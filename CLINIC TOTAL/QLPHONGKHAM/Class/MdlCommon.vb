Imports System.Data.SqlClient
Module MdlCommon
#Region "Khai bao bien"
    Public CNNQLPHONGKHAM As New SqlConnection
    Public glbManhom As String
    Public hople As Boolean
    Public CurrentDate As Date
    Public clsLoginObj As New ClsLogin
    Public IDGioThoat As Int16
    Public kiemtra As Int16
    Public SerialKey As String
    Public Machinhanh As String
    Public MADUYET As String
    Public P_Server As String
    Public P_Database As String
    Public P_Username As String
    Public P_Password As String
    Public Kieuthanhtoan As Boolean = True
    Public obj() As Donthuoc

    Public D_ngaygio As Date
#End Region
    Structure Donthuoc
        Dim Mathuoc As String
        Dim Soluong As String
        Dim Lieudung As String
    End Structure
    Enum Kieu
        Capnhat = 1
        Them = 2
        Sua = 3
        Huy = 4
    End Enum
    Enum Kieukitu
        Text = 1
        So = 2
        Ngaythang = 3
    End Enum
    Enum LoaiDV
        KHAMBENH = 1
        XETNGHIEM = 2
        SIEUAM = 3
        NOISOI = 4
        XQUANG = 5
        DIENTIM = 6
        THUTHUAT = 7
        PHAUTHUAT = 8
    End Enum

    Enum NhomDV
        THUOC = 10
        KHAMBENH = 12
        XETNGHIEM = 13
        SIEUAM = 14
        XQUANG = 15
        DIENTIM = 16
        NOISOI = 17
        TTPT = 18
        VTYT = 19
    End Enum

    Enum DoiTuong
        BHYT = 0
        DICHVU = 1
    End Enum

    Enum DanhMuc
        DM_NGHENGHIEP = 2
        DM_DANTOC = 3
        DM_QUANHE = 6
        DM_TINHTRANG_BN = 8
    End Enum

    Enum GioiTinh
        NAM = 1
        NU = 2
        KHONGXACDINH = 3
    End Enum

    Public sp_xuat() As Sanphamxuat
    Structure Sanphamxuat
        Dim Masp As String
        Dim Solo As String
        Dim Soluong As Decimal
    End Structure

    'Bien luu tru ket noi Csdl dung chung cho toan bo chuong trình
    Public Sub Main()
        'Ham duoc goi dau tien khi chuong trinh chay
        'Dim Clsonj As New clsKet_noi
        'If Clsonj.CheckSerial() = True Then
        Dim frmMain As New form1
        frmMain.ShowDialog()
        'Else
        '    MsgBox("Bạn chưa có Licence của chuơng trình")
        'End If
    End Sub
    Public Function GetNextRefNo(ByVal RefType As String) As String
        openConnection()
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "RefGetNextRefNo"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paramLoaiCT As SqlParameter = New SqlParameter("@RefType", SqlDbType.NVarChar, 8)
        paramLoaiCT.Value = RefType
        cmd.Parameters.Add(paramLoaiCT)

        Dim refNo As SqlParameter = New SqlParameter("@RefNo", SqlDbType.NVarChar, 32)
        refNo.Direction = ParameterDirection.Output
        cmd.Parameters.Add(refNo)

        Dim refNoByYear As SqlParameter = New SqlParameter("@Year", SqlDbType.Int)
        refNoByYear.Value = Today.Date.Year
        cmd.Parameters.Add(refNoByYear)

        Dim refNoByMonth As SqlParameter = New SqlParameter("@Month", SqlDbType.Int)
        refNoByMonth.Value = Today.Date.Month
        cmd.Parameters.Add(refNoByMonth)
        Try
            cmd.ExecuteNonQuery()
            Return refNo.Value.ToString()
            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
    Public Function NgayGioServer() As Date
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        Application.CurrentCulture = myCIintl
        Dim d As DateTime
        Dim strSQL As String = "select getdate()"
        Dim dt As New DataTable
        dt = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing).Tables(0)
        d = CDate(dt.Rows(0)(0)).ToString("MM/dd/yyyy hh:mm:ss tt")
        Return d
    End Function
    Public Sub Load_ComboBox(ByVal strSQL As String, ByVal Cmb As ComboBox, ByVal Cnn As SqlConnection)
        'Ham nay dung de Load du lieu cho ComboBx
        Dim dts As New DataSet
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        Cmb.DataSource = dtb
        Cmb.ValueMember = dtb.Columns(0).ColumnName
        Cmb.DisplayMember = dtb.Columns(1).ColumnName
    End Sub
    Public Sub Load_ComboBox(ByVal strSQL As String, ByVal Cmb As DevExpress.XtraEditors.LookUpEdit, ByVal Cnn As SqlConnection, Optional ByVal opt As Boolean = False)
        'Ham nay dung de Load du lieu cho LooKupEdit
        Dim dts As New DataSet
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        Cmb.Properties.DataSource = dtb
        Cmb.Properties.ValueMember = dtb.Columns(0).ColumnName
        If opt = True Then
            Cmb.Properties.DisplayMember = dtb.Columns(0).ColumnName
        Else
            Cmb.Properties.DisplayMember = dtb.Columns(1).ColumnName
        End If
    End Sub

    Public Sub Load_ComboBox(ByVal strSQL As String, ByVal Cmb As DevExpress.XtraEditors.SearchLookUpEdit, ByVal Cnn As SqlConnection, Optional ByVal opt As Boolean = False)
        Dim dts As New DataSet
        Dim dtb As New DataTable
        dtb = BusinessLogic.Data.GetDataset(strSQL).Tables(0)
        Cmb.Properties.DataSource = dtb
        Cmb.Properties.ValueMember = dtb.Columns(0).ColumnName
        If opt = True Then
            Cmb.Properties.DisplayMember = dtb.Columns(0).ColumnName
        Else
            Cmb.Properties.DisplayMember = dtb.Columns(1).ColumnName
        End If
    End Sub

    Public Sub Load_ComboBox(ByVal dt As DataTable, ByVal Cmb As DevExpress.XtraEditors.LookUpEdit, Optional ByVal opt As Boolean = False)
        Cmb.Properties.DataSource = dt
        Cmb.Properties.ValueMember = dt.Columns(0).ColumnName
        If opt = True Then
            Cmb.Properties.DisplayMember = dt.Columns(0).ColumnName
        Else
            Cmb.Properties.DisplayMember = dt.Columns(1).ColumnName
        End If
    End Sub

    Public Function Load_DataTable(ByVal strSQL As String, ByVal Cnn As SqlConnection) As DataTable
        Dim dtb As New DataTable
        Dim SqlAdp As New SqlDataAdapter(strSQL, Cnn)
        Try
            SqlAdp.Fill(dtb)
        Catch ex As Exception
            MsgBox("Có lỗi khi lấy dữ liệu ")
        End Try
        Return dtb
    End Function

    Public Sub Clear_Control(ByVal ctrl As Object)
        For Each obj As Object In ctrl.Controls
            Dim t As Type = obj.[GetType]()
            If t Is GetType(TextBox) Then
                obj.Text = ""

            ElseIf t Is GetType(RichTextBox) Then
                obj.Text = ""

            ElseIf t Is GetType(ComboBox) Then
                obj.SelectedIndex = -1

            ElseIf t Is GetType(CheckBox) Then
                obj.Checked = False

            ElseIf t Is GetType(GroupBox) Then
                Clear_Control(obj)
                Clear_Control_DevExprees(obj)
            ElseIf t Is GetType(TabControl) Then
                Clear_Control(obj)
                Clear_Control_DevExprees(obj)
            ElseIf t Is GetType(TabPage) Then
                Clear_Control(obj)
                Clear_Control_DevExprees(obj)
            End If
        Next
    End Sub

    Public Sub Clear_Control_DevExprees(ByVal ctrl As Object)
        For Each obj As Object In ctrl.Controls
            Dim t As Type = obj.[GetType]()
            If t Is GetType(DevExpress.XtraEditors.TextEdit) Then
                CType(obj, DevExpress.XtraEditors.TextEdit).Text = ""

            ElseIf t Is GetType(DevExpress.XtraEditors.DateEdit) Then
                CType(obj, DevExpress.XtraEditors.DateEdit).DateTime = NgayGioServer().Date

            ElseIf t Is GetType(DevExpress.XtraEditors.SpinEdit) Then
                CType(obj, DevExpress.XtraEditors.SpinEdit).Value = 0

            ElseIf t Is GetType(DevExpress.XtraEditors.LookUpEdit) Then
                CType(obj, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing

            ElseIf t Is GetType(DevExpress.XtraEditors.CheckEdit) Then
                CType(obj, DevExpress.XtraEditors.CheckEdit).Checked = False

            ElseIf t Is GetType(DevExpress.XtraEditors.MemoEdit) Then
                CType(obj, DevExpress.XtraEditors.MemoEdit).Text = ""

            ElseIf t Is GetType(DevExpress.XtraEditors.RichTextEdit) Then
                CType(obj, DevExpress.XtraEditors.RichTextEdit).Text = ""

            ElseIf t Is GetType(DevExpress.XtraEditors.ComboBox) Then
                CType(obj, DevExpress.XtraEditors.ComboBox).SelectedIndex = -1

            ElseIf t Is GetType(GroupBox) Then
                Clear_Control_DevExprees(obj)
            ElseIf t Is GetType(DevExpress.XtraEditors.GroupControl) Then
                Clear_Control_DevExprees(obj)
            End If
        Next
    End Sub

    Public Sub Lock_Control(ByVal ctrl As Object, ByVal Opt As Boolean)
        ' Ham nay su dung de khoa,mo khoa cac dieu khien thi them moi ban ghi(Opt=true la khoa va nguoc lai)
        Dim obj As Object
        If TypeOf (obj) Is GroupBox Then
            Lock_Control(obj, Opt)
        End If
        For Each obj In ctrl.Controls
            If TypeOf (obj) Is TextBox Then
                obj.Enabled = IIf(Opt = True, False, True)
            ElseIf TypeOf (obj) Is ComboBox Then
                obj.Enabled = IIf(Opt = True, False, True)
            ElseIf TypeOf (obj) Is CheckBox Then
                obj.Enabled = IIf(Opt = True, False, True)
            ElseIf TypeOf (obj) Is GroupBox Then
                Lock_Control(obj, Opt)
            End If
        Next
    End Sub

    Public Sub Chuan_Xau(ByRef strGoc As String)
        strGoc = Trim(strGoc)
    End Sub

    'Su dung de day du lieu vao doi tuong listview
    Public Sub LsvFill(ByVal lsv As ListView, ByVal dtb As DataTable)
        Dim int_i As Integer
        Dim int_col As Integer
        lsv.Items.Clear()
        For int_i = 0 To dtb.Rows.Count - 1
            lsv.Items.Add(dtb.Rows(int_i)(0))
            For int_col = 1 To dtb.Columns.Count - 1
                If Not IsDBNull(dtb.Rows(int_i)(int_col)) Then
                    lsv.Items(int_i).SubItems.Add(dtb.Rows(int_i)(int_col))
                Else
                    lsv.Items(int_i).SubItems.Add("")
                End If
            Next
        Next
    End Sub

    Public Sub Ctrl_Enable(ByVal frm As Form, ByVal Type As Kieu)
        Dim ctrl As Control
        Select Case Type
            Case 1 'Cap nhat
                Ctrl_QuyenForm(frm)
                MsgBox("Đã cập nhật thành công.")
            Case 2 'Them moi
                For Each ctrl In frm.Controls
                    If ctrl.Name = "btnCap_nhat" Or ctrl.Name = "btnHuy" Or ctrl.Name = "grv" Or ctrl.Name = "Grb" Or ctrl.Name = "grdDinh_khoan" Or ctrl.Name = "GroupControl1" Then
                        ctrl.Enabled = True
                    ElseIf ctrl.Name = "btnThem" Or ctrl.Name = "btnSua" Or ctrl.Name = "grv" Or ctrl.Name = "Grb" Or ctrl.Name = "grdDinh_khoan" Or ctrl.Name = "GroupControl1" Then
                        ctrl.Enabled = False
                    End If
                Next
            Case 3 'Sua
                For Each ctrl In frm.Controls
                    If ctrl.Name = "btnCap_nhat" Or ctrl.Name = "btnHuy" Or ctrl.Name = "btnThem" Or ctrl.Name = "grv" Or ctrl.Name = "Grb" Or ctrl.Name = "grdDinh_khoan" Or ctrl.Name = "GroupControl1" Then
                        ctrl.Enabled = True
                    ElseIf ctrl.Name = "btnThem" Or ctrl.Name = "btnSua" Or ctrl.Name = "Grb" Or ctrl.Name = "grdDinh_khoan" Or ctrl.Name = "GroupControl1" Then
                        ctrl.Enabled = False
                    End If
                Next
            Case 4 'Huy
                Ctrl_QuyenForm(frm)
        End Select
    End Sub

    'Dien du lieu vao Form
    Public Sub Data_Fill(ByVal frm As Form, ByVal dtb As DataTable)
        Dim int_col As Integer
        Dim ctrl As Object
        If dtb.Rows.Count > 0 Then
            For int_col = 0 To dtb.Columns.Count - 1
                For Each ctrl In frm.Controls
                    If ctrl.Tag = dtb.Columns(int_col).ColumnName Then
                        If TypeOf (ctrl) Is TextBox Then
                            ctrl.Text = dtb.Rows(0)(int_col)
                        ElseIf TypeOf (ctrl) Is ComboBox Then
                            ctrl.SelectedIndex = dtb.Rows(0)(int_col)
                        ElseIf TypeOf (ctrl) Is CheckBox Then
                            ctrl.Checked = dtb.Rows(0)(int_col)
                        ElseIf TypeOf (ctrl) Is DateTimePicker Then
                            ctrl.Value = dtb.Rows(0)(int_col)
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    Public Sub EData_Fill(ByVal grb As GroupBox, ByVal dtb As DataTable)
        'Dung cho cac dieu khien khong thuoc MS
        Dim int_col As Integer
        Dim ctrl As Object
        Dim txtEdit As DevExpress.XtraEditors.TextEdit
        Dim cmb As DevExpress.XtraEditors.LookUpEdit
        Dim dtp As DevExpress.XtraEditors.DateEdit
        If dtb.Rows.Count > 0 Then
            For int_col = 0 To dtb.Columns.Count - 1
                For Each ctrl In grb.Controls
                    If TypeOf (ctrl) Is DevExpress.XtraEditors.TextEdit Then
                        ctrl = CType(ctrl, DevExpress.XtraEditors.TextEdit)
                    ElseIf TypeOf (ctrl) Is DevExpress.XtraEditors.LookUpEdit Then
                        ctrl = CType(ctrl, DevExpress.XtraEditors.LookUpEdit)
                    ElseIf TypeOf (ctrl) Is DevExpress.XtraEditors.DateEdit Then
                        ctrl = CType(ctrl, DevExpress.XtraEditors.DateEdit)
                    End If
                    If ctrl.Tag = dtb.Columns(int_col).ColumnName Then
                        If TypeOf (ctrl) Is DevExpress.XtraEditors.TextEdit Then
                            txtEdit = CType(ctrl, DevExpress.XtraEditors.TextEdit)
                            txtEdit.EditValue = dtb.Rows(0)(int_col)
                        ElseIf TypeOf (ctrl) Is DevExpress.XtraEditors.LookUpEdit Then
                            cmb = CType(ctrl, DevExpress.XtraEditors.LookUpEdit)
                            cmb.EditValue = dtb.Rows(0)(int_col)
                        ElseIf TypeOf (ctrl) Is DevExpress.XtraEditors.DateEdit Then
                            dtp = CType(ctrl, DevExpress.XtraEditors.DateEdit)
                            dtp.EditValue = dtb.Rows(0)(int_col)
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    Public Function Command_Exc(ByVal strSQl As String, ByVal Cnn As SqlConnection) As Int16
        Try
            BusinessLogic.Data.ExecuteNonQuery(strSQl)
            Return 0
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Public Sub string_Replace(ByRef str As String)
        str = Replace(str, "'", "''", 1, Len(str), CompareMethod.Text)
    End Sub

    Function Get_DataView(ByVal strSQL As String, ByVal cnn As SqlConnection) As DataView
        Dim SqlAdp As New SqlDataAdapter(strSQL, cnn)
        Dim dtb As New DataTable
        SqlAdp.Fill(dtb)
        Return dtb.DefaultView
    End Function
    Public Sub GenSQL(ByVal strField As String, ByVal strKieu As Kieukitu, ByVal strToantu1 As String, ByVal strToantu2 As String, ByVal strValue1 As String, ByVal strValue2 As String, ByRef strSQL As String)
        Select Case strToantu1
            Case "LIKE"
                strSQL &= strField & "Like 'N%" & strValue1 & "%'" & strToantu2 & Space(1)
            Case "BETWEEN"
                Select Case strKieu
                    Case Kieukitu.So
                        strSQL &= strField & " BETWEEN" & strValue1 & " AND " & strValue2 & strToantu2 & Space(1)
                    Case Kieukitu.Ngaythang
                        strSQL &= strField & " BETWEEN '" & strValue1 & " ' AND '" & strValue2 & "'" & strToantu2 & Space(1)
                End Select
            Case Else
                Select Case strKieu
                    Case Kieukitu.So
                        strSQL &= strField & strToantu1 & strValue1 & "" & strToantu2 & Space(1)
                    Case Kieukitu.Ngaythang, Kieukitu.Text
                        strSQL &= strField & "" & strToantu1 & " '" & strValue1 & "'" & strToantu2 & Space(1)
                End Select
        End Select
    End Sub

    Public Sub Ctrl_QuyenForm(ByVal frm As Form)
        Dim dts As New DataSet
        Dim i As Int16
        Dim ctrl As Control
        For Each ctrl In frm.Controls
            If ctrl.Name = "grv" Then
                ctrl.Enabled = True
            Else
                ctrl.Enabled = False
            End If
        Next
        Dim dtbQuyenForm As New DataTable
        dts = BusinessLogic.Data.GetDataset(String.Format("Select * From Nhom_Quyen Where Ma_Nhom =N'{0}' And Ma_Cn =N'{1}'", clsLoginObj.strGroup, frm.Name))
        dtbQuyenForm = dts.Tables(0)
        If dtbQuyenForm.Rows.Count > 0 Then
            Dim StrQuyenForm As String = ""
            If Not IsDBNull(dtbQuyenForm.Rows(0)("Quyen_Form")) Then
                StrQuyenForm = dtbQuyenForm.Rows(0)("Quyen_Form")
            End If
            Dim arrQuyenForm(5) As String
            arrQuyenForm = Split(StrQuyenForm, ";", -1, CompareMethod.Text)
            For i = 0 To UBound(arrQuyenForm) - 1
                If arrQuyenForm(i) = 1 Then
                    For Each ctrl In frm.Controls
                        If ctrl.Name = "Panel_Button" Or ctrl.Name = "btnThem" Or ctrl.Name = "btnThoat" Then ctrl.Enabled = True
                    Next
                End If
                If arrQuyenForm(i) = 2 Then
                    For Each ctrl In frm.Controls
                        If ctrl.Name = "Panel_Button" Or ctrl.Name = "btnSua" Or ctrl.Name = "btnThoat" Then ctrl.Enabled = True
                    Next
                End If
                If arrQuyenForm(i) = 3 Then
                    For Each ctrl In frm.Controls
                        If ctrl.Name = "Panel_Button" Or ctrl.Name = "btnXoa" Or ctrl.Name = "btnThoat" Then ctrl.Enabled = True
                    Next
                End If
                If arrQuyenForm(i) = 4 Then
                    For Each ctrl In frm.Controls
                        If ctrl.Name = "Panel_Button" Or ctrl.Name = "btnThem" Or ctrl.Name = "btnSua" Or ctrl.Name = "btnXoa" Or ctrl.Name = "btnThoat" Then
                            ctrl.Enabled = True
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Public Function DoiSo(ByVal x As String) As String 'Doi toan bo chuoi so thanh chu
        Dim Donvi() As String = {"", "nghìn ", "triệu ", "tỷ ", "nghìn ", "triệu ", "tỷ "}
        Dim so As String
        Dim chuoi As String = ""
        Dim temp As String
        Dim ID As Byte
        'Dim sochan As Boolean
        Dim i As Integer
        'Loai bo nhung so 0 tren dau day so (VD: 00123 -> 123)
        Do While (Mid(x, 1, 1) = "0") Or ((Mid(x, 1, 1) = "-"))
            x = Right(x, Len(x) - 1)
        Loop
        If Len(x) > 21 Then
            MsgBox("Số quá lớn", vbCritical)
            Exit Function
        End If
        'Neu bang 0 thoat ra luon
        If Val(x) = 0 Then Exit Function
        'Neu tat ca cac so dung sau con so dau tien deu la 0 thi la so (tie^`n) chan
        'If Right(x, Len(x) - 1) = 0 Or Len(x) = 1 Then sochan = True
        Do While (x <> "")
            If Len(x) <> 0 Then
                so = Lay3So(x)
                x = Mid(x, 1, Len(x) - Len(so))
                On Error Resume Next
                temp = Tinh3So(so)
                so = temp
                If so <> "" Then
                    temp = temp + Donvi(ID)
                    chuoi = temp + chuoi
                Else 'So=""
                    If ID = 3 Then
                        chuoi = temp + "tỷ " + chuoi
                    End If
                End If
                ID = ID + 1
            End If
        Loop
        'Doi ky tu dau tien cua chuoi ra chu hoa
        chuoi = UCase(Mid(chuoi, 1, 1)) + Mid(chuoi, 2, Len(chuoi))
        chuoi = chuoi + " đồng"
        DoiSo = Trim(chuoi)
    End Function
    Public Function DoiSoVND(ByVal x As String) As String 'Doi toan bo chuoi so thanh chu và đọc theo VNĐ
        Dim Donvi() As String = {"", "nghìn ", "triệu ", "tỷ ", "nghìn ", "triệu ", "tỷ "}
        Dim so As String
        Dim chuoi As String
        Dim temp As String
        Dim ID As Byte
        'Dim sochan As Boolean
        Dim i As Integer
        'Loai bo nhung so 0 tren dau day so (VD: 00123 -> 123)
        Do While (Mid(x, 1, 1) = "0") Or ((Mid(x, 1, 1) = "-"))
            x = Right(x, Len(x) - 1)
        Loop
        If Len(x) > 21 Then
            MsgBox("Số quá lớn", vbCritical)
            Exit Function
        End If
        'Neu bang 0 thoat ra luon
        If Val(x) = 0 Then Exit Function
        'Neu tat ca cac so dung sau con so dau tien deu la 0 thi la so (tie^`n) chan
        'If Right(x, Len(x) - 1) = 0 Or Len(x) = 1 Then sochan = True
        Do While (x <> "")
            If Len(x) <> 0 Then
                so = Lay3So(x)
                x = Mid(x, 1, Len(x) - Len(so))
                On Error Resume Next
                temp = Tinh3So(so)
                so = temp
                If so <> "" Then
                    temp = temp + Donvi(ID)
                    chuoi = temp + chuoi
                Else 'So=""
                    If ID = 3 Then
                        chuoi = temp + "tỷ " + chuoi
                    End If
                End If
                ID = ID + 1
            End If
        Loop
        'Doi ky tu dau tien cua chuoi ra chu hoa
        chuoi = UCase(Mid(chuoi, 1, 1)) + Mid(chuoi, 2, Len(chuoi))
        chuoi = chuoi + " đồng"
        DoiSoVND = Trim(chuoi)
    End Function
    Public Function Lay3So(ByVal x As String) As String 'Tach chuoi so thanh tung nhom 3 ky tu
        Dim so As String
        If Len(x) >= 3 Then
            so = Mid(x, Len(x) - 2, 3)
        Else
            so = Mid(x, 1, Len(x))
        End If
        Lay3So = so
    End Function
    Public Function Tinh3So(ByVal x As String) As String 'Chuyen 3 ky tu so da lay duoc thanh chu
        Dim chuoi As String
        Dim temp As String
        Dim flag0, flag1 As Boolean
        temp = x
        Dim KySo() As String = {"không ", "một ", "hai ", "ba ", "bốn ", "năm ", "sáu ", "bảy ", "tám ", "chín "}
        'Neu bang khong, thoat ra luon
        If x = "000" Then
            Tinh3So = ""
            GoTo End1
        End If
        'Xet hang tram
        If Len(x) = 3 Then
            chuoi = KySo(Mid(x, 1, 1)) + "trăm "
            x = Mid(x, Len(x) - 1, 2)
        End If
        'Xet hang chuc
        If Len(x) = 2 And x <> "00" Then
            Select Case Mid(x, 1, 1)
                Case 0 : chuoi = chuoi + "linh" & " "
                    flag0 = True
                Case 1 : chuoi = chuoi + "mười "
                    flag1 = True
                Case Else : chuoi = chuoi + KySo(Mid(x, 1, 1)) + "mươi "
            End Select
            x = Mid(x, Len(x), 1)
        End If
        'Xet hang don vi
        Select Case x
            Case 1
                If Not flag0 And Not flag1 And Len(temp) > 1 Then
                    chuoi = chuoi + "mốt "
                Else
                    chuoi = chuoi + "một "
                End If
            Case 5
                If flag0 Or Len(temp) = 1 Then chuoi = chuoi + "năm "
                If flag1 Then chuoi = chuoi + "lăm "
                If Not flag0 And Not flag1 And Len(temp) > 1 Then chuoi = chuoi + "lăm "
            Case 4
                If Not flag1 And Not flag0 And Len(chuoi) > 1 Then
                    chuoi = chuoi + "tư "
                Else
                    chuoi = chuoi + "bốn "
                End If
            Case Else
                If (Len(temp) <= 2 And x <> 0) Or (Len(temp) = 3 And x <> 0) Then chuoi = chuoi + KySo(Mid(x, 1, 1))
        End Select
        Tinh3So = chuoi
End1:
    End Function

    Public Function Chuanhoa(ByVal strXau As String) As String
        Return Replace(strXau, ",", "")
    End Function

    Public Function CheckRowExist(ByVal dtb As DataTable, ByVal FieldName As String, ByVal strValue As String) As Boolean
        Dim i As Integer
        If dtb.Rows.Count > 0 Then
            For i = 0 To dtb.Rows.Count - 1
                If dtb.Rows(i)(FieldName) = strValue Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function
    Public Function GetRowPos(ByVal dtv As DataView, ByVal FieldName As String, ByVal strValue As String) As Integer
        Dim pos As Integer
        Dim obj As Object
        obj = strValue
        dtv.Sort = FieldName
        pos = dtv.Find(obj)
        Return pos
    End Function

    Public Sub GenUpdateSQL(ByVal TenBang As String, ByVal IDSophieu As Int16, ByVal blnType As Boolean, ByVal Grb As GroupBox) 'Function
        Dim obj As Object
        Dim dtv As New DataView
        Dim strSQL As String = ""
        Dim strSQLVALUE As String = ""
        Dim dtbDsTruong As DataTable
        strSQL = "SELECT TenBang,TenTruong,TenHT,KieuDL,Dodai,[Null] FROM DStruong WHERE TenBang='" & TenBang & "'"
        dtbDsTruong = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing).Tables(0)
        If blnType = True Then
            strSQL = "UPDATE " & TenBang & " SET "
        Else
            strSQL = "INSERT INTO " & TenBang & "("
            strSQLVALUE = "VALUES("
        End If
        For Each obj In Grb.Controls
            If obj.tag <> "" Then
                dtv = dtbDsTruong.DefaultView
                dtv.RowFilter = "TenTruong='" & obj.Tag & "'"
                If TypeOf (obj) Is DevExpress.XtraEditors.DateEdit Then
                    If blnType = True Then
                        strSQL &= obj.Tag & "='" & obj.EditValue & "'" & ","
                    Else
                        strSQL &= obj.Tag & ","
                        strSQLVALUE &= "'" & Format(obj.EditValue, "MM/dd/yyyy") & "'" & ","
                    End If
                ElseIf TypeOf (obj) Is DevExpress.XtraEditors.LookUpEdit Then
                    If blnType = True Then
                        If dtv(0)("KieuDL") = "C" Then
                            strSQL &= obj.Tag & "='" & obj.EditValue & "'" & ","
                        ElseIf dtv(0)("KieuDL") = "N" Then
                            strSQL &= obj.Tag & "=" & obj.EditValue & "" & ","
                        End If
                    Else
                        strSQL &= obj.Tag & ","
                        If dtv(0)("KieuDL") = "C" Then
                            strSQLVALUE &= "'" & obj.EditValue & "'" & ","
                        ElseIf dtv(0)("KieuDL") = "N" Then
                            strSQLVALUE &= "" & obj.EditValue & "" & ","
                        End If
                    End If
                ElseIf TypeOf (obj) Is DevExpress.XtraEditors.TextEdit Then
                    If blnType = True Then
                        If dtv(0)("KieuDL") = "C" Then
                            strSQL &= obj.Tag & "='" & obj.EditValue & "'" & ","
                        ElseIf dtv(0)("KieuDL") = "N" Then
                            strSQL &= obj.Tag & "=" & obj.EditValue & "" & ","
                        End If
                    Else
                        strSQL &= obj.Tag & ","
                        If dtv(0)("KieuDL") = "C" Then
                            strSQLVALUE &= "'" & obj.EditValue & "'" & ","
                        ElseIf dtv(0)("KieuDL") = "N" Then
                            strSQLVALUE &= "" & obj.EditValue & "" & ","
                        End If
                    End If
                End If
            End If
        Next
        If blnType = False Then
            If (Len(strSQL) > 0) Then
                strSQL = Mid(strSQL, 1, Len(strSQL) - 1)
                strSQL &= ")"
            End If
            If (Len(strSQLVALUE) > 0) Then
                strSQLVALUE = Mid(strSQLVALUE, 1, Len(strSQLVALUE) - 1)
                strSQLVALUE &= ")"
            End If
            strSQL &= strSQLVALUE
        Else
            strSQL = Mid(strSQL, 1, Len(strSQL) - 1)
            strSQL &= " WHERE  ID= " & IDSophieu & ""
        End If
        Command_Exc(strSQL, CNNQLPHONGKHAM)
    End Sub

    Public Sub HTDTDunoUpdate(ByVal DtpNgay As DevExpress.XtraEditors.DateEdit)
        Dim strSQL As String
        strSQL = "Update Hach_toan_von_DN Set Vonduno=(SELECT isnull((SELECT Sum(Quydoi)FROM Phieu_xuat_nhap WHERE   Loaiphieu=0 AND Huy =0 ),0) +"
        strSQL &= "isnull((SELECT Sum(Quydoi)FROM Phieu_thu_chi WHERE  phieu_thu_chi.Madv <> '253 ' AND Loaiphieu=0  AND Huy=0 ),0)-"
        strSQL &= "isnull((SELECT Sum(Quydoi)FROM Phieu_thu_chi WHERE   phieu_thu_chi.Madv <> '253 ' AND  Loaiphieu=1  AND Huy=0 ),0)-"
        strSQL &= "isnull((SELECT Sum(Quydoi)FROM Phieu_xuat_nhap  WHERE   Loaiphieu=1  AND  Huy=0 ),0) as Duno) WHERE Convert(nvarchar(10),Ngay,101)='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "' "
        Command_Exc(strSQL, CNNQLPHONGKHAM)
        strSQL &= "Update Hach_toan_von_DN set Vonbangtien=(select sum(ToncuoiVND)/(select Top 1 Tygia FROM Hach_toan_von_DN WHERE Convert(nvarchar(10),Ngay,101)='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "') "
        strSQL &= "+ sum(ToncuoiUSD) as Tonquy from ton_quy WHERE Convert(nvarchar(10),Ngay,101)='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "') WHERE Convert(nvarchar(10),Ngay,101)='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "'"
        Command_Exc(strSQL, CNNQLPHONGKHAM)
        strSQL = "Update Hach_toan_von_DN Set Vonhangton=(SELECT Sum(Toncuoi* DonGia)From Ton_kho where left(masp,2)<>'00') WHERE Convert(nvarchar(10),Ngay,101)='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "'"
        Command_Exc(strSQL, CNNQLPHONGKHAM)
    End Sub
    Public Sub InsertHTVDN_XN(ByVal DtpNgay As DevExpress.XtraEditors.DateEdit)
        Dim strSQL As String
        strSQL = "IF NOT EXISTS (SELECT *  FROM Hach_toan_von_DN WHERE Convert(char(10),Ngay,101)='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "') BEGIN INSERT INTO Hach_toan_von_DN(Ngay,Vonbangtien,Vonhangton,Vonduno,Voncodinh,Tygia) "
        strSQL &= "SELECT '" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "',Vonbangtien,Vonhangton,Vonduno,Voncodinh, "
        strSQL &= "(select tygia from phieu_xuat_nhap where  ngay='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "' and idPhieuxn=(SELECT MAX(idPhieuxn) FROM phieu_xuat_nhap)) "
        strSQL &= "FROM Hach_toan_von_DN WHERE ID = (SELECT MAX(ID) FROM Hach_toan_von_DN)END"
        Command_Exc(strSQL, CNNQLPHONGKHAM)
    End Sub
    Public Sub InsertHTVDN_TC(ByVal DtpNgay As DevExpress.XtraEditors.DateEdit)
        Dim strSQL As String
        strSQL = "IF NOT EXISTS (SELECT *  FROM Hach_toan_von_DN WHERE Convert(char(10),Ngay,101)='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "') BEGIN INSERT INTO Hach_toan_von_DN(Ngay,Vonbangtien,Vonhangton,Vonduno,Voncodinh,Tygia) "
        strSQL &= "SELECT '" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "',Vonbangtien,Vonhangton,Vonduno,Voncodinh, "
        strSQL &= "(select tygia from phieu_thu_chi where  ngay='" & Format(DtpNgay.EditValue, "MM/dd/yyyy") & "' and idsophieu=(SELECT MAX(idsophieu) FROM phieu_thu_chi))"
        strSQL &= "FROM Hach_toan_von_DN WHERE ID = (SELECT MAX(ID) FROM Hach_toan_von_DN)END"
        Command_Exc(strSQL, CNNQLPHONGKHAM)
    End Sub
    Public Function CheckValid(ByVal ErrorProvider1 As ErrorProvider, ByVal TenBang As String, ByVal Grb As GroupBox) As Boolean
        Dim obj As Object
        Dim dtv As New DataView
        Dim strSQL As String
        Dim dtbDsTruong As DataTable
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        strSQL = "SELECT TenBang,TenTruong,TenHT,KieuDL,Dodai,[Null] FROM DStruong WHERE TenBang='" & TenBang & "'"
        dtbDsTruong = BusinessLogic.Data.GetDataset(strSQL, CommandType.Text, Nothing, Nothing).Tables(0)
        CheckValid = True
        ErrorProvider1.Dispose()
        For Each obj In Grb.Controls
            If obj.tag <> "" Then
                dtv = dtbDsTruong.DefaultView
                dtv.RowFilter = "TenTruong='" & obj.Tag & "'"
                If TypeOf (obj) Is DevExpress.XtraEditors.DateEdit Then
                    If dtv(0)("KieuDL") = "N" Then
                        If Not IsNumeric(obj.EditValue) Then
                            ErrorProvider1.SetError(obj, "Dữ liệu phải là kiểu số")
                            CheckValid = False
                        End If
                    End If
                    If dtv(0)("Null") = False Then
                        If Not IsDate(obj.EditValue) Then
                            ErrorProvider1.SetError(obj, "Dữ liệu không để trống")
                            CheckValid = False
                        End If
                    End If
                ElseIf TypeOf (obj) Is DevExpress.XtraEditors.LookUpEdit Then
                    If dtv(0)("KieuDL") = "N" Then
                        If Not IsNumeric(obj.EditValue) Then
                            ErrorProvider1.SetError(obj, "Dữ liệu phải là kiểu số")
                            CheckValid = False
                        End If
                    End If
                    If dtv(0)("Null") = False Then
                        If obj.EditValue = "" Then
                            ErrorProvider1.SetError(obj, "Dữ liệu không để trống")
                            CheckValid = False
                        End If
                    End If
                ElseIf TypeOf (obj) Is DevExpress.XtraEditors.TextEdit Then
                    If dtv(0)("KieuDL") = "N" Then
                        If Not IsNumeric(obj.EditValue) Then
                            ErrorProvider1.SetError(obj, "Dữ liệu phải là kiểu số")
                            CheckValid = False
                        End If
                    End If
                    If dtv(0)("Null") = False Then
                        If Not IsNumeric(obj.EditValuE) Then
                            If obj.EditValuE = "" Then
                                ErrorProvider1.SetError(obj, "Dữ liệu không để trống")
                                CheckValid = False
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Function
    Public Sub Clearndata(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                Clearndata(c)
            ElseIf TypeOf c Is TextBox Then
                CType(c, TextBox).Text = ""
            End If
            If TypeOf c Is ComboBox Then
                CType(c, ComboBox).SelectedIndex = 0
            End If
            If TypeOf c Is CheckBox Then
                CType(c, CheckBox).Checked = False
            End If
        Next
    End Sub
    Public Function ChuanHoaChuoi(ByVal s As String) As String
        If s = "" Then
        Else
            s = s.Trim()
            While (s.IndexOf("  ")) > -1
                s = s.Replace("  ", " ")
            End While
            Dim a() As String = Split(s.ToString, " ")
            Dim t As String = ""
            For i As Integer = 0 To UBound(a)
                t = t & UCase(a(i).Substring(0, 1)) & LCase(a(i).Substring(1, a(i).Length - 1)) & " "
            Next
            s = t
        End If
        Return s
    End Function
    Public Function openConnection() As SqlConnection
        If CNNQLPHONGKHAM.State = ConnectionState.Closed Or CNNQLPHONGKHAM.State = ConnectionState.Broken Then
            CNNQLPHONGKHAM.Open()
        End If
        Return CNNQLPHONGKHAM
    End Function
    Public Function closeConnection() As SqlConnection
        If CNNQLPHONGKHAM.State = ConnectionState.Open Or CNNQLPHONGKHAM.State = ConnectionState.Connecting Then
            CNNQLPHONGKHAM.Close()
        End If
        Return CNNQLPHONGKHAM
    End Function
    Public Function Execute_Query(ByVal _query As String, ByVal ct As CommandType, ByVal mysqlParameter() As SqlParameter) As Boolean
        Dim bo As Boolean
        Dim myAdapter As New SqlDataAdapter()
        Dim myCommand As New SqlCommand()
        Try
            myCommand.Connection = openConnection()
            myCommand.CommandText = _query
            myCommand.CommandType = ct
            If mysqlParameter IsNot Nothing Then ' Neu khong co dieu kien/bien dau vao ->nothing;
                myCommand.Parameters.AddRange(mysqlParameter)
            End If
            myAdapter.InsertCommand = myCommand
            myCommand.ExecuteNonQuery()
            closeConnection()
            bo = True
        Catch ex As Exception
            bo = False
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
        Return bo
    End Function
    Public Sub Load_Cmb(ByVal dt As DataTable, ByVal cmb As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit, ByVal ValueMeber As String, ByVal DisplayMeber As String)
        cmb.DataSource = dt
        cmb.DisplayMember = DisplayMeber
        cmb.ValueMember = ValueMeber
    End Sub
    Public Sub Load_Cmb(ByVal dt As DataTable, ByVal cmb As DevExpress.XtraEditors.SearchLookUpEdit, ByVal ValueMeber As String, ByVal DisplayMeber As String)
        cmb.Properties.DataSource = dt
        cmb.Properties.DisplayMember = DisplayMeber
        cmb.Properties.ValueMember = ValueMeber
    End Sub
    Public Sub Load_Comb(ByVal dt As DataTable, ByVal cmb As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal ValueMeber As String, ByVal DisplayMeber As String)
        cmb.DataSource = dt
        cmb.DisplayMember = DisplayMeber
        cmb.ValueMember = ValueMeber
    End Sub
    Public Sub Load_Comb(ByVal dt As DataTable, ByVal cmb As DevExpress.XtraEditors.LookUpEdit, ByVal ValueMeber As String, ByVal DisplayMeber As String)
        cmb.Properties.DataSource = dt
        cmb.Properties.DisplayMember = DisplayMeber
        cmb.Properties.ValueMember = ValueMeber
    End Sub

    Public Function TinhThangTuoi(ByVal NgaySinh As DateTime, ByVal MucTuoiTinhThang As Integer) As String
        Dim lTotal As Long = DateTime.Now.Date.Ticks - NgaySinh.Ticks
        Dim d As DateTime = New DateTime(lTotal)
        Dim thangtuoi As String = ""
        If Not NgaySinh.ToString("dd/MM/yyyy").Equals("01/01/0001") Then
            If d.Year - 1 <= MucTuoiTinhThang Then
                thangtuoi = (d.Month + (d.Year - 1) * 12).ToString("00") + " tháng"
            Else
                thangtuoi = (d.Year - 1).ToString("00") + " tuổi"
            End If
        End If
        Return thangtuoi
    End Function
End Module
