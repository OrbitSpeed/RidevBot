
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
            'Utils.GetNistTime()
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

        Dim CurUser As New User_Database() With
            {
            .GFH51DFGTK_1855577GH7_54SDQAVV = AutoUpdater.A + Utils.getSHA1Hash(TextBox_username.Text) + AutoUpdater.B
                 }
        AutoUpdater.Hashing()
        '.ATDS_K4H_TRT2MM2455784BB_TK2 = Utils.getSHA1Hash(Utils.DateDistant.AddDays(30)),
        '.ATDGS_TK_PASSWORD185424175724557HSDJ1 = Utils.getSHA1Hash(user_key)

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

        Dim resUser = res.ResultAs(Of User_Database)

        Dim CurUser As New User_Database With
            {
                 .GFH51DFGTK_1855577GH7_54SDQAVV = AutoUpdater.A + Utils.getSHA1Hash(TextBox_username.Text) + AutoUpdater.B
            }
        AutoUpdater.Hashing()
        ',
        '            .ATDS_K4H_TRT2MM2455784BB_TK2 = Utils.getSHA1Hash(Utils.DateDistant.AddDays(30)),
        '            .ATDGS_TK_PASSWORD185424175724557HSDJ1 = Utils.getSHA1Hash(user_key)
        'If User_Database.IsEqual(resUser, CurUser) Then
        '    If resUser.ATDS_K4H_TRT2MM2455784BB_TK2.CompareTo(Utils.DateDistant) = -1 Then
        '        MsgBox("t'as pas payé enculé")
        '        Exit Sub
        '    End If

        'MsgBox($"Welcome {resUser.ATDS_K4H_TRT2MM2455784BB_TK1}")
        'Else
        '    MsgBox("Can't find your account, check your credentials")
        'End If

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

        Dim resUser = res.ResultAs(Of User_Database)

        Dim CurUser As New User_Database With
            {
                  .GFH51DFGTK_1855577GH7_54SDQAVV = AutoUpdater.A + Utils.getSHA1Hash(TextBox_username.Text) + AutoUpdater.B
            }
        AutoUpdater.Hashing()
        ',
        '            .ATDS_K4H_TRT2MM2455784BB_TK2 = Utils.getSHA1Hash(Utils.DateDistant.AddDays(30)),
        '            .ATDGS_TK_PASSWORD185424175724557HSDJ1 = Utils.getSHA1Hash(user_key)
        'If Utilisateur.IsEqual(resUser, CurUser) Then
        If resUser.ATDS_K4H_TRT2MM2455784BB_TK2.CompareTo(Utils.DateDistant) = -1 Then
            MsgBox("t'as pas payé enculé")
            Exit Sub
        End If

        MsgBox($"Welcome {resUser.GFH51DFGTK_1855577GH7_54SDQAVV}")
        'Else
        'MsgBox("Can't find your account, check your credentials")
        'End If
    End Sub
End Class