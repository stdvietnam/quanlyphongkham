Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDonThuocMau
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonThuocMau))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grid_DonMau = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit_ChiTiet = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit_XoaDon = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_DonMau_Thang = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_DVT_Thang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grid_DonMau_Vien = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox_LieuDung = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_DVT_Vien = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit_Xoa = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSoDonMau = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid_DonMau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit_ChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit_XoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_DonMau_Thang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit_MaSp_Thang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_DVT_Thang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grid_DonMau_Vien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit_MaSp_Vien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_LieuDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_DVT_Vien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit_Xoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoDonMau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grid_DonMau)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 516)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin đơn thuốc mẫu"
        '
        'grid_DonMau
        '
        Me.grid_DonMau.Location = New System.Drawing.Point(3, 16)
        Me.grid_DonMau.MainView = Me.GridView1
        Me.grid_DonMau.Name = "grid_DonMau"
        Me.grid_DonMau.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit_ChiTiet, Me.RepositoryItemButtonEdit_XoaDon})
        Me.grid_DonMau.Size = New System.Drawing.Size(387, 497)
        Me.grid_DonMau.TabIndex = 0
        Me.grid_DonMau.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn14})
        Me.GridView1.GridControl = Me.grid_DonMau
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tên đơn thuốc mẫu"
        Me.GridColumn1.FieldName = "TenDonThuocMau"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 289
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Chi tiết"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemButtonEdit_ChiTiet
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 42
        '
        'RepositoryItemButtonEdit_ChiTiet
        '
        Me.RepositoryItemButtonEdit_ChiTiet.AutoHeight = False
        Me.RepositoryItemButtonEdit_ChiTiet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)})
        Me.RepositoryItemButtonEdit_ChiTiet.Name = "RepositoryItemButtonEdit_ChiTiet"
        Me.RepositoryItemButtonEdit_ChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Xóa"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemButtonEdit_XoaDon
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        Me.GridColumn14.Width = 38
        '
        'RepositoryItemButtonEdit_XoaDon
        '
        Me.RepositoryItemButtonEdit_XoaDon.AutoHeight = False
        Me.RepositoryItemButtonEdit_XoaDon.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.RepositoryItemButtonEdit_XoaDon.Name = "RepositoryItemButtonEdit_XoaDon"
        Me.RepositoryItemButtonEdit_XoaDon.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grid_DonMau_Thang)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 315)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 153)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Đơn thuốc thang"
        Me.GroupBox2.Visible = False
        '
        'grid_DonMau_Thang
        '
        Me.grid_DonMau_Thang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_DonMau_Thang.Location = New System.Drawing.Point(3, 16)
        Me.grid_DonMau_Thang.MainView = Me.GridView2
        Me.grid_DonMau_Thang.Name = "grid_DonMau_Thang"
        Me.grid_DonMau_Thang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchLookUpEdit_MaSp_Thang, Me.RepositoryItemLookUpEdit_DVT_Thang})
        Me.grid_DonMau_Thang.Size = New System.Drawing.Size(214, 134)
        Me.grid_DonMau_Thang.TabIndex = 0
        Me.grid_DonMau_Thang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn12})
        Me.GridView2.GridControl = Me.grid_DonMau_Thang
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ID"
        Me.GridColumn3.FieldName = "ID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tên vị thuốc"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemSearchLookUpEdit_MaSp_Thang
        Me.GridColumn4.FieldName = "MaSp"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 279
        '
        'RepositoryItemSearchLookUpEdit_MaSp_Thang
        '
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang.DisplayMember = "TenSp"
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang.Name = "RepositoryItemSearchLookUpEdit_MaSp_Thang"
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang.NullText = "..."
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang.PopupView = Me.GridView4
        Me.RepositoryItemSearchLookUpEdit_MaSp_Thang.ValueMember = "MaSp"
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Số lượng"
        Me.GridColumn5.FieldName = "SoLuong"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 56
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ghi chú"
        Me.GridColumn6.FieldName = "GhiChu"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 148
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Đơn vị"
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemLookUpEdit_DVT_Thang
        Me.GridColumn12.FieldName = "MaSp"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.AllowFocus = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 46
        '
        'RepositoryItemLookUpEdit_DVT_Thang
        '
        Me.RepositoryItemLookUpEdit_DVT_Thang.AutoHeight = False
        Me.RepositoryItemLookUpEdit_DVT_Thang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_DVT_Thang.DisplayMember = "DonVT"
        Me.RepositoryItemLookUpEdit_DVT_Thang.Name = "RepositoryItemLookUpEdit_DVT_Thang"
        Me.RepositoryItemLookUpEdit_DVT_Thang.NullText = ""
        Me.RepositoryItemLookUpEdit_DVT_Thang.ValueMember = "MaSp"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.grid_DonMau_Vien)
        Me.GroupBox3.Location = New System.Drawing.Point(399, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 564)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Đơn thuốc viên"
        '
        'grid_DonMau_Vien
        '
        Me.grid_DonMau_Vien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_DonMau_Vien.Location = New System.Drawing.Point(3, 16)
        Me.grid_DonMau_Vien.MainView = Me.GridView3
        Me.grid_DonMau_Vien.Name = "grid_DonMau_Vien"
        Me.grid_DonMau_Vien.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchLookUpEdit_MaSp_Vien, Me.RepositoryItemLookUpEdit_DVT_Vien, Me.RepositoryItemButtonEdit_Xoa, Me.RepositoryItemComboBox_LieuDung})
        Me.grid_DonMau_Vien.Size = New System.Drawing.Size(631, 545)
        Me.grid_DonMau_Vien.TabIndex = 0
        Me.grid_DonMau_Vien.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn13})
        Me.GridView3.GridControl = Me.grid_DonMau_Vien
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "ID"
        Me.GridColumn7.FieldName = "ID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 41
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tên thuốc"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemSearchLookUpEdit_MaSp_Vien
        Me.GridColumn8.FieldName = "MaSp"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 246
        '
        'RepositoryItemSearchLookUpEdit_MaSp_Vien
        '
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien.DisplayMember = "TenSp"
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien.Name = "RepositoryItemSearchLookUpEdit_MaSp_Vien"
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien.NullText = "..."
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.RepositoryItemSearchLookUpEdit_MaSp_Vien.ValueMember = "MaSp"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Số lượng"
        Me.GridColumn9.FieldName = "SoLuong"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 50
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Liều dùng"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemComboBox_LieuDung
        Me.GridColumn10.FieldName = "LieuDung"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 226
        '
        'RepositoryItemComboBox_LieuDung
        '
        Me.RepositoryItemComboBox_LieuDung.AutoHeight = False
        Me.RepositoryItemComboBox_LieuDung.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_LieuDung.Name = "RepositoryItemComboBox_LieuDung"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Đơn vị"
        Me.GridColumn11.ColumnEdit = Me.RepositoryItemLookUpEdit_DVT_Vien
        Me.GridColumn11.FieldName = "MaSp"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.AllowFocus = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        Me.GridColumn11.Width = 47
        '
        'RepositoryItemLookUpEdit_DVT_Vien
        '
        Me.RepositoryItemLookUpEdit_DVT_Vien.AutoHeight = False
        Me.RepositoryItemLookUpEdit_DVT_Vien.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_DVT_Vien.DisplayMember = "DonVT"
        Me.RepositoryItemLookUpEdit_DVT_Vien.Name = "RepositoryItemLookUpEdit_DVT_Vien"
        Me.RepositoryItemLookUpEdit_DVT_Vien.NullText = ""
        Me.RepositoryItemLookUpEdit_DVT_Vien.ValueMember = "MaSp"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Xóa"
        Me.GridColumn13.ColumnEdit = Me.RepositoryItemButtonEdit_Xoa
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.FixedWidth = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 44
        '
        'RepositoryItemButtonEdit_Xoa
        '
        Me.RepositoryItemButtonEdit_Xoa.AutoHeight = False
        Me.RepositoryItemButtonEdit_Xoa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.RepositoryItemButtonEdit_Xoa.Name = "RepositoryItemButtonEdit_Xoa"
        Me.RepositoryItemButtonEdit_Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnXem
        '
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(310, 532)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(80, 23)
        Me.btnXem.TabIndex = 3
        Me.btnXem.Text = "Tải danh sách"
        '
        'txtSoDonMau
        '
        Me.txtSoDonMau.EditValue = "0"
        Me.txtSoDonMau.Location = New System.Drawing.Point(83, 530)
        Me.txtSoDonMau.Name = "txtSoDonMau"
        Me.txtSoDonMau.Size = New System.Drawing.Size(78, 20)
        Me.txtSoDonMau.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 533)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Số đơn mẫu"
        '
        'frmDonThuocMau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 563)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSoDonMau)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDonThuocMau"
        Me.Text = "DANH MỤC ĐƠN THUỐC MẪU"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grid_DonMau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit_ChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit_XoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_DonMau_Thang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit_MaSp_Thang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_DVT_Thang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grid_DonMau_Vien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit_MaSp_Vien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_LieuDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_DVT_Vien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit_Xoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoDonMau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grid_DonMau As GridControl
    Friend WithEvents GridView1 As GridView
    Friend WithEvents grid_DonMau_Thang As GridControl
    Friend WithEvents GridView2 As GridView
    Friend WithEvents grid_DonMau_Vien As GridControl
    Friend WithEvents GridView3 As GridView
    Friend WithEvents GridColumn1 As GridColumn
    Friend WithEvents GridColumn2 As GridColumn
    Friend WithEvents RepositoryItemButtonEdit_ChiTiet As RepositoryItemButtonEdit
    Friend WithEvents GridColumn3 As GridColumn
    Friend WithEvents GridColumn4 As GridColumn
    Friend WithEvents RepositoryItemSearchLookUpEdit_MaSp_Thang As RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView4 As GridView
    Friend WithEvents GridColumn5 As GridColumn
    Friend WithEvents GridColumn6 As GridColumn
    Friend WithEvents GridColumn12 As GridColumn
    Friend WithEvents GridColumn7 As GridColumn
    Friend WithEvents GridColumn8 As GridColumn
    Friend WithEvents RepositoryItemSearchLookUpEdit_MaSp_Vien As RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As GridView
    Friend WithEvents GridColumn9 As GridColumn
    Friend WithEvents GridColumn10 As GridColumn
    Friend WithEvents GridColumn11 As GridColumn
    Friend WithEvents btnXem As SimpleButton
    Friend WithEvents txtSoDonMau As TextEdit
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents RepositoryItemLookUpEdit_DVT_Thang As RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit_DVT_Vien As RepositoryItemLookUpEdit
    Friend WithEvents GridColumn13 As GridColumn
    Friend WithEvents RepositoryItemButtonEdit_Xoa As RepositoryItemButtonEdit
    Friend WithEvents GridColumn14 As GridColumn
    Friend WithEvents RepositoryItemButtonEdit_XoaDon As RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemComboBox_LieuDung As RepositoryItemComboBox
End Class
