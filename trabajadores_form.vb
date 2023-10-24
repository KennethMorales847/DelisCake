Public Class trabajadores_form
    Private Sub trabajadores_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.Productos_Terminados' table. You can move, or remove it, as needed.
        Me.Productos_TerminadosTableAdapter.Fill(Me.Delis_CakeDataSet.Productos_Terminados)
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.Planilla' table. You can move, or remove it, as needed.
        Me.PlanillaTableAdapter.Fill(Me.Delis_CakeDataSet.Planilla)

    End Sub

    Private Sub PlanillaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanillaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanillaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub PlanillaDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PlanillaDataGridView.CellEndEdit
        For Each row As DataGridViewRow In PlanillaDataGridView.Rows

            row.Cells("sum").Value = Convert.ToDouble(row.Cells("").Value)
        Next
    End Sub
End Class