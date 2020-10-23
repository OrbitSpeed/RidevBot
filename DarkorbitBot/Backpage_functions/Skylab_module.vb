Imports System.Net
Imports System.Text.RegularExpressions

Public Class Skylab_module

    Public Shared Socket As New System.Net.WebClient

    Public Shared Function Load()

        Socket.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data_Skylab = Socket.DownloadString("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalSkylab")
        'Console.WriteLine(WebClient_Data_Skylab)

        For Each Data As Match In Regex.Matches(WebClient_Data_Skylab, "<br \/>([^""]*)<\/div>")
            Console.WriteLine("--")
            Console.WriteLine(Data.Value)
            Console.WriteLine("--")

            If String.IsNullOrWhiteSpace(Data.Value) Then
                Console.WriteLine("null")
            Else
                Console.WriteLine("not null")
                Console.WriteLine(Data.ToString)
                Console.WriteLine("------")
                Console.WriteLine(Data.ToString.Replace(" ", ""))
            End If
        Next

        'Pour récup max nombre : maximal_number\">([^\"].*?)<\/div>

        'Dim WebClient_Data_Skylab_All_Items = Regex.Match(WebClient_Data_Skylab, "<div id=""(?s)((?:[^\n][\n]?)+)view_seprom_maximal_number"">(?s)((?:[^\n][\n]?)+)<\/div>").Groups.Item(1).ToString
        'Dim WebClient_Data_Skylab_All_Items_2 = Regex.Match(WebClient_Data_Skylab, "<div id=""(?s)((?:[^\n][\n]?)+)view_seprom_maximal_number"">(?s)((?:[^\n][\n]?)+)<\/div>").Groups.Item(2).ToString
        'Dim WebClient_Elements_Assembly = WebClient_Data_Skylab_All_Items + WebClient_Data_Skylab_All_Items_2
        '' Console.WriteLine(WebClient_Elements_Assembly)

        'Dim Skylab_Array As New List(Of String)
        'For Each Data As Match In Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>")
        '    If Data.
        'Next


        'Dim WebClient_Data_Skylab_prometium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>")(2).ToString
        'Dim WebClient_Data_Skylab_endurium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>")(4).ToString
        'Dim WebClient_Data_Skylab_terbium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 6).ToString
        'Dim WebClient_Data_Skylab_prometid_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 8).ToString
        'Dim WebClient_Data_Skylab_duranium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 10).ToString
        'Dim WebClient_Data_Skylab_xenomit_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 12).ToString
        'Dim WebClient_Data_Skylab_promerium_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 14).ToString
        'Dim WebClient_Data_Skylab_seprom_max = Regex.Matches(WebClient_Data_Skylab, "<div class.*?<\/div>", 16).ToString

    End Function

End Class
