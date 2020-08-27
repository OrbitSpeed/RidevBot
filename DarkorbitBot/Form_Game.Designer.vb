<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Game))
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Red_dots_function = New System.Windows.Forms.Button()
        Me.Alpha_module = New System.Windows.Forms.Button()
        Me.Button_REX = New System.Windows.Forms.Button()
        Me.Button_cargobox = New System.Windows.Forms.Button()
        Me.Label_PerformanceMemoire = New System.Windows.Forms.Label()
        Me.Button_Traveling_Module = New System.Windows.Forms.Button()
        Me.Label_map_location = New System.Windows.Forms.Label()
        Me.Button_Bot = New System.Windows.Forms.Button()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.TextBox_getserver = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker_Performance = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Startup_Bot = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Detection_minimap = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Reduce_minimap = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Deplacement_minimap_bas_droite = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Checking_minimap = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.WebBrowser_Game_Ridevbot = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(0, -1)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(141, 20)
        Me.Label_Title.TabIndex = 22
        Me.Label_Title.Text = "RidevBot Browser | "
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel7.Controls.Add(Me.Button25)
        Me.Panel7.Controls.Add(Me.Red_dots_function)
        Me.Panel7.Controls.Add(Me.Alpha_module)
        Me.Panel7.Controls.Add(Me.Button_REX)
        Me.Panel7.Controls.Add(Me.Button_cargobox)
        Me.Panel7.Controls.Add(Me.Label_PerformanceMemoire)
        Me.Panel7.Controls.Add(Me.Button_Traveling_Module)
        Me.Panel7.Controls.Add(Me.Label_map_location)
        Me.Panel7.Controls.Add(Me.Button_Bot)
        Me.Panel7.Controls.Add(Me.PictureBox_Close)
        Me.Panel7.Controls.Add(Me.Label_Title)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 18)
        Me.Panel7.TabIndex = 27
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(286, -1)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(89, 19)
        Me.Button25.TabIndex = 36
        Me.Button25.Text = "random move"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Red_dots_function
        '
        Me.Red_dots_function.Location = New System.Drawing.Point(598, -1)
        Me.Red_dots_function.Name = "Red_dots_function"
        Me.Red_dots_function.Size = New System.Drawing.Size(58, 19)
        Me.Red_dots_function.TabIndex = 35
        Me.Red_dots_function.Text = "red dots"
        Me.Red_dots_function.UseVisualStyleBackColor = True
        '
        'Alpha_module
        '
        Me.Alpha_module.Location = New System.Drawing.Point(559, -1)
        Me.Alpha_module.Name = "Alpha_module"
        Me.Alpha_module.Size = New System.Drawing.Size(47, 19)
        Me.Alpha_module.TabIndex = 34
        Me.Alpha_module.Text = "Alpha"
        Me.Alpha_module.UseVisualStyleBackColor = True
        '
        'Button_REX
        '
        Me.Button_REX.Location = New System.Drawing.Point(526, -1)
        Me.Button_REX.Name = "Button_REX"
        Me.Button_REX.Size = New System.Drawing.Size(40, 19)
        Me.Button_REX.TabIndex = 33
        Me.Button_REX.Text = "REX"
        Me.Button_REX.UseVisualStyleBackColor = True
        '
        'Button_cargobox
        '
        Me.Button_cargobox.Location = New System.Drawing.Point(463, -1)
        Me.Button_cargobox.Name = "Button_cargobox"
        Me.Button_cargobox.Size = New System.Drawing.Size(64, 19)
        Me.Button_cargobox.TabIndex = 31
        Me.Button_cargobox.Text = "Cargobox"
        Me.Button_cargobox.UseVisualStyleBackColor = True
        '
        'Label_PerformanceMemoire
        '
        Me.Label_PerformanceMemoire.AutoSize = True
        Me.Label_PerformanceMemoire.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PerformanceMemoire.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_PerformanceMemoire.Location = New System.Drawing.Point(135, -1)
        Me.Label_PerformanceMemoire.Name = "Label_PerformanceMemoire"
        Me.Label_PerformanceMemoire.Size = New System.Drawing.Size(96, 20)
        Me.Label_PerformanceMemoire.TabIndex = 32
        Me.Label_PerformanceMemoire.Text = "RAM Used: 0"
        '
        'Button_Traveling_Module
        '
        Me.Button_Traveling_Module.Location = New System.Drawing.Point(407, -2)
        Me.Button_Traveling_Module.Name = "Button_Traveling_Module"
        Me.Button_Traveling_Module.Size = New System.Drawing.Size(57, 20)
        Me.Button_Traveling_Module.TabIndex = 30
        Me.Button_Traveling_Module.Text = "Traveling"
        Me.Button_Traveling_Module.UseVisualStyleBackColor = True
        '
        'Label_map_location
        '
        Me.Label_map_location.AutoSize = True
        Me.Label_map_location.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_map_location.Location = New System.Drawing.Point(708, -1)
        Me.Label_map_location.Name = "Label_map_location"
        Me.Label_map_location.Size = New System.Drawing.Size(74, 20)
        Me.Label_map_location.TabIndex = 31
        Me.Label_map_location.Text = "Map : 0-0"
        '
        'Button_Bot
        '
        Me.Button_Bot.Location = New System.Drawing.Point(373, -1)
        Me.Button_Bot.Name = "Button_Bot"
        Me.Button_Bot.Size = New System.Drawing.Size(35, 19)
        Me.Button_Bot.TabIndex = 29
        Me.Button_Bot.Text = "bot"
        Me.Button_Bot.UseVisualStyleBackColor = True
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox_Close.Image = Global.DarkorbitBot.My.Resources.Resources.img_cross_full
        Me.PictureBox_Close.Location = New System.Drawing.Point(782, 0)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Close.TabIndex = 30
        Me.PictureBox_Close.TabStop = False
        '
        'TextBox_getserver
        '
        Me.TextBox_getserver.Location = New System.Drawing.Point(12, 24)
        Me.TextBox_getserver.Name = "TextBox_getserver"
        Me.TextBox_getserver.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_getserver.TabIndex = 28
        '
        'BackgroundWorker_Performance
        '
        Me.BackgroundWorker_Performance.WorkerSupportsCancellation = True
        '
        'BackgroundWorker_Startup_Bot
        '
        Me.BackgroundWorker_Startup_Bot.WorkerSupportsCancellation = True
        '
        'BackgroundWorker_Detection_minimap
        '
        Me.BackgroundWorker_Detection_minimap.WorkerSupportsCancellation = True
        '
        'BackgroundWorker_Reduce_minimap
        '
        Me.BackgroundWorker_Reduce_minimap.WorkerSupportsCancellation = True
        '
        'BackgroundWorker_Deplacement_minimap_bas_droite
        '
        Me.BackgroundWorker_Deplacement_minimap_bas_droite.WorkerSupportsCancellation = True
        '
        'BackgroundWorker_Checking_minimap
        '
        Me.BackgroundWorker_Checking_minimap.WorkerSupportsCancellation = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 19)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Aider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(0, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 19)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Recruit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Green
        Me.Button3.Location = New System.Drawing.Point(0, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 19)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "streuner"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Green
        Me.Button4.Location = New System.Drawing.Point(0, 53)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 19)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Lordakia"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Green
        Me.Button5.Location = New System.Drawing.Point(0, 70)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 19)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Boss streuner"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.Green
        Me.Button6.Location = New System.Drawing.Point(0, 87)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(78, 19)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Boss lordakia"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.Color.Green
        Me.Button7.Location = New System.Drawing.Point(0, 105)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(78, 19)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "Saimon"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.ForeColor = System.Drawing.Color.Green
        Me.Button8.Location = New System.Drawing.Point(-1, 123)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 19)
        Me.Button8.TabIndex = 41
        Me.Button8.Text = "Boss Saimon"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.Color.Green
        Me.Button9.Location = New System.Drawing.Point(-1, 159)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(79, 19)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "Boss Mordon"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.ForeColor = System.Drawing.Color.Green
        Me.Button10.Location = New System.Drawing.Point(-1, 141)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(79, 19)
        Me.Button10.TabIndex = 42
        Me.Button10.Text = "Mordon"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(-1, 195)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(79, 19)
        Me.Button11.TabIndex = 45
        Me.Button11.Text = "Boss devo"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(-1, 177)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(79, 19)
        Me.Button12.TabIndex = 44
        Me.Button12.Text = "devo"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(-1, 231)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(79, 19)
        Me.Button13.TabIndex = 47
        Me.Button13.Text = "Boss sibelon"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(-1, 213)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(79, 19)
        Me.Button14.TabIndex = 46
        Me.Button14.Text = "Sibelon"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(-1, 267)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(79, 19)
        Me.Button15.TabIndex = 49
        Me.Button15.Text = "Boss sibelonit"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(-1, 249)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(79, 19)
        Me.Button16.TabIndex = 48
        Me.Button16.Text = "Sibelonit"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(-1, 303)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(79, 34)
        Me.Button17.TabIndex = 51
        Me.Button17.Text = "Boss Lordakium"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(-1, 285)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(79, 19)
        Me.Button18.TabIndex = 50
        Me.Button18.Text = "Lordakium"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(-1, 387)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(79, 19)
        Me.Button19.TabIndex = 53
        Me.Button19.Text = "Boss Kristallin"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(-1, 369)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(79, 19)
        Me.Button20.TabIndex = 52
        Me.Button20.Text = "Kristallin"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(-1, 423)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(79, 38)
        Me.Button21.TabIndex = 55
        Me.Button21.Text = "Boss kristallon"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(-1, 405)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(79, 19)
        Me.Button22.TabIndex = 54
        Me.Button22.Text = "Kristallon"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(-1, 478)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(79, 43)
        Me.Button23.TabIndex = 57
        Me.Button23.Text = "Boss StreuneR"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(-1, 460)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(79, 19)
        Me.Button24.TabIndex = 56
        Me.Button24.Text = "StreuneR"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'WebBrowser_Game_Ridevbot
        '
        Me.WebBrowser_Game_Ridevbot.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser_Game_Ridevbot.Location = New System.Drawing.Point(0, 18)
        Me.WebBrowser_Game_Ridevbot.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser_Game_Ridevbot.Name = "WebBrowser_Game_Ridevbot"
        Me.WebBrowser_Game_Ridevbot.ScriptErrorsSuppressed = True
        Me.WebBrowser_Game_Ridevbot.ScrollBarsEnabled = False
        Me.WebBrowser_Game_Ridevbot.Size = New System.Drawing.Size(800, 600)
        Me.WebBrowser_Game_Ridevbot.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button26)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button23)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button24)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button21)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button22)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button19)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button20)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button17)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button18)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Location = New System.Drawing.Point(0, 434)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 180)
        Me.Panel1.TabIndex = 59
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(-1, 336)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(79, 34)
        Me.Button26.TabIndex = 58
        Me.Button26.Text = "*Lordakium spore*"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Form_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.WebBrowser_Game_Ridevbot)
        Me.Controls.Add(Me.TextBox_getserver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RidevBot"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser_Game_Ridevbot As WebBrowser
    Friend WithEvents Button_Backpage As FlatButton
    Friend WithEvents Button_Click As FlatButton
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents Label_Title As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents TextBox_getserver As TextBox
    Friend WithEvents Button_Bot As Button
    Friend WithEvents Button_Traveling_Module As Button
    Friend WithEvents Button_cargobox As Button
    Friend WithEvents Label_map_location As Label
    Friend WithEvents BackgroundWorker_Performance As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label_PerformanceMemoire As Label
    Friend WithEvents BackgroundWorker_Startup_Bot As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_Detection_minimap As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_Reduce_minimap As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_Deplacement_minimap_bas_droite As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_Checking_minimap As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button_REX As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents Alpha_module As Button
    Friend WithEvents Red_dots_function As Button
    Friend WithEvents Button25 As Button
End Class
