Imports System.ComponentModel
Imports System.Net
Imports System.Text.RegularExpressions
Imports FireSharp
Imports FireSharp.Config

Public Class Form_Tools

    Public Shared BOL_Redimensionnement As Boolean
    Public Shared BeingDragged As Boolean
    Public Shared ABG As Boolean
    Public Shared BackgroundWorkerAutospin As Boolean

    Public Shared MouseDownX As Integer
    Public Shared MouseDownY As Integer
    Public Shared Check_message As Integer
    Public Shared Reloader As Integer
    Public Shared Reader As Integer

    Public Shared Calculator As String
    Public Shared UridiumCalculator As String
    Public Shared CreditCalculator As String
    Public Shared HonorCalculator As String
    Public Shared ExpCalculator As String
    Public Shared RPCalculator As String
    Public Shared UridiumCalculator2 As String
    Public Shared CreditCalculator2 As String
    Public Shared HonorCalculator2 As String
    Public Shared ExpCalculator2 As String
    Public Shared RPCalculator2 As String
    Public Shared UridiumCalculator3 As String
    Public Shared CreditCalculator3 As String
    Public Shared HonorCalculator3 As String
    Public Shared ExpCalculator3 As String
    Public Shared RPCalculator3 As String
    Public Shared CheckedDeltaStats As String
    Public Shared CheckedEpsilonStats As String
    Public Shared CheckedZetaStats As String
    Public Shared CheckedkappaStats As String
    Public Shared CheckedLambdaStats As String
    Public Shared CheckedkuiperStats As String
    Public Shared CheckedHadesStats As String
    Public Shared CheckedAlphaBetaGammaStats As String
    Public Shared CheckedAlphaBetaGammaStats2 As String
    Public Shared CheckedAlphaBetaGammaStats3 As String
    Public Shared Opened As String = 1
    Public Shared PartAlpha As String
    Public Shared PartBeta As String
    Public Shared PartGamma As String
    Public Shared AlphaBetaGammaReupload As String
    Public Shared AlphaBetaGammaReupload2 As String
    Public Shared AlphaBetaGammaReupload3 As String
    Public Shared numberToSpin As String
    Public Shared uridiumToKeep As String
    Public Shared Data As String
    Public Shared infoPartGG As String
    Public Shared infoinMapGG As String
    Public Shared GalaxyGatesNumber As String
    Public Shared exitGGS As String = 0
    Public Shared Spintimes As String
    Public Shared WebClient_GET_All_elements As String
    Public Shared GalaxyGatesChecker As String = 0
    Public Shared WebClient_POST As New WebClient


    'Private client As FirebaseClient

    'Public fcon As New FirebaseConfig() With
    '    {
    '    .BasePath = "https://ridevbot-2cd86.firebaseio.com/",
    '    .AuthSecret = Utils.Firebase_Secret
    '    }

    Public Sub Reload()

        If Reloader = 0 Then
            Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8", AppWinStyle.Hide)
            Reloader = 1
        End If


    End Sub ' Sert a recharger le jeu

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

    Private Sub Title_form_MouseDown(sender As Object, e As MouseEventArgs) Handles Title_form.MouseDown

        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Title_form_MouseUp(sender As Object, e As MouseEventArgs) Handles Title_form.MouseUp

        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If

    End Sub

    Private Sub Title_form_MouseMove(sender As Object, e As MouseEventArgs) Handles Title_form.MouseMove

        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp

            tmp = Nothing
        End If

    End Sub


#End Region ' Sert a Déplacer la fenetre ( form )

    Private Sub Form_Tools_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Calculator = 1
        Panel_autospin.Location = New Point(499, 28)
        Panel_palladium_palladium.Location = New Point(0, 28)
        panel_npc_npc.Location = New Point(0, 28)
        Panel_collectable.Location = New Point(0, 28)
        General_General_BOX.Location = New Point(0, 28)
        Configuration_General_BOX.Location = New Point(0, 28)
        Log_General_BOX.Location = New Point(0, 28)
        Panel_GalaxyGates.Location = New Point(0, 28)
        panel_enchere.Location = New Point(0, 28)
        Panel_stats.Location = New Point(0, 28)
        Panel_rex.Location = New Point(0, 28)
        Divers_General_BOX.Location = New Point(0, 28)
        Bot_Settings_BOX.Location = New Point(0, 52)
        General_BOX.Location = New Point(0, 52)
        Stats_BOX.Location = New Point(0, 52)

        TextBox_ProfilSelected.Text = Form_Startup.Textbox_Username.Text

        Size = New Size(687, 436)
        CenterToScreen()
        'Try
        '    client = New FirebaseClient(fcon)
        '    Utils.GetNistTime()
        'Catch ex As Exception
        '    MessageBox.Show($"Erreur:{ex.ToString}")
        'End Try

        'If My.Settings.License_check <> "Your license here" Then
        '    Button_license_verify_Click(Nothing, Nothing)
        'End If

        If Form_Game.Visible = True Then
            Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Else
            Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        End If


    End Sub ' Ouverture du Program ( form )

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
    End Sub ' fermeture de la form par appel ( form )

#Region "Button toolbar"
    Private Sub Button_palladium_toolbar_Click(sender As Object, e As EventArgs) Handles button_palladium.Click


        Panel_Gates_task.Visible = False
        Panel_palladium_palladium.Visible = True
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_rex.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)
        Panel_autospin.Visible = False

        PictureBox_delta_reward_day.Visible = False
        PictureBox_epsilon_reward_day.Visible = False
        PictureBox_zeta_reward_day.Visible = False
        PictureBox_kappa_reward_day.Visible = False

    End Sub

    Private Sub Button_npc_toolbar_Click(sender As Object, e As EventArgs) Handles button_npc.Click

        Panel_Gates_task.Visible = False
        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = True
        Panel_collectable.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_rex.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)
        Panel_autospin.Visible = False

        PictureBox_delta_reward_day.Visible = False
        PictureBox_epsilon_reward_day.Visible = False
        PictureBox_zeta_reward_day.Visible = False
        PictureBox_kappa_reward_day.Visible = False

    End Sub

    Private Sub Button_collectable_toolbar_Click(sender As Object, e As EventArgs) Handles button_box.Click

        Panel_Gates_task.Visible = False
        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = True
        Panel_GalaxyGates.Visible = False
        Panel_rex.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)
        Panel_autospin.Visible = False

        PictureBox_delta_reward_day.Visible = False
        PictureBox_epsilon_reward_day.Visible = False
        PictureBox_zeta_reward_day.Visible = False
        PictureBox_kappa_reward_day.Visible = False

    End Sub

    Private Sub button_general_Click(sender As Object, e As EventArgs) Handles button_menu.Click

        For Each Con As Control In Me.Controls
            If Con.GetType Is GetType(Button) Then
                Console.WriteLine("mecontrols:" + Con.Text)
            End If
        Next

        For Each Con As Control In Panel_TBT2.Controls
            If Con.GetType Is GetType(Button) Then
                Console.WriteLine(Con.Text)
            End If
        Next

        General_General_BOX.Visible = True
        Configuration_General_BOX.Visible = False
        Log_General_BOX.Visible = False
        Divers_General_BOX.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub

    Private Sub button_configuration_Click(sender As Object, e As EventArgs) Handles button_configuration.Click

        General_General_BOX.Visible = False
        Configuration_General_BOX.Visible = True
        Log_General_BOX.Visible = False
        Divers_General_BOX.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub

    Private Sub button_log_Click(sender As Object, e As EventArgs) Handles button_log.Click

        General_General_BOX.Visible = False
        Configuration_General_BOX.Visible = False
        Log_General_BOX.Visible = True
        Divers_General_BOX.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub

    Private Sub GalaxyGates_Button_Click(sender As Object, e As EventArgs) Handles button_gates_spinner.Click

        If Utils.server = "" Then
            MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Button_BOX_general.PerformClick()

        Else

            GalaxyGates_module.Load()

        End If

    End Sub

    Private Sub Pirates_Button_Click(sender As Object, e As EventArgs) Handles button_bid.Click

        Panel_skylb.Visible = False
        Panel_store.Visible = False
        panel_enchere.Visible = True
        Panel_stats.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub

    Private Sub Stats_Button_Click(sender As Object, e As EventArgs) Handles button_stats.Click

        If Utils.server = "" Then

            MessageBox.Show("You must first login To the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Button_BOX_general.PerformClick()

        Else

            Panel_skylb.Visible = False
            Panel_store.Visible = False
            panel_enchere.Visible = False
            Panel_stats.Visible = True

            Size = New Size(687, 436)
            Bot_Settings_BOX.Size = New Size(687, 384)

        End If

    End Sub

    Private Sub Rex_Button_Click(sender As Object, e As EventArgs) Handles button_pet.Click

        Panel_Gates_task.Visible = False
        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_rex.Visible = True

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)
        Panel_autospin.Visible = False

        PictureBox_delta_reward_day.Visible = False
        PictureBox_epsilon_reward_day.Visible = False
        PictureBox_zeta_reward_day.Visible = False
        PictureBox_kappa_reward_day.Visible = False

    End Sub

    Private Sub button_divers_Click(sender As Object, e As EventArgs) Handles button_divers.Click

        General_General_BOX.Visible = False
        Configuration_General_BOX.Visible = False
        Log_General_BOX.Visible = False
        Divers_General_BOX.Visible = True

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub

    Private Sub button_changeAcc_Click(sender As Object, e As EventArgs) Handles button_changeAcc.Click

        Form_Startup.CheckedStats = 1
        Form_Startup.Show()
        button_menu.PerformClick()

    End Sub
    Private Sub Button_license_Click(sender As Object, e As EventArgs)

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_rex.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub
    Private Sub Button_How_use_Click(sender As Object, e As EventArgs) Handles button_How_use.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_rex.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub
#End Region ' Ici se trouve tout les bouttons de la toolbar

    Private Sub Button_LaunchGameRidevBrowser_Click(sender As Object, e As EventArgs) Handles Button_LaunchGameRidevBrowser.Click

        If Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser" Then
            Button_LaunchGameRidevBrowser.Cursor = Cursors.WaitCursor
            Button_LaunchGameRidevBrowser.Text = "Connecting..."
            Reload()
            Form_Game.Show()
            Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")

        ElseIf Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser" Then

            Button_LaunchGameRidevBrowser.Cursor = Cursors.WaitCursor
            Button_LaunchGameRidevBrowser.Text = "Connecting..."
            Reloader = 0
            Reload()
            Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")
            Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")

        Else Button_LaunchGameRidevBrowser.Text = "Already connecting..."
        End If

        If Stats_module.WebClient_GET_Ship_compagny_reg = Nothing Then
            Stats_module.Load()
        End If



    End Sub ' Boutton pour Ouvrir le bot Browser

#Region "GG Click Portail"

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click
        GalaxyGates_module.View("1", "alpha")
    End Sub
    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click
        GalaxyGates_module.View("2", "beta")
    End Sub
    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click
        GalaxyGates_module.View("3", "gamma")
    End Sub
    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click
        GalaxyGates_module.View("4", "Delta")
    End Sub
    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click
        GalaxyGates_module.View("5", "Epsilon")
    End Sub
    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click
        GalaxyGates_module.View("6", "Zeta")
    End Sub
    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click
        GalaxyGates_module.View("7", "Kappa")
    End Sub
    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click
        GalaxyGates_module.View("8", "Lambda")
    End Sub
    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click
        GalaxyGates_module.View("13", "Hades")
    End Sub
    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click
        GalaxyGates_module.View("19", "Kuiper")
    End Sub
    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click
        GalaxyGates_module.View("12", "Chronos")
    End Sub

#End Region ' ici se trouve tout les Bouttons pour voir la GG Uniquement

#Region "Button Click GGS"

    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_abg_GGS.Click
        GalaxyGates_module.View("1", "alpha")
        ComboBox_autospin.Text = "abg"
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)

    End Sub
    Private Sub Button_alpha_GGS_Click(sender As Object, e As EventArgs) Handles Button_alpha_GGS.Click
        GalaxyGates_module.View("1", "alpha")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)

    End Sub
    Private Sub Button_beta_GGS_Click(sender As Object, e As EventArgs) Handles Button_beta_GGS.Click
        GalaxyGates_module.View("2", "beta")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)

    End Sub
    Private Sub Button_Gamma_GGS_Click(sender As Object, e As EventArgs) Handles Button_gamma_GGS.Click
        GalaxyGates_module.View("3", "gamma")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)

    End Sub
    Private Sub Button_Delta_GGS_Click(sender As Object, e As EventArgs) Handles Button_delta_GGS.Click
        GalaxyGates_module.View("4", "Delta")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)
    End Sub
    Private Sub Button_Epsilon_GGS_Click(sender As Object, e As EventArgs) Handles Button_epsilon_GGS.Click
        GalaxyGates_module.View("5", "Epsilon")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)
    End Sub
    Private Sub Button_Zeta_GGS_Click(sender As Object, e As EventArgs) Handles Button_zeta_GGS.Click
        GalaxyGates_module.View("6", "Zeta")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)
    End Sub
    Private Sub Button_Kappa_GGS_Click(sender As Object, e As EventArgs) Handles Button_kappa_GGS.Click
        GalaxyGates_module.View("7", "Kappa")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)
    End Sub
    Private Sub Button_Lambda_GGS_Click(sender As Object, e As EventArgs) Handles Button_lambda_GGS.Click
        GalaxyGates_module.View("8", "Lambda")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)
    End Sub
    Private Async Sub Button_Kuiper_GGS_Click(sender As Object, e As EventArgs) Handles Button_kuiper_GGS.Click

        GalaxyGates_module.View("19", "Kuiper")
        ComboBox_autospin.Text = "Streuner"
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)
    End Sub
    Private Sub Button_Hades_GGS_Click(sender As Object, e As EventArgs) Handles Button_hades_GGS.Click
        GalaxyGates_module.View("13", "Hades")
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(0)
    End Sub
    Private Sub Button_PrepareGates_Click(sender As Object, e As EventArgs) Handles Button_PrepareGates.Click
        GalaxyGates_module.PrepareGates()

    End Sub ' button prepare Gates
    Public Sub Button_StartSpin_Click(sender As Object, e As EventArgs) Handles Button_StartSpin.Click
        GalaxyGates_module.Exit_Spin = 0
        GalaxyGates_module.Spin(1)

    End Sub ' Start Galaxy Gates Spinner 
    Public Sub Button_stopSpin_Click(sender As Object, e As EventArgs) Handles Button_stopSpin.Click
        GalaxyGates_module.Exit_Spin = 1

    End Sub ' Stop Galaxy Gates Spinner 

#End Region ' ici se trouve tout les Bouttons pour executer un spin que sa soit manuellement ou automatiquement sa ce passe ici 

    Private Sub TextBox_uridiumtokeepGGS_LostFocus(sender As Object, e As EventArgs) Handles TextBox_uridiumtokeepGGS.LostFocus
        TextBox_uridiumtokeepGGS.Text = Utils.NumberToHumanReadable(TextBox_uridiumtokeepGGS.Text, ".")

    End Sub ' pour afficher les energie lors de l'ouverture de GG Spinner

    Private Sub Button_resetlog_Click(sender As Object, e As EventArgs) Handles Button_resetlog.Click

        TextBox_WinGGS.Text = ""

    End Sub ' ici on reset les log du GGSpiner

    Private Sub Button_resettabspin_Click(sender As Object, e As EventArgs) Handles Button_resettabspin.Click

        Label_MCB25_Earned.Text = 0
        Label_MCB50_Earned.Text = 0
        Label_UCB100_Earned.Text = 0
        Label_SAB50_Earned.Text = 0
        Label_PLT2021_Earned.Text = 0
        Label_RepairCR_Earned.Text = 0
        Label_Xenomit_Earned.Text = 0
        Label_Nanohull_Earned.Text = 0
        Label_Mine_Earned.Text = 0
        Label_Logfile_Earned.Text = 0
        TextBox_total_spinned.Text = 0

    End Sub ' ici on reset les stats du GGSpinner 

    Private Sub Button_ResetStats_Click(sender As Object, e As EventArgs) Handles Button_ResetStats.Click

        Button_Refresh_Stats.Enabled = False
        Button_ResetStats.Enabled = False
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

        Stats_module.Load()


        'Reader = 1
        'BackPage_Form.ShowIcon = False
        'BackPage_Form.ShowInTaskbar = False

        'Utils.checkStats = True
        'BackPage_Form.Show()
        'BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        'BackPage_Form.WindowState = FormWindowState.Minimized


    End Sub ' ici on reset les stats du panel STATS !

    Private Sub Button_Refresh_Stats_Click(sender As Object, e As EventArgs) Handles Button_Refresh_Stats.Click

        Button_ResetStats.Enabled = False
        Button_Refresh_Stats.Enabled = False
        Stats_module.Load()

    End Sub ' ici on refresh les stats du panel STATS !

    Private Sub PictureBox_close1_Click(sender As Object, e As EventArgs) Handles PictureBox_close1.Click

        CloseForm.ShowDialog(Me)

    End Sub 'Close

    Private Sub PictureBox_epinglerBot_Click(sender As Object, e As EventArgs) Handles PictureBox_epinglerBot.Click

        Dim tagBoolean As Boolean = PictureBox_epinglerBot.Tag

        If tagBoolean Then
            PictureBox_epinglerBot.Image = My.Resources.lock_open
            PictureBox_epinglerBot.Tag = "0"
            Me.TopMost = False
        Else
            PictureBox_epinglerBot.Image = My.Resources.lock__2_
            PictureBox_epinglerBot.Tag = "1"
            Me.TopMost = True
        End If

    End Sub ' button epingler topbar

    Private Sub PictureBox_BackgroundBot_Click(sender As Object, e As EventArgs) Handles PictureBox_BackgroundBot.Click

        If Utils.userid = "" Then

            MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            BackPage_Form.ShowIcon = True
            BackPage_Form.ShowInTaskbar = True
            BackPage_Form.Show()
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

        End If


    End Sub ' button Home TopBar

    Private Sub WebBrowser_Synchronisation_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_Synchronisation.DocumentCompleted

        If WebBrowser_Synchronisation.Url.ToString.Contains("loginError=99") Then

            Form_Game.Visible = False
            Form_Startup.Visible = True
            WebBrowser_Synchronisation.Navigate("about:blank")
            MessageBox.Show("Can't connect to your account, check your credentials.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Check_message = 1
            Me.Close()

        ElseIf WebBrowser_Synchronisation.Url.ToString.Contains("authUser=291") Then

            Form_Game.Visible = False
            Form_Startup.Visible = True
            WebBrowser_Synchronisation.Navigate("about:blank")
            MessageBox.Show("Can't connect to your account, check your credentials.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Check_message = 1
            Me.Close()

        ElseIf WebBrowser_Synchronisation.Url.ToString.Contains("22.bpsecure.com") Then

            WebBrowser_Synchronisation.Document.GetElementById("bgcdw_login_form_username").SetAttribute("value", Form_Startup.Textbox_Username.Text)
            WebBrowser_Synchronisation.Document.GetElementById("bgcdw_login_form_password").SetAttribute("value", Form_Startup.Textbox_Password.Text)
            For Each p As HtmlElement In WebBrowser_Synchronisation.Document.GetElementsByTagName("input")
                If p.GetAttribute("type") = "submit" Then
                    p.InvokeMember("click")
                End If
            Next

        ElseIf WebBrowser_Synchronisation.Url.ToString.Contains("Start&prc=100") Then

            Label_ServerStatus.Text = "Online"
            Label_ServerStatus.ForeColor = Color.LimeGreen

            Check_message = 0
            Reload()

            ' Lance le jeu'
            Dim CheckRegex = Regex.Match(WebBrowser_Synchronisation.Url.ToString, "^http[s]?:[\/][\/]([^.]+)[.]darkorbit[.]com") '.exec(window.location.href);
            Utils.server = CheckRegex.Groups.Item(1).ToString

            Dim dosid_regex = Regex.Match(WebBrowser_Synchronisation.DocumentText, "dosid=([^&^.']+)")
            'Console.WriteLine(dosid_regex)
            If dosid_regex.Success Then

                Utils.dosid = dosid_regex.Value.Split("=")(1)
                Utils.userid = Replace(WebBrowser_Synchronisation.Document.GetElementById("header_top_id").InnerText, " ", "")
                Utils.userid = Utils.userid.Replace(vbCrLf, "")
                Console.WriteLine("----")
                Console.WriteLine(Utils.userid)
                Console.WriteLine("----")
                TextBox_Get_Dosid.Text = Replace(Utils.dosid, " ", "")
                Utils.server = Replace(Utils.server, " ", "")
                Utils.currentHonnor = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_hnr")).InnerText
                Utils.currentUridium = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_uri")).InnerText
                Utils.currentCredits = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_credits")).InnerText
                Utils.currentXP = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_exp")).InnerText
                Utils.currentLevel = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_level")).InnerText

                Dim Compagny = (WebBrowser_Synchronisation.Document.GetElementById("homeUserContent")).InnerText
                Dim username As String
                Dim clan As String
                Dim grade As String
                Dim niveau As String
                Dim options As RegexOptions = RegexOptions.IgnoreCase _
                                Or RegexOptions.IgnorePatternWhitespace _
                                Or RegexOptions.Multiline Or RegexOptions.ExplicitCapture
                Dim compagny_regex = Regex.Matches(Compagny, ":.([\s\S]*?)\n", options)

                If compagny_regex.Count = 4 Then
                    username = compagny_regex.Item(0).ToString.Replace(": ", "").Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "")
                    clan = compagny_regex.Item(1).ToString.Replace(": ", "").Replace(vbCr, "").Replace(vbLf, "")
                    grade = compagny_regex.Item(2).ToString.Replace(": ", "").Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "")
                    niveau = compagny_regex.Item(3).ToString.Replace(": ", "").Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "")
                Else
                    username = compagny_regex.Item(0).ToString.Replace(": ", "").Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "")
                    clan = "None"
                    grade = compagny_regex.Item(1).ToString.Replace(": ", "").Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "")
                    niveau = compagny_regex.Item(2).ToString.Replace(": ", "").Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "")
                End If

                Console.WriteLine("---------------------------------------")

                TextBox_username.Text = Utils.userid + " -   " + username + "   - " + Utils.server
                TextBox_clan.Text = clan

                Select Case grade
                    Case "Pilote 1ère classe"
                        PictureBox_grade.Image = My.Resources.rank_1

                    Case "Caporal"
                        PictureBox_grade.Image = My.Resources.rank_2

                    Case "Caporal-chef"
                        PictureBox_grade.Image = My.Resources.rank_3

                    Case "Sergent"
                        PictureBox_grade.Image = My.Resources.rank_4

                    Case "Sergent-chef"
                        PictureBox_grade.Image = My.Resources.rank_5

                    Case "Adjudant"
                        PictureBox_grade.Image = My.Resources.rank_6

                    Case "Adjudant-chef"
                        PictureBox_grade.Image = My.Resources.rank_7

                    Case "Major"
                        PictureBox_grade.Image = My.Resources.rank_8

                    Case "Sous-lieutenant"
                        PictureBox_grade.Image = My.Resources.rank_9

                    Case "Lieutenant"
                        PictureBox_grade.Image = My.Resources.rank_10

                    Case "Capitaine"
                        PictureBox_grade.Image = My.Resources.rank_11

                    Case "Capitaine d'escadron"
                        PictureBox_grade.Image = My.Resources.rank_12

                    Case "Commandant"
                        PictureBox_grade.Image = My.Resources.rank_13

                    Case "Commandant d'escadron"
                        PictureBox_grade.Image = My.Resources.rank_14

                    Case "Lieutenant-colonel"
                        PictureBox_grade.Image = My.Resources.rank_15

                    Case "Colonel"
                        PictureBox_grade.Image = My.Resources.rank_16

                    Case "Général de brigade"
                        PictureBox_grade.Image = My.Resources.rank_17

                    Case "Général de division"
                        PictureBox_grade.Image = My.Resources.rank_18

                    Case "Général de corps d'armée"
                        PictureBox_grade.Image = My.Resources.rank_19

                    Case "Général d'Armée"
                        PictureBox_grade.Image = My.Resources.rank_20

                    Case "Grade de Hors la loi"
                        PictureBox_grade.Image = My.Resources.rank_22

                    Case Else
                        If grade.Contains("Pilote") Then
                            PictureBox_grade.Image = My.Resources.rank_1
                        Else
                            PictureBox_grade.Image = My.Resources.rank_99
                        End If


                End Select

                Utils.UpdateStats()
                Stats_module.Load()

                Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
                Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

                WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information

                If CheckBox_LaunchGameAuto.Checked = True Then

                    Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")
                    Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
                    Form_Game.Show()

                End If
            End If

        End If



    End Sub ' !!!!! A VERIFIER ET A OPTIMISER !!!

    Public Sub Button_revive_sid_Click(sender As Object, e As EventArgs) Handles Button_revive_sid.Click

        TextBox_Get_Dosid.Text = 0
        TextBox_username.Text = 0
        TextBox_clan.Text = 0
        TextBox_Get_Dosid.Text = 0

        PictureBox_grade.Image = My.Resources.rank_99
        WebBrowser_Synchronisation.Navigate("https://darkorbit-22.bpsecure.com/")

    End Sub ' button revive Sid & reload

    Public Sub PictureBox_LaunchBot_Click(sender As Object, e As EventArgs) Handles PictureBox_LaunchBot.Click

        If Var.User_Stop_Bot = True Then
            PictureBox_LaunchBot.Image = My.Resources.cancel_presentation
            Var.User_Stop_Bot = False

            RUNNING.Start()

        Else
            PictureBox_LaunchBot.Image = My.Resources.play_circle_filled_white
            Var.User_Stop_Bot = True
        End If


    End Sub ' Start Bot

    Private Sub Button_license_verify_Click(sender As Object, e As EventArgs)
        'If String.IsNullOrWhiteSpace(TextBox_license_check.Text) Then
        '    MessageBox.Show("You didn't put a license")
        '    PictureBox_license_check.Image = My.Resources.error_icon
        '    PictureBox_license_check.Tag = False
        '    Exit Sub
        'End If
        'Dim user_key = TextBox_license_check.Text
        'Dim res
        'Try
        '    res = client.Get("Users/" + user_key)
        'Catch ex As Exception
        '    MessageBox.Show("Can't get your license, check it correctly.")
        '    TextBox_license_check.Text = "Your license here"
        '    PictureBox_license_check.Image = My.Resources.error_icon
        '    PictureBox_license_check.Tag = False
        '    Exit Sub
        'End Try
        'If res.Body = "null" Then 'vérifie si le compte est null (introuvable)
        '    MessageBox.Show("Your account doesn't exist")
        '    TextBox_license_check.Text = "Your license here"
        '    PictureBox_license_check.Image = My.Resources.error_icon
        '    PictureBox_license_check.Tag = False
        '    Exit Sub
        'End If

        'Dim resUser = res.ResultAs(Of Utilisateur)

        'Dim CurUser As New Utilisateur With
        '    {
        '    .NomUtilisateur = TextBox_license_username.Text,
        '    .PasswordUtilisateur = TextBox_license_password.Text,
        '    .LicenseEndTime = Utils.DateDistant,
        '    .LicenseActivated = False,
        '    .LicenseKey = user_key
        '    }

        'If resUser.LicenseEndTime.CompareTo(Utils.DateDistant) = -1 Then
        '    MsgBox("t'as pas payé enculé")
        '    PictureBox_license_check.Image = My.Resources.error_icon
        '    PictureBox_license_check.Tag = False

        '    Exit Sub
        'End If

        'Dim licenseJours = Utils.calculateDiffDates(Utils.DateDistant, resUser.LicenseEndTime)

        'If Not resUser.NomUtilisateur = TextBox_username.Text Then
        '    MessageBox.Show($"Your license is not for this account.{vbNewLine}Please buy an another one that is linked with this one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Form_Startup.Show()
        '    Close()
        'Else
        '    MessageBox.Show($"Welcome {resUser.NomUtilisateur}, your license will end in {licenseJours} days", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    PictureBox_license_check.Image = My.Resources.success_icon
        '    PictureBox_license_check.Tag = True
        'End If

    End Sub

    Private Sub Button_reg_Click(sender As Object, e As EventArgs)
        'If PictureBox_license_check.Tag = True Then
        '    MessageBox.Show("Your license is valid, you don't need to register")
        '    Exit Sub
        'End If
        'If String.IsNullOrWhiteSpace(TextBox_license_username.Text) Then
        '    MessageBox.Show("You didn't put a correct username")
        '    Exit Sub
        'End If
        'If String.IsNullOrWhiteSpace(TextBox_license_password.Text) Then
        '    MessageBox.Show("You didn't put a correct password")
        '    Exit Sub
        'End If
        'Dim user_key = Utils.getSHA1Hash(TextBox_license_username.Text)

        'Dim res = client.Get("Users/" + user_key)
        'If res.Body <> "null" Then 'vérifie si le compte est null (introuvable)
        '    MessageBox.Show("Your account already exist")
        '    Exit Sub
        'End If

        'Dim CurUser As New Utilisateur With
        '    {
        '    .NomUtilisateur = TextBox_license_username.Text,
        '    .PasswordUtilisateur = TextBox_license_password.Text,
        '    .LicenseEndTime = Utils.DateDistant,
        '    .LicenseActivated = False,
        '    .LicenseKey = user_key
        '    }
        'Dim setter = client.Set("Users/" + user_key, CurUser)
        'MessageBox.Show("Your account is now created, in order to use your license, go to our discord or our website :)")
    End Sub

    Private Sub WebBrowser_GGInfo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub WebBrowser_galaxyGates_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_galaxyGates.DocumentCompleted

        WebBrowser_galaxyGates.Document.BackColor = System.Drawing.Color.Transparent

    End Sub

    Private Sub Button_game_doodle_Click(sender As Object, e As EventArgs) Handles Button_game_doodle.Click

        If Button_game_doodle.Text = "Game" Then
            Button_game_doodle.Text = "Gates"
            WebBrowser_galaxyGates.Navigate("http://doodlejumppc.net/doodlejump.swf")

        Else Button_game_doodle.Text = "Gates"
            Button_game_doodle.Text = "Game"
            Button_Alpha.PerformClick()

        End If


    End Sub

    Private Sub Button_skylab_Click(sender As Object, e As EventArgs) Handles Button_skylab.Click

        Panel_Skylab.Visible = True
        Skylab_module.Load()

    End Sub

    Private Sub Button_update_hangar_Click(sender As Object, e As EventArgs) Handles Button_update_hangar.Click

        Palladium_module.Load()


    End Sub

    Private Sub CheckBox_Gates_mode_CheckedChanged(sender As Object, e As EventArgs)

        ' Gates_Redistribution_module_TableLayout_Gates.Load()

    End Sub

    Private Sub CheckedListBox_Gates_SelectedIndexChanged(sender As Object, e As EventArgs)

        '  Gates_Redistribution_module_TableLayout_Gates.Load()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim Get_Type_Hangar = (ComboBox_Base_Hangar.SelectedIndex + 1)
        Console.WriteLine(ComboBox_Base_Hangar.SelectedIndex + 1)
        Dim Execute_yes As String = 0

        WebClient_POST.Headers.Clear()
        WebClient_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils.dosid};") 'POST / GET socket Information
        Dim WebClient_Data = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        Dim WebClient_GET_All_elements = Regex.Match(WebClient_Data, "<div id=""header_main"">.*?([\s\S]*?)<div id=""hangar_slot_arrow""><\/div>").Groups.Item(1).ToString
        Dim _datatodo = Regex.Matches(WebClient_GET_All_elements, "href=""(.*)""".Replace("""", "").Replace("href=", ""))
        Dim reg As String = ComboBox_Base_Hangar.Text.Replace("Hangar", "").Replace(" ", "")
        Console.WriteLine(_datatodo.Item(reg))
        Dim Posting As String = _datatodo.Item(reg).ToString
        Dim WebClient_Data_posting = WebClient_POST.DownloadString("https://" + Utils.server + ".darkorbit.com/" + Posting)
        Console.WriteLine("https://" + Utils.server + ".darkorbit.com/" + Posting)

    End Sub

    Private Sub Button_BOX_general_Click(sender As Object, e As EventArgs) Handles Button_BOX_general.Click

        For Each Con As Control In Me.Controls
            If Con.GetType Is GetType(Button) Then
                Console.WriteLine(Con.Text)
            End If
        Next


        General_BOX.Visible = True
        Stats_BOX.Visible = False
        Bot_Settings_BOX.Visible = False
        button_menu.PerformClick()

    End Sub

    Private Sub Button_BOX_stats_Click(sender As Object, e As EventArgs) Handles Button_BOX_stats.Click


        General_BOX.Visible = False
        Stats_BOX.Visible = True
        Bot_Settings_BOX.Visible = False
        button_stats.PerformClick()

        PictureBox_delta_reward_day.Visible = False
        PictureBox_epsilon_reward_day.Visible = False
        PictureBox_zeta_reward_day.Visible = False
        PictureBox_kappa_reward_day.Visible = False

    End Sub

    Private Sub Button_BOX_botsettings_Click(sender As Object, e As EventArgs) Handles Button_BOX_botsettings.Click

        General_BOX.Visible = False
        Stats_BOX.Visible = False
        Bot_Settings_BOX.Visible = True
        button_pet.PerformClick()

        PictureBox_delta_reward_day.Visible = False
        PictureBox_epsilon_reward_day.Visible = False
        PictureBox_zeta_reward_day.Visible = False
        PictureBox_kappa_reward_day.Visible = False

    End Sub

    Private Sub button_gates_task_Click(sender As Object, e As EventArgs) Handles button_gates_task.Click

        Panel_Gates_task.Visible = True
        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_rex.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)
        Panel_autospin.Visible = False

        PictureBox_delta_reward_day.Visible = False
        PictureBox_epsilon_reward_day.Visible = False
        PictureBox_zeta_reward_day.Visible = False
        PictureBox_kappa_reward_day.Visible = False


    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged

        If CheckBox25.BackColor = Color.DarkRed Then
            CheckBox25.BackColor = Color.LimeGreen
        Else
            CheckBox25.BackColor = Color.DarkRed
        End If

    End Sub

    Private Sub Button_skyskylab_Click(sender As Object, e As EventArgs) Handles Button_skyskylab.Click

        Panel_skylb.Visible = True
        Panel_store.Visible = False
        panel_enchere.Visible = False
        Panel_stats.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub

    Private Sub Button_store_Click(sender As Object, e As EventArgs) Handles Button_store.Click

        Panel_skylb.Visible = False
        Panel_store.Visible = True
        panel_enchere.Visible = False
        Panel_stats.Visible = False

        Size = New Size(687, 436)
        Bot_Settings_BOX.Size = New Size(687, 384)

    End Sub

    Private Sub Panel_store_Paint(sender As Object, e As PaintEventArgs) Handles Panel_store.Paint

    End Sub
End Class