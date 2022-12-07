Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Public Class AdminMobileFlow
    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)

    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        loadinflot()
        wc = New WebClient()
    End Sub


    Private Sub uiandux_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        loadinflot()
        wc = New WebClient()
    End Sub
    Dim cmd As MySqlCommand
    Private WithEvents panel As New Panel
    Private WithEvents pic As New PictureBox
    Private WithEvents lblName As New Label

    Private WithEvents lblID As New Label

    Private WithEvents lblbuy As New Label

    Private WithEvents lbltry As New Label

    Private WithEvents lbldescribes As New Label
    'Private WithEvents Launchbtn As New Button
    'Private WithEvents panel2 As New Panel
    Private WithEvents editbtn As New Button
    Private WithEvents deletebtn As New Button
    Private WithEvents plusbtn As New Button

    Sub loadinflot()

        '''''''''''Add Product''''''
        FlowLayoutPanel1.Controls.Clear()
        Panel2 = New Panel
        Panel2.Width = 300
        Panel2.Height = 150
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.BackColor = Color.Black
        Panel2.ForeColor = Color.Gold

        plusbtn = New Button
        plusbtn.Text = "+"
        plusbtn.TextAlign = ContentAlignment.MiddleCenter

        plusbtn.Font = New Font(plusbtn.Font.FontFamily, plusbtn.Font.Size + 44, plusbtn.Font.Style)
        plusbtn.Cursor = Cursors.Hand
        plusbtn.Dock = DockStyle.Fill
        Panel2.Controls.Add(plusbtn)
        FlowLayoutPanel1.Controls.Add(Panel2)

        AddHandler plusbtn.Click, AddressOf plusbtn_click
        ''''''''''''''' Database''''''''''


        cmd = New MySqlCommand("Select Pics, Name, describes, buy, try, iD from mobile where Name like '%" & SearchTXT.Text & "%'", con)
        con.Open()
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
            panel.ForeColor = Color.Gold


            pic = New PictureBox
            pic.Width = 50
            pic.Height = 50
            pic.BackgroundImageLayout = ImageLayout.Zoom
            pic.BorderStyle = BorderStyle.FixedSingle

            panel.Controls.Add(pic)



            lblName = New Label
            lblName.TextAlign = ContentAlignment.TopLeft
            'lblP.Font.Bold = True
            lblName.Location = New Point(50, 0)
            lblName.Text = dr.Item("Name").ToString
            lblName.BorderStyle = BorderStyle.None
            lblName.Size = New Point(250, 20)
            lblName.Tag = dr.Item("iD").ToString
            panel.Controls.Add(lblName)



            lbldescribes = New Label
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

            AddHandler editbtn.Click, AddressOf editbtn_click
            AddHandler deletebtn.Click, AddressOf deletebtn_click

        End While

        dr.Close()
        con.Close()
    End Sub
    Private Sub plusbtn_click(ByVal sender As Object, ByVal e As EventArgs)
        mobileDataInput.ShowDialog()
    End Sub
    Public Sub editbtn_click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ID_Textbox.Text = (sender.tag.ToString)

            MobileEdit.Data_ID.Text = (sender.tag.ToString)

            MobileEdit.ShowDialog()
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
                cmd.CommandText = "delete from mobile where iD=@iD"
                cmd.Parameters.AddWithValue("@iD", ID_Textbox.Text)
                cmd.ExecuteNonQuery()
                'loadrecord()
                MsgBox("Successfully Deleted")
                con.Close()
                Button2.PerformClick()
            Catch ex As Exception

            End Try
        Else
            Exit Sub
        End If

    End Sub
    Dim wc As WebClient


    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        SearchTXT.Clear()
        loadinflot()
        wc = New WebClient()
    End Sub

    Private Sub SearchTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchTXT.TextChanged
        loadinflot()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class