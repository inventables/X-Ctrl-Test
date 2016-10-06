Imports System.ComponentModel
Imports System.IO.Ports

Public Class FormUpload
    Private hexFile As String = ""
    Dim WithEvents proc As Process

    Dim WithEvents ftprog As ft_prog

    Private Sub FormUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ftprog = New ft_prog
        refreshPorts()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        If SerialPort1.IsOpen Then SerialPort1.Close()
        refreshPorts()
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



    Private Sub ButtonOpenHex_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Upload()

        Dim appPath As String = My.Application.Info.DirectoryPath
        Dim params As String

        proc = New Process

        If hexFile = "" Then
            MessageBox.Show("No hex file loaded")
            Exit Sub
        End If

        If ComboBoxPorts.Items.Count = 0 Then
            MessageBox.Show("No COM port selected")
            Exit Sub
        End If

        If ComboBoxPorts.SelectedItem.ToString = "" Then
            MessageBox.Show("No COM port selected")
            Exit Sub
        End If

        AddText(RichTextBoxData, "Application path: " + appPath + vbCrLf)

        Dim appname As String = appPath + "\avrdude.exe"
        Dim config As String = appPath + "\avrdude.conf"
        Dim verbose As String = "-v"
        Dim partNo As String = "atmega328p"
        Dim programmer As String = "arduino"
        Dim port As String = ComboBoxPorts.SelectedItem.ToString
        Dim baud As String = "115200"

        params = Chr(34) + "-C" + config + Chr(34) + " " + " -p " + partNo + " -c " + programmer + " -P " + port + " -b " + baud + " -D " + Chr(34) + "-Uflash:w:" + hexFile + ":i" + Chr(34)

        'setup the process without a command window
        'the output and error lines will generate events so it can be displayed in the GUI.
        Dim start_info As New ProcessStartInfo(appname, params)

        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True

        ' Make the process and set its start information.
        proc.StartInfo = start_info

        ' Start the process.
        proc.Start()
        proc.BeginErrorReadLine()
        proc.BeginOutputReadLine()
        proc.Close()

    End Sub

    Private Sub ButtonUploadHex_Click(sender As Object, e As EventArgs) Handles ButtonUploadHex.Click

        RichTextBoxData.Text = ""

        Try
            If SerialPort1.IsOpen Then SerialPort1.Close()

            OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\firmware\"
            OpenFileDialog1.Filter = "Hex Files|*.hex"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                hexFile = OpenFileDialog1.FileName
                RichTextBoxData.Text = ""
                Upload()
            End If
        Catch ex As Exception
            RichTextBoxData.Text = "Error:" + ex.Message
        End Try



    End Sub

    Private Sub proc_ErrData(sender As Object, errLine As DataReceivedEventArgs) Handles proc.ErrorDataReceived
        If Not errLine.Data = Nothing Then
            AddText(RichTextBoxData, errLine.Data + vbCrLf)
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        AddText(RichTextBoxData, SerialPort1.ReadExisting)
    End Sub

    Private Sub FormUpload_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SerialPort1.IsOpen Then SerialPort1.Close()
    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        Dim port As String = ComboBoxPorts.SelectedItem.ToString
        RichTextBoxData.Text = ""
        Try
            SerialPort1.PortName = port
            SerialPort1.Open()

        Catch ex As Exception
            RichTextBoxData.Text = ex.Message
        End Try


    End Sub

    Private Sub ButtonPgmUSB_Click(sender As Object, e As EventArgs) Handles ButtonPgmUSB.Click
        RichTextBoxData.Text = ""

        Try
            ftprog.Template = "xcontroller.xmlx" 'Note: Visual Studio is fighting me with including .xml files in the project.  It is trying to handle them as a special case.  adding the x fixes it.
            ftprog.Prog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ftprog_data(data As String) Handles ftprog.DataReceived
        If Not data = Nothing Then
            AddText(RichTextBoxData, data + vbCrLf)
        End If
    End Sub

    Private Sub proc_OutputDataReceived(sender As Object, e As DataReceivedEventArgs) Handles proc.OutputDataReceived
        If Not e.Data = Nothing Then
            AddText(RichTextBoxData, e.Data + vbCrLf)
        End If
    End Sub


    Private Sub ButtonUploadAvrIspMkii_Click(sender As Object, e As EventArgs) Handles ButtonUploadAvrIspMkii.Click
        Dim appPath As String = My.Application.Info.DirectoryPath
        Dim params As String
        Dim hexFileParam As String

        RichTextBoxData.Text = ""

        'get a hex filename
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\firmware\"
        OpenFileDialog1.Filter = "Hex Files|*.hex"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            hexFile = OpenFileDialog1.FileName
        Else
            Exit Sub 'if no file selected quit
        End If


        proc = New Process
        proc.EnableRaisingEvents = True


        Dim appname As String = appPath + "\avrdude.exe"
        Dim config As String = appPath + "\avrdude.conf"

        'Create the hex file parameter
        'The filename must be surrounded in quotes to deal with spaces in the filename or path
        'you need to put the ":i" part to deal with the ":" in the drive, like "c:\..."
        hexFileParam = "-Uflash:w:" + Chr(34) + hexFile + Chr(34) + ":i"

        params = " -c avrispmkII -P usb -p atmega328p " + hexFileParam + " -U lfuse:w:0xFF:m -U hfuse:w:0xD6:m -U efuse:w:0x05:m"



        'setup the process without a command window
        'the output and error lines will generate events so it can be displayed in the GUI.
        Dim start_info As New ProcessStartInfo(appname, params)

        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True

        ' Make the process and set its start information.
        proc.StartInfo = start_info

        ' Start the process.
        proc.Start()
        proc.BeginErrorReadLine()
        proc.BeginOutputReadLine()
        proc.Close()
    End Sub
End Class