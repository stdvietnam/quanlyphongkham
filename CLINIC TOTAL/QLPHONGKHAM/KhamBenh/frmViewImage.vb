Public Class frmViewImage
    Public filePath As String = ""
    Private Sub frmViewImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureEdit1.Image = New Bitmap(filePath)
        PictureEdit1.Properties.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub
End Class