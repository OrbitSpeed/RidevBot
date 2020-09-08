Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports FireSharp
Imports FireSharp.Config

Public Class Form_Tools

    Public BOL_Redimensionnement As Boolean
    Public BeingDragged As Boolean
    Public ABG As Boolean
    Public BackgroundWorkerAutospin As Boolean

    Public MouseDownX As Integer
    Public MouseDownY As Integer
    Public Check_message As Integer
    Public Reloader As Integer
    Public Reader As Integer
    Public Const BufferSize As Integer = 512 * 1024
    Public Const BufferReadSize As Integer = 1024

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
    Public CheckedDeltaStats As String
    Public CheckedEpsilonStats As String
    Public CheckedZetaStats As String
    Public CheckedkappaStats As String
    Public CheckedLambdaStats As String
    Public CheckedkuiperStats As String
    Public CheckedHadesStats As String
    Public CheckedAlphaBetaGammaStats As String
    Public CheckedAlphaBetaGammaStats2 As String
    Public CheckedAlphaBetaGammaStats3 As String
    Public Opened As String = 1
    Public PartAlpha As String
    Public PartBeta As String
    Public PartGamma As String
    Public AlphaBetaGammaReupload As String
    Public AlphaBetaGammaReupload2 As String
    Public AlphaBetaGammaReupload3 As String
    Public numberToSpin As String
    Public uridiumToKeep As String
    Public Data As String
    Public infoPartGG As String
    Public infoinMapGG As String
    Public GalaxyGatesNumber As String
    Public exitGGS As String = 0
    Public Spintimes As String
    Public GalaxyGatesChecker As String = 0


    Private client As FirebaseClient

    Public fcon As New FirebaseConfig() With
        {
        .BasePath = "https://ridevbot-2cd86.firebaseio.com/",
        .AuthSecret = Utils.Firebase_Secret
        }

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
        Panel_license.Location = New Point(0, 66)
        Panel_autospin.Location = New Point(495, 68)
        Panel_palladium_palladium.Location = New Point(0, 66)
        panel_npc_npc.Location = New Point(0, 66)
        Panel_collectable.Location = New Point(0, 66)
        Panel_general.Location = New Point(0, 66)
        Panel_Npc.Location = New Point(0, 66)
        Panel_collector.Location = New Point(0, 66)
        Panel_GalaxyGates.Location = New Point(0, 66)
        Panel_Palladium.Location = New Point(0, 66)
        Panel_stats.Location = New Point(0, 66)
        Panel_rex.Location = New Point(0, 66)
        Panel_divers.Location = New Point(0, 66)

        TextBox_ProfilSelected.Text = Form_Startup.Textbox_Username.Text
        TextBox_license_username.Text = TextBox_ProfilSelected.Text

        Size = New Size(497, 412)
        CenterToScreen()
        Try
            client = New FirebaseClient(fcon)
            Utils.GetNistTime()
        Catch ex As Exception
            MessageBox.Show($"Erreur:{ex.ToString}")
        End Try


        If Form_Game.Visible = True Then
            Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Else
            Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        End If

        If My.Settings.License_check <> "Your license here" Then
            Button_license_verify_Click(Nothing, Nothing)
        End If

    End Sub ' Ouverture du Program ( form )

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
    End Sub ' fermeture de la form par appel ( form )

#Region "Button toolbar"
    Private Sub Button_palladium_toolbar_Click(sender As Object, e As EventArgs) Handles Button_palladium_toolbar.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub Button_npc_toolbar_Click(sender As Object, e As EventArgs) Handles Button_npc_toolbar.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub Button_collectable_toolbar_Click(sender As Object, e As EventArgs) Handles Button_collectable_toolbar.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub General_button_Click(sender As Object, e As EventArgs) Handles General_button.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub NPC_Button_Click(sender As Object, e As EventArgs) Handles NPC_Button.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 600)

    End Sub

    Private Sub Collector_Button_Click(sender As Object, e As EventArgs) Handles LogUpdate_button.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub GalaxyGates_Button_Click(sender As Object, e As EventArgs) Handles GalaxyGates_Button.Click

        If Utils.server = "" Then
            MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Panel_license.Visible = False
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

            Panel_suppresor_controler2.Size = New Size(168, 47)
            Button_suppresor_controler2.Text = "⬇"
            Panel_suppresor_controler.Size = New Size(168, 47)
            Button_suppresor_controler.Text = "⬇"
            Size = New Size(497, 412)
        Else

            Panel_license.Visible = False
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

            Panel_suppresor_controler2.Size = New Size(168, 47)
            Button_suppresor_controler2.Text = "⬇"
            Panel_suppresor_controler.Size = New Size(168, 47)
            Button_suppresor_controler.Text = "⬇"

            TextBox_uridiumGGS.Text = Utils.currentUridium
            ComboBox_autospin.Text = "ABG"
            WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)

        End If

    End Sub

    Private Sub Pirates_Button_Click(sender As Object, e As EventArgs) Handles Pirates_Button.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub Stats_Button_Click(sender As Object, e As EventArgs) Handles Stats_Button.Click

        If Utils.server = "" Then

            MessageBox.Show("You must first login To the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Panel_license.Visible = False
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

            Panel_suppresor_controler2.Size = New Size(168, 47)
            Button_suppresor_controler2.Text = "⬇"
            Panel_suppresor_controler.Size = New Size(168, 47)
            Button_suppresor_controler.Text = "⬇"
            Size = New Size(497, 412)

        Else

            Panel_license.Visible = False
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

            Panel_suppresor_controler2.Size = New Size(168, 47)
            Button_suppresor_controler2.Text = "⬇"
            Panel_suppresor_controler.Size = New Size(168, 47)
            Button_suppresor_controler.Text = "⬇"
            Size = New Size(497, 412)

        End If

    End Sub

    Private Sub Rex_Button_Click(sender As Object, e As EventArgs) Handles Rex_Button.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub Divers_Button_Click(sender As Object, e As EventArgs) Handles Divers_Button.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Size = New Size(497, 412)

    End Sub

    Private Sub Button_OpenLoginPanel_Click(sender As Object, e As EventArgs) Handles Button_OpenLoginPanel.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Form_Startup.CheckedStats = 1
        Form_Startup.Show()

    End Sub
    Private Sub Button_license_Click(sender As Object, e As EventArgs) Handles Button_license.Click

        Panel_license.Visible = True
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

        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Size = New Size(497, 412)

    End Sub
    Private Sub Button_How_use_Click(sender As Object, e As EventArgs) Handles Button_How_use.Click

        Panel_license.Visible = False
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

        Panel_suppresor_controler.Size = New Size(168, 47)
        Button_suppresor_controler.Text = "⬇"
        Panel_suppresor_controler2.Size = New Size(168, 47)
        Button_suppresor_controler2.Text = "⬇"
        Size = New Size(497, 412)

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



    End Sub ' Boutton pour Ouvrir le bot Browser

#Region "GG Click Portail"

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click

        ComboBox_autospin.Text = "Alpha"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")

    End Sub

    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click

        ComboBox_autospin.Text = "Beta"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")

    End Sub

    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click

        ComboBox_autospin.Text = "Gamma"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")

    End Sub

    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click

        ComboBox_autospin.Text = "Delta"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")

    End Sub

    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click

        ComboBox_autospin.Text = "Epsilon"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=5&type=full")

    End Sub

    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click

        ComboBox_autospin.Text = "Zeta"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=6&type=full")

    End Sub

    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click

        ComboBox_autospin.Text = "Kappa"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=7&type=full")

    End Sub

    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click

        ComboBox_autospin.Text = "Lambda"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=8&type=full")

    End Sub

    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click

        ComboBox_autospin.Text = "Hades"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=13&type=full")

    End Sub

    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click

        ComboBox_autospin.Text = "Kuiper"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=19&type=full")

    End Sub

    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click

        Dim DataChronos = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "chronos") ' Info GG chronos
        If DataChronos = Nothing Then
        Else

            Dim regex_currentWave = Utils.getCurrentWave(DataChronos)
            Dim regex_totalWave = Utils.getTotalWave(DataChronos)
            Dim regex_currentPart = Utils.getCurrentPart(DataChronos)
            Dim regex_totalPart = Utils.getTotalPart(DataChronos)
            Utils.setInfoPartGG_InMap(DataChronos)
            Utils.setLivesLeft(DataChronos)
            Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

            WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=12&type=full")

        End If

    End Sub

#End Region ' ici se trouve tout les Bouttons pour voir la GG Uniquement

#Region "Button Click GGS"

    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=1&alpha=1&sample=1&multiplier=1")

    End Sub
    Private Sub Button_alpha_GGS_Click(sender As Object, e As EventArgs) Handles Button_alpha_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=4&alpha=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_beta_GGS_Click(sender As Object, e As EventArgs) Handles Button_beta_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=4&beta=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Gamma_GGS_Click(sender As Object, e As EventArgs) Handles Button_Gamma_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=4&Gamma=1&sample=1&multiplier=1")

    End Sub
    Private Sub Button_Delta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Delta_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=4&delta=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Epsilon_GGS_Click(sender As Object, e As EventArgs) Handles Button_Epsilon_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=5&epsilon=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Zeta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Zeta_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=6&zeta=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Kappa_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kappa_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=7&kappa=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Lambda_GGS_Click(sender As Object, e As EventArgs) Handles Button_Lambda_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=8&lambda=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Kuiper_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kuiper_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=19&streuner=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Hades_GGS_Click(sender As Object, e As EventArgs) Handles Button_Hades_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=13&hades=1&sample=1&multiplier=1")

    End Sub

#End Region ' ici se trouve tout les Bouttons pour executer un spin que sa soit manuellement ou automatiquement sa ce passe ici 

    Private Sub Button_StartSpin_Click(sender As Object, e As EventArgs) Handles Button_StartSpin.Click

        Button_StartSpin.Enabled = False
        Button_stopSpin.Enabled = True

        If TextBox_spintimes_GGS.Text.Contains(".") Then

            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"You can't put a dot in the spin time." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Error :" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

        ElseIf TextBox_spintimes_GGS.Text.Contains(" ") Then

            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"You can't put a dot in the spin time." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Error :" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

        ElseIf Val(TextBox_spintimes_GGS.Text) < 200 Then

            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Starting with 300ms by Default, we don't recommand to go lower." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Error :" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

            TextBox_spintimes_GGS.Text = 300
        End If

        Data = ComboBox_autospin.Text
        exitGGS = 0
        Select Case Data
            Case "ABG"
                WebBrowser_galaxyGates.Navigate("about:blank")
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case "Delta"
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case "Epsilon"
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case "Zeta"
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case "Kappa"
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case "Lambda"
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case "Kuiper"
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case "Hades"
                ClickGG(Data, TextBox_spintimes_GGS.Text)

            Case Else
                Panel_Alpha_ABG_GGS.Visible = False
                Panel_Beta_ABG_GGS.Visible = False
                Panel_Gamma_ABG_GGS.Visible = False
                Button_alpha_GGS.Visible = True
                Button_beta_GGS.Visible = True
                Button_Gamma_GGS.Visible = True
                Button_stopSpin.PerformClick()
                ComboBox_autospin.Text = "ABG"
                ComboBox_autospin.Refresh()

        End Select


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

    Private Async Sub ClickGG(portail As String, temps As Integer)

Label_ClickGalaxyGates:

        infoinMapGG = Label_infoPartGG_InMap.Text.Replace("On map : ", "")
        infoPartGG = Label_InfoPartGG.Text.Replace("Part : ", "")


        If exitGGS = 1 Then
            Console.WriteLine($"exitGGS = 1")
            Exit Sub
        End If


        If CheckBox_UseOnlyEE_GGS.Checked = True And TextBox_ExtraEnergy_GGS.Text = "0" Then

            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"You no longer have / no Extra Energy." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

            Button_StartSpin.Enabled = True
            Button_stopSpin.Enabled = False
            ComboBox_autospin.Enabled = True
            Exit Sub

        ElseIf Val(TextBox_uridiumGGS.Text.Replace(".", "")) < Val(TextBox_uridiumtokeepGGS.Text.Replace(".", "")) And CheckBox_UseOnlyEE_GGS.Checked = False Then

            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"You no longer have / no Uridium." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + TextBox_WinGGS.Text
            TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

            Button_StartSpin.Enabled = True
            Button_stopSpin.Enabled = False
            ComboBox_autospin.Enabled = True
            Exit Sub
        End If



        If infoinMapGG.Split(" / ").First = infoinMapGG.Split(" / ").Last Then
            GalaxyGatesNumber = 2
        Else
            GalaxyGatesNumber = 1
        End If



        If infoPartGG.Split(" / ").First = infoPartGG.Split(" / ").Last Then
            If GalaxyGatesNumber = 1 Then
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"You Have 1 {ComboBox_autospin.Text} Gates completed" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Getting infos for ""Build One and Stop"" checkbox..." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Wait..." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                GalaxyGatesChecker = 1

                TextBox_total_gates_builded.Text = Val(TextBox_total_gates_builded.Text) + 1

                Button_PrepareGates.PerformClick()
                Await Task.Delay(5000)

            Else
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"You Have 2 {ComboBox_autospin.Text} Gates completed" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

                Button_StartSpin.Enabled = True
                Button_stopSpin.Enabled = False
                ComboBox_autospin.Enabled = True
                Exit Sub
            End If

            If CheckBox_BuildOneAndStop.Checked = True Then

                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"CheckBox Build One & Stop is true.{vbNewLine}" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Galaxy Gates Spinner stopped.{vbNewLine}" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

                Button_StartSpin.Enabled = True
                Button_stopSpin.Enabled = False
                ComboBox_autospin.Enabled = True

                Exit Sub

            Else

                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"CheckBox Build One & Stop is false." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Autospinner deactivated." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Wait..." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

                Await Task.Delay(1000)

                WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                WebBrowser_galaxyGates.Refresh()
                Await Task.Delay(1000)

            End If
        End If

        uridiumToKeep = Replace(TextBox_uridiumtokeepGGS.Text, ".", "")

        Select Case portail
            Case "ABG"
                Button_ABG_GGS.PerformClick()

            Case "Delta"
                Button_Delta_GGS.PerformClick()

            Case "Epsilon"
                Button_Epsilon_GGS.PerformClick()

            Case "Zeta"
                Button_Zeta_GGS.PerformClick()

            Case "Kappa"
                Button_Kappa_GGS.PerformClick()

            Case "Lambda"
                Button_Lambda_GGS.PerformClick()

            Case "Kuiper"
                Button_Kuiper_GGS.PerformClick()

            Case "Hades"
                Button_Hades_GGS.PerformClick()

            Case Else
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Select a valid Gate first." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"Autospinner deactivated." + TextBox_WinGGS.Text
                TextBox_WinGGS.Text = vbNewLine + $"" + TextBox_WinGGS.Text

        End Select

        Await Task.Delay(temps)

        GoTo Label_ClickGalaxyGates

    End Sub ' boucle click GG

    Private Sub TextBox_uridiumtokeepGGS_LostFocus(sender As Object, e As EventArgs) Handles TextBox_uridiumtokeepGGS.LostFocus
        TextBox_uridiumtokeepGGS.Text = Utils.NumberToHumanReadable(TextBox_uridiumtokeepGGS.Text, ".")
    End Sub ' pour afficher les energie lors de l'ouverture de GG Spinner

    Private Async Sub Button_PrepareGates_Click(sender As Object, e As EventArgs) Handles Button_PrepareGates.Click

        If GalaxyGatesChecker = 1 Then
            If ComboBox_autospin.Text = "ABG" Then

                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 1))
                Await Task.Delay("4000")

                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 2))
                Await Task.Delay("4000")

                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 3))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Alpha" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 1))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Beta" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 2))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Gamma" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 3))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Delta" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 4))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Epsilon" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 5))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Zeta" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 6))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Kappa" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 7))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Lambda" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 8))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Hades" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 13))
                Await Task.Delay("4000")

            ElseIf ComboBox_autospin.Text = "Kuiper" Then
                WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 19))
                Await Task.Delay("4000")
            End If

            GalaxyGatesChecker = 0
            WebBrowser_galaxyGates.Refresh()

            Button_stopSpin.PerformClick()
            Await Task.Delay("100")
            Button_StartSpin.PerformClick()

        End If


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
        TextBox_total_gates_builded.Text = 0

    End Sub ' ici on reset les stats du GGSpinner 

    Private Sub WebBrowser_GGspinner_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_GGspinner.DocumentCompleted

#Region "HTML5"
        Dim html5 = WebBrowser_GGspinner.DocumentText.Clone
        TextBox_DebugGGS.Text = html5

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

#End Region ' Ici on lie la Balise HTLM5 de WebBrowser_GGspinner 

        If GalaxyGatesChecker = 1 Then

            TextBox_WinGGS.Text = vbNewLine + "Preparing Gates..." + TextBox_WinGGS.Text
            GalaxyGatesChecker = 0

        ElseIf DataWinned Is Nothing AndAlso DataWinned2 Is Nothing Then


            TextBox_WinGGS.Text = vbNewLine + "Materializer locked !" + TextBox_WinGGS.Text

        Else

            If DataWinned.Contains("battery") AndAlso DataWinned2.Contains("2") Then
                DataWinned = "MCB-25"
                Label_MCB25_Earned.Text = Val(Label_MCB25_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("battery") AndAlso DataWinned2.Contains("3") Then
                DataWinned = "MCB-50"
                Label_MCB50_Earned.Text = Val(Label_MCB50_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("battery") AndAlso DataWinned2.Contains("4") Then
                DataWinned = "UCB-100"
                Label_UCB100_Earned.Text = Val(Label_UCB100_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("battery") AndAlso DataWinned2.Contains("5") Then
                DataWinned = "SAB-50"
                Label_SAB50_Earned.Text = Val(Label_SAB50_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("ore") Then
                DataWinned = "Xenomit"
                Label_Xenomit_Earned.Text = Val(Label_Xenomit_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("nanohull") Then
                DataWinned = "Nanohull"
                Label_Nanohull_Earned.Text = Val(Label_Nanohull_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("logfile") Then
                DataWinned = "Logfile"
                Label_Logfile_Earned.Text = Val(Label_Logfile_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("rocket") Then
                DataWinned = "PLT-2021"
                Label_PLT2021_Earned.Text = Val(Label_PLT2021_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("voucher") Then
                DataWinned = "Mine"
                Label_Mine_Earned.Text = Val(Label_Mine_Earned.Text) + DataWinned3
                TextBox_WinGGS.Text = vbNewLine + "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

            ElseIf DataWinned.Contains("part") Then
                DataWinned = "Part"

                Dim compare = "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text
                If compare.Contains("Part ()") Then

                    TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1
                    Label_Part_Earned.Text = Val(Label_Part_Earned.Text) + 1
                    TextBox_WinGGS.Text = vbNewLine + "Part(s) for Galaxy Gates " + (mode.Groups.Item(1).ToString) + " added " + TextBox_WinGGS.Text

                Else

                    TextBox_WinGGS.Text = vbNewLine + "DoubleSpin for Galaxy Gates " + (mode.Groups.Item(1).ToString) + " added " + TextBox_WinGGS.Text

                    Exit Sub
                End If

#Region "ABG"

                If ComboBox_autospin.Text = "ABG" Then

                    Button_Alpha.Enabled = False
                    Button_alpha_GGS.Enabled = False

                    Button_beta.Enabled = False
                    Button_beta_GGS.Enabled = False

                    Button_gamma.Enabled = False
                    Button_Gamma_GGS.Enabled = False

                    Button_ABG_GGS.Enabled = False

                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)

                    ' check piece savoir laquel a afficher
                    ' WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")

                End If



#End Region

#Region "Alpha"

                If ComboBox_autospin.Text = "Alpha" Then

                    Button_Alpha.Enabled = False
                    Button_alpha_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")

                End If


#End Region

#Region "Beta"

                If ComboBox_autospin.Text = "Beta" Then

                    Button_beta.Enabled = False
                    Button_beta_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")

                End If


#End Region

#Region "Gamma"

                If ComboBox_autospin.Text = "Gamma" Then

                    Button_gamma.Enabled = False
                    Button_Gamma_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")

                End If


#End Region

#Region "Delta"

                If ComboBox_autospin.Text = "Delta" Then

                    Button_delta.Enabled = False
                    Button_Delta_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")

                End If


#End Region

#Region "Epsilon"
                If ComboBox_autospin.Text = "Epsilon" Then

                    Button_epsilon.Enabled = False
                    Button_Epsilon_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=5&type=full")

                End If
#End Region

#Region "Zeta"
                If ComboBox_autospin.Text = "Zeta" Then

                    Button_zeta.Enabled = False
                    Button_Zeta_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=6&type=full")

                End If
#End Region

#Region "Kappa"
                If ComboBox_autospin.Text = "Kappa" Then

                    Button_Kappa.Enabled = False
                    Button_Kappa_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=7&type=full")

                End If
#End Region

#Region "Lambda"
                If ComboBox_autospin.Text = "Lambda" Then

                    Button_lambda.Enabled = False
                    Button_Lambda_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=8&type=full")

                End If
#End Region

#Region "Kuiper"
                If ComboBox_autospin.Text = "Kuiper" Then

                    Button_kuiper.Enabled = False
                    Button_Kuiper_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=19&type=full")

                End If

#End Region

#Region "Hades"

                If ComboBox_autospin.Text = "Hades" Then

                    Button_hades.Enabled = False
                    Button_Hades_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=13&type=full")

                End If

#End Region


            End If ' ERREUR ICI A COMPLETER JUSTE ABG !!!!

        End If

    End Sub ' GALAXY GATES SPINNER < HTML5 > 

    Private Sub WebBrowser_GGInfo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_GGInfo.DocumentCompleted

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

        If ComboBox_autospin.Text = "Alpha" Then
            Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "alpha") ' Info GG Alpha
            If DataAlpha = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataAlpha)
                Dim regex_totalWave = Utils.getTotalWave(DataAlpha)
                Dim regex_currentPart = Utils.getCurrentPart(DataAlpha)
                Dim regex_TotalPart = Utils.getTotalPart(DataAlpha)
                Utils.setInfoPartGG_InMap(DataAlpha)
                Utils.setLivesLeft(DataAlpha)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_TotalPart)

                Button_Alpha.Enabled = True
                Button_ABG_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Beta" Then
            Dim DataBeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "beta") ' Info GG Beta
            If DataBeta = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataBeta)
                Dim regex_totalWave = Utils.getTotalWave(DataBeta)
                Dim regex_currentPart = Utils.getCurrentPart(DataBeta)
                Dim regex_totalPart = Utils.getTotalPart(DataBeta)
                Utils.setInfoPartGG_InMap(DataBeta)
                Utils.setLivesLeft(DataBeta)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_beta.Enabled = True
                Button_ABG_GGS.Enabled = True


            End If

        ElseIf ComboBox_autospin.Text = "Gamma" Then
            Dim DataGamma = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "gamma") ' Info GG gamma
            If DataGamma = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataGamma)
                Dim regex_totalWave = Utils.getTotalWave(DataGamma)
                Dim regex_currentPart = Utils.getCurrentPart(DataGamma)
                Dim regex_totalPart = Utils.getTotalPart(DataGamma)
                Utils.setInfoPartGG_InMap(DataGamma)
                Utils.setLivesLeft(DataGamma)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_gamma.Enabled = True
                Button_ABG_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Delta" Then
            Dim DataDelta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "delta") ' Info GG Delta
            If DataDelta = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataDelta)
                Dim regex_totalWave = Utils.getTotalWave(DataDelta)
                Dim regex_currentPart = Utils.getCurrentPart(DataDelta)
                Dim regex_totalPart = Utils.getTotalPart(DataDelta)
                Utils.setInfoPartGG_InMap(DataDelta)
                Utils.setLivesLeft(DataDelta)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_delta.Enabled = True
                Button_Delta_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Epsilon" Then
            Dim DataEpsilon = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "epsilon") ' Info GG epsilon
            If DataEpsilon = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataEpsilon)
                Dim regex_totalWave = Utils.getTotalWave(DataEpsilon)
                Dim regex_currentPart = Utils.getCurrentPart(DataEpsilon)
                Dim regex_totalPart = Utils.getTotalPart(DataEpsilon)
                Utils.setInfoPartGG_InMap(DataEpsilon)
                Utils.setLivesLeft(DataEpsilon)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_epsilon.Enabled = True
                Button_Epsilon_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Zeta" Then
            Dim DataZeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "zeta") ' Info GG zeta
            If DataZeta = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataZeta)
                Dim regex_totalWave = Utils.getTotalWave(DataZeta)
                Dim regex_currentPart = Utils.getCurrentPart(DataZeta)
                Dim regex_totalPart = Utils.getTotalPart(DataZeta)
                Utils.setInfoPartGG_InMap(DataZeta)
                Utils.setLivesLeft(DataZeta)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_zeta.Enabled = True
                Button_Zeta_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Kappa" Then
            Dim DataKappa = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "kappa") ' Info GG kappa
            If DataKappa = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataKappa)
                Dim regex_totalWave = Utils.getTotalWave(DataKappa)
                Dim regex_currentPart = Utils.getCurrentPart(DataKappa)
                Dim regex_totalPart = Utils.getTotalPart(DataKappa)
                Utils.setInfoPartGG_InMap(DataKappa)
                Utils.setLivesLeft(DataKappa)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_Kappa.Enabled = True
                Button_Kappa_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Lambda" Then
            Dim DataLambda = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "lambda") ' Info GG lambda
            If DataLambda = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataLambda)
                Dim regex_totalWave = Utils.getTotalWave(DataLambda)
                Dim regex_currentPart = Utils.getCurrentPart(DataLambda)
                Dim regex_totalPart = Utils.getTotalPart(DataLambda)
                Utils.setInfoPartGG_InMap(DataLambda)
                Utils.setLivesLeft(DataLambda)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_lambda.Enabled = True
                Button_Lambda_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Hades" Then
            Dim DataHades = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "hades") ' Info GG hades
            If DataHades = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataHades)
                Dim regex_totalWave = Utils.getTotalWave(DataHades)
                Dim regex_currentPart = Utils.getCurrentPart(DataHades)
                Dim regex_totalPart = Utils.getTotalPart(DataHades)
                Utils.setInfoPartGG_InMap(DataHades)
                Utils.setLivesLeft(DataHades)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_hades.Enabled = True
                Button_Hades_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "Kuiper" Then
            Dim DataKuiper = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "kuiper") ' Info GG Kuiper
            If DataKuiper = Nothing Then
            Else

                Dim regex_currentWave = Utils.getCurrentWave(DataKuiper)
                Dim regex_totalWave = Utils.getTotalWave(DataKuiper)
                Dim regex_currentPart = Utils.getCurrentPart(DataKuiper)
                Dim regex_totalPart = Utils.getTotalPart(DataKuiper)
                Utils.setInfoPartGG_InMap(DataKuiper)
                Utils.setLivesLeft(DataKuiper)
                Utils.setWavePart(regex_currentWave, regex_totalWave, regex_currentPart, regex_totalPart)

                Button_kuiper.Enabled = True
                Button_Kuiper_GGS.Enabled = True

            End If

        ElseIf ComboBox_autospin.Text = "ABG" Then ' Info GG Alpha / beta / Gamma

            Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "alpha") ' Info GG Alpha
            If DataAlpha = Nothing Then
            Else
                Dim Alpha_currentPart = Utils.getCurrentPart(DataAlpha)
                Dim Alpha_totalPart = Utils.getTotalPart(DataAlpha)
                Label_Alpha_ABG_GGS_part.Text = $"Part : {Alpha_currentPart} / {Alpha_totalPart}"
            End If

            Dim DataBeta = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "beta") ' Info GG Beta 
            If DataBeta = Nothing Then
            Else
                Dim Beta_currentPart = Utils.getCurrentPart(DataBeta)
                Dim Beta_totalPart = Utils.getTotalPart(DataBeta)
                Label_Beta_ABG_GGS_part.Text = $"Part : {Beta_currentPart} / {Beta_totalPart}"
            End If

            Dim DataGamma = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "gamma") ' Info GG gamma
            If DataGamma = Nothing Then
            Else
                Dim Gamma_currentPart = Utils.getCurrentPart(DataGamma)
                Dim Gamma_totalPart = Utils.getTotalPart(DataGamma)
                Label_Gamma_ABG_GGS_part.Text = $"Part : {Gamma_currentPart} / {Gamma_totalPart}"
            End If

            Button_Alpha.Enabled = True
            Button_beta.Enabled = True
            Button_gamma.Enabled = True
            Button_ABG_GGS.Enabled = True



        End If

    End Sub  ' GALAXY GATES SPINNER < HTML107 > -- BUG ABG

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


    End Sub ' ici on reset les stats du panel STATS !

    Private Sub Button_Refresh_Stats_Click(sender As Object, e As EventArgs) Handles Button_Refresh_Stats.Click

        Reader = 1
        Utils.checkStats = True
        BackPage_Form.ShowIcon = False
        BackPage_Form.ShowInTaskbar = False
        BackPage_Form.Show()
        BackPage_Form.WindowState = FormWindowState.Minimized
        BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")

    End Sub ' ici on refresh les stats du panel STATS !

    Private Sub PictureBox_close1_Click(sender As Object, e As EventArgs) Handles PictureBox_close1.Click

        CloseForm.ShowDialog(Me)

    End Sub 'Close

    Private Sub PictureBox_epinglerBot_Click(sender As Object, e As EventArgs) Handles PictureBox_epinglerBot.Click

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
            Check_message = 1
            MessageBox.Show("Can't connect to your account, check your credentials.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            Check_message = 0
            Reload()

            ' Lance le jeu'
            Dim CheckRegex = Regex.Match(WebBrowser_Synchronisation.Url.ToString, "^http[s]?:[\/][\/]([^.]+)[.]darkorbit[.]com") '.exec(window.location.href);
            Utils.server = CheckRegex.Groups.Item(1).ToString

            Dim dosid_regex = Regex.Match(WebBrowser_Synchronisation.DocumentText, "dosid=([^&^.']+)")
            If dosid_regex.Success Then

                Utils.dosid = dosid_regex.Value.Split("=")(1)
                Utils.userid = Replace(WebBrowser_Synchronisation.Document.GetElementById("header_top_id").InnerText, " ", "")
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

                Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
                Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

                WebBrowser_Synchronisation.Navigate("about:blank")
                If CheckBox_LaunchGameAuto.Checked = True Then

                    Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")
                    Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
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
            PictureBox_LaunchBot.Image = My.Resources._087_pause
            Form_Game.User_Stop_Bot = False
            Form_Game.Button_Bot.PerformClick()
        Else
            PictureBox_LaunchBot.Image = My.Resources._080_play
            Form_Game.User_Stop_Bot = True
        End If


    End Sub ' Start Bot

    Private Sub Button_suppresor_controler_Click(sender As Object, e As EventArgs) Handles Button_suppresor_controler.Click

        If Button_suppresor_controler.Text = "⬇" Then
            Panel_suppresor_controler.Size = New Size(168, 350)
            Button_suppresor_controler.Text = "⬆"
            Panel_suppresor_controler2.Size = New Size(168, 47)
            Button_suppresor_controler2.Text = "⬇"

        ElseIf Button_suppresor_controler.Text = "⬆" Then
            Panel_suppresor_controler.Size = New Size(168, 47)
            Button_suppresor_controler.Text = "⬇"

        End If


    End Sub ' Supressor controler TOOLBAR General

    Private Sub Button_suppresor_controler2_Click(sender As Object, e As EventArgs) Handles Button_suppresor_controler2.Click

        If Button_suppresor_controler2.Text = "⬇" Then
            Panel_suppresor_controler2.Size = New Size(165, 217)
            Button_suppresor_controler2.Text = "⬆"
            Panel_suppresor_controler.Size = New Size(168, 47)
            Button_suppresor_controler.Text = "⬇"

        ElseIf Button_suppresor_controler2.Text = "⬆" Then
            Panel_suppresor_controler2.Size = New Size(168, 47)
            Button_suppresor_controler2.Text = "⬇"

        End If

    End Sub ' Supressor controler TOOLBAR Configuration

    Private Sub Button_suppresor_controler_GGS_Click(sender As Object, e As EventArgs) Handles Button_suppresor_controler_GGS.Click

        If Button_suppresor_controler_GGS.Text = "⬇" Then
            Button_suppresor_controler_GGS.Text = "⬆"
            Size = New Size(689, 705)


        ElseIf Button_suppresor_controler_GGS.Text = "⬆" Then
            Button_suppresor_controler_GGS.Text = "⬇"
            Size = New Size(497, 705)

        End If

    End Sub  ' Supressor controler INBAR GGS

    Private Sub ComboBox_autospin_TextChanged(sender As Object, e As EventArgs) Handles ComboBox_autospin.TextChanged

        If ComboBox_autospin.Text = "ABG" Then

            Panel_Alpha_ABG_GGS.Visible = True
            Panel_Beta_ABG_GGS.Visible = True
            Panel_Gamma_ABG_GGS.Visible = True
            Button_alpha_GGS.Visible = False
            Button_beta_GGS.Visible = False
            Button_Gamma_GGS.Visible = False

        Else

            Panel_Alpha_ABG_GGS.Visible = False
            Panel_Beta_ABG_GGS.Visible = False
            Panel_Gamma_ABG_GGS.Visible = False
            Button_alpha_GGS.Visible = True
            Button_beta_GGS.Visible = True
            Button_Gamma_GGS.Visible = True

        End If
    End Sub 'Permet de récuperer le nom du autospin et de définir si ABG

    Private Sub Button_license_verify_Click(sender As Object, e As EventArgs) Handles Button_license_verify.Click
        If String.IsNullOrWhiteSpace(TextBox_license_check.Text) Then
            MessageBox.Show("You didn't put a license")
            PictureBox_license_check.Image = My.Resources.error_icon
            PictureBox_license_check.Tag = False
            Exit Sub
        End If
        Dim user_key = TextBox_license_check.Text
        Dim res
        Try
            res = client.Get("Users/" + user_key)
        Catch ex As Exception
            MessageBox.Show("Can't get your license, check it correctly.")
            TextBox_license_check.Text = "Your license here"
            PictureBox_license_check.Image = My.Resources.error_icon
            PictureBox_license_check.Tag = False
            Exit Sub
        End Try
        If res.Body = "null" Then 'vérifie si le compte est null (introuvable)
            MessageBox.Show("Your account doesn't exist")
            TextBox_license_check.Text = "Your license here"
            PictureBox_license_check.Image = My.Resources.error_icon
            PictureBox_license_check.Tag = False
            Exit Sub
        End If

        Dim resUser = res.ResultAs(Of Utilisateur)

        Dim CurUser As New Utilisateur With
            {
            .NomUtilisateur = TextBox_license_username.Text,
            .PasswordUtilisateur = TextBox_license_password.Text,
            .LicenseEndTime = Utils.DateDistant,
            .LicenseActivated = False,
            .LicenseKey = user_key
            }

        If resUser.LicenseEndTime.CompareTo(Utils.DateDistant) = -1 Then
            MsgBox("t'as pas payé enculé")
            PictureBox_license_check.Image = My.Resources.error_icon
            PictureBox_license_check.Tag = False

            Exit Sub
        End If

        Dim licenseJours = Utils.calculateDiffDates(Utils.DateDistant, resUser.LicenseEndTime)
        MsgBox($"Welcome {resUser.NomUtilisateur}, your license will end in {licenseJours} days")
        PictureBox_license_check.Image = My.Resources.success_icon
        PictureBox_license_check.Tag = True
    End Sub

    Private Sub Button_reg_Click(sender As Object, e As EventArgs) Handles Button_reg.Click
        If PictureBox_license_check.Tag = True Then
            MessageBox.Show("Your license is valid, you don't need to register")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TextBox_license_username.Text) Then
            MessageBox.Show("You didn't put a correct username")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TextBox_license_password.Text) Then
            MessageBox.Show("You didn't put a correct password")
            Exit Sub
        End If
        Dim user_key = Utils.getSHA1Hash(TextBox_license_username.Text)

        Dim res = client.Get("Users/" + user_key)
        If res.Body <> "null" Then 'vérifie si le compte est null (introuvable)
            MessageBox.Show("Your account already exist")
            Exit Sub
        End If

        Dim CurUser As New Utilisateur With
            {
            .NomUtilisateur = TextBox_license_username.Text,
            .PasswordUtilisateur = TextBox_license_password.Text,
            .LicenseEndTime = Utils.DateDistant,
            .LicenseActivated = False,
            .LicenseKey = user_key
            }
        Dim setter = client.Set("Users/" + user_key, CurUser)
        MessageBox.Show("Your account is now created, in order to use your license, go to our discord or our website :)")
    End Sub
End Class