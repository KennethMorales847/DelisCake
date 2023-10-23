Public Class materia_prima_form
    Private Sub MPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MPBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub

    Private Sub materia_prima_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.MP' table. You can move, or remove it, as needed.
        Me.MPTableAdapter.Fill(Me.Delis_CakeDataSet.MP)

    End Sub
End Class