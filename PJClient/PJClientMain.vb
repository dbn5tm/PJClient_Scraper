Imports System.Net
Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports System.Text
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.Linq
Imports System.Xml
Imports System.Xml.Linq
Imports System.Net.Mail


Public Class PJClientMain
    Dim xStationXML As StationXML
    Dim getMoonFlag As Boolean
    Dim xInfo As New XDocument
    'Dim xStation As New XDocument
    Dim xColors As New XDocument
    Dim ApplicationPath As String
    Dim DataPath As String
    Dim legacyfullpath As String
    Dim FileInfoPath = New System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)
    Dim myInfo As New Info
    Dim nick_unique As New ArrayList
    Dim npj_count As Integer
    Dim current_PJ As PJ
    Dim logQSO As Boolean
    Dim logQSOs As Boolean
    Dim CQPosted As Boolean
    Dim RunningPosted As Boolean
    Private colorFrm As ColorsDlg
    Private optFrm As InfoDialog
    Dim SelectedStation As PJ
    Dim TelnetURL As String
    Private myposts As New ArrayList
    Dim DontShowDBException As Boolean
    'Private logBookFrm As Logbook
    'Private frmQSO As QSOLog
    Private RetrievePJPage As New WebClientTread()
    Private ThreadRetrievePJPage As New System.Threading.Thread(AddressOf RetrievePJPage.Go)
    Private call_colors As New ArrayList
    Private WSJTLogPath As String
    Dim webpagefontsize As Integer
    Dim Call3WSJTPath As String
    Dim Call3MAP65Path As String
    Dim Call3WSJTXPath As String
    Private logArray As New ArrayList
    Private call3Array As New ArrayList
    Private fontSize As Single = 9
    Private fontbold As Boolean
    Private fbold As Font 'New Font("Tahoma", fontSize, FontStyle.Bold)
    Private fnormal As Font  'New Font("Tahoma", fontSize, FontStyle.Regular)
    Private myBackcolor As Color
    Private myTextcolor As Color
    Private useWSJTLog As Boolean
    Private useSQLiteDB As Boolean
    Private QsoStartTime As Date
    Private History As Integer
    Private minutetimer As Long
    Private ColumnWidth(5) As Integer
    'Private ColumnOrder(5) As Integer
    Private InitializingListView As Boolean
    Private RefreshPage As Boolean
    Private PageURL() = {"https://www.pingjockey.net/cgi-bin/pingtalk/", "https://www.chris.org/cgi-bin/jt65emeA",
                          "https://www.chris.org/cgi-bin/jt65emeB", "https://www.chris.org/cgi-bin/jt65talk"}
    Private PageURLIndex As Integer
    Private SplitChar As String = "{"
    Private metricDistance As Boolean
    Private freq_post As New ArrayList
    Dim m_ColumnNames As New Collection
    Dim m_ColumnIndexes As New Collection
    Dim callsignIndex As Integer = 0

    'Dim DXCluster As New TelnetThread
    'Private ThreadDXCluster As New System.Threading.Thread(AddressOf DXCluster.Go)

    Private Sub CopyFilesIfNewInstall()
        Try
            'Dim ver As String = Application.ProductVersion
            'legacyfullpath = GetAppDataPath() + "\n5tm\PJClient\" + ver
            'Dim oldDataPath = legacyfullpath.Split("\")
            'Dim oldver = oldDataPath(oldDataPath.Length - 1)
            'Dim rVer = oldver.Split(".")
            'rVer(2) -= 1
            'Dim OldPath As String
            'While rVer(2) > 0
            '    OldPath = ""
            '    For Each Item As String In oldDataPath
            '        If Item.Contains(".") Then
            '            OldPath = OldPath + rVer(0) + "." + rVer(1) + "." + rVer(2) + "." + rVer(3)
            '            Exit For
            '        Else
            '            OldPath = OldPath + Item + "\"
            '        End If
            '    Next
            '    If Not System.IO.File.Exists(OldPath & "\info.xml") Then
            '        rVer(2) -= 1
            '    Else
            '        Exit While
            '    End If

            'End While

            System.IO.Directory.CreateDirectory(DataPath)

            'If Not System.IO.File.Exists(DataPath & "\PJCLogbook2.db3") Then
            '    System.IO.File.Copy(ApplicationPath & "\AppData\PJCLogbook2.db3", DataPath & "\PJCLogbook2.db3")
            'End If
            'OldPath = ""
            'copyXmlFiles(OldPath, "colors.xml")
            If Not System.IO.File.Exists(DataPath & "\Colors.xml") Then
                ' create new Colors.xml file
                Dim c_colors As New ArrayList

                c_colors.Add(Color.FromArgb(-65536))
                c_colors.Add(Color.FromArgb(-16744448))
                c_colors.Add(Color.FromArgb(-16776961))
                c_colors.Add(Color.FromArgb(-1146130))
                c_colors.Add(Color.FromArgb(-4684277))
                c_colors.Add(Color.FromArgb(-16741493))
                c_colors.Add(Color.FromArgb(-10185235))
                c_colors.Add(Color.FromArgb(-5952982))
                c_colors.Add(Color.FromArgb(-2354116))
                c_colors.Add(Color.FromArgb(-7722014))
                c_colors.Add(Color.FromArgb(-10510688))
                c_colors.Add(Color.FromArgb(-7722014))
                c_colors.Add(Color.FromArgb(-16777088))
                c_colors.Add(Color.FromArgb(-7667573))
                c_colors.Add(Color.FromArgb(-7667712))
                c_colors.Add(Color.FromArgb(-16724271))
                c_colors.Add(Color.FromArgb(-5103070))
                c_colors.Add(Color.FromArgb(-14513374))
                c_colors.Add(Color.FromArgb(-5374161))
                myBackcolor = Color.Black
                myTextcolor = Color.White
                SaveColorsXMLDocument(c_colors)
            End If
            'copyXmlFiles(OldPath, "Info.xml")
            If Not System.IO.File.Exists(DataPath & "\Info.xml") Then
                'create new info.xml file
                myInfo.callsign = "mycall"
                myInfo.country = "country"
                myInfo.firstname = "OM"
                myInfo.locator = "EM00"
                myInfo.state = "xx"
                myInfo.metric = "false"
                myInfo.nickname = "MSnick"
                myInfo.nickname2 = "emeNick"
                myInfo.email = "mycall@gmail.com"
                'InitListview(Me.StationsListView)
                SavemyInfoXMLDocument()
            End If
            'copyXmlFiles(OldPath, "Telnet.xml")
            If Not System.IO.File.Exists(DataPath & "\Telnet.xml") Then
                'create new Telnet.xml file

            End If
            'copyXmlFiles(OldPath, "Station.xml")
            If Not System.IO.File.Exists(DataPath & "\Station.xml") Then
                'create new Station.xml file
            End If
            If Not System.IO.File.Exists(DataPath & "\QRZKey.xml") Then
                'create new QRZKey.xml file
            End If

        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub

    Private Sub copyXmlFiles(ByVal oldPath As String, ByVal fspec As String)
        Try
            If Not System.IO.File.Exists(DataPath & "\" & fspec) Then
                If Not System.IO.File.Exists(oldPath & "\" & fspec) Then
                    'MsgBox("new install, copy files from " + ApplicationPath & "\AppData\" & fspec & " to " & DataPath & "\" & fspec)
                    System.IO.Directory.CreateDirectory(DataPath)
                    'MessageBox.Show("ApplicationPath" + " " + ApplicationPath.ToString() + " " + fspec)
                    System.IO.File.Copy(ApplicationPath & "\AppData\" & fspec, DataPath & "\" & fspec)
                Else
                    System.IO.Directory.CreateDirectory(DataPath)
                    System.IO.File.Copy(oldPath & "\" & fspec, DataPath & "\" & fspec)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show("Exception ApplicationPath" + " " + ApplicationPath.ToString())
            System.IO.Directory.CreateDirectory(DataPath)
            System.IO.File.Copy(ApplicationPath & "\AppData\" & fspec, DataPath & "\" & fspec)
        End Try

    End Sub

    Private Sub PJClientMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Static checkOnlyOnce As Integer
        'check for update available only one time as this was causing hang situations.
        If checkOnlyOnce = 1 Then
            SetStatusLabelText("Checking for Updates", Me.ToolStripStatusLabel1)
            CheckForUpdate()
            checkOnlyOnce = 2

        End If
        If checkOnlyOnce = 0 Then checkOnlyOnce = 1
        'With Me.PJTextbox
        '    .Font = New Font(New FontFamily("Tahoma"), 9, FontStyle.Regular)
        'End With

        With Me.StationsListView
            If fontbold Then
                .Font = fbold
            Else
                .Font = fnormal
            End If
            '.Font = New Font(New FontFamily("Tahoma"), fontSize, FontStyle.Regular)
        End With
        With Me.FreqTreeView
            If fontbold Then
                .Font = fbold
            Else
                .Font = fnormal
            End If
            '.Font = New Font(New FontFamily("Tahoma"), fontSize, FontStyle.Regular)
        End With
        If checkOnlyOnce = 1 Then ThreadRetrievePJPage.Start()
    End Sub

    Function GetAppDataPath() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    End Function

    Private Sub PJClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ApplicationPath = FileInfoPath.Directory.FullName

        Dim ver As String = Application.ProductVersion
        DataPath = GetAppDataPath() + "\n5tm\PJClient\params" '+ ver

        CopyFilesIfNewInstall()
        xStationXML = New StationXML(DataPath)

        Me.Text = "PJClient Version " + My.Application.Info.Version.ToString

        'Me.PJCLogBook2DataSet.EnforceConstraints = False
        ''TODO: This line of code loads data into the 'PJCLogBook2DataSet.Qso' table. You can move, or remove it, as needed.
        'Me.QsoTableAdapter.Fill(Me.PJCLogBook2DataSet.Qso)
        ''TODO: This line of code loads data into the 'PJCLogBook2DataSet.Station' table. You can move, or remove it, as needed.
        'Me.StationTableAdapter.Fill(Me.PJCLogBook2DataSet.Station)

        'DataPath = Application.CommonAppDataPath
        'DataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\PJClient"
        LoadColorsXMLDocument()
        LoadmyInfoXMLDocument()
        'InitListview(Me.StationsListView)
        'LoadStationXMLDocument()
        'If fontSize = 0 Then
        '    fontSize = 9.5
        '    SavemyInfoXMLDocument()
        'End If

        fbold = New Font(PJTextbox.Font.FontFamily, fontSize, FontStyle.Bold)
        fnormal = New Font(PJTextbox.Font.FontFamily, fontSize, FontStyle.Regular)
        'If fontbold Then
        '    Me.PJTextbox.Font = fbold
        'Else
        '    Me.PJTextbox.Font = fnormal
        'End If
        If fontbold Then
            Me.PJTextbox.Font = fbold
            Me.StationsListView.Font = fbold
            Me.FreqTreeView.Font = fbold
            Me.CQTextBox.Font = fbold
            Me.SelectedStationsTextBox.Font = fbold
        Else
            Me.PJTextbox.Font = fnormal
            Me.StationsListView.Font = fnormal
            Me.FreqTreeView.Font = fnormal
            Me.CQTextBox.Font = fnormal
            Me.SelectedStationsTextBox.Font = fnormal
        End If

        changefont(fontSize)
        InitListview(Me.StationsListView)
        'PJTextbox.Font = New Font(PJTextbox.Font.FontFamily, fontSize, PJTextbox.Font.Style)


        If useWSJTLog Then
            If WSJTLogPath = "" Then
                Dim f = findWSJT()
                If f <> "" Then
                    WSJTLogPath = f
                    SavemyInfoXMLDocument()
                End If
            End If
            readLogFile(WSJTLogPath)
        End If

        If Not Call3WSJTPath = "" Then
            readCall3File(Call3WSJTPath)
        Else
            If Not Call3WSJTXPath = "" Then
                readCall3File(Call3WSJTXPath)
            End If

        End If


        npj_count = 0
        'Me.WebPagesToolStripComboBox.SelectedIndex = 0

        RetrievePJPage.url = PageURL(PageURLIndex)
        'RetrievePJPage.url = "http://www.pingjockey.net/cgi-bin/pingtalk/"
        'RetrievePJPage.url = "http://www.chris.org/cgi-bin/jt65emeA"
        'RetrievePJPage.url = "http://www.chris.org/cgi-bin/jt65emeB"
        AddHandler RetrievePJPage.PageRcvd, AddressOf RetrievePJPageFromThread
        RetrievePJPage.refreshtime = 10000

        If PageURLIndex > 0 Then
            SplitChar = "{"
        Else
            SplitChar = "("
        End If
        'ThreadRetrievePJPage.Start()
        'Dim ret = RetrieveWebPage()
        'If ret <> "error" Then
        '    PostReponse(RetrieveWebPage)
        'Else

        'End If
        'Select Case webpagefontsize
        '    Case 0
        '        WebBrowser1.Document.Body.Style = "font-size:large;"
        '    Case 1
        '        WebBrowser1.Document.Body.Style = "font-size:medium;"
        '    Case 2
        '        WebBrowser1.Document.Body.Style = "font-size:small;"

        'End Select
        Me.MsgTextBox.Focus()
        'AddHandler DXCluster.TelnetData, AddressOf NewTelenetData
        'DXClusterLogin()
    End Sub

    Private Function MHDistance(ByVal myGrid As String, ByVal hisGrid As String) As Double
        Try
            Dim d As Double = DistBearing.MaidenheadLocator.Distance(myGrid, hisGrid)
            If metricDistance Then
                Return Format(Math.Ceiling(d), "0000")
            Else
                Return Format(Math.Ceiling(d * 0.621371), "0000")
            End If

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function MHAzmuth(ByVal myGrid As String, ByVal hisGrid As String) As Double
        Try
            Dim az As Double = DistBearing.MaidenheadLocator.Azimuth(myGrid, hisGrid)
            Return Format(az, "000")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub FillListview()
        ' keeping alls staions in an xml file. check for current activity
        Dim h = xStationXML.PostHistory(History)
        'Dim myDistCalc As New DistBearing.MaidenheadLocator
        'Dim d As Double  '= DistBearing.MaidenheadLocator.Distance("El29ds", "EM26dd")
        Dim az As Double '= DistBearing.MaidenheadLocator.Azimuth("El29ds", "EL95dd")

        If fontbold Then
            BoldListView(StationsListView)
        End If

        For Each item As PJ In nick_unique

            Try
                If item.locator <> "" Then
                    item.distance = MHDistance(myInfo.locator, item.locator)
                    az = DistBearing.MaidenheadLocator.Azimuth(myInfo.locator, item.locator)
                    item.azmuth = Format(az, "000")
                End If
            Catch ex As Exception

            End Try

        Next

        Dim i As Integer
        For i = npj_count To nick_unique.Count - 1
            If nick_unique(i).webpageindex = PageURLIndex Then
                If History > 0 Then
                    Try
                        If DateDiff("s", nick_unique(i).post, Date.UtcNow) < History Then ' do not show old posts
                            NewListviewItem(nick_unique(i))
                        Else
                            ' remove any posts from freq tree for this call.
                            AddTreeNode(-1, nick_unique(i).callsign.split("/")(0), 0, "Clear", "0")
                        End If
                    Catch ex As Exception
                        NewListviewItem(nick_unique(i))
                    End Try

                Else
                    NewListviewItem(nick_unique(i))
                End If
                'addToDatabase(nick_unique(i))
            End If
        Next
        npj_count = nick_unique.Count



    End Sub

    'Private Sub addQSOToDatabase(ByVal n_pj As PJ, ByVal log() As String)
    '    Dim callsign = n_pj.callsign.Split("/")(0)
    '    Try
    '        'first add station
    '        Me.StationTableAdapter.FillByCallsign(Me.PJCLogBook2DataSet.Station, callsign.ToUpper)
    '        Dim thisrow As PJCLogBook2DataSet.StationRow
    '        If PJCLogBook2DataSet.Station.Rows.Count > 0 Then
    '            thisrow = Me.PJCLogBook2DataSet.Station.Rows(0)
    '            thisrow.post = n_pj.post
    '            thisrow.azmuth = n_pj.asmuth
    '            thisrow.distance = n_pj.distance
    '            thisrow.email = n_pj.email

    '            StationBindingSource.EndEdit()
    '        Else
    '            newStationRow(n_pj)
    '            Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
    '            Me.StationTableAdapter.FillByCallsign(Me.PJCLogBook2DataSet.Station, callsign.ToUpper)
    '            thisrow = Me.PJCLogBook2DataSet.Station.Rows(0)
    '        End If
    '        ' now add QSO
    '        Dim thisQso As PJCLogBook2DataSet.QsoRow
    '        Dim qsoDate = Convert.ToDateTime(log(0))
    '        Dim qsoUTC = Format(Convert.ToDateTime(log(1) + ":00"), "HHmm")
    '        Me.QsoTableAdapter.FillByDateTime(Me.PJCLogBook2DataSet.Qso, qsoDate, qsoUTC)
    '        If PJCLogBook2DataSet.Qso.Rows.Count > 0 Then
    '            ' date utc match
    '            thisQso = Me.PJCLogBook2DataSet.Qso.Rows(0)

    '            thisQso.qsodistance = n_pj.distance
    '            thisQso.qsoazmuth = n_pj.asmuth

    '            If IsDBNull(thisQso.report) Then thisQso.report = ""
    '            If thisQso.report = "" Then

    '                Select Case thisQso.mode
    '                    Case "FSK441"
    '                        thisQso.report = "26"
    '                        thisQso.sent = "26"
    '                    Case "PSK2K"
    '                        thisQso.report = "0dB"
    '                        thisQso.sent = "0dB"
    '                    Case "JT65A", "JT65B"
    '                        thisQso.report = "26"
    '                        thisQso.sent = "26"
    '                    Case Else
    '                        thisQso.report = "599"
    '                        thisQso.sent = "599"
    '                End Select

    '            End If
    '            Select Case thisQso.band
    '                Case "50"
    '                    thisQso.band = "6m"
    '                Case "144"
    '                    thisQso.band = "2m"
    '                Case "222"
    '                    thisQso.band = "1.25m"
    '                Case "432"
    '                    thisQso.band = "70cm"
    '                Case "1296"
    '                    thisQso.band = "13cm"

    '            End Select
    '            Me.QsoBindingSource.EndEdit()
    '        Else
    '            'if not found check for match in date field only
    '            Dim q_date = Convert.ToDateTime(log(0) + " " + log(1) + ":00")
    '            Me.QsoTableAdapter.FillByQSODate(Me.PJCLogBook2DataSet.Qso, q_date)
    '            If PJCLogBook2DataSet.Qso.Rows.Count > 0 Then
    '                ' need to fix date
    '                thisQso = Me.PJCLogBook2DataSet.Qso.Rows(0)
    '                thisQso.qsoUTC = Format(q_date, "HHmm")
    '                thisQso.qsodate = Format(q_date, "yyyy-MM-dd")
    '                thisQso.qsodistance = n_pj.distance
    '                thisQso.qsoazmuth = n_pj.asmuth

    '                If IsDBNull(thisQso.report) Then thisQso.report = ""
    '                If thisQso.report = "" Then

    '                    Select Case thisQso.mode
    '                        Case "FSK441"
    '                            thisQso.report = "26"
    '                            thisQso.sent = "26"
    '                        Case "PSK2K"
    '                            thisQso.report = "0dB"
    '                            thisQso.sent = "0dB"
    '                        Case "JT65A", "JT65B"
    '                            thisQso.report = "26"
    '                            thisQso.sent = "26"
    '                        Case Else
    '                            thisQso.report = "599"
    '                            thisQso.sent = "599"
    '                    End Select

    '                End If
    '                Select Case thisQso.band
    '                    Case "50"
    '                        thisQso.band = "6m"
    '                    Case "144"
    '                        thisQso.band = "2m"
    '                    Case "222"
    '                        thisQso.band = "1.25m"
    '                    Case "432"
    '                        thisQso.band = "70cm"
    '                    Case "1296"
    '                        thisQso.band = "13cm"

    '                End Select
    '                Me.QsoBindingSource.EndEdit()
    '            Else
    '                newQSORow(thisrow.id, qsoDate, qsoUTC, log, n_pj)
    '            End If
    '        End If


    '    Catch ex As Exception
    '        Debug.Print(ex.ToString)
    '    End Try


    '    Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
    'End Sub
    'Private Sub addToDatabase(ByVal n_pj As PJ)
    '    Try
    '        Dim callsign = n_pj.callsign.Split("/")(0)
    '        Me.StationTableAdapter.FillByCallsign(Me.PJCLogBook2DataSet.Station, callsign.ToUpper)
    '        If PJCLogBook2DataSet.Station.Rows.Count > 0 Then

    '            Dim thisrow As PJCLogBook2DataSet.StationRow = Me.PJCLogBook2DataSet.Station.Rows(0)
    '            thisrow.post = n_pj.post
    '        Else
    '            newStationRow(n_pj)
    '        End If
    '        StationBindingSource.EndEdit()

    '        Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
    '    Catch ex As Exception

    '    End Try


    'End Sub

    'Private Sub newQSORow(ByVal station_ID As Integer, ByVal qso_Date As DateTime, ByVal qso_UTC As String, ByVal log() As String, ByVal n_pj As PJ)
    '    Dim newRow As PJCLogBook2DataSet.QsoRow = Me.PJCLogBook2DataSet.Qso.NewRow()
    '    newRow.qsodate = qso_Date
    '    newRow.qsoUTC = qso_UTC
    '    newRow.stationID = station_ID
    '    newRow.band = log(4)
    '    newRow.mode = log(5)
    '    newRow.qsolocator = log(3)
    '    newRow.qsodistance = n_pj.distance
    '    newRow.qsoazmuth = n_pj.asmuth
    '    If newRow.report = "" Then

    '        Select Case newRow.mode
    '            Case "FSK441"
    '                newRow.report = "26"
    '                newRow.sent = "26"
    '            Case "PSK2K"
    '                newRow.report = "0dB"
    '                newRow.sent = "0dB"
    '            Case "JT65A" Or "JT65B"
    '                newRow.report = "26"
    '                newRow.sent = "26"
    '            Case Else
    '                newRow.report = "599"
    '                newRow.sent = "599"
    '        End Select

    '    End If
    '    Select Case newRow.band
    '        Case "50"
    '            newRow.band = "6m"
    '        Case "144"
    '            newRow.band = "2m"
    '        Case "222"
    '            newRow.band = "1.25m"
    '        Case "432"
    '            newRow.band = "70cm"
    '        Case "1296"
    '            newRow.band = "13cm"

    '    End Select

    '    Me.PJCLogBook2DataSet.Qso.Rows.Add(newRow)
    '    Me.QsoBindingSource.EndEdit()

    'End Sub

    'Private Sub newStationRow(ByVal m_pjc As PJ)
    '    Dim newRow As PJCLogBook2DataSet.StationRow = Me.PJCLogBook2DataSet.Station.NewRow()
    '    newRow.callsign = m_pjc.callsign.Split("/")(0).ToUpper
    '    newRow.name = m_pjc.firstname
    '    newRow.locator = m_pjc.locator
    '    newRow.state = m_pjc.state
    '    newRow.email = m_pjc.email
    '    newRow.distance = m_pjc.distance
    '    newRow.azmuth = m_pjc.asmuth
    '    newRow.post = m_pjc.post
    '    newRow.post = m_pjc.post.ToString("yyyy-MM-dd HH:mm:ss")

    '    Me.PJCLogBook2DataSet.Station.Rows.Add(newRow)
    '    Me.StationBindingSource.EndEdit()


    'End Sub

    Private Function findWSJT() As String
        Dim fspec() As String =
        {"C:\Program Files\WSJT9\WSJT.LOG",
         "C:\Program Files (x86)\WSJT9\WSJT.LOG",
         "C:\Program Files\WSJT\WSJT.LOG",
         "C:\Program Files (x86)\WSJT.LOG",
         "C:\WSJT97\WSJT.LOG",
         "C:\WSJT9\WSJT.LOG",
         "C:\WSJT\WSJT.LOG"}


        Try
            For Each f In fspec
                If Dir(f) <> "" Then Return f
            Next

        Catch ex As Exception

        End Try
        Return ""
    End Function

    Private Function findCall3() As String
        Dim fspec() As String =
        {"C:\Program Files\WSJT9\CALL3.TXT",
         "C:\Program Files (x86)\WSJT9\CALL3.TXT",
         "C:\Program Files\WSJT\CALL3.TXT",
         "C:\Program Files (x86)\CALL3.TXT",
         "C:\WSJT97\CALL3.TXT",
         "C:\WSJT9\CALL3.TXT",
         "C:\WSJT\CALL3.TXT"}


        Try
            For Each f In fspec
                If Dir(f) <> "" Then Return f
            Next

        Catch ex As Exception

        End Try
        Return ""
    End Function

    Private Sub readCall3File(ByVal filespec As String)
        Static tryctr As Integer

        If filespec <> "" Then
            Try
                If Dir(filespec) <> "" Then
                    Dim sfilereader = System.IO.File.OpenText(filespec)
                    Dim sinputline = sfilereader.ReadLine()

                    Do Until sinputline Is Nothing

                        Dim log = sinputline.Split(",")
                        If log.Length > 2 Then
                            call3Array.Add(log(0))
                        End If

                        sinputline = sfilereader.ReadLine()
                    Loop

                End If
            Catch ex As Exception
                tryctr += 1
                If tryctr < 4 Then
                    readCall3File(filespec)
                Else
                    MsgBox("Could not access Call3.txt")
                End If



            End Try
        End If
    End Sub

    Private Function chkSQLiteDB(ByVal fspec As String, ByVal callsign As String) As ArrayList
        'Dim my_db As New SQLiteConnection("Data Source=C:\\Users\\dan\\Documents\\N5TM_DB\\N5TM_Full_NextGen.SQLite;Version=3;")
        Try
            Dim my_db As New SQLiteConnection("Data Source=" + fspec + ";Version=3;")
            my_db.Open()
            'Dim sql = "SELECT * FROM Log WHERE LIKE('" + callsign + "%',Call)=1 ORDER BY Band DESC;"
            Dim sql = "SELECT * FROM Log WHERE callsign = '" + callsign + "' ORDER BY Band DESC;"
            Dim command = New SQLiteCommand(sql, my_db)
            Dim reader As SQLiteDataReader
            reader = command.ExecuteReader()
            Dim wrkd As New ArrayList

            While reader.Read()
                Dim ret As String() = {"nil", "", "", "", "", ""}
                ret(0) = reader("qsodate")
                ret(1) = reader("qsodate")
                ret(2) = reader("callsign")
                ret(3) = reader("gridSquare")
                ret(4) = reader("band")
                ret(5) = reader("mode")
                wrkd.Add(ret)
            End While
            my_db.Close()
            Return wrkd
        Catch ex As Exception
            'MsgBox(ex.ToString())
            Dim wrkd As New ArrayList
            Return wrkd
        End Try

    End Function

    Private Function parseADILine(ByVal log As String) As String
        Dim regArray() As String = {"<qso_date:\d>", "<time_on:\d>", "<call:\d{1,2}>", "<my_gridsquare:\d>", "<band:\d>"}
        Dim ret As String = ""
        For Each reg In regArray
            Dim regX As New Regex(reg)
            ret += regX.Split(log)(1).Split("<")(0) + ","
        Next
        'Dim qsoX As New Regex("<qso_date:\d>")
        'Dim qso_date = qsoX.Split(log)(1).Split("<")(0)
        'Dim timeX As New Regex("<time_on:\d>")
        'Dim time_on = timeX.Split(log)(1).Split("<")(0)
        Return ret
    End Function

    Private Sub readLogFile(ByVal filespec As String)
        If useWSJTLog Then
            If filespec <> "" Then
                Try
                    If Dir(filespec) <> "" Then
                        Dim sfilereader = System.IO.File.OpenText(filespec)
                        Dim sinputline = sfilereader.ReadLine()

                        Do Until sinputline Is Nothing

                            Dim log = sinputline.Split(",")
                            If log(0).Contains("ADIF") Then
                                sinputline = sfilereader.ReadLine()
                                Do Until sinputline Is Nothing
                                    Dim adi = parseADILine(sinputline).Split(",")
                                    logArray.Add(adi)
                                    sinputline = sfilereader.ReadLine()
                                Loop
                                Exit Do
                            Else
                                logArray.Add(log)
                                sinputline = sfilereader.ReadLine()
                            End If

                        Loop

                    End If
                Catch ex As Exception

                End Try
            End If

        End If

    End Sub

    Private Delegate Sub SetBoldListViewCallback(ByRef [listview] As Object)
    Private Sub BoldListView(ByRef listview As Object)
        If Me.StationsListView.InvokeRequired Then
            Dim d As New SetBoldListViewCallback(AddressOf BoldListView)
            Me.Invoke(d, New Object() {listview})
        Else
            fbold = New Font(PJTextbox.Font.FontFamily, fontSize, FontStyle.Bold)
            listview.Font = fbold
        End If
    End Sub

    Private Delegate Sub SetInitListViewCallback(ByRef [listView] As Object)
    Private Sub InitListview(ByRef listView As Object)
        If Me.StationsListView.InvokeRequired Then
            Dim d As New SetInitListViewCallback(AddressOf InitListview)
            Me.Invoke(d, New Object() {listView})
        Else
            InitializingListView = True
            StationsListView.Clear()
            ' Set ListView Properties
            'ListView1.View = View.Details
            'ListView1.GridLines = True
            StationsListView.FullRowSelect = True
            StationsListView.HideSelection = False
            StationsListView.MultiSelect = False
            StationsListView.Sorting = SortOrder.Ascending
            Console.Write(StationsListView.Items.Count.ToString())
            'Console.Write(StationsListView.Items(0).Text)
            If m_ColumnNames.Count > 0 Then
                ' Create Columns Headers
                If m_ColumnNames.Item(1) = Nothing Then
                    StationsListView.Columns.Add("Callsign")
                    StationsListView.Columns.Add("Name")
                    StationsListView.Columns.Add("Grid")
                    StationsListView.Columns.Add("Distance")
                    StationsListView.Columns.Add("Azmuth")
                    StationsListView.Columns.Add("State")
                Else
                    StationsListView.Columns.Add(m_ColumnNames.Item(1))
                    StationsListView.Columns.Add(m_ColumnNames.Item(2))
                    StationsListView.Columns.Add(m_ColumnNames.Item(3))
                    StationsListView.Columns.Add(m_ColumnNames.Item(4))
                    StationsListView.Columns.Add(m_ColumnNames.Item(5))
                    StationsListView.Columns.Add(m_ColumnNames.Item(6))
                End If
            End If
            For c = 0 To 5
                    If ColumnWidth(c) > 0 Then
                        StationsListView.Columns(c).Width = ColumnWidth(c)
                    End If

                Next
                ' Record the initial column names.
                m_ColumnNames.Clear()
                For i As Integer = 0 To StationsListView.Columns.Count - 1
                    m_ColumnNames.Add(StationsListView.Columns(i).Text)
                Next i
                callsignIndex = 0
                For Each Item As String In m_ColumnNames
                    If Item = "Callsign" Then
                        Exit For
                    Else
                        callsignIndex += 1
                    End If

                Next
                ' Record the initial column indexes.
                m_ColumnIndexes.Clear()
                For i As Integer = 0 To StationsListView.Columns.Count - 1
                    m_ColumnIndexes.Add(i)
                Next i
            'Console.Write(StationsListView.Items.Count.ToString())
            'Console.Write(StationsListView.Items(0).Text)
            If StationsListView.Items.Count > 0 Then
                StationsListView.Items(0).Remove()
            End If

            InitializingListView = False
            End If
    End Sub



    Private Function set_callColors() As ArrayList

        call_colors.Add(Color.Red)
        call_colors.Add(Color.Green)
        call_colors.Add(Color.Blue)
        call_colors.Add(Color.Violet)
        call_colors.Add(Color.DarkGoldenrod)
        call_colors.Add(Color.DarkCyan)
        call_colors.Add(Color.CornflowerBlue)
        call_colors.Add(Color.Brown)
        call_colors.Add(Color.Crimson)
        call_colors.Add(Color.BlueViolet)
        call_colors.Add(Color.CadetBlue)
        call_colors.Add(Color.BlueViolet)
        call_colors.Add(Color.Coral)
        call_colors.Add(Color.Navy)
        call_colors.Add(Color.DarkMagenta)
        call_colors.Add(Color.DarkRed)
        call_colors.Add(Color.DarkTurquoise)
        call_colors.Add(Color.Firebrick)
        call_colors.Add(Color.ForestGreen)
        call_colors.Add(Color.Fuchsia)
        call_colors.Add(Color.Gold)
        call_colors.Add(Color.GreenYellow)
        Return call_colors
    End Function

    Private Delegate Sub SetListViewCallback(ByVal item As PJ)
    Private Sub NewListviewItem(ByVal item As PJ)

        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.' 
        If Me.PJTextbox.InvokeRequired Then
            Dim d As New SetListViewCallback(AddressOf NewListviewItem)
            Me.Invoke(d, New Object() {item})
        Else

            ' Create List View Item (Row)
            Dim lvi As New ListViewItem
            lvi.SubItems(0).ForeColor = item.nick_color
            If item.logCount > 0 Then
                lvi.SubItems(0).BackColor = Color.Aquamarine
            End If
            ' if not in call3.txt post color
            If WebPagesToolStripComboBox.SelectedIndex > 0 Then
                If Not item.call3 Then
                    lvi.SubItems(0).BackColor = Color.Beige
                End If
            End If

            ' First Column can be the listview item's Text
            ' Folling Columns are sub items
            Dim firstItem As Boolean = True
            ' decide what order the columns are from m_ColumnNames Collection which is saved after are reorder.
            For Each colName As String In m_ColumnNames
                Select Case colName
                    Case "Callsign"
                        If firstItem Then
                            lvi.Text = item.callsign
                            lvi.Name = item.callsign
                            firstItem = False
                        Else
                            lvi.SubItems.Add(item.callsign)
                        End If
                    Case "Name"
                        If firstItem Then
                            lvi.Text = item.firstname
                            firstItem = False
                        Else
                            lvi.SubItems.Add(item.firstname)
                        End If

                    Case "Grid"
                        If firstItem Then
                            lvi.Text = item.locator
                            firstItem = False
                        Else
                            lvi.SubItems.Add(item.locator)
                        End If

                    Case "Azmuth"
                        If firstItem Then
                            lvi.Text = item.azmuth.ToString
                            firstItem = False
                        Else
                            lvi.SubItems.Add(item.azmuth.ToString)
                        End If

                    Case "State"
                        If firstItem Then
                            lvi.Text = item.state
                            firstItem = False
                        Else
                            lvi.SubItems.Add(item.state)
                        End If

                    Case "Distance"
                        If firstItem Then
                            lvi.Text = item.distance.ToString
                            firstItem = False
                        Else
                            lvi.SubItems.Add(item.distance.ToString)
                        End If

                End Select

            Next


            'lvi.SubItems.Add(item.firstname)
            'lvi.SubItems.Add(item.locator)

            ' Third Column is the second sub item

            'lvi.SubItems.Add(item.distance.ToString)
            'lvi.SubItems.Add(item.azmuth.ToString)
            'lvi.SubItems.Add(item.state)
            ' Add the ListViewItem to the ListView
            Dim FoundLVI As Boolean = False

            For Each cs As ListViewItem In StationsListView.Items
                If cs.Text = lvi.Text Then
                    FoundLVI = True
                    Exit For
                End If

            Next

            If Not FoundLVI Then
                StationsListView.Items.Add(lvi)
            End If

            'StationsListView.Items.Add(lvi)

        End If

    End Sub

    Private m_SortingColumn As ColumnHeader

    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles StationsListView.ColumnClick
        ' Get the new sorting column.
        Dim new_sorting_column As ColumnHeader =
            StationsListView.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text =
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        StationsListView.ListViewItemSorter = New _
            ListViewComparer(e.Column, sort_order)

        ' Sort.
        StationsListView.Sort()

    End Sub

    Private Sub StationsListView_ColumnReordered(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles StationsListView.ColumnReordered
        ' Update the column order.

        Dim column_name As String =
            CStr(m_ColumnNames(e.OldDisplayIndex + 1))
        m_ColumnNames.Remove(e.OldDisplayIndex + 1)
        m_ColumnNames.Add(column_name,
            Before:=e.NewDisplayIndex + 1)

        Dim index As Integer =
            CInt(m_ColumnIndexes(e.OldDisplayIndex + 1))
        m_ColumnIndexes.Remove(e.OldDisplayIndex + 1)
        m_ColumnIndexes.Add(index, Before:=e.NewDisplayIndex +
            1)

        ' Display the current name order.
        'For i As Integer = 1 To m_ColumnIndexes.Count
        '    Debug.Write(CStr(m_ColumnNames(i)) & " ")
        'Next i
        'Debug.WriteLine("")

        ' Display the current index order.
        'For i As Integer = 1 To m_ColumnIndexes.Count
        '    Debug.Write(CInt(m_ColumnIndexes(i)) & " ")
        'Next i
        'Debug.WriteLine("")
        SavemyInfoXMLDocument()
    End Sub


    'Private Sub StationsListView_ColumnReordered(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles StationsListView.ColumnReordered

    '    If Not InitializingListView Then
    '        ColumnOrder(e.OldDisplayIndex) = e.NewDisplayIndex
    '        Dim n = StationsListView.Columns(e.OldDisplayIndex).Text
    '        'SavemyInfoXMLDocument()
    '    End If

    'End Sub

    Private Sub ListView1_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles StationsListView.ColumnWidthChanged
        If Not InitializingListView Then
            ColumnWidth(e.ColumnIndex) = StationsListView.Columns(e.ColumnIndex).Width
            SavemyInfoXMLDocument()
        End If
    End Sub

    Private Sub ListView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StationsListView.MouseUp
        Static oldSelectedStation As PJ

        If StationsListView.SelectedIndices.Count = 0 Then Return
        If StationsListView.SelectedItems(0).Text = "" Then Return

        Dim lvi As ListViewItem = StationsListView.SelectedItems(0)

        SelectedStation = ThisPJCInfo(lvi)

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                'logBookFrm = New Logbook
                'logBookFrm.pjc = thisStation.pjc
                'logBookFrm.myInfo = myInfo
                'logBookFrm.Show()
                CallBtn.Text = SelectedStation.callsign.Split("/")(0)
                NameBtn.Text = SelectedStation.firstname
                GridBtn.Text = SelectedStation.locator
                DistLabel.Text = SelectedStation.distance
                AzmuthLabel.Text = SelectedStation.azmuth
                StateLabel.Text = SelectedStation.state
                'GetMoonRiseSet(CallLabel.Text)
                Me.InfoTabControl.TabPages(2).Text = SelectedStation.callsign.Split("/")(0)

                ' turn off highlite for previously selected station
                If Not IsNothing(oldSelectedStation) Then
                    oldSelectedStation.highlite = False
                End If
                'turn on highlite for selected station
                SelectedStation.highlite = True
                oldSelectedStation = SelectedStation
                Me.SelectedStationsTextBox.Text = ""

                For Each Item As String In SelectedStation.posts
                    Me.SelectedStationsTextBox.Text += (Item + Chr(13) + Chr(10))
                Next

            Case Windows.Forms.MouseButtons.Right
                Me.ContextMenuStrip1.Show(MousePosition)

        End Select

    End Sub

    Private Sub PJClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.RetrievePJPage.StopWebClient = True
        SavemyInfoXMLDocument()
        'DXCluster.StopTelnet = True
        'Me.ThreadDXCluster.Abort()
        'Me.ThreadRetrievePJPage.Abort()
    End Sub

    Private Sub NewInfofromDialog(ByVal nickname As String, ByVal callsign As String, ByVal state As String, ByVal grid As String, ByVal firstname As String,
                                  ByVal email As String)

        readLogFile(WSJTLogPath)
        LoadmyInfoXMLDocument()

    End Sub

    Private Sub RetrievePJPageFromThread(ByVal str As String)

        PostReponse(str)
        If npj_count <> nick_unique.Count Then

            'InitListview()
            FillListview()

        End If
        If npj_count = 0 Then

            'InitListview()
            FillListview()

        End If

        SetStatusLabelText("Last Update: " & Date.UtcNow.ToString("HH:mm:ss UTC"), Me.ToolStripStatusLabel1)
        'Me.ToolStripStatusLabel1.Text = "Last Update: " & Date.UtcNow.ToString("HH:mm:ss UTC")
    End Sub

    'Private Sub GetMoonRiseSet(ByVal callsign As String)
    '    If DXCluster.connected Then
    '        getMoonFlag = True
    '        DXCluster.SendCommand("show/moon" + " " + callsign)
    '    End If

    'End Sub

    Private Function PostTimeToDate(ByVal t1 As String) As Date
        Try
            Dim t1Date = t1.Split(" ")(0).Split("/")  ' 0 = month, 1 = day
            Dim t1Time = t1.Split(" ")(1).Split(":")  ' 0 = hour, 1 = minute
            Dim d = Now.Year.ToString + "-" + t1Date(0) + " " + t1Time(0) + ":" + t1Time(1) + ":" + "00"
            Dim ret = DateTime.Parse(d)
            Return ret
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try

    End Function

    Private Function NewestTime(ByVal t1 As String, ByVal t2 As String) As String
        Try
            Dim t1Date = t1.Split(" ")(0).Split("/")  ' 0 = month, 1 = day
            Dim t2Date = t2.Split(" ")(0).Split("/")
            Dim t1Time = t1.Split(" ")(1).Split(":")  ' 0 = hour, 1 = minute
            Dim t2Time = t2.Split(" ")(1).Split(":")
            If t1Date(0) = 12 And t2Date(0) = 1 Then ' check year roll over
                Return t2
            Else
                If t1Date(1) < t2Date(1) Then  'check month
                    Return t2
                Else
                    If t1Date(0) < t2Date(0) Then ' check day
                        Return t2
                    Else
                        If t1Time(0) < t2Time(0) Then ' check hour
                            Return t2
                        Else
                            If t1Time(1) < t2Time(1) Then 'check minute
                                Return t2
                            Else
                                Return t1
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Return t1
        End Try

    End Function

    Private Sub PostReponse(ByVal str As String)

        Dim r As New Regex("DDMMM  UTC")
        ' get body of message ignor junk on top.

        Dim posted = r.Split(str)
        If posted.Length > 1 Then


            ' find time/date
            Dim dt As New Regex("\d\d\w\w\w \d\d:\d\d")
            Dim de As New Regex("This service")
            Dim textpart = de.Split(posted(1))
            Dim wholeline = dt.Split(textpart(0))
            Dim dte = dt.Matches(textpart(0))
            ' find nick names
            Dim n As New Regex(">.*</a>")
            Dim n1 As New Regex("(.*)")
            Dim n2 As New Regex("{.*}")
            Dim ip As New Regex("\d{1,3}.\.\d{1,3}")  '.\.\d{1,3}.\.\d{1,3}")
            'Dim n2 As New Regex("</a>.*)")
            'find email
            Dim e As New Regex("mailto(.*)''")
            'Dim email = e.Matches(textpart(0))
            Dim nick = n.Matches(textpart(0))
            'Dim nick2 = n2.Matches(posted(1))
            ' find text
            'Dim t As New Regex("\(.*</a>")
            Dim t As New Regex("\(<a href.*</a>")
            Dim tJT65A As New Regex("====== {.*</a>")
            Dim txt = n.Split(textpart(0))

            'Dim nick_color As New ArrayList
            'nick_color.Clear()
            'Static nick_unique As New ArrayList
            'nick_unique.Clear()
            Static post_time(dte.Count) As String
            Static post_nick(dte.Count) As String
            Static post_text(dte.Count) As String
            Static post_email(dte.Count) As String

            Static old_postTime(dte.Count) As String
            Dim i As Integer = 0

            Try
                Dim myNick As System.Text.RegularExpressions.Match
                ' start over with freq_post arraylist
                freq_post.Clear()

                For i = 0 To dte.Count - 1
                    If wholeline(i + 1).Length > 2 Then

                        myNick = n.Match(wholeline(i + 1))
                        If myNick.Success Then
                            Dim nn = (wholeline(i + 1).Substring(wholeline(i + 1).IndexOf(">") + 1)).Split("</a>")
                            Dim nnn = ip.Split(nn(1))
                            Dim ipaddr = ip.Match(wholeline(i + 1))
                            post_nick(i) = nn(0) + nnn(0).Substring(3)

                        Else
                            If PageURLIndex > 0 Then
                                myNick = n2.Match(wholeline(i + 1))
                            Else
                                myNick = n1.Match(wholeline(i + 1))
                            End If


                            If myNick.Length > 1 Then
                                If myNick.Value.Contains(SplitChar) Then
                                    Dim nn = wholeline(i + 1).Substring(wholeline(i + 1).IndexOf(SplitChar) - 1)
                                    Dim nnn = ip.Split(nn)
                                    post_nick(i) = nnn(0).Substring(2)

                                End If
                            End If

                        End If
                        ' this was added to clean up a dangling } or ) after a page change by Chris Sept 2021
                        If PageURLIndex > 0 Then
                            Dim tpost_nick = post_nick(i).Split("}")
                            post_nick(i) = tpost_nick(0)
                        Else
                            Dim tpost_nick = post_nick(i).Split(")")
                            post_nick(i) = tpost_nick(0)
                        End If

                        Dim split_nick = post_nick(i).Split(" ")

                        Dim npj = New PJ
                        post_time(i) = dte.Item(i).Value

                        Dim item_found = False
                        Dim item_index = 0
                        ' check all items in nick_unique for this nickname
                        For Each Item As PJ In nick_unique
                            If Item.nickname = post_nick(i) Then
                                item_found = True
                                npj = Item
                                Dim post_old = nick_unique.Item(item_index).post
                                Dim post_new = PostTimeToDate(post_time(i))
                                Try
                                    Dim ddiff = DateDiff("s", PostTimeToDate(post_time(i)), nick_unique.Item(item_index).post)
                                    If ddiff <= 0 Then
                                        nick_unique.Item(item_index).post = PostTimeToDate(post_time(i))
                                    End If
                                Catch ex As Exception

                                End Try



                            End If
                            item_index += 1
                        Next


                        ' if not found in nick_unique, add it to collection
                        If Not item_found Then
                            npj.callsign = split_nick(0).Split("/")(0)
                            npj.firstname = split_nick(1)
                            npj.state = split_nick(2)
                            npj.locator = split_nick(3)
                            npj.distance = MHDistance(myInfo.locator, npj.locator)
                            npj.azmuth = MHAzmuth(myInfo.locator, npj.locator)
                            npj.nickname = post_nick(i)
                            npj.post = PostTimeToDate(post_time(i))

                            'npj.nick_color = RandomQBColor()
                            npj.nick_color = call_colors.Item(nick_unique.Count Mod 12)
                            npj.WebPageIndex = PageURLIndex  ' which web page we are on PJ or EME-1,EME-2 Terrestrial 

                            ' extract email address
                            Try
                                Dim em = e.Match(wholeline(i + 1)).ToString.Replace("','", "@")
                                If em.Length > 0 Then
                                    npj.email = Mid(em, 9, em.Length - 10)
                                End If
                            Catch ex As Exception
                                Console.Write(ex.ToString())
                            End Try
                            Try


                                ' is this call in WSJT Log?
                                For Each item In logArray
                                    If item.length > 1 Then
                                        If item(2).ToString.Contains(Mid(split_nick(0), 1, item(2).ToString.Length)) Then
                                            npj.logged(-1) = item
                                            'npj.distance = MHDistance(myInfo.locator, npj.locator)
                                            'npj.asmuth = MHAzmuth(myInfo.locator, npj.locator)
                                            'addQSOToDatabase(npj, item)
                                        End If
                                    End If


                                Next
                                '-------- check the Log4OM SQLite database for worked stations.
                                If useSQLiteDB Then
                                    Dim Log4OM = chkSQLiteDB(WSJTLogPath, split_nick(0).Split("/")(0))
                                    For Each item In Log4OM
                                        npj.logged(-1) = item
                                    Next
                                End If

                            Catch ex As Exception
                                If Not DontShowDBException Then
                                    MsgBox("Database or ADIF File problems (check settings)")
                                    DontShowDBException = True
                                End If
                            End Try

                            If PageURLIndex > 0 Then
                                ' is this call in Call3.txt?
                                If call3Array.Contains(npj.callsign.Split("/")(0)) Then
                                    npj.call3 = True
                                Else
                                    SetStatusLabelText("Some stations on page not in Call3.txt, Use menu to add.", Me.ToolStripStatusLabel2)
                                End If
                            End If

                            'npj.xstation = xStation
                            xStationXML.SaveStationElement(npj)
                            nick_unique.Add(npj)




                        End If



                        'post_time(i) = dt.Split(wholeline(i))
                        'post_time(i) = dte.Item(i).Value
                        'post_email(i) = email.Item(i).Value
                        'post_nick(i) = nick.Item(i).Value.Substring(1, nick.Item(i).Value.IndexOf("<") - 1)

                        'find last occurance of (
                        'Dim s = wholeline(i + 1).Split("\(.<a")
                        'Dim p = 0

                        If InStr(wholeline(i + 1), "<a href") Then
                            ' email embended post
                            Dim temp = t.Split(wholeline(i + 1))
                            If PageURLIndex > 0 Then
                                post_text(i) = tJT65A.Split(wholeline(i + 1))(0)
                            Else
                                post_text(i) = t.Split(wholeline(i + 1))(0)
                            End If

                        Else
                            ' non email embedded post
                            Dim p = wholeline(i + 1).IndexOf(SplitChar & post_nick(i))
                            If p > 1 Then
                                post_text(i) = wholeline(i + 1).Substring(1, p - 1)

                            End If

                        End If

                        '----save all posts for each station
                        If npj.posts.Count > 0 Then

                            If Not npj.posts.Contains(post_time(i).Split(" ")(1) + ": " + post_text(i)) Then
                                Dim pdiff = DateDiff("s", PostTimeToDate(post_time(i)), npj.post)
                                If pdiff > 0 Then
                                    npj.posts.Add(post_time(i).Split(" ")(1) + ": " + post_text(i))
                                Else
                                    npj.posts.Insert(0, (post_time(i).Split(" ")(1) + ": " + post_text(i)))
                                End If
                                'if this station is in tab update
                                If Me.InfoTabControl.TabPages(2).Text = npj.callsign.Split("/")(0) Then

                                    Me.SelectedStationsTextBox.Text = ""

                                    For Each Item As String In npj.posts
                                        Me.SelectedStationsTextBox.Text += (Item + Chr(13) + Chr(10))
                                    Next
                                End If
                            End If
                        Else
                            npj.posts.Add(post_time(i).Split(" ")(1) + ": " + post_text(i))
                        End If
                        '--------------
                        If post_text(i) = Nothing Then post_text(i) = wholeline(i)
                        Dim infoPost = post_text(i).Split("~")

                        If infoPost.Count > 2 Then

                            Dim encrPost = post_text(i).Replace("~Plus~", "+")
                            encrPost = encrPost.Replace("~Percent~", "%")
                            encrPost = encrPost.Replace("~http~", "http://")
                            encrPost = encrPost.Replace("~GT~", ">")
                            encrPost = encrPost.Replace("~LT~", "<")
                            encrPost = encrPost.Replace("~w.w.w~", "www")
                            post_text(i) = encrPost
                            Dim cmd = infoPost(1)
                            If cmd.IndexOf("CQ") <> -1 Then
                                If infoPost.Count > 3 Then
                                    cmd = cmd + infoPost(3)
                                End If
                            End If
                            If cmd.IndexOf("Running") <> -1 Then
                                If infoPost.Count > 3 Then
                                    cmd = cmd + infoPost(3)
                                End If
                            End If
                            If cmd.IndexOf("QRV") <> -1 Then
                                If infoPost.Count > 3 Then
                                    cmd = cmd + infoPost(3)
                                End If
                            End If
                            If cmd.Contains("CQ") Or cmd.Contains("Running") Or cmd.Contains("QRV") Or cmd.Contains("Clear") Then
                                Dim freq = infoPost(2)
                                If freq_post.Contains(split_nick(0)) Then
                                    ' this is older post of frequency
                                    AddTreeNode(freq, split_nick(0).Split("/")(0), 1, cmd, post_time(i).Split(" ")(1))
                                Else
                                    ' this is most recent post of frequency
                                    If IsNumeric(freq) Then
                                        freq_post.Add(split_nick(0))
                                        AddTreeNode(freq, split_nick(0).Split("/")(0), 0, cmd, post_time(i).Split(" ")(1))
                                    End If

                                End If
                            End If



                        End If
                    End If

                Next i

                ' find new messages
                i = 0
                If RefreshPage Then
                    old_postTime(0) = ""
                    RefreshPage = False
                End If

                While post_time(i) + post_nick(i) + post_text(i) <> old_postTime(0)
                    i += 1
                    If i >= dte.Count Then Exit While
                End While



                For i = dte.Count - i To dte.Count - 1

                    SetColor(Color.DarkGray, False, PJTextbox)
                    SetText(post_time(dte.Count - 1 - i) + " ", PJTextbox)

                    Dim npj = New PJ
                    For Each Item As PJ In nick_unique
                        If Item.nickname = post_nick(dte.Count - 1 - i) Then

                            npj = Item
                        End If
                    Next

                    If npj.highlite = True Then
                        SetColor(npj.nick_color, True, PJTextbox)
                    Else
                        SetColor(npj.nick_color, False, PJTextbox)
                    End If

                    SetText(post_nick(dte.Count - 1 - i), PJTextbox)

                    SetColor(Color.LightBlue, False, PJTextbox)
                    SetText("=> ", PJTextbox)

                    SetColor(Color.DarkGreen, False, PJTextbox)
                    Dim newtext = post_text(dte.Count - 1 - i)
                    Dim highliteThis As Boolean

                    If myInfo.callsign = "" Then
                        myInfo.callsign = myInfo.nickname.Split(" ")(0).Split("/")(0)
                    End If

                    'does this post contain my callsign?
                    If InStr(1, newtext.ToUpper, myInfo.callsign.ToUpper) > 0 Then
                        highliteThis = True
                        If myInfo.Away Then
                            postMsg(myInfo.awaymsg)
                        End If
                    End If

                    If npj.highlite = True Then
                        highliteThis = True
                    End If
                    If highliteThis Then
                        SetColor(Color.Red, True, PJTextbox)
                    Else
                        SetColor(myTextcolor, False, PJTextbox)
                    End If
                    highliteThis = False
                    SetText(post_text(dte.Count - 1 - i) + Chr(13) + Chr(10), PJTextbox)


                    If InStr(1, newtext.ToUpper, "CQ") Or InStr(1, newtext.ToUpper, "QRV") Or InStr(1, newtext.ToUpper, "RUNNING..") Then
                        SetColor(Color.DarkGray, False, CQTextBox)
                        SetText(post_time(dte.Count - 1 - i) + " ", CQTextBox)

                        SetColor(npj.nick_color, False, CQTextBox)

                        SetText(post_nick(dte.Count - 1 - i), CQTextBox)

                        SetColor(Color.Blue, False, CQTextBox)
                        SetText("=> ", CQTextBox)

                        SetColor(myTextcolor, False, CQTextBox)


                        SetText(post_text(dte.Count - 1 - i) + Chr(13) + Chr(10), CQTextBox)

                    End If

                Next i
                'age old calls in listview, refresh after 60 postings 5 seconds apart = 5 minutes
                minutetimer += 1
                If minutetimer > 10 Then
                    minutetimer = 0
                    reFillListview()
                End If
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
            For i = 0 To dte.Count - 1

                old_postTime(i) = post_time(i) + post_nick(i) + post_text(i)
                i += 1
            Next
        Else
            MsgBox("PJ failed to return proper page.")
        End If

    End Sub

    Function searchTreeview(ByVal SearchString As String, ByVal Nodes As TreeNodeCollection,
    Optional ByVal ExactMatch As Boolean = False,
    Optional ByVal Recursive As Boolean = True) _
    As TreeNode
        Dim ret As TreeNode
        For Each tn As TreeNode In Nodes
            If ExactMatch = True Then
                If tn.Text = SearchString Then Return tn
            Else
                If tn.Text.IndexOf(SearchString) <> -1 Then Return tn
            End If

            If Recursive = True Then
                If tn.Nodes.Count > 0 Then
                    ret = searchTreeview(SearchString, tn.Nodes, ExactMatch, Recursive)
                    If Not ret Is Nothing Then Return ret
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Delegate Sub AddTreeNodeCallback(ByVal [freq] As String, ByVal [callsign] As String, ByVal [i] As Integer, ByVal [cmd] As String, ByVal [t] As String)
    Private Sub AddTreeNode(ByVal [freq] As String, ByVal [callsign] As String, ByVal [i] As Integer, ByVal [cmd] As String, ByVal [t] As String)
        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.'

        If Me.PJTextbox.InvokeRequired Then
            Dim d As New AddTreeNodeCallback(AddressOf AddTreeNode)
            Me.Invoke(d, New Object() {freq, callsign, i, cmd, t})
        Else
            If i > 0 Then
                ' older post
                ' any clean up for older post could go here.

            Else
                ' most recent post
                If cmd.Contains("Clear") Then

                    ' remove callsign from any node
                    For Each fnode As TreeNode In FreqTreeView.Nodes
                        Dim rn = searchTreeview(callsign, fnode.Nodes, False, True)
                        If Not rn Is Nothing Then
                            ' remove callsign from this node
                            FreqTreeView.SelectedNode = rn
                            fnode.Nodes.Remove(FreqTreeView.SelectedNode)
                        End If
                    Next
                Else
                    ' add or change freq/callsign nodes
                    ' does frequency node exist?
                    Dim freqnode As TreeNode = searchTreeview(freq, FreqTreeView.Nodes, False, True)
                    If Not freqnode Is Nothing Then
                        ' remove callsign from any other nodes
                        For Each fnode As TreeNode In FreqTreeView.Nodes
                            Dim rn = searchTreeview(callsign, fnode.Nodes, False, True)
                            If Not rn Is Nothing Then
                                ' remove callsign from this node
                                FreqTreeView.SelectedNode = rn
                                fnode.Nodes.Remove(FreqTreeView.SelectedNode)
                            End If
                        Next
                        ' freqnode exists, check callsign node
                        Dim callnode As TreeNode = searchTreeview(callsign, freqnode.Nodes, False, True)
                        If callnode Is Nothing Then
                            ' create new callsign node
                            FreqTreeView.SelectedNode = freqnode
                            freqnode.Nodes.Add(callsign + " - " + t + " " + cmd)
                            'callnode = searchTreeview(callsign, freqnode.Nodes, False, True)
                            'If Not callnode Is Nothing Then
                            '    callnode.Nodes.Add(cmd)
                            'End If

                        End If

                    Else
                        ' frequency node does not exist
                        ' remove callsign from any other nodes

                        For Each fnode As TreeNode In FreqTreeView.Nodes
                            Dim rn = searchTreeview(callsign, fnode.Nodes, False, True)
                            If Not rn Is Nothing Then
                                ' remove callsign from this node
                                FreqTreeView.SelectedNode = rn
                                fnode.Nodes.Remove(FreqTreeView.SelectedNode)
                            End If
                        Next

                        ' create new freqnode
                        freqnode = FreqTreeView.Nodes.Add(freq)
                        FreqTreeView.SelectedNode = freqnode
                        freqnode.Nodes.Add(callsign + " - " + t + " " + cmd)
                        'Dim callnode As TreeNode = searchTreeview(callsign, freqnode.Nodes, False, True)
                        'If Not callnode Is Nothing Then
                        '    callnode.Nodes.Add(cmd)
                        'End If
                    End If
                    'remove any blank frequency nodes
                End If
                For Each fnode As TreeNode In FreqTreeView.Nodes
                    If fnode.Nodes.Count = 0 Then
                        'remove freq node
                        FreqTreeView.SelectedNode = fnode
                        fnode.Nodes.Remove(FreqTreeView.SelectedNode)
                    End If

                Next


            End If

        End If
    End Sub

    Private Delegate Sub SetStatusLabelTextCallback(ByVal [text] As String, ByRef [tslabel] As Object)
    Private Sub SetStatusLabelText(ByVal text As String, ByRef tslabel As Object)

        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.' 
        If Me.PJTextbox.InvokeRequired Then
            Dim d As New SetStatusLabelTextCallback(AddressOf SetStatusLabelText)
            Me.Invoke(d, New Object() {text, tslabel})
        Else
            tslabel.Text = text
        End If
    End Sub

    Private Delegate Sub SetLengthCallback(ByVal [len] As Integer)
    Private Sub SetLength(ByVal newlength As Integer)

        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.' 
        If Me.PJTextbox.InvokeRequired Then
            Dim d As New SetLengthCallback(AddressOf SetLength)
            Me.Invoke(d, New Object() {newlength})
        Else
            PJTextbox.SelectionStart = newlength
        End If
    End Sub

    Private Delegate Sub SetBackgroundCallback(ByVal [color] As Color)
    Private Sub SetBackground(ByVal newcolor As Color)

        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.' 
        If Me.PJTextbox.InvokeRequired Then
            Dim d As New SetColorCallback(AddressOf SetColor)
            Me.Invoke(d, New Object() {newcolor})
        Else
            PJTextbox.SelectionBackColor = newcolor
        End If
    End Sub

    Private Delegate Sub SetColorCallback(ByVal [color] As Color, ByVal [highlite] As Boolean, ByRef [textbox] As Object)
    Private Sub SetColor(ByVal newcolor As Color, ByVal highlite As Boolean, ByRef textBox As Object)

        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.' 
        If Me.PJTextbox.InvokeRequired Then
            Dim d As New SetColorCallback(AddressOf SetColor)
            Me.Invoke(d, New Object() {newcolor, highlite, textBox})
        Else
            If highlite Then
                textBox.SelectionBackColor = Color.Chartreuse
                textBox.SelectionColor = newcolor
            Else
                textBox.SelectionColor = newcolor
            End If

        End If
    End Sub

    Private Delegate Sub SetTextCallback(ByVal [text] As String, ByRef [textBox] As Object)
    Private Sub SetText(ByVal newtext As String, ByRef textBox As Object)

        ' InvokeRequired required compares the thread ID of the' 
        ' calling thread to the thread ID of the creating thread.' 
        ' If these threads are different, it returns true.' 
        If Me.PJTextbox.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {newtext, textBox})
        Else
            textBox.SelectionStart = PJTextbox.Text.Length
            textBox.AppendText(newtext)
            textBox.ScrollToCaret()
            'PJTextbox.SelectionStart = PJTextbox.Text.Length
            'PJTextbox.AppendText(newtext)
            'PJTextbox.ScrollToCaret()
        End If
    End Sub


    Dim m_Rnd As New Random

    ' Return a random QB color.
    Public Function RandomQBColor() As Color
        Static seq_color As Integer
        Static color_array As New ArrayList
        Dim color_num As Integer
        If color_array.Count < 15 Then
            seq_color += 1
            color_num = seq_color
            'color_num = m_Rnd.Next(0, 15)

            While color_array.Contains(color_num)
                'color_num = m_Rnd.Next(0, 15)
                color_num = seq_color
            End While
        End If
        color_array.Add(color_num)

        Return Color.FromArgb(QBColor(color_num)) ' + &HFF)

    End Function

    Private Sub SendButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendButton.Click
        Dim msgToPost = Me.MsgTextBox.Text.Replace("%", "~Percent~")
        msgToPost = msgToPost.Replace("+", "~Plus~")
        msgToPost = msgToPost.Replace("http://", "~http~")
        msgToPost = msgToPost.Replace(">", "~GT~")
        msgToPost = msgToPost.Replace("<", "~LT~")
        msgToPost = msgToPost.Replace("www", "~w.w.w~")
        postMsg(msgToPost)
        'PostReponse(postMsg(msgToPost))
        RetrievePJPage.refreshtime = 5000
        Me.MsgTextBox.Text = ""
        Me.MsgTextBox.Focus()

        'If logQSO Then
        '    LogThisQSO(current_PJ)
        'End If
    End Sub

    Private Function webrequest(ByVal MsgToPost As String, ByVal ConnectURL As String) As HttpWebResponse
        Dim CookieJar As New CookieContainer
        Dim CookieList As New CookieCollection
        Dim PostData As String

        'Try
        Dim Request As HttpWebRequest = HttpWebRequest.Create(ConnectURL)
        Request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.14) Gecko/20080404 Firefox/2.0.0.14"
        Request.CookieContainer = CookieJar
        Request.AllowAutoRedirect = False
        If PageURLIndex = 0 Then
            Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("callsign", myInfo.nickname))
        Else
            Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("callsign", myInfo.nickname2))
        End If

        Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("firstname", myInfo.firstname))
        Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("state", myInfo.state))
        Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("locator", myInfo.locator))
        Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("email", myInfo.email))
        'Turn POST login string into ASCII and insert into Request... somehow 
        Request.ContentType = "application/x-www-form-urlencoded"
        PostData = MsgToPost
        Request.Method = "POST"

        Request.ContentLength = PostData.Length
        Dim requestStream As Stream = Request.GetRequestStream()
        Dim postBytes As Byte() = Encoding.ASCII.GetBytes(PostData)
        requestStream.Write(postBytes, 0, postBytes.Length)
        requestStream.Close()
        Request.AllowAutoRedirect = False
        'POST query, and display cookies 
        Dim Response As HttpWebResponse = Request.GetResponse()
        Return Response

    End Function

    Private Function postMsg(ByVal MsgToPost As String) As String
        'Dim Stream As Stream
        Dim CookieJar As New CookieContainer
        Dim CookieList As New CookieCollection
        'Dim PostData As String

        Dim ConnectURL = PageURL(PageURLIndex)
        'Const ConnectURL = "http://www.pingjockey.net/cgi-bin/pingtalk/"
        'Const EME1URL = "http://www.chris.org/cgi-bin/jt65emeA"
        myposts.Add(Date.UtcNow)
        'chkposts()

        Try
            'Dim Request As HttpWebRequest = HttpWebRequest.Create(ConnectURL)
            'Request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.14) Gecko/20080404 Firefox/2.0.0.14"
            'Request.CookieContainer = CookieJar
            'Request.AllowAutoRedirect = False
            'If PageURLIndex = 0 Then
            '    Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("callsign", myInfo.nickname))
            'Else
            '    Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("callsign", myInfo.nickname2))
            'End If

            'Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("firstname", myInfo.firstname))
            'Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("state", myInfo.state))
            'Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("locator", myInfo.locator))
            'Request.CookieContainer.Add(New Uri(ConnectURL), New Cookie("email", myInfo.email))
            ''Turn POST login string into ASCII and insert into Request... somehow 
            'Request.ContentType = "application/x-www-form-urlencoded"
            'PostData = MsgToPost
            'Request.Method = "POST"

            'Request.ContentLength = PostData.Length
            'Dim requestStream As Stream = Request.GetRequestStream()
            'Dim postBytes As Byte() = Encoding.ASCII.GetBytes(PostData)
            'requestStream.Write(postBytes, 0, postBytes.Length)
            'requestStream.Close()
            'Request.AllowAutoRedirect = False
            ''POST query, and display cookies 
            'Dim Response As HttpWebResponse = Request.GetResponse()
            ''For Each tempCookie In Response.Cookies
            ''    CookieJar.Add(tempCookie)
            ''    'RichTextBox1.AppendText(tempCookie.ToString)
            ''Next

            ''How to display BODY from response stream? 
            'Stream = Response.GetResponseStream
            Dim Response = webrequest(MsgToPost, ConnectURL)

            If Response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader =
                  New IO.StreamReader(Response.GetResponseStream())
                Dim responseData = responseStream.ReadToEnd()
                Return responseData
            Else
                If Response.StatusCode = Net.HttpStatusCode.Redirect Then
                    Dim newUrl As String = Response.Headers("Location")
                    PageURL(PageURLIndex) = newUrl
                    Response = webrequest(MsgToPost, newUrl)
                    If Response.StatusCode = Net.HttpStatusCode.OK Then
                        Dim responseStream As IO.StreamReader =
                  New IO.StreamReader(Response.GetResponseStream())
                        Dim responseData = responseStream.ReadToEnd()
                        Return responseData
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Return ""
    End Function

    'Private Sub chkposts()
    '    If myposts.Count > 10 Then
    '        If DateDiff(DateInterval.Minute, myposts.Item(myposts.Count - 10), myposts.Item(myposts.Count - 1)) < 10 Then
    '            Me.ToolStripStatusLabel3.Text = "Your post rate is high, Please use page for QSO related posts only."
    '        Else
    '            Me.ToolStripStatusLabel3.Text = ""
    '        End If
    '    End If



    'End Sub

    Private Sub MsgTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MsgTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim msgToPost = Me.MsgTextBox.Text.Replace("%", "~Percent~")
            msgToPost = msgToPost.Replace("+", "~Plus~")
            msgToPost = msgToPost.Replace("http://", "~http~")
            msgToPost = msgToPost.Replace(">", "~GT~")
            msgToPost = msgToPost.Replace("<", "~LT~")
            msgToPost = msgToPost.Replace("www", "~w.w.w~")
            postMsg(msgToPost)
            'postMsg(Me.MsgTextBox.Text)
            RetrievePJPage.refreshtime = 5000
            'PostReponse(postMsg(Me.MsgTextBox.Text))
            Me.MsgTextBox.Text = ""
            Me.MsgTextBox.Focus()
        End If
    End Sub

    Private Sub LoadmyInfoXMLDocument()

        Try
            xInfo = XDocument.Load(DataPath + "\Info.xml")
            myInfo.nickname = xInfo.<Info>.<nickname>.Value
            myInfo.nickname2 = xInfo.<Info>.<nickname2>.Value
            myInfo.callsign = xInfo.<Info>.<callsign>.Value
            myInfo.firstname = xInfo.<Info>.<firstname>.Value
            myInfo.locator = xInfo.<Info>.<locator>.Value
            myInfo.state = xInfo.<Info>.<state>.Value
            myInfo.email = xInfo.<Info>.<email>.Value
            useWSJTLog = Convert.ToBoolean(xInfo.<Info>.<useWSJTLog>.Value)
            useSQLiteDB = Convert.ToBoolean(xInfo.<Info>.<useSQLiteDB>.Value)
            WSJTLogPath = xInfo.<Info>.<WSJTLog>.Value
            Me.Call3WSJTPath = xInfo.<Info>.<Call3WSJT>.Value
            Me.Call3MAP65Path = xInfo.<Info>.<Call3MAP65>.Value
            Try
                Me.Call3WSJTXPath = xInfo.<Info>.<Call3WSJTX>.Value
            Catch ex As Exception
                Me.Call3WSJTXPath = ""
            End Try
            myInfo.awaymsg = xInfo.<Info>.<awaymsg>.Value
            If xInfo.<Info>.<away>.Value = "true" Then
                myInfo.Away = True
                AwayToolStripMenuItem.Checked = True
                OnPageToolStripMenuItem.Checked = False
            Else
                myInfo.Away = False
                AwayToolStripMenuItem.Checked = False
                OnPageToolStripMenuItem.Checked = True
            End If

            myInfo.WSJTLogPath = WSJTLogPath
            fontSize = xInfo.<Info>.<fontSize>.Value
            Dim fontsize_str = fontSize.ToString.Split(".")(0)
            fontSize = Convert.ToSingle(fontsize_str)
            If fontSize < 5 Or fontSize > 18 Then
                fontSize = 10
            End If
            myInfo.metric = metricDistance
            myInfo.QRZUser = xInfo.<Info>.<QRZuser>.Value
            myInfo.QRZpwd = xInfo.<Info>.<QRZpwd>.Value
            TelnetURL = xInfo.<Info>.<dxcluster>.Value

            Try
                fontbold = xInfo.<Info>.<fontbold>.Value
            Catch ex As Exception
                fontbold = False
            End Try
            If fontbold Then Me.BoldToolStripMenuItem.Checked = True

            metricDistance = xInfo.<Info>.<metric>.Value
            'myBackcolor = Color.Black
            Me.PJTextbox.BackColor = myBackcolor
            Me.StationsListView.BackColor = myBackcolor
            CQTextBox.BackColor = myBackcolor
            Me.PJTextbox.ForeColor = myTextcolor
            Me.StationsListView.ForeColor = myTextcolor
            Me.CQTextBox.ForeColor = myTextcolor
            Me.SelectedStationsTextBox.ForeColor = myTextcolor
            Me.SelectedStationsTextBox.BackColor = myBackcolor

            History = xInfo.<Info>.<history>.Value
            'logQSOs = xInfo.<Info>.<logQSOs>.Value
            ColumnWidth(0) = xInfo.<Info>.<column0>.Value
            ColumnWidth(1) = xInfo.<Info>.<column1>.Value
            ColumnWidth(2) = xInfo.<Info>.<column2>.Value
            ColumnWidth(3) = xInfo.<Info>.<column3>.Value
            ColumnWidth(4) = xInfo.<Info>.<column4>.Value
            ColumnWidth(5) = xInfo.<Info>.<column5>.Value

            myInfo.band(0) = xInfo.<Info>.<station1>.<band>.Value
            myInfo.power(0) = xInfo.<Info>.<station1>.<power>.Value
            myInfo.antenna(0) = xInfo.<Info>.<station1>.<antenna>.Value

            myInfo.band(1) = xInfo.<Info>.<station2>.<band>.Value
            myInfo.power(1) = xInfo.<Info>.<station2>.<power>.Value
            myInfo.antenna(1) = xInfo.<Info>.<station2>.<antenna>.Value

            myInfo.band(2) = xInfo.<Info>.<station3>.<band>.Value
            myInfo.power(2) = xInfo.<Info>.<station3>.<power>.Value
            myInfo.antenna(2) = xInfo.<Info>.<station3>.<antenna>.Value
            webpagefontsize = xInfo.<Info>.<WebPageFontSize>.Value
            m_ColumnNames.Clear()
            m_ColumnNames.Add(xInfo.<Info>.<columnHeader0>.Value)
            m_ColumnNames.Add(xInfo.<Info>.<columnHeader1>.Value)
            m_ColumnNames.Add(xInfo.<Info>.<columnHeader2>.Value)
            m_ColumnNames.Add(xInfo.<Info>.<columnHeader3>.Value)
            m_ColumnNames.Add(xInfo.<Info>.<columnHeader4>.Value)
            m_ColumnNames.Add(xInfo.<Info>.<columnHeader5>.Value)
            'Me.QRZLoginTextBox.Text = xInfo.<Info>.<QRZuser>.Value
            'Me.QRZPwdTextBox.Text = xInfo.<Info>.<QRZpwd>.Value

            Dim c = 0
            For Each Item As Integer In ColumnWidth
                If Item = 0 Then ColumnWidth(c) = 60
                c += 1
            Next

            Select Case History
                Case 3600
                    OneHrToolStripMenuItem.Checked = True
                Case 7200
                    TwoHrToolStripMenuItem.Checked = True
                Case 21600
                    SixHrToolStripMenuItem.Checked = True
                Case Else
                    AllToolStripMenuItem.Checked = True
            End Select
            Me.WebPagesToolStripComboBox.SelectedIndex = xInfo.<Info>.<webpageindex>.Value
            'Me.N5TMChatToolStripMenuItem1.Checked = xInfo.<Info>.<ViewChat>.Value
            'If Me.N5TMChatToolStripMenuItem1.Checked Then
            'SplitContainer3.Panel1Collapsed = False

            'Else
            SplitContainer3.Panel1Collapsed = True


            'End If
        Catch ex As Exception
            Try
                SavemyInfoXMLDocument()

            Catch ex1 As Exception

            End Try

        End Try


    End Sub

    Private Function GetHexColor(ByVal colorObj As System.Drawing.Color) As String
        Return "#" & Hex(colorObj.R) & Hex(colorObj.G) & Hex(colorObj.B)
    End Function

    Private Sub LoadColorsXMLDocument()

        Try

            xColors = XDocument.Load(DataPath + "\Colors.xml")

            Dim myColors = From c In xColors.<Pref>.<Callcolors>.<color>
                           Select c
            Debug.Print("")
            For Each Item As System.Xml.Linq.XElement In myColors
                call_colors.Add(Color.FromArgb(Convert.ToInt32(Item.Value)))
            Next
            myBackcolor = Color.FromArgb(Convert.ToInt32(xColors.<Pref>.<backcolor>.Value))
            myTextcolor = Color.FromArgb(Convert.ToInt32(xColors.<Pref>.<textcolor>.Value))
        Catch ex As Exception
            Dim cc = set_callColors()
            SaveColorsXMLDocument(cc)

        End Try
    End Sub

    Private Sub SaveColorsXMLDocument(ByVal myColors As ArrayList)
        Try
            xColors = <?xml version="1.0"?>
                      <Pref>
                          <Callcolors>
                              <%= From elem As Color In myColors
                                  Select <color><%= elem.ToArgb %></color> %>
                          </Callcolors>
                          <backcolor><%= myBackcolor.ToArgb %></backcolor>
                          <textcolor><%= myTextcolor.ToArgb %></textcolor>
                      </Pref>



            My.Computer.FileSystem.WriteAllText(DataPath + "\Colors.xml", xColors.ToString(), False)
        Catch ex As Exception
            MsgBox("Could not save Colors.xml")
        End Try

    End Sub

    'Private Sub LoadStationXMLDocument()
    '    Try
    '        xStation = XDocument.Load(DataPath + "\Station.xml")
    '    Catch ex As Exception
    '        SavemyInfoXMLDocument()
    '    End Try
    'End Sub

    Private Sub SavemyInfoXMLDocument()
        If Not IsNothing(xInfo) Then

        End If
        'Dim fontSize_str = fontSize.ToString.Split(".")

        Try
            xInfo = <?xml version="1.0"?>
                    <Info>
                        <nickname><%= myInfo.nickname %></nickname>
                        <nickname2><%= myInfo.nickname2 %></nickname2>
                        <callsign><%= myInfo.callsign %></callsign>
                        <firstname><%= myInfo.firstname %></firstname>
                        <locator><%= myInfo.locator %></locator>
                        <state><%= myInfo.state %></state>
                        <country><%= myInfo.country %></country>
                        <email><%= myInfo.email %></email>
                        <useWSJTLog><%= useWSJTLog %></useWSJTLog>
                        <WSJTLog><%= WSJTLogPath %></WSJTLog>
                        <fontSize><%= fontSize %></fontSize>
                        <history><%= History %></history>
                        <column0><%= Me.ColumnWidth(0) %></column0>
                        <column1><%= Me.ColumnWidth(1) %></column1>
                        <column2><%= Me.ColumnWidth(2) %></column2>
                        <column3><%= Me.ColumnWidth(3) %></column3>
                        <column4><%= Me.ColumnWidth(4) %></column4>
                        <column5><%= Me.ColumnWidth(5) %></column5>
                        <metric><%= metricDistance %></metric>
                        <webpageindex><%= 0 %></webpageindex>
                        <QRZuser><%= myInfo.QRZUser %></QRZuser>
                        <QRZpwd><%= myInfo.QRZpwd %></QRZpwd>
                        <dxcluster><%= TelnetURL %></dxcluster>
                        <fontbold><%= fontbold %></fontbold>
                        <Call3WSJT><%= Me.Call3WSJTPath %></Call3WSJT>
                        <Call3MAP65><%= Me.Call3MAP65Path %></Call3MAP65>
                        <WebPageFontSize><%= 10 %></WebPageFontSize>
                        <ViewChat><%= False %></ViewChat>
                        <Call3WSJTX><%= Me.Call3WSJTXPath %></Call3WSJTX>
                        <columnHeader0><%= "Callsign" %></columnHeader0>
                        <columnHeader1><%= "Name" %></columnHeader1>
                        <columnHeader2><%= "Grid" %></columnHeader2>
                        <columnHeader3><%= "Distance" %></columnHeader3>
                        <columnHeader4><%= "Azmuth" %></columnHeader4>
                        <columnHeader5><%= "State" %></columnHeader5>
                        <useSQLiteDB><%= useSQLiteDB %></useSQLiteDB>
                        <awaymsg><%= myInfo.awaymsg %></awaymsg>
                        <away><%= myInfo.Away %></away>
                    </Info>

            My.Computer.FileSystem.WriteAllText(DataPath + "\Info.xml", xInfo.ToString(), False)
        Catch ex1 As Exception

        End Try
    End Sub

    Private Sub SetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupToolStripMenuItem.Click
        optFrm = New InfoDialog
        AddHandler optFrm.Newinfo, AddressOf NewInfofromDialog

        optFrm.Show()

    End Sub

    Private Sub changefont(ByVal fontsize As Integer)
        Dim newfont = New Font(PJTextbox.Font.FontFamily, fontSize, PJTextbox.Font.Style)
        PJTextbox.Font = newfont
        Me.StationsListView.Font = newfont
        Me.SelectedStationsTextBox.Font = newfont
        CQTextBox.Font = newfont
        Me.MsgTextBox.Font = newfont
        SavemyInfoXMLDocument()
    End Sub

    Private Sub IncreaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncreaseToolStripMenuItem.Click
        fontSize += 1
        changefont(fontSize)
        refresh_all()
    End Sub

    Private Sub DecreaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecreaseToolStripMenuItem.Click
        fontSize -= 1
        changefont(fontSize)
        refresh_all()
    End Sub

    Private Function ThisPJCInfo(ByVal lvi As ListViewItem) As PJ
        Dim pj As New PJ
        'Dim c = 0
        'For Each Item As String In m_ColumnNames
        '    If Item = "Callsign" Then
        '        Exit For
        '    Else
        '        c += 1
        '    End If

        'Next
        For Each item As PJ In nick_unique
            If item.callsign = lvi.SubItems(callsignIndex).Text Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    Private Sub sendEmail(ByVal EmailAddress As String)
        Try
            Dim proc = New System.Diagnostics.Process
            proc.StartInfo.FileName = "mailto:" & EmailAddress & "?subject=&body="
            proc.Start()
        Catch ex As Exception
            MsgBox("Could not start email client, " & ex.ToString)
        End Try

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            sendEmail(c.email)
        End If
    End Sub

    Private Sub CallsignToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallsignToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            Clipboard.SetText(c.callsign.Split("/")(0))
        End If

    End Sub

    Private Sub GridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            Clipboard.SetText(c.locator)
        End If
    End Sub

    Private Sub MsgToCallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgToCallToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", "
        End If
    End Sub

    Private Sub RunningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunningToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", running.. GL"
            QsoStartTime = Now
            Me.OneSecondTimer.Enabled = True
        End If
    End Sub

    Private Sub RRRRcvdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RRRRcvdToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            If Me.WebPagesToolStripComboBox.SelectedIndex = 0 Then
                Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd RRR, Tnx " + c.distance.ToString + "mi QSO, Total Time- " + QsoElapTime(QsoStartTime, Now) + " ."
            Else
                Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd RRR, Tnx QSO, best -"
            End If

            Me.OneSecondTimer.Enabled = False

            For Each Item As PJ In nick_unique
                If c.callsign = Item.callsign Then
                    current_PJ = Item
                    If logQSOs Then logQSO = True
                    Exit For
                End If
                logQSO = False
            Next

        End If


    End Sub
    Private Sub New_Colors(ByVal new_colors As ArrayList, ByVal new_textcolor As Color, ByVal new_backcolor As Color)
        call_colors = new_colors
        Me.PJTextbox.BackColor = new_backcolor
        Me.StationsListView.BackColor = new_backcolor
        CQTextBox.BackColor = new_backcolor
        Me.myBackcolor = new_backcolor
        myTextcolor = new_textcolor

        Dim i = 0
        For Each c As PJ In nick_unique
            If i = call_colors.Count Then i = 1
            c.nick_color = call_colors.Item(i)
            i += 1
        Next

        SaveColorsXMLDocument(new_colors)
        SavemyInfoXMLDocument()


        Me.PJTextbox.Text = ""
        RefreshPage = True
        reFillListview()

    End Sub

    'Private Sub BackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.ColorDialog1.ShowDialog()
    '    Me.PJTextbox.BackColor = Me.ColorDialog1.Color
    '    Me.ListView1.BackColor = Me.ColorDialog1.Color
    '    CQTextBox.BackColor = Me.ColorDialog1.Color
    '    Me.myBackcolor = Me.ColorDialog1.Color
    '    SavemyInfoXMLDocument()
    'End Sub

    Private Sub ContinueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinueToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", continue?"
        End If
    End Sub

    Private Function QsoElapTime(ByVal starttime As DateTime, ByVal endtime As DateTime) As String
        Try
            Return FormatTime(DateDiff("s", starttime, endtime))

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Sub TnxQSOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TnxQSOToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            If Me.WebPagesToolStripComboBox.SelectedIndex = 0 Then
                Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd RRR, Tnx " + c.distance.ToString + "mi QSO, Total Time- " + QsoElapTime(QsoStartTime, Now) + " ."
            Else
                Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd RRR, Tnx QSO, best -"
            End If

            Me.OneSecondTimer.Enabled = False

            For Each Item As PJ In nick_unique
                If c.callsign = Item.callsign Then
                    current_PJ = Item
                    If logQSOs Then logQSO = True
                    Exit For
                End If
                logQSO = False
            Next

        End If
    End Sub

    'Private Sub LogThisQSO(ByVal npj As PJ)
    '    logQSO = False
    '    Me.StationTableAdapter.FillByCallsign(Me.PJCLogBook2DataSet.Station, npj.callsign.Split("/")(0))
    '    Dim thisrow As PJCLogBook2DataSet.StationRow
    '    If PJCLogBook2DataSet.Station.Rows.Count > 0 Then
    '        thisrow = Me.PJCLogBook2DataSet.Station.Rows(0)
    '        addQSOtoLogbook(npj, thisrow)
    '    End If
    'End Sub

    'Private Sub addQSOtoLogbook(ByVal m_pjc As PJ, ByVal station As PJCLogBook2DataSet.StationRow)
    '    If IsNothing(frmQSO) Then
    '        frmQSO = New QSOLog
    '        'AddHandler frmQSO.QsoUpdate, AddressOf QsoUpdated
    '        frmQSO.callsign = m_pjc.callsign.Split("/")(0)
    '        frmQSO.pjc = m_pjc
    '        frmQSO.myInfo = myInfo
    '        frmQSO.ID = -1
    '        frmQSO.StationID = station.id
    '        frmQSO.Show()
    '    Else
    '        If frmQSO.IsDisposed Then
    '            frmQSO = New QSOLog
    '            'AddHandler frmQSO.QsoUpdate, AddressOf QsoUpdated
    '            frmQSO.callsign = m_pjc.callsign.Split("/")(0)
    '            frmQSO.pjc = m_pjc
    '            frmQSO.myInfo = myInfo
    '            frmQSO.ID = -1
    '            frmQSO.StationID = station.id
    '            frmQSO.Show()
    '        Else
    '            frmQSO.Close()
    '            frmQSO.Dispose()
    '        End If
    '    End If
    'End Sub

    Private Sub TnxTryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TnxTryToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " Tnx try..., " + c.firstname
            Me.OneSecondTimer.Enabled = False
        End If
    End Sub

    Private Sub QSOTimerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QSOTimerButton.Click
        QsoStartTime = Now
        Me.OneSecondTimer.Enabled = True

    End Sub

    Private Sub QsoTimerStopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QsoTimerStopButton.Click
        Me.OneSecondTimer.Enabled = False
    End Sub

    Private Sub OneSecondTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneSecondTimer.Tick

        Me.lblTimer.Text = FormatTime(DateDiff("s", QsoStartTime, Now))

    End Sub

    Private Function FormatTime(ByVal seconds As Integer)

        Dim Hours = Fix(seconds / 3600)
        seconds = seconds Mod 3600
        Dim Minutes = Fix(seconds / 60)
        seconds = seconds Mod 60

        Dim HoursText = Hours.ToString.PadLeft(2, "0"c)
        Dim MinutesText = Minutes.ToString.PadLeft(2, "0"c)
        Dim SecondsText = seconds.ToString.PadLeft(2, "0"c)

        Return Hours.ToString.PadLeft(2, "0"c) & ":" & Minutes.ToString.PadLeft(2, "0"c) & ":" & seconds.ToString.PadLeft(2, "0"c)
    End Function

    Private Sub HighliteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighliteToolStripMenuItem.Click
        If StationsListView.SelectedIndices.Count = 0 Then
            Return
        Else
            Dim lvi As ListViewItem = StationsListView.SelectedItems(0)
            Dim c = ThisPJCInfo(lvi)
            If c.highlite = True Then
                c.highlite = False
                HighliteToolStripMenuItem.Checked = False
            Else
                c.highlite = True
                HighliteToolStripMenuItem.Checked = True
            End If
        End If
    End Sub

    Private Sub resetHistoryCheck()
        AllToolStripMenuItem.Checked = False
        OneHrToolStripMenuItem.Checked = False
        TwoHrToolStripMenuItem.Checked = False
        SixHrToolStripMenuItem.Checked = False
    End Sub

    Private Sub OneHrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneHrToolStripMenuItem.Click
        History = 3600
        nick_unique.Clear()
        resetHistoryCheck()
        OneHrToolStripMenuItem.Checked = True
        reFillListview()
        SavemyInfoXMLDocument()
    End Sub

    Private Sub TwoHrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwoHrToolStripMenuItem.Click
        History = 7200
        nick_unique.Clear()
        resetHistoryCheck()
        TwoHrToolStripMenuItem.Checked = True
        reFillListview()
        SavemyInfoXMLDocument()
    End Sub

    Private Sub SixHrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SixHrToolStripMenuItem.Click
        History = 3600 * 6
        nick_unique.Clear()
        resetHistoryCheck()
        SixHrToolStripMenuItem.Checked = True
        reFillListview()
        SavemyInfoXMLDocument()
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        History = 0
        nick_unique.Clear()
        resetHistoryCheck()
        AllToolStripMenuItem.Checked = True
        reFillListview()
        SavemyInfoXMLDocument()
    End Sub

    Private Sub reFillListview()
        'SavemyInfoXMLDocument()

        InitListview(Me.StationsListView)
        npj_count = 0
        FillListview()
    End Sub

    Private Sub ResetTimerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetTimerButton.Click
        Me.OneSecondTimer.Enabled = False
        QsoStartTime = Now
        lblTimer.Text = "00:00:00"
    End Sub

    Private Sub LogBookToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'logBookFrm = New Logbook
        'logBookFrm.myInfo = myInfo
        'logBookFrm.Show()
    End Sub

    'Private Sub StationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.StationBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)

    'End Sub

    Private Sub FreezeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.tag = "freeze" Then
            sender.tag = ""
        Else
            sender.tag = "freeze"
        End If

    End Sub

    Private Sub CallColorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallColorsToolStripMenuItem.Click
        colorFrm = New ColorsDlg
        colorFrm.background_color = myBackcolor
        colorFrm.text_color = myTextcolor

        colorFrm.callsign_colors = Me.call_colors
        AddHandler colorFrm.NewColors, AddressOf New_Colors
        colorFrm.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        'Me.PJTextbox.Text = ""
        'RefreshPage = True
        'Me.CQTextBox.Text = ""
        'Me.FreqTreeView.Nodes.Clear()
        'nick_unique.Clear()
        'reFillListview()
        refresh_all()
    End Sub

    Private Sub refresh_all()
        Me.PJTextbox.Text = ""
        RefreshPage = True
        Me.CQTextBox.Text = ""
        Me.FreqTreeView.Nodes.Clear()
        nick_unique.Clear()
        reFillListview()
    End Sub

    Private Sub QSYButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNumeric(Me.FreqTextBox.Text) Then
            PostReponse(postMsg("~ QSY ~ " + FreqTextBox.Text + " ~"))
            RetrievePJPage.refreshtime = 5000
        Else
            MsgBox("Please Enter Frequency (MHz)")
        End If
    End Sub

    Private Sub QRVButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRVButton.Click

        If IsNumeric(Me.FreqTextBox.Text) Then
            Dim az = ""
            If IsNumeric(QTFTextBox.Text) Then
                az = QTFTextBox.Text + " deg"
            End If
            PostReponse(postMsg("~ QRV ~ " + FreqTextBox.Text + " ~" + az + " " + ModeTextBox.Text))
            RetrievePJPage.refreshtime = 5000
        Else
            MsgBox("Please Enter Frequency (MHz)")
        End If
    End Sub

    Private Sub CQ1stButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CQ1stButton.Click
        Dim split = " "
        Dim az = " "
        CQPosted = True
        If IsNumeric(RcvFreqTextBox.Text) Then
            split = " RX: " + RcvFreqTextBox.Text + " "
        End If
        If IsNumeric(QTFTextBox.Text) Then
            az = QTFTextBox.Text + " deg"
        End If
        If IsNumeric(Me.FreqTextBox.Text) Then
            'If Me.WebPagesToolStripComboBox.SelectedIndex = 0 Then
            PostReponse(postMsg("~ CQ 1st ~ " + FreqTextBox.Text + " ~" + split + az + " " + ModeTextBox.Text))
            'Else
            'PostReponse(postMsg("~ CQ 1st ~ " + FreqTextBox.Text + " ~"))
            'End If
            RetrievePJPage.refreshtime = 5000
        Else
            MsgBox("Please Enter Frequency (MHz)")
        End If
    End Sub

    Private Sub CQ2ndButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CQ2ndButton.Click
        Dim split = " "
        Dim az = " "
        CQPosted = True
        If IsNumeric(RcvFreqTextBox.Text) Then
            split = " RX: " + RcvFreqTextBox.Text + " "
        End If
        If IsNumeric(QTFTextBox.Text) Then
            az = QTFTextBox.Text + " deg"
        End If
        If IsNumeric(Me.FreqTextBox.Text) Then
            'If Me.WebPagesToolStripComboBox.SelectedIndex = 0 Then
            PostReponse(postMsg("~ CQ 2nd ~ " + FreqTextBox.Text + " ~" + split + az + " " + ModeTextBox.Text))
            'Else
            'PostReponse(postMsg("~ CQ 2nd ~ " + FreqTextBox.Text + " ~"))
            'End If
            RetrievePJPage.refreshtime = 5000
        Else
            MsgBox("Please Enter Frequency (MHz)")
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Dim stopmsg As String = ""
        If CQPosted Then
            CQPosted = False
            stopmsg = " CQ stopped"
        End If
        If RunningPosted Then
            RunningPosted = False
            stopmsg = " tnx..."
        End If
        If IsNumeric(Me.FreqTextBox.Text) Then
            PostReponse(postMsg("~ Clear ~ " + FreqTextBox.Text + " ~" + stopmsg))
            RetrievePJPage.refreshtime = 5000
        Else
            MsgBox("Please Enter Frequency (MHz)")
        End If
    End Sub

    Private Sub RunningButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunningButton.Click
        If CallBtn.Text = "Callsign" Then
            MsgBox("Please select station (Click on callsign in window.)")
        Else
            RunningPosted = True
            If IsNumeric(Me.FreqTextBox.Text) Then
                Dim az = ""
                If IsNumeric(QTFTextBox.Text) Then
                    az = QTFTextBox.Text + " deg"
                End If
                PostReponse(postMsg("~ Running ~ " + FreqTextBox.Text + " ~" + az + " " + ModeTextBox.Text + " 1st w/" + CallBtn.Text))
                RetrievePJPage.refreshtime = 5000
                QsoStartTime = Now
                Me.OneSecondTimer.Enabled = True
            Else
                MsgBox("Please Enter Frequency (MHz)")
            End If
        End If
    End Sub


    Private Sub Running2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Running2Button.Click
        If CallBtn.Text = "Callsign" Then
            MsgBox("Please select station (Click on callsign in window.)")
        Else
            RunningPosted = True
            If IsNumeric(Me.FreqTextBox.Text) Then
                Dim az = ""
                If IsNumeric(QTFTextBox.Text) Then
                    az = QTFTextBox.Text + " deg"
                End If
                PostReponse(postMsg("~ Running ~ " + FreqTextBox.Text + " ~" + az + " " + ModeTextBox.Text + " 2nd w/" + CallBtn.Text))
                RetrievePJPage.refreshtime = 5000
                QsoStartTime = Now
                Me.OneSecondTimer.Enabled = True
            Else
                MsgBox("Please Enter Frequency (MHz)")
            End If
        End If
    End Sub

    Private Sub N5TMChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim webAddress As String = "http://chat.n5tm.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub LiveCQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiveCQToolStripMenuItem.Click
        Dim webAddress As String = "http://www.livecq.eu/"
        Process.Start(webAddress)
    End Sub

    Private Sub EMELoggerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMELoggerToolStripMenuItem.Click
        Dim webAddress As String = "http://livecq.eu/logger/default.asp"
        Process.Start(webAddress)
    End Sub

    Private Sub MMMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMMToolStripMenuItem.Click
        Dim webAddress As String = "http://www.mmmonvhf.de/eme.php"
        Process.Start(webAddress)
    End Sub

    Private Sub DXMapsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DXMapsToolStripMenuItem.Click
        Dim webAddress As String = "http://www.dxmaps.com/spots/map.php?Lan=E&Frec=50&ML=M&Map=NA&DXC=N&HF=N&GL=N"
        Process.Start(webAddress)
    End Sub

    Private Sub ON4KSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ON4KSTToolStripMenuItem.Click
        Dim webAddress As String = "http://www.on4kst.com/index.php"
        Process.Start(webAddress)
    End Sub

    Private Sub VHFPropagationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VHFPropagationToolStripMenuItem.Click
        Dim webAddress As String = "http://aprs.mountainlake.k12.mn.us/"
        Process.Start(webAddress)
    End Sub

    Private Sub WebPagesToolStripComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebPagesToolStripComboBox.SelectedIndexChanged
        PageURLIndex = sender.SelectedIndex
        If sender.SelectedIndex > 0 Then
            SplitChar = "{"
        Else
            SplitChar = "("
        End If
        RetrievePJPage.url = PageURL(PageURLIndex)
        ' refresh page
        Me.PJTextbox.Text = ""
        RefreshPage = True
        Me.CQTextBox.Text = ""
        Me.FreqTreeView.Nodes.Clear()
        'SavemyInfoXMLDocument()
        reFillListview()

    End Sub

    'Private Sub N5TMChatToolStripMenuItem1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles N5TMChatToolStripMenuItem1.CheckStateChanged
    '    If xInfo.<Info>.<ViewChat>.Value <> "" Then
    '        If sender.checked Then
    '            SplitContainer3.Panel1Collapsed = False

    '        Else
    '            SplitContainer3.Panel1Collapsed = True

    '        End If
    '        SavemyInfoXMLDocument()
    '    End If

    'End Sub

    Private Sub N5TMChatToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles N5TMChatToolStripMenuItem1.Click
        Dim webAddress As String = "http://chat.n5tm.com/"
        Process.Start(webAddress)
        'If sender.checked Then
        '    sender.checked = False
        'Else
        '    sender.checked = True
        'End If


    End Sub


    Private Sub TelnetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelnetToolStripMenuItem.Click
        Dim DXTelnet As New Telnet

        DXTelnet.callsign = myInfo.callsign
        DXTelnet.Show()
    End Sub

    'Private Sub DXClusterLogin()

    '    If TelnetURL <> "" Then
    '        Dim thisCluster = TelnetURL.Split(":")
    '        DXCluster.url = thisCluster(0)
    '        If thisCluster.Count > 1 Then
    '            If thisCluster(1) = "" Then
    '                DXCluster.Port = "7300"
    '            Else
    '                DXCluster.Port = thisCluster(1)
    '            End If
    '        Else
    '            DXCluster.Port = "7300"
    '        End If

    '        DXCluster.callsign = myInfo.callsign

    '        DXCluster.Login()
    '        ThreadDXCluster.Start()
    '        DXCluster.SendCommand("accept/spots on vhf")
    '    End If


    'End Sub

    'Private Sub NewTelenetData(ByVal ret As String)
    '    SetTelnetText(ret)
    'End Sub

    'Private Delegate Sub SetTelnetTextCallback(ByVal [text] As String)
    'Private Sub SetTelnetText(ByVal text As String)
    '    Static moonLinectr As Integer
    '    ' InvokeRequired required compares the thread ID of the' 
    '    ' calling thread to the thread ID of the creating thread.' 
    '    ' If these threads are different, it returns true.' 
    '    If Me.TelnetTextBox.InvokeRequired Then
    '        Dim d As New SetTelnetTextCallback(AddressOf SetTelnetText)
    '        Me.Invoke(d, New Object() {text})
    '    Else
    '        If getMoonFlag Then

    '            moonLinectr += 1
    '            Me.MoonTextBox.Text = text
    '            Me.MoonTextBox.Select(TelnetTextBox.TextLength, 0)
    '            Me.MoonTextBox.ScrollToCaret()

    '            If text.Contains("Illuminated") Or moonLinectr > 5 Then
    '                moonLinectr = 0
    '                getMoonFlag = False
    '            End If
    '        Else

    '            Me.TelnetTextBox.AppendText(text)
    '            Me.TelnetTextBox.Select(TelnetTextBox.TextLength, 0)
    '            Me.TelnetTextBox.ScrollToCaret()

    '        End If

    '    End If


    'End Sub

    Private Sub BoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldToolStripMenuItem.Click
        If sender.checked Then
            sender.checked = False

        Else
            sender.checked = True
        End If
        fontbold = sender.checked
        If fontbold Then
            Me.PJTextbox.Font = fbold
            Me.StationsListView.Font = fbold
            Me.FreqTreeView.Font = fbold
            Me.CQTextBox.Font = fbold
            Me.SelectedStationsTextBox.Font = fbold
        Else
            Me.PJTextbox.Font = fnormal
            Me.StationsListView.Font = fnormal
            Me.FreqTreeView.Font = fnormal
            Me.CQTextBox.Font = fnormal
            Me.SelectedStationsTextBox.Font = fnormal
        End If
        SavemyInfoXMLDocument()
        refresh_all()
    End Sub

    Private Sub WriteCall3File(ByVal fspec As String, ByVal call3txt As ArrayList, ByVal call3hdr As ArrayList)
        Try
            Using wFile As StreamWriter = New System.IO.StreamWriter(fspec)

                ' first write header info
                For Each hdr In call3hdr
                    wFile.WriteLine(hdr)
                Next
                ' now wright all elements

                For Each c As String() In call3txt
                    If c.Length > 1 Then wFile.WriteLine(String.Join(",", c))

                Next

                ' write trailer 
                wFile.WriteLine("ZZZZZZ,End-Of-Callsign-Database")

                wFile.Close()

            End Using
        Catch ex As Exception
            MsgBox("Unable to write WSJT Call3.txt file. Check path in Settings")
            Exit Sub
        End Try
    End Sub


    Private Sub UpdateCall3txtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCall3txtToolStripMenuItem.Click
        Dim call3txt As New ArrayList
        Dim call3hdr As New ArrayList
        Dim call3trlr As New ArrayList

        Try
            If Dir(Call3WSJTPath) <> "" Then
                Dim sfilereader = System.IO.File.OpenText(Call3WSJTPath)
                Dim sinputline = sfilereader.ReadLine()

                Do Until sinputline Is Nothing

                    Dim log = sinputline.Split(",")
                    If sinputline.Contains("//") Then
                        call3hdr.Add(sinputline)
                    Else
                        If Not sinputline.Contains("ZZZZZZ") Then call3txt.Add(log)

                    End If


                    'Select Case log.Length
                    '    Case 1
                    '        ' header info
                    '        call3hdr.Add(log)

                    '    Case 2
                    '        'trailer info
                    '        call3trlr.Add(log)

                    '    Case Else
                    '        call3txt.Add(log)

                    'End Select

                    sinputline = sfilereader.ReadLine()
                Loop
                sfilereader.Close()
            End If

        Catch ex As Exception
            MsgBox("Unable to open Call3.txt")
            Exit Sub
        End Try
        If Call3WSJTPath <> "" Then
            Dim njp As PJ
            For Each njp In nick_unique
                If Not njp.call3 Then
                    Dim s(7) As String
                    s(0) = njp.callsign.Split("/")(0)
                    s(1) = njp.locator
                    s(2) = "EME"
                    s(3) = ""
                    s(4) = ""
                    s(5) = ""
                    s(6) = ""
                    s(7) = ""
                    call3txt.Add(s)
                    njp.call3 = True
                End If

            Next
            Dim myCompare As New myArrayCompareClass
            call3txt.Sort(myCompare)

        Else
            MsgBox("No Call3.txt path found")
            Exit Sub
        End If

        ' Write Call3 to WSJT Path
        If Call3WSJTPath <> "" Then WriteCall3File(Call3WSJTPath, call3txt, call3hdr)
        ' Write Call3 to WSJTX Path
        If Call3WSJTXPath <> "" Then WriteCall3File(Call3WSJTXPath, call3txt, call3hdr)
        ' Write Call3 to MAP65 Path
        If Call3MAP65Path <> "" Then WriteCall3File(Call3MAP65Path, call3txt, call3hdr)
        'Try
        '    Dim wFile As New System.IO.StreamWriter(Call3WSJTPath, True)

        '    ' first write header info
        '    For Each hdr In call3hdr
        '        wFile.WriteLine(hdr)
        '    Next
        '    ' now wright all elements

        '    For Each c As String() In call3txt
        '        wFile.WriteLine(String.Join(",", c))

        '    Next

        '    ' write trailer 
        '    wFile.WriteLine("ZZZZZZ,End-Of-Callsign-Database")

        '    wFile.Close()
        '    wFile = Nothing
        'Catch ex As Exception
        '    MsgBox("Unable to write WSJT Call3.txt file. Check path in Settings")
        '    Exit Sub
        'End Try

        'Try
        '    If Call3WSJTXPath <> "" Then
        '        Dim mFile As New System.IO.StreamWriter(Call3WSJTXPath)

        '        ' first write header info
        '        For Each hdr In call3hdr
        '            mFile.WriteLine(hdr)
        '        Next
        '        ' now wright all elements

        '        For Each c As Array In call3txt
        '            mFile.WriteLine(String.Join(",", c))

        '        Next

        '        ' write trailer 
        '        mFile.WriteLine("ZZZZZZ,End-Of-Callsign-Database")

        '        mFile.Close()

        '        mFile = Nothing
        '    End If
        'Catch ex As Exception
        '    MsgBox("Unable to write WSJTX Call3.txt file.  Check path in Settings")
        '    Exit Sub
        'End Try

        'Try
        '    If Call3MAP65Path <> "" Then
        '        Dim mFile As New System.IO.StreamWriter(Call3MAP65Path)

        '        ' first write header info
        '        For Each hdr In call3hdr
        '            mFile.WriteLine(hdr)
        '        Next
        '        ' now wright all elements

        '        For Each c As Array In call3txt
        '            mFile.WriteLine(String.Join(",", c))

        '        Next

        '        ' write trailer 
        '        mFile.WriteLine("ZZZZZZ,End-Of-Callsign-Database")

        '        mFile.Close()

        '        mFile = Nothing
        '    End If
        'Catch ex As Exception
        '    MsgBox("Unable to write MAP65 Call3.txt file.  Check path in Settings")
        '    Exit Sub
        'End Try

        MsgBox("Call3.txt files updated.")
        SetStatusLabelText("", ToolStripStatusLabel2)
        'call3Array.Clear()
        'readCall3File(Call3WSJTPath)
        reFillListview()
    End Sub

    Public Class myArrayCompareClass
        Implements IComparer

        ' array compare 
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements IComparer.Compare
            Return New CaseInsensitiveComparer().Compare(x(0), y(0))
        End Function

    End Class

    Private Sub SelectedStationComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedStationComboBox.SelectedIndexChanged

        Dim c = SelectedStation
        If Not IsNothing(c) Then
            Select Case sender.selectedindex
                Case 0   ' info
                    Dim thisstation = New StationDialog
                    thisstation.DataPath = DataPath
                    thisstation.logarray = logArray
                    thisstation.pjc = SelectedStation
                    thisstation.QRZLogin = myInfo.QRZUser
                    thisstation.QRZPwd = myInfo.QRZpwd
                    thisstation.ShowDialog()
                    thisstation.OK_Button.Focus()
                Case 1  ' running
                    Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", running.. GL"
                    QsoStartTime = Now
                    Me.OneSecondTimer.Enabled = True
                Case 2  ' continue?
                    Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", continue?"
                Case 3  ' pse continue
                    Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", pse continue..."

                Case 4  ' RRR rcvd
                    If Me.WebPagesToolStripComboBox.SelectedIndex = 0 Then
                        Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd RRR, Tnx " + c.distance.ToString + "mi QSO, Total Time- " + QsoElapTime(QsoStartTime, Now) + " ."
                    Else
                        Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd RRR, Tnx QSO, best -"
                    End If

                    Me.OneSecondTimer.Enabled = False

                Case 5  ' 73 rcvd
                    If Me.WebPagesToolStripComboBox.SelectedIndex = 0 Then
                        Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd 73, Tnx " + c.distance.ToString + "mi QSO, Total Time- " + QsoElapTime(QsoStartTime, Now) + " ."
                    Else
                        Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ",rcvd 73, Tnx QSO, best -"
                    End If

                    Me.OneSecondTimer.Enabled = False
                Case 6  ' tnx QSO
                    If Me.WebPagesToolStripComboBox.SelectedIndex = 0 Then
                        Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", Tnx " + c.distance.ToString + "mi QSO, Total Time- " + QsoElapTime(QsoStartTime, Now) + " ."
                    Else
                        Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", Tnx QSO, best -"
                    End If
                    Me.OneSecondTimer.Enabled = False
                Case 7 ' tnx try
                    Me.MsgTextBox.Text = c.callsign.Split("/")(0) + " " + c.firstname + ", Tnx try... "

                    Me.OneSecondTimer.Enabled = False
                    'Case 7 ' log qso
                    '    For Each Item As PJ In nick_unique
                    '        If c.callsign = Item.callsign Then
                    '            current_PJ = Item
                    '            If logQSOs Then logQSO = True
                    '            Exit For
                    '        End If
                    '        logQSO = False
                    '    Next
                Case 7 'send email
                    sendEmail(c.email)

            End Select
        Else
            MsgBox("No callsign selected.")
        End If

    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Dim myver = My.Application.Info.Version.Minor
        Dim thisVer = CInt(My.Application.Info.Version.ToString.Replace(".", ""))
        Dim chkUpdate As New WebUpdate(thisVer, False)

    End Sub

    Private Sub CheckForUpdate()
        Dim myver = My.Application.Info.Version.Minor
        Dim thisVer = CInt(My.Application.Info.Version.ToString.Replace(".", ""))
        Dim chkUpdate As New WebUpdate(thisVer, True)
    End Sub

    Private Sub OnlineHelpDocumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineHelpDocumentToolStripMenuItem.Click
        Dim webAddress As String = "http://www.n5tm.com/pjclient-quick-start-guide/"
        Process.Start(webAddress)
    End Sub

    Private Sub StationInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StationInfoToolStripMenuItem.Click
        Dim thisstation = New StationDialog
        thisstation.logarray = logArray
        thisstation.pjc = SelectedStation
        thisstation.QRZLogin = myInfo.QRZUser
        thisstation.QRZPwd = myInfo.QRZpwd
        thisstation.ShowDialog()
        thisstation.OK_Button.Focus()
    End Sub

    Private Sub MsgTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgTextBox.TextChanged
        Dim newtext = sender.text.Replace(vbCr, "").Replace(vbLf, "")
        MsgTextBox.Text = newtext
    End Sub

    Private Sub PJTextbox_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles PJTextbox.LinkClicked
        Process.Start(e.LinkText)
    End Sub


    Private Sub MoonTrackerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoonTrackerToolStripMenuItem.Click
        Dim webAddress As String = "http://sm5cui.weebly.com/downloads.html"
        Process.Start(webAddress)
    End Sub

    Private Sub CallBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallBtn.Click
        Clipboard.SetText(CallBtn.Text.Split("/")(0))
    End Sub

    Private Sub NameBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameBtn.Click
        Me.MsgTextBox.Text = CallBtn.Text.Split("/")(0) + " " + NameBtn.Text + ", "
    End Sub

    Private Sub GridBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridBtn.Click
        Clipboard.SetText(GridBtn.Text)
    End Sub

    Private Sub CallBtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CallBtn.MouseHover, GridBtn.MouseHover _
        , NameBtn.MouseHover, CQ1stButton.MouseHover, CQ2ndButton.MouseHover, QRVButton.MouseHover, ClearButton.MouseHover _
        , ResetTimerButton.MouseHover, QSOTimerButton.MouseHover, QsoTimerStopButton.MouseHover, Running2Button.MouseHover _
        , RunningButton.MouseHover, SendButton.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub CallBtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CallBtn.MouseLeave, GridBtn.MouseLeave _
        , NameBtn.MouseLeave, CQ1stButton.MouseLeave, CQ2ndButton.MouseLeave, QRVButton.MouseLeave, ClearButton.MouseLeave _
        , ResetTimerButton.MouseLeave, QSOTimerButton.MouseLeave, QsoTimerStopButton.MouseLeave, Running2Button.MouseLeave _
        , RunningButton.MouseLeave, SendButton.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New AboutBox1()
        about.Show()
    End Sub

    Private Sub AwayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AwayToolStripMenuItem.Click
        myInfo.awaymsg = InputBox("Enter Away Message", "Away Message")
        myInfo.Away = True
        AwayToolStripMenuItem.Checked = True
        OnPageToolStripMenuItem.Checked = False
        SavemyInfoXMLDocument()

    End Sub

    Private Sub OnPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnPageToolStripMenuItem.Click
        AwayToolStripMenuItem.Checked = False
        OnPageToolStripMenuItem.Checked = True
        SavemyInfoXMLDocument()
    End Sub

    Private Sub GoToSettingsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToSettingsFolderToolStripMenuItem.Click
        Process.Start("explorer.exe", DataPath)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
