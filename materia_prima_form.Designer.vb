<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class materia_prima_form
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
        Dim Id_IngredienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim Fecha_CompraLabel As System.Windows.Forms.Label
        Dim Fecha_VencimientoLabel As System.Windows.Forms.Label
        Dim Unidad_MedidaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Costo_UnitarioLabel As System.Windows.Forms.Label
        Dim IVA_UnitarioLabel As System.Windows.Forms.Label
        Dim Costo_TotalLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DelisCakeSet4 = New DelisCake.DelisCakeSet4()
        Me.MPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MPTableAdapter = New DelisCake.DelisCakeSet4TableAdapters.MPTableAdapter()
        Me.IdIngredienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVAUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New DelisCake.DelisCakeSet4TableAdapters.TableAdapterManager()
        Me.Id_IngredienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_CompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_VencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Unidad_MedidaTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Costo_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.IVA_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Costo_TotalTextBox = New System.Windows.Forms.TextBox()
        Id_IngredienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Fecha_CompraLabel = New System.Windows.Forms.Label()
        Fecha_VencimientoLabel = New System.Windows.Forms.Label()
        Unidad_MedidaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Costo_UnitarioLabel = New System.Windows.Forms.Label()
        IVA_UnitarioLabel = New System.Windows.Forms.Label()
        Costo_TotalLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngredienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.FechaCompraDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.UnidadMedidaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CostoUnitarioDataGridViewTextBoxColumn, Me.IVAUnitarioDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(667, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'DelisCakeSet4
        '
        Me.DelisCakeSet4.DataSetName = "DelisCakeSet4"
        Me.DelisCakeSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MPBindingSource
        '
        Me.MPBindingSource.DataMember = "MP"
        Me.MPBindingSource.DataSource = Me.DelisCakeSet4
        '
        'MPTableAdapter
        '
        Me.MPTableAdapter.ClearBeforeFill = True
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
        'UnidadMedidaDataGridViewTextBoxColumn
        '
        Me.UnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "Unidad_Medida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad_Medida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.Name = "UnidadMedidaDataGridViewTextBoxColumn"
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
        Me.CostoTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MPTableAdapter = Me.MPTableAdapter
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_IngredienteLabel
        '
        Id_IngredienteLabel.AutoSize = True
        Id_IngredienteLabel.Location = New System.Drawing.Point(713, 13)
        Id_IngredienteLabel.Name = "Id_IngredienteLabel"
        Id_IngredienteLabel.Size = New System.Drawing.Size(75, 13)
        Id_IngredienteLabel.TabIndex = 1
        Id_IngredienteLabel.Text = "Id Ingrediente:"
        '
        'Id_IngredienteTextBox
        '
        Me.Id_IngredienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Id_Ingrediente", True))
        Me.Id_IngredienteTextBox.Location = New System.Drawing.Point(820, 10)
        Me.Id_IngredienteTextBox.Name = "Id_IngredienteTextBox"
        Me.Id_IngredienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_IngredienteTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(713, 39)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(820, 36)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(713, 65)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 5
        CategoriaLabel.Text = "Categoria:"
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(820, 62)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CategoriaTextBox.TabIndex = 6
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Location = New System.Drawing.Point(713, 92)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(79, 13)
        Fecha_CompraLabel.TabIndex = 7
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'Fecha_CompraDateTimePicker
        '
        Me.Fecha_CompraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MPBindingSource, "Fecha_Compra", True))
        Me.Fecha_CompraDateTimePicker.Location = New System.Drawing.Point(820, 88)
        Me.Fecha_CompraDateTimePicker.Name = "Fecha_CompraDateTimePicker"
        Me.Fecha_CompraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_CompraDateTimePicker.TabIndex = 8
        '
        'Fecha_VencimientoLabel
        '
        Fecha_VencimientoLabel.AutoSize = True
        Fecha_VencimientoLabel.Location = New System.Drawing.Point(713, 118)
        Fecha_VencimientoLabel.Name = "Fecha_VencimientoLabel"
        Fecha_VencimientoLabel.Size = New System.Drawing.Size(101, 13)
        Fecha_VencimientoLabel.TabIndex = 9
        Fecha_VencimientoLabel.Text = "Fecha Vencimiento:"
        '
        'Fecha_VencimientoDateTimePicker
        '
        Me.Fecha_VencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MPBindingSource, "Fecha_Vencimiento", True))
        Me.Fecha_VencimientoDateTimePicker.Location = New System.Drawing.Point(820, 114)
        Me.Fecha_VencimientoDateTimePicker.Name = "Fecha_VencimientoDateTimePicker"
        Me.Fecha_VencimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_VencimientoDateTimePicker.TabIndex = 10
        '
        'Unidad_MedidaLabel
        '
        Unidad_MedidaLabel.AutoSize = True
        Unidad_MedidaLabel.Location = New System.Drawing.Point(713, 143)
        Unidad_MedidaLabel.Name = "Unidad_MedidaLabel"
        Unidad_MedidaLabel.Size = New System.Drawing.Size(82, 13)
        Unidad_MedidaLabel.TabIndex = 11
        Unidad_MedidaLabel.Text = "Unidad Medida:"
        '
        'Unidad_MedidaTextBox
        '
        Me.Unidad_MedidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Unidad_Medida", True))
        Me.Unidad_MedidaTextBox.Location = New System.Drawing.Point(820, 140)
        Me.Unidad_MedidaTextBox.Name = "Unidad_MedidaTextBox"
        Me.Unidad_MedidaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Unidad_MedidaTextBox.TabIndex = 12
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(713, 169)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 13
        CantidadLabel.Text = "Cantidad:"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(820, 166)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 14
        '
        'Costo_UnitarioLabel
        '
        Costo_UnitarioLabel.AutoSize = True
        Costo_UnitarioLabel.Location = New System.Drawing.Point(713, 195)
        Costo_UnitarioLabel.Name = "Costo_UnitarioLabel"
        Costo_UnitarioLabel.Size = New System.Drawing.Size(76, 13)
        Costo_UnitarioLabel.TabIndex = 15
        Costo_UnitarioLabel.Text = "Costo Unitario:"
        '
        'Costo_UnitarioTextBox
        '
        Me.Costo_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Costo_Unitario", True))
        Me.Costo_UnitarioTextBox.Location = New System.Drawing.Point(820, 192)
        Me.Costo_UnitarioTextBox.Name = "Costo_UnitarioTextBox"
        Me.Costo_UnitarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Costo_UnitarioTextBox.TabIndex = 16
        '
        'IVA_UnitarioLabel
        '
        IVA_UnitarioLabel.AutoSize = True
        IVA_UnitarioLabel.Location = New System.Drawing.Point(713, 221)
        IVA_UnitarioLabel.Name = "IVA_UnitarioLabel"
        IVA_UnitarioLabel.Size = New System.Drawing.Size(66, 13)
        IVA_UnitarioLabel.TabIndex = 17
        IVA_UnitarioLabel.Text = "IVA Unitario:"
        '
        'IVA_UnitarioTextBox
        '
        Me.IVA_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "IVA_Unitario", True))
        Me.IVA_UnitarioTextBox.Location = New System.Drawing.Point(820, 218)
        Me.IVA_UnitarioTextBox.Name = "IVA_UnitarioTextBox"
        Me.IVA_UnitarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IVA_UnitarioTextBox.TabIndex = 18
        '
        'Costo_TotalLabel
        '
        Costo_TotalLabel.AutoSize = True
        Costo_TotalLabel.Location = New System.Drawing.Point(713, 247)
        Costo_TotalLabel.Name = "Costo_TotalLabel"
        Costo_TotalLabel.Size = New System.Drawing.Size(64, 13)
        Costo_TotalLabel.TabIndex = 19
        Costo_TotalLabel.Text = "Costo Total:"
        '
        'Costo_TotalTextBox
        '
        Me.Costo_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Costo_Total", True))
        Me.Costo_TotalTextBox.Location = New System.Drawing.Point(820, 244)
        Me.Costo_TotalTextBox.Name = "Costo_TotalTextBox"
        Me.Costo_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Costo_TotalTextBox.TabIndex = 20
        '
        'materia_prima_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 362)
        Me.Controls.Add(Id_IngredienteLabel)
        Me.Controls.Add(Me.Id_IngredienteTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(Fecha_CompraLabel)
        Me.Controls.Add(Me.Fecha_CompraDateTimePicker)
        Me.Controls.Add(Fecha_VencimientoLabel)
        Me.Controls.Add(Me.Fecha_VencimientoDateTimePicker)
        Me.Controls.Add(Unidad_MedidaLabel)
        Me.Controls.Add(Me.Unidad_MedidaTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Costo_UnitarioLabel)
        Me.Controls.Add(Me.Costo_UnitarioTextBox)
        Me.Controls.Add(IVA_UnitarioLabel)
        Me.Controls.Add(Me.IVA_UnitarioTextBox)
        Me.Controls.Add(Costo_TotalLabel)
        Me.Controls.Add(Me.Costo_TotalTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "materia_prima_form"
        Me.Text = "materia_prima_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeSet4 As DelisCakeSet4
    Friend WithEvents MPBindingSource As BindingSource
    Friend WithEvents MPTableAdapter As DelisCakeSet4TableAdapters.MPTableAdapter
    Friend WithEvents IdIngredienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVAUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DelisCakeSet4TableAdapters.TableAdapterManager
    Friend WithEvents Id_IngredienteTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents Fecha_CompraDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_VencimientoDateTimePicker As DateTimePicker
    Friend WithEvents Unidad_MedidaTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Costo_UnitarioTextBox As TextBox
    Friend WithEvents IVA_UnitarioTextBox As TextBox
    Friend WithEvents Costo_TotalTextBox As TextBox
End Class
