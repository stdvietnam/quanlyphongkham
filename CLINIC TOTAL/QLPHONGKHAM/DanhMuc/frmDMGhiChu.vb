Public Class frmDMGhiChu

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If txtTen.Text.Trim.Length > 0 Then
            Try
                If txtID.Text <> "0" Then
                    Command_Exc("Update DM_GhiChu Set GhiChu=N'" & txtTen.Text & "' Where ID=" & Integer.Parse("0" + txtID.Text), CNNQLPHONGKHAM)
                Else
                    Command_Exc("Insert Into DM_GhiChu(GhiChu) Values(N'" & txtTen.Text & "')", CNNQLPHONGKHAM)
                End If
                MsgBox("Cập nhật thành công!", MsgBoxStyle.OkOnly)
                Clear_Text()
            Catch ex As Exception
                MsgBox("Lỗi cập nhật!", MsgBoxStyle.RetryCancel)
            End Try
        Else
            MessageBox.Show("Tên ghi chú không được để trống...!")
            txtTen.Focus()
            Exit Sub
        End If
        grv.DataSource = BusinessLogic.Data.GetDataset("Select ID,GhiChu From DM_GhiChu").Tables(0)
    End Sub

    Private Sub frmDMLieudung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Text()
        grv.DataSource = BusinessLogic.Data.GetDataset("Select ID,GhiChu From DM_GhiChu").Tables(0)
    End Sub

    Private Sub Clear_Text()
        btnCap_nhat.Text = "Thêm mới"
        txtID.Text = "0"
        txtTen.Text = ""
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Clear_Text()
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim dr As DataRow
        Dim i As Integer
        i = GridView1.FocusedRowHandle
        If i >= 0 Then
            dr = GridView1.GetDataRow(i)
            If Not dr Is Nothing Then
                Me.txtID.Text = dr("ID")
                Me.txtTen.Text = dr("GhiChu")
            End If
        End If
        btnCap_nhat.Text = "Cập nhật"
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có thật sự muốn xoá phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Try
                        Command_Exc("Delete DM_LIEUDUNG Where ID=" & Integer.Parse("0" + dr("ID")), CNNQLPHONGKHAM)
                        MsgBox("Xóa bản ghi thành công!", MsgBoxStyle.OkOnly)
                        grv.DataSource = BusinessLogic.Data.GetDataset("Select ID,Lieudung From DM_LIEUDUNG").Tables(0)
                    Catch ex As Exception
                        MsgBox("Có lỗi dữ liệu?", MsgBoxStyle.RetryCancel)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class