Imports System.Runtime.InteropServices

Public Class Utils
#Region "Cookie Manager"
    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function InternetSetCookie(lpszUrl As String,
      lpszCookieName As String, lpszCookieData As String) As Boolean
    End Function
#End Region

#Region "Déclarations"
    'Used everywhere
    Public Shared dosid As String
    Public Shared server As String
    Public Shared connectWithCookie As Boolean = False

    'Used in backpage + form_tools (to get all data (uri,cred etc..)
    Public Shared checkStats As Boolean = False

    Public Shared currentUridium As String = 0
    Public Shared currentCredits As String = 0
    Public Shared currentXP As String = 0
    Public Shared currentLevel As String = 0
    Public Shared currentHonnor As String = 0
    Public Shared currentRankPoints As String = 0

    Public Shared Sub UpdateStats()
        If Not currentUridium = "0" Then
            Form_Tools.TextBox_creditCurrent.Text = currentCredits
            Form_Tools.TextBox_uridiumCurrent.Text = currentUridium
            Form_Tools.TextBox_uridiumGGS.Text = currentUridium
            Form_Tools.TextBox_honorCurrent.Text = currentHonnor
            Form_Tools.TextBox_LevelCurrent.Text = currentLevel
            Form_Tools.TextBox_experienceCurrent.Text = currentXP
            Form_Tools.TextBox_RPCurrent.Text = currentRankPoints
        End If
    End Sub

#End Region
    Public Shared Function NumberToHumanReadable(number As Integer)
        Dim numberHuman As String = ""
        Dim numberString As String = number.ToString
        Dim revNumberString As String = StrReverse(numberString) 'on inverse le résultat
        Dim newNumberString As String = ""
        Dim first As Boolean = True

        For Each n As String In revNumberString
            numberHuman = n + numberHuman
            If numberHuman.Length = 3 Then
                If first Then
                    first = False
                    ' permet d'éviter de mettre un point en trop
                    newNumberString = numberHuman
                    numberHuman = ""
                Else
                    'On met un point entre chaque nombre
                    newNumberString = numberHuman + "." + newNumberString
                    numberHuman = ""
                End If

            End If
        Next

        Return newNumberString
    End Function

End Class
