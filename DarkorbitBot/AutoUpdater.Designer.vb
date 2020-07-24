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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlatLabel_isUpdated = New DarkorbitBot.FlatLabel()
        Me.FlatLabel_Version = New DarkorbitBot.FlatLabel()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.FlatTextBox_Changelog = New DarkorbitBot.FlatTextBox()
        Me.FlatLabel_Title = New DarkorbitBot.FlatLabel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 25)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.FlatLabel_isUpdated)
        Me.Panel2.Controls.Add(Me.FlatLabel_Version)
        Me.Panel2.Location = New System.Drawing.Point(-1, 386)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 25)
        Me.Panel2.TabIndex = 1
        '
        'FlatLabel_isUpdated
        '
        Me.FlatLabel_isUpdated.AutoSize = True
        Me.FlatLabel_isUpdated.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_isUpdated.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel_isUpdated.ForeColor = System.Drawing.Color.Lime
        Me.FlatLabel_isUpdated.Location = New System.Drawing.Point(9, 2)
        Me.FlatLabel_isUpdated.Name = "FlatLabel_isUpdated"
        Me.FlatLabel_isUpdated.Size = New System.Drawing.Size(107, 19)
        Me.FlatLabel_isUpdated.TabIndex = 4
        Me.FlatLabel_isUpdated.Text = "Vous êtes à jour"
        Me.FlatLabel_isUpdated.Visible = False
        '
        'FlatLabel_Version
        '
        Me.FlatLabel_Version.AutoSize = True
        Me.FlatLabel_Version.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_Version.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel_Version.ForeColor = System.Drawing.Color.Transparent
        Me.FlatLabel_Version.Location = New System.Drawing.Point(258, 2)
        Me.FlatLabel_Version.Name = "FlatLabel_Version"
        Me.FlatLabel_Version.Size = New System.Drawing.Size(106, 19)
        Me.FlatLabel_Version.TabIndex = 3
        Me.FlatLabel_Version.Text = "Version : 0.0.0.0"
        '
        'Button_Update
        '
        Me.Button_Update.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Update.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.ForeColor = System.Drawing.Color.White
        Me.Button_Update.Location = New System.Drawing.Point(84, 344)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(194, 25)
        Me.Button_Update.TabIndex = 33
        Me.Button_Update.Text = "Verify if an update is available"
        Me.Button_Update.UseVisualStyleBackColor = False
        '
        'FlatTextBox_Changelog
        '
        Me.FlatTextBox_Changelog.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox_Changelog.Location = New System.Drawing.Point(12, 31)
        Me.FlatTextBox_Changelog.MaxLength = 32767
        Me.FlatTextBox_Changelog.Multiline = True
        Me.FlatTextBox_Changelog.Name = "FlatTextBox_Changelog"
        Me.FlatTextBox_Changelog.ReadOnly = True
        Me.FlatTextBox_Changelog.Size = New System.Drawing.Size(339, 305)
        Me.FlatTextBox_Changelog.TabIndex = 3
        Me.FlatTextBox_Changelog.Text = "Downloading the changelog..."
        Me.FlatTextBox_Changelog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox_Changelog.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatTextBox_Changelog.UseSystemPasswordChar = False
        '
        'FlatLabel_Title
        '
        Me.FlatLabel_Title.AutoSize = True
        Me.FlatLabel_Title.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatLabel_Title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel_Title.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel_Title.Location = New System.Drawing.Point(90, 1)
        Me.FlatLabel_Title.Name = "FlatLabel_Title"
        Me.FlatLabel_Title.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlatLabel_Title.Size = New System.Drawing.Size(182, 21)
        Me.FlatLabel_Title.TabIndex = 1
        Me.FlatLabel_Title.Text = "RidevBot AutoUpdater"
        Me.FlatLabel_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutoUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(363, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Update)
        Me.Controls.Add(Me.FlatTextBox_Changelog)
        Me.Controls.Add(Me.FlatLabel_Title)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AutoUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdater"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlatLabel_Title As FlatLabel
    Friend WithEvents FlatLabel_Version As FlatLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlatTextBox_Changelog As FlatTextBox
    Friend WithEvents FlatLabel_isUpdated As FlatLabel
    Friend WithEvents Button_Update As Button
End Class
