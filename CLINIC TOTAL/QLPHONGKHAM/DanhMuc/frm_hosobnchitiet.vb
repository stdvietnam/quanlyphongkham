Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frm_hosobnchitiet
    Public Mabn As String = ""
    Private dtv As New DataView
    Private ID As Integer
    Private Sub frm_hosobnchitiet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        loaddata()
        Me.GridView1.Columns.Remove(colsize)
        Me.GridView1.Columns.Remove(colfiledata)
    End Sub
    Private Sub loaddata()
        Dim str As String = "select * from hosobn_ct where Mabn='" & Mabn & "'"
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset(str, CommandType.Text, Nothing, Nothing)
        dtv = dts.Tables(0).DefaultView
        Me.GridControl1.DataSource = dts.Tables(0)
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEdit1.Click
        Dim Pages As Int16 = 0
        Dim Openfile = New OpenFileDialog()
        Try
            Openfile.InitialDirectory = "C:\"
            Openfile.Filter = "Image Documents(*.tif; *.tiff; *.mdi)|*.tif; *.tiff; *.mdi|Pdf(*.pdf)|*.pdf|Office(*.doc; *.docx; *.xls; *.xlsx)|*.doc; *.docx; *.xls; *.xlsx"
            Openfile.FilterIndex = 3
            Openfile.Title = "Open a File"
            If (Openfile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                If (Openfile.FileName.EndsWith(".exe")) Then
                    Return
                Else
                    CreateFile(Openfile.FileName)
                End If
            End If
            loaddata()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Public Sub CreateFile(ByVal strFile As String)
        Dim objFileStream As New System.IO.FileStream(strFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)
        Dim intLength As Integer = Convert.ToInt32(objFileStream.Length)
        Dim objData As Byte()
        objData = New Byte(intLength) {}
        Dim strPath As String() = strFile.Split(Convert.ToChar("\"))
        objFileStream.Read(objData, 0, intLength)
        objFileStream.Close()
        Dim dr As DataRow
        For Each dr In dtv.Table.Rows
            Dim Sql As String = "Insert into hosobn_ct (mabn,title,filename,filedata) values(@mabn,@title,@filename,@filedata)"
            Dim mysqlParameters(3) As SqlClient.SqlParameter
            mysqlParameters(0) = New SqlClient.SqlParameter("@mabn", SqlDbType.NVarChar)
            mysqlParameters(0).Value = Mabn
            mysqlParameters(1) = New SqlClient.SqlParameter("@title", SqlDbType.NVarChar)
            mysqlParameters(1).Value = dr("Title")
            mysqlParameters(2) = New SqlClient.SqlParameter("@filename", SqlDbType.NVarChar)
            mysqlParameters(2).Value = strPath(strPath.Length - 1)
            mysqlParameters(3) = New SqlClient.SqlParameter("@filedata", SqlDbType.Binary)
            mysqlParameters(3).Value = objData
            If dr("ID") = 0 Then
                dr("FileName") = strPath(strPath.Length - 1)
                Execute_Query(Sql, CommandType.Text, mysqlParameters)
            End If
        Next
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        dr("ID") = 0
        dr("Title") = ""
        dr("FileName") = ""
        dr("FileData") = Nothing
    End Sub
    Private Sub DownLoadfile()
        Dim FromFolder As String = Nothing
        FromFolder = Application.StartupPath
        Dim r As DataRow = GridView1.GetFocusedDataRow()
        If r Is Nothing Then
            Return
        End If
        Dim strId As String = If((r("ID") Is Nothing OrElse r("ID") Is DBNull.Value), "0", r("ID").ToString())
        If strId = "0" Then
            Return
        End If
        Dim fileName As String = If((r("fileName") Is Nothing OrElse r("fileName") Is DBNull.Value), "", DirectCast(r("fileName"), String))
        Dim strFileToSave As String = ""
        strFileToSave = FromFolder & "\" & fileName
        If System.IO.File.Exists(strFileToSave) Then
            System.IO.File.Delete(strFileToSave)
        End If
        SaveAttachment(strId, strFileToSave)
        System.Diagnostics.Process.Start(strFileToSave)
    End Sub
    Public Sub SaveAttachment(ByVal strId As String, ByVal strFileToSave As String)
        If Not String.IsNullOrEmpty(strId) Then
            Dim str As String = "select * from hosobn_ct where ID='" & strId & "'"
            Dim dts As New DataSet
            dts = BusinessLogic.Data.GetDataset(str, CommandType.Text, Nothing, Nothing)
            Dim objRow As DataRow
            objRow = dts.Tables(0).Rows(0)
            Dim objData As Byte()
            objData = DirectCast(objRow("fileData"), Byte())
            Dim objFileStream As New System.IO.FileStream(strFileToSave, System.IO.FileMode.Create, System.IO.FileAccess.Write)
            objFileStream.Write(objData, 0, objData.Length)
            objFileStream.Close()
        End If
    End Sub
    Private Sub RepositoryItemButtonEdit2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEdit2.Click
        DownLoadfile()
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Me.Close()
    End Sub
    Public Sub DeleteFile()
        Dim r As DataRow = GridView1.GetFocusedDataRow()
        If r Is Nothing Then
            Return
        End If
        Dim strId As String = If((r("ID") Is Nothing OrElse r("ID") Is DBNull.Value), "0", r("ID").ToString())
        If strId = "0" Then
            Return
        End If
        Dim Sql As String = "Delete hosobn_ct where ID='" & strId & "'"
        Command_Exc(Sql, CNNQLPHONGKHAM)
    End Sub
    Private Sub RepositoryItemButtonEdit3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEdit3.Click
        If MsgBox("Bạn có chắc chắn muốn xóa không?", MsgBoxStyle.YesNo, "Thông báo...") = MsgBoxResult.Yes Then
            DeleteFile()
            loaddata()
        End If
    End Sub
End Class