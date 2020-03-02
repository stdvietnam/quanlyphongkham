Public Class ClsDMquy
    Public Function Adddnew(ByVal Maquy As String, ByVal Tenquy As String, ByVal NH As Boolean, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_DMQuy"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@Maquy"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Maquy
        cmd.Parameters.Add(paraterMa)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@Tenquy"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Tenquy
        cmd.Parameters.Add(paraterTen)

        Dim paraterLoaiquy As New SqlClient.SqlParameter
        paraterLoaiquy.ParameterName = "@NH"
        paraterLoaiquy.DbType = DbType.Boolean
        paraterLoaiquy.Direction = ParameterDirection.Input
        paraterLoaiquy.Value = NH
        cmd.Parameters.Add(paraterLoaiquy)

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
    Public Function Update(ByVal MaQuy As String, ByVal TenQuy As String, ByVal NH As Boolean, ByVal Kieu As Byte, ByVal ID As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_DMQuy"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaQuy"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = MaQuy
        cmd.Parameters.Add(paraterMa)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@TenQuy"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = TenQuy
        cmd.Parameters.Add(paraterTen)

        Dim paraterLoaiquy As New SqlClient.SqlParameter
        paraterLoaiquy.ParameterName = "@NH"
        paraterLoaiquy.DbType = DbType.Boolean
        paraterLoaiquy.Direction = ParameterDirection.Input
        paraterLoaiquy.Value = NH
        cmd.Parameters.Add(paraterLoaiquy)

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
    Public Function Delete(ByVal MaQuy As String, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_DMQuy"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaQuy"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = MaQuy
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
