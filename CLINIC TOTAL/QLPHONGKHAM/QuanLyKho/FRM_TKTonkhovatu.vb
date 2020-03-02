Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports DevExpress.XtraPrinting

Public Class FRM_TKTonkhovatu
    Private dt As New DataTable
    Private Sub Load_CnnInfor()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        dt = BusinessLogic.Data.GetDataset("TK_KhoDuoc_TongHop", New Generic.List(Of String) From {"@tungay", "@denngay", "@kho", "@thuoc", "@nhom", "@manhomxetnghiem"}, New Generic.List(Of Object) From {Me.dtTuNgay.DateTime, Me.dtDenNgay.DateTime, Me.cmbkho.EditValue, Me.cmbTenThuoc.EditValue, Me.cmbnhom.EditValue, ""}).Tables(0)
        If dt.Rows.Count > 0 Then
            dt.Columns.Add("STT", GetType(Integer))
            Dim dem As Integer = 0
            For Each dr As DataRow In dt.Rows
                dem = dem + 1
                dr("STT") = dem
            Next
        End If
        grdDanhSach.DataSource = dt.DefaultView()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If cmbkho.EditValue = "" Then
            MsgBox("Bạn chưa chọn kho", MsgBoxStyle.Critical, "Thông báo...")
            Return
        End If
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
        Load_ComboBox("Select makho,tenkho from kho_hang where makho=N'KVT'", cmbkho, CNNQLPHONGKHAM)
        Load_ComboBox("Select Manhom[Mã],Tennhom[Tên nhóm] from nhom_sp where Manhom='19' order by manhom", Me.cmbnhom, CNNQLPHONGKHAM)
        Me.cmbkho.EditValue = "KVT"
        Me.cmbnhom.EditValue = "19"
    End Sub

    Private Sub cmbnhom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnhom.EditValueChanged
        If cmbnhom.EditValue <> "" Then
            Load_ComboBox("Select Masp,Tensp from San_Pham where Manhom=N'" & cmbnhom.EditValue & "'", cmbTenThuoc, CNNQLPHONGKHAM)
        Else
            Load_ComboBox("Select Masp,Tensp from San_Pham where Loai in (0)", cmbTenThuoc, CNNQLPHONGKHAM)
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
        Dim Brick() As PageInfoBrick = {e.Graph.DrawPageInfo(PageInfo.None, "THỐNG KÊ TỒN KHO VẬT TƯ", Color.DarkBlue, New RectangleF(0, 0, 500, 35), BorderSide.None), e.Graph.DrawPageInfo(PageInfo.None, "Từ ngày " & dtTuNgay.DateTime.ToString("dd/MM/yyyy") & " đến ngày " & dtDenNgay.DateTime.ToString("dd/MM/yyyy") & "", Color.DarkBlue, New RectangleF(0, 0, 100, 20), BorderSide.None)}
        Brick(0).LineAlignment = BrickAlignment.Center
        Brick(0).Alignment = BrickAlignment.Center
        Brick(0).AutoWidth = True
        Brick(0).Font = New System.Drawing.Font("Arial", 16.0F, FontStyle.Bold)

        Brick(1).LineAlignment = BrickAlignment.Far
        Brick(1).Alignment = BrickAlignment.Center
        Brick(1).AutoWidth = True
    End Sub
End Class