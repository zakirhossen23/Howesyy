Imports MySql.Data.MySqlClient
Imports System.IO
Public Class DesktopDataInput

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Upload  Photo..."
                .Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg|(*.giff)|*.giff| All Files (*.*)|*.*"

                If .ShowDialog = DialogResult.OK Then
                    Me.PictureBox1.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
    Private Sub insert()
        Try
            Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
            Dim ms As New MemoryStream

            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            Dim command As New MySqlCommand("INSERT INTO `uiandux_page`(`Name`, `describes`, `try`, `buy`, `Pics`, `Price`, `categories`) VALUES (@nm,@ds,@t,@b,@p,@price,@categories)", connection)

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@ds", MySqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@t", MySqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@b", MySqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@p", MySqlDbType.Blob).Value = ms.ToArray()
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = TextBox6.Text
            command.Parameters.Add("@categories", MySqlDbType.VarChar).Value = ComboBox1.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Inserted")
            Else
                MessageBox.Show("Not Inserted")
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox("Please use another image")
        End Try



    End Sub
    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        insert()
        AdminDesktopFlow.Button2.PerformClick()

    End Sub

    Private Sub Guna2Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox6.Text = "0"
        TextBox4.Text = ""
        TextBox3.Text = ""
        PictureBox1.Image = Howeasyy.My.Resources.Resources.picture
    End Sub
End Class