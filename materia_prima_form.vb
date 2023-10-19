Public Class materia_prima_form
    Private Sub materia_prima_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeSet4.MP' table. You can move, or remove it, as needed.
        Me.MPTableAdapter.Fill(Me.DelisCakeSet4.MP)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MPTableAdapter.agregar(Id_IngredienteTextBox.Text, NombreTextBox.Text, CategoriaTextBox.Text, Fecha_CompraDateTimePicker.Text, Fecha_VencimientoDateTimePicker.Text, Unidad_MedidaTextBox.Text, CantidadTextBox.Text, IVA_UnitarioTextBox.Text)
        Me.MPTableAdapter.Fill(Me.DelisCakeSet4.MP)
    End Sub
End Class