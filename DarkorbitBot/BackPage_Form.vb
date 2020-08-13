Public Class BackPage_Form

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    Private Sub Panel_Bar_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Bar.MouseMove

        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp
            tmp = Nothing
        End If

    End Sub

    Private Sub Panel_Bar_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Bar.MouseDown

        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Panel_Bar_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_Bar.MouseUp

        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If

    End Sub

    Private Sub Panel_Bar_DoubleClick(sender As Object, e As PaintEventArgs) Handles Panel_Bar.DoubleClick
        'TODO Quand on aura le temps de fix
        'If Me.WindowState = FormWindowState.Maximized Then
        '    Me.WindowState = FormWindowState.Normal
        'Else
        '    Me.WindowState = FormWindowState.Maximized
        'End If
    End Sub

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        If Form_Tools.Reader = 1 Then
            If WebBrowser1.Url.ToString.Contains("Start&prc=100") And Utils.checkStats Then

                Utils.currentHonnor = "" & (WebBrowser1.Document.GetElementById("header_top_hnr")).InnerText

                Utils.currentUridium = "" & (WebBrowser1.Document.GetElementById("header_uri")).InnerText

                Utils.currentCredits = "" & (WebBrowser1.Document.GetElementById("header_credits")).InnerText

                Utils.currentXP = "" & (WebBrowser1.Document.GetElementById("header_top_exp")).InnerText

                Utils.currentLevel = "" & (WebBrowser1.Document.GetElementById("header_top_level")).InnerText

                WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalHallofFame&view=dailyRank")

            ElseIf WebBrowser1.Url.ToString.Contains("internalHallofFame&view=dailyRank") And Utils.checkStats Then

                Utils.currentRankPoints = "" & (WebBrowser1.Document.GetElementById("hof_daily_points_points")).InnerText

                Utils.UpdateStats()

                If Form_Tools.Calculator = 1 Then

                    Form_Tools.UridiumCalculator = (Utils.currentUridium)
                    Form_Tools.CreditCalculator = (Utils.currentCredits)
                    Form_Tools.HonorCalculator = (Utils.currentHonnor)
                    Form_Tools.ExpCalculator = (Utils.currentXP)
                    Form_Tools.RPCalculator = (Utils.currentRankPoints)

                    Form_Tools.UridiumCalculator = Replace(Form_Tools.UridiumCalculator, ".", "")
                    Form_Tools.CreditCalculator = Replace(Form_Tools.CreditCalculator, ".", "")
                    Form_Tools.HonorCalculator = Replace(Form_Tools.HonorCalculator, ".", "")
                    Form_Tools.ExpCalculator = Replace(Form_Tools.ExpCalculator, ".", "")
                    Form_Tools.RPCalculator = Replace(Form_Tools.RPCalculator, ".", "")
                    Form_Tools.Calculator = 2

                ElseIf Form_Tools.Calculator = 2 Then

                    Form_Tools.UridiumCalculator2 = (Utils.currentUridium)
                    Form_Tools.CreditCalculator2 = (Utils.currentCredits)
                    Form_Tools.HonorCalculator2 = (Utils.currentHonnor)
                    Form_Tools.ExpCalculator2 = (Utils.currentXP)
                    Form_Tools.RPCalculator2 = (Utils.currentRankPoints)

                    Form_Tools.UridiumCalculator2 = Replace(Form_Tools.UridiumCalculator2, ".", "")
                    Form_Tools.CreditCalculator2 = Replace(Form_Tools.CreditCalculator2, ".", "")
                    Form_Tools.HonorCalculator2 = Replace(Form_Tools.HonorCalculator2, ".", "")
                    Form_Tools.ExpCalculator2 = Replace(Form_Tools.ExpCalculator2, ".", "")
                    Form_Tools.RPCalculator2 = Replace(Form_Tools.RPCalculator2, ".", "")

                    Form_Tools.UridiumCalculator3 = (Form_Tools.UridiumCalculator2) - (Form_Tools.UridiumCalculator)
                    Form_Tools.CreditCalculator3 = (Form_Tools.CreditCalculator2) - (Form_Tools.CreditCalculator)
                    Form_Tools.HonorCalculator3 = (Form_Tools.HonorCalculator2) - (Form_Tools.HonorCalculator)
                    Form_Tools.ExpCalculator3 = (Form_Tools.ExpCalculator2) - (Form_Tools.ExpCalculator)
                    Form_Tools.RPCalculator3 = (Form_Tools.RPCalculator2) - (Form_Tools.RPCalculator)

                    Form_Tools.TextBox_uridiumEarned.Text = Utils.NumberToHumanReadable(Form_Tools.UridiumCalculator3, ".")
                    Form_Tools.TextBox_creditEarned.Text = Utils.NumberToHumanReadable(Form_Tools.CreditCalculator3, ".")
                    Form_Tools.TextBox_honorEarned.Text = Utils.NumberToHumanReadable(Form_Tools.HonorCalculator3, ".")
                    Form_Tools.TextBox_experienceEarned.Text = Utils.NumberToHumanReadable(Form_Tools.ExpCalculator3, ".")
                    Form_Tools.TextBox_RPEarned.Text = Utils.NumberToHumanReadable(Form_Tools.RPCalculator3, ".")

                End If

                Utils.checkStats = False
                Form_Tools.Reader = 0
                Me.Close()


            End If
        End If

    End Sub

End Class