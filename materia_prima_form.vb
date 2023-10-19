Public Class materia_prima_form
    Private Sub materia_prima_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeSet4.MP' table. You can move, or remove it, as needed.
        Me.MPTableAdapter.Fill(Me.DelisCakeSet4.MP)
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.MP' table. You can move, or remove it, as needed.
        Me.MPTableAdapter.Fill(Me.Delis_CakeDataSet.MP)

    End Sub

    Private Sub AgregarMP_Click(sender As Object, e As EventArgs)
        Me.MPTableAdapter.Agregar(Id_IngredienteTextBox.Text, NombreTextBox.Text, CategoriaTextBox.Text, Fecha_CompraDateTimePicker.Text, Fecha_VencimientoDateTimePicker.Text, Unidad_MedidaTextBox.Text, CantidadTextBox.Text, Costo_UnitarioTextBox.Text, IVA_UnitarioTextBox.Text)
        Me.MPTableAdapter.Fill(Me.Delis_CakeDataSet.MP)
    End Sub
End Class