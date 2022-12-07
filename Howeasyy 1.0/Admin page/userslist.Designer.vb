<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userslist
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UpdateBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.SearchTXT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RefreshBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.GridViewGuna = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Auto_ID = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nametext = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EmailLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Passwordline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditLine = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.DeleteLineBTN = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.serialKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.GridViewGuna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.UpdateBTN)
        Me.Panel1.Controls.Add(Me.SearchTXT)
        Me.Panel1.Controls.Add(Me.RefreshBTN)
        Me.Panel1.Controls.Add(Me.GridViewGuna)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Panel1.ForeColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 543)
        Me.Panel1.TabIndex = 1
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateBTN.BorderColor = System.Drawing.Color.Gold
        Me.UpdateBTN.BorderRadius = 5
        Me.UpdateBTN.BorderThickness = 2
        Me.UpdateBTN.CheckedState.Parent = Me.UpdateBTN
        Me.UpdateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateBTN.CustomImages.Parent = Me.UpdateBTN
        Me.UpdateBTN.FillColor = System.Drawing.Color.Black
        Me.UpdateBTN.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.UpdateBTN.ForeColor = System.Drawing.Color.Gold
        Me.UpdateBTN.HoverState.Parent = Me.UpdateBTN
        Me.UpdateBTN.Location = New System.Drawing.Point(1114, 20)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.ShadowDecoration.Parent = Me.UpdateBTN
        Me.UpdateBTN.Size = New System.Drawing.Size(143, 38)
        Me.UpdateBTN.TabIndex = 11
        Me.UpdateBTN.Text = "Update"
        '
        'SearchTXT
        '
        Me.SearchTXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTXT.BorderColor = System.Drawing.Color.Transparent
        Me.SearchTXT.BorderRadius = 5
        Me.SearchTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTXT.DefaultText = ""
        Me.SearchTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTXT.DisabledState.Parent = Me.SearchTXT
        Me.SearchTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTXT.FillColor = System.Drawing.Color.Gold
        Me.SearchTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTXT.FocusedState.Parent = Me.SearchTXT
        Me.SearchTXT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchTXT.ForeColor = System.Drawing.Color.Black
        Me.SearchTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTXT.HoverState.Parent = Me.SearchTXT
        Me.SearchTXT.Location = New System.Drawing.Point(248, 20)
        Me.SearchTXT.Name = "SearchTXT"
        Me.SearchTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTXT.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.SearchTXT.PlaceholderText = "Search By Names"
        Me.SearchTXT.SelectedText = ""
        Me.SearchTXT.ShadowDecoration.Parent = Me.SearchTXT
        Me.SearchTXT.Size = New System.Drawing.Size(689, 38)
        Me.SearchTXT.TabIndex = 10
        '
        'RefreshBTN
        '
        Me.RefreshBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshBTN.BorderColor = System.Drawing.Color.Gold
        Me.RefreshBTN.BorderRadius = 5
        Me.RefreshBTN.BorderThickness = 2
        Me.RefreshBTN.CheckedState.Parent = Me.RefreshBTN
        Me.RefreshBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshBTN.CustomImages.Parent = Me.RefreshBTN
        Me.RefreshBTN.FillColor = System.Drawing.Color.Black
        Me.RefreshBTN.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.RefreshBTN.ForeColor = System.Drawing.Color.Gold
        Me.RefreshBTN.HoverState.Parent = Me.RefreshBTN
        Me.RefreshBTN.Location = New System.Drawing.Point(965, 20)
        Me.RefreshBTN.Name = "RefreshBTN"
        Me.RefreshBTN.ShadowDecoration.Parent = Me.RefreshBTN
        Me.RefreshBTN.Size = New System.Drawing.Size(143, 38)
        Me.RefreshBTN.TabIndex = 9
        Me.RefreshBTN.Text = "Refresh"
        '
        'GridViewGuna
        '
        Me.GridViewGuna.AllowUserToAddRows = False
        Me.GridViewGuna.AllowUserToDeleteRows = False
        Me.GridViewGuna.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.GridViewGuna.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GridViewGuna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridViewGuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridViewGuna.BackgroundColor = System.Drawing.Color.Black
        Me.GridViewGuna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridViewGuna.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewGuna.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridViewGuna.ColumnHeadersHeight = 40
        Me.GridViewGuna.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Image, Me.EmailLine, Me.Passwordline, Me.NameLine, Me.IDLine, Me.StatusLine, Me.EditLine, Me.DeleteLineBTN, Me.serialKey})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewGuna.DefaultCellStyle = DataGridViewCellStyle10
        Me.GridViewGuna.EnableHeadersVisualStyles = False
        Me.GridViewGuna.GridColor = System.Drawing.Color.Khaki
        Me.GridViewGuna.Location = New System.Drawing.Point(21, 72)
        Me.GridViewGuna.MultiSelect = False
        Me.GridViewGuna.Name = "GridViewGuna"
        Me.GridViewGuna.RowHeadersVisible = False
        Me.GridViewGuna.RowTemplate.Height = 60
        Me.GridViewGuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridViewGuna.Size = New System.Drawing.Size(1236, 448)
        Me.GridViewGuna.TabIndex = 8
        Me.GridViewGuna.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo
        Me.GridViewGuna.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Yellow
        Me.GridViewGuna.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GridViewGuna.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GridViewGuna.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GridViewGuna.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GridViewGuna.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.GridViewGuna.ThemeStyle.GridColor = System.Drawing.Color.Khaki
        Me.GridViewGuna.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GridViewGuna.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GridViewGuna.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GridViewGuna.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GridViewGuna.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GridViewGuna.ThemeStyle.HeaderStyle.Height = 40
        Me.GridViewGuna.ThemeStyle.ReadOnly = False
        Me.GridViewGuna.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black
        Me.GridViewGuna.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridViewGuna.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.GridViewGuna.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gold
        Me.GridViewGuna.ThemeStyle.RowsStyle.Height = 60
        Me.GridViewGuna.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GridViewGuna.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Auto_ID)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.nametext)
        Me.Panel2.Controls.Add(Me.pass)
        Me.Panel2.Controls.Add(Me.email)
        Me.Panel2.Location = New System.Drawing.Point(315, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'Auto_ID
        '
        Me.Auto_ID.Location = New System.Drawing.Point(97, 172)
        Me.Auto_ID.Name = "Auto_ID"
        Me.Auto_ID.Size = New System.Drawing.Size(100, 22)
        Me.Auto_ID.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Howeasyy.My.Resources.Resources.ui_and_ux_new_version
        Me.PictureBox1.Location = New System.Drawing.Point(24, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'nametext
        '
        Me.nametext.Location = New System.Drawing.Point(141, 119)
        Me.nametext.Name = "nametext"
        Me.nametext.Size = New System.Drawing.Size(100, 22)
        Me.nametext.TabIndex = 1
        Me.nametext.Text = "Name"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(141, 72)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(100, 22)
        Me.pass.TabIndex = 1
        Me.pass.Text = "pass"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(3, 20)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(194, 22)
        Me.email.TabIndex = 0
        Me.email.Text = "email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User List"
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        '
        'Image
        '
        Me.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Image.FillWeight = 253.8071!
        Me.Image.HeaderText = ""
        Me.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Image.MinimumWidth = 50
        Me.Image.Name = "Image"
        Me.Image.Width = 50
        '
        'EmailLine
        '
        Me.EmailLine.FillWeight = 61.54822!
        Me.EmailLine.HeaderText = "Email"
        Me.EmailLine.Name = "EmailLine"
        '
        'Passwordline
        '
        Me.Passwordline.FillWeight = 61.54822!
        Me.Passwordline.HeaderText = "Password"
        Me.Passwordline.Name = "Passwordline"
        '
        'NameLine
        '
        Me.NameLine.FillWeight = 61.54822!
        Me.NameLine.HeaderText = "Name"
        Me.NameLine.Name = "NameLine"
        '
        'IDLine
        '
        Me.IDLine.HeaderText = "ID"
        Me.IDLine.Name = "IDLine"
        Me.IDLine.Visible = False
        '
        'StatusLine
        '
        Me.StatusLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.StatusLine.HeaderText = "Status"
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Width = 5
        '
        'EditLine
        '
        Me.EditLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.EditLine.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent
        Me.EditLine.DefaultCellStyle = DataGridViewCellStyle8
        Me.EditLine.HeaderText = "Edit"
        Me.EditLine.Name = "EditLine"
        Me.EditLine.Text = "Edit"
        Me.EditLine.UseColumnTextForButtonValue = True
        Me.EditLine.Width = 41
        '
        'DeleteLineBTN
        '
        Me.DeleteLineBTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DeleteLineBTN.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent
        Me.DeleteLineBTN.DefaultCellStyle = DataGridViewCellStyle9
        Me.DeleteLineBTN.HeaderText = "Delete"
        Me.DeleteLineBTN.Name = "DeleteLineBTN"
        Me.DeleteLineBTN.Text = "Delete"
        Me.DeleteLineBTN.UseColumnTextForButtonValue = True
        Me.DeleteLineBTN.Width = 59
        '
        'serialKey
        '
        Me.serialKey.HeaderText = "serialKey"
        Me.serialKey.Name = "serialKey"
        Me.serialKey.Visible = False
        '
        'userslist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 543)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Howeasyy.My.Resources.Resources.Howeasyy
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "userslist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userslist"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridViewGuna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nametext As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Auto_ID As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridViewGuna As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents UpdateBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SearchTXT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RefreshBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Image As DataGridViewImageColumn
    Friend WithEvents EmailLine As DataGridViewTextBoxColumn
    Friend WithEvents Passwordline As DataGridViewTextBoxColumn
    Friend WithEvents NameLine As DataGridViewTextBoxColumn
    Friend WithEvents IDLine As DataGridViewTextBoxColumn
    Friend WithEvents StatusLine As DataGridViewTextBoxColumn
    Friend WithEvents EditLine As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents DeleteLineBTN As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents serialKey As DataGridViewTextBoxColumn
End Class
