Module Module1

    Sub Main()

        Dim optimus As New Robot("Optimus Prime")
        Dim OptimusAdapter As New RobotAdapter(Optimus)
        Dim Leopard As New Tank("Leopard")

        optimus.assault()
        optimus.move(22.79, "north")

        Leopard.attack()
        Leopard.move("west", 34.27)
        Leopard.assignWeappon("Laser")
        Leopard.attack()

        OptimusAdapter.attack()
        OptimusAdapter.move("east", 10.33)
        OptimusAdapter.assignWeappon("sword")

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
