Public Class Materia_Prima_Form
    Private Sub Materia_Prima_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeDatabaseDataSet.Materia_Prima_Table' table. You can move, or remove it, as needed.
        Me.Materia_Prima_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Materia_Prima_Table)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Materia_Prima_TableTableAdapter.agregar(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, TextBox5.Text, TextBox6.Text)
        Me.Materia_Prima_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Materia_Prima_Table)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Materia_Prima_TableTableAdapter.modificar(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, TextBox5.Text, TextBox6.Text, TextBox1.Text)
        Me.Materia_Prima_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Materia_Prima_Table)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Materia_Prima_TableTableAdapter.borrar(TextBox1.Text)
        Me.Materia_Prima_TableTableAdapter.Fill(Me.DelisCakeDatabaseDataSet.Materia_Prima_Table)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Materia_Prima_TableTableAdapter.buscar(DelisCakeDatabaseDataSet.Materia_Prima_Table, TextBox1.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Materia_Prima_TableTableAdapter.mostrar(DelisCakeDatabaseDataSet.Materia_Prima_Table)
    End Sub


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        MenuAdmin.Show()
    End Sub
End Class