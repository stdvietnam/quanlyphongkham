Public Class Frm_chuyenvien
    Public Flag As Boolean = False
    Public IDPhieu As Int64 = 0
    Private Sub txtmabn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmabn.EditValueChanged
        If txtmabn.Text <> "" Then
            Dim dts As New DataSet
            Dim dt As New DataTable
            Dim strsql As String = "SELECT [MaBN],[HoTenBN],DiaChiChiTiet,case [GioiTinh] when 1 then 'Nam'else N'Nữ' end as [GioiTinh],[DienThoai],namsinh from HOSOBN where Mabn='" & txtmabn.Text & "'"
            dts = BusinessLogic.Data.GetDataset(strsql, CommandType.Text, Nothing, Nothing)
            dt = dts.Tables(0)
            If dt.Rows.Count > 0 Then
                If Not dt.Rows(0)("HoTenBN") Is DBNull.Value Then
                    txtTenBN.Text = dt.Rows(0)("HoTenBN")
                Else
                    txtTenBN.Text = ""
                End If
                If Not dt.Rows(0)("DienThoai") Is DBNull.Value Then
                    txtDienthoai.Text = dt.Rows(0)("DienThoai")
                Else
                    txtDienthoai.Text = ""
                End If

                If Not dt.Rows(0)("GioiTinh") Is DBNull.Value Then
                    txtgioitinh.Text = dt.Rows(0)("GioiTinh")
                Else
                    txtgioitinh.Text = ""
                End If

                If Not dt.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                    txtDiachi.Text = dt.Rows(0)("DiaChiChiTiet")
                Else
                    txtDiachi.Text = ""
                End If
                If Not dt.Rows(0)("namsinh") Is DBNull.Value Then
                    txtnam.Text = dt.Rows(0)("namsinh")
                End If
            End If
        End If

    End Sub

    Private Sub txtnam_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnam.EditValueChanged
        If IsNumeric(txtnam.Text) Then
            txttuoi.Text = CDec(NgayGioServer().Year) - CDec(txtnam.Text)
        End If
    End Sub
    Private Sub loaddata()
        Dim dts As New DataSet
        Dim dtbphieu As New DataTable
        Dim strSql As String
        strSql = "SELECT * FROM tb_chuyenvien WHERE Socv = " & IDPhieu & ""
        dts = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing)
        dtbphieu = dts.Tables(0)
        If dtbphieu.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbphieu.Rows(0)
            txtsohoso.Text = row("Sophieukham")
            cmbbacsi.EditValue = row("Bacsi")
            Dngaylap.DateTime = row("Ngaycv")
            txtsocv.Text = row("Socv").ToString
            txtghichukham.Text = row("tinhtrangbn").ToString
            txtmabn.Text = row("Mabn")
            cmbbvien.EditValue = row("Mabv")
        End If
    End Sub

    Private Sub Frm_chuyenvien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        Dngaylap.EditValue = NgayGioServer()
        Load_ComboBox("Select Username[Mã],Hoten[Bác sĩ] from Nguoi_su_dung ", cmbbacsi, CNNQLPHONGKHAM)
        Load_ComboBox("Select Mabv[Mã],Tenbv[Bẹnh viện] from tb_benhvien ", cmbbvien, CNNQLPHONGKHAM)
        txtsocv.Text = SoCV()
        Ctrl_QuyenForm(Me)
        loaddata()
        If Flag = True Then
            Ctrl_Enable(Me, MdlCommon.Kieu.Them)
            grbkb.Enabled = True
            GroupControl1.Enabled = True
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
            grbkb.Enabled = True
            GroupControl1.Enabled = True
        End If
    End Sub
    Public Function SoCV() As Int64
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset("SELECT Max(cast(Socv as int))as socv FROM Tb_chuyenvien ", CommandType.Text, Nothing, Nothing).Tables(0)
        If dtb.Rows.Count > 0 And Not IsDBNull(dtb.Rows(0)("socv")) Then
            Return dtb.Rows(0)("socv") + 1
        Else
            Return 10
        End If
    End Function

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click
        Dim frm As New FRM_PhieuKham
        frm.xemphieu = True
        frm.IDPhieukham = CInt(txtsohoso.Text)
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
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.cmbbvien.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbbvien, "Dữ liệu không để trống!")
            ErrPro.SetIconAlignment(Me.cmbbvien, ErrorIconAlignment.MiddleRight)
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
                txtsocv.Text = SoCV()
                strSQL = "Insert into tb_chuyenvien(Socv,Ngaycv,Bacsi,MaBN,Tinhtrangbn,Sophieukham,Mabv)"
                strSQL &= " Values('" & Me.txtsocv.Text & "','" & Me.Dngaylap.EditValue & "','" & Me.cmbbacsi.EditValue & "', '" & Me.txtmabn.Text & "',N'" & Me.txtghichukham.Text & "','" & Me.txtsohoso.Text & "','" & Me.cmbbvien.EditValue & "')"
                Command_Exc(strSQL, CNNQLPHONGKHAM)
                'Update chuyenvien

                strSQL = "Update phieukhambenh set chuyenvien=1 Where SOPHIEU = cast('" & txtsohoso.Text & "' as int)"
                Command_Exc(strSQL, CNNQLPHONGKHAM)
            Else
                strSQL = "Update tb_chuyenvien set Ngaycv='" & Dngaylap.DateTime & "',Mabv = '" & Me.cmbbvien.EditValue & "',tinhtrangbn=N'" & Me.txtghichukham.Text & "' Where SOcv = cast('" & txtsocv.Text & "' as int)  "
                If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                    
                End If
            End If
            Flag = True
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Flag = False
        GroupControl1.Enabled = True
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim strSQL As String
        If MsgBox("Bạn có muốn xoá phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strSQL = "delete tb_chuyenvien  WHERE Socv = " & Me.txtsocv.Text & " "
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            'Update cv
            strSQL = "Update Phieukhambenh set chuyenvien=0 WHERE Sophieu='" & Me.txtsohoso.Text.Trim & "'"
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            MsgBox("Phiếu hiện tại đã được xoá!")
            Me.Close()
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class