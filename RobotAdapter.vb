Public Class RobotAdapter
    Implements IVihicleAttacker

    Private robot As Robot

    Sub New(robot As Robot)
        Me.robot = robot
    End Sub

    Public Sub assignWeappon(weapon As String) Implements IVihicleAttacker.assignWeappon
        Console.WriteLine("Robot " & Me.robot.name & " cannot aquire weapon " & weapon)
    End Sub

    Public Sub attack() Implements IVihicleAttacker.attack
        Me.robot.assault()
    End Sub

    Public Sub move(direction As String, speed As Double) Implements IVihicleAttacker.move
        Me.robot.move(speed, direction)
    End Sub
End Class
