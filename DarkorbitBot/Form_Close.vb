Public Class CloseForm
    Dim formToClose As String
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        formToClose = Owner.Name
    End Sub
    Private Sub Yes_button_Click(sender As Object, e As EventArgs) Handles Yes_button.Click
        'MsgBox(formToClose)
        Form_Tools.TopMost = True
        Form_Tools.TopMost = False
        Owner.Close()
        Close()
    End Sub

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        Close()
    End Sub

    Private Sub No_button_Click(sender As Object, e As EventArgs) Handles No_button.Click
        Close()
    End Sub

    Private Sub Button_CloseAllForm_Click(sender As Object, e As EventArgs) Handles Button_CloseAllForm.Click
        Form_Startup.Close()
        BackPage_Form.Close()
        Form_Game.Close()
        Form_Tools.Close()
        Close()
    End Sub
End Class