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

    Public Function Contains(src As Bitmap, bmp As Bitmap) As Point
        '
        '-- Some logic pre-checks
        '
        If src Is Nothing OrElse bmp Is Nothing Then Return Nothing

        If src.Width = bmp.Width AndAlso src.Height = bmp.Height Then
            If src.GetPixel(0, 0) = bmp.GetPixel(0, 0) Then
                Return New Point(0, 0)
            Else
                Return Nothing
            End If
        ElseIf src.Width < bmp.Width OrElse src.Height < bmp.Height Then
            Return Nothing
        End If
        '
        '-- Prepare optimizations
        '
        Dim sr As New Rectangle(0, 0, src.Width, src.Height)
        Dim br As New Rectangle(0, 0, bmp.Width, bmp.Height)

        Dim srcLock As BitmapData = src.LockBits(sr, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb)
        Dim bmpLock As BitmapData = bmp.LockBits(br, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb)

        Dim sStride As Integer = srcLock.Stride
        Dim bStride As Integer = bmpLock.Stride

        Dim srcSz As Integer = sStride * src.Height
        Dim bmpSz As Integer = bStride * bmp.Height

        Dim srcBuff(srcSz) As Byte
        Dim bmpBuff(bmpSz) As Byte

        Marshal.Copy(srcLock.Scan0, srcBuff, 0, srcSz)
        Marshal.Copy(bmpLock.Scan0, bmpBuff, 0, bmpSz)

        ' we don't need to lock the image anymore as we have a local copy
        bmp.UnlockBits(bmpLock)
        src.UnlockBits(srcLock)

        Dim x, y, x2, y2, sx, sy, bx, by, sw, sh, bw, bh As Integer
        Dim r, g, b As Byte

        Dim p As Point = Nothing

        bw = bmp.Width
        bh = bmp.Height

        sw = src.Width - bw      ' limit scan to only what we need. the extra corner
        sh = src.Height - bh     ' point we need is taken care of in the loop itself.

        bx = 0 : by = 0
        '
        '-- Scan source for bitmap
        '
        For y = 0 To sh
            sy = y * sStride
            For x = 0 To sw

                sx = sy + x * 3
                '
                '-- Find start point/pixel
                '
                r = srcBuff(sx + 2)
                g = srcBuff(sx + 1)
                b = srcBuff(sx)

                If r = bmpBuff(2) AndAlso g = bmpBuff(1) AndAlso b = bmpBuff(0) Then
                    p = New Point(x, y)
                    '
                    '-- We have a pixel match, check the region
                    '
                    For y2 = 0 To bh - 1
                        by = y2 * bStride
                        For x2 = 0 To bw - 1
                            bx = by + x2 * 3

                            sy = (y + y2) * sStride
                            sx = sy + (x + x2) * 3

                            r = srcBuff(sx + 2)
                            g = srcBuff(sx + 1)
                            b = srcBuff(sx)

                            If Not (r = bmpBuff(bx + 2) AndAlso
                                g = bmpBuff(bx + 1) AndAlso
                                b = bmpBuff(bx)) Then
                                '
                                '-- Not matching, continue checking
                                '
                                p = Nothing
                                sy = y * sStride
                                Exit For
                            End If

                        Next
                        If p = Nothing Then Exit For
                    Next
                End If 'end of region check

                If p <> Nothing Then Exit For
            Next
            If p <> Nothing Then Exit For
        Next

        bmpBuff = Nothing
        srcBuff = Nothing

        Return p

    End Function

End Class
