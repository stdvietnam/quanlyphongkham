Public Class ClsKhohang
    Public Function Adddnew(ByVal Ma As String, ByVal Ten As String, ByVal DiaChi As String, ByVal Tenthukho As String, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_ThemKhohang"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaKho"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma
        cmd.Parameters.Add(paraterMa)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@TenKho"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Ten
        cmd.Parameters.Add(paraterTen)

        Dim paraterDiaChi As New SqlClient.SqlParameter
        paraterDiaChi.ParameterName = "@DiaChi"
        paraterDiaChi.DbType = DbType.String
        paraterDiaChi.Direction = ParameterDirection.Input
        paraterDiaChi.Value = DiaChi
        cmd.Parameters.Add(paraterDiaChi)

        Dim paraterTel As New SqlClient.SqlParameter
        paraterTel.ParameterName = "@Tenthukho"
        paraterTel.DbType = DbType.String
        paraterTel.Direction = ParameterDirection.Input
        paraterTel.Value = Tenthukho
        cmd.Parameters.Add(paraterTel)

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
    Public Function Update(ByVal Ma As String, ByVal Ten As String, ByVal DiaChi As String, ByVal Tenthukho As String, ByVal Kieu As Byte, ByVal ID As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_ThemKhohang"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaKho"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma
        cmd.Parameters.Add(paraterMa)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@TenKho"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Ten
        cmd.Parameters.Add(paraterTen)

        Dim paraterDiaChi As New SqlClient.SqlParameter
        paraterDiaChi.ParameterName = "@DiaChi"
        paraterDiaChi.DbType = DbType.String
        paraterDiaChi.Direction = ParameterDirection.Input
        paraterDiaChi.Value = DiaChi
        cmd.Parameters.Add(paraterDiaChi)

        Dim paraterTel As New SqlClient.SqlParameter
        paraterTel.ParameterName = "@Tenthukho"
        paraterTel.DbType = DbType.String
        paraterTel.Direction = ParameterDirection.Input
        paraterTel.Value = Tenthukho
        cmd.Parameters.Add(paraterTel)

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
    Public Function Delete(ByVal Ma As String, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_ThemKhohang"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaKho"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma
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
