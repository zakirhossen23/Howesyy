<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminmain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MobileBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.WebBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.DesktopBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1320, 58)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.closebtn)
        Me.Panel2.Location = New System.Drawing.Point(979, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 9
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(28, 9)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(75, 23)
        Me.closebtn.TabIndex = 0
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1320, 446)
        Me.Panel3.TabIndex = 8
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MobileBTN, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.WebBTN, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DesktopBTN, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(471, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(374, 48)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'MobileBTN
        '
        Me.MobileBTN.BorderColor = System.Drawing.Color.Transparent
        Me.MobileBTN.BorderRadius = 5
        Me.MobileBTN.BorderThickness = 1
        Me.MobileBTN.CheckedState.Parent = Me.MobileBTN
        Me.MobileBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MobileBTN.CustomImages.Parent = Me.MobileBTN
        Me.MobileBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MobileBTN.FillColor = System.Drawing.Color.Black
        Me.MobileBTN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MobileBTN.ForeColor = System.Drawing.Color.Aqua
        Me.MobileBTN.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.MobileBTN.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.MobileBTN.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.MobileBTN.HoverState.Parent = Me.MobileBTN
        Me.MobileBTN.Location = New System.Drawing.Point(243, 3)
        Me.MobileBTN.Name = "MobileBTN"
        Me.MobileBTN.ShadowDecoration.Parent = Me.MobileBTN
        Me.MobileBTN.Size = New System.Drawing.Size(128, 42)
        Me.MobileBTN.TabIndex = 19
        Me.MobileBTN.Text = "Mobile"
        '
        'WebBTN
        '
        Me.WebBTN.BorderColor = System.Drawing.Color.Transparent
        Me.WebBTN.BorderRadius = 5
        Me.WebBTN.BorderThickness = 1
        Me.WebBTN.CheckedState.Parent = Me.WebBTN
        Me.WebBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WebBTN.CustomImages.Parent = Me.WebBTN
        Me.WebBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBTN.FillColor = System.Drawing.Color.Black
        Me.WebBTN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.WebBTN.ForeColor = System.Drawing.Color.Aqua
        Me.WebBTN.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.WebBTN.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.WebBTN.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.WebBTN.HoverState.Parent = Me.WebBTN
        Me.WebBTN.Location = New System.Drawing.Point(123, 3)
        Me.WebBTN.Name = "WebBTN"
        Me.WebBTN.ShadowDecoration.Parent = Me.WebBTN
        Me.WebBTN.Size = New System.Drawing.Size(114, 42)
        Me.WebBTN.TabIndex = 18
        Me.WebBTN.Text = "Web"
        '
        'DesktopBTN
        '
        Me.DesktopBTN.BorderColor = System.Drawing.Color.Transparent
        Me.DesktopBTN.BorderRadius = 5
        Me.DesktopBTN.BorderThickness = 1
        Me.DesktopBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.DesktopBTN.CheckedState.Parent = Me.DesktopBTN
        Me.DesktopBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DesktopBTN.CustomImages.Parent = Me.DesktopBTN
        Me.DesktopBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesktopBTN.FillColor = System.Drawing.Color.Black
        Me.DesktopBTN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DesktopBTN.ForeColor = System.Drawing.Color.Aqua
        Me.DesktopBTN.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.DesktopBTN.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.DesktopBTN.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.DesktopBTN.HoverState.Parent = Me.DesktopBTN
        Me.DesktopBTN.Location = New System.Drawing.Point(3, 3)
        Me.DesktopBTN.Name = "DesktopBTN"
        Me.DesktopBTN.ShadowDecoration.Parent = Me.DesktopBTN
        Me.DesktopBTN.Size = New System.Drawing.Size(114, 42)
        Me.DesktopBTN.TabIndex = 17
        Me.DesktopBTN.Text = "Desktop"
        '
        'Adminmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1320, 504)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Adminmain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MobileBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents WebBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DesktopBTN As Guna.UI2.WinForms.Guna2Button
End Class
