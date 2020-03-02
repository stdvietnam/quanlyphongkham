Imports System.Collections.Generic

Public Class FRM_PhieuKham
    Public IDPhieukham As Int64 = 0
    Public Flag As Boolean = False
    Public blnDelete As Boolean = False
    Private makb As String = ""
    Public ketthuc As Int16 = 0
    Public Thutien As Int16 = 0
    Private isload As Boolean = False
    Public Inidphieukham As Integer
    Public xemphieu As Boolean = False
    Public isCloseForm As Boolean = False
    Private Sub FRM_PhieuKham_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim frm As New FRM_DM_BENHNHAN
            frm.cmbDoiTuong.EditValue = 1
            frm.cmbGioi_Tinh.EditValue = 1
            frm.dtNgaySinh.DateTime = New DateTime(1990, 1, 1)
            frm.dtGT_THE_TU.DateTime = New DateTime(Year(DateTime.Now), 1, 1)
            frm.dtGT_THE_DEN.DateTime = New DateTime(Year(DateTime.Now), 12, 31)
            frm.passData_ = New FRM_DM_BENHNHAN.PassDatabn(AddressOf GetFirstValue)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show()
            isload = False
        End If
    End Sub
    Private Sub FRM_PhieuKham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dngaylap.EditValue = NgayGioServer()
        Ctrl_QuyenForm(Me)
        loadcombobox()
        MaxMa()
        If Flag = True Then
            btnThem_Click(sender, e)
            Me.grb.Enabled = True
            Me.grbkb.Enabled = True
            Me.grbkls.Enabled = True
            GroupBox_nut.Enabled = True
            Me.cmbtiepdon.EditValue = clsLoginObj.strUsername
            Me.cmbloaikham.EditValue = "12-1"
            Me.cmbphongkham.EditValue = "P1"
        End If
        'IsNew()
        'isload = False
        btnIn.Enabled = True
        If xemphieu = True Then
            loaddata()
            Flag = False
            grbkls.Enabled = True
            grbkb.Enabled = True
            GroupBox_nut.Enabled = True
            Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        End If
        If khamxong() = 1 Then
            grbkls.Enabled = False
            grb.Enabled = False
            grbkb.Enabled = False
            GroupBox_nut.Enabled = True
            btnCap_nhat.Enabled = False
            btnHuy.Enabled = False
        End If
        Me.btnSua.Enabled = True
        Me.Panel_Button.Enabled = True
    End Sub
    Private Sub loaddata()
        Dim dts As New DataSet
        Dim dtbphieu As New DataTable
        Dim strSql As String
        strSql = "SELECT * FROM PHIEUKHAMBENH WHERE SOPHIEU = " & IDPhieukham & ""
        dts = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing)
        dtbphieu = dts.Tables(0)
        If dtbphieu.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbphieu.Rows(0)
            ketthuc = row("KHAMXONG")
            cmbmabn.EditValue = row("Mabn")
            cmbloaikham.EditValue = row("Kieukham")
            txtsohoso.Text = row("Sophieu")
            cmbttbn.EditValue = row("Loaisuckhoe")
            cmbtiepdon.EditValue = row("Nguoilap")
            cmbphongkham.EditValue = row("Phongkham")
            cmbbacsi.EditValue = row("Bacsikham")
            Dngaylap.DateTime = row("Ngaylap")
            txttienkham.Text = Format(row("Tienkham"), "###,###")
            txtNhietdo.Text = row("Nhietdo").ToString
            txtHuyetap.Text = row("Huyetap").ToString
            txtNhiptim.Text = row("Mach").ToString
            txtNhiptho.Text = row("NhipTho").ToString
            txtCannang.Text = row("CanNang").ToString
            txtChieucao.Text = row("ChieuCao").ToString
            txtKetluan_f2.Text = row("Ketluan").ToString
            txtchandoan_ls.EditValue = row("Mabenh").ToString
            txtKhamlamsang.Text = row("KhamLamSang").ToString
            txtBenhkemtheo.Text = row("BenhKemTheo").ToString
            txtghichu.Text = row("Ghichu").ToString
            cmbMaICD.EditValue = row("MaICD").ToString()
            txtDiUngThuoc.Text = row("DiUngThuoc").ToString()
            If Not row("IsChoKetQua") Is DBNull.Value Then
                If row("IsChoKetQua") = True Then
                    chkChoKetQua.Checked = True
                Else
                    chkChoKetQua.Checked = False
                End If
            Else
                chkChoKetQua.Checked = False
            End If
            If Not row("Henkham") Is DBNull.Value Then
                If row("Henkham") = True Then
                    chkHenKham.Checked = True
                Else
                    chkHenKham.Checked = False
                End If
            End If
            If Not row("Ngayhenkham") Is DBNull.Value Then
                dtHenKham.DateTime = row("Ngayhenkham")
            End If
            If Not row("Doituong") Is DBNull.Value Then
                Me.cmbdoituong.EditValue = row("Doituong")
            Else
                Me.cmbdoituong.EditValue = Nothing
            End If
        End If
    End Sub
    Private Function LayMa(ByVal strMa As String, ByVal strManhom As String, ByVal strkd As String) As String
        Dim strMaMoi As String = ""
        Dim i As Integer
        If Len(strMa) > 0 Then
            For i = 1 To Len(strMa)
                If IsNumeric(Mid(strMa, i, 1)) Then
                    strMaMoi &= Mid(strMa, i, 1)
                End If
            Next
        End If
        If IsNumeric(strMaMoi) Then
            strMaMoi = Val(strMaMoi) + 1
        Else
            strMaMoi = strkd
        End If
        Return strManhom + strMaMoi
    End Function
    Private Sub MaxMa()
        Dim strMa As String = ""
        Dim Strmanhom As String
        Dim strSql As String
        Dim dt As New DataTable
        Try
            Strmanhom = ""
            strSql = "Select max(CAST(SoPhieu AS BIGINT))[Ma] from PhieuKhamBenh"
            dt = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing).Tables(0)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0)("Ma")) Then strMa = dt.Rows(0)("Ma")
            End If
            Me.txtsohoso.Text = LayMa(strMa, Strmanhom, "1")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub IsNew()
        Me.grb.Enabled = True
        Clear_Control_DevExprees(Me)
        Flag = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        'Dim cost As Double = 0
        'Try
        '    cost = TienKham()
        'Catch ex As Exception
        '    cost = 0
        'End Try
        'Me.txttienkham.Text = cost.ToString("###,###")
    End Sub
    Private Sub loadcombobox()
        Load_ComboBox("Select mabn[Mã],hotenbn[Bệnh nhân],Dienthoai[Điện thoại] From hosobn", Me.cmbmabn, CNNQLPHONGKHAM, True)
        Load_ComboBox("Select MaSp,TenSp,Dongia,Mahanghoa From San_Pham where Manhom=12", Me.cmbloaikham, CNNQLPHONGKHAM)
        Load_ComboBox("Select ma[Mã],ten[TT bệnh nhân] From DMCHUNG where loai=8 ", Me.cmbttbn, CNNQLPHONGKHAM)
        Load_ComboBox("Select maphong[Mã],tenphong[Phòng khám] From Phong_Ban where Loai=1", Me.cmbphongkham, CNNQLPHONGKHAM)
        Load_ComboBox("Select Username[Mã],Hoten[Họ và tên] From Nguoi_su_dung ", Me.cmbtiepdon, CNNQLPHONGKHAM)
        Load_ComboBox("Select Username[Mã],Hoten[Bác sĩ] From Nguoi_su_dung ", Me.cmbbacsi, CNNQLPHONGKHAM)
        Load_ComboBox("Select mabenh,tenbenh From tb_khambenh", Me.cmbTenICD, CNNQLPHONGKHAM)
        Load_ComboBox("Select id[Mã],doituong[Đối tượng] From DM_DOITUONG", Me.cmbdoituong, CNNQLPHONGKHAM)
        Load_ComboBox("Select CICD10,VVIET From ICD10", Me.cmbTenICD, CNNQLPHONGKHAM)
        Load_ComboBox("Select CICD10,VVIET From ICD10", Me.cmbMaICD, CNNQLPHONGKHAM, True)
        Me.cmbttbn.EditValue = "KK"
        Me.cmbtiepdon.EditValue = clsLoginObj.strUsername
    End Sub
    Private Sub cmbmabn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmabn.EditValueChanged
        If cmbmabn.EditValue <> "" Then
            Dim dts As New DataSet
            Dim dt As New DataTable
            Dim strsql As String = "SELECT MaBN,TenBN,HoTenBN,DiaChiChiTiet,Case GioiTinh when 1 then 'Nam'else N'Nữ' end as GioiTinh,d1.ten as DanToc,NgaySinh,d2.ten as NgheNghiep,NoiLamViec,DienThoai,d4.ten as QuanHe,NguoiThan,DiaChiLienHe,GhiChu,DoiTuong,SoTheBHYT,TuNgay,DenNgay FROM HOSOBN b "
            strsql &= "left join DMCHUNG d1 on d1.ma=b.DanToc left join DMCHUNG d2 on d2.ma=b.nghenghiep "
            strsql &= "left join DMCHUNG d4 on d4.ma=b.quanhe where Mabn='" & cmbmabn.EditValue & "'"
            dts = BusinessLogic.Data.GetDataset(strsql)
            dt = dts.Tables(0)
            If dt.Rows.Count > 0 Then
                If Not dt.Rows(0)("HoTenBN") Is DBNull.Value Then
                    Me.txtTenBN.Text = dt.Rows(0)("HoTenBN").ToString()
                Else
                    Me.txtTenBN.Text = ""
                End If
                If Not dt.Rows(0)("DanToc") Is DBNull.Value Then
                    Me.txtdantoc.Text = dt.Rows(0)("DanToc").ToString()
                Else
                    Me.txtdantoc.Text = ""
                End If
                If Not dt.Rows(0)("DienThoai") Is DBNull.Value Then
                    Me.txtDienthoai.Text = dt.Rows(0)("DienThoai").ToString()
                Else
                    Me.txtDienthoai.Text = ""
                End If
                If Not dt.Rows(0)("GhiChu") Is DBNull.Value Then
                    Me.txtghichu.Text = dt.Rows(0)("GhiChu").ToString()
                Else
                    Me.txtghichu.Text = ""
                End If
                If Not dt.Rows(0)("GioiTinh") Is DBNull.Value Then
                    Me.txtgioitinh.Text = dt.Rows(0)("GioiTinh")
                Else
                    Me.txtgioitinh.Text = ""
                End If
                If Not dt.Rows(0)("NgheNghiep") Is DBNull.Value Then
                    Me.txtnghenghiep.Text = dt.Rows(0)("NgheNghiep").ToString()
                Else
                    Me.txtnghenghiep.Text = ""
                End If
                If Not dt.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                    Me.txtdclienhe.Text = dt.Rows(0)("DiaChiChiTiet").ToString()
                Else
                    Me.txtdclienhe.Text = ""
                End If
                If Not dt.Rows(0)("NgaySinh") Is DBNull.Value Then
                    Me.dtNgaySinh.DateTime = dt.Rows(0)("NgaySinh")
                Else
                    Me.dtNgaySinh.Text = ""
                End If
                If Not dt.Rows(0)("DoiTuong") Is DBNull.Value Then
                    Me.cmbdoituong.EditValue = dt.Rows(0)("DoiTuong")
                Else
                    Me.cmbdoituong.EditValue = Nothing
                End If
                If Not dt.Rows(0)("SoTheBHYT") Is DBNull.Value Then
                    Me.txtsothe.Text = dt.Rows(0)("SoTheBHYT").ToString()
                Else
                    Me.txtsothe.Text = ""
                End If
                If Not dt.Rows(0)("TuNgay") Is DBNull.Value Then
                    Me.dtTuNgay.DateTime = dt.Rows(0)("TuNgay")
                Else
                    Me.dtTuNgay.Text = ""
                End If
                If Not dt.Rows(0)("DenNgay") Is DBNull.Value Then
                    Me.dtDenNgay.DateTime = dt.Rows(0)("DenNgay")
                Else
                    Me.dtDenNgay.Text = ""
                End If
                '=== Load lich su di ung thuoc ==
                strsql = "SELECT TOP 1 DiUngThuoc FROM PhieuKhamBenh WHERE MaBN='" & cmbmabn.EditValue & "' AND DiUngThuoc <> '' AND DiUngThuoc IS NOT NULL ORDER BY ID DESC"
                Dim dtDiUngThuoc As DataTable = BusinessLogic.Data.GetDataset(strsql).Tables(0)
                If dtDiUngThuoc.Rows.Count > 0 Then
                    Me.txtDiUngThuoc.Text = dtDiUngThuoc.Rows(0)("DiUngThuoc").ToString()
                Else
                    Me.txtDiUngThuoc.Text = ""
                End If
            End If
        End If
    End Sub
    Private Function TienKham() As Double
        Dim dts As New DataSet
        Dim dtbtonkho As DataTable
        dts = BusinessLogic.Data.GetDataset("Select distinct top 1 dongia from san_pham where Manhom=12 and masp='" & cmbloaikham.EditValue & "'", CommandType.Text, Nothing, Nothing)
        dtbtonkho = dts.Tables(0)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("dongia")
        Else
            Return 0 'MsgBox("Dịch vụ này hiện không có giá bán hoặc chưa định nghĩa...?", MsgBoxStyle.Critical)
        End If
    End Function
    Private Sub cmbmabn_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbmabn.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim frm As New FRM_DM_BENHNHAN
            frm.cmbDoiTuong.EditValue = 1
            frm.cmbGioi_Tinh.EditValue = 1
            frm.dtNgaySinh.DateTime = New DateTime(1990, 1, 1)
            frm.dtGT_THE_TU.DateTime = New DateTime(Year(DateTime.Now), 1, 1)
            frm.dtGT_THE_DEN.DateTime = New DateTime(Year(DateTime.Now), 12, 31)
            frm.passData_ = New FRM_DM_BENHNHAN.PassDatabn(AddressOf GetFirstValue)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show()
            isload = False
        End If
    End Sub
    Private Sub GetFirstValue(ByVal MaBN As String)
        Load_ComboBox("Select mabn[Mã],hotenbn[Bệnh nhân],Dienthoai[Điện thoại] from hosobn", cmbmabn, CNNQLPHONGKHAM)
        Me.cmbmabn.EditValue = MaBN
    End Sub
    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        IsNew()
        clear_form()
        Dngaylap.EditValue = NgayGioServer()
        Me.grb.Enabled = True
        Me.grbkb.Enabled = True
        Me.grbkls.Enabled = True
        Me.cmbtiepdon.EditValue = clsLoginObj.strUsername
        Me.cmbloaikham.EditValue = "12-1"
        Me.cmbphongkham.EditValue = "P1"
    End Sub
    Private Sub clear_form()
        Me.cmbbacsi.EditValue = ""
        Me.cmbmabn.EditValue = ""
        Me.cmbttbn.EditValue = "KK"
        Me.cmbphongkham.EditValue = ""
        Me.cmbloaikham.EditValue = "12-1"
        Try
            Dim txt As Object
            For Each txt In grb.Controls
                If txt.Name.Substring(0, 3).ToUpper = "TXT" Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.cmbmabn.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbmabn, "Chưa nhập thông tin bệnh nhân!")
            ErrPro.SetIconAlignment(Me.cmbmabn, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbttbn.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbttbn, "Dữ liệu không để trống!")
            ErrPro.SetIconAlignment(Me.cmbttbn, ErrorIconAlignment.MiddleRight)
        End If

        If Me.cmbphongkham.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbphongkham, "Dữ liệu không để trống!")
            ErrPro.SetIconAlignment(Me.cmbphongkham, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbbacsi.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbbacsi, "Dữ liệu không để trống!")
            ErrPro.SetIconAlignment(Me.cmbbacsi, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Kiem_Tra() = True Then
            Dim sql As String
            If Flag = True Then
                MaxMa()
                Dim cls As clsPhieuKhamBenh = New clsPhieuKhamBenh()
                Dim id As Integer = 0
                id = cls.LAPPHIEUKHAM_ADD(Integer.Parse(txtsohoso.Text), Dngaylap.DateTime, cmbtiepdon.EditValue, cmbmabn.EditValue, Double.Parse("0" + Chuanhoa(txttienkham.Text)), cmbttbn.EditValue, cmbbacsi.EditValue, cmbphongkham.EditValue, cmbloaikham.EditValue, txtghichukham.Text, cmbdoituong.EditValue, 0, 0, txtKhamlamsang.Text, txtBenhkemtheo.Text, txtchandoan_ls.Text, txtKetluan_f2.Text, txtNhiptim.Text, txtNhietdo.Text, txtHuyetap.Text, txtNhiptho.Text, txtChieucao.Text, txtCannang.Text, txtDiUngThuoc.Text, chkChoKetQua.Checked)
                If id > 0 Then
                    txtsohoso.Text = id
                    'Thêm vào chi_tiet_new
                    Dim soct As String = GetNextRefNo("KB")
                    sql = "Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung, Nguoilap,Bacsi,maphong)"
                    sql &= "values(N'" & txtsohoso.Text & "',N'" & cmbloaikham.EditValue & "',N'1',N'" & Chuanhoa(txttienkham.Text) & "', N'" & Chuanhoa(txttienkham.Text) & "',N'1',N'" & cmbmabn.EditValue.ToString() & "',N'" & Dngaylap.EditValue & "','" & Chuanhoa(txttienkham.Text) & "',N'KDV',N'12',N'" & soct & "',N'' ,N'',N'" & cmbtiepdon.EditValue & "',N'" & cmbbacsi.EditValue & "',N'" & cmbphongkham.EditValue & "')"
                    Command_Exc(sql, CNNQLPHONGKHAM)
                End If
            Else
                sql = "Update PHIEUKHAMBENH Set Henkham='" & IIf(chkHenKham.Checked, 1, 0) & "',Ngayhenkham='" & dtHenKham.DateTime & "',Ngaylap = '" & Dngaylap.EditValue & "',Nguoilap ='" & cmbtiepdon.EditValue & "',Mach=N'" & txtNhiptim.Text & "',Nhietdo=N'" & txtNhietdo.Text & "',Huyetap=N'" & txtHuyetap.Text & "',NhipTho=N'" & txtNhiptho.Text & "',Chieucao=N'" & txtChieucao.Text & "',Cannang = N'" & txtCannang.Text & "',KetLuan=N'" & txtKetluan_f2.Text & "',BenhKemTheo=N'" & txtBenhkemtheo.Text & "',MaBenh=N'" & txtchandoan_ls.EditValue & "',TienSu_BanThan=N'',TienSu_GiaDinh=N'',TienSu_DiUngThuoc=N'',KhamLamSang=N'" & txtKhamlamsang.Text & "',Khamxong=1,Tienkham = '" & Chuanhoa(txttienkham.Text) & "', LoaiSucKhoe= '" & cmbttbn.EditValue & "', BacSiKham=N'" & cmbbacsi.EditValue & "', PhongKham=N'" & cmbphongkham.EditValue & "' , KieuKham=N'" & cmbloaikham.EditValue & "',tuvong=0,Doituong=" & cmbdoituong.EditValue & ",MaICD=N'" & cmbMaICD.EditValue & "',DiUngThuoc=N'" & txtDiUngThuoc.Text & "',IsChoKetQua=" & IIf(chkChoKetQua.Checked, 1, 0) & "  Where SOPHIEU = cast('" & txtsohoso.Text & "' as Bigint)"
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                    sql = "Update chi_tiet_new set maphong=N'" & cmbphongkham.EditValue & "', masp=N'" & cmbloaikham.EditValue & "',Dongia=N'" & Chuanhoa(txttienkham.Text) & "',Thanhtien=N'" & Chuanhoa(txttienkham.Text) & "',TotalAmount=N'" & Chuanhoa(txttienkham.Text) & "',DateLap='" & Dngaylap.DateTime & "',Nguoilap=N'" & cmbtiepdon.EditValue & "',Bacsi=N'" & cmbbacsi.EditValue & "' where idsophieu='" & txtsohoso.Text & "' and loaidv=12"
                    Command_Exc(sql, CNNQLPHONGKHAM)
                End If
                Flag = False
            End If
            'Flag = True
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            GroupBox_nut.Enabled = True
            btnIn.Enabled = True
            isload = True
        End If
    End Sub
    Private Sub cmbphongkham_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbphongkham.EditValueChanged
        If cmbphongkham.EditValue <> "" Then
            Dim str As String = "Select Username from Nguoi_su_dung where maphong='" & cmbphongkham.EditValue & "'"
            Dim dts As New DataSet
            dts = BusinessLogic.Data.GetDataset(str, CommandType.Text, Nothing, Nothing)
            If dts.Tables(0).Rows.Count > 0 Then
                cmbbacsi.EditValue = dts.Tables(0).Rows(0)(0)
            Else
                cmbbacsi.EditValue = ""
            End If
        End If
    End Sub
    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
        Clear_Control(Me)
        btnIn.Enabled = True
    End Sub
    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.btnIn.Enabled = False
        Flag = False
        isload = True
        Me.grb.Enabled = True
        Me.grbkb.Enabled = True
        Me.grbkls.Enabled = True
        Me.GroupBox_nut.Enabled = True
    End Sub
    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim strSQL As String
        If MsgBox("Bạn có muốn xoá phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strSQL = "UPDATE PHIEUKHAMBENH SET Huy=1 WHERE SoPhieu = " & Me.txtsohoso.Text & " "
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            'Xóa Chi_tiet_new
            strSQL = "Update Chi_tiet_NEW set huy=1 WHERE IDSophieu='" & Me.txtsohoso.Text.Trim & "'"
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            MsgBox("Phiếu hiện tại đã được xoá!")
            Me.Close()
        End If
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim frm As New frmShowReport
        frm.IDchitiet = Me.txtsohoso.Text.Trim
        frm.Ngaythang = Me.Dngaylap.DateTime
        frm.bsckhoa = Me.cmbbacsi.Text
        frm.Nhanvien = Me.cmbtiepdon.Text
        frm.hoten = Me.txtTenBN.Text
        frm.diachi = Me.txtdclienhe.Text
        frm.nghenghiep = Me.txtnghenghiep.Text
        frm.gioitinh = Me.txtgioitinh.Text
        frm.tel = Me.txtDienthoai.Text
        frm.tuoi = dtNgaySinh.DateTime.ToString("dd/MM/yyyy")
        frm.sothebhyt = Me.txtsothe.Text
        frm.trieuchung = Me.txtKhamlamsang.Text + " " + Me.txtBenhkemtheo.Text
        frm.chandoanbenh = Me.txtchandoan_ls.Text
        frm.loidanbacsi = Me.txtKetluan_f2.Text
        Dim strDonthuoc As String = ""
        Dim strCLS As String = ""
        Dim CanLamSang As String = ""
        frm.canlamsang = CanLamSang
        frm.dtb = BusinessLogic.Data.GetDataset("dichvu_benhan", CommandType.StoredProcedure, New List(Of String) From {"sophieukham"}, New List(Of Object) From {Integer.Parse(txtsohoso.Text)}).Tables(0)
        frm.strBC = frmShowReport.TenBc.Phieukhambenh
        frm.Show()
    End Sub
    Private Function Check_BN_KhamTrongNgay() As Boolean
        Dim bo As Boolean
        Dim strSQL As String
        Dim dtk As New DataTable
        strSQL = String.Format("Select COUNT(k.Mabn) from PHIEUKHAMBENH k,HOSOBN h where k.Huy=0 and k.MaBN=h.MaBN and DoiTuong=0 and convert(char(10),NgayLap,101)= CONVERT(char(10),GETDATE(),101) and k.MaBN=N'{0}'", cmbmabn.EditValue)
        dtk = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing).Tables(0)
        If dtk.Rows.Count > 0 Then
            If Not dtk.Rows(0)(0) Is DBNull.Value Then
                If dtk.Rows(0)(0) > 0 Then
                    bo = True
                Else
                    bo = False
                End If
            End If
        Else
            bo = False
        End If
        Return bo
    End Function
    Private Sub cmbchandoan_ls_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchandoan_ls.EditValueChanged, txtKetluan_f2.EditValueChanged
        If txtchandoan_ls.EditValue <> "" Then
            Dim sql As String
            Dim dtcd As New DataTable
            sql = "Select mabenh,tenbenh from tb_khambenh where mabenh='" & txtchandoan_ls.EditValue & "'"
            dtcd = BusinessLogic.Data.GetDataset(sql, CommandType.Text, Nothing, Nothing).Tables(0)
            If dtcd.Rows.Count > 0 Then
                cmbTenICD.EditValue = dtcd.Rows(0)(0)
            Else
            End If
        End If
    End Sub
    Private Sub cmbtenicd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbTenICD.EditValue <> "" Then
            Dim sql As String
            Dim dtcd As New DataTable
            sql = "Select mabenh,tenbenh from tb_khambenh where mabenh='" & cmbTenICD.EditValue & "'"
            dtcd = BusinessLogic.Data.GetDataset(sql, CommandType.Text, Nothing, Nothing).Tables(0)
            If dtcd.Rows.Count > 0 Then
                txtchandoan_ls.EditValue = dtcd.Rows(0)(0)
            Else
            End If
        End If
    End Sub
    Private Function khamxong() As Int16
        Dim sql As String = "Select KhamXong from phieukhambenh where sophieu='" & txtsohoso.Text & "'"
        Dim dtk As New DataTable
        dtk = BusinessLogic.Data.GetDataset(sql, CommandType.Text, Nothing, Nothing).Tables(0)
        If dtk.Rows.Count > 0 Then
            If dtk.Rows(0)(0) = 2 Then
                Return 1
            Else
                Return 0
            End If
        End If
    End Function
    Private Sub btnKetthuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKetthuc.Click
        If khamxong() = 1 Then
            MsgBox("Đã khám xong!")
            Return
        End If
        Dim str As String
        If MsgBox("Bạn có chắc chắn đã khám xong?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            str = "UPDATE PHIEUKHAMBENH SET KHAMXONG=2,NgayRaVien='" & DateTime.Now & "' WHERE SOPHIEU = '" & Me.txtsohoso.Text & "'"
            If Command_Exc(str, CNNQLPHONGKHAM) = 0 Then
                MsgBox("BỆNH NHÂN ĐÃ KHÁM XONG!")
                Me.btnKetthuc.Enabled = False
            End If
        End If
    End Sub
    Private Sub cmbloaikham_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbloaikham.EditValueChanged
        If cmbloaikham.EditValue <> "" Then
            cmbphongkham.EditValue = ""
            cmbttbn.EditValue = "KK"
            Dim cost As Double = 0
            Try
                cost = TienKham()
            Catch ex As Exception
                cost = 0
            End Try
            Me.txttienkham.Text = cost.ToString("###,###")
        End If
    End Sub
    Private Sub btnHuyKham_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuyKham.Click
        If khamxong() = 1 Then
            MsgBox("Đã khám xong!")
            Return
        End If
        Dim str As String
        If MsgBox("Bạn có chắc chắn muốn hủy khám?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            str = "UPDATE PHIEUKHAMBENH SET huy=1 WHERE SOPHIEU = '" & Me.txtsohoso.Text & "'"
            If Command_Exc(str, CNNQLPHONGKHAM) = 0 Then
                MsgBox("Phiếu đã hủy!")
                Me.btnHuyKham.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnDonthuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDonthuoc.Click
        If khamxong() = 1 Then
            MsgBox("Đã khám xong!")
            Return
        End If
        If Integer.Parse("0" + txtsohoso.Text) = 0 Then
            MsgBox("Chưa lập phiếu khám!")
            Return
        End If

        Dim frm As New frm_kedonthuoc
        frm.BS = True
        'frmdichvu.BS = False
        frm.LoaiPhieu = 0
        frm.cmbDonvi.EditValue = Me.cmbmabn.EditValue
        frm.txtSophieukham.Text = Me.txtsohoso.Text
        frm.Txtchandoanls.Text = Me.txtchandoan_ls.Text
        frm.CmbKhohang.EditValue = "KT"
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.blnType = True
        Me.AddOwnedForm(frm)
        frm.ShowDialog()
        If frm.isCloseForm Then
            chkHenKham.Checked = frm.isHenKham
            dtHenKham.DateTime = frm.ngayHenKham
            Me.RemoveOwnedForm(frm)
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim frm As New FRM_DSCLS
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.IDchitiet = txtsohoso.Text
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub
    Private Sub chkHenKham_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHenKham.CheckedChanged
        If chkHenKham.Checked = True Then
            dtHenKham.Visible = True
            dtHenKham.DateTime = Dngaylap.DateTime.AddDays(1)
        Else
            dtHenKham.Visible = False
            dtHenKham.EditValue = New DateTime(1900, 1, 1)
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Dim frm As New Frm_chuyenvien
        frm.StartPosition = FormStartPosition.CenterScreen
        If CV() = 1 Then
            Dim sql As String = "Select Socv from tb_chuyenvien where Sophieukham='" & txtsohoso.Text & "'"
            Dim dtk As New DataTable
            dtk = BusinessLogic.Data.GetDataset(sql).Tables(0)
            If dtk.Rows.Count > 0 Then
                frm.IDPhieu = dtk.Rows(0)(0)
            End If
            Me.AddOwnedForm(frm)
            frm.Show()
        Else
            If MsgBox("Bạn có chắc chắn muốn chuyển viện?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                frm.txtmabn.Text = cmbmabn.EditValue
                frm.txtsohoso.Text = txtsohoso.Text
                frm.cmbbacsi.EditValue = cmbbacsi.EditValue
                frm.txtghichukham.Text = txtKhamlamsang.Text
                frm.Dngaylap.DateTime = Dngaylap.DateTime
                frm.Flag = True
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
        End If

    End Sub
    Private Function CV() As Int16
        Dim sql As String = "Select chuyenvien from phieukhambenh where Sophieu='" & txtsohoso.Text & "'"
        Dim dtk As New DataTable
        dtk = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dtk.Rows.Count > 0 Then
            If dtk.Rows(0)(0) = 1 Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If Integer.Parse("0" + txtsohoso.Text) = 0 Then
            MsgBox("Chưa lập phiếu khám!")
            Return
        End If
        Dim frm As New FRM_KECANLAMSANG
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.cmbnlap.EditValue = cmbbacsi.EditValue
        frm.txtSophieu.Text = Me.txtsohoso.Text
        frm.cmbMaBN.EditValue = cmbmabn.EditValue
        frm.DtpNgaylap.EditValue = Dngaylap.DateTime
        frm.IDPhieuxuat = Me.txtsohoso.Text
        frm.Rich_lamsang.Text = txtKhamlamsang.Text & IIf(txtBenhkemtheo.Text <> "", " / " & txtBenhkemtheo.Text, "")
        frm.PhongKham = ""
        frm.IDSophieu = "0"
        frm.IsNew = 1
        frm.load_all = True
        frm.suaphieu = False
        frm.Inidphieugoc = Inidphieukham
        frm.cmbdoi_tuong.EditValue = cmbdoituong.EditValue
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub
    Private Sub btnLichSuKham_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLichSuKham.Click
        Dim frm As New frm_LichSuBenhNhan
        frm.chk_TatCa.Checked = True
        frm.ls_mabn = Me.cmbmabn.EditValue
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
    End Sub
    Private Sub cmbTenICD_EditValueChanged_1(sender As Object, e As EventArgs) Handles cmbTenICD.EditValueChanged
        If cmbTenICD.EditValue <> "" Then
            cmbMaICD.EditValue = cmbTenICD.EditValue
        End If
    End Sub
    Private Sub cmbMaICD_EditValueChanged(sender As Object, e As EventArgs) Handles cmbMaICD.EditValueChanged
        If cmbMaICD.EditValue <> "" Then
            cmbTenICD.EditValue = cmbMaICD.EditValue
        End If
    End Sub
    Private Sub GetChanDoanBenh()
        txtchandoan_ls.Text += cmbTenICD.Text.Trim() + "(" + cmbMaICD.Text.Trim() + "), "
    End Sub
    Private Sub dtNgaySinh_EditValueChanged(sender As Object, e As EventArgs) Handles dtNgaySinh.EditValueChanged, cmbTenICD.MouseLeave
        Try
            Dim ThangTuoi As String = MdlCommon.TinhThangTuoi(dtNgaySinh.DateTime.Date, 3)
            txtThangTuoi.Text = ThangTuoi
        Catch ex As Exception
            txtThangTuoi.Text = String.Empty
        End Try
    End Sub
    Private Sub cmbTenICD_Leave(sender As Object, e As EventArgs) Handles cmbTenICD.Leave
        GetChanDoanBenh()
    End Sub

    Private Sub txttienkham_EditValueChanged(sender As Object, e As EventArgs) Handles txttienkham.EditValueChanged
        If String.IsNullOrEmpty(Chuanhoa(txttienkham.Text)) Then
            txttienkham.Text = "0"
        End If
    End Sub

    Private Sub btnKetQuaCLS_Click(sender As Object, e As EventArgs) Handles btnKetQuaCLS.Click
        If Integer.Parse("0" + txtsohoso.Text) = 0 Then
            MsgBox("Chưa lập phiếu khám!")
            Return
        End If
        Dim frm As New frmUploadFiles
        frm.mabn = cmbmabn.EditValue
        frm.StartPosition = FormStartPosition.CenterScreen
        Me.AddOwnedForm(frm)
        frm.ShowDialog()
        If frm.isClose Then
            Me.RemoveOwnedForm(frm)
        End If
    End Sub

    Private Sub FRM_PhieuKham_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isCloseForm = True
    End Sub
End Class