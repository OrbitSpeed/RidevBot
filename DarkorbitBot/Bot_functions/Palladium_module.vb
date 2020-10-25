Imports System.Net
Imports System.Text.RegularExpressions

Public Class Palladium_module
    Public Shared ID As Capture
    Public Shared SD As String
    Public Shared Contains_Hangar
    Public Shared _datatodo
    Public Shared WebClient_POST As New System.Net.WebClient
    Public Shared data_list = New ArrayList

    Public Shared Function Load()


        WebClient_POST.Headers.Clear()
        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<div id=""header_main"">.*?([\s\S]*?)<div id=""hangar_slot_arrow""><\/div>").Groups.Item(1).ToString
        _datatodo = Regex.Matches(WebClient_GET_All_elements, "href=""(.*)""")

        For Each Contains_Hangar As Match In _datatodo
            For Each ID In Contains_Hangar.Captures
                SD = (("ID : ") + (ID.Index.ToString) + " = " + ((ID.Value).Replace("href=", "").Replace("""", "")))

                Console.WriteLine(SD)
            Next
            data_list.Add(Contains_Hangar)

            Dim Hangar_counter As String = 1
            Form_tools.ComboBox_Base_Hangar.Items.Clear()
            Form_tools.ComboBox_collectable_Hangar.Items.Clear()
            Form_tools.ComboBox_5_3_Hangar.Items.Clear()
Label_Base:
            If data_list.Count = Hangar_counter Then
                Form_tools.ComboBox_Base_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_tools.ComboBox_collectable_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_tools.ComboBox_5_3_Hangar.Items.Add("Hangar " + Hangar_counter)

            Else
                Form_tools.ComboBox_Base_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_tools.ComboBox_collectable_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_tools.ComboBox_5_3_Hangar.Items.Add("Hangar " + Hangar_counter)
                Hangar_counter = Val(Hangar_counter) + 1
                GoTo Label_Base

            End If

        Next



    End Function
End Class
