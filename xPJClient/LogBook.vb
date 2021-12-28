Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Xml.XPath
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Logbook
    Dim StationIDList As New ArrayList
    Dim QsoRow As PJCLogBook2DataSet.QsoRow
    Dim frmQSO As QSOLog
    Private SelectedRow As PJCLogBook2DataSet.StationRow


    Private m_myInfo As Info
    Public Property myInfo() As Info
        Get
            Return m_myInfo
        End Get
        Set(ByVal value As Info)
            m_myInfo = value
        End Set
    End Property

    Private m_pjc As PJ
    Public Property pjc() As PJ
        Get
            Return m_pjc
        End Get
        Set(ByVal value As PJ)
            m_pjc = value
            Me.StationTableAdapter.FillByCallsign(PJCLogBook2DataSet.Station, value.callsign.Split("/")(0).ToUpper)
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        QsoBindingSource.EndEdit()
        StationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub StationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)

    End Sub

    Private Sub Logbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        newDateBinding()
        Me.PJCLogBook2DataSet.EnforceConstraints = False
        'TODO: This line of code loads data into the 'PJCLogBook2DataSet.Station' table. You can move, or remove it, as needed.
        If IsNothing(pjc) Then Me.StationTableAdapter.Fill(Me.PJCLogBook2DataSet.Station)
        'TODO: This line of code loads data into the 'PJCLogBook2DataSet.Qso' table. You can move, or remove it, as needed.
        Me.QsoTableAdapter.Fill(Me.PJCLogBook2DataSet.Qso)
        BuildStationDropdownList("*")
        'Me.LastPostLabel.Text = Format(pjc.post, "yyyy-MM-dd HHmm UTC")
    End Sub

    Private Sub StationBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)

    End Sub

    Private Sub newDateBinding()
        Dim bndBinding As New Binding("Text", StationBindingSource, "post")
        AddHandler bndBinding.Format, AddressOf DBdateTextbox
        AddHandler bndBinding.Parse, AddressOf TextBoxDBdate

        Me.LastPostTextBox.DataBindings.Add(bndBinding)

    End Sub

    'Handler for binding format
    Private Sub DBdateTextbox(ByVal sender As Object, ByVal cevent As ConvertEventArgs)
        If cevent.Value Is DBNull.Value Then
            cevent.Value = ""
        Else
            'Dim datum As Date
            'cevent.Value = datum.ToString("yyyy-MM-dd")
            cevent.Value = Format(cevent.Value, "yyyy-MM-dd HH:mm:ss")
        End If
    End Sub

    Private Sub TextBoxDBdate(ByVal sender As Object, ByVal cevent As ConvertEventArgs)
        If cevent.Value.ToString = "" Then
            cevent.Value = DBNull.Value
        End If
    End Sub

    Private Sub BuildStationDropdownList(ByVal SearchText As String)

        Dim StationList = From station In Me.PJCLogBook2DataSet.Station _
                                               Where station.callsign Like SearchText + "*" _
                                               Order By station.callsign _
                                               Select station.callsign, station.id

        If StationList.Count > 0 Then

            CallSignToolStripComboBox.Items.Clear()
            StationIDList.Clear()
            CallSignToolStripComboBox.Items.Add("(All)")
            StationIDList.Add(-1)
            For Each Item As Object In StationList
                CallSignToolStripComboBox.Items.Add(Item.callsign)
                StationIDList.Add(Item.id)
            Next
            'CustomerToolStripComboBox.DroppedDown = True
        End If

        'End If
        'Windows.Forms.Cursor.Show()
    End Sub

    Private Sub addQSOToDatabase(ByVal n_pj As PJ, ByVal log() As String)
        Dim callsign = n_pj.callsign.Split("/")(0)
        Try
            Me.StationTableAdapter.FillByCallsign(Me.PJCLogBook2DataSet.Station, callsign.ToUpper)
            Dim thisrow As PJCLogBook2DataSet.StationRow
            If PJCLogBook2DataSet.Station.Rows.Count > 0 Then
                thisrow = Me.PJCLogBook2DataSet.Station.Rows(0)
                thisrow.post = n_pj.post
            Else
                newStationRow(n_pj)
                Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
                Me.StationTableAdapter.FillByCallsign(Me.PJCLogBook2DataSet.Station, callsign.ToUpper)
                thisrow = Me.PJCLogBook2DataSet.Station.Rows(0)
            End If
            Dim thisQso As PJCLogBook2DataSet.QsoRow
            Dim qsoDate = Convert.ToDateTime(log(0))
            Dim qsoUtc = Format(Convert.ToDateTime(log(1) + ":00"), "HHmm")
            Me.QsoTableAdapter.FillByDateTime(Me.PJCLogBook2DataSet.Qso, qsoDate, qsoutc)
            If PJCLogBook2DataSet.Qso.Rows.Count > 0 Then
                thisQso = Me.PJCLogBook2DataSet.Qso.Rows(0)
                thisQso.qsoUTC = Format(thisQso.qsodate, "HHmm")
                Me.QsoBindingSource.EndEdit()
            Else
                'if not found check for match in date field only
                Dim q_date = Convert.ToDateTime(log(0) + " " + log(1) + ":00")
                Me.QsoTableAdapter.FillByQSODate(Me.PJCLogBook2DataSet.Qso, q_date)
                If PJCLogBook2DataSet.Qso.Rows.Count > 0 Then
                    ' need to fix date
                    thisQso = Me.PJCLogBook2DataSet.Qso.Rows(0)
                    thisQso.qsoUTC = Format(q_date, "HHmm")
                    thisQso.qsodate = Format(q_date, "yyyy-MM-dd")
                    thisQso.qsodistance = n_pj.distance
                    thisQso.qsoazmuth = n_pj.asmuth
                Else
                    newQSORow(thisrow.id, qsoDate, qsoUtc, log)
                End If
            End If
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try


        Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
    End Sub

    Private Sub newStationRow(ByVal m_pjc As PJ)
        Dim newRow As PJCLogBook2DataSet.StationRow = Me.PJCLogBook2DataSet.Station.NewRow()
        newRow.callsign = m_pjc.callsign.Split("/")(0).ToUpper
        newRow.name = m_pjc.firstname
        newRow.locator = m_pjc.locator
        newRow.state = m_pjc.state
        newRow.country = m_pjc.country
        newRow.county = m_pjc.county
        newRow.email = m_pjc.email
        If Not IsNothing(m_pjc.locator) Then newRow.distance = MHDistance(myInfo.locator, m_pjc.locator)
        newRow.azmuth = m_pjc.asmuth
        newRow.post = m_pjc.post
        newRow.post = m_pjc.post.ToString("yyyy-MM-dd HH:mm:ss")

        Me.PJCLogBook2DataSet.Station.Rows.Add(newRow)
        Me.StationBindingSource.EndEdit()


    End Sub

    Private Sub newQSORow(ByVal station_ID As Integer, ByVal qso_Date As DateTime, ByVal qso_Utc As String, ByVal log() As String)
        Dim newRow As PJCLogBook2DataSet.QsoRow = Me.PJCLogBook2DataSet.Qso.NewRow()
        newRow.qsodate = qso_Date
        newRow.qsoUTC = qso_Date
        newRow.stationID = station_ID
        newRow.band = log(4)
        newRow.mode = log(5)
        newRow.qsolocator = log(3)

        Me.PJCLogBook2DataSet.Qso.Rows.Add(newRow)
        Me.QsoBindingSource.EndEdit()

    End Sub

    Private Sub CallSignToolStripComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CallSignToolStripComboBox.SelectedIndexChanged
        If StationIDList(sender.selectedindex) > -1 Then
            Me.StationTableAdapter.FillByCallsign(PJCLogBook2DataSet.Station, sender.text)
            SelectedRow = Me.PJCLogBook2DataSet.Station.Rows(0)
        Else
            Me.StationTableAdapter.Fill(Me.PJCLogBook2DataSet.Station)
            BuildStationDropdownList("*")
        End If
    End Sub

    Private Sub QsoUpdated(ByVal id As Long)
        Me.QsoTableAdapter.Fill(Me.PJCLogBook2DataSet.Qso)
    End Sub

    Private Sub QsoDataGridView_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles QsoDataGridView.RowHeaderMouseClick
        Dim QsoID = QsoDataGridView.CurrentRow.Cells("DataGridViewTextBoxID").Value
        If IsNothing(SelectedRow) Then
            SelectedRow = Me.PJCLogBook2DataSet.Station.Rows(0)
        End If

        If IsNothing(frmQSO) Then
            frmQSO = New QSOLog
            AddHandler frmQSO.QsoUpdate, AddressOf QsoUpdated
            frmQSO.callsign = Me.CallsignTextBox.Text
            frmQSO.ID = QsoID
            frmQSO.myInfo = myInfo
            frmQSO.Station = SelectedRow
            frmQSO.Show()
        Else
            If frmQSO.IsDisposed Then
                frmQSO = New QSOLog
                AddHandler frmQSO.QsoUpdate, AddressOf QsoUpdated
                frmQSO.callsign = Me.CallsignTextBox.Text
                frmQSO.ID = QsoID
                frmQSO.myInfo = myInfo
                frmQSO.Station = SelectedRow
                frmQSO.Show()
            Else
                frmQSO.Close()
                frmQSO.Dispose()
            End If
        End If



    End Sub

    Private Sub NewQsoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewQsoToolStripButton.Click
        If IsNothing(SelectedRow) Then
            Me.StationTableAdapter.FillByCallsign(PJCLogBook2DataSet.Station, m_pjc.callsign.Split("/")(0))
            SelectedRow = Me.PJCLogBook2DataSet.Station.Rows(0)
        End If
        If IsNothing(frmQSO) Then
            frmQSO = New QSOLog
            AddHandler frmQSO.QsoUpdate, AddressOf QsoUpdated
            frmQSO.callsign = Me.CallsignTextBox.Text
            frmQSO.pjc = m_pjc
            frmQSO.myInfo = myInfo
            frmQSO.ID = -1
            frmQSO.Station = SelectedRow
            frmQSO.StationID = Convert.ToInt64(Me.IdTextBox.Text)
            frmQSO.Show()
        Else
            If frmQSO.IsDisposed Then
                frmQSO = New QSOLog
                AddHandler frmQSO.QsoUpdate, AddressOf QsoUpdated
                frmQSO.callsign = Me.CallsignTextBox.Text
                frmQSO.pjc = m_pjc
                frmQSO.myInfo = myInfo
                frmQSO.ID = -1
                frmQSO.Station = SelectedRow
                frmQSO.StationID = Convert.ToInt64(Me.IdTextBox.Text)
                frmQSO.Show()
            Else
                frmQSO.Close()
                frmQSO.Dispose()
            End If
        End If

    End Sub

    Private Sub LastPostTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastPostTextBox.TextChanged
        Try
            If LastPostTextBox.Text <> "" Then
                If Convert.ToDateTime(LastPostTextBox.Text) <> "0001-01-01 00:00:00" Then
                    Me.TimeSincePostLabel.Text = FormatTime(DateDiff("s", Convert.ToDateTime(LastPostTextBox.Text), Date.UtcNow))
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Function FormatTime(ByVal seconds As Integer) As String

        Dim Hours = Fix(seconds / 3600)
        Dim Days = Fix(Hours / 24)
        Hours = Hours Mod 24
        seconds = seconds Mod 3600
        Dim Minutes = Fix(seconds / 60)
        seconds = seconds Mod 60

        Dim DaysText = Days.ToString
        Dim HoursText = Hours.ToString.PadLeft(2, "0"c)
        Dim MinutesText = Minutes.ToString.PadLeft(2, "0"c)
        Dim SecondsText = seconds.ToString.PadLeft(2, "0"c)
        Dim ret As String
        If Days > 0 Then
            ret = DaysText + "d " + Hours.ToString.PadLeft(2, "0"c) & ":" & Minutes.ToString.PadLeft(2, "0"c) & ":" & seconds.ToString.PadLeft(2, "0"c)
        Else
            ret = Hours.ToString.PadLeft(2, "0"c) & ":" & Minutes.ToString.PadLeft(2, "0"c) & ":" & seconds.ToString.PadLeft(2, "0"c)
        End If

        Return ret
    End Function

    Private Sub QRZButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRZButton.Click
        Dim req As HttpWebRequest
        Dim res As HttpWebResponse
        Dim webStream As Stream
        Dim webResponse = ""
        If myInfo.QRZUser = "" Or myInfo.QRZpwd = "" Then
            MsgBox("QRZ Login info missing.  Add to Settings", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        req = WebRequest.Create("http://xmldata.qrz.com/xml/current/?username=" & myInfo.QRZUser & ";password=" & myInfo.QRZpwd)
        req.Method = "GET"
        res = req.GetResponse()
        webStream = res.GetResponseStream()
        Dim xmlQrz As XDocument = XDocument.Load(New StreamReader(webStream))
        Dim d = xmlQrz.Descendants()
        Dim qkey As String = ElementValue(d, "Key")

        'For Each Item As XElement In d
        '    If Item.Name.LocalName = "Key" Then
        '        qkey = Item.Value
        '        Exit For
        '    End If
        'Next
        If qkey = "" Then
            MsgBox("QRZ Login not valid")
        End If
        req = WebRequest.Create("http://xmldata.qrz.com/xml/current/?s=" & qkey & ";callsign=" & Me.CallsignTextBox.Text)
        req.Method = "GET"
        res = req.GetResponse()
        webStream = res.GetResponseStream()
        Dim xmlLookup As XDocument = XDocument.Load(New StreamReader(webStream))

        Dim QrzDbase = xmlLookup.Descendants()

        Me.NameTextBox.Text = ElementValue(QrzDbase, "fname") + " " + ElementValue(QrzDbase, "name")
        Me.LocatorTextBox.Text = ElementValue(QrzDbase, "grid")
        Me.CountryTextBox.Text = ElementValue(QrzDbase, "country")
        Me.CountyTextBox.Text = ElementValue(QrzDbase, "county")
        Me.EmailTextBox.Text = ElementValue(QrzDbase, "email")
        Me.AddrTextBox.Text = ElementValue(QrzDbase, "addr1")
        Me.CityTextBox.Text = ElementValue(QrzDbase, "addr2")
        Me.StateTextBox.Text = ElementValue(QrzDbase, "state")
        Me.ZipTextBox.Text = ElementValue(QrzDbase, "zip")
        Me.LatTextBox.Text = ElementValue(QrzDbase, "lat")
        Me.LonTextBox.Text = ElementValue(QrzDbase, "lon")

    End Sub

    Private Function ElementValue(ByVal q As System.Collections.Generic.IEnumerable(Of System.Xml.Linq.XElement), ByVal e As String) As String



        For Each Item As XElement In q
            If Item.Name.LocalName = e Then
                Return Item.Value
            End If
        Next
        Return ""


    End Function

    Private Sub ADIFExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADIFExportToolStripMenuItem.Click
        exportADIF()
    End Sub

    Private Sub ImportWSJTLog(ByVal logarray As ArrayList)
        ' add all itmes to database
        Me.ToolStripProgressBar1.Maximum = logarray.Count

        For Each item In logarray
            Dim n_PJ As New PJ
            n_PJ.logged(-1) = item
            n_PJ.locator = item(3)
            n_PJ.callsign = item(2)
            n_PJ.distance = MHDistance(myInfo.locator, n_PJ.locator)
            n_PJ.asmuth = MHAzmuth(myInfo.locator, n_PJ.locator)

            addQSOToDatabase(n_PJ, item)
            Me.ToolStripProgressBar1.Value += 1
        Next
        Me.ToolStripProgressBar1.Value = 0
    End Sub

    Private Sub exportADIF()
        StationTableAdapter.Fill(PJCLogBook2DataSet.Station)
        QsoTableAdapter.Fill(PJCLogBook2DataSet.Qso)

        Dim myLog = From log In PJCLogBook2DataSet.Qso _
                    Select log
        Dim ADIFOut As String = "<EOH>" & vbCrLf
        Me.SaveFileDialog1.ShowDialog()
        Dim filespec = SaveFileDialog1.FileName
        My.Computer.FileSystem.WriteAllText(filespec, ADIFOut, False)
        If myLog.Count > 0 Then
            For Each qso As PJCLogBook2DataSet.QsoRow In myLog
                Dim QsoStationID = qso.stationID
                Dim thisCall = From c In PJCLogBook2DataSet.Station _
                               Where c.id = QsoStationID _
                               Select c.callsign
                If thisCall.Count > 0 Then
                    If IsNothing(qso.report) Then qso.report = ""
                    If qso.report = "" Then

                        Select Case qso.mode
                            Case "FSK441"
                                qso.report = "26"
                            Case "PSK2K"
                                qso.report = "0dB"
                            Case Else
                                qso.report = "599"
                        End Select

                    End If
                    If IsNothing(qso.band) Then qso.band = ""
                    Select Case qso.band
                        Case "50"
                            qso.band = "6m"
                        Case "144"
                            qso.band = "2m"
                        Case "222"
                            qso.band = "1.25m"
                        Case "432"
                            qso.band = "70cm"
                        Case "1296"
                            qso.band = "13cm"

                    End Select
                    If qso.qsoUTC = "" Then
                        qso.qsoUTC = Format(qso.qsodate, "HHmm")
                    End If
                    If qso.mode = "" Then qso.mode = " "
                    Dim qsoDate = Format(qso.qsodate, "yyyyMMdd")
                    ADIFOut = "<CALL:" & CStr(thisCall(0).Length).ToString & ">" & thisCall(0) & _
                              "<GRIDSQUARE:" & CStr(qso.qsolocator.Length).ToString & ">" & qso.qsolocator & _
                              "<MODE:" & CStr(qso.mode.Length).ToString & ">" & qso.mode & _
                              "<BAND:" & CStr(qso.band.Length).ToString & ">" & qso.band & _
                              "<RST_RCVD:" & CStr(qso.report.Length).ToString & ">" & qso.report & _
                              "<RST_SENT:" & CStr(qso.report.Length).ToString & ">" & qso.report & _
                              "<QSO_DATE:" & CStr(qsoDate).Length & ">" & qsoDate & _
                              "<TIME_ON:" & CStr(qso.qsoUTC).Length & ">" & qso.qsoUTC & _
                              "<TIME_OFF:" & CStr(qso.qsoUTC).Length & ">" & qso.qsoUTC & _
                              "<STATION_CALLSIGN:" & CStr(myInfo.callsign.Split("/")(0).Length) & ">" & myInfo.callsign.Split("/")(0) & _
                              "<MY_GRIDSQUARE:" & CStr(myInfo.locator.Length) & ">" & myInfo.locator & "<eor>" & vbCrLf
                    My.Computer.FileSystem.WriteAllText(filespec, ADIFOut, True)

                End If

            Next


        End If

    End Sub

    Private Sub WSJTLogImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WSJTLogImportToolStripMenuItem.Click
        readLogFile(myInfo.WSJTLogPath)

    End Sub

    Private Sub readLogFile(ByVal filespec As String)
        Me.OpenFileDialog1.FileName = "WSJT.LOG"
        Dim d = filespec.Split("\")

        Dim initDir As String = ""
        If d.Count > 0 Then
            For x = 0 To d.Count - 2
                initDir = initDir + d(x) + "\"
            Next


        End If

        Me.OpenFileDialog1.InitialDirectory = initDir
        Me.OpenFileDialog1.ShowDialog()
        filespec = Me.OpenFileDialog1.FileName

        Dim logarray As New ArrayList
        If filespec <> "" Then
            Try
                If Dir(filespec) <> "" Then
                    Dim sfilereader = System.IO.File.OpenText(filespec)
                    Dim sinputline = sfilereader.ReadLine()

                    Do Until sinputline Is Nothing

                        Dim log = sinputline.Split(",")
                        logarray.Add(log)
                        sinputline = sfilereader.ReadLine()
                    Loop

                End If
            Catch ex As Exception

            End Try
        End If
        ImportWSJTLog(logarray)
    End Sub

    Private Function MHDistance(ByVal myGrid As String, ByVal hisGrid As String) As Double
        Try
            Dim d As Double = DistBearing.MaidenheadLocator.Distance(myGrid, hisGrid)
            If myInfo.metric Then
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

    Private Sub ADIFImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADIFImportToolStripMenuItem.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim filespec = Me.OpenFileDialog1.FileName
        Dim buf As String
        Me.ToolStripProgressBar1.Maximum = 100

        If filespec <> "" Then
            Try
                If Dir(filespec) <> "" Then
                    Dim sfilereader = System.IO.File.OpenText(filespec)
                    Dim sinputline = sfilereader.ReadLine()
                    ' find end of header
                    Do
                        sinputline = sfilereader.ReadLine()
                        If IsNothing(sinputline) Then Exit Sub
                    Loop Until (sinputline.Contains("<EOH>"))
                    ' build string of each ADIF entry and parse into array list
                    Do Until sinputline Is Nothing
                        buf = ""
                        Do
                            sinputline = sfilereader.ReadLine()
                            buf += sinputline
                        Loop Until sinputline.ToUpper.Contains("<EOR>")
                        Dim adi = parseADIF(buf)
                        If Me.ToolStripProgressBar1.Value = Me.ToolStripProgressBar1.Maximum Then Me.ToolStripProgressBar1.Value = Me.ToolStripProgressBar1.Minimum
                        Me.ToolStripProgressBar1.Value += 1
                        If Me.ToolStripProgressBar1.Value > 100 Then Me.ToolStripProgressBar1.Value = 0
                    Loop

                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Function parseADIF(ByVal s As String) As ArrayList
        Dim line = s.Split("<")
        Dim adi As New Dictionary(Of String, String)



        For Each Item As String In line
            Dim a = ADIFItems(Item)
            If Not adi.ContainsKey(a(0)) Then
                adi.Add(a(0), a(1))
            End If


        Next
        Dim a_pj As New PJ

        If adi.ContainsKey("call") Then a_pj.callsign = adi.Item("call")
        If adi.ContainsKey("name") Then a_pj.firstname = adi.Item("name")
        If adi.ContainsKey("email") Then a_pj.email = adi.Item("email")
        If adi.ContainsKey("country") Then a_pj.country = adi.Item("country")
        If adi.ContainsKey("county") Then a_pj.county = adi.Item("county")
        If adi.ContainsKey("qth") Then a_pj.state = adi.Item("qth")
        Dim log(5) As String

        log(0) = adi.Item("qso_date").Insert(4, "-").Insert(7, "-")
        log(1) = adi.Item("time_on").Substring(0, 4).Insert(2, ":")
        If adi.ContainsKey("grid") Then log(3) = adi.Item("grid")
        log(4) = adi.Item("mode")
        log(5) = adi.Item("band")

        addQSOToDatabase(a_pj, log)


    End Function

    Private Function ADIFItems(ByVal item As String) As String()

        Dim n1 As String = ""
        Dim n2() As String
        Dim n3 As String = ""

        Dim n = item.Split(":")
        If n.Count > 1 Then
            n1 = n(0)
            n2 = n(1).Split(">")
            If n2.Count > 1 Then
                n3 = n2(1)
            End If
        End If
        Dim ret(1) As String
        ret(0) = n1.ToLower
        ret(1) = n3
        Return ret
    End Function
End Class
