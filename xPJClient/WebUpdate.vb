
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Class WebUpdate
    'Dim version As String
    Public Shared Downuri As String
    Public Sub New(ByVal thisVer As Integer, ByVal stealth As Boolean)
        Dim URI As String
        Dim version As Integer
        Dim verpage As String
        Dim r As New Regex("\d\d\d\d")
        '
        'REPLACE Program WITH YOUR APPLICATIONS NAME.
        '
        'REMEMBER TO EDIT FILEVERSION IN ASSEMBLY INFORMATION
        '
        '
        'Edit URI to your version.html-file. 
        URI = "http://chat.n5tm.com/downloads/PJClient_version.html"
        'Edit URI to your programs zip-file
        Downuri = "http://chat.n5tm.com/downloads/PJClientInstaller.msi"
        Using client As New WebClient
            ' Set one of the headers.
            client.Headers("User-Agent") = "Mozilla/4.0"
            Try
                verpage = client.DownloadString(URI)
                Dim r_str = r.Match(verpage)
                version = r_str.Value
                'Dim str As String = client.DownloadString("http://www.pingjockey.net/cgi-bin/pingtalk/")
                'RaiseEvent PageRcvd(str)
                'dTimer.Enabled = True
            Catch ex As Exception
                'RaiseEvent ClientError(ex.ToString())
                'dTimer.Enabled = True
            End Try
        End Using

        If version > thisVer Then
            UpdatePJCDialog.ShowDialog()
        Else
            If Not stealth Then
                MessageBox.Show("Latest Version Installed.", "Update", MessageBoxButtons.OK)
            End If

        End If
    End Sub
End Class 'Web_update

