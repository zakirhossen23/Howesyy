Imports DevComponents.DotNetBar

Public Class Homenormalwebbrowser

    Private Property SuperTabControlPanel As SuperTabControlPanel

    Private Sub SideNavItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Homenormalwebbrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Displaytab(TabNoramBrowser, Me.TabControl1.SelectedTab)
        'Displaysupertab(TabNoramBrowser, SuperTabControlPanel1)
        'Dim page As New TabPage
        'Dim t As New TabNoramBrowser

        't.Show()
        't.Dock = DockStyle.Fill
        't.TopLevel = False
        'page.Controls.Add(t)
        'TabControl1.TabPages.Add(page)
        'TabControl1.SelectedTab = page

        Dim newtab As TabItem = TabControl2.CreateTab("New Tab")

        Dim t As New TabNoramBrowser
        Dim panel As TabControlPanel = DirectCast(newtab.AttachedControl, TabControlPanel)
        t.Show()
        t.Dock = DockStyle.Fill
        t.TopLevel = False
        panel.Controls.Add(t)
        TabControl2.Controls.Add(panel)
        TabControl2.SelectedTab = newtab
    End Sub

    'Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim page As New TabItem
    '    Dim t As New TabNoramBrowser
    '    't.SubItems.Add(newtab)
    '    t = TabNoramBrowser.Parent
    '    t.Show()
    '    TabNoramBrowser.Dock = DockStyle.Fill
    '    TabNoramBrowser.TopLevel = False
    '    'page.tabs.Add(t)

    '    'Me.SuperTabControl1.Tabs.Add(t)
    '    'If SuperTabControl1.Created = tabAdd Then
    '    '    Dim t = New TabControlPanel
    '    '    Dim newTab = New TabNoramBrowser()
    '    '    newTab.Show()
    '    '    newTab.TopLevel = False
    '    '    newTab.Dock = DockStyle.Fill
    '    '    newTab.Visible = True
    '    '    t.Controls.Add(newTab)
    '    '    SuperTabControl1.CreateTab("New Tab")

    '    '    Dim newCreatedTab = SuperTabControl1.Created - 1
    '    '    SuperTabControl1.SelectedTabIndex = newCreatedTab
    '    'End If

    '    'Displaysupertab(TabNoramBrowser, SuperTabControlPanel1)

    'End Sub

    ''Private Sub Displaysupertab(ByVal TabNoramBrowser As Form, ByVal SuperTabControlPanel1 As SuperTabControlPanel)

    ''    TabNoramBrowser.Width = SuperTabControlPanel1.Width
    ''    TabNoramBrowser.Height = SuperTabControlPanel1.Height
    ''    TabNoramBrowser.TopLevel = False
    ''    TabNoramBrowser.Parent = SuperTabControlPanel1.Parent
    ''    TabNoramBrowser.Dock = DockStyle.Fill
    ''    TabNoramBrowser.Show()
    ''    TabNoramBrowser.BringToFront()
    ''End Sub

    'Private Sub SymbolBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim page As New TabPage
    '    Dim t As New TabNoramBrowser

    '    t.Show()
    '    t.Dock = DockStyle.Fill
    '    t.TopLevel = False
    '    page.Controls.Add(t)
    '    TabControl1.TabPages.Add(page)
    '    TabControl1.SelectedTab = page
    '    't.TopLevel = False
    '    'page.Controls.Add(t)

    '    't.Show()
    '    't = TabNoramBrowser.Parent
    '    't.Dock = DockStyle.Fill
    '    'page.Controls.Add(t)

    '    'TabControl2.SelectedTab.Text = "New Tab"
    'End Sub

    'Private Sub SymbolBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SymbolBox1.BackColor = Color.LightGray
    'End Sub

    'Private Sub SymbolBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SymbolBox1.BackColor = Color.WhiteSmoke
    'End Sub

    Private Sub SymbolBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SymbolBox1.Click

        Dim i As Integer = Enumerable.Range(0, TabControl2.Tabs.Count).Where(Function(x) TabControl2.Tabs(x).Text.Equals("TabPage1")).FirstOrDefault

        'Dim page As New TabPage
        Dim newtab As TabItem = TabControl2.CreateTab("New Tab")

        Dim t As New TabNoramBrowser
        Dim panel As TabControlPanel = DirectCast(newtab.AttachedControl, TabControlPanel)
        t.Show()
        t.Dock = DockStyle.Fill
        t.TopLevel = False

        panel.Controls.Add(t)
        TabControl2.Controls.Add(panel)
        TabControl2.SelectedTab = newtab
        'panel = TabNoramBrowser.Parent
    End Sub

    Private Sub SymbolBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SymbolBox1.MouseEnter
        SymbolBox1.BackColor = Color.LightGray
    End Sub

    Private Sub SymbolBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SymbolBox1.MouseLeave
        SymbolBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Label1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        Button1.PerformClick()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim page As New TabPage
        'Try
        '    If Label1.Text = "Label1" Then
        '        Exit Sub
        '    End If
        'Catch ex As Exception

        'End Try
        'Try
        'If TabControl2.SelectedTab.Text = "New Tab" Then
        '    TabNoramBrowser.Guna2TextBox1.Text = Label1.Text
        '    TabNoramBrowser.AxWebBrowser1.Navigate(TabNoramBrowser.Guna2TextBox1.Text)
        'Else
        'Dim newtab As TabItem = TabControl2.CreateTab("New Tab")

        'Dim t As New TabNoramBrowser
        'Dim panel As TabControlPanel = DirectCast(newtab.AttachedControl, TabControlPanel)
        't.Show()
        't.Dock = DockStyle.Fill
        't.TopLevel = False

        'panel.Controls.Add(t)
        'TabControl2.Controls.Add(panel)
        'TabControl2.SelectedTab = newtab
        
        TabNoramBrowser.Guna2TextBox1.Text = Label1.Text
        'TabNoramBrowser.AxWebBrowser1.Navigate(TabNoramBrowser.Guna2TextBox1.Text)
        'End If

        'Catch ex As Exception

        'End Try
        'panel = TabNoramBrowser.Parent
    End Sub
End Class