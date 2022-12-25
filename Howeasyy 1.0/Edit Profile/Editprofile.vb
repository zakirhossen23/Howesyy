#Disable Warning BC42017 ' Late bound resolution
#Disable Warning BC42016 ' Implicit conversion
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Threading
Imports System.Net
Imports Guna.UI2.WinForms
Imports Microsoft.Win32
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading.Tasks
Imports CefSharp.DevTools.Cast
Imports Org.BouncyCastle.Asn1.Crmf
Imports RestSharp
Imports CefSharp

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

    Dim selectedPath As String = ""
    Dim selectedName As String = ""
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
        Guna2Panel2.UseTransparentBackground = False
        Guna2Panel2.UseTransparentBackground = True
        Thread.CurrentThread.Abort()
    End Sub


    Private Sub Editprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

        Dim objNewThread As New Thread(AddressOf LoadAll)
        objNewThread.IsBackground = True
        objNewThread.Start()


    End Sub

    Private Async Function updateimage() As Task(Of String)
        If (Not selectedPath.Equals("")) Then
            Dim httpClient = New HttpClient()
            Dim request = New HttpRequestMessage(New HttpMethod("POST"), "https://api.howeasyy.com/upload_image")
            Dim MultipartContent = New MultipartFormDataContent()
            MultipartContent.Add(New ByteArrayContent(File.ReadAllBytes(selectedPath)), "image_file", selectedName)
            request.Content = MultipartContent
            Dim response = Await httpClient.SendAsync(request)
            Dim body = Await response.Content.ReadAsStringAsync()
            Console.WriteLine(body)
            selectedName = ""
            selectedPath = ""
            Return body
        End If
        Return CurrentUser(0).picture
    End Function

    Private Sub Guna2Panel2_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click, Guna2Panel2.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.JPEG;*.PNG;)|*.jpg;*.jpeg;*.png;"
        opf.ShowDialog()
        If opf.FileNames.Length > 0 Then
            selectedName = opf.SafeFileName
            selectedPath = opf.FileName
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

            Dim pictureurl = Await updateimage()

            If NewPassTXT.Text = "" Then
                NewPassTXT.Text = Cryptography.Decrypt(CurrentUser(0).pass)
            End If
            Dim Password As String = Cryptography.Encrypt(NewPassTXT.Text.ToString())
            NewPassTXT.Text = ""
            Dim allFields = New Dictionary(Of String, Object) From {
            {"name", NameTXT.Text},
            {"pass", Password},
            {"picture", pictureurl}
            }

            Dim sqlQuery As String = Request.UpdateQueryMaker("users", allFields, "id", CurrentUser(0).id)

            Await Request.PostAsync(sqlQuery)
            UpadateBTN.Enabled = True
        End If
        Dim mainpage As Mainpage = ParentForm
        Await mainpage.LoadAll()

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