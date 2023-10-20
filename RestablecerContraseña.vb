Imports System.IO

Public Class RestablecerContraseña
    Private Sub BT_confirmar_Click(sender As Object, e As EventArgs) Handles BT_confirmar.Click
        Try
            Dim nombreUsuario As String = TextBox_Nombre.Text
            Dim nuevaContraseña As String = TextBox_Contraseña.Text

            ' Ruta del archivo de usuarios
            Dim rutaArchivo As String = If(CheckBox_Usuario.Checked, "Usuarios.txt", "Administradores.txt")

            If File.Exists(rutaArchivo) Then
                Dim usuarios As New List(Of String)
                Dim usuarioEncontrado As Boolean = False

                Using lector As New StreamReader(rutaArchivo)
                    Dim linea As String
                    While lector.Peek() >= 0
                        linea = lector.ReadLine()
                        Dim partes As String() = linea.Split(","c)
                        If partes.Length = 2 AndAlso partes(0) = nombreUsuario Then
                            usuarioEncontrado = True
                            ' Reemplazar la contraseña anterior con la nueva
                            usuarios.Add($"{nombreUsuario},{nuevaContraseña}")
                        Else
                            usuarios.Add(linea)
                        End If
                    End While
                End Using


                ' Confirmación de restablecimiento
                Dim mensaje As String
                If usuarioEncontrado Then
                    mensaje = "¿Está seguro de restablecer la contraseña?"
                Else
                    mensaje = "Nombre de usuario no encontrado. ¿Está seguro de que los datos son correctos?"
                End If

                Dim confirmacion As DialogResult = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmacion = DialogResult.Yes Then
                    ' Sobrescribir el archivo con la lista actualizada
                    Using escritor As New StreamWriter(rutaArchivo, False)
                        For Each usuario In usuarios
                            escritor.WriteLine(usuario)
                        Next
                    End Using

                    MessageBox.Show("Contraseña restablecida con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show($"Archivo '{rutaArchivo}' no encontrado en la ubicación de la aplicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al restablecer la contraseña: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BT_limpiar_Click(sender As Object, e As EventArgs) Handles BT_limpiar.Click
        TextBox_Nombre.Clear()
        TextBox_Contraseña.Clear()
        CheckBox_Usuario.Checked = False
        CheckBox_Admin.Checked = False
    End Sub
End Class
