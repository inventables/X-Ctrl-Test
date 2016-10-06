Public Class FormMain
    Dim WithEvents grbl As GrblInterface
    Dim JogIncrement As Single = 1.0

    Const APP_NAME As String = "X-Controller Test Program"
    Const APP_REV As String = "1.3.0"


    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbl = New GrblInterface
        grbl.AutoStatusUpdates = True
        ButtonInc1.PerformClick()

        Me.Width = LabelJogIncrement.Left + LabelJogIncrement.Width + 302@

    End Sub

    Private Sub refreshPorts()
        ComboBoxPorts.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBoxPorts.Items.Add(sp)
        Next

        If ComboBoxPorts.Items.Count > 0 Then
            ComboBoxPorts.SelectedIndex = 0
        End If
    End Sub

    Private Sub ButtonJog_Click(sender As Object, e As EventArgs) Handles ButtonYPos.Click, ButtonYNeg.Click, ButtonXNeg.Click, ButtonXPos.Click, ButtonZPos.Click, ButtonZNeg.Click
        Dim btn As Button = DirectCast(sender, Button)
        Try
            grbl.AddLine("G91 G0 " + btn.Tag + JogIncrement.ToString() + vbCr)
            grbl.AddLine("G90" + vbCr) 'return to absolute mode
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonJogInc_Click(sender As Object, e As EventArgs) Handles ButtonIncPt01.Click, ButtonIncPt1.Click, ButtonInc1.Click, ButtonInc10.Click, ButtonInc100.Click
        Dim btn As Button = DirectCast(sender, Button)

        'set all buttons as not selected
        ButtonIncPt01.BackColor = Color.Gray
        ButtonIncPt01.ForeColor = Color.DarkGray

        ButtonIncPt1.BackColor = Color.Gray
        ButtonIncPt1.ForeColor = Color.DarkGray

        ButtonInc1.BackColor = Color.Gray
        ButtonInc1.ForeColor = Color.DarkGray

        ButtonInc10.BackColor = Color.Gray
        ButtonInc10.ForeColor = Color.DarkGray

        ButtonInc100.BackColor = Color.Gray
        ButtonInc100.ForeColor = Color.DarkGray

        'set this button as selected
        btn.BackColor = Color.DodgerBlue
        btn.ForeColor = Color.White

        JogIncrement = Convert.ToDouble(btn.Tag)
    End Sub

    Private Sub TimerPortCheck_Tick(sender As Object, e As EventArgs) Handles TimerPortCheck.Tick
        If Not grbl.IsOpen Then
            ButtonPortOpen.Text = "Open Port"
            If My.Computer.Ports.SerialPortNames.Count <> ComboBoxPorts.Items.Count Then
                refreshPorts()
            End If
            SetText(LabelGrblVer, "Grbl Ver:---")
            SetText(LabelState, "State:")
            SetText(LabelXPos, "X: ---.---")
            SetText(LabelYPos, "Y: ---.---")
            SetText(LabelZPos, "Z: ---.---")
        Else
            ButtonPortOpen.Text = "Close Port"
        End If
    End Sub

    Private Sub ButtonPortOpen_Click(sender As Object, e As EventArgs) Handles ButtonPortOpen.Click
        If ButtonPortOpen.Text = "Open Port" Then
            Try
                grbl.PortName = ComboBoxPorts.Text
                grbl.Open()
                ButtonPortOpen.Text = "Close Port"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            grbl.Close()
            ButtonPortOpen.Text = "Open Port"
        End If
    End Sub


    Private Sub grbl_StatusUpdate(ByVal state As String) Handles grbl.StatusUpdate
        SetText(LabelState, "State: " + state)
        SetText(LabelXPos, "X: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Machine, GrblInterface.AxisLetter.X).ToString)
        SetText(LabelYPos, "Y: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Machine, GrblInterface.AxisLetter.Y).ToString)
        SetText(LabelZPos, "Z: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Machine, GrblInterface.AxisLetter.Z).ToString)

        'limit switches
        Try
            If grbl.GetLimitSwitch(GrblInterface.AxisLetter.X) Then
                SetLabelBackground(LabelXLim, Color.LimeGreen)
            Else
                SetLabelBackground(LabelXLim, Color.LightGray)
            End If

            If grbl.GetLimitSwitch(GrblInterface.AxisLetter.Y) Then
                SetLabelBackground(LabelYLim, Color.LimeGreen)
            Else
                SetLabelBackground(LabelYLim, Color.LightGray)
            End If

            If grbl.GetLimitSwitch(GrblInterface.AxisLetter.Z) Then
                SetLabelBackground(LabelZLIm, Color.LimeGreen)
            Else
                SetLabelBackground(LabelZLIm, Color.LightGray)
            End If
        Catch ex As Exception

        End Try

        'control switches
        Try
            If grbl.GetControlSwitch(GrblInterface.ControlPin.Feedhold) Then
                SetLabelBackground(LabelFeedhold, Color.LimeGreen)
            Else
                SetLabelBackground(LabelFeedhold, Color.LightGray)
            End If

            If grbl.GetControlSwitch(GrblInterface.ControlPin.CycleStart) Then
                SetLabelBackground(LabelCycleStart, Color.LimeGreen)
            Else
                SetLabelBackground(LabelCycleStart, Color.LightGray)
            End If

            If grbl.GetControlSwitch(GrblInterface.ControlPin.Reset) Then
                SetLabelBackground(LabelReset, Color.LimeGreen)
            Else
                SetLabelBackground(LabelReset, Color.LightGray)
            End If


            'If grbl.GetControlSwitch(GrblInterface.ControlPin.Door) Then
            'SetLabelBackground(LabelDoor, Color.LimeGreen)
            'Else
            'SetLabelBackground(LabelDoor, Color.LightGray)
            'End If

        Catch ex As Exception

        End Try

        'probe switch
        Try
            If Not grbl.GetProbeSwitch() Then
                SetLabelBackground(LabelProbe, Color.LimeGreen)
            Else
                SetLabelBackground(LabelProbe, Color.LightGray)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gbrl_DataReceived(ByVal rxData As String) Handles grbl.DataReceived
        Console.WriteLine(rxData)
    End Sub

    Private Sub grbl_GotVersion(ByVal ver As String) Handles grbl.GotVersion
        SetText(LabelGrblVer, "Grbl Ver:" + ver)
    End Sub

    Private Sub ButtonGrblCommand_Click(sender As Object, e As EventArgs) Handles ButtonSpindleOn.Click, ButtonSpindleOff.Click, ButtonMistOn.Click, ButtonFloodOn.Click, ButtonCoolantOff.Click, ButtonReadSwitches.Click, ButtonReset.Click, ButtonHome.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim cmds() As String

        cmds = btn.Tag.ToString.Split(";")

        For I As Integer = 0 To cmds.Length - 1
            Try
                grbl.AddLine(cmds(I) + vbCr)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        If grbl.IsOpen Then grbl.Close()

        FormUpload.ShowDialog()

    End Sub

    Private Sub OpenProgramFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProgramFolderToolStripMenuItem.Click
        Process.Start(Application.StartupPath)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(APP_NAME + vbCrLf + "Version: " + APP_REV, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class
