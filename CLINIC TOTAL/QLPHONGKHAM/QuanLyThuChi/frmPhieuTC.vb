Imports System.Collections.Generic

Public Class frmPhieuTC
    Inherits frmBase 'System.Windows.Forms.Form
    Public blnLoaiphieu As Boolean
    Public blnTiengui As Boolean
    Public blnEdit As Boolean
    Private dtbPXN As New DataTable
    Private dtbTienTe As New DataTable
    Private dtbTkNo As New DataTable
    Private dtbTkCo As New DataTable
    Private strIDDelete As String = String.Empty
    Private htbEdit As New Hashtable
    Private htbAdd As New Hashtable
    Public IDPhieuTC As Integer
    Public foundClick As Boolean = True
    Public blnDelete As Boolean
    Private sky As Boolean
    Private SuaNgay As DateTime
    Private strMaquy As String
    Private SotienVND As Double = 0
    Private SotienUSD As Double = 0
    Private fSotienVND As Double = 0
    Private fSotienUSD As Double = 0
    Private StypeSUA As Boolean = False
    Private Madv As String = String.Empty
    Private Quy As String = String.Empty
    Private bYNO As Boolean = False
    Public dattien As Boolean = False
    Public loaichi As Boolean = False
    Private dts As New DataSet
    Public thutamung As Boolean = False

    Public thucthu As Double = 0
    Public loaithuchi As String = String.Empty
    Public mabn As String = String.Empty
    Public isHiden As Boolean = False

    Friend WithEvents txtsophieukham As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGhichu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents CmbDonvi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents txtThucThu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label_ThucThu As Label


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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtSotienUSD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTygia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSotienVND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTienQT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbQuy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbNghiep_vu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQuydoiUSD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbNvTC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbnQuy As System.Windows.Forms.Label
    Friend WithEvents lblDonvitc As System.Windows.Forms.Label
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grb As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIn_phieu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSophieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CmbNVBH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbdenquy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbldenquy As System.Windows.Forms.Label
    Friend WithEvents LabTendv As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuTC))
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtThucThu = New DevExpress.XtraEditors.TextEdit()
        Me.Label_ThucThu = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtsophieukham = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldenquy = New System.Windows.Forms.Label()
        Me.cmbdenquy = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbNVBH = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabTendv = New System.Windows.Forms.Label()
        Me.cmbNvTC = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtQuydoiUSD = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbNghiep_vu = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTienQT = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbQuy = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpNgay = New DevExpress.XtraEditors.DateEdit()
        Me.txtSotienVND = New DevExpress.XtraEditors.TextEdit()
        Me.txtTygia = New DevExpress.XtraEditors.TextEdit()
        Me.txtSotienUSD = New DevExpress.XtraEditors.TextEdit()
        Me.txtSophieu = New DevExpress.XtraEditors.TextEdit()
        Me.lbnQuy = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDonvitc = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtGhichu = New DevExpress.XtraEditors.MemoEdit()
        Me.CmbDonvi = New DevExpress.XtraEditors.LookUpEdit()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn_phieu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Grb.SuspendLayout()
        CType(Me.txtThucThu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsophieukham.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbdenquy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNvTC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuydoiUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNghiep_vu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienQT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbQuy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSotienVND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTygia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSotienUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbDonvi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb
        '
        Me.Grb.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Controls.Add(Me.txtThucThu)
        Me.Grb.Controls.Add(Me.Label_ThucThu)
        Me.Grb.Controls.Add(Me.Label28)
        Me.Grb.Controls.Add(Me.Label27)
        Me.Grb.Controls.Add(Me.Label26)
        Me.Grb.Controls.Add(Me.Label24)
        Me.Grb.Controls.Add(Me.Label23)
        Me.Grb.Controls.Add(Me.Label22)
        Me.Grb.Controls.Add(Me.txtsophieukham)
        Me.Grb.Controls.Add(Me.Label5)
        Me.Grb.Controls.Add(Me.lbldenquy)
        Me.Grb.Controls.Add(Me.cmbdenquy)
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.CmbNVBH)
        Me.Grb.Controls.Add(Me.Label16)
        Me.Grb.Controls.Add(Me.LabTendv)
        Me.Grb.Controls.Add(Me.cmbNvTC)
        Me.Grb.Controls.Add(Me.txtQuydoiUSD)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.cmbNghiep_vu)
        Me.Grb.Controls.Add(Me.txtTienQT)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Controls.Add(Me.cmbQuy)
        Me.Grb.Controls.Add(Me.dtpNgay)
        Me.Grb.Controls.Add(Me.txtSotienVND)
        Me.Grb.Controls.Add(Me.txtTygia)
        Me.Grb.Controls.Add(Me.txtSotienUSD)
        Me.Grb.Controls.Add(Me.txtSophieu)
        Me.Grb.Controls.Add(Me.lbnQuy)
        Me.Grb.Controls.Add(Me.Label9)
        Me.Grb.Controls.Add(Me.Label14)
        Me.Grb.Controls.Add(Me.Label17)
        Me.Grb.Controls.Add(Me.lblDonvitc)
        Me.Grb.Controls.Add(Me.Label19)
        Me.Grb.Controls.Add(Me.Label20)
        Me.Grb.Controls.Add(Me.Label25)
        Me.Grb.Controls.Add(Me.txtGhichu)
        Me.Grb.Controls.Add(Me.CmbDonvi)
        Me.Grb.ForeColor = System.Drawing.Color.Blue
        Me.Grb.Location = New System.Drawing.Point(4, 39)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(666, 302)
        Me.Grb.TabIndex = 1
        Me.Grb.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(417, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 14)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "*"
        '
        'txtThucThu
        '
        Me.txtThucThu.EditValue = "0"
        Me.txtThucThu.Location = New System.Drawing.Point(437, 48)
        Me.txtThucThu.Name = "txtThucThu"
        Me.txtThucThu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtThucThu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtThucThu.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtThucThu.Properties.Appearance.Options.UseBackColor = True
        Me.txtThucThu.Properties.Appearance.Options.UseFont = True
        Me.txtThucThu.Properties.Appearance.Options.UseForeColor = True
        Me.txtThucThu.Properties.AutoHeight = False
        Me.txtThucThu.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.txtThucThu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtThucThu.Properties.EditFormat.FormatString = "###,###.00"
        Me.txtThucThu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtThucThu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtThucThu.Size = New System.Drawing.Size(217, 24)
        Me.txtThucThu.TabIndex = 107
        Me.txtThucThu.Tag = "SotienVND"
        '
        'Label_ThucThu
        '
        Me.Label_ThucThu.AutoSize = True
        Me.Label_ThucThu.BackColor = System.Drawing.Color.Transparent
        Me.Label_ThucThu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ThucThu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_ThucThu.Location = New System.Drawing.Point(349, 51)
        Me.Label_ThucThu.Name = "Label_ThucThu"
        Me.Label_ThucThu.Size = New System.Drawing.Size(59, 14)
        Me.Label_ThucThu.TabIndex = 106
        Me.Label_ThucThu.Text = "Thực thu"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(92, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 14)
        Me.Label28.TabIndex = 105
        Me.Label28.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(417, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 14)
        Me.Label27.TabIndex = 104
        Me.Label27.Text = "*"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(417, 110)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 14)
        Me.Label26.TabIndex = 103
        Me.Label26.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(92, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 14)
        Me.Label24.TabIndex = 103
        Me.Label24.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(417, 81)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 14)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(92, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 14)
        Me.Label22.TabIndex = 103
        Me.Label22.Text = "*"
        '
        'txtsophieukham
        '
        Me.txtsophieukham.EditValue = ""
        Me.txtsophieukham.Location = New System.Drawing.Point(111, 136)
        Me.txtsophieukham.Name = "txtsophieukham"
        Me.txtsophieukham.Properties.AutoHeight = False
        Me.txtsophieukham.Size = New System.Drawing.Size(214, 24)
        Me.txtsophieukham.TabIndex = 37
        Me.txtsophieukham.Tag = "Sophieu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 14)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Số hồ sơ"
        '
        'lbldenquy
        '
        Me.lbldenquy.AutoSize = True
        Me.lbldenquy.BackColor = System.Drawing.Color.Transparent
        Me.lbldenquy.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldenquy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldenquy.Location = New System.Drawing.Point(687, 155)
        Me.lbldenquy.Name = "lbldenquy"
        Me.lbldenquy.Size = New System.Drawing.Size(61, 17)
        Me.lbldenquy.TabIndex = 28
        Me.lbldenquy.Text = "Đến quỹ"
        Me.lbldenquy.Visible = False
        '
        'cmbdenquy
        '
        Me.cmbdenquy.Location = New System.Drawing.Point(783, 151)
        Me.cmbdenquy.Name = "cmbdenquy"
        Me.cmbdenquy.Properties.AutoHeight = False
        Me.cmbdenquy.Properties.AutoSearchColumnIndex = 1
        Me.cmbdenquy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbdenquy.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Maquy", "Mã quỹ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tenquy", "Tên quỹ", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbdenquy.Properties.NullText = ""
        Me.cmbdenquy.Properties.PopupWidth = 300
        Me.cmbdenquy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbdenquy.Size = New System.Drawing.Size(209, 24)
        Me.cmbdenquy.TabIndex = 29
        Me.cmbdenquy.Tag = "Maquy"
        Me.cmbdenquy.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NV Lập phiếu"
        '
        'CmbNVBH
        '
        Me.CmbNVBH.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.CmbNVBH.Location = New System.Drawing.Point(111, 106)
        Me.CmbNVBH.Name = "CmbNVBH"
        Me.CmbNVBH.Properties.AutoHeight = False
        Me.CmbNVBH.Properties.AutoSearchColumnIndex = 1
        Me.CmbNVBH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbNVBH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Hoten")})
        Me.CmbNVBH.Properties.NullText = ""
        Me.CmbNVBH.Properties.PopupSizeable = False
        Me.CmbNVBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbNVBH.ShowToolTips = False
        Me.CmbNVBH.Size = New System.Drawing.Size(214, 24)
        Me.CmbNVBH.TabIndex = 9
        Me.CmbNVBH.Tag = "Nguoinhap"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(349, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 14)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Người TC"
        '
        'LabTendv
        '
        Me.LabTendv.AllowDrop = True
        Me.LabTendv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabTendv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTendv.ForeColor = System.Drawing.Color.Blue
        Me.LabTendv.Location = New System.Drawing.Point(439, 133)
        Me.LabTendv.Name = "LabTendv"
        Me.LabTendv.Size = New System.Drawing.Size(215, 24)
        Me.LabTendv.TabIndex = 35
        Me.LabTendv.Visible = False
        '
        'cmbNvTC
        '
        Me.cmbNvTC.Location = New System.Drawing.Point(437, 77)
        Me.cmbNvTC.Name = "cmbNvTC"
        Me.cmbNvTC.Properties.AutoHeight = False
        Me.cmbNvTC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNvTC.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hoten", "Họ tên", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbNvTC.Properties.DisplayMember = "Hoten"
        Me.cmbNvTC.Properties.NullText = ""
        Me.cmbNvTC.Properties.PopupWidth = 250
        Me.cmbNvTC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNvTC.Properties.ValueMember = "Username"
        Me.cmbNvTC.Size = New System.Drawing.Size(217, 24)
        Me.cmbNvTC.TabIndex = 7
        Me.cmbNvTC.Tag = "NvTC"
        '
        'txtQuydoiUSD
        '
        Me.txtQuydoiUSD.EditValue = "0"
        Me.txtQuydoiUSD.Location = New System.Drawing.Point(783, 122)
        Me.txtQuydoiUSD.Name = "txtQuydoiUSD"
        Me.txtQuydoiUSD.Properties.AutoHeight = False
        Me.txtQuydoiUSD.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.txtQuydoiUSD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQuydoiUSD.Properties.EditFormat.FormatString = "###,###.00"
        Me.txtQuydoiUSD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQuydoiUSD.Properties.ReadOnly = True
        Me.txtQuydoiUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtQuydoiUSD.Size = New System.Drawing.Size(60, 24)
        Me.txtQuydoiUSD.TabIndex = 25
        Me.txtQuydoiUSD.Tag = "SotienVND"
        Me.txtQuydoiUSD.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(687, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Quy đổi"
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nghiệp vụ"
        '
        'cmbNghiep_vu
        '
        Me.cmbNghiep_vu.Location = New System.Drawing.Point(111, 76)
        Me.cmbNghiep_vu.Name = "cmbNghiep_vu"
        Me.cmbNghiep_vu.Properties.AutoHeight = False
        Me.cmbNghiep_vu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNghiep_vu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTC", "Mã TC", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiTC", "Tên loại", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbNghiep_vu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cmbNghiep_vu.Properties.NullText = ""
        Me.cmbNghiep_vu.Properties.PopupWidth = 250
        Me.cmbNghiep_vu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNghiep_vu.Size = New System.Drawing.Size(214, 24)
        Me.cmbNghiep_vu.TabIndex = 5
        Me.cmbNghiep_vu.Tag = "MaTC"
        '
        'txtTienQT
        '
        Me.txtTienQT.EditValue = "0"
        Me.txtTienQT.Location = New System.Drawing.Point(932, 122)
        Me.txtTienQT.Name = "txtTienQT"
        Me.txtTienQT.Properties.AutoHeight = False
        Me.txtTienQT.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.txtTienQT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTienQT.Properties.EditFormat.FormatString = "###,###.00"
        Me.txtTienQT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTienQT.Properties.ReadOnly = True
        Me.txtTienQT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTienQT.Size = New System.Drawing.Size(60, 24)
        Me.txtTienQT.TabIndex = 27
        Me.txtTienQT.Tag = "quydoi"
        Me.txtTienQT.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(858, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Giá trị QT"
        Me.Label2.Visible = False
        '
        'cmbQuy
        '
        Me.cmbQuy.Location = New System.Drawing.Point(437, 106)
        Me.cmbQuy.Name = "cmbQuy"
        Me.cmbQuy.Properties.AutoHeight = False
        Me.cmbQuy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuy.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Maquy", "Mã quỹ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tenquy", "Tên quỹ", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbQuy.Properties.NullText = ""
        Me.cmbQuy.Properties.PopupWidth = 300
        Me.cmbQuy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbQuy.Size = New System.Drawing.Size(217, 24)
        Me.cmbQuy.TabIndex = 11
        Me.cmbQuy.Tag = "Maquy"
        '
        'dtpNgay
        '
        Me.dtpNgay.EditValue = New Date(2005, 4, 5, 0, 0, 0, 0)
        Me.dtpNgay.Location = New System.Drawing.Point(111, 16)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay.Properties.Appearance.Options.UseFont = True
        Me.dtpNgay.Properties.AutoHeight = False
        Me.dtpNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpNgay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpNgay.Size = New System.Drawing.Size(123, 24)
        Me.dtpNgay.TabIndex = 2
        Me.dtpNgay.Tag = "Ngay"
        '
        'txtSotienVND
        '
        Me.txtSotienVND.EditValue = "0"
        Me.txtSotienVND.Location = New System.Drawing.Point(437, 19)
        Me.txtSotienVND.Name = "txtSotienVND"
        Me.txtSotienVND.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSotienVND.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtSotienVND.Properties.Appearance.Options.UseFont = True
        Me.txtSotienVND.Properties.Appearance.Options.UseForeColor = True
        Me.txtSotienVND.Properties.AutoHeight = False
        Me.txtSotienVND.Properties.DisplayFormat.FormatString = "###,###.00"
        Me.txtSotienVND.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSotienVND.Properties.EditFormat.FormatString = "###,###.00"
        Me.txtSotienVND.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSotienVND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSotienVND.Size = New System.Drawing.Size(218, 24)
        Me.txtSotienVND.TabIndex = 19
        Me.txtSotienVND.Tag = "SotienVND"
        '
        'txtTygia
        '
        Me.txtTygia.EditValue = "1"
        Me.txtTygia.Location = New System.Drawing.Point(929, 94)
        Me.txtTygia.Name = "txtTygia"
        Me.txtTygia.Properties.AutoHeight = False
        Me.txtTygia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTygia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTygia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTygia.Size = New System.Drawing.Size(63, 24)
        Me.txtTygia.TabIndex = 23
        Me.txtTygia.Tag = "Tygia"
        Me.txtTygia.Visible = False
        '
        'txtSotienUSD
        '
        Me.txtSotienUSD.EditValue = "0"
        Me.txtSotienUSD.Location = New System.Drawing.Point(783, 94)
        Me.txtSotienUSD.Name = "txtSotienUSD"
        Me.txtSotienUSD.Properties.AutoHeight = False
        Me.txtSotienUSD.Properties.DisplayFormat.FormatString = "###,###.##"
        Me.txtSotienUSD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSotienUSD.Properties.EditFormat.FormatString = "###,###.##"
        Me.txtSotienUSD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSotienUSD.Properties.Mask.ShowPlaceHolders = False
        Me.txtSotienUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSotienUSD.Size = New System.Drawing.Size(60, 24)
        Me.txtSotienUSD.TabIndex = 21
        Me.txtSotienUSD.Tag = "SotienUSD"
        Me.txtSotienUSD.Visible = False
        '
        'txtSophieu
        '
        Me.txtSophieu.EditValue = ""
        Me.txtSophieu.Location = New System.Drawing.Point(111, 46)
        Me.txtSophieu.Name = "txtSophieu"
        Me.txtSophieu.Properties.AutoHeight = False
        Me.txtSophieu.Size = New System.Drawing.Size(123, 24)
        Me.txtSophieu.TabIndex = 3
        Me.txtSophieu.Tag = "Sophieu"
        '
        'lbnQuy
        '
        Me.lbnQuy.AutoSize = True
        Me.lbnQuy.BackColor = System.Drawing.Color.Transparent
        Me.lbnQuy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnQuy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbnQuy.Location = New System.Drawing.Point(349, 109)
        Me.lbnQuy.Name = "lbnQuy"
        Me.lbnQuy.Size = New System.Drawing.Size(29, 14)
        Me.lbnQuy.TabIndex = 10
        Me.lbnQuy.Text = "Quỹ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 14)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Diễn giải"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(858, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Tỷ giá TT"
        Me.Label14.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(8, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 14)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Số phiếu TC"
        '
        'lblDonvitc
        '
        Me.lblDonvitc.AutoSize = True
        Me.lblDonvitc.BackColor = System.Drawing.Color.Transparent
        Me.lblDonvitc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonvitc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDonvitc.Location = New System.Drawing.Point(8, 168)
        Me.lblDonvitc.Name = "lblDonvitc"
        Me.lblDonvitc.Size = New System.Drawing.Size(66, 14)
        Me.lblDonvitc.TabIndex = 12
        Me.lblDonvitc.Text = "Bệnh nhân"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(687, 97)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 17)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Tiền(USD)"
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(8, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 14)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Ngày lập"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(349, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 14)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Tổng tiền"
        '
        'txtGhichu
        '
        Me.txtGhichu.EditValue = ""
        Me.txtGhichu.Location = New System.Drawing.Point(111, 196)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Size = New System.Drawing.Size(544, 87)
        Me.txtGhichu.TabIndex = 17
        Me.txtGhichu.Tag = "Ghichu"
        '
        'CmbDonvi
        '
        Me.CmbDonvi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbDonvi.Location = New System.Drawing.Point(111, 166)
        Me.CmbDonvi.Name = "CmbDonvi"
        Me.CmbDonvi.Properties.AutoHeight = False
        Me.CmbDonvi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbDonvi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CmbDonvi.Properties.NullText = ""
        Me.CmbDonvi.Properties.PopupWidth = 300
        Me.CmbDonvi.Size = New System.Drawing.Size(544, 24)
        Me.CmbDonvi.TabIndex = 13
        Me.CmbDonvi.Tag = "Madv"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(14, 356)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 16
        Me.btnCap_nhat.Text = "&Cập nhật"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(109, 356)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 18
        Me.btnThem.Text = "&Nhập mới"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(489, 356)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 21
        Me.btnXoa.Text = "&Xoá"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(394, 356)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 20
        Me.btnSua.Text = "&Sửa"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(299, 356)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 22
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'btnIn_phieu
        '
        Me.btnIn_phieu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnIn_phieu.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn_phieu.Appearance.Options.UseFont = True
        Me.btnIn_phieu.Appearance.Options.UseForeColor = True
        Me.btnIn_phieu.Location = New System.Drawing.Point(204, 356)
        Me.btnIn_phieu.Name = "btnIn_phieu"
        Me.btnIn_phieu.Size = New System.Drawing.Size(75, 25)
        Me.btnIn_phieu.TabIndex = 17
        Me.btnIn_phieu.Text = "&In phiếu"
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(584, 356)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 19
        Me.btnThoat.Text = "&Thoát"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(674, 37)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "PHIẾU THU TIỀN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPhieuTC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 400)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnIn_phieu)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCap_nhat)
        Me.Controls.Add(Me.Grb)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPhieuTC"
        Me.Text = "PHIẾU THU CHI"
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.txtThucThu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsophieukham.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbdenquy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbNVBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNvTC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuydoiUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNghiep_vu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienQT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbQuy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSotienVND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTygia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSotienUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSophieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGhichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbDonvi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim dtb As DataTable
        Dim strSQL As String
        If (Val(Replace(Me.txtQuydoiUSD.Text, ",", "")) * 0.95 > Val(Replace(Me.txtTienQT.Text, ",", ""))) Or (Val(Replace(Me.txtQuydoiUSD.Text, ",", "")) * 1.05 < Val(Replace(Me.txtTienQT.Text, ",", ""))) Then
            MsgBox("Bạn đã nhập số tiền quyết toán với sai số quá lớn")
        Else
            If CheckValidation() = True Then
                If xetngay() = True Then
                    Dim clsobj As New clsThuchi
                    If blnLoaiphieu = False Then
                        If CheckTon_quy() = False Then Exit Sub
                    End If
                    strSQL = "Select * from Ton_Quy WHERE MaQuy = '" & Me.cmbQuy.EditValue & "' AND Convert(char(10),Ngay,101) ='" & Format(Me.dtpNgay.DateTime, "MM/dd/yyyy") & "'"
                    dts = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing)
                    dtb = dts.Tables(0)
                    If dtb.Rows.Count > 0 Then
                    Else
                        clsobj.TinhTonQuy(CNNQLPHONGKHAM)
                    End If
                    'Thu or chi tien
                    DataUpdate()
                    'update tamung
                    Dim str As String = ""
                    str = "Update Chi_tiet_new set TamUng=1 where IDsophieu='" & txtsophieukham.Text & "'"
                    If dattien = True Then
                        Command_Exc(str, CNNQLPHONGKHAM)
                    End If
                    If thutamung = True Then
                        Dim strTU As String = ""
                        strTU = "Update PHIEUKHAMBENH set KeToanDuyet=2 where SOPHIEU ='" & txtsophieukham.Text & "'"
                        Command_Exc(strTU, CNNQLPHONGKHAM)
                    End If

                    'update ktduyet
                    Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
                    Me.btnIn_phieu.Enabled = True
                    If sky = False Then
                        Me.btnThem.Enabled = True
                        Me.btnIn_phieu.Enabled = True
                        Me.btnThoat.Enabled = True
                        Me.btnSua.Enabled = False
                        Me.btnXoa.Enabled = False
                    Else
                        Me.btnSua.Enabled = False
                        Me.btnXoa.Enabled = False
                        Me.btnThem.Enabled = True
                        Me.btnHuy.Enabled = False
                    End If
                End If
            End If
        End If
        If StypeSUA = True Then
            Me.btnThem.Enabled = True
        Else
            Me.btnThem.Enabled = True
        End If
        Me.btnIn_phieu.Focus()
    End Sub

    Private Sub frmPhieuTC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        Ctrl_QuyenForm(Me)
        If dattien = False Then
            Me.dtpNgay.DateTime = NgayGioServer().Date
        End If
        Khoi_taoForm()
        If IDPhieuTC <> 0 Then
            Load_Data()
            btnIn_phieu.Enabled = True
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Them)
            FormClear()
            Me.dtpNgay.DateTime = Today.Date
            Me.CmbNVBH.EditValue = clsLoginObj.strUsername
            Me.cmbNvTC.EditValue = clsLoginObj.strUsername
            Me.cmbQuy.EditValue = "1TM"
            Me.btnCap_nhat.Enabled = True
            'thu công nợ
            If loaithuchi = "TCN" Then
                cmbNghiep_vu.EditValue = loaithuchi
                CmbDonvi.EditValue = mabn
                txtThucThu.Text = thucthu
            End If
            If isHiden Then
                txtSotienVND.Enabled = False
            End If
        End If
        If blnDelete = True Then
            Me.btnSua.Enabled = False
            Me.btnXoa.Enabled = False
        End If
        Me.Label3.Enabled = True
    End Sub
    Private Sub Khoi_taoForm()
        Dim dtbTkNo As New DataTable
        Dim dtbTkCo As New DataTable
        Dim dtbTiente As New DataTable
        Dim clsobjTC As New clsThuchi
        Dim dtbtygia As DataTable
        dts = BusinessLogic.Data.GetDataset("select tygia from phieu_thu_chi where idsophieu=(select Max(idsophieu) from phieu_thu_chi )")
        dtbtygia = dts.Tables(0)
        If dtbtygia.Rows.Count > 0 Then
            Me.txtTygia.Text = dtbtygia.Rows(0)("tygia")
        Else
            Me.txtTygia.Text = "1"
        End If
        Load_ComboBox("SELECT Mabn[Mã],HOTENBN[Họ tên] From HOSOBN union all SELECT Madv[Mã],tendv[Họ tên] From Donvi", Me.CmbDonvi, CNNQLPHONGKHAM)
        If IDPhieuTC <> 0 Then
            If Me.blnTiengui = False Then
                Load_ComboBox("SELECT Maquy,Tenquy From CTQuy ", Me.cmbQuy, CNNQLPHONGKHAM)
            Else
                Load_ComboBox("SELECT Maquy,Tenquy From CTQuy  order by Tenquy", Me.cmbQuy, CNNQLPHONGKHAM)
            End If
        Else
            If Me.blnTiengui = False Then
                Load_ComboBox("SELECT Maquy,Tenquy From CTQuy where maquy = '1TM'  ", Me.cmbQuy, CNNQLPHONGKHAM)
            Else
                Load_ComboBox("SELECT Maquy,Tenquy From CTQuy where  maquy <> '1TM' order by Tenquy", Me.cmbQuy, CNNQLPHONGKHAM)
            End If
        End If
        If blnLoaiphieu = True Then
            If IDPhieuTC <> 0 Then
                Load_ComboBox("SELECT MaTC,TenLoaiTC From DM_Thu_Chi Where loai=1", Me.cmbNghiep_vu, CNNQLPHONGKHAM)
            Else
                Load_ComboBox("SELECT MaTC,TenLoaiTC From DM_Thu_Chi Where loai=1 AND MaTC <> 'TDU' AND MaTC <> 'TDT'", Me.cmbNghiep_vu, CNNQLPHONGKHAM)
            End If
        Else
            Load_ComboBox("SELECT MaTC,TenLoaiTC From DM_Thu_Chi Where Loai=0", Me.cmbNghiep_vu, CNNQLPHONGKHAM)
            Load_ComboBox("SELECT Maquy,Tenquy From CTQuy where Maquy <>'" & Me.cmbQuy.EditValue & "' order by Tenquy", Me.cmbdenquy, CNNQLPHONGKHAM)
        End If
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.cmbNvTC, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung order by Hoten", Me.CmbNVBH, CNNQLPHONGKHAM)
        Me.CmbNVBH.EditValue = clsLoginObj.strUsername
        Me.cmbNvTC.EditValue = clsLoginObj.strUsername
        Me.CmbNVBH.Enabled = False
        If IDPhieuTC <> 0 Then
        Else
            If Me.blnTiengui = False Then
                Me.txtSophieu.Text = clsobjTC.Lay_So_phieu(blnLoaiphieu)
            Else
                Me.txtSophieu.Text = clsobjTC.Lay_So_phieu1(blnLoaiphieu)
            End If
            IDPhieuTC = 0
        End If
        If blnLoaiphieu Then
            Label_ThucThu.Text = "Thực thu"
        Else
            Label_ThucThu.Text = "Thực chi"
        End If
    End Sub

    Private Sub DataUpdate()
        Dim Bolean As Boolean = False
        Dim strSQL As String
        Dim int_i As Integer
        Dim dtbCTTC As New DataTable
        Dim int_IDSophieu As Integer = 0
        Dim int_SophieuMoi As Integer = 0
        Dim IndexIDSophieu As Integer = 0
        Dim int_IDSophieuCDU As Integer = 0
        Dim clsobjTC As New clsThuchi
        Dim dtv As New DataView
        Dim Ghichu As String
        If blnEdit <> True Then
            If Me.cmbNghiep_vu.EditValue = "CDT" Then
                If Chidoitien() = False Then
                    Exit Sub
                End If
            End If
            If clsobjTC.ThemPhieuTC(IIf(Me.txtSotienVND.Text.Trim() <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), IIf(Me.txtThucThu.Text.Trim() <> "", Double.Parse(Chuanhoa("0" + Me.txtThucThu.Text)), 0), Me.txtSophieu.Text, blnLoaiphieu, blnTiengui, Me.cmbNghiep_vu.EditValue, Me.dtpNgay.EditValue, Me.cmbQuy.EditValue, "0", Me.CmbDonvi.EditValue, IIf(Me.txtSotienUSD.Text <> "", Chuanhoa(Me.txtSotienUSD.Text), 0), IIf(Me.txtTygia.Text <> "", Chuanhoa(Me.txtTygia.Text), 0), IIf(txtTienQT.Text <> "", (Me.txtTienQT.Text), 0), IIf(Me.txtSotienVND.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), Me.txtGhichu.Text, 0, 0, Me.CmbNVBH.EditValue, Me.cmbNvTC.EditValue, IIf(Me.txtsophieukham.Text <> "", Me.txtsophieukham.Text, 0), int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM) = True Then
                Me.txtSophieu.Text = int_SophieuMoi
            End If
            If Me.cmbNghiep_vu.EditValue = "CDU" Then
                If Me.blnTiengui = False Then
                    Ghichu = "Phiếu chi tiền mặt tương ứng:" & Me.txtSophieu.Text & ""
                Else
                    Ghichu = "Phiếu chi tiền gửi tương ứng :" & Me.txtSophieu.Text & ""
                End If
                If Me.cmbdenquy.EditValue = "1TM" Then
                    clsobjTC.ThemPhieuTC(IIf(Me.txtSotienVND.Text.Trim() <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), IIf(Me.txtThucThu.Text.Trim() <> "", Double.Parse("0" + Chuanhoa(Me.txtThucThu.Text)), 0), clsobjTC.Lay_So_phieu(IIf(blnLoaiphieu = True, False, True)), IIf(blnLoaiphieu = False, True, False), False, IIf(Me.cmbNghiep_vu.EditValue = "CDU", "TDU", Me.cmbNghiep_vu.EditValue), Me.dtpNgay.EditValue, Me.cmbdenquy.EditValue, 0, Me.CmbDonvi.EditValue, IIf(Me.txtSotienUSD.Text <> 0, Double.Parse("0" + Chuanhoa(Me.txtSotienUSD.Text)), 0), IIf(Me.txtTygia.Text <> 0, Chuanhoa(Me.txtTygia.Text), 0), IIf(txtTienQT.Text <> 0, Double.Parse("0" + (Me.txtTienQT.Text)), 0), IIf(Me.txtSotienVND.Text <> 0, Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), Ghichu, 0, 0, Me.CmbNVBH.EditValue, Me.cmbNvTC.EditValue, IIf(Me.txtsophieukham.Text <> "", Me.txtsophieukham.Text, 0), int_IDSophieuCDU, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
                Else
                    clsobjTC.ThemPhieuTC(IIf(Me.txtSotienVND.Text.Trim() <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), IIf(Me.txtThucThu.Text.Trim() <> "", Double.Parse("0" + Chuanhoa(Me.txtThucThu.Text)), 0), clsobjTC.Lay_So_phieu1(IIf(blnLoaiphieu = True, False, True)), IIf(blnLoaiphieu = False, True, False), True, IIf(Me.cmbNghiep_vu.EditValue = "CDU", "TDU", Me.cmbNghiep_vu.EditValue), Me.dtpNgay.EditValue, Me.cmbdenquy.EditValue, 0, Me.CmbDonvi.EditValue, IIf(Me.txtSotienUSD.Text <> 0, Double.Parse("0" + Chuanhoa(Me.txtSotienUSD.Text)), 0), IIf(Me.txtTygia.Text <> 0, Chuanhoa(Me.txtTygia.Text), 0), IIf(txtTienQT.Text <> 0, Double.Parse("0" + (Me.txtTienQT.Text)), 0), IIf(Me.txtSotienVND.Text <> 0, Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), Ghichu, 0, 0, Me.CmbNVBH.EditValue, Me.cmbNvTC.EditValue, IIf(Me.txtsophieukham.Text <> "", Me.txtsophieukham.Text, 0), int_IDSophieuCDU, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
                End If
            End If
            If Me.cmbNghiep_vu.EditValue = "CDT" Then
                If Me.blnTiengui = False Then
                    Ghichu = "Phiếu chi tiền mặt tương ứng:" & Me.txtSophieu.Text & ""
                Else
                    Ghichu = "Phiếu chi tiền gửi tương ứng :" & Me.txtSophieu.Text & ""
                End If
                If Me.cmbdenquy.EditValue = "1TM" Then
                    clsobjTC.ThemPhieuTC(IIf(Me.txtSotienVND.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), IIf(Me.txtThucThu.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtThucThu.Text)), 0), clsobjTC.Lay_So_phieu(IIf(blnLoaiphieu = True, False, True)), IIf(blnLoaiphieu = False, True, False), False, IIf(Me.cmbNghiep_vu.EditValue = "CDT", "TDT", Me.cmbNghiep_vu.EditValue), Me.dtpNgay.EditValue, Me.cmbdenquy.EditValue, 0, Me.CmbDonvi.EditValue, fSotienUSD, IIf(Me.txtTygia.Text <> "", Chuanhoa(Me.txtTygia.Text), 0), IIf(txtTienQT.Text <> 0, (Me.txtTienQT.Text), 0), fSotienVND, Ghichu, 0, 0, Me.CmbNVBH.EditValue, Me.cmbNvTC.EditValue, Me.txtsophieukham.Text, int_IDSophieuCDU, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
                Else
                    clsobjTC.ThemPhieuTC(IIf(Me.txtSotienVND.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), IIf(Me.txtThucThu.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtThucThu.Text)), 0), clsobjTC.Lay_So_phieu1(IIf(blnLoaiphieu = True, False, True)), IIf(blnLoaiphieu = False, True, False), True, IIf(Me.cmbNghiep_vu.EditValue = "CDT", "TDT", Me.cmbNghiep_vu.EditValue), Me.dtpNgay.EditValue, Me.cmbdenquy.EditValue, 0, Me.CmbDonvi.EditValue, fSotienUSD, IIf(Me.txtTygia.Text <> "", Chuanhoa(Me.txtTygia.Text), 0), IIf(txtTienQT.Text <> 0, (Me.txtTienQT.Text), 0), fSotienVND, Ghichu, 0, 0, Me.CmbNVBH.EditValue, Me.cmbNvTC.EditValue, Me.txtsophieukham.Text, int_IDSophieuCDU, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
                End If
            End If
        Else
            If Me.dtpNgay.DateTime.ToShortDateString <> SuaNgay.ToShortDateString Or Me.cmbQuy.EditValue <> strMaquy Then
                'Truong hop sua ngay thu chi
                clsobjTC.Xoa_Phieu(IDPhieuTC, blnLoaiphieu, SuaNgay, strMaquy, CNNQLPHONGKHAM)
                strSQL = "Delete Phieu_thu_chi WHERE IDSophieu =" & IDPhieuTC
                Command_Exc(strSQL, CNNQLPHONGKHAM)
                clsobjTC.ThemPhieuTC(IIf(Me.txtSotienVND.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), IIf(Me.txtThucThu.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtThucThu.Text)), 0), Me.txtSophieu.Text, blnLoaiphieu, blnTiengui, Me.cmbNghiep_vu.EditValue, Me.dtpNgay.EditValue, Me.cmbQuy.EditValue, 0, Me.CmbDonvi.EditValue, IIf(Me.txtSotienUSD.Text <> 0, Chuanhoa(Me.txtSotienUSD.Text), 0), IIf(Me.txtTygia.Text <> "", Chuanhoa(Me.txtTygia.Text), 0), IIf(txtTienQT.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtTienQT.Text)), 0), IIf(Me.txtSotienVND.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), Me.txtGhichu.Text, 0, 0, Me.CmbNVBH.EditValue, Me.cmbNvTC.EditValue, Me.txtsophieukham.Text, int_IDSophieu, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
            Else
                clsobjTC.ThemPhieuTC(IIf(Me.txtSotienVND.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), IIf(Me.txtThucThu.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtThucThu.Text)), 0), Me.txtSophieu.Text, blnLoaiphieu, blnTiengui, Me.cmbNghiep_vu.EditValue, Me.dtpNgay.DateTime.ToString("MM/dd/yyyy"), Me.cmbQuy.EditValue, "0", Me.CmbDonvi.EditValue, IIf(IsNumeric(txtSotienUSD.Text), Chuanhoa(Me.txtSotienUSD.Text), 0), Chuanhoa(Me.txtTygia.Text), IIf(txtTienQT.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtTienQT.Text)), 0), IIf(Me.txtSotienVND.Text <> "", Double.Parse("0" + Chuanhoa(Me.txtSotienVND.Text)), 0), Me.txtGhichu.Text, 1, 0, Me.CmbNVBH.EditValue, Me.cmbNvTC.EditValue, Me.txtsophieukham.Text, IDPhieuTC, int_SophieuMoi, IndexIDSophieu, CNNQLPHONGKHAM)
            End If
        End If
        If IndexIDSophieu <> 0 Then
            IDPhieuTC = IndexIDSophieu
        End If
        dtbCTTC = dtv.Table
        If Not dtbCTTC Is Nothing Then
            For int_i = 0 To dtbCTTC.Rows.Count - 1
                dtbCTTC.Rows(int_i)("IDPhieuTC") = IDPhieuTC
            Next
        End If
        If Me.dattien = True Then
            Command_Exc("Update phieukhambenh set dattien=1 where sophieu='" & Me.txtsophieukham.Text & "'", CNNQLPHONGKHAM)
        End If
    End Sub

    Private Sub Load_Data()
        Me.txtTienQT.Text = ""
        Dim strSql As String
        Dim dtbPhieuTC As New DataTable
        strSql = "SELECT * FROM Phieu_thu_chi WHERE IDSophieu=" & IDPhieuTC & ""
        dts = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing)
        dtbPXN = dts.Tables(0)
        If dtbPXN.Rows.Count > 0 Then
            Dim row As DataRow
            row = dtbPXN.Rows(0)
            blnLoaiphieu = row("Loaiphieu")
            blnTiengui = row("Tiengui")
            Me.CmbDonvi.EditValue = row(Me.CmbDonvi.Tag)
            Madv = row(Me.CmbDonvi.Tag)
            Me.CmbNVBH.EditValue = row(Me.CmbNVBH.Tag)
            Me.cmbNghiep_vu.EditValue = row(Me.cmbNghiep_vu.Tag)
            Me.cmbQuy.EditValue = row(Me.cmbQuy.Tag)
            strMaquy = row(Me.cmbQuy.Tag)
            Me.cmbNvTC.EditValue = row(Me.cmbNvTC.Tag)
            Me.txtGhichu.Text = row(Me.txtGhichu.Tag)
            Me.txtSophieu.Text = row(Me.txtSophieu.Tag)
            Me.txtSotienUSD.Text = row(Me.txtSotienUSD.Tag)
            Me.SotienUSD = row(Me.txtSotienUSD.Tag)
            If Not row("ThucThu") Is DBNull.Value Then
                Me.txtThucThu.Text = row("ThucThu")
            Else
                Me.txtThucThu.Text = "0"
            End If
            If Not row("Sophieukham") Is DBNull.Value Then
                Me.txtsophieukham.Text = row("Sophieukham")
            Else
                Me.txtsophieukham.Text = "0"
            End If
            If IsNumeric(txtSotienUSD.EditValue) Then
                If Me.txtSotienUSD.Text <> "0" Then
                    txtSotienUSD.EditValue = Format(Val(Replace(txtSotienUSD.EditValue, ",", "")), "###,###")
                End If
            End If
            If IsNumeric(txtThucThu.EditValue) Then
                If Me.txtThucThu.Text <> "0" Then
                    txtThucThu.EditValue = Format(Val(Replace(txtThucThu.EditValue, ",", "")), "###,###")
                End If
            End If
            Me.txtSotienVND.Text = row(Me.txtSotienVND.Tag)
            Me.SotienVND = row(Me.txtSotienVND.Tag)
            If IsNumeric(txtSotienVND.EditValue) Then
                txtSotienVND.EditValue = Format(Val(Replace(txtSotienVND.EditValue, ",", "")), "###,###")
            End If
            Me.txtTygia.Text = row(Me.txtTygia.Tag)
            If IsNumeric(Me.txtTygia.EditValue) Then
                Me.txtTygia.EditValue = Format(Val(Replace(Me.txtTygia.EditValue, ",", "")), "###,###")
            End If
            Me.dtpNgay.DateTime = row(Me.dtpNgay.Tag)
            SuaNgay = row(Me.dtpNgay.Tag)
            Me.txtTienQT.EditValue = row("Quydoi")
            If IsNumeric(txtTienQT.EditValue) Then
                txtTienQT.EditValue = Format(Val(Replace(txtTienQT.EditValue, ",", "")), "###,###")
            End If

        End If
    End Sub

    Private Function CheckValidation() As Boolean
        'Duong sua ham CheckValidation ngay 28/9/2005
        CheckValidation = True
        If Me.cmbNvTC.EditValue = "" Then
            CheckValidation = False
            Me.ErrPro.SetError(Me.cmbNvTC, "Dữ liệu không được để trống")
            Me.ErrPro.SetIconAlignment(Me.cmbNvTC, ErrorIconAlignment.BottomRight)
            Me.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If Me.CmbNVBH.EditValue = "" Then
            CheckValidation = False
            Me.ErrPro.SetError(Me.CmbNVBH, "Dữ liệu không được để trống")
            Me.ErrPro.SetIconAlignment(Me.CmbNVBH, ErrorIconAlignment.BottomRight)
            Me.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If Me.cmbQuy.EditValue = "" Then
            CheckValidation = False
            Me.ErrPro.SetError(Me.cmbQuy, "Dữ liệu không được để trống")
            Me.ErrPro.SetIconAlignment(Me.cmbQuy, ErrorIconAlignment.BottomRight)
            Me.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If Me.cmbdenquy.Visible = True Then
            If Me.cmbdenquy.EditValue = "" Then
                CheckValidation = False
                Me.ErrPro.SetError(Me.cmbdenquy, "Dữ liệu không được để trống")
                Me.ErrPro.SetIconAlignment(Me.cmbQuy, ErrorIconAlignment.BottomRight)
                Me.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
            End If
        End If
        If Me.CmbDonvi.EditValue = "" Then
            CheckValidation = False
            Me.ErrPro.SetError(Me.CmbDonvi, "Dữ liệu không được để trống")
            Me.ErrPro.SetIconAlignment(Me.CmbDonvi, ErrorIconAlignment.BottomRight)
            Me.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If
        If Me.cmbNghiep_vu.EditValue = "" Then
            CheckValidation = False
            Me.ErrPro.SetError(Me.cmbNghiep_vu, "Dữ liệu không được để trống")
            Me.ErrPro.SetIconAlignment(Me.cmbNghiep_vu, ErrorIconAlignment.BottomRight)
            Me.ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        End If

    End Function

    Private Sub txtTygia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTygia.EditValueChanged
        If IsNumeric(Me.txtSotienUSD.EditValue) And IsNumeric(Me.txtTygia.EditValue) Then
            Me.txtQuydoiUSD.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")) + (Val(Replace(Me.txtSotienUSD.EditValue, ",", "")) * Val(Replace(Me.txtTygia.EditValue, ",", ""))), "###,###")
            Me.txtTienQT.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")) + (Val(Replace(Me.txtSotienUSD.EditValue, ",", "")) * Val(Replace(Me.txtTygia.EditValue, ",", ""))), "###,###")
        Else
            Me.txtQuydoiUSD.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")), "###,###")
            Me.txtTienQT.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")), "###,###")
        End If
        If IsNumeric(txtSotienVND.EditValue) Then
            txtSotienVND.Text = Format(Val(Replace(txtSotienVND.Text, ",", "")), "###,###")
        End If
        If IsNumeric(txtQuydoiUSD.EditValue) Then
            txtQuydoiUSD.EditValue = Format(Val(Replace(txtQuydoiUSD.EditValue, ",", "")), "###,###")
        End If
        If IsNumeric(txtQuydoiUSD.EditValue) Then
            txtTienQT.EditValue = Format(Val(Replace(txtTienQT.EditValue, ",", "")), "###,###")
        End If
    End Sub

    Private Sub txtSotienVND_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSotienVND.EditValueChanged
        If IsNumeric(Me.txtSotienUSD.EditValue) And IsNumeric(Me.txtTygia.EditValue) Then
            Me.txtQuydoiUSD.EditValue = Format(Val(Replace(Replace(Me.txtSotienVND.EditValue, ",", ""), ".", "")) + (Val(Replace(Replace(Me.txtSotienUSD.EditValue, ",", ""), ".", "")) * Val(Replace(Replace(Me.txtTygia.EditValue, ",", ""), ".", ""))), "###,###")
            Me.txtTienQT.EditValue = Format(Val(Replace(Replace(Me.txtSotienVND.EditValue, ",", ""), ".", "")) + (Val(Replace(Replace(Me.txtSotienUSD.EditValue, ",", ""), ".", "")) * Val(Replace(Replace(Me.txtTygia.EditValue, ",", ""), ".", ""))), "###,###")
        Else
            Me.txtQuydoiUSD.EditValue = Format(Val(Replace(Replace(Me.txtSotienVND.EditValue, ",", ""), ".", "")), "###,###")
            Me.txtTienQT.EditValue = Format(Val(Replace(Replace(Me.txtSotienVND.EditValue, ",", ""), ".", "")), "###,###")
        End If
    End Sub

    Private Sub btnIn_phieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_phieu.Click
        Dim frm As New frmShowReport
        Dim CatChuoi As String
        Dim CatChuoiVND As String
        CatChuoi = Replace(Replace(Me.txtSotienUSD.Text, ",", ""), ".", "")
        CatChuoiVND = Replace(Replace(Me.txtThucThu.Text, ",", ""), ".", "")
        Dim arrCatChuoi(2) As String
        Dim arrCatchuoiVND(2) As String
        arrCatChuoi = Split(CatChuoi, ".", -1, CompareMethod.Text)
        arrCatchuoiVND = Split(CatChuoiVND, ".", -1, CompareMethod.Text)
        If Me.cmbdenquy.Visible = True Then
            frm.IDPhieuTC = CStr(IDPhieuTC - 1)
        Else
            frm.IDPhieuTC = CStr(IDPhieuTC)
        End If
        If UBound(arrCatChuoi) > 0 Then
            If arrCatChuoi(1) = 0 Then
                frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & "Không" & Space(1) & "Cent"
            Else
                frm.Bangchu = DoiSo(arrCatChuoi(0)) & Space(3) & Mid(DoiSo(arrCatChuoi(1)), 1, Len(DoiSo(arrCatChuoi(1))) - 4) & "Cent"
            End If

        Else
            If CatChuoi = "0" Or CatChuoi = "" Then
                frm.Bangchu = ""
            Else
                frm.Bangchu = DoiSo(CatChuoi)
            End If
        End If
        If UBound(arrCatchuoiVND) > 0 Then
            frm.BangchuVND = Mid(DoiSo(arrCatchuoiVND(0)), 1, Len(DoiSo(arrCatchuoiVND(0))) - 4) & "đồng"
        Else
            If CatChuoiVND = "0" Or CatChuoiVND = "" Then
                frm.BangchuVND = ""
            Else
                frm.BangchuVND = Mid(DoiSo(CatChuoiVND), 1, Len(DoiSo(arrCatchuoiVND(0))) - 4) & "đồng"
            End If
        End If
        frm.strBC = frmShowReport.TenBc.PhieuTC
        If blnTiengui = True Then
            If blnLoaiphieu = True Then
                frm.LoaiPhieuTC = "TN"
                frm.Title = "PHIẾU THU TIỀN GỬI"
                frm.NguoiTC = "Người nộp"
                frm.donvi = "Họ tên BN:"
            Else
                frm.LoaiPhieuTC = "CN"
                frm.Title = "PHIẾU CHI TIỀN GỬI"
                frm.NguoiTC = "Người nhận"
                frm.donvi = "Đơn vị:"
            End If
        Else
            If blnLoaiphieu = True Then
                frm.LoaiPhieuTC = "T"
                frm.Title = "PHIẾU THU TIỀN MẶT"
                frm.NguoiTC = "Người nộp"
                frm.donvi = "Họ tên BN:"
            Else
                frm.LoaiPhieuTC = "C"
                frm.Title = "PHIẾU CHI TIỀN MẶT"
                frm.NguoiTC = "Người nhận"
                frm.donvi = "Đơn vị:"
            End If
        End If
        Dim ifo_donvi As DataTable = BusinessLogic.Data.GetDataset("DS_BenhNhan_KhachHang", Data.CommandType.StoredProcedure, New List(Of String) From {"mabn"}, New List(Of Object) From {CmbDonvi.EditValue}).Tables(0)
        If ifo_donvi.Rows.Count > 0 Then
            If Not ifo_donvi.Rows(0)("diachi") Is DBNull.Value Then
                frm.diachi = ifo_donvi.Rows(0)("diachi")
            Else
                frm.diachi = ""
            End If
            If Not ifo_donvi.Rows(0)("dienthoai") Is DBNull.Value Then
                frm.dienthoai = ifo_donvi.Rows(0)("dienthoai")
            Else
                frm.dienthoai = ""
            End If
        Else
            frm.diachi = ""
            frm.dienthoai = ""
        End If
        frm.Show()
    End Sub

    Private Sub cmbNghiep_vu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNghiep_vu.GotFocus
        If IDPhieuTC = 0 Then
            If foundClick = False Then
                cmbNghiep_vu.ShowPopup()
            Else
                foundClick = False
            End If
        Else
            foundClick = False
        End If
    End Sub

    Private Sub CmbDonvi_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If foundClick = False Then
            CmbDonvi.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    Private Sub cmbNvTC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNvTC.GotFocus
        If foundClick = False Then
            cmbNvTC.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    Private Sub cmbQuy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbQuy.GotFocus
        If foundClick = False Then
            cmbQuy.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    'Private Sub CmbNVBH_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNVBH.GotFocus
    '    If foundClick = False Then
    '        CmbNVBH.ShowPopup()
    '    Else
    '        foundClick = False
    '    End If
    'End Sub

    Private Sub cmbNghiep_vu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNghiep_vu.Click, CmbDonvi.Click, cmbQuy.Click, cmbNvTC.Click, CmbNVBH.Click, dtpNgay.Click
        If foundClick = False Then
            sender.showpopup()
        Else
            foundClick = False
        End If
    End Sub

    Private Sub cmbdenquy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdenquy.Click
        If foundClick = False Then
            Me.cmbdenquy.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    Public Function CheckTon_quy() As Boolean
        Dim strsQL As String
        Dim dtbTon_quy As New DataTable
        CheckTon_quy = True
        strsQL = "SELECT * FROM Ton_quy WHERE Maquy='" & Me.cmbQuy.EditValue & "' And ID=(SELECT MAX(ID) FROM Ton_quy WHERE Maquy='" & Me.cmbQuy.EditValue & "' )"
        dts = BusinessLogic.Data.GetDataset(strsQL, CommandType.Text, Nothing, Nothing)
        dtbTon_quy = dts.Tables(0)
        If dtbTon_quy.Rows.Count > 0 Then
            If (dtbTon_quy.Rows(0)("ToncuoiVND") >= 0) Then
                If IDPhieuTC <> 0 Then
                    If Val(dtbTon_quy.Rows(0)("ToncuoiVND")) + Val(Replace(Me.SotienVND, ",", "")) < Val(IIf(Me.txtSotienVND.Text = "", 0, Replace(Me.txtSotienVND.Text, ",", ""))) Then
                        MsgBox("Số tiền VND trong quỹ không đủ để chi")
                        Me.txtSotienVND.Text = dtbTon_quy.Rows(0)("ToncuoiVND") + Val(IIf(Me.SotienVND = "", 0, Replace(Me.SotienVND, ",", "")))
                        Return False
                    End If
                Else
                    If Val(dtbTon_quy.Rows(0)("ToncuoiVND")) < Val(IIf(Me.txtSotienVND.Text = "", 0, Replace(Me.txtSotienVND.Text, ",", ""))) Then
                        MsgBox("Số tiền VND trong quỹ không đủ để chi")
                        Me.txtSotienVND.Text = dtbTon_quy.Rows(0)("ToncuoiVND")
                        Return False
                    End If
                End If
            Else
                MsgBox("Quỹ không có tiền VND hoặc số tiền bị âm")
            End If
            If (dtbTon_quy.Rows(0)("ToncuoiUSD") >= 0) Then
                If IDPhieuTC <> 0 Then
                    If dtbTon_quy.Rows(0)("ToncuoiUSD") + Val(Replace(Me.SotienUSD, ",", "")) < Val(IIf(Me.txtSotienUSD.Text = "", 0, Replace(Me.txtSotienUSD.Text, ",", ""))) Then
                        MsgBox("Số tiền USD trong quỹ không đủ để chi")
                        Me.txtSotienUSD.Text = dtbTon_quy.Rows(0)("ToncuoiUSD") + Val(IIf(Me.SotienUSD = "", 0, Replace(Me.SotienUSD, ",", "")))
                        Return False
                    End If
                Else
                    If dtbTon_quy.Rows(0)("ToncuoiUSD") < Val(IIf(Me.txtSotienUSD.Text = "", 0, Replace(Me.txtSotienUSD.Text, ",", ""))) Then
                        MsgBox("Số tiền USD trong quỹ không đủ để chi")
                        Me.txtSotienUSD.Text = dtbTon_quy.Rows(0)("ToncuoiUSD")
                        Return False
                    End If
                End If
            Else
                MsgBox("Quỹ không có tiền USD hoặc số tiền bị âm")
            End If
        Else
            MsgBox("Số tiền trong quỹ không đủ để chi")
            Return False
        End If
    End Function

    Private Sub CmbDonvi_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbDonvi.KeyUp
        'If e.KeyCode = Keys.F3 Then
        '    Dim frmKh As New frmThemDonVi
        '    frmKh.Show()
        '    If frmKh.Key = True Then
        '        Load_ComboBox("SELECT Madv,tenvt,Tendv From Don_vi order by tenvt ASC", Me.CmbDonvi, CNNQLPHONGKHAM)
        '        Me.CmbDonvi.EditValue = frmKh.IDmoi
        '    End If
        'ElseIf e.KeyCode = Keys.Delete Then
        '    Me.CmbDonvi.EditValue = "0"
        'End If
    End Sub

    'Private Sub cmbKhach_hang_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKhach_hang.KeyUp
    '    If e.KeyCode = Keys.F3 Then
    '        Dim frmKh As New frmKhach_hang
    '        frmKh.Madv = Me.CmbDonvi.EditValue
    '        frmKh.ShowDialog()
    '        If frmKh.Key = True Then
    '            Load_ComboBox("SELECT Makh,TenKh From Khach_hang where madv='" & Me.CmbDonvi.EditValue & "' order by Tenkh", Me.cmbKhach_hang, CNNQLPHONGKHAM)
    '            Me.cmbKhach_hang.EditValue = frmKh.IDmoi
    '        End If
    '    ElseIf e.KeyCode = Keys.Delete Then
    '        Me.cmbKhach_hang.EditValue = ""
    '    ElseIf e.KeyCode = Keys.Enter Then
    '        Me.txtGhichu.Focus()
    '    End If

    'End Sub

    Private Sub cmbNghiep_vu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNghiep_vu.KeyUp
        If e.KeyCode = Keys.F3 Then
            Dim frmKh As New frmDMThuChi
            frmKh.ShowDialog()
            If frmKh.Key = True Then
                If blnLoaiphieu = True Then
                    Load_ComboBox("SELECT MaTC,TenLoaiTC From DM_Thu_Chi Where loai=1", Me.cmbNghiep_vu, CNNQLPHONGKHAM)
                Else
                    Load_ComboBox("SELECT MaTC,TenLoaiTC From DM_Thu_Chi Where Loai=0", Me.cmbNghiep_vu, CNNQLPHONGKHAM)
                End If
                Me.cmbNghiep_vu.EditValue = frmKh.IDmoi
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            Me.cmbNghiep_vu.EditValue = ""
        ElseIf e.KeyCode = Keys.Enter Then
            Me.cmbNvTC.Focus()
        End If
    End Sub

    Private Sub cmbNvTC_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNvTC.KeyUp
        If e.KeyCode = Keys.F3 Then
            Dim frmKh As New frmNguoi_SD
            frmKh.ShowDialog()
            If frmKh.Key = True Then
                Load_ComboBox("SELECT Username,Hoten From Nguoi_su_dung", Me.cmbNvTC, CNNQLPHONGKHAM)
                Me.cmbNvTC.EditValue = frmKh.IDmoi
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            Me.cmbNvTC.EditValue = ""
        ElseIf e.KeyCode = Keys.Enter Then
            Me.cmbQuy.Focus()
        End If
    End Sub

    Private Sub cmbQuy_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbQuy.KeyUp
        If e.KeyCode = Keys.F3 Then
            Dim frmKh As New frmDMQuy
            frmKh.ShowDialog()
            If frmKh.Key = True Then
                Load_ComboBox("SELECT Maquy,Tenquy From CTQuy", Me.cmbQuy, CNNQLPHONGKHAM)
                Me.cmbQuy.EditValue = frmKh.IDmoi
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            Me.cmbQuy.EditValue = ""
        ElseIf e.KeyCode = Keys.Enter Then
            Me.CmbDonvi.Focus()
        End If
    End Sub

    Private Sub txtSotienUSD_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSotienUSD.EditValueChanged
        If IsNumeric(Me.txtSotienUSD.EditValue) And IsNumeric(Me.txtTygia.EditValue) Then
            Me.txtQuydoiUSD.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")) + (Val(Replace(Me.txtSotienUSD.EditValue, ",", "")) * Val(Replace(Me.txtTygia.EditValue, ",", ""))), "###,###")
            Me.txtTienQT.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")) + (Val(Replace(Me.txtSotienUSD.EditValue, ",", "")) * Val(Replace(Me.txtTygia.EditValue, ",", ""))), "###,###")
        Else
            Me.txtQuydoiUSD.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")), "###,###")
            Me.txtTienQT.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")), "###,###")
        End If
        If IsNumeric(Me.txtSotienVND.EditValue) Then
            Me.txtSotienVND.Text = Format(Val(Replace(Me.txtSotienVND.Text, ",", "")), "###,###")
        End If
        If IsNumeric(Me.txtQuydoiUSD.EditValue) Then
            Me.txtQuydoiUSD.EditValue = Format(Val(Replace(Me.txtQuydoiUSD.EditValue, ",", "")), "###,###")
        End If
        If IsNumeric(Me.txtQuydoiUSD.EditValue) Then
            Me.txtTienQT.EditValue = Format(Val(Replace(Me.txtTienQT.EditValue, ",", "")), "###,###")
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        FormClear()
        Me.dtpNgay.DateTime = Today.Date
        Dim dtbtygia As DataTable
        dts = BusinessLogic.Data.GetDataset("SELECT tygia FROM phieu_thu_chi WHERE idsophieu=(SELECT Max(idsophieu) FROM phieu_thu_chi )", CommandType.Text, Nothing, Nothing)
        dtbtygia = dts.Tables(0)
        If dtbtygia.Rows.Count > 0 Then
            Me.txtTygia.Text = dtbtygia.Rows(0)("tygia")
        Else
            Me.txtTygia.Text = "0"
        End If
        Me.txtQuydoiUSD.Enabled = False
        Me.txtSophieu.Enabled = False
        Me.btnIn_phieu.Enabled = False
        Me.CmbNVBH.EditValue = clsLoginObj.strUsername
        Me.cmbNvTC.EditValue = clsLoginObj.strUsername
        Me.cmbQuy.EditValue = "1TM"
        Me.CmbNVBH.Enabled = False
        If isHiden Then
            txtSotienVND.Enabled = False
        End If
        foundClick = True
        Me.cmbNghiep_vu.Focus()
    End Sub

    Public Sub FormClear()
        Dim ctrl As Object
        Dim clsObjPTC As New clsThuchi
        For Each ctrl In Me.Grb.Controls
            ctrl.Enabled = True
        Next
        Me.CmbDonvi.EditValue = ""
        Me.cmbNghiep_vu.EditValue = ""
        Me.CmbNVBH.EditValue = ""
        Me.cmbNvTC.EditValue = ""
        Me.cmbQuy.EditValue = ""
        If loaichi = False Then
            Me.txtGhichu.EditValue = ""
        End If
        Me.txtQuydoiUSD.EditValue = "0"
        Me.txtSophieu.EditValue = ""
        Me.txtSotienUSD.EditValue = "0"
        Me.txtSotienVND.EditValue = "0"
        Me.txtTienQT.EditValue = "0"
        Me.txtTygia.EditValue = "1"
        Me.txtThucThu.Text = "0"
        Me.LabTendv.Text = ""
        Me.btnCap_nhat.Enabled = True
        IDPhieuTC = 0
        If Me.blnTiengui = False Then
            Me.txtSophieu.Text = clsObjPTC.Lay_So_phieu(blnLoaiphieu)
        Else
            Me.txtSophieu.Text = clsObjPTC.Lay_So_phieu1(blnLoaiphieu)
        End If
    End Sub

    Private Sub txtSotienVND_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSotienVND.LostFocus
        If IsNumeric(Me.txtSotienVND.EditValue) Then
            Me.txtSotienVND.EditValue = Format(Val(Replace(Me.txtSotienVND.EditValue, ",", "")), "###,###")
        End If
    End Sub

    Private Sub txtSotienUSD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSotienUSD.LostFocus
        If IsNumeric(Me.txtSotienUSD.EditValue) Then
            If Me.txtSotienUSD.Text <> "0" Then
                Me.txtSotienUSD.EditValue = Format(Val(Replace(Me.txtSotienUSD.EditValue, ",", "")), "###,###")
            End If
        End If
    End Sub

    Private Sub txtTienQT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTienQT.LostFocus
        If IsNumeric(Me.txtTienQT.EditValue) Then
            Me.txtTienQT.EditValue = Format(Val(Replace(Me.txtTienQT.EditValue, ",", "")), "###,###")
        End If
    End Sub

    Private Sub txtTygia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTygia.LostFocus
        If IsNumeric(Me.txtTygia.EditValue) Then
            Me.txtTygia.EditValue = Format(Val(Replace(Me.txtTygia.EditValue, ",", "")), "###,###")
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có thực sự muốn xoá phiếu này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim clsobjTC As New clsThuchi
            clsobjTC.Xoa_Phieu(IDPhieuTC, blnLoaiphieu, Me.dtpNgay.EditValue, Me.cmbQuy.EditValue, CNNQLPHONGKHAM)
            MsgBox("Phiếu hiện tại đã được xoá")
            If Me.cmbNghiep_vu.EditValue = "CDU" Or Me.cmbNghiep_vu.EditValue = "TDU" Or Me.cmbNghiep_vu.EditValue = "TDT" Or Me.cmbNghiep_vu.EditValue = "CDT" Then
                MsgBox("Cần phải huỷ phiếu thu chi tương ứng được phát sinh từ phiếu này, nếu không sẽ lệch quỹ!")
            End If
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.btnIn_phieu.Enabled = False
        StypeSUA = True
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Me.btnThem.Enabled = True
        Me.btnIn_phieu.Enabled = True
        Me.btnThoat.Enabled = True
        Me.btnSua.Enabled = False
        Me.btnXoa.Enabled = False
        Me.btnIn_phieu.Enabled = False
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub cmbNghiep_vu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNghiep_vu.EditValueChanged
        If Me.cmbNghiep_vu.EditValue = "CDU" Or Me.cmbNghiep_vu.EditValue = "CDT" Then
            If IDPhieuTC <> 0 Then
                Me.lbldenquy.Visible = False
                Me.cmbdenquy.Visible = False
                Me.btnSua.Enabled = False
            Else
                Me.lbnQuy.Text = "Từ quỹ"
                Me.lbldenquy.Visible = True
                Me.cmbdenquy.Visible = True
            End If
        Else
            'Me.lbnQuy.Text = "TC Từ quỹ"
            Me.lbldenquy.Visible = False
            Me.cmbdenquy.Visible = False
            If loaichi = False Then
                Me.txtGhichu.Text = ""
            End If

        End If
    End Sub

    Private Sub dtpNgay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpNgay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.cmbNghiep_vu.Focus()
        End If
    End Sub

    Private Sub txtGhichu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGhichu.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txtSotienVND.Focus()
        End If
    End Sub

    Private Sub txtSotienVND_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSotienVND.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txtSotienUSD.Focus()
        End If
    End Sub

    Private Sub txtSotienUSD_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSotienUSD.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txtTygia.Focus()
        End If
    End Sub


    Private Sub txtTygia_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTygia.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txtTienQT.Focus()
        End If
    End Sub
    Private Sub cmbdenquy_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdenquy.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnCap_nhat.Focus()
        End If
    End Sub
    Private Sub txtTienQT_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTienQT.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Me.cmbNghiep_vu.EditValue = "CDU" Or Me.cmbNghiep_vu.EditValue = "CDT" Then
                Me.cmbdenquy.Focus()
            Else
                Me.btnCap_nhat.Focus()
            End If
        End If
    End Sub

    'Private Sub CmbNVBH_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbNVBH.KeyUp
    '    If e.KeyCode = Keys.Enter Then
    '        Me.cmbQuy.Focus()
    '    End If
    'End Sub

    Private Sub cmbdenquy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdenquy.GotFocus
        If foundClick = False Then
            cmbdenquy.ShowPopup()
        Else
            foundClick = False
        End If
    End Sub

    Private Sub btnCap_nhat_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCap_nhat.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnIn_phieu.Focus()
        End If
    End Sub

    Private Sub cmbQuy_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbQuy.EditValueChanged
        If foundClick = False Then
            If blnLoaiphieu = False Then
                If Me.cmbNghiep_vu.EditValue = "CDT" Then
                    Load_ComboBox("SELECT Maquy,Tenquy From CTQuy where Maquy ='" & Me.cmbQuy.EditValue & "' order by Tenquy", Me.cmbdenquy, CNNQLPHONGKHAM)
                Else
                    Load_ComboBox("SELECT Maquy,Tenquy From CTQuy where Maquy <>'" & Me.cmbQuy.EditValue & "' order by Tenquy", Me.cmbdenquy, CNNQLPHONGKHAM)
                End If
            End If
        End If
        Me.txtGhichu.Text = ""
    End Sub

    Private Sub cmbdenquy_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdenquy.EditValueChanged
        If foundClick = False Then
            If Me.cmbNghiep_vu.EditValue = "CDU" Then
                Me.txtGhichu.Text = "Chi đối ứng từ: " & Me.cmbQuy.EditValue & " => " & Me.cmbdenquy.EditValue
            Else
                Me.txtGhichu.Text = "Chi đổi tiền từ quỹ: " & Me.cmbQuy.EditValue
            End If
        End If
    End Sub

    Private Sub Voncodinh()

        Dim dtbTscd As New DataTable
        Dim TongConlai As Double
        Dim strSQL As String
        Dim i As Integer
        TongConlai = 0
        strSQL = " Select a.ID,a.Mats,a.Noisx,a.Noisudung,a.Sonamsd,a.Tents,a.Ngay,a.Soluong,a.Nguyengia,Cast(a.Tylekh/100 as varchar)+'/T' as Tylekhauhao,(SELECT GTkhauhao FROM ChitietKH WHERE ID =(SELECT MAX(ID) FROM ChitietKH b WHERE b.Mats = a.MaTS AND b.Ngaytrich <='" & Today.Date.Date & "')) as GiatriKh,Case When a.Nguyengia*a.Soluong - (SELECT GTkhauhao FROM ChitietKH WHERE ID =(SELECT MAX(ID) FROM ChitietKH b WHERE b.Mats = a.MaTS AND b.Ngaytrich <='" & Today.Date.Date & "')) < a.Nguyengia*a.Soluong*a.TyleKH/100 then 0 else a.Nguyengia*a.Soluong - (SELECT GTkhauhao FROM ChitietKH WHERE ID =(SELECT MAX(ID) FROM ChitietKH b WHERE b.Mats = a.MaTS AND b.Ngaytrich <='" & Today.Date.Date & "')) end as giatriconlai,Ngaykhhet from Tai_san_co_dinh a WHERE a.Ngay <='" & Today.Date.Date & "'"
        dts = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing)
        dtbTscd = dts.Tables(0)
        If dtbTscd.Rows.Count > 0 Then
            For i = 0 To dtbTscd.Rows.Count - 1
                If Not IsDBNull(dtbTscd.Rows(i)("Giatriconlai")) Then TongConlai += dtbTscd.Rows(i)("Giatriconlai")
            Next
        End If
        strSQL = "Update Hach_toan_von_DN set Voncodinh =" & TongConlai & " where Convert(char(10),Ngay,101) ='" & Format(Today.Date, "MM/dd/yyyy") & "'"
        Command_Exc(strSQL, CNNQLPHONGKHAM)

    End Sub

    Private Function Chidoitien() As Boolean
        Chidoitien = True
        If Me.txtSotienVND.Text <> "" And Me.txtSotienUSD.Text <> "" Then
            MsgBox("Không thể chi đổi cả hai loại tiền cùng một lúc!")
            Return False
        Else
            If Me.txtSotienVND.Text <> "" Then
                fSotienUSD = Chuanhoa(Me.txtTienQT.Text)
                fSotienVND = 0
            Else
                fSotienVND = Chuanhoa(Me.txtSotienUSD.Text) * Chuanhoa(Me.txtTygia.Text)
                fSotienUSD = 0
            End If
        End If
    End Function

    Private Function xetngay() As Boolean
        xetngay = True

        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dts = BusinessLogic.Data.GetDataset("select * from ket_chuyen", CommandType.Text, Nothing, Nothing)
        dtb = dts.Tables(0)
        ngayketchuyen = dtb.Rows(0)("ngayketchuyen")
        If Me.dtpNgay.Text = "" Then
            MsgBox("Chú ý! Bạn chưa chọn ngày")
            Me.dtpNgay.DateTime = NgayGioServer().Date
            xetngay = False
        End If
        If Me.dtpNgay.DateTime.Date > NgayGioServer().Date Then
            MsgBox("Chú ý! Bạn chọn đã chọn ngày lớn hơn ngày hiện tại")
            Me.dtpNgay.DateTime = NgayGioServer().Date
            xetngay = False
        End If
        If Me.dtpNgay.DateTime.Date < ngayketchuyen.Date Then
            MsgBox("Chú ý! Bạn chọn ngày nhỏ hơn ngày kết chuyển")
            Me.dtpNgay.DateTime = ngayketchuyen.Date
            xetngay = False
        End If

    End Function

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Grb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grb.Enter

    End Sub

    Private Sub txtsophieukham_Leave(sender As Object, e As EventArgs) Handles txtsophieukham.Leave
        If txtsophieukham.Text.Trim() <> "" Then
            Dim dt As New DataTable
            dt = BusinessLogic.Data.GetDataset("select MaBN from PHIEUKHAMBENH where Sophieu='" & txtsophieukham.Text & "'").Tables(0)
            If dt.Rows.Count > 0 Then
                CmbDonvi.EditValue = dt.Rows(0)("MaBN")
            End If
        End If
    End Sub
End Class
