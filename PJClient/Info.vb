Public Class Info

    Private m_WSJTLogPath As String
    Public Property WSJTLogPath() As String
        Get
            Return m_WSJTLogPath
        End Get
        Set(ByVal value As String)
            m_WSJTLogPath = value
        End Set
    End Property

    Private m_QRZUser As String
    Public Property QRZUser() As String
        Get
            Return m_QRZUser
        End Get
        Set(ByVal value As String)
            m_QRZUser = value
        End Set
    End Property

    Private m_QRZpwd As String
    Public Property QRZpwd() As String
        Get
            Return m_QRZpwd
        End Get
        Set(ByVal value As String)
            m_QRZpwd = value
        End Set
    End Property

    Private m_metric As Boolean
    Public Property metric() As Boolean
        Get
            Return m_metric
        End Get
        Set(ByVal value As Boolean)
            m_metric = value
        End Set
    End Property

    Private m_nickname2 As String
    Public Property nickname2() As String
        Get
            Return m_nickname2
        End Get
        Set(ByVal value As String)
            m_nickname2 = value
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

    Private m_locator As String
    Public Property locator() As String
        Get
            Return m_locator
        End Get
        Set(ByVal value As String)
            m_locator = value
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

    Private m_country As String
    Public Property country() As String
        Get
            Return m_country
        End Get
        Set(ByVal value As String)
            m_country = value
        End Set
    End Property

    Private m_band(2) As String
    Public Property band(ByVal index As Integer) As String
        Get
            Return m_band(index)
        End Get
        Set(ByVal value As String)
            m_band(index) = value
        End Set
    End Property

    Private m_power(2) As String
    Public Property power(ByVal index As Integer) As String
        Get
            Return m_power(index)
        End Get
        Set(ByVal value As String)
            m_power(index) = value
        End Set
    End Property

    Private m_antenna(2) As String
    Public Property antenna(ByVal index As Integer) As String
        Get
            Return m_antenna(index)
        End Get
        Set(ByVal value As String)
            m_antenna(index) = value
        End Set
    End Property

    Private m_awaymsg As String
    Public Property awaymsg() As String
        Get
            Return m_awaymsg
        End Get
        Set(ByVal value As String)
            m_awaymsg = value
        End Set
    End Property

    Private m_away As Boolean
    Public Property Away() As Boolean
        Get
            Return m_away
        End Get
        Set(ByVal value As Boolean)
            m_away = value
        End Set
    End Property
End Class
