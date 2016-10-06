Module Globals
    Delegate Sub SetTextDelagate(ByVal ctrl As Control, ByVal Text As String)

    Public Sub SetText(ByVal ctrl As Control, ByVal Text As String)
        If ctrl.InvokeRequired Then
            Dim del = New SetTextDelagate(AddressOf SetText)
            ctrl.Invoke(del, ctrl, Text)
        Else
            ctrl.Text = Text
        End If
    End Sub

    Delegate Sub SetLabelBackgroundDelagate(ByVal ctrl As Label, ByVal val As Color)

    Public Sub SetLabelBackground(ByVal ctrl As Label, ByVal val As Color)
        If ctrl.InvokeRequired Then
            Dim del = New SetLabelBackgroundDelagate(AddressOf SetLabelBackground)
            ctrl.Invoke(del, ctrl, val)
        Else
            ctrl.BackColor = val
        End If
    End Sub

    Delegate Sub AddTextDelagate(ByVal ctrl As RichTextBox, ByVal Text As String)

    Public Sub AddText(ByVal ctrl As RichTextBox, ByVal Text As String)
        If ctrl.InvokeRequired Then
            Dim del = New AddTextDelagate(AddressOf AddText)
            ctrl.Invoke(del, ctrl, Text)
        Else
            ctrl.AppendText(Text)
            ctrl.ScrollToCaret()
        End If
    End Sub
End Module
