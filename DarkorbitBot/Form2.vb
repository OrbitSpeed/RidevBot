Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' quand on appuye sur load dans form1 '

        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255")

        WebBrowser1.Navigate("https://darkorbit-22.bpsecure.com/")

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        ' cherche le pseudo et le mot de passe dans la form1 -> dans User&&Pass '
        ' toujours ce referer a User&&Pass '

        If WebBrowser1.Url.ToString.Contains("22.bpsecure.com") Then

            WebBrowser1.Document.GetElementById("bgcdw_login_form_username").SetAttribute("value", Form1.TextBox1.Text)
            WebBrowser1.Document.GetElementById("bgcdw_login_form_password").SetAttribute("value", Form1.TextBox2.Text)
            For Each p As HtmlElement In WebBrowser1.Document.GetElementsByTagName("input")
                If p.GetAttribute("type") = "submit" Then
                    p.InvokeMember("click")


                End If
            Next

        Else
        End If

        If WebBrowser1.Url.ToString.Contains("Start&prc=100") Then

                ' recupere le serveur du joueur '
                TextBox1.Text = WebBrowser1.Url.ToString
                TextBox1.Text = Replace(TextBox1.Text, ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "")
                TextBox1.Text = Replace(TextBox1.Text, "https://", "")
                TextBox1.Text = Replace(TextBox1.Text, " ", "")
                TextBox1.Refresh()

                ' Lance le jeu'
                WebBrowser1.Navigate("https://" + ((TextBox1.Text)) + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")

            End If

    End Sub
End Class