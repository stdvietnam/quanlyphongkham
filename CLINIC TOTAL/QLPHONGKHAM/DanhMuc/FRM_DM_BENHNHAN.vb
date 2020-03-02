Public Class FRM_DM_BENHNHAN
    Inherits frmBase
#Region "Khai bao bien"
    Private flag As Boolean = False
    Public key As Boolean
    Public IDmoi As Integer
    Private dt As New DataTable
    Friend WithEvents grb As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbDanToc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbQuanHe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbNgheNghiep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtNgaySinh As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDiaChiLienHe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaThe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttylechitra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colhoten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgioitinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldantoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colns As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnghenghiep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnoilv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colquanhe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnguoithan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldclh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colghichu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public Delegate Sub PassData(ByVal value As String, ByVal value2 As String)
    Public Delegate Sub PassDatabn(ByVal value As String)
    Public passData_ As PassDatabn
    Friend WithEvents txtnguoithan2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtGT_THE_TU As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtGT_THE_DEN As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMaKBD As DevExpress.XtraEditors.TextEdit
    Private isload As Boolean = False
    Private ngay, ngay2 As Int16
    Private thang, thang2 As Int16
    Private nam, nam2 As Int16
    Friend WithEvents txtSoLuongTE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtMA_VACH As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtghichu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmbDoiTuong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colsothebh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTenNoiKBD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbGioi_Tinh As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMA_KHUVUC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txtThangTuoi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel_Buton As Panel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
#End Region
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
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTenBN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSoTheBHYT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaBN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDienThoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoiLamViec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Error_PhongKham As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DM_BENHNHAN))
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenBN = New DevExpress.XtraEditors.TextEdit()
        Me.txtSoTheBHYT = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaBN = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.txtDienThoai = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoiLamViec = New DevExpress.XtraEditors.TextEdit()
        Me.Error_PhongKham = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaThe = New DevExpress.XtraEditors.TextEdit()
        Me.txttylechitra = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.grb = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtThangTuoi = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMA_KHUVUC = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTenNoiKBD = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaKBD = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtGT_THE_TU = New DevExpress.XtraEditors.DateEdit()
        Me.dtGT_THE_DEN = New DevExpress.XtraEditors.DateEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMA_VACH = New DevExpress.XtraEditors.MemoEdit()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSoLuongTE = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtNgaySinh = New DevExpress.XtraEditors.DateEdit()
        Me.txtnguoithan2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiaChiLienHe = New DevExpress.XtraEditors.TextEdit()
        Me.cmbQuanHe = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbNgheNghiep = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbDanToc = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtghichu = New DevExpress.XtraEditors.MemoEdit()
        Me.cmbDoiTuong = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbGioi_Tinh = New DevExpress.XtraEditors.LookUpEdit()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colhoten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgioitinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldantoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colns = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnghenghiep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnoilv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnguoithan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colquanhe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldclh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colghichu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsothebh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel_Buton = New System.Windows.Forms.Panel()
        CType(Me.txtTenBN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoTheBHYT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaBN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoiLamViec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Error_PhongKham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaThe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttylechitra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb.SuspendLayout()
        CType(Me.txtThangTuoi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMA_KHUVUC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenNoiKBD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaKBD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGT_THE_TU.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGT_THE_TU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGT_THE_DEN.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGT_THE_DEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMA_VACH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoLuongTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgaySinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnguoithan2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChiLienHe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbQuanHe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNgheNghiep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDanToc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtghichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDoiTuong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGioi_Tinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Buton.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(915, 10)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "&Thoát "
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(16, 10)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "&Nhập mới"
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(121, 10)
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
        Me.btnSua.Location = New System.Drawing.Point(331, 10)
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
        Me.btnXoa.Location = New System.Drawing.Point(436, 10)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "&Xoá"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(13, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Mã BN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Họ và tên"
        '
        'txtTenBN
        '
        Me.txtTenBN.EditValue = ""
        Me.txtTenBN.Location = New System.Drawing.Point(115, 52)
        Me.txtTenBN.Name = "txtTenBN"
        Me.txtTenBN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTenBN.Properties.Appearance.Options.UseFont = True
        Me.txtTenBN.Properties.AutoHeight = False
        Me.txtTenBN.Size = New System.Drawing.Size(390, 23)
        Me.txtTenBN.TabIndex = 2
        '
        'txtSoTheBHYT
        '
        Me.txtSoTheBHYT.EditValue = ""
        Me.txtSoTheBHYT.Location = New System.Drawing.Point(98, 20)
        Me.txtSoTheBHYT.Name = "txtSoTheBHYT"
        Me.txtSoTheBHYT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoTheBHYT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtSoTheBHYT.Properties.Appearance.Options.UseFont = True
        Me.txtSoTheBHYT.Properties.Appearance.Options.UseForeColor = True
        Me.txtSoTheBHYT.Properties.AutoHeight = False
        Me.txtSoTheBHYT.Size = New System.Drawing.Size(343, 20)
        Me.txtSoTheBHYT.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(545, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Nghề nghiệp"
        '
        'txtMaBN
        '
        Me.txtMaBN.EditValue = ""
        Me.txtMaBN.Location = New System.Drawing.Point(115, 27)
        Me.txtMaBN.Name = "txtMaBN"
        Me.txtMaBN.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaBN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaBN.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaBN.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaBN.Properties.Appearance.Options.UseFont = True
        Me.txtMaBN.Properties.Appearance.Options.UseForeColor = True
        Me.txtMaBN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaBN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMaBN.Properties.AutoHeight = False
        Me.txtMaBN.Properties.ReadOnly = True
        Me.txtMaBN.Size = New System.Drawing.Size(127, 23)
        Me.txtMaBN.TabIndex = 0
        '
        'txtDiaChi
        '
        Me.txtDiaChi.EditValue = ""
        Me.txtDiaChi.Location = New System.Drawing.Point(115, 102)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDiaChi.Properties.Appearance.Options.UseFont = True
        Me.txtDiaChi.Properties.AutoHeight = False
        Me.txtDiaChi.Size = New System.Drawing.Size(390, 23)
        Me.txtDiaChi.TabIndex = 6
        '
        'txtDienThoai
        '
        Me.txtDienThoai.EditValue = ""
        Me.txtDienThoai.Location = New System.Drawing.Point(115, 127)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDienThoai.Properties.Appearance.Options.UseFont = True
        Me.txtDienThoai.Properties.AutoHeight = False
        Me.txtDienThoai.Size = New System.Drawing.Size(390, 23)
        Me.txtDienThoai.TabIndex = 7
        '
        'txtNoiLamViec
        '
        Me.txtNoiLamViec.EditValue = ""
        Me.txtNoiLamViec.Location = New System.Drawing.Point(631, 27)
        Me.txtNoiLamViec.Name = "txtNoiLamViec"
        Me.txtNoiLamViec.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNoiLamViec.Properties.Appearance.Options.UseFont = True
        Me.txtNoiLamViec.Properties.AutoHeight = False
        Me.txtNoiLamViec.Size = New System.Drawing.Size(359, 23)
        Me.txtNoiLamViec.TabIndex = 8
        '
        'Error_PhongKham
        '
        Me.Error_PhongKham.ContainerControl = Me
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(226, 10)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 4
        Me.btnHuy.Text = "&Bỏ qua"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(303, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Tỷ lệ chi trả"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(190, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Mã thẻ"
        '
        'txtMaThe
        '
        Me.txtMaThe.EditValue = ""
        Me.txtMaThe.Location = New System.Drawing.Point(246, 44)
        Me.txtMaThe.Name = "txtMaThe"
        Me.txtMaThe.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMaThe.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaThe.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMaThe.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaThe.Properties.Appearance.Options.UseFont = True
        Me.txtMaThe.Properties.Appearance.Options.UseForeColor = True
        Me.txtMaThe.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaThe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMaThe.Properties.AutoHeight = False
        Me.txtMaThe.Size = New System.Drawing.Size(39, 20)
        Me.txtMaThe.TabIndex = 4
        '
        'txttylechitra
        '
        Me.txttylechitra.EditValue = ""
        Me.txttylechitra.Enabled = False
        Me.txttylechitra.Location = New System.Drawing.Point(390, 43)
        Me.txttylechitra.Name = "txttylechitra"
        Me.txttylechitra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txttylechitra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttylechitra.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txttylechitra.Properties.Appearance.Options.UseBackColor = True
        Me.txttylechitra.Properties.Appearance.Options.UseFont = True
        Me.txttylechitra.Properties.Appearance.Options.UseForeColor = True
        Me.txttylechitra.Properties.Appearance.Options.UseTextOptions = True
        Me.txttylechitra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttylechitra.Properties.AutoHeight = False
        Me.txttylechitra.Properties.ReadOnly = True
        Me.txttylechitra.Size = New System.Drawing.Size(51, 20)
        Me.txttylechitra.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(261, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Đối tượng"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(7, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 17)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Số thẻ"
        '
        'grb
        '
        Me.grb.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grb.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grb.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grb.Appearance.Options.UseBackColor = True
        Me.grb.Appearance.Options.UseFont = True
        Me.grb.Appearance.Options.UseForeColor = True
        Me.grb.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grb.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.grb.AppearanceCaption.Options.UseFont = True
        Me.grb.AppearanceCaption.Options.UseForeColor = True
        Me.grb.Controls.Add(Me.LabelControl3)
        Me.grb.Controls.Add(Me.txtThangTuoi)
        Me.grb.Controls.Add(Me.GroupBox1)
        Me.grb.Controls.Add(Me.Label25)
        Me.grb.Controls.Add(Me.LabelControl6)
        Me.grb.Controls.Add(Me.LabelControl5)
        Me.grb.Controls.Add(Me.LabelControl4)
        Me.grb.Controls.Add(Me.LabelControl1)
        Me.grb.Controls.Add(Me.txtSoLuongTE)
        Me.grb.Controls.Add(Me.CheckEdit1)
        Me.grb.Controls.Add(Me.Label8)
        Me.grb.Controls.Add(Me.Label12)
        Me.grb.Controls.Add(Me.Label7)
        Me.grb.Controls.Add(Me.Label13)
        Me.grb.Controls.Add(Me.Label5)
        Me.grb.Controls.Add(Me.Label1)
        Me.grb.Controls.Add(Me.Label18)
        Me.grb.Controls.Add(Me.Label17)
        Me.grb.Controls.Add(Me.Label16)
        Me.grb.Controls.Add(Me.Label15)
        Me.grb.Controls.Add(Me.dtNgaySinh)
        Me.grb.Controls.Add(Me.txtnguoithan2)
        Me.grb.Controls.Add(Me.txtDiaChiLienHe)
        Me.grb.Controls.Add(Me.cmbQuanHe)
        Me.grb.Controls.Add(Me.cmbNgheNghiep)
        Me.grb.Controls.Add(Me.cmbDanToc)
        Me.grb.Controls.Add(Me.txtMaBN)
        Me.grb.Controls.Add(Me.Label11)
        Me.grb.Controls.Add(Me.txtTenBN)
        Me.grb.Controls.Add(Me.Label2)
        Me.grb.Controls.Add(Me.Label10)
        Me.grb.Controls.Add(Me.txtDiaChi)
        Me.grb.Controls.Add(Me.txtDienThoai)
        Me.grb.Controls.Add(Me.txtNoiLamViec)
        Me.grb.Controls.Add(Me.txtghichu)
        Me.grb.Controls.Add(Me.cmbDoiTuong)
        Me.grb.Controls.Add(Me.cmbGioi_Tinh)
        Me.grb.Dock = System.Windows.Forms.DockStyle.Top
        Me.grb.Location = New System.Drawing.Point(0, 0)
        Me.grb.Name = "grb"
        Me.grb.Size = New System.Drawing.Size(998, 166)
        Me.grb.TabIndex = 0
        Me.grb.Text = "Thông tin bệnh nhân"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(281, 82)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl3.TabIndex = 69
        Me.LabelControl3.Text = "*"
        '
        'txtThangTuoi
        '
        Me.txtThangTuoi.EditValue = ""
        Me.txtThangTuoi.Location = New System.Drawing.Point(406, 77)
        Me.txtThangTuoi.Name = "txtThangTuoi"
        Me.txtThangTuoi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtThangTuoi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThangTuoi.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtThangTuoi.Properties.Appearance.Options.UseBackColor = True
        Me.txtThangTuoi.Properties.Appearance.Options.UseFont = True
        Me.txtThangTuoi.Properties.Appearance.Options.UseForeColor = True
        Me.txtThangTuoi.Properties.Appearance.Options.UseTextOptions = True
        Me.txtThangTuoi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtThangTuoi.Properties.AutoHeight = False
        Me.txtThangTuoi.Properties.ReadOnly = True
        Me.txtThangTuoi.Size = New System.Drawing.Size(99, 23)
        Me.txtThangTuoi.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMA_KHUVUC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTenNoiKBD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttylechitra)
        Me.GroupBox1.Controls.Add(Me.txtMaThe)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMaKBD)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.dtGT_THE_TU)
        Me.GroupBox1.Controls.Add(Me.dtGT_THE_DEN)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtMA_VACH)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtSoTheBHYT)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(600, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 188)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin thẻ BHYT"
        '
        'txtMA_KHUVUC
        '
        Me.txtMA_KHUVUC.EditValue = ""
        Me.txtMA_KHUVUC.Location = New System.Drawing.Point(98, 130)
        Me.txtMA_KHUVUC.Name = "txtMA_KHUVUC"
        Me.txtMA_KHUVUC.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMA_KHUVUC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMA_KHUVUC.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMA_KHUVUC.Properties.Appearance.Options.UseBackColor = True
        Me.txtMA_KHUVUC.Properties.Appearance.Options.UseFont = True
        Me.txtMA_KHUVUC.Properties.Appearance.Options.UseForeColor = True
        Me.txtMA_KHUVUC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMA_KHUVUC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMA_KHUVUC.Properties.AutoHeight = False
        Me.txtMA_KHUVUC.Size = New System.Drawing.Size(140, 20)
        Me.txtMA_KHUVUC.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(7, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Mã khu vực"
        '
        'txtTenNoiKBD
        '
        Me.txtTenNoiKBD.EditValue = ""
        Me.txtTenNoiKBD.Location = New System.Drawing.Point(98, 67)
        Me.txtTenNoiKBD.Name = "txtTenNoiKBD"
        Me.txtTenNoiKBD.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTenNoiKBD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenNoiKBD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtTenNoiKBD.Properties.Appearance.Options.UseBackColor = True
        Me.txtTenNoiKBD.Properties.Appearance.Options.UseFont = True
        Me.txtTenNoiKBD.Properties.Appearance.Options.UseForeColor = True
        Me.txtTenNoiKBD.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTenNoiKBD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTenNoiKBD.Properties.AutoHeight = False
        Me.txtTenNoiKBD.Size = New System.Drawing.Size(343, 37)
        Me.txtTenNoiKBD.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Tên CS KBĐ"
        '
        'txtMaKBD
        '
        Me.txtMaKBD.EditValue = ""
        Me.txtMaKBD.Location = New System.Drawing.Point(98, 44)
        Me.txtMaKBD.Name = "txtMaKBD"
        Me.txtMaKBD.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMaKBD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKBD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMaKBD.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaKBD.Properties.Appearance.Options.UseFont = True
        Me.txtMaKBD.Properties.Appearance.Options.UseForeColor = True
        Me.txtMaKBD.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaKBD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMaKBD.Properties.AutoHeight = False
        Me.txtMaKBD.Size = New System.Drawing.Size(70, 20)
        Me.txtMaKBD.TabIndex = 49
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(7, 46)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 17)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Mã KBĐ"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(58, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl2.TabIndex = 59
        Me.LabelControl2.Text = "*"
        '
        'dtGT_THE_TU
        '
        Me.dtGT_THE_TU.EditValue = Nothing
        Me.dtGT_THE_TU.Location = New System.Drawing.Point(98, 107)
        Me.dtGT_THE_TU.Name = "dtGT_THE_TU"
        Me.dtGT_THE_TU.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtGT_THE_TU.Properties.Appearance.Options.UseFont = True
        Me.dtGT_THE_TU.Properties.Appearance.Options.UseTextOptions = True
        Me.dtGT_THE_TU.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtGT_THE_TU.Properties.AutoHeight = False
        Me.dtGT_THE_TU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtGT_THE_TU.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtGT_THE_TU.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtGT_THE_TU.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtGT_THE_TU.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtGT_THE_TU.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtGT_THE_TU.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtGT_THE_TU.Size = New System.Drawing.Size(140, 20)
        Me.dtGT_THE_TU.TabIndex = 0
        '
        'dtGT_THE_DEN
        '
        Me.dtGT_THE_DEN.EditValue = Nothing
        Me.dtGT_THE_DEN.Location = New System.Drawing.Point(301, 107)
        Me.dtGT_THE_DEN.Name = "dtGT_THE_DEN"
        Me.dtGT_THE_DEN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtGT_THE_DEN.Properties.Appearance.Options.UseFont = True
        Me.dtGT_THE_DEN.Properties.Appearance.Options.UseTextOptions = True
        Me.dtGT_THE_DEN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtGT_THE_DEN.Properties.AutoHeight = False
        Me.dtGT_THE_DEN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtGT_THE_DEN.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtGT_THE_DEN.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtGT_THE_DEN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtGT_THE_DEN.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtGT_THE_DEN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtGT_THE_DEN.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtGT_THE_DEN.Size = New System.Drawing.Size(140, 20)
        Me.dtGT_THE_DEN.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(7, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 17)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "Mã vạch"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(7, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 17)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Giá trị : Từ"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(257, 109)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 17)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "đến"
        '
        'txtMA_VACH
        '
        Me.txtMA_VACH.Location = New System.Drawing.Point(98, 154)
        Me.txtMA_VACH.Name = "txtMA_VACH"
        Me.txtMA_VACH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMA_VACH.Properties.Appearance.Options.UseFont = True
        Me.txtMA_VACH.Size = New System.Drawing.Size(343, 33)
        Me.txtMA_VACH.TabIndex = 54
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(218, 80)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 16)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Ngày sinh"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(89, 105)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl6.TabIndex = 62
        Me.LabelControl6.Text = "*"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(89, 82)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl5.TabIndex = 61
        Me.LabelControl5.Text = "*"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(89, 56)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl4.TabIndex = 61
        Me.LabelControl4.Text = "*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(336, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "*"
        '
        'txtSoLuongTE
        '
        Me.txtSoLuongTE.EditValue = ""
        Me.txtSoLuongTE.Enabled = False
        Me.txtSoLuongTE.Location = New System.Drawing.Point(115, 247)
        Me.txtSoLuongTE.Name = "txtSoLuongTE"
        Me.txtSoLuongTE.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSoLuongTE.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuongTE.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtSoLuongTE.Properties.Appearance.Options.UseBackColor = True
        Me.txtSoLuongTE.Properties.Appearance.Options.UseFont = True
        Me.txtSoLuongTE.Properties.Appearance.Options.UseForeColor = True
        Me.txtSoLuongTE.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoLuongTE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoLuongTE.Properties.AutoHeight = False
        Me.txtSoLuongTE.Properties.ReadOnly = True
        Me.txtSoLuongTE.Size = New System.Drawing.Size(97, 23)
        Me.txtSoLuongTE.TabIndex = 51
        Me.txtSoLuongTE.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(28, 248)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Trẻ em"
        Me.CheckEdit1.Size = New System.Drawing.Size(70, 20)
        Me.CheckEdit1.TabIndex = 52
        Me.CheckEdit1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(13, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Điện thoại"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(545, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 16)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Ghi chú"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(13, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Địa chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(784, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Dân tộc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Giới tính"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(10, 212)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Địa chỉ liên hệ"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(545, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Người thân"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(545, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Nơi làm việc"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(545, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Quan hệ"
        '
        'dtNgaySinh
        '
        Me.dtNgaySinh.EditValue = Nothing
        Me.dtNgaySinh.Location = New System.Drawing.Point(292, 77)
        Me.dtNgaySinh.Name = "dtNgaySinh"
        Me.dtNgaySinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtNgaySinh.Properties.Appearance.Options.UseFont = True
        Me.dtNgaySinh.Properties.Appearance.Options.UseTextOptions = True
        Me.dtNgaySinh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtNgaySinh.Properties.AutoHeight = False
        Me.dtNgaySinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtNgaySinh.Size = New System.Drawing.Size(112, 23)
        Me.dtNgaySinh.TabIndex = 4
        '
        'txtnguoithan2
        '
        Me.txtnguoithan2.EditValue = ""
        Me.txtnguoithan2.Location = New System.Drawing.Point(631, 77)
        Me.txtnguoithan2.Name = "txtnguoithan2"
        Me.txtnguoithan2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtnguoithan2.Properties.Appearance.Options.UseFont = True
        Me.txtnguoithan2.Properties.AutoHeight = False
        Me.txtnguoithan2.Size = New System.Drawing.Size(359, 23)
        Me.txtnguoithan2.TabIndex = 10
        '
        'txtDiaChiLienHe
        '
        Me.txtDiaChiLienHe.EditValue = ""
        Me.txtDiaChiLienHe.Location = New System.Drawing.Point(115, 208)
        Me.txtDiaChiLienHe.Name = "txtDiaChiLienHe"
        Me.txtDiaChiLienHe.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtDiaChiLienHe.Properties.Appearance.Options.UseFont = True
        Me.txtDiaChiLienHe.Properties.AutoHeight = False
        Me.txtDiaChiLienHe.Size = New System.Drawing.Size(359, 23)
        Me.txtDiaChiLienHe.TabIndex = 15
        '
        'cmbQuanHe
        '
        Me.cmbQuanHe.Location = New System.Drawing.Point(631, 102)
        Me.cmbQuanHe.Name = "cmbQuanHe"
        Me.cmbQuanHe.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbQuanHe.Properties.Appearance.Options.UseFont = True
        Me.cmbQuanHe.Properties.AutoHeight = False
        Me.cmbQuanHe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuanHe.Properties.NullText = ""
        Me.cmbQuanHe.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbQuanHe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbQuanHe.Size = New System.Drawing.Size(141, 23)
        Me.cmbQuanHe.TabIndex = 11
        Me.cmbQuanHe.Tag = "Ma_donvi"
        '
        'cmbNgheNghiep
        '
        Me.cmbNgheNghiep.Location = New System.Drawing.Point(631, 52)
        Me.cmbNgheNghiep.Name = "cmbNgheNghiep"
        Me.cmbNgheNghiep.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbNgheNghiep.Properties.Appearance.Options.UseFont = True
        Me.cmbNgheNghiep.Properties.AutoHeight = False
        Me.cmbNgheNghiep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNgheNghiep.Properties.NullText = ""
        Me.cmbNgheNghiep.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbNgheNghiep.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNgheNghiep.Size = New System.Drawing.Size(359, 23)
        Me.cmbNgheNghiep.TabIndex = 9
        Me.cmbNgheNghiep.Tag = "Ma_donvi"
        '
        'cmbDanToc
        '
        Me.cmbDanToc.Location = New System.Drawing.Point(842, 102)
        Me.cmbDanToc.Name = "cmbDanToc"
        Me.cmbDanToc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbDanToc.Properties.Appearance.Options.UseFont = True
        Me.cmbDanToc.Properties.AutoHeight = False
        Me.cmbDanToc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDanToc.Properties.NullText = ""
        Me.cmbDanToc.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbDanToc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDanToc.Size = New System.Drawing.Size(148, 23)
        Me.cmbDanToc.TabIndex = 12
        Me.cmbDanToc.Tag = "Ma_donvi"
        '
        'txtghichu
        '
        Me.txtghichu.EditValue = ""
        Me.txtghichu.Location = New System.Drawing.Point(631, 127)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtghichu.Properties.Appearance.Options.UseFont = True
        Me.txtghichu.Size = New System.Drawing.Size(359, 23)
        Me.txtghichu.TabIndex = 13
        '
        'cmbDoiTuong
        '
        Me.cmbDoiTuong.Location = New System.Drawing.Point(351, 27)
        Me.cmbDoiTuong.Name = "cmbDoiTuong"
        Me.cmbDoiTuong.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbDoiTuong.Properties.Appearance.Options.UseFont = True
        Me.cmbDoiTuong.Properties.AutoHeight = False
        Me.cmbDoiTuong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDoiTuong.Properties.NullText = ""
        Me.cmbDoiTuong.Properties.PopupSizeable = False
        Me.cmbDoiTuong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDoiTuong.Size = New System.Drawing.Size(154, 23)
        Me.cmbDoiTuong.TabIndex = 1
        '
        'cmbGioi_Tinh
        '
        Me.cmbGioi_Tinh.Location = New System.Drawing.Point(115, 77)
        Me.cmbGioi_Tinh.Name = "cmbGioi_Tinh"
        Me.cmbGioi_Tinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbGioi_Tinh.Properties.Appearance.Options.UseFont = True
        Me.cmbGioi_Tinh.Properties.AutoHeight = False
        Me.cmbGioi_Tinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGioi_Tinh.Properties.NullText = ""
        Me.cmbGioi_Tinh.Properties.PopupSizeable = False
        Me.cmbGioi_Tinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbGioi_Tinh.Size = New System.Drawing.Size(97, 23)
        Me.cmbGioi_Tinh.TabIndex = 3
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 169)
        Me.grv.MainView = Me.GridView3
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(998, 261)
        Me.grv.TabIndex = 1
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.Colhoten, Me.coldc, Me.colgioitinh, Me.coldantoc, Me.colns, Me.colnghenghiep, Me.colnoilv, Me.coltel, Me.colnguoithan, Me.colquanhe, Me.coldclh, Me.colghichu, Me.colsothebh})
        Me.GridView3.GridControl = Me.grv
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã BN"
        Me.colma.FieldName = "MaBN"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.OptionsColumn.AllowFocus = False
        Me.colma.Visible = True
        Me.colma.VisibleIndex = 0
        Me.colma.Width = 106
        '
        'Colhoten
        '
        Me.Colhoten.Caption = "Họ và tên"
        Me.Colhoten.FieldName = "HoTenBN"
        Me.Colhoten.Name = "Colhoten"
        Me.Colhoten.OptionsColumn.AllowEdit = False
        Me.Colhoten.OptionsColumn.AllowFocus = False
        Me.Colhoten.Visible = True
        Me.Colhoten.VisibleIndex = 1
        Me.Colhoten.Width = 181
        '
        'coldc
        '
        Me.coldc.Caption = "Địa chỉ"
        Me.coldc.FieldName = "DiaChiChiTiet"
        Me.coldc.Name = "coldc"
        Me.coldc.OptionsColumn.AllowEdit = False
        Me.coldc.OptionsColumn.AllowFocus = False
        Me.coldc.Visible = True
        Me.coldc.VisibleIndex = 4
        Me.coldc.Width = 199
        '
        'colgioitinh
        '
        Me.colgioitinh.Caption = "Giới Tính"
        Me.colgioitinh.FieldName = "GioiTinh"
        Me.colgioitinh.Name = "colgioitinh"
        Me.colgioitinh.OptionsColumn.AllowEdit = False
        Me.colgioitinh.OptionsColumn.AllowFocus = False
        Me.colgioitinh.Visible = True
        Me.colgioitinh.VisibleIndex = 3
        Me.colgioitinh.Width = 67
        '
        'coldantoc
        '
        Me.coldantoc.Caption = "Dân tộc"
        Me.coldantoc.FieldName = "DanToc"
        Me.coldantoc.Name = "coldantoc"
        Me.coldantoc.OptionsColumn.AllowEdit = False
        Me.coldantoc.OptionsColumn.AllowFocus = False
        Me.coldantoc.Width = 62
        '
        'colns
        '
        Me.colns.Caption = "Ngày sinh"
        Me.colns.FieldName = "NgaySinh"
        Me.colns.Name = "colns"
        Me.colns.OptionsColumn.AllowEdit = False
        Me.colns.OptionsColumn.AllowFocus = False
        Me.colns.Visible = True
        Me.colns.VisibleIndex = 2
        Me.colns.Width = 99
        '
        'colnghenghiep
        '
        Me.colnghenghiep.Caption = "Nghề Nghiệp"
        Me.colnghenghiep.FieldName = "NgheNghiep"
        Me.colnghenghiep.Name = "colnghenghiep"
        Me.colnghenghiep.OptionsColumn.AllowEdit = False
        Me.colnghenghiep.OptionsColumn.AllowFocus = False
        Me.colnghenghiep.Visible = True
        Me.colnghenghiep.VisibleIndex = 5
        Me.colnghenghiep.Width = 111
        '
        'colnoilv
        '
        Me.colnoilv.Caption = "Nơi làm việc"
        Me.colnoilv.FieldName = "NoiLamViec"
        Me.colnoilv.Name = "colnoilv"
        Me.colnoilv.OptionsColumn.AllowEdit = False
        Me.colnoilv.OptionsColumn.AllowFocus = False
        '
        'coltel
        '
        Me.coltel.Caption = "Điện thoại"
        Me.coltel.FieldName = "DienThoai"
        Me.coltel.Name = "coltel"
        Me.coltel.OptionsColumn.AllowEdit = False
        Me.coltel.OptionsColumn.AllowFocus = False
        Me.coltel.Visible = True
        Me.coltel.VisibleIndex = 6
        Me.coltel.Width = 105
        '
        'colnguoithan
        '
        Me.colnguoithan.Caption = "Người thân"
        Me.colnguoithan.FieldName = "NguoiThan"
        Me.colnguoithan.Name = "colnguoithan"
        Me.colnguoithan.OptionsColumn.AllowEdit = False
        Me.colnguoithan.OptionsColumn.AllowFocus = False
        '
        'colquanhe
        '
        Me.colquanhe.Caption = "Quan hệ"
        Me.colquanhe.FieldName = "QuanHe"
        Me.colquanhe.Name = "colquanhe"
        Me.colquanhe.OptionsColumn.AllowEdit = False
        Me.colquanhe.OptionsColumn.AllowFocus = False
        '
        'coldclh
        '
        Me.coldclh.Caption = "Địa chỉ liên hệ"
        Me.coldclh.FieldName = "DiaChiLienHe"
        Me.coldclh.Name = "coldclh"
        Me.coldclh.OptionsColumn.AllowEdit = False
        Me.coldclh.OptionsColumn.AllowFocus = False
        '
        'colghichu
        '
        Me.colghichu.Caption = "Ghi chú"
        Me.colghichu.FieldName = "GhiChu"
        Me.colghichu.Name = "colghichu"
        Me.colghichu.OptionsColumn.AllowEdit = False
        Me.colghichu.OptionsColumn.AllowFocus = False
        Me.colghichu.Width = 129
        '
        'colsothebh
        '
        Me.colsothebh.Caption = "Số thẻ BHYT"
        Me.colsothebh.FieldName = "SoTheBHYT"
        Me.colsothebh.Name = "colsothebh"
        Me.colsothebh.Width = 193
        '
        'Panel_Buton
        '
        Me.Panel_Buton.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel_Buton.Controls.Add(Me.btnThoat)
        Me.Panel_Buton.Controls.Add(Me.btnSua)
        Me.Panel_Buton.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Buton.Controls.Add(Me.btnXoa)
        Me.Panel_Buton.Controls.Add(Me.btnThem)
        Me.Panel_Buton.Controls.Add(Me.btnHuy)
        Me.Panel_Buton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Buton.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel_Buton.Location = New System.Drawing.Point(0, 436)
        Me.Panel_Buton.Name = "Panel_Buton"
        Me.Panel_Buton.Size = New System.Drawing.Size(998, 43)
        Me.Panel_Buton.TabIndex = 8
        '
        'FRM_DM_BENHNHAN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 479)
        Me.Controls.Add(Me.Panel_Buton)
        Me.Controls.Add(Me.grb)
        Me.Controls.Add(Me.grv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FRM_DM_BENHNHAN"
        Me.Text = "DANH SÁCH BỆNH NHÂN"
        CType(Me.txtTenBN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoTheBHYT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaBN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoiLamViec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Error_PhongKham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaThe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttylechitra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb.ResumeLayout(False)
        Me.grb.PerformLayout()
        CType(Me.txtThangTuoi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtMA_KHUVUC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenNoiKBD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaKBD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGT_THE_TU.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGT_THE_TU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGT_THE_DEN.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGT_THE_DEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMA_VACH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoLuongTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgaySinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnguoithan2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChiLienHe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbQuanHe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNgheNghiep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDanToc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtghichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDoiTuong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGioi_Tinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Buton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FRM_DM_BENHNHAN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        flag = True
        loaddata()
        Loadcmb()
        Ctrl_QuyenForm(Me)
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        deactive_control()
        Maxma()
        isload = False
        Panel_Buton.Enabled = True
    End Sub

    Private Sub loaddata()
        Dim dts As New DataSet
        dt = BusinessLogic.Data.GetDataset("HOSOBN_GetAll", CommandType.StoredProcedure, Nothing, Nothing).Tables(0)
        grv.DataSource = dt
    End Sub
    Private Sub Loadcmb()
        Load_ComboBox("Select ma[Mã],ten[Nghề nghiệp] from DMCHUNG where loai=2 ", cmbNgheNghiep, CNNQLPHONGKHAM)
        Load_ComboBox("Select ma[Mã],ten[Dân tộc] from DMCHUNG where loai=3 ", cmbDanToc, CNNQLPHONGKHAM)
        Load_ComboBox("Select ma[Mã],ten[Quan hệ] from DMCHUNG where loai=6 ", cmbQuanHe, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT id[Mã],doituong[Đối tượng] From DM_DOITUONG", cmbDoiTuong, CNNQLPHONGKHAM)
        Load_ComboBox("select Id[Mã],Ten[Tên] from DM_GIOITINH", cmbGioi_Tinh, CNNQLPHONGKHAM)
        cmbDoiTuong.EditValue = DoiTuong.DICHVU
    End Sub
    Private Sub deactive_control()
        If (flag = False) Then
            Me.grb.Enabled = False
        Else
            Me.grb.Enabled = True
        End If
    End Sub

    Private Sub enabel_ctr()
        Me.txtMaBN.Enabled = False
        Me.grb.Enabled = True
    End Sub

    Private Sub clear_f()
        Try
            Dim txt As Object
            For Each txt In grb.Controls
                If txt.Name.Substring(0, 3).ToUpper = "TXT" Then
                    txt.Text = String.Empty
                End If
            Next
            cmbDanToc.EditValue = "K"
            cmbNgheNghiep.EditValue = ""
            cmbQuanHe.EditValue = ""
            cmbDoiTuong.EditValue = Integer.Parse(DoiTuong.DICHVU)
            cmbGioi_Tinh.EditValue = Integer.Parse(MdlCommon.GioiTinh.NAM)
            dtNgaySinh.DateTime = New DateTime(1990, 1, 1)
            dtGT_THE_TU.DateTime = New DateTime(Year(DateTime.Now), 1, 1)
            dtGT_THE_DEN.DateTime = New DateTime(Year(DateTime.Now), 12, 31)
        Catch ex As Exception

        End Try
    End Sub

    Private Function kiemtra() As Boolean
        kiemtra = True
        If (Me.txtMaBN.Text.Trim = "") Then
            kiemtra = False
            Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Error_PhongKham.SetError(Me.txtMaBN, "Chưa có mã bệnh nhân!")
            Me.Error_PhongKham.SetIconAlignment(Me.txtMaBN, ErrorIconAlignment.MiddleRight)
        End If

        If (Me.txtTenBN.Text.Trim = "") Then
            kiemtra = False
            Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Error_PhongKham.SetError(Me.txtTenBN, "Chưa có tên bệnh nhân!")
            Me.Error_PhongKham.SetIconAlignment(Me.txtTenBN, ErrorIconAlignment.MiddleRight)
        End If

        If cmbDoiTuong.EditValue Is Nothing Then
            kiemtra = False
            Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Error_PhongKham.SetError(Me.cmbDoiTuong, "Chưa chọn đối tượng bệnh nhân !")
            Me.Error_PhongKham.SetIconAlignment(Me.cmbDoiTuong, ErrorIconAlignment.MiddleRight)
        End If

        If cmbDoiTuong.EditValue = 0 Then
            If txtSoTheBHYT.Text = "" Then
                kiemtra = False
                Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.Error_PhongKham.SetError(Me.txtSoTheBHYT, "Chưa nhập số thẻ BHYT !")
                Me.Error_PhongKham.SetIconAlignment(Me.txtSoTheBHYT, ErrorIconAlignment.MiddleRight)
            End If
            If Me.txtSoTheBHYT.Text.Trim.Length <> 15 Then
                kiemtra = False
                MessageBox.Show("Số thẻ bảo hiểm không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMaThe.Text = ""
                txttylechitra.Text = ""
            End If

            If Me.dtGT_THE_TU.Text = "" Or Me.dtGT_THE_DEN.Text = "" Then
                kiemtra = False
                MessageBox.Show("Chưa nhập hạn sử dụng thẻ BHYT!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtGT_THE_TU.Text = ""
                dtGT_THE_DEN.Text = ""
                Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.Error_PhongKham.SetError(Me.dtGT_THE_TU, "!")
                Me.Error_PhongKham.SetIconAlignment(Me.dtGT_THE_TU, ErrorIconAlignment.MiddleRight)

                Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.Error_PhongKham.SetError(Me.dtGT_THE_DEN, "!")
                Me.Error_PhongKham.SetIconAlignment(Me.dtGT_THE_DEN, ErrorIconAlignment.MiddleRight)
            End If
        End If

        If cmbGioi_Tinh.EditValue Is Nothing Then
            kiemtra = False
            Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Error_PhongKham.SetError(Me.cmbGioi_Tinh, "Chưa chọn giới tính!")
            Me.Error_PhongKham.SetIconAlignment(Me.cmbGioi_Tinh, ErrorIconAlignment.MiddleRight)
        End If

        If txtDiaChi.Text.Trim() = "" Then
            kiemtra = False
            Me.Error_PhongKham.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.Error_PhongKham.SetError(Me.txtDiaChi, "Chưa nhập địa chỉ!")
            Me.Error_PhongKham.SetIconAlignment(Me.txtDiaChi, ErrorIconAlignment.MiddleRight)
        End If

    End Function

    Private Function kiemtrachuoi_So(ByVal myStr As String) As Boolean
        Dim flag As Boolean = False
        Try
            Dim temp As Double = Double.Parse(myStr)
            flag = True
        Catch
            flag = False
        End Try
        Return flag
    End Function

    Private Function Layma(ByVal strMa As String, ByVal strManhom As String, ByVal strkd As String) As String
        Dim strMaMoi As String = ""
        Dim i As Integer
        If Len(strMa) > 0 Then
            For i = 1 To Len(strMa)
                If IsNumeric(Mid(strMa, i, 1)) Then
                    strMaMoi &= Mid(strMa, i, 1)
                End If
            Next
        End If
        If IsNumeric(strMaMoi) Then
            strMaMoi = Val(strMaMoi) + 1
        Else
            strMaMoi = strkd
        End If
        While strMaMoi.Length < 6
            strMaMoi = "0" + strMaMoi
        End While
        Return strManhom + "-" + strMaMoi
    End Function

    Private Sub Maxma()
        Dim strMa As String = ""
        Dim Strmanhom As String
        Dim strSql As String
        Dim dt As New DataTable
        Try
            Strmanhom = NgayGioServer().Year
            strSql = "select max(CAST(RIGHT(MABN,6) AS BIGINT))[Ma] from HOSOBN where left(MABN,4)='" & Strmanhom & "'"
            dt = BusinessLogic.Data.GetDataset(strSql, CommandType.Text, Nothing, Nothing).Tables(0)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0)("Ma")) Then strMa = dt.Rows(0)("Ma")
            End If
            Me.txtMaBN.Text = Layma(strMa, Strmanhom, "000001")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FRM_DM_BENHNHAN_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            If Not passData_ Is Nothing Then
                passData_(Me.txtMaBN.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim b As Integer
        Dim sql As String
        If Me.txtMaBN.Text.Trim = "" Then
            MsgBox("Chưa chọn đối tượng để xóa!", MsgBoxStyle.Information, "Thông báo...")
        Else
            If KiemTra_TonTai_PhieuKham(txtMaBN.Text) = False Then
                MessageBox.Show("Bệnh nhân này đã phát sinh dịch vụ KCB...!")
                Return
            Else

            End If
            Try
                sql = "DELETE FROM HOSOBN WHERE  MaBN='" & Me.txtMaBN.Text.Trim & "'"
                b = MsgBox("Bạn có chắc chắn muốn xóa không?", MsgBoxStyle.YesNo, "Thông báo...")
                If (b = 6) Then
                    Command_Exc(sql, CNNQLPHONGKHAM)
                    loaddata()
                End If
            Catch ex As Exception
                MessageBox.Show("Có lỗi khi xóa dữ liệu!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        isload = True
    End Sub

    Private Function KiemTra_TonTai_PhieuKham(mabn As String) As Boolean
        Dim kq As Boolean = True
        Dim dt As DataTable = New DataTable()
        Dim sql As String = ""
        sql &= "select mabn from phieukhambenh where mabn='" & mabn & "' and huy=0"
        sql &= " union all select mabn from chi_tiet_new where mabn='" & mabn & "' and huy=0"
        dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dt.Rows.Count > 0 Then
            kq = False
        Else
            kq = True
        End If
        Return kq
    End Function

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If (Me.txtMaBN.Text.Trim = "") Then
            MsgBox("Chưa chọn đối tượng để sửa", MsgBoxStyle.Information, "Thông báo...")
        Else
            Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
            enabel_ctr()
            flag = False
        End If
        isload = True
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        flag = False
        Me.grb.Enabled = True
        deactive_control()
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Me.Error_PhongKham.SetError(Me.txtMaBN, "")
        Me.Error_PhongKham.SetError(Me.txtTenBN, "")
        clear_f()
        isload = True
        Me.Panel_Buton.Enabled = True
    End Sub

    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        flag = True
        deactive_control()
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        Clear_Control(Me)
        Clear_Control_DevExprees(Me)
        clear_f()
        Maxma()
        isload = False
        Me.txtMaBN.Properties.ReadOnly = True
        Me.Panel_Buton.Enabled = True
    End Sub

    Private Sub btnCap_nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        Dim sql As String = ""

        If (kiemtra() = True) Then
            If (flag = True) Then
                '==
                Dim cls As clsHoSoBn = New clsHoSoBn()
                Dim sMaBn As String = ""
                sMaBn = cls.hosobn_add(txtMaBN.Text, txtTenBN.Text, txtDiaChi.Text, cmbGioi_Tinh.EditValue, IIf(cmbDanToc.EditValue Is Nothing, "", cmbDanToc.EditValue), dtNgaySinh.DateTime, IIf(cmbNgheNghiep.EditValue Is Nothing, "", cmbNgheNghiep.EditValue), txtNoiLamViec.Text, txtDienThoai.Text, IIf(cmbQuanHe.EditValue Is Nothing, "", cmbQuanHe.EditValue), txtnguoithan2.Text, txtDiaChiLienHe.Text, txtghichu.Text, cmbDoiTuong.EditValue, txtSoTheBHYT.Text.Trim, Integer.Parse("0" + txtMaThe.Text), Integer.Parse("0" + txttylechitra.Text), txtMaKBD.Text, txtTenNoiKBD.Text, dtGT_THE_TU.DateTime, dtGT_THE_DEN.DateTime, txtMA_KHUVUC.Text)
                If sMaBn <> "" Then
                    txtMaBN.Text = sMaBn
                    MessageBox.Show("Dữ liệu đã được thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Có lỗi khi thêm mới dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                sql = "UPDATE HOSOBN set HoTenBN=N'" & txtTenBN.Text & "',DiaChiChiTiet=N'" & txtDiaChi.Text & "',GioiTinh='" & cmbGioi_Tinh.EditValue & "',DanToc='" & cmbDanToc.EditValue & "',NgaySinh='" & dtNgaySinh.DateTime & "',"
                sql &= "NgheNghiep=N'" & cmbNgheNghiep.EditValue & "',NoiLamViec=N'" & txtNoiLamViec.Text & "',DienThoai=N'" & txtDienThoai.Text & "',QuanHe='" & cmbQuanHe.EditValue & "',[NguoiThan]=N'" & txtnguoithan2.Text & "',"
                sql &= "DiaChiLienHe=N'" & txtDiaChiLienHe.Text & "',GhiChu=N'" & txtghichu.Text & "',DoiTuong=" & cmbDoiTuong.EditValue & ",SoTheBHYT=N'" & txtSoTheBHYT.Text & "',MaThe='" & txtMaThe.Text & "',TyLeChiTra='" & txttylechitra.Text & "',"
                sql &= "NoiKhamBanDau='" & txtMaKBD.Text & "',TenNoiKhamBanDau=N'" & txtTenNoiKBD.Text & "',TuNgay='" & dtGT_THE_TU.DateTime & "',DenNgay='" & dtGT_THE_DEN.DateTime & "',Ma_KhuVuc='" & txtMA_KHUVUC.Text & "' Where MaBN='" & txtMaBN.Text & "'"
                If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
                    MessageBox.Show("Dữ liệu đã được sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Có lỗi khi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            loaddata()
            Ctrl_QuyenForm(Me)
            isload = True
            Me.Panel_Buton.Enabled = True
        End If
    End Sub

    Private Function GetTen(ByVal Hoten As String) As String
        Hoten = Hoten.Trim
        Dim i, j As Int16
        Dim Kt As Char
        For i = 0 To Hoten.Length - 1
            Kt = Convert.ToChar(Hoten.Substring(i, 1))
            If Kt = " " Then
                j = i
            End If
        Next
        Hoten = Hoten.Substring(j + 1, 1).ToUpper & Hoten.Substring(j + 2)
        Return Hoten
    End Function

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub txtTenBN_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTenBN.EditValueChanged
        Me.Error_PhongKham.SetError(Me.txtTenBN, "")
    End Sub

    Private Sub txtSothe_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSoTheBHYT.LostFocus
        Dim dt As New DataTable
        Dim sqlstr As String
        sqlstr = "SELECT [SoTheBHYT] FROM HOSOBN WHERE [SoTheBHYT]<>'' and  [SoTheBHYT]=N'" & txtSoTheBHYT.Text.Trim & "'"
        If flag = True Then
            dt = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing).Tables(0)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Bệnh nhân này đã có trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Me.Close()
                isload = True
                Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
                sqlstr = "SELECT MaBN,TenBN,HoTenBN,DiaChiChiTiet,case GioiTinh when 1 then 'Nam'else N'Nữ' end as GioiTinh,d1.ten as DanToc,DanToc as MaDanToc,"
                sqlstr &= "NgaySinh,d2.ten as NgheNghiep ,NgheNghiep as MaNgheNghiep,NoiLamViec,DienThoai,SoTheBHYT,GioiTinh as MaGioiTinh,MaThe,"
                sqlstr &= "case DoiTuong when 0 then N'Bảo hiểm' else N'Dịch vụ' end as DoiTuong,DoiTuong as MaDoiTuong,TyLeChiTra, MaNhom,d4.ten as QuanHe,QuanHe as MaQuanHe,NguoiThan, "
                sqlstr &= "DiaChiLienHe,GhiChu,TuNgay,DenNgay,NoiKhamBanDau FROM HOSOBN b "
                sqlstr &= " left join DMCHUNG d1 on d1.ma=b.DanToc"
                sqlstr &= " left join DMCHUNG d2 on d2.ma=b.nghenghiep"
                sqlstr &= " left join DMCHUNG d4 on d4.ma=b.quanhe where SoTheBHYT= N'" & Me.txtSoTheBHYT.Text & "'"
                dt = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing).Tables(0)
                'Me.txtSothe.Text = ""
                'Me.txtSothe.Focus()
                'Exit Sub
                'Me.txtSothe.Focus()
                grv.DataSource = dt
            End If
        End If
        If Me.txtSoTheBHYT.Text.Trim <> "" Then
            If Me.txtSoTheBHYT.Text.Trim.Length <> 15 Then
                MessageBox.Show("Số thẻ bảo hiểm không đúng!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Try
            If Me.txtSoTheBHYT.Text.Trim.Length > 3 Then
                Me.txtMaThe.Text = Get_Maquyenloi(txtSoTheBHYT.Text)
                If Get_Maquyenloi(txtSoTheBHYT.Text) = 1 Or Get_Maquyenloi(txtSoTheBHYT.Text) = 2 Or Get_Maquyenloi(txtSoTheBHYT.Text) = 5 Then
                    Me.txttylechitra.Text = "0"
                ElseIf Get_Maquyenloi(txtSoTheBHYT.Text) = 3 Then
                    Me.txttylechitra.Text = "5"
                ElseIf Get_Maquyenloi(txtSoTheBHYT.Text) = 4 Or Get_Maquyenloi(txtSoTheBHYT.Text) = 7 Then
                    Me.txttylechitra.Text = "20"
                Else
                    Me.txttylechitra.Text = "0"
                End If
                txtMaKBD.Text = Get_KBD(txtSoTheBHYT.Text.Trim)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function Get_Maquyenloi(ByVal strSOTHEBH As String) As String
        strSOTHEBH = strSOTHEBH.Trim
        Return strSOTHEBH.Substring(2, 1)
    End Function
    Private Function Get_KBD(ByVal strSOTHEBH As String) As String
        strSOTHEBH = strSOTHEBH.Trim
        Return strSOTHEBH.Substring(15, 5)
    End Function
    Private Sub txtTenBN_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTenBN.Leave
        If txtTenBN.Text <> "" Then
            Me.txtTenBN.Text = ChuanHoaChuoi(Me.txtTenBN.Text).ToUpper()
        End If
    End Sub
    Private Sub txtSothe_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSoTheBHYT.Leave
        If txtSoTheBHYT.Text <> "" Then
            Me.txtSoTheBHYT.Text = Me.txtSoTheBHYT.Text.ToUpper()
        End If
    End Sub
    Private Sub txtDiachi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiaChi.Leave
        If txtDiaChi.Text <> "" Then
            Me.txtDiaChi.Text = ChuanHoaChuoi(txtDiaChi.Text)
        End If
    End Sub

    Private Sub GridView3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView3.Click
        Dim dr As DataRowView
        dr = Me.GridView3.GetRow(Me.GridView3.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView3.FocusedRowHandle <> -999999 Then
                If isload = True Then
                    txtMaBN.Text = dr("MaBN").ToString()
                    txtTenBN.Text = dr("HoTenBN").ToString()
                    If Not dr("DiaChiChiTiet") Is DBNull.Value Then
                        txtDiaChi.Text = dr("DiaChiChiTiet").ToString()
                    Else
                        txtDiaChi.Text = ""
                    End If

                    txttylechitra.Text = dr("TyLeChiTra").ToString()

                    If Not dr("NgaySinh") Is DBNull.Value Then
                        dtNgaySinh.DateTime = dr("NgaySinh")
                    Else
                        dtNgaySinh.Text = ""
                    End If

                    If Not dr("MaThe") Is DBNull.Value Then
                        txtMaThe.Text = dr("MaThe").ToString()
                    Else
                        txtMaThe.Text = ""
                    End If

                    If Not dr("DoiTuong") Is DBNull.Value Then
                        cmbDoiTuong.EditValue = dr("DoiTuong")
                    Else
                        cmbDoiTuong.EditValue = Nothing
                    End If

                    If Not dr("SoTheBHYT") Is DBNull.Value Then
                        txtSoTheBHYT.Text = dr("SoTheBHYT").ToString()
                    Else
                        txtSoTheBHYT.Text = ""
                    End If

                    If Not dr("MaNgheNghiep") Is DBNull.Value Then
                        cmbNgheNghiep.EditValue = dr("MaNgheNghiep")
                    Else
                        cmbNgheNghiep.EditValue = ""
                    End If


                    If Not dr("NguoiThan") Is DBNull.Value Then
                        txtnguoithan2.Text = dr("NguoiThan").ToString()
                    Else
                        txtnguoithan2.Text = ""
                    End If

                    If Not dr("DiaChiLienHe") Is DBNull.Value Then
                        txtDiaChiLienHe.Text = dr("DiaChiLienHe").ToString()
                    Else
                        txtDiaChiLienHe.Text = ""
                    End If

                    If Not dr("DienThoai") Is DBNull.Value Then
                        txtDienThoai.Text = dr("DienThoai").ToString()
                    Else
                        txtDienThoai.Text = ""
                    End If

                    If Not dr("GhiChu") Is DBNull.Value Then
                        txtghichu.Text = dr("GhiChu").ToString()
                    Else
                        txtghichu.Text = ""
                    End If

                    If Not dr("DanToc") Is DBNull.Value Then
                        cmbDanToc.EditValue = dr("MaDanToc")
                    Else
                        cmbDanToc.EditValue = ""
                    End If

                    If Not dr("GioiTinh") Is DBNull.Value Then
                        cmbGioi_Tinh.EditValue = dr("MaGioiTinh")
                    Else
                        cmbGioi_Tinh.EditValue = Nothing
                    End If

                    If Not dr("MaQuanHe") Is DBNull.Value Then
                        cmbQuanHe.EditValue = dr("MaQuanHe").ToString()
                    Else
                        cmbQuanHe.EditValue = ""
                    End If

                    If Not dr("NoiLamViec") Is DBNull.Value Then
                        txtNoiLamViec.Text = dr("NoiLamViec").ToString()
                    Else
                        txtNoiLamViec.Text = ""
                    End If

                    If Not dr("TuNgay") Is DBNull.Value Then
                        dtGT_THE_TU.DateTime = dr("TuNgay")
                    Else
                        dtGT_THE_TU.Text = ""
                    End If

                    If Not dr("DenNgay") Is DBNull.Value Then
                        dtGT_THE_DEN.DateTime = dr("DenNgay")
                    Else
                        dtGT_THE_DEN.Text = ""
                    End If

                    If Not dr("NoiKhamBanDau") Is DBNull.Value Then
                        txtMaKBD.Text = dr("NoiKhamBanDau")
                    Else
                        txtMaKBD.Text = ""
                    End If
                    If Not dr("TenNoiKhamBanDau") Is DBNull.Value Then
                        txtTenNoiKBD.Text = dr("TenNoiKhamBanDau").ToString()
                    Else
                        txtTenNoiKBD.Text = ""
                    End If

                    If Not dr("MA_KHUVUC") Is DBNull.Value Then
                        txtMA_KHUVUC.Text = dr("MA_KHUVUC").ToString()
                    Else
                        txtMA_KHUVUC.Text = ""
                    End If
                    txtMA_VACH.Text = ""
                End If
            End If
        End If
    End Sub

    'Private Sub GridView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView3.DoubleClick
    '    Dim dr As DataRowView
    '    dr = Me.GridView3.GetRow(Me.GridView3.FocusedRowHandle)
    '    If Not dr Is Nothing Then
    '        If Me.GridView3.FocusedRowHandle <> -999999 Then
    '            If isload = True Then
    '                Dim frm As New frm_hosobnchitiet
    '                frm.StartPosition = FormStartPosition.CenterScreen
    '                frm.Mabn = dr("MaBN").ToString()
    '                frm.Show()
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub txtnguoithan2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnguoithan2.Leave
        Me.txtnguoithan2.Text = ChuanHoaChuoi(Me.txtnguoithan2.Text)
    End Sub

    Private Sub cmbnghenghiep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNgheNghiep.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbNgheNghiep.EditValue = ""
        End If
    End Sub

    Private Sub cmbquanhe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbQuanHe.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbQuanHe.EditValue = ""
        End If
    End Sub

    Private Function Get_Ngay(ByVal strngay As String) As String
        strngay = strngay.Trim
        Return strngay.Substring(0, 2)
    End Function

    Private Function Get_Thang(ByVal strngay As String) As String
        strngay = strngay.Trim
        Return strngay.Substring(3, 2)
    End Function

    Private Function Get_nam(ByVal strngay As String) As String
        strngay = strngay.Trim
        Return strngay.Substring(6, 4)
    End Function

    Private Function InsoluotTE() As Integer
        Dim strSQL As String = "select isnull(COUNT(p.SoPhieu),0) a from PHIEUKHAMBENH p,HOSOBN h where p.MaBN=h.MaBN and p.DoiTuong=0 and YEAR(GETDATE())- YEAR(h.NgaySinh)<6 "
        Dim dtTE As New DataTable
        dtTE = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        If dtTE.Rows.Count > 0 Then
            If Not dtTE.Rows(0)(0) Is DBNull.Value Then
                Return Integer.Parse(dtTE.Rows(0)(0).ToString())
            End If
        Else
            Return 0
        End If
    End Function

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            Dim strTE As String
            strTE = InsoluotTE()
            While strTE.Length < 5
                strTE = "0" + strTE
            End While
            txtSoLuongTE.Text = strTE
        Else
            txtSoLuongTE.Text = ""
        End If
    End Sub

    Private Sub dtNgaySinh_EditValueChanged(sender As Object, e As EventArgs) Handles dtNgaySinh.EditValueChanged
        Try
            Dim ThangTuoi As String = MdlCommon.TinhThangTuoi(dtNgaySinh.DateTime.Date, 3)
            txtThangTuoi.Text = ThangTuoi
        Catch ex As Exception
            txtThangTuoi.Text = ""
        End Try
    End Sub

    Public Shared Function ConvertHexToString(ByVal hexInput As String, ByVal encoding As System.Text.Encoding) As String
        Dim numberChars As Integer = hexInput.Length
        Dim bytes As Byte() = New Byte(numberChars / 2 - 1) {}
        For i As Integer = 0 To numberChars - 1 Step 2
            bytes(i / 2) = Convert.ToByte(hexInput.Substring(i, 2), 16)
        Next
        Return encoding.GetString(bytes)
    End Function

    Private Sub txtMA_VACH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMA_VACH.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim kbd As String = ""
            Dim myCIintl As New System.Globalization.CultureInfo("en-US")
            myCIintl.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
            myCIintl.NumberFormat.NumberDecimalSeparator = "."
            myCIintl.NumberFormat.NumberGroupSeparator = ","
            myCIintl.NumberFormat.NumberDecimalDigits = 2
            Application.CurrentCulture = myCIintl
            cmbDoiTuong.EditValue = 0
            cmbGioi_Tinh.EditValue = txtMA_VACH.Text.Split("|")(3)
            txtTenBN.Text = ConvertHexToString(txtMA_VACH.Text.Split("|")(1), System.Text.Encoding.UTF8)
            txtSoTheBHYT.Text = txtMA_VACH.Text.Split("|")(0)
            txtDiaChi.Text = ConvertHexToString(txtMA_VACH.Text.Split("|")(4), System.Text.Encoding.UTF8)
            kbd = txtMA_VACH.Text.Split("|")(5)
            Dim kytu As Char() = {"–", "-"}
            Dim arr As String() = kbd.Split(kytu)
            txtMaKBD.Text = arr(0).Trim & arr(1).Trim
            dtNgaySinh.DateTime = CDate(txtMA_VACH.Text.Split("|")(2))
            dtGT_THE_TU.DateTime = CDate(txtMA_VACH.Text.Split("|")(6))
            dtGT_THE_DEN.DateTime = CDate(txtMA_VACH.Text.Split("|")(7))
            Dim dt As New DataTable
            Dim sqlstr As String
            sqlstr = "SELECT SoTheBHYT FROM HOSOBN WHERE SoTheBHYT<>'' and  SoTheBHYT=N'" & txtSoTheBHYT.Text.Trim & "'"
            If flag = True Then
                dt = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing).Tables(0)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show("Bệnh nhân này đã có trong hệ thống!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Me.Close()
                    isload = True
                    Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
                    sqlstr = "SELECT [MaBN],[TenBN],[HoTenBN],DiaChiChiTiet as MaDiaChiChiTiet,DiaChiChiTiet,case [GioiTinh] when 1 then 'Nam'else N'Nữ' end as [GioiTinh],"
                    sqlstr &= "d1.ten as [DanToc],DanToc as MaDanToc,[NgaySinh],d2.ten as [NgheNghiep] ,NgheNghiep as MaNgheNghiep,[NoiLamViec],[DienThoai],[SoTheBHYT],GioiTinh as MaGioiTinh,"
                    sqlstr &= "[MaThe], case [DoiTuong] when 0 then N'Bảo hiểm' else N'Dịch vụ' end as [DoiTuong],DoiTuong as MaDoiTuong, [TyLeChiTra], [MaNhom], d4.ten as [QuanHe], QuanHe as MaQuanHe,[NguoiThan], "
                    sqlstr &= "[DiaChiLienHe],[GhiChu],TuNgay,DenNgay,NoiKhamBanDau FROM [HOSOBN] b "
                    sqlstr &= " left join DMCHUNG d1 on d1.ma=b.DanToc"
                    sqlstr &= " left join DMCHUNG d2 on d2.ma=b.nghenghiep"
                    sqlstr &= " left join DMCHUNG d4 on d4.ma=b.quanhe where SoTheBHYT= N'" & Me.txtSoTheBHYT.Text & "'"
                    dt = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing).Tables(0)
                    grv.DataSource = dt
                End If
            End If
            If Me.txtSoTheBHYT.Text.Trim <> "" Then
                If Me.txtSoTheBHYT.Text.Trim.Length <> 15 Then
                    MessageBox.Show("Số thẻ bảo hiểm không đúng!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Try
                If Me.txtSoTheBHYT.Text.Trim.Length > 3 Then
                    Me.txtMaThe.Text = Get_Maquyenloi(txtSoTheBHYT.Text)
                    If Get_Maquyenloi(txtSoTheBHYT.Text) = 1 Or Get_Maquyenloi(txtSoTheBHYT.Text) = 2 Or Get_Maquyenloi(txtSoTheBHYT.Text) = 5 Then
                        Me.txttylechitra.Text = "0"
                    ElseIf Get_Maquyenloi(txtSoTheBHYT.Text) = 3 Then
                        Me.txttylechitra.Text = "5"
                    ElseIf Get_Maquyenloi(txtSoTheBHYT.Text) = 4 Or Get_Maquyenloi(txtSoTheBHYT.Text) = 7 Then
                        Me.txttylechitra.Text = "20"
                    Else
                        Me.txttylechitra.Text = "0"
                    End If
                    txtMaKBD.Text = Get_KBD(txtSoTheBHYT.Text.Trim)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmbdoituong_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbDoiTuong.EditValueChanged
        If cmbDoiTuong.EditValue = "0" Then
            txtSoTheBHYT.Enabled = True
        Else
            txtSoTheBHYT.Enabled = False
        End If
    End Sub
End Class
