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
        Dim Fecha_ElaboracionLabel As System.Windows.Forms.Label
        Dim Fecha_VencimientoLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DelisCakeSet1 = New DelisCake.DelisCakeSet1()
        Me.ProductosTerminadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Productos_TerminadosTableAdapter = New DelisCake.DelisCakeSet1TableAdapters.Productos_TerminadosTableAdapter()
        Me.IdProductoTerminadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaElaboracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New DelisCake.DelisCakeSet1TableAdapters.TableAdapterManager()
        Me.Id_Producto_TerminadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_VentaTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_ElaboracionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_VencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Id_Producto_TerminadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Precio_VentaLabel = New System.Windows.Forms.Label()
        Cantidad_TotalLabel = New System.Windows.Forms.Label()
        Fecha_ElaboracionLabel = New System.Windows.Forms.Label()
        Fecha_VencimientoLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosTerminadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoTerminadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CantidadTotalDataGridViewTextBoxColumn, Me.FechaElaboracionDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosTerminadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 157)
        Me.DataGridView1.TabIndex = 0
        '
        'DelisCakeSet1
        '
        Me.DelisCakeSet1.DataSetName = "DelisCakeSet1"
        Me.DelisCakeSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosTerminadosBindingSource
        '
        Me.ProductosTerminadosBindingSource.DataMember = "Productos_Terminados"
        Me.ProductosTerminadosBindingSource.DataSource = Me.DelisCakeSet1
        '
        'Productos_TerminadosTableAdapter
        '
        Me.Productos_TerminadosTableAdapter.ClearBeforeFill = True
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
        'FechaElaboracionDataGridViewTextBoxColumn
        '
        Me.FechaElaboracionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Elaboracion"
        Me.FechaElaboracionDataGridViewTextBoxColumn.HeaderText = "Fecha_Elaboracion"
        Me.FechaElaboracionDataGridViewTextBoxColumn.Name = "FechaElaboracionDataGridViewTextBoxColumn"
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Vencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Vencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Productos_TerminadosTableAdapter = Me.Productos_TerminadosTableAdapter
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_Producto_TerminadoLabel
        '
        Id_Producto_TerminadoLabel.AutoSize = True
        Id_Producto_TerminadoLabel.Location = New System.Drawing.Point(694, 13)
        Id_Producto_TerminadoLabel.Name = "Id_Producto_TerminadoLabel"
        Id_Producto_TerminadoLabel.Size = New System.Drawing.Size(118, 13)
        Id_Producto_TerminadoLabel.TabIndex = 1
        Id_Producto_TerminadoLabel.Text = "Id Producto Terminado:"
        '
        'Id_Producto_TerminadoTextBox
        '
        Me.Id_Producto_TerminadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosBindingSource, "Id_Producto_Terminado", True))
        Me.Id_Producto_TerminadoTextBox.Location = New System.Drawing.Point(818, 10)
        Me.Id_Producto_TerminadoTextBox.Name = "Id_Producto_TerminadoTextBox"
        Me.Id_Producto_TerminadoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_Producto_TerminadoTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(694, 39)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(818, 36)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'Precio_VentaLabel
        '
        Precio_VentaLabel.AutoSize = True
        Precio_VentaLabel.Location = New System.Drawing.Point(694, 65)
        Precio_VentaLabel.Name = "Precio_VentaLabel"
        Precio_VentaLabel.Size = New System.Drawing.Size(71, 13)
        Precio_VentaLabel.TabIndex = 5
        Precio_VentaLabel.Text = "Precio Venta:"
        '
        'Precio_VentaTextBox
        '
        Me.Precio_VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosBindingSource, "Precio_Venta", True))
        Me.Precio_VentaTextBox.Location = New System.Drawing.Point(818, 62)
        Me.Precio_VentaTextBox.Name = "Precio_VentaTextBox"
        Me.Precio_VentaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Precio_VentaTextBox.TabIndex = 6
        '
        'Cantidad_TotalLabel
        '
        Cantidad_TotalLabel.AutoSize = True
        Cantidad_TotalLabel.Location = New System.Drawing.Point(694, 91)
        Cantidad_TotalLabel.Name = "Cantidad_TotalLabel"
        Cantidad_TotalLabel.Size = New System.Drawing.Size(79, 13)
        Cantidad_TotalLabel.TabIndex = 7
        Cantidad_TotalLabel.Text = "Cantidad Total:"
        '
        'Cantidad_TotalTextBox
        '
        Me.Cantidad_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosTerminadosBindingSource, "Cantidad_Total", True))
        Me.Cantidad_TotalTextBox.Location = New System.Drawing.Point(818, 88)
        Me.Cantidad_TotalTextBox.Name = "Cantidad_TotalTextBox"
        Me.Cantidad_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cantidad_TotalTextBox.TabIndex = 8
        '
        'Fecha_ElaboracionLabel
        '
        Fecha_ElaboracionLabel.AutoSize = True
        Fecha_ElaboracionLabel.Location = New System.Drawing.Point(694, 118)
        Fecha_ElaboracionLabel.Name = "Fecha_ElaboracionLabel"
        Fecha_ElaboracionLabel.Size = New System.Drawing.Size(99, 13)
        Fecha_ElaboracionLabel.TabIndex = 9
        Fecha_ElaboracionLabel.Text = "Fecha Elaboracion:"
        '
        'Fecha_ElaboracionDateTimePicker
        '
        Me.Fecha_ElaboracionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosTerminadosBindingSource, "Fecha_Elaboracion", True))
        Me.Fecha_ElaboracionDateTimePicker.Location = New System.Drawing.Point(818, 114)
        Me.Fecha_ElaboracionDateTimePicker.Name = "Fecha_ElaboracionDateTimePicker"
        Me.Fecha_ElaboracionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_ElaboracionDateTimePicker.TabIndex = 10
        '
        'Fecha_VencimientoLabel
        '
        Fecha_VencimientoLabel.AutoSize = True
        Fecha_VencimientoLabel.Location = New System.Drawing.Point(694, 144)
        Fecha_VencimientoLabel.Name = "Fecha_VencimientoLabel"
        Fecha_VencimientoLabel.Size = New System.Drawing.Size(101, 13)
        Fecha_VencimientoLabel.TabIndex = 11
        Fecha_VencimientoLabel.Text = "Fecha Vencimiento:"
        '
        'Fecha_VencimientoDateTimePicker
        '
        Me.Fecha_VencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosTerminadosBindingSource, "Fecha_Vencimiento", True))
        Me.Fecha_VencimientoDateTimePicker.Location = New System.Drawing.Point(818, 140)
        Me.Fecha_VencimientoDateTimePicker.Name = "Fecha_VencimientoDateTimePicker"
        Me.Fecha_VencimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_VencimientoDateTimePicker.TabIndex = 12
        '
        'productos_terminados_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 361)
        Me.Controls.Add(Id_Producto_TerminadoLabel)
        Me.Controls.Add(Me.Id_Producto_TerminadoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Precio_VentaLabel)
        Me.Controls.Add(Me.Precio_VentaTextBox)
        Me.Controls.Add(Cantidad_TotalLabel)
        Me.Controls.Add(Me.Cantidad_TotalTextBox)
        Me.Controls.Add(Fecha_ElaboracionLabel)
        Me.Controls.Add(Me.Fecha_ElaboracionDateTimePicker)
        Me.Controls.Add(Fecha_VencimientoLabel)
        Me.Controls.Add(Me.Fecha_VencimientoDateTimePicker)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "productos_terminados_form"
        Me.Text = "productos_terminados_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosTerminadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeSet1 As DelisCakeSet1
    Friend WithEvents ProductosTerminadosBindingSource As BindingSource
    Friend WithEvents Productos_TerminadosTableAdapter As DelisCakeSet1TableAdapters.Productos_TerminadosTableAdapter
    Friend WithEvents IdProductoTerminadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaElaboracionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DelisCakeSet1TableAdapters.TableAdapterManager
    Friend WithEvents Id_Producto_TerminadoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Precio_VentaTextBox As TextBox
    Friend WithEvents Cantidad_TotalTextBox As TextBox
    Friend WithEvents Fecha_ElaboracionDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_VencimientoDateTimePicker As DateTimePicker
End Class
