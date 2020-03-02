Imports System.Data.SqlClient

Public Class clsPhieuKhamBenh

#Region "Them phieu kham benh"
    Public Function PHIEUKHAMBENH_ADD(ByVal SoPhieu As Integer, ByVal NgayLap As DateTime, ByVal NguoiLap As String, ByVal MaBN As String,
    ByVal TienKham As Double, ByVal LoaiSucKhoe As String, ByVal BacSiKham As String, ByVal PhongKham As String,
    ByVal KieuKham As String, ByVal TuyenBN As Integer, ByVal STT As Integer, ByVal GhiChu As String,
    ByVal Doituong As Integer, ByVal Is_CapCuu As Boolean, ByVal NoiChuyenDen As String) As Integer

        Dim Kq As Integer = 0
        Dim cmd As New SqlCommand

        Dim pSoPhieu As SqlParameter = New SqlParameter("@SoPhieu", SqlDbType.BigInt)
        pSoPhieu.Direction = ParameterDirection.Output
        cmd.Parameters.Add(pSoPhieu)

        Dim pNgayLap As SqlParameter = New SqlParameter("@NgayLap", SqlDbType.DateTime, 8)
        pNgayLap.Value = NgayLap
        cmd.Parameters.Add(pNgayLap)

        Dim pNguoiLap As SqlParameter = New SqlParameter("@NguoiLap", SqlDbType.NVarChar, 30)
        pNguoiLap.Value = NguoiLap
        cmd.Parameters.Add(pNguoiLap)

        Dim pMaBN As SqlParameter = New SqlParameter("@MaBN", SqlDbType.NVarChar, 30)
        pMaBN.Value = MaBN
        cmd.Parameters.Add(pMaBN)

        Dim pTienKham As SqlParameter = New SqlParameter("@TienKham", SqlDbType.Float)
        pTienKham.Value = TienKham
        cmd.Parameters.Add(pTienKham)

        Dim pLoaiSucKhoe As SqlParameter = New SqlParameter("@LoaiSucKhoe", SqlDbType.NVarChar, 50)
        pLoaiSucKhoe.Value = LoaiSucKhoe
        cmd.Parameters.Add(pLoaiSucKhoe)

        Dim pBacSiKham As SqlParameter = New SqlParameter("@BacSiKham", SqlDbType.NVarChar, 50)
        pBacSiKham.Value = BacSiKham
        cmd.Parameters.Add(pBacSiKham)

        Dim pPhongKham As SqlParameter = New SqlParameter("@PhongKham", SqlDbType.NVarChar, 50)
        pPhongKham.Value = PhongKham
        cmd.Parameters.Add(pPhongKham)

        Dim pKieuKham As SqlParameter = New SqlParameter("@KieuKham", SqlDbType.NVarChar, 50)
        pKieuKham.Value = KieuKham
        cmd.Parameters.Add(pKieuKham)

        Dim pTuyenBN As SqlParameter = New SqlParameter("@TuyenBN", SqlDbType.Int, 4)
        pTuyenBN.Value = TuyenBN
        cmd.Parameters.Add(pTuyenBN)

        Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
        pSTT.Value = STT
        cmd.Parameters.Add(pSTT)

        Dim pGhiChu As SqlParameter = New SqlParameter("@GhiChu", SqlDbType.NVarChar, 50)
        pGhiChu.Value = GhiChu
        cmd.Parameters.Add(pGhiChu)

        Dim pDoituong As SqlParameter = New SqlParameter("@Doituong", SqlDbType.Int, 4)
        pDoituong.Value = Doituong
        cmd.Parameters.Add(pDoituong)

        Dim pIs_CapCuu As SqlParameter = New SqlParameter("@Is_CapCuu", SqlDbType.Bit, 1)
        pIs_CapCuu.Value = Is_CapCuu
        cmd.Parameters.Add(pIs_CapCuu)

        Dim pNoiChuyenDen As SqlParameter = New SqlParameter("@NoiChuyenDen", SqlDbType.NVarChar, 250)
        pNoiChuyenDen.Value = NoiChuyenDen
        cmd.Parameters.Add(pNoiChuyenDen)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "PHIEUKHAMBENH_ADD"
        cmd.Connection = openConnection()
        Try
            cmd.ExecuteNonQuery()
            Kq = IIf(IsDBNull(cmd.Parameters("@SoPhieu").Value), 0, cmd.Parameters("@SoPhieu").Value)
            Return Kq
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "Lap phieu kham nhanh"
    Public Function LAPPHIEUKHAM_ADD(ByVal SoPhieu As Integer, ByVal NgayLap As DateTime, ByVal NguoiLap As String, ByVal MaBN As String, ByVal TienKham As Double, ByVal LoaiSucKhoe As String, ByVal BacSiKham As String, ByVal PhongKham As String, ByVal KieuKham As String, ByVal GhiChu As String, ByVal Doituong As Integer, ByVal Is_KhamTheoDot As Boolean, ByVal SoDot As Integer, ByVal KhamLamSang As String, ByVal BenhKemTheo As String, ByVal MaBenh As String, ByVal KetLuan As String, ByVal Mach As String, ByVal NhietDo As String, ByVal HuyetAp As String, ByVal NhipTho As String, ByVal Chieucao As String, ByVal Cannang As String, ByVal DiUngThuoc As String, ByVal IsChoKetQua As Boolean) As Integer

        Dim Kq As Integer = 0
        Dim cmd As New SqlCommand

        Dim pSoPhieu As SqlParameter = New SqlParameter("@SoPhieu", SqlDbType.BigInt)
        pSoPhieu.Direction = ParameterDirection.Output
        cmd.Parameters.Add(pSoPhieu)

        Dim pNgayLap As SqlParameter = New SqlParameter("@NgayLap", SqlDbType.DateTime, 8)
        pNgayLap.Value = NgayLap
        cmd.Parameters.Add(pNgayLap)

        Dim pNguoiLap As SqlParameter = New SqlParameter("@NguoiLap", SqlDbType.NVarChar, 30)
        pNguoiLap.Value = NguoiLap
        cmd.Parameters.Add(pNguoiLap)

        Dim pMaBN As SqlParameter = New SqlParameter("@MaBN", SqlDbType.NVarChar, 30)
        pMaBN.Value = MaBN
        cmd.Parameters.Add(pMaBN)

        Dim pTienKham As SqlParameter = New SqlParameter("@TienKham", SqlDbType.Float)
        pTienKham.Value = TienKham
        cmd.Parameters.Add(pTienKham)

        Dim pLoaiSucKhoe As SqlParameter = New SqlParameter("@LoaiSucKhoe", SqlDbType.NVarChar, 50)
        pLoaiSucKhoe.Value = LoaiSucKhoe
        cmd.Parameters.Add(pLoaiSucKhoe)

        Dim pBacSiKham As SqlParameter = New SqlParameter("@BacSiKham", SqlDbType.NVarChar, 50)
        pBacSiKham.Value = BacSiKham
        cmd.Parameters.Add(pBacSiKham)

        Dim pPhongKham As SqlParameter = New SqlParameter("@PhongKham", SqlDbType.NVarChar, 50)
        pPhongKham.Value = PhongKham
        cmd.Parameters.Add(pPhongKham)

        Dim pKieuKham As SqlParameter = New SqlParameter("@KieuKham", SqlDbType.NVarChar, 50)
        pKieuKham.Value = KieuKham
        cmd.Parameters.Add(pKieuKham)

        Dim pGhiChu As SqlParameter = New SqlParameter("@GhiChu", SqlDbType.NVarChar, 500)
        pGhiChu.Value = GhiChu
        cmd.Parameters.Add(pGhiChu)

        Dim pDoituong As SqlParameter = New SqlParameter("@Doituong", SqlDbType.Int, 4)
        pDoituong.Value = Doituong
        cmd.Parameters.Add(pDoituong)

        Dim pIs_KhamTheoDot As SqlParameter = New SqlParameter("@Is_KhamTheoDot", SqlDbType.Bit, 1)
        pIs_KhamTheoDot.Value = Is_KhamTheoDot
        cmd.Parameters.Add(pIs_KhamTheoDot)

        Dim pSoDot As SqlParameter = New SqlParameter("@SoDot", SqlDbType.Int, 4)
        pDoituong.Value = SoDot
        cmd.Parameters.Add(pSoDot)

        Dim pKhamLamSang As SqlParameter = New SqlParameter("@KhamLamSang", SqlDbType.NVarChar, 500)
        pKhamLamSang.Value = KhamLamSang
        cmd.Parameters.Add(pKhamLamSang)

        Dim pBenhKemTheo As SqlParameter = New SqlParameter("@BenhKemTheo", SqlDbType.NVarChar, 250)
        pBenhKemTheo.Value = BenhKemTheo
        cmd.Parameters.Add(pBenhKemTheo)

        Dim pMaBenh As SqlParameter = New SqlParameter("@MaBenh", SqlDbType.NVarChar, 50)
        pMaBenh.Value = MaBenh
        cmd.Parameters.Add(pMaBenh)

        Dim pKetLuan As SqlParameter = New SqlParameter("@KetLuan", SqlDbType.NVarChar, 500)
        pKetLuan.Value = KetLuan
        cmd.Parameters.Add(pKetLuan)

        Dim pMach As SqlParameter = New SqlParameter("@Mach", SqlDbType.NVarChar, 50)
        pMach.Value = Mach
        cmd.Parameters.Add(pMach)

        Dim pNhietDo As SqlParameter = New SqlParameter("@NhietDo", SqlDbType.NVarChar, 50)
        pNhietDo.Value = NhietDo
        cmd.Parameters.Add(pNhietDo)

        Dim pHuyetAp As SqlParameter = New SqlParameter("@HuyetAp", SqlDbType.NVarChar, 50)
        pHuyetAp.Value = HuyetAp
        cmd.Parameters.Add(pHuyetAp)

        Dim pNhipTho As SqlParameter = New SqlParameter("@NhipTho", SqlDbType.NVarChar, 50)
        pNhipTho.Value = NhipTho
        cmd.Parameters.Add(pNhipTho)

        Dim pChieucao As SqlParameter = New SqlParameter("@Chieucao", SqlDbType.NVarChar, 50)
        pChieucao.Value = Chieucao
        cmd.Parameters.Add(pChieucao)

        Dim pCannang As SqlParameter = New SqlParameter("@Cannang", SqlDbType.NVarChar, 50)
        pCannang.Value = Cannang
        cmd.Parameters.Add(pCannang)

        Dim pDiUngThuoc As SqlParameter = New SqlParameter("@DiUngThuoc", SqlDbType.NVarChar, 200)
        pDiUngThuoc.Value = DiUngThuoc
        cmd.Parameters.Add(pDiUngThuoc)

        Dim pIsChoKetQua As SqlParameter = New SqlParameter("@IsChoKetQua", SqlDbType.Bit, 1)
        pIsChoKetQua.Value = IsChoKetQua
        cmd.Parameters.Add(pIsChoKetQua)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "LapPhieuKham_Add"
        cmd.Connection = openConnection()
        Try
            cmd.ExecuteNonQuery()
            Kq = IIf(IsDBNull(cmd.Parameters("@SoPhieu").Value), 0, cmd.Parameters("@SoPhieu").Value)
            Return Kq
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region
End Class
