Imports Microsoft

Public Class Npc

    Public Shared Locked As Object
    Public Shared Locked1 As Object
    Public Shared Shared_ As Object = 0

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
            If Shared_ = 1 Then
                Alpha_Gates.Search_current_waves()
                Exit Function

            Else
                Console.WriteLine("No Npc arround")
                Await Task.Delay(1000)
                GoTo RetourLoad

            End If
        End If

    End Function

    Public Shared Function Control_Npc_attack() As Task

        Locked = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
        'Console.WriteLine(Locked)
        If Locked.ToString.Contains(Var.Student) Then

            Console.WriteLine("Npc Locked")
            'Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "1")
            Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "{LCTRL}")
            Control_Npc_dead()
        Else
            If Shared_ = 1 Then
                Alpha_Gates.Search_current_waves()
                Exit Function

            Else
                Load()
                Exit Function

            End If
        End If


    End Function


    Public Shared Async Function Control_Npc_dead() As Task

RetourNPC_Is_Killed:
        'If Var.User_Stop_Bot = True Then Exit Function

        Locked1 = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
        'Console.WriteLine(Locked1)
        If Locked1.ToString.Contains(Var.Student) Then

            Console.WriteLine("on fire, wait...")

            If Locked1(0) >= 400 Then
                If Locked1(1) >= 300 Then
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 300, Locked1(1) - 50)
                Else
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 300, Locked1(1) + 50)

                End If
            Else
                If Locked1(1) >= 300 Then
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 500, Locked1(1) - 50)
                Else
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 500, Locked1(1) + 50)
                End If
            End If
            Await Task.Delay(100)

            GoTo RetourNPC_Is_Killed
        Else
            If Shared_ = 1 Then
                Alpha_Gates.Search_current_waves()
                Exit Function

            Else
                Load()
                Exit Function

            End If
        End If

    End Function

End Class
