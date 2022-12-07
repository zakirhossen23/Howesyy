<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.img = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IconMenuItem1 = New FontAwesome.Sharp.IconMenuItem()
        Me.AddToBookmarksToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.ViewBookmarksToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ButtonX3)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ButtonX2)
        Me.Panel1.Controls.Add(Me.img)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 320)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Button1.Location = New System.Drawing.Point(684, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 24)
        Me.Button1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Go"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX3.Location = New System.Drawing.Point(655, 6)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(29, 24)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolSize = 15.0!
        Me.ButtonX3.TabIndex = 5
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(73, 6)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(29, 24)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 15.0!
        Me.ButtonX1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Blue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(128, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(492, 24)
        Me.TextBox1.TabIndex = 8
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX2.Location = New System.Drawing.Point(43, 6)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(30, 24)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolSize = 15.0!
        Me.ButtonX2.TabIndex = 3
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.Blue
        Me.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img.BorderRadius = 5
        Me.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img.Location = New System.Drawing.Point(103, 6)
        Me.img.Name = "img"
        Me.img.ShadowDecoration.Parent = Me.img
        Me.img.Size = New System.Drawing.Size(26, 24)
        Me.img.TabIndex = 44
        Me.img.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Button5.Location = New System.Drawing.Point(3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 26)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "+"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 307)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(716, 13)
        Me.ProgressBar1.TabIndex = 32
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(10, 10)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IconMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(614, 4)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(44, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IconMenuItem1
        '
        Me.IconMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.IconMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToBookmarksToolStripMenuItem, Me.ViewBookmarksToolStripMenuItem})
        Me.IconMenuItem1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.StarHalfAlt
        Me.IconMenuItem1.IconColor = System.Drawing.Color.Yellow
        Me.IconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMenuItem1.IconSize = 25
        Me.IconMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.IconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IconMenuItem1.ImageTransparentColor = System.Drawing.Color.Red
        Me.IconMenuItem1.Name = "IconMenuItem1"
        Me.IconMenuItem1.Rotation = 0R
        Me.IconMenuItem1.Size = New System.Drawing.Size(37, 28)
        '
        'AddToBookmarksToolStripMenuItem
        '
        Me.AddToBookmarksToolStripMenuItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.AddToBookmarksToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.AddToBookmarksToolStripMenuItem.IconColor = System.Drawing.Color.Black
        Me.AddToBookmarksToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddToBookmarksToolStripMenuItem.IconSize = 16
        Me.AddToBookmarksToolStripMenuItem.Name = "AddToBookmarksToolStripMenuItem"
        Me.AddToBookmarksToolStripMenuItem.Rotation = 0R
        Me.AddToBookmarksToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddToBookmarksToolStripMenuItem.Text = "Add to Bookmarks"
        '
        'ViewBookmarksToolStripMenuItem
        '
        Me.ViewBookmarksToolStripMenuItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ViewBookmarksToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ViewBookmarksToolStripMenuItem.IconColor = System.Drawing.Color.Black
        Me.ViewBookmarksToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ViewBookmarksToolStripMenuItem.IconSize = 16
        Me.ViewBookmarksToolStripMenuItem.Name = "ViewBookmarksToolStripMenuItem"
        Me.ViewBookmarksToolStripMenuItem.Rotation = 0R
        Me.ViewBookmarksToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ViewBookmarksToolStripMenuItem.Text = "View Bookmarks"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 18
        Me.Panel2.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(22, 100)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(142, 38)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Home"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.AntiAlias = True
        Me.TabControl1.AutoCloseTabs = True
        Me.TabControl1.BackColor = System.Drawing.Color.White
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.CloseButtonOnTabsVisible = True
        Me.TabControl1.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right
        Me.TabControl1.ColorScheme.NavigationBoxForeColor = System.Drawing.Color.Beige
        Me.TabControl1.ColorScheme.TabBackground = System.Drawing.Color.Blue
        Me.TabControl1.ColorScheme.TabBorder = System.Drawing.SystemColors.Window
        Me.TabControl1.ColorScheme.TabItemBackground = System.Drawing.Color.LawnGreen
        Me.TabControl1.ColorScheme.TabItemSelectedBackground = System.Drawing.SystemColors.Window
        Me.TabControl1.ColorScheme.TabItemSelectedBorder = System.Drawing.SystemColors.ControlLightLight
        Me.TabControl1.ColorScheme.TabItemSelectedBorderDark = System.Drawing.Color.Gainsboro
        Me.TabControl1.ColorScheme.TabItemSelectedBorderLight = System.Drawing.Color.Black
        Me.TabControl1.ColorScheme.TabItemSeparator = System.Drawing.Color.Black
        Me.TabControl1.ColorScheme.TabItemText = System.Drawing.Color.Black
        Me.TabControl1.ColorScheme.TabPanelBackground2 = System.Drawing.Color.Wheat
        Me.TabControl1.ColorScheme.TabPanelBorder = System.Drawing.Color.SlateBlue
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.FixedTabSize = New System.Drawing.Size(200, -8)
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(3, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(710, 272)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005
        Me.TabControl1.TabIndex = 35
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl2"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(710, 245)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.LawnGreen
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.Wheat
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.SlateBlue
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "New Tab"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(716, 35)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.LabelX2)
        Me.Panel3.Controls.Add(Me.LabelX1)
        Me.Panel3.Location = New System.Drawing.Point(200, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(680, 35)
        Me.Panel3.TabIndex = 1
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.LabelX2.Location = New System.Drawing.Point(319, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(353, 29)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "● <font color=""#FFFFFF"">Dow Jones Industrial Average (DJIA) 28586.90 </font><font" &
    " color=""#22B14C"">▲ 161.39 0.57%</font>"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(310, 29)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "● Nikkei 225 Index (NIKKEI) 23619.69 <font color=""#ED1C24"">▼ 27.38 0.12% </font>"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 355)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminHome"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IconMenuItem1 As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents AddToBookmarksToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ViewBookmarksToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents img As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Private WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Private WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Private WithEvents Button1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
