Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports Report
Public Class frm_bcdoanhthuchitiet
    Private dt As New DataTable
    Private k As Int16
    Private Sub loaddata()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim crDatabase As Database
        Dim crTables As Tables
        Dim crTable As Table
        Dim crTableLogOnInfo As TableLogOnInfo
        Dim crConnectionInfo As ConnectionInfo

        xetngay()
        dt = BusinessLogic.Data.GetDataset("sproc_BCChitietdoanhthu", New Generic.List(Of String) From {"@tungay", "@denngay", "@maphong"}, New Generic.List(Of Object) From {dtpTu_ngay.DateTime, dtpTu_ngay.DateTime, IIf(cmbphong.EditValue Is Nothing, "", cmbphong.EditValue)}).Tables(0)

        Dim rpt As New rpt_bcdoanhthuchitiet
        rpt.SetDataSource(dt)
        rpt.SetParameterValue("@tungay", dtpTu_ngay.DateTime)
        rpt.SetParameterValue("@denngay", dtpDen_ngay.DateTime)
        rpt.SetParameterValue("@maphong", cmbphong.EditValue)
        crDatabase = rpt.Database
        crConnectionInfo = New ConnectionInfo

        With crConnectionInfo
            .ServerName = P_Server
            .DatabaseName = P_Database
            .UserID = P_Username
            .Password = P_Password
        End With
        crTables = crDatabase.Tables
        For Each crTable In crTables
            crTableLogOnInfo = crTable.LogOnInfo
            crTableLogOnInfo.ConnectionInfo = crConnectionInfo
            crTable.ApplyLogOnInfo(crTableLogOnInfo)
        Next
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
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
        Load_ComboBox("Select maphong,tenphong From phong_ban", cmbphong, CNNQLPHONGKHAM)
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

    Private Sub cmbphong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbphong.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmbphong.EditValue = Nothing
        End If
    End Sub
End Class