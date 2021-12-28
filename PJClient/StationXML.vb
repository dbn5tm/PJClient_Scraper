Public Class StationXML

    Dim DataPath As String  ' = Application.UserAppDataPath
    Dim xStation As XDocument

    'Private m_npj As PJ
    'Public Property npj() As PJ
    '    Get
    '        Return m_npj
    '    End Get
    '    Set(ByVal value As PJ)
    '        m_npj = value
    '    End Set
    'End Property

    Public Sub New(AppPath As String)
        DataPath = AppPath
        LoadStationXMLDocument(AppPath)
    End Sub

    Private Sub LoadStationXMLDocument(DataPath As String)

        Try
            xStation = XDocument.Load(DataPath + "\Station.xml")
        Catch ex As Exception
            xStation = <?xml version="1.0"?>
                       <Stations>
                       </Stations>

            My.Computer.FileSystem.WriteAllText(DataPath + "\Station.xml", xStation.ToString(), False)
        End Try
    End Sub

    Public Sub SaveQSOElement(ByVal qCall As String, ByVal wDate As String, ByVal wUTC As String, ByVal wBand As String, ByVal wReport As String _
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

    Public Sub SaveStationElement(ByVal m_npj As PJ)
        Dim sInfo = From s In xStation.<Stations>.<radio> _
                    Where s.<callsign>.Value = m_npj.callsign.Split("/")(0) _
                    Select s
        ' if station already in XML just update data 
        If sInfo.Count > 0 Then
            sInfo(0).<callsign>.Value = m_npj.callsign.Split("/")(0)
            sInfo(0).<name>.Value = m_npj.firstname
            sInfo(0).<locator>.Value = m_npj.locator
            sInfo(0).<asmuth>.Value = m_npj.azmuth
            sInfo(0).<distance>.Value = m_npj.distance
            sInfo(0).<state>.Value = m_npj.state
            sInfo(0).<email>.Value = m_npj.email
            sInfo(0).<county>.Value = m_npj.county
            sInfo(0).<country>.Value = m_npj.country
            sInfo(0).<post>.Value = m_npj.post

            sInfo(0).<equipment>.Value = m_npj.station
        Else
            ' add station to XML file
            Dim sElement = <radio>
                               <callsign><%= m_npj.callsign.Split("/")(0) %></callsign>
                               <name><%= m_npj.firstname %></name>
                               <locator><%= m_npj.locator %></locator>
                               <azmuth><%= m_npj.azmuth %></azmuth>
                               <distance><%= m_npj.distance %></distance>
                               <state><%= m_npj.state %></state>
                               <email><%= m_npj.email %></email>
                               <county><%= m_npj.county %></county>
                               <country><%= m_npj.country %></country>
                               <post><%= m_npj.post %></post>
                               <equipment><%= m_npj.station %></equipment>
                               <qso></qso>
                           </radio>
            Dim stations = xStation.<Stations>(0)
            stations.Add(sElement)

        End If
        My.Computer.FileSystem.WriteAllText(DataPath + "\Station.xml", xStation.ToString(), False)

    End Sub

    Public Function PostHistory(ByVal history As Integer) As ArrayList
        Dim sInfo = From s In xStation.<Stations>.<radio> _
                    Where DateDiff("s", s.<post>.Value, Date.UtcNow) < history _
                    Select s
        Dim retArray As New ArrayList

        For s = 0 To sInfo.Count - 1
            Dim npj = New PJ
            npj.callsign = sInfo(s).<callsign>.Value
            npj.distance = sInfo(s).<distance>.Value
            npj.state = sInfo(s).<state>.Value
            npj.locator = sInfo(s).<locator>.Value
            npj.azmuth = sInfo(s).<azmuth>.Value
            npj.firstname = sInfo(s).<firstname>.Value
            retArray.Add(npj)
        Next

        Return retArray
    End Function
End Class
