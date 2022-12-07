Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class AdminMainPage
    Dim IDtextbox As New TextBox




#Region "This Form"
    Private Sub AdminMainPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub AdminMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        DashboardBTN.PerformClick()
        CountBackground.RunWorkerAsync()
        IDtextbox.Text = My.Settings.LoginID

    End Sub

#Region "Picture"


#Region "get picture"
    Private Sub getpicture()

        con.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `login` WHERE `Auto_ID` =" & IDtextbox.Text & ";", con)

        Try
            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(table)
            Dim imgByte() As Byte
            If table.Rows.Count > 0 Then
                imgByte = table(0)(4)
                Dim ms As New System.IO.MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                PictureBox1.Image = Nothing
            End If

        Catch ex As Exception
        End Try
        con.Close()
    End Sub
#End Region



#Region "picture background"
    Private Sub GetPicBack_DoWork(sender As Object, e As DoWorkEventArgs) Handles GetPicBack.DoWork
        getpicture()
        Try
            GetPicBack.CancelAsync()
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Picture right click"

    Private Sub PrifileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrifileToolStripMenuItem.Click

        Try

            DisableButton()
        Catch ex As Exception

        End Try
        DashboradClose()

        DisplayForm(New Editprofile, Me.ChildFormPanel)
        proc.Kill()
    End Sub

    Private Sub LoginAsUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginAsUserToolStripMenuItem.Click
        My.Settings.UserStatus = "Admin But User"
        My.Settings.Save()
        Process.Start(Application.StartupPath & "\" & "Howeasyy 1.0.exe")
        Application.Exit()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.MainpageOpen = "Logout"
        My.Settings.LoginID = ""
        My.Settings.Save()


        Process.Start(Application.StartupPath & "\" & "Howeasyy 1.0.exe")

        Application.Exit()
        Me.Refresh()
    End Sub
#End Region

#End Region

#End Region




#Region "Drag Title Form"
    Dim InitialMouseDownLocation As Point

    Private Sub Guna2Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            InitialMouseDownLocation = e.Location
            Cursor.Current = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Guna2Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Guna2Panel2.MouseMove
        If e.Button = MouseButtons.Left Then
            Location = New Point(Location.X - InitialMouseDownLocation.X + e.X, Location.Y - InitialMouseDownLocation.Y + e.Y)
        End If
    End Sub

    Private Sub Guna2Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2Panel2.MouseUp
        Cursor.Current = Cursors.Default
    End Sub

#End Region




#Region "Slide Bar"



#Region "<> btn"


    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click

        If currentBtn IsNot Nothing Then

            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.TopLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If

        If SplitContainer.Width = 45 Then

            SplitContainer.Width = 231
        Else
            SplitContainer.Visible = False

            SplitContainer.Width = 45

            SlideBarTran.ShowSync(SplitContainer)
        End If

    End Sub
#End Region




#Region "Button Click code"


#Region "Color"
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public Sub ActivateButton(ByVal senderBtn As Object, ByVal customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Class1.Pressed_BackColor
            currentBtn.ForeColor = Class1.Pressed_ForeColor
            currentBtn.IconColor = Color.Blue
            currentBtn.Cursor = Cursors.Default
            currentBtn.Enabled = False
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
        End If
    End Sub
    Public Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Class1.Normal_BackColor
            currentBtn.ForeColor = Class1.Normal_ForeColor
            currentBtn.IconColor = Color.White
            currentBtn.Cursor = Cursors.Hand
            currentBtn.Enabled = True
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.TopLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
#End Region

    Public Declare Function MoveWindow Lib "user32" (ByVal hwnd As Int32, ByVal x As Long, ByVal y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal bRepaint As Boolean) As Boolean
#Region "Loading software"
    <DllImport("user32.dll")>
    Public Shared Function MoveWindow(ByVal hWnd As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal bRepaint As Boolean) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowRect(ByVal hWnd As IntPtr, <Out()> ByRef lpRect As RECT) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <StructLayoutAttribute(LayoutKind.Sequential)>
    Private Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure
    Public proc As New System.Diagnostics.Process
    Public Sub OpenExternalAtCenter(ByVal appName As String)

        proc.StartInfo.FileName = appName
        proc.Start()
        proc.WaitForInputIdle(3000)
        Try
            If SetForegroundWindow(proc.MainWindowHandle) Then 'check if there is handle to the window
                Dim rec As RECT 'structure to get size and location 
                If Not proc.MainWindowHandle.Equals(IntPtr.Zero) Then
                    If GetWindowRect(proc.MainWindowHandle, rec) Then
                        Dim WidthSize As Integer = rec.right - rec.left 'Width size
                        Dim HeigthSize As Integer = rec.bottom - rec.top 'Heigth Size
                        'x and y location : divide screen width/3 and heigth/ 3
                        Dim x As Integer = CInt(SystemInformation.WorkingArea.Width / 3)
                        Dim y As Integer = CInt(SystemInformation.WorkingArea.Height / 3)
                        'call MoveWindow ApI to move the windows
                        MoveWindow(proc.MainWindowHandle, x, y, WidthSize, HeigthSize, True)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

#End Region

#End Region



#Region "ChildFormOpen"

#Region "Dashboard Page"
    Private Sub DashboardBTN_Click(sender As Object, e As EventArgs) Handles DashboardBTN.Click
        Try
            ActivateButton(sender, Class1.color1)

        Catch ex As Exception
        End Try
        DashboradOpen()
    End Sub

#Region "Background worker count"
    Dim con As New MySqlConnection("server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy")

#Region "Desktop Counter"
    Private Sub Desktopcounter()
        con.Open()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM uiandux_page ", con)
        Dim i As Integer = cmd.ExecuteScalar()
        cmd = Nothing
        con.Close()
        DesktopCount.Text = i
    End Sub
#End Region
#Region "Mobile Counter"
    Private Sub MobileCounter()
        con.Open()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM mobile ", con)
        Dim i As Integer = cmd.ExecuteScalar()
        cmd = Nothing
        con.Close()
        MobileCount.Text = i
    End Sub
#End Region
#Region "Web Counter"
    Private Sub WebCounter()
        con.Open()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM web ", con)
        Dim i As Integer = cmd.ExecuteScalar()
        cmd = Nothing
        con.Close()
        WebCount.Text = i
    End Sub
#End Region


    Private Sub CountBackground_DoWork(sender As Object, e As DoWorkEventArgs) Handles CountBackground.DoWork
        Desktopcounter()
        MobileCounter()
        WebCounter()
        CountBackground.CancelAsync()

        GetPicBack.RunWorkerAsync()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CountBackground.RunWorkerAsync()
    End Sub
#End Region


#End Region ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Dashboard


#Region "Dashborad Close Open"
    Private Sub DashboradClose()
        OpenExternalAtCenter(Application.StartupPath & "\Howeasyy Loading.exe")

        DashboardTransition1.HideSync(DashboardPanel)
        Threading.Thread.Sleep(100)
        DashboardTransition1.ShowSync(ChildFormPanel)
        Threading.Thread.Sleep(1000)
    End Sub
    Private Sub DashboradOpen()
        DashboardTransition1.HideSync(ChildFormPanel)
        DashboardTransition1.ShowSync(DashboardPanel)
    End Sub

#End Region


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Try
            ActivateButton(sender, Class1.color1)

        Catch ex As Exception

        End Try
        DashboradClose()


        DisplayForm(Adminmain, Me.ChildFormPanel)
        Try
            proc.Kill()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Try
            ActivateButton(sender, Class1.color1)

        Catch ex As Exception

        End Try
        DashboradClose()


        DisplayForm(userslist, Me.ChildFormPanel)
        proc.Kill()
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        My.Settings.UserStatus = "Admin But User"
        My.Settings.Save()
        Process.Start(Application.StartupPath & "\" & "Howeasyy 1.0.exe")
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


#End Region


#End Region

End Class