Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Public Class DesktopFlow
    Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        insert()
        loadrecord()
        TextBox4.Text = "http://localhost/paypal_client/"
    End Sub
    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub getimage()
        Dim command As New MySqlCommand("SELECT  `buy`,`describes`,`Name`,`Pics`,`try`,`iD` FROM `uiandux_page` WHERE `iD` = @iD", connection)
        command.Parameters.Add("@iD", MySqlDbType.UInt64).Value = ID_Textbox.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()


        Try

            adapter.Fill(table)

            Dim imgByte() As Byte

            If table.Rows.Count = 1 Then

                imgByte = table(0)(3)

                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)

            Else



            End If
        Catch ex As Exception



            PictureBox1.Image = Nothing

        End Try

    End Sub

    Private Sub insert()
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("INSERT INTO `uiandux_page`(`Name`, `describes`, `try`, `buy`, `Pics`, `Price`) VALUES (@nm,@ds,@t,@b,@p,@price)", connection)

        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@ds", MySqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@t", MySqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@b", MySqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@p", MySqlDbType.Blob).Value = ms.ToArray()
        command.Parameters.Add("@price", MySqlDbType.VarChar).Value = TextBox6.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Inserted")
            RefreshBTN.PerformClick()
            'MessageBox.Show("Image Inserted")

        Else
            'MessageBox.Show("Image Not Inserted")
        End If

        connection.Close()
    End Sub
    Private Sub updateimage()
        Dim update_command As New MySqlCommand("UPDATE `uiandux_page` SET `Pics`=@Pics WHERE `iD` = @iD", connection)

        Dim ms As New MemoryStream

        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        update_command.Parameters.Add("@iD", MySqlDbType.Blob).Value = ID_Textbox.Text()
        update_command.Parameters.Add("@Pics", MySqlDbType.Blob).Value = ms.ToArray()

        connection.Open()

        If update_command.ExecuteNonQuery() = 1 Then

        Else

        End If

        connection.Close()
    End Sub
    Private Sub loadclear()
        TextBox5.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''''loadrecord()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from uiandux_page where Name=@firstname"
            cmd.Parameters.AddWithValue("@firstname", TextBox1.Text)
            cmd.ExecuteNonQuery()
            loadrecord()
            MsgBox("Successfully Deleted")
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uiandux_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            HTTPCLient.CancelAsync()
        Catch ex As Exception

        End Try


    End Sub
    Dim cmd As MySqlCommand
    Private WithEvents panel As New Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pic As New Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblName As New Label

    Private WithEvents lblID As New Label

    Private WithEvents lblbuy As New Label

    Private WithEvents lbltry As New Label

    Private WithEvents lbldescribes As New Label
    Private WithEvents Trailbtn As New Guna.UI2.WinForms.Guna2Button
    Private WithEvents buybtn As New Guna.UI2.WinForms.Guna2Button
    Sub loadinflot()
        FlowLayoutPanel1.Controls.Clear()

        cmd = New MySqlCommand("Select Pics, Name, describes, buy, try, iD from uiandux_page where Name like '%" & TextBoxX1.Text & "%' And categories like'%" & Currentcat.Text & "%'", cn)
        cn.Open()
        dr = cmd.ExecuteReader

        While dr.Read
            'MsgBox("dr.Read.... OK....", MsgBoxStyle.Information)

            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            panel = New Guna.UI2.WinForms.Guna2Panel
            panel.Width = 300
            panel.Height = 150
            panel.BackColor = Color.Transparent
            panel.BackColor = System.Drawing.Color.Transparent
            panel.BorderColor = System.Drawing.Color.Black
            panel.BorderRadius = 10
            panel.BorderThickness = 1
            panel.Padding = New Padding(15)
            panel.FillColor = System.Drawing.Color.Gold


            pic = New Guna.UI2.WinForms.Guna2PictureBox
            pic.Width = 50
            pic.Height = 50
            pic.SizeMode = ImageLayout.Zoom
            pic.FillColor = Color.Transparent
            pic.BackColor = Color.Transparent
            pic.UseTransparentBackground = True

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.Image = bitmap
            pic.BorderRadius = 10
            panel.Controls.Add(pic)



            lblName = New Label
            lblName.BackColor = Color.Transparent
            lblName.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lblName.Location = New Point(50, 0)
            lblName.Text = dr.Item("Name").ToString
            lblName.BorderStyle = BorderStyle.None
            lblName.Size = New Point(250, 20)
            lblName.Tag = dr.Item("iD").ToString
            panel.Controls.Add(lblName)



            lbldescribes = New Label
            lbldescribes.BackColor = Color.Transparent
            lbldescribes.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lbldescribes.Location = New Point(0, 50)
            lbldescribes.Text = dr.Item("describes").ToString
            lbldescribes.Size = New Point(299, 65)
            lbldescribes.BorderStyle = BorderStyle.None
            panel.Controls.Add(lbldescribes)

            lbldescribes.Tag = dr.Item("iD").ToString

            'Button{''''''''''''''''''''''''''''''''''Button
            Trailbtn = New Guna.UI2.WinForms.Guna2Button
            Trailbtn.Size = New System.Drawing.Size(60, 30)
            Trailbtn.Location = New Point(225, 115)
            Trailbtn.Text = "Trial"

            Trailbtn.BorderColor = System.Drawing.Color.Gold
            Trailbtn.BorderRadius = 5
            Trailbtn.BorderThickness = 2
            Trailbtn.Cursor = System.Windows.Forms.Cursors.Hand
            Trailbtn.FillColor = System.Drawing.Color.Black
            Trailbtn.Font = New System.Drawing.Font("Arial", 10.0!)
            Trailbtn.ForeColor = System.Drawing.Color.Gold


            panel.Controls.Add(Trailbtn)
            Trailbtn.Tag = dr.Item("iD").ToString

            buybtn = New Guna.UI2.WinForms.Guna2Button
            buybtn.Size = New System.Drawing.Size(60, 30)
            buybtn.Location = New Point(160, 115)
            buybtn.Text = "Buy"

            buybtn.BorderColor = System.Drawing.Color.Gold
            buybtn.BorderRadius = 5
            buybtn.BorderThickness = 2
            buybtn.Cursor = System.Windows.Forms.Cursors.Hand
            buybtn.FillColor = System.Drawing.Color.Black
            buybtn.Font = New System.Drawing.Font("Arial", 10.0!)
            buybtn.ForeColor = System.Drawing.Color.Gold

            panel.Controls.Add(buybtn)
            buybtn.Tag = dr.Item("iD").ToString

            '}'''''''''''''''''''''''''''''''''''''''''Button

            lblbuy = New Label
            lblbuy.BackColor = Color.Transparent
            lblbuy.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lblbuy.Location = New Point(50, 0)
            lblbuy.Text = dr.Item("buy").ToString
            lblbuy.BorderStyle = BorderStyle.None
            lblbuy.Size = New Point(250, 20)
            lblbuy.Visible = False
            lblbuy.Tag = dr.Item("iD").ToString
            panel.Controls.Add(lblbuy)




            lbltry = New Label
            lbltry.BackColor = Color.Transparent
            lbltry.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lbltry.Location = New Point(50, 0)
            lbltry.Text = dr.Item("try").ToString
            lbltry.BorderStyle = BorderStyle.None
            lbltry.Size = New Point(250, 20)
            lbltry.Visible = False
            lbltry.Tag = dr.Item("iD").ToString
            panel.Controls.Add(lbltry)



            'pic.Tag = dr.Item("iD").ToString
            FlowLayoutPanel1.Controls.Add(panel)
            AddHandler buybtn.Click, AddressOf buybtn_click
            AddHandler Trailbtn.Click, AddressOf Trailbtn_click

        End While

        dr.Close()
        cn.Close()
    End Sub
    Public Sub Trailbtn_click(ByVal sender As Object, ByVal e As EventArgs)
        'Try
        ID_Textbox.Text = (sender.tag.ToString)

        Freeinterface.Data_ID.Text = (sender.tag.ToString)

        Status.AddStatus("Desktop - Trial - " + sender.tag.ToString)

        Freeinterface.ShowDialog()
        'Catch ex As Exception

        'End Try

    End Sub
    Public Sub buybtn_click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ID_Textbox.Text = (sender.tag.ToString)


            Status.AddStatus("Desktop - Buy - " + sender.tag.ToString)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub uiandux_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection()
        cn.ConnectionString = "datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy"
        loadrecord()
        loadinflot()
        wc = New WebClient()
    End Sub

    Sub loadrecord()
        cn.Close()
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select * from uiandux_page where iD like '%" & ID_Textbox.Text & "%'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("Pics"), dr.Item("Name").ToString, dr.Item("describes").ToString, dr.Item("Price").ToString, dr.Item("try").ToString, dr.Item("buy").ToString, dr.Item("iD"))
        End While
        dr.Close()
        cn.Close()
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 100
        Next
        'DataGridViewRow.row = DataGridView1.Rows(0)
        'dataGridView1.CurrentRow = row;

        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub updatesave()
        Try
            Dim cmd As MySqlCommand
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandText = "update uiandux_page set describes=@describes,try=@try, buy=@buy,Name=@firstname2,Price=@price where iD=@iD"
            cmd.Parameters.AddWithValue("@describes", TextBox2.Text)
            cmd.Parameters.AddWithValue("@try", TextBox4.Text)
            cmd.Parameters.AddWithValue("@buy", TextBox3.Text)
            cmd.Parameters.AddWithValue("@firstname2", TextBox1.Text)
            cmd.Parameters.AddWithValue("@price", TextBox6.Text)
            cmd.Parameters.AddWithValue("@iD", ID_Textbox.Text)

            cmd.ExecuteNonQuery()
            Try

            Catch ex As Exception

            End Try

            con.Close()

            MsgBox("Updated.")
            loadrecord()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        updatesave()
        updateimage()
        Try
            loadrecord()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox1.Text = row.Cells(1).Value.ToString
            TextBox2.Text = row.Cells(2).Value.ToString
            TextBox6.Text = row.Cells(3).Value.ToString
            TextBox3.Text = row.Cells(5).Value.ToString
            TextBox4.Text = row.Cells(4).Value.ToString
            ID_Textbox.Text = row.Cells(6).Value.ToString

        Catch ex As Exception

        End Try
        getimage()
    End Sub


    Private Sub ID_Textbox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ID_Textbox.TextChanged
        getimage()
        loadrecord()
    End Sub
    Dim wc As WebClient
    'Private Sub download()

    '    AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
    '    wc.DownloadFileAsync(New Uri(TextBox4.Text), TextBox7.Text + "\" + TextBox1.Text)
    'End Sub
    Private Sub ProgChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ProgressBar1.Value = e.ProgressPercentage 'Obtenir la progression du téléchargement en cours
        Label8.Text = e.ProgressPercentage.ToString() + "%"
        Label9.Text = String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        If e.ColumnIndex = 8 Then


            Freeinterface.Data_ID.Text = row.Cells(6).Value.ToString

            trytext.Text = row.Cells(4).Value.ToString
            Downloadpage.Downloadlink.Text = trytext.Text
            TextBox1.Text = row.Cells(1).Value.ToString

            Freeinterface.ShowDialog()


        End If

        If e.ColumnIndex = 7 Then


            Freeinterface.Data_ID.Text = row.Cells(6).Value.ToString

            trytext.Text = row.Cells(4).Value.ToString
            Downloadpage.Downloadlink.Text = trytext.Text
            TextBox1.Text = row.Cells(1).Value.ToString

        End If
    End Sub
    Private WithEvents HTTPCLient As WebClient
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        RefreshBTN.PerformClick()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Dim fldBrowse As New FolderBrowserDialog()
        'If fldBrowse.ShowDialog() = DialogResult.OK Then
        '    TextBox7.Text = fldBrowse.SelectedPath
        'End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        HTTPCLient = New WebClient
        Dim download As String = TextBox4.Text
        Dim user = Environment.UserName
        Dim save As String = "c:\Users\" & user & "\Downloads\" & TextBox1.Text
        Try
            HTTPCLient.DownloadFileAsync(New Uri(download), save)
            TextBox4.ReadOnly = True
            TextBox1.ReadOnly = True
            Button7.Enabled = False
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Done")

        End Try
    End Sub

    Private Sub HTTPCLient_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles HTTPCLient.DownloadProgressChanged
        ProgressBar1.Maximum = e.TotalBytesToReceive
        ProgressBar1.Value = e.BytesReceived
        Label8.Text = "Downloading " & e.ProgressPercentage & "%"

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            MessageBox.Show("Downloaded")
            TextBox4.ReadOnly = False
            TextBox1.ReadOnly = False
            Button7.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX1.TextChanged
        loadinflot()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        TextBoxX1.Clear()
    End Sub

    Private Sub Trailbutton_click(ByVal sender As Object, ByVal e As EventArgs)
        TextBoxX1.Text = lblName.Text
        ID_Textbox.Text = lblID.Text
        Freeinterface.Data_ID.Text = lblID.Text


        trytext.Text = lbltry.Text
        Downloadpage.Downloadlink.Text = trytext.Text



        Freeinterface.ShowDialog()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Currentcat.Text = sender.Text
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Currentcat.Text = sender.Text
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Currentcat.Text = sender.Text
    End Sub

    Private Sub Currentcat_TextChanged(sender As Object, e As EventArgs) Handles Currentcat.TextChanged
        loadinflot()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Currentcat.Text = ""
    End Sub

    Private Sub RefreshBTN_Click(sender As Object, e As EventArgs) Handles RefreshBTN.Click
        loadinflot()
        wc = New WebClient()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class