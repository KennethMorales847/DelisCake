Imports System.IO

Public Class InicioSesion
    Private Sub Button_IniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Try
            Dim nombreUsuario As String = TextBox_NombreLogin.Text
            Dim contraseñaIngresada As String = TextBox_ContraseñaLogin.Text

            ' Ruta del archivo "Usuarios.txt" en la ubicación especificada
            Dim rutaArchivo As String = "E:\D E L I S C A K E\DelisCake\bin\Debug\Usuarios.txt"

            If File.Exists(rutaArchivo) Then
                Dim usuarioEncontrado As Boolean = False

                Using lector As New StreamReader(rutaArchivo)
                    Dim linea As String
                    While (Not usuarioEncontrado) AndAlso (linea IsNot Nothing)
                        Dim partes As String() = linea.Split(","c)
                        If partes.Length = 2 AndAlso partes(0) = nombreUsuario Then
                            If partes(1) = contraseñaIngresada Then
                                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                usuarioEncontrado = True
                            Else
                                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                        linea = lector.ReadLine()
                    End While
                End Using

                If Not usuarioEncontrado Then
                    MessageBox.Show("Nombre de usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Archivo 'Usuarios.txt' no encontrado en la ubicación especificada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class