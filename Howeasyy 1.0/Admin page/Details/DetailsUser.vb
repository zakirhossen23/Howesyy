Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class DetailsUser
#Region "initialize"
    Dim str As String = "server=184.154.69.83; uid=howeasyyweb_howeasyy; pwd=8WU6eieKTK0J; database=howeasyyweb_howeasyy"
    Dim con As New MySqlConnection(str)

    Friend email As String
    Friend currentKeyID As Integer = 1
#End Region


    Dim status As Int32
    Friend serialKey As String


    Private Sub ActivateBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateBTN.Click
        DoActivate(1)
    End Sub

    Private Sub DeactivateBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeactivateBTN.Click
        DoActivate(0)
    End Sub
    Friend Sub DoActivate(stat As Integer)
        If (stat = 0) Then
            status = 0
            DeactivateBTN.Checked = True
            ActivateBTN.Checked = False
        Else
            status = 1
            ActivateBTN.Checked = True
            DeactivateBTN.Checked = False

        End If
        SaveBTN.Checked = False
    End Sub
    Dim isworking As Boolean = False

    Private Async Sub updatesave()
        Try
            Dim cmd As MySqlCommand
            con.Open()
            Dim ms As New MemoryStream



            cmd = con.CreateCommand()
            Dim SQLText = String.Format("update login set Status={0}, Serial='{1}' where Auto_ID={2}", status.ToString, serialKey.ToString, TXT_IDNo.Text.ToString)

            cmd.CommandText = SQLText
            Dim result = Await cmd.ExecuteNonQueryAsync()
            SaveBTN.Checked = False
            isworking = False
            SaveBTN.Text = "Saved"
            SaveBTN.Cursor = Cursors.Hand
            con.Close()

        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub
    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        If (isworking = False) Then
            isworking = True
            SaveBTN.Text = "Saving.."
            SaveBTN.Cursor = DefaultCursor
            SaveBTN.Checked = True
            updatesave()
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles GenereateKeyBTN.Click
        Dim generate = New SKGL.Generate()
        generate.secretPhase = email
        serialKey = generate.doKey(Convert.ToInt32(TrialDayTXT.Text))
        SerialKeyTXT.Text = serialKey
    End Sub

    Private Sub SerialKeyTXT_TextChanged(sender As Object, e As EventArgs) Handles SerialKeyTXT.TextChanged
        If (serialKey IsNot Nothing) Then
            Dim validator = New SKGL.Validate()
            validator.secretPhase = email
            validator.Key = serialKey
            Dim daysLeft = validator.DaysLeft
            TrialDayTXT.Value = daysLeft

        End If
    End Sub
End Class