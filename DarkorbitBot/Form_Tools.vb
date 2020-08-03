Public Class Form_Tools

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

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

        Panel_general.Location = New Point(86, 18)
        Panel_Npc.Location = New Point(86, 18)
        Panel_collector.Location = New Point(86, 18)
        Panel_GalaxyGates.Location = New Point(86, 18)
        Panel_Palladium.Location = New Point(86, 18)
        Panel_stats.Location = New Point(86, 18)
        Panel_rex.Location = New Point(86, 18)
        Panel_divers.Location = New Point(86, 18)

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


    End Sub

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
        'CloseForm1.Show()
    End Sub

#Region "Button"
    Private Sub General_button_Click(sender As Object, e As EventArgs) Handles General_button.Click

        General_button.Enabled = False
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
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

        General_button.Enabled = True
        NPC_Button.Enabled = False
        Collector_Button.Enabled = True
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

    Private Sub Collector_Button_Click(sender As Object, e As EventArgs) Handles Collector_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = False
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
        Collector_Button.Enabled = True
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

        'If Utils.server = "" Then
        '    Dim result = MessageBox.Show("You must first login to the game before you can access the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    If result = DialogResult.OK Then
        '        General_button.Enabled = False
        '        Label_buttonGeneral.Visible = True
        '        Panel_general.Visible = True
        '        Size = New Size(390, 324)
        '    Else
        '        General_button.Enabled = False
        '        Label_buttonGeneral.Visible = True
        '        Panel_general.Visible = True
        '        Size = New Size(390, 324)
        '    End If
        'Else

        Label_galaxygates.Visible = True
            GalaxyGates_Button.Enabled = False
            Panel_GalaxyGates.Visible = True
        Size = New Size(553, 622)
        TextBox_uridiumGGS.Text = Utils.currentUridium

        ' End If

    End Sub

    Private Sub Pirates_Button_Click(sender As Object, e As EventArgs) Handles Pirates_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
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

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
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


            General_button.Enabled = False
            Label_buttonGeneral.Visible = True
            Panel_general.Visible = True
            Size = New Size(390, 324)

        Else

            Label_buttonStats.Visible = True
            Stats_Button.Enabled = False
            Panel_stats.Visible = True
            Size = New Size(390, 438)

            Utils.checkStats = True
            BackPage_Form.Show()
            BackPage_Form.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
            BackPage_Form.WindowState = FormWindowState.Minimized

        End If

    End Sub

    Private Sub Rex_Button_Click(sender As Object, e As EventArgs) Handles Rex_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
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

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
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

        If Utils.server = vbNull Then
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
    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=12&type=full")

    End Sub

    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=13&type=full")

    End Sub

    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=19&type=full")

    End Sub

    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=8&type=full")

    End Sub

    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=7&type=full")

    End Sub

    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=6&type=full")

    End Sub

    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=5&type=full")

    End Sub

    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=4&type=full")

    End Sub

    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=3&type=full")

    End Sub

    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=2&type=full")

    End Sub

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click

        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=1&type=full")


    End Sub

    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click

        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=1&alpha=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=1&type=full")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=2&type=full")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=3&type=full")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'button open Login Box'

        Form_Startup.Show()

    End Sub

    Private Sub Button_epsion_GGS_Click(sender As Object, e As EventArgs) Handles Button_epsion_GGS.Click

        'delta
        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=5&delta=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=5&type=full")

    End Sub

    Private Sub Button_Epsilon_GGS_Click(sender As Object, e As EventArgs) Handles Button_Epsilon_GGS.Click

        ' espilon
        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=4&epsilon=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=4&type=full")

    End Sub

    Private Sub Button_Zeta_GGS_Click(sender As Object, e As EventArgs) Handles Button_Zeta_GGS.Click

        'zeta
        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=6&zeta=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=6&type=full")

    End Sub

    Private Sub Button_Kappa_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kappa_GGS.Click

        ' kappa
        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=7&kappa=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=7&type=full")

    End Sub

    Private Sub Button_Lambda_GGS_Click(sender As Object, e As EventArgs) Handles Button_Lambda_GGS.Click

        'lambda
        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=8&lambda=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=8&type=full")

    End Sub

    Private Sub Button_Kuiper_GGS_Click(sender As Object, e As EventArgs) Handles Button_Kuiper_GGS.Click

        'kuiper
        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=19&kuiper=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=19&type=full")

    End Sub

    Private Sub Button_Hades_GGS_Click(sender As Object, e As EventArgs) Handles Button_Hades_GGS.Click

        'hades
        WebBrowser_GGspinner.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=multiEnergy&sid=" + TextBox_Get_Dosid.Text + "&gateID=13&hades=1&sample=1&multiplier=1")
        WebBrowser_galaxyGates.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/jumpgate.php?userID=" + TextBox_Get_id.Text + "&gateID=13&type=full")

    End Sub
#End Region


#Region "CheckBox Spin"
    Private Sub CheckBox_Spin1_Click(sender As Object, e As EventArgs) Handles CheckBox_Spin1.Click
        CheckBox_Spin1.Checked = True
        CheckBox_spin5.Checked = False
        CheckBox_spin10.Checked = False
        CheckBox_spin100.Checked = False

        CheckBox_Spin1.CheckState = CheckState.Checked
        CheckBox_spin5.CheckState = CheckState.Unchecked
        CheckBox_spin10.CheckState = CheckState.Unchecked
        CheckBox_spin100.CheckState = CheckState.Unchecked
    End Sub

    Private Sub CheckBox_spin5_Click(sender As Object, e As EventArgs) Handles CheckBox_spin5.Click
        CheckBox_Spin1.Checked = False
        CheckBox_spin5.Checked = True
        CheckBox_spin10.Checked = False
        CheckBox_spin100.Checked = False

        CheckBox_Spin1.CheckState = CheckState.Unchecked
        CheckBox_spin5.CheckState = CheckState.Checked
        CheckBox_spin10.CheckState = CheckState.Unchecked
        CheckBox_spin100.CheckState = CheckState.Unchecked
    End Sub

    Private Sub CheckBox_spin10_Click(sender As Object, e As EventArgs) Handles CheckBox_spin10.Click
        CheckBox_Spin1.Checked = False
        CheckBox_spin5.Checked = False
        CheckBox_spin10.Checked = True
        CheckBox_spin100.Checked = False

        CheckBox_Spin1.CheckState = CheckState.Unchecked
        CheckBox_spin5.CheckState = CheckState.Unchecked
        CheckBox_spin10.CheckState = CheckState.Checked
        CheckBox_spin100.CheckState = CheckState.Unchecked
    End Sub

    Private Sub CheckBox_spin100_Click(sender As Object, e As EventArgs) Handles CheckBox_spin100.Click
        CheckBox_Spin1.Checked = False
        CheckBox_spin5.Checked = False
        CheckBox_spin10.Checked = False
        CheckBox_spin100.Checked = True

        CheckBox_Spin1.CheckState = CheckState.Unchecked
        CheckBox_spin5.CheckState = CheckState.Unchecked
        CheckBox_spin10.CheckState = CheckState.Unchecked
        CheckBox_spin100.CheckState = CheckState.Checked
    End Sub
#End Region

#Region "Spin Click"
    Public numberToSpin As String = 0
    Private Sub Button_StartSpin_Click(sender As Object, e As EventArgs) Handles Button_StartSpin.Click


        If BackgroundWorkerAutospin = False Then
            BackgroundWorkerAutospin = True

            If CheckBox_Spin1.Checked = True Then
                numberToSpin = 1

            ElseIf CheckBox_spin5.Checked = True Then
                numberToSpin = 5

            ElseIf CheckBox_spin10.Checked = True Then
                numberToSpin = 10

            ElseIf CheckBox_spin100.Checked = True Then
                numberToSpin = 100

            Else
                BackgroundWorkerAutospin = False
                numberToSpin = 0
                MsgBox("Selectionnez d'abord un nombre de spin a effectuer")
            End If

            If BackgroundWorkerAutospin = True Then
                ClickGG("alpha", 250)
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
            Console.WriteLine("Je fais le click")
            Console.WriteLine("J'attends")
            Await delay
            Console.WriteLine("J'ai terminé le click")

            ClickGG(portail, temps)
        End If
    End Sub

    'Private Async Function BackgroundWorker_GGspinner_RunWorkerCompletedAsync(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) As Task Handles BackgroundWorker_GGspinner.RunWorkerCompleted

    '    If BackgroundWorkerAutospin = True Then

    '        'Dim delay = Task.Delay(5000)

    '        'Dim sw = New Stopwatch()
    '        'sw.Start()
    '        'Console.WriteLine("TIC")
    '        ''Console.WriteLine(sw.Elapsed)
    '        ''Console.WriteLine(sw.Elapsed.TotalSeconds)
    '        ''Console.WriteLine(sw.Elapsed.TotalMilliseconds)
    '        'sw.Stop()
    '        'Console.WriteLine("-------")
    '        'Await delay
    '        'Console.WriteLine("TAC")
    '        ''Console.WriteLine(sw.Elapsed)
    '        ''Console.WriteLine(sw.Elapsed.TotalSeconds)
    '        ''Console.WriteLine(sw.Elapsed.TotalMilliseconds)
    '        'Console.WriteLine("async: Running for {0} seconds", sw.Elapsed.TotalSeconds)
    '        'Console.WriteLine("-------")
    '        'Await delay


    '        BackgroundWorker_GGspinner.RunWorkerAsync()

    '    Else


    '    End If

    'End Function

    'Public Check_Spin_Stats As String = 0

    'Private Async Sub BackgroundWorker_GGspinner_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_GGspinner.DoWork

    '    '   Me.Invoke(New MethodInvoker(Sub() --------- ))

    '    If BackgroundWorkerAutospin = True Then

    '        If CheckBox_Spin1.Checked = True Then
    '            Check_Spin_Stats = 1


    '        ElseIf CheckBox_spin5.Checked = True Then
    '            Check_Spin_Stats = 5


    '        ElseIf CheckBox_spin10.Checked = True Then
    '            Check_Spin_Stats = 10


    '        ElseIf CheckBox_spin100.Checked = True Then
    '            Check_Spin_Stats = 100

    '        Else

    '            BackgroundWorkerAutospin = False
    '            Check_Spin_Stats = 0
    '            MsgBox("Selectionnez d'abord un nombre de spin a effectuer")

    '        End If

    '    End If

    '    If BackgroundWorkerAutospin.CancellationPending = True Then
    '        e.Cancel = True

    '        MsgBox("Stopped.")
    '    Else



    '    End If

    'End Sub

#End Region

#End Region
End Class