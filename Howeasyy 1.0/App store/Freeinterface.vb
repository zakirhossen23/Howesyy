Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Public Class Freeinterface

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Data_description.Click

    End Sub
    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Private Sub Freeinterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New MySqlConnection()
        cn.ConnectionString = "datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy"
    End Sub

    Private Sub Data_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Data_ID.TextChanged
        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim command As New MySqlCommand("SELECT * FROM `uiandux_page` WHERE `iD` = @id", connection)

        command.Parameters.Add("@id", MySqlDbType.Int64).Value = Data_ID.Text

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)
            Dim imgByte() As Byte

            If table.Rows.Count > 0 Then
                imgByte = table(0)(3)
                'TextBox1.Text = table(0)(0)
                TextBox3.Text = table(0)(0)
                Data_description.Text = table(0)(1)
                Data_application.Text = table(0)(2)
                Traillink.Text = table(0)(4)
                Data_price.Text = table(0)(6)

                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                Data_price.Text = ""

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString())

        End Try
    End Sub
    Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
    Private Sub insert()

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("INSERT INTO `trail_details`(`Downloads`, `Download_Date`, `Email`, `Name`,`Picture`) VALUES (@download,@Date,@Email,@Name,@Picture)", connection)

        command.Parameters.Add("@download", MySqlDbType.VarChar).Value = Data_application.Text

        command.Parameters.Add("@Date", MySqlDbType.VarChar).Value = Label5.Text

        command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = FlowMobileFreeinterface.Email_ID.Text

        command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Mainpage.UsernameLBL.Text

        command.Parameters.Add("@Picture", MySqlDbType.Blob).Value = ms.ToArray()

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            'MessageBox.Show("Inserted")
            'Button2.PerformClick()
            'MessageBox.Show("Image Inserted")

        Else
            MessageBox.Show("Error")
        End If

        connection.Close()


    End Sub
    Dim user = Environment.UserName
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        insert()
        Downloadpage.Downloadlink.Text = Traillink.Text

        Downloadpage.Version.Text = " Free Version"
        Downloadpage.Label2.Text = Data_application.Text

        Downloadpage.Label2.Text = Downloadpage.Label2.Text + Downloadpage.Version.Text
        Downloadpage.Filename.Text = Downloadpage.Label2.Text + ".exe"

        Downloadpage.Savefile.Text = "c:\Users\" & user & "\Downloads\" & Downloadpage.Filename.Text
        Me.Hide()
        Downloadpage.Button2.PerformClick()

        Downloadpage.ShowDialog()



    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

        'NewCustomerdeatispos.TextBox1.Text = "0"

    End Sub


    Private Sub Guna2ControlBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2ControlBox1.Click
        Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = Today
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        insert()
    End Sub
End Class