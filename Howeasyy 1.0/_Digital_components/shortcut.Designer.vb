<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shortcut
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.img = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Guna2MouseStateHandler1 = New Guna.UI2.WinForms.Guna2MouseStateHandler(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.SystemColors.Control
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(0, 0)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(138, 125)
        Me.IconButton2.TabIndex = 14
        Me.IconButton2.UseVisualStyleBackColor = False
        Me.IconButton2.Visible = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 60
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Gold
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(138, 119)
        Me.Guna2Panel2.TabIndex = 53
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.IconButton1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(128, 109)
        Me.Guna2Panel1.TabIndex = 3
        Me.Guna2Panel1.UseTransparentBackground = True
        '
        'IconButton1
        '
        Me.IconButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.IconButton1.AutoEllipsis = True
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.EllipsisV
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton1.IconSize = 20
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton1.Location = New System.Drawing.Point(117, 6)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(15, 31)
        Me.IconButton1.TabIndex = 54
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.AutoRoundedCorners = True
        Me.Guna2Panel3.BorderRadius = 19
        Me.Guna2Panel3.Controls.Add(Me.img)
        Me.Guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Black
        Me.Guna2Panel3.Location = New System.Drawing.Point(49, 16)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(40, 40)
        Me.Guna2Panel3.TabIndex = 53
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.Transparent
        Me.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img.FillColor = System.Drawing.Color.Transparent
        Me.img.Location = New System.Drawing.Point(8, 10)
        Me.img.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.img.Name = "img"
        Me.img.Padding = New System.Windows.Forms.Padding(1)
        Me.img.ShadowDecoration.Parent = Me.img
        Me.img.Size = New System.Drawing.Size(25, 21)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img.TabIndex = 52
        Me.img.TabStop = False
        Me.img.UseTransparentBackground = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"browserlink1", "browserlink2", "browserlink3", "browserlink4", "browserlink5", "browserlink6", "browserlink7", "browserlink8"})
        Me.ComboBox1.Location = New System.Drawing.Point(14, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 53
        '
        'Guna2MouseStateHandler1
        '
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shortcut
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "shortcut"
        Me.Size = New System.Drawing.Size(138, 119)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents img As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2MouseStateHandler1 As Guna.UI2.WinForms.Guna2MouseStateHandler
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
End Class
