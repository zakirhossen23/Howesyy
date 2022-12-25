Imports FontAwesome.Sharp
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Net

Public Class Mainpage
    Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)
    Dim comm As MySqlCommand
    Dim datar As MySqlDataReader
    Dim CurrentUser = {New With {
        .id = "",
        .name = "",
        .email = "",
        .pass = "",
        .picture = "",
        .serial = "",
        .status = ""
        }}
    Private Sub AdministratorIdentity()
        If My.Settings.UserStatus = "Admin But User" Then
#Region "Admin but user"
            IconButton13.Visible = True
#End Region
        Else
#Region "User Page Show"
            IconButton13.Visible = False
#End Region
        End If
    End Sub


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

        PictureBox1.Image = Bitmap.FromStream(CType(WebRequest.Create(New Uri($"https://api.howeasyy.com/{CurrentUser(0).picture}")).GetResponse().GetResponseStream(), Stream))
        UsernameLBL.Text = CurrentUser(0).name

        Laodtransition.HideSync(FromLoader, parallel:=True)
        Laodtransition.HideSync(LoadPanel)
        Thread.CurrentThread.Abort()
    End Sub

    Public Sub Mainpage_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        AdministratorIdentity()

        Dim objNewThread As New Thread(AddressOf LoadAll)
        objNewThread.IsBackground = True
        objNewThread.Start()

        LoadPanel.BringToFront()
        Laodtransition.ShowSync(LoadPanel)
        TextBox1.Text = My.Settings.LoginID
        'BackgroundWorker1.RunWorkerAsync()

    End Sub


    Private Sub RadioButton14_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        DisplayForm(userslist, Me.FromHolder)
    End Sub

    'Contructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 40)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public Sub ActivateButton(ByVal senderBtn As Object, ByVal customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.BackColor = Drawing.Color.FromArgb(43, 42, 38)
            currentBtn.Cursor = Cursors.Default
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            ''current Form icon'
        End If
    End Sub
    Public Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Class1.Normal_BackColor
            currentBtn.ForeColor = Class1.Normal_ForeColor
            currentBtn.IconColor = Color.Silver
            currentBtn.Enabled = True
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Formtext As New TextBox
    Private Sub IconButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BrowserBTN.Click


        ActivateButton(sender, Class1.color1)


        DisplayForm(Home, Me.FromHolder)
        Status.AddStatus("Home")
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs)

        Try
            FromOpenWorker.RunWorkerAsync()

            ActivateButton(sender, Class1.color1)
        Catch ex As Exception

        End Try
        Threading.Thread.Sleep(500)

        DisplayForm(Adminmain, Me.FromHolder)

        Status.AddStatus("Administrator App store")
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles AppStoreBTN.Click

        Try
            FromOpenWorker.RunWorkerAsync()
            ActivateButton(sender, Class1.color1)
        Catch ex As Exception

        End Try

        DisplayForm(FlowMain, Me.FromHolder)


        Status.AddStatus("App store")
    End Sub


    Private Sub IconButton13_Click(sender As Object, e As EventArgs) Handles IconButton13.Click
        My.Settings.UserStatus = "Admin"
        My.Settings.Save()

        Process.Start(Application.StartupPath & "\" & "Howeasyy 1.0.exe")

        Status.AddStatus("Administrative Area")
        Application.Exit()
        Me.Refresh()


    End Sub

    Private Sub IconButton14_Click(sender As Object, e As EventArgs) Handles LogoutBTN.Click, LogoutToolStripMenuItem.Click
        My.Settings.MainpageOpen = "Logout"
        My.Settings.LoginID = ""
        My.Settings.Save()


        Process.Start(Application.StartupPath & "\" & "Howeasyy 1.0.exe")

        Status.AddStatus("Logout")
        Application.Exit()
        Me.Refresh()

    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBTN.Click
        DisplayForm(New Editprofile, Me.FromHolder)
        Status.AddStatus("Update Profile")
    End Sub

    Private Sub getimagebyautoid()
        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim command As New MySqlCommand("SELECT * FROM `login` WHERE `Auto_ID` = @idd", connection)
        command.CommandTimeout = 13000
        command.Parameters.Add("@idd", MySqlDbType.Int64).Value = TextBox1.Text

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)
            Dim imgByte() As Byte

            If table.Rows.Count > 0 Then
                imgByte = table(0)(4)
                UsernameLBL.Text = table(0)(2)
                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)
            Else

            End If

        Catch ex As Exception
            PictureBox1.Image = Nothing
            MessageBox.Show("An error orchard! Please try again.")
            LogoutBTN.PerformClick()
            BackgroundWorker1.CancelAsync()
        End Try

    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        getimagebyautoid()

    End Sub


    Private Sub IconButton11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            FromOpenWorker.RunWorkerAsync()
            ActivateButton(sender, Class1.color1)
        Catch ex As Exception

        End Try


        DisplayForm(AdminHome, Me.FromHolder)
        Status.AddStatus("Administrator Browser")
    End Sub


    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click

        If Panel7.Size.Width = 300 Then
            Timer1.Enabled = True
            Timer1.Start()
        ElseIf Panel7.Size.Width = 40 Then
            Timer2.Enabled = True
            Timer2.Start()
        End If


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Panel7.Size.Width = 40 Then
            Timer1.Enabled = False
            Timer1.Stop()
            For index As Integer = 0 To PanelMenu.Controls.Count() - 1
                If (TypeOf PanelMenu.Controls(index) Is IconButton) Then
                    Dim control As IconButton = PanelMenu.Controls(index)
                    control.Padding = New Padding(3, 0, 0, 0)
                    control.IconSize = 30
                End If
            Next
        Else
            Panel7.Width = Panel7.Width - 10
        End If



    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Panel7.Size.Width = 300 Then
            Timer2.Enabled = False
            Timer2.Stop()
            For index As Integer = 0 To PanelMenu.Controls.Count() - 1
                If (TypeOf PanelMenu.Controls(index) Is IconButton) Then
                    Dim control As IconButton = PanelMenu.Controls(index)
                    If (control.Name = "LogoutBTN") Then
                        control.Padding = New Padding(20, 0, 0, 0)
                        control.IconSize = 20
                    Else
                        control.Padding = New Padding(25, 0, 0, 0)
                        control.IconSize = 25
                    End If

                End If
            Next
        Else
            Panel7.Width = Panel7.Width + 10
        End If



    End Sub

    Private Sub Guna2ControlBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub IconButton15_Click(sender As Object, e As EventArgs) Handles IconButton15.Click, DeveloperAreaToolStripMenuItem.Click
        Try
            FromOpenWorker.RunWorkerAsync()
            ActivateButton(sender, Class1.color1)
        Catch ex As Exception

        End Try


        Status.AddStatus("Developer Area")
    End Sub

    Private Sub IconButton16_Click(sender As Object, e As EventArgs) Handles IconButton16.Click, RecorderToolStripMenuItem.Click
        recordersettings.Show()

        Status.AddStatus("Recorder")
    End Sub

    Private Sub IconButton17_Click(sender As Object, e As EventArgs) Handles IconButton17.Click, HoweasyyAIToolStripMenuItem.Click
        Assistanttransition.ShowSync(HoweasyyAi)

        Status.AddStatus("Assistant")
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles FromHolder.Paint

    End Sub
    Dim InitialMouseDownLocation As Point
    Private Sub SaveAppStoreCommands()
        comm = New MySqlCommand("Select buy, Name from web ", connection)
        connection.Open()
        datar = comm.ExecuteReader
        Dim AllName As List(Of String) = New List(Of String)
        Dim AllLinks As List(Of String) = New List(Of String)

        While datar.Read
            AllName.Add(datar.Item("Name").ToString())
            AllLinks.Add(datar.Item("buy").ToString())
        End While
        Using w As New StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/webApps.csv")
            For index = 0 To AllName.Count - 1
                Dim line As String = $"{AllName(index)},{AllLinks(index)}"
                w.WriteLine(line)
                w.Flush()
            Next
        End Using
        connection.Close()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        getimagebyautoid()
        SaveAppStoreCommands()

        Laodtransition.HideSync(LoadPanel)
        Laodtransition.HideSync(FromLoader)
        Try
            BackgroundWorker1.CancelAsync()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs)
        Try
            FromOpenWorker.CancelAsync()
            FormCloseWorker.RunWorkerAsync()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FromOpen()
        FromOpenTransition.HideSync(FromLoader)
        FromOpenTransition.HideSync(FromHolder)
        FromOpenTransition.ShowSync(FromLoader)
        Threading.Thread.Sleep(1500)

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\" & "Howeasyy 1.0.exe")
        Application.Exit()
    End Sub

    Private Sub FormCloseWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FormCloseWorker.DoWork

        FromOpenTransition.HideSync(FromLoader)
        FromOpenTransition.ShowSync(FromHolder)
        FormCloseWorker.CancelAsync()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        MsgBox(Status.Allstatus.Count)
    End Sub

    Private Sub Guna2ControlBox6_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox6.Click
        My.Settings.MainpageOpen = ""
        My.Settings.Save()
        Application.Exit()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub IconButton14_MouseHover(sender As Object, e As EventArgs) Handles LogoutBTN.MouseHover
        LogoutBTN.ForeColor = Color.Red
        LogoutBTN.IconColor = Color.Red
    End Sub

    Private Sub IconButton14_MouseLeave(sender As Object, e As EventArgs) Handles LogoutBTN.MouseLeave
        LogoutBTN.ForeColor = Color.Silver
        LogoutBTN.IconColor = Color.Silver
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub
End Class