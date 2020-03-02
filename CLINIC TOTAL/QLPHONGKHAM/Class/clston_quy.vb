Public Class clston_quy
    Public Function addnew(ByVal maquy As String, ByVal ngay As DateTime, ByVal toncuoiUSD As Double, ByVal toncuoiVND As Double, ByVal kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "pro_ton_quy"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraMaquy As New SqlClient.SqlParameter
        paraMaquy.ParameterName = "@Maquy"
        paraMaquy.DbType = DbType.String
        paraMaquy.Direction = ParameterDirection.Input
        paraMaquy.Value = maquy
        cmd.Parameters.Add(paraMaquy)

        Dim parangay As New SqlClient.SqlParameter
        parangay.ParameterName = "@Ngay"
        parangay.DbType = DbType.DateTime
        parangay.Direction = ParameterDirection.Input
        parangay.Value = ngay
        cmd.Parameters.Add(parangay)

        Dim paratoncuoiUSD As New SqlClient.SqlParameter
        paratoncuoiUSD.ParameterName = "@toncuoiUSD"
        paratoncuoiUSD.DbType = DbType.Double
        paratoncuoiUSD.Direction = ParameterDirection.Input
        paratoncuoiUSD.Value = toncuoiUSD
        cmd.Parameters.Add(paratoncuoiUSD)

        Dim paratoncuoiVND As New SqlClient.SqlParameter
        paratoncuoiVND.ParameterName = "@toncuoiVND"
        paratoncuoiVND.DbType = DbType.Double
        paratoncuoiVND.Direction = ParameterDirection.Input
        paratoncuoiVND.Value = toncuoiVND
        cmd.Parameters.Add(paratoncuoiVND)

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
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function

    Public Function update(ByVal maquy As String, ByVal ngay As DateTime, ByVal toncuoiUSD As Double, ByVal toncuoiVND As Double, ByVal kieu As Byte, ByVal id As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "pro_ton_quy"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraMaquy As New SqlClient.SqlParameter
        paraMaquy.ParameterName = "@Maquy"
        paraMaquy.DbType = DbType.String
        paraMaquy.Direction = ParameterDirection.Input
        paraMaquy.Value = maquy
        cmd.Parameters.Add(paraMaquy)

        Dim parangay As New SqlClient.SqlParameter
        parangay.ParameterName = "@Ngay"
        parangay.DbType = DbType.DateTime
        parangay.Direction = ParameterDirection.Input
        parangay.Value = ngay
        cmd.Parameters.Add(parangay)

        Dim paratoncuoiUSD As New SqlClient.SqlParameter
        paratoncuoiUSD.ParameterName = "@toncuoiUSD"
        paratoncuoiUSD.DbType = DbType.Double
        paratoncuoiUSD.Direction = ParameterDirection.Input
        paratoncuoiUSD.Value = toncuoiUSD
        cmd.Parameters.Add(paratoncuoiUSD)

        Dim paratoncuoiVND As New SqlClient.SqlParameter
        paratoncuoiVND.ParameterName = "@toncuoiVND"
        paratoncuoiVND.DbType = DbType.Double
        paratoncuoiVND.Direction = ParameterDirection.Input
        paratoncuoiVND.Value = toncuoiVND
        cmd.Parameters.Add(paratoncuoiVND)

        Dim paraID As New SqlClient.SqlParameter
        paraID.ParameterName = "@ID"
        paraID.DbType = DbType.Int16
        paraID.Direction = ParameterDirection.Input
        paraID.Value = id
        cmd.Parameters.Add(paraID)

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
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function
    Public Function delete(ByVal maquy As String, ByVal kieu As Byte) As Boolean

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "pro_ton_quy"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraMaquy As New SqlClient.SqlParameter
        paraMaquy.ParameterName = "@Maquy"
        paraMaquy.DbType = DbType.String
        paraMaquy.Direction = ParameterDirection.Input
        paraMaquy.Value = maquy
        cmd.Parameters.Add(paraMaquy)

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
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function


End Class
