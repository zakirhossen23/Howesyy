Public Class addshortcut
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub
    Dim browserHome As browserhome
    Friend Sub doneclick(settings As String)
        If settings = "browserlink1" Then
            My.Settings.browsername1 = Guna2TextBox1.Text
            My.Settings.browserlink1 = Guna2TextBox2.Text
            My.Settings.Save()

        ElseIf settings = "browserlink2" Then
            My.Settings.browsername2 = Guna2TextBox1.Text
            My.Settings.browserlink2 = Guna2TextBox2.Text
            My.Settings.Save()
        ElseIf settings = "browserlink3" Then
            My.Settings.browsername3 = Guna2TextBox1.Text
            My.Settings.browserlink3 = Guna2TextBox2.Text
            My.Settings.Save()
        ElseIf settings = "browserlink4" Then
            My.Settings.browsername4 = Guna2TextBox1.Text
            My.Settings.browserlink4 = Guna2TextBox2.Text
            My.Settings.Save()
        ElseIf settings = "browserlink5" Then
            My.Settings.browsername5 = Guna2TextBox1.Text
            My.Settings.browserlink5 = Guna2TextBox2.Text
            My.Settings.Save()
        ElseIf settings = "browserlink6" Then
            My.Settings.browsername6 = Guna2TextBox1.Text
            My.Settings.browserlink6 = Guna2TextBox2.Text
            My.Settings.Save()
        ElseIf settings = "browserlink7" Then
            My.Settings.browsername7 = Guna2TextBox1.Text
            My.Settings.browserlink7 = Guna2TextBox2.Text
            My.Settings.Save()
        ElseIf settings = "browserlink8" Then
            My.Settings.browsername8 = Guna2TextBox1.Text
            My.Settings.browserlink8 = Guna2TextBox2.Text
            My.Settings.Save()
        End If
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
        My.Settings.Reload()
        Try

            browserHome.Guna2Button1.PerformClick()
        Catch ex As Exception
        End Try
        Me.Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Guna2TextBox2.Text.Contains("http") And Guna2TextBox2.Text.Contains("www") Then
            If Guna2TextBox1.Text = "" Then
                Guna2TextBox1.Text = Guna2TextBox2.Text
            End If
        ElseIf Not ComboBox1.Text.Contains("http") And Guna2TextBox2.Text.Contains("www") Then
            Guna2TextBox2.Text = "https://" + Guna2TextBox2.Text
            If Guna2TextBox1.Text = "" Then
                Guna2TextBox1.Text = Guna2TextBox2.Text
            End If
        ElseIf Not ComboBox1.Text.Contains("www") And Not ComboBox1.Text.Contains("http") Then
            Guna2TextBox2.Text = "https://www." + Guna2TextBox2.Text
            If Guna2TextBox1.Text = "" Then
                Guna2TextBox1.Text = Guna2TextBox2.Text
            End If
        End If

        doneclick(ComboBox1.Text)
    End Sub
    Public Sub ShowDialog(ByVal browsingHome As browserhome)

        browserHome = browsingHome
        Me.Show()

    End Sub

    Private Sub codecheck(settings As String)
        If settings = "browserlink1" Then
            Guna2TextBox1.Text = My.Settings.browsername1
            Guna2TextBox2.Text = My.Settings.browserlink1


        ElseIf settings = "browserlink2" Then
            Guna2TextBox1.Text = My.Settings.browsername2
            Guna2TextBox2.Text = My.Settings.browserlink2

        ElseIf settings = "browserlink3" Then
            Guna2TextBox1.Text = My.Settings.browsername3
            Guna2TextBox2.Text = My.Settings.browserlink3

        ElseIf settings = "browserlink4" Then
            Guna2TextBox1.Text = My.Settings.browsername4
            Guna2TextBox2.Text = My.Settings.browserlink4

        ElseIf settings = "browserlink5" Then
            Guna2TextBox1.Text = My.Settings.browsername5
            Guna2TextBox2.Text = My.Settings.browserlink5

        ElseIf settings = "browserlink6" Then
            Guna2TextBox1.Text = My.Settings.browsername6
            Guna2TextBox2.Text = My.Settings.browserlink6

        ElseIf settings = "browserlink7" Then
            Guna2TextBox1.Text = My.Settings.browsername7
            Guna2TextBox2.Text = My.Settings.browserlink7

        ElseIf settings = "browserlink8" Then
            Guna2TextBox1.Text = My.Settings.browsername8
            Guna2TextBox2.Text = My.Settings.browserlink8

        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        codecheck(sender.text)
    End Sub

    Private Sub addshortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox1.Focus()
    End Sub

    Private Sub addshortcut_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Guna2TextBox1.Focus()
    End Sub
End Class