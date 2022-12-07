Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Editprofile

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")

    Private Sub getdata()
        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim command As New MySqlCommand("SELECT * FROM `login` WHERE `Auto_ID` = @idd", connection)

        command.Parameters.Add("@idd", MySqlDbType.Int64).Value = My.Settings.LoginID

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)
            Dim imgByte() As Byte

            If table.Rows.Count > 0 Then
                imgByte = table(0)(4)

                TextBoxX1.Text = table(0)(2)
                TextBoxX3.Text = table(0)(1)
                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)
            Else


            End If

        Catch ex As Exception
            PictureBox1.Image = Nothing
            MessageBox.Show("An error orchard! Please try again.")

        End Try
    End Sub
    Private Sub Editprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxX2.Text = My.Settings.Email
        getdata()

    End Sub

    Private Sub TextBoxX5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX5.TextChanged
        If TextBoxX5.Text = "" Then
            Label9.Text = "❌"

            Label9.ForeColor = Color.Red
        ElseIf TextBoxX5.Text = TextBoxX4.Text Then
            Label9.Text = "✔"
            Label9.ForeColor = Color.LimeGreen

        Else
            Label9.Text = "❌"
            Label9.ForeColor = Color.Red
        End If

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub
    Private Sub updateimage()
        Dim update_command As New MySqlCommand("UPDATE `login` SET `Picture`=@Picture WHERE `Auto_ID` = @id", connection)

        Dim ms As New MemoryStream

        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        update_command.Parameters.Add("@id", MySqlDbType.Blob).Value = TextBoxX6.Text()
        update_command.Parameters.Add("@Picture", MySqlDbType.Blob).Value = ms.ToArray()

        connection.Open()

        If update_command.ExecuteNonQuery() = 1 Then

        Else

        End If

        connection.Close()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If TextBoxX4.Text = "" Then
            TextBoxX4.Text = TextBoxX3.Text

        End If

        updatesave()

        Mainpage.ButtonX2.PerformClick()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(Str)
    Private Sub updatesave()
        Try
            Dim cmd As MySqlCommand
            con.Open()


            Dim crypt As New Chilkat.Crypt2
            crypt.BCryptWorkFactor = 10
            Dim bcryptHash As String = crypt.BCryptHash(TextBoxX4.Text)

            Dim ms As New MemoryStream

            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            cmd = con.CreateCommand()
            cmd.CommandText = "update login set pass=@pass, Name=@Name, Picture=@Picture where id=@id"
            cmd.Parameters.AddWithValue("@pass", bcryptHash)
            cmd.Parameters.AddWithValue("@Name", TextBoxX1.Text)
            cmd.Parameters.Add("@Picture", MySqlDbType.Blob).Value = MS.ToArray()

            cmd.Parameters.AddWithValue("@Picture", TextBoxX1.Text)
            cmd.Parameters.AddWithValue("@id", TextBoxX2.Text)
            cmd.ExecuteNonQuery()

            con.Close()
            Mainpage.ButtonX2.PerformClick()
            MsgBox("Updated.")


        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX2.TextChanged

    End Sub
End Class