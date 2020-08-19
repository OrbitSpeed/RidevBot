Imports System.ComponentModel
Imports AutoItX3Lib

Public Class Form_Game
    Declare Function BlockInput Lib "user32" (ByVal fBlockIt As Boolean) As Boolean


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

        If Form_Tools.textbox_stade.Text = "Launching the game wait ... " Then
            Form_Tools.textbox_stade.Text = "Game loaded. Have fun botting !"
        End If

        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

    End Sub


    Private Sub Form_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        If BackgroundWorker_Performance.IsBusy = False Then
            BackgroundWorker_Performance.RunWorkerAsync()
        End If


        'Traveling_module()
    End Sub

    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    ' █                                                                                                                                █
    ' █                                                          RidevBot BOT                                                          █
    ' █                                                                                                                                █
    ' █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█

    ' ici se trouve toute les déclaration et les variables utiles pour le bot
#Region "Declarations -- fonction Update screen -- Var.Multiple"

    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄

    Function Update_Screen()
        Dim Client_primary = New Bitmap(WebBrowser_Game_Ridevbot.ClientSize.Width, WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Invoke(New MethodInvoker(Sub()
                                     Client_second.CopyFromScreen(PointToScreen(WebBrowser_Game_Ridevbot.Location), New Point(0, 0), WebBrowser_Game_Ridevbot.ClientSize)
                                 End Sub))
        Return Client_primary
        'Client_primary.Save($"screenshot.jpg", ImageFormat.Jpeg)
    End Function

    Public User_Stop_Bot As Boolean = True
    Public CurrentMapUser = "0-0"
    Dim Client_Screen As Bitmap
    Dim save_point_x As String = 0
    Dim save_point_Y As String = 0
    Dim passage As String = 0

    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
#End Region

    ' Pour utiliser ce referer a " CHECKING MINIMAP "
#Region "Var.disconedcted -- Var.map location -- Fonction Minimap -- fonction deconnecté et reconnexion --- Resize/Reduce and place"


    ' ⚡ VARIABLES ⚡ 
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '  ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 
#Region "⚡ VARIABLES DISCONECTED ⚡"

    Dim Disconnected = My.Resources.Disconnected
#End Region

#Region "⚡ VARIABLES MAP LOCATION ⚡"

    Dim System_box_move As Boolean = False

    Dim Minimap_closed_ref = My.Resources.Minimap_closed
    Dim Minimap_size_ref = My.Resources.Minimap_reduce
    Dim Move_minimap_box_ref = My.Resources.Move_box
    Dim systeme_stellaire_ref = My.Resources.systeme_stellaire
    Dim map_detect_ref = My.Resources.map_detect
    Dim deconnection_popup_visible = My.Resources.Deconnection_popup_encore_visible

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
#End Region
    '  ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲                          
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    ' ⚡ VARIABLES ⚡









    ' ⚡ MODULE MINIMAP ⚡ 
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '  ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 
#Region "Checking/reducing/moving and saving minimap"

    Private BackgroundWorker_Startup_Bot_Rework As Boolean
    Private Async Sub BackgroundWorker_Startup_Bot_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Startup_Bot.DoWork

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        'Try
        Invoke(New MethodInvoker(Sub()
                                     WebBrowser_Game_Ridevbot.Select()
                                 End Sub))
        'Catch ex As Exception
        '    Console.WriteLine($"[ERROR - STR0] Connection_lost_error error! {ex.Message}")
        '    BackgroundWorker_Startup_Bot_Rework = True
        'End Try

        Client_Screen = Update_Screen()

        ' if machin
        'alors tu fais ça
        'exit sub
        'end if

        'Try
        Dim Connection_Lost As Point = Client_Screen.Contains(Disconnected)
        If Connection_Lost <> Nothing Then

            Reconnexion()
            Exit Sub

        End If

        'Catch Connection_lost_error As Exception
        '    Console.WriteLine($"[ERROR - STR1] Connection_lost_error error! {Connection_lost_error.Message}")
        '    BackgroundWorker_Startup_Bot_Rework = True
        '    'Startup_bot()
        'End Try

        'Try
        Client_Screen = Update_Screen()
        Dim Save_point_original As Point = Client_Screen.Contains(Minimap_size_ref)


        If Save_point_original.X = "762" Then
            BackgroundWorker_Checking_minimap.RunWorkerAsync()
            Exit Sub
        End If

        'Catch map_error As Exception
        '    Console.WriteLine($"[ERROR - STR2] map_error error! {map_error.Message}")
        '    BackgroundWorker_Startup_Bot_Rework = True
        '    'Startup_bot()
        'End Try

        'Try
        Invoke(New MethodInvoker(Sub()
                                     AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
                                     Form_Tools.TextBox_desactive_allkey.Refresh()
                                     Form_Tools.TextBox_desactive_allkey.Update()
                                     AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_desactive_allkey.Text))
                                 End Sub))
        Await Task.Delay(800)
        BackgroundWorker_Detection_minimap.RunWorkerAsync()
        'Catch ex As Exception
        '    Console.WriteLine($"[ERROR - STR3] Startup_Bot error! {ex.Message}")
        '    BackgroundWorker_Startup_Bot_Rework = True
        '    'Startup_bot()
        'End Try
    End Sub
    Private Sub BackgroundWorker_Startup_Bot_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_Startup_Bot.RunWorkerCompleted
        If BackgroundWorker_Startup_Bot_Rework = True Then
            BackgroundWorker_Startup_Bot_Rework = False
            BackgroundWorker_Startup_Bot.RunWorkerAsync()
        End If
    End Sub


    Private BackgroundWorker_Detection_minimap_Rework As Boolean
    Private Sub BackgroundWorker_Detection_minimap_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Detection_minimap.DoWork
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If


        'Try
        Client_Screen = Update_Screen()
        System_box_move = False

        Dim Minimap_closed As Point = Client_Screen.Contains(Minimap_closed_ref)
        If Minimap_closed <> Nothing Then
            Invoke(New MethodInvoker(Async Sub()
                                         WebBrowser_Game_Ridevbot.Select()
                                         AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_closed.X, Minimap_closed.Y + 18)
                                         Await Task.Delay(800)
                                         Console.WriteLine("Detection minimap ok")
                                         BackgroundWorker_Reduce_minimap.RunWorkerAsync()
                                     End Sub))
        Else
            BackgroundWorker_Startup_Bot.RunWorkerAsync()
        End If

        'Catch Minimap_opened_error As Exception
        '    Console.WriteLine($"[MNMAP_0] Minimap_opened error! {Minimap_opened_error.Message}")
        'End Try
    End Sub
    Private Sub BackgroundWorker_Detection_minimap_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_Detection_minimap.RunWorkerCompleted
        If BackgroundWorker_Detection_minimap_Rework = True Then
            BackgroundWorker_Detection_minimap_Rework = False
            BackgroundWorker_Detection_minimap.RunWorkerAsync()
        End If
    End Sub


    'Private BackgroundWorker_reduce_minimap_Rework As Boolean
    Private Async Sub BackgroundWorker_Reduce_minimap_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Reduce_minimap.DoWork
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If


        'Try
        Client_Screen = Update_Screen()
        Dim Minimap_size As Point = Client_Screen.Contains(Minimap_size_ref)
        Dim compare As Point

        If Minimap_size <> Nothing Then

            For i = 0 To 15
                Await Task.Delay(60)
                'Dim cursor_Pos = Cursor.Position
                Client_Screen = Update_Screen()
                Minimap_size = Client_Screen.Contains(Minimap_size_ref)
                If Minimap_size <> Nothing Then
                    If compare = Minimap_size Then
                        i = 15
                        Console.WriteLine("Réduction faite")
                        Invoke(New MethodInvoker(Sub()
                                                     'Await Task.Delay(1000)
                                                     BackgroundWorker_Deplacement_minimap_bas_droite.RunWorkerAsync()
                                                 End Sub))
                        BackgroundWorker_Reduce_minimap.CancelAsync()
                    Else
                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_size.X, Minimap_size.Y)

                        compare = Minimap_size
                    End If
                End If
                'Cursor.Position = cursor_Pos
            Next
            'BackgroundWorker_Reduce_minimap.CancelAsync()
            'Invoke(New MethodInvoker(Async Sub()
            '                             Console.WriteLine("Passé par la trappe")
            '                             AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_size.X, Minimap_size.Y)
            '                             Await Task.Delay(1000)
            '                             BackgroundWorker_Deplacement_minimap_bas_droite.RunWorkerAsync()
            '                         End Sub))
        Else
            If System_box_move = True Then
                BackgroundWorker_Startup_Bot.RunWorkerAsync()
            Else
                BackgroundWorker_Detection_minimap.RunWorkerAsync()
            End If
        End If

        'Catch Reduction_minimap_error As Exception
        '    Console.WriteLine($"Reduction_minimap_error error! {vbNewLine}{Reduction_minimap_error.Message}{vbNewLine}------")
        'End Try
    End Sub

    Private Sub BackgroundWorker_Deplacement_minimap_bas_droite_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Deplacement_minimap_bas_droite.DoWork
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Client_Screen = Update_Screen()

        'Try
        Dim Minimap_move As Point = Client_Screen.Contains(Move_minimap_box_ref)

        If Minimap_move <> Nothing Then

            Invoke(New MethodInvoker(Async Sub()
                                         BlockInput(True)
                                         Dim cursor_Pos = Cursor.Position
                                         Cursor.Position = New Point(Minimap_move.X - 40, Minimap_move.Y + 20)
                                         AutoIt.MouseDown("LEFT")
                                         Await Task.Delay(100)
                                         Cursor.Position = New Point(759, 599)
                                         AutoIt.MouseUp("LEFT")
                                         Cursor.Position = cursor_Pos
                                         'Await Task.Delay(1200)
                                         Console.WriteLine("déplacement minimap ok")
                                         BlockInput(False)

                                         Checking_map_actuel(True)
                                         User_Stop_Bot = False
                                         Stop_Bot()
                                     End Sub))
        Else
            System_box_move = True
            BackgroundWorker_Reduce_minimap.RunWorkerAsync()
        End If

        'Catch Deplacement_minimap_bas_droite_error As Exception
        '    Console.WriteLine($"Deplacement_minimap_bas_droite_error error! {Deplacement_minimap_bas_droite_error.Message}")

        'End Try
    End Sub

#End Region
    '  ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲                          
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    ' ⚡ MODULE MINIMAP ⚡











    ' ⚡ CHECKING MINIMAP / CHECK DANS QUEL MAP IL SE TROUVE / CHECK SI ON EST DECONNECTER ⚡ 
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '  ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 
    ' CHECKING MINIMAP
    Private Sub BackgroundWorker_Checking_minimap_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Checking_minimap.DoWork

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Client_Screen = Update_Screen()
        Dim Save_point_original As Point = Client_Screen.Contains(Minimap_size_ref)

        If Save_point_original.X = "762" Then
            'Await Task.Delay(1000)
            Console.WriteLine("relance")

            Dim Connection_Lost As Point = Client_Screen.Contains(Disconnected)
            If Connection_Lost <> Nothing Then

                Reconnexion()
                Exit Sub

            End If

            Checking_map_actuel(True)

            Console.WriteLine("On boucle sur checking_minimap")
            'User_Stop_Bot = False
            'BackgroundWorker_Checking_minimap.CancelAsync()
            Stop_Bot()
        Else
            BackgroundWorker_Startup_Bot.RunWorkerAsync()
        End If

        'Try
        'Catch Aucune_map_trouve_error As Exception
        '    Console.WriteLine($"Aucune_map_trouve_error! {Aucune_map_trouve_error.Message}")
        '    Dim st As New StackTrace(True)
        '    st = New StackTrace(Aucune_map_trouve_error, True)
        '    Console.WriteLine("Line: " & st.GetFrame(0).GetFileLineNumber().ToString)
        '    Console.WriteLine("-------")

        'End Try



    End Sub

    Private Sub Checking_map_actuel(Optional UpdateOnly As Boolean = False)

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Client_Screen = Update_Screen()

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


        Try
            Invoke(New MethodInvoker(Sub()
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
                                         Console.WriteLine("On a récupéré la map")
                                         If UpdateOnly = False Then
                                             BackgroundWorker_Checking_minimap.RunWorkerAsync()
                                         End If
                                     End Sub))

        Catch detect_map_error As Exception
            Console.WriteLine($"Error on the map detector: {detect_map_error.Message}")
        End Try

    End Sub

    Private Async Sub Reconnexion()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        'Try
        Client_Screen = Update_Screen()
        Dim Connection_Lost As Point = Client_Screen.Contains(Disconnected)

        If Connection_Lost <> Nothing Then
            'Cursor.Position = New Point(300, 354 + 18)
            'Await Task.Delay(1000)

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 300, 354)
            Console.WriteLine("Reconnexion")
            Await Task.Delay(7000)
            'Try
            Client_Screen = Update_Screen()
            Dim deconnection_popup As Point = Client_Screen.Contains(deconnection_popup_visible)

            If deconnection_popup <> Nothing Then
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 409, 348)
                Await Task.Delay(1000)
                BackgroundWorker_Checking_minimap.RunWorkerAsync()
            Else
                BackgroundWorker_Checking_minimap.RunWorkerAsync()
            End If
            'Catch detection_popup_error As Exception

            '    Console.WriteLine($"detection_popup_error {detection_popup_error.Message}")
            '    BackgroundWorker_Checking_minimap.RunWorkerAsync()
            'End Try
            'BackgroundWorker_Checking_minimap.CancelAsync()
            'Await Task.Delay(750)
            'BackgroundWorker_Checking_minimap.RunWorkerAsync() '--
        Else
            Console.WriteLine("Reconnexion introuvable")
            BackgroundWorker_Checking_minimap.RunWorkerAsync()
        End If

        'Catch Reconnection_errror As Exception

        '    Console.WriteLine($"Reconnection error {Reconnection_errror.Message}")
        '    BackgroundWorker_Checking_minimap.RunWorkerAsync()

        'End Try



    End Sub

    '  ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲                          
    ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    ' ⚡ MODULE MINIMAP ⚡

#End Region









#Region "Click Zone"

    Private Async Sub PORTAIL_1BL_MMO()
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 691, 556)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Sub

    Private Sub PORTAIL_2BL_EIC()
    End Sub

    Private Sub PORTAIL_3BL_VRU()
    End Sub

    Private Async Sub PORTAIL_15_TO_44()
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 764, 517)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Sub
    Private Async Sub PORTAIL_44_to_15()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 623, 523)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub

    Private Sub PORTAIL_25_TO_44()
    End Sub
    Private Async Sub PORTAIL_44_to_25()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 720, 467)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub

    Private Sub PORTAIL_35_TO_44()
    End Sub
    Private Async Sub PORTAIL_44_to_35()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 718, 575)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub

    Private Async Sub PORTAIL_44_to_41()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 679, 522)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_44_to_42()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 691, 515)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_44_to_43()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 691, 527)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub



    Private Async Sub PORTAIL_45_to_15()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 621, 517)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_45_to_25()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 717, 463)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_45_to_35()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 717, 571)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_45_to_51_MMO()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 645, 517)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_45_to_51_EIC()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 703, 486)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_45_to_51_VRU()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 703, 550)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub


















    Private Async Sub PORTAIL_45_MMO()
        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 683, 570)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()
    End Sub
    Private Sub PORTAIL_45_EIC()
    End Sub
    Private Sub PORTAIL_45_VRU()
    End Sub



    Private Async Sub PORTAIL_HAUT_DROITE()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        'HAUT DROITE 
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 760, 480)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_HAUT_GAUCHE()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' HAUT GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 610, 478)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_BAS_DROITE()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS DROITE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 760, 562)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub
    Private Async Sub PORTAIL_BAS_GAUCHE()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        ' BAS GAUCHE
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 610, 569)
        Await Task.Delay(10000)
        POINT_DE_CHUTE_DU_CLICK_TRAVELING()

    End Sub

#End Region

    Private Async Sub POINT_DE_CHUTE_DU_CLICK_TRAVELING()

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Dim Map_actuelle_reconize = Label_map_location.Text.Replace("Map : ", "")
        Dim Map_roaming_reconize = Form_Tools.ComboBox_map_to_travel.Text
        Console.WriteLine(Map_actuelle_reconize)
        Console.WriteLine(Map_roaming_reconize)

        If Map_actuelle_reconize <> Map_roaming_reconize Then

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
            AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "J")
            Console.WriteLine("Point de chute du click traveling atteint and Sended J")
            Await Task.Delay(10000)
            Checking_map_actuel(True)
            Traveling_module()

        Else

            Await Task.Delay(10000)
            Console.WriteLine("On relance Traveling par Point de chute")
            Traveling_module()

        End If

    End Sub

    Public Async Sub Traveling_module()

        'For Each bg_worker As BackgroundWorker In (Of BackgroundWorker)
        '    bg_worker.CancelAsync()
        '    Console.WriteLine($"Le bg_worker: '{bg_worker}' a été arrêté")
        'Next

        If User_Stop_Bot Then
            Stop_Bot()
            Exit Sub
        End If

        Client_Screen = Update_Screen()

        Dim Connection_Lost As Point = Client_Screen.Contains(Disconnected)
        If Connection_Lost <> Nothing Then

            If BackgroundWorker_Startup_Bot.IsBusy = False Then
                BackgroundWorker_Startup_Bot.RunWorkerAsync()
                Exit Sub
            End If

        End If

        Dim Save_point_original As Point = Client_Screen.Contains(Minimap_size_ref)
        If Save_point_original.X = "762" Then
            'Await Task.Delay(1000)
            Console.WriteLine("Minimap au bon endroit")

        Else
            If BackgroundWorker_Startup_Bot.IsBusy = False Then
                BackgroundWorker_Startup_Bot.RunWorkerAsync()
                Exit Sub
            End If
        End If

        If BackgroundWorker_Startup_Bot.IsBusy Or
            BackgroundWorker_Checking_minimap.IsBusy Or
            BackgroundWorker_Deplacement_minimap_bas_droite.IsBusy Or
            BackgroundWorker_Detection_minimap.IsBusy Or
            BackgroundWorker_Reduce_minimap.IsBusy Then

            'Await Task.Delay(350)
            Console.WriteLine($"Les backgrounds sont en cours, on coupe tout")
            User_Stop_Bot = True
            BackgroundWorker_Startup_Bot.CancelAsync()
            BackgroundWorker_Checking_minimap.CancelAsync()
            BackgroundWorker_Deplacement_minimap_bas_droite.CancelAsync()
            BackgroundWorker_Detection_minimap.CancelAsync()
            BackgroundWorker_Reduce_minimap.CancelAsync()
            Await Task.Delay(3200)
            User_Stop_Bot = False
        Else


            Dim Map_actuelle = Label_map_location.Text.Split(" : ")(2)
            Dim Map_roaming = Form_Tools.ComboBox_map_to_travel.Text

            Console.WriteLine(Map_actuelle)
            Console.WriteLine(Map_roaming)
            Console.WriteLine("Calcul de l'itinéraire")

            '  Or
            ' Map_roaming = ""

            If Map_actuelle <> Map_roaming Then




#Region "MAP = 1-8 ---------- "
                If Map_actuelle = "1-8" AndAlso Map_roaming = "1-6" Then
                    PORTAIL_HAUT_DROITE()

                ElseIf Map_actuelle = "1-8" AndAlso
                    (Map_roaming = "1-BL" Or "2-BL" Or "3-BL") Then
                    PORTAIL_1BL_MMO()

                ElseIf Map_actuelle = "1-8" AndAlso
                    (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-7" Or
                    Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                    Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or "3-6" Or "3-7" Or "3-8" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then
                    PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 1-7 ---------- "
                ElseIf Map_actuelle = "1-7" AndAlso
                    (Map_roaming = "1-6" Or Map_roaming = "1-8" Or
                    Map_roaming = "1-BL" Or Map_roaming = "2-BL" Or Map_roaming = "3-BL") Then

                    PORTAIL_HAUT_GAUCHE()

                ElseIf Map_actuelle = "1-7" AndAlso
                    (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or
                    Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                    Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or "3-6" Or "3-7" Or "3-8" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then

                    PORTAIL_HAUT_DROITE()
#End Region ' VALIDER
#Region "MAP = 1-6 ---------- "
                ElseIf Map_actuelle = "1-6" AndAlso
                    (Map_roaming = "1-7" Or "1-8" Or
                    Map_roaming = "1-BL" Or "2-BL" Or "3-BL") Then

                    PORTAIL_BAS_GAUCHE()

                ElseIf Map_actuelle = "1-6" AndAlso
                    (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or
                    Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                    Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or "3-6" Or "3-7" Or "3-8" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then

                    PORTAIL_BAS_DROITE()
#End Region ' VALIDER
#Region "MAP = 1-5 ---------- "
                ElseIf Map_actuelle = "1-5" AndAlso
                    (Map_roaming = "1-7" Or "1-8" Or
                    Map_roaming = "1-BL" Or "2-BL" Or "3-BL") Then

                    PORTAIL_BAS_GAUCHE()

                ElseIf Map_actuelle = "1-5" AndAlso Map_roaming = "1-6" Then

                    PORTAIL_HAUT_GAUCHE()

                ElseIf Map_actuelle = "1-5" AndAlso
                   (Map_roaming = "4-5" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "2-5" Or "3-5") Then

                    PORTAIL_45_MMO()

                ElseIf Map_actuelle = "1-5" AndAlso
                       (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or
                        Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-6" Or "2-7" Or "2-8" Or
                        Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-6" Or "3-7" Or "3-8" Or
                        Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4") Then

                    PORTAIL_15_TO_44()
#End Region ' VALIDER
#Region "MAP = 2-8 ---------- "

                ElseIf Map_actuelle = "2-8" AndAlso Map_roaming = "2-6" Then
                    PORTAIL_BAS_GAUCHE()

                ElseIf Map_actuelle = "2-8" AndAlso
                            (Map_roaming = "2-BL" Or "3-BL" Or "1-BL") Then
                    PORTAIL_2BL_EIC()

                ElseIf Map_actuelle = "2-8" AndAlso
                            (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                            Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-7" Or
                            Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or "3-6" Or "3-7" Or "3-8" Or
                            Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                            Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then
                    PORTAIL_BAS_DROITE()

#End Region ' VALIDER
#Region "MAP = 2-7 ---------- "

                ElseIf Map_actuelle = "2-7" AndAlso
                (Map_roaming = "2-6" Or Map_roaming = "2-8" Or
                Map_roaming = "2-BL" Or Map_roaming = "3-BL" Or Map_roaming = "1-BL") Then
                    PORTAIL_HAUT_DROITE()

                ElseIf Map_actuelle = "2-7" AndAlso
                    (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                    Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or
                    Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or "3-6" Or "3-7" Or "3-8" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then
                    PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 2-6 ---------- "

                ElseIf Map_actuelle = "2-6" AndAlso
             (Map_roaming = "2-7" Or "2-8" Or
             Map_roaming = "2-BL" Or "3-BL" Or "1-BL") Then

                    PORTAIL_HAUT_DROITE()

                ElseIf Map_actuelle = "2-6" AndAlso
                    (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                    Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or
                    Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or "3-6" Or "3-7" Or "3-8" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then

                    PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 2-5 ---------- "

                ElseIf Map_actuelle = "2-5" AndAlso
                   (Map_roaming = "2-7" Or "2-8" Or
                    map_roaming = "2-BL" Or "3-BL" Or "1-BL") Then
                    PORTAIL_HAUT_DROITE()

                ElseIf Map_actuelle = "2-5" AndAlso Map_roaming = "2-6" Then
                    PORTAIL_HAUT_GAUCHE()

                ElseIf Map_actuelle = "2-5" AndAlso
                   (Map_roaming = "4-5" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "3-5" Or "1-5") Then
                    PORTAIL_45_EIC()

                ElseIf Map_actuelle = "1-5" AndAlso
                       (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or
                        Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-6" Or "2-7" Or "2-8" Or
                        Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-6" Or "3-7" Or "3-8" Or
                        Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4") Then
                    PORTAIL_25_TO_44()

#End Region ' VALIDER
#Region "MAP = 3-8 ---------- "
                ElseIf Map_actuelle = "3-8" AndAlso Map_roaming = "3-6" Then
                    PORTAIL_BAS_GAUCHE()

                ElseIf Map_actuelle = "3-8" AndAlso
                        (Map_roaming = "3-BL" Or "1-BL" Or "2-BL") Then
                    PORTAIL_3BL_VRU()

                ElseIf Map_actuelle = "3-8" AndAlso
                        (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                        Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                        Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or "3-7" Or
                        Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                        Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then

                    PORTAIL_BAS_DROITE()
#End Region ' VALIDER
#Region "MAP = 3-7 ---------- "

                ElseIf Map_actuelle = "3-7" AndAlso
                (Map_roaming = "3-6" Or Map_roaming = "3-8" Or
                Map_roaming = "3-BL" Or Map_roaming = "1-BL" Or Map_roaming = "2-BL") Then
                    PORTAIL_BAS_DROITE()

                ElseIf Map_actuelle = "3-7" AndAlso
                    (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                    Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                    Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then
                    PORTAIL_BAS_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 3-6 ---------- "

                ElseIf Map_actuelle = "3-6" AndAlso
             (Map_roaming = "3-7" Or "3-8" Or
             Map_roaming = "3-BL" Or "1-BL" Or "2-BL") Then
                    PORTAIL_BAS_DROITE()

                ElseIf Map_actuelle = "3-6" AndAlso
                    (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                    Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                    Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-5" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or "4-5") Then
                    PORTAIL_HAUT_GAUCHE()

#End Region ' VALIDER
#Region "MAP = 3-5 ---------- "

                ElseIf Map_actuelle = "3-5" AndAlso
                   (Map_roaming = "3-7" Or "3-8" Or
                    Map_roaming = "3-BL" Or "1-BL" Or "2-BL") Then
                    PORTAIL_BAS_DROITE()

                ElseIf Map_actuelle = "3-5" AndAlso Map_roaming = "3-6" Then
                    PORTAIL_BAS_GAUCHE()

                ElseIf Map_actuelle = "2-5" AndAlso
                   (Map_roaming = "4-5" Or
                    Map_roaming = "5-1" Or "5-2" Or "5-3" Or
                    Map_roaming = "3-5" Or "1-5") Then
                    PORTAIL_45_VRU()

                ElseIf Map_actuelle = "1-5" AndAlso
                       (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or
                        Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-6" Or "2-7" Or "2-8" Or
                        Map_roaming = "3-1" Or "3-2" Or "3-3" Or "3-4" Or "3-6" Or "3-7" Or "3-8" Or
                        Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4") Then
                    PORTAIL_35_TO_44()

#End Region ' VALIDER
#Region "MAP = 4-4 ---------- "

                ElseIf Map_actuelle = "4-4" AndAlso
                    (Map_roaming = "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                    Map_roaming = "1-BL") Then
                    PORTAIL_44_to_15()

                ElseIf Map_actuelle = "4-4" AndAlso
                  (Map_roaming = "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                Map_roaming = "2-BL") Then
                    PORTAIL_44_to_25()

                ElseIf Map_actuelle = "4-4" AndAlso
              (Map_roaming = "3-5" Or "3-6" Or "3-7" Or "3-8" Or
            Map_roaming = "3-BL") Then
                    PORTAIL_44_to_35()

                    ' If mmo pour savoir par quel portail allez pour la 4-5

                ElseIf Map_actuelle = "4-4" AndAlso Form_Tools.ComboBox_firme.Text = "MMO" AndAlso
               (Map_roaming = "4-5" Or "5-1" Or "5-2" Or "5-3") Then
                    PORTAIL_44_to_15()

                ElseIf Map_actuelle = "4-4" AndAlso Form_Tools.ComboBox_firme.Text = "EIC" AndAlso
               (Map_roaming = "4-5" Or "5-1" Or "5-2" Or "5-3") Then
                    PORTAIL_44_to_25()

                ElseIf Map_actuelle = "4-4" AndAlso Form_Tools.ComboBox_firme.Text = "VRU" AndAlso
               (Map_roaming = "4-5" Or "5-1" Or "5-2" Or "5-3") Then
                    PORTAIL_44_to_35()


                ElseIf Map_actuelle = "4-4" AndAlso
          (Map_roaming = "4-1" Or "1-1" Or "1-2" Or "1-3" Or "1-4") Then
                    PORTAIL_44_to_41()

                ElseIf Map_actuelle = "4-4" AndAlso
 (Map_roaming = "4-1" Or "1-1" Or "1-2" Or "1-3" Or "1-4") Then
                    PORTAIL_44_to_42()

                ElseIf Map_actuelle = "4-4" AndAlso
 (Map_roaming = "4-3" Or "3-1" Or "3-2" Or "3-3" Or "3-4") Then
                    PORTAIL_44_to_43()


#End Region ' VALIDER
#Region "MAP = 4-5 ---------- "

                ElseIf Map_actuelle = "4-5" AndAlso Form_Tools.ComboBox_firme.Text = "MMO" AndAlso
                        (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                         Map_roaming = "4-1" Or "4-2" Or "4-3" Or "4-4" Or
                         Map_roaming = "1-BL") Then
                    PORTAIL_45_to_15()

                ElseIf Map_actuelle = "4-5" AndAlso Form_Tools.ComboBox_firme.Text = "EIC" AndAlso
                        (Map_roaming = "2-1" Or "2-2" Or "2-3" Or "2-4" Or "2-5" Or "2-6" Or "2-7" Or "2-8" Or
                         Map_roaming = "4-2" Or "4-3" Or "4-1" Or "4-4" Or
                         Map_roaming = "2-BL") Then
                    PORTAIL_45_to_25()

                ElseIf Map_actuelle = "4-5" AndAlso Form_Tools.ComboBox_firme.Text = "VRU" AndAlso
                        (Map_roaming = "1-1" Or "1-2" Or "1-3" Or "1-4" Or "1-5" Or "1-6" Or "1-7" Or "1-8" Or
                         Map_roaming = "4-3" Or "4-1" Or "4-3" Or "4-2" Or
                         Map_roaming = "3-BL") Then
                    PORTAIL_45_to_35()

#End Region


























                Else
                        'On ne trouve pas la map à aller ?
                        Await Task.Delay(10000)
                    Console.WriteLine("On relance Traveling Module")
                    Traveling_module()
                End If

            Else
                If BackgroundWorker_Startup_Bot.IsBusy = False Then
                    BackgroundWorker_Startup_Bot.RunWorkerAsync()
                    Console.WriteLine("On relance le startup (Traveling_module)")
                End If

            End If

        End If

    End Sub

    Public Sub Stop_Bot()
        If User_Stop_Bot Then
            Console.WriteLine("Stopped")
            User_Stop_Bot = False

        Else
            Console.WriteLine("User_Stop_Bot en true")
            If BackgroundWorker_Checking_minimap.IsBusy = False Then
                Console.WriteLine("Checking minimap n'est pas busy")
                BackgroundWorker_Checking_minimap.RunWorkerAsync()
                Console.WriteLine("On relance tous les background worker")

            Else
                Console.WriteLine("Checking minimap est busy")
                'Await Task.Delay(600)

                'If BackgroundWorker_Checking_minimap.IsBusy = False Then
                '    Console.WriteLine("Checking minimap est OFF (2nd check)")
                '    BackgroundWorker_Checking_minimap.RunWorkerAsync()
                '    Console.WriteLine("On relance tous les background worker (2nd check)")

                'End If
            End If
        End If

    End Sub


    Private Async Sub GoToPalladium(palla)
        '  found_palla = True
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, palla(0), palla(1))

        Dim temps = Task.Delay(Form_Tools.TextBox_palladium_ms.Text)
        Await temps
        '  found_palla = False
    End Sub

    Private Sub Button_bonusbox_Click(sender As Object, e As EventArgs) Handles Button_bonusbox.Click

        Traveling_module()

        'Dim Bonus_Box = AutoIt.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 1321834, 5, 1)

        'Try
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Bonus_Box(0) - 0, Bonus_Box(1) - 0)
        '    '  Me.Invoke(New MethodInvoker(Sub() System.Threading.Thread.Sleep(Form_Tools.TextBox_cargobox_ms.Text)))

        'Catch Bonus_Box_not_found As Exception
        'End Try

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
        BackgroundWorker_Startup_Bot.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_Performance_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Performance.DoWork
        Dim myProcess = Process.GetCurrentProcess()

        'Console.WriteLine($"{myProcess} -")
        'Console.WriteLine("-------------------------------------")
        'Console.WriteLine($"  Physical memory usage     : {Convert.ToInt32(myProcess.WorkingSet64 / (1024.0F * 1024.0F))}")
        'Console.WriteLine($"  Base priority             : {myProcess.BasePriority}")
        'Console.WriteLine($"  Priority class            : {myProcess.PriorityClass}")
        'Console.WriteLine($"  User processor time       : {myProcess.UserProcessorTime}")
        'Console.WriteLine($"  Privileged processor time : {myProcess.PrivilegedProcessorTime}")
        'Console.WriteLine($"  Total processor time      : {myProcess.TotalProcessorTime}")
        'Console.WriteLine($"  Paged system memory size  : {myProcess.PagedSystemMemorySize64}")
        'Console.WriteLine($"  Paged memory size         : {myProcess.PagedMemorySize64}")

        'Console.WriteLine(My.Computer.Info.TotalPhysicalMemory)
        'Console.WriteLine($"{Convert.ToInt32(My.Computer.Info.TotalPhysicalMemory / (1024.0F * 1024.0F * 1024.0F))}")

        Try
            Invoke(New MethodInvoker(Sub()
                                         Label_PerformanceMemoire.Text = $"RAM Used: {Convert.ToInt32(myProcess.WorkingSet64 / (1024.0F * 1024.0F))} Mo"
                                         Label_PerformanceMemoire.Update()
                                     End Sub))
        Catch ex As Exception
        End Try

    End Sub

    Private Async Sub BackgroundWorker_Performance_RunWorkCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_Performance.RunWorkerCompleted
        If BackgroundWorker_Performance.IsBusy = False Then
            Await Task.Delay(100)
            BackgroundWorker_Performance.RunWorkerAsync()
        End If
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


















' pour le click souris + blocage

'BlockInput(True)
'Console.WriteLine("désactivé")

'Cursor.Position = New Point(Minimap_size.X, Minimap_size.Y + 18)
'AutoIt.MouseClick("LEFT")

'BlockInput(False)
'Console.WriteLine("activé")









' Dim dest_heal = My.Resources.heal