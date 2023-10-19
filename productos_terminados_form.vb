Public Class productos_terminados_form
    Private Sub Productos_TerminadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub productos_terminados_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeSet1.Productos_Terminados' table. You can move, or remove it, as needed.
        Me.Productos_TerminadosTableAdapter.Fill(Me.DelisCakeSet1.Productos_Terminados)

    End Sub
End Class