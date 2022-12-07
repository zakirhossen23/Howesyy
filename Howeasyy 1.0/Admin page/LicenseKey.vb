Imports FoxLearn.License
Public Class LicenseKey
    Private Sub Guna2LoadingButton1_ButtonClick(sender As Object, e As EventArgs) Handles Guna2LoadingButton1.ButtonClick
#Region "enable Loading"
        Guna2LoadingButton1.LoadingShow = True
        LoadingPictureBox.Visible = True
        Guna2ProgressBar1.Visible = True
#End Region
#Region "Working"
        Dim km As KeyManager = New KeyManager(EmailBox.Text)
        Dim kv As KeyValuesClass
        Dim productKey As String = String.Empty

        If LicenseType.SelectedIndex = 0 Then
            kv = New KeyValuesClass() With {
                    .Type = FoxLearn.License.LicenseType.FULL,
                    .Header = Convert.ToByte(9),
                    .Footer = Convert.ToByte(6),
                    .ProductCode = CByte(EmailBox.Text),
                    .Edition = "Howeasyy",
                    .Version = 1
                }
            If Not km.GenerateKey(kv, productKey) Then ProductKeyTXT.Text = "ERROR"
        Else
            kv = New KeyValuesClass() With {
                   .Type = FoxLearn.License.LicenseType.FULL,
                    .Header = Convert.ToByte(9),
                    .Footer = Convert.ToByte(6),
                    .ProductCode = CByte(EmailBox.Text),
                    .Edition = "Howeasyy",
                    .Version = 1,
                    .Expiration = Date.Now.Date.AddDays(Convert.ToInt32(ExperienceDay.Text))
                }
            If Not km.GenerateKey(kv, productKey) Then ProductKeyTXT.Text = "ERROR"
        End If

        ProductKeyTXT.Text = productKey
#End Region

#Region "Done Working"
        Guna2LoadingButton1.LoadingShow = False
        LoadingPictureBox.Visible = False
        Guna2ProgressBar1.Visible = False

#End Region
    End Sub
End Class
