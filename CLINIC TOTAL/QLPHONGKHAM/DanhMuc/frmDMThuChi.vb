Public Class frmDMThuChi
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean
    Private ID As Int16
    Public IDmoi As String
    Private dtb As DataTable
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colloai As DevExpress.XtraGrid.Columns.GridColumn
    Public Key As Boolean
    Private isload As Boolean = False
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel_Button As Panel
    Private obj As New ClsDMThuChi
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
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RdbThu As System.Windows.Forms.RadioButton
    Friend WithEvents RdbChi As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDMThuChi))
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.RdbChi = New System.Windows.Forms.RadioButton()
        Me.RdbThu = New System.Windows.Forms.RadioButton()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colloai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.txtMa = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã thu chi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên thu chi"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(11, 7)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(110, 7)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 5
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(209, 7)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 7
        Me.btnHuy.Text = "&Bỏ qua "
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(308, 7)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 9
        Me.btnSua.Text = "&Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(407, 7)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "&Xoá"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(628, 7)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "&Thoát "
        '
        'RdbChi
        '
        Me.RdbChi.AutoSize = True
        Me.RdbChi.BackColor = System.Drawing.Color.Transparent
        Me.RdbChi.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.RdbChi.ForeColor = System.Drawing.Color.Red
        Me.RdbChi.Location = New System.Drawing.Point(536, 16)
        Me.RdbChi.Name = "RdbChi"
        Me.RdbChi.Size = New System.Drawing.Size(77, 20)
        Me.RdbChi.TabIndex = 4
        Me.RdbChi.Text = "Phiếu chi"
        Me.RdbChi.UseVisualStyleBackColor = False
        '
        'RdbThu
        '
        Me.RdbThu.AutoSize = True
        Me.RdbThu.BackColor = System.Drawing.Color.Transparent
        Me.RdbThu.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.RdbThu.ForeColor = System.Drawing.Color.Red
        Me.RdbThu.Location = New System.Drawing.Point(455, 16)
        Me.RdbThu.Name = "RdbThu"
        Me.RdbThu.Size = New System.Drawing.Size(79, 20)
        Me.RdbThu.TabIndex = 3
        Me.RdbThu.Text = "Phiếu thu"
        Me.RdbThu.UseVisualStyleBackColor = False
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 88)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(728, 329)
        Me.grv.TabIndex = 11
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.colten, Me.colloai})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã "
        Me.colma.FieldName = "matc"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.OptionsColumn.AllowFocus = False
        Me.colma.Visible = True
        Me.colma.VisibleIndex = 0
        Me.colma.Width = 105
        '
        'colten
        '
        Me.colten.Caption = "Tên loại TC"
        Me.colten.FieldName = "tenloaitc"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 1
        Me.colten.Width = 284
        '
        'colloai
        '
        Me.colloai.Caption = "Loại"
        Me.colloai.FieldName = "loai"
        Me.colloai.Name = "colloai"
        Me.colloai.OptionsColumn.AllowEdit = False
        Me.colloai.OptionsColumn.AllowFocus = False
        Me.colloai.Visible = True
        Me.colloai.VisibleIndex = 2
        Me.colloai.Width = 104
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.RdbChi)
        Me.GroupControl1.Controls.Add(Me.RdbThu)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.txtTen)
        Me.GroupControl1.Controls.Add(Me.txtMa)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(728, 84)
        Me.GroupControl1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(100, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 14)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(100, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "*"
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(122, 43)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Properties.AutoHeight = False
        Me.txtTen.Size = New System.Drawing.Size(513, 22)
        Me.txtTen.TabIndex = 5
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(122, 16)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Properties.AutoHeight = False
        Me.txtMa.Size = New System.Drawing.Size(271, 22)
        Me.txtMa.TabIndex = 5
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 422)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(728, 41)
        Me.Panel_Button.TabIndex = 13
        '
        'frmDMThuChi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 463)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grv)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDMThuChi"
        Me.Text = "DANH MỤC NGHIỆP VỤ THU CHI"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmDMThuChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        Ctrl_QuyenForm(Me)
        Me.RdbThu.Checked = True
        Me.btnThem.Enabled = True
        Me.btnSua.Enabled = True
        Me.btnXoa.Enabled = True
        Me.btnThoat.Enabled = True
        isload = True
    End Sub
    Private Sub LoadData()
        Dim dtb = New DataTable
        dtb = BusinessLogic.Data.GetDataset("SELECT matc,tenloaitc,(case loai when 1 then 'Thu' when 0 then 'Chi' end) as loai,ID From DM_Thu_Chi", CommandType.Text, Nothing, Nothing).Tables(0)
        Me.grv.DataSource = dtb
    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtMa.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtMa, "Trường mã thu chi không để rỗng")
            ErrPro.SetIconAlignment(Me.txtMa, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtTen.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtTen, "Trường tên loại thu chi không để rỗng")
            ErrPro.SetIconAlignment(Me.txtTen, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Sub tnbThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        ID = 0
        Clear_Control(Me.GroupControl1)
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        isload = False
    End Sub

    Private Sub btnCap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Kiem_Tra() = True Then
            If Flag = True Then
                If obj.Adddnew(Me.txtMa.Text, Me.txtTen.Text, Me.RdbThu.Checked, 1) = True Then
                    MsgBox("Chú ý! Mã thu chi đã tồn tại", MsgBoxStyle.Critical)
                End If
            Else
                If obj.Update(Me.txtMa.Text, Me.txtTen.Text, 2, ID) Then
                    MsgBox("Chú ý! Mã thu chi đã tồn tại", MsgBoxStyle.Critical)
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
        If MsgBox("Bạn có thật sự muốn xoá bản ghi này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            obj.Delete(Me.txtMa.Text, 3)
            LoadData()
        End If
        Clear_Control(Me.GroupControl1)
        isload = True
    End Sub

    Private Sub frmThuChi_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Key = True Then
            dtb = BusinessLogic.Data.GetDataset("Select MaTC from DM_Thu_Chi where ID = (select Max(ID) from DM_Thu_Chi)", CommandType.Text, Nothing, Nothing).Tables(0)
            If dtb.Rows.Count > 0 Then
                IDmoi = dtb.Rows(0)("MaTC")
            End If
        End If
    End Sub
 

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If isload = True Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Me.txtMa.Text = dr("matc")
                    Me.txtTen.Text = dr("tenloaitc")
                    If dr("loai") = "Thu" Then
                        RdbThu.Checked = True
                    Else
                        RdbChi.Checked = True
                    End If
                    ID = dr("ID")
                End If
            End If
        End If
    End Sub
End Class
