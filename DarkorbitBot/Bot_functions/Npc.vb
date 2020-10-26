Public Class Npc

    Public Shared Async Function Load() As Task

retour2:
        Var.Update_Screen()
        Dim All_Npc = My.Resources.All_npc

        Dim Npc As Point = Var.Client_Screen.Contains(All_Npc)
        If Npc <> Nothing Then

            Console.WriteLine("Npc Arround")
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc.X + 30, Npc.Y - 30)
            Await Task.Delay(500)
            func_all()
            Exit Function

        Else
            Console.WriteLine("No Npc arround")
            Await Task.Delay(1000)
            GoTo retour2

        End If

    End Function

    Public Shared Async Function func_all() As Task


        Dim Locked = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
        Console.WriteLine(Locked(1))
        If IsError(Locked(1)) Then
            Load()
            Exit Function
        Else
            Console.WriteLine("Npc Locked")
            Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "1")
            Await Task.Delay(1000)

        End If
retour:
        Dim Locked1 = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
        Console.WriteLine(Locked1(1))
        If IsError(Locked1(1)) Then
            Load()
            Exit Function

        Else
            Console.WriteLine("on fire, wait...")
            Await Task.Delay(1000)
            GoTo retour

        End If

        'Console.WriteLine($"temps:{dt.ElapsedMilliseconds}")

    End Function

End Class
