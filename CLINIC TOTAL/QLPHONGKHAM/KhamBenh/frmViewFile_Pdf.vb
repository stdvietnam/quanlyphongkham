Public Class frmViewFile_Pdf
    Public filePath As String = ""
    Private Sub frmViewFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(filePath) Then
            PdfViewer1.DocumentFilePath = filePath
        End If
    End Sub
End Class