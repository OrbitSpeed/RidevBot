Imports System.IO
Imports System.Net

Public Class AutoUpdater
    Public StartupPath As String = Application.StartupPath
    Public FileToUpdate As String = StartupPath + "\RidevBot.exe"
    Public FileUpdater As String = StartupPath + "\RidevBot_Updater.exe"

    'Update
    Private WC As New WebClient
    Private WC_Update_Version As New WebClient
    Private WC_Update_ChangeLog As New WebClient
    Private WC_Check_Maintenance As New WebClient

    Public LastVersion As String '= WC.DownloadString("")
    Public LastChangeLog As String
    Public Check_Maintenance As Boolean

    Private Sub AutoUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlatLabel_Version.Text = "Version : " + Application.ProductVersion
        FlatLabel_isUpdated.Select()

        AddHandler WC_Check_Maintenance.DownloadStringCompleted, AddressOf WC_Check_Maintenance_DownloadStringCompleted
        WC_Check_Maintenance.DownloadStringAsync(New Uri("https://www.dropbox.com/s/povcf3bfxjxy8ir/Maintenance.txt?dl=1"))
        '---
        AddHandler WC_Update_Version.DownloadStringCompleted, AddressOf WC_Update_Version_DownloadStringCompleted
        WC_Update_Version.DownloadStringAsync(New Uri("https://www.dropbox.com/s/5ergvrkppscoupo/Version.txt?dl=1"))
        '---
        AddHandler WC_Update_ChangeLog.DownloadStringCompleted, AddressOf WC_Update_ChangeLog_DownloadStringCompleted
        WC_Update_ChangeLog.DownloadStringAsync(New Uri("https://www.dropbox.com/s/q8wlkhxshwbnajo/Changelog.txt?dl=1"))
    End Sub

    Private Sub WC_Check_Maintenance_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs)
        Try
            Check_Maintenance = e.Result
            If Check_Maintenance Then
                Dim result = MessageBox.Show($"A maintenance is actually underway...{vbNewLine}Please, try again later.{vbNewLine}If the problem persist, contact our support at : https://discord.gg/GFzfcGR", "Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = DialogResult.OK Then
                    Close()
                Else
                    Close()
                End If
            End If
            FlatLabel_isUpdated.Select()
        Catch ex As Exception
            MessageBox.Show($"Impossible de récuperer la dernière version du logiciel.{vbNewLine}Le logiciel va se fermer.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

    End Sub

    Private Sub Update_Dialog()
        'Dans le cas où le programme n'est pas à jour
        'Timer_ChangeLog_Check.Stop()
        If Not File.Exists(FileUpdater) Then
            File.WriteAllBytes(FileUpdater, My.Resources.RidevBotUpdater)
        End If

        Dim result = MessageBox.Show("Une mise à jour est disponible (" & LastVersion & ")" & vbNewLine & vbNewLine & LastChangeLog & vbNewLine & vbNewLine & "-----------------------------------------------------------------" & vbNewLine & "Le logiciel va se mettre à jour automatiquement.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Process.Start(FileUpdater)
            Close()
        Else
            Process.Start(FileUpdater)
            Close()
        End If
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        If Application.ProductVersion <> LastVersion Then
            Update_Dialog()
        Else
            If File.Exists(FileUpdater) Then
                File.Delete(FileUpdater)
            End If
            Form_Startup.Show()
            Close()
        End If
        'Hide()
    End Sub

    Private Sub WC_Update_Version_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs)
        'MsgBox(e.Result)
        Try
            LastVersion = e.Result
            If Application.ProductVersion <> LastVersion Then
                'different
                FlatLabel_isUpdated.Text = "Vous n'êtes pas à jour"
                FlatLabel_isUpdated.ForeColor = Color.DarkOrange
                FlatLabel_isUpdated.Visible = True
            Else
                FlatLabel_isUpdated.Visible = True
            End If
            FlatLabel_isUpdated.Select()
            'Button_Update.Enabled = True
        Catch ex As Exception
            MessageBox.Show($"Impossible de récuperer la dernière version du logiciel.{vbNewLine}Le logiciel va se fermer.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        'Throw New NotImplementedException()
    End Sub

    Private Sub WC_Update_ChangeLog_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs)
        'MsgBox(e.Result)
        Try
            LastChangeLog = e.Result
            FlatTextBox_Changelog.Text = e.Result
            FlatLabel_isUpdated.Select()
            Button_Update.Visible = True
            Button_Update.Enabled = True
        Catch ex As Exception
            MessageBox.Show($"Impossible de récuperer la dernière version du logiciel.{vbNewLine}Le logiciel va se fermer.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
        'Throw New NotImplementedException()
    End Sub

End Class