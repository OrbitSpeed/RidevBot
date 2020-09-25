Imports System.Net
Imports System.Text.RegularExpressions

Public Class Skylab_module

    Public Shared WebClient_POST As New System.Net.WebClient

    Public Shared Function Load()

        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils_module.dosid};") 'POST / GET socket Information
        Dim WebClient_Data_Skylab = WebClient_POST.DownloadString("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalSkylab")

        Dim WebClient_Data_Skylab_All_Items = Regex.Match(WebClient_Data_Skylab, "<div id=""(?s)((?:[^\n][\n]?)+)view_seprom_maximal_number"">(?s)((?:[^\n][\n]?)+)<\/div>").Groups.Item(1).ToString
        Dim WebClient_Data_Skylab_All_Items_2 = Regex.Match(WebClient_Data_Skylab, "<div id=""(?s)((?:[^\n][\n]?)+)view_seprom_maximal_number"">(?s)((?:[^\n][\n]?)+)<\/div>").Groups.Item(2).ToString
        Dim WebClient_Elements_Assembly = WebClient_Data_Skylab_All_Items + WebClient_Data_Skylab_All_Items_2
        ' Console.WriteLine(WebClient_Elements_Assembly)
        Dim WebClient_Data_Skylab_prometium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 2).ToString
        Dim WebClient_Data_Skylab_endurium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 4).ToString
        Dim WebClient_Data_Skylab_terbium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 6).ToString
        Dim WebClient_Data_Skylab_prometid_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 8).ToString
        Dim WebClient_Data_Skylab_duranium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 10).ToString
        Dim WebClient_Data_Skylab_xenomit_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 12).ToString
        Dim WebClient_Data_Skylab_promerium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 14).ToString
        Dim WebClient_Data_Skylab_seprom_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 16).ToString

    End Function

End Class
