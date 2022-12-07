Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class FlowMobileFreeinterface

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Guna2RadioButton1.Checked = True Then
            Email_Panel.Visible = False
            SMS_Panel.Visible = True

        Else
            Label2.Text = "A download link will be sent to your verified ID email address:"
            Email_Panel.Visible = True
            SMS_Panel.Visible = False
        End If
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
                Buy_Text.Text = table(0)(0)

                Apps_Name.Text = table(0)(2)
                Trail_Text.Text = table(0)(4)


                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                'Data_price.Text = ""

            End If

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Shared touser As String
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2RadioButton2.Checked = True Then
            Dim from, pass, messagebody As String
            Dim rand As Random = New Random()

            Dim message As MailMessage = New MailMessage()
            touser = Email_ID.Text
            from = "noreplayhoweasyy@gmail.com"
            pass = "zakir%%$"
            messagebody = "Your " + Apps_Name.Text + " Download link " + Buy_Text.Text
            message.To.Add(touser)
            message.From = New MailAddress(from)
            message.Body = messagebody
            message.Subject = Apps_Name.Text + "-Download link"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com") With {
                .EnableSsl = True,
                .Port = 587
            }
#Disable Warning BC42025
            smtp.DeliveryMethod = smtp.DeliveryMethod.Network
#Enable Warning BC42025
            smtp.Credentials = New NetworkCredential(from, pass)
            Try

                smtp.Send(message)
                MsgBox("Download link sent.")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("There has a problem to sent link")
            End Try
        Else

        End If

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
    End Sub

    Private Sub FlowMobileFreeinterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Email_ID.Text = My.Settings.Email
    End Sub
End Class