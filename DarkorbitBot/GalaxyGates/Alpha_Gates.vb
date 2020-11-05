Imports System.Net
Imports System.Text.RegularExpressions

Public Class Alpha_Gates

    Public Shared Table_Load As String = """.*) \/>"
    Public Shared Verification_string As String = 0
    Public Shared Current_npc As String

    Public Shared Function Search_current_waves()

        Form_Tools.WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = Form_Tools.WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<gate (.*id=""2" + Table_Load).Groups.Item(1).ToString ' ALPHA
        Console.WriteLine(WebClient_GET_All_elements)

        Dim WebClient_GET_All_elements_currentWave = Regex.Match(WebClient_GET_All_elements, "currentWave="".*?([\s\S]*?)""").Groups.Item(1).ToString

        If WebClient_GET_All_elements_currentWave = "0" Or "1" Or "2" Or "3" Or "4" Then
            Current_npc = "streuner"
            Console.WriteLine(Current_npc)
            Streuner_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "5" Or "6" Or "7" Or "8" Then
            Current_npc = "lordakia" ' df
            Console.WriteLine(Current_npc)
            Lordakia_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "9" Or "10" Or "11" Or "12" Then
            Current_npc = "mordon"
            Console.WriteLine(Current_npc)
            Mordon_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "13" Or "14" Or "15" Or "16" Then
            Current_npc = "saimon" ' df
            Console.WriteLine(Current_npc)
            Saimon_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "17" Or "18" Or "19" Or "20" Then
            Current_npc = "devolarium"
            Console.WriteLine(Current_npc)
            Devolarium_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "21" Or "22" Or "23" Or "24" Then
            Current_npc = "kristallin"
            Console.WriteLine(Current_npc)
            Kristallin_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "25" Or "26" Or "27" Or "28" Then
            Current_npc = "sibelon"
            Console.WriteLine(Current_npc)
            Sibelon_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "29" Or "30" Or "31" Or "32" Then
            Current_npc = "sibelonit"
            Console.WriteLine(Current_npc)
            Sibelonit_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "33" Or "34" Or "35" Or "36" Then
            Current_npc = "kristallon"
            Console.WriteLine(Current_npc)
            Kristallon_Alpha()

        ElseIf WebClient_GET_All_elements_currentWave = "37" Or "38" Or "39" Or "40" Then
            Current_npc = "protegit" 'df
            Console.WriteLine(Current_npc)
            Protegit_Alpha()

        End If

    End Function

    Public Shared Async Function Streuner_Alpha() As Task

Base_macro:

        Dim Streuner = Var.AutoIt.PixelSearch(595, 465, 785, 595, 13369344, 0, 1) ' CHANGER 
        'Console.WriteLine(Streuner)
        If Streuner.ToString.Contains(Var.Student) Then

            Console.WriteLine("Npc found")
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Streuner(0), Streuner(1) - 18)
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
            Await Task.Delay(500)

            ' AJOUTER TRAVELING INDICATION

Return_Npc_not_on_lock:

            Var.Update_Screen()
            Dim All_Npc = My.Resources.All_npc
            Dim Npc_ref As Point = Var.Client_Screen.Contains(All_Npc)

            If Npc_ref <> Nothing Then

                Console.WriteLine("Npc Arround")
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc_ref.X + 30, Npc_ref.Y - 30)
                Await Task.Delay(100)
                Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Npc_ref.X, Npc_ref.Y + 30)
                Await Task.Delay(100)
                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "{LCTRL}")
                Await Task.Delay(300)

Return_OnLock:

                Dim InLocked = Var.AutoIt.PixelSearch(Form_Game.X_TOP, Form_Game.Y_TOP + 110, Form_Game.X_BOTTOM, Form_Game.Y_BOTTOM, 13377289, 0, 1)
                If InLocked.ToString.Contains(Var.Student) Then

                    Console.WriteLine("Npc on Lock")

                    If InLocked(0) >= 400 Then
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, InLocked(0) - 380, InLocked(1))
                    Else
                        Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, InLocked(0) + 380, InLocked(1))
                    End If

                    Await Task.Delay(500)
                    GoTo Return_OnLock

                Else

                    Console.WriteLine("Npc Not on lock")
                    GoTo Return_Npc_not_on_lock

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

                If Form_Tools.CheckBox_kill_alpha_lordakia.Checked = True Then ' CHANGER 

                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' portail gauche
                    Console.WriteLine($"Goto next portal")

                Else
                    Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 522) ' portail droite
                    Console.WriteLine($"Goto base , Textbox Unchecked")
                End If
                Await Task.Delay(10000)
                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_jump_key.Text))
                GoTo Base_macro

            Else
                Console.WriteLine("Checking Waves in progress..")
                Await Task.Delay(500)
                GoTo Base_macro
            End If

        End if

    End Function
    Public Shared Function Lordakia_Alpha()

    End Function
    Public Shared Function Mordon_Alpha()

    End Function
    Public Shared Function Saimon_Alpha()

    End Function
    Public Shared Function Devolarium_Alpha()

    End Function
    Public Shared Function Kristallin_Alpha()

    End Function
    Public Shared Function Sibelon_Alpha()

    End Function
    Public Shared Function Sibelonit_Alpha()

    End Function
    Public Shared Function Kristallon_Alpha()

    End Function
    Public Shared Function Protegit_Alpha()

    End Function

End Class
