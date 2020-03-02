Imports System.ComponentModel
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports System.Collections.Generic
Imports Dapper

Public Class FRMTHONGKEPHIEUKHAM
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
    Friend WithEvents cmbbacsi As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtTongBN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTongtienkham As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhenkham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colngayhen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbmabn As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chk_henkham As System.Windows.Forms.CheckBox
    Friend WithEvents chk_all As System.Windows.Forms.CheckBox
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbDoituong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMTHONGKEPHIEUKHAM))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhenkham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colngayhen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chk_all = New System.Windows.Forms.CheckBox()
        Me.chk_henkham = New System.Windows.Forms.CheckBox()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbbacsi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Date_denngay = New DevExpress.XtraEditors.DateEdit()
        Me.btnthoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnINtke = New DevExpress.XtraEditors.SimpleButton()
        Me.Date_tungay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbmabn = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtTongBN = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTongtienkham = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDoituong = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbacsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_denngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_denngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_tungay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmabn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTongBN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongtienkham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbDoituong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(0, 99)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1135, 407)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn11, Me.GridColumn12, Me.colhenkham, Me.colngayhen, Me.colphong, Me.colcv, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số phiếu"
        Me.GridColumn1.FieldName = "SOPHIEU"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SOPHIEU", "Tổng số: {0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 72
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ngày"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "NGAYLAP"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 67
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Họ tên"
        Me.GridColumn3.FieldName = "HOTEN"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 143
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Điện thoại"
        Me.GridColumn4.FieldName = "Dienthoai"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 105
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Chẩn đoán"
        Me.GridColumn7.FieldName = "CHANDOANLAMSANG"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 219
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Kết luận"
        Me.GridColumn8.FieldName = "KETLUAN"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 110
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tiền khám"
        Me.GridColumn9.DisplayFormat.FormatString = "###,###"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "THANHTIEN"
        Me.GridColumn9.GroupFormat.FormatString = "###,###"
        Me.GridColumn9.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THANHTIEN", "Tổng tiền={0:###,###}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 70
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Hủy"
        Me.GridColumn11.FieldName = "HUY"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 7
        Me.GridColumn11.Width = 41
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Trạng thái"
        Me.GridColumn12.FieldName = "KHAMXONG"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 8
        Me.GridColumn12.Width = 120
        '
        'colhenkham
        '
        Me.colhenkham.Caption = "Hẹn"
        Me.colhenkham.FieldName = "henkham"
        Me.colhenkham.Name = "colhenkham"
        Me.colhenkham.OptionsColumn.AllowEdit = False
        Me.colhenkham.OptionsColumn.AllowFocus = False
        Me.colhenkham.Visible = True
        Me.colhenkham.VisibleIndex = 9
        Me.colhenkham.Width = 29
        '
        'colngayhen
        '
        Me.colngayhen.Caption = "Ngày hẹn"
        Me.colngayhen.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colngayhen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colngayhen.FieldName = "ngayhenkham"
        Me.colngayhen.Name = "colngayhen"
        Me.colngayhen.OptionsColumn.AllowEdit = False
        Me.colngayhen.OptionsColumn.AllowFocus = False
        Me.colngayhen.Visible = True
        Me.colngayhen.VisibleIndex = 10
        Me.colngayhen.Width = 65
        '
        'colphong
        '
        Me.colphong.Caption = "Mã phòng"
        Me.colphong.FieldName = "phongkham"
        Me.colphong.Name = "colphong"
        Me.colphong.Visible = True
        Me.colphong.VisibleIndex = 11
        Me.colphong.Width = 76
        '
        'colcv
        '
        Me.colcv.Caption = "CV"
        Me.colcv.FieldName = "chuyenvien"
        Me.colcv.Name = "colcv"
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "KieuKham"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 81
        '
        'chk_all
        '
        Me.chk_all.AutoSize = True
        Me.chk_all.BackColor = System.Drawing.Color.Transparent
        Me.chk_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chk_all.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_all.Location = New System.Drawing.Point(654, 30)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(65, 20)
        Me.chk_all.TabIndex = 39
        Me.chk_all.Text = "Tất cả"
        Me.chk_all.UseVisualStyleBackColor = False
        '
        'chk_henkham
        '
        Me.chk_henkham.AutoSize = True
        Me.chk_henkham.BackColor = System.Drawing.Color.Transparent
        Me.chk_henkham.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chk_henkham.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_henkham.Location = New System.Drawing.Point(654, 55)
        Me.chk_henkham.Name = "chk_henkham"
        Me.chk_henkham.Size = New System.Drawing.Size(88, 20)
        Me.chk_henkham.TabIndex = 38
        Me.chk_henkham.Text = "Hẹn khám"
        Me.chk_henkham.UseVisualStyleBackColor = False
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(809, 36)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 29
        Me.btnXem.Text = "&Xem"
        '
        'cmbbacsi
        '
        Me.cmbbacsi.AllowDrop = True
        Me.cmbbacsi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbbacsi.Location = New System.Drawing.Point(341, 55)
        Me.cmbbacsi.Name = "cmbbacsi"
        Me.cmbbacsi.Properties.AutoHeight = False
        Me.cmbbacsi.Properties.AutoSearchColumnIndex = 1
        Me.cmbbacsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbacsi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbbacsi.Properties.NullText = ""
        Me.cmbbacsi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbbacsi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbbacsi.Size = New System.Drawing.Size(296, 22)
        Me.cmbbacsi.TabIndex = 5
        Me.cmbbacsi.Tag = "Phongkham"
        '
        'Date_denngay
        '
        Me.Date_denngay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.Date_denngay.Location = New System.Drawing.Point(98, 55)
        Me.Date_denngay.Name = "Date_denngay"
        Me.Date_denngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_denngay.Properties.Appearance.Options.UseFont = True
        Me.Date_denngay.Properties.Appearance.Options.UseTextOptions = True
        Me.Date_denngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Date_denngay.Properties.AutoHeight = False
        Me.Date_denngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_denngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Date_denngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Date_denngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_denngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Date_denngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_denngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.Date_denngay.Size = New System.Drawing.Size(115, 22)
        Me.Date_denngay.TabIndex = 26
        Me.Date_denngay.Tag = ""
        '
        'btnthoat
        '
        Me.btnthoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnthoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnthoat.Appearance.Options.UseFont = True
        Me.btnthoat.Appearance.Options.UseForeColor = True
        Me.btnthoat.Location = New System.Drawing.Point(1023, 36)
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
        Me.btnINtke.Location = New System.Drawing.Point(916, 36)
        Me.btnINtke.Name = "btnINtke"
        Me.btnINtke.Size = New System.Drawing.Size(75, 25)
        Me.btnINtke.TabIndex = 29
        Me.btnINtke.Text = "&In TK"
        '
        'Date_tungay
        '
        Me.Date_tungay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.Date_tungay.Location = New System.Drawing.Point(98, 28)
        Me.Date_tungay.Name = "Date_tungay"
        Me.Date_tungay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_tungay.Properties.Appearance.Options.UseFont = True
        Me.Date_tungay.Properties.Appearance.Options.UseTextOptions = True
        Me.Date_tungay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Date_tungay.Properties.AutoHeight = False
        Me.Date_tungay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_tungay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Date_tungay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Date_tungay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_tungay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.Date_tungay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_tungay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.Date_tungay.Size = New System.Drawing.Size(115, 22)
        Me.Date_tungay.TabIndex = 26
        Me.Date_tungay.Tag = ""
        '
        'cmbmabn
        '
        Me.cmbmabn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbmabn.Location = New System.Drawing.Point(341, 28)
        Me.cmbmabn.Name = "cmbmabn"
        Me.cmbmabn.Properties.AutoHeight = False
        Me.cmbmabn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmabn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbmabn.Properties.NullText = ""
        Me.cmbmabn.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cmbmabn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbmabn.Size = New System.Drawing.Size(296, 22)
        Me.cmbmabn.TabIndex = 35
        Me.cmbmabn.Tag = "BVCHUYENDEN"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'TxtTongBN
        '
        Me.TxtTongBN.EditValue = ""
        Me.TxtTongBN.Location = New System.Drawing.Point(707, 569)
        Me.TxtTongBN.Name = "TxtTongBN"
        Me.TxtTongBN.Properties.AutoHeight = False
        Me.TxtTongBN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTongBN.Size = New System.Drawing.Size(88, 22)
        Me.TxtTongBN.TabIndex = 23
        Me.TxtTongBN.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(643, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tổng BN:"
        '
        'txtTongtienkham
        '
        Me.txtTongtienkham.EditValue = ""
        Me.txtTongtienkham.Location = New System.Drawing.Point(911, 568)
        Me.txtTongtienkham.Name = "txtTongtienkham"
        Me.txtTongtienkham.Properties.AutoHeight = False
        Me.txtTongtienkham.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongtienkham.Size = New System.Drawing.Size(136, 22)
        Me.txtTongtienkham.TabIndex = 23
        Me.txtTongtienkham.Tag = "SOPHIEU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(801, 571)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tổng Thành tiền:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.cmbDoituong)
        Me.GroupControl1.Controls.Add(Me.chk_all)
        Me.GroupControl1.Controls.Add(Me.Date_denngay)
        Me.GroupControl1.Controls.Add(Me.chk_henkham)
        Me.GroupControl1.Controls.Add(Me.cmbmabn)
        Me.GroupControl1.Controls.Add(Me.Date_tungay)
        Me.GroupControl1.Controls.Add(Me.btnXem)
        Me.GroupControl1.Controls.Add(Me.btnINtke)
        Me.GroupControl1.Controls.Add(Me.btnthoat)
        Me.GroupControl1.Controls.Add(Me.cmbbacsi)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1135, 97)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Điều kiện tìm kiếm"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(253, 59)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl4.TabIndex = 42
        Me.LabelControl4.Text = "Bác sĩ"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl2.TabIndex = 41
        Me.LabelControl2.Text = "Đến ngày"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(253, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl3.TabIndex = 41
        Me.LabelControl3.Text = "Bệnh nhân"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl1.TabIndex = 41
        Me.LabelControl1.Text = "Từ ngày"
        '
        'cmbDoituong
        '
        Me.cmbDoituong.AllowDrop = True
        Me.cmbDoituong.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbDoituong.Location = New System.Drawing.Point(354, 101)
        Me.cmbDoituong.Name = "cmbDoituong"
        Me.cmbDoituong.Properties.AutoHeight = False
        Me.cmbDoituong.Properties.AutoSearchColumnIndex = 1
        Me.cmbDoituong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDoituong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbDoituong.Properties.NullText = ""
        Me.cmbDoituong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDoituong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDoituong.Size = New System.Drawing.Size(296, 22)
        Me.cmbDoituong.TabIndex = 40
        Me.cmbDoituong.Tag = "Phongkham"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(263, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Đối tượng"
        '
        'FRMTHONGKEPHIEUKHAM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1135, 506)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TxtTongBN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTongtienkham)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMTHONGKEPHIEUKHAM"
        Me.Text = "THỐNG KÊ PHIẾU KHÁM"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbacsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_denngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_denngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_tungay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmabn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTongBN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongtienkham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbDoituong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FRMTHONGKEPHIEUKHAM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.Date_tungay.DateTime = NgayGioServer().Date
        Me.Date_denngay.DateTime = NgayGioServer().Date
        Form_Initial()
        Load_Data()
    End Sub
    Private Sub Form_Initial()
        Load_ComboBox("SELECT Username[Mã],Hoten[Họ tên] FROM Nguoi_su_dung order by Hoten", Me.cmbbacsi, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT mabn[Mã],Hotenbn[Bệnh nhân] FROM HOSOBN order by Hotenbn", Me.cmbmabn, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT id[Mã],doituong[Đối tượng] FROM DM_DOITUONG", Me.cmbDoituong, CNNQLPHONGKHAM)
    End Sub
    Private Sub Load_Data()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        dtbPXN = BusinessLogic.Data.GetDataset("TK_PHIEUKHAM2", CommandType.StoredProcedure, New List(Of String) From {"tungay", "denngay", "bacsi", "mabn", "doituong", "henkham", "view"}, New List(Of Object) From {Date_tungay.DateTime, Date_denngay.DateTime, cmbbacsi.EditValue, cmbmabn.EditValue, cmbDoituong.EditValue, IIf(Me.chk_henkham.Checked, 1, 0), IIf(Me.chk_all.Checked, 1, 0)}).Tables(0)
        Me.GridControl1.DataSource = dtbPXN
        Dim i As Int16
        Dim tongBN As Int64
        Dim tongtien As Double
        tongBN = 0
        tongtien = 0
        For i = 0 To dtbPXN.Rows.Count - 1
            tongtien += dtbPXN.Rows(i)("THANHTIEN")
            tongBN = tongBN + 1
        Next
        Me.TxtTongBN.Text = tongBN
        Me.txtTongtienkham.Text = Format(tongtien, "###,###")
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim frm As New FRM_PhieuKham
        frm.xemphieu = True
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr.IsNew = False Then
                    frm.IDPhieukham &= dr("SOPHIEU")
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
        Load_Data()
    End Sub
    Private Sub btnINtke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINtke.Click
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.Thongkephieukham_bh
        frm.Tungay = Me.Date_tungay.DateTime.Date
        frm.Denngay = Me.Date_denngay.DateTime.Date
        frm.bacsi = Me.cmbbacsi.EditValue
        frm.mabn = Me.cmbmabn.EditValue
        frm.henkham = IIf(chk_henkham.Checked, 1, 0)
        frm.view = IIf(chk_all.Checked, 1, 0)
        frm.doituong = cmbDoituong.EditValue
        If Me.txtTongtienkham.Text <> "" Then
            frm.tientongtien = Me.txtTongtienkham.Text
        Else
            frm.tientongtien = 0
        End If
        frm.dtb = dtbPXN
        frm.Show()
    End Sub
    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub Radio_thuongxuyen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_dinhky_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_tatcakham_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Radio_CV_chuyenvien_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_CV_khong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub Radio_CV_TATCA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub txtTheBHYT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub txtSophieu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub cmbNguoilap_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Data()
    End Sub

    Private Sub cmbbacsi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbacsi.EditValueChanged
        Load_Data()
    End Sub
    Private Sub Date_tungay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date_tungay.KeyDown
        Dim dtngay As New DataTable
        dtngay = BusinessLogic.Data.GetDataset("Select ngayketchuyen from ket_chuyen", CommandType.Text, Nothing, Nothing).Tables(0)
        If e.KeyCode = Keys.Delete Then
            If dtngay.Rows.Count > 0 Then
                Me.Date_tungay.DateTime = dtngay.Rows(0)(0)
            Else
                Me.Date_tungay.DateTime = Today.Date
            End If
        End If
    End Sub

    Private Sub cmbDoituong_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbDoituong.EditValue = Nothing
        End If
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            If Not View.GetRowCellValue(e.RowHandle(), "henkham") Is DBNull.Value Then
                If Not View.GetRowCellValue(e.RowHandle(), "ngayhenkham") Is DBNull.Value Then
                    Dim Ngayhen As DateTime = View.GetRowCellValue(e.RowHandle(), "ngayhenkham")
                    Dim songay As Integer = Integer.Parse(BusinessLogic.Data.GetDataset("Select datediff(d,getdate(),'" & Ngayhen & "') as songay").Tables(0).Rows(0)("songay"))
                    If songay > 0 And songay <= 2 Then
                        e.Appearance.BackColor = Color.Salmon
                        e.Appearance.BackColor2 = Color.SeaShell
                    End If
                End If
            End If
        End If
    End Sub
End Class
