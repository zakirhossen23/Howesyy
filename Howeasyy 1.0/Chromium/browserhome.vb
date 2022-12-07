Imports CefSharp
Imports CefSharp.WinForms
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Public Class browserhome
    Friend Shared StartUrl As String = ""
    Friend remembershortcut As String
    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                searchtransition.HideSync(Guna2Panel1)

                ChromiumWebBrowser1.Load("https://www.google.com/search?q=" + Guna2TextBox1.Text)
            Catch ex As Exception
            End Try

            Try
                ButtonX5.Tooltip = "Stop"
                Me.ButtonX5.Symbol = "57676"
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub ChromiumWebBrowser1_AddressChanged(sender As Object, e As CefSharp.AddressChangedEventArgs) Handles ChromiumWebBrowser1.AddressChanged

        Try

            Invoke(New MethodInvoker(Sub()
                                         TextBox1.Text = e.Address
                                     End Sub))

        Catch ex As Exception

        End Try


    End Sub

    Private Sub ChromiumWebBrowser1_TitleChanged(sender As Object, e As TitleChangedEventArgs) Handles ChromiumWebBrowser1.TitleChanged
        Try

            Invoke(New MethodInvoker(Sub()
                                         Home.TabControl1.SelectedTab.Text = e.Title
                                     End Sub))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles BackBTN.Click

        Try
            searchtransition.HideSync(Guna2Panel1)
        Catch ex As Exception

        End Try
        Try

            ChromiumWebBrowser1.Back()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ForwardBTN.Click

        Try
            searchtransition.HideSync(Guna2Panel1)
        Catch ex As Exception

        End Try
        Try

            ChromiumWebBrowser1.Forward()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Try
            searchtransition.HideSync(Guna2Panel1)
        Catch ex As Exception

        End Try
        ChromiumWebBrowser1.Load(TextBox1.Text)
        Status.AddStatus("Browser - Go Button - " + TextBox1.Text)
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles SearchBTN.Click

        Try
            searchtransition.HideSync(Guna2Panel1)
        Catch ex As Exception

        End Try
        Try

            ChromiumWebBrowser1.Load("https://www.google.com/search?q=" + TextBox1.Text)

        Catch ex As Exception

        End Try
        Try
            ButtonX5.Tooltip = "Stop"
            Me.ButtonX5.Symbol = "57676"

        Catch ex As Exception

        End Try
    End Sub
    Private isSHowedHome As Boolean = False

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles HomeBTN.Click
        If (isSHowedHome = False) Then
            Guna2Panel1.BringToFront()
            searchtransition.ShowSync(Guna2Panel1)
            isSHowedHome = True
        Else
            searchtransition.HideSync(Guna2Panel1)
            isSHowedHome = False
        End If
    End Sub

    Private Sub ButtonX5_Click(sender As Object, e As EventArgs) Handles ButtonX5.Click
        If ButtonX5.Tooltip = "Reload" Then
            Try
                searchtransition.HideSync(Guna2Panel1)
            Catch ex As Exception

            End Try

            Try
                ChromiumWebBrowser1.Reload

            Catch ex As Exception

            End Try
        Else
            Try
                searchtransition.HideSync(Guna2Panel1)
            Catch ex As Exception

            End Try

            Try
                Try

                    Invoke(New MethodInvoker(Sub()
                                                 ChromiumWebBrowser1.Stop
                                             End Sub))

                Catch ex As Exception

                End Try

            Catch ex As Exception

            End Try
        End If

    End Sub

    Public Shared Function favicon(ByVal u As String, ByVal file As String) As Image


        Dim url As Uri = New Uri(u)
        Dim iconurl As String = "http://" & url.Host & "/favicon.ico"
        Dim request As WebRequest = WebRequest.Create(iconurl)

        Try
            Dim response As WebResponse = request.GetResponse()
            Dim s As Stream = response.GetResponseStream()
            Return Image.FromStream(s)
        Catch ex As Exception
            Return Image.FromFile(file)

        End Try



    End Function
    Private Sub ChromiumWebBrowser1_FrameLoadStart(sender As Object, eh As FrameLoadStartEventArgs) Handles ChromiumWebBrowser1.FrameLoadStart
        Try
            ButtonX5.Tooltip = "Stop"
            Me.ButtonX5.Symbol = "57676"
            img.Image = My.Resources.interneticon
            Dim e As TitleChangedEventArgs = Nothing
            Call ChromiumWebBrowser1_TitleChanged(sender, e)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ChromiumWebBrowser1_FrameLoadEnd(sender As Object, e As FrameLoadEndEventArgs) Handles ChromiumWebBrowser1.FrameLoadEnd
        Try
            img.Image = favicon(ChromiumWebBrowser1.Address, "net.png")
            img.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
        End Try

        Try
            Me.ButtonX5.Symbol = "58837"
            ButtonX5.Tooltip = "Reload"
        Catch ex As Exception
        End Try


    End Sub

    Private Sub AddToBookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If TextBox1.Text.Contains("http") = True Then
            MsgBox("Configuring")

        Else
        End If
    End Sub

    Private Sub ViewBookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If TextBox1.Text.Contains("http") = True Then
            MsgBox("Configuring")

        Else
        End If
    End Sub


    Private Sub Shortcut7_ShortcutClick(sender As Object, e As EventArgs) Handles Shortcut_8_.ShortcutClick, Shortcut_7_.ShortcutClick, Shortcut_6_.ShortcutClick, Shortcut_5_.ShortcutClick, Shortcut_4_.ShortcutClick, Shortcut_3_.ShortcutClick, Shortcut_2_.ShortcutClick, Shortcut_1_.ShortcutClick

        TextBox1.Text = sender.urltext
        GoBTN.PerformClick()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        addshortcut.Guna2HtmlLabel1.Text = "Add Shortcut"
        If My.Settings.browserlink1 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 0
            addshortcut.ShowDialog(Me)
            Exit Sub
        ElseIf My.Settings.browserlink2 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 1
            addshortcut.ShowDialog(Me)
            Exit Sub
        ElseIf My.Settings.browserlink3 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 2
            addshortcut.ShowDialog(Me)
            Exit Sub
        ElseIf My.Settings.browserlink4 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 3
            addshortcut.ShowDialog(Me)
            Exit Sub
        ElseIf My.Settings.browserlink5 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 4
            addshortcut.ShowDialog(Me)
            Exit Sub
        ElseIf My.Settings.browserlink6 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 5
            addshortcut.ShowDialog(Me)
            Exit Sub
        ElseIf My.Settings.browserlink7 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 6
            addshortcut.ShowDialog(Me)
            Exit Sub
        ElseIf My.Settings.browserlink8 = "" Then
            addshortcut.ComboBox1.SelectedIndex = 7
            addshortcut.ShowDialog(Me)
            Exit Sub
        End If
    End Sub

    Dim statusrefresh As String = "finished"
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If statusrefresh = "finished" Then
            statusrefresh = "starting"
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub

    Private Sub refreshing()
        Shortcut_1_.Refreshbtn_Click()
        Shortcut_2_.Refreshbtn_Click()
        Shortcut_3_.Refreshbtn_Click()
        Shortcut_4_.Refreshbtn_Click()
        Shortcut_5_.Refreshbtn_Click()
        Shortcut_6_.Refreshbtn_Click()
        Shortcut_7_.Refreshbtn_Click()
        Shortcut_8_.Refreshbtn_Click()
        Try
            BackgroundWorker1.CancelAsync()
        Catch ex As Exception

        End Try
        statusrefresh = "finished"
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        refreshing()

    End Sub
    Public Function IsUrlValid(webUrl As String)
        If (webUrl = "") Then Return False
        If (webUrl.Contains(".") And Not webUrl.Contains(" ")) Then
            Return True
        End If
        Return False
    End Function

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If (e.KeyCode = 13) Then
            If (IsUrlValid(TextBox1.Text)) Then
                GoBTN.PerformClick()
            Else
                SearchBTN.PerformClick()
            End If
            sender.focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(13)) Then
            e.Handled = True
        End If
    End Sub
End Class
