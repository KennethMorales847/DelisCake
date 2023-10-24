Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class productos_terminados_form
    Private Sub productos_terminados_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeDatabaseDataSet.Productos_Terminados_Table' table. You can move, or remove it, as needed.
        Me.Productos_Terminados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Productos_Terminados_Table)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Productos_Terminados_TableTableAdapter.agregar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        Me.Productos_Terminados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Productos_Terminados_Table)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Productos_Terminados_TableTableAdapter.modificar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox1.Text)
        Me.Productos_Terminados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Productos_Terminados_Table)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Productos_Terminados_TableTableAdapter.borrar(TextBox1.Text)
        Me.Productos_Terminados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Productos_Terminados_Table)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Productos_Terminados_TableTableAdapter.buscar(DelisCakeDatabaseDataSet.Productos_Terminados_Table, TextBox1.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Productos_Terminados_TableTableAdapter.mostrar(DelisCakeDatabaseDataSet.Productos_Terminados_Table)
    End Sub
End Class