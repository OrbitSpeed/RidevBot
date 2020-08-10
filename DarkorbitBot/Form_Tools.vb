﻿Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form_Tools

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
    Public ABG As String = 0

    Public BackgroundWorkerAutospin As Boolean = False

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

        Label_Transition_GGS.Text = "__________________________________________________"

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

        Size = New Size(390, 324)
        CenterToScreen()

        If Form_Game.Visible = True Then
            Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Else
            Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        End If

        If Utils.server = "" Then
        Else
            Utils.checkStats = True
            BackPage_Form.Show()
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
            BackPage_Form.WindowState = FormWindowState.Minimized

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

        Size = New Size(390, 324)

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

        Size = New Size(390, 324)

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


        Size = New Size(390, 324)
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
                Size = New Size(390, 324)
            Else
                General_button.Enabled = False
                Label_buttonGeneral.Visible = True
                Panel_general.Visible = True
                Size = New Size(390, 324)
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

        Size = New Size(390, 324)

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
                Size = New Size(390, 324)
            Else
                General_button.Enabled = False
                Label_buttonGeneral.Visible = True
                Panel_general.Visible = True
                Size = New Size(390, 324)
            End If


            General_button.Enabled = False
            Label_buttonGeneral.Visible = True
            Panel_general.Visible = True
            Size = New Size(390, 324)

        Else

            Label_buttonStats.Visible = True
            Stats_Button.Enabled = False
            Panel_stats.Visible = True
            Size = New Size(390, 356)

            Utils.checkStats = True
            BackPage_Form.Show()
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
            BackPage_Form.WindowState = FormWindowState.Minimized

            If Calculator = 1 Then

                UridiumCalculator = Val(TextBox_uridiumCurrent.Text)
                CreditCalculator = Val(TextBox_creditCurrent.Text)
                HonorCalculator = Val(TextBox_honorCurrent.Text)
                ExpCalculator = Val(TextBox_experienceCurrent.Text)
                RPCalculator = Val(TextBox_RPCurrent.Text)

                Calculator = 2
            End If

            UridiumCalculator3 = Val(TextBox_uridiumCurrent.Text)
            CreditCalculator3 = Val(TextBox_creditCurrent.Text)
            HonorCalculator3 = Val(TextBox_honorCurrent.Text)
            ExpCalculator3 = Val(TextBox_experienceCurrent.Text)
            RPCalculator3 = Val(TextBox_RPCurrent.Text)

            UridiumCalculator2 = (UridiumCalculator3) - (UridiumCalculator)
            CreditCalculator2 = (CreditCalculator3) - (CreditCalculator)
            HonorCalculator2 = (HonorCalculator3) - (HonorCalculator)
            ExpCalculator2 = (ExpCalculator3) - (ExpCalculator)
            RPCalculator2 = (RPCalculator3) - (RPCalculator)

            TextBox_uridiumEarned.Text = UridiumCalculator2
            TextBox_creditEarned.Text = CreditCalculator2
            TextBox_honorEarned.Text = HonorCalculator2
            TextBox_experienceEarned.Text = ExpCalculator2
            TextBox_RPEarned.Text = RPCalculator2

        End If

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

        Size = New Size(390, 324)

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

        Size = New Size(390, 324)

    End Sub
#End Region

    Private Sub Button_LaunchGameRidevBrowser_Click(sender As Object, e As EventArgs) Handles Button_LaunchGameRidevBrowser.Click

        If Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser" Then
            Button_LaunchGameRidevBrowser.Cursor = Cursors.WaitCursor
            Button_LaunchGameRidevBrowser.Text = "Connecting..."
            'Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
            Label_galaxygates.Select()

            If Utils.dosid IsNot vbNullString Then
                Utils.connectWithCookie = True
                'Form_Game.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart")
                Form_Game.Show()
                Form_Game.Hide()
            Else
                Form_Game.WebBrowser1.Navigate("https://darkorbit-22.bpsecure.com")
                'Form_Game.Show()
            End If

        ElseIf Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser" Then
            'Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
            Label_galaxygates.Select()
            Form_Game.WebBrowser1.Refresh()
            Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8")
            Form_Game.Show()
        Else
            Button_LaunchGameRidevBrowser.Text = "Already connecting..."
        End If


    End Sub

    Private Sub PictureBox_Backpage_Click(sender As Object, e As EventArgs) Handles PictureBox_Backpage.Click

        If Utils.server.Length = 0 Then
            MessageBox.Show("You must first login to the game before you can access the page", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
            BackPage_Form.Show()
        End If

    End Sub


#Region "Galaxy Gates"
    ' full = toute la gg 
    ' last = derniere piece

#Region "GG Click Portail"

    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click

        ABG = "1"

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

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
        Button_kronos.Enabled = True

        Panel_infoPartGG2.Visible = True
        Panel_infoPartGG3.Visible = True
        Panel_infoPartGG_GG2.Visible = True
        Panel_infoPartGG_GG3.Visible = True

        Panel_GalaxyGates.Size = New Size(995, 514)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=1&alpha=1&sample=1&multiplier=1")
        Me.Size = New Size(1079, 532)

        TextBox_WinGGS.Size = New Size(521, 162)
        TextBox_WinGGS.Location = New Point(461, 340)

        Label_Transition_GGS.Text = "_____________________________________________________________________________________________________________"

        WebBrowser_galaxyGates2.Visible = True
        WebBrowser_galaxyGates3.Visible = True

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")
        WebBrowser_galaxyGates2.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")
        WebBrowser_galaxyGates3.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")

        Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 34) ' Info GG Alpha
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Alpha")
        Console.WriteLine(DataAlpha)

        Dim DataBeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 48) ' Info GG Beta
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Beta")
        Console.WriteLine(DataBeta)

        Dim DataGamma = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 82) ' Info GG gamma
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Gamma")
        Console.WriteLine(DataGamma)

        If DataAlpha.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataAlpha.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeftAlpha = Regex.Match(DataAlpha, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeftAlpha)

        If Not regex_livesLeftAlpha.Length = 0 Then
            'Le regex contient quelque chose
            If regex_livesLeftAlpha > 5 Then

                Label_LivesLeft.Text = "Lives left : 5+"

            ElseIf regex_livesLeftAlpha = -1 Then

                Label_LivesLeft.Text = "Lives left : -1"
            Else

                Label_LivesLeft.Text = "Lives left : " + regex_livesLeftAlpha

            End If


        End If

        '________________________________________________________________



        If DataBeta.Contains("prepared1") Then

            Label_infoPartGG_InMap2.Text = "On map : 1"

        ElseIf DataBeta.Contains("prepared0") Then

            Label_infoPartGG_InMap2.Text = "On map : 0"

        End If

        Dim regex_livesLeftBeta = Regex.Match(DataBeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeftBeta)

        If Not regex_livesLeftBeta.Length = 0 Then
            'Le regex contient quelque chose
            If regex_livesLeftBeta > 5 Then

                Label_LivesLeft.Text = "Lives left : 5+"

            ElseIf regex_livesLeftBeta = -1 Then

                Label_LivesLeft.Text = "Lives left : -1"
            Else

                Label_LivesLeft.Text = "Lives left : " + regex_livesLeftBeta

            End If


        End If

        '_________________________________________________


        If DataGamma.Contains("prepared1") Then

            Label_infoPartGG_InMap3.Text = "On map : 1"

        ElseIf DataGamma.Contains("prepared0") Then

            Label_infoPartGG_InMap3.Text = "On map : 0"

        End If



        Dim regex_livesLeftGamma = Regex.Match(DataGamma, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeftGamma)

        If Not regex_livesLeftGamma.Length = 0 Then
            'Le regex contient quelque chose
            If regex_livesLeftGamma > 5 Then

                Label_LivesLeft.Text = "Lives left : 5+"

            ElseIf regex_livesLeftGamma = -1 Then

                Label_LivesLeft.Text = "Lives left : -1"
            Else

                Label_LivesLeft.Text = "Lives left : " + regex_livesLeftGamma

            End If
        End If

        'Button_Alpha.PerformClick()
        'Button_beta.PerformClick()
        'Button_Kappa.PerformClick()




    End Sub

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")
        Size = New Size(553, 622)

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

        Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 34)
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Alpha")
        Console.WriteLine(DataAlpha)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

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

    End Sub

    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")
        Size = New Size(553, 622)

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

        Dim DataBeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 48) ' Info GG Beta
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Beta")
        Console.WriteLine(DataBeta)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataBeta.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataBeta.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataBeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")
        Size = New Size(553, 622)

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

        Dim DataGamma = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 82) ' Info GG gamma
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Gamma")
        Console.WriteLine(DataGamma)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataGamma.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataGamma.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataGamma, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")
        Size = New Size(553, 622)

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

        Dim DataDelta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 128) ' Info GG Delta
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Delta")
        Console.WriteLine(DataDelta)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataDelta.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataDelta.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataDelta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=12&type=full")
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

        Dim DataChronos = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 21) ' Info GG chronos
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Chronos")
        Console.WriteLine(DataChronos)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataChronos.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataChronos.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataChronos, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=13&type=full")
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

        Dim DataHades = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 45) ' Info GG hades

        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Hades")
        Console.WriteLine(DataHades)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataHades.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataHades.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataHades, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=19&type=full")
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

        Dim DataKuiper = Utils.getKuiperGG(TextBox_GGinfoGGS.Text)
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Kuiper")
        Console.WriteLine(DataKuiper)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataKuiper.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataKuiper.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataKuiper, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=8&type=full")
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

        Dim DataLambda = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 45) ' Info GG lambda
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Lambda")
        Console.WriteLine(DataLambda)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataLambda.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataLambda.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataLambda, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=7&type=full")
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

        Dim DataKappa = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 120) ' Info GG kappa
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("kappa")
        Console.WriteLine(DataKappa)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataKappa.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataKappa.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataKappa, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=6&type=full")
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

        Dim DataZeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 111) ' Info GG zeta
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Zeta")
        Console.WriteLine(DataZeta)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataZeta.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataZeta.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataZeta, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub

    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=5&type=full")
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

        Dim DataEpsilon = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 99) ' Info GG epsilon
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("epsilon")
        Console.WriteLine(DataEpsilon)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

        If DataEpsilon.Contains("prepared1") Then

            Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf DataEpsilon.Contains("prepared0") Then

            Label_infoPartGG_InMap.Text = "On map : 0"

        End If

        Dim regex_livesLeft = Regex.Match(DataEpsilon, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        Console.WriteLine("DEBUG = " + regex_livesLeft)

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

    End Sub
#End Region

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_OpenLoginPanel.Click

        'button open Login Box'

        Form_Startup.Show()

    End Sub

#Region "Button Click GGS"
    Private Sub Button_Delta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Delta_GGS.Click

        'delta

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=4&delta=1&sample=1&multiplier=1")
        Button_delta.PerformClick()
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Epsilon_GGS_Click(sender As Object, e As EventArgs) Handles Button_Epsilon_GGS.Click

        ' epsilon

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=5&epsilon=1&sample=1&multiplier=1")
        Button_epsilon.PerformClick()
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Zeta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Zeta_GGS.Click

        'zeta

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=6&zeta=1&sample=1&multiplier=1")
        Button_zeta.PerformClick()
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Kappa_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kappa_GGS.Click

        ' kappa

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=7&kappa=1&sample=1&multiplier=1")
        Button_Kappa.PerformClick()
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Lambda_GGS_Click(sender As Object, e As EventArgs) Handles Button_Lambda_GGS.Click

        'lambda

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=8&lambda=1&sample=1&multiplier=1")
        Button_lambda.PerformClick()
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Kuiper_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kuiper_GGS.Click

        'kuiper

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=19&kuiper=1&sample=1&multiplier=1")
        Button_kuiper.PerformClick()
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Hades_GGS_Click(sender As Object, e As EventArgs) Handles Button_Hades_GGS.Click

        'hades

        Panel_infoPartGG2.Visible = False
        Panel_infoPartGG3.Visible = False
        Panel_infoPartGG_GG2.Visible = False
        Panel_infoPartGG_GG3.Visible = False

        Panel_GalaxyGates.Size = New Size(467, 606)

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=13&hades=1&sample=1&multiplier=1")
        Button_hades.PerformClick()
        Size = New Size(553, 622)
        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub
#End Region

#Region "Spin Click"
    Public numberToSpin As String = 0
    Public uridiumToKeep As String
    Private Sub Button_StartSpin_Click(sender As Object, e As EventArgs) Handles Button_StartSpin.Click

        If BackgroundWorkerAutospin = False Then
            BackgroundWorkerAutospin = True

            If BackgroundWorkerAutospin = True Then
                Dim data = ComboBox_autospin.Text
                Select Case data
                    Case "ABG"
                        MsgBox(data)
                    Case "Delta"
                        MsgBox(data)
                    Case "Epsilon"
                        MsgBox(data)
                    Case "Zeta"
                        MsgBox(data)
                    Case "Kappa"
                        MsgBox(data)
                    Case "Lambda"
                        MsgBox(data)
                    Case "Kuiper"
                        MsgBox(data)
                    Case "Hades"
                        MsgBox(data)

                    Case Else
                        BackgroundWorkerAutospin = False
                        MsgBox("Erreur, Aucune GG selectionnée")
                End Select
                If BackgroundWorkerAutospin = True Then
                    ClickGG("alpha", 250)
                End If
            End If

        Else
            MsgBox("Déjà lancé")
            ' Console.WriteLine("Already used")
        End If

    End Sub


    Private Sub Button_stopSpin_Click(sender As Object, e As EventArgs) Handles Button_stopSpin.Click

        If BackgroundWorkerAutospin = True Then
            BackgroundWorkerAutospin = False
        End If

    End Sub

    Private Async Sub ClickGG(portail As String, temps As Integer)
        Dim delay = Task.Delay(temps)


        If BackgroundWorkerAutospin = True Then
            'DoWork ici
            uridiumToKeep = Replace(TextBox_uridiumtokeepGGS.Text, ".", "")



            Await delay
            'TODO: Verification uri et prepare gates
            ClickGG(portail, temps)
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

#Region "Bordel"
        Dim html5 = WebBrowser_GGspinner.DocumentText.Clone
        TextBox_DebugGGS.Text = html5
        'Console.WriteLine(html5)

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


        'GGSpinner_EarnedType -- GGSpinner_EarnedID
        Dim materalizer As String

        If DataWinned = Nothing Then

            materalizer = 0

        Else

            materalizer = 1

        End If

        If DataWinned2 = Nothing Then

            materalizer = 0

        Else

            materalizer = 1

        End If



        If materalizer = 1 Then

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

            Else

                If DataWinned.Contains("part") AndAlso DataWinned2 = Nothing Then

                    DataWinned = "Multiplier assigned"

                ElseIf DataWinned = "part found" Then

                Else

                End If

            End If


            TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text + vbNewLine

        Else

            TextBox_WinGGS.Text = vbNewLine + "-----------------------" + vbNewLine +
                "Materializer locked" + vbNewLine +
                "come back later" + vbNewLine +
                "-----------------------" + vbNewLine

            'Button_ABG_GGS.Enabled = False
            'Button_Delta_GGS.Enabled = False
            'Button_Epsilon_GGS.Enabled = False
            'Button_Zeta_GGS.Enabled = False
            'Button_Kappa_GGS.Enabled = False
            'Button_Lambda_GGS.Enabled = False
            'Button_Hades_GGS.Enabled = False
            'Button_Kuiper_GGS.Enabled = False

        End If

        If materalizer = 1 Then

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

            ElseIf DataWinned.Contains("One part found") Then

                Label_Part_Earned.Text = Val(Label_Part_Earned.Text) + DataWinned3

            End If

        Else

        End If

        TextBox_uridiumGGS.Text = Utils.NumberToHumanReadable(money.Groups.Item(1).ToString, ".")
        TextBox_ExtraEnergy_GGS.Text = (DataSamples)

#End Region


        ' id<\/SPAN><SPAN class="m">="<\/SPAN><B>1<\/B.*?>([\s\S]*?)<\/DIV>

    End Sub

    Private Sub WebBrowser_GGInfo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_GGInfo.DocumentCompleted

        Dim CheckABG As String = 0
        Dim html107 = WebBrowser_GGInfo.DocumentText.Clone
        TextBox_GGinfoGGS.Text = html107

        Dim samples2 = Regex.Match(WebBrowser_GGInfo.Text, "samples.*?>([\s\S]*?)class=""t"">samples</SPAN>") ' energy restante
        Dim DataSamples2 = (samples2.Groups.Item(1).ToString)
        Console.WriteLine(DataSamples2)

        Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 34)
        Dim DataBeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 48)
        Dim DataGamma = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 82)
        Dim DataDelta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 128)
        Dim DataEpsilon = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 99)
        Dim DataZeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 111)
        Dim DataKappa = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 120)
        Dim DataLambda = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 45) ' ATTENTION
        Dim DataChronos = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 21)
        Dim DataHades = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 45) ' ATTENTION
        Dim DataHKuiper = Utils.getRegexGG(TextBox_GGinfoGGS.Text, 100)
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("---GGInfo_DocumentCompleted---")
        Console.WriteLine("Alpha")
        Console.WriteLine(DataAlpha)

        If Button_Alpha.Enabled = False Then

#Region "AlphaSpinStats"
            Dim regex_currentWave = Utils.getCurrentWave(DataAlpha)
            'On récupère avec une function la currentWave (utilisant un regexp)
            'Ensuite on le récup
            'DataAlpha = le string où on cherche
            Console.WriteLine("DEBUG = " + regex_currentWave)

            Dim regex_totalWave = Utils.getTotalWave(DataAlpha)
            Console.WriteLine("DEBUG = " + regex_totalWave)

            If Not regex_currentWave.Length = 0 AndAlso Not regex_totalWave.Length = 0 Then
                'Les 2 regex contiennent quelque chose, on défini

                Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave
            Else
                Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
            End If

            Dim regex_currentPart = Utils.getCurrentPart(DataAlpha)
            Console.WriteLine("DEBUG = " + regex_currentPart)


            If Not regex_currentPart.Length = 0 Then
                'Le regex contient quelque chose

                Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 40"
            Else
                Label_InfoPartGG.Text = "Part : " + "?" + " / 40"
            End If

#End Region
        ElseIf Button_beta.Enabled = False Then

#Region "BetaSpinStats"
            Dim regex_currentWave = Utils.getCurrentWave(DataBeta)
            Dim regex_totalWave = Utils.getTotalWave(DataBeta)

            If Not regex_currentWave.Length = 0 AndAlso Not regex_totalWave.Length = 0 Then
                Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

            Else
                Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "Unknown"
            End If

            Dim regex_currentPart = Utils.getCurrentPart(DataBeta)

            If Not regex_currentPart.Length = 0 Then


                Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 48"
            Else
                Label_InfoPartGG.Text = "Part : " + "?" + " / 48"
            End If

#End Region
        ElseIf Button_gamma.Enabled = False Then

#Region "GammaSpinStats"
            Dim regex_currentWave = Utils.getCurrentWave(DataGamma)
            Dim regex_totalWave = Utils.getTotalWave(DataGamma)

            If Not regex_currentWave.Length = 0 AndAlso Not regex_totalWave.Length = 0 Then
                Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

            Else
                Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
            End If

            Dim regex_currentPart = Utils.getCurrentPart(DataGamma)

            If Not regex_currentPart.Length = 0 Then


                Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 82"
            Else
                Label_InfoPartGG.Text = "Part : " + "?" + " / 82"
            End If

#End Region
        ElseIf ABG = "1" Then

#Region "AlphaBetaGammaSpinStats"

            Dim regex_currentWave = Utils.getCurrentWave(DataAlpha)
            Dim regex_totalWave = Utils.getTotalWave(DataAlpha)

            If Not regex_currentWave.Length = 0 AndAlso Not regex_totalWave.Length = 0 Then
                Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

            Else
                Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
            End If

            Dim Alpharegex_currentPart = Utils.getCurrentPart(DataDelta)

            If Not Alpharegex_currentPart.Length = 0 Then

                Label_InfoPartGG.Text = "Part : " + Alpharegex_currentPart + " / 34"
            Else
                Label_InfoPartGG.Text = "Part : " + "?" + " / 34"
            End If
            ABG = "2"

            If ABG = "2" Then

                Dim regex_currentWaveBeta = Utils.getCurrentWave(DataBeta)
                Dim regex_totalWavBetae = Utils.getTotalWave(DataBeta)

                If Not regex_currentWave.Length = 0 AndAlso Not regex_totalWave.Length = 0 Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                Dim Betaregex_currentPart = Utils.getCurrentPart(DataBeta)

                If Not Betaregex_currentPart.Length = 0 Then

                    Label_InfoPartGG.Text = "Part : " + Betaregex_currentPart + " / 48"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 48"
                End If
                ABG = "3"

            End If

            If ABG = "3" Then

                Dim regex_currentWaveGamma = Utils.getCurrentWave(DataGamma)
                Dim regex_totalWaveGamma = Utils.getTotalWave(DataGamma)

                If Not regex_currentWave.Length = 0 AndAlso Not regex_totalWave.Length = 0 Then
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

                Else
                    Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
                End If

                Dim Gammaregex_currentPart = Utils.getCurrentPart(DataGamma)

                If Not Gammaregex_currentPart.Length = 0 Then

                    Label_InfoPartGG.Text = "Part : " + Gammaregex_currentPart + " / 82"
                Else
                    Label_InfoPartGG.Text = "Part : " + "?" + " / 82"
                End If

            End If
            ABG = "0"
#End Region
        End If


        Console.WriteLine("---GGInfo_DocumentCompleted---")

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


    End Sub

    Private Sub CheckBox_SavedStatsEarned_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_SavedStatsEarned.CheckedChanged

        If CheckBox_SavedStatsEarned.Checked = True Then

            TextBox_uridiumEarned.DataBindings.Add(New Binding("0", TextBox_uridiumEarned, "Height"))
            TextBox_creditEarned.DataBindings.Add(New Binding("0", TextBox_creditEarned, "Height"))
            TextBox_honorEarned.DataBindings.Add(New Binding("0", TextBox_honorEarned, "Height"))
            TextBox_experienceEarned.DataBindings.Add(New Binding("0", TextBox_experienceEarned, "Height"))
            TextBox_RPEarned.DataBindings.Add(New Binding("0", TextBox_RPEarned, "Height"))

        Else

            TextBox_uridiumEarned.DataBindings.Clear()
            TextBox_creditEarned.DataBindings.Clear()
            TextBox_honorEarned.DataBindings.Clear()
            TextBox_experienceEarned.DataBindings.Clear()
            TextBox_RPEarned.DataBindings.Clear()

        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button_Refresh_Stats.Click

        Utils.checkStats = True
        BackPage_Form.Show()
        BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        BackPage_Form.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Panel_collector_Paint(sender As Object, e As PaintEventArgs) Handles Panel_collector.Paint

    End Sub
End Class