Imports System.Data.SqlClient
Public Class clsKet_noi
    Private strConnection As String
    Public Function Khoi_taoKn(ByRef Cnn As SqlConnection) As Boolean
        Dim clsObj As New clsConnectionInfor
        Try
            Cnn.ConnectionString = clsObj.strConnectionInfor
            'Cnn.ConnectionString = "Server =VS2; Database=Ketoan;UID=Sa;PWD="
            Cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function CheckSerial() As Boolean
        Dim clsObjCnn As New clsConnectionInfor
        Dim clsObj As New Encryption64
        Dim strKey As String
        'Dim clsObjSecurity As New Security.ClsGetSerialClass
        strKey = VolumeSerialNumber("C:\")
        clsObjCnn.strConnectionInfor()
        If SerialKey = "" Then
            MsgBox("Serial dia cung la:" & strKey)
            Return False
        Else
            If strKey = SerialKey Then
                Return True
            Else
                MsgBox("Serial dia cung la:" & strKey)
                Return False
            End If
        End If
    End Function
    Public Function VolumeSerialNumber(ByVal RootPath As String) As String
        Dim VolLabel As String
        Dim VolSize As Long
        Dim Serial As Long
        Dim MaxLen As Long
        Dim Flags As Long
        Dim Name As String
        Dim NameSize As Long
        Dim s As String

        If GetVolumeSerialNumber(RootPath, VolLabel, VolSize, Serial, MaxLen, Flags, Name, NameSize) Then
            'Create an 8 character string
            s = Hex(Serial)
            'Adds the '-' between the first 4 characters and the last 4 characters
            VolumeSerialNumber = Mid(s, 1, 4) + "-" + Mid(s, 4, 4)
        Else
            'If the call to API function fails the function returns a zero serial number
            VolumeSerialNumber = "0000-0000"
        End If
    End Function
    Private Declare Function GetVolumeSerialNumber Lib "kernel32.dll" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByRef nVolumeNameSize As Long, ByRef lpVolumeSerialNumber As Long, ByRef lpMaximumComponentLength As Long, ByVal lpFileSystemFlags As Long, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Long) As Long
End Class
