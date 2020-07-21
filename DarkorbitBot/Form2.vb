Imports System.Text.RegularExpressions
Imports AutoItX3Lib

Public Class Form2

    Dim server
    Dim AutoIt As New AutoItX3

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' quand on appuye sur load dans form1 '

        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8")

        WebBrowser1.Navigate("https://darkorbit-22.bpsecure.com/")

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        ' cherche le pseudo et le mot de passe dans la form1 -> dans User&&Pass '
        ' toujours ce referer a User&&Pass '
        StartWebBot()

    End Sub

    ' se connecte et lance le jeu avec le clean ' 
    Public Sub StartWebBot()
        If WebBrowser1.Url.ToString.Contains("22.bpsecure.com") Then

            WebBrowser1.Document.GetElementById("bgcdw_login_form_username").SetAttribute("value", Form1.Username_Textbox.Text)
            WebBrowser1.Document.GetElementById("bgcdw_login_form_password").SetAttribute("value", Form1.Password_Textbox.Text)
            For Each p As HtmlElement In WebBrowser1.Document.GetElementsByTagName("input")
                If p.GetAttribute("type") = "submit" Then
                    p.InvokeMember("click")


                End If
            Next

        ElseIf WebBrowser1.Url.ToString.Contains("Start&prc=100") Then

            ' Lance le jeu'
            Dim CheckRegex = Regex.Match(WebBrowser1.Url.ToString, "^http[s]?:[\/][\/]([^.]+)[.]darkorbit[.]com") '.exec(window.location.href);
            server = CheckRegex.Groups.Item(1).ToString
            WebBrowser1.Navigate("https://" + ((server)) + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
        End If

    End Sub

    ' button reload '
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click

        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8")
        WebBrowser1.Refresh()

        'StartWebBot()
    End Sub

    Private Sub Button_SID_Click(sender As Object, e As EventArgs) Handles Button_SID.Click

        ' ouverture de la maisonnette '

        BackPage_Form.WebBrowser1.Navigate("https://" + ((server)) + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        BackPage_Form.Show()

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

            Dim SIMPLE = AutoIt.PixelSearch(A1, A2, A3, A4, 13369344, 0, 1)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0), SIMPLE(1))

            Console.WriteLine(SIMPLE(0))
            Console.WriteLine(SIMPLE(1))

        Catch ex As Exception

        End Try

    End Sub
End Class