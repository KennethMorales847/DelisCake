Public Class MenuAdmin
    Private Sub btn_ajustes_Click(sender As Object, e As EventArgs) Handles btn_ajustes.Click
        Dim ajustesUsuarioForm As New AjustesUsuario()
        ajustesUsuarioForm.Show()
    End Sub

    Private Sub btn_planilla_Click(sender As Object, e As EventArgs) Handles btn_planilla.Click
        trabajadores_form.Show()
        Me.Hide()

    End Sub

    Private Sub btn_materiaPrima_Click(sender As Object, e As EventArgs) Handles btn_materiaPrima.Click
        materia_prima_form.Show()
        Me.Hide()
    End Sub

    Private Sub btn_proveedores_Click(sender As Object, e As EventArgs) Handles btn_proveedores.Click
        proveedores_form.Show()
        Me.Hide()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        productos_terminados_form.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
