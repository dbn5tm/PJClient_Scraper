<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Telnet
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
        Me.CallTextBox = New System.Windows.Forms.TextBox
        Me.MoonButton = New System.Windows.Forms.Button
        Me.SHDXButton = New System.Windows.Forms.Button
        Me.PostButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.CommentTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.FreqTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DXTextBox = New System.Windows.Forms.TextBox
        Me.cmdQuit = New System.Windows.Forms.Button
        Me.txtRecv = New System.Windows.Forms.TextBox
        Me.cmdSend = New System.Windows.Forms.Button
        Me.FilterComboBox = New System.Windows.Forms.ComboBox
        Me.TelNetURLComboBox = New System.Windows.Forms.ComboBox
        Me.AddDXClusterButton = New System.Windows.Forms.Button
        Me.DeleteURLButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CallTextBox
        '
        Me.CallTextBox.Location = New System.Drawing.Point(294, 44)
        Me.CallTextBox.Name = "CallTextBox"
        Me.CallTextBox.Size = New System.Drawing.Size(87, 20)
        Me.CallTextBox.TabIndex = 25
        '
        'MoonButton
        '
        Me.MoonButton.Location = New System.Drawing.Point(206, 40)
        Me.MoonButton.Name = "MoonButton"
        Me.MoonButton.Size = New System.Drawing.Size(70, 26)
        Me.MoonButton.TabIndex = 24
        Me.MoonButton.Text = "Moon"
        Me.MoonButton.UseVisualStyleBackColor = True
        '
        'SHDXButton
        '
        Me.SHDXButton.Location = New System.Drawing.Point(124, 40)
        Me.SHDXButton.Name = "SHDXButton"
        Me.SHDXButton.Size = New System.Drawing.Size(67, 26)
        Me.SHDXButton.TabIndex = 23
        Me.SHDXButton.Text = "Show DX"
        Me.SHDXButton.UseVisualStyleBackColor = True
        '
        'PostButton
        '
        Me.PostButton.Location = New System.Drawing.Point(485, 334)
        Me.PostButton.Name = "PostButton"
        Me.PostButton.Size = New System.Drawing.Size(43, 25)
        Me.PostButton.TabIndex = 22
        Me.PostButton.Text = "Post"
        Me.PostButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Comment"
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CommentTextBox.Location = New System.Drawing.Point(291, 333)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(180, 20)
        Me.CommentTextBox.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Freq"
        '
        'FreqTextBox
        '
        Me.FreqTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FreqTextBox.Location = New System.Drawing.Point(157, 333)
        Me.FreqTextBox.Name = "FreqTextBox"
        Me.FreqTextBox.Size = New System.Drawing.Size(68, 20)
        Me.FreqTextBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "DX"
        '
        'DXTextBox
        '
        Me.DXTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DXTextBox.Location = New System.Drawing.Point(44, 333)
        Me.DXTextBox.Name = "DXTextBox"
        Me.DXTextBox.Size = New System.Drawing.Size(74, 20)
        Me.DXTextBox.TabIndex = 16
        '
        'cmdQuit
        '
        Me.cmdQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdQuit.Location = New System.Drawing.Point(461, 40)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(67, 24)
        Me.cmdQuit.TabIndex = 15
        Me.cmdQuit.Text = "Quit"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'txtRecv
        '
        Me.txtRecv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecv.Location = New System.Drawing.Point(21, 73)
        Me.txtRecv.Multiline = True
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecv.Size = New System.Drawing.Size(518, 254)
        Me.txtRecv.TabIndex = 14
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(21, 40)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(74, 27)
        Me.cmdSend.TabIndex = 13
        Me.cmdSend.Text = "Connect"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'FilterComboBox
        '
        Me.FilterComboBox.AutoCompleteCustomSource.AddRange(New String() {"All", "VHF", "2m", "6m", "HF"})
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Items.AddRange(New Object() {"All", "VHF", "2m", "6m", "HF"})
        Me.FilterComboBox.Location = New System.Drawing.Point(387, 43)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(68, 21)
        Me.FilterComboBox.TabIndex = 26
        '
        'TelNetURLComboBox
        '
        Me.TelNetURLComboBox.FormattingEnabled = True
        Me.TelNetURLComboBox.Location = New System.Drawing.Point(21, 12)
        Me.TelNetURLComboBox.Name = "TelNetURLComboBox"
        Me.TelNetURLComboBox.Size = New System.Drawing.Size(152, 21)
        Me.TelNetURLComboBox.TabIndex = 27
        '
        'AddDXClusterButton
        '
        Me.AddDXClusterButton.Location = New System.Drawing.Point(179, 11)
        Me.AddDXClusterButton.Name = "AddDXClusterButton"
        Me.AddDXClusterButton.Size = New System.Drawing.Size(45, 20)
        Me.AddDXClusterButton.TabIndex = 28
        Me.AddDXClusterButton.Text = "Add"
        Me.AddDXClusterButton.UseVisualStyleBackColor = True
        '
        'DeleteURLButton
        '
        Me.DeleteURLButton.Location = New System.Drawing.Point(237, 11)
        Me.DeleteURLButton.Name = "DeleteURLButton"
        Me.DeleteURLButton.Size = New System.Drawing.Size(57, 20)
        Me.DeleteURLButton.TabIndex = 29
        Me.DeleteURLButton.Text = "Delete"
        Me.DeleteURLButton.UseVisualStyleBackColor = True
        '
        'Telnet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 371)
        Me.Controls.Add(Me.DeleteURLButton)
        Me.Controls.Add(Me.AddDXClusterButton)
        Me.Controls.Add(Me.TelNetURLComboBox)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.CallTextBox)
        Me.Controls.Add(Me.MoonButton)
        Me.Controls.Add(Me.SHDXButton)
        Me.Controls.Add(Me.PostButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FreqTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DXTextBox)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.txtRecv)
        Me.Controls.Add(Me.cmdSend)
        Me.Name = "Telnet"
        Me.Text = "DX Cluster"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MoonButton As System.Windows.Forms.Button
    Friend WithEvents SHDXButton As System.Windows.Forms.Button
    Friend WithEvents PostButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FreqTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmdQuit As System.Windows.Forms.Button
    Friend WithEvents txtRecv As System.Windows.Forms.TextBox
    Friend WithEvents cmdSend As System.Windows.Forms.Button
    Friend WithEvents FilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TelNetURLComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddDXClusterButton As System.Windows.Forms.Button
    Friend WithEvents DeleteURLButton As System.Windows.Forms.Button
End Class
