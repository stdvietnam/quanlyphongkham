Imports System.Data
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Collections.Generic

Public Class FRM_KECANLAMSANG
#Region "Khai bao bien"
    Public Reftype As String
    Public IDSophieu As String
    Public blnDelete As Boolean
    Private dtvCTPXN As DataView
    Private dtbCTPXN As DataTable
    Public blnType As Boolean
    Public blnLoaiphieu As Boolean
    Private htbDelete As New Hashtable
    Public IDPhieuxuat As Int32 = 0
    'Private dtvTon_kho As DataView
    Private dtv_PreCTPXN As DataView
    Private dtb_PreCTPXN As DataTable
    Private foundClick As Boolean = True
    Private BoQuaDK As Boolean
    Private sky As Boolean
    Private frmState As Boolean
    Private k As Int16 = 0
    Private Madv As String
    Private bYNO As Boolean = False
    'các biến dưới đây dùng để tính lãi
    Public plai As Boolean
    Public Doanhso As Double
    Public von As Double
    Public lai As Double
    Public VAT As Double
    Private stype As Boolean = False
    Private StypeSUA As Boolean = False
    'biến dưới đây dùng để nhập thêm sản phẩm mới
    Private blnsp As Boolean = False
    Private lbntruoc As Boolean
    Private lbnsau As Boolean
    Private IDsophieu_daythuchi As Int32
    Public xnxong As Boolean = True
    Private dts As New DataSet
    Public LoaiPhong As Int16
    Public Giaodien As Boolean = False
    Public suaphieu As Boolean = False
    Public duoclam As Int16
    Public Masp As String
    Public Tensp As String
    Public Dongia As Double
    Public Soluong As Double
    Public LoaiDV As Integer
    Public NXN As String
    Public Maphong As String

    Public NhomDV As String = ""
    Public bs As Boolean = False
    Public PhongKham As String = ""
    Public Inidphieugoc As Integer
    Public loaiphieu As Int16
    '---
    Public PhongBN As String
    Public giuongbn As String
    Public KhoaNT As String
    Public IsNew As Integer = 0
    Public IsNew2 As Boolean
    '---
    Public load_all As Boolean = True
    Public loai As String = ""
    Public type As String = "" 'nhóm loại dịch vụ chỉ định
    Private dtin As New DataTable
    Public thutien As Boolean
    Public Is_DotDieuTri As Boolean = False
    Public isCloseForm As Boolean = False

    Friend WithEvents grbnongdo As System.Windows.Forms.GroupBox
    Friend WithEvents txthongcau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txttieucau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtbachcau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
#End Region

    Private Sub FRM_KECANLAMSANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Ctrl_QuyenForm(Me)
        Form_Initial()
        load_combo()
        If IDSophieu <> "0" Then
            Me.btnThem.Enabled = False
            Me.btnIn.Enabled = True
            Me.btnSua.Enabled = True
            Me.btnXoa.Enabled = True
            Me.btnThoat.Enabled = True
            Me.grdDinh_khoan.Enabled = True
            btnxuatvt.Enabled = True
            suaphieu = True
            Loaddata()
            Form_Initial()
            cmbloaixn.EditValue = ""
        Else
            suaphieu = False
            Reftype = "CLS" + txtSophieu.Text
            Me.txtSophieuCT.Text = GetNextRefNo(Reftype)
        End If
        If (IsNew = 1) Then
            addNew()
        End If
        Panel_Button.Enabled = True
        Panel_KetLuan.Enabled = True
    End Sub

    Sub addNew()
        Me.GroupControl1.Enabled = True
        Me.Grb.Enabled = True
        Me.grdDinh_khoan.Enabled = True
        Me.GridView1.OptionsBehavior.ReadOnly = False
        Me.btnCap_nhat.Enabled = True
        Me.txtKetluan.Enabled = True
        IsNew2 = True
        If load_all = True Then
            Me.cmbloaixn.EditValue = ""
        End If
        Me.CheckEdit1.Checked = True
        Me.cmbdoi_tuong.EditValue = 1
        Me.btnKhamxong.Enabled = False
    End Sub
    Private Sub load_combo()
        Load_ComboBox("SELECT MABN[Mã],HOTENBN[Họ và tên],Dienthoai[Điện thoại] From HOSOBN order by MABN desc", Me.cmbMaBN, CNNQLPHONGKHAM, True)
        Load_ComboBox("SELECT maphong[Mã],tenphong[Phòng] From Phong_ban", Me.cmbphong, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang order by Tenkho", Me.CmbKhohang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT username[Mã],hoten[Họ tên] From nguoi_su_dung ", Me.cmbbacsi, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT username[Mã],hoten[Họ tên] From nguoi_su_dung   order by hoten ", Me.cmbnlap, CNNQLPHONGKHAM)
        Load_ComboBox("Select id[Mã],doituong[Đối tượng] from DM_DOITUONG", cmbdoi_tuong, CNNQLPHONGKHAM)

        Load_ComboBox("Select Manhom[Mã],Tennhom[Tên nhóm] From nhom_sp Where Manhom not in(N'10',N'19')", Me.CmbManhom, CNNQLPHONGKHAM)
        If CmbManhom.EditValue <> "" Then
            Load_ComboBox("SELECT MaNhom[Mã],TenNhom[Loại XN] From Tb_NhomXetNghiem where Active=1 And Id_NhomSp=N'" & CmbManhom.EditValue & "' order by ID ", Me.cmbloaixn, CNNQLPHONGKHAM)
        Else
            Load_ComboBox("SELECT MaNhom[Mã],TenNhom[Loại XN] From Tb_NhomXetNghiem where Active=1 And Id_NhomSp NOT IN (N'10',N'19') order by ID ", Me.cmbloaixn, CNNQLPHONGKHAM)
        End If
        Me.cmbbacsi.EditValue = ""
    End Sub

    Private Sub Form_Initial()
        Dim dt As New DataTable
        Dim sql As String = "Select Distinct s.id,s.Masp,s.tensp,s.mota,Donvt,s.dongia as Amount2,0 as toncuoi,s.Manhom as LoaiDV,MaNhomXetnghiem as NhomXetNghiem,s.MaPhong From San_Pham s join Nhom_sp n on s.manhom=n.manhom Where s.manhom not in (10,12) order by s.masp"
        If (Me.txtID_LoaiPhieu.Text <> "0") Then
            sql = "Select Distinct s.id,s.Masp,s.tensp,s.mota,Donvt,s.dongia as Amount2,0 as toncuoi,s.Manhom as LoaiDV,MaNhomXetnghiem as NhomXetNghiem,s.MaPhong From San_Pham s join Nhom_sp n on s.manhom=n.manhom Where s.manhom not in (10,12) order by s.masp"
            Me.CmbKhohang.Visible = False
        Else
            sql = "Select Distinct s.id,s.Masp,s.tensp,s.mota,Donvt,s.dongia as Amount2,0 as toncuoi,s.Manhom as LoaiDV,MaNhomXetnghiem as NhomXetNghiem,s.MaPhong From San_Pham s join Nhom_sp n on s.manhom=n.manhom Where s.manhom not in (10,12)"
            Me.CmbKhohang.Visible = True
        End If

        dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
        Me.RepositoryItemLookUpEdit1.DataSource = dt
        Me.RepositoryItemLookUpEdit2.DataSource = dt
        Me.RepositoryItemLookUpEdit4.DataSource = dt

        sql = "Select Username,Hoten from Nguoi_Su_Dung"
        Me.RepositoryItemLookUpEdit3.DataSource = BusinessLogic.Data.GetDataset(sql).Tables(0)
        Pre_CTPXNLLoad()
    End Sub

    Private Sub Pre_CTPXNLLoad()
        Dim sql As String
        sql = "SELECT ID,IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung,Nguoilap,Bacsi,MaPhong, NhomXetnghiem,ChanDoanLamSang,PhongKham,TuNgay,Is_nguoithuchien,trangthai,Is_HenKham,(CASE WHEN ISNULL(Is_HenKham,0)=1 THEN NgayHenKham ELSE NULL END) AS NgayHenKham FROM Chi_tiet_NEW WHERE 1=1 "
        If IDSophieu <> "0" Then
            sql &= String.Format("AND RefNo=N'{0}' AND isnull(thutien,0) in (0,1) AND Huy=0 AND LoaiDV in ({1}) order by id ", IDSophieu, loai)
        Else
            sql &= "AND IDSophieu='-99999' order by id "
        End If
        dtb_PreCTPXN = BusinessLogic.Data.GetDataset(sql).Tables(0)
        dtvCTPXN = dtb_PreCTPXN.DefaultView
        Me.grdDinh_khoan.DataSource = dtb_PreCTPXN
        Dim d As Double = 0
        Try
            d = Double.Parse(dtvCTPXN.Table.Compute("SUM(Thanhtien)", "").ToString())
        Catch ex As Exception
        End Try
        txtAmount.Text = d.ToString("#,###")
    End Sub

    Private Sub Loaddata()
        Dim sql As String = ""
        Dim dt As New DataTable
        sql = String.Format("SELECT ID,IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung,Nguoilap,Bacsi, MaPhong,NhomXetnghiem,ChanDoanLamSang,PhongKham,TuNgay,Is_nguoithuchien,Trangthai FROM Chi_tiet_NEW where RefNo=N'{0}' and LoaiDV in ({1}) order by id ", IDSophieu, loai)
        dts = BusinessLogic.Data.GetDataset(sql)
        dt = dts.Tables(0)
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0)("Mabn") Is DBNull.Value Then
                Me.cmbMaBN.EditValue = dt.Rows(0)("Mabn")
            End If
            If Not dt.Rows(0)("KetluanChung") Is DBNull.Value Then
                Me.txtKetluan.Text = dt.Rows(0)("KetluanChung")
            End If
            If Not dt.Rows(0)("ChanDoanLamSang") Is DBNull.Value Then
                Me.Rich_lamsang.Text = dt.Rows(0)("ChanDoanLamSang")
            End If
            If Not dt.Rows(0)("DateLap") Is DBNull.Value Then
                Me.DtpNgaylap.DateTime = dt.Rows(0)("DateLap")
            End If
            If Not dt.Rows(0)("IDSophieu") Is DBNull.Value Then
                Me.txtSophieu.Text = dt.Rows(0)("IDSophieu")
            End If
            If Not dt.Rows(0)("RefNo") Is DBNull.Value Then
                Me.txtSophieuCT.Text = dt.Rows(0)("RefNo")
            End If
            If Not dt.Rows(0)("Nguoilap") Is DBNull.Value Then
                Me.cmbnlap.EditValue = dt.Rows(0)("Nguoilap")
            End If
            If Not dt.Rows(0)("MaPhong") Is DBNull.Value Then
                Me.cmbphong.EditValue = dt.Rows(0)("MaPhong")
            End If
            If Not dt.Rows(0)("NhomXetnghiem") Is DBNull.Value Then
                Me.cmbloaixn.EditValue = dt.Rows(0)("NhomXetnghiem")
            Else
                Me.cmbloaixn.EditValue = ""
            End If
            If dt.Rows(0)("Is_nguoithuchien") = True Then
                CheckEdit1.Checked = True
                If Not dt.Rows(0)("bacsi") Is DBNull.Value Then
                    Me.cmbbacsi.EditValue = dt.Rows(0)("bacsi")
                End If
            Else
                CheckEdit1.Checked = False
                Me.cmbbacsi.EditValue = ""
            End If
            Me.cmbdoi_tuong.EditValue = 1
            xnxong = dt.Rows(0)("Trangthai")
            If xnxong = False Then
                Me.btnKhamxong.Enabled = True
            Else
                Me.btnKhamxong.Enabled = False
                Me.btnXoa.Enabled = False
                Me.btnSua.Enabled = False
                Me.btnThem.Enabled = False
                Me.btnHuy.Enabled = False
            End If
            'Me.Grb.Enabled = False
        End If
        Pre_CTPXNLLoad()
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim i As Int16
        Dim row As DataRow
        Dim tab As DataTable
        row = Me.GridView1.GetDataRow(e.RowHandle)
        Try
            '-- Change Column Masp or Soluong --
            If e.Column.FieldName = "Masp" Or e.Column.FieldName = "Soluong" Then
                row("Dongia") = chech_gia(row("Masp"))
                row("Thanhtien") = row("Soluong") * row("Dongia")
                tab = Get_Maphong(row("Masp"))
                If tab.Rows.Count > 0 Then
                    row("MaPhong") = tab.Rows(0)("Maphong")
                    row("LoaiDV") = tab.Rows(0)("Manhom")
                    row("NhomXetnghiem") = tab.Rows(0)("MaNhomXetnghiem")
                Else
                    row("MaPhong") = ""
                    row("LoaiDV") = "0"
                    row("NhomXetnghiem") = ""
                End If
            End If
            '-- Change Column DonGia --
            If e.Column.FieldName = "Dongia" Then
                row("Thanhtien") = row("Soluong") * row("Dongia")
            End If
            '-- Click chọn column khám xong --
            If e.Column.FieldName = "trangthai" Then
                Dim sql As String = ""
                If row("trangthai") = True Then
                    sql = String.Format("Update Chi_tiet_NEW set trangthai=1 WHERE RefNo=N'{0}' and LoaiDV in ({1}) and Masp=N'{2}'", txtSophieuCT.Text.Trim, loai, row("Masp"))
                Else
                    sql = String.Format("Update Chi_tiet_NEW set trangthai=0 WHERE RefNo=N'{0}' and LoaiDV in ({1}) and Masp=N'{2}'", txtSophieuCT.Text.Trim, loai, row("Masp"))
                End If
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                    Pre_CTPXNLLoad()
                End If
            End If
            '-- Tính lại tổng tiền --
            Me.GridView1.UpdateCurrentRow()
            Dim d As Double = 0
            Try
                d = Double.Parse(dtvCTPXN.Table.Compute("SUM(Thanhtien)", "").ToString())
            Catch ex As Exception
            End Try
            txtAmount.Text = d.ToString("#,###")
        Catch ex As Exception

        End Try
    End Sub

    Private Function chech_gia(ByVal Masp As String) As Double
        Dim dtbtonkho As DataTable
        dts = BusinessLogic.Data.GetDataset(String.Format("Select distinct dongia as Giaban From san_pham WHERE Masp=N'{0}'", Masp))
        dtbtonkho = dts.Tables(0)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("Giaban")
        Else
            MsgBox("Sản phẩm này hiện không có giá bán", MsgBoxStyle.Critical)
        End If
    End Function

    Private Function TongUSD() As Decimal
        Dim row As DataRow
        Dim tongtien As Decimal = 0
        For Each row In dtvCTPXN.Table.Rows
            Try
                tongtien += row("Thanhtien")
            Catch ex As Exception
            End Try
        Next
        Return tongtien
    End Function

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.grdDinh_khoan.Enabled = True
        Me.GroupControl1.Enabled = True
        'Me.grbnongdo.Enabled = True
        Me.Grb.Enabled = True
        Me.GridView1.OptionsBehavior.ReadOnly = False
        Me.btnIn.Enabled = False
        Me.txtKetluan.Enabled = True
        Me.Label12.Enabled = True
        Me.btnKhamxong.Enabled = True
        IsNew2 = False
        suaphieu = True
        If loai = "" Then
            Dim sql As String
            sql = "SELECT ID,IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung,Nguoilap,Bacsi,MaPhong, NhomXetnghiem,ChanDoanLamSang,PhongKham,TuNgay,Is_nguoithuchien,Is_HenKham, (CASE WHEN ISNULL(Is_HenKham,0)=1 THEN NgayHenKham ELSE NULL END) AS NgayHenKham "
            sql &= String.Format("FROM Chi_tiet_NEW where Refno=N'{0}' and isnull(thutien,0) in (0,1) and Huy=0 order by id", txtSophieuCT.Text)
            dtb_PreCTPXN = BusinessLogic.Data.GetDataset(sql).Tables(0)
            dtvCTPXN = dtb_PreCTPXN.DefaultView
            Me.grdDinh_khoan.DataSource = dtb_PreCTPXN
            Dim d As Double = 0
            Try
                d = Double.Parse(dtvCTPXN.Table.Compute("SUM(Thanhtien)", "").ToString())
            Catch ex As Exception
            End Try
            txtAmount.Text = d.ToString("#,###")
        End If
        Me.Panel_Button.Enabled = True
        Me.Panel_KetLuan.Enabled = True
    End Sub

    Private Sub frmPhieuXN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim i As Int16
        If e.KeyCode = Keys.Delete Then
            If blnsp = True Then
                Dim dr As DataRowView
                dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
                If Not dr Is Nothing Then dr.Delete()
                If IDPhieuxuat = 0 Then
                    For i = 0 To Me.GridView1.RowCount - 2
                        dr = Me.GridView1.GetRow(i)
                        dr("STT") = i + 1
                    Next
                End If
                GridView1.UpdateCurrentRow()
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            If blnsp = True Then
                If blnLoaiphieu = True Then
                    Dim dr As DataRowView
                    Dim dt As DataTable
                    Dim frmKh As New frmSanpham
                    frmKh.ShowDialog()
                    If frmKh.Key = True Then
                        Me.GridView1.AddNewRow()
                        dt = BusinessLogic.Data.GetDataset("Select l.Maloai as masp,Tenloai as tensp,Amount as Amount2 From LOAIDICHVU l join BangGia_2 b on l.maloai=b.maloai where SIEUAM_XN=4", CommandType.Text, Nothing, Nothing).Tables(0)
                        Me.RepositoryItemLookUpEdit1.DataSource = dt
                        Me.RepositoryItemLookUpEdit2.DataSource = dt
                        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
                        dr("Masp") = frmKh.IDmoi
                        GridView1.UpdateCurrentRow()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle)
        Dim row1 As DataRow
        row1 = Me.GridView1.GetDataRow(e.RowHandle - 1)
        row("THANHTIEN") = 0
        row("SOLUONG") = 1
        row("DONGIA") = 0
        row("GHICHU") = ""
        If row.Table.Rows.Count = 0 Then
            row("ID") = 0
            row("STT") = 1
        Else
            row("ID") = row.Table.Rows.Count
            row("STT") = row.Table.Rows.Count + 1
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Export()
    End Sub

    Private Sub Export()
        'Dim grid As DevExpress.XtraGrid.GridControl = Me.grdDinh_khoan
        'Dim provider As IExportProvider = New ExportXlsProvider("C:\TestExport.xLs")
        'Dim link As BaseExportLink = grid.DefaultView.CreateExportLink(provider)
        'link.ExportTo(True)
        'Dim HelpProvider1 As New HelpProvider
        'Help.ShowHelp(Me, "C:\TestExport.xLs")
    End Sub

    Private Sub GridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        blnsp = True
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        If Me.GridView1.RowCount = 1 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn dịch vụ", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(Me.txtSophieu.Text) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Số phiếu không được để trống", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(Me.cmbMaBN.Text) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Thông tin bệnh nhân chưa có", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Return
        End If
        'If Me.cmbphong.EditValue = "" Then
        '    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn phòng", "Thông báo...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        '    Return
        'End If
        If suaphieu = True Then
            MyUpdate()
            SaveEntry()
        Else
            Me.txtSophieuCT.Text = GetNextRefNo(Reftype) 'CAN XEM LAI VAN DANG BI TRUNG SO PHIEU
            SaveEntry()
        End If
        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Ctrl_QuyenForm(Me)
        Me.btnIn.Enabled = True
        Me.btnThoat.Enabled = True
        If xnxong = False Then
            Me.btnKhamxong.Enabled = True
        Else
            Me.btnKhamxong.Enabled = False
        End If
        Me.Panel_Button.Enabled = True
        Me.Panel_KetLuan.Enabled = True
    End Sub

    Private Sub SaveEntry()
        Dim dt As New DataTable
        dt = Me.grdDinh_khoan.DataSource
        If Not dt Is Nothing Then
            If Not dt.GetChanges(DataRowState.Modified) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Modified).Rows
                    UpdateEntry(row)
                Next
            End If
            If Not dt.GetChanges(DataRowState.Unchanged) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Unchanged).Rows
                    UpdateEntry(row)
                Next
            End If
            If Not dt.GetChanges(DataRowState.Deleted) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Deleted).Rows
                    DeleteEntry(row)
                Next
            End If
            If Not dt.GetChanges(DataRowState.Added) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Added).Rows
                    AddNewEntry(row)
                Next
            End If
            dt.AcceptChanges()
        End If
    End Sub

    Private Sub MyUpdate()
        Dim sql As String = ""
        If CheckEdit1.Checked = True Then
            sql = "UPDATE Chi_tiet_NEW SET Mabn=N'" & cmbMaBN.EditValue.ToString() & "',DateLap='" & DtpNgaylap.DateTime & "',TotalAmount='" & Double.Parse("0" + txtAmount.Text) & "',RefNo=N'" & Me.txtSophieuCT.Text & "',KetluanChung=N'" & Me.txtKetluan.Text & "',Nguoilap='" & Me.cmbnlap.EditValue & "',Bacsi='" & IIf(Me.cmbbacsi.EditValue = Nothing, "", Me.cmbbacsi.EditValue) & "',MaPhong='" & IIf(cmbphong.EditValue = Nothing, "", cmbphong.EditValue) & "',Is_nguoithuchien=1 WHERE refno='" & txtSophieuCT.Text & "'"
        Else
            sql = "UPDATE Chi_tiet_NEW SET Mabn=N'" & cmbMaBN.EditValue.ToString() & "',DateLap='" & DtpNgaylap.DateTime & "',TotalAmount='" & Double.Parse("0" + txtAmount.Text) & "',RefNo=N'" & Me.txtSophieuCT.Text & "',KetluanChung=N'" & Me.txtKetluan.Text & "',Nguoilap='" & Me.cmbnlap.EditValue & "',Bacsi='',MaPhong='" & IIf(cmbphong.EditValue = Nothing, "", cmbphong.EditValue) & "',Is_nguoithuchien=0 WHERE refno='" & txtSophieuCT.Text & "'"
        End If
        If loai.Trim() <> "" Then
            sql &= " AND LoaiDV in (" & loai & ")"
        End If
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub

    Private Sub AddNewEntry(ByVal row As DataRow)
        Dim sql As String
        If CheckEdit1.Checked = True Then
            sql = "INSERT INTO Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung,Nguoilap,Bacsi,MaPhong,NhomXetnghiem,ChanDoanLamSang,PhongKham,TuNgay,Is_nguoithuchien,Is_HenKham)"
            sql &= "VALUES(N'" & txtSophieu.Text & "',N'" & row("Masp") & "',N'" & row("Soluong").ToString() & "',N'" & Double.Parse("0" + row("Dongia").ToString()) & "',N'" & Double.Parse("0" + row("Thanhtien").ToString()) & "',N'" & row("STT").ToString() & "',N'" & cmbMaBN.EditValue.ToString() & "',N'" & DtpNgaylap.DateTime.Date.ToString("MM/dd/yyyy") & "','" & Double.Parse("0" + txtAmount.Text) & "','',N'" & row("LoaiDV") & "',N'" & txtSophieuCT.Text & "',N'" & row("ghichu").ToString() & "',N'" & txtKetluan.Text & "','" & cmbnlap.EditValue & "',N'" & cmbbacsi.EditValue & "','" & row("MaPhong").ToString() & "',N'" & row("NhomXetnghiem").ToString() & "',N'" & Rich_lamsang.Text & "',N'" & PhongKham & "',N'" & DateTime.Now & "',1,0)"
        Else
            sql = "INSERT INTO Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung,Nguoilap,Bacsi,MaPhong,NhomXetnghiem,ChanDoanLamSang,PhongKham,TuNgay,Is_nguoithuchien,Is_HenKham)"
            sql &= "VALUES(N'" & txtSophieu.Text & "',N'" & row("Masp") & "',N'" & row("Soluong").ToString() & "',N'" & Double.Parse("0" + row("Dongia").ToString()) & "',N'" & Double.Parse("0" + row("Thanhtien").ToString()) & "',N'" & row("STT").ToString() & "',N'" & cmbMaBN.EditValue.ToString() & "',N'" & DtpNgaylap.DateTime.Date.ToString("MM/dd/yyyy") & "','" & Double.Parse("0" + txtAmount.Text) & "','',N'" & row("LoaiDV") & "',N'" & txtSophieuCT.Text & "',N'" & row("ghichu").ToString() & "',N'" & txtKetluan.Text & "','" & cmbnlap.EditValue & "','" & row("Bacsi") & "','" & row("MaPhong").ToString() & "',N'" & row("NhomXetnghiem").ToString() & "',N'" & Rich_lamsang.Text & "',N'" & PhongKham & "',N'" & DateTime.Now & "',0,0)"
        End If
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub

    Private Sub UpdateEntry(ByVal row As DataRow)
        Dim sql As String
        If CheckEdit1.Checked = True Then
            sql = "UPDATE Chi_tiet_NEW SET Masp='" & row("Masp") & "',soluong='" & row("soluong") & "',dongia='" & Double.Parse("0" + row("dongia")) & "',thanhtien='" & Double.Parse("0" + row("thanhtien")) & "',STT=N'" & row("STT").ToString() & "',Mabn=N'" & cmbMaBN.EditValue.ToString() & "',DateLap=N'" & DtpNgaylap.DateTime.Date.ToString("MM/dd/yyyy") & "',TotalAmount='" & Double.Parse("0" + txtAmount.Text) & "',Makho='',LoaiDV=N'" & row("LoaiDV") & "',RefNo=N'" & Me.txtSophieuCT.Text & "',Ghichu=N'" & row("ghichu").ToString() & "',KetluanChung=N'" & Me.txtKetluan.Text & "',Nguoilap='" & IIf(Me.cmbnlap.EditValue = Nothing, "", Me.cmbnlap.EditValue) & "',Bacsi='" & IIf(Me.cmbbacsi.EditValue = Nothing, "", cmbbacsi.EditValue) & "',MaPhong='" & row("MaPhong") & "',Is_nguoithuchien=1,Is_HenKham=" & IIf(row("Is_HenKham") = False, 0, 1) & ",NgayHenKham='" & row("NgayHenKham") & "' WHERE ID='" & row("ID") & "'"
        Else
            sql = "UPDATE Chi_tiet_NEW SET Masp='" & row("Masp") & "',soluong='" & row("soluong") & "',dongia='" & Double.Parse("0" + row("dongia")) & "',thanhtien='" & Double.Parse("0" + row("thanhtien")) & "',STT=N'" & row("STT").ToString() & "',Mabn=N'" & cmbMaBN.EditValue.ToString() & "',DateLap=N'" & DtpNgaylap.DateTime.Date.ToString("MM/dd/yyyy") & "',TotalAmount='" & Double.Parse("0" + txtAmount.Text) & "',Makho='',LoaiDV=N'" & row("LoaiDV") & "',RefNo=N'" & Me.txtSophieuCT.Text & "',Ghichu=N'" & row("ghichu").ToString() & "',KetluanChung=N'" & Me.txtKetluan.Text & "',Nguoilap='" & IIf(Me.cmbnlap.EditValue = Nothing, "", Me.cmbnlap.EditValue) & "',Bacsi='" & row("Bacsi") & "',MaPhong='" & row("MaPhong") & "',Is_nguoithuchien=0,Is_HenKham=" & IIf(row("Is_HenKham") = False, 0, 1) & ",NgayHenKham='" & row("NgayHenKham") & "' WHERE ID='" & row("ID") & "'"
        End If
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub

    Private Sub DeleteEntry(ByVal row As DataRow)
        Dim sql As String
        sql = "DELETE FROM Chi_tiet_NEW WHERE ID='" & row("ID", DataRowVersion.Original) & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim strSql As String
        If MsgBox("Bạn có muốn xoá phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strSql = String.Format("DELETE FROM Chi_tiet_NEW WHERE RefNo=N'{0}'", Me.txtSophieuCT.Text)
            If Command_Exc(strSql, CNNQLPHONGKHAM) = 0 Then
                MsgBox("Phiếu hiện tại đã được xoá!")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Me.btnThem.Enabled = True        '
    End Sub

    Private Sub cmbMaBN_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMaBN.EditValueChanged
        Dim dt As New DataTable
        Dim sql As String = ""
        sql = String.Format("SELECT HoTenBN,DiaChiChiTiet,DienThoai,(Case GioiTinh when 1 then N'Nam' else N'Nữ' end) as GioiTinh,NgaySinh,d2.ten as NgheNghiep ")
        sql &= String.Format("FROM HOSOBN b LEFT JOIN DMCHUNG d2 on d2.ma=b.nghenghiep WHERE MABN=N'{0}'", Me.cmbMaBN.EditValue)
        If Me.cmbMaBN.EditValue <> Nothing Then
            dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
            If dt.Rows.Count > 0 Then
                Me.txtTenBN.Text = dt.Rows(0)("HoTenBN").ToString()
                If Not dt.Rows(0)("DienThoai") Is DBNull.Value Then
                    Me.txtTel.Text = dt.Rows(0)("DienThoai").ToString()
                Else
                    Me.txtTel.Text = ""
                End If
                If Not dt.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                    Me.txtDiachi.Text = dt.Rows(0)("DiaChiChiTiet").ToString()
                Else
                    Me.txtDiachi.Text = ""
                End If

                If Not dt.Rows(0)("NgheNghiep") Is DBNull.Value Then
                    Me.txtNghenghiep.Text = dt.Rows(0)("NgheNghiep").ToString()
                Else
                    Me.txtNghenghiep.Text = ""
                End If
                If Not dt.Rows(0)("GioiTinh") Is DBNull.Value Then
                    Me.txtGioitinh.Text = dt.Rows(0)("GioiTinh").ToString()
                End If
                If Not dt.Rows(0)("NgaySinh") Is DBNull.Value Then
                    Me.dtNgaySinh.DateTime = dt.Rows(0)("NgaySinh")
                Else
                    Me.dtNgaySinh.Text = ""
                End If
                If txtSophieu.Text <> "0" And txtSophieu.Text <> "" Then
                    Try
                        cmbdoi_tuong.EditValue = BusinessLogic.Data.GetDataset(String.Format("SELECT Doituong FROM PHIEUKHAMBENH WHERE SoPhieu='{0}'", txtSophieu.Text)).Tables(0).Rows(0)("Doituong")
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnKhamxong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKhamxong.Click
        Dim sql As String
        sql = String.Format("Update Chi_tiet_NEW set trangthai=1 WHERE RefNo=N'{0}' and LoaiDV in ({1})", Me.txtSophieuCT.Text.Trim, loai)
        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
            MsgBox("Phiếu hiện tại đã khám xong!")
        Else
            MessageBox.Show("Có lỗi khi cập nhật dữ liệu", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Close()
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim frm As New frmShowReport
        Dim _thutien As Boolean
        frm.Text = Me.Text
        frm.strBC = frmShowReport.TenBc.Phieudv

        If suaphieu = True Then
            frm.thutien = True
            _thutien = True
        Else
            frm.thutien = False
            _thutien = False
        End If
        If cmbloaixn.EditValue = "XNHH" Or cmbloaixn.EditValue = "XNNT" Then
            frm.Title = "KẾT QUẢ XÉT NGHIỆM"
        Else
            frm.Title = Me.Text
        End If
        frm.tuoi = txtThangTuoi.Text
        frm.IDchitiet = Me.txtSophieuCT.Text.Trim
        Dim dtb As DataTable = BusinessLogic.Data.GetDataset("BC_Canlamsang", Data.CommandType.StoredProcedure, New List(Of String) From {"IDsophieu", "thutien", "loai"}, New List(Of Object) From {Me.txtSophieuCT.Text.Trim, _thutien, Integer.Parse("0" + loai)}).Tables(0)
        frm.dtb = dtb
        frm.Show()
    End Sub

    Private Sub cmbphong_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbphong.EditValueChanged
        If cmbphong.EditValue <> "" Then
            Dim str As String = "Select Username from Nguoi_su_dung where maphong='" & cmbphong.EditValue & "'"
            Dim dts As New DataSet
            dts = BusinessLogic.Data.GetDataset(str, CommandType.Text, Nothing, Nothing)
            If dts.Tables(0).Rows.Count > 0 Then
                cmbbacsi.EditValue = dts.Tables(0).Rows(0)(0)
            Else
                cmbbacsi.EditValue = ""
            End If
        End If
    End Sub

    Private Sub cmbloaixn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbloaixn.EditValueChanged
        load_chitiet_xetnghiem()
        If suaphieu = False Then
            If cmbloaixn.EditValue = "XNHH_01" Or cmbloaixn.EditValue = "XNNT_01" Or cmbloaixn.EditValue = "CTM_01" Then
                Dim dt As DataTable = GridControl1.DataSource
                For Each dr As DataRow In dt.Rows
                    Masp = dr("Masp").ToString
                    Tensp = dr("Tensp").ToString
                    Dongia = dr("Dongia").ToString
                    LoaiDV = dr("Loai").ToString
                    NXN = dr("MaNhomXetnghiem").ToString
                    Maphong = dr("Maphong").ToString

                    'ktra va add row vào gridview1
                    If Kiemtramasp() = False Then
                        GridView1.AddNewRow()
                        GridView1.UpdateCurrentRow()
                        Dim n As Integer = GridView1.RowCount - 2
                        Dim row As DataRow
                        row = GridView1.GetDataRow(n)
                        row("Masp") = Masp
                        row("dongia") = Dongia
                        row("soluong") = 1
                        row("thanhtien") = Dongia
                        row("LoaiDV") = LoaiDV
                        row("NhomXetnghiem") = NXN
                        row("MaPhong") = Maphong
                    Else
                        MsgBox("Sản phẩm đã được chọn!", MsgBoxStyle.Critical, "Thông báo...")
                    End If
                    Me.GridView1.UpdateCurrentRow()
                    Dim d As Double = 0
                    Try
                        d = Double.Parse(dtvCTPXN.Table.Compute("SUM(Thanhtien)", "").ToString())
                    Catch ex As Exception
                    End Try
                    txtAmount.Text = d.ToString("#,###")
                Next
            End If
        End If
    End Sub

    Private Sub load_chitiet_xetnghiem()
        Dim strSQL As String = ""
        strSQL &= "Select CAST(0 as bit) as Chon,s.Masp,s.Tensp,s.Mota,s.Dongia,s.Manhom as Loai,s.MaNhomXetnghiem,s.Maphong from San_Pham s Where 1=1 "
        If CmbManhom.EditValue <> "" Then
            strSQL &= " And Manhom=N'" & CmbManhom.EditValue & "'"
        End If
        If cmbloaixn.EditValue <> "" Then
            strSQL &= " And MaNhomXetnghiem=N'" & cmbloaixn.EditValue & "'"
        End If
        strSQL &= " And Manhom not in (N'10',N'19') Order by s.STT"
        Me.GridControl1.DataSource = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
    End Sub

    Private Function Kiemtramasp() As Boolean
        Dim bo As Boolean = False
        For i As Int16 = 0 To Me.GridView1.RowCount - 2
            Dim row As DataRow
            row = Me.GridView1.GetDataRow(i)
            If (row("Masp") = Masp) Then
                bo = True
                Exit For
            End If
        Next
        Return bo
    End Function

    Private Sub RepositoryItemCheckEdit1_EditValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        Dim i As Integer
        Dim dr As DataRow
        i = GridView2.FocusedRowHandle
        If i >= 0 Then
            dr = GridView2.GetDataRow(i)
            Masp = dr("Masp").ToString
            Tensp = dr("Tensp").ToString
            Dongia = dr("Dongia").ToString
            LoaiDV = dr("Loai").ToString
            NXN = dr("MaNhomXetnghiem").ToString
            Maphong = dr("Maphong").ToString
        End If
        'ktra va add row vào gridview1
        If Kiemtramasp() = False Then
            GridView1.AddNewRow()
            GridView1.UpdateCurrentRow()
            Dim n As Integer = GridView1.RowCount - 2
            Dim row As DataRow
            row = GridView1.GetDataRow(n)
            row("Masp") = Masp
            row("dongia") = Dongia
            row("soluong") = 1
            row("thanhtien") = Dongia
            row("LoaiDV") = LoaiDV
            row("NhomXetnghiem") = NXN
            row("MaPhong") = Maphong
        Else
            MsgBox("Sản phẩm đã được chọn!", MsgBoxStyle.Critical, "Thông báo...")
        End If
        Me.GridView1.UpdateCurrentRow()
        Dim d As Double = 0
        Try
            d = Double.Parse(dtvCTPXN.Table.Compute("SUM(Thanhtien)", "").ToString())
        Catch ex As Exception
        End Try
        txtAmount.Text = d.ToString("#,###")
    End Sub

    Private Sub RepositoryItemTextEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim i As Integer
        Dim dr As DataRow
        i = GridView1.FocusedRowHandle
        dr = GridView1.GetDataRow(i)
        If e.KeyCode = Keys.F1 Then
            dr("Ghichu") = "Không thấy hình ảnh tổn thương"
        ElseIf e.KeyCode = Keys.F2 Then
            dr("Ghichu") = "Hình ảnh tim, phổi bình thường"
            'bổ sung sau
        End If
    End Sub

    Private Sub btnxuatvt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxuatvt.Click
        If khamxong() = 1 Then
            MsgBox("Đã khám xong!")
            Return
        Else
        End If
        Dim frmdichvu As New frmPhieuxuatvtyt
        If xuatvtyt() = 1 Then
            Dim sql As String = "select ID from tb_xuatnhapnoibo where Sophieudv='" & txtSophieuCT.Text & "'"
            Dim dtk As New DataTable
            dtk = BusinessLogic.Data.GetDataset(sql).Tables(0)
            If dtk.Rows.Count > 0 Then
                frmdichvu.IDPhieuxuat = dtk.Rows(0)(0)
            End If
        Else
            frmdichvu.cmbMakh.EditValue = cmbMaBN.EditValue
            frmdichvu.TxtSophieukham.Text = txtSophieu.Text
            frmdichvu.CmbKhohang.EditValue = cmbphong.EditValue
            frmdichvu.txtsophieudv.Text = txtSophieuCT.Text
            frmdichvu.StartPosition = FormStartPosition.CenterScreen
            frmdichvu.blnType = True
        End If
        Me.AddOwnedForm(frmdichvu)
        frmdichvu.Show()
    End Sub

    Private Function khamxong() As Int16
        Dim sql As String = "select Trangthai from Chi_tiet_NEW where RefNo ='" & txtSophieuCT.Text & "'"
        Dim dtk As New DataTable
        dtk = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dtk.Rows(0)(0) = 1 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Function xuatvtyt() As Int16
        Dim sql As String = "select * from tb_xuatnhapnoibo where Sophieudv='" & txtSophieuCT.Text & "'"
        Dim dtk As New DataTable
        dtk = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dtk.Rows.Count > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub btnMauphieu_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnMauphieu.ButtonClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                Dim url_file As Object = ""
                Dim dt As DataTable = New DataTable()
                dt = BusinessLogic.Data.GetDataset("select MaSp,Manhom,MaNhomXetnghiem,Url_File,Isnull(SoAnhInPhieu,0) as SoAnh from San_Pham where MaSp='" & dr("Masp") & "'").Tables(0)
                If dt.Rows.Count > 0 Then
                    'If dt.Rows(0)("Manhom").ToString() = "13" And CType(dt.Rows(0)("MaNhomXetnghiem"), String) <> "XNCTB" Then
                    '    MessageBox.Show("Chức năng không dùng cho các dịch vụ xét nghiệm!")
                    '    Return
                    'End If
                    url_file = dt.Rows(0)("Url_File").ToString()
                    'If url_file = "" Then
                    '    MessageBox.Show("Đường dẫn mẫu phiếu chưa có...!")
                    '    Return
                    'End If
                    Dim frm As New DocBrowser
                    frm.Name = "DocBrowser"
                    frm.fileName = url_file
                    frm.cmbMabn.EditValue = cmbMaBN.EditValue
                    frm.txtSophieukham.EditValue = txtSophieu.EditValue
                    frm.txtSophieudv.EditValue = txtSophieuCT.EditValue
                    frm.cmbLoaiDV.EditValue = CType(dt.Rows(0)("MaNhomXetnghiem"), String)
                    frm.cmbDichvu.EditValue = CType(dt.Rows(0)("MaSp"), String)
                    frm.txtChandoan.EditValue = Rich_lamsang.Text
                    frm.txtSoAnh.Text = dt.Rows(0)("SoAnh").ToString()
                    frm.type = dt.Rows(0)("Manhom").ToString()
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Dim frm1 As Form
                    For Each frm1 In Me.OwnedForms
                        If (frm1.Name = frm.Name) Then
                            frm1.Activate()
                            Exit Sub
                        End If
                    Next
                    Me.AddOwnedForm(frm)
                    frm.Show()
                End If
            End If
        End If
    End Sub

    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        Dim i As Int16
        If e.KeyCode = Keys.Delete Then
            If blnsp = True Then
                Dim dr As DataRowView
                dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
                If Not dr Is Nothing Then dr.Delete()
                If IDPhieuxuat = 0 Then
                    For i = 0 To Me.GridView1.RowCount - 2
                        dr = Me.GridView1.GetRow(i)
                        dr("STT") = i + 1
                    Next
                End If
                GridView1.UpdateCurrentRow()
                Dim d As Double = 0
                Try
                    d = Double.Parse(dtvCTPXN.Table.Compute("SUM(Thanhtien)", "").ToString())
                Catch ex As Exception
                End Try
                txtAmount.Text = d.ToString("#,###")
            End If
        End If
    End Sub

    Private Sub cmbMaBN_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbMaBN.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim frm As New FRM_DM_BENHNHAN
            frm.cmbDoiTuong.EditValue = 1
            frm.cmbGioi_Tinh.EditValue = 1
            frm.dtNgaySinh.DateTime = New DateTime(1990, 1, 1)
            frm.dtGT_THE_TU.DateTime = New DateTime(Year(DateTime.Now), 1, 1)
            frm.dtGT_THE_DEN.DateTime = New DateTime(Year(DateTime.Now), 12, 31)
            frm.passData_ = New FRM_DM_BENHNHAN.PassDatabn(AddressOf GetFirstValue)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show()
        End If
    End Sub

    Private Sub GetFirstValue(ByVal MaBN As String)
        Load_ComboBox("Select mabn[Mã],hotenbn[Bệnh nhân],Dienthoai[Điện thoại] from hosobn", cmbMaBN, CNNQLPHONGKHAM)
        Me.cmbMaBN.EditValue = MaBN
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            cmbbacsi.Enabled = True
            GridView1.Columns.ColumnByFieldName("Bacsi").Visible = False
            cmbbacsi.EditValue = clsLoginObj.strUsername
        Else
            cmbbacsi.Enabled = False
            GridView1.Columns.ColumnByFieldName("Bacsi").Visible = True
        End If
    End Sub

    Private Function Get_Maphong(ByVal Masp As String) As DataTable
        Dim dt As DataTable = BusinessLogic.Data.GetDataset("select Manhom,MaNhomXetnghiem,Maphong from San_Pham Where Masp='" & Masp & "'").Tables(0)
        Return dt
    End Function

    Private Sub GridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            If Not View.GetRowCellValue(e.RowHandle(), "trangthai") Is DBNull.Value Then
                Dim bl As Boolean = View.GetRowCellValue(e.RowHandle(), "trangthai")
                If bl = True Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.SeaShell
                End If
            End If
        End If
    End Sub
    Private Sub RepositoryItemButtonEdit_XoaDichVu_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit_XoaDichVu.ButtonClick
        Dim i As Int16
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then dr.Delete()
        If IDPhieuxuat = 0 Then
            For i = 0 To Me.GridView1.RowCount - 2
                dr = Me.GridView1.GetRow(i)
                dr("STT") = i + 1
            Next
        End If
        GridView1.UpdateCurrentRow()
        Dim d As Double = 0
        Try
            d = Double.Parse(dtvCTPXN.Table.Compute("SUM(Thanhtien)", "").ToString())
        Catch ex As Exception
        End Try
        txtAmount.Text = d.ToString("#,###")
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        suaphieu = False
        Me.txtSophieuCT.Text = GetNextRefNo(Reftype)
        Try
            Dim txt As Object
            For Each txt In GroupControl1.Controls
                If txt.Name.Substring(0, 3).ToUpper = "TXT" Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception

        End Try
        addNew()
        Me.DtpNgaylap.EditValue = NgayGioServer()
        Me.cmbnlap.EditValue = clsLoginObj.strUsername
        Me.cmbMaBN.EditValue = ""
        Me.Grb.Enabled = True
        Me.Panel_Button.Enabled = True
        Me.Panel_KetLuan.Enabled = True
    End Sub

    Private Sub dtNgaySinh_EditValueChanged(sender As Object, e As EventArgs) Handles dtNgaySinh.EditValueChanged
        Try
            Dim ThangTuoi As String = MdlCommon.TinhThangTuoi(dtNgaySinh.DateTime.Date, 3)
            txtThangTuoi.Text = ThangTuoi
        Catch ex As Exception
            txtThangTuoi.Text = ""
        End Try
    End Sub

    Private Sub FRM_KECANLAMSANG_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isCloseForm = True
    End Sub

    Private Sub CmbManhom_EditValueChanged(sender As Object, e As EventArgs) Handles CmbManhom.EditValueChanged
        Load_ComboBox("SELECT MaNhom[Mã],TenNhom[Loại XN] From Tb_NhomXetNghiem where Active=1 And Id_NhomSp=N'" & CmbManhom.EditValue & "' order by ID ", Me.cmbloaixn, CNNQLPHONGKHAM)
        load_chitiet_xetnghiem()
    End Sub

    Private Sub CmbManhom_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbManhom.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            cmbloaixn.EditValue = ""
        End If
    End Sub

    Private Sub cmbloaixn_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbloaixn.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            CmbManhom.EditValue = ""
        End If
    End Sub
End Class