Imports System.Text.RegularExpressions
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraReports.UI
Imports Report

Public Class DocBrowser
    Private arrPathImageSRC As [String]()
    Private arrPathImageDES As [String]()
    Private arrPathIamgeOld As [String]()

    Public type As String = ""
    Public fileName As String = ""
    Private dt As System.Data.DataTable
    Delegate Sub ConvertDocumentDelegate(ByVal fileName As String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private tempFileName As String = String.Empty

    Private Sub GetUrlImage(ByVal Pic As PictureBox, ByVal txtPic As System.Windows.Forms.TextBox)
        Dim open As OpenFileDialog = New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg; *.jpeg; *.gif; *.bmp"
        If open.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Pic.Image = New Bitmap(open.FileName)
            txtPic.Text = open.FileName
        End If
    End Sub

    Private Sub btnPic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPic1.Click
        GetUrlImage(Pic1, txtPic1)
    End Sub

    Private Sub btnPic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPic2.Click
        GetUrlImage(Pic2, txtPic2)
    End Sub

    Private Sub btnPic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPic3.Click
        GetUrlImage(Pic3, txtPic3)
    End Sub

    Private Sub btnPic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPic4.Click
        GetUrlImage(Pic4, txtPic4)
    End Sub

    Private Sub btnPic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPic5.Click
        GetUrlImage(Pic5, txtPic5)
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub DocBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myCIintl As New System.Globalization.CultureInfo("en-US")
        myCIintl.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        myCIintl.NumberFormat.NumberDecimalSeparator = "."
        myCIintl.NumberFormat.NumberGroupSeparator = ","
        myCIintl.NumberFormat.NumberDecimalDigits = 2
        Application.CurrentCulture = myCIintl

        Load_Combox()
        Load_Detail()
        Format_Defaulf_Font()
    End Sub

    Private Sub Load_Combox()
        Load_ComboBox("Select MaBN,HoTenBN From HOSOBN", cmbMabn, CNNQLPHONGKHAM)
        Load_ComboBox("Select MaSp,TenSp From San_Pham Where Manhom not in (10,12)", cmbDichvu, CNNQLPHONGKHAM)
        Load_ComboBox("Select MaNhom,TenNhom From Tb_NhomXetNghiem", cmbLoaiDV, CNNQLPHONGKHAM)
    End Sub

    Private Sub btnCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhat.Click
        Dim sql As String = ""
        sql &= String.Format("Update Chi_tiet_NEW Set img1=N'{0}',txt_img1=N'{1}',", txtPic1.Text, txt_ghichu_pc1.Text)
        sql &= String.Format("img2=N'{0}',txt_img2=N'{1}',", txtPic2.Text, txt_ghichu_pc2.Text)
        sql &= String.Format("img3=N'{0}',txt_img3=N'{1}',", txtPic3.Text, txt_ghichu_pc3.Text)
        sql &= String.Format("img4=N'{0}',txt_img4=N'{1}',", txtPic4.Text, txt_ghichu_pc4.Text)
        sql &= String.Format("img5=N'{0}',txt_img5=N'{1}',", txtPic5.Text, txt_ghichu_pc5.Text)
        sql &= String.Format("txt_Ketqua=N'{0}',txt_Ketluan=N'{1}' ", RichEditControl1.HtmlText.Replace("'", ""), txtKet_Luan.Text)
        sql &= String.Format("Where IDSophieu='{0}' and Masp=N'{1}' and RefNo=N'{2}'", txtSophieukham.Text, cmbDichvu.EditValue, txtSophieudv.Text)
        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
            MessageBox.Show("Lưu kết quả thành công!")
        Else
            MessageBox.Show("Lỗi, lưu kết quả thất bại!")
        End If
    End Sub

    Private Sub Load_Detail()
        dt = New System.Data.DataTable()
        Dim sql As String = ""
        sql &= String.Format("Select img1,txt_img1,img2,txt_img2,img3,txt_img3,img4,txt_img4,img5,txt_img5,txt_Ketqua,txt_Ketluan ")
        sql &= String.Format("From Chi_tiet_NEW Where IDSophieu='{0}' And Masp=N'{1}' And RefNo=N'{2}'", txtSophieukham.Text, cmbDichvu.EditValue, txtSophieudv.Text)
        dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0)("img1") Is DBNull.Value Then
                txtPic1.Text = CType(dt.Rows(0)("img1"), String)
                Try
                    Pic1.Image = New Bitmap(txtPic1.Text)
                Catch ex As Exception

                End Try
            End If
            If Not dt.Rows(0)("txt_img1") Is DBNull.Value Then
                txt_ghichu_pc1.Text = CType(dt.Rows(0)("txt_img1"), String)
            End If

            If Not dt.Rows(0)("img2") Is DBNull.Value Then
                txtPic2.Text = CType(dt.Rows(0)("img2"), String)
                Try
                    Pic2.Image = New Bitmap(txtPic2.Text)
                Catch ex As Exception

                End Try
            End If
            If Not dt.Rows(0)("txt_img2") Is DBNull.Value Then
                txt_ghichu_pc2.Text = CType(dt.Rows(0)("txt_img2"), String)
            End If

            If Not dt.Rows(0)("img3") Is DBNull.Value Then
                txtPic3.Text = CType(dt.Rows(0)("img3"), String)
                Try
                    Pic3.Image = New Bitmap(txtPic3.Text)
                Catch ex As Exception

                End Try

            End If
            If Not dt.Rows(0)("txt_img3") Is DBNull.Value Then
                txt_ghichu_pc3.Text = CType(dt.Rows(0)("txt_img3"), String)
            End If

            If Not dt.Rows(0)("img4") Is DBNull.Value Then
                txtPic4.Text = CType(dt.Rows(0)("img4"), String)
                Try
                    Pic4.Image = New Bitmap(txtPic4.Text)
                Catch ex As Exception

                End Try
            End If
            If Not dt.Rows(0)("txt_img4") Is DBNull.Value Then
                txt_ghichu_pc4.Text = CType(dt.Rows(0)("txt_img4"), String)
            End If

            If Not dt.Rows(0)("img5") Is DBNull.Value Then
                txtPic5.Text = CType(dt.Rows(0)("img5"), String)
                Try
                    Pic5.Image = New Bitmap(txtPic5.Text)
                Catch ex As Exception

                End Try
            End If
            If Not dt.Rows(0)("txt_img5") Is DBNull.Value Then
                txt_ghichu_pc5.Text = CType(dt.Rows(0)("txt_img5"), String)
            End If

            If Not dt.Rows(0)("txt_Ketqua") Is DBNull.Value Then
                RichEditControl1.HtmlText = dt.Rows(0)("txt_Ketqua")
            Else
                If fileName.Trim.Length = 0 Then
                    RichEditControl1.Text = ""
                Else
                    RichEditControl1.LoadDocument(fileName, DevExpress.XtraRichEdit.DocumentFormat.Rtf)
                End If
            End If

            If Not dt.Rows(0)("txt_Ketluan") Is DBNull.Value Then
                txtKet_Luan.Text = dt.Rows(0)("txt_Ketluan").ToString()
            End If
        End If
    End Sub

    Private Sub btnInphieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInphieu.Click
        Try
            insert_image()
        Catch ex As Exception
        End Try
        Dim tenbs As String = clsLoginObj.strHoten
        Dim logo As String = (System.Windows.Forms.Application.StartupPath.Replace("\bin", "") + "\image\logo.PNG")
        Dim frm As New frmShowReport
        dt = New DataTable()
        Dim sql As String = ""
        sql &= String.Format("Select h.MaBN,h.HoTenBN,(Case h.GioiTinh when 1 then N'Nam' when 2 then N'Nữ' else N'Khác' end) as GioiTinh,Convert(char(10),NgaySinh,103) as Namsinh,c.IDSoPhieu as SoPhieu,s.Masp,s.TenSp,c.RefNo,c.txt_Ketqua,c.txt_Ketluan ")
        sql &= String.Format("From HOSOBN h join Chi_tiet_NEW c  on h.Mabn=c.Mabn join San_Pham s on s.MaSp=c.Masp Where h.MaBN=N'{0}' And c.IDSoPhieu='{1}' And c.RefNo=N'{2}' And c.Masp=N'{3}'", cmbMabn.EditValue, txtSophieukham.Text, txtSophieudv.Text, cmbDichvu.EditValue)

        dt = BusinessLogic.Data.GetDataset(sql).Tables(0)
        frm.Title = UCase(CType(cmbDichvu.Text, String))
        frm.hoten = CType(dt.Rows(0)("HoTenBN"), String)
        frm.mabn = CType(dt.Rows(0)("MaBN"), String)
        frm.gioitinh = CType(dt.Rows(0)("GioiTinh"), String)
        frm.tuoi = CType(dt.Rows(0)("Namsinh"), String)
        frm.canlamsang = txtChandoan.Text
        frm.chidinh = cmbDichvu.Text
        If Not dt.Rows(0)("txt_ketqua") Is DBNull.Value Then
            frm.ketqua = CType(dt.Rows(0)("txt_ketqua"), String)
        Else
            frm.ketqua = ""
        End If
        If Not dt.Rows(0)("txt_ketluan") Is DBNull.Value Then
            frm.ketluan = CType(dt.Rows(0)("txt_ketluan"), String)
        Else
            frm.ketluan = ""
        End If

        Dim report As Object = Nothing
        If type = Integer.Parse(NhomDV.XETNGHIEM).ToString() Then
            'xet nghiem
            report = New XtraReport_0()
            report.ImgSource5 = logo
            report.tit = UCase(CType("KẾT QUẢ XÉT NGHIỆM", String))
            report.ht = CType(dt.Rows(0)("HoTenBN"), String)
            report.bn = CType(dt.Rows(0)("MaBN"), String)
            report.gt = CType(dt.Rows(0)("GioiTinh"), String)
            report.t = CType(dt.Rows(0)("Namsinh"), String)
            report.cd = txtChandoan.Text
            report.chd = cmbDichvu.Text
            report.kl = ""
            report.tenbs = tenbs
            report.DataSource = BusinessLogic.Data.GetDataset("Select * from ImageTable").Tables(0)
            Dim rpt As ReportPrintTool = New ReportPrintTool(report)
            rpt.ShowPreviewDialog()

        ElseIf type = Integer.Parse(NhomDV.SIEUAM).ToString() Then
            'sieu am   
            If txtSoAnh.Text = "0" Then
                report = New XtraReport_0()
            ElseIf txtSoAnh.Text = "1" Then
                report = New XtraReport_1()
            ElseIf txtSoAnh.Text = "2" Then
                report = New XtraReport_2()
            ElseIf txtSoAnh.Text = "3" Then
                report = New XtraReport_3()
            ElseIf txtSoAnh.Text = "4" Then
                report = New XtraReport_4()
            ElseIf txtSoAnh.Text = "5" Then
                report = New XtraReport_5()
            End If

            report.ImgSource5 = logo
            report.ImgSource1 = txtPic1.Text
            report.ImgSource2 = txtPic2.Text
            Try
                report.ImgSource3 = txtPic3.Text
                report.ImgSource4 = txtPic4.Text
            Catch ex As Exception

            End Try

            report.tit = UCase(CType("KẾT QUẢ SIÊU ÂM", String))
            report.ht = CType(dt.Rows(0)("HoTenBN"), String)
            report.bn = CType(dt.Rows(0)("MaBN"), String)
            report.gt = CType(dt.Rows(0)("GioiTinh"), String)
            report.t = CType(dt.Rows(0)("Namsinh"), String)
            report.cd = txtChandoan.Text
            report.chd = cmbDichvu.Text
            If Not dt.Rows(0)("txt_ketluan") Is DBNull.Value Then
                report.kl = CType(dt.Rows(0)("txt_ketluan"), String)
            Else
                report.kl = ""
            End If
            report.tenbs = tenbs
            report.DataSource = BusinessLogic.Data.GetDataset("Select * from ImageTable").Tables(0)
            Dim rpt As ReportPrintTool = New ReportPrintTool(report)
            rpt.ShowPreviewDialog()

        ElseIf type = Integer.Parse(NhomDV.NOISOI).ToString() Then
            'noi soi
            If txtSoAnh.Text = "0" Then
                report = New XtraReport_1()
            ElseIf txtSoAnh.Text = "1" Then
                report = New XtraReport_1()
            ElseIf txtSoAnh.Text = "2" Then
                report = New XtraReport_2()
            ElseIf txtSoAnh.Text = "3" Then
                report = New XtraReport_3()
            ElseIf txtSoAnh.Text = "4" Then
                report = New XtraReport_4()
            ElseIf txtSoAnh.Text = "5" Then
                report = New XtraReport_5()
            End If
            report.ImgSource5 = logo
            report.ImgSource1 = txtPic1.Text
            report.ImgSource2 = txtPic2.Text
            report.ImgSource3 = txtPic3.Text
            report.ImgSource4 = txtPic4.Text

            Try
                report.ImgSource6 = txtPic5.Text
            Catch ex As Exception

            End Try

            report.tit = UCase(CType("KẾT QUẢ NỘI SOI", String))
            report.ht = CType(dt.Rows(0)("HoTenBN"), String)
            report.bn = CType(dt.Rows(0)("MaBN"), String)
            report.gt = CType(dt.Rows(0)("GioiTinh"), String)
            report.t = CType(dt.Rows(0)("Namsinh"), String)
            report.cd = txtChandoan.Text
            report.chd = cmbDichvu.Text
            If Not dt.Rows(0)("txt_ketluan") Is DBNull.Value Then
                report.kl = CType(dt.Rows(0)("txt_ketluan"), String)
            Else
                report.kl = ""
            End If
            report.tenbs = tenbs
            report.DataSource = BusinessLogic.Data.GetDataset("Select * From ImageTable").Tables(0)
            Dim rpt As ReportPrintTool = New ReportPrintTool(report)
            rpt.ShowPreviewDialog()

        ElseIf type = Integer.Parse(NhomDV.XQUANG).ToString() Then
            'x-quang            
            report = New XtraReport_0()
            report.ImgSource5 = logo
            report.tit = UCase(CType("KẾT QUẢ XQUANG", String))
            report.ht = CType(dt.Rows(0)("HoTenBN"), String)
            report.bn = CType(dt.Rows(0)("MaBN"), String)
            report.gt = CType(dt.Rows(0)("GioiTinh"), String)
            report.t = CType(dt.Rows(0)("Namsinh"), String)
            report.cd = CType(txtChandoan.Text, String)
            report.chd = CType(cmbDichvu.Text, String)
            If Not dt.Rows(0)("txt_ketluan") Is DBNull.Value Then
                report.kl = CType(dt.Rows(0)("txt_ketluan"), String)
            Else
                report.kl = ""
            End If
            report.tenbs = tenbs
            report.DataSource = BusinessLogic.Data.GetDataset("Select * from ImageTable").Tables(0)
            Dim rpt As ReportPrintTool = New ReportPrintTool(report)
            rpt.ShowPreviewDialog()

        ElseIf type = Integer.Parse(NhomDV.DIENTIM).ToString() Then
            'dien tim
            report = New XtraReport_0()
            report.ImgSource5 = logo
            report.tit = UCase(CType("KẾT QUẢ ĐIỆN TIM", String))
            report.ht = CType(dt.Rows(0)("HoTenBN"), String)
            report.bn = CType(dt.Rows(0)("MaBN"), String)
            report.gt = CType(dt.Rows(0)("GioiTinh"), String)
            report.t = CType(dt.Rows(0)("Namsinh"), String)
            report.cd = txtChandoan.Text
            report.chd = cmbDichvu.Text
            If Not dt.Rows(0)("txt_ketluan") Is DBNull.Value Then
                report.kl = CType(dt.Rows(0)("txt_ketluan"), String)
            Else
                report.kl = ""
            End If
            report.tenbs = tenbs
            report.DataSource = BusinessLogic.Data.GetDataset("Select * from ImageTable").Tables(0)
            Dim rpt As ReportPrintTool = New ReportPrintTool(report)
            rpt.ShowPreviewDialog()

        ElseIf type = Integer.Parse(NhomDV.TTPT).ToString() Then
            'ttpt            
            report = New XtraReport_0()
            report.ImgSource5 = logo
            report.tit = UCase(CType("KẾT QUẢ THỦ THUẬT", String))
            report.ht = CType(dt.Rows(0)("HoTenBN"), String)
            report.bn = CType(dt.Rows(0)("MaBN"), String)
            report.gt = CType(dt.Rows(0)("GioiTinh"), String)
            report.t = CType(dt.Rows(0)("Namsinh"), String)
            report.cd = txtChandoan.Text
            report.chd = cmbDichvu.Text
            If Not dt.Rows(0)("txt_ketluan") Is DBNull.Value Then
                report.kl = CType(dt.Rows(0)("txt_ketluan"), String)
            Else
                report.kl = ""
            End If
            report.tenbs = tenbs
            report.DataSource = BusinessLogic.Data.GetDataset("Select * From ImageTable").Tables(0)
            Dim rpt As ReportPrintTool = New ReportPrintTool(report)
            rpt.ShowPreviewDialog()
        End If
    End Sub

    Private Sub insert_image()
        Dim sql As String = ""
        sql &= String.Format("Update ImageTable set Pic1='{0}',Pic2='{1}',Pic3='{2}',Pic4='{3}',Pic5='{4}',", txtPic1.Text, txtPic2.Text, txtPic3.Text, txtPic4.Text, txtPic5.Text)
        sql &= String.Format("txt_pic1=N'{0}',txt_pic2=N'{1}',txt_pic3=N'{2}',txt_pic4=N'{3}',", txt_ghichu_pc1.Text, txt_ghichu_pc2.Text, txt_ghichu_pc3.Text, txt_ghichu_pc4.Text)
        sql &= String.Format("txt_pic5=N'{0}',ketqua=N'{1}'", txt_ghichu_pc5.Text, RichEditControl1.HtmlText.Replace("'", ""))
        If Command_Exc(sql, CNNQLPHONGKHAM) = 0 Then
        Else
            MsgBox("Có lỗi xãy ra!")
        End If
    End Sub

    Public Shared Function RemoveAllHtmlTag(ByVal content As String) As String
        Dim result As String = content
        Dim removeTagArray As String() = New String() {"b", "a", "script", "i", "ul", "li", "ol", "font", "span", "div", "u"}
        For Each removeTag As String In removeTagArray
            Dim regExpressionToRemoveBeginTag As String = String.Format("<{0}([^>]*)>", removeTag)
            Dim regEx As New Regex(regExpressionToRemoveBeginTag, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            result = regEx.Replace(result, "")

            Dim regExpressionToRemoveEndTag As String = String.Format("</{0}([^>]*)>", removeTag)
            regEx = New Regex(regExpressionToRemoveEndTag, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            result = regEx.Replace(result, "")
        Next
        Return result
    End Function

    Private Sub Format_Defaulf_Font()
        RichEditControl1.SelectAll()
        Dim range As DocumentRange = RichEditControl1.Document.Selection
        Dim characterProperties As CharacterPropertiesBase = RichEditControl1.Document.BeginUpdateCharacters(range)
        characterProperties.FontName = "Times New Roman"
        'characterProperties.FontSize = 12.0F
        'characterProperties.Italic = True
        RichEditControl1.Document.EndUpdateCharacters(characterProperties)
    End Sub
End Class