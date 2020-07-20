Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' program started'

        Me.Size = New Size(272, 273)

        Label1.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Button 1 = User && Pass '

        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Label1.Select()

        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Button 1 = SID login '

        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
        Label1.Select()

        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Button 1 = Saved '

        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        Label1.Select()

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        ' button Load 1 > User&&Pass '

        Label1.Select()
            Form2.Show()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

        ' button Remove > Saved '

        Label1.Select()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        ' button Edit > Saved '

        Label1.Select()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        ' button Load > Saved '

        Label1.Select()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        ' button Load > SID login '

        Label1.Select()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        ' button credentials '

        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = False

        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = True

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        ' button Portal '

        Panel4.Visible = False
        Panel5.Visible = True
        Panel6.Visible = False

        Label8.Visible = False
        Label9.Visible = True
        Label10.Visible = False

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        ' button License '

        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True

        Label8.Visible = True
        Label9.Visible = False
        Label10.Visible = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        ' button browser Ridevbot '

        Label11.Visible = True
        Label12.Visible = False
        Button11.Visible = True
        Button4.Visible = False

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        ' button browser launcher '

        Label11.Visible = False
        Label12.Visible = True

        Button11.Visible = False
        Button4.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' button Load 2 > User&&Pass '

        Label1.Select()

    End Sub
End Class
