<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleados_productos_terminados
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
        Dim Id_Producto_TerminadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Precio_VentaLabel As System.Windows.Forms.Label
        Dim Cantidad_TotalLabel As System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DelisCakeDatabaseDataSet = New DelisCake.DelisCakeDatabaseDataSet()
        Me.ProductosTerminadosTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Productos_Terminados_TableTableAdapter = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Productos_Terminados_TableTableAdapter()
        Me.IdProductoTerminadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_Producto_TerminadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Precio_VentaLabel = New System.Windows.Forms.Label()
        Cantidad_TotalLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosTerminadosTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(656, 167)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(575, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(695, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(614, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(663, 87)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(130, 20)
        Me.TextBox4.TabIndex = 31
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(663, 61)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(130, 20)
        Me.TextBox3.TabIndex = 32
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(663, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 33
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(663, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 34
        '
        'Id_Producto_TerminadoLabel
        '
        Id_Producto_TerminadoLabel.AutoSize = True
        Id_Producto_TerminadoLabel.Location = New System.Drawing.Point(530, 12)
        Id_Producto_TerminadoLabel.Name = "Id_Producto_TerminadoLabel"
        Id_Producto_TerminadoLabel.Size = New System.Drawing.Size(118, 13)
        Id_Producto_TerminadoLabel.TabIndex = 27
        Id_Producto_TerminadoLabel.Text = "Id Producto Terminado:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(530, 38)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 28
        NombreLabel.Text = "Nombre:"
        '
        'Precio_VentaLabel
        '
        Precio_VentaLabel.AutoSize = True
        Precio_VentaLabel.Location = New System.Drawing.Point(530, 64)
        Precio_VentaLabel.Name = "Precio_VentaLabel"
        Precio_VentaLabel.Size = New System.Drawing.Size(71, 13)
        Precio_VentaLabel.TabIndex = 29
        Precio_VentaLabel.Text = "Precio Venta:"
        '
        'Cantidad_TotalLabel
        '
        Cantidad_TotalLabel.AutoSize = True
        Cantidad_TotalLabel.Location = New System.Drawing.Point(530, 90)
        Cantidad_TotalLabel.Name = "Cantidad_TotalLabel"
        Cantidad_TotalLabel.Size = New System.Drawing.Size(79, 13)
        Cantidad_TotalLabel.TabIndex = 30
        Cantidad_TotalLabel.Text = "Cantidad Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoTerminadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CantidadTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosTerminadosTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(480, 245)
        Me.DataGridView1.TabIndex = 26
        '
        'DelisCakeDatabaseDataSet
        '
        Me.DelisCakeDatabaseDataSet.DataSetName = "DelisCakeDatabaseDataSet"
        Me.DelisCakeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosTerminadosTableBindingSource
        '
        Me.ProductosTerminadosTableBindingSource.DataMember = "Productos_Terminados_Table"
        Me.ProductosTerminadosTableBindingSource.DataSource = Me.DelisCakeDatabaseDataSet
        '
        'Productos_Terminados_TableTableAdapter
        '
        Me.Productos_Terminados_TableTableAdapter.ClearBeforeFill = True
        '
        'IdProductoTerminadoDataGridViewTextBoxColumn
        '
        Me.IdProductoTerminadoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto_Terminado"
        Me.IdProductoTerminadoDataGridViewTextBoxColumn.HeaderText = "Id_Producto_Terminado"
        Me.IdProductoTerminadoDataGridViewTextBoxColumn.Name = "IdProductoTerminadoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio_Venta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        '
        'CantidadTotalDataGridViewTextBoxColumn
        '
        Me.CantidadTotalDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Total"
        Me.CantidadTotalDataGridViewTextBoxColumn.HeaderText = "Cantidad_Total"
        Me.CantidadTotalDataGridViewTextBoxColumn.Name = "CantidadTotalDataGridViewTextBoxColumn"
        '
        'empleados_productos_terminados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 295)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Id_Producto_TerminadoLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Precio_VentaLabel)
        Me.Controls.Add(Cantidad_TotalLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "empleados_productos_terminados"
        Me.Text = "empleados_productos_terminados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosTerminadosTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeDatabaseDataSet As DelisCakeDatabaseDataSet
    Friend WithEvents ProductosTerminadosTableBindingSource As BindingSource
    Friend WithEvents Productos_Terminados_TableTableAdapter As DelisCakeDatabaseDataSetTableAdapters.Productos_Terminados_TableTableAdapter
    Friend WithEvents IdProductoTerminadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
