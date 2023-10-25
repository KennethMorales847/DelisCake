Public Class proveedores_form
    Private Sub proveedores_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeDatabaseDataSet.Proveedores_Table' table. You can move, or remove it, as needed.
        Me.Proveedores_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Proveedores_Table)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Proveedores_TableTableAdapter.agregar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text)
        Me.Proveedores_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Proveedores_Table)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Proveedores_TableTableAdapter.modificar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox1.Text)
        Me.Proveedores_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Proveedores_Table)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Proveedores_TableTableAdapter.borrar(TextBox1.Text)
        Me.Proveedores_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Proveedores_Table)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Proveedores_TableTableAdapter.buscar(DelisCakeDatabaseDataSet.Proveedores_Table, TextBox1.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Proveedores_TableTableAdapter.mostrar(DelisCakeDatabaseDataSet.Proveedores_Table)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class