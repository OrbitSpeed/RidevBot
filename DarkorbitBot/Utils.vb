Imports System.Runtime.InteropServices

Public Class Utils
#Region "Cookie Manager"
    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function InternetSetCookie(lpszUrl As String,
      lpszCookieName As String, lpszCookieData As String) As Boolean
    End Function
#End Region

#Region "Déclarations"
    Public Shared dosid As String
    Public Shared server As String
    Public Shared connectWithCookie As Boolean = False

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
