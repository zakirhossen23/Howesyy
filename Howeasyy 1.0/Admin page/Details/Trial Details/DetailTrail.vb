Imports System.IO
Imports MySql.Data.MySqlClient
Public Class DetailTrail

    Private Sub Guna2ControlBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2ControlBox1.Click

    End Sub


    Private Sub Getimagebyautoid()
        Try
            Dim connection As New MySqlConnection("datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy")
            Dim command As New MySqlCommand("SELECT * FROM `login` WHERE `Auto_ID` = @idd", connection)

            command.Parameters.Add("@idd", MySqlDbType.Int64).Value = TextBox1.Text

            Dim adapter As New MySqlDataAdapter(command)

            Dim table As New DataTable()

            Try

                adapter.Fill(table)
                Dim imgByte() As Byte

                If table.Rows.Count > 0 Then
                    imgByte = table(0)(4)
                    'TextBox1.Text = table(0)(0)

                    Dim ms As New MemoryStream(imgByte)
                    PictureBox1.Image = Image.FromStream(ms)
                Else


                End If

            Catch ex As Exception
                PictureBox1.Image = Nothing
                MessageBox.Show(ex.Message)

            End Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DetailBuy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getimagebyautoid()
        cn = New MySqlConnection With {
            .ConnectionString = "datasource=184.154.69.83;port=3306;username=howeasyyweb_howeasyy;password=8WU6eieKTK0J;database=howeasyyweb_howeasyy"
        }
        Loadrecord()
    End Sub

    Private Sub Label2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Getimagebyautoid()
        Loadrecord()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Sub Loadrecord()
        Try
            cn.Close()
            Guna2DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from trail_details where Name like '%" & nameSearch.Text & "%'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                Guna2DataGridView1.Rows.Add(dr.Item("Picture"), dr.Item("Serial").ToString, dr.Item("Downloads").ToString, dr.Item("Download_Date").ToString, dr.Item("Expire_Date").ToString, dr.Item("ID").ToString)
            End While
            dr.Close()
            cn.Close()
            For i = 0 To Guna2DataGridView1.Rows.Count - 1
                Dim r As DataGridViewRow = Guna2DataGridView1.Rows(i)
                r.Height = 50
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, Downloads.TextChanged
        Loadrecord()
    End Sub

    ReadOnly str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    ReadOnly con As New MySqlConnection(str)
    Private Sub Guna2DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim row As DataGridViewRow = Guna2DataGridView1.CurrentRow
        Dim opf As New OpenFileDialog
        If e.ColumnIndex = 7 Then
            If MsgBox("Are you sure want to delete?", vbYesNo) = vbYes Then
                Try
                    Downloads.Text = row.Cells(2).Value.ToString

                Catch ex As Exception
                    MsgBox("Something went wrong")
                    Exit Sub

                End Try
                Dim cmd As MySqlCommand
                con.Open()
                Try
                    cmd = con.CreateCommand()
                    cmd.CommandText = "delete from trail_details where Downloads=@firstname"
                    cmd.Parameters.AddWithValue("@firstname", Downloads.Text)
                    cmd.ExecuteNonQuery()
                    Try
                        Loadrecord()
                    Catch ex As Exception

                    End Try
                    MsgBox("Successfully Deleted")
                    con.Close()
                Catch ex As Exception

                End Try
            Else
                Exit Sub
            End If
        ElseIf e.ColumnIndex = 6 Then

            DetailtrailInterface.Auto_ID.Text = row.Cells(5).Value.ToString
            DetailtrailInterface.Guna2TextBox1.Text = row.Cells(1).Value.ToString
            DetailtrailInterface.Guna2TextBox2.Text = row.Cells(2).Value.ToString
            DetailtrailInterface.Guna2DateTimePicker1.Text = row.Cells(3).Value.ToString
            DetailtrailInterface.Guna2DateTimePicker2.Text = row.Cells(4).Value.ToString


            DetailtrailInterface.ShowDialog()


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshbtn.Click
        Getimagebyautoid()
        Loadrecord()
    End Sub
End Class