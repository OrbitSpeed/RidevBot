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

        Labelportal_White_4.Visible = True
        Labelportal_White_5.Visible = False
        Labelportal_White_6.Visible = False
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
        Labelportal_White_4.Visible = False
        Labelportal_White_5.Visible = True
        Labelportal_White_6.Visible = False
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

        Labelportal_White_4.Visible = False
        Labelportal_White_5.Visible = False
        Labelportal_White_6.Visible = True
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

    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Load_Button.Click

        If ProfilSelected = 1 Then

            If Form_Tools.CheckBox_LaunchGameAuto.Checked = True Then
                Label_point_de_chute.Select()
                Form_Tools.Show()
                Form_Game.Show()
                Close()
            Else
                Label_point_de_chute.Select()
                Form_Tools.Show()
                Close()
            End If

        ElseIf ProfilSelected = 2 Then

            If Form_Tools.CheckBox_LaunchGameAuto.Checked = True Then
                Label_point_de_chute.Select()
                Form_Tools.Show()
                Form_Game.Show()
                Close()
            Else
                Label_point_de_chute.Select()
                Form_Tools.Show()
                Close()
            End If

        ElseIf ProfilSelected = 3 Then

            If Form_Tools.CheckBox_LaunchGameAuto.Checked = True Then
                Label_point_de_chute.Select()
                Form_Tools.Show()
                Form_Game.Show()
                Close()
            Else
                Label_point_de_chute.Select()
                Form_Tools.Show()
                Close()
            End If

        Else MsgBox("select profil in first.")


        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

        ' button Remove > Saved '

        Label_point_de_chute.Select()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        ' button Edit > Saved '

        Label_point_de_chute.Select()

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button_SID_Load.Click

        ' button Load > SID login '

        Label_point_de_chute.Select()
        Utils.server = TextBox_server.Text
        Utils.dosid = TextBox_sid.Text

        ' Inutile maintenant qu'on utilise la classe utils
        'Dim server1 = TextBox1.Text
        'Dim dosid = TextBox3.Text

        Utils.InternetSetCookie("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100", "dosid", Utils.dosid & ";")

        Form_Game.Show()
        Form_Game.WebBrowser1.Navigate("https://" + Utils.server + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        ' Form2.WebBrowser1.Navigate("https://" + ((server)) + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")
        Me.Close()

    End Sub

    Private Sub Credentials_Button_Click(sender As Object, e As EventArgs) Handles Credentials_Button.Click

        ' button credentials '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = True
        Panel_profil.Visible = False
        Panel_license.Visible = False

        Label_portal_White_2.Visible = False
        Label_portal_White.Visible = False
        Labelportal_White_3.Visible = True

        Credentials_Button.Enabled = False
        Portail_Button.Enabled = True
        License_Button.Enabled = True

    End Sub

    Private Sub Portail_Button_Click(sender As Object, e As EventArgs) Handles Portail_Button.Click

        ' button Portal '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = False
        Panel_profil.Visible = True
        Panel_license.Visible = False

        Label_portal_White_2.Visible = False
        Label_portal_White.Visible = True
        Labelportal_White_3.Visible = False

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

        Label_portal_White_2.Visible = True
        Label_portal_White.Visible = False
        Labelportal_White_3.Visible = False

        Credentials_Button.Enabled = True
        Portail_Button.Enabled = True
        License_Button.Enabled = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button_ridevbotBrowser.Click

        ' button browser Ridevbot '

        Label_buttonridevbotBrowser.Visible = True
        Label_OfficialLauncherBrowser.Visible = False
        Load_Button.Visible = True
        Button4.Visible = False

        Button_ridevbotBrowser.Enabled = False
        Button_OfficialLauncherBrowser.Enabled = True

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button_OfficialLauncherBrowser.Click

        ' button browser launcher '

        Label_buttonridevbotBrowser.Visible = False
        Label_OfficialLauncherBrowser.Visible = True

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

    Private Sub PictureBoxUsernamePasswordProfil1view_Click(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil1view.Click
        '
        ProfilSelected = 1
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.icons8_carré_arrondi_100_1_
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.icons8_carré_arrondi_100
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.icons8_carré_arrondi_100

        Textbox_Username.Text = TextBox_UsernamePasswordProfil1username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil1password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 1"
        UserAndPass_Button.PerformClick()

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil2view_Click(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil2view.Click
        '
        ProfilSelected = 2
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.icons8_carré_arrondi_100_1_
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.icons8_carré_arrondi_100
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.icons8_carré_arrondi_100

        Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 2"
        UserAndPass_Button.PerformClick()

    End Sub

    Private Sub PictureBoxUsernamePasswordProfil3view_Click(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil3view.Click
        '
        ProfilSelected = 3
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.icons8_carré_arrondi_100_1_
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.icons8_carré_arrondi_100
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.icons8_carré_arrondi_100


        Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 3"
        UserAndPass_Button.PerformClick()


    End Sub

    Private Sub Button_resetAll_accounts_Click(sender As Object, e As EventArgs) Handles Button_resetAll_accounts.Click

        TextBox_UsernamePasswordProfil1username.Text = ""
        TextBoxUsernamePasswordProfil1password.Text = ""
        TextBox_UsernamePasswordProfil2username.Text = ""
        TextBoxUsernamePasswordProfil2password.Text = ""
        TextBox_UsernamePasswordProfil3username.Text = ""
        TextBoxUsernamePasswordProfil3password.Text = ""

        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.icons8_carré_arrondi_100
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.icons8_carré_arrondi_100
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.icons8_carré_arrondi_100

    End Sub

    Private Sub TextBoxUsernamePasswordProfil1password_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsernamePasswordProfil1password.TextChanged

    End Sub
End Class
