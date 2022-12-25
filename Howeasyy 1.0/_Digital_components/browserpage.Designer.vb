<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browserpage
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
		Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
		Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(browserpage))
		Me.SearchBTN = New DevComponents.DotNetBar.ButtonX()
		Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
		Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Guna2Transition2 = New Guna.UI2.WinForms.Guna2Transition()
		Me.HomeBTN = New DevComponents.DotNetBar.ButtonX()
		Me.ForwardBTN = New DevComponents.DotNetBar.ButtonX()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.GoBTN = New DevComponents.DotNetBar.ButtonX()
		Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
		Me.BackBTN = New DevComponents.DotNetBar.ButtonX()
		Me.searchtransition = New Guna.UI2.WinForms.Guna2Transition()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
		Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
		Me.img = New Guna.UI2.WinForms.Guna2PictureBox()
		Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
		Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
		Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
		Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Shortcut_1_ = New Howeasyy.shortcut()
		Me.Shortcut_2_ = New Howeasyy.shortcut()
		Me.Shortcut_3_ = New Howeasyy.shortcut()
		Me.Shortcut_4_ = New Howeasyy.shortcut()
		Me.Shortcut_5_ = New Howeasyy.shortcut()
		Me.Shortcut_6_ = New Howeasyy.shortcut()
		Me.Shortcut_7_ = New Howeasyy.shortcut()
		Me.Shortcut_8_ = New Howeasyy.shortcut()
		Me.IconButton2 = New FontAwesome.Sharp.IconButton()
		Me.Guna2Panel3.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Guna2Panel1.SuspendLayout()
		Me.Guna2Panel2.SuspendLayout()
		CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SearchBTN
		'
		Me.SearchBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
		Me.SearchBTN.BackColor = System.Drawing.Color.Gold
		Me.SearchBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
		Me.Guna2Transition1.SetDecoration(Me.SearchBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.SearchBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.SearchBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.SearchBTN.Dock = System.Windows.Forms.DockStyle.Right
		Me.SearchBTN.Location = New System.Drawing.Point(1097, 2)
		Me.SearchBTN.Name = "ButtonX3"
		Me.SearchBTN.Size = New System.Drawing.Size(29, 27)
		Me.SearchBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.SearchBTN.Symbol = ""
		Me.SearchBTN.SymbolColor = System.Drawing.Color.Black
		Me.SearchBTN.SymbolSize = 15.0!
		Me.SearchBTN.TabIndex = 47
		Me.SearchBTN.Tooltip = "Search"
		'
		'Guna2Panel3
		'
		Me.Guna2Panel3.BackColor = System.Drawing.Color.Gold
		Me.Guna2Panel3.BorderColor = System.Drawing.Color.Gray
		Me.Guna2Panel3.BorderRadius = 15
		Me.Guna2Panel3.Controls.Add(Me.TextBox1)
		Me.Guna2Panel3.Controls.Add(Me.img)
		Me.Guna2Transition2.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.Guna2Panel3.ForeColor = System.Drawing.Color.Gold
		Me.Guna2Panel3.Location = New System.Drawing.Point(119, 2)
		Me.Guna2Panel3.Name = "Guna2Panel3"
		Me.Guna2Panel3.Padding = New System.Windows.Forms.Padding(1)
		Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
		Me.Guna2Panel3.Size = New System.Drawing.Size(978, 27)
		Me.Guna2Panel3.TabIndex = 53
		'
		'TextBox1
		'
		Me.TextBox1.Animated = True
		Me.TextBox1.BackColor = System.Drawing.Color.Gold
		Me.TextBox1.BorderColor = System.Drawing.Color.Gold
		Me.TextBox1.BorderThickness = 0
		Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Guna2Transition2.SetDecoration(Me.TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.TextBox1.DefaultText = ""
		Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TextBox1.DisabledState.Parent = Me.TextBox1
		Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBox1.FillColor = System.Drawing.Color.Gold
		Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TextBox1.FocusedState.Parent = Me.TextBox1
		Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.TextBox1.ForeColor = System.Drawing.Color.Black
		Me.TextBox1.HoverState.Parent = Me.TextBox1
		Me.TextBox1.Location = New System.Drawing.Point(28, 1)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TextBox1.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TextBox1.PlaceholderText = "Search Howeasyy or type a url"
		Me.TextBox1.SelectedText = ""
		Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
		Me.TextBox1.Size = New System.Drawing.Size(949, 25)
		Me.TextBox1.TabIndex = 51
		'
		'Guna2Transition2
		'
		Me.Guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate
		Me.Guna2Transition2.Cursor = Nothing
		Animation2.AnimateOnlyDifferences = True
		Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
		Animation2.LeafCoeff = 0!
		Animation2.MaxTime = 1.0!
		Animation2.MinTime = 0!
		Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
		Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
		Animation2.MosaicSize = 0
		Animation2.Padding = New System.Windows.Forms.Padding(30)
		Animation2.RotateCoeff = 0.5!
		Animation2.RotateLimit = 0.2!
		Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
		Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
		Animation2.TimeCoeff = 0!
		Animation2.TransparencyCoeff = 0!
		Me.Guna2Transition2.DefaultAnimation = Animation2
		'
		'HomeBTN
		'
		Me.HomeBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
		Me.HomeBTN.BackColor = System.Drawing.Color.Gold
		Me.HomeBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
		Me.Guna2Transition1.SetDecoration(Me.HomeBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.HomeBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.HomeBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.HomeBTN.Dock = System.Windows.Forms.DockStyle.Left
		Me.HomeBTN.Location = New System.Drawing.Point(90, 2)
		Me.HomeBTN.Name = "ButtonX4"
		Me.HomeBTN.Size = New System.Drawing.Size(29, 27)
		Me.HomeBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.HomeBTN.Symbol = ""
		Me.HomeBTN.SymbolColor = System.Drawing.Color.Black
		Me.HomeBTN.SymbolSize = 15.0!
		Me.HomeBTN.TabIndex = 50
		Me.HomeBTN.Tooltip = "Home"
		'
		'ForwardBTN
		'
		Me.ForwardBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
		Me.ForwardBTN.BackColor = System.Drawing.Color.Gold
		Me.ForwardBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
		Me.Guna2Transition1.SetDecoration(Me.ForwardBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.ForwardBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.ForwardBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.ForwardBTN.Dock = System.Windows.Forms.DockStyle.Left
		Me.ForwardBTN.Location = New System.Drawing.Point(61, 2)
		Me.ForwardBTN.Name = "ButtonX1"
		Me.ForwardBTN.Size = New System.Drawing.Size(29, 27)
		Me.ForwardBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ForwardBTN.Symbol = ""
		Me.ForwardBTN.SymbolColor = System.Drawing.Color.Black
		Me.ForwardBTN.SymbolSize = 15.0!
		Me.ForwardBTN.TabIndex = 46
		Me.ForwardBTN.Tooltip = "Forward"
		'
		'Panel1
		'
		Me.Panel1.AutoSize = True
		Me.Panel1.BackColor = System.Drawing.Color.Gold
		Me.Panel1.Controls.Add(Me.Guna2Panel3)
		Me.Panel1.Controls.Add(Me.HomeBTN)
		Me.Panel1.Controls.Add(Me.SearchBTN)
		Me.Panel1.Controls.Add(Me.ForwardBTN)
		Me.Panel1.Controls.Add(Me.GoBTN)
		Me.Panel1.Controls.Add(Me.ButtonX5)
		Me.Panel1.Controls.Add(Me.BackBTN)
		Me.Guna2Transition2.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
		Me.Panel1.Size = New System.Drawing.Size(1157, 31)
		Me.Panel1.TabIndex = 55
		'
		'GoBTN
		'
		Me.GoBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
		Me.GoBTN.BackColor = System.Drawing.Color.Gold
		Me.GoBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
		Me.Guna2Transition1.SetDecoration(Me.GoBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.GoBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.GoBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.GoBTN.Dock = System.Windows.Forms.DockStyle.Right
		Me.GoBTN.Location = New System.Drawing.Point(1126, 2)
		Me.GoBTN.Name = "Button1"
		Me.GoBTN.Size = New System.Drawing.Size(29, 27)
		Me.GoBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.GoBTN.SymbolColor = System.Drawing.Color.Black
		Me.GoBTN.TabIndex = 48
		Me.GoBTN.Text = "Go"
		Me.GoBTN.TextColor = System.Drawing.Color.Black
		Me.GoBTN.Tooltip = "Instant Url"
		'
		'ButtonX5
		'
		Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
		Me.ButtonX5.BackColor = System.Drawing.Color.Gold
		Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
		Me.Guna2Transition1.SetDecoration(Me.ButtonX5, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.ButtonX5, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.ButtonX5, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.ButtonX5.Dock = System.Windows.Forms.DockStyle.Left
		Me.ButtonX5.Location = New System.Drawing.Point(32, 2)
		Me.ButtonX5.Name = "ButtonX5"
		Me.ButtonX5.Size = New System.Drawing.Size(29, 27)
		Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ButtonX5.SubItemsExpandWidth = 17
		Me.ButtonX5.Symbol = "58837"
		Me.ButtonX5.SymbolColor = System.Drawing.Color.Black
		Me.ButtonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
		Me.ButtonX5.SymbolSize = 15.0!
		Me.ButtonX5.TabIndex = 51
		Me.ButtonX5.Tooltip = "Reload"
		'
		'BackBTN
		'
		Me.BackBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
		Me.BackBTN.BackColor = System.Drawing.Color.Gold
		Me.BackBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
		Me.Guna2Transition1.SetDecoration(Me.BackBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.BackBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.BackBTN, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.BackBTN.Dock = System.Windows.Forms.DockStyle.Left
		Me.BackBTN.Location = New System.Drawing.Point(2, 2)
		Me.BackBTN.Margin = New System.Windows.Forms.Padding(9)
		Me.BackBTN.Name = "ButtonX2"
		Me.BackBTN.Size = New System.Drawing.Size(30, 27)
		Me.BackBTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.BackBTN.Symbol = ""
		Me.BackBTN.SymbolColor = System.Drawing.Color.Black
		Me.BackBTN.SymbolSize = 15.0!
		Me.BackBTN.TabIndex = 45
		Me.BackBTN.Tooltip = "Back"
		'
		'searchtransition
		'
		Me.searchtransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
		Me.searchtransition.Cursor = Nothing
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
		Me.searchtransition.DefaultAnimation = Animation3
		'
		'Guna2Elipse1
		'
		Me.Guna2Elipse1.BorderRadius = 10
		'
		'Guna2Transition1
		'
		Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
		Me.Guna2Transition1.Cursor = Nothing
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
		Me.Guna2Transition1.DefaultAnimation = Animation1
		'
		'img
		'
		Me.img.BackColor = System.Drawing.Color.Transparent
		Me.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.img.BorderRadius = 14
		Me.Guna2Transition1.SetDecoration(Me.img, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.img, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.img, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.img.Dock = System.Windows.Forms.DockStyle.Left
		Me.img.FillColor = System.Drawing.Color.Black
		Me.img.Image = Global.Howeasyy.My.Resources.Resources.interneticon
		Me.img.Location = New System.Drawing.Point(1, 1)
		Me.img.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
		Me.img.Name = "img"
		Me.img.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.img.ShadowDecoration.Parent = Me.img
		Me.img.Size = New System.Drawing.Size(27, 25)
		Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.img.TabIndex = 50
		Me.img.TabStop = False
		Me.img.UseTransparentBackground = True
		'
		'Guna2Panel1
		'
		Me.Guna2Panel1.BackColor = System.Drawing.Color.Black
		Me.Guna2Panel1.Controls.Add(Me.FlowLayoutPanel1)
		Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
		Me.Guna2Panel1.Controls.Add(Me.Label1)
		Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
		Me.Guna2Transition2.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.Custom)
		Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Guna2Panel1.FillColor = System.Drawing.Color.Black
		Me.Guna2Panel1.ForeColor = System.Drawing.Color.Gold
		Me.Guna2Panel1.Location = New System.Drawing.Point(0, 31)
		Me.Guna2Panel1.Name = "Guna2Panel1"
		Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
		Me.Guna2Panel1.Size = New System.Drawing.Size(1157, 507)
		Me.Guna2Panel1.TabIndex = 57
		'
		'Guna2Panel2
		'
		Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
		Me.Guna2Panel2.BorderColor = System.Drawing.Color.Gold
		Me.Guna2Panel2.BorderRadius = 15
		Me.Guna2Panel2.BorderThickness = 2
		Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox1)
		Me.Guna2Panel2.Controls.Add(Me.IconPictureBox1)
		Me.Guna2Transition2.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Panel2.Location = New System.Drawing.Point(347, 221)
		Me.Guna2Panel2.Name = "Guna2Panel2"
		Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(8)
		Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
		Me.Guna2Panel2.Size = New System.Drawing.Size(462, 41)
		Me.Guna2Panel2.TabIndex = 12
		'
		'Guna2TextBox1
		'
		Me.Guna2TextBox1.BorderThickness = 0
		Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Guna2Transition2.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2TextBox1.DefaultText = ""
		Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
		Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Guna2TextBox1.FillColor = System.Drawing.Color.Black
		Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
		Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Gold
		Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
		Me.Guna2TextBox1.Location = New System.Drawing.Point(36, 8)
		Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
		Me.Guna2TextBox1.Name = "Guna2TextBox1"
		Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Guna2TextBox1.PlaceholderText = "Search"
		Me.Guna2TextBox1.SelectedText = ""
		Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
		Me.Guna2TextBox1.Size = New System.Drawing.Size(418, 25)
		Me.Guna2TextBox1.TabIndex = 1
		'
		'IconPictureBox1
		'
		Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.Guna2Transition2.SetDecoration(Me.IconPictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.IconPictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.IconPictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.IconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left
		Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.GrayText
		Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search
		Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.GrayText
		Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
		Me.IconPictureBox1.IconSize = 25
		Me.IconPictureBox1.Location = New System.Drawing.Point(8, 8)
		Me.IconPictureBox1.Name = "IconPictureBox1"
		Me.IconPictureBox1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.IconPictureBox1.Size = New System.Drawing.Size(28, 25)
		Me.IconPictureBox1.TabIndex = 2
		Me.IconPictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(514, 179)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(128, 41)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Howeasyy"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.Guna2Transition1.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.PictureBox1.Image = Global.Howeasyy.My.Resources.Resources.logo
		Me.PictureBox1.Location = New System.Drawing.Point(506, 33)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(150, 143)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_1_)
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_2_)
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_3_)
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_4_)
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_5_)
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_6_)
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_7_)
		Me.FlowLayoutPanel1.Controls.Add(Me.Shortcut_8_)
		Me.FlowLayoutPanel1.Controls.Add(Me.IconButton2)
		Me.Guna2Transition1.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(283, 283)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(591, 195)
		Me.FlowLayoutPanel1.TabIndex = 58
		'
		'Shortcut_1_
		'
		Me.Shortcut_1_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_1_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_1_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_1_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_1_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_1_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_1_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_1_.Name = "Shortcut_1_"
		Me.Shortcut_1_.SelectedText = "0"
		Me.Shortcut_1_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_1_.TabIndex = 14
		Me.Shortcut_1_.urltext = ""
		'
		'Shortcut_2_
		'
		Me.Shortcut_2_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_2_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_2_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_2_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_2_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_2_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_2_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_2_.Name = "Shortcut_2_"
		Me.Shortcut_2_.SelectedText = "1"
		Me.Shortcut_2_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_2_.TabIndex = 15
		Me.Shortcut_2_.urltext = ""
		'
		'Shortcut_3_
		'
		Me.Shortcut_3_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_3_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_3_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_3_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_3_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_3_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_3_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_3_.Name = "Shortcut_3_"
		Me.Shortcut_3_.SelectedText = "2"
		Me.Shortcut_3_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_3_.TabIndex = 16
		Me.Shortcut_3_.urltext = ""
		'
		'Shortcut_4_
		'
		Me.Shortcut_4_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_4_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_4_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_4_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_4_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_4_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_4_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_4_.Name = "Shortcut_4_"
		Me.Shortcut_4_.SelectedText = "3"
		Me.Shortcut_4_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_4_.TabIndex = 17
		Me.Shortcut_4_.urltext = ""
		'
		'Shortcut_5_
		'
		Me.Shortcut_5_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_5_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_5_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_5_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_5_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_5_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_5_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_5_.Name = "Shortcut_5_"
		Me.Shortcut_5_.SelectedText = "4"
		Me.Shortcut_5_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_5_.TabIndex = 18
		Me.Shortcut_5_.urltext = ""
		'
		'Shortcut_6_
		'
		Me.Shortcut_6_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_6_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_6_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_6_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_6_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_6_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_6_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_6_.Name = "Shortcut_6_"
		Me.Shortcut_6_.SelectedText = "5"
		Me.Shortcut_6_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_6_.TabIndex = 19
		Me.Shortcut_6_.urltext = ""
		'
		'Shortcut_7_
		'
		Me.Shortcut_7_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_7_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_7_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_7_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_7_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_7_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_7_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_7_.Name = "Shortcut_7_"
		Me.Shortcut_7_.SelectedText = "6"
		Me.Shortcut_7_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_7_.TabIndex = 20
		Me.Shortcut_7_.urltext = ""
		'
		'Shortcut_8_
		'
		Me.Shortcut_8_.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Shortcut_8_.BackColor = System.Drawing.Color.Transparent
		Me.Shortcut_8_.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.Shortcut_8_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.Shortcut_8_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.Shortcut_8_, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Shortcut_8_.Location = New System.Drawing.Point(3, 3)
		Me.Shortcut_8_.Name = "Shortcut_8_"
		Me.Shortcut_8_.SelectedText = "7"
		Me.Shortcut_8_.Size = New System.Drawing.Size(140, 125)
		Me.Shortcut_8_.TabIndex = 21
		Me.Shortcut_8_.urltext = ""
		'
		'IconButton2
		'
		Me.IconButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.IconButton2.BackColor = System.Drawing.Color.Gold
		Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.searchtransition.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition1.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.IconButton2.FlatAppearance.BorderSize = 0
		Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Plus
		Me.IconButton2.IconColor = System.Drawing.Color.Black
		Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
		Me.IconButton2.Location = New System.Drawing.Point(3, 3)
		Me.IconButton2.Name = "IconButton2"
		Me.IconButton2.Size = New System.Drawing.Size(140, 125)
		Me.IconButton2.TabIndex = 22
		Me.IconButton2.UseVisualStyleBackColor = False
		'
		'browserpage
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Controls.Add(Me.Guna2Panel1)
		Me.Controls.Add(Me.Panel1)
		Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Guna2Transition2.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.searchtransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
		Me.Name = "browserpage"
		Me.Size = New System.Drawing.Size(1157, 538)
		Me.Guna2Panel3.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Guna2Panel1.ResumeLayout(False)
		Me.Guna2Panel1.PerformLayout()
		Me.Guna2Panel2.ResumeLayout(False)
		CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents SearchBTN As DevComponents.DotNetBar.ButtonX
	Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
	Friend WithEvents Guna2Transition2 As Guna.UI2.WinForms.Guna2Transition
	Friend WithEvents searchtransition As Guna.UI2.WinForms.Guna2Transition
	Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
	Friend WithEvents img As Guna.UI2.WinForms.Guna2PictureBox
	Private WithEvents HomeBTN As DevComponents.DotNetBar.ButtonX
	Private WithEvents ForwardBTN As DevComponents.DotNetBar.ButtonX
	Friend WithEvents Panel1 As Panel
	Protected Friend WithEvents GoBTN As DevComponents.DotNetBar.ButtonX
	Private WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
	Private WithEvents BackBTN As DevComponents.DotNetBar.ButtonX
	Friend WithEvents Timer1 As Timer
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
	Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
	Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Shortcut_1_ As shortcut
	Friend WithEvents Shortcut_2_ As shortcut
	Friend WithEvents Shortcut_3_ As shortcut
	Friend WithEvents Shortcut_4_ As shortcut
	Friend WithEvents Shortcut_5_ As shortcut
	Friend WithEvents Shortcut_6_ As shortcut
	Friend WithEvents Shortcut_7_ As shortcut
	Friend WithEvents Shortcut_8_ As shortcut
	Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
