<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackPage_Form
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackPage_Form))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel_Bar = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.FlatMax1 = New DarkorbitBot.FlatMax()
        Me.FlatMini1 = New DarkorbitBot.FlatMini()
        Me.Panel_Bar.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 17)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(800, 583)
        Me.WebBrowser1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 18)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "RidevBot Backpage"
        '
        'Panel_Bar
        '
        Me.Panel_Bar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel_Bar.Controls.Add(Me.FlatMax1)
        Me.Panel_Bar.Controls.Add(Me.FlatMini1)
        Me.Panel_Bar.Controls.Add(Me.PictureBox_Close)
        Me.Panel_Bar.Controls.Add(Me.Label16)
        Me.Panel_Bar.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Panel_Bar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Bar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Bar.Name = "Panel_Bar"
        Me.Panel_Bar.Size = New System.Drawing.Size(800, 18)
        Me.Panel_Bar.TabIndex = 24
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
        'FlatMax1
        '
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.SystemColors.HotTrack
        Me.FlatMax1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(746, 0)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 31
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.Black
        '
        'FlatMini1
        '
        Me.FlatMini1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlatMini1.BaseColor = System.Drawing.Color.Empty
        Me.FlatMini1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatMini1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(764, 0)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 29
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.Black
        '
        'BackPage_Form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel_Bar)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BackPage_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackPage_Form"
        Me.Panel_Bar.ResumeLayout(False)
        Me.Panel_Bar.PerformLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel_Bar As Panel
    Friend WithEvents FlatMax1 As FlatMax
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents PictureBox_Close As PictureBox
End Class
