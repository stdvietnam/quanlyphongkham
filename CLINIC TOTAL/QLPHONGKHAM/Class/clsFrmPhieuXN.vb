Public Class clsFrmPhieuXN
    Public Sub frmXuatnhapClear(ByVal frm As frmPhieuNHAPKHOTHUOC)
        Dim clsObjPxn As New clsXNKho
        Dim i As Integer
        frm.cmbDonvi.EditValue = ""
        'frm.txtCong_no.EditValue = ""
        frm.txtGhichu.EditValue = ""
        frm.txtQuyet_toan.EditValue = ""
        frm.txtSophieu.EditValue = ""
        frm.txtSotien.EditValue = ""
        frm.txtSotienVnd.EditValue = ""
        frm.txtTygia.EditValue = ""
        frm.txtSophieu.Text = clsObjPxn.Lay_So_phieu(frm.blnLoaiphieu)
        frm.IDPhieuxuat = 0
    End Sub
    
    Public Sub DonotSave(ByVal frm As frmPhieuNHAPKHOTHUOC)
        If frm.IDPhieuxuat <> 0 Then
            frm.btnThem.Enabled = False
            frm.btnIn.Enabled = True
            frm.btnThoat.Enabled = True
            frm.DtpNgay.Enabled = True
            frm.grdDinh_khoan.Enabled = False
            frm.btnCap_nhat.Enabled = False
            frm.btnHuy.Enabled = False

            Ctrl_Enable(frm, MdlCommon.Kieu.Huy)
        Else
            frm.btnThem.Enabled = True
            frm.btnThoat.Enabled = True
            frm.btnCap_nhat.Enabled = False
            frm.btnHuy.Enabled = False
            frm.btnSua.Enabled = False
            frm.btnXoa.Enabled = False
            frm.Grb.Enabled = False
            frm.btnIn.Enabled = False

            'frm.cmbDonvi.ShowPopup()
            'frm.cmbDonvi.Focus()
        End If
        If frm.blnDelete = True Then
            frm.btnSua.Enabled = False
            frm.btnXoa.Enabled = False

        End If

    End Sub
    
    Public Sub Print_daily(ByVal frmXN As frmPhieuNHAPKHOTHUOC)
        Dim frm As New frmShowReport
        Dim CatChuoi As String
        If frmXN.IDPhieuxuat <> 0 Then
            CatChuoi = Replace(frmXN.txtQuyet_toan.Text, ",", "")
            Dim arrCatChuoi(2) As String
            arrCatChuoi = Split(CatChuoi, ".", -1, CompareMethod.Text)
            ' frm.strBC = frmShowReport.TenBc.PhieuXN_Daily
            Dim dtb1 As DataTable
            dtb1 = Load_DataTable("Select * from Ten_menu_baocao", CNNQLPHONGKHAM)
            If dtb1.Rows.Count > 0 Then
                frm.strMadv = dtb1.Rows(0)("Tenct")
                frm.strMakh = dtb1.Rows(0)("Diachi")
                frm.Paraval1 = dtb1.Rows(0)("Tel")
                frm.NguoiGD = dtb1.Rows(0)("Fax")
            End If
            frm.IDPhieuTC = CStr(frmXN.IDPhieuxuat)
            frm.Paraval2 = IIf(frmXN.blnLoaiphieu = True, "N", "X")
            frm.TienVND = frmXN.txtSotienVnd.Text
            If frmXN.blnLoaiphieu = True Then
                frm.Title = "PHIẾU NHẬP KHO"
                frm.xuatnhap = "Nhập kho:"
            Else
                frm.Title = "HOÁ ĐƠN KIÊM PHIẾU XUẤT KHO"
                frm.xuatnhap = "Xuất kho:"
            End If
            If UBound(arrCatChuoi) > 0 Then
                If arrCatChuoi(1) = 0 Then
                    frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & "Không" & Space(1) & "đồng"
                Else
                    frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & Mid(DoiSo(arrCatChuoi(1)), 1, Len(DoiSo(arrCatChuoi(1))) - 4) & "đồng"
                End If
            Else
                frm.Bangchu = DoiSo(CatChuoi)
            End If
            frm.Show()
        Else
            MsgBox("Chú ý thông tin phiếu chua có", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub Print(ByVal frmXN As frmPhieuNHAPKHOTHUOC)
        Dim frm As New frmShowReport
        Dim CatChuoi As String
        CatChuoi = Replace(frmXN.txtQuyet_toan.Text, ",", "")
        Dim arrCatChuoi(2) As String
        arrCatChuoi = Split(CatChuoi, ".", -1, CompareMethod.Text)
        frm.strBC = frmShowReport.TenBc.Phieunhap
        frm.IDPhieuTC = CStr(frmXN.IDPhieuxuat)
        frm.Paraval2 = "N"
        frm.TienVND = Double.Parse("0" + Chuanhoa(frmXN.txtSotien.Text)) 'frmXN.txtSotienVnd.Text
        frm.Title = "PHIẾU NHẬP KHO"
        frm.xuatnhap = "Nhập kho:"
        If UBound(arrCatChuoi) > 0 Then
            If arrCatChuoi(1) = 0 Then
                frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & "Không" & Space(1) & "kip"
            Else
                frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & Mid(DoiSo(arrCatChuoi(1)), 1, Len(DoiSo(arrCatChuoi(1))) - 4) & "kip"
            End If
        Else
            frm.Bangchu = DoiSo(CatChuoi)
        End If
        frm.Show()

    End Sub
   
    Public Function GetUSDTotal(ByVal frmPXN As frmPhieuNHAPKHOTHUOC)
        Dim int_i As Integer
        Dim row As DataRowView
        Dim ftotal As Double
        ftotal = 0
        For int_i = 0 To frmPXN.GridView1.RowCount - 2
            row = frmPXN.GridView1.GetRow(int_i)
            If IsNumeric(row("Thanhtien")) Then
                ftotal += Val(row("Thanhtien"))
            End If
        Next
        frmPXN.txtSotien.Text = ftotal
        If IsNumeric(frmPXN.txtSotien.EditValue) Then
            frmPXN.txtSotien.EditValue = Replace(frmPXN.txtSotien.Text, ",", "")
            frmPXN.txtSotien.EditValue = Format(Val(frmPXN.txtSotien.Text), "###,###.####")
        End If
    End Function
     
    Public Function FrmCheckValide(ByVal frmPXN As frmPhieuNHAPKHOTHUOC) As Boolean
        FrmCheckValide = True
        If frmPXN.cmbDonvi.Text = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.cmbDonvi, "Chua ch?n don v?.")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.cmbDonvi, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.CmbNVBH.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.CmbNVBH, "Chua ch?n nhân viên bán hàng.")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.CmbNVBH, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.cmbLoai_xuat.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.cmbLoai_xuat, "Chua ch?n lo?i xu?t.")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.cmbLoai_xuat, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.CmbKhohang.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.CmbKhohang, "Chua ch?n kho.")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.CmbKhohang, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.GridView1.RowCount - 1 = 0 Then
            FrmCheckValide = False
            MsgBox("Không th? c?p nh?t du?c phi?u do không t?n t?i m?t hàng")
        End If
    End Function
    

End Class
