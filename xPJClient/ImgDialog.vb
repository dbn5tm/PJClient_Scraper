Imports System.Windows.Forms

Public Class ImgDialog

    Private m_fspec As String
    Public Property fspec() As String
        Get
            Return m_fspec
        End Get
        Set(ByVal value As String)
            m_fspec = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ImgDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim bm As New Bitmap(m_fspec)

        ImgPictureBox.Image = bm
    End Sub
End Class
