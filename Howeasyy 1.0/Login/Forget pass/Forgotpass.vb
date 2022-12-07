Imports System.Net
Imports System.Net.Mail
Public Class Forgotpass
    Dim randomcode As String
    Public Shared touser As String
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Randomdd()
        Dim rand As Random = New Random
        randomcode = (rand.Next(999999)).ToString()

    End Sub
    Friend Sub loadclear()
        lavel = "Email"
        TextBox1.Clear()
        TextBox2.Clear()
        PanelSwitch2.HideSync(RecoveryPanel, False)
        PanelSwitch2.HideSync(VerifyPanel, False)
        Panelswitch.ShowSync(EmailSenderPanel, False)
    End Sub


    Public lavel As String = "Email"
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        If lavel = "Verify" Then
            PanelSwitch2.HideSync(VerifyPanel, False)
            Panelswitch.ShowSync(EmailSenderPanel, False)
        ElseIf lavel = "Email" Then
            loadclear()
            forgotpassconnect.Hide()
            Form2.openslide()
        ElseIf lavel = "Recovery" Then
            loadclear()
            forgotpassconnect.Hide()
            Form2.openslide()
        End If


    End Sub

    Private Sub Testing1_ButtonClick(sender As Object, e As EventArgs) Handles DigitalButton1.ButtonClick

        '        Dim from, pass, messagebody As String
        '        Dim rand As Random = New Random()
        '        randomcode = (rand.Next(999999)).ToString()
        '        Dim message As MailMessage = New MailMessage()
        '        touser = TextBox1.Text
        '        from = "noreplayhoweasyy@gmail.com"
        '        pass = "zakir%%$"
        '        messagebody = "Your reset code is " + randomcode
        '        message.To.Add(touser)
        '        message.From = New MailAddress(from)
        '        message.Body = messagebody
        '        message.Subject = "Password reseting code"
        '        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com") With {
        '            .EnableSsl = True,
        '            .Port = 587
        '        }
        '#Disable Warning BC42025
        '        smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        '#Enable Warning BC42025
        '        smtp.Credentials = New NetworkCredential(from, pass)
        '        Try

        '            smtp.Send(message)
        '            MsgBox("Please check your email and enter the code blew.")


        Panelswitch.HideSync(EmailSenderPanel, False)
        PanelSwitch2.ShowSync(VerifyPanel)
        Me.Refresh()
        lavel = "Verify"

        '            TextBox2.Focus()
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '            MsgBox("There has a problem to sent code")
        '        End Try

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        'If (TextBox2.Text.Equals(randomcode)) Then
        '    touser = TextBox1.Text
        '    resetpass.TextBoxid.Text = TextBox1.Text
        DisplayForm(New resetpass, RecoveryPanel)
        Panelswitch.HideSync(VerifyPanel, False)
        PanelSwitch2.ShowSync(RecoveryPanel)

        lavel = "Recovery"

        '    resetpass.TextBoxid.Text = TextBox1.Text
        '    TextBox2.Clear()
        'Else
        '    MsgBox("Code Invalid")
        'End If
    End Sub
End Class