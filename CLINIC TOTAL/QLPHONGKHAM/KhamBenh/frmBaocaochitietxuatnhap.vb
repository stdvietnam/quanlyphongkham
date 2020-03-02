Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmBaocaochitietxuatnhap

    Private Sub frmBaocaochitietxuatnhap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        dtpTu_ngay.DateTime = DateTime.Now
        dtpDen_ngay.DateTime = DateTime.Now
        Load_ComboBox("Select MaSp[Mã],TenSp[Tên sp] From San_Pham Where Manhom in (10,19)", cmbSanpham, CNNQLPHONGKHAM)
        cmbKieu.SelectedIndex = 0
    End Sub

    Private Sub btnXem_Click(sender As System.Object, e As System.EventArgs) Handles btnXem.Click
        loadData()
    End Sub

    Sub loadData()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        Application.CurrentCulture = myCIintl
        Dim dt As DataTable = BusinessLogic.Data.GetDataset("BcChitietxuatnhap", New Generic.List(Of String) From {"@tungay", "@denngay", "@masp", "@kieu"}, New Generic.List(Of Object) From {dtpTu_ngay.DateTime, dtpDen_ngay.DateTime, cmbSanpham.EditValue, IIf(cmbKieu.SelectedIndex = 0, False, True)}).Tables(0)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class