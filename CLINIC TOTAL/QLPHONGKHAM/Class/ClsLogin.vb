Public Class ClsLogin
    Public strGroup As String
    Public strUsername As String
    Public strQuyen As String
    Public strHoten As String

    Private frm As New Form1
    Public Function Update(ByVal Username As String, ByVal Password As String, ByVal id As Int16, ByVal Kieu As Byte) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_Nguoisd"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterusername As New SqlClient.SqlParameter
        paraterusername.ParameterName = "@username"
        paraterusername.DbType = DbType.String
        paraterusername.Direction = ParameterDirection.Input
        paraterusername.Value = Username
        cmd.Parameters.Add(paraterusername)

        Dim paraterpassword As New SqlClient.SqlParameter
        paraterpassword.ParameterName = "@password"
        paraterpassword.DbType = DbType.String
        paraterpassword.Direction = ParameterDirection.Input
        paraterpassword.Value = Password
        cmd.Parameters.Add(paraterpassword)

        Dim paraterID As New SqlClient.SqlParameter
        paraterID.ParameterName = "@ID"
        paraterID.DbType = DbType.String
        paraterID.Direction = ParameterDirection.Input
        paraterID.Value = id
        cmd.Parameters.Add(paraterID)

        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)

        Dim paraterCheck As New SqlClient.SqlParameter
        paraterCheck.ParameterName = "@Check"
        paraterCheck.DbType = DbType.Boolean
        paraterCheck.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraterCheck)
        Try
            cmd.ExecuteNonQuery()
            Return cmd.Parameters("@Check").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try

    End Function
    Public Function UpdateGioThoat(ByVal Username As String, ByVal ID As Int16, ByVal Kieu As Byte)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_ThongKeLogin"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterUsername As New SqlClient.SqlParameter
        paraterUsername.ParameterName = "@Username"
        paraterUsername.DbType = DbType.String
        paraterUsername.Direction = ParameterDirection.Input
        paraterUsername.Value = Username
        cmd.Parameters.Add(paraterUsername)

        Dim paraterID As New SqlClient.SqlParameter
        paraterID.ParameterName = "@ID"
        paraterID.DbType = DbType.Int16
        paraterID.Direction = ParameterDirection.Input
        paraterID.Value = ID
        cmd.Parameters.Add(paraterID)

        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
    Public Function Adddnew(ByVal UserName As String, ByVal ComputerName As String, ByVal ComputerIP As String, ByVal Kieu As Byte, ByRef dtCurrDate As Date, ByRef IDGioThoat As Int16) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = openConnection()
        cmd.CommandText = "Pro_ThongKeLogin"
        cmd.CommandType = CommandType.StoredProcedure

        Dim paraterUserName As New SqlClient.SqlParameter
        paraterUserName.ParameterName = "@Username"
        paraterUserName.DbType = DbType.String
        paraterUserName.Direction = ParameterDirection.Input
        paraterUserName.Value = UserName
        cmd.Parameters.Add(paraterUserName)

        Dim paraterTen As New SqlClient.SqlParameter
        paraterTen.ParameterName = "@Computername"
        paraterTen.DbType = DbType.String
        paraterTen.Direction = ParameterDirection.Input
        paraterTen.Value = ComputerName
        cmd.Parameters.Add(paraterTen)

        Dim paraterComputerIP As New SqlClient.SqlParameter
        paraterComputerIP.ParameterName = "@ComputerIP"
        paraterComputerIP.DbType = DbType.String
        paraterComputerIP.Direction = ParameterDirection.Input
        paraterComputerIP.Value = ComputerIP
        cmd.Parameters.Add(paraterComputerIP)

        Dim paraterIDGiothoat As New SqlClient.SqlParameter
        paraterIDGiothoat.ParameterName = "@IDGiothoat"
        paraterIDGiothoat.DbType = DbType.Int16
        paraterIDGiothoat.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraterIDGiothoat)

        Dim paraterdtCurrDate As New SqlClient.SqlParameter
        paraterdtCurrDate.ParameterName = "@CurrDate"
        paraterdtCurrDate.DbType = DbType.Date
        paraterdtCurrDate.Direction = ParameterDirection.Output
        cmd.Parameters.Add(paraterdtCurrDate)

        Dim paraterKieu As New SqlClient.SqlParameter
        paraterKieu.ParameterName = "@Kieu"
        paraterKieu.DbType = DbType.Int16
        paraterKieu.Direction = ParameterDirection.Input
        paraterKieu.Value = Kieu
        cmd.Parameters.Add(paraterKieu)

        Try
            cmd.ExecuteNonQuery()
            dtCurrDate = cmd.Parameters("@CurrDate").Value
            IDGioThoat = cmd.Parameters("@IDGioThoat").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Function
    Public Sub Phan_Quyen(ByVal frm As Form)
        Dim i As Integer
        Dim j As Integer
        Dim mnu As MenuItem
        Dim mnuChild As MenuItem
        Dim mnuChilds As MenuItem
        For Each mnu In frm.Menu.MenuItems
            If mnu.MenuItems.Count > 0 Then
                For Each mnuChild In mnu.MenuItems
                    mnuChild.Visible = False
                    If mnuChild.MenuItems.Count > 0 Then
                        For Each mnuChilds In mnuChild.MenuItems
                            mnuChilds.Visible = False
                        Next
                    End If

                Next
            End If
        Next
        Dim dtvPhan_Quyen As DataView
        dtvPhan_Quyen = Get_DataView("Select * from Phan_Quyen", CNNQLPHONGKHAM)
        Dim strQuyen1 As String
        strQuyen1 = clsLoginObj.strQuyen
        Dim arrstrQuyen1(80) As String
        arrstrQuyen1 = Split(strQuyen1, ";", -1, CompareMethod.Text)
        For i = 0 To UBound(arrstrQuyen1) - 1
            dtvPhan_Quyen.Sort = "Ma_Cn"
            j = dtvPhan_Quyen.Find(arrstrQuyen1(i))
            For Each mnu In frm.Menu.MenuItems
                If mnu.MenuItems.Count > 0 Then
                    For Each mnuChild In mnu.MenuItems
                        If InStr(Trim(mnuChild.Text), Trim(dtvPhan_Quyen.Item(j)("Ten_Cnang")), CompareMethod.Text) > 0 Then
                            'mnuChild.Enabled = True
                            mnuChild.Visible = True
                        End If
                        If mnuChild.MenuItems.Count > 0 Then
                            For Each mnuChilds In mnuChild.MenuItems
                                If InStr(Trim(mnuChilds.Text), Trim(dtvPhan_Quyen.Item(j)("Ten_Cnang")), CompareMethod.Text) > 0 Then
                                    'mnuChild.Enabled = True
                                    mnuChilds.Visible = True
                                End If
                            Next
                        End If

                    Next

                End If
            Next
        Next
    End Sub

End Class
