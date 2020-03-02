<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DMDoituong
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DMDoituong))
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel_Button = New System.Windows.Forms.Panel()
        Me.Grb.SuspendLayout()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Button.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb
        '
        Me.Grb.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Grb.Controls.Add(Me.txtId)
        Me.Grb.Controls.Add(Me.txtTen)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grb.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Grb.ForeColor = System.Drawing.Color.Red
        Me.Grb.Location = New System.Drawing.Point(0, 0)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(629, 65)
        Me.Grb.TabIndex = 1
        Me.Grb.TabStop = False
        Me.Grb.Text = "Đối tượng bệnh nhân"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(550, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(67, 23)
        Me.txtId.TabIndex = 3
        Me.txtId.Visible = False
        '
        'txtTen
        '
        Me.txtTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.Location = New System.Drawing.Point(121, 26)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(423, 23)
        Me.txtTen.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên đối tượng"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Appearance.Options.UseForeColor = True
        Me.btnThem.Location = New System.Drawing.Point(20, 12)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 25)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "&Nhập mới "
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(113, 12)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 11
        Me.btnCap_nhat.Text = "&Lưu"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Appearance.Options.UseForeColor = True
        Me.btnHuy.Location = New System.Drawing.Point(206, 12)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 25)
        Me.btnHuy.TabIndex = 13
        Me.btnHuy.Text = "&Bỏ qua "
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.Location = New System.Drawing.Point(299, 12)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 25)
        Me.btnSua.TabIndex = 15
        Me.btnSua.Text = "&Sửa "
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(392, 12)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "&Xoá "
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(542, 12)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 14
        Me.btnThoat.Text = "&Thoát "
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(0, 71)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(629, 300)
        Me.grv.TabIndex = 17
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.colten})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.HorzScrollStep = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã"
        Me.colma.FieldName = "id"
        Me.colma.Name = "colma"
        Me.colma.OptionsColumn.AllowEdit = False
        Me.colma.Width = 100
        '
        'colten
        '
        Me.colten.Caption = "Tên đối tượng"
        Me.colten.FieldName = "doituong"
        Me.colten.Name = "colten"
        Me.colten.OptionsColumn.AllowEdit = False
        Me.colten.OptionsColumn.AllowFocus = False
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 0
        Me.colten.Width = 537
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'Panel_Button
        '
        Me.Panel_Button.Controls.Add(Me.btnThem)
        Me.Panel_Button.Controls.Add(Me.btnSua)
        Me.Panel_Button.Controls.Add(Me.btnThoat)
        Me.Panel_Button.Controls.Add(Me.btnHuy)
        Me.Panel_Button.Controls.Add(Me.btnCap_nhat)
        Me.Panel_Button.Controls.Add(Me.btnXoa)
        Me.Panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Button.Location = New System.Drawing.Point(0, 377)
        Me.Panel_Button.Name = "Panel_Button"
        Me.Panel_Button.Size = New System.Drawing.Size(629, 47)
        Me.Panel_Button.TabIndex = 18
        '
        'frm_DMDoituong
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 424)
        Me.Controls.Add(Me.Panel_Button)
        Me.Controls.Add(Me.grv)
        Me.Controls.Add(Me.Grb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_DMDoituong"
        Me.Text = "DANH MỤC ĐỐI TƯỢNG BỆNH NHÂN"
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grb As System.Windows.Forms.GroupBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel_Button As Panel
End Class
