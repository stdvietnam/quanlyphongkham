Imports System.Data
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport

Public Class frmPhieuNHAPKHOTHUOC
    Inherits frmBase 'System.Windows.Forms.Form
    Public blnDelete As Boolean
    Private dtvCTPXN As DataView
    Private dtbCTPXN As DataTable
    Public blnType As Boolean
    Public blnLoaiphieu As Boolean = True
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
    Public Thuoc As Boolean
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents coldvt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colck As DevExpress.XtraGrid.Columns.GridColumn
    Private IDsophieu_daythuchi As Int32
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Grb As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTiendachi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSophieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuyet_toan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSotienVnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSotien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbNVBH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CmbKhohang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTygia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DtpNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbLoai_xuat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDonvi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel_Button As Panel
    Private _Masp As String = ""

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
    Friend WithEvents btnBoxoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_ghichu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSolo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ColVAT As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuNHAPKHOTHUOC))
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGhichu = New DevExpress.XtraEditors.TextEdit()
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
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.coldvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSoluong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDongia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThanhtien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid_ghichu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.ColSolo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btnBoxoa = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Grb = New DevExpress.XtraEditors.GroupControl()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTiendachi = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSophieu = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuyet_toan = New DevExpress.XtraEditors.TextEdit()
        Me.txtSotienVnd = New DevExpress.XtraEditors.TextEdit()
        Me.txtSotien = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbNVBH = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbKhohang = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTygia = New DevExpress.XtraEditors.TextEdit()
        Me.DtpNgay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbLoai_xuat = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbDonvi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        CType(Me.txtTiendachi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuyet_toan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSotienVnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSotien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTygia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDonvi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(326, 12)
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
        Me.btnSua.Location = New System.Drawing.Point(428, 12)
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
        Me.btnIn.Location = New System.Drawing.Point(224, 12)
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
        Me.btnXoa.Location = New System.Drawing.Point(531, 12)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 20
        Me.btnXoa.Text = "&Xoá"
        '
        'txtGhichu
        '
        Me.txtGhichu.EditValue = ""
        Me.txtGhichu.Location = New System.Drawing.Point(476, 79)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Properties.AutoHeight = False
        Me.txtGhichu.Size = New System.Drawing.Size(373, 24)
        Me.txtGhichu.TabIndex = 11
        Me.txtGhichu.Tag = "GhiChu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(393, 82)
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
        Me.btnThoat.Location = New System.Drawing.Point(774, 12)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 22
        Me.btnThoat.Text = "&Thoát"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(20, 12)
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
        Me.btnCap_nhat.Location = New System.Drawing.Point(122, 12)
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
        Me.grdDinh_khoan.Location = New System.Drawing.Point(-2, 151)
        Me.grdDinh_khoan.MainView = Me.GridView1
        Me.grdDinh_khoan.Name = "grdDinh_khoan"
        Me.grdDinh_khoan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemDateEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3})
        Me.grdDinh_khoan.Size = New System.Drawing.Size(871, 356)
        Me.grdDinh_khoan.TabIndex = 10
        Me.grdDinh_khoan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT, Me.colMasp, Me.colTensp, Me.coldvt, Me.colSoluong, Me.colDongia, Me.ColVAT, Me.colThanhtien, Me.Grid_ghichu, Me.ColSolo, Me.colck})
        Me.GridView1.GridControl = Me.grdDinh_khoan
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSTT
        '
        Me.colSTT.Caption = "STT"
        Me.colSTT.FieldName = "stt"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.OptionsColumn.AllowEdit = False
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 0
        Me.colSTT.Width = 32
        '
        'colMasp
        '
        Me.colMasp.Caption = "Mã "
        Me.colMasp.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colMasp.FieldName = "masp"
        Me.colMasp.Name = "colMasp"
        Me.colMasp.Width = 43
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.CaseSensitiveSearch = True
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("masp", "Mã SP", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tensp", "Tên sản phẩm", 275, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("gianhap", "Giá nhập")})
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
        Me.colTensp.Width = 209
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tensp", "Tên sản phẩm", 280, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("gianhap", "Giá nhập", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "tensp"
        Me.RepositoryItemLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.PopupWidth = 435
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "masp"
        '
        'coldvt
        '
        Me.coldvt.Caption = "Đvt"
        Me.coldvt.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.coldvt.FieldName = "masp"
        Me.coldvt.Name = "coldvt"
        Me.coldvt.OptionsColumn.AllowFocus = False
        Me.coldvt.Visible = True
        Me.coldvt.VisibleIndex = 2
        Me.coldvt.Width = 43
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("masp", "Mã", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tensp", "Tên sản phẩm", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("donvt", "Đvt", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "donvt"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.PopupWidth = 260
        Me.RepositoryItemLookUpEdit3.ValueMember = "masp"
        '
        'colSoluong
        '
        Me.colSoluong.Caption = "Số lượng"
        Me.colSoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSoluong.FieldName = "soluong"
        Me.colSoluong.Name = "colSoluong"
        Me.colSoluong.Visible = True
        Me.colSoluong.VisibleIndex = 3
        Me.colSoluong.Width = 53
        '
        'colDongia
        '
        Me.colDongia.Caption = "Đơn giá"
        Me.colDongia.DisplayFormat.FormatString = "###,###.##"
        Me.colDongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDongia.FieldName = "dongia"
        Me.colDongia.Name = "colDongia"
        Me.colDongia.Visible = True
        Me.colDongia.VisibleIndex = 4
        Me.colDongia.Width = 92
        '
        'ColVAT
        '
        Me.ColVAT.Caption = "VAT"
        Me.ColVAT.FieldName = "vat"
        Me.ColVAT.Name = "ColVAT"
        Me.ColVAT.Visible = True
        Me.ColVAT.VisibleIndex = 6
        Me.ColVAT.Width = 44
        '
        'colThanhtien
        '
        Me.colThanhtien.Caption = "Thành tiền"
        Me.colThanhtien.DisplayFormat.FormatString = "###,###.##"
        Me.colThanhtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colThanhtien.FieldName = "thanhtien"
        Me.colThanhtien.Name = "colThanhtien"
        Me.colThanhtien.OptionsColumn.AllowEdit = False
        Me.colThanhtien.OptionsColumn.FixedWidth = True
        Me.colThanhtien.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "thanhtien", "T={0:###,###.##}")})
        Me.colThanhtien.Visible = True
        Me.colThanhtien.VisibleIndex = 7
        Me.colThanhtien.Width = 137
        '
        'Grid_ghichu
        '
        Me.Grid_ghichu.Caption = "Hạn SD"
        Me.Grid_ghichu.ColumnEdit = Me.RepositoryItemDateEdit3
        Me.Grid_ghichu.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Grid_ghichu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Grid_ghichu.FieldName = "hansd"
        Me.Grid_ghichu.Name = "Grid_ghichu"
        Me.Grid_ghichu.Visible = True
        Me.Grid_ghichu.VisibleIndex = 8
        Me.Grid_ghichu.Width = 97
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit3.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemDateEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit3.EditFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemDateEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit3.Mask.EditMask = "dd/MM/yyyy"
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'ColSolo
        '
        Me.ColSolo.Caption = "Số lô"
        Me.ColSolo.FieldName = "solo"
        Me.ColSolo.Name = "ColSolo"
        Me.ColSolo.Visible = True
        Me.ColSolo.VisibleIndex = 9
        Me.ColSolo.Width = 104
        '
        'colck
        '
        Me.colck.Caption = "%CK"
        Me.colck.DisplayFormat.FormatString = "###,###.##"
        Me.colck.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colck.FieldName = "Trietkhau"
        Me.colck.Name = "colck"
        Me.colck.Visible = True
        Me.colck.VisibleIndex = 5
        Me.colck.Width = 41
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'btnBoxoa
        '
        Me.btnBoxoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnBoxoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBoxoa.Appearance.Options.UseFont = True
        Me.btnBoxoa.Appearance.Options.UseForeColor = True
        Me.btnBoxoa.Location = New System.Drawing.Point(531, 12)
        Me.btnBoxoa.Name = "btnBoxoa"
        Me.btnBoxoa.Size = New System.Drawing.Size(75, 25)
        Me.btnBoxoa.TabIndex = 21
        Me.btnBoxoa.Text = "&Bỏ xoá"
        Me.btnBoxoa.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-272, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 64)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(869, 37)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "PHIẾU NHẬP"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grb
        '
        Me.Grb.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Grb.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Grb.AppearanceCaption.Options.UseFont = True
        Me.Grb.AppearanceCaption.Options.UseForeColor = True
        Me.Grb.Controls.Add(Me.Label10)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Controls.Add(Me.Label22)
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.txtTiendachi)
        Me.Grb.Controls.Add(Me.Label9)
        Me.Grb.Controls.Add(Me.Label8)
        Me.Grb.Controls.Add(Me.txtSophieu)
        Me.Grb.Controls.Add(Me.txtQuyet_toan)
        Me.Grb.Controls.Add(Me.txtGhichu)
        Me.Grb.Controls.Add(Me.txtSotienVnd)
        Me.Grb.Controls.Add(Me.txtSotien)
        Me.Grb.Controls.Add(Me.Label12)
        Me.Grb.Controls.Add(Me.CmbNVBH)
        Me.Grb.Controls.Add(Me.Label16)
        Me.Grb.Controls.Add(Me.CmbKhohang)
        Me.Grb.Controls.Add(Me.Label15)
        Me.Grb.Controls.Add(Me.txtTygia)
        Me.Grb.Controls.Add(Me.DtpNgay)
        Me.Grb.Controls.Add(Me.cmbLoai_xuat)
        Me.Grb.Controls.Add(Me.cmbDonvi)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.Label11)
        Me.Grb.Controls.Add(Me.Label5)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grb.Location = New System.Drawing.Point(0, 37)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(869, 112)
        Me.Grb.TabIndex = 74
        Me.Grb.Text = "Thông tin phiếu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(83, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 14)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(458, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 14)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(83, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 14)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(83, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 14)
        Me.Label22.TabIndex = 104
        Me.Label22.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(635, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Tiền đã chi:"
        '
        'txtTiendachi
        '
        Me.txtTiendachi.EditValue = ""
        Me.txtTiendachi.Location = New System.Drawing.Point(719, 122)
        Me.txtTiendachi.Name = "txtTiendachi"
        Me.txtTiendachi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTiendachi.Properties.Appearance.Options.UseBackColor = True
        Me.txtTiendachi.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTiendachi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTiendachi.Properties.AutoHeight = False
        Me.txtTiendachi.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.txtTiendachi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTiendachi.Properties.EditFormat.FormatString = "###,###.00"
        Me.txtTiendachi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTiendachi.Properties.Mask.EditMask = "n"
        Me.txtTiendachi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTiendachi.Size = New System.Drawing.Size(130, 22)
        Me.txtTiendachi.TabIndex = 49
        Me.txtTiendachi.Tag = "Quydoi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Kho hàng"
        '
        'txtSophieu
        '
        Me.txtSophieu.EditValue = ""
        Me.txtSophieu.Location = New System.Drawing.Point(719, 31)
        Me.txtSophieu.Name = "txtSophieu"
        Me.txtSophieu.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSophieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSophieu.Properties.Appearance.Options.UseBackColor = True
        Me.txtSophieu.Properties.Appearance.Options.UseFont = True
        Me.txtSophieu.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSophieu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSophieu.Properties.AutoHeight = False
        Me.txtSophieu.Properties.ReadOnly = True
        Me.txtSophieu.Size = New System.Drawing.Size(130, 22)
        Me.txtSophieu.TabIndex = 5
        Me.txtSophieu.Tag = "Sophieu"
        '
        'txtQuyet_toan
        '
        Me.txtQuyet_toan.EditValue = ""
        Me.txtQuyet_toan.Location = New System.Drawing.Point(476, 122)
        Me.txtQuyet_toan.Name = "txtQuyet_toan"
        Me.txtQuyet_toan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtQuyet_toan.Properties.Appearance.Options.UseBackColor = True
        Me.txtQuyet_toan.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQuyet_toan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQuyet_toan.Properties.AutoHeight = False
        Me.txtQuyet_toan.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.txtQuyet_toan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQuyet_toan.Properties.EditFormat.FormatString = "###,###.00"
        Me.txtQuyet_toan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQuyet_toan.Properties.Mask.EditMask = "n"
        Me.txtQuyet_toan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQuyet_toan.Properties.ReadOnly = True
        Me.txtQuyet_toan.Size = New System.Drawing.Size(130, 22)
        Me.txtQuyet_toan.TabIndex = 47
        Me.txtQuyet_toan.Tag = "Quydoi"
        '
        'txtSotienVnd
        '
        Me.txtSotienVnd.EditValue = ""
        Me.txtSotienVnd.Location = New System.Drawing.Point(104, 125)
        Me.txtSotienVnd.Name = "txtSotienVnd"
        Me.txtSotienVnd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSotienVnd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSotienVnd.Properties.AutoHeight = False
        Me.txtSotienVnd.Size = New System.Drawing.Size(98, 22)
        Me.txtSotienVnd.TabIndex = 45
        Me.txtSotienVnd.Tag = "Quydoi"
        Me.txtSotienVnd.Visible = False
        '
        'txtSotien
        '
        Me.txtSotien.EditValue = ""
        Me.txtSotien.Location = New System.Drawing.Point(719, 55)
        Me.txtSotien.Name = "txtSotien"
        Me.txtSotien.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSotien.Properties.Appearance.Options.UseBackColor = True
        Me.txtSotien.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSotien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSotien.Properties.AutoHeight = False
        Me.txtSotien.Properties.Mask.EditMask = "n"
        Me.txtSotien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSotien.Properties.ReadOnly = True
        Me.txtSotien.Size = New System.Drawing.Size(130, 22)
        Me.txtSotien.TabIndex = 6
        Me.txtSotien.Tag = "TienUSD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(393, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Loại X/N"
        '
        'CmbNVBH
        '
        Me.CmbNVBH.Location = New System.Drawing.Point(104, 55)
        Me.CmbNVBH.Name = "CmbNVBH"
        Me.CmbNVBH.Properties.AutoHeight = False
        Me.CmbNVBH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbNVBH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Tên nhân viên", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbNVBH.Properties.NullText = ""
        Me.CmbNVBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbNVBH.Size = New System.Drawing.Size(275, 22)
        Me.CmbNVBH.TabIndex = 1
        Me.CmbNVBH.Tag = "Nguoinhap"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(17, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Người lập"
        '
        'CmbKhohang
        '
        Me.CmbKhohang.AllowDrop = True
        Me.CmbKhohang.Enabled = False
        Me.CmbKhohang.Location = New System.Drawing.Point(104, 79)
        Me.CmbKhohang.Name = "CmbKhohang"
        Me.CmbKhohang.Properties.AutoHeight = False
        Me.CmbKhohang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbKhohang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã kho", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbKhohang.Properties.NullText = ""
        Me.CmbKhohang.Properties.PopupWidth = 200
        Me.CmbKhohang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbKhohang.Properties.ValidateOnEnterKey = True
        Me.CmbKhohang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbKhohang.Size = New System.Drawing.Size(275, 22)
        Me.CmbKhohang.TabIndex = 2
        Me.CmbKhohang.Tag = "makho"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(392, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 17)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Giá trị QĐ:"
        '
        'txtTygia
        '
        Me.txtTygia.EditValue = "1"
        Me.txtTygia.Location = New System.Drawing.Point(208, 125)
        Me.txtTygia.Name = "txtTygia"
        Me.txtTygia.Properties.AutoHeight = False
        Me.txtTygia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTygia.Size = New System.Drawing.Size(25, 22)
        Me.txtTygia.TabIndex = 37
        Me.txtTygia.Tag = "Tygia"
        Me.txtTygia.Visible = False
        '
        'DtpNgay
        '
        Me.DtpNgay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.DtpNgay.Location = New System.Drawing.Point(476, 31)
        Me.DtpNgay.Name = "DtpNgay"
        Me.DtpNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DtpNgay.Size = New System.Drawing.Size(149, 22)
        Me.DtpNgay.TabIndex = 3
        Me.DtpNgay.Tag = "Ngay"
        '
        'cmbLoai_xuat
        '
        Me.cmbLoai_xuat.Enabled = False
        Me.cmbLoai_xuat.Location = New System.Drawing.Point(476, 55)
        Me.cmbLoai_xuat.Name = "cmbLoai_xuat"
        Me.cmbLoai_xuat.Properties.AutoHeight = False
        Me.cmbLoai_xuat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLoai_xuat.Properties.NullText = ""
        Me.cmbLoai_xuat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbLoai_xuat.Size = New System.Drawing.Size(149, 22)
        Me.cmbLoai_xuat.TabIndex = 4
        Me.cmbLoai_xuat.Tag = "MaXN"
        '
        'cmbDonvi
        '
        Me.cmbDonvi.AllowDrop = True
        Me.cmbDonvi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbDonvi.Location = New System.Drawing.Point(104, 31)
        Me.cmbDonvi.Name = "cmbDonvi"
        Me.cmbDonvi.Properties.AutoHeight = False
        Me.cmbDonvi.Properties.AutoSearchColumnIndex = 1
        Me.cmbDonvi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDonvi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MADV", "Mã", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENDV", "Tên NCC", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbDonvi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbDonvi.Properties.NullText = ""
        Me.cmbDonvi.Properties.PopupWidth = 300
        Me.cmbDonvi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDonvi.Size = New System.Drawing.Size(275, 22)
        Me.cmbDonvi.TabIndex = 0
        Me.cmbDonvi.Tag = "Madv"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(635, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Số phiếu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Nhà CC"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(17, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Tiền VNĐ"
        Me.Label11.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(635, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Tổng tiền"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(393, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Ngày lập"
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnIn)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnBoxoa)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 512)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(869, 49)
        Me.Panel_Button.TabIndex = 75
        '
        'frmPhieuNHAPKHOTHUOC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(869, 561)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.Grb)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grdDinh_khoan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPhieuNHAPKHOTHUOC"
        Me.Text = "PHIẾU NHẬP (F3: Thêm mới 1 sản phẩm)"
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDinh_khoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.txtTiendachi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuyet_toan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSotienVnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSotien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbKhohang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTygia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLoai_xuat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDonvi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPhieuNHAPKHOTHUOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        Me.DtpNgay.DateTime = NgayGioServer().Date
        Load_Data()
        Form_Initial()
        Ctrl_QuyenForm(Me)
        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnBoxoa.Visible = False
        If IDPhieuxuat <> 0 Then
            'Me.btnThem.Enabled = False
            Me.btnIn.Enabled = True
            'Me.btnSua.Enabled = True
            'Me.btnXoa.Enabled = True
            'Me.btnThoat.Enabled = True
            'Me.DtpNgay.Enabled = True
            'Me.grdDinh_khoan.Enabled = False
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Them)
            Me.btnSua.Enabled = False
            Me.btnXoa.Enabled = False
        End If
        If blnDelete = True Then
            Me.btnSua.Enabled = False
            Me.btnXoa.Enabled = False
            Me.btnBoxoa.Visible = True
            Me.btnBoxoa.Enabled = True
            Me.btnXoa.Visible = False
        End If
        stype = True
        Me.grdDinh_khoan.Enabled = True
        Me.Panel_Button.Enabled = True
    End Sub
    Private Sub Form_Initial()
        Dim clsObjPxn As New clsXNKho
        Dim dtbtygia As DataTable
        Dim dtbxn As New DataTable
        Me.txtTygia.Text = "1"
        Load_ComboBox("SELECT MADV,TENDV From DONVI order by TENDV", Me.cmbDonvi, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaXn,TenLoai From DM_Xuat_Nhap WHERE Loai= 1", Me.cmbLoai_xuat, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang", Me.CmbKhohang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.CmbNVBH, CNNQLPHONGKHAM, True)
        Me.CmbNVBH.EditValue = clsLoginObj.strUsername
        Me.CmbNVBH.Enabled = False
        Dim dt As New DataTable
        dt = BusinessLogic.Data.GetDataset("select masp,tensp,isnull(gianhap,0) as gianhap,donvt from san_pham where Makho='" & CmbKhohang.EditValue & "' ", Data.CommandType.Text, Nothing, Nothing).Tables(0)
        Me.RepositoryItemLookUpEdit1.DataSource = dt
        Me.RepositoryItemLookUpEdit2.DataSource = dt
        Me.RepositoryItemLookUpEdit3.DataSource = dt
        If IDPhieuxuat <> 0 Then
            CTPXFill()
        Else
            CTPXFill()
            Me.txtSophieu.Text = clsObjPxn.Lay_So_phieu(1)
        End If
    End Sub
    Private Sub Load_Data()
        Dim dtbPXN As New DataTable
        Dim dtbtk As New DataTable
        Dim dtbkho As New DataTable
        Dim strSql As String
        strSql = "SELECT * FROM Phieu_Xuat_Nhap WHERE IDPhieuXn=" & IDPhieuxuat & " "
        dtbPXN = Load_DataTable(strSql, CNNQLPHONGKHAM)

        If dtbPXN.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbPXN.Rows(0)
            blnLoaiphieu = row("Loaiphieu")
            Me.cmbDonvi.EditValue = row(Me.cmbDonvi.Tag)
            Madv = row(Me.cmbDonvi.Tag)
            Me.CmbNVBH.EditValue = row(Me.CmbNVBH.Tag)
            Me.CmbKhohang.EditValue = row(Me.CmbKhohang.Tag)
            Me.cmbLoai_xuat.EditValue = row(Me.cmbLoai_xuat.Tag)
            Me.txtGhichu.Text = row(Me.txtGhichu.Tag)
            Me.txtQuyet_toan.Text = row(Me.txtQuyet_toan.Tag)
            Me.txtSophieu.Text = row(Me.txtSophieu.Tag)
            Me.txtSotien.Text = row(Me.txtSotien.Tag)
            Me.txtSotienVnd.Text = row(Me.txtSotienVnd.Tag)
            Me.txtTygia.Text = row(Me.txtTygia.Tag)
            Me.DtpNgay.DateTime = row(Me.DtpNgay.Tag)
            Me.txtTiendachi.Text = row("sotienchi").ToString()

            Me.Text = "Phiếu nhập thuốc"
            Me.Label12.Text = "Loại nhập"
            If IsNumeric(Me.txtTygia.EditValue) Then
                Me.txtTygia.EditValue = Replace(Me.txtTygia.EditValue, ",", "")
                Me.txtTygia.EditValue = Format(Val(Me.txtTygia.Text), "###,###.##")
            End If
            If IsNumeric(Me.txtSotien.EditValue) Then
                Me.txtSotien.EditValue = Replace(Me.txtSotien.EditValue, ",", "")
                Me.txtSotien.EditValue = Format(Val(Me.txtSotien.EditValue), "###,###.##")
            End If
            Me.txtQuyet_toan.Text = row(Me.txtQuyet_toan.Tag)
            If IsNumeric(Me.txtQuyet_toan.EditValue) Then
                Me.txtQuyet_toan.EditValue = Replace(Me.txtQuyet_toan.EditValue, ",", "")
                Me.txtQuyet_toan.EditValue = Format(Val(Me.txtQuyet_toan.EditValue), "###,###.##")
            End If
            '-- add 22.6.2016
            If IsNumeric(Me.txtTiendachi.EditValue) Then
                Me.txtTiendachi.EditValue = Replace(Me.txtTiendachi.EditValue, ",", "")
                Me.txtTiendachi.EditValue = Format(Val(Me.txtTiendachi.EditValue), "###,###.##")
            End If
        End If
        CTPXFill()
        If IDPhieuxuat = 0 Then
            Me.btnXoa.Enabled = False
        End If
    End Sub
    Private Sub CTPXFill()
        Dim strSql As String
        If IDPhieuxuat <> 0 Then
            strSql = "SELECT id,idsophieu,masp,soluong,dongia,stt,vat,thanhtien,hansd,solo,Trietkhau FROM Chi_Tiet_PXN WHERE IDSophieu =" & IDPhieuxuat & " order by id "
        Else
            strSql = "SELECT id,idsophieu,masp,soluong,dongia,stt,vat,thanhtien,hansd,solo,Trietkhau FROM Chi_Tiet_PXN WHERE IDSophieu =-9999 order by id "
        End If
        dtb_PreCTPXN = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing).Tables(0)
        Me.grdDinh_khoan.DataSource = dtb_PreCTPXN
    End Sub
    Private Function CheckValidation() As Boolean
        Dim clsObjFrmXN As New clsFrmPhieuXN
        Return clsObjFrmXN.FrmCheckValide(Me)
    End Function
    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim obj As Object
        Dim rowpos As Integer
        Dim i As Int16
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle.ToString)
        If e.Column.FieldName = "masp" Then
            Try
                row("Dongia") = chech_gia_nhap(row("Masp"))
            Catch ex As Exception

            End Try
            _Masp = row("Masp")
            If Kiemtramasp() = True Then
                MsgBox("Sản phẩm đã được chọn ở 1 dòng khác!", MsgBoxStyle.Critical, "Thông báo")
            End If
        End If
        Try
            If (e.Column.FieldName = "masp") Or (e.Column.FieldName = "soluong") Or (e.Column.FieldName = "dongia") Or (e.Column.FieldName = "Trietkhau") Then
                If (IsNumeric(row("Soluong")) And IsNumeric(row("Dongia")) And IsNumeric(row("Trietkhau"))) Then
                    row("Thanhtien") = row("Soluong") * row("Dongia") + (IIf(row("VAT") <> 0, row("Soluong") * row("Dongia") * (row("VAT") / 100), 0)) - (IIf(row("Trietkhau") <> 0, row("Soluong") * row("Dongia") * (row("Trietkhau") / 100), 0))
                End If
            End If
        Catch ex As Exception

        End Try
        Try
            For i = 0 To Me.GridView1.RowCount - 2
                If (IsNumeric(row("Soluong")) And IsNumeric(row("Dongia")) And IsNumeric(row("Trietkhau"))) Then
                    row("Thanhtien") = row("Soluong") * row("Dongia") + (IIf(row("VAT") <> 0, row("Soluong") * row("Dongia") * (row("VAT") / 100), 0)) - (IIf(row("Trietkhau") <> 0, row("Soluong") * row("Dongia") * (row("Trietkhau") / 100), 0))
                End If
            Next
        Catch ex As Exception
        End Try
        Me.GridView1.UpdateCurrentRow()
        TongUSD()
    End Sub
    Private Function chech_gia_nhap(ByVal Masp As String) As Double
        Dim pos As Integer
        Dim Obj As New Object
        Dim dtb As DataTable
        Dim dtbtonkho As DataTable
        dtbtonkho = Load_DataTable("Select gianhap  from san_pham WHERE Masp =N'" & Masp & "'", CNNQLPHONGKHAM)
        If dtbtonkho.Rows.Count > 0 Then
            Return dtbtonkho.Rows(0)("gianhap")
        Else
            MsgBox("Sản phẩm này hiện không còn tồn kho", MsgBoxStyle.Critical)
        End If
    End Function
    Private Sub TongUSD()
        Dim objclsPXN As New clsFrmPhieuXN
        objclsPXN.GetUSDTotal(Me)
        objclsPXN = Nothing
    End Sub
    Public Sub FormClear()
        Dim objclsPXN As New clsFrmPhieuXN
        objclsPXN.frmXuatnhapClear(Me)
        objclsPXN = Nothing
    End Sub
    Private Function Check_san_pham(ByVal Masp As String, ByVal rowid As Integer) As Boolean
        Dim pos As Integer
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
    Private Sub cmbDonvi_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IDPhieuxuat = 0 Then
            If foundClick = True Then
                cmbDonvi.ShowPopup()
                foundClick = False
            Else
                foundClick = False
            End If
        Else
            foundClick = False
        End If
    End Sub
    Private Sub cmbLoai_xuat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
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
        Me.grdDinh_khoan.Enabled = True
        Me.txtGhichu.Enabled = True
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
    Private Sub cmbDonvi_keyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If sender Is cmbDonvi Then
            If e.KeyCode = Keys.F3 Then
                Dim frmKh As New frmThemDonVi
                frmKh.ShowDialog()
                If frmKh.Key = True Then
                    Load_ComboBox("SELECT Madv,tenvt,Tendv From Don_vi order by tenvt,Tendv", Me.cmbDonvi, CNNQLPHONGKHAM)
                    Me.cmbDonvi.EditValue = frmKh.IDmoi
                End If
            ElseIf e.KeyCode = Keys.Delete Then
                Me.cmbDonvi.EditValue = ""
            ElseIf e.KeyCode = Keys.Enter Then
                Me.CmbNVBH.Focus()
            End If
        End If
    End Sub

#End Region
#Region "Nhom cac su kien Button"
    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim ketnoi As String
        ketnoi = CNNQLPHONGKHAM.ConnectionString
        If CheckValidation() = True Then
            Dim dr As DataRowView
            Dim int_i As Int16
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
                SaveEntry()
            Else
                UPDATA()
                SaveEntry()
            End If

            '-- update hansd=null truong hop khong chon ngay
            Try
                Command_Exc("update Chi_Tiet_PXN set HanSD=null where CONVERT(varchar(10),HanSD,103)='01/01/1900'", CNNQLPHONGKHAM)
            Catch ex As Exception

            End Try

            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Me.btnIn.Enabled = True
            If sky = False Then
                Me.btnThem.Enabled = True
                Me.btnIn.Enabled = True

                Me.btnThoat.Enabled = True
                Me.btnSua.Enabled = False
                Me.btnXoa.Enabled = False
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
        Me.Panel_Button.Enabled = True
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
            For i = 0 To Me.GridView1.RowCount - 2
                dr = Me.GridView1.GetRow(i)
                dr("STT") = i + 1
            Next
            GridView1.UpdateCurrentRow()
            TongUSD()
        ElseIf e.KeyCode = Keys.F3 Then
            Dim dr As DataRowView
            Dim dt As DataTable
            Dim frmsp As New frmSanpham
            frmsp.ShowDialog()
            If frmsp.Key = True Then
                Me.GridView1.AddNewRow()
                dt = BusinessLogic.Data.GetDataset("select masp,tensp,isnull(gianhap,0) as gianhap,donvt from San_Pham where Manhom=10 and Makho='" & CmbKhohang.EditValue & "' ", Data.CommandType.Text, Nothing, Nothing).Tables(0)
                Me.RepositoryItemLookUpEdit1.DataSource = dt
                Me.RepositoryItemLookUpEdit2.DataSource = dt
                Me.RepositoryItemLookUpEdit3.DataSource = dt
                dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
                dr("Masp") = frmsp.IDmoi
                dr("dongia") = chech_gia_nhap(dr("Masp"))
                GridView1.UpdateCurrentRow()
                TongUSD()
            End If
        End If
    End Sub
    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim i As Integer
        Dim dtbtk As New DataTable
        Dim dtbxn As New DataTable
        Dim dtbkho As New DataTable
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        FormClear()
        dtbxn = Load_DataTable("select Maxn from Dm_xuat_nhap where loai=1", CNNQLPHONGKHAM)
        Me.cmbLoai_xuat.EditValue = dtbxn.Rows(0)("Maxn")
        Me.txtTygia.Text = "1"
        frmState = False
        Me.DtpNgay.DateTime = NgayGioServer().Date
        Me.DtpNgay.Enabled = False
        Me.txtSophieu.Enabled = False
        Me.txtSotien.Enabled = False
        Me.txtSotienVnd.Enabled = False
        Me.txtQuyet_toan.Enabled = False
        Me.txtGhichu.Enabled = True
        Me.Label9.Enabled = True
        Me.btnIn.Enabled = False
        Me.CmbNVBH.Enabled = False
        CTPXFill()
        k = 0
        Me.cmbDonvi.Focus()
        Me.cmbDonvi.ShowPopup()
        blnType = True
        Me.Panel_Button.Enabled = True
    End Sub
#End Region
    Private Sub INSERT()
        Me.GridView1.UpdateCurrentRow()
        TongUSD()
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        Dim fVAT As Double = 0
        Me.txtSophieu.Text = clsObjPxn.Lay_So_phieu(True)
        If clsObjPxn.ThemPhieu(Me.txtSophieu.Text, 1, "0", Me.cmbDonvi.EditValue, Chuanhoa(Me.txtSotien.Text), Chuanhoa(Me.txtTygia.Text), fVAT, 0, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, Chuanhoa(Me.txtQuyet_toan.Text), 0, int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM) = 0 Then
            txtSophieu.Text = BusinessLogic.Data.GetDatatable("select Sophieu from Phieu_Xuat_Nhap where IDPhieuXn=" & int_IDSophieu & "").Rows(0)("Sophieu").ToString()
            'Command_Exc("Update Phieu_Xuat_Nhap set sotienchi=" & Chuanhoa(Me.txtTiendachi.Text) & " where Loaiphieu=1 and Sophieu='" & Me.txtSophieu.Text & "'", CNNQLPHONGKHAM)
            Me.btnCap_nhat.Enabled = False
        End If
    End Sub
    Private Sub UPDATA()
        Me.GridView1.UpdateCurrentRow()
        TongUSD()
        Dim clsObjPxn As New clsXNKho
        Dim int_IDSophieu As Int32
        Dim int_SophieuMoi As Int32
        Dim IndexIDSophieu As Int32
        Dim fVAT As Double
        clsObjPxn.ThemPhieu(IDPhieuxuat, 1, "0", Me.cmbDonvi.EditValue, Chuanhoa(Me.txtSotien.Text), Chuanhoa(Me.txtTygia.Text), fVAT, 1, 0, Me.DtpNgay.EditValue, Me.cmbLoai_xuat.EditValue, Me.CmbKhohang.EditValue, Me.txtGhichu.Text, Me.CmbNVBH.EditValue, "", 0, 0, 0, Chuanhoa(Me.txtQuyet_toan.Text), 0, int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
        Command_Exc("Update Phieu_Xuat_Nhap set sotienchi=" & Chuanhoa(Me.txtTiendachi.Text) & " where Loaiphieu=1 and Sophieu='" & Me.txtSophieu.Text & "'", CNNQLPHONGKHAM)
        Me.btnCap_nhat.Enabled = False
    End Sub
    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle)
        Dim row1 As DataRow
        row1 = Me.GridView1.GetDataRow(e.RowHandle - 1)
        row("vat") = 0
        row("Trietkhau") = 0
        row("thanhtien") = 0
        row("soluong") = 0
        row("dongia") = 0
        'row("hansd") = Nothing
        row("solo") = Now.ToString("yyMMdd") & Me.txtSophieu.Text
        If row.Table.Rows.Count = 0 Then
            row("id") = 0
            row("stt") = 1
        Else
            row("id") = row.Table.Rows.Count + 1
            row("stt") = row.Table.Rows.Count + 1

        End If
    End Sub
    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có thật sự muốn xoá phiếu này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim strSQL As String
            Dim Styl As Boolean = False
            strSQL = "UPDATE Phieu_Xuat_Nhap SET Huy=1 WHERE IDPhieuXn=" & IDPhieuxuat & ""
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
                Me.Panel_Button.Enabled = True
            Else
                MsgBox("Xóa dữ liệu thất bại!")
            End If
        End If
    End Sub
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Try
            Dim dt As DataTable = New DataTable()
            dt = BusinessLogic.Data.GetDataset("Select IDPhieuXn from Phieu_Xuat_Nhap where Sophieu='" & txtSophieu.Text & "' and MaXN in ('NT','NVT') and Loaiphieu=1").Tables(0)
            IDPhieuxuat = CType(dt.Rows(0)("IDPhieuXn"), Integer)
        Catch ex As Exception

        End Try

        Dim clsObjPxn As New clsFrmPhieuXN
        clsObjPxn.Print(Me)
        clsObjPxn = Nothing
    End Sub
    Private Sub txtGhichu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGhichu.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnCap_nhat.Focus()
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
    Private Sub DtpNgay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dtb = Load_DataTable("select * from ket_chuyen", CNNQLPHONGKHAM)
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
            strSQL = "UPDATE Phieu_Xuat_Nhap SET Huy=0 WHERE IDPhieuXn=" & IDPhieuxuat & ""
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
    Private Sub txtSotien_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNumeric(Me.txtSotien.Text) Then
            Me.txtSotienVnd.Text = Replace(Me.txtSotien.Text, ",", "")
            Me.txtSotienVnd.Text = Format(Val(Me.txtSotienVnd.Text), "###,###.##")
            Me.txtQuyet_toan.Text = Val(Replace(Me.txtSotien.Text, ",", ""))
            Me.txtQuyet_toan.Text = Format(Val(Me.txtQuyet_toan.Text), "###,###.##")
            Me.txtTiendachi.Text = Val(Replace(Me.txtTiendachi.Text, ",", ""))
            Me.txtTiendachi.Text = Format(Val(Me.txtTiendachi.Text), "###,###.##")
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
        sql = "update Chi_tiet_pxn set Trietkhau='" & row("Trietkhau") & "',Stt='" & row("STT") & "',Masp='" & row("Masp") & "',soluong='" & row("soluong") & "',dongia='" & row("dongia") & "',thanhtien='" & row("thanhtien") & "',VAT=N'" & row("VAT") & "',hansd=N'" & row("hansd") & "',solo=N'" & row("solo") & "' where ID='" & row("ID") & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
        
    End Sub
    Private Sub DeleteEntry(ByVal row As DataRow)
        Dim sql As String
        sql = "Delete from Chi_tiet_pxn Where ID='" & row("ID", DataRowVersion.Original) & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Sub
    Private Sub AddNewEntry(ByVal row As DataRow)
        Dim sql As String
        Dim dtphieu As New DataTable
        dtphieu = BusinessLogic.Data.GetDataset("select Idphieuxn from phieu_xuat_nhap where loaiphieu=1 and sophieu='" & txtSophieu.Text & "'", CommandType.Text, Nothing, Nothing).Tables(0)
        sql = "Insert into Chi_tiet_pxn(Trietkhau,IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,VAT,Hansd,solo)values('" & row("Trietkhau") & "',N'" & dtphieu.Rows(0)(0) & "',N'" & row("Masp") & "',N'" & row("Soluong").ToString() & "',N'" & row("Dongia").ToString() & "',N'" & row("Thanhtien").ToString() & "',N'" & row("STT").ToString() & "',N'" & row("vat") & "',N'" & row("hansd") & "','" & row("solo") & "')"
        Command_Exc(sql, CNNQLPHONGKHAM)
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

End Class

