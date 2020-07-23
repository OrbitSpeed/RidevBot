﻿Public Class Form_Tools

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove

        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp
            tmp = Nothing
        End If

    End Sub

    Private Sub Panel7_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel7.MouseDown

        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Panel7_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel7.MouseUp

        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If

    End Sub

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
            If Form_Game.Visible = False Then

                Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"

            Else


            End If
        End If

    End Sub

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
        'CloseForm1.Show()
    End Sub

    Private Sub General_button_Click(sender As Object, e As EventArgs) Handles General_button.Click

        General_button.Enabled = False
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = True
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

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

        Label10.Visible = False
        Label9.Visible = True
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

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

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = True
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(517, 324)

    End Sub

    Private Sub GalaxyGates_Button_Click(sender As Object, e As EventArgs) Handles GalaxyGates_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = False
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = True
        Panel_Palladium.Visible = False
        Panel_stats.Visible = False
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(390, 324)

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

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

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
        Stats_Button.Enabled = False
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
        Label5.Visible = False

        Panel_general.Visible = False
        Panel_Npc.Visible = False
        Panel_collector.Visible = False
        Panel_GalaxyGates.Visible = False
        Panel_Palladium.Visible = False
        Panel_stats.Visible = True
        Panel_rex.Visible = False
        Panel_divers.Visible = False

        Size = New Size(390, 324)


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

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        Label5.Visible = False

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

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = True

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

    Private Sub Button_LaunchGameRidevBrowser_Click(sender As Object, e As EventArgs) Handles Button_LaunchGameRidevBrowser.Click

        If Form_Game.Visible = True Then

            Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
            Label1.Select()
            Form_Game.Show()

        Else
            If Form_Game.Visible = False Then

                Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
                Label1.Select()
                Form_Game.Show()

            Else


            End If
        End If


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        If TextBox_Get_Server.Text = "" Then

            MsgBox("actualiser d'abord le Game server en vous connectant a l'aide du button > Open RidevBot Browser ")

        Else

            BackPage_Form.WebBrowser1.Navigate("https://" + TextBox_Get_Server.Text + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
            BackPage_Form.Show()

        End If

    End Sub

    ' full = toute la gg 
    ' last = derniere piece

    Private Sub Button_kronos_Click(sender As Object, e As EventArgs) Handles Button_kronos.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=12&type=full")

    End Sub

    Private Sub Button_hades_Click(sender As Object, e As EventArgs) Handles Button_hades.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=13&type=full")

    End Sub

    Private Sub Button_kuiper_Click(sender As Object, e As EventArgs) Handles Button_kuiper.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=19&type=full")

    End Sub

    Private Sub Button_lambda_Click(sender As Object, e As EventArgs) Handles Button_lambda.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=8&type=full")

    End Sub

    Private Sub Button_Kappa_Click(sender As Object, e As EventArgs) Handles Button_Kappa.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=7&type=full")

    End Sub

    Private Sub Button_zeta_Click(sender As Object, e As EventArgs) Handles Button_zeta.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=6&type=full")

    End Sub

    Private Sub Button_epsilon_Click(sender As Object, e As EventArgs) Handles Button_epsilon.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=5&type=full")

    End Sub

    Private Sub Button_delta_Click(sender As Object, e As EventArgs) Handles Button_delta.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=4&type=full")

    End Sub

    Private Sub Button_gamma_Click(sender As Object, e As EventArgs) Handles Button_gamma.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=3&type=full")

    End Sub

    Private Sub Button_beta_Click(sender As Object, e As EventArgs) Handles Button_beta.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=2&type=full")

    End Sub

    Private Sub Button_Alpha_Click(sender As Object, e As EventArgs) Handles Button_Alpha.Click

        WebBrowser_galaxyGates.Navigate("https://" + ((TextBox_Get_id.Text)) + ".darkorbit.com/jumpgate.php?userID=" + ((TextBox_Get_Dosid.Text)) + "&gateID=1&type=full")

    End Sub

    Private Sub Button_ABG_GGS_Click(sender As Object, e As EventArgs) Handles Button_ABG_GGS.Click

        WebBrowser_GGspinner.Navigate(" https://" + ((TextBox_Get_Server.Text)) + ".darkorbit.com/flashinput/galaxyGates.php?userID=" + ((TextBox_Get_id.Text)) + "&action=multiEnergy&sid=" + ((TextBox_Get_Dosid.Text)) + "&gateID=1&alpha=1&sample=1&multiplier=1")

    End Sub
End Class