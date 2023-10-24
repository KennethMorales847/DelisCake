<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materia_Prima_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdIngredienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoSinIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVAUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MateriaPrimaTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DelisCakeDatabaseDataSet = New DelisCake.DelisCakeDatabaseDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Materia_Prima_TableTableAdapter = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Materia_Prima_TableTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngredienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.FechaCompraDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CostoUnitarioDataGridViewTextBoxColumn, Me.CostoSinIVADataGridViewTextBoxColumn, Me.IVAUnitarioDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MateriaPrimaTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 160)
        Me.DataGridView1.TabIndex = 0
        '
        'IdIngredienteDataGridViewTextBoxColumn
        '
        Me.IdIngredienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Ingrediente"
        Me.IdIngredienteDataGridViewTextBoxColumn.HeaderText = "Id_Ingrediente"
        Me.IdIngredienteDataGridViewTextBoxColumn.Name = "IdIngredienteDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        '
        'FechaCompraDataGridViewTextBoxColumn
        '
        Me.FechaCompraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Compra"
        Me.FechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha_Compra"
        Me.FechaCompraDataGridViewTextBoxColumn.Name = "FechaCompraDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'CostoUnitarioDataGridViewTextBoxColumn
        '
        Me.CostoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Costo_Unitario"
        Me.CostoUnitarioDataGridViewTextBoxColumn.HeaderText = "Costo_Unitario"
        Me.CostoUnitarioDataGridViewTextBoxColumn.Name = "CostoUnitarioDataGridViewTextBoxColumn"
        '
        'CostoSinIVADataGridViewTextBoxColumn
        '
        Me.CostoSinIVADataGridViewTextBoxColumn.DataPropertyName = "Costo_Sin_IVA"
        Me.CostoSinIVADataGridViewTextBoxColumn.HeaderText = "Costo_Sin_IVA"
        Me.CostoSinIVADataGridViewTextBoxColumn.Name = "CostoSinIVADataGridViewTextBoxColumn"
        Me.CostoSinIVADataGridViewTextBoxColumn.ReadOnly = True
        '
        'IVAUnitarioDataGridViewTextBoxColumn
        '
        Me.IVAUnitarioDataGridViewTextBoxColumn.DataPropertyName = "IVA_Unitario"
        Me.IVAUnitarioDataGridViewTextBoxColumn.HeaderText = "IVA_Unitario"
        Me.IVAUnitarioDataGridViewTextBoxColumn.Name = "IVAUnitarioDataGridViewTextBoxColumn"
        Me.IVAUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoTotalDataGridViewTextBoxColumn
        '
        Me.CostoTotalDataGridViewTextBoxColumn.DataPropertyName = "Costo_Total"
        Me.CostoTotalDataGridViewTextBoxColumn.HeaderText = "Costo_Total"
        Me.CostoTotalDataGridViewTextBoxColumn.Name = "CostoTotalDataGridViewTextBoxColumn"
        Me.CostoTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MateriaPrimaTableBindingSource
        '
        Me.MateriaPrimaTableBindingSource.DataMember = "Materia_Prima_Table"
        Me.MateriaPrimaTableBindingSource.DataSource = Me.DelisCakeDatabaseDataSet
        '
        'DelisCakeDatabaseDataSet
        '
        Me.DelisCakeDatabaseDataSet.DataSetName = "DelisCakeDatabaseDataSet"
        Me.DelisCakeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Id_Ingrediente", True))
        Me.TextBox1.Location = New System.Drawing.Point(1050, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 20)
        Me.TextBox1.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(1050, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 20)
        Me.TextBox2.TabIndex = 21
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Categoria", True))
        Me.TextBox3.Location = New System.Drawing.Point(1050, 65)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 20)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Cantidad", True))
        Me.TextBox5.Location = New System.Drawing.Point(1050, 117)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(220, 20)
        Me.TextBox5.TabIndex = 21
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Costo_Unitario", True))
        Me.TextBox6.Location = New System.Drawing.Point(1050, 143)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(220, 20)
        Me.TextBox6.TabIndex = 21
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Costo_Sin_IVA", True))
        Me.TextBox7.Location = New System.Drawing.Point(1050, 169)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(220, 20)
        Me.TextBox7.TabIndex = 21
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "IVA_Unitario", True))
        Me.TextBox8.Location = New System.Drawing.Point(1050, 195)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(220, 20)
        Me.TextBox8.TabIndex = 21
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Costo_Total", True))
        Me.TextBox9.Location = New System.Drawing.Point(1050, 221)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(220, 20)
        Me.TextBox9.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Fecha_Compra", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1050, 91)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(220, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Materia_Prima_TableTableAdapter
        '
        Me.Materia_Prima_TableTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(336, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Materia_Prima_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 295)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Materia_Prima_Form"
        Me.Text = "Materia_Prima_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DelisCakeDatabaseDataSet As DelisCakeDatabaseDataSet
    Friend WithEvents MateriaPrimaTableBindingSource As BindingSource
    Friend WithEvents Materia_Prima_TableTableAdapter As DelisCakeDatabaseDataSetTableAdapters.Materia_Prima_TableTableAdapter
    Friend WithEvents IdIngredienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoSinIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVAUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
