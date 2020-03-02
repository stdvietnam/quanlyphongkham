Public Class frmThongKeTruyCap
    Inherits frmBase 'System.Windows.Forms.Form
    Private dtbThongKeLogin As DataTable
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grb As System.Windows.Forms.GroupBox
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInThongKe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkOption As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ColUseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ColComputerName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Lsv As System.Windows.Forms.DataGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKeTruyCap))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Lsv = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.ColUseName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ColComputerName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.chkOption = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInThongKe = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Grb.SuspendLayout()
        CType(Me.Lsv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LỊCH SỬ ĐĂNG NHẬP"
        '
        'Grb
        '
        Me.Grb.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Grb.Controls.Add(Me.SimpleButton1)
        Me.Grb.Controls.Add(Me.Button8)
        Me.Grb.Controls.Add(Me.Button7)
        Me.Grb.Controls.Add(Me.Button6)
        Me.Grb.Controls.Add(Me.Button5)
        Me.Grb.Controls.Add(Me.Lsv)
        Me.Grb.Controls.Add(Me.Button4)
        Me.Grb.Controls.Add(Me.Button3)
        Me.Grb.Controls.Add(Me.Button2)
        Me.Grb.Controls.Add(Me.Button1)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Controls.Add(Me.DateEdit2)
        Me.Grb.Controls.Add(Me.chkOption)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Controls.Add(Me.DateEdit1)
        Me.Grb.Controls.Add(Me.btnXoa)
        Me.Grb.Controls.Add(Me.btnInThongKe)
        Me.Grb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb.Location = New System.Drawing.Point(2, 32)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(582, 404)
        Me.Grb.TabIndex = 0
        Me.Grb.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(482, 40)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 17
        Me.SimpleButton1.Text = "&Thoát"
        '
        'Button8
        '
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(255, 40)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(24, 24)
        Me.Button8.TabIndex = 16
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.SystemColors.Control
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(231, 40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 24)
        Me.Button7.TabIndex = 15
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.SystemColors.Control
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(255, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 14
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(231, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 24)
        Me.Button5.TabIndex = 13
        '
        'Lsv
        '
        Me.Lsv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Lsv.CaptionVisible = False
        Me.Lsv.DataMember = ""
        Me.Lsv.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Lsv.Location = New System.Drawing.Point(0, 70)
        Me.Lsv.Name = "Lsv"
        Me.Lsv.Size = New System.Drawing.Size(582, 334)
        Me.Lsv.TabIndex = 12
        Me.Lsv.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Lsv
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ColUseName, Me.ColComputerName, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'ColUseName
        '
        Me.ColUseName.Format = ""
        Me.ColUseName.FormatInfo = Nothing
        Me.ColUseName.HeaderText = "UserName"
        Me.ColUseName.MappingName = "UserName"
        Me.ColUseName.NullText = ""
        Me.ColUseName.Width = 120
        '
        'ColComputerName
        '
        Me.ColComputerName.Format = ""
        Me.ColComputerName.FormatInfo = Nothing
        Me.ColComputerName.HeaderText = "Tên máy"
        Me.ColComputerName.MappingName = "ComputerName"
        Me.ColComputerName.NullText = ""
        Me.ColComputerName.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "IP của máy"
        Me.DataGridTextBoxColumn3.MappingName = "ComputerIP"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Ngày giờ truy cập"
        Me.DataGridTextBoxColumn4.MappingName = "Ngaytruycap"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Ngày giờ thoát"
        Me.DataGridTextBoxColumn5.MappingName = "Ngaythoat"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "ID"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(207, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 24)
        Me.Button4.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(183, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(207, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(183, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Đến ngày"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2005, 4, 23, 0, 0, 0, 0)
        Me.DateEdit2.Location = New System.Drawing.Point(80, 41)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DateEdit2.Properties.Appearance.Options.UseFont = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.DateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit2.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.DateEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit2.Size = New System.Drawing.Size(97, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'chkOption
        '
        Me.chkOption.BackColor = System.Drawing.Color.Transparent
        Me.chkOption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkOption.Location = New System.Drawing.Point(288, 16)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(120, 20)
        Me.chkOption.TabIndex = 2
        Me.chkOption.Text = "Xoá theo ngày "
        Me.chkOption.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Từ ngày"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.DateEdit1.Location = New System.Drawing.Point(80, 17)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Size = New System.Drawing.Size(97, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(288, 40)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 25)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "&Xoá"
        '
        'btnInThongKe
        '
        Me.btnInThongKe.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnInThongKe.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInThongKe.Appearance.Options.UseFont = True
        Me.btnInThongKe.Appearance.Options.UseForeColor = True
        Me.btnInThongKe.Location = New System.Drawing.Point(385, 40)
        Me.btnInThongKe.Name = "btnInThongKe"
        Me.btnInThongKe.Size = New System.Drawing.Size(75, 25)
        Me.btnInThongKe.TabIndex = 4
        Me.btnInThongKe.Text = "&In "
        '
        'frmThongKeTruyCap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 437)
        Me.Controls.Add(Me.Grb)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThongKeTruyCap"
        Me.Text = "THỐNG KÊ TRUY CẬP "
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.Lsv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmThongKeTruyCap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.DateEdit1.DateTime = Today.Date.AddDays(-1)
        Dim dt As New Date
        Me.DateEdit2.DateTime = Today.Date
        dtbThongKeLogin = Load_DataTable("SELECT UserName,ComputerName,ComputerIP,Convert(char(20),Ngay,100)as NgayTruyCap,Convert(char(20),GioThoat,100)as NgayThoat,ID From Thong_Ke_Login Where Convert(char(20),Ngay,101) BETWEEN '" & Format(Today.Date, "MM/dd/yyyy") & "' AND '" & Format(Today.Date, "MM/dd/yyyy") & "'", CNNQLPHONGKHAM)
        Me.Lsv.DataSource = dtbThongKeLogin
        Me.ToolTip1.SetToolTip(Me.Button1, "Click vào đây để chọn ngày trước")
        Me.ToolTip1.SetToolTip(Me.Button2, "Click vào đây để chọn ngày sau")
        Me.ToolTip1.SetToolTip(Me.Button3, "Click vào đây để chọn ngày trước")
        Me.ToolTip1.SetToolTip(Me.Button4, "Click vào đây để chọn ngày sau")
        Me.ToolTip1.SetToolTip(Me.Button5, "Click vào đây để chọn ngày đầu tiên ")
        Me.ToolTip1.SetToolTip(Me.Button6, "Click vào đây để chọn ngày cuối cùng")
        Me.ToolTip1.SetToolTip(Me.Button7, "Click vào đây để chọn ngày đầu tiên")
        Me.ToolTip1.SetToolTip(Me.Button8, "Click vào đây để chọn ngày cuối cùng")

    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim i As Integer
        Dim strSQL As String
        If Me.chkOption.Checked = True Then
            strSQL = "DELETE Thong_Ke_Login Where Convert(char(20),Ngay,101) BETWEEN '" & Format(Me.DateEdit1.DateTime, "MM/dd/yyyy") & "' AND '" & Format(Me.DateEdit2.DateTime, "MM/dd/yyyy") & "'"
            Command_Exc(strSQL, CNNQLPHONGKHAM)
        Else
            If Not IsDBNull(Me.Lsv.Item(Me.Lsv.CurrentCell.RowNumber, 0)) And Not IsDBNull(Me.Lsv.Item(Me.Lsv.CurrentCell.RowNumber, 1)) Then
                strSQL = " DeLete from Thong_ke_login where id='" & Me.Lsv.Item(Me.Lsv.CurrentCell.RowNumber, 5) & "'"
                Command_Exc(strSQL, CNNQLPHONGKHAM)
            End If
        End If
        dtbThongKeLogin = Load_DataTable("SELECT UserName,ComputerName,ComputerIP,Convert(char(20),Ngay,100)as NgayTruyCap,Convert(char(20),GioThoat,100)as NgayThoat,ID From Thong_Ke_Login Where Convert(char(20),Ngay,101) BETWEEN '" & Format(Me.DateEdit1.DateTime, "MM/dd/yyyy") & "' AND '" & Format(Me.DateEdit2.DateTime, "MM/dd/yyyy") & "'", CNNQLPHONGKHAM)
        Me.Lsv.DataSource = dtbThongKeLogin
    End Sub
    Private Sub btnInThongKe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInThongKe.Click
        Dim frm As New frmShowReport
        Dim dtb As DataTable
        frm.strBC = frmShowReport.TenBc.ThongKeTruyCap
        dtb = Load_DataTable("Select * from Ten_menu_baocao", CNNQLPHONGKHAM)
        If dtb.Rows.Count > 0 Then
            frm.strMadv = dtb.Rows(0)("Tenct")
            frm.strMakh = dtb.Rows(0)("Diachi")
            frm.Paraval1 = dtb.Rows(0)("Tel")
            frm.Paraval2 = dtb.Rows(0)("Fax")
        End If
        frm.strBC = frmShowReport.TenBc.ThongKeTruyCap
        frm.dtb = dtbThongKeLogin
        frm.Show()
    End Sub
    Private Sub DateEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged
        dtbThongKeLogin = Load_DataTable("SELECT UserName,ComputerName,ComputerIP,Convert(char(20),Ngay,100)as NgayTruyCap,ID,Convert(char(20),GioThoat,100)as NgayThoat From Thong_Ke_Login Where Convert(char(20),Ngay,101) BETWEEN '" & Format(Me.DateEdit1.DateTime, "MM/dd/yyyy") & "' AND '" & Format(Me.DateEdit2.DateTime, "MM/dd/yyyy") & "'", CNNQLPHONGKHAM)
        Me.Lsv.DataSource = dtbThongKeLogin
    End Sub
    Private Sub DateEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit2.EditValueChanged
        dtbThongKeLogin = Load_DataTable("SELECT UserName,ComputerName,ComputerIP,Convert(char(20),Ngay,100)as NgayTruyCap,ID,Convert(char(20),GioThoat,100)as NgayThoat From Thong_Ke_Login Where Convert(char(20),Ngay,101) BETWEEN '" & Format(Me.DateEdit1.DateTime, "MM/dd/yyyy") & "' AND '" & Format(Me.DateEdit2.DateTime, "MM/dd/yyyy") & "'", CNNQLPHONGKHAM)
        Me.Lsv.DataSource = dtbThongKeLogin
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As Date
        dt = (Me.DateEdit1.DateTime).AddDays(-1)
        Me.DateEdit1.DateTime = dt
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dt As Date
        dt = (Me.DateEdit1.DateTime).AddDays(1)
        If dt > Me.DateEdit2.DateTime Then
            MsgBox("Ngày  trước không được lớn hơn ngày sau", MsgBoxStyle.Critical)
        Else
            Me.DateEdit1.DateTime = dt
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dt As Date
        dt = (Me.DateEdit2.DateTime).AddDays(-1)
        If dt < Me.DateEdit1.DateTime Then
            MsgBox("Ngày  sau không được nhỏ hơn ngày trước", MsgBoxStyle.Critical)
        Else
            Me.DateEdit2.DateTime = dt
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dt As Date
        dt = (Me.DateEdit2.DateTime).AddDays(1)
        Me.DateEdit2.DateTime = dt
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim str As String
        Dim tb As New DataTable
        str = "select min(giothoat) from Thong_Ke_Login "
        tb = Load_DataTable(str, CNNQLPHONGKHAM)
        If (IsDBNull(tb.Rows(0)(0))) Then
            MessageBox.Show("Không có bản ghi nào", "Acount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.DateEdit1.DateTime = tb.Rows(0)(0)
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim str As String
        Dim tb As New DataTable
        str = "select max(giothoat) from Thong_Ke_Login "
        tb = Load_DataTable(str, CNNQLPHONGKHAM)
        If (IsDBNull(tb.Rows(0)(0))) Then
            MessageBox.Show("Không có bản ghi nào", "Acount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tb.Rows(0)(0) > Me.DateEdit2.DateTime Then
            MsgBox("Ngày  trước không được lớn hơn ngày sau", MsgBoxStyle.Critical)
        Else
            Me.DateEdit1.DateTime = tb.Rows(0)(0)
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim str As String
        Dim tb As New DataTable
        str = "select min(giothoat) from Thong_Ke_Login "
        tb = Load_DataTable(str, CNNQLPHONGKHAM)
        If (IsDBNull(tb.Rows(0)(0))) Then
            MessageBox.Show("Không có bản ghi nào", "Acount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf tb.Rows(0)(0) < Me.DateEdit1.DateTime Then
            MsgBox("Ngày sau không được nhỏ hơn ngày trước", MsgBoxStyle.Critical)
        Else
            Me.DateEdit2.DateTime = tb.Rows(0)(0)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim str As String
        Dim tb As New DataTable
        str = "select max(giothoat) from Thong_Ke_Login "
        tb = Load_DataTable(str, CNNQLPHONGKHAM)
        If (IsDBNull(tb.Rows(0)(0))) Then
            MessageBox.Show("Không có bản ghi nào", "Acount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.DateEdit2.DateTime = tb.Rows(0)(0)
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class
