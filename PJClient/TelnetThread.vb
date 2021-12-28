Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class TelnetThread
    Dim remoteIPAddress As IPAddress
    Dim ep As IPEndPoint
    Dim tnSocket As Socket

    Public StopTelnet As Boolean
    Public Event PageRcvd(ByVal ret As String)
    Public Event ClientError(ByVal err As String)
    Public dTimer As System.Timers.Timer
    Public Event TelnetData(ByVal ret As String)

    Private m_url As String
    Public Property url() As String
        Get
            Return m_url
        End Get
        Set(ByVal value As String)
            m_url = value
        End Set
    End Property

    Private m_port As String
    Public Property Port() As String
        Get
            Return m_port
        End Get
        Set(ByVal value As String)
            m_port = value
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

    Private m_connected As Boolean
    Public Property connected() As Boolean
        Get
            Return m_connected
        End Get
        Set(ByVal value As Boolean)
            m_connected = value
        End Set
    End Property

    Public Sub New()
        StopTelnet = False

    End Sub

    Public Sub Go()

        'Using client As New WebClient
        ' Set one of the headers.
        'dTimer = New System.Timers.Timer(1000)
        'AddHandler dTimer.Elapsed, AddressOf OnTimedEvent
        'dTimer.Interval = 5000
        TelnetRcvdData()
        'dTimer.Enabled = True

    End Sub
    
    Public Sub Login()
        'SendCommand(m_callsign)
        If Connect(m_url, m_port, m_callsign) <> -1 Then
            Me.connected = True
        Else
            Me.connected = False
        End If
    End Sub

    Private Function Connect(ByVal url As String, ByVal PPort As String, ByVal Command As String) As Integer
        ' LCommand: Actual command we are going to send through telnet
        ' Quite often this is the password or login (or both)
        'Dim Command As String = "N5TM' ' Example command only - you need to use your own
        Dim PIPAddress As System.Net.IPHostEntry
        Dim ip As String
        Try
            PIPAddress = Dns.GetHostEntry(url)
            ip = PIPAddress.AddressList(0).ToString
        Catch ex As Exception
            Return -1
        End Try

        ' Get the IP Address and the Port and create an IPEndpoint (ep)
        remoteIPAddress = IPAddress.Parse(ip.Trim)
        ep = New IPEndPoint(remoteIPAddress, CType(PPort.Trim, Integer))

        ' Set the socket up (type etc)
        tnSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        ' Convert the ASCII command into bytes, adding a line termination on (vbCrLf)
        Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(Command & vbCrLf)
        ' LRecvString: data returned from the telnet socet
        Dim RecvString As String = String.Empty
        ' Create a byte array for recieving bytes from the telnet socket
        Dim RecvBytes(255) As [Byte]
        ' NumBytes: Number of bytes return from telnet socket (count)
        Dim NumBytes As Integer = 0

        Try
            ' Connect
            tnSocket.Connect(ep)
            RecvString = ""
            Do
                ' RecvBytes with contain 256 bytes if data returned
                ' numbytes with have the count of bytes returned
                NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
                RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
            Loop While NumBytes = 256 ' if less than 256 we are at the end of the recv stream
            RaiseEvent TelnetData(RecvString)

            tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
            Return 0
        Catch oEX As SocketException
            ' error
            ' You will need to do error cleanup here e.g killing the socket
            ' and exiting the procedure.
            RaiseEvent TelnetData(oEX.ToString)
            tnSocket = Nothing
            Return -1
        End Try
    End Function

    Public Function SendCommand(ByVal Command As String) As Integer

        ' If we get to here then all seems good (we are connected)
        Try
            ' Convert the ASCII command into bytes, adding a line termination on (vbCrLf)
            Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(Command & vbCrLf)

            ' Double check we are connected
            If tnSocket.Connected Then
                ' Send the command
                tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
            End If
        Catch ex As Exception

        End Try

    End Function

    Private Sub TelnetRcvdData()
        ' -------------------------------------------------------------------
        ' The below "do loop" is not actually needed. This loop is used to
        ' Provide feedback for the commands you issue. e.g. like a hyperterm 
        ' window. If you simply want to send command with no feedback rem it out
        ' -------------------------------------------------------------------
        ' LRecvString: data returned from the telnet socet
        Dim RecvString As String = String.Empty
        ' Create a byte array for recieving bytes from the telnet socket
        Dim RecvBytes(255) As [Byte]
        ' NumBytes: Number of bytes return from telnet socket (count)
        Dim NumBytes As Integer = 0
        Try

            Do
                RecvString = ""
                Do
                    ' RecvBytes with contain 256 bytes if data returned
                    ' numbytes with have the count of bytes returned
                    NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
                    RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
                Loop While NumBytes = 256 ' if less than 256 we are at the end of the recv stream
                ' -------------------------------------------------------------------
                RaiseEvent TelnetData(RecvString)
                'Wait(1000)
                'txtRecv.Text = txtRecv.Text + RecvString
                'txtRecv.SelectionStart = txtRecv.Text.Length
            Loop While Not StopTelnet


            ' Disconnect
            'tnSocket.Disconnect(False)
            'End If
        Catch oEX As Exception
            ' Error cleanup etc needed
        End Try

        ' Cleanup
        'remoteIPAddress = Nothing
        'ep = Nothing
        'tnSocket = Nothing
        'Command = Nothing
        'RecvString = Nothing
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

    Private Sub OnTimedEvent(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        If Not StopTelnet Then
            dTimer.Enabled = False
            DownloadPJPage()
            dTimer.Enabled = True
        End If

    End Sub
End Class
