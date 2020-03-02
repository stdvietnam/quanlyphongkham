Imports System.Collections.Generic

Public Class FRM_TIEPDONBN
    Public IDPhieukham As Int64 = 0
    Private Flag As Boolean = False
    Public blnDelete As Boolean = False
    Private makb As String = ""
    Public ketthuc As Int16 = 0
    Public Thutien As Int16 = 0
    Private isload As Boolean = False
    Public Inchuyenphong As Int16 = 0
    Public Inidphieukham As Integer
    Public ChuyenPhong As Boolean = False
    Public xemphieu As Boolean = False
    Public strMaTinh As String

    Private Sub FRM_TIEPDONBN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FRM_TIEPDONBN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        'IsNew()
        TK_PhieuKham()
        TK_PhongKham()
        isload = False
        btnIn.Enabled = True
        btnf5.Enabled = True
        grbttpk.Enabled = True
        If xemphieu = True Then
            loaddata()
            Flag = False
            Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        End If
        Me.Panel_Button.Enabled = True
    End Sub
    Private Sub loaddata()
        Dim dts As New DataSet
        Dim dtbphieu As New DataTable
        Dim strSql As String
        strSql = String.Format("SELECT * FROM PHIEUKHAMBENH WHERE SOPHIEU = {0}", IDPhieukham)
        dts = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing)
        dtbphieu = dts.Tables(0)
        If dtbphieu.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbphieu.Rows(0)
            ketthuc = row("KHAMXONG")
            If row("KHAMXONG") = 1 Then

            End If
            cmbmabn.EditValue = row("Mabn")
            cmbloaikham.EditValue = row("Kieukham")
            txtsohoso.Text = row("Sophieu").ToString()
            cmbttbn.EditValue = row("Loaisuckhoe")
            cmbtiepdon.EditValue = row("Nguoilap")
            cmbphongkham.EditValue = row("Phongkham")
            cmbbacsi.EditValue = row("Bacsikham")
            Dngaylap.DateTime = row("Ngaylap")
            txttienkham.Text = Format(row("Tienkham"), "###,###")
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
            strSql = "select max(CAST(SoPhieu AS BIGINT))[Ma] from PhieuKhamBenh"
            dt = BusinessLogic.Data.GetDataset(strSql).Tables(0)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0)("Ma")) Then strMa = dt.Rows(0)("Ma")
            End If
            Me.txtsohoso.Text = LayMa(strMa, Strmanhom, "1")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ActiveF()
        grbttpk.Enabled = True
        grbttphong.Enabled = True
    End Sub
    Private Sub IsNew()
        ActiveF()
        Me.grb.Enabled = True
        Me.grbkb.Enabled = True
        Me.grbct.Enabled = True
        Me.grbttphong.Enabled = True
        Me.grbttpk.Enabled = True
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
        Load_ComboBox("Select mabn[Mã],hotenbn[Bệnh nhân],Dienthoai[Điện thoại] from HoSoBN", cmbmabn, CNNQLPHONGKHAM)
        Load_ComboBox("Select ma[Mã],ten[Loại khám] from DMCHUNG where loai=7 ", cmbkieukham, CNNQLPHONGKHAM)
        Load_ComboBox("Select ma[Mã],ten[TT bệnh nhân] from DMCHUNG where loai=8 ", cmbttbn, CNNQLPHONGKHAM)
        Load_ComboBox("Select maphong[Mã],tenphong[Phòng khám] from Phong_Ban where Loai=1", cmbphongkham, CNNQLPHONGKHAM)
        Load_ComboBox("Select Username[Mã],Hoten[Họ và tên] from Nguoi_su_dung ", cmbtiepdon, CNNQLPHONGKHAM)
        Load_ComboBox("Select Username[Mã],Hoten[Bác sĩ] from Nguoi_su_dung ", cmbbacsi, CNNQLPHONGKHAM)
        Load_ComboBox("Select id[Mã],doituong[Đối tượng] from DM_DOITUONG", cmbdoituong, CNNQLPHONGKHAM)
        Load_ComboBox("Select Id[Mã],Ten[Tên] from DM_TUYEN_BHYT", cmbtuyen, CNNQLPHONGKHAM)
        Load_ComboBox("Select MaSp,TenSp,Dongia,Mahanghoa from San_Pham where Manhom=12", cmbloaikham, CNNQLPHONGKHAM)
        cmbttbn.EditValue = "KK"
        cmbphongkham.EditValue = ""
        cmbtiepdon.EditValue = clsLoginObj.strUsername
        cmbbacsi.EditValue = ""
    End Sub
    Private Sub cmbmabn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmabn.EditValueChanged
        If cmbmabn.EditValue <> "" Then
            Dim dts As New DataSet
            Dim dt As New DataTable
            Dim strsql As String = String.Format("SELECT MaBN,TenBN,HoTenBN,DiaChiChiTiet,g.Ten as GioiTinh,d1.ten as DanToc,NgaySinh,d2.ten as NgheNghiep,NoiLamViec,DienThoai,d4.ten as QuanHe,NguoiThan,DiaChiLienHe,GhiChu,Doituong,SotheBHYT,TuNgay,DenNgay,datediff(d,getdate(),DenNgay) as SoNgay ")
            strsql &= String.Format("FROM HOSOBN b left join DMCHUNG d1 on d1.ma=b.DanToc left join DMCHUNG d2 on d2.ma=b.nghenghiep left join DMCHUNG d4 on d4.ma=b.quanhe join DM_GIOITINH g on g.ID=b.GioiTinh where Mabn='{0}'", cmbmabn.EditValue)
            dt = BusinessLogic.Data.GetDataset(strsql).Tables(0)
            If dt.Rows.Count > 0 Then
                If Not dt.Rows(0)("HoTenBN") Is DBNull.Value Then
                    txtTenBN.Text = dt.Rows(0)("HoTenBN").ToString()
                Else
                    txtTenBN.Text = ""
                End If

                If Not dt.Rows(0)("DanToc") Is DBNull.Value Then
                    txtdantoc.Text = dt.Rows(0)("DanToc").ToString()
                Else
                    txtdantoc.Text = ""
                End If
                If Not dt.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                    txtDiachi.Text = dt.Rows(0)("DiaChiChiTiet").ToString()
                Else
                    txtDiachi.Text = ""
                End If
                If Not dt.Rows(0)("DienThoai") Is DBNull.Value Then
                    txtDienthoai.Text = dt.Rows(0)("DienThoai").ToString()
                Else
                    txtDienthoai.Text = ""
                End If
                If Not dt.Rows(0)("GhiChu") Is DBNull.Value Then
                    txtghichu.Text = dt.Rows(0)("GhiChu").ToString()
                Else
                    txtghichu.Text = ""
                End If
                If Not dt.Rows(0)("GioiTinh") Is DBNull.Value Then
                    txtgioitinh.Text = dt.Rows(0)("GioiTinh").ToString()
                Else
                    txtgioitinh.Text = ""
                End If
                If Not dt.Rows(0)("NgheNghiep") Is DBNull.Value Then
                    txtnghenghiep.Text = dt.Rows(0)("NgheNghiep").ToString()
                Else
                    txtnghenghiep.Text = ""
                End If

                If Not dt.Rows(0)("NoiLamViec") Is DBNull.Value Then
                    txtnoilv.Text = dt.Rows(0)("NoiLamViec").ToString()
                Else
                    txtnoilv.Text = ""
                End If

                If Not dt.Rows(0)("DiaChiLienHe") Is DBNull.Value Then
                    txtdclienhe.Text = dt.Rows(0)("DiaChiLienHe").ToString()
                Else
                    txtdclienhe.Text = ""
                End If

                If Not dt.Rows(0)("NgaySinh") Is DBNull.Value Then
                    dtNgaySinh.DateTime = dt.Rows(0)("NgaySinh")
                Else
                    dtNgaySinh.Text = ""
                End If

                If Not dt.Rows(0)("Doituong") Is DBNull.Value Then
                    cmbdoituong.EditValue = dt.Rows(0)("Doituong")
                Else
                    cmbdoituong.EditValue = Nothing
                End If

                If Not dt.Rows(0)("SotheBHYT") Is DBNull.Value Then
                    txtsothe.Text = dt.Rows(0)("SotheBHYT").ToString()
                Else
                    txtsothe.Text = ""
                End If
                If Not dt.Rows(0)("TuNgay") Is DBNull.Value Then
                    dtTuNgay.DateTime = dt.Rows(0)("TuNgay")
                Else
                    dtTuNgay.EditValue = ""
                End If
                If Not dt.Rows(0)("DenNgay") Is DBNull.Value Then
                    dtDenNgay.DateTime = dt.Rows(0)("DenNgay")
                Else
                    dtDenNgay.EditValue = ""
                End If
                If cmbdoituong.EditValue = 0 Then
                    If Not dt.Rows(0)("SoNgay") Is DBNull.Value Then
                        If Integer.Parse(dt.Rows(0)("SoNgay")) <= 0 Then
                            MessageBox.Show("Thẻ BHYT đã hết hạn sử dụng...!")
                            cmbdoituong.EditValue = 1
                        End If
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub LichSuKhamBenh()
        Dim d1, d2, d3, d4 As Date
        Dim d, m As Integer
        Dim sql As String
        Dim dt As New DataTable

        sql = String.Format("Select count(SoPhieu) as LSoPhieu from PhieuKhamBenh where MaBN=N'{0}' and Huy=0 and NgayLap between '{1}' and '{2}'", cmbmabn.EditValue, d1, d2)
        dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dt.Rows.Count > 0 Then
            d = dt.Rows(0)(0)
        End If
        '=========================
        sql = String.Format("Select count(SoPhieu) as LSoPhieu from PhieuKhamBenh where MaBN=N'{0}' and Huy=0 and NgayLap between '{1}' and '{2}'", cmbmabn.EditValue, d3, d4)
        dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dt.Rows.Count > 0 Then
            m = dt.Rows(0)(0)
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
            Return 0
            MsgBox("Sản phẩm này chưa có giá bán", MsgBoxStyle.Critical)
        End If
    End Function
    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        IsNew()
        clear_form()
        Dngaylap.EditValue = NgayGioServer()
    End Sub
    Private Sub clear_form()
        Me.cmbloaikham.EditValue = "12-1"
        Me.cmbbacsi.EditValue = ""
        Me.cmbdoituong.EditValue = 1
        Me.cmbmabn.EditValue = ""
        Me.cmbttbn.EditValue = "KK"
        Me.cmbkieukham.EditValue = "KT"
        Me.cmbphongkham.EditValue = "P1"
        Try
            Dim txt As Object
            For Each txt In grb.Controls
                If txt.Name.Substring(0, 3).ToUpper = "TXT" Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception

        End Try
        MaxMa()
        ErrPro.Clear()
    End Sub

    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.cmbloaikham.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbloaikham, "Trường thông tin bắt buộc!")
            ErrPro.SetIconAlignment(Me.cmbloaikham, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbmabn.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbmabn, "Trường thông tin bắt buộc!")
            ErrPro.SetIconAlignment(Me.cmbmabn, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbttbn.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbttbn, "Trường thông tin bắt buộc!")
            ErrPro.SetIconAlignment(Me.cmbttbn, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbloaikham.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbloaikham, "Trường thông tin bắt buộc!")
            ErrPro.SetIconAlignment(Me.cmbloaikham, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbphongkham.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbphongkham, "Trường thông tin bắt buộc!")
            ErrPro.SetIconAlignment(Me.cmbphongkham, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbbacsi.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbbacsi, "Trường thông tin bắt buộc!")
            ErrPro.SetIconAlignment(Me.cmbbacsi, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbdoituong.EditValue Is Nothing Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbdoituong, "Trường thông tin bắt buộc!")
            ErrPro.SetIconAlignment(Me.cmbdoituong, ErrorIconAlignment.MiddleRight)
        End If
        If cmbdoituong.EditValue = 0 Then
            If cmbtuyen.EditValue Is Nothing Then
                Kiem_Tra = False
                ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.ErrPro.SetError(Me.cmbtuyen, "Trường thông tin bắt buộc!")
                ErrPro.SetIconAlignment(Me.cmbtuyen, ErrorIconAlignment.MiddleRight)
            End If
        End If
    End Function

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        If Kiem_Tra() = True Then
            Dim strSQL As String
            If Flag = True Then
                MaxMa()
                Dim cls As clsPhieuKhamBenh = New clsPhieuKhamBenh()
                Dim id As Integer = 0
                id = cls.PHIEUKHAMBENH_ADD(Integer.Parse(txtsohoso.Text), Dngaylap.DateTime, cmbtiepdon.EditValue, cmbmabn.EditValue, Double.Parse("0" + Chuanhoa(txttienkham.Text)), cmbttbn.EditValue, cmbbacsi.EditValue, cmbphongkham.EditValue, cmbloaikham.EditValue, cmbtuyen.EditValue, Integer.Parse(Label26.Text), txtghichukham.Text, cmbdoituong.EditValue, chk_capcuu.Checked, txtNoiChuyenDen.Text)
                If id > 0 Then
                    txtsohoso.Text = id
                    'Thêm vào chi_tiet_new
                    Dim soct As String = GetNextRefNo("KB" + txtsohoso.Text)
                    strSQL = "Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung,Nguoilap,Bacsi,maphong)"
                    strSQL &= "Values('" & txtsohoso.Text & "',N'" & cmbloaikham.EditValue & "',N'1','" & Double.Parse("0" + Chuanhoa(Me.txttienkham.Text)) & "', '" & Double.Parse("0" + Chuanhoa(Me.txttienkham.Text)) & "',"
                    strSQL &= "N'1',N'" & cmbmabn.EditValue.ToString() & "','" & Dngaylap.DateTime & "','" & Double.Parse("0" + Chuanhoa(Me.txttienkham.Text)) & "',N'',N'12',N'" & soct & "',N'' ,N'',N'" & cmbtiepdon.EditValue & "',N'" & Me.cmbbacsi.EditValue & "',N'" & cmbphongkham.EditValue & "')"
                    If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                        If IsNumeric(txttienkham.Text) = 0 Then
                            'Trangthaiphieu()
                        End If
                    End If
                End If
            Else
                strSQL = "Update PHIEUKHAMBENH set Ngaylap = '" & Me.Dngaylap.DateTime & "' ,Nguoilap ='" & Me.cmbtiepdon.EditValue & "',Tienkham = '" & Double.Parse("0" + Chuanhoa(Me.txttienkham.Text)) & "', "
                strSQL &= "LoaiSucKhoe= '" & Me.cmbttbn.EditValue & "', BacSiKham=N'" & Me.cmbbacsi.EditValue & "', PhongKham=N'" & Me.cmbphongkham.EditValue & "' , KieuKham=N'" & Me.cmbloaikham.EditValue & "',"
                strSQL &= "Doituong=" & cmbdoituong.EditValue & ",TuyenBN=" & cmbtuyen.EditValue & ",Is_CapCuu=" & IIf(chk_capcuu.Checked, 1, 0) & ",NoiChuyenDen=N'" & txtNoiChuyenDen.Text & "' Where SOPHIEU = cast('" & txtsohoso.Text & "' as bigint)  "
                If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                    Dim str As String = "Update chi_tiet_new set masp=N'" & cmbloaikham.EditValue & "',Dongia=N'" & Double.Parse("0" + Chuanhoa(Me.txttienkham.Text)) & "',Thanhtien=N'" & Double.Parse("0" + Chuanhoa(Me.txttienkham.Text)) & "',TotalAmount=N'" & Double.Parse("0" + Chuanhoa(Me.txttienkham.Text)) & "',DateLap='" & Dngaylap.DateTime & "',Nguoilap=N'" & cmbtiepdon.EditValue & "',Bacsi=N'" & cmbbacsi.EditValue & "' where idsophieu='" & txtsohoso.Text & "' and loaidv=12"
                    Command_Exc(str, CNNQLPHONGKHAM)
                End If
                Flag = False
            End If
            'Flag = True
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            TK_PhieuKham()
            TK_PhongKham()
            isload = True
            ActiveF()
            btnIn.Enabled = True
            ErrPro.Clear()
            Panel_Button.Enabled = True
        End If
    End Sub
    Private Sub Trangthaiphieu()
        Dim strSQL As String = ""
        strSQL = "Update Chi_tiet_new set Thutien=1,thanhtoan=1 where idsophieu='" & txtsohoso.Text & "'"
        If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
            strSQL = "Update phieukhambenh set Thutien=1 where sophieu='" & txtsohoso.Text & "'"
            Command_Exc(strSQL, CNNQLPHONGKHAM)
        End If
    End Sub
    Private Sub TK_PhieuKham()
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("DanhSach_PhieuKham_TiepDon", CommandType.StoredProcedure, New List(Of String) From {"ngay"}, New List(Of Object) From {Dngaylap.DateTime})
        grv.DataSource = dts.Tables(0)
    End Sub
    Private Sub TK_PhongKham()
        Dim dts As New DataSet
        Dim strSQL As String = String.Format("Select count(k.SoPhieu) as LTiepDon,LKhamXong=(Select count(SoPhieu) from Phieukhambenh where Khamxong<>0 and convert(char(10),ngaylap,101)='{0}' and Phongkham= k.PhongKham and Huy=0),p.TenPhong from phieukhambenh k inner join Phong_ban p on k.PhongKham=p.Maphong where convert(char(10),k.ngaylap,101)='{1}' and k.Huy=0 group by p.TenPhong,k.PhongKham", Dngaylap.DateTime.ToString("MM/dd/yyyy"), Dngaylap.DateTime.ToString("MM/dd/yyyy"))
        dts = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing)
        grv2.DataSource = dts.Tables(0)
        Dim i As Int32
        Dim Tongtiep, Tongkham As Double
        Tongtiep = 0
        Tongkham = 0
        For i = 0 To dts.Tables(0).Rows.Count - 1
            If Not IsDBNull(dts.Tables(0).Rows(i)("LTiepDon")) Then
                Tongtiep += dts.Tables(0).Rows(i)("LTiepDon")
            End If
            If Not IsDBNull(dts.Tables(0).Rows(i)("LKhamXong")) Then
                Tongkham += dts.Tables(0).Rows(i)("LKhamXong")
            End If
        Next
        If Me.GridView2.RowCount > 0 Then
            Me.GridView2.AddNewRow()
            GridView2.UpdateCurrentRow()
            Dim n As Int16
            n = Me.GridView2.RowCount - 1
            Dim row As DataRow
            row = Me.GridView2.GetDataRow(n)
            row("TenPhong") = "Tổng cộng:"
            row("LTiepDon") = Tongtiep
            row("LKhamXong") = Tongkham
        End If
    End Sub
    Private Sub cmbphongkham_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbphongkham.EditValueChanged
        If cmbphongkham.EditValue <> "" Then
            Dim str As String = String.Format("Select Username from Nguoi_su_dung where maphong='{0}'", cmbphongkham.EditValue)
            Dim dts As New DataSet
            dts = BusinessLogic.Data.GetDataset(str, CommandType.Text, Nothing, Nothing)
            If dts.Tables(0).Rows.Count > 0 Then
                cmbbacsi.EditValue = dts.Tables(0).Rows(0)(0)
            Else
                cmbbacsi.EditValue = ""
            End If
            Insolan()
        End If
    End Sub
    Private Sub Insolan()
        Dim str As String
        Dim dtInsolan As New DataTable
        str = "Select COUNT(*)from PHIEUKHAMBENH where PhongKham='" & Me.cmbphongkham.EditValue & "' and Convert(char(10),NgayLap,101) = '" & Today.Date.ToString("MM/dd/yyyy") & "'"
        dtInsolan = BusinessLogic.Data.GetDataset(str, CommandType.Text, Nothing, Nothing).Tables(0)
        If dtInsolan.Rows.Count > 0 Then
            Label26.Text = dtInsolan.Rows(0)(0) + 1
        Else
            Label26.Text = "1"
        End If
    End Sub
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Flag = False
        isload = True
        If isload = True Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    cmbmabn.EditValue = dr("MaBN")
                    Dngaylap.EditValue = dr("NgayLap")
                    cmbphongkham.EditValue = dr("PhongKham").ToString
                    cmbbacsi.EditValue = dr("BacSiKham")
                    cmbloaikham.EditValue = dr("KieuKham")
                    cmbtiepdon.EditValue = dr("NguoiLap")
                    cmbttbn.EditValue = dr("LoaiSucKhoe")
                    txtsohoso.Text = dr("SoPhieu").ToString()
                    If Not dr("TuyenBN") Is DBNull.Value Then
                        cmbtuyen.EditValue = dr("TuyenBN")
                    Else
                        cmbtuyen.EditValue = Nothing
                    End If

                    If Not dr("Doituong") Is DBNull.Value Then
                        cmbdoituong.EditValue = dr("Doituong")
                    End If

                    Try
                        chk_capcuu.Checked = Convert.ToBoolean(dr("Is_CapCuu"))
                    Catch ex As Exception
                        chk_capcuu.Checked = False
                    End Try

                    If Not dr("NoiChuyenDen") Is DBNull.Value Then
                        txtNoiChuyenDen.Text = dr("NoiChuyenDen").ToString()
                    Else
                        txtNoiChuyenDen.Text = ""
                    End If

                    If Not dr("Stt") Is DBNull.Value Then
                        Label26.Text = dr("Stt")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
        Clear_Control(Me)
        ActiveF()
        btnIn.Enabled = True
    End Sub
    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.btnIn.Enabled = False
        Flag = False
        isload = True
        Me.grb.Enabled = True
        Me.grbct.Enabled = True
        Me.grbkb.Enabled = True
    End Sub
    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim strSQL As String
        If MsgBox("Bạn có muốn xoá phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strSQL = "UPDATE PHIEUKHAMBENH SET Huy=1 WHERE SoPhieu = " & Me.txtsohoso.Text & " "
            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                'Xóa Chi_tiet_new
                strSQL = "Update Chi_tiet_NEW set huy=1 WHERE IDSophieu='" & Me.txtsohoso.Text.Trim & "'"
                Command_Exc(strSQL, CNNQLPHONGKHAM)
                MsgBox("Phiếu hiện tại đã được xoá!")
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim frm As New frmShowReport
        Dim dt As New DataTable
        Try
            dt = BusinessLogic.Data.GetDataset("LaySoPhieuKham", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieukham"}, New List(Of Object) From {Long.Parse(txtsohoso.Text)}).Tables(0)
            frm.stt = dt.Rows(0)("t_stt")
            frm.Ngay = Convert.ToDateTime(dt.Rows(0)("t_ngay"))
            frm.hoten = UCase(dt.Rows(0)("HoTenBN"))
            frm.mabn = cmbmabn.EditValue
            frm.strBC = frmShowReport.TenBc.LaySophieukham
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Function LaySTTKham(ByVal sophieukham As String) As String
        Dim sql As String = ""
        Dim stt As Long = 1
        Dim table As DataTable
        table = BusinessLogic.Data.GetDataset("Select STT from STT_KHAM where Id=(select MAX(id) from STT_KHAM where datediff(d,Ngay,Getdate())=0)").Tables(0)
        If table.Rows.Count > 0 Then
            stt = stt + Long.Parse(table.Rows(0)("STT").ToString())
        End If

        table = BusinessLogic.Data.GetDataset("Select STT from STT_KHAM where SoPhieuKham='" & sophieukham & "' and datediff(d,Ngay,Getdate())=0").Tables(0)
        If table.Rows.Count > 0 Then
            stt = Long.Parse(table.Rows(0)("STT").ToString())
        Else
            Command_Exc("insert into STT_KHAM(Ngay,SoPhieuKham,STT) values(Getdate()," & sophieukham & "," & stt & ")", CNNQLPHONGKHAM)
        End If
        Return stt.ToString()
    End Function

    Private Sub btnf5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf5.Click
        TK_PhieuKham()
        TK_PhongKham()
    End Sub

    Private Sub cmbloaikham_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbloaikham.EditValueChanged
        If cmbloaikham.EditValue <> "" Then
            'cmbphongkham.EditValue = ""
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

    Private Sub Dngaylap_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dngaylap.EditValueChanged
        'TK_PhieuKham()
    End Sub
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
            Dim frm1 As Form
            For Each frm1 In Me.OwnedForms
                If (frm1.Name = frm.Name) Then
                    frm1.Activate()
                    Exit Sub
                End If
            Next
            Me.AddOwnedForm(frm)
            frm.ShowDialog()
            Me.RemoveOwnedForm(frm)
            isload = False
        End If
    End Sub
    Private Sub GetFirstValue(ByVal MaBN As String)
        Load_ComboBox("Select mabn[Mã],hotenbn[Bệnh nhân],Dienthoai[Điện thoại] from HoSoBN", cmbmabn, CNNQLPHONGKHAM)
        Me.cmbmabn.EditValue = MaBN
    End Sub

    Private Sub dtNgaySinh_EditValueChanged(sender As Object, e As EventArgs) Handles dtNgaySinh.EditValueChanged
        Try
            Dim ThangTuoi As String = MdlCommon.TinhThangTuoi(dtNgaySinh.DateTime.Date, 3)
            txtThangTuoi.Text = ThangTuoi
        Catch ex As Exception
            txtThangTuoi.Text = ""
        End Try
    End Sub
End Class