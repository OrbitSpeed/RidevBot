Imports System.ComponentModel
Imports AutoItX3Lib

Public Class Form_Game
    Declare Function BlockInput Lib "user32" (ByVal fBlockIt As Boolean) As Boolean

    Dim AutoIt As New AutoItX3
    Dim X_TOP As Integer = 0
    Dim Y_TOP As Integer = 64
    Dim X_BOTTOM As Integer = 800
    Dim Y_BOTTOM As Integer = 618
    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click

        CloseForm.ShowDialog(Me)
        Form_tools.Button_LaunchGameRidevBrowser.Text = "Open RidevBot Browser"
        Form_tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

        Form_tools.Reloader = 0
        Form_tools.Reload()

    End Sub
    Private Sub WebBrowser_Game_Ridevbot_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser_Game_Ridevbot.DocumentCompleted

        Form_tools.Button_LaunchGameRidevBrowser.Text = "Reload RidevBot Browser"
        Form_tools.Button_LaunchGameRidevBrowser.Cursor = Cursors.Hand

    End Sub
    Private Sub Form_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        If BackgroundWorker_Performance.IsBusy = False Then
            BackgroundWorker_Performance.RunWorkerAsync()
        End If

    End Sub

    Private Sub Button_cargobox_Click(sender As Object, e As EventArgs) Handles Button_cargobox.Click

        Dim Cargo_Box = AutoIt.PixelSearch(X_TOP, Y_TOP, X_BOTTOM, Y_BOTTOM, 16777030, 5, 1)

        Try
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Cargo_Box(0) - 0, Cargo_Box(1) - 0)
            '   Me.Invoke(New MethodInvoker(Sub() System.Threading.Thread.Sleep(Form_Tools.TextBox_bonusbox_ms.Text)))

        Catch Cargo_Box_not_found As Exception
        End Try

    End Sub
    Private Sub BackgroundWorker_Performance_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_Performance.DoWork
        Dim myProcess = Process.GetCurrentProcess()
        'Console.WriteLine($"{myProcess} -")

        'Console.WriteLine("-------------------------------------")
        'Console.WriteLine($"  Physical memory usage     : {Convert.ToInt32(myProcess.WorkingSet64 / (1024.0F * 1024.0F))}")
        'Console.WriteLine($"  Base priority             : {myProcess.BasePriority}")
        'Console.WriteLine($"  Priority class            : {myProcess.PriorityClass}")
        'Console.WriteLine($"  User processor time       : {myProcess.UserProcessorTime}")
        'Console.WriteLine($"  Privileged processor time : {myProcess.PrivilegedProcessorTime}")
        'Console.WriteLine($"  Total processor time      : {myProcess.TotalProcessorTime}")
        'Console.WriteLine($"  Paged system memory size  : {myProcess.PagedSystemMemorySize64}")
        'Console.WriteLine($"  Paged memory size         : {myProcess.PagedMemorySize64}")

        'Console.WriteLine(My.Computer.Info.TotalPhysicalMemory)
        'Console.WriteLine($"{Convert.ToInt32(My.Computer.Info.TotalPhysicalMemory / (1024.0F * 1024.0F * 1024.0F))}")

        Try
            Invoke(New MethodInvoker(Sub()
                                         Label_PerformanceMemoire.Text = $"RAM Used: {Convert.ToInt32(myProcess.WorkingSet64 / (1024.0F * 1024.0F))} Mo"
                                         Label_PerformanceMemoire.Update()
                                     End Sub))
        Catch ex As Exception
        End Try

    End Sub

    Private Async Sub BackgroundWorker_Performance_RunWorkCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_Performance.RunWorkerCompleted
        If BackgroundWorker_Performance.IsBusy = False Then
            Await Task.Delay(100)
            BackgroundWorker_Performance.RunWorkerAsync()
        End If
    End Sub

    Private Sub Button_REX_Click(sender As Object, e As EventArgs) Handles Button_REX.Click

        Pet_module.Post_function()

    End Sub


#Region "npc et lock test"
    Public LOCKEDTRUE As String = 1

    '                                                                                                               IDEE NUMERO 2
    Private Async Sub If_Locked()

        AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "1")
        Await Task.Delay(350)

        Dim DROITE = My.Resources.Locked_One
        Dim GAUCHE = My.Resources.Locked_Two
        Dim HAUT = My.Resources.Locked_Three
        Dim BAS = My.Resources.Locked_Four
        Dim Click_Zone = My.Resources.Click_Zone_Possible2

Label_GotoHome:

        ' ----------------------------------------

        Var.Client_Screen = Var.Update_Screen()
        Dim Locked_Droite As Point = Var.Client_Screen.Contains(DROITE)
        Dim Locked_Gauche As Point = Var.Client_Screen.Contains(GAUCHE)
        Dim Locked_Haut As Point = Var.Client_Screen.Contains(HAUT)
        Dim Locked_Bas As Point = Var.Client_Screen.Contains(BAS)

        Dim Locked As String = 0

        If Locked_Droite <> Nothing Or
            Locked_Gauche <> Nothing Or
            Locked_Haut <> Nothing Or
            Locked_Bas <> Nothing Then

            ' ___________________________________________________________________________________________________________________________________________________________________________

            If Locked_Droite <> Nothing Then
                Dim Locked_True = Locked_Droite.X + 370    '                         >>> | DROIE
                If Locked_True <= 810 Then

                    Console.WriteLine("Locked")

                    Var.Update_Screen()
                    Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                    Console.WriteLine("---DEBUG---")
                    Console.WriteLine(Click_Zone_possible.X)
                    Console.WriteLine(Locked_True)
                    Console.WriteLine("---DEBUG---")
                    If Click_Zone_possible.X = Locked_True Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Droite.X + 370, Locked_Droite.Y)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    ElseIf Click_Zone_possible.X = Locked_True - 100 Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Droite.X + 270, Locked_Droite.Y)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    End If

                Else
                    Dim Locked_True2 = Locked_Droite.X - 370
                    If Locked_True2 >= 20 Then        '                                  | <<< GAUCHE

                        Console.WriteLine("Locked_else")

                        Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                        If Click_Zone_possible.X = Locked_True2 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Droite.X - 370, Locked_Droite.Y)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        ElseIf Click_Zone_possible.X = Locked_True2 + 100 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Droite.X - 270, Locked_Droite.Y)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        End If
                    End If


                End If
            End If


            ' ___________________________________________________________________________________________________________________________________________________________________________

            If Locked_Gauche <> Nothing Then
                Dim Locked_True = Locked_Gauche.X - 370                  '                          | <<< GAUCHE
                If Locked_True >= 20 Then

                    Console.WriteLine("Locked2")

                    Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                    If Click_Zone_possible.X = Locked_True Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Gauche.X - 370, Locked_Gauche.Y)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    ElseIf Click_Zone_possible.X = Locked_True + 100 Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Gauche.X - 270, Locked_Gauche.Y)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    End If


                Else
                    Dim Locked_True2 = Locked_Gauche.X + 370                   '                         >>> | DROITE
                    If Locked_True2 <= 810 Then

                        Console.WriteLine("Locked2_else")

                        Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                        If Click_Zone_possible.X = Locked_True2 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Gauche.X + 370, Locked_Gauche.Y)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        ElseIf Click_Zone_possible.X = Locked_True2 - 100 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Gauche.X + 270, Locked_Gauche.Y)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        End If
                    End If


                End If
            End If

            ' ___________________________________________________________________________________________________________________________________________________________________________

            If Locked_Haut <> Nothing Then
                Dim Locked_True = Locked_Haut.Y - 310    '                    /\   HAUT 
                If Locked_True >= 90 Then

                    Console.WriteLine("Locked3")

                    Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                    If Click_Zone_possible.X = Locked_True Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Haut.X, Locked_Haut.Y - 310)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    ElseIf Click_Zone_possible.X = Locked_True + 100 Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Haut.X, Locked_Haut.Y - 210)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    End If


                Else
                    Dim Locked_True2 = Locked_Haut.X + 310    '                    \/   BAS 
                    If Locked_True2 <= 610 Then

                        Console.WriteLine("Locked3_else")


                        Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                        If Click_Zone_possible.X = Locked_True2 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Haut.X, Locked_Haut.Y + 310)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        ElseIf Click_Zone_possible.X = Locked_True2 - 100 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Haut.X, Locked_Haut.Y + 210)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        End If
                    End If


                End If
            End If

            ' ___________________________________________________________________________________________________________________________________________________________________________

            If Locked_Bas <> Nothing Then
                Dim Locked_True = Locked_Bas.Y + 310 '                    \/   BAS 
                If Locked_True >= 610 Then

                    Console.WriteLine("Locked4")

                    Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                    If Click_Zone_possible.X = Locked_True Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Bas.X, Locked_Bas.Y - 310)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    ElseIf Click_Zone_possible.X = Locked_True + 100 Then

                        AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Bas.X, Locked_Bas.Y - 210)
                        Await Task.Delay(1000)
                        GoTo Label_GotoHome

                    End If

                Else
                    Dim Locked_True2 = Locked_Bas.Y - 310   '                    /\   HAUT 
                    If Locked_True2 >= 90 Then

                        Console.WriteLine("Locked4_else")

                        Dim Click_Zone_possible As Point = Var.Client_Screen.Contains(Click_Zone)
                        If Click_Zone_possible.X = Locked_True2 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Bas.X, Locked_Bas.Y + 310)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        ElseIf Click_Zone_possible.X = Locked_True2 - 100 Then

                            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked_Bas.X, Locked_Bas.Y + 210)
                            Await Task.Delay(1000)
                            GoTo Label_GotoHome

                        End If
                    End If


                End If
            End If

            ' ___________________________________________________________________________________________________________________________________________________________________________

        End If

        Console.WriteLine("finish, restart !")
        Await Task.Delay(1000)
        GoTo Label_GotoHome





















        '                                                                                                               IDEE NUMERO 1




        'Label_General:


        '        Dim Locked1 = My.Resources.Locked_One
        '        Dim Locked2 = My.Resources.Locked_Two
        '        Dim Locked3 = My.Resources.Locked_Three
        '        Dim Locked4 = My.Resources.Locked_Four


        '        ' ----------------------------------------

        '       Var.Client_Screen =Var.Update_Screen()
        '        Dim Locked1_point As Point =Var.Client_Screen.Contains(Locked1)
        '        Dim Locked2_point As Point =Var.Client_Screen.Contains(Locked2)
        '        Dim Locked3_point As Point =Var.Client_Screen.Contains(Locked3)
        '        Dim Locked4_point As Point =Var.Client_Screen.Contains(Locked4)

        '        If Locked1_point <> Nothing Or Locked2_point <> Nothing Or Locked3_point <> Nothing Or Locked4_point <> Nothing Then
        '            Console.WriteLine("Locked")
        '            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 792, 338)
        '            Await Task.Delay(1000)
        '        Else
        '            Await Task.Delay(1000)

        '           Var.Client_Screen =Var.Update_Screen()
        '            Dim Locked12_point As Point =Var.Client_Screen.Contains(Locked1)
        '            Dim Locked22_point As Point =Var.Client_Screen.Contains(Locked2)
        '            Dim Locked32_point As Point =Var.Client_Screen.Contains(Locked3)
        '            Dim Locked42_point As Point =Var.Client_Screen.Contains(Locked4)

        '            If Locked12_point <> Nothing Or Locked22_point <> Nothing Or Locked32_point <> Nothing Or Locked42_point <> Nothing Then
        '                Console.WriteLine("Locked_else")
        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 792, 338)
        '                Await Task.Delay(100)

        '            Else GoTo Label_General


        '            End If
        '        End If

        '        ' ----------------------------------------

        '       Var.Client_Screen =Var.Update_Screen()
        '        Dim Locked11_point As Point =Var.Client_Screen.Contains(Locked1)
        '        Dim Locked21_point As Point =Var.Client_Screen.Contains(Locked2)
        '        Dim Locked31_point As Point =Var.Client_Screen.Contains(Locked3)
        '        Dim Locked41_point As Point =Var.Client_Screen.Contains(Locked4)

        '        If Locked11_point <> Nothing Or Locked21_point <> Nothing Or Locked31_point <> Nothing Or Locked41_point <> Nothing Then
        '            Console.WriteLine("Locked2")
        '            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 592, 21)
        '            Await Task.Delay(1000)
        '        Else
        '            Await Task.Delay(1000)

        '           Var.Client_Screen =Var.Update_Screen()
        '            Dim Locked122_point As Point =Var.Client_Screen.Contains(Locked1)
        '            Dim Locked222_point As Point =Var.Client_Screen.Contains(Locked2)
        '            Dim Locked322_point As Point =Var.Client_Screen.Contains(Locked3)
        '            Dim Locked422_point As Point =Var.Client_Screen.Contains(Locked4)

        '            If Locked122_point <> Nothing Or Locked222_point <> Nothing Or Locked322_point <> Nothing Or Locked422_point <> Nothing Then
        '                Console.WriteLine("Locked2_else")
        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 592, 21)
        '                Await Task.Delay(1000)

        '            Else GoTo Label_General

        '            End If
        '        End If

        '        ' ----------------------------------------

        '       Var.Client_Screen =Var.Update_Screen()
        '        Dim Locked111_point As Point =Var.Client_Screen.Contains(Locked1)
        '        Dim Locked211_point As Point =Var.Client_Screen.Contains(Locked2)
        '        Dim Locked311_point As Point =Var.Client_Screen.Contains(Locked3)
        '        Dim Locked411_point As Point =Var.Client_Screen.Contains(Locked4)

        '        If Locked111_point <> Nothing Or Locked211_point <> Nothing Or Locked311_point <> Nothing Or Locked411_point <> Nothing Then

        '            Console.WriteLine("Locked3")
        '            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 4, 64)
        '            Await Task.Delay(1500)

        '        Else
        '            Await Task.Delay(1000)

        '           Var.Client_Screen =Var.Update_Screen()
        '            Dim Locked122_point As Point =Var.Client_Screen.Contains(Locked1)
        '            Dim Locked222_point As Point =Var.Client_Screen.Contains(Locked2)
        '            Dim Locked322_point As Point =Var.Client_Screen.Contains(Locked3)
        '            Dim Locked422_point As Point =Var.Client_Screen.Contains(Locked4)
        '            If Locked122_point <> Nothing Or Locked222_point <> Nothing Or Locked322_point <> Nothing Or Locked422_point <> Nothing Then

        '                Console.WriteLine("Locked3_else")
        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 4, 64)
        '                Await Task.Delay(1000)

        '            Else GoTo Label_General

        '            End If
        '        End If

        '        ' ----------------------------------------

        '       Var.Client_Screen =Var.Update_Screen()
        '        Dim Locked1111_point As Point =Var.Client_Screen.Contains(Locked1)
        '        Dim Locked2111_point As Point =Var.Client_Screen.Contains(Locked2)
        '        Dim Locked3111_point As Point =Var.Client_Screen.Contains(Locked3)
        '        Dim Locked4111_point As Point =Var.Client_Screen.Contains(Locked4)

        '        If Locked1111_point <> Nothing Or Locked2111_point <> Nothing Or Locked3111_point <> Nothing Or Locked4111_point <> Nothing Then

        '            Console.WriteLine("Locked4")
        '            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 4, 580)
        '            Await Task.Delay(1000)
        '        Else
        '            Await Task.Delay(1000)

        '           Var.Client_Screen =Var.Update_Screen()
        '            Dim Locked122_point As Point =Var.Client_Screen.Contains(Locked1)
        '            Dim Locked222_point As Point =Var.Client_Screen.Contains(Locked2)
        '            Dim Locked322_point As Point =Var.Client_Screen.Contains(Locked3)
        '            Dim Locked422_point As Point =Var.Client_Screen.Contains(Locked4)
        '            If Locked122_point <> Nothing Or Locked222_point <> Nothing Or Locked322_point <> Nothing Or Locked422_point <> Nothing Then

        '                Console.WriteLine("Locked4_else")
        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 4, 580)
        '                Await Task.Delay(1000)

        '            Else GoTo Label_General


        '            End If
        '        End If

        '        ' ----------------------------------------

        '       Var.Client_Screen =Var.Update_Screen()
        '        Dim Locked11111_point As Point =Var.Client_Screen.Contains(Locked1)
        '        Dim Locked21111_point As Point =Var.Client_Screen.Contains(Locked2)
        '        Dim Locked31111_point As Point =Var.Client_Screen.Contains(Locked3)
        '        Dim Locked41111_point As Point =Var.Client_Screen.Contains(Locked4)

        '        If Locked11111_point <> Nothing Or Locked21111_point <> Nothing Or Locked31111_point <> Nothing Or Locked41111_point <> Nothing Then

        '            Console.WriteLine("Locked5")
        '            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 530, 580)
        '            Await Task.Delay(1000)
        '        Else
        '            Await Task.Delay(1000)

        '           Var.Client_Screen =Var.Update_Screen()
        '            Dim Locked122_point As Point =Var.Client_Screen.Contains(Locked1)
        '            Dim Locked222_point As Point =Var.Client_Screen.Contains(Locked2)
        '            Dim Locked322_point As Point =Var.Client_Screen.Contains(Locked3)
        '            Dim Locked422_point As Point =Var.Client_Screen.Contains(Locked4)
        '            If Locked122_point <> Nothing Or Locked222_point <> Nothing Or Locked322_point <> Nothing Or Locked422_point <> Nothing Then

        '                Console.WriteLine("Locked5_else")
        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 530, 580)
        '                Await Task.Delay(1000)

        '            Else GoTo Label_General

        '            End If
        '        End If

        '        ' ----------------------------------------

        '       Var.Client_Screen =Var.Update_Screen()
        '        Dim Locked111111_point As Point =Var.Client_Screen.Contains(Locked1)
        '        Dim Locked211111_point As Point =Var.Client_Screen.Contains(Locked2)
        '        Dim Locked311111_point As Point =Var.Client_Screen.Contains(Locked3)
        '        Dim Locked411111_point As Point =Var.Client_Screen.Contains(Locked4)

        '        If Locked111111_point <> Nothing Or Locked211111_point <> Nothing Or Locked311111_point <> Nothing Or Locked411111_point <> Nothing Then

        '            Console.WriteLine("Locked6")
        '            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 792, 338)
        '            Await Task.Delay(1000)
        '        Else
        '            Await Task.Delay(1000)

        '           Var.Client_Screen =Var.Update_Screen()
        '            Dim Locked122_point As Point =Var.Client_Screen.Contains(Locked1)
        '            Dim Locked222_point As Point =Var.Client_Screen.Contains(Locked2)
        '            Dim Locked322_point As Point =Var.Client_Screen.Contains(Locked3)
        '            Dim Locked422_point As Point =Var.Client_Screen.Contains(Locked4)
        '            If Locked122_point <> Nothing Or Locked222_point <> Nothing Or Locked322_point <> Nothing Or Locked422_point <> Nothing Then

        '                Console.WriteLine("Locked6_else")
        '                AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, 792, 338)
        '                Await Task.Delay(1000)

        '            Else GoTo Label_General

        '            End If
        '        End If

        '        ' ----------------------------------------

        '        Console.WriteLine("finish")
        '        Await Task.Delay(500)
        '        GoTo Label_General


        ' ----------------------------------------
        ' ----------------------------------------
        ' ----------------------------------------




























        'If Locked1_point.X + 400 >= 800 Then
        '    Locked1_point.X = 600
        '    Console.WriteLine("en dehors du form")
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked1_point.X, Locked1_point.Y)
        'ElseIf Locked1_point.X <= 100 Then
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, (Size.Width / 2) - 50, (Height / 2))
        '    Await Task.Delay(100)
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, (Size.Width / 2) + 20, (Height / 2))
        '    Await Task.Delay(250)
        'ElseIf Locked1_point.X >= 160 Then
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked1_point.X + 450, Locked1_point.Y)
        'Else
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked1_point.X + 400, Locked1_point.Y)
        '    'Client_Screen =Var.Update_Screen()
        '    'Locked1_1 =Var.Client_Screen.Contains(Locked1)
        '    'Await Task.Delay(350)
        '    'AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked1_point.X + 300, Locked1_point.Y)
        '    'Client_Screen =Var.Update_Screen()
        '    'Locked1_1 =Var.Client_Screen.Contains(Locked1)
        '    'Await Task.Delay(350)
        '    'AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked1_point.X + 400, Locked1_point.Y)
        'End If
        'Console.WriteLine(Locked1_point.X)
        'Await Task.Delay(250)
        'GoTo Label_General

        'Dim Locked2 = My.Resources.Locked_Two
        'Dim Locked2_point As Point =Var.Client_Screen.Contains(Locked2)

        'If Locked2_point <> Nothing Then

        '    Console.WriteLine("Locked gauche")
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked2_point.X - 360, Locked2_point.Y)
        '    Await Task.Delay(500)
        '    GoTo Label_General

        'End If

        'Dim Locked3 = My.Resources.Locked_Three
        'Dim Locked3_point As Point =Var.Client_Screen.Contains(Locked3)

        'If Locked3_point <> Nothing Then

        '    Console.WriteLine("Locked haut")
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked3_point.X - 360, Locked3_point.Y)
        '    Await Task.Delay(500)
        '    GoTo Label_General

        'End If

        'Dim Locked4 = My.Resources.Locked_Four
        'Dim Locked4_point As Point =Var.Client_Screen.Contains(Locked4)

        'If Locked4_point <> Nothing Then

        '    Console.WriteLine("Locked bas")
        '    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Locked4_point.X + 360, Locked4_point.Y)
        '    Await Task.Delay(500)
        '    GoTo Label_General
        'End If

        'If Locked1_point = Nothing And Locked2_point = Nothing Or Locked3_point = Nothing Or Locked4_point = Nothing Then
        '    Console.WriteLine("finish")
        '    Exit Sub
        'End If














    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Aider_Streuner = My.Resources.Aider_streuner
        Dim Aider_Streuner1 As Point = Var.Client_Screen.Contains(Aider_Streuner)
        If Aider_Streuner1 <> Nothing Then

            Console.WriteLine("Un Aider_Streuner trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Aider_Streuner1.X + 30, Aider_Streuner1.Y - 55)
            If_Locked()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Recruit_streuner = My.Resources.recruit_streuner
        Dim Recruit_streuner1 As Point = Var.Client_Screen.Contains(Recruit_streuner)
        If Recruit_streuner1 <> Nothing Then

            Console.WriteLine("Un Recruit_streuner trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Recruit_streuner1.X + 30, Recruit_streuner1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim streuner = My.Resources.streuner
        Dim streuner1 As Point = Var.Client_Screen.Contains(streuner)
        If streuner1 <> Nothing Then

            Console.WriteLine("Un streuner trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, streuner1.X + 30, streuner1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Lordakia = My.Resources.lordakia
        Dim Lordakia1 As Point = Var.Client_Screen.Contains(Lordakia)
        If Lordakia1 <> Nothing Then

            Console.WriteLine("Un Lordakia trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Lordakia1.X + 30, Lordakia1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Boss_streuner = My.Resources.boss_streuner
        Dim Boss_streuner1 As Point = Var.Client_Screen.Contains(Boss_streuner)
        If Boss_streuner1 <> Nothing Then

            Console.WriteLine("Un Boss_streuner trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Boss_streuner1.X + 30, Boss_streuner1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Boss_Lordakia = My.Resources.boss_Lordakia
        Dim Boss_Lordakia1 As Point = Var.Client_Screen.Contains(Boss_Lordakia)
        If Boss_Lordakia1 <> Nothing Then

            Console.WriteLine("Un Boss_Lordakia trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Boss_Lordakia1.X + 30, Boss_Lordakia1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Saimon = My.Resources.Saimon
        Dim Saimon1 As Point = Var.Client_Screen.Contains(Saimon)
        If Saimon1 <> Nothing Then

            Console.WriteLine("Un Boss_Lordakia trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Saimon1.X + 30, Saimon1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Boss_Saimon = My.Resources.Boss_Saimon
        Dim Boss_Saimon1 As Point = Var.Client_Screen.Contains(Boss_Saimon)
        If Boss_Saimon1 <> Nothing Then

            Console.WriteLine("Un Boss_Lordakia trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Boss_Saimon1.X + 30, Boss_Saimon1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Mordon = My.Resources.Mordon
        Dim Mordon1 As Point = Var.Client_Screen.Contains(Mordon)
        If Mordon1 <> Nothing Then

            Console.WriteLine("Un Boss_Lordakia trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Mordon1.X + 30, Mordon1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim boss_mordon = My.Resources.boss_mordon
        Dim boss_mordon1 As Point = Var.Client_Screen.Contains(boss_mordon)
        If boss_mordon1 <> Nothing Then

            Console.WriteLine("Un Boss_Lordakia trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, boss_mordon1.X + 30, boss_mordon1.Y - 55)
            If_Locked()

        End If

    End Sub

#End Region

    '  Dim alpha_portal_x = Utils.GetPortalCenter(628, "x")
    '   Dim alpha_portal_y = Utils.GetPortalCenter(488, "y")
    ' AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "LEFT", 1, 628, 488)

    Public Traveling_return As Integer = 0
    Public Property Main As Object
    Public Property HeroManager As Object

    Private Async Sub Red_dots_function_Click(sender As Object, e As EventArgs) Handles Red_dots_function.Click

        Dim HAUT_GAUCHE_X As Integer = "599"
        Dim HAUT_DROITE_Y As Integer = "774"
        Dim BAS_GAUCHE_X As Integer = "466"
        Dim BAS_DROITE_Y As Integer = "575"

        Try

            'Dim Red_dots = AutoIt.PixelSearch(HAUT_GAUCHE_X, HAUT_DROITE_Y, BAS_GAUCHE_X, BAS_DROITE_Y, 13369344, 1, 1)
            Dim Red_dots = AutoIt.PixelSearch(BAS_GAUCHE_X, HAUT_DROITE_Y, HAUT_GAUCHE_X, BAS_DROITE_Y, 13369344, 1, 1)
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Red_dots.X, Red_dots.Y)
            Await Task.Delay(1000)

        Catch Red_dots_not_found As Exception

            Console.WriteLine("Error 3286")

        End Try

    End Sub

    '{Me.add(1, "1-1", New Portal(150000159, 2))
    'Me.add(2, "1-2", New Portal(150000160, 1), New Portal(150000161, 3), New Portal(150000163, 4))
    '    Me.add(3, "1-3", New Portal(150000162, 2), New Portal(150000185, 4), New Portal(150000165, 7))
    '    Me.add(4, "1-4", New Portal(150000164, 2), New Portal(150000186, 3), New Portal(150000189, 13), New Portal(150000169, 12))
    '    Me.add(17, "1-5", New Portal(150000299, 16), New Portal(150000328, 29), New Portal(150000300, 18), New Portal(150000302, 19))
    '    Me.add(18, "1-6", New Portal(150000301, 17), New Portal(150000304, 20))
    '    Me.add(19, "1-7", New Portal(150000306, 20), New Portal(150000303, 17))
    '    Me.add(20, "1-8", New Portal(150000305, 18), New Portal(150000307, 19))
    '    Me.add(5, "2-1", New Portal(150000174, 6))
    '    Me.add(6, "2-2", New Portal(150000168, 7), New Portal(150000175, 8), New Portal(150000173, 5))
    '    Me.add(7, "2-3", New Portal(150000166, 3), New Portal(150000183, 8), New Portal(150000167, 6))
    '    Me.add(8, "2-4", New Portal(150000184, 7), New Portal(150000191, 14), New Portal(150000176, 6), New Portal(150000177, 11))
    '    Me.add(21, "2-5", New Portal(150000330, 16), New Portal(150000309, 29), New Portal(150000310, 22), New Portal(150000312, 23))
    '    Me.add(22, "2-6", New Portal(150000311, 21), New Portal(150000314, 24))
    '    Me.add(23, "2-7", New Portal(150000313, 21), New Portal(150000316, 24))
    '    Me.add(24, "2-8", New Portal(150000315, 22), New Portal(150000317, 23))
    '    Me.add(9, "3-1", New Portal(150000182, 10))
    '    Me.add(10, "3-2", New Portal(150000180, 11), New Portal(150000172, 12), New Portal(150000181, 9))
    '    Me.add(11, "3-3", New Portal(150000178, 8), New Portal(150000188, 12), New Portal(150000179, 10))
    '    Me.add(12, "3-4", New Portal(150000170, 4), New Portal(150000193, 15), New Portal(150000187, 11), New Portal(150000171, 10))
    '    Me.add(25, "3-5", New Portal(150000319, 16), New Portal(150000332, 29), New Portal(150000320, 26), New Portal(150000322, 27))
    '    Me.add(26, "3-6", New Portal(150000321, 25), New Portal(150000324, 28))
    '    Me.add(27, "3-7", New Portal(150000323, 25), New Portal(150000326, 28))
    '    Me.add(28, "3-8", New Portal(150000327, 27), New Portal(150000325, 26))
    '    Me.add(13, "4-1", New Portal(150000190, 4), New Portal(150000195, 14), New Portal(150000200, 15), New Portal(150000289, 16))
    '    Me.add(14, "4-2", New Portal(150000192, 8), New Portal(150000196, 13), New Portal(150000197, 15), New Portal(150000291, 16))
    '    Me.add(15, "4-3", New Portal(150000194, 12), New Portal(150000198, 14), New Portal(150000199, 13), New Portal(150000293, 16))
    '    Me.add(16, "4-4", New Portal(150000318, 25), New Portal(150000294, 15), New Portal(150000292, 14), New Portal(150000308, 21), New Portal(150000298, 17), New Portal(150000290, 13))
    '    Me.add(29, "4-5", New Portal(150000329, 17), New Portal(150000331, 21), New Portal(150000333, 15))
    '    Me.add(223, "Devolarium Attack")
    '    Me.fill
    'Unknown

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click


        Dim myProcess = System.Diagnostics.Process.GetProcessesByName("RidevBot")
        Dim MyAddress As IntPtr = myProcess.Length

        Console.WriteLine(MyAddress)

        'Dim HAUT_GAUCHE_X As Integer = "599"
        'Dim HAUT_DROITE_Y As Integer = "774"
        'Dim BAS_GAUCHE_X As Integer = "466"
        'Dim BAS_DROITE_Y As Integer = "575"



        'Dim CLICK_X As Integer = Utils.GetRandom(HAUT_GAUCHE_X, HAUT_DROITE_Y)

        'Dim CLICK_Y As Integer = Utils.GetRandom(HAUT_GAUCHE_X, BAS_GAUCHE_X)

        'AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, CLICK_X, CLICK_Y)

    End Sub

    Private Sub Button_dead_Click(sender As Object, e As EventArgs) Handles Button_dead.Click



    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Var.Client_Screen = Var.Update_Screen()
        Dim Sibelonit = My.Resources.sibelonit
        Dim Sibelonit1 As Point = Var.Client_Screen.Contains(Sibelonit)
        If Sibelonit1 <> Nothing Then

            Console.WriteLine("Un Sibelonit trouver")
            AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, Sibelonit1.X + 30, Sibelonit1.Y - 55)
            If_Locked()

        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        If_Locked()

    End Sub
End Class

'Private Sub Random_movement()


'    'Dim random As New Random(), rndnbr As Integer
'    '    rndnbr = random.Next(A6 + 60, A62 + 60)
'    '    Dim random2 As New Random(), rndnbr2 As Integer
'    '    rndnbr2 = random2.Next(A61 - 20, A63 - 20)

'    '    AutoIt.ControlClick("Form3", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, rndnbr, rndnbr2)

'End Sub


'npc killer

'Try
'    Dim A1 As Integer = (WebBrowser_Game_Ridevbot.Location.X)
'    Dim A2 As Integer = (WebBrowser_Game_Ridevbot.Location.Y - 18)
'    Dim A3 As Integer = (WebBrowser_Game_Ridevbot.Width)
'    Dim A4 As Integer = (WebBrowser_Game_Ridevbot.Height)

'    Dim result = AutoIt.PixelSearch(A1, A2, A3, A4, 13369344, 0, 1)


























'    Console.WriteLine(result)

'    AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, result(0) + 40, result(1) - 40)
'    AutoIt.ControlSend("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", (1))
'Catch ex As Exception
'  AutoIt.ControlClick("RidevBot", "", "[CLASS:MacromediaFlashPlayerActiveX; INSTANCE:1]", "left", 1, palla(0), palla(1))
'End Try
























'Dim pt_bouclier As Point = B.Contains(dest_bouclier)
'If pt_bouclier <> Nothing Then
'    '... image found at pt
'    MsgBox($"found logout at {pt_bouclier.X}-{pt_bouclier.Y}")
'    Cursor.Position = New Point(pt_bouclier.X, pt_bouclier.Y + 18)
'End If


'Dim pt_mission1 As Point = B.Contains(dest_mission)
'If pt_mission1 <> Nothing Then
'    '... image found at pt
'    MsgBox($"found mission at {pt_mission1.X}-{pt_mission1.Y}")
'    Cursor.Position = New Point(pt_mission1.X, pt_mission1.Y + 18)
'End If

'Dim pt_map As Point = B.Contains(dest_map)
'If pt_map <> Nothing Then
'    '... image found at pt
'    MsgBox($"found map at {pt_map.X}-{pt_map.Y}")
'    Cursor.Position = New Point(pt_map.X, pt_map.Y + 18)


















' pour le click souris + blocage

'BlockInput(True)
'Console.WriteLine("désactivé")

'Cursor.Position = New Point(Minimap_size.X, Minimap_size.Y + 18)
'AutoIt.MouseClick("LEFT")

'BlockInput(False)
'Console.WriteLine("activé")









' Dim dest_heal = My.Resources.heal