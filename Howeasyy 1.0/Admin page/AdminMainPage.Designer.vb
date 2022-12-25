<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMainPage
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
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMainPage))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DashboardPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.WebCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.MobileCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.DesktopCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChildFormPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.IconClickStrip = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.PrifileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginAsUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.SplitContainer = New System.Windows.Forms.Panel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.DashboardBTN = New FontAwesome.Sharp.IconButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.SlideBarTran = New Guna.UI2.WinForms.Guna2Transition()
        Me.DashboardTransition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.CountBackground = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GetPicBack = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TranUp = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.DashboardPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2ShadowPanel3.SuspendLayout()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.IconClickStrip.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel1.Controls.Add(Me.DashboardPanel)
        Me.Guna2Panel1.Controls.Add(Me.ChildFormPanel)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.SplitContainer)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.SlideBarTran.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1280, 720)
        Me.Guna2Panel1.TabIndex = 0
        '
        'DashboardPanel
        '
        Me.DashboardPanel.BackColor = System.Drawing.Color.Black
        Me.DashboardPanel.Controls.Add(Me.Label7)
        Me.DashboardPanel.Controls.Add(Me.Panel1)
        Me.DashboardPanel.CustomBorderColor = System.Drawing.Color.Black
        Me.DashboardPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.SlideBarTran.SetDecoration(Me.DashboardPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.DashboardPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.DashboardPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardPanel.ForeColor = System.Drawing.Color.Gold
        Me.DashboardPanel.Location = New System.Drawing.Point(231, 27)
        Me.DashboardPanel.Name = "DashboardPanel"
        Me.DashboardPanel.ShadowDecoration.Parent = Me.DashboardPanel
        Me.DashboardPanel.Size = New System.Drawing.Size(1049, 693)
        Me.DashboardPanel.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.TranUp.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("MS PGothic", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(404, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(241, 34)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Welcome Back!"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.Guna2ShadowPanel3)
        Me.Panel1.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Panel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.SlideBarTran.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(134, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 161)
        Me.Panel1.TabIndex = 3
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.WebCount)
        Me.Guna2ShadowPanel3.Controls.Add(Me.Label1)
        Me.SlideBarTran.SetDecoration(Me.Guna2ShadowPanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2ShadowPanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2ShadowPanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.Gold
        Me.Guna2ShadowPanel3.ForeColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(529, 2)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.Radius = 8
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(245, 151)
        Me.Guna2ShadowPanel3.TabIndex = 2
        '
        'WebCount
        '
        Me.TranUp.SetDecoration(Me.WebCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.WebCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.WebCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.WebCount.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.WebCount.ForeColor = System.Drawing.Color.Black
        Me.WebCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.WebCount.Location = New System.Drawing.Point(56, 19)
        Me.WebCount.Name = "WebCount"
        Me.WebCount.Size = New System.Drawing.Size(133, 89)
        Me.WebCount.TabIndex = 3
        Me.WebCount.Text = "Loading..."
        Me.WebCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TranUp.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(25, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Web Applications"
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.MobileCount)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label2)
        Me.SlideBarTran.SetDecoration(Me.Guna2ShadowPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2ShadowPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2ShadowPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.Gold
        Me.Guna2ShadowPanel2.ForeColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(268, 2)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.Radius = 8
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(245, 151)
        Me.Guna2ShadowPanel2.TabIndex = 1
        '
        'MobileCount
        '
        Me.TranUp.SetDecoration(Me.MobileCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.MobileCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.MobileCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MobileCount.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.MobileCount.ForeColor = System.Drawing.Color.Black
        Me.MobileCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MobileCount.Location = New System.Drawing.Point(57, 19)
        Me.MobileCount.Name = "MobileCount"
        Me.MobileCount.Size = New System.Drawing.Size(132, 89)
        Me.MobileCount.TabIndex = 2
        Me.MobileCount.Text = "Loading..."
        Me.MobileCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TranUp.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(45, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Mobile Apps"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.DesktopCount)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.SlideBarTran.SetDecoration(Me.Guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2ShadowPanel1.ForeColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(7, 2)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 8
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(245, 151)
        Me.Guna2ShadowPanel1.TabIndex = 0
        '
        'DesktopCount
        '
        Me.TranUp.SetDecoration(Me.DesktopCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.DesktopCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.DesktopCount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DesktopCount.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.DesktopCount.ForeColor = System.Drawing.Color.Black
        Me.DesktopCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DesktopCount.Location = New System.Drawing.Point(46, 19)
        Me.DesktopCount.Name = "DesktopCount"
        Me.DesktopCount.Size = New System.Drawing.Size(131, 89)
        Me.DesktopCount.TabIndex = 1
        Me.DesktopCount.Text = "Loading..."
        Me.DesktopCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TranUp.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Desktop Applications"
        '
        'ChildFormPanel
        '
        Me.ChildFormPanel.CustomBorderColor = System.Drawing.Color.Black
        Me.ChildFormPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.SlideBarTran.SetDecoration(Me.ChildFormPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.ChildFormPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.ChildFormPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChildFormPanel.Location = New System.Drawing.Point(231, 27)
        Me.ChildFormPanel.Name = "ChildFormPanel"
        Me.ChildFormPanel.ShadowDecoration.Parent = Me.ChildFormPanel
        Me.ChildFormPanel.Size = New System.Drawing.Size(1049, 693)
        Me.ChildFormPanel.TabIndex = 2
        Me.ChildFormPanel.Visible = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 1, 2, 2)
        Me.SlideBarTran.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.Gold
        Me.Guna2Panel2.Location = New System.Drawing.Point(231, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1049, 27)
        Me.Guna2Panel2.TabIndex = 1
        '
        'IconClickStrip
        '
        Me.TranUp.SetDecoration(Me.IconClickStrip, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.IconClickStrip, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.IconClickStrip, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconClickStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrifileToolStripMenuItem, Me.LoginAsUserToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.IconClickStrip.Name = "IconClickStrip"
        Me.IconClickStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconClickStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.IconClickStrip.RenderStyle.ColorTable = Nothing
        Me.IconClickStrip.RenderStyle.RoundedEdges = True
        Me.IconClickStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.IconClickStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconClickStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.IconClickStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.IconClickStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.IconClickStrip.Size = New System.Drawing.Size(150, 70)
        '
        'PrifileToolStripMenuItem
        '
        Me.PrifileToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PrifileToolStripMenuItem.Image = Global.Howeasyy.My.Resources.Resources.update_icon
        Me.PrifileToolStripMenuItem.Name = "PrifileToolStripMenuItem"
        Me.PrifileToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PrifileToolStripMenuItem.Text = "Update Profile"
        '
        'LoginAsUserToolStripMenuItem
        '
        Me.LoginAsUserToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.LoginAsUserToolStripMenuItem.Image = Global.Howeasyy.My.Resources.Resources.man_icon
        Me.LoginAsUserToolStripMenuItem.Name = "LoginAsUserToolStripMenuItem"
        Me.LoginAsUserToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LoginAsUserToolStripMenuItem.Text = "Login As User"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogoutToolStripMenuItem.Image = Global.Howeasyy.My.Resources.Resources.New_Logout_Logo
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Animated = True
        Me.Guna2ControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.BorderColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTransition1.SetDecoration(Me.Guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Gold
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(930, 2)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(38, 23)
        Me.Guna2ControlBox3.TabIndex = 5
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.BorderColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTransition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Gold
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(968, 2)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(38, 23)
        Me.Guna2ControlBox2.TabIndex = 4
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTransition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Gold
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1006, 2)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(38, 23)
        Me.Guna2ControlBox1.TabIndex = 3
        '
        'SplitContainer
        '
        Me.SplitContainer.BackColor = System.Drawing.Color.Black
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer.Controls.Add(Me.Guna2GradientPanel1)
        Me.SplitContainer.Controls.Add(Me.Guna2Panel3)
        Me.SlideBarTran.SetDecoration(Me.SplitContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.SplitContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.SplitContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Size = New System.Drawing.Size(231, 720)
        Me.SplitContainer.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.Controls.Add(Me.IconButton2)
        Me.Guna2GradientPanel1.Controls.Add(Me.IconButton3)
        Me.Guna2GradientPanel1.Controls.Add(Me.IconButton1)
        Me.Guna2GradientPanel1.Controls.Add(Me.DashboardBTN)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.SlideBarTran.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 166)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(229, 552)
        Me.Guna2GradientPanel1.TabIndex = 65
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Black
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTransition1.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconButton2.IconColor = System.Drawing.Color.Gold
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.IconButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IconButton2.Location = New System.Drawing.Point(0, 114)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(229, 38)
        Me.IconButton2.TabIndex = 30
        Me.IconButton2.Text = "  Switch to User Mode"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Black
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTransition1.SetDecoration(Me.IconButton3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.IconButton3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.IconButton3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.IconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!)
        Me.IconButton3.ForeColor = System.Drawing.Color.Gold
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.IconButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IconButton3.Location = New System.Drawing.Point(0, 76)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(229, 38)
        Me.IconButton3.TabIndex = 29
        Me.IconButton3.Text = "  Users"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Black
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTransition1.SetDecoration(Me.IconButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.IconButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.IconButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!)
        Me.IconButton1.ForeColor = System.Drawing.Color.Gold
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.IconButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IconButton1.Location = New System.Drawing.Point(0, 38)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(229, 38)
        Me.IconButton1.TabIndex = 26
        Me.IconButton1.Text = "  App Store"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'DashboardBTN
        '
        Me.DashboardBTN.BackColor = System.Drawing.Color.Black
        Me.DashboardBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTransition1.SetDecoration(Me.DashboardBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.DashboardBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.DashboardBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashboardBTN.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.DashboardBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.DashboardBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
        Me.DashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBTN.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!)
        Me.DashboardBTN.ForeColor = System.Drawing.Color.Gold
        Me.DashboardBTN.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.DashboardBTN.IconColor = System.Drawing.Color.White
        Me.DashboardBTN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DashboardBTN.IconSize = 30
        Me.DashboardBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DashboardBTN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DashboardBTN.Location = New System.Drawing.Point(0, 0)
        Me.DashboardBTN.Name = "DashboardBTN"
        Me.DashboardBTN.Size = New System.Drawing.Size(229, 38)
        Me.DashboardBTN.TabIndex = 28
        Me.DashboardBTN.Text = "  Dashboard"
        Me.DashboardBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardBTN.UseVisualStyleBackColor = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.Controls.Add(Me.ButtonX3)
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.SlideBarTran.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Black
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(229, 166)
        Me.Guna2Panel3.TabIndex = 64
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TranUp.SetDecoration(Me.ButtonX3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.ButtonX3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.ButtonX3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.ButtonX3.Location = New System.Drawing.Point(194, 3)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.PopupSide = DevComponents.DotNetBar.ePopupSide.Right
        Me.ButtonX3.Size = New System.Drawing.Size(30, 29)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolColor = System.Drawing.SystemColors.WindowText
        Me.ButtonX3.SymbolSize = 19.0!
        Me.ButtonX3.TabIndex = 62
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.AutoRoundedCorners = True
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox2.BorderRadius = 79
        Me.TranUp.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashboardTransition1.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = Global.Howeasyy.My.Resources.Resources.logo
        Me.Guna2PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(32, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(164, 160)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 103
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'SlideBarTran
        '
        Me.SlideBarTran.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.SlideBarTran.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.SlideBarTran.DefaultAnimation = Animation2
        '
        'DashboardTransition1
        '
        Me.DashboardTransition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.DashboardTransition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.DashboardTransition1.DefaultAnimation = Animation3
        '
        'CountBackground
        '
        Me.CountBackground.WorkerReportsProgress = True
        Me.CountBackground.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15000
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 22
        Me.Guna2Elipse1.TargetControl = Me.Guna2PictureBox2
        '
        'GetPicBack
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Press Right Click"
        '
        'TranUp
        '
        Me.TranUp.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.TranUp.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.TranUp.DefaultAnimation = Animation1
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 15
        '
        'PictureBox1
        '
        Me.DashboardTransition1.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(904, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PictureBox1.ShadowDecoration.Parent = Me.PictureBox1
        Me.PictureBox1.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseTransparentBackground = True
        '
        'AdminMainPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DashboardTransition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SlideBarTran.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TranUp.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Howeasyy.My.Resources.Resources.Howeasyy
        Me.Name = "AdminMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howeasyy 1.0"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.DashboardPanel.ResumeLayout(False)
        Me.DashboardPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel3.PerformLayout()
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.IconClickStrip.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SplitContainer As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents DashboardPanel As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SlideBarTran As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents WebCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MobileCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IconClickStrip As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents PrifileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginAsUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopCount As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents DashboardTransition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents ChildFormPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DashboardBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents CountBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GetPicBack As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TranUp As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
