Imports System.IO

Public Class Startup_Checker
    Private Async Sub Startup_Checker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(Path.Combine(Application.StartupPath, "AxInterop.WMPLib.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "AxInterop.WMPLib.dll"), My.Resources.AxInterop_WMPLib)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Interop.WMPLib.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Interop.WMPLib.dll"), My.Resources.Interop_WMPLib)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "FireSharp.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "FireSharp.dll"), My.Resources.FireSharp)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.dll"), My.Resources.Microsoft_Threading_Tasks)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.Extensions.Desktop.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Microsoft.Threading.Tasks.Extensions.Desktop.dll"), My.Resources.Microsoft_Threading_Tasks_Extensions_Desktop)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Newtonsoft.Json.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Newtonsoft.Json.dll"), My.Resources.Newtonsoft_Json)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Firebase.Auth.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Firebase.Auth.dll"), My.Resources.Firebase_Auth)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "FirebaseAdmin.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "FirebaseAdmin.dll"), My.Resources.FirebaseAdmin)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Api.Gax.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Api.Gax.dll"), My.Resources.Google_Api_Gax)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Api.Gax.Rest")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Api.Gax.Rest.dll"), My.Resources.Google_Api_Gax_Rest)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.Auth.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.Auth.dll"), My.Resources.Google_Apis_Auth)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.Auth.PlatformServices.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.Auth.PlatformServices.dll"), My.Resources.Google_Apis_Auth_PlatformServices)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.Core.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.Core.dll"), My.Resources.Google_Apis_Core)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.dll"), My.Resources.Google_Apis)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Google.Apis.PlatformServices.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Google.Apis.PlatformServices.dll"), My.Resources.Google_Apis_PlatformServices)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "System.Collections.Immutable.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Collections.Immutable.dll"), My.Resources.System_Collections_Immutable)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "System.Diagnostics.DiagnosticSource.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Diagnostics.DiagnosticSource.dll"), My.Resources.System_Diagnostics_DiagnosticSource)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "System.Interactive.Async.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Interactive.Async.dll"), My.Resources.System_Interactive_Async)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "System.Net.Http.Extensions.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Net.Http.Extensions.dll"), My.Resources.System_Net_Http_Extensions)
        End If
        If Not File.Exists(Path.Combine(Application.StartupPath, "System.Net.Http.Primitives.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Net.Http.Primitives.dll"), My.Resources.System_Net_Http_Primitives)
        End If



        'If Not File.Exists(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4")) Then
        '    File.WriteAllBytes(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4"), My.Resources.ridevbotuniverse)
        'End If

        Await Task.Delay(1500)

        AutoUpdater.ShowDialog(Me)
        Close()
    End Sub
End Class