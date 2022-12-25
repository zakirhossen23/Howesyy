Public Class Loading

    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Prog_In_Timer.Start()
    End Sub
    Private Sub Prog_In_Timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Prog_In_Timer.Tick
        'Inrement by +1 in progressbar #1 (get it started) 
        ProgressBar1.Increment(+1)


        'Add percent towards the central label
        Label2.Text = "Loading... " + ProgressBar1.Value.ToString + "%"
        Dim r As IO.StreamReader


        'Self-setup and checkup
        If ProgressBar1.Value = "1" Then

            If My.Computer.FileSystem.DirectoryExists("C:\local\") Then
                'Check if returning user
            Else
                'If user is new, then create core directory folder
                My.Computer.FileSystem.CreateDirectory("C:\local\")
            End If

        End If

        'Make sure History and Bookmarks panels are loaded up for next ProgressCheck @ Value '10'
        If ProgressBar1.Value = "5" Then
            Mainpage.BrowserBTN.PerformClick()

            'Bookmarks.Show()
            'Bookmarks.Hide()

            'AdminBookmarks.Show()
            'AdminBookmarks.Hide()

        End If


        If ProgressBar1.Value = "100" Then
            Prog_In_Timer.Stop()

            Process.Start(Application.StartupPath & "\" & "Howeasyy 1.0.exe")
            ProgressBar1.Value = "0"
            Application.Exit()

        End If


    End Sub
End Class