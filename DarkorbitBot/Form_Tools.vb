Imports System.Net
Imports System.Text.RegularExpressions
Imports AutoItX3Lib

Public Class Form_Tools

    Dim AutoIt As New AutoItX3
    Public X_TOP As Integer = (Form_Game.WebBrowser_Game_Ridevbot.Location.X)
    Public Y_TOP As Integer = (Form_Game.WebBrowser_Game_Ridevbot.Location.Y - 18)
    Public X_BOTTOM As Integer = (Form_Game.WebBrowser_Game_Ridevbot.Width)
    Public Y_BOTTOM As Integer = (Form_Game.WebBrowser_Game_Ridevbot.Height)

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer
    Public Calculator As String

    Public UridiumCalculator As String
    Public CreditCalculator As String
    Public HonorCalculator As String
    Public ExpCalculator As String
    Public RPCalculator As String
    Public UridiumCalculator2 As String
    Public CreditCalculator2 As String
    Public HonorCalculator2 As String
    Public ExpCalculator2 As String
    Public RPCalculator2 As String
    Public UridiumCalculator3 As String
    Public CreditCalculator3 As String
    Public HonorCalculator3 As String
    Public ExpCalculator3 As String
    Public RPCalculator3 As String
    Public ABG As Boolean = False

    Public BackgroundWorkerAutospin As Boolean = False

    Public CheckedDeltaStats As String = 0
    Public CheckedEpsilonStats As String = 0
    Public CheckedZetaStats As String = 0
    Public CheckedkappaStats As String = 0
    Public CheckedLambdaStats As String = 0
    Public CheckedkuiperStats As String = 0
    Public CheckedHadesStats As String = 0
    Public CheckedAlphaBetaGammaStats As String = 0
    Public CheckedAlphaBetaGammaStats2 As String = 0
    Public CheckedAlphaBetaGammaStats3 As String = 0

    Public Reader As String = 0


#Region "Panel_Title (Move)"
    Private Sub Panel_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove

        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp

            tmp = Nothing
        End If

    End Sub

    Private Sub Panel_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseDown

        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Panel_Title_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseUp

        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If

    End Sub
#End Region

    Private Sub Form_Tools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Calculator = 1

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        ' -----------------------------------------------

        Panel_general.Location = New Point(86, 18)
        Panel_Npc.Location = New Point(86, 18)
        Panel_collector.Location = New Point(86, 18)
        Panel_GalaxyGates.Location = New Point(86, 18)
        Panel_Palladium.Location = New Point(86, 18)
        Panel_stats.Location = New Point(86, 18)
        Panel_rex.Location = New Point(86, 18)
        Panel_divers.Location = New Point(86, 18)

        TextBox_ProfilSelected.Text = Form_Startup.Textbox_Username.Text

        Size = New Size(390, 333)
        CenterToScreen()

        If Form_Game.Visible = True Then
            Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Else
            Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        End If

        'TODO
        'Pour les thèmes (prend uniquement dans le controle et pas dans un panel) (donc à faire)
        'For Each b As Button In Me.Controls.OfType(Of Button)()
        '    b.BackColor = Color.Red
        'Next
    End Sub

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
        'CloseForm1.Show()
    End Sub

#Region "Button"
    Private Sub General_button_Click(sender As Object, e As EventArgs) Handles General_button.Click

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False
        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        General_button.Enabled = False
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label_buttonGeneral.Visible = True
        Label_ButtonNPCBOX.Visible = False
        Label_ButtonINUTILE.Visible = False
        Label_galaxygates.Visible = False
        Label_buttonPALLADIUM.Visible = False
        Label_buttonStats.Visible = False
        Label_buttonREX.Visible = False
        Label_ButtonDivers.Visible = False

        Panel_general.Visible = True
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(390, 333)
        CenterToScreen()

    End Sub

    Private Sub NPC_Button_Click(sender As Object, e As EventArgs) Handles NPC_Button.Click

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False
        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        General_button.Enabled = True
        NPC_Button.Enabled = False
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label_buttonGeneral.Visible = False
        Label_ButtonNPCBOX.Visible = True
        Label_ButtonINUTILE.Visible = False
        Label_galaxygates.Visible = False
        Label_buttonPALLADIUM.Visible = False
        Label_buttonStats.Visible = False
        Label_buttonREX.Visible = False
        Label_ButtonDivers.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = True
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(390, 333)
        CenterToScreen()

    End Sub

    Private Sub Collector_Button_Click(sender As Object, e As EventArgs) Handles LogUpdate_button.Click

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False
        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = False
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label_buttonGeneral.Visible = False
        Label_ButtonNPCBOX.Visible = False
        Label_ButtonINUTILE.Visible = True
        Label_galaxygates.Visible = False
        Label_buttonPALLADIUM.Visible = False
        Label_buttonStats.Visible = False
        Label_buttonREX.Visible = False
        Label_ButtonDivers.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = True
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False


        Size = New Size(390, 333)
        CenterToScreen()

    End Sub

    Private Sub GalaxyGates_Button_Click(sender As Object, e As EventArgs) Handles GalaxyGates_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label_buttonGeneral.Visible = False
        Label_ButtonNPCBOX.Visible = False
        Label_ButtonINUTILE.Visible = False
        Label_buttonPALLADIUM.Visible = False
        Label_buttonStats.Visible = False
        Label_buttonREX.Visible = False
        Label_ButtonDivers.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        If Utils.server = "" Then
            Dim result = MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                General_button.Enabled = False
                Label_buttonGeneral.Visible = True
                Panel_general.Visible = True
                Size = New Size(390, 333)
            Else
                General_button.Enabled = False
                Label_buttonGeneral.Visible = True
                Panel_general.Visible = True
                Size = New Size(390, 333)
            End If
        Else

            Label_galaxygates.Visible = True
            GalaxyGates_Button.Enabled = False
            Panel_GalaxyGates.Visible = True
            Size = New Size(553, 622)
            TextBox_uridiumGGS.Text = Utils.currentUridium

            WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

            ' https://fr1.darkorbit.com/flashinput/galaxyGates.php?userID=168449162&action=init&sid=b1b8a3c2e29ac06147fea27af6fac2bb

            TextBox_WinGGS.Visible = True

        End If

        '
        CenterToScreen()

    End Sub

    Private Sub Pirates_Button_Click(sender As Object, e As EventArgs) Handles Pirates_Button.Click

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False
        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = False
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label_buttonGeneral.Visible = False
        Label_ButtonNPCBOX.Visible = False
        Label_ButtonINUTILE.Visible = False
        Label_galaxygates.Visible = False
        Label_buttonPALLADIUM.Visible = True
        Label_buttonStats.Visible = False
        Label_buttonREX.Visible = False
        Label_ButtonDivers.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = True
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(390, 333)
        CenterToScreen()

    End Sub

    Private Sub Stats_Button_Click(sender As Object, e As EventArgs) Handles Stats_Button.Click

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False
        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label_buttonGeneral.Visible = False
        Label_ButtonNPCBOX.Visible = False
        Label_ButtonINUTILE.Visible = False
        Label_galaxygates.Visible = False
        Label_buttonPALLADIUM.Visible = False
        Label_buttonREX.Visible = False
        Label_ButtonDivers.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False


        If Utils.server = "" Then

            Dim result = MessageBox.Show("You must first login To the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                General_button.Enabled = False
                Label_buttonGeneral.Visible = True
                Panel_general.Visible = True
                Size = New Size(390, 333)
            Else
                General_button.Enabled = False
                Label_buttonGeneral.Visible = True
                Panel_general.Visible = True
                Size = New Size(390, 333)
            End If


            General_button.Enabled = False
            Label_buttonGeneral.Visible = True
            Panel_general.Visible = True
            Size = New Size(390, 333)

        Else

            Label_buttonStats.Visible = True
            Stats_Button.Enabled = False
            Panel_stats.Visible = True
            Size = New Size(390, 356)

            Utils.checkStats = True
            BackPage_Form.Show()
            Reader = 1
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
            BackPage_Form.WindowState = FormWindowState.Minimized

            BackPage_Form.ShowIcon = False
            BackPage_Form.ShowInTaskbar = False

        End If

        CenterToScreen()

    End Sub

    Private Sub Rex_Button_Click(sender As Object, e As EventArgs) Handles Rex_Button.Click

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False
        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = False
        Divers_Button.Enabled = True

        Label_buttonGeneral.Visible = False
        Label_ButtonNPCBOX.Visible = False
        Label_ButtonINUTILE.Visible = False
        Label_galaxygates.Visible = False
        Label_buttonPALLADIUM.Visible = False
        Label_buttonStats.Visible = False
        Label_buttonREX.Visible = True
        Label_ButtonDivers.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = True
        Panel_divers.Visible = False

        Size = New Size(390, 333)
        CenterToScreen()

    End Sub

    Private Sub Divers_Button_Click(sender As Object, e As EventArgs) Handles Divers_Button.Click

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False
        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = False

        Label_buttonGeneral.Visible = False
        Label_ButtonNPCBOX.Visible = False
        Label_ButtonINUTILE.Visible = False
        Label_galaxygates.Visible = False
        Label_buttonPALLADIUM.Visible = False
        Label_buttonStats.Visible = False
        Label_buttonREX.Visible = False
        Label_ButtonDivers.Visible = True

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = True

        Size = New Size(390, 333)
        CenterToScreen()

    End Sub

    Private Sub Button_LaunchGameRidevBrowser_Click(sender As Object, e As EventArgs) Handles Button_LaunchGameRidevBrowser.Click

        If Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser" Then
            Button_LaunchGameRidevBrowser.Cursor = Cursors.WaitCursor
            Button_LaunchGameRidevBrowser.Text = "Connecting..."

            Form_Game.Show()
            Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")


        ElseIf Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser" Then

            Button_LaunchGameRidevBrowser.Cursor = Cursors.WaitCursor
            Button_LaunchGameRidevBrowser.Text = "Connecting..."

            Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8", vbHide)

            Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")
            Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")

        Else Button_LaunchGameRidevBrowser.Text = "Already connecting..."
        End If



    End Sub
#End Region

#Region "Galaxy Gates"
    ' full = toute la gg 
    ' last = derniere piece

#Region "GG Click Portail"

    Dim PartAlpha As String
    Dim PartBeta As String
    Dim PartGamma As String
    Public AlphaBetaGammaReupload As String = 0
    Public AlphaBetaGammaReupload2 As String = 0
    Public AlphaBetaGammaReupload3 As String = 0
    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click

        ABG = True
        ComboBox_autospin.Text = "ABG"

        If CheckedAlphaBetaGammaStats = 0 Then

            Button_Alpha.PerformClick()
            Button_beta.PerformClick()
            Button_gamma.PerformClick()

        End If

        Button_Alpha.Enabled = False
        Button_beta.Enabled = False
        Button_gamma.Enabled = False

        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0

        Button_ABG_GGS.Enabled = False

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=1&alpha=1&sample=1&multiplier=1")

        Panel_infoPartGG2.Visible = True
        Panel_infoPartGG3.Visible = True
        Panel_infoPartGG_GG2.Visible = True
        Panel_infoPartGG_GG3.Visible = True
        WebBrowser_galaxyGates2.Visible = True
        WebBrowser_galaxyGates3.Visible = True

        Panel_GalaxyGates.Size = New Size(995, 514)
        Me.Size = New Size(1079, 532)
        TextBox_WinGGS.Size = New Size(521, 162)
        TextBox_WinGGS.Location = New Point(461, 340)

    End Sub

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click


        Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "alpha")

        ComboBox_autospin.Text = "ABG"

        Button_Alpha.Enabled = False
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedAlphaBetaGammaStats = 1 Then

            Panel_infoPartGG2.Visible = False
            Panel_infoPartGG3.Visible = False
            Panel_infoPartGG_GG2.Visible = False
            Panel_infoPartGG_GG3.Visible = False
            WebBrowser_galaxyGates2.Visible = False
            WebBrowser_galaxyGates3.Visible = False

            Panel_GalaxyGates.Size = New Size(467, 606)
            TextBox_WinGGS.Size = New Size(439, 86)
            TextBox_WinGGS.Location = New Point(15, 508)
            Size = New Size(553, 622)

            If DataAlpha = Nothing Then
            Else

                If DataAlpha.Contains("prepared1") Then
                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataAlpha.Contains("prepared0") Then
                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeftAlpha = Regex.Match(DataAlpha, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeftAlpha.Length = 0 Then

                    If regex_livesLeftAlpha > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeftAlpha = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"

                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeftAlpha

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataAlpha)
                Dim regex_totalWave = Utils.getTotalWave(DataAlpha)
                Dim regex_currentPart = Utils.getCurrentPart(DataAlpha)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then

                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave
                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then

                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 34"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 34"
                End If

            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")

        Else

            If DataAlpha = Nothing Then
            Else

                If DataAlpha.Contains("prepared1") Then
                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataAlpha.Contains("prepared0") Then
                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeftAlpha = Regex.Match(DataAlpha, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeftAlpha.Length = 0 Then

                    If regex_livesLeftAlpha > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeftAlpha = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"

                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeftAlpha

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataAlpha)
                Dim regex_totalWave = Utils.getTotalWave(DataAlpha)
                Dim regex_currentPart = Utils.getCurrentPart(DataAlpha)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then

                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave
                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then

                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 34"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 34"
                End If

            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")
            CheckedAlphaBetaGammaStats = 1


        End If

    End Sub

    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click

        Dim DataBeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "beta") ' Info GG Beta

        ComboBox_autospin.Text = "ABG"
        '
        Button_Alpha.Enabled = True
        Button_beta.Enabled = False
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedAlphaBetaGammaStats2 = 1 Then

            Panel_infoPartGG2.Visible = False
            Panel_infoPartGG3.Visible = False
            Panel_infoPartGG_GG2.Visible = False
            Panel_infoPartGG_GG3.Visible = False
            WebBrowser_galaxyGates2.Visible = False
            WebBrowser_galaxyGates3.Visible = False

            Panel_GalaxyGates.Size = New Size(467, 606)
            TextBox_WinGGS.Size = New Size(439, 86)
            TextBox_WinGGS.Location = New Point(15, 508)
            Size = New Size(553, 622)

            If DataBeta = Nothing Then
            Else

                If DataBeta.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataBeta.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataBeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataBeta)
                Dim regex_totalWave = Utils.getTotalWave(DataBeta)
                Dim regex_currentPart = Utils.getCurrentPart(DataBeta)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "Unknown"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 48"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 48"
                End If

            End If


            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")

        Else

            If DataBeta = Nothing Then
            Else

                If DataBeta.Contains("prepared1") Then

                    Label_infoPartGG_InMap2.Text = "On map : 1"

                ElseIf DataBeta.Contains("prepared0") Then

                    Label_infoPartGG_InMap2.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataBeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft2.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft2.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft2.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataBeta)
                Dim regex_totalWave = Utils.getTotalWave(DataBeta)
                Dim regex_currentPart = Utils.getCurrentPart(DataBeta)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave2.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave2.Text = "Wave : " + "?" + " / " + "Unknown"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG2.Text = "Part : " + regex_currentPart + " / 48"
                Else
                    Label_InfoPartGG2.Text = "Part : " + "?" + " / 48"
                End If

            End If

            WebBrowser_galaxyGates2.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")
            CheckedAlphaBetaGammaStats2 = 1

        End If

    End Sub

    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click

        Dim DataGamma = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "gamma") ' Info GG gamma

        ComboBox_autospin.Text = "ABG"

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = False
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedAlphaBetaGammaStats3 = 1 Then

            Panel_infoPartGG2.Visible = False
            Panel_infoPartGG3.Visible = False
            Panel_infoPartGG_GG2.Visible = False
            Panel_infoPartGG_GG3.Visible = False
            WebBrowser_galaxyGates2.Visible = False
            WebBrowser_galaxyGates3.Visible = False

            Panel_GalaxyGates.Size = New Size(467, 606)
            TextBox_WinGGS.Size = New Size(439, 86)
            TextBox_WinGGS.Location = New Point(15, 508)
            Size = New Size(553, 622)

            If DataGamma = Nothing Then
            Else

                If DataGamma.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataGamma.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataGamma, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataGamma)
                Dim regex_totalWave = Utils.getTotalWave(DataGamma)
                Dim regex_currentPart = Utils.getCurrentPart(DataGamma)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 82"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 82"
                End If

            End If


            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")

        Else

            If DataGamma = Nothing Then
            Else

                If DataGamma.Contains("prepared1") Then

                    Label_infoPartGG_InMap3.Text = "On map : 1"

                ElseIf DataGamma.Contains("prepared0") Then

                    Label_infoPartGG_InMap3.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataGamma, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft3.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft3.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft3.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataGamma)
                Dim regex_totalWave = Utils.getTotalWave(DataGamma)
                Dim regex_currentPart = Utils.getCurrentPart(DataGamma)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave3.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave3.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG3.Text = "Part : " + regex_currentPart + " / 82"
                Else
                    Label_InfoPartGG3.Text = "Part : " + "?" + " / 82"
                End If

                AlphaBetaGammaReupload = 0

            End If


            WebBrowser_galaxyGates3.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")
            CheckedAlphaBetaGammaStats3 = 1

        End If

    End Sub

    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click

        ComboBox_autospin.Text = "Delta"

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedkuiperStats = 0
        CheckedkappaStats = 0
        CheckedEpsilonStats = 0
        CheckedZetaStats = 0
        CheckedLambdaStats = 0
        CheckedHadesStats = 0


        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = False
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedDeltaStats = 0 Then

            Dim DataDelta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "delta") ' Info GG Delta

            If DataDelta = Nothing Then
            Else

                If DataDelta.Contains("prepared1") Then
                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataDelta.Contains("prepared0") Then
                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataDelta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataDelta)
                Dim regex_totalWave = Utils.getTotalWave(DataDelta)
                Dim regex_currentPart = Utils.getCurrentPart(DataDelta)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then

                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 128"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 128"
                End If

            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")
            CheckedDeltaStats = 1
        Else
        End If

        '''
        '

        '
        ''
        ''''

    End Sub

    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Size = New Size(553, 622)

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = False

        Dim DataChronos = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "chronos") ' Info GG chronos

        If DataChronos = Nothing Then
        Else

            If DataChronos.Contains("prepared1") Then

                Label_infoPartGG_InMap.Text = "On map : 1"

            ElseIf DataChronos.Contains("prepared0") Then

                Label_infoPartGG_InMap.Text = "On map : 0"

            End If

            Dim regex_livesLeft = Regex.Match(DataChronos, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
            If Not regex_livesLeft.Length = 0 Then

                If regex_livesLeft > 5 Then
                    Label_LivesLeft.Text = "Lives left : 5+"

                ElseIf regex_livesLeft = -1 Then
                    Label_LivesLeft.Text = "Lives left : -1"
                Else
                    Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                End If
            End If

            Dim regex_currentWave = Utils.getCurrentWave(DataChronos)
            Dim regex_totalWave = Utils.getTotalWave(DataChronos)
            Dim regex_currentPart = Utils.getCurrentPart(DataChronos)

            If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

            Else
                Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
            End If

            If Not regex_currentPart = "?" Then


                Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 21"
            Else
                Label_InfoPartGG.Text = "Part : " + "?" + " / 21"
            End If

        End If

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=12&type=full")
    End Sub

    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click

        ComboBox_autospin.Text = "Hades"

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0


        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Size = New Size(553, 622)

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = False
        Button_kronos.Enabled = True

        If CheckedHadesStats = 0 Then

            Dim DataHades = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "hades") ' Info GG hades

            If DataHades = Nothing Then
            Else

                If DataHades.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataHades.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataHades, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataHades)
                Dim regex_totalWave = Utils.getTotalWave(DataHades)
                Dim regex_currentPart = Utils.getCurrentPart(DataHades)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then

                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 45"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 45"
                End If
            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=13&type=full")
            CheckedHadesStats = 1

        Else
        End If

    End Sub

    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click

        ComboBox_autospin.Text = "Kuiper"

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedHadesStats = 0


        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Size = New Size(553, 622)

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = False
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedkuiperStats = 0 Then

            Dim DataKuiper = Utils.getKuiperGG(TextBox_GGinfoGGS.Text)

            If DataKuiper = Nothing Then
            Else

                If DataKuiper.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataKuiper.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataKuiper, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                Console.WriteLine("DEBUG = " + regex_livesLeft)

                If Not regex_livesLeft.Length = 0 Then
                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataKuiper)
                Dim regex_totalWave = Utils.getTotalWave(DataKuiper)
                Dim regex_currentPart = Utils.getCurrentPart(DataKuiper)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 100"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 100"
                End If
            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=19&type=full")
            CheckedkuiperStats = 1

        Else
        End If

    End Sub

    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click

        ComboBox_autospin.Text = "Lambda"

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0


        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Size = New Size(553, 622)

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = False
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedLambdaStats = 0 Then

            Dim DataLambda = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "lambda") ' Info GG lambda

            If DataLambda = Nothing Then
            Else

                If DataLambda.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataLambda.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataLambda, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataLambda)
                Dim regex_totalWave = Utils.getTotalWave(DataLambda)
                Dim regex_currentPart = Utils.getCurrentPart(DataLambda)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 45"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 45"
                End If

            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=8&type=full")
            CheckedLambdaStats = 1

        Else
        End If



    End Sub

    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click

        ComboBox_autospin.Text = "Kappa"

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedkuiperStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedLambdaStats = 0
        CheckedHadesStats = 0


        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Size = New Size(553, 622)

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = False
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedkappaStats = 0 Then

            Dim DataKappa = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "kappa") ' Info GG kappa

            If DataKappa = Nothing Then
            Else

                If DataKappa.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataKappa.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataKappa, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else
                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataKappa)
                Dim regex_totalWave = Utils.getTotalWave(DataKappa)
                Dim regex_currentPart = Utils.getCurrentPart(DataKappa)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 120"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 120"
                End If

            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=7&type=full")
            CheckedkappaStats = 1

        Else
        End If

    End Sub

    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click

        ComboBox_autospin.Text = "Zeta"

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0


        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Size = New Size(553, 622)

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = False
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedZetaStats = 0 Then

            Dim DataZeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "zeta") ' Info GG zeta

            If DataZeta = Nothing Then
            Else

                If DataZeta.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataZeta.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If

                Dim regex_livesLeft = Regex.Match(DataZeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString

                If Not regex_livesLeft.Length = 0 Then

                    If regex_livesLeft > 5 Then
                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then
                        Label_LivesLeft.Text = "Lives left : -1"
                    Else

                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataZeta)
                Dim regex_totalWave = Utils.getTotalWave(DataZeta)
                Dim regex_currentPart = Utils.getCurrentPart(DataZeta)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                If Not regex_currentPart = "?" Then


                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 111"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 111"
                End If
            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=6&type=full")
            CheckedZetaStats = 1

        Else
        End If

    End Sub

    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click

        ComboBox_autospin.Text = "Epsilon"

        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        '
        CheckedAlphaBetaGammaStats = 0
        CheckedLambdaStats = 0
        CheckedkappaStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0


        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False
        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)
        Size = New Size(553, 622)

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True
        Button_delta.Enabled = True
        Button_epsilon.Enabled = False
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kuiper.Enabled = True
        Button_hades.Enabled = True
        Button_kronos.Enabled = True

        If CheckedEpsilonStats = 0 Then

            Dim DataEpsilon = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "epsilon") ' Info GG epsilon
            '
            If DataEpsilon = Nothing Then
            Else


                If DataEpsilon.Contains("prepared1") Then

                    Label_infoPartGG_InMap.Text = "On map : 1"

                ElseIf DataEpsilon.Contains("prepared0") Then

                    Label_infoPartGG_InMap.Text = "On map : 0"

                End If


                Dim regex_livesLeft = Regex.Match(DataEpsilon, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString

                If Not regex_livesLeft.Length = 0 Then
                    'Le regex contient quelque chose
                    If regex_livesLeft > 5 Then

                        Label_LivesLeft.Text = "Lives left : 5+"

                    ElseIf regex_livesLeft = -1 Then

                        Label_LivesLeft.Text = "Lives left : -1"
                    Else

                        Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                    End If
                End If

                Dim regex_currentWave = Utils.getCurrentWave(DataEpsilon)
                Dim regex_totalWave = Utils.getTotalWave(DataEpsilon)
                Dim regex_currentPart = Utils.getCurrentPart(DataEpsilon)

                If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If


                If Not regex_currentPart = "?" Then

                    Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 99"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 99"
                End If

            End If

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=5&type=full")
            CheckedEpsilonStats = 1

        Else
        End If


        '
        '

    End Sub
#End Region

    Private Sub Button_OpenLoginPanel_Click(sender As Object, e As EventArgs) Handles Button_OpenLoginPanel.Click

        'button open Login Box'

        Form_Startup.CheckedStats = 1
        Form_Startup.Show()

    End Sub

#Region "Button Click GGS"
    Private Sub Button_Delta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Delta_GGS.Click

        'delta
        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0

        Button_delta.Enabled = True
        Button_Delta_GGS.Enabled = False
        Button_delta.PerformClick()

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=4&delta=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Epsilon_GGS_Click(sender As Object, e As EventArgs) Handles Button_Epsilon_GGS.Click

        ' epsilon
        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        CheckedAlphaBetaGammaStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0

        Button_epsilon.Enabled = True
        Button_Epsilon_GGS.Enabled = False
        Button_epsilon.PerformClick()

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=5&epsilon=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Zeta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Zeta_GGS.Click

        'zeta
        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0

        Button_zeta.Enabled = True
        Button_Zeta_GGS.Enabled = False
        Button_zeta.PerformClick()

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=6&zeta=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Kappa_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kappa_GGS.Click

        ' kappa
        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0

        Button_Kappa.Enabled = True
        Button_Kappa_GGS.Enabled = False
        Button_Kappa.PerformClick()

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=7&kappa=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Lambda_GGS_Click(sender As Object, e As EventArgs) Handles Button_Lambda_GGS.Click

        'lambda
        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedkuiperStats = 0
        CheckedHadesStats = 0

        Button_lambda.Enabled = True
        Button_Lambda_GGS.Enabled = False
        Button_lambda.PerformClick()

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=8&lambda=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Kuiper_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kuiper_GGS.Click

        'kuiper
        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedHadesStats = 0

        Button_kuiper.Enabled = True
        Button_Kuiper_GGS.Enabled = False
        Button_kuiper.PerformClick()

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=19&streuner=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Hades_GGS_Click(sender As Object, e As EventArgs) Handles Button_Hades_GGS.Click

        'hades
        CheckedAlphaBetaGammaStats2 = 0
        CheckedAlphaBetaGammaStats3 = 0
        CheckedAlphaBetaGammaStats = 0
        CheckedEpsilonStats = 0
        CheckedDeltaStats = 0
        CheckedZetaStats = 0
        CheckedkappaStats = 0
        CheckedLambdaStats = 0
        CheckedkuiperStats = 0

        Button_hades.Enabled = True
        Button_Hades_GGS.Enabled = False
        Button_hades.PerformClick()

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=13&hades=1&sample=1&multiplier=1")

    End Sub
#End Region

#Region "Spin Click"
    Public numberToSpin As String = 0
    Public uridiumToKeep As String
    Private Sub Button_StartSpin_Click(sender As Object, e As EventArgs) Handles Button_StartSpin.Click


        If BackgroundWorkerAutospin = False Then

            If TextBox_spintimes_GGS.Text.Contains(".") Then
                BackgroundWorkerAutospin = True
                MessageBox.Show($"Error, you can't put a dot in the spin time.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf TextBox_spintimes_GGS.Text.Contains(" ") Then
                BackgroundWorkerAutospin = True
                MessageBox.Show($"Error, you can't put a space in the spin time.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf Val(TextBox_spintimes_GGS.Text) < 100 Then
                TextBox_spintimes_GGS.Text = 100
                BackgroundWorkerAutospin = False
                MessageBox.Show($"Error, you can't put less than 150ms.{vbNewLine}Starting with 100ms by default", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                BackgroundWorkerAutospin = False
            End If

            If BackgroundWorkerAutospin = False Then
                BackgroundWorkerAutospin = True

                Button_StartSpin.Enabled = False
                Button_stopSpin.Enabled = True

                Dim data = ComboBox_autospin.Text
                Select Case data
                    Case "ABG"
                        '  MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)
                    Case "Delta"
                        '  MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)
                    Case "Epsilon"
                        '   MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)
                    Case "Zeta"
                        '   MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)
                    Case "Kappa"
                        '   MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)
                    Case "Lambda"
                        '   MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)
                    Case "Kuiper"
                        '  MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)
                    Case "Hades"
                        '  MsgBox(data)
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case Else
                        BackgroundWorkerAutospin = False
                        MessageBox.Show("Erreur, Aucune GG selectionnée", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
                'If BackgroundWorkerAutospin = True Then
                '    ClickGG("alpha", 250)
                'End If
            Else
                BackgroundWorkerAutospin = False
            End If
        Else
            MessageBox.Show($"GG Snipper already started{vbNewLine}Stop it before starting it again", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button_StartSpin.Enabled = True

            ' Console.WriteLine("Already used")
        End If

    End Sub

    Private Sub Button_stopSpin_Click(sender As Object, e As EventArgs) Handles Button_stopSpin.Click
        If BackgroundWorkerAutospin = True Then
            BackgroundWorkerAutospin = False
            MessageBox.Show("Autospinner deactivated.")
        End If

        Button_StartSpin.Enabled = True
        Button_stopSpin.Enabled = False
        ComboBox_autospin.Enabled = True
    End Sub

    Private Async Sub ClickGG(portail As String, temps As Integer)
        Dim delay = Task.Delay(temps)
        If CheckBox_UseOnlyEE_GGS.Checked = True And TextBox_ExtraEnergy_GGS.Text = "0" Then
            BackgroundWorkerAutospin = False
            TextBox_WinGGS.Text = vbNewLine + $"(Galaxy Gates - {ComboBox_autospin.Text}) There is no more EE left..." + TextBox_WinGGS.Text
        End If
        If BackgroundWorkerAutospin = True Then
            uridiumToKeep = Replace(TextBox_uridiumtokeepGGS.Text, ".", "")
            ComboBox_autospin.Enabled = False
            'DoWork ici

            Select Case portail
                Case "ABG"
                    If Button_ABG_GGS.Enabled = True Then
                        Button_ABG_GGS.PerformClick()
                    End If

                Case "Delta"
                    If Button_Delta_GGS.Enabled = True Then
                        Button_Delta_GGS.PerformClick()
                    End If

                Case "Epsilon"
                    If Button_Epsilon_GGS.Enabled = True Then
                        Button_Epsilon_GGS.PerformClick()
                    End If

                Case "Zeta"
                    If Button_Zeta_GGS.Enabled = True Then
                        Button_Zeta_GGS.PerformClick()
                    End If

                Case "Kappa"
                    If Button_Kappa_GGS.Enabled = True Then
                        Button_Kappa_GGS.PerformClick()
                    End If

                Case "Lambda"
                    If Button_Lambda_GGS.Enabled = True Then
                        Button_Lambda_GGS.PerformClick()
                    End If

                Case "Kuiper"
                    If Button_Kuiper_GGS.Enabled = True Then
                        Button_Kuiper_GGS.PerformClick()
                    End If

                Case "Hades"
                    If Button_Hades_GGS.Enabled = True Then
                        Button_Hades_GGS.PerformClick()
                    End If


                Case Else
                    BackgroundWorkerAutospin = False
                    MsgBox("Erreur, Aucune GG selectionnée")
            End Select

            'Avant le timer
            Await delay
            'Apres le timer


            'TODO: Verification uri et prepare gates

            Dim infoPartGG = Label_InfoPartGG.Text.Replace("Part : ", "")
            Dim infoinMapGG As Boolean = Label_infoPartGG_InMap.Text.Replace("On map : ", "")
            Console.WriteLine($"DEBUG-{infoinMapGG}")

            If infoPartGG.Split(" / ").First = infoPartGG.Split(" / ").Last Then
                If infoinMapGG = False Then
                    If CheckBox_PrepareGatesIfBuiled.Checked = True Then
                        Button_PrepareGates.PerformClick()
                        TextBox_WinGGS.Text = vbNewLine + $"(Galaxy Gates - {ComboBox_autospin.Text}) was put in your mothermap" + TextBox_WinGGS.Text
                        If CheckBox_buildoneandstop.Checked = True Then
                            BackgroundWorkerAutospin = False
                            TextBox_WinGGS.Text = vbNewLine + $"(Galaxy Gates - {ComboBox_autospin.Text }) The Galaxy Gates {ComboBox_autospin.Text} is 1/2 completed." + TextBox_WinGGS.Text
                            MessageBox.Show($"(Galaxy Gates {ComboBox_autospin.Text}) The Galaxy Gates {ComboBox_autospin.Text} is 1/2 completed", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        BackgroundWorkerAutospin = False
                        MessageBox.Show($"The Galaxy Gates {ComboBox_autospin.Text} is 2/2 completed{vbNewLine}Stopping the spinner.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If


            ClickGG(portail, temps)
        Else
            BackgroundWorkerAutospin = False
            Button_StartSpin.Enabled = True
            Button_stopSpin.Enabled = False
            ComboBox_autospin.Enabled = True

        End If
    End Sub



#End Region

#End Region

    Private Sub TextBox_uridiumtokeepGGS_LostFocus(sender As Object, e As EventArgs) Handles TextBox_uridiumtokeepGGS.LostFocus
        TextBox_uridiumtokeepGGS.Text = Utils.NumberToHumanReadable(TextBox_uridiumtokeepGGS.Text, ".")
    End Sub

    Private Sub Button_ResetStats_Click(sender As Object, e As EventArgs) Handles Button_ResetStats.Click

        Calculator = 1
        TextBox_uridiumCurrent.Text = 0
        TextBox_creditCurrent.Text = 0
        TextBox_honorCurrent.Text = 0
        TextBox_experienceCurrent.Text = 0
        TextBox_RPCurrent.Text = 0
        TextBox_LevelCurrent.Text = 0

        TextBox_uridiumEarned.Text = 0
        TextBox_creditEarned.Text = 0
        TextBox_honorEarned.Text = 0
        TextBox_experienceEarned.Text = 0
        TextBox_RPEarned.Text = 0


        Reader = 1
        BackPage_Form.ShowIcon = False
        BackPage_Form.ShowInTaskbar = False

        Utils.checkStats = True
        BackPage_Form.Show()
        BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        BackPage_Form.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub Button_PrepareGates_Click(sender As Object, e As EventArgs) Handles Button_PrepareGates.Click

        If Button_Alpha.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 1))

        ElseIf Button_beta.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 2))

        ElseIf Button_gamma.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 3))

        ElseIf Button_delta.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 4))

        ElseIf Button_epsilon.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 5))

        ElseIf Button_zeta.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 6))

        ElseIf Button_Kappa.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 7))

        ElseIf Button_lambda.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 8))

        ElseIf Button_hades.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 19))

        ElseIf Button_kuiper.Enabled = False Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 13))
        End If

        'https://fr1.darkorbit.com/flashinput/galaxyGates.php?userID=TONID&sid=TONSID&action=setupGate&gateID=1

    End Sub


    Private Sub WebBrowser_GGspinner_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_GGspinner.DocumentCompleted
        'Après le click
#Region "WebBrowser_GGspinner"
        Dim html5 = WebBrowser_GGspinner.DocumentText.Clone
        TextBox_DebugGGS.Text = html5
        'Console.WriteLine(html5)
        'Clipboard.SetText(html5)

        Dim mode = Regex.Match(TextBox_DebugGGS.Text, "mode<\/SPAN><SPAN class=""m"">&gt;<\/SPAN><SPAN class=""tx"".*?>([\s\S]*?)<\/SPAN>") ' quel type de GG
        Console.WriteLine(mode.Groups.Item(1).ToString)

        Dim money = Regex.Match(TextBox_DebugGGS.Text, "money<\/SPAN><SPAN class=""m"">&gt;<\/SPAN><SPAN class=""tx"".*?>([\s\S]*?)<\/SPAN>") ' money en cours d'utilisation
        Console.WriteLine(money.Groups.Item(1).ToString)

        Dim spinamount_selected = Regex.Match(TextBox_DebugGGS.Text, "spinamount_selected<\/SPAN><SPAN class=""m"">&gt;<\/SPAN><SPAN class=""tx"".*?>([\s\S]*?)<\/SPAN>") ' nombre de spin utiliser
        Console.WriteLine(spinamount_selected.Groups.Item(1).ToString)

        Dim samples = Regex.Match(TextBox_DebugGGS.Text, "samples.*?>([\s\S]*?)<\/SPAN><SPAN class=""m"">") ' energy restante
        Dim DataSamples = (samples.Groups.Item(1).ToString)
        DataSamples = Replace(DataSamples, "<SPAN class=""m"">&gt;</SPAN><SPAN class=""tx"">", "")
        Console.WriteLine(DataSamples)

        Dim Winned = Regex.Match(TextBox_DebugGGS.Text, "type.*?>([\s\S]*?)<\/B>") ' winned into spin >>> type
        Dim DataWinned = (Winned.Groups.Item(1).ToString)
        DataWinned = Replace(DataWinned, "<SPAN class=""m"">=""</SPAN><B>", "")
        Console.WriteLine(DataWinned)

        Dim Winned2 = Regex.Match(TextBox_DebugGGS.Text, "item_id.*?>([\s\S]*?)<\/B>") ' winned into spin >>> item id
        Dim DataWinned2 = (Winned2.Groups.Item(1).ToString)
        DataWinned2 = Replace(DataWinned2, "<SPAN class=""m"">=""</SPAN><B>", "")
        Console.WriteLine(DataWinned2)

        Dim Winned3 = Regex.Match(TextBox_DebugGGS.Text, "class=""t""> amount.*?>([\s\S]*?)<\/B>") ' winned into spin >>> amount
        Dim DataWinned3 = (Winned3.Groups.Item(1).ToString)
        DataWinned3 = Replace(DataWinned3, "<SPAN class=""m"">=""</SPAN><B>", "")
        Console.WriteLine(DataWinned3)

        TextBox_uridiumGGS.Text = Utils.NumberToHumanReadable(money.Groups.Item(1).ToString, ".")
        TextBox_ExtraEnergy_GGS.Text = Utils.NumberToHumanReadable(DataSamples, ".")

        If DataWinned Is Nothing AndAlso DataWinned2 Is Nothing Then
            TextBox_WinGGS.Text = vbNewLine + "Materializer locked !"
        Else

            If DataWinned.Contains("battery") AndAlso DataWinned2.Contains("2") Then
                DataWinned = "MCB-25"

            ElseIf DataWinned.Contains("battery") AndAlso DataWinned2.Contains("3") Then
                DataWinned = "MCB-50"

            ElseIf DataWinned.Contains("battery") AndAlso DataWinned2.Contains("4") Then
                DataWinned = "UCB-100"

            ElseIf DataWinned.Contains("battery") AndAlso DataWinned2.Contains("5") Then
                DataWinned = "SAB-50"

            ElseIf DataWinned.Contains("ore") Then
                DataWinned = "Xenomit"

            ElseIf DataWinned.Contains("nanohull") Then
                DataWinned = "Nanohull"

            ElseIf DataWinned.Contains("logfile") Then
                DataWinned = "Logfile"

            ElseIf DataWinned.Contains("rocket") Then
                DataWinned = "PLT-2021"

            ElseIf DataWinned.Contains("voucher") Then
                DataWinned = "Mine"

            ElseIf DataWinned.Contains("part") Then

#Region "Delta"
                If Button_delta.Enabled = False Then

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")
                    Dim DataDelta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "delta") ' Info GG Delta

                    If DataDelta = Nothing Then
                    Else

                        If DataDelta.Contains("prepared1") Then
                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataDelta.Contains("prepared0") Then
                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataDelta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        If Not regex_livesLeft.Length = 0 Then

                            If regex_livesLeft > 5 Then
                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft.Text = "Lives left : -1"
                            Else
                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataDelta)
                        Dim regex_totalWave = Utils.getTotalWave(DataDelta)
                        Dim regex_currentPart = Utils.getCurrentPart(DataDelta)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then

                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 128"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 128"
                        End If

                    End If

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")
                    CheckedDeltaStats = 1
                End If
#End Region

#Region "Epsilon"
                If Button_epsilon.Enabled = False Then

                    Dim DataEpsilon = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "epsilon") ' Info GG epsilon
                    '
                    If DataEpsilon = Nothing Then
                    Else


                        If DataEpsilon.Contains("prepared1") Then

                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataEpsilon.Contains("prepared0") Then

                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If


                        Dim regex_livesLeft = Regex.Match(DataEpsilon, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString

                        If Not regex_livesLeft.Length = 0 Then
                            'Le regex contient quelque chose
                            If regex_livesLeft > 5 Then

                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then

                                Label_LivesLeft.Text = "Lives left : -1"
                            Else

                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataEpsilon)
                        Dim regex_totalWave = Utils.getTotalWave(DataEpsilon)
                        Dim regex_currentPart = Utils.getCurrentPart(DataEpsilon)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If


                        If Not regex_currentPart = "?" Then

                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 99"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 99"
                        End If

                    End If

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=5&type=full")
                    CheckedEpsilonStats = 1
                End If
#End Region

#Region "Zeta"
                If Button_zeta.Enabled = False Then

                    Dim DataZeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "zeta") ' Info GG zeta

                    If DataZeta = Nothing Then
                    Else

                        If DataZeta.Contains("prepared1") Then

                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataZeta.Contains("prepared0") Then

                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataZeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString

                        If Not regex_livesLeft.Length = 0 Then

                            If regex_livesLeft > 5 Then
                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft.Text = "Lives left : -1"
                            Else

                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataZeta)
                        Dim regex_totalWave = Utils.getTotalWave(DataZeta)
                        Dim regex_currentPart = Utils.getCurrentPart(DataZeta)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then


                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 111"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 111"
                        End If
                    End If

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=6&type=full")
                    CheckedZetaStats = 1
                End If
#End Region

#Region "Kappa"
                If Button_Kappa.Enabled = False Then

                    Dim DataKappa = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "kappa") ' Info GG kappa

                    If DataKappa = Nothing Then
                    Else

                        If DataKappa.Contains("prepared1") Then

                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataKappa.Contains("prepared0") Then

                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataKappa, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        If Not regex_livesLeft.Length = 0 Then

                            If regex_livesLeft > 5 Then
                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft.Text = "Lives left : -1"
                            Else
                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataKappa)
                        Dim regex_totalWave = Utils.getTotalWave(DataKappa)
                        Dim regex_currentPart = Utils.getCurrentPart(DataKappa)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then


                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 120"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 120"
                        End If

                    End If

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=7&type=full")
                    CheckedkappaStats = 1
                End If
#End Region

#Region "Lambda"
                If Button_lambda.Enabled = False Then

                    Dim DataLambda = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "lambda") ' Info GG lambda

                    If DataLambda = Nothing Then
                    Else

                        If DataLambda.Contains("prepared1") Then

                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataLambda.Contains("prepared0") Then

                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataLambda, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        If Not regex_livesLeft.Length = 0 Then

                            If regex_livesLeft > 5 Then
                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft.Text = "Lives left : -1"
                            Else
                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataLambda)
                        Dim regex_totalWave = Utils.getTotalWave(DataLambda)
                        Dim regex_currentPart = Utils.getCurrentPart(DataLambda)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then


                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 45"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 45"
                        End If

                    End If

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=8&type=full")
                    CheckedLambdaStats = 1
                End If
#End Region

#Region "Kuiper"
                If Button_kuiper.Enabled = False Then

                    Dim DataKuiper = Utils.getKuiperGG(TextBox_GGinfoGGS.Text)

                    If DataKuiper = Nothing Then
                    Else

                        If DataKuiper.Contains("prepared1") Then

                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataKuiper.Contains("prepared0") Then

                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataKuiper, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        Console.WriteLine("DEBUG = " + regex_livesLeft)

                        If Not regex_livesLeft.Length = 0 Then
                            If regex_livesLeft > 5 Then
                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft.Text = "Lives left : -1"
                            Else
                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataKuiper)
                        Dim regex_totalWave = Utils.getTotalWave(DataKuiper)
                        Dim regex_currentPart = Utils.getCurrentPart(DataKuiper)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then


                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 100"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 100"
                        End If
                    End If

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=19&type=full")
                    CheckedkuiperStats = 1
                End If
#End Region

#Region "Hades"
                If Button_hades.Enabled = False Then

                    Dim DataHades = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "hades") ' Info GG hades

                    If DataHades = Nothing Then
                    Else

                        If DataHades.Contains("prepared1") Then

                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataHades.Contains("prepared0") Then

                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataHades, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        If Not regex_livesLeft.Length = 0 Then

                            If regex_livesLeft > 5 Then
                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft.Text = "Lives left : -1"
                            Else
                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataHades)
                        Dim regex_totalWave = Utils.getTotalWave(DataHades)
                        Dim regex_currentPart = Utils.getCurrentPart(DataHades)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then

                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 45"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 45"
                        End If
                    End If

                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=13&type=full")
                    CheckedHadesStats = 1
                End If
#End Region

#Region "ABG"
                If Button_Alpha.Enabled = False Then

                    Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "alpha") ' info GG Alpha
                    If DataAlpha = Nothing Then
                    Else

                        If DataAlpha.Contains("prepared1") Then
                            Label_infoPartGG_InMap.Text = "On map : 1"

                        ElseIf DataAlpha.Contains("prepared0") Then
                            Label_infoPartGG_InMap.Text = "On map : 0"

                        End If

                        Dim regex_livesLeftAlpha = Regex.Match(DataAlpha, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        If Not regex_livesLeftAlpha.Length = 0 Then

                            If regex_livesLeftAlpha > 5 Then
                                Label_LivesLeft.Text = "Lives left : 5+"

                            ElseIf regex_livesLeftAlpha = -1 Then
                                Label_LivesLeft.Text = "Lives left : -1"

                            Else
                                Label_LivesLeft.Text = "Lives left : " + regex_livesLeftAlpha

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataAlpha)
                        Dim regex_totalWave = Utils.getTotalWave(DataAlpha)
                        Dim regex_currentPart = Utils.getCurrentPart(DataAlpha)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then

                            Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave
                        Else
                            Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then

                            Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 34"
                        Else
                            Label_InfoPartGG.Text = "Part : " + "?" + " / 34"
                        End If

                        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")
                        CheckedAlphaBetaGammaStats = 1

                    End If
                    Dim DataBeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "beta") ' Info GG Beta
                    If DataBeta = Nothing Then
                    Else

                        If DataBeta.Contains("prepared1") Then

                            Label_infoPartGG_InMap2.Text = "On map : 1"

                        ElseIf DataBeta.Contains("prepared0") Then

                            Label_infoPartGG_InMap2.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataBeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        If Not regex_livesLeft.Length = 0 Then

                            If regex_livesLeft > 5 Then
                                Label_LivesLeft2.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft2.Text = "Lives left : -1"
                            Else
                                Label_LivesLeft2.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataBeta)
                        Dim regex_totalWave = Utils.getTotalWave(DataBeta)
                        Dim regex_currentPart = Utils.getCurrentPart(DataBeta)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave2.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave2.Text = "Wave : " + "?" + " / " + "Unknown"
                        End If

                        If Not regex_currentPart = "?" Then


                            Label_InfoPartGG2.Text = "Part : " + regex_currentPart + " / 48"
                        Else
                            Label_InfoPartGG2.Text = "Part : " + "?" + " / 48"
                        End If

                        WebBrowser_galaxyGates2.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")
                        CheckedAlphaBetaGammaStats2 = 1

                    End If
                    Dim DataGamma = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "gamma") ' Info GG gamma
                    If DataGamma = Nothing Then
                    Else

                        If DataGamma.Contains("prepared1") Then

                            Label_infoPartGG_InMap3.Text = "On map : 1"

                        ElseIf DataGamma.Contains("prepared0") Then

                            Label_infoPartGG_InMap3.Text = "On map : 0"

                        End If

                        Dim regex_livesLeft = Regex.Match(DataGamma, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
                        If Not regex_livesLeft.Length = 0 Then

                            If regex_livesLeft > 5 Then
                                Label_LivesLeft3.Text = "Lives left : 5+"

                            ElseIf regex_livesLeft = -1 Then
                                Label_LivesLeft3.Text = "Lives left : -1"
                            Else
                                Label_LivesLeft3.Text = "Lives left : " + regex_livesLeft

                            End If
                        End If

                        Dim regex_currentWave = Utils.getCurrentWave(DataGamma)
                        Dim regex_totalWave = Utils.getTotalWave(DataGamma)
                        Dim regex_currentPart = Utils.getCurrentPart(DataGamma)

                        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
                            Label_infoPartGG_CurrentWave3.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                        Else
                            Label_infoPartGG_CurrentWave3.Text = "Wave : " + "?" + " / " + "?"
                        End If

                        If Not regex_currentPart = "?" Then


                            Label_InfoPartGG3.Text = "Part : " + regex_currentPart + " / 82"
                        Else
                            Label_InfoPartGG3.Text = "Part : " + "?" + " / 82"
                        End If

                        AlphaBetaGammaReupload = 0

                        WebBrowser_galaxyGates3.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")
                        CheckedAlphaBetaGammaStats3 = 1
                    End If



                End If
#End Region

                DataWinned = "Part/ Multiplier assigned"
            End If

        End If

        TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text

        If DataWinned Is Nothing AndAlso DataWinned2 Is Nothing Then
        Else

            If DataWinned.Contains("MCB-25") Then

                Label_MCB25_Earned.Text = Val(Label_MCB25_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("MCB-50") Then

                Label_MCB50_Earned.Text = Val(Label_MCB50_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("UCB-100") Then

                Label_UCB100_Earned.Text = Val(Label_UCB100_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("SAB-50") Then

                Label_SAB50_Earned.Text = Val(Label_SAB50_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("Xenomit") Then

                Label_Xenomit_Earned.Text = Val(Label_Xenomit_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("Nanohull") Then

                Label_Nanohull_Earned.Text = Val(Label_Nanohull_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("Logfile") Then

                Label_Logfile_Earned.Text = Val(Label_Logfile_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("PLT-2021") Then

                Label_PLT2021_Earned.Text = Val(Label_PLT2021_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("Mine") Then

                Label_Mine_Earned.Text = Val(Label_Mine_Earned.Text) + DataWinned3

            ElseIf DataWinned.Contains("Part/ Multiplier assigned") Then

                Label_Part_Earned.Text = Val(Label_Part_Earned.Text) + DataWinned3

            End If


        End If

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
#End Region

    End Sub

    Private Sub WebBrowser_GGInfo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_GGInfo.DocumentCompleted

        'Lors du click "Galaxy Gates"

        Dim html107 = WebBrowser_GGInfo.DocumentText.Clone
        TextBox_GGinfoGGS.Text = html107

        Dim DataSamples2 = Regex.Match(TextBox_GGinfoGGS.Text, "<SPAN class=""m"">&lt;<\/SPAN>(<SPAN class=""t"">samples.*?>[\s\S]*?)class=""t"">samples<\/SPAN>").Groups.Item(1).ToString ' energy restante

        DataSamples2 = DataSamples2.Replace("<SPAN Class=""t" > "", "")
        DataSamples2 = DataSamples2.Replace("</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        DataSamples2 = DataSamples2.Replace("<SPAN Class=""tx"">", "")
        DataSamples2 = DataSamples2.Replace("</SPAN><SPAN class=""m"">&lt;/</SPAN><SPAN", "")
        DataSamples2 = DataSamples2.Replace("<SPAN class=""t"">", "")
        DataSamples2 = DataSamples2.Replace("<SPAN class=""tx"">", "")

        Dim EERestant = Regex.Match(DataSamples2, "samples.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        TextBox_ExtraEnergy_GGS.Text = Utils.NumberToHumanReadable(EERestant, ".")

        Button_ABG_GGS.Enabled = True
        Button_Delta_GGS.Enabled = True
        Button_Epsilon_GGS.Enabled = True
        Button_Zeta_GGS.Enabled = True
        Button_Kappa_GGS.Enabled = True
        Button_Lambda_GGS.Enabled = True
        Button_Hades_GGS.Enabled = True
        Button_Kuiper_GGS.Enabled = True

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True

    End Sub

    Private Sub PictureBox_close1_Click(sender As Object, e As EventArgs) Handles PictureBox_close1.Click

        CloseForm.ShowDialog(Me)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label_MCB25_Earned.Text = 0
        Label_MCB50_Earned.Text = 0
        Label_UCB100_Earned.Text = 0
        Label_SAB50_Earned.Text = 0
        Label_PLT2021_Earned.Text = 0
        Label_Part_Earned.Text = 0
        Label_Xenomit_Earned.Text = 0
        Label_Nanohull_Earned.Text = 0
        Label_Mine_Earned.Text = 0
        Label_Logfile_Earned.Text = 0

        TextBox_WinGGS.Text = ""

    End Sub

    Private Sub Button_Refresh_Stats_Click(sender As Object, e As EventArgs) Handles Button_Refresh_Stats.Click

        Reader = 1
        Utils.checkStats = True
        BackPage_Form.ShowIcon = False
        BackPage_Form.ShowInTaskbar = False
        BackPage_Form.Show()
        BackPage_Form.WindowState = FormWindowState.Minimized
        BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

    End Sub

    Private Sub CheckBox_AutoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AutoUpdate.CheckedChanged

        '  Button_Update

    End Sub

    Private Sub PictureBox_epinglerBot_Click(sender As Object, e As EventArgs) Handles PictureBox_epinglerBot.Click
        Console.WriteLine("click !")
        Dim tagBoolean As Boolean = PictureBox_epinglerBot.Tag

        If tagBoolean Then
            PictureBox_epinglerBot.Tag = "0"
            PictureBox_epinglerBot.Image = My.Resources.img_unpin
            Me.TopMost = False
        Else
            PictureBox_epinglerBot.Tag = "1"
            PictureBox_epinglerBot.Image = My.Resources.img_pin
            Me.TopMost = True
        End If

    End Sub

    Private Sub PictureBox_BackgroundBot_Click(sender As Object, e As EventArgs) Handles PictureBox_BackgroundBot.Click

        If TextBox_Get_Dosid.Text = "" Then

            MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            BackPage_Form.ShowIcon = True
            BackPage_Form.ShowInTaskbar = True
            BackPage_Form.Show()
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

        End If


    End Sub

    Private Sub WebBrowser_Synchronisation_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_Synchronisation.DocumentCompleted

        If WebBrowser_Synchronisation.Url.ToString.Contains("22.bpsecure.com") Then
            Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8", vbHide)

            WebBrowser_Synchronisation.Document.GetElementById("bgcdw_login_form_username").SetAttribute("value", Form_Startup.Textbox_Username.Text)
            WebBrowser_Synchronisation.Document.GetElementById("bgcdw_login_form_password").SetAttribute("value", Form_Startup.Textbox_Password.Text)
            For Each p As HtmlElement In WebBrowser_Synchronisation.Document.GetElementsByTagName("input")
                If p.GetAttribute("type") = "submit" Then
                    p.InvokeMember("click")
                End If
            Next

        ElseIf WebBrowser_Synchronisation.Url.ToString.Contains("Start&prc=100") Then

            ' Lance le jeu'
            Dim CheckRegex = Regex.Match(WebBrowser_Synchronisation.Url.ToString, "^http[s]?:[\/][\/]([^.]+)[.]darkorbit[.]com") '.exec(window.location.href);
            Utils.server = CheckRegex.Groups.Item(1).ToString

            Dim testalacon = Regex.Match(WebBrowser_Synchronisation.DocumentText, "dosid=([^&^.']+)")
            If testalacon.Success Then
                Console.WriteLine(testalacon.Value.Split("=")(1))
                Utils.dosid = testalacon.Value.Split("=")(1)

                Utils.userid = Replace(WebBrowser_Synchronisation.Document.GetElementById("header_top_id").InnerText, " ", "")

                TextBox_Get_id.Text = Replace(WebBrowser_Synchronisation.Document.GetElementById("header_top_id").InnerText, " ", "")

                TextBox_Get_Dosid.Text = Replace(Utils.dosid, " ", "")

                TextBox_Get_Server.Text = Replace(Utils.server, " ", "")

                Utils.currentHonnor = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_hnr")).InnerText

                Utils.currentUridium = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_uri")).InnerText

                Utils.currentCredits = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_credits")).InnerText

                Utils.currentXP = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_exp")).InnerText

                Utils.currentLevel = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_level")).InnerText

                TextBox_Get_Server.Text = Utils.server

                Utils.UpdateStats()

                Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
                Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
                Timer_sid.Enabled = True
                Timer_sid.Start()

                WebBrowser_Synchronisation.Navigate("About:Blank")


                If CheckBox_LaunchGameAuto.Checked = True Then

                    Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")
                    Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
                    Form_Game.Show()
                    Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
                    Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
                    WebBrowser_Synchronisation.Navigate("About:Blank")

                End If

            End If

            '   My.Computer.Audio.Play(My.Resources.connected, AudioPlayMode.Background)


        ElseIf WebBrowser_Synchronisation.Url.ToString.Contains("authUser=291") Then
            Dim result = MessageBox.Show("Verify your account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If result = DialogResult.OK Then

                Form_Startup.Show()
                Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
                Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand
                WebBrowser_Synchronisation.Navigate("About:Blank")

            End If

        Else
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_revive_sid.Click

        Timer_sid.Stop()
        Timer_sid.Enabled = False

        TextBox_Get_Dosid.Text = ""
        TextBox_Get_id.Text = ""
        TextBox_Get_Server.Text = ""

        WebBrowser_Synchronisation.Navigate("https://darkorbit-22.bpsecure.com/")

        TextBox_minutedouble2.Text = "0"
        TextBox_minutedouble.Text = "0"
        TextBox_secondsdouble2.Text = "0"
        TextBox_secondsdouble.Text = "0"

    End Sub

    Private Sub Timer_sid_Tick(sender As Object, e As EventArgs) Handles Timer_sid.Tick

        TextBox_secondsdouble.Text = Val(TextBox_secondsdouble.Text) + 1

        ' seconds
        If TextBox_secondsdouble.Text = "10" Then

            TextBox_secondsdouble.Text = "0"
            TextBox_secondsdouble2.Text = Val(TextBox_secondsdouble2.Text) + 1

        End If

        If TextBox_secondsdouble2.Text = "6" Then

            TextBox_secondsdouble2.Text = "0"
            TextBox_minutedouble.Text = Val(TextBox_minutedouble.Text) + 1

        End If

        ' minutes
        If TextBox_minutedouble.Text = "10" Then

            Button_revive_sid.PerformClick()

            TextBox_minutedouble2.Text = "0"
            TextBox_minutedouble.Text = "0"
            TextBox_secondsdouble2.Text = "0"
            TextBox_secondsdouble.Text = "0"

            TextBox_minutedouble2.Text = Val(TextBox_minutedouble2.Text) + 1

        End If

        If TextBox_minutedouble2.Text = "6" Then

            TextBox_minutedouble2.Text = "0"

        End If

    End Sub



    Private Sub Collect_Palladium()


        Try

            Dim Palladium_ = AutoIt.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 5073012, 5, 1)
            AutoIt.ControlClick("Form3", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Palladium_(0), Palladium_(1))

        Catch Palladium_not_found As Exception

        End Try

    End Sub

    Private Sub Collect_box()

        Try

            Dim Bonus_Box = AutoIt.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 1321834, 5, 1)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Bonus_Box(0) - 0, Bonus_Box(1) - 0)

        Catch Bonus_Box_not_found As Exception

        End Try

    End Sub

    Private Sub Collect_Cargo_box()

        Try

            Dim Cargo_Box = AutoIt.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 16777030, 5, 1)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Cargo_Box(0) - 0, Cargo_Box(1) - 0)

        Catch Cargo_Box_not_found As Exception

        End Try

    End Sub

    Private Sub Random_movement()


        'Dim random As New Random(), rndnbr As Integer
        '    rndnbr = random.Next(A6 + 60, A62 + 60)
        '    Dim random2 As New Random(), rndnbr2 As Integer
        '    rndnbr2 = random2.Next(A61 - 20, A63 - 20)

        '    AutoIt.ControlClick("Form3", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, rndnbr, rndnbr2)

    End Sub




























    Private Sub PictureBox_PlayBot_Click(sender As Object, e As EventArgs) Handles PictureBox_PlayBot.Click

    End Sub

    Private Sub PictureBox_StopBot_Click(sender As Object, e As EventArgs) Handles PictureBox_StopBot.Click

    End Sub
End Class





