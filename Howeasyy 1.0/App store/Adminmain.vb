Public Class Adminmain


    Private Sub Adminmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DesktopBTN.PerformClick()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DesktopBTN_Click(sender As Object, e As EventArgs) Handles DesktopBTN.Click
        AdminDesktopFlow.closebtn.PerformClick()
        DisplayForm(AdminDesktopFlow, Me.Panel3)
        WebBTN.Checked = False
        DesktopBTN.Checked = True
        MobileBTN.Checked = False
    End Sub

    Private Sub WebBTN_Click(sender As Object, e As EventArgs) Handles WebBTN.Click
        AdminDesktopFlow.closebtn.PerformClick()
        DisplayForm(AdminWebFlow, Me.Panel3)

        WebBTN.Checked = True
        DesktopBTN.Checked = False
        MobileBTN.Checked = False
    End Sub

    Private Sub MobileBTN_Click(sender As Object, e As EventArgs) Handles MobileBTN.Click
        DisplayForm(AdminMobileFlow, Me.Panel3)

        WebBTN.Checked = False
        DesktopBTN.Checked = False
        MobileBTN.Checked = True
    End Sub
End Class