Public Class Form1
    'Constants
    'Const inchesPerMile As Integer = 63360
    'Const secondsPerHour As Integer = 3600
    Const inchPerSecondRatio As Decimal = 0.0568

    'Globals
    Dim myTimeKeeper As timeKeeper = New timeKeeper(False)
    Dim playAreaLength As Integer = 79 'Represents the length of the table's play area, in inches

    'When the form is loaded...
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Show the current date and time
        WriteCurrentTime()

        'Start the timer for updating the time and date
        DateTimer.Enabled = True
    End Sub

    'Updates the appropriate labels with the current time and date
    Private Sub WriteCurrentTime()
        LabelDate.Text = Format(Date.Now(), "dddd, MMMM dd, yyyy")
        LabelTime.Text = Format(Date.Now(), "h:mm:ss tt")
    End Sub

    'Event handler for DateTimer's tick
    Private Sub DateTimer_Tick(sender As Object, e As EventArgs) Handles DateTimer.Tick
        WriteCurrentTime()
    End Sub

    'When Radio Button - 7 Foot is clicked...
    Private Sub rdb7FootTable_CheckedChanged(sender As Object, e As EventArgs) Handles rdb7FootTable.CheckedChanged
        'Set the table image, and playAreaLength variable, to the appropriate size table
        PicturePoolTable.Image = My.Resources.Resources.SevenFootTable
        playAreaLength = 79
    End Sub

    'When Radio Button - 8 Foot is clicked...
    Private Sub rdb8FootTable_CheckedChanged(sender As Object, e As EventArgs) Handles rdb8FootTable.CheckedChanged
        PicturePoolTable.Image = My.Resources.Resources.EightFootTable
        playAreaLength = 88
    End Sub

    'When Radio Button - 9 Foot is clicked...
    Private Sub rdb9FootTable_CheckedChanged(sender As Object, e As EventArgs) Handles rdb9FootTable.CheckedChanged
        PicturePoolTable.Image = My.Resources.Resources.NineFootTable
        playAreaLength = 100
    End Sub

    'When Radio Button - 12 Foot is clicked...
    Private Sub rdb12FootTable_CheckedChanged(sender As Object, e As EventArgs) Handles rdb12FootTable.CheckedChanged
        PicturePoolTable.Image = My.Resources.Resources.TwelveFootTable
        playAreaLength = 140.5
    End Sub

    'When the Start Button is clicked...
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        'If you're starting the timer...
        If myTimeKeeper.timerStarted = False Then
            'Change the Start button color and text, and DISABLE the reset button
            StartButton.BackColor = Color.FromName("Red")
            StartButton.Text = "Stop"
            ResetButton.Enabled = False

            'Stop updating the current time and date, and save the start time
            DateTimer.Enabled = False
            myTimeKeeper.timerStarted = True
            myTimeKeeper.startTimer = System.DateTime.Now

        'If you're stopping the timer...
        ElseIf myTimeKeeper.timerStarted = True Then

            'Will hold the break time, IN SECONDS, for use below
            Dim breakTime As String = ""

            'DISABLE the Start button, change its colors and text, and ENABLE the reset button, and change its colors
            StartButton.Enabled = False
            StartButton.BackColor = SystemColors.Control
            StartButton.ForeColor = SystemColors.ControlText
            StartButton.Text = "Start"
            ResetButton.Enabled = True
            ResetButton.BackColor = Color.FromName("ForestGreen")
            ResetButton.ForeColor = Color.FromName("White")

            'Save the end time
            myTimeKeeper.endTimer = System.DateTime.Now
            myTimeKeeper.timerStarted = False

            'Update the appropriate labels with the elapsed time and break speed
            breakTime = myTimeKeeper.returnDifference

            'If the cue ball is at the first diamond...
            If rdbFirstDiamond.Checked = True Then
                '"0.125" represents that the first diamond is at 1/8 the length of the table
                '"0.25" represents that the billiard balls start at 1/4 the length of the table
                LabelBreakSpeed.Text = Format(((playAreaLength - (playAreaLength * 0.125) - (playAreaLength * 0.25)) * inchPerSecondRatio) / (breakTime), "0.#") + "mph"


            'If the cue ball is at the second diamond...
            ElseIf rdbSecondDiamond.Checked = True Then
                'the first "0.25" represents that the second diamond is at 1/4 the length of the table
                'the second "0.25" represents that the billiard balls start at 1/4 the length of the table
                LabelBreakSpeed.Text = Format(((playAreaLength - (playAreaLength * 0.25) - (playAreaLength * 0.25)) * inchPerSecondRatio) / (breakTime), "0.#") + "mph"
            End If

            LabelElapsedTime.Text = breakTime + "s"
        End If
    End Sub

    'When the Reset Button is clicked...
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'ENABLE the start button, change its colors, change the reset button's colors
        StartButton.Enabled = True
        StartButton.BackColor = Color.FromName("ForestGreen")
        StartButton.ForeColor = Color.FromName("White")
        ResetButton.BackColor = SystemColors.Control
        ResetButton.ForeColor = SystemColors.ControlText

        'Resume updating the current time and date
        WriteCurrentTime()
        DateTimer.Enabled = True

        'Clear the elapsed time and break speed labels
        LabelElapsedTime.Text = ""
        LabelBreakSpeed.Text = ""
    End Sub

    'When the Exit Button is clicked...
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Notes
    'The balls start at 1/4 the length of the table
    'The first diamond is 1/8 the length of the table
    'The second is 1/4 the length of the table
End Class
