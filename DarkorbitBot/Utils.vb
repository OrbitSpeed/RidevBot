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

#Region "Galaxy Gates Function"

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
    Public Shared Sub setWavePart(regex_currentWave As String, regex_totalWave As String, regex_currentPart As String, regex_totalPart As String)
        If Not regex_currentWave = "?" And Not regex_totalWave = "?" Then
            Form_Tools.Label_infoPartGG_CurrentWave.Text = "Wave : " + regex_currentWave + " / " + regex_totalWave

        Else
            Form_Tools.Label_infoPartGG_CurrentWave.Text = "Wave : " + "?" + " / " + "?"
        End If

        If Not regex_currentPart = "?" And Not regex_totalPart = "?" Then

            Form_Tools.Label_InfoPartGG.Text = "Part : " + regex_currentPart + " / " + regex_totalPart
        Else
            Form_Tools.Label_InfoPartGG.Text = "Part : " + "?" + " / ?"
        End If
    End Sub


#End Region
    Public Shared Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As Random = New Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Shared Function GetPortalZone(ByVal Number As Integer, ByVal x_or_y As String) As Integer
        If x_or_y = "x" Then
            'C'est X, donc on enlève pas 18
            Dim Generator As Random = New Random()
            Return Generator.Next(Number - 4, Number + 4)
        ElseIf x_or_y = "y" Then
            'C'est Y, donc on enlève 18
            Dim Generator As Random = New Random()
            Return Generator.Next((Number - 18) - 4, (Number - 18) + 4)
        Else
            Console.WriteLine("Can't get the X or Y, is it defined in the call of the function ?")
            Return 0
        End If
    End Function

    Public Shared Function GetPortalCenter(ByVal Number As Integer, ByVal x_or_y As String) As Integer
        If x_or_y = "x" Then
            'C'est X, donc on enlève pas 18
            Dim Generator As Random = New Random()
            Return Generator.Next(Number, Number)
        ElseIf x_or_y = "y" Then
            'C'est Y, donc on enlève 18
            Dim Generator As Random = New Random()
            Return Generator.Next((Number - 18), (Number - 18))
        Else
            Console.WriteLine("Can't get the X or Y, is it defined in the call of the function ?")
            Return 0
        End If
    End Function

    Public Shared Sub SetNPCAndCollectibleListBox(ByVal Map_actuelle As String)

#Region "PVP"
        If Map_actuelle = "4-1" Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

        ElseIf Map_actuelle = "4-2" Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

        ElseIf Map_actuelle = "4-3" Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

        ElseIf Map_actuelle = "4-4" Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

        ElseIf Map_actuelle = "4-5" Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

        ElseIf Map_actuelle = "5-1" Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

        ElseIf Map_actuelle = "5-2" Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

        ElseIf Map_actuelle = "5-3" Then
#End Region

        ElseIf Map_actuelle.Contains("-1") Then


            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Streuner ]=-")

            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Streuner ]=-")

        ElseIf Map_actuelle.Contains("-2") Then


            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Mucosum")
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Streuner ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Lordakia ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Recruit Streuner ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Aider Streuner ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add(" ..:{ Boss Streuner }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Lordakia }:..")

            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Streuner ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Lordakia ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Recruit Streuner ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Aider Streuner ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add(" ..:{ Boss Streuner }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Lordakia }:..")

        ElseIf Map_actuelle.Contains("-3") Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Mucosum")
            Form_Tools.CheckedListBox_listbox.Items.Add("Scrap")
            Form_Tools.CheckedListBox_listbox.Items.Add("Plasmide")
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Lordakia ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Saimon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Mordon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Devolarium ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Saimon }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Mordon }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Devolarium }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add(" -- HITAC MINION -- ")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add(" -- HITAC -- ")


            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Lordakia ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Saimon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Mordon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Devolarium ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Saimon }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Mordon }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Devolarium }:..")
            Form_Tools.CheckedListBox_npc.Items.Add(" -- HITAC MINION -- ")
            Form_Tools.CheckedListBox_npc.Items.Add(" -- HITAC -- ")

        ElseIf Map_actuelle.Contains("-4") Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Mucosum")
            Form_Tools.CheckedListBox_listbox.Items.Add("Scrap")
            Form_Tools.CheckedListBox_listbox.Items.Add("Plasmide")
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Lordakia ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Saimon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Mordon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Sibelon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Saimon }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Mordon }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Sibelon }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add(" -- HITAC MINION -- ")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add(" -- HITAC -- ")


            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Lordakia ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Saimon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Mordon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Sibelon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Saimon }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Mordon }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Sibelon }:..")
            Form_Tools.CheckedListBox_npc.Items.Add(" -- HITAC MINION -- ")
            Form_Tools.CheckedListBox_npc.Items.Add(" -- HITAC -- ")


        ElseIf Map_actuelle.Contains("-5") Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Mucosum")
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("*Lordakium spore*")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Sibelonit ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Lordakium ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Sibelonit }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Lordakium }:..")

            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("*Lordakium spore*")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Sibelonit ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Lordakium ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Sibelonit }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Lordakium }:..")

        ElseIf Map_actuelle.Contains("-6") Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Prismatium")
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bifenon")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Blighted Kristallin ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Kristallin ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Kristallon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Cubikon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Protegit ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Kristallin }:..")

            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Blighted Kristallin ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Kristallin ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Kristallon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Cubikon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Protegit ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Kristallin }:..")

        ElseIf Map_actuelle.Contains("-7") Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Prismatium")
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Kristallin ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Kristallon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ Blighted Kristallon ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Kristallin }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss Kristallon }:..")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("<=< Blighted Gygerthrall >=>")

            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Kristallin ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Kristallon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ Blighted Kristallon ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Kristallin }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss Kristallon }:..")
            Form_Tools.CheckedListBox_npc.Items.Add("<=< Blighted Gygerthrall >=>")

        ElseIf Map_actuelle.Contains("-8") Then

            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")

            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Clear()
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("-=[ StreuneR ]=-")
            Form_Tools.ComboBoxLabel_pet_locator_list.Items.Add("..: { Boss StreuneR }:..")

            Form_Tools.CheckedListBox_npc.Items.Clear()
            Form_Tools.CheckedListBox_npc.Items.Add("-=[ StreuneR ]=-")
            Form_Tools.CheckedListBox_npc.Items.Add("..: { Boss StreuneR }:..")

        ElseIf Map_actuelle.Contains("BL") Then
            Form_Tools.CheckedListBox_listbox.Items.Clear()
            Form_Tools.CheckedListBox_listbox.Items.Add("Gift Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Bonus Box")
            Form_Tools.CheckedListBox_listbox.Items.Add("Cargo Box")
        End If

        Form_Tools.CheckedListBox_listbox.Refresh()
        Form_Tools.CheckedListBox_npc.Refresh()
        Form_Tools.ComboBoxLabel_pet_locator_list.Refresh()
    End Sub
End Class
