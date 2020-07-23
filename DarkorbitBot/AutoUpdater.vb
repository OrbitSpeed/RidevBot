Imports System.IO
Imports System.Net

Public Class AutoUpdater
    Public StartupPath As String = Application.StartupPath
    Public FileToUpdate As String = StartupPath + "\RidevBot.exe"
    Public FileUpdater As String = StartupPath + "\RidevBot_Updater.exe"

    'Update
    Dim WC As New WebClient
    Dim WC_Update_Version As New WebClient
    Dim WC_Update_ChangeLog As New WebClient

    Public LastVersion As String '= WC.DownloadString("")
    Public LastChangeLog As String

    Private Sub AutoUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlatLabel_Version.Text = "Version : " + Application.ProductVersion

        AddHandler WC_Update_Version.DownloadStringCompleted, AddressOf WC_Update_Version_DownloadStringCompleted
        WC_Update_Version.DownloadStringAsync(New Uri("https://www.dropbox.com/s/qplm5okuue4ycac/LastVersion.txt?dl=1"))
        '---
        AddHandler WC_Update_ChangeLog.DownloadStringCompleted, AddressOf WC_Update_ChangeLog_DownloadStringCompleted
        WC_Update_ChangeLog.DownloadStringAsync(New Uri("https://www.dropbox.com/s/9qqo742mkyu1ate/ChangeLog.txt?dl=1"))
    End Sub
    Private Sub Continue_Loading()
        'Après le form_load
        'If File.Exists(FileToUpdate) Then
        '    File.Delete(FileToUpdate)
        'End If
        'Update_Dialog()
    End Sub

    Private Sub Update_Dialog()
        'Dans le cas où le programme n'est pas à jour
        'Timer_ChangeLog_Check.Stop()
        If Not File.Exists(FileUpdater) Then
            'TODO
            'PREND DANS MES RESSOURCES LAUTOUPDATER
            'JE MEN CHARGE DE CA
            'On extract le updater
            File.WriteAllBytes(FileUpdater, My.Resources.MMD_Updater)
        End If

        Dim result = MessageBox.Show("Une mise à jour est disponible (" & LastVersion & ")" & vbNewLine & vbNewLine & LastChangeLog & vbNewLine & vbNewLine & "-----------------------------------------------------------------" & vbNewLine & "Le logiciel va se mettre à jour automatiquement.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Process.Start(FileUpdater)
            End
        End If
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        If Application.ProductVersion <> LastVersion Then
            Update_Dialog()
        Else
            Form_Startup.ShowDialog(Me)
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
            Button_Update.Enabled = True
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
            Button_Update.Visible = True
        Catch ex As Exception
            MessageBox.Show($"Impossible de récuperer la dernière version du logiciel.{vbNewLine}Le logiciel va se fermer.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        'Throw New NotImplementedException()
    End Sub

End Class