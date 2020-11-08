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
    Public Shared sibelonit_alpha As Integer = "395"
    Public Shared kristallon_alpha As Integer = "410"
    Public Shared protegit_alpha As Integer = "410"

    Public Shared Distance_npc As Integer
    Public Shared pointer0 As Integer = "0"
    Public Shared pointer800 As Integer = "800"

    Public Shared pointer_scan As Integer = "400"

    Public Shared Async Function Search_current_waves() As Task

Return_start:

        Form_Tools.WebClient_POST.Headers.Clear()
        Form_Tools.WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = Form_Tools.WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<gate (.*id=""1" + Table_Load).Groups.Item(1).ToString ' ALPHA
        Console.WriteLine(WebClient_GET_All_elements)

        Dim WebClient_GET_All_elements_currentWave = Regex.Match(WebClient_GET_All_elements, "currentWave="".*?([\s\S]*?)""").Groups.Item(1).ToString

        If WebClient_GET_All_elements_currentWave = "0" Or
           WebClient_GET_All_elements_currentWave = "1" Or
           WebClient_GET_All_elements_currentWave = "2" Or
           WebClient_GET_All_elements_currentWave = "3" Or
           WebClient_GET_All_elements_currentWave = "4" Then
            Current_npc = "streuner"
            Distance_npc = streuner_alpha
            control_killed_selection = "3"

        ElseIf WebClient_GET_All_elements_currentWave = "5" Or
            WebClient_GET_All_elements_currentWave = "6" Or
            WebClient_GET_All_elements_currentWave = "7" Or
            WebClient_GET_All_elements_currentWave = "8" Then
            Current_npc = "lordakia" ' df
            Distance_npc = Lordakia_alpha
            control_killed_selection = "5"

        ElseIf WebClient_GET_All_elements_currentWave = "9" Or
            WebClient_GET_All_elements_currentWave = "10" Or
            WebClient_GET_All_elements_currentWave = "11" Or
            WebClient_GET_All_elements_currentWave = "12" Then
            Current_npc = "mordon"
            Distance_npc = mordon_alpha
            control_killed_selection = "8"

        ElseIf WebClient_GET_All_elements_currentWave = "13" Or
            WebClient_GET_All_elements_currentWave = "14" Or
            WebClient_GET_All_elements_currentWave = "15" Or
            WebClient_GET_All_elements_currentWave = "16" Then
            Current_npc = "saimon" ' df
            Distance_npc = saimon_alpha
            control_killed_selection = "10"

        ElseIf WebClient_GET_All_elements_currentWave = "17" Or
            WebClient_GET_All_elements_currentWave = "18" Or
            WebClient_GET_All_elements_currentWave = "19" Or
            WebClient_GET_All_elements_currentWave = "20" Then
            Current_npc = "devolarium"
            Distance_npc = devolarium_alpha
            control_killed_selection = "15"

        ElseIf WebClient_GET_All_elements_currentWave = "21" Or
            WebClient_GET_All_elements_currentWave = "22" Or
            WebClient_GET_All_elements_currentWave = "23" Or
            WebClient_GET_All_elements_currentWave = "24" Then
            Current_npc = "kristallin"
            Distance_npc = kristallin_alpha
            control_killed_selection = "9"

        ElseIf WebClient_GET_All_elements_currentWave = "25" Or
            WebClient_GET_All_elements_currentWave = "26" Or
            WebClient_GET_All_elements_currentWave = "27" Or
            WebClient_GET_All_elements_currentWave = "28" Then
            Current_npc = "sibelon"
            Distance_npc = sibelon_alpha
            control_killed_selection = "15"

        ElseIf WebClient_GET_All_elements_currentWave = "29" Or
            WebClient_GET_All_elements_currentWave = "30" Or
            WebClient_GET_All_elements_currentWave = "31" Or
            WebClient_GET_All_elements_currentWave = "32" Then
            Current_npc = "sibelonit"
            Distance_npc = sibelonit_alpha
            control_killed_selection = "9"

        ElseIf WebClient_GET_All_elements_currentWave = "33" Or
            WebClient_GET_All_elements_currentWave = "34" Or
            WebClient_GET_All_elements_currentWave = "35" Or
            WebClient_GET_All_elements_currentWave = "36" Then
            Current_npc = "kristallon"
            Distance_npc = kristallon_alpha
            control_killed_selection = "9"

        ElseIf WebClient_GET_All_elements_currentWave = "37" Or
            WebClient_GET_All_elements_currentWave = "38" Or
            WebClient_GET_All_elements_currentWave = "39" Or
            WebClient_GET_All_elements_currentWave = "40" Then
            Current_npc = "protegit" 'df
            Distance_npc = protegit_alpha
            control_killed_selection = "15"

        End If

        Console.WriteLine(Current_npc)
        Console.WriteLine(Distance_npc)
        Console.WriteLine(control_killed_selection)
        'Gates_task_task()

Base_macro:
        Dim Npc_in_map = Var.AutoIt.PixelSearch(595, 465, 785, 595, 13369344, 0, 1) ' detecter dans une plus petite zone pour savoir si il reste des npc avant d'attaquer les coins 

        If Npc_in_map.ToString.Contains(Var.Student) Then

            Var.Update_Screen()
            Dim Npc_dans_le_coin_bas_droite = My.Resources.coin_bas_droite
            Dim Npc_dans_le_coin_haut_gauche = My.Resources.coin_haut_gauche
            Dim Coin_droite As Point = Var.Client_Screen.Contains(Npc_dans_le_coin_bas_droite)
            Dim Coin_gauche As Point = Var.Client_Screen.Contains(Npc_dans_le_coin_haut_gauche)

            If Coin_droite <> Nothing Then
                Console.WriteLine("coin droite")
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 771, 58)
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                Await Task.Delay(1000)

            ElseIf Coin_gauche <> Nothing Then
                Console.WriteLine("Coin gauche")
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 597, 463)
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                Await Task.Delay(1000)

            Else
                Console.WriteLine("Npc found")
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc_in_map(0), Npc_in_map(1) - 17)
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                Await Task.Delay(500)
            End If

Return_in_traveling:
            Var.Update_Screen()
            Dim traveling_indication As Bitmap = My.Resources.traveling_indication
            Dim traveling_indication_point As Point = Var.Client_Screen.Contains(traveling_indication)
            If traveling_indication_point <> Nothing Then
                Console.WriteLine("traveling indication trouvée")
                Await Task.Delay(500)
                GoTo Return_in_traveling

            Else
                Var.Update_Screen()
                Dim traveling_indication_checking As Point = Var.Client_Screen.Contains(traveling_indication)
                If traveling_indication_checking <> Nothing Then
                    Console.WriteLine("traveling indication trouvée")
                    Await Task.Delay(500)
                    GoTo Return_in_traveling
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

                If Reference_npc.X >= pointer_scan Then
                    If Reference_npc.X - Distance_npc <= pointer0 Then
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 1, Reference_npc.Y)
                    Else
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Reference_npc.X - Distance_npc, Reference_npc.Y)
                    End If
                Else
                    If Reference_npc.X + Distance_npc >= pointer800 Then
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 799, Reference_npc.Y)
                    Else
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Reference_npc.X + Distance_npc, Reference_npc.Y)
                    End If
                End If ' ajouter un changer de direction tout les 200x exemple

                Await Task.Delay(100)
                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "{LCTRL}")
                Await Task.Delay(350)

Return_OnLock:

                Dim InLocked = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP + 155, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
                If InLocked.ToString.Contains(Var.Student) Then

                    Console.WriteLine("Npc on Lock")
                    Control_killed_searching = 0

                    If InLocked(0) >= pointer_scan Then
                        If InLocked(0) - Distance_npc <= pointer0 Then
                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 1, InLocked(1))
                        Else
                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, InLocked(0) - Distance_npc, InLocked(1))
                        End If
                    Else
                        If InLocked(0) + Distance_npc >= pointer800 Then
                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 799, InLocked(1))
                        Else
                            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, InLocked(0) + Distance_npc, InLocked(1))
                        End If ' ajouter un changeur de direction tous les 200x exemple

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
                        Await Task.Delay(50)
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

                If Form_Tools.CheckBox_kill_alpha_lordakia.Checked = True Then
                    ' CHANGER >>>    CheckBox_kill_alpha_lordakia > si npc alors plus haut alors un autre plus bas etc ! l'endroit du portail change selon la vague !
                    ' sert aussi a definir si on veut passer a la vague d'apres ou s arreter avec la checkbox kill >>>

                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' portail gauche
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Console.WriteLine($"Goto next portal")

                Else
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' portail droite
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                    Console.WriteLine($"Goto base , Textbox Unchecked")
                End If

Return_traveling_map:
                Var.Update_Screen()
                Dim traveling_indication As Bitmap = My.Resources.traveling_indication
                Dim traveling_indication_point As Point = Var.Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    Console.WriteLine("traveling indication trouvée")
                    Await Task.Delay(1000)
                    GoTo Return_traveling_map

                Else
                    Var.Update_Screen()
                    Dim traveling_indication_checking As Point = Var.Client_Screen.Contains(traveling_indication)
                    If traveling_indication_checking <> Nothing Then
                        Console.WriteLine("traveling indication trouvée")
                        Await Task.Delay(1000)
                        GoTo Return_traveling_map
                    Else
                        Console.WriteLine("No moving")
                    End If
                End If

                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_jump_key.Text))
                Await Task.Delay(10000)
                GoTo Base_macro

            Else
                Console.WriteLine("Checking Waves in progress..")
                Await Task.Delay(2000)
                GoTo Return_start
                'permet de revenir au début

                'Search_current_waves()
                'Exit Function
            End If

        End If

    End Function

End Class
