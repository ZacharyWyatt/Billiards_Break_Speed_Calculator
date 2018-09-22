<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PicturePoolTable = New System.Windows.Forms.PictureBox()
        Me.StaticLabelDate = New System.Windows.Forms.Label()
        Me.StaticLabelTime = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.DateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.rdb7FootTable = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb12FootTable = New System.Windows.Forms.RadioButton()
        Me.rdb9FootTable = New System.Windows.Forms.RadioButton()
        Me.rdb8FootTable = New System.Windows.Forms.RadioButton()
        Me.StaticLabelSelectTable = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbSecondDiamond = New System.Windows.Forms.RadioButton()
        Me.StaticLabelSelectLocation = New System.Windows.Forms.Label()
        Me.rdbFirstDiamond = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.LabelStaticElapsedTime = New System.Windows.Forms.Label()
        Me.LabelStaticBreakSpeed = New System.Windows.Forms.Label()
        Me.LabelElapsedTime = New System.Windows.Forms.Label()
        Me.LabelBreakSpeed = New System.Windows.Forms.Label()
        CType(Me.PicturePoolTable,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'PicturePoolTable
        '
        Me.PicturePoolTable.Image = Global.MidtermProject.My.Resources.Resources.SevenFootTable
        Me.PicturePoolTable.InitialImage = CType(resources.GetObject("PicturePoolTable.InitialImage"),System.Drawing.Image)
        Me.PicturePoolTable.Location = New System.Drawing.Point(5, 5)
        Me.PicturePoolTable.Name = "PicturePoolTable"
        Me.PicturePoolTable.Size = New System.Drawing.Size(1000, 553)
        Me.PicturePoolTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePoolTable.TabIndex = 0
        Me.PicturePoolTable.TabStop = false
        '
        'StaticLabelDate
        '
        Me.StaticLabelDate.AutoSize = true
        Me.StaticLabelDate.BackColor = System.Drawing.Color.Transparent
        Me.StaticLabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StaticLabelDate.Location = New System.Drawing.Point(30, 561)
        Me.StaticLabelDate.Name = "StaticLabelDate"
        Me.StaticLabelDate.Size = New System.Drawing.Size(89, 33)
        Me.StaticLabelDate.TabIndex = 1
        Me.StaticLabelDate.Text = "Date:"
        Me.StaticLabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StaticLabelTime
        '
        Me.StaticLabelTime.AutoSize = true
        Me.StaticLabelTime.BackColor = System.Drawing.Color.Transparent
        Me.StaticLabelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StaticLabelTime.Location = New System.Drawing.Point(30, 598)
        Me.StaticLabelTime.Name = "StaticLabelTime"
        Me.StaticLabelTime.Size = New System.Drawing.Size(94, 33)
        Me.StaticLabelTime.TabIndex = 2
        Me.StaticLabelTime.Text = "Time:"
        Me.StaticLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = true
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelDate.Location = New System.Drawing.Point(125, 565)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(280, 29)
        Me.LabelDate.TabIndex = 3
        Me.LabelDate.Text = "Tuesday, March 06, 2018"
        Me.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = true
        Me.LabelTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelTime.Location = New System.Drawing.Point(125, 602)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(132, 29)
        Me.LabelTime.TabIndex = 4
        Me.LabelTime.Text = "1:35:30 PM"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimer
        '
        Me.DateTimer.Interval = 1000
        '
        'rdb7FootTable
        '
        Me.rdb7FootTable.AutoSize = true
        Me.rdb7FootTable.Checked = true
        Me.rdb7FootTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdb7FootTable.Location = New System.Drawing.Point(6, 42)
        Me.rdb7FootTable.Name = "rdb7FootTable"
        Me.rdb7FootTable.Size = New System.Drawing.Size(168, 33)
        Me.rdb7FootTable.TabIndex = 5
        Me.rdb7FootTable.TabStop = true
        Me.rdb7FootTable.Text = "7 Foot Table"
        Me.rdb7FootTable.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdb12FootTable)
        Me.GroupBox1.Controls.Add(Me.rdb9FootTable)
        Me.GroupBox1.Controls.Add(Me.rdb8FootTable)
        Me.GroupBox1.Controls.Add(Me.StaticLabelSelectTable)
        Me.GroupBox1.Controls.Add(Me.rdb7FootTable)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 644)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 205)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = false
        '
        'rdb12FootTable
        '
        Me.rdb12FootTable.AutoSize = true
        Me.rdb12FootTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdb12FootTable.Location = New System.Drawing.Point(5, 159)
        Me.rdb12FootTable.Name = "rdb12FootTable"
        Me.rdb12FootTable.Size = New System.Drawing.Size(191, 33)
        Me.rdb12FootTable.TabIndex = 10
        Me.rdb12FootTable.Text = "Snooker Table"
        Me.rdb12FootTable.UseVisualStyleBackColor = true
        '
        'rdb9FootTable
        '
        Me.rdb9FootTable.AutoSize = true
        Me.rdb9FootTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdb9FootTable.Location = New System.Drawing.Point(6, 120)
        Me.rdb9FootTable.Name = "rdb9FootTable"
        Me.rdb9FootTable.Size = New System.Drawing.Size(168, 33)
        Me.rdb9FootTable.TabIndex = 9
        Me.rdb9FootTable.Text = "9 Foot Table"
        Me.rdb9FootTable.UseVisualStyleBackColor = true
        '
        'rdb8FootTable
        '
        Me.rdb8FootTable.AutoSize = true
        Me.rdb8FootTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdb8FootTable.Location = New System.Drawing.Point(5, 81)
        Me.rdb8FootTable.Name = "rdb8FootTable"
        Me.rdb8FootTable.Size = New System.Drawing.Size(168, 33)
        Me.rdb8FootTable.TabIndex = 8
        Me.rdb8FootTable.Text = "8 Foot Table"
        Me.rdb8FootTable.UseVisualStyleBackColor = true
        '
        'StaticLabelSelectTable
        '
        Me.StaticLabelSelectTable.AutoSize = true
        Me.StaticLabelSelectTable.BackColor = System.Drawing.Color.Transparent
        Me.StaticLabelSelectTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StaticLabelSelectTable.Location = New System.Drawing.Point(0, 10)
        Me.StaticLabelSelectTable.Name = "StaticLabelSelectTable"
        Me.StaticLabelSelectTable.Size = New System.Drawing.Size(414, 29)
        Me.StaticLabelSelectTable.TabIndex = 7
        Me.StaticLabelSelectTable.Text = "Select the Appropriate Table Size:"
        Me.StaticLabelSelectTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdbSecondDiamond)
        Me.GroupBox2.Controls.Add(Me.StaticLabelSelectLocation)
        Me.GroupBox2.Controls.Add(Me.rdbFirstDiamond)
        Me.GroupBox2.Location = New System.Drawing.Point(484, 644)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 125)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = false
        '
        'rdbSecondDiamond
        '
        Me.rdbSecondDiamond.AutoSize = true
        Me.rdbSecondDiamond.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdbSecondDiamond.Location = New System.Drawing.Point(5, 81)
        Me.rdbSecondDiamond.Name = "rdbSecondDiamond"
        Me.rdbSecondDiamond.Size = New System.Drawing.Size(217, 33)
        Me.rdbSecondDiamond.TabIndex = 8
        Me.rdbSecondDiamond.Text = "Second Diamond"
        Me.rdbSecondDiamond.UseVisualStyleBackColor = true
        '
        'StaticLabelSelectLocation
        '
        Me.StaticLabelSelectLocation.AutoSize = true
        Me.StaticLabelSelectLocation.BackColor = System.Drawing.Color.Transparent
        Me.StaticLabelSelectLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StaticLabelSelectLocation.Location = New System.Drawing.Point(0, 10)
        Me.StaticLabelSelectLocation.Name = "StaticLabelSelectLocation"
        Me.StaticLabelSelectLocation.Size = New System.Drawing.Size(493, 29)
        Me.StaticLabelSelectLocation.TabIndex = 7
        Me.StaticLabelSelectLocation.Text = "Select the Appropriate Cue Ball Location:"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.StaticLabelSelectLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbFirstDiamond
        '
        Me.rdbFirstDiamond.AutoSize = true
        Me.rdbFirstDiamond.Checked = true
        Me.rdbFirstDiamond.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdbFirstDiamond.Location = New System.Drawing.Point(6, 42)
        Me.rdbFirstDiamond.Name = "rdbFirstDiamond"
        Me.rdbFirstDiamond.Size = New System.Drawing.Size(181, 33)
        Me.rdbFirstDiamond.TabIndex = 5
        Me.rdbFirstDiamond.TabStop = true
        Me.rdbFirstDiamond.Text = "First Diamond"
        Me.rdbFirstDiamond.UseVisualStyleBackColor = true
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.DarkGreen
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.Location = New System.Drawing.Point(484, 788)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(134, 61)
        Me.StartButton.TabIndex = 12
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = false
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ExitButton.Location = New System.Drawing.Point(845, 788)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(134, 61)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = true
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ResetButton.Location = New System.Drawing.Point(662, 788)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(134, 61)
        Me.ResetButton.TabIndex = 14
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'LabelStaticElapsedTime
        '
        Me.LabelStaticElapsedTime.AutoSize = true
        Me.LabelStaticElapsedTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaticElapsedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelStaticElapsedTime.Location = New System.Drawing.Point(572, 561)
        Me.LabelStaticElapsedTime.Name = "LabelStaticElapsedTime"
        Me.LabelStaticElapsedTime.Size = New System.Drawing.Size(215, 33)
        Me.LabelStaticElapsedTime.TabIndex = 15
        Me.LabelStaticElapsedTime.Text = "Elapsed Time:"
        Me.LabelStaticElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelStaticBreakSpeed
        '
        Me.LabelStaticBreakSpeed.AutoSize = true
        Me.LabelStaticBreakSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaticBreakSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelStaticBreakSpeed.Location = New System.Drawing.Point(478, 598)
        Me.LabelStaticBreakSpeed.Name = "LabelStaticBreakSpeed"
        Me.LabelStaticBreakSpeed.Size = New System.Drawing.Size(309, 33)
        Me.LabelStaticBreakSpeed.TabIndex = 16
        Me.LabelStaticBreakSpeed.Text = "Speed of Your break:"
        Me.LabelStaticBreakSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelElapsedTime
        '
        Me.LabelElapsedTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelElapsedTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelElapsedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelElapsedTime.Location = New System.Drawing.Point(793, 565)
        Me.LabelElapsedTime.Name = "LabelElapsedTime"
        Me.LabelElapsedTime.Size = New System.Drawing.Size(184, 29)
        Me.LabelElapsedTime.TabIndex = 17
        Me.LabelElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelBreakSpeed
        '
        Me.LabelBreakSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LabelBreakSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBreakSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelBreakSpeed.Location = New System.Drawing.Point(793, 602)
        Me.LabelBreakSpeed.Name = "LabelBreakSpeed"
        Me.LabelBreakSpeed.Size = New System.Drawing.Size(184, 29)
        Me.LabelBreakSpeed.TabIndex = 18
        Me.LabelBreakSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 885)
        Me.Controls.Add(Me.LabelBreakSpeed)
        Me.Controls.Add(Me.LabelElapsedTime)
        Me.Controls.Add(Me.LabelStaticBreakSpeed)
        Me.Controls.Add(Me.LabelStaticElapsedTime)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.StaticLabelTime)
        Me.Controls.Add(Me.StaticLabelDate)
        Me.Controls.Add(Me.PicturePoolTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1025, 603)
        Me.Name = "Form1"
        Me.Text = "Cue Ball Break Speed Calculator"
        CType(Me.PicturePoolTable,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PicturePoolTable As PictureBox
    Friend WithEvents StaticLabelDate As Label
    Friend WithEvents StaticLabelTime As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelTime As Label
    Friend WithEvents DateTimer As Timer
    Friend WithEvents rdb7FootTable As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdb12FootTable As RadioButton
    Friend WithEvents rdb9FootTable As RadioButton
    Friend WithEvents rdb8FootTable As RadioButton
    Friend WithEvents StaticLabelSelectTable As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbSecondDiamond As RadioButton
    Friend WithEvents StaticLabelSelectLocation As Label
    Friend WithEvents rdbFirstDiamond As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents LabelStaticElapsedTime As Label
    Friend WithEvents LabelStaticBreakSpeed As Label
    Friend WithEvents LabelElapsedTime As Label
    Friend WithEvents LabelBreakSpeed As Label
End Class
