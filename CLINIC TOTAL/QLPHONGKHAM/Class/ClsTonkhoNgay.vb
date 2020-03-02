Public Class ClsTonkhoNgay
    Public Function TinhTonkho(ByVal strMakho As String, ByVal strManhom As String, ByVal strDNgay As DateTime, ByVal strLoai As String) As DataTable
        Dim strFilter As String
        Dim dtbSelect As DataTable
        Dim row As DataRow
        Dim rows As DataRow()
        Dim strSQL As String
        Dim dtbTemp As DataTable
        Dim dtbCTPXN As New DataTable
        Dim dtbrow As DataRow
        Dim dtvrow As DataRowView
        Dim dtvCTPXN As New DataView
        Dim dtbTonkho As New DataTable
        Dim int_i As Integer
        strSQL = "SELECT Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp, SUM(Chi_Tiet_PXN.Soluong) AS Soluong "
        strSQL &= "FROM Phieu_Xuat_Nhap INNER JOIN "
        strSQL &= " Chi_Tiet_PXN ON Phieu_Xuat_Nhap.IDPhieuXn = Chi_Tiet_PXN.IDSophieu INNER JOIN San_Pham ON San_Pham.Masp= Chi_Tiet_PXN.masp "
        strSQL &= "Where Phieu_Xuat_Nhap.Huy=0 AND Phieu_Xuat_Nhap.Makho='" & strMakho & "' AND Left(Chi_Tiet_PXN.Masp,2)='" & strManhom & "' and Ngay = '" & strDNgay & "' "
        strSQL &= "GROUP BY Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp "
        strSQL &= "ORDER BY Phieu_Xuat_Nhap.Loaiphieu"
        dtbCTPXN = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        dtvCTPXN = dtbCTPXN.DefaultView
        strSQL = " select ton_kho.masp,ton_kho.Hansd,San_pham.Tensp as Tensp,sum(ton_kho.tondau)as Tondau,"
        strSQL &= "sum(ton_kho.nhap)as SlNhap,sum(ton_kho.xuat)as SLXuat,sum(ton_kho.toncuoi)as Toncuoi,MAX(Ton_kho.Dongia)as Dongia,"
        strSQL &= "sum(ton_kho.toncuoi)*MAX(Ton_kho.Dongia) as Tonvon FROM ton_kho INNER JOIN San_pham ON Ton_kho.Masp = San_pham.Masp"
        strSQL &= " WHERE left(Ton_kho.masp,2)<>'00' AND Ton_kho.Makho='" & strMakho & "' AND Left(Ton_kho.Masp,2)='" & strManhom & "' AND NOT (Ton_kho.Xuat=0 AND Ton_kho.Nhap=0 AND "
        strSQL &= "Ton_kho.Tondau=0 AND Ton_kho.Toncuoi=0) group by ton_kho.masp,San_pham.Tensp,ton_kho.Hansd "
        dtbTonkho = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        For Each dtbrow In dtbTonkho.Rows
            dtvCTPXN = dtbCTPXN.DefaultView
            dtvCTPXN.RowFilter = "Masp='" & dtbrow("Masp") & "'"
            dtbrow("SLNhap") = 0
            dtbrow("SLXuat") = 0
            If dtvCTPXN.Count > 0 Then
                For Each dtvrow In dtvCTPXN
                    If dtvrow("Loaiphieu") = True Then
                        dtbrow("SLNhap") += dtvrow("Soluong")
                    Else
                        dtbrow("SLXuat") += dtvrow("Soluong")
                    End If
                Next
            End If
            dtbrow("Toncuoi") = dtbrow("Tondau") + dtbrow("SLNhap") - dtbrow("SLXuat")
            dtbrow("Tonvon") = dtbrow("Toncuoi") * dtbrow("Dongia")
        Next
        If strLoai = "1" Then
            strFilter = "Toncuoi>0"
        ElseIf strLoai = "2" Then
            strFilter = "Toncuoi<0"
        ElseIf strLoai = "3" Then
            strFilter = "Toncuoi=0"
        Else
            strFilter = ""
        End If
        dtbSelect = dtbTonkho.Clone
        dtbSelect.Rows.Clear()
        If strFilter <> "" Then
            rows = dtbTonkho.Select(strFilter, "Toncuoi Desc")
            For Each row In rows
                dtbSelect.ImportRow(row)
            Next
            dtbTonkho = dtbSelect
        End If
        Return dtbTonkho
    End Function
    Public Function TinhTonkho1(ByVal strDNgay As DateTime, ByVal strLoai As String) As DataTable
        Dim strFilter As String
        Dim dtbSelect As DataTable
        Dim row As DataRow
        Dim rows As DataRow()
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
        strSQL &= "Where Phieu_Xuat_Nhap.Ngay='" & strDNgay & "' AND Phieu_Xuat_Nhap.Huy=0 "
        strSQL &= "GROUP BY Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp " ',Makho "
        strSQL &= "ORDER BY Phieu_Xuat_Nhap.Loaiphieu"
        dtbCTPXN = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        dtvCTPXN = dtbCTPXN.DefaultView
        strSQL = " select ton_kho.masp,ton_kho.Hansd,San_pham.Tensp as Tensp,sum(ton_kho.tondau)as Tondau,"
        strSQL &= "sum(ton_kho.nhap)as SlNhap,sum(ton_kho.xuat)as SLXuat,sum(ton_kho.toncuoi)as Toncuoi,MAX(Ton_kho.Dongia)as Dongia,"
        strSQL &= "sum(ton_kho.toncuoi)*MAX(Ton_kho.Dongia) as Tonvon FROM ton_kho INNER JOIN San_pham on "
        strSQL &= " Ton_kho.Masp = San_pham.Masp WHERE Left(Ton_kho.Masp,2)<>'00' AND NOT (Ton_kho.Xuat=0 AND Ton_kho.Nhap=0 AND "
        strSQL &= "Ton_kho.Tondau=0 AND Ton_kho.Toncuoi=0) group by ton_kho.masp,San_pham.Tensp" ',Ton_kho.Dongia,ton_kho.makho "
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
        If strLoai = "1" Then
            strFilter = "Toncuoi>0"
        ElseIf strLoai = "2" Then
            strFilter = "Toncuoi<0"
        ElseIf strLoai = "3" Then
            strFilter = "Toncuoi=0"
        Else
            strFilter = ""
        End If
        dtbSelect = dtbTonkho.Clone
        dtbSelect.Rows.Clear()
        If strFilter <> "" Then
            rows = dtbTonkho.Select(strFilter, "Toncuoi Desc")
            For Each row In rows
                dtbSelect.ImportRow(row)
            Next
            dtbTonkho = dtbSelect
        End If
        Return dtbTonkho
    End Function
    Public Function TinhTonkho2(ByVal strManhom As String, ByVal strDNgay As DateTime, ByVal strLoai As String) As DataTable
        Dim strFilter As String
        Dim dtbSelect As DataTable
        Dim row As DataRow
        Dim rows As DataRow()
        Dim strSQL As String
        Dim dtbTemp As DataTable
        Dim dtbCTPXN As New DataTable
        Dim dtbrow As DataRow
        Dim dtvrow As DataRowView
        Dim dtvCTPXN As New DataView
        Dim dtbTonkho As New DataTable
        Dim int_i As Integer
        strSQL = "SELECT Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp, SUM(Chi_Tiet_PXN.Soluong) AS Soluong "
        strSQL &= "FROM Phieu_Xuat_Nhap INNER JOIN "
        strSQL &= " Chi_Tiet_PXN ON Phieu_Xuat_Nhap.IDPhieuXn = Chi_Tiet_PXN.IDSophieu INNER JOIN San_Pham ON San_Pham.Masp= Chi_Tiet_PXN.masp "
        strSQL &= "Where Phieu_Xuat_Nhap.Huy=0 AND Left(Chi_Tiet_PXN.Masp,2)='" & strManhom & "' and Ngay = '" & strDNgay & "' "
        strSQL &= "GROUP BY Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp "
        strSQL &= "ORDER BY Phieu_Xuat_Nhap.Loaiphieu"
        dtbCTPXN = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        dtvCTPXN = dtbCTPXN.DefaultView
        strSQL = " select ton_kho.masp,ton_kho.Hansd,San_pham.Tensp as Tensp,sum(ton_kho.tondau)as Tondau,"
        strSQL &= "sum(ton_kho.nhap)as SlNhap,sum(ton_kho.xuat)as SLXuat,sum(ton_kho.toncuoi)as Toncuoi,MAX(Ton_kho.Dongia)as Dongia,"
        strSQL &= "sum(ton_kho.toncuoi)*MAX(Ton_kho.Dongia) as Tonvon FROM ton_kho INNER JOIN San_pham ON "
        strSQL &= " Ton_kho.Masp = San_pham.Masp WHERE left(Ton_kho.masp,2)<>'00' AND Left(Ton_kho.Masp,2)='" & strManhom & "' AND NOT (Ton_kho.Xuat=0 AND Ton_kho.Nhap=0 AND "
        strSQL &= "Ton_kho.Tondau=0 AND Ton_kho.Toncuoi=0) group by ton_kho.masp,San_pham.Tensp"
        dtbTonkho = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        For Each dtbrow In dtbTonkho.Rows
            dtvCTPXN = dtbCTPXN.DefaultView
            dtvCTPXN.RowFilter = "Masp='" & dtbrow("Masp") & "'"
            dtbrow("SLNhap") = 0
            dtbrow("SLXuat") = 0
            If dtvCTPXN.Count > 0 Then
                For Each dtvrow In dtvCTPXN
                    If dtvrow("Loaiphieu") = True Then
                        dtbrow("SLNhap") += dtvrow("Soluong")
                    Else
                        dtbrow("SLXuat") += dtvrow("Soluong")
                    End If
                Next
            End If
            dtbrow("Toncuoi") = dtbrow("Tondau") + dtbrow("SLNhap") - dtbrow("SLXuat")
            dtbrow("Tonvon") = dtbrow("Toncuoi") * dtbrow("Dongia")
        Next
        If strLoai = "1" Then
            strFilter = "Toncuoi>0"
        ElseIf strLoai = "2" Then
            strFilter = "Toncuoi<0"
        ElseIf strLoai = "3" Then
            strFilter = "Toncuoi=0"
        Else
            strFilter = ""
        End If
        dtbSelect = dtbTonkho.Clone
        dtbSelect.Rows.Clear()
        If strFilter <> "" Then
            rows = dtbTonkho.Select(strFilter, "Toncuoi Desc")
            For Each row In rows
                dtbSelect.ImportRow(row)
            Next
            dtbTonkho = dtbSelect
        End If
        Return dtbTonkho
    End Function
    Public Function TinhTonkho3(ByVal strMakho As String, ByVal strDNgay As DateTime, ByVal strLoai As String) As DataTable
        Dim strFilter As String
        Dim dtbSelect As DataTable
        Dim row As DataRow
        Dim rows As DataRow()
        Dim strSQL As String
        Dim dtbTemp As DataTable
        Dim dtbCTPXN As New DataTable
        Dim dtbrow As DataRow
        Dim dtvrow As DataRowView
        Dim dtvCTPXN As New DataView
        Dim dtbTonkho As New DataTable
        Dim int_i As Integer
        strSQL = "SELECT Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp, SUM(Chi_Tiet_PXN.Soluong) AS Soluong "
        strSQL &= "FROM Phieu_Xuat_Nhap INNER JOIN "
        strSQL &= " Chi_Tiet_PXN ON Phieu_Xuat_Nhap.IDPhieuXn = Chi_Tiet_PXN.IDSophieu INNER JOIN San_Pham ON San_Pham.Masp= Chi_Tiet_PXN.masp "
        strSQL &= "Where Phieu_Xuat_Nhap.Huy=0 AND Phieu_Xuat_Nhap.Makho='" & strMakho & "' and Ngay ='" & strDNgay & "' "
        strSQL &= "GROUP BY Phieu_Xuat_Nhap.Loaiphieu, Chi_Tiet_PXN.Masp "
        strSQL &= "ORDER BY Phieu_Xuat_Nhap.Loaiphieu"
        dtbCTPXN = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        dtvCTPXN = dtbCTPXN.DefaultView
        strSQL = " select ton_kho.masp,ton_kho.Hansd,San_pham.Tensp as Tensp,sum(ton_kho.tondau)as Tondau,"
        strSQL &= "sum(ton_kho.nhap)as SlNhap,sum(ton_kho.xuat)as SLXuat,sum(ton_kho.toncuoi)as Toncuoi,MAX(Ton_kho.Dongia)as Dongia,"
        strSQL &= "sum(ton_kho.toncuoi)*MAX(Ton_kho.Dongia) as Tonvon FROM ton_kho INNER JOIN San_pham ON "
        strSQL &= " Ton_kho.Masp = San_pham.Masp WHERE left(Ton_kho.masp,2)<>'00' AND Ton_kho.Makho='" & strMakho & "' AND NOT (Ton_kho.Xuat=0 AND Ton_kho.Nhap=0 AND "
        strSQL &= "Ton_kho.Tondau=0 AND Ton_kho.Toncuoi=0) group by ton_kho.masp,ton_kho.Hansd,San_pham.Tensp"
        dtbTonkho = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        For Each dtbrow In dtbTonkho.Rows
            dtvCTPXN = dtbCTPXN.DefaultView
            dtvCTPXN.RowFilter = "Masp='" & dtbrow("Masp") & "'"
            dtbrow("SLNhap") = 0
            dtbrow("SLXuat") = 0
            If dtvCTPXN.Count > 0 Then
                For Each dtvrow In dtvCTPXN
                    If dtvrow("Loaiphieu") = True Then
                        dtbrow("SLNhap") += dtvrow("Soluong")
                    Else
                        dtbrow("SLXuat") += dtvrow("Soluong")
                    End If
                Next
            End If
            dtbrow("Toncuoi") = dtbrow("Tondau") + dtbrow("SLNhap") - dtbrow("SLXuat")
            dtbrow("Tonvon") = dtbrow("Toncuoi") * dtbrow("Dongia")
        Next
        If strLoai = "1" Then
            strFilter = "Toncuoi>0"
        ElseIf strLoai = "2" Then
            strFilter = "Toncuoi<0"
        ElseIf strLoai = "3" Then
            strFilter = "Toncuoi=0"
        Else
            strFilter = ""
        End If
        dtbSelect = dtbTonkho.Clone
        dtbSelect.Rows.Clear()
        If strFilter <> "" Then
            rows = dtbTonkho.Select(strFilter, "Toncuoi Desc")
            For Each row In rows
                dtbSelect.ImportRow(row)
            Next
            dtbTonkho = dtbSelect
        End If
        Return dtbTonkho
    End Function
End Class
