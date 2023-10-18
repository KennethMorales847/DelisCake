<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MateriaPrima
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
        Me.MateriaPrimaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriaPrimaDataSet = New DelisCake.MateriaPrimaDataSet()
        Me.MateriaPrimaTableAdapter = New DelisCake.MateriaPrimaDataSetTableAdapters.MateriaPrimaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MateriaPrimaDataSet1 = New DelisCake.MateriaPrimaDataSet1()
        Me.MateriaPrimaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriaPrimaTableAdapter1 = New DelisCake.MateriaPrimaDataSet1TableAdapters.MateriaPrimaTableAdapter()
        Me.MateriaPrimaDataSet2 = New DelisCake.MateriaPrimaDataSet2()
        Me.MateriaPrimaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriaPrimaTableAdapter2 = New DelisCake.MateriaPrimaDataSet2TableAdapters.MateriaPrimaTableAdapter()
        Me.IdIngredienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroLoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadInventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVAUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.MateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MateriaPrimaBindingSource
        '
        Me.MateriaPrimaBindingSource.DataMember = "MateriaPrima"
        Me.MateriaPrimaBindingSource.DataSource = Me.MateriaPrimaDataSet
        '
        'MateriaPrimaDataSet
        '
        Me.MateriaPrimaDataSet.DataSetName = "MateriaPrimaDataSet"
        Me.MateriaPrimaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MateriaPrimaTableAdapter
        '
        Me.MateriaPrimaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 209)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 209)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngredienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.FechaCompraDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.NumeroLoteDataGridViewTextBoxColumn, Me.UnidadMedidaDataGridViewTextBoxColumn, Me.CantidadInventarioDataGridViewTextBoxColumn, Me.CostoUnitarioDataGridViewTextBoxColumn, Me.IVAUnitarioDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MateriaPrimaBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1246, 175)
        Me.DataGridView1.TabIndex = 3
        '
        'MateriaPrimaDataSet1
        '
        Me.MateriaPrimaDataSet1.DataSetName = "MateriaPrimaDataSet1"
        Me.MateriaPrimaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MateriaPrimaBindingSource1
        '
        Me.MateriaPrimaBindingSource1.DataMember = "MateriaPrima"
        Me.MateriaPrimaBindingSource1.DataSource = Me.MateriaPrimaDataSet1
        '
        'MateriaPrimaTableAdapter1
        '
        Me.MateriaPrimaTableAdapter1.ClearBeforeFill = True
        '
        'MateriaPrimaDataSet2
        '
        Me.MateriaPrimaDataSet2.DataSetName = "MateriaPrimaDataSet2"
        Me.MateriaPrimaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MateriaPrimaBindingSource2
        '
        Me.MateriaPrimaBindingSource2.DataMember = "MateriaPrima"
        Me.MateriaPrimaBindingSource2.DataSource = Me.MateriaPrimaDataSet2
        '
        'MateriaPrimaTableAdapter2
        '
        Me.MateriaPrimaTableAdapter2.ClearBeforeFill = True
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
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Vencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Vencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        '
        'NumeroLoteDataGridViewTextBoxColumn
        '
        Me.NumeroLoteDataGridViewTextBoxColumn.DataPropertyName = "Numero_Lote"
        Me.NumeroLoteDataGridViewTextBoxColumn.HeaderText = "Numero_Lote"
        Me.NumeroLoteDataGridViewTextBoxColumn.Name = "NumeroLoteDataGridViewTextBoxColumn"
        '
        'UnidadMedidaDataGridViewTextBoxColumn
        '
        Me.UnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "Unidad_Medida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad_Medida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.Name = "UnidadMedidaDataGridViewTextBoxColumn"
        '
        'CantidadInventarioDataGridViewTextBoxColumn
        '
        Me.CantidadInventarioDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Inventario"
        Me.CantidadInventarioDataGridViewTextBoxColumn.HeaderText = "Cantidad_Inventario"
        Me.CantidadInventarioDataGridViewTextBoxColumn.Name = "CantidadInventarioDataGridViewTextBoxColumn"
        '
        'CostoUnitarioDataGridViewTextBoxColumn
        '
        Me.CostoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Costo_Unitario"
        Me.CostoUnitarioDataGridViewTextBoxColumn.HeaderText = "Costo_Unitario"
        Me.CostoUnitarioDataGridViewTextBoxColumn.Name = "CostoUnitarioDataGridViewTextBoxColumn"
        '
        'IVAUnitarioDataGridViewTextBoxColumn
        '
        Me.IVAUnitarioDataGridViewTextBoxColumn.DataPropertyName = "IVA_Unitario"
        Me.IVAUnitarioDataGridViewTextBoxColumn.HeaderText = "IVA_Unitario"
        Me.IVAUnitarioDataGridViewTextBoxColumn.Name = "IVAUnitarioDataGridViewTextBoxColumn"
        '
        'CostoTotalDataGridViewTextBoxColumn
        '
        Me.CostoTotalDataGridViewTextBoxColumn.DataPropertyName = "Costo_Total"
        Me.CostoTotalDataGridViewTextBoxColumn.HeaderText = "Costo_Total"
        Me.CostoTotalDataGridViewTextBoxColumn.Name = "CostoTotalDataGridViewTextBoxColumn"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(244, 209)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 34)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(361, 209)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 34)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1270, 275)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MateriaPrima"
        Me.Text = "MateriaPrima"
        CType(Me.MateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MateriaPrimaDataSet As MateriaPrimaDataSet
    Friend WithEvents MateriaPrimaBindingSource As BindingSource
    Friend WithEvents MateriaPrimaTableAdapter As MateriaPrimaDataSetTableAdapters.MateriaPrimaTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MateriaPrimaDataSet1 As MateriaPrimaDataSet1
    Friend WithEvents MateriaPrimaBindingSource1 As BindingSource
    Friend WithEvents MateriaPrimaTableAdapter1 As MateriaPrimaDataSet1TableAdapters.MateriaPrimaTableAdapter
    Friend WithEvents MateriaPrimaDataSet2 As MateriaPrimaDataSet2
    Friend WithEvents MateriaPrimaBindingSource2 As BindingSource
    Friend WithEvents MateriaPrimaTableAdapter2 As MateriaPrimaDataSet2TableAdapters.MateriaPrimaTableAdapter
    Friend WithEvents IdIngredienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroLoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadInventarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVAUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
