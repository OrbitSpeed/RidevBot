Imports System.Text.RegularExpressions
Imports AutoItX3Lib


Public Class Form_Game
    Dim AutoIt As New AutoItX3

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Clickbutton_Click(sender As Object, e As EventArgs) Handles Clickbutton.Click

        'Try

        '    Dim A1 As Integer = (WebBrowser_Game_Ridevbot.Location.X)
        '    Dim A2 As Integer = (WebBrowser_Game_Ridevbot.Location.Y - 18)
        '    Dim A3 As Integer = (WebBrowser_Game_Ridevbot.Width)
        '    Dim A4 As Integer = (WebBrowser_Game_Ridevbot.Height)

        '    Console.WriteLine(A1)
        '    Console.WriteLine(A2)
        '    Console.WriteLine(A3)
        '    Console.WriteLine(A4)

        '    Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 1321834, 5, 1)


        '    Console.WriteLine(SIMPLE)

        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)

        '    Console.WriteLine(SIMPLE(0))
        '    Console.WriteLine(SIMPLE(1))

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        'Try

        '    Dim A1 As Integer = (WebBrowser_Game_Ridevbot.Location.X)
        '    Dim A2 As Integer = (WebBrowser_Game_Ridevbot.Location.Y - 18)
        '    Dim A3 As Integer = (WebBrowser_Game_Ridevbot.Width)
        '    Dim A4 As Integer = (WebBrowser_Game_Ridevbot.Height)

        '    Console.WriteLine(A1)
        '    Console.WriteLine(A2)
        '    Console.WriteLine(A3)
        '    Console.WriteLine(A4)

        '    Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 16777030, 5, 1)


        '    Console.WriteLine(SIMPLE)

        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)
        '    'AutoIt.

        '    Console.WriteLine(SIMPLE(0))
        '    Console.WriteLine(SIMPLE(1))

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
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

        'End Try

    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click

        'Try
        '    Dim A1 As Integer = (WebBrowser1.Location.X)
        '    Dim A2 As Integer = (WebBrowser1.Location.Y - 18)
        '    Dim A3 As Integer = (WebBrowser1.Width)
        '    Dim A4 As Integer = (WebBrowser1.Height)

        '    Dim result = AutoIt.PixelSearch(A1, A2, A3, A4, 6959164, 0, 1)

        '    Console.WriteLine(result)
        '    If result = 0 Then

        '    Else

        '        AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (1))

        '    End If

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click

        CloseForm.ShowDialog(Me)
        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8", vbHide)

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click

        'Dim A1 As Integer = (WebBrowser_Game_Ridevbot.Location.X)
        'Dim A2 As Integer = (WebBrowser_Game_Ridevbot.Location.Y - 18)
        'Dim A3 As Integer = (WebBrowser_Game_Ridevbot.Width)
        'Dim A4 As Integer = (WebBrowser_Game_Ridevbot.Height)

        'Dim A6 As Integer = 597 'x
        'Dim A61 As Integer = 486 'y
        'Dim A62 As Integer = 773 'xx
        'Dim A63 As Integer = 588 'yy

        'Try

        '    Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 1321834, 5, 1)
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)

        'Catch aser2 As Exception

        '    Try

        '        Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 1321834, 5, 1)
        '        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)

        '    Catch aser77 As Exception
        '        Try

        '            Dim SIMPLE2 = AutoIt.PixelSearch(A1, A2, A3, A4, 16777030, 10, 1)
        '            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE2(0) - 0, SIMPLE2(1) - 0)

        '        Catch aser3 As Exception
        '            Try

        '                Dim result = AutoIt.PixelSearch(A1, A2, A3, A4, 13369344, 0, 1)


        '                Console.WriteLine(result)

        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, result(0) + 40, result(1) - 40)
        '                AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (1))

        '            Catch aser4 As Exception

        '                Dim random As New Random(), rndnbr As Integer
        '                rndnbr = random.Next(A6, A62)
        '                Dim random2 As New Random(), rndnbr2 As Integer
        '                rndnbr2 = random2.Next(A61, A63)

        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, rndnbr, rndnbr2)

        '            End Try
        '        End Try
        '    End Try
        'End Try

    End Sub

    Private Sub WebBrowser_Game_Ridevbot_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_Game_Ridevbot.DocumentCompleted


        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
    End Sub
End Class