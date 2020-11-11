Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
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

    Public Shared Firebase_Secret As String

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

    ''' <summary>
    ''' Attends le temps donné par le code
    ''' </summary>    
    '''<param name="time">Le temps en secondes</param>
    ''' <remarks></remarks>
    Friend Shared Async Sub WaitingAsync(ByVal time As Integer)
        For i As Integer = 0 To (time / 1000)






            Await Task.Delay(i * 1000)
        Next
    End Sub
#End Region

    ''' <summary>
    ''' Retourne le temps avec un espacement
    ''' </summary>    
    '''<param name="number">Le nombre en question genre 1000</param>
    '''<param name="espacement">L'espace à mettre pour séparer les nombres</param>
    ''' <remarks></remarks>
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
            Return number
        End If
    End Function

    Public Shared Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As Random = New Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Shared Function GetPortalZone(ByVal Number As Integer, ByVal x_or_y As String) As Integer
        If x_or_y = "x" Then
            'C'est X, donc on enlève pas 18
            Dim Generator As Random = New Random()
            Return Generator.Next(Number - 1, Number + 1)
        ElseIf x_or_y = "y" Then
            'C'est Y, donc on enlève 18
            Dim Generator As Random = New Random()
            Return Generator.Next((Number - 18) - 1, (Number - 18) + 1)
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
            Return Number
        End If
    End Function

#Region "Hashing Data"
    Public Shared Function AESEncryptStringToBase64(strPlainText As String, strKey As String) As String
        Dim Algo As RijndaelManaged = RijndaelManaged.Create()

        With Algo
            .BlockSize = 128
            .FeedbackSize = 128
            .KeySize = 256
            .Mode = CipherMode.CBC
            .IV = Guid.NewGuid().ToByteArray()
            .Key = Encoding.ASCII.GetBytes(strKey)
        End With


        Using Encryptor As ICryptoTransform = Algo.CreateEncryptor()
            Using MemStream As New MemoryStream
                Using CryptStream As New CryptoStream(MemStream, Encryptor, CryptoStreamMode.Write)
                    Using Writer As New StreamWriter(CryptStream)
                        Writer.Write(strPlainText)
                    End Using

                    AESEncryptStringToBase64 = Convert.ToBase64String(Algo.IV.Concat(MemStream.ToArray()).ToArray())
                End Using
            End Using
        End Using
    End Function

    Public Shared Function AESDecryptBase64ToString(strCipherText As String, strKey As String) As String
        Dim arrSaltAndCipherText As Byte() = Convert.FromBase64String(strCipherText)

        Dim Algo As RijndaelManaged = RijndaelManaged.Create()

        With Algo
            .BlockSize = 128
            .FeedbackSize = 128
            .KeySize = 256
            .Mode = CipherMode.CBC
            .IV = arrSaltAndCipherText.Take(16).ToArray()
            .Key = Encoding.ASCII.GetBytes(strKey)
        End With


        Using Decryptor As ICryptoTransform = Algo.CreateDecryptor()
            Using MemStream As New MemoryStream(arrSaltAndCipherText.Skip(16).ToArray())
                Using CryptStream As New CryptoStream(MemStream, Decryptor, CryptoStreamMode.Read)
                    Using Reader As New StreamReader(CryptStream)
                        AESDecryptBase64ToString = Reader.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
    End Function

    Shared Function getMD5Hash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("x2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

    Public Shared Function getSHA1Hash(ByVal strToHash As String) As String

        Dim sha1Obj As New SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function

    Public Shared Function GenerateSHA512String(ByVal inputString As String) As String
        Dim sha512 As SHA512 = SHA512Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Return GetStringFromHash(hash)
    End Function

    Private Shared Function GetStringFromHash(ByVal hash As Byte()) As String
        Dim result As StringBuilder = New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            result.Append(hash(i).ToString("x2"))
        Next

        Return result.ToString()
    End Function

#End Region

    Public Shared DateDistant As Date

    Public Shared Function calculateDiffDates(ByVal StartDate As DateTime, ByVal EndDate As DateTime) As Integer
        Dim diff As Integer
        diff = (EndDate - StartDate).TotalDays
        Return diff
    End Function


    Public Shared Function GetNetworkTime() As DateTime
        Const ntpServer As String = "146.59.146.51"
        Dim ntpData = New Byte(47) {}
        ntpData(0) = &H1B
        Dim addresses = Dns.GetHostEntry(ntpServer).AddressList
        Dim ipEndPoint = New IPEndPoint(addresses(0), 123)

        Using socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
            socket.Connect(ipEndPoint)
            socket.ReceiveTimeout = 3000
            socket.Send(ntpData)
            socket.Receive(ntpData)
            socket.Close()
        End Using

        Const serverReplyTime As Byte = 40
        Dim intPart As ULong = BitConverter.ToUInt32(ntpData, serverReplyTime)
        Dim fractPart As ULong = BitConverter.ToUInt32(ntpData, serverReplyTime + 4)
        intPart = SwapEndianness(intPart)
        fractPart = SwapEndianness(fractPart)
        Dim milliseconds = (intPart * 1000) + ((fractPart * 1000) / &H100000000L)
        Dim networkDateTime = (New DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(CLng(milliseconds))
        'DateDistant = networkDateTime.ToLocalTime()
        Return networkDateTime.ToLocalTime()
    End Function

    Shared Function SwapEndianness(x As ULong) As UInteger
        Return CUInt(((CLng(x) And &HFF) << 24) + ((CLng(x) And &HFF00) << 8) + ((CLng(x) And &HFF0000) >> 8) + ((CLng(x) And &HFF000000UI) >> 24))
    End Function
End Class
