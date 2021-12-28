Public Class PJ
    Public posts As New ArrayList

    'Private m_xStation As XDocument
    'Public Property xstation() As XDocument
    '    Get
    '        Return m_xStation
    '    End Get
    '    Set(ByVal value As XDocument)
    '        m_xStation = value
    '    End Set
    'End Property

    Private m_station As String
    Public Property station() As String
        Get
            Return m_station
        End Get
        Set(ByVal value As String)
            m_station = value
        End Set
    End Property

    Private m_WebPageIndex As Integer
    Public Property WebPageIndex() As Integer
        Get
            Return m_WebPageIndex
        End Get
        Set(ByVal value As Integer)
            m_WebPageIndex = value
        End Set
    End Property

    Private m_highlite As Boolean
    Public Property highlite() As Boolean
        Get
            Return m_highlite
        End Get
        Set(ByVal value As Boolean)
            m_highlite = value
        End Set
    End Property

    Private m_nickname As String
    Public Property nickname() As String
        Get
            Return m_nickname
        End Get
        Set(ByVal value As String)
            m_nickname = value
        End Set
    End Property

    Private m_callsign As String
    Public Property callsign() As String
        Get
            Return m_callsign
        End Get
        Set(ByVal value As String)
            m_callsign = value
        End Set
    End Property

    Private m_firstname As String
    Public Property firstname() As String
        Get
            Return m_firstname
        End Get
        Set(ByVal value As String)
            m_firstname = value
        End Set
    End Property

    Private m_email As String
    Public Property email() As String
        Get
            Return m_email
        End Get
        Set(ByVal value As String)
            m_email = value
        End Set
    End Property

    Private m_nick_color As Color
    Public Property nick_color() As Color
        Get
            Return m_nick_color
        End Get
        Set(ByVal value As Color)
            m_nick_color = value
        End Set
    End Property

    Private m_locator As String
    Public Property locator() As String
        Get
            Return m_locator
        End Get
        Set(ByVal value As String)
            m_locator = value
        End Set
    End Property

    Private m_moonset As DateTime
    Public Property moonset() As DateTime
        Get
            Return m_moonset
        End Get
        Set(ByVal value As DateTime)
            m_moonset = value
        End Set
    End Property

    Private m_moonrise As DateTime
    Public Property moonrise() As DateTime
        Get
            Return m_moonrise
        End Get
        Set(ByVal value As DateTime)
            m_moonrise = value
        End Set
    End Property

    Private m_addr1 As String
    Public Property addr1() As String
        Get
            Return m_addr1
        End Get
        Set(ByVal value As String)
            m_addr1 = value
        End Set
    End Property

    Private m_addr2 As String
    Public Property addr2() As String
        Get
            Return m_addr2
        End Get
        Set(ByVal value As String)
            m_addr2 = value
        End Set
    End Property

    Private m_state As String
    Public Property state() As String
        Get
            Return m_state
        End Get
        Set(ByVal value As String)
            m_state = value
        End Set
    End Property

    Private m_county As String
    Public Property county() As String
        Get
            Return m_county
        End Get
        Set(ByVal value As String)
            m_county = value
        End Set
    End Property

    Private m_country As String
    Public Property country() As String
        Get
            Return m_country
        End Get
        Set(ByVal value As String)
            m_country = value
        End Set
    End Property

    Private m_distance As Double
    Public Property distance() As Double
        Get
            Return m_distance
        End Get
        Set(ByVal value As Double)
            m_distance = value
        End Set
    End Property

    Private m_azmuth As Double
    Public Property azmuth() As Double
        Get
            Return m_azmuth
        End Get
        Set(ByVal value As Double)
            m_azmuth = value
        End Set
    End Property

    Private m_logged As New ArrayList
    Public Property logged(ByVal index As Integer) As String()
        Get
            Return m_logged.Item(index)
        End Get
        Set(ByVal value As String())
            If index > -1 Then
                m_logged.Item(index) = value
            Else
                m_logged.Add(value)
            End If

        End Set
    End Property

    'Private m_logCount As Integer
    Public Property logCount() As Integer
        Get
            Return m_logged.Count
        End Get
        Set(ByVal value As Integer)
            'm_logCount = value
        End Set
    End Property

    Private m_post As Date
    Public Property post() As Date
        Get
            Return m_post
        End Get
        Set(ByVal value As Date)
            m_post = value
        End Set
    End Property

    Private m_call3 As Boolean
    Public Property call3() As Boolean
        Get
            Return m_call3
        End Get
        Set(ByVal value As Boolean)
            m_call3 = value
        End Set
    End Property

    Private Sub initProperties()
        m_station = ""
        m_county = ""
        m_country = ""
        m_state = ""
        m_azmuth = 0
        m_distance = 0
        m_callsign = ""
        m_email = ""
        m_firstname = ""
        m_locator = ""
        m_nickname = ""
        m_station = ""
        m_call3 = False

    End Sub

    Public Sub New()
        initProperties()
    End Sub


End Class
