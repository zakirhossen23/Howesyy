#Disable Warning BC42017 ' Late bound resolution
#Disable Warning BC42016 ' Implicit conversion
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Threading
Imports System.Net
Imports Guna.UI2.WinForms
Imports Microsoft.Win32

Public Class Editprofile
    Dim CurrentUser = {New With {
        .id = "",
        .name = "",
        .email = "",
        .pass = "",
        .picture = "",
        .serial = "",
        .status = ""
        }}
    Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")

    Private Async Sub LoadAll()
        Dim Result = {New With {
        .id = "",
        .name = "",
        .email = "",
        .pass = "",
        .picture = "",
        .serial = "",
        .status = ""
        }}
        CurrentUser = Await Request.GetJSONAsync("select * from users where id='" & My.Settings.LoginID & "'", Result)
        NameTXT.Text = CurrentUser(0).name
        EmailTXT.Text = CurrentUser(0).email
        UserImage.Image = Bitmap.FromStream(CType(WebRequest.Create(New Uri($"https://api.howeasyy.com/{CurrentUser(0).picture}")).GetResponse().GetResponseStream(), Stream))

        Thread.CurrentThread.Abort()
    End Sub


    Private Sub Editprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

        Dim objNewThread As New Thread(AddressOf LoadAll)
        objNewThread.IsBackground = True
        objNewThread.Start()


    End Sub


    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub updateimage()
        'Dim update_command As New MySqlCommand("UPDATE `login` SET `Picture`=@Picture WHERE `Auto_ID` = @id", connection)

        'Dim ms As New MemoryStream

        'UserImage.Image.Save(ms, UserImage.Image.RawFormat)
        'update_command.Parameters.Add("@id", MySqlDbType.Blob).Value = TextBoxX6.Text()
        'update_command.Parameters.Add("@Picture", MySqlDbType.Blob).Value = ms.ToArray()

        'connection.Open()

        'If update_command.ExecuteNonQuery() = 1 Then

        'Else

        'End If

        connection.Close()
    End Sub


    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)

    Private Sub Guna2Panel2_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click, Guna2Panel2.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        opf.ShowDialog()
        If opf.FileNames.Length > 0 Then

            UserImage.Image = Image.FromFile(opf.FileName)
            Guna2Panel2.UseTransparentBackground = False
            Guna2Panel2.UseTransparentBackground = True
        End If
    End Sub
    Private Async Sub UpdateData()


        If (Not Cryptography.Decrypt(CurrentUser(0).pass).Equals(PasswordTXT.Text) And NewPassTXT.Text IsNot String.Empty) Then
            MessageBox.Show($"Current Password is incorrect!", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Not NewPassTXT.Text.Equals(ConfirmPassTXT.Text)) Then
            MessageBox.Show($"New Password and Confirm Password both does not matched!", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If NewPassTXT.Text = "" Then
                NewPassTXT.Text = Cryptography.Decrypt(CurrentUser(0).pass)
            End If
            Dim Password As String = Cryptography.Encrypt(NewPassTXT.Text.ToString())
            NewPassTXT.Text = ""
            Dim allFields = New Dictionary(Of String, Object) From {
            {"name", NameTXT.Text},
            {"pass", Password}
            }

            Dim sqlQuery As String = Request.UpdateQueryMaker("users", allFields, "id", CurrentUser(0).id)

            Await Request.PostAsync(sqlQuery)
            UpadateBTN.Enabled = True
            Mainpage.ButtonX2.PerformClick()
        End If

        UpadateBTN.Enabled = True
        Thread.CurrentThread.Abort()

    End Sub
    Private Sub UpadateBTN_Click(sender As Object, e As EventArgs) Handles UpadateBTN.Click

        UpadateBTN.Enabled = False

        Dim objNewThread As New Thread(AddressOf UpdateData)
        objNewThread.IsBackground = True
        objNewThread.Start()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        PasswordTXT.UseSystemPasswordChar = Not PasswordTXT.UseSystemPasswordChar
        sender.IconChar = If(PasswordTXT.UseSystemPasswordChar = False, FontAwesome.Sharp.IconChar.EyeSlash, FontAwesome.Sharp.IconChar.Eye)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        NewPassTXT.UseSystemPasswordChar = Not NewPassTXT.UseSystemPasswordChar
        sender.IconChar = If(NewPassTXT.UseSystemPasswordChar = False, FontAwesome.Sharp.IconChar.EyeSlash, FontAwesome.Sharp.IconChar.Eye)

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ConfirmPassTXT.UseSystemPasswordChar = Not ConfirmPassTXT.UseSystemPasswordChar
        sender.IconChar = If(ConfirmPassTXT.UseSystemPasswordChar = False, FontAwesome.Sharp.IconChar.EyeSlash, FontAwesome.Sharp.IconChar.Eye)

    End Sub
End Class