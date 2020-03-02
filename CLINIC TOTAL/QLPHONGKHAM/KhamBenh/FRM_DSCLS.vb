Imports System.Collections.Generic

Public Class FRM_DSCLS
    Public IDchitiet As String = ""
    Public tongtien As Double
    Private Sub btnHuy_Dichvu_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnHuy_Dichvu.ButtonClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        If Not dr Is Nothing Then
            If Me.GridView1.FocusedRowHandle <> -999999 Then
                If radDichvulam.Checked = True Then
                    If MsgBox("Bạn có muốn xoá dịch vụ này?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Command_Exc("Update Chi_tiet_NEW Set Huy=1 Where ID=" & dr("ID") & "", CNNQLPHONGKHAM)
                    End If
                End If
                If radDichvuhuy.Checked = True Then
                    If MsgBox("Bạn có muốn lấy lại dịch vụ này?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Command_Exc("Update Chi_tiet_NEW Set Huy=0 Where ID=" & dr("ID") & "", CNNQLPHONGKHAM)
                    End If
                End If
                Load_Info()
            End If
        End If
    End Sub

    Private Sub btnNaplai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNaplai.Click
        Load_Info()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim FRM As New frmShowReport
        FRM.strBC = frmShowReport.TenBc.DanhSach
        FRM.IDchitiet = IDchitiet
        Dim dt As New DataTable
        If chk_intheophong.Checked = False Then
            dt = BusinessLogic.Data.GetDataset("BC_DSCLS", Data.CommandType.StoredProcedure, New List(Of String) From {"IDsophieu", "Maphong"}, New List(Of Object) From {IDchitiet, ""}).Tables(0)
        Else
            Dim dr As DataRowView
            dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
            dt = BusinessLogic.Data.GetDataset("BC_DSCLS", Data.CommandType.StoredProcedure, New List(Of String) From {"IDsophieu", "Maphong"}, New List(Of Object) From {IDchitiet, dr("MaPhong").ToString()}).Tables(0)
        End If
        FRM.dtb = dt
        FRM.Show()
    End Sub

    Private Sub Load_Info()
        Dim Sql As String = ""
        Dim dt As DataTable = New DataTable()

        If radDichvulam.Checked = True Then
            dt = BusinessLogic.Data.GetDataset("DS_DICHVUCLS_DAKE", CommandType.StoredProcedure, New List(Of String) From {"IDSophieu", "Huy"}, New List(Of Object) From {IDchitiet, True}).Tables(0)
        End If
        If radDichvuhuy.Checked = True Then
            dt = BusinessLogic.Data.GetDataset("DS_DICHVUCLS_DAKE", CommandType.StoredProcedure, New List(Of String) From {"IDSophieu", "Huy"}, New List(Of Object) From {IDchitiet, False}).Tables(0)
        End If

        Grid_DSCLS.DataSource = dt
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub FRM_DSCLS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        radDichvulam.Checked = True
        Load_Info()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub radDichvulam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDichvulam.Click
        Load_Info()
    End Sub

    Private Sub radDichvuhuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDichvuhuy.CheckedChanged
        Load_Info()
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Dim dr As DataRowView
        dr = Me.GridView1.GetRow(Me.GridView1.FocusedRowHandle)
        Try
            If Not dr Is Nothing Then
                If dr("LoaiDV") = 13 Then
                    Dim frm As New FRM_KECANLAMSANG
                    'frm.xemphieu = True
                    frm.Text = "DỊCH VỤ XÉT NGHIỆM"
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.loai = "13"
                    frm.duoclam = 1
                    frm.IDSophieu = dr("RefNo")
                    frm.IDPhieuxuat = dr("idsophieu")
                    frm.type = "2"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.Show()
                End If
                If dr("LoaiDV") = 14 Then
                    Dim frm As New FRM_KECANLAMSANG
                    'frm.xemphieu = True
                    frm.Text = "DỊCH VỤ SIÊU ÂM"
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.loai = "14"
                    frm.IDSophieu = dr("RefNo")
                    frm.IDPhieuxuat = dr("idsophieu")
                    frm.type = "3"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.Show()
                End If
                If dr("LoaiDV") = 15 Then
                    Dim frm As New FRM_KECANLAMSANG
                    'frm.xemphieu = True
                    frm.Text = "DỊCH VỤ XQuang"
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.loai = "15"
                    frm.IDSophieu = dr("RefNo")
                    frm.IDPhieuxuat = dr("idsophieu")
                    frm.type = "5"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.Show()
                End If
                If dr("Loaidv") = 16 Then
                    Dim frm As New FRM_KECANLAMSANG
                    'frm.xemphieu = True
                    frm.Text = "DỊCH VỤ ĐIỆN TIM"
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.loai = "16"
                    frm.IDSophieu = dr("RefNo")
                    frm.IDPhieuxuat = dr("idsophieu")
                    frm.type = "6"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.Show()
                End If
                If dr("Loaidv") = 17 Then
                    Dim frm As New FRM_KECANLAMSANG
                    'frm.xemphieu = True
                    frm.Text = "DỊCH VỤ NỘI SOI"
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.loai = "17"
                    frm.IDSophieu = dr("RefNo")
                    frm.IDPhieuxuat = dr("idsophieu")
                    frm.type = "4"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.Show()
                End If
                If dr("Loaidv") = 18 Then
                    Dim frm As New FRM_KECANLAMSANG
                    'frm.xemphieu = True
                    frm.Text = "DỊCH VỤ PHẨU THUẬT"
                    frm.load_all = False
                    frm.suaphieu = True
                    frm.loai = "18"
                    frm.IDSophieu = dr("RefNo")
                    frm.IDPhieuxuat = dr("idsophieu")
                    frm.type = "7"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    Me.AddOwnedForm(frm)
                    frm.Show()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class