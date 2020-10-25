Public Class Traveling_module

    Public Shared Function Load() As Task

        If Var.User_Stop_Bot Then Exit Function

        Console.WriteLine("Traveling_module Started ")
        Var.Update_Screen()

        Dim Map_actuelle = Form_Game.Label_map_location.Text.Split(" : ")(2)
        Dim Map_roaming = Form_tools.ComboBox_map_to_travel.Text

        Console.WriteLine(Map_actuelle)
        Console.WriteLine(Map_roaming)
        Console.WriteLine("Calcul de l'itinéraire")

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

            End If

        Else

            Console.WriteLine("Traveling success get/set")
            Var.security_T_backup = 1
            Running.Start()
        End If

    End Function

End Class
