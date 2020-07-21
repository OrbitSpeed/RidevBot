Public Class Form_Tools

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove

        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp
            tmp = Nothing
        End If

    End Sub

    Private Sub Panel7_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel7.MouseDown

        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Panel7_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel7.MouseUp

        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel_general.Location = New Point(86, 18)
        Panel_Npc.Location = New Point(86, 18)
        Panel_collector.Location = New Point(86, 18)
        Panel_GalaxyGates.Location = New Point(86, 18)
        Panel_Palladium.Location = New Point(86, 18)
        Panel_stats.Location = New Point(86, 18)
        Panel7.Location = New Point(86, 18)
        Panel_rex.Location = New Point(86, 18)
        Me.Size = New Size(390, 324)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CloseForm1.ShowDialog(Me)
        'CloseForm1.Show()
    End Sub

    Private Sub General_button_Click(sender As Object, e As EventArgs) Handles General_button.Click

        General_button.Enabled = False
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = True
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub NPC_Button_Click(sender As Object, e As EventArgs) Handles NPC_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = False
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = True
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub Collector_Button_Click(sender As Object, e As EventArgs) Handles Collector_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = False
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub GalaxyGates_Button_Click(sender As Object, e As EventArgs) Handles GalaxyGates_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = False
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub Pirates_Button_Click(sender As Object, e As EventArgs) Handles Pirates_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = False
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub Stats_Button_Click(sender As Object, e As EventArgs) Handles Stats_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = False
        Rex_Button.Enabled = True
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
        Label5.Visible = False


    End Sub

    Private Sub Rex_Button_Click(sender As Object, e As EventArgs) Handles Rex_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = False
        Divers_Button.Enabled = True

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        Label5.Visible = False

    End Sub

    Private Sub Divers_Button_Click(sender As Object, e As EventArgs) Handles Divers_Button.Click

        General_button.Enabled = True
        NPC_Button.Enabled = True
        Collector_Button.Enabled = True
        GalaxyGates_Button.Enabled = True
        Pirates_Button.Enabled = True
        Stats_Button.Enabled = True
        Rex_Button.Enabled = True
        Divers_Button.Enabled = False

        Label10.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = True

    End Sub

    Private Sub FlatCheckBox3_CheckedChanged(sender As Object) Handles FlatCheckBox3.CheckedChanged

    End Sub
End Class