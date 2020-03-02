Public Class frmNhomxetnghiem
    Inherits frmBase
    Private Flag As Boolean = False
    Private ID As Int16
    Public IDmoi As String
    Private isload As Boolean = False
    Public Delegate Sub PassData(ByVal value As String, ByVal value2 As String)
    Public Delegate Sub PassDatabn(ByVal value As String)
    Public passData_ As PassDatabn

    Private Sub frmNhomSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_ComboBox("Select Manhom[Mã],Tennhom[Tên nhóm] from nhom_sp order by manhom ", Me.CmbManhom, CNNQLPHONGKHAM)
        LoadData()
        Ctrl_QuyenForm(Me)
        isload = True
    End Sub
    Private Sub LoadData()
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset("SELECT id,manhom,tennhom,ghichu,ID,Id_NhomSp From Tb_NhomXetNghiem", CommandType.Text, Nothing, Nothing).Tables(0)
        Me.grv.DataSource = dtb
    End Sub

    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtManhom.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtManhom, "Trường mã nhóm sản phẩm không để rỗng")
            ErrPro.SetIconAlignment(Me.txtManhom, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtTennhom.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtTennhom, "Trường tên nhóm sản phẩm không để rỗng")
            ErrPro.SetIconAlignment(Me.txtTennhom, ErrorIconAlignment.MiddleRight)
        End If
        If CmbManhom.EditValue = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.CmbManhom, "Thông tin không để rỗng")
            ErrPro.SetIconAlignment(Me.CmbManhom, ErrorIconAlignment.MiddleRight)
        End If
    End Function

    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Try
            If Not passData_ Is Nothing Then
                passData_(Me.txtManhom.Text)
            End If
        Catch ex As Exception
        End Try
        Me.Close()
    End Sub

    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        ID = 0
        Clear_Control(Me.GroupControl1)
        Me.txtManhom.Text = Lay_ma_khach()
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        isload = False
    End Sub

    Public Function Lay_ma_khach() As Int32
        Dim dtbmakh As New DataTable
        dtbmakh = BusinessLogic.Data.GetDataset("SELECT count(MaNhom)as Makh FROM Tb_NhomXetNghiem ", CommandType.Text, Nothing, Nothing).Tables(0)
        If dtbmakh.Rows.Count > 0 And Not IsDBNull(dtbmakh.Rows(0)("makh")) Then
            Return dtbmakh.Rows(0)("makh") + 1
        Else
            Return 10
        End If
    End Function

    Private Sub btnCap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        'If kiemtratrung(txtManhom.Text) = True Then
        If Kiem_Tra() = True Then
            Dim sql As String = ""
            If Flag = True Then
                Try
                    sql = "Insert into tb_nhomxetnghiem(Manhom,Tennhom,GhiChu,Active,Id_NhomSp) values(N'" & Me.txtManhom.Text.Trim() & "', N'" & Me.txtTennhom.Text & "', N'" & Me.TxtMota.Text & "',1,N'" & CmbManhom.EditValue & "')"
                    BusinessLogic.Data.ExecuteNonQuery(sql)
                Catch ex As Exception
                    MsgBox("Chú ý! Mã nhóm sản phẩm đã tồn tại", MsgBoxStyle.Critical)
                End Try
            Else
                Try
                    sql = "update tb_nhomxetnghiem set Manhom=N'" & txtManhom.Text.Trim() & "',Tennhom=N'" & Me.txtTennhom.Text & "',GhiChu=N'" & Me.TxtMota.Text & "',Id_NhomSp=N'" & CmbManhom.EditValue & "' where id=" & Integer.Parse("0" + txtID.Text) & ""
                    BusinessLogic.Data.ExecuteNonQuery(sql)
                    '-- update lại manhom trong san pham --
                    BusinessLogic.Data.ExecuteNonQuery("Update San_Pham set MaNhomXetNghiem=N'" & txtManhom.Text & "' Where MaNhomXetNghiem=N'" & txtManhom_Old.Text & "'")
                Catch ex As Exception
                    MsgBox("Chú ý! Mã nhóm sản phẩm đã tồn tại", MsgBoxStyle.Critical)
                End Try
            End If
            LoadData()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Flag = False
            ErrPro.Dispose()
            isload = True
        End If
        'Else
        'MsgBox("Chú ý! Mã nhóm sản phẩm đã tồn tại", MsgBoxStyle.Critical)
        'End If
    End Sub

    Private Sub btnHuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.GroupControl1.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
        Flag = False
    End Sub

    Private Sub btnSua_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Flag = False
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        isload = True
    End Sub

    Private Sub btnXoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If Me.txtManhom.Text = "" Then
            MsgBox("Bạn chưa chọn đối tượng cần xóa!", MsgBoxStyle.Critical, "Thông báo...")
        Else
            If MsgBox("Bạn có thật sự muốn xoá bản ghi này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BusinessLogic.Data.ExecuteNonQuery("delete tb_nhomxetnghiem where id=" & Integer.Parse("0" + txtID.Text))
                LoadData()
            End If
            isload = True
        End If

    End Sub

    Private Sub frmNhomSP_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset("Select Manhom from nhom_sp where ID=(select Max(ID) from nhom_sp)", CommandType.Text, Nothing, Nothing).Tables(0)
        If dtb.Rows.Count > 0 Then
            IDmoi = dtb.Rows(0)("Manhom")
        End If
    End Sub

    Private Sub txtManhom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtManhom.Text <> "" Then
            Me.txtManhom.Text = Me.txtManhom.Text.TrimStart()
            Me.txtManhom.Text = Me.txtManhom.Text.TrimEnd()
            Me.txtManhom.Text = Me.txtManhom.Text.ToUpper()
            If Len(Me.txtManhom.Text) = 1 Then
                MsgBox("Chú ý! Mã nhóm phải nhập 2 ký tự!", MsgBoxStyle.Critical)
                Me.txtManhom.Focus()
            End If
        End If
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If isload = True Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Me.txtManhom.Text = dr("manhom")
                    Me.txtManhom_Old.Text = dr("manhom")
                    Me.txtTennhom.Text = dr("tennhom")
                    If Not dr("ghichu") Is DBNull.Value Then
                        Me.TxtMota.Text = dr("ghichu")
                    Else
                        Me.TxtMota.Text = ""
                    End If
                    CmbManhom.EditValue = dr("Id_NhomSp")
                    Me.txtID.Text = dr("id")
                End If
            End If
        End If
    End Sub

    Private Function kiemtratrung(ByVal ma As String) As Boolean
        Try
            If BusinessLogic.Data.GetDatatable("SELECT * FROM Tb_NhomXetNghiem WHERE MaNhom=N'" & txtManhom.Text & "'").Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frmNhomxetnghiem_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If Not passData_ Is Nothing Then
                passData_(Me.txtManhom.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class