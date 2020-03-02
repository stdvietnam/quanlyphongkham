Imports System.ComponentModel
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports System.Collections.Generic

Public Class frmThongKeCongNo
    Private Sub ThongKeCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_ComboBox("SELECT MaBN,HoTenBN,DiaChiChiTiet,DienThoai FROM dbo.HoSoBN", cmbMabn, CNNQLPHONGKHAM)
        Load_Data()
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Load_Data()
    End Sub

    Private Sub Load_Data()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim tongtien, thucthu, thucchi, congno As Double
        tongtien = 0
        thucthu = 0
        thucchi = 0
        congno = 0
        Dim dt As DataTable = BusinessLogic.Data.GetDataset("spThongkecongno", New Generic.List(Of String) From {"mabn"}, New Generic.List(Of Object) From {cmbMabn.EditValue}).Tables(0)
        grdDanhSach.DataSource = dt
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                tongtien += r("TongTien")
                thucthu += r("TongThucThu")
                thucchi += r("TongThucChi")
                congno += r("CongNo")
            Next
        End If
        txtTongTien.Text = tongtien
        txtThucThu.Text = thucthu
        txtThucChi.Text = thucchi
        txtCongNo.Text = congno
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub cmbMabn_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbMabn.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            cmbMabn.EditValue = ""
        End If
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim Link As New PrintableComponentLink(New PrintingSystem())
        Link.Component = grdDanhSach
        AddHandler Link.CreateMarginalHeaderArea, AddressOf Link_CreateMarginalHeaderArea
        Link.PaperKind = Printing.PaperKind.A4
        Link.Landscape = True
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Sub Link_CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick() As PageInfoBrick = {
            e.Graph.DrawPageInfo(PageInfo.None, "THỐNG KÊ CÔNG NỢ KHÁCH HÀNG", Color.DarkBlue, New RectangleF(0, 0, 500, 35), BorderSide.None)
        }
        Brick(0).LineAlignment = BrickAlignment.Center
        Brick(0).Alignment = BrickAlignment.Center
        Brick(0).AutoWidth = True
        Brick(0).Font = New System.Drawing.Font("Arial", 17.0F)
    End Sub

    Private Sub RepositoryItemButtonEdit_LapPhieuThu_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit_LapPhieuThu.ButtonClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If (dr("CongNo") > 0) Then
                Dim frm As New frmPhieuTC
                frm.Name = "frmThuTienMat"
                frm.Text = "Phiếu thu tiền mặt"
                frm.Label3.Text = "PHIẾU THU CÔNG NỢ"
                frm.lbnQuy.Text = "Thu vào quỹ"
                frm.lblDonvitc.Text = "Đơn vị trả"
                frm.blnLoaiphieu = True
                frm.blnTiengui = False
                frm.thucthu = dr("CongNo")
                frm.loaithuchi = "TCN"
                frm.mabn = dr("MaBN")
                frm.isHiden = True
                frm.StartPosition = FormStartPosition.CenterScreen
                Dim frm1 As Form
                For Each frm1 In Me.OwnedForms
                    If (frm1.Name = frm.Name) Then
                        frm1.Activate()
                        Exit Sub
                    End If
                Next
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
        End If
    End Sub
End Class