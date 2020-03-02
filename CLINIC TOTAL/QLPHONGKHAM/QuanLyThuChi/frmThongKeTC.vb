Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Views.Base

Public Class frmThongKeTC
    Inherits frmBase 'System.Windows.Forms.Form
    Private dtbTkTC As New DataTable
    Private Foundchek As Boolean = True
    Private ThuUSD As Double
    Private ChiUSD As Double
    Private ThuVND As Double
    Private ChiVND As Double
    Private k As Int16
    Private foundClick As Boolean = True
    Private Style As Boolean = False
    Friend WithEvents colCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Private dts As New DataSet
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
    Friend WithEvents grbTotal As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTongSp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbltong_so As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents grbDieu_kien As System.Windows.Forms.GroupBox
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSo_phieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDon_vi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtThuVND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTonVND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChiUsd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtThuUSD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTonUSD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents colSophieu As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmbQuyTC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChiVND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GrdDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Radio1 As System.Windows.Forms.RadioButton
    Friend WithEvents Radio2 As System.Windows.Forms.RadioButton
    Friend WithEvents Radio3 As System.Windows.Forms.RadioButton
    Friend WithEvents Radio4 As System.Windows.Forms.RadioButton
    Friend WithEvents Radio5 As System.Windows.Forms.RadioButton
    Friend WithEvents Radio6 As System.Windows.Forms.RadioButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbNvLP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupHuy As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton0 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKeTC))
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbTotal = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTonUSD = New DevExpress.XtraEditors.TextEdit()
        Me.txtChiUsd = New DevExpress.XtraEditors.TextEdit()
        Me.txtThuUSD = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTongSp = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtChiVND = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtThuVND = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltong_so = New System.Windows.Forms.Label()
        Me.TxtTonVND = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.grbDieu_kien = New System.Windows.Forms.GroupBox()
        Me.cmbNvLP = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbKhoan = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSo_phieu = New DevExpress.XtraEditors.TextEdit()
        Me.cmbQuyTC = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDon_vi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Radio6 = New System.Windows.Forms.RadioButton()
        Me.Radio5 = New System.Windows.Forms.RadioButton()
        Me.Radio4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Radio3 = New System.Windows.Forms.RadioButton()
        Me.Radio2 = New System.Windows.Forms.RadioButton()
        Me.Radio1 = New System.Windows.Forms.RadioButton()
        Me.GroupHuy = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton0 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.colSophieu = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GrdDetail = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTotal.SuspendLayout()
        CType(Me.txtTonUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChiUsd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThuUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongSp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChiVND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThuVND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTonVND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDieu_kien.SuspendLayout()
        CType(Me.cmbNvLP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKhoan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_phieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbQuyTC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDon_vi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupHuy.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'grbTotal
        '
        Me.grbTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grbTotal.Controls.Add(Me.Label12)
        Me.grbTotal.Controls.Add(Me.Label7)
        Me.grbTotal.Controls.Add(Me.txtTonUSD)
        Me.grbTotal.Controls.Add(Me.txtChiUsd)
        Me.grbTotal.Controls.Add(Me.txtThuUSD)
        Me.grbTotal.Controls.Add(Me.GroupBox1)
        Me.grbTotal.Controls.Add(Me.txtTongSp)
        Me.grbTotal.Controls.Add(Me.Label10)
        Me.grbTotal.Controls.Add(Me.txtChiVND)
        Me.grbTotal.Controls.Add(Me.Label9)
        Me.grbTotal.Controls.Add(Me.txtThuVND)
        Me.grbTotal.Controls.Add(Me.Label8)
        Me.grbTotal.Controls.Add(Me.lbltong_so)
        Me.grbTotal.Controls.Add(Me.TxtTonVND)
        Me.grbTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTotal.ForeColor = System.Drawing.Color.Red
        Me.grbTotal.Location = New System.Drawing.Point(595, 1)
        Me.grbTotal.Name = "grbTotal"
        Me.grbTotal.Size = New System.Drawing.Size(372, 160)
        Me.grbTotal.TabIndex = 1
        Me.grbTotal.TabStop = False
        Me.grbTotal.Text = "Thông tin tổng hợp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(261, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 14)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "USD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(91, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 14)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "VNĐ"
        '
        'txtTonUSD
        '
        Me.txtTonUSD.EditValue = ""
        Me.txtTonUSD.Location = New System.Drawing.Point(200, 126)
        Me.txtTonUSD.Name = "txtTonUSD"
        Me.txtTonUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTonUSD.Size = New System.Drawing.Size(144, 20)
        Me.txtTonUSD.TabIndex = 13
        '
        'txtChiUsd
        '
        Me.txtChiUsd.EditValue = ""
        Me.txtChiUsd.Location = New System.Drawing.Point(200, 93)
        Me.txtChiUsd.Name = "txtChiUsd"
        Me.txtChiUsd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtChiUsd.Size = New System.Drawing.Size(144, 20)
        Me.txtChiUsd.TabIndex = 9
        '
        'txtThuUSD
        '
        Me.txtThuUSD.EditValue = ""
        Me.txtThuUSD.Location = New System.Drawing.Point(200, 70)
        Me.txtThuUSD.Name = "txtThuUSD"
        Me.txtThuUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtThuUSD.Size = New System.Drawing.Size(144, 20)
        Me.txtThuUSD.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 8)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txtTongSp
        '
        Me.txtTongSp.EditValue = ""
        Me.txtTongSp.Location = New System.Drawing.Point(264, 22)
        Me.txtTongSp.Name = "txtTongSp"
        Me.txtTongSp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTongSp.Size = New System.Drawing.Size(80, 20)
        Me.txtTongSp.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(152, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tổng số phiếu:"
        '
        'txtChiVND
        '
        Me.txtChiVND.EditValue = ""
        Me.txtChiVND.Location = New System.Drawing.Point(48, 93)
        Me.txtChiVND.Name = "txtChiVND"
        Me.txtChiVND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtChiVND.Size = New System.Drawing.Size(136, 20)
        Me.txtChiVND.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Thu"
        '
        'txtThuVND
        '
        Me.txtThuVND.EditValue = ""
        Me.txtThuVND.Location = New System.Drawing.Point(48, 70)
        Me.txtThuVND.Name = "txtThuVND"
        Me.txtThuVND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtThuVND.Size = New System.Drawing.Size(136, 20)
        Me.txtThuVND.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Chi"
        '
        'lbltong_so
        '
        Me.lbltong_so.AutoSize = True
        Me.lbltong_so.BackColor = System.Drawing.Color.Transparent
        Me.lbltong_so.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltong_so.ForeColor = System.Drawing.Color.Black
        Me.lbltong_so.Location = New System.Drawing.Point(7, 129)
        Me.lbltong_so.Name = "lbltong_so"
        Me.lbltong_so.Size = New System.Drawing.Size(38, 14)
        Me.lbltong_so.TabIndex = 11
        Me.lbltong_so.Text = "Tổng"
        '
        'TxtTonVND
        '
        Me.TxtTonVND.EditValue = ""
        Me.TxtTonVND.Location = New System.Drawing.Point(48, 126)
        Me.TxtTonVND.Name = "TxtTonVND"
        Me.TxtTonVND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTonVND.Size = New System.Drawing.Size(136, 20)
        Me.TxtTonVND.TabIndex = 12
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(786, 171)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "&Excel"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(699, 171)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 12
        Me.btnIn.Text = "&In TK"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(873, 171)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "&Thoát"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(612, 171)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 11
        Me.btnXem.Text = "&Xem"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'grbDieu_kien
        '
        Me.grbDieu_kien.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grbDieu_kien.Controls.Add(Me.cmbNvLP)
        Me.grbDieu_kien.Controls.Add(Me.Label13)
        Me.grbDieu_kien.Controls.Add(Me.cmbKhoan)
        Me.grbDieu_kien.Controls.Add(Me.Label6)
        Me.grbDieu_kien.Controls.Add(Me.txtSo_phieu)
        Me.grbDieu_kien.Controls.Add(Me.cmbQuyTC)
        Me.grbDieu_kien.Controls.Add(Me.Label4)
        Me.grbDieu_kien.Controls.Add(Me.Label3)
        Me.grbDieu_kien.Controls.Add(Me.dtpTu_ngay)
        Me.grbDieu_kien.Controls.Add(Me.dtpDen_ngay)
        Me.grbDieu_kien.Controls.Add(Me.Label2)
        Me.grbDieu_kien.Controls.Add(Me.cmbDon_vi)
        Me.grbDieu_kien.Controls.Add(Me.Label5)
        Me.grbDieu_kien.Controls.Add(Me.Label1)
        Me.grbDieu_kien.Controls.Add(Me.GroupBox3)
        Me.grbDieu_kien.Controls.Add(Me.GroupBox2)
        Me.grbDieu_kien.Controls.Add(Me.GroupHuy)
        Me.grbDieu_kien.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDieu_kien.ForeColor = System.Drawing.Color.Red
        Me.grbDieu_kien.Location = New System.Drawing.Point(0, 1)
        Me.grbDieu_kien.Name = "grbDieu_kien"
        Me.grbDieu_kien.Size = New System.Drawing.Size(589, 160)
        Me.grbDieu_kien.TabIndex = 0
        Me.grbDieu_kien.TabStop = False
        Me.grbDieu_kien.Text = "Điều kiện thống kê"
        '
        'cmbNvLP
        '
        Me.cmbNvLP.Location = New System.Drawing.Point(94, 74)
        Me.cmbNvLP.Name = "cmbNvLP"
        Me.cmbNvLP.Properties.AutoHeight = False
        Me.cmbNvLP.Properties.AutoSearchColumnIndex = 1
        Me.cmbNvLP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNvLP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Mã ngưởi dùng"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Tên người dùng")})
        Me.cmbNvLP.Properties.NullText = ""
        Me.cmbNvLP.Properties.PopupWidth = 250
        Me.cmbNvLP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbNvLP.Size = New System.Drawing.Size(196, 22)
        Me.cmbNvLP.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(17, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Lập phiếu"
        '
        'cmbKhoan
        '
        Me.cmbKhoan.Location = New System.Drawing.Point(94, 50)
        Me.cmbKhoan.Name = "cmbKhoan"
        Me.cmbKhoan.Properties.AutoHeight = False
        Me.cmbKhoan.Properties.AutoSearchColumnIndex = 1
        Me.cmbKhoan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKhoan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTC", "Mã Loại T/C", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiTC", "Tên loại T/C", 180, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbKhoan.Properties.NullText = ""
        Me.cmbKhoan.Properties.PopupWidth = 200
        Me.cmbKhoan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbKhoan.Size = New System.Drawing.Size(196, 22)
        Me.cmbKhoan.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Khoản T/C"
        '
        'txtSo_phieu
        '
        Me.txtSo_phieu.EditValue = ""
        Me.txtSo_phieu.Location = New System.Drawing.Point(94, 26)
        Me.txtSo_phieu.Name = "txtSo_phieu"
        Me.txtSo_phieu.Properties.AutoHeight = False
        Me.txtSo_phieu.Size = New System.Drawing.Size(88, 22)
        Me.txtSo_phieu.TabIndex = 4
        '
        'cmbQuyTC
        '
        Me.cmbQuyTC.Location = New System.Drawing.Point(94, 98)
        Me.cmbQuyTC.Name = "cmbQuyTC"
        Me.cmbQuyTC.Properties.AutoHeight = False
        Me.cmbQuyTC.Properties.AutoSearchColumnIndex = 1
        Me.cmbQuyTC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuyTC.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaQuy", "Mã quỹ", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenQuy", "Tên quỹ", 180, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbQuyTC.Properties.NullText = ""
        Me.cmbQuyTC.Properties.PopupWidth = 300
        Me.cmbQuyTC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbQuyTC.Size = New System.Drawing.Size(196, 22)
        Me.cmbQuyTC.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(416, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Đến ngày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(230, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Từ ngày"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(296, 20)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.Properties.AllowFocused = False
        Me.dtpTu_ngay.Properties.AutoHeight = False
        Me.dtpTu_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpTu_ngay.Size = New System.Drawing.Size(96, 22)
        Me.dtpTu_ngay.TabIndex = 1
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(485, 20)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.Properties.AutoHeight = False
        Me.dtpDen_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDen_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpDen_ngay.Size = New System.Drawing.Size(98, 22)
        Me.dtpDen_ngay.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Đơn vị"
        '
        'cmbDon_vi
        '
        Me.cmbDon_vi.Location = New System.Drawing.Point(94, 122)
        Me.cmbDon_vi.Name = "cmbDon_vi"
        Me.cmbDon_vi.Properties.AutoHeight = False
        Me.cmbDon_vi.Properties.AutoSearchColumnIndex = 1
        Me.cmbDon_vi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDon_vi.Properties.NullText = ""
        Me.cmbDon_vi.Properties.PopupWidth = 350
        Me.cmbDon_vi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbDon_vi.Size = New System.Drawing.Size(196, 22)
        Me.cmbDon_vi.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Quỹ thu chi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Số phiếu"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Radio6)
        Me.GroupBox3.Controls.Add(Me.Radio5)
        Me.GroupBox3.Controls.Add(Me.Radio4)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(296, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 40)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Radio6
        '
        Me.Radio6.BackColor = System.Drawing.Color.Transparent
        Me.Radio6.Location = New System.Drawing.Point(210, 14)
        Me.Radio6.Name = "Radio6"
        Me.Radio6.Size = New System.Drawing.Size(45, 22)
        Me.Radio6.TabIndex = 17
        Me.Radio6.Text = "All"
        Me.Radio6.UseVisualStyleBackColor = False
        '
        'Radio5
        '
        Me.Radio5.BackColor = System.Drawing.Color.Transparent
        Me.Radio5.Checked = True
        Me.Radio5.Location = New System.Drawing.Point(103, 14)
        Me.Radio5.Name = "Radio5"
        Me.Radio5.Size = New System.Drawing.Size(86, 22)
        Me.Radio5.TabIndex = 16
        Me.Radio5.TabStop = True
        Me.Radio5.Text = "TM"
        Me.Radio5.UseVisualStyleBackColor = False
        '
        'Radio4
        '
        Me.Radio4.BackColor = System.Drawing.Color.Transparent
        Me.Radio4.Location = New System.Drawing.Point(8, 14)
        Me.Radio4.Name = "Radio4"
        Me.Radio4.Size = New System.Drawing.Size(71, 22)
        Me.Radio4.TabIndex = 15
        Me.Radio4.Text = "NH"
        Me.Radio4.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Radio3)
        Me.GroupBox2.Controls.Add(Me.Radio2)
        Me.GroupBox2.Controls.Add(Me.Radio1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(296, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 40)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Radio3
        '
        Me.Radio3.BackColor = System.Drawing.Color.Transparent
        Me.Radio3.Location = New System.Drawing.Point(210, 12)
        Me.Radio3.Name = "Radio3"
        Me.Radio3.Size = New System.Drawing.Size(45, 22)
        Me.Radio3.TabIndex = 14
        Me.Radio3.Text = "All"
        Me.Radio3.UseVisualStyleBackColor = False
        '
        'Radio2
        '
        Me.Radio2.BackColor = System.Drawing.Color.Transparent
        Me.Radio2.Location = New System.Drawing.Point(103, 13)
        Me.Radio2.Name = "Radio2"
        Me.Radio2.Size = New System.Drawing.Size(86, 22)
        Me.Radio2.TabIndex = 13
        Me.Radio2.Text = "Chi"
        Me.Radio2.UseVisualStyleBackColor = False
        '
        'Radio1
        '
        Me.Radio1.BackColor = System.Drawing.Color.Transparent
        Me.Radio1.Checked = True
        Me.Radio1.Location = New System.Drawing.Point(8, 13)
        Me.Radio1.Name = "Radio1"
        Me.Radio1.Size = New System.Drawing.Size(71, 22)
        Me.Radio1.TabIndex = 12
        Me.Radio1.TabStop = True
        Me.Radio1.Text = "Thu"
        Me.Radio1.UseVisualStyleBackColor = False
        '
        'GroupHuy
        '
        Me.GroupHuy.Controls.Add(Me.RadioButton1)
        Me.GroupHuy.Controls.Add(Me.RadioButton0)
        Me.GroupHuy.Controls.Add(Me.RadioButton2)
        Me.GroupHuy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupHuy.ForeColor = System.Drawing.Color.Black
        Me.GroupHuy.Location = New System.Drawing.Point(296, 118)
        Me.GroupHuy.Name = "GroupHuy"
        Me.GroupHuy.Size = New System.Drawing.Size(287, 40)
        Me.GroupHuy.TabIndex = 23
        Me.GroupHuy.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(103, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 24)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Không huỷ"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton0
        '
        Me.RadioButton0.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton0.Location = New System.Drawing.Point(8, 13)
        Me.RadioButton0.Name = "RadioButton0"
        Me.RadioButton0.Size = New System.Drawing.Size(71, 24)
        Me.RadioButton0.TabIndex = 18
        Me.RadioButton0.Text = "Huỷ"
        Me.RadioButton0.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(210, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(45, 22)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.Text = "All"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'colSophieu
        '
        Me.colSophieu.Format = ""
        Me.colSophieu.FormatInfo = Nothing
        Me.colSophieu.HeaderText = "S? H�"
        Me.colSophieu.MappingName = "Sophieu"
        Me.colSophieu.NullText = ""
        Me.colSophieu.Width = 50
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Ng�y "
        Me.DataGridTextBoxColumn1.MappingName = "Ngay"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "�on v?"
        Me.DataGridTextBoxColumn2.MappingName = "Tendv"
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "M� XN"
        Me.DataGridTextBoxColumn3.MappingName = "MaXN"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 40
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nh�n vi�n b�n h�ng"
        Me.DataGridTextBoxColumn4.MappingName = "Nguoinhap"
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "T�n kho"
        Me.DataGridTextBoxColumn5.MappingName = "Tenkho"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Ti?n h�ng"
        Me.DataGridTextBoxColumn6.MappingName = "Tienhang"
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "VAT"
        Me.DataGridTextBoxColumn7.MappingName = "VAT"
        Me.DataGridTextBoxColumn7.Width = 40
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Th�nh ti?n"
        Me.DataGridTextBoxColumn8.MappingName = "Quydoi"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Hu?"
        Me.DataGridTextBoxColumn9.MappingName = "Huy"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 30
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "IDPhieuXn"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Huỷ"
        Me.DataGridTextBoxColumn11.MappingName = "Huy"
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'GrdDetail
        '
        Me.GrdDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.GrdDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.Location = New System.Drawing.Point(0, 212)
        Me.GrdDetail.MainView = Me.GridView1
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(971, 390)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.coltotal, Me.colCK, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn14, Me.GridColumn15, Me.GridColumn5, Me.GridColumn6, Me.GridColumn13})
        Me.GridView1.GridControl = Me.GrdDetail
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ngày"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Ngay"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 79
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số HĐ"
        Me.GridColumn1.FieldName = "Sophieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 80
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Khoản"
        Me.GridColumn3.FieldName = "MaTC"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 47
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Đơn vị"
        Me.GridColumn4.FieldName = "Tendv"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 199
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "T.VNĐ"
        Me.GridColumn7.DisplayFormat.FormatString = "###,###"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "SotienVND"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Width = 80
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "T. USD"
        Me.GridColumn8.DisplayFormat.FormatString = "###,###.00"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "SotienUSD"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Width = 70
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tỷ giá"
        Me.GridColumn9.DisplayFormat.FormatString = "###,###"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Tygia"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Width = 60
        '
        'coltotal
        '
        Me.coltotal.Caption = "Tổng tiền"
        Me.coltotal.DisplayFormat.FormatString = "###,###"
        Me.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltotal.FieldName = "total"
        Me.coltotal.Name = "coltotal"
        Me.coltotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:###,###}")})
        Me.coltotal.Visible = True
        Me.coltotal.VisibleIndex = 4
        Me.coltotal.Width = 86
        '
        'colCK
        '
        Me.colCK.Caption = "Tiền CK"
        Me.colCK.DisplayFormat.FormatString = "###,###"
        Me.colCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCK.FieldName = "CK"
        Me.colCK.Name = "colCK"
        Me.colCK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CK", "{0:###,###}")})
        Me.colCK.Visible = True
        Me.colCK.VisibleIndex = 5
        Me.colCK.Width = 78
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tổng thu"
        Me.GridColumn10.DisplayFormat.FormatString = "###,###"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Quydoi"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", "{0:###,###}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 93
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Lập phiếu"
        Me.GridColumn11.FieldName = "hoten"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        Me.GridColumn11.Width = 99
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Huỷ"
        Me.GridColumn12.FieldName = "Huy"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 35
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "IDPhieuTC"
        Me.GridColumn14.FieldName = "IDSophieu"
        Me.GridColumn14.MinWidth = 10
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Width = 48
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Thẻ BH"
        Me.GridColumn15.FieldName = "Tenkh"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.Width = 165
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Thực thu"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "ThucThu"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThucThu", "{0:###,###}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 81
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nợ"
        Me.GridColumn6.DisplayFormat.FormatString = "###,####"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "No"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Thực chi"
        Me.GridColumn13.DisplayFormat.FormatString = "###,###"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "ThucChi"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThucChi", "{0:###,###}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 8
        Me.GridColumn13.Width = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(12, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(284, 14)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Kích đúp vào bản ghi để xem chi tiết phiếu thu chi"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(14, 480)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(632, 14)
        Me.ProgressBarControl1.TabIndex = 5
        Me.ProgressBarControl1.Visible = False
        '
        'frmThongKeTC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 602)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.grbDieu_kien)
        Me.Controls.Add(Me.grbTotal)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmThongKeTC"
        Me.Text = "THỐNG KÊ PHIẾU THU CHI"
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTotal.ResumeLayout(False)
        Me.grbTotal.PerformLayout()
        CType(Me.txtTonUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChiUsd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThuUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongSp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChiVND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThuVND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTonVND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDieu_kien.ResumeLayout(False)
        Me.grbDieu_kien.PerformLayout()
        CType(Me.cmbNvLP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKhoan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_phieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbQuyTC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDon_vi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupHuy.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub frmThongKeTC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.dtpTu_ngay.DateTime = NgayGioServer().Date
        Me.dtpDen_ngay.DateTime = NgayGioServer().Date
        Load_ComboBox("SELECT Mabn[Mã],HOTENBN[Họ tên] From HOSOBN union all select Madv[Mã],Tendv[Họ tên] from donvi", Me.cmbDon_vi, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaTC,TenLoaiTC From DM_Thu_Chi order by TenLoaiTC", Me.cmbKhoan, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT Username,HoTen From Nguoi_su_dung order by hoten", Me.cmbNvLP, CNNQLPHONGKHAM)
        Load_ComboBox("SELECT MaQuy,TenQuy From CTQuy order by Tenquy", Me.cmbQuyTC, CNNQLPHONGKHAM)
        loadData()
        Style = True

        Me.GridView1.Columns.Remove(GridColumn14)
        Me.GridView1.Columns.Remove(GridColumn15)
    End Sub
    Private Sub loadData()
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        Application.CurrentCulture = myCIintl
        Dim strSQL As String
        strSQL = "SELECT Phieu_thu_chi.TC + Right('00000'+ cast(Phieu_thu_chi.Sophieu as nvarchar),5) as Sophieu,Phieu_thu_chi.Loaiphieu,Phieu_thu_chi.Tiengui,Phieu_thu_chi.Ngay,Phieu_thu_chi.MaTC,"
        strSQL &= "HOSOBN.SOTHEBHYT as Tenkh,HOSOBN.HOTENBN as Tendv,Phieu_thu_chi.Maquy,Phieu_thu_chi.SotienUSD,Phieu_thu_chi.Tygia,Phieu_thu_chi.SotienVND,Phieu_thu_chi.Quydoi,isnull(total,Quydoi) as total,isnull(total,quydoi)-quydoi as CK,"
        strSQL &= "(Case Phieu_thu_chi.TC when 'T' then Isnull(ThucThu,0) else 0 end) as ThucThu,(Case Phieu_thu_chi.TC when 'C' then Isnull(ThucThu,0) else 0 end) as ThucChi,Isnull(total,0)-Isnull(ThucThu,0) as No,"
        strSQL &= "nguoi_su_dung.hoten,Phieu_thu_chi.GhiChu,Phieu_thu_chi.IDSophieu,Phieu_thu_chi.Huy,Phieu_thu_chi.MaQuy FROM Phieu_thu_chi INNER JOIN nguoi_su_dung ON (Phieu_thu_chi.nguoinhap = nguoi_su_dung.username)"
        If Me.Radio1.Checked = True Then
            strSQL = strSQL & " INNER JOIN HOSOBN ON (Phieu_thu_chi.Madv = HOSOBN.Mabn) where Phieu_thu_chi.Loaiphieu = 1 AND "
        ElseIf Me.Radio2.Checked = True Then
            strSQL = strSQL & " INNER JOIN HOSOBN ON (Phieu_thu_chi.Madv = HOSOBN.Mabn) where Phieu_thu_chi.Loaiphieu = 0 AND "
        Else
            strSQL = strSQL & " INNER JOIN HOSOBN ON (Phieu_thu_chi.Madv = HOSOBN.Mabn) where "
        End If
        If Me.Radio4.Checked = True Then
            strSQL &= " Phieu_thu_chi.Tiengui = 1 AND "
        ElseIf Me.Radio5.Checked = True Then
            strSQL &= " Phieu_thu_chi.Tiengui = 0 AND "
        Else
        End If
        If Me.RadioButton0.Checked = True Then
            strSQL &= " Phieu_thu_chi.Huy = 1 AND "
        ElseIf Me.RadioButton1.Checked = True Then
            strSQL &= " Phieu_thu_chi.Huy = 0 AND "
        Else
        End If
        If Me.dtpTu_ngay.Text <> "" And Me.dtpDen_ngay.Text <> "" Then
            GenSQL("Phieu_thu_chi.Ngay", MdlCommon.Kieukitu.Ngaythang, "BETWEEN", "AND", Me.dtpTu_ngay.DateTime.Date, Me.dtpDen_ngay.DateTime.Date, strSQL)
        End If
        If Me.cmbQuyTC.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.MaQuy", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbQuyTC.EditValue, "", strSQL)
        End If
        If Me.txtSo_phieu.Text <> "" Then
            If IsNumeric(Me.txtSo_phieu.Text) = False Then
                ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.ErrPro.SetError(Me.txtSo_phieu, "Trường số phiếu có giá trị bằng số, không phải bằng chữ")
                ErrPro.SetIconAlignment(Me.txtSo_phieu, ErrorIconAlignment.MiddleRight)
            Else
                GenSQL("Phieu_thu_chi.Sophieu", MdlCommon.Kieukitu.So, "=", "AND", Me.txtSo_phieu.Text, "", strSQL)
            End If
        End If
        If Me.cmbNvLP.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.Nguoinhap", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbNvLP.EditValue, "", strSQL)
        End If
        If Me.cmbDon_vi.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.Madv", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbDon_vi.EditValue, "", strSQL)
        End If
        If Me.cmbKhoan.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.MaTC", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbKhoan.EditValue, "", strSQL)
        End If
        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If
        strSQL &= "union all SELECT Phieu_thu_chi.TC + Right('00000'+ cast(Phieu_thu_chi.Sophieu as nvarchar),5) as Sophieu,Phieu_thu_chi.Loaiphieu,Phieu_thu_chi.Tiengui,Phieu_thu_chi.Ngay,Phieu_thu_chi.MaTC,"
        strSQL &= "NULL as Tenkh,donvi.tendv as Tendv,Phieu_thu_chi.Maquy,Phieu_thu_chi.SotienUSD,Phieu_thu_chi.Tygia,Phieu_thu_chi.SotienVND,Phieu_thu_chi.Quydoi,Isnull(total,Quydoi) as total,Isnull(total,quydoi)-quydoi as CK,"
        strSQL &= "(Case Phieu_thu_chi.TC when 'T' then Isnull(ThucThu,0) else 0 end) as ThucThu,(Case Phieu_thu_chi.TC when 'C' then Isnull(ThucThu,0) else 0 end) as ThucChi,Isnull(total,0)-Isnull(ThucThu,0) as No,"
        strSQL &= "nguoi_su_dung.hoten,Phieu_thu_chi.GhiChu,Phieu_thu_chi.IDSophieu,Phieu_thu_chi.Huy,Phieu_thu_chi.MaQuy FROM Phieu_thu_chi INNER JOIN nguoi_su_dung ON (Phieu_thu_chi.nguoinhap = nguoi_su_dung.username)"
        If Me.Radio1.Checked = True Then
            strSQL = strSQL & " INNER JOIN donvi ON (Phieu_thu_chi.Madv = donvi.Madv) where Phieu_thu_chi.Loaiphieu = 1 AND "
        ElseIf Me.Radio2.Checked = True Then
            strSQL = strSQL & " INNER JOIN donvi ON (Phieu_thu_chi.Madv = donvi.Madv) where Phieu_thu_chi.Loaiphieu = 0 AND "
        Else
            strSQL = strSQL & " INNER JOIN donvi ON (Phieu_thu_chi.Madv = donvi.Madv) where "
        End If
        If Me.Radio4.Checked = True Then
            strSQL &= " Phieu_thu_chi.Tiengui = 1 AND "
        ElseIf Me.Radio5.Checked = True Then
            strSQL &= " Phieu_thu_chi.Tiengui = 0 AND "
        Else
        End If
        If Me.RadioButton0.Checked = True Then
            strSQL &= " Phieu_thu_chi.Huy = 1 AND "
        ElseIf Me.RadioButton1.Checked = True Then
            strSQL &= " Phieu_thu_chi.Huy = 0 AND "
        Else
        End If
        If Me.dtpTu_ngay.Text <> "" And Me.dtpDen_ngay.Text <> "" Then
            GenSQL("Phieu_thu_chi.Ngay", MdlCommon.Kieukitu.Ngaythang, "BETWEEN", "AND", Me.dtpTu_ngay.DateTime.Date, Me.dtpDen_ngay.DateTime.Date, strSQL)
        End If
        If Me.cmbQuyTC.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.MaQuy", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbQuyTC.EditValue, "", strSQL)
        End If
        If Me.txtSo_phieu.Text <> "" Then
            If IsNumeric(Me.txtSo_phieu.Text) = False Then
                ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Me.ErrPro.SetError(Me.txtSo_phieu, "Trường số phiếu có giá trị bằng số, không phải bằng chữ")
                ErrPro.SetIconAlignment(Me.txtSo_phieu, ErrorIconAlignment.MiddleRight)
            Else
                GenSQL("Phieu_thu_chi.Sophieu", MdlCommon.Kieukitu.So, "=", "AND", Me.txtSo_phieu.Text, "", strSQL)
            End If
        End If
        If Me.cmbNvLP.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.Nguoinhap", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbNvLP.EditValue, "", strSQL)
        End If
        If Me.cmbDon_vi.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.Madv", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbDon_vi.EditValue, "", strSQL)
        End If
        If Me.cmbKhoan.EditValue <> "" Then
            GenSQL("Phieu_thu_chi.MaTC", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbKhoan.EditValue, "", strSQL)
        End If
        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If
        dts = BusinessLogic.Data.GetDataset(strSQL & " order by sophieu", CommandType.Text, Nothing, Nothing)
        dtbTkTC = dts.Tables(0)
        dtbTkTC.TableName = "rpt_thongkeTC"
        Me.GrdDetail.DataSource = dtbTkTC
        Dim i As Int16
        ThuUSD = 0
        ThuVND = 0
        ChiUSD = 0
        ChiVND = 0
        k = 0
        For i = 0 To dtbTkTC.Rows.Count - 1
            If dtbTkTC.Rows(i)("Huy") = 0 Then
                If dtbTkTC.Rows(i)("Loaiphieu") = True Then
                    'ThuUSD += dtbTkTC.Rows(i)("SotienUSD")
                    'ThuVND += dtbTkTC.Rows(i)("SotienVND")
                    ThuVND += dtbTkTC.Rows(i)("ThucThu")
                Else
                    'ChiUSD += dtbTkTC.Rows(i)("SotienUSD")
                    'ChiVND += dtbTkTC.Rows(i)("SotienVND")
                    ChiVND += dtbTkTC.Rows(i)("ThucChi")
                End If
            End If
            k = k + 1
        Next
        Me.txtTongSp.Text = k
        'Me.txtThuUSD.Text = Format(ThuUSD, "###,###.00")
        Me.txtThuVND.Text = Format(ThuVND, "###,###")
        'Me.txtChiUsd.Text = Format(ChiUSD, "###,###.00")
        Me.txtChiVND.Text = Format(ChiVND, "###,###")
        'Me.txtTonUSD.Text = Format(ThuUSD - ChiUSD, "###,###.00")
        Me.TxtTonVND.Text = Format(ThuVND - ChiVND, "###,###")

    End Sub
    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Xetngay()
        loadData()
    End Sub
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        Xetngay()
        loadData()
        Dim frm As New frmShowReport
        frm.strBC = frmShowReport.TenBc.ThongkeTC
        frm.Tngay = Me.dtpTu_ngay.DateTime.Date
        frm.Dngay = Me.dtpDen_ngay.DateTime.Date
        frm.DoanhSo = ThuUSD
        frm.TienLai = ThuVND
        frm.fNobandau = ChiUSD
        frm.Paraval3 = ChiVND
        frm.Paraval4 = k
        'Thái sửa để in thống kê
        If Me.Radio1.Checked = True Then 'Thu
            If Me.Radio4.Checked = True Then
                frm.Title = "THỐNG KÊ PHIẾU THU NGÂN HÀNG"
            ElseIf Me.Radio5.Checked = True Then
                frm.Title = "THỐNG KÊ PHIẾU THU TIỀN MẶT"
            Else
                frm.Title = "THỐNG KÊ PHIẾU THU"
            End If
        ElseIf Me.Radio2.Checked = True Then 'Chi
            If Me.Radio4.Checked = True Then
                frm.Title = "THỐNG KÊ PHIẾU CHI NGÂN HÀNG"
            ElseIf Me.Radio5.Checked = True Then
                frm.Title = "THỐNG KÊ PHIẾU CHI TIỀN MẶT"
            Else
                frm.Title = "THỐNG KÊ PHIẾU CHI"
            End If
        Else  'All
            If Me.Radio4.Checked = True Then
                frm.Title = "THỐNG KÊ PHIẾU THU CHI NGÂN HÀNG"
            ElseIf Me.Radio5.Checked = True Then
                frm.Title = "THỐNG KÊ PHIẾU THU CHI TIỀN MẶT"
            Else
                frm.Title = "THỐNG KÊ PHIẾU THU CHI"
            End If
        End If
        frm.dtb = dtbTkTC
        frm.Show()
        'Application.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
    End Sub
    Private Sub GrdDetail_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick

        Dim frm As New frmPhieuTC
        frm.blnEdit = True
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        frm.StartPosition = FormStartPosition.CenterScreen
        If Me.GridView1.FocusedRowHandle <> -999999 Then
            If dr.IsNew = False Then
                frm.IDPhieuTC &= dr("IDSophieu") & ","
                If dr("Loaiphieu") = True And dr("Tiengui") = False Then
                    frm.Name = "frmThuTienMat"
                    frm.Text = "Phiếu thu tiền mặt"
                    frm.blnLoaiphieu = True
                ElseIf dr("Loaiphieu") = False And dr("Tiengui") = False Then
                    frm.Name = "frmChiTienMat"
                    frm.Text = "Phiếu chi tiền mặt"
                    frm.Label3.Text = "PHIẾU CHI TIỀN MẶT"
                    frm.blnLoaiphieu = False
                ElseIf dr("Loaiphieu") = True And dr("Tiengui") = True Then
                    frm.Name = "frmThuTienGui"
                    frm.Text = "Phiếu thu tiền gửi"
                    frm.blnLoaiphieu = True
                ElseIf dr("Loaiphieu") = False And dr("Tiengui") = True Then
                    frm.Name = "frmChiTienGui"
                    frm.Text = "Phiếu chi tiền gửi"
                    frm.blnLoaiphieu = False
                End If
            End If
            If dr("huy") = True Then
                frm.blnDelete = True
            End If
        End If
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()

    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub cmbDon_vi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDon_vi.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbDon_vi.EditValue = ""
        End If
    End Sub
    Private Sub cmbKhoan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKhoan.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbKhoan.EditValue = ""
        End If
    End Sub
    Private Sub cmbNvLP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNvLP.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbNvLP.EditValue = ""
        End If
    End Sub
    Private Sub cmbQuyTC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbQuyTC.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbQuyTC.EditValue = ""
        End If
    End Sub
    Private Sub dtpDen_ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDen_ngay.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.dtpDen_ngay.EditValue = ""
        End If
    End Sub
    Private Sub dtpTu_ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTu_ngay.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.dtpTu_ngay.EditValue = ""
        End If
    End Sub
    Private Sub RadioButton0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton0.CheckedChanged
        If Me.RadioButton0.Checked = True Then
            loadData()
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            loadData()
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            If Style = True Then
                loadData()
            End If
        End If
    End Sub
    Private Sub Radio1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio1.CheckedChanged
        loadData()
    End Sub
    Private Sub Radio2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio2.CheckedChanged
        loadData()
    End Sub
    Private Sub Radio3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio3.CheckedChanged
        loadData()
    End Sub
    Private Sub Radio4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio4.CheckedChanged
        loadData()
    End Sub
    Private Sub Radio5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio5.CheckedChanged
        loadData()
    End Sub
    Private Sub Radio6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio6.CheckedChanged
        loadData()
    End Sub
    Private Sub dtpTu_ngay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTu_ngay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.dtpDen_ngay.Focus()
            Xetngay()
            loadData()
        End If
    End Sub
    Private Sub dtpDen_ngay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDen_ngay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txtSo_phieu.Focus()
            Xetngay()
            loadData()
        End If
    End Sub
    Private Sub txtSo_phieu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSo_phieu.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            loadData()
            Me.cmbKhoan.Focus()
        End If
    End Sub
    Private Sub cmbKhoan_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKhoan.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            loadData()
        End If
    End Sub
    Private Sub cmbNvLP_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNvLP.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            loadData()
            Me.cmbQuyTC.Focus()
        End If
    End Sub
    Private Sub cmbQuyTC_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbQuyTC.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            loadData()
            Me.cmbDon_vi.Focus()
        End If
    End Sub
    Private Sub cmbDon_vi_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDon_vi.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            loadData()
        End If
    End Sub
    Private Sub cmbKhach_hang_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            loadData()
            Me.btnXem.Focus()
        End If
    End Sub
    Private Sub Xetngay()
        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dts = BusinessLogic.Data.GetDataset("select * from ket_chuyen", CommandType.Text, Nothing, Nothing)
        dtb = dts.Tables(0)
        ngayketchuyen = dtb.Rows(0)("ngayketchuyen")
        If Me.dtpTu_ngay.Text = "" Then
            Me.dtpTu_ngay.DateTime = ngayketchuyen.Date
        End If
        If Me.dtpDen_ngay.Text = "" Then
            Me.dtpDen_ngay.DateTime = Today.Date.Date
        End If
        If Me.dtpTu_ngay.DateTime.Date > Me.dtpDen_ngay.DateTime.Date Then
            MsgBox("Từ ngày không thể lớn hơn đến ngày!")
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim strsql As String
        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        'strsql = "select ngay as chitiet,sl,dongia,vat,psno,psco,ngay1,Tenkh from BANGTAM_CONGNO1 left join khach_hang on khach_hang.makh=BANGTAM_CONGNO1.makh order by bangtam_congno1.id"
        'dtb = Load_DataTable(strsql, CNNQLPHONGKHAM)
        'GrdDetail.DataSource = dtbTkTC
        '--------------------------------------
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim i As Int16 = 5
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = i
        '--------------------------------------
        wSheet.Range("C2", "F2").Merge()
        wSheet.Range("C2", "F2").Font.Bold = True
        wSheet.Range("C2", "F2").Font.Size = 20
        wSheet.Range("C2", "F2").Value2 = "THỐNG KÊ THU CHI"

        excel.Cells(i, 1) = "STT"
        excel.Cells(i, 2) = "Ngày lập"
        excel.Cells(i, 3) = "Số phiếu"
        excel.Cells(i, 4) = "Người Giao Dịch"
        excel.Cells(i, 5) = "Thẻ BHYT"
        excel.Cells(i, 6) = "Số tiền"
        excel.Cells(i, 7) = "Nhân viên"
        wSheet.Range("A5", "G5").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin

        Dim j As Int32 = i + 1
        Dim tem = 0
        For j = i + 1 To dtbTkTC.Rows.Count + i
            tem = j - i - 1
            excel.Cells(j, 1) = ""
            excel.Cells(j, 2) = dtbTkTC.Rows(tem)("Ngay")
            excel.Cells(j, 3) = dtbTkTC.Rows(tem)("Sophieu")
            excel.Cells(j, 4) = dtbTkTC.Rows(tem)("Tendv")
            excel.Cells(j, 5) = dtbTkTC.Rows(tem)("Tenkh")
            excel.Cells(j, 6) = dtbTkTC.Rows(tem)("SotienVND")
            excel.Cells(j, 7) = dtbTkTC.Rows(tem)("hoten")
            wSheet.Range("A" + j.ToString, "G" + j.ToString).Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin
        Next
        excel.Cells(j + 1, 6) = Me.TxtTonVND.Text
        excel.Cells(j + 1, 5) = "Tổng:"
        wSheet.Columns.AutoFit()
        wSheet.Rows.AutoFit()
        'Mo thu muc va luu file
        Dim strFileName As String
        Dim blnFileOpen As Boolean = False
        Dim Save As New SaveFileDialog
        If Save.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Save.Filter = "Excel Files|*.xls"
            strFileName = Save.FileName
            Try
                wBook.SaveAs(strFileName)
                excel.Workbooks.Open(strFileName)
                excel.Visible = True
            Catch ex As Exception
                Exit Sub
            End Try
        Else : Exit Sub
        End If
        loadData()
    End Sub
End Class
