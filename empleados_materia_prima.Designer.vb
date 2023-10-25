<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleados_materia_prima
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
        Dim Id_IngredienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim Fecha_CompraLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Costo_UnitarioLabel As System.Windows.Forms.Label
        Dim Costo_Sin_IVALabel As System.Windows.Forms.Label
        Dim IVA_UnitarioLabel As System.Windows.Forms.Label
        Dim Costo_TotalLabel As System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DelisCakeDatabaseDataSet = New DelisCake.DelisCakeDatabaseDataSet()
        Me.MateriaPrimaTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Materia_Prima_TableTableAdapter = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Materia_Prima_TableTableAdapter()
        Me.IdIngredienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoSinIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVAUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_IngredienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Fecha_CompraLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Costo_UnitarioLabel = New System.Windows.Forms.Label()
        Costo_Sin_IVALabel = New System.Windows.Forms.Label()
        IVA_UnitarioLabel = New System.Windows.Forms.Label()
        Costo_TotalLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_IngredienteLabel
        '
        Id_IngredienteLabel.AutoSize = True
        Id_IngredienteLabel.Location = New System.Drawing.Point(988, 15)
        Id_IngredienteLabel.Name = "Id_IngredienteLabel"
        Id_IngredienteLabel.Size = New System.Drawing.Size(75, 13)
        Id_IngredienteLabel.TabIndex = 54
        Id_IngredienteLabel.Text = "Id Ingrediente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(988, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 55
        NombreLabel.Text = "Nombre:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(988, 67)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 56
        CategoriaLabel.Text = "Categoria:"
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Location = New System.Drawing.Point(988, 94)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(79, 13)
        Fecha_CompraLabel.TabIndex = 57
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(988, 119)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 58
        CantidadLabel.Text = "Cantidad:"
        '
        'Costo_UnitarioLabel
        '
        Costo_UnitarioLabel.AutoSize = True
        Costo_UnitarioLabel.Location = New System.Drawing.Point(988, 145)
        Costo_UnitarioLabel.Name = "Costo_UnitarioLabel"
        Costo_UnitarioLabel.Size = New System.Drawing.Size(76, 13)
        Costo_UnitarioLabel.TabIndex = 59
        Costo_UnitarioLabel.Text = "Costo Unitario:"
        '
        'Costo_Sin_IVALabel
        '
        Costo_Sin_IVALabel.AutoSize = True
        Costo_Sin_IVALabel.Location = New System.Drawing.Point(988, 171)
        Costo_Sin_IVALabel.Name = "Costo_Sin_IVALabel"
        Costo_Sin_IVALabel.Size = New System.Drawing.Size(75, 13)
        Costo_Sin_IVALabel.TabIndex = 60
        Costo_Sin_IVALabel.Text = "Costo Sin IVA:"
        '
        'IVA_UnitarioLabel
        '
        IVA_UnitarioLabel.AutoSize = True
        IVA_UnitarioLabel.Location = New System.Drawing.Point(988, 197)
        IVA_UnitarioLabel.Name = "IVA_UnitarioLabel"
        IVA_UnitarioLabel.Size = New System.Drawing.Size(66, 13)
        IVA_UnitarioLabel.TabIndex = 61
        IVA_UnitarioLabel.Text = "IVA Unitario:"
        '
        'Costo_TotalLabel
        '
        Costo_TotalLabel.AutoSize = True
        Costo_TotalLabel.Location = New System.Drawing.Point(988, 223)
        Costo_TotalLabel.Name = "Costo_TotalLabel"
        Costo_TotalLabel.Size = New System.Drawing.Size(64, 13)
        Costo_TotalLabel.TabIndex = 62
        Costo_TotalLabel.Text = "Costo Total:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1082, 90)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(220, 20)
        Me.DateTimePicker1.TabIndex = 53
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(1082, 220)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(220, 20)
        Me.TextBox9.TabIndex = 52
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1082, 142)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(220, 20)
        Me.TextBox6.TabIndex = 51
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1082, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 20)
        Me.TextBox3.TabIndex = 50
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(1082, 194)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(220, 20)
        Me.TextBox8.TabIndex = 49
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(1082, 116)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(220, 20)
        Me.TextBox5.TabIndex = 48
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1082, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 20)
        Me.TextBox2.TabIndex = 47
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(1082, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(220, 20)
        Me.TextBox7.TabIndex = 46
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1082, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 20)
        Me.TextBox1.TabIndex = 45
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1164, 300)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 44
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1083, 300)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1203, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1122, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1041, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngredienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.FechaCompraDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CostoUnitarioDataGridViewTextBoxColumn, Me.CostoSinIVADataGridViewTextBoxColumn, Me.IVAUnitarioDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MateriaPrimaTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 296)
        Me.DataGridView1.TabIndex = 39
        '
        'DelisCakeDatabaseDataSet
        '
        Me.DelisCakeDatabaseDataSet.DataSetName = "DelisCakeDatabaseDataSet"
        Me.DelisCakeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MateriaPrimaTableBindingSource
        '
        Me.MateriaPrimaTableBindingSource.DataMember = "Materia_Prima_Table"
        Me.MateriaPrimaTableBindingSource.DataSource = Me.DelisCakeDatabaseDataSet
        '
        'Materia_Prima_TableTableAdapter
        '
        Me.Materia_Prima_TableTableAdapter.ClearBeforeFill = True
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
        'empleados_materia_prima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 342)
        Me.Controls.Add(Id_IngredienteLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Fecha_CompraLabel)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Costo_UnitarioLabel)
        Me.Controls.Add(Costo_Sin_IVALabel)
        Me.Controls.Add(IVA_UnitarioLabel)
        Me.Controls.Add(Costo_TotalLabel)
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
        Me.Name = "empleados_materia_prima"
        Me.Text = "empleados_materia_prima"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
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
End Class
