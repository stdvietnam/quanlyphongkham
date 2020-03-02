Imports System.ComponentModel
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports System.Collections.Generic

Public Class FRM_CANLAMSANG
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
    Friend WithEvents cmbNhomSp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
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
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtTongBN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTongtienkham As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colhenkham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbmabn As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chk_henkham As System.Windows.Forms.CheckBox
    Friend WithEvents chk_all As System.Windows.Forms.CheckBox
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSanPham As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDoituong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CANLAMSANG))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhenkham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_all = New System.Windows.Forms.CheckBox()
        Me.chk_henkham = New System.Windows.Forms.CheckBox()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbNhomSp = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnthoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnINtke = New DevExpress.XtraEditors.SimpleButton()
        Me.Date_denngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Date_tungay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbmabn = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmbSanPham = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtTongBN = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTongtienkham = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDoituong = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhomSp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_denngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_denngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_tungay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmabn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSanPham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridControl1.Location = New System.Drawing.Point(0, 108)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1080, 383)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn7, Me.GridColumn8, Me.GridColumn11, Me.colhenkham, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số phiếu CLS"
        Me.GridColumn1.FieldName = "RefNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SOPHIEU", "Tổng số: {0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 103
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ngày lập"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "DateLap"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 92
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tên dịch vụ"
        Me.GridColumn3.FieldName = "TenSp"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 196
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tên BN"
        Me.GridColumn4.FieldName = "HoTenBN"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 157
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Địa chỉ"
        Me.GridColumn7.FieldName = "DiaChiChiTiet"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 212
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Điện thoại"
        Me.GridColumn8.FieldName = "DienThoai"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 159
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Hẹn khám"
        Me.GridColumn11.FieldName = "Is_HenKham"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        Me.GridColumn11.Width = 67
        '
        'colhenkham
        '
        Me.colhenkham.Caption = "Ngày hẹn khám"
        Me.colhenkham.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colhenkham.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colhenkham.FieldName = "NgayHenKham"
        Me.colhenkham.GroupFormat.FormatString = "dd/MM/yyyy"
        Me.colhenkham.Name = "colhenkham"
        Me.colhenkham.OptionsColumn.AllowEdit = False
        Me.colhenkham.OptionsColumn.AllowFocus = False
        Me.colhenkham.Visible = True
        Me.colhenkham.VisibleIndex = 6
        Me.colhenkham.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Gói DV"
        Me.GridColumn5.FieldName = "Is_GoiDV"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(510, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Dịch vụ"
        '
        'chk_all
        '
        Me.chk_all.AutoSize = True
        Me.chk_all.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.chk_all.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_all.Location = New System.Drawing.Point(596, 66)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(63, 20)
        Me.chk_all.TabIndex = 39
        Me.chk_all.Text = "Tất cả"
        Me.chk_all.UseVisualStyleBackColor = True
        '
        'chk_henkham
        '
        Me.chk_henkham.AutoSize = True
        Me.chk_henkham.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.chk_henkham.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_henkham.Location = New System.Drawing.Point(682, 66)
        Me.chk_henkham.Name = "chk_henkham"
        Me.chk_henkham.Size = New System.Drawing.Size(84, 20)
        Me.chk_henkham.TabIndex = 38
        Me.chk_henkham.Text = "Hẹn khám"
        Me.chk_henkham.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(766, 63)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 29
        Me.btnXem.Text = "&Xem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(212, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Bệnh nhân"
        '
        'cmbNhomSp
        '
        Me.cmbNhomSp.AllowDrop = True
        Me.cmbNhomSp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbNhomSp.Location = New System.Drawing.Point(286, 62)
        Me.cmbNhomSp.Name = "cmbNhomSp"
        Me.cmbNhomSp.Properties.AutoHeight = False
        Me.cmbNhomSp.Properties.AutoSearchColumnIndex = 1
        Me.cmbNhomSp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNhomSp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbNhomSp.Properties.NullText = ""
        Me.cmbNhomSp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNhomSp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNhomSp.Size = New System.Drawing.Size(208, 22)
        Me.cmbNhomSp.TabIndex = 5
        Me.cmbNhomSp.Tag = "Phongkham"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(212, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 16)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Nhóm DV"
        '
        'btnthoat
        '
        Me.btnthoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnthoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnthoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnthoat.Appearance.Options.UseFont = True
        Me.btnthoat.Appearance.Options.UseForeColor = True
        Me.btnthoat.Location = New System.Drawing.Point(946, 63)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 25)
        Me.btnthoat.TabIndex = 29
        Me.btnthoat.Text = "&Thoát"
        '
        'btnINtke
        '
        Me.btnINtke.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnINtke.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnINtke.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnINtke.Appearance.Options.UseFont = True
        Me.btnINtke.Appearance.Options.UseForeColor = True
        Me.btnINtke.Location = New System.Drawing.Point(856, 63)
        Me.btnINtke.Name = "btnINtke"
        Me.btnINtke.Size = New System.Drawing.Size(75, 25)
        Me.btnINtke.TabIndex = 29
        Me.btnINtke.Text = "&In TK"
        '
        'Date_denngay
        '
        Me.Date_denngay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.Date_denngay.Location = New System.Drawing.Point(91, 62)
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
        Me.Date_denngay.Size = New System.Drawing.Size(106, 22)
        Me.Date_denngay.TabIndex = 26
        Me.Date_denngay.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Đến ngày"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Từ ngày"
        '
        'Date_tungay
        '
        Me.Date_tungay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.Date_tungay.Location = New System.Drawing.Point(91, 31)
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
        Me.Date_tungay.Size = New System.Drawing.Size(106, 22)
        Me.Date_tungay.TabIndex = 26
        Me.Date_tungay.Tag = ""
        '
        'cmbmabn
        '
        Me.cmbmabn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbmabn.Location = New System.Drawing.Point(286, 31)
        Me.cmbmabn.Name = "cmbmabn"
        Me.cmbmabn.Properties.AutoHeight = False
        Me.cmbmabn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmabn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbmabn.Properties.NullText = ""
        Me.cmbmabn.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cmbmabn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbmabn.Size = New System.Drawing.Size(208, 22)
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
        'cmbSanPham
        '
        Me.cmbSanPham.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbSanPham.Location = New System.Drawing.Point(573, 31)
        Me.cmbSanPham.Name = "cmbSanPham"
        Me.cmbSanPham.Properties.AutoHeight = False
        Me.cmbSanPham.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSanPham.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbSanPham.Properties.NullText = ""
        Me.cmbSanPham.Properties.PopupView = Me.GridView2
        Me.cmbSanPham.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSanPham.Size = New System.Drawing.Size(204, 22)
        Me.cmbSanPham.TabIndex = 41
        Me.cmbSanPham.Tag = "Phongkham"
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.btnXem)
        Me.GroupControl1.Controls.Add(Me.Date_tungay)
        Me.GroupControl1.Controls.Add(Me.btnthoat)
        Me.GroupControl1.Controls.Add(Me.btnINtke)
        Me.GroupControl1.Controls.Add(Me.chk_all)
        Me.GroupControl1.Controls.Add(Me.cmbSanPham)
        Me.GroupControl1.Controls.Add(Me.chk_henkham)
        Me.GroupControl1.Controls.Add(Me.cmbmabn)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Date_denngay)
        Me.GroupControl1.Controls.Add(Me.cmbNhomSp)
        Me.GroupControl1.Controls.Add(Me.Label16)
        Me.GroupControl1.Controls.Add(Me.cmbDoituong)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1080, 106)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Thông tin tìm kiếm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(573, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Đối tượng"
        '
        'cmbDoituong
        '
        Me.cmbDoituong.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbDoituong.Location = New System.Drawing.Point(658, 141)
        Me.cmbDoituong.Name = "cmbDoituong"
        Me.cmbDoituong.Properties.AutoHeight = False
        Me.cmbDoituong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDoituong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbDoituong.Properties.NullText = ""
        Me.cmbDoituong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDoituong.Size = New System.Drawing.Size(180, 22)
        Me.cmbDoituong.TabIndex = 41
        Me.cmbDoituong.Tag = "Phongkham"
        '
        'FRM_CANLAMSANG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1080, 493)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TxtTongBN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTongtienkham)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_CANLAMSANG"
        Me.Text = "THỐNG KÊ DỊCH VỤ CLS"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhomSp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_denngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_denngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_tungay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_tungay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmabn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSanPham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
        chk_all.Checked = True
        Form_Initial()
        Load_Data()
    End Sub
    Private Sub Form_Initial()
        Load_ComboBox("SELECT MaNhom,TenNhom FROM Nhom_Sp order by TenNhom", Me.cmbNhomSp, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaSp[Mã Sp],TenSp[Tên Sp] FROM San_Pham Where Manhom not in (10,19) order by Manhom", Me.cmbSanPham, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT mabn[Mã],Hotenbn[Bệnh nhân] FROM HOSOBN order by Hotenbn", Me.cmbmabn, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT id[Mã],doituong[Đối tượng] FROM DM_DOITUONG", Me.cmbDoituong, CNNQLPHONGKHAM)
    End Sub
    Private Sub Load_Data()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        Application.CurrentCulture = myCIintl
        dtbPXN = BusinessLogic.Data.GetDataset("TK_CANLAMSANG", CommandType.StoredProcedure, New List(Of String) From {"tungay", "denngay", "mabn", "loaidv", "henkham", "xemtatca", "masp"}, New List(Of Object) From {Date_tungay.DateTime, Date_denngay.DateTime, cmbmabn.EditValue, cmbNhomSp.EditValue, IIf(Me.chk_henkham.Checked, 1, 0), IIf(Me.chk_all.Checked, 1, 0), cmbSanPham.EditValue}).Tables(0)
        Me.GridControl1.DataSource = dtbPXN
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        'Dim frm As New FRM_PhieuKham
        'frm.xemphieu = True
        'Dim dr As DataRowView
        'dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        'If Not dr Is Nothing Then
        '    If Me.GridView1.FocusedRowHandle <> -999999 Then
        '        If dr.IsNew = False Then
        '            frm.IDPhieukham &= dr("SOPHIEU")
        '            If dr("Huy") = True Then
        '                frm.blnDelete = True
        '            End If
        '        End If
        '    End If
        'End If
        'Dim frm1 As Form
        'frm.StartPosition = FormStartPosition.CenterScreen
        'For Each frm1 In Me.OwnedForms
        '    If (frm1.Name = frm.Name) Then
        '        frm1.Activate()
        '        Exit Sub
        '    End If
        'Next
        'Me.AddOwnedForm(frm)
        'frm.Show()
    End Sub
    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Load_Data()
    End Sub
    Private Sub btnINtke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINtke.Click
        Dim Link As New PrintableComponentLink(New PrintingSystem())
        Link.Component = GridControl1
        AddHandler Link.CreateMarginalHeaderArea, AddressOf Link_CreateMarginalHeaderArea
        Link.PaperKind = Printing.PaperKind.A4
        Link.Landscape = True
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Sub Link_CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        Dim Brick() As PageInfoBrick = {e.Graph.DrawPageInfo(PageInfo.None, "THỐNG KÊ DỊCH VỤ CẬN LÂM SÀNG", Color.DarkBlue, New RectangleF(0, 0, 500, 35), BorderSide.None), e.Graph.DrawPageInfo(PageInfo.None, "Từ ngày " & Date_tungay.DateTime.ToString("dd/MM/yyyy") & " đến ngày " & Date_denngay.DateTime.ToString("dd/MM/yyyy") & "", Color.DarkBlue, New RectangleF(0, 0, 100, 20), BorderSide.None)}
        Brick(0).LineAlignment = BrickAlignment.Center
        Brick(0).Alignment = BrickAlignment.Center
        Brick(0).AutoWidth = True
        Brick(0).Font = New System.Drawing.Font("Arial", 17.0F)

        Brick(1).LineAlignment = BrickAlignment.Far
        Brick(1).Alignment = BrickAlignment.Center
        Brick(1).AutoWidth = True
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

    Private Sub cmbbacsi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNhomSp.EditValueChanged
        Load_ComboBox("SELECT MaSp[Mã Sp],TenSp[Tên Sp] from San_Pham Where manhom='" & cmbNhomSp.EditValue & "' and Manhom not in (10,19)  order by Manhom", Me.cmbSanPham, CNNQLPHONGKHAM)
        Load_Data()
    End Sub
    Private Sub Date_tungay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date_tungay.KeyDown
        Dim dtngay As New DataTable
        dtngay = BusinessLogic.Data.GetDataset("Select ngayketchuyen From ket_chuyen").Tables(0)
        If e.KeyCode = Keys.Delete Then
            If dtngay.Rows.Count > 0 Then
                Me.Date_tungay.DateTime = dtngay.Rows(0)("ngayketchuyen")
            Else
                Me.Date_tungay.DateTime = Today.Date
            End If
        End If
    End Sub

    Private Sub cmbDoituong_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDoituong.KeyDown
        If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Back) Then
            cmbDoituong.EditValue = Nothing
        End If
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            Try
                If Not View.GetRowCellValue(e.RowHandle(), "Is_HenKham") Is DBNull.Value Then
                    If View.GetRowCellValue(e.RowHandle(), "Is_HenKham") = True Then
                        If Not View.GetRowCellValue(e.RowHandle(), "NgayHenKham") Is DBNull.Value Then
                            Dim Ngayhen As DateTime = View.GetRowCellValue(e.RowHandle(), "NgayHenKham")
                            Dim songay As Integer = Integer.Parse(BusinessLogic.Data.GetDataset("select datediff(d,getdate(),'" & Ngayhen & "') as songay").Tables(0).Rows(0)("songay"))
                            If songay > 0 And songay <= 3 Then
                                e.Appearance.BackColor = Color.Salmon
                                e.Appearance.BackColor2 = Color.SeaShell
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If dr("Manhom") = Integer.Parse(NhomDV.XETNGHIEM).ToString() Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ XÉT NGHIỆM"
                frm.IDSophieu = dr("SoPhieu")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.load_all = False
                frm.duoclam = 1
                frm.loai = Integer.Parse(NhomDV.XETNGHIEM).ToString()
                frm.type = Integer.Parse(LoaiDV.XETNGHIEM).ToString()
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Manhom") = Integer.Parse(NhomDV.SIEUAM).ToString() Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ SIÊU ÂM"
                frm.IDSophieu = dr("RefNo")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.load_all = False
                frm.loai = Integer.Parse(NhomDV.SIEUAM).ToString()
                frm.type = Integer.Parse(LoaiDV.SIEUAM).ToString()
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Manhom") = Integer.Parse(NhomDV.XQUANG).ToString() Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ XQuang"
                frm.IDSophieu = dr("RefNo")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.load_all = False
                frm.loai = Integer.Parse(NhomDV.XQUANG).ToString()
                frm.type = Integer.Parse(LoaiDV.XQUANG).ToString()
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Manhom") = Integer.Parse(NhomDV.DIENTIM).ToString() Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ ĐIỆN TIM"
                frm.IDSophieu = dr("RefNo")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.load_all = False
                frm.loai = Integer.Parse(NhomDV.DIENTIM).ToString()
                frm.type = Integer.Parse(LoaiDV.DIENTIM).ToString()
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Manhom") = Integer.Parse(NhomDV.NOISOI).ToString() Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ NỘI SOI"
                frm.IDSophieu = dr("RefNo")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.load_all = False
                frm.loai = Integer.Parse(NhomDV.NOISOI).ToString()
                frm.type = Integer.Parse(LoaiDV.NOISOI).ToString()
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
            If dr("Manhom") = Integer.Parse(NhomDV.TTPT).ToString() Then
                Dim frm As New FRM_KECANLAMSANG
                'frm.xemphieu = True
                frm.Text = "DỊCH VỤ PHẨU THUẬT"
                frm.IDSophieu = dr("RefNo")
                frm.IDPhieuxuat = dr("IDsophieu")
                frm.load_all = False
                frm.loai = Integer.Parse(NhomDV.TTPT).ToString()
                frm.type = Integer.Parse(LoaiDV.THUTHUAT).ToString()
                frm.StartPosition = FormStartPosition.CenterScreen
                Me.AddOwnedForm(frm)
                frm.Show()
            End If
        End If
    End Sub

    Private Sub cmbNhomSp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNhomSp.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            cmbNhomSp.EditValue = Nothing
        End If
    End Sub

    Private Sub cmbSanPham_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSanPham.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            cmbNhomSp.EditValue = ""
        End If
    End Sub
End Class
