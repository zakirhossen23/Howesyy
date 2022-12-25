#Disable Warning BC42016 ' Implicit conversion
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports Newtonsoft.Json
Imports System.ComponentModel
Imports System.Threading
Imports Mysqlx.XDevAPI.Common
Imports CefSharp.Web
Imports Chilkat

Public Class Form2
    Public query As String
    Public SerializerSettings As JsonSerializerSettings = New JsonSerializerSettings()

    Private Async Sub Check()

        Dim result() = {New With {
        .id = "",
        .name = "",
        .email = "",
        .pass = "",
        .picture = "",
        .serial = "",
        .status = ""
        }}
        result = Await Request.GetJSONAsync("select * from users where email='" & TextBox1.Text & "'", result)

        If (result.Length > 0) Then
            If Cryptography.Decrypt(result(0).pass).Equals(TextBox2.Text) Then
                My.Settings.LoginID = result(0).id
#Region "Settings Remember checkbox"
                If CheckBox1.Checked = True Then
                    My.Settings.Email = TextBox1.Text
                    My.Settings.Password = TextBox2.Text
                    My.Settings.Remember = True
                Else
                    My.Settings.Remember = False
                End If
                My.Settings.Save()
                My.Settings.Reload()
#End Region

#Region "User Status Checking"
                If TextBox1.Text = "zakirhoss12345@gmail.com" Or TextBox1.Text = "sales@howeasyy.com" Then
                    My.Settings.UserStatus = "Admin"
                    My.Settings.Save()
                Else
                    My.Settings.UserStatus = "User"
                    My.Settings.Save()
                End If
                My.Settings.Reload()
#End Region

                If CheckBox1.Checked = False Then
                    loadclear()
                End If

                Loading.Prog_In_Timer.Start()
                Me.Hide()
                Loading.ShowDialog()

                Button1.Enabled = True
                ButtonX1.PerformClick()
                Thread.CurrentThread.Abort()

            Else
                MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        Button1.Enabled = True


        Thread.CurrentThread.Abort()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Enabled = False

        Dim objNewThread As New Thread(AddressOf Check)
        objNewThread.IsBackground = True
        objNewThread.Start()


#Region "Started Working"
        With LoadPanel
            .BringToFront()
            .BringToFront()
            .BringToFront()
            .BringToFront()
        End With
        LoadingTransition.ShowSync(LoadPanel)
#End Region

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        slideTransition.HideSync(Panel3, parallel:=True)
        Panel5.Visible = False
        DisplayFormwithoutclear(New signup, Panel3)
        SlideTransrev.ShowSync(Panel3)

    End Sub
    Public Sub openslide()
        Me.slideTransition.ShowSync(Panel5)
    End Sub
    Private Sub Form2_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        slideTransition.HideSync(Panel3)
        Panel5.Visible = False
        DisplayFormwithoutclear(forgotpassconnect, Panel3)
        SlideTransrev.ShowSync(Panel3)
    End Sub

    Private Sub loadclear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
#Region "Form Loading"
    Private Sub Form2_FromLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SerializerSettings.Formatting = Formatting.None
        Control.CheckForIllegalCrossThreadCalls = False
#Region "Full Check"

        If My.Settings.LoginID = "" Then
#Region "New Login"

            If My.Settings.Remember = True Then
                TextBox1.Text = My.Settings.Email
                TextBox2.Text = My.Settings.Password
                CheckBox1.Checked = True
            End If
            Try

                InternetCheck.RunWorkerAsync()
                Button1.Enabled = True
                Timer1.Start()
            Catch ex As Exception
            End Try
#End Region
        Else
#Region "Logged IN"
            Me.Hide()

            If My.Settings.UserStatus = "Admin" Then
#Region "Admin Page Show"
                AdminMainPage.ShowDialog()
#End Region
#Region "Admin but user"
            ElseIf My.Settings.UserStatus = "Admin But User" Then
                Mainpage.ShowDialog()
            Else
#End Region
#Region "User Page Show"
                InternetCheck.RunWorkerAsync()
                PanelTransition.ShowSync(PanelsContainer)
                Mainpage.ShowDialog()
#End Region
            End If
#End Region
        End If

#End Region
    End Sub
#End Region
    Public Sub LoginpageReloading()

        If My.Settings.Remember = True Then
            TextBox1.Text = My.Settings.Email
            TextBox2.Text = My.Settings.Password
            CheckBox1.Checked = True
        End If
        Button1.Enabled = True

    End Sub


    Dim internetstatus As Boolean

    Private Sub InternetCheck_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles InternetCheck.DoWork
        System.Threading.Thread.Sleep(1000)
        If My.Computer.Network.IsAvailable Then
            internetstatus = True
        Else
            internetstatus = False

        End If
    End Sub

    Private Sub InternetCheck_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles InternetCheck.RunWorkerCompleted
        If internetstatus = True Then
            Label4.Text = "Online"
            LinkLabel2.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True

            LinkLabel1.Enabled = True
            Label4.ForeColor = Color.LightGreen
        Else
            Label4.Text = "Offline"
            Label4.ForeColor = Color.Red
            LinkLabel2.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False

            LinkLabel1.Enabled = False
        End If
        InternetCheck.RunWorkerAsync()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Else
            TextBox2.UseSystemPasswordChar = True
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            PanelTransition.ShowSync(PanelsContainer)

        Catch ex As Exception

        End Try

        Timer1.Stop()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        LoadingTransition.HideSync(LoadPanel)
        Button1.Enabled = True
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        My.Settings.LoginID = TextBox4.Text
        My.Settings.Save()
        'MsgBox(My.Settings.LoginID)
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class