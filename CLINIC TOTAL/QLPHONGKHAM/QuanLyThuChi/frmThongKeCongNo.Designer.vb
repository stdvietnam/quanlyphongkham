Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThongKeCongNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKeCongNo))
        Me.grdDanhSach = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit_LapPhieuThu = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDonvitc = New System.Windows.Forms.Label()
        Me.cmbMabn = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTongTien = New DevExpress.XtraEditors.TextEdit()
        Me.txtThucThu = New DevExpress.XtraEditors.TextEdit()
        Me.txtCongNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtThucChi = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel_TongTien = New System.Windows.Forms.Panel()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit_LapPhieuThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMabn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThucThu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCongNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThucChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_TongTien.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDanhSach
        '
        Me.grdDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach.Location = New System.Drawing.Point(0, 111)
        Me.grdDanhSach.MainView = Me.GridView1
        Me.grdDanhSach.Name = "grdDanhSach"
        Me.grdDanhSach.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit_LapPhieuThu})
        Me.grdDanhSach.Size = New System.Drawing.Size(911, 395)
        Me.grdDanhSach.TabIndex = 0
        Me.grdDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView1.GridControl = Me.grdDanhSach
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "STT"
        Me.GridColumn1.FieldName = "Stt"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 38
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mã KH"
        Me.GridColumn2.FieldName = "MaBN"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 83
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Địa chỉ"
        Me.GridColumn3.FieldName = "DiaChiChiTiet"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 130
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Điện thoại"
        Me.GridColumn4.FieldName = "DienThoai"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 83
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tổng tiền"
        Me.GridColumn5.DisplayFormat.FormatString = "###,###"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "TongTien"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 76
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tổng thực thu"
        Me.GridColumn6.DisplayFormat.FormatString = "###,###"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "TongThucThu"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 101
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tổng thực chi"
        Me.GridColumn7.DisplayFormat.FormatString = "###,###"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "TongThucChi"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 84
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Nợ"
        Me.GridColumn8.DisplayFormat.FormatString = "###,###"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "CongNo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 77
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tên KH"
        Me.GridColumn9.FieldName = "HoTenBN"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 171
        '
        'GridColumn10
        '
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemButtonEdit_LapPhieuThu
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 48
        '
        'RepositoryItemButtonEdit_LapPhieuThu
        '
        Me.RepositoryItemButtonEdit_LapPhieuThu.AutoHeight = False
        Me.RepositoryItemButtonEdit_LapPhieuThu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.RepositoryItemButtonEdit_LapPhieuThu.Name = "RepositoryItemButtonEdit_LapPhieuThu"
        Me.RepositoryItemButtonEdit_LapPhieuThu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(776, 21)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 22
        Me.btnThoat.Text = "Thoát"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(678, 21)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 21
        Me.btnIn.Text = "In TK"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(580, 21)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 20
        Me.btnXem.Text = "Xem"
        '
        'lblDonvitc
        '
        Me.lblDonvitc.AutoSize = True
        Me.lblDonvitc.BackColor = System.Drawing.Color.Transparent
        Me.lblDonvitc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonvitc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDonvitc.Location = New System.Drawing.Point(46, 25)
        Me.lblDonvitc.Name = "lblDonvitc"
        Me.lblDonvitc.Size = New System.Drawing.Size(74, 16)
        Me.lblDonvitc.TabIndex = 14
        Me.lblDonvitc.Text = "Khách hàng"
        '
        'cmbMabn
        '
        Me.cmbMabn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbMabn.Location = New System.Drawing.Point(131, 24)
        Me.cmbMabn.Name = "cmbMabn"
        Me.cmbMabn.Properties.AutoHeight = False
        Me.cmbMabn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMabn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbMabn.Properties.NullText = ""
        Me.cmbMabn.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.cmbMabn.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cmbMabn.Size = New System.Drawing.Size(302, 20)
        Me.cmbMabn.TabIndex = 15
        Me.cmbMabn.Tag = "Madv"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 700
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Mã BN"
        Me.GridColumn11.FieldName = "MaBN"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 89
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Họ tên BN"
        Me.GridColumn12.FieldName = "HoTenBN"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 107
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Địa chỉ"
        Me.GridColumn13.FieldName = "DiaChiChiTiet"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        Me.GridColumn13.Width = 89
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Điện thoại"
        Me.GridColumn14.FieldName = "DienThoai"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        Me.GridColumn14.Width = 79
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Số hồ sơ"
        Me.GridColumn15.FieldName = "SoHoSo"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 4
        Me.GridColumn15.Width = 80
        '
        'txtTongTien
        '
        Me.txtTongTien.EditValue = "0"
        Me.txtTongTien.Location = New System.Drawing.Point(128, 10)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTongTien.Properties.Appearance.Options.UseBackColor = True
        Me.txtTongTien.Properties.DisplayFormat.FormatString = "###,###,###"
        Me.txtTongTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTongTien.Properties.Mask.EditMask = "n0"
        Me.txtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTien.Size = New System.Drawing.Size(123, 20)
        Me.txtTongTien.TabIndex = 20
        '
        'txtThucThu
        '
        Me.txtThucThu.EditValue = "0"
        Me.txtThucThu.Location = New System.Drawing.Point(323, 10)
        Me.txtThucThu.Name = "txtThucThu"
        Me.txtThucThu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtThucThu.Properties.Appearance.Options.UseBackColor = True
        Me.txtThucThu.Properties.DisplayFormat.FormatString = "###,###,###"
        Me.txtThucThu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtThucThu.Properties.Mask.EditMask = "n0"
        Me.txtThucThu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtThucThu.Size = New System.Drawing.Size(123, 20)
        Me.txtThucThu.TabIndex = 20
        '
        'txtCongNo
        '
        Me.txtCongNo.EditValue = "0"
        Me.txtCongNo.Location = New System.Drawing.Point(710, 10)
        Me.txtCongNo.Name = "txtCongNo"
        Me.txtCongNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCongNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtCongNo.Properties.DisplayFormat.FormatString = "###,###,###"
        Me.txtCongNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCongNo.Properties.Mask.EditMask = "n0"
        Me.txtCongNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCongNo.Size = New System.Drawing.Size(123, 20)
        Me.txtCongNo.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(59, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Tổng tiền"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(257, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Thực thu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(648, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Công nợ"
        '
        'txtThucChi
        '
        Me.txtThucChi.EditValue = "0"
        Me.txtThucChi.Location = New System.Drawing.Point(515, 10)
        Me.txtThucChi.Name = "txtThucChi"
        Me.txtThucChi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtThucChi.Properties.Appearance.Options.UseBackColor = True
        Me.txtThucChi.Properties.DisplayFormat.FormatString = "###,###,###"
        Me.txtThucChi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtThucChi.Properties.Mask.EditMask = "n0"
        Me.txtThucChi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtThucChi.Size = New System.Drawing.Size(123, 20)
        Me.txtThucChi.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(451, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Thực chi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMabn)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnIn)
        Me.GroupBox1.Controls.Add(Me.lblDonvitc)
        Me.GroupBox1.Controls.Add(Me.btnXem)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 63)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tìm kiếm"
        '
        'Panel_TongTien
        '
        Me.Panel_TongTien.Controls.Add(Me.txtCongNo)
        Me.Panel_TongTien.Controls.Add(Me.txtThucChi)
        Me.Panel_TongTien.Controls.Add(Me.Label1)
        Me.Panel_TongTien.Controls.Add(Me.txtThucThu)
        Me.Panel_TongTien.Controls.Add(Me.txtTongTien)
        Me.Panel_TongTien.Controls.Add(Me.Label5)
        Me.Panel_TongTien.Controls.Add(Me.Label3)
        Me.Panel_TongTien.Controls.Add(Me.Label4)
        Me.Panel_TongTien.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TongTien.Location = New System.Drawing.Point(0, 63)
        Me.Panel_TongTien.Name = "Panel_TongTien"
        Me.Panel_TongTien.Size = New System.Drawing.Size(911, 42)
        Me.Panel_TongTien.TabIndex = 25
        '
        'frmThongKeCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(911, 507)
        Me.Controls.Add(Me.Panel_TongTien)
        Me.Controls.Add(Me.grdDanhSach)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThongKeCongNo"
        Me.Text = "THỐNG KÊ CÔNG NỢ"
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit_LapPhieuThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMabn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThucThu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCongNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThucChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_TongTien.ResumeLayout(False)
        Me.Panel_TongTien.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblDonvitc As Label
    Friend WithEvents txtTongTien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtThucThu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCongNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnThoat As SimpleButton
    Friend WithEvents btnIn As SimpleButton
    Friend WithEvents btnXem As SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtThucChi As TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMabn As SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit_LapPhieuThu As Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel_TongTien As Panel
End Class
