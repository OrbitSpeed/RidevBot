
Imports FireSharp
Imports FireSharp.Config

Public Class ConnectionForm

    Private client As FirebaseClient

    Public fcon As New FirebaseConfig() With
        {
        .BasePath = "https://ridevbot-2cd86.firebaseio.com/",
        .AuthSecret = Utils.Firebase_Secret
        }



    Private Sub ConnectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FirebaseClient(fcon)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button_reg_Click(sender As Object, e As EventArgs) Handles Button_reg.Click
        If String.IsNullOrWhiteSpace(TextBox_username.Text) AndAlso String.IsNullOrWhiteSpace(TextBox_password.Text) Then
            MsgBox("null")
            Return
        End If

        Dim res = client.Get("Users/" + TextBox_username.Text)
        Dim resUser = res.ResultAs(Of Utilisateur)
        Dim CurUser As New Utilisateur() With
            {
            .NomUtilisateur = TextBox_username.Text,
            .PasswordUtilisateur = TextBox_password.Text,
            .License = Date.Now.AddDays(30)
            }

        If Utilisateur.IsEqual(resUser, CurUser) Then
            MsgBox("Your account already exist")
        Else
            Dim setter = client.Set("Users/" + TextBox_username.Text, CurUser)
            MessageBox.Show("Your account is now added")

        End If


    End Sub

    Private Sub Button_connect_Click(sender As Object, e As EventArgs) Handles Button_connect.Click
        If String.IsNullOrWhiteSpace(TextBox_username.Text) AndAlso String.IsNullOrWhiteSpace(TextBox_password.Text) Then
            MsgBox("null")
            Return
        End If

        Dim res = client.Get("Users/" + TextBox_username.Text)
        Dim resUser = res.ResultAs(Of Utilisateur)

        Dim CurUser As New Utilisateur With
            {
            .NomUtilisateur = TextBox_username.Text,
            .PasswordUtilisateur = TextBox_password.Text,
            .License = Date.Now
            }

        If Utilisateur.IsEqual(resUser, CurUser) Then
            If resUser.License.CompareTo(Date.Now) = -1 Then
                MsgBox("t'as pas payé enculé")
                Exit Sub
            End If

            MsgBox($"Welcome {resUser.NomUtilisateur}")
        Else
            MsgBox("Can't find your account, check your credentials")
        End If

    End Sub
End Class