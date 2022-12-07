Imports System.ComponentModel
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<DefaultEvent("ButtonClick")>
Partial Class DigitalButton
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2MouseStateHandler1 = New Guna.UI2.WinForms.Guna2MouseStateHandler(Me.components)
        Me.CoverButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 51)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Digital Button"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 16
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button6)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(247, 51)
        Me.Guna2Panel1.TabIndex = 27
        '
        'Guna2Button6
        '
        Me.Guna2Button6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button6.CheckedState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button6.CustomBorderColor = System.Drawing.Color.Red
        Me.Guna2Button6.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Guna2Button6.CustomImages.Parent = Me.Guna2Button6
        Me.Guna2Button6.CustomizableEdges.BottomLeft = False
        Me.Guna2Button6.CustomizableEdges.TopLeft = False
        Me.Guna2Button6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Button6.FillColor = System.Drawing.Color.Cyan
        Me.Guna2Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button6.HoverState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Location = New System.Drawing.Point(196, 0)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.Parent = Me.Guna2Button6
        Me.Guna2Button6.Size = New System.Drawing.Size(51, 51)
        Me.Guna2Button6.TabIndex = 25
        Me.Guna2Button6.Text = "➜"
        Me.Guna2Button6.TextOffset = New System.Drawing.Point(-4, 2)
        Me.Guna2Button6.UseTransparentBackground = True
        '
        'Guna2MouseStateHandler1
        '
        '
        'CoverButton
        '
        Me.CoverButton.BackColor = System.Drawing.Color.Transparent
        Me.CoverButton.CheckedState.Parent = Me.CoverButton
        Me.CoverButton.CustomImages.Parent = Me.CoverButton
        Me.CoverButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoverButton.FillColor = System.Drawing.Color.Transparent
        Me.CoverButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CoverButton.ForeColor = System.Drawing.Color.White
        Me.CoverButton.HoverState.Parent = Me.CoverButton
        Me.CoverButton.Location = New System.Drawing.Point(0, 0)
        Me.CoverButton.Name = "CoverButton"
        Me.CoverButton.ShadowDecoration.Parent = Me.CoverButton
        Me.CoverButton.Size = New System.Drawing.Size(247, 51)
        Me.CoverButton.TabIndex = 28
        Me.CoverButton.UseTransparentBackground = True
        '
        'DigitalButton
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CoverButton)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "DigitalButton"
        Me.Size = New System.Drawing.Size(247, 51)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2MouseStateHandler1 As Guna.UI2.WinForms.Guna2MouseStateHandler
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CoverButton As Guna.UI2.WinForms.Guna2Button
End Class
