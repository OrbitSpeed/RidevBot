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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WebBrowser_Game_Ridevbot = New System.Windows.Forms.WebBrowser()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.FlatButton2 = New DarkorbitBot.FlatButton()
        Me.TextBox_getserver = New System.Windows.Forms.TextBox()
        Me.FlatButton3 = New DarkorbitBot.FlatButton()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(91, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "000"
        Me.Label2.Visible = False
        '
        'WebBrowser_Game_Ridevbot
        '
        Me.WebBrowser_Game_Ridevbot.Location = New System.Drawing.Point(0, 18)
        Me.WebBrowser_Game_Ridevbot.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser_Game_Ridevbot.Name = "WebBrowser_Game_Ridevbot"
        Me.WebBrowser_Game_Ridevbot.ScriptErrorsSuppressed = True
        Me.WebBrowser_Game_Ridevbot.ScrollBarsEnabled = False
        Me.WebBrowser_Game_Ridevbot.Size = New System.Drawing.Size(800, 600)
        Me.WebBrowser_Game_Ridevbot.TabIndex = 17
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
        Me.Panel7.Controls.Add(Me.PictureBox_Close)
        Me.Panel7.Controls.Add(Me.FlatButton2)
        Me.Panel7.Controls.Add(Me.Label_Title)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 18)
        Me.Panel7.TabIndex = 27
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
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(359, 0)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(147, 18)
        Me.FlatButton2.TabIndex = 25
        Me.FlatButton2.Text = "Click NPC + attack"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatButton2.Visible = False
        '
        'TextBox_getserver
        '
        Me.TextBox_getserver.Location = New System.Drawing.Point(12, 32)
        Me.TextBox_getserver.Name = "TextBox_getserver"
        Me.TextBox_getserver.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_getserver.TabIndex = 28
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(12, 58)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(73, 18)
        Me.FlatButton3.TabIndex = 28
        Me.FlatButton3.Text = "Attack"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatButton3.Visible = False
        '
        'Form_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.WebBrowser_Game_Ridevbot)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.TextBox_getserver)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents WebBrowser_Game_Ridevbot As WebBrowser
    Friend WithEvents Button_Backpage As FlatButton
    Friend WithEvents Button_Click As FlatButton
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents Label_Title As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents TextBox_getserver As TextBox
End Class
