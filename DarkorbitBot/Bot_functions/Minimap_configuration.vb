Public Class Minimap_configuration

    Public Shared Function Load() As Task

        If Var.User_Stop_Bot Then Exit Function

        Dim Save_point_original As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original.X = "762" Then

            Console.WriteLine("Minimap get/set correct")
            If Var.User_Stop_Bot Then Exit Function
            Var.security = 1
            Running.Start()
            Exit Function
        Else
            Console.WriteLine("Configuration ( minimap ) in times...")
            If Var.User_Stop_Bot Then Exit Function
            SharedTask()

        End If

    End Function

    Public Shared Async Function SharedTask() As Task
        If Var.User_Stop_Bot Then Exit Function

        Form_tools.TextBox_desactive_allkey.Refresh()
        Form_tools.TextBox_desactive_allkey.Update()
        Form_Game.WebBrowser_Game_Ridevbot.Select()

        Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_tools.TextBox_desactive_allkey.Text))
        Await Task.Delay(1000)

        Var.Client_Screen = Var.Update_Screen()
        Dim Minimap_closed As Point = Var.Client_Screen.Contains(Var.Minimap_closed_ref)
        If Minimap_closed <> Nothing Then

            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_closed.X, Minimap_closed.Y + 18)
            Await Task.Delay(1000)
            If Var.User_Stop_Bot Then Exit Function
            Console.WriteLine("Minimap Ouverte")
            Minimap_resize()

        Else
            Load()
            'Exit Function
        End If

    End Function

    Public Shared Async Function Minimap_resize() As Task

        If Var.User_Stop_Bot Then Exit Function

        Var.Client_Screen = Var.Update_Screen()

        Dim Minimap_size As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        Dim compare As Point

        If Minimap_size <> Nothing Then

            For i = 0 To 15
                Await Task.Delay(60)
                If Var.User_Stop_Bot Then Exit Function
                Var.Client_Screen = Var.Update_Screen()
                Minimap_size = Var.Client_Screen.Contains(Var.Minimap_size_ref)
                If Minimap_size <> Nothing Then
                    If compare = Minimap_size Then
                        i = 15
                        Console.WriteLine("Réduction Minimap > Ouverte <")
                        If Var.User_Stop_Bot Then Exit Function

                    Else
                        If Var.User_Stop_Bot Then Exit Function
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_size.X, Minimap_size.Y)
                        compare = Minimap_size
                    End If
                End If
            Next
            Minimap_movement()
            If Var.User_Stop_Bot Then Exit Function
        Else
            Load()
            'Exit Function
        End If

    End Function

    Public Shared Async Function Minimap_movement() As Task

        If Var.User_Stop_Bot Then Exit Function
        Var.Client_Screen = Var.Update_Screen()
        Dim Minimap_move As Point = Var.Client_Screen.Contains(Var.Move_minimap_box_ref)
        If Minimap_move <> Nothing Then

            Dim cursor_Pos = Cursor.Position
            Cursor.Position = New Point(Minimap_move.X - 40, Minimap_move.Y + 20)
            Var.AutoIt.MouseDown("LEFT")
            Await Task.Delay(10)
            Cursor.Position = New Point(759, 599)
            Var.AutoIt.MouseUp("LEFT")
            Cursor.Position = cursor_Pos
            Await Task.Delay(1200)
            If Var.User_Stop_Bot Then Exit Function

            Console.WriteLine("déplacement minimap > Ouverte < éffectué")
            Var.security = 1
            Running.Start()
        Else
            Load()
        End If

    End Function

End Class
