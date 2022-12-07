
Imports DevComponents.DotNetBar
Imports System.Net
Imports System.IO
Public Class TabNoramBrowser

    Private Sub Guna2TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Guna2TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Guna2TextBox1.Text.Contains(".com") Then
                AxWebBrowser1.Navigate(Guna2TextBox1.Text)

            ElseIf Guna2TextBox1.Text.Contains(".net") Then
                AxWebBrowser1.Navigate(Guna2TextBox1.Text)

            ElseIf Guna2TextBox1.Text.Contains("www") Then
                AxWebBrowser1.Navigate(Guna2TextBox1.Text)

            ElseIf Guna2TextBox1.Text.Contains("https://") Then
                AxWebBrowser1.Navigate(Guna2TextBox1.Text)
            Else
                AxWebBrowser1.Navigate2("https://www.google.com/search?q=" + Guna2TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub AxWebBrowser1_NavigateComplete2(ByVal sender As System.Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event) Handles AxWebBrowser1.NavigateComplete2
        Try
            Parent.Text = AxWebBrowser1.LocationName
            Guna2TextBox1.Text = AxWebBrowser1.LocationURL
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            AxWebBrowser1.GoBack()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            AxWebBrowser1.GoForward()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            AxWebBrowser1.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TabNoramBrowser_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AxWebBrowser1.Navigate("https://test.howeasyyweb.com/simple_search/index.php")
            Parent.Text = "New Tab"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        AxWebBrowser1.Navigate("https://test.howeasyyweb.com/simple_search/index.php")
    End Sub

    Private Sub ButtonX1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.MouseEnter
        ButtonX1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ButtonX5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.MouseEnter
        ButtonX5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ButtonX2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.MouseEnter
        ButtonX2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ButtonX3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.MouseEnter
        ButtonX3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ButtonX5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.MouseLeave
        ButtonX5.BackColor = Color.White
    End Sub


    Private Sub ButtonX1_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.MouseLeave
        ButtonX1.BackColor = Color.White
    End Sub

    Private Sub ButtonX2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.MouseLeave
        ButtonX2.BackColor = Color.White
    End Sub

    Private Sub ButtonX3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.MouseLeave
        ButtonX3.BackColor = Color.White
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Guna2Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button7.Click

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If ButtonX4.Checked = False Then
            ButtonX4.Checked = True
            ButtonX4.BackColor = Color.WhiteSmoke
            Panel1.Visible = True

        Else
            ButtonX4.Checked = False
            ButtonX4.BackColor = Color.White
            Panel1.Visible = False
        End If


    End Sub

    Private Sub Panel1_RegionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.RegionChanged
        Panel1.Visible = False
    End Sub

    Private Sub Guna2Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        'Dim page As New TabPage
        Dim newtab As TabItem = Homenormalwebbrowser.TabControl2.CreateTab("New Tab")

        Dim t As New TabNoramBrowser
        Dim panel As TabControlPanel = DirectCast(newtab.AttachedControl, TabControlPanel)
        t.Show()
        t.Dock = DockStyle.Fill
        t.TopLevel = False

        panel.Controls.Add(t)
        Homenormalwebbrowser.TabControl2.Controls.Add(panel)
        Homenormalwebbrowser.TabControl2.SelectedTab = newtab
        Panel1.Visible = False
        'panel = TabNoramBrowser.Parent
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gobtn.Click
        If Guna2TextBox1.Text.Contains(".com") Then
            AxWebBrowser1.Navigate(Guna2TextBox1.Text)

        ElseIf Guna2TextBox1.Text.Contains(".net") Then
            AxWebBrowser1.Navigate(Guna2TextBox1.Text)

        ElseIf Guna2TextBox1.Text.Contains("www") Then
            AxWebBrowser1.Navigate(Guna2TextBox1.Text)

        ElseIf Guna2TextBox1.Text.Contains("https://") Then
            AxWebBrowser1.Navigate(Guna2TextBox1.Text)
        Else
            AxWebBrowser1.Navigate2("https://www.google.com/search?q=" + Guna2TextBox1.Text)
        End If
    End Sub
End Class