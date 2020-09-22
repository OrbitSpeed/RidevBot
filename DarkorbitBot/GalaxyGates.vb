Imports System.Net
Imports System.Text.RegularExpressions

Public Class GalaxyGates

    Public Shared GGNumber_loaded = Form_Tools.ComboBox_autospin.Text
    Public Shared GGNumber_loaded_cookies


    Public Shared WebClient_Data
    Public Shared WebClient_POST
    Public Shared WebClient_GET_All_elements
    Public Shared WebClient_GET_All_elements_Alpha
    Public Shared WebClient_GET_All_elements_Beta
    Public Shared WebClient_GET_All_elements_Gamma

    Public Shared WebClient_GET_currentWave
    Public Shared WebClient_GET_totalWave
    Public Shared WebClient_GET_livesLeft
    Public Shared WebClient_GET_current_part
    Public Shared WebClient_GET_total_part
    Public Shared WebClient_GET_lifePrice

    Public Shared Function GalaxyGates_Load()

        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};")
        WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)

        WebClient_GET_All_elements_Alpha = Regex.Match(WebClient_Data, "<gate (.*id=""alpha"".*) \/>").Groups.Item(1).ToString 'A
        Dim WebClient_GET_current_part_Alpha = Regex.Match(WebClient_GET_All_elements_Alpha, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Alpha = Regex.Match(WebClient_GET_All_elements_Alpha, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_alpha.Text = "Alpha [ " + WebClient_GET_current_part_Alpha + " / " + WebClient_GET_total_part_Alpha

        WebClient_GET_All_elements_Beta = Regex.Match(WebClient_Data, "<gate (.*id=""beta"".*) \/>").Groups.Item(1).ToString 'A
        Dim WebClient_GET_current_part_Beta = Regex.Match(WebClient_GET_All_elements_Beta, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Beta = Regex.Match(WebClient_GET_All_elements_Beta, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_alpha.Text = "Beta [ " + WebClient_GET_current_part_Beta + " / " + WebClient_GET_total_part_Beta

        WebClient_GET_All_elements_Gamma = Regex.Match(WebClient_Data, "<gate (.*id=""gamma"".*) \/>").Groups.Item(1).ToString 'A
        Dim WebClient_GET_current_part_Gamma = Regex.Match(WebClient_GET_All_elements_Gamma, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Dim WebClient_GET_total_part_Gamma = Regex.Match(WebClient_GET_All_elements_Gamma, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        Form_Tools.Label_alpha.Text = "Gamma [ " + WebClient_GET_current_part_Gamma + " / " + WebClient_GET_total_part_Gamma

        If GGNumber_loaded = "alpha" Then 'Or "34"
            GGNumber_loaded_cookies = "1"
        ElseIf GGNumber_loaded = "beta" Then 'Or "48"
            GGNumber_loaded_cookies = "2"
        ElseIf GGNumber_loaded = "gamma" Then 'Or "82"
            GGNumber_loaded_cookies = "3"
        ElseIf GGNumber_loaded = "delta" Then 'Or "128"
            GGNumber_loaded_cookies = "4"
        ElseIf GGNumber_loaded = "epsilon" Then 'Or "99"
            GGNumber_loaded_cookies = "5"
        ElseIf GGNumber_loaded = "zeta" Then 'Or "111"
            GGNumber_loaded_cookies = "6"
        ElseIf GGNumber_loaded = "kappa" Then 'Or "120"
            GGNumber_loaded_cookies = "7"
        ElseIf GGNumber_loaded = "lambda" Then 'or 45
            GGNumber_loaded_cookies = "8"
        ElseIf GGNumber_loaded = "chronos" Then 'Or "21"
            GGNumber_loaded_cookies = "12"
        ElseIf GGNumber_loaded = "hades" Then 'or 45
            GGNumber_loaded_cookies = "13"
        ElseIf GGNumber_loaded = "kuiper" Then 'Or "100"
            GGNumber_loaded_cookies = "19"
        End If
    End Function


    Public Shared Function Alpha()

        Form_Tools.ComboBox_autospin.Text = "Alpha"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Beta()

        Form_Tools.ComboBox_autospin.Text = "Beta"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Gamma()

        Form_Tools.ComboBox_autospin.Text = "Gamma"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Delta()

        Form_Tools.ComboBox_autospin.Text = "Delta"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Epsilon()

        Form_Tools.ComboBox_autospin.Text = "Epsilon"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Zeta()

        Form_Tools.ComboBox_autospin.Text = "Zeta"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Kappa()

        Form_Tools.ComboBox_autospin.Text = "Kappa"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Lambda()

        Form_Tools.ComboBox_autospin.Text = "Lambda"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Hades()

        Form_Tools.ComboBox_autospin.Text = "Hades"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Kuiper()

        Form_Tools.ComboBox_autospin.Text = "Kuiper"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function Chronos()

        Form_Tools.ComboBox_autospin.Text = "Chronos"
        State_and_Prepared_Gates()
        Form_Tools.WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=" + GGNumber_loaded_cookies + "&type=full")

    End Function

    Public Shared Function State_and_Prepared_Gates()


        WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<gate (.*id=""" + Form_Tools.ComboBox_autospin.Text + """.*) >").Groups.Item(1).ToString
        WebClient_GET_currentWave = Regex.Match(WebClient_GET_All_elements, "currentWave="".*?([\s\S]*?)""").Groups.Item(1).ToString
        WebClient_GET_totalWave = Regex.Match(WebClient_GET_All_elements, "totalWave="".*?([\s\S]*?)""").Groups.Item(1).ToString
        WebClient_GET_livesLeft = Regex.Match(WebClient_GET_All_elements, "livesLeft="".*?([\s\S]*?)""").Groups.Item(1).ToString
        WebClient_GET_current_part = Regex.Match(WebClient_GET_All_elements, "current="".*?([\s\S]*?)""").Groups.Item(1).ToString
        WebClient_GET_total_part = Regex.Match(WebClient_GET_All_elements, "total="".*?([\s\S]*?)""").Groups.Item(1).ToString
        WebClient_GET_lifePrice = Regex.Match(WebClient_GET_All_elements, "lifePrice="".*?([\s\S]*?)""").Groups.Item(1).ToString

        Form_Tools.INFO_WAVE_GG_LABEL.Text = "Wave : " + WebClient_GET_currentWave + " / " + WebClient_GET_totalWave
        Form_Tools.INFO_LIVES_LEFT_GG_LABEL.Text = "Lives left : " + WebClient_GET_livesLeft
        Form_Tools.INFO_PART_GG_LABEL.Text = "Part : " + WebClient_GET_current_part + " / " + WebClient_GET_total_part

        If WebClient_GET_All_elements.Contains("state=""in_progress""") Then
            ' LA GG N'EST PAS COMPLETE
        Else ' LA GG EST COMPLETE
        End If

        If WebClient_GET_All_elements.Contains("prepared=""1""") Then
            Form_Tools.INFO_ON_MAP_GG_LABEL.Text = "On Map : 1"
        Else Form_Tools.INFO_ON_MAP_GG_LABEL.Text = "On Map : 0"
        End If

    End Function


End Class
