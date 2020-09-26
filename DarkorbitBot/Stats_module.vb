

Imports System.Net

Public Class Stats_module

    Public Shared WebClient_POST As New System.Net.WebClient

    Public Shared Function Load()

        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils_module.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        Console.WriteLine(WebClient_Data)
        '  User[.]Parameters(?s)((?:[^\n][\n]?)+)

    End Function


End Class
