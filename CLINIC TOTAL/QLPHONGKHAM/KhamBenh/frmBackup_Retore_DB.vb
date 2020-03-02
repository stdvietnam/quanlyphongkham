Imports System.Data.SqlClient

Public Class frmBackup_Retore_DB
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub frmBackup_Retore_DB_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        serverName()
    End Sub

    Public Sub serverName()
        Try
            cmd = New SqlCommand("select *  from sys.servers", CNNQLPHONGKHAM)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Me.cbservername.Items.Add(dr(1))
            End While
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Createconnection()
        'cbservername.Items.Clear()
        cmd = New SqlCommand("select * from sys.databases", CNNQLPHONGKHAM)
        dr = cmd.ExecuteReader()
        While dr.Read()
            Me.cbdatabasename.Items.Add(dr(0))
        End While
        dr.Close()
    End Sub

    Public Sub query(ByVal que As String)
        cmd = New SqlCommand(que, CNNQLPHONGKHAM)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub newquery(ByVal que As String)
        cmd = New SqlCommand(que, CNNQLPHONGKHAM)
        cmd.CommandTimeout = 50
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub blank(ByVal str As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            If (String.IsNullOrEmpty(cbservername.Text) Or String.IsNullOrEmpty(cbdatabasename.Text)) Then
                MessageBox.Show("Server Name & Database can not be Blank", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                If (str = "backup") Then
                    SaveFileDialog1.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*"
                    If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
                        query("Backup database " + cbdatabasename.Text + " to disk='" + SaveFileDialog1.FileName + "'")
                        MessageBox.Show("Database BackUp has been created successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Report this to Fix it.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnBackup_Click(sender As System.Object, e As System.EventArgs) Handles btnBackup.Click
        blank("backup")
    End Sub

    Private Sub cbservername_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbservername.SelectedIndexChanged
        Createconnection()
    End Sub

    ' retore
    Public Sub Restore(ByVal sqlcon As SqlConnection, ByVal DatabaseFullPath As String, ByVal backUpPath As String)
        Try
            sqlcon = CNNQLPHONGKHAM
            Cursor.Current = Cursors.WaitCursor
            Dim UseMaster As String = "USE master"
            Dim UseMasterCommand As SqlCommand = New SqlCommand(UseMaster, sqlcon)
            UseMasterCommand.ExecuteNonQuery()
            'The below query will rollback any transaction which is running on that database and brings SQL Server database in a single user mode.
            Dim Alter1 As String = "ALTER DATABASE [" + DatabaseFullPath + "] SET Single_User WITH Rollback Immediate"
            Dim Alter1Cmd As SqlCommand = New SqlCommand(Alter1, sqlcon)
            Alter1Cmd.ExecuteNonQuery()
            'The below query will restore database file from disk where backup was taken ....
            Dim Restore As String = "RESTORE DATABASE [" + DatabaseFullPath + "] FROM DISK = N'" + backUpPath + "' WITH  FILE = 1,  NOUNLOAD,  STATS = 10"
            Dim RestoreCmd As SqlCommand = New SqlCommand(Restore, sqlcon)
            RestoreCmd.ExecuteNonQuery()
            'the below query change the database back to multiuser
            Dim Alter2 As String = "ALTER DATABASE [" + DatabaseFullPath + "] SET Multi_User"
            Dim Alter2Cmd As SqlCommand = New SqlCommand(Alter2, sqlcon)
            Alter2Cmd.ExecuteNonQuery()
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Report this to Fix it.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnRetore_Click(sender As System.Object, e As System.EventArgs) Handles btnRetore.Click
        If (String.IsNullOrEmpty(cbservername.Text) Or String.IsNullOrEmpty(cbdatabasename.Text)) Then
            MessageBox.Show("Server Name & Database can not be Blank", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If (openFileDialog1.ShowDialog() = DialogResult.OK) Then
            OpenFileDialog1.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*"
            Restore(CNNQLPHONGKHAM, cbdatabasename.SelectedItem.ToString(), OpenFileDialog1.FileName)
            MessageBox.Show("Database Backup file has been restore successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        BusinessLogic.Data.ExecuteNonQuery("Clear_Data", CommandType.StoredProcedure, Nothing, Nothing)
        ProgressBar1.Maximum = 100
        ProgressBar1.Step = 1
        For i As Integer = 0 To 100
            Dim pow As Double = Math.Pow(i, i)
            ProgressBar1.Value = i
        Next
    End Sub
End Class