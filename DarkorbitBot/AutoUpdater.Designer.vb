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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoUpdater))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatLabel_Title = New DarkorbitBot.FlatLabel()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.FlatTextBox_Changelog = New System.Windows.Forms.TextBox()
        Me.Panel_utilites = New System.Windows.Forms.Panel()
        Me.FlatLabel_Version = New DarkorbitBot.FlatLabel()
        Me.FlatLabel_isUpdated = New DarkorbitBot.FlatLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.FlatLabel_isUpdated)
        Me.Panel1.Controls.Add(Me.FlatLabel_Version)
        Me.Panel1.Controls.Add(Me.FlatLabel_Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 18)
        Me.Panel1.TabIndex = 0
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
        Me.FlatLabel_Title.Size = New System.Drawing.Size(102, 20)
        Me.FlatLabel_Title.TabIndex = 1
        Me.FlatLabel_Title.Text = "Auto Updater"
        Me.FlatLabel_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Update
        '
        Me.Button_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Update.Enabled = False
        Me.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Update.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.ForeColor = System.Drawing.Color.White
        Me.Button_Update.Location = New System.Drawing.Point(113, 8)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(138, 34)
        Me.Button_Update.TabIndex = 33
        Me.Button_Update.Text = "Continue"
        Me.Button_Update.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, -8)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(363, 292)
        Me.AxWindowsMediaPlayer1.TabIndex = 100
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
        'Panel_utilites
        '
        Me.Panel_utilites.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel_utilites.Location = New System.Drawing.Point(163, 316)
        Me.Panel_utilites.Name = "Panel_utilites"
        Me.Panel_utilites.Size = New System.Drawing.Size(200, 105)
        Me.Panel_utilites.TabIndex = 102
        '
        'FlatLabel_Version
        '
        Me.FlatLabel_Version.AutoSize = True
        Me.FlatLabel_Version.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_Version.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel_Version.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel_Version.Location = New System.Drawing.Point(96, -1)
        Me.FlatLabel_Version.Name = "FlatLabel_Version"
        Me.FlatLabel_Version.Size = New System.Drawing.Size(116, 20)
        Me.FlatLabel_Version.TabIndex = 3
        Me.FlatLabel_Version.Text = "Version : 0.0.0.0"
        '
        'FlatLabel_isUpdated
        '
        Me.FlatLabel_isUpdated.AutoSize = True
        Me.FlatLabel_isUpdated.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_isUpdated.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel_isUpdated.ForeColor = System.Drawing.Color.Lime
        Me.FlatLabel_isUpdated.Location = New System.Drawing.Point(228, -1)
        Me.FlatLabel_isUpdated.Name = "FlatLabel_isUpdated"
        Me.FlatLabel_isUpdated.Size = New System.Drawing.Size(135, 20)
        Me.FlatLabel_isUpdated.TabIndex = 4
        Me.FlatLabel_isUpdated.Text = "You are up to date"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button_Update)
        Me.Panel2.Location = New System.Drawing.Point(0, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 152)
        Me.Panel2.TabIndex = 103
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(66, 315)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(232, 22)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 104
        Me.ProgressBar1.Value = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(113, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 34)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Cancel AutoLogin"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AutoUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(363, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.FlatTextBox_Changelog)
        Me.Controls.Add(Me.Panel_utilites)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AutoUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdater"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlatLabel_Title As FlatLabel
    Friend WithEvents FlatLabel_Version As FlatLabel
    Friend WithEvents FlatLabel_isUpdated As FlatLabel
    Friend WithEvents Button_Update As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents FlatTextBox_Changelog As TextBox
    Friend WithEvents Panel_utilites As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
End Class
