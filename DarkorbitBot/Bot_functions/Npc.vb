Imports Microsoft

Public Class Npc

    Public Shared Student As Object = "System.Object[]"


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

        Try
            Dim Locked = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
            If Locked.contains(Student) Then

                Console.WriteLine("Npc Locked")
                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "1")
                Wait_npc_is_killed()
            End If


        Catch Locked As MissingMemberException


            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine("ERROR")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Load()
            Exit Function

        End Try

    End Function


    Public Shared Async Function Wait_npc_is_killed() As Task

retour:

        Try
            Dim Locked1 = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
            If Locked1.contains(Student) Then

                Console.WriteLine("on fire, wait...")
                Console.WriteLine(Locked1)
                Locked1 = Nothing
                Await Task.Delay(1000)
                GoTo retour

            End If

        Catch Locked1 As MissingMemberException

            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine("ERROR")
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Load()
            Exit Function

        End Try


    End Function

End Class
