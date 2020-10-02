Imports System.Net
Imports System.Text.RegularExpressions

Public Class Palladium_module
    Public Shared WebClient_POST As New System.Net.WebClient
    Private Shared txtPattern As Object
    Private Shared lblResult As Object

    Public Shared Function Load()

        WebClient_POST.Headers.Clear()
        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<div id=""header_main"">.*?([\s\S]*?)<div id=""hangar_slot_arrow""><\/div>").Groups.Item(1).ToString
        Dim data = Regex.Matches(WebClient_GET_All_elements, "href=""(.*)""")

        Dim data_list = New ArrayList
        For Each x As Match In data
            For Each c As Capture In x.Captures
                Dim SD = ("Index={0}, Value={1}", c.Index, c.Value)
                Console.WriteLine(SD)
            Next
            data_list.Add(x)



            Dim Hangar_counter As String = 1
            Form_Tools.ComboBox_Base_Hangar.Items.Clear()
            Form_Tools.ComboBox_collectable_Hangar.Items.Clear()
            Form_Tools.ComboBox_5_3_Hangar.Items.Clear()
Label_Base:
            If data_list.Count = Hangar_counter Then
                Form_Tools.ComboBox_Base_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_collectable_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_5_3_Hangar.Items.Add("Hangar " + Hangar_counter)

            Else
                Form_Tools.ComboBox_Base_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_collectable_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_5_3_Hangar.Items.Add("Hangar " + Hangar_counter)
                Hangar_counter = Val(Hangar_counter) + 1
                GoTo Label_Base

            End If

        Next

    End Function
End Class
