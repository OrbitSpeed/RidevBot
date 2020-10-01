Imports System.Net
Imports System.Text.RegularExpressions

Public Class Palladium_module
    Public Shared WebClient_POST As New System.Net.WebClient

    Public Shared Function Load()

        WebClient_POST.Headers.Clear()
        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<div id=""header_main"">.*?([\s\S]*?)<div id=""hangar_slot_arrow""><\/div>").Groups.Item(1).ToString
        Dim match As Match = Regex.Match(WebClient_Data, "<div id=""header_main"">.*?([\s\S]*?)<div id=""hangar_slot_arrow""><\/div>")
        match = match.NextMatch()

        '  Dim WebClient_GET_All_elements_Hangar = Regex.Match(WebClient_GET_All_elements, "href="".*?([\s\S]*?)<\/a>").Groups(1)
        '  Console.WriteLine(WebClient_GET_All_elements_Hangar)

        Dim value As String = "href="".*?([\s\S]*?)<\/a>"
        Dim WebClient_GET_All_elements_Hangar As Match = Regex.Match(WebClient_GET_All_elements, value)

        If (WebClient_GET_All_elements_Hangar.Success) Then
            Dim key As String = WebClient_GET_All_elements_Hangar.Groups(2).Value
            Console.WriteLine(key)
        End If

    End Function




End Class
