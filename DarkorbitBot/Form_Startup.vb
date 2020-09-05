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

        Dim test1 = Utils.GenerateSHA512String(Utils.Firebase_Secret)
        MsgBox(test1)

        'Console.WriteLine("----------")
        'sKZhQw5brMKAHXuUuyjYgmGNTNUwbpQPQ7b87ABYSevjugXRnDxmWes6GA5VEAYU, 1475a6209fc4fce52a6acc08a642d36caa916738
        ' coté serveur :  Dim dans_base_de_donnee = "1475a6209fc4fce52a6acc08a642d36caa916738"
        ' coté client Console.WriteLine(Utils.getSHA1Hash("sKZhQw5brMKAHXuUuyjYgmGNTNUwbpQPQ7b87ABYSevjugXRnDxmWes6GA5VEAYU"))


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
        PanelUserAndPass.Location = New Point(0, 18)
        PanelUserAndPass.Size = New Size(256, 221)

        Panel_ProfilConnection.Location = New Point(0, 35)
        Panel_SidConnexion.Location = New Point(0, 35)
        PanelConnection.Location = New Point(0, 35)

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
                    Button_Load.PerformClick()

                ElseIf Form_Tools.ComboBox_autologin.Text = "Profil 2" Then

                    ProfilSelected = 2
                    Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text
                    Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text
                    CheckedStats = 1
                    Button_Load.PerformClick()

                ElseIf Form_Tools.ComboBox_autologin.Text = "Profil 3" Then

                    ProfilSelected = 3
                    Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text
                    Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text
                    CheckedStats = 1
                    Button_Load.PerformClick()


                Else CheckedStats = 1
                    MessageBox.Show("If you active the ""Auto Login"" option, please select Profil")


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

    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Button_Load.Click


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

        Form_Tools.TextBox_Get_Dosid.Text = ""

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

    Private Sub Credentials_Button_Click(sender As Object, e As EventArgs)

        ' button credentials '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = True

        UserAndPass_Button.PerformClick()

    End Sub

    Private Sub Portail_Button_Click(sender As Object, e As EventArgs)

        ' button Portal '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = False

    End Sub

    Private Sub License_Button_Click(sender As Object, e As EventArgs)

        ' button License '

        Me.Size = New Size(256, 251)
        PanelUserAndPass.Visible = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

        ' button browser Ridevbot '

        Button_Load.Visible = True


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

        ' button browser launcher '

        Button_Load.Visible = False


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

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
        Button_Load.PerformClick()

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
        Button_Load.PerformClick()

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
        Button_Load.PerformClick()


    End Sub

    Private Sub Button_resetAll_accounts_Click(sender As Object, e As EventArgs)

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

    Private Sub Textbox_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Load.PerformClick()
        End If
    End Sub

    Private Sub TextBoxUsernamePasswordProfil2password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUsernamePasswordProfil2password.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBoxUsernamePasswordProfil2view_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBoxUsernamePasswordProfil3password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUsernamePasswordProfil3password.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBoxUsernamePasswordProfil3view_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBox_license_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_license.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_License_Verify.PerformClick()
        End If
    End Sub
End Class