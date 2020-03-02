Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraExport
Public Class frmtkxnnoibo
    Inherits frmBase 'System.Windows.Forms.Form
    Private dtb As New DataTable
    Private dtb1 As New DataTable
    Private strSQL As String
    Private Tienhang As Double
    Private VAT As Double
    Private Tongso As Double
    Private k As Int16
    Private foundClick As Boolean = True
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
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents grbDieu_kien As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnXem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDen_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpTu_ngay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbKho_hang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtkxnnoibo))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.grbDieu_kien = New System.Windows.Forms.GroupBox()
        Me.cmbKho_hang = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTu_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDen_ngay = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnXem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdDetail = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDieu_kien.SuspendLayout()
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'grbDieu_kien
        '
        Me.grbDieu_kien.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grbDieu_kien.Controls.Add(Me.cmbKho_hang)
        Me.grbDieu_kien.Controls.Add(Me.Label4)
        Me.grbDieu_kien.Controls.Add(Me.Label3)
        Me.grbDieu_kien.Controls.Add(Me.dtpTu_ngay)
        Me.grbDieu_kien.Controls.Add(Me.dtpDen_ngay)
        Me.grbDieu_kien.Controls.Add(Me.Label5)
        Me.grbDieu_kien.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDieu_kien.ForeColor = System.Drawing.Color.Red
        Me.grbDieu_kien.Location = New System.Drawing.Point(0, 1)
        Me.grbDieu_kien.Name = "grbDieu_kien"
        Me.grbDieu_kien.Size = New System.Drawing.Size(833, 74)
        Me.grbDieu_kien.TabIndex = 0
        Me.grbDieu_kien.TabStop = False
        Me.grbDieu_kien.Text = "Điều kiện thông kê"
        '
        'cmbKho_hang
        '
        Me.cmbKho_hang.Location = New System.Drawing.Point(547, 32)
        Me.cmbKho_hang.Name = "cmbKho_hang"
        Me.cmbKho_hang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbKho_hang.Properties.Appearance.Options.UseFont = True
        Me.cmbKho_hang.Properties.AutoHeight = False
        Me.cmbKho_hang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKho_hang.Properties.NullText = ""
        Me.cmbKho_hang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbKho_hang.Size = New System.Drawing.Size(240, 22)
        Me.cmbKho_hang.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(231, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Đến ngày:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Từ ngày:"
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpTu_ngay.Location = New System.Drawing.Point(84, 33)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpTu_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpTu_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpTu_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpTu_ngay.Properties.AutoHeight = False
        Me.dtpTu_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTu_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTu_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTu_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpTu_ngay.Size = New System.Drawing.Size(110, 22)
        Me.dtpTu_ngay.TabIndex = 0
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.EditValue = New Date(2005, 4, 25, 0, 0, 0, 0)
        Me.dtpDen_ngay.Location = New System.Drawing.Point(315, 33)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpDen_ngay.Properties.Appearance.Options.UseFont = True
        Me.dtpDen_ngay.Properties.Appearance.Options.UseTextOptions = True
        Me.dtpDen_ngay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtpDen_ngay.Properties.AutoHeight = False
        Me.dtpDen_ngay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDen_ngay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpDen_ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDen_ngay.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpDen_ngay.Size = New System.Drawing.Size(110, 22)
        Me.dtpDen_ngay.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(483, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phòng"
        '
        'btnXem
        '
        Me.btnXem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXem.Appearance.Options.UseFont = True
        Me.btnXem.Appearance.Options.UseForeColor = True
        Me.btnXem.Location = New System.Drawing.Point(504, 85)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 25)
        Me.btnXem.TabIndex = 9
        Me.btnXem.Text = "&Xem"
        '
        'btnIn
        '
        Me.btnIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnIn.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIn.Appearance.Options.UseFont = True
        Me.btnIn.Appearance.Options.UseForeColor = True
        Me.btnIn.Location = New System.Drawing.Point(608, 85)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 25)
        Me.btnIn.TabIndex = 10
        Me.btnIn.Text = "&In TK"
        '
        'SimpleButton_Close
        '
        Me.SimpleButton_Close.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SimpleButton_Close.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton_Close.Appearance.Options.UseFont = True
        Me.SimpleButton_Close.Appearance.Options.UseForeColor = True
        Me.SimpleButton_Close.Location = New System.Drawing.Point(712, 85)
        Me.SimpleButton_Close.Name = "SimpleButton_Close"
        Me.SimpleButton_Close.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton_Close.TabIndex = 11
        Me.SimpleButton_Close.Text = "&Thoát"
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'grdDetail
        '
        Me.grdDetail.Location = New System.Drawing.Point(0, 130)
        Me.grdDetail.MainView = Me.GridView1
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.Size = New System.Drawing.Size(833, 427)
        Me.grdDetail.TabIndex = 2
        Me.grdDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1, Me.GridColumn4, Me.GridColumn3, Me.GridColumn5, Me.GridColumn10, Me.GridColumn11})
        Me.GridView1.GridControl = Me.grdDetail
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quydoi", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ngày"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MM/yy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "ngay"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 85
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Số HĐ"
        Me.GridColumn1.FieldName = "sophieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 99
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Loại"
        Me.GridColumn4.FieldName = "loaixn"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 78
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Bệnh nhân"
        Me.GridColumn3.FieldName = "hotenbn"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 200
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nhân viên"
        Me.GridColumn5.FieldName = "hoten"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 212
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Huỷ"
        Me.GridColumn10.FieldName = "huy"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 62
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Phiếu X/N"
        Me.GridColumn11.FieldName = "loaiphieu"
        Me.GridColumn11.MinWidth = 10
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(7, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(249, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Kích đúp vào bản ghi để xem chi tiết phiếu"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(16, 466)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(608, 14)
        Me.ProgressBarControl1.TabIndex = 13
        Me.ProgressBarControl1.Visible = False
        '
        'frmtkxnnoibo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 558)
        Me.Controls.Add(Me.grdDetail)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.grbDieu_kien)
        Me.Controls.Add(Me.SimpleButton_Close)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.btnIn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(845, 597)
        Me.Name = "frmtkxnnoibo"
        Me.Text = "THỐNG KÊ PHIẾU XUẤT NHẬP VTYT"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDieu_kien.ResumeLayout(False)
        Me.grbDieu_kien.PerformLayout()
        CType(Me.cmbKho_hang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmThongkeXN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Load_ComboBox("SELECT maphong,tenphong From phong_ban where loai not in(1,8) ", Me.cmbKho_hang, CNNQLPHONGKHAM)
        Me.dtpTu_ngay.DateTime = NgayGioServer().Date
        Me.dtpDen_ngay.DateTime = NgayGioServer().Date
        LoadData()
    End Sub
    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Xetngay()
        LoadData()
    End Sub
    Private Sub LoadData()
        Me.ErrPro.Dispose()
        strSQL = "Select tb_xuatnhapnoibo.ID,tb_xuatnhapnoibo.sophieu,tb_xuatnhapnoibo.ngay,HOSOBN.hotenbn,tb_xuatnhapnoibo.loaixn,Nguoi_su_dung.hoten,tb_xuatnhapnoibo.huy,tb_xuatnhapnoibo.loaiphieu from tb_xuatnhapnoibo inner JOIN nguoi_su_dung  ON nguoi_su_dung.Username = tb_xuatnhapnoibo.Manv left JOIN HOSOBN ON (tb_xuatnhapnoibo.Mabn = HOSOBN.Mabn) where Loaiphieu in(1,0) AND "
        If Me.cmbKho_hang.EditValue <> "" Then
            GenSQL("tb_xuatnhapnoibo.maphong", MdlCommon.Kieukitu.Text, "=", "AND", Me.cmbKho_hang.EditValue, "", strSQL)
        End If
        If Me.dtpTu_ngay.Text <> "" And Me.dtpDen_ngay.Text <> "" Then
            GenSQL("tb_xuatnhapnoibo.Ngay", MdlCommon.Kieukitu.Ngaythang, "BETWEEN", "AND", Me.dtpTu_ngay.DateTime, Me.dtpDen_ngay.DateTime, strSQL)
        End If
        If strSQL <> "" Then
            strSQL = Mid(strSQL, 1, Len(strSQL) - 4)
        End If
        dtb = Load_DataTable(strSQL, CNNQLPHONGKHAM)
        Me.grdDetail.DataSource = dtb
        Me.GridView1.ExpandAllGroups()

    End Sub
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        
    End Sub
    Private Sub grdDetail_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDetail.DoubleClick
        Dim frm As New Object
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If dr.IsNew = False Then
                    If dr("loaixn") = "XTH" Then
                        frm = New frmPhieuxuatvtyt
                        frm.IDPhieuxuat &= dr("ID") & ","
                        If dr("Huy") = True Then
                            frm.blnDelete = True
                        End If
                    ElseIf dr("loaixn") = "NNB" Then
                        frm = New frmPhieunhapnoibo
                        frm.IDPhieuxuat &= dr("ID") & ","
                        If dr("Huy") = True Then
                            frm.blnDelete = True
                        End If
                    Else
                        Exit Sub
                    End If
                End If
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
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()

    End Sub
    Private Sub SimpleButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton_Close.Click
        Me.Close()
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
    Private Sub dtpTu_ngay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTu_ngay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.dtpDen_ngay.Focus()
            Xetngay()
            LoadData()
        End If
    End Sub
    Private Sub dtpDen_ngay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDen_ngay.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.cmbKho_hang.Focus()
            Xetngay()
            LoadData()
        End If
    End Sub
    Private Sub cmbKho_hang_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbKho_hang.KeyUp
        If e.KeyCode = Keys.Enter Then
            Xetngay()
            LoadData()

        End If
    End Sub
     
    Private Sub Xetngay()
        Dim dtb As DataTable
        Dim ngayketchuyen As Date
        dtb = Load_DataTable("select * from ket_chuyen", CNNQLPHONGKHAM)
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

    
End Class
