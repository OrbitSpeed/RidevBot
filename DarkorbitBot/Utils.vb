Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Utils
#Region "Cookie Manager"
    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function InternetSetCookie(lpszUrl As String,
      lpszCookieName As String, lpszCookieData As String) As Boolean
    End Function
#End Region

#Region "Déclarations"
    'Used everywhere
    Public Shared userid As String
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
        If espacement.Length = 0 Then
            Debug.WriteLine("espacement est NUL !!!!")
            Return False
        Else
            'Dim abc As String = number
            'For i = 3 To number.Length Step 4
            '    abc = abc.Insert(i, espacement)
            'Next
            'Return abc
            If Not number.Length = 0 Then
                number = StrReverse(number)
                Dim dataToReturn = Regex.Replace(number, ".{3}", "$0" + espacement)
                If dataToReturn.Substring(dataToReturn.Length - 1, 1) = espacement Then
                    'Si le dernier char est l'epacement alors

                    Dim newData = dataToReturn.Substring(0, dataToReturn.Length - 1)
                    'On enlève le dernier char

                    dataToReturn = newData
                    'et on le renvoie
                    dataToReturn = StrReverse(dataToReturn)
                    Return dataToReturn
                End If
                dataToReturn = StrReverse(dataToReturn)
                Return dataToReturn
            End If
            Return number
        End If
    End Function

    Public Shared Function PrepareGatesFunction(server As String, userid As String, dosid As String, gateid As Integer)
        If server.Length = 0 Or userid.Length = 0 Or dosid.Length = 0 Or gateid = 0 Then
            Return MsgBox("Erreur dans le code, tu as oublié de mettre une valeur dans PrepareGatesFunction")
        End If
        Return "https://" + server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + userid + "&sid=" + dosid + "&action=setupGate&gateID=" & gateid
    End Function

End Class
