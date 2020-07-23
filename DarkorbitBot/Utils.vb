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


End Class
