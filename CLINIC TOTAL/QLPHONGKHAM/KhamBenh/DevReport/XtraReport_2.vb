Public Class XtraReport_2

    Public Property ImgSource1() As String
        Get
            Return m_ImgSource1
        End Get
        Set(ByVal value As String)
            m_ImgSource1 = value
        End Set
    End Property
    Private m_ImgSource1 As String

    Public Property ImgSource2() As String
        Get
            Return m_ImgSource2
        End Get
        Set(ByVal value As String)
            m_ImgSource2 = value
        End Set
    End Property
    Private m_ImgSource2 As String

    Public Property ImgSource3() As String
        Get
            Return m_ImgSource3
        End Get
        Set(ByVal value As String)
            m_ImgSource3 = value
        End Set
    End Property
    Private m_ImgSource3 As String

    Public Property ImgSource4() As String
        Get
            Return m_ImgSource4
        End Get
        Set(ByVal value As String)
            m_ImgSource4 = value
        End Set
    End Property
    Private m_ImgSource4 As String

    Public Property ImgSource5() As String
        Get
            Return m_ImgSource5
        End Get
        Set(ByVal value As String)
            m_ImgSource5 = value
        End Set
    End Property
    Private m_ImgSource5 As String

    Public Property ImgSource9() As String
        Get
            Return m_ImgSource9
        End Get
        Set(ByVal value As String)
            m_ImgSource9 = value
        End Set
    End Property
    Private m_ImgSource9 As String
    '=================================

    Public Property ht() As String
        Get
            Return m_Hoten
        End Get
        Set(ByVal value As String)
            m_Hoten = value
        End Set
    End Property
    Private m_Hoten As String

    Public Property t() As String
        Get
            Return m_tuoi
        End Get
        Set(ByVal value As String)
            m_tuoi = value
        End Set
    End Property
    Private m_tuoi As String

    Public Property gt() As String
        Get
            Return m_gioitinh
        End Get
        Set(ByVal value As String)
            m_gioitinh = value
        End Set
    End Property
    Private m_gioitinh As String

    Private m_mabn As String
    Public Property bn() As String
        Get
            Return m_mabn
        End Get
        Set(ByVal value As String)
            m_mabn = value
        End Set
    End Property

    Private m_chandoan As String
    Public Property cd() As String
        Get
            Return m_chandoan
        End Get
        Set(ByVal value As String)
            m_chandoan = value
        End Set
    End Property

    Private m_chidinh As String
    Public Property chd() As String
        Get
            Return m_chidinh
        End Get
        Set(ByVal value As String)
            m_chidinh = value
        End Set
    End Property

    Private m_ketluan As String
    Public Property kl() As String
        Get
            Return m_ketluan
        End Get
        Set(ByVal value As String)
            m_ketluan = value
        End Set
    End Property

    Private m_Title As String
    Public Property tit() As String
        Get
            Return m_Title
        End Get
        Set(ByVal value As String)
            m_Title = value
        End Set
    End Property

    Public Property tenbs() As String
        Get
            Return m_tenbs
        End Get
        Set(ByVal value As String)
            m_tenbs = value
        End Set
    End Property
    Private m_tenbs As String

    Protected Overrides Sub BeforeReportPrint()
        MyBase.BeforeReportPrint()
        logo.ImageUrl = m_ImgSource5

        XrPictureBox1.ImageUrl = ImgSource1
        XrPictureBox2.ImageUrl = ImgSource2
        XrTableCell2.Text = ht
        XrTableCell4.Text = gt
        XrTableCell6.Text = t
        XrTableCell8.Text = bn
        'XrTableCell12.Text = cd
        XrTableCell14.Text = chd
        XrTableCell16.Text = kl
        XrLabel3.Text = tit

        XrLabel_TenBacSi.Text = tenbs
        XrLabel5.Text = "Ngày " + DateTime.Now.Date.ToString("dd/MM/yyyy")
    End Sub
End Class