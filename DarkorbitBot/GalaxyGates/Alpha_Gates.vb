﻿Imports System.Net
Imports System.Text.RegularExpressions

Public Class Alpha_Gates

    Public Shared Table_Load As String = """.*) \/>"
    Public Shared Control_killed_searching As Integer = 0
    Public Shared control_killed_selection As Integer
    Public Shared Current_npc As String

    Public Shared streuner_alpha As Integer = "370"
    Public Shared Lordakia_alpha As Integer = "370"
    Public Shared mordon_alpha As Integer = "385"
    Public Shared saimon_alpha As Integer = "385"
    Public Shared devolarium_alpha As Integer = "385"
    Public Shared kristallin_alpha As Integer = "410"
    Public Shared sibelon_alpha As Integer = "395"
    Public Shared sibelonit_alpha As Integer = "410"
    Public Shared kristallon_alpha As Integer = "410"
    Public Shared protegit_alpha As Integer = "410"

    Public Shared Distance_npc As Integer
    Public Shared pointer0 As Integer = "0"
    Public Shared pointer800 As Integer = "800"

    Public Shared control_selection As String

    Public Shared WebClient_GET_All_elements_currentWave As String
    Public Shared WebClient_GET_All_elements_currentstate As String

    Public Shared pointer_scan As Integer = "400"

    Public Shared Async Function Search_current_waves() As Task

        Form_Tools.WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information

Search_load:
        Dim WebClient_Data = Form_Tools.WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<gate (.*id=""1" + Table_Load).Groups.Item(1).ToString ' ALPHA

        WebClient_GET_All_elements_currentWave = Regex.Match(WebClient_GET_All_elements, "currentWave="".*?([\s\S]*?)""").Groups.Item(1).ToString
        WebClient_GET_All_elements_currentstate = Regex.Match(WebClient_GET_All_elements, "state="".*?([\s\S]*?)""").Groups.Item(1).ToString

        If WebClient_GET_All_elements_currentWave = "0" Or
             WebClient_GET_All_elements_currentWave = "1" Then
            Current_npc = "streuner"
            Distance_npc = streuner_alpha
            control_killed_selection = "3"

        ElseIf WebClient_GET_All_elements_currentWave = "4" Then
            Current_npc = "lordakia" ' df
            Distance_npc = Lordakia_alpha
            control_killed_selection = "5"

        ElseIf WebClient_GET_All_elements_currentWave = "8" Then
            Current_npc = "mordon"
            Distance_npc = mordon_alpha
            control_killed_selection = "8"

        ElseIf WebClient_GET_All_elements_currentWave = "12" Then
            Current_npc = "saimon" ' df
            Distance_npc = saimon_alpha
            control_killed_selection = "5"

        ElseIf WebClient_GET_All_elements_currentWave = "16" Then
            Current_npc = "devolarium"
            Distance_npc = devolarium_alpha
            control_killed_selection = "11"

        ElseIf WebClient_GET_All_elements_currentWave = "20" Then
            Current_npc = "kristallin"
            Distance_npc = kristallin_alpha
            control_killed_selection = "5"

        ElseIf WebClient_GET_All_elements_currentWave = "24" Then
            Current_npc = "sibelon"
            Distance_npc = sibelon_alpha
            control_killed_selection = "11"

        ElseIf WebClient_GET_All_elements_currentWave = "28" Then
            Current_npc = "sibelonit"
            Distance_npc = sibelonit_alpha
            control_killed_selection = "5"

        ElseIf WebClient_GET_All_elements_currentWave = "32" Then
            Current_npc = "kristallon"
            Distance_npc = kristallon_alpha
            control_killed_selection = "16"

        ElseIf WebClient_GET_All_elements_currentWave = "36" Or
            WebClient_GET_All_elements_currentWave = "40" Then
            Current_npc = "protegit" 'df
            Distance_npc = protegit_alpha
            control_killed_selection = "5"

        End If

        Console.WriteLine(" ")
        Console.WriteLine("Current Gate :")
        Console.WriteLine(WebClient_GET_All_elements)
        Console.WriteLine(" ")
        Console.WriteLine("Current state :")
        Console.WriteLine(WebClient_GET_All_elements_currentstate)
        Console.WriteLine(" ")
        Console.WriteLine("Current Waves :")
        Console.WriteLine(WebClient_GET_All_elements_currentWave)
        Console.WriteLine(" ")
        Console.WriteLine("Current Npc : ")
        Console.WriteLine(Current_npc)
        Console.WriteLine(" ")
        Console.WriteLine("Current distance of : ")
        Console.WriteLine(Distance_npc)
        Console.WriteLine(" ")
        Console.WriteLine("Current control selection killed : ")
        Console.WriteLine(control_killed_selection)
        Console.WriteLine(" ")

        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)

        If WebClient_GET_All_elements_currentstate = "in_progress" Then
        Else
            If Form_Tools.TextBox_end_gates.Text = "" Or
                Form_Tools.TextBox_end_gates.Text = " " Then
            Else
                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_end_gates.Text))
                Await Task.Delay(1000)
            End If
        End If

        Await Task.Delay(5000)

Base_macro:

        ' controle de la vie 
        ' controle du bouclier 

        ' essayer de controler les positions X et Y et interagir en consequence selon certain type de npc 

        Dim Npc_in_map = Var.AutoIt.PixelSearch(595, 465, 785, 595, 13369344, 0, 1)
        If Npc_in_map.ToString.Contains(Var.Student) Then

            Var.Update_Screen()
            Dim Npc_dans_le_coin_bas_droite = My.Resources.coin_bas_droite
            Dim Npc_dans_le_coin_haut_gauche = My.Resources.coin_haut_gauche
            Dim Coin_droite As Point = Var.Client_Screen.Contains(Npc_dans_le_coin_bas_droite)
            Dim Coin_gauche As Point = Var.Client_Screen.Contains(Npc_dans_le_coin_haut_gauche)

            Dim Npc_in_map_ref = Var.AutoIt.PixelSearch(605, 465, 766, 573, 13369344, 0, 1)
            If Npc_in_map_ref.ToString.Contains(Var.Student) Then
                control_selection = 1
            Else control_selection = 0
            End If

            If Coin_droite <> Nothing Then
                If control_selection = 1 Then
                    Console.WriteLine("Npc found before1")
                    Console.WriteLine("coin droite")
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc_in_map_ref(0), Npc_in_map_ref(1) - 17)
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Await Task.Delay(500)
                Else
                    Console.WriteLine("coin droite")
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Coin_droite.X, Coin_droite.Y)
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Await Task.Delay(500)
                End If

            ElseIf Coin_gauche <> Nothing Then
                If control_selection = 1 Then
                    Console.WriteLine("Npc found before2")
                    Console.WriteLine("Coin gauche")
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc_in_map_ref(0), Npc_in_map_ref(1) - 17)
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Await Task.Delay(500)
                Else
                    Console.WriteLine("Coin gauche")
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 597, 463)
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Await Task.Delay(500)
                End If

            Else

                If control_selection = 1 Then

                    Console.WriteLine("Npc found")
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc_in_map_ref(0), Npc_in_map_ref(1) - 17)
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Await Task.Delay(500)

                Else
                    Console.WriteLine("control_selection = 0     >>>      Debug")
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                    Await Task.Delay(500)

                End If

            End If

Return_in_traveling:
            Var.Update_Screen()
            Dim traveling_indication As Bitmap = My.Resources.traveling_indication
            Dim traveling_indication_point As Point = Var.Client_Screen.Contains(traveling_indication)
            If traveling_indication_point <> Nothing Then
                Console.WriteLine("traveling indication trouvée")

                Var.Update_Screen()
                Dim All_Npcr2 = My.Resources.All_npc
                Dim Reference_npc_control As Point = Var.Client_Screen.Contains(All_Npcr2)

                If Reference_npc_control <> Nothing Then

                    Await Task.Delay(10)
                    Console.WriteLine("Npc Arround")
                    Console.WriteLine("traveling interrupted")
                Else

                    Await Task.Delay(100)
                    GoTo Return_in_traveling
                End If

            Else

                Var.Update_Screen()
                Dim traveling_indication_checking_true As Bitmap = My.Resources.traveling_indication
                Dim traveling_indication_checking As Point = Var.Client_Screen.Contains(traveling_indication)
                If traveling_indication_checking <> Nothing Then
                    Console.WriteLine("traveling indication trouvée")
                    Await Task.Delay(100)

                    Var.Update_Screen()
                    Dim All_Npcr2_ref_control = My.Resources.All_npc
                    Dim Reference_npc_control_statbut_starbucks_coffee As Point = Var.Client_Screen.Contains(All_Npcr2_ref_control)

                    If Reference_npc_control_statbut_starbucks_coffee <> Nothing Then

                        Await Task.Delay(100)
                        Console.WriteLine("Npc Arround")
                        Console.WriteLine("traveling interrupted")
                    Else

                        Await Task.Delay(100)
                        GoTo Return_in_traveling
                    End If

                Else
                    Console.WriteLine("No moving")
                End If
            End If


Return_Npc_not_on_lock:

            Var.Update_Screen()
            Dim All_Npc = My.Resources.All_npc
            Dim Reference_npc As Point = Var.Client_Screen.Contains(All_Npc)

            If Reference_npc <> Nothing Then

                Console.WriteLine("Npc Arround")
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Reference_npc.X + 30, Reference_npc.Y - 30)
                Await Task.Delay(100)

                Var.Update_Screen()
                Dim control_bordure = My.Resources.out_map
                Dim Bordure_control As Point = Var.Client_Screen.Contains(control_bordure)

                Dim control_bordure_second = My.Resources.out_map_second
                Dim Bordure_control_second As Point = Var.Client_Screen.Contains(control_bordure_second)

                If Bordure_control_second <> Nothing Then
                    If Bordure_control <> Nothing Then

                        If Reference_npc.X >= pointer_scan Then
                            If Reference_npc.X - Distance_npc <= pointer0 Then
                                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 1, Reference_npc.Y)
                            Else
                                ' if npc sibelonit exemple
                                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Reference_npc.X - Distance_npc, Reference_npc.Y)
                            End If
                        Else
                            If Reference_npc.X + Distance_npc >= pointer800 Then
                                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 799, Reference_npc.Y)
                            Else
                                ' if npc sibelonit exemple

                                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Reference_npc.X + Distance_npc, Reference_npc.Y)
                            End If
                        End If

                        Await Task.Delay(100)
                        Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "{LCTRL}")
                        Await Task.Delay(400)

                    Else
                        Console.WriteLine("out of map1")
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                        Await Task.Delay(5000)
                        GoTo Return_Npc_not_on_lock
                    End If
                Else
                    Console.WriteLine("out of map1_second")
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Await Task.Delay(5000)
                    GoTo Return_Npc_not_on_lock
                End If

Return_OnLock:

                Dim InLocked = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP + 155, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
                If InLocked.ToString.Contains(Var.Student) Then

                    Console.WriteLine("Npc on Lock")
                    Control_killed_searching = 0

                    Var.Update_Screen()
                    Dim control_bordure_ref = My.Resources.out_map
                    Dim Bordure_control_ref As Point = Var.Client_Screen.Contains(control_bordure)

                    Dim control_bordure_second_ref = My.Resources.out_map_second
                    Dim Bordure_control_second_ref As Point = Var.Client_Screen.Contains(control_bordure_second_ref)

                    If Bordure_control_second_ref <> Nothing Then
                        If Bordure_control_ref <> Nothing Then

                            If InLocked(0) >= pointer_scan Then
                                If InLocked(0) - Distance_npc <= pointer0 Then
                                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 1, InLocked(1))
                                Else Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, InLocked(0) - Distance_npc, InLocked(1))
                                End If
                            Else
                                If InLocked(0) + Distance_npc >= pointer800 Then
                                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 799, InLocked(1))
                                Else Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, InLocked(0) + Distance_npc, InLocked(1))
                                End If

                            End If

                        Else

                            Console.WriteLine("out of map2")
                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                            Await Task.Delay(5000)
                            GoTo Return_OnLock
                        End If
                    Else

                        Console.WriteLine("out of map2_second")
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                        Await Task.Delay(5000)
                        GoTo Return_OnLock
                    End If


                    Await Task.Delay(100)
                    GoTo Return_OnLock

                Else

                    If Control_killed_searching = control_killed_selection Then
                        Console.WriteLine("Npc Not on lock")
                        Control_killed_searching = 0
                        GoTo Return_Npc_not_on_lock

                    Else
                        Control_killed_searching = Control_killed_searching + 1
                        Console.WriteLine("Verification du lock")

                        If WebClient_GET_All_elements_currentWave = "4" Or
                             WebClient_GET_All_elements_currentWave = "12" Or
                             WebClient_GET_All_elements_currentWave = "18" Or
                            WebClient_GET_All_elements_currentWave = "36" Or
                             WebClient_GET_All_elements_currentWave = "40" Then

                            Var.Update_Screen()

                            Dim All_Npc_ref = My.Resources.All_npc
                            Dim Reference_npc_ref As Point = Var.Client_Screen.Contains(All_Npc)
                            Dim control_bordure_ref = My.Resources.out_map
                            Dim Bordure_control_ref As Point = Var.Client_Screen.Contains(control_bordure)
                            Dim control_bordure_second_ref = My.Resources.out_map_second
                            Dim Bordure_control_second_ref As Point = Var.Client_Screen.Contains(control_bordure_second)

                            If Bordure_control_second <> Nothing Then
                                If Bordure_control <> Nothing Then

                                    If Reference_npc_ref.X >= pointer_scan Then
                                        If Reference_npc_ref.X - Distance_npc <= pointer0 Then
                                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 1, Reference_npc_ref.Y)
                                        Else Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Reference_npc_ref.X - Distance_npc, Reference_npc_ref.Y)
                                        End If
                                    Else
                                        If Reference_npc_ref.X + Distance_npc >= pointer800 Then
                                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 799, Reference_npc_ref.Y)
                                        Else Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Reference_npc_ref.X + Distance_npc, Reference_npc_ref.Y)
                                        End If
                                    End If

                                Else
                                    Console.WriteLine("out of map1")
                                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                                    Await Task.Delay(5000)
                                    GoTo Return_Npc_not_on_lock
                                End If
                            Else
                                Console.WriteLine("out of map1_second")
                                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                                Await Task.Delay(5000)
                                GoTo Return_Npc_not_on_lock
                            End If
                        End If

                        Await Task.Delay(100)
                        GoTo Return_OnLock


                    End If

                End If

            Else
                Console.WriteLine("No Npc arround, wait..")
                GoTo Base_macro

            End If

        Else

            Console.WriteLine("Npc not found, Control Gates in progress.. ")

            Var.Update_Screen()
            Dim Portal = My.Resources.Portal

            Dim portal_finder As Point = Var.Client_Screen.Contains(Portal)
            If portal_finder <> Nothing Then

                Console.WriteLine("Wave terminated")

                If Form_Tools.CheckBox_alpha_gates_module.Checked = True Then ' Check box alpha

                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' portail gauche
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Console.WriteLine($"Goto next portal")

                Else
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' portail droite
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Console.WriteLine($"Goto base , Textbox Unchecked")

                End If

                Await Task.Delay(1000)

Return_traveling_map:
                Var.Update_Screen()
                Dim traveling_indication As Bitmap = My.Resources.traveling_indication
                Dim traveling_indication_point As Point = Var.Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    Console.WriteLine("traveling indication trouvée")
                    Await Task.Delay(2500)
                    GoTo Return_traveling_map

                Else
                    Var.Update_Screen()
                    Dim traveling_indication_checking_true As Bitmap = My.Resources.traveling_indication
                    Dim traveling_indication_checking As Point = Var.Client_Screen.Contains(traveling_indication)
                    If traveling_indication_checking <> Nothing Then
                        Console.WriteLine("traveling indication trouvée")
                        Await Task.Delay(2500)
                        GoTo Return_traveling_map
                    Else
                        Console.WriteLine("No moving")
                    End If
                End If

                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_jump_key.Text))
                GoTo Base_macro

            Else

                Console.WriteLine("Checking Waves in progress..")
                Dim Npc_in_map_Afterwork = Var.AutoIt.PixelSearch(595, 465, 785, 595, 13369344, 0, 1)
                If Npc_in_map_Afterwork.ToString.Contains(Var.Student) Then
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' Debug
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Await Task.Delay(2500)
                    GoTo Base_macro

                Else
                    Await Task.Delay(100)
                    GoTo Search_load

                End If
            End If
        End If

    End Function

End Class
