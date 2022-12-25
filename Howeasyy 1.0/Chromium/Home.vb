Imports CefSharp
Imports CefSharp.WinForms
Imports DevComponents.DotNetBar
Imports System.Net
Imports System.IO
Imports System.ComponentModel
Imports System.Threading.ApartmentState
Imports System.Threading
Imports System.Runtime.CompilerServices

Public Class Home

    Public Shared opened As Boolean
    Dim frm As New browserhome
    Private Delegate Sub CompleteWork()
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        CreateNewTab("")
    End Sub
    Function createTab() As TabItem
        Dim newtab2 As TabItem = TabControl1.CreateTab("New Tab")
        Return newtab2
    End Function
    Public Async Sub CreateNewTab(ByVal link As String)
        ''''''''''✅✅✅✅✅✅✅✅✅✅
        frm = New browserhome
        frm.TopLevel = False
        'If (link IsNot "") Then
        '    frm.TextBox1.Text = link
        '    frm.Guna2Panel1.Visible = False
        '    frm.GoBTN.PerformClick()
        'End If

        frm.BringToFront()

        frm.Show()
        frm.TextBox1.Focus()
        frm.Dock = DockStyle.Fill

        newtab = createTab()

        panel = DirectCast(newtab.AttachedControl, TabControlPanel)
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
    Dim panel As TabControlPanel
    Dim newtab As New TabItem
    Private Sub BackgroundNewTab_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundNewTab.DoWork

        Control.CheckForIllegalCrossThreadCalls = False
        CreateNewTab("")


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''Button5.PerformClick()
        Control.CheckForIllegalCrossThreadCalls = False

        ''''Mainpage.FormCloseWorker.RunWorkerAsync()

    End Sub

End Class