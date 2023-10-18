Imports System.IO

Public Class Registro
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles L_Contraseña.Click
        ' Este manejador de eventos está vacío, por lo que no es necesario hacer nada aquí.
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        ' Limpia los TextBox
        TextBox_Nombre.Clear()
        TextBox_Contraseña.Clear()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Try
            Dim rutaArchivo As String = "E:\D E L I S C A K E\DelisCake\bin\Debug\Recursos\" + TextBox_Nombre.Text + ".txt"
            Dim RegistrarUsuario As TextWriter = New StreamWriter(rutaArchivo, True)
            RegistrarUsuario.WriteLine(TextBox_Contraseña.Text)
            RegistrarUsuario.Close()

            MessageBox.Show("El Usuario se registró exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Usuario o Contraseña no Válidos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btn_registrar.Click, AddressOf btn_registrar_Click
    End Sub
End Class
