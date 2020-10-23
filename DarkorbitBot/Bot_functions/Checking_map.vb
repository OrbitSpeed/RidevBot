Public Class Checking_map

    Public Shared Function Func_Checking_map() As Task

        Var.UpdateMapLocations()
        Var.Update_Screen()

        If Var.Map_Location1_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-1"
        ElseIf Var.Map_Location1_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-2"
        ElseIf Var.Map_Location1_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-3"
        ElseIf Var.Map_Location1_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-4"
        ElseIf Var.Map_Location1_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-5"
        ElseIf Var.Map_Location1_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-6"
        ElseIf Var.Map_Location1_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-7"
        ElseIf Var.Map_Location1_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1-8"
        ElseIf Var.Map_Location2_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-1"
        ElseIf Var.Map_Location2_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-2"
        ElseIf Var.Map_Location2_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-3"
        ElseIf Var.Map_Location2_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-4"
        ElseIf Var.Map_Location2_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-5"
        ElseIf Var.Map_Location2_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-6"
        ElseIf Var.Map_Location2_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-7"
        ElseIf Var.Map_Location2_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2-8"
        ElseIf Var.Map_Location3_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-1"
        ElseIf Var.Map_Location3_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-2"
        ElseIf Var.Map_Location3_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-3"
        ElseIf Var.Map_Location3_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-4"
        ElseIf Var.Map_Location3_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-5"
        ElseIf Var.Map_Location3_6 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-6"
        ElseIf Var.Map_Location3_7 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-7"
        ElseIf Var.Map_Location3_8 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3-8"
        ElseIf Var.Map_Location4_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-1"
        ElseIf Var.Map_Location4_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-2"
        ElseIf Var.Map_Location4_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-3"
        ElseIf Var.Map_Location4_4 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-4"
        ElseIf Var.Map_Location4_5 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 4-5"
        ElseIf Var.Map_Location5_1 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-1"
        ElseIf Var.Map_Location5_2 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-2"
        ElseIf Var.Map_Location5_3 <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 5-3"
        ElseIf Var.Map_Location1_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 1BL"
        ElseIf Var.Map_Location2_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 2BL"
        ElseIf Var.Map_Location3_BL <> Nothing Then
            Form_Game.Label_map_location.Text = "Map : 3BL"
        End If

        Var.CurrentMapUser = Form_Game.Label_map_location.Text.Split(" : ")(2)
        Form_Game.Label_map_location.Update()

        Dim Save_point_original_point As Point = Var.Client_Screen.Contains(Var.Minimap_size_ref)
        If Save_point_original_point <> Nothing Then
            Console.WriteLine("Get/set -- correctly traded.")
        Else
            Console.WriteLine("Get//X -- No contains")
        End If

    End Function

End Class
