Imports System.Net
Public Class Downloadpage
 
    Private Sub Downloadpage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Loading..."
        'Guna2ProgressBar1.Value = 0
        Button1.Enabled = False
        wc = New WebClient()
        'TextBox3.Text = Downloadlink.Text
        'TextBox4.Text = Savefile.Text
        Button2.PerformClick()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Close()
        Freeinterface.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim users = Environment.UserName
        Dim saves As String = "c:\Users\" & users & "\Downloads\" & Filename.Text
        Try
            System.Diagnostics.Process.Start(saves)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Public WithEvents downloadd As WebClient
    Dim wc As WebClient
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox3.Text = Downloadlink.Text
        TextBox4.Text = Savefile.Text

        downloadd = New WebClient
        'Dim download As String = Me.Downloadlink.Text
        ''Dim user = Environment.UserName
        'Dim saved As String = Savefile.Text


        downloadd.DownloadFileAsync(New Uri(TextBox3.Text), TextBox4.Text)
     
        Button1.Enabled = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub download_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloadd.DownloadFileCompleted
        Button1.Enabled = True
    End Sub

    Private Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles downloadd.DownloadProgressChanged
        'Label1.Text = e.ProgressPercentage.ToString() + "Downloading"
        Label1.Text = String.Format("{0} MB Downloaded", (e.BytesReceived / 1024D / 1024D).ToString("0.00"))
    End Sub

End Class