﻿Imports System.Text.RegularExpressions
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

End Class