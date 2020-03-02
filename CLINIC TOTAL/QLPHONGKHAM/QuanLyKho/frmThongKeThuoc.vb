Imports System.Collections.Generic
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO.Directory
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel.XlRangeAutoFormat

Public Class frmThongKeThuoc
    Public loainoitru As Int16
    Private Sub frmThongKeThuoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_ComboBox("SELECT [MaKhoa],[TenKhoa] FROM [Tb_DMKHOA]", Me.cmbKhoa, CNNQLPHONGKHAM)
        dtNgay.DateTime = NgayGioServer().ToString("MM/dd/yyyy")
    End Sub

    Public Function danhsach(ByVal khoa As String, ByVal ngay As DateTime) As System.Data.DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CNNQLPHONGKHAM
        cmd.CommandText = "BC_SUDUNGTHUOC"
        cmd.CommandType = CommandType.StoredProcedure

        Dim pkhoa As New SqlParameter("@Makhoa", SqlDbType.NVarChar, 50)
        pkhoa.Value = khoa
        cmd.Parameters.Add(pkhoa)

        Dim pThoiGian As New SqlParameter("@Ngay", SqlDbType.DateTime, 8)
        pThoiGian.Value = ngay.ToString("MM/dd/yyyy")
        cmd.Parameters.Add(pThoiGian)

        Dim myAdapter As New SqlDataAdapter()
        Dim myDataSet As New DataSet()
        myAdapter.SelectCommand = cmd
        myAdapter.Fill(myDataSet, "BC_SUDUNGTHUOC")
        Return myDataSet.Tables("BC_SUDUNGTHUOC")
    End Function
    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        If loainoitru = 1 Then
            dgvDanhSach.DataSource = danhsach(cmbKhoa.EditValue, dtNgay.DateTime)
        Else
            dgvDanhSach.DataSource = danhsach_NGT(cmbKhoa.EditValue, dtNgay.DateTime)
        End If

    End Sub
    Public Function danhsach_NGT(ByVal khoa As String, ByVal ngay As DateTime) As System.Data.DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CNNQLPHONGKHAM
        cmd.CommandText = "BC_SUDUNGTHUOC_NGOAITRU"
        cmd.CommandType = CommandType.StoredProcedure

        Dim pkhoa As New SqlParameter("@Makhoa", SqlDbType.NVarChar, 50)
        pkhoa.Value = khoa
        cmd.Parameters.Add(pkhoa)

        Dim pThoiGian As New SqlParameter("@Ngay", SqlDbType.DateTime, 8)
        pThoiGian.Value = ngay.ToString("MM/dd/yyyy")
        cmd.Parameters.Add(pThoiGian)

        Dim myAdapter As New SqlDataAdapter()
        Dim myDataSet As New DataSet()
        myAdapter.SelectCommand = cmd
        myAdapter.Fill(myDataSet, "BC_SUDUNGTHUOC_NGOAITRU")
        Return myDataSet.Tables("BC_SUDUNGTHUOC_NGOAITRU")
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    '-----------------
    Private Sub btnXuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXuat.Click
        Dim i, j, k As Integer
        Dim dt As System.Data.DataTable

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        If loainoitru = 1 Then
            dt = danhsach(cmbKhoa.EditValue, dtNgay.DateTime)
        Else
            dt = danhsach_NGT(cmbKhoa.EditValue, dtNgay.DateTime)
        End If
        For i = 2 To dt.Columns.Count - 1
            xlWorkSheet.Range("D1", "AC1").Merge()
            xlWorkSheet.Range("D1", "AC1").Font.Size = 14
            xlWorkSheet.Range("D1", "AC1").Font.Bold = True
            xlWorkSheet.Range("D1", "AC1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("D1", "AC1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("D1", "AC1").Value2 = "TÊN THUỐC VÀ HÀM LƯỢNG (" & dtNgay.DateTime.ToString("dd/MM/yyyy") & ")"

            xlWorkSheet.Range("A1", "A2").Merge()
            xlWorkSheet.Range("A1", "A2").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("A1", "A2").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("A1", "A2").Value2 = "SỐ GIƯỜNG"
            xlWorkSheet.Range("A1", "A2").Font.Bold = True
            xlWorkSheet.Cells(1, 1).Orientation = 90

            xlWorkSheet.Range("B1", "B2").Merge()
            xlWorkSheet.Range("B1", "B2").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("B1", "B2").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("B1", "B2").Value2 = "HỌ VÀ TÊN " & vbNewLine & "NGƯỜI BỆNH"
            xlWorkSheet.Range("B1", "B2").Font.Bold = True

            xlWorkSheet.Range("C1", "C2").Merge()
            xlWorkSheet.Range("C1", "C2").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("C1", "C2").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("C1", "C2").Value2 = "TUỔI"
            xlWorkSheet.Range("C1", "C2").Font.Bold = True
            xlWorkSheet.Cells(1, 3).Orientation = 90

            '==========================
            If dt.Rows.Count > 21 Then
                If dt.Rows.Count < 43 Then
                    xlWorkSheet.Range("D26", "AC26").Merge()
                    xlWorkSheet.Range("D26", "AC26").Font.Size = 14
                    xlWorkSheet.Range("D26", "AC26").Font.Bold = True
                    xlWorkSheet.Range("D26", "AC26").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D26", "AC26").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D26", "AC26").Value2 = "TÊN THUỐC VÀ HÀM LƯỢNG (" & dtNgay.DateTime.ToString("dd/MM/yyyy") & ")"

                    xlWorkSheet.Range("A26", "A27").Merge()
                    xlWorkSheet.Range("A26", "A27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A26", "A27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A26", "A27").Value2 = "SỐ GIƯỜNG"
                    xlWorkSheet.Range("A26", "A27").Font.Bold = True
                    xlWorkSheet.Cells(26, 1).Orientation = 90

                    xlWorkSheet.Range("B26", "B27").Merge()
                    xlWorkSheet.Range("B26", "B27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B26", "B27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B26", "B27").Value2 = "HỌ VÀ TÊN " & vbNewLine & "NGƯỜI BỆNH"
                    xlWorkSheet.Range("B26", "B27").Font.Bold = True

                    xlWorkSheet.Range("C26", "C27").Merge()
                    xlWorkSheet.Range("C26", "C27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C26", "C27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C26", "C27").Value2 = "TUỔI"
                    xlWorkSheet.Range("C26", "C27").Font.Bold = True
                    xlWorkSheet.Cells(26, 3).Orientation = 90
                End If
                If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                    xlWorkSheet.Range("D26", "AC26").Merge()
                    xlWorkSheet.Range("D26", "AC26").Font.Size = 14
                    xlWorkSheet.Range("D26", "AC26").Font.Bold = True
                    xlWorkSheet.Range("D26", "AC26").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D26", "AC26").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D26", "AC26").Value2 = "TÊN THUỐC VÀ HÀM LƯỢNG (" & dtNgay.DateTime.ToString("dd/MM/yyyy") & ")"

                    xlWorkSheet.Range("A26", "A27").Merge()
                    xlWorkSheet.Range("A26", "A27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A26", "A27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A26", "A27").Value2 = "SỐ GIƯỜNG"
                    xlWorkSheet.Range("A26", "A27").Font.Bold = True
                    xlWorkSheet.Cells(26, 1).Orientation = 90

                    xlWorkSheet.Range("B26", "B27").Merge()
                    xlWorkSheet.Range("B26", "B27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B26", "B27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B26", "B27").Value2 = "HỌ VÀ TÊN " & vbNewLine & "NGƯỜI BỆNH"
                    xlWorkSheet.Range("B26", "B27").Font.Bold = True

                    xlWorkSheet.Range("C26", "C27").Merge()
                    xlWorkSheet.Range("C26", "C27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C26", "C27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C26", "C27").Value2 = "TUỔI"
                    xlWorkSheet.Range("C26", "C27").Font.Bold = True
                    xlWorkSheet.Cells(26, 3).Orientation = 90
                    '===
                    xlWorkSheet.Range("D51", "AC51").Merge()
                    xlWorkSheet.Range("D51", "AC51").Font.Size = 14
                    xlWorkSheet.Range("D51", "AC51").Font.Bold = True
                    xlWorkSheet.Range("D51", "AC51").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D51", "AC51").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D51", "AC51").Value2 = "TÊN THUỐC VÀ HÀM LƯỢNG (" & dtNgay.DateTime.ToString("dd/MM/yyyy") & ")"

                    xlWorkSheet.Range("A51", "A52").Merge()
                    xlWorkSheet.Range("A51", "A52").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A51", "A52").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A51", "A52").Value2 = "SỐ GIƯỜNG"
                    xlWorkSheet.Range("A51", "A52").Font.Bold = True
                    xlWorkSheet.Cells(51, 1).Orientation = 90

                    xlWorkSheet.Range("B51", "B52").Merge()
                    xlWorkSheet.Range("B51", "B52").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B51", "B52").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B51", "B52").Value2 = "HỌ VÀ TÊN " & vbNewLine & "NGƯỜI BỆNH"
                    xlWorkSheet.Range("B51", "B52").Font.Bold = True

                    xlWorkSheet.Range("C51", "C52").Merge()
                    xlWorkSheet.Range("C51", "C52").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C51", "C52").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C51", "C52").Value2 = "TUỔI"
                    xlWorkSheet.Range("C51", "C52").Font.Bold = True
                    xlWorkSheet.Cells(51, 3).Orientation = 90
                End If
                If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                    xlWorkSheet.Range("D26", "AC26").Merge()
                    xlWorkSheet.Range("D26", "AC26").Font.Size = 14
                    xlWorkSheet.Range("D26", "AC26").Font.Bold = True
                    xlWorkSheet.Range("D26", "AC26").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D26", "AC26").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D26", "AC26").Value2 = "TÊN THUỐC VÀ HÀM LƯỢNG (" & dtNgay.DateTime.ToString("dd/MM/yyyy") & ")"

                    xlWorkSheet.Range("A26", "A27").Merge()
                    xlWorkSheet.Range("A26", "A27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A26", "A27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A26", "A27").Value2 = "SỐ GIƯỜNG"
                    xlWorkSheet.Range("A26", "A27").Font.Bold = True
                    xlWorkSheet.Cells(26, 1).Orientation = 90
                    '====
                    xlWorkSheet.Range("B26", "B27").Merge()
                    xlWorkSheet.Range("B26", "B27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B26", "B27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B26", "B27").Value2 = "HỌ VÀ TÊN " & vbNewLine & "NGƯỜI BỆNH"
                    xlWorkSheet.Range("B26", "B27").Font.Bold = True

                    xlWorkSheet.Range("C26", "C27").Merge()
                    xlWorkSheet.Range("C26", "C27").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C26", "C27").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C26", "C27").Value2 = "TUỔI"
                    xlWorkSheet.Range("C26", "C27").Font.Bold = True
                    xlWorkSheet.Cells(26, 3).Orientation = 90

                    xlWorkSheet.Range("D51", "AC51").Merge()
                    xlWorkSheet.Range("D51", "AC51").Font.Size = 14
                    xlWorkSheet.Range("D51", "AC51").Font.Bold = True
                    xlWorkSheet.Range("D51", "AC51").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D51", "AC51").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D51", "AC51").Value2 = "TÊN THUỐC VÀ HÀM LƯỢNG (" & dtNgay.DateTime.ToString("dd/MM/yyyy") & ")"
                    '===
                    xlWorkSheet.Range("A51", "A52").Merge()
                    xlWorkSheet.Range("A51", "A52").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A51", "A52").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A51", "A52").Value2 = "SỐ GIƯỜNG"
                    xlWorkSheet.Range("A51", "A52").Font.Bold = True
                    xlWorkSheet.Cells(51, 1).Orientation = 90

                    xlWorkSheet.Range("B51", "B52").Merge()
                    xlWorkSheet.Range("B51", "B52").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B51", "B52").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B51", "B52").Value2 = "HỌ VÀ TÊN " & vbNewLine & "NGƯỜI BỆNH"
                    xlWorkSheet.Range("B51", "B52").Font.Bold = True

                    xlWorkSheet.Range("C51", "C52").Merge()
                    xlWorkSheet.Range("C51", "C52").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C51", "C52").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C51", "C52").Value2 = "TUỔI"
                    xlWorkSheet.Range("C51", "C52").Font.Bold = True
                    xlWorkSheet.Cells(51, 3).Orientation = 90
                    '===
                    xlWorkSheet.Range("D76", "AC76").Merge()
                    xlWorkSheet.Range("D76", "AC76").Font.Size = 14
                    xlWorkSheet.Range("D76", "AC76").Font.Bold = True
                    xlWorkSheet.Range("D76", "AC76").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D76", "AC76").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("D76", "AC76").Value2 = "TÊN THUỐC VÀ HÀM LƯỢNG (" & dtNgay.DateTime.ToString("dd/MM/yyyy") & ")"

                    xlWorkSheet.Range("A76", "A77").Merge()
                    xlWorkSheet.Range("A76", "A77").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A76", "A77").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("A76", "A77").Value2 = "SỐ GIƯỜNG"
                    xlWorkSheet.Range("A76", "A77").Font.Bold = True
                    xlWorkSheet.Cells(76, 1).Orientation = 90

                    xlWorkSheet.Range("B76", "B77").Merge()
                    xlWorkSheet.Range("B76", "B77").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B76", "B77").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("B76", "B77").Value2 = "HỌ VÀ TÊN " & vbNewLine & "NGƯỜI BỆNH"
                    xlWorkSheet.Range("B76", "B77").Font.Bold = True

                    xlWorkSheet.Range("C76", "C77").Merge()
                    xlWorkSheet.Range("C76", "C77").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C76", "C77").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range("C76", "C77").Value2 = "TUỔI"
                    xlWorkSheet.Range("C76", "C77").Font.Bold = True
                    xlWorkSheet.Cells(76, 3).Orientation = 90
                End If
            End If
            '==========================
            'xlWorkSheet.Range("A1", "BF50").Font.Name = "Times New Roman"
            'xlWorkSheet.Range("A1", "BF100").Font.Name = "Times New Roman"

            '---header
            xlWorkSheet.Cells(2, i + 1) = dt.Columns(i).ToString()
            xlWorkSheet.Cells(2, i + 2).Orientation = 90
            If dt.Rows.Count > 21 Then
                If dt.Rows.Count < 43 Then
                    xlWorkSheet.Cells(27, i + 1) = dt.Columns(i).ToString()
                    xlWorkSheet.Cells(27, i + 2).Orientation = 90

                    xlWorkSheet.Range("A1", "BF50").Font.Name = "Times New Roman"
                End If
                If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                    xlWorkSheet.Cells(27, i + 1) = dt.Columns(i).ToString()
                    xlWorkSheet.Cells(27, i + 2).Orientation = 90

                    xlWorkSheet.Cells(52, i + 1) = dt.Columns(i).ToString()
                    xlWorkSheet.Cells(52, i + 2).Orientation = 90

                    xlWorkSheet.Range("A1", "BF75").Font.Name = "Times New Roman"
                End If
                If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                    xlWorkSheet.Cells(27, i + 1) = dt.Columns(i).ToString()
                    xlWorkSheet.Cells(27, i + 2).Orientation = 90

                    xlWorkSheet.Cells(52, i + 1) = dt.Columns(i).ToString()
                    xlWorkSheet.Cells(52, i + 2).Orientation = 90

                    xlWorkSheet.Cells(77, i + 1) = dt.Columns(i).ToString()
                    xlWorkSheet.Cells(77, i + 2).Orientation = 90

                    xlWorkSheet.Range("A1", "BF100").Font.Name = "Times New Roman"
                End If
            Else
                xlWorkSheet.Range("A1", "BF25").Font.Name = "Times New Roman"
            End If
        Next

        '---
        xlWorkSheet.Cells(3, 1) = "A"
        xlWorkSheet.Cells(3, 2) = "B"
        xlWorkSheet.Cells(3, 3) = "C"
        If dt.Columns.Count > 27 Then
            For i = 1 To 55
                xlWorkSheet.Cells(3, i + 3) = i
            Next
        Else
            For i = 1 To 26
                xlWorkSheet.Cells(3, i + 3) = i
            Next
        End If

        If dt.Rows.Count > 21 Then
            If dt.Rows.Count < 43 Then
                xlWorkSheet.Cells(28, 1) = "A"
                xlWorkSheet.Cells(28, 2) = "B"
                xlWorkSheet.Cells(28, 3) = "C"
                For i = 1 To 26
                    xlWorkSheet.Cells(28, i + 3) = i
                Next
            End If
            If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                xlWorkSheet.Cells(28, 1) = "A"
                xlWorkSheet.Cells(28, 2) = "B"
                xlWorkSheet.Cells(28, 3) = "C"
                For i = 1 To 26
                    xlWorkSheet.Cells(28, i + 3) = i
                Next

                xlWorkSheet.Cells(53, 1) = "A"
                xlWorkSheet.Cells(53, 2) = "B"
                xlWorkSheet.Cells(53, 3) = "C"
                For i = 1 To 26
                    xlWorkSheet.Cells(53, i + 3) = i
                Next
            End If
            If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                xlWorkSheet.Cells(28, 1) = "A"
                xlWorkSheet.Cells(28, 2) = "B"
                xlWorkSheet.Cells(28, 3) = "C"
                For i = 1 To 26
                    xlWorkSheet.Cells(28, i + 3) = i
                Next

                xlWorkSheet.Cells(53, 1) = "A"
                xlWorkSheet.Cells(53, 2) = "B"
                xlWorkSheet.Cells(53, 3) = "C"
                For i = 1 To 26
                    xlWorkSheet.Cells(53, i + 3) = i
                Next

                xlWorkSheet.Cells(78, 1) = "A"
                xlWorkSheet.Cells(78, 2) = "B"
                xlWorkSheet.Cells(78, 3) = "C"
                For i = 1 To 26
                    xlWorkSheet.Cells(78, i + 3) = i
                Next
            End If
        End If
        '---
        If dt.Rows.Count > 21 Then
            If dt.Rows.Count < 43 Then
                For j = 0 To 20
                    'xlWorkSheet.Cells(j + 4, 2) = dt.Columns(j).ToString()
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 4, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
                For j = 21 To dt.Rows.Count - 1
                    'xlWorkSheet.Cells(j + 4, 2) = dt.Columns(j).ToString()
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 8, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
            End If
            If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                For j = 0 To 20
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 4, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
                For j = 21 To 42
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 8, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
                '=====
                For j = 43 To dt.Rows.Count - 1
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 11, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
            End If

            If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                For j = 0 To 20
                    'xlWorkSheet.Cells(j + 4, 2) = dt.Columns(j).ToString()
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 4, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
                For j = 21 To 42
                    'xlWorkSheet.Cells(j + 4, 2) = dt.Columns(j).ToString()
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 8, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
                '===============
                For j = 43 To 63
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 11, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
                For j = 64 To dt.Rows.Count - 1
                    For i = 0 To dt.Columns.Count - 1
                        xlWorkSheet.Cells(j + 15, i + 1) = dt.Rows(j).Item(i).ToString()
                    Next
                Next
            End If
        Else
            For j = 0 To dt.Rows.Count - 1
                'xlWorkSheet.Cells(j + 4, 2) = dt.Columns(j).ToString()
                For i = 0 To dt.Columns.Count - 1
                    xlWorkSheet.Cells(j + 4, i + 1) = dt.Rows(j).Item(i).ToString()
                Next
            Next
        End If

        '======================= tính tổng ===========================
        For i = 3 To dt.Columns.Count - 1
            Dim d As Double = 0
            Dim row As DataRow
            For Each row In dt.Rows
                If Not row.Item(i) Is DBNull.Value Then
                    d += Math.Ceiling(row.Item(i))
                End If
            Next

            If dt.Rows.Count > 21 Then
                If dt.Rows.Count < 43 Then
                    xlWorkSheet.Cells(50, i + 1) = d
                End If
                If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                    xlWorkSheet.Cells(75, i + 1) = d
                End If

                If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                    xlWorkSheet.Cells(100, i + 1) = d
                End If
            Else
                xlWorkSheet.Cells(25, i + 1) = d
            End If
        Next

        '=====
        If dt.Rows.Count > 21 Then
            If dt.Rows.Count < 43 Then
                'xlWorkSheet = xlApp.Sheets()
                xlWorkSheet.Range(xlWorkSheet.Cells(51, 1), xlWorkSheet.Cells(xlWorkSheet.Rows.Count, 58)).Delete()
            End If
            If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                'xlWorkSheet = xlApp.Sheets()
                xlWorkSheet.Range(xlWorkSheet.Cells(76, 1), xlWorkSheet.Cells(xlWorkSheet.Rows.Count, 58)).Delete()
            End If

            If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                'xlWorkSheet = xlApp.Sheets()
                xlWorkSheet.Range(xlWorkSheet.Cells(101, 1), xlWorkSheet.Cells(xlWorkSheet.Rows.Count, 58)).Delete()
            End If
        Else
            'xlWorkSheet = xlApp.Sheets()
            xlWorkSheet.Range(xlWorkSheet.Cells(26, 1), xlWorkSheet.Cells(xlWorkSheet.Rows.Count, 58)).Delete()
        End If
        '=====

        If dt.Rows.Count > 21 Then
            If dt.Rows.Count < 43 Then
                xlWorkSheet.Cells(50, 1) = "Tổng cộng"
                xlWorkSheet.Range("A50", "C50").Merge()
                xlWorkSheet.Range("A50", "BF50").Font.Bold = True
            End If
            If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                xlWorkSheet.Cells(75, 1) = "Tổng cộng"
                xlWorkSheet.Range("A75", "C75").Merge()
                xlWorkSheet.Range("A75", "BF75").Font.Bold = True
            End If
            If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                xlWorkSheet.Cells(100, 1) = "Tổng cộng"
                xlWorkSheet.Range("A100", "C100").Merge()
                xlWorkSheet.Range("A100", "BF100").Font.Bold = True
            End If
        Else
            xlWorkSheet.Cells(25, 1) = "Tổng cộng"
            xlWorkSheet.Range("A25", "C25").Merge()
            xlWorkSheet.Range("A25", "BF25").Font.Bold = True
        End If

        '===============================================================
        If dt.Rows.Count > 21 Then
            If dt.Rows.Count < 43 Then
                If dt.Columns.Count > 26 Then
                    xlWorkSheet.Range("A1", "BF50").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
                Else
                    xlWorkSheet.Range("A1", "AC50").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
                End If
            End If
            If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                If dt.Columns.Count > 26 Then
                    xlWorkSheet.Range("A1", "BF75").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
                Else
                    xlWorkSheet.Range("A1", "AC75").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
                End If
            End If
            If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                If dt.Columns.Count > 26 Then
                    xlWorkSheet.Range("A1", "BF100").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
                Else
                    xlWorkSheet.Range("A1", "AC100").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
                End If
            End If
        Else
            If dt.Columns.Count > 26 Then
                xlWorkSheet.Range("A1", "BF25").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
            Else
                xlWorkSheet.Range("A1", "AC25").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
            End If
        End If

        xlWorkSheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape        '
        xlApp.Columns.AutoFit()

        If dt.Rows.Count > 21 Then
            If dt.Rows.Count < 43 Then
                xlWorkSheet.Cells.Range("D1", "BF50").ColumnWidth = 3
                xlWorkSheet.Cells.Range("D2", "AC2").RowHeight = 130
                xlWorkSheet.Cells.Range("D27", "AC27").RowHeight = 130
            End If
            If dt.Rows.Count >= 43 And dt.Rows.Count <= 63 Then
                xlWorkSheet.Cells.Range("D1", "BF75").ColumnWidth = 3
                xlWorkSheet.Cells.Range("D2", "AC2").RowHeight = 130
                xlWorkSheet.Cells.Range("D27", "AC27").RowHeight = 130
                xlWorkSheet.Cells.Range("D52", "AC52").RowHeight = 130
            End If
            If dt.Rows.Count >= 64 And dt.Rows.Count <= 84 Then
                xlWorkSheet.Cells.Range("D1", "BF100").ColumnWidth = 3
                xlWorkSheet.Cells.Range("D2", "AC2").RowHeight = 130
                xlWorkSheet.Cells.Range("D27", "AC27").RowHeight = 130
                xlWorkSheet.Cells.Range("D52", "AC52").RowHeight = 130
                xlWorkSheet.Cells.Range("D77", "AC77").RowHeight = 130
            End If
        Else
            xlWorkSheet.Cells.Range("D1", "BF25").ColumnWidth = 3
            xlWorkSheet.Cells.Range("D2", "AC2").RowHeight = 130
        End If
        xlApp.Visible = True
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class