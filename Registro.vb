Imports System.IO

Public Class Registro
    Private Sub Button_Registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Try
            Dim nombreUsuario As String = TextBox_Nombre.Text
            Dim contraseña As String = TextBox_Contraseña.Text

            ' Ruta del archivo "Usuarios.txt"
            Dim rutaArchivo As String = "Usuarios.txt"

            ' Verificar si el nombre de usuario ya existe
            If File.Exists(rutaArchivo) Then
                Using lector As New StreamReader(rutaArchivo)
                    Dim linea As String
                    While True
                        linea = lector.ReadLine()
                        If linea Is Nothing Then
                            Exit While
                        End If
                        Dim partes As String() = linea.Split(","c)
                        If partes.Length = 2 AndAlso partes(0) = nombreUsuario Then
                            MessageBox.Show("El nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return ' Salir de la función si el nombre ya existe
                        End If
                    End While
                End Using
            End If

            ' Formato: nombreUsuario,contraseña
            Dim nuevaLinea As String = $"{nombreUsuario},{contraseña}"

            ' Agregar el nuevo usuario al archivo
            Using escritor As New StreamWriter(rutaArchivo, True)
                escritor.WriteLine(nuevaLinea)
            End Using

            MessageBox.Show("Usuario registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Hubo un error al registrar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
