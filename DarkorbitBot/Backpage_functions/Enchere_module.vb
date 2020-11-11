Imports System.Net

Public Class Enchere_module
    Public Shared WebClient_POST As New WebClient

    Public Shared Sub Load()


        WebClient_POST.Headers.Clear()
        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalAuction")
        Console.WriteLine(WebClient_Data)

    End Sub


End Class
