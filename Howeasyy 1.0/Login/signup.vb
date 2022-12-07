Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.ComponentModel
Public Class signup

    Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            connection.Close()
        Catch ex As Exception

        End Try

        Dim Password As String = Cryptography.Encrypt(TextBox3.Text.ToString())

        If TextBox1.Text = "" Then
            MsgBox("Please fill username box")
            TextBox1.Focus()

            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please fill E-mail ID box")
            TextBox2.Focus()
            Exit Sub
        End If

        connection.Open()
        Dim query As String = "select * from login where id = @username"
        Dim comman As New MySqlCommand

        Dim reader As MySqlDataReader
        With comman
            .CommandText = query
            .Connection = connection
            .Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox2.Text.Trim
            reader = .ExecuteReader()
        End With
        If reader.Read Then
            MsgBox("User " & TextBox2.Text.Trim & " is already added! Please choose another Email!", MsgBoxStyle.Information)
        Else
            Try
                connection.Close()
            Catch ex As Exception

            End Try
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim command As New MySqlCommand("INSERT INTO `login`(`Name`, `id`,`pass`,`Picture`) VALUES (@1,@2,@3,@Picture)", connection)

            ' add Parameters to the command
            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = Password
            command.Parameters.Add("@Picture", MySqlDbType.Blob).Value = ms.ToArray()

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                loadclear()
                MessageBox.Show("You can log in now.")

                Me.Hide()
                Form2.Show()
            Else

                MessageBox.Show("ERROR")

            End If

            connection.Close()
        End If

    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form2.Show()
    End Sub
    Private Sub loadclear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loadclear()
        Me.Hide()
        Form2.openslide()
        'Form2.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Try
            connection.Close()
        Catch ex As Exception

        End Try

        Dim Password As String = Cryptography.Encrypt(TextBox3.Text.ToString())

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            ErrorPanel.Visible = True
            Errorlabel.Text = "Please fill in all of the fields!"

            Exit Sub
        ElseIf TextBox2.Text.Contains("@") = False Then
            ErrorPanel.Visible = True
            Errorlabel.Text = "Please include an '@' in Email field!"
            Exit Sub

        ElseIf TextBox3.Text.Length < 8 Then
            ErrorPanel.Visible = True
            Errorlabel.Text = "The password must be at least 8 characters."
            Exit Sub
        ElseIf TextBox3.Text = TextBox4.Text Then

        Else
            ErrorPanel.Visible = True
            Errorlabel.Text = "Both password does not matched!"
            Exit Sub

        End If


        connection.Open()
        Dim query As String = "select * from login where id = @username"
        Dim comman As New MySqlCommand

        Dim reader As MySqlDataReader
        With comman
            .CommandText = query
            .Connection = connection
            .Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox2.Text.Trim
            reader = .ExecuteReader()
        End With
        If reader.Read Then
            MsgBox("User " & TextBox2.Text.Trim & " is already added! Please choose another Email!", MsgBoxStyle.Information)
        Else
            Try
                connection.Close()
            Catch ex As Exception
            End Try
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim command As New MySqlCommand("INSERT INTO `login`(`Name`, `id`,`pass`,`Picture`) VALUES (@1,@2,@3,@Picture)", connection)

            ' add Parameters to the command
            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = Password
            command.Parameters.Add("@Picture", MySqlDbType.Blob).Value = ms.ToArray()

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                loadclear()
                Me.Hide()
                Form2.openslide()
            Else
                ErrorPanel.Visible = True
                Errorlabel.Text = "An error has occurred. Please try again."
            End If
            connection.Close()
        End If


    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ErrorPanel.Visible = False
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Successpanel.Visible = False
    End Sub
End Class