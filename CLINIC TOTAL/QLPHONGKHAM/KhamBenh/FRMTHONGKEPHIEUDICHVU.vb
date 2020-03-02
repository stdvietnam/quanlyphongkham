Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Public Class FRMTHONGKEPHIEUDICHVU
    Inherits frmBase 'System.Windows.Forms.Form
    Private dtbPXN As New DataTable
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Date_denngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Date_tungay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnINtke As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnthoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtTongBN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTongtienkham As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbloaidv As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colthutien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChidinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colloai As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMTHONGKEPHIEUDICHVU))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colphong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChidinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colloai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colthutien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbloaidv = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.Date_denngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Date_tungay = New DevExpress.XtraEditors.DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnthoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnINtke = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtTongBN = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTongtienkham = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbloaidv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_denngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_denngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_tungay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTongBN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongtienkham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 105)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1026, 490)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colphong, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colChidinh, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.colloai, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.colthutien})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colphong, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colphong
        '
        Me.colphong.Caption = "Phòng"
        Me.colphong.FieldName = "maphong"
        Me.colphong.Name = "colphong"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số phiếu"
        Me.GridColumn1.FieldName = "SOPHIEU"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 73
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ngày"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "NGAYLAP"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 88
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Họ tên"
        Me.GridColumn3.FieldName = "HOTEN"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 145
        '
        'colChidinh
        '
        Me.colChidinh.Caption = "Chỉ định"
        Me.colChidinh.FieldName = "TenSp"
        Me.colChidinh.Name = "colChidinh"
        Me.colChidinh.Visible = True
        Me.colChidinh.VisibleIndex = 3
        Me.colChidinh.Width = 143
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Chẩn đoán"
        Me.GridColumn7.FieldName = "CHANDOANLAMSANG"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.AllowFocus = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 149
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Kết luận"
        Me.GridColumn8.FieldName = "KETLUAN"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.AllowFocus = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 190
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tiền khám"
        Me.GridColumn9.DisplayFormat.FormatString = "###,###"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "THANHTIEN"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THANHTIEN", "{0: ###,###}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 70
        '
        'colloai
        '
        Me.colloai.Caption = "Loại DV"
        Me.colloai.FieldName = "NhomXetNghiem"
        Me.colloai.Name = "colloai"
        Me.colloai.OptionsColumn.AllowEdit = False
        Me.colloai.OptionsColumn.AllowFocus = False
        Me.colloai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colloai.Visible = True
        Me.colloai.VisibleIndex = 7
        Me.colloai.Width = 42
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Loại"
        Me.GridColumn10.FieldName = "LoaiDV"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.AllowFocus = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Width = 33
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Hủy"
        Me.GridColumn11.FieldName = "HUY"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.AllowFocus = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        Me.GridColumn11.Width = 24
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Xong"
        Me.GridColumn12.FieldName = "SAXONG"
        Me.GridColumn12.MinWidth = 10
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.AllowFocus = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 39
        '
        'colthutien
        '
        Me.colthutien.Caption = "Thu tiền"
        Me.colthutien.FieldName = "thutien"
        Me.colthutien.Name = "colthutien"
        Me.colthutien.OptionsColumn.AllowEdit = False
        Me.colthutien.OptionsColumn.AllowFocus = False
        Me.colthutien.Visible = True
        Me.colthutien.VisibleIndex = 9
        Me.colthutien.Width = 44
        '
        'cmbloaidv
        '
        Me.cmbloaidv.AllowDrop = True
        Me.cmbloaidv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbloaidv.Location = New System.Drawing.Point(325, 36)
        Me.cmbloaidv.Name = "cmbloaidv"
        Me.cmbloaidv.Properties.AutoHeight = False
        Me.cmbloaidv.Properties.AutoSearchColumnIndex = 1
        Me.cmbloaidv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbloaidv.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbloaidv.Properties.NullText = ""
        Me.cmbloaidv.Properties.ReadOnly = True
        Me.cmbloaidv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbloaidv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbloaidv.Size = New System.Drawing.Size(269, 23)
        Me.cmbloaidv.TabIndex = 118
        Me.cmbloaidv.Tag = "Bacsi"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(699, 35)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 29
        Me.btnXem.Text = "&Xem"
        '
        'Date_denngay
        '
        Me.Date_denngay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.Date_denngay.Location = New System.Drawing.Point(107, 64)
        Me.Date_denngay.Name = "Date_denngay"
        Me.Date_denngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Date_denngay.Properties.Appearance.Options.UseFont = True
        Me.Date_denngay.Properties.AutoHeight = False
        Me.Date_denngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_denngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Date_denngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Date_denngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_denngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Date_denngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_denngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.Date_denngay.Size = New System.Drawing.Size(105, 23)
        Me.Date_denngay.TabIndex = 26
        Me.Date_denngay.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Từ ngày:"
        '
        'Date_tungay
        '
        Me.Date_tungay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.Date_tungay.Location = New System.Drawing.Point(107, 35)
        Me.Date_tungay.Name = "Date_tungay"
        Me.Date_tungay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Date_tungay.Properties.Appearance.Options.UseFont = True
        Me.Date_tungay.Properties.AutoHeight = False
        Me.Date_tungay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_tungay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Date_tungay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Date_tungay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_tungay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Date_tungay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_tungay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.Date_tungay.Size = New System.Drawing.Size(105, 23)
        Me.Date_tungay.TabIndex = 26
        Me.Date_tungay.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(260, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Loại DV:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(32, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Đến ngày:"
        '
        'btnthoat
        '
        Me.btnthoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnthoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnthoat.Appearance.Options.UseFont = True
        Me.btnthoat.Appearance.Options.UseForeColor = True
        Me.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnthoat.Location = New System.Drawing.Point(897, 35)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 25)
        Me.btnthoat.TabIndex = 29
        Me.btnthoat.Text = "&Thoát"
        '
        'btnINtke
        '
        Me.btnINtke.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnINtke.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnINtke.Appearance.Options.UseFont = True
        Me.btnINtke.Appearance.Options.UseForeColor = True
        Me.btnINtke.Location = New System.Drawing.Point(798, 35)
        Me.btnINtke.Name = "btnINtke"
        Me.btnINtke.Size = New System.Drawing.Size(75, 25)
        Me.btnINtke.TabIndex = 29
        Me.btnINtke.Text = "&In TK"
        '
        'TxtTongBN
        '
        Me.TxtTongBN.EditValue = ""
        Me.TxtTongBN.Location = New System.Drawing.Point(90, 566)
        Me.TxtTongBN.Name = "TxtTongBN"
        Me.TxtTongBN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTongBN.Properties.Appearance.Options.UseFont = True
        Me.TxtTongBN.Properties.AutoHeight = False
        Me.TxtTongBN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTongBN.Size = New System.Drawing.Size(88, 22)
        Me.TxtTongBN.TabIndex = 23
        Me.TxtTongBN.Tag = ""
        Me.TxtTongBN.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 568)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tổng BN:"
        Me.Label1.Visible = False
        '
        'txtTongtienkham
        '
        Me.txtTongtienkham.EditValue = ""
        Me.txtTongtienkham.Location = New System.Drawing.Point(335, 566)
        Me.txtTongtienkham.Name = "txtTongtienkham"
        Me.txtTongtienkham.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongtienkham.Properties.Appearance.Options.UseFont = True
        Me.txtTongtienkham.Properties.AutoHeight = False
        Me.txtTongtienkham.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongtienkham.Size = New System.Drawing.Size(136, 22)
        Me.txtTongtienkham.TabIndex = 23
        Me.txtTongtienkham.Tag = "SOPHIEU"
        Me.txtTongtienkham.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(205, 568)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tổng Thành tiền:"
        Me.Label4.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.BackColor = System.Drawing.Color.LightBlue
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(1, 1)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(1025, 40)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "THỐNG KÊ PHIẾU SIÊU ÂM"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.cmbloaidv)
        Me.GroupControl1.Controls.Add(Me.Date_tungay)
        Me.GroupControl1.Controls.Add(Me.btnXem)
        Me.GroupControl1.Controls.Add(Me.btnINtke)
        Me.GroupControl1.Controls.Add(Me.Date_denngay)
        Me.GroupControl1.Controls.Add(Me.btnthoat)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1026, 103)
        Me.GroupControl1.TabIndex = 46
        Me.GroupControl1.Text = "Điều kiện tìm kiếm"
        '
        'FRMTHONGKEPHIEUDICHVU
        '
        Me.AcceptButton = Me.btnXem
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.CancelButton = Me.btnthoat
        Me.ClientSize = New System.Drawing.Size(1026, 596)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TxtTongBN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTongtienkham)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMTHONGKEPHIEUDICHVU"
        Me.Text = "THỐNG KÊ DỊCH VỤ"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbloaidv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_denngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_denngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_tungay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTongBN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongtienkham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FRMTHONGKEPHIEUSIEUAMTH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.Date_tungay.DateTime = NgayGioServer().Date
        Me.Date_denngay.DateTime = NgayGioServer().Date
        'Load_Comb(BusinessLogic.Data.GetDatatable("select ma,ten from tb_loaidv order by ma"), cmbloaidv, "ma", "ten")
        Load_ComboBox("select MaNhom,TenNhom from Nhom_Sp", cmbloaidv, CNNQLPHONGKHAM)
        Load_Data()
        Me.GridView1.Columns.Remove(GridColumn10)
    End Sub

    Private Sub Load_Data()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        Application.CurrentCulture = myCIintl
        Dim dts As New DataSet
        Dim sql As String = String.Format("SELECT Cast(thutien as bit) as thutien,isnull(c.NhomXetNghiem,'') as NhomXetNghiem,c.IDsophieu,c.RefNo as SOPHIEU,c.Datelap as NGAYLAP ,h.HOTENBN as HOTEN,c.maphong,c.Ketluanchung as KETLUAN,((c.Dongia*c.Soluong)*(1-ISNULL(chietkhau,0)/100)) as THANHTIEN,c.LoaiDV,Cast(c.Huy as bit) as HUY,c.Trangthai AS SAXONG,s.TenSp FROM Chi_tiet_NEW c JOIN HOSOBN h ON c.MABN = h.MABN JOIN San_Pham s on s.MaSp=c.Masp WHERE (1=1) and Isnull(c.Huy,0)=0 and c.thutien=1 ")
        If Me.Date_tungay.Text <> "" And Me.Date_denngay.Text <> "" Then
            sql &= String.Format("AND DATEDIFF(D,'{0}',c.Datelap)>=0 and DATEDIFF(D,c.Datelap,'{1}')>=0 ", Date_tungay.DateTime.Date, Date_denngay.DateTime.Date)
        End If
        If Me.cmbloaidv.Text <> "" Then
            sql &= String.Format("AND c.loaiDV='{0}' ", Me.cmbloaidv.EditValue)
        End If
        sql &= String.Format("Group By c.maphong,NhomXetNghiem,c.IDsophieu,RefNo,Datelap,HotenBN,thutien,Ketluanchung,TotalAmount,LoaiDV,c.huy, trangthai,s.TenSp,c.chietkhau,c.Dongia,c.soluong")
        dts = BusinessLogic.Data.GetDataset(sql)
        dtbPXN = dts.Tables(0)
        Me.GridControl1.DataSource = dtbPXN
        Me.GridView1.ExpandAllGroups()
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If dr("Loaidv") = 13 Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ XÉT NGHIỆM"
                frm.IDSophieu = dr("SoPhieu")
                frm.load_all = False
                frm.loai = "13"
                frm.duoclam = 1
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.type = "2"
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Loaidv") = 14 Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ SIÊU ÂM"
                frm.load_all = False
                frm.loai = "14"
                frm.IDSophieu = dr("SoPhieu")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.type = "3"
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Loaidv") = 15 Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ XQuang"
                frm.IDSophieu = dr("SoPhieu")
                frm.load_all = False
                frm.loai = "15"
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.type = "5"
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Loaidv") = 16 Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ ĐIỆN TIM"
                frm.IDSophieu = dr("SoPhieu")
                frm.load_all = False
                frm.loai = "16"
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.type = "6"
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Loaidv") = 17 Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ NỘI SOI"
                frm.load_all = False
                frm.loai = "17"
                frm.IDSophieu = dr("SoPhieu")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.type = "4"
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Loaidv") = 18 Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ PHẨU THUẬT"
                frm.IDSophieu = dr("SoPhieu")
                frm.load_all = False
                frm.loai = "18"
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.type = "7"
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
        End If
    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Load_Data()
    End Sub

    Private Sub btnINtke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINtke.Click
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.Thongkephieusieuam
        frm.Tngay = Me.Date_tungay.DateTime.Date
        frm.Dngay = Me.Date_denngay.DateTime.Date
        frm.Title = Me.Text.ToUpper
        Try
            frm.tientongtien = Me.GridColumn9.SummaryText
        Catch ex As Exception

        End Try

        frm.dtb = dtbPXN
        frm.Show()
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub ngay1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date_tungay.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.Date_tungay.EditValue = ""
        End If
    End Sub

    Private Sub ngay2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date_denngay.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.Date_denngay.EditValue = ""
        End If
    End Sub

    Private Sub Radio_Daxong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_chuaxong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_tatcaphieu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_Khonghuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_Huy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_tatca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Rad_dinhky_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Rad_tx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Date_tungay_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_tungay.EditValueChanged
        Load_Data()
    End Sub

    Private Sub Date_denngay_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_denngay.EditValueChanged
        Load_Data()
    End Sub

    Private Sub Txtthebaohiem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub txtSophieu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub cmbNguoilap_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub cmbbacsi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub cmbBacsiSieuam_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub
End Class
