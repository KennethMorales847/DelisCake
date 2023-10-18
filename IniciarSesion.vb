Imports System.IO

Public Class InicioSesion
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Este manejador de eventos está vacío, por lo que no es necesario hacer nada aquí.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Try
            Dim rutaArchivo As String = TextBox_NombreLogin.Text & ".txt"
            Dim Inicio As TextReader = New StreamReader(rutaArchivo)

            Dim contraseñaGuardada As String = Inicio.ReadLine()
            Inicio.Close()

            If contraseñaGuardada = TextBox_ContraseñaLogin.Text Then
                MessageBox.Show("Se Inició Sesión Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo Iniciar Sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
