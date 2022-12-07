Imports MySql.Data.MySqlClient
Imports System.IO
Public Class DevArea


    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub DevArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection()
        cn.ConnectionString = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        codeinsert.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBoxEx1.SelectedIndex = 0
        ComboBoxEx1.Visible = True
        ComboBoxEx1.WatermarkText = "Programming"
    End Sub

    Private Sub ComboBoxEx1_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.TextChanged
        LoadData()
    End Sub

    Friend Sub LoadData()
        cn.Close()
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select * from developerarea where CodeLanuage like '%" & ComboBoxEx1.Text & "%'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("Pic"), dr.Item("SourceCode").ToString, dr.Item("CodeLanuage").ToString, dr.Item("SourceDescription").ToString, dr.Item("ID").ToString)
        End While
        dr.Close()
        cn.Close()
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 100%
        Next
    End Sub
    Dim view As New Form
    Dim codetext As New RichTextBox
    Dim copy As New Button
    Dim buttonpanel As New Panel
    Dim textpanel As New Panel

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        If e.ColumnIndex = 1 Then
            ''''''''''''''''''''''''''''''
            view.Size = New Point(968, 539)
            view.StartPosition = FormStartPosition.CenterScreen
            copy.Enabled = True

            buttonpanel.Size = New Point(0, 26)

            view.ShowIcon = False
            view.ShowInTaskbar = False
            copy.Text = "Copy Code"

            codetext.Text = row.Cells(1).Value.ToString

            codetext.SelectAll()

            codetext.Dock = DockStyle.Fill
            textpanel.Controls.Add(codetext)

            buttonpanel.Controls.Add(copy)
            buttonpanel.Dock = DockStyle.Bottom

            textpanel.Dock = DockStyle.Fill
            textpanel.BringToFront()
            textpanel.AutoSize = True

            view.Controls.Add(buttonpanel)
            view.Controls.Add(textpanel)

            AddHandler copy.Click, AddressOf copy_click
            view.ShowDialog()


            '''''''''''''''''''''''''''
        End If

        If e.ColumnIndex = 6 Then
            Try
                TextBox1.Text = row.Cells(4).Value.ToString
            Catch ex As Exception
            End Try
            DevAreaUpdate.TextBox3.Text = TextBox1.Text
            DevAreaUpdate.ShowDialog()

        End If
        If e.ColumnIndex = 7 Then
            If MsgBox("Are you sure want to Delete?", vbYesNo) = vbYes Then
                TextBox1.Text = row.Cells(4).Value.ToString
                Dim cmd As MySqlCommand
                Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
                Dim con As New MySqlConnection(str)
                con.Open()
                Try
                    cmd = con.CreateCommand()
                    cmd.CommandText = "delete from developerarea where ID=@ID"
                    cmd.Parameters.AddWithValue("@ID", TextBox1.Text)
                    cmd.ExecuteNonQuery()
                    LoadData()
                    MsgBox("Successfully Deleted")
                    con.Close()
                Catch ex As Exception
                End Try
            Else
                Exit Sub
            End If

        End If
    End Sub

    Private Sub copy_click(sender As Object, e As EventArgs)

        My.Computer.Clipboard.SetText(codetext.Text)
        copy.Enabled = False
        view.Close()
    End Sub

End Class