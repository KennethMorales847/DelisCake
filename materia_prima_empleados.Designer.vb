<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class materia_prima_empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(materia_prima_empleados))
        Me.Delis_CakeDataSet = New DelisCake.Delis_CakeDataSet()
        Me.MPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MPTableAdapter = New DelisCake.Delis_CakeDataSetTableAdapters.MPTableAdapter()
        Me.TableAdapterManager = New DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager()
        Me.MPBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MPDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_IngredienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_CompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Costo_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Costo_Sin_IVATextBox = New System.Windows.Forms.TextBox()
        Me.IVA_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Costo_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MPBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Id_IngredienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Fecha_CompraLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Costo_UnitarioLabel = New System.Windows.Forms.Label()
        Costo_Sin_IVALabel = New System.Windows.Forms.Label()
        IVA_UnitarioLabel = New System.Windows.Forms.Label()
        Costo_TotalLabel = New System.Windows.Forms.Label()
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPBindingNavigator.SuspendLayout()
        CType(Me.MPDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Delis_CakeDataSet
        '
        Me.Delis_CakeDataSet.DataSetName = "Delis_CakeDataSet"
        Me.Delis_CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MPBindingSource
        '
        Me.MPBindingSource.DataMember = "MP"
        Me.MPBindingSource.DataSource = Me.Delis_CakeDataSet
        '
        'MPTableAdapter
        '
        Me.MPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MPTableAdapter = Me.MPTableAdapter
        Me.TableAdapterManager.PlanillaTableAdapter = Nothing
        Me.TableAdapterManager.Productos_TerminadosTableAdapter = Nothing
        Me.TableAdapterManager.PRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MPBindingNavigator
        '
        Me.MPBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MPBindingNavigator.BindingSource = Me.MPBindingSource
        Me.MPBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MPBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MPBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MPBindingNavigatorSaveItem})
        Me.MPBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MPBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MPBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MPBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MPBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MPBindingNavigator.Name = "MPBindingNavigator"
        Me.MPBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MPBindingNavigator.Size = New System.Drawing.Size(970, 25)
        Me.MPBindingNavigator.TabIndex = 0
        Me.MPBindingNavigator.Text = "BindingNavigator1"
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
        'MPDataGridView
        '
        Me.MPDataGridView.AutoGenerateColumns = False
        Me.MPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MPDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MPDataGridView.DataSource = Me.MPBindingSource
        Me.MPDataGridView.Location = New System.Drawing.Point(12, 37)
        Me.MPDataGridView.Name = "MPDataGridView"
        Me.MPDataGridView.Size = New System.Drawing.Size(615, 220)
        Me.MPDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Costo_Unitario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Costo_Unitario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Costo_Sin_IVA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Costo_Sin_IVA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IVA_Unitario"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IVA_Unitario"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Costo_Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Costo_Total"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Id_IngredienteLabel
        '
        Id_IngredienteLabel.AutoSize = True
        Id_IngredienteLabel.Location = New System.Drawing.Point(662, 37)
        Id_IngredienteLabel.Name = "Id_IngredienteLabel"
        Id_IngredienteLabel.Size = New System.Drawing.Size(75, 13)
        Id_IngredienteLabel.TabIndex = 2
        Id_IngredienteLabel.Text = "Id Ingrediente:"
        '
        'Id_IngredienteTextBox
        '
        Me.Id_IngredienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Id_Ingrediente", True))
        Me.Id_IngredienteTextBox.Location = New System.Drawing.Point(747, 34)
        Me.Id_IngredienteTextBox.Name = "Id_IngredienteTextBox"
        Me.Id_IngredienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_IngredienteTextBox.TabIndex = 3
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(662, 63)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(747, 60)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(662, 89)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 6
        CategoriaLabel.Text = "Categoria:"
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(747, 86)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CategoriaTextBox.TabIndex = 7
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Location = New System.Drawing.Point(662, 116)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(79, 13)
        Fecha_CompraLabel.TabIndex = 8
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'Fecha_CompraDateTimePicker
        '
        Me.Fecha_CompraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MPBindingSource, "Fecha_Compra", True))
        Me.Fecha_CompraDateTimePicker.Location = New System.Drawing.Point(747, 112)
        Me.Fecha_CompraDateTimePicker.Name = "Fecha_CompraDateTimePicker"
        Me.Fecha_CompraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_CompraDateTimePicker.TabIndex = 9
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(662, 141)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 10
        CantidadLabel.Text = "Cantidad:"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(747, 138)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 11
        '
        'Costo_UnitarioLabel
        '
        Costo_UnitarioLabel.AutoSize = True
        Costo_UnitarioLabel.Location = New System.Drawing.Point(662, 167)
        Costo_UnitarioLabel.Name = "Costo_UnitarioLabel"
        Costo_UnitarioLabel.Size = New System.Drawing.Size(76, 13)
        Costo_UnitarioLabel.TabIndex = 12
        Costo_UnitarioLabel.Text = "Costo Unitario:"
        '
        'Costo_UnitarioTextBox
        '
        Me.Costo_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Costo_Unitario", True))
        Me.Costo_UnitarioTextBox.Location = New System.Drawing.Point(747, 164)
        Me.Costo_UnitarioTextBox.Name = "Costo_UnitarioTextBox"
        Me.Costo_UnitarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Costo_UnitarioTextBox.TabIndex = 13
        '
        'Costo_Sin_IVALabel
        '
        Costo_Sin_IVALabel.AutoSize = True
        Costo_Sin_IVALabel.Location = New System.Drawing.Point(662, 193)
        Costo_Sin_IVALabel.Name = "Costo_Sin_IVALabel"
        Costo_Sin_IVALabel.Size = New System.Drawing.Size(75, 13)
        Costo_Sin_IVALabel.TabIndex = 14
        Costo_Sin_IVALabel.Text = "Costo Sin IVA:"
        '
        'Costo_Sin_IVATextBox
        '
        Me.Costo_Sin_IVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Costo_Sin_IVA", True))
        Me.Costo_Sin_IVATextBox.Location = New System.Drawing.Point(747, 190)
        Me.Costo_Sin_IVATextBox.Name = "Costo_Sin_IVATextBox"
        Me.Costo_Sin_IVATextBox.Size = New System.Drawing.Size(200, 20)
        Me.Costo_Sin_IVATextBox.TabIndex = 15
        '
        'IVA_UnitarioLabel
        '
        IVA_UnitarioLabel.AutoSize = True
        IVA_UnitarioLabel.Location = New System.Drawing.Point(662, 219)
        IVA_UnitarioLabel.Name = "IVA_UnitarioLabel"
        IVA_UnitarioLabel.Size = New System.Drawing.Size(66, 13)
        IVA_UnitarioLabel.TabIndex = 16
        IVA_UnitarioLabel.Text = "IVA Unitario:"
        '
        'IVA_UnitarioTextBox
        '
        Me.IVA_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "IVA_Unitario", True))
        Me.IVA_UnitarioTextBox.Location = New System.Drawing.Point(747, 216)
        Me.IVA_UnitarioTextBox.Name = "IVA_UnitarioTextBox"
        Me.IVA_UnitarioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IVA_UnitarioTextBox.TabIndex = 17
        '
        'Costo_TotalLabel
        '
        Costo_TotalLabel.AutoSize = True
        Costo_TotalLabel.Location = New System.Drawing.Point(662, 245)
        Costo_TotalLabel.Name = "Costo_TotalLabel"
        Costo_TotalLabel.Size = New System.Drawing.Size(64, 13)
        Costo_TotalLabel.TabIndex = 18
        Costo_TotalLabel.Text = "Costo Total:"
        '
        'Costo_TotalTextBox
        '
        Me.Costo_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MPBindingSource, "Costo_Total", True))
        Me.Costo_TotalTextBox.Location = New System.Drawing.Point(747, 242)
        Me.Costo_TotalTextBox.Name = "Costo_TotalTextBox"
        Me.Costo_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Costo_TotalTextBox.TabIndex = 19
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
        'MPBindingNavigatorSaveItem
        '
        Me.MPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MPBindingNavigatorSaveItem.Image = CType(resources.GetObject("MPBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MPBindingNavigatorSaveItem.Name = "MPBindingNavigatorSaveItem"
        Me.MPBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MPBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'materia_prima_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 315)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_IngredienteLabel)
        Me.Controls.Add(Me.Id_IngredienteTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(Fecha_CompraLabel)
        Me.Controls.Add(Me.Fecha_CompraDateTimePicker)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Costo_UnitarioLabel)
        Me.Controls.Add(Me.Costo_UnitarioTextBox)
        Me.Controls.Add(Costo_Sin_IVALabel)
        Me.Controls.Add(Me.Costo_Sin_IVATextBox)
        Me.Controls.Add(IVA_UnitarioLabel)
        Me.Controls.Add(Me.IVA_UnitarioTextBox)
        Me.Controls.Add(Costo_TotalLabel)
        Me.Controls.Add(Me.Costo_TotalTextBox)
        Me.Controls.Add(Me.MPDataGridView)
        Me.Controls.Add(Me.MPBindingNavigator)
        Me.Name = "materia_prima_empleados"
        Me.Text = "materia_prima_empleados"
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPBindingNavigator.ResumeLayout(False)
        Me.MPBindingNavigator.PerformLayout()
        CType(Me.MPDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Delis_CakeDataSet As Delis_CakeDataSet
    Friend WithEvents MPBindingSource As BindingSource
    Friend WithEvents MPTableAdapter As Delis_CakeDataSetTableAdapters.MPTableAdapter
    Friend WithEvents TableAdapterManager As Delis_CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MPBindingNavigator As BindingNavigator
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
    Friend WithEvents MPBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MPDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Id_IngredienteTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents Fecha_CompraDateTimePicker As DateTimePicker
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Costo_UnitarioTextBox As TextBox
    Friend WithEvents Costo_Sin_IVATextBox As TextBox
    Friend WithEvents IVA_UnitarioTextBox As TextBox
    Friend WithEvents Costo_TotalTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
