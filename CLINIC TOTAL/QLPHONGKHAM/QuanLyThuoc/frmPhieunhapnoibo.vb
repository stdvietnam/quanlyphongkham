Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class frmPhieunhapnoibo
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
    Friend WithEvents Panel_Button As Panel
    Private Sophieunoibo As Integer
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
    Friend WithEvents Grb As System.Windows.Forms.GroupBox
    Friend WithEvents txtSophieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbNVBH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CmbKhohang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DtpNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbLoai_xuat As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents grdDinh_khoan As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBoxoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_ghichu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMakh As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieunhapnoibo))
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGhichu = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbMakh = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtSophieu = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbNVBH = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbKhohang = New DevExpress.XtraEditors.LookUpEdit()
        Me.DtpNgay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbLoai_xuat = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.colSoluong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid_ghichu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnBoxoa = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        CType(Me.cmbMakh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(321, 16)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 18
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(420, 16)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 19
        Me.btnSua.Text = "&Sửa"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(222, 16)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 16
        Me.btnIn.Text = "&In phiếu"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(519, 16)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 20
        Me.btnXoa.Text = "&Xoá"
        '
        'txtGhichu
        '
        Me.txtGhichu.EditValue = ""
        Me.txtGhichu.Location = New System.Drawing.Point(119, 94)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Properties.AutoHeight = False
        Me.txtGhichu.Size = New System.Drawing.Size(587, 22)
        Me.txtGhichu.TabIndex = 11
        Me.txtGhichu.Tag = "GhiChu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(21, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Ghi Chú"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(623, 16)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 22
        Me.btnThoat.Text = "&Thoát"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'Grb
        '
        Me.Grb.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Grb.Controls.Add(Me.Label9)
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.Label8)
        Me.Grb.Controls.Add(Me.cmbMakh)
        Me.Grb.Controls.Add(Me.txtSophieu)
        Me.Grb.Controls.Add(Me.txtGhichu)
        Me.Grb.Controls.Add(Me.Label16)
        Me.Grb.Controls.Add(Me.CmbNVBH)
        Me.Grb.Controls.Add(Me.Label12)
        Me.Grb.Controls.Add(Me.CmbKhohang)
        Me.Grb.Controls.Add(Me.DtpNgay)
        Me.Grb.Controls.Add(Me.cmbLoai_xuat)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb.ForeColor = System.Drawing.Color.Red
        Me.Grb.Location = New System.Drawing.Point(0, 0)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(722, 122)
        Me.Grb.TabIndex = 0
        Me.Grb.TabStop = False
        Me.Grb.Text = "Thông tin phiếu nhập"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Phòng"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(21, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Kho hàng"
        '
        'cmbMakh
        '
        Me.cmbMakh.AllowDrop = True
        Me.cmbMakh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbMakh.Location = New System.Drawing.Point(119, 44)
        Me.cmbMakh.Name = "cmbMakh"
        Me.cmbMakh.Properties.AutoHeight = False
        Me.cmbMakh.Properties.AutoSearchColumnIndex = 1
        Me.cmbMakh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMakh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbMakh.Properties.NullText = ""
        Me.cmbMakh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbMakh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMakh.Size = New System.Drawing.Size(268, 22)
        Me.cmbMakh.TabIndex = 1
        Me.cmbMakh.Tag = "Makh"
        '
        'txtSophieu
        '
        Me.txtSophieu.EditValue = ""
        Me.txtSophieu.Enabled = False
        Me.txtSophieu.Location = New System.Drawing.Point(497, 19)
        Me.txtSophieu.Name = "txtSophieu"
        Me.txtSophieu.Properties.AutoHeight = False
        Me.txtSophieu.Size = New System.Drawing.Size(103, 22)
        Me.txtSophieu.TabIndex = 16
        Me.txtSophieu.Tag = "Sophieu"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(21, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Nhân viên XN"
        '
        'CmbNVBH
        '
        Me.CmbNVBH.Location = New System.Drawing.Point(119, 69)
        Me.CmbNVBH.Name = "CmbNVBH"
        Me.CmbNVBH.Properties.AutoHeight = False
        Me.CmbNVBH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbNVBH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Tên nhân viên", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbNVBH.Properties.NullText = ""
        Me.CmbNVBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbNVBH.Size = New System.Drawing.Size(268, 22)
        Me.CmbNVBH.TabIndex = 3
        Me.CmbNVBH.Tag = "Nguoinhap"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(422, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Loại xuất"
        '
        'CmbKhohang
        '
        Me.CmbKhohang.AllowDrop = True
        Me.CmbKhohang.Location = New System.Drawing.Point(119, 19)
        Me.CmbKhohang.Name = "CmbKhohang"
        Me.CmbKhohang.Properties.AutoHeight = False
        Me.CmbKhohang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbKhohang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã kho", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbKhohang.Properties.NullText = ""
        Me.CmbKhohang.Properties.PopupWidth = 200
        Me.CmbKhohang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbKhohang.Properties.ValidateOnEnterKey = True
        Me.CmbKhohang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbKhohang.Size = New System.Drawing.Size(268, 22)
        Me.CmbKhohang.TabIndex = 5
        Me.CmbKhohang.Tag = "makho"
        '
        'DtpNgay
        '
        Me.DtpNgay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.DtpNgay.Location = New System.Drawing.Point(497, 44)
        Me.DtpNgay.Name = "DtpNgay"
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
        Me.DtpNgay.Size = New System.Drawing.Size(103, 22)
        Me.DtpNgay.TabIndex = 7
        Me.DtpNgay.Tag = "Ngay"
        '
        'cmbLoai_xuat
        '
        Me.cmbLoai_xuat.Location = New System.Drawing.Point(497, 69)
        Me.cmbLoai_xuat.Name = "cmbLoai_xuat"
        Me.cmbLoai_xuat.Properties.AutoHeight = False
        Me.cmbLoai_xuat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLoai_xuat.Properties.NullText = ""
        Me.cmbLoai_xuat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbLoai_xuat.Size = New System.Drawing.Size(209, 22)
        Me.cmbLoai_xuat.TabIndex = 4
        Me.cmbLoai_xuat.Tag = "MaXN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(422, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Ngày lập"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(421, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Số phiếu"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(24, 16)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "&Nhập mới"
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(123, 16)
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
        Me.grdDinh_khoan.Location = New System.Drawing.Point(0, 122)
        Me.grdDinh_khoan.MainView = Me.GridView1
        Me.grdDinh_khoan.Name = "grdDinh_khoan"
        Me.grdDinh_khoan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.grdDinh_khoan.Size = New System.Drawing.Size(722, 318)
        Me.grdDinh_khoan.TabIndex = 10
        Me.grdDinh_khoan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT, Me.colMasp, Me.colTensp, Me.DVT, Me.colSoluong, Me.Grid_ghichu})
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
        Me.colSTT.Width = 42
        '
        'colMasp
        '
        Me.colMasp.Caption = "Mã "
        Me.colMasp.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colMasp.FieldName = "masp"
        Me.colMasp.Name = "colMasp"
        Me.colMasp.Visible = True
        Me.colMasp.VisibleIndex = 1
        Me.colMasp.Width = 64
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
        Me.colTensp.VisibleIndex = 2
        Me.colTensp.Width = 174
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
        Me.DVT.VisibleIndex = 3
        Me.DVT.Width = 66
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
        'colSoluong
        '
        Me.colSoluong.Caption = "Số lượng"
        Me.colSoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSoluong.FieldName = "soluong"
        Me.colSoluong.Name = "colSoluong"
        Me.colSoluong.Visible = True
        Me.colSoluong.VisibleIndex = 4
        Me.colSoluong.Width = 56
        '
        'Grid_ghichu
        '
        Me.Grid_ghichu.Caption = "Ghi chú"
        Me.Grid_ghichu.FieldName = "ghichu"
        Me.Grid_ghichu.Name = "Grid_ghichu"
        Me.Grid_ghichu.Visible = True
        Me.Grid_ghichu.VisibleIndex = 5
        Me.Grid_ghichu.Width = 66
        '
        'btnBoxoa
        '
        Me.btnBoxoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoxoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBoxoa.Appearance.Options.UseFont = True
        Me.btnBoxoa.Appearance.Options.UseForeColor = True
        Me.btnBoxoa.Location = New System.Drawing.Point(519, 16)
        Me.btnBoxoa.Name = "btnBoxoa"
        Me.btnBoxoa.Size = New System.Drawing.Size(75, 25)
        Me.btnBoxoa.TabIndex = 21
        Me.btnBoxoa.Text = "Bỏ xóa"
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnBoxoa)
        Me.Panel_Button.Controls.Add(Me.btnIn)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 446)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(722, 53)
        Me.Panel_Button.TabIndex = 23
        '
        'frmPhieunhapnoibo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 499)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.grdDinh_khoan)
        Me.Controls.Add(Me.Grb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPhieunhapnoibo"
        Me.Text = "PHIẾU NHẬP VẬT TƯ NỘI BỘ"
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.cmbMakh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.DtpNgay.Enabled = False
        Load_Data()
        Form_Initial()
        Ctrl_QuyenForm(Me)
        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnBoxoa.Visible = False
        If IDPhieuxuat <> 0 Then
            'Me.btnThem.Enabled = False
            'Me.btnSua.Enabled = True
            'Me.btnXoa.Enabled = True
            Me.btnIn.Enabled = True
            'Me.btnThoat.Enabled = True
            'Me.DtpNgay.Enabled = True
            'Me.grdDinh_khoan.Enabled = False
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Them)
            Me.btnXoa.Enabled = True
            Me.Grb.Enabled = True
        End If
        If blnDelete = True Then
            Me.btnXoa.Enabled = False
            Me.btnBoxoa.Visible = True
            Me.btnBoxoa.Enabled = True
            Me.btnXoa.Visible = False
        End If
        'Me.GridView1.Columns.Remove(Losanpham)
        stype = True
    End Sub
    Private Sub Form_Initial()
        Dim clsObjPxn As New clsXNKho
        Dim dtbxn As New DataTable
        Load_ComboBox("select maphong[Mã],tenphong[Phòng] from phong_ban where loai not in(1,8) ", Me.cmbMakh, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaXn,TenLoai From DM_Xuat_Nhap", Me.cmbLoai_xuat, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang order by Tenkho", Me.CmbKhohang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.CmbNVBH, CNNQLPHONGKHAM, True)
        Me.CmbNVBH.EditValue = clsLoginObj.strUsername
        cmbLoai_xuat.EditValue = "NNB"
        Me.CmbNVBH.Enabled = False
        Dim dt As New DataTable
        dt = BusinessLogic.Data.GetDataset("Select masp,tensp,donvt from san_pham").Tables(0)
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
        strSql = "SELECT * FROM tb_xuatnhapnoibo WHERE ID=" & IDPhieuxuat & " "
        dtbPXN = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing).Tables(0)
        If dtbPXN.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbPXN.Rows(0)
            blnLoaiphieu = row("Loaiphieu")
            Me.cmbMakh.EditValue = row("maphong")
            Me.CmbNVBH.EditValue = row("manv")
            Me.CmbKhohang.EditValue = row("makho")
            Me.cmbLoai_xuat.EditValue = row("loaixn")
            Me.txtGhichu.Text = row("ghichu")
            Me.txtSophieu.Text = row("sophieu")
            Me.DtpNgay.DateTime = row("ngay")
            Me.Text = "Phiếu nhập nội bộ"
            Me.Label12.Text = "Loại nhập"
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
            strSql = "SELECT [id],[idsophieu],[masp],[soluong],[stt],ghichu FROM tb_xuatnhapnoiboct WHERE IDSophieu =" & IDPhieuxuat & " order by id "
        Else
            strSql = "SELECT [id],[idsophieu],[masp],[soluong],[stt],ghichu FROM tb_xuatnhapnoiboct WHERE IDSophieu =-9999 order by id "
        End If
        dtb_PreCTPXN = BusinessLogic.Data.GetDataset(strSql).Tables(0)
        Me.grdDinh_khoan.DataSource = dtb_PreCTPXN
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim i As Int16
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString)
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Public Sub FormClear()

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
        blnType = False
        Me.grdDinh_khoan.Enabled = True
        Me.Grb.Enabled = True
        Me.txtGhichu.Enabled = True

        Me.btnIn.Enabled = False
        Me.CmbNVBH.Enabled = False
        StypeSUA = True

    End Sub
    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Me.btnThem.Enabled = False
    End Sub

#End Region
#Region "Nhom cac su kien Button"
    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim ketnoi As String
        ketnoi = CNNQLPHONGKHAM.ConnectionString
        Dim strSQL As String
        If checkNhap() Then
            Dim dr As DataRowView
            Dim int_i As Int16
            Dim Soluong As Double
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
            Dim dt As DataTable = BusinessLogic.Data.GetDataset("proc_GetListHanghoa", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
            Dim dt2 As DataTable = DirectCast(grdDinh_khoan.DataSource, DataTable)
            For Each r As DataRow In dt2.Rows
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
            Next
            If blnType = True Then
                'INSERT()
                'SaveEntry()

            Else
                ' UPDATA()
                SaveEntry()

            End If
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
        Me.btnIn.Focus()
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Function checkNhap() As Boolean
        checkNhap = True
        If cmbMakh.EditValue = "" Then
            checkNhap = False
            ErrPro.SetError(cmbMakh, "Dữ liệu không để trống!")
            ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If cmbLoai_xuat.EditValue = "" Then
            checkNhap = False
            ErrPro.SetError(cmbLoai_xuat, "Dữ liệu không để trống!")
            ErrPro.SetIconAlignment(cmbLoai_xuat, ErrorIconAlignment.BottomRight)
            ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If CmbKhohang.EditValue = "" Then
            checkNhap = False
            ErrPro.SetError(CmbKhohang, "Dữ liệu không để trống!")
            ErrPro.SetIconAlignment(CmbKhohang, ErrorIconAlignment.BottomRight)
            ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
    End Function
    Private Sub frmPhieuXN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Int16
        If e.KeyCode = Keys.Delete Then
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
    End Sub
    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim i As Integer
        Dim dtbtk As New DataTable
        Dim dtbxn As New DataTable
        Dim dtbkho As New DataTable
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        FormClear()
        dtbkho = Load_DataTable("select makho from kho_hang where makho='KT'", CNNQLPHONGKHAM)
        Me.CmbKhohang.EditValue = dtbkho.Rows(0)("makho")
        frmState = False
        Me.DtpNgay.DateTime = Today.Date
        Me.DtpNgay.Enabled = False
        Me.txtSophieu.Enabled = False

        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnIn.Enabled = False
        Me.CmbNVBH.Enabled = False
        Me.CmbKhohang.Enabled = False
        Me.Grb.Enabled = True
        CTPXFill()
        k = 0
    End Sub
#End Region
    Private Sub INSERT()
        Dim str As String = ""
        str = "insert into Phieu_Xuat_Nhap(sophieu,loaiphieu,makh,madv,ngay,maxn,makho,nguoinhap,ghichu,maphong,huy) values('" & txtSophieu.Text & "','" & blnLoaiphieu & "','" & cmbMakh.EditValue & "','" & cmbMakh.EditValue & "','" & DtpNgay.DateTime & "','" & cmbLoai_xuat.EditValue & "','" & CmbKhohang.EditValue & "','" & CmbNVBH.EditValue & "','" & txtGhichu.Text & "','" & cmbMakh.EditValue & "',0)"
        Command_Exc(str, CNNQLPHONGKHAM)
        Me.btnCap_nhat.Enabled = False
        Exit Sub

        Dim Bolean As Boolean = False
        Dim blkhuyenmai As Boolean = False
        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        clsObjPxn.ThemPhieu(Me.txtSophieu.Text, blnLoaiphieu, Me.cmbMakh.EditValue, "0", 0, 1, 0, 0, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, 0, 0, int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
    End Sub
    Private Sub UPDATA()
        Dim str As String = ""
        str = "update tb_xuatnhapnoibo set makh ='" & cmbMakh.EditValue & "',madv='" & cmbMakh.EditValue & "',ngay='" & DtpNgay.DateTime & "',maxn='" & cmbLoai_xuat.EditValue & "',makho='" & CmbKhohang.EditValue & "',nguoinhap='" & CmbNVBH.EditValue & "',ghichu='" & txtGhichu.Text & "',maphong='" & cmbMakh.EditValue & "' where sophieu='" & txtSophieu.Text & "' "
        Command_Exc(str, CNNQLPHONGKHAM)
        Me.btnCap_nhat.Enabled = False
        Exit Sub

        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        Dim fVAT As Double
        clsObjPxn.ThemPhieu(IDPhieuxuat, blnLoaiphieu, Me.cmbMakh.EditValue, "0", 0, 1, fVAT, 1, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, 0, 0, int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
        Me.btnCap_nhat.Enabled = False
    End Sub
    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle)
        Dim row1 As DataRow
        row1 = Me.GridView1.GetDataRow(e.RowHandle - 1)
        row("soluong") = 0
        row("ghichu") = ""
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
            Dim strSQL As String
            Dim Styl As Boolean = False
            strSQL = "UPDATE tb_xuatnhapnoibo SET Huy=1 WHERE ID=" & IDPhieuxuat & ""
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            MsgBox("Bản ghi hiện tại đã được xoá")
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
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.Xuat_VTHT_CLS
        frm.IDSophieu = txtSophieu.EditValue
        frm.LoaiPhieu = 1
        frm.Title = "PHIẾU NHẬP VTTH PHÒNG CLS"
        frm.loaixn = "NNB"
        Dim dt As DataTable = New DataTable()
        dt = BusinessLogic.Data.GetDataset("tk_xuatvtth_cls", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieu", "maphong", "loaiphieu", "loaixn"}, New List(Of Object) From {txtSophieu.EditValue, "", 1, "NNB"}).Tables(0)
        frm.dtb = dt
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
        dtb = BusinessLogic.Data.GetDataset("select * from ket_chuyen", CommandType.Text, Nothing, Nothing).Tables(0)
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
            Dim strSQL As String
            Dim Styl As Boolean = False
            strSQL = "UPDATE tb_xuatnhapnoibo SET Huy=0 WHERE ID=" & IDPhieuxuat & ""
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            MsgBox("Phiếu hiện tại đã được phục hồi")
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
    End Sub

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
        Dim sql As String
        sql = "update tb_xuatnhapnoiboct set Stt='" & row("STT") & "',Masp='" & row("Masp") & "',soluong='" & row("soluong") & "',ghichu=N'" & row("ghichu") & "' where ID='" & row("ID") & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub
    Private Sub DeleteEntry(ByVal row As DataRow)
        Dim sql As String
        sql = "Delete from tb_xuatnhapnoiboct Where ID='" & row("ID", DataRowVersion.Original) & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub
    Private Sub AddNewEntry(ByVal row As DataRow)
        Dim sql As String
        Dim dtphieu As New DataTable
        dtphieu = BusinessLogic.Data.GetDataset("select Id from tb_xuatnhapnoibo where loaiphieu=1 and sophieu='" & txtSophieu.Text & "'", CommandType.Text, Nothing, Nothing).Tables(0)
        sql = "Insert into tb_xuatnhapnoiboct(IDSophieu,Masp,Soluong,STT,ghichu)values(N'" & dtphieu.Rows(0)(0) & "',N'" & row("Masp") & "',N'" & row("Soluong").ToString() & "',N'" & row("STT").ToString() & "',N'" & row("ghichu") & "')"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub
    

End Class
