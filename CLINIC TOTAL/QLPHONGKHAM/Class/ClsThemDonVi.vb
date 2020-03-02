Public Class ClsThemDonVi
    Public Function Adddnew(ByVal Ma As String, ByVal tenvt As String, ByVal Ten As String, ByVal Diachi As String, ByVal Tel As String, ByVal Fax As String, ByVal Email As String, ByVal khoano As Boolean, ByVal Capkh As Int16, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CNNQLPHONGKHAM
        openConnection()
        cmd.CommandText = "Pro_DonVi"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaDV"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma
        cmd.Parameters.Add(paraterMa)

        Dim paraterTenvt As New SqlClient.SqlParameter
        paraterTenvt.ParameterName = "@Tenvt"
        paraterTenvt.DbType = DbType.String
        paraterTenvt.Direction = ParameterDirection.Input
        paraterTenvt.Value = tenvt
        cmd.Parameters.Add(paraterTenvt)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@TenDV"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Ten
        cmd.Parameters.Add(paraterTen)

        Dim paraterDiaChi As New SqlClient.SqlParameter
        paraterDiaChi.ParameterName = "@Diachi"
        paraterDiaChi.DbType = DbType.String
        paraterDiaChi.Direction = ParameterDirection.Input
        paraterDiaChi.Value = Diachi
        cmd.Parameters.Add(paraterDiaChi)

        Dim paraterTel As New SqlClient.SqlParameter
        paraterTel.ParameterName = "@Tel"
        paraterTel.DbType = DbType.String
        paraterTel.Direction = ParameterDirection.Input
        paraterTel.Value = Tel
        cmd.Parameters.Add(paraterTel)

        Dim paraterFax As New SqlClient.SqlParameter
        paraterFax.ParameterName = "@Fax"
        paraterFax.DbType = DbType.String
        paraterFax.Direction = ParameterDirection.Input
        paraterFax.Value = Fax
        cmd.Parameters.Add(paraterFax)

        Dim paraterEmail As New SqlClient.SqlParameter
        paraterEmail.ParameterName = "@Email"
        paraterEmail.DbType = DbType.String
        paraterEmail.Direction = ParameterDirection.Input
        paraterEmail.Value = Email
        cmd.Parameters.Add(paraterEmail)

        Dim paratertinhgiamoi As New SqlClient.SqlParameter
        paratertinhgiamoi.ParameterName = "@Khoano"
        paratertinhgiamoi.DbType = DbType.Boolean
        paratertinhgiamoi.Direction = ParameterDirection.Input
        paratertinhgiamoi.Value = khoano
        cmd.Parameters.Add(paratertinhgiamoi)

        Dim paraterCapkh As New SqlClient.SqlParameter
        paraterCapkh.ParameterName = "@Capkh"
        paraterCapkh.DbType = DbType.Int16
        paraterCapkh.Direction = ParameterDirection.Input
        paraterCapkh.Value = Capkh
        cmd.Parameters.Add(paraterCapkh)


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
    Public Function Update(ByVal Ma As String, ByVal tenvt As String, ByVal Ten As String, ByVal Diachi As String, ByVal Tel As String, ByVal Fax As String, ByVal Email As String, ByVal khoano As Boolean, ByVal Capkh As Int16, ByVal Kieu As Byte, ByVal ID As Int16) As Boolean

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CNNQLPHONGKHAM
        openConnection()
        cmd.CommandText = "Pro_DonVi"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaDV"
        paraterMa.DbType = DbType.String
        paraterMa.Direction = ParameterDirection.Input
        paraterMa.Value = Ma
        cmd.Parameters.Add(paraterMa)

        Dim paraterTenvt As New SqlClient.SqlParameter
        paraterTenvt.ParameterName = "@Tenvt"
        paraterTenvt.DbType = DbType.String
        paraterTenvt.Direction = ParameterDirection.Input
        paraterTenvt.Value = tenvt
        cmd.Parameters.Add(paraterTenvt)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@TenDV"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = Ten
        cmd.Parameters.Add(paraterTen)

        Dim paraterDiaChi As New SqlClient.SqlParameter
        paraterDiaChi.ParameterName = "@Diachi"
        paraterDiaChi.DbType = DbType.String
        paraterDiaChi.Direction = ParameterDirection.Input
        paraterDiaChi.Value = Diachi
        cmd.Parameters.Add(paraterDiaChi)

        Dim paraterTel As New SqlClient.SqlParameter
        paraterTel.ParameterName = "@Tel"
        paraterTel.DbType = DbType.String
        paraterTel.Direction = ParameterDirection.Input
        paraterTel.Value = Tel
        cmd.Parameters.Add(paraterTel)

        Dim paraterFax As New SqlClient.SqlParameter
        paraterFax.ParameterName = "@Fax"
        paraterFax.DbType = DbType.String
        paraterFax.Direction = ParameterDirection.Input
        paraterFax.Value = Fax
        cmd.Parameters.Add(paraterFax)

        Dim paraterEmail As New SqlClient.SqlParameter
        paraterEmail.ParameterName = "@Email"
        paraterEmail.DbType = DbType.String
        paraterEmail.Direction = ParameterDirection.Input
        paraterEmail.Value = Email
        cmd.Parameters.Add(paraterEmail)

        Dim paratertinhgiamoi As New SqlClient.SqlParameter
        paratertinhgiamoi.ParameterName = "@Khoano"
        paratertinhgiamoi.DbType = DbType.Boolean
        paratertinhgiamoi.Direction = ParameterDirection.Input
        paratertinhgiamoi.Value = khoano
        cmd.Parameters.Add(paratertinhgiamoi)

        Dim paraterCapkh As New SqlClient.SqlParameter
        paraterCapkh.ParameterName = "@Capkh"
        paraterCapkh.DbType = DbType.Int16
        paraterCapkh.Direction = ParameterDirection.Input
        paraterCapkh.Value = Capkh
        cmd.Parameters.Add(paraterCapkh)

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
        cmd.Connection = CNNQLPHONGKHAM
        cmd.CommandText = "Pro_DonVi"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMa As New SqlClient.SqlParameter
        paraterMa.ParameterName = "@MaDV"
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
    Public Function Lay_ma_Donvi() As Int32
        Dim dtbmadv As New DataTable
        dtbmadv = Load_DataTable("SELECT Max(cast(madv as int))as Madv FROM Don_vi where madv not in('TT-DST','CTlh','DST','Kle','KML','KML1','KSC')", CNNQLPHONGKHAM)
        If dtbmadv.Rows.Count > 0 And Not IsDBNull(dtbmadv.Rows(0)("Madv")) Then
            Return dtbmadv.Rows(0)("Madv") + 1
        Else
            Return 10
        End If
    End Function

End Class
