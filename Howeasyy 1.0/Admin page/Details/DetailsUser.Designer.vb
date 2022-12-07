<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsUser
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TrialDayTXT = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.GenereateKeyBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SerialKeyTXT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TXT_IDNo = New System.Windows.Forms.TextBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.DeactivateBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.ActivateBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.TrialDayTXT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TrialDayTXT)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.SaveBTN)
        Me.Panel1.Controls.Add(Me.GenereateKeyBTN)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SerialKeyTXT)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.DeactivateBTN)
        Me.Panel1.Controls.Add(Me.ActivateBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 473)
        Me.Panel1.TabIndex = 0
        '
        'TrialDayTXT
        '
        Me.TrialDayTXT.BackColor = System.Drawing.Color.Transparent
        Me.TrialDayTXT.BorderColor = System.Drawing.Color.Gold
        Me.TrialDayTXT.BorderRadius = 5
        Me.TrialDayTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TrialDayTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TrialDayTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TrialDayTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TrialDayTXT.DisabledState.Parent = Me.TrialDayTXT
        Me.TrialDayTXT.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TrialDayTXT.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.TrialDayTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TrialDayTXT.FocusedState.Parent = Me.TrialDayTXT
        Me.TrialDayTXT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TrialDayTXT.ForeColor = System.Drawing.Color.Black
        Me.TrialDayTXT.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.TrialDayTXT.Location = New System.Drawing.Point(18, 191)
        Me.TrialDayTXT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TrialDayTXT.Name = "TrialDayTXT"
        Me.TrialDayTXT.ShadowDecoration.Parent = Me.TrialDayTXT
        Me.TrialDayTXT.Size = New System.Drawing.Size(94, 44)
        Me.TrialDayTXT.TabIndex = 12
        Me.TrialDayTXT.UpDownButtonFillColor = System.Drawing.Color.Black
        Me.TrialDayTXT.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Trial Days"
        '
        'SaveBTN
        '
        Me.SaveBTN.BackColor = System.Drawing.Color.Transparent
        Me.SaveBTN.BorderColor = System.Drawing.Color.Gold
        Me.SaveBTN.BorderRadius = 5
        Me.SaveBTN.BorderThickness = 3
        Me.SaveBTN.Checked = True
        Me.SaveBTN.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.SaveBTN.CheckedState.FillColor = System.Drawing.Color.GhostWhite
        Me.SaveBTN.CheckedState.Parent = Me.SaveBTN
        Me.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBTN.CustomImages.Parent = Me.SaveBTN
        Me.SaveBTN.FillColor = System.Drawing.Color.Black
        Me.SaveBTN.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.SaveBTN.ForeColor = System.Drawing.Color.Gold
        Me.SaveBTN.HoverState.BorderColor = System.Drawing.Color.Black
        Me.SaveBTN.HoverState.FillColor = System.Drawing.Color.Yellow
        Me.SaveBTN.HoverState.ForeColor = System.Drawing.Color.Black
        Me.SaveBTN.HoverState.Parent = Me.SaveBTN
        Me.SaveBTN.Location = New System.Drawing.Point(332, 406)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.ShadowDecoration.Parent = Me.SaveBTN
        Me.SaveBTN.Size = New System.Drawing.Size(116, 41)
        Me.SaveBTN.TabIndex = 9
        Me.SaveBTN.Text = "Save"
        '
        'GenereateKeyBTN
        '
        Me.GenereateKeyBTN.BackColor = System.Drawing.Color.Transparent
        Me.GenereateKeyBTN.BorderColor = System.Drawing.Color.Transparent
        Me.GenereateKeyBTN.BorderRadius = 5
        Me.GenereateKeyBTN.BorderThickness = 3
        Me.GenereateKeyBTN.CheckedState.Parent = Me.GenereateKeyBTN
        Me.GenereateKeyBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenereateKeyBTN.CustomImages.Parent = Me.GenereateKeyBTN
        Me.GenereateKeyBTN.FillColor = System.Drawing.Color.Gold
        Me.GenereateKeyBTN.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.GenereateKeyBTN.ForeColor = System.Drawing.Color.Black
        Me.GenereateKeyBTN.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.GenereateKeyBTN.HoverState.FillColor = System.Drawing.Color.White
        Me.GenereateKeyBTN.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.GenereateKeyBTN.HoverState.Parent = Me.GenereateKeyBTN
        Me.GenereateKeyBTN.Location = New System.Drawing.Point(354, 293)
        Me.GenereateKeyBTN.Name = "GenereateKeyBTN"
        Me.GenereateKeyBTN.ShadowDecoration.Parent = Me.GenereateKeyBTN
        Me.GenereateKeyBTN.Size = New System.Drawing.Size(94, 41)
        Me.GenereateKeyBTN.TabIndex = 8
        Me.GenereateKeyBTN.Text = "Generate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Serial Key"
        '
        'SerialKeyTXT
        '
        Me.SerialKeyTXT.BorderColor = System.Drawing.Color.Gold
        Me.SerialKeyTXT.BorderRadius = 5
        Me.SerialKeyTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SerialKeyTXT.DefaultText = ""
        Me.SerialKeyTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SerialKeyTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SerialKeyTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SerialKeyTXT.DisabledState.Parent = Me.SerialKeyTXT
        Me.SerialKeyTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SerialKeyTXT.FillColor = System.Drawing.Color.Gainsboro
        Me.SerialKeyTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SerialKeyTXT.FocusedState.Parent = Me.SerialKeyTXT
        Me.SerialKeyTXT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SerialKeyTXT.ForeColor = System.Drawing.Color.Black
        Me.SerialKeyTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SerialKeyTXT.HoverState.Parent = Me.SerialKeyTXT
        Me.SerialKeyTXT.Location = New System.Drawing.Point(16, 292)
        Me.SerialKeyTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.SerialKeyTXT.Name = "SerialKeyTXT"
        Me.SerialKeyTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SerialKeyTXT.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.SerialKeyTXT.PlaceholderText = "Serial Key"
        Me.SerialKeyTXT.ReadOnly = True
        Me.SerialKeyTXT.SelectedText = ""
        Me.SerialKeyTXT.ShadowDecoration.Parent = Me.SerialKeyTXT
        Me.SerialKeyTXT.Size = New System.Drawing.Size(331, 42)
        Me.SerialKeyTXT.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Activation"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TXT_IDNo)
        Me.Panel2.Location = New System.Drawing.Point(3, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 4
        '
        'TXT_IDNo
        '
        Me.TXT_IDNo.Location = New System.Drawing.Point(25, 5)
        Me.TXT_IDNo.Name = "TXT_IDNo"
        Me.TXT_IDNo.Size = New System.Drawing.Size(72, 26)
        Me.TXT_IDNo.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox1.CustomIconSize = 20.0!
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Gold
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(423, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(35, 23)
        Me.Guna2ControlBox1.TabIndex = 3
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.LblName.Location = New System.Drawing.Point(12, 9)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(77, 31)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Name"
        '
        'DeactivateBTN
        '
        Me.DeactivateBTN.BackColor = System.Drawing.Color.Transparent
        Me.DeactivateBTN.BorderColor = System.Drawing.Color.Transparent
        Me.DeactivateBTN.BorderRadius = 5
        Me.DeactivateBTN.BorderThickness = 3
        Me.DeactivateBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.DeactivateBTN.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.DeactivateBTN.CheckedState.FillColor = System.Drawing.Color.GhostWhite
        Me.DeactivateBTN.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.DeactivateBTN.CheckedState.Parent = Me.DeactivateBTN
        Me.DeactivateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeactivateBTN.CustomImages.Parent = Me.DeactivateBTN
        Me.DeactivateBTN.FillColor = System.Drawing.Color.Gold
        Me.DeactivateBTN.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.DeactivateBTN.ForeColor = System.Drawing.Color.Black
        Me.DeactivateBTN.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.DeactivateBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DeactivateBTN.HoverState.ForeColor = System.Drawing.Color.Black
        Me.DeactivateBTN.HoverState.Parent = Me.DeactivateBTN
        Me.DeactivateBTN.Location = New System.Drawing.Point(126, 99)
        Me.DeactivateBTN.Name = "DeactivateBTN"
        Me.DeactivateBTN.ShadowDecoration.Parent = Me.DeactivateBTN
        Me.DeactivateBTN.Size = New System.Drawing.Size(100, 41)
        Me.DeactivateBTN.TabIndex = 1
        Me.DeactivateBTN.Text = "Deactivated"
        '
        'ActivateBTN
        '
        Me.ActivateBTN.BackColor = System.Drawing.Color.Transparent
        Me.ActivateBTN.BorderColor = System.Drawing.Color.Transparent
        Me.ActivateBTN.BorderRadius = 5
        Me.ActivateBTN.BorderThickness = 3
        Me.ActivateBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ActivateBTN.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ActivateBTN.CheckedState.FillColor = System.Drawing.Color.GhostWhite
        Me.ActivateBTN.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.ActivateBTN.CheckedState.Parent = Me.ActivateBTN
        Me.ActivateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActivateBTN.CustomImages.Parent = Me.ActivateBTN
        Me.ActivateBTN.FillColor = System.Drawing.Color.Gold
        Me.ActivateBTN.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.ActivateBTN.ForeColor = System.Drawing.Color.Black
        Me.ActivateBTN.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.ActivateBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ActivateBTN.HoverState.ForeColor = System.Drawing.Color.Black
        Me.ActivateBTN.HoverState.Parent = Me.ActivateBTN
        Me.ActivateBTN.Location = New System.Drawing.Point(18, 99)
        Me.ActivateBTN.Name = "ActivateBTN"
        Me.ActivateBTN.ShadowDecoration.Parent = Me.ActivateBTN
        Me.ActivateBTN.Size = New System.Drawing.Size(102, 41)
        Me.ActivateBTN.TabIndex = 0
        Me.ActivateBTN.Text = "Activated"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'DetailsUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DetailsUser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrialDayTXT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ActivateBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents DeactivateBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TXT_IDNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SerialKeyTXT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GenereateKeyBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TrialDayTXT As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
