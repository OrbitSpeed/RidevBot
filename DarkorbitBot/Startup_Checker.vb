Imports System.IO

Public Class Startup_Checker
    Private Async Sub Startup_Checker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '{"AxInterop.WMPLib.dll", My.Resources.AxInterop_WMPLib},
        '{"Interop.WMPLib.dll", My.Resources.Interop_WMPLib},
        Dim DLL_List = New Dictionary(Of String, Byte()) From {
            {"Firebase.Auth.dll", My.Resources.Firebase_Auth},
            {"FirebaseAdmin.dll", My.Resources.FirebaseAdmin},
            {"FireSharp.dll", My.Resources.FireSharp},
            {"Google.Api.Gax.dll", My.Resources.Google_Api_Gax},
            {"Google.Api.Gax.Rest.dll", My.Resources.Google_Api_Gax_Rest},
            {"Google.Apis.Auth.dll", My.Resources.Google_Apis_Auth},
            {"Google.Apis.Auth.PlatformServices.dll", My.Resources.Google_Apis_Auth_PlatformServices},
            {"Google.Apis.Core.dll", My.Resources.Google_Apis_Core},
            {"Google.Apis.dll", My.Resources.Google_Apis},
            {"Google.Apis.PlatformServices.dll", My.Resources.Google_Apis_PlatformServices},
            {"Microsoft.Threading.Tasks.dll", My.Resources.Microsoft_Threading_Tasks},
            {"Microsoft.Threading.Tasks.Extensions.Desktop.dll", My.Resources.Microsoft_Threading_Tasks_Extensions_Desktop},
            {"Newtonsoft.Json.dll", My.Resources.Newtonsoft_Json},
            {"System.Collections.Immutable.dll", My.Resources.System_Collections_Immutable},
            {"System.Diagnostics.DiagnosticSource.dll", My.Resources.System_Diagnostics_DiagnosticSource},
            {"System.Interactive.Async.dll", My.Resources.System_Interactive_Async},
            {"System.Net.Http.Extensions.dll", My.Resources.System_Net_Http_Extensions},
            {"System.Net.Http.Primitives.dll", My.Resources.System_Net_Http_Primitives}
        }

        'Dim list As New List(Of String)(DLL_List.Keys)
        'For Each value As String In list
        '    Console.WriteLine("Name: {0}", value)

        '    Console.WriteLine("Name: {0}, Ressource: {1}", value, list.Item(value))
        'Next

        For Each kvp As KeyValuePair(Of String, Byte()) In DLL_List
            Dim Name As String = kvp.Key
            Dim Ressource As Byte() = kvp.Value

            If Not File.Exists(Path.Combine(Application.StartupPath, Name)) Then
                File.WriteAllBytes(Path.Combine(Application.StartupPath, Name), Ressource)
            End If
            'Do whatever you want with v2:
            'If v2.ImageID = .... Then
        Next


        'If Not File.Exists(Path.Combine(Application.StartupPath, "AxInterop.WMPLib.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "AxInterop.WMPLib.dll"), My.Resources.AxInterop_WMPLib)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Firebase.Auth.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Firebase.Auth.dll"), My.Resources.Firebase_Auth)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "FirebaseAdmin.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "FirebaseAdmin.dll"), My.Resources.FirebaseAdmin)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "FireSharp.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "FireSharp.dll"), My.Resources.FireSharp)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Api.Gax.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Api.Gax.dll"), My.Resources.Google_Api_Gax)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Api.Gax.Rest")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Api.Gax.Rest.dll"), My.Resources.Google_Api_Gax_Rest)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.Auth.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.Auth.dll"), My.Resources.Google_Apis_Auth)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.Auth.PlatformServices.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.Auth.PlatformServices.dll"), My.Resources.Google_Apis_Auth_PlatformServices)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.Core.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.Core.dll"), My.Resources.Google_Apis_Core)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.dll"), My.Resources.Google_Apis)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.PlatformServices.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.PlatformServices.dll"), My.Resources.Google_Apis_PlatformServices)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Interop.WMPLib.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Interop.WMPLib.dll"), My.Resources.Interop_WMPLib)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.dll"), My.Resources.Microsoft_Threading_Tasks)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.Extensions.Desktop.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.Extensions.Desktop.dll"), My.Resources.Microsoft_Threading_Tasks_Extensions_Desktop)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "Newtonsoft.Json.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "Newtonsoft.Json.dll"), My.Resources.Newtonsoft_Json)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "System.Collections.Immutable.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Collections.Immutable.dll"), My.Resources.System_Collections_Immutable)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "System.Diagnostics.DiagnosticSource.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Diagnostics.DiagnosticSource.dll"), My.Resources.System_Diagnostics_DiagnosticSource)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "System.Interactive.Async.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Interactive.Async.dll"), My.Resources.System_Interactive_Async)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "System.Net.Http.Extensions.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Net.Http.Extensions.dll"), My.Resources.System_Net_Http_Extensions)
        'End If

        'If Not File.Exists(Path.Combine(Application.StartupPath, "System.Net.Http.Primitives.dll")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Net.Http.Primitives.dll"), My.Resources.System_Net_Http_Primitives)
        'End If



        'If Not File.Exists(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4"), My.Resources.ridevbotuniverse)
        'End If

        Await Task.Delay(1500)

        AutoUpdater.ShowDialog(Me)
        Close()
    End Sub

    Private Sub Extract_All_DLL()

    End Sub

End Class