Imports System.Data
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Imports System.Collections.Generic
Public Class frm_kedonthuoc
    Inherits frmBase 'System.Windows.Forms.Form
#Region "khai bao bien"
    Public blnDelete As Boolean
    Public dtvCTPXN As DataView
    Private dtbCTPXN As DataTable
    Public blnType As Boolean = True
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
    Public PhongKham As String = ""
    Public Inidphieugoc As Integer
    Public LoaiPhieu As Int16
    Private i_status As Int16 = 0
    Public BS As Boolean = False
    Public Is_DotDieuTri As Boolean = False
    Public ngayHenKham As DateTime
    Public isHenKham As Boolean = True
    Public isCloseForm As Boolean = False

    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnBoxoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grb As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbDonvi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDiachi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDienThoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtGioitinh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents DtpNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSophieukham As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSophieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbNVBH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbKhohang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbbacsykedon As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtchandoanls As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbDonMau As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbdoituong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtGhichu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label_SoNgay As Label
    Friend WithEvents txtSoNgay As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox_GhiChu As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents dtHenKham As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkHenKham As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label18 As Label
    Friend WithEvents txtThangTuoi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel_Button As Panel
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
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Collieudung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colghichu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnXuatthuoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents coldongia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colthanhtien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSotien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_kedonthuoc))
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.grdDinh_khoan = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colTensp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSoluong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldongia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colthanhtien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Collieudung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Colghichu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox_GhiChu = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnXuatthuoc = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSotien = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBoxoa = New DevExpress.XtraEditors.SimpleButton()
        Me.Grb = New DevExpress.XtraEditors.GroupControl()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtThangTuoi = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbdoituong = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtNgaySinh = New DevExpress.XtraEditors.DateEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbDonMau = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSophieukham = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSophieu = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbNVBH = New DevExpress.XtraEditors.LookUpEdit()
        Me.CmbKhohang = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbbacsykedon = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtchandoanls = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbDonvi = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDiachi = New DevExpress.XtraEditors.TextEdit()
        Me.txtDienThoai = New DevExpress.XtraEditors.TextEdit()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtGioitinh = New DevExpress.XtraEditors.TextEdit()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.DtpNgay = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGhichu = New DevExpress.XtraEditors.MemoEdit()
        Me.Label_SoNgay = New System.Windows.Forms.Label()
        Me.txtSoNgay = New DevExpress.XtraEditors.SpinEdit()
        Me.dtHenKham = New DevExpress.XtraEditors.DateEdit()
        Me.chkHenKham = New DevExpress.XtraEditors.CheckEdit()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_GhiChu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSotien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        CType(Me.txtThangTuoi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbdoituong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaySinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDonMau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieukham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbacsykedon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtchandoanls.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDonvi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiachi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGioitinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHenKham.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHenKham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHenKham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(324, 14)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 13
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(426, 14)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 14
        Me.btnSua.Text = "&Sửa"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(222, 14)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 11
        Me.btnIn.Text = "&In phiếu"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(528, 14)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "&Xoá"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 515)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Lời dặn"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(811, 14)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 17
        Me.btnThoat.Text = "&Thoát"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(18, 14)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "&Nhập mới"
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(120, 14)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 10
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'grdDinh_khoan
        '
        Me.grdDinh_khoan.Location = New System.Drawing.Point(2, 238)
        Me.grdDinh_khoan.MainView = Me.GridView1
        Me.grdDinh_khoan.Name = "grdDinh_khoan"
        Me.grdDinh_khoan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemComboBox1, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemSearchLookUpEdit1, Me.RepositoryItemComboBox_GhiChu})
        Me.grdDinh_khoan.Size = New System.Drawing.Size(897, 264)
        Me.grdDinh_khoan.TabIndex = 1
        Me.grdDinh_khoan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT, Me.colMasp, Me.colTensp, Me.DVT, Me.colSoluong, Me.coldongia, Me.colthanhtien, Me.Collieudung, Me.Colghichu, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.grdDinh_khoan
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSTT
        '
        Me.colSTT.Caption = "STT"
        Me.colSTT.FieldName = "STT"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.OptionsColumn.AllowEdit = False
        Me.colSTT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 0
        Me.colSTT.Width = 34
        '
        'colMasp
        '
        Me.colMasp.Caption = "Mã thuốc"
        Me.colMasp.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colMasp.FieldName = "Masp"
        Me.colMasp.Name = "colMasp"
        Me.colMasp.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMasp.Width = 69
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.CaseSensitiveSearch = True
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("masp", "Mã sản phẩm", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tensp", "Tên sản phẩm", 270, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("toncuoi", "Tồn kho", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "masp"
        Me.RepositoryItemLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.PopupWidth = 395
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "masp"
        '
        'colTensp
        '
        Me.colTensp.Caption = "Tên Thuốc"
        Me.colTensp.ColumnEdit = Me.RepositoryItemSearchLookUpEdit1
        Me.colTensp.FieldName = "Masp"
        Me.colTensp.Name = "colTensp"
        Me.colTensp.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTensp.Visible = True
        Me.colTensp.VisibleIndex = 1
        Me.colTensp.Width = 232
        '
        'RepositoryItemSearchLookUpEdit1
        '
        Me.RepositoryItemSearchLookUpEdit1.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit1.DisplayMember = "tensp"
        Me.RepositoryItemSearchLookUpEdit1.Name = "RepositoryItemSearchLookUpEdit1"
        Me.RepositoryItemSearchLookUpEdit1.NullText = ""
        Me.RepositoryItemSearchLookUpEdit1.PopupView = Me.GridView2
        Me.RepositoryItemSearchLookUpEdit1.ValueMember = "masp"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Mã Sp"
        Me.GridColumn6.FieldName = "masp"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 73
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tên thuốc"
        Me.GridColumn7.FieldName = "tensp"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 227
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tồn cuối"
        Me.GridColumn8.FieldName = "toncuoi"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 64
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Mô tả"
        Me.GridColumn9.FieldName = "mota"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        Me.GridColumn9.Width = 150
        '
        'DVT
        '
        Me.DVT.Caption = "ĐVT"
        Me.DVT.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.DVT.FieldName = "Masp"
        Me.DVT.Name = "DVT"
        Me.DVT.OptionsColumn.AllowEdit = False
        Me.DVT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.DVT.Visible = True
        Me.DVT.VisibleIndex = 8
        Me.DVT.Width = 34
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
        Me.colSoluong.Caption = "S.Lượng"
        Me.colSoluong.FieldName = "Soluong"
        Me.colSoluong.Name = "colSoluong"
        Me.colSoluong.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSoluong.Visible = True
        Me.colSoluong.VisibleIndex = 7
        Me.colSoluong.Width = 50
        '
        'coldongia
        '
        Me.coldongia.Caption = "Đơn giá"
        Me.coldongia.DisplayFormat.FormatString = "###,###,###.###"
        Me.coldongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldongia.FieldName = "Dongia"
        Me.coldongia.Name = "coldongia"
        Me.coldongia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.coldongia.Width = 67
        '
        'colthanhtien
        '
        Me.colthanhtien.Caption = "Thành tiền"
        Me.colthanhtien.DisplayFormat.FormatString = "###,###,###.###"
        Me.colthanhtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colthanhtien.FieldName = "thanhtien"
        Me.colthanhtien.Name = "colthanhtien"
        Me.colthanhtien.OptionsColumn.AllowEdit = False
        Me.colthanhtien.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colthanhtien.Width = 97
        '
        'Collieudung
        '
        Me.Collieudung.Caption = "Liều dùng"
        Me.Collieudung.ColumnEdit = Me.RepositoryItemComboBox1
        Me.Collieudung.FieldName = "Lieudung"
        Me.Collieudung.Name = "Collieudung"
        Me.Collieudung.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Collieudung.Visible = True
        Me.Collieudung.VisibleIndex = 9
        Me.Collieudung.Width = 158
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Colghichu
        '
        Me.Colghichu.Caption = "Ghi chú"
        Me.Colghichu.ColumnEdit = Me.RepositoryItemComboBox_GhiChu
        Me.Colghichu.FieldName = "Ghichu"
        Me.Colghichu.Name = "Colghichu"
        Me.Colghichu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Colghichu.Visible = True
        Me.Colghichu.VisibleIndex = 10
        Me.Colghichu.Width = 163
        '
        'RepositoryItemComboBox_GhiChu
        '
        Me.RepositoryItemComboBox_GhiChu.AutoHeight = False
        Me.RepositoryItemComboBox_GhiChu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_GhiChu.Name = "RepositoryItemComboBox_GhiChu"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Sáng"
        Me.GridColumn1.FieldName = "Sang"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 39
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Trưa"
        Me.GridColumn2.FieldName = "Trua"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 34
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Chiều"
        Me.GridColumn3.FieldName = "Chieu"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 35
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tối"
        Me.GridColumn4.FieldName = "Toi"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 30
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ĐV Sử dụng"
        Me.GridColumn5.FieldName = "DonViSuDung"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        Me.GridColumn5.Width = 70
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("masp", "Mã sản phẩm", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tensp", "Tên sản phẩm", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("toncuoi", "Tồn kho", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mota", "Mô tả", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "tensp"
        Me.RepositoryItemLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.PopupWidth = 500
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "masp"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lieudung", "Liều dùng")})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Lieudung"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.PopupWidth = 350
        Me.RepositoryItemLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit4.ValueMember = "Lieudung"
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "donvisudung"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.ValueMember = "masp"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(900, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ĐƠN THUỐC"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnXuatthuoc
        '
        Me.btnXuatthuoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXuatthuoc.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXuatthuoc.Appearance.Options.UseFont = True
        Me.btnXuatthuoc.Appearance.Options.UseForeColor = True
        Me.btnXuatthuoc.Location = New System.Drawing.Point(804, 205)
        Me.btnXuatthuoc.Name = "btnXuatthuoc"
        Me.btnXuatthuoc.Size = New System.Drawing.Size(88, 25)
        Me.btnXuatthuoc.TabIndex = 17
        Me.btnXuatthuoc.Text = "&Xuất thuốc"
        '
        'txtSotien
        '
        Me.txtSotien.EditValue = "0"
        Me.txtSotien.Location = New System.Drawing.Point(529, 205)
        Me.txtSotien.Name = "txtSotien"
        Me.txtSotien.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSotien.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSotien.Properties.Appearance.Options.UseBackColor = True
        Me.txtSotien.Properties.Appearance.Options.UseFont = True
        Me.txtSotien.Properties.AutoHeight = False
        Me.txtSotien.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSotien.Size = New System.Drawing.Size(111, 23)
        Me.txtSotien.TabIndex = 58
        Me.txtSotien.Tag = "TienUSD"
        Me.txtSotien.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(456, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Tổng tiền:"
        Me.Label5.Visible = False
        '
        'btnBoxoa
        '
        Me.btnBoxoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnBoxoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBoxoa.Appearance.Options.UseFont = True
        Me.btnBoxoa.Appearance.Options.UseForeColor = True
        Me.btnBoxoa.Location = New System.Drawing.Point(528, 14)
        Me.btnBoxoa.Name = "btnBoxoa"
        Me.btnBoxoa.Size = New System.Drawing.Size(75, 25)
        Me.btnBoxoa.TabIndex = 59
        Me.btnBoxoa.Text = "&Bỏ xóa"
        '
        'Grb
        '
        Me.Grb.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Grb.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Grb.AppearanceCaption.Options.UseFont = True
        Me.Grb.AppearanceCaption.Options.UseForeColor = True
        Me.Grb.Controls.Add(Me.Label18)
        Me.Grb.Controls.Add(Me.txtThangTuoi)
        Me.Grb.Controls.Add(Me.Label16)
        Me.Grb.Controls.Add(Me.cmbdoituong)
        Me.Grb.Controls.Add(Me.dtNgaySinh)
        Me.Grb.Controls.Add(Me.Label15)
        Me.Grb.Controls.Add(Me.cmbDonMau)
        Me.Grb.Controls.Add(Me.Label11)
        Me.Grb.Controls.Add(Me.txtSophieukham)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Controls.Add(Me.Label10)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.Label8)
        Me.Grb.Controls.Add(Me.txtSophieu)
        Me.Grb.Controls.Add(Me.Label12)
        Me.Grb.Controls.Add(Me.CmbNVBH)
        Me.Grb.Controls.Add(Me.CmbKhohang)
        Me.Grb.Controls.Add(Me.cmbbacsykedon)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Controls.Add(Me.Txtchandoanls)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Controls.Add(Me.GroupBox1)
        Me.Grb.Controls.Add(Me.Label13)
        Me.Grb.Controls.Add(Me.Label14)
        Me.Grb.Controls.Add(Me.cmbDonvi)
        Me.Grb.Controls.Add(Me.txtDiachi)
        Me.Grb.Controls.Add(Me.txtDienThoai)
        Me.Grb.Controls.Add(Me.Label24)
        Me.Grb.Controls.Add(Me.Label25)
        Me.Grb.Controls.Add(Me.txtGioitinh)
        Me.Grb.Controls.Add(Me.Label30)
        Me.Grb.Controls.Add(Me.Label31)
        Me.Grb.Controls.Add(Me.DtpNgay)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grb.Location = New System.Drawing.Point(0, 34)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(900, 165)
        Me.Grb.TabIndex = 61
        Me.Grb.Text = "Thông tin bệnh nhân"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(690, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "Tháng tuổi"
        '
        'txtThangTuoi
        '
        Me.txtThangTuoi.EditValue = ""
        Me.txtThangTuoi.Location = New System.Drawing.Point(765, 51)
        Me.txtThangTuoi.Name = "txtThangTuoi"
        Me.txtThangTuoi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtThangTuoi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThangTuoi.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtThangTuoi.Properties.Appearance.Options.UseBackColor = True
        Me.txtThangTuoi.Properties.Appearance.Options.UseFont = True
        Me.txtThangTuoi.Properties.Appearance.Options.UseForeColor = True
        Me.txtThangTuoi.Properties.Appearance.Options.UseTextOptions = True
        Me.txtThangTuoi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtThangTuoi.Properties.AutoHeight = False
        Me.txtThangTuoi.Properties.ReadOnly = True
        Me.txtThangTuoi.Size = New System.Drawing.Size(125, 23)
        Me.txtThangTuoi.TabIndex = 131
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(690, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Đối tượng"
        '
        'cmbdoituong
        '
        Me.cmbdoituong.Location = New System.Drawing.Point(766, 26)
        Me.cmbdoituong.Name = "cmbdoituong"
        Me.cmbdoituong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbdoituong.Properties.Appearance.Options.UseFont = True
        Me.cmbdoituong.Properties.AutoHeight = False
        Me.cmbdoituong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbdoituong.Properties.NullText = ""
        Me.cmbdoituong.Properties.PopupSizeable = False
        Me.cmbdoituong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbdoituong.Size = New System.Drawing.Size(124, 22)
        Me.cmbdoituong.TabIndex = 97
        '
        'dtNgaySinh
        '
        Me.dtNgaySinh.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.dtNgaySinh.Location = New System.Drawing.Point(570, 51)
        Me.dtNgaySinh.Name = "dtNgaySinh"
        Me.dtNgaySinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtNgaySinh.Properties.Appearance.Options.UseFont = True
        Me.dtNgaySinh.Properties.AutoHeight = False
        Me.dtNgaySinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtNgaySinh.Size = New System.Drawing.Size(112, 22)
        Me.dtNgaySinh.TabIndex = 96
        Me.dtNgaySinh.Tag = "Ngay"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(588, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 16)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Đơn thuốc mẫu"
        '
        'cmbDonMau
        '
        Me.cmbDonMau.Location = New System.Drawing.Point(696, 135)
        Me.cmbDonMau.Name = "cmbDonMau"
        Me.cmbDonMau.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbDonMau.Properties.Appearance.Options.UseFont = True
        Me.cmbDonMau.Properties.AutoHeight = False
        Me.cmbDonMau.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDonMau.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Mã", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonThuocMau", "Tên đơn mẫu")})
        Me.cmbDonMau.Properties.NullText = ""
        Me.cmbDonMau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDonMau.Size = New System.Drawing.Size(194, 22)
        Me.cmbDonMau.TabIndex = 94
        Me.cmbDonMau.Tag = "Bacsykedon"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(588, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Người lập"
        '
        'txtSophieukham
        '
        Me.txtSophieukham.EditValue = ""
        Me.txtSophieukham.Location = New System.Drawing.Point(109, 87)
        Me.txtSophieukham.Name = "txtSophieukham"
        Me.txtSophieukham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSophieukham.Properties.Appearance.Options.UseFont = True
        Me.txtSophieukham.Properties.AutoHeight = False
        Me.txtSophieukham.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSophieukham.Size = New System.Drawing.Size(80, 22)
        Me.txtSophieukham.TabIndex = 81
        Me.txtSophieukham.Tag = "Sophieukham"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Số hồ sơ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(673, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 17)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(89, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 17)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(588, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Quầy thuốc"
        '
        'txtSophieu
        '
        Me.txtSophieu.EditValue = ""
        Me.txtSophieu.Location = New System.Drawing.Point(262, 87)
        Me.txtSophieu.Name = "txtSophieu"
        Me.txtSophieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSophieu.Properties.Appearance.Options.UseFont = True
        Me.txtSophieu.Properties.AutoHeight = False
        Me.txtSophieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSophieu.Size = New System.Drawing.Size(66, 22)
        Me.txtSophieu.TabIndex = 84
        Me.txtSophieu.Tag = "Sophieu"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "B.Sỹ kê đơn"
        '
        'CmbNVBH
        '
        Me.CmbNVBH.Location = New System.Drawing.Point(696, 111)
        Me.CmbNVBH.Name = "CmbNVBH"
        Me.CmbNVBH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmbNVBH.Properties.Appearance.Options.UseFont = True
        Me.CmbNVBH.Properties.AutoHeight = False
        Me.CmbNVBH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbNVBH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Tên nhân viên", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbNVBH.Properties.NullText = ""
        Me.CmbNVBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbNVBH.Size = New System.Drawing.Size(194, 22)
        Me.CmbNVBH.TabIndex = 82
        Me.CmbNVBH.Tag = "Nguoinhap"
        '
        'CmbKhohang
        '
        Me.CmbKhohang.AllowDrop = True
        Me.CmbKhohang.Location = New System.Drawing.Point(696, 87)
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
        Me.CmbKhohang.Size = New System.Drawing.Size(194, 22)
        Me.CmbKhohang.TabIndex = 85
        Me.CmbKhohang.Tag = "Makho"
        '
        'cmbbacsykedon
        '
        Me.cmbbacsykedon.Location = New System.Drawing.Point(109, 111)
        Me.cmbbacsykedon.Name = "cmbbacsykedon"
        Me.cmbbacsykedon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbbacsykedon.Properties.Appearance.Options.UseFont = True
        Me.cmbbacsykedon.Properties.AutoHeight = False
        Me.cmbbacsykedon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbacsykedon.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Họ tên", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbbacsykedon.Properties.NullText = ""
        Me.cmbbacsykedon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbbacsykedon.Size = New System.Drawing.Size(219, 22)
        Me.cmbbacsykedon.TabIndex = 83
        Me.cmbbacsykedon.Tag = "Bacsykedon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(196, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Số phiếu"
        '
        'Txtchandoanls
        '
        Me.Txtchandoanls.EditValue = ""
        Me.Txtchandoanls.Location = New System.Drawing.Point(109, 135)
        Me.Txtchandoanls.Name = "Txtchandoanls"
        Me.Txtchandoanls.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txtchandoanls.Properties.Appearance.Options.UseFont = True
        Me.Txtchandoanls.Properties.AutoHeight = False
        Me.Txtchandoanls.Size = New System.Drawing.Size(399, 22)
        Me.Txtchandoanls.TabIndex = 80
        Me.Txtchandoanls.Tag = "ChandoanLS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Chẩn đoán"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(2, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 3)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(89, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 17)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Bệnh nhân"
        '
        'cmbDonvi
        '
        Me.cmbDonvi.AllowDrop = True
        Me.cmbDonvi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbDonvi.Location = New System.Drawing.Point(109, 26)
        Me.cmbDonvi.Name = "cmbDonvi"
        Me.cmbDonvi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbDonvi.Properties.Appearance.Options.UseFont = True
        Me.cmbDonvi.Properties.AutoHeight = False
        Me.cmbDonvi.Properties.AutoSearchColumnIndex = 1
        Me.cmbDonvi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDonvi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbDonvi.Properties.NullText = ""
        Me.cmbDonvi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDonvi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDonvi.Size = New System.Drawing.Size(219, 22)
        Me.cmbDonvi.TabIndex = 0
        Me.cmbDonvi.Tag = "Mabn"
        '
        'txtDiachi
        '
        Me.txtDiachi.EditValue = ""
        Me.txtDiachi.Location = New System.Drawing.Point(410, 26)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDiachi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDiachi.Properties.Appearance.Options.UseBackColor = True
        Me.txtDiachi.Properties.Appearance.Options.UseFont = True
        Me.txtDiachi.Properties.AutoHeight = False
        Me.txtDiachi.Properties.ReadOnly = True
        Me.txtDiachi.Size = New System.Drawing.Size(272, 22)
        Me.txtDiachi.TabIndex = 64
        Me.txtDiachi.Tag = ""
        '
        'txtDienThoai
        '
        Me.txtDienThoai.EditValue = ""
        Me.txtDienThoai.Location = New System.Drawing.Point(109, 51)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDienThoai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDienThoai.Properties.Appearance.Options.UseBackColor = True
        Me.txtDienThoai.Properties.Appearance.Options.UseFont = True
        Me.txtDienThoai.Properties.AutoHeight = False
        Me.txtDienThoai.Properties.ReadOnly = True
        Me.txtDienThoai.Size = New System.Drawing.Size(219, 22)
        Me.txtDienThoai.TabIndex = 65
        Me.txtDienThoai.Tag = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(344, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 16)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Địa chỉ"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(8, 52)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 16)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Điện thoại"
        '
        'txtGioitinh
        '
        Me.txtGioitinh.EditValue = ""
        Me.txtGioitinh.Location = New System.Drawing.Point(410, 51)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtGioitinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtGioitinh.Properties.Appearance.Options.UseBackColor = True
        Me.txtGioitinh.Properties.Appearance.Options.UseFont = True
        Me.txtGioitinh.Properties.AutoHeight = False
        Me.txtGioitinh.Properties.ReadOnly = True
        Me.txtGioitinh.Size = New System.Drawing.Size(71, 22)
        Me.txtGioitinh.TabIndex = 67
        Me.txtGioitinh.Tag = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(494, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 16)
        Me.Label30.TabIndex = 73
        Me.Label30.Text = "Ngày sinh"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(344, 54)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(54, 16)
        Me.Label31.TabIndex = 72
        Me.Label31.Text = "Giới tính"
        '
        'DtpNgay
        '
        Me.DtpNgay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.DtpNgay.Location = New System.Drawing.Point(403, 111)
        Me.DtpNgay.Name = "DtpNgay"
        Me.DtpNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DtpNgay.Properties.Appearance.Options.UseFont = True
        Me.DtpNgay.Properties.AutoHeight = False
        Me.DtpNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtpNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DtpNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DtpNgay.Size = New System.Drawing.Size(105, 22)
        Me.DtpNgay.TabIndex = 68
        Me.DtpNgay.Tag = "Ngay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(339, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Ngày kê"
        '
        'txtGhichu
        '
        Me.txtGhichu.EditValue = ""
        Me.txtGhichu.Location = New System.Drawing.Point(91, 508)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Size = New System.Drawing.Size(795, 49)
        Me.txtGhichu.TabIndex = 2
        Me.txtGhichu.Tag = "Ghichu"
        '
        'Label_SoNgay
        '
        Me.Label_SoNgay.AutoSize = True
        Me.Label_SoNgay.BackColor = System.Drawing.Color.Transparent
        Me.Label_SoNgay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SoNgay.ForeColor = System.Drawing.Color.Red
        Me.Label_SoNgay.Location = New System.Drawing.Point(38, 208)
        Me.Label_SoNgay.Name = "Label_SoNgay"
        Me.Label_SoNgay.Size = New System.Drawing.Size(59, 16)
        Me.Label_SoNgay.TabIndex = 62
        Me.Label_SoNgay.Text = "Số ngày:"
        '
        'txtSoNgay
        '
        Me.txtSoNgay.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtSoNgay.Location = New System.Drawing.Point(109, 205)
        Me.txtSoNgay.Name = "txtSoNgay"
        Me.txtSoNgay.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSoNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSoNgay.Properties.Appearance.Options.UseBackColor = True
        Me.txtSoNgay.Properties.Appearance.Options.UseFont = True
        Me.txtSoNgay.Properties.AutoHeight = False
        Me.txtSoNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSoNgay.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtSoNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtSoNgay.Size = New System.Drawing.Size(76, 23)
        Me.txtSoNgay.TabIndex = 63
        Me.txtSoNgay.Tag = "TienUSD"
        '
        'dtHenKham
        '
        Me.dtHenKham.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.dtHenKham.Location = New System.Drawing.Point(320, 205)
        Me.dtHenKham.Name = "dtHenKham"
        Me.dtHenKham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtHenKham.Properties.Appearance.Options.UseFont = True
        Me.dtHenKham.Properties.AutoHeight = False
        Me.dtHenKham.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtHenKham.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtHenKham.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtHenKham.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtHenKham.Size = New System.Drawing.Size(112, 23)
        Me.dtHenKham.TabIndex = 100
        Me.dtHenKham.Tag = "Ngay"
        Me.dtHenKham.Visible = False
        '
        'chkHenKham
        '
        Me.chkHenKham.Location = New System.Drawing.Point(217, 206)
        Me.chkHenKham.Name = "chkHenKham"
        Me.chkHenKham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHenKham.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkHenKham.Properties.Appearance.Options.UseFont = True
        Me.chkHenKham.Properties.Appearance.Options.UseForeColor = True
        Me.chkHenKham.Properties.Caption = "Hẹn khám lại"
        Me.chkHenKham.Size = New System.Drawing.Size(99, 20)
        Me.chkHenKham.TabIndex = 107
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnIn)
        Me.Panel_Button.Controls.Add(Me.btnBoxoa)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 563)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(900, 51)
        Me.Panel_Button.TabIndex = 108
        '
        'frm_kedonthuoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 614)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.chkHenKham)
        Me.Controls.Add(Me.dtHenKham)
        Me.Controls.Add(Me.Label_SoNgay)
        Me.Controls.Add(Me.Grb)
        Me.Controls.Add(Me.txtSotien)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grdDinh_khoan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnXuatthuoc)
        Me.Controls.Add(Me.txtGhichu)
        Me.Controls.Add(Me.txtSoNgay)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(916, 653)
        Me.MinimumSize = New System.Drawing.Size(916, 653)
        Me.Name = "frm_kedonthuoc"
        Me.Text = "KÊ ĐƠN THUỐC"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_GhiChu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSotien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.txtThangTuoi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbdoituong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaySinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDonMau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieukham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbacsykedon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtchandoanls.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDonvi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiachi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGioitinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHenKham.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHenKham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHenKham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frm_kedonthuoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.DtpNgay.DateTime = NgayGioServer()
        Me.DtpNgay.Enabled = False
        If txtSophieukham.Text.Trim <> "-1" And txtSophieukham.Text.Trim <> "0" And txtSophieukham.Text.Trim <> "" Then
            get_IDPhieuxuat()
        End If
        Load_Data()
        Form_Initial()
        Ctrl_QuyenForm(Me)
        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True

        If IDPhieuxuat <> 0 Then
            Me.btnThem.Enabled = False
            Me.btnIn.Enabled = True
            Me.GroupBox1.Enabled = True
            Me.btnThoat.Enabled = True
            Me.DtpNgay.Enabled = True
            Me.grdDinh_khoan.Enabled = False
            Me.btnXuatthuoc.Enabled = True
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Them)
            Me.btnSua.Enabled = False
            Me.btnXoa.Enabled = False
            Me.GroupBox1.Enabled = False
            Me.btnXuatthuoc.Enabled = False
        End If
        If blnDelete = True Then
            Me.btnSua.Enabled = False
            Me.btnXoa.Enabled = False
            Me.btnBoxoa.Visible = True
            Me.btnBoxoa.Enabled = True
            Me.btnXoa.Visible = False
            Me.GroupBox1.Enabled = False
        Else
            Me.btnBoxoa.Visible = False
            Me.btnXoa.Visible = True
        End If
        stype = True
        Me.Label1.Enabled = True
        Me.grdDinh_khoan.Enabled = True
        If BS = True Then
            Me.btnXuatthuoc.Enabled = False
        Else
            If i_status = 1 Then
                Me.btnXuatthuoc.Enabled = False
            Else
                Me.btnXuatthuoc.Enabled = True
            End If
        End If
        Label_SoNgay.Enabled = True
        txtSoNgay.Enabled = True
        chkHenKham.Enabled = True
        dtHenKham.Enabled = True
    End Sub

    Private Sub get_IDPhieuxuat()
        Dim sql As String = String.Format("Select IDphieu From Tb_Kedonthuoc Where Sophieukham='{0}'", txtSophieukham.Text)
        Dim dt As DataTable = New DataTable()
        dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dt.Rows.Count > 0 Then
            IDPhieuxuat = Integer.Parse(dt.Rows(0)("IDphieu").ToString())
        Else
            IDPhieuxuat = 0
        End If
    End Sub

    Private Sub Form_Initial()
        Dim clsObjPxn As New clsFrm_kedonthuoc
        Dim dtbxn As New DataTable
        Load_ComboBox("SELECT MABN,HOTENBN From HOSOBN order by MABN desc", Me.cmbDonvi, CNNQLPHONGKHAM, True)
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang order by Tenkho", Me.CmbKhohang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.cmbbacsykedon, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.CmbNVBH, CNNQLPHONGKHAM, True)
        Load_ComboBox(String.Format("SELECT ID,TenDonThuocMau FROM Dm_DonThuocMau"), Me.cmbDonMau, CNNQLPHONGKHAM)
        Load_ComboBox("Select id[Mã],doituong[Đối tượng] from DM_DOITUONG", cmbdoituong, CNNQLPHONGKHAM)

        Me.CmbNVBH.EditValue = clsLoginObj.strUsername
        Me.cmbbacsykedon.EditValue = clsLoginObj.strUsername
        Me.CmbNVBH.Enabled = False
        Dim dt As New DataTable
        dt = BusinessLogic.Data.GetDataset("proc_GetListkedon", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
        Me.RepositoryItemLookUpEdit1.DataSource = dt
        Me.RepositoryItemLookUpEdit2.DataSource = dt
        Me.RepositoryItemLookUpEdit3.DataSource = dt
        Me.RepositoryItemLookUpEdit5.DataSource = dt
        Me.RepositoryItemSearchLookUpEdit1.DataSource = dt
        If IDPhieuxuat <> 0 Then
            Pre_CTPXNLLoad()
        Else
            Me.txtSophieu.Text = clsObjPxn.Lay_So_phieu()
            Pre_CTPXNLLoad()
        End If
        '================
        dt = BusinessLogic.Data.GetDataset("Select Lieudung from DM_Lieudung").Tables(0)
        Dim dr As DataRow
        For Each dr In dt.Rows
            Me.RepositoryItemComboBox1.Items.Add(dr("Lieudung"))
        Next
        '================
        dt = BusinessLogic.Data.GetDataset("SELECT GhiChu FROM Dm_GhiChu").Tables(0)
        For Each dr In dt.Rows
            Me.RepositoryItemComboBox_GhiChu.Items.Add(dr("GhiChu"))
        Next
    End Sub

    Private Sub Load_Data()
        Dim dtbPXN As New DataTable
        Dim dtbtk As New DataTable
        Dim dtbkho As New DataTable
        Dim strSql As String
        strSql = String.Format("SELECT t.*,p.Henkham,p.Ngayhenkham FROM Tb_KeDonThuoc t JOIN PhieuKhamBenh p ON t.Sophieukham=p.SoPhieu WHERE t.IDPhieu={0}", IDPhieuxuat)
        dtbPXN = BusinessLogic.Data.GetDataset(strSql).Tables(0)
        If dtbPXN.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbPXN.Rows(0)
            cmbDonvi.EditValue = row(Me.cmbDonvi.Tag)
            Madv = row(Me.cmbDonvi.Tag)
            CmbNVBH.EditValue = row(Me.CmbNVBH.Tag)
            CmbKhohang.EditValue = row(Me.CmbKhohang.Tag)
            cmbbacsykedon.EditValue = row(Me.cmbbacsykedon.Tag)
            txtGhichu.Text = row(Me.txtGhichu.Tag)
            txtSophieu.Text = row(Me.txtSophieu.Tag)
            txtSophieukham.Text = row(Me.txtSophieukham.Tag)
            DtpNgay.DateTime = row(Me.DtpNgay.Tag)
            If Not row("sotien") Is DBNull.Value Then
                txtSotien.Text = row("sotien").ToString()
            End If
            If Not dtbPXN.Rows(0)("ChandoanLS") Is DBNull.Value Then
                Txtchandoanls.Text = dtbPXN.Rows(0)("ChandoanLS").ToString()
            End If
            If Not row("SoNgay") Is DBNull.Value Then
                txtSoNgay.EditValue = dtbPXN.Rows(0)("SoNgay")
            End If
            If Not dtbPXN.Rows(0)("i_status") Is DBNull.Value Then
                i_status = dtbPXN.Rows(0)("i_status")
            End If
            If Not row("Henkham") Is DBNull.Value Then
                chkHenKham.Checked = Convert.ToBoolean(row("Henkham"))
            Else
                chkHenKham.Checked = False
            End If
            If Not row("Ngayhenkham") Is DBNull.Value Then
                dtHenKham.DateTime = row("Ngayhenkham")
            End If
            cmbdoituong.EditValue = Integer.Parse(MdlCommon.DoiTuong.DICHVU)
            'If txtSophieukham.Text.Trim <> "-1" And txtSophieukham.Text.Trim <> "0" And txtSophieukham.Text.Trim <> "" Then
            '    dtbPXN = BusinessLogic.Data.GetDataset("select Doituong from phieukhambenh where sophieu='" & txtSophieukham.Text & "'").Tables(0)
            '    If dtbPXN.Rows.Count > 0 Then
            '        If Not dtbPXN(0)("Doituong") Is DBNull.Value Then
            '            cmbdoituong.EditValue = dtbPXN(0)("Doituong")
            '        Else
            '            cmbdoituong.EditValue = 1 'dich vu
            '        End If
            '    End If
            'End If
        End If
        '===
        If IDPhieuxuat = 0 Then
            Me.btnXoa.Enabled = False
        End If
    End Sub

    Private Sub CTPXFill()

    End Sub

    Private Sub Pre_CTPXNLLoad()
        Dim strSQL As String
        strSQL = "SELECT ID,IDsophieu,Masp,Soluong,Dongia,thanhtien,Lieudung,Ghichu,STT,Isnull(Sang,0) as Sang,Isnull(Trua,0) as Trua,Isnull(Chieu,0) as Chieu,Isnull(Toi,0) as Toi,(Select DonViSuDung FROM San_Pham Where Masp=Tb_Kedonthuoc_chitiet.Masp) as DonViSuDung "
        strSQL &= "FROM Tb_Kedonthuoc_chitiet WHERE IDsophieu =" & IDPhieuxuat & " order by id "
        dtb_PreCTPXN = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        dtv_PreCTPXN = dtb_PreCTPXN.DefaultView
        grdDinh_khoan.DataSource = dtb_PreCTPXN
    End Sub

    Private Sub TongUSD()
        Dim objclsPXN As New clsFrmPhieuXNKedonthuoc
        objclsPXN.GetTotal_donthuoc(Me)
        objclsPXN = Nothing
    End Sub

    Private Function CheckValidation() As Boolean
        Dim clsObjFrmXN As New clsFrm_kedonthuoc
        Return clsObjFrmXN.FrmCheckValide(Me)
    End Function

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim i As Int16
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString)
        Try
            row("Dongia") = laygia(row("Masp"))
            row("DonViSuDung") = laydonvisudung(row("Masp"))
        Catch ex As Exception

        End Try
        Try
            If (e.Column.FieldName = "Sang") Or (e.Column.FieldName = "Trua") Or (e.Column.FieldName = "Chieu") Or (e.Column.FieldName = "Toi") Then
                If (IsNumeric(row("Sang")) And IsNumeric(row("Trua")) And IsNumeric(row("Chieu")) And IsNumeric(row("Toi")) And IsNumeric(txtSoNgay.EditValue)) Then
                    row("SoLuong") = (Double.Parse(row("Sang").ToString()) + Double.Parse(row("Trua").ToString()) + Double.Parse(row("Chieu").ToString()) + Double.Parse(row("Toi").ToString())) * Double.Parse(txtSoNgay.EditValue.ToString())
                    Dim str As String = ""
                    If Double.Parse(row("Sang").ToString()) > 0 Then
                        str += "Sáng " + row("Sang").ToString() + " " + row("DonViSuDung").ToString()
                    End If
                    If Double.Parse(row("Trua").ToString()) > 0 Then
                        str += ",trưa " + row("Trua").ToString() + " " + row("DonViSuDung").ToString()
                    End If
                    If Double.Parse(row("Chieu").ToString()) > 0 Then
                        str += ",chiều " + row("Chieu").ToString() + " " + row("DonViSuDung").ToString()
                    End If
                    If Double.Parse(row("Toi").ToString()) > 0 Then
                        str += ",tối " + row("Toi").ToString() + " " + row("DonViSuDung").ToString()
                    End If
                    row("Lieudung") = str
                End If
            End If
            If (e.Column.FieldName = "Soluong") Or (e.Column.FieldName = "Dongia") Then
                If (IsNumeric(row("Soluong")) And IsNumeric(row("Dongia"))) Then
                    row("Thanhtien") = row("Soluong") * row("Dongia")
                End If
            End If
        Catch ex As Exception

        End Try
        Try
            For i = 0 To Me.GridView1.RowCount - 2
                If (IsNumeric(row("Soluong")) And IsNumeric(row("Dongia"))) Then
                    row("Thanhtien") = row("Soluong") * row("Dongia")
                End If
            Next
        Catch ex As Exception
        End Try
        TongUSD()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Public Sub FormClear()
        Dim objclsPXN As New clsFrm_kedonthuoc
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
            If dtvCTPXN(int_i)("Masp") = Masp And int_i <> rowid Then
                Return True
            Else
                Return True
            End If
        Next
    End Function

#Region "Xu ly cac su kien cua dieu khien"
    Private Sub CmbKhohang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dt As New DataTable
        If frmState = False Then
            Dim clsobjPXN As New clsXNKho
            dt = BusinessLogic.Data.GetDataset("proc_GetListkedon", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
            Me.RepositoryItemLookUpEdit1.DataSource = dt
            Me.RepositoryItemLookUpEdit2.DataSource = dt
            Me.RepositoryItemLookUpEdit3.DataSource = dt
            Me.RepositoryItemSearchLookUpEdit1.DataSource = dt
        End If
        Me.txtGhichu.Text = ""
        Me.grdDinh_khoan.DataSource = BusinessLogic.Data.GetDataset("Select * FROM Tb_kedonthuoc_chitiet WHERE IDSophieu=" & IDPhieuxuat & "").Tables(0)
    End Sub

    Private Sub cmbLoai_xuat_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If foundClick = False Then
            sender.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    Private Sub CmbKhohang_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If foundClick = False Then
            CmbKhohang.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    Private Sub cmbDonvi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If foundClick = False Then
            sender.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        grdDinh_khoan.Enabled = True
        txtGhichu.Enabled = True
        btnIn.Enabled = False
        CmbNVBH.Enabled = False
        GroupBox1.Enabled = False
        btnXuatthuoc.Enabled = False
        Label_SoNgay.Enabled = True
        txtSoNgay.Enabled = True
        chkHenKham.Enabled = True
        dtHenKham.Enabled = True
        StypeSUA = True
        blnType = False
    End Sub

    Private Sub cmbDonvi_keyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If sender Is cmbDonvi Then
            If e.KeyCode = Keys.F3 Then
                Dim frmKh As New frmThemDonVi
                frmKh.ShowDialog()
                If frmKh.Key = True Then
                    Load_ComboBox("Select Madv,Email As MaBN,Tendv From Don_vi order by MaBN,Tendv", Me.cmbDonvi, CNNQLPHONGKHAM)
                    Me.cmbDonvi.EditValue = frmKh.IDmoi
                End If
            ElseIf e.KeyCode = Keys.Delete Then
                Me.cmbDonvi.EditValue = ""
            ElseIf e.KeyCode = Keys.Enter Then
                ' Me.cmbMakh.Focus()
            End If
        End If
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
            Dim Soluong As Int32 = 0
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
            If blnType = True Then
                INSERT()
                'If cmbdoituong.EditValue = 0 Then ' xuat cho BHYT
                '    AddNewEntry()
                'End If
            Else
                UPDATA()
                'If cmbdoituong.EditValue = 0 Then ' xuat cho BHYT
                '    AddNewEntry()
                'End If
            End If
            Try
                'Cap nhat ngay hen kham khi thay doi so ngay uong thuoc
                strSQL = String.Format("UPDATE PhieuKhamBenh SET Henkham={0},Ngayhenkham='{1}' WHERE SoPhieu='{2}'", IIf(chkHenKham.Checked, 1, 0), dtHenKham.DateTime, txtSophieukham.Text)
                If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                    ngayHenKham = dtHenKham.DateTime
                    isHenKham = chkHenKham.Checked
                End If
            Catch ex As Exception

            End Try
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
        If BS = True Then
            Me.btnXuatthuoc.Enabled = True 'False
        Else
            Me.btnXuatthuoc.Enabled = True
        End If
        Me.GroupBox1.Enabled = True
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
            TongUSD()
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim dtbkho As New DataTable
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        Dim _sophieukham As String
        If txtSophieukham.Text.Trim = "-1" Then
            _sophieukham = "-1"
        ElseIf txtSophieukham.Text.Trim = "0" Then
            _sophieukham = "0"
        ElseIf txtSophieukham.Text.Trim = "" Then
            _sophieukham = ""
        Else
            _sophieukham = txtSophieukham.Text.Trim()
        End If
        'FormClear()
        Me.CmbKhohang.EditValue = "KT"
        txtSophieukham.Text = _sophieukham
        If _sophieukham <> "-1" And _sophieukham <> "0" And _sophieukham <> "" Then
            get_IDPhieuxuat()
        Else
            FormClear()
        End If

        frmState = False
        Me.DtpNgay.DateTime = NgayGioServer()
        Me.DtpNgay.Enabled = False
        Me.txtSophieu.Enabled = False
        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnIn.Enabled = False
        Me.CmbNVBH.Enabled = False
        CTPXFill()
        k = 0
        Me.btnXuatthuoc.Enabled = False
        txtSoNgay.EditValue = 1
    End Sub
#End Region

    Private Sub INSERT()
        Dim Bolean As Boolean = False
        Me.GridView1.UpdateCurrentRow()
        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim sql As String = ""
        Dim int_IDSophieu As Int32 = 0
        Dim ofjec As New clsFrm_kedonthuoc
        Me.txtSophieu.Text = ofjec.Lay_So_phieu()
        Dim cls As clsKeDonThuoc = New clsKeDonThuoc()
        int_IDSophieu = cls.kedonthuoc_add(cmbDonvi.EditValue, txtSophieukham.Text, Me.txtSophieu.Text, cmbbacsykedon.EditValue, txtGhichu.Text, DtpNgay.DateTime, CmbNVBH.EditValue, CmbKhohang.EditValue, Txtchandoanls.Text, Double.Parse("0" + Chuanhoa(Me.txtSotien.Text)), PhongKham, txtSoNgay.EditValue)
        If int_IDSophieu > 0 Then
            txtSophieu.Text = int_IDSophieu
            Dim strID As String = "Select IDPhieu From Tb_Kedonthuoc Where Sophieu='" & int_IDSophieu & "'"
            Dim dtbID As New DataTable
            dtbID = BusinessLogic.Data.GetDataset(strID).Tables(0)
            int_IDSophieu = dtbID.Rows(0)("IDPhieu")
            IDPhieuxuat = int_IDSophieu
            If IDPhieuxuat <> 0 Then
                dtv = Me.GridView1.DataSource
                dtbCTXN = dtv.Table
                If Not dtbCTXN Is Nothing Then
                    For Each r As DataRow In dtbCTXN.Rows
                        If r.RowState <> DataRowState.Deleted Then
                            sql = "INSERT INTO Tb_Kedonthuoc_chitiet(IDsophieu,Masp,Soluong,Dongia,thanhtien,Lieudung,Ghichu,Thanhtien2,STT,b_Ex,Sang,Trua,Chieu,Toi)"
                            sql &= "VALUES(" & int_IDSophieu & ",'" & r("Masp") & "'," & r("Soluong") & "," & Double.Parse("0" + r("Dongia").ToString()) & "," & Double.Parse("0" + r("thanhtien").ToString()) & ",N'" & r("Lieudung").ToString() & "',N'" & r("Ghichu").ToString() & "',NULL," & r("STT") & ",NULL," & r("Sang") & "," & r("Trua") & "," & r("Chieu") & "," & r("Toi") & ")"
                            BusinessLogic.Data.Insert(sql)
                        End If
                    Next
                End If
            End If
            Me.btnCap_nhat.Enabled = False
        Else
            MessageBox.Show("Có lỗi xảy ra...!")
        End If
    End Sub

    Private Sub UPDATA()
        Me.GridView1.UpdateCurrentRow()
        Dim dtbCTXN As New DataTable
        Dim dtv As New DataView
        Dim sql As String = ""
        sql = "Update Tb_Kedonthuoc Set MaBN = '" & cmbDonvi.EditValue & "',Ngay = '" & DtpNgay.DateTime & "',Sophieukham ='" & txtSophieukham.Text & "',"
        sql &= "chandoanls =N'" & Txtchandoanls.Text & "',Bacsykedon= '" & cmbbacsykedon.EditValue & "',Nguoinhap = '" & CmbNVBH.EditValue & "',"
        sql &= "Makho ='" & CmbKhohang.EditValue & "',Ghichu =N'" & txtGhichu.Text & "',sotien='" & Double.Parse("0" + Chuanhoa(txtSotien.Text)) & "',SoNgay=" & txtSoNgay.EditValue & " Where IDPhieu = " & IDPhieuxuat & " "
        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
            If IDPhieuxuat <> 0 Then
                'TinhtonkhoSP()
                dtv = Me.GridView1.DataSource
                dtbCTXN = dtv.Table
                If Not dtbCTXN Is Nothing Then
                    If Command_Exc("Delete Tb_Kedonthuoc_chitiet WHERE IDsophieu=" & IDPhieuxuat & "", CNNQLPHONGKHAM) = 0 Then
                        For Each r As DataRow In dtbCTXN.Rows
                            If r.RowState <> DataRowState.Deleted Then
                                sql = "INSERT INTO Tb_Kedonthuoc_chitiet(IDsophieu,Masp,Soluong,Dongia,thanhtien,Lieudung,Ghichu,Thanhtien2,STT,b_Ex,Sang,Trua,Chieu,Toi)"
                                sql &= "VALUES(" & IDPhieuxuat & ",'" & r("Masp") & "'," & r("Soluong") & "," & r("Dongia") & "," & r("thanhtien") & ",N'" & r("Lieudung") & "',N'" & r("Ghichu") & "',NULL," & r("STT") & ",NULL," & r("Sang") & "," & r("Trua") & "," & r("Chieu") & "," & r("Toi") & ")"
                                BusinessLogic.Data.Update(sql)
                            End If
                        Next
                    End If
                End If
            End If
            Me.btnCap_nhat.Enabled = False
        Else
            MessageBox.Show("Có lỗi xảy ra...!")
        End If
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle)
        Dim row1 As DataRow
        row1 = Me.GridView1.GetDataRow(e.RowHandle - 1)
        row("Sang") = 0
        row("Trua") = 0
        row("Chieu") = 0
        row("Toi") = 0
        row("Soluong") = 0
        row("Dongia") = 0
        row("Thanhtien") = 0
        row("Ghichu") = ""
        row("Lieudung") = ""
        If row.Table.Rows.Count = 0 Then
            row("ID") = 0
            row("STT") = 1
        Else
            row("ID") = row.Table.Rows.Count + 1
            row("STT") = row.Table.Rows.Count + 1
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn muốn xoá phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strSQL As String = ""
            strSQL = String.Format("UPDATE Tb_Kedonthuoc SET Huy=1 WHERE IDPhieu={0}", IDPhieuxuat)
            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                strSQL = String.Format("UPDATE chi_tiet_new SET Huy=1 where RefNo=N'{0}'", txtSophieu.Text)
                If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
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
                    Me.btnXoa.Enabled = False
                    Me.btnSua.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Tab And e.Shift = True Then
            Me.CmbKhohang.Focus()
            blnsp = False
        End If
    End Sub

    Private Sub GridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txtGhichu.Focus()
            blnsp = False
        End If
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.Kedonthuoc
        Dim dtb As DataTable = New DataTable()
        dtb = BusinessLogic.Data.GetDataset("InKeDonThuoc", Data.CommandType.StoredProcedure, New List(Of String) From {"Idphieu"}, New List(Of Object) From {IDPhieuxuat}).Tables(0)
        frm.IDPhieuTC = IDPhieuxuat
        frm.Title = "ĐƠN THUỐC"
        frm.SoNgay = txtSoNgay.EditValue
        If chkHenKham.Checked Then
            frm.Ngayhenkham = dtHenKham.DateTime.ToString("dd/MM/yyyy")
        Else
            frm.Ngayhenkham = ""
        End If
        frm.tuoi = txtThangTuoi.Text
        frm.dtb = dtb
        frm.Show()
    End Sub

    Private Sub txtGhichu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGhichu.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnCap_nhat.Focus()
        End If
    End Sub

    Private Sub CmbKhohang_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Or e.KeyCode = Keys.Delete Then
            Me.CmbKhohang.EditValue = ""
        ElseIf e.KeyCode = Keys.Enter Then
        End If
    End Sub

    Private Sub CmbNVBH_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        blnsp = False
    End Sub

    Private Sub cmbLoai_xuat_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        blnsp = False
    End Sub

    Private Sub CmbKhohang_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        blnsp = False
    End Sub

    Private Sub txtGhichu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtGhichu.MouseDown
        blnsp = False
    End Sub

    Private Sub GridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView1.MouseDown
        blnsp = True
    End Sub

    Private Sub DtpNgay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dtb = BusinessLogic.Data.GetDataset("Select * From ket_chuyen").Tables(0)
        ngayketchuyen = dtb.Rows(0)("ngayketchuyen")
        If Me.DtpNgay.Text = "" Then
            MsgBox("Chú ý! Bạn chưa chọn ngày")
            Me.DtpNgay.DateTime = NgayGioServer()
        End If
        If Me.DtpNgay.DateTime.Date > NgayGioServer().Date Then
            MsgBox("Chú ý! Bạn chọn đã chọn ngày lớn hơn ngày hiện tại")
            Me.DtpNgay.DateTime = NgayGioServer()
        End If
        If Me.DtpNgay.DateTime.Date < ngayketchuyen.Date Then
            MsgBox("Chú ý! Bạn chọn ngày nhỏ hơn ngày kết chuyển")
            Me.DtpNgay.DateTime = ngayketchuyen
        End If
    End Sub

    Private Sub cmbDonvi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDonvi.EditValueChanged
        If cmbDonvi.EditValue <> "" Then
            Dim dtbbenhnhan As New DataTable
            Dim sql As String = String.Format("SELECT MaBN,TenBN,HoTenBN,DiaChiChiTiet,CASE GioiTinh WHEN 1 THEN N'Nam'ELSE N'Nữ' END as GioiTinh,NgaySinh,DienThoai FROM HOSOBN b where Mabn=N'{0}'", cmbDonvi.EditValue)
            dtbbenhnhan = BusinessLogic.Data.GetDataset(sql).Tables(0)
            If dtbbenhnhan.Rows.Count > 0 Then
                If Not dtbbenhnhan.Rows(0)("DienThoai") Is DBNull.Value Then
                    Me.txtDienThoai.Text = dtbbenhnhan.Rows(0)("DienThoai").ToString()
                Else
                    Me.txtDienThoai.Text = String.Empty
                End If
                If Not dtbbenhnhan.Rows(0)("DiaChiChiTiet") Is DBNull.Value Then
                    Me.txtDiachi.Text = dtbbenhnhan.Rows(0)("DiaChiChiTiet").ToString()
                Else
                    Me.txtDiachi.Text = String.Empty
                End If
                If Not dtbbenhnhan.Rows(0)("Gioitinh") Is DBNull.Value Then
                    Me.txtGioitinh.Text = dtbbenhnhan.Rows(0)("Gioitinh").ToString()
                Else
                    Me.txtGioitinh.Text = String.Empty
                End If
                If Not dtbbenhnhan.Rows(0)("NgaySinh") Is DBNull.Value Then
                    dtNgaySinh.DateTime = dtbbenhnhan.Rows(0)("NgaySinh")
                Else
                    dtNgaySinh.Text = String.Empty
                End If
            Else
                Me.txtDienThoai.Text = String.Empty
                Me.txtDiachi.Text = String.Empty
                Me.txtGioitinh.Text = String.Empty
                Me.dtNgaySinh.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub btnXuatthuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXuatthuoc.Click
        Dim _sql As String = "Select ISNULL(i_status,0) As i_status From tb_kedonthuoc Where Sophieu='" & CInt(txtSophieu.Text.Trim) & "'"
        Dim dtStatus As DataTable = BusinessLogic.Data.GetDataset(_sql).Tables(0)
        Try
            If dtStatus.Rows(0)("i_status") = 1 Then
                MessageBox.Show("Đơn thuốc đã xuất!")
                Return
            End If
        Catch ex As Exception

        End Try
        If MsgBox("BẠN CÓ CHẮC CHẮN LÀ XUẤT THUỐC KHÔNG?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim frm As New frmPhieuXN
            frm.Sodonthuoc = CInt(txtSophieu.Text.Trim)
            frm.Loai = True
            frm.Loaixuat = False
            frm.Name = "frmPhieuxuatdon"
            frm.Label12.Text = "Loại xuất"
            frm.blnLoaiphieu = False
            frm.cmbLoai_xuat.EditValue = "XTD"
            frm.CmbKhohang.EditValue = "KT"
            frm.Text = "PHIẾU PHÁT THUỐC"
            frm.Label21.Text = "PHIẾU PHÁT THUỐC"
            ' Lấy thông tin sang
            frm.CmbNVBH.EditValue = Me.CmbNVBH.EditValue
            frm.Sophieukham = Me.txtSophieukham.Text
            frm.Sodonthuoc = Me.txtSophieu.Text
            frm.MABN = Me.cmbDonvi.EditValue
            frm.Chandoanlansang = Me.Txtchandoanls.Text
            frm.Is_BHYT = False
            'If Not cmbdoituong.EditValue Is Nothing Then
            '    If cmbdoituong.EditValue = 0 Then
            '        frm.Is_BHYT = True
            '    Else
            '        frm.Is_BHYT = False
            '    End If
            'Else
            '    frm.Is_BHYT = False
            'End If

            ' Lấy thông tin sản phẩm 
            obj = Nothing
            Dim dtb As DataView
            dtb = Me.GridView1.DataSource()
            Dim row As DataRowView
            Dim n, i As Integer
            n = Me.GridView1.RowCount - 1
            ReDim obj(n)
            For Each row In dtb
                obj(i) = New Donthuoc
                obj(i).Mathuoc = row("Masp")
                obj(i).Soluong = row("Soluong")
                obj(i).Lieudung = row("Lieudung")
                i = i + 1
            Next
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
        Exit Sub

        Using dt As DataTable = BusinessLogic.Data.GetDataset("proc_GetListHanghoa", Data.CommandType.StoredProcedure, New List(Of String) From {"Kho"}, New List(Of Object) From {CmbKhohang.EditValue}).Tables(0)
            Dim dt2 As DataTable = DirectCast(grdDinh_khoan.DataSource, DataTable)
            For Each r As DataRow In dt2.Rows
                Dim dr2() As DataRow = dt.Select(String.Format("[Masp]='{0}'", r("Masp")))
                If (dr2 Is Nothing OrElse dr2.Length = 0) Then
                    MessageBox.Show("Mã thuốc/vật tư vừa kê hết!:" + r("Masp"), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return
                Else
                    Dim r2 As DataRow = dr2(0)
                    If (r("Soluong") > r2("toncuoi")) Then
                        MessageBox.Show(String.Format("Mã thuốc/vật tư {0} không đủ xuất theo số lượng kê! SL trong kho còn={1}", r("Masp"), r2("toncuoi")), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Return
                    End If
                End If
            Next
        End Using

        Dim clsObjPxn As New clsXNKho
        Dim TTXuat As Integer = 1
        If TTXuat = 1 Then
            'update tb_kedonthuoc
            Dim str As String = "Update tb_kedonthuoc set i_status=1 where IDphieu='" & IDPhieuxuat & "'"
            If Command_Exc(str, CNNQLPHONGKHAM) = 0 Then
                'insert Phieu_xuat_nhap  
                Dim idsophieu As Integer = 0
                Dim Sophieu As Integer = clsObjPxn.Lay_So_phieu(0)
                Dim strSQL As String = ""
                strSQL = "Insert into phieu_xuat_nhap (Sophieu,Loaiphieu,Ngay,MaXN,Makho,Madv,Makh,TienUSD,Tygia,VAT,Quydoi,Giavon,TienVND,Nguoinhap,GhiChu,Huy,Sophieukham,LoaiDonXuat) "
                strSQL &= "Values('" & clsObjPxn.Lay_So_phieu(0) & "',0,'" & NgayGioServer().Date & "','XTBHYT','KT',0,'" & cmbDonvi.EditValue & "','" & txtSotien.Text & "',0,0,'" & txtSotien.Text & "',0,0,'" & clsLoginObj.strUsername & "','',0,'" & txtSophieukham.Text & "',2)"
                If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                    'insert chi_tiet_pxn  
                    Dim strID As String = ""
                    Dim dtID As New DataTable
                    strID = "Select IDphieuXN from phieu_xuat_nhap where sophieu='" & Sophieu & "'"
                    dtID = BusinessLogic.Data.GetDataset(strID, CommandType.Text, Nothing, Nothing).Tables(0)
                    idsophieu = dtID.Rows(0)(0)
                    strSQL = "Insert into chi_tiet_pxn (IDSophieu,Masp,Soluong,Dongia,DongiaVND,VAT,KhuyenMai,Thanhtien,ThanhtienVND,Giathanh,STT,Trietkhau,Lieudung,HanSD,Solo,Ghichu) Select '" & idsophieu & "',masp,soluong,dongia,0,0,0,thanhtien,0,0,stt,0,'','','',N'Xuất thuốc' from Tb_Kedonthuoc_chitiet where idsophieu='" & IDPhieuxuat & "'"
                    If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                        Dim sql As String
                        sql = "Delete from chi_tiet_new where RefNo='" & Sophieu & "'"
                        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                            sql = "Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung)"
                            sql &= "Select '" & txtSophieukham.Text & "',masp,soluong,dongia,thanhtien,stt,'" & cmbDonvi.EditValue & "','" & NgayGioServer().Date & "','" & txtSotien.Text & "','KT',0,'" & Sophieu & "',N'Xuất thuốc',N'' from Tb_Kedonthuoc_chitiet where idsophieu='" & IDPhieuxuat & "'"
                            Command_Exc(sql, CNNQLPHONGKHAM)
                        End If
                    End If
                    If Command_Exc(String.Format("Update Tb_Kedonthuoc_chitiet set b_Ex=1 where IDsophieu={0}", IDPhieuxuat), CNNQLPHONGKHAM) = 0 Then
                        Me.Close()
                    Else
                        Return
                    End If
                End If
            End If
        End If
        Exit Sub
    End Sub

    Private Sub Insert_KETQUA()
        Dim frmdichvu As New frmPhieuXN
        ' Lấy thông tin phiếu
        frmdichvu.Nguoilap = Me.CmbNVBH.EditValue
        frmdichvu.Sophieukham = Me.txtSophieukham.Text
        frmdichvu.Sodonthuoc = Me.txtSophieu.Text
        frmdichvu.MABN = Me.cmbDonvi.EditValue
        frmdichvu.Chandoanlansang = Me.Txtchandoanls.Text
        frmdichvu.cmbLoai_xuat.EditValue = "XTBHYT"
        frmdichvu.CmbKhohang.EditValue = "KT"
        ' Lấy thông tin sản phẩm
        obj = Nothing
        Dim dtb As DataView
        dtb = Me.GridView1.DataSource()
        Dim row As DataRowView
        Dim n, i As Integer
        n = Me.GridView1.RowCount - 1
        ReDim obj(n)
        For Each row In dtb
            obj(i) = New Donthuoc
            obj(i).Mathuoc = row("Masp")
            obj(i).Soluong = row("Soluong")
            i = i + 1
        Next
    End Sub

    Private Function laygia(ByVal Masp As String) As Double
        Dim Obj As New Object
        Dim dtbtonkho As DataTable
        dtbtonkho = BusinessLogic.Data.GetDataset("Select isnull(dongia,0) as Giaban from san_pham WHERE Masp =N'" & Masp & "'").Tables(0)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("Giaban")
        Else
            MsgBox("Sản phẩm này hiện không còn tồn kho", MsgBoxStyle.Critical)
        End If
    End Function

    Private Function laymota(ByVal Masp As String) As String
        Dim Obj As New Object
        Dim dtbtonkho As DataTable
        dtbtonkho = BusinessLogic.Data.GetDataset("Select isnull(mota,'') as mota from san_pham WHERE Masp =N'" & Masp & "'").Tables(0)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("mota").ToString()
        Else
            Return ""
        End If
    End Function
    Private Function laydonvisudung(ByVal Masp As String) As String
        Dim Obj As New Object
        Dim dtbtonkho As DataTable
        dtbtonkho = BusinessLogic.Data.GetDataset("Select Isnull(DonViSuDung,'') as DonViSuDung From San_Pham WHERE Masp =N'" & Masp & "'").Tables(0)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("DonViSuDung").ToString()
        Else
            Return ""
        End If
    End Function

    Private Sub AddNewEntry()
        Dim dt As New DataTable
        dt = grdDinh_khoan.DataSource
        Dim sql As String = ""
        sql = "DELETE FROM Chi_Tiet_New WHERE IdSophieu='" & Me.txtSophieukham.Text & "' AND LoaiDV=10"
        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
            For Each dr As DataRow In dt.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    sql = "INSERT INTO Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,thanhtoan,thutien,maphong)"
                    sql &= "Values('" & txtSophieukham.Text & "',N'" & dr("Masp") & "','" & dr("Soluong") & "','" & dr("Dongia") & "','" & dr("Thanhtien") & "','" & dr("STT") & "',N'" & Me.cmbDonvi.EditValue.ToString() & "',"
                    sql &= "'" & DtpNgay.DateTime & "'," & Double.Parse("0" + Chuanhoa(Me.txtSotien.Text)) & ",N'','10',N'" & Me.txtSophieu.Text & "',N'Xuất thuốc BHYT:" & txtSophieukham.Text & "',0,0,N'" & PhongKham & "')"
                    Command_Exc(sql, CNNQLPHONGKHAM)
                End If
            Next
        Else
            MsgBox("Có lỗi xảy ra...!", MsgBoxStyle.Critical)
            Return
        End If
    End Sub

    Private Sub btnBoxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoxoa.Click
        If MsgBox("Bạn có thật sự muốn phục hồi phiếu này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strSQL As String
            strSQL = "UPDATE Tb_Kedonthuoc SET Huy=0 WHERE IDPhieu=" & IDPhieuxuat & ""
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            Dim sql As String
            sql = "UPDATE chi_tiet_new SET Huy=0 where RefNo='" & Me.txtSophieu.Text & "'"
            Command_Exc(sql, CNNQLPHONGKHAM)
            MsgBox("Bản ghi hiện tại đã được phục hồi")
            Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
            If sky = False Then
                Me.btnThem.Enabled = False
                Me.btnIn.Enabled = True
                Me.btnThoat.Enabled = True
            Else
                Me.btnSua.Enabled = False
                Me.btnXoa.Enabled = False
            End If
            Me.btnBoxoa.Enabled = False
            Me.btnSua.Enabled = False
        End If

    End Sub

    Private Sub txtSoNgay_EditValueChanged(sender As Object, e As EventArgs) Handles txtSoNgay.EditValueChanged
        If txtSoNgay.EditValue < 1 Then
            txtSoNgay.EditValue = 1
        Else
            For i As Integer = 0 To Me.GridView1.RowCount - 2
                Dim row As DataRowView = GridView1.GetRow(i)
                Dim sl As Double = (Double.Parse(row("Sang").ToString()) + Double.Parse(row("Trua").ToString()) + Double.Parse(row("Chieu").ToString()) + Double.Parse(row("Toi").ToString())) * Double.Parse(txtSoNgay.EditValue.ToString())
                row("SoLuong") = sl
                Dim str As String = ""
                If Double.Parse(row("Sang").ToString()) > 0 Then
                    str += "Sáng " + row("Sang").ToString() + " " + row("DonViSuDung").ToString()
                End If
                If Double.Parse(row("Trua").ToString()) > 0 Then
                    str += ",trưa " + row("Trua").ToString() + " " + row("DonViSuDung").ToString()
                End If
                If Double.Parse(row("Chieu").ToString()) > 0 Then
                    str += ",chiều " + row("Chieu").ToString() + " " + row("DonViSuDung").ToString()
                End If
                If Double.Parse(row("Toi").ToString()) > 0 Then
                    str += ",tối " + row("Toi").ToString() + " " + row("DonViSuDung").ToString()
                End If
                row("Lieudung") = str

                If (IsNumeric(row("Soluong")) And IsNumeric(row("Dongia"))) Then
                    row("Thanhtien") = row("Soluong") * row("Dongia")
                End If
            Next
            TongUSD()
            Me.GridView1.UpdateCurrentRow()
        End If
    End Sub

    Private Sub chkHenKham_CheckedChanged(sender As Object, e As EventArgs) Handles chkHenKham.CheckedChanged
        If chkHenKham.Checked = True Then
            dtHenKham.Visible = True
            dtHenKham.DateTime = DtpNgay.DateTime.AddDays(3)
        Else
            dtHenKham.Visible = False
            dtHenKham.EditValue = New DateTime(1900, 1, 1)
        End If
    End Sub

    Private Sub dtNgaySinh_EditValueChanged(sender As Object, e As EventArgs) Handles dtNgaySinh.EditValueChanged
        Try
            Dim ThangTuoi As String = MdlCommon.TinhThangTuoi(dtNgaySinh.DateTime.Date, 3)
            txtThangTuoi.Text = ThangTuoi
        Catch ex As Exception
            txtThangTuoi.Text = ""
        End Try
    End Sub

    Private Sub frm_kedonthuoc_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isCloseForm = True
    End Sub

    Private Sub cmbDonMau_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDonMau.EditValueChanged
        If cmbDonMau.EditValue <> Nothing Then
            GridView1.SelectAll()
            GridView1.DeleteSelectedRows()
            Dim sql As String = String.Format("SELECT ROW_NUMBER()OVER(ORDER BY c.ID) AS STT, 0 AS ID, 0 AS IDsophieu, s.Masp, c.SoLuong AS Soluong, s.Dongia, (c.SoLuong*s.Dongia) AS thanhtien, c.LieuDung AS Lieudung, c.GhiChu AS Ghichu, 0 as Sang, 0 AS Trua, 0 as Chieu, 0 as Toi, CAST(0 AS BIT) AS IsTest, s.DonViSuDung FROM Dm_DonThuocMau_Ct c JOIN San_Pham s ON c.MaSp=s.MaSp WHERE c.IDDonThuocMau='{0}' ", cmbDonMau.EditValue)
            sql &= String.Format("AND c.Loai='V' ")
            Dim dt As DataTable = BusinessLogic.Data.GetDataset(sql).Tables(0)
            grdDinh_khoan.DataSource = dt
            TongUSD()
            Me.GridView1.UpdateCurrentRow()
        End If
    End Sub
End Class
