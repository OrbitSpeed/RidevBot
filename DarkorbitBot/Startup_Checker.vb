Imports System.IO

Public Class Startup_Checker
    Private Async Sub Startup_Checker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(Path.Combine(Application.StartupPath, "AxInterop.WMPLib.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "AxInterop.WMPLib.dll"), My.Resources.AxInterop_WMPLib)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "Interop.WMPLib.dll")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "Interop.WMPLib.dll"), My.Resources.Interop_WMPLib)
        End If

        If Not File.Exists(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4")) Then
            File.WriteAllBytes(Path.Combine(Application.StartupPath, "ridevbotuniverse.mp4"), My.Resources.ridevbotuniverse)
        End If

        Await Task.Delay(1500)

        AutoUpdater.ShowDialog(Me)
        Close()
    End Sub
End Class