Public Class MenuEmpleados
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        InicioSesion.Show()

    End Sub

    Private Sub btn_materiaPrima_Click(sender As Object, e As EventArgs) Handles btn_materiaPrima.Click
        Me.Hide()
        empleados_materia_prima.Show()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        Me.Hide()
        empleados_productos_terminados.Show()

    End Sub
End Class