<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AutoUpdater
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoUpdater))
        Me.Panel_title = New System.Windows.Forms.Panel()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.FlatTextBox_Changelog = New System.Windows.Forms.TextBox()
        Me.Panel_continue = New System.Windows.Forms.Panel()
        Me.ProgressBar_cancel_autotlogin = New System.Windows.Forms.ProgressBar()
        Me.Button_cancel_auto_login = New System.Windows.Forms.Button()
        Me.Timer_bar_cancel_auto_login = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox_Loading_Image = New System.Windows.Forms.PictureBox()
        Me.FlatLabel_isUpdated = New DarkorbitBot.FlatLabel()
        Me.FlatLabel_Version = New DarkorbitBot.FlatLabel()
        Me.FlatLabel_Title = New DarkorbitBot.FlatLabel()
        Me.Panel_title.SuspendLayout()
        Me.Panel_continue.SuspendLayout()
        CType(Me.PictureBox_Loading_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_title
        '
        Me.Panel_title.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel_title.Controls.Add(Me.FlatLabel_isUpdated)
        Me.Panel_title.Controls.Add(Me.FlatLabel_Version)
        Me.Panel_title.Controls.Add(Me.FlatLabel_Title)
        Me.Panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_title.Name = "Panel_title"
        Me.Panel_title.Size = New System.Drawing.Size(363, 18)
        Me.Panel_title.TabIndex = 0
        '
        'Button_Update
        '
        Me.Button_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Update.Enabled = False
        Me.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Update.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.ForeColor = System.Drawing.Color.White
        Me.Button_Update.Location = New System.Drawing.Point(115, 106)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(185, 40)
        Me.Button_Update.TabIndex = 33
        Me.Button_Update.Text = "Continue"
        Me.Button_Update.UseVisualStyleBackColor = False
        Me.Button_Update.Visible = False
        '
        'FlatTextBox_Changelog
        '
        Me.FlatTextBox_Changelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.FlatTextBox_Changelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlatTextBox_Changelog.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatTextBox_Changelog.Location = New System.Drawing.Point(19, 201)
        Me.FlatTextBox_Changelog.Multiline = True
        Me.FlatTextBox_Changelog.Name = "FlatTextBox_Changelog"
        Me.FlatTextBox_Changelog.Size = New System.Drawing.Size(327, 127)
        Me.FlatTextBox_Changelog.TabIndex = 101
        '
        'Panel_continue
        '
        Me.Panel_continue.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel_continue.Controls.Add(Me.ProgressBar_cancel_autotlogin)
        Me.Panel_continue.Controls.Add(Me.Button_cancel_auto_login)
        Me.Panel_continue.Location = New System.Drawing.Point(0, 191)
        Me.Panel_continue.Name = "Panel_continue"
        Me.Panel_continue.Size = New System.Drawing.Size(363, 217)
        Me.Panel_continue.TabIndex = 103
        '
        'ProgressBar_cancel_autotlogin
        '
        Me.ProgressBar_cancel_autotlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ProgressBar_cancel_autotlogin.ForeColor = System.Drawing.Color.White
        Me.ProgressBar_cancel_autotlogin.Location = New System.Drawing.Point(18, 0)
        Me.ProgressBar_cancel_autotlogin.MarqueeAnimationSpeed = 200
        Me.ProgressBar_cancel_autotlogin.Name = "ProgressBar_cancel_autotlogin"
        Me.ProgressBar_cancel_autotlogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar_cancel_autotlogin.Size = New System.Drawing.Size(327, 15)
        Me.ProgressBar_cancel_autotlogin.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_cancel_autotlogin.TabIndex = 104
        '
        'Button_cancel_auto_login
        '
        Me.Button_cancel_auto_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_cancel_auto_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_cancel_auto_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cancel_auto_login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cancel_auto_login.ForeColor = System.Drawing.Color.White
        Me.Button_cancel_auto_login.Location = New System.Drawing.Point(89, 27)
        Me.Button_cancel_auto_login.Name = "Button_cancel_auto_login"
        Me.Button_cancel_auto_login.Size = New System.Drawing.Size(185, 26)
        Me.Button_cancel_auto_login.TabIndex = 105
        Me.Button_cancel_auto_login.Text = "Cancel AutoLogin"
        Me.Button_cancel_auto_login.UseVisualStyleBackColor = False
        '
        'Timer_bar_cancel_auto_login
        '
        Me.Timer_bar_cancel_auto_login.Enabled = True
        Me.Timer_bar_cancel_auto_login.Interval = 8
        '
        'PictureBox_Loading_Image
        '
        Me.PictureBox_Loading_Image.Image = Global.DarkorbitBot.My.Resources.Resources.ridevbotuniverse_gif
        Me.PictureBox_Loading_Image.Location = New System.Drawing.Point(0, 18)
        Me.PictureBox_Loading_Image.Name = "PictureBox_Loading_Image"
        Me.PictureBox_Loading_Image.Size = New System.Drawing.Size(363, 173)
        Me.PictureBox_Loading_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Loading_Image.TabIndex = 106
        Me.PictureBox_Loading_Image.TabStop = False
        '
        'FlatLabel_isUpdated
        '
        Me.FlatLabel_isUpdated.AutoSize = True
        Me.FlatLabel_isUpdated.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_isUpdated.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel_isUpdated.ForeColor = System.Drawing.Color.Lime
        Me.FlatLabel_isUpdated.Location = New System.Drawing.Point(193, -1)
        Me.FlatLabel_isUpdated.Name = "FlatLabel_isUpdated"
        Me.FlatLabel_isUpdated.Size = New System.Drawing.Size(135, 20)
        Me.FlatLabel_isUpdated.TabIndex = 4
        Me.FlatLabel_isUpdated.Text = "You are up to date"
        '
        'FlatLabel_Version
        '
        Me.FlatLabel_Version.AutoSize = True
        Me.FlatLabel_Version.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_Version.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel_Version.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel_Version.Location = New System.Drawing.Point(60, -1)
        Me.FlatLabel_Version.Name = "FlatLabel_Version"
        Me.FlatLabel_Version.Size = New System.Drawing.Size(116, 20)
        Me.FlatLabel_Version.TabIndex = 3
        Me.FlatLabel_Version.Text = "Version : 0.0.0.0"
        '
        'FlatLabel_Title
        '
        Me.FlatLabel_Title.AutoSize = True
        Me.FlatLabel_Title.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel_Title.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel_Title.Location = New System.Drawing.Point(0, -1)
        Me.FlatLabel_Title.Name = "FlatLabel_Title"
        Me.FlatLabel_Title.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlatLabel_Title.Size = New System.Drawing.Size(65, 20)
        Me.FlatLabel_Title.TabIndex = 1
        Me.FlatLabel_Title.Text = "Updater"
        Me.FlatLabel_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutoUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(363, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox_Loading_Image)
        Me.Controls.Add(Me.Panel_title)
        Me.Controls.Add(Me.Panel_continue)
        Me.Controls.Add(Me.FlatTextBox_Changelog)
        Me.Controls.Add(Me.Button_Update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AutoUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdater"
        Me.Panel_title.ResumeLayout(False)
        Me.Panel_title.PerformLayout()
        Me.Panel_continue.ResumeLayout(False)
        CType(Me.PictureBox_Loading_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_title As Panel
    Friend WithEvents FlatLabel_Title As FlatLabel
    Friend WithEvents FlatLabel_Version As FlatLabel
    Friend WithEvents FlatLabel_isUpdated As FlatLabel
    Friend WithEvents Button_Update As Button
    Friend WithEvents FlatTextBox_Changelog As TextBox
    Friend WithEvents Panel_continue As Panel
    Friend WithEvents ProgressBar_cancel_autotlogin As ProgressBar
    Friend WithEvents Button_cancel_auto_login As Button
    Friend WithEvents Timer_bar_cancel_auto_login As Timer
    Friend WithEvents PictureBox_Loading_Image As PictureBox
End Class
