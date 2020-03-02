Imports System.IO
Imports System.Data.OleDb

Public Class frmSanPham_Import
    Public _Import As Boolean = False
    Public _CloseThis As Boolean = True

    Private Sub frmSanPham_Import_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Load_ComboBox("select MaKho,TenKho from kho_hang order by TenKho", cmbKhoHang, CNNQLPHONGKHAM)
        Load_ComboBox("select MaNhom as MaLoai,TenNhom as TenLoai from nhom_sp order by TenNhom", cmbLoaisp, CNNQLPHONGKHAM)
        Load_ComboBox("select MaNhom,TenNhom from Tb_NhomXetNghiem order by TenNhom", cmbNhomsp, CNNQLPHONGKHAM)

        RepositoryItemLookUpEdit1.DataSource = Load_DataTable("select MaNhom,TenNhom from nhom_sp order by TenNhom", CNNQLPHONGKHAM)
        RepositoryItemLookUpEdit2.DataSource = Load_DataTable("select MaNhom,TenNhom from Tb_NhomXetNghiem order by TenNhom", CNNQLPHONGKHAM)
        RepositoryItemLookUpEdit3.DataSource = Load_DataTable("select MaPhong,TenPhong from Phong_Ban order by TenPhong", CNNQLPHONGKHAM)

        btnFileExel_Click(Nothing, Nothing)
        _CloseThis = False
    End Sub

#Region "my function"

    Function LoadFileExcel(ByVal openFileDialog As Boolean) As Integer
        Dim dir As New OpenFileDialog()
        dir.Filter = "All Exel|*.xls;*.xlsx|All files (*.*)|*.*"
        Dim dlg As DialogResult
        If (openFileDialog) Then
            dlg = dir.ShowDialog()
            If (_CloseThis And dlg = Windows.Forms.DialogResult.Cancel) Then
                Close()
            End If
        End If
        If (dlg = System.Windows.Forms.DialogResult.OK Or Not openFileDialog) Then
            If (dlg = System.Windows.Forms.DialogResult.OK) Then
                txtFileExel.Text = dir.FileName
                btnLuu.Enabled = True
                btnTaiLai.Enabled = True
            End If
            Dim dt As New DataTable
            dt.Columns.Add("STT", Type.GetType("System.Int32"))
            dt.Columns.Add("MASP", Type.GetType("System.String"))
            dt.Columns.Add("LOAISP", Type.GetType("System.Int32"))
            dt.Columns.Add("NHOMSP", Type.GetType("System.String"))
            dt.Columns.Add("TENSP", Type.GetType("System.String"))
            dt.Columns.Add("DONVT", Type.GetType("System.String"))
            dt.Columns.Add("MOTA", Type.GetType("System.String"))
            dt.Columns.Add("GIABAN", Type.GetType("System.Double"))
            dt.Columns.Add("GIANHAP", Type.GetType("System.Double"))
            dt.Columns.Add("MAPHONG", Type.GetType("System.String"))
            Dim result As String
            If (openFileDialog) Then
                result = Excel.Load(dir.FileName, dt, "SELECT STT,IIF(ISNULL([MASP]),'',[MASP]) as [MASP],IIF(ISNUMERIC([LOAISP]),[LOAISP],0) as [LOAISP],IIF(ISNULL([TENSP]),'',[TENSP]) as [TENSP],IIF(ISNULL([DONVT]),'',[DONVT]) as [DONVT],IIF(ISNULL([MOTA]),'',[MOTA]) as [MOTA],IIF(ISNULL([NHOMSP]),'',[NHOMSP]) as [NHOMSP],IIF(ISNUMERIC([GIABAN]),[GIABAN],0) as [GIABAN],IIF(ISNUMERIC([GIANHAP]),[GIANHAP],0) as [GIANHAP],IIF(ISNULL([MAPHONG]),'',[MAPHONG]) as [MAPHONG] FROM [{0}] WHERE LTRIM(RTRIM([TENSP]))<>'' order by [LOAISP],[TENSP]")
            Else
                result = Excel.Load(txtFileExel.Text, dt, "SELECT STT,IIF(ISNULL([MASP]),'',[MASP]) as [MASP],IIF(ISNUMERIC([LOAISP]),[LOAISP],0) as [LOAISP],IIF(ISNULL([TENSP]),'',[TENSP]) as [TENSP],IIF(ISNULL([DONVT]),'',[DONVT]) as [DONVT],IIF(ISNULL([MOTA]),'',[MOTA]) as [MOTA],IIF(ISNULL([NHOMSP]),'',[NHOMSP]) as [NHOMSP],IIF(ISNUMERIC([GIABAN]),[GIABAN],0) as [GIABAN],IIF(ISNUMERIC([GIANHAP]),[GIANHAP],0) as [GIANHAP],IIF(ISNULL([MAPHONG]),'',[MAPHONG]) as [MAPHONG] FROM [{0}] WHERE LTRIM(RTRIM([TENSP]))<>'' order by [LOAISP],[TENSP]")
            End If
            If (result = "") Then
                GridControl1.DataSource = Nothing
                If (dt.Rows.Count > 0) Then
                    For item As Integer = 0 To dt.Rows.Count - 1
                        dt.Rows(item)("STT") = item + 1
                    Next
                End If
                GridControl1.DataSource = dt
                txtSoLuong.Text = Format(dt.Rows.Count, "###,###")
            Else
                GridControl1.DataSource = Nothing
                txtSoLuong.Text = "0"
                MessageBox.Show(result)
            End If
        End If
        Return 0
    End Function

    Function CheckData(ByVal save As Boolean) As Boolean
        Dim result As Boolean = True
        If (txtFileExel.Text.Trim() = "") Then
            result = False
            ErrPro.SetError(txtFileExel, "Chưa chọn file exel.")
            ErrPro.SetIconAlignment(txtFileExel, ErrorIconAlignment.MiddleRight)
            ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If (save) Then
            If (cmbKhoHang.EditValue = "") Then
                result = False
                ErrPro.SetError(cmbKhoHang, "Chưa chọn kho hàng.")
                ErrPro.SetIconAlignment(cmbKhoHang, ErrorIconAlignment.MiddleRight)
                ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
            End If
            If (GridControl1.DataSource Is Nothing) Then
                result = False
                MsgBox("Không có dữ liệu để cập nhật.")
            Else
                If (GridView1.RowCount = 0) Then
                    result = False
                    MsgBox("Không có dữ liệu để cập nhật.")
                Else
                    For index As Integer = 0 To GridView1.RowCount - 1
                        If (GridView1.GetDataRow(index)("MASP").ToString().Trim() = "") Then
                            result = False
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.FocusedRowHandle = index
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.ShowEditor()
                            MsgBox("Chưa nhập đầy đủ mã sản phẩm.")
                            Exit For
                        End If
                        If (GridView1.GetDataRow(index)("TENSP").ToString().Trim() = "") Then
                            result = False
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.FocusedRowHandle = index
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.ShowEditor()
                            MsgBox("Chưa nhập đầy đủ tên sản phẩm.")
                            Exit For
                        End If
                        If (RepositoryItemLookUpEdit1.GetDataSourceRowByKeyValue(GridView1.GetDataRow(index)("LOAISP")) Is Nothing) Then
                            result = False
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.FocusedRowHandle = index
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.ShowEditor()
                            MsgBox("Chưa nhập đầy đủ tên loại sản phẩm.")
                            Exit For
                        End If
                        If (RepositoryItemLookUpEdit2.GetDataSourceRowByKeyValue(GridView1.GetDataRow(index)("NHOMSP")) Is Nothing) Then
                            result = False
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.FocusedRowHandle = index
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.ShowEditor()
                            MsgBox("Chưa nhập đầy đủ tên nhóm sản phẩm.")
                            Exit For
                        End If
                        If (RepositoryItemLookUpEdit3.GetDataSourceRowByKeyValue(GridView1.GetDataRow(index)("MAPHONG")) Is Nothing) Then
                            result = False
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.FocusedRowHandle = index
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.ShowEditor()
                            MsgBox("Chưa nhập đầy đủ mã phòng quản lý cho sản phẩm.")
                            Exit For
                        End If
                        If (GridView1.GetDataRow(index)("GIABAN") < 0) Then
                            result = False
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.FocusedRowHandle = index
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.ShowEditor()
                            MsgBox("Giá bán của sản phẩm phải lớn hơn hoặc bằng 0")
                            Exit For
                        End If
                        If (GridView1.GetDataRow(index)("GIANHAP") < 0) Then
                            result = False
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.FocusedRowHandle = index
                            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                            GridView1.ShowEditor()
                            MsgBox("Giá nhập của sản phẩm phải lớn hơn hoặc bằng 0")
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
        Return result
    End Function

    Public Function GetKey() As Int32
        Dim dtbmakh As New DataTable
        dtbmakh = Load_DataTable("SELECT Max(cast(MaNhom as int))as MaNhom FROM Nhom_SP ", CNNQLPHONGKHAM)
        If dtbmakh.Rows.Count > 0 And Not IsDBNull(dtbmakh.Rows(0)("MaNhom")) Then
            Return dtbmakh.Rows(0)("MaNhom") + 1
        Else
            Return 10
        End If
    End Function

#End Region

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        _Import = True
        If (CheckData(True)) Then
            Dim cls As New clssanpham
            Dim dr As DataRow
            For index As Integer = 0 To GridView1.RowCount - 1
                ProgressBar1.Value = (index + 1) * 100 / GridView1.RowCount
                dr = GridView1.GetDataRow(index)
                If cls.Addnew(dr("MASP"), dr("LOAISP"), dr("TENSP"), dr("DONVT"), dr("MOTA"), "0", dr("MASP"), dr("LOAISP"), cmbKhoHang.EditValue, dr("NHOMSP"), 0, dr("GIABAN"), dr("GIANHAP"), 1, "", dr("MAPHONG"), 0, "", "", "", "", "", 0) = True Then
                    MsgBox("Chú ý! Mã sản phẩm đã tồn tại ", MsgBoxStyle.Critical)
                Else

                End If
            Next
            MessageBox.Show("Import thành công.")
            _Import = True
            btnLuu.Enabled = False
            btnTaiLai.Enabled = False
            Close()
        End If
    End Sub

    Private Sub btnTaiLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaiLai.Click
        If (CheckData(False)) Then
            cmbLoaisp.EditValue = Nothing
            LoadFileExcel(False)
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub btnFileExel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileExel.Click
        ErrPro.Clear()
        LoadFileExcel(True)
    End Sub

    Private Sub cmbLoaisp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoaisp.EditValueChanged
        If (cmbLoaisp.EditValue <> "" And GridControl1.DataSource IsNot Nothing) Then
            For index As Integer = 0 To GridView1.RowCount - 1
                GridView1.SetRowCellValue(index, "LOAISP", cmbLoaisp.EditValue)
            Next
        End If
    End Sub

    Private Sub cmbNhomsp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNhomsp.EditValueChanged
        If (cmbNhomsp.EditValue <> "" And GridControl1.DataSource IsNot Nothing) Then
            For index As Integer = 0 To GridView1.RowCount - 1
                GridView1.SetRowCellValue(index, "NHOMSP", cmbNhomsp.EditValue)
            Next
        End If
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If (e.KeyCode = Keys.Delete And GridView1.FocusedRowHandle >= 0) Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            For index As Integer = 0 To GridView1.RowCount - 1
                GridView1.SetRowCellValue(index, "STT", index + 1)
            Next
            txtSoLuong.Text = Format(GridView1.RowCount, "###,###")
        End If
    End Sub
End Class