Public Class Clskhoa
    Public Function Addnew(ByVal MaKhoa As String, ByVal TenKhoa As String, ByVal GhiChu As String) As Boolean
        Dim sql As String = "insert into Tb_DMKHOA(MaKhoa,TenKhoa,GhiChu) values (N'" & MaKhoa & "',N'" & TenKhoa & "',N'" & GhiChu & "')"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Function

    Public Function Update(ByVal MaKhoa As String, ByVal TenKhoa As String, ByVal GhiChu As String, ByVal ID As Integer) As Boolean
        Dim sql As String = " Update Tb_DMKHOA set MaKhoa=N'" & MaKhoa & "',TenKhoa = N'" & TenKhoa & "',GhiChu = N'" & GhiChu & "'where ID ='" & ID & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Function

    Public Function Delete(ByVal ID As Integer) As Boolean
        Dim sql As String = "delete  from Tb_DMKHOA where ID = '" & ID & "'"
        Command_Exc(sql, CNNQLPHONGKHAM)
    End Function
End Class
