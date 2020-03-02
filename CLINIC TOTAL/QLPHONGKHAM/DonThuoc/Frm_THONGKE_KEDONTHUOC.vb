Public Class Frm_THONGKE_KEDONTHUOC
    Inherits frmBase 'System.Windows.Forms.Form
    Public ok As Integer = False
    Private dtb As New DataTable
    Private strSQL As String
    Private Tongtienkham As Double
    Private Tongtientrietkhau As Double
    Private Tongtienthanhtoan As Double
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad_chuaxuat As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_tatca As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_xuat As System.Windows.Forms.RadioButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn_xuatthuoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnXuatThuoc As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private Tongtiennolai As Double

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
    Friend WithEvents grdDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn_sophieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ngaynhanmay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Donvi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Khachhang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tenhuhong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Huy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMaBN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbbacsy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSophieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupHuy As System.Windows.Forms.GroupBox
    Friend WithEvents Radio_kohuy As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHuy As System.Windows.Forms.RadioButton
    Friend WithEvents txtTongsophieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSophieukham As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_THONGKE_KEDONTHUOC))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grdDetail = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn_sophieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ngaynhanmay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Donvi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Khachhang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tenhuhong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Huy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn_xuatthuoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnXuatThuoc = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rad_chuaxuat = New System.Windows.Forms.RadioButton()
        Me.Rad_tatca = New System.Windows.Forms.RadioButton()
        Me.Rad_xuat = New System.Windows.Forms.RadioButton()
        Me.cmbMaBN = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTongsophieu = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbbacsy = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtSophieu = New DevExpress.XtraEditors.TextEdit()
        Me.GroupHuy = New System.Windows.Forms.GroupBox()
        Me.Radio_kohuy = New System.Windows.Forms.RadioButton()
        Me.RadioAll = New System.Windows.Forms.RadioButton()
        Me.RadioHuy = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSophieukham = New DevExpress.XtraEditors.TextEdit()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnXuatThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbMaBN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongsophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbacsy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupHuy.SuspendLayout()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieukham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDetail
        '
        Me.grdDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.grdDetail.Location = New System.Drawing.Point(1, 132)
        Me.grdDetail.MainView = Me.GridView1
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnXuatThuoc})
        Me.grdDetail.Size = New System.Drawing.Size(887, 467)
        Me.grdDetail.TabIndex = 87
        Me.grdDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_sophieu, Me.Ngaynhanmay, Me.Donvi, Me.Khachhang, Me.Tenhuhong, Me.ID, Me.Huy, Me.GridColumn1, Me.GridColumn_xuatthuoc})
        Me.GridView1.GridControl = Me.grdDetail
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn_sophieu, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn_sophieu
        '
        Me.GridColumn_sophieu.Caption = "Số phiếu"
        Me.GridColumn_sophieu.FieldName = "Sophieu"
        Me.GridColumn_sophieu.Name = "GridColumn_sophieu"
        Me.GridColumn_sophieu.OptionsColumn.AllowEdit = False
        Me.GridColumn_sophieu.Visible = True
        Me.GridColumn_sophieu.VisibleIndex = 0
        Me.GridColumn_sophieu.Width = 83
        '
        'Ngaynhanmay
        '
        Me.Ngaynhanmay.Caption = "Ngày lập"
        Me.Ngaynhanmay.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Ngaynhanmay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Ngaynhanmay.FieldName = "Ngay"
        Me.Ngaynhanmay.Name = "Ngaynhanmay"
        Me.Ngaynhanmay.OptionsColumn.AllowEdit = False
        Me.Ngaynhanmay.Visible = True
        Me.Ngaynhanmay.VisibleIndex = 1
        Me.Ngaynhanmay.Width = 108
        '
        'Donvi
        '
        Me.Donvi.Caption = "Mã BN"
        Me.Donvi.FieldName = "MaBN"
        Me.Donvi.Name = "Donvi"
        Me.Donvi.OptionsColumn.AllowEdit = False
        Me.Donvi.Visible = True
        Me.Donvi.VisibleIndex = 2
        Me.Donvi.Width = 102
        '
        'Khachhang
        '
        Me.Khachhang.Caption = "Tên BN"
        Me.Khachhang.FieldName = "TenBN"
        Me.Khachhang.Name = "Khachhang"
        Me.Khachhang.OptionsColumn.AllowEdit = False
        Me.Khachhang.Visible = True
        Me.Khachhang.VisibleIndex = 3
        Me.Khachhang.Width = 180
        '
        'Tenhuhong
        '
        Me.Tenhuhong.Caption = "Bác sỹ"
        Me.Tenhuhong.FieldName = "Bacsy"
        Me.Tenhuhong.Name = "Tenhuhong"
        Me.Tenhuhong.OptionsColumn.AllowEdit = False
        Me.Tenhuhong.Visible = True
        Me.Tenhuhong.VisibleIndex = 4
        Me.Tenhuhong.Width = 177
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "IDphieu"
        Me.ID.MinWidth = 10
        Me.ID.Name = "ID"
        Me.ID.OptionsColumn.AllowEdit = False
        Me.ID.Width = 93
        '
        'Huy
        '
        Me.Huy.Caption = "Huỷ"
        Me.Huy.FieldName = "Huy"
        Me.Huy.MinWidth = 10
        Me.Huy.Name = "Huy"
        Me.Huy.OptionsColumn.AllowEdit = False
        Me.Huy.Visible = True
        Me.Huy.VisibleIndex = 5
        Me.Huy.Width = 37
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Loại đơn"
        Me.GridColumn1.FieldName = "LoaiDon"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 93
        '
        'GridColumn_xuatthuoc
        '
        Me.GridColumn_xuatthuoc.Caption = "Xuất thuốc"
        Me.GridColumn_xuatthuoc.ColumnEdit = Me.btnXuatThuoc
        Me.GridColumn_xuatthuoc.Name = "GridColumn_xuatthuoc"
        Me.GridColumn_xuatthuoc.OptionsColumn.FixedWidth = True
        Me.GridColumn_xuatthuoc.Visible = True
        Me.GridColumn_xuatthuoc.VisibleIndex = 6
        Me.GridColumn_xuatthuoc.Width = 70
        '
        'btnXuatThuoc
        '
        Me.btnXuatThuoc.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnXuatThuoc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnXuatThuoc.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnXuatThuoc.Name = "btnXuatThuoc"
        Me.btnXuatThuoc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbMaBN)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnXem)
        Me.GroupBox1.Controls.Add(Me.txtTongsophieu)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbbacsy)
        Me.GroupBox1.Controls.Add(Me.txtSophieu)
        Me.GroupBox1.Controls.Add(Me.GroupHuy)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpTu_ngay)
        Me.GroupBox1.Controls.Add(Me.dtpDen_ngay)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSophieukham)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 129)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tìm kiếm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rad_chuaxuat)
        Me.GroupBox2.Controls.Add(Me.Rad_tatca)
        Me.GroupBox2.Controls.Add(Me.Rad_xuat)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(437, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(105, 105)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        '
        'Rad_chuaxuat
        '
        Me.Rad_chuaxuat.AutoSize = True
        Me.Rad_chuaxuat.BackColor = System.Drawing.Color.Transparent
        Me.Rad_chuaxuat.Checked = True
        Me.Rad_chuaxuat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_chuaxuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad_chuaxuat.Location = New System.Drawing.Point(11, 45)
        Me.Rad_chuaxuat.Name = "Rad_chuaxuat"
        Me.Rad_chuaxuat.Size = New System.Drawing.Size(84, 20)
        Me.Rad_chuaxuat.TabIndex = 15
        Me.Rad_chuaxuat.TabStop = True
        Me.Rad_chuaxuat.Text = "Chưa xuất"
        Me.Rad_chuaxuat.UseVisualStyleBackColor = False
        '
        'Rad_tatca
        '
        Me.Rad_tatca.AutoSize = True
        Me.Rad_tatca.BackColor = System.Drawing.Color.Transparent
        Me.Rad_tatca.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_tatca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad_tatca.Location = New System.Drawing.Point(11, 74)
        Me.Rad_tatca.Name = "Rad_tatca"
        Me.Rad_tatca.Size = New System.Drawing.Size(62, 20)
        Me.Rad_tatca.TabIndex = 14
        Me.Rad_tatca.Text = "Tẩt cả"
        Me.Rad_tatca.UseVisualStyleBackColor = False
        '
        'Rad_xuat
        '
        Me.Rad_xuat.AutoSize = True
        Me.Rad_xuat.BackColor = System.Drawing.Color.Transparent
        Me.Rad_xuat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_xuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rad_xuat.Location = New System.Drawing.Point(11, 16)
        Me.Rad_xuat.Name = "Rad_xuat"
        Me.Rad_xuat.Size = New System.Drawing.Size(70, 20)
        Me.Rad_xuat.TabIndex = 16
        Me.Rad_xuat.Text = "Đã xuất"
        Me.Rad_xuat.UseVisualStyleBackColor = False
        '
        'cmbMaBN
        '
        Me.cmbMaBN.AllowDrop = True
        Me.cmbMaBN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbMaBN.Location = New System.Drawing.Point(130, 47)
        Me.cmbMaBN.Name = "cmbMaBN"
        Me.cmbMaBN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbMaBN.Properties.Appearance.Options.UseFont = True
        Me.cmbMaBN.Properties.AutoHeight = False
        Me.cmbMaBN.Properties.AutoSearchColumnIndex = 1
        Me.cmbMaBN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMaBN.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MABN", "Mã BN", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HOTEN", "Tên BN", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbMaBN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbMaBN.Properties.NullText = ""
        Me.cmbMaBN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbMaBN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMaBN.Size = New System.Drawing.Size(296, 22)
        Me.cmbMaBN.TabIndex = 109
        Me.cmbMaBN.Tag = ""
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnThoat.Location = New System.Drawing.Point(787, 82)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 94
        Me.btnThoat.Text = "&Thoát"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(695, 82)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 93
        Me.btnXem.Text = "&Xem"
        '
        'txtTongsophieu
        '
        Me.txtTongsophieu.EditValue = ""
        Me.txtTongsophieu.Location = New System.Drawing.Point(130, 97)
        Me.txtTongsophieu.Name = "txtTongsophieu"
        Me.txtTongsophieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTongsophieu.Properties.Appearance.Options.UseFont = True
        Me.txtTongsophieu.Properties.AutoHeight = False
        Me.txtTongsophieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongsophieu.Size = New System.Drawing.Size(96, 22)
        Me.txtTongsophieu.TabIndex = 104
        Me.txtTongsophieu.Tag = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(23, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 22)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Tổng số phiếu:"
        '
        'cmbbacsy
        '
        Me.cmbbacsy.AllowDrop = True
        Me.cmbbacsy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbbacsy.Location = New System.Drawing.Point(130, 72)
        Me.cmbbacsy.Name = "cmbbacsy"
        Me.cmbbacsy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbbacsy.Properties.Appearance.Options.UseFont = True
        Me.cmbbacsy.Properties.AutoHeight = False
        Me.cmbbacsy.Properties.AutoSearchColumnIndex = 1
        Me.cmbbacsy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbacsy.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Mã", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Tên Bác sỹ", 105, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbbacsy.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbbacsy.Properties.NullText = ""
        Me.cmbbacsy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbbacsy.Properties.ValueMember = "Username"
        Me.cmbbacsy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbbacsy.Size = New System.Drawing.Size(296, 22)
        Me.cmbbacsy.TabIndex = 113
        Me.cmbbacsy.Tag = ""
        '
        'txtSophieu
        '
        Me.txtSophieu.EditValue = ""
        Me.txtSophieu.Location = New System.Drawing.Point(737, 18)
        Me.txtSophieu.Name = "txtSophieu"
        Me.txtSophieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSophieu.Properties.Appearance.Options.UseFont = True
        Me.txtSophieu.Properties.AutoHeight = False
        Me.txtSophieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSophieu.Size = New System.Drawing.Size(95, 22)
        Me.txtSophieu.TabIndex = 90
        '
        'GroupHuy
        '
        Me.GroupHuy.Controls.Add(Me.Radio_kohuy)
        Me.GroupHuy.Controls.Add(Me.RadioAll)
        Me.GroupHuy.Controls.Add(Me.RadioHuy)
        Me.GroupHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupHuy.ForeColor = System.Drawing.Color.Blue
        Me.GroupHuy.Location = New System.Drawing.Point(543, 10)
        Me.GroupHuy.Name = "GroupHuy"
        Me.GroupHuy.Size = New System.Drawing.Size(93, 105)
        Me.GroupHuy.TabIndex = 101
        Me.GroupHuy.TabStop = False
        '
        'Radio_kohuy
        '
        Me.Radio_kohuy.BackColor = System.Drawing.Color.Transparent
        Me.Radio_kohuy.Checked = True
        Me.Radio_kohuy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_kohuy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Radio_kohuy.Location = New System.Drawing.Point(10, 45)
        Me.Radio_kohuy.Name = "Radio_kohuy"
        Me.Radio_kohuy.Size = New System.Drawing.Size(72, 20)
        Me.Radio_kohuy.TabIndex = 15
        Me.Radio_kohuy.TabStop = True
        Me.Radio_kohuy.Text = "Kh huỷ"
        Me.Radio_kohuy.UseVisualStyleBackColor = False
        '
        'RadioAll
        '
        Me.RadioAll.BackColor = System.Drawing.Color.Transparent
        Me.RadioAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioAll.Location = New System.Drawing.Point(10, 16)
        Me.RadioAll.Name = "RadioAll"
        Me.RadioAll.Size = New System.Drawing.Size(75, 20)
        Me.RadioAll.TabIndex = 14
        Me.RadioAll.Text = "Tẩt cả"
        Me.RadioAll.UseVisualStyleBackColor = False
        '
        'RadioHuy
        '
        Me.RadioHuy.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioHuy.Location = New System.Drawing.Point(8, 74)
        Me.RadioHuy.Name = "RadioHuy"
        Me.RadioHuy.Size = New System.Drawing.Size(63, 20)
        Me.RadioHuy.TabIndex = 16
        Me.RadioHuy.Text = "Huỷ"
        Me.RadioHuy.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(660, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Đơn thuốc:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Bác sỹ kê đơn:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(244, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Đến ngày:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Từ ngày:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Bệnh nhân:"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(130, 24)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpTu_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpTu_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpTu_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpTu_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpTu_ngay.Size = New System.Drawing.Size(96, 20)
        Me.dtpTu_ngay.TabIndex = 85
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(322, 24)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpDen_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpDen_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpDen_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpDen_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDen_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpDen_ngay.Size = New System.Drawing.Size(104, 20)
        Me.dtpDen_ngay.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(660, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Số hồ sơ:"
        '
        'txtSophieukham
        '
        Me.txtSophieukham.EditValue = ""
        Me.txtSophieukham.Location = New System.Drawing.Point(737, 42)
        Me.txtSophieukham.Name = "txtSophieukham"
        Me.txtSophieukham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSophieukham.Properties.Appearance.Options.UseFont = True
        Me.txtSophieukham.Properties.AutoHeight = False
        Me.txtSophieukham.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSophieukham.Size = New System.Drawing.Size(95, 22)
        Me.txtSophieukham.TabIndex = 90
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(889, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 601)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(889, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 601)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(889, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 601)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Xuất thuốc"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Thoát"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Nạp lại"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'Frm_THONGKE_KEDONTHUOC
        '
        Me.AcceptButton = Me.btnXem
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.CancelButton = Me.btnThoat
        Me.ClientSize = New System.Drawing.Size(889, 601)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdDetail)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(916, 640)
        Me.Name = "Frm_THONGKE_KEDONTHUOC"
        Me.Text = "THỐNG KÊ HÓA ĐƠN -KÊ ĐƠN THUỐC"
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnXuatThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbMaBN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongsophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbacsy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupHuy.ResumeLayout(False)
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieukham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Frm_THONGKE_KEDONTHUOC_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ok = 1 Then
            LoadData()
            ok = 0
        End If
    End Sub

    Private Sub Frm_THONGKE_KEDONTHUOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.dtpTu_ngay.DateTime = NgayGioServer().Date
        Me.dtpDen_ngay.DateTime = NgayGioServer().Date.AddDays(1)
        Load_ComboBox("SELECT MABN,HOTENBN as HOTEN From HOSOBN", Me.cmbMaBN, CNNQLPHONGKHAM, True)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung ", Me.cmbbacsy, CNNQLPHONGKHAM)
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.ErrPro.Dispose()
        strSQL = "Select TB_kedonthuoc.Sophieu,TB_kedonthuoc.Ngay,TB_kedonthuoc.Bacsykedon,TB_kedonthuoc.Sotien,TB_kedonthuoc.IDSoPhieuKham, "
        strSQL &= "Upper(HOSOBN.Hotenbn) as TenBN, HOSOBN.MaBN,Nguoi_su_dung.Hoten as Bacsy,TB_kedonthuoc.IDphieu,TB_kedonthuoc.Huy, "
        strSQL &= "(Select Doituong from PHIEUKHAMBENH where SoPhieu=TB_kedonthuoc.Sophieukham) as Doituong,N'' as LoaiDon "
        strSQL &= "From TB_kedonthuoc join HOSOBN on TB_kedonthuoc.MaBN = HOSOBN.Mabn "
        strSQL &= "Join Nguoi_su_dung on TB_kedonthuoc.Bacsykedon = Nguoi_su_dung.Username Where 1=1 "
        If Me.Radio_kohuy.Checked = True Then
            strSQL &= "and Huy = 0 "
        ElseIf Me.RadioHuy.Checked = True Then
            strSQL &= "and Huy = 1 "
        End If
        If Me.Rad_xuat.Checked = True Then
            strSQL &= "and i_status = 1 "
        ElseIf Me.Rad_chuaxuat.Checked = True Then
            strSQL &= "and i_status = 0 "
        End If
        If Me.cmbbacsy.Text <> "" Then
            strSQL &= "and TB_kedonthuoc.Bacsykedon='" & cmbbacsy.EditValue & "' "
        End If
        If Me.cmbMaBN.Text <> "" Then
            strSQL &= "and TB_kedonthuoc.Mabn='" & cmbMaBN.EditValue & "' "
        End If
        If Me.dtpTu_ngay.Text <> "" And Me.dtpDen_ngay.Text <> "" Then
            strSQL &= "and datediff(d,'" & dtpTu_ngay.DateTime & "',TB_kedonthuoc.Ngay)>=0 and datediff(d,TB_kedonthuoc.Ngay,'" & dtpDen_ngay.DateTime & "')>=0"
        End If
        If Me.txtSophieu.Text <> "" Then
            If IsNumeric(Me.txtSophieu.Text) = False Then
                ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.ErrPro.SetError(Me.txtSophieu, "Trường số phiếu có giá trị bằng số, không phải bằng chữ")
                ErrPro.SetIconAlignment(Me.txtSophieu, ErrorIconAlignment.MiddleRight)
            Else
                strSQL &= "and TB_kedonthuoc.Sophieu='" & txtSophieu.Text & "' "
            End If
        End If
        If Me.txtSophieukham.Text <> "" Then
            strSQL &= "and TB_kedonthuoc.Sophieukham='" & cmbMaBN.EditValue & "' "
        End If
        dtb = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        Dim i As Int16
        Dim k As Int16 = 0
        For i = 0 To dtb.Rows.Count - 1
            k = k + 1
        Next
        Me.txtTongsophieu.Text = k
        Me.grdDetail.DataSource = dtb
        Me.GridView1.ExpandAllGroups()
    End Sub

    Private Sub grdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDetail.DoubleClick
        ok = 1
        Dim frm As New frm_kedonthuoc
        frm.blnType = False
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr.IsNew = False Then
                    frm.IDPhieuxuat &= dr("IDPhieu") & ","
                    If dr("Huy") = True Then
                        frm.blnDelete = True
                    End If
                End If
            End If
        End If
        Dim frm1 As Form
        frm.StartPosition = FormStartPosition.CenterScreen
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()

    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        LoadData()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub RadioAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioAll.CheckedChanged
        LoadData()
    End Sub

    Private Sub Radio_kohuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_kohuy.CheckedChanged
        LoadData()
    End Sub

    Private Sub RadioHuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioHuy.CheckedChanged
        LoadData()
    End Sub

    Private Sub cmbbacsy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbacsy.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbbacsy.EditValue = ""
        End If
    End Sub
    Private Sub cmbMaBN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMaBN.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbMaBN.EditValue = ""
        End If
    End Sub
    Private Sub GridView1_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim hitinfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(e.Point)
        If Rad_chuaxuat.Checked = True Then
            If hitinfo.InRowCell Then
                view.FocusedRowHandle = hitinfo.RowHandle
                PopupMenu1.ShowPopup(BarManager1, view.GridControl.PointToScreen(e.Point))
            End If
        Else
            MsgBox("Đã xuất thuốc rồi!", MsgBoxStyle.Critical, "Thông báo...")
        End If

    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim clsObjPxn As New clsXNKho
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr("Huy") = True Then
                    MsgBox("Đơn đã hủy", MsgBoxStyle.Critical, "Thông báo...")
                Else
                    If MsgBox("Bạn có chắc muốn xuất thuốc không?", MsgBoxStyle.YesNo, "Thông báo...") = MsgBoxResult.Yes Then
                        'update tb_kedonthuoc
                        Dim str As String = "update tb_kedonthuoc set i_status=1 where IDphieu='" & dr("IDPhieu") & "'"
                        If Command_Exc(str, CNNQLPHONGKHAM) = 0 Then
                            'insert Phieu_xuat_nhap  
                            Dim idsophieu As Integer = 0
                            Dim Sophieu As Integer = clsObjPxn.Lay_So_phieu(0)
                            Dim strSQL As String = ""
                            strSQL = "Insert into phieu_xuat_nhap ([Sophieu],[Loaiphieu],[Ngay],[MaXN],[Makho],[Madv],[Makh],[TienUSD],[Tygia],[VAT],[Quydoi],[Giavon],[TienVND],[Nguoinhap],[GhiChu],[Huy],[Sophieukham],[LoaiDonXuat]) values('" & clsObjPxn.Lay_So_phieu(0) & "',0,'" & NgayGioServer().Date & "','XTBHYT','KT',0,'" & dr("MaBN") & "','" & dr("Sotien") & "',0,0,'" & dr("Sotien") & "',0,0,'" & clsLoginObj.strUsername & "','',0,'" & dr("IDSoPhieuKham") & "',2)"
                            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                                'insert chi_tiet_pxn  
                                Dim strID As String = ""
                                Dim dtID As New DataTable
                                strID = "select IDphieuXN from phieu_xuat_nhap where sophieu='" & Sophieu & "'"
                                dtID = BusinessLogic.Data.GetDataset(strID, CommandType.Text, Nothing, Nothing).Tables(0)
                                idsophieu = dtID.Rows(0)(0)
                                strSQL = "insert into chi_tiet_pxn ([IDSophieu],[Masp],[Soluong],[Dongia],[DongiaVND],[VAT],[KhuyenMai],[Thanhtien],[ThanhtienVND],[Giathanh],[STT],[Trietkhau],[Lieudung],[HanSD],[Solo],[Ghichu]) select '" & idsophieu & "',masp,soluong,dongia,0,0,0,thanhtien,0,0,stt,0,'','','',N'Xuất thuốc' from Tb_Kedonthuoc_chitiet where idsophieu='" & dr("IDPhieu") & "'"
                                If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                                    Dim doituong As Int16
                                    Dim dtdt As New DataTable
                                    strSQL = "Select DoiTuong from HOSOBN where mabn='" & dr("MaBN") & "'"
                                    dtdt = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing).Tables(0)
                                    If dtdt.Rows.Count > 0 Then
                                        If Not dtdt.Rows(0)(0) Is DBNull.Value Then
                                            doituong = dtdt.Rows(0)(0)
                                        Else
                                            doituong = 1
                                        End If
                                    End If
                                    If doituong = 0 Then
                                        Dim sql As String
                                        sql = "delete from chi_tiet_new where RefNo='" & Sophieu & "'"
                                        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                                            sql = "Insert into Chi_tiet_NEW(IDSophieu,Masp,Soluong,Dongia,Thanhtien,STT,Mabn,DateLap,TotalAmount,Makho,LoaiDV,RefNo,Ghichu,KetluanChung)"
                                            sql &= "select '" & dr("IDSoPhieuKham") & "',masp,soluong,dongia,thanhtien,stt,'" & dr("MaBN") & "','" & NgayGioServer().Date & "','" & dr("Sotien") & "','KT',0,'" & Sophieu & "',N'Xuất thuốc',N'' from Tb_Kedonthuoc_chitiet where idsophieu='" & dr("IDPhieu") & "'"
                                            Command_Exc(sql, CNNQLPHONGKHAM)
                                        End If
                                    End If
                                    MsgBox("Xuất thuốc thành công", MsgBoxStyle.Information, "Thông báo...")
                                    LoadData()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        PopupMenu1.HidePopup()
    End Sub

    Private Sub Rad_chuaxuat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_chuaxuat.CheckedChanged
        LoadData()
    End Sub

    Private Sub Rad_xuat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_xuat.CheckedChanged
        LoadData()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LoadData()
    End Sub
    Private Sub btnXuatThuoc_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnXuatThuoc.ButtonClick
        ok = 1
        Dim frm As New frm_kedonthuoc
        frm.blnType = False
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr.IsNew = False Then
                    frm.IDPhieuxuat &= dr("IDPhieu") & ","
                    If dr("Huy") = True Then
                        frm.blnDelete = True
                    End If
                End If
            End If
        End If
        Dim frm1 As Form
        frm.StartPosition = FormStartPosition.CenterScreen
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub
End Class
