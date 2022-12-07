Public Class forgotpassconnect
    Private Sub forgotpassconnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayForm(Forgotpass, Me.Panel1)
        'DisplayForm(resetpass, Me.Panel1)
    End Sub

    Private Sub forgotpassconnect_LostFocus(sender As Object, e As EventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class