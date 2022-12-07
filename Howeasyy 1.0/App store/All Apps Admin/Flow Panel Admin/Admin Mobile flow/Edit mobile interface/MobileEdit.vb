Imports MySql.Data.MySqlClient
Imports System.IO
Public Class MobileEdit

    Private Sub Data_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Data_ID.TextChanged

        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim command As New MySqlCommand("SELECT * FROM `mobile` WHERE `iD` = @id", connection)

        command.Parameters.Add("@id", MySqlDbType.Int64).Value = Data_ID.Text

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)
            Dim imgByte() As Byte

            If table.Rows.Count > 0 Then
                imgByte = table(0)(3)
                'TextBox1.Text = table(0)(0)
                Data_buy.Text = table(0)(0)
                Data_description.Text = table(0)(1)
                Data_application.Text = table(0)(2)
                'Traillink.Text = table(0)(4)
                Price.Text = table(0)(6)

                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                Price.Text = "0"

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString())

        End Try
    End Sub
    Private Sub updatesave()
        Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
        Dim con As New MySqlConnection(str)
        Try
            Dim cmd As MySqlCommand
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandText = "update mobile set describes=@describes, buy=@buy,Name=@Name,Price=@price where iD=@iD"
            'MsgBox("Connection")
            cmd.Parameters.AddWithValue("@describes", Data_description.Text)
            'cmd.Parameters.AddWithValue("@try", Traillink.Text)
            cmd.Parameters.AddWithValue("@buy", Data_buy.Text)
            cmd.Parameters.AddWithValue("@Name", Data_application.Text)
            cmd.Parameters.AddWithValue("@price", Price.Text)

            cmd.Parameters.AddWithValue("@iD", Data_ID.Text)

            cmd.ExecuteNonQuery()
            Try

            Catch ex As Exception

            End Try

            con.Close()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub updateimage()
        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim update_command As New MySqlCommand("UPDATE `mobile` SET `Pics`=@Pics WHERE `iD` = @iD", connection)
        Dim ms As New MemoryStream

        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        update_command.Parameters.Add("@iD", MySqlDbType.UInt32).Value = Data_ID.Text()
        update_command.Parameters.Add("@Pics", MySqlDbType.LongBlob).Value = ms.ToArray()

        connection.Open()

        If update_command.ExecuteNonQuery() = 1 Then

        Else

        End If

        connection.Close()
    End Sub
    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        updatesave()
        updateimage()
        MsgBox("Updated")
        AdminMobileFlow.Button2.PerformClick()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.ico)|*.ico|(*.jpeg)|*.jpeg|(*.giff)|*.giff| All Files (*.*)|*.*"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub
End Class