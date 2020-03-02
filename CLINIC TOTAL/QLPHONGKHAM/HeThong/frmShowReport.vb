Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports Report
Public Class frmShowReport
    Inherits System.Windows.Forms.Form
    Public IDchitiet As String
    Public IDchitiet2 As Int64
    'noisoi_xquang
    Public bsdieutri As String
    Public bsckhoa As String
    'Public bsnoisoi As String
    'Public bsxn As String
    Public TenBV As String
    Public Noikham As String
    Public hoten As String
    Public tuoi As String
    Public gioitinh As String
    Public diachi As String
    Public dienthoai As String
    Public sothe As String
    Public tel As String
    Public nghenghiep As String
    Public sothebhyt As String
    Public canlamsang As String
    Public chandoanbenh As String
    Public loidanbacsi As String
    Public trieuchung As String
    '--- kHAI BAO PHUC VU PHAN NHA HÀNG - SAU NAY S? BO B?T BI?N ÐI
    Public Tungay As DateTime
    Public Denngay As DateTime
    Public Ngayin As DateTime
    Public strBC As TenBc
    Public strMakh As String
    Public strMadv As String
    Public Paraval1 As String
    Public Paraval2 As String
    Public IDPhieuTC As String
    Public LoaiPhieuTC As String
    Public NguoiTC As String
    Public Bangchu As String
    Public BangchuVND As String
    Public Title As String
    Public dtb As New DataTable
    Public dtbrp As New DataTable
    Public DoanhSo As Double 'thu USD
    Public TienLai As Double 'thu VND
    Public fNobandau As Double 'chi USD
    Public Paraval3 As Double  'chi VND
    Public Paraval4 As Double  'so phieu
    Public paraval5 As Double 'Fax
    Public Ngay As DateTime
    Public Tngay As DateTime
    Public Dngay As DateTime
    Public Tienhang As Double
    Public TienVND As Double
    Public VAT As Double
    Public TongSo As Double
    Public TongSP As Double
    Public NguoiGD As String
    Public xuatnhap As String
    Public Phong As String
    Public Nhanvien As String
    Public donvi As String
    'bien tinh form thong ke lai lo
    Public Tongds As Double
    Public Tongnl As Double
    Public Thucds As Double
    Public Tongvon As Double
    Public TongvonNL As Double
    Public Thucvon As Double
    Public Tonglai As Double
    Public LaiNL As Double
    Public Thuclai As Double
    Public Tyle As Double
    ' Phieu thanh toán tổng hợp
    Public tienkham As Double
    Public tiensieuamtim As Double
    Public tiensieuamobung As Double
    Public tiensieuamMM As Double
    Public tienXNnuoctieu As Double
    Public tienXNhuyethoc As Double
    Public tienXNsinhhoa As Double
    Public tienXQuang As Double
    Public tienNoisoi As Double
    Public tientienthuoc As Double
    Public tientongtien As Double
    Public tienBNchitra As Double
    Public tienBVchitra As Double
    Public tienDT As Double
    Public tienTG As Double
    Public TongII As Double
    Public Ngaythang As String
    Public GT As String
    Public DKKBD As String
    Public tiensathai As Double
    'TIEN BN CHI TRA
    Public TIENTHUOC As Double
    Public TIENXN As Double
    Public TIENCDHA As Double
    Public BNTRA As Double
    Public BHTT As Double
    Public Phieudv As String
    'In phieu VTYT
    Public IDSophieukham As String
    Public IDSophieu As String
    Public phong_kham As String
    Public mabn As String
    Public tienbangchu As String
    Public chidinh As String
    Public ketqua As String
    Public ketluan As String
    Public thutien As Boolean
    Public Ngayhenkham As String
    Public LoaiPhieu As Integer
    Public loaixn As String
    'In tk phieu kham
    Public bacsi As String
    Public view As Boolean
    Public henkham As Boolean
    Public doituong As Integer
    Public stt As String
    Public SoNgay As String
    'Phieu doi tra
    Public tiennhan As Double
    Public tientra As Double
    Public lbl_thucthu As String
    Public thanhtoan As Double
    Public IDPhieuNhan As Long
    Public IDPhieuTra As Long
    Public Property khoIn As String
    Enum TenBc
        PhieuXN = 1
        PhieuTC = 2
        Tonkho = 3
        ThongkeTC = 4
        TKTon_Quy = 5
        ThongKeTruyCap = 6

        '--Noisoi_ChupXQ----
        Phieunoisoi = 7
        Phieuchupxquang = 8
        Thongkephieuchupxquang = 9
        ThongKephieunoisoi = 10

        'phieu xet nghiem
        Thongkephieuxetnghiem = 11
        Phieuxetnghiemhh = 12
        Phieuxetnghiemnuoctieu = 13
        Phieuxetnghiemsinhhoamau = 14
        PhieuSA_dopplertim = 15
        phieuKQsieuam = 16
        PhieuSA_maumachmau = 17
        Thongkephieusieuam = 18

        TheKho = 19
        ThongKeXN = 20
        Phieuthanhtoan = 21
        ThongKeXN_donthuoc = 22
        Thongkexangxe = 23
        Sieuamtuyengiap = 24
        Phieudientim = 25
        Thongkedientim = 26
        ThongkeBC = 27
        ThongkeBC1 = 28
        ThongkechiphiBN = 29
        Phieusieuamthai = 30
        Phieusieuamthai4D = 31
        Phieusieuamthai3D = 32
        Phieukhambenh = 33
        Phieuxangxe = 34
        Thongkephieukham_bh = 35
        TKchuyenvien = 36
        Kedonthuoc = 37
        ThongkeBCCV = 38
        PhieuxuatHC = 39
        ThongkeBCTH = 40
        Giaychuyenvien = 41
        Giaychuyenvien1 = 42
        Phieusaob_nu = 43
        chitietDV = 44
        '
        Phieudv = 46
        DanhSach = 47
        Phieuxetnghiem = 48
        Phieuxq = 49
        PhieuVaoVien = 50
        Phieusieuamthainho = 51
        phieusieuamtcpp = 52
        tonghop_thuchi_tamung = 53
        PHIEULINHTHUOCVTYT = 54
        PhieuLinhthuoctamthan = 55
        DanhSachNoiTru = 56
        PhieuRaVien = 57
        InPhieu_VTYT = 58
        soicotucung = 59
        sieuamdaudo = 60
        soinhuomdich = 61
        sieuamvu = 62
        Thai14tuan = 64
        thaidoito = 65
        Phieunhap = 66
        sieuamtcpp = 67
        sieuamtinhhoan = 68
        sieuamthaito = 69
        sieuamthai14tuan = 70
        sieuamhach = 71
        sieuamtietnieu = 72
        sieuamdmc = 73
        sieuamchitren = 74
        sieuamchiduoi = 75
        soitmh = 76
        soidaday = 77
        soidaitrang = 78
        soitructrang = 79
        Sieuamthaidoi3t = 80
        Phieusieuamthai2D = 81

        New_XetNghiem = 82
        New_SieuAm = 83
        New_NoiSoi_TMH = 84
        New_NoiSoi_Khac = 85
        New_XQuang = 86
        LaySophieukham = 87

        Xuat_VTHT_CLS = 88
        PhieuDoiTra = 89
    End Enum
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
    Friend WithEvents crvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowReport))
        Me.crvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvViewer
        '
        Me.crvViewer.ActiveViewIndex = -1
        Me.crvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvViewer.Location = New System.Drawing.Point(0, 0)
        Me.crvViewer.Name = "crvViewer"
        Me.crvViewer.SelectionFormula = ""
        Me.crvViewer.Size = New System.Drawing.Size(712, 574)
        Me.crvViewer.TabIndex = 0
        Me.crvViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crvViewer.ViewTimeSelectionFormula = ""
        '
        'frmShowReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(712, 574)
        Me.Controls.Add(Me.crvViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmShowReport"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "XEM TRƯỚC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Load_CnnInfor(ByVal BC As TenBc)
        Dim crDatabase As Database
        Dim crTables As Tables
        Dim crTable As Table
        Dim crTableLogOnInfo As TableLogOnInfo
        Dim crConnectionInfo As ConnectionInfo
        Dim rpt As Object
        If BC = TenBc.PhieuxuatHC Then
            rpt = New Report.rptPhieuXN_xuatHC
            rpt.SetParameterValue("IDSophieu", IDPhieuTC)
            crDatabase = rpt.Database
        ElseIf BC = TenBc.PhieuXN Then
            If khoIn = "K57" Then
                rpt = New rptPhieuXN_Kedonthuoc_K57
            ElseIf khoIn = "K80" Then
                rpt = New rptPhieuXN_Kedonthuoc_K80
            ElseIf khoIn = "A5" Then
                rpt = New rptPhieuXN_Kedonthuoc
            ElseIf khoIn = "A4" Then
                rpt = New rptPhieuXN_Kedonthuoc_A4
            Else
                rpt = New rptPhieuXN_Kedonthuoc
            End If

            rpt.setDatasource(dtb)
            rpt.SetParameterValue("IDSophieu", IDPhieuTC)
            rpt.SetParameterValue("Title", Title)
            rpt.SetParameterValue("tuoi", tuoi)
            rpt.SetParameterValue("gioitinh", gioitinh)
            rpt.SetParameterValue("tienbangchu", tienbangchu)
            crDatabase = rpt.Database

        ElseIf BC = TenBc.Phieunhap Then
            rpt = New rptPhieunhapthuoc
            rpt.SetParameterValue("IDSophieu", IDPhieuTC)
            rpt.SetParameterValue("Title", Title)
            crDatabase = rpt.Database

        ElseIf BC = TenBc.Kedonthuoc Then
            rpt = New rpt_DonThuoc 'RPT_Kedonthuoc2
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("@Idphieu", IDPhieuTC)
            rpt.SetParameterValue("Title", Title)
            rpt.SetParameterValue("songay", SoNgay)
            rpt.SetParameterValue("ngayhenkham", Ngayhenkham)
            rpt.SetParameterValue("tuoi", tuoi)
            crDatabase = rpt.Database
        ElseIf BC = TenBc.ThongKeTruyCap Then
            rpt = New Crys_Login
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("Tungay", Tngay)
            rpt.SetParameterValue("Denngay", Dngay)
            rpt.SetParameterValue("Tenct", strMadv)
            rpt.SetParameterValue("diachi", strMakh)
            rpt.SetParameterValue("tel", Paraval1)
            rpt.SetParameterValue("Fax", Paraval2)
            crDatabase = rpt.Database

        ElseIf BC = TenBc.Phieukhambenh Then
            rpt = New rpt_Benh_An
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("hoten", hoten)
            rpt.SetParameterValue("diachi", diachi)
            rpt.SetParameterValue("dienthoai", tel)
            rpt.SetParameterValue("sothebhyt", sothebhyt)
            rpt.SetParameterValue("canlamsang", canlamsang)
            rpt.SetParameterValue("chandoanbenh", chandoanbenh)
            rpt.SetParameterValue("loidan", loidanbacsi)
            rpt.SetParameterValue("ngaylap", Ngaythang)
            rpt.SetParameterValue("trieuchung", trieuchung)
            rpt.SetParameterValue("tuoi", tuoi)
            crDatabase = rpt.Database

        ElseIf BC = TenBc.PhieuTC Then
            rpt = New rptPhieuTC
            rpt.SetParameterValue("IDSophieu", IDPhieuTC)
            rpt.SetParameterValue("NguoiTC", NguoiTC)
            rpt.SetParameterValue("Title", Title)
            rpt.SetParameterValue("Hoten", donvi)
            rpt.SetParameterValue("Loaiphieu", LoaiPhieuTC)
            rpt.SetParameterValue("Bangchu", Bangchu)
            rpt.SetParameterValue("BangchuVND", BangchuVND)
            rpt.SetParameterValue("dia_chi", diachi)
            rpt.SetParameterValue("dien_thoai", dienthoai)
            crDatabase = rpt.Database
        ElseIf BC = TenBc.ThongkeTC Then
            Try
                rpt = New rptThongkeTC
                rpt.setDatasource(dtb)
                rpt.SetParameterValue("ThuUSD", DoanhSo)
                rpt.SetParameterValue("ThuVND", TienLai)
                rpt.SetParameterValue("ChiUSD", fNobandau)
                rpt.SetParameterValue("ChiVND", Paraval3)
                rpt.SetParameterValue("TongSP", Paraval4)
                rpt.SetParameterValue("Tungay", Tngay)
                rpt.SetParameterValue("Denngay", Dngay)
                rpt.SetParameterValue("Title", Title)
                crDatabase = rpt.Database
            Catch ex As Exception
            End Try

        ElseIf BC = TenBc.TKTon_Quy Then
            Try
                rpt = New rptTKTon_Quy
                rpt.setDatasource(dtb)
                rpt.SetParameterValue("TonVND", Paraval3)
                rpt.SetParameterValue("TonUSD", Paraval4)
                rpt.setparameterValue("tNgay", Tngay)
                rpt.setparameterValue("dNgay", Dngay)
                crDatabase = rpt.Database
            Catch ex As Exception

            End Try

        ElseIf BC = TenBc.Tonkho Then
            Try
                rpt = New rptTonkho
                rpt.setDatasource(dtb)
                rpt.SetParameterValue("Dngay", Dngay)
                rpt.SetParameterValue("Tngay", Tngay)
                rpt.SetParameterValue("kho", Phong)
                rpt.SetParameterValue("Nhomhang", Paraval1)
                crDatabase = rpt.Database
            Catch ex As Exception

            End Try

        ElseIf BC = TenBc.DanhSach Then
            rpt = New Rpt_DSCLS
            crDatabase = rpt.Database
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("@IDsophieu", IDchitiet)
            crDatabase = rpt.Database
        ElseIf BC = TenBc.ThongKeXN Then
            Try
                rpt = New rptThongKeXN
                rpt.setDatasource(dtb)
                rpt.SetParameterValue("VAT", VAT)
                rpt.SetParameterValue("Tienhang", Tienhang)
                rpt.SetParameterValue("Tongso", TongSo)
                rpt.SetParameterValue("TongSP", TongSP)
                rpt.SetParameterValue("Title", Title)
                rpt.SetParameterValue("Tungay", Tngay)
                rpt.SetParameterValue("Denngay", Dngay)
                rpt.SetParameterValue("phong", Phong)
                rpt.SetParameterValue("Nhanvien", Nhanvien)
                rpt.SetParameterValue("Donvi", donvi)
                crDatabase = rpt.Database
            Catch ex As Exception

            End Try

        ElseIf BC = TenBc.ThongKeXN_donthuoc Then
            Try
                rpt = New rptThongKeXN_donthuoc
                rpt.setDatasource(dtb)
                rpt.SetParameterValue("Tongso", TongSo)
                rpt.SetParameterValue("TongSP", TongSP)
                rpt.SetParameterValue("Title", Title)
                rpt.SetParameterValue("Tungay", Tngay)
                rpt.SetParameterValue("Denngay", Dngay)
                crDatabase = rpt.Database
            Catch ex As Exception

            End Try

        ElseIf BC = TenBc.TheKho Then
            rpt = New rptInTheKho
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("tel", Paraval1)
            rpt.SetParameterValue("Fax", Paraval2)
            rpt.SetParameterValue("tondau", fNobandau)
            rpt.SetParameterValue("sln", Paraval3)
            rpt.SetParameterValue("slx", Paraval4)
            rpt.SetParameterValue("toncuoi", paraval5)
            crDatabase = rpt.DataBase

        ElseIf BC = TenBc.Phieudv Then
            rpt = New RPT_PhieuinXN
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("@IDSophieu", IDchitiet)
            rpt.SetParameterValue("Title", Title)
            rpt.SetParameterValue("@thutien", thutien)
            rpt.SetParameterValue("tuoi", tuoi)
            crDatabase = rpt.Database
        ElseIf BC = TenBc.PhieuDoiTra Then
            rpt = New rpt_PhieuDoiTra
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("@IDPhieuNhan", IDPhieuNhan)
            rpt.SetParameterValue("@IDPhieuTra", IDPhieuTra)
            rpt.SetParameterValue("hoten", hoten)
            rpt.SetParameterValue("tuoi", tuoi)
            rpt.SetParameterValue("diachi", diachi)
            rpt.SetParameterValue("dienthoai", dienthoai)
            rpt.SetParameterValue("lbl_thucthu", lbl_thucthu)
            rpt.SetParameterValue("tiennhan", tiennhan)
            rpt.SetParameterValue("tientra", tientra)
            rpt.SetParameterValue("thanhtoan", thanhtoan)
            crDatabase = rpt.Database
        ElseIf BC = TenBc.Phieudientim Then
            Return
        ElseIf BC = TenBc.Phieuxetnghiem Then
            rpt = New RPT_PhieuXetNghiem
            rpt.SetParameterValue("IDSophieu", IDchitiet)
            rpt.SetParameterValue("Title", Title)
            crDatabase = rpt.Database

        ElseIf BC = TenBc.Thongkephieusieuam Then
            Try
                rpt = New RPT_THONGKE_SIEUAM
                rpt.setDatasource(dtb)
                rpt.SetParameterValue("Tungay", Tngay)
                rpt.SetParameterValue("Denngay", Dngay)
                rpt.SetParameterValue("tongtien", tientongtien)
                rpt.SetParameterValue("Title", Title)
                crDatabase = rpt.Database
            Catch ex As Exception
            End Try

        ElseIf BC = TenBc.Thongkephieukham_bh Then
            rpt = New rpt_TKPhieuKham
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("tu_ngay", Tngay)
            rpt.SetParameterValue("den_ngay", Dngay)
            rpt.SetParameterValue("@tungay", Tngay)
            rpt.SetParameterValue("@denngay", Dngay)
            rpt.SetParameterValue("@bacsi", bacsi)
            rpt.SetParameterValue("@mabn", mabn)
            rpt.SetParameterValue("@doituong", doituong)
            rpt.SetParameterValue("@henkham", henkham)
            rpt.SetParameterValue("@view", view)
            crDatabase = rpt.Database

        ElseIf BC = TenBc.LaySophieukham Then
            rpt = New rpt_Sophieukham
            rpt.SetParameterValue("STT", stt)
            rpt.SetParameterValue("ngay", Ngay)
            rpt.SetParameterValue("hoten", hoten)
            rpt.SetParameterValue("mabn", mabn)
            crDatabase = rpt.Database

        ElseIf BC = TenBc.Xuat_VTHT_CLS Then
            rpt = New rpt_xuat_vtth_cls
            rpt.setDatasource(dtb)
            rpt.SetParameterValue("tieude", Title)
            rpt.SetParameterValue("maxn", loaixn)
            rpt.SetParameterValue("@sophieu", IDSophieu)
            rpt.SetParameterValue("@maphong", "")
            rpt.SetParameterValue("@loaiphieu", LoaiPhieu)
            rpt.SetParameterValue("@loaixn", loaixn)
            crDatabase = rpt.DataBase

        End If
        crConnectionInfo = New ConnectionInfo
        With crConnectionInfo
            .ServerName = P_Server
            .DatabaseName = P_Database
            .UserID = P_Username
            .Password = P_Password
        End With
        crTables = crDatabase.Tables
        For Each crTable In crTables
            crTableLogOnInfo = crTable.LogOnInfo
            crTableLogOnInfo.ConnectionInfo = crConnectionInfo
            crTable.ApplyLogOnInfo(crTableLogOnInfo)
        Next
        Me.crvViewer.ReportSource = rpt
        GC.Collect()
    End Sub
    Private Sub frmShowReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.crvViewer.Height = Me.Height
        Me.crvViewer.Width = Me.Width
        Load_CnnInfor(strBC)
    End Sub

    Private Sub frmShowReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.P And e.Control = True Then
            Me.crvViewer.PrintReport()
        End If
    End Sub
End Class
