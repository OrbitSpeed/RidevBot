Public Class User_module
    Public Property NomUtilisateur As String
    Public Property PasswordUtilisateur As String
    Public Property LicenseEndTime As Date
    Public Property LicenseKey As String
    Public Property LicenseActivated As Boolean
    Public Property UserMail As String

    Public Shared Function IsEqual(user1 As User_module, user2 As User_module)
        If user1 Is Nothing Or user2 Is Nothing Then
            'MessageBox.Show("Can't find your account")
            Return False
        End If

        If user1.NomUtilisateur <> user2.NomUtilisateur Then
            'MessageBox.Show("Can't find your account")
            Return False
        ElseIf user1.PasswordUtilisateur <> user2.PasswordUtilisateur Then
            'MessageBox.Show("The username and the password doesn't match our database")
            Return False
        End If
        Return True

    End Function
End Class
