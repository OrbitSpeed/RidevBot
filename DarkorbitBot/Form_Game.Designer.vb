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
        Me.Button_REX = New System.Windows.Forms.Button()
        Me.Button_cargobox = New System.Windows.Forms.Button()
        Me.Label_PerformanceMemoire = New System.Windows.Forms.Label()
        Me.Button_bonusbox = New System.Windows.Forms.Button()
        Me.Label_map_location = New System.Windows.Forms.Label()
        Me.Button_Bot = New System.Windows.Forms.Button()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.TextBox_getserver = New System.Windows.Forms.TextBox()
        Me.WebBrowser_Game_Ridevbot = New System.Windows.Forms.WebBrowser()
        Me.BackgroundWorker_Performance = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Startup_Bot = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Detection_minimap = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Reduce_minimap = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Deplacement_minimap_bas_droite = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Checking_minimap = New System.ComponentModel.BackgroundWorker()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(2, 0)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(144, 18)
        Me.Label_Title.TabIndex = 22
        Me.Label_Title.Text = "RidevBot Browser"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel7.Controls.Add(Me.Button_REX)
        Me.Panel7.Controls.Add(Me.Button_cargobox)
        Me.Panel7.Controls.Add(Me.Label_PerformanceMemoire)
        Me.Panel7.Controls.Add(Me.Button_bonusbox)
        Me.Panel7.Controls.Add(Me.Label_map_location)
        Me.Panel7.Controls.Add(Me.Button_Bot)
        Me.Panel7.Controls.Add(Me.PictureBox_Close)
        Me.Panel7.Controls.Add(Me.Label_Title)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 18)
        Me.Panel7.TabIndex = 27
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
        Me.Label_PerformanceMemoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PerformanceMemoire.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_PerformanceMemoire.Location = New System.Drawing.Point(152, 0)
        Me.Label_PerformanceMemoire.Name = "Label_PerformanceMemoire"
        Me.Label_PerformanceMemoire.Size = New System.Drawing.Size(107, 18)
        Me.Label_PerformanceMemoire.TabIndex = 32
        Me.Label_PerformanceMemoire.Text = "RAM Used: 0"
        '
        'Button_bonusbox
        '
        Me.Button_bonusbox.Location = New System.Drawing.Point(400, -2)
        Me.Button_bonusbox.Name = "Button_bonusbox"
        Me.Button_bonusbox.Size = New System.Drawing.Size(64, 20)
        Me.Button_bonusbox.TabIndex = 30
        Me.Button_bonusbox.Text = "Traveling"
        Me.Button_bonusbox.UseVisualStyleBackColor = True
        '
        'Label_map_location
        '
        Me.Label_map_location.AutoSize = True
        Me.Label_map_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_map_location.Location = New System.Drawing.Point(694, 0)
        Me.Label_map_location.Name = "Label_map_location"
        Me.Label_map_location.Size = New System.Drawing.Size(79, 18)
        Me.Label_map_location.TabIndex = 31
        Me.Label_map_location.Text = "Map : 0-0"
        '
        'Button_Bot
        '
        Me.Button_Bot.Location = New System.Drawing.Point(366, -1)
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
        'Form_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 618)
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
    Friend WithEvents Button_bonusbox As Button
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
End Class
