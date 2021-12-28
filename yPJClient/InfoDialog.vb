Imports System.Windows.Forms
Imports System.Net
Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports System.Text
Imports System.ComponentModel
Imports System.Linq
Imports System.Xml
Imports System.Xml.Linq


Public Class InfoDialog
    Dim myInfo As New PJ
    Dim xInfo As XDocument
    Dim FileInfoPath = New System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)
    Dim ApplicationPath As String
    Dim DataPath As String
    Dim webpageindex As Integer
    Dim webpagefontsize As Integer
    Private fontSize As Single
    Private fontbold As Boolean
    Private myBackcolor As Color
    Private ColumnWidth(5) As Integer
    Private N5TMChat As Boolean

    Public Event Newinfo(ByVal nickname As String, ByVal callsign As String, ByVal state As String, ByVal grid As String, _
                         ByVal firstname As String, ByVal email As String)

    Private Function GetHexColor(ByVal colorObj As System.Drawing.Color) As String
        Return "#" & Hex(colorObj.R) & Hex(colorObj.G) & Hex(colorObj.B)
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        saveInfoXML()
        RaiseEvent Newinfo(Me.NicknameTextBox.Text, Me.CallsignTextBox.Text, Me.StateTextBox.Text, Me.GridTextBox.Text, Me.FirstnameTextBox.Text, _
                           Me.emailTextBox.Text)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function findWSJT() As String
        Dim fspec() As String = _
        {"C:\Program Files\WSJT9\WSJT.LOG", _
         "C:\Program Files (x86)\WSJT9\WSJT.LOG", _
         "C:\Program Files\WSJT\WSJT.LOG", _
         "C:\Program Files (x86)\WSJT.LOG", _
         "C:\WSJT\WSJT.LOG", _
         "C:\WSJT9\WSJT.LOG"}


        Try
            For Each f In fspec
                If Dir(f) <> "" Then Return f
            Next

        Catch ex As Exception

        End Try
        Return ""
    End Function

    Private Sub saveInfoXML()
        Try
            Dim xInfo = <?xml version="1.0"?>
                        <Info>
                            <nickname><%= Me.NicknameTextBox.Text %></nickname>
                            <nickname2><%= Me.NickName2TextBox.Text %></nickname2>
                            <callsign><%= Me.CallsignTextBox.Text %></callsign>
                            <firstname><%= Me.FirstnameTextBox.Text %></firstname>
                            <locator><%= Me.GridTextBox.Text %></locator>
                            <state><%= Me.StateTextBox.Text %></state>
                            <country><%= Me.CountryTextBox.Text %></country>
                            <email><%= Me.emailTextBox.Text %></email>
                            <fontSize><%= fontSize %></fontSize>
                            <useWSJTLog><%= Me.UseWSJTLogCheckBox.Checked %></useWSJTLog>
                            <WSJTLog><%= Me.WSJTLogTextBox.Text %></WSJTLog>
                            <history><%= 0 %></history>
                            <column0><%= Me.ColumnWidth(0) %></column0>
                            <column1><%= Me.ColumnWidth(1) %></column1>
                            <column2><%= Me.ColumnWidth(2) %></column2>
                            <column3><%= Me.ColumnWidth(3) %></column3>
                            <column4><%= Me.ColumnWidth(4) %></column4>
                            <column5><%= Me.ColumnWidth(5) %></column5>
                            <metric><%= Me.KmRadioButton.Checked %></metric>
                            <webpageindex><%= webpageindex %></webpageindex>
                            <QRZuser><%= Me.QRZLoginTextBox.Text %></QRZuser>
                            <QRZpwd><%= Me.QRZPwdTextBox.Text %></QRZpwd>
                            <dxcluster><%= Me.DXClusterComboBox.SelectedItem %></dxcluster>
                            <fontbold><%= fontbold %></fontbold>
                            <Call3WSJT><%= Me.Call3WSJTTextBox.Text %></Call3WSJT>
                            <Call3MAP65><%= Me.Call3MAP65TextBox.Text %></Call3MAP65>
                            <WebPageFontSize><%= Me.webpagefontsize %></WebPageFontSize>
                            <ViewChat><%= N5TMChat %></ViewChat>
                        </Info>
            My.Computer.FileSystem.WriteAllText(DataPath + "\Info.xml", xInfo.ToString(), False)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub LoadTelnetXMLFile()
        Try
            Dim xTelnet = XDocument.Load(DataPath + "\Telnet.xml")

            For Each Item As String In xTelnet.<clusters>.<url>
                Me.DXClusterComboBox.Items.Add(Item)

            Next

        Catch ex As Exception
            Dim xTelnet = <?xml version="1.0"?>
                          <clusters>
                          </clusters>

            My.Computer.FileSystem.WriteAllText(DataPath + "\Telnet.xml", xTelnet.ToString(), False)
        End Try
    End Sub

    Private Sub LoadmyInfoXMLDocument()

        Try
            xInfo = XDocument.Load(DataPath + "\Info.xml")
            Me.NickName2TextBox.Text = xInfo.<Info>.<nickname2>.Value
            Me.NicknameTextBox.Text = xInfo.<Info>.<nickname>.Value
            Me.CallsignTextBox.Text = xInfo.<Info>.<callsign>.Value
            Me.FirstnameTextBox.Text = xInfo.<Info>.<firstname>.Value
            Me.StateTextBox.Text = xInfo.<Info>.<state>.Value
            Me.CountryTextBox.Text = xInfo.<Info>.<country>.Value
            Me.GridTextBox.Text = xInfo.<Info>.<locator>.Value
            Me.emailTextBox.Text = xInfo.<Info>.<email>.Value
            fontSize = xInfo.<Info>.<fontSize>.Value
            Me.WSJTLogTextBox.Text = xInfo.<Info>.<WSJTLog>.Value
            Me.UseWSJTLogCheckBox.Checked = Convert.ToBoolean(xInfo.<Info>.<useWSJTLog>.Value)
            Me.Call3WSJTTextBox.Text = xInfo.<Info>.<Call3WSJT>.Value
            Me.Call3MAP65TextBox.Text = xInfo.<Info>.<Call3MAP65>.Value
            Me.webpagefontsize = xInfo.<Info>.<webpagefontsize>.Value
            'Me.LogQsosCheckBox.Checked = Convert.ToBoolean(xInfo.<Info>.<logQSOs>.Value)
            ColumnWidth(0) = xInfo.<Info>.<column0>.Value
            ColumnWidth(1) = xInfo.<Info>.<column1>.Value
            ColumnWidth(2) = xInfo.<Info>.<column2>.Value
            ColumnWidth(3) = xInfo.<Info>.<column3>.Value
            ColumnWidth(4) = xInfo.<Info>.<column4>.Value
            ColumnWidth(5) = xInfo.<Info>.<column5>.Value
            fontbold = xInfo.<Info>.<fontbold>.Value
            webpageindex = xInfo.<Info>.<webpageindex>.Value
            Me.QRZLoginTextBox.Text = xInfo.<Info>.<QRZuser>.Value
            Me.QRZPwdTextBox.Text = xInfo.<Info>.<QRZpwd>.Value
            Me.N5TMChat = xInfo.<Info>.<ViewChat>.Value
            Dim i = 0
            For Each Item As String In DXClusterComboBox.Items
                If Item = xInfo.<Info>.<dxcluster>.Value Then
                    DXClusterComboBox.SelectedIndex = i
                    i = -1
                    Exit For
                End If
                i += 1

            Next
            If i = -1 Then
                DXClusterComboBox.Items.Add(xInfo.<Info>.<dxcluster>.Value)
            End If

            If xInfo.<Info>.<metric>.Value Then
                Me.KmRadioButton.Checked = True
            Else
                Me.MilesRadioButton.Checked = True
            End If


        Catch ex As Exception
            Try
                saveInfoXML()
            Catch ex1 As Exception

            End Try

        End Try


    End Sub

    Private Sub InfoDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ApplicationPath = FileInfoPath.Directory.FullName
        DataPath = Application.UserAppDataPath
        'DataPath = Application.CommonAppDataPath
        'DataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\PJClient"
        'DataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\PJClient"
        
        LoadTelnetXMLFile()
        LoadmyInfoXMLDocument()


    End Sub

    Private Sub BrowseWSJTLogButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseWSJTLogButton.Click
        'MyOpenFileDialog.ShowDialog()
        MyFolderBrowserDialog.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            Me.WSJTLogTextBox.Text = MyFolderBrowserDialog.SelectedPath & "\WSJT.LOG"
            

        End If
    End Sub

    Private Sub MyOpenFileDialog_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyOpenFileDialog.FileOk
        Me.WSJTLogTextBox.Text = MyOpenFileDialog.FileName
    End Sub

    Private Sub WSJTLogTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WSJTLogTextBox.Click
        Me.LogPathMessageLabel.Visible = True
    End Sub

    Private Sub UseWSJTLogCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseWSJTLogCheckBox.CheckedChanged
        If sender.checked Then
            If Me.WSJTLogTextBox.Text = "" Then
                Me.WSJTLogTextBox.Text = findWSJT()
            End If
        End If
    End Sub


    Private Sub BrowseCall3WSJTButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseCall3WSJTButton.Click
        MyFolderBrowserDialog.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            Me.Call3WSJTTextBox.Text = MyFolderBrowserDialog.SelectedPath & "\CALL3.TXT"


        End If
    End Sub


    Private Sub BrowseCall3MAP65Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseCall3MAP65Button.Click
        MyFolderBrowserDialog.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            Me.Call3MAP65TextBox.Text = MyFolderBrowserDialog.SelectedPath & "\CALL3.TXT"


        End If
    End Sub

End Class
