Imports System
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports CSScreenRecorder
Public Class recordersettings
    Inherits Form

    Friend ScreenRecorder As ScreenRecorder
    Private Sub recordersettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.size1.Text = Screen.PrimaryScreen.Bounds.Width.ToString()
        Me.size2.Text = Screen.PrimaryScreen.Bounds.Height.ToString()

        Me.cboRotate.Items.Add("RotateNoneFlipNone")
        Me.cboRotate.Items.Add("RotateNoneFlipXY")
        Me.cboRotate.Items.Add("RotateNoneFlipY")

        Me.cboRotate.SelectedIndex = 0


        For Each prop As PropertyInfo In GetType(Color).GetProperties()
            If Equals(prop.PropertyType.FullName, "System.Drawing.Color") Then Me.cboSpinningToolColor.Items.Add(prop.Name)
        Next

        Me.cboSpinningToolColor.Text = "Red"
        Me.cboSpinningToolStyle.Text = "Dot"

        Using ScreenRecorder = New ScreenRecorder("UserName", "RegKey")

            For Each Codec As ScreenRecorder.Codecs In ScreenRecorder.GetCodecs()
                Console.WriteLine(Codec.CodecName)
                Me.cboVideoCodecs.Items.Add(Codec.CodecName)
            Next

            Me.cboVideoCodecs.SelectedIndex = 1

#Region "LoadAudioProperties"

            'Formats:
            Me.cboAudioFormat.DataSource = ScreenRecorder.GetAudioFormats()
            Me.cboAudioFormat.Text = "MP3"

            'Bitrate
            Me.cboBitrate.DataSource = ScreenRecorder.GetAudioBitrates()
            Me.cboBitrate.Text = "192"

            'Samplerate
            Me.cboSamplerate.DataSource = ScreenRecorder.GetAudioSamplerates()
            Me.cboSamplerate.Text = "44100"

            'Bit depth
            Me.cboBits.DataSource = ScreenRecorder.GetAudioBits()
            Me.cboBits.Text = "16"

            'Channels
            Me.cboChannels.DataSource = ScreenRecorder.GetAudioChannels()
            Me.cboChannels.Text = "2"

            'Recorder mode
            Me.cboRecorderMode.DataSource = ScreenRecorder.GetAudioModes()
            Me.cboRecorderMode.SelectedItem = ScreenRecorder.GetEnumValue(ScreenRecorder.AudioMode)

#End Region

        End Using

        Me.txtTop.Text = "0"
        Me.txtLeft.Text = "0"

        Me.txtWidth.Text = Screen.PrimaryScreen.Bounds.Width.ToString()
        Me.txtHeight.Text = Screen.PrimaryScreen.Bounds.Height.ToString()
        ComboBoxEx5.SelectedIndex = 0
    End Sub

    Friend Sub btnSpinningTool_Click(sender As Object, e As EventArgs) Handles btnSpinningTool.Click

        Dim SpinningSelection As SpinningSelection = New SpinningSelection()


        Using ScreenRecorder = New ScreenRecorder("UserName", "RegKey")
            ScreenRecorder.SpinningToolColor = Color.FromName(Me.cboSpinningToolColor.SelectedItem.ToString())

            ScreenRecorder.SpinningToolBorderSize = Integer.Parse(Me.txtSpinningToolBorder.Text)

            ScreenRecorder.SpinningToolStyle = CType(Drawing2D.DashStyle.DashDotDot, Drawing2D.DashStyle)

            AddHandler ScreenRecorder.OnSpinningSelection, Sub(o, Cancel, Top, Left, Width, Height)
                                                               If Cancel Then
                                                                   Me.txtLog.Text = Me.txtLog.Text & Date.Now & ":Spinner tool canceled" & Microsoft.VisualBasic.Constants.vbCrLf
                                                               Else
                                                                   Me.txtTop.Text = Top.ToString()
                                                                   Me.txtLeft.Text = Left.ToString()
                                                                   Me.txtWidth.Text = Width.ToString()
                                                                   Me.txtHeight.Text = Height.ToString()
                                                                   Me.size1.Text = Width.ToString()
                                                                   Me.size2.Text = Height.ToString()
                                                                   Me.txtLog.Text = Me.txtLog.Text & Date.Now & ":Spinner tool selected - " & Top & " " & Left & " " & Width & " " & Height & Microsoft.VisualBasic.Constants.vbCrLf
                                                               End If
                                                           End Sub


            SpinningSelection = ScreenRecorder.SpinningTool()

        End Using

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Dim activewindow As ActiveWindow = New ActiveWindow()
        activewindow = ScreenRecorder.GetActiveWindow()

        Me.txtTop.Text = activewindow.Top.ToString()
        Me.txtLeft.Text = activewindow.Left.ToString()
        Me.txtWidth.Text = activewindow.Width.ToString()
        Me.txtHeight.Text = activewindow.Height.ToString()
    End Sub

    Private Sub btnActiveWindow_Click(sender As Object, e As EventArgs) Handles btnActiveWindow.Click
        If Not Me.timer1.Enabled Then
            Me.timer1.Enabled = True
            Me.btnActiveWindow.Text = "Stop"
        Else
            Me.timer1.Enabled = False
            Me.btnActiveWindow.Text = "Get active window"
        End If
    End Sub

    <Obsolete>
    Private Sub cmdRecord_Click(sender As Object, e As EventArgs) Handles cmdRecord.Click

        Using CSharpImpl.__Assign(ScreenRecorder, New ScreenRecorder("UserName", "RegKey"))
#Region "Area"

            'Set the area to record
            ScreenRecorder.RecordScreenHeight = Integer.Parse(Me.txtHeight.Text)
            ScreenRecorder.RecordScreenWidth = Integer.Parse(Me.txtWidth.Text)
            ScreenRecorder.RecordScreenTop = Integer.Parse(Me.txtTop.Text)
            ScreenRecorder.RecordScreenLeft = Integer.Parse(Me.txtLeft.Text)

#End Region

#Region "Video"

            ScreenRecorder.VideoFPS = 10
            ScreenRecorder.VideoEncoderQuality = Me.trcVideoEncoderQuality.Value
            Me.picPreview.SizeMode = PictureBoxSizeMode.StretchImage

            ScreenRecorder.VideoCodecIndex = Me.cboVideoCodecs.SelectedIndex

#End Region

#Region "Audio"


            ScreenRecorder.AudioRecorder = Me.chkRecordAudio.Checked


            ScreenRecorder.AudioDeviceIndex = Me.cboAudioSource.SelectedIndex


            ScreenRecorder.AudioMode = CType([Enum].Parse(GetType(CSScreenAudioRecorder.Mode), Me.cboRecorderMode.Text), CSScreenAudioRecorder.Mode)

            ScreenRecorder.AudioSamplerate = CType([Enum].Parse(GetType(CSScreenAudioRecorder.Samplerate), Me.cboSamplerate.Text), CSScreenAudioRecorder.Samplerate)

            ScreenRecorder.AudioBits = CType([Enum].Parse(GetType(CSScreenAudioRecorder.Bits), Me.cboBits.Text), CSScreenAudioRecorder.Bits)


            ScreenRecorder.AudioChannels = CType([Enum].Parse(GetType(CSScreenAudioRecorder.Channels), Me.cboChannels.Text), CSScreenAudioRecorder.Channels)

            ScreenRecorder.AudioFormat = CType([Enum].Parse(GetType(CSScreenAudioRecorder.Format), Me.cboAudioFormat.Text), CSScreenAudioRecorder.Format)

            ScreenRecorder.AudioBitrate = CType([Enum].Parse(GetType(CSScreenAudioRecorder.Bitrate), Me.cboBitrate.Text), CSScreenAudioRecorder.Bitrate)

#End Region

#Region "Style"

            ScreenRecorder.TrackMouse = Me.chkTrackMouse.Checked


            ScreenRecorder.Rotate = RotateStyle.RotateNoneFlipNone
            If Equals(Me.cboRotate.Text, "RotateNoneFlipXY") Then ScreenRecorder.Rotate = RotateStyle.RotateNoneFlipXY
            If Equals(Me.cboRotate.Text, "RotateNoneFlipY") Then ScreenRecorder.Rotate = RotateStyle.RotateNoneFlipY

            ScreenRecorder.WatermarkFont = New Font(New Font("Arial", 32), FontStyle.Underline)
            ScreenRecorder.WatermarkText = Me.txtWatermarkText.Text

#End Region

#Region "Events"

            AddHandler ScreenRecorder.OnStartRecord, Sub(o)
                                                         Me.lblPreview.Visible = False
                                                         Me.txtLog.Text = Me.txtLog.Text & Date.Now & ":Start record" & Microsoft.VisualBasic.Constants.vbCrLf
                                                     End Sub



            AddHandler ScreenRecorder.OnPauseRecord, Sub(o) Me.txtLog.Text = Me.txtLog.Text & Date.Now & ":Pause record" & Microsoft.VisualBasic.Constants.vbCrLf

            AddHandler ScreenRecorder.OnUnPauseRecord, Sub(o) Me.txtLog.Text = Me.txtLog.Text & Date.Now & ":Unpause record" & Microsoft.VisualBasic.Constants.vbCrLf

            AddHandler ScreenRecorder.OnStopRecord, Sub(o)
                                                        Me.lblPreview.Visible = True
                                                        Me.txtLog.Text = Me.txtLog.Text & Date.Now & ":Stop record" & Microsoft.VisualBasic.Constants.vbCrLf
                                                    End Sub

            AddHandler ScreenRecorder.OnPreview, Sub(o, bmp)
                                                     Dim pImage As Bitmap = New Bitmap(bmp)
                                                     picPreview.Image = pImage
                                                 End Sub

            AddHandler ScreenRecorder.OnError, Sub(o, ErrorMessage, ErrorNumber) Me.txtLog.Text = Me.txtLog.Text & Date.Now & ":Error - " & ErrorMessage & " (" & ErrorNumber & ")" & Microsoft.VisualBasic.Constants.vbCrLf

#End Region



            Me.txtFileName.Text = Application.StartupPath & "\" & Date.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".avi"
            ScreenRecorder.FileName = Me.txtFileName.Text

            ScreenRecorder.Record()

        End Using


    End Sub

    Private Sub cmdStopRec_Click(sender As Object, e As EventArgs) Handles cmdStopRec.Click
        Try
            ScreenRecorder.Stop()
            Try
                If MsgBox("Record stopped! Do you want to play the video?", vbYesNo) = vbYes Then
                    Process.Start(txtFileName.Text)
                Else

                End If

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
        picPreview.Image = Nothing
        cmdStopRec.Visible = False
    End Sub

    Private Sub cmdPauseIn_Click(sender As Object, e As EventArgs) Handles cmdPauseIn.Click
        ScreenRecorder.Pause()
    End Sub

    Private Sub cmdUnPauseIn_Click(sender As Object, e As EventArgs) Handles cmdUnPauseIn.Click
        ScreenRecorder.UnPause()
    End Sub

    ''' <summary>
    ''' Order a license.
    ''' </summary>


    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class

    Private Sub cboRecorderMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRecorderMode.SelectedIndexChanged
        Using ScreenRecorder = New ScreenRecorder("UserName", "RegKey")
            Dim mode As CSScreenAudioRecorder.Mode = [Enum].Parse(GetType(CSScreenAudioRecorder.Mode), Me.cboRecorderMode.Text)

            Me.cboAudioSource.DataSource = ScreenRecorder.GetDevices(mode)

            Dim default_device_index As Integer = ScreenRecorder.GetDeviceDefaultIndex(mode)

            If default_device_index <> -1 Then
                Me.cboAudioSource.SelectedIndex = default_device_index
            Else
                Me.cboAudioSource.SelectedIndex = 0
            End If
        End Using
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub lblPreview_Click(sender As Object, e As EventArgs) Handles lblPreview.Click

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock


        size1.Text = Screen.PrimaryScreen.Bounds.Width.ToString()
        size2.Text = Screen.PrimaryScreen.Bounds.Height.ToString()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        ButtonX2.Enabled = False
        btnSpinningTool.PerformClick()
        ButtonX2.Enabled = True
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer)) Then
            IconButton1.IconColor = Color.Black
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.LockOpen



        ElseIf IconButton1.IconColor = Color.Black Then
            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock
        End If
    End Sub

    Private Sub ComboBoxEx5_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxEx5.TextChanged
        If ComboBoxEx5.Text = "2160p: 3840x2160" Then
            size1.Text = "3840"
            size2.Text = "2160"


            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock

        Else

        End If
        If ComboBoxEx5.Text = "1440p: 2560x1440" Then
            size1.Text = "2560"
            size2.Text = "1440"


            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock

        Else
        End If
        If ComboBoxEx5.Text = "1080p: 1920x1080" Then
            size1.Text = "1920"
            size2.Text = "1080"


            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock

        Else
        End If
        If ComboBoxEx5.Text = "720p: 1280x720" Then
            size1.Text = "1280"
            size2.Text = "720"

            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock

        Else
        End If
        If ComboBoxEx5.Text = "480p: 854x480" Then
            size1.Text = "854"
            size2.Text = "480"

            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock

        Else
        End If
        If ComboBoxEx5.Text = ("360p: 640x360") Then
            size1.Text = "640"
            size2.Text = "360"


            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock

        Else
        End If
        If ComboBoxEx5.Text = ("240p: 426x240") Then
            size1.Text = "426"
            size2.Text = "240"



            IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(2, Byte), Integer))
            Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock


        Else

        End If
        If ComboBoxEx5.Text = ("Custom") Then

        Else

        End If
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        cmdRecord.PerformClick()
        cmdStopRec.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        ElseIf CheckBox1.Checked = False Then
            Me.TopMost = False
        End If
    End Sub


    Private Sub chkRecordAudio_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecordAudio.CheckedChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub btnaudioold_Click(sender As Object, e As EventArgs) Handles btnaudioold.Click
        If btnaudioold.Symbol = "57423" Then '' Not audio
            btnaudioold.Symbol = "57424"
            chkRecordAudio.Checked = False
        ElseIf btnaudioold.Symbol = "57424" Then ''Audio
            btnaudioold.Symbol = "57423"
            chkRecordAudio.Checked = True
        Else

        End If
    End Sub
End Class