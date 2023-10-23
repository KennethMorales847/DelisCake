Public Class trabajadores_form
    Private Sub trabajadores_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.Planilla' table. You can move, or remove it, as needed.
        Me.PlanillaTableAdapter.Fill(Me.Delis_CakeDataSet.Planilla)
        'TODO: This line of code loads data into the 'DelisCakeSet3.Planilla' table. You can move, or remove it, as needed.
        Me.PlanillaTableAdapter.Fill(Me.DelisCakeSet3.Planilla)

    End Sub

    Private Sub PlanillaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanillaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanillaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub
End Class