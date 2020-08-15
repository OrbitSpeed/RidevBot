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
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8", vbHide)

    End Sub

    Private Sub WebBrowser_Game_Ridevbot_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_Game_Ridevbot.DocumentCompleted

        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

    End Sub


    Private Sub Form_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub


















    Function Checking_screen()

        Dim Client_primary = New Bitmap(WebBrowser_Game_Ridevbot.ClientSize.Width, WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Client_second.CopyFromScreen(PointToScreen(WebBrowser_Game_Ridevbot.Location), New Point(0, 0), WebBrowser_Game_Ridevbot.ClientSize)
        Return Client_primary
        'Client_primary.Save($"screenshot.jpg", ImageFormat.Jpeg)

    End Function










    Private Async Sub Button_Bot_Click(sender As Object, e As EventArgs) Handles Button_Bot.Click

        ' --------------- 
        ' --- Startup --- 
        ' --------------- 


        ' Checking de l'écran et effectue le screen de demarge + desacive toute les fenetre du jeu avec la touche associé + check et recuperation d'image
        ' balise 1 '


        WebBrowser_Game_Ridevbot.Select()
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 400, 300)
        AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (Form_Tools.TextBox_desactive_allkey.Text))

        Await Task.Delay(2000)

        Dim Minimap_closed_ref = My.Resources.Minimap_closed
        Dim Minimap_size_ref = My.Resources.Minimap_reduce
        Dim Move_minimap_box_ref = My.Resources.Move_box

        Dim systeme_stellaire_ref = My.Resources.systeme_stellaire
        Dim map_detect_ref = My.Resources.map_detect

        ' --------------- 
        ' --- Startup --- 
        ' --------------- 

Startup_Balise1:
        ' checking si minimap fermer et que la touche de depart a bien ete entrer
        Dim Client_Screen As Bitmap = Checking_screen()
        'Graphics.FromImage(Client_primary)
        Try
            Dim Minimap_closed As Point = Client_Screen.Contains(Minimap_closed_ref)
            If Minimap_closed <> Nothing Then

                WebBrowser_Game_Ridevbot.Select()
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Minimap_closed.X, Minimap_closed.Y + 18)

            End If
        Catch Minimap_opened As Exception
            ' faire un systeme qui te ramene a la "balise 0" 
            Console.WriteLine($"Exception minimap_opened: {Minimap_opened.Message}")
            GoTo Startup_Balise1
        End Try

        Await Task.Delay(3000)








        ' -------------------------------------------
        ' reduit la minimap au minimum 
        ' balise 2 
        ' -------------------------------------------

        Client_Screen = Checking_screen()

        Try
            Dim Minimap_size As Point = Client_Screen.Contains(Minimap_size_ref)
            Dim compare As Point

            If Minimap_size <> Nothing Then

                For i = 0 To 20
                    Await Task.Delay(90)
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

            End If
        Catch ex As Exception
            GoTo Startup_Balise1
            ' faire un systeme qui te ramene a la "balise 1" 
        End Try

        Await Task.Delay(3000)











        ' ---------------------------------------------------
        'deplace la minimap en bas a droite 
        ' balise 3
        ' ---------------------------------------------------
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

            End If

        Catch ex As Exception

            '

        End Try

        Try

            Dim Systeme_Stellaire_Point As Point = Client_Screen.Contains(systeme_stellaire_ref)

            If Systeme_Stellaire_Point <> Nothing Then
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "LEFT", 1, Systeme_Stellaire_Point.X, Systeme_Stellaire_Point.Y + 18)
                Await Task.Delay(1200)

                Client_Screen = Checking_screen()
                Dim map_detect_point As Point = Client_Screen.Contains(map_detect_ref)

                If map_detect_point <> Nothing Then
                    Cursor.Position = New Point(map_detect_point.X, map_detect_point.Y)
                Else
                    Console.WriteLine("Not found")
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub































    Private Async Sub GoToPalladium(palla)
        '  found_palla = True
        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, palla(0), palla(1))

        Dim temps = Task.Delay(Form_Tools.TextBox_palladium_ms.Text)
        Await temps
        '  found_palla = False
    End Sub

    Private Sub Button_bonusbox_Click(sender As Object, e As EventArgs) Handles Button_bonusbox.Click

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