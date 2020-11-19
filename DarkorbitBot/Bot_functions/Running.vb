Public Class Running

    Public Shared Async Sub Start()

        If Form_Game.Visible = False Then
            Var.User_Stop_Bot = False 'TODO: FIX
            Form_tools.PictureBox_LaunchBot.Image = My.Resources.cancel_presentation 'TOOD: FIX
            Form_tools.PictureBox_LaunchBot.Refresh()

            MessageBox.Show($"It seems that you don't opened the Browser{vbNewLine}" +
                            $"{vbNewLine}Open it first and then click the Start button.", "RidevBot", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Exit Sub
        End If

        If Var.security = True Then
            Var.security = False ' minimap configuration
            Console.WriteLine("redirection Minimap effectué /set")
            GoTo Minimap_backup
        End If

        If Var.security_traveling = True Then
            Var.security_traveling = False
            Console.WriteLine("redirection Traveling effectué /set")
            GoTo Retour_error_map_traveling
        End If

        If Var.security_T_backup = True Then
            Var.security_T_backup = False
            Console.WriteLine("redirection Traveling success effectué /set")
            GoTo Backup_traveling_success
        End If


        If Var.User_Stop_Bot Then
            Console.WriteLine("Stopped")
        Else
            Console.WriteLine("Started")
            Form_Game.WebBrowser_Game_Ridevbot.Select()
        End If

Recharge_functions:

        If Var.User_Stop_Bot Then Exit Sub
        Await Dead.Load

        If Var.User_Stop_Bot Then Exit Sub
        Await Reconnect.Load

        If Var.User_Stop_Bot Then Exit Sub
        Await Dependency.Load

Retour_error_map_traveling:
        If Var.User_Stop_Bot Then Exit Sub
        Minimap_configuration.Load()
        Exit Sub

Minimap_backup:
        Console.WriteLine("redirection effectué get/set")

        If Var.User_Stop_Bot Then Exit Sub
        Await Checking_map.Load
        Console.WriteLine("Map Loaded")

        If Form_Tools.CheckBox_use_palladium.Checked = True Then
            Await Palladium_module.Function_palladium_running
        End If

        If Var.User_Stop_Bot Then Exit Sub
        Traveling_module.Load()
        Exit Sub
Backup_traveling_success:

        If Var.User_Stop_Bot Then Exit Sub
        Await Pet_module.Post_function

        Await Task.Delay(1000)
        GoTo Recharge_functions


    End Sub

    Private Async Sub Backup_Traveling_Sucess(Optional reboot As Boolean = False)

        If Var.User_Stop_Bot Then Exit Sub
        Await Pet_module.Post_function
        Await Task.Delay(1000)
        If reboot = True Then Start()
    End Sub

End Class
