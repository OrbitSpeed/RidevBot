Imports System.Net
Imports System.Text.RegularExpressions

Public Class GalaxyGates

    Public Shared GalaxyGates_Name As String
    Public Shared GalaxyGates_id As String
    Public Shared Table_Chronos As String = """.*) >"
    Public Shared Table_Load As String = """.*) \/>"

    Public Shared WebClient_POST As New System.Net.WebClient

    Public Shared Function Load()

        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};")
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)

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


    Public Shared Function View()

        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};")
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
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GalaxyGates_id + "&type=full")

    End Function


End Class
