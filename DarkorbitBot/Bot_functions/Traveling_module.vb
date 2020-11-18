Public Class Traveling_module

    Public Shared Gates_in_times As String
    Public Shared Gates_process As String
    Public Shared Function Load() As Task

        If Var.User_Stop_Bot Then Exit Function

        Console.WriteLine("Traveling_module Started ")
        Var.Update_Screen()

        Dim Map_actuelle = Form_Game.Label_map_location.Text.Split(" : ")(2)
        Dim Map_roaming = Form_Tools.ComboBox_map_to_travel.Text

        Console.WriteLine(Map_actuelle)
        Console.WriteLine(Map_roaming)
        Console.WriteLine("Calcul de l'itinéraire")

        If Map_actuelle <> Map_roaming Then

            Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_fleeing.Text))

#Region "MAP = GATES ---------- "

            If Map_roaming = "Gates" Then
                Gates_in_times = 1

                If Stats_module.WebClient_GET_Ship_compagny_reg = "mmo" Then
                    Form_Tools.ComboBox_map_to_travel.Text = "1-1"

                ElseIf Stats_module.WebClient_GET_Ship_compagny_reg = "eic" Then
                    Form_Tools.ComboBox_map_to_travel.Text = "2-1"

                ElseIf Stats_module.WebClient_GET_Ship_compagny_reg = "vru" Then
                    Form_Tools.ComboBox_map_to_travel.Text = "3-1"

                Else
                    Console.WriteLine("Error : Le bot n'a pas pu lire la carte ou la firme set/reload ")
                End If
            End If

#End Region ' VALIDER
#Region "MAP = 1-8 ---------- "
            If Map_actuelle = "1-8" And
                            Map_roaming = "1-6" Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "1-8" And
                            (Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL") Then
                Var.Goto_Next_portal(691, 556) ' 1BL MMO

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
                Var.Goto_Next_portal(760, 585) ' Bas Droite

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 1-7 ---------- "
            ElseIf Map_actuelle = "1-7" And
                            (Map_roaming = "1-6" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL") Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

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
                Var.Goto_Next_portal(760, 497) ' Haut Droite

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 1-6 ---------- "
            ElseIf Map_actuelle = "1-6" And
                        (Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "1-BL" Or
                        Map_roaming = "2-BL" Or
                        Map_roaming = "3-BL") Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

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
                Var.Goto_Next_portal(760, 585) ' Bas Droite

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 1-5 ---------- "
            ElseIf Map_actuelle = "1-5" And
                        (Map_roaming = "1-7" Or
                        Map_roaming = "1-8" Or
                        Map_roaming = "1-BL" Or
                        Map_roaming = "2-BL" Or
                        Map_roaming = "3-BL") Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

            ElseIf Map_actuelle = "1-5" And Map_roaming = "1-6" Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

            ElseIf Map_actuelle = "1-5" And
                       (Map_roaming = "4-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "2-5" Or
                        Map_roaming = "3-5") Then

                Var.Goto_Next_portal(764, 534) ' 1-5 > 4-5 

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
                Var.Goto_Next_portal(764, 517) ' 1-5 > 4-4

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 2-8 ---------- "

            ElseIf Map_actuelle = "2-8" And Map_roaming = "2-6" Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

            ElseIf Map_actuelle = "2-8" And
                                (Map_roaming = "2-BL" Or
                                Map_roaming = "3-BL" Or
                                Map_roaming = "1-BL") Then
                Var.Goto_Next_portal(692, 563) ' 2BL EIC

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
                Var.Goto_Next_portal(760, 585) ' Bas Droite

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 2-7 ---------- "

            ElseIf Map_actuelle = "2-7" And
                    (Map_roaming = "2-6" Or
                    Map_roaming = "2-8" Or
                    Map_roaming = "2-BL" Or
                    Map_roaming = "3-BL" Or
                    Map_roaming = "1-BL") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

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
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 2-6 ---------- "

            ElseIf Map_actuelle = "2-6" And
                            (Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "2-BL" Or
                            Map_roaming = "3-BL" Or
                            Map_roaming = "1-BL") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

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
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 2-5 ---------- "

            ElseIf Map_actuelle = "2-5" And
                       (Map_roaming = "2-7" Or
                        Map_roaming = "2-8" Or
                        Map_roaming = "2-BL" Or
                        Map_roaming = "3-BL" Or
                        Map_roaming = "1-BL") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "2-5" And Map_roaming = "2-6" Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

            ElseIf Map_actuelle = "2-5" And
                       (Map_roaming = "4-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "1-5") Then
                Var.Goto_Next_portal(760, 584) ' 2.5 > 4.5

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
                Var.Goto_Next_portal(610, 569) ' 2.5 > 4.4

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 3-8 ---------- "
            ElseIf Map_actuelle = "3-8" And Map_roaming = "3-6" Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

            ElseIf Map_actuelle = "3-8" And
                            (Map_roaming = "3-BL" Or
                            Map_roaming = "1-BL" Or
                            Map_roaming = "2-BL") Then
                Var.Goto_Next_portal(692, 562) ' 3BL vru

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
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 3-7 ---------- "

            ElseIf Map_actuelle = "3-7" And
                    (Map_roaming = "3-6" Or
                    Map_roaming = "3-8" Or
                    Map_roaming = "3-BL" Or
                    Map_roaming = "1-BL" Or
                    Map_roaming = "2-BL") Then
                Var.Goto_Next_portal(760, 585) ' Bas Droite

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
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 3-6 ---------- "

            ElseIf Map_actuelle = "3-6" And
                 (Map_roaming = "3-7" Or
                 Map_roaming = "3-8" Or
                 Map_roaming = "3-BL" Or
                 Map_roaming = "1-BL" Or
                 Map_roaming = "2-BL") Then
                Var.Goto_Next_portal(760, 585) ' Bas Droite

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
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 3-5 ---------- "

            ElseIf Map_actuelle = "3-5" And
                       (Map_roaming = "3-7" Or
                       Map_roaming = "3-8" Or
                        Map_roaming = "3-BL" Or
                        Map_roaming = "1-BL" Or
                        Map_roaming = "2-BL") Then
                Var.Goto_Next_portal(760, 585) ' Bas Droite

            ElseIf Map_actuelle = "3-5" And Map_roaming = "3-6" Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

            ElseIf Map_actuelle = "3-5" And
                       (Map_roaming = "4-5" Or
                        Map_roaming = "5-1" Or
                        Map_roaming = "5-2" Or
                        Map_roaming = "5-3" Or
                        Map_roaming = "3-5" Or
                        Map_roaming = "1-5" Or
                        Map_roaming = "2-5") Then
                Var.Goto_Next_portal(745, 493) ' 3.5 > 4.5


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
                Var.Goto_Next_portal(610, 478) ' 3.5 > 4.4

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 4-5 ---------- "

            ElseIf Map_actuelle = "4-5" And
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
                Var.Goto_Next_portal(623, 540) ' 4.5 > 1.5 mmo

            ElseIf Map_actuelle = "4-5" And
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
                Var.Goto_Next_portal(717, 463) ' 4.5 > 2.5 eic

            ElseIf Map_actuelle = "4-5" And
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
                Var.Goto_Next_portal(719, 596) ' 4.5 > 3.5 vru

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "mmo" And
                            (Map_roaming = "5-1" Or
                             Map_roaming = "5-2" Or
                             Map_roaming = "5-3") Then
                Var.Goto_Next_portal(647, 540) ' 4.5 > 5-1 mmo

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "eic" And
                            (Map_roaming = "5-1" Or
                             Map_roaming = "5-2" Or
                             Map_roaming = "5-3") Then
                Var.Goto_Next_portal(705, 508) ' 4.5 > 5-1 eic

            ElseIf Map_actuelle = "4-5" And Stats_module.WebClient_GET_Ship_compagny_reg = "vru" And
                            (Map_roaming = "5-1" Or
                             Map_roaming = "5-2" Or
                             Map_roaming = "5-3") Then
                Var.Goto_Next_portal(703, 550) ' 4.5 > 5-1 vru

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 4-4 ---------- "

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "1-5" Or
                            Map_roaming = "1-6" Or
                            Map_roaming = "1-7" Or
                            Map_roaming = "1-8" Or
                            Map_roaming = "1-BL") Then
                Var.Goto_Next_portal(623, 540) ' 4.4 > 1.5 mmo

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "2-5" Or
                            Map_roaming = "2-6" Or
                            Map_roaming = "2-7" Or
                            Map_roaming = "2-8" Or
                            Map_roaming = "2-BL") Then
                Var.Goto_Next_portal(719, 485) ' 4.4 > 2.5 eic

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "3-5" Or
                            Map_roaming = "3-6" Or
                            Map_roaming = "3-7" Or
                            Map_roaming = "3-8" Or
                            Map_roaming = "3-BL") Then
                Var.Goto_Next_portal(719, 593) ' 4.4 > 3.5 vru

            ElseIf Map_actuelle = "4-4" And Stats_module.WebClient_GET_Ship_compagny_reg = "mmo" And
                            (Map_roaming = "4-5" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3") Then
                Var.Goto_Next_portal(623, 540) ' 4.4 > 1.5 + SP mmo

            ElseIf Map_actuelle = "4-4" And Stats_module.WebClient_GET_Ship_compagny_reg = "eic" And
                            (Map_roaming = "4-5" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3") Then
                Var.Goto_Next_portal(719, 485) ' 4.4 > 2.5 + SP eic

            ElseIf Map_actuelle = "4-4" And Stats_module.WebClient_GET_Ship_compagny_reg = "vru" And
                            (Map_roaming = "4-5" Or
                            Map_roaming = "5-1" Or
                            Map_roaming = "5-2" Or
                            Map_roaming = "5-3") Then
                Var.Goto_Next_portal(719, 593) ' 4.4 > 3.5 + SP vru


            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "4-1" Or
                            Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4") Then
                Var.Goto_Next_portal(679, 540) ' 4.4 > 4.1

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "4-2" Or
                            Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4") Then
                Var.Goto_Next_portal(691, 533) ' 4.4 > 4.2

            ElseIf Map_actuelle = "4-4" And
                            (Map_roaming = "4-3" Or
                            Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4") Then
                Var.Goto_Next_portal(691, 545) ' 4.4 > 4.3


#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 4-3 ---------- "

            ElseIf Map_actuelle = "4-3" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4") Then
                Var.Goto_Next_portal(764, 516) ' 4.3 > 3.4

            ElseIf Map_actuelle = "4-3" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "4-1") Then
                Var.Goto_Next_portal(610, 566) ' 4.3 > 4.1

            ElseIf Map_actuelle = "4-3" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "4-2") Then
                Var.Goto_Next_portal(610, 479) ' 4.3 > 4.2

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
                Var.Goto_Next_portal(685, 717) ' 4.3 > 4.4

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 4-2 ---------- "

            ElseIf Map_actuelle = "4-2" And
                        (Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4") Then
                Var.Goto_Next_portal(683, 475) ' 4.2 > 2.4

            ElseIf Map_actuelle = "4-2" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "4-3") Then
                Var.Goto_Next_portal(764, 516) ' 4.2 > 4.3

            ElseIf Map_actuelle = "4-2" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4" Or
                            Map_roaming = "4-1") Then
                Var.Goto_Next_portal(610, 566) ' 4.2 > 4.1

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
                Var.Goto_Next_portal(687, 522) ' 4.2 > 4.4

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 4-1 ---------- "

            ElseIf Map_actuelle = "4-1" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4") Then
                Var.Goto_Next_portal(606, 516) ' 4.1 > 1.4

            ElseIf Map_actuelle = "4-1" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4" Or
                            Map_roaming = "4-2") Then
                Var.Goto_Next_portal(760, 479) ' 4.1 > 4.2

            ElseIf Map_actuelle = "4-1" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4" Or
                            Map_roaming = "4-3") Then
                Var.Goto_Next_portal(760, 566) ' 4.1 > 4.3

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
                Var.Goto_Next_portal(687, 522) ' 4.1 > 4.4

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 1-4 ---------- "

            ElseIf Map_actuelle = "1-4" And
                            (Map_roaming = "1-2" Or
                            Map_roaming = "1-1") Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

            ElseIf Map_actuelle = "1-4" And
                        (Map_roaming = "1-3" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "1-4" And
                                 (Map_roaming = "3-1" Or
                                 Map_roaming = "3-2" Or
                                 Map_roaming = "3-3" Or
                                 Map_roaming = "3-4") Then
                Var.Goto_Next_portal(760, 585) ' Bas Droite

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
                Var.Goto_Next_portal(764, 517) ' 1.4 > 4.1

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 1-3 ---------- "

            ElseIf Map_actuelle = "1-3" And
                        (Map_roaming = "1-2" Or
                        Map_roaming = "1-1") Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

            ElseIf Map_actuelle = "1-3" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

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
                Var.Goto_Next_portal(760, 585) ' Bas Droite

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 1-2 ---------- "

            ElseIf Map_actuelle = "1-2" And
                        (Map_roaming = "1-3" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "1-2" And
                        (Map_roaming = "1-1") Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

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
                Var.Goto_Next_portal(760, 585) ' Bas Droite


#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 1-1 ---------- "

            ElseIf Map_actuelle = "1-1" Then
                If Gates_in_times = 1 Then
                    Gates_in_times = 0

                    If Form_Tools.CheckBox_kappa_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_zeta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_gamma_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_delta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_beta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_epsilon_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_alpha_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_lambda_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_hades_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_kuiper_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_chronos_gates_module.Checked = True Then

                    End If

                Else Var.Goto_Next_portal(760, 585) ' Bas Droite
                End If

#End Region ' VALIDATION EN COURS
#Region "MAP = 2-4 ---------- "

            ElseIf Map_actuelle = "2-4" And
                            (Map_roaming = "2-2" Or
                            Map_roaming = "2-1") Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

            ElseIf Map_actuelle = "2-4" And
                    (Map_roaming = "2-3" Or
                    Map_roaming = "1-1" Or
                    Map_roaming = "1-2" Or
                    Map_roaming = "1-3" Or
                    Map_roaming = "1-4") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "2-4" And
                            (Map_roaming = "3-1" Or
                            Map_roaming = "3-2" Or
                            Map_roaming = "3-3" Or
                            Map_roaming = "3-4") Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

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
                Var.Goto_Next_portal(683, 570) ' 2.4 > 4.2

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 2-3 ---------- "

            ElseIf Map_actuelle = "2-3" And
                                      (Map_roaming = "2-2" Or
                                      Map_roaming = "2-1") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "2-3" And
                            (Map_roaming = "1-1" Or
                            Map_roaming = "1-2" Or
                            Map_roaming = "1-3" Or
                            Map_roaming = "1-4") Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

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
                Var.Goto_Next_portal(760, 585) ' Bas Droite

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 2-2 ---------- "

            ElseIf Map_actuelle = "2-2" And
                        (Map_roaming = "2-3" Or
                        Map_roaming = "1-1" Or
                        Map_roaming = "1-2" Or
                        Map_roaming = "1-3" Or
                        Map_roaming = "1-4") Then
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

            ElseIf Map_actuelle = "2-2" And
                        (Map_roaming = "2-1") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite


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
                Var.Goto_Next_portal(760, 585) ' Bas Droite

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 2-1 ---------- "

            ElseIf Map_actuelle = "2-1" Then
                If Gates_in_times = 1 Then
                    Gates_in_times = 0

                    If Form_Tools.CheckBox_kappa_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_zeta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_gamma_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_delta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_beta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_epsilon_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_alpha_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_lambda_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_hades_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_kuiper_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_chronos_gates_module.Checked = True Then

                    End If

                Else Var.Goto_Next_portal(610, 584) ' Bas Gauche
                End If

#End Region ' VALIDATION EN COURS
#Region "MAP = 3-4 ---------- "

            ElseIf Map_actuelle = "3-4" And
                                        (Map_roaming = "3-2" Or
                                        Map_roaming = "3-1") Then
                Var.Goto_Next_portal(760, 585) ' Bas Droite

            ElseIf Map_actuelle = "3-4" And
                                  (Map_roaming = "3-3" Or
                                    Map_roaming = "2-1" Or
                                    Map_roaming = "2-2" Or
                                    Map_roaming = "2-3" Or
                                    Map_roaming = "2-4") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "3-4" And
                             (Map_roaming = "1-1" Or
                             Map_roaming = "1-2" Or
                             Map_roaming = "1-3" Or
                             Map_roaming = "1-4") Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

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
                Var.Goto_Next_portal(683, 493) ' 3.4 > 4.3 
#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 3-3 ---------- "

            ElseIf Map_actuelle = "3-3" And
                          (Map_roaming = "3-2" Or
                          Map_roaming = "3-1") Then
                Var.Goto_Next_portal(760, 585) ' Bas Droite

            ElseIf Map_actuelle = "3-3" And
                            (Map_roaming = "2-1" Or
                            Map_roaming = "2-2" Or
                            Map_roaming = "2-3" Or
                            Map_roaming = "2-4") Then
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

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
                Var.Goto_Next_portal(610, 584) ' Bas Gauche

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 3-2 ---------- "

            ElseIf Map_actuelle = "3-2" And
                        (Map_roaming = "3-3" Or
                        Map_roaming = "2-1" Or
                        Map_roaming = "2-2" Or
                        Map_roaming = "2-3" Or
                        Map_roaming = "2-4") Then
                Var.Goto_Next_portal(760, 497) ' Haut Droite

            ElseIf Map_actuelle = "3-2" And
                        Map_roaming = "3-1" Then
                Var.Goto_Next_portal(760, 585) ' Bas Droite

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
                Var.Goto_Next_portal(610, 497) ' Haut Gauche

#End Region ' VALIDER ( VALIDATION EN COURS TEST ) V2
#Region "MAP = 3-1 ---------- "

            ElseIf Map_actuelle = "3-1" Then
                If Gates_in_times = 1 Then
                    Gates_in_times = 0

                    If Form_Tools.CheckBox_kappa_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_zeta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_gamma_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_delta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_beta_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_epsilon_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_alpha_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_lambda_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_hades_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_kuiper_gates_module.Checked = True Then

                    ElseIf Form_Tools.CheckBox_chronos_gates_module.Checked = True Then

                    End If

                Else Var.Goto_Next_portal(610, 497) ' Haut Gauche
                End If
#End Region ' VALIDATION EN COURS

            Else
                Console.WriteLine("Traveling Terminated")

            End If

        Else

            Console.WriteLine("Traveling success get/set")
            Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_Attack.Text))
            Var.security_T_backup = 1
            Running.Start()
        End If

    End Function

End Class
