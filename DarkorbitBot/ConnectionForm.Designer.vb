<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectionForm
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
        Me.Button_reg = New System.Windows.Forms.Button()
        Me.Button_connect = New System.Windows.Forms.Button()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.Button_validate = New System.Windows.Forms.Button()
        Me.TextBox_license_check = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_reg
        '
        Me.Button_reg.Location = New System.Drawing.Point(78, 258)
        Me.Button_reg.Name = "Button_reg"
        Me.Button_reg.Size = New System.Drawing.Size(75, 23)
        Me.Button_reg.TabIndex = 0
        Me.Button_reg.Text = "reg"
        Me.Button_reg.UseVisualStyleBackColor = True
        '
        'Button_connect
        '
        Me.Button_connect.Location = New System.Drawing.Point(193, 258)
        Me.Button_connect.Name = "Button_connect"
        Me.Button_connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_connect.TabIndex = 0
        Me.Button_connect.Text = "connect"
        Me.Button_connect.UseVisualStyleBackColor = True
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(122, 143)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_username.TabIndex = 1
        Me.TextBox_username.Text = "username"
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(122, 178)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_password.TabIndex = 2
        Me.TextBox_password.Text = "password"
        '
        'Button_validate
        '
        Me.Button_validate.Location = New System.Drawing.Point(344, 175)
        Me.Button_validate.Name = "Button_validate"
        Me.Button_validate.Size = New System.Drawing.Size(327, 23)
        Me.Button_validate.TabIndex = 3
        Me.Button_validate.Text = "validate"
        Me.Button_validate.UseVisualStyleBackColor = True
        '
        'TextBox_license_check
        '
        Me.TextBox_license_check.Location = New System.Drawing.Point(344, 143)
        Me.TextBox_license_check.Name = "TextBox_license_check"
        Me.TextBox_license_check.Size = New System.Drawing.Size(327, 20)
        Me.TextBox_license_check.TabIndex = 4
        Me.TextBox_license_check.Text = "license"
        '
        'ConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox_license_check)
        Me.Controls.Add(Me.Button_validate)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_username)
        Me.Controls.Add(Me.Button_connect)
        Me.Controls.Add(Me.Button_reg)
        Me.Name = "ConnectionForm"
        Me.Text = "ConnectionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_reg As Button
    Friend WithEvents Button_connect As Button
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents Button_validate As Button
    Friend WithEvents TextBox_license_check As TextBox
End Class
