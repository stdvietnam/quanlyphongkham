Imports DevExpress.XtraPrinting
Imports System.Collections.Generic

Public Class frm_Baocaohansudungthuoc
    Private dt As New DataTable
    Private Sub frm_Baocaohansudungthuoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        dtpTu_ngay.DateTime = DateTime.Now
        dtpDen_ngay.DateTime = DateTime.Now
        Load_ComboBox("SELECT MaSp[Mã],TenSp[Tên sp] FROM San_Pham WHERE Manhom=10", cmbSanpham, CNNQLPHONGKHAM)
    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Load_Data()
    End Sub

    Private Sub Load_Data()
        Dim dt As DataTable = BusinessLogic.Data.GetDataset("proc_HanSuDungThuoc", New List(Of String) From {"TuNgay", "DenNgay", "Kho", "Masp"}, New List(Of Object) From {dtpTu_ngay.DateTime, dtpDen_ngay.DateTime, "KT", cmbSanpham.EditValue}).Tables(0)
        grdHanSuDungThuoc.DataSource = dt
    End Sub

    Private Sub xetngay()
        If Me.dtpTu_ngay.DateTime > Me.dtpDen_ngay.DateTime Then
            MsgBox("Từ ngày không thể lớn hơn đến ngày", MsgBoxStyle.Critical, "Thông báo...")
            Me.dtpTu_ngay.DateTime = Me.dtpDen_ngay.DateTime
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
    Private Sub GridView1_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            If e.Column.FieldName = "NgayConLai" Then
                If Not View.GetRowCellValue(e.RowHandle(), "NgayConLai") Is DBNull.Value Then
                    Dim songayconlai As Integer = Integer.Parse(View.GetRowCellValue(e.RowHandle(), "NgayConLai").ToString())
                    If songayconlai < 90 Then 'Canh bao han truoc 90 ngay
                        e.Appearance.BackColor = Color.Salmon
                        e.Appearance.BackColor2 = Color.SeaShell
                    End If
                End If
            ElseIf e.Column.FieldName = "TonCuoi" Then
                If Not View.GetRowCellValue(e.RowHandle(), "TonCuoi") Is DBNull.Value Then
                    Dim toncuoi As Double = Double.Parse(View.GetRowCellValue(e.RowHandle(), "TonCuoi").ToString())
                    Dim sltoithieu As Double = Double.Parse(View.GetRowCellValue(e.RowHandle(), "SLToiThieu").ToString())
                    If toncuoi = sltoithieu Then
                        e.Appearance.BackColor = Color.Salmon
                        e.Appearance.BackColor2 = Color.SeaShell
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnInPhieu_Click(sender As Object, e As EventArgs) Handles btnInPhieu.Click
        Dim Link As New PrintableComponentLink(New PrintingSystem())
        Link.Component = grdHanSuDungThuoc
        AddHandler Link.CreateMarginalHeaderArea, AddressOf Link_CreateMarginalHeaderArea
        Link.PaperKind = Printing.PaperKind.A4
        Link.Landscape = False
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub
    Sub Link_CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick() As PageInfoBrick = {e.Graph.DrawPageInfo(PageInfo.None, "THỐNG KÊ, CẢNH BÁO HẠN SỬ DỤNG THUỐC", Color.DarkBlue, New RectangleF(0, 0, 500, 35), BorderSide.None), e.Graph.DrawPageInfo(PageInfo.None, "Ngày in: " & DateTime.Now.ToString("dd/MM/yyyy") & "", Color.DarkBlue, New RectangleF(0, 0, 100, 20), BorderSide.None)}
        Brick(0).LineAlignment = BrickAlignment.Center
        Brick(0).Alignment = BrickAlignment.Center
        Brick(0).AutoWidth = True
        Brick(0).Font = New System.Drawing.Font("Arial", 17.0F)

        Brick(1).LineAlignment = BrickAlignment.Far
        Brick(1).Alignment = BrickAlignment.Center
        Brick(1).AutoWidth = True
    End Sub
End Class