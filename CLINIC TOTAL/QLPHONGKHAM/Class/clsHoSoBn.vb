Imports System.Data.SqlClient

Public Class clsHoSoBn
    Public Function hosobn_add(MaBN As String, HoTenBN As String, DiaChiChiTiet As String, GioiTinh As Integer, DanToc As String, NgaySinh As DateTime,
                               NgheNghiep As String, NoiLamViec As String, DienThoai As String, QuanHe As String, NguoiThan As String,
                               DiaChiLienHe As String, GhiChu As String, DoiTuong As Integer, SoTheBHYT As String, MaThe As Integer, TyLeChiTra As Integer,
                               NoiKhamBanDau As String, TenNoiKhamBanDau As String, TuNgay As DateTime, DenNgay As DateTime, Ma_KhuVuc As String) As String
        Dim kq As String = ""
        Dim cmd As New SqlCommand

        Dim pHotenBN As New SqlParameter("@HoTenBN", SqlDbType.NVarChar, 250)
        pHotenBN.Value = HoTenBN
        cmd.Parameters.Add(pHotenBN)

        Dim pDiaChiChiTiet As New SqlParameter("@DiaChiChiTiet", SqlDbType.NVarChar, 400)
        pDiaChiChiTiet.Value = DiaChiChiTiet
        cmd.Parameters.Add(pDiaChiChiTiet)

        Dim pGioiTinh As New SqlParameter("@GioiTinh", SqlDbType.Int, 4)
        pGioiTinh.Value = GioiTinh
        cmd.Parameters.Add(pGioiTinh)

        Dim pDanToc As New SqlParameter("@DanToc", SqlDbType.NVarChar, 50)
        pDanToc.Value = DanToc
        cmd.Parameters.Add(pDanToc)

        Dim pNgaySinh As New SqlParameter("@NgaySinh", SqlDbType.DateTime, 8)
        pNgaySinh.Value = NgaySinh
        cmd.Parameters.Add(pNgaySinh)

        Dim pNgheNghiep As New SqlParameter("@NgheNghiep", SqlDbType.NVarChar, 50)
        pNgheNghiep.Value = NgheNghiep
        cmd.Parameters.Add(pNgheNghiep)

        Dim pNoiLamViec As New SqlParameter("@NoiLamViec", SqlDbType.NVarChar, 250)
        pNoiLamViec.Value = NoiLamViec
        cmd.Parameters.Add(pNoiLamViec)

        Dim pDienThoai As New SqlParameter("@DienThoai", SqlDbType.NVarChar, 50)
        pDienThoai.Value = DienThoai
        cmd.Parameters.Add(pDienThoai)

        Dim pQuanHe As New SqlParameter("@QuanHe", SqlDbType.NVarChar, 50)
        pQuanHe.Value = QuanHe
        cmd.Parameters.Add(pQuanHe)

        Dim pNguoiThan As New SqlParameter("@NguoiThan", SqlDbType.NVarChar, 150)
        pNguoiThan.Value = NguoiThan
        cmd.Parameters.Add(pNguoiThan)

        Dim pDiaChiLienHe As New SqlParameter("@DiaChiLienHe", SqlDbType.NVarChar, 250)
        pDiaChiLienHe.Value = DiaChiLienHe
        cmd.Parameters.Add(pDiaChiLienHe)

        Dim pGhiChu As New SqlParameter("@GhiChu", SqlDbType.NVarChar, 100)
        pGhiChu.Value = GhiChu
        cmd.Parameters.Add(pGhiChu)

        Dim pDoiTuong As New SqlParameter("@DoiTuong", SqlDbType.Int, 4)
        pDoiTuong.Value = DoiTuong
        cmd.Parameters.Add(pDoiTuong)

        Dim pSoTheBHYT As New SqlParameter("@SoTheBHYT", SqlDbType.NVarChar, 20)
        pSoTheBHYT.Value = SoTheBHYT
        cmd.Parameters.Add(pSoTheBHYT)

        Dim pMaThe As New SqlParameter("@MaThe", SqlDbType.Int, 4)
        pMaThe.Value = MaThe
        cmd.Parameters.Add(pMaThe)

        Dim pTyLeChiTra As New SqlParameter("@TyLeChiTra", SqlDbType.Int, 4)
        pTyLeChiTra.Value = TyLeChiTra
        cmd.Parameters.Add(pTyLeChiTra)

        Dim pNoiKhamBanDau As New SqlParameter("@NoiKhamBanDau", SqlDbType.NVarChar, 50)
        pNoiKhamBanDau.Value = NoiKhamBanDau
        cmd.Parameters.Add(pNoiKhamBanDau)

        Dim pTenNoiKhamBanDau As New SqlParameter("@TenNoiKhamBanDau", SqlDbType.NVarChar, 250)
        pTenNoiKhamBanDau.Value = TenNoiKhamBanDau
        cmd.Parameters.Add(pTenNoiKhamBanDau)

        Dim pTuNgay As New SqlParameter("@TuNgay", SqlDbType.DateTime, 8)
        pTuNgay.Value = TuNgay
        cmd.Parameters.Add(pTuNgay)

        Dim pDenNgay As New SqlParameter("@DenNgay", SqlDbType.DateTime, 8)
        pDenNgay.Value = DenNgay
        cmd.Parameters.Add(pDenNgay)

        Dim pMa_KhuVuc As New SqlParameter("@MA_KHUVUC", SqlDbType.Char, 2)
        pMa_KhuVuc.Value = Ma_KhuVuc
        cmd.Parameters.Add(pMa_KhuVuc)

        Dim pMaBN As New SqlParameter("@MaBN", SqlDbType.NVarChar, 30)
        pMaBN.Direction = ParameterDirection.Output
        cmd.Parameters.Add(pMaBN)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "HoSoBN_Add"
        cmd.Connection = openConnection()

        Try
            cmd.ExecuteNonQuery()
            kq = cmd.Parameters("@MaBN").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            closeConnection()
        End Try

        Return kq
    End Function
End Class
