Public Class FRM_DanhsachBN
    Inherits frmBase 'System.Windows.Forms.Form
    Private dt As New DataTable

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
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents STT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbphong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents radChoKetQua As System.Windows.Forms.RadioButton
    Friend WithEvents radChuaKham As System.Windows.Forms.RadioButton
    Friend WithEvents radTatCa As System.Windows.Forms.RadioButton
    Friend WithEvents colbtnCLS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents radDaKham As RadioButton
    Friend WithEvents Panel_Button As Panel
    Friend WithEvents Panel_Search As Panel
    Friend WithEvents btnXemCLS As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButton_XemCLS As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lb_Title As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DanhsachBN))
        Me.btnXemCLS = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.STT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbtnCLS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButton_XemCLS = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ngay = New DevExpress.XtraEditors.DateEdit()
        Me.cmbphong = New DevExpress.XtraEditors.LookUpEdit()
        Me.radChoKetQua = New System.Windows.Forms.RadioButton()
        Me.radChuaKham = New System.Windows.Forms.RadioButton()
        Me.radTatCa = New System.Windows.Forms.RadioButton()
        Me.radDaKham = New System.Windows.Forms.RadioButton()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        Me.Panel_Search = New System.Windows.Forms.Panel()
        CType(Me.btnXemCLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButton_XemCLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbphong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.Panel_Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXemCLS
        '
        Me.btnXemCLS.AutoHeight = False
        Me.btnXemCLS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Xem các CLS đã chỉ định", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnXemCLS.LookAndFeel.SkinName = "Caramel"
        Me.btnXemCLS.Name = "btnXemCLS"
        Me.btnXemCLS.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(0, 77)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButton_XemCLS})
        Me.GridControl1.Size = New System.Drawing.Size(533, 336)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.STT, Me.GridColumn2, Me.GridColumn3, Me.colbtnCLS, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'STT
        '
        Me.STT.Caption = "STT"
        Me.STT.FieldName = "STT"
        Me.STT.Name = "STT"
        Me.STT.OptionsColumn.AllowEdit = False
        Me.STT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.STT.OptionsColumn.FixedWidth = True
        Me.STT.Visible = True
        Me.STT.VisibleIndex = 0
        Me.STT.Width = 46
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Số phiếu"
        Me.GridColumn2.FieldName = "SoPhieu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 88
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Họ tên"
        Me.GridColumn3.FieldName = "HoTenBN"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "HOTEN", "Tổng bệnh nhân={0}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 212
        '
        'colbtnCLS
        '
        Me.colbtnCLS.Caption = "Xem"
        Me.colbtnCLS.ColumnEdit = Me.RepositoryItemButton_XemCLS
        Me.colbtnCLS.Name = "colbtnCLS"
        Me.colbtnCLS.OptionsColumn.FixedWidth = True
        Me.colbtnCLS.Visible = True
        Me.colbtnCLS.VisibleIndex = 5
        Me.colbtnCLS.Width = 47
        '
        'RepositoryItemButton_XemCLS
        '
        Me.RepositoryItemButton_XemCLS.AutoHeight = False
        Me.RepositoryItemButton_XemCLS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)})
        Me.RepositoryItemButton_XemCLS.Name = "RepositoryItemButton_XemCLS"
        Me.RepositoryItemButton_XemCLS.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Địa chỉ"
        Me.GridColumn4.FieldName = "DiaChiChiTiet"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 60
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Điện thoại"
        Me.GridColumn5.FieldName = "DienThoai"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 62
        '
        'Lb_Title
        '
        Me.Lb_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb_Title.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_Title.Location = New System.Drawing.Point(0, 0)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(534, 40)
        Me.Lb_Title.TabIndex = 45
        Me.Lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(447, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 46
        Me.SimpleButton1.Text = "&Tải lại"
        '
        'ngay
        '
        Me.ngay.EditValue = New Date(2015, 2, 2, 10, 27, 42, 768)
        Me.ngay.Location = New System.Drawing.Point(5, 12)
        Me.ngay.Name = "ngay"
        Me.ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ngay.Properties.Appearance.Options.UseFont = True
        Me.ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ngay.Properties.AutoHeight = False
        Me.ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.ngay.Properties.NullDate = New Date(2015, 2, 2, 10, 27, 27, 883)
        Me.ngay.Size = New System.Drawing.Size(117, 25)
        Me.ngay.TabIndex = 47
        '
        'cmbphong
        '
        Me.cmbphong.Enabled = False
        Me.cmbphong.Location = New System.Drawing.Point(128, 12)
        Me.cmbphong.Name = "cmbphong"
        Me.cmbphong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbphong.Properties.Appearance.Options.UseFont = True
        Me.cmbphong.Properties.AutoHeight = False
        Me.cmbphong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbphong.Properties.NullText = ""
        Me.cmbphong.Size = New System.Drawing.Size(268, 25)
        Me.cmbphong.TabIndex = 48
        '
        'radChoKetQua
        '
        Me.radChoKetQua.AutoSize = True
        Me.radChoKetQua.BackColor = System.Drawing.Color.Transparent
        Me.radChoKetQua.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChoKetQua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.radChoKetQua.Location = New System.Drawing.Point(123, 11)
        Me.radChoKetQua.Name = "radChoKetQua"
        Me.radChoKetQua.Size = New System.Drawing.Size(103, 20)
        Me.radChoKetQua.TabIndex = 49
        Me.radChoKetQua.Text = "Chờ kết quả"
        Me.radChoKetQua.UseVisualStyleBackColor = False
        Me.radChoKetQua.Visible = False
        '
        'radChuaKham
        '
        Me.radChuaKham.AutoSize = True
        Me.radChuaKham.BackColor = System.Drawing.Color.Transparent
        Me.radChuaKham.Checked = True
        Me.radChuaKham.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChuaKham.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.radChuaKham.Location = New System.Drawing.Point(255, 11)
        Me.radChuaKham.Name = "radChuaKham"
        Me.radChuaKham.Size = New System.Drawing.Size(97, 20)
        Me.radChuaKham.TabIndex = 50
        Me.radChuaKham.TabStop = True
        Me.radChuaKham.Text = "Chưa khám"
        Me.radChuaKham.UseVisualStyleBackColor = False
        Me.radChuaKham.Visible = False
        '
        'radTatCa
        '
        Me.radTatCa.AutoSize = True
        Me.radTatCa.BackColor = System.Drawing.Color.Transparent
        Me.radTatCa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTatCa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.radTatCa.Location = New System.Drawing.Point(381, 11)
        Me.radTatCa.Name = "radTatCa"
        Me.radTatCa.Size = New System.Drawing.Size(66, 20)
        Me.radTatCa.TabIndex = 51
        Me.radTatCa.Text = "Tất cả"
        Me.radTatCa.UseVisualStyleBackColor = False
        Me.radTatCa.Visible = False
        '
        'radDaKham
        '
        Me.radDaKham.AutoSize = True
        Me.radDaKham.BackColor = System.Drawing.Color.Transparent
        Me.radDaKham.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDaKham.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.radDaKham.Location = New System.Drawing.Point(12, 11)
        Me.radDaKham.Name = "radDaKham"
        Me.radDaKham.Size = New System.Drawing.Size(82, 20)
        Me.radDaKham.TabIndex = 52
        Me.radDaKham.Text = "Đã khám"
        Me.radDaKham.UseVisualStyleBackColor = False
        Me.radDaKham.Visible = False
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.cmbphong)
        Me.Panel_Button.Controls.Add(Me.SimpleButton1)
        Me.Panel_Button.Controls.Add(Me.ngay)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 419)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(534, 49)
        Me.Panel_Button.TabIndex = 53
        '
        'Panel_Search
        '
        Me.Panel_Search.Controls.Add(Me.radDaKham)
        Me.Panel_Search.Controls.Add(Me.radChoKetQua)
        Me.Panel_Search.Controls.Add(Me.radChuaKham)
        Me.Panel_Search.Controls.Add(Me.radTatCa)
        Me.Panel_Search.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Search.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Search.Name = "Panel_Search"
        Me.Panel_Search.Size = New System.Drawing.Size(534, 39)
        Me.Panel_Search.TabIndex = 54
        '
        'FRM_DanhsachBN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 468)
        Me.Controls.Add(Me.Panel_Search)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Lb_Title)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_DanhsachBN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        CType(Me.btnXemCLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButton_XemCLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbphong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.Panel_Search.ResumeLayout(False)
        Me.Panel_Search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public LoaiDV As Int16
    Public Phong As String = ""

    Private Sub FRM_DanhsachBN_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Load_Data_dv()
        'SimpleButton1_Click(sender, e)
    End Sub

    Private Sub FRM_DanhsachBN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        ngay.DateTime = NgayGioServer()
        Load_ComboBox("Select MaPhong,TenPhong from Phong_Ban Where Loai in (1,5)", cmbphong, CNNQLPHONGKHAM)
        'Phong mac dinh
        Dim dtphong As New DataTable
        dtphong = BusinessLogic.Data.GetDataset("Select Top 1 Maphong From Nguoi_Su_Dung Where username=N'" & clsLoginObj.strUsername & "'").Tables(0)
        If dtphong.Rows.Count > 0 Then
            cmbphong.EditValue = dtphong.Rows(0)(0)
        End If
        Load_Data_dv()
        Panel_Search.Enabled = True
        Panel_Button.Enabled = True
    End Sub

    Private Sub Load_Data_dv()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim strSql As String = ""
        'KHAM BENH
        If LoaiDV = Short.Parse(MdlCommon.LoaiDV.KHAMBENH) Then
            Me.Lb_Title.Text = "BỆNH NHÂN CHỜ KHÁM BỆNH"
            strSql = String.Format("SELECT p.SoPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,p.LoaiPhieu as LoaiDV,p.Sophieu as IDsophieu,'' AS NhomXetNghiem FROM PHIEUKHAMBENH p JOIN HOSOBN h ON p.MABN = h.MABN ")
            strSql &= String.Format("WHERE p.Phongkham= N'{0}' and Isnull(p.huy,0)=0 AND convert(char(12),p.ngaylap,101)='{1}' and Isnull(p.thutien,0) in (0,1) ", cmbphong.EditValue, ngay.DateTime.ToString("MM/dd/yyyy"))
            If Me.radChuaKham.Checked Then
                strSql &= String.Format("AND p.khamxong = 0 ")
            ElseIf Me.radChoKetQua.Checked Then
                strSql &= String.Format("AND p.khamxong=1 ")
            ElseIf Me.radDaKham.Checked Then
                strSql &= String.Format("AND p.khamxong = 2 ")
            End If
            strSql &= String.Format("Group by p.SoPhieu,p.LoaiPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai")
        End If
        'XET NGHIEM
        If LoaiDV = Short.Parse(MdlCommon.LoaiDV.XETNGHIEM) Then
            Me.Lb_Title.Text = "BỆNH NHÂN CHỜ XÉT NGHIỆM"
            strSql = String.Format("SELECT c.RefNo as SoPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu FROM Chi_tiet_NEW c INNER JOIN HOSOBN h ON c.MABN = h.MABN ")
            strSql &= String.Format("WHERE LoaiDV={0} And Trangthai=0 And Isnull(c.Huy,0)=0 And (Convert(char(12),c.datelap,101)='{1}' OR Datediff(d,c.tungay,'{2}')=0) And Isnull(c.thutien,0) In (0,1) ", Integer.Parse(NhomDV.XETNGHIEM), ngay.DateTime.ToString("MM/dd/yyyy"), ngay.DateTime.ToString("MM/dd/yyyy"))
            strSql &= String.Format("Group by c.RefNo,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu Order by c.RefNo")
        End If
        'SIEU AM
        If LoaiDV = Short.Parse(MdlCommon.LoaiDV.SIEUAM) Then
            Me.Lb_Title.Text = "BỆNH NHÂN CHỜ SIÊU ÂM"
            strSql = String.Format("SELECT c.RefNo as SoPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu FROM Chi_tiet_NEW c INNER JOIN HOSOBN h ON c.MABN = h.MABN ")
            strSql &= String.Format("WHERE LoaiDV={0} And Trangthai=0 And Isnull(c.Huy,0)=0 And (Convert(char(12),c.datelap,101)='{1}' OR Datediff(d,c.tungay,'{2}')=0) And Isnull(c.thutien,0) In (0,1) ", Integer.Parse(NhomDV.SIEUAM), ngay.DateTime.ToString("MM/dd/yyyy"), ngay.DateTime.ToString("MM/dd/yyyy"))
            strSql &= String.Format("Group by c.RefNo,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu Order by c.RefNo")
        End If
        'NOI SOI
        If LoaiDV = Short.Parse(MdlCommon.LoaiDV.NOISOI) Then
            Me.Lb_Title.Text = "BỆNH NHÂN CHỜ NỘI SOI"
            strSql = String.Format("SELECT c.RefNo as SoPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu FROM Chi_tiet_NEW c INNER JOIN HOSOBN h ON c.MABN = h.MABN ")
            strSql &= String.Format("WHERE LoaiDV={0} And Trangthai=0 And Isnull(c.Huy,0)=0 And (Convert(char(12),c.datelap,101)='{1}' OR Datediff(d,c.tungay,'{2}')=0) And Isnull(c.thutien,0) in (0,1) ", Integer.Parse(NhomDV.NOISOI), ngay.DateTime.ToString("MM/dd/yyyy"), ngay.DateTime.ToString("MM/dd/yyyy"))
            strSql &= String.Format("Group by c.RefNo,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu Order by c.RefNo")
        End If
        'X QUANG
        If LoaiDV = Short.Parse(MdlCommon.LoaiDV.XQUANG) Then
            Me.Lb_Title.Text = "BỆNH NHÂN CHỜ CHỤP XQUANG - CT"
            strSql = String.Format("SELECT c.RefNo as SoPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu FROM Chi_tiet_NEW c INNER JOIN HOSOBN h ON c.MABN = h.MABN ")
            strSql &= String.Format("WHERE LoaiDV={0} And Trangthai=0 And Isnull(c.Huy,0)=0 And (Convert(char(12),c.datelap,101)='{1}' OR Datediff(d,c.tungay,'{2}')=0) And Isnull(c.thutien,0) in (0,1) ", Integer.Parse(NhomDV.XQUANG), ngay.DateTime.ToString("MM/dd/yyyy"), ngay.DateTime.ToString("MM/dd/yyyy"))
            strSql &= String.Format("Group by c.RefNo,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu Order by c.RefNo")
        End If
        'DIEN TIM
        If LoaiDV = Short.Parse(MdlCommon.LoaiDV.DIENTIM) Then
            Me.Lb_Title.Text = "BỆNH NHÂN CHỜ ĐIỆN TIM"
            strSql = String.Format("SELECT c.RefNo as SoPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu FROM Chi_tiet_NEW c INNER JOIN HOSOBN h ON c.MABN = h.MABN ")
            strSql &= String.Format("WHERE LoaiDV={0} And Trangthai=0 And Isnull(c.Huy,0)=0 And (Convert(char(12),c.datelap,101)='{1}' OR Datediff(d,c.tungay,'{2}')=0) And Isnull(c.thutien,0) in (0,1) ", Integer.Parse(NhomDV.DIENTIM), ngay.DateTime.ToString("MM/dd/yyyy"), ngay.DateTime.ToString("MM/dd/yyyy"))
            strSql &= String.Format("Group by c.RefNo,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu Order by c.RefNo")
        End If
        'TTPT
        If LoaiDV = Short.Parse(MdlCommon.LoaiDV.THUTHUAT) Then
            Me.Lb_Title.Text = "BỆNH NHÂN CHỜ THỦ THUẬT"
            strSql = String.Format("SELECT c.RefNo as SoPhieu,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu FROM Chi_tiet_NEW c INNER JOIN HOSOBN h ON c.MABN = h.MABN ")
            strSql &= String.Format("WHERE LoaiDV={0} And Trangthai=0 And Isnull(c.Huy,0)=0 And (Convert(char(12),c.datelap,101)='{1}' OR Datediff(d,c.tungay,'{2}')=0) And Isnull(c.thutien,0) in (0,1) ", Integer.Parse(NhomDV.TTPT), ngay.DateTime.ToString("MM/dd/yyyy"), ngay.DateTime.ToString("MM/dd/yyyy"))
            strSql &= String.Format("Group by c.RefNo,h.HoTenBN,h.DiaChiChiTiet,h.DienThoai,c.LoaiDV,c.IDsophieu Order by c.RefNo")
        End If
        dt.Clear()
        dt = BusinessLogic.Data.GetDataset(strSql).Tables(0)
        dt.Columns.Add("STT")
        For j As Int16 = 0 To dt.Rows.Count - 1
            dt.Rows(j).Item("STT") = j + 1
        Next
        Me.GridControl1.DataSource = dt
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle >= 0 Then
                If LoaiDV = Short.Parse(MdlCommon.LoaiDV.KHAMBENH) Then
                    Dim frm As New FRM_PhieuKham
                    frm.xemphieu = True
                    frm.IDPhieukham = dr("SoPhieu")
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.ShowDialog()
                    If frm.isCloseForm Then
                        Load_Data_dv()
                        Me.RemoveOwnedForm(frm)
                    End If
                Else
                    Dim frm As New FRM_KECANLAMSANG
                    frm.IDSophieu = dr("SoPhieu")
                    frm.IDPhieuxuat = dr("IDsophieu")
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.XETNGHIEM) Then
                        frm.Text = "KẾT QUẢ XÉT NGHIỆM"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.XETNGHIEM).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.XETNGHIEM).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.SIEUAM) Then
                        frm.Text = "KẾT QUẢ SIÊU ÂM"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.SIEUAM).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.SIEUAM).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.NOISOI) Then
                        frm.Text = "KẾT QUẢ NỘI SOI"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.NOISOI).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.NOISOI).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.XQUANG) Then
                        frm.Text = "KẾT QUẢ XQUANG"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.XQUANG).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.XQUANG).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.DIENTIM) Then
                        frm.Text = "KẾT QUẢ ĐIỆN TIM"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.DIENTIM).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.DIENTIM).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.THUTHUAT) Then
                        frm.Text = "KẾT QUẢ THỦ THUẬT - PHẨU THUẬT"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.TTPT).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.THUTHUAT).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.PHAUTHUAT) Then
                        frm.Text = "KẾT QUẢ PHẨU THUẬT"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.TTPT).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.PHAUTHUAT).ToString()
                    End If
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.ShowDialog()
                    If frm.isCloseForm Then
                        Load_Data_dv()
                        Me.RemoveOwnedForm(frm)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Load_Data_dv()
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radChuaKham.Click
        Load_Data_dv()
    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radTatCa.Click
        Load_Data_dv()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radChoKetQua.Click
        Load_Data_dv()
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles radDaKham.Click
        Load_Data_dv()
    End Sub

    Private Sub btnXemCLS_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButton_XemCLS.ButtonClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle >= 0 Then
                If LoaiDV = Short.Parse(MdlCommon.LoaiDV.KHAMBENH) Then
                    Dim frm As New FRM_PhieuKham
                    frm.xemphieu = True
                    frm.IDPhieukham = dr("SoPhieu")
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.ShowDialog()
                    If frm.isCloseForm Then
                        Load_Data_dv()
                        Me.RemoveOwnedForm(frm)
                    End If
                Else
                    Dim frm As New FRM_KECANLAMSANG
                    frm.IDSophieu = dr("SoPhieu")
                    frm.IDPhieuxuat = dr("IDsophieu")
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.XETNGHIEM) Then
                        frm.Text = "KẾT QUẢ XÉT NGHIỆM"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.XETNGHIEM).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.XETNGHIEM).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.SIEUAM) Then
                        frm.Text = "KẾT QUẢ SIÊU ÂM"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.SIEUAM).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.SIEUAM).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.NOISOI) Then
                        frm.Text = "KẾT QUẢ NỘI SOI"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.NOISOI).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.NOISOI).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.XQUANG) Then
                        frm.Text = "KẾT QUẢ XQUANG"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.XQUANG).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.XQUANG).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.DIENTIM) Then
                        frm.Text = "KẾT QUẢ ĐIỆN TIM"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.DIENTIM).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.DIENTIM).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.THUTHUAT) Then
                        frm.Text = "KẾT QUẢ THỦ THUẬT - PHẨU THUẬT"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.TTPT).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.THUTHUAT).ToString()
                    End If
                    If LoaiDV = Short.Parse(MdlCommon.LoaiDV.PHAUTHUAT) Then
                        frm.Text = "KẾT QUẢ PHẨU THUẬT"
                        frm.loai = Integer.Parse(MdlCommon.NhomDV.TTPT).ToString()
                        frm.type = Integer.Parse(MdlCommon.LoaiDV.PHAUTHUAT).ToString()
                    End If
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.ShowDialog()
                    If frm.isCloseForm Then
                        Load_Data_dv()
                        Me.RemoveOwnedForm(frm)
                    End If
                End If
            End If
        End If
    End Sub

End Class
