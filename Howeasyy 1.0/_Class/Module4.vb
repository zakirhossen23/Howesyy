Module Module4
    Public Sub Displaytab(ByVal form As Form, ByVal t As TabPage)
        't.Controls.Clear()
        form.Dock = DockStyle.Fill
        'form.Width = t.Width
        'form.Height = t.Height
        form.TopLevel = False
        form.Parent = t

        form.Show()
        form.BringToFront()

    End Sub


    Public Sub Displaypic(ByVal pic As PictureBox, ByVal picture As PictureBox)

        pic.Dock = DockStyle.Fill
        pic.Width = picture.Width
        pic.Height = picture.Height

        pic.Parent = picture

        pic.Show()
        pic.BringToFront()

    End Sub
End Module
