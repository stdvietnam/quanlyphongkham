Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports Connection_db
Imports DevExpress.Skins
Imports System.Threading

Public Class form1
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents frmPhanQuyen As System.Windows.Forms.MenuItem
    Friend WithEvents frmNhom_NSD As System.Windows.Forms.MenuItem
    Friend WithEvents frmNguoi_SD As System.Windows.Forms.MenuItem
    Friend WithEvents frmDangNhaplai As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents OfficeMenus1 As Dev4Arabs.OfficeMenus
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBThutm As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBChiTM As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBThuTG As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBChiTG As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBLai_xuat As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBCongno As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBTon_quy As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBHachtoanvon As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBPhanQuyen As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBDangNhaplai As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBTKTruycap As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBTSCD As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBTktscd As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBTKKH As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBTKLH As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBBGBTN As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBTKTC As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBICapNhatTonKho As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBICapNhatCNBD As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NBICapNhatTQ As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NVB_LP_XuatThue As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NVB_LP_Nhapthue As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NVB_KT_tk_HDT As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NVB_In_TKHoadon As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NVB_Lap_ct_KeToan As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuHDSD As System.Windows.Forms.MenuItem
    Friend WithEvents MenuThoat As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel6 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents NB_QLKHO_Tonghopnhapxuatton As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_QLKHO_THNXtheonhacungcap As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_QLKHO_THNXT_theonhom As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_QLKHO_TKTonkhotonghop As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_QLKHO_TKTonkhonhaCC As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_QLKHO_TKTonkhotheoHanSD As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_QLKHO_TKTonkhoDINHMUC As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_cauca As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_sinhvatcanh As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_DTNhahang As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_DTquaybar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_DTKaraoke As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_Chiphitonghop As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_Chiphithaca As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_CPThucpham As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_Chiphiluong As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_Chiphikhac As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_CNphaithu As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NB_baocao_CNphaitra As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danhmuc_Benhnhan As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danhmuc_nhomthuoc As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danhmuc_thuoc As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danhmuc_nghiepvuthuchi As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danhmuc_Quy As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danhmuc_donvicungcap As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danhmuc_khothuoc As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_KHAM_TKphieudk As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_thuchi_TKephieuthuchi As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_thuchi_TonquyTC As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_THUOC_Nhapthuoc As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_THUOC_TKXnhap As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_THUOC_TonkhothuocBHXH As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_thuchi_TonquyDK As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Thuoc_thongkephieunhap As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_duong5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_phieuthu As System.Windows.Forms.MenuItem
    Friend WithEvents d11 As System.Windows.Forms.MenuItem
    Friend WithEvents NavBarControl2 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBar_kham As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_sieuam As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_XN As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_noisoi As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_XQ As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_dientim As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup6 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBar_THUCHI_THONGKE As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_THUCHI_TONQUY As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_KB_tkphieukham As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBar_PTTT As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem6 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Menuxuatthuoc As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents d12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents d2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents d3 As System.Windows.Forms.MenuItem
    Friend WithEvents d4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents d9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents d10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents d1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents d13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents MenuItem13 As MenuItem
    Friend WithEvents MenuItem19 As MenuItem
    Friend WithEvents MenuItem20 As MenuItem
    Friend WithEvents MenuItem21 As MenuItem
    Friend WithEvents MenuItem23 As MenuItem
    Friend WithEvents NavBar_TiepDon As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents MenuItem27 As MenuItem
    Friend WithEvents MenuItem28 As MenuItem
    Friend WithEvents MenuItem29 As MenuItem
    Friend WithEvents MenuItem32 As MenuItem
    Friend WithEvents MenuItem33 As MenuItem
    Friend WithEvents MenuItem34 As MenuItem
    Friend WithEvents DefaultLookAndFeel_Main As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents MenuItem36 As MenuItem
    Friend WithEvents MenuItem38 As MenuItem
    Friend WithEvents NavBar_THUTIEN_DICHVU As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Menu_PhieuchiTM As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.frmNhom_NSD = New System.Windows.Forms.MenuItem()
        Me.frmNguoi_SD = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.frmDangNhaplai = New System.Windows.Forms.MenuItem()
        Me.frmPhanQuyen = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.d1 = New System.Windows.Forms.MenuItem()
        Me.MenuThoat = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.Menu_Danhmuc_Benhnhan = New System.Windows.Forms.MenuItem()
        Me.Menu_Danhmuc_donvicungcap = New System.Windows.Forms.MenuItem()
        Me.Menu_Danhmuc_nhomthuoc = New System.Windows.Forms.MenuItem()
        Me.Menu_Danhmuc_thuoc = New System.Windows.Forms.MenuItem()
        Me.Menu_Danhmuc_nghiepvuthuchi = New System.Windows.Forms.MenuItem()
        Me.Menu_Danhmuc_Quy = New System.Windows.Forms.MenuItem()
        Me.Menu_Danhmuc_khothuoc = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem77 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem114 = New System.Windows.Forms.MenuItem()
        Me.d2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem115 = New System.Windows.Forms.MenuItem()
        Me.d3 = New System.Windows.Forms.MenuItem()
        Me.Menu_KHAM_TKphieudk = New System.Windows.Forms.MenuItem()
        Me.d4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.d13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem129 = New System.Windows.Forms.MenuItem()
        Me.MenuItem139 = New System.Windows.Forms.MenuItem()
        Me.d9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem140 = New System.Windows.Forms.MenuItem()
        Me.MenuItem119 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem124 = New System.Windows.Forms.MenuItem()
        Me.MenuItem141 = New System.Windows.Forms.MenuItem()
        Me.MenuItem142 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem143 = New System.Windows.Forms.MenuItem()
        Me.MenuItem144 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem146 = New System.Windows.Forms.MenuItem()
        Me.MenuItem147 = New System.Windows.Forms.MenuItem()
        Me.MenuItem73 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem149 = New System.Windows.Forms.MenuItem()
        Me.MenuItem150 = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem153 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.d10 = New System.Windows.Forms.MenuItem()
        Me.Menu_phieuthu = New System.Windows.Forms.MenuItem()
        Me.Menu_PhieuchiTM = New System.Windows.Forms.MenuItem()
        Me.Menu_thuchi_TKephieuthuchi = New System.Windows.Forms.MenuItem()
        Me.d11 = New System.Windows.Forms.MenuItem()
        Me.Menu_thuchi_TonquyDK = New System.Windows.Forms.MenuItem()
        Me.Menu_thuchi_TonquyTC = New System.Windows.Forms.MenuItem()
        Me.d12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.Menu_THUOC_Nhapthuoc = New System.Windows.Forms.MenuItem()
        Me.MenuItem68 = New System.Windows.Forms.MenuItem()
        Me.Menu_Thuoc_thongkephieunhap = New System.Windows.Forms.MenuItem()
        Me.Menu_duong5 = New System.Windows.Forms.MenuItem()
        Me.Menuxuatthuoc = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.Menu_THUOC_TKXnhap = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem82 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.Menu_THUOC_TonkhothuocBHXH = New System.Windows.Forms.MenuItem()
        Me.MenuItem79 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem76 = New System.Windows.Forms.MenuItem()
        Me.MenuItem78 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuHDSD = New System.Windows.Forms.MenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel6 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.NavBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBar_TiepDon = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_kham = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_XN = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_sieuam = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_noisoi = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_XQ = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_dientim = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_PTTT = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBar_THUTIEN_DICHVU = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_THUCHI_THONGKE = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_THUCHI_TONQUY = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBar_KB_tkphieukham = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem6 = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.DefaultLookAndFeel_Main = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem1, Me.MenuItem2, Me.MenuItem129, Me.MenuItem119, Me.MenuItem141, Me.MenuItem144, Me.MenuItem147, Me.MenuItem150, Me.MenuItem27, Me.MenuItem39, Me.MenuItem24, Me.MenuItem6, Me.MenuItem8})
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.frmNhom_NSD, Me.frmNguoi_SD, Me.MenuItem48, Me.frmDangNhaplai, Me.frmPhanQuyen, Me.MenuItem10, Me.MenuItem3, Me.d1, Me.MenuThoat})
        Me.MenuItem16.ShowShortcut = False
        Me.MenuItem16.Text = "HỆ THỐNG"
        '
        'frmNhom_NSD
        '
        Me.frmNhom_NSD.Index = 0
        Me.frmNhom_NSD.Text = "Nhóm người sử dụng"
        '
        'frmNguoi_SD
        '
        Me.frmNguoi_SD.Index = 1
        Me.frmNguoi_SD.Text = "Người sử dụng"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 2
        Me.MenuItem48.Text = "Đổi mật khẩu"
        '
        'frmDangNhaplai
        '
        Me.frmDangNhaplai.Index = 3
        Me.frmDangNhaplai.Shortcut = System.Windows.Forms.Shortcut.CtrlShift3
        Me.frmDangNhaplai.Text = "Đăng nhập"
        '
        'frmPhanQuyen
        '
        Me.frmPhanQuyen.Index = 4
        Me.frmPhanQuyen.Shortcut = System.Windows.Forms.Shortcut.CtrlShift2
        Me.frmPhanQuyen.Text = "Phân quyền"
        Me.frmPhanQuyen.Visible = False
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlShift1
        Me.MenuItem10.Text = "Làm trắng dữ liệu"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 6
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlShift4
        Me.MenuItem3.Text = "Thống kê truy cập"
        '
        'd1
        '
        Me.d1.Index = 7
        Me.d1.Text = "-"
        '
        'MenuThoat
        '
        Me.MenuThoat.Index = 8
        Me.MenuThoat.Shortcut = System.Windows.Forms.Shortcut.CtrlShift5
        Me.MenuThoat.Text = "Thoát"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Danhmuc_Benhnhan, Me.Menu_Danhmuc_donvicungcap, Me.Menu_Danhmuc_nhomthuoc, Me.Menu_Danhmuc_thuoc, Me.Menu_Danhmuc_nghiepvuthuchi, Me.Menu_Danhmuc_Quy, Me.Menu_Danhmuc_khothuoc, Me.MenuItem30, Me.MenuItem31, Me.MenuItem35, Me.MenuItem37, Me.MenuItem17, Me.MenuItem9, Me.MenuItem53, Me.MenuItem77, Me.MenuItem15, Me.MenuItem11, Me.MenuItem29, Me.MenuItem38})
        Me.MenuItem1.ShowShortcut = False
        Me.MenuItem1.Text = "DANH MỤC"
        '
        'Menu_Danhmuc_Benhnhan
        '
        Me.Menu_Danhmuc_Benhnhan.Index = 0
        Me.Menu_Danhmuc_Benhnhan.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftD
        Me.Menu_Danhmuc_Benhnhan.Text = "Danh mục bệnh nhân"
        '
        'Menu_Danhmuc_donvicungcap
        '
        Me.Menu_Danhmuc_donvicungcap.Index = 1
        Me.Menu_Danhmuc_donvicungcap.Text = "Danh mục đơn vị cung cấp"
        '
        'Menu_Danhmuc_nhomthuoc
        '
        Me.Menu_Danhmuc_nhomthuoc.Index = 2
        Me.Menu_Danhmuc_nhomthuoc.Text = "Danh mục nhóm sản phẩm - dịch vụ"
        '
        'Menu_Danhmuc_thuoc
        '
        Me.Menu_Danhmuc_thuoc.Index = 3
        Me.Menu_Danhmuc_thuoc.Text = "Danh mục sản phẩm - dịch vụ"
        '
        'Menu_Danhmuc_nghiepvuthuchi
        '
        Me.Menu_Danhmuc_nghiepvuthuchi.Index = 4
        Me.Menu_Danhmuc_nghiepvuthuchi.Text = "Danh mục thu chi"
        '
        'Menu_Danhmuc_Quy
        '
        Me.Menu_Danhmuc_Quy.Index = 5
        Me.Menu_Danhmuc_Quy.Text = "Danh mục quỹ"
        '
        'Menu_Danhmuc_khothuoc
        '
        Me.Menu_Danhmuc_khothuoc.Index = 6
        Me.Menu_Danhmuc_khothuoc.Text = "Danh mục kho"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 7
        Me.MenuItem30.Text = "Danh mục nghề nghiệp"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 8
        Me.MenuItem31.Text = "Danh mục dân tộc"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 9
        Me.MenuItem35.Text = "Danh mục quan hệ"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 10
        Me.MenuItem37.Text = "Danh mục tình trạng bệnh nhân"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 11
        Me.MenuItem17.Text = "Danh mục phòng ban"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 12
        Me.MenuItem9.Text = "Cập nhật giá dịch vụ"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 13
        Me.MenuItem53.Text = "Danh mục ghi chú"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 14
        Me.MenuItem77.Text = "Danh mục đối tượng bệnh nhân"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 15
        Me.MenuItem15.Text = "Danh mục liều dùng"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 16
        Me.MenuItem11.Text = "Danh mục đơn thuốc theo mã bệnh"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 17
        Me.MenuItem29.Text = "Danh mục định mức BHYT"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 18
        Me.MenuItem38.Text = "Đơn thuốc mẫu"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem114, Me.d2, Me.MenuItem115, Me.d3, Me.Menu_KHAM_TKphieudk, Me.d4, Me.MenuItem5, Me.d13, Me.MenuItem18, Me.MenuItem33})
        Me.MenuItem2.Text = "QL KHÁM BỆNH"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 0
        Me.MenuItem114.Text = "Danh sách bệnh nhân"
        '
        'd2
        '
        Me.d2.Index = 1
        Me.d2.Text = "-"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 2
        Me.MenuItem115.Text = "Tiếp đón bệnh nhân"
        '
        'd3
        '
        Me.d3.Index = 3
        Me.d3.Text = "-"
        '
        'Menu_KHAM_TKphieudk
        '
        Me.Menu_KHAM_TKphieudk.Index = 4
        Me.Menu_KHAM_TKphieudk.Text = "Thống kê phiếu khám"
        '
        'd4
        '
        Me.d4.Index = 5
        Me.d4.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "Tổng hợp lịch sử bệnh nhân"
        '
        'd13
        '
        Me.d13.Index = 7
        Me.d13.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 8
        Me.MenuItem18.Text = "Lập phiếu khám"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 9
        Me.MenuItem33.Text = "Thống kê dịch vụ thực hiện"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 3
        Me.MenuItem129.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem139, Me.d9, Me.MenuItem140})
        Me.MenuItem129.Text = "QL SIÊU ÂM"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 0
        Me.MenuItem139.Text = "Phiếu siêu âm"
        '
        'd9
        '
        Me.d9.Index = 1
        Me.d9.Text = "-"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 2
        Me.MenuItem140.Text = "Thống kê phiêu siêu âm"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 4
        Me.MenuItem119.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem59, Me.MenuItem60, Me.MenuItem124})
        Me.MenuItem119.Text = "QL XÉT NGHIỆM"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 0
        Me.MenuItem59.Text = "Phiếu xét nghiệm"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 1
        Me.MenuItem60.Text = "-"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 2
        Me.MenuItem124.Text = "Thống kê phiếu xét nghiệm"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 5
        Me.MenuItem141.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem142, Me.MenuItem45, Me.MenuItem143})
        Me.MenuItem141.Text = "QL X QUANG - CT"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 0
        Me.MenuItem142.Text = "Phiếu chụp X Quang - CT"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 1
        Me.MenuItem45.Text = "-"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 2
        Me.MenuItem143.Text = "Thống kê phiếu X Quang - CT"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 6
        Me.MenuItem144.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem145, Me.MenuItem46, Me.MenuItem146})
        Me.MenuItem144.Text = "QL ĐIỆN TIM"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 0
        Me.MenuItem145.Text = "Phiếu điện tim"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        Me.MenuItem46.Text = "-"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 2
        Me.MenuItem146.Text = "Thống kê phiếu điện tim"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 7
        Me.MenuItem147.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem73, Me.MenuItem49, Me.MenuItem149})
        Me.MenuItem147.Text = "QL NỘI SOI"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 0
        Me.MenuItem73.Text = "Phiếu nội soi"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 1
        Me.MenuItem49.Text = "-"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 2
        Me.MenuItem149.Text = "Thống kê phiếu nội soi"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 8
        Me.MenuItem150.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem151, Me.MenuItem50, Me.MenuItem152, Me.MenuItem47, Me.MenuItem153})
        Me.MenuItem150.Text = "QUẢN LÝ PTTT"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 0
        Me.MenuItem151.Text = "Phiếu thủ thuật"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 1
        Me.MenuItem50.Text = "-"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 2
        Me.MenuItem152.Text = "Phiếu phẫu thuật"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 3
        Me.MenuItem47.Text = "-"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 4
        Me.MenuItem153.Text = "Thống kê phiếu thủ thuật PT"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 9
        Me.MenuItem27.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem32})
        Me.MenuItem27.Text = "QL BHYT"
        Me.MenuItem27.Visible = False
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Text = "Giám định BHYT"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "Tổng hợp chi phí KCB bảo hiểm ngoại trú"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 10
        Me.MenuItem39.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem54, Me.d10, Me.Menu_phieuthu, Me.Menu_PhieuchiTM, Me.Menu_thuchi_TKephieuthuchi, Me.d11, Me.Menu_thuchi_TonquyDK, Me.Menu_thuchi_TonquyTC, Me.d12, Me.MenuItem14})
        Me.MenuItem39.Text = "QL THU CHI"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 0
        Me.MenuItem54.Text = "Thu tiền dịch vụ"
        '
        'd10
        '
        Me.d10.Index = 1
        Me.d10.Text = "-"
        '
        'Menu_phieuthu
        '
        Me.Menu_phieuthu.Index = 2
        Me.Menu_phieuthu.Text = "Phiếu thu tiền mặt"
        '
        'Menu_PhieuchiTM
        '
        Me.Menu_PhieuchiTM.Index = 3
        Me.Menu_PhieuchiTM.Text = "Phiếu chi tiền mặt"
        '
        'Menu_thuchi_TKephieuthuchi
        '
        Me.Menu_thuchi_TKephieuthuchi.Index = 4
        Me.Menu_thuchi_TKephieuthuchi.Text = "Thống kê phiếu thu chi"
        '
        'd11
        '
        Me.d11.Index = 5
        Me.d11.Text = "-"
        '
        'Menu_thuchi_TonquyDK
        '
        Me.Menu_thuchi_TonquyDK.Index = 6
        Me.Menu_thuchi_TonquyDK.Text = "Nhập tồn quỹ đầu kỳ"
        '
        'Menu_thuchi_TonquyTC
        '
        Me.Menu_thuchi_TonquyTC.Index = 7
        Me.Menu_thuchi_TonquyTC.Text = "Thống kê tồn quỹ"
        '
        'd12
        '
        Me.d12.Index = 8
        Me.d12.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 9
        Me.MenuItem14.Text = "Thống kê công nợ"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 11
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_THUOC_Nhapthuoc, Me.MenuItem68, Me.Menu_Thuoc_thongkephieunhap, Me.Menu_duong5, Me.Menuxuatthuoc, Me.MenuItem22, Me.MenuItem36, Me.MenuItem12, Me.Menu_THUOC_TKXnhap, Me.MenuItem25, Me.MenuItem7, Me.MenuItem4, Me.MenuItem82, Me.MenuItem62, Me.MenuItem64, Me.MenuItem65, Me.MenuItem63, Me.MenuItem66, Me.Menu_THUOC_TonkhothuocBHXH, Me.MenuItem79, Me.MenuItem67, Me.MenuItem34})
        Me.MenuItem24.Text = "QL THUỐC"
        '
        'Menu_THUOC_Nhapthuoc
        '
        Me.Menu_THUOC_Nhapthuoc.Index = 0
        Me.Menu_THUOC_Nhapthuoc.Text = "Nhập thuốc"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 1
        Me.MenuItem68.Text = "Nhập vật tư tiêu hao"
        '
        'Menu_Thuoc_thongkephieunhap
        '
        Me.Menu_Thuoc_thongkephieunhap.Index = 2
        Me.Menu_Thuoc_thongkephieunhap.Text = "Thống kê phiếu nhập thuốc"
        '
        'Menu_duong5
        '
        Me.Menu_duong5.Index = 3
        Me.Menu_duong5.Text = "-"
        '
        'Menuxuatthuoc
        '
        Me.Menuxuatthuoc.Index = 4
        Me.Menuxuatthuoc.Text = "Xuất bán thuốc"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 5
        Me.MenuItem22.Text = "Xuất hủy thuốc"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 6
        Me.MenuItem36.Text = "Phiếu trả hàng"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 7
        Me.MenuItem12.Text = "-"
        '
        'Menu_THUOC_TKXnhap
        '
        Me.Menu_THUOC_TKXnhap.Index = 8
        Me.Menu_THUOC_TKXnhap.Text = "Thống kê phiếu xuất thuốc"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 9
        Me.MenuItem25.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "Kê đơn thuốc"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 11
        Me.MenuItem4.Text = "Thống kê kê đơn thuốc"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 12
        Me.MenuItem82.Text = "-"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 13
        Me.MenuItem62.Text = "Xuất VTTH - Thuốc cho phòng ban"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 14
        Me.MenuItem64.Text = "TK xuất VTTH - Thuốc cho phòng ban"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 15
        Me.MenuItem65.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 16
        Me.MenuItem63.Text = "TK xuất - nhập VTTH,Thuốc phòng ban"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 17
        Me.MenuItem66.Text = "-"
        '
        'Menu_THUOC_TonkhothuocBHXH
        '
        Me.Menu_THUOC_TonkhothuocBHXH.Index = 18
        Me.Menu_THUOC_TonkhothuocBHXH.Text = "Thống kê tồn kho thuốc"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 19
        Me.MenuItem79.Text = "Thống kê tồn kho vật tư"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 20
        Me.MenuItem67.Text = "Thống kê tồn kho VTTH các phòng CLS"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 21
        Me.MenuItem34.Text = "Thống kê hạn sử dụng thuốc"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 12
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem61, Me.MenuItem56, Me.MenuItem13, Me.MenuItem76, Me.MenuItem78, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem23})
        Me.MenuItem6.Text = "BÁO CÁO"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Text = "Báo cáo doanh thu tổng hợp"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 1
        Me.MenuItem61.Text = "Báo cáo doanh thu theo phòng"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 2
        Me.MenuItem56.Text = "Báo cáo doanh thu theo bệnh nhân"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "-"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 4
        Me.MenuItem76.Text = "Báo cáo hạn sử dụng thuốc"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 5
        Me.MenuItem78.Text = "Báo cáo chi tiết xuất nhập thuốc"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 7
        Me.MenuItem20.Text = "Báo cáo BHYT 20"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 8
        Me.MenuItem21.Text = "Báo cáo BHYT 21"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 9
        Me.MenuItem23.Text = "Báo cáo BHYT 79"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 13
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuHDSD})
        Me.MenuItem8.ShowShortcut = False
        Me.MenuItem8.Text = "HDSD"
        '
        'MenuHDSD
        '
        Me.MenuHDSD.Index = 0
        Me.MenuHDSD.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuHDSD.Text = "Hướng dẫn SD"
        Me.MenuHDSD.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "")
        Me.ImageList1.Images.SetKeyName(19, "")
        Me.ImageList1.Images.SetKeyName(20, "")
        Me.ImageList1.Images.SetKeyName(21, "")
        Me.ImageList1.Images.SetKeyName(22, "")
        Me.ImageList1.Images.SetKeyName(23, "")
        Me.ImageList1.Images.SetKeyName(24, "")
        Me.ImageList1.Images.SetKeyName(25, "")
        Me.ImageList1.Images.SetKeyName(26, "")
        Me.ImageList1.Images.SetKeyName(27, "")
        Me.ImageList1.Images.SetKeyName(28, "")
        Me.ImageList1.Images.SetKeyName(29, "")
        Me.ImageList1.Images.SetKeyName(30, "")
        Me.ImageList1.Images.SetKeyName(31, "")
        Me.ImageList1.Images.SetKeyName(32, "books-stack.png")
        Me.ImageList1.Images.SetKeyName(33, "11.png")
        Me.ImageList1.Images.SetKeyName(34, "14.png")
        Me.ImageList1.Images.SetKeyName(35, "21.png")
        Me.ImageList1.Images.SetKeyName(36, "23.png")
        Me.ImageList1.Images.SetKeyName(37, "30.png")
        Me.ImageList1.Images.SetKeyName(38, "31.png")
        Me.ImageList1.Images.SetKeyName(39, "add-user.png")
        Me.ImageList1.Images.SetKeyName(40, "CAB.png")
        Me.ImageList1.Images.SetKeyName(41, "calendar.png")
        Me.ImageList1.Images.SetKeyName(42, "exet.ru (42).png")
        Me.ImageList1.Images.SetKeyName(43, "home.png")
        Me.ImageList1.Images.SetKeyName(44, "ICON_Thông báo.ico")
        Me.ImageList1.Images.SetKeyName(45, "inbox-document.png")
        Me.ImageList1.Images.SetKeyName(46, "inbox-document-text.png")
        Me.ImageList1.Images.SetKeyName(47, "Mes Documents.ico")
        Me.ImageList1.Images.SetKeyName(48, "Notepad.ico")
        Me.ImageList1.Images.SetKeyName(49, "Panel Settings.ico")
        Me.ImageList1.Images.SetKeyName(50, "store.png")
        Me.ImageList1.Images.SetKeyName(51, "user.png")
        Me.ImageList1.Images.SetKeyName(52, "Winrar.ico")
        Me.ImageList1.Images.SetKeyName(53, "URBAN MSN1.png")
        Me.ImageList1.Images.SetKeyName(54, "URBAN MSN2.png")
        Me.ImageList1.Images.SetKeyName(55, "people.ico")
        Me.ImageList1.Images.SetKeyName(56, "Alpha Dista Icon 81.ico")
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.Name = "StatusBarPanel5"
        Me.StatusBarPanel5.Width = 178
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "Phần mềm Thông báo "
        Me.StatusBarPanel3.Width = 145
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Text = "Phiên bản 1.0.010608"
        Me.StatusBarPanel4.Width = 150
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Bản quyền thuộc công ty Thông báo"
        Me.StatusBarPanel1.Width = 240
        '
        'StatusBarPanel6
        '
        Me.StatusBarPanel6.Name = "StatusBarPanel6"
        Me.StatusBarPanel6.Text = "Tel:043540738 - Mobi:0912841157"
        Me.StatusBarPanel6.Width = 220
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "Website: http://www.Thông báo.vn"
        Me.StatusBarPanel2.Width = 319
        '
        'NavBarControl2
        '
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup5
        Me.NavBarControl2.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl2.DragDropFlags = CType(((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop) _
            Or DevExpress.XtraNavBar.NavBarDragDrop.AllowOuterDrop), DevExpress.XtraNavBar.NavBarDragDrop)
        Me.NavBarControl2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NavBarControl2.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup5, Me.NavBarGroup6})
        Me.NavBarControl2.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBar_KB_tkphieukham, Me.NavBar_THUCHI_THONGKE, Me.NavBar_THUCHI_TONQUY, Me.NavBar_sieuam, Me.NavBar_noisoi, Me.NavBar_XQ, Me.NavBar_dientim, Me.NavBar_XN, Me.NavBar_kham, Me.NavBar_PTTT, Me.NavBar_TiepDon, Me.NavBar_THUTIEN_DICHVU})
        Me.NavBarControl2.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl2.LookAndFeel.UseWindowsXPTheme = True
        Me.NavBarControl2.Name = "NavBarControl2"
        Me.NavBarControl2.OptionsNavPane.ExpandedWidth = 250
        Me.NavBarControl2.Size = New System.Drawing.Size(250, 350)
        Me.NavBarControl2.SmallImages = Me.ImageList1
        Me.NavBarControl2.TabIndex = 21
        Me.NavBarControl2.Text = "NavBarControl2"
        Me.NavBarControl2.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Caramel")
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup5.Appearance.Options.UseFont = True
        Me.NavBarGroup5.Caption = "DSBN CHỜ KHÁM"
        Me.NavBarGroup5.Expanded = True
        Me.NavBarGroup5.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
        Me.NavBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_TiepDon), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_kham), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_XN), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_sieuam), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_noisoi), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_XQ), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_dientim), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_PTTT)})
        Me.NavBarGroup5.Name = "NavBarGroup5"
        Me.NavBarGroup5.TopVisibleLinkIndex = 1
        '
        'NavBar_TiepDon
        '
        Me.NavBar_TiepDon.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_TiepDon.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_TiepDon.Appearance.Options.UseFont = True
        Me.NavBar_TiepDon.Appearance.Options.UseForeColor = True
        Me.NavBar_TiepDon.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_TiepDon.AppearanceDisabled.Options.UseFont = True
        Me.NavBar_TiepDon.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_TiepDon.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_TiepDon.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_TiepDon.AppearancePressed.Options.UseFont = True
        Me.NavBar_TiepDon.Caption = "TIẾP ĐÓN"
        Me.NavBar_TiepDon.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_TiepDon.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_TiepDon.Name = "NavBar_TiepDon"
        '
        'NavBar_kham
        '
        Me.NavBar_kham.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_kham.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_kham.Appearance.Options.UseFont = True
        Me.NavBar_kham.Appearance.Options.UseForeColor = True
        Me.NavBar_kham.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_kham.AppearanceDisabled.ForeColor = System.Drawing.Color.White
        Me.NavBar_kham.AppearanceDisabled.Options.UseFont = True
        Me.NavBar_kham.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_kham.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.NavBar_kham.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_kham.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_kham.AppearancePressed.Options.UseFont = True
        Me.NavBar_kham.Caption = "KHÁM BỆNH"
        Me.NavBar_kham.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_kham.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_kham.ImageOptions.SmallImageIndex = 42
        Me.NavBar_kham.Name = "NavBar_kham"
        '
        'NavBar_XN
        '
        Me.NavBar_XN.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_XN.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_XN.Appearance.Options.UseFont = True
        Me.NavBar_XN.Appearance.Options.UseForeColor = True
        Me.NavBar_XN.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent
        Me.NavBar_XN.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_XN.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_XN.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_XN.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_XN.AppearancePressed.Options.UseFont = True
        Me.NavBar_XN.Caption = "XÉT NGHIỆM"
        Me.NavBar_XN.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_XN.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_XN.ImageOptions.SmallImageIndex = 53
        Me.NavBar_XN.Name = "NavBar_XN"
        '
        'NavBar_sieuam
        '
        Me.NavBar_sieuam.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_sieuam.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_sieuam.Appearance.Options.UseFont = True
        Me.NavBar_sieuam.Appearance.Options.UseForeColor = True
        Me.NavBar_sieuam.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent
        Me.NavBar_sieuam.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_sieuam.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_sieuam.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_sieuam.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_sieuam.AppearancePressed.Options.UseFont = True
        Me.NavBar_sieuam.Caption = "SIÊU ÂM"
        Me.NavBar_sieuam.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_sieuam.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_sieuam.ImageOptions.SmallImageIndex = 54
        Me.NavBar_sieuam.Name = "NavBar_sieuam"
        '
        'NavBar_noisoi
        '
        Me.NavBar_noisoi.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_noisoi.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_noisoi.Appearance.Options.UseFont = True
        Me.NavBar_noisoi.Appearance.Options.UseForeColor = True
        Me.NavBar_noisoi.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent
        Me.NavBar_noisoi.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_noisoi.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_noisoi.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_noisoi.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_noisoi.AppearancePressed.Options.UseFont = True
        Me.NavBar_noisoi.Caption = "NỘI SOI"
        Me.NavBar_noisoi.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_noisoi.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_noisoi.ImageOptions.SmallImageIndex = 55
        Me.NavBar_noisoi.Name = "NavBar_noisoi"
        '
        'NavBar_XQ
        '
        Me.NavBar_XQ.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_XQ.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_XQ.Appearance.Options.UseFont = True
        Me.NavBar_XQ.Appearance.Options.UseForeColor = True
        Me.NavBar_XQ.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent
        Me.NavBar_XQ.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_XQ.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_XQ.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_XQ.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_XQ.AppearancePressed.Options.UseFont = True
        Me.NavBar_XQ.Caption = "CHỤP X QUANG - CT"
        Me.NavBar_XQ.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_XQ.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_XQ.ImageOptions.SmallImageIndex = 56
        Me.NavBar_XQ.Name = "NavBar_XQ"
        '
        'NavBar_dientim
        '
        Me.NavBar_dientim.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_dientim.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_dientim.Appearance.Options.UseFont = True
        Me.NavBar_dientim.Appearance.Options.UseForeColor = True
        Me.NavBar_dientim.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent
        Me.NavBar_dientim.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_dientim.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_dientim.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_dientim.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_dientim.AppearancePressed.Options.UseFont = True
        Me.NavBar_dientim.Caption = "ĐIỆN TIM"
        Me.NavBar_dientim.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_dientim.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_dientim.ImageOptions.SmallImageIndex = 51
        Me.NavBar_dientim.Name = "NavBar_dientim"
        '
        'NavBar_PTTT
        '
        Me.NavBar_PTTT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_PTTT.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_PTTT.Appearance.Options.UseFont = True
        Me.NavBar_PTTT.Appearance.Options.UseForeColor = True
        Me.NavBar_PTTT.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent
        Me.NavBar_PTTT.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_PTTT.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_PTTT.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_PTTT.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_PTTT.AppearancePressed.Options.UseFont = True
        Me.NavBar_PTTT.Caption = "THỦ THUẬT - PHẪU THUẬT"
        Me.NavBar_PTTT.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_PTTT.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_PTTT.ImageOptions.SmallImageIndex = 53
        Me.NavBar_PTTT.Name = "NavBar_PTTT"
        '
        'NavBarGroup6
        '
        Me.NavBarGroup6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.NavBarGroup6.Appearance.Options.UseFont = True
        Me.NavBarGroup6.Caption = "QUẢN LÝ THU CHI"
        Me.NavBarGroup6.Expanded = True
        Me.NavBarGroup6.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
        Me.NavBarGroup6.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_THUTIEN_DICHVU), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_THUCHI_THONGKE), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBar_THUCHI_TONQUY)})
        Me.NavBarGroup6.Name = "NavBarGroup6"
        '
        'NavBar_THUTIEN_DICHVU
        '
        Me.NavBar_THUTIEN_DICHVU.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUTIEN_DICHVU.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUTIEN_DICHVU.Appearance.Options.UseFont = True
        Me.NavBar_THUTIEN_DICHVU.Appearance.Options.UseForeColor = True
        Me.NavBar_THUTIEN_DICHVU.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUTIEN_DICHVU.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUTIEN_DICHVU.AppearanceDisabled.Options.UseFont = True
        Me.NavBar_THUTIEN_DICHVU.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_THUTIEN_DICHVU.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUTIEN_DICHVU.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUTIEN_DICHVU.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_THUTIEN_DICHVU.AppearanceHotTracked.Options.UseForeColor = True
        Me.NavBar_THUTIEN_DICHVU.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUTIEN_DICHVU.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUTIEN_DICHVU.AppearancePressed.Options.UseFont = True
        Me.NavBar_THUTIEN_DICHVU.AppearancePressed.Options.UseForeColor = True
        Me.NavBar_THUTIEN_DICHVU.Caption = "THU TIỀN DỊCH VỤ"
        Me.NavBar_THUTIEN_DICHVU.ImageOptions.SmallImage = Global.MEDICAL.My.Resources.Resources.profilereport_16x16
        Me.NavBar_THUTIEN_DICHVU.Name = "NavBar_THUTIEN_DICHVU"
        '
        'NavBar_THUCHI_THONGKE
        '
        Me.NavBar_THUCHI_THONGKE.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_THUCHI_THONGKE.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUCHI_THONGKE.Appearance.Options.UseFont = True
        Me.NavBar_THUCHI_THONGKE.Appearance.Options.UseForeColor = True
        Me.NavBar_THUCHI_THONGKE.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUCHI_THONGKE.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUCHI_THONGKE.AppearanceDisabled.Options.UseFont = True
        Me.NavBar_THUCHI_THONGKE.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_THUCHI_THONGKE.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUCHI_THONGKE.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_THUCHI_THONGKE.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUCHI_THONGKE.AppearancePressed.Options.UseFont = True
        Me.NavBar_THUCHI_THONGKE.Caption = "THỐNG KÊ PHIẾU THU CHI"
        Me.NavBar_THUCHI_THONGKE.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_THUCHI_THONGKE.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_THUCHI_THONGKE.ImageOptions.SmallImageIndex = 35
        Me.NavBar_THUCHI_THONGKE.Name = "NavBar_THUCHI_THONGKE"
        '
        'NavBar_THUCHI_TONQUY
        '
        Me.NavBar_THUCHI_TONQUY.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBar_THUCHI_TONQUY.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUCHI_TONQUY.Appearance.Options.UseFont = True
        Me.NavBar_THUCHI_TONQUY.Appearance.Options.UseForeColor = True
        Me.NavBar_THUCHI_TONQUY.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent
        Me.NavBar_THUCHI_TONQUY.AppearanceDisabled.Options.UseForeColor = True
        Me.NavBar_THUCHI_TONQUY.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUCHI_TONQUY.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBar_THUCHI_TONQUY.AppearanceHotTracked.Options.UseFont = True
        Me.NavBar_THUCHI_TONQUY.AppearanceHotTracked.Options.UseForeColor = True
        Me.NavBar_THUCHI_TONQUY.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.NavBar_THUCHI_TONQUY.AppearancePressed.Options.UseFont = True
        Me.NavBar_THUCHI_TONQUY.Caption = "THỐNG KÊ TỒN QUỸ"
        Me.NavBar_THUCHI_TONQUY.ImageOptions.SmallImage = CType(resources.GetObject("NavBar_THUCHI_TONQUY.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.NavBar_THUCHI_TONQUY.ImageOptions.SmallImageIndex = 36
        Me.NavBar_THUCHI_TONQUY.Name = "NavBar_THUCHI_TONQUY"
        '
        'NavBar_KB_tkphieukham
        '
        Me.NavBar_KB_tkphieukham.Caption = "Thống kê phiếu khám"
        Me.NavBar_KB_tkphieukham.Name = "NavBar_KB_tkphieukham"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.BarStaticItem3, Me.BarStaticItem6})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Bar3.BarAppearance.Normal.Options.UseFont = True
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem6)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "PHẦN MỀM PHÒNG KHÁM ĐA KHOA"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "TEL: 0243.2115.388 - HOTLINE: 0964.673.592 - WEB: stdvietnam.vn"
        Me.BarStaticItem3.Id = 2
        Me.BarStaticItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'BarStaticItem6
        '
        Me.BarStaticItem6.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.BarStaticItem6.Caption = "User:                                CSDL:"
        Me.BarStaticItem6.Id = 5
        Me.BarStaticItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.BarStaticItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem6.Name = "BarStaticItem6"
        Me.BarStaticItem6.Size = New System.Drawing.Size(900, 0)
        Me.BarStaticItem6.Width = 900
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(649, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 350)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(649, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 350)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(649, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 350)
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Bản quyền thuộc công ty Thông báo"
        Me.BarStaticItem2.Id = 1
        Me.BarStaticItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.Appearance.Image = Global.MEDICAL.My.Resources.Resources.bg
        Me.XtraTabbedMdiManager1.Appearance.Options.UseImage = True
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'DefaultLookAndFeel_Main
        '
        Me.DefaultLookAndFeel_Main.LookAndFeel.SkinName = "Caramel"
        '
        'form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(649, 379)
        Me.Controls.Add(Me.NavBarControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLINIC - STD VIỆT NAM "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Caramel" '{"The Asphalt World","Office 2010 Blue"}
        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = False
        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseWindowsXPTheme = False
        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        '====
        'Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        'Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")
        '====
        Dim frmLoginobj As New frmLogin
        frmLoginobj.StartPosition = FormStartPosition.CenterScreen
        Me.AddOwnedForm(frmLoginobj)
        frmLoginobj.ShowDialog()
        Dim clsOject As New ClsLogin
        If clsLoginObj.strUsername <> "" Then
            clsOject.Phan_Quyen(Me)
            PhanQuyen_Menu()
        Else
            Me.Close()
        End If
        Try
            Me.frmDangNhaplai.Visible = True
            Me.MenuHDSD.Visible = True
            Me.MenuThoat.Visible = True
            Me.Menu_duong5.Visible = True
            Me.MenuItem12.Visible = True
            Me.MenuItem16.Visible = True
            Me.MenuHDSD.Visible = False
            Me.d10.Visible = True
            Me.d11.Visible = True
        Catch ex As Exception
        End Try
        Try
            Try
                BarStaticItem6.Caption = "User:" + clsLoginObj.strUsername.ToString()
            Catch ex As Exception

            End Try
            'Timer1.Start()
        Catch ex As Exception

        End Try
        Dim clConnection As New Connection_db.ConnectionInfor()
        clConnection.CnnGet()
        DataAccess.Data.Server = clConnection.Server
        DataAccess.Data.Database = clConnection.Database
        DataAccess.Data.UserID = clConnection.Username
        DataAccess.Data.Password = clConnection.Pasword
        DataAccess.Data.IsWindowAuthenMod = False
    End Sub
#Region "DANH MỤC HỆ THỐNG"

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmNhom_NSD.Click
        Dim frm As New frmNhom_NSD
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmNguoi_SD.Click
        Dim frm As New frmNguoi_SD
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmPhanQuyen.Click
        Dim frm As New frmPhanQuyen
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
        Me.frmDangNhaplai.Enabled = True
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmDangNhaplai.Click
        kiemtra = 0
        Dim frm As New frmLogin
        'Dim frm1 As Form
        frm.Old_Usename = clsLoginObj.strUsername
        frm.ShowDialog()
        Dim clsOject As New ClsLogin
        clsOject.Phan_Quyen(Me)
        PhanQuyen_Menu()
        Me.frmDangNhaplai.Visible = True
        Me.MenuHDSD.Visible = True
        Me.MenuThoat.Visible = True
    End Sub
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim frm As New frmThongKeTruyCap
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub
    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim ClsLoginObj1 As New ClsLogin
        If clsLoginObj.strUsername <> "" Then
            ClsLoginObj1.UpdateGioThoat(clsLoginObj.strUsername, IDGioThoat, 2)
        End If
    End Sub
    Private Sub NBPhanQuyen_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBPhanQuyen.LinkClicked
        Dim frm As New frmPhanQuyen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
        Me.frmDangNhaplai.Enabled = True
    End Sub
    Private Sub NBDangNhaplai_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBDangNhaplai.LinkClicked
        kiemtra = 0
        Dim frm As New frmLogin
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Old_Usename = clsLoginObj.strUsername
        frm.Show()
        Dim clsOject As New ClsLogin
        clsOject.Phan_Quyen(Me)
        Me.frmDangNhaplai.Enabled = True
    End Sub
    Private Sub NBTKTruycap_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBTKTruycap.LinkClicked
        Dim frm As New frmThongKeTruyCap
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub PhanQuyen_Menu()
        Me.NavBar_TiepDon.Visible = False
        Me.NavBar_kham.Visible = False
        Me.NavBar_noisoi.Visible = False
        Me.NavBar_PTTT.Visible = False
        Me.NavBar_sieuam.Visible = False
        Me.NavBar_dientim.Visible = False
        Me.NavBar_XN.Visible = False
        Me.NavBar_XQ.Visible = False

        Me.NavBar_THUTIEN_DICHVU.Visible = False
        Me.NavBar_THUCHI_THONGKE.Visible = False
        Me.NavBar_THUCHI_TONQUY.Visible = False

        If MenuItem115.Visible = True Then
            Me.NavBar_TiepDon.Visible = True
        End If
        If Me.Menu_KHAM_TKphieudk.Visible = True Then
            Me.NavBar_kham.Visible = True
        End If

        If Me.MenuItem149.Visible = True Then
            Me.NavBar_noisoi.Visible = True
        End If
        If Me.MenuItem146.Visible = True Then
            Me.NavBar_dientim.Visible = True
        End If
        If Me.MenuItem153.Visible = True Then
            Me.NavBar_PTTT.Visible = True
        End If
        If Me.MenuItem140.Visible = True Then
            Me.NavBar_sieuam.Visible = True
        End If
        If Me.MenuItem124.Visible = True Then
            Me.NavBar_XN.Visible = True
        End If
        If Me.MenuItem143.Visible = True Then
            Me.NavBar_XQ.Visible = True
        End If

        If Me.MenuItem54.Visible = True Then
            Me.NavBar_THUTIEN_DICHVU.Visible = True
        End If
        If Me.Menu_thuchi_TKephieuthuchi.Visible = True Then
            Me.NavBar_THUCHI_THONGKE.Visible = True
        End If
        If Me.Menu_thuchi_TonquyTC.Visible = True Then
            Me.NavBar_THUCHI_TONQUY.Visible = True
        End If

        Me.d1.Visible = True
        Me.d2.Visible = True
        Me.d3.Visible = True
        Me.d4.Visible = True
        Me.d9.Visible = True
        Me.d10.Visible = True
        Me.d11.Visible = True
        Me.d12.Visible = True
        Me.d13.Visible = True
        'Ẩn đổi mật khẩu
        Me.MenuItem48.Enabled = True
        Me.MenuItem7.Visible = False
    End Sub

    Private Sub MenuThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuThoat.Click
        Me.Close()
    End Sub
#End Region

#Region "ĐỊNH NGHĨA DANH MỤC CHUNG"
    Private Sub Menu_Danhmuc_Benhnhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danhmuc_Benhnhan.Click
        Dim frm As New FRM_DM_BENHNHAN
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_Danhmuc_nghiepvuthuchi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danhmuc_nghiepvuthuchi.Click
        Dim frm As New frmDMThuChi
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_Danhmuc_Quy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danhmuc_Quy.Click
        Dim frm As New frmDMQuy
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_Danhmuc_donvicungcap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danhmuc_donvicungcap.Click
        Dim frm As New frmThemDonVi
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_Danhmuc_khothuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danhmuc_khothuoc.Click
        Dim frm As New frmThemKhoHang
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub
#End Region
    Private Sub Menu_KHAM_TKphieudk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_KHAM_TKphieudk.Click
        Dim frm As New FRMTHONGKEPHIEUKHAM
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_thuchi_TonquyDK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_thuchi_TonquyDK.Click
        Dim frm As New frmTon_quy
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub Menu_thuchi_TKephieuthuchi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_thuchi_TKephieuthuchi.Click
        Dim frm As New frmThongKeTC
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_thuchi_TonquyTC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_thuchi_TonquyTC.Click
        Dim frm As New frmTKTon_quy
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub Menu_THUOC_Nhapthuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_THUOC_Nhapthuoc.Click
        Dim frm As New frmPhieuNHAPKHOTHUOC
        frm.Label12.Text = "Loại nhập"
        frm.blnLoaiphieu = True
        frm.blnType = True
        frm.cmbLoai_xuat.EditValue = "NT"
        frm.CmbKhohang.EditValue = "KT"
        'frm.CmbKhohang.Enabled = False
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_THUOC_TKXnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_THUOC_TKXnhap.Click
        Dim frm As New frmThongkeXN
        frm.cmbKho_hang.EditValue = "KT"
        'frm.cmbKho_hang.Enabled = False
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_THUOC_Tonkhothuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_THUOC_TonkhothuocBHXH.Click
        Dim frm As New frmTKTonKhoKhoaDuoc
        frm.Name = "frmTKtonkho"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_Danhmuc_nhomthuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danhmuc_nhomthuoc.Click
        Dim frm As New frmNhomSP
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_Danhmuc_thuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danhmuc_thuoc.Click
        Dim frm As New frmSanpham
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_Thuoc_thongkephieunhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Thuoc_thongkephieunhap.Click
        Dim frm As New frmThongkephieunhapthuoc
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuHDSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuHDSD.Click
        Try
            Dim HelpProvider1 As New HelpProvider
            Dim strHelpFilePath As String
            HelpProvider1.HelpNamespace = "HDSD.doc"
            strHelpFilePath = Application.StartupPath
            If Microsoft.VisualBasic.Right(strHelpFilePath, 1) <> "\" Then
                strHelpFilePath += "\"
            End If
            strHelpFilePath += HelpProvider1.HelpNamespace
            HelpProvider1.HelpNamespace = strHelpFilePath
            Help.ShowHelp(Me, HelpProvider1.HelpNamespace)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim frm As New Frm_THONGKE_KEDONTHUOC
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menu_PhieuchiTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_PhieuchiTM.Click
        Dim frm As New frmPhieuTC
        frm.Name = "frmChiTienMat"
        frm.Text = "PHIẾU CHI TIỀN MẶT"
        frm.Label3.Text = "PHIẾU CHI TIỀN MẶT"
        frm.lbnQuy.Text = "Chi từ quỹ"
        frm.lblDonvitc.Text = "Đơn vị nhận "
        frm.blnLoaiphieu = False
        frm.blnTiengui = False
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub
    Private Sub Menu_phieuthu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_phieuthu.Click
        Dim frm As New frmPhieuTC
        frm.Name = "frmThuTienMat"
        frm.Text = "PHIẾU THU TIỀN MẶT"
        frm.Label3.Text = "PHIẾU THU TIỀN MẶT"
        frm.lbnQuy.Text = "Thu vào quỹ"
        frm.lblDonvitc.Text = "Đơn vị trả"
        frm.blnLoaiphieu = True
        frm.blnTiengui = False
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub NavBar_kham_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_kham.LinkClicked
        Dim frm As New FRM_DanhsachBN
        frm.StartPosition = FormStartPosition.Manual
        frm.Name = "FRM_DanhsachBN_KCB"
        frm.Text = "DANH SÁCH CHỜ KHÁM-TƯ VẤN"
        frm.LoaiDV = 1
        frm.radChoKetQua.Visible = True
        frm.radChuaKham.Visible = True
        frm.radTatCa.Visible = True
        frm.radDaKham.Visible = True
        frm.cmbphong.Visible = True
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_XN_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_XN.LinkClicked
        Dim frm As New FRM_DanhsachBN
        frm.StartPosition = FormStartPosition.Manual
        frm.Name = "FRM_DanhsachBN_XetNghiem"
        frm.Text = "DANH SÁCH CHỜ XÉT NGHIỆM"
        frm.cmbphong.Visible = False
        frm.LoaiDV = 2
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_sieuam_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_sieuam.LinkClicked
        Dim frm As New FRM_DanhsachBN
        frm.StartPosition = FormStartPosition.Manual
        frm.Name = "FRM_DanhsachBN_SieuAm"
        frm.Text = "DANH SÁCH CHỜ SIÊU ÂM"
        frm.cmbphong.Visible = False
        frm.LoaiDV = 3
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_noisoi_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_noisoi.LinkClicked
        Dim frm As New FRM_DanhsachBN
        frm.StartPosition = FormStartPosition.Manual
        frm.Name = "FRM_DanhsachBN_NoiSoi"
        frm.Text = "DANH SÁCH CHỜ NỘI SOI"
        frm.cmbphong.Visible = False
        frm.LoaiDV = 4
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_XQ_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_XQ.LinkClicked
        Dim frm As New FRM_DanhsachBN
        frm.cmbphong.Visible = False
        frm.StartPosition = FormStartPosition.Manual
        frm.Name = "FRM_DanhsachBN_XQ"
        frm.Text = "DANH SÁCH CHỜ XQUANG"
        frm.LoaiDV = 5
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_dientim_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_dientim.LinkClicked
        Dim frm As New FRM_DanhsachBN
        frm.cmbphong.Visible = False
        frm.StartPosition = FormStartPosition.Manual
        frm.Name = "FRM_DanhsachBN_DienTim"
        frm.Text = "DANH SÁCH CHỜ ĐIỆN TIM"
        frm.LoaiDV = 6
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_PTTT_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_PTTT.LinkClicked
        Dim frm As New FRM_DanhsachBN
        frm.StartPosition = FormStartPosition.Manual
        frm.Name = "FRM_DanhsachBN_PTTT"
        frm.Text = "DANH SÁCH CHỜ PTTT"
        frm.LoaiDV = 7
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Menuxuatthuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menuxuatthuoc.Click
        Dim frm As New frmPhieuXN
        frm.kieuthu = 1
        frm.Name = "frm_xuatbanthuoc"
        frm.Loai = True
        frm.Loaixuat = True
        frm.Text = "PHIẾU XUẤT BÁN THUỐC"
        frm.Label12.Text = "Loại xuất"
        frm.Label21.Text = "PHIẾU XUẤT BÁN THUỐC"
        frm.blnLoaiphieu = False
        frm.cmbLoai_xuat.EditValue = "XB"
        frm.CmbKhohang.EditValue = "KT"
        frm.cmbLoai_xuat.Enabled = False
        frm.blnType = True
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_THUCHI_THONGKE_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_THUCHI_THONGKE.LinkClicked
        Dim frm As New frmThongKeTC
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_THUCHI_TONQUY_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_THUCHI_TONQUY.LinkClicked
        Dim frm As New frmTKTon_quy
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Dim frm As New FRM_DMCHUNG
        frm.Name = "frmdm_nghenghiep"
        frm.Text = "DANH MỤC NGHỀ NGHIỆP"
        frm.loai = Integer.Parse(MdlCommon.DanhMuc.DM_NGHENGHIEP)
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Dim frm As New FRM_DMCHUNG
        frm.Name = "frmdm_dantoc"
        frm.Text = "DANH MỤC DÂN TỘC"
        frm.loai = Integer.Parse(MdlCommon.DanhMuc.DM_DANTOC)
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim frm As New FRM_DMCHUNG
        frm.Name = "frmdm_quanhe"
        frm.Text = "DANH MỤC QUAN HỆ"
        frm.loai = Integer.Parse(MdlCommon.DanhMuc.DM_QUANHE)
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Dim frm As New FRM_DMCHUNG
        frm.Name = "frmdm_ttbn"
        frm.Text = "DANH MỤC TÌNH TRẠNG BỆNH NHÂN"
        frm.loai = Integer.Parse(MdlCommon.DanhMuc.DM_TINHTRANG_BN)
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        Dim frm As New FRM_ThanhToanNhanDan
        frm.Name = "FRM_Thutien"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click
        Dim frm As New FRM_DM_BENHNHAN
        frm.cmbDoiTuong.EditValue = Integer.Parse(MdlCommon.DoiTuong.DICHVU)
        frm.cmbGioi_Tinh.EditValue = Integer.Parse(MdlCommon.GioiTinh.NAM)
        frm.cmbDanToc.EditValue = "K"
        frm.dtNgaySinh.DateTime = New DateTime(1990, 1, 1)
        frm.dtGT_THE_TU.DateTime = New DateTime(Year(DateTime.Now), 1, 1)
        frm.dtGT_THE_DEN.DateTime = New DateTime(Year(DateTime.Now), 12, 31)
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        Dim frm As New FRM_TIEPDONBN
        frm.cmbdoituong.EditValue = Integer.Parse(MdlCommon.DoiTuong.DICHVU)
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click
        Dim frm As New FRMTHONGKEPHIEUDICHVU
        frm.Name = "frmthongkephieuxn"
        frm.cmbloaidv.EditValue = Integer.Parse(MdlCommon.NhomDV.XETNGHIEM).ToString()
        frm.Text = "THỐNG KÊ PHIẾU XÉT NGHIỆM"
        frm.Label28.Text = "THỐNG KÊ PHIẾU XÉT NGHIỆM"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem140.Click
        Dim frm As New FRMTHONGKEPHIEUDICHVU
        frm.Name = "frmtkphieusakhac"
        frm.cmbloaidv.EditValue = Integer.Parse(MdlCommon.NhomDV.SIEUAM).ToString()
        frm.Text = "THỐNG KÊ PHIẾU SIÊU ÂM"
        frm.Label28.Text = "THỐNG KÊ PHIẾU SIÊU ÂM"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        Dim frm As New FRMTHONGKEPHIEUDICHVU
        frm.Name = "frmtkphieuxq"
        frm.cmbloaidv.EditValue = Integer.Parse(MdlCommon.NhomDV.XQUANG).ToString()
        frm.Text = "THỐNG KÊ PHIẾU X QUANG"
        frm.Label28.Text = "THỐNG KÊ PHIẾU X QUANG"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        Dim frm As New FRMTHONGKEPHIEUDICHVU
        frm.Name = "frmtkphieuDT"
        frm.cmbloaidv.EditValue = Integer.Parse(MdlCommon.NhomDV.DIENTIM).ToString()
        frm.Text = "THỐNG KÊ PHIẾU ĐIỆN TIM"
        frm.Label28.Text = "THỐNG KÊ PHIẾU ĐIỆN TIM"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        Dim frm As New FRMTHONGKEPHIEUDICHVU
        frm.Name = "frmtkphieuNS"
        frm.cmbloaidv.EditValue = Integer.Parse(MdlCommon.NhomDV.NOISOI).ToString()
        frm.Text = "THỐNG KÊ PHIẾU NỘI SOI"
        frm.Label28.Text = "THỐNG KÊ PHIẾU NỘI SOI"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem153.Click
        Dim frm As New FRMTHONGKEPHIEUDICHVU
        frm.Name = "frmtkphieuTTPT"
        frm.cmbloaidv.EditValue = Integer.Parse(MdlCommon.NhomDV.TTPT).ToString()
        frm.Text = "THỐNG KÊ PHIẾU TTPT"
        frm.Label28.Text = "THỐNG KÊ PHIẾU TTPT"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        Dim frm As New FRM_KECANLAMSANG
        frm.Name = "frmPhieuSieuam"
        frm.Text = "PHIẾU SIÊU ÂM"
        frm.IDSophieu = "0"
        frm.IDPhieuxuat = 0
        frm.Inidphieugoc = 0
        frm.load_all = False
        frm.suaphieu = False
        'frm.cmbloaixn.EditValue = "SA"
        frm.CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.SIEUAM).ToString()
        frm.cmbnlap.EditValue = clsLoginObj.strUsername
        frm.txtSophieu.Text = 0
        frm.cmbMaBN.EditValue = ""
        frm.DtpNgaylap.EditValue = NgayGioServer()
        frm.Rich_lamsang.Text = ""
        frm.PhongKham = ""
        frm.IsNew = 1
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        Dim frm As New FRM_KECANLAMSANG
        frm.Name = "frmPhieuXQuang_CT"
        frm.Text = "PHIẾU X.QUANG - CT"
        frm.IDSophieu = "0"
        frm.load_all = False
        frm.suaphieu = False
        'frm.cmbloaixn.EditValue = "XQ"
        frm.CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.XQUANG).ToString()
        frm.cmbnlap.EditValue = clsLoginObj.strUsername
        frm.txtSophieu.Text = 0
        frm.cmbMaBN.EditValue = ""
        frm.DtpNgaylap.EditValue = NgayGioServer()
        frm.IDPhieuxuat = 0
        frm.Rich_lamsang.Text = ""
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.IsNew = 1
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        Dim frm As New FRM_KECANLAMSANG
        frm.Name = "Frm_PhieuDienTim"
        frm.Text = "PHIẾU ĐIỆN TIM"
        frm.IDSophieu = "0"
        frm.load_all = False
        frm.suaphieu = False
        'frm.cmbloaixn.EditValue = "DT"
        frm.CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.DIENTIM).ToString()
        frm.cmbnlap.EditValue = clsLoginObj.strUsername
        frm.txtSophieu.Text = 0
        frm.cmbMaBN.EditValue = ""
        frm.DtpNgaylap.EditValue = NgayGioServer()
        frm.IDPhieuxuat = 0
        frm.Rich_lamsang.Text = ""
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.IsNew = 1
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem151.Click
        Dim frm As New FRM_KECANLAMSANG
        frm.Name = "frmThuThuat"
        frm.Text = "PHIẾU THỦ THUẬT"
        frm.IDSophieu = "0"
        frm.load_all = False
        frm.suaphieu = False
        frm.cmbloaixn.EditValue = "TT"
        frm.CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.TTPT).ToString()
        frm.cmbnlap.EditValue = clsLoginObj.strUsername
        frm.txtSophieu.Text = 0
        frm.cmbMaBN.EditValue = ""
        frm.DtpNgaylap.EditValue = NgayGioServer()
        frm.IDPhieuxuat = 0
        frm.Rich_lamsang.Text = ""
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.IsNew = 1
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem152.Click
        Dim frm As New FRM_KECANLAMSANG
        frm.Name = "frmPhauThuat"
        frm.Text = "PHIẾU PHẨU THUẬT"
        frm.IDSophieu = "0"
        frm.load_all = False
        frm.suaphieu = False
        frm.cmbloaixn.EditValue = "PT"
        frm.CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.TTPT).ToString()
        frm.cmbnlap.EditValue = clsLoginObj.strUsername
        frm.txtSophieu.Text = 0
        frm.cmbMaBN.EditValue = ""
        frm.DtpNgaylap.EditValue = NgayGioServer()
        frm.IDPhieuxuat = 0
        frm.Rich_lamsang.Text = ""
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.IsNew = 1
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem17_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Dim frm As New frmPhongBan
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim frm As New frm_LichSuBenhNhan
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim frm As New frmPhieuXN
        frm.kieuthu = 2
        frm.Name = "frm_xuathuythuoc"
        frm.Loai = True
        frm.Loaixuat = True
        frm.Text = "PHIẾU XUẤT HỦY THUỐC"
        frm.Label12.Text = "Loại xuất"
        frm.Label21.Text = "PHIẾU XUẤT HỦY THUỐC"
        frm.blnLoaiphieu = False
        frm.cmbLoai_xuat.EditValue = "XH"
        frm.CmbKhohang.EditValue = "KT"
        frm.cmbLoai_xuat.Enabled = False
        frm.blnType = True
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim frm As New frm_baocaothanhtoan
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim frm As New frmCapNhatGia
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        Dim frm As New frmDoiMK
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms 'MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        'frm.MdiParent = Me
        frm.ShowDialog()
        If frm.isClose Then
            Me.RemoveOwnedForm(frm)
        End If
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Dim frm As New frmDMGhiChu
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
        'Dim frm As New FRM_DMNHOMTHUOC
        'frm.StartPosition = FormStartPosition.CenterScreen
        'Dim frm1 As Form
        'For Each frm1 In Me.OwnedForms
        '    If (frm1.Name = frm.Name) Then
        '        frm1.Activate()
        '        Exit Sub
        '    End If
        'Next
        'Me.AddOwnedForm(frm)
        'frm.Show()
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        Dim frm As New frm_Tonghopthuchi
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        Dim frm As New FRM_KECANLAMSANG
        frm.Name = "frmPhieuxetnghiem"
        frm.Text = "PHIẾU XÉT NGHIỆM"
        frm.IDSophieu = "0"
        frm.load_all = False
        frm.suaphieu = False
        'frm.cmbloaixn.EditValue = "XN"
        frm.CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.XETNGHIEM).ToString()
        frm.cmbnlap.EditValue = clsLoginObj.strUsername
        frm.txtSophieu.Text = 0
        frm.cmbMaBN.EditValue = ""
        frm.DtpNgaylap.EditValue = NgayGioServer()
        frm.IDPhieuxuat = 0
        frm.Rich_lamsang.Text = ""
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.IsNew = 1
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        Dim frm As New frm_bcdoanhthuchitiet
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        Dim frm As New frmPhieuxuatnoibo
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        Dim frm As New frmtkxnnoibo
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        Dim frm As New frmTKTonKhoCLS
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Dim frm As New frmThongkexuatnoibo
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        Dim frm As New frmPhieuNHAPKHOTHUOC
        frm.Name = "frmPhieunhapvtth"
        Dim frm1 As Form
        frm.Label12.Text = "Loại nhập"
        frm.blnLoaiphieu = True
        frm.cmbLoai_xuat.EditValue = "NVT"
        frm.blnType = True
        frm.CmbKhohang.EditValue = "KVT"
        frm.StartPosition = FormStartPosition.CenterScreen
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim frm As New frm_kedonthuoc
        frm.BS = True
        frm.LoaiPhieu = 0
        frm.txtSophieukham.Text = -1
        frm.CmbKhohang.EditValue = "KT"
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.blnType = True
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        Dim frm As New FRM_KECANLAMSANG
        frm.Name = "frmnoisoikhac"
        frm.Text = "PHIẾU NỘI SOI"
        frm.IDSophieu = "0"
        frm.load_all = False
        frm.suaphieu = False
        'frm.cmbloaixn.EditValue = "NS"
        frm.CmbManhom.EditValue = Integer.Parse(MdlCommon.NhomDV.NOISOI).ToString()
        frm.cmbnlap.EditValue = clsLoginObj.strUsername
        frm.txtSophieu.Text = 0
        frm.cmbMaBN.EditValue = ""
        frm.DtpNgaylap.EditValue = NgayGioServer()
        frm.IDPhieuxuat = 0
        frm.Rich_lamsang.Text = ""
        frm.PhongKham = ""
        frm.Inidphieugoc = 0
        frm.IsNew = 1
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim frm As New frmThongKeCongNo
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Dim frm As New frmBackup_Retore_DB
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        Dim frm As New frm_DMDoituong
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        Dim frm As New frm_Baocaohansudungthuoc
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        Dim frm As New frmBaocaochitietxuatnhap
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        Dim frm As New FRM_TKTonkhovatu
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Dim frm As New frmDMLieudung
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim frm As New FRM_PhieuKham
        frm.Flag = True
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim frm As New frm_DanhMuc_MaBenh
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NavBar_TiepDon_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_TiepDon.LinkClicked
        Dim frm As New FRM_TIEPDONBN
        frm.cmbdoituong.EditValue = 3
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem28_Click(sender As Object, e As EventArgs) Handles MenuItem28.Click
        Dim frm As New FRM_GIAMDINHBAOHIEM
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem29_Click(sender As Object, e As EventArgs) Handles MenuItem29.Click
        Dim frm As New frmDinhMucBHYT
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem32_Click(sender As Object, e As EventArgs) Handles MenuItem32.Click
        Dim frm As New FRM_TONGCHIPHI_KCB_BHYT_NT
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem33_Click(sender As Object, e As EventArgs) Handles MenuItem33.Click
        Dim frm As New FRM_CANLAMSANG
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In MdiChildren 'Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        'Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem36_Click(sender As Object, e As EventArgs) Handles MenuItem36.Click
        Dim frm As New frmPhieuDoiTra
        frm.kieuthu = 1
        frm.Loai = True
        frm.Loaixuat = True
        frm.Text = "PHIẾU ĐỔI HÀNG"
        frm.Label12.Text = "Loại xuất"
        frm.Label21.Text = "PHIẾU ĐỔI HÀNG"
        frm.blnLoaiphieu = False
        frm.cmbLoai_xuat.EditValue = "XB"
        frm.CmbKhohang.EditValue = "KT"
        frm.cmbLoai_xuat.Enabled = False
        frm.blnType = True
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub MenuItem38_Click(sender As Object, e As EventArgs) Handles MenuItem38.Click
        Dim frm As New frmDonThuocMau
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub NavBar_THUTIEN_DICHVU_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_THUTIEN_DICHVU.LinkClicked
        Dim frm As New FRM_ThanhToanNhanDan
        frm.Name = "FRM_Thutien"
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim frm1 As Form
        For Each frm1 In Me.OwnedForms
            If (frm1.Name = frm.Name) Then
                frm1.Activate()
                Exit Sub
            End If
        Next
        Me.AddOwnedForm(frm)
        frm.Show()
    End Sub
End Class