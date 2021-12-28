<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoDialog
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
        Me.components = New System.ComponentModel.Container
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.NicknameTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GridTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.emailTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CallsignTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.WSJTLogTextBox = New System.Windows.Forms.TextBox
        Me.BrowseWSJTLogButton = New System.Windows.Forms.Button
        Me.MyOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.LogPathMessageLabel = New System.Windows.Forms.Label
        Me.MyFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.UseWSJTLogCheckBox = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NickName2TextBox = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.KmRadioButton = New System.Windows.Forms.RadioButton
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.QRZLoginTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.QRZPwdTextBox = New System.Windows.Forms.TextBox
        Me.DXClusterComboBox = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.BrowseCall3WSJTButton = New System.Windows.Forms.Button
        Me.Call3WSJTTextBox = New System.Windows.Forms.TextBox
        Me.BrowseCall3MAP65Button = New System.Windows.Forms.Button
        Me.Call3MAP65TextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(312, 456)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 23
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 24
        Me.Cancel_Button.Text = "Cancel"
        '
        'NicknameTextBox
        '
        Me.NicknameTextBox.Location = New System.Drawing.Point(137, 44)
        Me.NicknameTextBox.Name = "NicknameTextBox"
        Me.NicknameTextBox.Size = New System.Drawing.Size(173, 20)
        Me.NicknameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NicknameTextBox, "Your callsign as it appears on Ping Jockey")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JT65 EME Callsign"
        Me.ToolTip1.SetToolTip(Me.Label1, "{call}/ant/pwr")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "State"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(137, 122)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(40, 20)
        Me.StateTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grid"
        '
        'GridTextBox
        '
        Me.GridTextBox.Location = New System.Drawing.Point(137, 148)
        Me.GridTextBox.Name = "GridTextBox"
        Me.GridTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GridTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Firstname"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(137, 96)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(127, 20)
        Me.FirstnameTextBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "email"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(137, 174)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(232, 20)
        Me.emailTextBox.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Callsign"
        Me.ToolTip1.SetToolTip(Me.Label6, "{call only}")
        '
        'CallsignTextBox
        '
        Me.CallsignTextBox.Location = New System.Drawing.Point(137, 70)
        Me.CallsignTextBox.Name = "CallsignTextBox"
        Me.CallsignTextBox.Size = New System.Drawing.Size(127, 20)
        Me.CallsignTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CallsignTextBox, "callsgn w/o modifiers")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "WSJT Path"
        '
        'WSJTLogTextBox
        '
        Me.WSJTLogTextBox.Location = New System.Drawing.Point(78, 314)
        Me.WSJTLogTextBox.Name = "WSJTLogTextBox"
        Me.WSJTLogTextBox.Size = New System.Drawing.Size(232, 20)
        Me.WSJTLogTextBox.TabIndex = 9
        '
        'BrowseWSJTLogButton
        '
        Me.BrowseWSJTLogButton.Location = New System.Drawing.Point(327, 313)
        Me.BrowseWSJTLogButton.Name = "BrowseWSJTLogButton"
        Me.BrowseWSJTLogButton.Size = New System.Drawing.Size(62, 20)
        Me.BrowseWSJTLogButton.TabIndex = 10
        Me.BrowseWSJTLogButton.Text = "Browse ..."
        Me.BrowseWSJTLogButton.UseVisualStyleBackColor = True
        '
        'MyOpenFileDialog
        '
        Me.MyOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'LogPathMessageLabel
        '
        Me.LogPathMessageLabel.AutoSize = True
        Me.LogPathMessageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogPathMessageLabel.Location = New System.Drawing.Point(135, 337)
        Me.LogPathMessageLabel.Name = "LogPathMessageLabel"
        Me.LogPathMessageLabel.Size = New System.Drawing.Size(194, 13)
        Me.LogPathMessageLabel.TabIndex = 16
        Me.LogPathMessageLabel.Text = "Restart necessary if Log Path changed."
        Me.LogPathMessageLabel.Visible = False
        '
        'UseWSJTLogCheckBox
        '
        Me.UseWSJTLogCheckBox.AutoSize = True
        Me.UseWSJTLogCheckBox.Location = New System.Drawing.Point(78, 278)
        Me.UseWSJTLogCheckBox.Name = "UseWSJTLogCheckBox"
        Me.UseWSJTLogCheckBox.Size = New System.Drawing.Size(99, 17)
        Me.UseWSJTLogCheckBox.TabIndex = 8
        Me.UseWSJTLogCheckBox.Text = "Use WSJT Log"
        Me.ToolTip1.SetToolTip(Me.UseWSJTLogCheckBox, "Check box if you want to load WSJT.log")
        Me.UseWSJTLogCheckBox.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'NickName2TextBox
        '
        Me.NickName2TextBox.Location = New System.Drawing.Point(138, 18)
        Me.NickName2TextBox.Name = "NickName2TextBox"
        Me.NickName2TextBox.Size = New System.Drawing.Size(172, 20)
        Me.NickName2TextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NickName2TextBox, "Your callsign as it appears on  JT65 EME 1 or 2")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(61, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "PJ Callsign"
        Me.ToolTip1.SetToolTip(Me.Label17, "{call}/bands/pwr")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.KmRadioButton)
        Me.GroupBox4.Controls.Add(Me.MilesRadioButton)
        Me.GroupBox4.Location = New System.Drawing.Point(385, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(101, 78)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Distance Units"
        '
        'KmRadioButton
        '
        Me.KmRadioButton.AutoSize = True
        Me.KmRadioButton.Location = New System.Drawing.Point(18, 42)
        Me.KmRadioButton.Name = "KmRadioButton"
        Me.KmRadioButton.Size = New System.Drawing.Size(40, 17)
        Me.KmRadioButton.TabIndex = 12
        Me.KmRadioButton.TabStop = True
        Me.KmRadioButton.Text = "Km"
        Me.KmRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(18, 19)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MilesRadioButton.TabIndex = 11
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Country"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(253, 122)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(122, 20)
        Me.CountryTextBox.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "QRZ Login"
        '
        'QRZLoginTextBox
        '
        Me.QRZLoginTextBox.Location = New System.Drawing.Point(136, 209)
        Me.QRZLoginTextBox.Name = "QRZLoginTextBox"
        Me.QRZLoginTextBox.Size = New System.Drawing.Size(81, 20)
        Me.QRZLoginTextBox.TabIndex = 36
        Me.QRZLoginTextBox.Text = "future"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(239, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "QRZ Password"
        '
        'QRZPwdTextBox
        '
        Me.QRZPwdTextBox.Location = New System.Drawing.Point(326, 209)
        Me.QRZPwdTextBox.Name = "QRZPwdTextBox"
        Me.QRZPwdTextBox.Size = New System.Drawing.Size(87, 20)
        Me.QRZPwdTextBox.TabIndex = 38
        Me.QRZPwdTextBox.Text = "future"
        '
        'DXClusterComboBox
        '
        Me.DXClusterComboBox.FormattingEnabled = True
        Me.DXClusterComboBox.Location = New System.Drawing.Point(137, 238)
        Me.DXClusterComboBox.Name = "DXClusterComboBox"
        Me.DXClusterComboBox.Size = New System.Drawing.Size(192, 21)
        Me.DXClusterComboBox.TabIndex = 39
        Me.DXClusterComboBox.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "DX Cluster"
        Me.Label11.Visible = False
        '
        'BrowseCall3WSJTButton
        '
        Me.BrowseCall3WSJTButton.Location = New System.Drawing.Point(327, 376)
        Me.BrowseCall3WSJTButton.Name = "BrowseCall3WSJTButton"
        Me.BrowseCall3WSJTButton.Size = New System.Drawing.Size(62, 20)
        Me.BrowseCall3WSJTButton.TabIndex = 42
        Me.BrowseCall3WSJTButton.Text = "Browse ..."
        Me.BrowseCall3WSJTButton.UseVisualStyleBackColor = True
        '
        'Call3WSJTTextBox
        '
        Me.Call3WSJTTextBox.Location = New System.Drawing.Point(78, 377)
        Me.Call3WSJTTextBox.Name = "Call3WSJTTextBox"
        Me.Call3WSJTTextBox.Size = New System.Drawing.Size(232, 20)
        Me.Call3WSJTTextBox.TabIndex = 41
        '
        'BrowseCall3MAP65Button
        '
        Me.BrowseCall3MAP65Button.Location = New System.Drawing.Point(327, 416)
        Me.BrowseCall3MAP65Button.Name = "BrowseCall3MAP65Button"
        Me.BrowseCall3MAP65Button.Size = New System.Drawing.Size(62, 20)
        Me.BrowseCall3MAP65Button.TabIndex = 44
        Me.BrowseCall3MAP65Button.Text = "Browse ..."
        Me.BrowseCall3MAP65Button.UseVisualStyleBackColor = True
        '
        'Call3MAP65TextBox
        '
        Me.Call3MAP65TextBox.Location = New System.Drawing.Point(78, 417)
        Me.Call3MAP65TextBox.Name = "Call3MAP65TextBox"
        Me.Call3MAP65TextBox.Size = New System.Drawing.Size(232, 20)
        Me.Call3MAP65TextBox.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(81, 361)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Call3.txt WSJT Path"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(81, 400)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Call3.txt MAP65 Path"
        '
        'InfoDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(509, 497)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BrowseCall3MAP65Button)
        Me.Controls.Add(Me.Call3MAP65TextBox)
        Me.Controls.Add(Me.BrowseCall3WSJTButton)
        Me.Controls.Add(Me.Call3WSJTTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DXClusterComboBox)
        Me.Controls.Add(Me.QRZPwdTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.QRZLoginTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NickName2TextBox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.UseWSJTLogCheckBox)
        Me.Controls.Add(Me.LogPathMessageLabel)
        Me.Controls.Add(Me.BrowseWSJTLogButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.WSJTLogTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CallsignTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GridTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NicknameTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InfoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InfoDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents NicknameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CallsignTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WSJTLogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowseWSJTLogButton As System.Windows.Forms.Button
    Friend WithEvents MyOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LogPathMessageLabel As System.Windows.Forms.Label
    Friend WithEvents MyFolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents UseWSJTLogCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents KmRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MilesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NickName2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents QRZLoginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents QRZPwdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DXClusterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BrowseCall3WSJTButton As System.Windows.Forms.Button
    Friend WithEvents Call3WSJTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowseCall3MAP65Button As System.Windows.Forms.Button
    Friend WithEvents Call3MAP65TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
