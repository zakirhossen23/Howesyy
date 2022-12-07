<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Freeinterface
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Nodata_address = New System.Windows.Forms.TextBox()
        Me.Nodata_mobile = New System.Windows.Forms.TextBox()
        Me.Nodata_customer = New System.Windows.Forms.TextBox()
        Me.Data_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Traillink = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Data_application = New System.Windows.Forms.Label()
        Me.Data_description = New System.Windows.Forms.Label()
        Me.Data_price = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Label1 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(21, 199)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 19)
        Label1.TabIndex = 61
        Label1.Text = "No Address:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(21, 175)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(79, 19)
        Label8.TabIndex = 59
        Label8.Text = "No Mobile:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(21, 151)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(95, 19)
        Label9.TabIndex = 57
        Label9.Text = "No Customer:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Data_application)
        Me.Panel1.Controls.Add(Me.Data_description)
        Me.Panel1.Controls.Add(Me.Data_price)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 270)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.ForeColor = System.Drawing.Color.Gold
        Me.Panel3.Location = New System.Drawing.Point(213, 237)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 10)
        Me.Panel3.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Time"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(82, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 66
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(577, 10)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 64
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.Nodata_address)
        Me.Panel2.Controls.Add(Label8)
        Me.Panel2.Controls.Add(Me.Nodata_mobile)
        Me.Panel2.Controls.Add(Label9)
        Me.Panel2.Controls.Add(Me.Nodata_customer)
        Me.Panel2.Controls.Add(Me.Data_ID)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Traillink)
        Me.Panel2.ForeColor = System.Drawing.Color.Gold
        Me.Panel2.Location = New System.Drawing.Point(222, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 61
        '
        'Nodata_address
        '
        Me.Nodata_address.Location = New System.Drawing.Point(113, 198)
        Me.Nodata_address.Multiline = True
        Me.Nodata_address.Name = "Nodata_address"
        Me.Nodata_address.Size = New System.Drawing.Size(105, 26)
        Me.Nodata_address.TabIndex = 62
        '
        'Nodata_mobile
        '
        Me.Nodata_mobile.Location = New System.Drawing.Point(113, 172)
        Me.Nodata_mobile.Name = "Nodata_mobile"
        Me.Nodata_mobile.Size = New System.Drawing.Size(105, 26)
        Me.Nodata_mobile.TabIndex = 60
        '
        'Nodata_customer
        '
        Me.Nodata_customer.Location = New System.Drawing.Point(113, 146)
        Me.Nodata_customer.Name = "Nodata_customer"
        Me.Nodata_customer.Size = New System.Drawing.Size(105, 26)
        Me.Nodata_customer.TabIndex = 58
        '
        'Data_ID
        '
        Me.Data_ID.Location = New System.Drawing.Point(25, 15)
        Me.Data_ID.Name = "Data_ID"
        Me.Data_ID.Size = New System.Drawing.Size(120, 26)
        Me.Data_ID.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Trail Apps link"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 19)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Buy Apps link"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(210, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 26)
        Me.TextBox3.TabIndex = 55
        '
        'Traillink
        '
        Me.Traillink.Location = New System.Drawing.Point(84, 105)
        Me.Traillink.Name = "Traillink"
        Me.Traillink.Size = New System.Drawing.Size(120, 26)
        Me.Traillink.TabIndex = 56
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(3, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 46)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Add to cart"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(470, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 46)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Free Download"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Data_application
        '
        Me.Data_application.ForeColor = System.Drawing.Color.Gold
        Me.Data_application.Location = New System.Drawing.Point(344, 20)
        Me.Data_application.Name = "Data_application"
        Me.Data_application.Size = New System.Drawing.Size(235, 28)
        Me.Data_application.TabIndex = 60
        '
        'Data_description
        '
        Me.Data_description.ForeColor = System.Drawing.Color.Gold
        Me.Data_description.Location = New System.Drawing.Point(305, 100)
        Me.Data_description.Name = "Data_description"
        Me.Data_description.Size = New System.Drawing.Size(325, 108)
        Me.Data_description.TabIndex = 59
        '
        'Data_price
        '
        Me.Data_price.AutoSize = True
        Me.Data_price.ForeColor = System.Drawing.Color.Gold
        Me.Data_price.Location = New System.Drawing.Point(264, 59)
        Me.Data_price.Name = "Data_price"
        Me.Data_price.Size = New System.Drawing.Size(21, 19)
        Me.Data_price.TabIndex = 58
        Me.Data_price.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(218, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 19)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(218, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Description"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(218, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Applications Name"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Freeinterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 270)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Freeinterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Data_ID As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Data_description As System.Windows.Forms.Label
    Friend WithEvents Data_application As System.Windows.Forms.Label
    Friend WithEvents Traillink As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Data_price As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Nodata_address As System.Windows.Forms.TextBox
    Friend WithEvents Nodata_mobile As System.Windows.Forms.TextBox
    Friend WithEvents Nodata_customer As System.Windows.Forms.TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
