Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class frmPhieuXN
    Inherits frmBase 'System.Windows.Forms.Form
#Region "khai báo biến"
    Public blnDelete As Boolean
    Public dtvCTPXN As DataView
    Public dtbCTPXN As DataTable
    Public blnType As Boolean = True
    Public blnLoaiphieu As Boolean = False
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

    Public Thebaohiem As String
    Public Bacsy As String
    Public lanchup As Int32 = 11
    Public Nguoilap As String
    Public Sophieukham As String
    Public Chandoanlansang As String
    Public Sophieuchup As String
    Public Sodonthuoc As Int64
    Public Hoten As String
    Public Gioitinh As String
    Public Nghenghiep As String
    Public namsinh As Date
    Public Diachi As String
    Public Tel As String
    Public MABN As String
    Public Loai As Boolean
    Public Loaixuat As Boolean = False
    Public dtthuoc As DataTable
    Private dts As New DataSet
    Public kieuthu As Int16 = 0
    Private _Masp As String = ""
    Public Is_Edit As Boolean = False
    Public Is_BHYT As Boolean = False

    Friend WithEvents colck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnInphieuthu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox_BN As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label27 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSearchLookUpEdit_LoXuat As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grb As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel_Button As Panel
    Friend WithEvents rad_A4 As RadioButton
    Friend WithEvents rad_A5 As RadioButton
    Friend WithEvents rad_K80 As RadioButton
    Friend WithEvents rad_K57 As RadioButton
    Friend WithEvents dtNgaySinh As DevExpress.XtraEditors.DateEdit
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtGhichu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtSophieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSotienVnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbNVBH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CmbKhohang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTygia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DtpNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbLoai_xuat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTensp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoluong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDongia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThanhtien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdDinh_khoan As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBoxoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTenBN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNghenghiep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDiachi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGioitinh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSophieukham As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbMakh As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Losanpham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuXN))
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGhichu = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSophieu = New DevExpress.XtraEditors.TextEdit()
        Me.txtSotienVnd = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbNVBH = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbKhohang = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTygia = New DevExpress.XtraEditors.TextEdit()
        Me.DtpNgay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbLoai_xuat = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSophieukham = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.grdDinh_khoan = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colTensp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Losanpham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoluong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDongia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThanhtien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSearchLookUpEdit_LoXuat = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnBoxoa = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTenBN = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMakh = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNghenghiep = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiachi = New DevExpress.XtraEditors.TextEdit()
        Me.txtTel = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtGioitinh = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtNgaySinh = New DevExpress.XtraEditors.DateEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnInphieuthu = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox_BN = New DevExpress.XtraEditors.GroupControl()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Grb = New DevExpress.XtraEditors.GroupControl()
        Me.rad_A4 = New System.Windows.Forms.RadioButton()
        Me.rad_A5 = New System.Windows.Forms.RadioButton()
        Me.rad_K80 = New System.Windows.Forms.RadioButton()
        Me.rad_K57 = New System.Windows.Forms.RadioButton()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSotienVnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTygia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSophieukham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit_LoXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenBN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMakh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNghenghiep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiachi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGioitinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaySinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupBox_BN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_BN.SuspendLayout()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(340, 10)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 18
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(444, 10)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 19
        Me.btnSua.Text = "&Sửa"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(236, 10)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 16
        Me.btnIn.Text = "&In phiếu"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(548, 10)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 20
        Me.btnXoa.Text = "&Xoá"
        '
        'txtGhichu
        '
        Me.txtGhichu.EditValue = ""
        Me.txtGhichu.Location = New System.Drawing.Point(78, 98)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Properties.AutoHeight = False
        Me.txtGhichu.Size = New System.Drawing.Size(366, 22)
        Me.txtGhichu.TabIndex = 11
        Me.txtGhichu.Tag = "GhiChu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(11, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Ghi Chú"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(895, 10)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 22
        Me.btnThoat.Text = "&Thoát"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(59, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 14)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Kho hàng"
        '
        'txtSophieu
        '
        Me.txtSophieu.EditValue = "0"
        Me.txtSophieu.Enabled = False
        Me.txtSophieu.Location = New System.Drawing.Point(343, 50)
        Me.txtSophieu.Name = "txtSophieu"
        Me.txtSophieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSophieu.Properties.Appearance.Options.UseFont = True
        Me.txtSophieu.Properties.AutoHeight = False
        Me.txtSophieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSophieu.Size = New System.Drawing.Size(101, 22)
        Me.txtSophieu.TabIndex = 16
        Me.txtSophieu.Tag = "Sophieu"
        '
        'txtSotienVnd
        '
        Me.txtSotienVnd.EditValue = "0"
        Me.txtSotienVnd.Enabled = False
        Me.txtSotienVnd.Location = New System.Drawing.Point(78, 122)
        Me.txtSotienVnd.Name = "txtSotienVnd"
        Me.txtSotienVnd.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSotienVnd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotienVnd.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSotienVnd.Properties.Appearance.Options.UseBackColor = True
        Me.txtSotienVnd.Properties.Appearance.Options.UseFont = True
        Me.txtSotienVnd.Properties.Appearance.Options.UseForeColor = True
        Me.txtSotienVnd.Properties.AutoHeight = False
        Me.txtSotienVnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSotienVnd.Size = New System.Drawing.Size(123, 22)
        Me.txtSotienVnd.TabIndex = 24
        Me.txtSotienVnd.Tag = "Quydoi"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(12, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Loại xuất"
        '
        'CmbNVBH
        '
        Me.CmbNVBH.Location = New System.Drawing.Point(78, 26)
        Me.CmbNVBH.Name = "CmbNVBH"
        Me.CmbNVBH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmbNVBH.Properties.Appearance.Options.UseFont = True
        Me.CmbNVBH.Properties.AutoHeight = False
        Me.CmbNVBH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbNVBH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Tên nhân viên", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbNVBH.Properties.NullText = ""
        Me.CmbNVBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbNVBH.Size = New System.Drawing.Size(188, 22)
        Me.CmbNVBH.TabIndex = 3
        Me.CmbNVBH.Tag = "Nguoinhap"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(12, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Bác sĩ"
        '
        'CmbKhohang
        '
        Me.CmbKhohang.AllowDrop = True
        Me.CmbKhohang.Location = New System.Drawing.Point(78, 74)
        Me.CmbKhohang.Name = "CmbKhohang"
        Me.CmbKhohang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmbKhohang.Properties.Appearance.Options.UseFont = True
        Me.CmbKhohang.Properties.AutoHeight = False
        Me.CmbKhohang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbKhohang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã kho", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbKhohang.Properties.NullText = ""
        Me.CmbKhohang.Properties.PopupWidth = 200
        Me.CmbKhohang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbKhohang.Properties.ValidateOnEnterKey = True
        Me.CmbKhohang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbKhohang.Size = New System.Drawing.Size(188, 22)
        Me.CmbKhohang.TabIndex = 5
        Me.CmbKhohang.Tag = "makho"
        '
        'txtTygia
        '
        Me.txtTygia.EditValue = "1"
        Me.txtTygia.Location = New System.Drawing.Point(206, 122)
        Me.txtTygia.Name = "txtTygia"
        Me.txtTygia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTygia.Properties.Appearance.Options.UseFont = True
        Me.txtTygia.Properties.AutoHeight = False
        Me.txtTygia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTygia.Size = New System.Drawing.Size(21, 22)
        Me.txtTygia.TabIndex = 8
        Me.txtTygia.Tag = "Tygia"
        Me.txtTygia.Visible = False
        '
        'DtpNgay
        '
        Me.DtpNgay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.DtpNgay.Location = New System.Drawing.Point(343, 74)
        Me.DtpNgay.Name = "DtpNgay"
        Me.DtpNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DtpNgay.Properties.Appearance.Options.UseFont = True
        Me.DtpNgay.Properties.Appearance.Options.UseTextOptions = True
        Me.DtpNgay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DtpNgay.Properties.AutoHeight = False
        Me.DtpNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtpNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DtpNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DtpNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.DtpNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DtpNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.DtpNgay.Size = New System.Drawing.Size(101, 22)
        Me.DtpNgay.TabIndex = 7
        Me.DtpNgay.Tag = "Ngay"
        '
        'cmbLoai_xuat
        '
        Me.cmbLoai_xuat.Location = New System.Drawing.Point(78, 50)
        Me.cmbLoai_xuat.Name = "cmbLoai_xuat"
        Me.cmbLoai_xuat.Properties.AutoHeight = False
        Me.cmbLoai_xuat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLoai_xuat.Properties.NullText = ""
        Me.cmbLoai_xuat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbLoai_xuat.Size = New System.Drawing.Size(188, 22)
        Me.cmbLoai_xuat.TabIndex = 4
        Me.cmbLoai_xuat.Tag = "MaXN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(11, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Tổng tiền"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(276, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Ngày lập"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(276, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Số HS"
        '
        'TxtSophieukham
        '
        Me.TxtSophieukham.EditValue = "0"
        Me.TxtSophieukham.Location = New System.Drawing.Point(343, 26)
        Me.TxtSophieukham.Name = "TxtSophieukham"
        Me.TxtSophieukham.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtSophieukham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtSophieukham.Properties.Appearance.Options.UseBackColor = True
        Me.TxtSophieukham.Properties.Appearance.Options.UseFont = True
        Me.TxtSophieukham.Properties.AutoHeight = False
        Me.TxtSophieukham.Properties.ReadOnly = True
        Me.TxtSophieukham.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSophieukham.Size = New System.Drawing.Size(101, 22)
        Me.TxtSophieukham.TabIndex = 16
        Me.TxtSophieukham.Tag = "SOPHIEUKHAM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(276, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Số phiếu"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(28, 10)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "&Nhập mới"
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(132, 10)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 15
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'grdDinh_khoan
        '
        Me.grdDinh_khoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDinh_khoan.Location = New System.Drawing.Point(1, 187)
        Me.grdDinh_khoan.MainView = Me.GridView1
        Me.grdDinh_khoan.Name = "grdDinh_khoan"
        Me.grdDinh_khoan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemSearchLookUpEdit_LoXuat})
        Me.grdDinh_khoan.Size = New System.Drawing.Size(979, 333)
        Me.grdDinh_khoan.TabIndex = 10
        Me.grdDinh_khoan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT, Me.colMasp, Me.colTensp, Me.DVT, Me.Losanpham, Me.colSoluong, Me.colDongia, Me.colck, Me.colThanhtien, Me.GridColumn1, Me.GridColumn2, Me.GridColumn7})
        Me.GridView1.GridControl = Me.grdDinh_khoan
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSTT
        '
        Me.colSTT.Caption = "Stt"
        Me.colSTT.FieldName = "stt"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.OptionsColumn.AllowEdit = False
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 0
        Me.colSTT.Width = 41
        '
        'colMasp
        '
        Me.colMasp.Caption = "Mã "
        Me.colMasp.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colMasp.FieldName = "masp"
        Me.colMasp.Name = "colMasp"
        Me.colMasp.Width = 78
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.CaseSensitiveSearch = True
        Me.RepositoryItemLookUpEdit1.DisplayMember = "masp"
        Me.RepositoryItemLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.PopupWidth = 435
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "masp"
        '
        'colTensp
        '
        Me.colTensp.Caption = "Tên sản phẩm"
        Me.colTensp.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colTensp.FieldName = "masp"
        Me.colTensp.Name = "colTensp"
        Me.colTensp.Visible = True
        Me.colTensp.VisibleIndex = 1
        Me.colTensp.Width = 244
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("masp", "Mã", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tensp", "Tên sản phẩm", 280, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("toncuoi", "Tồn kho", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "tensp"
        Me.RepositoryItemLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.PopupWidth = 435
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "masp"
        '
        'DVT
        '
        Me.DVT.Caption = "ĐVT"
        Me.DVT.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.DVT.FieldName = "masp"
        Me.DVT.Name = "DVT"
        Me.DVT.OptionsColumn.AllowEdit = False
        Me.DVT.Visible = True
        Me.DVT.VisibleIndex = 2
        Me.DVT.Width = 48
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "donvt"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ValueMember = "masp"
        '
        'Losanpham
        '
        Me.Losanpham.Caption = "Số lô"
        Me.Losanpham.FieldName = "solo"
        Me.Losanpham.Name = "Losanpham"
        Me.Losanpham.Width = 65
        '
        'colSoluong
        '
        Me.colSoluong.Caption = "Số lượng"
        Me.colSoluong.FieldName = "soluong"
        Me.colSoluong.Name = "colSoluong"
        Me.colSoluong.Visible = True
        Me.colSoluong.VisibleIndex = 3
        Me.colSoluong.Width = 80
        '
        'colDongia
        '
        Me.colDongia.Caption = "Đơn giá"
        Me.colDongia.DisplayFormat.FormatString = "###,###.##"
        Me.colDongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDongia.FieldName = "dongia"
        Me.colDongia.Name = "colDongia"
        Me.colDongia.OptionsColumn.AllowEdit = False
        Me.colDongia.OptionsColumn.AllowFocus = False
        Me.colDongia.Visible = True
        Me.colDongia.VisibleIndex = 4
        Me.colDongia.Width = 85
        '
        'colck
        '
        Me.colck.Caption = "Chiết khấu(%)"
        Me.colck.DisplayFormat.FormatString = "###,###.##"
        Me.colck.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colck.FieldName = "Trietkhau"
        Me.colck.Name = "colck"
        Me.colck.Width = 94
        '
        'colThanhtien
        '
        Me.colThanhtien.Caption = "Thành tiền"
        Me.colThanhtien.DisplayFormat.FormatString = "###,###.##"
        Me.colThanhtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colThanhtien.FieldName = "thanhtien"
        Me.colThanhtien.Name = "colThanhtien"
        Me.colThanhtien.OptionsColumn.AllowEdit = False
        Me.colThanhtien.Visible = True
        Me.colThanhtien.VisibleIndex = 5
        Me.colThanhtien.Width = 79
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Liều dùng"
        Me.GridColumn1.FieldName = "lieudung"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 128
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Chọn lô xuất"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemSearchLookUpEdit_LoXuat
        Me.GridColumn2.FieldName = "solo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 138
        '
        'RepositoryItemSearchLookUpEdit_LoXuat
        '
        Me.RepositoryItemSearchLookUpEdit_LoXuat.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit_LoXuat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit_LoXuat.DisplayMember = "Solo"
        Me.RepositoryItemSearchLookUpEdit_LoXuat.Name = "RepositoryItemSearchLookUpEdit_LoXuat"
        Me.RepositoryItemSearchLookUpEdit_LoXuat.NullText = "..."
        Me.RepositoryItemSearchLookUpEdit_LoXuat.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.RepositoryItemSearchLookUpEdit_LoXuat.ValueMember = "Solo"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 400
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Số lô nhập"
        Me.GridColumn3.FieldName = "Solo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 150
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Hạn sử dụng"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "HanSD"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 131
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tồn kho"
        Me.GridColumn5.FieldName = "toncuoi"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 100
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Mã Sp"
        Me.GridColumn6.FieldName = "Masp"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Số lô"
        Me.GridColumn7.FieldName = "solo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 118
        '
        'btnBoxoa
        '
        Me.btnBoxoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnBoxoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBoxoa.Appearance.Options.UseFont = True
        Me.btnBoxoa.Appearance.Options.UseForeColor = True
        Me.btnBoxoa.Location = New System.Drawing.Point(548, 10)
        Me.btnBoxoa.Name = "btnBoxoa"
        Me.btnBoxoa.Size = New System.Drawing.Size(75, 25)
        Me.btnBoxoa.TabIndex = 21
        Me.btnBoxoa.Text = "Bỏ xóa"
        '
        'txtTenBN
        '
        Me.txtTenBN.EditValue = ""
        Me.txtTenBN.Location = New System.Drawing.Point(92, 50)
        Me.txtTenBN.Name = "txtTenBN"
        Me.txtTenBN.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTenBN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTenBN.Properties.Appearance.Options.UseBackColor = True
        Me.txtTenBN.Properties.Appearance.Options.UseFont = True
        Me.txtTenBN.Properties.AutoHeight = False
        Me.txtTenBN.Properties.ReadOnly = True
        Me.txtTenBN.Size = New System.Drawing.Size(246, 22)
        Me.txtTenBN.TabIndex = 28
        Me.txtTenBN.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã BN"
        '
        'cmbMakh
        '
        Me.cmbMakh.AllowDrop = True
        Me.cmbMakh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbMakh.Location = New System.Drawing.Point(92, 26)
        Me.cmbMakh.Name = "cmbMakh"
        Me.cmbMakh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbMakh.Properties.Appearance.Options.UseFont = True
        Me.cmbMakh.Properties.AutoHeight = False
        Me.cmbMakh.Properties.AutoSearchColumnIndex = 1
        Me.cmbMakh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmbMakh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbMakh.Properties.NullText = ""
        Me.cmbMakh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbMakh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMakh.Size = New System.Drawing.Size(246, 22)
        Me.cmbMakh.TabIndex = 1
        Me.cmbMakh.Tag = "Makh"
        '
        'txtNghenghiep
        '
        Me.txtNghenghiep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNghenghiep.EditValue = ""
        Me.txtNghenghiep.Location = New System.Drawing.Point(92, 122)
        Me.txtNghenghiep.Name = "txtNghenghiep"
        Me.txtNghenghiep.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNghenghiep.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNghenghiep.Properties.Appearance.Options.UseBackColor = True
        Me.txtNghenghiep.Properties.Appearance.Options.UseFont = True
        Me.txtNghenghiep.Properties.AutoHeight = False
        Me.txtNghenghiep.Properties.ReadOnly = True
        Me.txtNghenghiep.Size = New System.Drawing.Size(423, 22)
        Me.txtNghenghiep.TabIndex = 31
        Me.txtNghenghiep.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Họ và tên"
        '
        'txtDiachi
        '
        Me.txtDiachi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiachi.EditValue = ""
        Me.txtDiachi.Location = New System.Drawing.Point(92, 74)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDiachi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDiachi.Properties.Appearance.Options.UseBackColor = True
        Me.txtDiachi.Properties.Appearance.Options.UseFont = True
        Me.txtDiachi.Properties.AutoHeight = False
        Me.txtDiachi.Properties.ReadOnly = True
        Me.txtDiachi.Size = New System.Drawing.Size(423, 22)
        Me.txtDiachi.TabIndex = 29
        Me.txtDiachi.Tag = ""
        '
        'txtTel
        '
        Me.txtTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTel.EditValue = ""
        Me.txtTel.Location = New System.Drawing.Point(92, 98)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTel.Properties.Appearance.Options.UseBackColor = True
        Me.txtTel.Properties.Appearance.Options.UseFont = True
        Me.txtTel.Properties.AutoHeight = False
        Me.txtTel.Properties.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(423, 22)
        Me.txtTel.TabIndex = 30
        Me.txtTel.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Địa chỉ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Điện thoại"
        '
        'txtGioitinh
        '
        Me.txtGioitinh.EditValue = ""
        Me.txtGioitinh.Location = New System.Drawing.Point(412, 50)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtGioitinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtGioitinh.Properties.Appearance.Options.UseBackColor = True
        Me.txtGioitinh.Properties.Appearance.Options.UseFont = True
        Me.txtGioitinh.Properties.AutoHeight = False
        Me.txtGioitinh.Properties.ReadOnly = True
        Me.txtGioitinh.Size = New System.Drawing.Size(103, 22)
        Me.txtGioitinh.TabIndex = 33
        Me.txtGioitinh.Tag = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(344, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Ngày sinh"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(344, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 16)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Giới tính"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(8, 125)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 16)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Nghề nghiệp"
        '
        'dtNgaySinh
        '
        Me.dtNgaySinh.EditValue = ""
        Me.dtNgaySinh.Location = New System.Drawing.Point(412, 26)
        Me.dtNgaySinh.Name = "dtNgaySinh"
        Me.dtNgaySinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtNgaySinh.Properties.Appearance.Options.UseFont = True
        Me.dtNgaySinh.Properties.AutoHeight = False
        Me.dtNgaySinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtNgaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtNgaySinh.Size = New System.Drawing.Size(103, 22)
        Me.dtNgaySinh.TabIndex = 118
        Me.dtNgaySinh.Tag = ""
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(981, 33)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "PHIẾU XUẤT BÁN THUỐC"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInphieuthu
        '
        Me.btnInphieuthu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnInphieuthu.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInphieuthu.Appearance.Options.UseFont = True
        Me.btnInphieuthu.Appearance.Options.UseForeColor = True
        Me.btnInphieuthu.Location = New System.Drawing.Point(652, 10)
        Me.btnInphieuthu.Name = "btnInphieuthu"
        Me.btnInphieuthu.Size = New System.Drawing.Size(75, 25)
        Me.btnInphieuthu.TabIndex = 74
        Me.btnInphieuthu.Text = "&Thu dịch vụ"
        '
        'GroupBox_BN
        '
        Me.GroupBox_BN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_BN.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupBox_BN.Appearance.Options.UseBackColor = True
        Me.GroupBox_BN.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupBox_BN.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox_BN.AppearanceCaption.Options.UseFont = True
        Me.GroupBox_BN.AppearanceCaption.Options.UseForeColor = True
        Me.GroupBox_BN.Controls.Add(Me.Label27)
        Me.GroupBox_BN.Controls.Add(Me.txtNghenghiep)
        Me.GroupBox_BN.Controls.Add(Me.txtTel)
        Me.GroupBox_BN.Controls.Add(Me.Label1)
        Me.GroupBox_BN.Controls.Add(Me.Label14)
        Me.GroupBox_BN.Controls.Add(Me.txtTenBN)
        Me.GroupBox_BN.Controls.Add(Me.txtGioitinh)
        Me.GroupBox_BN.Controls.Add(Me.Label13)
        Me.GroupBox_BN.Controls.Add(Me.Label17)
        Me.GroupBox_BN.Controls.Add(Me.Label18)
        Me.GroupBox_BN.Controls.Add(Me.txtDiachi)
        Me.GroupBox_BN.Controls.Add(Me.cmbMakh)
        Me.GroupBox_BN.Controls.Add(Me.Label20)
        Me.GroupBox_BN.Controls.Add(Me.Label2)
        Me.GroupBox_BN.Controls.Add(Me.dtNgaySinh)
        Me.GroupBox_BN.Location = New System.Drawing.Point(456, 33)
        Me.GroupBox_BN.Name = "GroupBox_BN"
        Me.GroupBox_BN.Size = New System.Drawing.Size(525, 152)
        Me.GroupBox_BN.TabIndex = 75
        Me.GroupBox_BN.Text = "Thông tin người bệnh"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(70, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 14)
        Me.Label27.TabIndex = 119
        Me.Label27.Text = "*"
        '
        'Grb
        '
        Me.Grb.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Grb.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Grb.AppearanceCaption.Options.UseFont = True
        Me.Grb.AppearanceCaption.Options.UseForeColor = True
        Me.Grb.Controls.Add(Me.rad_A4)
        Me.Grb.Controls.Add(Me.rad_A5)
        Me.Grb.Controls.Add(Me.rad_K80)
        Me.Grb.Controls.Add(Me.rad_K57)
        Me.Grb.Controls.Add(Me.Label11)
        Me.Grb.Controls.Add(Me.txtSotienVnd)
        Me.Grb.Controls.Add(Me.txtSophieu)
        Me.Grb.Controls.Add(Me.txtTygia)
        Me.Grb.Controls.Add(Me.Label9)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Controls.Add(Me.DtpNgay)
        Me.Grb.Controls.Add(Me.txtGhichu)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Controls.Add(Me.CmbNVBH)
        Me.Grb.Controls.Add(Me.Label8)
        Me.Grb.Controls.Add(Me.cmbLoai_xuat)
        Me.Grb.Controls.Add(Me.CmbKhohang)
        Me.Grb.Controls.Add(Me.Label16)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.Label12)
        Me.Grb.Controls.Add(Me.TxtSophieukham)
        Me.Grb.Location = New System.Drawing.Point(1, 33)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(453, 152)
        Me.Grb.TabIndex = 76
        Me.Grb.Text = "Thông tin phiếu"
        '
        'rad_A4
        '
        Me.rad_A4.AutoSize = True
        Me.rad_A4.Location = New System.Drawing.Point(404, 125)
        Me.rad_A4.Name = "rad_A4"
        Me.rad_A4.Size = New System.Drawing.Size(38, 17)
        Me.rad_A4.TabIndex = 124
        Me.rad_A4.TabStop = True
        Me.rad_A4.Text = "A4"
        Me.rad_A4.UseVisualStyleBackColor = True
        '
        'rad_A5
        '
        Me.rad_A5.AutoSize = True
        Me.rad_A5.Location = New System.Drawing.Point(354, 125)
        Me.rad_A5.Name = "rad_A5"
        Me.rad_A5.Size = New System.Drawing.Size(38, 17)
        Me.rad_A5.TabIndex = 123
        Me.rad_A5.TabStop = True
        Me.rad_A5.Text = "A5"
        Me.rad_A5.UseVisualStyleBackColor = True
        '
        'rad_K80
        '
        Me.rad_K80.AutoSize = True
        Me.rad_K80.Location = New System.Drawing.Point(299, 125)
        Me.rad_K80.Name = "rad_K80"
        Me.rad_K80.Size = New System.Drawing.Size(43, 17)
        Me.rad_K80.TabIndex = 122
        Me.rad_K80.TabStop = True
        Me.rad_K80.Text = "K80"
        Me.rad_K80.UseVisualStyleBackColor = True
        '
        'rad_K57
        '
        Me.rad_K57.AutoSize = True
        Me.rad_K57.Location = New System.Drawing.Point(244, 125)
        Me.rad_K57.Name = "rad_K57"
        Me.rad_K57.Size = New System.Drawing.Size(43, 17)
        Me.rad_K57.TabIndex = 121
        Me.rad_K57.TabStop = True
        Me.rad_K57.Text = "K57"
        Me.rad_K57.UseVisualStyleBackColor = True
        '
        'Panel_Button
        '
        Me.Panel_Button.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnBoxoa)
        Me.Panel_Button.Controls.Add(Me.btnInphieuthu)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnIn)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Location = New System.Drawing.Point(1, 526)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(980, 47)
        Me.Panel_Button.TabIndex = 77
        '
        'frmPhieuXN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(981, 573)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.Grb)
        Me.Controls.Add(Me.GroupBox_BN)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.grdDinh_khoan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPhieuXN"
        Me.Text = "PHIẾU XUẤT THUỐC"
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSotienVnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTygia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSophieukham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit_LoXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenBN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMakh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNghenghiep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiachi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGioitinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaySinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupBox_BN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_BN.ResumeLayout(False)
        Me.GroupBox_BN.PerformLayout()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPhieuXN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.DtpNgay.DateTime = NgayGioServer().Date
        'Me.DtpNgay.Enabled = False
        Load_Data()
        Form_Initial()
        Ctrl_QuyenForm(Me)
        If Sophieukham <> 0 Then
            Me.cmbMakh.EditValue = MABN
            TxtSophieukham.Text = Sophieukham
            'CmbKhohang.Enabled = False
            cmbLoai_xuat.Enabled = False
            cmbMakh.Enabled = False
            myaddrow()
        End If

        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnBoxoa.Visible = False
        If IDPhieuxuat <> 0 Then
            'Me.btnThem.Enabled = False
            Me.btnSua.Enabled = True
            Me.btnXoa.Enabled = True
            Me.btnIn.Enabled = True
            'Me.btnThoat.Enabled = True
            'Me.DtpNgay.Enabled = True
            'Me.grdDinh_khoan.Enabled = False
            Me.Grb.Enabled = True
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Them)
            Me.btnXoa.Enabled = True
            Me.GroupBox_BN.Enabled = True
        End If
        If blnDelete = True Then
            Me.btnXoa.Enabled = False
            Me.btnBoxoa.Visible = True
            Me.btnBoxoa.Enabled = True
            Me.btnXoa.Visible = False
        End If
        'Me.GridView1.Columns.Remove(Losanpham)
        stype = True
        Me.Label21.Enabled = True
        Me.Panel_Button.Enabled = True
        Me.rad_A5.Checked = True
    End Sub

    Private Sub myaddrow()
        If Not obj Is Nothing Then
            Dim item As Donthuoc
            Dim row As DataRow
            For Each item In obj
                If Not item.Mathuoc Is Nothing Then
                    Try
                        Dim n As Int16 = Me.GridView1.RowCount - 1
                        Me.GridView1.AddNewRow()
                        Me.GridView1.UpdateCurrentRow()
                        row = Me.GridView1.GetDataRow(n)
                        row("Masp") = item.Mathuoc
                        row("Soluong") = item.Soluong
                        row("Lieudung") = item.Lieudung
                        row("Solo") = ""
                        row("STT") = n + 1
                        Dim dt As New DataTable
                        dt = BusinessLogic.Data.GetDataset("SELECT Dongia FROM San_Pham  WHERE MaSp='" & item.Mathuoc & "'").Tables(0)
                        If dt.Rows.Count > 0 Then
                            If Not dt.Rows(0)("Dongia") Is DBNull.Value Then
                                row("dongia") = dt.Rows(0)("Dongia")
                            End If
                            row("THANHTIEN") = row("Soluong") * row("dongia")
                        End If
                    Catch ex As Exception

                    End Try
                    Me.GridView1.UpdateCurrentRow()
                    TongUSD()
                End If
            Next
        End If
    End Sub

    Private Sub Form_Initial()
        Dim clsObjPxn As New clsXNKho
        Dim dtbxn As New DataTable
        Load_ComboBox("select mabn[Mã],hotenbn[Họ tên] from hosobn ", Me.cmbMakh, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaXn,TenLoai From DM_Xuat_Nhap WHERE Loai= 0 ", Me.cmbLoai_xuat, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang order by Tenkho", Me.CmbKhohang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.CmbNVBH, CNNQLPHONGKHAM, True)
        Me.CmbNVBH.EditValue = clsLoginObj.strUsername
        Me.CmbNVBH.Enabled = False
        Dim dt As New DataTable
        If Is_Edit = False Then
            dt = BusinessLogic.Data.GetDataset("proc_GetListkedon", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
        Else
            dt = BusinessLogic.Data.GetDataset("proc_GetHangHoa_TraKho", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieu"}, New List(Of Object) From {Integer.Parse("0" + txtSophieu.EditValue)}).Tables(0)
        End If
        Me.RepositoryItemLookUpEdit1.DataSource = dt
        Me.RepositoryItemLookUpEdit2.DataSource = dt
        Me.RepositoryItemLookUpEdit3.DataSource = dt

        If IDPhieuxuat <> 0 Then
            CTPXFill()
        Else
            CTPXFill()
            Me.txtSophieu.Text = clsObjPxn.Lay_So_phieu(blnLoaiphieu)
        End If
    End Sub

    Private Sub Load_Data()
        Dim dtbPXN As New DataTable
        Dim dtbtk As New DataTable
        Dim dtbkho As New DataTable
        Dim strSql As String
        strSql = "SELECT * FROM Phieu_Xuat_Nhap WHERE IDPhieuXn=" & IDPhieuxuat & " "
        dtbPXN = BusinessLogic.Data.GetDataset(strSql).Tables(0)
        If dtbPXN.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbPXN.Rows(0)
            blnLoaiphieu = row("Loaiphieu")
            Me.cmbMakh.EditValue = row(Me.cmbMakh.Tag)
            Me.CmbNVBH.EditValue = row(Me.CmbNVBH.Tag)
            Me.CmbKhohang.EditValue = row(Me.CmbKhohang.Tag)
            Me.cmbLoai_xuat.EditValue = row(Me.cmbLoai_xuat.Tag)
            Me.txtGhichu.Text = row(Me.txtGhichu.Tag)
            Me.txtSophieu.Text = row(Me.txtSophieu.Tag)
            Me.TxtSophieukham.Text = row(Me.TxtSophieukham.Tag)
            Me.txtSotienVnd.Text = row(Me.txtSotienVnd.Tag)
            Me.txtTygia.Text = row(Me.txtTygia.Tag)
            Me.DtpNgay.DateTime = row(Me.DtpNgay.Tag)
            If blnLoaiphieu = False Then
                If Me.cmbLoai_xuat.EditValue = "XTD" Then
                    Me.Text = "Phiếu xuất theo đơn"
                    Me.Label12.Text = "Loại xuất"
                ElseIf Me.cmbLoai_xuat.EditValue = "XB" Then
                    Me.Text = "Phiếu xuất bán"
                    Me.Label12.Text = "Loại xuất"
                Else
                    Me.Text = "Phiếu xuất hủy"
                    Me.Label12.Text = "Loại xuất"
                End If
            Else
                Me.Text = "Phiếu nhập thuốc"
                Me.Label12.Text = "Loại nhập"
            End If
            CTPXFill()
        End If
        If IDPhieuxuat = 0 Then
            Me.btnXoa.Enabled = False
        End If
    End Sub

    Private Sub CTPXFill()
        Dim i As Int16 = 1
        Dim strSql As String
        dtvCTPXN = Nothing
        If IDPhieuxuat <> 0 Then
            strSql = String.Format("SELECT [id],[idsophieu],[masp],[soluong],[dongia],[Trietkhau],[thanhtien],[stt],[lieudung],[hansd],[solo] FROM Chi_Tiet_PXN WHERE IDSophieu ={0} order by id ", IDPhieuxuat)
        Else
            strSql = "SELECT [id],[idsophieu],[masp],[soluong],[dongia],[Trietkhau],[thanhtien],[stt],[lieudung],[hansd],[solo] FROM Chi_Tiet_PXN WHERE IDSophieu =-9999 order by id "
        End If
        dtb_PreCTPXN = BusinessLogic.Data.GetDataset(strSql).Tables(0)
        Me.grdDinh_khoan.DataSource = dtb_PreCTPXN
    End Sub

    Private Function CheckValidation() As Boolean
        Dim clsObjFrmXN As New clsFrmPhieuXNKedonthuoc
        Return clsObjFrmXN.FrmCheckValide(Me)
    End Function

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim i As Int16
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString)
        Try
            If e.Column.FieldName = "masp" Then
                row("dongia") = chech_gia(row("masp"))
                _Masp = row("Masp")
                If Kiemtramasp() = True Then
                    MsgBox("Sản phẩm đã được chọn ở 1 dòng khác!", MsgBoxStyle.Critical, "THÔNG BÁO...")
                End If
            End If
        Catch ex As Exception

        End Try

        Try
            If (e.Column.FieldName = "soluong") Or (e.Column.FieldName = "dongia") Or (e.Column.FieldName = "Trietkhau") Then
                If (IsNumeric(row("Soluong")) And IsNumeric(row("Dongia")) And IsNumeric(row("Dongia"))) Then
                    row("Thanhtien") = row("Soluong") * row("Dongia") - row("Soluong") * row("Dongia") * row("Trietkhau") / 100
                End If
            End If
        Catch ex As Exception
        End Try
        'Load lô sản phẩm
        Try
            Dim dt As DataTable
            If Is_Edit = False Then
                dt = BusinessLogic.Data.GetDataset("proc_GetList_TonThuoc_SoLo", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho", "Masp"}, New List(Of Object) From {CmbKhohang.EditValue, row("Masp")}).Tables(0)
            Else
                dt = BusinessLogic.Data.GetDataset("proc_GetList_TonThuoc_SoLo_TraKho", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieu", "masp"}, New List(Of Object) From {Integer.Parse("0" + txtSophieu.EditValue), row("Masp")}).Tables(0)
            End If
            RepositoryItemSearchLookUpEdit_LoXuat.DataSource = dt
        Catch ex As Exception

        End Try

        'Tính lại tong tien
        Try
            For i = 0 To Me.GridView1.RowCount - 2
                If (IsNumeric(row("Soluong")) And IsNumeric(row("Dongia")) And IsNumeric(row("Dongia"))) Then
                    row("Thanhtien") = row("Soluong") * row("Dongia") - row("Soluong") * row("Dongia") * row("Trietkhau") / 100
                End If
            Next
        Catch ex As Exception
        End Try
        Me.GridView1.UpdateCurrentRow()
        TongUSD()
    End Sub

    Private Function chech_gia(ByVal Masp As String) As Double
        Dim Obj As New Object
        Dim dtbtonkho As DataTable
        dtbtonkho = BusinessLogic.Data.GetDataset("Select Dongia From San_Pham WHERE Masp = '" & Masp & "'").Tables(0)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("Dongia")
        Else
            MsgBox("Sản phẩm này hiện không còn tồn kho", MsgBoxStyle.Critical, "THÔNG BÁO...")
        End If
    End Function

    Private Sub TongUSD()
        Dim objclsPXN As New clsFrmPhieuXNKedonthuoc
        objclsPXN.GetUSDTotal(Me)
        objclsPXN = Nothing
    End Sub

    Public Sub FormClear()
        Dim objclsPXN As New clsFrmPhieuXNKedonthuoc
        objclsPXN.frmXuatnhapClear(Me)
        objclsPXN = Nothing
    End Sub

    Private Function Check_san_pham(ByVal Masp As String, ByVal rowid As Integer) As Boolean
        Dim Obj As New Object
        Dim int_i As Integer
        Obj = Masp
        If Me.GridView1.RowCount = 0 Then
            Return True
        End If
        For int_i = 0 To dtvCTPXN.Count
            If dtvCTPXN(int_i)("masp") = Masp And int_i <> rowid Then
                Return True
            Else
                Return True
            End If
        Next
    End Function

#Region "Xu ly cac su kien cua dieu khien"
    Private Sub cmbMakh_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If foundClick = False Then
            cmbMakh.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub
    Private Sub cmbLoai_xuat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLoai_xuat.GotFocus
        If foundClick = False Then
            sender.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub
    Private Sub CmbKhohang_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbKhohang.GotFocus
        If foundClick = False Then
            CmbKhohang.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub
    Private Sub cmbDonvi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbKhohang.Click, cmbLoai_xuat.Click, CmbNVBH.Click
        If foundClick = False Then
            sender.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub
    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.grdDinh_khoan.Enabled = True
        Me.GroupBox_BN.Enabled = True
        Me.txtGhichu.Enabled = True
        Me.TxtSophieukham.Enabled = False
        Me.btnIn.Enabled = False
        Me.CmbNVBH.Enabled = False
        blnType = False
        StypeSUA = True
        Me.Panel_Button.Enabled = True
    End Sub
    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Me.btnThem.Enabled = False
        Me.Panel_Button.Enabled = True
    End Sub

#End Region

#Region "Nhom cac su kien Button"
    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim ketnoi As String
        ketnoi = CNNQLPHONGKHAM.ConnectionString
        Dim strSQL As String = ""
        If CheckValidation() = True Then
            Dim dr As DataRowView
            Dim int_i As Int16
            Dim Soluong As Double = 0
            If Me.GridView1.RowCount > 0 Then
                For int_i = 0 To Me.GridView1.RowCount - 2
                    If int_i >= 0 Then
                        dr = Me.GridView1.GetRow(int_i)
                        If IsDBNull(dr("Masp")) Then
                            MsgBox("Bạn chưa chọn sản phẩm.")
                            Me.grdDinh_khoan.Focus()
                            Exit Sub
                        End If
                        If dr("Soluong") = 0 Then
                            MsgBox("Bạn chưa nhập số lượng.")
                            Me.grdDinh_khoan.Focus()
                            Exit Sub
                        End If
                        If dr("Soluong") < 0 Then
                            MsgBox("Bạn không thể chọn số lượng âm.")
                            Me.grdDinh_khoan.Focus()
                            Exit Sub
                        End If
                    End If
                Next
            End If
            Dim dt As DataTable
            If Is_Edit = False Then
                dt = BusinessLogic.Data.GetDataset("proc_GetListkedon", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
            Else
                dt = BusinessLogic.Data.GetDataset("proc_GetHangHoa_TraKho", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieu"}, New List(Of Object) From {Integer.Parse("0" + txtSophieu.EditValue)}).Tables(0)
            End If
            Dim dt2 As DataTable = DirectCast(grdDinh_khoan.DataSource, DataTable)
            For Each r As DataRow In dt2.Rows
                If r.RowState <> DataRowState.Deleted Then
                    Dim dr2() As DataRow = dt.Select(String.Format("[Masp]='{0}'", r("Masp")))
                    If (dr2 Is Nothing OrElse dr2.Length = 0) Then
                        MessageBox.Show("Mã thuốc/vật tư vừa kê hết!:" + r("Masp"), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        'r("Soluong") = 0
                        Return
                    Else
                        Dim r2 As DataRow = dr2(0)
                        If (r("Soluong") > r2("toncuoi")) Then
                            MessageBox.Show("Mã thuốc/vật tư không đủ xuất theo số lượng kê!:" + r("Masp"), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            ' r("Soluong") = r2("toncuoi")
                            Return
                        End If
                    End If
                End If
            Next
            Dim loaiXN As String = cmbLoai_xuat.EditValue
            If blnType = True Then
                INSERT()
                If Is_BHYT = False And loaiXN <> "XH" And loaiXN <> "XTH" Then
                    AddNewEntry()
                End If
                SaveEntry()
                'If cmbLoai_xuat.EditValue <> "XH" Then
                '    phieuthu()
                'End If
                updateTTDON()
            Else
                UPDATA()
                If Is_BHYT = False And loaiXN <> "XH" And loaiXN <> "XTH" Then
                    AddNewEntry()
                End If
                SaveEntry()
                MsgBox("Bạn cần sửa phiếu thu nếu có thay đổi về tổng tiền", MsgBoxStyle.Information)
            End If
            CTPXFill()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Me.btnIn.Enabled = True
            If sky = False Then
                Me.btnThem.Enabled = True
                Me.btnIn.Enabled = True

                Me.btnThoat.Enabled = True
                Me.btnSua.Enabled = True
                Me.btnXoa.Enabled = True
            Else
                Me.btnSua.Enabled = False
                Me.btnXoa.Enabled = False
            End If
        End If
        If StypeSUA = True Then
            Me.btnThem.Enabled = False
        Else
            Me.btnThem.Enabled = True
        End If
        Me.btnInphieuthu.Enabled = True
        Me.btnIn.Focus()
        Me.Panel_Button.Enabled = True
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub updateTTDON()
        Dim str As String = "update tb_kedonthuoc set i_status=1 where Sophieu='" & Sodonthuoc & "'"
        Command_Exc(str, CNNQLPHONGKHAM)
    End Sub

    Private Sub phieuthu()
        Dim clsobj As New clsThuchi
        Dim dtb As New DataTable
        Dim sql As String = ""
        sql = "Select * from Ton_Quy WHERE MaQuy = '1TM' AND Convert(char(10),Ngay,101) ='" & Format(Me.DtpNgay.DateTime, "MM/dd/yyyy") & "'"
        dtb = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dtb.Rows.Count > 0 Then
        Else
            clsobj.TinhTonQuy(CNNQLPHONGKHAM)
        End If
        Dim int_SophieuMoi As Int64 = 0
        Dim IndexIDSophieu As Int64 = 0
        Dim sophieu_ As Integer = clsobj.Lay_So_phieu(True)
        If clsobj.ThemPhieuTC(Double.Parse(Chuanhoa(Me.txtSotienVnd.Text)), Double.Parse(Chuanhoa(Me.txtSotienVnd.Text)), clsobj.Lay_So_phieu(True), 1, 0, "TTHUOC", NgayGioServer().Date, "1TM", cmbMakh.EditValue, cmbMakh.EditValue, 0, 1, Double.Parse(Chuanhoa(Me.txtSotienVnd.Text)), Chuanhoa(Me.txtSotienVnd.Text), "Phiếu thu tiền thuốc số phiếu xuất:" & Me.txtSophieu.Text & "", 0, 0, clsLoginObj.strUsername, clsLoginObj.strUsername, TxtSophieukham.Text, 0, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM) = True Then
        End If
        If IndexIDSophieu > 0 Then
            dtb = BusinessLogic.Data.GetDatatable("select Sophieu from phieu_thu_chi where IDSophieu='" & IndexIDSophieu & "'")
            If dtb.Rows.Count > 0 Then
                sophieu_ = Integer.Parse("0" + dtb.Rows(0)("Sophieu").ToString())
                Command_Exc("update phieu_thu_chi set sophieuxuat=" & Long.Parse(txtSophieu.Text) & " where Sophieu=" & sophieu_ & " and Loaiphieu=1", CNNQLPHONGKHAM)
            End If
        End If

    End Sub

    Private Sub frmPhieuXN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Int16
        If e.KeyCode = Keys.Delete Then
            'If StypeSUA = False Then
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
            TongUSD()
            'End If
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim i As Integer = 0
        Dim dtbtk As New DataTable
        Dim dtbxn As New DataTable
        Dim dtbkho As New DataTable
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        FormClear()
        dtbkho = Load_DataTable("select makho from kho_hang where makho='KT'", CNNQLPHONGKHAM)
        Me.CmbKhohang.EditValue = dtbkho.Rows(0)("makho")
        frmState = False
        Me.DtpNgay.DateTime = NgayGioServer().Date
        'Me.DtpNgay.Enabled = False
        Me.txtSophieu.Enabled = False
        Me.txtSotienVnd.Enabled = False
        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnIn.Enabled = False
        Me.CmbNVBH.Enabled = False
        Me.CmbKhohang.Enabled = False
        Me.GroupBox_BN.Enabled = True
        CTPXFill()
        k = 0
        blnType = True
        Me.Panel_Button.Enabled = True
    End Sub
#End Region

    Private Sub INSERT()
        Dim Bolean As Boolean = False
        Dim blkhuyenmai As Boolean = False
        Me.GridView1.UpdateCurrentRow()
        TongUSD()
        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        txtSophieu.Text = clsObjPxn.Lay_So_phieu(False)
        If clsObjPxn.ThemPhieu(Me.txtSophieu.Text, blnLoaiphieu, Me.cmbMakh.EditValue, "0", Chuanhoa(Me.txtSotienVnd.Text), Chuanhoa(Me.txtTygia.Text), 0, 0, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, Chuanhoa(Me.txtSotienVnd.Text), Chuanhoa(Me.TxtSophieukham.Text), int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM) = 0 Then
            IDPhieuxuat = int_IDSophieu
            dtbCTXN = BusinessLogic.Data.GetDataset("Select Sophieu From Phieu_Xuat_Nhap Where IDPhieuXn=" & int_IDSophieu & "").Tables(0)
            If dtbCTXN.Rows.Count > 0 Then
                txtSophieu.Text = dtbCTXN.Rows(0)("Sophieu").ToString()
                Me.btnCap_nhat.Enabled = False
            Else
                MsgBox("Có lỗi xảy ra...!", MsgBoxStyle.Information, "Thông báo...")
                Return
            End If
        Else
            MsgBox("Có lỗi xảy ra...!", MsgBoxStyle.Information, "Thông báo...")
            Return
        End If
    End Sub

    Private Sub UPDATA()
        Me.GridView1.UpdateCurrentRow()
        TongUSD()
        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        Dim fVAT As Double
        If clsObjPxn.ThemPhieu(IDPhieuxuat, blnLoaiphieu, Me.cmbMakh.EditValue, "0", Chuanhoa(txtSotienVnd.Text), Chuanhoa(Me.txtTygia.Text), fVAT, 1, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, Chuanhoa(txtSotienVnd.Text), Chuanhoa(Me.TxtSophieukham.Text), int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM) = 0 Then
            IDPhieuxuat = int_IDSophieu
            Me.btnCap_nhat.Enabled = False
        End If
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle)
        Dim row1 As DataRow
        row1 = Me.GridView1.GetDataRow(e.RowHandle - 1)
        'row("vat") = 0
        row("thanhtien") = 0
        row("soluong") = 0
        row("dongia") = 0
        row("Trietkhau") = 0
        row("lieudung") = ""
        Try
            row("hansd") = ""
        Catch ex As Exception

        End Try

        row("solo") = ""
        If row.Table.Rows.Count = 0 Then
            row("id") = 0
            row("stt") = 1
        Else
            row("id") = row.Table.Rows.Count + 1
            row("stt") = row.Table.Rows.Count + 1
        End If
        'Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có thật sự muốn xoá phiếu này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strSQL, sql As String
            Dim Styl As Boolean = False
            strSQL = "UPDATE Phieu_Xuat_Nhap SET Huy=1 WHERE IDPhieuXn=" & IDPhieuxuat & ""
            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                Dim dtphieu As New DataTable
                dtphieu = BusinessLogic.Data.GetDataset("Select sophieu From phieu_xuat_nhap where IDphieuxn =" & IDPhieuxuat & "").Tables(0)
                sql = String.Format("UPDATE chi_tiet_new SET Huy=1 WHERE RefNo=N'{0}'", dtphieu.Rows(0)(0).ToString())
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                    MsgBox("Bạn ghi hiện tại đã được xóa. Bạn cần xóa phiếu thu tiền nếu đã thu tiền...!", MsgBoxStyle.Information, "Thông báo...")
                    Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
                    If sky = False Then
                        Me.btnThem.Enabled = False
                        Me.btnIn.Enabled = True
                        Me.btnThoat.Enabled = True
                    Else
                        Me.btnSua.Enabled = False
                        Me.btnXoa.Enabled = False
                    End If
                Else
                    MsgBox("Xóa thất bại...!", MsgBoxStyle.Information, "Thông báo...")
                End If
            End If
        End If
    End Sub

    'Lay du lieu tu form khac ve
    Private Sub GetFirstValue(ByVal _Solo As String, ByVal _Soluong As String, ByVal _Dongia As String)
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        dr("Solo") = _Solo
        dr("Dongia") = _Dongia
        dr("Soluong") = _Soluong
        dr("Thanhtien") = _Soluong * _Dongia
        GridView1.UpdateCurrentRow()
        TongUSD()
    End Sub

    Private Sub GridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If e.KeyCode = Keys.Enter Then
            If Not dr Is Nothing Then
                sp_xuat = Nothing
                Dim dtb As DataView
                Dim i As Int16 = 0
                dtb = Me.GridView1.DataSource()
                Dim datarow As DataRowView
                ReDim sp_xuat(Me.GridView1.RowCount - 2)
                For Each datarow In dtb
                    Try
                        If i < Me.GridView1.RowCount - 2 Then
                            If Not IsDBNull(datarow("Masp")) Then
                                sp_xuat(i) = New Sanphamxuat
                                sp_xuat(i).Masp = datarow("Masp")
                                sp_xuat(i).Solo = datarow("Solo")
                                sp_xuat(i).Soluong = datarow("Soluong")
                                i = i + 1
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                Next
                Dim frm As New FRM_XUATTHEOLO
                frm.Masp = dr("Masp")
                frm.Ngay = Me.DtpNgay.DateTime
                frm.Makho = Me.CmbKhohang.EditValue
                frm.StartPosition = FormStartPosition.CenterScreen
                frm._passData = New FRM_XUATTHEOLO.PassData(AddressOf GetFirstValue)
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
        Else
        End If
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim tienbangchu As String = ""
        Try
            tienbangchu = DoiSo(Replace(txtSotienVnd.Text, ",", ""))
        Catch ex As Exception

        End Try

        Dim frm As New frmShowReport
        frm.tienbangchu = tienbangchu
        frm.tuoi = dtNgaySinh.DateTime.ToString("dd/MM/yyyy")
        frm.gioitinh = txtGioitinh.Text
        If Me.Name = "frmPhieuXNHC" Then
            frm.strBC = frmShowReport.TenBc.PhieuxuatHC
        Else
            frm.strBC = frmShowReport.TenBc.PhieuXN
        End If
        If Me.CmbKhohang.EditValue = "KHC" Then
            frm.Title = "PHIẾU XUẤT HÓA CHẤT"
            If txtSophieu.EditValue <> "" Then
                Try
                    IDPhieuxuat = BusinessLogic.Data.GetDataset("Select IDPhieuXn From Phieu_Xuat_Nhap WHERE Sophieu=" & txtSophieu.EditValue).Tables(0).Rows(0)("IDPhieuXn")
                Catch ex As Exception
                    IDPhieuxuat = 0
                End Try
            End If
        ElseIf Me.CmbKhohang.EditValue = "KVTYT" Then
            frm.Title = "PHIẾU XUẤT VTYT"
            If txtSophieu.EditValue <> "" Then
                Try
                    IDPhieuxuat = BusinessLogic.Data.GetDataset("Select IDPhieuXn From Phieu_Xuat_Nhap WHERE Sophieu=" & txtSophieu.EditValue).Tables(0).Rows(0)("IDPhieuXn")
                Catch ex As Exception
                    IDPhieuxuat = 0
                End Try
            End If
        Else
            frm.Title = "PHIẾU XUẤT BÁN THUỐC"
            If txtSophieu.EditValue <> "" Then
                Try
                    IDPhieuxuat = BusinessLogic.Data.GetDataset("Select IDPhieuXn From Phieu_Xuat_Nhap WHERE (MaXN='XTD' or MaXN='XB') and Sophieu=" & txtSophieu.EditValue).Tables(0).Rows(0)("IDPhieuXn")
                Catch ex As Exception
                    IDPhieuxuat = 0
                End Try
            End If
        End If
        frm.dtb = BusinessLogic.Data.GetDataset("XuatThuoc_ChiTiet", Data.CommandType.StoredProcedure, New List(Of String) From {"IDPhieuxuat"}, New List(Of Object) From {IDPhieuxuat}).Tables(0)
        If rad_K57.Checked Then
            frm.khoIn = "K57"
        ElseIf rad_K80.Checked Then
            frm.khoIn = "K80"
        ElseIf rad_A5.Checked Then
            frm.khoIn = "A5"
        ElseIf rad_A4.Checked Then
            frm.khoIn = "A4"
        Else
            frm.khoIn = "A5"
        End If
        frm.IDPhieuTC = IDPhieuxuat
        frm.Show()
    End Sub

    Private Sub txtGhichu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGhichu.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnCap_nhat.Focus()
        End If
    End Sub

    Private Sub CmbKhohang_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbKhohang.KeyUp
        If e.KeyCode = Keys.F2 Or e.KeyCode = Keys.Delete Then
            Me.CmbKhohang.EditValue = ""
        End If
    End Sub

    Private Sub DtpNgay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpNgay.LostFocus
        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dtb = BusinessLogic.Data.GetDataset("Select * From ket_chuyen", CommandType.Text, Nothing, Nothing).Tables(0)
        ngayketchuyen = dtb.Rows(0)("ngayketchuyen")
        If Me.DtpNgay.Text = "" Then
            MsgBox("Chú ý! Bạn chưa chọn ngày")
            Me.DtpNgay.DateTime = NgayGioServer().Date
        End If
        If Me.DtpNgay.DateTime.Date > NgayGioServer().Date Then
            MsgBox("Chú ý! Bạn chọn đã chọn ngày lớn hơn ngày hiện tại")
            Me.DtpNgay.DateTime = NgayGioServer().Date
        End If
        If Me.DtpNgay.DateTime.Date < ngayketchuyen.Date Then
            MsgBox("Chú ý! Bạn chọn ngày nhỏ hơn ngày kết chuyển")
            Me.DtpNgay.DateTime = ngayketchuyen.Date
        End If

    End Sub

    Private Sub btnBoxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoxoa.Click
        If MsgBox("Bạn có muốn phục hồi phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strSQL, sql As String
            Dim Styl As Boolean = False
            strSQL = "UPDATE Phieu_Xuat_Nhap SET Huy=0 WHERE IDPhieuXn=" & IDPhieuxuat & ""
            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                Dim dtphieu As New DataTable
                dtphieu = BusinessLogic.Data.GetDataset("select sophieu from phieu_xuat_nhap where IDphieuxn =" & IDPhieuxuat & "").Tables(0)
                sql = "UPDATE chi_tiet_new SET Huy=0 WHERE refno=N'" & dtphieu.Rows(0)(0) & "'"
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                    MsgBox("Phiếu hiện tại đã được phục hồi!", MsgBoxStyle.Information, "Thông báo...")
                    Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
                    If sky = False Then
                        Me.btnThem.Enabled = False
                        Me.btnIn.Enabled = True
                        Me.btnThoat.Enabled = True
                    Else
                        Me.btnSua.Enabled = False
                        Me.btnXoa.Enabled = False
                    End If
                End If
            End If
        End If
        Me.Panel_Button.Enabled = True
    End Sub

    Private Sub cmbMakh_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMakh.EditValueChanged
        Dim dtbbenhnhan, dtdonvi As New DataTable
        Dim strSQL_BN, strSQL_DV As String
        strSQL_DV = String.Format("SELECT MADV,TENDV,DIACHI,TEL FROM DONVI WHERE MADV=N'{0}'", Me.cmbMakh.EditValue)
        strSQL_BN = "SELECT MaBN,TenBN,HoTenBN,DiaChiChiTiet,CASE GioiTinh WHEN 1 THEN N'Nam'ELSE N'Nữ' END as GioiTinh,NgaySinh,d2.ten as NgheNghiep,"
        strSQL_BN &= "DienThoai,GhiChu FROM HOSOBN b LEFT JOIN DMCHUNG d2 ON d2.ma=b.nghenghiep WHERE MABN =N'" & Me.cmbMakh.EditValue & "'"
        If Me.cmbMakh.EditValue <> Nothing Then
            dtbbenhnhan = BusinessLogic.Data.GetDataset(strSQL_BN).Tables(0)
            dtdonvi = BusinessLogic.Data.GetDataset(strSQL_DV).Tables(0)
            If dtbbenhnhan.Rows.Count > 0 Then
                Try
                    If Not dtbbenhnhan.Rows(0)("HoTenBN") Is DBNull.Value Then
                        Me.txtTenBN.Text = dtbbenhnhan.Rows(0)("HoTenBN").ToString()
                    Else
                        Me.txtTenBN.Text = ""
                    End If

                    If Not dtbbenhnhan.Rows(0)("DienThoai") Is DBNull.Value Then
                        Me.txtTel.Text = dtbbenhnhan.Rows(0)("DienThoai").ToString()
                    Else
                        Me.txtTel.Text = ""
                    End If

                    If Not dtbbenhnhan.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                        Me.txtDiachi.Text = dtbbenhnhan.Rows(0)("DiaChiChiTiet")
                    Else
                        Me.txtDiachi.Text = ""
                    End If

                    If Not dtbbenhnhan.Rows(0)("NgaySinh") Is DBNull.Value Then
                        Me.dtNgaySinh.DateTime = dtbbenhnhan.Rows(0)("NgaySinh")
                    Else
                        dtNgaySinh.Text = ""
                    End If

                    If Not dtbbenhnhan.Rows(0)("NgheNghiep") Is DBNull.Value Then
                        Me.txtNghenghiep.Text = dtbbenhnhan.Rows(0)("NgheNghiep").ToString()
                    Else
                        Me.txtNghenghiep.Text = ""
                    End If

                    If Not dtbbenhnhan.Rows(0)("GioiTinh") Is DBNull.Value Then
                        Me.txtGioitinh.Text = dtbbenhnhan.Rows(0)("GioiTinh").ToString()
                    Else
                        Me.txtGioitinh.Text = ""
                    End If
                Catch ex As Exception

                End Try
            Else
                Try
                    Me.txtTenBN.Text = ""
                    Me.txtTel.Text = ""
                    Me.txtDiachi.Text = ""
                    Me.dtNgaySinh.DateTime = NgayGioServer()
                    Me.txtNghenghiep.Text = ""
                    Me.txtGioitinh.Text = ""
                    Me.txtTenBN.Text = dtdonvi.Rows(0)("TENDV").ToString()
                    Me.txtTel.Text = dtdonvi.Rows(0)("TEL").ToString()
                    Me.txtDiachi.Text = dtdonvi.Rows(0)("diachi").ToString()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub AddNewEntry()
        Dim dts As New DataTable
        Dim dtk As New DataTable
        dts = grdDinh_khoan.DataSource
        Dim dr As DataRow
        Dim sql As String = ""
        sql = String.Format("Select kieuthu From chi_tiet_new where RefNo=N'{0}'", Me.txtSophieu.Text)
        dtk = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dtk.Rows.Count > 0 Then
            kieuthu = dtk.Rows(0)("kieuthu")
        End If
        Dim is_ThanhToan As Boolean = IsThanhToan(txtSophieu.Text)
        sql = String.Format("Delete from chi_tiet_new where RefNo=N'{0}'", Me.txtSophieu.Text)
        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
            For Each dr In dts.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    If blnType Then
                        sql = String.Format("Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu, kieuthu,DuyetBH,ChapNhanThanhToan,thanhtoan,thutien,maphong,chietkhau)")
                        sql &= "Values(N'" & TxtSophieukham.Text & "',N'" & dr("Masp") & "','" & dr("Soluong") & "','" & dr("Dongia") & "','" & dr("Thanhtien") & "','" & dr("stt") & "',N'" & cmbMakh.EditValue.ToString() & "',"
                        sql &= "'" & DtpNgay.DateTime & "'," & Double.Parse("0" + Chuanhoa(txtSotienVnd.Text)) & ",N'',N'10',N'" & txtSophieu.Text & "',N'Xuất bán thuốc','" & kieuthu & "'," & IIf(Is_BHYT, 1, 0) & ",1,1,0,N'QLT'," & Double.Parse("0" + dr("Trietkhau")) & ")"
                    Else
                        If is_ThanhToan Then
                            sql = String.Format("Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo, Ghichu,kieuthu,DuyetBH,ChapNhanThanhToan,thanhtoan,thutien,maphong,chietkhau)")
                            sql &= "values(N'" & TxtSophieukham.Text & "',N'" & dr("Masp") & "','" & dr("Soluong") & "','" & dr("Dongia") & "','" & dr("Thanhtien") & "','" & dr("stt") & "',N'" & cmbMakh.EditValue.ToString() & "',"
                            sql &= "'" & DtpNgay.DateTime & "'," & Double.Parse("0" + Chuanhoa(txtSotienVnd.Text)) & ",N'',N'10',N'" & txtSophieu.Text & "',N'Xuất bán thuốc','" & kieuthu & "'," & IIf(Is_BHYT, 1, 0) & ",1,1,1,N'QLT'," & Double.Parse("0" + dr("Trietkhau")) & ")"
                        Else
                            sql = "Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo, Ghichu,kieuthu,DuyetBH,ChapNhanThanhToan,thanhtoan,thutien,maphong,chietkhau)"
                            sql &= "values(N'" & TxtSophieukham.Text & "',N'" & dr("Masp") & "','" & dr("Soluong") & "','" & dr("Dongia") & "','" & dr("Thanhtien") & "','" & dr("stt") & "',N'" & cmbMakh.EditValue.ToString() & "',"
                            sql &= "'" & DtpNgay.DateTime & "'," & Double.Parse("0" + Chuanhoa(txtSotienVnd.Text)) & ",N'',N'10',N'" & txtSophieu.Text & "',N'Xuất bán thuốc','" & kieuthu & "'," & IIf(Is_BHYT, 1, 0) & ",1,1,0,N'QLT'," & Double.Parse("0" + dr("Trietkhau")) & ")"
                        End If
                    End If
                    '=====
                    'sql = "Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,kieuthu,DuyetBH,ChapNhanThanhToan,thanhtoan,thutien,maphong,chietkhau)"
                    'sql &= "values(N'" & TxtSophieukham.Text & "',N'" & dr("Masp") & "','" & dr("Soluong") & "','" & dr("Dongia") & "','" & dr("Thanhtien") & "','" & dr("stt") & "',N'" & cmbMakh.EditValue.ToString() & "',"
                    'sql &= "'" & DtpNgay.DateTime & "'," & Double.Parse("0" + Chuanhoa(txtSotienVnd.Text)) & ",N'',N'10',N'" & txtSophieu.Text & "',N'Xuất bán thuốc','" & kieuthu & "'," & IIf(Is_BHYT, 1, 0) & ",1,1,1,N'QLT'," & Double.Parse("0" + dr("Trietkhau")) & ")"
                    Command_Exc(sql, CNNQLPHONGKHAM)
                End If
            Next
        End If
    End Sub
    Private Function IsThanhToan(refNo As String) As Boolean
        Try
            Dim sql As String = "Select Top 1 ISNULL(IDPhieuTC,0) AS IDPhieuTC From Chi_tiet_new Where refNo ='" & Me.txtSophieu.Text & "'"
            Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
            If dt.Rows(0)("IDPhieuTC") > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function IsXuatThuoc(ByVal sodonthuoc As String) As Boolean
        Dim sql As String = "SELECT i_status FROM dbo.Tb_KeDonThuoc WHERE Sophieukham='" & TxtSophieukham.Text.Trim & "'"
        Return False
    End Function

    Private Sub SaveEntry()
        Dim dt As New DataTable
        dt = grdDinh_khoan.DataSource
        If Not dt Is Nothing Then
            If Not dt.GetChanges(DataRowState.Modified) Is Nothing Then
                For Each row As DataRow In dt.GetChanges(DataRowState.Modified).Rows
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

    Private Sub UpdateEntry(ByVal row As DataRow)
        Dim sql As String = ""
        sql &= "Update Chi_tiet_pxn Set Stt='" & row("STT") & "',Masp='" & row("Masp") & "',soluong='" & row("soluong") & "',dongia='" & row("dongia") & "',"
        sql &= "thanhtien='" & row("thanhtien") & "',Trietkhau='" & row("Trietkhau") & "',hansd='" & row("hansd") & "',solo=N'" & row("solo") & "' Where ID='" & row("ID") & "'"
        BusinessLogic.Data.Update(sql)
    End Sub

    Private Sub DeleteEntry(ByVal row As DataRow)
        Dim sql As String
        sql = "Delete from Chi_tiet_pxn Where ID='" & row("ID", DataRowVersion.Original) & "'"
        BusinessLogic.Data.Delete(sql)
    End Sub

    Private Sub AddNewEntry(ByVal row As DataRow)
        Dim sql As String = ""
        Dim dt As New DataTable
        dt = BusinessLogic.Data.GetDataset("Select Idphieuxn From Phieu_Xuat_Nhap Where Loaiphieu=0 And Sophieu='" & txtSophieu.Text & "'").Tables(0)
        If dt.Rows.Count > 0 Then
            sql &= "Insert into Chi_tiet_pxn(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Trietkhau,Hansd,solo) "
            sql &= "Values (N'" & dt.Rows(0)("Idphieuxn") & "',N'" & row("Masp") & "','" & row("Soluong") & "','" & row("Dongia") & "',"
            sql &= "'" & row("Thanhtien") & "',N'" & row("STT") & "','" & row("Trietkhau") & "','" & row("hansd") & "','" & row("solo") & "')"
            BusinessLogic.Data.Insert(sql)
        End If
    End Sub

    Private Function phongthuoc() As String
        Dim dt As New DataTable
        Dim kq As String = ""
        dt = BusinessLogic.Data.GetDataset("Select top 1 maphong From phong_ban where loai=9").Tables(0)
        If dt.Rows.Count > 0 Then
            kq = dt.Rows(0)(0).ToString
        End If
        Return kq
    End Function

    Private Sub CmbKhohang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbKhohang.EditValueChanged
        Dim dt As New DataTable
        If Is_Edit = False Then
            dt = BusinessLogic.Data.GetDataset("proc_GetListkedon", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
        Else
            dt = BusinessLogic.Data.GetDataset("proc_GetHangHoa_TraKho", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieu"}, New List(Of Object) From {Integer.Parse("0" + txtSophieu.EditValue)}).Tables(0)
        End If
        Me.RepositoryItemLookUpEdit1.DataSource = dt
        Me.RepositoryItemLookUpEdit2.DataSource = dt
        Me.RepositoryItemLookUpEdit3.DataSource = dt
    End Sub

    Private Function Kiemtramasp() As Boolean
        Dim bo As Boolean = False
        For i As Int16 = 0 To Me.GridView1.RowCount - 2
            Dim row As DataRow
            row = Me.GridView1.GetDataRow(i)
            If (row("Masp") = _Masp) Then
                bo = True
                Exit For
            End If
        Next
        Return bo
    End Function
    Private Sub btnInphieuthu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInphieuthu.Click
        Dim frm As New FRM_ThanhToanNhanDan
        frm.Name = "FRM_Thutien"
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
        'Dim frm As New frmShowReport
        'Dim CatChuoi As String = ""
        'Dim CatChuoiVND As String
        'CatChuoiVND = Replace(Me.txtSotienVnd.Text, ",", "")
        'Dim arrCatChuoi(2) As String
        'Dim arrCatchuoiVND(2) As String
        'arrCatChuoi = Split(CatChuoi, ".", -1, CompareMethod.Text)
        'arrCatchuoiVND = Split(CatChuoiVND, ".", -1, CompareMethod.Text)
        'Dim dt_ As DataTable = BusinessLogic.Data.GetDataset("select IDSophieu from phieu_thu_chi where sophieuxuat=" & Long.Parse(txtSophieu.Text) & " and Loaiphieu=1").Tables(0)
        'If dt_.Rows.Count > 0 Then
        '    frm.IDPhieuTC = CStr(dt_.Rows(0)("IDSophieu").ToString())
        'Else
        '    frm.IDPhieuTC = 0
        'End If

        'If UBound(arrCatChuoi) > 0 Then
        '    If arrCatChuoi(1) = 0 Then
        '        frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & "Không" & Space(1) & "Cent"
        '    Else
        '        frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & Mid(DoiSo(arrCatChuoi(1)), 1, Len(DoiSo(arrCatChuoi(1))) - 4) & "Cent"
        '    End If

        'Else
        '    If CatChuoi = "0" Or CatChuoi = "" Then
        '        frm.Bangchu = ""
        '    Else
        '        frm.Bangchu = DoiSo(CatChuoi)
        '    End If
        'End If
        'If UBound(arrCatchuoiVND) > 0 Then
        '    frm.BangchuVND = Mid(DoiSo(arrCatchuoiVND(0)), 1, Len(DoiSo(arrCatchuoiVND(0))) - 4) & "đồng"
        'Else
        '    If CatChuoiVND = "0" Or CatChuoiVND = "" Then
        '        frm.BangchuVND = ""
        '    Else
        '        frm.BangchuVND = Mid(DoiSo(CatChuoiVND), 1, Len(DoiSo(arrCatchuoiVND(0))) - 4) & "đồng"
        '    End If
        'End If
        'frm.strBC = frmShowReport.TenBc.PhieuTC
        'frm.LoaiPhieuTC = "T"
        'frm.Title = "PHIẾU THU TIỀN MẶT"
        'frm.NguoiTC = "Người nộp"
        'frm.donvi = "Họ tên BN:"
        'Dim ifo_donvi As DataTable = BusinessLogic.Data.GetDataset("DS_BenhNhan_KhachHang", Data.CommandType.StoredProcedure, New List(Of String) From {"mabn"}, New List(Of Object) From {cmbMakh.EditValue}).Tables(0)
        'If ifo_donvi.Rows.Count > 0 Then
        '    If Not ifo_donvi.Rows(0)("diachi") Is DBNull.Value Then
        '        frm.diachi = ifo_donvi.Rows(0)("diachi").ToString()
        '    Else
        '        frm.diachi = ""
        '    End If
        '    If Not ifo_donvi.Rows(0)("dienthoai") Is DBNull.Value Then
        '        frm.dienthoai = ifo_donvi.Rows(0)("dienthoai").ToString()
        '    Else
        '        frm.dienthoai = ""
        '    End If
        'Else
        '    frm.diachi = ""
        '    frm.dienthoai = ""
        'End If
        'frm.Show()
    End Sub
    Private Sub cmbMakh_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbMakh.ButtonClick
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
        Load_ComboBox("Select mabn[Mã],hotenbn[Họ tên] from hosobn", cmbMakh, CNNQLPHONGKHAM)
        Me.cmbMakh.EditValue = MaBN
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Try
            Dim dt As DataTable
            Dim row As DataRow
            row = Me.GridView1.GetDataRow(e.RowHandle.ToString)
            If Is_Edit = False Then
                dt = BusinessLogic.Data.GetDataset("proc_GetList_TonThuoc_SoLo", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho", "Masp"}, New List(Of Object) From {CmbKhohang.EditValue, row("Masp")}).Tables(0)
            Else
                dt = BusinessLogic.Data.GetDataset("proc_GetList_TonThuoc_SoLo_TraKho", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieu", "masp"}, New List(Of Object) From {Integer.Parse("0" + txtSophieu.EditValue), row("Masp")}).Tables(0)
            End If
            RepositoryItemSearchLookUpEdit_LoXuat.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSotienVnd_EditValueChanged(sender As Object, e As EventArgs) Handles txtSotienVnd.EditValueChanged
        If String.IsNullOrEmpty(Chuanhoa(txtSotienVnd.Text)) Then
            txtSotienVnd.Text = "0"
        End If
    End Sub
End Class
