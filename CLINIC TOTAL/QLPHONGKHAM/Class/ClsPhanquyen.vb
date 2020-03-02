Public Class ClsPhanquyen
    Public Function AdddnewChild(ByVal Ma_nhom As String, ByVal Ma_Cn As String, ByVal Quyen_Form As String, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_NhomQuyen"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@Ma_nhom"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma_nhom
        cmd.Parameters.Add(paraterMa)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@Ma_Cn"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Ma_Cn
        cmd.Parameters.Add(paraterTen)

        Dim paraterQuyenForm As New SqlClient.SqlParameter
        paraterQuyenForm.ParameterName = "@Quyen_Form"
        paraterQuyenForm.DbType = DbType.String
        paraterQuyenForm.Direction = ParameterDirection.Input
        paraterQuyenForm.Value = Quyen_Form
        cmd.Parameters.Add(paraterQuyenForm)

        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)

        Dim paraterCheck As New SqlClient.SqlParameter
        paraterCheck.ParameterName = "@Check"
        paraterCheck.DbType = DbType.Boolean
        paraterCheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraterCheck)
        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@Check").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()

        End Try
    End Function
    Public Function Update(ByVal Ma_nhom As String, ByVal Quyen As String, ByVal Kieu As Byte, ByVal ID As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_NhomNSD"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@Ma_nhom"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma_nhom
        cmd.Parameters.Add(paraterMa)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@Quyen"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Quyen
        cmd.Parameters.Add(paraterTen)

        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)

        Dim paraterID As New SqlClient.SqlParameter
        paraterID.ParameterName = "@ID"
        paraterID.DbType = DbType.Int16
        paraterID.Direction = ParameterDirection.Input
        paraterID.Value = ID
        cmd.Parameters.Add(paraterID)

        Dim paraterCheck As New SqlClient.SqlParameter
        paraterCheck.ParameterName = "@Check"
        paraterCheck.DbType = DbType.Boolean
        paraterCheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraterCheck)
        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@Check").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function
    Public Function DeleteChild(ByVal Ma_nhom As String, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_NhomQuyen"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@Ma_nhom"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma_nhom
        cmd.Parameters.Add(paraterMa)

        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)

        Dim paraterCheck As New SqlClient.SqlParameter
        paraterCheck.ParameterName = "@Check"
        paraterCheck.DbType = DbType.Boolean
        paraterCheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraterCheck)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function

End Class
