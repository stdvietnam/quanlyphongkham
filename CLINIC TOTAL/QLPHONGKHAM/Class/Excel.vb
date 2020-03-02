Imports System.IO
Imports System.Data.OleDb

Public Class Excel
    Public Shared Function Load(ByVal dir As String, ByVal dt As DataTable, ByVal query As String) As String
        Dim result As String = ""
        Dim conString As String
        Dim sheetName As String
        If (File.Exists(dir) And (Path.GetExtension(dir).ToLower() = ".xls" Or Path.GetExtension(dir).ToLower() = ".xlsx")) Then
            If (Path.GetExtension(dir).ToLower() = ".xls") Then
                conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'"
            Else
                conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=YES;'" 'IMEX=0'"
            End If
            conString = String.Format(conString, dir)
            Dim cnn As New OleDbConnection(conString)
            cnn.Open()
            If (cnn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing).Rows.Count > 0) Then
                sheetName = cnn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing).Rows(0)("TABLE_NAME").ToString()
                query = String.Format(query, sheetName)
                Dim da As New OleDbDataAdapter(query, cnn)
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    dt = Nothing
                    result = "Lấy dữ liệu từ file exel thất bại." & vbNewLine & vbNewLine & ex.Message
                Finally
                    If (cnn.State = ConnectionState.Open Or cnn.State = ConnectionState.Connecting) Then
                        cnn.Close()
                    End If
                End Try
            Else
                result = "File exel không hợp lệ. (Không tìm thấy Sheet hợp lệ.)"
            End If
        Else
            result = "File không tồn tại, hoặc không phải file exel."
        End If
        Return result
    End Function
End Class
