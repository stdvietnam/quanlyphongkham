Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports BusinessLogic.Data
Imports Report
Public Class FRM_ThanhToanNhanDan
    Private dtb As New DataTable
    Private dt As New DataTable
    Private soHoSo As Integer = 0
    Private maBenhNhan As String = ""
    Private dtbhyt As New DataTable

    Private Sub FRM_GIAMDINHBAOHIEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        Grbthongtin.Enabled = True
        Grbduyet.Enabled = True
        dtNgayThu.DateTime = DateTime.Now.Date
        loadcombox()
        LoadDataTogrv()
        btnthutien.Enabled = False
        'btnCap_nhat_Click(Nothing, Nothing)
    End Sub

    Private Sub loadcombox()
        Load_ComboBox("SELECT mabn,hotenbn,dienthoai,diachi FROM HOSOBN", cmbMaBn, CNNQLPHONGKHAM)
        Load_ComboBox(String.Format("SELECT SoPhieu,h.MaBN,h.HoTenBN FROM PHIEUKHAMBENH p Join HOSOBN h on p.Mabn=h.MaBN Where DATEDIFF(d,NgayLap,'{0}')=0", dtNgayThu.DateTime.ToString("MM/dd/yyyy")), cmbSoHoSo, CNNQLPHONGKHAM, True)
    End Sub

    Private Sub LoadDataTogrv()
        Try
            Dim soPhieu As Integer = 0
            If Not cmbSoHoSo.EditValue Is Nothing Then
                soPhieu = Integer.Parse("0" + cmbSoHoSo.EditValue.ToString())
            End If
            dtb = BusinessLogic.Data.GetDataset("DanhSach_ThuTien_DichVu", CommandType.StoredProcedure, New Generic.List(Of String) From {"mabn", "ngay", "is_thutien", "sophieu"}, New Generic.List(Of Object) From {cmbMaBn.EditValue.ToString(), dtNgayThu.DateTime, IIf(Checka.Checked, 1, 0), soPhieu}).Tables(0)
            If dtb.Rows.Count > 0 Then
                grv.DataSource = dtb
            Else
                grv.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadData()
        Dim dts As New DataSet
        Dim dt As New DataTable
        Dim sql As String = String.Format("Select ISNULL(p.ChanDoanLamSang, N'') as ChanDoanLamSang,h.MaBN,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,Case When h.GioiTinh=1 then N'Nam' else N'Nữ' end as Gioitinh,NgaySinh,p.Doituong From PhieuKhamBenh p join HOSOBN h on p.MaBN=h.MaBN where sophieu='{0}'", cmbSoHoSo.EditValue)
        dts = BusinessLogic.Data.GetDataset(sql)
        dt = dts.Tables(0)
        ClearText()
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0)(0) Is DBNull.Value Then
                txtcdls.Text = dt.Rows(0)("ChanDoanLamSang").ToString()
                txtmabn.Text = dt.Rows(0)("MaBN").ToString()
                cmbMaBn.EditValue = dt.Rows(0)("MaBN").ToString()
                If Not dt.Rows(0)("DienThoai") Is DBNull.Value Then
                    txtDienThoai.Text = dt.Rows(0)("DienThoai").ToString()
                End If
                If Not dt.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                    txtdiachi.Text = dt.Rows(0)("DiaChiChiTiet").ToString()
                End If
                txtgioitinh.Text = dt.Rows(0)("Gioitinh").ToString()
                dtNgaySinh.DateTime = dt.Rows(0)("NgaySinh")
            End If
        End If
    End Sub

    Private Sub Load_Hoso()
        Dim dt As New DataTable
        Dim soPhieu As Int32 = 0
        If Not cmbSoHoSo.EditValue Is Nothing Then
            soPhieu = Integer.Parse("0" + cmbSoHoSo.EditValue.ToString())
        End If
        Dim strSQL As String = String.Empty
        strSQL = String.Format("Select h.MaBN,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,g.Ten as Gioitinh,NgaySinh,p.Doituong,h.SoTheBHYT,h.TyLeChiTra,h.TuNgay,h.DenNgay,p.TuyenBN ")
        strSQL &= String.Format("From HOSOBN h left join PHIEUKHAMBENH p on h.MaBN=p.MaBN join DM_GIOITINH g on g.ID=h.GioiTinh Where h.mabn='{0}' And (p.SoPhieu={1} or {2}=0)", cmbMaBn.EditValue, soPhieu, soPhieu)
        dt = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        If dt.Rows.Count > 0 Then
            txtmabn.Text = dt.Rows(0)("MaBN").ToString()
            txtDienThoai.Text = dt.Rows(0)("DienThoai").ToString()
            If Not dt.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                txtdiachi.Text = dt.Rows(0)("DiaChiChiTiet").ToString()
            End If
            If Not dt.Rows(0)("Gioitinh") Is DBNull.Value Then
                txtgioitinh.Text = dt.Rows(0)("Gioitinh").ToString()
            End If
            If Not dt.Rows(0)("NgaySinh") Is DBNull.Value Then
                dtNgaySinh.DateTime = dt.Rows(0)("NgaySinh")
            End If
        Else
            ClearText()
        End If
    End Sub

    Private Sub MyUpdate()
        Dim i As Integer
        Dim strSQL As String = ""
        For i = 0 To dtb.Rows.Count - 1
            If dtb.Rows(i)("duyetbh") = True Then
                strSQL = String.Format("Update Chi_tiet_new set ThanhToan=1 where ID='{0}'", dtb.Rows(i)("ID"))
            Else
                strSQL = String.Format("Update Chi_tiet_new set ThanhToan=0 where ID='{0}'", dtb.Rows(i)("ID"))
            End If
            Command_Exc(strSQL, CNNQLPHONGKHAM)
        Next
    End Sub

    Private Sub MyUpdate_Thutien()
        Dim i As Integer
        Dim strSQL As String = ""
        For i = 0 To dtb.Rows.Count - 1
            If dtb.Rows(i)("duyetbh") = True Then
                strSQL = String.Format("Update Chi_tiet_new set Thutien=1,chietkhau={0} where ID='{1}'", Double.Parse(txtck.Text), dtb.Rows(i)("ID"))
                If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                    If dtb.Rows(i)("loaidv") = Integer.Parse(NhomDV.THUOC) Then
                        strSQL = String.Format("Update phieukhambenh set Thutien=1 where sophieu='{0}'", dtb.Rows(i)("idsophieu"))
                        Command_Exc(strSQL, CNNQLPHONGKHAM)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub txtsohoso_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSoHoSo.KeyUp
        If e.KeyCode = Keys.Enter Then
            LoadData()
            LoadDataTogrv()
            Me.btnCap_nhat.Enabled = True
        End If
    End Sub

    Private Sub chkall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkall.CheckedChanged
        Dim dr As DataRow
        For Each dr In dtb.Rows
            If chkall.Checked Then
                dr("duyetbh") = True
            Else
                dr("duyetbh") = False
            End If
        Next
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Checka.Checked Then
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
        Dim cmd As New SqlCommand
        Dim tongtien As Decimal = 0
        Me.cmbSoHoSo.EditValue = soHoSo
        Me.cmbMaBn.EditValue = maBenhNhan
        dt = BusinessLogic.Data.GetDataset("sproc_tonghopdv_NhanDan", CommandType.StoredProcedure, New Generic.List(Of String) From {"@sophieu", "@mabn", "@thutien", "@ngay"}, New Generic.List(Of Object) From {soHoSo, cmbMaBn.EditValue, IIf(Checka.Checked, 1, 0), dtNgayThu.DateTime.Date}).Tables(0)

        If dt.Rows.Count > 0 Then
            btnthutien.Enabled = True
            'For i As Integer = 0 To dt.Rows.Count - 1
            '    If Not dt.Rows(i)("thanhtien") Is DBNull.Value Then
            '        tongtien += dt.Rows(i)("thanhtien")
            '    End If
            'Next
            Dim sotien As Double = 0
            Try
                sotien = Double.Parse(dt.Compute("SUM(thanhtien)", "").ToString())
            Catch ex As Exception
                sotien = 0
            End Try

            If sotien <> 0 Then
                Me.txttienhang.Text = String.Format("{0:###,###}", sotien)
                Me.txttongtien.Text = String.Format("{0:###,###}", sotien - sotien * Double.Parse(Chuanhoa(txtck.Text)) / 100)
            Else
                Me.txttienhang.Text = "0"
                Me.txttongtien.Text = "0"
            End If

            Dim CatChuoi As String
            Dim Bangchu As String
            Dim arrCatChuoi(2) As String
            CatChuoi = Chuanhoa(txtThucThu.Text)
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

            Dim rpt As New rpt_TonghopThuChi_NhanDan_A5
            rpt.SetDataSource(dt)
            rpt.SetParameterValue("sophieukham", cmbSoHoSo.EditValue)
            rpt.SetParameterValue("Chietkhau", Double.Parse(Chuanhoa(txtck.Text)))
            rpt.SetParameterValue("TienThucThu", Double.Parse(Chuanhoa(txtThucThu.Text)))
            rpt.SetParameterValue("Tuoi", dtNgaySinh.DateTime.ToString("dd/MM/yyyy"))
            rpt.SetParameterValue("Khoa", "")
            rpt.SetParameterValue("tongsongay", 0)
            Try
                rpt.SetParameterValue("bangchu", Bangchu)
            Catch ex As Exception
                rpt.SetParameterValue("bangchu", "")
            End Try

            rpt.SetParameterValue("Title", "TỔNG HỢP CHI PHÍ KHÁM CHỮA BỆNH")
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
        Else
            btnthutien.Enabled = False
            CrystalReportViewer1.Refresh()
        End If

    End Sub

    Private Sub loaddata_BHYT()
        Dim crDatabase As Database
        Dim crTables As Tables
        Dim crTable As Table
        Dim crTableLogOnInfo As TableLogOnInfo
        Dim crConnectionInfo As ConnectionInfo
        Dim tongchiphi, baohiemchitra, nguoibenhtra, fdinhmuc As Double
        Dim idDinhMuc As Int16 = 0
        Dim ngaylap As String = ""
        tongchiphi = 0
        baohiemchitra = 0
        nguoibenhtra = 0
        fdinhmuc = 0
        dtbhyt = New DataTable
        dtbhyt = BusinessLogic.Data.GetDataset("select Id_DinhMuc from PHIEUKHAMBENH where Sophieu='" & soHoSo & "'").Tables(0)
        If dtbhyt.Rows.Count > 0 Then
            If Not dtbhyt.Rows(0)("Id_DinhMuc") Is DBNull.Value Then
                idDinhMuc = Int16.Parse(dtbhyt.Rows(0)("Id_DinhMuc").ToString())
            End If
        End If
        dtbhyt = BusinessLogic.Data.GetDataset("sproc_tonghop_chiphikcb_bhyt", CommandType.StoredProcedure, New Generic.List(Of String) From {"@sophieu", "@mabn", "@thutien", "@ngay", "@dinhmuc"}, New Generic.List(Of Object) From {soHoSo, cmbMaBn.EditValue, IIf(Checka.Checked, 1, 0), dtNgayThu.DateTime.Date, idDinhMuc}).Tables(0)
        If dtbhyt.Rows.Count > 0 Then
            btnthutien.Enabled = True
            For Each r As DataRow In dtbhyt.Rows
                tongchiphi += Double.Parse("0" + r("Thanhtien").ToString())
                baohiemchitra += Double.Parse("0" + r("BaoHiemChiTra").ToString())
                nguoibenhtra += Double.Parse("0" + r("BenhNhanChiTra").ToString())
            Next
            txttienhang.Text = String.Format("{0:###,###}", tongchiphi)
            txttongtien.Text = String.Format("{0:###,###}", nguoibenhtra)

            ngaylap = "Ngày " + dtNgayThu.DateTime.Day.ToString() + " tháng " + dtNgayThu.DateTime.Month.ToString() + " năm " + dtNgayThu.DateTime.Year.ToString()
            Dim rpt As New rpt_BangKe_KhamChuaBenh_NgoaiTru
            rpt.SetDataSource(dtbhyt)
            Try
                rpt.SetParameterValue("TongChiPhi", DoiSoVND(tongchiphi.ToString()))
            Catch ex As Exception
                rpt.SetParameterValue("TongChiPhi", "0đ")
            End Try
            Try
                rpt.SetParameterValue("BaoHiemChiTra", DoiSoVND(baohiemchitra.ToString()))
            Catch ex As Exception
                rpt.SetParameterValue("BaoHiemChiTra", "0đ")
            End Try
            Try
                rpt.SetParameterValue("NguoiBenhTra", DoiSoVND(nguoibenhtra.ToString()))
            Catch ex As Exception
                rpt.SetParameterValue("NguoiBenhTra", "0đ")
            End Try

            rpt.SetParameterValue("ngay_in", ngaylap)
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
            'CrystalReportViewer1.Refresh()
        Else
            btnthutien.Enabled = False
            txttienhang.Text = 0
            txttongtien.Text = 0
            CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub btnxem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxem.Click
        If Me.cmbMaBn.EditValue <> "" Then
            LoadDataTogrv()
            loaddata_rpt()
            If Checka.Checked Then
                btnCap_nhat.Enabled = False
                btnthutien.Enabled = False
            Else
                btnCap_nhat.Enabled = True
            End If
        End If
        If Checka.Checked Then
            Dim idphieuthu As Integer = 0
            Dim dtb As DataTable
            'Lay chiet khau
            Dim sql As String = String.Format("Select ISNULL(chietkhau, 0) As chietkhau,ISNULL(IdPhieuTC,0) AS IdPhieuTC FROM Chi_tiet_NEW WHERE thutien=1 AND IDSophieu='{0}' AND Datediff(d,DateLap,'{1}')=0", cmbSoHoSo.EditValue, dtNgayThu.DateTime.ToString("MM/dd/yyyy"))
            dtb = BusinessLogic.Data.GetDataset(sql).Tables(0)
            Try
                If dtb.Rows.Count > 0 Then
                    If Not dtb.Rows(0)("chietkhau") Is DBNull.Value Then
                        txtck.Text = dtb.Rows(0)("chietkhau")
                    Else
                        txtck.Text = "0"
                    End If
                    idphieuthu = dtb.Rows(0)("IdPhieuTC")
                    'Lay thuc thu
                    If idphieuthu > 0 Then
                        sql = String.Format("SELECT ISNULL(SotienVND,0) AS SotienVND,ISNULL(total,0) AS total,ISNULL(ThucThu,0) AS ThucThu FROM Phieu_thu_chi WHERE IDSophieu='{0}'", idphieuthu)
                        dtb = BusinessLogic.Data.GetDataset(sql).Tables(0)
                        If dtb.Rows.Count > 0 Then
                            txtThucThu.Text = String.Format("{0:###,###}", dtb.Rows(0)("ThucThu"))
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
        'CrystalReportViewer1.Refresh()
        CrystalReportViewer1.ShowPrintButton = True
    End Sub

    Private Sub btnthutien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthutien.Click
        Dim sql As String = ""
        If MsgBox("Bạn có chắc chắn muốn thu tiền bệnh nhân này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MyUpdate_Thutien()
            Dim dt As DataTable
            Dim strSQL As String
            Dim int_IDSophieu As Integer = 0
            Dim int_SophieuMoi As Integer = 0
            Dim IndexIDSophieu As Integer = 0
            Dim PTC As New frmPhieuTC
            Dim clsobj As New clsThuchi
            strSQL = String.Format("Select * From Ton_Quy WHERE MaQuy = '1TM' AND Convert(char(10),Ngay,101) ='{0}'", Format(NgayGioServer(), "MM/dd/yyyy"))
            dt = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
            If dt.Rows.Count > 0 Then
            Else
                clsobj.TinhTonQuy(CNNQLPHONGKHAM)
            End If
            'If clsobj.ThemPhieuTC(Double.Parse(Chuanhoa(txttienhang.Text)), Double.Parse(Chuanhoa(txtThucThu.Text)), clsobj.Lay_So_phieu(True), 1, 0, "TTH", NgayGioServer().Date, "1TM", cmbMaBn.EditValue, cmbMaBn.EditValue, 0, 1, Double.Parse("0" + Chuanhoa(Me.txttongtien.Text)), Double.Parse("0" + Chuanhoa(Me.txttongtien.Text)), "Phiếu thu tiền từ bệnh nhân:" & Me.txthoten.Text & "", 0, 0, clsLoginObj.strUsername, clsLoginObj.strUsername, Integer.Parse("0" + cmbSoHoSo.EditValue), int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM) = 0 Then
            'Insert vao MauPhieu79BHYT
            'Insert_Mau79BHYT(sohoso)
            'End If
            clsobj.ThemPhieuTC(Double.Parse("0" + Chuanhoa(txttienhang.Text)), Double.Parse("0" + Chuanhoa(txtThucThu.Text)), clsobj.Lay_So_phieu(True), 1, 0, "TTH", NgayGioServer().Date, "1TM", cmbMaBn.EditValue, cmbMaBn.EditValue, 0, 1, Double.Parse("0" + Chuanhoa(Me.txttongtien.Text)), Double.Parse("0" + Chuanhoa(Me.txttongtien.Text)), "Phiếu thu tiền từ bệnh nhân:" & cmbMaBn.Text & "", 0, 0, clsLoginObj.strUsername, clsLoginObj.strUsername, Integer.Parse("0" + cmbSoHoSo.EditValue), int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
            If IndexIDSophieu > 0 Then
                'update idphieuTC vao chi_tiet_new
                Dim i As Integer
                For i = 0 To dtb.Rows.Count - 1
                    If dtb.Rows(i)("duyetbh") = True Then
                        strSQL = String.Format("Update Chi_tiet_new set IdPhieuTC='{0}' where ID='{1}'", IndexIDSophieu, dtb.Rows(i)("ID"))
                    End If
                    Command_Exc(strSQL, CNNQLPHONGKHAM)
                Next
            End If
            btnthutien.Enabled = False
            CrystalReportViewer1.ShowPrintButton = True
        Else
            btnthutien.Enabled = True
        End If
    End Sub

    Private Sub DateEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtNgayThu.EditValueChanged
        ClearText()
        LoadDataTogrv()
    End Sub

    Private Sub Seditbn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMaBn.KeyUp
        If e.KeyCode = Keys.Delete Then
            ClearText()
        End If
    End Sub

    Private Sub cmbMaBn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaBn.EditValueChanged
        If cmbMaBn.EditValue <> "" Then
            Load_Hoso()
            LoadDataTogrv()
        Else
            LoadDataTogrv()
        End If
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        loadcombox()
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If dr.IsNew = False Then
                cmbMaBn.EditValue = dr("mabn")
                cmbSoHoSo.EditValue = dr("idsophieu")
                maBenhNhan = dr("mabn").ToString
                soHoSo = Integer.Parse(dr("idsophieu").ToString())
                If cmbMaBn.EditValue <> "" Then
                    Load_Hoso()
                End If
                btnxem_Click(Nothing, Nothing)
            End If
        End If
    End Sub
    Private Sub btnNapDuLieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNapDuLieu.Click
        loadcombox()
        ClearText()
        LoadDataTogrv()
        Me.btnthutien.Enabled = False
        If Checka.Checked Then
        Else
            If dtb.Rows.Count > 0 Then
                MyUpdate()
            End If
        End If
    End Sub
    Sub ClearText()
        Me.cmbSoHoSo.EditValue = Nothing
        Me.cmbMaBn.EditValue = String.Empty
        Me.txtcdls.Text = String.Empty
        Me.txtmabn.Text = String.Empty
        Me.txtDienThoai.Text = String.Empty
        Me.txtdiachi.Text = String.Empty
        Me.txtgioitinh.Text = String.Empty
        Me.dtNgaySinh.Text = String.Empty
    End Sub

    Private Sub txtck_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtck.Leave
        If IsNumeric(txtck.Text) Then
            txttongtien.Text = String.Format("{0:###,###}", Double.Parse(Chuanhoa(txttienhang.Text)) - Double.Parse(Chuanhoa(txttienhang.Text)) * Double.Parse(Chuanhoa(txtck.Text)) / 100)
            'txtck.Text = String.Format("{0:###,###}", txtck.Text)
        End If
        If Me.cmbMaBn.EditValue = "" Then
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

    Private Sub Insert_Mau79BHYT(ByVal sovaovien As Long)
        Dim T_TONGCHI, T_XN, T_CDHA, T_THUOC, T_MAU, T_PTTT, T_VTYT, T_DVKT_TYLE, T_THUOC_TYLE, T_VTYT_TYLE, T_KHAM, T_GIUONG, T_VCHUYEN, T_BNTT, T_BHTT, T_NGOAIDS As Decimal
        T_TONGCHI = 0
        T_XN = 0
        T_CDHA = 0
        T_THUOC = 0
        T_MAU = 0
        T_PTTT = 0
        T_VTYT = 0
        T_DVKT_TYLE = 0
        T_THUOC_TYLE = 0
        T_VTYT_TYLE = 0
        T_KHAM = 0
        T_GIUONG = 0
        T_VCHUYEN = 0
        T_BNTT = 0
        T_BHTT = 0
        T_NGOAIDS = 0

        If dtbhyt.Rows.Count > 0 Then
            T_TONGCHI = Decimal.Parse(dtbhyt.Rows(0)("TongChiPhi").ToString())
            For Each r As DataRow In dtbhyt.Rows
                If r("Loai").ToString() = "13" Then 'XN
                    T_XN += Decimal.Parse(r("Thanhtien").ToString())
                ElseIf r("Loai").ToString() = "14" Or r("Loai").ToString() = "15" Or r("Loai").ToString() = "17" Then 'CĐHA
                    T_CDHA += Decimal.Parse(r("Thanhtien").ToString())
                ElseIf r("Loai").ToString() = "10" Then 'THUOC
                    T_THUOC += Decimal.Parse(r("Thanhtien").ToString())
                ElseIf r("Loai").ToString() = "MAU" Then 'MAU chua co
                    'nothing
                ElseIf r("Loai").ToString() = "18" Then 'T_PTTT
                    T_PTTT += Decimal.Parse(r("Thanhtien").ToString())
                ElseIf r("Loai").ToString() = "19" Then
                    T_VTYT += Decimal.Parse(r("Thanhtien").ToString())
                ElseIf r("Loai").ToString() = "12" Then 'T_KHAM
                    T_KHAM += Decimal.Parse(r("Thanhtien").ToString())
                ElseIf r("Loai").ToString() = "20" Then 'T_GIUONG
                    T_GIUONG += Decimal.Parse(r("Thanhtien").ToString())
                ElseIf r("Loai").ToString() = "21" Then 'T_VCHUYEN
                    T_VCHUYEN += Decimal.Parse(r("Thanhtien").ToString())
                End If

                T_BNTT += Decimal.Parse(r("BenhNhanChiTra").ToString())
                T_BHTT += Decimal.Parse(r("BaoHiemChiTra").ToString())
            Next
            Dim cls As clsMau79BHYT = New clsMau79BHYT()
            Dim kq As Integer = 0
            kq = cls.Mau79BHYT_Add(sovaovien, T_TONGCHI, T_XN, T_CDHA, T_THUOC, T_MAU, T_PTTT, T_VTYT, T_DVKT_TYLE, T_THUOC_TYLE, T_VTYT_TYLE, T_KHAM, T_GIUONG, T_VCHUYEN, T_BNTT, T_BHTT, T_NGOAIDS)
            If kq > 0 Then
            Else
                MsgBox("Cập nhật chi phi BHYT lỗi...!")
                Return
            End If
        End If
    End Sub

    Private Sub txttongtien_EditValueChanged(sender As Object, e As EventArgs) Handles txttongtien.EditValueChanged
        If String.IsNullOrEmpty(Chuanhoa(txttongtien.Text)) Then
            txttongtien.Text = "0"
        End If
        Try
            If Not Checka.Checked Then
                Me.txtThucThu.Text = String.Format("{0:###,###}", Double.Parse(Chuanhoa(txttongtien.Text)))
            End If
        Catch ex As Exception
            Me.txtThucThu.Text = "0"
        End Try
    End Sub

    Private Sub txtThucThu_Leave(sender As Object, e As EventArgs) Handles txtThucThu.Leave
        btnxem_Click(Nothing, Nothing)
    End Sub

    Private Sub txttienhang_EditValueChanged(sender As Object, e As EventArgs) Handles txttienhang.EditValueChanged
        If String.IsNullOrEmpty(Chuanhoa(txttienhang.Text)) Then
            txttienhang.Text = "0"
        End If
    End Sub

    Private Sub txtck_EditValueChanged(sender As Object, e As EventArgs) Handles txtck.EditValueChanged
        If String.IsNullOrEmpty(Chuanhoa(txtck.Text)) Then
            txtck.Text = "0"
        End If
    End Sub

    Private Sub txtThucThu_EditValueChanged(sender As Object, e As EventArgs) Handles txtThucThu.EditValueChanged
        If String.IsNullOrEmpty(Chuanhoa(txtThucThu.Text)) Then
            txtThucThu.Text = "0"
        End If
    End Sub
End Class