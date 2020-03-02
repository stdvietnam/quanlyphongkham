Imports System.Collections.Generic

Public Class frm_DanhMuc_MaBenh
    Private _Masp As String = ""

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Try
            If txtID.Text <> "0" Then
                Command_Exc("Update DM_MABENH Set MABENH=N'" & txtMaBenh.Text & "',TENBENH=N'" & txtTenBenh.Text & "' Where ID=" & Long.Parse("0" + txtID.Text), CNNQLPHONGKHAM)
            Else
                Command_Exc("Insert Into DM_MABENH(MABENH,TENBENH,GHICHU) Values(N'" & txtMaBenh.Text & "',N'" & txtTenBenh.Text & "',N'')", CNNQLPHONGKHAM)
            End If
            MsgBox("Cập nhật thành công!", MsgBoxStyle.OkOnly)
            Clear_Text()
        Catch ex As Exception
            MsgBox("Cập nhật thất bại!", MsgBoxStyle.RetryCancel)
        End Try
        grv.DataSource = BusinessLogic.Data.GetDataset("Select ID,MABENH,TENBENH From DM_MABENH Order by ID").Tables(0)
        Form_Initial()
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Clear_Text()
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
                        Command_Exc("Delete DM_MABENH Where ID=" & Long.Parse("0" + dr("ID")), CNNQLPHONGKHAM)
                        MsgBox("Xóa bản ghi thành công!", MsgBoxStyle.OkOnly)
                        grv.DataSource = BusinessLogic.Data.GetDataset("Select ID,MABENH,TENBENH From DM_MABENH  Order by ID").Tables(0)
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

    Private Sub frm_DanhMuc_MaBenh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Text()
        Form_Initial()
        grv.DataSource = BusinessLogic.Data.GetDataset("Select ID,MABENH,TENBENH From DM_MABENH  Order by ID").Tables(0)
        CTPXFill()
    End Sub

    Private Sub Clear_Text()
        btnCap_nhat.Text = "Thêm mới"
        txtID.Text = "0"
        txtMaBenh.Text = ""
        txtTenBenh.Text = ""
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim dr As DataRow
        Dim i As Integer
        i = GridView1.FocusedRowHandle
        If i >= 0 Then
            dr = GridView1.GetDataRow(i)
            If Not dr Is Nothing Then
                Me.txtID.Text = dr("ID")
                Me.txtMaBenh.Text = dr("MABENH")
                Me.txtTenBenh.Text = dr("TENBENH")
            End If
        End If
        btnCap_nhat.Text = "Cập nhật"
    End Sub

    Private Sub Form_Initial()
        Dim dt As New DataTable
        Load_ComboBox("SELECT ID,TENBENH FROM DM_MABENH", Me.cmbMabenh, CNNQLPHONGKHAM)
        dt = BusinessLogic.Data.GetDataset("proc_GetListkedon", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {"KT"}).Tables(0)
        Me.RepositoryItemLookUpEdit1.DataSource = dt
        Me.RepositoryItemLookUpEdit2.DataSource = dt
        Me.RepositoryItemLookUpEdit3.DataSource = dt

        dt = BusinessLogic.Data.GetDataset("Select Lieudung from DM_Lieudung", Data.CommandType.Text, Nothing, Nothing).Tables(0)
        Dim dr As DataRow
        For Each dr In dt.Rows
            Me.RepositoryItemComboBox1.Items.Add(dr("Lieudung"))
        Next
    End Sub

    Private Function laygia(ByVal Masp As String) As Double
        Dim Obj As New Object
        Dim dtbtonkho As DataTable
        dtbtonkho = BusinessLogic.Data.GetDataset("Select isnull(dongia,0) as Giaban from san_pham WHERE Masp=N'" & Masp & "'").Tables(0)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("Giaban")
        Else
            MsgBox("Sản phẩm này hiện không còn tồn kho", MsgBoxStyle.Critical)
        End If
    End Function

    Private Sub CTPXFill()
        Dim dt As DataTable
        Dim strSql As String = ""
        If cmbMabenh.EditValue <> Nothing Then
            strSql = "SELECT id,masp,SL as soluong,stt,lieudung FROM DM_MABENH_DONTHUOC WHERE ID_MABENH =" & cmbMabenh.EditValue & ""
        Else
            strSql = "SELECT id,masp,SL as soluong,stt,lieudung FROM DM_MABENH_DONTHUOC WHERE ID_MABENH =-1"
        End If
        dt = BusinessLogic.Data.GetDataset(strSql).Tables(0)
        Me.grdDonThuoc.DataSource = dt
    End Sub

    Private Sub GridView3_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView3.InitNewRow
        Dim row As DataRow
        row = Me.GridView3.GetDataRow(e.RowHandle)
        Dim row1 As DataRow
        row1 = Me.GridView3.GetDataRow(e.RowHandle - 1)
        row("soluong") = 0
        row("lieudung") = ""
        If row.Table.Rows.Count = 0 Then
            row("id") = 0
            row("stt") = 1
        Else
            row("id") = row.Table.Rows.Count + 1
            row("stt") = row.Table.Rows.Count + 1
        End If
    End Sub

    Private Sub GridView3_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString)
        Try
            If e.Column.FieldName = "masp" Then
                _Masp = row("Masp")
            End If
        Catch ex As Exception

        End Try

        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub cmbMabenh_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMabenh.EditValueChanged
        CTPXFill()
    End Sub

    Private Sub GridView3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView3.KeyDown
        Dim i As Int16
        If e.KeyCode = Keys.Delete Then
            Dim dr As DataRowView
            dr = Me.GridView3.GetRow(Me.GridView3.FocusedRowHandle)
            If Not dr Is Nothing Then dr.Delete()
            For i = 0 To Me.GridView3.RowCount - 2
                dr = Me.GridView3.GetRow(i)
                dr("STT") = i + 1
            Next
            GridView3.UpdateCurrentRow()
        End If
    End Sub

    Private Sub SaveEntry()
        Dim dt As New DataTable
        dt = grdDonThuoc.DataSource
        If Not dt Is Nothing Then
            If Not dt.GetChanges(DataRowState.Modified) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Modified).Rows
                    UpdateEntry(row)
                Next
            End If
            If Not dt.GetChanges(DataRowState.Deleted) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Deleted).Rows
                    DeleteEntry(row)
                Next
            End If
            If Not dt.GetChanges(DataRowState.Added) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Added).Rows
                    AddNewEntry(row)
                Next
            End If
            dt.AcceptChanges()
        End If
    End Sub

    Private Sub UpdateEntry(ByVal row As DataRow)
        Dim sql As String
        sql = "UPDATE DM_MABENH_DONTHUOC SET MASP=N'" & row("masp") & "',SL=" & row("soluong") & ",LIEUDUNG=N'" & row("lieudung") & "',STT=" & row("stt") & " WHERE ID=" & row("id") & ""
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub

    Private Sub DeleteEntry(ByVal row As DataRow)
        Dim sql As String
        sql = "DELETE FROM DM_MABENH_DONTHUOC WHERE ID='" & row("id", DataRowVersion.Original) & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub

    Private Sub AddNewEntry(ByVal row As DataRow)
        Dim sql As String
        sql = "INSERT INTO DM_MABENH_DONTHUOC(ID_MABENH,MASP,SL,LIEUDUNG,STT,GHICHU) VALUES(" & cmbMabenh.EditValue & ",N'" & row("masp") & "'," & row("soluong") & ",N'" & row("lieudung") & "'," & row("stt") & ",N'')"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub

    Private Sub btnCapnhat_Donthuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapnhat_Donthuoc.Click
        If cmbMabenh.EditValue = Nothing Then
            Return
        Else
            SaveEntry()
        End If
    End Sub
End Class