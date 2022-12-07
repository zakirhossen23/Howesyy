Imports MySql.Data.MySqlClient
Imports System.IO
Public Class DetailtrailInterface
    ReadOnly str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    ReadOnly con As New MySqlConnection(str)
    Private Sub Updatesave()
        Try
            Dim cmd As MySqlCommand
            con.Open()
            Dim ms As New MemoryStream



            cmd = con.CreateCommand()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            cmd.CommandText = "update trail_details set Serial=@firstname1,Downloads=@firstname2,Download_Date=@firstname3,Expire_Date=@firstname4, Picture=@pic where ID=@id"
            cmd.Parameters.AddWithValue("@firstname1", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@firstname2", Guna2TextBox2.Text)
            cmd.Parameters.AddWithValue("@firstname3", Guna2DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("@firstname4", Guna2DateTimePicker2.Text)
            cmd.Parameters.AddWithValue("@pic", ms.ToArray)
            cmd.Parameters.AddWithValue("@id", Auto_ID.Text)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Updated.")

        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub
    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Updatesave()
        Getimagebyautoid()
        DetailTrail.refreshbtn.PerformClick()
    End Sub

    Private Sub Getimagebyautoid()
        Try
            Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
            Dim command As New MySqlCommand("SELECT * FROM `trail_details` WHERE `ID` = @idd", connection)

            command.Parameters.Add("@idd", MySqlDbType.Int64).Value = Auto_ID.Text

            Dim adapter As New MySqlDataAdapter(command)

            Dim table As New DataTable()

            Try

                adapter.Fill(table)
                Dim imgByte() As Byte

                If table.Rows.Count > 0 Then
                    imgByte = table(0)(1)
                    'TextBox1.Text = table(0)(0)

                    Dim ms As New MemoryStream(imgByte)
                    PictureBox1.Image = Image.FromStream(ms)
                Else


                End If

            Catch ex As Exception
                PictureBox1.Image = Nothing
                MessageBox.Show(ex.Message)

            End Try
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Dim opf As New OpenFileDialog With {
            .Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        }
        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)


        Else
            Exit Sub
        End If
    End Sub

    Private Sub Auto_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Auto_ID.TextChanged
        Getimagebyautoid()
    End Sub

    Private Sub DetailtrailInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getimagebyautoid()
    End Sub
End Class