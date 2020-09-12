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

        If Not File.Exists(Path.Combine(Application.StartupPath, "System.Net.Http.Extensions.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Net.Http.Extensions.dll"), My.Resources.System_Net_Http_Extensions)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "System.Net.Http.Primitives.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Net.Http.Primitives.dll"), My.Resources.System_Net_Http_Primitives)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4"), My.Resources.ridevbotuniverse)
        End If

        Await Task.Delay(1500)

        AutoUpdater.ShowDialog(Me)
        Close()
    End Sub
End Class