Public Class AjustesUsuario

    Private Sub btn_restablecer_Click(sender As Object, e As EventArgs) Handles btn_restablecer.Click
        Dim restablecerForm As New RestablecerContraseña()
        restablecerForm.Show()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim eliminarForm As New EliminarUsuario()
        eliminarForm.Show()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim registroForm As New Registro()
        registroForm.Show()
    End Sub

    Private Sub AjustesUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_vitacora_Click(sender As Object, e As EventArgs) Handles btn_vitacora.Click
        Dim registroForm As New BitacoraUsuarios()
        registroForm.Show()
    End Sub
End Class
