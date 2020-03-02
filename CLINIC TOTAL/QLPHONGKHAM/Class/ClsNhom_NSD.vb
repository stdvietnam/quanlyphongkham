Public Class ClsNhom_NSD
    Public Function Adddnew(ByVal Ma_nhom As String, ByVal Ten_nhom As String, ByVal quyen As String, ByVal Kieu As Byte) As Boolean
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
        paraterTen.ParameterName = "@Ten_nhom"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Ten_nhom
        cmd.Parameters.Add(paraterTen)

        Dim paraterquyen As New SqlClient.SqlParameter
        paraterquyen.ParameterName = "@quyen"
        paraterquyen.DbType = DbType.String
        paraterquyen.Direction = ParameterDirection.Input
        paraterquyen.Value = quyen
        cmd.Parameters.Add(paraterquyen)

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
    Public Function Update(ByVal Ma_nhom As String, ByVal Ten_nhom As String, ByVal Kieu As Byte, ByVal ID As Int16) As Boolean
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
        paraterTen.ParameterName = "@Ten_nhom"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Ten_nhom
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
    Public Function Delete(ByVal Ma_nhom As String, ByVal Kieu As Byte) As Boolean
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
