<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.FlatLabel1 = New DarkorbitBot.FlatLabel()
        Me.FlatButton1 = New DarkorbitBot.FlatButton()
        Me.Button_SID = New DarkorbitBot.FlatButton()
        Me.Button_Reload = New DarkorbitBot.FlatButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.FlatClose1 = New DarkorbitBot.FlatClose()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(694, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "000"
        Me.Label2.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 18)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(800, 600)
        Me.WebBrowser1.TabIndex = 17
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Red
        Me.FlatLabel1.Location = New System.Drawing.Point(734, 2)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel1.TabIndex = 24
        Me.FlatLabel1.Text = "⚫"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(301, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(111, 18)
        Me.FlatButton1.TabIndex = 23
        Me.FlatButton1.Text = "Click"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Button_SID
        '
        Me.Button_SID.BackColor = System.Drawing.Color.Transparent
        Me.Button_SID.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button_SID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_SID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button_SID.Location = New System.Drawing.Point(184, 0)
        Me.Button_SID.Name = "Button_SID"
        Me.Button_SID.Rounded = False
        Me.Button_SID.Size = New System.Drawing.Size(111, 18)
        Me.Button_SID.TabIndex = 22
        Me.Button_SID.Text = "Background"
        Me.Button_SID.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Button_Reload
        '
        Me.Button_Reload.BackColor = System.Drawing.Color.Transparent
        Me.Button_Reload.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button_Reload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Reload.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button_Reload.Location = New System.Drawing.Point(67, 0)
        Me.Button_Reload.Name = "Button_Reload"
        Me.Button_Reload.Rounded = False
        Me.Button_Reload.Size = New System.Drawing.Size(111, 18)
        Me.Button_Reload.TabIndex = 21
        Me.Button_Reload.Text = "Reload"
        Me.Button_Reload.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(2, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "RidevBot"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.FlatButton1)
        Me.Panel7.Controls.Add(Me.FlatLabel1)
        Me.Panel7.Controls.Add(Me.Button_SID)
        Me.Panel7.Controls.Add(Me.FlatClose1)
        Me.Panel7.Controls.Add(Me.Button_Reload)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 18)
        Me.Panel7.TabIndex = 27
        '
        'FlatClose1
        '
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(782, 0)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 21
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RidevBot"
        Me.TopMost = True
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button_Reload As FlatButton
    Friend WithEvents Button_SID As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents FlatClose1 As FlatClose
End Class
