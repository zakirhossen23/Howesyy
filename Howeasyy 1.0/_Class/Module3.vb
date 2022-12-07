Imports DevComponents.DotNetBar

Module Module3
    Public Sub DisplayForm(ByVal frm As Form, ByVal pnl As Panel)
        pnl.Controls.Clear()
        frm.Dock = DockStyle.Fill

        frm.TopLevel = False
        frm.Parent = pnl
        Try
            frm.Show()
        Catch ex As Exception
            MsgBox("Check your connection!")
        End Try

        frm.BringToFront()
    End Sub
    Public Sub DisplayPanelandgroup(ByVal frm As Panel, ByVal pnl As Guna.UI2.WinForms.Guna2GroupBox)
        pnl.Controls.Clear()

        frm.Dock = DockStyle.Fill

        frm.BringToFront()
        pnl.Controls.Add(frm)
        frm.Show()

    End Sub

    Public Sub DisplayFormwithoutclear(ByVal frm As Form, ByVal pnl As Panel)
        frm.BringToFront()
        frm.Dock = DockStyle.Fill
        frm.TopLevel = False
        pnl.Controls.Add(frm)
        Try
            frm.Show()
        Catch ex As Exception

        End Try

        frm.BringToFront()

    End Sub
    Public Sub DisplayFormTab(ByVal frm As Form, ByVal Tab As TabControlPanel)

        frm.Dock = DockStyle.Fill
        frm.TopLevel = False

        frm.BringToFront()
        Tab.Controls.Add(frm)
        frm.Show()


    End Sub
End Module
