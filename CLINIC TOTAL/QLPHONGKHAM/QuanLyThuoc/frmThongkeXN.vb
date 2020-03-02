Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Public Class frmThongkeXN
    Inherits frmBase 'System.Windows.Forms.Form
    Private dtb As New DataTable
    Private dtb1 As New DataTable
    Private strSQL As String
    Private Tienhang As Double
    Private VAT As Double
    Private Tongso As Double
    Private k As Int16
    Friend WithEvents COLTENDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbdonvi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbNvbh As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbKho_hang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbKhach_hang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSo_phieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents Radio1 As System.Windows.Forms.RadioButton
    Friend WithEvents SimpleButton_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmb_LoaiXN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupHuy As System.Windows.Forms.GroupBox
    Friend WithEvents RadioHuy1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHuy2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHuy3 As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents btnecl As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongkeXN))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.grbDieu_kien = New System.Windows.Forms.GroupBox()
        Me.cmbdonvi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupHuy = New System.Windows.Forms.GroupBox()
        Me.RadioHuy3 = New System.Windows.Forms.RadioButton()
        Me.RadioHuy2 = New System.Windows.Forms.RadioButton()
        Me.RadioHuy1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_LoaiXN = New DevExpress.XtraEditors.LookUpEdit()
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.Radio1 = New System.Windows.Forms.RadioButton()
        Me.txtSo_phieu = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbKhach_hang = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbKho_hang = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNvbh = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.btnecl = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdDetail = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COLTENDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDieu_kien.SuspendLayout()
        CType(Me.cmbdonvi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupHuy.SuspendLayout()
        CType(Me.cmb_LoaiXN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group.SuspendLayout()
        CType(Me.txtSo_phieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKhach_hang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNvbh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grbDieu_kien.Controls.Add(Me.cmbdonvi)
        Me.grbDieu_kien.Controls.Add(Me.Label2)
        Me.grbDieu_kien.Controls.Add(Me.GroupHuy)
        Me.grbDieu_kien.Controls.Add(Me.Label7)
        Me.grbDieu_kien.Controls.Add(Me.cmb_LoaiXN)
        Me.grbDieu_kien.Controls.Add(Me.Group)
        Me.grbDieu_kien.Controls.Add(Me.txtSo_phieu)
        Me.grbDieu_kien.Controls.Add(Me.Label11)
        Me.grbDieu_kien.Controls.Add(Me.Label6)
        Me.grbDieu_kien.Controls.Add(Me.cmbKhach_hang)
        Me.grbDieu_kien.Controls.Add(Me.cmbKho_hang)
        Me.grbDieu_kien.Controls.Add(Me.Label4)
        Me.grbDieu_kien.Controls.Add(Me.Label3)
        Me.grbDieu_kien.Controls.Add(Me.dtpTu_ngay)
        Me.grbDieu_kien.Controls.Add(Me.dtpDen_ngay)
        Me.grbDieu_kien.Controls.Add(Me.Label1)
        Me.grbDieu_kien.Controls.Add(Me.cmbNvbh)
        Me.grbDieu_kien.Controls.Add(Me.Label5)
        Me.grbDieu_kien.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbDieu_kien.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDieu_kien.ForeColor = System.Drawing.Color.Red
        Me.grbDieu_kien.Location = New System.Drawing.Point(0, 0)
        Me.grbDieu_kien.Name = "grbDieu_kien"
        Me.grbDieu_kien.Size = New System.Drawing.Size(829, 127)
        Me.grbDieu_kien.TabIndex = 0
        Me.grbDieu_kien.TabStop = False
        Me.grbDieu_kien.Text = "Điều kiện thông kê"
        '
        'cmbdonvi
        '
        Me.cmbdonvi.Location = New System.Drawing.Point(525, 71)
        Me.cmbdonvi.Name = "cmbdonvi"
        Me.cmbdonvi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbdonvi.Properties.Appearance.Options.UseFont = True
        Me.cmbdonvi.Properties.AutoHeight = False
        Me.cmbdonvi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbdonvi.Properties.NullText = ""
        Me.cmbdonvi.Properties.PopupWidth = 250
        Me.cmbdonvi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbdonvi.Size = New System.Drawing.Size(290, 22)
        Me.cmbdonvi.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(443, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Đơn vị:"
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
        Me.RadioHuy3.ForeColor = System.Drawing.Color.Navy
        Me.RadioHuy3.Location = New System.Drawing.Point(154, 13)
        Me.RadioHuy3.Name = "RadioHuy3"
        Me.RadioHuy3.Size = New System.Drawing.Size(59, 21)
        Me.RadioHuy3.TabIndex = 16
        Me.RadioHuy3.Text = "Huỷ"
        Me.RadioHuy3.UseVisualStyleBackColor = False
        '
        'RadioHuy2
        '
        Me.RadioHuy2.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy2.Checked = True
        Me.RadioHuy2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy2.ForeColor = System.Drawing.Color.Navy
        Me.RadioHuy2.Location = New System.Drawing.Point(68, 13)
        Me.RadioHuy2.Name = "RadioHuy2"
        Me.RadioHuy2.Size = New System.Drawing.Size(71, 21)
        Me.RadioHuy2.TabIndex = 15
        Me.RadioHuy2.TabStop = True
        Me.RadioHuy2.Text = "Kh huỷ"
        Me.RadioHuy2.UseVisualStyleBackColor = False
        '
        'RadioHuy1
        '
        Me.RadioHuy1.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy1.ForeColor = System.Drawing.Color.Navy
        Me.RadioHuy1.Location = New System.Drawing.Point(8, 13)
        Me.RadioHuy1.Name = "RadioHuy1"
        Me.RadioHuy1.Size = New System.Drawing.Size(40, 21)
        Me.RadioHuy1.TabIndex = 14
        Me.RadioHuy1.Text = "All"
        Me.RadioHuy1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(443, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Loại KĐ:"
        '
        'cmb_LoaiXN
        '
        Me.cmb_LoaiXN.Location = New System.Drawing.Point(525, 25)
        Me.cmb_LoaiXN.Name = "cmb_LoaiXN"
        Me.cmb_LoaiXN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmb_LoaiXN.Properties.Appearance.Options.UseFont = True
        Me.cmb_LoaiXN.Properties.AutoHeight = False
        Me.cmb_LoaiXN.Properties.AutoSearchColumnIndex = 1
        Me.cmb_LoaiXN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_LoaiXN.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaXn", "Mã Xuất nhập ", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tenloai", "Tên Loại", 180, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmb_LoaiXN.Properties.NullText = ""
        Me.cmb_LoaiXN.Properties.PopupWidth = 250
        Me.cmb_LoaiXN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmb_LoaiXN.Size = New System.Drawing.Size(290, 22)
        Me.cmb_LoaiXN.TabIndex = 6
        '
        'Group
        '
        Me.Group.Controls.Add(Me.Radio1)
        Me.Group.Location = New System.Drawing.Point(87, 16)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(109, 42)
        Me.Group.TabIndex = 19
        Me.Group.TabStop = False
        '
        'Radio1
        '
        Me.Radio1.BackColor = System.Drawing.Color.Transparent
        Me.Radio1.Checked = True
        Me.Radio1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio1.ForeColor = System.Drawing.Color.Navy
        Me.Radio1.Location = New System.Drawing.Point(6, 15)
        Me.Radio1.Name = "Radio1"
        Me.Radio1.Size = New System.Drawing.Size(97, 21)
        Me.Radio1.TabIndex = 12
        Me.Radio1.TabStop = True
        Me.Radio1.Text = "Xuất thuốc"
        Me.Radio1.UseVisualStyleBackColor = False
        '
        'txtSo_phieu
        '
        Me.txtSo_phieu.EditValue = ""
        Me.txtSo_phieu.Location = New System.Drawing.Point(305, 87)
        Me.txtSo_phieu.Name = "txtSo_phieu"
        Me.txtSo_phieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSo_phieu.Properties.Appearance.Options.UseFont = True
        Me.txtSo_phieu.Properties.AutoHeight = False
        Me.txtSo_phieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSo_phieu.Size = New System.Drawing.Size(116, 22)
        Me.txtSo_phieu.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(219, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Số phiếu:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(443, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Bác sĩ KĐ:"
        '
        'cmbKhach_hang
        '
        Me.cmbKhach_hang.Location = New System.Drawing.Point(525, 48)
        Me.cmbKhach_hang.Name = "cmbKhach_hang"
        Me.cmbKhach_hang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbKhach_hang.Properties.Appearance.Options.UseFont = True
        Me.cmbKhach_hang.Properties.AutoHeight = False
        Me.cmbKhach_hang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKhach_hang.Properties.NullText = ""
        Me.cmbKhach_hang.Properties.PopupWidth = 250
        Me.cmbKhach_hang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbKhach_hang.Size = New System.Drawing.Size(290, 22)
        Me.cmbKhach_hang.TabIndex = 8
        '
        'cmbKho_hang
        '
        Me.cmbKho_hang.Location = New System.Drawing.Point(87, 87)
        Me.cmbKho_hang.Name = "cmbKho_hang"
        Me.cmbKho_hang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbKho_hang.Properties.Appearance.Options.UseFont = True
        Me.cmbKho_hang.Properties.AutoHeight = False
        Me.cmbKho_hang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKho_hang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã kho"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho")})
        Me.cmbKho_hang.Properties.NullText = ""
        Me.cmbKho_hang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbKho_hang.Size = New System.Drawing.Size(116, 22)
        Me.cmbKho_hang.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(219, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Đến ngày:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Từ ngày:"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(87, 64)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.dtpTu_ngay.Size = New System.Drawing.Size(116, 22)
        Me.dtpTu_ngay.TabIndex = 0
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(305, 64)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.dtpDen_ngay.Size = New System.Drawing.Size(116, 22)
        Me.dtpDen_ngay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(443, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Bệnh nhân:"
        '
        'cmbNvbh
        '
        Me.cmbNvbh.Location = New System.Drawing.Point(525, 94)
        Me.cmbNvbh.Name = "cmbNvbh"
        Me.cmbNvbh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbNvbh.Properties.Appearance.Options.UseFont = True
        Me.cmbNvbh.Properties.AutoHeight = False
        Me.cmbNvbh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNvbh.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Họ và tên", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbNvbh.Properties.NullText = ""
        Me.cmbNvbh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNvbh.Size = New System.Drawing.Size(290, 22)
        Me.cmbNvbh.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kho thuốc:"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(429, 137)
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
        Me.btnIn.Location = New System.Drawing.Point(627, 137)
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
        Me.SimpleButton_Close.Location = New System.Drawing.Point(726, 137)
        Me.SimpleButton_Close.Name = "SimpleButton_Close"
        Me.SimpleButton_Close.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton_Close.TabIndex = 11
        Me.SimpleButton_Close.Text = "&Thoát"
        '
        'btnecl
        '
        Me.btnecl.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnecl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnecl.Appearance.Options.UseFont = True
        Me.btnecl.Appearance.Options.UseForeColor = True
        Me.btnecl.Location = New System.Drawing.Point(528, 137)
        Me.btnecl.Name = "btnecl"
        Me.btnecl.Size = New System.Drawing.Size(75, 25)
        Me.btnecl.TabIndex = 21
        Me.btnecl.Text = "&Excel"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'grdDetail
        '
        Me.grdDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDetail.Location = New System.Drawing.Point(0, 183)
        Me.grdDetail.MainView = Me.GridView1
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.Size = New System.Drawing.Size(829, 375)
        Me.grdDetail.TabIndex = 2
        Me.grdDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn4, Me.COLTENDV, Me.GridColumn3, Me.GridColumn9, Me.GridColumn5, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView1.GridControl = Me.grdDetail
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
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
        Me.GridColumn2.Width = 85
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số HĐ"
        Me.GridColumn1.FieldName = "Sophieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 99
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Loại"
        Me.GridColumn4.FieldName = "MaXN"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Width = 50
        '
        'COLTENDV
        '
        Me.COLTENDV.Caption = "Đơn vị"
        Me.COLTENDV.FieldName = "TENDONVI"
        Me.COLTENDV.Name = "COLTENDV"
        Me.COLTENDV.Visible = True
        Me.COLTENDV.VisibleIndex = 2
        Me.COLTENDV.Width = 194
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Bệnh nhân"
        Me.GridColumn3.FieldName = "Tendv"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 162
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Quy đổi"
        Me.GridColumn9.DisplayFormat.FormatString = "###,###"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Quydoi"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", "{0: ###,###}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 94
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Bác sĩ kê đơn"
        Me.GridColumn5.FieldName = "hoten"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 125
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Huỷ"
        Me.GridColumn10.FieldName = "Huy"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.FixedWidth = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 48
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Phiếu X/N"
        Me.GridColumn11.FieldName = "LoaiPhieu"
        Me.GridColumn11.MinWidth = 10
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Width = 56
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "IDPhieuXN"
        Me.GridColumn12.FieldName = "IDPhieuXN"
        Me.GridColumn12.MinWidth = 10
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Width = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(12, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(249, 16)
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
        'frmThongkeXN
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
        Me.Controls.Add(Me.btnecl)
        Me.Controls.Add(Me.btnIn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(845, 597)
        Me.Name = "frmThongkeXN"
        Me.Text = "THỐNG KÊ PHIẾU XUẤT THUỐC"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDieu_kien.ResumeLayout(False)
        Me.grbDieu_kien.PerformLayout()
        CType(Me.cmbdonvi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupHuy.ResumeLayout(False)
        CType(Me.cmb_LoaiXN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group.ResumeLayout(False)
        CType(Me.txtSo_phieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKhach_hang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNvbh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        Load_ComboBox("SELECT Username,HoTen From Nguoi_su_dung order by HoTen", Me.cmbNvbh, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang order by TenKho", Me.cmbKho_hang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaXn,Tenloai From DM_Xuat_nhap order by Tenloai", Me.cmb_LoaiXN, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT madv[Mã],tendv[Họ tên] From donvi order by Tendv", Me.cmbdonvi, CNNQLPHONGKHAM)
        grdcolLoai_phieu.HeaderText = "Huỷ"
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
        strSQL = "Select Case When Phieu_Xuat_Nhap.Loaiphieu = 0 then 'X'+ Right('000000'+ cast(Phieu_Xuat_Nhap.Sophieu as nvarchar),6) else 'N'+ Right('000000'+ cast(Phieu_Xuat_Nhap.Sophieu as nvarchar),6) end as Sophieu,Phieu_Xuat_Nhap.Ngay,HOSOBN.HOTENbn as Tendv,HOSOBN.SOTHEBHyt as Makh,Phieu_Xuat_Nhap.MaXN,Nguoi_su_dung.hoten ,Kho_Hang.TenKho,Phieu_Xuat_Nhap.Quydoi-Phieu_Xuat_Nhap.Vat as Tienhang,"
        strSQL = strSQL & "Phieu_Xuat_Nhap.Vat,Phieu_Xuat_Nhap.Quydoi,Phieu_Xuat_Nhap.Huy,Phieu_Xuat_Nhap.IDPhieuXn,Phieu_Xuat_Nhap.LoaiPhieu from Phieu_Xuat_Nhap INNER JOIN Kho_hang ON (Phieu_Xuat_Nhap.Makho = Kho_hang.Makho) INNER JOIN nguoi_su_dung  ON nguoi_su_dung.Username = Phieu_Xuat_Nhap.nguoinhap"
        strSQL = strSQL & " INNER JOIN HOSOBN ON (Phieu_Xuat_Nhap.Makh = HOSOBN.Mabn) where Loaiphieu = 0 AND "
        If Me.RadioHuy2.Checked = True Then
            strSQL = strSQL & "Huy = 0 AND "
        ElseIf Me.RadioHuy3.Checked = True Then
            strSQL = strSQL & "Huy = 1 AND "
        End If
        If Me.cmbKho_hang.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Makho", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbKho_hang.EditValue, "", strSQL)
        End If
        If Me.cmb_LoaiXN.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.MaXn", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmb_LoaiXN.EditValue, "", strSQL)
        End If
        If Me.dtpTu_ngay.Text <> "" And Me.dtpDen_ngay.Text <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Ngay", MdlCommon.Kieukitu.Ngaythang, "BETWEEN", "AND", Me.dtpTu_ngay.DateTime, Me.dtpDen_ngay.DateTime, strSQL)
        End If
        If Me.txtSo_phieu.Text <> "" Then
            If IsNumeric(Me.txtSo_phieu.Text) = False Then
                ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.ErrPro.SetError(Me.txtSo_phieu, "Trường số phiếu có giá trị bằng số, không phải bằng chữ")
                ErrPro.SetIconAlignment(Me.txtSo_phieu, ErrorIconAlignment.MiddleRight)
            Else
                GenSQL("Phieu_Xuat_Nhap.Sophieu", MdlCommon.Kieukitu.So, "=", "AND", Me.txtSo_phieu.Text, "", strSQL)
            End If
        End If
        If Me.cmbNvbh.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Nguoinhap", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbNvbh.EditValue, "", strSQL)
        End If
        If Me.cmbKhach_hang.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Makh", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbKhach_hang.EditValue, "", strSQL)
        End If
        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If
        'THEM PHAN DONVI BAC SUA 18/1/2013
        'BEGIN
        strSQL = strSQL & " UNION ALL Select Case When Phieu_Xuat_Nhap.Loaiphieu = 0 then 'X'+ Right('000000'+ cast(Phieu_Xuat_Nhap.Sophieu as nvarchar),6) else 'N'+ Right('000000'+ cast(Phieu_Xuat_Nhap.Sophieu as nvarchar),6) end as Sophieu,Phieu_Xuat_Nhap.Ngay,DONVI.Tendv,'' as Makh,Phieu_Xuat_Nhap.MaXN,Nguoi_su_dung.hoten ,Kho_Hang.TenKho,Phieu_Xuat_Nhap.Quydoi-Phieu_Xuat_Nhap.Vat as Tienhang,"
        strSQL = strSQL & "Phieu_Xuat_Nhap.Vat,Phieu_Xuat_Nhap.Quydoi,Phieu_Xuat_Nhap.Huy,Phieu_Xuat_Nhap.IDPhieuXn,Phieu_Xuat_Nhap.LoaiPhieu from Phieu_Xuat_Nhap INNER JOIN Kho_hang ON (Phieu_Xuat_Nhap.Makho = Kho_hang.Makho) INNER JOIN nguoi_su_dung  ON nguoi_su_dung.Username = Phieu_Xuat_Nhap.nguoinhap"
        strSQL = strSQL & " INNER JOIN DONVI ON DONVI.MADV=Phieu_Xuat_Nhap.Makh where Loaiphieu = 0 AND "
        If Me.RadioHuy2.Checked = True Then
            strSQL = strSQL & "Huy = 0 AND "
        ElseIf Me.RadioHuy3.Checked = True Then
            strSQL = strSQL & "Huy = 1 AND "
        End If
        If Me.cmbKho_hang.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Makho", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbKho_hang.EditValue, "", strSQL)
        End If
        If Me.cmb_LoaiXN.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.MaXn", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmb_LoaiXN.EditValue, "", strSQL)
        End If
        If Me.dtpTu_ngay.Text <> "" And Me.dtpDen_ngay.Text <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Ngay", MdlCommon.Kieukitu.Ngaythang, "BETWEEN", "AND", Me.dtpTu_ngay.DateTime, Me.dtpDen_ngay.DateTime, strSQL)
        End If
        If Me.txtSo_phieu.Text <> "" Then
            If IsNumeric(Me.txtSo_phieu.Text) = False Then
                ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.ErrPro.SetError(Me.txtSo_phieu, "Trường số phiếu có giá trị bằng số, không phải bằng chữ")
                ErrPro.SetIconAlignment(Me.txtSo_phieu, ErrorIconAlignment.MiddleRight)
            Else
                GenSQL("Phieu_Xuat_Nhap.Sophieu", MdlCommon.Kieukitu.So, "=", "AND", Me.txtSo_phieu.Text, "", strSQL)
            End If
        End If
        If Me.cmbNvbh.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Nguoinhap", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbNvbh.EditValue, "", strSQL)
        End If
        If Me.cmbdonvi.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Makh", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbdonvi.EditValue, "", strSQL)
        End If
        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If
        'END
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
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If dr("MaXN") = "XTH" Then
                Dim frm As New frmPhieuDoiTra
                Dim dt As DataTable = BusinessLogic.Data.GetDataset("SELECT IDPhieuXN FROM Phieu_Xuat_Nhap WHERE IDPhieuTra='" & dr("IDPhieuXN") & "'").Tables(0)
                frm.IDPhieuNhan = dt.Rows(0)("IDPhieuXN")
                frm.blnType = False
                frm.StartPosition = FormStartPosition.CenterScreen
                Dim frm1 As Form
                For Each frm1 In Me.OwnedForms
                    If (frm1.Name = frm.Name) Then
                        frm1.Activate()
                        Exit Sub
                    End If
                Next
                Me.AddOwnedForm(frm)
                frm.Show()
            Else
                Dim frm As New frmPhieuXN
                frm.blnType = False
                frm.Is_Edit = True
                frm.StartPosition = FormStartPosition.CenterScreen
                If Me.GridView1.FocusedRowHandle <> -999999 Then
                    If dr.IsNew = False Then
                        frm.IDPhieuxuat &= dr("IDPhieuXN") & ","
                        If dr("MaXN") = "XB" Then
                            frm.Name = "frm_xuatbanthuoc"
                            If dr("Huy") = True Then
                                frm.blnDelete = True
                            End If
                            frm.TxtSophieukham.Enabled = False
                            frm.blnLoaiphieu = False
                            frm.CmbKhohang.Enabled = False
                            frm.txtGhichu.Enabled = False
                        ElseIf dr("MaXN") = "XH" Then
                            frm.Name = "frm_xuathuythuoc"
                            If dr("Huy") = True Then
                                frm.blnDelete = True
                            End If
                            frm.blnLoaiphieu = False
                            frm.CmbKhohang.Enabled = False
                            frm.txtGhichu.Enabled = False
                        ElseIf dr("MaXN") = "XTD" Then
                            frm.Name = "frm_xuattheodon"
                            If dr("Huy") = True Then
                                frm.blnDelete = True
                            End If
                            frm.blnLoaiphieu = False
                            frm.CmbKhohang.Enabled = False
                            frm.txtGhichu.Enabled = False
                            frm.Label6.Visible = False
                            frm.TxtSophieukham.Visible = False
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
            End If
        End If
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
    Private Sub cmb_LoaiXN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_LoaiXN.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmb_LoaiXN.EditValue = ""
        End If
    End Sub
    Private Sub cmbKhach_hang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKhach_hang.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbKhach_hang.EditValue = ""
        End If
    End Sub
    Private Sub cmbKho_hang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKho_hang.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbKho_hang.EditValue = ""
        End If
    End Sub
    Private Sub cmbNvbh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNvbh.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbNvbh.EditValue = ""
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
            Me.txtSo_phieu.Focus()
        End If
    End Sub
    Private Sub txtSo_phieu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSo_phieu.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            LoadData()
            Me.cmbNvbh.Focus()
        End If
    End Sub

    Private Sub cmbNvbh_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNvbh.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            LoadData()
            Me.cmb_LoaiXN.Focus()
        End If
    End Sub
    Private Sub cmb_LoaiXN_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_LoaiXN.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            LoadData()
            Me.cmbKhach_hang.Focus()
        End If
    End Sub
    Private Sub cmbKhach_hang_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKhach_hang.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            LoadData()
            Me.btnXem.Focus()
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
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Export()
    End Sub
    Private Sub Export()
        'ProgressBarControl1.Visible = True
        'Dim grid As DevExpress.XtraGrid.GridControl = Me.grdDetail
        'Dim provider As IExportProvider = New ExportXlsProvider("C:\TestExport.xLs")
        'Dim link As BaseExportLink = grid.DefaultView.CreateExportLink(provider)
        'AddHandler link.Progress, New DevExpress.XtraGrid.Export.ProgressEventHandler(AddressOf Export_Progerss)
        'link.ExportTo(True)
        'ProgressBarControl1.Visible = False
        'Dim HelpProvider1 As New HelpProvider
        'Help.ShowHelp(Me, "C:\TestExport.xLs")
    End Sub
    Private Sub Export_Progerss(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Export.ProgressEventArgs)
        If e.Phase = DevExpress.XtraGrid.Export.ExportPhase.Link Then
            ProgressBarControl1.Position = e.Position
            Me.Update()
        End If
    End Sub

    Private Sub btnecl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnecl.Click
        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        grdDetail.DataSource = dtb
        '--------------------------------------
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim i As Int16 = 5
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = i
        '--------------------------------------
        wSheet.Range("C2", "G2").Merge()
        wSheet.Range("C2", "G2").Font.Bold = True
        wSheet.Range("C2", "G2").Font.Size = 20
        wSheet.Range("C2", "G2").Value2 = "THỐNG KÊ PHIẾU XUẤT THUỐC"
        wSheet.Range("C3", "C3").Value2 = "Từ ngày:"
        wSheet.Range("E3", "E3").Value2 = "Đến ngày:"

        excel.Cells(i, 1) = "STT"
        excel.Cells(i, 2) = "Ngày"
        excel.Cells(i, 3) = "Số HĐ"
        excel.Cells(i, 4) = "Loại"
        excel.Cells(i, 5) = "Bệnh nhân"
        excel.Cells(i, 6) = "Thẻ HBYT"
        excel.Cells(i, 7) = "Bác sỹ kê đơn"
        excel.Cells(i, 8) = "Thành tiền"
        excel.Cells(i, 9) = "Tên kho"
        excel.Cells(i, 10) = "Ghi chú"
        wSheet.Range(excel.Cells(i, 1), excel.Cells(i, 10)).Font.Bold = True
        wSheet.Range("A5", "J5").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin

        Dim j As Int32 = i + 1
        Dim tem = 0
        For j = i + 1 To dtb.Rows.Count + i
            tem = j - i - 1
            excel.Cells(j, 1) = ""
            excel.Cells(j, 2) = dtb.Rows(tem)("Ngay")
            excel.Cells(j, 3) = dtb.Rows(tem)("Sophieu")
            excel.Cells(j, 4) = dtb.Rows(tem)("MaXN")
            excel.Cells(j, 5) = dtb.Rows(tem)("Tendv")
            excel.Cells(j, 6) = dtb.Rows(tem)("Makh")
            excel.Cells(j, 7) = dtb.Rows(tem)("hoten")
            excel.Cells(j, 8) = dtb.Rows(tem)("Quydoi")
            excel.Cells(j, 9) = dtb.Rows(tem)("Tenkho")
            excel.Cells(j, 10) = ""
            wSheet.Range("A" + j.ToString, "J" + j.ToString).Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
        Next
        excel.Cells(3, 4) = Me.dtpTu_ngay.DateTime.Date
        excel.Cells(3, 6) = Me.dtpDen_ngay.DateTime.Date
        excel.Cells(j + 1, 7) = "TỔNG TIỀN"
        excel.Cells(j + 1, 8) = ""

        excel.Cells(j + 4, 2) = "THỦ KHO"
        excel.Cells(j + 4, 5) = "KẾ TOÁN"
        excel.Cells(j + 4, 7) = "THỦ TRƯỞNG ĐƠN VỊ"
        excel.Cells(j + 5, 2) = "(Ký,Họ tên)"
        excel.Cells(j + 5, 5) = "(Ký,Họ tên)"
        excel.Cells(j + 5, 7) = "(Ký,Họ tên)"
        wSheet.Range(excel.Cells(j + 1, 7), excel.Cells(j + 1, 8)).Font.Bold = True
        wSheet.Range(excel.Cells(j + 4, 2), excel.Cells(j + 4, 7)).Font.Bold = True
        wSheet.Columns.AutoFit()
        wSheet.Rows.AutoFit()
        'Mo thu muc va luu file
        Dim strFileName As String
        Dim blnFileOpen As Boolean = False
        Dim Save As New SaveFileDialog
        If Save.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Save.Filter = "Excel Files|*.xls"
            strFileName = Save.FileName
            Try
                wBook.SaveAs(strFileName)
                excel.Workbooks.Open(strFileName)
                excel.Visible = True
            Catch ex As Exception
                Exit Sub
            End Try
        Else : Exit Sub
        End If
        LoadData()
    End Sub

    Private Sub cmbdonvi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdonvi.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbdonvi.EditValue = ""
        End If
    End Sub
End Class
