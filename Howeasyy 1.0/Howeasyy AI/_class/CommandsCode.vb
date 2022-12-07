Imports System.Speech.Synthesis
Imports System.Text.RegularExpressions

Public Class CommandsCode
    Dim AllCommands As New Dictionary(Of Integer, String())

    Public Sub DoWork(WorkID As Integer)
        Select Case WorkID
            Case 2
                Dim howeasyyAI As HoweasyyAi = Application.OpenForms("HoweasyyAi")
                howeasyyAI.WindowState = FormWindowState.Minimized
            Case 3
                Dim mainpage As Mainpage = Application.OpenForms("MainPage")
                mainpage.AppStoreBTN.PerformClick()

            Case FirstIntegerWeb To LastIntegerWeb
                Dim mainpage As Mainpage = Application.OpenForms("MainPage")
                mainpage.AppStoreBTN.PerformClick()
                Dim flowmainPage As FlowMain = mainpage.FromHolder.Controls().Item(0)
                flowmainPage.WebBTN.PerformClick()
                Dim flowwebPage As WebFlow = flowmainPage.Panel2.Controls().Item(0)
                flowwebPage.LunchBrowseLink(AllCommands(WorkID).GetValue(2))


            Case LastIntegerWeb
                Dim mainpage As Mainpage = Application.OpenForms("MainPage")
                mainpage.BrowserBTN.PerformClick()
            Case LastIntegerWeb + 1
                SendKeys.Send("^+{a}+{DELETE}")

        End Select
    End Sub
    Dim FirstIntegerWeb As Integer = 3
    Dim LastIntegerWeb As Integer = 0
    Private Sub readFromWeb()
        Dim lines As String() = System.IO.File.ReadAllLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/webApps.csv")
        For Each line In lines
            Dim allSplitted = line.Split(",")
            Dim onlyWWWTOEND As String = Regex.Match(allSplitted(1).ToString, "www[^/]+").Value
            Dim onlyStartTOEND As String = Regex.Match(allSplitted(1).ToString, "\w[com][^/]+").Value
            AllCommands.Add(AllCommands.Count + 1, {AllCommands.Count + 1, allSplitted(0).ToLower, allSplitted(1), onlyWWWTOEND, onlyStartTOEND, $"{allSplitted(0).ToLower} in app store", $"{allSplitted(0).ToLower} in web app store", $"open {allSplitted(0).ToLower} in web app store", $"open {allSplitted(0).ToLower} in app store"})
        Next
        LastIntegerWeb = AllCommands.Count + 1

    End Sub
    Public Sub InitializeCommands()
        AllCommands.Add(1, {1, "hi", "hello", "hey"})
        AllCommands.Add(2, {2, "minimize"})
        AllCommands.Add(3, {3, "app store", "open app store", "go to app store", "all apps", "app store open"})
        readFromWeb()
        AllCommands.Add(AllCommands.Count + 1, {LastIntegerWeb, "home", "browser", "open browser", "go to browser"})
        AllCommands.Add(AllCommands.Count + 1, {LastIntegerWeb + 1, "clear"})
        AllCommands.Add(AllCommands.Count + 1, {LastIntegerWeb + 2, "stop", "cancel", "cancel ai"})
        'About Browser
        AllCommands.Add(AllCommands.Count + 1, {LastIntegerWeb + 3, "howeasyy.com", "open howeasyy", "open howeasyy.com", "go to howeasyy", "go to howeasyy.com", "https://www.howeasyy.com"})
        AllCommands.Add(AllCommands.Count + 1, {LastIntegerWeb + 4, "howeasyymusic.com", "howeasyy music", "open howeasyy music", "go to howeasyy music"})

    End Sub
    Public Function ReturnCommandsArray()
        Dim SearchedCommands As List(Of String) = New List(Of String)
        For index = 0 To AllCommands.Count - 1
            For index2 = 1 To AllCommands.Values(index).Length - 1
                Dim TextInput = AllCommands.Values(index).GetValue(index2)
                SearchedCommands.Add(TextInput)
            Next
        Next
        Return SearchedCommands
    End Function
    Public Sub WorkCommand(number As Integer)
        Select Case number
            Case 0
                HoweasyyAi.ss.SpeakAsync("Command not found!")
            Case 1
                HoweasyyAi.ss.SpeakAsync("Hello, I am Howeasy A I")
            Case 2
                DoWork(2)
                HoweasyyAi.ss.SpeakAsync("Minimized")
            Case 3
                DoWork(3)
                HoweasyyAi.ss.SpeakAsync("Opened App Store")
            Case FirstIntegerWeb To LastIntegerWeb
                DoWork(number)
                HoweasyyAi.ss.SpeakAsync("Opened")
            Case LastIntegerWeb
                DoWork(LastIntegerWeb)
                HoweasyyAi.ss.SpeakAsync("Opened Browser")
            Case LastIntegerWeb + 1
                DoWork(LastIntegerWeb + 1)
                HoweasyyAi.ss.SpeakAsync("Cleared")
        End Select

        AddHandler HoweasyyAi.ss.SpeakCompleted, AddressOf Spoken

    End Sub

    Private Sub Spoken(sender As Object, e As SpeakCompletedEventArgs)
        HoweasyyAi.Playtext = False
    End Sub

    Public Function checkArray(arrayText As String(), Searchtext As String) As Boolean
        Dim objs As List(Of String) = arrayText.Where(Function(x) x.Contains(Searchtext)).ToList()
        If (objs.Count > 0) Then
            Return True
        End If
        Return False
    End Function

    Public Function GetCommands(TextSearch As String)
        TextSearch = TextSearch.ToLower()
        Dim foundList As List(Of String()) = AllCommands.Values.Where(Function(x) checkArray(x, TextSearch)).ToList()

        If (foundList.Count > 0) And TextSearch IsNot "" Then
            Return foundList.Item(0)(0)
        End If
        Return 0
    End Function
End Class
