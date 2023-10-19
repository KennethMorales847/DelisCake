Public Class trabajadores_form
    Private Sub trabajadores_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeSet3.Planilla' table. You can move, or remove it, as needed.
        Me.PlanillaTableAdapter.Fill(Me.DelisCakeSet3.Planilla)

    End Sub
End Class