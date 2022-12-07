Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Speech
Imports System.Speech.Synthesis
Imports System.Speech.Recognition
Imports System.Threading

Public Class HoweasyyAi
    Public ReadOnly ss As SpeechSynthesizer = New SpeechSynthesizer()
    Private ReadOnly pb As PromptBuilder = New PromptBuilder()
    Private ReadOnly sre As SpeechRecognitionEngine = New SpeechRecognitionEngine()
    Private ReadOnly clist As Choices = New Choices()


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ButtonTransition1.HideSync(Guna2Button1)
        ButtonTransition1.ShowSync(Guna2Button2)
        Guna2Button1.Enabled = False
        Guna2Button2.Enabled = True
        Dim CommandsCode As New CommandsCode
        CommandsCode.InitializeCommands()
        Dim GrmamerLists As List(Of String) = CommandsCode.ReturnCommandsArray()
        Dim allInputSTring() As String = GrmamerLists.ToArray()
        clist.Add(allInputSTring)
        Dim gr As Grammar = New Grammar(New GrammarBuilder(clist))

        Try
            sre.RequestRecognizerUpdate()
            sre.LoadGrammar(gr)
            AddHandler sre.SpeechRecognized, AddressOf Sre_SpeechRecognized
            sre.SetInputToDefaultAudioDevice()

            sre.RecognizeAsync(RecognizeMode.Single)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ButtonTransition1.ShowSync(Guna2Button1)
        ButtonTransition1.HideSync(Guna2Button2)

        sre.RecognizeAsyncStop()

        Guna2Button1.Enabled = True
        Guna2Button2.Enabled = False
        RemoveHandler sre.SpeechRecognized, AddressOf Sre_SpeechRecognized
    End Sub
    Private Sub Sre_SpeechRecognized(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)

        TextBox2.Text = e.Result.Text.ToString()
        IconButton1.PerformClick()

        'TextBox1.Text += "Me:" & (e.Result.Text.ToString()) & "--" & TimeOfDay & Environment.NewLine
        'Select Case e.Result.Text.ToString()
        '    Case ""
        '        Exit Select
        '    Case "hi"
        '        TextBox1.Text += "Howeasyy Assistant:hello it's Howeasyy Bot" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("hello it's Howeasyy Bot")
        '        Exit Select

        '    Case "minimize"
        '        Me.WindowState = FormWindowState.Minimized
        '        TextBox1.Text += "Howeasyy Assistant:minimized" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("minimized")
        '        Exit Select


        '    Case "open app store"
        '        Mainpage.AppStoreBTN.PerformClick()
        '        TextBox1.Text += "Howeasyy Assistant:opened app store" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("opened app store")
        '        Exit Select

        '    Case "go to app store"
        '        Mainpage.AppStoreBTN.PerformClick()
        '        TextBox1.Text += "Howeasyy Assistant:opened app store" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("opened app store")
        '        Exit Select


        '    Case "go to browser"
        '        Mainpage.BrowserBTN.PerformClick()
        '        TextBox1.Text += "Howeasyy Assistant:opened browser" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("opened browser")
        '        Exit Select

        '    Case "open howeasyy recorder"
        '        Mainpage.IconButton16.PerformClick()
        '        TextBox1.Text += "Howeasyy Assistant:opened howeasyy recorder" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("opened howeasyy recorder")
        '        Exit Select



        '    Case "full screen"
        '        Me.WindowState = FormWindowState.Maximized
        '        TextBox1.Text += "Howeasyy Assistant:maximized" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("maximized")
        '        Exit Select


        '    Case "who are you"
        '        TextBox1.Text += "Howeasyy Assistant:I am a Howeasyy 1.0 User Guider." & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("I am a Howeasyy 1.0 User Guider. ")
        '        Exit Select
        '    Case "help me"
        '        TextBox1.Text += "Howeasyy Assistant:How may I help you?" & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("How may I help you?")
        '        Exit Select
        '    Case "bye"
        '        Close()
        '    Case "tell me about howeasyy"
        '        TextBox1.Text += "Howeasyy Assistant:The Howeasyy Social Networking is a suite of innovation technology products to help you build your brand and connect with your customers in a better way online." & "--" & TimeOfDay & Environment.NewLine
        '        ss.Speak("The Howeasyy Social Networking is a suite of innovation technology products to help you build your brand and connect with your customers in a better way online.")
        '        Exit Select
        '    Case "clear"
        '        TextBox1.Clear()
        '        TextBox1.Text += "Cleared" & "--" & TimeOfDay & Environment.NewLine
        '        TextBox1.Text += "Me:" & (e.Result.Text.ToString()) & "--" & TimeOfDay & Environment.NewLine
        '        Exit Select
        '    Case "stop"
        '        Call Guna2Button2_Click(sender, e)
        '        Exit Select
        'End Select


    End Sub



    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        sre.RecognizeAsyncStop()

        Guna2Button1.Enabled = True
        Guna2Button2.Enabled = False
        RemoveHandler sre.SpeechRecognized, AddressOf Sre_SpeechRecognized
    End Sub
    Public Playtext As Boolean

    Private Async Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Playtext = True
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.EllipsisH
        Dim commandcode As New CommandsCode
        commandcode.InitializeCommands()
        commandcode.WorkCommand(Integer.Parse(commandcode.GetCommands(TextBox2.Text)))

        Do Until Playtext = False
            Await Task.Delay(25)
        Loop


        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Play

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            IconButton1.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LoadCommandsList()
        Dim commandcode As New CommandsCode
        commandcode.InitializeCommands()
        Dim allCommands = commandcode.ReturnCommandsArray()
        For index = 0 To allCommands.count - 1
            TextBox3.Text = TextBox3.Text + vbNewLine + allCommands(index)
        Next

    End Sub
    Private Sub HoweasyyAi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCommandsList()
    End Sub
End Class