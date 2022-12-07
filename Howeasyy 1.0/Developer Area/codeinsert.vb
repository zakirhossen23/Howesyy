
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class codeinsert
    Private Sub insertdata()
        Try
            Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
            Dim ms As New MemoryStream

            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            Dim command As New MySqlCommand("INSERT INTO `developerarea`(`SourceCode`, `CodeLanuage`, `SourceDescription`, `Pic`) VALUES (@SourceCode,@CodeLanuage,@SourceDescription,@Pic)", connection)

            command.Parameters.Add("@SourceCode", MySqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@CodeLanuage", MySqlDbType.VarChar).Value = ComboBoxEx1.Text
            command.Parameters.Add("@SourceDescription", MySqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@Pic", MySqlDbType.Blob).Value = ms.ToArray()


            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Inserted")
                DevArea.LoadData()
            Else
                'MessageBox.Show("Not Inserted")
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!")
        End Try

    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If ComboBoxEx1.Text = "" Then
            MessageBox.Show("Please select Code Lanuage")
            Exit Sub
        Else
            insertdata()
        End If

    End Sub
    Private Sub video_insert()
        Dim SourceFilePath As String
        OpenFileDialog1.Filter = "MP3 files(*.mp3)|*.mp3|Video files(*.mpg)|*.mpg|Video Disc MPEG (*.dat)|*.dat|All Files(*.*)|*.*"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then Exit Sub
        SourceFilePath = OpenFileDialog1.FileName
        Dim VideoName As String = SourceFilePath

        If VideoName <> "" Then
            Dim fls As IO.FileStream
            fls = New IO.FileStream(VideoName, FileMode.Open, FileAccess.Read)
            Dim blob(fls.Length) As Byte
            fls.Read(blob, 0, System.Convert.ToInt32(fls.Length))
            fls.Close()

            Dim conn As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
            Dim query = "insert into developerarea(Videofile) values(video=:blobParameter)"
            conn.Open()
            Dim cmnd As MySqlCommand
            Dim blobParameter = New MySqlParameter()
            blobParameter.MySqlDbType = MySqlDbType.LongBlob
            blobParameter.ParameterName = "BlobParameter"
            blobParameter.Value = blob
            cmnd = New MySqlCommand(query, conn)
            cmnd.Parameters.Add(blobParameter)
            cmnd.ExecuteNonQuery()
            cmnd.Dispose()
            conn.Close()
            conn.Dispose()
        End If
    End Sub

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

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        PictureBox1.Image = Howeasyy.My.Resources.Resources.picture
        TextBox2.Clear()
        TextBox1.Clear()
        ComboBoxEx1.Text = ""
        ComboBoxEx1.WatermarkText = "Select Language"
    End Sub
End Class