Imports System.IO
Imports System.Data

Public Class BitacoraUsuarios
    Private Sub BitacoraUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers("Usuarios.txt", DataGridViewUsuarios)
        LoadUsers("Administradores.txt", DataGridViewAdministradores)
    End Sub

    Private Sub LoadUsers(filePath As String, dataGridView As DataGridView)
        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim dt As New DataTable()
            dt.Columns.Add("Usuario")
            dt.Columns.Add("Contraseña") ' Agregamos una columna para la contraseña

            For Each line As String In lines
                Dim parts As String() = line.Split(","c) ' Dividir la línea en usuario y contraseña
                If parts.Length = 2 Then
                    dt.Rows.Add(parts(0), parts(1))
                End If
            Next

            dataGridView.DataSource = dt
        Else
            MessageBox.Show($"El archivo {filePath} no existe.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
