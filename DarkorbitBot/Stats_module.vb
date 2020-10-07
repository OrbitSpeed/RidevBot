Imports System.Net
Imports System.Text.RegularExpressions

Public Class Stats_module

    Public Shared WebClient_GET_Ship_compagny_reg
    Public Shared WebClient_GET_Uridium
    Public Shared WebClient_GET_Credit
    Public Shared WebClient_GET_Honneur
    Public Shared WebClient_GET_Honneur_reg
    Public Shared WebClient_GET_Exp
    Public Shared WebClient_GET_Exp_reg
    Public Shared WebClient_GET_Level
    Public Shared WebClient_GET_Level_reg
    Public Shared WebClient_GET_ID
    Public Shared WebClient_GET_ID_reg
    Public Shared WebClient_GET_Ship_model
    Public Shared WebClient_GET_Ship_model_reg
    Public Shared WebClient_GET_Ship_compagny

    Public Shared WebClient_POST As New System.Net.WebClient

    Public Shared Function Load()

        WebClient_POST.Headers.Clear()
        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

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


        Console.WriteLine("Uridium : " + WebClient_GET_Uridium)
        Console.WriteLine("Credit : " + WebClient_GET_Credit)
        Console.WriteLine("Honnor : " + WebClient_GET_Honneur_reg)
        Console.WriteLine("Experience : " + WebClient_GET_Exp_reg)
        Console.WriteLine("Level : " + WebClient_GET_Level_reg)
        Console.WriteLine("ID : " + WebClient_GET_ID_reg)
        Console.WriteLine("Ship_model : " + WebClient_GET_Ship_model_reg)
        Console.WriteLine("Compagny : " + WebClient_GET_Ship_compagny_reg)

    End Function


End Class
