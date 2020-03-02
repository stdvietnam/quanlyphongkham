<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaocaochitietxuatnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaocaochitietxuatnhap))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbKieu = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSanpham = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnthoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSophieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNgay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaSp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTenSp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDonVT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoluong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaXuat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTienNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTienXuat = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbKieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSanpham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.btnIn)
        Me.GroupControl1.Controls.Add(Me.cmbKieu)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.cmbSanpham)
        Me.GroupControl1.Controls.Add(Me.btnthoat)
        Me.GroupControl1.Controls.Add(Me.btnXem)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.dtpTu_ngay)
        Me.GroupControl1.Controls.Add(Me.dtpDen_ngay)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(994, 100)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Điều kiện hiện thị"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(787, 35)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 45
        Me.btnIn.Text = "&In TK"
        '
        'cmbKieu
        '
        Me.cmbKieu.Location = New System.Drawing.Point(328, 32)
        Me.cmbKieu.Name = "cmbKieu"
        Me.cmbKieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbKieu.Properties.Appearance.Options.UseFont = True
        Me.cmbKieu.Properties.AutoHeight = False
        Me.cmbKieu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKieu.Properties.Items.AddRange(New Object() {"Xuất", "Nhập"})
        Me.cmbKieu.Size = New System.Drawing.Size(135, 22)
        Me.cmbKieu.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(252, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Loại Xn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(252, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Sản phẩm"
        '
        'cmbSanpham
        '
        Me.cmbSanpham.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbSanpham.Location = New System.Drawing.Point(328, 59)
        Me.cmbSanpham.Name = "cmbSanpham"
        Me.cmbSanpham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbSanpham.Properties.Appearance.Options.UseFont = True
        Me.cmbSanpham.Properties.AutoHeight = False
        Me.cmbSanpham.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSanpham.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbSanpham.Properties.NullText = ""
        Me.cmbSanpham.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSanpham.Size = New System.Drawing.Size(294, 22)
        Me.cmbSanpham.TabIndex = 41
        Me.cmbSanpham.Tag = "BVCHUYENDEN"
        '
        'btnthoat
        '
        Me.btnthoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnthoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnthoat.Appearance.Options.UseFont = True
        Me.btnthoat.Appearance.Options.UseForeColor = True
        Me.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnthoat.Location = New System.Drawing.Point(877, 35)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 25)
        Me.btnthoat.TabIndex = 20
        Me.btnthoat.Text = "&Thoát"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(697, 35)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 19
        Me.btnXem.Text = "&Xem"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Đến ngày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Từ ngày"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(100, 32)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTu_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpTu_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpTu_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpTu_ngay.Properties.AutoHeight = False
        Me.dtpTu_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpTu_ngay.Size = New System.Drawing.Size(119, 22)
        Me.dtpTu_ngay.TabIndex = 15
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(100, 59)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDen_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpDen_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpDen_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpDen_ngay.Properties.AutoHeight = False
        Me.dtpDen_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDen_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpDen_ngay.Size = New System.Drawing.Size(119, 22)
        Me.dtpDen_ngay.TabIndex = 17
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(0, 101)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(994, 401)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSophieu, Me.colNgay, Me.colMaSp, Me.colTenSp, Me.colDonVT, Me.colSoluong, Me.colGiaNhap, Me.colGiaXuat, Me.colTienNhap, Me.colTienXuat})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Soluong", Me.colSoluong, "(SL: {0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienNhap", Me.colTienNhap, "(Tiền nhập: {0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienXuat", Me.colTienXuat, "(Tiền xuất: {0:0.##})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colSophieu
        '
        Me.colSophieu.Caption = "Số phiếu"
        Me.colSophieu.FieldName = "Sophieu"
        Me.colSophieu.Name = "colSophieu"
        Me.colSophieu.OptionsColumn.FixedWidth = True
        Me.colSophieu.Visible = True
        Me.colSophieu.VisibleIndex = 8
        Me.colSophieu.Width = 99
        '
        'colNgay
        '
        Me.colNgay.Caption = "Ngày"
        Me.colNgay.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay.FieldName = "Ngay"
        Me.colNgay.Name = "colNgay"
        Me.colNgay.OptionsColumn.FixedWidth = True
        Me.colNgay.Visible = True
        Me.colNgay.VisibleIndex = 9
        Me.colNgay.Width = 134
        '
        'colMaSp
        '
        Me.colMaSp.Caption = "Mã SP"
        Me.colMaSp.FieldName = "MaSp"
        Me.colMaSp.Name = "colMaSp"
        Me.colMaSp.OptionsColumn.FixedWidth = True
        Me.colMaSp.Visible = True
        Me.colMaSp.VisibleIndex = 0
        Me.colMaSp.Width = 53
        '
        'colTenSp
        '
        Me.colTenSp.Caption = "Tên SP"
        Me.colTenSp.FieldName = "TenSp"
        Me.colTenSp.Name = "colTenSp"
        Me.colTenSp.Visible = True
        Me.colTenSp.VisibleIndex = 1
        Me.colTenSp.Width = 217
        '
        'colDonVT
        '
        Me.colDonVT.Caption = "Đơn VT"
        Me.colDonVT.FieldName = "DonVT"
        Me.colDonVT.Name = "colDonVT"
        Me.colDonVT.OptionsColumn.FixedWidth = True
        Me.colDonVT.Visible = True
        Me.colDonVT.VisibleIndex = 3
        Me.colDonVT.Width = 46
        '
        'colSoluong
        '
        Me.colSoluong.Caption = "SL"
        Me.colSoluong.FieldName = "Soluong"
        Me.colSoluong.Name = "colSoluong"
        Me.colSoluong.OptionsColumn.FixedWidth = True
        Me.colSoluong.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Soluong", "{0:0.##}")})
        Me.colSoluong.Visible = True
        Me.colSoluong.VisibleIndex = 2
        Me.colSoluong.Width = 55
        '
        'colGiaNhap
        '
        Me.colGiaNhap.Caption = "Giá nhập"
        Me.colGiaNhap.FieldName = "GiaNhap"
        Me.colGiaNhap.Name = "colGiaNhap"
        Me.colGiaNhap.OptionsColumn.FixedWidth = True
        Me.colGiaNhap.Visible = True
        Me.colGiaNhap.VisibleIndex = 4
        Me.colGiaNhap.Width = 83
        '
        'colGiaXuat
        '
        Me.colGiaXuat.Caption = "Giá xuất"
        Me.colGiaXuat.FieldName = "GiaXuat"
        Me.colGiaXuat.Name = "colGiaXuat"
        Me.colGiaXuat.OptionsColumn.FixedWidth = True
        Me.colGiaXuat.Visible = True
        Me.colGiaXuat.VisibleIndex = 5
        Me.colGiaXuat.Width = 81
        '
        'colTienNhap
        '
        Me.colTienNhap.Caption = "Tiền nhập"
        Me.colTienNhap.FieldName = "TienNhap"
        Me.colTienNhap.Name = "colTienNhap"
        Me.colTienNhap.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienNhap", "{0:0.##}")})
        Me.colTienNhap.Visible = True
        Me.colTienNhap.VisibleIndex = 6
        Me.colTienNhap.Width = 103
        '
        'colTienXuat
        '
        Me.colTienXuat.Caption = "Tiền xuất"
        Me.colTienXuat.FieldName = "TienXuat"
        Me.colTienXuat.Name = "colTienXuat"
        Me.colTienXuat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienXuat", "{0:0.##}")})
        Me.colTienXuat.Visible = True
        Me.colTienXuat.VisibleIndex = 7
        Me.colTienXuat.Width = 104
        '
        'frmBaocaochitietxuatnhap
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 503)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBaocaochitietxuatnhap"
        Me.Text = "BÁO CÁO CHI TIẾT XUẤT NHẬP"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbKieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSanpham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSanpham As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnthoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbKieu As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSophieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaSp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTenSp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDonVT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoluong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaXuat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTienNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTienXuat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
End Class
