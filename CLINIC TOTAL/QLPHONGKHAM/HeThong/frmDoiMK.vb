Public Class frmDoiMK
    Inherits frmBase 'System.Windows.Forms.Form
    Private flag As Boolean
    Private ID As Int16
    Public IDmoi As String
    Private dtb As DataTable
    Public Key As Boolean
    Private isload As Boolean = False
    Dim strgiaima As String = ""
    Private hoten As String = ""
    Friend WithEvents txtmkhientai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmkmoilai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmkmoi As DevExpress.XtraEditors.TextEdit
    Private Mypass As String = ""
    Public isClose As Boolean = False
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents Grb As System.Windows.Forms.GroupBox
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoiMK))
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.txtmkmoilai = New DevExpress.XtraEditors.TextEdit()
        Me.txtmkmoi = New DevExpress.XtraEditors.TextEdit()
        Me.txtmkhientai = New DevExpress.XtraEditors.TextEdit()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Grb.SuspendLayout()
        CType(Me.txtmkmoilai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmkmoi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmkhientai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb
        '
        Me.Grb.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Grb.Controls.Add(Me.txtmkmoilai)
        Me.Grb.Controls.Add(Me.txtmkmoi)
        Me.Grb.Controls.Add(Me.txtmkhientai)
        Me.Grb.Controls.Add(Me.btnCap_nhat)
        Me.Grb.Controls.Add(Me.btnThoat)
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Controls.Add(Me.Label3)
        Me.Grb.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb.Location = New System.Drawing.Point(3, -4)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(312, 156)
        Me.Grb.TabIndex = 0
        Me.Grb.TabStop = False
        '
        'txtmkmoilai
        '
        Me.txtmkmoilai.Location = New System.Drawing.Point(125, 73)
        Me.txtmkmoilai.Name = "txtmkmoilai"
        Me.txtmkmoilai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtmkmoilai.Properties.Appearance.Options.UseFont = True
        Me.txtmkmoilai.Properties.AutoHeight = False
        Me.txtmkmoilai.Size = New System.Drawing.Size(176, 23)
        Me.txtmkmoilai.TabIndex = 16
        '
        'txtmkmoi
        '
        Me.txtmkmoi.Location = New System.Drawing.Point(125, 45)
        Me.txtmkmoi.Name = "txtmkmoi"
        Me.txtmkmoi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtmkmoi.Properties.Appearance.Options.UseFont = True
        Me.txtmkmoi.Properties.AutoHeight = False
        Me.txtmkmoi.Size = New System.Drawing.Size(176, 23)
        Me.txtmkmoi.TabIndex = 16
        '
        'txtmkhientai
        '
        Me.txtmkhientai.Location = New System.Drawing.Point(125, 17)
        Me.txtmkhientai.Name = "txtmkhientai"
        Me.txtmkhientai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtmkhientai.Properties.Appearance.Options.UseFont = True
        Me.txtmkhientai.Properties.AutoHeight = False
        Me.txtmkhientai.Size = New System.Drawing.Size(176, 23)
        Me.txtmkhientai.TabIndex = 16
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(62, 112)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 7
        Me.btnCap_nhat.Text = "&Cập nhật "
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.Location = New System.Drawing.Point(166, 112)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "&Thoát "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mật khẩu củ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật khẩu mới"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nhập lại MK mới"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'frmDoiMK
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(318, 155)
        Me.Controls.Add(Me.Grb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmDoiMK"
        Me.Text = "ĐỔI MẬT KHẨU"
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        CType(Me.txtmkmoilai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmkmoi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmkhientai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmNguoi_SD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()

    End Sub
    Private Sub loaddata()
        Dim clsgiaima As New Encryption64
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset("select Password from nguoi_su_dung where Username = N'" & clsLoginObj.strUsername & "' ").Tables(0)
        If dtb.Rows.Count > 0 Then
            Mypass = clsgiaima.DecryptFromBase64String(dtb.Rows(0)(0).ToString, "1234567a")
        End If
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtmkmoi.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtmkmoi, "Nhập mật khẩu mới")
            ErrPro.SetIconAlignment(Me.txtmkmoi, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtmkmoi.Text.Length < 3 Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtmkmoi, "Mật khẩu quá ngắn")
            ErrPro.SetIconAlignment(Me.txtmkmoi, ErrorIconAlignment.MiddleRight)
        End If
        If Me.txtmkhientai.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtmkhientai, "Nhập mật khẩu hiện tại!")
            ErrPro.SetIconAlignment(Me.txtmkhientai, ErrorIconAlignment.MiddleRight)
        Else
            If txtmkhientai.Text.Trim <> Mypass.ToString() Then
                Kiem_Tra = False
                ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.ErrPro.SetError(Me.txtmkhientai, "Mật khẩu không đúng!")
                ErrPro.SetIconAlignment(Me.txtmkhientai, ErrorIconAlignment.MiddleRight)
            End If
        End If

        If txtmkmoilai.Text.Trim <> txtmkmoi.Text.Trim Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtmkmoilai, "Xác nhận mật khẩu không đúng!")
            ErrPro.SetIconAlignment(Me.txtmkmoilai, ErrorIconAlignment.MiddleRight)
        End If

    End Function

    Private Sub btnCap_Nhat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        Dim clsma As New Encryption64
        Dim strSQL As String = ""
        strSQL = "Update nguoi_su_dung set password='" & clsma.EncryptToBase64String(txtmkmoi.Text.Trim.ToString(), "1234567a") & "' where Username='" & clsLoginObj.strUsername & "'"
        If Kiem_Tra() = True Then
            If Command_Exc(strSQL, CNNQLPHONGKHAM) = 0 Then
                MsgBox("Cập nhật thành công")
            End If
        End If

    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmDoiMK_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isClose = True
    End Sub
End Class