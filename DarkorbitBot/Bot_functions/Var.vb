Imports AutoItX3Lib

Public Class Var

    Public Shared Student As String = "System.Object[]"

    Public Shared Map1_1 = My.Resources.map1_1
    Public Shared Map1_2 = My.Resources.map1_2
    Public Shared Map1_3 = My.Resources.map1_3
    Public Shared Map1_4 = My.Resources.map1_4
    Public Shared Map1_5 = My.Resources.map1_5
    Public Shared Map1_6 = My.Resources.map1_6
    Public Shared Map1_7 = My.Resources.map1_7
    Public Shared Map1_8 = My.Resources.map1_8
    Public Shared Map2_1 = My.Resources.map2_1
    Public Shared Map2_2 = My.Resources.map2_2
    Public Shared Map2_3 = My.Resources.map2_3
    Public Shared Map2_4 = My.Resources.map2_4
    Public Shared Map2_5 = My.Resources.map2_5
    Public Shared Map2_6 = My.Resources.map2_6
    Public Shared Map2_7 = My.Resources.map2_7
    Public Shared Map2_8 = My.Resources.map2_8
    Public Shared Map3_1 = My.Resources.map3_1
    Public Shared Map3_2 = My.Resources.map3_2
    Public Shared Map3_3 = My.Resources.map3_3
    Public Shared Map3_4 = My.Resources.map3_4
    Public Shared Map3_5 = My.Resources.map3_5
    Public Shared Map3_6 = My.Resources.map3_6
    Public Shared Map3_7 = My.Resources.map3_7
    Public Shared Map3_8 = My.Resources.map3_8
    Public Shared Map4_1 = My.Resources.map4_1
    Public Shared Map4_2 = My.Resources.map4_2
    Public Shared Map4_3 = My.Resources.map4_3
    Public Shared Map4_4 = My.Resources.map4_4
    Public Shared Map4_5 = My.Resources.map4_5
    Public Shared Map5_1 = My.Resources.map5_1
    Public Shared Map5_2 = My.Resources.map5_2
    Public Shared Map5_3 = My.Resources.map5_3
    Public Shared Map1_BL = My.Resources.map1_BL
    Public Shared Map2_BL = My.Resources.map2_BL
    Public Shared Map3_BL = My.Resources.map3_BL

    Public Shared security As Boolean = False
    Public Shared security_traveling As Boolean = False
    Public Shared security_T_backup As Boolean = False

    Public Shared X_TOP As Integer = 0
    Public Shared Y_TOP As Integer = 64
    Public Shared X_BOTTOM As Integer = 800
    Public Shared Y_BOTTOM As Integer = 618

    Public Shared User_Stop_Bot As Boolean = True
    Public Shared CurrentMapUser = "0-0"
    Public Shared Client_Screen As Bitmap
    Public Shared save_point_x As String = 0
    Public Shared save_point_Y As String = 0
    Public Shared passage As String = 0
    Public Shared AutoIt As New AutoItX3

    Public Shared Disconnected = My.Resources.Disconnected
    Public Shared System_box_move As Boolean = False

    Public Shared Button_repair = My.Resources.Button_repair
    Public Shared Base_repair = My.Resources.Base_repair
    Public Shared Portal_repair = My.Resources.Portal_repair
    Public Shared Instant_repair = My.Resources.Instant_repair
    Public Shared Detect_if_dead = My.Resources.Detect_if_dead

    Public Shared Cancel_disconnect = My.Resources.Cancel_disconnect
    Public Shared Close_popup_payment = My.Resources.Close_popup_payment

    Public Shared Minimap_closed_ref = My.Resources.Minimap_closed
    Public Shared Minimap_size_ref = My.Resources.Minimap_reduce
    Public Shared Move_minimap_box_ref = My.Resources.Move_box
    Public Shared systeme_stellaire_ref = My.Resources.systeme_stellaire
    Public Shared map_detect_ref = My.Resources.map_detect
    Public Shared deconnection_popup_visible = My.Resources.Deconnection_popup_encore_visible

    Public Shared Map_Location1_1 As Point = Client_Screen.Contains(Map1_1)
    Public Shared Map_Location1_2 As Point = Client_Screen.Contains(Map1_2)
    Public Shared Map_Location1_3 As Point = Client_Screen.Contains(Map1_3)
    Public Shared Map_Location1_4 As Point = Client_Screen.Contains(Map1_4)
    Public Shared Map_Location1_5 As Point = Client_Screen.Contains(Map1_5)
    Public Shared Map_Location1_6 As Point = Client_Screen.Contains(Map1_6)
    Public Shared Map_Location1_7 As Point = Client_Screen.Contains(Map1_7)
    Public Shared Map_Location1_8 As Point = Client_Screen.Contains(Map1_8)

    Public Shared Map_Location2_1 As Point = Client_Screen.Contains(Map2_1)
    Public Shared Map_Location2_2 As Point = Client_Screen.Contains(Map2_2)
    Public Shared Map_Location2_3 As Point = Client_Screen.Contains(Map2_3)
    Public Shared Map_Location2_4 As Point = Client_Screen.Contains(Map2_4)
    Public Shared Map_Location2_5 As Point = Client_Screen.Contains(Map2_5)
    Public Shared Map_Location2_6 As Point = Client_Screen.Contains(Map2_6)
    Public Shared Map_Location2_7 As Point = Client_Screen.Contains(Map2_7)
    Public Shared Map_Location2_8 As Point = Client_Screen.Contains(Map2_8)

    Public Shared Map_Location3_1 As Point = Client_Screen.Contains(Map3_1)
    Public Shared Map_Location3_2 As Point = Client_Screen.Contains(Map3_2)
    Public Shared Map_Location3_3 As Point = Client_Screen.Contains(Map3_3)
    Public Shared Map_Location3_4 As Point = Client_Screen.Contains(Map3_4)
    Public Shared Map_Location3_5 As Point = Client_Screen.Contains(Map3_5)
    Public Shared Map_Location3_6 As Point = Client_Screen.Contains(Map3_6)
    Public Shared Map_Location3_7 As Point = Client_Screen.Contains(Map3_7)
    Public Shared Map_Location3_8 As Point = Client_Screen.Contains(Map3_8)

    Public Shared Map_Location4_1 As Point = Client_Screen.Contains(Map4_1)
    Public Shared Map_Location4_2 As Point = Client_Screen.Contains(Map4_2)
    Public Shared Map_Location4_3 As Point = Client_Screen.Contains(Map4_3)
    Public Shared Map_Location4_4 As Point = Client_Screen.Contains(Map4_4)
    Public Shared Map_Location4_5 As Point = Client_Screen.Contains(Map4_5)

    Public Shared Map_Location5_1 As Point = Client_Screen.Contains(Map5_1)
    Public Shared Map_Location5_2 As Point = Client_Screen.Contains(Map5_2)
    Public Shared Map_Location5_3 As Point = Client_Screen.Contains(Map5_3)

    Public Shared Map_Location1_BL As Point = Client_Screen.Contains(Map1_BL)
    Public Shared Map_Location2_BL As Point = Client_Screen.Contains(Map2_BL)
    Public Shared Map_Location3_BL As Point = Client_Screen.Contains(Map3_BL)

    Public Shared Need_reconnexion As String = 0

    Public Shared Async Function Goto_Next_portal(ByVal ReferenceGoto_X, ByVal ReferenceGoto_Y) As Task

        If User_Stop_Bot Then Exit Function

        Dim Chocolatine = Utils.GetPortalZone(ReferenceGoto_X, "x")
        Dim pain_au_chocolat = Utils.GetPortalZone(ReferenceGoto_Y, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Chocolatine, pain_au_chocolat)
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)

        Await Task.Delay(1500)

Return_On_Road:
        Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then

            If User_Stop_Bot Then Exit Function
            Console.WriteLine("On Road.. Traveling icon found.")
            Await Dead.Load
            Await Task.Delay(333)
            Await Reconnect.Load
            Await Task.Delay(333)
            Await Dependency.Load
            Await Task.Delay(334)
            GoTo Return_On_Road

        Else
            Console.WriteLine("Debug in progress.. Traveling icon not found.")
            Console.WriteLine("Checking if portal is arround...")

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Chocolatine, pain_au_chocolat)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)

            Await Task.Delay(2000)

            Update_Screen()
            Dim traveling_indication_ref As Bitmap = My.Resources.traveling_indication
            Dim traveling_indication_point_ref As Point = Client_Screen.Contains(traveling_indication_ref)
            If traveling_indication_point_ref <> Nothing Then

                If User_Stop_Bot Then Exit Function
                Console.WriteLine("On Road.. Traveling icon found. _return not moved or distracted")
                Await Dead.Load
                Await Task.Delay(333)
                Await Reconnect.Load
                Await Task.Delay(333)
                Await Dependency.Load
                Await Task.Delay(334)
                GoTo Return_On_Road

            Else

                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_jump_key.Text))
                Console.WriteLine("Key Portal sended > Waiting 10s before new operation")

                Await Task.Delay(15000)

                Update_Screen()

                Dim Map_actuelle = Form_Game.Label_map_location.Text.Split(" : ")(2)
                Dim Map_roaming = Form_Tools.ComboBox_map_to_travel.Text

                If Map_actuelle <> Map_roaming Then
                    Console.WriteLine("New operation in progress...")

                    Await Dead.Load
                    Await Task.Delay(250)
                    Await Reconnect.Load
                    Await Task.Delay(250)
                    Await Dependency.Load
                    Await Task.Delay(500)
                    Await Checking_map.Load()
                    Await Task.Delay(100)
                    Traveling_module.Load()

                Else
                    Console.WriteLine("Traveling success, checking, wait...")

                    Await Dead.Load
                    Await Task.Delay(250)
                    Await Reconnect.Load
                    Await Task.Delay(250)
                    Await Dependency.Load
                    Await Task.Delay(500)
                    Await Checking_map.Load()
                    Await Task.Delay(100)
                    Traveling_module.Load()

                End If
            End If
        End If


    End Function ' tout remplacer par sa !

    Public Shared Async Function POINT_DE_CHUTE_DU_CLICK_TRAVELING() As Task

        If User_Stop_Bot Then Exit Function

        Dim Map_actuelle_reconize = Form_Game.Label_map_location.Text.Replace("Map : ", "")
        Dim Map_roaming_reconize = Form_Tools.ComboBox_map_to_travel.Text
        Console.WriteLine(Map_actuelle_reconize)
        Console.WriteLine(Map_roaming_reconize)

        If Map_actuelle_reconize <> Map_roaming_reconize Then

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
            AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_jump_key.Text))
            Console.WriteLine($"Point de chute du click traveling atteint and Sended -- {Form_Tools.TextBox_jump_key.Text}")

            Await Dead.Load
            Await Task.Delay(250)
            Await Reconnect.Load
            Await Task.Delay(250)
            Await Dependency.Load
            Await Task.Delay(15000)
            If User_Stop_Bot Then Exit Function
            Await Checking_map.Load()
            Traveling_module.Load()

        Else

            Console.WriteLine("On relance Traveling par Point de chute")

            Await Dead.Load
            Await Task.Delay(250)
            Await Reconnect.Load
            Await Task.Delay(250)
            Await Dependency.Load
            Await Task.Delay(15000)
            If User_Stop_Bot Then Exit Function
            Await Checking_map.Load()
            Traveling_module.Load()


        End If

    End Function

    Public Shared Function Update_Screen()

        Dim Client_primary = New Bitmap(Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Width, Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Form_Game.Invoke(New MethodInvoker(Sub()
                                               Client_second.CopyFromScreen(Form_Game.PointToScreen(Form_Game.WebBrowser_Game_Ridevbot.Location), New Point(0, 0), Form_Game.WebBrowser_Game_Ridevbot.ClientSize)
                                           End Sub))
        Client_Screen = Client_primary
        Return Client_primary

    End Function ' Update Screen >> [Ok] 

End Class
