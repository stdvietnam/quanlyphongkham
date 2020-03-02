Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class frmPhieuxuatvtyt
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
    Friend WithEvents Dngaysinh As DevExpress.XtraEditors.DateEdit
    Public dtthuoc As DataTable
    Private dts As New DataSet
    Friend WithEvents txtsophieudv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel_Button As Panel
    Public kieuthu As Int16 = 0
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
    Friend WithEvents GroupBox_BN As System.Windows.Forms.GroupBox
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
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSophieukham As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbMakh As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuxuatvtyt))
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGhichu = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.txtsophieudv = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSophieu = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbNVBH = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbKhohang = New DevExpress.XtraEditors.LookUpEdit()
        Me.DtpNgay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbLoai_xuat = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.colSoluong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid_ghichu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnBoxoa = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox_BN = New System.Windows.Forms.GroupBox()
        Me.Dngaysinh = New DevExpress.XtraEditors.DateEdit()
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
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        CType(Me.txtsophieudv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSophieukham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_BN.SuspendLayout()
        CType(Me.Dngaysinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dngaysinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenBN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMakh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNghenghiep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiachi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGioitinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(323, 19)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 18
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(424, 19)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 19
        Me.btnSua.Text = "&Sửa"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(222, 19)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 16
        Me.btnIn.Text = "&In phiếu"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(525, 19)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 20
        Me.btnXoa.Text = "&Xoá"
        '
        'txtGhichu
        '
        Me.txtGhichu.EditValue = ""
        Me.txtGhichu.Location = New System.Drawing.Point(96, 10)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Properties.AutoHeight = False
        Me.txtGhichu.Size = New System.Drawing.Size(705, 22)
        Me.txtGhichu.TabIndex = 11
        Me.txtGhichu.Tag = "GhiChu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(27, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Ghi Chú"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(726, 19)
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
        Me.Grb.Controls.Add(Me.txtsophieudv)
        Me.Grb.Controls.Add(Me.Label8)
        Me.Grb.Controls.Add(Me.txtSophieu)
        Me.Grb.Controls.Add(Me.Label12)
        Me.Grb.Controls.Add(Me.CmbNVBH)
        Me.Grb.Controls.Add(Me.Label16)
        Me.Grb.Controls.Add(Me.CmbKhohang)
        Me.Grb.Controls.Add(Me.DtpNgay)
        Me.Grb.Controls.Add(Me.cmbLoai_xuat)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.TxtSophieukham)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Location = New System.Drawing.Point(-1, 122)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(814, 93)
        Me.Grb.TabIndex = 0
        Me.Grb.TabStop = False
        '
        'txtsophieudv
        '
        Me.txtsophieudv.EditValue = "0"
        Me.txtsophieudv.Location = New System.Drawing.Point(353, 13)
        Me.txtsophieudv.Name = "txtsophieudv"
        Me.txtsophieudv.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtsophieudv.Properties.Appearance.Options.UseFont = True
        Me.txtsophieudv.Properties.AutoHeight = False
        Me.txtsophieudv.Properties.ReadOnly = True
        Me.txtsophieudv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsophieudv.Size = New System.Drawing.Size(61, 22)
        Me.txtsophieudv.TabIndex = 29
        Me.txtsophieudv.Tag = "SOPHIEUKHAM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(18, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Phòng"
        '
        'txtSophieu
        '
        Me.txtSophieu.EditValue = ""
        Me.txtSophieu.Enabled = False
        Me.txtSophieu.Location = New System.Drawing.Point(677, 37)
        Me.txtSophieu.Name = "txtSophieu"
        Me.txtSophieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSophieu.Properties.Appearance.Options.UseFont = True
        Me.txtSophieu.Properties.AutoHeight = False
        Me.txtSophieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSophieu.Size = New System.Drawing.Size(125, 22)
        Me.txtSophieu.TabIndex = 16
        Me.txtSophieu.Tag = "Sophieu"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(18, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Loại xuất"
        '
        'CmbNVBH
        '
        Me.CmbNVBH.Location = New System.Drawing.Point(97, 13)
        Me.CmbNVBH.Name = "CmbNVBH"
        Me.CmbNVBH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmbNVBH.Properties.Appearance.Options.UseFont = True
        Me.CmbNVBH.Properties.AutoHeight = False
        Me.CmbNVBH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbNVBH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Tên nhân viên", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbNVBH.Properties.NullText = ""
        Me.CmbNVBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbNVBH.Size = New System.Drawing.Size(250, 22)
        Me.CmbNVBH.TabIndex = 3
        Me.CmbNVBH.Tag = "Nguoinhap"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(18, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Bác sĩ"
        '
        'CmbKhohang
        '
        Me.CmbKhohang.AllowDrop = True
        Me.CmbKhohang.Location = New System.Drawing.Point(97, 61)
        Me.CmbKhohang.Name = "CmbKhohang"
        Me.CmbKhohang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmbKhohang.Properties.Appearance.Options.UseFont = True
        Me.CmbKhohang.Properties.AutoHeight = False
        Me.CmbKhohang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbKhohang.Properties.NullText = ""
        Me.CmbKhohang.Properties.PopupWidth = 200
        Me.CmbKhohang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbKhohang.Properties.ValidateOnEnterKey = True
        Me.CmbKhohang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbKhohang.Size = New System.Drawing.Size(250, 22)
        Me.CmbKhohang.TabIndex = 5
        Me.CmbKhohang.Tag = "makho"
        '
        'DtpNgay
        '
        Me.DtpNgay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.DtpNgay.Location = New System.Drawing.Point(677, 61)
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
        Me.DtpNgay.Size = New System.Drawing.Size(125, 22)
        Me.DtpNgay.TabIndex = 7
        Me.DtpNgay.Tag = "Ngay"
        '
        'cmbLoai_xuat
        '
        Me.cmbLoai_xuat.Location = New System.Drawing.Point(97, 37)
        Me.cmbLoai_xuat.Name = "cmbLoai_xuat"
        Me.cmbLoai_xuat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbLoai_xuat.Properties.Appearance.Options.UseFont = True
        Me.cmbLoai_xuat.Properties.AutoHeight = False
        Me.cmbLoai_xuat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLoai_xuat.Properties.NullText = ""
        Me.cmbLoai_xuat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbLoai_xuat.Size = New System.Drawing.Size(250, 22)
        Me.cmbLoai_xuat.TabIndex = 4
        Me.cmbLoai_xuat.Tag = "MaXN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(600, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Ngày lập"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(600, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Số P.Khám"
        '
        'TxtSophieukham
        '
        Me.TxtSophieukham.EditValue = "0"
        Me.TxtSophieukham.Location = New System.Drawing.Point(677, 13)
        Me.TxtSophieukham.Name = "TxtSophieukham"
        Me.TxtSophieukham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtSophieukham.Properties.Appearance.Options.UseFont = True
        Me.TxtSophieukham.Properties.AutoHeight = False
        Me.TxtSophieukham.Properties.ReadOnly = True
        Me.TxtSophieukham.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSophieukham.Size = New System.Drawing.Size(125, 22)
        Me.TxtSophieukham.TabIndex = 16
        Me.TxtSophieukham.Tag = "SOPHIEUKHAM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(600, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Số phiếu"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(20, 19)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "&Nhập mới"
        Me.btnThem.Visible = False
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(121, 19)
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
        Me.grdDinh_khoan.Location = New System.Drawing.Point(-1, 218)
        Me.grdDinh_khoan.MainView = Me.GridView1
        Me.grdDinh_khoan.Name = "grdDinh_khoan"
        Me.grdDinh_khoan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.grdDinh_khoan.Size = New System.Drawing.Size(814, 249)
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
        Me.colSTT.Caption = "stt"
        Me.colSTT.FieldName = "stt"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.OptionsColumn.AllowEdit = False
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 0
        Me.colSTT.Width = 54
        '
        'colMasp
        '
        Me.colMasp.Caption = "Mã "
        Me.colMasp.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colMasp.FieldName = "masp"
        Me.colMasp.Name = "colMasp"
        Me.colMasp.Visible = True
        Me.colMasp.VisibleIndex = 1
        Me.colMasp.Width = 103
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
        Me.colTensp.Width = 304
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
        Me.DVT.Width = 50
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
        Me.colSoluong.Width = 71
        '
        'Grid_ghichu
        '
        Me.Grid_ghichu.Caption = "Ghi chú"
        Me.Grid_ghichu.FieldName = "ghichu"
        Me.Grid_ghichu.Name = "Grid_ghichu"
        Me.Grid_ghichu.Visible = True
        Me.Grid_ghichu.VisibleIndex = 5
        Me.Grid_ghichu.Width = 214
        '
        'btnBoxoa
        '
        Me.btnBoxoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnBoxoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBoxoa.Appearance.Options.UseFont = True
        Me.btnBoxoa.Appearance.Options.UseForeColor = True
        Me.btnBoxoa.Location = New System.Drawing.Point(525, 19)
        Me.btnBoxoa.Name = "btnBoxoa"
        Me.btnBoxoa.Size = New System.Drawing.Size(75, 25)
        Me.btnBoxoa.TabIndex = 21
        Me.btnBoxoa.Text = "Bỏ xóa"
        '
        'GroupBox_BN
        '
        Me.GroupBox_BN.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupBox_BN.Controls.Add(Me.Dngaysinh)
        Me.GroupBox_BN.Controls.Add(Me.txtTenBN)
        Me.GroupBox_BN.Controls.Add(Me.Label1)
        Me.GroupBox_BN.Controls.Add(Me.cmbMakh)
        Me.GroupBox_BN.Controls.Add(Me.txtNghenghiep)
        Me.GroupBox_BN.Controls.Add(Me.Label2)
        Me.GroupBox_BN.Controls.Add(Me.txtDiachi)
        Me.GroupBox_BN.Controls.Add(Me.txtTel)
        Me.GroupBox_BN.Controls.Add(Me.Label13)
        Me.GroupBox_BN.Controls.Add(Me.Label14)
        Me.GroupBox_BN.Controls.Add(Me.txtGioitinh)
        Me.GroupBox_BN.Controls.Add(Me.Label17)
        Me.GroupBox_BN.Controls.Add(Me.Label18)
        Me.GroupBox_BN.Controls.Add(Me.TextEdit7)
        Me.GroupBox_BN.Controls.Add(Me.Label20)
        Me.GroupBox_BN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_BN.ForeColor = System.Drawing.Color.Red
        Me.GroupBox_BN.Location = New System.Drawing.Point(-1, 36)
        Me.GroupBox_BN.Name = "GroupBox_BN"
        Me.GroupBox_BN.Size = New System.Drawing.Size(814, 93)
        Me.GroupBox_BN.TabIndex = 57
        Me.GroupBox_BN.TabStop = False
        Me.GroupBox_BN.Text = "Quản lý thông tin bệnh nhân"
        '
        'Dngaysinh
        '
        Me.Dngaysinh.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.Dngaysinh.Location = New System.Drawing.Point(558, 19)
        Me.Dngaysinh.Name = "Dngaysinh"
        Me.Dngaysinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Dngaysinh.Properties.Appearance.Options.UseFont = True
        Me.Dngaysinh.Properties.Appearance.Options.UseTextOptions = True
        Me.Dngaysinh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Dngaysinh.Properties.AutoHeight = False
        Me.Dngaysinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dngaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Dngaysinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Dngaysinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Dngaysinh.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Dngaysinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Dngaysinh.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.Dngaysinh.Size = New System.Drawing.Size(112, 22)
        Me.Dngaysinh.TabIndex = 28
        Me.Dngaysinh.Tag = "Ngay"
        '
        'txtTenBN
        '
        Me.txtTenBN.EditValue = ""
        Me.txtTenBN.Location = New System.Drawing.Point(98, 43)
        Me.txtTenBN.Name = "txtTenBN"
        Me.txtTenBN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTenBN.Properties.Appearance.Options.UseFont = True
        Me.txtTenBN.Properties.AutoHeight = False
        Me.txtTenBN.Properties.ReadOnly = True
        Me.txtTenBN.Size = New System.Drawing.Size(249, 22)
        Me.txtTenBN.TabIndex = 28
        Me.txtTenBN.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã BN"
        '
        'cmbMakh
        '
        Me.cmbMakh.AllowDrop = True
        Me.cmbMakh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbMakh.Location = New System.Drawing.Point(98, 19)
        Me.cmbMakh.Name = "cmbMakh"
        Me.cmbMakh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbMakh.Properties.Appearance.Options.UseFont = True
        Me.cmbMakh.Properties.AutoHeight = False
        Me.cmbMakh.Properties.AutoSearchColumnIndex = 1
        Me.cmbMakh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMakh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbMakh.Properties.NullText = ""
        Me.cmbMakh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbMakh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMakh.Size = New System.Drawing.Size(249, 22)
        Me.cmbMakh.TabIndex = 1
        Me.cmbMakh.Tag = "Makh"
        '
        'txtNghenghiep
        '
        Me.txtNghenghiep.EditValue = ""
        Me.txtNghenghiep.Location = New System.Drawing.Point(558, 67)
        Me.txtNghenghiep.Name = "txtNghenghiep"
        Me.txtNghenghiep.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNghenghiep.Properties.Appearance.Options.UseFont = True
        Me.txtNghenghiep.Properties.AutoHeight = False
        Me.txtNghenghiep.Properties.ReadOnly = True
        Me.txtNghenghiep.Size = New System.Drawing.Size(244, 22)
        Me.txtNghenghiep.TabIndex = 31
        Me.txtNghenghiep.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Họ và tên"
        '
        'txtDiachi
        '
        Me.txtDiachi.EditValue = ""
        Me.txtDiachi.Location = New System.Drawing.Point(98, 67)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDiachi.Properties.Appearance.Options.UseFont = True
        Me.txtDiachi.Properties.AutoHeight = False
        Me.txtDiachi.Properties.ReadOnly = True
        Me.txtDiachi.Size = New System.Drawing.Size(249, 22)
        Me.txtDiachi.TabIndex = 29
        Me.txtDiachi.Tag = ""
        '
        'txtTel
        '
        Me.txtTel.EditValue = ""
        Me.txtTel.Location = New System.Drawing.Point(558, 43)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTel.Properties.Appearance.Options.UseFont = True
        Me.txtTel.Properties.AutoHeight = False
        Me.txtTel.Properties.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(244, 22)
        Me.txtTel.TabIndex = 30
        Me.txtTel.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(18, 69)
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
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(473, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Điện thoại"
        '
        'txtGioitinh
        '
        Me.txtGioitinh.EditValue = ""
        Me.txtGioitinh.Location = New System.Drawing.Point(741, 19)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtGioitinh.Properties.Appearance.Options.UseFont = True
        Me.txtGioitinh.Properties.AutoHeight = False
        Me.txtGioitinh.Properties.ReadOnly = True
        Me.txtGioitinh.Size = New System.Drawing.Size(61, 22)
        Me.txtGioitinh.TabIndex = 33
        Me.txtGioitinh.Tag = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(473, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 16)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Năm sinh"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(681, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 16)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Giới tính"
        '
        'TextEdit7
        '
        Me.TextEdit7.EditValue = ""
        Me.TextEdit7.Location = New System.Drawing.Point(1472, 120)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.AutoHeight = False
        Me.TextEdit7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit7.Size = New System.Drawing.Size(9, 24)
        Me.TextEdit7.TabIndex = 23
        Me.TextEdit7.Tag = "TienUSD"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(473, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 16)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Nghề nghiệp"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(813, 33)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "PHIẾU XUẤT VTYT TIÊU HAO"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnBoxoa)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnIn)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 512)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(813, 56)
        Me.Panel_Button.TabIndex = 74
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtGhichu)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 471)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 41)
        Me.Panel2.TabIndex = 75
        '
        'frmPhieuxuatvtyt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 568)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox_BN)
        Me.Controls.Add(Me.grdDinh_khoan)
        Me.Controls.Add(Me.Grb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPhieuxuatvtyt"
        Me.Text = "PHIẾU XUẤT VTYT TIÊU HAO"
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.txtsophieudv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSophieukham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_BN.ResumeLayout(False)
        Me.GroupBox_BN.PerformLayout()
        CType(Me.Dngaysinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dngaysinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenBN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMakh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNghenghiep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiachi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGioitinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    End Sub
   
    Private Sub Form_Initial()
        Dim clsObjPxn As New clsXNKho
        Dim dtbxn As New DataTable
        Load_ComboBox("select mabn[Mã],hotenbn[Họ tên] from hosobn ", Me.cmbMakh, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaXn,TenLoai From DM_Xuat_Nhap WHERE Loai= 0 ", Me.cmbLoai_xuat, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT maphong,tenphong From phong_ban ", Me.CmbKhohang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.CmbNVBH, CNNQLPHONGKHAM, True)
        Me.CmbNVBH.EditValue = clsLoginObj.strUsername
        Me.CmbNVBH.Enabled = False
        cmbLoai_xuat.EditValue = "XTH"

        Dim dt As New DataTable
        dt = BusinessLogic.Data.GetDataset("proc_GetListvtyt", Data.CommandType.StoredProcedure, New List(Of String) From {"maphong"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
        Me.RepositoryItemLookUpEdit1.DataSource = dt
        Me.RepositoryItemLookUpEdit2.DataSource = dt
        Me.RepositoryItemLookUpEdit3.DataSource = dt
        If IDPhieuxuat <> 0 Then
            CTPXFill()
        Else
            CTPXFill()
            Me.txtSophieu.Text = Lay_So_phieu()
        End If
    End Sub
    Public Function Lay_So_phieu() As Integer
        Dim dtbPhieuXn As New DataTable
        dtbPhieuXn = Load_DataTable("SELECT Max(Sophieu)as Sophieu FROM tb_xuatnhapnoibo WHERE LoaiPhieu=0 ", CNNQLPHONGKHAM)
        If dtbPhieuXn.Rows.Count > 0 And Not IsDBNull(dtbPhieuXn.Rows(0)("Sophieu")) Then
            Return dtbPhieuXn.Rows(0)("Sophieu") + 1
        Else
            Return 100000
        End If
    End Function
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
            Me.cmbMakh.EditValue = row("Mabn")
            Me.CmbNVBH.EditValue = row("Manv")
            Me.CmbKhohang.EditValue = row("maphong")
            Me.cmbLoai_xuat.EditValue = row("loaixn")
            Me.txtGhichu.Text = row("ghichu")
            Me.txtSophieu.Text = row("sophieu")
            Me.TxtSophieukham.Text = row("sophieukham").ToString
            txtsophieudv.Text = row("sophieudv").ToString
            Me.DtpNgay.DateTime = row(Me.DtpNgay.Tag)
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
            strSql = "SELECT [id],[idsophieu],[masp],[soluong],[stt],[ghichu] FROM tb_xuatnhapnoiboct WHERE IDSophieu =" & IDPhieuxuat & " order by id "
        Else
            strSql = "SELECT [id],[idsophieu],[masp],[soluong],[stt],[ghichu] FROM tb_xuatnhapnoiboct WHERE IDSophieu =-9999 order by id "
        End If
        dtb_PreCTPXN = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing).Tables(0)
        Me.grdDinh_khoan.DataSource = dtb_PreCTPXN
    End Sub
    Private Function CheckValidation() As Boolean
        CheckValidation = True
    End Function
    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim i As Int16
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString)

         
        Me.GridView1.UpdateCurrentRow()

    End Sub
    
    Public Sub FormClear()
         
    End Sub
   

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
        Me.GroupBox_BN.Enabled = True
        Me.txtGhichu.Enabled = True
        Me.TxtSophieukham.Enabled = False
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
        If CheckValidation() = True Then
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
            Dim dt = BusinessLogic.Data.GetDataset("proc_GetListvtyt", Data.CommandType.StoredProcedure, New List(Of String) From {"maphong"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
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
                'Me.GridView1.UpdateCurrentRow()
                'TongUSD()
            Next
            If blnType = True Then
                INSERT()

                SaveEntry()

            Else
                UPDATA()

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
        
        frmState = False
        Me.DtpNgay.DateTime = Today.Date
        Me.DtpNgay.Enabled = False
        Me.txtSophieu.Enabled = False

        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnIn.Enabled = False
        Me.CmbNVBH.Enabled = False
        Me.CmbKhohang.Enabled = False
        Me.GroupBox_BN.Enabled = True
        CTPXFill()
        k = 0
    End Sub
#End Region
    Private Sub INSERT()


        Dim str As String = ""
        str = "insert into tb_xuatnhapnoibo([Sophieu],[Loaiphieu],[Ngay],[Maphong],[Manv],[Huy],[Loaixn],[Ghichu],[Mabn],[Sophieukham],[Sophieudv],[Sophieutong]) values('" & txtSophieu.Text & "',0,'" & DtpNgay.DateTime & "','" & CmbKhohang.EditValue & "','" & CmbNVBH.EditValue & "',0,'" & cmbLoai_xuat.EditValue & "','" & txtGhichu.Text & "','" & cmbMakh.EditValue & "','" & TxtSophieukham.Text & "','" & txtsophieudv.Text & "',0)"
        Command_Exc(str, CNNQLPHONGKHAM)
        Me.btnCap_nhat.Enabled = False
        Exit Sub

        Dim Bolean As Boolean = False
        Dim blkhuyenmai As Boolean = False
        Me.GridView1.UpdateCurrentRow()

        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        'clsObjPxn.ThemPhieu(Me.txtSophieu.Text, blnLoaiphieu, Me.cmbMakh.EditValue, "0", Chuanhoa(Me.txtSotienVnd.Text), Chuanhoa(Me.txtTygia.Text), 0, 0, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, Chuanhoa(Me.txtSotienVnd.Text), Chuanhoa(Me.TxtSophieukham.Text), int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
        Me.btnCap_nhat.Enabled = False

    End Sub
    Private Sub UPDATA()
        Dim str As String = ""
        str = "update tb_xuatnhapnoibo set [Ngay]='" & DtpNgay.DateTime & "' ,[Ghichu] =N'" & txtGhichu.Text & "' where sophieu='" & txtSophieu.Text & "'"
        Command_Exc(str, CNNQLPHONGKHAM)
        Me.btnCap_nhat.Enabled = False
        Exit Sub
        Me.GridView1.UpdateCurrentRow()

        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        Dim fVAT As Double
        ' clsObjPxn.ThemPhieu(IDPhieuxuat, blnLoaiphieu, Me.cmbMakh.EditValue, "0", Chuanhoa(txtSotienVnd.Text), Chuanhoa(Me.txtTygia.Text), fVAT, 1, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, Chuanhoa(txtSotienVnd.Text), Chuanhoa(Me.TxtSophieukham.Text), int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
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
            strSQL = "UPDATE tb_xuatnhapnoibo SET Huy=1 WHERE IDPhieuXn=" & IDPhieuxuat & ""
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
            strSQL = "UPDATE tb_xuatnhapnoibo SET Huy=0 WHERE IDPhieuXn=" & IDPhieuxuat & ""
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
    Private Sub cmbMakh_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMakh.EditValueChanged
        Dim dtbbenhnhan, dtdonvi As New DataTable
        Dim strSQL_BN As String

        strSQL_BN = "SELECT [MaBN],[TenBN],[HoTenBN],DiaChiChiTiet,case [GioiTinh] when 1 then 'Nam'else N'Nữ' end as [GioiTinh],"
        strSQL_BN &= "[NgaySinh],d2.ten as [NgheNghiep] ,[DienThoai],[GhiChu] FROM [HOSOBN] b "
        strSQL_BN &= " left join DMCHUNG d2 on d2.ma=b.nghenghiep where MABN = '" & Me.cmbMakh.EditValue & "'"
        If Not Me.cmbMakh.EditValue Is Nothing Then
            dtbbenhnhan = BusinessLogic.Data.GetDataset(strSQL_BN, CommandType.Text, Nothing, Nothing).Tables(0)

            If dtbbenhnhan.Rows.Count > 0 Then
                Try
                    Me.txtTenBN.Text = ""
                    Me.txtTel.Text = ""
                    Me.txtDiachi.Text = ""
                    Me.Dngaysinh.DateTime = NgayGioServer().Date
                    Me.txtNghenghiep.Text = ""
                    Me.txtGioitinh.Text = ""
                    Me.txtTenBN.Text = dtbbenhnhan.Rows(0)("HOTENBN")
                    Me.txtTel.Text = dtbbenhnhan.Rows(0)("DIENTHOAI")
                    Me.txtDiachi.Text = dtbbenhnhan.Rows(0)("DiaChiChiTiet")
                    Me.Dngaysinh.DateTime = dtbbenhnhan.Rows(0)("NGAYSINH")
                    Me.txtNghenghiep.Text = dtbbenhnhan.Rows(0)("nghenghiep")
                    Me.txtGioitinh.Text = dtbbenhnhan.Rows(0)("Gioitinh")
                Catch ex As Exception

                End Try

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
        dtphieu = BusinessLogic.Data.GetDataset("select Id from tb_xuatnhapnoibo where loaiphieu=0 and sophieu='" & txtSophieu.Text & "'", CommandType.Text, Nothing, Nothing).Tables(0)
        sql = "Insert into tb_xuatnhapnoiboct(IDSophieu,Masp,Soluong,Stt,ghichu)values(N'" & dtphieu.Rows(0)(0) & "',N'" & row("Masp") & "',N'" & row("Soluong").ToString() & "',N'" & row("STT").ToString() & "',N'" & row("ghichu") & "')"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub


    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.Xuat_VTHT_CLS
        frm.IDSophieu = txtSophieu.EditValue
        frm.LoaiPhieu = 0
        frm.Title = "PHIẾU XUẤT VTTH"
        frm.loaixn = "XTH"
        Dim dt As DataTable = New DataTable()
        dt = BusinessLogic.Data.GetDataset("tk_xuatvtth_cls", Data.CommandType.StoredProcedure, New List(Of String) From {"sophieu", "maphong", "loaiphieu", "loaixn"}, New List(Of Object) From {txtSophieu.EditValue, "", 0, "XTH"}).Tables(0)
        frm.dtb = dt
        frm.Show()
    End Sub
End Class
