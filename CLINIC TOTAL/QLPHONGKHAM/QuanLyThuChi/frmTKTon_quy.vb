Public Class frmTKTon_quy
    Inherits frmBase 'System.Windows.Forms.Form
    Private blnFoundClick As Boolean = True
    Private dtbTon_quy As New DataTable
    Private ToncuoiVND As Double
    Private ToncuoiUSD As Double
    Private DtvTon_quy As DataView
    Private i As Int16
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdDetail As System.Windows.Forms.DataGrid
    Friend WithEvents dtpThoigian As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ColTen_quy As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colThuVND As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colChiVND As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colTonVND As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colThuUSD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ColChiUSD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ColTonUSD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tbnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbQuy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtToncuoiVND As System.Windows.Forms.TextBox
    Friend WithEvents TxTTonCuoiUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_tungay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents coltondauVND As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents coltondauUSD As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTKTon_quy))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbQuy = New DevExpress.XtraEditors.LookUpEdit()
        Me.tbnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpThoigian = New DevExpress.XtraEditors.DateEdit()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dtp_tungay = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdDetail = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.ColTen_quy = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.coltondauVND = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.colThuVND = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.colChiVND = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.colTonVND = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.coltondauUSD = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.colThuUSD = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColChiUSD = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColTonUSD = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtToncuoiVND = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxTTonCuoiUSD = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbQuy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpThoigian.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpThoigian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_tungay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbQuy)
        Me.GroupBox1.Controls.Add(Me.tbnXem)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpThoigian)
        Me.GroupBox1.Controls.Add(Me.btnIn)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.dtp_tungay)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tìm kiếm"
        '
        'cmbQuy
        '
        Me.cmbQuy.AllowDrop = True
        Me.cmbQuy.Location = New System.Drawing.Point(337, 20)
        Me.cmbQuy.Name = "cmbQuy"
        Me.cmbQuy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbQuy.Properties.Appearance.Options.UseFont = True
        Me.cmbQuy.Properties.AutoHeight = False
        Me.cmbQuy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuy.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Maquy", "Mã quỹ", 10, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tenquy", "Tên quỹ", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbQuy.Properties.NullText = ""
        Me.cmbQuy.Properties.PopupWidth = 300
        Me.cmbQuy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbQuy.Size = New System.Drawing.Size(248, 23)
        Me.cmbQuy.TabIndex = 3
        '
        'tbnXem
        '
        Me.tbnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.tbnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbnXem.Appearance.Options.UseFont = True
        Me.tbnXem.Appearance.Options.UseForeColor = True
        Me.tbnXem.Location = New System.Drawing.Point(331, 56)
        Me.tbnXem.Name = "tbnXem"
        Me.tbnXem.Size = New System.Drawing.Size(75, 25)
        Me.tbnXem.TabIndex = 4
        Me.tbnXem.Text = "&Xem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(253, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tồn tại quỹ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Từ ngày"
        '
        'dtpThoigian
        '
        Me.dtpThoigian.EditValue = New Date(2005, 5, 14, 0, 0, 0, 0)
        Me.dtpThoigian.Location = New System.Drawing.Point(92, 49)
        Me.dtpThoigian.Name = "dtpThoigian"
        Me.dtpThoigian.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpThoigian.Properties.Appearance.Options.UseFont = True
        Me.dtpThoigian.Properties.AutoHeight = False
        Me.dtpThoigian.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpThoigian.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpThoigian.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpThoigian.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpThoigian.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpThoigian.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpThoigian.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpThoigian.Size = New System.Drawing.Size(106, 23)
        Me.dtpThoigian.TabIndex = 2
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(423, 56)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 5
        Me.btnIn.Text = "&In"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(515, 56)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Thoát"
        '
        'dtp_tungay
        '
        Me.dtp_tungay.EditValue = New Date(2005, 5, 14, 0, 0, 0, 0)
        Me.dtp_tungay.Location = New System.Drawing.Point(92, 20)
        Me.dtp_tungay.Name = "dtp_tungay"
        Me.dtp_tungay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtp_tungay.Properties.Appearance.Options.UseFont = True
        Me.dtp_tungay.Properties.AutoHeight = False
        Me.dtp_tungay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_tungay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtp_tungay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtp_tungay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_tungay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtp_tungay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_tungay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtp_tungay.Size = New System.Drawing.Size(106, 23)
        Me.dtp_tungay.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Đến ngày"
        '
        'grdDetail
        '
        Me.grdDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grdDetail.CaptionVisible = False
        Me.grdDetail.DataMember = ""
        Me.grdDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDetail.Location = New System.Drawing.Point(0, 99)
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.ReadOnly = True
        Me.grdDetail.Size = New System.Drawing.Size(635, 304)
        Me.grdDetail.TabIndex = 1
        Me.grdDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Lavender
        Me.DataGridTableStyle1.DataGrid = Me.grdDetail
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ColTen_quy, Me.coltondauVND, Me.colThuVND, Me.colChiVND, Me.colTonVND, Me.coltondauUSD, Me.colThuUSD, Me.ColChiUSD, Me.ColTonUSD})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.SpringGreen
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.SkyBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.PreferredRowHeight = 22
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.IndianRed
        '
        'ColTen_quy
        '
        Me.ColTen_quy.Format = ""
        Me.ColTen_quy.FormatInfo = Nothing
        Me.ColTen_quy.HeaderText = "Tên quỹ"
        Me.ColTen_quy.MappingName = "Maquy"
        Me.ColTen_quy.ReadOnly = True
        Me.ColTen_quy.Width = 70
        '
        'coltondauVND
        '
        Me.coltondauVND.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.coltondauVND.Format = "###,###"
        Me.coltondauVND.FormatInfo = Nothing
        Me.coltondauVND.HeaderText = "Tồn đầu  VND"
        Me.coltondauVND.MappingName = "tondauVND"
        Me.coltondauVND.NullText = "0"
        Me.coltondauVND.ReadOnly = True
        Me.coltondauVND.Width = 95
        '
        'colThuVND
        '
        Me.colThuVND.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.colThuVND.Format = "###,###"
        Me.colThuVND.FormatInfo = Nothing
        Me.colThuVND.HeaderText = "Thu VND"
        Me.colThuVND.MappingName = "ThuVND"
        Me.colThuVND.ReadOnly = True
        Me.colThuVND.Width = 95
        '
        'colChiVND
        '
        Me.colChiVND.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.colChiVND.Format = "###,###"
        Me.colChiVND.FormatInfo = Nothing
        Me.colChiVND.HeaderText = "Chi VND"
        Me.colChiVND.MappingName = "ChiVND"
        Me.colChiVND.ReadOnly = True
        Me.colChiVND.Width = 95
        '
        'colTonVND
        '
        Me.colTonVND.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTonVND.Format = "###,###"
        Me.colTonVND.FormatInfo = Nothing
        Me.colTonVND.HeaderText = "Tồn VND"
        Me.colTonVND.MappingName = "ToncuoiVND"
        Me.colTonVND.NullText = ""
        Me.colTonVND.ReadOnly = True
        Me.colTonVND.Width = 95
        '
        'coltondauUSD
        '
        Me.coltondauUSD.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.coltondauUSD.Format = "###,###.00"
        Me.coltondauUSD.FormatInfo = Nothing
        Me.coltondauUSD.HeaderText = "Tồn đầu USD"
        Me.coltondauUSD.MappingName = "tondauUSD"
        Me.coltondauUSD.ReadOnly = True
        Me.coltondauUSD.Width = 70
        '
        'colThuUSD
        '
        Me.colThuUSD.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.colThuUSD.Format = "###,###.00"
        Me.colThuUSD.FormatInfo = Nothing
        Me.colThuUSD.HeaderText = "Thu USD"
        Me.colThuUSD.MappingName = "ThuUSD"
        Me.colThuUSD.NullText = ""
        Me.colThuUSD.ReadOnly = True
        Me.colThuUSD.Width = 70
        '
        'ColChiUSD
        '
        Me.ColChiUSD.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColChiUSD.Format = "###,###.00"
        Me.ColChiUSD.FormatInfo = Nothing
        Me.ColChiUSD.HeaderText = "Chi USD"
        Me.ColChiUSD.MappingName = "ChiUsd"
        Me.ColChiUSD.ReadOnly = True
        Me.ColChiUSD.Width = 70
        '
        'ColTonUSD
        '
        Me.ColTonUSD.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColTonUSD.Format = "###,###.00"
        Me.ColTonUSD.FormatInfo = Nothing
        Me.ColTonUSD.HeaderText = "Tồn USD"
        Me.ColTonUSD.MappingName = "ToncuoiUSD"
        Me.ColTonUSD.ReadOnly = True
        Me.ColTonUSD.Width = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(159, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tổng tồn VND"
        '
        'TxtToncuoiVND
        '
        Me.TxtToncuoiVND.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtToncuoiVND.Location = New System.Drawing.Point(260, 425)
        Me.TxtToncuoiVND.Multiline = True
        Me.TxtToncuoiVND.Name = "TxtToncuoiVND"
        Me.TxtToncuoiVND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtToncuoiVND.Size = New System.Drawing.Size(120, 24)
        Me.TxtToncuoiVND.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(401, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tổng tồn USD"
        '
        'TxTTonCuoiUSD
        '
        Me.TxTTonCuoiUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTTonCuoiUSD.Location = New System.Drawing.Point(504, 425)
        Me.TxTTonCuoiUSD.Multiline = True
        Me.TxTTonCuoiUSD.Name = "TxTTonCuoiUSD"
        Me.TxTTonCuoiUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxTTonCuoiUSD.Size = New System.Drawing.Size(120, 24)
        Me.TxTTonCuoiUSD.TabIndex = 6
        '
        'frmTKTon_quy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(636, 462)
        Me.Controls.Add(Me.TxTTonCuoiUSD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtToncuoiVND)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grdDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmTKTon_quy"
        Me.Text = "THỐNG KÊ TIỀN THEO QUỸ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbQuy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpThoigian.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpThoigian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_tungay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub tbnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnXem.Click
        Xetngay()
        loaddata_khoitao()
    End Sub
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Dim frm As New frmShowReport
        frm.Paraval3 = ToncuoiVND
        frm.Paraval4 = ToncuoiUSD
        frm.Tngay = Me.dtp_tungay.DateTime
        frm.Dngay = Me.dtpThoigian.DateTime
        frm.strBC = frmShowReport.TenBc.TKTon_Quy
        frm.dtb = dtbTon_quy
        frm.Show()
    End Sub
    Private Sub frmTKTon_quy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        blnFoundClick = True
        Load_ComboBox("SELECT Maquy,Tenquy From CTQuy", Me.cmbQuy, CNNQLPHONGKHAM)
        Me.dtpThoigian.DateTime = TODAY.Date.Date
        Me.dtp_tungay.DateTime = TODAY.Date.Date
        blnFoundClick = False
        Dim strSQL As String
        Dim clsobj As New clsThuchi
        Dim dtb2 As DataTable
        strSQL = "Select * from Ton_Quy WHERE Convert(char(10),Ngay,101) ='" & Format(TODAY.Date, "MM/dd/yyyy") & "'"
        dtb2 = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        If dtb2.Rows.Count > 0 Then
        Else
            clsobj.TinhTonQuy(CNNQLPHONGKHAM)
        End If
        loaddata_khoitao()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub cmbQuy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbQuy.KeyDown
        If e.KeyCode = Keys.F2 Or e.KeyCode = Keys.Delete Then
            Me.cmbQuy.EditValue = ""
        End If
    End Sub
    Private Sub dtpThoigian_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpThoigian.KeyDown
        If e.KeyCode = Keys.F2 Or e.KeyCode = Keys.Delete Then
            Me.dtpThoigian.EditValue = ""
        End If
    End Sub
    Private Sub cmbQuy_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbQuy.EditValueChanged
        Dim pos As Int16
        Dim i As Int16
        For i = 0 To Me.grdDetail.VisibleRowCount - 1
            Me.grdDetail.UnSelect(i)
        Next
        pos = GetRowPos(DtvTon_quy, "Maquy", Me.cmbQuy.EditValue)
        If pos <> -1 Then
            Me.grdDetail.CurrentRowIndex = pos
            Me.grdDetail.Select(pos)
        End If
    End Sub
    Private Sub loaddata_khoitao()

        Dim strSQL As String
        ToncuoiVND = 0
        ToncuoiUSD = 0
        i = 0
        strSQL = "SELECT Ton_quy.Maquy,CTQuy.TenQuy,Sum(Ton_quy.ThuUSD)as ThuUSD,Sum(Ton_quy.ChiUSD)as ChiUSD,"
        strSQL &= "Sum(Ton_quy.ThuVND)as ThuVND,Sum(Ton_quy.ChiVND)as ChiVND,"
        'Tinh ton dau USD truoc tu_ngay
        strSQL = strSQL & " (SELECT isnull(TondauUSD,0) FROM Ton_quy b WHERE Ton_quy.Maquy=b.Maquy AND Convert(Char(10),b.Ngay,101)='" & Format(Me.dtp_tungay.DateTime.Date, "MM/dd/yyyy") & "') as TondauUSD,"
        strSQL = strSQL & " (SELECT isnull(ToncuoiUSD,0) FROM Ton_quy b WHERE Ton_quy.Maquy=b.Maquy AND Convert(Char(10),b.Ngay,101)='" & Format(Me.dtpThoigian.DateTime.Date, "MM/dd/yyyy") & "') as ToncuoiUSD,"
        'Tinh ton dau viet nam dong 
        strSQL = strSQL & " (SELECT isnull(TondauVND,0) FROM Ton_quy b WHERE Ton_quy.Maquy=b.Maquy AND Convert(Char(10),b.Ngay,101)='" & Format(Me.dtp_tungay.DateTime.Date, "MM/dd/yyyy") & "') as TondauVND,"
        strSQL = strSQL & " (SELECT isnull(ToncuoiVND,0) FROM Ton_quy b WHERE Ton_quy.Maquy=b.Maquy AND Convert(Char(10),b.Ngay,101)='" & Format(Me.dtpThoigian.DateTime.Date, "MM/dd/yyyy") & "') as ToncuoiVND "
        strSQL &= "FROM  Ton_quy INNER JOIN CTQuy ON Ton_quy.Maquy = CTQuy.Maquy where "
        If Me.dtpThoigian.Text <> "" And Me.dtp_tungay.Text <> "" Then
            GenSQL("Ton_quy.Ngay", MdlCommon.Kieukitu.Ngaythang, "BETWEEN", "AND", Me.dtp_tungay.DateTime.Date, Me.dtpThoigian.DateTime.Date, strSQL)
        End If
        If Me.cmbQuy.EditValue <> "" Then
            GenSQL("Ton_quy.Maquy", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbQuy.EditValue, "", strSQL)
        End If
        strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        strSQL &= "Group by Ton_quy.Maquy,CTQuy.TenQuy"
        dtbTon_quy = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        Me.grdDetail.DataSource = dtbTon_quy
        DtvTon_quy = dtbTon_quy.DefaultView
        For i = 0 To dtbTon_quy.Rows.Count - 1
            ToncuoiVND = ToncuoiVND + dtbTon_quy.Rows(i)("ToncuoiVND")
            ToncuoiUSD = ToncuoiUSD + dtbTon_quy.Rows(i)("ToncuoiUSD")
        Next
        Me.TxTTonCuoiUSD.Text = Format(ToncuoiUSD, "###,###.##") '& "  "
        Me.TxtToncuoiVND.Text = Format(ToncuoiVND, "###,###.##") '& "  VND"

    End Sub
    Private Sub dtp_tungay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_tungay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.dtpThoigian.Focus()
            Xetngay()
            loaddata_khoitao()
        End If
    End Sub
    Private Sub dtpThoigian_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpThoigian.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.tbnXem.Focus()
            Xetngay()
            loaddata_khoitao()
        End If
    End Sub
    Private Sub Xetngay()
        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dtb = Load_DataTable("select * from ket_chuyen", CNNQLPHONGKHAM)
        ngayketchuyen = dtb.Rows(0)("ngayketchuyen")
        If Me.dtp_tungay.Text = "" Or Me.dtp_tungay.DateTime.Date <= ngayketchuyen.Date Then
            Me.dtp_tungay.DateTime = ngayketchuyen.AddDays(1).Date
        End If
        If Me.dtpThoigian.Text = "" Or Me.dtpThoigian.DateTime.Date > TODAY.Date.Date Then
            Me.dtpThoigian.DateTime = TODAY.Date.Date
        End If
        If Me.dtp_tungay.DateTime.Date > Me.dtpThoigian.DateTime.Date Then
            MsgBox("Từ ngày không thể lớn hơn đến ngày!")
        End If
    End Sub

End Class
