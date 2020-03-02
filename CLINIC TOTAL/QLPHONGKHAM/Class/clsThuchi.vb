Imports System.data.SqlClient
Public Class clsThuchi
    Private dts As DataSet
    Public Function ThemPhieuTC(ByVal total As Double, ByVal thucthu As Double, ByVal strSophieu As String, ByVal blnLoaiphieu As Boolean, ByVal blnTiengui As Boolean, ByVal strMaTC As String, ByVal DtNgay As Date, ByVal strMaquy As String, ByVal strMakh As String, ByVal strMadv As String, ByVal fSotienUSD As Double, ByVal ftygia As Double, ByVal fQuydoi As Double, ByVal fSotienVND As Double, ByVal strGhichu As String, ByVal int_kieu As Integer, ByVal int_ID As Int16, ByVal strUsername As String, ByVal Nvtc As String, ByVal spk As Integer, ByVal int_IDSophieu As Int64, ByRef int_SophieuMoi As Int64, ByRef IndexIDSophieu As Int64, ByVal Cn As SqlConnection) As Boolean
        Dim cmd As New SqlCommand
        Dim paraSophieu As New SqlParameter
        Dim paraMaquy As New SqlParameter
        Dim paraSophieuOut As New SqlParameter
        Dim paraIdSophieu As New SqlParameter
        cmd.Connection = openConnection()

        Dim paraID As New SqlParameter
        paraID.SqlDbType = SqlDbType.BigInt
        paraID.ParameterName = "@ID"
        paraID.Direction = ParameterDirection.Input
        paraID.Value = int_ID
        cmd.Parameters.Add(paraID)

        paraSophieu.SqlDbType = SqlDbType.NVarChar
        paraSophieu.ParameterName = "@Sophieu"
        paraSophieu.Direction = ParameterDirection.Input
        paraSophieu.Value = strSophieu
        cmd.Parameters.Add(paraSophieu)

        paraSophieuOut.SqlDbType = SqlDbType.BigInt
        paraSophieuOut.ParameterName = "@SophieuOut"
        paraSophieuOut.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraSophieuOut)

        paraIdSophieu.SqlDbType = SqlDbType.BigInt
        paraIdSophieu.ParameterName = "@IdSophieuOut"
        paraIdSophieu.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraIdSophieu)

        Dim paraSophieuID As New SqlParameter
        paraSophieuID.SqlDbType = SqlDbType.BigInt
        paraSophieuID.ParameterName = "@IdSophieu"
        paraSophieuID.Direction = ParameterDirection.Input
        paraSophieuID.Value = int_IDSophieu
        cmd.Parameters.Add(paraSophieuID)

        paraMaquy.SqlDbType = SqlDbType.NVarChar
        paraMaquy.ParameterName = "@Maquy"
        paraMaquy.Direction = ParameterDirection.Input
        paraMaquy.Value = strMaquy
        cmd.Parameters.Add(paraMaquy)

        Dim paraMaTC As New SqlParameter
        paraMaTC.SqlDbType = SqlDbType.NVarChar
        paraMaTC.ParameterName = "@MaTC"
        paraMaTC.Direction = ParameterDirection.Input
        paraMaTC.Value = strMaTC
        cmd.Parameters.Add(paraMaTC)

        Dim paraUser As New SqlParameter
        paraUser.SqlDbType = SqlDbType.NVarChar
        paraUser.ParameterName = "@Nguoinhap"
        paraUser.Direction = ParameterDirection.Input
        paraUser.Value = strUsername
        cmd.Parameters.Add(paraUser)

        Dim paraNvtc As New SqlParameter
        paraNvtc.SqlDbType = SqlDbType.NVarChar
        paraNvtc.ParameterName = "@Nvtc"
        paraNvtc.Direction = ParameterDirection.Input
        paraNvtc.Value = Nvtc
        cmd.Parameters.Add(paraNvtc)

        Dim paraspk As New SqlParameter
        paraspk.SqlDbType = SqlDbType.BigInt
        paraspk.ParameterName = "@spk"
        paraspk.Direction = ParameterDirection.Input
        paraspk.Value = spk
        cmd.Parameters.Add(paraspk)

        Dim paraLoaiphieu As New SqlParameter
        paraLoaiphieu.SqlDbType = SqlDbType.Bit
        paraLoaiphieu.ParameterName = "@Loaiphieu"
        paraLoaiphieu.Direction = ParameterDirection.Input
        paraLoaiphieu.Value = IIf(blnLoaiphieu = True, 1, 0)
        cmd.Parameters.Add(paraLoaiphieu)

        Dim paraTiengui As New SqlParameter
        paraTiengui.SqlDbType = SqlDbType.Bit
        paraTiengui.ParameterName = "@Tiengui"
        paraTiengui.Direction = ParameterDirection.Input
        paraTiengui.Value = IIf(blnTiengui = True, 1, 0)
        cmd.Parameters.Add(paraTiengui)

        Dim paraNgay As New SqlParameter
        paraNgay.SqlDbType = SqlDbType.NVarChar
        paraNgay.ParameterName = "@Ngay"
        paraNgay.Direction = ParameterDirection.Input
        paraNgay.Value = Format(DtNgay, "MM/dd/yyyy")
        cmd.Parameters.Add(paraNgay)

        Dim paraMaKh As New SqlParameter
        paraMaKh.ParameterName = "@MaKh"
        paraMaKh.SqlDbType = SqlDbType.NVarChar
        paraMaKh.Direction = ParameterDirection.Input
        paraMaKh.Value = strMakh
        cmd.Parameters.Add(paraMaKh)

        Dim paraGhichu As New SqlParameter
        paraGhichu.ParameterName = "@ghichu"
        paraGhichu.SqlDbType = SqlDbType.NVarChar
        paraGhichu.Direction = ParameterDirection.Input
        paraGhichu.Value = strGhichu
        cmd.Parameters.Add(paraGhichu)

        Dim paraMadv As New SqlParameter
        paraMadv.ParameterName = "@Madv"
        paraMadv.SqlDbType = SqlDbType.NVarChar
        paraMadv.Direction = ParameterDirection.Input
        paraMadv.Value = strMadv
        cmd.Parameters.Add(paraMadv)

        Dim paraSotienUSD As New SqlParameter
        paraSotienUSD.ParameterName = "@SotienUSD"
        paraSotienUSD.SqlDbType = SqlDbType.Float
        paraSotienUSD.Value = fSotienUSD
        paraSotienUSD.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraSotienUSD)

        Dim paratotal As New SqlParameter
        paratotal.ParameterName = "@total"
        paratotal.SqlDbType = SqlDbType.Float
        paratotal.Value = total
        paratotal.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paratotal)

        Dim paraThucthu As New SqlParameter
        paraThucthu.ParameterName = "@thucthu"
        paraThucthu.SqlDbType = SqlDbType.Float
        paraThucthu.Value = thucthu
        paraThucthu.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraThucthu)


        Dim paraTygia As New SqlParameter
        paraTygia.ParameterName = "@Tygia"
        paraTygia.SqlDbType = SqlDbType.Float
        paraTygia.Value = ftygia
        paraTygia.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraTygia)

        Dim paraSotienVND As New SqlParameter
        paraSotienVND.ParameterName = "@SotienVND"
        paraSotienVND.SqlDbType = SqlDbType.Float
        paraSotienVND.Value = fSotienVND
        paraSotienVND.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraSotienVND)

        Dim paraQuydoi As New SqlParameter
        paraQuydoi.ParameterName = "@Quydoi"
        paraQuydoi.SqlDbType = SqlDbType.Float
        paraQuydoi.Value = fQuydoi
        paraQuydoi.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraQuydoi)

        Dim paraTrung As New SqlParameter
        paraTrung.SqlDbType = SqlDbType.Int
        paraTrung.ParameterName = "@Trung"
        paraTrung.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraTrung)

        Dim paraKieu As New SqlParameter
        paraKieu.ParameterName = "@Kieu"
        paraKieu.SqlDbType = SqlDbType.Int
        paraKieu.Direction = ParameterDirection.Input
        paraKieu.Value = int_kieu
        cmd.Parameters.Add(paraKieu)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_ThemPhieuTC"
        Try
            cmd.ExecuteNonQuery()
            int_IDSophieu = IIf(IsDBNull(cmd.Parameters("@IDSophieuOut").Value), 0, cmd.Parameters("@IDSophieuOut").Value)
            IndexIDSophieu = int_IDSophieu
            If cmd.Parameters("@Trung").Value = 1 Then
                int_SophieuMoi = cmd.Parameters("@SophieuOut").Value
                Return True
            Else
                int_SophieuMoi = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
    Public Function Lay_So_phieu(ByVal LoaiPhieu As Boolean) As Int32
        Dim dtbPhieuTC As New DataTable
        dts = BusinessLogic.Data.GetDataset("SELECT Max(Sophieu)as Sophieu FROM Phieu_Thu_Chi WHERE LoaiPhieu=" & IIf(LoaiPhieu = True, 1, 0) & "AND Tiengui =0", CommandType.Text, Nothing, Nothing)
        dtbPhieuTC = dts.Tables(0)
        If dtbPhieuTC.Rows.Count > 0 And Not IsDBNull(dtbPhieuTC.Rows(0)("Sophieu")) Then
            Return dtbPhieuTC.Rows(0)("Sophieu") + 1
        Else
            Return 1000
        End If
    End Function
    Public Function Lay_So_phieu1(ByVal LoaiPhieu As Boolean) As Int32
        Dim dtbPhieuTC As New DataTable
        dts = BusinessLogic.Data.GetDataset("SELECT Max(Sophieu)as Sophieu FROM Phieu_Thu_Chi WHERE LoaiPhieu=" & IIf(LoaiPhieu = True, 1, 0) & "AND Tiengui =1", CommandType.Text, Nothing, Nothing)
        dtbPhieuTC = dts.Tables(0)
        If dtbPhieuTC.Rows.Count > 0 And Not IsDBNull(dtbPhieuTC.Rows(0)("Sophieu")) Then
            Return dtbPhieuTC.Rows(0)("Sophieu") + 1
        Else
            Return 1000
        End If
    End Function
    Public Function TinhTonQuy(ByVal Cn As SqlConnection)
        Dim cmdTonquy As New SqlCommand
        cmdTonquy.CommandType = CommandType.StoredProcedure
        cmdTonquy.CommandText = "Pro_TinhTonquy"
        cmdTonquy.Connection = openConnection()
        Try
            cmdTonquy.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
    Public Function TinhlaicongnoTC(ByVal int_IDSophieu As Int32) As Int32
        Dim cmdGiathanh As New SqlCommand
        Dim paraSophieu As New SqlParameter

        cmdGiathanh.CommandText = "TinhlaicongnoTC1"
        cmdGiathanh.CommandType = CommandType.StoredProcedure

        paraSophieu.SqlDbType = SqlDbType.Int
        paraSophieu.ParameterName = "@int_IDSophieu"
        paraSophieu.Direction = ParameterDirection.Input
        paraSophieu.Value = int_IDSophieu

        cmdGiathanh.Parameters.Add(paraSophieu)
        cmdGiathanh.Connection = CNNQLPHONGKHAM
        Try
            cmdGiathanh.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Xoa_Phieu(ByVal Idsophieu As String, ByVal Loaiphieu As Boolean, ByVal DtNgay As Date, ByVal strMaquy As String, ByVal Cn As SqlConnection)
        Dim cmd As New SqlCommand
        Dim paraSophieu As New SqlParameter
        Dim paraMaquy As New SqlParameter
        Dim paraSophieuOut As New SqlParameter
        Dim paraIdSophieu As New SqlParameter
        cmd.Connection = openConnection()
        paraSophieuOut.SqlDbType = SqlDbType.Int
        paraSophieuOut.ParameterName = "@SophieuOut"
        paraSophieuOut.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraSophieuOut)

        paraIdSophieu.SqlDbType = SqlDbType.Int
        paraIdSophieu.ParameterName = "@IdSophieuOut"
        paraIdSophieu.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraIdSophieu)

        Dim paraSophieuID As New SqlParameter
        paraSophieuID.SqlDbType = SqlDbType.Int
        paraSophieuID.ParameterName = "@IdSophieu"
        paraSophieuID.Direction = ParameterDirection.Input
        paraSophieuID.Value = Idsophieu
        cmd.Parameters.Add(paraSophieuID)

        Dim paraLoaiphieu As New SqlParameter
        paraLoaiphieu.ParameterName = "@Loaiphieu"
        paraLoaiphieu.SqlDbType = SqlDbType.Bit
        paraLoaiphieu.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraLoaiphieu)

        Dim paraNgay As New SqlParameter
        paraNgay.SqlDbType = SqlDbType.NVarChar
        paraNgay.ParameterName = "@Ngay"
        paraNgay.Direction = ParameterDirection.Input
        paraNgay.Value = Format(DtNgay, "MM/dd/yyyy")
        cmd.Parameters.Add(paraNgay)

        paraMaquy.SqlDbType = SqlDbType.NVarChar
        paraMaquy.ParameterName = "@Maquy"
        paraMaquy.Direction = ParameterDirection.Input
        paraMaquy.Value = strMaquy
        cmd.Parameters.Add(paraMaquy)

        Dim paraTrung As New SqlParameter
        paraTrung.ParameterName = "@Trung"
        paraTrung.SqlDbType = SqlDbType.Bit
        paraTrung.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraTrung)

        Dim paraKieu As New SqlParameter
        paraKieu.ParameterName = "@Kieu"
        paraKieu.SqlDbType = SqlDbType.Int
        paraKieu.Direction = ParameterDirection.Input
        paraKieu.Value = 2
        cmd.Parameters.Add(paraKieu)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Pro_ThemPhieuTC"
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
End Class
