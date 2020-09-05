
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
            Utils.GetNistTime()
            'MsgBox(Utils.GetNistTime)
        Catch ex As Exception
            MessageBox.Show($"Erreur:{ex.ToString}")
        End Try
    End Sub

    Private Sub Button_reg_Click(sender As Object, e As EventArgs) Handles Button_reg.Click
        If String.IsNullOrWhiteSpace(TextBox_username.Text) AndAlso String.IsNullOrWhiteSpace(TextBox_password.Text) Then
            MsgBox("null")
            Return
        End If
        Dim user_key = Utils.getSHA1Hash(TextBox_username.Text)


        Dim res = client.Get("Users/" + user_key)
        Console.WriteLine(res.Body)
        If res.Body <> "null" Then
            MessageBox.Show("Your account already exist")
            Exit Sub
        End If

        Dim CurUser As New Utilisateur() With
            {
            .NomUtilisateur = TextBox_username.Text,
            .PasswordUtilisateur = TextBox_password.Text,
            .LicenseEndTime = Utils.DateDistant.AddDays(30),
            .LicenseKey = user_key,
            .LicenseActivated = False
            }


        Dim setter = client.Set("Users/" + user_key, CurUser)
        Console.WriteLine(setter.Body)
        Console.WriteLine(setter.StatusCode)
        MessageBox.Show("Your account is now added")



    End Sub

    Private Sub Button_connect_Click(sender As Object, e As EventArgs) Handles Button_connect.Click
        If String.IsNullOrWhiteSpace(TextBox_username.Text) AndAlso String.IsNullOrWhiteSpace(TextBox_password.Text) Then
            MsgBox("null")
            Return
        End If
        Dim user_key = Utils.getSHA1Hash(TextBox_username.Text)

        Dim res = client.Get("Users/" + user_key)
        If res.Body = "null" Then
            MessageBox.Show("Your account doesn't exist")
            Exit Sub
        End If

        Dim resUser = res.ResultAs(Of Utilisateur)

        Dim CurUser As New Utilisateur With
            {
            .NomUtilisateur = TextBox_username.Text,
            .PasswordUtilisateur = TextBox_password.Text,
            .LicenseEndTime = Utils.DateDistant,
            .LicenseActivated = False,
            .LicenseKey = user_key
            }

        If Utilisateur.IsEqual(resUser, CurUser) Then
            If resUser.LicenseEndTime.CompareTo(Utils.DateDistant) = -1 Then
                MsgBox("t'as pas payé enculé")
                Exit Sub
            End If

            MsgBox($"Welcome {resUser.NomUtilisateur}")
        Else
            MsgBox("Can't find your account, check your credentials")
        End If

    End Sub

    Private Sub Button_validate_Click(sender As Object, e As EventArgs) Handles Button_validate.Click
        If String.IsNullOrWhiteSpace(TextBox_license_check.Text) Then
            MsgBox("null")
            Return
        End If
        Dim user_key = TextBox_license_check.Text

        Dim res = client.Get("Users/" + user_key)
        If res.Body = "null" Then
            MessageBox.Show("Your account doesn't exist")
            Exit Sub
        End If

        Dim resUser = res.ResultAs(Of Utilisateur)

        Dim CurUser As New Utilisateur With
            {
            .NomUtilisateur = TextBox_username.Text,
            .PasswordUtilisateur = TextBox_password.Text,
            .LicenseEndTime = Utils.DateDistant,
            .LicenseActivated = False,
            .LicenseKey = user_key
            }

        'If Utilisateur.IsEqual(resUser, CurUser) Then
        If resUser.LicenseEndTime.CompareTo(Utils.DateDistant) = -1 Then
            MsgBox("t'as pas payé enculé")
            Exit Sub
        End If

        MsgBox($"Welcome {resUser.NomUtilisateur}")
        'Else
        'MsgBox("Can't find your account, check your credentials")
        'End If
    End Sub
End Class