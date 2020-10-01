Imports System.Net
Imports System.Text.RegularExpressions

Public Class GalaxyGates_module

    Public Shared GalaxyGates_Name As String
    Public Shared Spins_reward As String
    Public Shared GalaxyGates_id As String
    Public Shared GalaxyGates_id_spin As String

    Public Shared Spin_Sample As Object
    Public Shared Exit_Spin As Object

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

    Public Shared Multiplicateur_activated As Object = 0

    Public Shared WebClient_POST As New System.Net.WebClient


    Public Shared Sub Load()

        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        Console.WriteLine(WebClient_Data)

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

    End Sub


    Public Shared Function View(ByVal GalaxyGates_id As String, ByVal GalaxyGates_Name As String)

        GalaxyGates_Name = GalaxyGates_Name.ToLower()

        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)

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

            Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GalaxyGates_id + "&type=full")

        Else

        End If


    End Function

    Public Shared Async Sub Spin(ByVal Spin_Sample)

        GalaxyGates_Name = Form_Tools.ComboBox_autospin.Text
        GalaxyGates_Name = GalaxyGates_Name.ToLower()

        If Not Form_Tools.ComboBox_autospin.Items.Contains(Form_Tools.ComboBox_autospin.Text) Then
            Form_Tools.ComboBox_autospin.Text = "alpha"
            Form_Tools.Button_stopSpin.PerformClick()
            Closing_Spinner()
            Exit Sub

        Else
            Form_Tools.Button_StartSpin.Enabled = False
            Form_Tools.Button_stopSpin.Enabled = True
            Form_Tools.ComboBox_autospin.Enabled = False

        End If

LABEL_BOUCLE:

        If Exit_Spin = 1 Then
            Closing_Spinner()
            Exit Sub

        Else Await Task.Delay(101)
        End If

        If Form_Tools.CheckBox_UseOnlyEE_GGS.Checked = True And Form_Tools.TextBox_ExtraEnergy_GGS.Text = "0" Then
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"No more Extra Energy left." + Form_Tools.TextBox_WinGGS.Text
            Closing_Spinner()
            Exit Sub

        ElseIf Val(Form_Tools.TextBox_uridiumGGS.Text.Replace(".", "")) < Val(Form_Tools.TextBox_uridiumtokeepGGS.Text.Replace(".", "")) And Form_Tools.CheckBox_UseOnlyEE_GGS.Checked = False Then
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"No more Uridium left." + Form_Tools.TextBox_WinGGS.Text
            Closing_Spinner()
            Exit Sub
        End If

        If GalaxyGates_Name = Nothing Then
        ElseIf GalaxyGates_Name = "abg" Then
            GalaxyGates_Name = "alpha"
            Autorize_ABG = "1"
            GalaxyGates_id = "1"
        ElseIf GalaxyGates_Name = "alpha" Then
            Autorize_ABG = "1"
            GalaxyGates_id = "1"
        ElseIf GalaxyGates_Name = "beta" Then
            Autorize_ABG = "1"
            GalaxyGates_id = "2"
        ElseIf GalaxyGates_Name = "gamma" Then
            Autorize_ABG = "1"
            GalaxyGates_id = "3"
        ElseIf GalaxyGates_Name = "delta" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "4"
        ElseIf GalaxyGates_Name = "epsilon" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "5"
        ElseIf GalaxyGates_Name = "zeta" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "6"
        ElseIf GalaxyGates_Name = "kappa" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "7"
        ElseIf GalaxyGates_Name = "lambda" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "8"
        ElseIf GalaxyGates_Name = "hades" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "13"
        ElseIf GalaxyGates_Name = "streuner" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "19"
        ElseIf GalaxyGates_Name = "chronos" Then
            Autorize_ABG = "0"
            GalaxyGates_id = "12"
        End If

        Dim PART_GG As String = Form_Tools.INFO_PART_GG_LABEL.Text
        Dim Result_PART_GG = Regex.Match(PART_GG, "Part :(.*)").Groups.Item(1).ToString
        Result_PART_GG = Result_PART_GG.Substring(1)
        If Result_PART_GG = "34 / 34" AndAlso GalaxyGates_Name = "alpha" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "48 / 48" AndAlso GalaxyGates_Name = "beta" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "82 / 82" AndAlso GalaxyGates_Name = "gamma" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "128 / 128" AndAlso GalaxyGates_Name = "delta" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "99 / 99" AndAlso GalaxyGates_Name = "epsilon" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "111 / 111" AndAlso GalaxyGates_Name = "zeta" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "120 / 120" AndAlso GalaxyGates_Name = "kappa" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "45 / 45" AndAlso GalaxyGates_Name = "lambda" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "45 / 45" AndAlso GalaxyGates_Name = "hades" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "100 / 100" AndAlso GalaxyGates_Name = "Streuner" Then
            PART_CHECKER = 1
        ElseIf Result_PART_GG = "21 / 21" AndAlso GalaxyGates_Name = "chronos" Then
            PART_CHECKER = 1
        Else
            PART_CHECKER = 0
        End If

        If PART_CHECKER = 1 Then
            Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates " + PART_GG_GG_Completed + " Completed." + Form_Tools.TextBox_WinGGS.Text

            If Form_Tools.INFO_ON_MAP_GG_LABEL.Text.Contains("1") Then
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates " + PART_GG_GG_Completed + " 2 / 2 Completed." + Form_Tools.TextBox_WinGGS.Text
                Closing_Spinner()
                Exit Sub

            Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates " + PART_GG_GG_Completed + " 1 / 2 Completed." + Form_Tools.TextBox_WinGGS.Text
            End If

            Dim Prepare_Gates_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&sid=" + Utils.dosid + "&action=setupGate&gateID=" + GalaxyGates_id)
            View(GalaxyGates_id, GalaxyGates_Name)
            Load()

            If Form_Tools.CheckBox_BuildOneAndStop.Checked = True Then
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"CheckBox_BuildOneAndStop are checked. " + Form_Tools.TextBox_WinGGS.Text
                Closing_Spinner()
                Exit Sub

            Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner reactivated." + Form_Tools.TextBox_WinGGS.Text
            End If

            PART_CHECKER = 0
        End If

        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=" + GalaxyGates_id + "&" + GalaxyGates_Name + "=1&sample=1&sample=1&multiplier=1")
        Form_Tools.TextBox_uridiumGGS.Text = Regex.Match(WebClient_Data, "<money>(.*)<\/money>").Groups.Item(1).ToString 'Uridium
        Form_Tools.TextBox_ExtraEnergy_GGS.Text = Regex.Match(WebClient_Data, "<samples>(.*)<\/samples>").Groups.Item(1).ToString 'Eextra energy
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

        If Not Webclient_GET_Items_amount_counter = Nothing AndAlso Not Webclient_GET_Items_part_multiplier_amount_counter = Nothing Then
            Webclient_GET_Items_amount_counter_TTT_Webclient_GET_Items_part_multiplier_amount_counter_counterStrike = Webclient_GET_Items_amount_counter + Webclient_GET_Items_part_multiplier_amount_counter
        End If

        Console.WriteLine(" -------------------- ")
        Console.WriteLine("Item_type : " + Webclient_GET_Items_type)
        Console.WriteLine("item_id : " + Webclient_GET_Items_item_id)
        Console.WriteLine("Items_Spin : " + Webclient_GET_Items_spins)
        Console.WriteLine("Items_date : " + Webclient_GET_Items_date)
        Console.WriteLine("Items_part_id : " + Webclient_GET_Items_part_id)
        Console.WriteLine("Items_duplicate : " + Webclient_GET_Items_part_id_duplicate)
        Console.WriteLine("Items_multiplier_used : " + Webclient_GET_Items_part_multiplier_used)
        Console.WriteLine("Items_amount : " + Webclient_GET_Items_amount)
        Console.WriteLine("Items_multiplier_amount : " + CStr(Webclient_GET_Items_part_multiplier_amount))
        Console.WriteLine("Items_amount_duplicate : " + (Webclient_GET_Items_amount_counter_TTT_Webclient_GET_Items_part_multiplier_amount_counter_counterStrike))

        If Webclient_GET_Items_date = Nothing Then
            Form_Tools.TextBox_WinGGS.Text = "Your dosid is broken"
            Form_Tools.DATE_REMAINING.Text = "Your dosid is broken"

            Form_Tools.Button_StartSpin.Enabled = True
            Form_Tools.Button_stopSpin.Enabled = False
            Form_Tools.ComboBox_autospin.Enabled = True
            Exit Sub
        Else Form_Tools.DATE_REMAINING.Text = Webclient_GET_Items_date + " Done."
        End If

        Dim GalaxyGates_Name_Get_Items As String
        If Webclient_GET_Items_item_id_Gates = Nothing Then
        ElseIf Webclient_GET_Items_item_id_Gates = "1" Then
            GalaxyGates_Name_Get_Items = "alpha"
        ElseIf Webclient_GET_Items_item_id_Gates = "2" Then
            GalaxyGates_Name_Get_Items = "beta"
        ElseIf Webclient_GET_Items_item_id_Gates = "3" Then
            GalaxyGates_Name_Get_Items = "gamma"
        ElseIf Webclient_GET_Items_item_id_Gates = "4" Then
            GalaxyGates_Name_Get_Items = "delta"
        ElseIf Webclient_GET_Items_item_id_Gates = "5" Then
            GalaxyGates_Name_Get_Items = "epsilon"
        ElseIf Webclient_GET_Items_item_id_Gates = "6" Then
            GalaxyGates_Name_Get_Items = "zeta"
        ElseIf Webclient_GET_Items_item_id_Gates = "7" Then
            GalaxyGates_Name_Get_Items = "kappa"
        ElseIf Webclient_GET_Items_item_id_Gates = "8" Then
            GalaxyGates_Name_Get_Items = "lambda"
        ElseIf Webclient_GET_Items_item_id_Gates = "13" Then
            GalaxyGates_Name_Get_Items = "hades"
        ElseIf Webclient_GET_Items_item_id_Gates = "19" Then
            GalaxyGates_Name_Get_Items = "Streuner"
        ElseIf Webclient_GET_Items_item_id_Gates = "12" Then
            GalaxyGates_Name_Get_Items = "chronos"
        End If

        If Webclient_GET_Items_part_multiplier_amount <> Nothing Then
            Multiplicateur_activated = 1
        Else Multiplicateur_activated = 0
        End If

        If Webclient_GET_Items_type = "image/x-icon" Then
            Form_Tools.TextBox_WinGGS.Text = "Your dosid is broken"
            Form_Tools.DATE_REMAINING.Text = "Your dosid is broken"

            Form_Tools.Button_StartSpin.Enabled = True
            Form_Tools.Button_stopSpin.Enabled = False
            Form_Tools.ComboBox_autospin.Enabled = True
            Exit Sub

        End If

        If Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "2" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_MCB25_Earned.Text = Val(Form_Tools.Label_MCB25_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_MCB25_Earned.Text = Val(Form_Tools.Label_MCB25_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "MCB-25"

        ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "3" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_MCB50_Earned.Text = Val(Form_Tools.Label_MCB50_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_MCB50_Earned.Text = Val(Form_Tools.Label_MCB50_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "MCB-50"

        ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "4" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_UCB100_Earned.Text = Val(Form_Tools.Label_UCB100_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_UCB100_Earned.Text = Val(Form_Tools.Label_UCB100_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "UCB-100"

        ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "5" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_SAB50_Earned.Text = Val(Form_Tools.Label_SAB50_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_SAB50_Earned.Text = Val(Form_Tools.Label_SAB50_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "SAB-50"

        ElseIf Webclient_GET_Items_type = "ore" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_Xenomit_Earned.Text = Val(Form_Tools.Label_Xenomit_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_Xenomit_Earned.Text = Val(Form_Tools.Label_Xenomit_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "Xenomit"

        ElseIf Webclient_GET_Items_type = "nanohull" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_Nanohull_Earned.Text = Val(Form_Tools.Label_Nanohull_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_Nanohull_Earned.Text = Val(Form_Tools.Label_Nanohull_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "Nanohull"

        ElseIf Webclient_GET_Items_type = "logfile" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_Logfile_Earned.Text = Val(Form_Tools.Label_Logfile_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_Logfile_Earned.Text = Val(Form_Tools.Label_Logfile_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "Logfile"

        ElseIf Webclient_GET_Items_type = "rocket" AndAlso Webclient_GET_Items_item_id = "3" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_PLT2021_Earned.Text = Val(Form_Tools.Label_PLT2021_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_PLT2021_Earned.Text = Val(Form_Tools.Label_PLT2021_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "PLT-2021"

        ElseIf Webclient_GET_Items_type = "rocket" AndAlso Webclient_GET_Items_item_id = "11" AndAlso Multiplicateur_activated = "1" Then
            Form_Tools.Label_Mine_Earned.Text = Val(Form_Tools.Label_Mine_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_Mine_Earned.Text = Val(Form_Tools.Label_Mine_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "ACM-1"

        ElseIf Webclient_GET_Items_type = "voucher" AndAlso Multiplicateur_activated = "1" Then '
            Form_Tools.Label_RepairCR_Earned.Text = Val(Form_Tools.Label_RepairCR_Earned.Text) + Webclient_GET_Items_amount
            Form_Tools.Label_RepairCR_Earned.Text = Val(Form_Tools.Label_RepairCR_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "Repair CR"

        ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "2" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_MCB25_Earned.Text = Val(Form_Tools.Label_MCB25_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "MCB-25"

        ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "3" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_MCB50_Earned.Text = Val(Form_Tools.Label_MCB50_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "MCB-50"

        ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "4" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_UCB100_Earned.Text = Val(Form_Tools.Label_UCB100_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "UCB-100"

        ElseIf Webclient_GET_Items_type = "battery" AndAlso Webclient_GET_Items_item_id = "5" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_SAB50_Earned.Text = Val(Form_Tools.Label_SAB50_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "SAB-50"

        ElseIf Webclient_GET_Items_type = "ore" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_Xenomit_Earned.Text = Val(Form_Tools.Label_Xenomit_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "Xenomit"

        ElseIf Webclient_GET_Items_type = "nanohull" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_Nanohull_Earned.Text = Val(Form_Tools.Label_Nanohull_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "Nanohull"

        ElseIf Webclient_GET_Items_type = "logfile" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_Logfile_Earned.Text = Val(Form_Tools.Label_Logfile_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "Logfile"

        ElseIf Webclient_GET_Items_type = "rocket" AndAlso Webclient_GET_Items_item_id = "3" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_PLT2021_Earned.Text = Val(Form_Tools.Label_PLT2021_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "PLT-2021"

        ElseIf Webclient_GET_Items_type = "rocket" AndAlso Webclient_GET_Items_item_id = "11" AndAlso Multiplicateur_activated = "0" Then
            Form_Tools.Label_Mine_Earned.Text = Val(Form_Tools.Label_Mine_Earned.Text) + Webclient_GET_Items_amount
            Spins_reward = "ACM-1"

        ElseIf Webclient_GET_Items_type = "voucher" AndAlso Multiplicateur_activated = "0" Then '
            Form_Tools.Label_RepairCR_Earned.Text = Val(Form_Tools.Label_RepairCR_Earned.Text) + Webclient_GET_Items_amount
                    Spins_reward = "Repair crédit"
                End If

        If Webclient_GET_Items_type = "part" Then
                If Webclient_GET_Items_part_id_duplicate <> Nothing Then
                    If Autorize_ABG = 1 Then
                        Form_Tools.TextBox_WinGGS.Text = vbNewLine + "[ABG] :   " + Webclient_GET_Items_amount + " Multiplier   ◆" + Form_Tools.TextBox_WinGGS.Text
                    Else
                        Form_Tools.TextBox_WinGGS.Text = vbNewLine + Webclient_GET_Gates_name + " :   " + Webclient_GET_Items_amount + " Multiplier   ◆" + Form_Tools.TextBox_WinGGS.Text
                    End If

                    If Spin_Sample = 1 Then
                        GoTo LABEL_BOUCLE
                    Else
                        Form_Tools.Button_StartSpin.Enabled = True
                        Form_Tools.Button_stopSpin.Enabled = False
                        Form_Tools.ComboBox_autospin.Enabled = True
                        Exit Sub
                    End If

                Else

                    View(Webclient_GET_Items_item_id_Gates, GalaxyGates_Name)

                    If Webclient_GET_Items_part_multiplier_used = Nothing Then
                        Form_Tools.TextBox_WinGGS.Text = vbNewLine + GalaxyGates_Name_Get_Items + " :   Part N° : " + Webclient_GET_Items_part_id + " Added" + Form_Tools.TextBox_WinGGS.Text
                    Else
                    Form_Tools.TextBox_WinGGS.Text = vbNewLine + GalaxyGates_Name_Get_Items + " :   Multiple Part Added" + Form_Tools.TextBox_WinGGS.Text
                End If

                    Load()

                    If Spin_Sample = 1 Then
                        GoTo LABEL_BOUCLE
                    Else
                        Form_Tools.Button_StartSpin.Enabled = True
                        Form_Tools.Button_stopSpin.Enabled = False
                        Form_Tools.ComboBox_autospin.Enabled = True
                        Exit Sub
                    End If

                End If
            End If

        If Webclient_GET_Items_part_multiplier_amount <> Nothing Then
            If Autorize_ABG = 1 Then
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + "    [ABG] :   " + Webclient_GET_Items_amount + " + " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + "   " + Webclient_GET_Gates_name + " :   " + Webclient_GET_Items_amount + " + " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            End If
        Else
            If Autorize_ABG = 1 Then
                Form_Tools.TextBox_WinGGS.Text = vbNewLine + " [ABG] :   " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            Else Form_Tools.TextBox_WinGGS.Text = vbNewLine + Webclient_GET_Gates_name + " :   " + Webclient_GET_Items_amount + " " + Spins_reward + Form_Tools.TextBox_WinGGS.Text
            End If

        End If

        Form_Tools.TextBox_total_spinned.Text = Val(Form_Tools.TextBox_total_spinned.Text) + 1

        If Spin_Sample = 1 Then
            GoTo LABEL_BOUCLE

        Else
            Form_Tools.Button_StartSpin.Enabled = True
            Form_Tools.Button_stopSpin.Enabled = False
            Form_Tools.ComboBox_autospin.Enabled = True

            Exit Sub
        End If


    End Sub

    Public Shared Function Closing_Spinner()

        Console.WriteLine("Autospinner deactivated.")

        Form_Tools.TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped. by stop" + Form_Tools.TextBox_WinGGS.Text

        Form_Tools.Button_StartSpin.Enabled = True
        Form_Tools.Button_stopSpin.Enabled = False
        Form_Tools.ComboBox_autospin.Enabled = True

    End Function


    Public Shared Async Sub PrepareGates()

        Dim GalaxyGates_id As String = Form_Tools.ComboBox_autospin.Text
        Dim PART_GG As String = Form_Tools.INFO_PART_GG_LABEL.Text

        Dim Result_PART_GG = Regex.Match(PART_GG, "Part :(.*)").Groups.Item(1).ToString
        Result_PART_GG = Result_PART_GG.Substring(1)
        If Result_PART_GG = "34 / 34" AndAlso GalaxyGates_id = "alpha" Then
            GalaxyGates_id = 1
        ElseIf Result_PART_GG = "48 / 48" AndAlso GalaxyGates_id = "beta" Then
            GalaxyGates_id = 2
        ElseIf Result_PART_GG = "82 / 82" AndAlso GalaxyGates_id = "gamma" Then
            GalaxyGates_id = 3
        ElseIf Result_PART_GG = "128 / 128" AndAlso GalaxyGates_id = "delta" Then
            GalaxyGates_id = 4
        ElseIf Result_PART_GG = "99 / 99" AndAlso GalaxyGates_id = "epsilon" Then
            GalaxyGates_id = 5
        ElseIf Result_PART_GG = "111 / 111" AndAlso GalaxyGates_id = "zeta" Then
            GalaxyGates_id = 6
        ElseIf Result_PART_GG = "120 / 120" AndAlso GalaxyGates_id = "kappa" Then
            GalaxyGates_id = 7
        ElseIf Result_PART_GG = "45 / 45" AndAlso GalaxyGates_id = "lambda" Then
            GalaxyGates_id = 8
        ElseIf Result_PART_GG = "45 / 45" AndAlso GalaxyGates_id = "hades" Then
            GalaxyGates_id = 13
        ElseIf Result_PART_GG = "100 / 100" AndAlso GalaxyGates_id = "kuiper" Then
            GalaxyGates_id = 19
        ElseIf Result_PART_GG = "21 / 21" AndAlso GalaxyGates_id = "chronos" Then
            GalaxyGates_id = 12
        Else
            GalaxyGates_id = 0
        End If

        If GalaxyGates_id = 0 Then
            'The GG is not full we go away 
            Form_Tools.Label1.Select()
            Dim data_PG = Color.FromArgb(20, 75, 158)
            Form_Tools.Button_PrepareGates.BackColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.Button_PrepareGates.BackColor = data_PG
            '---
            Dim data_T = Color.Black
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = data_T
            Await Task.Delay(300)
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = data_T
            Exit Sub
        End If

        Dim Prepare_Gates_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&sid=" + Utils.dosid + "&action=setupGate&gateID=" + GalaxyGates_id)
        Console.WriteLine(Prepare_Gates_Data)
        Dim Prepare_Gates_Data_Regex = Regex.Match(Prepare_Gates_Data, "error code="".*?([\s\S]*?)""")
        If Prepare_Gates_Data_Regex.Groups.Item(1).ToString = "gate_already_setup" Then
            'The gate is already on the map
            Console.WriteLine("The gate is already on the map")
            Form_Tools.Label1.Select()
            Dim data_PG = Color.FromArgb(20, 75, 158)
            Form_Tools.Button_PrepareGates.BackColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.Button_PrepareGates.BackColor = data_PG
            '---
            Dim data_Label = Color.Black
            Form_Tools.INFO_ON_MAP_GG_LABEL.ForeColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.INFO_ON_MAP_GG_LABEL.ForeColor = data_Label
            Await Task.Delay(300)
            Form_Tools.INFO_ON_MAP_GG_LABEL.ForeColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.INFO_ON_MAP_GG_LABEL.ForeColor = data_Label

        ElseIf Prepare_Gates_Data_Regex.Groups.Item(1).ToString = "not_enough_parts" Then
            'The gate is not full
            Console.WriteLine("The gate is not full")
            Form_Tools.Label1.Select()
            Dim data_PG = Color.FromArgb(20, 75, 158)
            Form_Tools.Button_PrepareGates.BackColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.Button_PrepareGates.BackColor = data_PG
            '---
            Dim data_T = Color.Black
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = data_T
            Await Task.Delay(300)
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = Color.Red
            Await Task.Delay(300)
            Form_Tools.INFO_PART_GG_LABEL.ForeColor = data_T
        Else
            'The gate is full and is placed
            Console.WriteLine("The gate is full and is placed")
            Form_Tools.Label1.Select()
            Dim data_PG = Color.FromArgb(20, 75, 158)
            Form_Tools.Button_PrepareGates.BackColor = Color.LimeGreen
            Await Task.Delay(300)
            Form_Tools.Button_PrepareGates.BackColor = data_PG
        End If
    End Sub

End Class
