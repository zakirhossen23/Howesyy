Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class DevAreaUpdate
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
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
    Private Sub updatesave()
        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim update_command As New MySqlCommand("UPDATE `developerarea` SET `SourceCode`=@SourceCode,`CodeLanuage`=@CodeLanuage,`SourceDescription`=@SourceDescription,`Pic`=@Pic WHERE `ID` = @ID", connection)

        Dim ms As New MemoryStream

        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        update_command.Parameters.Add("@ID", MySqlDbType.Blob).Value = TextBox3.Text()
        update_command.Parameters.Add("@SourceCode", MySqlDbType.LongText).Value = TextBox2.Text()
        update_command.Parameters.Add("@CodeLanuage", MySqlDbType.LongText).Value = ComboBoxEx1.Text()
        update_command.Parameters.Add("@SourceDescription", MySqlDbType.LongText).Value = TextBox1.Text()
        update_command.Parameters.Add("@Pic", MySqlDbType.Blob).Value = ms.ToArray()

        connection.Open()

        If update_command.ExecuteNonQuery() = 1 Then
            MsgBox("Updated")
            DevArea.LoadData()
        Else

        End If

        connection.Close()
    End Sub
    Friend Sub loadform()
        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim command As New MySqlCommand("SELECT * FROM `developerarea` WHERE `ID` = @ID", connection)

        command.Parameters.Add("@ID", MySqlDbType.Int64).Value = TextBox3.Text

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)
            Dim imgByte() As Byte

            If table.Rows.Count > 0 Then
                imgByte = table(0)(4)


                TextBox2.Text = table(0)(1)
                ComboBoxEx1.Text = table(0)(2)
                TextBox1.Text = table(0)(3)
                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)
            Else

            End If

        Catch ex As Exception


        End Try
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        loadform()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        updatesave()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class