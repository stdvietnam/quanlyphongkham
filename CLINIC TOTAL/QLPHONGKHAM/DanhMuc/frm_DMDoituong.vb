Public Class frm_DMDoituong 
    Private Flag As Boolean
    Private ID As Int16
    Public IDmoi As String
    Private dtb As DataTable
    Public Key As Boolean
    Private isload As Boolean = False

    Private Sub frmThemKhoHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        Ctrl_QuyenForm(Me)
        isload = True
    End Sub

    Private Sub LoadData()
        Dim dts As New DataSet
        dts = BusinessLogic.Data.GetDataset("SELECT id,doituong From DM_DOITUONG", CommandType.Text, Nothing, Nothing)
        Me.grv.DataSource = dts.Tables(0)
    End Sub
    Private Function Kiem_Tra() As Boolean
        Kiem_Tra = True
        If Me.txtTen.Text = "" Then
            Kiem_Tra = False
            ErrPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrPro.SetError(Me.txtTen, "Trường tên không để rỗng")
            ErrPro.SetIconAlignment(Me.txtTen, ErrorIconAlignment.MiddleRight)
        End If
    End Function
    Private Sub btnThem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Flag = True
        ID = 0
        Clear_Control(Me.Grb)
        Ctrl_Enable(Me, MdlCommon.Kieu.Them)
        isload = False
    End Sub
    Private Sub btnHuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.Grb.Enabled = False
        Ctrl_Enable(Me, MdlCommon.Kieu.Huy)
        isload = True
    End Sub
    Private Sub btnSua_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Flag = False
        Me.Grb.Enabled = True
        Ctrl_Enable(Me, MdlCommon.Kieu.Sua)
        isload = True
    End Sub
    Private Sub btnXoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim strSQL As String = ""
        If MsgBox("Xóa bản ghi đã chọn?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strSQL = "Delete DM_DOITUONG where id='" & Me.txtId.Text & "'"
            Command_Exc(strSQL, CNNQLPHONGKHAM)
            LoadData()
            isload = True
        End If
    End Sub
    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub btnCap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhat.Click
        If Kiem_Tra() = True Then
            If Flag = True Then
                Command_Exc("insert into DM_DOITUONG(doituong) values(N'" & txtTen.Text & "')", CNNQLPHONGKHAM)
            Else
                Command_Exc("Update DM_DOITUONG set doituong=N'" & txtTen.Text & "' where id=" & txtId.Text & "", CNNQLPHONGKHAM)
            End If
            LoadData()
            Ctrl_Enable(Me, MdlCommon.Kieu.Capnhat)
            Flag = False
            ErrPro.Dispose()
            Key = True
            isload = True
        End If
    End Sub
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If isload = True Then
            Dim dr As DataRow
            Dim i As Integer
            i = GridView1.FocusedRowHandle
            If i >= 0 Then
                dr = GridView1.GetDataRow(i)
                If Not dr Is Nothing Then
                    Me.txtId.Text = dr("id")
                    Me.txtTen.Text = dr("doituong")
                    ID = dr("ID")
                End If
            End If
        End If
    End Sub
End Class