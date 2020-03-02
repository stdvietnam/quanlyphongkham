Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports Report
Public Class FRM_ThanhToanBanLe
    Private dtb As New DataTable
    Private dt As New DataTable

    Private Sub FRM_ThanhToanBanLe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        Grbthongtin.Enabled = True
        Grbduyet.Enabled = True
        DateEdit1.DateTime = NgayGioServer()
        LoadDataTogrv()
        Load_Cmb(BusinessLogic.Data.GetDatatable("Select mabn,hotenbn,dienthoai,diachi from hosobn"), Seditbn, "mabn", "hotenbn")
        btnthutien.Enabled = False
    End Sub
    Private Sub LoadDataTogrv()
        Dim dts As New DataSet
        Dim strSQL As String = "select h.mabn,h.hotenbn+'('+ c.refno +')' as hotenbn,c.ID,cast(refno as int) as refno,s.masp,tensp,soluong,c.dongia,thanhtien,c.mabn,datelap as ngaylap,loaidv,isnull(Thanhtoan,0) as duyetbh,c.thutien from chi_tiet_new c inner join san_pham s on c.masp=s.masp  inner join hosobn h on c.mabn=h.mabn where thutien= '" & IIf(Checka.Checked, 1, 0) & "' and convert(char(10),datelap,101)='" & DateEdit1.DateTime.ToString("MM/dd/yyyy") & "' and  c.Kieuthu=1  and "
        If Me.Seditbn.EditValue <> "" Then
            GenSQL("c.mabn", MdlCommon.Kieukitu.Text, "=", "and", Me.Seditbn.EditValue, "", strSQL)
        End If
        If Me.txtsohoso.Text <> "0" Then
            GenSQL("c.refno", MdlCommon.Kieukitu.Text, "=", "and", Me.txtsohoso.Text, "", strSQL)
        End If
        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If
        dts = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing)
        dtb = dts.Tables(0)
        If dtb.Rows.Count > 0 Then
            grv.DataSource = dtb
        Else
            grv.DataSource = Nothing
        End If
    End Sub
    Private Sub LoadData()
        Dim dts As New DataSet
        Dim dt As New DataTable
        Dim strSQL As String = "select isnull(p.ChanDoanLamSang,'')as ChanDoanLamSang,h.MaBN,h.HoTenBN,DiaChiChiTiet as Diachi,Case when h.GioiTinh =1 then N'Nam' else N'Nữ' end as Gioitinh,case when YEAR(NgaySinh)=YEAR(GETDATE()) then 1 else YEAR(GETDATE())-YEAR(NgaySinh) end as Tuoi from PhieuKhamBenh p inner join HOSOBN h on p.MaBN=h.MaBN where sophieu='" & txtsohoso.Text & "'"
        dts = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing)
        dt = dts.Tables(0)
        txtcdls.Text = ""
        txtmabn.Text = ""
        txthoten.Text = ""
        txtdiachi.Text = ""
        txtgioitinh.Text = ""
        txttuoi.Text = ""
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0)(0) Is DBNull.Value Then
                txtcdls.Text = dt.Rows(0)(0)
                txtmabn.Text = dt.Rows(0)(1)
                txthoten.Text = dt.Rows(0)(2)
                If Not dt.Rows(0)(3) Is DBNull.Value Then
                    txtdiachi.Text = dt.Rows(0)(3)
                End If
                txtgioitinh.Text = dt.Rows(0)(4)
                txttuoi.Text = dt.Rows(0)(5)
            End If
        End If
    End Sub
    Private Sub Load_Hoso()
        Dim dts As New DataSet
        Dim dt As New DataTable
        Dim strSQL As String = "select h.MaBN,h.HoTenBN,DiaChiChiTiet as Diachi,Case when h.GioiTinh =1 then N'Nam' else N'Nữ' end as Gioitinh,case when YEAR(NgaySinh)=YEAR(GETDATE()) then 1 else YEAR(GETDATE())-YEAR(NgaySinh) end as Tuoi from HOSOBN h where mabn='" & Seditbn.EditValue & "'"
        dts = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing)
        dt = dts.Tables(0)
        txtcdls.Text = ""
        txtmabn.Text = ""
        txthoten.Text = ""
        txtdiachi.Text = ""
        txtgioitinh.Text = ""
        txttuoi.Text = ""
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0)(0) Is DBNull.Value Then
                txtmabn.Text = dt.Rows(0)(0)
                txthoten.Text = dt.Rows(0)(1)
                If Not dt.Rows(0)(2) Is DBNull.Value Then
                    txtdiachi.Text = dt.Rows(0)(2)
                End If
                txtgioitinh.Text = dt.Rows(0)(3)
                txttuoi.Text = dt.Rows(0)(4)
            End If
        End If
    End Sub
    Private Sub MyUpdate()
        Dim i As Integer
        Dim strSQL As String = ""
        For i = 0 To dtb.Rows.Count - 1
            If dtb.Rows(i)("duyetbh") = True Then
                strSQL = "Update Chi_tiet_new set ThanhToan=1 where ID='" & dtb.Rows(i)("ID") & "'"
            Else
                strSQL = "Update Chi_tiet_new set ThanhToan=0 where ID='" & dtb.Rows(i)("ID") & "'"
            End If
            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                'MsgBox("OK!", MsgBoxStyle.Information, "Thông báo....")
            Else
                MsgBox("Xảy ra lỗi!", MsgBoxStyle.Critical, "Thông báo....")
            End If
        Next
    End Sub
    Private Sub MyUpdate_Thutien()
        Dim i As Integer
        Dim strSQL As String = ""
        For i = 0 To dtb.Rows.Count - 1
            If dtb.Rows(i)("duyetbh") = True Then
                strSQL = "Update Chi_tiet_new set Thutien=1 where ID='" & dtb.Rows(i)("ID") & "'"
                Command_Exc(strSQL, CNNQLPHONGKHAM)
            End If
        Next
    End Sub

    Private Sub txtsohoso_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsohoso.KeyUp
        If e.KeyCode = Keys.Enter Then
            'LoadData()
            LoadDataTogrv()
            Me.btnCap_nhat.Enabled = True
        End If
    End Sub

    Private Sub chkall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkall.CheckedChanged
        Dim dr As DataRow
        For Each dr In dtb.Rows
            If chkall.Checked = True Then
                dr("duyetbh") = True
            Else
                dr("duyetbh") = False
            End If
        Next
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Checka.Checked = True Then
        Else
            If dtb.Rows.Count > 0 Then
                MyUpdate()
            End If
        End If
    End Sub
    Private Sub loaddata_rpt()
        Dim crDatabase As Database
        Dim crTables As Tables
        Dim crTable As Table
        Dim crTableLogOnInfo As TableLogOnInfo
        Dim crConnectionInfo As ConnectionInfo
        dt = New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Dim tongtien As Decimal
        tongtien = 0
        Dim sophieu As Long = 0
        Try
            sophieu = Long.Parse(txtsohoso.Text.Trim)
        Catch ex As Exception
            sophieu = 0
        End Try
        Try
            cmd.Connection = CNNQLPHONGKHAM
            cmd.CommandText = "sproc_tonghopdv_banle"
            cmd.CommandType = CommandType.StoredProcedure

            Dim paratersp As New SqlClient.SqlParameter
            paratersp.ParameterName = "@sophieu"
            paratersp.DbType = DbType.Int64
            paratersp.Value = sophieu
            cmd.Parameters.Add(paratersp)

            Dim paratermabn As New SqlClient.SqlParameter
            paratermabn.ParameterName = "@mabn"
            paratermabn.DbType = DbType.String
            paratermabn.Value = txtmabn.Text
            cmd.Parameters.Add(paratermabn)

            Dim paratertt As New SqlClient.SqlParameter
            paratertt.ParameterName = "@thutien"
            paratertt.DbType = DbType.Int16
            paratertt.Value = IIf(Checka.Checked, 1, 0)
            cmd.Parameters.Add(paratertt)

            Dim paraterngay As New SqlClient.SqlParameter
            paraterngay.ParameterName = "@ngay"
            paraterngay.DbType = DbType.DateTime
            paraterngay.Value = DateEdit1.DateTime.Date
            cmd.Parameters.Add(paraterngay)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                btnthutien.Enabled = True
            Else
                btnthutien.Enabled = False
            End If
            If dt.Rows.Count Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If Not dt.Rows(i)("thanhtien") Is DBNull.Value Then
                        tongtien += dt.Rows(i)("thanhtien")
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

        Dim sotien As Double

        Try
            sotien = Double.Parse(dt.Compute("SUM(thanhtien)", "").ToString())
        Catch ex As Exception
            sotien = 0
        End Try

        If tongtien <> 0 Then
            Me.txttongtien.Text = String.Format("{0:###,###}", sotien)
        Else
            Me.txttongtien.Text = 0
        End If

        Dim CatChuoi As String
        Dim Bangchu As String
        Dim arrCatChuoi(2) As String
        CatChuoi = Replace(txttongtien.Text, ",", "")
        arrCatChuoi = Split(CatChuoi, ".", -1, CompareMethod.Text)
        If UBound(arrCatChuoi) > 0 Then
            If arrCatChuoi(1) = 0 Then
                Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & "Không" & Space(1) & "đồng"
            Else
                Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & Mid(DoiSo(arrCatChuoi(1)), 1, Len(DoiSo(arrCatChuoi(1))) - 4) & "đồng"
            End If
        Else
            Bangchu = DoiSo(CatChuoi)
        End If
        Dim rpt As New rpt_Thutienbanthuoc
        rpt.SetDataSource(dt)
        rpt.SetParameterValue("sophieukham", CInt(Me.txtsohoso.EditValue))
        Try
            rpt.SetParameterValue("bangchu", Bangchu)
        Catch ex As Exception
            rpt.SetParameterValue("bangchu", "")
        End Try
        rpt.SetParameterValue("Title", "PHIẾU THU TIỀN THUỐC")
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

    Private Sub btnxem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxem.Click
        If Me.Seditbn.EditValue = "" Then
        Else
            LoadDataTogrv()
            loaddata_rpt()
            If Checka.Checked = True Then
                btnCap_nhat.Enabled = False
                btnthutien.Enabled = False
            Else
                btnCap_nhat.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnthutien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthutien.Click
        Dim sql As String
        If MsgBox("Bạn có chắc chắn muốn thu tiền lại bệnh nhân này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MyUpdate_Thutien()
            Dim dtb As DataTable
            Dim strSQL As String
            Dim sophieuTC As Int32
            Dim PTC As New frmPhieuTC
            Dim clsobj As New clsThuchi
            strSQL = "Select * from Ton_Quy WHERE MaQuy = '1TM' AND Convert(char(10),Ngay,101) ='" & Format(NgayGioServer(), "MM/dd/yyyy") & "'"
            dtb = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing).Tables(0)
            If dtb.Rows.Count > 0 Then
            Else
                clsobj.TinhTonQuy(CNNQLPHONGKHAM)
            End If
            If clsobj.ThemPhieuTC(Chuanhoa(txttongtien.Text), Chuanhoa(txttongtien.Text), clsobj.Lay_So_phieu(True), 1, 0, "TTHUOC", NgayGioServer().Date, "1TM", txtmabn.Text, txtmabn.Text, 0, 1, Chuanhoa(Me.txttongtien.Text), Chuanhoa(Me.txttongtien.Text), "Phiếu thu tiền thuốc số phiếu:" & Me.txtsohoso.Text & "", 0, 0, clsLoginObj.strUsername, clsLoginObj.strUsername, txtsohoso.Text, sophieuTC, sophieuTC, sophieuTC, CNNQLPHONGKHAM) = True Then
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show("Đã thu tiền !")
            btnthutien.Enabled = False
        Else
            btnthutien.Enabled = True
        End If
    End Sub
    Private Sub DateEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged
        Seditbn.EditValue = ""
        txtcdls.Text = ""
        txtmabn.Text = ""
        txthoten.Text = ""
        txtdiachi.Text = ""
        txtgioitinh.Text = ""
        txttuoi.Text = ""
        txtsohoso.Text = "0"
        LoadDataTogrv()
    End Sub

    Private Sub Seditbn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Seditbn.KeyUp
        If e.KeyCode = Keys.Delete Then
            Seditbn.EditValue = ""
            txtcdls.Text = ""
            txtmabn.Text = ""
            txthoten.Text = ""
            txtdiachi.Text = ""
            txtgioitinh.Text = ""
            txttuoi.Text = ""
        End If
    End Sub

    Private Sub Seditbn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seditbn.EditValueChanged
        If Seditbn.EditValue <> "" Then
            Load_Hoso()
            LoadDataTogrv()
        Else
            LoadDataTogrv()
        End If
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr.IsNew = False Then
                    Seditbn.EditValue = dr("mabn").ToString
                    txtsohoso.Text = dr("refno")
                    btnxem_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Seditbn.EditValue = ""
        txtcdls.Text = ""
        txtmabn.Text = ""
        txthoten.Text = ""
        txtdiachi.Text = ""
        txtgioitinh.Text = ""
        txttuoi.Text = ""
        txtsohoso.Text = "0"
        LoadDataTogrv()
        btnthutien.Enabled = False
        If Checka.Checked = True Then
            btnCap_nhat.Enabled = False
        Else
            btnCap_nhat.Enabled = True
        End If
    End Sub
End Class