<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_baocaothanhtoan
    Inherits frmBase 'System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_baocaothanhtoan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDoituong = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.btnthoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.grdDanhSach = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMaBN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cmbDoituong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Đối tượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(247, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Đến ngày:"
        '
        'cmbDoituong
        '
        Me.cmbDoituong.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbDoituong.Location = New System.Drawing.Point(111, 134)
        Me.cmbDoituong.Name = "cmbDoituong"
        Me.cmbDoituong.Properties.AutoHeight = False
        Me.cmbDoituong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDoituong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbDoituong.Properties.NullText = ""
        Me.cmbDoituong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDoituong.Size = New System.Drawing.Size(154, 22)
        Me.cmbDoituong.TabIndex = 39
        Me.cmbDoituong.Tag = "BVCHUYENDEN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Từ ngày:"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(90, 36)
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
        Me.dtpTu_ngay.Size = New System.Drawing.Size(112, 22)
        Me.dtpTu_ngay.TabIndex = 11
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(329, 36)
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
        Me.dtpDen_ngay.Size = New System.Drawing.Size(112, 22)
        Me.dtpDen_ngay.TabIndex = 13
        '
        'btnthoat
        '
        Me.btnthoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnthoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnthoat.Appearance.Options.UseFont = True
        Me.btnthoat.Appearance.Options.UseForeColor = True
        Me.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnthoat.Location = New System.Drawing.Point(766, 34)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 25)
        Me.btnthoat.TabIndex = 10
        Me.btnthoat.Text = "&Thoát"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(570, 34)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 8
        Me.btnXem.Text = "&Xem"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.btnPrint)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.btnthoat)
        Me.GroupControl1.Controls.Add(Me.cmbDoituong)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.btnXem)
        Me.GroupControl1.Controls.Add(Me.dtpDen_ngay)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.dtpTu_ngay)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1173, 75)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Điều kiện tìm kiếm"
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Appearance.Options.UseForeColor = True
        Me.btnPrint.Location = New System.Drawing.Point(668, 34)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 40
        Me.btnPrint.Text = "&In TK"
        '
        'grdDanhSach
        '
        Me.grdDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach.Location = New System.Drawing.Point(0, 77)
        Me.grdDanhSach.MainView = Me.GridView1
        Me.grdDanhSach.Name = "grdDanhSach"
        Me.grdDanhSach.Size = New System.Drawing.Size(1173, 442)
        Me.grdDanhSach.TabIndex = 3
        Me.grdDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaBN, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn1, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.GridView1.GridControl = Me.grdDanhSach
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colMaBN
        '
        Me.colMaBN.Caption = "Mã BN"
        Me.colMaBN.FieldName = "MaBN"
        Me.colMaBN.Name = "colMaBN"
        Me.colMaBN.OptionsColumn.FixedWidth = True
        Me.colMaBN.Visible = True
        Me.colMaBN.VisibleIndex = 2
        Me.colMaBN.Width = 98
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Họ và tên"
        Me.GridColumn2.FieldName = "hoten"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ngày sinh"
        Me.GridColumn3.FieldName = "NGAYSINH"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Giới tính"
        Me.GridColumn4.FieldName = "gioitinh"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 58
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Số hồ sơ"
        Me.GridColumn5.FieldName = "sophieu"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 51
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ngày lập"
        Me.GridColumn6.FieldName = "DateLap"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 77
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tiền thuốc"
        Me.GridColumn7.FieldName = "tienthuoc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tienthuoc", "{0:0.##}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        Me.GridColumn7.Width = 80
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tiền khám"
        Me.GridColumn1.FieldName = "tienkham"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tienkham", "{0:0.##}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        Me.GridColumn1.Width = 80
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tiền XN"
        Me.GridColumn8.FieldName = "tienxn"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tienxn", "{0:0.##}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 10
        Me.GridColumn8.Width = 80
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tiền CĐHA"
        Me.GridColumn9.FieldName = "tiencdha"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.FixedWidth = True
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tiencdha", "{0:0.##}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 11
        Me.GridColumn9.Width = 80
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tiền TTPT"
        Me.GridColumn10.FieldName = "tienttpt"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.FixedWidth = True
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tienttpt", "{0:0.##}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 12
        Me.GridColumn10.Width = 80
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Tông tiền"
        Me.GridColumn11.FieldName = "tongtien"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.FixedWidth = True
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tongtien", "{0:0.##}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 13
        Me.GridColumn11.Width = 80
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Địa chỉ"
        Me.GridColumn12.FieldName = "DiaChiChiTiet"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 6
        Me.GridColumn12.Width = 95
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Điện thoại"
        Me.GridColumn13.FieldName = "DienThoai"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        Me.GridColumn13.Width = 100
        '
        'frm_baocaothanhtoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1173, 519)
        Me.Controls.Add(Me.grdDanhSach)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_baocaothanhtoan"
        Me.Text = "BÁO CÁO DOANH THU TỔNG HỢP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cmbDoituong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnthoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDoituong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMaBN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
End Class
