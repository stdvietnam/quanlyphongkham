Public Class frmNhomSP
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean = False
    Private ID As Int16
    Public IDmoi As String
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmota As DevExpress.XtraGrid.Columns.GridColumn
    Private isload As Boolean = False
    Private obj As New ClsNhomSP
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtManhom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTennhom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel_Button As Panel
    Private bo As Boolean
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhomSP))
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
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtMota = New DevExpress.XtraEditors.TextEdit()
        Me.txtTennhom = New DevExpress.XtraEditors.TextEdit()
        Me.txtManhom = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_Button = New System.Windows.Forms.Panel()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtMota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTennhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mô tả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã nhóm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên nhóm"
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
        Me.btnThoat.Location = New System.Drawing.Point(674, 18)
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
        Me.btnThem.Location = New System.Drawing.Point(21, 18)
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
        Me.btnCap_nhat.Location = New System.Drawing.Point(117, 18)
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
        Me.btnHuy.Location = New System.Drawing.Point(213, 18)
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
        Me.btnSua.Location = New System.Drawing.Point(309, 18)
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
        Me.btnXoa.Location = New System.Drawing.Point(405, 18)
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
        Me.grv.Location = New System.Drawing.Point(0, 94)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(773, 335)
        Me.grv.TabIndex = 9
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.colten, Me.colmota})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã nhóm"
        Me.colma.FieldName = "manhom"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.OptionsColumn.AllowFocus = False
        Me.colma.OptionsColumn.FixedWidth = True
        Me.colma.Visible = True
        Me.colma.VisibleIndex = 0
        Me.colma.Width = 97
        '
        'colten
        '
        Me.colten.Caption = "Tên nhóm"
        Me.colten.FieldName = "tennhom"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 1
        Me.colten.Width = 346
        '
        'colmota
        '
        Me.colmota.Caption = "Mô tả"
        Me.colmota.FieldName = "mota"
        Me.colmota.Name = "colmota"
        Me.colmota.OptionsColumn.AllowEdit = False
        Me.colmota.OptionsColumn.AllowFocus = False
        Me.colmota.Visible = True
        Me.colmota.VisibleIndex = 2
        Me.colmota.Width = 311
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.TxtMota)
        Me.GroupControl1.Controls.Add(Me.txtTennhom)
        Me.GroupControl1.Controls.Add(Me.txtManhom)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(773, 90)
        Me.GroupControl1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(93, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 14)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(93, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 14)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "*"
        '
        'TxtMota
        '
        Me.TxtMota.Location = New System.Drawing.Point(116, 59)
        Me.TxtMota.Name = "TxtMota"
        Me.TxtMota.Properties.AutoHeight = False
        Me.TxtMota.Size = New System.Drawing.Size(431, 22)
        Me.TxtMota.TabIndex = 6
        '
        'txtTennhom
        '
        Me.txtTennhom.Location = New System.Drawing.Point(116, 33)
        Me.txtTennhom.Name = "txtTennhom"
        Me.txtTennhom.Properties.AutoHeight = False
        Me.txtTennhom.Size = New System.Drawing.Size(431, 22)
        Me.txtTennhom.TabIndex = 6
        '
        'txtManhom
        '
        Me.txtManhom.Location = New System.Drawing.Point(116, 7)
        Me.txtManhom.Name = "txtManhom"
        Me.txtManhom.Properties.AutoHeight = False
        Me.txtManhom.Size = New System.Drawing.Size(141, 22)
        Me.txtManhom.TabIndex = 6
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
        Me.Panel_Button.Location = New System.Drawing.Point(0, 433)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(773, 55)
        Me.Panel_Button.TabIndex = 11
        '
        'frmNhomSP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 488)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grv)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNhomSP"
        Me.Text = "NHÓM SẢN PHẨM - DỊCH VỤ"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtMota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTennhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmNhomSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        Ctrl_QuyenForm(Me)
        isload = True
    End Sub
    Private Sub LoadData()
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset("SELECT manhom,tennhom,mota,ID,active From Nhom_SP", CommandType.Text, Nothing, Nothing).Tables(0)
        Me.grv.DataSource = dtb
    End Sub

    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtManhom.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtManhom, "Trường mã nhóm sản phẩm không để rỗng")
            ErrPro.SetIconAlignment(Me.txtManhom, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtTennhom.Text = "" Then
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
        Me.GroupControl1.Enabled = True
        Me.txtManhom.Text = Lay_ma_khach()
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        isload = False
    End Sub
    Public Function Lay_ma_khach() As Int32
        Dim dtbmakh As New DataTable
        dtbmakh = BusinessLogic.Data.GetDataset("SELECT Max(cast(MaNhom as int))as Makh FROM Nhom_Sp ", CommandType.Text, Nothing, Nothing).Tables(0)
        If dtbmakh.Rows.Count > 0 And Not IsDBNull(dtbmakh.Rows(0)("makh")) Then
            Return dtbmakh.Rows(0)("makh") + 1
        Else
            Return 10
        End If
    End Function
    Private Sub btnCap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Kiem_Tra() = True Then
            If Flag = True Then
                If obj.Adddnew(Me.txtManhom.Text, Me.txtTennhom.Text, Me.TxtMota.Text, 1) = True Then
                    MsgBox("Chú ý! Mã nhóm sản phẩm đã tồn tại", MsgBoxStyle.Critical)
                End If
            Else
                If obj.Update(Me.txtManhom.Text, Me.txtTennhom.Text, Me.TxtMota.Text, 2, ID) Then
                    MsgBox("Chú ý! Mã nhóm sản phẩm đã tồn tại", MsgBoxStyle.Critical)
                End If
            End If
            LoadData()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Flag = False
            ErrPro.Dispose()
            isload = True
        End If
    End Sub

    Private Sub btnHuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.GroupControl1.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
        Flag = False
    End Sub

    Private Sub btnSua_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Flag = False
        Me.GroupControl1.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        isload = True
    End Sub

    Private Sub btnXoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If Me.txtManhom.Text = "" Then
            MsgBox("Bạn chưa chọn đối tượng cần xóa!", MsgBoxStyle.Critical, "Thông báo...")
        Else
            If bo = True Then
                MsgBox("Nhóm này không được phép xóa!", MsgBoxStyle.Critical, "Thông báo...")
                Return
            Else
                If MsgBox("Bạn có thật sự muốn xoá bản ghi này không", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    obj.Delete(Me.txtManhom.Text, 3)
                    LoadData()
                End If
                isload = True
            End If

        End If

    End Sub
    Private Sub frmNhomSP_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset("Select Manhom from nhom_sp where ID=(select Max(ID) from nhom_sp)", CommandType.Text, Nothing, Nothing).Tables(0)
        If dtb.Rows.Count > 0 Then
            IDmoi = dtb.Rows(0)("Manhom")
        End If
    End Sub

    Private Sub txtManhom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtManhom.Text <> "" Then
            Me.txtManhom.Text = Me.txtManhom.Text.TrimStart()
            Me.txtManhom.Text = Me.txtManhom.Text.TrimEnd()
            Me.txtManhom.Text = Me.txtManhom.Text.ToUpper()
            If Len(Me.txtManhom.Text) = 1 Then
                MsgBox("Chú ý! Mã nhóm phải nhập 2 ký tự!", MsgBoxStyle.Critical)
                Me.txtManhom.Focus()
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
                    Me.txtManhom.Text = dr("manhom")
                    Me.txtTennhom.Text = dr("tennhom")
                    Me.TxtMota.Text = dr("mota")
                    ID = dr("ID")
                    bo = dr("active")
                End If
            End If
        End If
    End Sub
End Class
