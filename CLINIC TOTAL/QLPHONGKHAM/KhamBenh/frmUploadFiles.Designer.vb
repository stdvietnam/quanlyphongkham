<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUploadFiles))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit_Xem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit_ChinhSua = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit_Xoa = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.btnUpload = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChonFiles = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit_Xem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit_ChinhSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit_Xoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(-1, 90)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit_ChinhSua, Me.RepositoryItemButtonEdit_Xem, Me.RepositoryItemButtonEdit_Xoa})
        Me.GridControl1.Size = New System.Drawing.Size(770, 364)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tên tài liệu"
        Me.GridColumn1.FieldName = "TenTaiLieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 352
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Path"
        Me.GridColumn2.FieldName = "Path"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 284
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Xem"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemButtonEdit_Xem
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 45
        '
        'RepositoryItemButtonEdit_Xem
        '
        Me.RepositoryItemButtonEdit_Xem.AutoHeight = False
        Me.RepositoryItemButtonEdit_Xem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.RepositoryItemButtonEdit_Xem.Name = "RepositoryItemButtonEdit_Xem"
        Me.RepositoryItemButtonEdit_Xem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Chỉnh sửa"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemButtonEdit_ChinhSua
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Width = 61
        '
        'RepositoryItemButtonEdit_ChinhSua
        '
        Me.RepositoryItemButtonEdit_ChinhSua.AutoHeight = False
        Me.RepositoryItemButtonEdit_ChinhSua.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)})
        Me.RepositoryItemButtonEdit_ChinhSua.Name = "RepositoryItemButtonEdit_ChinhSua"
        Me.RepositoryItemButtonEdit_ChinhSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Xóa"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemButtonEdit_Xoa
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 39
        '
        'RepositoryItemButtonEdit_Xoa
        '
        Me.RepositoryItemButtonEdit_Xoa.AutoHeight = False
        Me.RepositoryItemButtonEdit_Xoa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.RepositoryItemButtonEdit_Xoa.Name = "RepositoryItemButtonEdit_Xoa"
        Me.RepositoryItemButtonEdit_Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ngày"
        Me.GridColumn6.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "NgayTao"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 95
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Ghi chú"
        Me.GridColumn7.FieldName = "GhiChu"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 221
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.TextEdit1)
        Me.GroupBox1.Controls.Add(Me.btnUpload)
        Me.GroupBox1.Controls.Add(Me.btnChonFiles)
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chọn tài liệu đính kèm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ghi chú"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(160, 58)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "&Thoát"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(61, 28)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(477, 20)
        Me.TextEdit1.TabIndex = 1
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(59, 58)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "&Tải lên"
        '
        'btnChonFiles
        '
        Me.btnChonFiles.Location = New System.Drawing.Point(544, 26)
        Me.btnChonFiles.Name = "btnChonFiles"
        Me.btnChonFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnChonFiles.TabIndex = 0
        Me.btnChonFiles.Text = "Chọn tài liệu"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(103, 104)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(283, 22)
        Me.txtGhiChu.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmUploadFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 453)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUploadFiles"
        Me.Text = "TÀI LIỆU ĐÍNH KÈM"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit_Xem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit_ChinhSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit_Xoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnChonFiles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnUpload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit_Xem As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit_ChinhSua As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit_Xoa As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
