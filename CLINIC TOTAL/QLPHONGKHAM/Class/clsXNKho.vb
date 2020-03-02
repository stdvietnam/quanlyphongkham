Imports System.Data.SqlClient
Public Class clsXNKho
    Public Function ThemPhieu(ByVal strSophieu As String, ByVal blnLoaiphieu As Boolean, ByVal strMakh As String, ByVal strMadv As String, ByVal fSotienUSD As Double, ByVal ftygia As Double, ByVal fVAT As Double, ByVal int_kieu As Integer, ByVal int_ID As Int16, ByVal DtNgay As Date, ByVal strMaloaixn As String, ByVal strMakho As String, ByVal strGhichu As String, ByVal Nguoinhap As String, ByVal GhichuBH As String, ByVal BHCT As Boolean, ByVal BHKH As Boolean, ByVal ngaytt As Int16, ByVal fQuydoi As Double, ByVal SOPHIEUKHAM As Int64, ByRef int_IDSophieu As Int32, ByRef int_SophieuMoi As Int32, ByRef IndexIDSophieu As Int32, ByVal Cn As SqlConnection) As Boolean
        Dim cmd As New SqlCommand
        Dim paraSophieu As New SqlParameter
        Dim paraSophieuOut As New SqlParameter
        Dim paraIdSophieu As New SqlParameter
        cmd.Connection = openConnection()

        Dim paraID As New SqlParameter
        paraID.SqlDbType = SqlDbType.Int
        paraID.ParameterName = "@ID"
        paraID.Direction = ParameterDirection.Input
        paraID.Value = int_ID
        cmd.Parameters.Add(paraID)

        paraSophieu.SqlDbType = SqlDbType.Int
        paraSophieu.ParameterName = "@Sophieu"
        paraSophieu.Direction = ParameterDirection.Input
        paraSophieu.Value = strSophieu
        cmd.Parameters.Add(paraSophieu)

        paraSophieuOut.SqlDbType = SqlDbType.Int
        paraSophieuOut.ParameterName = "@SophieuOut"
        paraSophieuOut.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraSophieuOut)

        paraIdSophieu.SqlDbType = SqlDbType.Int
        paraIdSophieu.ParameterName = "@IdSophieu"
        paraIdSophieu.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraIdSophieu)

        Dim paraNguoinhap As New SqlParameter
        paraNguoinhap.SqlDbType = SqlDbType.NVarChar
        paraNguoinhap.ParameterName = "@Nguoinhap"
        paraNguoinhap.Direction = ParameterDirection.Input
        paraNguoinhap.Value = Nguoinhap
        cmd.Parameters.Add(paraNguoinhap)

        Dim paraLoaiphieu As New SqlParameter
        paraLoaiphieu.SqlDbType = SqlDbType.Bit
        paraLoaiphieu.ParameterName = "@Loaiphieu"
        paraLoaiphieu.Direction = ParameterDirection.Input
        paraLoaiphieu.Value = IIf(blnLoaiphieu = True, 1, 0)
        cmd.Parameters.Add(paraLoaiphieu)

        Dim paraNgay As New SqlParameter
        paraNgay.SqlDbType = SqlDbType.NVarChar
        paraNgay.ParameterName = "@Ngay"
        paraNgay.Direction = ParameterDirection.Input
        paraNgay.Value = Format(DtNgay, "MM/dd/yyyy")
        cmd.Parameters.Add(paraNgay)

        Dim paraMakho As New SqlParameter
        paraMakho.ParameterName = "@Makho"
        paraMakho.SqlDbType = SqlDbType.NVarChar
        paraMakho.Direction = ParameterDirection.Input
        paraMakho.Value = strMakho
        cmd.Parameters.Add(paraMakho)

        Dim paraLoaiXn As New SqlParameter
        paraLoaiXn.ParameterName = "@MaloaiXn"
        paraLoaiXn.SqlDbType = SqlDbType.NVarChar
        paraLoaiXn.Direction = ParameterDirection.Input
        paraLoaiXn.Value = strMaloaixn
        cmd.Parameters.Add(paraLoaiXn)

        Dim paraGhichu As New SqlParameter
        paraGhichu.ParameterName = "@ghichu"
        paraGhichu.SqlDbType = SqlDbType.NVarChar
        paraGhichu.Direction = ParameterDirection.Input
        paraGhichu.Value = strGhichu
        cmd.Parameters.Add(paraGhichu)

        Dim paraMakh As New SqlParameter
        paraMakh.ParameterName = "@makh"
        paraMakh.SqlDbType = SqlDbType.NVarChar
        paraMakh.Direction = ParameterDirection.Input
        paraMakh.Value = strMakh
        cmd.Parameters.Add(paraMakh)

        Dim paraMadv As New SqlParameter
        paraMadv.ParameterName = "@Madv"
        paraMadv.SqlDbType = SqlDbType.NVarChar
        paraMadv.Direction = ParameterDirection.Input
        paraMadv.Value = strMadv
        cmd.Parameters.Add(paraMadv)

        Dim paraSotien As New SqlParameter
        paraSotien.ParameterName = "@SoTienUSD"
        paraSotien.SqlDbType = SqlDbType.Float
        paraSotien.Value = fSotienUSD
        paraSotien.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraSotien)

        Dim paraQuydoi As New SqlParameter
        paraQuydoi.ParameterName = "@Quydoi"
        paraQuydoi.SqlDbType = SqlDbType.Float
        paraQuydoi.Value = fQuydoi
        paraQuydoi.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraQuydoi)

        Dim paraGhichuBH As New SqlParameter
        paraGhichuBH.ParameterName = "@ghichuBH"
        paraGhichuBH.SqlDbType = SqlDbType.NVarChar
        paraGhichuBH.Direction = ParameterDirection.Input
        paraGhichuBH.Value = GhichuBH
        cmd.Parameters.Add(paraGhichuBH)

        Dim paraBHCT As New SqlParameter
        paraBHCT.SqlDbType = SqlDbType.Bit
        paraBHCT.ParameterName = "@BHCT"
        paraBHCT.Direction = ParameterDirection.Input
        paraBHCT.Value = BHCT
        cmd.Parameters.Add(paraBHCT)

        Dim paraBHKH As New SqlParameter
        paraBHKH.SqlDbType = SqlDbType.Bit
        paraBHKH.ParameterName = "@BHKH"
        paraBHKH.Direction = ParameterDirection.Input
        paraBHKH.Value = BHKH
        cmd.Parameters.Add(paraBHKH)

        Dim parangayTT As New SqlParameter
        parangayTT.ParameterName = "@ngaytt"
        parangayTT.SqlDbType = SqlDbType.Int
        parangayTT.Value = ngaytt
        parangayTT.Direction = ParameterDirection.Input
        cmd.Parameters.Add(parangayTT)

        Dim paraVAT As New SqlParameter
        paraVAT.ParameterName = "@VAT"
        paraVAT.SqlDbType = SqlDbType.Float
        paraVAT.Value = fVAT
        paraVAT.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraVAT)

        Dim paraTygia As New SqlParameter
        paraTygia.ParameterName = "@Tygia"
        paraTygia.SqlDbType = SqlDbType.Float
        paraTygia.Value = ftygia
        paraTygia.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paraTygia)

        Dim parasophieukham As New SqlParameter
        parasophieukham.SqlDbType = SqlDbType.Int
        parasophieukham.ParameterName = "@Sophieukham"
        parasophieukham.Direction = ParameterDirection.Input
        parasophieukham.Value = SOPHIEUKHAM
        cmd.Parameters.Add(parasophieukham)

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
        cmd.CommandText = "Pro_ThemPXN"
        Try
            cmd.ExecuteNonQuery()
            int_IDSophieu = IIf(IsDBNull(cmd.Parameters("@IDSophieu").Value), 0, cmd.Parameters("@IDSophieu").Value)
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
    Public Function CapnhatCTPhieu(ByVal dtb As DataTable, ByVal Cnn As SqlConnection) As String
        Dim strDelete, strInsert, strUpdate, strSelect As String
        Dim paraDel As New SqlParameter
        Dim paraUpdate As New SqlParameter
        Dim cnnAcct As New SqlConnection
        Dim SQLadp As New SqlDataAdapter(strSelect, Cnn)
        strDelete = "DELETE FROM Chi_Tiet_PXN WHERE ID=@ID"
        strInsert = "INSERT INTO Chi_Tiet_PXN(IDSophieu,Masp,Soluong,Dongia,Khuyenmai,VAT,Thanhtien) VALUES (@IDSophieu,@Masp,@Soluong,@Dongia,@Khuyenmai,@VAT,@Thanhtien)"
        strUpdate = "UPDATE Chi_Tiet_PXN SET IDSophieu = @IDSophieu,Masp=@Masp,Soluong=@Soluong,Dongia=@Dongia,Khuyenmai=@Khuyenmai,VAT=@VAT,Thanhtien=@Thanhtien WHERE ID =@ID"
        strSelect = "SELECT ID,Sophieu,Masp,Soluong,khuyenmai,tylehh FROM Chi_Tiet_PXN"
        Dim cmdDel As New SqlCommand(strDelete, Cnn)
        Dim cmdInsert As New SqlCommand(strInsert, Cnn)
        Dim cmdUpdate As New SqlCommand(strUpdate, Cnn)
        Dim cmdSelect As New SqlCommand(strSelect, Cnn)

        paraDel.ParameterName = "@ID"
        paraDel.DbType = DbType.Int32
        paraDel.Direction = ParameterDirection.Input
        paraDel.SourceColumn = "ID"
        paraDel.SourceVersion = DataRowVersion.Original
        cmdDel.Parameters.Add(paraDel)

        cmdUpdate.Parameters.Add("@IDSophieu", SqlDbType.BigInt, 50, "IDSophieu")
        cmdUpdate.Parameters.Add("@Masp", SqlDbType.VarChar, 50, "Masp")
        cmdUpdate.Parameters.Add("@Soluong", SqlDbType.Float, 8, "Soluong")
        cmdUpdate.Parameters.Add("@Dongia", SqlDbType.Float, 8, "Dongia")
        cmdUpdate.Parameters.Add("@Khuyenmai", SqlDbType.Bit, 1, "Khuyenmai")
        cmdUpdate.Parameters.Add("@VAT", SqlDbType.Float, 8, "VAT")
        cmdUpdate.Parameters.Add("@Thanhtien", SqlDbType.Float, 8, "Thanhtien")
        paraUpdate.ParameterName = "@ID"
        paraUpdate.DbType = DbType.Int32
        paraUpdate.Direction = ParameterDirection.Input
        paraUpdate.SourceColumn = "ID"
        paraUpdate.SourceVersion = DataRowVersion.Original
        cmdUpdate.Parameters.Add(paraUpdate)

        cmdInsert.Parameters.Add("@IDSophieu", SqlDbType.BigInt, 50, "IDSophieu")
        cmdInsert.Parameters.Add("@Masp", SqlDbType.VarChar, 50, "Masp")
        cmdInsert.Parameters.Add("@Soluong", SqlDbType.Float, 8, "Soluong")
        cmdInsert.Parameters.Add("@Dongia", SqlDbType.Float, 8, "Dongia")
        cmdInsert.Parameters.Add("@Thanhtien", SqlDbType.Float, 8, "Thanhtien")
        cmdInsert.Parameters.Add("@Khuyenmai", SqlDbType.Bit, 1, "Khuyenmai")
        cmdInsert.Parameters.Add("@VAT", SqlDbType.Float, 8, "VAT")

        SQLadp.SelectCommand = cmdSelect
        SQLadp.DeleteCommand = cmdDel
        SQLadp.UpdateCommand = cmdUpdate
        SQLadp.InsertCommand = cmdInsert
        Try
            SQLadp.Update(dtb)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Tinhlai(ByVal int_Sophieu As Int64, ByVal tygia As Double, ByVal Cn As SqlConnection)
        Dim cmdLai As New SqlCommand
        Dim paraSophieu As New SqlParameter
        cmdLai.CommandText = "Tinhlai"

        cmdLai.CommandType = CommandType.StoredProcedure
        paraSophieu.SqlDbType = SqlDbType.Int
        paraSophieu.ParameterName = "@Sophieu"
        paraSophieu.Direction = ParameterDirection.Input
        paraSophieu.Value = int_Sophieu

        Dim paraTygia As New SqlParameter
        paraTygia.ParameterName = "@Tygia"
        paraTygia.SqlDbType = SqlDbType.Float
        paraTygia.Value = tygia
        paraTygia.Direction = ParameterDirection.Input

        cmdLai.Connection = Cn
        cmdLai.Parameters.Add(paraTygia)
        cmdLai.Parameters.Add(paraSophieu)
        cmdLai.ExecuteNonQuery()
    End Function
    Public Function TinhTonkho(ByVal Cn As SqlConnection)
        Dim cmdTonkho As New SqlCommand
        cmdTonkho.CommandText = "TinhTonkho"
        cmdTonkho.Connection = Cn
        cmdTonkho.ExecuteNonQuery()
    End Function
    Public Function TinhTonkhoTT(ByVal dtbSP As DataTable, ByVal Cn As SqlConnection, ByVal Loaiphieu As Boolean, ByVal Ngay As Date)
        Dim i As Integer
        Dim strSQL As String
        For i = 0 To dtbSP.Rows.Count - 1
            If Loaiphieu = False Then
                If dtbSP.Rows(i)("Khuyenmai") <> True Then
                    strSQL = "Update Tonkho Set Nhaptk=Nhaptk + " & dtbSP.Rows(i)("Soluong") & ",Toncuoi=(Tondau+Nhaptk-Xuattk+" & dtbSP.Rows(i)("Soluong") & ") WHERE Masp='" & dtbSP.Rows(i)("Masp") & "' AND  Convert(nvarchar(10),Ngay,101)='" & Ngay & "'"
                    Command_Exc(strSQL, Cn)
                End If
            Else
                If dtbSP.Rows(i)("Khuyenmai") <> True Then
                    strSQL = "Update Tonkho Set Xuattk=Xuattk + " & dtbSP.Rows(i)("Soluong") & " ,Toncuoi=(Tondau+Nhaptk-Xuattk-" & dtbSP.Rows(i)("Soluong") & ") WHERE Masp='" & dtbSP.Rows(i)("Masp") & "' AND  Convert(nvarchar(10),Ngay,101)='" & Ngay & "'"
                    Command_Exc(strSQL, Cn)
                End If
            End If
        Next
    End Function
    Public Function Lay_So_phieu(ByVal LoaiPhieu As Boolean) As Int32
        Dim dtbPhieuXn As New DataTable
        dtbPhieuXn = Load_DataTable("SELECT Max(Sophieu)as Sophieu FROM Phieu_Xuat_Nhap WHERE LoaiPhieu=" & IIf(LoaiPhieu = True, 1, 0) & "", CNNQLPHONGKHAM)
        If dtbPhieuXn.Rows.Count > 0 And Not IsDBNull(dtbPhieuXn.Rows(0)("Sophieu")) Then
            Return dtbPhieuXn.Rows(0)("Sophieu") + 1
        Else
            Return 1000
        End If
    End Function
    Public Function Tinh_Gia_Thanh(ByVal int_IDSophieu As Int32, ByVal MaXN As String) As Int32
        Dim cmdGiathanh As New SqlCommand
        Dim paraSophieu As New SqlParameter
        Dim paraLoaiphieu As New SqlParameter
        Dim paraMaXN As New SqlParameter

        cmdGiathanh.CommandText = "Tinh_gia_thanh"
        cmdGiathanh.CommandType = CommandType.StoredProcedure

        paraSophieu.SqlDbType = SqlDbType.Int
        paraSophieu.ParameterName = "@int_IDSophieu"
        paraSophieu.Direction = ParameterDirection.Input
        paraSophieu.Value = int_IDSophieu

        paraMaXN.SqlDbType = SqlDbType.Char
        paraMaXN.ParameterName = "@MaXN"
        paraMaXN.Direction = ParameterDirection.Input
        paraMaXN.Value = MaXN

        cmdGiathanh.Parameters.Add(paraSophieu)
        cmdGiathanh.Parameters.Add(paraMaXN)
        cmdGiathanh.Connection = CNNQLPHONGKHAM
        Try
            cmdGiathanh.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Tinh_lai_lai(ByVal int_tuSophieu As Int32, ByVal int_denSophieu As Int32) As Int32
        Dim cmdtinhlailai As New SqlCommand
        Dim paraTuSophieu As New SqlParameter
        Dim paradenSophieu As New SqlParameter

        cmdtinhlailai.CommandText = "Tinh_lai_lai"
        cmdtinhlailai.CommandType = CommandType.StoredProcedure

        paraTuSophieu.SqlDbType = SqlDbType.Int
        paraTuSophieu.ParameterName = "@int_tuSophieu"
        paraTuSophieu.Direction = ParameterDirection.Input
        paraTuSophieu.Value = int_tuSophieu

        paradenSophieu.SqlDbType = SqlDbType.Char
        paradenSophieu.ParameterName = "@int_denSophieu"
        paradenSophieu.Direction = ParameterDirection.Input
        paradenSophieu.Value = int_denSophieu

        cmdtinhlailai.Parameters.Add(paraTuSophieu)
        cmdtinhlailai.Parameters.Add(paradenSophieu)
        cmdtinhlailai.Connection = CNNQLPHONGKHAM
        Try
            cmdtinhlailai.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function TinhlaicongnoNX(ByVal int_IDSophieu As Int32) As Int32
        Dim cmdGiathanh As New SqlCommand
        Dim paraSophieu As New SqlParameter

        cmdGiathanh.CommandText = "TinhlaicongnoNX"
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
    Public Function Lay_Ton_kho(ByRef dtvTon_kho As DataView, ByVal Makho As String, ByVal dtCurrDate As Date)
        Dim strSQl As String
        Dim dtbTon_kho As New DataTable
        If Makho <> "" Then
            strSQl = "SELECT Makho,Masp,Tondau,Nhap,Xuat,Toncuoi FROM Ton_kho WHERE Makho='" & Makho & "'"
            dtbTon_kho = Load_DataTable(strSQl, CNNQLPHONGKHAM)
            If dtbTon_kho.Rows.Count = 0 Then
                Dim cmdTonkho As New SqlCommand
                cmdTonkho.CommandType = CommandType.StoredProcedure
                cmdTonkho.Connection = CNNQLPHONGKHAM
                cmdTonkho.CommandText = "Pro_TinhTonkho1"
                Try
                    cmdTonkho.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        dtvTon_kho = dtbTon_kho.DefaultView
    End Function
    Public Function Laycongno(ByVal strMakh As String) As String
        Dim dtbCongno As New DataTable
        Dim strSQL As String
        Dim strSQL1 As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String
        Dim strSQL5 As String
        Dim Tonno As Double
        dtbCongno = Load_DataTable("Select Nobandau FROM No_Ban_dau WHERE Makh='" & strMakh & "'", CNNQLPHONGKHAM)
        If dtbCongno.Rows.Count > 0 Then
            Tonno = Val(dtbCongno.Rows(0)("Nobandau"))
        End If
        strSQL1 = "Select isnull((SELECT Sum(Quydoi)FROM Phieu_xuat_nhap b WHERE a.makh=b.makh and Loaiphieu=0 and huy=0),0)"
        strSQL2 = "isnull((SELECT Sum(Quydoi)FROM Phieu_thu_chi b WHERE a.makh=b.makh and Loaiphieu=1 and huy=0),0)"
        strSQL3 = "isnull((SELECT Sum(Quydoi)FROM Phieu_xuat_nhap b WHERE a.makh=b.makh and Loaiphieu=1 and huy=0),0)"
        strSQL4 = "isnull((SELECT Sum(Quydoi)FROM Phieu_thu_chi b WHERE a.makh=b.makh and Loaiphieu=0 and huy=0),0)"
        strSQL5 = "isnull()"
        strSQL = strSQL1 & "-" & strSQL2 & "+" & strSQL4 & "-" & strSQL3 & " as Tonno from khach_hang a Where a.Makh = '" & strMakh & "'"
        dtbCongno = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        If dtbCongno.Rows.Count > 0 Then
            Tonno = Tonno + Val(dtbCongno.Rows(0)("Tonno"))
        End If
        If Tonno > 0 Then
            Return Tonno
        Else
            Return ""
        End If
    End Function
End Class
