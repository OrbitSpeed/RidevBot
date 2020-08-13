Imports System.Text.RegularExpressions
Imports AutoItX3Lib


Public Class Form_Game
    Dim AutoIt As New AutoItX3

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Clickbutton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)


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

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click

        CloseForm.ShowDialog(Me)
        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8", vbHide)

    End Sub

    Private Sub WebBrowser_Game_Ridevbot_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_Game_Ridevbot.DocumentCompleted

        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"

    End Sub
End Class