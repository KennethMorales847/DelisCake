<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class productos_terminados_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_Producto_TerminadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Precio_VentaLabel As System.Windows.Forms.Label
        Dim Cantidad_TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos_terminados_form))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProductoTerminadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosTerminadosTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DelisCakeDatabaseDataSet = New DelisCake.DelisCakeDatabaseDataSet()
        Me.Productos_Terminados_TableTableAdapter = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Productos_Terminados_TableTableAdapter()
        Me.TableAdapterManager = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_Producto_TerminadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Precio_VentaLabel = New System.Windows.Forms.Label()
        Cantidad_TotalLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosTerminadosTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_Producto_TerminadoLabel
        '
        Id_Producto_TerminadoLabel.AutoSize = True
        Id_Producto_TerminadoLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Id_Producto_TerminadoLabel.Location = New System.Drawing.Point(514, 144)
        Id_Producto_TerminadoLabel.Name = "Id_Producto_TerminadoLabel"
        Id_Producto_TerminadoLabel.Size = New System.Drawing.Size(181, 17)
        Id_Producto_TerminadoLabel.TabIndex = 1
        Id_Producto_TerminadoLabel.Text = "Id Producto Terminado:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(514, 170)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(73, 17)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'Precio_VentaLabel
        '
        Precio_VentaLabel.AutoSize = True
        Precio_VentaLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Precio_VentaLabel.Location = New System.Drawing.Point(514, 196)
        Precio_VentaLabel.Name = "Precio_VentaLabel"
        Precio_VentaLabel.Size = New System.Drawing.Size(106, 17)
        Precio_VentaLabel.TabIndex = 5
        Precio_VentaLabel.Text = "Precio Venta:"
        '
        'Cantidad_TotalLabel
        '
        Cantidad_TotalLabel.AutoSize = True
        Cantidad_TotalLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Cantidad_TotalLabel.Location = New System.Drawing.Point(514, 222)
        Cantidad_TotalLabel.Name = "Cantidad_TotalLabel"
        Cantidad_TotalLabel.Size = New System.Drawing.Size(121, 17)
        Cantidad_TotalLabel.TabIndex = 7
        Cantidad_TotalLabel.Text = "Cantidad Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoTerminadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CantidadTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosTerminadosTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(480, 245)
        Me.DataGridView1.TabIndex = 0
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
        'ProductosTerminadosTableBindingSource
        '
        Me.ProductosTerminadosTableBindingSource.DataMember = "Productos_Terminados_Table"
        Me.ProductosTerminadosTableBindingSource.DataSource = Me.DelisCakeDatabaseDataSet
        '
        'DelisCakeDatabaseDataSet
        '
        Me.DelisCakeDatabaseDataSet.DataSetName = "DelisCakeDatabaseDataSet"
        Me.DelisCakeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Productos_Terminados_TableTableAdapter
        '
        Me.Productos_Terminados_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Materia_Prima_TableTableAdapter = Nothing
        Me.TableAdapterManager.Planilla_Empleados_TableTableAdapter = Nothing
        Me.TableAdapterManager.Productos_Terminados_TableTableAdapter = Me.Productos_Terminados_TableTableAdapter
        Me.TableAdapterManager.Proveedores_TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosTableBindingSource, "Id_Producto_Terminado", True))
        Me.TextBox1.Font = New System.Drawing.Font("Louis George Cafe", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(708, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 22)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosTableBindingSource, "Nombre", True))
        Me.TextBox2.Font = New System.Drawing.Font("Louis George Cafe", 9.75!)
        Me.TextBox2.Location = New System.Drawing.Point(708, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 22)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosTableBindingSource, "Precio_Venta", True))
        Me.TextBox3.Font = New System.Drawing.Font("Louis George Cafe", 9.75!)
        Me.TextBox3.Location = New System.Drawing.Point(708, 195)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(130, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosTableBindingSource, "Cantidad_Total", True))
        Me.TextBox4.Font = New System.Drawing.Font("Louis George Cafe", 9.75!)
        Me.TextBox4.Location = New System.Drawing.Point(708, 221)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(130, 22)
        Me.TextBox4.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(692, 306)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 47)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(583, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 47)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(735, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 47)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(626, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 47)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(517, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 47)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 366)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(78, 80)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 83
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(158, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Amsterdam", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 86)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Productos Terminados"
        '
        'productos_terminados_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(908, 458)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
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
        Me.Name = "productos_terminados_form"
        Me.Text = "productos_terminados_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosTerminadosTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeDatabaseDataSet As DelisCakeDatabaseDataSet
    Friend WithEvents ProductosTerminadosTableBindingSource As BindingSource
    Friend WithEvents Productos_Terminados_TableTableAdapter As DelisCakeDatabaseDataSetTableAdapters.Productos_Terminados_TableTableAdapter
    Friend WithEvents IdProductoTerminadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
