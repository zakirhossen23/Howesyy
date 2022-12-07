Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class resetpass
    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)



    Private Sub reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Forgotpass.TextBox1.Text = Me.TextBoxid.Text
    End Sub

    Private Sub clearLoad()
        TextBoxpass.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub


    Private Sub updatesave()
        Try
            'Dim cmd As MySqlCommand
            'con.Open()

            'Dim crypt As New Chilkat.Crypt2
            'crypt.BCryptWorkFactor = 10
            'Dim bcryptHash As String = crypt.BCryptHash(TextBoxpass.Text)

            'cmd = con.CreateCommand()
            'cmd.CommandText = "update login set pass=@firstname2 where id=@firstname3"
            'cmd.Parameters.AddWithValue("@firstname2", bcryptHash)
            'cmd.Parameters.AddWithValue("@firstname3", TextBoxid.Text)
            'cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Updated.")
            Forgotpass.loadclear()
            forgotpassconnect.Hide()
            Form2.openslide()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If TextBoxpass.Text = "" Then
            MsgBox("Please fill Password")

        Else

            If TextBoxpass.Text = TextBox2.Text Then
                updatesave()
                TextBoxid.Clear()
                TextBoxpass.Clear()
                TextBox2.Clear()

            Else
                MsgBox("Password does not match.")

            End If
        End If
    End Sub
End Class