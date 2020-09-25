Imports System.Net
Imports System.Text.RegularExpressions

Public Class GalaxyGates_module

    Public Shared GalaxyGates_Name As String
    Public Shared Spins_reward As String
    Public Shared GalaxyGates_id As String
    Public Shared GalaxyGates_id_spin As String

    Public Shared PART_GG_GG_Completed As Object
    Public Shared PART_CHECKER As Object
    Public Shared PART_GG As Object = Form_Tools.INFO_PART_GG_LABEL.Text

    Public Shared Table_Chronos As String = """.*) >"
    Public Shared Table_Load As String = """.*) \/>"

    Public Shared Duplicate_Yes As Object = 0
    Public Shared Autorize_ABG As Object = 0

    Public Shared Webclient_GET_Items_amount_counter As Double
    Public Shared Webclient_GET_Items_part_multiplier_amount_counter As Double
    Public Shared Webclient_GET_Items_amount_counter_TTT_Webclient_GET_Items_part_multiplier_amount_counter_counterStrike As String = 0
    Public Shared RisedSky As String = 0

    Public Shared Module_control_control_lang As Object = 0

    Public Shared WebClient_POST As New System.Net.WebClient


    Public Shared Function Load()

        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils_module.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils_module.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils_module.userid + "&action=init&sid=" + Utils_module.dosid)

        Form_Tools.TextBox_uridiumGGS.Text = Regex.Match(WebClient_Data, "<money>(.*)<\/money>").Groups.Item(1).ToString 'Uridium
        Form_Tools.TextBox_ExtraEnergy_GGS.Text = Regex.Match(WebClient_Data, "<samples>(.*)<\/samples>").Groups.Item(1).ToString 'Eextra energy
        Form_Tools.Leaderprice.Text = Regex.Match(WebClient_Data, "<energy_cost mode=""standard"">(.*)<\/energy_cost>").Groups.Item(1).ToString + " U." 'Spin Price

        Dim WebClient_GET_All_elements_Alpha = Regex.Match(WebClient_Data, "<gate (.*id=""1" + Table_Load).Groups.Item(1).ToString 'A
        Dim WebClient_GET_current_part_Alpha = Regex.Match(WebClient_GET_All_elements_Alpha, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Alpha = Regex.Match(WebClient_GET_All_elements_Alpha, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_alpha.Text = "Alpha [ " + WebClient_GET_current_part_Alpha + " / " + WebClient_GET_total_part_Alpha + " ]"

        Dim WebClient_GET_All_elements_Beta = Regex.Match(WebClient_Data, "<gate (.*id=""2" + Table_Load).Groups.Item(1).ToString 'B 
        Dim WebClient_GET_current_part_Beta = Regex.Match(WebClient_GET_All_elements_Beta, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Beta = Regex.Match(WebClient_GET_All_elements_Beta, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_beta.Text = "Beta [ " + WebClient_GET_current_part_Beta + " / " + WebClient_GET_total_part_Beta + " ]"

        Dim WebClient_GET_All_elements_Gamma = Regex.Match(WebClient_Data, "<gate (.*id=""3" + Table_Load).Groups.Item(1).ToString 'G
        Dim WebClient_GET_current_part_Gamma = Regex.Match(WebClient_GET_All_elements_Gamma, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Gamma = Regex.Match(WebClient_GET_All_elements_Gamma, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_gamma.Text = "Gamma [ " + WebClient_GET_current_part_Gamma + " / " + WebClient_GET_total_part_Gamma + " ]"

        Dim WebClient_GET_All_elements_Delta = Regex.Match(WebClient_Data, "<gate (.*id=""4" + Table_Load).Groups.Item(1).ToString 'D
        If WebClient_GET_All_elements_Delta <> Nothing Then

            Dim WebClient_GET_current_part_Delta = Regex.Match(WebClient_GET_All_elements_Delta, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Delta = Regex.Match(WebClient_GET_All_elements_Delta, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_delta.Text = "Delta [ " + WebClient_GET_current_part_Delta + " / " + WebClient_GET_total_part_Delta + " ]"

        Else Dim WebClient_GET_All_elements_Delta_remained = Regex.Match(WebClient_Data, "<gate (.*id=""4" + Table_Chronos).Groups.Item(1).ToString 'D

            Form_Tools.PictureBox_delta_reward_day.Visible = True
            Dim WebClient_GET_current_part_Delta_remained = Regex.Match(WebClient_GET_All_elements_Delta_remained, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Delta_remained = Regex.Match(WebClient_GET_All_elements_Delta_remained, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_delta.Text = "Delta [ " + WebClient_GET_current_part_Delta_remained + " / " + WebClient_GET_total_part_Delta_remained + " ]"

        End If

        Dim WebClient_GET_All_elements_Epsilon = Regex.Match(WebClient_Data, "<gate (.*id=""5" + Table_Load).Groups.Item(1).ToString 'E
        If WebClient_GET_All_elements_Epsilon <> Nothing Then

            Dim WebClient_GET_current_part_Epsilon = Regex.Match(WebClient_GET_All_elements_Epsilon, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Epsilon = Regex.Match(WebClient_GET_All_elements_Epsilon, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_epsilon.Text = "Epsilon [ " + WebClient_GET_current_part_Epsilon + " / " + WebClient_GET_total_part_Epsilon + " ]"

        Else Dim WebClient_GET_All_elements_Epsilon_remained = Regex.Match(WebClient_Data, "<gate (.*id=""5" + Table_Chronos).Groups.Item(1).ToString 'E

            Form_Tools.PictureBox_epsilon_reward_day.Visible = True
            Dim WebClient_GET_current_part_Epsilon_remained = Regex.Match(WebClient_GET_All_elements_Epsilon_remained, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Epsilon_remained = Regex.Match(WebClient_GET_All_elements_Epsilon_remained, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_epsilon.Text = "Epsilon [ " + WebClient_GET_current_part_Epsilon_remained + " / " + WebClient_GET_total_part_Epsilon_remained + " ]"


        End If

        Dim WebClient_GET_All_elements_Zeta = Regex.Match(WebClient_Data, "<gate (.*id=""6" + Table_Load).Groups.Item(1).ToString 'Z
        If WebClient_GET_All_elements_Zeta <> Nothing Then

            Dim WebClient_GET_current_part_Zeta = Regex.Match(WebClient_GET_All_elements_Zeta, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Zeta = Regex.Match(WebClient_GET_All_elements_Zeta, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_zeta.Text = "Zeta [ " + WebClient_GET_current_part_Zeta + " / " + WebClient_GET_total_part_Zeta + " ]"

        Else Dim WebClient_GET_All_elements_Zeta_remained = Regex.Match(WebClient_Data, "<gate (.*id=""6" + Table_Chronos).Groups.Item(1).ToString 'Z

            Form_Tools.PictureBox_zeta_reward_day.Visible = True
            Dim WebClient_GET_current_part_Zeta_remained = Regex.Match(WebClient_GET_All_elements_Zeta_remained, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Zeta_remained = Regex.Match(WebClient_GET_All_elements_Zeta_remained, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_zeta.Text = "Zeta [ " + WebClient_GET_current_part_Zeta_remained + " / " + WebClient_GET_total_part_Zeta_remained + " ]"

        End If

        Dim WebClient_GET_All_elements_Kappa = Regex.Match(WebClient_Data, "<gate (.*id=""7" + Table_Load).Groups.Item(1).ToString 'K
        If WebClient_GET_All_elements_Kappa <> Nothing Then

            Dim WebClient_GET_current_part_Kappa = Regex.Match(WebClient_GET_All_elements_Kappa, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Kappa = Regex.Match(WebClient_GET_All_elements_Kappa, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_kappa.Text = "Kappa [ " + WebClient_GET_current_part_Kappa + " / " + WebClient_GET_total_part_Kappa + " ]"

        Else Dim WebClient_GET_All_elements_Kappa_remained = Regex.Match(WebClient_Data, "<gate (.*id=""7" + Table_Chronos).Groups.Item(1).ToString 'K

            Form_Tools.PictureBox_kappa_reward_day.Visible = True
            Dim WebClient_GET_current_part_Kappa_remained = Regex.Match(WebClient_GET_All_elements_Kappa_remained, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_total_part_Kappa_remained = Regex.Match(WebClient_GET_All_elements_Kappa_remained, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Form_Tools.Label_kappa.Text = "Kappa [ " + WebClient_GET_current_part_Kappa_remained + " / " + WebClient_GET_total_part_Kappa_remained + " ]"

        End If

        Dim WebClient_GET_All_elements_Lambda = Regex.Match(WebClient_Data, "<gate (.*id=""8" + Table_Load).Groups.Item(1).ToString 'L
        Dim WebClient_GET_current_part_Lambda = Regex.Match(WebClient_GET_All_elements_Lambda, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Lambda = Regex.Match(WebClient_GET_All_elements_Lambda, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_lambda.Text = "Lambda [ " + WebClient_GET_current_part_Lambda + " / " + WebClient_GET_total_part_Lambda + " ]"

        Dim WebClient_GET_All_elements_Hades = Regex.Match(WebClient_Data, "<gate (.*id=""13" + Table_Load).Groups.Item(1).ToString 'H
        Dim WebClient_GET_current_part_Hades = Regex.Match(WebClient_GET_All_elements_Hades, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Hades = Regex.Match(WebClient_GET_All_elements_Hades, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_hades.Text = "Hades [ " + WebClient_GET_current_part_Hades + " / " + WebClient_GET_total_part_Hades + " ]"

        Dim WebClient_GET_All_elements_Kuiper = Regex.Match(WebClient_Data, "<gate (.*id=""19" + Table_Load).Groups.Item(1).ToString 'K
        Dim WebClient_GET_current_part_Kuiper = Regex.Match(WebClient_GET_All_elements_Kuiper, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Kuiper = Regex.Match(WebClient_GET_All_elements_Kuiper, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_kuiper.Text = "Kuiper [ " + WebClient_GET_current_part_Kuiper + " / " + WebClient_GET_total_part_Kuiper + " ]"

        Dim WebClient_GET_All_elements_Chronos = Regex.Match(WebClient_Data, "<gate (.*id=""12" + Table_Chronos).Groups.Item(1).ToString 'CHR
        Dim WebClient_GET_current_part_Chronos = Regex.Match(WebClient_GET_All_elements_Chronos, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Chronos = Regex.Match(WebClient_GET_All_elements_Chronos, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_chronos.Text = "Chronos [ " + WebClient_GET_current_part_Chronos + " / " + WebClient_GET_total_part_Chronos + " ]"

    End Function

    Public Shared Function View(ByVal GalaxyGates_id As String, ByVal GalaxyGates_Name As String)

        GalaxyGates_Name = GalaxyGates_Name.ToLower()

        'WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils_module.dosid};")
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils_module.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils_module.userid + "&action=init&sid=" + Utils_module.dosid)

        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<gate (.*id=""" + GalaxyGates_id + Table_Load).Groups.Item(1).ToString
        If WebClient_GET_All_elements <> Nothing Then

            Dim WebClient_GET_All_elements_currentWave = Regex.Match(WebClient_GET_All_elements, "currentWave="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_totalWave = Regex.Match(WebClient_GET_All_elements, "totalWave="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_livesLeft = Regex.Match(WebClient_GET_All_elements, "livesLeft="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_current_part = Regex.Match(WebClient_GET_All_elements, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_total_part = Regex.Match(WebClient_GET_All_elements, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_lifePrice = Regex.Match(WebClient_GET_All_elements, "lifePrice="".*?([\s\S]*?)""").Groups.Item(1).ToString

            Form_Tools.INFO_WAVE_GG_LABEL.Text = "Wave : " + WebClient_GET_All_elements_currentWave + " / " + WebClient_GET_All_elements_totalWave
            Form_Tools.INFO_LIVES_LEFT_GG_LABEL.Text = "Lives left : " + WebClient_GET_All_elements_livesLeft
            Form_Tools.INFO_PART_GG_LABEL.Text = "Part : " + WebClient_GET_All_elements_current_part + " / " + WebClient_GET_All_elements_total_part

            If WebClient_GET_All_elements.Contains("state=""in_progress""") Then
                ' LA GG N'EST PAS COMPLETE
            Else ' LA GG EST COMPLETE
            End If

            If WebClient_GET_All_elements.Contains("prepared=""1""") Then
                Form_Tools.INFO_ON_MAP_GG_LABEL.Text = "On Map : 1"
            Else Form_Tools.INFO_ON_MAP_GG_LABEL.Text = "On Map : 0"
            End If


        Else Dim WebClient_GET_All_elements_remained = Regex.Match(WebClient_Data, "<gate (.*id=""" + GalaxyGates_id + Table_Chronos).Groups.Item(1).ToString

            Dim WebClient_GET_All_elements_currentWave_remained = Regex.Match(WebClient_GET_All_elements_remained, "currentWave="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_totalWave_remained = Regex.Match(WebClient_GET_All_elements_remained, "totalWave="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_livesLeft_remained = Regex.Match(WebClient_GET_All_elements_remained, "livesLeft="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_current_part_remained = Regex.Match(WebClient_GET_All_elements_remained, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_total_part_remained = Regex.Match(WebClient_GET_All_elements_remained, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
            Dim WebClient_GET_All_elements_lifePrice_remained = Regex.Match(WebClient_GET_All_elements_remained, "lifePrice="".*?([\s\S]*?)""").Groups.Item(1).ToString

            Form_Tools.INFO_WAVE_GG_LABEL.Text = "Wave : " + WebClient_GET_All_elements_currentWave_remained + " / " + WebClient_GET_All_elements_totalWave_remained
            Form_Tools.INFO_LIVES_LEFT_GG_LABEL.Text = "Lives left : " + WebClient_GET_All_elements_livesLeft_remained
            Form_Tools.INFO_PART_GG_LABEL.Text = "Part : " + WebClient_GET_All_elements_current_part_remained + " / " + WebClient_GET_All_elements_total_part_remained

            If WebClient_GET_All_elements_remained.Contains("state=""in_progress""") Then
                ' LA GG N'EST PAS COMPLETE
            Else ' LA GG EST COMPLETE
            End If

            If WebClient_GET_All_elements_remained.Contains("prepared=""1""") Then
                Form_Tools.INFO_ON_MAP_GG_LABEL.Text = "On Map : 1"
            Else Form_Tools.INFO_ON_MAP_GG_LABEL.Text = "On Map : 0"
            End If

        End If

        Form_Tools.ComboBox_autospin.Text = GalaxyGates_Name

        If Form_Tools.Button_game_doodle.Text = "Game" Then

            Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils_module.server + ".darkorbit.com/jumpgate.php?userID=" + Utils_module.userid + "&gateID=" + GalaxyGates_id + "&type=full")

        Else

        End If


    End Function

    Public Shared Function Spin(ByVal GalaxyGates_id As String, ByVal GalaxyGates_Name As String, ByVal Autorize_ABG As Object)

        GalaxyGates_Name = GalaxyGates_Name.ToLower()

        If Form_Tools.CheckBox_UseOnlyEE_GGS.Checked = True And Form_Tools.TextBox_ExtraEnergy_GGS.Text = "0" Then

            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"You no longer have / no Extra Energy." + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text

            Form_Tools.Button_StartSpin.Enabled = True
            Form_Tools.Button_stopSpin.Enabled = False
            Form_Tools.ComboBox_autospin.Enabled = True
            Form_Tools.exitGGS = 1
            Exit Function

        ElseIf Val(Form_Tools.TextBox_uridiumGGS.Text.Replace(".", "")) < Val(Form_Tools.TextBox_uridiumtokeepGGS.Text.Replace(".", "")) And Form_Tools.CheckBox_UseOnlyEE_GGS.Checked = False Then

            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"You no longer have / no Uridium." + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text

            Form_Tools.Button_StartSpin.Enabled = True
            Form_Tools.Button_stopSpin.Enabled = False
            Form_Tools.ComboBox_autospin.Enabled = True
            Form_Tools.exitGGS = 1
            Exit Function
        End If

        Dim Result_PART_GG = Regex.Match(PART_GG, "Part :(.*)").Groups.Item(1).ToString
        If Result_PART_GG = "34 / 34" AndAlso GalaxyGates_id = 1 Then
            GalaxyGates_id = 1
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "48 / 48" AndAlso GalaxyGates_id = 2 Then
            GalaxyGates_id = 2
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "82 / 82" AndAlso GalaxyGates_id = 3 Then
            GalaxyGates_id = 3
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "128 / 128" AndAlso GalaxyGates_id = 4 Then
            GalaxyGates_id = 4
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "99 / 99" AndAlso GalaxyGates_id = 5 Then
            GalaxyGates_id = 5
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "111 / 111" AndAlso GalaxyGates_id = 6 Then
            GalaxyGates_id = 6
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "120 / 120" AndAlso GalaxyGates_id = 7 Then
            GalaxyGates_id = 7
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "45 / 45" AndAlso GalaxyGates_id = 8 Then
            GalaxyGates_id = 8
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "45 / 45" AndAlso GalaxyGates_id = 13 Then
            GalaxyGates_id = 13
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "100 / 100" AndAlso GalaxyGates_id = 19 Then
            GalaxyGates_id = 19
            PART_CHECKER = 1

        ElseIf Result_PART_GG = "21 / 21" AndAlso GalaxyGates_id = 12 Then
            GalaxyGates_id = 12
            PART_CHECKER = 1

        Else
            GalaxyGates_id = GalaxyGates_id
            PART_CHECKER = 0

        End If

        If PART_CHECKER = 1 Then
            PART_CHECKER = 0

            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates " + PART_GG_GG_Completed + " Completed." + Form_Tools.TextBox_WinGGS.Text
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text

            If Form_Tools.INFO_ON_MAP_GG_LABEL.Text = "1" Then

                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates " + PART_GG_GG_Completed + " 2 / 2 Completed." + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text

                Form_Tools.Button_StartSpin.Enabled = True
                Form_Tools.Button_stopSpin.Enabled = False
                Form_Tools.ComboBox_autospin.Enabled = True
                Form_Tools.exitGGS = 1
                Exit Function

            Else

                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates " + PART_GG_GG_Completed + " 1 / 2 Completed." + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text

            End If

            Dim Prepare_Gates_POST As New System.Net.WebClient
            Prepare_Gates_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils_module.dosid};")
            Dim Prepare_Gates_Data = Prepare_Gates_POST.DownloadString("https://" + Utils_module.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + Utils_module.userid + "&sid=" + Utils_module.dosid + "&action=setupGate&gateID=" & GalaxyGates_id)

            If Form_Tools.CheckBox_BuildOneAndStop.Checked = True Then

                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"CheckBox_BuildOneAndStop are checked. " + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text

                Form_Tools.Button_StartSpin.Enabled = True
                Form_Tools.Button_stopSpin.Enabled = False
                Form_Tools.ComboBox_autospin.Enabled = True
                Form_Tools.exitGGS = 1
                Exit Function

            Else

                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"CheckBox_BuildOneAndStop are not checked. " + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner reactivated." + Form_Tools.TextBox_WinGGS.Text
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"" + Form_Tools.TextBox_WinGGS.Text

            End If
        End If

        'WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils_module.dosid};")
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils_module.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils_module.userid + "&action=multiEnergy&sid=" + Utils_module.dosid + "&gateID=" + GalaxyGates_id + "&" + GalaxyGates_Name + "=1&sample=1&sample=1&multiplier=1")
        Form_Tools.TextBox_uridiumGGS.Text = Regex.Match(WebClient_Data, "<money>(.*)<\/money>").Groups.Item(1).ToString 'Uridium Left
        Dim Webclient_GET_Gates_name = Regex.Match(WebClient_Data, "<mode>(.*)<\/mode>").Groups.Item(1).ToString ' Gates name
        Dim Webclient_GET_Items = Regex.Match(WebClient_Data, "<item (.*)>").Groups.Item(1).ToString ' Items Rewared
        Console.WriteLine(Webclient_GET_Items)

        Dim Webclient_GET_Items_type = Regex.Match(WebClient_Data, "type=\""([^\""]*)").Groups.Item(1).ToString ' type de recompense
        Dim Webclient_GET_Items_item_id = Regex.Match(WebClient_Data, "item_id=\""([^\""]*)").Groups.Item(1).ToString ' id de recompense
        Dim Webclient_GET_Items_item_id_Gates = Regex.Match(WebClient_Data, "gate_id=\""([^\""]*)").Groups.Item(1).ToString ' id de la gg sur laquelle il y a eu la recompense
        Dim Webclient_GET_Items_spins = Regex.Match(WebClient_Data, "spins=\""([^\""]*)").Groups.Item(1).ToString ' nombre de spins effectuer pour ce spin
        Dim Webclient_GET_Items_amount = Regex.Match(WebClient_Data, "amount=\""([^\""]*)").Groups.Item(1).ToString ' quantité de recompense
        Dim Webclient_GET_Items_date = Regex.Match(WebClient_Data, "date=\""([^\""]*)").Groups.Item(1).ToString ' date de recompense
        Dim Webclient_GET_Items_part_id = Regex.Match(WebClient_Data, "part_id=\""([^\""]*)").Groups.Item(1).ToString ' state de la GG > in progress < Finsished
        Dim Webclient_GET_Items_part_id_duplicate = Regex.Match(WebClient_Data, "duplicate=\""([^\""]*)").Groups.Item(1).ToString ' Si on obtient un Multiplicateur a la place d'une part de GG 
        Dim Webclient_GET_Items_part_multiplier_used = Regex.Match(WebClient_Data, "multiplier_used=\""([^\""]*)").Groups.Item(1).ToString ' Le nombre de Multiplicateur utilisé 
        Dim Webclient_GET_Items_part_multiplier_amount = Regex.Match(WebClient_Data, "multiplier_amount=\""([^\""]*)").Groups.Item(1).ToString ' la quantité de ressources Obtenu via le mutliplicateur

        If Webclient_GET_Items_amount_counter = Nothing Then
        Else Webclient_GET_Items_amount_counter = CStr(Webclient_GET_Items_amount)
        End If

        If Webclient_GET_Items_part_multiplier_amount_counter = Nothing Then
        Else Webclient_GET_Items_part_multiplier_amount_counter = CStr(Webclient_GET_Items_part_multiplier_amount)
        End If

        If Webclient_GET_Items_amount_counter = Nothing AndAlso Webclient_GET_Items_part_multiplier_amount_counter = Nothing Then
        Else Webclient_GET_Items_amount_counter_TTT_Webclient_GET_Items_part_multiplier_amount_counter_counterStrike = Webclient_GET_Items_amount_counter + Webclient_GET_Items_part_multiplier_amount_counter
        End If

        Console.WriteLine(" -------------------- ")
        Console.WriteLine("Item_type : " + Webclient_GET_Items_type)
        Console.WriteLine("item_id : " + Webclient_GET_Items_item_id)
        Console.WriteLine("Items_Spin : " + Webclient_GET_Items_spins)
        Console.WriteLine("Items_date : " + Webclient_GET_Items_date)
        Console.WriteLine("Items_part_id : " + Webclient_GET_Items_part_id)
        Console.WriteLine("Items_duplicate : " + Webclient_GET_Items_part_id_duplicate)
        Console.WriteLine("Items_multiplier_used : " + Webclient_GET_Items_part_multiplier_used)
        Try
            Console.WriteLine("Items_amount : " + Webclient_GET_Items_amount)
            Console.WriteLine("Items_multiplier_amount : " + CStr(Webclient_GET_Items_part_multiplier_amount))
            Console.WriteLine("Items_amount_duplicate : " + (Webclient_GET_Items_amount_counter + Webclient_GET_Items_part_multiplier_amount_counter))
        Catch
            Console.WriteLine("Aucun Multiplicateur Assignée a ce spin")
        End Try
        Console.WriteLine(" -------------------- ")

        If Webclient_GET_Items_date = Nothing Then
            Form_Tools.DATE_REMAINING.Text = "Reload your account, your dosid is broken"
        Else Form_Tools.DATE_REMAINING.Text = Webclient_GET_Items_date + " Done."
        End If

        If Webclient_GET_Items_item_id_Gates = Nothing Then
        ElseIf Webclient_GET_Items_item_id_Gates = "1" Then
            GalaxyGates_Name = "alpha"
        ElseIf Webclient_GET_Items_item_id_Gates = "2" Then
            GalaxyGates_Name = "beta"
        ElseIf Webclient_GET_Items_item_id_Gates = "3" Then
            GalaxyGates_Name = "gamma"
        ElseIf Webclient_GET_Items_item_id_Gates = "4" Then
            GalaxyGates_Name = "delta"
        ElseIf Webclient_GET_Items_item_id_Gates = "5" Then
            GalaxyGates_Name = "epsilon"
        ElseIf Webclient_GET_Items_item_id_Gates = "6" Then
            GalaxyGates_Name = "zeta"
        ElseIf Webclient_GET_Items_item_id_Gates = "7" Then
            GalaxyGates_Name = "kappa"
        ElseIf Webclient_GET_Items_item_id_Gates = "8" Then
            GalaxyGates_Name = "lambda"
        ElseIf Webclient_GET_Items_item_id_Gates = "13" Then
            GalaxyGates_Name = "hades"
        ElseIf Webclient_GET_Items_item_id_Gates = "19" Then
            GalaxyGates_Name = "kuiper"
        ElseIf Webclient_GET_Items_item_id_Gates = "12" Then
            GalaxyGates_Name = "chronos"
        End If

        If Webclient_GET_Items_part_multiplier_amount <> Nothing Then
            Module_control_control_lang = 1
        End If

        If Webclient_GET_Items_type = "image/x-icon" Then
            Form_Tools.TextBox_WinGGS.Text = ""
            Form_Tools.DATE_REMAINING.Text = "Reload your account, your dosid is broken"
            Exit Function
        End If

        If Module_control_control_lang = 1 Then

            If Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "2" Then
                Form_Tools.Label_MCB25_Earned.Text = Val(Form_Tools.Label_MCB25_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_MCB25_Earned.Text = Val(Form_Tools.Label_MCB25_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "MCB-25"

            ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "3" Then
                Form_Tools.Label_MCB50_Earned.Text = Val(Form_Tools.Label_MCB50_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_MCB50_Earned.Text = Val(Form_Tools.Label_MCB50_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "MCB-50"

            ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "4" Then
                Form_Tools.Label_UCB100_Earned.Text = Val(Form_Tools.Label_UCB100_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_UCB100_Earned.Text = Val(Form_Tools.Label_UCB100_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "UCB-100"

            ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "5" Then
                Form_Tools.Label_SAB50_Earned.Text = Val(Form_Tools.Label_SAB50_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_SAB50_Earned.Text = Val(Form_Tools.Label_SAB50_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "SAB-50"

            ElseIf Webclient_GET_Items_type = "ore" Then
                Form_Tools.Label_Xenomit_Earned.Text = Val(Form_Tools.Label_Xenomit_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_Xenomit_Earned.Text = Val(Form_Tools.Label_Xenomit_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "Xenomit"

            ElseIf Webclient_GET_Items_type = "nanohull" Then
                Form_Tools.Label_Nanohull_Earned.Text = Val(Form_Tools.Label_Nanohull_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_Nanohull_Earned.Text = Val(Form_Tools.Label_Nanohull_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "Nanohull"

            ElseIf Webclient_GET_Items_type = "logfile" Then
                Form_Tools.Label_Logfile_Earned.Text = Val(Form_Tools.Label_Logfile_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_Logfile_Earned.Text = Val(Form_Tools.Label_Logfile_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "Logfile"

            ElseIf Webclient_GET_Items_type = "rocket" Then
                Form_Tools.Label_PLT2021_Earned.Text = Val(Form_Tools.Label_PLT2021_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_PLT2021_Earned.Text = Val(Form_Tools.Label_PLT2021_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "PLT-2021"

            ElseIf Webclient_GET_Items_type = "voucher" Then
                Form_Tools.Label_Mine_Earned.Text = Val(Form_Tools.Label_Mine_Earned.Text) + Webclient_GET_Items_amount
                Form_Tools.Label_Mine_Earned.Text = Val(Form_Tools.Label_Mine_Earned.Text) + Webclient_GET_Items_amount
                Spins_reward = "Mine"

            Else

                If Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "2" Then
                    Form_Tools.Label_MCB25_Earned.Text = Val(Form_Tools.Label_MCB25_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "MCB-25"

                ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "3" Then
                    Form_Tools.Label_MCB50_Earned.Text = Val(Form_Tools.Label_MCB50_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "MCB-50"

                ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "4" Then
                    Form_Tools.Label_UCB100_Earned.Text = Val(Form_Tools.Label_UCB100_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "UCB-100"

                ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "5" Then
                    Form_Tools.Label_SAB50_Earned.Text = Val(Form_Tools.Label_SAB50_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "SAB-50"

                ElseIf Webclient_GET_Items_type = "ore" Then
                    Form_Tools.Label_Xenomit_Earned.Text = Val(Form_Tools.Label_Xenomit_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "Xenomit"

                ElseIf Webclient_GET_Items_type = "nanohull" Then
                    Form_Tools.Label_Nanohull_Earned.Text = Val(Form_Tools.Label_Nanohull_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "Nanohull"

                ElseIf Webclient_GET_Items_type = "logfile" Then
                    Form_Tools.Label_Logfile_Earned.Text = Val(Form_Tools.Label_Logfile_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "Logfile"

                ElseIf Webclient_GET_Items_type = "rocket" Then
                    Form_Tools.Label_PLT2021_Earned.Text = Val(Form_Tools.Label_PLT2021_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "PLT-2021"

                ElseIf Webclient_GET_Items_type = "voucher" Then
                    Form_Tools.Label_Mine_Earned.Text = Val(Form_Tools.Label_Mine_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "Mine"
                End If
            End If


            If Webclient_GET_Items_type = "part" Then
                If Webclient_GET_Items_part_id_duplicate <> Nothing Then
                    If Autorize_ABG = 1 Then
                        Form_Tools.TextBox_WinGGS.Text = vbNewLine + "[ABG] :   " + Webclient_GET_Items_amount + " Multiplier   ◆" + Form_Tools.TextBox_WinGGS.Text
                    Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + Webclient_GET_Gates_name + " :   " + Webclient_GET_Items_amount + " Multiplier   ◆" + Form_Tools.TextBox_WinGGS.Text
                    End If
                    Exit Function

                Else

                    View(GalaxyGates_id:=Webclient_GET_Items_item_id_Gates, GalaxyGates_Name:=GalaxyGates_Name)

                    If Webclient_GET_Items_part_multiplier_used = Nothing Then
                        Form_Tools.TextBox_WinGGS.Text = vbNewLine + GalaxyGates_Name + " :   Part N° : " + Webclient_GET_Items_part_id + " Added" + Form_Tools.TextBox_WinGGS.Text

                    Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + GalaxyGates_Name + " :   Multiple Part Added" + Form_Tools.TextBox_WinGGS.Text
                    End If

                    Load()

                    Exit Function
                End If
            End If
        End If

        If Webclient_GET_Items_part_multiplier_amount <> Nothing Then
            If Autorize_ABG = 1 Then
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + "    [ABG] :   " + Webclient_GET_Items_amount + " + " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + "   " + GalaxyGates_Name + " :   " + Webclient_GET_Items_amount + " + " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            End If
        Else
            If Autorize_ABG = 1 Then
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + " [ABG] :   " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + GalaxyGates_Name + " :   " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            End If

        End If

        Form_Tools.TextBox_total_spinned.Text = Val(Form_Tools.TextBox_total_spinned.Text) + 1


    End Function

End Class
