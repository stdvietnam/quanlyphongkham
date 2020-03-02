Public Class frmTon_quy
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean
    Private ID As Int16
    Private foundclick As Boolean = True
    Private thanhcong As Boolean

    Friend WithEvents Panel_Button As Panel
    Friend WithEvents grdDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Errpro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grb As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sotienUSD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbTenquy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtNgaynhap As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SotienVND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTon_quy))
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.Errpro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sotienUSD = New DevExpress.XtraEditors.TextEdit()
        Me.cmbTenquy = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtNgaynhap = New DevExpress.XtraEditors.DateEdit()
        Me.SotienVND = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        Me.grdDanhSach = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.Errpro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        CType(Me.sotienUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTenquy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaynhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaynhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SotienVND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(504, 8)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "&Thoát"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(407, 8)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "&Xoá"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(310, 8)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "&Sửa"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(213, 8)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 6
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(116, 8)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 5
        Me.btnCap_nhat.Text = "&Cập nhật "
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(19, 8)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 7
        Me.btnThem.Text = "&Nhập  mới"
        '
        'Errpro
        '
        Me.Errpro.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(336, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 7
        '
        'Grb
        '
        Me.Grb.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Grb.Controls.Add(Me.Label5)
        Me.Grb.Controls.Add(Me.sotienUSD)
        Me.Grb.Controls.Add(Me.cmbTenquy)
        Me.Grb.Controls.Add(Me.dtNgaynhap)
        Me.Grb.Controls.Add(Me.SotienVND)
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Controls.Add(Me.Label8)
        Me.Grb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb.ForeColor = System.Drawing.Color.Red
        Me.Grb.Location = New System.Drawing.Point(0, 0)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(600, 93)
        Me.Grb.TabIndex = 7
        Me.Grb.TabStop = False
        Me.Grb.Text = "Thông tin nhập"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 14)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Ngày nhập"
        '
        'sotienUSD
        '
        Me.sotienUSD.EditValue = "0"
        Me.sotienUSD.Location = New System.Drawing.Point(416, 20)
        Me.sotienUSD.Name = "sotienUSD"
        Me.sotienUSD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sotienUSD.Properties.Appearance.Options.UseFont = True
        Me.sotienUSD.Properties.AutoHeight = False
        Me.sotienUSD.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.sotienUSD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sotienUSD.Properties.EditFormat.FormatString = "###,###.00"
        Me.sotienUSD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sotienUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sotienUSD.Size = New System.Drawing.Size(160, 24)
        Me.sotienUSD.TabIndex = 3
        '
        'cmbTenquy
        '
        Me.cmbTenquy.AllowDrop = True
        Me.cmbTenquy.EditValue = ""
        Me.cmbTenquy.Location = New System.Drawing.Point(96, 52)
        Me.cmbTenquy.Name = "cmbTenquy"
        Me.cmbTenquy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbTenquy.Properties.Appearance.Options.UseFont = True
        Me.cmbTenquy.Properties.AutoHeight = False
        Me.cmbTenquy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTenquy.Properties.NullText = ""
        Me.cmbTenquy.Size = New System.Drawing.Size(200, 24)
        Me.cmbTenquy.TabIndex = 2
        '
        'dtNgaynhap
        '
        Me.dtNgaynhap.EditValue = New Date(2005, 5, 31, 0, 0, 0, 0)
        Me.dtNgaynhap.Location = New System.Drawing.Point(96, 20)
        Me.dtNgaynhap.Name = "dtNgaynhap"
        Me.dtNgaynhap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtNgaynhap.Properties.Appearance.Options.UseFont = True
        Me.dtNgaynhap.Properties.AutoHeight = False
        Me.dtNgaynhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgaynhap.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtNgaynhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgaynhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtNgaynhap.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgaynhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtNgaynhap.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtNgaynhap.ShowToolTips = False
        Me.dtNgaynhap.Size = New System.Drawing.Size(106, 24)
        Me.dtNgaynhap.TabIndex = 1
        Me.dtNgaynhap.TabStop = False
        '
        'SotienVND
        '
        Me.SotienVND.AllowDrop = True
        Me.SotienVND.EditValue = "0"
        Me.SotienVND.Location = New System.Drawing.Point(416, 52)
        Me.SotienVND.Name = "SotienVND"
        Me.SotienVND.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SotienVND.Properties.Appearance.Options.UseFont = True
        Me.SotienVND.Properties.AutoHeight = False
        Me.SotienVND.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.SotienVND.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SotienVND.Properties.EditFormat.FormatString = "###,###.00"
        Me.SotienVND.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SotienVND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SotienVND.Size = New System.Drawing.Size(160, 24)
        Me.SotienVND.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 14)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tên quỹ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(320, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 14)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Số tiền USD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(320, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Số  tiền VNĐ"
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 419)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(600, 43)
        Me.Panel_Button.TabIndex = 12
        '
        'grdDanhSach
        '
        Me.grdDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach.Location = New System.Drawing.Point(0, 94)
        Me.grdDanhSach.MainView = Me.GridView1
        Me.grdDanhSach.Name = "grdDanhSach"
        Me.grdDanhSach.Size = New System.Drawing.Size(600, 319)
        Me.grdDanhSach.TabIndex = 13
        Me.grdDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.GridControl = Me.grdDanhSach
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mã quỹ"
        Me.GridColumn2.FieldName = "maquy"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tên quỹ"
        Me.GridColumn3.FieldName = "tenquy"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Ngày"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "ngay"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tồn cuối VNĐ"
        Me.GridColumn5.DisplayFormat.FormatString = "###,###"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "toncuoiVND"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tồn cuối USD"
        Me.GridColumn6.DisplayFormat.FormatString = "###,###"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "toncuoiUSD"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'frmTon_quy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 462)
        Me.Controls.Add(Me.grdDanhSach)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.Grb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmTon_quy"
        Me.Text = "NHẬP TỒN QUỸ ĐẦU KỲ"
        CType(Me.Errpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.sotienUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTenquy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaynhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaynhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SotienVND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTon_quy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim strSQL As String
        Dim dtb As DataTable
        strSQL = "SELECT Ngayketchuyen FROM Ket_chuyen WHERE ID=(SELECT Max(ID)FROM Ket_chuyen)"
        dtb = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        If dtb.Rows.Count > 0 Then
            Me.dtNgaynhap.DateTime = dtb.Rows(0)("Ngayketchuyen")
        End If
        Load_ComboBox("Select Maquy,Tenquy from ctquy ", Me.cmbTenquy, CNNQLPHONGKHAM)
        dtNgaynhap.DateTime = DateTime.Now
        Me.dtNgaynhap.Enabled = True
        loaddata()
        Ctrl_QuyenForm(Me)
        Me.grdDanhSach.Enabled = True
    End Sub
    Private Sub loaddata()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim dtbTon_quyBackup As New DataTable
        Dim sql As String = "Select ngay,ctquy.tenquy,Ton_quyBackup.toncuoiUSD,Ton_quyBackup.toncuoiVND,Ton_quyBackup.id,ctquy.maquy From Ton_quyBackup inner join ctquy on Ton_quyBackup.maquy=ctquy.maquy where Datediff(d,ngay,'" & dtNgaynhap.DateTime & "')=0"
        dtbTon_quyBackup = BusinessLogic.Data.GetDataset(sql).Tables(0)
        Me.grdDanhSach.DataSource = dtbTon_quyBackup
        Me.btnCap_nhat.Enabled = False
        Me.btnHuy.Enabled = False
    End Sub
    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        ID = 0
        Me.dtNgaynhap.DateTime = DateTime.Now
        Me.sotienUSD.Text = "0"
        Me.SotienVND.Text = "0"
        Me.cmbTenquy.Text = ""
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Me.cmbTenquy.EditValue <> "" Then
            Dim cls As New clston_quy
            If Flag = True Then
                If cls.addnew(Me.cmbTenquy.EditValue, Me.dtNgaynhap.DateTime, Val(Chuanhoa(Me.sotienUSD.Text)), Val(Chuanhoa(Me.SotienVND.Text)), 1) = True Then
                    MsgBox("Chú ý! Mã quỹ  đã tồn tại", MsgBoxStyle.Critical)
                    thanhcong = True
                End If
            Else
                If cls.update(Me.cmbTenquy.EditValue, Me.dtNgaynhap.DateTime, Val(Chuanhoa(Me.sotienUSD.Text)), Val(Chuanhoa(Me.SotienVND.Text)), 2, ID) = True Then
                    MsgBox("Chú ý! Mã quỹ đã tồn tại", MsgBoxStyle.Critical)
                    thanhcong = True
                End If
            End If
            loaddata()
            If thanhcong = False Then
                Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Else
                Ctrl_QuyenForm(Me)
            End If
            Flag = False
            Errpro.Dispose()
        Else
            MsgBox("Chưa chọn quỹ!!!")
        End If
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.Grb.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Flag = False
        Me.Grb.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim cls As New clston_quy
        If MsgBox("Bạn có thật sự muốn xoá bản ghi này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cls.delete(Me.cmbTenquy.EditValue, 3)
            loaddata()
        End If
        Clear_Control(Me.Grb)
    End Sub
    Private Sub Ngaynhap_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtNgaynhap.EditValueChanged
        loaddata()
        Me.btnCap_nhat.Enabled = True
        Me.btnHuy.Enabled = True
    End Sub
    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle())
        If Not dr Is Nothing Then
            If Not dr("ngay") Is DBNull.Value Then
                Me.dtNgaynhap.DateTime = dr("ngay")
            End If
            If Not dr("maquy") Is DBNull.Value Then
                Me.cmbTenquy.EditValue = dr("maquy")
            Else
                Me.cmbTenquy.EditValue = ""
            End If
            If Not dr("toncuoiVND") Is DBNull.Value Then
                Me.SotienVND.EditValue = dr("toncuoiVND")
            Else
                Me.SotienVND.EditValue = "0"
            End If
            If Not dr("toncuoiUSD") Is DBNull.Value Then
                Me.sotienUSD.EditValue = dr("toncuoiUSD")
            Else
                Me.sotienUSD.EditValue = "0"
            End If
            If Not dr("id") Is DBNull.Value Then
                ID = dr("ID")
            End If
        End If
    End Sub
End Class
