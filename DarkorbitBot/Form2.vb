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
        AutoIt.ControlClick(Text, "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 100, 100)

        'AutoIt.ControlClick("Form2", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, FlatTextBox1.Text, FlatTextBox2.Text)
        'Wagonnet578 = 0
    End Sub
End Class