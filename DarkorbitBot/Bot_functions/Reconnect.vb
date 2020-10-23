Public Class Reconnect

    Public Shared isReconnected As Boolean = False
    Public Shared reconnectionAttempt As Integer = 0
    Public Shared Async Function Load() As Task

        Var.Update_Screen()
        Console.WriteLine("Verifying, wait...")

        Dim Connection_Lost As Point = Var.Client_Screen.Contains(Var.Disconnected)
        If Connection_Lost <> Nothing Then
            Console.WriteLine("Reconnecting... 1/2")
            Await Shell_Reconnect()

        Else
            Console.WriteLine("Already connected")
        End If

    End Function

    Public Shared Async Function Shell_Reconnect() As Task

Label_retour_failed_connection:

        If reconnectionAttempt = 3 Then
            Console.WriteLine("Error, we tried 3 times in a row to reconnect and all failed.")

        End If

        Var.Update_Screen()
        Dim Connection_Lost As Point = Var.Client_Screen.Contains(Var.Disconnected)
        If Connection_Lost <> Nothing Then

            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 300, 354)
            Console.WriteLine("Reconnecting... 2/2")
            reconnectionAttempt += 1
            Await Task.Delay(7000)
            Console.WriteLine("Verifying, wait...")

            Var.Update_Screen()
            Dim Connection_Lost_control As Point = Var.Client_Screen.Contains(Var.Disconnected)
            If Connection_Lost_control <> Nothing Then
                GoTo Label_retour_failed_connection
                Console.WriteLine("Failed, module restarting, wait...")
            End If
        Else
            isReconnected = True
        End If

    End Function

End Class
