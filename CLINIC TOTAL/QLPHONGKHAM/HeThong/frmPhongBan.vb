Public Class frmPhongBan
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean
    Private ID As Int16
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgc As DevExpress.XtraGrid.Columns.GridColumn
    Public IDmoi As String
    Friend WithEvents r6 As System.Windows.Forms.RadioButton
    Friend WithEvents r5 As System.Windows.Forms.RadioButton
    Friend WithEvents r4 As System.Windows.Forms.RadioButton
    Friend WithEvents r3 As System.Windows.Forms.RadioButton
    Friend WithEvents r2 As System.Windows.Forms.RadioButton
    Friend WithEvents r1 As System.Windows.Forms.RadioButton
    Friend WithEvents r8 As System.Windows.Forms.RadioButton
    Friend WithEvents r7 As System.Windows.Forms.RadioButton
    Private isload As Boolean = False
    Friend WithEvents Radthuoc As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMaPhong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtGhiChu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenPhong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel_Button As Panel
    Private kieu As Int16

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
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhongBan))
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Radthuoc = New System.Windows.Forms.RadioButton()
        Me.r8 = New System.Windows.Forms.RadioButton()
        Me.r7 = New System.Windows.Forms.RadioButton()
        Me.r6 = New System.Windows.Forms.RadioButton()
        Me.r5 = New System.Windows.Forms.RadioButton()
        Me.r4 = New System.Windows.Forms.RadioButton()
        Me.r3 = New System.Windows.Forms.RadioButton()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtGhiChu = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenPhong = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaPhong = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenPhong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaPhong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'Radthuoc
        '
        Me.Radthuoc.AutoSize = True
        Me.Radthuoc.BackColor = System.Drawing.Color.Transparent
        Me.Radthuoc.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Radthuoc.ForeColor = System.Drawing.Color.Red
        Me.Radthuoc.Location = New System.Drawing.Point(679, 55)
        Me.Radthuoc.Name = "Radthuoc"
        Me.Radthuoc.Size = New System.Drawing.Size(61, 20)
        Me.Radthuoc.TabIndex = 13
        Me.Radthuoc.Text = "Thuốc"
        Me.Radthuoc.UseVisualStyleBackColor = False
        '
        'r8
        '
        Me.r8.AutoSize = True
        Me.r8.BackColor = System.Drawing.Color.Transparent
        Me.r8.Checked = True
        Me.r8.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r8.ForeColor = System.Drawing.Color.Red
        Me.r8.Location = New System.Drawing.Point(679, 79)
        Me.r8.Name = "r8"
        Me.r8.Size = New System.Drawing.Size(53, 20)
        Me.r8.TabIndex = 12
        Me.r8.TabStop = True
        Me.r8.Text = "Khác"
        Me.r8.UseVisualStyleBackColor = False
        '
        'r7
        '
        Me.r7.AutoSize = True
        Me.r7.BackColor = System.Drawing.Color.Transparent
        Me.r7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r7.ForeColor = System.Drawing.Color.Red
        Me.r7.Location = New System.Drawing.Point(679, 31)
        Me.r7.Name = "r7"
        Me.r7.Size = New System.Drawing.Size(61, 20)
        Me.r7.TabIndex = 11
        Me.r7.Text = "TT PT"
        Me.r7.UseVisualStyleBackColor = False
        '
        'r6
        '
        Me.r6.AutoSize = True
        Me.r6.BackColor = System.Drawing.Color.Transparent
        Me.r6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r6.ForeColor = System.Drawing.Color.Red
        Me.r6.Location = New System.Drawing.Point(572, 79)
        Me.r6.Name = "r6"
        Me.r6.Size = New System.Drawing.Size(74, 20)
        Me.r6.TabIndex = 10
        Me.r6.Text = "Điện tim"
        Me.r6.UseVisualStyleBackColor = False
        '
        'r5
        '
        Me.r5.AutoSize = True
        Me.r5.BackColor = System.Drawing.Color.Transparent
        Me.r5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r5.ForeColor = System.Drawing.Color.Red
        Me.r5.Location = New System.Drawing.Point(572, 55)
        Me.r5.Name = "r5"
        Me.r5.Size = New System.Drawing.Size(64, 20)
        Me.r5.TabIndex = 9
        Me.r5.Text = "Nội soi"
        Me.r5.UseVisualStyleBackColor = False
        '
        'r4
        '
        Me.r4.AutoSize = True
        Me.r4.BackColor = System.Drawing.Color.Transparent
        Me.r4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r4.ForeColor = System.Drawing.Color.Red
        Me.r4.Location = New System.Drawing.Point(572, 31)
        Me.r4.Name = "r4"
        Me.r4.Size = New System.Drawing.Size(89, 20)
        Me.r4.TabIndex = 8
        Me.r4.Text = "XQ - CĐHA"
        Me.r4.UseVisualStyleBackColor = False
        '
        'r3
        '
        Me.r3.AutoSize = True
        Me.r3.BackColor = System.Drawing.Color.Transparent
        Me.r3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r3.ForeColor = System.Drawing.Color.Red
        Me.r3.Location = New System.Drawing.Point(453, 79)
        Me.r3.Name = "r3"
        Me.r3.Size = New System.Drawing.Size(91, 20)
        Me.r3.TabIndex = 7
        Me.r3.Text = "Xét nghiệm"
        Me.r3.UseVisualStyleBackColor = False
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.BackColor = System.Drawing.Color.Transparent
        Me.r2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r2.ForeColor = System.Drawing.Color.Red
        Me.r2.Location = New System.Drawing.Point(453, 55)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(73, 20)
        Me.r2.TabIndex = 6
        Me.r2.Text = "Siêu âm"
        Me.r2.UseVisualStyleBackColor = False
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.BackColor = System.Drawing.Color.Transparent
        Me.r1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.r1.ForeColor = System.Drawing.Color.Red
        Me.r1.Location = New System.Drawing.Point(453, 31)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(96, 20)
        Me.r1.TabIndex = 5
        Me.r1.Text = "Phòng khám"
        Me.r1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mô tả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Phòng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Phòng"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(657, 15)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "&Thoát "
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(21, 15)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(128, 15)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 4
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(235, 15)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 7
        Me.btnHuy.Text = "&Bỏ qua "
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(342, 15)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "&sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(449, 15)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "&Xoá "
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 124)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(756, 310)
        Me.grv.TabIndex = 10
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.colten, Me.colgc})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã phòng"
        Me.colma.FieldName = "Maphong"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.OptionsColumn.AllowFocus = False
        Me.colma.OptionsColumn.FixedWidth = True
        Me.colma.Visible = True
        Me.colma.VisibleIndex = 0
        Me.colma.Width = 107
        '
        'colten
        '
        Me.colten.Caption = "Phòng ban"
        Me.colten.FieldName = "Tenphong"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 1
        Me.colten.Width = 313
        '
        'colgc
        '
        Me.colgc.Caption = "Mô tả"
        Me.colgc.FieldName = "ghichu"
        Me.colgc.Name = "colgc"
        Me.colgc.OptionsColumn.AllowEdit = False
        Me.colgc.OptionsColumn.AllowFocus = False
        Me.colgc.Visible = True
        Me.colgc.VisibleIndex = 2
        Me.colgc.Width = 318
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.TxtGhiChu)
        Me.GroupControl1.Controls.Add(Me.txtTenPhong)
        Me.GroupControl1.Controls.Add(Me.txtMaPhong)
        Me.GroupControl1.Controls.Add(Me.Radthuoc)
        Me.GroupControl1.Controls.Add(Me.r3)
        Me.GroupControl1.Controls.Add(Me.r8)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.r7)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.r6)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.r5)
        Me.GroupControl1.Controls.Add(Me.r4)
        Me.GroupControl1.Controls.Add(Me.r2)
        Me.GroupControl1.Controls.Add(Me.r1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(756, 120)
        Me.GroupControl1.TabIndex = 11
        Me.GroupControl1.Text = "Thông tin phòng ban"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(98, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(98, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 108
        Me.Label19.Text = "*"
        '
        'TxtGhiChu
        '
        Me.TxtGhiChu.Location = New System.Drawing.Point(120, 84)
        Me.TxtGhiChu.Name = "TxtGhiChu"
        Me.TxtGhiChu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtGhiChu.Properties.Appearance.Options.UseFont = True
        Me.TxtGhiChu.Properties.AutoHeight = False
        Me.TxtGhiChu.Size = New System.Drawing.Size(316, 24)
        Me.TxtGhiChu.TabIndex = 107
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Location = New System.Drawing.Point(120, 57)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTenPhong.Properties.Appearance.Options.UseFont = True
        Me.txtTenPhong.Properties.AutoHeight = False
        Me.txtTenPhong.Size = New System.Drawing.Size(316, 24)
        Me.txtTenPhong.TabIndex = 107
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Location = New System.Drawing.Point(120, 30)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMaPhong.Properties.Appearance.Options.UseFont = True
        Me.txtMaPhong.Properties.AutoHeight = False
        Me.txtMaPhong.Size = New System.Drawing.Size(155, 24)
        Me.txtMaPhong.TabIndex = 107
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 438)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(756, 52)
        Me.Panel_Button.TabIndex = 12
        '
        'frmPhongBan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(756, 490)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPhongBan"
        Me.Text = "DANH MỤC PHÒNG BAN"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenPhong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaPhong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPhongBan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        Ctrl_QuyenForm(Me)
        isload = True
    End Sub
    Private Sub LoadData()
        'Dim obj As New localhost.Service1
        'Dim dts As New DataSet
        Dim dtb As New DataTable
        dtb = Load_DataTable("SELECT Maphong,Tenphong,ghichu,ID,Loai From Phong_Ban", CNNQLPHONGKHAM)
        Me.grv.DataSource = dtb
        Me.txtMaPhong.Enabled = False
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtMaPhong.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtMaPhong, "Trường mã tiền tệ không để rỗng")
            ErrPro.SetIconAlignment(Me.txtMaPhong, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtTenPhong.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtTenPhong, "Trường tên tiền tệ không để rỗng")
            ErrPro.SetIconAlignment(Me.txtTenPhong, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        ID = 0
        Clear_Control(Me.GroupControl1)
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        Me.GroupControl1.Enabled = True
        Me.txtMaPhong.Enabled = True
        isload = False
    End Sub

    Private Sub btnCap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim cls As New ClsPhongBan
        If Kiem_Tra() = True Then
            If Flag = True Then
                If cls.Adddnew(Me.txtMaPhong.Text, Me.txtTenPhong.Text, Me.TxtGhiChu.Text, 1, kieu) = True Then
                    MsgBox("Chú ý! Mã tiền đã tồn tại", MsgBoxStyle.Critical)
                End If
            Else
                If cls.Update(Me.txtMaPhong.Text, Me.txtTenPhong.Text, Me.TxtGhiChu.Text, 2, ID, kieu) Then
                    MsgBox("Chú ý! Mã phòng đã tồn tại", MsgBoxStyle.Critical)
                End If
            End If
            LoadData()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Flag = False
            ErrPro.Dispose()
            isload = True
        End If
    End Sub

    Private Sub btnHuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.GroupControl1.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
    End Sub

    Private Sub btnSua_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Flag = False
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
    End Sub

    Private Sub btnXoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim cls As New ClsPhongBan
        If Me.txtMaPhong.Text = "" Then
            MsgBox("bạn chưa chọn đối tượng để xóa!", MsgBoxStyle.Critical, "Thông báo...")
        Else
            If MsgBox("Bạn có thật sự muốn xoá bản ghi này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cls.Delete(Me.txtMaPhong.Text, 3)

                LoadData()
            End If
            Clear_Control(Me.GroupControl1)
        End If
        isload = True
    End Sub
    Private Sub frmPhongBan_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim dtb As New DataTable
        dtb = Load_DataTable("Select Maphong from Phong_Ban where ID=(select Max(ID) from Phong_Ban)", CNNQLPHONGKHAM)
        If dtb.Rows.Count > 0 Then
            IDmoi = dtb.Rows(0)("Maphong")
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
                    Me.txtMaPhong.Text = dr("Maphong")
                    Me.txtTenPhong.Text = dr("Tenphong")
                    Me.TxtGhiChu.Text = dr("Ghichu").ToString
                    ID = dr("ID")
                    If Not dr("Loai") Is DBNull.Value Then
                        If dr("Loai") = 1 Then
                            r1.Checked = True
                        ElseIf dr("Loai") = 2 Then
                            r2.Checked = True
                        ElseIf dr("Loai") = 3 Then
                            r3.Checked = True
                        ElseIf dr("Loai") = 4 Then
                            r4.Checked = True
                        ElseIf dr("Loai") = 5 Then
                            r5.Checked = True
                        ElseIf dr("Loai") = 6 Then
                            r6.Checked = True
                        ElseIf dr("Loai") = 7 Then
                            r7.Checked = True
                        ElseIf dr("loai") = 8 Then
                            r8.Checked = True
                        Else
                            Radthuoc.Checked = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub loadKieu()
        If r1.Checked = True Then
            kieu = 1
        ElseIf r2.Checked = True Then
            kieu = 2
        ElseIf r3.Checked = True Then
            kieu = 3
        ElseIf r4.Checked = True Then
            kieu = 4
        ElseIf r5.Checked = True Then
            kieu = 5
        ElseIf r6.Checked = True Then
            kieu = 6
        ElseIf r7.Checked = True Then
            kieu = 7
        ElseIf Radthuoc.Checked = True Then
            kieu = 9
        Else
            kieu = 8
        End If
    End Sub

    Private Sub r1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.CheckedChanged
        loadKieu()
    End Sub

    Private Sub r2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r2.CheckedChanged
        loadKieu()
    End Sub

    Private Sub r3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r3.CheckedChanged
        loadKieu()
    End Sub

    Private Sub r4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r4.CheckedChanged
        loadKieu()
    End Sub

    Private Sub r5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r5.CheckedChanged
        loadKieu()
    End Sub

    Private Sub r6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r6.CheckedChanged
        loadKieu()
    End Sub

    Private Sub r7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r7.CheckedChanged
        loadKieu()
    End Sub

    Private Sub r8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r8.CheckedChanged
        loadKieu()
    End Sub

    Private Sub Radthuoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radthuoc.CheckedChanged
        loadKieu()
    End Sub
End Class
