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


#Region "Click Zone"
#Region "4-1"
    Public Shared Async Function PORTAIL_41_to_14() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 606, 516)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_41_to_43() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 760, 566)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_41_to_42() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 760, 479)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_41_to_44() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 687, 522)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
#End Region
#Region "4-2"
    Public Shared Async Function PORTAIL_42_to_24() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 475)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_42_to_41() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 610, 566)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_42_to_43() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 759, 567)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_42_to_44() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 687, 522)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
#End Region
#Region "4-3"
    Public Shared Async Function PORTAIL_43_to_34() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 764, 516)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_43_to_41() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 610, 566)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_43_to_42() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 610, 479)
        Await Dead.Load
        Await Reconnect.Load
        Await Dependency.Load
        Await Task.Delay(1000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_43_to_44() As Task
        If User_Stop_Bot Then Exit Function

        Dim randomX = Utils.GetPortalZone(685, "x")
        Dim randomY = Utils.GetPortalZone(717, "y")
        'Milieu
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Dead.Load
        Await Reconnect.Load
        Await Dependency.Load
        Await Task.Delay(1000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
#End Region
#Region "1-4"
    Public Shared Async Function PORTAIL_14_to_41() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 764, 517)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
#End Region
#Region "2-4"
    Public Shared Async Function PORTAIL_24_to_42() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 570)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
#End Region
#Region "3-4"
    Public Shared Async Function PORTAIL_34_to_43() As Task
        If User_Stop_Bot Then Exit Function
        'On envoit le milieu du portail
        Dim randomX = Utils.GetPortalZone(683, "x")
        Dim randomY = Utils.GetPortalZone(493, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
#End Region
#Region "BL"
    Public Shared Async Function PORTAIL_1BL_MMO() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 691, 556)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_2BL_EIC() As Task
        If User_Stop_Bot Then Exit Function

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 692, 563)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_3BL_VRU() As Task

        If User_Stop_Bot Then Exit Function

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 692, 562)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
#End Region
    Public Shared Async Function PORTAIL_15_TO_44() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 764, 517)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_44_to_15() As Task
        If User_Stop_Bot Then Exit Function
        'Centre : 623, 540
        Dim randomX = Utils.GetPortalZone(623, "x")
        Dim randomY = Utils.GetPortalZone(540, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_25_TO_44() As Task
        If User_Stop_Bot Then Exit Function

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 610, 569)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_44_to_25() As Task
        If User_Stop_Bot Then Exit Function
        'Centre : 719, 485
        Dim randomX = Utils.GetPortalZone(719, "x")
        Dim randomY = Utils.GetPortalZone(485, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_35_TO_44() As Task
        If User_Stop_Bot Then Exit Function
        ' HAUT GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 610, 478)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
#Region "4-4"
    Public Shared Async Function PORTAIL_44_to_35() As Task
        If User_Stop_Bot Then Exit Function
        'Centre : 719, 593
        Dim randomX = Utils.GetPortalZone(719, "x")
        Dim randomY = Utils.GetPortalZone(593, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_44_to_41() As Task
        If User_Stop_Bot Then Exit Function
        Dim randomX = Utils.GetPortalZone(679, "x")
        Dim randomY = Utils.GetPortalZone(540, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_44_to_42() As Task
        If User_Stop_Bot Then Exit Function
        Dim randomX = Utils.GetPortalZone(691, "x")
        Dim randomY = Utils.GetPortalZone(533, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_44_to_43() As Task
        If User_Stop_Bot Then Exit Function
        Dim randomX = Utils.GetPortalZone(691, "x")
        Dim randomY = Utils.GetPortalZone(545, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
#End Region
#Region "4-5"
    Public Shared Async Function PORTAIL_45_to_15() As Task
        If User_Stop_Bot Then Exit Function
        Dim randomX = Utils.GetPortalZone(623, "x")
        Dim randomY = Utils.GetPortalZone(540, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_45_to_25() As Task
        If User_Stop_Bot Then Exit Function

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 717, 463)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_45_to_35() As Task
        If User_Stop_Bot Then Exit Function

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 719, 596)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_45_to_51_MMO() As Task
        If User_Stop_Bot Then Exit Function
        Dim randomX = Utils.GetPortalZone(647, "x")
        Dim randomY = Utils.GetPortalZone(540, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_45_to_51_EIC() As Task
        If User_Stop_Bot Then Exit Function
        'Centre : 705, 508
        Dim randomX = Utils.GetPortalZone(705, "x")
        Dim randomY = Utils.GetPortalZone(508, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_45_to_51_VRU() As Task
        If User_Stop_Bot Then Exit Function

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 703, 550)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
#End Region
#Region "4-5 Indépendant"
    Public Shared Async Function PORTAIL_45_MMO() As Task
        If User_Stop_Bot Then Exit Function
        'Centre : 610, 584
        'Vrai centre : 764, 534
        Dim randomX = Utils.GetPortalZone(764, "x")
        Dim randomY = Utils.GetPortalZone(534, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
    Public Shared Async Function PORTAIL_45_EIC() As Task
        If User_Stop_Bot Then Exit Function
        'Centre : 760, 584
        Dim randomX = Utils.GetPortalZone(760, "x")
        Dim randomY = Utils.GetPortalZone(584, "y")

        ' BAS DROITE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_45_VRU() As Task
        If User_Stop_Bot Then Exit Function
        'Centre : 745, 493
        Dim randomX = Utils.GetPortalZone(745, "x")
        Dim randomY = Utils.GetPortalZone(493, "y")

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Function
#End Region

#Region "Portails généraux"

    Public Shared Async Function PORTAIL_HAUT_DROITE() As Task

        If User_Stop_Bot Then Exit Function

        Dim randomX = Utils.GetPortalZone(760, "x")
        Dim randomY = Utils.GetPortalZone(497, "y")

        'HAUT DROITE 
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If

        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_HAUT_GAUCHE() As Task

        If User_Stop_Bot Then Exit Function

        Dim randomX = Utils.GetPortalZone(610, "x")
        Dim randomY = Utils.GetPortalZone(497, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If

        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_BAS_DROITE() As Task

        If User_Stop_Bot Then Exit Function

        Dim randomX = Utils.GetPortalZone(760, "x")
        Dim randomY = Utils.GetPortalZone(585, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If

        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function
    Public Shared Async Function PORTAIL_BAS_GAUCHE() As Task

        If User_Stop_Bot Then Exit Function
        Dim randomX = Utils.GetPortalZone(610, "x")
        Dim randomY = Utils.GetPortalZone(584, "y")

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, randomX, randomY)
        Await Task.Delay(1500)
        Client_Screen = Update_Screen()
        Dim traveling_indication As Bitmap = My.Resources.traveling_indication
        Dim traveling_indication_point As Point = Client_Screen.Contains(traveling_indication)
        If traveling_indication_point <> Nothing Then
            Console.WriteLine("traveling indication trouvée")
            Do Until traveling_indication_point = Nothing
                Client_Screen = Update_Screen()
                traveling_indication_point = Client_Screen.Contains(traveling_indication)
                If traveling_indication_point <> Nothing Then
                    If User_Stop_Bot Then Exit Function
                    Await Dead.Load
                    Await Reconnect.Load
                    Await Dependency.Load
                    Await Task.Delay(1000)
                    Console.WriteLine("on reboucle pour revérifier")
                Else
                    Console.WriteLine("on exit le until do car pas trouvé donc point d'arrivé")
                    Exit Do
                End If
            Loop
        End If

        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Function

#End Region
#End Region

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

                Await Task.Delay(10000)

                Update_Screen()

                Dim Map_actuelle = Form_Game.Label_map_location.Text.Split(" : ")(2)
                Dim Map_roaming = Form_Tools.ComboBox_map_to_travel.Text

                If Map_actuelle <> Map_roaming Then
                    Console.WriteLine("New operation in progress...")

                    Await Dead.Load
                    Await Task.Delay(100)
                    Await Reconnect.Load
                    Await Task.Delay(100)
                    Await Dependency.Load
                    Await Task.Delay(100)
                    Await Checking_map.Load()
                    Await Task.Delay(100)
                    Traveling_module.Load()

                Else
                    Console.WriteLine("Traveling success, checking, wait...")

                    Await Dead.Load
                    Await Task.Delay(100)
                    Await Reconnect.Load
                    Await Task.Delay(100)
                    Await Dependency.Load
                    Await Task.Delay(100)
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

            Await Task.Delay(1000)
            If User_Stop_Bot Then Exit Function
            Await Dead.Load
            Await Task.Delay(1000)
            If User_Stop_Bot Then Exit Function
            Await Reconnect.Load
            Await Task.Delay(1000)
            If User_Stop_Bot Then Exit Function
            Await Dependency.Load
            Await Task.Delay(7000)
            If User_Stop_Bot Then Exit Function
            Await Checking_map.Load()
            If User_Stop_Bot Then Exit Function
            Traveling_module.Load()

        Else

            Console.WriteLine("On relance Traveling par Point de chute")

            Await Task.Delay(1000)
            If User_Stop_Bot Then Exit Function
            Await Dead.Load
            Await Task.Delay(1000)
            If User_Stop_Bot Then Exit Function
            Await Reconnect.Load
            Await Task.Delay(1000)
            If User_Stop_Bot Then Exit Function
            Await Dependency.Load
            Await Task.Delay(7000)
            If User_Stop_Bot Then Exit Function
            Await Checking_map.Load()
            If User_Stop_Bot Then Exit Function
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
