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

    Public Shared Function NumberToHumanReadable(number As String, espacement As String)
        If espacement = "" Then
            Debug.WriteLine("espacement est NUL !!!!")
            Return False
        Else
            Dim numberHuman As String = ""
            Dim revNumberString As String = StrReverse(number) 'on inverse le résultat
            Dim newNumberString As String = ""
            Dim first As Boolean = True
            Dim second As Boolean = True

            For Each n As String In revNumberString
                numberHuman = n + numberHuman
                'Console.WriteLine("avant:" + numberHuman)

                If numberHuman.Length = 3 Then
                    If first Then
                        first = False
                        'permet d'éviter de mettre un point en trop
                        newNumberString = espacement + numberHuman
                        numberHuman = ""
                    Else
                        If second Then
                            second = False
                            'On ne met pas un espacement entre chaque nombre car déjà mis dans first
                            newNumberString = numberHuman + newNumberString
                            Console.WriteLine("2nd>" + newNumberString)
                            numberHuman = ""
                        Else
                            'On met un espacement entre chaque nombre car on en a plus
                            newNumberString = numberHuman + espacement + newNumberString
                            numberHuman = ""
                        End If

                    End If
                End If
                'Console.WriteLine("apres:" + numberHuman)
            Next
            If Not numberHuman.Length = 0 Then
                newNumberString = numberHuman + newNumberString
            End If
            Return newNumberString
        End If

    End Function

    Public Shared Function ReplaceAllFromTo(text As String, fromText As String, toText As String)
        Dim newText As String
        newText = text.Replace(fromText, toText)

        Return newText
    End Function

End Class
