
Public Class DigitalButton

    Public Property ButtonText As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property

    Public Property ButtonIcon As String
        Get
            Return Guna2Button6.Text
        End Get
        Set(ByVal value As String)
            Guna2Button6.Text = value
        End Set
    End Property
    Public Property ButtonIconHeight As Size
        Get
            Return Guna2Button6.Size
        End Get
        Set(ByVal Size As Size)
            Guna2Button6.Size = Size

        End Set
    End Property
    Public Property CoverButtonFore As Color
        Get
            Return CoverButton.ForeColor
        End Get
        Set(ByVal Forecolor As Color)
            Guna2Button6.ForeColor = Forecolor

        End Set
    End Property


    Private Sub Testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2MouseStateHandler1.Add(Guna2Panel1)
        Guna2MouseStateHandler1.Add(Label1)
        Guna2MouseStateHandler1.Add(CoverButton)
    End Sub
    Event ButtonClick As EventHandler
    Private Sub Guna2MouseStateHandler1_PressedState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.PressedState
        RaiseEvent ButtonClick(Me, Nothing)
    End Sub

    Private Sub CoverButton_Click(sender As Object, e As EventArgs) Handles CoverButton.Click

    End Sub
End Class
