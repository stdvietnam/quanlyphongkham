Imports System.Xml
Public Class clsConnectionInfor
    Public Server As String
    Public Database As String
    Public Username As String
    Public Password As String
    Public Sub Encrypt()
        Dim xmldoc As New XmlDocument
        Dim xmlNode, xmlParentNode As XmlNode
        Dim xmlNodelist As XmlNodeList
        Dim blnMahoa As Boolean
        Dim ds As Encryption64 = New Encryption64
        Dim strPath As String
        strPath = Application.StartupPath
        If Len(strPath) > 4 Then
            If Mid(strPath, Len(strPath) - 3, 4) = "\bin" Then
                strPath = Mid(strPath, 1, Len(strPath) - 4)
            End If
            strPath = strPath & "\" & "Connection.xml"
            xmldoc.Load(strPath)
            xmlNodelist = xmldoc.GetElementsByTagName("add")
            For Each xmlNode In xmlNodelist
                If xmlNode.Attributes("key").Value = "Code" Then
                    If xmlNode.Attributes("value").Value = "0" Then
                        xmlNode.Attributes("value").Value = "1"
                        blnMahoa = True
                    End If
                End If
                If xmlNode.Attributes("key").Value = "Server" Then
                    If blnMahoa = True Then
                        xmlNode.Attributes("value").Value = ds.EncryptToBase64String(xmlNode.Attributes("value").Value, "12345678")
                    End If
                End If
                If xmlNode.Attributes("key").Value = "Database" Then
                    If blnMahoa = True Then
                        xmlNode.Attributes("value").Value = ds.EncryptToBase64String(xmlNode.Attributes("value").Value, "12345678")
                    End If
                End If
                If xmlNode.Attributes("key").Value = "Username" Then
                    If blnMahoa = True Then
                        xmlNode.Attributes("value").Value = ds.EncryptToBase64String(xmlNode.Attributes("value").Value, "12345678")
                    End If
                End If
                If xmlNode.Attributes("key").Value = "Password" Then
                    If blnMahoa = True Then
                        xmlNode.Attributes("value").Value = ds.EncryptToBase64String(xmlNode.Attributes("value").Value, "12345678")
                    End If
                End If
                If xmlNode.Attributes("key").Value = "SerialKey" Then
                    If blnMahoa = True Then
                        xmlNode.Attributes("value").Value = ds.EncryptToBase64String(xmlNode.Attributes("value").Value, "12345678")
                    End If
                End If
            Next
            If blnMahoa = True Then
                xmldoc.Save(strPath)
            End If
        End If
    End Sub
    Public Sub CnnGet()
        Dim xmldoc As New XmlDocument
        Dim xmlNode, xmlParentNode As XmlNode
        Dim xmlNodelist As XmlNodeList
        Dim blnMahoa As Boolean
        Dim ds As Encryption64 = New Encryption64
        Dim strPath As String
        strPath = Application.StartupPath
        If Len(strPath) > 4 Then
            If Mid(strPath, Len(strPath) - 3, 4) = "\bin" Then
                strPath = Mid(strPath, 1, Len(strPath) - 4)
            End If
            strPath = strPath & "\" & "Connection.xml"
            xmldoc.Load(strPath)
            xmlNodelist = xmldoc.GetElementsByTagName("add")
            For Each xmlNode In xmlNodelist
                If xmlNode.Attributes("key").Value = "Code" Then
                    If xmlNode.Attributes("value").Value = "0" Then
                        xmlNode.Attributes("value").Value = "1"
                        blnMahoa = True
                    End If
                End If
                If xmlNode.Attributes("key").Value = "Server" Then
                    Server = ds.DecryptFromBase64String(xmlNode.Attributes("value").Value, "12345678")
                End If
                If xmlNode.Attributes("key").Value = "Database" Then
                    Database = ds.DecryptFromBase64String(xmlNode.Attributes("value").Value, "12345678")
                End If
                If xmlNode.Attributes("key").Value = "Username" Then
                    Username = ds.DecryptFromBase64String(xmlNode.Attributes("value").Value, "12345678")
                End If
                If xmlNode.Attributes("key").Value = "Password" Then
                    Password = ds.DecryptFromBase64String(xmlNode.Attributes("value").Value, "12345678")
                End If
                If xmlNode.Attributes("key").Value = "SerialKey" Then
                    SerialKey = ds.DecryptFromBase64String(xmlNode.Attributes("value").Value, "12345678")
                End If
            Next
        End If
    End Sub
    Public Function strConnectionInfor() As String
        Encrypt()
        CnnGet()
        'Lanhdv them 25/09/2005
        'Begin
        P_Server = Server
        P_Database = Database
        P_Username = Username
        P_Password = Password
        'End
        Return "SERVER=" & Server & ";DATABASE=" & Database & ";UID=" & Username & ";PWD=" & Password & "; Connect TimeOut=1000"
    End Function
End Class


