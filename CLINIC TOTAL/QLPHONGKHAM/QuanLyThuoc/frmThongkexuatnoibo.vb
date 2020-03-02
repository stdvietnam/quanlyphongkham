Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Public Class frmThongkexuatnoibo
    Inherits frmBase 'System.Windows.Forms.Form
    Private dtb As New DataTable
    Private dtb1 As New DataTable
    Private strSQL As String
    Private Tienhang As Double
    Private VAT As Double
    Private Tongso As Double
    Private k As Int16
    Friend WithEvents colphong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbphong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private foundClick As Boolean = True
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
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents grbDieu_kien As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbKho_hang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents Radio1 As System.Windows.Forms.RadioButton
    Friend WithEvents SimpleButton_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupHuy As System.Windows.Forms.GroupBox
    Friend WithEvents RadioHuy1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHuy2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHuy3 As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongkexuatnoibo))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.grbDieu_kien = New System.Windows.Forms.GroupBox()
        Me.cmbphong = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupHuy = New System.Windows.Forms.GroupBox()
        Me.RadioHuy3 = New System.Windows.Forms.RadioButton()
        Me.RadioHuy2 = New System.Windows.Forms.RadioButton()
        Me.RadioHuy1 = New System.Windows.Forms.RadioButton()
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.Radio1 = New System.Windows.Forms.RadioButton()
        Me.cmbKho_hang = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdDetail = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDieu_kien.SuspendLayout()
        CType(Me.cmbphong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupHuy.SuspendLayout()
        Me.Group.SuspendLayout()
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'grbDieu_kien
        '
        Me.grbDieu_kien.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grbDieu_kien.Controls.Add(Me.cmbphong)
        Me.grbDieu_kien.Controls.Add(Me.Label1)
        Me.grbDieu_kien.Controls.Add(Me.GroupHuy)
        Me.grbDieu_kien.Controls.Add(Me.Group)
        Me.grbDieu_kien.Controls.Add(Me.cmbKho_hang)
        Me.grbDieu_kien.Controls.Add(Me.Label4)
        Me.grbDieu_kien.Controls.Add(Me.Label3)
        Me.grbDieu_kien.Controls.Add(Me.dtpTu_ngay)
        Me.grbDieu_kien.Controls.Add(Me.dtpDen_ngay)
        Me.grbDieu_kien.Controls.Add(Me.Label5)
        Me.grbDieu_kien.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDieu_kien.ForeColor = System.Drawing.Color.Red
        Me.grbDieu_kien.Location = New System.Drawing.Point(3, 1)
        Me.grbDieu_kien.Name = "grbDieu_kien"
        Me.grbDieu_kien.Size = New System.Drawing.Size(826, 101)
        Me.grbDieu_kien.TabIndex = 0
        Me.grbDieu_kien.TabStop = False
        Me.grbDieu_kien.Text = "Điều kiện thông kê"
        '
        'cmbphong
        '
        Me.cmbphong.Location = New System.Drawing.Point(529, 53)
        Me.cmbphong.Name = "cmbphong"
        Me.cmbphong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmbphong.Properties.Appearance.Options.UseFont = True
        Me.cmbphong.Properties.AutoHeight = False
        Me.cmbphong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbphong.Properties.NullText = ""
        Me.cmbphong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbphong.Size = New System.Drawing.Size(264, 22)
        Me.cmbphong.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(458, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "phòng:"
        '
        'GroupHuy
        '
        Me.GroupHuy.Controls.Add(Me.RadioHuy3)
        Me.GroupHuy.Controls.Add(Me.RadioHuy2)
        Me.GroupHuy.Controls.Add(Me.RadioHuy1)
        Me.GroupHuy.Location = New System.Drawing.Point(202, 16)
        Me.GroupHuy.Name = "GroupHuy"
        Me.GroupHuy.Size = New System.Drawing.Size(219, 42)
        Me.GroupHuy.TabIndex = 20
        Me.GroupHuy.TabStop = False
        '
        'RadioHuy3
        '
        Me.RadioHuy3.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioHuy3.Location = New System.Drawing.Point(157, 13)
        Me.RadioHuy3.Name = "RadioHuy3"
        Me.RadioHuy3.Size = New System.Drawing.Size(56, 21)
        Me.RadioHuy3.TabIndex = 16
        Me.RadioHuy3.Text = "Huỷ"
        Me.RadioHuy3.UseVisualStyleBackColor = False
        '
        'RadioHuy2
        '
        Me.RadioHuy2.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy2.Checked = True
        Me.RadioHuy2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioHuy2.Location = New System.Drawing.Point(68, 13)
        Me.RadioHuy2.Name = "RadioHuy2"
        Me.RadioHuy2.Size = New System.Drawing.Size(72, 21)
        Me.RadioHuy2.TabIndex = 15
        Me.RadioHuy2.TabStop = True
        Me.RadioHuy2.Text = "Kh huỷ"
        Me.RadioHuy2.UseVisualStyleBackColor = False
        '
        'RadioHuy1
        '
        Me.RadioHuy1.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioHuy1.Location = New System.Drawing.Point(8, 13)
        Me.RadioHuy1.Name = "RadioHuy1"
        Me.RadioHuy1.Size = New System.Drawing.Size(40, 21)
        Me.RadioHuy1.TabIndex = 14
        Me.RadioHuy1.Text = "All"
        Me.RadioHuy1.UseVisualStyleBackColor = False
        '
        'Group
        '
        Me.Group.Controls.Add(Me.Radio1)
        Me.Group.Location = New System.Drawing.Point(86, 16)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(110, 42)
        Me.Group.TabIndex = 19
        Me.Group.TabStop = False
        '
        'Radio1
        '
        Me.Radio1.BackColor = System.Drawing.Color.Transparent
        Me.Radio1.Checked = True
        Me.Radio1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Radio1.Location = New System.Drawing.Point(6, 15)
        Me.Radio1.Name = "Radio1"
        Me.Radio1.Size = New System.Drawing.Size(104, 21)
        Me.Radio1.TabIndex = 12
        Me.Radio1.TabStop = True
        Me.Radio1.Text = "Xuất nội bộ"
        Me.Radio1.UseVisualStyleBackColor = False
        '
        'cmbKho_hang
        '
        Me.cmbKho_hang.Location = New System.Drawing.Point(529, 25)
        Me.cmbKho_hang.Name = "cmbKho_hang"
        Me.cmbKho_hang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmbKho_hang.Properties.Appearance.Options.UseFont = True
        Me.cmbKho_hang.Properties.AutoHeight = False
        Me.cmbKho_hang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKho_hang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã kho"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho")})
        Me.cmbKho_hang.Properties.NullText = ""
        Me.cmbKho_hang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbKho_hang.Size = New System.Drawing.Size(264, 22)
        Me.cmbKho_hang.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(230, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Đến ngày:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Từ ngày:"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(86, 64)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
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
        Me.dtpTu_ngay.Size = New System.Drawing.Size(122, 22)
        Me.dtpTu_ngay.TabIndex = 0
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(298, 64)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
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
        Me.dtpDen_ngay.Size = New System.Drawing.Size(122, 22)
        Me.dtpDen_ngay.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(456, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kho xuất:"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(537, 114)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 9
        Me.btnXem.Text = "&Xem"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(632, 114)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 10
        Me.btnIn.Text = "&In TK"
        '
        'SimpleButton_Close
        '
        Me.SimpleButton_Close.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton_Close.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton_Close.Appearance.Options.UseFont = True
        Me.SimpleButton_Close.Appearance.Options.UseForeColor = True
        Me.SimpleButton_Close.Location = New System.Drawing.Point(727, 114)
        Me.SimpleButton_Close.Name = "SimpleButton_Close"
        Me.SimpleButton_Close.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton_Close.TabIndex = 11
        Me.SimpleButton_Close.Text = "&Thoát"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'grdDetail
        '
        Me.grdDetail.Location = New System.Drawing.Point(3, 159)
        Me.grdDetail.MainView = Me.GridView1
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.Size = New System.Drawing.Size(826, 398)
        Me.grdDetail.TabIndex = 2
        Me.grdDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn5, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.colphong})
        Me.GridView1.GridControl = Me.grdDetail
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ngày"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Ngay"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 119
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số HĐ"
        Me.GridColumn1.FieldName = "Sophieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 121
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nhân viên XN"
        Me.GridColumn5.FieldName = "hoten"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 204
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Huỷ"
        Me.GridColumn10.FieldName = "Huy"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 5
        Me.GridColumn10.Width = 65
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Phiếu X/N"
        Me.GridColumn11.FieldName = "LoaiPhieu"
        Me.GridColumn11.MinWidth = 10
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 116
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "IDPhieuXN"
        Me.GridColumn12.FieldName = "IDPhieuXN"
        Me.GridColumn12.MinWidth = 10
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 6
        Me.GridColumn12.Width = 146
        '
        'colphong
        '
        Me.colphong.Caption = "Phòng"
        Me.colphong.FieldName = "tenphong"
        Me.colphong.Name = "colphong"
        Me.colphong.OptionsColumn.AllowEdit = False
        Me.colphong.OptionsColumn.AllowFocus = False
        Me.colphong.Visible = True
        Me.colphong.VisibleIndex = 4
        Me.colphong.Width = 96
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(12, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(255, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Kích đúp vào bản ghi để xem chi tiết phiếu"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(16, 466)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(608, 14)
        Me.ProgressBarControl1.TabIndex = 13
        Me.ProgressBarControl1.Visible = False
        '
        'frmThongkexuatnoibo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 558)
        Me.Controls.Add(Me.grdDetail)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.grbDieu_kien)
        Me.Controls.Add(Me.SimpleButton_Close)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.btnIn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(845, 597)
        Me.Name = "frmThongkexuatnoibo"
        Me.Text = "THỐNG KÊ PHIẾU XUẤT VTTH"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDieu_kien.ResumeLayout(False)
        Me.grbDieu_kien.PerformLayout()
        CType(Me.cmbphong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupHuy.ResumeLayout(False)
        Me.Group.ResumeLayout(False)
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmThongkeXN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim grdcolLoai_phieu As New DataGridBoolColumn
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang order by TenKho", Me.cmbKho_hang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT maphong,tenphong From phong_ban where loai not in(1,8)", Me.cmbphong, CNNQLPHONGKHAM)
        grdcolLoai_phieu.HeaderText = "Huỷ"
        cmbKho_hang.EditValue = "KT"
        Me.dtpTu_ngay.DateTime = NgayGioServer().Date
        Me.dtpDen_ngay.DateTime = NgayGioServer().Date
        LoadData()
    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Xetngay()
        LoadData()
    End Sub

    Private Sub LoadData()
        Me.ErrPro.Dispose()
        strSQL = "Select Case When Phieu_Xuat_Nhap.Loaiphieu = 0 then 'X'+ Right('000000'+ cast(Phieu_Xuat_Nhap.Sophieu as nvarchar),6) else 'N'+ Right('000000'+ cast(Phieu_Xuat_Nhap.Sophieu as nvarchar),6) end as Sophieu,Phieu_Xuat_Nhap.Ngay,Phieu_Xuat_Nhap.MaXN,Nguoi_su_dung.hoten ,phong_ban.tenphong,Phieu_Xuat_Nhap.Huy,Phieu_Xuat_Nhap.IDPhieuXn,Phieu_Xuat_Nhap.LoaiPhieu from Phieu_Xuat_Nhap INNER JOIN phong_ban ON (Phieu_Xuat_Nhap.maphong = phong_ban.Maphong) INNER JOIN nguoi_su_dung  ON nguoi_su_dung.Username = Phieu_Xuat_Nhap.nguoinhap where Loaiphieu = 0 AND maxn='XNB' and "
        If Me.RadioHuy2.Checked = True Then
            strSQL = strSQL & "Huy = 0 AND "
        ElseIf Me.RadioHuy3.Checked = True Then
            strSQL = strSQL & "Huy = 1 AND "
        End If
        If Me.cmbKho_hang.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Makho", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbKho_hang.EditValue, "", strSQL)
        End If

        If Me.dtpTu_ngay.Text <> "" And Me.dtpDen_ngay.Text <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Ngay", MdlCommon.Kieukitu.Ngaythang, "BETWEEN", "AND", Me.dtpTu_ngay.DateTime, Me.dtpDen_ngay.DateTime, strSQL)
        End If

        If Me.cmbphong.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.maphong", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbphong.EditValue, "", strSQL)
        End If

        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If

        dtb = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        Me.grdDetail.DataSource = dtb
        Me.GridView1.ExpandAllGroups()

    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Xetngay()
        LoadData()
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.ThongKeXN_donthuoc
        frm.Tngay = Me.dtpTu_ngay.DateTime.Date
        frm.Dngay = Me.dtpDen_ngay.DateTime.Date
        frm.TongSo = Tongso
        frm.TongSP = k
        frm.Title = "THỐNG KÊ PHIẾU XUẤT THUỐC"
        frm.dtb = dtb
        frm.Show()
        'Application.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
    End Sub
    Private Sub grdDetail_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDetail.DoubleClick
        Dim frm As New frmPhieuxuatnoibo
        frm.blnType = False
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        frm.StartPosition = FormStartPosition.CenterScreen
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr.IsNew = False Then
                    frm.IDPhieuxuat &= dr("IDPhieuXN") & ","
                    If dr("Huy") = True Then
                        frm.blnDelete = True
                    End If
                End If
            End If
        End If
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()

    End Sub
    Private Sub SimpleButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton_Close.Click
        Me.Close()
    End Sub

    Private Sub Radio1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio1.CheckedChanged
        If Me.Radio1.Checked = True Then
            LoadData()
        End If
    End Sub

    Private Sub RadioHuy1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioHuy1.CheckedChanged
        If Me.RadioHuy1.Checked = True Then
            LoadData()
        End If
    End Sub
    Private Sub RadioHuy2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioHuy2.CheckedChanged
        If Me.RadioHuy2.Checked = True Then
            LoadData()
        End If
    End Sub
    Private Sub RadioHuy3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioHuy3.CheckedChanged
        If Me.RadioHuy3.Checked = True Then
            LoadData()
        End If
    End Sub
   
    Private Sub cmbKho_hang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKho_hang.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbKho_hang.EditValue = ""
        End If
    End Sub
    
    Private Sub dtpDen_ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDen_ngay.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.dtpDen_ngay.EditValue = ""
        End If
    End Sub

    Private Sub dtpTu_ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTu_ngay.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.dtpTu_ngay.EditValue = ""
        End If
    End Sub
    Private Sub dtpTu_ngay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTu_ngay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.dtpDen_ngay.Focus()
            Xetngay()
            LoadData()
        End If
    End Sub
    Private Sub dtpDen_ngay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDen_ngay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.cmbKho_hang.Focus()
            Xetngay()
            LoadData()
        End If
    End Sub
    Private Sub cmbKho_hang_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKho_hang.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            LoadData()

        End If
    End Sub
    
    Private Sub Xetngay()
        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dtb = Load_DataTable("select * from ket_chuyen", CNNQLPHONGKHAM)
        ngayketchuyen = dtb.Rows(0)("ngayketchuyen")
        If Me.dtpTu_ngay.Text = "" Then
            Me.dtpTu_ngay.DateTime = ngayketchuyen.Date
        End If
        If Me.dtpDen_ngay.Text = "" Then
            Me.dtpDen_ngay.DateTime = Today.Date.Date
        End If
        If Me.dtpTu_ngay.DateTime.Date > Me.dtpDen_ngay.DateTime.Date Then
            MsgBox("Từ ngày không thể lớn hơn đến ngày!")
        End If
    End Sub
   
End Class
