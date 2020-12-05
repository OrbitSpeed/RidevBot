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
                Hangar_counter = Val(Hangar_counter) + 1
                Form_Tools.ComboBox_Base_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_collectable_Hangar.Items.Add("Hangar " + Hangar_counter)
                Form_Tools.ComboBox_5_3_Hangar.Items.Add("Hangar " + Hangar_counter)
                GoTo Label_Base

            End If

        Next

    End Sub

    Public Shared Async Sub Hangar_resolver()

        If PLK.ToString = ("Wait to Update") Then

            Console.WriteLine("Please Update Hangar in first")
            MessageBox.Show("Please Update Hangar in first")
            Exit Sub
        End If

        If PLK.ToString = Nothing Then

            Console.WriteLine("Please Update Hangar in first")
            MessageBox.Show("Please Update Hangar in first")
            Exit Sub
        End If

        If PLK.ToString = (" ") Then

            Console.WriteLine("Please Update Hangar in first")
            MessageBox.Show("Please Update Hangar in first")
            Exit Sub
        End If

        If Hangartype_id = "1" Then
            PLK = Form_Tools.ComboBox_Base_Hangar.Text.Replace("Hangar", "").Replace(" ", "") - 1
            Console.WriteLine(PLK)
            MOUTON = data_list(PLK).ToString.Replace("href=", "").Replace("""", "")
            Console.WriteLine(MOUTON)

        ElseIf Hangartype_id = "2" Then
            PLK = Form_Tools.ComboBox_collectable_Hangar.Text.Replace("Hangar", "").Replace(" ", "") - 1
            Console.WriteLine(PLK)
            MOUTON = data_list(PLK).ToString.Replace("href=", "").Replace("""", "")
            Console.WriteLine(MOUTON)

        ElseIf Hangartype_id = "3" Then
            PLK = Form_Tools.ComboBox_5_3_Hangar.Text.Replace("Hangar", "").Replace(" ", "") - 1
            Console.WriteLine(PLK)
            MOUTON = data_list(PLK).ToString.Replace("href=", "").Replace("""", "")
            Console.WriteLine(MOUTON)

        End If

        WebClient_POST.Headers.Clear()
        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/" + MOUTON)
        Console.WriteLine("https://" + Utils.server + ".darkorbit.com/" + MOUTON)
        Console.WriteLine("Hangar transfered successfully")
        MessageBox.Show("Hangar transfered successfully")

        Await Task.Delay(1000)
        Load()

    End Sub

    Public Shared Async Function Function_palladium_running() As Task

        Dim Function_palladium_running_Map_actuelle = Form_Game.Label_map_location.Text.Split(" : ")(2)
        Dim Function_palladium_running_Map_roaming = Form_Tools.ComboBox_map_to_travel.Text

        Console.WriteLine(Function_palladium_running_Map_actuelle)
        Console.WriteLine(Function_palladium_running_Map_roaming)
        Console.WriteLine("Calcul de la selection des Hangar")

        If Function_palladium_running_Map_actuelle <> Function_palladium_running_Map_roaming Then
            If Form_Tools.CheckBox_use53_hangar_palladium.Checked = True Then

                Var.AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_Logout_key.Text))
                Form_Game.Label_state_contain.Text = "Disconnecting.."
                Await Task.Delay(20500)
                If Var.User_Stop_Bot Then Exit Function

                PLK = Form_Tools.ComboBox_5_3_Hangar.Text.Replace("Hangar", "").Replace(" ", "") - 1
                Console.WriteLine(PLK)
                MOUTON = data_list(PLK).ToString.Replace("href=", "").Replace("""", "")
                Console.WriteLine(MOUTON)
                Form_Game.Label_state_contain.Text = "Selecting Hangar.."
                WebClient_POST.Headers.Clear()
                WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
                Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/" + MOUTON)
                Console.WriteLine("https://" + Utils.server + ".darkorbit.com/" + MOUTON)
                Console.WriteLine("Hangar transfered successfully")
                Form_Game.Label_state_contain.Text = "Hangar transfered successfully"
                Await Task.Delay(1500)
                If Var.User_Stop_Bot Then Exit Function

                Form_Tools.Button_LaunchGameRidevBrowser_Click(Nothing, Nothing)

                ' faire une fonction qui detecte la page de demarage


            Else
                Form_Tools.ComboBox_map_to_travel.Text = "5-3"
                Exit Function
            End If
        Else
            Console.WriteLine("Pret a recevoir une tache !")
        End If

    End Function
End Class
