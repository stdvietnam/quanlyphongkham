Imports Connection_db
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frmLogin
    Inherits frmBase 'System.Windows.Forms.Form
    Private j As Int16
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Chk_pas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNewpass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtReNewPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Grb2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Public Old_Usename As String
    'Private obj As New localhost.Service1

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
    Friend WithEvents tbnhap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.Txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chk_pas = New DevExpress.XtraEditors.CheckEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbnhap = New DevExpress.XtraEditors.SimpleButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNewpass = New DevExpress.XtraEditors.TextEdit()
        Me.TxtReNewPass = New DevExpress.XtraEditors.TextEdit()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.chk = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.Txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chk_pas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNewpass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtReNewPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb2.SuspendLayout()
        CType(Me.chk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtusername
        '
        Me.Txtusername.EditValue = "admin"
        Me.Txtusername.Location = New System.Drawing.Point(147, 19)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txtusername.Properties.Appearance.Options.UseFont = True
        Me.Txtusername.Properties.AutoHeight = False
        Me.Txtusername.Size = New System.Drawing.Size(150, 23)
        Me.Txtusername.TabIndex = 1
        '
        'Txtpassword
        '
        Me.Txtpassword.EditValue = "123"
        Me.Txtpassword.Location = New System.Drawing.Point(147, 45)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txtpassword.Properties.Appearance.Options.UseFont = True
        Me.Txtpassword.Properties.AutoHeight = False
        Me.Txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(150, 23)
        Me.Txtpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(76, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên dùng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(76, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mật khẩu"
        '
        'Chk_pas
        '
        Me.Chk_pas.Location = New System.Drawing.Point(147, 74)
        Me.Chk_pas.Name = "Chk_pas"
        Me.Chk_pas.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Chk_pas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_pas.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chk_pas.Properties.Appearance.Options.UseBackColor = True
        Me.Chk_pas.Properties.Appearance.Options.UseFont = True
        Me.Chk_pas.Properties.Appearance.Options.UseForeColor = True
        Me.Chk_pas.Properties.AutoWidth = True
        Me.Chk_pas.Properties.Caption = "Ghi nhớ tài khoản"
        Me.Chk_pas.Size = New System.Drawing.Size(121, 20)
        Me.Chk_pas.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MEDICAL.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'tbnhap
        '
        Me.tbnhap.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbnhap.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbnhap.Appearance.Options.UseFont = True
        Me.tbnhap.Appearance.Options.UseForeColor = True
        Me.tbnhap.Location = New System.Drawing.Point(79, 120)
        Me.tbnhap.LookAndFeel.SkinName = "Caramel"
        Me.tbnhap.Name = "tbnhap"
        Me.tbnhap.Size = New System.Drawing.Size(75, 25)
        Me.tbnhap.TabIndex = 7
        Me.tbnhap.Text = "&Đăng nhập"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(10, 74)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 16)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cấu hình"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnThoat.Location = New System.Drawing.Point(175, 120)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 25)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "&Thoát"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Re-Type password"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "New password :"
        '
        'TxtNewpass
        '
        Me.TxtNewpass.EditValue = ""
        Me.TxtNewpass.Location = New System.Drawing.Point(136, 16)
        Me.TxtNewpass.Name = "TxtNewpass"
        Me.TxtNewpass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewpass.Size = New System.Drawing.Size(136, 20)
        Me.TxtNewpass.TabIndex = 1
        '
        'TxtReNewPass
        '
        Me.TxtReNewPass.EditValue = ""
        Me.TxtReNewPass.Location = New System.Drawing.Point(136, 40)
        Me.TxtReNewPass.Name = "TxtReNewPass"
        Me.TxtReNewPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtReNewPass.Size = New System.Drawing.Size(136, 20)
        Me.TxtReNewPass.TabIndex = 3
        '
        'Grb2
        '
        Me.Grb2.Controls.Add(Me.TxtReNewPass)
        Me.Grb2.Controls.Add(Me.TxtNewpass)
        Me.Grb2.Controls.Add(Me.Label4)
        Me.Grb2.Controls.Add(Me.Label5)
        Me.Grb2.Location = New System.Drawing.Point(12, 199)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(280, 72)
        Me.Grb2.TabIndex = 6
        Me.Grb2.TabStop = False
        '
        'chk
        '
        Me.chk.Location = New System.Drawing.Point(146, 181)
        Me.chk.Name = "chk"
        Me.chk.Properties.Caption = ""
        Me.chk.Size = New System.Drawing.Size(40, 19)
        Me.chk.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Txtusername)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txtpassword)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.tbnhap)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.Chk_pas)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 169)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.tbnhap
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk)
        Me.Controls.Add(Me.Grb2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.Text = "ĐĂNG NHẬP"
        Me.TopMost = True
        CType(Me.Txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chk_pas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNewpass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtReNewPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb2.ResumeLayout(False)
        CType(Me.chk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grb2.Enabled = False
        ReadUserINI()
    End Sub
    Private Sub frmlogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim clsMahoa As New Encryption64
        If e.KeyCode = Keys.Enter Then
            If j < 3 Then
                Dim strUserName As String
                Dim strPassword As String
                strUserName = Me.Txtusername.Text
                strPassword = Me.Txtpassword.Text
                strUserName = Killchars(strUserName)
                strPassword = Killchars(strPassword)
                string_Replace(strUserName)
                string_Replace(strPassword)
                strPassword = clsMahoa.EncryptToBase64String(strPassword, "1234567a")
                Check_Validation(strUserName, strPassword)
            Else
                Me.Close()
            End If
        End If
    End Sub
    Function Killchars(ByVal Strinput)
        Dim i As Int16
        Dim badchars(6) As String
        Dim newchars As String
        badchars(0) = "select"
        badchars(1) = "drop"
        badchars(2) = ";"
        badchars(3) = "--"
        badchars(4) = "insert"
        badchars(5) = "Xp_"
        badchars(6) = "="
        newchars = Strinput
        For i = 0 To 6
            newchars = Replace(newchars, badchars(i), "")
        Next
        Killchars = newchars
    End Function
    Private Sub Check_Validation(ByVal strUserName As String, ByVal strPassword As String)
        If strUserName <> "" And strPassword <> "" Then
            Dim cls As New clsKet_noi
            Dim clsLoginObj1 As New ClsLogin
            If CNNQLPHONGKHAM.State = ConnectionState.Closed Then
                cls.Khoi_taoKn(CNNQLPHONGKHAM)
            End If
            Dim strSQL As String
            Dim strName As String
            Dim iphost As System.Net.IPHostEntry
            Dim strIP As String
            Dim i As Integer
            Dim dtbLogin As New DataTable
            Dim clsMahoa As New Encryption64
            Dim strNewpass As String
            strNewpass = clsMahoa.EncryptToBase64String(Me.TxtNewpass.Text, "1234567a")
            strSQL = String.Format("SELECT n.ID,n.Username,n.Hoten,n.Password,n.Manhom,d.Quyen,n.Manhom FROM Nguoi_su_dung n INNER JOIN Nhom_NSD d ON n.Manhom = d.Ma_nhom WHERE n.Username =N'{0}' AND n.Password =N'{1}'", strUserName, strPassword)
            Dim dts As New DataSet
            dtbLogin = Load_DataTable(strSQL, CNNQLPHONGKHAM)
            If dtbLogin.Rows.Count > 0 Then
                If kiemtra = 0 Then
                    hople = True
                    Me.Close()
                Else
                    clsLoginObj.Update(Me.Txtusername.Text, strNewpass, dtbLogin.Rows(0)("ID"), 3)
                    hople = True
                    Me.Close()
                    MsgBox("Password đã được thay đổi")
                End If
                clsLoginObj.strGroup = dtbLogin.Rows(0)("Manhom")
                clsLoginObj.strUsername = dtbLogin.Rows(0)("Username")
                clsLoginObj.strQuyen = dtbLogin.Rows(0)("Quyen")
                clsLoginObj.strHoten = dtbLogin.Rows(0)("Hoten")
                strName = System.Net.Dns.GetHostName
                iphost = System.Net.Dns.GetHostByName(strName)
                Dim Iplist() As System.Net.IPAddress
                Iplist = iphost.AddressList
                For i = 0 To Iplist.GetUpperBound(0)
                    strIP = Iplist(i).ToString
                Next
                If Old_Usename Is Nothing Then
                Else
                    clsLoginObj.UpdateGioThoat(Old_Usename, IDGioThoat, 2)
                End If
                'obj.ThemLog(clsLoginObj.strUsername, strName, strIP, 1, Today.Date, IDGioThoat)
            Else
                j = j + 1
                MsgBox("User name hoặc Pass word không đúng!")
            End If
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Grb2.Visible = False
    End Sub
    Private Sub WriteUserINI()
        Dim clsMahoa As New Encryption64
        Dim sw As StreamWriter
        Try
            sw = File.CreateText("User.INI")
        Catch
            MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try
        Try
            sw.WriteLine("user=" + Txtusername.Text.Trim())
            sw.WriteLine("password=" + clsMahoa.EncryptToBase64String(Txtpassword.Text.Trim(), "1234567a"))
        Catch
            MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        sw.Close()
    End Sub
    Private Sub ReadUserINI()
        Dim clsMahoa As New Encryption64
        Dim sr As StreamReader
        Dim line As String, param As String
        Dim user As String = ""
        Dim pass As String = ""
        If File.Exists("User.INI") Then
            sr = File.OpenText("User.INI")
            While sr.Peek() > -1
                line = sr.ReadLine()
                Dim index As Integer = line.IndexOf("=")
                If index > -1 Then
                    param = line.Substring(0, index).Trim().ToLower()
                    Select Case param
                        Case "user"
                            user = line.Substring(index + 1).Trim()
                            Exit Select
                        Case "password"
                            pass = line.Substring(index + 1).Trim()
                            Exit Select
                    End Select
                End If
            End While
            sr.Close()
            If user.Length > 0 Then
                Txtusername.Text = user
                If pass.Length > 0 Then
                    Txtpassword.Text = clsMahoa.DecryptFromBase64String(pass, "1234567a")
                    Chk_pas.Checked = True
                    tbnhap.Focus()
                Else
                    Txtpassword.Focus()
                End If
            Else
                Txtusername.Focus()
            End If
        Else
            Txtusername.Focus()
        End If
    End Sub

    Private Sub tbnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnhap.Click
        If j < 3 Then
            Dim clsMahoa As New Encryption64
            Dim strUserName As String
            Dim strPassword As String
            strUserName = Me.Txtusername.Text
            strPassword = Me.Txtpassword.Text
            If Me.TxtNewpass.Text <> "" Then
                If Me.TxtNewpass.Text <> Me.TxtReNewPass.Text Then
                    MsgBox("Bạn nhập mật khẩu mới không đúng, cần nhập lại!")
                Else
                    If strUserName = "" Then
                        MsgBox("Bạn chưa đăng nhập tên !")
                    Else
                        If strPassword = "" Then
                            MsgBox("Bạn chưa nhập mật khẩu cũ !")
                        Else
                            kiemtra = 1
                            strUserName = Killchars(strUserName)
                            strPassword = Killchars(strPassword)
                            string_Replace(strUserName)
                            string_Replace(strPassword)
                            strPassword = clsMahoa.EncryptToBase64String(strPassword, "1234567a")
                            Check_Validation(strUserName, strPassword)

                        End If
                    End If
                End If
            Else
                'kiemtra = 2
                strUserName = Killchars(strUserName)
                strPassword = Killchars(strPassword)
                string_Replace(strUserName)
                string_Replace(strPassword)
                strPassword = clsMahoa.EncryptToBase64String(strPassword, "1234567a")
                Check_Validation(strUserName, strPassword)
                If Chk_pas.Checked Then
                    WriteUserINI()
                Else
                    Dim strPath As String = Application.StartupPath + "\User.INI"
                    Try
                        File.Delete(Application.StartupPath + "\User.INI")
                    Catch
                    End Try
                End If
                Txtpassword.Text = ""
                Me.Hide()
            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        kiemtra = 3
        Application.Exit()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_pas.CheckedChanged, chk.CheckedChanged
        If Me.chk.Checked = True Then
            Me.Grb2.Enabled = True
        Else
            Me.Grb2.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim login_db As New Connection_db.Login_Database
        login_db.StartPosition = FormStartPosition.CenterScreen
        Me.AddOwnedForm(login_db)
        login_db.ShowDialog()
    End Sub
End Class
