<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloseForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CloseForm1))
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Yes_button = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.No_button = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Donate_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(269, 18)
        Me.Panel7.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 18)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "RidevBot > Close ?"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.DarkorbitBot.My.Resources.Resources.icons8_ios_rempli_50_2_
        Me.PictureBox1.Location = New System.Drawing.Point(251, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Yes_button
        '
        Me.Yes_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Yes_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Yes_button.Enabled = False
        Me.Yes_button.FlatAppearance.BorderSize = 0
        Me.Yes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Yes_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yes_button.Location = New System.Drawing.Point(74, 38)
        Me.Yes_button.Name = "Yes_button"
        Me.Yes_button.Size = New System.Drawing.Size(121, 35)
        Me.Yes_button.TabIndex = 26
        Me.Yes_button.Text = "Yes, Close"
        Me.Yes_button.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(77, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "____________"
        '
        'No_button
        '
        Me.No_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.No_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.No_button.FlatAppearance.BorderSize = 0
        Me.No_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.No_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_button.Location = New System.Drawing.Point(74, 79)
        Me.No_button.Name = "No_button"
        Me.No_button.Size = New System.Drawing.Size(121, 47)
        Me.No_button.TabIndex = 28
        Me.No_button.Text = "No, Go back"
        Me.No_button.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(77, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 18)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "____________"
        Me.Label12.Visible = False
        '
        'Donate_button
        '
        Me.Donate_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Donate_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Donate_button.Enabled = False
        Me.Donate_button.FlatAppearance.BorderSize = 0
        Me.Donate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Donate_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Donate_button.Location = New System.Drawing.Point(74, 132)
        Me.Donate_button.Name = "Donate_button"
        Me.Donate_button.Size = New System.Drawing.Size(121, 35)
        Me.Donate_button.TabIndex = 30
        Me.Donate_button.Text = "Donate !"
        Me.Donate_button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "____________"
        '
        'CloseForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(269, 199)
        Me.Controls.Add(Me.Donate_button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Yes_button)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.No_button)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CloseForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Close1"
        Me.TopMost = True
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Yes_button As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents No_button As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Donate_button As Button
    Friend WithEvents Label1 As Label
End Class
