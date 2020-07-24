Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Form_Startup

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(Utils.NumberToHumanReadable(875425))
#Region "Location and resize"
        Panel4.Location = New Point(0, 55)
        Panel4.Size = New Size(256, 221)

        Panel3.Location = New Point(0, 37)
        Panel2.Location = New Point(0, 37)
        PanelConnection.Location = New Point(0, 37)

        Panel5.Location = New Point(0, 55)
        Panel6.Location = New Point(0, 55)
#End Region

        ' program started'

        Me.Size = New Size(256, 251)
        CenterToScreen()
        Label1.Select()

        ' Profil 1
        ' Profil 2
        ' Profil 3
        ' Current

        If Form_Tools.CheckBox_AutoLogin.Checked = True Then

            If Form_Tools.ComboBox_autologin.Text = "Profil 1" Then

                Label1.Select()

            Else
                If Form_Tools.ComboBox_autologin.Text = "Profil 2" Then

                    Label1.Select()

                Else
                    If Form_Tools.ComboBox_autologin.Text = "Profil 3" Then

                        Label1.Select()

                    Else
                        If Form_Tools.ComboBox_autologin.Text = "Current" Then

                            If Form_Tools.CheckBox_LaunchGameAuto.Checked = True Then
                                Form_Game.Show()
                            Else

                            End If
                            Label1.Select()
                            Form_Tools.Show()
                            Close()

                        Else



                        End If
                    End If
                End If
            End If

        Else



        End If


    End Sub

    Private Sub UserAndPass_Button_Click(sender As Object, e As EventArgs) Handles UserAndPass_Button.Click

        ' Button 1 = User && Pass '

        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Label1.Select()

        PanelConnection.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False

        UserAndPass_Button.Enabled = False
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = True



    End Sub

    Private Sub SID_Login_Button_Click(sender As Object, e As EventArgs) Handles SID_Login_Button.Click

        ' Button 1 = SID login '

        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
        Label1.Select()

        PanelConnection.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = False
        Saved_Button.Enabled = True

    End Sub

    Private Sub Saved_Button_Click(sender As Object, e As EventArgs) Handles Saved_Button.Click

        ' Button 1 = Saved '

        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        Label1.Select()

        PanelConnection.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = False

    End Sub

    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Load_Button.Click

        ' button Load 1 > User&&Pass > RidevBot Browser '
        If Form_Tools.CheckBox_LaunchGameAuto.Checked = True Then

            Label1.Select()
            Form_Game.Show()
            Form_Tools.Show()
            Me.Close()

        Else

            Label1.Select()
            Form_Tools.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

        ' button Remove > Saved '

        Label1.Select()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        ' button Edit > Saved '

        Label1.Select()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button_loadprofil.Click

        ' button Load > Saved '

        Label1.Select()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        ' button Load > SID login '

        Label1.Select()
        Utils.server = TextBox1.Text
        Utils.dosid = TextBox3.Text

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

        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = False

        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = True

        Credentials_Button.Enabled = False
        Portail_Button.Enabled = True
        License_Button.Enabled = True

    End Sub

    Private Sub Portail_Button_Click(sender As Object, e As EventArgs) Handles Portail_Button.Click

        ' button Portal '

        Panel4.Visible = False
        Panel5.Visible = True
        Panel6.Visible = False

        Label8.Visible = False
        Label9.Visible = True
        Label10.Visible = False

        Credentials_Button.Enabled = True
        Portail_Button.Enabled = False
        License_Button.Enabled = True

    End Sub

    Private Sub License_Button_Click(sender As Object, e As EventArgs) Handles License_Button.Click

        ' button License '

        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True

        Label8.Visible = True
        Label9.Visible = False
        Label10.Visible = False

        Credentials_Button.Enabled = True
        Portail_Button.Enabled = True
        License_Button.Enabled = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        ' button browser Ridevbot '

        Label11.Visible = True
        Label12.Visible = False
        Load_Button.Visible = True
        Button4.Visible = False

        Button15.Enabled = False
        Button16.Enabled = True

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        ' button browser launcher '

        Label11.Visible = False
        Label12.Visible = True

        Load_Button.Visible = False
        Button4.Visible = True

        Button15.Enabled = True
        Button16.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' button Load 2 > User&&Pass > Launcher'

        Label1.Select()

    End Sub

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CloseForm.ShowDialog(Me)
    End Sub

    Private Sub PictureBox_PasswordHider_MouseDown(sender As Object, e As EventArgs) Handles PictureBox_PasswordHider.MouseDown
        Password_Textbox.UseSystemPasswordChar = False
        PictureBox_PasswordHider.Image = My.Resources._remove_red_eye_90161
    End Sub
    Private Sub PictureBox_PasswordHider_MouseUp(sender As Object, e As EventArgs) Handles PictureBox_PasswordHider.MouseUp
        Password_Textbox.UseSystemPasswordChar = True
        PictureBox_PasswordHider.Image = My.Resources.eye_off_icon_135658
    End Sub

    Private Sub Button_profil1_Click(sender As Object, e As EventArgs) Handles Button_profil1.Click

        Label22.Visible = True
        Label23.Visible = False
        Label24.Visible = False

        Button_profil1.Enabled = True
        Button_profil2.Enabled = False
        Button_profil3.Enabled = False


    End Sub

    Private Sub Button_profil2_Click(sender As Object, e As EventArgs) Handles Button_profil2.Click

        Label22.Visible = False
        Label23.Visible = True
        Label24.Visible = False

        Button_profil1.Enabled = False
        Button_profil2.Enabled = True
        Button_profil3.Enabled = False

    End Sub

    Private Sub Button_profil3_Click(sender As Object, e As EventArgs) Handles Button_profil3.Click

        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = True

        Button_profil1.Enabled = False
        Button_profil2.Enabled = False
        Button_profil3.Enabled = True

    End Sub

End Class
