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
    Public Shared GalaxyGatesChecker As String = 0


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
        Panel_autospin.Location = New Point(495, 24)
        Panel_palladium_palladium.Location = New Point(0, 24)
        panel_npc_npc.Location = New Point(0, 24)
        Panel_collectable.Location = New Point(0, 24)
        Panel_general.Location = New Point(0, 24)
        Panel_Npc.Location = New Point(0, 24)
        Panel_collector.Location = New Point(0, 24)
        Panel_GalaxyGates.Location = New Point(0, 24)
        Panel_Palladium.Location = New Point(0, 24)
        Panel_stats.Location = New Point(0, 24)
        Panel_rex.Location = New Point(0, 24)
        Panel_divers.Location = New Point(0, 24)

        TextBox_ProfilSelected.Text = Form_Startup.Textbox_Username.Text

        Size = New Size(497, 412)
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
    Private Sub Button_palladium_toolbar_Click(sender As Object, e As EventArgs) Handles Button_palladium_toolbar.Click

        Panel_palladium_palladium.Visible = True
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub

    Private Sub Button_npc_toolbar_Click(sender As Object, e As EventArgs) Handles Button_npc_toolbar.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = True
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub

    Private Sub Button_collectable_toolbar_Click(sender As Object, e As EventArgs) Handles Button_collectable_toolbar.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = True
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub

    Private Sub General_button_Click(sender As Object, e As EventArgs) Handles General_button.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = True
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(400, 371)

    End Sub

    Private Sub NPC_Button_Click(sender As Object, e As EventArgs) Handles NPC_Button.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = True
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 600)

    End Sub

    Private Sub Collector_Button_Click(sender As Object, e As EventArgs) Handles LogUpdate_button.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = True
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub

    Private Sub GalaxyGates_Button_Click(sender As Object, e As EventArgs) Handles GalaxyGates_Button.Click

        If Utils_module.server = "" Then
            MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Panel_general.Visible = True
            Panel_palladium_palladium.Visible = False
            panel_npc_npc.Visible = False
            Panel_collectable.Visible = False
            Panel_Npc.Visible = False
            Panel_collector.Visible = False
            Panel_GalaxyGates.Visible = False
            Panel_Palladium.Visible = False
            Panel_stats.Visible = False
            Panel_rex.Visible = False
            Panel_divers.Visible = False

            Panel_suppresor_controler.Size = New Size(125, 24)
            Button_suppresor_controler.Text = "﹀"
            Size = New Size(497, 412)
        Else

            Panel_palladium_palladium.Visible = False
            panel_npc_npc.Visible = False
            Panel_collectable.Visible = False
            Panel_general.Visible = False
            Panel_Npc.Visible = False
            Panel_collector.Visible = False
            Panel_Palladium.Visible = False
            Panel_stats.Visible = False
            Panel_rex.Visible = False
            Panel_divers.Visible = False
            Panel_GalaxyGates.Visible = True

            If Button_suppresor_controler_GGS.Text = "⬇" Then
                Size = New Size(497, 705)

            ElseIf Button_suppresor_controler_GGS.Text = "⬆" Then
                Size = New Size(689, 705)
            End If


            Panel_suppresor_controler.Size = New Size(125, 24)
            Button_suppresor_controler.Text = "﹀"
            TextBox_uridiumGGS.Text = Utils_module.currentUridium

            GalaxyGates_module.Load()

        End If

    End Sub

    Private Sub Pirates_Button_Click(sender As Object, e As EventArgs) Handles Pirates_Button.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = True
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub

    Private Sub Stats_Button_Click(sender As Object, e As EventArgs) Handles Stats_Button.Click

        If Utils_module.server = "" Then

            MessageBox.Show("You must first login To the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Panel_general.Visible = True
            Panel_palladium_palladium.Visible = False
            panel_npc_npc.Visible = False
            Panel_collectable.Visible = False
            Panel_Npc.Visible = False
            Panel_collector.Visible = False
            Panel_GalaxyGates.Visible = False
            Panel_Palladium.Visible = False
            Panel_stats.Visible = False
            Panel_rex.Visible = False
            Panel_divers.Visible = False

            Panel_suppresor_controler.Size = New Size(125, 24)
            Button_suppresor_controler.Text = "﹀"
            Size = New Size(497, 412)

        Else

            Panel_palladium_palladium.Visible = False
            panel_npc_npc.Visible = False
            Panel_collectable.Visible = False
            Panel_general.Visible = False
            Panel_Npc.Visible = False
            Panel_collector.Visible = False
            Panel_GalaxyGates.Visible = False
            Panel_Palladium.Visible = False
            Panel_stats.Visible = True
            Panel_rex.Visible = False
            Panel_divers.Visible = False

            Panel_suppresor_controler.Size = New Size(125, 24)
            Button_suppresor_controler.Text = "﹀"
            Size = New Size(497, 412)

        End If

    End Sub

    Private Sub Rex_Button_Click(sender As Object, e As EventArgs) Handles Rex_Button.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = True
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub

    Private Sub Divers_Button_Click(sender As Object, e As EventArgs) Handles Divers_Button.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = True

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub

    Private Sub Button_OpenLoginPanel_Click(sender As Object, e As EventArgs) Handles Button_OpenLoginPanel.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Form_Startup.CheckedStats = 1
        Form_Startup.Show()

    End Sub
    Private Sub Button_license_Click(sender As Object, e As EventArgs) Handles Button_license.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub
    Private Sub Button_How_use_Click(sender As Object, e As EventArgs) Handles Button_How_use.Click

        Panel_palladium_palladium.Visible = False
        panel_npc_npc.Visible = False
        Panel_collectable.Visible = False
        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Panel_suppresor_controler.Size = New Size(125, 24)
        Button_suppresor_controler.Text = "﹀"
        Size = New Size(497, 412)

    End Sub
#End Region ' Ici se trouve tout les bouttons de la toolbar

    Private Sub Button_LaunchGameRidevBrowser_Click(sender As Object, e As EventArgs) Handles Button_LaunchGameRidevBrowser.Click

        If Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser" Then
            Button_LaunchGameRidevBrowser.Cursor = Cursors.WaitCursor
            Button_LaunchGameRidevBrowser.Text = "Connecting..."
            Reload()
            Form_Game.Show()
            Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")

        ElseIf Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser" Then

            Button_LaunchGameRidevBrowser.Cursor = Cursors.WaitCursor
            Button_LaunchGameRidevBrowser.Text = "Connecting..."
            Reloader = 0
            Reload()
            Utils_module.InternetSetCookie("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils_module.dosid & ";")
            Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")

        Else Button_LaunchGameRidevBrowser.Text = "Already connecting..."
        End If



    End Sub ' Boutton pour Ouvrir le bot Browser

#Region "GG Click Portail"

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click
        GalaxyGates_module.View(GalaxyGates_id:="1",
                         GalaxyGates_Name:="alpha")
    End Sub
    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click
        GalaxyGates_module.View(GalaxyGates_id:="2",
                         GalaxyGates_Name:="Beta")
    End Sub
    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click
        GalaxyGates_module.View(GalaxyGates_id:="3",
                         GalaxyGates_Name:="Gamma")
    End Sub
    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click
        GalaxyGates_module.View(GalaxyGates_id:="4",
                         GalaxyGates_Name:="Delta")
    End Sub
    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click
        GalaxyGates_module.View(GalaxyGates_id:="5",
                         GalaxyGates_Name:="Epsilon")
    End Sub
    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click
        GalaxyGates_module.View(GalaxyGates_id:="6",
                         GalaxyGates_Name:="Zeta")
    End Sub
    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click
        GalaxyGates_module.View(GalaxyGates_id:="7",
                         GalaxyGates_Name:="Kappa")
    End Sub
    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click
        GalaxyGates_module.View(GalaxyGates_id:="8",
                         GalaxyGates_Name:="Lambda")
    End Sub
    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click
        GalaxyGates_module.View(GalaxyGates_id:="13",
                         GalaxyGates_Name:="Hades")
    End Sub
    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click
        GalaxyGates_module.View(GalaxyGates_id:="19",
                         GalaxyGates_Name:="Kuiper")
    End Sub
    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click
        GalaxyGates_module.View(GalaxyGates_id:="12",
                         GalaxyGates_Name:="Chronos")
    End Sub

#End Region ' ici se trouve tout les Bouttons pour voir la GG Uniquement

#Region "Button Click GGS"

    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="1",
                         GalaxyGates_Name:="alpha",
                         Autorize_ABG:="1")
    End Sub
    Private Sub Button_alpha_GGS_Click(sender As Object, e As EventArgs) Handles Button_alpha_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="1",
                         GalaxyGates_Name:="alpha",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_beta_GGS_Click(sender As Object, e As EventArgs) Handles Button_beta_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="2",
                         GalaxyGates_Name:="beta",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Gamma_GGS_Click(sender As Object, e As EventArgs) Handles Button_Gamma_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="3",
                         GalaxyGates_Name:="gamma",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Delta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Delta_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="4",
                         GalaxyGates_Name:="delta",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Epsilon_GGS_Click(sender As Object, e As EventArgs) Handles Button_Epsilon_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="5",
                         GalaxyGates_Name:="epsilon",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Zeta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Zeta_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="6",
                         GalaxyGates_Name:="zeta",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Kappa_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kappa_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="7",
                         GalaxyGates_Name:="kappa",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Lambda_GGS_Click(sender As Object, e As EventArgs) Handles Button_Lambda_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="8",
                         GalaxyGates_Name:="lambda",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Kuiper_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kuiper_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="19",
                         GalaxyGates_Name:="kuiper",
                         Autorize_ABG:="0")
    End Sub
    Private Sub Button_Hades_GGS_Click(sender As Object, e As EventArgs) Handles Button_Hades_GGS.Click
        GalaxyGates_module.Spin(GalaxyGates_id:="13",
                         GalaxyGates_Name:="hades",
                         Autorize_ABG:="0")
    End Sub

#End Region ' ici se trouve tout les Bouttons pour executer un spin que sa soit manuellement ou automatiquement sa ce passe ici 

    Private Sub Button_StartSpin_Click(sender As Object, e As EventArgs) Handles Button_StartSpin.Click

        Button_StartSpin.Enabled = False
        Button_stopSpin.Enabled = True
        ComboBox_autospin.Enabled = False

        ClickGG()

    End Sub ' Start Galaxy Gates Spinner 

    Private Sub Button_stopSpin_Click(sender As Object, e As EventArgs) Handles Button_stopSpin.Click

        Console.WriteLine("Autospinner deactivated.")

        TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
        TextBox_WinGGS.Text = vbNewLine + $"Autospinner deactivated." + TextBox_WinGGS.Text
        TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + TextBox_WinGGS.Text
        TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

        exitGGS = 1
        Button_StartSpin.Enabled = True
        Button_stopSpin.Enabled = False
        ComboBox_autospin.Enabled = True

    End Sub ' Stop Galaxy Gates Spinner 

    Private Async Sub ClickGG()

        If exitGGS = 1 Then
            Console.WriteLine($"exitGGS = 1")
            Exit Sub
        End If

HOME_BASIC_RETURN_IF_VALID:

        If exitGGS = 1 Then
            Console.WriteLine($"exitGGS = 1")
            Exit Sub
        End If

        GalaxyGates_module.GalaxyGates_Name = ComboBox_autospin.Text
        If GalaxyGates_module.GalaxyGates_Name = Nothing Then

        ElseIf GalaxyGates_module.GalaxyGates_Name = "abg" Then
            GalaxyGates_module.Autorize_ABG = "1"
            GalaxyGates_module.GalaxyGates_id = "1"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "delta" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "4"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "epsilon" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "5"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "zeta" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "6"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "kappa" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "7"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "lambda" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "8"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "hades" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "13"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "kuiper" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "19"

        ElseIf GalaxyGates_module.GalaxyGates_Name = "chronos" Then
            GalaxyGates_module.Autorize_ABG = "0"
            GalaxyGates_module.GalaxyGates_id = "12"
        End If

        GalaxyGates_module.Spin(GalaxyGates_id:=GalaxyGates_module.GalaxyGates_id,
                         GalaxyGates_Name:=GalaxyGates_module.GalaxyGates_Name,
                         Autorize_ABG:=GalaxyGates_module.Autorize_ABG)

        Await Task.Delay(125)

        GoTo HOME_BASIC_RETURN_IF_VALID

    End Sub ' boucle click GG

    Private Sub TextBox_uridiumtokeepGGS_LostFocus(sender As Object, e As EventArgs) Handles TextBox_uridiumtokeepGGS.LostFocus
        TextBox_uridiumtokeepGGS.Text = Utils_module.NumberToHumanReadable(TextBox_uridiumtokeepGGS.Text, ".")
    End Sub ' pour afficher les energie lors de l'ouverture de GG Spinner

    Private Async Sub Button_PrepareGates_Click(sender As Object, e As EventArgs) Handles Button_PrepareGates.Click

        Dim GalaxyGates_id As Object = 0
        Dim PART_GG As Object = INFO_PART_GG_LABEL.Text


        Dim Result_PART_GG = Regex.Match(PART_GG, "Part :(.*)").Groups.Item(1).ToString
        Result_PART_GG = Result_PART_GG.Substring(1)
        If Result_PART_GG = "34 / 34" AndAlso ComboBox_autospin.Text.ToLower = "alpha" Then
            GalaxyGates_id = 1

        ElseIf Result_PART_GG = "48 / 48" AndAlso ComboBox_autospin.Text.ToLower = "beta" Then
            GalaxyGates_id = 2

        ElseIf Result_PART_GG = "82 / 82" AndAlso ComboBox_autospin.Text.ToLower = "gamma" Then
            GalaxyGates_id = 3

        ElseIf Result_PART_GG = "128 / 128" AndAlso ComboBox_autospin.Text.ToLower = "delta" Then
            GalaxyGates_id = 4

        ElseIf Result_PART_GG = "99 / 99" AndAlso ComboBox_autospin.Text.ToLower = "epsilon" Then
            GalaxyGates_id = 5

        ElseIf Result_PART_GG = "111 / 111" AndAlso ComboBox_autospin.Text.ToLower = "zeta" Then
            GalaxyGates_id = 6

        ElseIf Result_PART_GG = "120 / 120" AndAlso ComboBox_autospin.Text.ToLower = "kappa" Then
            GalaxyGates_id = 7

        ElseIf Result_PART_GG = "45 / 45" AndAlso ComboBox_autospin.Text.ToLower = "lambda" Then
            GalaxyGates_id = 8

        ElseIf Result_PART_GG = "45 / 45" AndAlso ComboBox_autospin.Text.ToLower = "hades" Then
            GalaxyGates_id = 13

        ElseIf Result_PART_GG = "100 / 100" AndAlso ComboBox_autospin.Text.ToLower = "kuiper" Then
            GalaxyGates_id = 19

        ElseIf Result_PART_GG = "21 / 21" AndAlso ComboBox_autospin.Text.ToLower = "chronos" Then
            GalaxyGates_id = 12

        End If

        Console.WriteLine(Result_PART_GG)
        Console.WriteLine(GalaxyGates_id)
        Console.WriteLine(ComboBox_autospin.Text.ToLower)
        Console.WriteLine("https://" + Utils_module.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils_module.userid + "&sid=" + Utils_module.dosid + "&action=setupGate&gateID=" & GalaxyGates_id)

        Dim Prepare_Gates_POST As New System.Net.WebClient
        Prepare_Gates_POST.Headers.Add(HttpRequestHeader.Cookie, $"dosid={Utils_module.dosid};")
        Dim Prepare_Gates_Data = Prepare_Gates_POST.DownloadString("https//" + Utils_module.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils_module.userid + "&sid=" + Utils_module.dosid + "&action=setupGate&gateID=" + GalaxyGates_id)

    End Sub ' button prepare Gates

    Private Sub Button_resetlog_Click(sender As Object, e As EventArgs) Handles Button_resetlog.Click

        TextBox_WinGGS.Text = ""

    End Sub ' ici on reset les log du GGSpiner

    Private Sub Button_resettabspin_Click(sender As Object, e As EventArgs) Handles Button_resettabspin.Click

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
        TextBox_total_spinned.Text = 0

    End Sub ' ici on reset les stats du GGSpinner 

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

        Utils_module.checkStats = True
        BackPage_Form.Show()
        BackPage_Form.WebBrowser1.Navigate("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        BackPage_Form.WindowState = FormWindowState.Minimized


    End Sub ' ici on reset les stats du panel STATS !

    Private Sub Button_Refresh_Stats_Click(sender As Object, e As EventArgs) Handles Button_Refresh_Stats.Click

        Reader = 1
        Utils_module.checkStats = True
        BackPage_Form.ShowIcon = False
        BackPage_Form.ShowInTaskbar = False
        BackPage_Form.Show()
        BackPage_Form.WindowState = FormWindowState.Minimized
        BackPage_Form.WebBrowser1.Navigate("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

    End Sub ' ici on refresh les stats du panel STATS !

    Private Sub PictureBox_close1_Click(sender As Object, e As EventArgs) Handles PictureBox_close1.Click

        CloseForm.ShowDialog(Me)

    End Sub 'Close

    Private Sub PictureBox_epinglerBot_Click(sender As Object, e As EventArgs) Handles PictureBox_epinglerBot.Click

        Dim tagBoolean As Boolean = PictureBox_epinglerBot.Tag

        If tagBoolean Then
            PictureBox_epinglerBot.Tag = "0"
            PictureBox_epinglerBot.Image = My.Resources.lock_open
            Me.TopMost = False
        Else
            PictureBox_epinglerBot.Tag = "1"
            PictureBox_epinglerBot.Image = My.Resources.lock__2_
            Me.TopMost = True
        End If

    End Sub ' button epingler topbar

    Private Sub PictureBox_BackgroundBot_Click(sender As Object, e As EventArgs) Handles PictureBox_BackgroundBot.Click

        If Utils_module.userid = "" Then

            MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            BackPage_Form.ShowIcon = True
            BackPage_Form.ShowInTaskbar = True
            BackPage_Form.Show()
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

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
            Utils_module.server = CheckRegex.Groups.Item(1).ToString

            Dim dosid_regex = Regex.Match(WebBrowser_Synchronisation.DocumentText, "dosid=([^&^.']+)")
            If dosid_regex.Success Then

                Utils_module.dosid = dosid_regex.Value.Split("=")(1)
                Utils_module.userid = Replace(WebBrowser_Synchronisation.Document.GetElementById("header_top_id").InnerText, " ", "")
                TextBox_Get_Dosid.Text = Replace(Utils_module.dosid, " ", "")
                Utils_module.server = Replace(Utils_module.server, " ", "")
                Utils_module.currentHonnor = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_hnr")).InnerText
                Utils_module.currentUridium = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_uri")).InnerText
                Utils_module.currentCredits = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_credits")).InnerText
                Utils_module.currentXP = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_exp")).InnerText
                Utils_module.currentLevel = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_level")).InnerText

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

                TextBox_username.Text = Utils_module.userid + " -   " + username + "   - " + Utils_module.server
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

                Utils_module.UpdateStats()

                Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
                Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

                WebBrowser_Synchronisation.Navigate("about:blank")
                If CheckBox_LaunchGameAuto.Checked = True Then

                    Utils_module.InternetSetCookie("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils_module.dosid & ";")
                    Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils_module.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
                    Form_Game.Show()

                End If
            End If

        End If

    End Sub ' !!!!! A VERIFIER ET A OPTIMISER !!!

    Private Sub Button_revive_sid_Click(sender As Object, e As EventArgs) Handles Button_revive_sid.Click

        TextBox_Get_Dosid.Text = ""
        TextBox_username.Text = ""
        TextBox_clan.Text = ""
        TextBox_Get_Dosid.Text = ""
        PictureBox_grade.Image = My.Resources.rank_99
        WebBrowser_Synchronisation.Navigate("https://darkorbit-22.bpsecure.com/")

    End Sub ' button revive Sid & reload

    Public Sub PictureBox_LaunchBot_Click(sender As Object, e As EventArgs) Handles PictureBox_LaunchBot.Click

        If Form_Game.User_Stop_Bot = True Then
            PictureBox_LaunchBot.Image = My.Resources.cancel_presentation
            Form_Game.User_Stop_Bot = False
            Form_Game.Button_Bot.PerformClick()
        Else
            PictureBox_LaunchBot.Image = My.Resources.play_circle_filled_white
            Form_Game.User_Stop_Bot = True
        End If


    End Sub ' Start Bot

    Private Sub Button_suppresor_controler_Click(sender As Object, e As EventArgs) Handles Button_suppresor_controler.Click

        If Button_suppresor_controler.Text = "﹀" Then
            Panel_suppresor_controler.Size = New Size(125, 407)
            Button_suppresor_controler.Text = "︿"

        ElseIf Button_suppresor_controler.Text = "︿" Then
            Panel_suppresor_controler.Size = New Size(125, 24)
            Button_suppresor_controler.Text = "﹀"

        End If


    End Sub ' Supressor controler TOOLBAR General

    Private Sub Button_suppresor_controler_GGS_Click(sender As Object, e As EventArgs) Handles Button_suppresor_controler_GGS.Click

        If Button_suppresor_controler_GGS.Text = "Open Gates Spinner" Then
            Button_suppresor_controler_GGS.Text = "Close Gates Spinner"
            Size = New Size(689, 705)


        ElseIf Button_suppresor_controler_GGS.Text = "Close Gates Spinner" Then
            Button_suppresor_controler_GGS.Text = "Open Gates Spinner"
            Size = New Size(497, 705)

        End If

    End Sub  ' Supressor controler INBAR GGS

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

    Private Sub Button_menu_Click(sender As Object, e As EventArgs) Handles Button_menu.Click

        Button_suppresor_controler.PerformClick()

    End Sub

    Private Sub WebBrowser_GGInfo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub WebBrowser_galaxyGates_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_galaxyGates.DocumentCompleted

        WebBrowser_galaxyGates.Document.BackColor = System.Drawing.Color.Transparent

    End Sub

    Private Sub Button_game_doodle_Click(sender As Object, e As EventArgs) Handles Button_game_doodle.Click

        If Button_game_doodle.Text = "Game" Then
            Button_game_doodle.Text = "Gates"

        Else Button_game_doodle.Text = "Gates"
            Button_game_doodle.Text = "Game"

        End If

        WebBrowser_galaxyGates.Navigate("http://doodlejumppc.net/doodlejump.swf")

    End Sub

    Private Sub Button_skylab_Click(sender As Object, e As EventArgs) Handles Button_skylab.Click

        Panel_Skylab.Visible = True
        Skylab_module.Load()

    End Sub
End Class