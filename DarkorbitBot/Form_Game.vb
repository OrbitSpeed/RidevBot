Imports System.Text.RegularExpressions
Imports AutoItX3Lib

Public Class Form_Game
    Dim AutoIt As New AutoItX3
    'Public server As String
    'Public dosid As String

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' quand on appuye sur load dans form1
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8")

        If Utils.connectWithCookie Then
            Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution", "dosid", Utils.dosid & ";")
            WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
            Form_Tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
            Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
            Me.Show()
        Else
            WebBrowser1.Navigate("https://darkorbit-22.bpsecure.com/")
            Me.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        ' cherche le pseudo et le mot de passe dans la form1 -> dans User&&Pass
        ' toujours se referer a User&&Pass
        StartWebBot()
    End Sub

    ' se connecte et lance le jeu avec le clean
    Public Sub StartWebBot()
        If WebBrowser1.Url.ToString Is vbNullString Then
            WebBrowser1.Navigate("https://darkorbit-22.bpsecure.com/")
            Me.Show()
            Me.Hide()

        End If

        If WebBrowser1.Url.ToString.Contains("22.bpsecure.com") And Not WebBrowser1.Url.ToString.Contains("authUser=291") Then

            WebBrowser1.Document.GetElementById("bgcdw_login_form_username").SetAttribute("value", Form_Startup.Textbox_Username.Text)
            WebBrowser1.Document.GetElementById("bgcdw_login_form_password").SetAttribute("value", Form_Startup.Textbox_Password.Text)
            For Each p As HtmlElement In WebBrowser1.Document.GetElementsByTagName("input")
                If p.GetAttribute("type") = "submit" Then
                    p.InvokeMember("click")
                End If
            Next
            Me.Show()
            Me.Hide()

        ElseIf WebBrowser1.Url.ToString.Contains("Start&prc=100") Then

            ' Lance le jeu'
            Dim CheckRegex = Regex.Match(WebBrowser1.Url.ToString, "^http[s]?:[\/][\/]([^.]+)[.]darkorbit[.]com") '.exec(window.location.href);
            Utils.server = CheckRegex.Groups.Item(1).ToString

            Dim testalacon = Regex.Match(WebBrowser1.DocumentText, "dosid=([^&^.']+)")
            If testalacon.Success Then
                Console.WriteLine(testalacon.Value.Split("=")(1))
                Utils.dosid = testalacon.Value.Split("=")(1)

                Utils.userid = Replace(WebBrowser1.Document.GetElementById("header_top_id").InnerText, " ", "")

                Form_Tools.TextBox_Get_id.Text = Replace(WebBrowser1.Document.GetElementById("header_top_id").InnerText, " ", "")

                Form_Tools.TextBox_Get_Dosid.Text = Replace(Utils.dosid, " ", "")

                Form_Tools.TextBox_Get_Server.Text = Replace(Utils.server, " ", "")

                Utils.currentHonnor = "" & (WebBrowser1.Document.GetElementById("header_top_hnr")).InnerText

                Utils.currentUridium = "" & (WebBrowser1.Document.GetElementById("header_uri")).InnerText

                Utils.currentCredits = "" & (WebBrowser1.Document.GetElementById("header_credits")).InnerText

                Utils.currentXP = "" & (WebBrowser1.Document.GetElementById("header_top_exp")).InnerText

                Utils.currentLevel = "" & (WebBrowser1.Document.GetElementById("header_top_level")).InnerText

                TextBox_getserver.Text = Utils.server

                Form_Tools.Button_ABG_GGS.Enabled = True
                Form_Tools.Button_Delta_GGS.Enabled = True
                Form_Tools.Button_Epsilon_GGS.Enabled = True
                Form_Tools.Button_Zeta_GGS.Enabled = True
                Form_Tools.Button_Kappa_GGS.Enabled = True
                Form_Tools.Button_Lambda_GGS.Enabled = True
                Form_Tools.Button_Hades_GGS.Enabled = True
                Form_Tools.Button_Kuiper_GGS.Enabled = True

                'MsgBox(dosid)
            End If

            'Launch the Start
            Form_Tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
            Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
            WebBrowser1.Navigate("https://" + (Utils.server) + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
            My.Computer.Audio.Play(My.Resources.connected, AudioPlayMode.Background)
            Me.Show()

        ElseIf WebBrowser1.Url.ToString.Contains("authUser=291") Then
            Dim result = MessageBox.Show("Le compte est incorrect, veuillez vérifier les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If result = DialogResult.OK Then
                Form_Startup.Show()
                BackPage_Form.Close()
                Form_Tools.Close()
                Close()
            End If
        Else
            Me.Show()
        End If
        'MsgBox(WebBrowser1.Url.ToString)
    End Sub

    Private Sub Clickbutton_Click(sender As Object, e As EventArgs) Handles Clickbutton.Click

        Try

            Dim A1 As Integer = (WebBrowser1.Location.X)
            Dim A2 As Integer = (WebBrowser1.Location.Y - 18)
            Dim A3 As Integer = (WebBrowser1.Width)
            Dim A4 As Integer = (WebBrowser1.Height)

            Console.WriteLine(A1)
            Console.WriteLine(A2)
            Console.WriteLine(A3)
            Console.WriteLine(A4)

            Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 1321834, 5, 1)


            Console.WriteLine(SIMPLE)

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)

            Console.WriteLine(SIMPLE(0))
            Console.WriteLine(SIMPLE(1))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try

            Dim A1 As Integer = (WebBrowser1.Location.X)
            Dim A2 As Integer = (WebBrowser1.Location.Y - 18)
            Dim A3 As Integer = (WebBrowser1.Width)
            Dim A4 As Integer = (WebBrowser1.Height)

            Console.WriteLine(A1)
            Console.WriteLine(A2)
            Console.WriteLine(A3)
            Console.WriteLine(A4)

            Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 16777030, 5, 1)


            Console.WriteLine(SIMPLE)

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)
            'AutoIt.

            Console.WriteLine(SIMPLE(0))
            Console.WriteLine(SIMPLE(1))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Try
            Dim A1 As Integer = (WebBrowser1.Location.X)
            Dim A2 As Integer = (WebBrowser1.Location.Y - 18)
            Dim A3 As Integer = (WebBrowser1.Width)
            Dim A4 As Integer = (WebBrowser1.Height)

            Dim result = AutoIt.PixelSearch(A1, A2, A3, A4, 13369344, 0, 1)


            Console.WriteLine(result)

            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, result(0) + 40, result(1) - 40)
            AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (1))
        Catch ex As Exception

        End Try

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

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click

        Dim A1 As Integer = (WebBrowser1.Location.X)
        Dim A2 As Integer = (WebBrowser1.Location.Y - 18)
        Dim A3 As Integer = (WebBrowser1.Width)
        Dim A4 As Integer = (WebBrowser1.Height)

        Dim A6 As Integer = 597 'x
        Dim A61 As Integer = 486 'y
        Dim A62 As Integer = 773 'xx
        Dim A63 As Integer = 588 'yy

        Try

            Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 1321834, 5, 1)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)

        Catch aser2 As Exception

            Try

                Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 1321834, 5, 1)
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) - 0, SIMPLE(1) - 0)

            Catch aser77 As Exception
                Try

                    Dim SIMPLE2 = AutoIt.PixelSearch(A1, A2, A3, A4, 16777030, 10, 1)
                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE2(0) - 0, SIMPLE2(1) - 0)

                Catch aser3 As Exception
                    Try

                        Dim result = AutoIt.PixelSearch(A1, A2, A3, A4, 13369344, 0, 1)


                        Console.WriteLine(result)

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, result(0) + 40, result(1) - 40)
                        AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (1))

                    Catch aser4 As Exception

                        Dim random As New Random(), rndnbr As Integer
                        rndnbr = random.Next(A6, A62)
                        Dim random2 As New Random(), rndnbr2 As Integer
                        rndnbr2 = random2.Next(A61, A63)

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, rndnbr, rndnbr2)

                    End Try
                End Try
            End Try
        End Try



    End Sub


    Private Sub Form_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form_Tools.Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        Form_Tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
    End Sub

End Class