<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeThuoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKeThuoc))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSach = New System.Windows.Forms.DataGridView()
        Me.btnXuat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnthoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtNgay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbKhoa = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKhoa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvDanhSach)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(949, 447)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgvDanhSach
        '
        Me.dgvDanhSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSach.Location = New System.Drawing.Point(3, 16)
        Me.dgvDanhSach.Name = "dgvDanhSach"
        Me.dgvDanhSach.Size = New System.Drawing.Size(943, 428)
        Me.dgvDanhSach.TabIndex = 1
        '
        'btnXuat
        '
        Me.btnXuat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXuat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXuat.Appearance.Options.UseFont = True
        Me.btnXuat.Appearance.Options.UseForeColor = True
        Me.btnXuat.Location = New System.Drawing.Point(751, 34)
        Me.btnXuat.Name = "btnXuat"
        Me.btnXuat.Size = New System.Drawing.Size(75, 25)
        Me.btnXuat.TabIndex = 0
        Me.btnXuat.Text = "Xuất Excel"
        '
        'btnthoat
        '
        Me.btnthoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnthoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnthoat.Appearance.Options.UseFont = True
        Me.btnthoat.Appearance.Options.UseForeColor = True
        Me.btnthoat.Location = New System.Drawing.Point(852, 34)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 25)
        Me.btnthoat.TabIndex = 27
        Me.btnthoat.Text = "Thoát"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(650, 34)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 26
        Me.btnXem.Text = "Xem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(344, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Chọn ngày:"
        '
        'dtNgay
        '
        Me.dtNgay.EditValue = New Date(2014, 12, 29, 0, 0, 0, 0)
        Me.dtNgay.Location = New System.Drawing.Point(430, 36)
        Me.dtNgay.Name = "dtNgay"
        Me.dtNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtNgay.Properties.NullDate = New Date(2014, 12, 29, 15, 46, 17, 351)
        Me.dtNgay.Size = New System.Drawing.Size(194, 20)
        Me.dtNgay.TabIndex = 24
        '
        'cmbKhoa
        '
        Me.cmbKhoa.AllowDrop = True
        Me.cmbKhoa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbKhoa.Location = New System.Drawing.Point(96, 36)
        Me.cmbKhoa.Name = "cmbKhoa"
        Me.cmbKhoa.Properties.AutoHeight = False
        Me.cmbKhoa.Properties.AutoSearchColumnIndex = 1
        Me.cmbKhoa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKhoa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbKhoa.Properties.NullText = ""
        Me.cmbKhoa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbKhoa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbKhoa.Size = New System.Drawing.Size(227, 21)
        Me.cmbKhoa.TabIndex = 23
        Me.cmbKhoa.Tag = "MABN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Chọn khoa:"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnthoat)
        Me.GroupControl1.Controls.Add(Me.cmbKhoa)
        Me.GroupControl1.Controls.Add(Me.btnXem)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.dtNgay)
        Me.GroupControl1.Controls.Add(Me.btnXuat)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(949, 85)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Điều kiện tìm kiếm"
        '
        'frmThongKeThuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 528)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThongKeThuoc"
        Me.Text = "Bảng kê khai thuốc hàng ngày"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKhoa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents btnXuat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbKhoa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnthoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
