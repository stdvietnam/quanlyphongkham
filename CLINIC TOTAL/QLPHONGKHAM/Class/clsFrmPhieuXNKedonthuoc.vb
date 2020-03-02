Public Class clsFrmPhieuXNKedonthuoc
    Public Sub frmXuatnhapClear(ByVal frm As frmPhieuXN)
        Dim clsObjPxn As New clsXNKho
        frm.cmbMakh.EditValue = ""
        frm.txtGhichu.EditValue = ""
        frm.txtSophieu.EditValue = ""
        frm.txtSotienVnd.EditValue = ""
        frm.txtTygia.EditValue = ""
        frm.txtSophieu.Text = clsObjPxn.Lay_So_phieu(frm.blnLoaiphieu)
        frm.IDPhieuxuat = 0
    End Sub
    Public Sub DonotSave(ByVal frm As frmPhieuXN)
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
        End If
        If frm.blnDelete = True Then
            frm.btnSua.Enabled = False
            frm.btnXoa.Enabled = False
        End If
    End Sub
    Public Sub Print_daily(ByVal frmXN As frmPhieuXN)
        Dim frm As New frmShowReport
        Dim CatChuoi As String
        If frmXN.IDPhieuxuat <> 0 Then
            CatChuoi = Replace(frmXN.txtSotienVnd.Text, ",", "")
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
    Public Sub Print(ByVal frmXN As frmPhieuXN)
        Dim frm As New frmShowReport
        Dim CatChuoi As String
        CatChuoi = Replace(frmXN.txtSotienVnd.Text, ",", "")
        Dim arrCatChuoi(2) As String
        arrCatChuoi = Split(CatChuoi, ".", -1, CompareMethod.Text)
        If frmXN.Name = "frmPhieuXNHC" Then
            frm.strBC = frmShowReport.TenBc.PhieuxuatHC
        Else
            frm.strBC = frmShowReport.TenBc.PhieuXN
        End If
        frm.IDPhieuTC = CStr(frmXN.IDPhieuxuat)
        If frmXN.CmbKhohang.EditValue = "KHC" Then
            frm.Title = "PHIẾU XUẤT HÓA CHẤT"
        ElseIf frmXN.CmbKhohang.EditValue = "KVTYT" Then
            frm.Title = "PHIẾU XUẤT VTYT"
        Else
            frm.Title = "PHIẾU PHÁT THUỐC"
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
    End Sub
    Public Function GetUSDTotal(ByVal frmPXN As frmPhieuXN)
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
        frmPXN.txtSotienVnd.Text = ftotal
        If IsNumeric(frmPXN.txtSotienVnd.EditValue) Then
            frmPXN.txtSotienVnd.EditValue = Replace(frmPXN.txtSotienVnd.Text, ",", "")
            frmPXN.txtSotienVnd.EditValue = Format(Val(frmPXN.txtSotienVnd.Text), "###,###.####")
        End If
    End Function
    Public Function GetTotal_donthuoc(ByVal frm_donthuoc As frm_kedonthuoc)
        Dim int_i As Integer
        Dim row As DataRowView
        Dim ftotal As Double
        ftotal = 0
        For int_i = 0 To frm_donthuoc.GridView1.RowCount - 2
            row = frm_donthuoc.GridView1.GetRow(int_i)
            If IsNumeric(row("Thanhtien")) Then
                ftotal += Val(row("Thanhtien"))
            End If
        Next
        frm_donthuoc.txtSotien.Text = ftotal
        If IsNumeric(frm_donthuoc.txtSotien.EditValue) Then
            frm_donthuoc.txtSotien.EditValue = Replace(frm_donthuoc.txtSotien.Text, ",", "")
            frm_donthuoc.txtSotien.EditValue = Format(Val(frm_donthuoc.txtSotien.Text), "###,###.####")
        End If
    End Function
    Public Function FrmCheckValide(ByVal frmPXN As frmPhieuXN) As Boolean
        FrmCheckValide = True
        If frmPXN.cmbMakh.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.cmbMakh, "Dữ liệu không để trống!")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.cmbMakh, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.CmbNVBH.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.CmbNVBH, "Dữ liệu không để trống!")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.CmbNVBH, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.cmbLoai_xuat.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.cmbLoai_xuat, "Dữ liệu không để trống!")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.cmbLoai_xuat, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.CmbKhohang.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.CmbKhohang, "Dữ liệu không để trống!")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.CmbKhohang, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.GridView1.RowCount - 1 = 0 Then
            FrmCheckValide = False
            MsgBox("Không thể cập nhật được phiếu ")
        End If
    End Function
End Class
