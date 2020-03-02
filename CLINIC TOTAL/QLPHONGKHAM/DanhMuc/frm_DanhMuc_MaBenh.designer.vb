<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DanhMuc_MaBenh
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DanhMuc_MaBenh))
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ctenphong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.txtTenBenh = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaBenh = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdDonThuoc = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colTensp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSoluong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnCapnhat_Donthuoc = New DevExpress.XtraEditors.SimpleButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmbMabenh = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        CType(Me.txtTenBenh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaBenh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDonThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMabenh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(-2, 135)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grv.Size = New System.Drawing.Size(406, 388)
        Me.grv.TabIndex = 4
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cMA, Me.ctenphong})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 25
        '
        'cMA
        '
        Me.cMA.Caption = "Mã bệnh"
        Me.cMA.FieldName = "MABENH"
        Me.cMA.Name = "cMA"
        Me.cMA.OptionsColumn.AllowEdit = False
        Me.cMA.Visible = True
        Me.cMA.VisibleIndex = 0
        Me.cMA.Width = 62
        '
        'ctenphong
        '
        Me.ctenphong.Caption = "Tên bệnh"
        Me.ctenphong.FieldName = "TENBENH"
        Me.ctenphong.Name = "ctenphong"
        Me.ctenphong.OptionsColumn.AllowEdit = False
        Me.ctenphong.Visible = True
        Me.ctenphong.VisibleIndex = 1
        Me.ctenphong.Width = 320
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ReadOnly = True
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grv
        Me.GridView2.Name = "GridView2"
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(319, 92)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(16, 92)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 0
        Me.btnCap_nhat.Text = "Cập nhật "
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(117, 92)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 1
        Me.btnHuy.Text = "Bỏ qua "
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(218, 92)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xoá "
        '
        'Grb
        '
        Me.Grb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grb.Controls.Add(Me.txtTenBenh)
        Me.Grb.Controls.Add(Me.txtMaBenh)
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.txtID)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Grb.ForeColor = System.Drawing.Color.Red
        Me.Grb.Location = New System.Drawing.Point(-2, 0)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(406, 81)
        Me.Grb.TabIndex = 21
        Me.Grb.TabStop = False
        Me.Grb.Text = "Thông tin mã bệnh"
        '
        'txtTenBenh
        '
        Me.txtTenBenh.Location = New System.Drawing.Point(82, 47)
        Me.txtTenBenh.Name = "txtTenBenh"
        Me.txtTenBenh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTenBenh.Properties.Appearance.Options.UseFont = True
        Me.txtTenBenh.Properties.AutoHeight = False
        Me.txtTenBenh.Size = New System.Drawing.Size(310, 23)
        Me.txtTenBenh.TabIndex = 5
        '
        'txtMaBenh
        '
        Me.txtMaBenh.Location = New System.Drawing.Point(82, 19)
        Me.txtMaBenh.Name = "txtMaBenh"
        Me.txtMaBenh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMaBenh.Properties.Appearance.Options.UseFont = True
        Me.txtMaBenh.Properties.AutoHeight = False
        Me.txtMaBenh.Size = New System.Drawing.Size(146, 23)
        Me.txtMaBenh.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã bệnh"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(82, 97)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(10, 22)
        Me.txtID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên bệnh"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdDonThuoc)
        Me.GroupBox1.Controls.Add(Me.btnCapnhat_Donthuoc)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.cmbMabenh)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(412, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 524)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đơn thuốc"
        '
        'grdDonThuoc
        '
        Me.grdDonThuoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDonThuoc.Location = New System.Drawing.Point(6, 63)
        Me.grdDonThuoc.MainView = Me.GridView3
        Me.grdDonThuoc.Name = "grdDonThuoc"
        Me.grdDonThuoc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemComboBox1})
        Me.grdDonThuoc.Size = New System.Drawing.Size(557, 455)
        Me.grdDonThuoc.TabIndex = 2
        Me.grdDonThuoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT, Me.colMasp, Me.colTensp, Me.DVT, Me.colSoluong, Me.GridColumn1})
        Me.GridView3.GridControl = Me.grdDonThuoc
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSTT
        '
        Me.colSTT.Caption = "Stt"
        Me.colSTT.FieldName = "stt"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.OptionsColumn.AllowEdit = False
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 0
        Me.colSTT.Width = 35
        '
        'colMasp
        '
        Me.colMasp.Caption = "Mã "
        Me.colMasp.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colMasp.FieldName = "masp"
        Me.colMasp.Name = "colMasp"
        Me.colMasp.Visible = True
        Me.colMasp.VisibleIndex = 1
        Me.colMasp.Width = 45
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.CaseSensitiveSearch = True
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
        Me.colTensp.VisibleIndex = 2
        Me.colTensp.Width = 135
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("masp", "Mã", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tensp", "Tên sản phẩm", 280, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("toncuoi", "Tồn kho", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "tensp"
        Me.RepositoryItemLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.PopupWidth = 435
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "masp"
        '
        'DVT
        '
        Me.DVT.Caption = "ĐVT"
        Me.DVT.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.DVT.FieldName = "masp"
        Me.DVT.Name = "DVT"
        Me.DVT.OptionsColumn.AllowEdit = False
        Me.DVT.Visible = True
        Me.DVT.VisibleIndex = 3
        Me.DVT.Width = 32
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
        Me.colSoluong.Caption = "SL"
        Me.colSoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSoluong.FieldName = "soluong"
        Me.colSoluong.Name = "colSoluong"
        Me.colSoluong.Visible = True
        Me.colSoluong.VisibleIndex = 4
        Me.colSoluong.Width = 36
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Liều dùng"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemComboBox1
        Me.GridColumn1.FieldName = "lieudung"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 161
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'btnCapnhat_Donthuoc
        '
        Me.btnCapnhat_Donthuoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCapnhat_Donthuoc.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCapnhat_Donthuoc.Appearance.Options.UseFont = True
        Me.btnCapnhat_Donthuoc.Appearance.Options.UseForeColor = True
        Me.btnCapnhat_Donthuoc.Location = New System.Drawing.Point(467, 23)
        Me.btnCapnhat_Donthuoc.Name = "btnCapnhat_Donthuoc"
        Me.btnCapnhat_Donthuoc.Size = New System.Drawing.Size(75, 25)
        Me.btnCapnhat_Donthuoc.TabIndex = 1
        Me.btnCapnhat_Donthuoc.Text = "Cập nhật "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(9, 27)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(91, 16)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "Chọn mã bệnh"
        '
        'cmbMabenh
        '
        Me.cmbMabenh.Location = New System.Drawing.Point(113, 24)
        Me.cmbMabenh.Name = "cmbMabenh"
        Me.cmbMabenh.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbMabenh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbMabenh.Properties.Appearance.Options.UseBackColor = True
        Me.cmbMabenh.Properties.Appearance.Options.UseFont = True
        Me.cmbMabenh.Properties.AutoHeight = False
        Me.cmbMabenh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMabenh.Properties.NullText = ""
        Me.cmbMabenh.Size = New System.Drawing.Size(311, 23)
        Me.cmbMabenh.TabIndex = 0
        Me.cmbMabenh.Tag = ""
        '
        'frm_DanhMuc_MaBenh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 524)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grb)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnCap_nhat)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.grv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(997, 563)
        Me.MinimumSize = New System.Drawing.Size(997, 563)
        Me.Name = "frm_DanhMuc_MaBenh"
        Me.Text = "DANH MỤC ĐƠN THUỐC THEO MÃ BỆNH"
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.txtTenBenh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaBenh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdDonThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMabenh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ctenphong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grb As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnCapnhat_Donthuoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdDonThuoc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colTensp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSoluong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbMabenh As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTenBenh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaBenh As DevExpress.XtraEditors.TextEdit
End Class
