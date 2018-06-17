Public Class Robot
    Implements IRobotAttacker

    Private nameValue As String
    Public ReadOnly Property name() As String
        Get
            Return nameValue
        End Get
    End Property

    Sub New(name As String)
        Me.nameValue = name
    End Sub

    Public Sub assault() Implements IRobotAttacker.assault
        Console.WriteLine("Robot " & Me.name & " inflicted " & CInt(Math.Ceiling(Rnd() * 10)) + 1 & " damage with it's hands")
    End Sub

    Public Sub move(speed As Double, direction As String) Implements IRobotAttacker.move
        Console.WriteLine("Robot " & Me.name & " moved with " & speed & "Km/h to the " & direction)
    End Sub
End Class
