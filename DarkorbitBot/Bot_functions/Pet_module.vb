Imports AutoItX3Lib
Imports System.ComponentModel
Public Class Pet_module

    Public Shared save_point_x As String = 0
    Public Shared save_point_Y As String = 0
    Public Shared passage As String = 0
    Public Shared AutoIt As New AutoItX3

    Public Shared Client_Screen As Bitmap

    Public Shared Activate_pet = My.Resources.Activate_pet
    Public Shared Play_Pet = My.Resources.Play_pet
    Public Shared Stop_pet = My.Resources.Stop_pet
    Public Shared repair_pet = My.Resources.repair_pet
    Public Shared defile_menu = My.Resources.Defile_menu_pet

    Public Shared Module_Passive = My.Resources.passive_pet_module
    Public Shared Combo_Module_defense_pet = My.Resources.combo_ship_Defense_pet_module
    Public Shared Combo_Module_Ship_repairer = My.Resources.reparator_ship_module_pet
    Public Shared Module_Auto_looter = My.Resources.auto_loot_pet_module
    Public Shared Module_Pet_repairer = My.Resources.Ship_repairer_pet_module
    Public Shared Module_Ore_collector = My.Resources.auto_loot_resources_pet_module
    Public Shared Module_Guard = My.Resources.guard_pet_module
    Public Shared Module_Kamikaze = My.Resources.Kamikaze_pet_module
    Public Shared Module_Npc_locator = My.Resources.Npc_detector_pet_module
    Public Shared Module_Link_pv = My.Resources.Link_pv_pet_module
    Public Shared Module_sacrifice_flam = My.Resources.Sacrifice_flam_pet_module

    Public Shared Play_rex1 As Point '= Client_Screen.Contains(Play_Pet)
    Public Shared Stop_pet1 As Point '= Client_Screen.Contains(Stop_pet)
    Public Shared repair_pet1 As Point '= Client_Screen.Contains(repair_pet)

    'Public Shared temps_rex_timer As Integer = 1600
    Public Shared temps_rex_timer As Integer = 1001

    Public Shared Function Update_Screen()

        Dim Client_primary = New Bitmap(Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Width, Form_Game.WebBrowser_Game_Ridevbot.ClientSize.Height)
        Dim Client_second As Graphics = Graphics.FromImage(Client_primary)
        Form_Game.Invoke(New MethodInvoker(Sub()
                                               Client_second.CopyFromScreen(Form_Game.PointToScreen(Form_Game.WebBrowser_Game_Ridevbot.Location), New Point(0, 0), Form_Game.WebBrowser_Game_Ridevbot.ClientSize)
                                           End Sub))
        Return Client_primary

    End Function


    Public Shared Async Function Post_function() As Task

        'On met à jour les info sur le rex
        Client_Screen = Update_Screen()
        Play_rex1 = Client_Screen.Contains(Play_Pet)
        Stop_pet1 = Client_Screen.Contains(Stop_pet)
        repair_pet1 = Client_Screen.Contains(repair_pet)

#Region "Activating the pet module"

        If Play_rex1 <> Nothing Then

        ElseIf Stop_pet1 <> Nothing Then

        ElseIf repair_pet1 <> Nothing Then

        Else
            Dim Activate_pet1 As Point = Client_Screen.Contains(Activate_pet)
            If Activate_pet1 <> Nothing Then

                Console.WriteLine("On ouvre le rex")
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Activate_pet1.X, Activate_pet1.Y)
                Await Task.Delay(temps_rex_timer)
            Else

                Console.WriteLine("Rex Error 2678")

            End If
        End If

#End Region

#Region "Pet reparation"

        Client_Screen = Update_Screen()
        Dim repair_pet2 As Point = Client_Screen.Contains(repair_pet)
        If repair_pet2 <> Nothing Then

            If Form_Tools.CheckBox_repair_pet_auto.Checked = True Then

                Console.WriteLine("On repare le rex")
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, repair_pet2.X, repair_pet2.Y)
                Form_Tools.Label_dead_pet_counter.Text = +1
                Await Task.Delay(temps_rex_timer)

            End If
        End If

#End Region

#Region "Condition d'utilisation"

        If Form_Tools.CheckBox_use_pet.Checked = True Then


        Else

            Console.WriteLine("La checkbox n'est pas ou plus checker")
            Console.WriteLine("On verifie si le rex et quand meme lancer")
            Client_Screen = Update_Screen()
            Dim Stop_pet2 As Point = Client_Screen.Contains(Stop_pet)
            If Stop_pet2 <> Nothing Then

                Console.WriteLine("On arrete le Rex")
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Stop_pet2.X, Stop_pet2.Y)
                Await Task.Delay(temps_rex_timer)

                Client_Screen = Update_Screen()
                Console.WriteLine("On ferme le rex")
                Dim Activate_pet3 As Point = Client_Screen.Contains(Activate_pet)
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Activate_pet3.X, Activate_pet3.Y)
                Await Task.Delay(temps_rex_timer)
                Exit Function

            Else

                Console.WriteLine("On ferme le rex -- le rex n'est pas lancé")
                Dim Activate_pet2 As Point = Client_Screen.Contains(Activate_pet)
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Activate_pet2.X, Activate_pet2.Y)
                Await Task.Delay(temps_rex_timer)
                Exit Function

            End If

        End If

#End Region

#Region "Module Pet + Else des conditions"

        Client_Screen = Update_Screen()
        Dim Play_Pet2 As Point = Client_Screen.Contains(Play_Pet)
        If Play_Pet2 <> Nothing Then

            Console.WriteLine("On lance le rex")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Play_Pet2.X, Play_Pet2.Y)
            Await Task.Delay(temps_rex_timer)

            Client_Screen = Update_Screen()
            Dim defile_menu1 As Point = Client_Screen.Contains(defile_menu)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, defile_menu1.X, defile_menu1.Y)
            Await Task.Delay(1200)

#Region "Elements_by_pet"

            If Form_Tools.ComboBox_pet_profil.Text = "Passive" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Passive")
                Dim Passive_pet1 As Point = Client_Screen.Contains(Module_Passive)
                If Passive_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Passive_pet1.X, Passive_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Defensive mode" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Defensive mode")
                Dim Combo_material_module_pet1 As Point = Client_Screen.Contains(Combo_Module_defense_pet)
                If Combo_material_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Combo_material_module_pet1.X, Combo_material_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Collect Box" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Collect Box")
                Dim box_collector_module_pet1 As Point = Client_Screen.Contains(Module_Auto_looter)
                If box_collector_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, box_collector_module_pet1.X, box_collector_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Ship Repairer" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Ship Repairer")
                Dim reparator_ship_module_pet1 As Point = Client_Screen.Contains(Combo_Module_Ship_repairer)
                If reparator_ship_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, reparator_ship_module_pet1.X, reparator_ship_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Collect Ore" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Collect Ore")
                Dim ore_collector_module_pet1 As Point = Client_Screen.Contains(Module_Ore_collector)
                If ore_collector_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, ore_collector_module_pet1.X, ore_collector_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Guard" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Guard")
                Dim protect_module_pet1 As Point = Client_Screen.Contains(Module_Guard)
                If protect_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, protect_module_pet1.X, protect_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Kamikaze" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Kamikaze")
                Dim Kamikaze_active_module_pet1 As Point = Client_Screen.Contains(Module_Kamikaze)
                If Kamikaze_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Kamikaze_active_module_pet1.X, Kamikaze_active_module_pet1.Y)
                End If


            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Link Pv" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Link Pv")
                Dim Link_PV_active_module_pet1 As Point = Client_Screen.Contains(Module_Link_pv)
                If Link_PV_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Link_PV_active_module_pet1.X, Link_PV_active_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Fireflam" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Fireflam")
                Dim Sacrifice_FLAM_active_module_pet1 As Point = Client_Screen.Contains(Module_sacrifice_flam)
                If Sacrifice_FLAM_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Sacrifice_FLAM_active_module_pet1.X, Sacrifice_FLAM_active_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "PET Repairer" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("PET Repairer")
                Dim Module_Pet_repairer_active_module_pet1 As Point = Client_Screen.Contains(Module_Pet_repairer)
                If Module_Pet_repairer_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Module_Pet_repairer_active_module_pet1.X, Module_Pet_repairer_active_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "NPC Locator" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("NPC Locator")
                Dim npc_locator_module_pet1 As Point = Client_Screen.Contains(Module_Npc_locator)
                If npc_locator_module_pet1 <> Nothing Then

                    Dim cursor_Pos = Cursor.Position
                    Cursor.Position = New Point(npc_locator_module_pet1.X + 2, npc_locator_module_pet1.Y + 19)
                    Await Task.Delay(10)
                    Cursor.Position = cursor_Pos


                    If Form_Tools.ComboBoxLabel_pet_locator_list.Text = "" Then

                        MsgBox($" Select in first Npc in list ")

                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Streuner ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Lordakia ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Aider Streuner ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Recruit Streuner ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Saimon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Mordon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Devolarium ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Sibelon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Sibelonit ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Lordakium ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Kristallin ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Kristallon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ StreuneR ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Protegit ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Cubikon ]=-" Then

                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Streuner } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Lordakia } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Saimon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Mordon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Devolarium } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Sibelon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Sibelonit } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Lordakium } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Kristallin } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Kristallon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss StreuneR } :.. " Then

                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "\\ Invoke XVI //" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "Agatus" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "Spinel" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "Spinelus" Then

                    End If

                    ' Await Task.Delay(5000)

                Else
                End If



            Else Console.WriteLine("Not added")

                Client_Screen = Update_Screen()
                Console.WriteLine("On ferme le rex")
                Dim Activate_pet4 As Point = Client_Screen.Contains(Activate_pet)
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Activate_pet4.X, Activate_pet4.Y)
                Exit Function

            End If

#End Region


            Client_Screen = Update_Screen()
            Console.WriteLine("On ferme le rex")
            Dim Activate_pet3 As Point = Client_Screen.Contains(Activate_pet)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Activate_pet3.X, Activate_pet3.Y)
            Exit Function



        Else
            Console.WriteLine("Rex deja lancer")
            Console.WriteLine("On verifie alors si on es sur le bon module")

            Client_Screen = Update_Screen()
            Dim defile_menu1 As Point = Client_Screen.Contains(defile_menu)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, defile_menu1.X, defile_menu1.Y)
            Await Task.Delay(1200)

#Region "Elements_by_pet2"

            If Form_Tools.ComboBox_pet_profil.Text = "Passive" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Passive")
                Dim Passive_pet1 As Point = Client_Screen.Contains(Module_Passive)
                If Passive_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Passive_pet1.X, Passive_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Defensive mode" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Defensive mode")
                Dim Combo_material_module_pet1 As Point = Client_Screen.Contains(Combo_Module_defense_pet)
                If Combo_material_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Combo_material_module_pet1.X, Combo_material_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Collect Box" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Collect Box")
                Dim box_collector_module_pet1 As Point = Client_Screen.Contains(Module_Auto_looter)
                If box_collector_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, box_collector_module_pet1.X, box_collector_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Ship Repairer" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Ship Repairer")
                Dim reparator_ship_module_pet1 As Point = Client_Screen.Contains(Combo_Module_Ship_repairer)
                If reparator_ship_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, reparator_ship_module_pet1.X, reparator_ship_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Collect Ore" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Collect Ore")
                Dim ore_collector_module_pet1 As Point = Client_Screen.Contains(Module_Ore_collector)
                If ore_collector_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, ore_collector_module_pet1.X, ore_collector_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Guard" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Guard")
                Dim protect_module_pet1 As Point = Client_Screen.Contains(Module_Guard)
                If protect_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, protect_module_pet1.X, protect_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Kamikaze" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Kamikaze")
                Dim Kamikaze_active_module_pet1 As Point = Client_Screen.Contains(Module_Kamikaze)
                If Kamikaze_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Kamikaze_active_module_pet1.X, Kamikaze_active_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Link PV" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Link Pv")
                Dim Link_PV_active_module_pet1 As Point = Client_Screen.Contains(Module_Link_pv)
                If Link_PV_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Link_PV_active_module_pet1.X, Link_PV_active_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "Sacrifice FLAM" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("Link Pv")
                Dim Sacrifice_FLAM_active_module_pet1 As Point = Client_Screen.Contains(Module_sacrifice_flam)
                If Sacrifice_FLAM_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Sacrifice_FLAM_active_module_pet1.X, Sacrifice_FLAM_active_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "PET Repairer" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("PET Repairer")
                Dim Module_Pet_repairer_active_module_pet1 As Point = Client_Screen.Contains(Module_Pet_repairer)
                If Module_Pet_repairer_active_module_pet1 <> Nothing Then

                    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Module_Pet_repairer_active_module_pet1.X, Module_Pet_repairer_active_module_pet1.Y)
                End If

            ElseIf Form_Tools.ComboBox_pet_profil.Text = "NPC Locator" Then

                Client_Screen = Update_Screen()
                Console.WriteLine("NPC Locator")
                Dim npc_locator_module_pet1 As Point = Client_Screen.Contains(Module_Npc_locator)
                If npc_locator_module_pet1 <> Nothing Then

                    Dim cursor_Pos = Cursor.Position
                    Cursor.Position = New Point(npc_locator_module_pet1.X + 2, npc_locator_module_pet1.Y + 19)
                    Await Task.Delay(10)
                    Cursor.Position = cursor_Pos

                    If Form_Tools.ComboBoxLabel_pet_locator_list.Text = "" Then

                        MsgBox($" Select in first Npc in list ")

                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Streuner ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Lordakia ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Aider Streuner ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Recruit Streuner ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Saimon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Mordon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Devolarium ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Sibelon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Sibelonit ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Lordakium ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Kristallin ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Kristallon ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ StreuneR ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Protegit ]=-" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "-=[ Cubikon ]=-" Then

                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Streuner } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Lordakia } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Saimon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Mordon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Devolarium } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Sibelon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Sibelonit } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Lordakium } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Kristallin } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss Kristallon } :.." Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "..: { Boss StreuneR } :.. " Then

                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "\\ Invoke XVI //" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "Agatus" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "Spinel" Then
                    ElseIf Form_Tools.ComboBoxLabel_pet_locator_list.Text = "Spinelus" Then

                    End If

                Else
                End If

            Else Console.WriteLine("Not added")

                Client_Screen = Update_Screen()
                Console.WriteLine("On ferme le rex")
                Dim Activate_pet4 As Point = Client_Screen.Contains(Activate_pet)
                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Activate_pet4.X, Activate_pet4.Y)
                Exit Function

            End If

#End Region

            Client_Screen = Update_Screen()
            Console.WriteLine("On ferme le rex")
            Dim Activate_pet3 As Point = Client_Screen.Contains(Activate_pet)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Activate_pet3.X, Activate_pet3.Y)
            Exit Function

        End If

#End Region


    End Function

End Class
