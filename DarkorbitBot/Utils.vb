Imports System.Drawing.Imaging
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
            If number = Nothing Then
            Else
                If Not number.Length = 0 Then
                    number = StrReverse(number)
                    number = number.Replace(espacement, "")
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

        End If
    End Function

    Public Shared Function PrepareGatesFunction(server As String, userid As String, dosid As String, gateid As Integer)
        If server.Length = 0 Or userid.Length = 0 Or dosid.Length = 0 Or gateid = 0 Then
            Return MsgBox("Erreur dans le code, tu as oublié de mettre une valeur dans PrepareGatesFunction")
        End If
        Return "https://" + server + ".darkorbit.com/flashinput/galaxyGates.php?userID" + userid + "&sid=" + dosid + "&action=setupGate&gateID=" & gateid
    End Function

    Public Shared Function getRegexGG(Text As String, GGNumber As String)
        GGNumber = GGNumber.ToString
        Dim idGG As String

        If GGNumber = "alpha" Then 'Or "34"
            idGG = "1"
        ElseIf GGNumber = "beta" Then 'Or "48"
            idGG = "2"
        ElseIf GGNumber = "gamma" Then 'Or "82"
            idGG = "3"
        ElseIf GGNumber = "delta" Then 'Or "128"
            idGG = "4"
        ElseIf GGNumber = "epsilon" Then 'Or "99"
            idGG = "5"
        ElseIf GGNumber = "zeta" Then 'Or "111"
            idGG = "6"
        ElseIf GGNumber = "kappa" Then 'Or "120"
            idGG = "7"
        ElseIf GGNumber = "lambda" Then
            idGG = "8"
        ElseIf GGNumber = "hades" Then
            idGG = "13"
        ElseIf GGNumber = "chronos" Then 'Or "21"
            idGG = "12"
        ElseIf GGNumber = "kuiper" Then 'Or "100"
            idGG = "19"
        Else
            idGG = "0"
            MsgBox("Erreur lors du regex GG, si le problème persiste, contactez le support.")
        End If

        'Dim DataGG = Regex.Match(Text, GGNumber + ".*?>([\s\S]*?)<\/DIV>").Groups.Item(1).ToString ' Info GG
        Dim DataGG = Regex.Match(Text, "(.*?id</SPAN><SPAN class=""m"">=""</SPAN><B>" + idGG + "</B[\s\S]*?)</DIV>").Groups.Item(1).ToString ' Info GG
        DataGG = Replace(DataGG, "<SPAN class=""m"">""</SPAN><SPAN class=""t""> ", "")
        DataGG = Replace(DataGG, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataGG = Replace(DataGG, "<SPAN class=""m"" > ""</SPAN><SPAN Class=""m""> /&gt;</SPAN>", "")
        DataGG = Replace(DataGG, "<SPAN class=""t""> ", "")
        DataGG = Replace(DataGG, "<SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataGG = Replace(DataGG, "</B>", " ")
        DataGG = Replace(DataGG, "<SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "") 'pour la chronos
        DataGG = Replace(DataGG, "<SPAN class=""m"">&lt;</SPAN><SPAN class=""t"">gate</SPAN>", "") 'pour la chronos

        Console.WriteLine("DataGG=" + DataGG)

        Return DataGG
    End Function

    Public Shared Function getKuiperGG(Text As String)
        Dim Kuiper = Regex.Match(Text, "total<\/SPAN><SPAN class=""m"">=""<\/SPAN><B>100.*?>([\s\S]*?)<\/DIV>") ' Info GG kuiper
        Dim DataKuiper = (Kuiper.Groups.Item(1).ToString)
        DataKuiper = Replace(DataKuiper, "</SPAN><SPAN class=""m"">=""</SPAN><B>", "")
        DataKuiper = Replace(DataKuiper, "</B><SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataKuiper = Replace(DataKuiper, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m""> /&gt;</SPAN>", "")
        DataKuiper = Replace(DataKuiper, "<SPAN class=""m"">""</SPAN><SPAN class=""t"">", "")
        DataKuiper = Replace(DataKuiper, "</B><SPAN class=""m"">""</SPAN><SPAN class=""m"">&gt;</SPAN>", "")
        DataKuiper = Replace(DataKuiper, "  total</SPAN><SPAN class="" m"">=""</SPAN><B>", "")

        Return DataKuiper
    End Function

    Public Shared Function getCurrentWave(Data As String)
        If Data = Nothing Then
            Return "?"
        ElseIf Data.Length = 0 Then
            Return "?"
        End If
        Return Regex.Match(Data, "currentWave.*?([\s\S]*?)\ ").Groups.Item(1).ToString
    End Function

    Public Shared Function getTotalWave(Data As String)
        If Data = Nothing Then
            Return "?"
        ElseIf Data.Length = 0 Then
            Return "?"
        End If
        Return Regex.Match(Data, "totalWave.*?([\s\S]*?)\ ").Groups.Item(1).ToString
    End Function

    Public Shared Function getCurrentPart(Data As String)
        If Data = Nothing Then
            Return "?"
        ElseIf Data.Length = 0 Then
            Return "?"
        End If
        Return Regex.Match(Data, "current(.*?)\ ").Groups.Item(1).ToString
    End Function
    Public Shared Function getTotalPart(Data As String)
        If Data = Nothing Then
            Return "?"
        ElseIf Data.Length = 0 Then
            Return "?"
        End If
        Return Regex.Match(Data, "total(.*?)\ ").Groups.Item(1).ToString
    End Function

    Public Shared Sub setLivesLeft(Data As String)
        Dim regex_livesLeft = Regex.Match(Data, "livesLeft.*?([\s\S]*?)\ ").Groups.Item(1).ToString
        If Not regex_livesLeft.Length = 0 Then

            If regex_livesLeft > 5 Then
                Form_Tools.Label_LivesLeft.Text = "Lives left : 5+"

            ElseIf regex_livesLeft = -1 Then
                Form_Tools.Label_LivesLeft.Text = "Lives left : -1"
            Else
                Form_Tools.Label_LivesLeft.Text = "Lives left : " + regex_livesLeft

            End If
        End If
    End Sub

    Public Shared Sub setInfoPartGG_InMap(Data As String)
        If Data.Contains("prepared1") Then
            Form_Tools.Label_infoPartGG_InMap.Text = "On map : 1"

        ElseIf Data.Contains("prepared0") Then
            Form_Tools.Label_infoPartGG_InMap.Text = "On map : 0"

        End If
    End Sub
    Public Shared Sub setWavePart(regex_currentWave As String, regex_totalWave As String, regex_currentPart As String)
        If Not regex_currentWave = "?" AndAlso Not regex_totalWave = "?" Then
            Form_Tools.Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

        Else
            Form_Tools.Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
        End If

        If Not regex_currentPart = "?" Then

            Form_Tools.Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / 128"
        Else
            Form_Tools.Label_InfoPartGG.Text = "Part : " + "?" + " / 128"
        End If
    End Sub

End Class
