Public Class frmThemKhoHang
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean
    Private ID As Int16
    Public IDmoi As String
    Private dtb As DataTable
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colthukho As DevExpress.XtraGrid.Columns.GridColumn
    Public Key As Boolean
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtTenthukho As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemKhoHang))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colthukho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtTenthukho = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.txtMa = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtTenthukho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tên thủ kho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã kho"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(204, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Kho"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(15, 10)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(116, 10)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 5
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(217, 10)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 7
        Me.btnHuy.Text = "&Bỏ qua "
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(318, 10)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 9
        Me.btnSua.Text = "&Sửa "
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(419, 10)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "&Xoá "
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(725, 10)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "&Thoát "
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 93)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(829, 316)
        Me.grv.TabIndex = 11
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.colten, Me.coladd, Me.colthukho})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.HorzScrollStep = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã kho"
        Me.colma.FieldName = "makho"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.OptionsColumn.FixedWidth = True
        Me.colma.Visible = True
        Me.colma.VisibleIndex = 0
        '
        'colten
        '
        Me.colten.Caption = "Tên kho"
        Me.colten.FieldName = "tenkho"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 1
        Me.colten.Width = 259
        '
        'coladd
        '
        Me.coladd.Caption = "Địa chỉ"
        Me.coladd.FieldName = "diachi"
        Me.coladd.Name = "coladd"
        Me.coladd.OptionsColumn.AllowEdit = False
        Me.coladd.OptionsColumn.AllowFocus = False
        Me.coladd.Visible = True
        Me.coladd.VisibleIndex = 2
        Me.coladd.Width = 291
        '
        'colthukho
        '
        Me.colthukho.Caption = "Thủ kho"
        Me.colthukho.FieldName = "tenthukho"
        Me.colthukho.Name = "colthukho"
        Me.colthukho.OptionsColumn.AllowEdit = False
        Me.colthukho.OptionsColumn.AllowFocus = False
        Me.colthukho.Visible = True
        Me.colthukho.VisibleIndex = 3
        Me.colthukho.Width = 185
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.TxtTenthukho)
        Me.GroupControl1.Controls.Add(Me.TxtDiaChi)
        Me.GroupControl1.Controls.Add(Me.txtTen)
        Me.GroupControl1.Controls.Add(Me.txtMa)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(829, 89)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Thông tin kho"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(266, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 14)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(71, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "*"
        '
        'TxtTenthukho
        '
        Me.TxtTenthukho.Location = New System.Drawing.Point(96, 58)
        Me.TxtTenthukho.Name = "TxtTenthukho"
        Me.TxtTenthukho.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtTenthukho.Properties.Appearance.Options.UseFont = True
        Me.TxtTenthukho.Properties.AutoHeight = False
        Me.TxtTenthukho.Size = New System.Drawing.Size(470, 23)
        Me.TxtTenthukho.TabIndex = 15
        '
        'TxtDiaChi
        '
        Me.TxtDiaChi.Location = New System.Drawing.Point(96, 33)
        Me.TxtDiaChi.Name = "TxtDiaChi"
        Me.TxtDiaChi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtDiaChi.Properties.Appearance.Options.UseFont = True
        Me.TxtDiaChi.Properties.AutoHeight = False
        Me.TxtDiaChi.Size = New System.Drawing.Size(470, 23)
        Me.TxtDiaChi.TabIndex = 15
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(287, 8)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTen.Properties.Appearance.Options.UseFont = True
        Me.txtTen.Properties.AutoHeight = False
        Me.txtTen.Size = New System.Drawing.Size(279, 23)
        Me.txtTen.TabIndex = 15
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(96, 8)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMa.Properties.Appearance.Options.UseFont = True
        Me.txtMa.Properties.AutoHeight = False
        Me.txtMa.Size = New System.Drawing.Size(91, 23)
        Me.txtMa.TabIndex = 15
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 414)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(829, 46)
        Me.Panel_Button.TabIndex = 13
        '
        'frmThemKhoHang
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 460)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemKhoHang"
        Me.Text = "DANH MỤC KHO"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtTenthukho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmThemKhoHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        Ctrl_QuyenForm(Me)
        isload = True

    End Sub

    Private Sub LoadData()
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("SELECT makho,tenkho,diachi,tenthukho,ID From Kho_hang", CommandType.Text, Nothing, Nothing)
        Me.grv.DataSource = dts.Tables(0)
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtMa.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtMa, "Trường mã tiền tệ không để rỗng")
            ErrPro.SetIconAlignment(Me.txtMa, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtTen.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtTen, "Trường tên tiền tệ không để rỗng")
            ErrPro.SetIconAlignment(Me.txtTen, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        ID = 0
        Clear_Control(Me.GroupControl1)
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        Me.txtMa.Enabled = True
        isload = False
    End Sub
    Private Sub btnHuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.GroupControl1.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
    End Sub
    Private Sub btnSua_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Flag = False
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        Me.txtMa.Enabled = False
        isload = True
    End Sub
    Private Sub btnXoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim strSQL As String = ""
        Dim clskho As New ClsKhohang
        If kiemtrakho() = True Then
        Else
            If MsgBox("Khi bạn xóa kho các sản phẩm thuộc kho này sẽ bị xóa. Bạn có thật sự muốn xoá kho này không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                clskho.Delete(Me.txtMa.Text, 3)
                'clskho.xoaKhohang(Me.txtMa.Text, 3)
                strSQL = "Delete san_pham where makho='" & Me.txtMa.Text & "'"
                Command_Exc(strSQL, CNNQLPHONGKHAM)
                LoadData()
                isload = True
            End If
        End If
    End Sub
    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub btnCap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim clskho As New ClsKhohang
        If Kiem_Tra() = True Then
            If Flag = True Then
                If clskho.Adddnew(Me.txtMa.Text, Me.txtTen.Text, Me.TxtDiaChi.Text, Me.TxtTenthukho.Text, 1) = True Then
                    MsgBox("Chú ý! Mã kho  đã tồn tại", MsgBoxStyle.Critical)
                Else
                End If
            Else
                If clskho.Update(Me.txtMa.Text, Me.txtTen.Text, Me.TxtDiaChi.Text, Me.TxtTenthukho.Text, 2, ID) = True Then
                    MsgBox("Chú ý! Mã kho  đã tồn tại", MsgBoxStyle.Critical)
                End If
            End If
            LoadData()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Flag = False
            ErrPro.Dispose()
            Key = True
            isload = True
        End If
    End Sub
    Private Sub frmThemKhoHang_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim dts As New DataSet
        If Key = True Then
            dts = BusinessLogic.Data.GetDataset("Select Makho from Kho_Hang where ID = (select Max(ID) from Kho_Hang)", CommandType.Text, Nothing, Nothing)
            dtb = dts.Tables(0)
            If dtb.Rows.Count > 0 Then
                IDmoi = dtb.Rows(0)("Makho")
            End If
        End If
    End Sub
    Private Function kiemtrakho() As Boolean
        Dim Makho As String = ""
        Dim dt1 As New DataTable
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("select Makho from phieu_xuat_nhap where huy=0 group by Makho union all select Makho from Tb_Kedonthuoc where huy=0 and Makho not in (select Makho from phieu_xuat_nhap where huy=0 group by Makho) group by Makho", CommandType.Text, Nothing, Nothing)
        dt1 = dts.Tables(0)
        For i As Integer = 0 To dt1.Rows.Count - 1
            If dt1.Rows.Count > 0 Then
                Makho = dt1.Rows(i)("Makho")
            End If
            If Me.txtMa.Text = Makho Then
                MsgBox("Không thể xóa kho này!", MsgBoxStyle.Critical, "Cảnh báo!")
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
                    Me.txtMa.Text = dr("makho")
                    Me.txtTen.Text = dr("tenkho")
                    If Not dr("diachi") Is DBNull.Value Then
                        Me.TxtDiaChi.Text = dr("diachi").ToString()
                    End If
                    If Not dr("tenthukho") Is DBNull.Value Then
                        TxtTenthukho.Text = dr("tenthukho").ToString()
                    End If
                    ID = dr("ID")
                End If
            End If
        End If
    End Sub

    Private Sub TxtTenthukho_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtTenthukho.Text = ChuanHoaChuoi(TxtTenthukho.Text)
    End Sub
End Class
