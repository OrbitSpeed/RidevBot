Public Class Dead

    Public Shared Async Function Load() As Task


        Var.Update_Screen()
        Console.WriteLine("Verifying if your Dead, wait...")

        Dim Detect_if_dead_get As Point = Var.Client_Screen.Contains(Var.Detect_if_dead)
        If Detect_if_dead_get <> Nothing Then
            Console.WriteLine("You are Dead, wait...")
            Await Shell_Dead()
            Console.WriteLine("Alive, continue.")
        Else
            Console.WriteLine("Alive, continue.")
        End If

    End Function

    Public Shared Async Function Shell_Dead() As Task

        Var.Update_Screen()
        Console.WriteLine("Control Location...")

        If Form_tools.ComboBox_repair.Text = "Base" Then
            Dim Repair_location_1 As Point = Var.Client_Screen.Contains(Var.Base_repair)
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Repair_location_1.X, Repair_location_1.Y)
            Console.WriteLine("Base repair selected")
            Await Task.Delay(10000)

        ElseIf Form_tools.ComboBox_repair.Text = "Portal" Then
            Dim Repair_location_2 As Point = Var.Client_Screen.Contains(Var.Portal_repair)
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Repair_location_2.X, Repair_location_2.Y)
            Console.WriteLine("Portal repair selected")
            Await Task.Delay(10000)

        ElseIf Form_tools.ComboBox_repair.Text = "Instant" Then
            Dim Repair_location_3 As Point = Var.Client_Screen.Contains(Var.Instant_repair)
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Repair_location_3.X, Repair_location_3.Y)
            Console.WriteLine("Instant repair selected")
            Await Task.Delay(10000)

        End If

        Console.WriteLine("reducing game...")
        Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "-")
        Await Task.Delay(100)
        Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "-")
        Await Task.Delay(100)
        Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "-")
        Await Task.Delay(100)
        Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "-")
        Await Task.Delay(100)
        Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "-")
        Await Task.Delay(100)

    End Function


End Class
