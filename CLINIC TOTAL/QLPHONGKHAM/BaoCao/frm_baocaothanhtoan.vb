Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports DevExpress.XtraPrinting

Public Class frm_baocaothanhtoan
    Private dt As New DataTable
    Private k As Int16
    Private Sub loaddata()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim dt As DataTable = BusinessLogic.Data.GetDataset("pro_BCtonghop", New Generic.List(Of String) From {"tungay", "denngay", "doituong"}, New Generic.List(Of Object) From {dtpTu_ngay.DateTime, dtpDen_ngay.DateTime, IIf(cmbDoituong.EditValue Is Nothing, 0, cmbDoituong.EditValue)}).Tables(0)
        grdDanhSach.DataSource = dt.DefaultView
    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        loaddata()
    End Sub

    Private Sub frm_baocaothanhtoan_noitru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.dtpDen_ngay.DateTime = NgayGioServer().Date
        Me.dtpTu_ngay.DateTime = NgayGioServer().Date
        Load_ComboBox("Select id[Mã],doituong[Đối tượng] From DM_DOITUONG", Me.cmbDoituong, CNNQLPHONGKHAM)
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
    Private Sub xetngay()
        If Me.dtpTu_ngay.DateTime > Me.dtpDen_ngay.DateTime Then
            MsgBox("Từ ngày không thể lớn hơn đến ngày", MsgBoxStyle.Critical, "Thông báo...")
            Me.dtpTu_ngay.DateTime = Me.dtpDen_ngay.DateTime
        End If
    End Sub

    Private Sub cmbDoituong_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbDoituong.KeyDown
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbDoituong.EditValue = Nothing
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
        Dim Brick() As PageInfoBrick = {e.Graph.DrawPageInfo(PageInfo.None, "THỐNG KÊ DOANH THU TỔNG HỢP", Color.DarkBlue, New RectangleF(0, 0, 500, 35), BorderSide.None), e.Graph.DrawPageInfo(PageInfo.None, "Từ ngày " & dtpTu_ngay.DateTime.ToString("dd/MM/yyyy") & " đến ngày " & dtpDen_ngay.DateTime.ToString("dd/MM/yyyy") & "", Color.DarkBlue, New RectangleF(0, 0, 100, 20), BorderSide.None)}
        Brick(0).LineAlignment = BrickAlignment.Center
        Brick(0).Alignment = BrickAlignment.Center
        Brick(0).AutoWidth = True
        Brick(0).Font = New System.Drawing.Font("Arial", 16.0F, FontStyle.Bold)

        Brick(1).LineAlignment = BrickAlignment.Far
        Brick(1).Alignment = BrickAlignment.Center
        Brick(1).AutoWidth = True
    End Sub
End Class