Public Class frmThemDonVi
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean
    Private ID As Int16
    Public IDmoi As String
    Private dtb As DataTable
    Private DtvDV As DataView
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colweb As DevExpress.XtraGrid.Columns.GridColumn
    Public Key As Boolean = False
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel_Button As Panel
    Private isload As Boolean = False
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Error_PhongKham As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemDonVi))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Error_PhongKham = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colweb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtWeb = New DevExpress.XtraEditors.TextEdit()
        Me.TxtFax = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTel = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.txtMa = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.Error_PhongKham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtWeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã đơn vị"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(476, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Website"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(477, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Điện thoại"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên đơn vị"
        '
        'Error_PhongKham
        '
        Me.Error_PhongKham.ContainerControl = Me
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(125, 12)
        Me.btnCap_nhat.MaximumSize = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.MinimumSize = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 8
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(226, 12)
        Me.btnHuy.MaximumSize = New System.Drawing.Size(75, 25)
        Me.btnHuy.MinimumSize = New System.Drawing.Size(75, 25)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 10
        Me.btnHuy.Text = "&Bỏ qua "
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(24, 12)
        Me.btnThem.MaximumSize = New System.Drawing.Size(75, 25)
        Me.btnThem.MinimumSize = New System.Drawing.Size(75, 25)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(327, 12)
        Me.btnSua.MaximumSize = New System.Drawing.Size(75, 25)
        Me.btnSua.MinimumSize = New System.Drawing.Size(75, 25)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "&Sửa "
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(428, 12)
        Me.btnXoa.MaximumSize = New System.Drawing.Size(75, 25)
        Me.btnXoa.MinimumSize = New System.Drawing.Size(75, 25)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "&Xoá "
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tên viết tắt"
        Me.ColumnHeader1.Width = 87
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(809, 12)
        Me.btnThoat.MaximumSize = New System.Drawing.Size(75, 25)
        Me.btnThoat.MinimumSize = New System.Drawing.Size(75, 25)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 11
        Me.btnThoat.Text = "&Thoát"
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 144)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(896, 308)
        Me.grv.TabIndex = 14
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.colten, Me.coldc, Me.colmail, Me.coltel, Me.colfax, Me.colweb})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã"
        Me.colma.FieldName = "madv"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.OptionsColumn.AllowFocus = False
        Me.colma.Width = 80
        '
        'colten
        '
        Me.colten.Caption = "Tên đơn vị"
        Me.colten.FieldName = "tendv"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 0
        Me.colten.Width = 118
        '
        'coldc
        '
        Me.coldc.Caption = "Địa chỉ"
        Me.coldc.FieldName = "diachi"
        Me.coldc.Name = "coldc"
        Me.coldc.OptionsColumn.AllowEdit = False
        Me.coldc.OptionsColumn.AllowFocus = False
        Me.coldc.Visible = True
        Me.coldc.VisibleIndex = 1
        Me.coldc.Width = 95
        '
        'colmail
        '
        Me.colmail.Caption = "Email"
        Me.colmail.FieldName = "email"
        Me.colmail.Name = "colmail"
        Me.colmail.OptionsColumn.AllowEdit = False
        Me.colmail.OptionsColumn.AllowFocus = False
        Me.colmail.Visible = True
        Me.colmail.VisibleIndex = 2
        Me.colmail.Width = 95
        '
        'coltel
        '
        Me.coltel.Caption = "Điện thoại"
        Me.coltel.FieldName = "tel"
        Me.coltel.Name = "coltel"
        Me.coltel.OptionsColumn.AllowEdit = False
        Me.coltel.OptionsColumn.AllowFocus = False
        Me.coltel.Visible = True
        Me.coltel.VisibleIndex = 3
        Me.coltel.Width = 95
        '
        'colfax
        '
        Me.colfax.Caption = "Fax"
        Me.colfax.FieldName = "fax"
        Me.colfax.Name = "colfax"
        Me.colfax.OptionsColumn.AllowEdit = False
        Me.colfax.OptionsColumn.AllowFocus = False
        Me.colfax.Visible = True
        Me.colfax.VisibleIndex = 4
        Me.colfax.Width = 95
        '
        'colweb
        '
        Me.colweb.Caption = "Website"
        Me.colweb.FieldName = "website"
        Me.colweb.Name = "colweb"
        Me.colweb.OptionsColumn.AllowEdit = False
        Me.colweb.OptionsColumn.AllowFocus = False
        Me.colweb.Visible = True
        Me.colweb.VisibleIndex = 5
        Me.colweb.Width = 106
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.txtWeb)
        Me.GroupControl1.Controls.Add(Me.TxtFax)
        Me.GroupControl1.Controls.Add(Me.TxtTel)
        Me.GroupControl1.Controls.Add(Me.TxtEmail)
        Me.GroupControl1.Controls.Add(Me.TxtDiaChi)
        Me.GroupControl1.Controls.Add(Me.txtTen)
        Me.GroupControl1.Controls.Add(Me.txtMa)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(896, 140)
        Me.GroupControl1.TabIndex = 15
        Me.GroupControl1.Text = "Thông tin đơn vị"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(85, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 14)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(83, 166)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "*"
        '
        'txtWeb
        '
        Me.txtWeb.Location = New System.Drawing.Point(541, 80)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtWeb.Properties.Appearance.Options.UseFont = True
        Me.txtWeb.Properties.AutoHeight = False
        Me.txtWeb.Size = New System.Drawing.Size(343, 23)
        Me.txtWeb.TabIndex = 3
        '
        'TxtFax
        '
        Me.TxtFax.Location = New System.Drawing.Point(541, 106)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtFax.Properties.Appearance.Options.UseFont = True
        Me.TxtFax.Properties.AutoHeight = False
        Me.TxtFax.Size = New System.Drawing.Size(343, 23)
        Me.TxtFax.TabIndex = 5
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(104, 80)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtTel.Properties.Appearance.Options.UseFont = True
        Me.TxtTel.Properties.AutoHeight = False
        Me.TxtTel.Size = New System.Drawing.Size(346, 23)
        Me.TxtTel.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(104, 106)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtEmail.Properties.Appearance.Options.UseFont = True
        Me.TxtEmail.Properties.AutoHeight = False
        Me.TxtEmail.Size = New System.Drawing.Size(346, 23)
        Me.TxtEmail.TabIndex = 4
        '
        'TxtDiaChi
        '
        Me.TxtDiaChi.Location = New System.Drawing.Point(104, 54)
        Me.TxtDiaChi.Name = "TxtDiaChi"
        Me.TxtDiaChi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtDiaChi.Properties.Appearance.Options.UseFont = True
        Me.TxtDiaChi.Properties.AutoHeight = False
        Me.TxtDiaChi.Size = New System.Drawing.Size(780, 23)
        Me.TxtDiaChi.TabIndex = 1
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(104, 28)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTen.Properties.Appearance.Options.UseFont = True
        Me.txtTen.Properties.AutoHeight = False
        Me.txtTen.Size = New System.Drawing.Size(780, 23)
        Me.txtTen.TabIndex = 0
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(104, 162)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMa.Properties.Appearance.Options.UseFont = True
        Me.txtMa.Properties.AutoHeight = False
        Me.txtMa.Size = New System.Drawing.Size(129, 23)
        Me.txtMa.TabIndex = 14
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 456)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(896, 49)
        Me.Panel_Button.TabIndex = 16
        '
        'frmThemDonVi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 505)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemDonVi"
        Me.Text = "DANH MỤC ĐƠN VỊ CUNG CẤP"
        CType(Me.Error_PhongKham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtWeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub loaddata_to_grid()
        Dim dts As New DataSet
        Dim sqlstr As String
        sqlstr = "SELECT [madv],[tendv],[tel],[fax],[diachi],[email],[website] FROM DONVI"
        dts = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing)
        Me.grv.DataSource = dts.Tables(0)
    End Sub
    Private Sub deactive_control()
        If (Flag = False) Then
            Me.txtMa.Enabled = False
            Me.txtTen.Enabled = False
            Me.TxtTel.Enabled = False
            Me.TxtFax.Enabled = False
            Me.TxtEmail.Enabled = False
            Me.TxtDiaChi.Enabled = False
            Me.txtWeb.Enabled = False

        Else
            Me.txtMa.Enabled = True
            Me.txtTen.Enabled = True
            Me.TxtTel.Enabled = True
            Me.TxtFax.Enabled = True
            Me.TxtEmail.Enabled = True
            Me.TxtDiaChi.Enabled = True
            Me.txtWeb.Enabled = True

        End If
    End Sub
    Private Sub enabel_ctr()
        Me.txtMa.Enabled = True
        Me.txtTen.Enabled = True
        Me.TxtTel.Enabled = True
        Me.TxtFax.Enabled = True
        Me.TxtEmail.Enabled = True
        Me.TxtDiaChi.Enabled = True
        Me.txtWeb.Enabled = True
    End Sub
    Private Function kiemtra() As Boolean
        kiemtra = True
        If (Me.txtMa.Text.Trim = "") Then
            kiemtra = False
            Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Error_PhongKham.SetError(Me.txtMa, "Không để trống mã!")
            Me.Error_PhongKham.SetIconAlignment(Me.txtMa, ErrorIconAlignment.MiddleRight)
        End If
        If (Me.txtTen.Text.Trim = "") Then
            kiemtra = False
            Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Error_PhongKham.SetError(Me.txtTen, "không để trống tên ĐV!")
            Me.Error_PhongKham.SetIconAlignment(Me.txtTen, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Function Layma(ByVal strMa As String, ByVal strManhom As String) As String
        Dim strMaMoi As String = ""
        Dim srtSQL As String
        Dim dtb As New DataTable
        Dim ok As Boolean
        Dim i As Integer
        If Len(strMa) > 0 Then
            For i = 1 To Len(strMa)
                If IsNumeric(Mid(strMa, i, 1)) Then
                    strMaMoi &= Mid(strMa, i, 1)
                End If
            Next
        End If
        If IsNumeric(strMaMoi) Then
            strMaMoi = Val(strMaMoi) + 1
        Else
            strMaMoi = 10
        End If
        Do While ok = False
            srtSQL = "SELECT [MADV] FROM DONVI where MaDV=" & Convert.ToInt32(strManhom & strMaMoi)
            Dim dts As New DataSet
            dts = BusinessLogic.Data.GetDataset(srtSQL, CommandType.Text, Nothing, Nothing)
            dtb = dts.Tables(0)
            If dtb.Rows.Count > 0 Then
                strMaMoi = Val(strMaMoi) + 1
            Else
                ok = True
            End If
        Loop
        Return strManhom & strMaMoi
    End Function
    Private Sub Maxma()
        Dim strMa As String = ""
        Dim Strmanhom As String
        Dim strsQL As String
        Dim dts As New DataSet
        Dim dtb As New DataTable
        Dim dtblsv_SP As New DataTable
        If Flag = True Then
            Try
                strsQL = "Select max([MaDV]) as Ma FROM DONVI"
                dts = BusinessLogic.Data.GetDataset(strsQL, CommandType.Text, Nothing, Nothing)
                dtb = dts.Tables(0)
                If dtb.Rows.Count > 0 Then
                    If Not IsDBNull(dtb.Rows(0)("Ma")) Then strMa = dtb.Rows(0)("Ma")
                End If
                Strmanhom = ""
                Me.txtMa.Text = Layma(strMa, Strmanhom)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub frmThemDonVi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata_to_grid()
        deactive_control()
        Ctrl_QuyenForm(Me)
        isload = True
    End Sub
    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim b As Integer
        Dim sql As String
        If Me.txtMa.Text.Trim = "" Then
            MsgBox("Chưa chọn đối tượng để xóa!", MsgBoxStyle.Information, "Thông báo...")
        Else
            Try
                If kiemtradv() = True Then
                Else
                    sql = "DELETE FROM DONVI WHERE MaDV=" & Me.txtMa.Text.Trim
                    b = MsgBox("Bạn có chắc chắn muốn xóa không?", MsgBoxStyle.YesNo, "Thông báo...")
                    If (b = 6) Then
                        Command_Exc(sql, CNNQLPHONGKHAM)
                        loaddata_to_grid()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Có lỗi khi xóa dữ liệu!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        Clear_Control(GroupControl1)
        isload = True
    End Sub
    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If (Me.txtMa.Text.Trim = "") Then
            MsgBox("Chưa chọn đối tượng để sửa", MsgBoxStyle.Information, "Thông báo...")
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
            enabel_ctr()
            Flag = False
            isload = True
        End If
    End Sub
    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Flag = False
        Me.GroupControl1.Enabled = True
        Clear_Control(Me.GroupControl1)
        deactive_control()
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Me.Error_PhongKham.SetError(Me.txtMa, "")
        Me.Error_PhongKham.SetError(Me.txtTen, "")
        isload = True
    End Sub
    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        deactive_control()
        Clear_Control(Me.GroupControl1)
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        Maxma()
        Me.txtTen.Focus()
        Me.txtMa.ReadOnly = True
        isload = False
    End Sub
    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim sql As String
        Try
            If (kiemtra() = True) Then
                If (Flag = True) Then
                    sql = "INSERT INTO [DONVI]([MADV],[TENDV],[TEL],[FAX],[DIACHI],[EMAIL],[WEBSITE])" &
                    "VALUES(" & Convert.ToInt32(Me.txtMa.Text.Trim) & ",N'" & Me.txtTen.Text & "',N'" & Me.TxtTel.Text & "',N'" & Me.TxtFax.Text & "',N'" &
                    Me.TxtDiaChi.Text & "',N'" & Me.TxtEmail.Text & "',N'" & Me.txtWeb.Text & "')"
                    If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                        MessageBox.Show("Dữ liệu đã được thêm mới!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Có lỗi khi thêm mới dữ liệu!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    sql = "UPDATE DONVI SET [TENDV] =N'" & Me.txtTen.Text & "',[TEL] ='" & Me.TxtTel.Text & "',[FAX] ='" & Me.TxtFax.Text & "',[DIACHI] =N'" &
                    Me.TxtDiaChi.Text & "',[EMAIL] =N'" & Me.TxtEmail.Text & "',[WEBSITE] =N'" & Me.txtWeb.Text & "' WHERE [MADV] =" & Me.txtMa.Text.Trim
                    If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                        MessageBox.Show("Dữ liệu đã được sửa!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Có lỗi khi cập nhật dữ liệu", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                loaddata_to_grid()
                Ctrl_QuyenForm(Me)
                isload = True
            End If
        Catch ex As Exception
            MessageBox.Show("Có lỗi khi cập nhật dữ liệu", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmThemDonVi_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Key = True Then
            Dim dtbt As New DataTable
            Dim dts As New DataSet
            dts = BusinessLogic.Data.GetDataset("Select Madv from Donvi where ID=(select Max(ID) from Donvi)", CommandType.Text, Nothing, Nothing)
            dtbt = dts.Tables(0)
            If dtbt.Rows.Count > 0 Then
                IDmoi = dtbt.Rows(0)("Madv")
            End If
        End If
    End Sub
    Private Sub txtTen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Error_PhongKham.SetError(txtTen, "")
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Function kiemtradv() As Boolean
        Dim Madv As String = ""
        Dim dt1 As New DataTable
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("select madv from phieu_xuat_nhap group by madv union all select madv from phieu_thu_chi where Madv not in (select Madv from phieu_xuat_nhap group by Madv) group by madv order by Madv", CommandType.Text, Nothing, Nothing)
        dt1 = dts.Tables(0)
        For i As Integer = 0 To dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                Madv = dt1.Rows(i)("madv")
            End If
            If Me.txtMa.Text = Madv And Madv <> "" Then
                MsgBox("Đơn vị đã giao dịch. Bạn không thể xóa!", MsgBoxStyle.Critical, "Cảnh báo!")
                Return True
            End If
        Next
    End Function

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If isload = True Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    txtMa.Text = dr("madv")
                    txtTen.Text = dr("tendv")
                    TxtDiaChi.Text = dr("diachi")
                    TxtFax.Text = dr("fax")
                    TxtTel.Text = dr("tel")
                    TxtEmail.Text = dr("email")
                    txtWeb.Text = dr("website")
                End If
            End If
        End If
    End Sub
End Class
