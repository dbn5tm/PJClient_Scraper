Imports System.Windows.Forms

Public Class UpdatePJCDialog
    Dim Client As New Net.WebClient()
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    'Download file from web. 	
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        'Download file from web to Temp-directory and run.

        'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Client.DownloadFile(WebUpdate.Downuri, _
        My.Computer.FileSystem.SpecialDirectories.Temp.ToString & "\PJClient_Update.msi")

        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp.ToString & _
        "\PJClient_Update.msi")
        Application.Exit()
    End Sub

    Private Sub DownloadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadButton.Click
        Dim DR As DialogResult = FolderBrowserDialog1.ShowDialog
        If DR = Windows.Forms.DialogResult.OK Then
            Client.DownloadFile(WebUpdate.Downuri, _
            FolderBrowserDialog1.SelectedPath.ToString & _
            "\PJClientInstaller_" & Date.Today.ToShortDateString.ToString & ".msi")
        End If
        Me.Close()
    End Sub
End Class
