Imports CefSharp
Imports CefSharp.WinForms
Imports DevComponents.DotNetBar
Imports System.Net
Imports System.IO
Public Class AdminHome
    Private WithEvents Browser As ChromiumWebBrowser

    'Dim w As IO.StreamWriter

    Public Sub New()
        InitializeComponent()
    End Sub
    Dim chromes As ChromiumWebBrowser
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ChromiumWebBrowser.BrowserNotInitializedExceptionErrorMessage
        Try
            Using setting As New CefSettings
                setting.RemoteDebuggingPort = 8088
                CefSharp.Cef.Initialize(setting)
            End Using

        Catch ex As Exception

        End Try
        Try
            Dim settings As CefSettings = New CefSettings()
            Dim chromes As New ChromiumWebBrowser("https://test.howeasyyweb.com/SearchAdministrator/index.php") With {
                .Parent = TabControl1.SelectedTab.AttachedControl,
                .Dock = DockStyle.Fill
            }
            AddHandler chromes.AddressChanged, AddressOf Chrome_AddressChanged
            AddHandler chromes.TitleChanged, AddressOf Chromes_tiltlechanged
            chromes.Load("https://test.howeasyyweb.com/SearchAdministrator/index.php")
            'AddHandler chromes.FrameLoadStart, AddressOf BrowserOnFrameLoadStart
            'AddHandler chromes.FrameLoadEnd, AddressOf BrowserOnFrameLoadEnd
            TabControl1.SelectedTab.Text = "New Tab"
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub BrowserOnFrameLoadEnd(ByVal sender As Object, ByVal e As FrameLoadEndEventArgs)
    '    Try
    '        ProgressBar1.Invoke(
    '                  Sub()
    '                      ProgressBar1.Style = ProgressBarStyle.Blocks
    '                      ProgressBar1.Refresh()
    '                  End Sub
    '                  )
    '    Catch ex As Exception

    '    End Try


    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Browser.Load(TextBox1.Text)
        'Label1.Text = "loading"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Back()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Forward()
        Catch ex As Exception

        End Try

    End Sub



    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs)

        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Load("https://www.google.com/search?q=" + TextBox1.Text)
            ''Label1.Text = "loading"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Load(TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub AddToBookmarksToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToBookmarksToolStripMenuItem.Click
    '    If ProgressBar1.Value = 0 Then

    '        If TextBox1.Text.Contains("http") = True Then
    '            AddBookmark.Show()
    '            AddBookmark.TopMost = True

    '        Else
    '        End If
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub ViewBookmarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddToBookmarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Try
        '    Dim setting As New CefSettings
        '    setting.RemoteDebuggingPort = 8088
        '    CefSharp.Cef.Initialize(setting)

        'Catch ex As Exception

        'End Try

        'Dim settings As CefSettings = New CefSettings()
        'Dim chromes As ChromiumWebBrowser = New ChromiumWebBrowser("https://test.howeasyyweb.com/SearchAdministrator/index.php/")
        'chromes.Parent = TabControl1.SelectedTab.AttachedControl
        'chromes.Dock = DockStyle.Fill
        'AddHandler chromes.AddressChanged, AddressOf Chrome_AddressChanged
        'AddHandler chromes.TitleChanged, AddressOf chromes_tiltlechanged
        'chromes.Load("https://test.howeasyyweb.com/SearchAdministrator/index.php")
        ''AddHandler chromes.FrameLoadStart, AddressOf BrowserOnFrameLoadStart
        ''AddHandler chromes.FrameLoadEnd, AddressOf BrowserOnFrameLoadEnd
        'TabControl1.SelectedTab.Text = "New Tab"
        Try
            Dim newtab As TabItem = TabControl1.CreateTab("New Tab")

            Dim panel As TabControlPanel = DirectCast(newtab.AttachedControl, TabControlPanel)
            Dim chromes1 As New ChromiumWebBrowser("https://test.howeasyyweb.com/SearchAdministrator/index.php/") With {
                .Dock = DockStyle.Fill
            }
            panel.Controls.Add(chromes1)
            TabControl1.SelectedTab = newtab
            CType(TabControl1.SelectedTab.AttachedControl.Controls.Item(0), ChromiumWebBrowser).Load("https://test.howeasyyweb.com/SearchAdministrator/index.php/")

            TextBox1.Text = "https://test.howeasyyweb.com/SearchAdministrator/index.php"
            AddHandler chromes1.AddressChanged, AddressOf Chrome_AddressChanged
            AddHandler chromes1.TitleChanged, AddressOf Chromes_tiltlechanged
            TabControl1.SelectedTab.Text = "New Tab"
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Function Favicon(ByVal u As String, ByVal file As String) As Image

        Dim url As Uri = New Uri(u)
        Dim iconurl As String = "http://" & url.Host & "/favicon.ico"
        Dim request As WebRequest = WebRequest.Create(iconurl)

        Try
            Dim response As WebResponse = request.GetResponse()
            Dim s As Stream = response.GetResponseStream()
            Return Image.FromStream(s)
        Catch ex As Exception
            'Return Image.FromFile(file)
            'MsgBox(ex.Message)
        End Try


    End Function
    Private Sub Chrome_AddressChanged(ByVal sender As Object, ByVal e As AddressChangedEventArgs)
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            Me.Invoke(New MethodInvoker(Sub()
                                            TextBox1.Text = chromes.Address
                                        End Sub))
            img.Image = Favicon(chromes.Address, "net.png")
            img.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception

        End Try


    End Sub
    Private Sub Chromes_tiltlechanged(ByVal sender As Object, ByVal e As TitleChangedEventArgs)
        Try
            If TextBox1.Text.Contains("https://test.howeasyyweb.com/SearchAdministrator/index.php/") Then
                Exit Sub
                TabControl1.SelectedTab.Text = "New Tab"

            Else
                Me.Invoke(New MethodInvoker(Sub()
                                                TabControl1.SelectedTab.Text = e.Title
                                            End Sub))
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Private Sub TabControl1_SelectedTabChanging(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangingEventArgs) Handles TabControl1.SelectedTabChanging
    '    TextBox1.Text = chromes.Address
    'End Sub

    Private Sub TabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControl1.SelectedTabChanged
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            'If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)


            TextBox1.Text = chromes.Address
            Try
                img.Image = Favicon(chromes.Address, "net.png")
                img.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            'AddHandler chromes.AddressChanged, AddressOf Chrome_AddressChangedTab
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Back()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Forward()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        TabControl1.ResumeLayout()
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Load("https://www.google.com/search?q=" + TextBox1.Text)
            ''Label1.Text = "loading"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            chromes = TryCast(TabControl1.SelectedTab.AttachedControl.Controls(0), ChromiumWebBrowser)
            If chromes IsNot Nothing Then chromes.Load(TextBox1.Text)

            chromes.Load(TextBox1.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel3.Left -= 10
        'Panel3.Left += 15

    End Sub
    Private Sub BrowserOnFrameLoadStart(ByVal sender As Object, ByVal e As FrameLoadStartEventArgs)
        Try
            ProgressBar1.Invoke(
                  Sub()
                      ProgressBar1.Style = ProgressBarStyle.Marquee
                      ProgressBar1.Refresh()
                  End Sub
                  )
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Panel3_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.LocationChanged
        If Panel3.Right = 10 Then
            Panel3.Left = 400
        Else

        End If

    End Sub

    'Private Sub Browser_Newtab(ByVal sender As Object, ByVal e As NativeWindow)
    '    Try
    '        Dim newtab As TabItem = TabControl1.CreateTab("New Tab")

    '        Dim panel As TabControlPanel = DirectCast(newtab.AttachedControl, TabControlPanel)
    '        Dim chromes1 As ChromiumWebBrowser = New ChromiumWebBrowser("https://test.howeasyyweb.com/SearchAdministrator/index.php")
    '        chromes1.Dock = DockStyle.Fill
    '        panel.Controls.Add(chromes1)
    '        TabControl1.SelectedTab = newtab
    '        CType(TabControl1.SelectedTab.AttachedControl.Controls.Item(0), ChromiumWebBrowser).Load("https://test.howeasyyweb.com/SearchAdministrator/index.php")

    '        TextBox1.Text = "https://test.howeasyyweb.com/SearchAdministrator/index.php"
    '        AddHandler chromes1.AddressChanged, AddressOf Chrome_AddressChanged
    '        AddHandler chromes1.TitleChanged, AddressOf chromes_tiltlechanged
    '        AddHandler chromes.FrameLoadStart, AddressOf BrowserOnFrameLoadStart
    '        AddHandler chromes.FrameLoadEnd, AddressOf BrowserOnFrameLoadEnd
    '        TabControl1.SelectedTab.Text = "New Tab"
    '    Catch ex As Exception

    '    End Try

    'End Sub
    Private Sub BrowserOnFrameLoadEnd(ByVal sender As Object, ByVal e As FrameLoadEndEventArgs)
        Try
            ProgressBar1.Invoke(
                      Sub()
                          ProgressBar1.Style = ProgressBarStyle.Blocks
                          ProgressBar1.Refresh()
                      End Sub
                      )

        Catch ex As Exception

        End Try

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class