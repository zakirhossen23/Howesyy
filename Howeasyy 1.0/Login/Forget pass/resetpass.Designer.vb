<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resetpass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resetpass))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxid = New System.Windows.Forms.TextBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Button4)
        Me.Panel1.Controls.Add(Me.TextBoxpass)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 354)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.TextBoxid)
        Me.Panel2.Location = New System.Drawing.Point(225, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 4
        '
        'TextBoxid
        '
        Me.TextBoxid.Location = New System.Drawing.Point(14, 5)
        Me.TextBoxid.Name = "TextBoxid"
        Me.TextBoxid.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxid.TabIndex = 0
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BorderRadius = 21
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.Font = New System.Drawing.Font("Monospac821 BT", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(137, 201)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(145, 45)
        Me.Guna2Button4.TabIndex = 23
        Me.Guna2Button4.Text = "Recover"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BorderRadius = 2
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TextBox2.Location = New System.Drawing.Point(67, 153)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextBox2.PlaceholderText = "Confirm Password"
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.ShadowDecoration.Parent = Me.TextBox2
        Me.TextBox2.Size = New System.Drawing.Size(283, 39)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxpass
        '
        Me.TextBoxpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxpass.BorderRadius = 2
        Me.TextBoxpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxpass.DefaultText = ""
        Me.TextBoxpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxpass.DisabledState.Parent = Me.TextBoxpass
        Me.TextBoxpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxpass.FocusedState.Parent = Me.TextBoxpass
        Me.TextBoxpass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.TextBoxpass.ForeColor = System.Drawing.Color.Black
        Me.TextBoxpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxpass.HoverState.Parent = Me.TextBoxpass
        Me.TextBoxpass.Location = New System.Drawing.Point(67, 108)
        Me.TextBoxpass.Name = "TextBoxpass"
        Me.TextBoxpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxpass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextBoxpass.PlaceholderText = "New Password"
        Me.TextBoxpass.SelectedText = ""
        Me.TextBoxpass.ShadowDecoration.Parent = Me.TextBoxpass
        Me.TextBoxpass.Size = New System.Drawing.Size(283, 39)
        Me.TextBoxpass.TabIndex = 22
        Me.TextBoxpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'resetpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 354)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = My.Resources.Howeasyy
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "resetpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxid As TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBoxpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox2 As Guna.UI2.WinForms.Guna2TextBox
End Class
