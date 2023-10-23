Public Class productos_terminados_empleados
    Private Sub Productos_TerminadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Productos_TerminadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Productos_TerminadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub

    Private Sub productos_terminados_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.Productos_Terminados' table. You can move, or remove it, as needed.
        Me.Productos_TerminadosTableAdapter.Fill(Me.Delis_CakeDataSet.Productos_Terminados)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuEmpleados.Show()
        Me.Hide()
    End Sub
End Class