<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos_terminados_empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos_terminados_empleados))
        Me.Delis_CakeDataSet = New DelisCake.Delis_CakeDataSet()
        Me.Productos_TerminadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Productos_TerminadosTableAdapter = New DelisCake.Delis_CakeDataSetTableAdapters.Productos_TerminadosTableAdapter()
        Me.TableAdapterManager = New DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager()
        Me.Productos_TerminadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Id_Producto_TerminadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_VentaTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Productos_TerminadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Productos_TerminadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Id_Producto_TerminadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Precio_VentaLabel = New System.Windows.Forms.Label()
        Cantidad_TotalLabel = New System.Windows.Forms.Label()
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productos_TerminadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productos_TerminadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Productos_TerminadosBindingNavigator.SuspendLayout()
        CType(Me.Productos_TerminadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Delis_CakeDataSet
        '
        Me.Delis_CakeDataSet.DataSetName = "Delis_CakeDataSet"
        Me.Delis_CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Productos_TerminadosBindingSource
        '
        Me.Productos_TerminadosBindingSource.DataMember = "Productos_Terminados"
        Me.Productos_TerminadosBindingSource.DataSource = Me.Delis_CakeDataSet
        '
        'Productos_TerminadosTableAdapter
        '
        Me.Productos_TerminadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MPTableAdapter = Nothing
        Me.TableAdapterManager.PlanillaTableAdapter = Nothing
        Me.TableAdapterManager.Productos_TerminadosTableAdapter = Me.Productos_TerminadosTableAdapter
        Me.TableAdapterManager.PRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Productos_TerminadosBindingNavigator
        '
        Me.Productos_TerminadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Productos_TerminadosBindingNavigator.BindingSource = Me.Productos_TerminadosBindingSource
        Me.Productos_TerminadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Productos_TerminadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Productos_TerminadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Productos_TerminadosBindingNavigatorSaveItem})
        Me.Productos_TerminadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Productos_TerminadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Productos_TerminadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Productos_TerminadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Productos_TerminadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Productos_TerminadosBindingNavigator.Name = "Productos_TerminadosBindingNavigator"
        Me.Productos_TerminadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Productos_TerminadosBindingNavigator.Size = New System.Drawing.Size(779, 25)
        Me.Productos_TerminadosBindingNavigator.TabIndex = 0
        Me.Productos_TerminadosBindingNavigator.Text = "BindingNavigator1"
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
        'Id_Producto_TerminadoLabel
        '
        Id_Producto_TerminadoLabel.AutoSize = True
        Id_Producto_TerminadoLabel.Location = New System.Drawing.Point(508, 39)
        Id_Producto_TerminadoLabel.Name = "Id_Producto_TerminadoLabel"
        Id_Producto_TerminadoLabel.Size = New System.Drawing.Size(118, 13)
        Id_Producto_TerminadoLabel.TabIndex = 1
        Id_Producto_TerminadoLabel.Text = "Id Producto Terminado:"
        '
        'Id_Producto_TerminadoTextBox
        '
        Me.Id_Producto_TerminadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Productos_TerminadosBindingSource, "Id_Producto_Terminado", True))
        Me.Id_Producto_TerminadoTextBox.Location = New System.Drawing.Point(632, 36)
        Me.Id_Producto_TerminadoTextBox.Name = "Id_Producto_TerminadoTextBox"
        Me.Id_Producto_TerminadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_Producto_TerminadoTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(508, 65)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Productos_TerminadosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(632, 62)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'Precio_VentaLabel
        '
        Precio_VentaLabel.AutoSize = True
        Precio_VentaLabel.Location = New System.Drawing.Point(508, 91)
        Precio_VentaLabel.Name = "Precio_VentaLabel"
        Precio_VentaLabel.Size = New System.Drawing.Size(71, 13)
        Precio_VentaLabel.TabIndex = 5
        Precio_VentaLabel.Text = "Precio Venta:"
        '
        'Precio_VentaTextBox
        '
        Me.Precio_VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Productos_TerminadosBindingSource, "Precio_Venta", True))
        Me.Precio_VentaTextBox.Location = New System.Drawing.Point(632, 88)
        Me.Precio_VentaTextBox.Name = "Precio_VentaTextBox"
        Me.Precio_VentaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Precio_VentaTextBox.TabIndex = 6
        '
        'Cantidad_TotalLabel
        '
        Cantidad_TotalLabel.AutoSize = True
        Cantidad_TotalLabel.Location = New System.Drawing.Point(508, 117)
        Cantidad_TotalLabel.Name = "Cantidad_TotalLabel"
        Cantidad_TotalLabel.Size = New System.Drawing.Size(79, 13)
        Cantidad_TotalLabel.TabIndex = 7
        Cantidad_TotalLabel.Text = "Cantidad Total:"
        '
        'Cantidad_TotalTextBox
        '
        Me.Cantidad_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Productos_TerminadosBindingSource, "Cantidad_Total", True))
        Me.Cantidad_TotalTextBox.Location = New System.Drawing.Point(632, 114)
        Me.Cantidad_TotalTextBox.Name = "Cantidad_TotalTextBox"
        Me.Cantidad_TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cantidad_TotalTextBox.TabIndex = 8
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
        'Productos_TerminadosBindingNavigatorSaveItem
        '
        Me.Productos_TerminadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Productos_TerminadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("Productos_TerminadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Productos_TerminadosBindingNavigatorSaveItem.Name = "Productos_TerminadosBindingNavigatorSaveItem"
        Me.Productos_TerminadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Productos_TerminadosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Productos_TerminadosDataGridView
        '
        Me.Productos_TerminadosDataGridView.AutoGenerateColumns = False
        Me.Productos_TerminadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Productos_TerminadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Productos_TerminadosDataGridView.DataSource = Me.Productos_TerminadosBindingSource
        Me.Productos_TerminadosDataGridView.Location = New System.Drawing.Point(12, 39)
        Me.Productos_TerminadosDataGridView.Name = "Productos_TerminadosDataGridView"
        Me.Productos_TerminadosDataGridView.Size = New System.Drawing.Size(466, 220)
        Me.Productos_TerminadosDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Producto_Terminado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Producto_Terminado"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Precio_Venta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio_Venta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad_Total"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad_Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'productos_terminados_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 312)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Productos_TerminadosDataGridView)
        Me.Controls.Add(Id_Producto_TerminadoLabel)
        Me.Controls.Add(Me.Id_Producto_TerminadoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Precio_VentaLabel)
        Me.Controls.Add(Me.Precio_VentaTextBox)
        Me.Controls.Add(Cantidad_TotalLabel)
        Me.Controls.Add(Me.Cantidad_TotalTextBox)
        Me.Controls.Add(Me.Productos_TerminadosBindingNavigator)
        Me.Name = "productos_terminados_empleados"
        Me.Text = "productos_terminados_empleados"
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productos_TerminadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productos_TerminadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Productos_TerminadosBindingNavigator.ResumeLayout(False)
        Me.Productos_TerminadosBindingNavigator.PerformLayout()
        CType(Me.Productos_TerminadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Delis_CakeDataSet As Delis_CakeDataSet
    Friend WithEvents Productos_TerminadosBindingSource As BindingSource
    Friend WithEvents Productos_TerminadosTableAdapter As Delis_CakeDataSetTableAdapters.Productos_TerminadosTableAdapter
    Friend WithEvents TableAdapterManager As Delis_CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Productos_TerminadosBindingNavigator As BindingNavigator
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
    Friend WithEvents Productos_TerminadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_Producto_TerminadoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Precio_VentaTextBox As TextBox
    Friend WithEvents Cantidad_TotalTextBox As TextBox
    Friend WithEvents Productos_TerminadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
