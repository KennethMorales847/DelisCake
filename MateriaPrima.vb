Public Class MateriaPrima
    Private Sub MateriaPrimaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MateriaPrimaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Materia_Prima)

    End Sub

    Private Sub MateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Materia_Prima.MateriaPrima' table. You can move, or remove it, as needed.
        Me.MateriaPrimaTableAdapter.Fill(Me.Materia_Prima.MateriaPrima)

    End Sub
End Class