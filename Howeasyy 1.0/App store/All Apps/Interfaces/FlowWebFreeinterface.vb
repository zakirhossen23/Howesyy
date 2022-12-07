Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Public Class FlowWebFreeinterface

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Data_description.Click

    End Sub

    Private Sub Freeinterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

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
    Dim user = Environment.UserName
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Downloadpage.Downloadlink.Text = Traillink.Text
        Me.Hide()
        Downloadpage.Show()
        Downloadpage.Version.Text = " Free Version"
        Downloadpage.Label2.Text = Data_application.Text


        Downloadpage.Label2.Text = Downloadpage.Label2.Text + Downloadpage.Version.Text
        Downloadpage.Filename.Text = Downloadpage.Label2.Text + ".exe"

        Downloadpage.Savefile.Text = "c:\Users\" & user & "\Downloads\" & Downloadpage.Filename.Text
        Downloadpage.Button2.PerformClick()

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


    End Sub


End Class