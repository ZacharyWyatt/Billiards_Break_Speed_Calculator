Public Class timeKeeper
    'Variables
    Private timerBool As Boolean
    Private startTime As Date
    Private endTime As Date

    'Constructor
    Public Sub New(initialBool As Boolean)
        timerBool = initialBool
    End Sub

    'Properties
    Public Property timerStarted() As Boolean
        Get
            Return timerBool
        End Get
        Set(value As Boolean)
            timerBool = value
        End Set
    End Property

    Public Property startTimer() As Date
        Get
            Return startTime
        End Get
        Set(value As Date)
            startTime = value
        End Set
    End Property

    Public Property endTimer() As Date
        Get
            Return endTime
        End Get
        Set(value As Date)
            endTime = value
        End Set
    End Property

    'Fuctions
    Public Function returnDifference() As Double
        'Returns the difference in times, as seconds
        Return Format((endTime - startTime).TotalSeconds, "0.####")
    End Function
End Class
