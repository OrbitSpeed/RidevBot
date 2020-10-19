Imports System.ComponentModel
Imports AutoItX3Lib
Public Class RUNNING

    Declare Function BlockInput Lib "user32" (ByVal fBlockIt As Boolean) As Boolean
    Public Shared AutoIt As New AutoItX3

#Region "Start_Bot_function"
    ' legende :
    ' [¿¿¿] A REMPLACER PAR UN DETECTION AUTOMATIQUE DE L'EMPLACEMENT DE LA MINI MAP

    Public Shared Function Start()

        Console.WriteLine("Start atteint")

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        Console.WriteLine("Continue Start Not stopped ")

        Form_Game.WebBrowser_Game_Ridevbot.Select()
        'AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)

        Var.Client_Screen = Var.Update_Screen()

        Dim Connection_Lost As Point = Var.Client_Screen.Contains(Var.Disconnected)
        If Connection_Lost <> Nothing Then
            Console.WriteLine("Continue Start > reconnect")
            reconnect()
            Exit Function
        End If

        ' INCLURE DEAD 

        Console.WriteLine("Continue Start > connected <")

        ' A REMPLACER PAR UN DETECTION AUTOMATIQUE DE L'EMPLACEMENT DE LA MINI MAP
        Dim Save_point_original As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original.X = "762" Then

            Console.WriteLine("Continue Start > Base du bot > 762_OK")
            Baseofbot()
        Else
            Console.WriteLine("Continue Start > Minimap Load > ")
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

        Console.WriteLine("reconnect Not stopped ")

        Var.Client_Screen = Var.Update_Screen()
        Dim Connection_Lost As Point = Var.Client_Screen.Contains(Var.Disconnected)

        If Connection_Lost <> Nothing Then

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 300, 354)
            Console.WriteLine("Reconnexion...")
            Await Task.Delay(7000)

            Var.Client_Screen = Var.Update_Screen()
            Dim deconnection_popup As Point = Var.Client_Screen.Contains(Var.deconnection_popup_visible)

            If deconnection_popup <> Nothing Then
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 409, 348)
                Console.WriteLine("Fermeture de la Pop up de deconnexion > TRUE <")
                Await Task.Delay(1000)
                Start()
            Else
                'Probablmeent qu'on nest mort, on relance le start
                Start() ' ERREUR PROBABLE ICI ???
            End If

        Else
            Console.WriteLine("Reconnexion introuvable")
            Stopped()
        End If

    End Function ' Se reconnecter >> [¿¿¿]

    Public Shared Async Function Minimap_load() As Task

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        'AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
        Form_Tools.TextBox_desactive_allkey.Refresh()
        Form_tools.TextBox_desactive_allkey.Update()
        AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_tools.TextBox_desactive_allkey.Text))
        Await Task.Delay(1000)
        Var.Client_Screen = Var.Update_Screen()
        Dim Minimap_closed As Point = Var.Client_Screen.Contains(Var.Minimap_closed_ref)
        If Minimap_closed <> Nothing Then

            Form_Game.WebBrowser_Game_Ridevbot.Select()
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_closed.X, Minimap_closed.Y + 18)
            Await Task.Delay(1000)
            Console.WriteLine("Minimap Ouverte")
            Minimap_resize()

        Else
            Start()
            Exit Function
        End If

    End Function ' Load
    Public Shared Async Function Minimap_resize() As Task

        Var.Client_Screen = Var.Update_Screen()
        Dim Minimap_size As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        Dim compare As Point

        If Minimap_size <> Nothing Then

            For i = 0 To 15
                Await Task.Delay(60)
                Var.Client_Screen = Var.Update_Screen()
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
        Var.Client_Screen = Var.Update_Screen()
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
            Baseofbot()
        Else
            Start()
        End If

    End Function ' Movement >> [¿¿¿]

#End Region ' 1 Suggestion ! On lance le bot et sa regle la minimap 

    Public Shared Async Function Baseofbot() As Task

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        Console.WriteLine("Continue Baseofbot Not stopped ")

        Console.WriteLine("Continue to Checking map actuel")
        Await Checking_map_actuel()

        Console.WriteLine("Refreshing map to travel")
        Form_tools.ComboBox_map_to_travel.Refresh()
        Console.WriteLine("Launching traveling module")
        Traveling_module()

    End Function ' retourne true a la minimap et se prepare pour le traveling
    Public Shared Function Checking_map_actuel() As Task

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        Var.UpdateMapLocations()
        Console.WriteLine("Updated map locations")
        Var.Update_Screen()
        Console.WriteLine("Updated Client Screen")

        If Var.Map_Location1_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-1"
        ElseIf Var.Map_Location1_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-2"
        ElseIf Var.Map_Location1_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-3"
        ElseIf Var.Map_Location1_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-4"
        ElseIf Var.Map_Location1_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-5"
        ElseIf Var.Map_Location1_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-6"
        ElseIf Var.Map_Location1_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-7"
        ElseIf Var.Map_Location1_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-8"
        ElseIf Var.Map_Location2_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-1"
        ElseIf Var.Map_Location2_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-2"
        ElseIf Var.Map_Location2_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-3"
        ElseIf Var.Map_Location2_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-4"
        ElseIf Var.Map_Location2_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-5"
        ElseIf Var.Map_Location2_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-6"
        ElseIf Var.Map_Location2_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-7"
        ElseIf Var.Map_Location2_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-8"
        ElseIf Var.Map_Location3_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-1"
        ElseIf Var.Map_Location3_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-2"
        ElseIf Var.Map_Location3_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-3"
        ElseIf Var.Map_Location3_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-4"
        ElseIf Var.Map_Location3_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-5"
        ElseIf Var.Map_Location3_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-6"
        ElseIf Var.Map_Location3_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-7"
        ElseIf Var.Map_Location3_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-8"
        ElseIf Var.Map_Location4_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-1"
        ElseIf Var.Map_Location4_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-2"
        ElseIf Var.Map_Location4_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-3"
        ElseIf Var.Map_Location4_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-4"
        ElseIf Var.Map_Location4_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-5"
        ElseIf Var.Map_Location5_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-1"
        ElseIf Var.Map_Location5_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-2"
        ElseIf Var.Map_Location5_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-3"
        ElseIf Var.Map_Location1_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1BL"
        ElseIf Var.Map_Location2_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2BL"
        ElseIf Var.Map_Location3_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3BL"
        End If

        Console.WriteLine("On a défini la map actuelle")
        ' ERREUR ICI 
        Var.CurrentMapUser = Form_Game.Label_map_location.Text.Split(" : ")(2)
        Form_Game.Label_map_location.Update()
        Var.Update_Screen()
        'Console.WriteLine("On a récupéré la map : " + Val(Var.CurrentMapUser))
        Dim Save_point_original_point As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original_point <> Nothing Then
            Console.WriteLine("contient")
        Else
            Console.WriteLine("contient PAS")
        End If

        Return Task.CompletedTask

    End Function ' checking map actuel ( ne produit pas de valeur juste un refresh du stats )
    Public Shared Async Function Traveling_module() As Task

        If Var.User_Stop_Bot Then
            Stopped()
            Exit Function
        End If

        Console.WriteLine("Traveling_module Started ")

        Var.Update_Screen()

        Dim Connection_Lost As Point = Var.Client_Screen.Contains(Var.Disconnected)
        If Connection_Lost <> Nothing Then
            reconnect()
            Console.WriteLine("Reconnexion en cours")
            Exit Function
        End If


        Dim Save_point_original As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original.X = "762" Then
            Console.WriteLine("Minimap au bon endroit")
        Else
            Start()
            Console.WriteLine("Minimap pas placé correctement, on relance")
            Exit Function
        End If

        Dim Map_actuelle = Form_Game.Label_map_location.Text.Split(" : ")(2)
        Dim Map_roaming = Form_Tools.ComboBox_map_to_travel.Text

        Console.WriteLine(Map_actuelle)
        Console.WriteLine(Map_roaming)
        Console.WriteLine("Calcul de l'itinéraire")

        Var.Update_Screen()

        If Map_actuelle <> Map_roaming Then

#Region "MAP = 1-8 ---------- "
            If Map_actuelle = "1-8" And
                            Map_roaming = "1-6" Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "1-8" And
                            (Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL") Then
                Var.PORTAIL_1BL_MMO()

            ElseIf Map_actuelle = "1-8" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 1-7 ---------- "
            ElseIf Map_actuelle = "1-7" And
                            (Map_roaming = "1-6" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL") Then

                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "1-7" And
                        (Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "2-6" Or
                        Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "3-1" Or
                        Map_roaming = "3-2" Or
                        Map_roaming = "3-3" Or
                        Map_roaming = "3-4" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "3-6" Or
                        Map_roaming = "3-7" Or
                        Map_roaming = "3-8" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "4-1" Or
                        Map_roaming = "4-2" Or
                        Map_roaming = "4-3" Or
                        Map_roaming = "4-4" Or
                        Map_roaming = "4-5") Then

                Var.PORTAIL_HAUT_DROITE()
#End Region ' VALIDER
#Region "MAP = 1-6 ---------- "
            ElseIf Map_actuelle = "1-6" And
                        (Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "1-BL" Or
                        Map_roaming = "2-BL" Or
                        Map_roaming = "3-BL") Then

                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "1-6" And
                        (Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "2-6" Or
                        Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "3-1" Or
                        Map_roaming = "3-2" Or
                        Map_roaming = "3-3" Or
                        Map_roaming = "3-4" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "3-6" Or
                        Map_roaming = "3-7" Or
                        Map_roaming = "3-8" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "4-1" Or
                        Map_roaming = "4-2" Or
                        Map_roaming = "4-3" Or
                        Map_roaming = "4-4" Or
                        Map_roaming = "4-5") Then

                Var.PORTAIL_BAS_DROITE()
#End Region ' VALIDER
#Region "MAP = 1-5 ---------- "
            ElseIf Map_actuelle = "1-5" And
                        (Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "1-BL" Or
                        Map_roaming = "2-BL" Or
                        Map_roaming = "3-BL") Then

                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "1-5" And Map_roaming = "1-6" Then

                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "1-5" And
                       (Map_roaming = "4-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "3-5") Then

                Var.PORTAIL_45_MMO()

            ElseIf Map_actuelle = "1-5" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4") Then

                Var.PORTAIL_15_TO_44()
#End Region ' VALIDER
#Region "MAP = 2-8 ---------- "

            ElseIf Map_actuelle = "2-8" And Map_roaming = "2-6" Then
                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "2-8" And
                                (Map_roaming = "2-BL" Or
                                Map_roaming = "3-BL" Or
                                Map_roaming = "1-BL") Then
                Var.PORTAIL_2BL_EIC()

            ElseIf Map_actuelle = "2-8" And
                                (Map_roaming = "1-1" Or
                                Map_roaming = "1-2" Or
                                Map_roaming = "1-3" Or
                                Map_roaming = "1-4" Or
                                Map_roaming = "1-5" Or
                                Map_roaming = "1-6" Or
                                Map_roaming = "1-7" Or
                                Map_roaming = "1-8" Or
                                Map_roaming = "2-1" Or
                                Map_roaming = "2-2" Or
                                Map_roaming = "2-3" Or
                                Map_roaming = "2-4" Or
                                Map_roaming = "2-5" Or
                                Map_roaming = "2-7" Or
                                Map_roaming = "3-1" Or
                                Map_roaming = "3-2" Or
                                Map_roaming = "3-3" Or
                                Map_roaming = "3-4" Or
                                Map_roaming = "3-5" Or
                                Map_roaming = "3-6" Or
                                Map_roaming = "3-7" Or
                                Map_roaming = "3-8" Or
                                Map_roaming = "5-1" Or
                                Map_roaming = "5-2" Or
                                Map_roaming = "5-3" Or
                                Map_roaming = "4-1" Or
                                Map_roaming = "4-2" Or
                                Map_roaming = "4-3" Or
                                Map_roaming = "4-4" Or
                                Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 2-7 ---------- "

            ElseIf Map_actuelle = "2-7" And
                    (Map_roaming = "2-6" Or
                    Map_roaming = "2-8" Or
                    Map_roaming = "2-BL" Or
                    Map_roaming = "3-BL" Or
                    Map_roaming = "1-BL") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "2-7" And
                        (Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "1-6" Or
                        Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "3-1" Or
                        Map_roaming = "3-2" Or
                        Map_roaming = "3-3" Or
                        Map_roaming = "3-4" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "3-6" Or
                        Map_roaming = "3-7" Or
                        Map_roaming = "3-8" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "4-1" Or
                        Map_roaming = "4-2" Or
                        Map_roaming = "4-3" Or
                        Map_roaming = "4-4" Or
                        Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 2-6 ---------- "

            ElseIf Map_actuelle = "2-6" And
                            (Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "1-BL") Then

                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "2-6" And
                        (Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "1-6" Or
                        Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "3-1" Or
                        Map_roaming = "3-2" Or
                        Map_roaming = "3-3" Or
                        Map_roaming = "3-4" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "3-6" Or
                        Map_roaming = "3-7" Or
                        Map_roaming = "3-8" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "4-1" Or
                        Map_roaming = "4-2" Or
                        Map_roaming = "4-3" Or
                        Map_roaming = "4-4" Or
                        Map_roaming = "4-5") Then

                Var.PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 2-5 ---------- "

            ElseIf Map_actuelle = "2-5" And
                       (Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "2-BL" Or
                        Map_roaming = "3-BL" Or
                        Map_roaming = "1-BL") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "2-5" And Map_roaming = "2-6" Then
                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "2-5" And
                       (Map_roaming = "4-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "1-5") Then
                Var.PORTAIL_45_EIC()

            ElseIf Map_actuelle = "2-5" And
                           (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4") Then
                Var.PORTAIL_25_TO_44()

#End Region ' VALIDER
#Region "MAP = 3-8 ---------- "
            ElseIf Map_actuelle = "3-8" And Map_roaming = "3-6" Then
                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "3-8" And
                            (Map_roaming = "3-BL" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL") Then
                Var.PORTAIL_3BL_VRU()

            ElseIf Map_actuelle = "3-8" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then

                Var.PORTAIL_HAUT_GAUCHE()
#End Region ' VALIDER
#Region "MAP = 3-7 ---------- "

            ElseIf Map_actuelle = "3-7" And
                    (Map_roaming = "3-6" Or
                    Map_roaming = "3-8" Or
                    Map_roaming = "3-BL" Or
                    Map_roaming = "1-BL" Or
                    Map_roaming = "2-BL") Then
                Var.PORTAIL_BAS_DROITE()

            ElseIf Map_actuelle = "3-7" And
                        (Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "1-6" Or
                        Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "2-6" Or
                        Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "3-1" Or
                        Map_roaming = "3-2" Or
                        Map_roaming = "3-3" Or
                        Map_roaming = "3-4" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "4-1" Or
                        Map_roaming = "4-2" Or
                        Map_roaming = "4-3" Or
                        Map_roaming = "4-4" Or
                        Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 3-6 ---------- "

            ElseIf Map_actuelle = "3-6" And
                 (Map_roaming = "3-7" Or
                 Map_roaming = "3-8" Or
                 Map_roaming = "3-BL" Or
                 Map_roaming = "1-BL" Or
                 Map_roaming = "2-BL") Then
                Var.PORTAIL_BAS_DROITE()

            ElseIf Map_actuelle = "3-6" And
                        (Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "1-6" Or
                        Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "2-6" Or
                        Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "3-1" Or
                        Map_roaming = "3-2" Or
                        Map_roaming = "3-3" Or
                        Map_roaming = "3-4" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "4-1" Or
                        Map_roaming = "4-2" Or
                        Map_roaming = "4-3" Or
                        Map_roaming = "4-4" Or
                        Map_roaming = "4-5") Then
                Var.PORTAIL_HAUT_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 3-5 ---------- "

            ElseIf Map_actuelle = "3-5" And
                       (Map_roaming = "3-7" Or
                       Map_roaming = "3-8" Or
                        Map_roaming = "3-BL" Or
                        Map_roaming = "1-BL" Or
                        Map_roaming = "2-BL") Then
                Var.PORTAIL_BAS_DROITE()

            ElseIf Map_actuelle = "3-5" And Map_roaming = "3-6" Then
                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "3-5" And
                       (Map_roaming = "4-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "2-5") Then
                Var.PORTAIL_45_VRU()

            ElseIf Map_actuelle = "3-5" And
                           (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4") Then
                Var.PORTAIL_35_TO_44()

#End Region ' VALIDER
#Region "MAP = 4-5 ---------- "

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "mmo" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                             Map_roaming = "4-1" Or
                             Map_roaming = "4-2" Or
                             Map_roaming = "4-3" Or
                             Map_roaming = "4-4" Or
                             Map_roaming = "1-BL") Then
                Var.PORTAIL_45_to_15()

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "eic" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                             Map_roaming = "4-2" Or
                             Map_roaming = "4-3" Or
                             Map_roaming = "4-1" Or
                             Map_roaming = "4-4" Or
                             Map_roaming = "2-BL") Then
                Var.PORTAIL_45_to_25()

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "vru" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "3-BL") Then
                Var.PORTAIL_45_to_35()

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "mmo" And
                            (Map_roaming = "5-1") Then
                Var.PORTAIL_45_to_51_MMO()

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "eic" And
                            (Map_roaming = "5-1") Then
                Var.PORTAIL_45_to_51_EIC()

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "vru" And
                            (Map_roaming = "5-1") Then
                Var.PORTAIL_45_to_51_VRU()

#End Region ' VALIDER
#Region "MAP = 4-4 ---------- "

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "1-BL") Then
                Var.PORTAIL_44_to_15()

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "2-BL") Then
                Var.PORTAIL_44_to_25()

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "3-BL") Then
                Var.PORTAIL_44_to_35()

                ' If mmo pour savoir par quel portail allez pour la 4-5

            ElseIf Map_actuelle = "4-4" And Stats_module.WebClient_GET_Ship_compagny_reg = "mmo" And
                            (Map_roaming = "4-5" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3") Then
                Var.PORTAIL_44_to_15()

            ElseIf Map_actuelle = "4-4" And Stats_module.WebClient_GET_Ship_compagny_reg = "eic" And
                            (Map_roaming = "4-5" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3") Then
                Var.PORTAIL_44_to_25()

            ElseIf Map_actuelle = "4-4" And Stats_module.WebClient_GET_Ship_compagny_reg = "vru" And
                            (Map_roaming = "4-5" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3") Then
                Var.PORTAIL_44_to_35()


            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "4-1" Or
                            Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4") Then
                Var.PORTAIL_44_to_41()

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "4-1" Or
                            Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4") Then
                Var.PORTAIL_44_to_42()

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "4-3" Or
                            Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4") Then
                Var.PORTAIL_44_to_43()


#End Region ' VALIDER
#Region "MAP = 4-3 ---------- "

            ElseIf Map_actuelle = "4-3" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4") Then
                Var.PORTAIL_43_to_34()

            ElseIf Map_actuelle = "4-3" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "4-1") Then
                Var.PORTAIL_43_to_41()

            ElseIf Map_actuelle = "4-3" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "4-2") Then
                Var.PORTAIL_43_to_42()

            ElseIf Map_actuelle = "4-3" And
                        (Map_roaming = "1-5" Or
                        Map_roaming = "1-6" Or
                        Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "2-6" Or
                        Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "3-6" Or
                        Map_roaming = "3-7" Or
                        Map_roaming = "3-8" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "4-5" Or
                        Map_roaming = "4-4") Then
                Var.PORTAIL_43_to_44()

#End Region ' VALIDER
#Region "MAP = 4-2 ---------- "

            ElseIf Map_actuelle = "4-2" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4") Then
                Var.PORTAIL_42_to_24()

            ElseIf Map_actuelle = "4-2" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "4-3") Then
                Var.PORTAIL_42_to_43()

            ElseIf Map_actuelle = "4-2" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "4-1") Then
                Var.PORTAIL_42_to_41()

            ElseIf Map_actuelle = "4-2" And
                            (Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "4-5" Or
                            Map_roaming = "4-4") Then
                Var.PORTAIL_42_to_44()

#End Region ' VALIDER
#Region "MAP = 4-1 ---------- "

            ElseIf Map_actuelle = "4-1" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4") Then
                Var.PORTAIL_41_to_14()

            ElseIf Map_actuelle = "4-1" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "4-2") Then
                Var.PORTAIL_41_to_42()

            ElseIf Map_actuelle = "4-1" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4") Then
                Var.PORTAIL_41_to_43()

            ElseIf Map_actuelle = "4-1" And
                            (Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "4-5" Or
                            Map_roaming = "4-4") Then

                Var.PORTAIL_41_to_44()

#End Region ' VALIDER
#Region "MAP = 1-4 ---------- "

            ElseIf Map_actuelle = "1-4" And
                            (Map_roaming = "1-2" Or
                            Map_roaming = "1-1") Then
                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "1-4" And
                        (Map_roaming = "1-3" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "1-4" And
                                 (Map_roaming = "3-1" Or
                                 Map_roaming = "3-2" Or
                                 Map_roaming = "3-3" Or
                                 Map_roaming = "3-4") Then
                Var.PORTAIL_BAS_DROITE()

            ElseIf Map_actuelle = "1-4" And
                            (Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_14_to_41()
#End Region ' VALIDER
#Region "MAP = 1-3 ---------- "

            ElseIf Map_actuelle = "1-3" And
                        (Map_roaming = "1-2" Or
                        Map_roaming = "1-1") Then
                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "1-3" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "1-3" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 1-2 ---------- "

            ElseIf Map_actuelle = "1-2" And
                        (Map_roaming = "1-3" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "1-2" And
                        (Map_roaming = "1-1") Then
                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "1-2" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_DROITE()


#End Region ' VALIDER
#Region "MAP = 1-1 ---------- "

            ElseIf Map_actuelle = "1-1" Then
                Var.PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 2-4 ---------- "

            ElseIf Map_actuelle = "2-4" And
                            (Map_roaming = "2-2" Or
                            Map_roaming = "2-1") Then
                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "2-4" And
                    (Map_roaming = "2-3" Or
                    Map_roaming = "1-1" Or
                    Map_roaming = "1-2" Or
                    Map_roaming = "1-3" Or
                    Map_roaming = "1-4") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "2-4" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4") Then
                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "2-4" And
                            (Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_24_to_42()
#End Region ' VALIDER
#Region "MAP = 2-3 ---------- "

            ElseIf Map_actuelle = "2-3" And
                                      (Map_roaming = "2-2" Or
                                      Map_roaming = "2-1") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "2-3" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4") Then
                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "2-3" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 2-2 ---------- "

            ElseIf Map_actuelle = "2-2" And
                        (Map_roaming = "2-3" Or
                        Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4") Then
                Var.PORTAIL_BAS_GAUCHE()

            ElseIf Map_actuelle = "2-2" And
                        (Map_roaming = "2-1") Then
                Var.PORTAIL_HAUT_DROITE()


            ElseIf Map_actuelle = "2-2" And
                        (Map_roaming = "3-1" Or
                        Map_roaming = "3-2" Or
                        Map_roaming = "3-3" Or
                        Map_roaming = "3-4" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "3-6" Or
                        Map_roaming = "3-7" Or
                        Map_roaming = "3-8" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "2-6" Or
                        Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "1-6" Or
                        Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "1-BL" Or
                        Map_roaming = "2-BL" Or
                        Map_roaming = "3-BL" Or
                        Map_roaming = "2-4" Or
                        Map_roaming = "4-1" Or
                        Map_roaming = "4-2" Or
                        Map_roaming = "4-3" Or
                        Map_roaming = "4-4" Or
                        Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 2-1 ---------- "

            ElseIf Map_actuelle = "2-1" Then
                Var.PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 3-4 ---------- "

            ElseIf Map_actuelle = "3-4" And
                                        (Map_roaming = "3-2" Or
                                        Map_roaming = "3-1") Then
                Var.PORTAIL_BAS_DROITE()

            ElseIf Map_actuelle = "3-4" And
                                  (Map_roaming = "3-3" Or
                                    Map_roaming = "2-1" Or
                                    Map_roaming = "2-2" Or
                                    Map_roaming = "2-3" Or
                                    Map_roaming = "2-4") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "3-4" And
                             (Map_roaming = "1-1" Or
                             Map_roaming = "1-2" Or
                             Map_roaming = "1-3" Or
                             Map_roaming = "1-4") Then
                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "3-4" And
                            (Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_34_to_43()
#End Region ' VALIDER
#Region "MAP = 3-3 ---------- "

            ElseIf Map_actuelle = "3-3" And
                          (Map_roaming = "3-2" Or
                          Map_roaming = "3-1") Then
                Var.PORTAIL_BAS_DROITE()

            ElseIf Map_actuelle = "3-3" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4") Then
                Var.PORTAIL_HAUT_GAUCHE()

            ElseIf Map_actuelle = "3-3" And
                            (Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 3-2 ---------- "

            ElseIf Map_actuelle = "3-2" And
                        (Map_roaming = "3-3" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4") Then
                Var.PORTAIL_HAUT_DROITE()

            ElseIf Map_actuelle = "3-2" And
                        Map_roaming = "3-1" Then
                Var.PORTAIL_BAS_DROITE()

            ElseIf Map_actuelle = "3-2" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "4-1" Or
                            Map_roaming = "4-2" Or
                            Map_roaming = "4-3" Or
                            Map_roaming = "4-4" Or
                            Map_roaming = "4-5") Then
                Var.PORTAIL_HAUT_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 3-1 ---------- "

            ElseIf Map_actuelle = "3-1" Then
                Var.PORTAIL_HAUT_GAUCHE()

#End Region ' VALIDER

            Else
                'On ne trouve pas la map à aller ?
                Await Task.Delay(10000)
                Console.WriteLine("On relance Traveling Module")
                Traveling_module()
            End If

        Else

            Console.WriteLine("Vous etes arrive a destination")
            Traveling_succes()
        End If


    End Function ' effectue le traveling vers une map selectionner 


    Public Shared Function Traveling_succes() As Task
        Console.WriteLine("Success")


    End Function

End Class
