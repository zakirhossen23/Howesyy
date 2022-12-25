<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
		Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
		Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
		Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.BackgroundNewTab = New System.ComponentModel.BackgroundWorker()
		Me.Panel1.SuspendLayout()
		CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel5.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Black
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.TabControl1)
		Me.Panel1.Controls.Add(Me.Panel5)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel1.Location = New System.Drawing.Point(0, 35)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1370, 714)
		Me.Panel1.TabIndex = 1
		'
		'TabControl1
		'
		Me.TabControl1.AntiAlias = True
		Me.TabControl1.AutoCloseTabs = True
		Me.TabControl1.BackColor = System.Drawing.Color.Black
		Me.TabControl1.CanReorderTabs = True
		Me.TabControl1.CloseButtonOnTabsVisible = True
		Me.TabControl1.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right
		Me.TabControl1.ColorScheme.NavigationBoxForeColor = System.Drawing.Color.Beige
		Me.TabControl1.ColorScheme.TabBackground = System.Drawing.Color.Black
		Me.TabControl1.ColorScheme.TabBorder = System.Drawing.Color.Gold
		Me.TabControl1.ColorScheme.TabItemBackground = System.Drawing.Color.Gold
		Me.TabControl1.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.White
		Me.TabControl1.ColorScheme.TabItemSelectedBackground2 = System.Drawing.Color.White
		Me.TabControl1.ColorScheme.TabItemSelectedBorder = System.Drawing.SystemColors.ControlLightLight
		Me.TabControl1.ColorScheme.TabItemSelectedBorderDark = System.Drawing.Color.Gainsboro
		Me.TabControl1.ColorScheme.TabItemSelectedBorderLight = System.Drawing.Color.Black
		Me.TabControl1.ColorScheme.TabItemSeparator = System.Drawing.Color.Black
		Me.TabControl1.ColorScheme.TabItemText = System.Drawing.Color.Black
		Me.TabControl1.ColorScheme.TabPanelBackground2 = System.Drawing.Color.Wheat
		Me.TabControl1.ColorScheme.TabPanelBorder = System.Drawing.Color.SlateBlue
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.FixedTabSize = New System.Drawing.Size(200, -8)
		Me.TabControl1.ForeColor = System.Drawing.Color.Black
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
		Me.TabControl1.SelectedTabIndex = -1
		Me.TabControl1.Size = New System.Drawing.Size(1368, 712)
		Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005
		Me.TabControl1.TabIndex = 35
		Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
		Me.TabControl1.Text = "TabControl2"
		'
		'Panel5
		'
		Me.Panel5.Controls.Add(Me.Button2)
		Me.Panel5.Location = New System.Drawing.Point(119, 50)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(10, 10)
		Me.Panel5.TabIndex = 0
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(17, 24)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 0
		Me.Button2.Text = "Go"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Black
		Me.Panel4.Controls.Add(Me.Panel2)
		Me.Panel4.Controls.Add(Me.Guna2Button1)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(1370, 35)
		Me.Panel4.TabIndex = 2
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(40, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1330, 35)
		Me.Panel2.TabIndex = 34
		'
		'Panel3
		'
		Me.Panel3.AutoSize = True
		Me.Panel3.Controls.Add(Me.LabelX2)
		Me.Panel3.Controls.Add(Me.LabelX1)
		Me.Panel3.Location = New System.Drawing.Point(643, 0)
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
		'Guna2Button1
		'
		Me.Guna2Button1.BorderColor = System.Drawing.Color.Gold
		Me.Guna2Button1.BorderThickness = 1
		Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
		Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
		Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Guna2Button1.FillColor = System.Drawing.Color.Black
		Me.Guna2Button1.Font = New System.Drawing.Font("Times New Roman", 10.75!)
		Me.Guna2Button1.ForeColor = System.Drawing.Color.White
		Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
		Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
		Me.Guna2Button1.Name = "Guna2Button1"
		Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
		Me.Guna2Button1.Size = New System.Drawing.Size(40, 35)
		Me.Guna2Button1.TabIndex = 35
		Me.Guna2Button1.Text = "+"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		'
		'BackgroundNewTab
		'
		Me.BackgroundNewTab.WorkerReportsProgress = True
		Me.BackgroundNewTab.WorkerSupportsCancellation = True
		'
		'Home
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ClientSize = New System.Drawing.Size(1370, 749)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Panel4)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Home"
		Me.ShowIcon = False
		Me.Panel1.ResumeLayout(False)
		CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel5.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundNewTab As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
