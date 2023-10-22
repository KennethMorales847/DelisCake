Public Class productos_terminados_form
    Private Sub Productos_TerminadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub productos_terminados_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.Productos_Terminados' table. You can move, or remove it, as needed.
        Me.Productos_TerminadosTableAdapter.Fill(Me.Delis_CakeDataSet.Productos_Terminados)
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.Productos_Terminados' table. You can move, or remove it, as needed.
        Me.Productos_TerminadosTableAdapter.Fill(Me.Delis_CakeDataSet.Productos_Terminados)
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.Productos_Terminados' table. You can move, or remove it, as needed.
        Me.Productos_TerminadosTableAdapter.Fill(Me.Delis_CakeDataSet.Productos_Terminados)



    End Sub

    Private Sub Productos_TerminadosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Productos_TerminadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub

    Private Sub Productos_TerminadosBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Productos_TerminadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub

    Private Sub Productos_TerminadosBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs) Handles Productos_TerminadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Productos_TerminadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub
End Class