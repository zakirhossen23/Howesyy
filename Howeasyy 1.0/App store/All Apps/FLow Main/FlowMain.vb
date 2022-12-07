Imports System.Data.OleDb
Imports System.Data

Public Class FlowMain
    Dim ll, ii, pp As Integer
    Dim txt As String
    Dim dtPurchase As DataTable

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBTN.Click
        If MsgBox("Are you sure you want to Quit?", vbYesNo) = vbYes Then
            Application.Exit()

        Else
            Exit Sub
        End If
        Status.AddStatus("Exit")
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DesktopBTN.PerformClick()
    End Sub

    Private Sub SearchTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchTXT.TextChanged
        If DesktopBTN.Checked = True Then
            DesktopFlow.TextBoxX1.Text = SearchTXT.Text

        ElseIf WebBTN.Checked = True Then
            WebFlow.TextBoxX1.Text = SearchTXT.Text

        ElseIf MobileBTN.Checked = True Then

            MobileFlow.TextBoxX1.Text = SearchTXT.Text
        End If
    End Sub

    Private Sub DesktopBTN_Click(sender As Object, e As EventArgs) Handles DesktopBTN.Click

        DisplayForm(DesktopFlow, Me.Panel2)
        WebBTN.Checked = False
        DesktopBTN.Checked = True
        MobileBTN.Checked = False
        DesktopFlow.TextBoxX1.Text = SearchTXT.Text

        Status.AddStatus("Desktop")
    End Sub

    Private Sub WebBTN_Click(sender As Object, e As EventArgs) Handles WebBTN.Click
        DisplayForm(WebFlow, Me.Panel2)
        WebBTN.Checked = True
        DesktopBTN.Checked = False
        MobileBTN.Checked = False
        WebFlow.TextBoxX1.Text = SearchTXT.Text
        Status.AddStatus("Web")
    End Sub

    Private Sub MobileBTN_Click(sender As Object, e As EventArgs) Handles MobileBTN.Click
        DisplayForm(MobileFlow, Me.Panel2)
        MobileFlow.TextBoxX1.Text = SearchTXT.Text
        WebBTN.Checked = False
        DesktopBTN.Checked = False
        MobileBTN.Checked = True
        Status.AddStatus("Mobile")
    End Sub

    Private Sub CheckoutBTN_Click(sender As Object, e As EventArgs) Handles CheckoutBTN.Click
        Me.Collectingmoney.Visible = False

    End Sub

    Private Sub BuyLogsBTN_Click(sender As Object, e As EventArgs) Handles BuyLogsBTN.Click

    End Sub


End Class