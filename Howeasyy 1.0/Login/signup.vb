Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.ComponentModel
Imports System.Threading

Public Class signup

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form2.Show()
    End Sub
    Private Sub loadclear()
        NameTXT.Clear()
        EmailTXT.Clear()
        PasswordTXT.Clear()
        ConfirmPassTXT.Clear()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LoginBTN.LinkClicked
        loadclear()
        Me.Hide()
        Form2.openslide()
        'Form2.Show()
    End Sub

    Private Async Sub Register()

        Dim UserResult() = {New With {
        .id = "",
        .name = "",
        .email = "",
        .pass = "",
        .picture = "",
        .serial = "",
        .status = ""
        }}
        UserResult = Await Request.GetJSONAsync("select * from users where email='" & EmailTXT.Text & "'", UserResult)

        If (UserResult.Length > 0) Then
            MessageBox.Show($"User {EmailTXT.Text} is already added! Please choose another Email!", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim Password As String = Cryptography.Encrypt(PasswordTXT.Text.ToString())

            Dim result = New Dictionary(Of String, Object) From {
            {"name", NameTXT.Text},
            {"email", EmailTXT.Text},
            {"pass", Password},
            {"picture", "/upload/default.png"},
            {"status", 0}
            }

            Dim sqlQuery As String = Request.InsertQueryMaker("users", result)
            Await Request.PostAsync(sqlQuery)
        End If

        Guna2Button1.Enabled = True
        loadclear()
        Thread.CurrentThread.Abort()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click



        If (NameTXT.Text = "") Or (ConfirmPassTXT.Text = "") Or (EmailTXT.Text = "") Or (PasswordTXT.Text = "") Then
            ErrorPanel.Visible = True
            Errorlabel.Text = "Please fill in all of the fields!"

            Exit Sub
        ElseIf EmailTXT.Text.Contains("@") = False Then
            ErrorPanel.Visible = True
            Errorlabel.Text = "Please include an '@' in Email field!"
            Exit Sub

        ElseIf PasswordTXT.Text.Length < 8 Then
            ErrorPanel.Visible = True
            Errorlabel.Text = "The password must be at least 8 characters."
            Exit Sub
        ElseIf Not PasswordTXT.Text.Equals(ConfirmPassTXT.Text) Then
            ErrorPanel.Visible = True
            Errorlabel.Text = "Both password does not matched!"
            Exit Sub

        End If

        Guna2Button1.Enabled = False

        Dim objNewThread As New Thread(AddressOf Register)
        objNewThread.IsBackground = True
        objNewThread.Start()

    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ErrorPanel.Visible = False
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Successpanel.Visible = False
    End Sub

    Private Sub signup_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        PasswordTXT.UseSystemPasswordChar = Not PasswordTXT.UseSystemPasswordChar
        sender.IconChar = If(PasswordTXT.UseSystemPasswordChar = False, FontAwesome.Sharp.IconChar.EyeSlash, FontAwesome.Sharp.IconChar.Eye)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ConfirmPassTXT.UseSystemPasswordChar = Not ConfirmPassTXT.UseSystemPasswordChar
        sender.IconChar = If(ConfirmPassTXT.UseSystemPasswordChar = False, FontAwesome.Sharp.IconChar.EyeSlash, FontAwesome.Sharp.IconChar.Eye)

    End Sub
End Class