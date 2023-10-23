<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trabajadores_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trabajadores_form))
        Dim Codigo_EmpleadoLabel As System.Windows.Forms.Label
        Dim Nombre_CompletoLabel As System.Windows.Forms.Label
        Dim PuestoLabel As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim Num_Horas_ExtrasLabel As System.Windows.Forms.Label
        Dim Horas_ExtrasLabel As System.Windows.Forms.Label
        Dim Bonificacion_IncentivoLabel As System.Windows.Forms.Label
        Dim Total_DevengadoLabel As System.Windows.Forms.Label
        Dim AnticipoLabel As System.Windows.Forms.Label
        Dim IGSSLabel As System.Windows.Forms.Label
        Dim Total_DescuentosLabel As System.Windows.Forms.Label
        Dim Importe_a_RecibirLabel As System.Windows.Forms.Label
        Me.Delis_CakeDataSet = New DelisCake.Delis_CakeDataSet()
        Me.PlanillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaTableAdapter = New DelisCake.Delis_CakeDataSetTableAdapters.PlanillaTableAdapter()
        Me.TableAdapterManager = New DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager()
        Me.PlanillaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PlanillaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Codigo_EmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_CompletoTextBox = New System.Windows.Forms.TextBox()
        Me.PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.SalarioTextBox = New System.Windows.Forms.TextBox()
        Me.Num_Horas_ExtrasTextBox = New System.Windows.Forms.TextBox()
        Me.Horas_ExtrasTextBox = New System.Windows.Forms.TextBox()
        Me.Bonificacion_IncentivoTextBox = New System.Windows.Forms.TextBox()
        Me.Total_DevengadoTextBox = New System.Windows.Forms.TextBox()
        Me.AnticipoTextBox = New System.Windows.Forms.TextBox()
        Me.IGSSTextBox = New System.Windows.Forms.TextBox()
        Me.Total_DescuentosTextBox = New System.Windows.Forms.TextBox()
        Me.Importe_a_RecibirTextBox = New System.Windows.Forms.TextBox()
        Me.PlanillaDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Codigo_EmpleadoLabel = New System.Windows.Forms.Label()
        Nombre_CompletoLabel = New System.Windows.Forms.Label()
        PuestoLabel = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        Num_Horas_ExtrasLabel = New System.Windows.Forms.Label()
        Horas_ExtrasLabel = New System.Windows.Forms.Label()
        Bonificacion_IncentivoLabel = New System.Windows.Forms.Label()
        Total_DevengadoLabel = New System.Windows.Forms.Label()
        AnticipoLabel = New System.Windows.Forms.Label()
        IGSSLabel = New System.Windows.Forms.Label()
        Total_DescuentosLabel = New System.Windows.Forms.Label()
        Importe_a_RecibirLabel = New System.Windows.Forms.Label()
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanillaBindingNavigator.SuspendLayout()
        CType(Me.PlanillaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Delis_CakeDataSet
        '
        Me.Delis_CakeDataSet.DataSetName = "Delis_CakeDataSet"
        Me.Delis_CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanillaBindingSource
        '
        Me.PlanillaBindingSource.DataMember = "Planilla"
        Me.PlanillaBindingSource.DataSource = Me.Delis_CakeDataSet
        '
        'PlanillaTableAdapter
        '
        Me.PlanillaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MPTableAdapter = Nothing
        Me.TableAdapterManager.PlanillaTableAdapter = Me.PlanillaTableAdapter
        Me.TableAdapterManager.Productos_TerminadosTableAdapter = Nothing
        Me.TableAdapterManager.PRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PlanillaBindingNavigator
        '
        Me.PlanillaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanillaBindingNavigator.BindingSource = Me.PlanillaBindingSource
        Me.PlanillaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlanillaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlanillaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlanillaBindingNavigatorSaveItem})
        Me.PlanillaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlanillaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlanillaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlanillaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlanillaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlanillaBindingNavigator.Name = "PlanillaBindingNavigator"
        Me.PlanillaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlanillaBindingNavigator.Size = New System.Drawing.Size(1051, 25)
        Me.PlanillaBindingNavigator.TabIndex = 0
        Me.PlanillaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PlanillaBindingNavigatorSaveItem
        '
        Me.PlanillaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanillaBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanillaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanillaBindingNavigatorSaveItem.Name = "PlanillaBindingNavigatorSaveItem"
        Me.PlanillaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PlanillaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Codigo_EmpleadoLabel
        '
        Codigo_EmpleadoLabel.AutoSize = True
        Codigo_EmpleadoLabel.Location = New System.Drawing.Point(810, 39)
        Codigo_EmpleadoLabel.Name = "Codigo_EmpleadoLabel"
        Codigo_EmpleadoLabel.Size = New System.Drawing.Size(93, 13)
        Codigo_EmpleadoLabel.TabIndex = 1
        Codigo_EmpleadoLabel.Text = "Codigo Empleado:"
        '
        'Codigo_EmpleadoTextBox
        '
        Me.Codigo_EmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Codigo_Empleado", True))
        Me.Codigo_EmpleadoTextBox.Location = New System.Drawing.Point(931, 36)
        Me.Codigo_EmpleadoTextBox.Name = "Codigo_EmpleadoTextBox"
        Me.Codigo_EmpleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Codigo_EmpleadoTextBox.TabIndex = 2
        '
        'Nombre_CompletoLabel
        '
        Nombre_CompletoLabel.AutoSize = True
        Nombre_CompletoLabel.Location = New System.Drawing.Point(810, 65)
        Nombre_CompletoLabel.Name = "Nombre_CompletoLabel"
        Nombre_CompletoLabel.Size = New System.Drawing.Size(94, 13)
        Nombre_CompletoLabel.TabIndex = 3
        Nombre_CompletoLabel.Text = "Nombre Completo:"
        '
        'Nombre_CompletoTextBox
        '
        Me.Nombre_CompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Nombre_Completo", True))
        Me.Nombre_CompletoTextBox.Location = New System.Drawing.Point(931, 62)
        Me.Nombre_CompletoTextBox.Name = "Nombre_CompletoTextBox"
        Me.Nombre_CompletoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_CompletoTextBox.TabIndex = 4
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Location = New System.Drawing.Point(810, 91)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(43, 13)
        PuestoLabel.TabIndex = 5
        PuestoLabel.Text = "Puesto:"
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(931, 88)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PuestoTextBox.TabIndex = 6
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Location = New System.Drawing.Point(810, 117)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(42, 13)
        SalarioLabel.TabIndex = 7
        SalarioLabel.Text = "Salario:"
        '
        'SalarioTextBox
        '
        Me.SalarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Salario", True))
        Me.SalarioTextBox.Location = New System.Drawing.Point(931, 114)
        Me.SalarioTextBox.Name = "SalarioTextBox"
        Me.SalarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalarioTextBox.TabIndex = 8
        '
        'Num_Horas_ExtrasLabel
        '
        Num_Horas_ExtrasLabel.AutoSize = True
        Num_Horas_ExtrasLabel.Location = New System.Drawing.Point(810, 143)
        Num_Horas_ExtrasLabel.Name = "Num_Horas_ExtrasLabel"
        Num_Horas_ExtrasLabel.Size = New System.Drawing.Size(95, 13)
        Num_Horas_ExtrasLabel.TabIndex = 9
        Num_Horas_ExtrasLabel.Text = "Num Horas Extras:"
        '
        'Num_Horas_ExtrasTextBox
        '
        Me.Num_Horas_ExtrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Num_Horas_Extras", True))
        Me.Num_Horas_ExtrasTextBox.Location = New System.Drawing.Point(931, 140)
        Me.Num_Horas_ExtrasTextBox.Name = "Num_Horas_ExtrasTextBox"
        Me.Num_Horas_ExtrasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Num_Horas_ExtrasTextBox.TabIndex = 10
        '
        'Horas_ExtrasLabel
        '
        Horas_ExtrasLabel.AutoSize = True
        Horas_ExtrasLabel.Location = New System.Drawing.Point(810, 169)
        Horas_ExtrasLabel.Name = "Horas_ExtrasLabel"
        Horas_ExtrasLabel.Size = New System.Drawing.Size(70, 13)
        Horas_ExtrasLabel.TabIndex = 11
        Horas_ExtrasLabel.Text = "Horas Extras:"
        '
        'Horas_ExtrasTextBox
        '
        Me.Horas_ExtrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Horas_Extras", True))
        Me.Horas_ExtrasTextBox.Location = New System.Drawing.Point(931, 166)
        Me.Horas_ExtrasTextBox.Name = "Horas_ExtrasTextBox"
        Me.Horas_ExtrasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Horas_ExtrasTextBox.TabIndex = 12
        '
        'Bonificacion_IncentivoLabel
        '
        Bonificacion_IncentivoLabel.AutoSize = True
        Bonificacion_IncentivoLabel.Location = New System.Drawing.Point(810, 195)
        Bonificacion_IncentivoLabel.Name = "Bonificacion_IncentivoLabel"
        Bonificacion_IncentivoLabel.Size = New System.Drawing.Size(115, 13)
        Bonificacion_IncentivoLabel.TabIndex = 13
        Bonificacion_IncentivoLabel.Text = "Bonificacion Incentivo:"
        '
        'Bonificacion_IncentivoTextBox
        '
        Me.Bonificacion_IncentivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Bonificacion_Incentivo", True))
        Me.Bonificacion_IncentivoTextBox.Location = New System.Drawing.Point(931, 192)
        Me.Bonificacion_IncentivoTextBox.Name = "Bonificacion_IncentivoTextBox"
        Me.Bonificacion_IncentivoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bonificacion_IncentivoTextBox.TabIndex = 14
        '
        'Total_DevengadoLabel
        '
        Total_DevengadoLabel.AutoSize = True
        Total_DevengadoLabel.Location = New System.Drawing.Point(810, 221)
        Total_DevengadoLabel.Name = "Total_DevengadoLabel"
        Total_DevengadoLabel.Size = New System.Drawing.Size(93, 13)
        Total_DevengadoLabel.TabIndex = 15
        Total_DevengadoLabel.Text = "Total Devengado:"
        '
        'Total_DevengadoTextBox
        '
        Me.Total_DevengadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Total_Devengado", True))
        Me.Total_DevengadoTextBox.Location = New System.Drawing.Point(931, 218)
        Me.Total_DevengadoTextBox.Name = "Total_DevengadoTextBox"
        Me.Total_DevengadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_DevengadoTextBox.TabIndex = 16
        '
        'AnticipoLabel
        '
        AnticipoLabel.AutoSize = True
        AnticipoLabel.Location = New System.Drawing.Point(810, 247)
        AnticipoLabel.Name = "AnticipoLabel"
        AnticipoLabel.Size = New System.Drawing.Size(48, 13)
        AnticipoLabel.TabIndex = 17
        AnticipoLabel.Text = "Anticipo:"
        '
        'AnticipoTextBox
        '
        Me.AnticipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Anticipo", True))
        Me.AnticipoTextBox.Location = New System.Drawing.Point(931, 244)
        Me.AnticipoTextBox.Name = "AnticipoTextBox"
        Me.AnticipoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnticipoTextBox.TabIndex = 18
        '
        'IGSSLabel
        '
        IGSSLabel.AutoSize = True
        IGSSLabel.Location = New System.Drawing.Point(810, 273)
        IGSSLabel.Name = "IGSSLabel"
        IGSSLabel.Size = New System.Drawing.Size(35, 13)
        IGSSLabel.TabIndex = 19
        IGSSLabel.Text = "IGSS:"
        '
        'IGSSTextBox
        '
        Me.IGSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "IGSS", True))
        Me.IGSSTextBox.Location = New System.Drawing.Point(931, 270)
        Me.IGSSTextBox.Name = "IGSSTextBox"
        Me.IGSSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IGSSTextBox.TabIndex = 20
        '
        'Total_DescuentosLabel
        '
        Total_DescuentosLabel.AutoSize = True
        Total_DescuentosLabel.Location = New System.Drawing.Point(810, 299)
        Total_DescuentosLabel.Name = "Total_DescuentosLabel"
        Total_DescuentosLabel.Size = New System.Drawing.Size(94, 13)
        Total_DescuentosLabel.TabIndex = 21
        Total_DescuentosLabel.Text = "Total Descuentos:"
        '
        'Total_DescuentosTextBox
        '
        Me.Total_DescuentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Total_Descuentos", True))
        Me.Total_DescuentosTextBox.Location = New System.Drawing.Point(931, 296)
        Me.Total_DescuentosTextBox.Name = "Total_DescuentosTextBox"
        Me.Total_DescuentosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_DescuentosTextBox.TabIndex = 22
        '
        'Importe_a_RecibirLabel
        '
        Importe_a_RecibirLabel.AutoSize = True
        Importe_a_RecibirLabel.Location = New System.Drawing.Point(810, 325)
        Importe_a_RecibirLabel.Name = "Importe_a_RecibirLabel"
        Importe_a_RecibirLabel.Size = New System.Drawing.Size(90, 13)
        Importe_a_RecibirLabel.TabIndex = 23
        Importe_a_RecibirLabel.Text = "Importe a Recibir:"
        '
        'Importe_a_RecibirTextBox
        '
        Me.Importe_a_RecibirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Importe_a_Recibir", True))
        Me.Importe_a_RecibirTextBox.Location = New System.Drawing.Point(931, 322)
        Me.Importe_a_RecibirTextBox.Name = "Importe_a_RecibirTextBox"
        Me.Importe_a_RecibirTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Importe_a_RecibirTextBox.TabIndex = 24
        '
        'PlanillaDataGridView
        '
        Me.PlanillaDataGridView.AutoGenerateColumns = False
        Me.PlanillaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.PlanillaDataGridView.DataSource = Me.PlanillaBindingSource
        Me.PlanillaDataGridView.Location = New System.Drawing.Point(0, 36)
        Me.PlanillaDataGridView.Name = "PlanillaDataGridView"
        Me.PlanillaDataGridView.Size = New System.Drawing.Size(804, 220)
        Me.PlanillaDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo_Empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Completo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre_Completo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Puesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Puesto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Salario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Salario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Num_Horas_Extras"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Num_Horas_Extras"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Horas_Extras"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Horas_Extras"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Bonificacion_Incentivo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Bonificacion_Incentivo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total_Devengado"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total_Devengado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Anticipo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Anticipo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IGSS"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IGSS"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total_Descuentos"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total_Descuentos"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Importe_a_Recibir"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Importe_a_Recibir"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'trabajadores_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 381)
        Me.Controls.Add(Me.PlanillaDataGridView)
        Me.Controls.Add(Codigo_EmpleadoLabel)
        Me.Controls.Add(Me.Codigo_EmpleadoTextBox)
        Me.Controls.Add(Nombre_CompletoLabel)
        Me.Controls.Add(Me.Nombre_CompletoTextBox)
        Me.Controls.Add(PuestoLabel)
        Me.Controls.Add(Me.PuestoTextBox)
        Me.Controls.Add(SalarioLabel)
        Me.Controls.Add(Me.SalarioTextBox)
        Me.Controls.Add(Num_Horas_ExtrasLabel)
        Me.Controls.Add(Me.Num_Horas_ExtrasTextBox)
        Me.Controls.Add(Horas_ExtrasLabel)
        Me.Controls.Add(Me.Horas_ExtrasTextBox)
        Me.Controls.Add(Bonificacion_IncentivoLabel)
        Me.Controls.Add(Me.Bonificacion_IncentivoTextBox)
        Me.Controls.Add(Total_DevengadoLabel)
        Me.Controls.Add(Me.Total_DevengadoTextBox)
        Me.Controls.Add(AnticipoLabel)
        Me.Controls.Add(Me.AnticipoTextBox)
        Me.Controls.Add(IGSSLabel)
        Me.Controls.Add(Me.IGSSTextBox)
        Me.Controls.Add(Total_DescuentosLabel)
        Me.Controls.Add(Me.Total_DescuentosTextBox)
        Me.Controls.Add(Importe_a_RecibirLabel)
        Me.Controls.Add(Me.Importe_a_RecibirTextBox)
        Me.Controls.Add(Me.PlanillaBindingNavigator)
        Me.Name = "trabajadores_form"
        Me.Text = "trabajadores_form"
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanillaBindingNavigator.ResumeLayout(False)
        Me.PlanillaBindingNavigator.PerformLayout()
        CType(Me.PlanillaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Delis_CakeDataSet As Delis_CakeDataSet
    Friend WithEvents PlanillaBindingSource As BindingSource
    Friend WithEvents PlanillaTableAdapter As Delis_CakeDataSetTableAdapters.PlanillaTableAdapter
    Friend WithEvents TableAdapterManager As Delis_CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanillaBindingNavigator As BindingNavigator
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
    Friend WithEvents PlanillaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Codigo_EmpleadoTextBox As TextBox
    Friend WithEvents Nombre_CompletoTextBox As TextBox
    Friend WithEvents PuestoTextBox As TextBox
    Friend WithEvents SalarioTextBox As TextBox
    Friend WithEvents Num_Horas_ExtrasTextBox As TextBox
    Friend WithEvents Horas_ExtrasTextBox As TextBox
    Friend WithEvents Bonificacion_IncentivoTextBox As TextBox
    Friend WithEvents Total_DevengadoTextBox As TextBox
    Friend WithEvents AnticipoTextBox As TextBox
    Friend WithEvents IGSSTextBox As TextBox
    Friend WithEvents Total_DescuentosTextBox As TextBox
    Friend WithEvents Importe_a_RecibirTextBox As TextBox
    Friend WithEvents PlanillaDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
