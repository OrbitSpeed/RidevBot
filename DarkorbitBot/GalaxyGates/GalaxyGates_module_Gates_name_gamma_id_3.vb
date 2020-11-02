Imports System.Net
Imports System.Text.RegularExpressions

Public Class GalaxyGates_module_Gates_name_gamma_id_3

    Public Shared WebClient_POST_3 As New System.Net.WebClient
    Public Shared Table_Load As String = """.*) \/>"
    Public Shared Verification_string As String = 0
    Public Shared Current_npc As String

    Public Shared Function Load(ByVal Verification)

        If Verification_string = 1 Then
            WebClient_POST_3.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
            Dim WebClient_Data = WebClient_POST_3.DownloadString("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
            Dim WebClient_GET_All_elements_Gamma = Regex.Match(WebClient_Data, "<gate (.*id=""2" + Table_Load).Groups.Item(1).ToString 'G
            Console.WriteLine(WebClient_GET_All_elements_Gamma)

            If WebClient_GET_All_elements_Gamma.Contains("prepared=""1""") Then
                If Stats_module.WebClient_GET_Ship_compagny_reg = Nothing Then
                    Stats_module.Load()

                End If

                If Stats_module.WebClient_GET_Ship_compagny_reg = "mmo" Then
                    Form_Tools.ComboBox_map_to_travel.Text = "1-1"

                ElseIf Stats_module.WebClient_GET_Ship_compagny_reg = "eic" Then
                    Form_Tools.ComboBox_map_to_travel.Text = "2-1"

                ElseIf Stats_module.WebClient_GET_Ship_compagny_reg = "vru" Then
                    Form_Tools.ComboBox_map_to_travel.Text = "3-1"

                End If
            Else
                Console.WriteLine("No Gates avaibled")
                Exit Function
            End If

            Traveling_module.Load()
            Exit Function

        Else

            ' TROUVER LA POSITION DU PORTAIL MMO VRU ET EIC 
            ' RETURN TRAVELING
            ' POSITIF GG => " Verification =0 "

        End If
    End Function


    Public Shared Function Progress_Gates()

    End Function

End Class
