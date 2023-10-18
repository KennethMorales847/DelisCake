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
        Dim Id_IngredienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim Fecha_CompraLabel As System.Windows.Forms.Label
        Dim Fecha_VencimientoLabel As System.Windows.Forms.Label
        Dim Unidad_de_MedidaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Costo_UnitarioLabel As System.Windows.Forms.Label
        Dim IVA_UnitarioLabel As System.Windows.Forms.Label
        Dim Costo_TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MateriaPrima))
        Me.Materia_Prima = New DelisCake.Materia_Prima()
        Me.MateriaPrimaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriaPrimaTableAdapter = New DelisCake.Materia_PrimaTableAdapters.MateriaPrimaTableAdapter()
        Me.TableAdapterManager = New DelisCake.Materia_PrimaTableAdapters.TableAdapterManager()
        Me.MateriaPrimaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Id_IngredienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_CompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_VencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Unidad_de_MedidaTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Costo_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.IVA_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Costo_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MateriaPrimaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MateriaPrimaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_IngredienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Fecha_CompraLabel = New System.Windows.Forms.Label()
        Fecha_VencimientoLabel = New System.Windows.Forms.Label()
        Unidad_de_MedidaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Costo_UnitarioLabel = New System.Windows.Forms.Label()
        IVA_UnitarioLabel = New System.Windows.Forms.Label()
        Costo_TotalLabel = New System.Windows.Forms.Label()
        CType(Me.Materia_Prima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MateriaPrimaBindingNavigator.SuspendLayout()
        CType(Me.MateriaPrimaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Materia_Prima
        '
        Me.Materia_Prima.DataSetName = "Materia_Prima"
        Me.Materia_Prima.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MateriaPrimaBindingSource
        '
        Me.MateriaPrimaBindingSource.DataMember = "MateriaPrima"
        Me.MateriaPrimaBindingSource.DataSource = Me.Materia_Prima
        '
        'MateriaPrimaTableAdapter
        '
        Me.MateriaPrimaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MateriaPrimaTableAdapter = Me.MateriaPrimaTableAdapter
        Me.TableAdapterManager.UpdateOrder = DelisCake.Materia_PrimaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MateriaPrimaBindingNavigator
        '
        Me.MateriaPrimaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MateriaPrimaBindingNavigator.BindingSource = Me.MateriaPrimaBindingSource
        Me.MateriaPrimaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MateriaPrimaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MateriaPrimaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MateriaPrimaBindingNavigatorSaveItem})
        Me.MateriaPrimaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MateriaPrimaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MateriaPrimaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MateriaPrimaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MateriaPrimaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MateriaPrimaBindingNavigator.Name = "MateriaPrimaBindingNavigator"
        Me.MateriaPrimaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MateriaPrimaBindingNavigator.Size = New System.Drawing.Size(991, 25)
        Me.MateriaPrimaBindingNavigator.TabIndex = 0
        Me.MateriaPrimaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Id_IngredienteLabel
        '
        Id_IngredienteLabel.AutoSize = True
        Id_IngredienteLabel.Location = New System.Drawing.Point(56, 57)
        Id_IngredienteLabel.Name = "Id_IngredienteLabel"
        Id_IngredienteLabel.Size = New System.Drawing.Size(75, 13)
        Id_IngredienteLabel.TabIndex = 1
        Id_IngredienteLabel.Text = "Id Ingrediente:"
        '
        'Id_IngredienteTextBox
        '
        Me.Id_IngredienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "Id_Ingrediente", True))
        Me.Id_IngredienteTextBox.Location = New System.Drawing.Point(163, 54)
        Me.Id_IngredienteTextBox.Name = "Id_IngredienteTextBox"
        Me.Id_IngredienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_IngredienteTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(56, 83)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(163, 80)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(56, 109)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 5
        CategoriaLabel.Text = "Categoria:"
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(163, 106)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CategoriaTextBox.TabIndex = 6
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Location = New System.Drawing.Point(56, 136)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(79, 13)
        Fecha_CompraLabel.TabIndex = 7
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'Fecha_CompraDateTimePicker
        '
        Me.Fecha_CompraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MateriaPrimaBindingSource, "Fecha_Compra", True))
        Me.Fecha_CompraDateTimePicker.Location = New System.Drawing.Point(163, 132)
        Me.Fecha_CompraDateTimePicker.Name = "Fecha_CompraDateTimePicker"
        Me.Fecha_CompraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_CompraDateTimePicker.TabIndex = 8
        '
        'Fecha_VencimientoLabel
        '
        Fecha_VencimientoLabel.AutoSize = True
        Fecha_VencimientoLabel.Location = New System.Drawing.Point(56, 162)
        Fecha_VencimientoLabel.Name = "Fecha_VencimientoLabel"
        Fecha_VencimientoLabel.Size = New System.Drawing.Size(101, 13)
        Fecha_VencimientoLabel.TabIndex = 9
        Fecha_VencimientoLabel.Text = "Fecha Vencimiento:"
        '
        'Fecha_VencimientoDateTimePicker
        '
        Me.Fecha_VencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MateriaPrimaBindingSource, "Fecha_Vencimiento", True))
        Me.Fecha_VencimientoDateTimePicker.Location = New System.Drawing.Point(163, 158)
        Me.Fecha_VencimientoDateTimePicker.Name = "Fecha_VencimientoDateTimePicker"
        Me.Fecha_VencimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_VencimientoDateTimePicker.TabIndex = 10
        '
        'Unidad_de_MedidaLabel
        '
        Unidad_de_MedidaLabel.AutoSize = True
        Unidad_de_MedidaLabel.Location = New System.Drawing.Point(56, 187)
        Unidad_de_MedidaLabel.Name = "Unidad_de_MedidaLabel"
        Unidad_de_MedidaLabel.Size = New System.Drawing.Size(97, 13)
        Unidad_de_MedidaLabel.TabIndex = 11
        Unidad_de_MedidaLabel.Text = "Unidad de Medida:"
        '
        'Unidad_de_MedidaTextBox
        '
        Me.Unidad_de_MedidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "Unidad_de_Medida", True))
        Me.Unidad_de_MedidaTextBox.Location = New System.Drawing.Point(163, 184)
        Me.Unidad_de_MedidaTextBox.Name = "Unidad_de_MedidaTextBox"
        Me.Unidad_de_MedidaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Unidad_de_MedidaTextBox.TabIndex = 12
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(56, 213)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 13
        CantidadLabel.Text = "Cantidad:"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(163, 210)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 14
        '
        'Costo_UnitarioLabel
        '
        Costo_UnitarioLabel.AutoSize = True
        Costo_UnitarioLabel.Location = New System.Drawing.Point(56, 239)
        Costo_UnitarioLabel.Name = "Costo_UnitarioLabel"
        Costo_UnitarioLabel.Size = New System.Drawing.Size(76, 13)
        Costo_UnitarioLabel.TabIndex = 15
        Costo_UnitarioLabel.Text = "Costo Unitario:"
        '
        'Costo_UnitarioTextBox
        '
        Me.Costo_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "Costo_Unitario", True))
        Me.Costo_UnitarioTextBox.Location = New System.Drawing.Point(163, 236)
        Me.Costo_UnitarioTextBox.Name = "Costo_UnitarioTextBox"
        Me.Costo_UnitarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Costo_UnitarioTextBox.TabIndex = 16
        '
        'IVA_UnitarioLabel
        '
        IVA_UnitarioLabel.AutoSize = True
        IVA_UnitarioLabel.Location = New System.Drawing.Point(56, 265)
        IVA_UnitarioLabel.Name = "IVA_UnitarioLabel"
        IVA_UnitarioLabel.Size = New System.Drawing.Size(66, 13)
        IVA_UnitarioLabel.TabIndex = 17
        IVA_UnitarioLabel.Text = "IVA Unitario:"
        '
        'IVA_UnitarioTextBox
        '
        Me.IVA_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "IVA_Unitario", True))
        Me.IVA_UnitarioTextBox.Location = New System.Drawing.Point(163, 262)
        Me.IVA_UnitarioTextBox.Name = "IVA_UnitarioTextBox"
        Me.IVA_UnitarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IVA_UnitarioTextBox.TabIndex = 18
        '
        'Costo_TotalLabel
        '
        Costo_TotalLabel.AutoSize = True
        Costo_TotalLabel.Location = New System.Drawing.Point(56, 291)
        Costo_TotalLabel.Name = "Costo_TotalLabel"
        Costo_TotalLabel.Size = New System.Drawing.Size(64, 13)
        Costo_TotalLabel.TabIndex = 19
        Costo_TotalLabel.Text = "Costo Total:"
        '
        'Costo_TotalTextBox
        '
        Me.Costo_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaBindingSource, "Costo_Total", True))
        Me.Costo_TotalTextBox.Location = New System.Drawing.Point(163, 288)
        Me.Costo_TotalTextBox.Name = "Costo_TotalTextBox"
        Me.Costo_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Costo_TotalTextBox.TabIndex = 20
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'MateriaPrimaBindingNavigatorSaveItem
        '
        Me.MateriaPrimaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MateriaPrimaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MateriaPrimaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MateriaPrimaBindingNavigatorSaveItem.Name = "MateriaPrimaBindingNavigatorSaveItem"
        Me.MateriaPrimaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MateriaPrimaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MateriaPrimaDataGridView
        '
        Me.MateriaPrimaDataGridView.AutoGenerateColumns = False
        Me.MateriaPrimaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MateriaPrimaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.MateriaPrimaDataGridView.DataSource = Me.MateriaPrimaBindingSource
        Me.MateriaPrimaDataGridView.Location = New System.Drawing.Point(417, 54)
        Me.MateriaPrimaDataGridView.Name = "MateriaPrimaDataGridView"
        Me.MateriaPrimaDataGridView.Size = New System.Drawing.Size(526, 220)
        Me.MateriaPrimaDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Ingrediente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Ingrediente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha_Compra"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha_Compra"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fecha_Vencimiento"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha_Vencimiento"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Unidad_de_Medida"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unidad_de_Medida"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Costo_Unitario"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Costo_Unitario"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IVA_Unitario"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IVA_Unitario"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Costo_Total"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Costo_Total"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'MateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 349)
        Me.Controls.Add(Me.MateriaPrimaDataGridView)
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
        Me.Controls.Add(Unidad_de_MedidaLabel)
        Me.Controls.Add(Me.Unidad_de_MedidaTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Costo_UnitarioLabel)
        Me.Controls.Add(Me.Costo_UnitarioTextBox)
        Me.Controls.Add(IVA_UnitarioLabel)
        Me.Controls.Add(Me.IVA_UnitarioTextBox)
        Me.Controls.Add(Costo_TotalLabel)
        Me.Controls.Add(Me.Costo_TotalTextBox)
        Me.Controls.Add(Me.MateriaPrimaBindingNavigator)
        Me.Name = "MateriaPrima"
        Me.Text = "MateriaPrima"
        CType(Me.Materia_Prima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MateriaPrimaBindingNavigator.ResumeLayout(False)
        Me.MateriaPrimaBindingNavigator.PerformLayout()
        CType(Me.MateriaPrimaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Materia_Prima As Materia_Prima
    Friend WithEvents MateriaPrimaBindingSource As BindingSource
    Friend WithEvents MateriaPrimaTableAdapter As Materia_PrimaTableAdapters.MateriaPrimaTableAdapter
    Friend WithEvents TableAdapterManager As Materia_PrimaTableAdapters.TableAdapterManager
    Friend WithEvents MateriaPrimaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MateriaPrimaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_IngredienteTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents Fecha_CompraDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_VencimientoDateTimePicker As DateTimePicker
    Friend WithEvents Unidad_de_MedidaTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Costo_UnitarioTextBox As TextBox
    Friend WithEvents IVA_UnitarioTextBox As TextBox
    Friend WithEvents Costo_TotalTextBox As TextBox
    Friend WithEvents MateriaPrimaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
