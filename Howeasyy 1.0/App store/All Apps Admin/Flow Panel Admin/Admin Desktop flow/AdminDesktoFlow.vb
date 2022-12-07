Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Public Class AdminDesktopFlow
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
            Button2.PerformClick()
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

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        loadinflot()
        wc = New WebClient()
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
            End
        End Try


    End Sub
    Dim cmd As MySqlCommand
    Private WithEvents panel As New Panel
    Private WithEvents pic As New PictureBox
    Private WithEvents lblName As New Label

    Private WithEvents lblID As New Label

    Private WithEvents lblbuy As New Label

    Private WithEvents lbltry As New Label

    Private WithEvents lbldescribes As New Label
    Private WithEvents editbtn As New Button
    Private WithEvents deletebtn As New Button
    Private WithEvents plusbtn As New Button

    Private Sub loadinflot()
#Region "code"
        Try
            LoaderPanelTransition.HideSync(FromLoader)

        Catch ex As Exception

        End Try
        ''''''Loaderpanel.ShowSync(FromLoader)
        FromLoader.Visible = True
        '''''''''''Add Product''''''


        FlowLayoutPanel1.Controls.Clear()
        Panel2 = New Panel
        Panel2.Width = 300
        Panel2.Height = 150
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.BackColor = Color.Black

        plusbtn = New Button
        plusbtn.Text = "+"
        plusbtn.TextAlign = ContentAlignment.MiddleCenter

        plusbtn.Font = New Font(plusbtn.Font.FontFamily, plusbtn.Font.Size + 44, plusbtn.Font.Style)
        plusbtn.Cursor = Cursors.Hand
        plusbtn.Dock = DockStyle.Fill
        Panel2.Controls.Add(plusbtn)
        FlowLayoutPanel1.Controls.Add(Panel2)
        cmd = New MySqlCommand("Select Pics, Name, describes, buy, try, iD from uiandux_page where Name like '%" & SearchTXT.Text & "%'", cn)
        cn.Open()
        dr = cmd.ExecuteReader

        While dr.Read
            'MsgBox("dr.Read.... OK....", MsgBoxStyle.Information)

            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            panel = New Panel
            panel.Width = 300
            panel.Height = 150
            panel.BorderStyle = BorderStyle.FixedSingle
            panel.BackColor = Color.Black


            pic = New PictureBox
            pic.Width = 50
            pic.Height = 50
            pic.BackgroundImageLayout = ImageLayout.Zoom
            pic.BorderStyle = BorderStyle.FixedSingle

            panel.Controls.Add(pic)



            lblName = New Label
            lblName.BackColor = Color.Black
            lblName.ForeColor = Color.Gold
            lblName.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lblName.Location = New Point(50, 0)
            lblName.Text = dr.Item("Name").ToString
            lblName.BorderStyle = BorderStyle.None
            lblName.Size = New Point(250, 20)
            lblName.Tag = dr.Item("iD").ToString
            panel.Controls.Add(lblName)



            lbldescribes = New Label
            lbldescribes.BackColor = Color.Black
            lbldescribes.ForeColor = Color.Gold

            lbldescribes.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lbldescribes.Location = New Point(0, 50)
            lbldescribes.Text = dr.Item("describes").ToString
            lbldescribes.Size = New Point(299, 65)
            lbldescribes.BorderStyle = BorderStyle.None
            panel.Controls.Add(lbldescribes)

            lbldescribes.Tag = dr.Item("iD").ToString

            'Button{''''''''''''''''''''''''''''''''''Button

            '''''''''''''''Edit Button''''''''''''''''
            editbtn = New Button
            editbtn.Location = New Point(145, 120)
            editbtn.Text = "Edit"
            editbtn.Font = New Font(editbtn.Font.FontFamily, editbtn.Font.Size - 0, editbtn.Font.Style)
            panel.Controls.Add(editbtn)
            editbtn.Tag = dr.Item("iD").ToString
            editbtn.BackColor = Color.Blue
            editbtn.ForeColor = Color.White
            editbtn.FlatStyle = FlatStyle.Flat
            editbtn.FlatAppearance.MouseOverBackColor = Color.DarkGreen
            editbtn.Cursor = Cursors.Hand

            '''''''''''Delete Button''''''''''''''
            deletebtn = New Button
            deletebtn.Location = New Point(220, 120)
            deletebtn.Text = "Delete"
            deletebtn.Font = New Font(deletebtn.Font.FontFamily, deletebtn.Font.Size - 0, deletebtn.Font.Style)
            panel.Controls.Add(deletebtn)
            deletebtn.Tag = dr.Item("iD").ToString
            deletebtn.BackColor = Color.Red
            deletebtn.ForeColor = Color.White
            deletebtn.FlatStyle = FlatStyle.Flat
            deletebtn.FlatAppearance.MouseOverBackColor = Color.Black

            deletebtn.Cursor = Cursors.Hand
            '}'''''''''''''''''''''''''''''''''''''''''Button

            lblbuy = New Label
            lblbuy.BackColor = Color.Transparent
            lblbuy.ForeColor = Color.Gold
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
            lbltry.ForeColor = Color.Gold
            lbltry.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lbltry.Location = New Point(50, 0)
            lbltry.Text = dr.Item("try").ToString
            lbltry.BorderStyle = BorderStyle.None
            lbltry.Size = New Point(250, 20)
            lbltry.Visible = False
            lbltry.Tag = dr.Item("iD").ToString
            panel.Controls.Add(lbltry)




            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            'pic.BackgroundImageLayout = ImageLayout.Zoom


            'pic.Tag = dr.Item("iD").ToString
            FlowLayoutPanel1.Controls.Add(panel)

            ''''''''''''''' Database''''''''''
            '''

            AddHandler editbtn.Click, AddressOf editbtn_click
            AddHandler deletebtn.Click, AddressOf deletebtn_click

        End While

        dr.Close()
        cn.Close()

        FromLoader.Visible = False
        Loaderpanel.HideSync(FromLoader)



        AddHandler plusbtn.Click, AddressOf plusbtn_click
#End Region

    End Sub
    Public Sub editbtn_click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ID_Textbox.Text = (sender.tag.ToString)

            DesktopEdit.Data_ID.Text = (sender.tag.ToString)

            DesktopEdit.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub deletebtn_click(ByVal sender As Object, ByVal e As EventArgs)
        ID_Textbox.Text = (sender.tag.ToString)
        If MsgBox("Are you sure want to delete?", vbYesNo) = vbYes Then
            Dim cmd As MySqlCommand
            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "delete from uiandux_page where iD=@iD"
                cmd.Parameters.AddWithValue("@iD", ID_Textbox.Text)
                cmd.ExecuteNonQuery()
                loadrecord()
                MsgBox("Successfully Deleted")
                con.Close()
                Button2.PerformClick()
            Catch ex As Exception

            End Try
        Else
            Exit Sub
        End If

    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''Worked Stopped
    Private Sub uiandux_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
#Disable Warning
        Threading.Thread.CurrentThread.ApartmentState = Threading.ApartmentState.STA
#Enable Warning
        cn = New MySqlConnection()
        cn.ConnectionString = "datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy"

        Me.loadinflot()


        wc = New WebClient()
        'MsgBox("load")

    End Sub

    'Sub loadrecordbytext()
    ' Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
    '    Dim command As New MySqlCommand("SELECT * FROM `uiandux_page` WHERE `iD` = @id", connection)

    '    command.Parameters.Add("@iD", MySqlDbType.Int64).Value = ID_Textbox.Text

    '    Dim adapter As New MySqlDataAdapter(command)

    '    Dim table As New DataTable()

    '    Try

    '        adapter.Fill(table)
    '        Dim imgByte() As Byte

    '        If table.Rows.Count > 0 Then
    '            TextBox3.Text = table(0)(0)
    '            Data_description.Text = table(0)(1)
    '            Data_application.Text = table(0)(2)
    '            Traillink.Text = table(0)(4)
    '            Data_price.Text = table(0)(6)

    '        Else


    '        End If

    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message.ToString())

    '    End Try
    'End Sub
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

            'Downloadpage.Label2.Text = TextBox1.Text + " Free Version"


        End If

        If e.ColumnIndex = 7 Then


            Freeinterface.Data_ID.Text = row.Cells(6).Value.ToString

            trytext.Text = row.Cells(4).Value.ToString
            Downloadpage.Downloadlink.Text = trytext.Text
            TextBox1.Text = row.Cells(1).Value.ToString

            'Downloadpage.Label2.Text = TextBox1.Text + " Free Version"


        End If
    End Sub
    Private WithEvents HTTPCLient As WebClient
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Button2.PerformClick()
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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        SearchTXT.Clear()
    End Sub

    Private Sub Trailbutton_click(ByVal sender As Object, ByVal e As EventArgs)
        SearchTXT.Text = lblName.Text
        ID_Textbox.Text = lblID.Text
        Freeinterface.Data_ID.Text = lblID.Text


        trytext.Text = lbltry.Text
        Downloadpage.Downloadlink.Text = trytext.Text



        Freeinterface.ShowDialog()

    End Sub

    Private Sub plusbtn_click(ByVal sender As Object, ByVal e As EventArgs)
        DesktopDataInput.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Close()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        SearchTXT.Clear()
        ''MsgBox("starting")
        Timer2.Enabled = True

    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTXT.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadinflot()
        End If
    End Sub

    Private Sub Reloadingtime_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick

        loadinflot()
        Timer2.Enabled = False
    End Sub
End Class