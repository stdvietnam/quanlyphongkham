Public Class ClsNguoi_SD
    Public Function Adddnew(ByVal Hoten As String, ByVal Username As String, ByVal Password As String, ByVal Maphong As String, ByVal Manhom As String, ByVal Ghichu As String, ByVal Kieu As Byte, ByVal MaKhoa As String) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_Nguoisd"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterhoten As New SqlClient.SqlParameter
        paraterhoten.ParameterName = "@Hoten"
        paraterhoten.DbType = DbType.String
        paraterhoten.Direction = ParameterDirection.Input
        paraterhoten.Value = Hoten
        cmd.Parameters.Add(paraterhoten)

        Dim paraterusername As New SqlClient.SqlParameter
        paraterusername.ParameterName = "@username"
        paraterusername.DbType = DbType.String
        paraterusername.Direction = ParameterDirection.Input
        paraterusername.Value = Username
        cmd.Parameters.Add(paraterusername)

        Dim paraterpassword As New SqlClient.SqlParameter
        paraterpassword.ParameterName = "@password"
        paraterpassword.DbType = DbType.String
        paraterpassword.Direction = ParameterDirection.Input
        paraterpassword.Value = Password
        cmd.Parameters.Add(paraterpassword)

        Dim paratermaphong As New SqlClient.SqlParameter
        paratermaphong.ParameterName = "@maphong"
        paratermaphong.DbType = DbType.String
        paratermaphong.Direction = ParameterDirection.Input
        paratermaphong.Value = Maphong
        cmd.Parameters.Add(paratermaphong)

        Dim paratermanhom As New SqlClient.SqlParameter
        paratermanhom.ParameterName = "@manhom"
        paratermanhom.DbType = DbType.String
        paratermanhom.Direction = ParameterDirection.Input
        paratermanhom.Value = Manhom
        cmd.Parameters.Add(paratermanhom)

        Dim paratermakhoa As New SqlClient.SqlParameter
        paratermakhoa.ParameterName = "@MaKhoa"
        paratermakhoa.DbType = DbType.String
        paratermakhoa.Direction = ParameterDirection.Input
        paratermakhoa.Value = MaKhoa
        cmd.Parameters.Add(paratermakhoa)

        Dim paraterghichu As New SqlClient.SqlParameter
        paraterghichu.ParameterName = "@ghichu"
        paraterghichu.DbType = DbType.String
        paraterghichu.Direction = ParameterDirection.Input
        paraterghichu.Value = Ghichu
        cmd.Parameters.Add(paraterghichu)

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
    Public Function Update(ByVal Hoten As String, ByVal Username As String, ByVal Password As String, ByVal Maphong As String, ByVal Manhom As String, ByVal ghichu As String, ByVal Kieu As Int16, ByVal ID As Int32, ByVal MaKhoa As String) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_Nguoisd"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterhoten As New SqlClient.SqlParameter
        paraterhoten.ParameterName = "@Hoten"
        paraterhoten.DbType = DbType.String
        paraterhoten.Direction = ParameterDirection.Input
        paraterhoten.Value = Hoten
        cmd.Parameters.Add(paraterhoten)

        Dim paraterusername As New SqlClient.SqlParameter
        paraterusername.ParameterName = "@username"
        paraterusername.DbType = DbType.String
        paraterusername.Direction = ParameterDirection.Input
        paraterusername.Value = Username
        cmd.Parameters.Add(paraterusername)

        Dim paraterpassword As New SqlClient.SqlParameter
        paraterpassword.ParameterName = "@password"
        paraterpassword.DbType = DbType.String
        paraterpassword.Direction = ParameterDirection.Input
        paraterpassword.Value = Password
        cmd.Parameters.Add(paraterpassword)

        Dim paratermaphong As New SqlClient.SqlParameter
        paratermaphong.ParameterName = "@maphong"
        paratermaphong.DbType = DbType.String
        paratermaphong.Direction = ParameterDirection.Input
        paratermaphong.Value = Maphong
        cmd.Parameters.Add(paratermaphong)

        Dim paratermanhom As New SqlClient.SqlParameter
        paratermanhom.ParameterName = "@manhom"
        paratermanhom.DbType = DbType.String
        paratermanhom.Direction = ParameterDirection.Input
        paratermanhom.Value = Manhom
        cmd.Parameters.Add(paratermanhom)

        Dim paratermakhoa As New SqlClient.SqlParameter
        paratermakhoa.ParameterName = "@MaKhoa"
        paratermakhoa.DbType = DbType.String
        paratermakhoa.Direction = ParameterDirection.Input
        paratermakhoa.Value = MaKhoa
        cmd.Parameters.Add(paratermakhoa)

        Dim paraterghichu As New SqlClient.SqlParameter
        paraterghichu.ParameterName = "@ghichu"
        paraterghichu.DbType = DbType.String
        paraterghichu.Direction = ParameterDirection.Input
        paraterghichu.Value = ghichu
        cmd.Parameters.Add(paraterghichu)

        Dim paraterID As New SqlClient.SqlParameter
        paraterID.ParameterName = "@ID"
        paraterID.DbType = DbType.Int32
        paraterID.Direction = ParameterDirection.Input
        paraterID.Value = ID
        cmd.Parameters.Add(paraterID)


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
    Public Function Delete(ByVal Username As String, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_Nguoisd"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterUsername As New SqlClient.SqlParameter
        paraterUsername.ParameterName = "@Username"
        paraterUsername.DbType = DbType.String
        paraterUsername.Direction = ParameterDirection.Input
        paraterUsername.Value = Username
        cmd.Parameters.Add(paraterUsername)


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
