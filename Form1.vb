Public Class MateriaPrima
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MateriaPrimaDataSet2.MateriaPrima' table. You can move, or remove it, as needed.
        Me.MateriaPrimaTableAdapter2.Fill(Me.MateriaPrimaDataSet2.MateriaPrima)
        'TODO: This line of code loads data into the 'MateriaPrimaDataSet1.MateriaPrima' table. You can move, or remove it, as needed.
        Me.MateriaPrimaTableAdapter1.Fill(Me.MateriaPrimaDataSet1.MateriaPrima)
        'TODO: This line of code loads data into the 'MateriaPrimaDataSet.MateriaPrima' table. You can move, or remove it, as needed.
        Me.MateriaPrimaTableAdapter.Fill(Me.MateriaPrimaDataSet.MateriaPrima)

    End Sub
End Class
