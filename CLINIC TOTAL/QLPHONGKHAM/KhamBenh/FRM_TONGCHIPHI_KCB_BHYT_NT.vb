Public Class FRM_TONGCHIPHI_KCB_BHYT_NT
    Private T_TONGCHI, T_XN, T_CDHA, T_THUOC, T_MAU, T_PTTT, T_VTYT, T_DVKT_TYLE, T_THUOC_TYLE, T_VTYT_TYLE, T_KHAM, T_GIUONG, T_VCHUYEN, T_BNTT, T_BHTT, T_NGOAIDS As Decimal

    Private Sub FRM_TONGCHIPHI_KCB_BHYT_NT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        dtTuNgay.DateTime = DateTime.Now
        dtDenNgay.DateTime = DateTime.Now
        Loadcombox()
        Load_Data()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Load_Data()
    End Sub

    Private Sub Load_Data()
        Dim dt As New DataTable()
        dt = BusinessLogic.Data.GetDataset("DS_TongHopChiPhi_KCBBaoHiem_NgoaiTru", CommandType.StoredProcedure, New Generic.List(Of String) From {"tungay", "denngay"}, New Generic.List(Of Object) From {dtTuNgay.DateTime, dtDenNgay.DateTime}).Tables(0)
        grDanhSach.DataSource = dt
    End Sub

    Private Sub Loadcombox()
        Load_ComboBox("Select mabn[Mã],hotenbn[Bệnh nhân],Dienthoai[Điện thoại] from hosobn", cmbMA_BN, CNNQLPHONGKHAM, True)
        Load_ComboBox("select Id[Mã],Ten[Tên] from DM_GIOITINH", cmbGIOI_TINH, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT id[Mã],doituong[Đối tượng] From DM_DOITUONG", cmbDOI_TUONG, CNNQLPHONGKHAM)
        Load_ComboBox("select Id[Mã],Ten[Tên] from DM_GIOITINH", cmbGIOI_TINH, CNNQLPHONGKHAM)
        Load_ComboBox("select Id[Mã],Ten[Tên] from DM_TUYEN_BHYT", cmbTUYENBN, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT CICD10,VVIET FROM ICD10", Me.cmbMA_BENH, CNNQLPHONGKHAM, True)
        Load_ComboBox("select Id[Mã],DinhMuc[Định mức],TenDinhMuc[Tên] from DM_DINHMUC_BHYT", cmbDINH_MUC, CNNQLPHONGKHAM, True)
        Load_ComboBox("select Id[Mã],Ten[Tên] from DM_KETQUA_DT", cmbKET_QUA_DT, CNNQLPHONGKHAM)
        Load_ComboBox("select ID[Mã],Ten[Tên] from DM_LOAI_KCB", cmbMA_LOAIKCB, CNNQLPHONGKHAM)
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        Dim dr As DataRowView
        Dim dt As DataTable
        Dim sovaovien As Long = 0
        dr = Me.GridView2.GetRow(Me.GridView2.FocusedRowHandle)
        If Not dr Is Nothing Then
            dt = New DataTable()
            sovaovien = Long.Parse(dr("Sophieu").ToString())
            dt = BusinessLogic.Data.GetDataset("TongChiPhi_KCB_GetBySoVaoVien", CommandType.StoredProcedure, New Generic.List(Of String) From {"sovaovien"}, New Generic.List(Of Object) From {sovaovien}).Tables(0)
            If dt.Rows.Count > 0 Then
                txtMA_LK.Text = dt.Rows(0)("MA_LK").ToString()
                cmbDOI_TUONG.EditValue = 1
                cmbMA_BN.EditValue = dt.Rows(0)("MA_BN")
                dtNGAY_SINH.DateTime = dt.Rows(0)("NGAY_SINH")
                cmbGIOI_TINH.EditValue = dt.Rows(0)("GIOI_TINH")
                txtDIA_CHI.Text = dt.Rows(0)("DIA_CHI").ToString()
                txtMA_CSKCB.Text = dt.Rows(0)("MA_CSKCB").ToString()
                txtMA_THE.Text = dt.Rows(0)("MA_THE").ToString()
                dtGT_THE_TU.DateTime = dt.Rows(0)("GT_THE_TU")
                dtGT_THE_DEN.DateTime = dt.Rows(0)("GT_THE_DEN")
                txtMA_DKBD.Text = dt.Rows(0)("MA_DKBD").ToString()
                cmbTUYENBN.EditValue = dt.Rows(0)("TUYEN_BN").ToString()
                cmbDINH_MUC.EditValue = dt.Rows(0)("DINH_MUC")
                txtMA_KHUVUC.Text = dt.Rows(0)("MA_KHUVUC").ToString()
                txtTYLE_CHITRA.Text = dt.Rows(0)("TYLE_CHITRA").ToString()

                cmbMA_LOAIKCB.EditValue = dt.Rows(0)("MA_LOAIKCB")
                cmbMA_BENH.EditValue = dt.Rows(0)("MA_BENH")
                txtMA_BENH_KHAC.Text = dt.Rows(0)("MA_BENH_KHAC").ToString()
                dtNGAY_VAO.EditValue = dt.Rows(0)("NGAY_VAO")
                dtNGAY_RA.EditValue = dt.Rows(0)("NGAY_RA")
                txtSO_NGAY_DTRI.Text = dt.Rows(0)("SO_NGAY_DT").ToString()
                cmbKET_QUA_DT.EditValue = dt.Rows(0)("KET_QUA_DTRI")
                cmbTINH_TRANG_RV.EditValue = dt.Rows(0)("TINH_TRANG_RV")

                txtT_TONGCHI.Text = dt.Rows(0)("T_TONGCHI").ToString()
                txtT_XN.Text = dt.Rows(0)("T_XN").ToString()
                txtT_CDHA.Text = dt.Rows(0)("T_CDHA").ToString()
                txtT_THUOC.Text = dt.Rows(0)("T_THUOC").ToString()
                txtT_MAU.Text = dt.Rows(0)("T_MAU").ToString()
                txtT_PTTT.Text = dt.Rows(0)("T_PTTT").ToString()
                txtT_VTYT.Text = dt.Rows(0)("T_VTYT").ToString()
                txtT_DVKT_TYLE.Text = dt.Rows(0)("T_DVKT_TYLE").ToString()
                txtT_THUOC_TYLE.Text = dt.Rows(0)("T_THUOC_TYLE").ToString()
                txtT_VTYT_TYLE.Text = dt.Rows(0)("T_VTYT_TYLE").ToString()
                txtT_KHAM.Text = dt.Rows(0)("T_KHAM").ToString()
                txtT_GIUONG.Text = dt.Rows(0)("T_GIUONG").ToString()
                txtT_VCHUYEN.Text = dt.Rows(0)("T_VCHUYEN").ToString()
                txtT_BNTT.Text = dt.Rows(0)("T_BNTT").ToString()
                txtT_BHTT.Text = dt.Rows(0)("T_BHTT").ToString()
            End If
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnCap_Nhat_Click(sender As Object, e As EventArgs) Handles btnCap_Nhat.Click
        If txtMA_LK.Text.Trim = "0" Then
            'Them mới
        Else
            'Cap nhat
        End If
    End Sub

    Private Sub txtT_XN_Leave(sender As Object, e As EventArgs) Handles txtT_XN.Leave
        TONGTIEN_RELOAD()
    End Sub

    Private Sub TONGTIEN_RELOAD()
        T_XN = Decimal.Parse("0" + txtT_XN.Text)
        T_CDHA = Decimal.Parse("0" + txtT_CDHA.Text)
        T_THUOC = Decimal.Parse("0" + txtT_THUOC.Text)
        T_MAU = Decimal.Parse("0" + txtT_MAU.Text)
        T_PTTT = Decimal.Parse("0" + txtT_PTTT.Text)
        T_VTYT = Decimal.Parse("0" + txtT_VTYT.Text)
        T_DVKT_TYLE = Decimal.Parse("0" + txtT_DVKT_TYLE.Text)
        T_THUOC_TYLE = Decimal.Parse("0" + txtT_THUOC_TYLE.Text)
        T_VTYT_TYLE = Decimal.Parse("0" + txtT_VTYT_TYLE.Text)
        T_KHAM = Decimal.Parse("0" + txtT_KHAM.Text)
        T_GIUONG = Decimal.Parse("0" + txtT_GIUONG.Text)
        T_VCHUYEN = Decimal.Parse("0" + txtT_VCHUYEN.Text)

        T_BNTT = Decimal.Parse("0" + txtT_BNTT.Text)

        T_BHTT = Decimal.Parse("0" + txtT_BHTT.Text)
        T_NGOAIDS = Decimal.Parse("0" + txtT_NGOAIDS.Text)
        '--
        T_TONGCHI = T_XN + T_CDHA + T_THUOC + T_MAU + T_PTTT + T_VTYT + T_DVKT_TYLE + T_THUOC_TYLE + T_VTYT_TYLE + T_KHAM + T_GIUONG + T_VCHUYEN
        T_BNTT = T_TONGCHI * Double.Parse("0" + txtTYLE_CHITRA.Text) * 0.01
        T_BHTT = T_TONGCHI - T_BNTT

        txtT_TONGCHI.Text = T_TONGCHI
        txtT_BNTT.Text = T_BNTT
        txtT_BHTT.Text = T_BHTT
    End Sub


    Private Sub txtT_VTYT_TYLE_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_VTYT_TYLE.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_KHAM_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_KHAM.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_GIUONG_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_GIUONG.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_VCHUYEN_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_VCHUYEN.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_DVKT_TYLE_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_DVKT_TYLE.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_THUOC_TYLE_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_THUOC_TYLE.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_BNTT_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_BNTT.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_VTYT_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_VTYT.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_THUOC_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_THUOC.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_PTTT_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_PTTT.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_CDHA_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_CDHA.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_MAU_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_MAU.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub

    Private Sub txtT_XN_EditValueChanged(sender As Object, e As EventArgs) Handles txtT_XN.EditValueChanged
        TONGTIEN_RELOAD()
    End Sub
End Class