<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ThanhToanBanLe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ThanhToanBanLe))
        Me.Grbthongtin = New DevExpress.XtraEditors.GroupControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Seditbn = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Checka = New DevExpress.XtraEditors.CheckEdit()
        Me.Check_xong = New DevExpress.XtraEditors.CheckEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmabn = New DevExpress.XtraEditors.TextEdit()
        Me.txtdiachi = New DevExpress.XtraEditors.TextEdit()
        Me.btnthutien = New DevExpress.XtraEditors.SimpleButton()
        Me.txtgioitinh = New DevExpress.XtraEditors.TextEdit()
        Me.btnxem = New DevExpress.XtraEditors.SimpleButton()
        Me.txttuoi = New DevExpress.XtraEditors.TextEdit()
        Me.txthoten = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcdls = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsohoso = New DevExpress.XtraEditors.TextEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.grv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnhom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDongia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colngay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colduyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltenbn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grbduyet = New DevExpress.XtraEditors.GroupControl()
        Me.chkall = New DevExpress.XtraEditors.CheckEdit()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txttongtien = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttamung = New DevExpress.XtraEditors.TextEdit()
        Me.btnchitien = New DevExpress.XtraEditors.SimpleButton()
        Me.txttientt = New DevExpress.XtraEditors.TextEdit()
        CType(Me.Grbthongtin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grbthongtin.SuspendLayout()
        CType(Me.Seditbn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Checka.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check_xong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmabn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdiachi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgioitinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttuoi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthoten.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcdls.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsohoso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grbduyet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grbduyet.SuspendLayout()
        CType(Me.chkall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttongtien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttamung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttientt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grbthongtin
        '
        Me.Grbthongtin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grbthongtin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Grbthongtin.Controls.Add(Me.Label9)
        Me.Grbthongtin.Controls.Add(Me.Seditbn)
        Me.Grbthongtin.Controls.Add(Me.DateEdit1)
        Me.Grbthongtin.Controls.Add(Me.Checka)
        Me.Grbthongtin.Controls.Add(Me.Check_xong)
        Me.Grbthongtin.Controls.Add(Me.Label7)
        Me.Grbthongtin.Controls.Add(Me.txtmabn)
        Me.Grbthongtin.Controls.Add(Me.txtdiachi)
        Me.Grbthongtin.Controls.Add(Me.btnthutien)
        Me.Grbthongtin.Controls.Add(Me.txtgioitinh)
        Me.Grbthongtin.Controls.Add(Me.btnxem)
        Me.Grbthongtin.Controls.Add(Me.txttuoi)
        Me.Grbthongtin.Controls.Add(Me.txthoten)
        Me.Grbthongtin.Controls.Add(Me.Label6)
        Me.Grbthongtin.Controls.Add(Me.Label5)
        Me.Grbthongtin.Controls.Add(Me.Label4)
        Me.Grbthongtin.Controls.Add(Me.Label3)
        Me.Grbthongtin.Controls.Add(Me.txtcdls)
        Me.Grbthongtin.Controls.Add(Me.Label2)
        Me.Grbthongtin.Controls.Add(Me.txtsohoso)
        Me.Grbthongtin.Controls.Add(Me.Label32)
        Me.Grbthongtin.Location = New System.Drawing.Point(2, 4)
        Me.Grbthongtin.Name = "Grbthongtin"
        Me.Grbthongtin.Size = New System.Drawing.Size(636, 148)
        Me.Grbthongtin.TabIndex = 50
        Me.Grbthongtin.Text = "Thông tin khám"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(33, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 16)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Ngày"
        '
        'Seditbn
        '
        Me.Seditbn.EditValue = ""
        Me.Seditbn.Location = New System.Drawing.Point(84, 54)
        Me.Seditbn.Name = "Seditbn"
        Me.Seditbn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Seditbn.Properties.NullText = ""
        Me.Seditbn.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.Seditbn.Size = New System.Drawing.Size(263, 20)
        Me.Seditbn.TabIndex = 73
        Me.Seditbn.Tag = "mabn"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colma, Me.GridColumn1, Me.coltel, Me.coladd})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colma
        '
        Me.colma.Caption = "Mã"
        Me.colma.FieldName = "mabn"
        Me.colma.Name = "colma"
        Me.colma.Visible = True
        Me.colma.VisibleIndex = 0
        Me.colma.Width = 85
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Họ tên"
        Me.GridColumn1.FieldName = "hotenbn"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 124
        '
        'coltel
        '
        Me.coltel.Caption = "Điện thoại"
        Me.coltel.FieldName = "dienthoai"
        Me.coltel.Name = "coltel"
        Me.coltel.Visible = True
        Me.coltel.VisibleIndex = 2
        Me.coltel.Width = 87
        '
        'coladd
        '
        Me.coladd.Caption = "Địa chỉ"
        Me.coladd.FieldName = "diachichitiet"
        Me.coladd.Name = "coladd"
        Me.coladd.Visible = True
        Me.coladd.VisibleIndex = 3
        Me.coladd.Width = 200
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(84, 31)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.DateEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.DateEdit1.Size = New System.Drawing.Size(119, 20)
        Me.DateEdit1.TabIndex = 69
        '
        'Checka
        '
        Me.Checka.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Checka.Location = New System.Drawing.Point(541, 25)
        Me.Checka.Name = "Checka"
        Me.Checka.Properties.Caption = "Xem tổng hợp"
        Me.Checka.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Checka.Size = New System.Drawing.Size(90, 19)
        Me.Checka.TabIndex = 67
        '
        'Check_xong
        '
        Me.Check_xong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Check_xong.Location = New System.Drawing.Point(396, 29)
        Me.Check_xong.Name = "Check_xong"
        Me.Check_xong.Properties.Caption = "Đã kết thúc"
        Me.Check_xong.Size = New System.Drawing.Size(90, 19)
        Me.Check_xong.TabIndex = 68
        Me.Check_xong.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Mã BN"
        '
        'txtmabn
        '
        Me.txtmabn.EditValue = ""
        Me.txtmabn.Location = New System.Drawing.Point(84, 54)
        Me.txtmabn.Name = "txtmabn"
        Me.txtmabn.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmabn.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmabn.Properties.Appearance.Options.UseBackColor = True
        Me.txtmabn.Properties.Appearance.Options.UseFont = True
        Me.txtmabn.Properties.AutoHeight = False
        Me.txtmabn.Properties.ReadOnly = True
        Me.txtmabn.Size = New System.Drawing.Size(167, 20)
        Me.txtmabn.TabIndex = 65
        '
        'txtdiachi
        '
        Me.txtdiachi.EditValue = ""
        Me.txtdiachi.Location = New System.Drawing.Point(84, 102)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtdiachi.Properties.Appearance.Options.UseBackColor = True
        Me.txtdiachi.Properties.AutoHeight = False
        Me.txtdiachi.Properties.ReadOnly = True
        Me.txtdiachi.Size = New System.Drawing.Size(445, 20)
        Me.txtdiachi.TabIndex = 64
        '
        'btnthutien
        '
        Me.btnthutien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnthutien.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthutien.Appearance.Options.UseFont = True
        Me.btnthutien.Location = New System.Drawing.Point(544, 81)
        Me.btnthutien.Name = "btnthutien"
        Me.btnthutien.Size = New System.Drawing.Size(87, 30)
        Me.btnthutien.TabIndex = 57
        Me.btnthutien.Text = "Thu tiền"
        '
        'txtgioitinh
        '
        Me.txtgioitinh.EditValue = ""
        Me.txtgioitinh.Location = New System.Drawing.Point(492, 54)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtgioitinh.Properties.Appearance.Options.UseBackColor = True
        Me.txtgioitinh.Properties.AutoHeight = False
        Me.txtgioitinh.Properties.ReadOnly = True
        Me.txtgioitinh.Size = New System.Drawing.Size(37, 20)
        Me.txtgioitinh.TabIndex = 62
        Me.txtgioitinh.Visible = False
        '
        'btnxem
        '
        Me.btnxem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnxem.Location = New System.Drawing.Point(544, 47)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(87, 30)
        Me.btnxem.TabIndex = 56
        Me.btnxem.Text = "Xem"
        '
        'txttuoi
        '
        Me.txttuoi.EditValue = ""
        Me.txttuoi.Location = New System.Drawing.Point(391, 54)
        Me.txttuoi.Name = "txttuoi"
        Me.txttuoi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txttuoi.Properties.Appearance.Options.UseBackColor = True
        Me.txttuoi.Properties.AutoHeight = False
        Me.txttuoi.Properties.ReadOnly = True
        Me.txttuoi.Size = New System.Drawing.Size(33, 20)
        Me.txttuoi.TabIndex = 61
        Me.txttuoi.Visible = False
        '
        'txthoten
        '
        Me.txthoten.EditValue = ""
        Me.txthoten.Location = New System.Drawing.Point(84, 76)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txthoten.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoten.Properties.Appearance.Options.UseBackColor = True
        Me.txthoten.Properties.Appearance.Options.UseFont = True
        Me.txthoten.Properties.AutoHeight = False
        Me.txthoten.Properties.ReadOnly = True
        Me.txthoten.Size = New System.Drawing.Size(445, 24)
        Me.txthoten.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(431, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Giới tính"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(351, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Tuổi"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "CĐLS"
        Me.Label3.Visible = False
        '
        'txtcdls
        '
        Me.txtcdls.EditValue = ""
        Me.txtcdls.Location = New System.Drawing.Point(84, 124)
        Me.txtcdls.Name = "txtcdls"
        Me.txtcdls.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtcdls.Properties.Appearance.Options.UseBackColor = True
        Me.txtcdls.Properties.AutoHeight = False
        Me.txtcdls.Properties.ReadOnly = True
        Me.txtcdls.Size = New System.Drawing.Size(445, 20)
        Me.txtcdls.TabIndex = 55
        Me.txtcdls.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Họ tên BN"
        '
        'txtsohoso
        '
        Me.txtsohoso.EditValue = "0"
        Me.txtsohoso.Location = New System.Drawing.Point(261, 30)
        Me.txtsohoso.Name = "txtsohoso"
        Me.txtsohoso.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtsohoso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsohoso.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsohoso.Properties.Appearance.Options.UseBackColor = True
        Me.txtsohoso.Properties.Appearance.Options.UseFont = True
        Me.txtsohoso.Properties.Appearance.Options.UseForeColor = True
        Me.txtsohoso.Properties.Appearance.Options.UseTextOptions = True
        Me.txtsohoso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtsohoso.Properties.AutoHeight = False
        Me.txtsohoso.Size = New System.Drawing.Size(86, 20)
        Me.txtsohoso.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(209, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(47, 16)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Số HS"
        '
        'grv
        '
        Me.grv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grv.Location = New System.Drawing.Point(2, 25)
        Me.grv.MainView = Me.GridView1
        Me.grv.Name = "grv"
        Me.grv.Size = New System.Drawing.Size(426, 606)
        Me.grv.TabIndex = 51
        Me.grv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnhom, Me.colten, Me.colsl, Me.colDongia, Me.coltt, Me.colngay, Me.colduyet, Me.coltenbn})
        Me.GridView1.GridControl = Me.grv
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "hotenbn", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coltenbn, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colnhom
        '
        Me.colnhom.Caption = "Loại"
        Me.colnhom.FieldName = "loaidv"
        Me.colnhom.Name = "colnhom"
        Me.colnhom.Visible = True
        Me.colnhom.VisibleIndex = 0
        Me.colnhom.Width = 42
        '
        'colten
        '
        Me.colten.Caption = "Dịch vụ"
        Me.colten.FieldName = "tensp"
        Me.colten.Name = "colten"
        Me.colten.Visible = True
        Me.colten.VisibleIndex = 1
        Me.colten.Width = 166
        '
        'colsl
        '
        Me.colsl.Caption = "Số lượng"
        Me.colsl.FieldName = "soluong"
        Me.colsl.Name = "colsl"
        Me.colsl.Width = 77
        '
        'colDongia
        '
        Me.colDongia.Caption = "Đơn giá"
        Me.colDongia.FieldName = "dongia"
        Me.colDongia.Name = "colDongia"
        Me.colDongia.Width = 110
        '
        'coltt
        '
        Me.coltt.Caption = "Thành tiền"
        Me.coltt.DisplayFormat.FormatString = "###,###"
        Me.coltt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltt.FieldName = "thanhtien"
        Me.coltt.Name = "coltt"
        Me.coltt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "thanhtien", "Tổng tiền={0:###,###}")})
        Me.coltt.Visible = True
        Me.coltt.VisibleIndex = 2
        Me.coltt.Width = 113
        '
        'colngay
        '
        Me.colngay.Caption = "Ngày"
        Me.colngay.FieldName = "ngaylap"
        Me.colngay.Name = "colngay"
        Me.colngay.Visible = True
        Me.colngay.VisibleIndex = 3
        Me.colngay.Width = 51
        '
        'colduyet
        '
        Me.colduyet.Caption = "Duyệt"
        Me.colduyet.FieldName = "duyetbh"
        Me.colduyet.Name = "colduyet"
        Me.colduyet.Visible = True
        Me.colduyet.VisibleIndex = 4
        Me.colduyet.Width = 38
        '
        'coltenbn
        '
        Me.coltenbn.Caption = "Bệnh nhân"
        Me.coltenbn.FieldName = "hotenbn"
        Me.coltenbn.Name = "coltenbn"
        Me.coltenbn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "hotenbn", "{0}")})
        Me.coltenbn.Visible = True
        Me.coltenbn.VisibleIndex = 5
        '
        'Grbduyet
        '
        Me.Grbduyet.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Grbduyet.Controls.Add(Me.chkall)
        Me.Grbduyet.Controls.Add(Me.btnCap_nhat)
        Me.Grbduyet.Controls.Add(Me.SimpleButton1)
        Me.Grbduyet.Controls.Add(Me.grv)
        Me.Grbduyet.Dock = System.Windows.Forms.DockStyle.Right
        Me.Grbduyet.Location = New System.Drawing.Point(642, 0)
        Me.Grbduyet.Name = "Grbduyet"
        Me.Grbduyet.Size = New System.Drawing.Size(433, 636)
        Me.Grbduyet.TabIndex = 52
        Me.Grbduyet.Text = "Chi tiết dịch vụ"
        '
        'chkall
        '
        Me.chkall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkall.Location = New System.Drawing.Point(341, 35)
        Me.chkall.Name = "chkall"
        Me.chkall.Properties.Appearance.Options.UseTextOptions = True
        Me.chkall.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.chkall.Properties.Caption = "Chọn tất cả"
        Me.chkall.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkall.Size = New System.Drawing.Size(82, 19)
        Me.chkall.TabIndex = 52
        Me.chkall.Visible = False
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCap_nhat.Location = New System.Drawing.Point(234, 28)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(87, 30)
        Me.btnCap_nhat.TabIndex = 55
        Me.btnCap_nhat.Text = "Duyệt thu"
        Me.btnCap_nhat.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(130, 28)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(87, 30)
        Me.SimpleButton1.TabIndex = 57
        Me.SimpleButton1.Text = "Nạp lại"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 158)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(636, 478)
        Me.CrystalReportViewer1.TabIndex = 53
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'txttongtien
        '
        Me.txttongtien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttongtien.EditValue = ""
        Me.txttongtien.Location = New System.Drawing.Point(543, 163)
        Me.txttongtien.Name = "txttongtien"
        Me.txttongtien.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txttongtien.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttongtien.Properties.Appearance.Options.UseBackColor = True
        Me.txttongtien.Properties.Appearance.Options.UseFont = True
        Me.txttongtien.Properties.Appearance.Options.UseTextOptions = True
        Me.txttongtien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttongtien.Properties.AutoHeight = False
        Me.txttongtien.Properties.ReadOnly = True
        Me.txttongtien.Size = New System.Drawing.Size(89, 20)
        Me.txttongtien.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(460, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Tổng tiền:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(642, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Tạm Ứng:"
        Me.Label8.Visible = False
        '
        'txttamung
        '
        Me.txttamung.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttamung.EditValue = ""
        Me.txttamung.Location = New System.Drawing.Point(642, 198)
        Me.txttamung.Name = "txttamung"
        Me.txttamung.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txttamung.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttamung.Properties.Appearance.Options.UseBackColor = True
        Me.txttamung.Properties.Appearance.Options.UseFont = True
        Me.txttamung.Properties.Appearance.Options.UseTextOptions = True
        Me.txttamung.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttamung.Properties.AutoHeight = False
        Me.txttamung.Properties.ReadOnly = True
        Me.txttamung.Size = New System.Drawing.Size(83, 20)
        Me.txttamung.TabIndex = 69
        Me.txttamung.Visible = False
        '
        'btnchitien
        '
        Me.btnchitien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnchitien.Location = New System.Drawing.Point(378, 158)
        Me.btnchitien.Name = "btnchitien"
        Me.btnchitien.Size = New System.Drawing.Size(76, 27)
        Me.btnchitien.TabIndex = 71
        Me.btnchitien.Text = "Trả BN"
        Me.btnchitien.Visible = False
        '
        'txttientt
        '
        Me.txttientt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttientt.EditValue = ""
        Me.txttientt.Location = New System.Drawing.Point(727, 200)
        Me.txttientt.Name = "txttientt"
        Me.txttientt.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txttientt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttientt.Properties.Appearance.Options.UseBackColor = True
        Me.txttientt.Properties.Appearance.Options.UseFont = True
        Me.txttientt.Properties.Appearance.Options.UseTextOptions = True
        Me.txttientt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txttientt.Properties.AutoHeight = False
        Me.txttientt.Properties.ReadOnly = True
        Me.txttientt.Size = New System.Drawing.Size(97, 20)
        Me.txttientt.TabIndex = 72
        Me.txttientt.Visible = False
        '
        'FRM_ThanhToanBanLe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1075, 636)
        Me.Controls.Add(Me.Grbduyet)
        Me.Controls.Add(Me.txttientt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttamung)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttongtien)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Grbthongtin)
        Me.Controls.Add(Me.btnchitien)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_ThanhToanBanLe"
        Me.Text = "Thu tiền theo dịch vụ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grbthongtin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grbthongtin.ResumeLayout(False)
        Me.Grbthongtin.PerformLayout()
        CType(Me.Seditbn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Checka.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check_xong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmabn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdiachi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgioitinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttuoi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthoten.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcdls.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsohoso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grbduyet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grbduyet.ResumeLayout(False)
        CType(Me.chkall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttongtien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttamung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttientt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grbthongtin As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtsohoso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents grv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Grbduyet As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkall As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcdls As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colnhom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDongia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colngay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colduyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtdiachi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtgioitinh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttuoi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthoten As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmabn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnxem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnthutien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txttongtien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Checka As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Check_xong As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttamung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnchitien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txttientt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents coltenbn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Seditbn As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
