<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TKTonkhovatu
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_TKTonkhovatu))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbkho = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbnhom = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbTenThuoc = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.dtTuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dtDenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.colTienTon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdDanhSach = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMaSP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTenSP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonDau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colXuat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonCuoi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDonVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cmbkho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbnhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTenThuoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(506, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Kho hàng"
        '
        'cmbkho
        '
        Me.cmbkho.AllowDrop = True
        Me.cmbkho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbkho.Location = New System.Drawing.Point(579, 29)
        Me.cmbkho.Name = "cmbkho"
        Me.cmbkho.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbkho.Properties.Appearance.Options.UseFont = True
        Me.cmbkho.Properties.AutoHeight = False
        Me.cmbkho.Properties.AutoSearchColumnIndex = 1
        Me.cmbkho.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbkho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbkho.Properties.NullText = ""
        Me.cmbkho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbkho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbkho.Size = New System.Drawing.Size(145, 22)
        Me.cmbkho.TabIndex = 20
        Me.cmbkho.Tag = "MABN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(227, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nhóm VTYT"
        '
        'cmbnhom
        '
        Me.cmbnhom.AllowDrop = True
        Me.cmbnhom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbnhom.Location = New System.Drawing.Point(309, 29)
        Me.cmbnhom.Name = "cmbnhom"
        Me.cmbnhom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbnhom.Properties.Appearance.Options.UseFont = True
        Me.cmbnhom.Properties.AutoHeight = False
        Me.cmbnhom.Properties.AutoSearchColumnIndex = 1
        Me.cmbnhom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbnhom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbnhom.Properties.NullText = ""
        Me.cmbnhom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbnhom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbnhom.Size = New System.Drawing.Size(174, 22)
        Me.cmbnhom.TabIndex = 18
        Me.cmbnhom.Tag = "MABN"
        '
        'cmbTenThuoc
        '
        Me.cmbTenThuoc.AllowDrop = True
        Me.cmbTenThuoc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbTenThuoc.Location = New System.Drawing.Point(309, 55)
        Me.cmbTenThuoc.Name = "cmbTenThuoc"
        Me.cmbTenThuoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbTenThuoc.Properties.Appearance.Options.UseFont = True
        Me.cmbTenThuoc.Properties.AutoHeight = False
        Me.cmbTenThuoc.Properties.AutoSearchColumnIndex = 1
        Me.cmbTenThuoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTenThuoc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbTenThuoc.Properties.NullText = ""
        Me.cmbTenThuoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbTenThuoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTenThuoc.Size = New System.Drawing.Size(415, 22)
        Me.cmbTenThuoc.TabIndex = 16
        Me.cmbTenThuoc.Tag = "MABN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(227, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Tên VTYT"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(963, 41)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "&Thoát"
        '
        'dtTuNgay
        '
        Me.dtTuNgay.EditValue = New Date(2015, 10, 26, 14, 22, 46, 187)
        Me.dtTuNgay.Location = New System.Drawing.Point(93, 29)
        Me.dtTuNgay.Name = "dtTuNgay"
        Me.dtTuNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtTuNgay.Properties.Appearance.Options.UseFont = True
        Me.dtTuNgay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtTuNgay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtTuNgay.Properties.AutoHeight = False
        Me.dtTuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtTuNgay.Properties.NullDate = New Date(2015, 10, 26, 14, 22, 1, 76)
        Me.dtTuNgay.Size = New System.Drawing.Size(116, 22)
        Me.dtTuNgay.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(779, 41)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "&Xem"
        '
        'dtDenNgay
        '
        Me.dtDenNgay.EditValue = New Date(2015, 10, 26, 14, 23, 50, 820)
        Me.dtDenNgay.Location = New System.Drawing.Point(93, 55)
        Me.dtDenNgay.Name = "dtDenNgay"
        Me.dtDenNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtDenNgay.Properties.Appearance.Options.UseFont = True
        Me.dtDenNgay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtDenNgay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtDenNgay.Properties.AutoHeight = False
        Me.dtDenNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtDenNgay.Properties.NullDate = New Date(2015, 10, 26, 14, 23, 10, 115)
        Me.dtDenNgay.Size = New System.Drawing.Size(116, 22)
        Me.dtDenNgay.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Từ ngày"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(28, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Đến ngày"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.btnPrint)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.cmbkho)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.cmbnhom)
        Me.GroupControl1.Controls.Add(Me.dtDenNgay)
        Me.GroupControl1.Controls.Add(Me.cmbTenThuoc)
        Me.GroupControl1.Controls.Add(Me.dtTuNgay)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1084, 100)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Điều kiện tìm kiếm"
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Appearance.Options.UseForeColor = True
        Me.btnPrint.Location = New System.Drawing.Point(871, 41)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 25
        Me.btnPrint.Text = "&In TK"
        '
        'colTienTon
        '
        Me.colTienTon.Caption = "Tiền tồn"
        Me.colTienTon.FieldName = "TongTienTon"
        Me.colTienTon.Name = "colTienTon"
        Me.colTienTon.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienTon", "{0:0.##}")})
        Me.colTienTon.Width = 118
        '
        'colGiaNhap
        '
        Me.colGiaNhap.Caption = "Giá nhập"
        Me.colGiaNhap.FieldName = "DonGia"
        Me.colGiaNhap.Name = "colGiaNhap"
        Me.colGiaNhap.Width = 102
        '
        'grdDanhSach
        '
        Me.grdDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach.Location = New System.Drawing.Point(0, 102)
        Me.grdDanhSach.MainView = Me.GridView1
        Me.grdDanhSach.Name = "grdDanhSach"
        Me.grdDanhSach.Size = New System.Drawing.Size(1084, 415)
        Me.grdDanhSach.TabIndex = 16
        Me.grdDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaSP, Me.colTenSP, Me.colTonDau, Me.colNhap, Me.colXuat, Me.colTonCuoi, Me.GridColumn1, Me.GridColumn2, Me.colDonVT, Me.colSTT})
        Me.GridView1.GridControl = Me.grdDanhSach
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colMaSP
        '
        Me.colMaSP.Caption = "Mã SP"
        Me.colMaSP.FieldName = "MaSP"
        Me.colMaSP.Name = "colMaSP"
        Me.colMaSP.OptionsColumn.FixedWidth = True
        Me.colMaSP.Visible = True
        Me.colMaSP.VisibleIndex = 1
        Me.colMaSP.Width = 79
        '
        'colTenSP
        '
        Me.colTenSP.Caption = "Tên vật tư y tế"
        Me.colTenSP.FieldName = "TenThuoc"
        Me.colTenSP.Name = "colTenSP"
        Me.colTenSP.Visible = True
        Me.colTenSP.VisibleIndex = 2
        Me.colTenSP.Width = 230
        '
        'colTonDau
        '
        Me.colTonDau.Caption = "Tồn đầu"
        Me.colTonDau.FieldName = "tondau"
        Me.colTonDau.Name = "colTonDau"
        Me.colTonDau.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tondau", "{0:0.##}")})
        Me.colTonDau.Visible = True
        Me.colTonDau.VisibleIndex = 4
        Me.colTonDau.Width = 106
        '
        'colNhap
        '
        Me.colNhap.Caption = "Nhập"
        Me.colNhap.FieldName = "TongNhap"
        Me.colNhap.Name = "colNhap"
        Me.colNhap.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongNhap", "{0:0.##}")})
        Me.colNhap.Visible = True
        Me.colNhap.VisibleIndex = 5
        Me.colNhap.Width = 113
        '
        'colXuat
        '
        Me.colXuat.Caption = "Xuất"
        Me.colXuat.FieldName = "TongXuat"
        Me.colXuat.Name = "colXuat"
        Me.colXuat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongXuat", "{0:0.##}")})
        Me.colXuat.Visible = True
        Me.colXuat.VisibleIndex = 6
        Me.colXuat.Width = 109
        '
        'colTonCuoi
        '
        Me.colTonCuoi.Caption = "Tồn cuối"
        Me.colTonCuoi.FieldName = "TongTon"
        Me.colTonCuoi.Name = "colTonCuoi"
        Me.colTonCuoi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTon", "{0:0.##}")})
        Me.colTonCuoi.Visible = True
        Me.colTonCuoi.VisibleIndex = 7
        Me.colTonCuoi.Width = 96
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Giá nhập"
        Me.GridColumn1.FieldName = "DonGia"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        Me.GridColumn1.Width = 102
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tiền tồn"
        Me.GridColumn2.FieldName = "TongTienTon"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienTon", "{0:0.##}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 9
        Me.GridColumn2.Width = 118
        '
        'colDonVT
        '
        Me.colDonVT.Caption = "Đơn vị tính"
        Me.colDonVT.FieldName = "DVT"
        Me.colDonVT.Name = "colDonVT"
        Me.colDonVT.OptionsColumn.FixedWidth = True
        Me.colDonVT.Visible = True
        Me.colDonVT.VisibleIndex = 3
        Me.colDonVT.Width = 65
        '
        'colSTT
        '
        Me.colSTT.Caption = "STT"
        Me.colSTT.FieldName = "STT"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.OptionsColumn.FixedWidth = True
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 0
        Me.colSTT.Width = 48
        '
        'FRM_TKTonkhovatu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 517)
        Me.Controls.Add(Me.grdDanhSach)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_TKTonkhovatu"
        Me.Text = "THỐNG KÊ TỒN KHO VẬT TƯ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cmbkho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbnhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTenThuoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbkho As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbnhom As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbTenThuoc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtTuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtDenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTienTon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMaSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTenSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonDau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colXuat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonCuoi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDonVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTT As DevExpress.XtraGrid.Columns.GridColumn
End Class
