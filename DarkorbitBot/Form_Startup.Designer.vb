<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Startup
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Startup))
        Me.UserAndPass_Button = New System.Windows.Forms.Button()
        Me.SID_Login_Button = New System.Windows.Forms.Button()
        Me.Saved_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.PictureBox_PasswordHider = New System.Windows.Forms.PictureBox()
        Me.Load_Button = New System.Windows.Forms.Button()
        Me.Label_password = New System.Windows.Forms.Label()
        Me.Textbox_Username = New System.Windows.Forms.TextBox()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Textbox_Password = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_serverExemple = New System.Windows.Forms.Label()
        Me.TextBox_server = New System.Windows.Forms.TextBox()
        Me.Label_server = New System.Windows.Forms.Label()
        Me.Button_SID_Load = New System.Windows.Forms.Button()
        Me.TextBox_sid = New System.Windows.Forms.TextBox()
        Me.Label_sid = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button_profil3 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button_profil2 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button_profil1 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button_removeprofil = New System.Windows.Forms.Button()
        Me.button_editprofil = New System.Windows.Forms.Button()
        Me.Button_loadprofil = New System.Windows.Forms.Button()
        Me.Credentials_Button = New System.Windows.Forms.Button()
        Me.Portail_Button = New System.Windows.Forms.Button()
        Me.License_Button = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button_License_Verify = New System.Windows.Forms.Button()
        Me.TextBox_license = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.FlatMini = New DarkorbitBot.FlatMini()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.PanelConnection.SuspendLayout()
        CType(Me.PictureBox_PasswordHider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel_Title.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserAndPass_Button
        '
        Me.UserAndPass_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.UserAndPass_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UserAndPass_Button.Enabled = False
        Me.UserAndPass_Button.FlatAppearance.BorderSize = 0
        Me.UserAndPass_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserAndPass_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserAndPass_Button.ForeColor = System.Drawing.Color.White
        Me.UserAndPass_Button.Location = New System.Drawing.Point(0, 0)
        Me.UserAndPass_Button.Name = "UserAndPass_Button"
        Me.UserAndPass_Button.Size = New System.Drawing.Size(86, 35)
        Me.UserAndPass_Button.TabIndex = 3
        Me.UserAndPass_Button.Text = "User && Pass"
        Me.UserAndPass_Button.UseVisualStyleBackColor = False
        '
        'SID_Login_Button
        '
        Me.SID_Login_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.SID_Login_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SID_Login_Button.FlatAppearance.BorderSize = 0
        Me.SID_Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SID_Login_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SID_Login_Button.ForeColor = System.Drawing.Color.White
        Me.SID_Login_Button.Location = New System.Drawing.Point(85, 0)
        Me.SID_Login_Button.Name = "SID_Login_Button"
        Me.SID_Login_Button.Size = New System.Drawing.Size(86, 35)
        Me.SID_Login_Button.TabIndex = 4
        Me.SID_Login_Button.Text = "SID login"
        Me.SID_Login_Button.UseVisualStyleBackColor = False
        '
        'Saved_Button
        '
        Me.Saved_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Saved_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Saved_Button.FlatAppearance.BorderSize = 0
        Me.Saved_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Saved_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saved_Button.ForeColor = System.Drawing.Color.White
        Me.Saved_Button.Location = New System.Drawing.Point(170, 0)
        Me.Saved_Button.Name = "Saved_Button"
        Me.Saved_Button.Size = New System.Drawing.Size(86, 35)
        Me.Saved_Button.TabIndex = 5
        Me.Saved_Button.Text = "Saved"
        Me.Saved_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-2, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "_________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "_________"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(169, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "_________"
        Me.Label4.Visible = False
        '
        'PanelConnection
        '
        Me.PanelConnection.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelConnection.Controls.Add(Me.PictureBox_PasswordHider)
        Me.PanelConnection.Controls.Add(Me.Load_Button)
        Me.PanelConnection.Controls.Add(Me.Label_password)
        Me.PanelConnection.Controls.Add(Me.Textbox_Username)
        Me.PanelConnection.Controls.Add(Me.Label_username)
        Me.PanelConnection.Controls.Add(Me.Button4)
        Me.PanelConnection.Controls.Add(Me.Textbox_Password)
        Me.PanelConnection.ForeColor = System.Drawing.Color.White
        Me.PanelConnection.Location = New System.Drawing.Point(17, 222)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(256, 160)
        Me.PanelConnection.TabIndex = 10
        '
        'PictureBox_PasswordHider
        '
        Me.PictureBox_PasswordHider.Image = Global.DarkorbitBot.My.Resources.Resources.img_eyeOpen
        Me.PictureBox_PasswordHider.Location = New System.Drawing.Point(236, 88)
        Me.PictureBox_PasswordHider.Name = "PictureBox_PasswordHider"
        Me.PictureBox_PasswordHider.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox_PasswordHider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_PasswordHider.TabIndex = 22
        Me.PictureBox_PasswordHider.TabStop = False
        '
        'Load_Button
        '
        Me.Load_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Load_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Load_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load_Button.Location = New System.Drawing.Point(159, 123)
        Me.Load_Button.Name = "Load_Button"
        Me.Load_Button.Size = New System.Drawing.Size(86, 25)
        Me.Load_Button.TabIndex = 19
        Me.Load_Button.Text = "Load"
        Me.Load_Button.UseVisualStyleBackColor = False
        '
        'Label_password
        '
        Me.Label_password.AutoSize = True
        Me.Label_password.Location = New System.Drawing.Point(12, 70)
        Me.Label_password.Name = "Label_password"
        Me.Label_password.Size = New System.Drawing.Size(59, 13)
        Me.Label_password.TabIndex = 14
        Me.Label_password.Text = "Password :"
        '
        'Textbox_Username
        '
        Me.Textbox_Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Textbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_Username.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DarkorbitBot.My.MySettings.Default, "Username", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Textbox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_Username.ForeColor = System.Drawing.Color.White
        Me.Textbox_Username.Location = New System.Drawing.Point(0, 32)
        Me.Textbox_Username.Name = "Textbox_Username"
        Me.Textbox_Username.Size = New System.Drawing.Size(256, 21)
        Me.Textbox_Username.TabIndex = 13
        Me.Textbox_Username.Text = Global.DarkorbitBot.My.MySettings.Default.Username
        Me.Textbox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_username
        '
        Me.Label_username.AutoSize = True
        Me.Label_username.Location = New System.Drawing.Point(12, 16)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(61, 13)
        Me.Label_username.TabIndex = 12
        Me.Label_username.Text = "Username :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(159, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 25)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Textbox_Password
        '
        Me.Textbox_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Textbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox_Password.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DarkorbitBot.My.MySettings.Default, "Password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Textbox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_Password.ForeColor = System.Drawing.Color.White
        Me.Textbox_Password.Location = New System.Drawing.Point(0, 86)
        Me.Textbox_Password.Name = "Textbox_Password"
        Me.Textbox_Password.Size = New System.Drawing.Size(256, 21)
        Me.Textbox_Password.TabIndex = 21
        Me.Textbox_Password.Text = Global.DarkorbitBot.My.MySettings.Default.Password
        Me.Textbox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Textbox_Password.UseSystemPasswordChar = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Label_serverExemple)
        Me.Panel2.Controls.Add(Me.TextBox_server)
        Me.Panel2.Controls.Add(Me.Label_server)
        Me.Panel2.Controls.Add(Me.Button_SID_Load)
        Me.Panel2.Controls.Add(Me.TextBox_sid)
        Me.Panel2.Controls.Add(Me.Label_sid)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(17, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 160)
        Me.Panel2.TabIndex = 11
        Me.Panel2.Visible = False
        '
        'Label_serverExemple
        '
        Me.Label_serverExemple.AutoSize = True
        Me.Label_serverExemple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_serverExemple.Location = New System.Drawing.Point(67, 83)
        Me.Label_serverExemple.Name = "Label_serverExemple"
        Me.Label_serverExemple.Size = New System.Drawing.Size(121, 13)
        Me.Label_serverExemple.TabIndex = 21
        Me.Label_serverExemple.Text = "Server exemple : fr1"
        '
        'TextBox_server
        '
        Me.TextBox_server.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.TextBox_server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_server.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_server.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DarkorbitBot.My.MySettings.Default, "server", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox_server.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_server.ForeColor = System.Drawing.Color.White
        Me.TextBox_server.Location = New System.Drawing.Point(62, 19)
        Me.TextBox_server.Name = "TextBox_server"
        Me.TextBox_server.Size = New System.Drawing.Size(46, 20)
        Me.TextBox_server.TabIndex = 16
        Me.TextBox_server.Text = Global.DarkorbitBot.My.MySettings.Default.server
        Me.TextBox_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_server
        '
        Me.Label_server.AutoSize = True
        Me.Label_server.Location = New System.Drawing.Point(12, 23)
        Me.Label_server.Name = "Label_server"
        Me.Label_server.Size = New System.Drawing.Size(44, 13)
        Me.Label_server.TabIndex = 19
        Me.Label_server.Text = "Server :"
        '
        'Button_SID_Load
        '
        Me.Button_SID_Load.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_SID_Load.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_SID_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SID_Load.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SID_Load.Location = New System.Drawing.Point(159, 123)
        Me.Button_SID_Load.Name = "Button_SID_Load"
        Me.Button_SID_Load.Size = New System.Drawing.Size(86, 25)
        Me.Button_SID_Load.TabIndex = 18
        Me.Button_SID_Load.Text = "Load"
        Me.Button_SID_Load.UseVisualStyleBackColor = False
        '
        'TextBox_sid
        '
        Me.TextBox_sid.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.TextBox_sid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_sid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_sid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_sid.ForeColor = System.Drawing.Color.White
        Me.TextBox_sid.Location = New System.Drawing.Point(47, 45)
        Me.TextBox_sid.Name = "TextBox_sid"
        Me.TextBox_sid.Size = New System.Drawing.Size(197, 20)
        Me.TextBox_sid.TabIndex = 17
        Me.TextBox_sid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_sid
        '
        Me.Label_sid.AutoSize = True
        Me.Label_sid.Location = New System.Drawing.Point(12, 49)
        Me.Label_sid.Name = "Label_sid"
        Me.Label_sid.Size = New System.Drawing.Size(31, 13)
        Me.Label_sid.TabIndex = 16
        Me.Label_sid.Text = "SID :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.Button_profil3)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Button_profil2)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Button_profil1)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Button_removeprofil)
        Me.Panel3.Controls.Add(Me.button_editprofil)
        Me.Panel3.Controls.Add(Me.Button_loadprofil)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(17, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 160)
        Me.Panel3.TabIndex = 11
        Me.Panel3.Visible = False
        '
        'Button_profil3
        '
        Me.Button_profil3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_profil3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_profil3.FlatAppearance.BorderSize = 0
        Me.Button_profil3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_profil3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_profil3.ForeColor = System.Drawing.Color.White
        Me.Button_profil3.Location = New System.Drawing.Point(9, 79)
        Me.Button_profil3.Name = "Button_profil3"
        Me.Button_profil3.Size = New System.Drawing.Size(236, 35)
        Me.Button_profil3.TabIndex = 22
        Me.Button_profil3.Text = "Profil 3 = none"
        Me.Button_profil3.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(7, 97)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(242, 18)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "__________________________"
        Me.Label24.Visible = False
        '
        'Button_profil2
        '
        Me.Button_profil2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_profil2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_profil2.FlatAppearance.BorderSize = 0
        Me.Button_profil2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_profil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_profil2.ForeColor = System.Drawing.Color.White
        Me.Button_profil2.Location = New System.Drawing.Point(9, 43)
        Me.Button_profil2.Name = "Button_profil2"
        Me.Button_profil2.Size = New System.Drawing.Size(236, 35)
        Me.Button_profil2.TabIndex = 21
        Me.Button_profil2.Text = "Profil 2 = none"
        Me.Button_profil2.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(7, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(242, 18)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "__________________________"
        Me.Label23.Visible = False
        '
        'Button_profil1
        '
        Me.Button_profil1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_profil1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_profil1.FlatAppearance.BorderSize = 0
        Me.Button_profil1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_profil1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_profil1.ForeColor = System.Drawing.Color.White
        Me.Button_profil1.Location = New System.Drawing.Point(9, 7)
        Me.Button_profil1.Name = "Button_profil1"
        Me.Button_profil1.Size = New System.Drawing.Size(236, 35)
        Me.Button_profil1.TabIndex = 20
        Me.Button_profil1.Text = "Profil 1 = none"
        Me.Button_profil1.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(7, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(242, 18)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "__________________________"
        Me.Label22.Visible = False
        '
        'Button_removeprofil
        '
        Me.Button_removeprofil.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_removeprofil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_removeprofil.Enabled = False
        Me.Button_removeprofil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_removeprofil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_removeprofil.Location = New System.Drawing.Point(67, 123)
        Me.Button_removeprofil.Name = "Button_removeprofil"
        Me.Button_removeprofil.Size = New System.Drawing.Size(75, 25)
        Me.Button_removeprofil.TabIndex = 24
        Me.Button_removeprofil.Text = "Remove"
        Me.Button_removeprofil.UseVisualStyleBackColor = False
        '
        'button_editprofil
        '
        Me.button_editprofil.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.button_editprofil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_editprofil.Enabled = False
        Me.button_editprofil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_editprofil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_editprofil.Location = New System.Drawing.Point(9, 123)
        Me.button_editprofil.Name = "button_editprofil"
        Me.button_editprofil.Size = New System.Drawing.Size(53, 25)
        Me.button_editprofil.TabIndex = 23
        Me.button_editprofil.Text = "Edit"
        Me.button_editprofil.UseVisualStyleBackColor = False
        '
        'Button_loadprofil
        '
        Me.Button_loadprofil.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_loadprofil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_loadprofil.Enabled = False
        Me.Button_loadprofil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_loadprofil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_loadprofil.Location = New System.Drawing.Point(159, 123)
        Me.Button_loadprofil.Name = "Button_loadprofil"
        Me.Button_loadprofil.Size = New System.Drawing.Size(86, 25)
        Me.Button_loadprofil.TabIndex = 19
        Me.Button_loadprofil.Text = "Load"
        Me.Button_loadprofil.UseVisualStyleBackColor = False
        '
        'Credentials_Button
        '
        Me.Credentials_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Credentials_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Credentials_Button.Enabled = False
        Me.Credentials_Button.FlatAppearance.BorderSize = 0
        Me.Credentials_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Credentials_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credentials_Button.ForeColor = System.Drawing.Color.White
        Me.Credentials_Button.Location = New System.Drawing.Point(0, 18)
        Me.Credentials_Button.Name = "Credentials_Button"
        Me.Credentials_Button.Size = New System.Drawing.Size(86, 35)
        Me.Credentials_Button.TabIndex = 12
        Me.Credentials_Button.Text = "Credentials"
        Me.Credentials_Button.UseVisualStyleBackColor = False
        '
        'Portail_Button
        '
        Me.Portail_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Portail_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Portail_Button.FlatAppearance.BorderSize = 0
        Me.Portail_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Portail_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Portail_Button.ForeColor = System.Drawing.Color.White
        Me.Portail_Button.Location = New System.Drawing.Point(86, 18)
        Me.Portail_Button.Name = "Portail_Button"
        Me.Portail_Button.Size = New System.Drawing.Size(84, 35)
        Me.Portail_Button.TabIndex = 13
        Me.Portail_Button.Text = "Portal"
        Me.Portail_Button.UseVisualStyleBackColor = False
        '
        'License_Button
        '
        Me.License_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.License_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.License_Button.FlatAppearance.BorderSize = 0
        Me.License_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.License_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.License_Button.ForeColor = System.Drawing.Color.White
        Me.License_Button.Location = New System.Drawing.Point(170, 18)
        Me.License_Button.Name = "License_Button"
        Me.License_Button.Size = New System.Drawing.Size(86, 35)
        Me.License_Button.TabIndex = 14
        Me.License_Button.Text = "License"
        Me.License_Button.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(169, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "_________"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(83, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "_________"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-2, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "_________"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Saved_Button)
        Me.Panel4.Controls.Add(Me.SID_Login_Button)
        Me.Panel4.Controls.Add(Me.UserAndPass_Button)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.PanelConnection)
        Me.Panel4.Location = New System.Drawing.Point(412, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(289, 562)
        Me.Panel4.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel5.Controls.Add(Me.Button15)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Button16)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(86, 314)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(256, 197)
        Me.Panel5.TabIndex = 19
        Me.Panel5.Visible = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Enabled = False
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(67, 31)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(121, 35)
        Me.Button15.TabIndex = 18
        Me.Button15.Text = "RidevBot Browser"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(70, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "____________"
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(67, 72)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(121, 47)
        Me.Button16.TabIndex = 20
        Me.Button16.Text = "Official Launcher Browser"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(70, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "____________"
        Me.Label12.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.Button_License_Verify)
        Me.Panel6.Controls.Add(Me.TextBox_license)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.ForeColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(86, 111)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(256, 197)
        Me.Panel6.TabIndex = 20
        Me.Panel6.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(141, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "FREE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(71, 98)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "0d 00:00:00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 98)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Time left :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(148, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "FREE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(97, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "no Valid"
        '
        'Button_License_Verify
        '
        Me.Button_License_Verify.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_License_Verify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_License_Verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_License_Verify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_License_Verify.Location = New System.Drawing.Point(159, 160)
        Me.Button_License_Verify.Name = "Button_License_Verify"
        Me.Button_License_Verify.Size = New System.Drawing.Size(86, 25)
        Me.Button_License_Verify.TabIndex = 20
        Me.Button_License_Verify.Text = "Verify"
        Me.Button_License_Verify.UseVisualStyleBackColor = False
        '
        'TextBox_license
        '
        Me.TextBox_license.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.TextBox_license.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_license.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_license.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DarkorbitBot.My.MySettings.Default, "License", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox_license.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_license.ForeColor = System.Drawing.Color.White
        Me.TextBox_license.Location = New System.Drawing.Point(0, 36)
        Me.TextBox_license.Name = "TextBox_license"
        Me.TextBox_license.Size = New System.Drawing.Size(256, 20)
        Me.TextBox_license.TabIndex = 18
        Me.TextBox_license.Text = Global.DarkorbitBot.My.MySettings.Default.License
        Me.TextBox_license.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(61, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Valid"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Status :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "License :"
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel_Title.Controls.Add(Me.FlatMini)
        Me.Panel_Title.Controls.Add(Me.PictureBox_Close)
        Me.Panel_Title.Controls.Add(Me.Label_Title)
        Me.Panel_Title.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(256, 18)
        Me.Panel_Title.TabIndex = 23
        '
        'FlatMini
        '
        Me.FlatMini.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatMini.BaseColor = System.Drawing.Color.Empty
        Me.FlatMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatMini.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlatMini.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini.Location = New System.Drawing.Point(220, 0)
        Me.FlatMini.Name = "FlatMini"
        Me.FlatMini.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini.TabIndex = 24
        Me.FlatMini.Text = "FlatMini"
        Me.FlatMini.TextColor = System.Drawing.Color.Black
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox_Close.Image = Global.DarkorbitBot.My.Resources.Resources.img_cross_full
        Me.PictureBox_Close.Location = New System.Drawing.Point(238, 0)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Close.TabIndex = 24
        Me.PictureBox_Close.TabStop = False
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(2, 0)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(140, 18)
        Me.Label_Title.TabIndex = 22
        Me.Label_Title.Text = "RidevBot v0.0.0.0"
        '
        'Form_Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1052, 671)
        Me.Controls.Add(Me.License_Button)
        Me.Controls.Add(Me.Portail_Button)
        Me.Controls.Add(Me.Credentials_Button)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RidevBot"
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        CType(Me.PictureBox_PasswordHider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Title.PerformLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserAndPass_Button As Button
    Friend WithEvents SID_Login_Button As Button
    Friend WithEvents Saved_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents Label_password As Label
    Friend WithEvents Textbox_Username As TextBox
    Friend WithEvents Label_username As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox_sid As TextBox
    Friend WithEvents Label_sid As Label
    Friend WithEvents Load_Button As Button
    Friend WithEvents Button_SID_Load As Button
    Friend WithEvents Button_loadprofil As Button
    Friend WithEvents Credentials_Button As Button
    Friend WithEvents Portail_Button As Button
    Friend WithEvents License_Button As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button15 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button16 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_license As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Label_Title As Label
    Friend WithEvents TextBox_server As TextBox
    Friend WithEvents Label_server As Label
    Friend WithEvents Label_serverExemple As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button_License_Verify As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents FlatMini As FlatMini
    Friend WithEvents PictureBox_PasswordHider As PictureBox
    Friend WithEvents Button_removeprofil As Button
    Friend WithEvents button_editprofil As Button
    Friend WithEvents Button_profil3 As Button
    Friend WithEvents Button_profil2 As Button
    Friend WithEvents Button_profil1 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Textbox_Password As TextBox
End Class
