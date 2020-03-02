Public Class frmDanhmucPhong
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean = False
    Private ID As Int16
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ctenphong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cghichu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbkhoa As DevExpress.XtraEditors.LookUpEdit
    Public IDmoi As String
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtMota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTennhom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents colkhoa As DevExpress.XtraGrid.Columns.GridColumn

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhmucPhong))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbkhoa = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ctenphong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cghichu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colkhoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtMota = New DevExpress.XtraEditors.TextEdit()
        Me.txtTennhom = New DevExpress.XtraEditors.TextEdit()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.cmbkhoa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtMota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTennhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(292, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Khoa"
        '
        'cmbkhoa
        '
        Me.cmbkhoa.Location = New System.Drawing.Point(362, 29)
        Me.cmbkhoa.Name = "cmbkhoa"
        Me.cmbkhoa.Properties.AutoHeight = False
        Me.cmbkhoa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbkhoa.Properties.NullText = ""
        Me.cmbkhoa.Size = New System.Drawing.Size(187, 22)
        Me.cmbkhoa.TabIndex = 1
        '
        'chkActive
        '
        Me.chkActive.BackColor = System.Drawing.Color.Transparent
        Me.chkActive.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.chkActive.ForeColor = System.Drawing.Color.Red
        Me.chkActive.Location = New System.Drawing.Point(118, 109)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(127, 20)
        Me.chkActive.TabIndex = 4
        Me.chkActive.Text = "Ngừng hoạt động"
        Me.chkActive.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ghi chú"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã phòng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên phòng"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(474, 17)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "&Thoát "
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(16, 17)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(107, 17)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 4
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(198, 17)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 5
        Me.btnHuy.Text = "&Bỏ qua "
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(289, 17)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 7
        Me.btnSua.Text = "&Sửa "
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(380, 17)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "&Xoá "
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 142)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grv.Size = New System.Drawing.Size(580, 277)
        Me.grv.TabIndex = 9
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cMA, Me.ctenphong, Me.cghichu, Me.cactive, Me.colkhoa})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cMA
        '
        Me.cMA.Caption = "Mã"
        Me.cMA.FieldName = "MAPhongBN"
        Me.cMA.Name = "cMA"
        Me.cMA.OptionsColumn.AllowEdit = False
        Me.cMA.OptionsColumn.AllowFocus = False
        Me.cMA.Visible = True
        Me.cMA.VisibleIndex = 0
        Me.cMA.Width = 82
        '
        'ctenphong
        '
        Me.ctenphong.Caption = "Tên phòng"
        Me.ctenphong.FieldName = "TENPhongBN"
        Me.ctenphong.Name = "ctenphong"
        Me.ctenphong.OptionsColumn.AllowEdit = False
        Me.ctenphong.OptionsColumn.AllowFocus = False
        Me.ctenphong.Visible = True
        Me.ctenphong.VisibleIndex = 1
        Me.ctenphong.Width = 174
        '
        'cghichu
        '
        Me.cghichu.Caption = "Ghi chú"
        Me.cghichu.FieldName = "Mota"
        Me.cghichu.Name = "cghichu"
        Me.cghichu.OptionsColumn.AllowEdit = False
        Me.cghichu.OptionsColumn.AllowFocus = False
        Me.cghichu.Visible = True
        Me.cghichu.VisibleIndex = 3
        Me.cghichu.Width = 93
        '
        'cactive
        '
        Me.cactive.Caption = "Sử dụng"
        Me.cactive.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.cactive.FieldName = "Active"
        Me.cactive.Name = "cactive"
        Me.cactive.OptionsColumn.AllowEdit = False
        Me.cactive.OptionsColumn.AllowFocus = False
        Me.cactive.Visible = True
        Me.cactive.VisibleIndex = 4
        Me.cactive.Width = 52
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ReadOnly = True
        '
        'colkhoa
        '
        Me.colkhoa.Caption = "Tên Khoa"
        Me.colkhoa.FieldName = "TenKhoa"
        Me.colkhoa.Name = "colkhoa"
        Me.colkhoa.OptionsColumn.AllowEdit = False
        Me.colkhoa.OptionsColumn.AllowFocus = False
        Me.colkhoa.Visible = True
        Me.colkhoa.VisibleIndex = 2
        Me.colkhoa.Width = 140
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grv
        Me.GridView2.Name = "GridView2"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.TxtMota)
        Me.GroupControl1.Controls.Add(Me.txtTennhom)
        Me.GroupControl1.Controls.Add(Me.txtID)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.chkActive)
        Me.GroupControl1.Controls.Add(Me.cmbkhoa)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(580, 139)
        Me.GroupControl1.TabIndex = 10
        Me.GroupControl1.Text = "Thông tin phòng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(94, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 14)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(338, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 14)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(94, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "*"
        '
        'TxtMota
        '
        Me.TxtMota.Location = New System.Drawing.Point(118, 81)
        Me.TxtMota.Name = "TxtMota"
        Me.TxtMota.Properties.AutoHeight = False
        Me.TxtMota.Size = New System.Drawing.Size(431, 22)
        Me.TxtMota.TabIndex = 3
        '
        'txtTennhom
        '
        Me.txtTennhom.Location = New System.Drawing.Point(118, 55)
        Me.txtTennhom.Name = "txtTennhom"
        Me.txtTennhom.Properties.AutoHeight = False
        Me.txtTennhom.Size = New System.Drawing.Size(431, 22)
        Me.txtTennhom.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(118, 29)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.AutoHeight = False
        Me.txtID.Size = New System.Drawing.Size(136, 22)
        Me.txtID.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnThoat)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Controls.Add(Me.btnHuy)
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.btnCap_nhat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 425)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 54)
        Me.Panel1.TabIndex = 11
        '
        'frmDanhmucPhong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(596, 518)
        Me.Name = "frmDanhmucPhong"
        Me.Text = "DANH MỤC PHÒNG"
        CType(Me.cmbkhoa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtMota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTennhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmNhomSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_ComboBox("Select makhoa[Mã],tenkhoa[Tên khoa] from tb_dmkhoa", cmbkhoa, CNNQLPHONGKHAM)
        LoadData()
        Ctrl_QuyenForm(Me)
        Me.grv.Enabled = True
    End Sub
    Private Sub LoadData()
        Dim dts As New DataSet
        Dim sqlstr As String = " SELECT p.ID,[MAPhongBN],[TENPhongBN],p.Mota,Active,p.MaKhoa,k.TenKhoa from [DM_PhongBN] p inner join tb_dmkhoa k on p.makhoa=k.makhoa"
        dts = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing)
        Me.grv.DataSource = dts.Tables(0)
    End Sub

    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtID.Text.Trim() = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtID, "Trường mã nhóm sản phẩm không để rỗng")
            ErrPro.SetIconAlignment(Me.txtID, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtTennhom.Text.Trim() = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtTennhom, "Trường tên nhóm sản phẩm không để rỗng")
            ErrPro.SetIconAlignment(Me.txtTennhom, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        ID = 0
        Clear_Control(Me.GroupControl1)
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        'Me.grv.Enabled = False
    End Sub
    
    Private Sub btnCap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Kiem_Tra() = True Then
            Dim dts As New DataSet
            Dim sqlstr As String
            Dim dtexit As DataTable
            Dim inactinct As Integer
            Try
                If (chkActive.Checked = True) Then
                    inactinct = 1
                Else
                    inactinct = 0
                End If
            Catch ex As Exception

            End Try
            If Flag = True Then
                sqlstr = " SELECT * from [DM_PhongBN] where MAPhongBN=N'" & txtID.Text & "'"
                dts = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing)
                dtexit = dts.Tables(0)
                If (dtexit.Rows.Count > 0) Then
                    MsgBox("Chú ý! Mã đã tồn tại", MsgBoxStyle.Critical)
                    Return
                Else
                    sqlstr = "Insert into DM_PhongBN(MAPhongBN,TENPhongBN,Mota,Active,makhoa)values('" & txtID.Text & "',N'" & txtTennhom.Text & "',N'" & TxtMota.Text & "',N'" & inactinct & "','" & cmbkhoa.EditValue & "')"
                    Command_Exc(sqlstr, CNNQLPHONGKHAM)
                    'dtexit = Load_DataTable(sqlstr, CNNQLPHONGKHAM)
                End If
            Else
                sqlstr = "Update DM_PhongBN set MAPhongBN=N'" & txtID.Text.ToString() & "',TENPhongBN=N'" & txtTennhom.Text & "',Mota =N'" & TxtMota.Text & "',Active=N'" & inactinct & "',Makhoa='" & cmbkhoa.EditValue & "' where ID='" & ID & "' "
                Command_Exc(sqlstr, CNNQLPHONGKHAM)
                'dtexit = Load_DataTable(sqlstr, CNNQLPHONGKHAM)
            End If
            LoadData()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Flag = False
            ErrPro.Dispose()
        End If
        Me.grv.Enabled = True
    End Sub

    Private Sub btnHuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.GroupControl1.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        Me.grv.Enabled = True
    End Sub

    Private Sub btnSua_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Flag = False
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.grv.Enabled = False
        Me.txtID.Enabled = False
    End Sub

    Private Sub btnXoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        'Dim cls As New ClsNhomSP
        If MsgBox("Bạn có thật sự muốn xoá bản ghi này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim sqlstr As String
            Dim dtexit As DataTable
            sqlstr = "Delete from DM_PhongBN  where MAPhongBN=N'" & txtID.Text & "' "
            Command_Exc(sqlstr, CNNQLPHONGKHAM)
            'dtexit = Load_DataTable(sqlstr, CNNQLPHONGKHAM)
            LoadData()
        End If
    End Sub



    Private Sub dgData_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grv.DoubleClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                Try
                    Me.txtID.Text = dr("MAPhongBN").ToString()
                Catch ex As Exception

                End Try
                Try
                    Me.txtTennhom.Text = dr("TENPhongBN").ToString()
                Catch ex As Exception

                End Try
                Try
                    Me.TxtMota.Text = dr("Mota").ToString()
                Catch ex As Exception

                End Try
                Try
                    Me.chkActive.Checked = CType(dr("Active"), Boolean)
                Catch ex As Exception

                End Try
                If Not dr("Makhoa") Is DBNull.Value Then
                    cmbkhoa.EditValue = dr("Makhoa").ToString()
                End If
            End If
        End If
    End Sub

    Private Sub dgData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grv.Click
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                Try
                    Me.txtID.Text = dr("MAPhongBN").ToString()
                Catch ex As Exception

                End Try
                Try
                    Me.txtTennhom.Text = dr("TENPhongBN").ToString()
                Catch ex As Exception

                End Try
                Try
                    Me.TxtMota.Text = dr("Mota").ToString()
                Catch ex As Exception

                End Try
                Try
                    Me.chkActive.Checked = CType(dr("Active"), Boolean)
                Catch ex As Exception

                End Try
                Try
                    ID = dr("ID").ToString()
                Catch ex As Exception

                End Try
                If Not dr("Makhoa") Is DBNull.Value Then
                    cmbkhoa.EditValue = dr("Makhoa").ToString()
                End If
            End If
        End If
    End Sub

    Private Sub cmbkhoa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkhoa.EditValueChanged
        If cmbkhoa.EditValue <> "" Then
            Dim dts As New DataSet
            Dim sqlstr As String = " SELECT p.ID,[MAPhongBN],[TENPhongBN],p.Mota,Active,p.MaKhoa,k.TenKhoa from [DM_PhongBN] p inner join tb_dmkhoa k on p.makhoa=k.makhoa where p.Makhoa='" & cmbkhoa.EditValue & "'"
            dts = BusinessLogic.Data.GetDataset(sqlstr, CommandType.Text, Nothing, Nothing)
            Me.grv.DataSource = dts.Tables(0)
        End If

    End Sub
End Class
