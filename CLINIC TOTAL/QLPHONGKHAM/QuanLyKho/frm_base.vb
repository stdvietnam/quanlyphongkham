Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Collections.Generic

Public Class Clinic_Gridcolumn
    Private _FieldName As String
    Public Property FieldName As String
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property

    Private _Caption As String
    Public Property Caption As String
        Get
            Return _Caption
        End Get
        Set(ByVal value As String)
            _Caption = value
        End Set
    End Property

    Private _Type As String
    Public Property Type As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property

    Private _VisibleIndex As Integer
    Public Property VisibleIndex As Integer
        Get
            Return _VisibleIndex
        End Get
        Set(ByVal value As Integer)
            _VisibleIndex = value
        End Set
    End Property

    Private _Width As Integer
    Public Property Width As Integer
        Get
            Return _Width
        End Get
        Set(ByVal value As Integer)
            _Width = value
        End Set
    End Property

    Private _AllowEdit As Boolean
    Public Property AllowEdit As Boolean
        Get
            Return _AllowEdit
        End Get
        Set(ByVal value As Boolean)
            _AllowEdit = value
        End Set
    End Property

    Public Sub New(ByVal fieldName As String, ByVal caption As String, ByVal type As String, ByVal visibleIndex As Integer, ByVal width As Integer, ByVal allowEdit As Boolean)
        _FieldName = fieldName
        _Caption = caption
        _Type = type
        _VisibleIndex = visibleIndex
        _Width = width
        _AllowEdit = allowEdit
    End Sub
End Class

Public Class frm_base

    Public isAddNew As Boolean = True
    Public rowEdit As DataRow = Nothing
    Public b_lock As Boolean = False
    Public is_Change As Boolean = False

    Private Sub frm_base_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl
        setLableAll()
    End Sub

    Public Sub setLableAll()
        For Each ctr As Control In Me.Controls
            setLable(ctr)
        Next
    End Sub

    Protected Sub setLable(ByVal ctr As Control)
        Dim t As Type = ctr.[GetType]()
        If t Is GetType(System.Windows.Forms.GroupBox) Then
            For Each ctls As Control In ctr.Controls
                setLable(ctls)
            Next
        ElseIf t Is GetType(DevExpress.XtraTab.XtraTabControl) Then
            For Each tab As DevExpress.XtraTab.XtraTabPage In DirectCast(ctr, DevExpress.XtraTab.XtraTabControl).TabPages
                For Each ctls As Control In tab.Controls
                    setLable(ctls)
                Next
            Next
        ElseIf t Is GetType(DevExpress.XtraEditors.GroupControl) Then
            For Each ctls As Control In ctr.Controls
                setLable(ctls)
            Next
        ElseIf t Is GetType(DevExpress.XtraEditors.TimeEdit) Then
            DirectCast(ctr, DevExpress.XtraEditors.TimeEdit).EditValue = Nothing
        ElseIf t Is GetType(DevExpress.XtraGrid.GridControl) Then
            For Each Item As DevExpress.XtraEditors.Repository.RepositoryItem In DirectCast(ctr, DevExpress.XtraGrid.GridControl).RepositoryItems
                If Item.[GetType]() Is GetType(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit) Then
                    DirectCast(Item, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).NullText = String.Empty
                ElseIf Item.[GetType]() Is GetType(DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit) Then
                    DirectCast(Item, DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit).NullText = String.Empty
                End If
            Next
        ElseIf t Is GetType(DevExpress.XtraEditors.LookUpEdit) Then
            DirectCast(ctr, DevExpress.XtraEditors.LookUpEdit).Properties.NullText = String.Empty
            DirectCast(ctr, DevExpress.XtraEditors.LookUpEdit).Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        ElseIf t Is GetType(DevExpress.XtraEditors.SearchLookUpEdit) Then
            DirectCast(ctr, DevExpress.XtraEditors.SearchLookUpEdit).Properties.NullText = String.Empty
        ElseIf t Is GetType(DevExpress.XtraEditors.GridLookUpEdit) Then
            DirectCast(ctr, DevExpress.XtraEditors.GridLookUpEdit).Properties.NullText = String.Empty
        ElseIf t Is GetType(DevExpress.XtraEditors.DateEdit) Then
            DirectCast(ctr, DevExpress.XtraEditors.DateEdit).Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
            DirectCast(ctr, DevExpress.XtraEditors.DateEdit).Properties.EditFormat.FormatString = "dd/MM/yyyy"
            DirectCast(ctr, DevExpress.XtraEditors.DateEdit).Properties.Mask.EditMask = "dd/MM/yyyy"
        End If
    End Sub

    Public Sub CreateColumnGridview(ByVal gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Lcolums As List(Of Clinic_Gridcolumn))
        gridview.OptionsView.ColumnAutoWidth = False
        gridview.Columns.Clear()
        gridview.GroupSummary.Clear()
        gridview.SortInfo.Clear()
        For Each col As Clinic_Gridcolumn In Lcolums
            Dim gridColumn As DevExpress.XtraGrid.Columns.GridColumn = gridview.Columns.Add()
            gridColumn.OptionsColumn.AllowEdit = False
            gridColumn.FieldName = col.FieldName
            gridColumn.Caption = col.Caption
            gridColumn.VisibleIndex = col.VisibleIndex
            gridColumn.Width = col.Width
            If (col.Type.ToLower() = "date") Then
                gridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                gridColumn.DisplayFormat.FormatString = "dd/MM/yyyy"
            ElseIf (col.Type.ToLower() = "datetime") Then
                gridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                gridColumn.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"
            ElseIf (col.Type.ToLower() = "int") Then
                gridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                gridColumn.DisplayFormat.FormatString = "###,###"
            ElseIf (col.Type.ToLower() = "float") Then
                gridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                gridColumn.DisplayFormat.FormatString = "###,###.00"
            Else

            End If
        Next
    End Sub

End Class