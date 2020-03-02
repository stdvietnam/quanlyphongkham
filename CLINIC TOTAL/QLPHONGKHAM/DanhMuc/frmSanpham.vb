Imports System.IO

Public Class frmSanpham
    Inherits frmBase 'System.Windows.Forms.Form
    Private flag As Boolean
    Private BlnState As Boolean
    Private ID As Int16
    Public IDmoi As String
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbkho As DevExpress.XtraEditors.LookUpEdit
    Public Key As Boolean
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmanhom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colloai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmahang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbnhomxn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdongia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtstt As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtgianhap As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents connhomxn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgianhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldongia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUrl_File As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnMT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colUrl_File As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbPhongban As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSoAnhInRa As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Grb As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Txtmota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDonVT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMasp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTensp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMahanghoa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaBHY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSoDK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHamLuong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDuongDung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbNhomTheoChiPhi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtDonViSuDung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label27 As Label
    Friend WithEvents txtSLToiThieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel_Button As Panel
    Private isload As Boolean = False
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
    Friend WithEvents Errpro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbManhom As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSanpham))
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.Errpro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSoAnhInRa = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbPhongban = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUrl_File = New DevExpress.XtraEditors.TextEdit()
        Me.btnMT = New DevExpress.XtraEditors.SimpleButton()
        Me.txtgianhap = New DevExpress.XtraEditors.SpinEdit()
        Me.txtdongia = New DevExpress.XtraEditors.SpinEdit()
        Me.txtstt = New DevExpress.XtraEditors.SpinEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbnhomxn = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbkho = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbManhom = New DevExpress.XtraEditors.LookUpEdit()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmahang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmanhom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldvt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colloai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.connhomxn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgianhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldongia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUrl_File = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grb = New DevExpress.XtraEditors.GroupControl()
        Me.txtSLToiThieu = New DevExpress.XtraEditors.TextEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtDonViSuDung = New DevExpress.XtraEditors.TextEdit()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txtmota = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDonVT = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTensp = New DevExpress.XtraEditors.TextEdit()
        Me.txtMahanghoa = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaBHY = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSoDK = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMasp = New DevExpress.XtraEditors.TextEdit()
        Me.txtHamLuong = New DevExpress.XtraEditors.TextEdit()
        Me.txtDuongDung = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbNhomTheoChiPhi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.Errpro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSoAnhInRa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPhongban.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUrl_File.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgianhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdongia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbnhomxn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbkho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbManhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        CType(Me.txtSLToiThieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDonViSuDung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtmota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDonVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTensp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMahanghoa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaBHY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSoDK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMasp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHamLuong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuongDung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhomTheoChiPhi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(18, 12)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(120, 12)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 3
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(324, 12)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 5
        Me.btnSua.Text = "&Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(426, 12)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "&Xoá"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(222, 12)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 4
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'Errpro
        '
        Me.Errpro.ContainerControl = Me
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(984, 12)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "&Thoát "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nhóm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tên SP/DV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(746, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Đơn vị tính"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Mô tả"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(947, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Số ảnh"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSoAnhInRa
        '
        Me.cmbSoAnhInRa.EditValue = ""
        Me.cmbSoAnhInRa.Location = New System.Drawing.Point(1001, 78)
        Me.cmbSoAnhInRa.Name = "cmbSoAnhInRa"
        Me.cmbSoAnhInRa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbSoAnhInRa.Properties.Appearance.Options.UseFont = True
        Me.cmbSoAnhInRa.Properties.AutoHeight = False
        Me.cmbSoAnhInRa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSoAnhInRa.Properties.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbSoAnhInRa.Size = New System.Drawing.Size(61, 23)
        Me.cmbSoAnhInRa.TabIndex = 11
        '
        'btnImport
        '
        Me.btnImport.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnImport.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImport.Appearance.Options.UseFont = True
        Me.btnImport.Appearance.Options.UseForeColor = True
        Me.btnImport.Location = New System.Drawing.Point(528, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 25)
        Me.btnImport.TabIndex = 88
        Me.btnImport.Text = "&Import"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(746, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Phòng thực hiện"
        '
        'cmbPhongban
        '
        Me.cmbPhongban.AllowDrop = True
        Me.cmbPhongban.Location = New System.Drawing.Point(866, 130)
        Me.cmbPhongban.Name = "cmbPhongban"
        Me.cmbPhongban.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbPhongban.Properties.Appearance.Options.UseFont = True
        Me.cmbPhongban.Properties.AutoHeight = False
        Me.cmbPhongban.Properties.AutoSearchColumnIndex = 1
        Me.cmbPhongban.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPhongban.Properties.NullText = ""
        Me.cmbPhongban.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbPhongban.Size = New System.Drawing.Size(193, 23)
        Me.cmbPhongban.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(25, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Mẫu đính kèm"
        '
        'txtUrl_File
        '
        Me.txtUrl_File.EditValue = ""
        Me.txtUrl_File.Enabled = False
        Me.txtUrl_File.Location = New System.Drawing.Point(122, 133)
        Me.txtUrl_File.Name = "txtUrl_File"
        Me.txtUrl_File.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUrl_File.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUrl_File.Properties.Appearance.Options.UseBackColor = True
        Me.txtUrl_File.Properties.Appearance.Options.UseFont = True
        Me.txtUrl_File.Properties.AutoHeight = False
        Me.txtUrl_File.Size = New System.Drawing.Size(456, 23)
        Me.txtUrl_File.TabIndex = 12
        '
        'btnMT
        '
        Me.btnMT.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnMT.Appearance.Options.UseForeColor = True
        Me.btnMT.Location = New System.Drawing.Point(584, 132)
        Me.btnMT.Name = "btnMT"
        Me.btnMT.Size = New System.Drawing.Size(96, 25)
        Me.btnMT.TabIndex = 82
        Me.btnMT.Text = "&Chọn File..."
        '
        'txtgianhap
        '
        Me.txtgianhap.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgianhap.Location = New System.Drawing.Point(362, 52)
        Me.txtgianhap.Name = "txtgianhap"
        Me.txtgianhap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtgianhap.Properties.Appearance.Options.UseFont = True
        Me.txtgianhap.Properties.AutoHeight = False
        Me.txtgianhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtgianhap.Properties.DisplayFormat.FormatString = "###,###"
        Me.txtgianhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtgianhap.Properties.EditFormat.FormatString = "###,###"
        Me.txtgianhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtgianhap.Properties.NullText = "0"
        Me.txtgianhap.Size = New System.Drawing.Size(106, 23)
        Me.txtgianhap.TabIndex = 4
        '
        'txtdongia
        '
        Me.txtdongia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdongia.Location = New System.Drawing.Point(574, 52)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtdongia.Properties.Appearance.Options.UseFont = True
        Me.txtdongia.Properties.AutoHeight = False
        Me.txtdongia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtdongia.Properties.DisplayFormat.FormatString = "###,###"
        Me.txtdongia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtdongia.Properties.EditFormat.FormatString = "###,###"
        Me.txtdongia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtdongia.Properties.NullText = "0"
        Me.txtdongia.Size = New System.Drawing.Size(106, 23)
        Me.txtdongia.TabIndex = 5
        '
        'txtstt
        '
        Me.txtstt.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtstt.Location = New System.Drawing.Point(1001, 52)
        Me.txtstt.Name = "txtstt"
        Me.txtstt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtstt.Properties.Appearance.Options.UseFont = True
        Me.txtstt.Properties.AutoHeight = False
        Me.txtstt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtstt.Size = New System.Drawing.Size(61, 23)
        Me.txtstt.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(279, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Giá nhập"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(947, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "STT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(279, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nhóm SP"
        '
        'cmbnhomxn
        '
        Me.cmbnhomxn.AllowDrop = True
        Me.cmbnhomxn.Location = New System.Drawing.Point(362, 26)
        Me.cmbnhomxn.Name = "cmbnhomxn"
        Me.cmbnhomxn.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbnhomxn.Properties.Appearance.Options.UseFont = True
        Me.cmbnhomxn.Properties.AutoHeight = False
        Me.cmbnhomxn.Properties.AutoSearchColumnIndex = 1
        Me.cmbnhomxn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmbnhomxn.Properties.NullText = ""
        Me.cmbnhomxn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbnhomxn.Size = New System.Drawing.Size(318, 22)
        Me.cmbnhomxn.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(746, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Kho quản lý"
        '
        'cmbkho
        '
        Me.cmbkho.AllowDrop = True
        Me.cmbkho.Location = New System.Drawing.Point(866, 26)
        Me.cmbkho.Name = "cmbkho"
        Me.cmbkho.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbkho.Properties.Appearance.Options.UseFont = True
        Me.cmbkho.Properties.AutoHeight = False
        Me.cmbkho.Properties.AutoSearchColumnIndex = 1
        Me.cmbkho.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbkho.Properties.NullText = ""
        Me.cmbkho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbkho.Size = New System.Drawing.Size(196, 23)
        Me.cmbkho.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(25, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Mã SP/DV"
        '
        'CmbManhom
        '
        Me.CmbManhom.AllowDrop = True
        Me.CmbManhom.Location = New System.Drawing.Point(122, 26)
        Me.CmbManhom.Name = "CmbManhom"
        Me.CmbManhom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmbManhom.Properties.Appearance.Options.UseFont = True
        Me.CmbManhom.Properties.AutoHeight = False
        Me.CmbManhom.Properties.AutoSearchColumnIndex = 1
        Me.CmbManhom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbManhom.Properties.NullText = ""
        Me.CmbManhom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CmbManhom.Size = New System.Drawing.Size(146, 22)
        Me.CmbManhom.TabIndex = 0
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 176)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(1076, 380)
        Me.grv.TabIndex = 8
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.colmahang, Me.colten, Me.colmanhom, Me.colmota, Me.coldvt, Me.colkho, Me.colloai, Me.connhomxn, Me.colgianhap, Me.coldongia, Me.colstt, Me.colUrl_File})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "tensp", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PreviewLineCount = 1
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colmanhom, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colma
        '
        Me.colma.Caption = "Mã SP"
        Me.colma.FieldName = "masp"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.OptionsColumn.AllowFocus = False
        Me.colma.Visible = True
        Me.colma.VisibleIndex = 0
        Me.colma.Width = 70
        '
        'colmahang
        '
        Me.colmahang.Caption = "Mã sp/dịch vụ"
        Me.colmahang.FieldName = "mahanghoa"
        Me.colmahang.Name = "colmahang"
        Me.colmahang.OptionsColumn.AllowEdit = False
        Me.colmahang.OptionsColumn.AllowFocus = False
        Me.colmahang.Width = 98
        '
        'colten
        '
        Me.colten.Caption = "Tên sản phẩm/dịch vụ"
        Me.colten.FieldName = "tensp"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 1
        Me.colten.Width = 256
        '
        'colmanhom
        '
        Me.colmanhom.Caption = "Nhóm sản phẩm"
        Me.colmanhom.FieldName = "tennhom"
        Me.colmanhom.Name = "colmanhom"
        Me.colmanhom.OptionsColumn.AllowEdit = False
        Me.colmanhom.OptionsColumn.AllowFocus = False
        Me.colmanhom.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "tennhom", "{0}")})
        Me.colmanhom.Width = 133
        '
        'colmota
        '
        Me.colmota.Caption = "Mô tả"
        Me.colmota.FieldName = "mota"
        Me.colmota.Name = "colmota"
        Me.colmota.OptionsColumn.AllowEdit = False
        Me.colmota.OptionsColumn.AllowFocus = False
        Me.colmota.Visible = True
        Me.colmota.VisibleIndex = 3
        Me.colmota.Width = 188
        '
        'coldvt
        '
        Me.coldvt.Caption = "ĐVT"
        Me.coldvt.FieldName = "dvt"
        Me.coldvt.Name = "coldvt"
        Me.coldvt.OptionsColumn.AllowEdit = False
        Me.coldvt.OptionsColumn.AllowFocus = False
        Me.coldvt.Visible = True
        Me.coldvt.VisibleIndex = 2
        Me.coldvt.Width = 67
        '
        'colkho
        '
        Me.colkho.Caption = "Kho"
        Me.colkho.FieldName = "makho"
        Me.colkho.Name = "colkho"
        Me.colkho.OptionsColumn.AllowEdit = False
        Me.colkho.OptionsColumn.AllowFocus = False
        Me.colkho.Width = 62
        '
        'colloai
        '
        Me.colloai.Caption = "Loại"
        Me.colloai.FieldName = "ten"
        Me.colloai.Name = "colloai"
        Me.colloai.OptionsColumn.AllowEdit = False
        Me.colloai.OptionsColumn.AllowFocus = False
        '
        'connhomxn
        '
        Me.connhomxn.Caption = "Mã nhóm XN"
        Me.connhomxn.FieldName = "MaNhomXetnghiem"
        Me.connhomxn.Name = "connhomxn"
        Me.connhomxn.Visible = True
        Me.connhomxn.VisibleIndex = 6
        Me.connhomxn.Width = 73
        '
        'colgianhap
        '
        Me.colgianhap.Caption = "Giá nhập"
        Me.colgianhap.DisplayFormat.FormatString = "###,###"
        Me.colgianhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colgianhap.FieldName = "gianhap"
        Me.colgianhap.Name = "colgianhap"
        Me.colgianhap.Visible = True
        Me.colgianhap.VisibleIndex = 4
        Me.colgianhap.Width = 96
        '
        'coldongia
        '
        Me.coldongia.Caption = "Giá bán"
        Me.coldongia.DisplayFormat.FormatString = "###,###"
        Me.coldongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldongia.FieldName = "dongia"
        Me.coldongia.Name = "coldongia"
        Me.coldongia.Visible = True
        Me.coldongia.VisibleIndex = 5
        Me.coldongia.Width = 90
        '
        'colstt
        '
        Me.colstt.Caption = "Stt"
        Me.colstt.FieldName = "Stt"
        Me.colstt.Name = "colstt"
        Me.colstt.Width = 35
        '
        'colUrl_File
        '
        Me.colUrl_File.Caption = "Url File"
        Me.colUrl_File.FieldName = "Url_File"
        Me.colUrl_File.Name = "colUrl_File"
        Me.colUrl_File.Visible = True
        Me.colUrl_File.VisibleIndex = 7
        Me.colUrl_File.Width = 213
        '
        'Grb
        '
        Me.Grb.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Grb.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Grb.AppearanceCaption.Options.UseFont = True
        Me.Grb.AppearanceCaption.Options.UseForeColor = True
        Me.Grb.Controls.Add(Me.txtSLToiThieu)
        Me.Grb.Controls.Add(Me.Label29)
        Me.Grb.Controls.Add(Me.txtDonViSuDung)
        Me.Grb.Controls.Add(Me.Label27)
        Me.Grb.Controls.Add(Me.Label25)
        Me.Grb.Controls.Add(Me.Label24)
        Me.Grb.Controls.Add(Me.Label23)
        Me.Grb.Controls.Add(Me.Label22)
        Me.Grb.Controls.Add(Me.Label21)
        Me.Grb.Controls.Add(Me.Label20)
        Me.Grb.Controls.Add(Me.Label19)
        Me.Grb.Controls.Add(Me.Txtmota)
        Me.Grb.Controls.Add(Me.TxtDonVT)
        Me.Grb.Controls.Add(Me.TxtTensp)
        Me.Grb.Controls.Add(Me.txtMahanghoa)
        Me.Grb.Controls.Add(Me.txtMaBHY)
        Me.Grb.Controls.Add(Me.GroupBox1)
        Me.Grb.Controls.Add(Me.Label17)
        Me.Grb.Controls.Add(Me.Label13)
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.txtUrl_File)
        Me.Grb.Controls.Add(Me.cmbSoAnhInRa)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Controls.Add(Me.Label5)
        Me.Grb.Controls.Add(Me.Label12)
        Me.Grb.Controls.Add(Me.cmbPhongban)
        Me.Grb.Controls.Add(Me.Label11)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.btnMT)
        Me.Grb.Controls.Add(Me.CmbManhom)
        Me.Grb.Controls.Add(Me.txtgianhap)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Controls.Add(Me.txtdongia)
        Me.Grb.Controls.Add(Me.cmbkho)
        Me.Grb.Controls.Add(Me.txtstt)
        Me.Grb.Controls.Add(Me.Label8)
        Me.Grb.Controls.Add(Me.Label10)
        Me.Grb.Controls.Add(Me.Label9)
        Me.Grb.Controls.Add(Me.cmbnhomxn)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grb.Location = New System.Drawing.Point(0, 0)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(1076, 173)
        Me.Grb.TabIndex = 9
        Me.Grb.Text = "Thông tin sản phẩm"
        '
        'txtSLToiThieu
        '
        Me.txtSLToiThieu.EditValue = "0"
        Me.txtSLToiThieu.Location = New System.Drawing.Point(866, 104)
        Me.txtSLToiThieu.Name = "txtSLToiThieu"
        Me.txtSLToiThieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSLToiThieu.Properties.Appearance.Options.UseFont = True
        Me.txtSLToiThieu.Properties.AutoHeight = False
        Me.txtSLToiThieu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSLToiThieu.Properties.NullText = "0"
        Me.txtSLToiThieu.Size = New System.Drawing.Size(71, 23)
        Me.txtSLToiThieu.TabIndex = 108
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(746, 107)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 16)
        Me.Label29.TabIndex = 109
        Me.Label29.Text = "SL Tối thiểu"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDonViSuDung
        '
        Me.txtDonViSuDung.Location = New System.Drawing.Point(866, 78)
        Me.txtDonViSuDung.Name = "txtDonViSuDung"
        Me.txtDonViSuDung.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDonViSuDung.Properties.Appearance.Options.UseFont = True
        Me.txtDonViSuDung.Properties.AutoHeight = False
        Me.txtDonViSuDung.Size = New System.Drawing.Size(71, 23)
        Me.txtDonViSuDung.TabIndex = 105
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(746, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(78, 16)
        Me.Label27.TabIndex = 106
        Me.Label27.Text = "ĐVị sử dụng"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(842, 135)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 14)
        Me.Label25.TabIndex = 104
        Me.Label25.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(842, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 14)
        Me.Label24.TabIndex = 104
        Me.Label24.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(842, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 14)
        Me.Label23.TabIndex = 104
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(342, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 14)
        Me.Label22.TabIndex = 103
        Me.Label22.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(98, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 14)
        Me.Label21.TabIndex = 102
        Me.Label21.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(98, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 14)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(98, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "*"
        '
        'Txtmota
        '
        Me.Txtmota.Location = New System.Drawing.Point(122, 106)
        Me.Txtmota.Name = "Txtmota"
        Me.Txtmota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txtmota.Properties.Appearance.Options.UseFont = True
        Me.Txtmota.Properties.AutoHeight = False
        Me.Txtmota.Size = New System.Drawing.Size(558, 23)
        Me.Txtmota.TabIndex = 10
        '
        'TxtDonVT
        '
        Me.TxtDonVT.Location = New System.Drawing.Point(866, 52)
        Me.TxtDonVT.Name = "TxtDonVT"
        Me.TxtDonVT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtDonVT.Properties.Appearance.Options.UseFont = True
        Me.TxtDonVT.Properties.AutoHeight = False
        Me.TxtDonVT.Size = New System.Drawing.Size(71, 23)
        Me.TxtDonVT.TabIndex = 6
        '
        'TxtTensp
        '
        Me.TxtTensp.Location = New System.Drawing.Point(122, 79)
        Me.TxtTensp.Name = "TxtTensp"
        Me.TxtTensp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtTensp.Properties.Appearance.Options.UseFont = True
        Me.TxtTensp.Properties.AutoHeight = False
        Me.TxtTensp.Size = New System.Drawing.Size(558, 23)
        Me.TxtTensp.TabIndex = 8
        '
        'txtMahanghoa
        '
        Me.txtMahanghoa.Location = New System.Drawing.Point(122, 52)
        Me.txtMahanghoa.Name = "txtMahanghoa"
        Me.txtMahanghoa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMahanghoa.Properties.Appearance.Options.UseFont = True
        Me.txtMahanghoa.Properties.AutoHeight = False
        Me.txtMahanghoa.Size = New System.Drawing.Size(146, 23)
        Me.txtMahanghoa.TabIndex = 3
        '
        'txtMaBHY
        '
        Me.txtMaBHY.Location = New System.Drawing.Point(133, 246)
        Me.txtMaBHY.Name = "txtMaBHY"
        Me.txtMaBHY.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMaBHY.Properties.Appearance.Options.UseFont = True
        Me.txtMaBHY.Properties.AutoHeight = False
        Me.txtMaBHY.Size = New System.Drawing.Size(146, 23)
        Me.txtMaBHY.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtSoDK)
        Me.GroupBox1.Controls.Add(Me.TxtMasp)
        Me.GroupBox1.Controls.Add(Me.txtHamLuong)
        Me.GroupBox1.Controls.Add(Me.txtDuongDung)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbNhomTheoChiPhi)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 62)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khác"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(807, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(123, 16)
        Me.Label18.TabIndex = 106
        Me.Label18.Text = "Nhóm theo chi phí *"
        '
        'txtSoDK
        '
        Me.txtSoDK.Location = New System.Drawing.Point(585, 37)
        Me.txtSoDK.Name = "txtSoDK"
        Me.txtSoDK.Properties.AutoHeight = False
        Me.txtSoDK.Size = New System.Drawing.Size(179, 20)
        Me.txtSoDK.TabIndex = 2
        '
        'TxtMasp
        '
        Me.TxtMasp.Location = New System.Drawing.Point(993, 11)
        Me.TxtMasp.Name = "TxtMasp"
        Me.TxtMasp.Properties.AutoHeight = False
        Me.TxtMasp.Size = New System.Drawing.Size(50, 23)
        Me.TxtMasp.TabIndex = 102
        Me.TxtMasp.Visible = False
        '
        'txtHamLuong
        '
        Me.txtHamLuong.Location = New System.Drawing.Point(285, 37)
        Me.txtHamLuong.Name = "txtHamLuong"
        Me.txtHamLuong.Properties.AutoHeight = False
        Me.txtHamLuong.Size = New System.Drawing.Size(275, 20)
        Me.txtHamLuong.TabIndex = 1
        '
        'txtDuongDung
        '
        Me.txtDuongDung.Location = New System.Drawing.Point(11, 37)
        Me.txtDuongDung.Name = "txtDuongDung"
        Me.txtDuongDung.Properties.AutoHeight = False
        Me.txtDuongDung.Size = New System.Drawing.Size(250, 20)
        Me.txtDuongDung.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(582, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 16)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Số đăng ký / số GPNK"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(282, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 16)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Hàm lượng/ nồng độ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(8, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(165, 16)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Đường dùng/ Dạng bào chế"
        '
        'cmbNhomTheoChiPhi
        '
        Me.cmbNhomTheoChiPhi.Location = New System.Drawing.Point(810, 37)
        Me.cmbNhomTheoChiPhi.Name = "cmbNhomTheoChiPhi"
        Me.cmbNhomTheoChiPhi.Properties.AutoHeight = False
        Me.cmbNhomTheoChiPhi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNhomTheoChiPhi.Properties.NullText = ""
        Me.cmbNhomTheoChiPhi.Size = New System.Drawing.Size(236, 20)
        Me.cmbNhomTheoChiPhi.TabIndex = 107
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(494, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "Giá xuất"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(16, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 17)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Mã DM của BYT"
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnImport)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 561)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(1076, 52)
        Me.Panel_Button.TabIndex = 89
        '
        'frmSanpham
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 613)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.Grb)
        Me.Controls.Add(Me.grv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSanpham"
        Me.Text = "DANH MỤC SẢN PHẨM - DỊCH VỤ"
        CType(Me.Errpro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSoAnhInRa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPhongban.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUrl_File.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgianhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdongia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbnhomxn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbkho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbManhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.txtSLToiThieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDonViSuDung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtmota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDonVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTensp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMahanghoa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaBHY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSoDK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMasp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHamLuong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuongDung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhomTheoChiPhi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSanpham_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        loaddata()
    End Sub
    Private Sub frmSanpham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BlnState = True
        loaddata()
        Ctrl_QuyenForm(Me)
        BlnState = False
        isload = True
        Panel_Button.Enabled = True
    End Sub
    Private Sub loaddata()
        Dim dts As New DataSet
        Dim sql As String = "Select s.masp,s.manhom,s.tensp,s.DonVT as dvt,s.mota,s.BH,s.Loai,s.id,s.makho,nhom_sp.tennhom,s.mahanghoa,MaNhomXetnghiem,Stt,s.dongia,s.gianhap,s.Url_File,s.Maphong,s.SoAnhInPhieu,s.MaBYT,s.DuongDung,s.HamLuong,s.SoDK,s.DonViSuDung,s.SLToiThieu from San_pham s join Nhom_Sp on s.manhom = nhom_sp.manhom order by s.manhom"
        dts = BusinessLogic.Data.GetDataset(sql)
        grv.DataSource = dts.Tables(0)
        GridView1.ExpandGroupRow(0)

        Load_ComboBox("Select Manhom[Mã],Tennhom[Tên nhóm] from nhom_sp order by manhom ", Me.CmbManhom, CNNQLPHONGKHAM)
        Load_ComboBox("Select Makho[Mã],Tenkho[Tên kho] from kho_hang order by Makho ", Me.cmbkho, CNNQLPHONGKHAM)
        Load_ComboBox("Select MaPhong,TenPhong from Phong_Ban", cmbPhongban, CNNQLPHONGKHAM)
        Load_ComboBox("Select ID[Mã],Ten[Tên nhóm chi phí] from DM_NHOMTHEO_CHIPHI", cmbNhomTheoChiPhi, CNNQLPHONGKHAM)
        'Load_ComboBox("Select Manhom[Mã],TenNhom[Tên nhóm] from Tb_NhomXetNghiem where Active=1 order by MaNhom ", Me.cmbnhomxn, CNNQLPHONGKHAM)

        'Me.Grb.Enabled = True
        'Me.btnCap_nhat.Enabled = False
        'Me.btnHuy.Enabled = False
    End Sub
    Private Function Kiem_Tra() As Boolean
        Dim dts As New DataSet
        Kiem_Tra = True
        If Me.TxtTensp.Text.Trim() = "" Then
            Kiem_Tra = False
            Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Errpro.SetError(Me.TxtTensp, "Trường bắt buộc!")
            Errpro.SetIconAlignment(Me.TxtTensp, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtMahanghoa.Text.Trim() = "" Then
            Kiem_Tra = False
            Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Errpro.SetError(Me.txtMahanghoa, "Trường bắt buộc!")
            Errpro.SetIconAlignment(Me.txtMahanghoa, ErrorIconAlignment.MiddleRight)
        Else
            Dim dtbmahanghoa As New DataTable
            Dim str As String
            Dim i As Int64
            str = "Select Mahanghoa from San_pham Where Masp <> '" & Me.TxtMasp.Text & "'"
            dts = BusinessLogic.Data.GetDataset(str, CommandType.Text, Nothing, Nothing)
            dtbmahanghoa = dts.Tables(0)
            If dtbmahanghoa.Rows.Count > 0 Then
                For i = 0 To dtbmahanghoa.Rows.Count - 1
                    If dtbmahanghoa.Rows(i)("Mahanghoa") = Me.txtMahanghoa.Text Then
                        Kiem_Tra = False
                        Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                        Me.Errpro.SetError(Me.txtMahanghoa, "Mã hàng hoá đã có!")
                        Errpro.SetIconAlignment(Me.txtMahanghoa, ErrorIconAlignment.MiddleRight)
                    End If
                Next
            End If
        End If
        If Me.CmbManhom.EditValue = "" Then
            Kiem_Tra = False
            Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Errpro.SetError(Me.CmbManhom, "Trường bắt buộc!")
            Errpro.SetIconAlignment(Me.CmbManhom, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbkho.EditValue = "" Then
            Kiem_Tra = False
            Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Errpro.SetError(Me.cmbkho, "Trường bắt buộc!")
            Errpro.SetIconAlignment(Me.cmbkho, ErrorIconAlignment.MiddleRight)
        End If
        If Me.cmbPhongban.EditValue = "" Then
            Kiem_Tra = False
            Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Errpro.SetError(Me.cmbPhongban, "Trường bắt buộc!")
            Errpro.SetIconAlignment(Me.cmbPhongban, ErrorIconAlignment.MiddleRight)
        End If
        If Me.TxtDonVT.Text.Trim() = "" Then
            Kiem_Tra = False
            Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Errpro.SetError(Me.TxtDonVT, "Trường bắt buộc!")
            Errpro.SetIconAlignment(Me.TxtDonVT, ErrorIconAlignment.MiddleRight)
        End If
        'If cmbNhomTheoChiPhi.EditValue Is Nothing Then
        '    Kiem_Tra = False
        '    Errpro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
        '    Me.Errpro.SetError(Me.cmbNhomTheoChiPhi, "Trường bắt buộc!")
        '    Errpro.SetIconAlignment(Me.cmbNhomTheoChiPhi, ErrorIconAlignment.MiddleRight)
        'End If
    End Function
    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        BlnState = True
        flag = True
        ID = 0
        Clear_Control(Me)
        clear_form()
        Me.CmbManhom.EditValue = String.Empty
        Me.cmbkho.EditValue = String.Empty
        Me.cmbnhomxn.EditValue = String.Empty
        Me.cmbPhongban.EditValue = String.Empty
        Me.cmbSoAnhInRa.SelectedIndex = 0
        Me.Grb.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        BlnState = False
        isload = False
        Panel_Button.Enabled = True
        Errpro.Dispose()
    End Sub

    Private Sub clear_form()
        Try
            Dim txt As Object
            For Each txt In Grb.Controls
                If txt.Name.Substring(0, 3).ToUpper = "TXT" Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim clssp As New clssanpham
        Dim strSQL As String = ""
        If kiemtrasp() = True Then
        Else
            If kiemtraspTontaiphieudichvu() = True Then
            Else
                If (ActiveSP() = True) Then
                    MsgBox("Không thể xóa sản phẩm này !", MsgBoxStyle.Critical, "Cảnh báo!")
                Else
                    If MsgBox(" Bạn có muốn xoá thật ko ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        clssp.Delete(Me.TxtMasp.Text, 3)
                        strSQL = "delete Ton_kho where masp='" & Me.TxtMasp.Text & "'"
                        If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                            strSQL = "delete Ton_khobackup where masp='" & Me.TxtMasp.Text & "'"
                            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                                loaddata()
                            End If
                        End If
                    End If
                End If
            End If
            Clear_Control(Me)
            isload = True
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        flag = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.Grb.Enabled = True
        Me.TxtMasp.Enabled = False
        kiemtrasp2()
        isload = True
        Panel_Button.Enabled = True
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Clear_Control(Me)
        Clear_Control_DevExprees(Me)
        loaddata()
        isload = True
        Panel_Button.Enabled = True
        Errpro.Dispose()
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub Update_NhomXN()
        Dim str As String = String.Format("Update San_Pham Set MaNhomXetnghiem=N'{0}' Where MaSp='{1}'", cmbnhomxn.EditValue, TxtMasp.Text)
        BusinessLogic.Data.Update(str)
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim clssp As New clssanpham
        If Kiem_Tra() = True Then
            If flag = True Then
                If clssp.Addnew(TxtMasp.Text, CmbManhom.EditValue, TxtTensp.Text, TxtDonVT.Text, Txtmota.Text, 0, txtMahanghoa.Text, cmbNhomTheoChiPhi.EditValue, cmbkho.EditValue, cmbnhomxn.EditValue, txtstt.Value, txtdongia.Value, txtgianhap.Value, 1, txtUrl_File.Text, cmbPhongban.EditValue, cmbSoAnhInRa.SelectedIndex, txtMaBHY.Text, txtDuongDung.Text, txtHamLuong.Text, txtSoDK.Text, txtDonViSuDung.Text, Double.Parse("0" + txtSLToiThieu.EditValue)) = True Then
                    MsgBox("Chú ý! Mã sản phẩm đã tồn tại ", MsgBoxStyle.Critical)
                Else
                    MsgBox("Lưu sản phẩm, dịch vụ thất bại!", MsgBoxStyle.Information)
                    Return
                End If
            Else
                If clssp.Update(TxtMasp.Text, CmbManhom.EditValue, TxtTensp.Text, TxtDonVT.Text, Txtmota.Text, 0, txtMahanghoa.Text, cmbNhomTheoChiPhi.EditValue, cmbkho.EditValue, cmbnhomxn.EditValue, txtstt.Value, txtdongia.Value, txtgianhap.Value, 2, ID, txtUrl_File.Text, cmbPhongban.EditValue, cmbSoAnhInRa.SelectedIndex, txtMaBHY.Text, txtDuongDung.Text, txtHamLuong.Text, txtSoDK.Text, txtDonViSuDung.Text, Double.Parse("0" + txtSLToiThieu.EditValue)) = True Then
                    MsgBox("Chú ý! Mã sản phẩm đã tồn tại", MsgBoxStyle.Critical)
                Else
                    Update_NhomXN()
                End If
            End If
            loaddata()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            flag = False
            Errpro.Dispose()
            Key = True
            Me.CmbManhom.Enabled = True
            isload = True
        End If
        Panel_Button.Enabled = True
    End Sub

    Private Function lay_ma_SP(ByVal strMasp As String, ByVal strManhom As String) As String
        Dim strMaspMoi As String = ""
        Dim srtSQL As String = ""
        Dim dtb As New DataTable
        Dim dts As New DataSet
        Dim ok As Boolean
        Dim i As Integer
        If Len(strMasp) > 0 Then
            For i = 1 To Len(strMasp)
                If IsNumeric(Mid(strMasp, i, 1)) Then
                    strMaspMoi &= Mid(strMasp, i, 1)
                End If
            Next
        End If
        If IsNumeric(strMaspMoi) Then
            strMaspMoi = Val(strMaspMoi) + 1
        Else
            strMaspMoi = 1
        End If
        Do While ok = False
            srtSQL = String.Format("Select masp From San_Pham WHERE masp=N'{0}'", strManhom & strMaspMoi)
            dts = BusinessLogic.Data.GetDataset(srtSQL, CommandType.Text, Nothing, Nothing)
            dtb = dts.Tables(0)
            If dtb.Rows.Count > 0 Then
                strMaspMoi = Val(strMaspMoi) + 1
            Else
                ok = True
            End If
        Loop
        Return strManhom & strMaspMoi
    End Function

    Private Sub CmbManhom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbManhom.EditValueChanged
        Dim Strmasp As String = ""
        Dim Strmanhom As String = ""
        Dim strsQL As String = ""
        Dim dtb As New DataTable
        Dim dts As New DataSet
        Dim dtblsv_SP As New DataTable
        If flag = True And BlnState = False Then
            strsQL = "Select max(cast(right(masp,len(masp)-(" & Len(Trim(CmbManhom.EditValue)) & "+1)) as int)) as Masp From san_pham where Manhom='" & CmbManhom.EditValue & "' and masp like '%" & CmbManhom.EditValue & "-%'"
            dts = BusinessLogic.Data.GetDataset(strsQL)
            dtb = dts.Tables(0)
            If dtb.Rows.Count > 0 Then
                If Not IsDBNull(dtb.Rows(0)("Masp")) Then Strmasp = dtb.Rows(0)("Masp")
            End If
            Strmanhom = CmbManhom.EditValue + "-"
            Me.TxtMasp.Text = lay_ma_SP(Strmasp, Strmanhom)
            Me.txtMahanghoa.Text = Me.TxtMasp.Text
        End If
        If Me.CmbManhom.EditValue <> "" Then
            If isload = False Then
                strsQL = String.Format("Select s.masp,s.manhom,s.tensp,s.DonVT as dvt,s.mota,s.BH,loai,s.id,s.makho,tennhom,s.mahanghoa,tb_loaidv.ten,MaNhomXetnghiem,s.Stt,s.dongia,s.gianhap ")
                strsQL &= String.Format("From San_pham s inner join Nhom_Sp on s.manhom = nhom_sp.manhom inner join tb_loaidv on Loai=tb_loaidv.ma where s.manhom= N'{0}'", CmbManhom.EditValue)
                dts = BusinessLogic.Data.GetDataset(strsQL)
                grv.DataSource = dts.Tables(0)
            End If
        End If
        If CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.THUOC).ToString() Or CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.VTYT).ToString() Then
            Load_ComboBox("Select Manhom[Mã],TenNhom[Tên nhóm] from Tb_NhomXetNghiem where Active=1 order by MaNhom ", Me.cmbnhomxn, CNNQLPHONGKHAM)
        Else
            Load_ComboBox("Select Manhom[Mã],TenNhom[Tên nhóm] from Tb_NhomXetNghiem where Active=1 order by MaNhom ", Me.cmbnhomxn, CNNQLPHONGKHAM)
        End If
        Load_ComboBox("Select Manhom[Mã],TenNhom[Tên nhóm] from Tb_NhomXetNghiem where Active=1 and Id_NhomSp=N'" & CmbManhom.EditValue & "' order by MaNhom ", Me.cmbnhomxn, CNNQLPHONGKHAM)
        Me.Errpro.SetError(Me.CmbManhom, "")
    End Sub

    Private Sub CmbManhom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbManhom.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim frmKh As New frmNhomSP
            frmKh.ShowDialog()
            Load_ComboBox("Select Manhom,Tennhom from nhom_sp order by tennhom", Me.CmbManhom, CNNQLPHONGKHAM)
            Me.CmbManhom.EditValue = frmKh.IDmoi
        End If
    End Sub

    Private Sub frmSanpham_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Key = True Then
            Dim dtb As New DataTable
            Dim dts As New DataSet
            dts = BusinessLogic.Data.GetDataset("Select Masp from San_pham where ID=(select Max(ID) from San_pham)", CommandType.Text, Nothing, Nothing)
            dtb = dts.Tables(0)
            If dtb.Rows.Count > 0 Then
                IDmoi = dtb.Rows(0)("Masp")
            End If
        End If
    End Sub

    Private Sub txtMahanghoa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        kiemtrasp2()
    End Sub

    Private Sub txtMahanghoa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtMahanghoa.Text <> "" Then
            Me.Errpro.SetError(Me.txtMahanghoa, "")
        End If
    End Sub

    Private Sub TxtTensp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.TxtTensp.Text <> "" Then
            Me.Errpro.SetError(Me.TxtTensp, "")
        End If
    End Sub

    Private Sub cmbkho_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkho.EditValueChanged
        If Me.cmbkho.EditValue <> "" Then
            Me.Errpro.SetError(Me.cmbkho, "")
        End If
    End Sub

    Private Function kiemtrasp() As Boolean
        Dim Masp As String = ""
        Dim dt1 As New DataTable
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("Select masp from chi_tiet_pxn  inner join phieu_xuat_nhap  on idsophieu=idphieuxn where huy=0 group by masp union all select masp From Tb_Kedonthuoc_chitiet  inner join Tb_Kedonthuoc on Tb_Kedonthuoc.idphieu=Tb_Kedonthuoc_chitiet.idsophieu where huy=0 and masp not in (select masp from chi_tiet_pxn inner join phieu_xuat_nhap  on idsophieu=idphieuxn where huy=0 group by masp) group by masp", CommandType.Text, Nothing, Nothing)
        dt1 = dts.Tables(0)
        For i As Integer = 0 To dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                Masp = dt1.Rows(i)("masp")
            End If
            If Me.TxtMasp.Text = Masp Then
                MsgBox("Không thể xóa sản phẩm này!", MsgBoxStyle.Critical, "Cảnh báo!")
                Return True
            End If
        Next
    End Function

    Private Function ActiveSP() As Boolean
        Dim bo As Boolean = False
        Dim dt1 As New DataTable
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset(String.Format("Select Active From San_Pham Where masp=N'{0}'", TxtMasp.Text))
        dt1 = dts.Tables(0)
        For i As Integer = 0 To dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                bo = dt1.Rows(i)("Active")
            End If
            If bo = True Then
                'MsgBox("Không thể xóa sản phẩm này!", MsgBoxStyle.Critical, "Cảnh báo!")
                Return True
            End If
        Next
    End Function

    'kiem tra khi sua phieu
    Private Function kiemtrasp2() As Boolean
        Dim Masp As String = ""
        Dim dt1 As New DataTable
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("select masp from chi_tiet_pxn  inner join phieu_xuat_nhap  on idsophieu=idphieuxn where huy=0 group by masp union all select masp from Tb_Kedonthuoc_chitiet  inner join Tb_Kedonthuoc on Tb_Kedonthuoc.idphieu=Tb_Kedonthuoc_chitiet.idsophieu where huy=0 and masp not in (select masp from chi_tiet_pxn  inner join phieu_xuat_nhap  on idsophieu=idphieuxn where huy=0 group by masp) group by masp", CommandType.Text, Nothing, Nothing)
        dt1 = dts.Tables(0)
        For i As Integer = 0 To dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                Masp = dt1.Rows(i)("masp")
            End If
            If Me.TxtMasp.Text = Masp Then
                Me.cmbkho.Enabled = False
                Return True
            Else
                Me.cmbkho.Enabled = True
            End If
        Next
    End Function

    'thêm kiểm tra xem mã này đã được xuất chưa (dịch vụ)
    Private Function kiemtraspTontaiphieudichvu() As Boolean
        Dim Masp As String = ""
        Dim dt1 As New DataTable
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("Select * from Chi_tiet_NEW where Masp=N'" & Me.TxtMasp.Text & "' ", CommandType.Text, Nothing, Nothing)
        dt1 = dts.Tables(0)
        For i As Integer = 0 To dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                MsgBox("Không thể xóa sản phẩm này vì đã có trong các phiếu dịch vụ!", MsgBoxStyle.Critical, "Cảnh báo!")
                Return True
            End If
        Next
    End Function

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If isload = True Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Me.txtMahanghoa.Text = dr("mahanghoa").ToString()
                    Me.TxtTensp.Text = dr("tensp").ToString()
                    If Not dr("Mota") Is DBNull.Value Then
                        Me.Txtmota.Text = dr("mota").ToString()
                    Else
                        Me.Txtmota.Text = String.Empty
                    End If
                    If Not dr("MaNhomXetnghiem") Is DBNull.Value Then
                        cmbnhomxn.EditValue = dr("MaNhomXetnghiem")
                    End If
                    TxtMasp.Text = dr("masp").ToString()
                    TxtDonVT.Text = dr("dvt").ToString()
                    cmbkho.EditValue = dr("makho")
                    CmbManhom.EditValue = dr("manhom")
                    ID = dr("ID")
                    If Not dr("gianhap") Is DBNull.Value Then
                        txtgianhap.Value = dr("gianhap")
                    Else
                        txtgianhap.Value = 0
                    End If
                    If Not dr("dongia") Is DBNull.Value Then
                        txtdongia.Value = dr("dongia")
                    Else
                        txtdongia.Value = 0
                    End If
                    If Not dr("Stt") Is DBNull.Value Then
                        txtstt.Value = dr("Stt")
                    End If
                    If Not dr("Url_File") Is DBNull.Value Then
                        txtUrl_File.Text = dr("Url_File").ToString()
                    Else
                        txtUrl_File.Text = String.Empty
                    End If
                    If Not dr("Maphong") Is DBNull.Value Then
                        cmbPhongban.EditValue = dr("Maphong")
                    Else
                        cmbPhongban.EditValue = String.Empty
                    End If
                    If Not dr("SoAnhInPhieu") Is DBNull.Value Then
                        cmbSoAnhInRa.Text = dr("SoAnhInPhieu").ToString()
                    Else
                        cmbSoAnhInRa.Text = "0"
                    End If
                    If Not dr("MaBYT") Is DBNull.Value Then
                        txtMaBHY.Text = dr("MaBYT").ToString()
                    Else
                        txtMaBHY.Text = String.Empty
                    End If
                    If Not dr("DuongDung") Is DBNull.Value Then
                        txtDuongDung.Text = dr("DuongDung").ToString()
                    Else
                        txtDuongDung.Text = String.Empty
                    End If
                    If Not dr("HamLuong") Is DBNull.Value Then
                        txtHamLuong.Text = dr("HamLuong").ToString()
                    Else
                        txtHamLuong.Text = String.Empty
                    End If
                    If Not dr("SoDK") Is DBNull.Value Then
                        txtSoDK.Text = dr("SoDK").ToString()
                    Else
                        txtSoDK.Text = String.Empty
                    End If

                    If Not dr("Loai") Is DBNull.Value Then
                        cmbNhomTheoChiPhi.EditValue = dr("Loai")
                    Else
                        cmbNhomTheoChiPhi.EditValue = Nothing
                    End If

                    If Not dr("DonViSuDung") Is DBNull.Value Then
                        txtDonViSuDung.Text = dr("DonViSuDung").ToString()
                    Else
                        txtDonViSuDung.Text = String.Empty
                    End If
                    If Not dr("SLToiThieu") Is DBNull.Value Then
                        txtSLToiThieu.EditValue = Double.Parse(dr("SLToiThieu").ToString())
                    Else
                        txtSLToiThieu.EditValue = "0"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Txtmota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtmota.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.M Then
                Me.Txtmota.Text &= "mmol/L "
            End If
            If e.KeyCode = Keys.T Then
                Me.Txtmota.Text &= "°C "
            End If
            If e.KeyCode = Keys.U Then
                Me.Txtmota.Text &= "µmol/L "
            End If
            If e.KeyCode = Keys.OemPeriod Then
                Me.Txtmota.Text &= "≥"
            End If
            If e.KeyCode = Keys.Oemcomma Then
                Me.Txtmota.Text &= "≤"
            End If
            If e.KeyCode = Keys.F6 Then
                Txtmota.Text = "Bình thường"
            End If
        End If
    End Sub

    Private Sub btnMT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMT.Click
        Dim dtURL As DataTable = New DataTable()
        Dim StrURL As String = ""
        dtURL = BusinessLogic.Data.GetDataset("Select Server_Name From Server_Share").Tables(0)
        If Not dtURL.Rows(0)("Server_Name") Is DBNull.Value Then
            StrURL = dtURL.Rows(0)("Server_Name")
        End If
        Dim open As OpenFileDialog = New OpenFileDialog()
        open.InitialDirectory = StrURL
        open.Filter = "Image Files(*.doc;*.docx; *.excel;*.rtf)|*.doc;*.docx;*.excel;*.rtf"
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtUrl_File.Text = open.FileName
        End If
    End Sub

    Private Sub btnNhomxn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmNhomxetnghiem
        frm.passData_ = New frmNhomxetnghiem.PassDatabn(AddressOf GetFirstValue)
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
    End Sub

    Private Sub GetFirstValue(ByVal MaXN As String)
        Load_ComboBox("Select Manhom[Mã],TenNhom[Tên nhóm] from Tb_NhomXetNghiem where Active=1 order by MaNhom", cmbnhomxn, CNNQLPHONGKHAM)
        Me.cmbnhomxn.EditValue = MaXN
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim frm As New frmSanPham_Import
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

    Private Sub cmbnhomxn_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbnhomxn.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim frm As New frmNhomxetnghiem
            frm.passData_ = New frmNhomxetnghiem.PassDatabn(AddressOf GetFirstValue)
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
        End If
    End Sub

    Private Sub TxtDonVT_EditValueChanged(sender As Object, e As EventArgs) Handles TxtDonVT.EditValueChanged
        txtDonViSuDung.Text = TxtDonVT.Text
    End Sub

    Private Sub txtSLToiThieu_EditValueChanged(sender As Object, e As EventArgs) Handles txtSLToiThieu.EditValueChanged
        If String.IsNullOrEmpty(txtSLToiThieu.Text) Then
            txtSLToiThieu.Text = "0"
        End If
    End Sub
End Class
