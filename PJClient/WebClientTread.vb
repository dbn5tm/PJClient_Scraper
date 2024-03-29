﻿Imports System.Threading
Imports System.Net
Imports System.IO


Public Class WebClientTread
    Public StopWebClient As Boolean
    Public Event PageRcvd(ByVal ret As String)
    Public Event ClientError(ByVal err As String)
    Public dTimer As System.Timers.Timer
    Private client As WebClient
    Public ThreadRunning As Boolean = False

    Private m_url As String
    Public Property URL() As String
        Get
            Return m_url
        End Get
        Set(ByVal value As String)
            m_url = value
        End Set
    End Property

    Private m_refreshtime As Integer
    Public Property Refreshtime() As Integer
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
        ThreadRunning = True
        'Using client As New WebClient
        ' Set one of the headers.
        client = New WebClient()
        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")

        dTimer = New System.Timers.Timer(1000)
        AddHandler dTimer.Elapsed, AddressOf OnTimedEvent
        If Me.refreshtime < 5000 Then Me.refreshtime = 5000
        dTimer.Interval = Me.refreshtime
        DownloadPJPage()
        dTimer.Enabled = True

    End Sub
    Private Sub DownloadPJPage()
        'Dim uri As String = "http://n5tm.com/PJReflector/PJReflector.html"

        'Using client As New WebClient
        ' Set one of the headers.
        'client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")

        'client.Headers("User-Agent") = "myUserAgentString"
        Try
            ' below lines added 1-28-2023 to fix the issue "The request was aborted: Could not create SSL/TLS secure channel." reported by Lloyd K8DIO running on W7
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            ' -------------------------------------------------
            'Dim str As String = client.DownloadString(uri)
            Dim str As String = client.DownloadString(url)
                'Dim str As String = client.DownloadString("http://www.pingjockey.net/cgi-bin/pingtalk/")

                RaiseEvent PageRcvd(str)
                dTimer.Enabled = True
            Catch ex As Exception
                RaiseEvent ClientError(ex.ToString())
                dTimer.Enabled = True
            End Try
        'End Using
    End Sub

    Private Sub OnTimedEvent()
        If Not StopWebClient Then
            dTimer.Enabled = False
            DownloadPJPage()
            'm_refreshtime += 1000
            'If Me.refreshtime > 20000 Then Me.refreshtime = 20000
            dTimer.Interval = Me.refreshtime
            dTimer.Enabled = True
        End If

    End Sub

End Class
