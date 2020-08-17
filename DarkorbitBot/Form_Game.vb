Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports AutoItX3Lib

Public Class Form_Game

    Dim AutoIt As New AutoItX3
    Dim X_TOP As Integer = 0
    Dim Y_TOP As Integer = 64
    Dim X_BOTTOM As Integer = 800
    Dim Y_BOTTOM As Integer = 618

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click

        CloseForm.ShowDialog(Me)
        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

        Form_Tools.Reloader = 0
        Form_Tools.Reload()

    End Sub

    Private Sub WebBrowser_Game_Ridevbot_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_Game_Ridevbot.DocumentCompleted

        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

    End Sub


    Private Sub Form_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    ' █                                                                                                                                █
    ' █                                                          RidevBot BOT                                                          █
    ' █                                                                                                                                █
    ' █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

    Public User_Stop_Bot As Boolean = True
    Function Update_Screen()

        Dim Client_primary = New Bitmap(WebBrowser_Game_Ridevbot.ClientSize.Width, WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Client_second.CopyFromScreen(PointToScreen(WebBrowser_Game_Ridevbot.Location), New Point(0, 0), WebBrowser_Game_Ridevbot.ClientSize)
        Return Client_primary
        'Client_primary.Save($"screenshot.jpg", ImageFormat.Jpeg)
    End Function

    Dim Client_Screen As Bitmap
    Public CurrentMapUser = "0-0"
    Dim save_point_x As String = 0
    Dim save_point_Y As String = 0
    Dim passage As String = 0
    Dim tour As String = 0

    ' ⚡ VARIABLES DISCONECTED ⚡

    Dim Disconnected = My.Resources.Disconnected

    ' ⚡ VARIABLES MAP LOCATION ⚡

    Dim System_box_move As Boolean = False
    Dim Minimap_closed_ref = My.Resources.Minimap_closed
    Dim Minimap_size_ref = My.Resources.Minimap_reduce
    Dim Move_minimap_box_ref = My.Resources.Move_box
    Dim systeme_stellaire_ref = My.Resources.systeme_stellaire
    Dim map_detect_ref = My.Resources.map_detect

    Dim Map1_1 = My.Resources.map1_1
    Dim Map1_2 = My.Resources.map1_2
    Dim Map1_3 = My.Resources.map1_3
    Dim Map1_4 = My.Resources.map1_4
    Dim Map1_5 = My.Resources.map1_5
    Dim Map1_6 = My.Resources.map1_6
    Dim Map1_7 = My.Resources.map1_7
    Dim Map1_8 = My.Resources.map1_8

    Dim Map2_1 = My.Resources.map2_1
    Dim Map2_2 = My.Resources.map2_2
    Dim Map2_3 = My.Resources.map2_3
    Dim Map2_4 = My.Resources.map2_4
    Dim Map2_5 = My.Resources.map2_5
    Dim Map2_6 = My.Resources.map2_6
    Dim Map2_7 = My.Resources.map2_7
    Dim Map2_8 = My.Resources.map2_8

    Dim Map3_1 = My.Resources.map3_1
    Dim Map3_2 = My.Resources.map3_2
    Dim Map3_3 = My.Resources.map3_3
    Dim Map3_4 = My.Resources.map3_4
    Dim Map3_5 = My.Resources.map3_5
    Dim Map3_6 = My.Resources.map3_6
    Dim Map3_7 = My.Resources.map3_7
    Dim Map3_8 = My.Resources.map3_8

    Dim Map4_1 = My.Resources.map4_1
    Dim Map4_2 = My.Resources.map4_2
    Dim Map4_3 = My.Resources.map4_3
    Dim Map4_4 = My.Resources.map4_4
    Dim Map4_5 = My.Resources.map4_5

    Dim Map5_1 = My.Resources.map5_1
    Dim Map5_2 = My.Resources.map5_2
    Dim Map5_3 = My.Resources.map5_3

    Dim Map1_BL = My.Resources.map1_BL
    Dim Map2_BL = My.Resources.map2_BL
    Dim Map3_BL = My.Resources.map3_BL


    ' ⚡ MODULE MINIMAP ⚡ 
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '  ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 

#Region "Checking/reducing/moving and saving minimap"

    Private Async Sub Startup_bot()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        WebBrowser_Game_Ridevbot.Select()
        Client_Screen = Update_Screen()

        ' if machin
        'alors tu fais ça
        'exit sub
        'end if

        Try
            Dim Save_point_original As Point = Client_Screen.Contains(Minimap_size_ref)

            If Save_point_original.X = "762" Then
                Checking_minimap()
                Exit Sub
            End If

        Catch map_error As Exception
        End Try

        Try
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
            AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_desactive_allkey.Text))
            Await Task.Delay(2000)
            Detection_minimap()
        Catch ex As Exception
            Console.WriteLine($"Startup_Bot error! {ex.Message}")
            Startup_bot()
        End Try

    End Sub

    Private Async Sub Detection_minimap()
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If


        Try
            Client_Screen = Update_Screen()
            System_box_move = False

            Dim Minimap_closed As Point = Client_Screen.Contains(Minimap_closed_ref)
            If Minimap_closed <> Nothing Then
                WebBrowser_Game_Ridevbot.Select()
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_closed.X, Minimap_closed.Y + 18)
                Await Task.Delay(3000)
                Console.WriteLine("Detection minimap ok")
                Reduction_minimap()
            Else
                Startup_bot()
            End If

        Catch Minimap_opened As Exception
            Console.WriteLine($"Minimap_opened error! {Minimap_opened.Message}")
        End Try

    End Sub

    Private Async Sub Reduction_minimap()
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If


        Try
            Client_Screen = Update_Screen()
            Dim Minimap_size As Point = Client_Screen.Contains(Minimap_size_ref)
            Dim compare As Point

            If Minimap_size <> Nothing Then

                For i = 0 To 15
                    Await Task.Delay(120)
                    Dim cursor_Pos = Cursor.Position
                    Client_Screen = Update_Screen()
                    Minimap_size = Client_Screen.Contains(Minimap_size_ref)
                    If Minimap_size <> Nothing Then
                        If compare = Minimap_size Then
                            i = 15
                            Console.WriteLine("Réduction faite")
                            Await Task.Delay(1000)
                            Deplacement_minimap_bas_droite()
                            Exit Sub
                        Else
                            Cursor.Position = New Point(Minimap_size.X, Minimap_size.Y + 18)
                            AutoIt.MouseClick("LEFT")
                            compare = Minimap_size
                        End If
                    End If
                    Cursor.Position = cursor_Pos
                Next
                Await Task.Delay(1000)
                Deplacement_minimap_bas_droite()
            Else
                If System_box_move = True Then
                    Startup_bot()
                Else
                    Detection_minimap()
                End If
            End If

        Catch Reduction_minimap_error As Exception
            Console.WriteLine($"Reduction_minimap_error error! {Reduction_minimap_error.Message}")
        End Try

    End Sub

    Private Async Sub Deplacement_minimap_bas_droite()
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Client_Screen = Update_Screen()

        Try
            Dim Minimap_move As Point = Client_Screen.Contains(Move_minimap_box_ref)

            If Minimap_move <> Nothing Then

                Dim cursor_Pos = Cursor.Position
                Cursor.Position = New Point(Minimap_move.X - 40, Minimap_move.Y + 20)
                AutoIt.MouseDown("LEFT")
                Cursor.Position = New Point(759, 599)
                AutoIt.MouseUp("LEFT")
                Cursor.Position = cursor_Pos
                Await Task.Delay(800)
                Console.WriteLine("déplacement minimap ok")
                Stop_Bot()
            Else
                System_box_move = True
                Reduction_minimap()
            End If

        Catch Deplacement_minimap_bas_droite_error As Exception
            Console.WriteLine($"Deplacement_minimap_bas_droite_error error! {Deplacement_minimap_bas_droite_error.Message}")

        End Try
    End Sub

#End Region

    '  ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲                          
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    ' ⚡ MODULE MINIMAP ⚡


    ' TOUJOURS CE REFERENCER ICI !
    Private Async Sub Checking_minimap()
        Client_Screen = Update_Screen()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Try
            Dim Save_point_original As Point = Client_Screen.Contains(Minimap_size_ref)

            If Save_point_original.X = "762" Then
                Await Task.Delay(1000)
                Console.WriteLine("relance")
                tour += 1
                If tour = 5 Then

                    Checking_map_actuel()
                    Exit Sub
                End If
                Checking_minimap()
                Exit Sub
            Else
                Startup_bot()
            End If

        Catch Aucune_map_trouve_error As Exception
            Console.WriteLine($"Aucune_map_trouve_error! {Aucune_map_trouve_error.Message}")

        End Try

    End Sub

    ' CHECK DANS QUEL MAP IL SE TROUVE !
    Private Sub Checking_map_actuel()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        If tour = 5 Then
            tour = 0

            Client_Screen = Update_Screen()

            Try
                Dim Map_Location1_1 As Point = Client_Screen.Contains(Map1_1)
                Dim Map_Location1_2 As Point = Client_Screen.Contains(Map1_2)
                Dim Map_Location1_3 As Point = Client_Screen.Contains(Map1_3)
                Dim Map_Location1_4 As Point = Client_Screen.Contains(Map1_4)
                Dim Map_Location1_5 As Point = Client_Screen.Contains(Map1_5)
                Dim Map_Location1_6 As Point = Client_Screen.Contains(Map1_6)
                Dim Map_Location1_7 As Point = Client_Screen.Contains(Map1_7)
                Dim Map_Location1_8 As Point = Client_Screen.Contains(Map1_8)

                Dim Map_Location2_1 As Point = Client_Screen.Contains(Map2_1)
                Dim Map_Location2_2 As Point = Client_Screen.Contains(Map2_2)
                Dim Map_Location2_3 As Point = Client_Screen.Contains(Map2_3)
                Dim Map_Location2_4 As Point = Client_Screen.Contains(Map2_4)
                Dim Map_Location2_5 As Point = Client_Screen.Contains(Map2_5)
                Dim Map_Location2_6 As Point = Client_Screen.Contains(Map2_6)
                Dim Map_Location2_7 As Point = Client_Screen.Contains(Map2_7)
                Dim Map_Location2_8 As Point = Client_Screen.Contains(Map2_8)

                Dim Map_Location3_1 As Point = Client_Screen.Contains(Map3_1)
                Dim Map_Location3_2 As Point = Client_Screen.Contains(Map3_2)
                Dim Map_Location3_3 As Point = Client_Screen.Contains(Map3_3)
                Dim Map_Location3_4 As Point = Client_Screen.Contains(Map3_4)
                Dim Map_Location3_5 As Point = Client_Screen.Contains(Map3_5)
                Dim Map_Location3_6 As Point = Client_Screen.Contains(Map3_6)
                Dim Map_Location3_7 As Point = Client_Screen.Contains(Map3_7)
                Dim Map_Location3_8 As Point = Client_Screen.Contains(Map3_8)

                Dim Map_Location4_1 As Point = Client_Screen.Contains(Map4_1)
                Dim Map_Location4_2 As Point = Client_Screen.Contains(Map4_2)
                Dim Map_Location4_3 As Point = Client_Screen.Contains(Map4_3)
                Dim Map_Location4_4 As Point = Client_Screen.Contains(Map4_4)
                Dim Map_Location4_5 As Point = Client_Screen.Contains(Map4_5)

                Dim Map_Location5_1 As Point = Client_Screen.Contains(Map5_1)
                Dim Map_Location5_2 As Point = Client_Screen.Contains(Map5_2)
                Dim Map_Location5_3 As Point = Client_Screen.Contains(Map5_3)

                Dim Map_Location1_BL As Point = Client_Screen.Contains(Map1_BL)
                Dim Map_Location2_BL As Point = Client_Screen.Contains(Map2_BL)
                Dim Map_Location3_BL As Point = Client_Screen.Contains(Map3_BL)

                If Map_Location1_1 <> Nothing Then
                    Label_map_location.Text = "Map : 1-1"
                ElseIf Map_Location1_2 <> Nothing Then
                    Label_map_location.Text = "Map : 1-2"
                ElseIf Map_Location1_3 <> Nothing Then
                    Label_map_location.Text = "Map : 1-3"
                ElseIf Map_Location1_4 <> Nothing Then
                    Label_map_location.Text = "Map : 1-4"
                ElseIf Map_Location1_5 <> Nothing Then
                    Label_map_location.Text = "Map : 1-5"
                ElseIf Map_Location1_6 <> Nothing Then
                    Label_map_location.Text = "Map : 1-6"
                ElseIf Map_Location1_7 <> Nothing Then
                    Label_map_location.Text = "Map : 1-7"
                ElseIf Map_Location1_8 <> Nothing Then
                    Label_map_location.Text = "Map : 1-8"
                ElseIf Map_Location2_1 <> Nothing Then
                    Label_map_location.Text = "Map : 2-1"
                ElseIf Map_Location2_2 <> Nothing Then
                    Label_map_location.Text = "Map : 2-2"
                ElseIf Map_Location2_3 <> Nothing Then
                    Label_map_location.Text = "Map : 2-3"
                ElseIf Map_Location2_4 <> Nothing Then
                    Label_map_location.Text = "Map : 2-4"
                ElseIf Map_Location2_5 <> Nothing Then
                    Label_map_location.Text = "Map : 2-5"
                ElseIf Map_Location2_6 <> Nothing Then
                    Label_map_location.Text = "Map : 2-6"
                ElseIf Map_Location2_7 <> Nothing Then
                    Label_map_location.Text = "Map : 2-7"
                ElseIf Map_Location2_8 <> Nothing Then
                    Label_map_location.Text = "Map : 2-8"
                ElseIf Map_Location3_1 <> Nothing Then
                    Label_map_location.Text = "Map : 3-1"
                ElseIf Map_Location3_2 <> Nothing Then
                    Label_map_location.Text = "Map : 3-2"
                ElseIf Map_Location3_3 <> Nothing Then
                    Label_map_location.Text = "Map : 3-3"
                ElseIf Map_Location3_4 <> Nothing Then
                    Label_map_location.Text = "Map : 3-4"
                ElseIf Map_Location3_5 <> Nothing Then
                    Label_map_location.Text = "Map : 3-5"
                ElseIf Map_Location3_6 <> Nothing Then
                    Label_map_location.Text = "Map : 3-6"
                ElseIf Map_Location3_7 <> Nothing Then
                    Label_map_location.Text = "Map : 3-7"
                ElseIf Map_Location3_8 <> Nothing Then
                    Label_map_location.Text = "Map : 3-8"
                ElseIf Map_Location4_1 <> Nothing Then
                    Label_map_location.Text = "Map : 4-1"
                ElseIf Map_Location4_2 <> Nothing Then
                    Label_map_location.Text = "Map : 4-2"
                ElseIf Map_Location4_3 <> Nothing Then
                    Label_map_location.Text = "Map : 4-3"
                ElseIf Map_Location4_4 <> Nothing Then
                    Label_map_location.Text = "Map : 4-4"
                ElseIf Map_Location4_5 <> Nothing Then
                    Label_map_location.Text = "Map : 4-5"
                ElseIf Map_Location5_1 <> Nothing Then
                    Label_map_location.Text = "Map : 5-1"
                ElseIf Map_Location5_2 <> Nothing Then
                    Label_map_location.Text = "Map : 5-2"
                ElseIf Map_Location5_3 <> Nothing Then
                    Label_map_location.Text = "Map : 5-3"
                ElseIf Map_Location1_BL <> Nothing Then
                    Label_map_location.Text = "Map : 1BL"
                ElseIf Map_Location2_BL <> Nothing Then
                    Label_map_location.Text = "Map : 2BL"
                ElseIf Map_Location3_BL <> Nothing Then
                    Label_map_location.Text = "Map : 3BL"
                End If
                Label_map_location.Update()
                CurrentMapUser = Label_map_location.Text.Split(" : ")(1)
                Console.WriteLine("On a reussi ! ")
                reconnexion()

            Catch detect_map_error As Exception
                Console.WriteLine($"Error on the map detector: {detect_map_error.Message}")
            End Try

        End If


    End Sub

    ' CHECK SI ON ES DECONNECTER !
    Private Async Sub reconnexion()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Try
            Client_Screen = Update_Screen()
            Dim Connection_Lost As Point = Client_Screen.Contains(Disconnected)
            Dim Connection_Lost2 As Point = Client_Screen.Contains(Disconnected)

            If Connection_Lost <> Nothing Then

                Await Task.Delay(2000)
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 300, 354)
                Console.WriteLine("Reconnexion")
                Await Task.Delay(6999)
                Checking_minimap()
            End If

        Catch Connected As Exception

            Checking_minimap()

        End Try



    End Sub



















    Private Sub Stop_Bot()
        If User_Stop_Bot Then
            MsgBox("Stopped")
        Else
            Checking_minimap()
        End If


        'Try

        '    Dim Systeme_Stellaire_Point As Point = Client_Screen.Contains(systeme_stellaire_ref)

        '    If Systeme_Stellaire_Point <> Nothing Then
        '        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "LEFT", 1, Systeme_Stellaire_Point.X, Systeme_Stellaire_Point.Y + 18)
        '        Await Task.Delay(1200)

        '        Client_Screen = Update_Screen()
        '        Dim map_detect_point As Point = Client_Screen.Contains(map_detect_ref)

        '        If map_detect_point <> Nothing Then
        '            Cursor.Position = New Point(map_detect_point.X, map_detect_point.Y)
        '        Else
        '            Console.WriteLine("Not found")
        '        End If

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub


    Private Async Sub GoToPalladium(palla)
        '  found_palla = True
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, palla(0), palla(1))

        Dim temps = Task.Delay(Form_Tools.TextBox_palladium_ms.Text)
        Await temps
        '  found_palla = False
    End Sub

    Private Sub Button_bonusbox_Click(sender As Object, e As EventArgs) Handles Button_bonusbox.Click

        Dim Bonus_Box = AutoIt.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 1321834, 5, 1)

        Try
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Bonus_Box(0) - 0, Bonus_Box(1) - 0)
            '  Me.Invoke(New MethodInvoker(Sub() System.Threading.Thread.Sleep(Form_Tools.TextBox_cargobox_ms.Text)))

        Catch Bonus_Box_not_found As Exception
        End Try

    End Sub

    Private Sub Button_cargobox_Click(sender As Object, e As EventArgs) Handles Button_cargobox.Click

        Dim Cargo_Box = AutoIt.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 16777030, 5, 1)

        Try
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Cargo_Box(0) - 0, Cargo_Box(1) - 0)
            '   Me.Invoke(New MethodInvoker(Sub() System.Threading.Thread.Sleep(Form_Tools.TextBox_bonusbox_ms.Text)))

        Catch Cargo_Box_not_found As Exception
        End Try

    End Sub

    Private Sub Button_Bot_Click(sender As Object, e As EventArgs) Handles Button_Bot.Click
        Startup_bot()
    End Sub
End Class

'npc killer

'Try
'    Dim A1 As Integer = (WebBrowser_Game_Ridevbot.Location.X)
'    Dim A2 As Integer = (WebBrowser_Game_Ridevbot.Location.Y - 18)
'    Dim A3 As Integer = (WebBrowser_Game_Ridevbot.Width)
'    Dim A4 As Integer = (WebBrowser_Game_Ridevbot.Height)

'    Dim result = AutoIt.PixelSearch(A1, A2, A3, A4, 13369344, 0, 1)


























'    Console.WriteLine(result)

'    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, result(0) + 40, result(1) - 40)
'    AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (1))
'Catch ex As Exception
'  AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, palla(0), palla(1))
'End Try
























'Dim pt_bouclier As Point = B.Contains(dest_bouclier)
'If pt_bouclier <> Nothing Then
'    '... image found at pt
'    MsgBox($"found logout at {pt_bouclier.X}-{pt_bouclier.Y}")
'    Cursor.Position = New Point(pt_bouclier.X, pt_bouclier.Y + 18)
'End If


'Dim pt_mission1 As Point = B.Contains(dest_mission)
'If pt_mission1 <> Nothing Then
'    '... image found at pt
'    MsgBox($"found mission at {pt_mission1.X}-{pt_mission1.Y}")
'    Cursor.Position = New Point(pt_mission1.X, pt_mission1.Y + 18)
'End If

'Dim pt_map As Point = B.Contains(dest_map)
'If pt_map <> Nothing Then
'    '... image found at pt
'    MsgBox($"found map at {pt_map.X}-{pt_map.Y}")
'    Cursor.Position = New Point(pt_map.X, pt_map.Y + 18)
















' Dim dest_heal = My.Resources.heal