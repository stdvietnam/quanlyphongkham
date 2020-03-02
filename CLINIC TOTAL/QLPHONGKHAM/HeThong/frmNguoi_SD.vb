Public Class frmNguoi_SD
    Inherits frmBase 'System.Windows.Forms.Form
    Private flag As Boolean
    Private ID As Int16
    Public IDmoi As String
    Private dtb As DataTable
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colusser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colghichu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnhom As DevExpress.XtraGrid.Columns.GridColumn
    Public Key As Boolean
    Private isload As Boolean = False
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Txthoten As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Txtghichu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel_Button As Panel
    Dim strgiaima As String = ""
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
    Friend WithEvents CmbMaphong As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmbmanhom As System.Windows.Forms.ComboBox
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNguoi_SD))
        Me.CmbMaphong = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmbmanhom = New System.Windows.Forms.ComboBox()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colusser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnhom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colghichu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txtghichu = New DevExpress.XtraEditors.TextEdit()
        Me.Txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Txthoten = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Txtghichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txthoten.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbMaphong
        '
        Me.CmbMaphong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMaphong.Location = New System.Drawing.Point(528, 53)
        Me.CmbMaphong.Name = "CmbMaphong"
        Me.CmbMaphong.Size = New System.Drawing.Size(300, 24)
        Me.CmbMaphong.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Họ tên "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên đăng nhập"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mật khẩu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(425, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phòng ban"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(425, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nhóm NSD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(425, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ghi chú "
        '
        'Cmbmanhom
        '
        Me.Cmbmanhom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbmanhom.Location = New System.Drawing.Point(528, 26)
        Me.Cmbmanhom.Name = "Cmbmanhom"
        Me.Cmbmanhom.Size = New System.Drawing.Size(300, 24)
        Me.Cmbmanhom.TabIndex = 3
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
        Me.btnThem.Location = New System.Drawing.Point(21, 11)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(114, 11)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 7
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(300, 11)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "&Sửa "
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(393, 11)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "&Xoá "
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(207, 11)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 8
        Me.btnHuy.Text = "&Bỏ qua "
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(753, 11)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "&Thoát "
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(1, 117)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(848, 334)
        Me.grv.TabIndex = 13
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colusser, Me.colten, Me.colphong, Me.colnhom, Me.colghichu})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colusser
        '
        Me.colusser.Caption = "UserName"
        Me.colusser.FieldName = "Username"
        Me.colusser.Name = "colusser"
        Me.colusser.OptionsColumn.AllowEdit = False
        Me.colusser.OptionsColumn.AllowFocus = False
        Me.colusser.Visible = True
        Me.colusser.VisibleIndex = 0
        Me.colusser.Width = 110
        '
        'colten
        '
        Me.colten.Caption = "Họ và tên"
        Me.colten.FieldName = "Hoten"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 1
        Me.colten.Width = 198
        '
        'colphong
        '
        Me.colphong.Caption = "Phòng ban"
        Me.colphong.FieldName = "Tenphong"
        Me.colphong.Name = "colphong"
        Me.colphong.OptionsColumn.AllowEdit = False
        Me.colphong.OptionsColumn.AllowFocus = False
        Me.colphong.Visible = True
        Me.colphong.VisibleIndex = 2
        Me.colphong.Width = 126
        '
        'colnhom
        '
        Me.colnhom.Caption = "Nhóm NSD"
        Me.colnhom.FieldName = "ten_nhom"
        Me.colnhom.Name = "colnhom"
        Me.colnhom.OptionsColumn.AllowEdit = False
        Me.colnhom.OptionsColumn.AllowFocus = False
        Me.colnhom.Visible = True
        Me.colnhom.VisibleIndex = 3
        Me.colnhom.Width = 100
        '
        'colghichu
        '
        Me.colghichu.Caption = "Ghi chú"
        Me.colghichu.FieldName = "ghichu"
        Me.colghichu.Name = "colghichu"
        Me.colghichu.OptionsColumn.AllowEdit = False
        Me.colghichu.OptionsColumn.AllowFocus = False
        Me.colghichu.Visible = True
        Me.colghichu.VisibleIndex = 4
        Me.colghichu.Width = 116
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grv
        Me.GridView2.Name = "GridView2"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.Txtghichu)
        Me.GroupControl1.Controls.Add(Me.Txtpassword)
        Me.GroupControl1.Controls.Add(Me.TxtUsername)
        Me.GroupControl1.Controls.Add(Me.Txthoten)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.CmbMaphong)
        Me.GroupControl1.Controls.Add(Me.Cmbmanhom)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(851, 114)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "Thông tin người dùng"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(504, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 14)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(504, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 14)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(124, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 14)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(124, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "*"
        '
        'Txtghichu
        '
        Me.Txtghichu.Location = New System.Drawing.Point(528, 80)
        Me.Txtghichu.Name = "Txtghichu"
        Me.Txtghichu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txtghichu.Properties.Appearance.Options.UseFont = True
        Me.Txtghichu.Properties.AutoHeight = False
        Me.Txtghichu.Size = New System.Drawing.Size(300, 23)
        Me.Txtghichu.TabIndex = 5
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(144, 80)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txtpassword.Properties.Appearance.Options.UseFont = True
        Me.Txtpassword.Properties.AutoHeight = False
        Me.Txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(264, 23)
        Me.Txtpassword.TabIndex = 2
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(144, 53)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtUsername.Properties.Appearance.Options.UseFont = True
        Me.TxtUsername.Properties.AutoHeight = False
        Me.TxtUsername.Size = New System.Drawing.Size(264, 24)
        Me.TxtUsername.TabIndex = 1
        '
        'Txthoten
        '
        Me.Txthoten.Location = New System.Drawing.Point(144, 26)
        Me.Txthoten.Name = "Txthoten"
        Me.Txthoten.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txthoten.Properties.Appearance.Options.UseFont = True
        Me.Txthoten.Properties.AutoHeight = False
        Me.Txthoten.Size = New System.Drawing.Size(264, 24)
        Me.Txthoten.TabIndex = 0
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 456)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(851, 48)
        Me.Panel_Button.TabIndex = 15
        '
        'frmNguoi_SD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 504)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNguoi_SD"
        Me.Text = "DANH MỤC NGƯỜI SỬ DỤNG"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Txtghichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txthoten.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmNguoi_SD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        Ctrl_QuyenForm(Me)
        isload = True
    End Sub
    Private Sub loaddata()
        'Dim obj As New localhost.Service1
        'Dim dts As New DataSet
        Dim dtb As New DataTable
        dtb = Load_DataTable("select Nguoi_Su_Dung.Hoten,Nguoi_Su_Dung.Username,Nguoi_Su_Dung.Password,Phong_Ban.Tenphong,Nhom_NSD.ten_nhom,Nguoi_Su_Dung.ghichu,Nguoi_Su_Dung.id,nguoi_su_dung.maphong,nguoi_su_dung.manhom,MaKhoa from Nguoi_Su_Dung inner join Phong_Ban  on Phong_Ban.Maphong=Nguoi_Su_Dung.Maphong inner join Nhom_NSD on Nhom_NSD.Ma_nhom = Nguoi_Su_Dung.Manhom  where Nguoi_Su_Dung.Username<>N'Admin'", CNNQLPHONGKHAM)
        Me.grv.DataSource = dtb 'dts.Tables(0)
        Load_ComboBox("Select Maphong,Tenphong from Phong_ban ", Me.CmbMaphong, CNNQLPHONGKHAM)
        Load_ComboBox("Select Ma_nhom,Ten_nhom from Nhom_NSD ", Me.Cmbmanhom, CNNQLPHONGKHAM)
        Me.TxtUsername.Enabled = False
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.TxtUsername.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.TxtUsername, "Phải nhập Username")
            ErrPro.SetIconAlignment(Me.TxtUsername, ErrorIconAlignment.MiddleRight)
        End If
        If Me.Txthoten.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.Txthoten, "Trường họ tên không để trống ")
            ErrPro.SetIconAlignment(Me.Txthoten, ErrorIconAlignment.MiddleRight)
        End If
        If Me.Cmbmanhom.SelectedIndex = -1 Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.Cmbmanhom, "Bạn phải chọn nhóm NSD!")
            ErrPro.SetIconAlignment(Me.Cmbmanhom, ErrorIconAlignment.MiddleRight)
        End If
        If Me.CmbMaphong.SelectedIndex = -1 Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.CmbMaphong, "Bạn phải chọn phòng ban!")
            ErrPro.SetIconAlignment(Me.CmbMaphong, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        flag = True
        ID = 0
        Clear_Control(Me.GroupControl1)
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        Me.GroupControl1.Enabled = True
        Me.TxtUsername.Enabled = True
        isload = False
    End Sub
    Private Sub btnCap_Nhat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim strUsername As String
        Dim strPassword As String
        Dim cls As New ClsNguoi_SD
        Dim obj As New Encryption64
        strPassword = obj.EncryptToBase64String(Me.Txtpassword.Text, "1234567a")
        If Kiem_Tra() = True Then
            If ID = 0 Then
                If cls.Adddnew(Me.Txthoten.Text, Me.TxtUsername.Text, strPassword, Me.CmbMaphong.SelectedValue, Me.Cmbmanhom.SelectedValue, Me.Txtghichu.Text, 1, "") = True Then
                    MsgBox("User đã có người  sử dụng ", MsgBoxStyle.Critical)
                End If
            Else
                If cls.Update(Me.Txthoten.Text, Me.TxtUsername.Text, strPassword, Me.CmbMaphong.SelectedValue, Me.Cmbmanhom.SelectedValue, Me.Txtghichu.Text, 2, ID, "") Then
                    MsgBox("Chú ý! User đã có người  sử dụng", MsgBoxStyle.Critical)
                End If
            End If
            loaddata()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            flag = False
            ErrPro.Dispose()
            Key = True
            isload = True
        End If
    End Sub

    Private Sub btnSua_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        flag = True
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        isload = True
    End Sub

    Private Sub btnXoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim cls As New ClsNguoi_SD
        If Me.TxtUsername.Text = "" Then
            MsgBox("Bạn chưa chọn đối tượng để xóa!", MsgBoxStyle.Critical, "Thông báo...")
        Else
            If MsgBox(" Bạn có muốn xoá thật ko ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cls.Delete(Me.TxtUsername.Text, 4)
                loaddata()
            End If
            Clear_Control(Me.GroupControl1)
        End If

    End Sub

    Private Sub btnHuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.GroupControl1.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
    End Sub

    Private Sub frmNguoi_SD_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Key = True Then
            dtb = BusinessLogic.Data.GetDataset("Select Username from Nguoi_su_dung where ID = (select Max(ID) from Nguoi_su_dung)", CommandType.Text, Nothing, Nothing).Tables(0)
            If dtb.Rows.Count > 0 Then
                IDmoi = dtb.Rows(0)("Username")
            End If
        End If
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub CmbMaphong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbMaphong.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim frmKh As New frmPhongBan
            frmKh.ShowDialog()
            Load_ComboBox("Select Maphong,Tenphong from Phong_ban", Me.CmbMaphong, CNNQLPHONGKHAM)
            Me.CmbMaphong.ValueMember = frmKh.IDmoi
        End If
    End Sub
    Private Sub Cmbmanhom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbmanhom.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim frmKh As New frmNhom_NSD
            frmKh.ShowDialog()
            Load_ComboBox("Select Ma_nhom,Ten_nhom from Nhom_NSD", Me.Cmbmanhom, CNNQLPHONGKHAM)
            Me.Cmbmanhom.ValueMember = frmKh.IDmoi
        End If
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If isload = True Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Dim clsgiaima As New Encryption64
                    strgiaima = clsgiaima.DecryptFromBase64String(dr("Password").ToString, "1234567a")
                    Me.TxtUsername.Text = dr("Username")
                    Me.Txthoten.Text = dr("Hoten")
                    Me.Txtpassword.Text = strgiaima
                    Me.Txtghichu.Text = dr("ghichu").ToString
                    Me.Cmbmanhom.SelectedValue = dr("manhom")
                    Me.CmbMaphong.SelectedValue = dr("maphong")
                    ID = dr("ID")
                End If
            End If
        End If
    End Sub

    Private Sub Txthoten_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Txthoten.Text = ChuanHoaChuoi(Txthoten.Text)
    End Sub
End Class