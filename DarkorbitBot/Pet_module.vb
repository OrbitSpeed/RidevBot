
Imports System.ComponentModel
Public Class Pet_module

    Public Shared save_point_x As String = 0
    Public Shared save_point_Y As String = 0
    Public Shared passage As String = 0
    Public Shared Client_Screen As Bitmap
    Public Shared Activate_pet = My.Resources.Activate_pet
    Public Shared Play_Pet = My.Resources.Play_pet
    Public Shared defile_menu = My.Resources.Defile_menu_pet
    Public Shared Passive_pet = My.Resources.Passive_module_pet
    Public Shared Combo_material_module_pet = My.Resources.Combo_material_module_pet
    Public Shared box_collector_module_pet = My.Resources.box_collector_module_pet
    Public Shared Stop_pet = My.Resources.Stop_pet
    Public Shared reparator_ship_module_pet = My.Resources.reparator_ship_module_pet
    Public Shared ore_collector_module_pet = My.Resources.ore_collector_module_pet
    Public Shared protect_module_pet = My.Resources.protect_module_pet
    Public Shared Kamikaze_active_module_pet = My.Resources.Kamikaze_active_module_pet
    Public Shared npc_locator_module_pet = My.Resources.npc_locator_module_pet
    Public Shared repair_pet = My.Resources.repair_pet
    Public Shared Play_rex1 As Point = Client_Screen.Contains(Play_Pet)
    Public Shared Stop_pet1 As Point = Client_Screen.Contains(Stop_pet)
    Public Shared repair_pet1 As Point = Client_Screen.Contains(repair_pet)

    Function Update_Screen()
        Dim Client_primary = New Bitmap(Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Width, Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Invoke(New MethodInvoker(Sub()
                                     Client_second.CopyFromScreen(PointToScreen(Form_Game.WebBrowser_Game_Ridevbot.Location), New Point(0, 0), Form_Game.WebBrowser_Game_Ridevbot.ClientSize)
                                 End Sub))
        Return Client_primary

    End Function




    Public Shared Function Post_function()


    End Function

End Class
