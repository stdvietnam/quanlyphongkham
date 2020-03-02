Public Class frmDonThuocMau
    Private Sub frmCauHinhDonThuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Combobox()
        Load_Data()
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Load_Data()
        txtSoDonMau.Text = "0"
    End Sub

    Sub Load_Data()
        Dim sql As String = String.Format("SELECT ID,TenDonThuocMau,DonGia,GhiChu FROM Dm_DonThuocMau")
        Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
        grid_DonMau.DataSource = dt.DefaultView
    End Sub
    Sub Load_DonThang()
        Dim sql As String = String.Format("SELECT ID,IDDonThuocMau,MaSp,SoLuong,LieuDung,GhiChu FROM Dm_DonThuocMau_Ct WHERE IDDonThuocMau='{0}' AND Loai='T'", txtSoDonMau.Text)
        Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
        grid_DonMau_Thang.DataSource = dt.DefaultView
    End Sub
    Sub Load_DonVien()
        Dim sql As String = String.Format("SELECT ID,IDDonThuocMau,MaSp,SoLuong,LieuDung,GhiChu FROM Dm_DonThuocMau_Ct WHERE IDDonThuocMau='{0}' AND Loai='V'", txtSoDonMau.Text)
        Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
        grid_DonMau_Vien.DataSource = dt.DefaultView
    End Sub
    Sub Load_Combobox()
        Dim sql As String = String.Format("SELECT MaSp,TenSp,DonVT,MoTa FROM San_Pham WHERE Manhom=10")
        Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
        RepositoryItemSearchLookUpEdit_MaSp_Thang.DataSource = dt
        RepositoryItemLookUpEdit_DVT_Thang.DataSource = dt

        RepositoryItemSearchLookUpEdit_MaSp_Vien.DataSource = dt
        RepositoryItemLookUpEdit_DVT_Vien.DataSource = dt
        '================
        dt = BusinessLogic.Data.GetDataset("SELECT LieuDung FROM DM_Lieudung").Tables(0)
        Dim dr As DataRow
        For Each dr In dt.Rows
            Me.RepositoryItemComboBox_LieuDung.Items.Add(dr("LieuDung"))
        Next
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle)
        row("ID") = 0
        row("TenDonThuocMau") = ""
        row("DonGia") = 0
        row("GhiChu") = ""
    End Sub
    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Dim row As DataRow
        row = Me.GridView2.GetDataRow(e.RowHandle)
        row("ID") = 0
        row("IDDonThuocMau") = txtSoDonMau.Text
        row("MaSp") = ""
        row("SoLuong") = 1
        row("GhiChu") = ""
    End Sub

    Private Sub GridView3_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView3.InitNewRow
        Dim row As DataRow
        row = Me.GridView3.GetDataRow(e.RowHandle)
        row("ID") = 0
        row("IDDonThuocMau") = txtSoDonMau.Text
        row("MaSp") = ""
        row("SoLuong") = 1
        row("LieuDung") = ""
    End Sub
    Private Sub RepositoryItemButtonEdit_ChiTiet_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit_ChiTiet.ButtonClick
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If Not row Is Nothing Then
            txtSoDonMau.Text = row("ID")
            Load_DonThang()
            Load_DonVien()
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString())
        Try
            If (e.Column.FieldName = "TenDonThuocMau") Then
                If row("ID") > 0 Then
                    Command_Exc(String.Format("UPDATE Dm_DonThuocMau SET TenDonThuocMau=N'{0}' WHERE ID={1}", row("TenDonThuocMau"), row("ID")), CNNQLPHONGKHAM)
                Else
                    Command_Exc(String.Format("INSERT INTO Dm_DonThuocMau(TenDonThuocMau,DonGia,GhiChu) VALUES(N'{0}',0,N'')", row("TenDonThuocMau")), CNNQLPHONGKHAM)
                End If
            End If
        Catch ex As Exception

        End Try
        Me.GridView1.UpdateCurrentRow()
        Load_Data()
    End Sub
    Private Sub GridView2_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If Integer.Parse(txtSoDonMau.Text) > 0 Then
            Dim row As DataRow
            row = Me.GridView2.GetDataRow(e.RowHandle.ToString())
            Try
                If e.Column.FieldName = "MaSp" Or e.Column.FieldName = "SoLuong" Then
                    If row("ID") > 0 Then
                        Command_Exc(String.Format("UPDATE Dm_DonThuocMau_Ct SET MaSp=N'{0}',SoLuong={1},GhiChu=N'{2}' WHERE ID={3}", row("MaSp"), row("SoLuong"), row("GhiChu"), row("ID")), CNNQLPHONGKHAM)
                    Else
                        Command_Exc(String.Format("INSERT INTO Dm_DonThuocMau_Ct(IDDonThuocMau,MaSp,SoLuong,GhiChu,Loai) VALUES({0},N'{1}',{2},N'{3}','T')", txtSoDonMau.Text, row("MaSp"), row("SoLuong"), row("GhiChu")), CNNQLPHONGKHAM)
                    End If
                End If
            Catch ex As Exception

            End Try
            Me.GridView2.UpdateCurrentRow()
            Load_DonThang()
        End If
    End Sub

    Private Sub GridView3_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If Integer.Parse(txtSoDonMau.Text) > 0 Then
            Dim row As DataRow
            row = Me.GridView3.GetDataRow(e.RowHandle.ToString())
            Try
                If e.Column.FieldName = "MaSp" Or e.Column.FieldName = "SoLuong" Or e.Column.FieldName = "LieuDung" Then
                    If row("ID") > 0 Then
                        Command_Exc(String.Format("UPDATE Dm_DonThuocMau_Ct SET MaSp=N'{0}',SoLuong={1},LieuDung=N'{2}',GhiChu=N'{3}' WHERE ID={4}", row("MaSp"), row("SoLuong"), row("LieuDung"), row("GhiChu"), row("ID")), CNNQLPHONGKHAM)
                    Else
                        Command_Exc(String.Format("INSERT INTO Dm_DonThuocMau_Ct(IDDonThuocMau,MaSp,SoLuong,LieuDung,GhiChu,Loai) VALUES({0},N'{1}',{2},N'{3}',N'{4}','V')", txtSoDonMau.Text, row("MaSp"), row("SoLuong"), row("LieuDung"), row("GhiChu")), CNNQLPHONGKHAM)
                    End If
                End If
            Catch ex As Exception

            End Try
            Me.GridView3.UpdateCurrentRow()
            Load_DonVien()
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit_Xoa_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit_Xoa.ButtonClick
        Dim row As DataRow
        row = Me.GridView3.GetDataRow(GridView3.FocusedRowHandle)
        If Not row Is Nothing Then
            If MsgBox("Bạn muốn xoá thuốc này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim sql As String = String.Format("DELETE Dm_DonThuocMau_Ct WHERE ID={0}", row("ID"))
                Command_Exc(sql, CNNQLPHONGKHAM)
            End If
        End If
        Me.GridView3.UpdateCurrentRow()
        Load_DonVien()
    End Sub

    Private Sub RepositoryItemButtonEdit_XoaDon_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit_XoaDon.ButtonClick
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If Not row Is Nothing Then
            If MsgBox("Bạn muốn xoá thuốc này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim sql As String = String.Format("DELETE Dm_DonThuocMau WHERE ID={0}", row("ID"))
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                    sql = String.Format("DELETE Dm_DonThuocMau_Ct WHERE IDDonThuocMau={0}", row("ID"))
                    Command_Exc(sql, CNNQLPHONGKHAM)
                End If
            End If
        End If
    End Sub
End Class