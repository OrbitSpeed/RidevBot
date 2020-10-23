Imports Firebase.Auth

Public Class Form_Startup

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer
    Public ProfilSelected As String = 0
    Public CheckedStats As String = 0

#Region "Caché"
    Private lespates As New FirebaseConfig("AIzaSyARdVr3iWd4B_dob9H_dU3dg7tlfm5U5vE")

    Public lefromage As New FirebaseAuthProvider(lespates)
#End Region

    Private Sub Form_Startup_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form_Tools.TextBox_ProfilSelected.Text = Textbox_Username.Text
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Title.Text = "RidevBot v" + Application.ProductVersion

        Form_Tools.Button_revive_sid.Enabled = False
        '   User_Database.Load()


        Me.Size = New Size(303, 200)
        CenterToScreen()
        Label_point_de_chute.Select()

        Button_Load.Enabled = False
        Button_SID_Load.Enabled = False
        Panel_License.Visible = True

        Try
            Utils.DateDistant = Utils.GetNetworkTime()
            Console.WriteLine(Utils.DateDistant)
        Catch ex As Exception
            Console.WriteLine($"Erreur:{ex.ToString}")
        End Try

        Panel_License.Visible = False

        If My.Settings.email_license <> "Email" And My.Settings.password_license <> "Your Password" Then
            Button_license_verify_Click(Nothing, Nothing)
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

        Panel_ProfilConnection.Location = New Point(0, 58)
        Panel_SidConnexion.Location = New Point(0, 58)
        PanelConnection.Location = New Point(0, 58)
        Panel_License.Location = New Point(0, 58)

#End Region


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

        Me.Size = New Size(303, 200)
        PanelConnection.Visible = True
        Panel_SidConnexion.Visible = False
        Panel_ProfilConnection.Visible = False
        Panel_License.Visible = False

        UserAndPass_Button.Enabled = False
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = True
        Button_License.Enabled = True
    End Sub

    Private Sub Button_License_Click(sender As Object, e As EventArgs) Handles Button_License.Click
        ' License

        Label_point_de_chute.Select()
        Me.Size = New Size(303, 244)

        PanelConnection.Visible = False
        Panel_SidConnexion.Visible = False
        Panel_ProfilConnection.Visible = False
        Panel_License.Visible = True

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = True
        Button_License.Enabled = False
    End Sub
    Private Sub SID_Login_Button_Click(sender As Object, e As EventArgs) Handles SID_Login_Button.Click
        ' Button 1 = SID login '

        Label_point_de_chute.Select()
        Me.Size = New Size(303, 200)

        PanelConnection.Visible = False
        Panel_SidConnexion.Visible = True
        Panel_ProfilConnection.Visible = False

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = False
        Saved_Button.Enabled = True
        Button_License.Enabled = True
    End Sub

    Private Sub Saved_Button_Click(sender As Object, e As EventArgs) Handles Saved_Button.Click

        ' Button 1 = Saved '

        Label_point_de_chute.Select()
        Me.Size = New Size(303, 395)

        PanelConnection.Visible = False
        Panel_SidConnexion.Visible = False
        Panel_ProfilConnection.Visible = True
        Panel_License.Visible = False

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = False
        Button_License.Enabled = True

    End Sub

    Private Sub Launcher()

        Form_Tools.WebBrowser_Synchronisation.Navigate("https://darkorbit-22.bpsecure.com/")
        Label_point_de_chute.Select()
        Form_Tools.Show()
        Form_Tools.TextBox_ProfilSelected.Text = Textbox_Username.Text
        Close()

    End Sub

    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Button_Load.Click

        If Textbox_Username.Text = "Username" And Textbox_Password.Text = "Password" Then
            MessageBox.Show("You should define your username and your password first", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

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
        GalaxyGates_module_Gates_name_gamma_id_3.WebClient_POST_3.Headers.Clear()
        Form_tools.WebClient_POST.Headers.Clear()

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

        UserAndPass_Button.PerformClick()

    End Sub

    Private Sub Portail_Button_Click(sender As Object, e As EventArgs)

        ' button Portal '

        Me.Size = New Size(256, 251)

    End Sub

    Private Sub License_Button_Click(sender As Object, e As EventArgs)

        ' button License '

        Me.Size = New Size(256, 251)

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
        PictureBox_PasswordHider.Image = My.Resources.visibility
    End Sub
    Private Sub PictureBox_PasswordHider_MouseUp(sender As Object, e As EventArgs) Handles PictureBox_PasswordHider.MouseUp
        Textbox_Password.UseSystemPasswordChar = True
        PictureBox_PasswordHider.Image = My.Resources.visibility_off
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil1eyes_MouseDown(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil1eyes.MouseDown
        TextBoxUsernamePasswordProfil1password.UseSystemPasswordChar = False
        PictureBoxUsernamePasswordProfil1eyes.Image = My.Resources.visibility
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil1eyes_MouseUp(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil1eyes.MouseUp
        TextBoxUsernamePasswordProfil1password.UseSystemPasswordChar = True
        PictureBoxUsernamePasswordProfil1eyes.Image = My.Resources.visibility_off
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil2eyes_MouseDown(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil2eyes.MouseDown
        TextBoxUsernamePasswordProfil2password.UseSystemPasswordChar = False
        PictureBoxUsernamePasswordProfil2eyes.Image = My.Resources.visibility
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil2eyes_MouseUp(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil2eyes.MouseUp
        TextBoxUsernamePasswordProfil2password.UseSystemPasswordChar = True
        PictureBoxUsernamePasswordProfil2eyes.Image = My.Resources.visibility_off
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil3eyes_MouseDown(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil3eyes.MouseDown
        TextBoxUsernamePasswordProfil3password.UseSystemPasswordChar = False
        PictureBoxUsernamePasswordProfil3eyes.Image = My.Resources.visibility
    End Sub
    Private Sub PictureBoxUsernamePasswordProfil3eyes_MouseUp(sender As Object, e As EventArgs) Handles PictureBoxUsernamePasswordProfil3eyes.MouseUp
        TextBoxUsernamePasswordProfil3password.UseSystemPasswordChar = True
        PictureBoxUsernamePasswordProfil3eyes.Image = My.Resources.visibility_off
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
        Button_license_verify_Click(Nothing, Nothing)
    End Sub
    Private Sub Button_Profil1_Load_Click(sender As Object, e As EventArgs) Handles Button_Profil1_Load.Click
        '
        If TextBox_UsernamePasswordProfil1username.Text = "Username" And TextBoxUsernamePasswordProfil1password.Text = "Password" Then
            MessageBox.Show("You should define your username and your password first", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ProfilSelected = 1
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.greenBooty
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.prometium
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.prometium

        Textbox_Username.Text = TextBox_UsernamePasswordProfil1username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil1password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 1"
        Button_license_verify_Click(Nothing, Nothing)

        UserAndPass_Button.PerformClick()
        Button_Load.PerformClick()

        Form_Tools.TextBox_Get_Dosid.Text = ""
        GalaxyGates_module_Gates_name_gamma_id_3.WebClient_POST_3.Headers.Clear()
        Form_tools.WebClient_POST.Headers.Clear()
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
        Button_license_verify_Click(Nothing, Nothing)
    End Sub

    Private Sub PictureBox_Profil2_Load_Click(sender As Object, e As EventArgs) Handles Button_Profil2_Load.Click
        '
        ProfilSelected = 2
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.greenBooty
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.prometium
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.prometium

        Textbox_Username.Text = TextBox_UsernamePasswordProfil2username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil2password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 2"
        Button_license_verify_Click(Nothing, Nothing)

        UserAndPass_Button.PerformClick()
        Button_Load.PerformClick()
        Form_Tools.TextBox_Get_Dosid.Text = ""
        GalaxyGates_module_Gates_name_gamma_id_3.WebClient_POST_3.Headers.Clear()
        Form_tools.WebClient_POST.Headers.Clear()
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
        Button_license_verify_Click(Nothing, Nothing)
    End Sub
    Private Sub PictureBox_Profil3_Load_Click(sender As Object, e As EventArgs) Handles Button_Profil3_Load.Click
        '
        ProfilSelected = 3
        PictureBoxUsernamePasswordProfil3view.Image = My.Resources.greenBooty
        PictureBoxUsernamePasswordProfil2view.Image = My.Resources.prometium
        PictureBoxUsernamePasswordProfil1view.Image = My.Resources.prometium

        Textbox_Username.Text = TextBox_UsernamePasswordProfil3username.Text
        Textbox_Password.Text = TextBoxUsernamePasswordProfil3password.Text
        Form_Tools.ComboBox_autologin.Text = "Profil 3"
        Button_license_verify_Click(Nothing, Nothing)

        UserAndPass_Button.PerformClick()
        Button_Load.PerformClick()

        Form_Tools.TextBox_Get_Dosid.Text = ""
        GalaxyGates_module_Gates_name_gamma_id_3.WebClient_POST_3.Headers.Clear()
        Form_tools.WebClient_POST.Headers.Clear()
    End Sub

    Private Sub Textbox_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Load.PerformClick()
        End If
    End Sub


    Private Sub TextBoxUsernamePasswordProfil2password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUsernamePasswordProfil2password.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBoxUsernamePasswordProfil3view_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub TextBoxUsernamePasswordProfil3password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUsernamePasswordProfil3password.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBoxUsernamePasswordProfil3view_Click(Nothing, Nothing)
        End If
    End Sub

    Private Async Sub Button_license_verify_Click(sender As Object, e As EventArgs) Handles Button_license_verify.Click
        Button_Load.Enabled = False
        Button_Profil1_Load.Enabled = False

        If String.IsNullOrWhiteSpace(TextBox_license_email.Text) Or
            Not TextBox_license_email.Text.Contains("@") Or
            Not TextBox_license_email.Text.Contains(".") Or
            TextBox_license_email.Text.Contains(" ") Or
            TextBox_license_email.Text = "Email" Then
            MessageBox.Show("You didn't put a correct mail", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Picturebox image
            PictureBox_license_check.Image = My.Resources.error_icon
            PictureBox_license_check.Tag = False
            '--
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TextBox_license_password.Text) Or
            TextBox_license_password.Text = "Your Password" Then
            MessageBox.Show("You can't send an empty password", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Picturebox image
            PictureBox_license_check.Image = My.Resources.error_icon
            PictureBox_license_check.Tag = False
            '--
            Exit Sub
        End If

        Try
            Dim utilisateur = Await lefromage.SignInWithEmailAndPasswordAsync(TextBox_license_email.Text, TextBox_license_password.Text)
            If utilisateur.User.Email <> "" Then

            End If

            'Console.WriteLine(utilisateur.User.IsEmailVerified)
            'If Not utilisateur.User.IsEmailVerified Then
            '    MessageBox.Show($"Your account is not verified.{vbNewLine}{vbNewLine}" +
            '                    $"Please open a ticket on the discord to send a verification mail.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If

        Catch ex As Exception
            Console.WriteLine("Message")
            'Console.WriteLine(ex.Message)
            If ex.Message.Contains("INVALID_PASSWORD") Then
                MessageBox.Show("Your account doesn't match our database.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Message.Contains("EMAIL_NOT_FOUND") Then
                MessageBox.Show("Your account doesn't match our database.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Message.Contains("USER_DISABLED") Then
                MessageBox.Show($"Your account is disabled.{vbNewLine}{vbNewLine}" +
                                $"It means that you didn't pay the license !{vbNewLine}{vbNewLine}" +
                                $"Start a new ticket to be able to re-enable it", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'Picturebox image
            PictureBox_license_check.Image = My.Resources.error_icon
            PictureBox_license_check.Tag = False
            '--
            Exit Sub
        End Try

        'Picturebox image
        PictureBox_license_check.Image = My.Resources.success_icon
        PictureBox_license_check.Tag = True
        '--
        Button_Load.Enabled = True
        Button_Profil1_Load.Enabled = True
    End Sub

    Private Async Sub Timer_Flashing_Tick(sender As Object, e As EventArgs) Handles Timer_Flashing.Tick
        If PictureBox_license_check.Tag = False Then
            PictureBox_License_Flashing.Image = My.Resources.error_icon
            Await Task.Delay(250)
            PictureBox_License_Flashing.Image = My.Resources.error_icon_orange
        Else
            PictureBox_License_Flashing.Image = My.Resources.success_icon
        End If
    End Sub

    Private Sub Button_License_MouseMove(sender As Object, e As MouseEventArgs) Handles Button_License.MouseMove
        'Console.WriteLine("true")
        PictureBox_License_Flashing.BackColor = Color.FromArgb(24, 90, 189)
    End Sub

    Private Sub Button_License_MouseLeave(sender As Object, e As EventArgs) Handles Button_License.MouseLeave
        PictureBox_License_Flashing.BackColor = Color.FromArgb(20, 75, 158)
    End Sub



    Private Sub Form_Startup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form_Tools.Button_revive_sid.Enabled = True

    End Sub

    'If e.KeyCode = Keys.Enter Then
    '    Button_License_Verify.PerformClick()
    'End If

End Class