Public Class frmCapNhatGia
    Inherits frm_base 'System.Windows.Forms.Form
    Private i As Int16
    Private Flag As Boolean = False
    Private Ngay As DateTime
    Private style As Boolean
    Private dtbsp As New DataTable
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private foundclick As Boolean = True

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
    Friend WithEvents cmbnhom As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapNhatGia))
        Me.cmbnhom = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.cmbnhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbnhom
        '
        Me.cmbnhom.EditValue = ""
        Me.cmbnhom.Location = New System.Drawing.Point(109, 17)
        Me.cmbnhom.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbnhom.Name = "cmbnhom"
        Me.cmbnhom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbnhom.Properties.Appearance.Options.UseFont = True
        Me.cmbnhom.Properties.AutoHeight = False
        Me.cmbnhom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbnhom.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("manhom", "Mã nhóm", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tennhom", "Tên nhóm", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbnhom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbnhom.Size = New System.Drawing.Size(362, 24)
        Me.cmbnhom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nhóm Sp/Dv"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(630, 17)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "&Thoát"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Location = New System.Drawing.Point(523, 17)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "&Lưu"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Location = New System.Drawing.Point(1, 64)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(749, 432)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mã "
        Me.GridColumn2.FieldName = "Masp"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 56
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tên dịch vụ"
        Me.GridColumn3.FieldName = "tensp"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 331
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Giá nhập"
        Me.GridColumn4.DisplayFormat.FormatString = "###,###.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "gianhap"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 93
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Giá xuất"
        Me.GridColumn5.DisplayFormat.FormatString = "###,###.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Dongia"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 89
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.cmbnhom)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(750, 62)
        Me.GroupControl1.TabIndex = 21
        Me.GroupControl1.Text = "Phần lựa chọn"
        '
        'frmCapNhatGia
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(750, 496)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmCapNhatGia"
        Me.Text = "CẬP NHẬT GIÁ DỊCH VỤ"
        CType(Me.cmbnhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTonkhodauky_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_ComboBox("Select manhom,Tennhom from nhom_SP order by Tennhom", Me.cmbnhom, CNNQLPHONGKHAM)
        loaddata()
        Flag = True
    End Sub
    Private Sub loaddata()
        Dim dtb As New DataTable
        dtbsp = BusinessLogic.Data.GetDataset("select s.Masp,s.Manhom,Nhom_SP.TenNhom + ' ' + s.tensp as tensp,s.Dongia,s.gianhap,s.id from  San_pham s INNER JOIN Nhom_SP ON s.MaNhom = Nhom_SP.MaNhom").Tables(0)
        Me.GridControl1.DataSource = dtbsp
    End Sub

    Private Sub cmbnhom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnhom.EditValueChanged
        If Flag = True Then
            If Me.cmbnhom.EditValue <> "" Then
                dtbsp = BusinessLogic.Data.GetDataset("select s.Masp,s.Manhom,Nhom_SP.TenNhom + ' ' + s.tensp as tensp,s.Dongia,s.gianhap,s.id from  San_pham s INNER JOIN Nhom_SP ON s.MaNhom = Nhom_SP.MaNhom WHERE  s.MaNhom ='" & Me.cmbnhom.EditValue & "'").Tables(0)
                Me.GridControl1.DataSource = dtbsp
            Else
                MsgBox("Chưa chọn nhóm dịch vụ!")
            End If
        End If
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.cmbnhom.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.cmbnhom, "Phải chọn nhóm sản phẩm")
            ErrPro.SetIconAlignment(Me.cmbnhom, ErrorIconAlignment.MiddleRight)
        End If

    End Function

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Dim strSQL As String
        If Kiem_Tra() = True Then
            For i = 0 To dtbsp.Rows.Count - 1
                strSQL = "Update san_pham SET gianhap =" & dtbsp.Rows(i)("gianhap") & ", Dongia =" & dtbsp.Rows(i)("Dongia") & "  WHERE ID =" & dtbsp.Rows(i)("ID") & ""
                Command_Exc(strSQL, CNNQLPHONGKHAM)
            Next
            MsgBox("Đã cập nhật xong!")
        End If
    End Sub

    Private Sub frmTonkhodauky_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim obj As Object
            For Each obj In Me.GroupControl1.Controls
                If obj.Focused = True Then
                    If TypeOf (obj) Is DevExpress.XtraEditors.LookUpEdit Then
                        obj.EditValue = ""
                    End If
                End If
            Next
        End If
    End Sub

End Class