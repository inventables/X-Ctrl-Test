<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.LabelJogIncrement = New System.Windows.Forms.Label()
        Me.ButtonZPos = New System.Windows.Forms.Button()
        Me.ButtonZNeg = New System.Windows.Forms.Button()
        Me.ButtonXNeg = New System.Windows.Forms.Button()
        Me.ButtonXPos = New System.Windows.Forms.Button()
        Me.ButtonYPos = New System.Windows.Forms.Button()
        Me.ButtonInc100 = New System.Windows.Forms.Button()
        Me.ButtonInc10 = New System.Windows.Forms.Button()
        Me.ButtonInc1 = New System.Windows.Forms.Button()
        Me.ButtonIncPt1 = New System.Windows.Forms.Button()
        Me.ButtonIncPt01 = New System.Windows.Forms.Button()
        Me.ButtonYNeg = New System.Windows.Forms.Button()
        Me.ButtonSpindleOn = New System.Windows.Forms.Button()
        Me.ButtonSpindleOff = New System.Windows.Forms.Button()
        Me.ButtonMistOn = New System.Windows.Forms.Button()
        Me.ButtonFloodOn = New System.Windows.Forms.Button()
        Me.ButtonCoolantOff = New System.Windows.Forms.Button()
        Me.LabelXLim = New System.Windows.Forms.Label()
        Me.LabelYLim = New System.Windows.Forms.Label()
        Me.LabelZLIm = New System.Windows.Forms.Label()
        Me.LabelFeedhold = New System.Windows.Forms.Label()
        Me.LabelCycleStart = New System.Windows.Forms.Label()
        Me.LabelProbe = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelReset = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonPortOpen = New System.Windows.Forms.Button()
        Me.ComboBoxPorts = New System.Windows.Forms.ComboBox()
        Me.LabelXPos = New System.Windows.Forms.Label()
        Me.LabelYPos = New System.Windows.Forms.Label()
        Me.LabelZPos = New System.Windows.Forms.Label()
        Me.TimerPortCheck = New System.Windows.Forms.Timer(Me.components)
        Me.LabelState = New System.Windows.Forms.Label()
        Me.ButtonReadSwitches = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProgramFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonClearAlarm = New System.Windows.Forms.Button()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.LabelGrblVer = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelJogIncrement
        '
        Me.LabelJogIncrement.BackColor = System.Drawing.Color.Gray
        Me.LabelJogIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelJogIncrement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJogIncrement.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelJogIncrement.Location = New System.Drawing.Point(530, 49)
        Me.LabelJogIncrement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJogIncrement.Name = "LabelJogIncrement"
        Me.LabelJogIncrement.Size = New System.Drawing.Size(518, 59)
        Me.LabelJogIncrement.TabIndex = 51
        Me.LabelJogIncrement.Text = "Jog Increment"
        Me.LabelJogIncrement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonZPos
        '
        Me.ButtonZPos.BackColor = System.Drawing.Color.Black
        Me.ButtonZPos.BackgroundImage = CType(resources.GetObject("ButtonZPos.BackgroundImage"), System.Drawing.Image)
        Me.ButtonZPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonZPos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonZPos.FlatAppearance.BorderSize = 0
        Me.ButtonZPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonZPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonZPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonZPos.ForeColor = System.Drawing.Color.White
        Me.ButtonZPos.Location = New System.Drawing.Point(926, 207)
        Me.ButtonZPos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonZPos.Name = "ButtonZPos"
        Me.ButtonZPos.Size = New System.Drawing.Size(122, 120)
        Me.ButtonZPos.TabIndex = 50
        Me.ButtonZPos.Tag = "Z+"
        Me.ButtonZPos.UseVisualStyleBackColor = False
        '
        'ButtonZNeg
        '
        Me.ButtonZNeg.BackColor = System.Drawing.Color.Black
        Me.ButtonZNeg.BackgroundImage = CType(resources.GetObject("ButtonZNeg.BackgroundImage"), System.Drawing.Image)
        Me.ButtonZNeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonZNeg.FlatAppearance.BorderSize = 0
        Me.ButtonZNeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonZNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonZNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonZNeg.ForeColor = System.Drawing.Color.White
        Me.ButtonZNeg.Location = New System.Drawing.Point(926, 403)
        Me.ButtonZNeg.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonZNeg.Name = "ButtonZNeg"
        Me.ButtonZNeg.Size = New System.Drawing.Size(122, 120)
        Me.ButtonZNeg.TabIndex = 49
        Me.ButtonZNeg.Tag = "Z-"
        Me.ButtonZNeg.UseVisualStyleBackColor = False
        '
        'ButtonXNeg
        '
        Me.ButtonXNeg.BackColor = System.Drawing.Color.Black
        Me.ButtonXNeg.BackgroundImage = CType(resources.GetObject("ButtonXNeg.BackgroundImage"), System.Drawing.Image)
        Me.ButtonXNeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonXNeg.FlatAppearance.BorderSize = 0
        Me.ButtonXNeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonXNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonXNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonXNeg.ForeColor = System.Drawing.Color.White
        Me.ButtonXNeg.Location = New System.Drawing.Point(596, 304)
        Me.ButtonXNeg.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonXNeg.Name = "ButtonXNeg"
        Me.ButtonXNeg.Size = New System.Drawing.Size(122, 120)
        Me.ButtonXNeg.TabIndex = 48
        Me.ButtonXNeg.Tag = "X-"
        Me.ButtonXNeg.UseVisualStyleBackColor = False
        '
        'ButtonXPos
        '
        Me.ButtonXPos.BackColor = System.Drawing.Color.Black
        Me.ButtonXPos.BackgroundImage = CType(resources.GetObject("ButtonXPos.BackgroundImage"), System.Drawing.Image)
        Me.ButtonXPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonXPos.FlatAppearance.BorderSize = 0
        Me.ButtonXPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonXPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonXPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonXPos.ForeColor = System.Drawing.Color.White
        Me.ButtonXPos.Location = New System.Drawing.Point(811, 304)
        Me.ButtonXPos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonXPos.Name = "ButtonXPos"
        Me.ButtonXPos.Size = New System.Drawing.Size(122, 120)
        Me.ButtonXPos.TabIndex = 47
        Me.ButtonXPos.Tag = "X+"
        Me.ButtonXPos.UseVisualStyleBackColor = False
        '
        'ButtonYPos
        '
        Me.ButtonYPos.BackColor = System.Drawing.Color.Black
        Me.ButtonYPos.BackgroundImage = CType(resources.GetObject("ButtonYPos.BackgroundImage"), System.Drawing.Image)
        Me.ButtonYPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonYPos.FlatAppearance.BorderSize = 0
        Me.ButtonYPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonYPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonYPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonYPos.ForeColor = System.Drawing.Color.White
        Me.ButtonYPos.Location = New System.Drawing.Point(706, 207)
        Me.ButtonYPos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonYPos.Name = "ButtonYPos"
        Me.ButtonYPos.Size = New System.Drawing.Size(122, 120)
        Me.ButtonYPos.TabIndex = 46
        Me.ButtonYPos.Tag = "Y+"
        Me.ButtonYPos.UseVisualStyleBackColor = False
        '
        'ButtonInc100
        '
        Me.ButtonInc100.BackColor = System.Drawing.Color.Gray
        Me.ButtonInc100.FlatAppearance.BorderSize = 0
        Me.ButtonInc100.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonInc100.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInc100.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonInc100.Location = New System.Drawing.Point(950, 111)
        Me.ButtonInc100.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInc100.Name = "ButtonInc100"
        Me.ButtonInc100.Size = New System.Drawing.Size(98, 72)
        Me.ButtonInc100.TabIndex = 45
        Me.ButtonInc100.Tag = "100"
        Me.ButtonInc100.Text = "100"
        Me.ButtonInc100.UseVisualStyleBackColor = False
        '
        'ButtonInc10
        '
        Me.ButtonInc10.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonInc10.FlatAppearance.BorderSize = 0
        Me.ButtonInc10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonInc10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInc10.ForeColor = System.Drawing.Color.White
        Me.ButtonInc10.Location = New System.Drawing.Point(845, 111)
        Me.ButtonInc10.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInc10.Name = "ButtonInc10"
        Me.ButtonInc10.Size = New System.Drawing.Size(98, 72)
        Me.ButtonInc10.TabIndex = 44
        Me.ButtonInc10.Tag = "10"
        Me.ButtonInc10.Text = "10"
        Me.ButtonInc10.UseVisualStyleBackColor = False
        '
        'ButtonInc1
        '
        Me.ButtonInc1.BackColor = System.Drawing.Color.Gray
        Me.ButtonInc1.FlatAppearance.BorderSize = 0
        Me.ButtonInc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonInc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInc1.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonInc1.Location = New System.Drawing.Point(740, 111)
        Me.ButtonInc1.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInc1.Name = "ButtonInc1"
        Me.ButtonInc1.Size = New System.Drawing.Size(98, 72)
        Me.ButtonInc1.TabIndex = 43
        Me.ButtonInc1.Tag = "1"
        Me.ButtonInc1.Text = "1"
        Me.ButtonInc1.UseVisualStyleBackColor = False
        '
        'ButtonIncPt1
        '
        Me.ButtonIncPt1.BackColor = System.Drawing.Color.Gray
        Me.ButtonIncPt1.FlatAppearance.BorderSize = 0
        Me.ButtonIncPt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIncPt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIncPt1.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonIncPt1.Location = New System.Drawing.Point(635, 111)
        Me.ButtonIncPt1.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonIncPt1.Name = "ButtonIncPt1"
        Me.ButtonIncPt1.Size = New System.Drawing.Size(98, 72)
        Me.ButtonIncPt1.TabIndex = 42
        Me.ButtonIncPt1.Tag = "0.1"
        Me.ButtonIncPt1.Text = "0.1"
        Me.ButtonIncPt1.UseVisualStyleBackColor = False
        '
        'ButtonIncPt01
        '
        Me.ButtonIncPt01.BackColor = System.Drawing.Color.Gray
        Me.ButtonIncPt01.FlatAppearance.BorderSize = 0
        Me.ButtonIncPt01.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIncPt01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIncPt01.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonIncPt01.Location = New System.Drawing.Point(530, 111)
        Me.ButtonIncPt01.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonIncPt01.Name = "ButtonIncPt01"
        Me.ButtonIncPt01.Size = New System.Drawing.Size(98, 72)
        Me.ButtonIncPt01.TabIndex = 41
        Me.ButtonIncPt01.Tag = "0.01"
        Me.ButtonIncPt01.Text = "0.01"
        Me.ButtonIncPt01.UseVisualStyleBackColor = False
        '
        'ButtonYNeg
        '
        Me.ButtonYNeg.BackColor = System.Drawing.Color.Black
        Me.ButtonYNeg.BackgroundImage = CType(resources.GetObject("ButtonYNeg.BackgroundImage"), System.Drawing.Image)
        Me.ButtonYNeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonYNeg.FlatAppearance.BorderSize = 0
        Me.ButtonYNeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonYNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonYNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonYNeg.ForeColor = System.Drawing.Color.White
        Me.ButtonYNeg.Location = New System.Drawing.Point(706, 403)
        Me.ButtonYNeg.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonYNeg.Name = "ButtonYNeg"
        Me.ButtonYNeg.Size = New System.Drawing.Size(122, 120)
        Me.ButtonYNeg.TabIndex = 40
        Me.ButtonYNeg.Tag = "Y-"
        Me.ButtonYNeg.UseVisualStyleBackColor = False
        '
        'ButtonSpindleOn
        '
        Me.ButtonSpindleOn.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonSpindleOn.FlatAppearance.BorderSize = 2
        Me.ButtonSpindleOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSpindleOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpindleOn.ForeColor = System.Drawing.Color.White
        Me.ButtonSpindleOn.Location = New System.Drawing.Point(596, 558)
        Me.ButtonSpindleOn.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSpindleOn.Name = "ButtonSpindleOn"
        Me.ButtonSpindleOn.Size = New System.Drawing.Size(205, 78)
        Me.ButtonSpindleOn.TabIndex = 52
        Me.ButtonSpindleOn.Tag = "S12000;M3"
        Me.ButtonSpindleOn.Text = "Spindle On"
        Me.ButtonSpindleOn.UseVisualStyleBackColor = False
        '
        'ButtonSpindleOff
        '
        Me.ButtonSpindleOff.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonSpindleOff.FlatAppearance.BorderSize = 0
        Me.ButtonSpindleOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSpindleOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpindleOff.ForeColor = System.Drawing.Color.White
        Me.ButtonSpindleOff.Location = New System.Drawing.Point(596, 643)
        Me.ButtonSpindleOff.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSpindleOff.Name = "ButtonSpindleOff"
        Me.ButtonSpindleOff.Size = New System.Drawing.Size(205, 78)
        Me.ButtonSpindleOff.TabIndex = 53
        Me.ButtonSpindleOff.Tag = "M5"
        Me.ButtonSpindleOff.Text = "Spindle Off"
        Me.ButtonSpindleOff.UseVisualStyleBackColor = False
        '
        'ButtonMistOn
        '
        Me.ButtonMistOn.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonMistOn.FlatAppearance.BorderSize = 0
        Me.ButtonMistOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMistOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMistOn.ForeColor = System.Drawing.Color.White
        Me.ButtonMistOn.Location = New System.Drawing.Point(809, 558)
        Me.ButtonMistOn.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMistOn.Name = "ButtonMistOn"
        Me.ButtonMistOn.Size = New System.Drawing.Size(205, 78)
        Me.ButtonMistOn.TabIndex = 54
        Me.ButtonMistOn.Tag = "M7"
        Me.ButtonMistOn.Text = "Mist On"
        Me.ButtonMistOn.UseVisualStyleBackColor = False
        '
        'ButtonFloodOn
        '
        Me.ButtonFloodOn.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonFloodOn.FlatAppearance.BorderSize = 0
        Me.ButtonFloodOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFloodOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFloodOn.ForeColor = System.Drawing.Color.White
        Me.ButtonFloodOn.Location = New System.Drawing.Point(809, 643)
        Me.ButtonFloodOn.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonFloodOn.Name = "ButtonFloodOn"
        Me.ButtonFloodOn.Size = New System.Drawing.Size(205, 78)
        Me.ButtonFloodOn.TabIndex = 55
        Me.ButtonFloodOn.Tag = "M8"
        Me.ButtonFloodOn.Text = "Flood On"
        Me.ButtonFloodOn.UseVisualStyleBackColor = False
        '
        'ButtonCoolantOff
        '
        Me.ButtonCoolantOff.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonCoolantOff.FlatAppearance.BorderSize = 0
        Me.ButtonCoolantOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCoolantOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCoolantOff.ForeColor = System.Drawing.Color.White
        Me.ButtonCoolantOff.Location = New System.Drawing.Point(809, 729)
        Me.ButtonCoolantOff.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCoolantOff.Name = "ButtonCoolantOff"
        Me.ButtonCoolantOff.Size = New System.Drawing.Size(205, 78)
        Me.ButtonCoolantOff.TabIndex = 56
        Me.ButtonCoolantOff.Tag = "M9"
        Me.ButtonCoolantOff.Text = "Coolant Off"
        Me.ButtonCoolantOff.UseVisualStyleBackColor = False
        '
        'LabelXLim
        '
        Me.LabelXLim.BackColor = System.Drawing.Color.Gray
        Me.LabelXLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelXLim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelXLim.ForeColor = System.Drawing.Color.White
        Me.LabelXLim.Location = New System.Drawing.Point(16, 60)
        Me.LabelXLim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelXLim.Name = "LabelXLim"
        Me.LabelXLim.Size = New System.Drawing.Size(134, 59)
        Me.LabelXLim.TabIndex = 57
        Me.LabelXLim.Text = "X Lim"
        Me.LabelXLim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelYLim
        '
        Me.LabelYLim.BackColor = System.Drawing.Color.Gray
        Me.LabelYLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelYLim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYLim.ForeColor = System.Drawing.Color.White
        Me.LabelYLim.Location = New System.Drawing.Point(158, 60)
        Me.LabelYLim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelYLim.Name = "LabelYLim"
        Me.LabelYLim.Size = New System.Drawing.Size(134, 59)
        Me.LabelYLim.TabIndex = 58
        Me.LabelYLim.Text = "Y Lim"
        Me.LabelYLim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelZLIm
        '
        Me.LabelZLIm.BackColor = System.Drawing.Color.Gray
        Me.LabelZLIm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelZLIm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZLIm.ForeColor = System.Drawing.Color.White
        Me.LabelZLIm.Location = New System.Drawing.Point(299, 60)
        Me.LabelZLIm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelZLIm.Name = "LabelZLIm"
        Me.LabelZLIm.Size = New System.Drawing.Size(134, 59)
        Me.LabelZLIm.TabIndex = 59
        Me.LabelZLIm.Text = "Z Lim"
        Me.LabelZLIm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFeedhold
        '
        Me.LabelFeedhold.BackColor = System.Drawing.Color.Gray
        Me.LabelFeedhold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelFeedhold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFeedhold.ForeColor = System.Drawing.Color.White
        Me.LabelFeedhold.Location = New System.Drawing.Point(16, 132)
        Me.LabelFeedhold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFeedhold.Name = "LabelFeedhold"
        Me.LabelFeedhold.Size = New System.Drawing.Size(202, 59)
        Me.LabelFeedhold.TabIndex = 60
        Me.LabelFeedhold.Text = "Feedhold"
        Me.LabelFeedhold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCycleStart
        '
        Me.LabelCycleStart.BackColor = System.Drawing.Color.Gray
        Me.LabelCycleStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCycleStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCycleStart.ForeColor = System.Drawing.Color.White
        Me.LabelCycleStart.Location = New System.Drawing.Point(225, 132)
        Me.LabelCycleStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCycleStart.Name = "LabelCycleStart"
        Me.LabelCycleStart.Size = New System.Drawing.Size(209, 59)
        Me.LabelCycleStart.TabIndex = 61
        Me.LabelCycleStart.Text = "Cycle Start"
        Me.LabelCycleStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelProbe
        '
        Me.LabelProbe.BackColor = System.Drawing.Color.Gray
        Me.LabelProbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelProbe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProbe.ForeColor = System.Drawing.Color.White
        Me.LabelProbe.Location = New System.Drawing.Point(16, 202)
        Me.LabelProbe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProbe.Name = "LabelProbe"
        Me.LabelProbe.Size = New System.Drawing.Size(202, 59)
        Me.LabelProbe.TabIndex = 62
        Me.LabelProbe.Text = "Probe"
        Me.LabelProbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.LabelReset)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LabelFeedhold)
        Me.Panel1.Controls.Add(Me.LabelProbe)
        Me.Panel1.Controls.Add(Me.LabelXLim)
        Me.Panel1.Controls.Add(Me.LabelCycleStart)
        Me.Panel1.Controls.Add(Me.LabelYLim)
        Me.Panel1.Controls.Add(Me.LabelZLIm)
        Me.Panel1.Location = New System.Drawing.Point(11, 530)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 277)
        Me.Panel1.TabIndex = 63
        '
        'LabelReset
        '
        Me.LabelReset.BackColor = System.Drawing.Color.Gray
        Me.LabelReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReset.ForeColor = System.Drawing.Color.White
        Me.LabelReset.Location = New System.Drawing.Point(225, 199)
        Me.LabelReset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelReset.Name = "LabelReset"
        Me.LabelReset.Size = New System.Drawing.Size(209, 59)
        Me.LabelReset.TabIndex = 64
        Me.LabelReset.Text = "Reset"
        Me.LabelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(412, 42)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Switch Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonPortOpen
        '
        Me.ButtonPortOpen.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonPortOpen.FlatAppearance.BorderSize = 2
        Me.ButtonPortOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPortOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPortOpen.ForeColor = System.Drawing.Color.White
        Me.ButtonPortOpen.Location = New System.Drawing.Point(0, 54)
        Me.ButtonPortOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPortOpen.Name = "ButtonPortOpen"
        Me.ButtonPortOpen.Size = New System.Drawing.Size(191, 64)
        Me.ButtonPortOpen.TabIndex = 64
        Me.ButtonPortOpen.Tag = "G30"
        Me.ButtonPortOpen.Text = "Open Port"
        Me.ButtonPortOpen.UseVisualStyleBackColor = False
        '
        'ComboBoxPorts
        '
        Me.ComboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPorts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPorts.FormattingEnabled = True
        Me.ComboBoxPorts.Location = New System.Drawing.Point(198, 63)
        Me.ComboBoxPorts.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPorts.Name = "ComboBoxPorts"
        Me.ComboBoxPorts.Size = New System.Drawing.Size(140, 40)
        Me.ComboBoxPorts.TabIndex = 65
        '
        'LabelXPos
        '
        Me.LabelXPos.AutoSize = True
        Me.LabelXPos.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelXPos.ForeColor = System.Drawing.Color.White
        Me.LabelXPos.Location = New System.Drawing.Point(8, 251)
        Me.LabelXPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelXPos.Name = "LabelXPos"
        Me.LabelXPos.Size = New System.Drawing.Size(338, 66)
        Me.LabelXPos.TabIndex = 66
        Me.LabelXPos.Text = "X: ---.---"
        '
        'LabelYPos
        '
        Me.LabelYPos.AutoSize = True
        Me.LabelYPos.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYPos.ForeColor = System.Drawing.Color.White
        Me.LabelYPos.Location = New System.Drawing.Point(8, 317)
        Me.LabelYPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelYPos.Name = "LabelYPos"
        Me.LabelYPos.Size = New System.Drawing.Size(338, 66)
        Me.LabelYPos.TabIndex = 67
        Me.LabelYPos.Text = "Y: ---.---"
        '
        'LabelZPos
        '
        Me.LabelZPos.AutoSize = True
        Me.LabelZPos.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZPos.ForeColor = System.Drawing.Color.White
        Me.LabelZPos.Location = New System.Drawing.Point(8, 383)
        Me.LabelZPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelZPos.Name = "LabelZPos"
        Me.LabelZPos.Size = New System.Drawing.Size(338, 66)
        Me.LabelZPos.TabIndex = 68
        Me.LabelZPos.Text = "Z: ---.---"
        '
        'TimerPortCheck
        '
        Me.TimerPortCheck.Enabled = True
        Me.TimerPortCheck.Interval = 1000
        '
        'LabelState
        '
        Me.LabelState.AutoSize = True
        Me.LabelState.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelState.ForeColor = System.Drawing.Color.White
        Me.LabelState.Location = New System.Drawing.Point(8, 187)
        Me.LabelState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelState.Name = "LabelState"
        Me.LabelState.Size = New System.Drawing.Size(214, 66)
        Me.LabelState.TabIndex = 69
        Me.LabelState.Text = "State:"
        '
        'ButtonReadSwitches
        '
        Me.ButtonReadSwitches.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonReadSwitches.FlatAppearance.BorderSize = 2
        Me.ButtonReadSwitches.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonReadSwitches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReadSwitches.ForeColor = System.Drawing.Color.White
        Me.ButtonReadSwitches.Location = New System.Drawing.Point(0, 459)
        Me.ButtonReadSwitches.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonReadSwitches.Name = "ButtonReadSwitches"
        Me.ButtonReadSwitches.Size = New System.Drawing.Size(252, 64)
        Me.ButtonReadSwitches.TabIndex = 70
        Me.ButtonReadSwitches.Tag = "$10=115"
        Me.ButtonReadSwitches.Text = "Read Switches"
        Me.ButtonReadSwitches.UseVisualStyleBackColor = False
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonReset.FlatAppearance.BorderSize = 2
        Me.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.ForeColor = System.Drawing.Color.White
        Me.ButtonReset.Location = New System.Drawing.Point(260, 459)
        Me.ButtonReset.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(156, 64)
        Me.ButtonReset.TabIndex = 71
        Me.ButtonReset.Tag = "$RST=*"
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'ButtonUpload
        '
        Me.ButtonUpload.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonUpload.FlatAppearance.BorderSize = 2
        Me.ButtonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpload.ForeColor = System.Drawing.Color.White
        Me.ButtonUpload.Location = New System.Drawing.Point(346, 54)
        Me.ButtonUpload.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(169, 64)
        Me.ButtonUpload.TabIndex = 72
        Me.ButtonUpload.Tag = "G30"
        Me.ButtonUpload.Text = "Program"
        Me.ButtonUpload.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 38)
        Me.MenuStrip1.TabIndex = 73
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenProgramFolderToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(56, 34)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenProgramFolderToolStripMenuItem
        '
        Me.OpenProgramFolderToolStripMenuItem.Name = "OpenProgramFolderToolStripMenuItem"
        Me.OpenProgramFolderToolStripMenuItem.Size = New System.Drawing.Size(304, 34)
        Me.OpenProgramFolderToolStripMenuItem.Text = "Open Program Folder"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(68, 34)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(162, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ButtonClearAlarm
        '
        Me.ButtonClearAlarm.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonClearAlarm.FlatAppearance.BorderSize = 2
        Me.ButtonClearAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonClearAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearAlarm.ForeColor = System.Drawing.Color.White
        Me.ButtonClearAlarm.Location = New System.Drawing.Point(596, 729)
        Me.ButtonClearAlarm.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClearAlarm.Name = "ButtonClearAlarm"
        Me.ButtonClearAlarm.Size = New System.Drawing.Size(205, 78)
        Me.ButtonClearAlarm.TabIndex = 74
        Me.ButtonClearAlarm.Tag = "$X"
        Me.ButtonClearAlarm.Text = "Clear Alarm"
        Me.ButtonClearAlarm.UseVisualStyleBackColor = False
        '
        'ButtonHome
        '
        Me.ButtonHome.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonHome.FlatAppearance.BorderSize = 2
        Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHome.ForeColor = System.Drawing.Color.White
        Me.ButtonHome.Location = New System.Drawing.Point(530, 191)
        Me.ButtonHome.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(156, 64)
        Me.ButtonHome.TabIndex = 75
        Me.ButtonHome.Tag = "$22=1;$H"
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = False
        '
        'LabelGrblVer
        '
        Me.LabelGrblVer.AutoSize = True
        Me.LabelGrblVer.Font = New System.Drawing.Font("Consolas", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGrblVer.ForeColor = System.Drawing.Color.White
        Me.LabelGrblVer.Location = New System.Drawing.Point(13, 127)
        Me.LabelGrblVer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGrblVer.Name = "LabelGrblVer"
        Me.LabelGrblVer.Size = New System.Drawing.Size(188, 40)
        Me.LabelGrblVer.TabIndex = 76
        Me.LabelGrblVer.Text = "Grbl Ver:"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1067, 833)
        Me.Controls.Add(Me.LabelGrblVer)
        Me.Controls.Add(Me.ButtonHome)
        Me.Controls.Add(Me.ButtonClearAlarm)
        Me.Controls.Add(Me.ButtonUpload)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonReadSwitches)
        Me.Controls.Add(Me.LabelState)
        Me.Controls.Add(Me.LabelZPos)
        Me.Controls.Add(Me.LabelYPos)
        Me.Controls.Add(Me.LabelXPos)
        Me.Controls.Add(Me.ComboBoxPorts)
        Me.Controls.Add(Me.ButtonPortOpen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonCoolantOff)
        Me.Controls.Add(Me.ButtonFloodOn)
        Me.Controls.Add(Me.ButtonMistOn)
        Me.Controls.Add(Me.ButtonSpindleOff)
        Me.Controls.Add(Me.ButtonSpindleOn)
        Me.Controls.Add(Me.LabelJogIncrement)
        Me.Controls.Add(Me.ButtonZPos)
        Me.Controls.Add(Me.ButtonZNeg)
        Me.Controls.Add(Me.ButtonXNeg)
        Me.Controls.Add(Me.ButtonXPos)
        Me.Controls.Add(Me.ButtonYPos)
        Me.Controls.Add(Me.ButtonInc100)
        Me.Controls.Add(Me.ButtonInc10)
        Me.Controls.Add(Me.ButtonInc1)
        Me.Controls.Add(Me.ButtonIncPt1)
        Me.Controls.Add(Me.ButtonIncPt01)
        Me.Controls.Add(Me.ButtonYNeg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Text = "X Controller Test Program"
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJogIncrement As Label
    Friend WithEvents ButtonZPos As Button
    Friend WithEvents ButtonZNeg As Button
    Friend WithEvents ButtonXNeg As Button
    Friend WithEvents ButtonXPos As Button
    Friend WithEvents ButtonYPos As Button
    Friend WithEvents ButtonInc100 As Button
    Friend WithEvents ButtonInc10 As Button
    Friend WithEvents ButtonInc1 As Button
    Friend WithEvents ButtonIncPt1 As Button
    Friend WithEvents ButtonIncPt01 As Button
    Friend WithEvents ButtonYNeg As Button
    Friend WithEvents ButtonSpindleOn As Button
    Friend WithEvents ButtonSpindleOff As Button
    Friend WithEvents ButtonMistOn As Button
    Friend WithEvents ButtonFloodOn As Button
    Friend WithEvents ButtonCoolantOff As Button
    Friend WithEvents LabelXLim As Label
    Friend WithEvents LabelYLim As Label
    Friend WithEvents LabelZLIm As Label
    Friend WithEvents LabelFeedhold As Label
    Friend WithEvents LabelCycleStart As Label
    Friend WithEvents LabelProbe As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonPortOpen As Button
    Friend WithEvents ComboBoxPorts As ComboBox
    Friend WithEvents LabelXPos As Label
    Friend WithEvents LabelYPos As Label
    Friend WithEvents LabelZPos As Label
    Friend WithEvents TimerPortCheck As Timer
    Friend WithEvents LabelState As Label
    Friend WithEvents ButtonReadSwitches As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents LabelReset As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenProgramFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonClearAlarm As Button
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonHome As Button
    Friend WithEvents LabelGrblVer As Label
End Class
