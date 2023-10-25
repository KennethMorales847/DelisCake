Public Class trabajadores_form
    Private Sub trabajadores_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeDatabaseDataSet.Planilla_Empleados_Table' table. You can move, or remove it, as needed.
        Me.Planilla_Empleados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Planilla_Empleados_Table)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Planilla_Empleados_TableTableAdapter.agregar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text)
        Me.Planilla_Empleados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Planilla_Empleados_Table)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Planilla_Empleados_TableTableAdapter.modificar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox1.Text)
        Me.Planilla_Empleados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Planilla_Empleados_Table)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Planilla_Empleados_TableTableAdapter.borrar(TextBox1.Text)
        Me.Planilla_Empleados_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Planilla_Empleados_Table)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Planilla_Empleados_TableTableAdapter.buscar(DelisCakeDatabaseDataSet.Planilla_Empleados_Table, TextBox1.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Planilla_Empleados_TableTableAdapter.mostrar(DelisCakeDatabaseDataSet.Planilla_Empleados_Table)
    End Sub


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class