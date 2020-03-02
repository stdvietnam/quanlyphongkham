<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTKTonKhoKhoaDuoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTKTonKhoKhoaDuoc))
        Me.dtTuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbNhomsp = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbnhom = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbTenThuoc = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbkho = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdDanhSach = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMaSP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTenSP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonDau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colXuat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonCuoi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTienTon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDonVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.dtTuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhomsp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbnhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTenThuoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbkho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtTuNgay
        '
        Me.dtTuNgay.EditValue = New Date(2015, 10, 26, 14, 22, 46, 187)
        Me.dtTuNgay.Location = New System.Drawing.Point(102, 36)
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
        Me.dtTuNgay.Size = New System.Drawing.Size(104, 22)
        Me.dtTuNgay.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 38)
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
        Me.LabelControl2.Location = New System.Drawing.Point(24, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Đến ngày"
        '
        'dtDenNgay
        '
        Me.dtDenNgay.EditValue = New Date(2015, 10, 26, 14, 23, 50, 820)
        Me.dtDenNgay.Location = New System.Drawing.Point(102, 63)
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
        Me.dtDenNgay.Size = New System.Drawing.Size(104, 22)
        Me.dtDenNgay.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(546, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nhóm SP"
        '
        'cmbNhomsp
        '
        Me.cmbNhomsp.AllowDrop = True
        Me.cmbNhomsp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbNhomsp.Location = New System.Drawing.Point(612, 36)
        Me.cmbNhomsp.Name = "cmbNhomsp"
        Me.cmbNhomsp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbNhomsp.Properties.Appearance.Options.UseFont = True
        Me.cmbNhomsp.Properties.AutoHeight = False
        Me.cmbNhomsp.Properties.AutoSearchColumnIndex = 1
        Me.cmbNhomsp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNhomsp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbNhomsp.Properties.NullText = ""
        Me.cmbNhomsp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNhomsp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNhomsp.Size = New System.Drawing.Size(270, 22)
        Me.cmbNhomsp.TabIndex = 22
        Me.cmbNhomsp.Tag = "MABN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(220, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Loại"
        '
        'cmbnhom
        '
        Me.cmbnhom.AllowDrop = True
        Me.cmbnhom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbnhom.Location = New System.Drawing.Point(294, 36)
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
        Me.cmbnhom.Size = New System.Drawing.Size(229, 22)
        Me.cmbnhom.TabIndex = 18
        Me.cmbnhom.Tag = "MABN"
        '
        'cmbTenThuoc
        '
        Me.cmbTenThuoc.AllowDrop = True
        Me.cmbTenThuoc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbTenThuoc.Location = New System.Drawing.Point(294, 63)
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
        Me.cmbTenThuoc.Size = New System.Drawing.Size(229, 22)
        Me.cmbTenThuoc.TabIndex = 16
        Me.cmbTenThuoc.Tag = "MABN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(220, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Tên thuốc"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(806, 67)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "&Thoát"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(612, 67)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "&Xem"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.btnPrint)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.cmbnhom)
        Me.GroupControl1.Controls.Add(Me.cmbNhomsp)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.dtDenNgay)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.dtTuNgay)
        Me.GroupControl1.Controls.Add(Me.cmbkho)
        Me.GroupControl1.Controls.Add(Me.cmbTenThuoc)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(948, 105)
        Me.GroupControl1.TabIndex = 10
        Me.GroupControl1.Text = "Thông tin tìm kiếm"
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Appearance.Options.UseForeColor = True
        Me.btnPrint.Location = New System.Drawing.Point(709, 67)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 24
        Me.btnPrint.Text = "&In TK"
        '
        'cmbkho
        '
        Me.cmbkho.AllowDrop = True
        Me.cmbkho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbkho.Location = New System.Drawing.Point(328, 122)
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
        Me.cmbkho.Size = New System.Drawing.Size(229, 22)
        Me.cmbkho.TabIndex = 16
        Me.cmbkho.Tag = "MABN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(250, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Kho"
        '
        'grdDanhSach
        '
        Me.grdDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach.Location = New System.Drawing.Point(0, 106)
        Me.grdDanhSach.MainView = Me.GridView1
        Me.grdDanhSach.Name = "grdDanhSach"
        Me.grdDanhSach.Size = New System.Drawing.Size(948, 407)
        Me.grdDanhSach.TabIndex = 12
        Me.grdDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaSP, Me.colTenSP, Me.colTonDau, Me.colNhap, Me.colXuat, Me.colTonCuoi, Me.colGiaNhap, Me.colTienTon, Me.colDonVT, Me.colSTT})
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
        Me.colTenSP.Caption = "Tên thuốc"
        Me.colTenSP.FieldName = "TenThuoc"
        Me.colTenSP.Name = "colTenSP"
        Me.colTenSP.Visible = True
        Me.colTenSP.VisibleIndex = 2
        Me.colTenSP.Width = 198
        '
        'colTonDau
        '
        Me.colTonDau.Caption = "Tồn đầu"
        Me.colTonDau.FieldName = "tondau"
        Me.colTonDau.Name = "colTonDau"
        Me.colTonDau.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tondau", "{0:0.##}")})
        Me.colTonDau.Visible = True
        Me.colTonDau.VisibleIndex = 4
        Me.colTonDau.Width = 91
        '
        'colNhap
        '
        Me.colNhap.Caption = "Nhập"
        Me.colNhap.FieldName = "TongNhap"
        Me.colNhap.Name = "colNhap"
        Me.colNhap.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongNhap", "{0:0.##}")})
        Me.colNhap.Visible = True
        Me.colNhap.VisibleIndex = 5
        Me.colNhap.Width = 98
        '
        'colXuat
        '
        Me.colXuat.Caption = "Xuất"
        Me.colXuat.FieldName = "TongXuat"
        Me.colXuat.Name = "colXuat"
        Me.colXuat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongXuat", "{0:0.##}")})
        Me.colXuat.Visible = True
        Me.colXuat.VisibleIndex = 6
        Me.colXuat.Width = 95
        '
        'colTonCuoi
        '
        Me.colTonCuoi.Caption = "Tồn cuối"
        Me.colTonCuoi.FieldName = "TongTon"
        Me.colTonCuoi.Name = "colTonCuoi"
        Me.colTonCuoi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTon", "{0:0.##}")})
        Me.colTonCuoi.Visible = True
        Me.colTonCuoi.VisibleIndex = 7
        Me.colTonCuoi.Width = 82
        '
        'colGiaNhap
        '
        Me.colGiaNhap.Caption = "Giá nhập"
        Me.colGiaNhap.FieldName = "DonGia"
        Me.colGiaNhap.Name = "colGiaNhap"
        Me.colGiaNhap.Visible = True
        Me.colGiaNhap.VisibleIndex = 8
        Me.colGiaNhap.Width = 87
        '
        'colTienTon
        '
        Me.colTienTon.Caption = "Tiền tồn"
        Me.colTienTon.FieldName = "TongTienTon"
        Me.colTienTon.Name = "colTienTon"
        Me.colTienTon.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienTon", "{0:0.##}")})
        Me.colTienTon.Visible = True
        Me.colTienTon.VisibleIndex = 9
        Me.colTienTon.Width = 105
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
        Me.colSTT.Width = 49
        '
        'frmTKTonKhoKhoaDuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 513)
        Me.Controls.Add(Me.grdDanhSach)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTKTonKhoKhoaDuoc"
        Me.Text = "THỐNG KÊ TỒN KHO THUỐC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtTuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhomsp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbnhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTenThuoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbkho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtTuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbTenThuoc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbnhom As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbNhomsp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbkho As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents grdDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMaSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTenSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonDau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colXuat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonCuoi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTienTon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDonVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSTT As DevExpress.XtraGrid.Columns.GridColumn
End Class
