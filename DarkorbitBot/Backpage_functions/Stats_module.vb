Imports System.Net
Imports System.Net.Http
Imports System.Net.Sockets
Imports System.Text.RegularExpressions

Public Class Stats_module

    Public Shared WebClient_GET_Ship_compagny_reg As String
    Public Shared WebClient_GET_Uridium As String
    Public Shared WebClient_GET_Credit As String
    Public Shared WebClient_GET_Honneur As String
    Public Shared WebClient_GET_Honneur_reg As String
    Public Shared WebClient_GET_Exp As String
    Public Shared WebClient_GET_Exp_reg As String
    Public Shared WebClient_GET_Level As String
    Public Shared WebClient_GET_Level_reg As String
    Public Shared WebClient_GET_ID As String
    Public Shared WebClient_GET_ID_reg As String
    Public Shared WebClient_GET_Ship_model As String
    Public Shared WebClient_GET_Ship_model_reg As String
    Public Shared WebClient_GET_Ship_compagny As String
    Public Shared WebClient_GET_Rank As String
    Public Shared WebClient_GET_Rank_reg As String

    Public Shared WebClient_POST As New WebClient
    Private Shared searching As Boolean = False

    Public Shared Sub Load()
        AddHandler WebClient_POST.DownloadStringCompleted, AddressOf WebClient_POST_DownloadFinished

        Console.WriteLine("Load - Stats Module")
        If searching = False Then
            searching = True
            WebClient_POST.Headers.Clear()
            WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
            WebClient_POST.DownloadStringAsync(New Uri("https://" + Utils.server + ".darkorbit.com/indexInternal.es"))
            Console.WriteLine("DownloadStringAsync - Stats Module")
        Else
            Console.WriteLine("Load NOT STARTED PREVENTED - Stats module")
        End If

    End Sub

    Private Shared Sub WebClient_POST_DownloadFinished(sender As Object, e As DownloadStringCompletedEventArgs)

        If searching = True Then
            Console.WriteLine("WebPostFinished - Stats Module")
            Dim WebClient_Data = e.Result

            'Debug only
            'Clipboard.SetText(WebClient_Data)

            Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "User[.]Parameters(.*)}").Groups.Item(1).ToString

            WebClient_GET_Uridium = Regex.Match(WebClient_Data, """uridium"":.*?([\s\S]*?),").Groups.Item(1).ToString
            WebClient_GET_Credit = Regex.Match(WebClient_Data, """credits"":.*?([\s\S]*?)}").Groups.Item(1).ToString
            WebClient_GET_Honneur = Regex.Match(WebClient_Data, "header_top_hnr.*?([\s\S]*?)<\/span>").Groups.Item(1).ToString
            WebClient_GET_Honneur_reg = Regex.Match(WebClient_GET_Honneur, "<span>(.*)").Groups.Item(1).ToString.Replace("</span>", "")
            WebClient_GET_Exp = Regex.Match(WebClient_Data, "header_top_exp.*?([\s\S]*?)<\/span>").Groups.Item(1).ToString
            WebClient_GET_Exp_reg = Regex.Match(WebClient_GET_Exp, "<span>(.*)").Groups.Item(1).ToString.Replace("</span>", "")
            WebClient_GET_Level = Regex.Match(WebClient_Data, "header_top_level.*?([\s\S]*?)<\/span>").Groups.Item(1).ToString
            WebClient_GET_Level_reg = Regex.Match(WebClient_GET_Level, "<span>(.*)").Groups.Item(1).ToString.Replace("</span>", "")
            WebClient_GET_ID = Regex.Match(WebClient_Data, "header_top_id.*?([\s\S]*?)<\/span>").Groups.Item(1).ToString
            WebClient_GET_ID_reg = Regex.Match(WebClient_GET_ID, "<span>(.*)").Groups.Item(1).ToString.Replace("</span>", "")
            WebClient_GET_Ship_model = Regex.Match(WebClient_Data, "header_ship.*?([\s\S]*?)"">").Groups.Item(1).ToString
            WebClient_GET_Ship_model_reg = Regex.Match(WebClient_GET_Ship_model, "model(.*)[.]").Groups.Item(1).ToString
            WebClient_GET_Ship_compagny = Regex.Match(WebClient_Data, "companyLogo.*?([\s\S]*?)<\/div>").Groups.Item(1).ToString
            WebClient_GET_Ship_compagny_reg = Regex.Match(WebClient_GET_Ship_compagny, "companyLogoSmall_(.*)"">").Groups.Item(1).ToString
            WebClient_GET_Rank = Regex.Match(WebClient_Data, "userRankIcon.*?([\s\S]*?)>").Groups.Item(1).ToString
            WebClient_GET_Rank_reg = Regex.Match(WebClient_GET_Rank, "rank_(.*)[.]").Groups.Item(1).ToString

            Form_Tools.TextBox_uridiumCurrent.Text = WebClient_GET_Uridium
            Form_Tools.TextBox_creditCurrent.Text = WebClient_GET_Credit
            Form_Tools.TextBox_honorCurrent.Text = WebClient_GET_Honneur_reg
            Form_Tools.TextBox_experienceCurrent.Text = WebClient_GET_Exp_reg
            Form_Tools.TextBox_LevelCurrent.Text = WebClient_GET_Level_reg
            'Form_Tools.TextBox_RPCurrent.Text = WebClient_GET_Level

            'WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalHallofFame&view=dailyRank")

            Console.WriteLine("Uridium : " + WebClient_GET_Uridium)
            Console.WriteLine("Credit : " + WebClient_GET_Credit)
            Console.WriteLine("Honnor : " + WebClient_GET_Honneur_reg)
            Console.WriteLine("Experience : " + WebClient_GET_Exp_reg)
            Console.WriteLine("Level : " + WebClient_GET_Level_reg)
            Console.WriteLine("ID : " + WebClient_GET_ID_reg)
            Console.WriteLine("Ship_model : " + WebClient_GET_Ship_model_reg)
            Console.WriteLine("Compagny : " + WebClient_GET_Ship_compagny_reg)
            Console.WriteLine("Rank : " + WebClient_GET_Rank_reg)

            Form_Tools.PictureBox16.ImageLocation = ("https://darkorbit-22.bpsecure.com/do_img/global/header/ships/model" + WebClient_GET_Ship_model_reg + ".png")
            Form_Tools.PictureBox_grade.ImageLocation = ("https://darkorbit-22.bpsecure.com/do_img/global/ranks/rank_" + WebClient_GET_Rank_reg + ".png")

            Form_Tools.Button_ResetStats.Enabled = True
            Form_Tools.Button_Refresh_Stats.Enabled = True
        End If
        searching = False
    End Sub
End Class
