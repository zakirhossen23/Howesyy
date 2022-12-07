<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forgotpass
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
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgotpass))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VerifyPanel = New System.Windows.Forms.Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EmailSenderPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelswitch = New Guna.UI2.WinForms.Guna2Transition()
        Me.PanelSwitch2 = New Guna.UI2.WinForms.Guna2Transition()
        Me.RecoveryPanel = New System.Windows.Forms.Panel()
        Me.DigitalButton1 = New Howeasyy.DigitalButton()
        Me.Panel1.SuspendLayout()
        Me.VerifyPanel.SuspendLayout()
        Me.EmailSenderPanel.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.RecoveryPanel)
        Me.Panel1.Controls.Add(Me.EmailSenderPanel)
        Me.Panel1.Controls.Add(Me.VerifyPanel)
        Me.Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.PanelSwitch2.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 437)
        Me.Panel1.TabIndex = 1
        '
        'VerifyPanel
        '
        Me.VerifyPanel.Controls.Add(Me.Guna2Button4)
        Me.VerifyPanel.Controls.Add(Me.TextBox2)
        Me.PanelSwitch2.SetDecoration(Me.VerifyPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.VerifyPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.VerifyPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerifyPanel.Location = New System.Drawing.Point(0, 108)
        Me.VerifyPanel.Name = "VerifyPanel"
        Me.VerifyPanel.Size = New System.Drawing.Size(393, 329)
        Me.VerifyPanel.TabIndex = 22
        Me.VerifyPanel.Visible = False
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BorderRadius = 21
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.PanelSwitch2.SetDecoration(Me.Guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.Guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button4.Font = New System.Drawing.Font("Monospac821 BT", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(125, 186)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(145, 45)
        Me.Guna2Button4.TabIndex = 21
        Me.Guna2Button4.Text = "Submit"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BorderRadius = 2
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelSwitch2.SetDecoration(Me.TextBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.TextBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox2.DefaultText = ""
        Me.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.DisabledState.Parent = Me.TextBox2
        Me.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.FocusedState.Parent = Me.TextBox2
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.HoverState.Parent = Me.TextBox2
        Me.TextBox2.Location = New System.Drawing.Point(55, 138)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextBox2.PlaceholderText = "Verify code"
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.ShadowDecoration.Parent = Me.TextBox2
        Me.TextBox2.Size = New System.Drawing.Size(283, 39)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmailSenderPanel
        '
        Me.EmailSenderPanel.Controls.Add(Me.DigitalButton1)
        Me.EmailSenderPanel.Controls.Add(Me.TextBox1)
        Me.PanelSwitch2.SetDecoration(Me.EmailSenderPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.EmailSenderPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.EmailSenderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailSenderPanel.Location = New System.Drawing.Point(0, 108)
        Me.EmailSenderPanel.Name = "EmailSenderPanel"
        Me.EmailSenderPanel.Size = New System.Drawing.Size(393, 329)
        Me.EmailSenderPanel.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BorderRadius = 2
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelSwitch2.SetDecoration(Me.TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox1.DefaultText = ""
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.Parent = Me.TextBox1
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.FocusedState.Parent = Me.TextBox1
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.HoverState.Parent = Me.TextBox1
        Me.TextBox1.Location = New System.Drawing.Point(49, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.PlaceholderText = "Email"
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
        Me.TextBox1.Size = New System.Drawing.Size(283, 39)
        Me.TextBox1.TabIndex = 18
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoSize = True
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button5)
        Me.PanelSwitch2.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 66)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(393, 42)
        Me.Guna2Panel2.TabIndex = 17
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.BorderRadius = 10
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.PanelSwitch2.SetDecoration(Me.Guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.Guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button5.FillColor = System.Drawing.Color.Black
        Me.Guna2Button5.Font = New System.Drawing.Font("Calibri Light", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Enabled = True
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.Guna2Button5.Size = New System.Drawing.Size(60, 39)
        Me.Guna2Button5.TabIndex = 22
        Me.Guna2Button5.Text = "←"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.PanelSwitch2.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 66)
        Me.Panel2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Panelswitch.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelSwitch2.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Forgot your password?"
        '
        'Panelswitch
        '
        Me.Panelswitch.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Panelswitch.Cursor = Nothing
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
        Me.Panelswitch.DefaultAnimation = Animation2
        '
        'PanelSwitch2
        '
        Me.PanelSwitch2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.PanelSwitch2.Cursor = Nothing
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
        Me.PanelSwitch2.DefaultAnimation = Animation1
        '
        'RecoveryPanel
        '
        Me.PanelSwitch2.SetDecoration(Me.RecoveryPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me.RecoveryPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.RecoveryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecoveryPanel.Location = New System.Drawing.Point(0, 108)
        Me.RecoveryPanel.Name = "RecoveryPanel"
        Me.RecoveryPanel.Size = New System.Drawing.Size(393, 329)
        Me.RecoveryPanel.TabIndex = 23
        Me.RecoveryPanel.Visible = False
        '
        'DigitalButton1
        '
        Me.DigitalButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigitalButton1.BackColor = System.Drawing.Color.White
        Me.DigitalButton1.ButtonIcon = "➜"
        Me.DigitalButton1.ButtonIconHeight = New System.Drawing.Size(45, 51)
        Me.DigitalButton1.ButtonText = "Send Verify Code"
        Me.DigitalButton1.CoverButtonFore = System.Drawing.Color.White
        Me.Panelswitch.SetDecoration(Me.DigitalButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelSwitch2.SetDecoration(Me.DigitalButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DigitalButton1.Location = New System.Drawing.Point(72, 162)
        Me.DigitalButton1.Name = "DigitalButton1"
        Me.DigitalButton1.Size = New System.Drawing.Size(247, 51)
        Me.DigitalButton1.TabIndex = 19
        '
        'Forgotpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 437)
        Me.Controls.Add(Me.Panel1)
        Me.PanelSwitch2.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelswitch.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = My.Resources.Howeasyy
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Forgotpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.VerifyPanel.ResumeLayout(False)
        Me.EmailSenderPanel.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VerifyPanel As Panel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailSenderPanel As Panel
    Friend WithEvents Panelswitch As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelSwitch2 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents DigitalButton1 As DigitalButton
    Friend WithEvents RecoveryPanel As Panel
End Class
