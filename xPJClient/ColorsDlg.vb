Imports System.Windows.Forms

Public Class ColorsDlg
    Public Event NewColors(ByVal call_colors As ArrayList, ByVal text_color As Color, ByVal back_color As Color)

    Private m_callsign_colors As ArrayList
    Public Property callsign_colors() As ArrayList
        Get
            Return m_callsign_colors
        End Get
        Set(ByVal value As ArrayList)
            m_callsign_colors = value
        End Set
    End Property

    Private m_background_color As Color
    Public Property background_color() As Color
        Get
            Return m_background_color
        End Get
        Set(ByVal value As Color)
            m_background_color = value
            Me.BackgroundColorPictureBox.BackColor = value
        End Set
    End Property

    Private m_text_color As Color
    Public Property text_color() As Color
        Get
            Return m_text_color
        End Get
        Set(ByVal value As Color)
            m_text_color = value
            Me.TextColorPictureBox.BackColor = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        RaiseEvent NewColors(m_callsign_colors, m_text_color, m_background_color)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ColorsDlg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SetCallsignColors()
    End Sub

    Private Sub SetCallsignColors()
        Dim ctrls As Control

        For Each ctrls In Me.CallsignColorGroupBox.Controls
            If TypeOf ctrls Is PictureBox Then
                If Me.callsign_colors.Count > ctrls.Tag Then
                    ctrls.BackColor = Me.callsign_colors.Item(ctrls.Tag)
                End If

            End If

        Next

    End Sub

    Private Sub Callsign1PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Callsign1PictureBox.Click, Callsign2PictureBox.Click, _
    Callsign3PictureBox.Click, Callsign4PictureBox.Click, Callsign5PictureBox.Click, Callsign6PictureBox.Click, Callsign7PictureBox.Click, Callsign8PictureBox.Click, _
    Callsign9PictureBox.Click, Callsign10PictureBox.Click, Callsign11PictureBox.Click, Callsign12PictureBox.Click
        ColorDialog1.ShowDialog()
        sender.BackColor = Me.ColorDialog1.Color
        m_callsign_colors.Item(sender.tag) = sender.backcolor


    End Sub

    Private Sub TextColorPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextColorPictureBox.Click
        ColorDialog1.ShowDialog()
        sender.BackColor = Me.ColorDialog1.Color
        m_text_color = sender.backcolor

    End Sub

    Private Sub BackgroundColorPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorPictureBox.Click
        ColorDialog1.ShowDialog()
        sender.BackColor = Me.ColorDialog1.Color
        m_background_color = sender.backcolor
    End Sub
End Class
