Imports System.IO

Public Class frmUploadFiles
    Public isClose As Boolean = False
    Public mabn As String = String.Empty
    Private Sub btnChonFiles_Click(sender As Object, e As EventArgs) Handles btnChonFiles.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "All files (*.*)|*.*"
        TextEdit1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            Dim count As Integer = 0
            Dim FName As String()
            Dim Path As String = ""
            Dim pathServer As String = ""
            Dim sql As String = "SELECT Server_Name FROM dbo.Server_Share WHERE ID=1"
            Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
            If dt.Rows.Count > 0 Then
                pathServer = dt.Rows(0)("Server_Name").ToString()
                For Each s As String In OpenFileDialog1.FileNames
                    FName = s.Split("\\")
                    Path = pathServer + "\" + FName(FName.Length - 1)
                    If Not File.Exists(Path) Then
                        File.Copy(s, Path)
                    End If
                    sql = "INSERT INTO TaiLieuDinhKem(TenTaiLieu,Path,MaBN,GhiChu,NgayTao) VALUES(N'" & FName(FName.Length - 1) & "',N'" & Path & "',N'" & mabn & "',N'" & txtGhiChu.Text & "','" & DateTime.Now & "')"
                    If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                        count = count + 1
                    End If
                Next
                MessageBox.Show(Convert.ToString(count) + " Tài liệu được lưu")
                Load_Data()
                OpenFileDialog1.Dispose()
                TextEdit1.Text = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show("Có lỗi xảy ra, kiểm tra thư mục tải lên!")
        End Try


    End Sub

    Private Sub frmUploadFiles_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isClose = True
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Sub Load_Data()
        Dim sql As String = String.Format("SELECT ID,TenTaiLieu,Path,MaBN,GhiChu,NgayTao FROM TaiLieuDinhKem WHERE MaBN=N'{0}'", mabn)
        Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
        GridControl1.DataSource = dt
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0)("GhiChu") Is DBNull.Value Then
                txtGhiChu.Text = dt.Rows(0)("GhiChu").ToString()
            End If
        End If
    End Sub

    Private Sub frmUploadFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim sql As String = String.Empty
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString)
        If (e.Column.FieldName = "TenTaiLieu" Or e.Column.FieldName = "GhiChu") Then
            sql = "UPDATE TaiLieuDinhKem SET TenTaiLieu=N'" & row("TenTaiLieu") & "',GhiChu=N'" & row("GhiChu") & "' WHERE ID=" & row("ID") & ""
            Command_Exc(sql, CNNQLPHONGKHAM)
        End If
        Load_Data()
    End Sub

    Private Sub RepositoryItemButtonEdit_Xem_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit_Xem.ButtonClick
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'System.Diagnostics.Process.Start(row("Path"))
        Dim fi As FileInfo = New FileInfo(row("Path").ToString())
        Dim extn As String = fi.Extension
        If extn.ToLower() = ".pdf" Then
            Dim frm As New frmViewFile_Pdf
            frm.Text = row("TenTaiLieu").ToString()
            frm.filePath = row("Path").ToString()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        ElseIf extn.ToLower() = ".png" Or extn.ToLower() = ".jpg" Then
            Dim frm As New frmViewImage
            frm.Text = row("TenTaiLieu").ToString()
            frm.filePath = row("Path").ToString()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        Else
            System.Diagnostics.Process.Start(row("Path"))
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit_Xoa_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit_Xoa.ButtonClick
        If MsgBox("Bạn có muốn xoá tài liệu này?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Try
                        Command_Exc("DELETE TaiLieuDinhKem Where ID=" & Long.Parse(dr("ID").ToString()), CNNQLPHONGKHAM)
                        MsgBox("Xóa tài liệu thành công!", MsgBoxStyle.OkOnly)
                        Load_Data()
                    Catch ex As Exception
                        MsgBox("Có lỗi dữ liệu?", MsgBoxStyle.RetryCancel)
                    End Try
                End If
            End If
        End If
    End Sub
End Class