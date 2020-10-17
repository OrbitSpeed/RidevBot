Imports System.ComponentModel
Imports AutoItX3Lib
Public Class RUNNING

    Declare Function BlockInput Lib "user32" (ByVal fBlockIt As Boolean) As Boolean
    Public Shared AutoIt As New AutoItX3

#Region "Start_Bot_function"
    ' legende :
    ' [¿¿¿] A REMPLACER PAR UN DETECTION AUTOMATIQUE DE L'EMPLACEMENT DE LA MINI MAP

    Public Shared Function Update_Screen()

        Dim Client_primary = New Bitmap(Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Width, Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Form_Game.Invoke(New MethodInvoker(Sub()
                                               Client_second.CopyFromScreen(Form_Game.PointToScreen(Form_Game.WebBrowser_Game_Ridevbot.Location), New Point(0, 0), Form_Game.WebBrowser_Game_Ridevbot.ClientSize)
                                           End Sub))
        Return Client_primary

    End Function ' Update Screen >> [Ok] 
    Public Shared Function Start()

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        Form_Game.WebBrowser_Game_Ridevbot.Select()
        Var.Client_Screen = Update_Screen()

        Dim Connection_Lost As Point = Var.Client_Screen.Contains(Var.Disconnected)
        If Connection_Lost <> Nothing Then
            reconnect()
            Exit Function
        End If

        ' A REMPLACER PAR UN DETECTION AUTOMATIQUE DE L'EMPLACEMENT DE LA MINI MAP
        Dim Save_point_original As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original.X = "762" Then
            Start_suite()
        Else
            Minimap_load()
            Exit Function
        End If

    End Function ' On lance le bot >> [Ok]
    Public Shared Function Stopped()
        Console.WriteLine("Stooped")
    End Function ' Stopped All function >> [Ok]
    Public Shared Async Function reconnect() As Task

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        Var.Client_Screen = Update_Screen()
        Dim Connection_Lost As Point = Var.Client_Screen.Contains(Var.Disconnected)

        If Connection_Lost <> Nothing Then

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 300, 354)
            Console.WriteLine("Reconnexion")
            Await Task.Delay(7000)
            'Try
            Var.Client_Screen = Update_Screen()
            Dim deconnection_popup As Point = Var.Client_Screen.Contains(Var.deconnection_popup_visible)

            If deconnection_popup <> Nothing Then
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 409, 348)
                Await Task.Delay(1000)
                Start()
            Else
                Start() ' ERREUR PROBABLE ICI ???
            End If

        Else
            Console.WriteLine("Reconnexion introuvable")
            Stopped()
        End If

    End Function ' Se reconnecter >> [¿¿¿]

#Region "Minimap"
    Public Shared Async Function Minimap_load() As Task

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
        Form_tools.TextBox_desactive_allkey.Refresh()
        Form_tools.TextBox_desactive_allkey.Update()
        AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_tools.TextBox_desactive_allkey.Text))
        Await Task.Delay(800)

        Var.Client_Screen = Update_Screen()
        Dim Minimap_closed As Point = Var.Client_Screen.Contains(Var.Minimap_closed_ref)
        If Minimap_closed <> Nothing Then

            Form_Game.WebBrowser_Game_Ridevbot.Select()
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_closed.X, Minimap_closed.Y + 18)
            Await Task.Delay(800)
            Console.WriteLine("Minimap Ouverte")
            Minimap_resize()

        Else
            Start()
            Exit Function
        End If

    End Function ' Load
    Public Shared Async Function Minimap_resize() As Task

        Var.Client_Screen = Update_Screen()
        Dim Minimap_size As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        Dim compare As Point

        If Minimap_size <> Nothing Then

            For i = 0 To 15
                Await Task.Delay(60)
                Var.Client_Screen = Update_Screen()
                Minimap_size = Var.Client_Screen.Contains(Var.Minimap_size_ref)
                If Minimap_size <> Nothing Then
                    If compare = Minimap_size Then
                        i = 15
                        Console.WriteLine("Réduction Minimap > Ouverte <")

                    Else
                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_size.X, Minimap_size.Y)
                        compare = Minimap_size
                    End If
                End If
            Next
            Minimap_movement()
        Else
            Start()
            Exit Function
        End If

    End Function ' Resize
    Public Shared Async Function Minimap_movement() As Task
        Var.Client_Screen = Update_Screen()
        Dim Minimap_move As Point = Var.Client_Screen.Contains(Var.Move_minimap_box_ref)
        If Minimap_move <> Nothing Then

            Dim cursor_Pos = Cursor.Position
            Cursor.Position = New Point(Minimap_move.X - 40, Minimap_move.Y + 20)
            AutoIt.MouseDown("LEFT")
            Await Task.Delay(10)
            Cursor.Position = New Point(759, 599)
            AutoIt.MouseUp("LEFT")
            Cursor.Position = cursor_Pos
            Await Task.Delay(1200)

            Console.WriteLine("déplacement minimap > Ouverte < éffectué")
            Start_suite()
        Else
            Start()
        End If

    End Function ' Movement
#End Region ' >> [¿¿¿]

#End Region ' 1 Suggestion !

    Public Shared Function Start_suite()



    End Function

End Class
