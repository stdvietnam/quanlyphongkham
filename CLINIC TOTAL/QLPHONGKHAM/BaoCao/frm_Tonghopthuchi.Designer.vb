<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Tonghopthuchi
    Inherits frm_base

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Tonghopthuchi))
        Me.grbkb = New DevExpress.XtraEditors.GroupControl()
        Me.btnInTk = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbDoituong = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbThucHien = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbNguoiLap = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbMaBn = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbVattu = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbBN = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDenngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtTungay = New DevExpress.XtraEditors.DateEdit()
        Me.gridDanhSach = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSanpham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGianhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTongtiennhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaban = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTongtienban = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBacsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNguoilap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSohoso = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grbkb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbkb.SuspendLayout()
        CType(Me.cmbDoituong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbThucHien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNguoiLap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMaBn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVattu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDenngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDenngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTungay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbkb
        '
        Me.grbkb.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grbkb.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.grbkb.AppearanceCaption.Options.UseFont = True
        Me.grbkb.AppearanceCaption.Options.UseForeColor = True
        Me.grbkb.Controls.Add(Me.btnInTk)
        Me.grbkb.Controls.Add(Me.cmbDoituong)
        Me.grbkb.Controls.Add(Me.LabelControl4)
        Me.grbkb.Controls.Add(Me.cmbThucHien)
        Me.grbkb.Controls.Add(Me.cmbNguoiLap)
        Me.grbkb.Controls.Add(Me.cmbMaBn)
        Me.grbkb.Controls.Add(Me.cmbVattu)
        Me.grbkb.Controls.Add(Me.btnThoat)
        Me.grbkb.Controls.Add(Me.LabelControl6)
        Me.grbkb.Controls.Add(Me.btnXem)
        Me.grbkb.Controls.Add(Me.LabelControl5)
        Me.grbkb.Controls.Add(Me.LabelControl2)
        Me.grbkb.Controls.Add(Me.cmbBN)
        Me.grbkb.Controls.Add(Me.LabelControl3)
        Me.grbkb.Controls.Add(Me.LabelControl1)
        Me.grbkb.Controls.Add(Me.dtDenngay)
        Me.grbkb.Controls.Add(Me.dtTungay)
        Me.grbkb.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbkb.Location = New System.Drawing.Point(0, 0)
        Me.grbkb.Name = "grbkb"
        Me.grbkb.Size = New System.Drawing.Size(1065, 122)
        Me.grbkb.TabIndex = 2
        Me.grbkb.Text = "Thông tìm kiếm"
        '
        'btnInTk
        '
        Me.btnInTk.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnInTk.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInTk.Appearance.Options.UseFont = True
        Me.btnInTk.Appearance.Options.UseForeColor = True
        Me.btnInTk.Location = New System.Drawing.Point(879, 36)
        Me.btnInTk.Name = "btnInTk"
        Me.btnInTk.Size = New System.Drawing.Size(75, 25)
        Me.btnInTk.TabIndex = 58
        Me.btnInTk.Text = "&In TK"
        '
        'cmbDoituong
        '
        Me.cmbDoituong.Location = New System.Drawing.Point(731, 149)
        Me.cmbDoituong.Name = "cmbDoituong"
        Me.cmbDoituong.Properties.AutoHeight = False
        Me.cmbDoituong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDoituong.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None)
        Me.cmbDoituong.Properties.NullText = ""
        Me.cmbDoituong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDoituong.Size = New System.Drawing.Size(148, 23)
        Me.cmbDoituong.TabIndex = 57
        Me.cmbDoituong.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(662, 154)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl4.TabIndex = 56
        Me.LabelControl4.Text = "Đối tượng"
        Me.LabelControl4.Visible = False
        '
        'cmbThucHien
        '
        Me.cmbThucHien.Location = New System.Drawing.Point(548, 57)
        Me.cmbThucHien.Name = "cmbThucHien"
        Me.cmbThucHien.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbThucHien.Properties.Appearance.Options.UseFont = True
        Me.cmbThucHien.Properties.AutoHeight = False
        Me.cmbThucHien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbThucHien.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None)
        Me.cmbThucHien.Properties.NullText = ""
        Me.cmbThucHien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbThucHien.Size = New System.Drawing.Size(194, 23)
        Me.cmbThucHien.TabIndex = 55
        '
        'cmbNguoiLap
        '
        Me.cmbNguoiLap.Location = New System.Drawing.Point(548, 31)
        Me.cmbNguoiLap.Name = "cmbNguoiLap"
        Me.cmbNguoiLap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbNguoiLap.Properties.Appearance.Options.UseFont = True
        Me.cmbNguoiLap.Properties.AutoHeight = False
        Me.cmbNguoiLap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNguoiLap.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None)
        Me.cmbNguoiLap.Properties.NullText = ""
        Me.cmbNguoiLap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNguoiLap.Size = New System.Drawing.Size(194, 23)
        Me.cmbNguoiLap.TabIndex = 55
        '
        'cmbMaBn
        '
        Me.cmbMaBn.Location = New System.Drawing.Point(104, 57)
        Me.cmbMaBn.Name = "cmbMaBn"
        Me.cmbMaBn.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbMaBn.Properties.Appearance.Options.UseFont = True
        Me.cmbMaBn.Properties.AutoHeight = False
        Me.cmbMaBn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMaBn.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None)
        Me.cmbMaBn.Properties.NullText = ""
        Me.cmbMaBn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbMaBn.Size = New System.Drawing.Size(327, 23)
        Me.cmbMaBn.TabIndex = 55
        '
        'cmbVattu
        '
        Me.cmbVattu.Location = New System.Drawing.Point(104, 83)
        Me.cmbVattu.Name = "cmbVattu"
        Me.cmbVattu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbVattu.Properties.Appearance.Options.UseFont = True
        Me.cmbVattu.Properties.AutoHeight = False
        Me.cmbVattu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbVattu.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None)
        Me.cmbVattu.Properties.NullText = ""
        Me.cmbVattu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbVattu.Size = New System.Drawing.Size(327, 23)
        Me.cmbVattu.TabIndex = 47
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(970, 36)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "&Thoát"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(467, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "Thực hiện"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(788, 36)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 4
        Me.btnXem.Text = "&Xem"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(467, 34)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "Người lập"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(240, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Đến ngày"
        '
        'cmbBN
        '
        Me.cmbBN.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBN.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbBN.Appearance.Options.UseFont = True
        Me.cmbBN.Appearance.Options.UseForeColor = True
        Me.cmbBN.Location = New System.Drawing.Point(28, 59)
        Me.cmbBN.Name = "cmbBN"
        Me.cmbBN.Size = New System.Drawing.Size(41, 16)
        Me.cmbBN.TabIndex = 2
        Me.cmbBN.Text = "Tên BN"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(28, 85)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Sản phẩm"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Từ ngày"
        '
        'dtDenngay
        '
        Me.dtDenngay.EditValue = Nothing
        Me.dtDenngay.Location = New System.Drawing.Point(306, 31)
        Me.dtDenngay.Name = "dtDenngay"
        Me.dtDenngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtDenngay.Properties.Appearance.Options.UseFont = True
        Me.dtDenngay.Properties.AutoHeight = False
        Me.dtDenngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDenngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDenngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtDenngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDenngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtDenngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDenngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtDenngay.Size = New System.Drawing.Size(125, 23)
        Me.dtDenngay.TabIndex = 1
        '
        'dtTungay
        '
        Me.dtTungay.EditValue = Nothing
        Me.dtTungay.Location = New System.Drawing.Point(104, 31)
        Me.dtTungay.Name = "dtTungay"
        Me.dtTungay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtTungay.Properties.Appearance.Options.UseFont = True
        Me.dtTungay.Properties.AutoHeight = False
        Me.dtTungay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTungay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtTungay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtTungay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTungay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtTungay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTungay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtTungay.Size = New System.Drawing.Size(125, 23)
        Me.dtTungay.TabIndex = 0
        '
        'gridDanhSach
        '
        Me.gridDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDanhSach.Location = New System.Drawing.Point(0, 124)
        Me.gridDanhSach.MainView = Me.GridView1
        Me.gridDanhSach.Name = "gridDanhSach"
        Me.gridDanhSach.Size = New System.Drawing.Size(1065, 435)
        Me.gridDanhSach.TabIndex = 5
        Me.gridDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT, Me.colKH, Me.colSanpham, Me.colSL, Me.colGianhap, Me.colTongtiennhap, Me.colGiaban, Me.colTongtienban, Me.colBacsi, Me.colNguoilap, Me.colSohoso})
        Me.GridView1.GridControl = Me.gridDanhSach
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKH, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSTT
        '
        Me.colSTT.Caption = "STT"
        Me.colSTT.FieldName = "STT"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 0
        Me.colSTT.Width = 41
        '
        'colKH
        '
        Me.colKH.Caption = "KH"
        Me.colKH.FieldName = "ThongTin"
        Me.colKH.Name = "colKH"
        Me.colKH.Visible = True
        Me.colKH.VisibleIndex = 1
        '
        'colSanpham
        '
        Me.colSanpham.Caption = "Sản phẩm/Dịch vụ"
        Me.colSanpham.FieldName = "TenSp"
        Me.colSanpham.Name = "colSanpham"
        Me.colSanpham.Visible = True
        Me.colSanpham.VisibleIndex = 1
        Me.colSanpham.Width = 206
        '
        'colSL
        '
        Me.colSL.Caption = "Số lượng"
        Me.colSL.FieldName = "Soluong"
        Me.colSL.Name = "colSL"
        Me.colSL.Visible = True
        Me.colSL.VisibleIndex = 2
        Me.colSL.Width = 54
        '
        'colGianhap
        '
        Me.colGianhap.Caption = "Giá nhập"
        Me.colGianhap.FieldName = "Gianhap"
        Me.colGianhap.Name = "colGianhap"
        Me.colGianhap.Visible = True
        Me.colGianhap.VisibleIndex = 3
        Me.colGianhap.Width = 96
        '
        'colTongtiennhap
        '
        Me.colTongtiennhap.Caption = "Tổng tiền nhập"
        Me.colTongtiennhap.FieldName = "TTNhap"
        Me.colTongtiennhap.Name = "colTongtiennhap"
        Me.colTongtiennhap.Visible = True
        Me.colTongtiennhap.VisibleIndex = 4
        Me.colTongtiennhap.Width = 103
        '
        'colGiaban
        '
        Me.colGiaban.Caption = "Giá bán"
        Me.colGiaban.FieldName = "Dongia"
        Me.colGiaban.Name = "colGiaban"
        Me.colGiaban.Visible = True
        Me.colGiaban.VisibleIndex = 5
        Me.colGiaban.Width = 85
        '
        'colTongtienban
        '
        Me.colTongtienban.Caption = "Tổng tiền bán"
        Me.colTongtienban.FieldName = "TTXuat"
        Me.colTongtienban.Name = "colTongtienban"
        Me.colTongtienban.Visible = True
        Me.colTongtienban.VisibleIndex = 6
        Me.colTongtienban.Width = 109
        '
        'colBacsi
        '
        Me.colBacsi.Caption = "Bác sĩ/ KTV thực hiện"
        Me.colBacsi.FieldName = "Bacsi"
        Me.colBacsi.Name = "colBacsi"
        Me.colBacsi.Visible = True
        Me.colBacsi.VisibleIndex = 7
        Me.colBacsi.Width = 126
        '
        'colNguoilap
        '
        Me.colNguoilap.Caption = "Người lập phiếu"
        Me.colNguoilap.FieldName = "Nguoilap"
        Me.colNguoilap.Name = "colNguoilap"
        Me.colNguoilap.Visible = True
        Me.colNguoilap.VisibleIndex = 8
        Me.colNguoilap.Width = 132
        '
        'colSohoso
        '
        Me.colSohoso.Caption = "Số hồ sơ"
        Me.colSohoso.FieldName = "SoPhieuKham"
        Me.colSohoso.Name = "colSohoso"
        Me.colSohoso.OptionsColumn.FixedWidth = True
        Me.colSohoso.Visible = True
        Me.colSohoso.VisibleIndex = 9
        Me.colSohoso.Width = 95
        '
        'frm_Tonghopthuchi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 560)
        Me.Controls.Add(Me.gridDanhSach)
        Me.Controls.Add(Me.grbkb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Tonghopthuchi"
        Me.Text = "TỔNG HỢP THU CHI THEO BỆNH NHÂN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grbkb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbkb.ResumeLayout(False)
        Me.grbkb.PerformLayout()
        CType(Me.cmbDoituong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbThucHien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNguoiLap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMaBn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVattu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDenngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDenngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTungay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbkb As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDenngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtTungay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbBN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbMaBn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbVattu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDoituong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNguoiLap As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbThucHien As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSanpham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGianhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTongtiennhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaban As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTongtienban As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBacsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNguoilap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSohoso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnInTk As DevExpress.XtraEditors.SimpleButton
End Class
