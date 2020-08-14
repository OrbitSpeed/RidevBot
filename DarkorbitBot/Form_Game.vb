Imports AutoItX3Lib


Public Class Form_Game
    Dim AutoIt2 As New AutoItX3

    Private Sub Collect_Palladium()

        Dim X_TOP As Integer = (Me.Location.X)
        Dim Y_TOP As Integer = (Me.Location.Y - 18)
        Dim X_BOTTOM As Integer = (Me.Width)
        Dim Y_BOTTOM As Integer = (Me.Height)

        Dim Palladium_ = AutoIt2.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 5073012, 5, 1)
        Try

            AutoIt2.ControlClick("Form3", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Palladium_(0), Palladium_(1))
            System.Threading.Thread.Sleep(Form_Tools.TextBox_palladium_ms.Text)

        Catch Palladium_not_found As Exception

        End Try

    End Sub

    Private Sub Collect_box()

        Dim X_TOP As Integer = (Me.Location.X)
        Dim Y_TOP As Integer = (Me.Location.Y - 18)
        Dim X_BOTTOM As Integer = (Me.Width)
        Dim Y_BOTTOM As Integer = (Me.Height)

        Dim Bonus_Box = AutoIt2.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 1321834, 5, 1)
        Try

            AutoIt2.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Bonus_Box(0) - 0, Bonus_Box(1) - 0)
            System.Threading.Thread.Sleep(Form_Tools.TextBox_cargobox_ms.Text)

        Catch Bonus_Box_not_found As Exception

        End Try

    End Sub

    Private Sub Collect_Cargo_box()

        Dim X_TOP As Integer = (Me.Location.X)
        Dim Y_TOP As Integer = (Me.Location.Y - 18)
        Dim X_BOTTOM As Integer = (Me.Width)
        Dim Y_BOTTOM As Integer = (Me.Height)

        Dim Cargo_Box = AutoIt2.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 16777030, 5, 1)
        Try

            AutoIt2.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Cargo_Box(0) - 0, Cargo_Box(1) - 0)
            System.Threading.Thread.Sleep(Form_Tools.TextBox_bonusbox_ms.Text)

        Catch Cargo_Box_not_found As Exception

        End Try

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim X_TOP As Integer = (Me.Location.X)
        Dim Y_TOP As Integer = (Me.Location.Y - 18)
        Dim X_BOTTOM As Integer = (Me.Width)
        Dim Y_BOTTOM As Integer = (Me.Height)

        Dim Palladium_ = AutoIt2.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 5073012, 5, 1)
        Try

            AutoIt2.ControlClick("Form3", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Palladium_(0), Palladium_(1))

        Catch Palladium_not_found As Exception

        End Try

    End Sub
End Class