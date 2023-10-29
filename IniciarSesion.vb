Imports System.IO

Public Class InicioSesion
    Private Sub Button_IniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Try
            Dim nombreUsuario As String = TextBox_NombreLogin.Text
            Dim contraseñaIngresada As String = TextBox_ContraseñaLogin.Text

            ' Ruta del archivo de usuarios
            Dim rutaArchivo As String = If(CheckBox_Usuario.Checked, "Usuarios.txt", "Administradores.txt")

            If File.Exists(rutaArchivo) Then
                Dim usuarioEncontrado As Boolean = False

                ' Mostrar un mensaje de procesamiento
                MessageBox.Show("Procesando datos...", "Proceso en curso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Using lector As New StreamReader(rutaArchivo)
                    Dim linea As String
                    While (Not usuarioEncontrado) AndAlso (lector.Peek() >= 0)
                        linea = lector.ReadLine()
                        Dim partes As String() = linea.Split(","c)
                        If partes.Length = 2 AndAlso partes(0) = nombreUsuario Then
                            If partes(1) = contraseñaIngresada Then
                                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                usuarioEncontrado = True

                                ' Ocultar el formulario actual
                                Me.Hide()

                                ' Abrir el formulario correspondiente 
                                Dim formulario As Form
                                If CheckBox_Usuario.Checked Then
                                    formulario = New MenuEmpleados()
                                Else
                                    formulario = New MenuAdmin()
                                End If
                                formulario.Show()
                            Else
                                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    End While
                End Using

                If Not usuarioEncontrado Then
                    MessageBox.Show("Nombre de usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show($"Archivo '{rutaArchivo}' no encontrado en la ubicación de la aplicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_registrarse_Click(sender As Object, e As EventArgs)
        ' Ocultar el formulario actual
        Me.Hide()

        ' Abrir el formulario de registro (Registro.vb)
        Dim registroForm As New Registro()
        registroForm.Show()
    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar TextBox_ContraseñaLogin para mostrar asteriscos
        TextBox_ContraseñaLogin.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class
