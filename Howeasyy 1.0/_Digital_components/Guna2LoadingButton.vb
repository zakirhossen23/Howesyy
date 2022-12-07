
Public Class Guna2LoadingButton
    Dim Buttontext As String = "Loading Button"
    Dim LoadingText As String = "Loading..."
    Dim PanelDefaultColor As Object
    Dim TextDefaultColor As Object



    Public Property Textt As String
        Get
            Return Buttontext
        End Get
        Set(ByVal value As String)
            Buttontext = value
            Label2.Text = value
        End Set
    End Property
    Public Property TextLoading As String
        Get
            Return LoadingText
        End Get
        Set(ByVal value As String)
            LoadingText = value
        End Set
    End Property
    Dim LoadingPictureBox As Boolean
    Public Property LoadingShow As Boolean
        Get
            Return LoadingPictureBox
        End Get
        Set(ByVal value As Boolean)
            If (value = True) Then
                Me.Enabled = False
                Label2.Text = LoadingText
            Else
                Me.Enabled = True
                Label2.Text = Buttontext
            End If
            LoadingPictureBox = value
        End Set
    End Property
    'Public Property ButtonIconHeight As Size
    '    Get
    '        Return Guna2Button6.Size
    '    End Get
    '    Set(ByVal Size As Size)
    '        Guna2Button6.Size = Size

    '    End Set
    'End Property
    'Public Property CoverButtonFore As Color
    '    Get
    '        Return CoverButton.ForeColor
    '    End Get
    '    Set(ByVal Forecolor As Color)
    '        Guna2Button6.ForeColor = Forecolor

    '    End Set
    'End Property


    Private Sub Testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2MouseStateHandler1.Add(Guna2Panel1)
        Guna2MouseStateHandler1.Add(Label2)
        Guna2MouseStateHandler1.Add(Label1)
        PanelDefaultColor = Label1.BackColor
        TextDefaultColor = Label2.BackColor
    End Sub
    Event ButtonClick As EventHandler
    Private Sub Guna2MouseStateHandler1_PressedState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.PressedState
        RaiseEvent ButtonClick(Me, Nothing)
    End Sub
    Private Sub Guna2MouseStateHandler1_HoveredState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.HoverState
        Label1.BackColor = Color.Navy
        Label2.ForeColor = Color.DarkGray
    End Sub

    Private Sub Guna2MouseStateHandler1_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.IdleState
        Label1.BackColor = PanelDefaultColor
        Label2.ForeColor = TextDefaultColor
    End Sub
End Class
