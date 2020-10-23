Imports System
Imports System.Threading.Tasks
Imports System.Threading

Public Class Dependency
    Public Shared Async Function Func_Dpendency() As Task

        Var.Update_Screen()
        Console.WriteLine("Verifying Dependency, wait...")

        Dim Cancel_disconnect As Point = Var.Client_Screen.Contains(Var.Cancel_disconnect)
        If Cancel_disconnect <> Nothing Then
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Cancel_disconnect.X, Cancel_disconnect.Y)
            Console.WriteLine("Cancel disconnect.")
            Await Task.Delay(1000)
        End If

        Dim Close_popup_payment As Point = Var.Client_Screen.Contains(Var.Close_popup_payment)
        If Close_popup_payment <> Nothing Then
            Var.AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Close_popup_payment.X, Close_popup_payment.Y)
            Console.WriteLine("Close popup payment.")
            Await Task.Delay(1000)
        End If

    End Function

End Class