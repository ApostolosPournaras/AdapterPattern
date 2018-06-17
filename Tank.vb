Public Class Tank
    Implements IVihicleAttacker


    Private nameValue As String
    Public ReadOnly Property name() As String
        Get
            Return nameValue
        End Get
    End Property

    Private weapon As String = "Cannon"

    Sub New(name As String)
        Me.nameValue = name
    End Sub

    Public Sub assignWeappon(weapon As String) Implements IVihicleAttacker.assignWeappon
        Me.weapon = weapon
        Console.WriteLine("Tank " & Me.name & " got the weapon " & weapon)
    End Sub

    Public Sub attack() Implements IVihicleAttacker.attack
        Console.WriteLine("Tank " & Me.name & " inflicted " & CInt(Math.Ceiling(Rnd() * 10)) + 1 & " damage with " & Me.weapon)
    End Sub

    Public Sub move(direction As String, speed As Double) Implements IVihicleAttacker.move
        Console.WriteLine("Tank " & Me.name & " moved with " & speed & "Km/h to the " & direction)
    End Sub
End Class
