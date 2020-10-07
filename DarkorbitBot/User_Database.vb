Public Class User_Database


    Public Shared Property ATDGS_TK_PASSWORD185424175724557HSDJ1 As String ' key
    Public Property GFH51DFGTK_1855577GH7_54SDQAVV As String 'NomUtilisateur
    Public Property ATDS_K4H_TRT2MM2455784BB_TK2 As String 'LicenseEndTime

    Public Shared Client_ID As String = "762368770575826945"
    Public Shared Client_Secret As String = "U0ixNeps_xZtBPtbYbV1FFgQbF-rzYDY"
    'Public Shared scope_URI As String = "identify%20gdm.join"
    Public Shared scope_URI As String = "identify"
    Public Shared redirect_URI As String = "http%3A%2F%2Flocalhost%3A1000"
    'Public Shared Parse_ID_URI As String = "&redirect_uri=http%3A%2F%2FRidevbot.oat%3A127A0A0A1&response_type=code&scope="
    Public Shared Parse_ID_URI As String = "&redirect_uri=" + redirect_URI + "&response_type=code&scope="
    Public Shared Discord_login_URL As String = "https://discord.com/api/oauth2/authorize?client_id=" + Client_ID + Parse_ID_URI + scope_URI
    Public Shared WebClient_POST As New System.Net.WebClient
    Public Shared proc As System.Diagnostics.Process
    'https://discord.com/api/oauth2/authorize?client_id=762368770575826945&redirect_uri=http%3A%2F%2Flocalhost%3A1000&response_type=code&scope=identify


    Public Shared Function Load() As Task

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
