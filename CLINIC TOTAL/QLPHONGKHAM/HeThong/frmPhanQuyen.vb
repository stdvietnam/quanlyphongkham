Public Class frmPhanQuyen
    Inherits frmBase 'System.Windows.Forms.Form
    Private Flag As Boolean
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private ID As Int16
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
    Friend WithEvents TrvPhan_quyen As System.Windows.Forms.TreeView
    Friend WithEvents CmbMaNhomNSD As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTenNhomNSD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhanQuyen))
        Me.TrvPhan_quyen = New System.Windows.Forms.TreeView()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.TxtTenNhomNSD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbMaNhomNSD = New System.Windows.Forms.ComboBox()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrvPhan_quyen
        '
        Me.TrvPhan_quyen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrvPhan_quyen.CheckBoxes = True
        Me.TrvPhan_quyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvPhan_quyen.ImageIndex = 0
        Me.TrvPhan_quyen.ImageList = Me.imgList
        Me.TrvPhan_quyen.Location = New System.Drawing.Point(2, 74)
        Me.TrvPhan_quyen.Name = "TrvPhan_quyen"
        Me.TrvPhan_quyen.RightToLeftLayout = True
        Me.TrvPhan_quyen.SelectedImageIndex = 0
        Me.TrvPhan_quyen.ShowNodeToolTips = True
        Me.TrvPhan_quyen.Size = New System.Drawing.Size(549, 417)
        Me.TrvPhan_quyen.TabIndex = 3
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "")
        Me.imgList.Images.SetKeyName(1, "")
        '
        'TxtTenNhomNSD
        '
        Me.TxtTenNhomNSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTenNhomNSD.Location = New System.Drawing.Point(103, 36)
        Me.TxtTenNhomNSD.Name = "TxtTenNhomNSD"
        Me.TxtTenNhomNSD.Size = New System.Drawing.Size(227, 23)
        Me.TxtTenNhomNSD.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên nhóm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã nhóm :"
        '
        'CmbMaNhomNSD
        '
        Me.CmbMaNhomNSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMaNhomNSD.Location = New System.Drawing.Point(103, 9)
        Me.CmbMaNhomNSD.Name = "CmbMaNhomNSD"
        Me.CmbMaNhomNSD.Size = New System.Drawing.Size(227, 24)
        Me.CmbMaNhomNSD.TabIndex = 1
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(369, 17)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 3
        Me.btnCap_nhat.Text = "&Cập nhật"
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(462, 17)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "&Thoát"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.TxtTenNhomNSD)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.btnThoat)
        Me.GroupControl1.Controls.Add(Me.btnCap_nhat)
        Me.GroupControl1.Controls.Add(Me.CmbMaNhomNSD)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(552, 71)
        Me.GroupControl1.TabIndex = 5
        '
        'frmPhanQuyen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(552, 493)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.TrvPhan_quyen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(568, 532)
        Me.MinimumSize = New System.Drawing.Size(568, 532)
        Me.Name = "frmPhanQuyen"
        Me.Text = "PHÂN QUYỀN"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmPhanQuyen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Flag = True
        Dim strQuyen As String = ""
        Khoi_tao_Form()
        Flag = False
    End Sub
    Private Function Khoi_tao_Form()
        Dim dtbNhomNSD As New DataTable
        Dim dtbNhomNSDckeck As New DataTable
        Dim ndRoot As New TreeNode
        Dim ndChild_Level1 As TreeNode
        Dim ndChild_Level2 As TreeNode
        Dim int_i, int_j As Integer
        Dim arrRight(3) As String
        dtbNhomNSD = BusinessLogic.Data.GetDataset("Select Ma_cn,Ten_Cnang From Phan_Quyen order by Ten_cnang", CommandType.Text, Nothing, Nothing).Tables(0)
        Load_ComboBox("Select ID,Ma_Nhom From Nhom_NSD", Me.CmbMaNhomNSD, CNNQLPHONGKHAM)
        Me.CmbMaNhomNSD.SelectedIndex = -1
        arrRight = Split("Thêm mới;Sửa;Xoá;Tất cả quyền;", ";", -1, CompareMethod.Text)
        ndRoot.Text = "Danh mục các chức năng"
        ndRoot.Tag = "Root"
        ndRoot.ImageIndex = 1
        Me.TrvPhan_quyen.Nodes.Add(ndRoot)
        Me.TrvPhan_quyen.ExpandAll()
        If dtbNhomNSD.Rows.Count > 0 Then
            For int_i = 0 To dtbNhomNSD.Rows.Count - 1
                ndChild_Level1 = New TreeNode
                ndChild_Level1.ImageIndex = 0
                ndChild_Level1.Text = dtbNhomNSD.Rows(int_i)("Ten_Cnang")
                ndChild_Level1.Tag = dtbNhomNSD.Rows(int_i)("Ma_cn")
                Me.TrvPhan_quyen.Nodes(0).Nodes.Add(ndChild_Level1)
                For int_j = 0 To UBound(arrRight) - 1
                    ndChild_Level2 = New TreeNode
                    ndChild_Level2.Text = arrRight(int_j)
                    ndChild_Level2.Tag = int_j + 1
                    Me.TrvPhan_quyen.Nodes(0).Nodes(int_i).Nodes.Add(ndChild_Level2)
                Next
            Next
        End If
    End Function
    Private Sub CmbMaNhomNSD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMaNhomNSD.SelectedIndexChanged
        If Flag = False Then
            Dim strSQL As String = ""
            Dim i As Int16
            Dim dtbNhomNSD As New DataTable
            Dim strQuyen As String = ""
            Dim arrNodeParent(20) As String
            Flag = True
            dtbNhomNSD = BusinessLogic.Data.GetDataset("select ID, Ma_nhom,Ten_nhom,quyen from Nhom_NSD WHERE ID='" & Me.CmbMaNhomNSD.SelectedValue & "'", CommandType.Text, Nothing, Nothing).Tables(0)
            If dtbNhomNSD.Rows.Count > 0 Then
                Me.TxtTenNhomNSD.Text = dtbNhomNSD.Rows(0)("Ten_nhom")
                strQuyen = dtbNhomNSD.Rows(0)("quyen")
                ID = dtbNhomNSD.Rows(0)("ID")
            End If
            arrNodeParent = Split(strQuyen, ";", -1, CompareMethod.Text)
            Dim nd As TreeNode
            For Each nd In Me.TrvPhan_quyen.Nodes(0).Nodes
                nd.Checked = False
                duyetcaydel(nd)
            Next
            For Each nd In Me.TrvPhan_quyen.Nodes(0).Nodes
                For i = 0 To UBound(arrNodeParent) - 1
                    If arrNodeParent(i) = nd.Tag Then
                        nd.Checked = True
                        duyetCay(nd, Me.CmbMaNhomNSD.Text, nd.Tag)
                    End If
                Next
            Next
            Flag = False
        End If

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nd As TreeNode
        For Each nd In Me.TrvPhan_quyen.Nodes(0).Nodes
            If nd.Checked = True Then
                If Not nd.NextNode Is Nothing Then
                    duyetCay(nd, Me.CmbMaNhomNSD.Text, nd.Tag)
                End If
            End If
        Next
    End Sub
    Private Sub duyetCay(ByVal ndChild As TreeNode, ByVal Manhom As String, ByVal MaCn As String)
        Dim nd As TreeNode
        Dim j As Int16
        Dim strQuyenChild As String
        Dim dtbNhomNSDchk As New DataTable
        Dim arrNodeChild(4) As String
        dtbNhomNSDchk = BusinessLogic.Data.GetDataset("select ID,Quyen_Form from Nhom_Quyen WHERE Ma_nhom ='" & Manhom & "' AND Ma_Cn ='" & MaCn & "'", CommandType.Text, Nothing, Nothing).Tables(0)
        If dtbNhomNSDchk.Rows.Count > 0 Then
            If Not IsDBNull(dtbNhomNSDchk.Rows(0)("Quyen_Form")) Then strQuyenChild = dtbNhomNSDchk.Rows(0)("Quyen_Form")
            'strQuyenChild = dtbNhomNSDchk.Rows(0)("Quyen_Form")
        End If
        arrNodeChild = Split(strQuyenChild, ";", -1, CompareMethod.Text)
        Dim thu As String
        Dim thu1 As String
        For Each nd In ndChild.Nodes
            For j = 0 To UBound(arrNodeChild) - 1
                thu = arrNodeChild(j)
                thu1 = nd.Tag
                If arrNodeChild(j) = nd.Tag Then
                    nd.Checked = True
                End If
            Next
        Next
    End Sub
    Private Sub duyetcaydel(ByVal ndChild As TreeNode)
        Dim nd As TreeNode
        For Each nd In ndChild.Nodes
            nd.Checked = False
        Next
    End Sub

    Private Sub BtNhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Kiem_Tra() = True Then
            Dim nd As TreeNode
            Dim strQuyen As String
            Dim cls As New ClsPhanquyen
            cls.DeleteChild(Me.CmbMaNhomNSD.Text, 3)
            For Each nd In Me.TrvPhan_quyen.Nodes(0).Nodes
                If nd.Checked = True Then
                    strQuyen = strQuyen & nd.Tag & ";"
                    DuyetcayChild(nd, Me.CmbMaNhomNSD.Text, nd.Tag)
                End If
            Next
            If cls.Update(Me.CmbMaNhomNSD.Text, strQuyen, 3, ID) Then
                MsgBox("Chú ý! Mã nhóm người sử dụng đã tồn tại", MsgBoxStyle.Critical)
            Else
                MsgBox("Đã cập nhật thành công.")
            End If
        End If
    End Sub
    Private Sub DuyetcayChild(ByVal ndChild As TreeNode, ByVal Manhom As String, ByVal MaCn As String)
        Dim cls As New ClsPhanquyen
        Dim nd As TreeNode
        Dim strQuyenChild As String
        For Each nd In ndChild.Nodes
            If nd.Checked = True Then
                strQuyenChild = strQuyenChild & nd.Tag & ";"
            End If
        Next
        cls.AdddnewChild(Manhom, MaCn, strQuyenChild, 1)
    End Sub
    Private Sub TrvPhan_quyen_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TrvPhan_quyen.AfterCheck
        Dim nd As TreeNode
        If e.Node.GetNodeCount(False) >= 1 Then
            If e.Node.Checked = False Then
                For Each nd In e.Node.Nodes
                    nd.Checked = False
                Next
            End If
        Else
            If e.Node.Checked = True Then
                e.Node.Parent.Checked = True
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.CmbMaNhomNSD.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.CmbMaNhomNSD, "Phải chọn mã nhóm trước khi phân quyền")
            ErrPro.SetIconAlignment(Me.CmbMaNhomNSD, ErrorIconAlignment.MiddleRight)
        End If
    End Function

    Private Sub CmbMaNhomNSD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbMaNhomNSD.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim frmKh As New frmNhom_NSD
            frmKh.ShowDialog()
            Load_ComboBox("Select Ma_nhom,Ten_nhom from Nhom_NSD", Me.CmbMaNhomNSD, CNNQLPHONGKHAM)
            Me.CmbMaNhomNSD.ValueMember = frmKh.IDmoi
        End If
    End Sub
End Class
