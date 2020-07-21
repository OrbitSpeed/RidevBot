Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Form1

    Public BOL_Redimensionnement As Boolean 'variable publique pour stocker le redimensionnement
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function InternetSetCookie(lpszUrl As String,
      lpszCookieName As String, lpszCookieData As String) As Boolean
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' program started'

        Me.Size = New Size(256, 251)

        Label1.Select()

    End Sub

    Private Sub UserAndPass_Button_Click(sender As Object, e As EventArgs) Handles UserAndPass_Button.Click

        ' Button 1 = User && Pass '

        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Label1.Select()

        PanelConnection.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False

        UserAndPass_Button.Enabled = False
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = True



    End Sub

    Private Sub SID_Login_Button_Click(sender As Object, e As EventArgs) Handles SID_Login_Button.Click

        ' Button 1 = SID login '

        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
        Label1.Select()

        PanelConnection.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = False
        Saved_Button.Enabled = True

    End Sub

    Private Sub Saved_Button_Click(sender As Object, e As EventArgs) Handles Saved_Button.Click

        ' Button 1 = Saved '

        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        Label1.Select()

        PanelConnection.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True

        UserAndPass_Button.Enabled = True
        SID_Login_Button.Enabled = True
        Saved_Button.Enabled = False

    End Sub

    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Load_Button.Click

        ' button Load 1 > User&&Pass > RidevBot Browser '

        Label1.Select()
        Form2.Show()
        Form3.Show()


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
        Dim server1 = TextBox1.Text
        Dim dosid = TextBox3.Text

        InternetSetCookie("https://" + server1 + ".darkorbit.com/indexInternal.es?action=internalStart", "dosid", dosid & ";")

        Form2.Show()
        Form2.WebBrowser1.Navigate("https://" + ((server1)) + ".darkorbit.com/indexInternal.es?action=internalStart&prc=100")
        ' Form2.WebBrowser1.Navigate("https://" + ((server)) + ".darkorbit.com/indexInternal.es?action=internalMapRevolution")

    End Sub

    Private Sub Credentials_Button_Click(sender As Object, e As EventArgs) Handles Credentials_Button.Click

        ' button credentials '

        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = False

        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = True

        Credentials_Button.Enabled = False
        Portail_Button.Enabled = True
        License_Button.Enabled = True

    End Sub

    Private Sub Portail_Button_Click(sender As Object, e As EventArgs) Handles Portail_Button.Click

        ' button Portal '

        Panel4.Visible = False
        Panel5.Visible = True
        Panel6.Visible = False

        Label8.Visible = False
        Label9.Visible = True
        Label10.Visible = False

        Credentials_Button.Enabled = True
        Portail_Button.Enabled = False
        License_Button.Enabled = True

    End Sub

    Private Sub License_Button_Click(sender As Object, e As EventArgs) Handles License_Button.Click

        ' button License '

        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True

        Label8.Visible = True
        Label9.Visible = False
        Label10.Visible = False

        Credentials_Button.Enabled = True
        Portail_Button.Enabled = True
        License_Button.Enabled = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        ' button browser Ridevbot '

        Label11.Visible = True
        Label12.Visible = False
        Load_Button.Visible = True
        Button4.Visible = False

        Button15.Enabled = False
        Button16.Enabled = True

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        ' button browser launcher '

        Label11.Visible = False
        Label12.Visible = True

        Load_Button.Visible = False
        Button4.Visible = True

        Button15.Enabled = True
        Button16.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' button Load 2 > User&&Pass > Launcher'

        Label1.Select()

    End Sub

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

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
