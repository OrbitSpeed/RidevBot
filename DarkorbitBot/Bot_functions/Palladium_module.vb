Imports System.Net
Imports System.Text.RegularExpressions

Public Class Palladium_module
    Public Shared ID As Capture
    Public Shared SD As String
    Public Shared Contains_Hangar
    Public Shared _datatodo
    Public Shared WebClient_POST As New System.Net.WebClient
    Public Shared data_list = New ArrayList

    Public Shared Hangartype_id As String
    Public Shared MOUTON As String
    Public Shared PLK As Integer

    Public Shared Sub Load()

        Contains_Hangar = ""
        _datatodo = ""
        Try

            data_list.clear
        Catch ex As Exception

        End Try

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

            Dim Hangar_counter As String = 0

            Form_Tools.ComboBox_Base_Hangar.Items.Clear()
            Form_Tools.ComboBox_collectable_Hangar.Items.Clear()
            Form_Tools.ComboBox_5_3_Hangar.Items.Clear()
Label_Base:
            If data_list.Count = Hangar_counter Then

            Else
                Form_Tools.ComboBox_Base_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_collectable_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_5_3_Hangar.Items.Add("Hangar " + Hangar_counter)
                Hangar_counter = Val(Hangar_counter) + 1
                GoTo Label_Base

            End If

        Next

    End Sub

    Public Shared Sub Hangar_resolver()

        If PLK.ToString.Contains("Wait to Update") Then

            Console.WriteLine("Please Update Hangar in first")
            MessageBox.Show("Please Update Hangar in first")

        End If

        If Hangartype_id = "1" Then
            PLK = Form_Tools.ComboBox_Base_Hangar.Text.Replace("Hangar", "").Replace(" ", "")
            Console.WriteLine(PLK)
            MOUTON = data_list(PLK).ToString.Replace("href=", "").Replace("""", "")
            Console.WriteLine(MOUTON)

        ElseIf Hangartype_id = "2" Then
            PLK = Form_Tools.ComboBox_collectable_Hangar.Text.Replace("Hangar", "").Replace(" ", "")
            Console.WriteLine(PLK)
            MOUTON = data_list(PLK).ToString.Replace("href=", "").Replace("""", "")
            Console.WriteLine(MOUTON)

        ElseIf Hangartype_id = "3" Then
            PLK = Form_Tools.ComboBox_5_3_Hangar.Text.Replace("Hangar", "").Replace(" ", "")
            Console.WriteLine(PLK)
            MOUTON = data_list(PLK).ToString.Replace("href=", "").Replace("""", "")
            Console.WriteLine(MOUTON)

        End If

        Hangartype_id = Nothing

        If PLK <> Nothing Then

            WebClient_POST.Headers.Clear()
            WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
            Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/" + MOUTON)
            Console.WriteLine("https://" + Utils.server + ".darkorbit.com/" + MOUTON)
            Console.WriteLine("Hangar transfered successfully")
            MessageBox.Show("Hangar transfered successfully")

        Else
            Console.WriteLine("No hangar selected")
            MessageBox.Show("No hangar selected")
        End If

    End Sub




End Class
