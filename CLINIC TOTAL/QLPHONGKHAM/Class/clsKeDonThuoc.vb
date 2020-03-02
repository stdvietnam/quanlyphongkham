Imports System.Data.SqlClient

Public Class clsKeDonThuoc
#Region "add kedonthuoc"
    Public Function kedonthuoc_add(ByVal Mabn As String, ByVal Sophieukham As String, ByVal Sophieu As Integer, ByVal Bacsykedon As String,
                                   ByVal Ghichu As String, ByVal Ngay As String, ByVal Nguoinhap As String, ByVal Makho As String, ByVal chandoanls As String,
                                   ByVal SOTIEN As Double, ByVal PhongKham As String, ByVal SoNgay As Integer) As Integer
        Dim Kq As Integer = 0
        Dim cmd As New SqlCommand

        Dim pSoPhieu As SqlParameter = New SqlParameter("@Sophieu", SqlDbType.BigInt)
        pSoPhieu.Direction = ParameterDirection.Output
        cmd.Parameters.Add(pSoPhieu)

        Dim pMabn As SqlParameter = New SqlParameter("@Mabn", SqlDbType.NVarChar, 30)
        pMabn.Value = Mabn
        cmd.Parameters.Add(pMabn)

        Dim pSophieukham As SqlParameter = New SqlParameter("@Sophieukham", SqlDbType.NVarChar, 30)
        pSophieukham.Value = Sophieukham
        cmd.Parameters.Add(pSophieukham)

        Dim pBacsykedon As SqlParameter = New SqlParameter("@Bacsykedon", SqlDbType.NVarChar, 30)
        pBacsykedon.Value = Bacsykedon
        cmd.Parameters.Add(pBacsykedon)

        Dim pGhichu As SqlParameter = New SqlParameter("@Ghichu", SqlDbType.NVarChar, 200)
        pGhichu.Value = Ghichu
        cmd.Parameters.Add(pGhichu)

        Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.DateTime, 8)
        pNgay.Value = Ngay
        cmd.Parameters.Add(pNgay)

        Dim pNguoinhap As SqlParameter = New SqlParameter("@Nguoinhap", SqlDbType.NVarChar, 20)
        pNguoinhap.Value = Nguoinhap
        cmd.Parameters.Add(pNguoinhap)

        Dim pMakho As SqlParameter = New SqlParameter("@Makho", SqlDbType.NVarChar, 30)
        pMakho.Value = Makho
        cmd.Parameters.Add(pMakho)

        Dim pchandoanls As SqlParameter = New SqlParameter("@chandoanls", SqlDbType.NVarChar, 200)
        pchandoanls.Value = chandoanls
        cmd.Parameters.Add(pchandoanls)

        Dim pSOTIEN As SqlParameter = New SqlParameter("@SOTIEN", SqlDbType.Float)
        pSOTIEN.Value = SOTIEN
        cmd.Parameters.Add(pSOTIEN)

        Dim pPhongKham As SqlParameter = New SqlParameter("@PhongKham", SqlDbType.NVarChar, 50)
        pPhongKham.Value = PhongKham
        cmd.Parameters.Add(pPhongKham)

        Dim pSoNgay As SqlParameter = New SqlParameter("@SoNgay", SqlDbType.Int, 4)
        pSoNgay.Value = SoNgay
        cmd.Parameters.Add(pSoNgay)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "kedonthuoc_add"
        cmd.Connection = openConnection()
        Try
            cmd.ExecuteNonQuery()
            Kq = IIf(IsDBNull(cmd.Parameters("@Sophieu").Value), 0, cmd.Parameters("@Sophieu").Value)
            Return Kq
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region
End Class
