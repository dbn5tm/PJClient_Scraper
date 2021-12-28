Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Public Class QSOLog
    Private frmImg As ImgDialog

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
        End Set
    End Property

    Private m_Station As PJCLogBook2DataSet.StationRow
    Public Property Station() As PJCLogBook2DataSet.StationRow
        Get
            Return m_Station
        End Get
        Set(ByVal value As PJCLogBook2DataSet.StationRow)
            m_Station = value
        End Set
    End Property

    Private m_QSO As PJCLogBook2DataSet.QsoRow
    Public Property QSO() As PJCLogBook2DataSet.QsoRow
        Get
            Return m_QSO
        End Get
        Set(ByVal value As PJCLogBook2DataSet.QsoRow)
            m_QSO = value
        End Set
    End Property

    Private m_StationID As Long
    Public Property StationID() As Long
        Get
            Return m_StationID
        End Get
        Set(ByVal value As Long)
            m_StationID = value
        End Set
    End Property

    Private m_ID As Long
    Public Property ID() As Long
        Get
            Return m_ID
        End Get
        Set(ByVal value As Long)
            m_ID = value
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

    Public Event QsoUpdate(ByVal id As Long)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.Validate()
        Me.StationBindingSource.EndEdit()
        Me.QsoBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
        RaiseEvent QsoUpdate(ID)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub QsoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QsoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QsoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)

    End Sub

    Private Sub QSOLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PJCLogBook2DataSet.EnforceConstraints = False
        'TODO: This line of code loads data into the 'PJCLogBook2DataSet.Station' table. You can move, or remove it, as needed.
        Me.StationTableAdapter.Fill(Me.PJCLogBook2DataSet.Station)
        Me.PJCLogBook2DataSet.EnforceConstraints = False
        'TODO: This line of code loads data into the 'PJCLogBook2DataSet.Qso' table. You can move, or remove it, as needed.
        newDateBinding()
        Me.QSODateTimePicker.Format = DateTimePickerFormat.Custom
        Me.QSODateTimePicker.CustomFormat = "yyyy-MM-dd"

        If Not IsNothing(m_ID) Then
            If m_ID = -1 Then
                ' new row
                newQSORow()
            Else
                Me.QsoTableAdapter.FillByID(Me.PJCLogBook2DataSet.Qso, m_ID)
                Me.StationTextBox.Text = m_callsign.Split("/")(0)
            End If
            If Me.ReportTextBox.Text = "" Then

                Select Case Me.ModeTextBox.Text
                    Case "FSK441"
                        ReportTextBox.Text = "26"
                    Case "PSK2K"
                        ReportTextBox.Text = "0dB"
                    Case Else
                        ReportTextBox.Text = "599"
                End Select

            End If
        Else
            Me.QsoTableAdapter.Fill(Me.PJCLogBook2DataSet.Qso)

        End If

    End Sub

    Private Sub newDateBinding()
        Dim bndBinding As New Binding("Text", QsoBindingSource, "qsodate")
        AddHandler bndBinding.Format, AddressOf DBdateTextbox
        AddHandler bndBinding.Parse, AddressOf TextBoxDBdate

        Me.QSOFormatedDateTextBox.DataBindings.Add(bndBinding)

    End Sub

    'Handler for binding format
    Private Sub DBdateTextbox(ByVal sender As Object, ByVal cevent As ConvertEventArgs)
        If cevent.Value Is DBNull.Value Then
            cevent.Value = ""
        Else
            'Dim datum As Date
            'cevent.Value = datum.ToString("yyyy-MM-dd")
            cevent.Value = Format(cevent.Value, "yyyy-MM-dd")
        End If
    End Sub

    Private Sub TextBoxDBdate(ByVal sender As Object, ByVal cevent As ConvertEventArgs)
        If cevent.Value.ToString = "" Then
            cevent.Value = DBNull.Value
        End If
    End Sub

    Private Sub newQSORow()
        Dim newRow As PJCLogBook2DataSet.QsoRow = Me.PJCLogBook2DataSet.Qso.NewRow()
        If Not IsNothing(Station) Then
            newRow.stationID = Station.id
            Me.StationTextBox.Text = Station.callsign
            If Not IsNothing(Station.locator) Then
                newRow.qsolocator = Station.locator
                If Station.distance Then newRow.qsodistance = Station.distance
                newRow.qsoazmuth = Convert.ToSingle(Station.azmuth)
            End If
        Else
            newRow.stationID = StationID
            Me.StationTextBox.Text = m_pjc.callsign.Split("/")(0)
            newRow.qsolocator = m_pjc.locator
            newRow.qsodistance = m_pjc.distance
            newRow.qsoazmuth = Convert.ToSingle(m_pjc.asmuth)
        End If



        newRow.qsodate = Format(Date.UtcNow, "yyyy-MM-dd")
        newRow.qsoUTC = Format(Date.UtcNow, "HHmm")



        Me.PJCLogBook2DataSet.Qso.Rows.Add(newRow)
        ' these two rows were causing a concurrency error.
        'Me.QsoBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.PJCLogBook2DataSet)
    End Sub

    Private Sub ImgButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgButton.Click
        Me.OpenFileDialog1.ShowDialog()
        Me.ImgTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub setReports(ByVal mode As String)
        Select Case mode
            Case "FSK441"
                Me.ReportTextBox.Text = "26"
                Me.SentTextBox.Text = "26"
            Case "PSK2K"
                Me.ReportTextBox.Text = "0dB"
                Me.SentTextBox.Text = "0dB"
            Case "JT65", "ISCAT"
                Me.ReportTextBox.Text = "-20"
                Me.SentTextBox.Text = "-20"
            Case "CW"
                Me.ReportTextBox.Text = "599"
                Me.SentTextBox.Text = "599"
            Case "SSB"
                Me.ReportTextBox.Text = "59"
                Me.SentTextBox.Text = "59"
        End Select
    End Sub

    Private Sub setStation(ByVal band As String)
        Dim x = -1

        For x = 0 To 2
            If myInfo.band(x) = band Then
                Exit For
            End If
        Next
        If x >= 0 Then
            PowerTextBox.Text = myInfo.power(x)
            AntennaTextBox.Text = myInfo.antenna(x)
        End If



    End Sub

    Private Sub ImgTextBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ImgTextBox.DoubleClick
        frmImg = New ImgDialog
        frmImg.fspec = Me.ImgTextBox.Text
        frmImg.Show()
    End Sub

    Private Sub BandTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BandTextBox.TextChanged
        Me.BandComboBox.Text = sender.text
    End Sub

    Private Sub BandComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BandComboBox.SelectedIndexChanged
        Me.BandTextBox.Text = sender.text
        setStation(sender.text)
    End Sub

    Private Sub ModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeComboBox.SelectedIndexChanged
        Me.ModeTextBox.Text = sender.text
    End Sub

    Private Sub ModeTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModeTextBox.TextChanged
        Me.ModeComboBox.Text = sender.text
        setReports(sender.text)
    End Sub

    Private Sub ShowImgButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowImgButton.Click
        If Me.ImgTextBox.Text <> "" Then
            If Dir(Me.ImgTextBox.Text) <> "" Then
                frmImg = New ImgDialog
                frmImg.fspec = Me.ImgTextBox.Text
                frmImg.Show()
            End If

        End If

    End Sub
End Class