Public Class clssanpham
    Public Function Addnew(ByVal Masp As String, ByVal Manhom As String, ByVal Tensp As String, ByVal DonVT As String, ByVal Mota As String,
                           ByVal BH As String, ByVal Mahanghoa As String, ByVal Loai As Int16, ByVal Makho As String, ByVal ManhomXN As String, ByVal Stt As Int32,
                           ByVal Dongia As Double, ByVal gianhap As Double, ByVal Kieu As Byte, ByVal Url_File As String, ByVal Maphong As String,
                           ByVal SoAnhinPhieu As Integer, ByVal MaBHY As String, ByVal DuongDung As String, ByVal HamLuong As String, ByVal SoDK As String, ByVal DonViSuDung As String, ByVal SLToiThieu As Double) As Boolean

        Dim cmd As New SqlClient.SqlCommand

        Dim paraterMasp As New SqlClient.SqlParameter
        paraterMasp.ParameterName = "@Masp"
        paraterMasp.DbType = DbType.String
        paraterMasp.Direction = ParameterDirection.Input
        paraterMasp.Value = Masp
        cmd.Parameters.Add(paraterMasp)

        Dim paraterManhom As New SqlClient.SqlParameter
        paraterManhom.ParameterName = "@Manhom"
        paraterManhom.DbType = DbType.String
        paraterManhom.Direction = ParameterDirection.Input
        paraterManhom.Value = Manhom
        cmd.Parameters.Add(paraterManhom)

        Dim paraterMahanghoa As New SqlClient.SqlParameter
        paraterMahanghoa.ParameterName = "@Mahanghoa"
        paraterMahanghoa.DbType = DbType.String
        paraterMahanghoa.Direction = ParameterDirection.Input
        paraterMahanghoa.Value = Mahanghoa
        cmd.Parameters.Add(paraterMahanghoa)

        Dim pLoai As New SqlClient.SqlParameter
        pLoai.ParameterName = "@Loai"
        pLoai.DbType = DbType.Int16
        pLoai.Direction = ParameterDirection.Input
        pLoai.Value = Loai
        cmd.Parameters.Add(pLoai)

        Dim paraterTensp As New SqlClient.SqlParameter
        paraterTensp.ParameterName = "@Tensp"
        paraterTensp.DbType = DbType.String
        paraterTensp.Direction = ParameterDirection.Input
        paraterTensp.Value = Tensp
        cmd.Parameters.Add(paraterTensp)

        Dim paraterDonVT As New SqlClient.SqlParameter
        paraterDonVT.ParameterName = "@DonVT"
        paraterDonVT.DbType = DbType.String
        paraterDonVT.Direction = ParameterDirection.Input
        paraterDonVT.Value = DonVT
        cmd.Parameters.Add(paraterDonVT)

        Dim paraterMota As New SqlClient.SqlParameter
        paraterMota.ParameterName = "@Mota"
        paraterMota.DbType = DbType.String
        paraterMota.Direction = ParameterDirection.Input
        paraterMota.Value = Mota
        cmd.Parameters.Add(paraterMota)

        Dim paraterBH As New SqlClient.SqlParameter
        paraterBH.ParameterName = "@BH"
        paraterBH.DbType = DbType.String
        paraterBH.Direction = ParameterDirection.Input
        paraterBH.Value = BH
        cmd.Parameters.Add(paraterBH)

        Dim paraterkho As New SqlClient.SqlParameter
        paraterkho.ParameterName = "@Makho"
        paraterkho.DbType = DbType.String
        paraterkho.Direction = ParameterDirection.Input
        paraterkho.Value = Makho
        cmd.Parameters.Add(paraterkho)

        Dim paraternhomxn As New SqlClient.SqlParameter
        paraternhomxn.ParameterName = "@ManhomXN"
        paraternhomxn.DbType = DbType.String
        paraternhomxn.Direction = ParameterDirection.Input
        paraternhomxn.Value = ManhomXN
        cmd.Parameters.Add(paraternhomxn)

        Dim paraterstt As New SqlClient.SqlParameter
        paraterstt.ParameterName = "@Stt"
        paraterstt.DbType = DbType.Int32
        paraterstt.Direction = ParameterDirection.Input
        paraterstt.Value = Stt
        cmd.Parameters.Add(paraterstt)

        Dim paraterdgia As New SqlClient.SqlParameter
        paraterdgia.ParameterName = "@dongia"
        paraterdgia.DbType = DbType.Double
        paraterdgia.Direction = ParameterDirection.Input
        paraterdgia.Value = Dongia
        cmd.Parameters.Add(paraterdgia)

        Dim paraterdgiaN As New SqlClient.SqlParameter
        paraterdgiaN.ParameterName = "@gianhap"
        paraterdgiaN.DbType = DbType.Double
        paraterdgiaN.Direction = ParameterDirection.Input
        paraterdgiaN.Value = gianhap
        cmd.Parameters.Add(paraterdgiaN)


        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)

        Dim pUrl_File As New SqlClient.SqlParameter
        pUrl_File.ParameterName = "@Url_File"
        pUrl_File.DbType = DbType.String
        pUrl_File.Direction = ParameterDirection.Input
        pUrl_File.Value = Url_File
        cmd.Parameters.Add(pUrl_File)

        Dim pMaphong As New SqlClient.SqlParameter
        pMaphong.ParameterName = "@Maphong"
        pMaphong.DbType = DbType.String
        pMaphong.Direction = ParameterDirection.Input
        pMaphong.Value = Maphong
        cmd.Parameters.Add(pMaphong)

        Dim pSoAnhInPhieu As New SqlClient.SqlParameter
        pSoAnhInPhieu.ParameterName = "@SoAnhInPhieu"
        pSoAnhInPhieu.DbType = DbType.String
        pSoAnhInPhieu.Direction = ParameterDirection.Input
        pSoAnhInPhieu.Value = SoAnhinPhieu
        cmd.Parameters.Add(pSoAnhInPhieu)

        Dim pMaBYT As New SqlClient.SqlParameter
        pMaBYT.ParameterName = "@MaBYT"
        pMaBYT.DbType = DbType.String
        pMaBYT.Direction = ParameterDirection.Input
        pMaBYT.Value = MaBHY
        cmd.Parameters.Add(pMaBYT)

        Dim pDuongDung As New SqlClient.SqlParameter
        pDuongDung.ParameterName = "@DuongDung"
        pDuongDung.DbType = DbType.String
        pDuongDung.Direction = ParameterDirection.Input
        pDuongDung.Value = DuongDung
        cmd.Parameters.Add(pDuongDung)

        Dim pHamLuong As New SqlClient.SqlParameter
        pHamLuong.ParameterName = "@HamLuong"
        pHamLuong.DbType = DbType.String
        pHamLuong.Direction = ParameterDirection.Input
        pHamLuong.Value = HamLuong
        cmd.Parameters.Add(pHamLuong)

        Dim pSoDK As New SqlClient.SqlParameter
        pSoDK.ParameterName = "@SoDK"
        pSoDK.DbType = DbType.String
        pSoDK.Direction = ParameterDirection.Input
        pSoDK.Value = SoDK
        cmd.Parameters.Add(pSoDK)

        Dim pDonViSuDung As New SqlClient.SqlParameter
        pDonViSuDung.ParameterName = "@DonViSuDung"
        pDonViSuDung.DbType = DbType.String
        pDonViSuDung.Direction = ParameterDirection.Input
        pDonViSuDung.Value = DonViSuDung
        cmd.Parameters.Add(pDonViSuDung)

        Dim pSLToiThieu As New SqlClient.SqlParameter
        pSLToiThieu.ParameterName = "@SLToiThieu"
        pSLToiThieu.DbType = DbType.Double
        pSLToiThieu.Direction = ParameterDirection.Input
        pSLToiThieu.Value = SLToiThieu
        cmd.Parameters.Add(pSLToiThieu)

        Dim paratercheck As New SqlClient.SqlParameter
        paratercheck.ParameterName = "@check"
        paratercheck.DbType = DbType.Boolean
        paratercheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paratercheck)

        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_sanpham"
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@check").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function

    Public Function Update(ByVal Masp As String, ByVal Manhom As String, ByVal Tensp As String, ByVal DonVT As String, ByVal Mota As String,
                           ByVal BH As String, ByVal Mahanghoa As String, ByVal Loai As Int16, ByVal Makho As String, ByVal ManhomXN As String,
                           ByVal Stt As Int32, ByVal Dongia As Double, ByVal gianhap As Double, ByVal Kieu As Byte, ByVal ID As Int16,
                           ByVal Url_File As String, ByVal Maphong As String, ByVal SoAnhinPhieu As Integer, ByVal MaBHY As String,
                           ByVal DuongDung As String, ByVal HamLuong As String, ByVal SoDK As String, ByVal DonViSuDung As String, ByVal SLToiThieu As Double) As Boolean

        Dim cmd As New SqlClient.SqlCommand

        Dim paraterMasp As New SqlClient.SqlParameter
        paraterMasp.ParameterName = "@Masp"
        paraterMasp.DbType = DbType.String
        paraterMasp.Direction = ParameterDirection.Input
        paraterMasp.Value = Masp
        cmd.Parameters.Add(paraterMasp)

        Dim paraterManhom As New SqlClient.SqlParameter
        paraterManhom.ParameterName = "@Manhom"
        paraterManhom.DbType = DbType.String
        paraterManhom.Direction = ParameterDirection.Input
        paraterManhom.Value = Manhom
        cmd.Parameters.Add(paraterManhom)

        Dim paraterTensp As New SqlClient.SqlParameter
        paraterTensp.ParameterName = "@Tensp"
        paraterTensp.DbType = DbType.String
        paraterTensp.Direction = ParameterDirection.Input
        paraterTensp.Value = Tensp
        cmd.Parameters.Add(paraterTensp)

        Dim paraterMahanghoa As New SqlClient.SqlParameter
        paraterMahanghoa.ParameterName = "@Mahanghoa"
        paraterMahanghoa.DbType = DbType.String
        paraterMahanghoa.Direction = ParameterDirection.Input
        paraterMahanghoa.Value = Mahanghoa
        cmd.Parameters.Add(paraterMahanghoa)

        Dim pLoai As New SqlClient.SqlParameter
        pLoai.ParameterName = "@Loai"
        pLoai.DbType = DbType.Int16
        pLoai.Direction = ParameterDirection.Input
        pLoai.Value = Loai
        cmd.Parameters.Add(pLoai)

        Dim paraterDonVT As New SqlClient.SqlParameter
        paraterDonVT.ParameterName = "@DonVT"
        paraterDonVT.DbType = DbType.String
        paraterDonVT.Direction = ParameterDirection.Input
        paraterDonVT.Value = DonVT
        cmd.Parameters.Add(paraterDonVT)

        Dim paraterMota As New SqlClient.SqlParameter
        paraterMota.ParameterName = "@Mota"
        paraterMota.DbType = DbType.String
        paraterMota.Direction = ParameterDirection.Input
        paraterMota.Value = Mota
        cmd.Parameters.Add(paraterMota)

        Dim paraterBH As New SqlClient.SqlParameter
        paraterBH.ParameterName = "@BH"
        paraterBH.DbType = DbType.String
        paraterBH.Direction = ParameterDirection.Input
        paraterBH.Value = BH
        cmd.Parameters.Add(paraterBH)

        Dim paraternhomxn As New SqlClient.SqlParameter
        paraternhomxn.ParameterName = "@ManhomXN"
        paraternhomxn.DbType = DbType.String
        paraternhomxn.Direction = ParameterDirection.Input
        paraternhomxn.Value = ManhomXN
        cmd.Parameters.Add(paraternhomxn)

        Dim paraterstt As New SqlClient.SqlParameter
        paraterstt.ParameterName = "@Stt"
        paraterstt.DbType = DbType.Int32
        paraterstt.Direction = ParameterDirection.Input
        paraterstt.Value = Stt
        cmd.Parameters.Add(paraterstt)

        Dim paraterkho As New SqlClient.SqlParameter
        paraterkho.ParameterName = "@Makho"
        paraterkho.DbType = DbType.String
        paraterkho.Direction = ParameterDirection.Input
        paraterkho.Value = Makho
        cmd.Parameters.Add(paraterkho)

        Dim paraterID As New SqlClient.SqlParameter
        paraterID.ParameterName = "@ID"
        paraterID.DbType = DbType.String
        paraterID.Direction = ParameterDirection.Input
        paraterID.Value = ID
        cmd.Parameters.Add(paraterID)

        Dim paraterdgia As New SqlClient.SqlParameter
        paraterdgia.ParameterName = "@dongia"
        paraterdgia.DbType = DbType.Double
        paraterdgia.Direction = ParameterDirection.Input
        paraterdgia.Value = Dongia
        cmd.Parameters.Add(paraterdgia)

        Dim paraterdgiaN As New SqlClient.SqlParameter
        paraterdgiaN.ParameterName = "@gianhap"
        paraterdgiaN.DbType = DbType.Double
        paraterdgiaN.Direction = ParameterDirection.Input
        paraterdgiaN.Value = gianhap
        cmd.Parameters.Add(paraterdgiaN)


        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)

        Dim pUrl_File As New SqlClient.SqlParameter
        pUrl_File.ParameterName = "@Url_File"
        pUrl_File.DbType = DbType.String
        pUrl_File.Direction = ParameterDirection.Input
        pUrl_File.Value = Url_File
        cmd.Parameters.Add(pUrl_File)

        Dim pMaphong As New SqlClient.SqlParameter
        pMaphong.ParameterName = "@Maphong"
        pMaphong.DbType = DbType.String
        pMaphong.Direction = ParameterDirection.Input
        pMaphong.Value = Maphong
        cmd.Parameters.Add(pMaphong)

        Dim pSoAnhInPhieu As New SqlClient.SqlParameter
        pSoAnhInPhieu.ParameterName = "@SoAnhInPhieu"
        pSoAnhInPhieu.DbType = DbType.String
        pSoAnhInPhieu.Direction = ParameterDirection.Input
        pSoAnhInPhieu.Value = SoAnhinPhieu
        cmd.Parameters.Add(pSoAnhInPhieu)

        Dim pMaBYT As New SqlClient.SqlParameter
        pMaBYT.ParameterName = "@MaBYT"
        pMaBYT.DbType = DbType.String
        pMaBYT.Direction = ParameterDirection.Input
        pMaBYT.Value = MaBHY
        cmd.Parameters.Add(pMaBYT)

        Dim pDuongDung As New SqlClient.SqlParameter
        pDuongDung.ParameterName = "@DuongDung"
        pDuongDung.DbType = DbType.String
        pDuongDung.Direction = ParameterDirection.Input
        pDuongDung.Value = DuongDung
        cmd.Parameters.Add(pDuongDung)

        Dim pHamLuong As New SqlClient.SqlParameter
        pHamLuong.ParameterName = "@HamLuong"
        pHamLuong.DbType = DbType.String
        pHamLuong.Direction = ParameterDirection.Input
        pHamLuong.Value = HamLuong
        cmd.Parameters.Add(pHamLuong)

        Dim pSoDK As New SqlClient.SqlParameter
        pSoDK.ParameterName = "@SoDK"
        pSoDK.DbType = DbType.String
        pSoDK.Direction = ParameterDirection.Input
        pSoDK.Value = SoDK
        cmd.Parameters.Add(pSoDK)

        Dim pDonViSuDung As New SqlClient.SqlParameter
        pDonViSuDung.ParameterName = "@DonViSuDung"
        pDonViSuDung.DbType = DbType.String
        pDonViSuDung.Direction = ParameterDirection.Input
        pDonViSuDung.Value = DonViSuDung
        cmd.Parameters.Add(pDonViSuDung)

        Dim pSLToiThieu As New SqlClient.SqlParameter
        pSLToiThieu.ParameterName = "@SLToiThieu"
        pSLToiThieu.DbType = DbType.Double
        pSLToiThieu.Direction = ParameterDirection.Input
        pSLToiThieu.Value = SLToiThieu
        cmd.Parameters.Add(pSLToiThieu)

        Dim paratercheck As New SqlClient.SqlParameter
        paratercheck.ParameterName = "@check"
        paratercheck.DbType = DbType.Boolean
        paratercheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paratercheck)

        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_sanpham"
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@check").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try


    End Function
    Public Function Delete(ByVal Masp As String, ByVal Kieu As Byte) As Boolean

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_sanpham"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMasp As New SqlClient.SqlParameter
        paraterMasp.ParameterName = "@Masp"
        paraterMasp.DbType = DbType.String
        paraterMasp.Direction = ParameterDirection.Input
        paraterMasp.Value = Masp
        cmd.Parameters.Add(paraterMasp)


        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)


        Dim paratercheck As New SqlClient.SqlParameter
        paratercheck.ParameterName = "@check"
        paratercheck.DbType = DbType.Boolean
        paratercheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paratercheck)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function
End Class
