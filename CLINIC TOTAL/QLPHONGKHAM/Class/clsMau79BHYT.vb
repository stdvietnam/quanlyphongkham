Imports System.Data.SqlClient
Public Class clsMau79BHYT
#Region "Them"
    Public Function Mau79BHYT_Add(ByVal SO_VAO_VIEN As Long, ByVal T_TONGCHI As Decimal, ByVal T_XN As Decimal, ByVal T_CDHA As Decimal,
                                  ByVal T_THUOC As Decimal, ByVal T_MAU As Decimal, ByVal T_PTTT As Decimal, ByVal T_VTYT As Decimal,
                                  ByVal T_DVKT_TYLE As Decimal, ByVal T_THUOC_TYLE As Decimal, ByVal T_VTYT_TYLE As Decimal, ByVal T_KHAM As Decimal,
                                  ByVal T_GIUONG As Decimal, ByVal T_VCHUYEN As Decimal, ByVal T_BNTT As Decimal, ByVal T_BHTT As Decimal, ByVal T_NGOAIDS As Decimal) As Integer
        Dim Kq As Integer = 0
        Dim cmd As New SqlCommand

        Dim pSO_VAO_VIEN As SqlParameter = New SqlParameter("@SO_VAO_VIEN", SqlDbType.BigInt)
        pSO_VAO_VIEN.Value = SO_VAO_VIEN
        cmd.Parameters.Add(pSO_VAO_VIEN)

        Dim pT_TONGCHI As SqlParameter = New SqlParameter("@T_TONGCHI", SqlDbType.Decimal)
        pT_TONGCHI.Value = T_TONGCHI
        cmd.Parameters.Add(pT_TONGCHI)

        Dim pT_XN As SqlParameter = New SqlParameter("@T_XN", SqlDbType.Decimal)
        pT_XN.Value = T_XN
        cmd.Parameters.Add(pT_XN)

        Dim pT_CDHA As SqlParameter = New SqlParameter("@T_CDHA", SqlDbType.Decimal)
        pT_CDHA.Value = T_CDHA
        cmd.Parameters.Add(pT_CDHA)

        Dim pT_THUOC As SqlParameter = New SqlParameter("@T_THUOC", SqlDbType.Decimal)
        pT_THUOC.Value = T_THUOC
        cmd.Parameters.Add(pT_THUOC)

        Dim pT_MAU As SqlParameter = New SqlParameter("@T_MAU", SqlDbType.Decimal)
        pT_MAU.Value = T_MAU
        cmd.Parameters.Add(pT_MAU)

        Dim pT_PTTT As SqlParameter = New SqlParameter("@T_PTTT", SqlDbType.Decimal)
        pT_PTTT.Value = T_PTTT
        cmd.Parameters.Add(pT_PTTT)

        Dim pT_VTYT As SqlParameter = New SqlParameter("@T_VTYT", SqlDbType.Decimal)
        pT_VTYT.Value = T_VTYT
        cmd.Parameters.Add(pT_VTYT)

        Dim pT_DVKT_TYLE As SqlParameter = New SqlParameter("@T_DVKT_TYLE", SqlDbType.Decimal)
        pT_DVKT_TYLE.Value = T_DVKT_TYLE
        cmd.Parameters.Add(pT_DVKT_TYLE)

        Dim pT_THUOC_TYLE As SqlParameter = New SqlParameter("@T_THUOC_TYLE", SqlDbType.Decimal)
        pT_THUOC_TYLE.Value = T_THUOC_TYLE
        cmd.Parameters.Add(pT_THUOC_TYLE)

        Dim pTuyenBN As SqlParameter = New SqlParameter("@T_VTYT_TYLE", SqlDbType.Decimal)
        pTuyenBN.Value = T_VTYT_TYLE
        cmd.Parameters.Add(pTuyenBN)

        Dim pT_KHAM As SqlParameter = New SqlParameter("@T_KHAM", SqlDbType.Decimal)
        pT_KHAM.Value = T_KHAM
        cmd.Parameters.Add(pT_KHAM)

        Dim pT_GIUONG As SqlParameter = New SqlParameter("@T_GIUONG", SqlDbType.Decimal)
        pT_GIUONG.Value = T_GIUONG
        cmd.Parameters.Add(pT_GIUONG)

        Dim pT_VCHUYEN As SqlParameter = New SqlParameter("@T_VCHUYEN", SqlDbType.Decimal)
        pT_VCHUYEN.Value = T_VCHUYEN
        cmd.Parameters.Add(pT_VCHUYEN)

        Dim pT_BNTT As SqlParameter = New SqlParameter("@T_BNTT", SqlDbType.Decimal)
        pT_BNTT.Value = T_BNTT
        cmd.Parameters.Add(pT_BNTT)

        Dim pT_BHTT As SqlParameter = New SqlParameter("@T_BHTT", SqlDbType.Decimal)
        pT_BHTT.Value = T_BHTT
        cmd.Parameters.Add(pT_BHTT)

        Dim pT_NGOAIDS As SqlParameter = New SqlParameter("@T_NGOAIDS", SqlDbType.Decimal)
        pT_NGOAIDS.Value = T_NGOAIDS
        cmd.Parameters.Add(pT_NGOAIDS)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Mau79BHYT_Add"
        cmd.Connection = openConnection()
        Try
            cmd.ExecuteNonQuery()
            Kq = 1
        Catch ex As Exception
            Kq = 0
        End Try
        Return Kq
    End Function
#End Region
End Class
