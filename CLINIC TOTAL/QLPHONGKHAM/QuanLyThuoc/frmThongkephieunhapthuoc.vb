Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmThongkephieunhapthuoc
    Inherits frmBase 'System.Windows.Forms.Form
    Private dtb As New DataTable
    Private dtb1 As New DataTable
    Private strSQL As String
    Private Tienhang As Double
    Private VAT As Double
    Private Tongso As Double
    Private k As Int16
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbNvbh As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDon_vi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbKho_hang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txttong_so As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbltong_so As System.Windows.Forms.Label
    Friend WithEvents txtTien_hang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTongSp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSo_phieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents Radio2 As System.Windows.Forms.RadioButton
    Friend WithEvents SimpleButton_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmb_LoaiXN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupHuy As System.Windows.Forms.GroupBox
    Friend WithEvents RadioHuy1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHuy2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHuy3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbPhong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents btnecl As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongkephieunhapthuoc))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.grbDieu_kien = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPhong = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTongSp = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupHuy = New System.Windows.Forms.GroupBox()
        Me.RadioHuy3 = New System.Windows.Forms.RadioButton()
        Me.RadioHuy2 = New System.Windows.Forms.RadioButton()
        Me.RadioHuy1 = New System.Windows.Forms.RadioButton()
        Me.txtVAT = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_LoaiXN = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTien_hang = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.Radio2 = New System.Windows.Forms.RadioButton()
        Me.lbltong_so = New System.Windows.Forms.Label()
        Me.txtSo_phieu = New DevExpress.XtraEditors.TextEdit()
        Me.txttong_so = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbKho_hang = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDon_vi = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDieu_kien.SuspendLayout()
        CType(Me.cmbPhong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongSp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupHuy.SuspendLayout()
        CType(Me.txtVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_LoaiXN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTien_hang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group.SuspendLayout()
        CType(Me.txtSo_phieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttong_so.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDon_vi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grbDieu_kien.Controls.Add(Me.GroupBox1)
        Me.grbDieu_kien.Controls.Add(Me.cmbPhong)
        Me.grbDieu_kien.Controls.Add(Me.txtTongSp)
        Me.grbDieu_kien.Controls.Add(Me.Label13)
        Me.grbDieu_kien.Controls.Add(Me.Label10)
        Me.grbDieu_kien.Controls.Add(Me.GroupHuy)
        Me.grbDieu_kien.Controls.Add(Me.txtVAT)
        Me.grbDieu_kien.Controls.Add(Me.Label7)
        Me.grbDieu_kien.Controls.Add(Me.Label9)
        Me.grbDieu_kien.Controls.Add(Me.cmb_LoaiXN)
        Me.grbDieu_kien.Controls.Add(Me.txtTien_hang)
        Me.grbDieu_kien.Controls.Add(Me.Label8)
        Me.grbDieu_kien.Controls.Add(Me.Group)
        Me.grbDieu_kien.Controls.Add(Me.lbltong_so)
        Me.grbDieu_kien.Controls.Add(Me.txtSo_phieu)
        Me.grbDieu_kien.Controls.Add(Me.txttong_so)
        Me.grbDieu_kien.Controls.Add(Me.Label11)
        Me.grbDieu_kien.Controls.Add(Me.Label6)
        Me.grbDieu_kien.Controls.Add(Me.cmbKho_hang)
        Me.grbDieu_kien.Controls.Add(Me.Label4)
        Me.grbDieu_kien.Controls.Add(Me.Label3)
        Me.grbDieu_kien.Controls.Add(Me.dtpTu_ngay)
        Me.grbDieu_kien.Controls.Add(Me.dtpDen_ngay)
        Me.grbDieu_kien.Controls.Add(Me.Label2)
        Me.grbDieu_kien.Controls.Add(Me.cmbDon_vi)
        Me.grbDieu_kien.Controls.Add(Me.cmbNvbh)
        Me.grbDieu_kien.Controls.Add(Me.Label5)
        Me.grbDieu_kien.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbDieu_kien.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDieu_kien.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grbDieu_kien.Location = New System.Drawing.Point(0, 0)
        Me.grbDieu_kien.Name = "grbDieu_kien"
        Me.grbDieu_kien.Size = New System.Drawing.Size(995, 108)
        Me.grbDieu_kien.TabIndex = 0
        Me.grbDieu_kien.TabStop = False
        Me.grbDieu_kien.Text = "Điều kiện thông kê"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(721, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 8)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cmbPhong
        '
        Me.cmbPhong.Location = New System.Drawing.Point(180, 222)
        Me.cmbPhong.Name = "cmbPhong"
        Me.cmbPhong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPhong.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Maphong", "Mã", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhong", "Tên phòng", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbPhong.Properties.NullText = ""
        Me.cmbPhong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbPhong.Size = New System.Drawing.Size(120, 20)
        Me.cmbPhong.TabIndex = 4
        Me.cmbPhong.Visible = False
        '
        'txtTongSp
        '
        Me.txtTongSp.EditValue = ""
        Me.txtTongSp.Location = New System.Drawing.Point(620, 75)
        Me.txtTongSp.Name = "txtTongSp"
        Me.txtTongSp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongSp.Size = New System.Drawing.Size(72, 20)
        Me.txtTongSp.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(100, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 14)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Phòng ban"
        Me.Label13.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(621, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tổng SP"
        '
        'GroupHuy
        '
        Me.GroupHuy.Controls.Add(Me.RadioHuy3)
        Me.GroupHuy.Controls.Add(Me.RadioHuy2)
        Me.GroupHuy.Controls.Add(Me.RadioHuy1)
        Me.GroupHuy.Location = New System.Drawing.Point(376, 22)
        Me.GroupHuy.Name = "GroupHuy"
        Me.GroupHuy.Size = New System.Drawing.Size(221, 40)
        Me.GroupHuy.TabIndex = 20
        Me.GroupHuy.TabStop = False
        '
        'RadioHuy3
        '
        Me.RadioHuy3.AutoSize = True
        Me.RadioHuy3.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioHuy3.Location = New System.Drawing.Point(164, 13)
        Me.RadioHuy3.Name = "RadioHuy3"
        Me.RadioHuy3.Size = New System.Drawing.Size(46, 18)
        Me.RadioHuy3.TabIndex = 16
        Me.RadioHuy3.Text = "Huỷ"
        Me.RadioHuy3.UseVisualStyleBackColor = False
        '
        'RadioHuy2
        '
        Me.RadioHuy2.AutoSize = True
        Me.RadioHuy2.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy2.Checked = True
        Me.RadioHuy2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioHuy2.Location = New System.Drawing.Point(69, 13)
        Me.RadioHuy2.Name = "RadioHuy2"
        Me.RadioHuy2.Size = New System.Drawing.Size(63, 18)
        Me.RadioHuy2.TabIndex = 15
        Me.RadioHuy2.TabStop = True
        Me.RadioHuy2.Text = "Kh huỷ"
        Me.RadioHuy2.UseVisualStyleBackColor = False
        '
        'RadioHuy1
        '
        Me.RadioHuy1.AutoSize = True
        Me.RadioHuy1.BackColor = System.Drawing.Color.Transparent
        Me.RadioHuy1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHuy1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioHuy1.Location = New System.Drawing.Point(6, 13)
        Me.RadioHuy1.Name = "RadioHuy1"
        Me.RadioHuy1.Size = New System.Drawing.Size(37, 18)
        Me.RadioHuy1.TabIndex = 14
        Me.RadioHuy1.Text = "All"
        Me.RadioHuy1.UseVisualStyleBackColor = False
        '
        'txtVAT
        '
        Me.txtVAT.EditValue = ""
        Me.txtVAT.Location = New System.Drawing.Point(801, 37)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVAT.Size = New System.Drawing.Size(120, 20)
        Me.txtVAT.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Loại X/N"
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(713, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Tiền hàng"
        '
        'cmb_LoaiXN
        '
        Me.cmb_LoaiXN.Location = New System.Drawing.Point(180, 246)
        Me.cmb_LoaiXN.Name = "cmb_LoaiXN"
        Me.cmb_LoaiXN.Properties.AutoSearchColumnIndex = 1
        Me.cmb_LoaiXN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_LoaiXN.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaXn", "Mã Xuất nhập ", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tenloai", "Tên Loại", 180, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmb_LoaiXN.Properties.NullText = ""
        Me.cmb_LoaiXN.Properties.PopupWidth = 250
        Me.cmb_LoaiXN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmb_LoaiXN.Size = New System.Drawing.Size(272, 20)
        Me.cmb_LoaiXN.TabIndex = 6
        Me.cmb_LoaiXN.Visible = False
        '
        'txtTien_hang
        '
        Me.txtTien_hang.EditValue = ""
        Me.txtTien_hang.Location = New System.Drawing.Point(801, 14)
        Me.txtTien_hang.Name = "txtTien_hang"
        Me.txtTien_hang.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTien_hang.Size = New System.Drawing.Size(120, 20)
        Me.txtTien_hang.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(713, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Thuế(VAT)"
        '
        'Group
        '
        Me.Group.Controls.Add(Me.Radio2)
        Me.Group.Location = New System.Drawing.Point(274, 22)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(80, 40)
        Me.Group.TabIndex = 19
        Me.Group.TabStop = False
        '
        'Radio2
        '
        Me.Radio2.AutoSize = True
        Me.Radio2.BackColor = System.Drawing.Color.Transparent
        Me.Radio2.Checked = True
        Me.Radio2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Radio2.Location = New System.Drawing.Point(8, 13)
        Me.Radio2.Name = "Radio2"
        Me.Radio2.Size = New System.Drawing.Size(53, 18)
        Me.Radio2.TabIndex = 13
        Me.Radio2.TabStop = True
        Me.Radio2.Text = "Nhập"
        Me.Radio2.UseVisualStyleBackColor = False
        '
        'lbltong_so
        '
        Me.lbltong_so.AutoSize = True
        Me.lbltong_so.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltong_so.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbltong_so.Location = New System.Drawing.Point(713, 78)
        Me.lbltong_so.Name = "lbltong_so"
        Me.lbltong_so.Size = New System.Drawing.Size(84, 14)
        Me.lbltong_so.TabIndex = 6
        Me.lbltong_so.Text = "Tổng số tiền"
        '
        'txtSo_phieu
        '
        Me.txtSo_phieu.EditValue = ""
        Me.txtSo_phieu.Location = New System.Drawing.Point(469, 168)
        Me.txtSo_phieu.Name = "txtSo_phieu"
        Me.txtSo_phieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSo_phieu.Size = New System.Drawing.Size(128, 20)
        Me.txtSo_phieu.TabIndex = 3
        Me.txtSo_phieu.Visible = False
        '
        'txttong_so
        '
        Me.txttong_so.EditValue = ""
        Me.txttong_so.Location = New System.Drawing.Point(801, 75)
        Me.txttong_so.Name = "txttong_so"
        Me.txttong_so.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txttong_so.Size = New System.Drawing.Size(120, 20)
        Me.txttong_so.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(397, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 14)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Số phiếu"
        Me.Label11.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(230, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nhân viên"
        Me.Label6.Visible = False
        '
        'cmbKho_hang
        '
        Me.cmbKho_hang.Location = New System.Drawing.Point(274, 68)
        Me.cmbKho_hang.Name = "cmbKho_hang"
        Me.cmbKho_hang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKho_hang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã kho"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho")})
        Me.cmbKho_hang.Properties.NullText = ""
        Me.cmbKho_hang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbKho_hang.Size = New System.Drawing.Size(323, 20)
        Me.cmbKho_hang.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Đến ngày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Từ ngày"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(82, 32)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpTu_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpTu_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpTu_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpTu_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpTu_ngay.Size = New System.Drawing.Size(105, 20)
        Me.dtpTu_ngay.TabIndex = 0
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(82, 66)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpDen_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpDen_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpDen_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpDen_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDen_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpDen_ngay.Size = New System.Drawing.Size(105, 20)
        Me.dtpDen_ngay.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Đơn vị"
        Me.Label2.Visible = False
        '
        'cmbDon_vi
        '
        Me.cmbDon_vi.Location = New System.Drawing.Point(302, 215)
        Me.cmbDon_vi.Name = "cmbDon_vi"
        Me.cmbDon_vi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDon_vi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Madv", "Mã đơn vị", 10, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tendv", "Tên đơn vị", 180, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbDon_vi.Properties.NullText = ""
        Me.cmbDon_vi.Properties.PopupWidth = 250
        Me.cmbDon_vi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDon_vi.Size = New System.Drawing.Size(295, 20)
        Me.cmbDon_vi.TabIndex = 7
        Me.cmbDon_vi.Visible = False
        '
        'cmbNvbh
        '
        Me.cmbNvbh.Location = New System.Drawing.Point(302, 192)
        Me.cmbNvbh.Name = "cmbNvbh"
        Me.cmbNvbh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNvbh.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Họ và tên", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbNvbh.Properties.NullText = ""
        Me.cmbNvbh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNvbh.Size = New System.Drawing.Size(295, 20)
        Me.cmbNvbh.TabIndex = 5
        Me.cmbNvbh.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(201, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kho hàng"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(14, 115)
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
        Me.btnIn.Location = New System.Drawing.Point(198, 115)
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
        Me.SimpleButton_Close.Location = New System.Drawing.Point(290, 115)
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
        Me.btnecl.Location = New System.Drawing.Point(106, 115)
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
        Me.grdDetail.Location = New System.Drawing.Point(1, 153)
        Me.grdDetail.MainView = Me.GridView1
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.Size = New System.Drawing.Size(994, 397)
        Me.grdDetail.TabIndex = 2
        Me.grdDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn4, Me.GridColumn3, Me.GridColumn9, Me.GridColumn5, Me.GridColumn6, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn7})
        Me.GridView1.GridControl = Me.grdDetail
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.GridColumn2.Width = 86
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số HĐ"
        Me.GridColumn1.FieldName = "Sophieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 60
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Loại"
        Me.GridColumn4.FieldName = "MaXN"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 82
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Đơn vị"
        Me.GridColumn3.FieldName = "TenDv"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 191
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tiền nhập"
        Me.GridColumn9.DisplayFormat.FormatString = "###,###"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Quydoi"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 97
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Người nhập"
        Me.GridColumn5.FieldName = "hoten"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 127
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tên kho"
        Me.GridColumn6.FieldName = "TenKho"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 124
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Huỷ"
        Me.GridColumn10.FieldName = "Huy"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 58
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Phiếu X/N"
        Me.GridColumn11.FieldName = "LoaiPhieu"
        Me.GridColumn11.MinWidth = 10
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        Me.GridColumn11.Width = 58
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "IDPhieuXN"
        Me.GridColumn12.FieldName = "IDPhieuXN"
        Me.GridColumn12.MinWidth = 10
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Width = 54
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Công nợ"
        Me.GridColumn7.FieldName = "congno"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 30
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(660, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(261, 14)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Kích đúp vào bản ghi để xem chi tiết phiếu XN"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(32, 568)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(608, 14)
        Me.ProgressBarControl1.TabIndex = 13
        Me.ProgressBarControl1.Visible = False
        '
        'frmThongkephieunhapthuoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(995, 551)
        Me.Controls.Add(Me.grbDieu_kien)
        Me.Controls.Add(Me.grdDetail)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SimpleButton_Close)
        Me.Controls.Add(Me.btnecl)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.btnXem)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmThongkephieunhapthuoc"
        Me.Text = "THỐNG KÊ PHIẾU NHẬP KHO"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDieu_kien.ResumeLayout(False)
        Me.grbDieu_kien.PerformLayout()
        CType(Me.cmbPhong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongSp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupHuy.ResumeLayout(False)
        Me.GroupHuy.PerformLayout()
        CType(Me.txtVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_LoaiXN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTien_hang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group.ResumeLayout(False)
        Me.Group.PerformLayout()
        CType(Me.txtSo_phieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttong_so.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDon_vi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNvbh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmThongkephieunhapthuoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Dim grdcolLoai_phieu As New DataGridBoolColumn
        Load_ComboBox("SELECT Madv,Tendv From Donvi order by Tendv", Me.cmbDon_vi, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,HoTen From Nguoi_su_dung order by HoTen", Me.cmbNvbh, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaKho,TenKho From Kho_hang order by TenKho", Me.cmbKho_hang, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaXn,Tenloai From DM_Xuat_nhap order by Tenloai", Me.cmb_LoaiXN, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Maphong,TenPhong From Phong_ban order by TenPhong", Me.cmbPhong, CNNQLPHONGKHAM)
        grdcolLoai_phieu.HeaderText = "Huỷ"
        Me.dtpTu_ngay.DateTime = NgayGioServer().Date
        Me.dtpDen_ngay.DateTime = NgayGioServer().Date
        'Me.cmbNvbh.EditValue = clsLoginObj.strUsername
        LoadData()
        ' Application.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
    End Sub
    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Xetngay()
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        Application.CurrentCulture = myCIintl
        Application.CurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        Me.ErrPro.Dispose()
        strSQL = "Select   'N'+ Right('000000'+ cast(Phieu_Xuat_Nhap.Sophieu as nvarchar),6) as Sophieu,convert(char(10),Phieu_Xuat_Nhap.Ngay,103) as Ngay,DonVi.TenDv,Phieu_Xuat_Nhap.MaXN,Nguoi_su_dung.hoten ,Kho_Hang.TenKho,Phieu_Xuat_Nhap.Quydoi-Phieu_Xuat_Nhap.Vat as Tienhang,"
        strSQL = strSQL & "Phieu_Xuat_Nhap.Vat,Phieu_Xuat_Nhap.Quydoi,Phieu_Xuat_Nhap.Huy,Phieu_Xuat_Nhap.IDPhieuXn,Phieu_Xuat_Nhap.LoaiPhieu,Phong_ban.Maphong,ISNULL(Phieu_Xuat_Nhap.Quydoi-Phieu_Xuat_Nhap.Vat,0)-ISNULL(sotienchi,0) as congno "
        strSQL = strSQL & "from Phieu_Xuat_Nhap INNER JOIN Kho_hang ON (Phieu_Xuat_Nhap.Makho = Kho_hang.Makho) INNER JOIN (nguoi_su_dung INNER JOIN Phong_ban ON nguoi_su_dung.Maphong = Phong_ban.Maphong) ON nguoi_su_dung.Username = Phieu_Xuat_Nhap.nguoinhap"
        strSQL = strSQL & " INNER JOIN Donvi ON (Phieu_Xuat_Nhap.Madv = Donvi.Madv) where  Loaiphieu = 1 and "
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
        If Me.cmbPhong.EditValue <> "" Then
            GenSQL("Phong_ban.Maphong", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbPhong.EditValue, "", strSQL)
        End If
        If Me.cmbDon_vi.EditValue <> "" Then
            GenSQL("Phieu_Xuat_Nhap.Madv", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbDon_vi.EditValue, "", strSQL)
        End If
        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If
        dtb = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        Dim i As Int16
        Tienhang = 0
        VAT = 0
        Tongso = 0
        k = 0
        For i = 0 To dtb.Rows.Count - 1
            'If dtb.Rows(i)("Huy") = 0 Then
            Tienhang += dtb.Rows(i)("Tienhang")
            VAT += dtb.Rows(i)("VAT")
            Tongso += dtb.Rows(i)("QuyDoi")
            'End If
            k = k + 1
        Next
        Me.grdDetail.DataSource = dtb
        Me.txtTongSp.Text = Format(k, "###,###")
        Me.txtTien_hang.Text = Format(Tienhang, "###,###")
        Me.txtVAT.Text = Format(VAT, "###,###")
        Me.txttong_so.Text = Format(Tongso, "###,###")
        Me.GridView1.ExpandAllGroups()

    End Sub
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Xetngay()
        LoadData()
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.ThongKeXN
        frm.dtb = dtb
        frm.Tngay = Me.dtpTu_ngay.DateTime.Date
        frm.Dngay = Me.dtpDen_ngay.DateTime.Date
        frm.Phong = Me.cmbPhong.Text
        frm.Nhanvien = Me.cmbNvbh.Text
        frm.donvi = Me.cmbDon_vi.Text
        frm.Tienhang = Tienhang
        frm.VAT = VAT
        frm.TongSo = Tongso
        frm.TongSP = k
        frm.Title = Me.Text
        frm.Show()
        'Application.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
    End Sub
    Private Sub grdDetail_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDetail.DoubleClick
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        Application.CurrentCulture = myCIintl
        Application.CurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"

        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If dr("MaXN") = "NTH" Then
                Dim frm As New frmPhieuDoiTra
                frm.IDPhieuNhan = dr("IDPhieuXN")
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
                Dim frm As New frmPhieuNHAPKHOTHUOC
                If Me.cmbKho_hang.EditValue = "KHC" Then
                    frm.Label20.Text = "PHIẾU NHẬP HÓA CHẤT"
                End If
                frm.blnType = False
                frm.StartPosition = FormStartPosition.CenterScreen
                If Me.GridView1.FocusedRowHandle <> -999999 Then
                    If dr.IsNew = False Then
                        frm.IDPhieuxuat &= dr("IDPhieuXN") & ","
                        If dr("LoaiPhieu") = True Then
                            'frm.Name = "frmPhieuN"
                            'frm.Text = "Phiếu nhập kho"
                            If dr("Huy") = True Then
                                frm.blnDelete = True
                            End If
                            frm.blnLoaiphieu = True
                            frm.CmbKhohang.Enabled = False
                            frm.txtGhichu.Enabled = False
                        Else
                            If dr("Huy") = True Then
                                frm.blnDelete = True
                            End If
                            frm.Name = "frmPhieuX"
                            frm.Text = "Phiếu xuất kho"
                            frm.blnLoaiphieu = False
                            frm.CmbKhohang.Enabled = False
                            frm.txtGhichu.Enabled = False
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
    Private Sub Radio2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio2.CheckedChanged
        If Me.Radio2.Checked = True Then
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
    Private Sub cmbDon_vi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDon_vi.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbDon_vi.EditValue = ""
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
    Private Sub cmbPhong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPhong.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbPhong.EditValue = ""
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
            Me.cmbPhong.Focus()
        End If
    End Sub
    Private Sub cmbPhong_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPhong.KeyUp
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
            Me.cmbDon_vi.Focus()
        End If
    End Sub
    Private Sub cmbKhach_hang_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
            Me.dtpDen_ngay.DateTime = TODAY.Date.Date
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
        wSheet.Range("C2", "G2").Value2 = "THỐNG KÊ PHIẾU NHẬP THUỐC"
        wSheet.Range("C3", "C3").Value2 = "Từ ngày:"
        wSheet.Range("E3", "E3").Value2 = "Đến ngày:"

        excel.Cells(i, 1) = "STT"
        excel.Cells(i, 2) = "Ngày"
        excel.Cells(i, 3) = "Số HĐ"
        excel.Cells(i, 4) = "Loại"
        excel.Cells(i, 5) = "Đơn vị"
        excel.Cells(i, 6) = "Tiền nhập"
        excel.Cells(i, 7) = "Người nhập"
        excel.Cells(i, 8) = "Kho"
        excel.Cells(i, 9) = "Ghi chú"
        wSheet.Range(excel.Cells(i, 1), excel.Cells(i, 9)).Font.Bold = True
        wSheet.Range("A5", "I5").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin

        Dim j As Int32 = i + 1
        Dim tem = 0
        For j = i + 1 To dtb.Rows.Count + i
            tem = j - i - 1
            excel.Cells(j, 1) = ""
            excel.Cells(j, 2) = dtb.Rows(tem)("Ngay")
            excel.Cells(j, 3) = dtb.Rows(tem)("Sophieu")
            excel.Cells(j, 4) = dtb.Rows(tem)("MaXN")
            excel.Cells(j, 5) = dtb.Rows(tem)("TenDV")
            excel.Cells(j, 6) = dtb.Rows(tem)("Quydoi")
            excel.Cells(j, 7) = dtb.Rows(tem)("hoten")
            excel.Cells(j, 8) = dtb.Rows(tem)("Tenkho")
            excel.Cells(j, 9) = ""
            wSheet.Range("A" + j.ToString, "I" + j.ToString).Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
        Next
        excel.Cells(3, 4) = Me.dtpTu_ngay.DateTime.Date
        excel.Cells(3, 6) = Me.dtpDen_ngay.DateTime.Date
        excel.Cells(j + 1, 5) = "TỔNG TIỀN"
        excel.Cells(j + 1, 6) = Me.txttong_so.Text

        excel.Cells(j + 4, 2) = "THỦ KHO"
        excel.Cells(j + 4, 5) = "KẾ TOÁN"
        excel.Cells(j + 4, 7) = "THỦ TRƯỞNG ĐƠN VỊ"
        excel.Cells(j + 5, 2) = "(Ký,Họ tên)"
        excel.Cells(j + 5, 5) = "(Ký,Họ tên)"
        excel.Cells(j + 5, 7) = "(Ký,Họ tên)"

        wSheet.Range(excel.Cells(j + 1, 5), excel.Cells(j + 1, 6)).Font.Bold = True
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

    Private Sub GridView1_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim congno As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("congno"))
            If congno <> "0" Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If
        End If
    End Sub
End Class
