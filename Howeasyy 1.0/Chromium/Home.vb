Imports CefSharp
Imports CefSharp.WinForms
Imports DevComponents.DotNetBar
Imports System.Net
Imports System.IO
Imports System.ComponentModel
Imports System.Threading.ApartmentState
Public Class Home

    Public Shared opened As Boolean

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click, Button5.Click

        CreateNewTab("")
        Status.AddStatus("Home - Create tab")
    End Sub
    Function createTab() As TabItem
        Dim newtab As TabItem = TabControl1.CreateTab("New Tab")
        Return newtab
    End Function
    Public Sub CreateNewTab(ByVal link As String)
        ''''''''''✅✅✅✅✅✅✅✅✅✅

        Dim newtab As TabItem = createTab()
        Dim panel As New TabControlPanel
        panel = DirectCast(newtab.AttachedControl, TabControlPanel)

        Dim frm As New browserhome
        frm.TopLevel = False
        If (link IsNot "") Then
            frm.TextBox1.Text = link
            frm.Guna2Panel1.Visible = False
            frm.GoBTN.PerformClick()
        End If

        frm.BringToFront()
        frm.Show()
        frm.TextBox1.Focus()
        frm.Dock = DockStyle.Fill
        panel.Controls.Add(frm)
        TabControl1.SelectedTab = newtab

        opened = True
        '''''✅✅✅✅✅✅✅
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel3.Left -= 10

    End Sub


    Private Sub Panel3_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.LocationChanged
        If Panel3.Left <= -643 Then
            Panel3.Location = New System.Drawing.Point(643, 0)

        End If

    End Sub
    Private Sub BackgroundNewTab_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundNewTab.RunWorkerCompleted
        Dim frm As New browserhome
        frm.TopLevel = False
        frm.BringToFront()
        frm.Show()
        frm.Dock = DockStyle.Fill
        panel.Controls.Add(frm)
        BackgroundNewTab.CancelAsync()

    End Sub

    Dim newtab As New TabItem
    Dim panel As New TabControlPanel
    Private Sub BackgroundNewTab_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundNewTab.DoWork

        Control.CheckForIllegalCrossThreadCalls = False

        If Me.InvokeRequired Then
            Me.BeginInvoke(CType(Function()
                                     newtab = TabControl1.CreateTab("New Tab")

                                     panel = DirectCast(newtab.AttachedControl, TabControlPanel)
                                     TabControl1.SelectedTab = newtab
                                     Return 0
                                 End Function, MethodInvoker))
        Else
            newtab = TabControl1.CreateTab("New Tab")
            panel = DirectCast(newtab.AttachedControl, TabControlPanel)
        End If


        MessageBoxEx.Show("Starting")


    End Sub

    <Obsolete>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''Button5.PerformClick()
        Control.CheckForIllegalCrossThreadCalls = False
        Threading.Thread.CurrentThread.ApartmentState = Threading.ApartmentState.STA

        ''''Mainpage.FormCloseWorker.RunWorkerAsync()

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub LabelX2_Click(sender As Object, e As EventArgs) Handles LabelX2.Click

    End Sub
End Class