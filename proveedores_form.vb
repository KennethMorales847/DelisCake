Public Class proveedores_form
    Private Sub proveedores_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Delis_CakeDataSet.PR' table. You can move, or remove it, as needed.
        Me.PRTableAdapter.Fill(Me.Delis_CakeDataSet.PR)


    End Sub

    Private Sub PRBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Delis_CakeDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class