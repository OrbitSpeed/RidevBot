Public Class Extension

    Public Shared Function Load() As Task

        ' ICI ON PEUT GERER LES PRIORITER
        Console.WriteLine("Extension set/")

    End Function
End Class


' CLASS EXTERIEUR DE FUSION 
Public Class Form_tools

        Private Sub CheckBox_alpha_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_alpha_gates_module.CheckedChanged

        If CheckBox_alpha_gates_module.Checked = True Then
            CheckBox_alpha_gates_module.ForeColor = Color.Lime
        Else CheckBox_alpha_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
        Private Sub CheckBox_beta_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_beta_gates_module.CheckedChanged

        If CheckBox_beta_gates_module.Checked = True Then
            CheckBox_beta_gates_module.ForeColor = Color.Lime
        Else CheckBox_beta_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
        Private Sub CheckBox_gamma_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_gamma_gates_module.CheckedChanged

        If CheckBox_gamma_gates_module.Checked = True Then
            CheckBox_gamma_gates_module.ForeColor = Color.Lime
        Else CheckBox_gamma_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
        Private Sub CheckBox_delta_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_delta_gates_module.CheckedChanged

        If CheckBox_delta_gates_module.Checked = True Then
            CheckBox_delta_gates_module.ForeColor = Color.Lime
        Else CheckBox_delta_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
        Private Sub CheckBox_epsilon_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_epsilon_gates_module.CheckedChanged

        If CheckBox_epsilon_gates_module.Checked = True Then
            CheckBox_epsilon_gates_module.ForeColor = Color.Lime
        Else CheckBox_epsilon_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
    Private Sub CheckBox_zeta_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_zeta_gates_module.CheckedChanged

        If CheckBox_zeta_gates_module.Checked = True Then
            CheckBox_zeta_gates_module.ForeColor = Color.Lime
        Else CheckBox_zeta_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
    Private Sub CheckBox_kappa_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_kappa_gates_module.CheckedChanged

        If CheckBox_kappa_gates_module.Checked = True Then
            CheckBox_kappa_gates_module.ForeColor = Color.Lime
        Else CheckBox_kappa_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
        Private Sub CheckBox_lambda_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_lambda_gates_module.CheckedChanged

        If CheckBox_lambda_gates_module.Checked = True Then
            CheckBox_lambda_gates_module.ForeColor = Color.Lime
        Else CheckBox_lambda_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
        Private Sub CheckBox_hades_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_hades_gates_module.CheckedChanged

        If CheckBox_hades_gates_module.Checked = True Then
            CheckBox_hades_gates_module.ForeColor = Color.Lime
        Else CheckBox_hades_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
        Private Sub CheckBox_chronos_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_chronos_gates_module.CheckedChanged

        If CheckBox_chronos_gates_module.Checked = True Then
            CheckBox_chronos_gates_module.ForeColor = Color.Lime
        Else CheckBox_chronos_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub
    Private Sub CheckBox_kuiper_gates_module_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_kuiper_gates_module.CheckedChanged

        If CheckBox_kuiper_gates_module.Checked = True Then
            CheckBox_kuiper_gates_module.ForeColor = Color.Lime
        Else CheckBox_kuiper_gates_module.ForeColor = Color.DarkRed
        End If

    End Sub

    ' _________________________________________________________________

    Private Sub Button_alpha_gates_module_Click(sender As Object, e As EventArgs) Handles Button_alpha_gates_module.Click
        Panel_Alpha_configuration_func.Visible = True
    End Sub
    Private Sub Button_beta_gates_module_Click(sender As Object, e As EventArgs) Handles Button_beta_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_gamma_gates_module_Click(sender As Object, e As EventArgs) Handles Button_gamma_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_delta_gates_module_Click(sender As Object, e As EventArgs) Handles Button_delta_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_epsilon_gates_module_Click(sender As Object, e As EventArgs) Handles Button_epsilon_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_zeta_gates_module_Click(sender As Object, e As EventArgs) Handles Button_zeta_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_kappa_gates_module_Click(sender As Object, e As EventArgs) Handles Button_kappa_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_lambda_gates_module_Click(sender As Object, e As EventArgs) Handles Button_lambda_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_hades_gates_module_Click(sender As Object, e As EventArgs) Handles Button_hades_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_kuiper_gates_module_Click(sender As Object, e As EventArgs) Handles Button_kuiper_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub
    Private Sub Button_chronos_gates_module_Click(sender As Object, e As EventArgs) Handles Button_chronos_gates_module.Click
        Panel_Alpha_configuration_func.Visible = False
    End Sub

End Class