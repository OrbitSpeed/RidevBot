Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label3.Visible = True
        Label1.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label3.Visible = False
        Label1.Visible = True
        'testaze
    End Sub
End Class