<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Msgbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Msgbox))
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Label_Title_contenu = New System.Windows.Forms.Label()
        Me.TextBox_Message_contenu = New System.Windows.Forms.TextBox()
        Me.button_type = New System.Windows.Forms.Button()
        Me.Panel_Title.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel_Title.Controls.Add(Me.Label_Title_contenu)
        Me.Panel_Title.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(338, 18)
        Me.Panel_Title.TabIndex = 24
        '
        'Label_Title_contenu
        '
        Me.Label_Title_contenu.AutoSize = True
        Me.Label_Title_contenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Title_contenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title_contenu.ForeColor = System.Drawing.Color.Black
        Me.Label_Title_contenu.Location = New System.Drawing.Point(2, 0)
        Me.Label_Title_contenu.Name = "Label_Title_contenu"
        Me.Label_Title_contenu.Size = New System.Drawing.Size(80, 18)
        Me.Label_Title_contenu.TabIndex = 22
        Me.Label_Title_contenu.Text = "Title_type"
        '
        'TextBox_Message_contenu
        '
        Me.TextBox_Message_contenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Message_contenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.TextBox_Message_contenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Message_contenu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_Message_contenu.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Message_contenu.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Message_contenu.Location = New System.Drawing.Point(12, 30)
        Me.TextBox_Message_contenu.Multiline = True
        Me.TextBox_Message_contenu.Name = "TextBox_Message_contenu"
        Me.TextBox_Message_contenu.Size = New System.Drawing.Size(314, 105)
        Me.TextBox_Message_contenu.TabIndex = 25
        Me.TextBox_Message_contenu.Text = "Message_type"
        Me.TextBox_Message_contenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'button_type
        '
        Me.button_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.button_type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_type.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_type.Location = New System.Drawing.Point(126, 141)
        Me.button_type.Name = "button_type"
        Me.button_type.Size = New System.Drawing.Size(86, 40)
        Me.button_type.TabIndex = 26
        Me.button_type.Text = "button_type"
        Me.button_type.UseVisualStyleBackColor = False
        '
        'Form_Msgbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(338, 190)
        Me.Controls.Add(Me.button_type)
        Me.Controls.Add(Me.TextBox_Message_contenu)
        Me.Controls.Add(Me.Panel_Title)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Msgbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Msgbox"
        Me.TopMost = True
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Title.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Label_Title_contenu As Label
    Friend WithEvents TextBox_Message_contenu As TextBox
    Friend WithEvents button_type As Button
End Class
