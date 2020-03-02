Public Class FRM_GIAMDINHBAOHIEM
    Private dtb As New DataTable

    Private Sub FRM_GIAMDINHBAOHIEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Grbthongtin.Enabled = True
        Grbduyet.Enabled = True
        DateEdit1.DateTime = DateTime.Now
        Load_ComboBox("Select id[Mã],doituong[Đối tượng] from DM_DOITUONG", cmbdoituong, CNNQLPHONGKHAM)
        Load_ComboBox("select Id[Mã],TenDinhMuc[Tên],DinhMuc[Định mức] from DM_DINHMUC_BHYT", cmbDinhMuc, CNNQLPHONGKHAM)
        Load_ComboBox("select Id[Mã],Ten[Tên] from DM_TUYEN_BHYT", cmbtuyen, CNNQLPHONGKHAM)
        Load_chuaduyet()
    End Sub

    Private Sub LoadDataTogrv()
        Dim sql As String = "select c.ID,c.IDSophieu,s.MaSp,s.TenSp,c.Soluong,c.Dongia,Thanhtien,c.Mabn,DateLap,LoaiDV,DuyetBH,ChapNhanThanhToan "
        sql &= "from Chi_tiet_NEW c join San_Pham s on c.Masp=s.MaSp join PHIEUKHAMBENH p on c.IDSophieu=p.SoPhieu join HOSOBN h on c.Mabn=h.MaBN "
        sql &= "where p.LoaiPhieu=0 and c.Huy=0 and p.SoPhieu='" & txtsohoso.Text & "' and c.Trangthai in (0,1) and  p.DoiTuong=0 order by LoaiDV"
        dtb = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dtb.Rows.Count > 0 Then
            grv.DataSource = dtb
        Else
            grv.DataSource = Nothing
        End If
    End Sub
    Private Sub Load_chuaduyet()
        dtb = BusinessLogic.Data.GetDataset("DuyetBH_GetAll", CommandType.StoredProcedure, New Generic.List(Of String) From {"ngay"}, New Generic.List(Of Object) From {DateEdit1.DateTime}).Tables(0)
        If dtb.Rows.Count > 0 Then
            grv_chuaduyet.DataSource = dtb
        Else
            grv_chuaduyet.DataSource = Nothing
        End If
    End Sub

    Private Sub LoadDataTogrv_Duyetlai()
        Dim sql As String = "select c.ID,IDSophieu,s.MaSp,TenSp,Soluong,c.Dongia,Thanhtien,c.Mabn,DateLap,LoaiDV,DuyetBH,ChapNhanThanhToan "
        sql &= "from Chi_tiet_NEW c join San_Pham s on c.Masp=s.MaSp join PHIEUKHAMBENH p on c.IDSophieu=p.SoPhieu join HOSOBN h on c.Mabn=h.MaBN "
        sql &= "where p.LoaiPhieu=0 and c.Huy=0 and p.SoPhieu='" & txtsohoso.Text & "' and c.Trangthai in (0,1) and h.DoiTuong=0 order by LoaiDV"
        dtb = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dtb.Rows.Count > 0 Then
            grv.DataSource = dtb
        Else
            grv.DataSource = Nothing
        End If
    End Sub

    Private Sub LoadData()
        Dim dt As New DataTable
        Dim strSQL As String = "select isnull(p.ChanDoanLamSang,'') as ChanDoanLamSang,h.MaBN,h.HoTenBN,h.SoTheBHYT,TuNgay,DenNgay,DiaChiChiTiet,g.Ten as Gioitinh,h.NgaySinh,p.Doituong,p.TuyenBN,p.Id_DinhMuc "
        strSQL &= "from PhieuKhamBenh p join HOSOBN h on p.MaBN=h.MaBN join DM_GIOITINH g on g.ID=h.GioiTinh left join DMCHUNG dm on dm.Ma=h.DiaChi where Sophieu='" & txtsohoso.Text & "'"
        dt = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0)(0) Is DBNull.Value Then
                txtcdls.Text = dt.Rows(0)("ChanDoanLamSang").ToString()
                txtmabn.Text = dt.Rows(0)("MaBN").ToString()
                txthoten.Text = dt.Rows(0)("HoTenBN").ToString()
                txtsothe.Text = dt.Rows(0)("SoTheBHYT").ToString()
                If Not dt.Rows(0)("Doituong") Is DBNull.Value Then
                    cmbdoituong.EditValue = dt.Rows(0)("Doituong")
                End If
                If Not dt.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                    txtdiachi.Text = dt.Rows(0)("DiaChiChiTiet").ToString()
                End If
                If Not dt.Rows(0)("TuNgay") Is DBNull.Value Then
                    Date1.DateTime = dt.Rows(0)("TuNgay")
                End If
                If Not dt.Rows(0)("DenNgay") Is DBNull.Value Then
                    Date2.DateTime = dt.Rows(0)("DenNgay")
                End If
                If Not dt.Rows(0)("Gioitinh") Is DBNull.Value Then
                    txtgioitinh.Text = dt.Rows(0)("Gioitinh")
                End If
                dtNgaySinh.DateTime = dt.Rows(0)("NgaySinh")
                cmbtuyen.EditValue = dt.Rows(0)("TuyenBN")
                If Not dt.Rows(0)("Id_DinhMuc") Is DBNull.Value Then
                    cmbDinhMuc.EditValue = dt.Rows(0)("Id_DinhMuc")
                Else
                    cmbDinhMuc.EditValue = Nothing
                End If

            End If
        Else
            txtcdls.Text = String.Empty
            txtmabn.Text = String.Empty
            txthoten.Text = String.Empty
            txtsothe.Text = String.Empty
            txtdiachi.Text = String.Empty
            txtgioitinh.Text = String.Empty
            dtNgaySinh.Text = String.Empty
            Date2.Text = String.Empty
            Date2.Text = String.Empty
            cmbdoituong.EditValue = Nothing
            cmbtuyen.EditValue = Nothing
            cmbDinhMuc.EditValue = Nothing
        End If
    End Sub

    Private Sub MyUpdate()
        Dim sql As String = ""
        dtb = DirectCast(grv.DataSource, DataTable)
        If dtb.Rows.Count > 0 Then
            For Each r As DataRow In dtb.Rows
                If r("DuyetBH") = True Then
                    sql = "Update Chi_tiet_NEW set DuyetBH=1 where ID='" & r("ID") & "'"
                Else
                    sql = "Update Chi_tiet_NEW set DuyetBH=0 where ID='" & r("ID") & "'"
                End If
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                Else
                    MsgBox("Xảy ra lỗi!", MsgBoxStyle.Critical, "Thông báo....")
                End If
            Next
        End If
    End Sub

    Private Sub MyUpdate2()
        Dim sql As String = ""
        dtb = DirectCast(grv.DataSource, DataTable)
        If dtb.Rows.Count > 0 Then
            For Each r As DataRow In dtb.Rows
                If r("ChapNhanThanhToan") = True Then
                    sql = "Update Chi_tiet_NEW set ChapNhanThanhToan=1 where ID='" & r("ID") & "'"
                Else
                    sql = "Update Chi_tiet_NEW set ChapNhanThanhToan=0 where ID='" & r("ID") & "'"
                End If
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                Else
                    MsgBox("Xảy ra lỗi!", MsgBoxStyle.Critical, "Thông báo....")
                End If
            Next
        End If
    End Sub

    Private Sub txtsohoso_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsohoso.KeyUp
        If e.KeyCode = Keys.Enter Then
            chkall.Checked = False
            LoadData()
            If Checkduyetlai.Checked Then
                LoadDataTogrv_Duyetlai()
            Else
                LoadDataTogrv()
            End If

            Me.btnCap_nhat.Enabled = True
        End If
    End Sub

    Private Sub chkall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkall.CheckedChanged
        Dim dr As DataRow
        For Each dr In dtb.Rows
            If chkall.Checked Then
                dr("DuyetBH") = True
            Else
                dr("DuyetBH") = False
            End If
        Next
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If cmbDinhMuc.EditValue = 0 Or cmbDinhMuc.EditValue Is Nothing Then
            MessageBox.Show("Chưa chọn Định mức BHYT...!")
            cmbDinhMuc.Focus()
            Return
        Else
            If Command_Exc("Update PHIEUKHAMBENH set Id_DinhMuc='" & cmbDinhMuc.EditValue & "' where Sophieu='" & txtsohoso.Text & "'", CNNQLPHONGKHAM) = 0 Then
                MyUpdate()
                MyUpdate2()
                Me.btnCap_nhat.Enabled = False
            End If
        End If
    End Sub

    Private Sub Checkduyetlai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Checkduyetlai.CheckedChanged
        LoadData()
        If Checkduyetlai.Checked Then
            LoadDataTogrv_Duyetlai()
        Else
            LoadDataTogrv()
        End If

        Me.btnCap_nhat.Enabled = True
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Load_chuaduyet()
    End Sub

    Private Sub GridView2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        Dim dr As DataRow
        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        If dr.Table.Rows.Count > 0 Then
            txtsohoso.Text = dr("Sophieu").ToString()
            'tai lai 
            chkall.Checked = False
            LoadData()
            If Checkduyetlai.Checked Then
                LoadDataTogrv_Duyetlai()
            Else
                LoadDataTogrv()
            End If
            Me.btnCap_nhat.Enabled = True
        End If
    End Sub
End Class