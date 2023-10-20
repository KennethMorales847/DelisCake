Imports System.IO

Public Class EliminarUsuario
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            Dim nombreUsuario As String = TextBox_Nombre.Text
            Dim contraseñaIngresada As String = TextBox_Contraseña.Text

            ' Ruta del archivo de usuarios
            Dim rutaArchivo As String = If(CheckBox_Usuario.Checked, "Usuarios.txt", "Administradores.txt")

            If File.Exists(rutaArchivo) Then
                Dim usuarios As New List(Of String)

                Using lector As New StreamReader(rutaArchivo)
                    Dim linea As String
                    While lector.Peek() >= 0
                        linea = lector.ReadLine()
                        Dim partes As String() = linea.Split(","c)
                        If partes.Length = 2 AndAlso partes(0) = nombreUsuario AndAlso partes(1) = contraseñaIngresada Then
                            ' No agregamos el usuario a la lista, lo estamos eliminando
                        Else
                            usuarios.Add(linea)
                        End If
                    End While
                End Using

                ' Sobrescribir el archivo con la lista actualizada
                Using escritor As New StreamWriter(rutaArchivo, False)
                    For Each usuario In usuarios
                        escritor.WriteLine(usuario)
                    Next
                End Using

                MessageBox.Show("Usuario eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"Archivo '{rutaArchivo}' no encontrado en la ubicación de la aplicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al eliminar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        TextBox_Nombre.Clear()
        TextBox_Contraseña.Clear()
        CheckBox_Usuario.Checked = False
        CheckBox_Admin.Checked = False
    End Sub
End Class
