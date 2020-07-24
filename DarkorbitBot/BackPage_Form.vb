Public Class BackPage_Form

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    Private Sub Panel_Bar_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Bar.MouseMove

        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp
            tmp = Nothing
        End If

    End Sub

    Private Sub Panel_Bar_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Bar.MouseDown

        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Panel_Bar_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_Bar.MouseUp

        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If

    End Sub

    Private Sub Panel_Bar_DoubleClick(sender As Object, e As PaintEventArgs) Handles Panel_Bar.DoubleClick
        'TODO Quand on aura le temps de fix
        'If Me.WindowState = FormWindowState.Maximized Then
        '    Me.WindowState = FormWindowState.Normal
        'Else
        '    Me.WindowState = FormWindowState.Maximized
        'End If
    End Sub

    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        CloseForm.ShowDialog(Me)
    End Sub

End Class