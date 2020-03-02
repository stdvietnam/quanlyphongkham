Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports System.Collections.Generic

Public Class frm_LichSuBenhNhan
    Public ls_mabn As String = ""
    Private dt As New DataTable

    Private Sub load_reports()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        xetngay()
        dt = BusinessLogic.Data.GetDataset("LSkhamchuabenh", CommandType.StoredProcedure, New List(Of String) From {"mabn", "tungay", "denngay", "is_tatca"}, New List(Of Object) From {Seditbn.EditValue, dtpTu_ngay.DateTime, dtpDen_ngay.DateTime, IIf(chk_TatCa.Checked, 1, 0)}).Tables(0)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        load_reports()
    End Sub

    Private Sub frm_baocaothanhtoan_noitru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.dtpDen_ngay.DateTime = NgayGioServer()
        Me.dtpTu_ngay.DateTime = NgayGioServer()
        Load_ComboBox("Select mabn,hotenbn,dienthoai,diachi from hosobn", Seditbn, CNNQLPHONGKHAM)
        If ls_mabn <> "" Then
            Me.dtpTu_ngay.DateTime = DateTime.Now
            Me.dtpDen_ngay.DateTime = DateTime.Now
            Me.Seditbn.EditValue = ls_mabn
            load_reports()
        End If
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub xetngay()
        If Me.dtpTu_ngay.DateTime > Me.dtpDen_ngay.DateTime Then
            MsgBox("Từ ngày không thể lớn hơn đến ngày", MsgBoxStyle.Critical, "THÔNG BÁO")
            Me.dtpTu_ngay.DateTime = Me.dtpDen_ngay.DateTime
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        Dim dr As DataRowView
        Dim strSql As String = ""
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr("LoaiDV") = Integer.Parse(NhomDV.THUOC) Then

                ElseIf dr("LoaiDV") = Integer.Parse(NhomDV.KHAMBENH) Then
                    Dim frm As New FRM_PhieuKham
                    frm.xemphieu = True
                    If dr.IsNew = False Then
                        frm.IDPhieukham &= dr("SoPhieu")
                    End If
                    Dim frm1 As Form
                    frm.StartPosition = FormStartPosition.CenterScreen
                    For Each frm1 In Me.OwnedForms
                        If (frm1.Name = frm.Name) Then
                            frm1.Activate()
                            Exit Sub
                        End If
                    Next
                    Me.AddOwnedForm(frm)
                    frm.Show()
                ElseIf dr("LoaiDV") = Integer.Parse(NhomDV.XETNGHIEM) Then
                    Dim frm As New FRM_KECANLAMSANG
                    frm.Text = "DỊCH VỤ XÉT NGHIỆM"
                    frm.IDSophieu = dr("RefNo").ToString()
                    frm.IDPhieuxuat = Integer.Parse(dr("SoPhieu").ToString())
                    frm.load_all = False
                    frm.duoclam = 1
                    frm.loai = Integer.Parse(NhomDV.XETNGHIEM).ToString()
                    frm.type = Integer.Parse(LoaiDV.XETNGHIEM).ToString()
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.Show()
                Else
                    Dim url_file As String = ""
                    Dim dt As DataTable
                    strSql = String.Format("Select MaSp,Manhom,MaNhomXetnghiem,Url_File From San_Pham Where MaSp=N'{0}'", dr("Masp"))
                    dt = BusinessLogic.Data.GetDataset(strSql).Tables(0)
                    If dt.Rows.Count > 0 Then
                        url_file = dt.Rows(0)("Url_File").ToString()
                        Dim frm As New DocBrowser
                        frm.Name = "DocBrowser"
                        frm.fileName = url_file
                        frm.cmbMabn.EditValue = dr("mabn").ToString()
                        frm.txtSophieukham.EditValue = dr("SoPhieu").ToString()
                        frm.txtSophieudv.EditValue = dr("RefNo").ToString()
                        frm.cmbLoaiDV.EditValue = dr("MaNhomXetnghiem").ToString()
                        frm.cmbDichvu.EditValue = dr("MaSp").ToString()

                        strSql = String.Format("SELECT ChanDoanLamSang FROM Chi_tiet_NEW Where RefNo=N'{0}' and LoaiDV in ({1}) Order by id ", dr("RefNo").ToString(), dr("LoaiDV"))
                        dt = BusinessLogic.Data.GetDataset(strSql).Tables(0)
                        If Not dt.Rows(0)("ChanDoanLamSang") Is DBNull.Value Then
                            frm.txtChandoan.EditValue = dt.Rows(0)("ChanDoanLamSang")
                        Else
                            frm.txtChandoan.EditValue = ""
                        End If
                        frm.type = dr("LoaiDV").ToString()
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
            End If
        End If

    End Sub

End Class