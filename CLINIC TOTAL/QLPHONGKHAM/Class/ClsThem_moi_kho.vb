Public Class ClsThem_moi_kho
    Public Function addnew(ByVal makho As String, ByVal kieu As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_TinhTonkho3"

        Dim paramakho As New SqlClient.SqlParameter
        paramakho.ParameterName = "@makho"
        paramakho.DbType = DbType.String
        paramakho.Direction = ParameterDirection.Input
        paramakho.Value = makho
        cmd.Parameters.Add(paramakho)

        Dim parakieu As New SqlClient.SqlParameter
        parakieu.ParameterName = "@kieu"
        parakieu.DbType = DbType.Int16
        parakieu.Direction = ParameterDirection.Input
        parakieu.Value = kieu
        cmd.Parameters.Add(parakieu)

        Dim paraCheck As New SqlClient.SqlParameter
        paraCheck.ParameterName = "@check"
        paraCheck.DbType = DbType.Boolean
        paraCheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraCheck)

        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@check").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            closeConnection()
        End Try
    End Function
    Public Function Delete(ByVal makho As String, ByVal kieu As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_TinhTonkho3"

        Dim paramakho As New SqlClient.SqlParameter
        paramakho.ParameterName = "@makho"
        paramakho.DbType = DbType.String
        paramakho.Direction = ParameterDirection.Input
        paramakho.Value = makho
        cmd.Parameters.Add(paramakho)

        Dim parakieu As New SqlClient.SqlParameter
        parakieu.ParameterName = "@kieu"
        parakieu.DbType = DbType.Int16
        parakieu.Direction = ParameterDirection.Input
        parakieu.Value = kieu
        cmd.Parameters.Add(parakieu)

        Dim paraCheck As New SqlClient.SqlParameter
        paraCheck.ParameterName = "@check"
        paraCheck.DbType = DbType.Boolean
        paraCheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraCheck)

        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@check").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            closeConnection()
        End Try
    End Function

End Class
