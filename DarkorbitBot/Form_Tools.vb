Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System
Imports System.Net
Imports System.IO

Public Class Form_Tools

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean
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
    Public ABG As Boolean

    Public BackgroundWorkerAutospin As Boolean

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

    Public Check_message As Integer
    Public Reloader As Integer
    Public Reader As Integer


    Public Sub Reload()

        If Reloader = 0 Then
            Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8", AppWinStyle.Hide)
            Reloader = 1
        End If


    End Sub

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

        TextBox_WinGGS.Visible = True
        TextBox_WinGGS.Size = New Size(258, 171)
        Panel_GalaxyGates.Size = New Size(467, 606)

        Calculator = 1
        textbox_stade.Text = "Checking URL Profil ... "

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

        Size = New Size(390, 358)
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

        General_button.Enabled = False
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Panel_general.Visible = True
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(390, 358)
        'CenterToScreen()

    End Sub

    Private Sub NPC_Button_Click(sender As Object, e As EventArgs) Handles NPC_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = False
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Panel_general.Visible = False
        Panel_Npc.Visible = True
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(608, 448)
        'CenterToScreen()

    End Sub

    Private Sub Collector_Button_Click(sender As Object, e As EventArgs) Handles LogUpdate_button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = False
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = True
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False


        Size = New Size(390, 358)
        ' CenterToScreen()

    End Sub

    Private Sub GalaxyGates_Button_Click(sender As Object, e As EventArgs) Handles GalaxyGates_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        If Utils.server = "" Then
            MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            General_button.Enabled = False
            Panel_general.Visible = True
            Size = New Size(390, 358)
        Else

            GalaxyGates_Button.Enabled = False
            Panel_GalaxyGates.Visible = True
            Panel_GalaxyGates.Size = New Size(669, 531)
            Size = New Size(746, 550)
            TextBox_uridiumGGS.Text = Utils.currentUridium

            WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

            ' https://fr1.darkorbit.com/flashinput/galaxyGates.php?userID=168449162&action=init&sid=b1b8a3c2e29ac06147fea27af6fac2bb

        End If

        '
        '  CenterToScreen()

    End Sub

    Private Sub Pirates_Button_Click(sender As Object, e As EventArgs) Handles Pirates_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = False
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = True
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(390, 358)
        ' CenterToScreen()

    End Sub

    Private Sub Stats_Button_Click(sender As Object, e As EventArgs) Handles Stats_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False


        If Utils.server = "" Then

            MessageBox.Show("You must first login To the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            General_button.Enabled = False
            Panel_general.Visible = True
            Size = New Size(390, 358)

        Else

            Stats_Button.Enabled = False
            Panel_stats.Visible = True
            Size = New Size(390, 358)

            '   Utils.checkStats = True
            ' BackPage_Form.Show()
            ' Reader = 1
            '  BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
            '   BackPage_Form.WindowState = FormWindowState.Minimized

            ' BackPage_Form.ShowIcon = False
            '  BackPage_Form.ShowInTaskbar = False

        End If

        '  CenterToScreen()

    End Sub

    Private Sub Rex_Button_Click(sender As Object, e As EventArgs) Handles Rex_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = False
        Divers_Button.Enabled = True

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = True
        Panel_divers.Visible = False

        Size = New Size(390, 358)
        ' CenterToScreen()

    End Sub

    Private Sub Divers_Button_Click(sender As Object, e As EventArgs) Handles Divers_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        LogUpdate_button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = True

        Size = New Size(390, 358)
        ' CenterToScreen()

    End Sub

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



    End Sub
#End Region

#Region "Galaxy Gates"
    ' full = toute la gg 
    ' last = derniere piece

#Region "GG Click Portail"

    Dim PartAlpha As String
    Dim PartBeta As String
    Dim PartGamma As String
    Public AlphaBetaGammaReupload As String
    Public AlphaBetaGammaReupload2 As String
    Public AlphaBetaGammaReupload3 As String
    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + Utils.userid + "&action=multiEnergy&sid=" + Utils.dosid + "&gateID=1&alpha=1&sample=1&multiplier=1")

    End Sub

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click

        ComboBox_autospin.Text = "ABG"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=1&type=full")

    End Sub

    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click

        ComboBox_autospin.Text = "ABG"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=2&type=full")

    End Sub

    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click

        ComboBox_autospin.Text = "ABG"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=3&type=full")

    End Sub

    Public Const BufferSize As Integer = 512 * 1024
    Public Const BufferReadSize As Integer = 1024

    Private Function GetImageFromURL(ByVal url As String) As Image

        Dim retVal As Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(url.Trim)

                Using request As System.Net.WebResponse = req.GetResponse
                    Using stream As System.IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(System.Drawing.Image.FromStream(stream))
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
                                          vbCrLf, ex.Message),
                                          "Exception Thrown",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning)

        End Try

        Return retVal

    End Function

    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click

        ComboBox_autospin.Text = "Delta"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        '   WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")

        'Using c As New Net.WebClient
        '    c.Headers.Add(“User-Agent”, “Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36 Edge/15.15063”)

        '    Dim b = c.DownloadData(“https://fr1.darkorbit.com/jumpgate.php?userID=168449162&gateID=4&type=full”)
        '    Using s As New MemoryStream(b)
        '        Dim i = Image.FromStream(s)
        '        PictureBox1.Image = i
        '    End Using
        'End Using

        'Dim url As String =
        '    "https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full"

        'With PictureBox1
        '    .SizeMode = PictureBoxSizeMode.Zoom

        '    Dim img As Image = GetImageFromURL(url)

        '    If img IsNot Nothing Then
        '        .Image = img
        '    End If
        'End With

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

    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click

        ComboBox_autospin.Text = "Hades"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=13&type=full")

    End Sub

    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click

        ComboBox_autospin.Text = "Kuiper"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=19&type=full")

    End Sub

    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click

        ComboBox_autospin.Text = "Lambda"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=8&type=full")

    End Sub

    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click

        ComboBox_autospin.Text = "Kappa"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=7&type=full")

    End Sub

    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click

        ComboBox_autospin.Text = "Zeta"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=6&type=full")

    End Sub

    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click

        ComboBox_autospin.Text = "Epsilon"
        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
        WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=5&type=full")

    End Sub
#End Region

    Private Sub Button_OpenLoginPanel_Click(sender As Object, e As EventArgs) Handles Button_OpenLoginPanel.Click

        'button open Login Box'

        Form_Startup.CheckedStats = 1
        Form_Startup.Show()

    End Sub

#Region "Button Click GGS"
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
#End Region

#Region "Spin Click"
    Public numberToSpin As String
    Public uridiumToKeep As String
    Private Sub Button_StartSpin_Click(sender As Object, e As EventArgs) Handles Button_StartSpin.Click

        If BackgroundWorkerAutospin = False Then

            If TextBox_spintimes_GGS.Text.Contains(".") Then
                BackgroundWorkerAutospin = True
                MessageBox.Show($"Error, you can't put a dot in the spin time.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf TextBox_spintimes_GGS.Text.Contains(" ") Then
                BackgroundWorkerAutospin = True
                MessageBox.Show($"Error, you can't put a space in the spin time.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf Val(TextBox_spintimes_GGS.Text) < 300 Then
                TextBox_spintimes_GGS.Text = 300
                BackgroundWorkerAutospin = False
                MessageBox.Show($"Error, Starting with 300ms by default, we don't recommand to go lower", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

                        Button_ABG_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case "Delta"
                        Button_Delta_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case "Epsilon"
                        Button_Epsilon_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case "Zeta"
                        Button_Zeta_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case "Kappa"
                        Button_Kappa_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case "Lambda"
                        Button_Lambda_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case "Kuiper"
                        Button_Kuiper_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case "Hades"
                        Button_Hades_GGS.Enabled = True
                        ClickGG(data, TextBox_spintimes_GGS.Text)

                    Case Else
                        BackgroundWorkerAutospin = False
                        MessageBox.Show("Erreur, Aucune GG selectionnée", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Button_stopSpin.PerformClick()
                        ComboBox_autospin.Text = "ABG"
                        ComboBox_autospin.Refresh()

                End Select
            Else BackgroundWorkerAutospin = False
            End If
        Else

            MessageBox.Show($"GG Snipper already started{vbNewLine}Stop it before starting it again", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button_StartSpin.Enabled = True

        End If
    End Sub

    Private Sub Button_stopSpin_Click(sender As Object, e As EventArgs) Handles Button_stopSpin.Click

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

        Button_ABG_GGS.Enabled = True
        Button_Delta_GGS.Enabled = True
        Button_Epsilon_GGS.Enabled = True
        Button_Zeta_GGS.Enabled = True
        Button_Kappa_GGS.Enabled = True
        Button_Lambda_GGS.Enabled = True
        Button_Kuiper_GGS.Enabled = True
        Button_Hades_GGS.Enabled = True

        Button_StartSpin.Enabled = True
        Button_stopSpin.Enabled = False
        ComboBox_autospin.Enabled = True

        If BackgroundWorkerAutospin = True Then
            BackgroundWorkerAutospin = False
            Console.WriteLine("Autospinner deactivated.")
        End If

    End Sub

    Private Async Sub ClickGG(portail As String, temps As Integer)

        Dim delay = Task.Delay(temps)
        If CheckBox_UseOnlyEE_GGS.Checked = True And TextBox_ExtraEnergy_GGS.Text = "0" Then
            BackgroundWorkerAutospin = False
            TextBox_WinGGS.Text = vbNewLine + $"(Galaxy Gates - {ComboBox_autospin.Text}) There is no more EE left..." + TextBox_WinGGS.Text
        End If
        If Val(TextBox_uridiumGGS.Text.Replace(".", "")) < Val(TextBox_uridiumtokeepGGS.Text.Replace(".", "")) And CheckBox_UseOnlyEE_GGS.Checked = False Then
            BackgroundWorkerAutospin = False
            TextBox_WinGGS.Text = vbNewLine + $"(Galaxy Gates - {ComboBox_autospin.Text}) Uridium is lowest than the Uridium to keep..." + TextBox_WinGGS.Text
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
                    If CheckBox_PrepareGatesIfBuiled.Checked Then
                        Button_PrepareGates.PerformClick()
                        TextBox_total_gates_builded.Text = Val(TextBox_total_gates_builded.Text) + 1
                        TextBox_WinGGS.Text = vbNewLine + $"(Galaxy Gates - {ComboBox_autospin.Text}) was put in your mothermap{vbNewLine}" + TextBox_WinGGS.Text
                        If CheckBox_BuildOneAndStop.Checked Then
                            BackgroundWorkerAutospin = False
                            TextBox_WinGGS.Text = $"The Galaxy Gates {ComboBox_autospin.Text} is 1/2 completed.{vbNewLine}" + TextBox_WinGGS.Text
                            MessageBox.Show($"The Galaxy Gates {ComboBox_autospin.Text} is 1/2 completed", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Button_stopSpin.PerformClick()
                            Button_PrepareGates.PerformClick()
                            Await Task.Delay(1500)
                            Button_StartSpin.PerformClick()
                        End If

                    Else
                        BackgroundWorkerAutospin = False
                        MessageBox.Show($"The Galaxy Gates {ComboBox_autospin.Text} is 2/2 completed{vbNewLine}Stopping the spinner.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    'Déjà une map en carte mère (prepared : 1)
                    If CheckBox_BuildOneAndStop.Checked Or CheckBox_PrepareGatesIfBuiled.Checked Then
                        BackgroundWorkerAutospin = False
                        If CheckBox_PrepareGatesIfBuiled.Checked Then
                            Button_PrepareGates.PerformClick()
                            TextBox_total_gates_builded.Text = Val(TextBox_total_gates_builded.Text) + 1
                        End If
                        TextBox_WinGGS.Text = vbNewLine + $"(Galaxy Gates - {ComboBox_autospin.Text}) was put in your mothermap" + TextBox_WinGGS.Text
                        MessageBox.Show($"The Galaxy Gates {ComboBox_autospin.Text} is 1/2 completed", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If ComboBox_autospin.Text = "ABG" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 1))
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 2))
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 3))

        ElseIf ComboBox_autospin.Text = "Delta" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 4))

        ElseIf ComboBox_autospin.Text = "Epsilon" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 5))

        ElseIf ComboBox_autospin.Text = "Zeta" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 6))

        ElseIf ComboBox_autospin.Text = "Kappa" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 7))

        ElseIf ComboBox_autospin.Text = "Lambda" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 8))

        ElseIf ComboBox_autospin.Text = "Hades" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 13))

        ElseIf ComboBox_autospin.Text = "Kuiper" Then
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 19))
        End If

    End Sub


    Private Sub WebBrowser_GGspinner_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_GGspinner.DocumentCompleted
#Region "WebBrowser_GGspinner"

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

        If DataWinned Is Nothing AndAlso DataWinned2 Is Nothing Then
            TextBox_WinGGS.Text = vbNewLine + "Materializer locked !"
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

                    TextBox_WinGGS.Text = vbNewLine + "Part(s) for Galaxy Gates " + (mode.Groups.Item(1).ToString) + " added" + TextBox_WinGGS.Text

                    Label_Part_Earned.Text = Val(Label_Part_Earned.Text) + DataWinned3
                    TextBox_total_spinned.Text = Val(TextBox_total_spinned.Text) + 1

                Else

                    TextBox_WinGGS.Text = vbNewLine + "DoubleSpin for Galaxy Gates " + (mode.Groups.Item(1).ToString) + " added" + TextBox_WinGGS.Text
                    Exit Sub
                End If

#Region "Delta"

                If ComboBox_autospin.Text = "Delta" Then

                    Button_delta.Enabled = False
                    Button_Delta_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=4&type=full")

                End If


#End Region

#Region "Epsilon"
                If ComboBox_autospin.Text = "Epsilon" Then

                    Button_epsilon.Enabled = False
                    Button_Epsilon_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=5&type=full")

                End If
#End Region

#Region "Zeta"
                If ComboBox_autospin.Text = "Zeta" Then

                    Button_zeta.Enabled = False
                    Button_Zeta_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=6&type=full")

                End If
#End Region

#Region "Kappa"
                If ComboBox_autospin.Text = "Kappa" Then

                    Button_Kappa.Enabled = False
                    Button_Kappa_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=7&type=full")

                End If
#End Region

#Region "Lambda"
                If ComboBox_autospin.Text = "Lambda" Then

                    Button_lambda.Enabled = False
                    Button_Lambda_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=8&type=full")

                End If
#End Region

#Region "Kuiper"
                If ComboBox_autospin.Text = "Kuiper" Then

                    Button_kuiper.Enabled = False
                    Button_Kuiper_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=19&type=full")

                End If

#End Region

#Region "Hades"

                If ComboBox_autospin.Text = "Hades" Then

                    Button_hades.Enabled = False
                    Button_Hades_GGS.Enabled = False
                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)
                    WebBrowser_galaxyGates.Navigate("https://" + Utils.server + ".darkorbit.com/jumpgate.php?userID=" + Utils.userid + "&gateID=13&type=full")

                End If

#End Region

#Region "ABG"

                If ComboBox_autospin.Text = "ABG" Then

                    Button_Alpha.Enabled = False
                    Button_beta.Enabled = False
                    Button_gamma.Enabled = False
                    Button_ABG_GGS.Enabled = False

                    WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

                End If



#End Region



            End If
        End If

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

        If ComboBox_autospin.Text = "Alpha" Then

            Dim DataAlpha = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "alpha")
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

            Dim DataKuiper = Utils.getRegexGG(TextBox_GGinfoGGS.Text, "kuiper")
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

        End If

    End Sub

    Private Sub PictureBox_close1_Click(sender As Object, e As EventArgs) Handles PictureBox_close1.Click

        CloseForm.ShowDialog(Me)

    End Sub

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

    Private Sub PictureBox_epinglerBot_Click(sender As Object, e As EventArgs) Handles PictureBox_epinglerBot.Click
        'Console.WriteLine("click !")
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

            textbox_stade.Text = "Checking URL Profil ... "

            WebBrowser_Synchronisation.Document.GetElementById("bgcdw_login_form_username").SetAttribute("value", Form_Startup.Textbox_Username.Text)
            WebBrowser_Synchronisation.Document.GetElementById("bgcdw_login_form_password").SetAttribute("value", Form_Startup.Textbox_Password.Text)
            For Each p As HtmlElement In WebBrowser_Synchronisation.Document.GetElementsByTagName("input")
                If p.GetAttribute("type") = "submit" Then
                    p.InvokeMember("click")
                End If
            Next

            textbox_stade.Text = "Verifying URL Profil ... "


        ElseIf WebBrowser_Synchronisation.Url.ToString.Contains("Start&prc=100") Then

            textbox_stade.Text = "URL : OK  ---  1/2"

            Check_message = 0

            Reload()

            ' Lance le jeu'
            Dim CheckRegex = Regex.Match(WebBrowser_Synchronisation.Url.ToString, "^http[s]?:[\/][\/]([^.]+)[.]darkorbit[.]com") '.exec(window.location.href);
            Utils.server = CheckRegex.Groups.Item(1).ToString

            Dim dosid_regex = Regex.Match(WebBrowser_Synchronisation.DocumentText, "dosid=([^&^.']+)")
            If dosid_regex.Success Then

                ' System.Text.UTF7Encoding :   18  23  :7A 61 2B 41 77 59 42 2F 51 4F 79 32 50 2F 63 2F 77 2D
                ' System.Text.UTF8Encoding :  12  24  :7A 61 CC 86 C7 BD CE B2 F1 8F B3 BF
                ' System.Text.UnicodeEncoding :  14  16  :7A 00 61 00 06 03 FD 01 B2 03 FF D8 FF DC
                ' System.Text.UnicodeEncoding :  14  16  :00 7A 00 61 03 06 01 FD 03 B2 D8 FF DC FF
                ' System.Text.UTF32Encoding :  24  32  :7A 00 00 00 61 00 00 00 06 03 00 00 FD 01 00 00 B2 03 00 00 FF FC 04 00

                Utils.dosid = dosid_regex.Value.Split("=")(1)
                Utils.userid = Replace(WebBrowser_Synchronisation.Document.GetElementById("header_top_id").InnerText, " ", "")
                TextBox_Get_id.Text = Replace(WebBrowser_Synchronisation.Document.GetElementById("header_top_id").InnerText, " ", "")
                TextBox_Get_Dosid.Text = Replace(Utils.dosid, " ", "")
                TextBox_Get_Server.Text = Replace(Utils.server, " ", "")
                Utils.currentHonnor = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_hnr")).InnerText
                Utils.currentUridium = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_uri")).InnerText
                Utils.currentCredits = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_credits")).InnerText
                Utils.currentXP = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_exp")).InnerText
                Utils.currentLevel = "" & (WebBrowser_Synchronisation.Document.GetElementById("header_top_level")).InnerText

                Dim Compagny = (WebBrowser_Synchronisation.Document.GetElementById("homeUserContent")).InnerText
                'Compagny = Compagny.replace(vbCr, "-").replace(vbLf, "|")
                'Clipboard.SetText(Compagny)
                Dim username As String
                Dim clan As String
                Dim grade As String
                Dim niveau As String
                Dim options As RegexOptions = RegexOptions.IgnoreCase _
                                Or RegexOptions.IgnorePatternWhitespace _
                                Or RegexOptions.Multiline Or RegexOptions.ExplicitCapture
                Dim compagny_regex = Regex.Matches(Compagny, ":.([\s\S]*?)\n", options)
                'Console.WriteLine(compagny_regex.Count)
                'For Each grp As Group In compagny_regex
                '    Console.WriteLine(grp.ToString)
                '    Console.WriteLine("--")
                'Next
                'Console.WriteLine("---------")
                'Console.WriteLine(compagny_regex.Item(0).ToString.Replace(" ", ""))

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
                'Console.WriteLine("Compagny info")
                'Console.WriteLine(username)
                'Console.WriteLine(clan)
                'Console.WriteLine(grade)
                'Console.WriteLine(niveau)


                Console.WriteLine("---------------------------------------")

                TextBox_username.Text = username
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


                Console.WriteLine(Compagny)
                Console.WriteLine("---------------------------------------")

                'If TextBox_username Then

                'End If

                TextBox_Get_Server.Text = Utils.server
                Utils.UpdateStats()

                textbox_stade.Text = "Server : OK  ---  2/2"


                Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
                Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

                If BackgroundWorker_Timer.IsBusy <> True Then
                    BackgroundWorker_Timer.RunWorkerAsync()
                End If

                WebBrowser_Synchronisation.Navigate("about:blank")
                textbox_stade.Text = "Done."

                If CheckBox_LaunchGameAuto.Checked = True Then

                    textbox_stade.Text = "Launching the game wait ... "

                    Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")
                    Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
                    Form_Game.Show()

                End If
            End If

            '   My.Computer.Audio.Play(My.Resources.connected, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub Button_revive_sid_Click(sender As Object, e As EventArgs) Handles Button_revive_sid.Click

        'Timer_SID.Stop()

        If BackgroundWorker_Timer.IsBusy = True Then
            BackgroundWorker_Timer.CancelAsync()
            SID_Minutes_dixaine = 0
            SID_Minutes = 0
            SID_Seconds_dixaine = 0
            SID_Seconds = 0
        End If

        TextBox_Get_Dosid.Text = ""
        TextBox_Get_id.Text = ""
        TextBox_Get_Server.Text = ""

        WebBrowser_Synchronisation.Navigate("https://darkorbit-22.bpsecure.com/")

        'TextBox_minutedouble_dixieme.Text = "0"
        'TextBox_minutedouble.Text = "0"
        'TextBox_secondsdouble2.Text = "0"
        'TextBox_secondsdouble.Text = "0"
        textbox_stade.Text = "Checking URL Profil ... "

    End Sub

    Private SID_Minutes_dixaine As Integer
    Private SID_Minutes As Integer
    Private SID_Seconds_dixaine As Integer
    Private SID_Seconds As Integer

    Private Sub BackgroundWorker_Timer_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Timer.DoWork

        SID_Seconds += 1
        If SID_Seconds = 10 Then
            SID_Seconds_dixaine += 1
            SID_Seconds = 0
        End If

        If SID_Seconds_dixaine = 6 Then
            SID_Seconds_dixaine = 0
            SID_Minutes += 1
        End If

        If SID_Minutes = 10 Then
            SID_Minutes = 0
            SID_Seconds_dixaine = 1
        End If

        If SID_Minutes_dixaine = 1 Then

            Invoke(New MethodInvoker(Sub()
                                         Try
                                             Button_revive_sid.PerformClick()
                                         Catch ex As Exception
                                             Console.WriteLine($"Method invoker SID minutes dixaine error - {ex.Message}")
                                         End Try
                                     End Sub))

            'TextBox_minutedouble_dixieme.Text = "0"
            'TextBox_minutedouble.Text = "0"
            'TextBox_secondsdouble2.Text = "0"
            'TextBox_secondsdouble.Text = "0"

            'TextBox_minutedouble_dixieme.Text = Val(TextBox_minutedouble_dixieme.Text) + 1

        End If

        Try
            Invoke(New MethodInvoker(Sub()
                                         Try
                                             TextBox_minutedouble_dixieme.Text = SID_Minutes_dixaine
                                             TextBox_minutedouble.Text = SID_Minutes
                                             TextBox_secondsdouble2.Text = SID_Seconds_dixaine
                                             TextBox_secondsdouble.Text = SID_Seconds

                                             TextBox_minutedouble_dixieme.Refresh()
                                             TextBox_minutedouble.Refresh()
                                             TextBox_secondsdouble2.Refresh()
                                             TextBox_secondsdouble.Refresh()
                                         Catch MethodInvoker As Exception
                                             Console.WriteLine($"Error on MethodInvoker {MethodInvoker.Message}")
                                         End Try
                                     End Sub))
        Catch invoke_error As Exception
            Console.WriteLine($"Error on Invoke_error {invoke_error.Message}")
        End Try
    End Sub

    Private Async Sub BackgroundWorker_Timer_RunWorkCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_Timer.RunWorkerCompleted
        Await Task.Delay(980)
        If BackgroundWorker_Timer.IsBusy = False Then
            BackgroundWorker_Timer.RunWorkerAsync()
        End If
    End Sub


    Public Sub PictureBox_LaunchBot_Click(sender As Object, e As EventArgs) Handles PictureBox_LaunchBot.Click
        If Form_Game.User_Stop_Bot = True Then
            PictureBox_LaunchBot.Image = My.Resources.img_pause
            Form_Game.User_Stop_Bot = False
            Form_Game.Button_Bot.PerformClick()
        Else
            PictureBox_LaunchBot.Image = My.Resources.img_suivant
            Form_Game.User_Stop_Bot = True
        End If


    End Sub

    Private Sub PictureBox_StopBot_Click(sender As Object, e As EventArgs)

        'Form_Game.User_Stop_Bot = True
        'PictureBox_LaunchBot.Visible = True
        'PictureBox_StopBot.Visible = False
        '

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

    Private Sub ComboBox_colormod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_colormod.SelectedIndexChanged

        If ComboBox_colormod.Text = "Dark&Red  ( By _Dev )" Then

            Button_OpenLoginPanel.FlatAppearance.BorderColor = Color.Red
            Button_LaunchGameRidevBrowser.FlatAppearance.BorderColor = Color.Red
            Button_revive_sid.FlatAppearance.BorderColor = Color.Red

            CheckBox_AutoLogin.ForeColor = Color.Red
            Label_choose_firm.ForeColor = Color.Red
            CheckBox_LaunchGameAuto.ForeColor = Color.Red
            CheckBox_colormod.ForeColor = Color.Red
            textbox_stade.ForeColor = Color.Red
            CheckBox_AutoUpdate.ForeColor = Color.Red
            TextBox_username.ForeColor = Color.Red
            TextBox_clan.ForeColor = Color.Red
            TextBox_Get_Server.ForeColor = Color.Red
            TextBox_ProfilSelected.ForeColor = Color.Red
            TextBox_minutedouble_dixieme.ForeColor = Color.Red
            TextBox_minutedouble.ForeColor = Color.Red
            TextBox_secondsdouble2.ForeColor = Color.Red
            TextBox_secondsdouble.ForeColor = Color.Red
            TextBox_Get_Dosid.ForeColor = Color.Red

            TextBox_username.BackColor = Color.FromArgb(30, 30, 30)
            PictureBox_grade.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_clan.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_Get_Server.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_ProfilSelected.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_minutedouble_dixieme.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_minutedouble.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_secondsdouble2.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_secondsdouble.BackColor = Color.FromArgb(30, 30, 30)
            Label_separator2.BackColor = Color.FromArgb(30, 30, 30)
            TextBox_Get_Dosid.BackColor = Color.FromArgb(30, 30, 30)
            Label_Dosid.BackColor = Color.FromArgb(30, 30, 30)
            Label_timeticks.BackColor = Color.FromArgb(30, 30, 30)
            Label_ProfilSelected.BackColor = Color.FromArgb(30, 30, 30)
            Label_ID.BackColor = Color.FromArgb(30, 30, 30)
            Button_LaunchGameRidevBrowser.BackColor = Color.FromArgb(30, 30, 30)
            Button_revive_sid.BackColor = Color.FromArgb(30, 30, 30)
            CheckBox_AutoLogin.BackColor = Color.FromArgb(30, 30, 30)
            Label_choose_firm.BackColor = Color.FromArgb(30, 30, 30)
            CheckBox_LaunchGameAuto.BackColor = Color.FromArgb(30, 30, 30)
            textbox_stade.BackColor = Color.FromArgb(30, 30, 30)
            Panel_Info.BackColor = Color.FromArgb(30, 30, 30)
            Panel_divers.BackColor = Color.FromArgb(30, 30, 30)
            CheckBox_AutoUpdate.BackColor = Color.FromArgb(30, 30, 30)
            Button_OpenLoginPanel.BackColor = Color.FromArgb(30, 30, 30)
            CheckBox_colormod.BackColor = Color.FromArgb(30, 30, 30)
            ComboBox_colormod.BackColor = Color.FromArgb(30, 30, 30)
            General_button.BackColor = Color.FromArgb(30, 30, 30)
            NPC_Button.BackColor = Color.FromArgb(30, 30, 30)
            Stats_Button.BackColor = Color.FromArgb(30, 30, 30)
            LogUpdate_button.BackColor = Color.FromArgb(30, 30, 30)
            GalaxyGates_Button.BackColor = Color.FromArgb(30, 30, 30)
            Pirates_Button.BackColor = Color.FromArgb(30, 30, 30)
            Divers_Button.BackColor = Color.FromArgb(30, 30, 30)
            Rex_Button.BackColor = Color.FromArgb(30, 30, 30)
            Button_Howuse.BackColor = Color.FromArgb(30, 30, 30)
            Panel_suppresor_controler.BackColor = Color.FromArgb(30, 30, 30)
            Panel_general.BackColor = Color.FromArgb(30, 30, 30)
            Panel_autospin.BackColor = Color.FromArgb(30, 30, 30)
            Panel_collector.BackColor = Color.FromArgb(30, 30, 30)
            Panel_Info.BackColor = Color.FromArgb(30, 30, 30)
            Panel_divers.BackColor = Color.FromArgb(30, 30, 30)
            Panel_GalaxyGates.BackColor = Color.FromArgb(30, 30, 30)
            ComboBox_firme.BackColor = Color.FromArgb(30, 30, 30)
            ComboBox_autologin.BackColor = Color.FromArgb(30, 30, 30)

            Me.BackColor = Color.FromArgb(30, 30, 30)
        End If

    End Sub

    Private Sub Button_Howuse_Click(sender As Object, e As EventArgs) Handles Button_Howuse.Click

        Size = New Size(390, 358)

    End Sub

    Private Sub Button_resetlog_Click(sender As Object, e As EventArgs) Handles Button_resetlog.Click

        TextBox_WinGGS.Text = ""

    End Sub
End Class