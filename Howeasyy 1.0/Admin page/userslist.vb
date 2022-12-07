Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class userslist
    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)

    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
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

    Sub loadrecord()

        cn.Close()
        GridViewGuna.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select * from login where Name like '%" & SearchTXT.Text & "%'", cn)
        dr = cm.ExecuteReader


        While dr.Read
            Dim Activation As String = "Deactivated"
            If dr.Item("Status") = 1 Then
                Activation = "Activated"
            End If
            GridViewGuna.Rows.Add(dr.Item("Picture"), dr.Item("id").ToString, dr.Item("pass").ToString, dr.Item("Name").ToString, dr.Item("Auto_ID").ToString, Activation, True, True, dr.Item("Serial").ToString)

        End While
        dr.Close()
        cn.Close()
        'For i = 0 To GridViewGuna.Rows.Count - 1
        '    Dim r As DataGridViewRow = GridViewGuna.Rows(i)
        '    r.Height = 50
        'Next
    End Sub
    Private Sub userslist_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection()
        cn.ConnectionString = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
        loadrecord()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RefreshBTN.Click
        OpenExternalAtCenter(Application.StartupPath & "\Howeasyy Loading.exe")

        Try

            loadrecord()
            SearchTXT.Clear()
        Catch ex As Exception

        End Try
        proc.Kill()
    End Sub

    Private Sub GridViewGuna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridViewGuna.CellClick
        Dim row As DataGridViewRow = GridViewGuna.CurrentRow
        If (e.RowIndex = -1) Then
            Return
        End If

        If e.ColumnIndex = 7 Then
            If MsgBox("Are you sure want to Delete?", vbYesNo) = vbYes Then
                Try
                    pass.Text = row.Cells(2).Value.ToString
                    email.Text = row.Cells(1).Value.ToString
                    nametext.Text = row.Cells(3).Value.ToString
                    Auto_ID.Text = row.Cells(4).Value.ToString
                Catch ex As Exception

                End Try
                Auto_ID.Text = row.Cells(4).Value.ToString
                Dim cmd As MySqlCommand
                con.Open()
                Try
                    cmd = con.CreateCommand()
                    cmd.CommandText = "delete from login where Name=@firstname"
                    cmd.Parameters.AddWithValue("@firstname", nametext.Text)
                    cmd.ExecuteNonQuery()
                    RefreshBTN.PerformClick()
                    MsgBox("Successfully Deleted")
                    con.Close()
                Catch ex As Exception

                End Try
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from login where Name=@firstname"
            cmd.Parameters.AddWithValue("@firstname", nametext.Text)
            cmd.ExecuteNonQuery()
            RefreshBTN.PerformClick()
            MsgBox("Successfully Deleted")
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UpdateBTN.Click
        OpenExternalAtCenter(Application.StartupPath & "\Howeasyy Loading.exe")

        Dim row As DataGridViewRow = GridViewGuna.CurrentRow
        Try
            pass.Text = row.Cells(2).Value.ToString
            email.Text = row.Cells(1).Value.ToString
            nametext.Text = row.Cells(3).Value.ToString
            updatesave()
            Try

                loadrecord()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
        proc.Kill()

    End Sub


    Private Sub updatesave()
        Try
            Dim cmd As MySqlCommand
            con.Open()
            Dim ms As New MemoryStream



            cmd = con.CreateCommand()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            cmd.CommandText = "update login set pass=@firstname1,id=@firstname3, Picture=@pic where Name=@firstname2"
            cmd.Parameters.AddWithValue("@firstname1", pass.Text)
            cmd.Parameters.AddWithValue("@firstname3", email.Text)
            cmd.Parameters.AddWithValue("@firstname2", nametext.Text)
            cmd.Parameters.AddWithValue("@pic", ms.ToArray)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Updated.")

        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GridViewGuna_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridViewGuna.CellContentClick
        Dim row As DataGridViewRow = GridViewGuna.CurrentRow
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If e.RowIndex = -1 Then
            Return
        End If

        If e.ColumnIndex = 6 Then
            Dim DetailsUser As New DetailsUser()
            DetailsUser.email = row.Cells(1).Value.ToString
            DetailsUser.serialKey = row.Cells(8).Value.ToString
            DetailsUser.LblName.Text = row.Cells(3).Value.ToString
            DetailsUser.TXT_IDNo.Text = row.Cells(4).Value.ToString
            DetailsUser.SerialKeyTXT.Text = row.Cells(8).Value.ToString
            Dim Activation As Integer = 0
            If row.Cells(5).Value.ToString = "Activated" Then
                Activation = 1
            End If
            DetailsUser.DoActivate(Activation)
            DetailsUser.ShowDialog()

        End If
    End Sub

    Private Sub autoid()
        Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
        Dim command As New MySqlCommand("SELECT * FROM `login` WHERE `Auto_ID` = @id", connection)

        command.Parameters.Add("@id", MySqlDbType.Int64).Value = Auto_ID.Text

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)
            Dim imgByte() As Byte

            If table.Rows.Count > 0 Then
                imgByte = table(0)(4)
                'TextBox1.Text = table(0)(0)

                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Drawing.Image.FromStream(ms)
            Else


            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Auto_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Auto_ID.TextChanged
        autoid()
    End Sub
    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTXT.TextChanged
        Timer1.Stop()
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BackgroundWorker1.WorkerSupportsCancellation = True
        If BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.CancelAsync()
        Else
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CheckForIllegalCrossThreadCalls = False
        loadrecord()
        Timer1.Stop()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class