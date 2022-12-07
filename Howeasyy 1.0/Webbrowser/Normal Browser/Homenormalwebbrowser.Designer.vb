<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homenormalwebbrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homenormalwebbrowser))
        Me.SymbolBox1 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SymbolBox1
        '
        Me.SymbolBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SymbolBox1.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.SymbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox1.BackgroundStyle.TextTrimming = DevComponents.DotNetBar.eStyleTextTrimming.Character
        Me.SymbolBox1.BackgroundStyle.UseMnemonic = True
        Me.SymbolBox1.BackgroundStyle.WordWrap = True
        Me.SymbolBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SymbolBox1.Location = New System.Drawing.Point(748, 0)
        Me.SymbolBox1.Name = "SymbolBox1"
        Me.SymbolBox1.Size = New System.Drawing.Size(33, 24)
        Me.SymbolBox1.Symbol = ""
        Me.SymbolBox1.TabIndex = 1
        Me.SymbolBox1.Text = "SymbolBox2"
        '
        'TabControl2
        '
        Me.TabControl2.AutoCloseTabs = True
        Me.TabControl2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabControl2.CanReorderTabs = False
        Me.TabControl2.CloseButtonOnTabsVisible = True
        Me.TabControl2.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right
        Me.TabControl2.ColorScheme.NavigationBoxForeColor = System.Drawing.Color.White
        Me.TabControl2.ColorScheme.TabBackground = System.Drawing.Color.WhiteSmoke
        Me.TabControl2.ColorScheme.TabBackground2 = System.Drawing.Color.WhiteSmoke
        Me.TabControl2.ColorScheme.TabItemBackground = System.Drawing.Color.White
        Me.TabControl2.ColorScheme.TabItemBorder = System.Drawing.Color.DimGray
        Me.TabControl2.ColorScheme.TabItemHotBackground = System.Drawing.Color.Black
        Me.TabControl2.ColorScheme.TabItemHotBackground2 = System.Drawing.Color.Black
        Me.TabControl2.ColorScheme.TabItemHotText = System.Drawing.Color.White
        Me.TabControl2.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.Empty
        Me.TabControl2.ColorScheme.TabItemSelectedBackground2 = System.Drawing.Color.Empty
        Me.TabControl2.ColorScheme.TabItemSelectedText = System.Drawing.Color.Black
        Me.TabControl2.ColorScheme.TabItemText = System.Drawing.Color.Black
        Me.TabControl2.ColorScheme.TabPanelBackground = System.Drawing.Color.Empty
        Me.TabControl2.ColorScheme.TabPanelBackground2 = System.Drawing.Color.Empty
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.FixedTabSize = New System.Drawing.Size(200, 0)
        Me.TabControl2.ForeColor = System.Drawing.Color.Black
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(781, 478)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.Office2003
        Me.TabControl2.TabIndex = 6
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SymbolBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TabControl2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 478)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(388, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'Homenormalwebbrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 478)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = My.Resources.Howeasyy
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Homenormalwebbrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SymbolBox1 As DevComponents.DotNetBar.Controls.SymbolBox
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
