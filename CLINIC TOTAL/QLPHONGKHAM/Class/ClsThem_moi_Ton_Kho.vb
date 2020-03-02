Public Class ClsThem_moi_Ton_Kho
    Public Function AddNew(ByVal masp As String, ByVal tondau As Double, ByVal toncuoi As Double, ByVal kieu As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CNNQLPHONGKHAM
        openConnection()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_TinhTonkho2"


        Dim paraMaSp As New SqlClient.SqlParameter
        paraMaSp.ParameterName = "@Masp"
        paraMaSp.DbType = DbType.String
        paraMaSp.Direction = ParameterDirection.Input
        paraMaSp.Value = masp
        cmd.Parameters.Add(paraMaSp)

        Dim paraTondau As New SqlClient.SqlParameter
        paraTondau.ParameterName = "@tondau"
        paraTondau.DbType = DbType.Double
        paraTondau.Direction = ParameterDirection.Input
        paraTondau.Value = tondau
        cmd.Parameters.Add(paraTondau)

        Dim paraToncuoi As New SqlClient.SqlParameter
        paraToncuoi.ParameterName = "@toncuoi"
        paraToncuoi.DbType = DbType.Double
        paraToncuoi.Direction = ParameterDirection.Input
        paraToncuoi.Value = toncuoi
        cmd.Parameters.Add(paraToncuoi)

        Dim paraKieu As New SqlClient.SqlParameter
        paraKieu.ParameterName = "@Kieu"
        paraKieu.DbType = DbType.Int16
        paraKieu.Direction = ParameterDirection.Input
        paraKieu.Value = kieu
        cmd.Parameters.Add(paraKieu)

        Dim paracheck As New SqlClient.SqlParameter
        paracheck.ParameterName = "@Check"
        paracheck.DbType = DbType.Boolean
        paracheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paracheck)

        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@Check").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            closeConnection()
        End Try
    End Function
    Public Function Delete(ByVal masp As String, ByVal kieu As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CNNQLPHONGKHAM
        openConnection()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_TinhTonkho2"

        Dim paraMaSp As New SqlClient.SqlParameter
        paraMaSp.ParameterName = "@Masp"
        paraMaSp.DbType = DbType.String
        paraMaSp.Direction = ParameterDirection.Input
        paraMaSp.Value = masp
        cmd.Parameters.Add(paraMaSp)

        Dim paraKieu As New SqlClient.SqlParameter
        paraKieu.ParameterName = "@Kieu"
        paraKieu.DbType = DbType.Int16
        paraKieu.Direction = ParameterDirection.Input
        paraKieu.Value = kieu
        cmd.Parameters.Add(paraKieu)

        Dim paracheck As New SqlClient.SqlParameter
        paracheck.ParameterName = "@Check"
        paracheck.DbType = DbType.Boolean
        paracheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paracheck)

        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@Check").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            closeConnection()
        End Try
    End Function
End Class
