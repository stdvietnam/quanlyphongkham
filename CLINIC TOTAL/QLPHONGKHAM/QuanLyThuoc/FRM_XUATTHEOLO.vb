Imports System.Data
Imports System.Data.SqlClient
Public Class FRM_XUATTHEOLO
    Inherits frmBase 'System.Windows.Forms.Form

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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Toncuoi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Dongia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Losanpham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COLGIABAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SLxuat As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_XUATTHEOLO))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Losanpham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Toncuoi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Dongia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COLGIABAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SLxuat = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(3, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(441, 271)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Losanpham, Me.Toncuoi, Me.Dongia, Me.COLGIABAN, Me.SLxuat})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Losanpham
        '
        Me.Losanpham.Caption = "lô sản phẩm"
        Me.Losanpham.FieldName = "solo"
        Me.Losanpham.Name = "Losanpham"
        Me.Losanpham.OptionsColumn.AllowEdit = False
        Me.Losanpham.Visible = True
        Me.Losanpham.VisibleIndex = 0
        Me.Losanpham.Width = 84
        '
        'Toncuoi
        '
        Me.Toncuoi.Caption = "Số lượng tồn"
        Me.Toncuoi.FieldName = "toncuoi"
        Me.Toncuoi.Name = "Toncuoi"
        Me.Toncuoi.OptionsColumn.AllowEdit = False
        Me.Toncuoi.Visible = True
        Me.Toncuoi.VisibleIndex = 1
        Me.Toncuoi.Width = 84
        '
        'Dongia
        '
        Me.Dongia.Caption = "Giá nhập"
        Me.Dongia.DisplayFormat.FormatString = "###,###"
        Me.Dongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Dongia.FieldName = "dongia"
        Me.Dongia.Name = "Dongia"
        Me.Dongia.OptionsColumn.AllowEdit = False
        Me.Dongia.Visible = True
        Me.Dongia.VisibleIndex = 2
        Me.Dongia.Width = 90
        '
        'COLGIABAN
        '
        Me.COLGIABAN.Caption = "Giá bán"
        Me.COLGIABAN.DisplayFormat.FormatString = "###,###"
        Me.COLGIABAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COLGIABAN.FieldName = "giaban"
        Me.COLGIABAN.Name = "COLGIABAN"
        Me.COLGIABAN.Visible = True
        Me.COLGIABAN.VisibleIndex = 3
        '
        'SLxuat
        '
        Me.SLxuat.Caption = "Số lượng xuất"
        Me.SLxuat.FieldName = "SLxuat"
        Me.SLxuat.Name = "SLxuat"
        Me.SLxuat.Visible = True
        Me.SLxuat.VisibleIndex = 4
        Me.SLxuat.Width = 96
        '
        'FRM_XUATTHEOLO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(447, 277)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_XUATTHEOLO"
        Me.Text = "CHỌN LÔ"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Masp, Makho As String
    Public Ngay As Date
    Public Delegate Sub PassData(ByVal Solo As String, ByVal Soluong As String, ByVal Dongia As String)
    Public _passData As PassData
    Private Sub FRM_XUATTHEOLO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Me.GridControl1.DataSource = Loaddata(Masp, Ngay, "")
        Me.GridView1.Columns.ColumnByName("SLxuat")
        Me.GridView1.FocusedColumn = Me.GridView1.Columns.ColumnByName("SLxuat")
    End Sub
    Public Function Loaddata(ByVal Masp As String, ByVal Ngay As DateTime, ByVal Solo As String) As DataTable
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CNNQLPHONGKHAM
        cmd.CommandText = "sp_Losanpham"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterMavt As New SqlClient.SqlParameter
        paraterMavt.ParameterName = "@Masp"
        paraterMavt.DbType = DbType.String
        paraterMavt.Direction = ParameterDirection.Input
        paraterMavt.Value = Masp
        cmd.Parameters.Add(paraterMavt)

        Dim paraterNgay As New SqlClient.SqlParameter
        paraterNgay.ParameterName = "@Ngay"
        paraterNgay.DbType = DbType.DateTime
        paraterNgay.Direction = ParameterDirection.Input
        paraterNgay.Value = Ngay
        cmd.Parameters.Add(paraterNgay)

        Dim paratersolo As New SqlClient.SqlParameter
        paratersolo.ParameterName = "@Solo"
        paratersolo.DbType = DbType.String
        paratersolo.Direction = ParameterDirection.Input
        paratersolo.Value = Solo
        cmd.Parameters.Add(paratersolo)

        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dt.Columns.Add("SLxuat")

        For i As Int16 = 0 To dt.Rows.Count - 1
            dt.Rows(i)("SLxuat") = 0
        Next
        'loc nhung san pham da chon
        Dim Item As Sanphamxuat
        dt.Columns.Item("SLxuat").DefaultValue = Item.Soluong
        Try
            Dim i As Int16 = 0
            If Not sp_xuat Is Nothing Then
                For Each Item In sp_xuat
                    i = 0
                    If Not Item.Masp Is Nothing Then
                        If Item.Masp = Masp Then
                            While i <= dt.Rows.Count - 1
                                If Item.Solo = dt.Rows(i)("Solo") Then
                                    If Item.Soluong = dt.Rows(i)("Toncuoi") Then
                                        dt.Rows.RemoveAt(i)
                                        i = i - 1
                                    Else
                                        dt.Rows(i)("Toncuoi") = dt.Rows(i)("Toncuoi") - Item.Soluong
                                    End If
                                End If
                                i += 1
                            End While
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
        Return dt
    End Function
    Private Sub FRM_XUATTHEOLO_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub GridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        Try
            If e.KeyCode = Keys.Enter Then
                Dim dr As DataRowView
                dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
                If Not dr Is Nothing Then
                    _passData(dr("Solo"), dr("SLxuat"), dr("Giaban"))
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim row As DataRow
        row = Me.GridView1.GetDataRow(e.RowHandle)
        If e.Column.FieldName = "SLxuat" Then
            If row("SLxuat") > row("Toncuoi") Then
                row("SLxuat") = row("Toncuoi")
            End If
        End If
        Me.GridView1.UpdateCurrentRow()
    End Sub
End Class
