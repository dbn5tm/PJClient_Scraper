<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StationDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LastPostLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.LocatorTextBox = New System.Windows.Forms.TextBox
        Me.DistanceTextBox = New System.Windows.Forms.TextBox
        Me.AzmuthTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.StationTextBox = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.LogQSOGroupBox = New System.Windows.Forms.GroupBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LogCancelButton = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.LogBandTextBox = New System.Windows.Forms.TextBox
        Me.LogOKButton = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.LogExchangeTextBox = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.LogShowerTextBox = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.LogQsoTimeTextBox = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.LogHisAntennaTextBox = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.LogHisPowerTextBox = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.LogAntennaTextBox = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.LogPowerTextBox = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.LogDistanceTextBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.LogGridTextBox = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.LogModeTextBox = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.LogReportTextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.LogUTCTextBox = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.LogDateTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.LogCallsignTextBox = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.CallsignComboBox = New System.Windows.Forms.ComboBox
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.QRZButton = New System.Windows.Forms.Button
        Me.Addr1TextBox = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Addr2TextBox = New System.Windows.Forms.TextBox
        Me.ApplyButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.LogQSOGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(410, 418)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(181, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(11, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(102, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Callsign"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Locator"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Email"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(45, 260)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(475, 136)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Distance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Azmuth"
        '
        'LastPostLabel
        '
        Me.LastPostLabel.AutoSize = True
        Me.LastPostLabel.Location = New System.Drawing.Point(347, 33)
        Me.LastPostLabel.Name = "LastPostLabel"
        Me.LastPostLabel.Size = New System.Drawing.Size(49, 13)
        Me.LastPostLabel.TabIndex = 16
        Me.LastPostLabel.Text = "00:00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Last Post"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(111, 198)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(380, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(110, 172)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 6
        '
        'LocatorTextBox
        '
        Me.LocatorTextBox.Location = New System.Drawing.Point(112, 88)
        Me.LocatorTextBox.Name = "LocatorTextBox"
        Me.LocatorTextBox.Size = New System.Drawing.Size(72, 20)
        Me.LocatorTextBox.TabIndex = 3
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(267, 88)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.Size = New System.Drawing.Size(79, 20)
        Me.DistanceTextBox.TabIndex = 4
        '
        'AzmuthTextBox
        '
        Me.AzmuthTextBox.Location = New System.Drawing.Point(422, 90)
        Me.AzmuthTextBox.Name = "AzmuthTextBox"
        Me.AzmuthTextBox.Size = New System.Drawing.Size(70, 20)
        Me.AzmuthTextBox.TabIndex = 5
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(112, 56)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(172, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Station"
        '
        'StationTextBox
        '
        Me.StationTextBox.Location = New System.Drawing.Point(111, 232)
        Me.StationTextBox.Name = "StationTextBox"
        Me.StationTextBox.Size = New System.Drawing.Size(380, 20)
        Me.StationTextBox.TabIndex = 26
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogQSOGroupBox
        '
        Me.LogQSOGroupBox.Controls.Add(Me.Label28)
        Me.LogQSOGroupBox.Controls.Add(Me.TextBox1)
        Me.LogQSOGroupBox.Controls.Add(Me.LogCancelButton)
        Me.LogQSOGroupBox.Controls.Add(Me.Label26)
        Me.LogQSOGroupBox.Controls.Add(Me.LogBandTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.LogOKButton)
        Me.LogQSOGroupBox.Controls.Add(Me.Label25)
        Me.LogQSOGroupBox.Controls.Add(Me.LogExchangeTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label24)
        Me.LogQSOGroupBox.Controls.Add(Me.LogShowerTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label23)
        Me.LogQSOGroupBox.Controls.Add(Me.LogQsoTimeTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label20)
        Me.LogQSOGroupBox.Controls.Add(Me.Label21)
        Me.LogQSOGroupBox.Controls.Add(Me.LogHisAntennaTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label22)
        Me.LogQSOGroupBox.Controls.Add(Me.LogHisPowerTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label19)
        Me.LogQSOGroupBox.Controls.Add(Me.Label18)
        Me.LogQSOGroupBox.Controls.Add(Me.LogAntennaTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label17)
        Me.LogQSOGroupBox.Controls.Add(Me.LogPowerTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label16)
        Me.LogQSOGroupBox.Controls.Add(Me.LogDistanceTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label15)
        Me.LogQSOGroupBox.Controls.Add(Me.LogGridTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label14)
        Me.LogQSOGroupBox.Controls.Add(Me.LogModeTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label13)
        Me.LogQSOGroupBox.Controls.Add(Me.LogReportTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label12)
        Me.LogQSOGroupBox.Controls.Add(Me.LogUTCTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label11)
        Me.LogQSOGroupBox.Controls.Add(Me.LogDateTextBox)
        Me.LogQSOGroupBox.Controls.Add(Me.Label10)
        Me.LogQSOGroupBox.Controls.Add(Me.LogCallsignTextBox)
        Me.LogQSOGroupBox.Location = New System.Drawing.Point(293, 450)
        Me.LogQSOGroupBox.Name = "LogQSOGroupBox"
        Me.LogQSOGroupBox.Size = New System.Drawing.Size(504, 252)
        Me.LogQSOGroupBox.TabIndex = 28
        Me.LogQSOGroupBox.TabStop = False
        Me.LogQSOGroupBox.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(27, 73)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 13)
        Me.Label28.TabIndex = 99
        Me.Label28.Text = "Rcvd"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 98
        '
        'LogCancelButton
        '
        Me.LogCancelButton.Location = New System.Drawing.Point(387, 213)
        Me.LogCancelButton.Name = "LogCancelButton"
        Me.LogCancelButton.Size = New System.Drawing.Size(72, 22)
        Me.LogCancelButton.TabIndex = 97
        Me.LogCancelButton.Text = "Cancel"
        Me.LogCancelButton.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(244, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 96
        Me.Label26.Text = "Band"
        '
        'LogBandTextBox
        '
        Me.LogBandTextBox.Location = New System.Drawing.Point(282, 46)
        Me.LogBandTextBox.Name = "LogBandTextBox"
        Me.LogBandTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogBandTextBox.TabIndex = 12
        '
        'LogOKButton
        '
        Me.LogOKButton.Location = New System.Drawing.Point(308, 212)
        Me.LogOKButton.Name = "LogOKButton"
        Me.LogOKButton.Size = New System.Drawing.Size(70, 23)
        Me.LogOKButton.TabIndex = 21
        Me.LogOKButton.Text = "OK"
        Me.LogOKButton.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(27, 177)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 13)
        Me.Label25.TabIndex = 92
        Me.Label25.Text = "Exchange"
        '
        'LogExchangeTextBox
        '
        Me.LogExchangeTextBox.Location = New System.Drawing.Point(92, 174)
        Me.LogExchangeTextBox.Name = "LogExchangeTextBox"
        Me.LogExchangeTextBox.Size = New System.Drawing.Size(367, 20)
        Me.LogExchangeTextBox.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(314, 146)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 13)
        Me.Label24.TabIndex = 90
        Me.Label24.Text = "condx"
        '
        'LogShowerTextBox
        '
        Me.LogShowerTextBox.Location = New System.Drawing.Point(369, 141)
        Me.LogShowerTextBox.Name = "LogShowerTextBox"
        Me.LogShowerTextBox.Size = New System.Drawing.Size(89, 20)
        Me.LogShowerTextBox.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(314, 119)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 13)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "QSO Elap Time"
        '
        'LogQsoTimeTextBox
        '
        Me.LogQsoTimeTextBox.Location = New System.Drawing.Point(402, 115)
        Me.LogQsoTimeTextBox.Name = "LogQsoTimeTextBox"
        Me.LogQsoTimeTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogQsoTimeTextBox.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(225, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "his Station"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(192, 146)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Antenna"
        '
        'LogHisAntennaTextBox
        '
        Me.LogHisAntennaTextBox.Location = New System.Drawing.Point(247, 141)
        Me.LogHisAntennaTextBox.Name = "LogHisAntennaTextBox"
        Me.LogHisAntennaTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogHisAntennaTextBox.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(192, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 13)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "Power"
        '
        'LogHisPowerTextBox
        '
        Me.LogHisPowerTextBox.Location = New System.Drawing.Point(247, 115)
        Me.LogHisPowerTextBox.Name = "LogHisPowerTextBox"
        Me.LogHisPowerTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogHisPowerTextBox.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(71, 97)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 13)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "my Station"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(38, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Antenna"
        '
        'LogAntennaTextBox
        '
        Me.LogAntennaTextBox.Location = New System.Drawing.Point(93, 141)
        Me.LogAntennaTextBox.Name = "LogAntennaTextBox"
        Me.LogAntennaTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogAntennaTextBox.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(38, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Power"
        '
        'LogPowerTextBox
        '
        Me.LogPowerTextBox.Location = New System.Drawing.Point(93, 115)
        Me.LogPowerTextBox.Name = "LogPowerTextBox"
        Me.LogPowerTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogPowerTextBox.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(366, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Distance"
        '
        'LogDistanceTextBox
        '
        Me.LogDistanceTextBox.Location = New System.Drawing.Point(421, 45)
        Me.LogDistanceTextBox.Name = "LogDistanceTextBox"
        Me.LogDistanceTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogDistanceTextBox.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(376, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Grid"
        '
        'LogGridTextBox
        '
        Me.LogGridTextBox.Location = New System.Drawing.Point(421, 71)
        Me.LogGridTextBox.Name = "LogGridTextBox"
        Me.LogGridTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogGridTextBox.TabIndex = 73
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(134, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Mode"
        '
        'LogModeTextBox
        '
        Me.LogModeTextBox.Location = New System.Drawing.Point(172, 45)
        Me.LogModeTextBox.Name = "LogModeTextBox"
        Me.LogModeTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogModeTextBox.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Sent"
        '
        'LogReportTextBox
        '
        Me.LogReportTextBox.Location = New System.Drawing.Point(72, 45)
        Me.LogReportTextBox.Name = "LogReportTextBox"
        Me.LogReportTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LogReportTextBox.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(334, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "UTC"
        '
        'LogUTCTextBox
        '
        Me.LogUTCTextBox.Location = New System.Drawing.Point(369, 19)
        Me.LogUTCTextBox.Name = "LogUTCTextBox"
        Me.LogUTCTextBox.Size = New System.Drawing.Size(84, 20)
        Me.LogUTCTextBox.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Date"
        '
        'LogDateTextBox
        '
        Me.LogDateTextBox.Location = New System.Drawing.Point(238, 18)
        Me.LogDateTextBox.Name = "LogDateTextBox"
        Me.LogDateTextBox.Size = New System.Drawing.Size(84, 20)
        Me.LogDateTextBox.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Callsign"
        '
        'LogCallsignTextBox
        '
        Me.LogCallsignTextBox.Location = New System.Drawing.Point(82, 18)
        Me.LogCallsignTextBox.Name = "LogCallsignTextBox"
        Me.LogCallsignTextBox.Size = New System.Drawing.Size(104, 20)
        Me.LogCallsignTextBox.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(216, 176)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 13)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "Country"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(265, 172)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(156, 20)
        Me.CountryTextBox.TabIndex = 30
        '
        'CallsignComboBox
        '
        Me.CallsignComboBox.FormattingEnabled = True
        Me.CallsignComboBox.Location = New System.Drawing.Point(111, 24)
        Me.CallsignComboBox.Name = "CallsignComboBox"
        Me.CallsignComboBox.Size = New System.Drawing.Size(173, 21)
        Me.CallsignComboBox.TabIndex = 31
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip2.TabIndex = 32
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'QRZButton
        '
        Me.QRZButton.Location = New System.Drawing.Point(434, 125)
        Me.QRZButton.Name = "QRZButton"
        Me.QRZButton.Size = New System.Drawing.Size(58, 22)
        Me.QRZButton.TabIndex = 33
        Me.QRZButton.Text = "QRZ"
        Me.QRZButton.UseVisualStyleBackColor = True
        '
        'Addr1TextBox
        '
        Me.Addr1TextBox.Location = New System.Drawing.Point(113, 114)
        Me.Addr1TextBox.Name = "Addr1TextBox"
        Me.Addr1TextBox.Size = New System.Drawing.Size(233, 20)
        Me.Addr1TextBox.TabIndex = 34
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(43, 114)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 35
        Me.Label29.Text = "Address"
        '
        'Addr2TextBox
        '
        Me.Addr2TextBox.Location = New System.Drawing.Point(112, 140)
        Me.Addr2TextBox.Name = "Addr2TextBox"
        Me.Addr2TextBox.Size = New System.Drawing.Size(235, 20)
        Me.Addr2TextBox.TabIndex = 36
        '
        'ApplyButton
        '
        Me.ApplyButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplyButton.Location = New System.Drawing.Point(345, 421)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(67, 23)
        Me.ApplyButton.TabIndex = 37
        Me.ApplyButton.Text = "Apply"
        '
        'StationDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 459)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.Addr2TextBox)
        Me.Controls.Add(Me.Addr1TextBox)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.QRZButton)
        Me.Controls.Add(Me.CallsignComboBox)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.LogQSOGroupBox)
        Me.Controls.Add(Me.StationTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.AzmuthTextBox)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(Me.LocatorTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LastPostLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StationDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StationDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.LogQSOGroupBox.ResumeLayout(False)
        Me.LogQSOGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LastPostLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocatorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AzmuthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LogQSOGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LogBandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogOKButton As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LogExchangeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LogShowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LogQsoTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LogHisAntennaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LogHisPowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LogAntennaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LogPowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LogDistanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LogGridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LogModeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LogReportTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LogUTCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LogDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LogCallsignTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogCancelButton As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CallsignComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents QRZButton As System.Windows.Forms.Button
    Friend WithEvents Addr1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Addr2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApplyButton As System.Windows.Forms.Button

End Class
