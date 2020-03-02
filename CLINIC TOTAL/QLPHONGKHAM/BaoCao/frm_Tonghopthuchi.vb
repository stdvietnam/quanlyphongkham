Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Collections.Generic
Imports DevExpress.XtraPrinting

Public Class frm_Tonghopthuchi
    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Load_CnnInfor()
    End Sub
    Private Sub Load_CnnInfor()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim dt As DataTable = New DataTable()
        dt = BusinessLogic.Data.GetDataset("rpt_PhieuTongHopThuChi", Data.CommandType.StoredProcedure, New List(Of String) From {"tungay", "denngay", "mabn", "masp", "nguoilap", "bacsi"}, New List(Of Object) From {dtTungay.DateTime, dtDenngay.DateTime, cmbMaBn.EditValue, cmbVattu.EditValue, cmbNguoiLap.EditValue, cmbThucHien.EditValue}).Tables(0)
        If dt.Rows.Count > 0 Then
            dt.Columns.Add("STT", GetType(Integer))
            Dim dem As Integer = 0
            For Each dr As DataRow In dt.Rows
                dem = dem + 1
                dr("STT") = dem
            Next
        End If
        gridDanhSach.DataSource = dt.DefaultView
    End Sub

    Private Sub frmMat_Tonghopthuchi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        dtTungay.DateTime = NgayGioServer().Date
        dtDenngay.DateTime = NgayGioServer().Date
        Load_ComboBox("SELECT MaBN,HoTenBN FROM HOSOBN", cmbMaBn, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Masp,Tensp FROM San_Pham", cmbVattu, CNNQLPHONGKHAM)
        Load_ComboBox("select id[Mã],doituong[Đối tượng] from DM_DOITUONG", Me.cmbDoituong, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT username[Mã],hoten[Họ tên] From nguoi_su_dung", Me.cmbNguoiLap, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT username[Mã],hoten[Họ tên] From nguoi_su_dung", Me.cmbThucHien, CNNQLPHONGKHAM)
    End Sub

    Private Sub cmbVattu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbVattu.KeyDown
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbVattu.EditValue = ""
        End If
    End Sub

    Private Sub cmbMaBn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMaBn.KeyDown
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbMaBn.EditValue = ""
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub cmbDoituong_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDoituong.KeyDown
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbDoituong.EditValue = Nothing
        End If
    End Sub

    Private Sub cmbNguoiLap_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNguoiLap.KeyDown
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbThucHien.EditValue = ""
        End If
    End Sub

    Private Sub cmbThucHien_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbThucHien.KeyDown
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbThucHien.EditValue = ""
        End If
    End Sub

    Private Sub btnInTk_Click(sender As Object, e As EventArgs) Handles btnInTk.Click
        Dim Link As New PrintableComponentLink(New PrintingSystem())
        Link.Component = gridDanhSach
        AddHandler Link.CreateMarginalHeaderArea, AddressOf Link_CreateMarginalHeaderArea
        Link.PaperKind = Printing.PaperKind.A4
        Link.Landscape = True
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub
    Sub Link_CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick() As PageInfoBrick = {e.Graph.DrawPageInfo(PageInfo.None, "THỐNG KÊ DỊCH VỤ THEO KHÁCH HÀNG", Color.DarkBlue, New RectangleF(0, 0, 500, 35), BorderSide.None), e.Graph.DrawPageInfo(PageInfo.None, "Từ ngày " & dtTungay.DateTime.ToString("dd/MM/yyyy") & " đến ngày " & dtDenngay.DateTime.ToString("dd/MM/yyyy") & "", Color.DarkBlue, New RectangleF(0, 0, 100, 20), BorderSide.None)}

        Brick(0).LineAlignment = BrickAlignment.Center
        Brick(0).Alignment = BrickAlignment.Center
        Brick(0).AutoWidth = True
        Brick(0).Font = New System.Drawing.Font("Arial", 17.0F)

        Brick(1).LineAlignment = BrickAlignment.Far
        Brick(1).Alignment = BrickAlignment.Center
        Brick(1).AutoWidth = True
    End Sub
End Class