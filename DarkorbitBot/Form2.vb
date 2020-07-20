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

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Dim result = MessageBox.Show("Voulez-vous vraiment fermer le bot ?", "RidevBot", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        Else
            Close()

        End If
    End Sub

    Public Sub StartWebBot()
        If WebBrowser1.Url.ToString.Contains("22.bpsecure.com") Then

            WebBrowser1.Document.GetElementById("bgcdw_login_form_username").SetAttribute("value", Form1.TextBox1.Text)
            WebBrowser1.Document.GetElementById("bgcdw_login_form_password").SetAttribute("value", Form1.TextBox2.Text)
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

    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8")
        WebBrowser1.Refresh()
        'StartWebBot()
    End Sub

    Private Sub Button_SID_Click(sender As Object, e As EventArgs) Handles Button_SID.Click
        If server IsNot vbNullString Then
            BackPage_Form.WebBrowser1.Navigate("https://" + server + ".darkorbit.com/indexInternal.es?action=internalAuction")
            BackPage_Form.Show()

        End If

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim A1 As Integer = (WebBrowser1.Location.X)
        Dim A2 As Integer = (WebBrowser1.Location.Y)
        Dim A22 As Integer = (A2 + 170)
        Dim A3 As Integer = (WebBrowser1.Width)
        Dim A31 As Integer = (A1 + 800)
        Dim A4 As Integer = (WebBrowser1.Height)
        Dim A41 As Integer = (A22 + 270)

        Try

            Dim SIMPLE = AutoIt.PixelSearch(A1, A22, A3, A4, 1321834, 5, 1)
            FlatLabel1.Location = New Point(SIMPLE(0) + 7, SIMPLE(1) - 7)

            AutoIt.ControlClick(Text, "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, SIMPLE(0) + 7, SIMPLE(1) - 7)
            'Wagonnet578 = 0

        Catch Erreur As Exception
            Console.Beep()
        End Try

    End Sub
End Class