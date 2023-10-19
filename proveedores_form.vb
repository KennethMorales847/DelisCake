Public Class proveedores_form
    Private Sub proveedores_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DelisCakeSet2.PR' table. You can move, or remove it, as needed.
        Me.PRTableAdapter.Fill(Me.DelisCakeSet2.PR)

    End Sub
End Class