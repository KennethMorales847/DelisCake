Public Class MenuEmpleados
    Private Sub btn_materiaPrima_Click(sender As Object, e As EventArgs) Handles btn_materiaPrima.Click
        materia_prima_form.Show()
        Me.Hide()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        productos_terminados_form.Show()
        Me.Hide()
    End Sub
End Class