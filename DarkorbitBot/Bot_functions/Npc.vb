Imports Microsoft

Public Class Npc

    Public Shared Student As String = "System.Object[]"
    Private Shared Locked As Object
    Private Shared Locked1 As Object

    Public Shared Async Function Load() As Task

RetourLoad:

        Var.Update_Screen()
        Dim All_Npc = My.Resources.All_npc

        Dim Npc As Point = Var.Client_Screen.Contains(All_Npc)
        If Npc <> Nothing Then

            Console.WriteLine("Npc Arround")
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc.X + 30, Npc.Y - 30)
            Await Task.Delay(500)
            Control_Npc_attack()
            Exit Function

        Else
            Console.WriteLine("No Npc arround")
            Await Task.Delay(1000)
            GoTo RetourLoad

        End If

    End Function

    Public Shared Function Control_Npc_attack() As Task

        Locked = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
        'Console.WriteLine(Locked)
        If Locked.ToString.Contains(Student) Then

            Console.WriteLine("Npc Locked")
            'Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "1")
            Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "{LCTRL}")
            Control_Npc_dead()
        Else
            Load()
            Exit Function

        End If


    End Function


    Public Shared Async Function Control_Npc_dead() As Task

RetourNPC_Is_Killed:
        'If Var.User_Stop_Bot = True Then Exit Function

        Locked1 = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
        'Console.WriteLine(Locked1)
        If Locked1.ToString.Contains(Student) Then

            Console.WriteLine("on fire, wait...")
            Await Task.Delay(1000)
            GoTo RetourNPC_Is_Killed
        Else
            Load()
            Exit Function
        End If



    End Function

End Class
