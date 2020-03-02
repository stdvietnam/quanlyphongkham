<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hosobnchitiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_hosobnchitiet))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltenfile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfiledata = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdfile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colload = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colxoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnCap_nhat = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(1, 46)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2, Me.RepositoryItemButtonEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(624, 306)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTitle, Me.coltenfile, Me.colfiledata, Me.colsize, Me.coladdfile, Me.colload, Me.colxoa})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colTitle
        '
        Me.colTitle.Caption = "Tiêu đề"
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 0
        Me.colTitle.Width = 103
        '
        'coltenfile
        '
        Me.coltenfile.Caption = "Tên file"
        Me.coltenfile.FieldName = "FileName"
        Me.coltenfile.Name = "coltenfile"
        Me.coltenfile.OptionsColumn.AllowEdit = False
        Me.coltenfile.OptionsColumn.AllowFocus = False
        Me.coltenfile.Visible = True
        Me.coltenfile.VisibleIndex = 1
        Me.coltenfile.Width = 177
        '
        'colfiledata
        '
        Me.colfiledata.Caption = "Nội dung"
        Me.colfiledata.FieldName = "FileData"
        Me.colfiledata.Name = "colfiledata"
        Me.colfiledata.OptionsColumn.AllowEdit = False
        Me.colfiledata.OptionsColumn.AllowFocus = False
        Me.colfiledata.Visible = True
        Me.colfiledata.VisibleIndex = 2
        Me.colfiledata.Width = 41
        '
        'colsize
        '
        Me.colsize.Caption = "ID"
        Me.colsize.FieldName = "ID"
        Me.colsize.Name = "colsize"
        Me.colsize.Visible = True
        Me.colsize.VisibleIndex = 3
        Me.colsize.Width = 50
        '
        'coladdfile
        '
        Me.coladdfile.Caption = "Add"
        Me.coladdfile.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.coladdfile.FieldName = "Add"
        Me.coladdfile.Name = "coladdfile"
        Me.coladdfile.Visible = True
        Me.coladdfile.VisibleIndex = 4
        Me.coladdfile.Width = 51
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'colload
        '
        Me.colload.Caption = "Hiển thị"
        Me.colload.ColumnEdit = Me.RepositoryItemButtonEdit2
        Me.colload.FieldName = "Load"
        Me.colload.Name = "colload"
        Me.colload.Visible = True
        Me.colload.VisibleIndex = 5
        Me.colload.Width = 49
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'colxoa
        '
        Me.colxoa.Caption = "Xóa"
        Me.colxoa.ColumnEdit = Me.RepositoryItemButtonEdit3
        Me.colxoa.FieldName = "Xoa"
        Me.colxoa.Name = "colxoa"
        Me.colxoa.Visible = True
        Me.colxoa.VisibleIndex = 6
        Me.colxoa.Width = 46
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        '
        'btnCap_nhat
        '
        Me.btnCap_nhat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCap_nhat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCap_nhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCap_nhat.Appearance.Options.UseFont = True
        Me.btnCap_nhat.Appearance.Options.UseForeColor = True
        Me.btnCap_nhat.Location = New System.Drawing.Point(544, 370)
        Me.btnCap_nhat.Name = "btnCap_nhat"
        Me.btnCap_nhat.Size = New System.Drawing.Size(75, 25)
        Me.btnCap_nhat.TabIndex = 5
        Me.btnCap_nhat.Text = "&Thoát"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(223, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(158, 23)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "HỒ SƠ CHI TIẾT"
        '
        'frm_hosobnchitiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(631, 407)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnCap_nhat)
        Me.Controls.Add(Me.GridControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_hosobnchitiet"
        Me.Text = "HỒ SƠ CHI TIẾT"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltenfile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfiledata As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdfile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colload As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCap_nhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colxoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
