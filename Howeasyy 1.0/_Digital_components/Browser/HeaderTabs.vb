Public Class HeaderTabs
    Private IsSlected As Boolean
    Public Property SetSelect() As Boolean
        Get
            Return IsSlected
        End Get
        Set(ByVal value As Boolean)
            TitleConatiner.FillColor = If(value = False, Color.FromArgb(63, 65, 69), Color.FromArgb(83, 86, 91))
            IsSlected = value
        End Set
    End Property

    Private Sub img_Click(sender As Object, e As EventArgs) Handles img.Click

    End Sub
End Class
