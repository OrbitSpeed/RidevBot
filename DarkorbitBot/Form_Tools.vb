Imports System.Net
Imports System.Text.RegularExpressions

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

        WebBrowser_GGInfo.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + TextBox_Get_id.Text + "&action=init&sid=" + Utils.dosid)

        ' https://fr1.darkorbit.com/flashinput/galaxyGates.php?userID=168449162&action=init&sid=b1b8a3c2e29ac06147fea27af6fac2bb

        TextBox_WinGGS.Visible = True

        ' End If

        CenterToScreen()

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
    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click

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

        Dim Chronos = Regex.Match(TextBox_GGinfoGGS.Text, "21.*?>([\s\S]*?)<\/DIV>") ' Info GG chronos
        Dim DataChronos = (Chronos.Groups.Item(1).ToString)
        DataChronos = Replace(DataChronos, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataChronos = Replace(DataChronos, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataChronos = Replace(DataChronos, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataChronos = Replace(DataChronos, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataChronos = Replace(DataChronos, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Chronos")
        Console.WriteLine(DataChronos)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click

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

        Dim Hades = Regex.Match(TextBox_GGinfoGGS.Text, "45.*?>([\s\S]*?)<\/DIV>") ' Info GG hades
        Dim DataHades = (Hades.Groups.Item(1).ToString)
        DataHades = Replace(DataHades, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataHades = Replace(DataHades, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataHades = Replace(DataHades, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataHades = Replace(DataHades, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataHades = Replace(DataHades, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Hades")
        Console.WriteLine(DataHades)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click

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

        Dim Kuiper = Regex.Match(TextBox_GGinfoGGS.Text, "total<\/SPAN><SPAN class=""m"">=""<\/SPAN><B>100.*?>([\s\S]*?)<\/DIV>") ' Info GG kuiper
        Dim DataKuiper = (Kuiper.Groups.Item(1).ToString)
        DataKuiper = Replace(DataKuiper, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataKuiper = Replace(DataKuiper, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataKuiper = Replace(DataKuiper, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataKuiper = Replace(DataKuiper, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataKuiper = Replace(DataKuiper, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        DataKuiper = Replace(DataKuiper, "  total</SPAN><SPAN class="" m"">=""</SPAN><B>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Kuiper")
        Console.WriteLine(DataKuiper)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click

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

        Dim Lambda = Regex.Match(TextBox_GGinfoGGS.Text, "45.*?>([\s\S]*?)<\/DIV>") ' Info GG lambda
        Dim DataLambda = (Lambda.Groups.Item(1).ToString)
        DataLambda = Replace(DataLambda, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataLambda = Replace(DataLambda, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataLambda = Replace(DataLambda, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataLambda = Replace(DataLambda, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataLambda = Replace(DataLambda, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Lambda")
        Console.WriteLine(DataLambda)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click

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

        Dim Kappa = Regex.Match(TextBox_GGinfoGGS.Text, "120.*?>([\s\S]*?)<\/DIV>") ' Info GG kappa
        Dim DataKappa = (Kappa.Groups.Item(1).ToString)
        DataKappa = Replace(DataKappa, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataKappa = Replace(DataKappa, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataKappa = Replace(DataKappa, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataKappa = Replace(DataKappa, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataKappa = Replace(DataKappa, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("kappa")
        Console.WriteLine(DataKappa)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click

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

        Dim Zeta = Regex.Match(TextBox_GGinfoGGS.Text, "111.*?>([\s\S]*?)<\/DIV>") ' Info GG zeta
        Dim DataZeta = (Zeta.Groups.Item(1).ToString)
        DataZeta = Replace(DataZeta, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataZeta = Replace(DataZeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataZeta = Replace(DataZeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataZeta = Replace(DataZeta, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataZeta = Replace(DataZeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Zeta")
        Console.WriteLine(DataZeta)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click

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

        Dim Epsilon = Regex.Match(TextBox_GGinfoGGS.Text, "99.*?>([\s\S]*?)<\/DIV>") ' Info GG epsilon
        Dim DataEpsilon = (Epsilon.Groups.Item(1).ToString)
        DataEpsilon = Replace(DataEpsilon, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataEpsilon = Replace(DataEpsilon, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataEpsilon = Replace(DataEpsilon, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataEpsilon = Replace(DataEpsilon, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataEpsilon = Replace(DataEpsilon, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("epsilon")
        Console.WriteLine(DataEpsilon)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click

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

        Dim Delta = Regex.Match(TextBox_GGinfoGGS.Text, "128.*?>([\s\S]*?)<\/DIV>") ' Info GG Delta
        Dim DataDelta = (Delta.Groups.Item(1).ToString)
        DataDelta = Replace(DataDelta, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataDelta = Replace(DataDelta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataDelta = Replace(DataDelta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataDelta = Replace(DataDelta, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataDelta = Replace(DataDelta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Delta")
        Console.WriteLine(DataDelta)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click

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

        Dim Gamma = Regex.Match(TextBox_GGinfoGGS.Text, "82.*?>([\s\S]*?)<\/DIV>") ' Info GG gamma
        Dim DataGamma = (Gamma.Groups.Item(1).ToString)
        DataGamma = Replace(DataGamma, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataGamma = Replace(DataGamma, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataGamma = Replace(DataGamma, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataGamma = Replace(DataGamma, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataGamma = Replace(DataGamma, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Gamma")
        Console.WriteLine(DataGamma)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click

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

        Dim Beta = Regex.Match(TextBox_GGinfoGGS.Text, "48.*?>([\s\S]*?)<\/DIV>") ' Info GG Beta
        Dim DataBeta = (Beta.Groups.Item(1).ToString)
        DataBeta = Replace(DataBeta, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataBeta = Replace(DataBeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataBeta = Replace(DataBeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataBeta = Replace(DataBeta, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataBeta = Replace(DataBeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Beta")
        Console.WriteLine(DataBeta)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click

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

        Dim Alpha = Regex.Match(TextBox_GGinfoGGS.Text, "34.*?>([\s\S]*?)<\/DIV>") ' Info GG Alpha
        Dim DataAlpha = (Alpha.Groups.Item(1).ToString)
        DataAlpha = Replace(DataAlpha, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataAlpha = Replace(DataAlpha, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Alpha")
        Console.WriteLine(DataAlpha)

        TextBox_WinGGS.Size = New Size(439, 86)
        TextBox_WinGGS.Location = New Point(15, 508)

        Label_Transition_GGS.Text = "__________________________________________________"

        WebBrowser_galaxyGates2.Visible = False
        WebBrowser_galaxyGates3.Visible = False

    End Sub

    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click

        Button_delta.Enabled = True
        Button_epsilon.Enabled = True
        Button_zeta.Enabled = True
        Button_Kappa.Enabled = True
        Button_lambda.Enabled = True
        Button_kronos.Enabled = True
        Button_hades.Enabled = True
        Button_kuiper.Enabled = True

        Button_Alpha.Enabled = True
        Button_beta.Enabled = True
        Button_gamma.Enabled = True

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

        Dim Alpha = Regex.Match(TextBox_GGinfoGGS.Text, "34.*?>([\s\S]*?)<\/DIV>") ' Info GG Alpha
        Dim DataAlpha = (Alpha.Groups.Item(1).ToString)
        DataAlpha = Replace(DataAlpha, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataAlpha = Replace(DataAlpha, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Alpha")
        Console.WriteLine(DataAlpha)

        Dim Beta = Regex.Match(TextBox_GGinfoGGS.Text, "48.*?>([\s\S]*?)<\/DIV>") ' Info GG Beta
        Dim DataBeta = (Beta.Groups.Item(1).ToString)
        DataBeta = Replace(DataBeta, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataBeta = Replace(DataBeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataBeta = Replace(DataBeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataBeta = Replace(DataBeta, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataBeta = Replace(DataBeta, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Beta")
        Console.WriteLine(DataBeta)

        Dim Gamma = Regex.Match(TextBox_GGinfoGGS.Text, "82.*?>([\s\S]*?)<\/DIV>") ' Info GG gamma
        Dim DataGamma = (Gamma.Groups.Item(1).ToString)
        DataGamma = Replace(DataGamma, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataGamma = Replace(DataGamma, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataGamma = Replace(DataGamma, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataGamma = Replace(DataGamma, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataGamma = Replace(DataGamma, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Gamma")
        Console.WriteLine(DataGamma)



        'Button_Alpha.PerformClick()
        'Button_beta.PerformClick()
        'Button_Kappa.PerformClick()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_OpenLoginPanel.Click

        'button open Login Box'

        Form_Startup.Show()

    End Sub

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

    Private Sub TextBox_uridiumtokeepGGS_LostFocus(sender As Object, e As EventArgs) Handles TextBox_uridiumtokeepGGS.LostFocus
        TextBox_uridiumtokeepGGS.Text = Utils.NumberToHumanReadable(TextBox_uridiumtokeepGGS.Text, ".")
    End Sub

    Private Sub Button_ResetStats_Click(sender As Object, e As EventArgs) Handles Button_ResetStats.Click

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

        'TODO ? :
        'WebBrowser_GGspinner.Navigate(Utils.GGspinner(server, userid, sid, gate))

        If Button_Alpha.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + Utils.userid + "&sid=" + Utils.dosid + "&action=setupGate&gateID=1")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 1))

        ElseIf Button_beta.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=2")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 2))

        ElseIf Button_gamma.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=3")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 3))

        ElseIf Button_delta.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https//" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=4")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 4))

        ElseIf Button_epsilon.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=5")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 5))

        ElseIf Button_zeta.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https: //" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=6")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 6))

        ElseIf Button_Kappa.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=7")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 7))

        ElseIf Button_lambda.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https: //" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=8")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 8))

        ElseIf Button_hades.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https://" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=19")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 19))

        ElseIf Button_kuiper.Enabled = False Then

            'WebBrowser_GGspinner.Navigate("https: //" + Utils.server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + TextBox_Get_id.Text + "&sid=" + Utils.dosid + "&action=setupGate&gateID=13")
            WebBrowser_GGspinner.Navigate(Utils.PrepareGatesFunction(Utils.server, Utils.userid, Utils.dosid, 13))
        End If

        'https://fr1.darkorbit.com/flashinput/galaxyGates.php?userID=TONID&sid=TONSID&action=setupGate&gateID=5

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

            Else DataWinned = "part found"

            End If

        End If

        TextBox_WinGGS.Text = vbNewLine +
            "(" + (spinamount_selected.Groups.Item(1).ToString) + ") " + (mode.Groups.Item(1).ToString) + " - " + (DataWinned) + " (" + (DataWinned3) + ")" + TextBox_WinGGS.Text

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

        'Console.WriteLine("---DEBUG---")
        'Console.WriteLine(money.Groups.Item(1).ToString)
        'Console.WriteLine(Utils.NumberToHumanReadable(money.Groups.Item(1).ToString, "."))
        'Console.WriteLine("---DEBUG---")

        'TextBox_uridiumGGS.Text = Utils.NumberToHumanReadable(money.Groups.Item(1).ToString, ".")
        TextBox_uridiumGGS.Text = Utils.NumberToHumanReadable(money.Groups.Item(1).ToString, ".")
        TextBox_ExtraEnergy_GGS.Text = (DataSamples)
#End Region



        ' id<\/SPAN><SPAN class="m">="<\/SPAN><B>1<\/B.*?>([\s\S]*?)<\/DIV>


    End Sub

    Private Sub WebBrowser_GGInfo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_GGInfo.DocumentCompleted

        Dim html107 = WebBrowser_GGInfo.DocumentText.Clone
        TextBox_GGinfoGGS.Text = html107

        Dim Alpha = Regex.Match(TextBox_GGinfoGGS.Text, "34.*?>([\s\S]*?)<\/DIV>") ' Info GG Alpha
        Dim DataAlpha = (Alpha.Groups.Item(1).ToString)
        DataAlpha = Replace(DataAlpha, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataAlpha = Replace(DataAlpha, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataAlpha = Replace(DataAlpha, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        Console.WriteLine("---DEBUG---")
        Console.WriteLine("Alpha")
        Console.WriteLine(DataAlpha)

        If Button_Alpha.Enabled = False Then

#Region "AlphaSpinStats"

            If DataAlpha.Contains("prepared1") Then

                Label_infoPartGG_InMap.Text = "On map : 1"

            ElseIf DataAlpha.Contains("prepared0") Then

                Label_infoPartGG_InMap.Text = "On map : 0"

            End If

            If DataAlpha.Contains("lifePrice-1") Then

                Button_buyLives.Text = "Build GG in first"

            Else Button_buyLives.Text = "Buy live"

            End If

            If DataAlpha.Contains("livesLeft5") Then

                Label_LivesLeft.Text = "Lives left : 5"

            ElseIf DataAlpha.Contains("livesLeft4") Then

                Label_LivesLeft.Text = "Lives left : 4"

            ElseIf DataAlpha.Contains("livesLeft3") Then

                Label_LivesLeft.Text = "Lives left : 3"

            ElseIf DataAlpha.Contains("livesLeft2") Then

                Label_LivesLeft.Text = "Lives left : 2"

            ElseIf DataAlpha.Contains("livesLeft1") Then

                Label_LivesLeft.Text = "Lives left : 1"

            ElseIf DataAlpha.Contains("livesLeft0") Then

                Label_LivesLeft.Text = "Lives left : 0"

            ElseIf DataAlpha.Contains("livesLeft-1") Then

                Label_LivesLeft.Text = "Lives left : -1"

            End If

            If DataAlpha.Contains("currentWave1") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 1 / 40"

            ElseIf DataAlpha.Contains("currentWave2") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 2 / 40"

            ElseIf DataAlpha.Contains("currentWave3") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 3 / 40"

            ElseIf DataAlpha.Contains("currentWave4") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 4 / 40"

            ElseIf DataAlpha.Contains("currentWave5") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 5 / 40"

            ElseIf DataAlpha.Contains("currentWave6") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 6 / 40"

            ElseIf DataAlpha.Contains("currentWave7") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 7 / 40"

            ElseIf DataAlpha.Contains("currentWave8") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 8 / 40"

            ElseIf DataAlpha.Contains("currentWave9") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 9 / 40"

            ElseIf DataAlpha.Contains("currentWave10") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 10 / 40"

            ElseIf DataAlpha.Contains("currentWave11") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 11 / 40"

            ElseIf DataAlpha.Contains("currentWave12") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 12 / 40"

            ElseIf DataAlpha.Contains("currentWave13") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 13 / 40"

            ElseIf DataAlpha.Contains("currentWave14") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 14 / 40"

            ElseIf DataAlpha.Contains("currentWave15") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 15 / 40"

            ElseIf DataAlpha.Contains("currentWave16") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 16 / 40"

            ElseIf DataAlpha.Contains("currentWave17") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 17 / 40"

            ElseIf DataAlpha.Contains("currentWave18") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 18 / 40"

            ElseIf DataAlpha.Contains("currentWave19") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 19 / 40"

            ElseIf DataAlpha.Contains("currentWave20") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 20 / 40"

            ElseIf DataAlpha.Contains("currentWave21") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 21 / 40"

            ElseIf DataAlpha.Contains("currentWave22") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 22 / 40"

            ElseIf DataAlpha.Contains("currentWave23") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 23 / 40"

            ElseIf DataAlpha.Contains("currentWave24") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 24 / 40"

            ElseIf DataAlpha.Contains("currentWave25") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 25 / 40"

            ElseIf DataAlpha.Contains("currentWave26") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 26 / 40"

            ElseIf DataAlpha.Contains("currentWave27") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 27 / 40"

            ElseIf DataAlpha.Contains("currentWave28") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 28 / 40"

            ElseIf DataAlpha.Contains("currentWave29") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 29 / 40"

            ElseIf DataAlpha.Contains("currentWave30") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 30 / 40"

            ElseIf DataAlpha.Contains("currentWave31") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 31 / 40"

            ElseIf DataAlpha.Contains("currentWave32") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 32 / 40"

            ElseIf DataAlpha.Contains("currentWave33") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 33 / 40"

            ElseIf DataAlpha.Contains("currentWave34") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 34 / 40"

            ElseIf DataAlpha.Contains("currentWave35") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 35 / 40"

            ElseIf DataAlpha.Contains("currentWave36") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 36 / 40"

            ElseIf DataAlpha.Contains("currentWave37") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 37 / 40"

            ElseIf DataAlpha.Contains("currentWave38") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 38 / 40"

            ElseIf DataAlpha.Contains("currentWave39") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 39 / 40"

            ElseIf DataAlpha.Contains("currentWave40") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 40 / 40"

            ElseIf DataAlpha.Contains("currentWave0") Then

                Label_infoPartGG_CurrentWave.Text = "Wave : 0 / 40"

            End If

            If DataAlpha.Contains("current1") Then

                Label_InfoPartGG.Text = "Part : 1 / 40"

            ElseIf DataAlpha.Contains("current2") Then

                Label_InfoPartGG.Text = "Part : 2 / 40"

            ElseIf DataAlpha.Contains("current3") Then

                Label_InfoPartGG.Text = "Part : 3 / 40"

            ElseIf DataAlpha.Contains("current4") Then

                Label_InfoPartGG.Text = "Part : 4 / 40"

            ElseIf DataAlpha.Contains("current5") Then

                Label_InfoPartGG.Text = "Part : 5 / 40"

            ElseIf DataAlpha.Contains("current6") Then

                Label_InfoPartGG.Text = "Part : 6 / 40"

            ElseIf DataAlpha.Contains("current7") Then

                Label_InfoPartGG.Text = "Part : 7 / 40"

            ElseIf DataAlpha.Contains("current8") Then

                Label_InfoPartGG.Text = "Part : 8 / 40"

            ElseIf DataAlpha.Contains("current9") Then

                Label_InfoPartGG.Text = "Part : 9 / 40"

            ElseIf DataAlpha.Contains("current10") Then

                Label_InfoPartGG.Text = "Part : 10 / 40"

            ElseIf DataAlpha.Contains("current11") Then

                Label_InfoPartGG.Text = "Part : 11 / 40"

            ElseIf DataAlpha.Contains("current12") Then

                Label_InfoPartGG.Text = "Part : 12 / 40"

            ElseIf DataAlpha.Contains("current13") Then

                Label_InfoPartGG.Text = "Part : 13 / 40"

            ElseIf DataAlpha.Contains("current14") Then

                Label_InfoPartGG.Text = "Part : 14 / 40"

            ElseIf DataAlpha.Contains("current15") Then

                Label_InfoPartGG.Text = "Part : 15 / 40"

            ElseIf DataAlpha.Contains("current16") Then

                Label_InfoPartGG.Text = "Part : 16 / 40"

            ElseIf DataAlpha.Contains("current17") Then

                Label_InfoPartGG.Text = "Part : 17 / 40"

            ElseIf DataAlpha.Contains("current18") Then

                Label_InfoPartGG.Text = "Part : 18 / 40"

            ElseIf DataAlpha.Contains("current19") Then

                Label_InfoPartGG.Text = "Part : 19 / 40"

            ElseIf DataAlpha.Contains("current20") Then

                Label_InfoPartGG.Text = "Part : 20 / 40"

            ElseIf DataAlpha.Contains("current21") Then

                Label_InfoPartGG.Text = "Part : 21 / 40"

            ElseIf DataAlpha.Contains("current22") Then

                Label_InfoPartGG.Text = "Part : 22 / 40"

            ElseIf DataAlpha.Contains("current23") Then

                Label_InfoPartGG.Text = "Part : 23 / 40"

            ElseIf DataAlpha.Contains("current24") Then

                Label_InfoPartGG.Text = "Part : 24 / 40"

            ElseIf DataAlpha.Contains("current25") Then

                Label_InfoPartGG.Text = "Part : 25 / 40"

            ElseIf DataAlpha.Contains("current26") Then

                Label_InfoPartGG.Text = "Part : 26 / 40"

            ElseIf DataAlpha.Contains("current27") Then

                Label_InfoPartGG.Text = "Part : 27 / 40"

            ElseIf DataAlpha.Contains("current28") Then

                Label_InfoPartGG.Text = "Part : 28 / 40"

            ElseIf DataAlpha.Contains("current29") Then

                Label_InfoPartGG.Text = "Part : 29 / 40"

            ElseIf DataAlpha.Contains("current30") Then

                Label_InfoPartGG.Text = "Part : 30 / 40"

            ElseIf DataAlpha.Contains("current31") Then

                Label_InfoPartGG.Text = "Part : 31 / 40"

            ElseIf DataAlpha.Contains("current32") Then

                Label_InfoPartGG.Text = "Part : 32 / 40"

            ElseIf DataAlpha.Contains("current33") Then

                Label_InfoPartGG.Text = "Part : 33 / 40"

            ElseIf DataAlpha.Contains("current34") Then

                Label_InfoPartGG.Text = "Part : 34 / 40"

            ElseIf DataAlpha.Contains("current35") Then

                Label_InfoPartGG.Text = "Part : 35 / 40"

            ElseIf DataAlpha.Contains("current36") Then

                Label_InfoPartGG.Text = "Part : 36 / 40"

            ElseIf DataAlpha.Contains("current37") Then

                Label_InfoPartGG.Text = "Part : 37 / 40"

            ElseIf DataAlpha.Contains("current38") Then

                Label_InfoPartGG.Text = "Part : 38 / 40"

            ElseIf DataAlpha.Contains("current39") Then

                Label_InfoPartGG.Text = "Part : 39 / 40"

            ElseIf DataAlpha.Contains("current40") Then

                Label_InfoPartGG.Text = "Part : 40 / 40"

            ElseIf DataAlpha.Contains("current0") Then

                Label_InfoPartGG.Text = "Part : 0 / 40"

            End If

#End Region

        ElseIf Button_beta.Enabled = False Then

        ElseIf Button_gamma.Enabled = False Then

        End If

        ' TextBox_infoGGbeta1
        ' </B><SPAN class="m">"</SPAN><SPAN class="m">&gt;</SPAN>
        ' </B><SPAN class="m">"</SPAN><SPAN class="m">&gt;</SPAN>
        ' id<\/SPAN><SPAN class="m">="<\/SPAN><B>1<\/B.*?>([\s\S]*?) <\/ DIV >
        ' </B><SPAN class="m">"</SPAN><SPAN class="m"> /&gt;</SPAN>

        ' BETA ET KUIPER BUGUUER , TCHEKER POURQUOI SA MERE LA PUTE !!!!

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
End Class