Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.XPath
Imports System.IO
Imports System.Xml.Schema

Public Class StationDialog
    Dim xStation As XDocument
    Public DataPath As String
    Dim all_stations As New ArrayList
    Public logarray As New ArrayList
    Dim qrzKey As String
    'Dim xDoc As New XDocument


    Private m_QRZLogin As String
    Public Property QRZLogin() As String
        Get
            Return m_QRZlogin
        End Get
        Set(ByVal value As String)
            m_QRZlogin = value
        End Set
    End Property

    Private m_QRZPwd As String
    Public Property QRZPwd() As String
        Get
            Return m_QRZPwd
        End Get
        Set(ByVal value As String)
            m_QRZPwd = value
        End Set
    End Property


    Private m_pjc As PJ
    Public Property pjc() As PJ
        Get
            Return m_pjc
        End Get
        Set(ByVal value As PJ)
            m_pjc = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        SaveStationElement()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub InitListview(ByVal t_pjc As PJ)
        ListView1.Clear()
        ' Set ListView Properties
        'ListView1.View = View.Details
        'ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False
        ListView1.MultiSelect = False
        ListView1.Sorting = SortOrder.Ascending


        ' Create Columns Headers

        ListView1.Columns.Add("Date")
        ListView1.Columns.Add("Time")
        ListView1.Columns.Add("Call")
        ListView1.Columns.Add("Grid")
        ListView1.Columns.Add("Band")
        ListView1.Columns.Add("Mode")
        ListView1.Columns(0).Width = 100
        Dim lvi As ListViewItem

        For i = 0 To t_pjc.logCount - 1

            ' Create List View Item (Row)
            lvi = New ListViewItem

            ' First Column can be the listview item's Text
            lvi.Text = t_pjc.logged(i)(0)

            ' Second Column is the first sub item

            lvi.SubItems.Add(t_pjc.logged(i)(1))

            ' Third - fifth Column as sub items

            lvi.SubItems.Add(t_pjc.logged(i)(2))
            lvi.SubItems.Add(t_pjc.logged(i)(3))
            lvi.SubItems.Add(t_pjc.logged(i)(4))
            lvi.SubItems.Add(t_pjc.logged(i)(5))
            ' Add the ListViewItem to the ListView
            ListView1.Items.Add(lvi)
        Next
        'Dim sInfo = From s In xStation.<Stations>.<radio> _
        '            Where s.<callsign>.Value.ToUpper = m_pjc.callsign.Split("/")(0).ToUpper _
        '            Select s

        'Dim sQso = From q In sInfo.<qso> _
        '           Where q.<call>.@value.ToUpper = m_pjc.callsign.Split("/")(0).ToUpper _
        '           Select q

        'Dim childElements = sQso(0).<call>

        'For x = 0 To childElements.Count - 1
        '    lvi = New ListViewItem
        '    lvi.Text = childElements(x).<date>.Value

        '    lvi.SubItems.Add(childElements(x).<time>.Value)
        '    lvi.SubItems.Add(childElements(x).@value)
        '    lvi.SubItems.Add(childElements(x).<grid>.Value)
        '    lvi.SubItems.Add(childElements(x).<band>.Value)
        '    lvi.SubItems.Add(childElements(x).<mode>.Value)
        '    ListView1.Items.Add(lvi)
        'Next


    End Sub

    Private Sub StationDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Me.CallsignComboBox.Text = m_pjc.callsign
        'Me.NameTextBox.Text = m_pjc.firstname
        'Me.LocatorTextBox.Text = m_pjc.locator
        'Me.StateTextBox.Text = m_pjc.state
        'Me.EmailTextBox.Text = m_pjc.email
        'Me.DistanceTextBox.Text = m_pjc.distance
        'Me.AzmuthTextBox.Text = m_pjc.azmuth
        'Me.LastPostLabel.Text = m_pjc.post.ToString("yyyy-MM-dd HH:mm:ss")
        'DataPath = Application.UserAppDataPath
        'DataPath = Application.CommonAppDataPath
        LoadStationXMLDocument()
        
        'newStationRow()
        fillCallsignDropDown()
        If Not IsNothing(m_pjc) Then fillForm(m_pjc)
        If Me.QRZLogin <> "" Then qrzKey = GetQRZSessionKey()

    End Sub

    Private Sub fillForm(ByVal t_pjc As PJ)
        Me.CallsignComboBox.Text = t_pjc.callsign
        Me.NameTextBox.Text = t_pjc.firstname
        Me.LocatorTextBox.Text = t_pjc.locator
        Me.Addr1TextBox.Text = t_pjc.addr1
        Me.Addr2TextBox.Text = t_pjc.addr2
        Me.StateTextBox.Text = t_pjc.state
        Me.CountryTextBox.Text = t_pjc.country
        Me.EmailTextBox.Text = t_pjc.email
        Me.DistanceTextBox.Text = t_pjc.distance
        Me.AzmuthTextBox.Text = t_pjc.azmuth
        Me.LastPostLabel.Text = t_pjc.post.ToString("yyyy-MM-dd HH:mm:ss")
        Try
            Dim sInfo = From s In xStation.<Stations>.<radio> _
                                Where s.<callsign>.Value = t_pjc.callsign.Split("/")(0) _
                                Select s
            Me.StationTextBox.Text = sInfo(0).<equipment>.Value

        Catch ex As Exception

        End Try

        InitListview(t_pjc)
    End Sub

    Private Sub fillCallsignDropDown()

        all_stations.Clear()
        For Each s As XElement In xStation.<Stations>.<radio>.OrderBy(Function(callsign) callsign.Value)
            Me.CallsignComboBox.Items.Add(s.<callsign>.Value)
            all_stations.Add(s)
        Next


    End Sub
    'Private Sub newStationRow()
    '    Dim newRow As PJCLogBook2DataSet.StationRow = Me.PJCLogBook2DataSet.Station.NewRow()
    '    newRow.callsign = m_pjc.callsign
    '    newRow.name = m_pjc.firstname
    '    newRow.locator = m_pjc.locator
    '    newRow.state = m_pjc.state
    '    newRow.email = m_pjc.email
    '    newRow.distance = m_pjc.distance
    '    newRow.azmuth = m_pjc.asmuth
    '    newRow.post = m_pjc.post.ToString("yyyy-MM-dd HH:mm:ss")

    '    Me.PJCLogBook2DataSet.Station.Rows.Add(newRow)
    '    Me.StationBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)

    'End Sub

    Private Sub LoadStationXMLDocument()

        Try
            xStation = XDocument.Load(DataPath + "\Station.xml")
        Catch ex As Exception
            xStation = <?xml version="1.0"?>
                       <Stations>
                           <radio>
                               <callsign><%= Me.CallsignComboBox.Text.Split("/")(0) %></callsign>
                               <name><%= Me.NameTextBox.Text %></name>
                               <locator><%= Me.LocatorTextBox.Text %></locator>
                               <azmuth><%= Me.AzmuthTextBox.Text %></azmuth>
                               <distance><%= Me.DistanceTextBox.Text %></distance>
                               <state><%= Me.StateTextBox.Text %></state>
                               <addr1><%= Me.Addr1TextBox.Text %></addr1>
                               <addr2><%= Me.Addr2TextBox.Text %></addr2>
                               <country><%= Me.CountryTextBox.Text %></country>
                               <email><%= Me.EmailTextBox.Text %></email>
                               <equipment><%= Me.StationTextBox.Text %></equipment>
                               <qso></qso>
                           </radio>
                       </Stations>

            My.Computer.FileSystem.WriteAllText(DataPath + "\Station.xml", xStation.ToString(), False)
        End Try
    End Sub

    Private Sub SaveQSOElement(ByVal qCall As String, ByVal wDate As String, ByVal wUTC As String, ByVal wBand As String, ByVal wReport As String _
                               , ByVal wMode As String, ByVal wGrid As String, ByVal wDistance As Single, ByVal wPower As String _
                               , ByVal wAntenna As String, ByVal wHisPower As String, ByVal wHisAntenna As String, ByVal wQSOTime As String _
                               , ByVal wShower As String, ByVal wExchange As String)

        Dim sInfo = From s In xStation.<Stations>.<radio> _
                    Where s.<callsign>.Value.ToUpper = qCall.Split("/")(0).ToUpper _
                    Select s

        Dim sQso = From q In sInfo.<qso> _
                   Where q.<call>.@value.ToUpper = qCall.Split("/")(0).ToUpper _
                   Select q
        Dim existingRecord As Boolean = False

        If sQso.Count > 0 Then

            For Each Item As Object In sQso
                If sQso.<date>.Value = wDate And sQso.<time>.Value = wUTC Then
                    sQso.<date>.Value = wDate
                    sQso.<time>.Value = wUTC
                    sQso.<band>.Value = wBand
                    sQso.<report>.Value = wReport
                    sQso.<mode>.Value = wMode
                    sQso.<grid>.Value = wGrid
                    sQso.<distance>.Value = wDistance
                    sQso.<power>.Value = wPower
                    sQso.<antenna>.Value = wAntenna
                    sQso.<hisPower>.Value = wHisPower
                    sQso.<hisAntenna>.Value = wHisAntenna
                    sQso.<QSOTime>.Value = wQSOTime
                    sQso.<shower>.Value = wShower
                    sQso.<exchange>.Value = wExchange
                    existingRecord = True
                    Exit For
                End If
            Next

        End If

        If Not existingRecord Then
            Dim qElement = <call value=<%= qCall %>>
                               <date><%= wDate %></date>
                               <time><%= wUTC %></time>
                               <band><%= wBand %></band>
                               <report><%= wReport %></report>
                               <mode><%= wMode %></mode>
                               <grid><%= wGrid %></grid>
                               <distance><%= wDistance %></distance>
                               <power><%= wPower %></power>
                               <antenna><%= wAntenna %></antenna>
                               <hisPower><%= wHisPower %></hisPower>
                               <hisAntenna><%= wHisAntenna %></hisAntenna>
                               <QSOTime><%= wQSOTime %></QSOTime>
                               <shower><%= wShower %></shower>
                               <exchange><%= wExchange %></exchange>
                           </call>

            sQso(0).Add(qElement)
        End If
        My.Computer.FileSystem.WriteAllText(DataPath + "\Station.xml", xStation.ToString(), False)
    End Sub

    Private Sub SaveStationElement()
        If Me.CallsignComboBox.Text <> "" Then

            Dim sInfo = From s In xStation.<Stations>.<radio> _
                        Where s.<callsign>.Value = Me.CallsignComboBox.Text _
                        Select s
            If sInfo.Count > 0 Then
                'sInfo(0).<callsign>.Value = Me.CallsignTextBox.Text
                sInfo(0).<name>.Value = Me.NameTextBox.Text
                sInfo(0).<locator>.Value = Me.LocatorTextBox.Text
                sInfo(0).<state>.Value = Me.StateTextBox.Text
                ' country node was added later, so check to see if it exists.
                If IsNothing(sInfo(0).<country>.Value) Then
                    sInfo(0).Add(New XElement("country", Me.CountryTextBox.Text))
                Else
                    sInfo(0).<country>.Value = Me.CountryTextBox.Text
                End If
                If IsNothing(sInfo(0).<addr1>.Value) Then
                    sInfo(0).Add(New XElement("addr1", Me.Addr1TextBox.Text))
                Else
                    sInfo(0).<addr1>.Value = Me.Addr1TextBox.Text
                End If
                If IsNothing(sInfo(0).<addr2>.Value) Then
                    sInfo(0).Add(New XElement("addr2", Me.Addr2TextBox.Text))
                Else
                    sInfo(0).<addr2>.Value = Me.Addr2TextBox.Text
                End If

                sInfo(0).<email>.Value = Me.EmailTextBox.Text
                sInfo(0).<asmuth>.Value = Me.AzmuthTextBox.Text
                sInfo(0).<distance>.Value = Me.DistanceTextBox.Text
                sInfo(0).<equipment>.Value = Me.StationTextBox.Text
                'below alternate code.
                'xStation.<Stations>.<radio>.Elements(Me.CallsignComboBox.Text).<country>.Value = Me.CountryTextBox.Text
            Else

                Dim sElement = <radio>
                                   <callsign><%= Me.CallsignComboBox.Text.Split("/")(0) %></callsign>
                                   <name><%= Me.NameTextBox.Text %></name>
                                   <locator><%= Me.LocatorTextBox.Text %></locator>
                                   <azmuth><%= Me.AzmuthTextBox.Text %></azmuth>
                                   <distance><%= Me.DistanceTextBox.Text %></distance>
                                   <addr1><%= Me.Addr1TextBox.Text %></addr1>
                                   <addr2><%= Me.Addr2TextBox.Text %></addr2>
                                   <state><%= Me.StateTextBox.Text %></state>
                                   <country><%= Me.CountryTextBox.Text %></country>
                                   <email><%= Me.EmailTextBox.Text %></email>
                                   <equipment><%= Me.StationTextBox.Text %></equipment>
                                   <qso></qso>
                               </radio>
                Dim stations = xStation.<Stations>(0)
                stations.Add(sElement)

            End If
                My.Computer.FileSystem.WriteAllText(DataPath + "\Station.xml", xStation.ToString(), False)
            End If
    End Sub

    Private Sub LogOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOKButton.Click
        SaveQSOElement(Me.LogCallsignTextBox.Text, Me.LogDateTextBox.Text, Me.LogUTCTextBox.Text, Me.LogBandTextBox.Text, Me.LogReportTextBox.Text, _
                               Me.LogModeTextBox.Text, Me.LogGridTextBox.Text, Me.LogDistanceTextBox.Text, Me.LogPowerTextBox.Text, Me.LogAntennaTextBox.Text, _
                               Me.LogHisPowerTextBox.Text, Me.LogHisAntennaTextBox.Text, Me.LogQsoTimeTextBox.Text, Me.LogShowerTextBox.Text, Me.LogExchangeTextBox.Text)

        LogQSOGroupBox.Visible = False

    End Sub

    Private Sub ListView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseUp
        Return
        If ListView1.SelectedIndices.Count = 0 Then Return

        Dim lvi As ListViewItem = ListView1.SelectedItems(0)
        LogQSOGroupBox.Visible = True

        Me.LogDateTextBox.Text = lvi.Text
        Me.LogUTCTextBox.Text = lvi.SubItems(1).Text

        Dim sInfo = From s In xStation.<Stations>.<radio> _
                            Where s.<callsign>.Value.ToUpper = m_pjc.callsign.Split("/")(0).ToUpper _
                            Select s

        Dim sQso = From q In sInfo.<qso> _
                   Where q.<call>.@value.ToUpper = m_pjc.callsign.Split("/")(0).ToUpper _
                   Select q

        Dim childElements = sQso(0).<call>

        For x = 0 To childElements.Count - 1
            If childElements(x).<date>.Value = lvi.Text And childElements(x).<time>.Value = lvi.SubItems(1).Text Then
                Me.LogCallsignTextBox.Text = childElements(x).<call>.@value
                Me.LogExchangeTextBox.Text = childElements(x).<exchange>.Value
                Me.LogGridTextBox.Text = childElements(x).<grid>.Value
                Me.LogDistanceTextBox.Text = childElements(x).<distance>.Value
                Me.LogHisAntennaTextBox.Text = childElements(x).<hisAntenna>.Value
                Me.LogHisPowerTextBox.Text = childElements(x).<hisPower>.Value
                Me.LogModeTextBox.Text = childElements(x).<mode>.Value
                Me.LogReportTextBox.Text = childElements(x).<report>.Value
                Me.LogShowerTextBox.Text = childElements(x).<shower>.Value
            End If
        Next


    End Sub

    'Private Sub StationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StationBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.StationBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)

    'End Sub

    Private Sub CallsignComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CallsignComboBox.SelectedIndexChanged
        Dim this_pjc = New PJ
        For Each s As XElement In all_stations
            If s.<callsign>.Value = sender.text.split("/")(0) Then
                this_pjc.callsign = s.<callsign>.Value
                this_pjc.firstname = s.<name>.Value
                this_pjc.email = s.<email>.Value
                this_pjc.locator = s.<locator>.Value
                this_pjc.addr1 = s.<addr1>.Value
                this_pjc.addr2 = s.<addr2>.Value
                this_pjc.state = s.<state>.Value
                this_pjc.country = s.<country>.Value
                this_pjc.distance = s.<distance>.Value
                this_pjc.azmuth = s.<azmuth>.Value
                fillForm(this_pjc)

                Exit For
            End If

        Next


        For Each s As String() In Me.logarray
            If s(2) = CallsignComboBox.Text Then
                this_pjc.logged(-1) = s

            End If
        Next
        InitListview(this_pjc)
        this_pjc = Nothing

    End Sub

    Private Sub LogContactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Future")
        'LogQSOGroupBox.Visible = True

        'Me.LogCallsignTextBox.Text = Me.CallsignComboBox.Text
        'Me.LogDateTextBox.Text = Date.UtcNow.ToShortDateString
        'Me.LogUTCTextBox.Text = Date.UtcNow.ToString("hhmm")
        'Me.LogDistanceTextBox.Text = Me.DistanceTextBox.Text
        'Me.LogGridTextBox.Text = pjc.locator
    End Sub

    Private Sub QRZButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRZButton.Click
        Try
            If qrzKey <> "" Then
                Dim xQRZ = New XmlDocument
                Dim queryStr = "http://xml.qrz.com/xml?s=" + qrzKey + ";callsign=" + Me.CallsignComboBox.Text
                xQRZ.Load(queryStr)
                Me.NameTextBox.Text = xQRZ.GetElementsByTagName("fname")(0).InnerText _
                                    + " " + xQRZ.GetElementsByTagName("name")(0).InnerText
                Me.CountryTextBox.Text = xQRZ.GetElementsByTagName("country")(0).InnerText
                Me.EmailTextBox.Text = xQRZ.GetElementsByTagName("email")(0).InnerText
                Me.Addr1TextBox.Text = xQRZ.GetElementsByTagName("addr1")(0).InnerText
                Me.Addr2TextBox.Text = xQRZ.GetElementsByTagName("addr2")(0).InnerText
                Me.LocatorTextBox.Text = xQRZ.GetElementsByTagName("grid")(0).InnerText
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Function GetQRZSessionKey() As String
        Try
            Dim xDocKey As New XmlDocument
            ' use traditional xml methods to extract key
            xDocKey.Load("http://xml.qrz.com/xml?username=" & Me.QRZLogin & ";password=" & Me.QRZPwd & ";agent=q5.0")
            Dim keyElement = xDocKey.GetElementsByTagName("Key")
            Dim key As String
            If keyElement.Count > 0 Then
                key = keyElement(0).InnerText
            Else
                key = ""
            End If
            Dim alert = xDocKey.GetElementsByTagName("Alert")
            If alert.Count > 0 Then
                MsgBox("Alert:" + alert(0).InnerText)
            End If
            Dim errmsg = xDocKey.GetElementsByTagName("Error")
            If errmsg.Count > 0 Then
                MsgBox("Error:" + errmsg(0).InnerText)
            End If
            Return key
        Catch ex As System.Net.WebException   'Error in accessing the resource, handle it
            Return ""
        End Try
    End Function

    Private Function LookUpCallSign(ByVal callsign As String) As IEnumerable(Of XElement)

        Dim queryStr = "http://xml.qrz.com/xml?s=" + qrzKey + ";callsign=" + callsign
        Dim xDoc = XDocument.Load(queryStr)

        Dim ret = From el In xDoc.Elements() _
        Select el


        Return ret

    End Function

    Private Sub ApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyButton.Click
        SaveStationElement()
    End Sub
End Class
