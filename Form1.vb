﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MateriaPrimaDataSet.MateriaPrima' table. You can move, or remove it, as needed.
        Me.MateriaPrimaTableAdapter.Fill(Me.MateriaPrimaDataSet.MateriaPrima)

    End Sub
End Class
