Imports System.IO
'
' This uses the FTDI FT_Prog-CmdLine.exe program to upload templates to FT232R chips
' The FT_Prog-CmdLine program and the template must be in the same folder as the application.
'
' Usage 
' Set the Template property
' call the Prog() subroutine...use try, catch to see if there is an problem.
' Use the DataReceived event to see the result.
' 
Public Class ft_prog
    Dim WithEvents proc As Process
    Private mTemplate As String = ""

    Public Event DataReceived(ByVal Data As String)

    Public Property Template As String
        Get
            Return mTemplate
        End Get
        Set(value As String)
            mTemplate = value
        End Set
    End Property

    Private Sub proc_DataReceived(sender As Object, errLine As DataReceivedEventArgs) Handles proc.ErrorDataReceived, proc.OutputDataReceived
        If Not errLine.Data = Nothing Then
            RaiseEvent DataReceived(errLine.Data)
        End If
    End Sub

    Public Sub Prog()
        Dim appPath As String = My.Application.Info.DirectoryPath
        Dim params As String

        proc = New Process

        If mTemplate = "" Then
            Throw New Exception("No template specified")
        End If

        Dim appname As String = appPath + "\FT_Prog-CmdLine.exe"
        Dim template As String = appPath + "\" + mTemplate


        params = "scan prog 0 " + Chr(34) + template + Chr(34) + " scan"

        ' Console.WriteLine(appname)
        ' Console.WriteLine(params)

        proc.EnableRaisingEvents = True

        Try
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
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

End Class
