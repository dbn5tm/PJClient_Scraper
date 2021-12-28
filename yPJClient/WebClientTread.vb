Imports System.Threading
Imports System.Net

Public Class WebClientTread
    Public StopWebClient As Boolean
    Public Event PageRcvd(ByVal ret As String)
    Public Event ClientError(ByVal err As String)
    Public dTimer As System.Timers.Timer
    
    Private m_url As String
    Public Property url() As String
        Get
            Return m_url
        End Get
        Set(ByVal value As String)
            m_url = value
        End Set
    End Property

    Private m_refreshtime As Integer
    Public Property refreshtime() As Integer
        Get
            Return m_refreshtime
        End Get
        Set(ByVal value As Integer)
            m_refreshtime = value
        End Set
    End Property

    Public Sub New()
        StopWebClient = False

    End Sub

    Public Sub Go()

        'Using client As New WebClient
        ' Set one of the headers.
        dTimer = New System.Timers.Timer(1000)
        AddHandler dTimer.Elapsed, AddressOf OnTimedEvent
        If Me.refreshtime < 5000 Then Me.refreshtime = 5000
        dTimer.Interval = Me.refreshtime
        DownloadPJPage()
        dTimer.Enabled = True

    End Sub
    Private Sub DownloadPJPage()
        Using client As New WebClient
            ' Set one of the headers.
            client.Headers("User-Agent") = "Mozilla/4.0"
            Try
                Dim str As String = client.DownloadString(url)
                'Dim str As String = client.DownloadString("http://www.pingjockey.net/cgi-bin/pingtalk/")
                RaiseEvent PageRcvd(str)
                dTimer.Enabled = True
            Catch ex As Exception
                RaiseEvent ClientError(ex.ToString())
                dTimer.Enabled = True
            End Try
        End Using
    End Sub

    Private Sub OnTimedEvent()
        If Not StopWebClient Then
            dTimer.Enabled = False
            DownloadPJPage()
            m_refreshtime += 1000
            If Me.refreshtime > 20000 Then Me.refreshtime = 20000
            dTimer.Interval = Me.refreshtime
            dTimer.Enabled = True
        End If

    End Sub

End Class
