Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.ComponentModel

Public Class Form2
    Private connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
    Dim obj As MySqlDataAdapter
    Dim dta As New DataTable
    Dim complete As New Label
    Public reader As MySqlDataReader
    Public Comman As MySqlCommand
    Public query As String

#Region "MySQL"
    Private Sub login()
        Try
            connection.Close()
        Catch ex As Exception

        End Try


        Try

            Dim Password As String = ""
            Dim IsExist As Boolean = False
            connection.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from login where id='" & TextBox1.Text & "'", connection)
            Dim sdr As MySqlDataReader = cmd.ExecuteReader()

            If sdr.Read() Then
                Password = sdr.GetString(1)
                IsExist = True
            End If

            connection.Close()

            If IsExist Then

                If Cryptography.Decrypt(Password).Equals(TextBox2.Text) Then

                    ''''''
                    complete.Text = "done"

                    ''''''
                    Loading.Prog_In_Timer.Start()
                Else
                    MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    complete.Text = "failed"
                End If
            Else
                complete.Text = "failed"
                MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        connection.Close()


    End Sub
    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)
    Private Sub getusername()

        Dim command As New MySqlCommand("SELECT  `id`,`pass`,`Name`,`Auto_ID` FROM `login` WHERE `id` = @iD", connection)
        command.Parameters.Add("@iD", MySqlDbType.Text).Value = TextBox1.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()


        Try

            adapter.Fill(table)


            If table.Rows.Count > 0 Then
                'TextBox3.Text = table(0)(2)
                TextBox4.Text = table(0)(3)

            Else

            End If

        Catch ex As Exception
        End Try
    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False

#Region "Settings Remember checkbox"
        If CheckBox1.Checked = True Then
            My.Settings.Email = TextBox1.Text
            My.Settings.Password = TextBox2.Text
            My.Settings.Remember = True
            My.Settings.Save()
        Else

            My.Settings.Remember = False
        End If
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

#Region "Started Working"
        With LoadPanel
            .BringToFront()
            .BringToFront()
            .BringToFront()
            .BringToFront()
        End With
        LoadingTransition.ShowSync(LoadPanel)

        Threading.Thread.Sleep(1000)
        BackgroundWorker1.RunWorkerAsync()
#End Region


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        slideTransition.HideSync(Panel3)
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

    Private Sub loginclick()

        getusername()

        If TextBox1.Text = "sales@howeasyy.com" Then
            Mainpage.IconButton13.Visible = True
            Mainpage.IconButton15.Visible = True

            login()
            Mainpage.BrowserBTN.PerformClick()

        ElseIf TextBox1.Text = "zakirhoss12345@gmail.com" Then

            Mainpage.IconButton13.Visible = True
            Mainpage.IconButton15.Visible = True

            login()


        Else
            Mainpage.IconButton13.Visible = False
            Mainpage.IconButton15.Visible = False

            login()
            Mainpage.BrowserBTN.PerformClick()
        End If
        If complete.Text = "done" Then

            If CheckBox1.Checked = True Then
            Else
                loadclear()
            End If

            Loading.Prog_In_Timer.Start()
            Me.Hide()
            Loading.ShowDialog()

            Button1.Enabled = True
            ButtonX1.PerformClick()
            Try
                BackgroundWorker1.CancelAsync()
            Catch ex As Exception

            End Try


        Else

            ButtonX1.PerformClick()
            Try
                BackgroundWorker1.CancelAsync()
            Catch ex As Exception

            End Try

            Button1.Enabled = True
        End If

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

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        LoadingTransition.HideSync(LoadPanel)
        Button1.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        loginclick()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        My.Settings.LoginID = TextBox4.Text
        My.Settings.Save()
        'MsgBox(My.Settings.LoginID)
    End Sub
End Class