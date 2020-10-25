Public Class Checking_map

    Public Shared Function Load() As Task

        Var.Update_Screen()

        Dim Map_Location1_1 = Var.Client_Screen.Contains(Var.Map1_1)
        Dim Map_Location1_2 = Var.Client_Screen.Contains(Var.Map1_2)
        Dim Map_Location1_3 = Var.Client_Screen.Contains(Var.Map1_3)
        Dim Map_Location1_4 = Var.Client_Screen.Contains(Var.Map1_4)
        Dim Map_Location1_5 = Var.Client_Screen.Contains(Var.Map1_5)
        Dim Map_Location1_6 = Var.Client_Screen.Contains(Var.Map1_6)
        Dim Map_Location1_7 = Var.Client_Screen.Contains(Var.Map1_7)
        Dim Map_Location1_8 = Var.Client_Screen.Contains(Var.Map1_8)

        Dim Map_Location2_1 = Var.Client_Screen.Contains(Var.Map2_1)
        Dim Map_Location2_2 = Var.Client_Screen.Contains(Var.Map2_2)
        Dim Map_Location2_3 = Var.Client_Screen.Contains(Var.Map2_3)
        Dim Map_Location2_4 = Var.Client_Screen.Contains(Var.Map2_4)
        Dim Map_Location2_5 = Var.Client_Screen.Contains(Var.Map2_5)
        Dim Map_Location2_6 = Var.Client_Screen.Contains(Var.Map2_6)
        Dim Map_Location2_7 = Var.Client_Screen.Contains(Var.Map2_7)
        Dim Map_Location2_8 = Var.Client_Screen.Contains(Var.Map2_8)

        Dim Map_Location3_1 = Var.Client_Screen.Contains(Var.Map3_1)
        Dim Map_Location3_2 = Var.Client_Screen.Contains(Var.Map3_2)
        Dim Map_Location3_3 = Var.Client_Screen.Contains(Var.Map3_3)
        Dim Map_Location3_4 = Var.Client_Screen.Contains(Var.Map3_4)
        Dim Map_Location3_5 = Var.Client_Screen.Contains(Var.Map3_5)
        Dim Map_Location3_6 = Var.Client_Screen.Contains(Var.Map3_6)
        Dim Map_Location3_7 = Var.Client_Screen.Contains(Var.Map3_7)
        Dim Map_Location3_8 = Var.Client_Screen.Contains(Var.Map3_8)

        Dim Map_Location4_1 = Var.Client_Screen.Contains(Var.Map4_1)
        Dim Map_Location4_2 = Var.Client_Screen.Contains(Var.Map4_2)
        Dim Map_Location4_3 = Var.Client_Screen.Contains(Var.Map4_3)
        Dim Map_Location4_4 = Var.Client_Screen.Contains(Var.Map4_4)

        Dim Map_Location4_5 = Var.Client_Screen.Contains(Var.Map4_5)
        Dim Map_Location5_1 = Var.Client_Screen.Contains(Var.Map5_1)
        Dim Map_Location5_2 = Var.Client_Screen.Contains(Var.Map5_2)
        Dim Map_Location5_3 = Var.Client_Screen.Contains(Var.Map5_3)

        Dim Map_Location1_BL = Var.Client_Screen.Contains(Var.Map1_BL)
        Dim Map_Location2_BL = Var.Client_Screen.Contains(Var.Map2_BL)
        Dim Map_Location3_BL = Var.Client_Screen.Contains(Var.Map3_BL)

        Dim Save_point_original_point As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original_point <> Nothing Then
            Console.WriteLine("Get/set -- Getting...")
        Else
            Console.WriteLine("Get/ -- No contains")
        End If

        If Map_Location1_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-1"
        ElseIf Map_Location1_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-2"
        ElseIf Map_Location1_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-3"
        ElseIf Map_Location1_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-4"
        ElseIf Map_Location1_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-5"
        ElseIf Map_Location1_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-6"
        ElseIf Map_Location1_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-7"
        ElseIf Map_Location1_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-8"
        ElseIf Map_Location2_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-1"
        ElseIf Map_Location2_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-2"
        ElseIf Map_Location2_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-3"
        ElseIf Map_Location2_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-4"
        ElseIf Map_Location2_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-5"
        ElseIf Map_Location2_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-6"
        ElseIf Map_Location2_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-7"
        ElseIf Map_Location2_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-8"
        ElseIf Map_Location3_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-1"
        ElseIf Map_Location3_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-2"
        ElseIf Map_Location3_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-3"
        ElseIf Map_Location3_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-4"
        ElseIf Map_Location3_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-5"
        ElseIf Map_Location3_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-6"
        ElseIf Map_Location3_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-7"
        ElseIf Map_Location3_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-8"
        ElseIf Map_Location4_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-1"
        ElseIf Map_Location4_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-2"
        ElseIf Map_Location4_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-3"
        ElseIf Map_Location4_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-4"
        ElseIf Map_Location4_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-5"
        ElseIf Map_Location5_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-1"
        ElseIf Map_Location5_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-2"
        ElseIf Map_Location5_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-3"
        ElseIf Map_Location1_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1BL"
        ElseIf Map_Location2_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2BL"
        ElseIf Map_Location3_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3BL"
        End If

        Var.CurrentMapUser = Form_Game.Label_map_location.Text.Replace("Map : ", "")
        Console.WriteLine(Var.CurrentMapUser)

        Dim Save_point_original_point2 As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original_point2 <> Nothing Then
            Console.WriteLine("Get/set -- correct")
        Else
            Console.WriteLine("Get/ -- No contains")
        End If

        Return Nothing
    End Function

End Class
