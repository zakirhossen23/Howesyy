<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HeaderTabs
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
		Me.TitleConatiner = New Guna.UI2.WinForms.Guna2Panel()
		Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
		Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
		Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
		Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
		Me.img = New Guna.UI2.WinForms.Guna2PictureBox()
		Me.TitleConatiner.SuspendLayout()
		Me.Guna2Panel2.SuspendLayout()
		Me.Guna2Panel3.SuspendLayout()
		Me.Guna2Panel4.SuspendLayout()
		CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TitleConatiner
		'
		Me.TitleConatiner.BackColor = System.Drawing.Color.Transparent
		Me.TitleConatiner.BorderRadius = 10
		Me.TitleConatiner.Controls.Add(Me.Guna2Panel3)
		Me.TitleConatiner.Controls.Add(Me.Guna2Panel2)
		Me.TitleConatiner.CustomizableEdges.BottomLeft = False
		Me.TitleConatiner.CustomizableEdges.BottomRight = False
		Me.TitleConatiner.Dock = System.Windows.Forms.DockStyle.Left
		Me.TitleConatiner.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.TitleConatiner.Location = New System.Drawing.Point(0, 0)
		Me.TitleConatiner.Name = "TitleConatiner"
		Me.TitleConatiner.ShadowDecoration.Parent = Me.TitleConatiner
		Me.TitleConatiner.Size = New System.Drawing.Size(275, 45)
		Me.TitleConatiner.TabIndex = 0
		'
		'Guna2ControlBox1
		'
		Me.Guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
		Me.Guna2ControlBox1.BorderRadius = 10
		Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
		Me.Guna2ControlBox1.CustomIconSize = 8.0!
		Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
		Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Firebrick
		Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
		Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
		Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
		Me.Guna2ControlBox1.Location = New System.Drawing.Point(6, 12)
		Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
		Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
		Me.Guna2ControlBox1.Size = New System.Drawing.Size(20, 20)
		Me.Guna2ControlBox1.TabIndex = 8
		Me.Guna2ControlBox1.UseTransparentBackground = True
		'
		'Guna2VSeparator1
		'
		Me.Guna2VSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Guna2VSeparator1.BackColor = System.Drawing.Color.Transparent
		Me.Guna2VSeparator1.Location = New System.Drawing.Point(278, 10)
		Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
		Me.Guna2VSeparator1.Size = New System.Drawing.Size(8, 25)
		Me.Guna2VSeparator1.TabIndex = 9
		'
		'Guna2Panel2
		'
		Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
		Me.Guna2Panel2.Controls.Add(Me.Guna2ControlBox1)
		Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
		Me.Guna2Panel2.CustomizableEdges.BottomRight = False
		Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
		Me.Guna2Panel2.Location = New System.Drawing.Point(246, 0)
		Me.Guna2Panel2.Name = "Guna2Panel2"
		Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
		Me.Guna2Panel2.Size = New System.Drawing.Size(29, 45)
		Me.Guna2Panel2.TabIndex = 10
		'
		'Guna2Panel3
		'
		Me.Guna2Panel3.Controls.Add(Me.img)
		Me.Guna2Panel3.Controls.Add(Me.Label1)
		Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
		Me.Guna2Panel3.Name = "Guna2Panel3"
		Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
		Me.Guna2Panel3.Size = New System.Drawing.Size(246, 45)
		Me.Guna2Panel3.TabIndex = 11
		'
		'Label1
		'
		Me.Label1.AutoEllipsis = True
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(30, 14)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 17)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Youtube"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Guna2Panel4
		'
		Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
		Me.Guna2Panel4.Controls.Add(Me.Guna2VSeparator1)
		Me.Guna2Panel4.Controls.Add(Me.TitleConatiner)
		Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Guna2Panel4.Name = "Guna2Panel4"
		Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
		Me.Guna2Panel4.Size = New System.Drawing.Size(296, 45)
		Me.Guna2Panel4.TabIndex = 10
		'
		'img
		'
		Me.img.AutoRoundedCorners = True
		Me.img.BackColor = System.Drawing.Color.Transparent
		Me.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.img.BorderRadius = 9
		Me.img.FillColor = System.Drawing.Color.Black
		Me.img.Image = Global.Howeasyy.My.Resources.Resources.interneticon
		Me.img.Location = New System.Drawing.Point(6, 13)
		Me.img.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
		Me.img.Name = "img"
		Me.img.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.img.ShadowDecoration.Parent = Me.img
		Me.img.Size = New System.Drawing.Size(20, 20)
		Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.img.TabIndex = 51
		Me.img.TabStop = False
		Me.img.UseTransparentBackground = True
		'
		'HeaderTabs
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Transparent
		Me.Controls.Add(Me.Guna2Panel4)
		Me.Name = "HeaderTabs"
		Me.Size = New System.Drawing.Size(296, 45)
		Me.TitleConatiner.ResumeLayout(False)
		Me.Guna2Panel2.ResumeLayout(False)
		Me.Guna2Panel3.ResumeLayout(False)
		Me.Guna2Panel3.PerformLayout()
		Me.Guna2Panel4.ResumeLayout(False)
		CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TitleConatiner As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
	Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
	Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
	Friend WithEvents img As Guna.UI2.WinForms.Guna2PictureBox
End Class
