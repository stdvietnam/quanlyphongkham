Public Class CLsTinhlaivondoanhnghiep
    Public Function Tinhlaivonduno(ByVal Ngaybatdau As DateTime, ByVal Ngayketthuc As DateTime)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "TinhLaiVonDuNo"
        cmd.CommandType = CommandType.StoredProcedure
        Dim paraNgaybatdau As New SqlClient.SqlParameter
        paraNgaybatdau.ParameterName = "@Ngaybatdau"
        paraNgaybatdau.DbType = DbType.DateTime
        paraNgaybatdau.Direction = ParameterDirection.Input
        paraNgaybatdau.Value = Ngaybatdau
        cmd.Parameters.Add(paraNgaybatdau)

        Dim paraNgayketthuc As New SqlClient.SqlParameter
        paraNgayketthuc.ParameterName = "@Ngayketthuc"
        paraNgayketthuc.DbType = DbType.DateTime
        paraNgayketthuc.Direction = ParameterDirection.Input
        paraNgayketthuc.Value = Ngayketthuc
        cmd.Parameters.Add(paraNgayketthuc)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
    Public Function tinhlai_tonkhocuoiky()
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Tonkhocuoiky"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 500

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function
    Public Function tinhlai_giamoi()
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "UpdateGiaMoiIntonkho"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 300
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function
    Public Function Tinhlai_tonquycuoiky(ByVal Ngayketthuc As DateTime)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Tonquycuoiky"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 500

        Dim paraNgayketthuc As New SqlClient.SqlParameter
        paraNgayketthuc.ParameterName = "@Ngayketthuc"
        paraNgayketthuc.DbType = DbType.DateTime
        paraNgayketthuc.Direction = ParameterDirection.Input
        paraNgayketthuc.Value = Ngayketthuc
        cmd.Parameters.Add(paraNgayketthuc)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function

    Public Function Tinhlaivonbangtien(ByVal Ngayketthuc As DateTime)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "TinhLaivonbangtien"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraNgayketthuc As New SqlClient.SqlParameter
        paraNgayketthuc.ParameterName = "@Ngayketthuc"
        paraNgayketthuc.DbType = DbType.DateTime
        paraNgayketthuc.Direction = ParameterDirection.Input
        paraNgayketthuc.Value = Ngayketthuc
        cmd.Parameters.Add(paraNgayketthuc)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function
    Public Function Tinhlaivonhangton(ByVal Ngayketthuc As DateTime)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "TinhLaivonhangton"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraNgayketthuc As New SqlClient.SqlParameter
        paraNgayketthuc.ParameterName = "@Ngayketthuc"
        paraNgayketthuc.DbType = DbType.DateTime
        paraNgayketthuc.Direction = ParameterDirection.Input
        paraNgayketthuc.Value = Ngayketthuc
        cmd.Parameters.Add(paraNgayketthuc)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
    Public Function Ent_Capital_CanCulate(ByVal ToDate As DateTime)
      
        Dim strSQL As String
        Dim Tygia As Double
        Dim Tonquy As Double
        Dim dtb As DataTable
        'ToDate = Format(ToDate, "MM/dd/yyyy")
        Dim dtbLiquidCapital As DataTable
        Dim dtbFixedCapital As DataTable
        Dim dtbStockCapital As DataTable
        Dim dtbCashCapital As DataTable
        Dim dbDebitCurrBall As Double
        Dim dbFixCurrBall As Double
        Dim dbStockCurrBall As Double
        Dim dbCashCurrBall As Double
        Dim row As DataRow
        strSQL = "SELECT isnull((SELECT Sum(Quydoi)  FROM Phieu_xuat_nhap WHERE  madv <> '253' and Loaiphieu=0  AND Huy =0 AND Ngay < ='" & ToDate & "'),0) + " 'thai sua madv <> '253' and de ko tinh den cong no TSI
        strSQL &= "isnull((SELECT Sum(Quydoi)FROM Phieu_thu_chi WHERE madv <> '253' and Loaiphieu=0  AND Huy=0 AND Ngay <= '" & ToDate & "'),0)- "
        strSQL &= "isnull((SELECT Sum(Quydoi)FROM Phieu_thu_chi WHERE  madv <> '253' and Loaiphieu=1  AND Huy=0 AND Ngay <= '" & ToDate & "'),0)- "
        strSQL &= "isnull((SELECT Sum(Quydoi)FROM Phieu_xuat_nhap  WHERE madv <> '253' and Loaiphieu=1  AND  Huy=0 AND Ngay <= '" & ToDate & "'),0) as DebitCurrBall"
        dtbLiquidCapital = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        For Each row In dtbLiquidCapital.Rows
            dbDebitCurrBall += row("DebitCurrBall")
        Next
        strSQL = "Select a.MATS,Ngaykhhet,a.Nguyengia,a.Nguyengia as GTKhauhao from Tai_San_Co_dinh a,ChitietKH b "
        strSQL &= "where a.Mats=b.Mats AND a.Ngaykhhet<='" & ToDate.AddDays(1).Date & "' AND Ngaytrich=(Select Max(c.Ngaytrich) FROM  ChitietKH c WHERE b.Mats=c.Mats AND "
        strSQL &= "Ngaytrich<=('" & ToDate.AddDays(1).Date & "')) "
        strSQL &= "Group By a.MaTS,Ngaykhhet,a.Nguyengia "
        strSQL &= "Union "
        strSQL &= "Select a.MATS,Ngaykhhet,a.Nguyengia,Sum(b.GTkhauhao) as GTKhauhao from Tai_San_Co_dinh a,ChitietKH b "
        strSQL &= "where a.Mats=b.Mats AND a.Ngaykhhet>'" & ToDate.AddDays(1).Date & "' AND Ngaytrich=(Select Max(c.Ngaytrich) FROM  ChitietKH c WHERE b.Mats=c.Mats AND "
        strSQL &= "Ngaytrich<('" & ToDate.AddDays(1).Date & "')) "
        strSQL &= "Group By a.MaTS,Ngaykhhet,a.Nguyengia"
        dtbFixedCapital = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        For Each row In dtbFixedCapital.Rows
            dbFixCurrBall += row("Nguyengia") - row("GTKhauhao")
        Next
        dtbStockCapital = TinhTonkho(ToDate)
        For Each row In dtbStockCapital.Rows
            'dbStockCurrBall += row("Toncuoi") * row("dongia")
            dbStockCurrBall += row("Tonvon")
        Next
        strSQL = "Select Tygia,Vonbangtien From Hach_toan_von_DN WHERE convert(nvarchar(10),ngay,101)='" & Format(ToDate, "MM/dd/yyyy") & "'"
        dtb = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        If dtb.Rows.Count > 0 Then
            If Not IsDBNull(dtb.Rows(0)("tygia")) Then Tygia = dtb.Rows(0)("tygia")
            Tonquy = dtb.Rows(0)("Vonbangtien")
        End If
        strSQL = "Select (Sum(ToncuoiUSD)* " & Tygia & " + SUM(ToncuoiVND)) as Cash from Ton_quy where convert(nvarchar(10),ngay,101)='" & Format(ToDate, "MM/dd/yyyy") & "'"
        dtbCashCapital = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        If dtbCashCapital.Rows.Count > 0 Then
            If IsDBNull(dtbCashCapital.Rows(0)(0)) Then
                dbCashCurrBall = Tonquy
            Else
                dbCashCurrBall = dtbCashCapital.Rows(0)(0)
            End If
        End If
        strSQL = "Update Hach_toan_von_DN set Vonbangtien =" & dbCashCurrBall & " ,Vonhangton = " & dbStockCurrBall & " ,Vonduno =" & dbDebitCurrBall & ",Voncodinh =" & dbFixCurrBall & " WHERE convert(nvarchar(10),ngay,101)='" & Format(ToDate, "MM/dd/yyyy") & "'"
        Command_Exc(strSQL, CNNQLPHONGKHAM)
        MsgBox("Đã tính lại xong ngày: " & ToDate.ToShortDateString)

    End Function
    Public Function TinhTonkho(ByVal strNgay As DateTime) As DataTable
       
        Dim strSQL As String
        Dim dtbTemp As DataTable
        Dim dtbCTPXN As New DataTable
        Dim dtbrow As DataRow
        Dim dtvrow As DataRowView
        Dim dtvCTPXN As New DataView
        Dim dtbTonkho As New DataTable
        strSQL = "SELECT Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp, SUM(Chi_Tiet_PXN.Soluong) AS Soluong " ',Makho "
        strSQL &= "FROM Phieu_Xuat_Nhap INNER JOIN "
        strSQL &= " Chi_Tiet_PXN ON Phieu_Xuat_Nhap.IDPhieuXn = Chi_Tiet_PXN.IDSophieu INNER JOIN San_Pham ON San_Pham.Masp= Chi_Tiet_PXN.masp "
        strSQL &= "Where Phieu_Xuat_Nhap.Ngay <='" & strNgay & "' AND Phieu_Xuat_Nhap.Huy=0 "
        strSQL &= "GROUP BY Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp " ',Makho "
        strSQL &= "ORDER BY Phieu_Xuat_Nhap.Loaiphieu"
        dtbCTPXN = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        dtvCTPXN = dtbCTPXN.DefaultView
        strSQL = " select ton_kho.masp, Nhom_SP.TenNhom + '   ' + San_pham.Tensp as Tensp,sum(ton_kho.tondau)as Tondau,"
        strSQL &= "sum(ton_kho.nhap)as SlNhap,sum(ton_kho.xuat)as SLXuat,sum(ton_kho.toncuoi)as Toncuoi,MAX(Ton_kho.Dongia)as Dongia,"
        strSQL &= "sum(ton_kho.toncuoi)*MAX(Ton_kho.Dongia) as Tonvon FROM ton_kho INNER JOIN San_pham INNER JOIN Nhom_SP ON "
        strSQL &= "San_pham.Manhom = Nhom_SP.manhom ON Ton_kho.Masp = San_pham.Masp WHERE Left(Ton_kho.Masp,2)<>'00' AND NOT (Ton_kho.Xuat=0 AND Ton_kho.Nhap=0 AND "
        strSQL &= "Ton_kho.Tondau=0 AND Ton_kho.Toncuoi=0) group by ton_kho.masp,San_pham.Tensp,Nhom_SP.TenNhom " ',ton_kho.makho "
        dtbTonkho = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        For Each dtbrow In dtbTonkho.Rows
            dtvCTPXN = dtbCTPXN.DefaultView
            dtvCTPXN.RowFilter = "Masp='" & dtbrow("Masp") & "'" ' and Makho='" & dtbrow("Makho") & "'"
            dtbrow("SLNhap") = 0
            dtbrow("SLXuat") = 0
            If dtvCTPXN.Count > 0 Then
                For Each dtvrow In dtvCTPXN
                    If dtvrow("Loaiphieu") = True Then
                        If Not IsDBNull(dtvrow("Soluong")) Then dtbrow("SLNhap") += dtvrow("Soluong")
                    Else
                        If Not IsDBNull(dtvrow("Soluong")) Then dtbrow("SLXuat") += dtvrow("Soluong")
                    End If
                Next
            End If
            dtbrow("Toncuoi") = dtbrow("Tondau") + dtbrow("SLNhap") - dtbrow("SLXuat")
            dtbrow("Tonvon") = dtbrow("Toncuoi") * dtbrow("Dongia")
        Next
        Return dtbTonkho

    End Function

End Class
