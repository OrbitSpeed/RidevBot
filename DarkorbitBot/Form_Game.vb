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
    ' ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 









    Public Stop_bot As Boolean = False
    Function Checking_screen()

        Dim Client_primary = New Bitmap(WebBrowser_Game_Ridevbot.ClientSize.Width, WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Client_second.CopyFromScreen(PointToScreen(WebBrowser_Game_Ridevbot.Location), New Point(0, 0), WebBrowser_Game_Ridevbot.ClientSize)
        Return Client_primary
        'Client_primary.Save($"screenshot.jpg", ImageFormat.Jpeg)
    End Function

    Dim System_box_move As Boolean = False
    Dim save_point_x As String = 0
    Dim save_point_Y As String = 0
    Dim passage As String = 0

    Dim Minimap_closed_ref = My.Resources.Minimap_closed
    Dim Minimap_size_ref = My.Resources.Minimap_reduce
    Dim Move_minimap_box_ref = My.Resources.Move_box
    Dim systeme_stellaire_ref = My.Resources.systeme_stellaire
    Dim map_detect_ref = My.Resources.map_detect

    Dim Client_Screen As Bitmap

    Private Async Sub Startup_bot()

        WebBrowser_Game_Ridevbot.Select()
        Client_Screen = Checking_screen()


        ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
        ' █                                                            █
        ' █             Effectue un click au centre du browser         █
        ' █              appel les variables et les assignes           █
        ' █                                                            █
        ' █                          < Balise 1 >                      █
        ' █                                                            █
        ' █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 

        If Stop_bot Then Exit_Bot()

        'Try
        '    Dim Save_point_original As Point = Client_Screen.Contains(Minimap_size_ref)

        '    If Save_point_original.X = "440" Then

        '        GoTo Label_Minimap_ok

        '    Else
        '    End If

        '    GoTo Label_HOME_lancement_du_bot
        'Catch map_error As Exception
        'End Try

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
        If Stop_bot Then Exit_Bot()


        Try
            Client_Screen = Checking_screen()
            System_box_move = False

            Dim Minimap_closed As Point = Client_Screen.Contains(Minimap_closed_ref)
            If Minimap_closed <> Nothing Then
                WebBrowser_Game_Ridevbot.Select()
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_closed.X, Minimap_closed.Y + 18)
                Await Task.Delay(3000)
                Reduction_minimap()
            Else
                Startup_bot()
            End If

        Catch Minimap_opened As Exception
            Console.WriteLine($"Minimap_opened error! {Minimap_opened.Message}")
        End Try

    End Sub

    Private Async Sub Reduction_minimap()
        If Stop_bot Then Exit_Bot()


        Try
            Client_Screen = Checking_screen()
            Dim Minimap_size As Point = Client_Screen.Contains(Minimap_size_ref)
            Dim compare As Point

            If Minimap_size <> Nothing Then

                For i = 0 To 15
                    Await Task.Delay(120)
                    Dim cursor_Pos = Cursor.Position
                    Client_Screen = Checking_screen()
                    Minimap_size = Client_Screen.Contains(Minimap_size_ref)
                    If Minimap_size <> Nothing Then
                        If compare = Minimap_size Then
                            i = 20
                            Console.WriteLine("Similaire, on skip")
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
        If Stop_bot Then Exit_Bot()

        Client_Screen = Checking_screen()

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
                Exit_Bot()
            Else
                System_box_move = True
                Reduction_minimap()
            End If

        Catch Deplacement_minimap_bas_droite_error As Exception
            Console.WriteLine($"Deplacement_minimap_bas_droite_error error! {Deplacement_minimap_bas_droite_error.Message}")

        End Try

        Await Task.Delay(2000)
        Console.WriteLine("minimap ok")
    End Sub


    Private Sub Checking_minimap()
        Try













        Catch Aucune_map_trouve As Exception
            Console.WriteLine($"Aucune_map_trouve error! {Aucune_map_trouve.Message}")

        End Try




        MsgBox("relance")
    End Sub

    Private Sub Exit_Bot()
        If Stop_bot Then
            MsgBox("Stopped")
        Else
            Startup_bot()
        End If


        'Try

        '    Dim Systeme_Stellaire_Point As Point = Client_Screen.Contains(systeme_stellaire_ref)

        '    If Systeme_Stellaire_Point <> Nothing Then
        '        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "LEFT", 1, Systeme_Stellaire_Point.X, Systeme_Stellaire_Point.Y + 18)
        '        Await Task.Delay(1200)

        '        Client_Screen = Checking_screen()
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

    '    Private Async Sub Button_Bot_Click(sender As Object, e As EventArgs) Handles Button_Bot.Click

    'Label_HOME_lancement_du_bot:

    '        ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '        ' █                                                            █
    '        ' █                Detecte la minimap et l'ouvre               █
    '        ' █                                                            █
    '        ' █                         < Balise 2 >                       █
    '        ' █                                                            █
    '        ' █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 
    'Label_Detection_Minimap_et_ouverture:



    '        ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '        ' █                                                            █
    '        ' █                reduit la minimap au minimum                █
    '        ' █                                                            █
    '        ' █                        < Balise 3 >                        █
    '        ' █                                                            █
    '        ' █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 
    'Label_Reduction_minimap:



    '        ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '        ' █                                                            █
    '        ' █           deplace la minimap en bas a droite               █
    '        ' █                                                            █
    '        ' █                        < Balise 4 >                        █
    '        ' █                                                            █
    '        ' █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 
    'Label_Deplacement_miniamp_basdroite:




    '        ' ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    '        ' █                                                            █
    '        ' █               Check dans quel map il se trouve             █
    '        ' █                                                            █
    '        ' █                          < Balise 1 >                      █
    '        ' █                                                            █
    '        ' █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ ▼ 
    'Label_Checking_minimap:


    'Exit_:


    '    End Sub









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