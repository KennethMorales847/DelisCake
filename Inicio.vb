Imports Microsoft.VisualBasic.Logging

Public Class IniciarSesion
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        ' Este manejador de eventos está vacío, por lo que no es necesario hacer nada aquí.
    End Sub

    Private Sub btn_iniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_iniciarSesion.Click
        ' Abre el formulario Login.vb
        Dim InicioSesionForm As New InicioSesion()
        InicioSesionForm.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Este manejador de eventos está vacío, por lo que no es necesario hacer nappda aquí.
    End Sub

    Private Sub btn_registrarse_Click(sender As Object, e As EventArgs)
        ' Abre el formulario Registro.vb
        Dim registroForm As New Registro()
        registroForm.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub
End Class
