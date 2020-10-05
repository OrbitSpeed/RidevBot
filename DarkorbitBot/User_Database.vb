Public Class User_Database

    Public Property ATDGS_TK_PASSWORD185424175724557HSDJ1 As String ' key
    Public Property GFH51DFGTK_1855577GH7_54SDQAVV As String 'NomUtilisateur
    Public Property ATDS_K4H_TRT2MM2455784BB_TK2 As String 'LicenseEndTime







    Public Shared Client_ID As String = "762368770575826945"
    Public Shared Client_Secret As String = "U0ixNeps_xZtBPtbYbV1FFgQbF-rzYDY"
    Public Shared scope_URI As String = "guilds.join%20identify%20email"
    Public Shared redirect_URI As String = "http://127.0.0.1:4335/login"
    Public Shared Parse_ID_URI As String = "http%3A%2F%2F127.0.0.1%3A4335%2Flogin&response_type=code&scope="
    Public Shared Discord_login_URL As String = "https://discord.com/api/oauth2/authorize?client_id=" + Client_ID + Parse_ID_URI + scope_URI

    Public Shared Function Load()

        Process.Start(Discord_login_URL)

    End Function



    Public Shared Function IsEqual(user1 As User_Database, user2 As User_Database)
        If user1 Is Nothing Or user2 Is Nothing Then
            'MessageBox.Show("Can't find your account")
            Return False
        End If

        If user1.GFH51DFGTK_1855577GH7_54SDQAVV <> user2.GFH51DFGTK_1855577GH7_54SDQAVV Then
            'MessageBox.Show("Can't find your account")
            Return False
        End If
        Return True
    End Function




End Class
