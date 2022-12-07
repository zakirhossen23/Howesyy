Public Class ShortcutPopup
    Public Shortcut As shortcut
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        addshortcut.Guna2HtmlLabel1.Text = "Edit Shortcut"
        addshortcut.ComboBox1.SelectedIndex = browserhome.remembershortcut
        addshortcut.Show()
        addshortcut.Focus()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        addshortcut.Close()
        addshortcut.ComboBox1.SelectedIndex = browserhome.remembershortcut

        addshortcut.Guna2TextBox1.Text = ""
        addshortcut.Guna2TextBox2.Text = ""
        Call addshortcut.doneclick(addshortcut.ComboBox1.Text)
        Dim browsinghome As browserhome = Shortcut.Parent().Parent().Parent()
        browsinghome.TextBox1.Focus()
        browsinghome.Guna2Button1.PerformClick()
    End Sub
End Class
