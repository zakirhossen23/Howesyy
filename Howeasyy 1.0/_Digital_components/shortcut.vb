Imports System.IO
Imports System.Net
Public Class shortcut
    Dim link As New TextBox
    Dim statustext As New TextBox

    WithEvents popup As Popup
    Public Shared Function favicon(ByVal u As String, ByVal file As String, status As String) As Image


        Dim url As Uri = New Uri(u)
        Dim iconurl As String = "http://" & url.Host & "/favicon.ico"
        Dim request As WebRequest = WebRequest.Create(iconurl)

        Try
            Dim response As WebResponse = request.GetResponse()
            Dim s As Stream = response.GetResponseStream()
            Return Image.FromStream(s)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Private Sub shortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2MouseStateHandler1.Add(img)
        Guna2MouseStateHandler1.Add(Guna2Panel3)
        Guna2MouseStateHandler1.Add(Guna2Panel1)
        Guna2MouseStateHandler1.Add(Label1)
        Guna2MouseStateHandler1.Add(Guna2Panel2)
        Guna2MouseStateHandler1.Add(Me)
        Try

            doneclick(ComboBox1.Text)
            img.Image = favicon(link.Text, "net.png", statustext.Text)

        Catch ex As Exception
            Me.Hide()
        End Try
        Dim UserControl1 As New ShortcutPopup
        UserControl1.Shortcut = Me
        popup = New Popup(UserControl1, IconButton1)

    End Sub

    Public Property SelectedText As String
        Get
            Return ComboBox1.SelectedIndex
        End Get
        Set(ByVal value As String)
            ComboBox1.SelectedIndex = value
        End Set


    End Property
    Public Property urltext As String
        Get
            Return link.Text
        End Get
        Set(ByVal value As String)
            link.Text = value
        End Set


    End Property


    Private Sub doneclick(settings As String)
        If settings = "browserlink1" Then
            Label1.Text = My.Settings.browsername1
            link.Text = My.Settings.browserlink1

        ElseIf settings = "browserlink2" Then
            Label1.Text = My.Settings.browsername2
            link.Text = My.Settings.browserlink2

        ElseIf settings = "browserlink3" Then
            Label1.Text = My.Settings.browsername3
            link.Text = My.Settings.browserlink3

        ElseIf settings = "browserlink4" Then
            Label1.Text = My.Settings.browsername4
            link.Text = My.Settings.browserlink4

        ElseIf settings = "browserlink5" Then
            Label1.Text = My.Settings.browsername5
            link.Text = My.Settings.browserlink5

        ElseIf settings = "browserlink6" Then
            Label1.Text = My.Settings.browsername6
            link.Text = My.Settings.browserlink6

        ElseIf settings = "browserlink7" Then
            Label1.Text = My.Settings.browsername7
            link.Text = My.Settings.browserlink7

        ElseIf settings = "browserlink8" Then
            Label1.Text = My.Settings.browsername8
            link.Text = My.Settings.browserlink8

        End If

    End Sub
    Event ShortcutClick As EventHandler
    Private Sub Guna2MouseStateHandler1_PressedState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.PressedState
        RaiseEvent ShortcutClick(Me, Nothing)
    End Sub

    Private Sub Guna2MouseStateHandler1_HoverState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.HoverState
        Guna2Panel2.BorderColor = Color.Black
    End Sub

    Private Sub Guna2MouseStateHandler1_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.IdleState
        Guna2Panel2.BorderColor = Color.Transparent
    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim input As String = Me.Name

        browserhome.remembershortcut = input.Substring(9, 1) - 1

        popup.Show()

    End Sub

    Friend Sub Refreshbtn_Click()
        Control.CheckForIllegalCrossThreadCalls = False
        Try

            doneclick(ComboBox1.Text)
            img.Image = My.Resources.laoding
            img.Image = favicon(link.Text, "net.png", statustext.Text)
            Me.Show()
        Catch ex As Exception
            Me.Hide()
        End Try
    End Sub
End Class
