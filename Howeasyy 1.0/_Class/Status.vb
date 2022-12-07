Public Class Status
    Public Shared statusTXT As String = ""
    Public Shared Allstatus As New ArrayList

    Public Shared Sub Reset()
        statusTXT = ""
        Allstatus = New ArrayList
    End Sub

    Public Shared Sub AddStatus(ByVal text As String)
        Status.statusTXT = text
        Status.Allstatus.Add(text)
    End Sub

End Class
