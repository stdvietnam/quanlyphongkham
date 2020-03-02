Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports DevExpress.XtraPrinting

Public Class frmTKTonKhoCLS
    Inherits System.Windows.Forms.Form

    Private Sub Load_CnnInfor()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim dt As DataTable = New DataTable()
        dt = BusinessLogic.Data.GetDataset("TK_VTTH_Phong", CommandType.StoredProcedure, New Generic.List(Of String) From {"@tungay", "@denngay", "@phong", "@thuoc", "@nhom"}, New Generic.List(Of Object) From {dtTuNgay.DateTime, dtDenNgay.DateTime, cmbphong.EditValue, cmbTenThuoc.EditValue, cmbnhom.EditValue}).Tables(0)
        If dt.Rows.Count > 0 Then
            dt.Columns.Add("STT", GetType(Integer))
            Dim dem As Integer = 0
            For Each dr As DataRow In dt.Rows
                dem = dem + 1
                dr("STT") = dem
            Next
        End If
        grdDanhSach.DataSource = dt.DefaultView
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Load_CnnInfor()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub frmTKTonKhoKhoaDuoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCombobox()
    End Sub
    Private Sub LoadCombobox()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        dtTuNgay.DateTime = NgayGioServer().Date
        dtDenNgay.DateTime = NgayGioServer().Date
        Load_ComboBox("Select maphong,tenphong from phong_ban where Loai not in (1,8)", cmbphong, CNNQLPHONGKHAM)
        Load_ComboBox("Select Manhom[Mã],TenNhom[Tên nhóm] from Tb_NhomXetNghiem where Active=1 and Loai=9 order by MaNhom ", Me.cmbnhom, CNNQLPHONGKHAM)
        cmbnhom.EditValue = "VTTH"
    End Sub

    Private Sub cmbnhom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnhom.EditValueChanged
        If cmbnhom.EditValue <> "" Then
            Load_ComboBox("Select Masp,Tensp from San_Pham where Manhomxetnghiem=N'" & cmbnhom.EditValue & "'", cmbTenThuoc, CNNQLPHONGKHAM)
        Else
            Load_ComboBox("Select Masp,Tensp from San_Pham", cmbTenThuoc, CNNQLPHONGKHAM)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Link As New PrintableComponentLink(New PrintingSystem())
        Link.Component = grdDanhSach
        AddHandler Link.CreateMarginalHeaderArea, AddressOf Link_CreateMarginalHeaderArea
        Link.PaperKind = Printing.PaperKind.A4
        Link.Landscape = True
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Sub Link_CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick() As PageInfoBrick = {e.Graph.DrawPageInfo(PageInfo.None, "THỐNG KÊ TỒN KHO PHÒNG BAN", Color.DarkBlue, New RectangleF(0, 0, 500, 35), BorderSide.None), e.Graph.DrawPageInfo(PageInfo.None, "Từ ngày " & dtTuNgay.DateTime.ToString("dd/MM/yyyy") & " đến ngày " & dtDenNgay.DateTime.ToString("dd/MM/yyyy") & "", Color.DarkBlue, New RectangleF(0, 0, 100, 20), BorderSide.None)}
        Brick(0).LineAlignment = BrickAlignment.Center
        Brick(0).Alignment = BrickAlignment.Center
        Brick(0).AutoWidth = True
        Brick(0).Font = New System.Drawing.Font("Arial", 16.0F, FontStyle.Bold)

        Brick(1).LineAlignment = BrickAlignment.Far
        Brick(1).Alignment = BrickAlignment.Center
        Brick(1).AutoWidth = True
    End Sub
End Class