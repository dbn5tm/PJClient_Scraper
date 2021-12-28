
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Telnet
    ' These vars can be formwide or local (in procedure) depending on how you want to use them.
    Dim remoteIPAddress As IPAddress
    Dim ep As IPEndPoint
    Dim tnSocket As Socket
    Dim DXCluster As New TelnetThread
    Private ThreadDXCluster As New System.Threading.Thread(AddressOf DXCluster.Go)
    Dim DataPath As String
    Dim xTelnet As XDocument

    Private m_callsign As String
    Public Property callsign() As String
        Get
            Return m_callsign
        End Get
        Set(ByVal value As String)
            m_callsign = value
        End Set
    End Property

    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        'DXCluster.url = "128.111.56.240"
        'DXCluster.url = "dxc.kb1h.com"
        If TelNetURLComboBox.Text <> "" Then
            Dim thisCluster = TelNetURLComboBox.Text.Split(":")
            DXCluster.url = thisCluster(0)

            If thisCluster.Count > 1 Then
                If thisCluster(1) = "" Then
                    DXCluster.Port = "7300"
                Else
                    DXCluster.Port = thisCluster(1)
                End If
            Else
                DXCluster.Port = "7300"
            End If


            DXCluster.callsign = m_callsign


            DXCluster.Login()
            ThreadDXCluster.Start()
        Else
            MsgBox("Select or enter URL for DX Cluster")
        End If


    End Sub

    'Private Sub SendCommands(ByVal PIPAddress As String, ByVal PPort As String)
    '    ' LCommand: Actual command we are going to send through telnet
    '    ' Quite often this is the password or login (or both)
    '    Dim Command As String = "N5TM" ' Example command only - you need to use your own

    '    ' LRecvString: data returned from the telnet socet
    '    Dim RecvString As String = String.Empty

    '    ' NumBytes: Number of bytes return from telnet socket (count)
    '    Dim NumBytes As Integer = 0

    '    ' Get the IP Address and the Port and create an IPEndpoint (ep)
    '    remoteIPAddress = IPAddress.Parse(PIPAddress.Trim)
    '    ep = New IPEndPoint(remoteIPAddress, CType(PPort.Trim, Integer))

    '    ' Set the socket up (type etc)
    '    tnSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

    '    ' Convert the ASCII command into bytes, adding a line termination on (vbCrLf)
    '    Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(Command & vbCrLf)

    '    ' Create a byte array for recieving bytes from the telnet socket
    '    Dim RecvBytes(255) As [Byte]

    '    Try
    '        ' Connect
    '        tnSocket.Connect(ep)
    '    Catch oEX As SocketException
    '        ' error
    '        ' You will need to do error cleanup here e.g killing the socket
    '        ' and exiting the procedure.
    '        Exit Sub
    '    End Try

    '    ' If we get to here then all seems good (we are connected)
    '    Try
    '        ' Wait a few seconds (3) (depending on connection) telnet can be slow.
    '        Wait(3000)

    '        ' Double check we are connected
    '        If tnSocket.Connected Then
    '            ' Send the command
    '            'tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)

    '            ' -------------------------------------------------------------------
    '            ' The below "do loop" is not actually needed. This loop is used to
    '            ' Provide feedback for the commands you issue. e.g. like a hyperterm 
    '            ' window. If you simply want to send command with no feedback rem it out
    '            ' -------------------------------------------------------------------

    '            ' loop getting 256 bytes of data from telnet socket at a time
    '            Do
    '                ' RecvBytes with contain 256 bytes if data returned
    '                ' numbytes with have the count of bytes returned
    '                NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
    '                RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
    '            Loop While NumBytes = 256 ' if less than 256 we are at the end of the recv stream

    '            ' Send recieved bytes to the output text box
    '            txtRecv.Text = RecvString
    '            'login first
    '            tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
    '            ' loop getting 256 bytes of data from telnet socket at a time
    '            Do
    '                Do
    '                    ' RecvBytes with contain 256 bytes if data returned
    '                    ' numbytes with have the count of bytes returned
    '                    NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
    '                    RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
    '                Loop While NumBytes = 256 ' if less than 256 we are at the end of the recv stream
    '                ' -------------------------------------------------------------------
    '                Wait(1000)
    '                txtRecv.Text = txtRecv.Text + RecvString
    '                txtRecv.SelectionStart = txtRecv.Text.Length
    '            Loop


    '            ' Disconnect
    '            'tnSocket.Disconnect(False)
    '        End If
    '    Catch oEX As Exception
    '        ' Error cleanup etc needed
    '    End Try

    '    ' Cleanup
    '    remoteIPAddress = Nothing
    '    ep = Nothing
    '    tnSocket = Nothing
    '    Command = Nothing
    '    RecvString = Nothing


    'End Sub

    'Private Sub Wait(ByVal PMillseconds As Integer)
    '    ' Function created to replace thread.sleep()
    '    ' Provides responsive main form without using threading.

    '    Dim TimeNow As DateTime
    '    Dim TimeEnd As DateTime
    '    Dim StopFlag As Boolean

    '    TimeEnd = Now()
    '    TimeEnd = TimeEnd.AddMilliseconds(PMillseconds)
    '    StopFlag = False
    '    While Not StopFlag
    '        TimeNow = Now()
    '        If TimeNow > TimeEnd Then
    '            StopFlag = True
    '        End If
    '        Application.DoEvents()
    '    End While

    '    ' Cleanup
    '    TimeNow = Nothing
    '    TimeEnd = Nothing
    'End Sub

    Private Sub NewTelenetData(ByVal ret As String)
        SetTelnetText(ret)
    End Sub

    Private Delegate Sub SetTelnetTextCallback(ByVal [text] As String)
    Private Sub SetTelnetText(ByVal text As String)

        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.' 
        If Me.txtRecv.InvokeRequired Then
            Dim d As New SetTelnetTextCallback(AddressOf SetTelnetText)
            Me.Invoke(d, New Object() {text})
        Else
            Me.txtRecv.AppendText(text)
            Me.txtRecv.Select(txtRecv.TextLength, 0)
            Me.txtRecv.ScrollToCaret()
        End If
    End Sub

    Private Sub Telnet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DXCluster.StopTelnet = True
    End Sub

    Function GetAppDataPath() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    End Function

    Private Sub Telnet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'DataPath = Application.UserAppDataPath
        DataPath = GetAppDataPath() + "\n5tm\PJClient\params"
        LoadTelnetXMLFile()

        AddHandler DXCluster.TelnetData, AddressOf NewTelenetData
    End Sub

    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click
        DXCluster.StopTelnet = True
        If DXCluster.connected Then
            DXCluster.SendCommand("/Exit")
        End If

        Me.Close()
    End Sub

    Private Sub PostButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostButton.Click
        If Me.DXTextBox.Text.Length > 2 And IsNumeric(Me.FreqTextBox.Text) Then
            DXCluster.SendCommand("DX " + Me.DXTextBox.Text + " " + Me.FreqTextBox.Text + " " + Me.CommentTextBox.Text)
        End If

    End Sub

    Private Sub SHDXButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHDXButton.Click
        DXCluster.SendCommand("show/dx 20")
    End Sub

    Private Sub MoonButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoonButton.Click
        If Me.CallTextBox.Text.Length > 2 Then
            DXCluster.SendCommand("show/moon" + " " + Me.CallTextBox.Text)
        End If


    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterComboBox.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 0
                DXCluster.SendCommand("clear/spots all")
            Case 1
                DXCluster.SendCommand("accept/spots on vhf")
            Case 2
                DXCluster.SendCommand("accept/spots on 2m")
            Case 3
                DXCluster.SendCommand("accept/spots on 6m")
            Case 4
                DXCluster.SendCommand("accept/spots on hf")
        End Select
    End Sub

    Private Sub LoadTelnetXMLFile()
        Try
            xTelnet = XDocument.Load(DataPath + "\Telnet.xml")

            For Each Item As String In xTelnet.<clusters>.<url>
                Me.TelNetURLComboBox.Items.Add(Item)

            Next

        Catch ex As Exception
            xTelnet = <?xml version="1.0"?>
                      <clusters>
                      </clusters>

            My.Computer.FileSystem.WriteAllText(DataPath + "\Telnet.xml", xTelnet.ToString(), False)
        End Try
    End Sub

    Private Sub AddDXClusterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDXClusterButton.Click
        Dim exists As Boolean = False

        For Each item As String In xTelnet.<clusters>.<url>
            If item = Me.TelNetURLComboBox.Text Then
                exists = True
                Exit For

            End If

        Next
        Dim xClusters = From el In xTelnet.<clusters> Select el

        If Not exists Then
            xClusters(0).Add(New XElement("url", Me.TelNetURLComboBox.Text))
        End If
        My.Computer.FileSystem.WriteAllText(DataPath + "\Telnet.xml", xTelnet.ToString(), False)

    End Sub

    Private Sub DeleteURLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteURLButton.Click
        Dim xURL = From el In xTelnet.<clusters>.<url> _
                    Where el.Value = Me.TelNetURLComboBox.Text _
                    Select el
        If xURL.Count > 0 Then
            If MsgBox("Remove URL?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                xURL(0).Remove()
                My.Computer.FileSystem.WriteAllText(DataPath + "\Telnet.xml", xTelnet.ToString(), False)
                Me.TelNetURLComboBox.Items.Remove(Me.TelNetURLComboBox.SelectedItem)
            End If
        End If


    End Sub
End Class