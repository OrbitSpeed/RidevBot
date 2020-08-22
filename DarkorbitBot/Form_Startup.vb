Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Form_Startup

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer
    Public ProfilSelected As String = 0
    Public CheckedStats As String = 0

    Private Sub Form_Startup_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form_Tools.TextBox_ProfilSelected.Text = Textbox_Username.Text
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form_Tools.Check_message = 1 Then

            MsgBox("Error", "Check your credentials")

        End If

        If Textbox_Username.Text = TextBox_UsernamePasswordProfil1username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil1password.Text Then

            ProfilSelected = 1
            PictureBoxUsernamePasswordProfil1view.Image = My.Resources.greenBooty
            PictureBoxUsernamePasswordProfil2view.Image = My.Resources.prometium
            PictureBoxUsernamePasswordProfil3view.Image = My.Resources.prometium

        ElseIf Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text Then

            ProfilSelected = 2
            PictureBoxUsernamePasswordProfil2view.Image = My.Resources.greenBooty
            PictureBoxUsernamePasswordProfil1view.Image = My.Resources.prometium
            PictureBoxUsernamePasswordProfil3view.Image = My.Resources.prometium

        ElseIf Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text Then

            ProfilSelected = 3
            PictureBoxUsernamePasswordProfil3view.Image = My.Resources.greenBooty
            PictureBoxUsernamePasswordProfil2view.Image = My.Resources.prometium
            PictureBoxUsernamePasswordProfil1view.Image = My.Resources.prometium

        End If

#Region "Location and resize"
        PanelUserAndPass.Location = New Point(0, 55)
        PanelUserAndPass.Size = New Size(256, 221)

        Panel_ProfilConnection.Location = New Point(0, 37)
        Panel_SidConnexion.Location = New Point(0, 37)
        PanelConnection.Location = New Point(0, 37)

        Panel_profil.Location = New Point(0, 55)
        Panel_license.Location = New Point(0, 55)
#End Region

        Label_Title.Text = "RidevBot v" + Application.ProductVersion
        Me.Size = New Size(256, 251)
        CenterToScreen()
        Label_point_de_chute.Select()

        If Textbox_Username.Text = TextBox_UsernamePasswordProfil1username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil1password.Text Then

        ElseIf Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text Then

        ElseIf Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text Then

        End If

        If CheckedStats = 0 Then
            If Form_Tools.CheckBox_AutoLogin.Checked = True Then
                If Form_Tools.ComboBox_autologin.Text = "Profil 1" Then

                    ProfilSelected = 1
                    Textbox_Username.Text = TextBox_UsernamePasswordProfil1username.Text
                    Textbox_Password.Text = TextBoxUsernamePasswordProfil1password.Text
                    CheckedStats = 1
                    Load_Button.PerformClick()

                ElseIf Form_Tools.ComboBox_autologin.Text = "Profil 2" Then

                    ProfilSelected = 2
                    Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text
                    Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text
                    CheckedStats = 1
                    Load_Button.PerformClick()

                ElseIf Form_Tools.ComboBox_autologin.Text = "Profil 3" Then

                    ProfilSelected = 3
                    Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text
                    Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text
                    CheckedStats = 1
                    Load_Button.PerformClick()


                Else CheckedStats = 1
                    MsgBox("if your active ""Auto Login"" option , select Profil")


                End If
            End If
        End If

    End Sub

    Private Sub UserAndPass_Button_Click(sender As Object, e As EventArgs) Handles UserAndPass_Button.Click

        ' Button 1 = User && Pass '

        Label_point_de_chute.Select()

        PanelUserAndPass.Size = New Size(256, 251)
        Me.Size = New Size(256, 251)
        PanelConnection.Visible = True
        Panel_SidConnexion.Visible = False
        Panel_ProfilConnection.Visible = False

        UserAndPass_Button.Enabled = False
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = True



    End Sub

    Private Sub SID_Login_Button_Click(sender As Object, e As EventArgs) Handles SID_Login_Button.Click

        ' Button 1 = SID login '

        PanelUserAndPass.Size = New Size(256, 251)
        Me.Size = New Size(256, 251)
        Label_point_de_chute.Select()

        PanelConnection.Visible = False
        Panel_SidConnexion.Visible = True
        Panel_ProfilConnection.Visible = False

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = False
        Saved_Button.Enabled = True

    End Sub

    Private Sub Saved_Button_Click(sender As Object, e As EventArgs) Handles Saved_Button.Click

        ' Button 1 = Saved '

        Label_point_de_chute.Select()
        PanelUserAndPass.Size = New Size(256, 358)
        Me.Size = New Size(256, 358)

        PanelConnection.Visible = False
        Panel_SidConnexion.Visible = False
        Panel_ProfilConnection.Visible = True

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = False

    End Sub

    Private Sub Launcher()

        Form_Tools.WebBrowser_Synchronisation.Navigate("https://darkorbit-22.bpsecure.com/")
        Label_point_de_chute.Select()
        Form_Tools.Show()
        Close()

    End Sub

    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Load_Button.Click


        If Textbox_Username.Text = TextBox_UsernamePasswordProfil1username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil1password.Text Then
            ProfilSelected = 1

        ElseIf Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text Then
            ProfilSelected = 2

        ElseIf Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text And Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text Then
            ProfilSelected = 3

        End If

        If ProfilSelected = 1 Then
            Form_Tools.ComboBox_autologin.Text = "Profil 1"
            Launcher()

        ElseIf ProfilSelected = 2 Then
            Form_Tools.ComboBox_autologin.Text = "Profil 2"
            Launcher()

        ElseIf ProfilSelected = 3 Then
            Form_Tools.ComboBox_autologin.Text = "Profil 3"
            Launcher()

        Else Form_Tools.ComboBox_autologin.Text = "Current"
            Launcher()

        End If

        'Form_Tools.Timer_SID.Stop()
        If Form_Tools.BackgroundWorker_Timer.IsBusy = True Then
            Form_Tools.BackgroundWorker_Timer.CancelAsync()
        End If

        Form_Tools.TextBox_minutedouble_dixieme.Text = "0"
        Form_Tools.TextBox_minutedouble.Text = "0"
        Form_Tools.TextBox_secondsdouble2.Text = "0"
        Form_Tools.TextBox_secondsdouble.Text = "0"
        Form_Tools.TextBox_Get_Dosid.Text = ""
        Form_Tools.TextBox_Get_id.Text = ""
        Form_Tools.TextBox_Get_Server.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

        ' button Remove > Saved '

        Label_point_de_chute.Select()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        ' button Edit > Saved '

        Label_point_de_chute.Select()

    End Sub


    Private Sub Button_SID_Load_Click(sender As Object, e As EventArgs) Handles Button_SID_Load.Click

        Label_point_de_chute.Select()
        Utils.server = TextBox_server.Text
        Utils.dosid = TextBox_sid.Text

        Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")
        Form_Game.WebBrowser_Game_Ridevbot.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        Form_Game.Show()

        Me.Close()

    End Sub

    Private Sub Credentials_Button_Click(sender As Object, e As EventArgs) Handles Credentials_Button.Click

        ' button credentials '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = True
        Panel_profil.Visible = False
        Panel_license.Visible = False

        Credentials_Button.Enabled = False
        Portail_Button.Enabled = True
        License_Button.Enabled = True

        UserAndPass_Button.PerformClick()

    End Sub

    Private Sub Portail_Button_Click(sender As Object, e As EventArgs) Handles Portail_Button.Click

        ' button Portal '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = False
        Panel_profil.Visible = True
        Panel_license.Visible = False

        Credentials_Button.Enabled = True
        Portail_Button.Enabled = False
        License_Button.Enabled = True

    End Sub

    Private Sub License_Button_Click(sender As Object, e As EventArgs) Handles License_Button.Click

        ' button License '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = False
        Panel_profil.Visible = False
        Panel_license.Visible = True

        Credentials_Button.Enabled = True
        Portail_Button.Enabled = True
        License_Button.Enabled = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button_ridevbotBrowser.Click

        ' button browser Ridevbot '

        Load_Button.Visible = True
        Button4.Visible = False

        Button_ridevbotBrowser.Enabled = False
        Button_OfficialLauncherBrowser.Enabled = True

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button_OfficialLauncherBrowser.Click

        ' button browser launcher '

        Load_Button.Visible = False
        Button4.Visible = True

        Button_ridevbotBrowser.Enabled = True
        Button_OfficialLauncherBrowser.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' button Load 2 > User&&Pass > Launcher'

        Label_point_de_chute.Select()

    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove

        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp
            tmp = Nothing
        End If

    End Sub

    Private Sub Panel7_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseDown

        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Panel7_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseUp

        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
    End Sub

#Region "Yeux"
    Private Sub PictureBox_PasswordHider_MouseDown(sender As Object, e As EventArgs) Handles PictureBox_PasswordHider.MouseDown
        Textbox_Password.UseSystemPasswordChar = False
        PictureBox_PasswordHider.Image = My.Resources.img_eyeOpen
    End Sub
    Private Sub PictureBox_PasswordHider_MouseUp(sender As Object, e As EventArgs) Handles PictureBox_PasswordHider.MouseUp
        Textbox_Password.UseSystemPasswordChar = True
        PictureBox_PasswordHider.Image = My.Resources.img_eyeClose
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil1eyes_MouseDown(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil1eyes.MouseDown
        TextBoxUsernamePasswordProfil1password.UseSystemPasswordChar = False
        PictureBoxUsernamePasswordProfil1eyes.Image = My.Resources.img_eyeOpen
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil1eyes_MouseUp(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil1eyes.MouseUp
        TextBoxUsernamePasswordProfil1password.UseSystemPasswordChar = True
        PictureBoxUsernamePasswordProfil1eyes.Image = My.Resources.img_eyeClose
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil2eyes_MouseDown(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil2eyes.MouseDown
        TextBoxUsernamePasswordProfil2password.UseSystemPasswordChar = False
        PictureBoxUsernamePasswordProfil2eyes.Image = My.Resources.img_eyeOpen
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil2eyes_MouseUp(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil2eyes.MouseUp
        TextBoxUsernamePasswordProfil2password.UseSystemPasswordChar = True
        PictureBoxUsernamePasswordProfil2eyes.Image = My.Resources.img_eyeClose
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil3eyes_MouseDown(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil3eyes.MouseDown
        TextBoxUsernamePasswordProfil3password.UseSystemPasswordChar = False
        PictureBoxUsernamePasswordProfil3eyes.Image = My.Resources.img_eyeOpen
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil3eyes_MouseUp(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil3eyes.MouseUp
        TextBoxUsernamePasswordProfil3password.UseSystemPasswordChar = True
        PictureBoxUsernamePasswordProfil3eyes.Image = My.Resources.img_eyeClose
    End Sub
#End Region

    Private Sub PictureBoxUsernamePasswordProfil1view_Click(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil1view.Click
        '
        ProfilSelected = 1
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.greenBooty
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.prometium
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.prometium

        Textbox_Username.Text = TextBox_UsernamePasswordProfil1username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil1password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 1"
        UserAndPass_Button.PerformClick()
        Load_Button.PerformClick()

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil2view_Click(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil2view.Click
        '
        ProfilSelected = 2
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.greenBooty
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.prometium
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.prometium

        Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 2"
        UserAndPass_Button.PerformClick()
        Load_Button.PerformClick()

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil3view_Click(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil3view.Click
        '
        ProfilSelected = 3
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.greenBooty
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.prometium
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.prometium


        Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 3"
        UserAndPass_Button.PerformClick()
        Load_Button.PerformClick()


    End Sub

    Private Sub Button_resetAll_accounts_Click(sender As Object, e As EventArgs) Handles Button_resetAll_accounts.Click

        TextBox_UsernamePasswordProfil1username.Text = ""
        TextBoxUsernamePasswordProfil1password.Text = ""
        TextBox_UsernamePasswordProfil2username.Text = ""
        TextBoxUsernamePasswordProfil2password.Text = ""
        TextBox_UsernamePasswordProfil3username.Text = ""
        TextBoxUsernamePasswordProfil3password.Text = ""

        'PictureBoxUsernamePasswordProfil3view.Image = My.Resources.icons8_carré_arrondi_100
        'PictureBoxUsernamePasswordProfil2view.Image = My.Resources.icons8_carré_arrondi_100
        'PictureBoxUsernamePasswordProfil1view.Image = My.Resources.icons8_carré_arrondi_100

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil3eyes_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxUsernamePasswordProfil3eyes.MouseDown

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil3eyes_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxUsernamePasswordProfil3eyes.MouseUp

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil2eyes_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxUsernamePasswordProfil2eyes.MouseDown

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil2eyes_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxUsernamePasswordProfil2eyes.MouseUp

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil1eyes_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxUsernamePasswordProfil1eyes.MouseDown

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil1eyes_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxUsernamePasswordProfil1eyes.MouseUp

    End Sub

    Private Sub PictureBox_PasswordHider_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox_PasswordHider.MouseDown

    End Sub

    Private Sub PictureBox_PasswordHider_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox_PasswordHider.MouseUp

    End Sub

    Private Sub Panel_Title_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Title.Paint

    End Sub
End Class