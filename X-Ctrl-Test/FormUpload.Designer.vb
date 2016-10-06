<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUpload
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBoxPorts = New System.Windows.Forms.ComboBox()
        Me.ButtonUploadHex = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.RichTextBoxData = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ButtonPgmUSB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonUploadAvrIspMkii = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxPorts
        '
        Me.ComboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPorts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPorts.FormattingEnabled = True
        Me.ComboBoxPorts.Location = New System.Drawing.Point(95, 25)
        Me.ComboBoxPorts.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPorts.Name = "ComboBoxPorts"
        Me.ComboBoxPorts.Size = New System.Drawing.Size(156, 40)
        Me.ComboBoxPorts.TabIndex = 66
        '
        'ButtonUploadHex
        '
        Me.ButtonUploadHex.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonUploadHex.FlatAppearance.BorderSize = 2
        Me.ButtonUploadHex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUploadHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUploadHex.ForeColor = System.Drawing.Color.White
        Me.ButtonUploadHex.Location = New System.Drawing.Point(17, 143)
        Me.ButtonUploadHex.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonUploadHex.Name = "ButtonUploadHex"
        Me.ButtonUploadHex.Size = New System.Drawing.Size(374, 48)
        Me.ButtonUploadHex.TabIndex = 67
        Me.ButtonUploadHex.Tag = "G30"
        Me.ButtonUploadHex.Text = "Program with USB"
        Me.ButtonUploadHex.UseVisualStyleBackColor = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonRefresh.FlatAppearance.BorderSize = 2
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.Location = New System.Drawing.Point(259, 18)
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(187, 48)
        Me.ButtonRefresh.TabIndex = 68
        Me.ButtonRefresh.Tag = "G30"
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'ButtonCheck
        '
        Me.ButtonCheck.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonCheck.FlatAppearance.BorderSize = 2
        Me.ButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCheck.ForeColor = System.Drawing.Color.White
        Me.ButtonCheck.Location = New System.Drawing.Point(17, 254)
        Me.ButtonCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(374, 48)
        Me.ButtonCheck.TabIndex = 69
        Me.ButtonCheck.Tag = "G30"
        Me.ButtonCheck.Text = "Check Firmware"
        Me.ButtonCheck.UseVisualStyleBackColor = False
        '
        'RichTextBoxData
        '
        Me.RichTextBoxData.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RichTextBoxData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxData.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxData.Location = New System.Drawing.Point(17, 321)
        Me.RichTextBoxData.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBoxData.Name = "RichTextBoxData"
        Me.RichTextBoxData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxData.Size = New System.Drawing.Size(965, 303)
        Me.RichTextBoxData.TabIndex = 70
        Me.RichTextBoxData.Text = ""
        Me.RichTextBoxData.WordWrap = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Hex Files|*.hex"
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.DtrEnable = True
        '
        'ButtonPgmUSB
        '
        Me.ButtonPgmUSB.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonPgmUSB.FlatAppearance.BorderSize = 2
        Me.ButtonPgmUSB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPgmUSB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPgmUSB.ForeColor = System.Drawing.Color.White
        Me.ButtonPgmUSB.Location = New System.Drawing.Point(17, 199)
        Me.ButtonPgmUSB.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPgmUSB.Name = "ButtonPgmUSB"
        Me.ButtonPgmUSB.Size = New System.Drawing.Size(374, 48)
        Me.ButtonPgmUSB.TabIndex = 71
        Me.ButtonPgmUSB.Tag = "G30"
        Me.ButtonPgmUSB.Text = "Program USB S/N"
        Me.ButtonPgmUSB.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 29)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Port"
        '
        'ButtonUploadAvrIspMkii
        '
        Me.ButtonUploadAvrIspMkii.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonUploadAvrIspMkii.FlatAppearance.BorderSize = 2
        Me.ButtonUploadAvrIspMkii.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUploadAvrIspMkii.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUploadAvrIspMkii.ForeColor = System.Drawing.Color.White
        Me.ButtonUploadAvrIspMkii.Location = New System.Drawing.Point(17, 87)
        Me.ButtonUploadAvrIspMkii.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonUploadAvrIspMkii.Name = "ButtonUploadAvrIspMkii"
        Me.ButtonUploadAvrIspMkii.Size = New System.Drawing.Size(374, 48)
        Me.ButtonUploadAvrIspMkii.TabIndex = 73
        Me.ButtonUploadAvrIspMkii.Tag = "G30"
        Me.ButtonUploadAvrIspMkii.Text = "Program with AVRISPMKII"
        Me.ButtonUploadAvrIspMkii.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(410, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 29)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Upload firmware over USB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(410, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 29)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Uploads bootloader"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(410, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(392, 29)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Program the s/n on the USB chip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(410, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 29)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Check current firmware"
        '
        'FormUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(995, 640)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonUploadAvrIspMkii)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonPgmUSB)
        Me.Controls.Add(Me.RichTextBoxData)
        Me.Controls.Add(Me.ButtonCheck)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonUploadHex)
        Me.Controls.Add(Me.ComboBoxPorts)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "FormUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Firmware Upload and USB Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxPorts As ComboBox
    Friend WithEvents ButtonUploadHex As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonCheck As Button
    Friend WithEvents RichTextBoxData As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ButtonPgmUSB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonUploadAvrIspMkii As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
