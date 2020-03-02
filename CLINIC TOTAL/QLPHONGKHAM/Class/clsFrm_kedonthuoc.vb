Public Class clsFrm_kedonthuoc
    Public Sub frmXuatnhapClear(ByVal frm As frm_kedonthuoc)
        Dim i As Integer
        frm.CmbKhohang.EditValue = ""
        frm.cmbDonvi.EditValue = ""
        frm.cmbbacsykedon.EditValue = ""
        frm.txtGhichu.EditValue = ""
        frm.txtSophieu.EditValue = ""
        frm.txtSophieukham.EditValue = ""
        frm.txtSophieu.Text = Lay_So_phieu()
        frm.IDPhieuxuat = 0
    End Sub
    Public Function Lay_So_phieu() As Int32
        Dim dtbPhieuXn As New DataTable
        dtbPhieuXn = Load_DataTable("SELECT Max(Sophieu)as Sophieu FROM Tb_kedonthuoc ", CNNQLPHONGKHAM)
        If dtbPhieuXn.Rows.Count > 0 And Not IsDBNull(dtbPhieuXn.Rows(0)("Sophieu")) Then
            Return dtbPhieuXn.Rows(0)("Sophieu") + 1
        Else
            Return 100
        End If
    End Function
    Public Sub DonotSave(ByVal frm As frm_kedonthuoc)
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
    Public Function GetUSDTotal(ByVal frmPXN As frm_kedonthuoc)
        Dim int_i As Integer
        Dim row As DataRowView
        Dim ftotal As Double
        ftotal = 0
        For int_i = 0 To frmPXN.GridView1.RowCount - 2
            row = frmPXN.GridView1.GetRow(int_i)
            If row("KhuyenMai") = False Then
                If IsNumeric(row("Thanhtien")) Then
                    ftotal += Val(row("Thanhtien"))
                End If
            End If
        Next
    End Function
    Public Function FrmCheckValide(ByVal frmPXN As frm_kedonthuoc) As Boolean
        FrmCheckValide = True
        If frmPXN.cmbDonvi.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.cmbDonvi, "Chưa chọn đơn vị")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.cmbDonvi, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.CmbNVBH.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.CmbNVBH, "Chưa chọn nhân viên bán hàng.")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.CmbNVBH, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.CmbKhohang.EditValue = "" Then
            FrmCheckValide = False
            frmPXN.ErrPro.SetError(frmPXN.CmbKhohang, "Chưa chọn kho.")
            frmPXN.ErrPro.SetIconAlignment(frmPXN.CmbKhohang, ErrorIconAlignment.BottomRight)
            frmPXN.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If frmPXN.GridView1.RowCount - 1 = 0 Then
            FrmCheckValide = False
            MsgBox("Không thể cập nhật được phiếu do không tồn tại mặt hàng")
        End If
    End Function

End Class
