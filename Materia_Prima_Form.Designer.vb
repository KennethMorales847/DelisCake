<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materia_Prima_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Materia_Prima_Form))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdIngredienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoSinIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVAUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MateriaPrimaTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DelisCakeDatabaseDataSet = New DelisCake.DelisCakeDatabaseDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Materia_Prima_TableTableAdapter = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Materia_Prima_TableTableAdapter()
        Me.TableAdapterManager = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
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
        CType(Me.MateriaPrimaTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_IngredienteLabel
        '
        Id_IngredienteLabel.AutoSize = True
        Id_IngredienteLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_IngredienteLabel.Location = New System.Drawing.Point(974, 115)
        Id_IngredienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_IngredienteLabel.Name = "Id_IngredienteLabel"
        Id_IngredienteLabel.Size = New System.Drawing.Size(106, 17)
        Id_IngredienteLabel.TabIndex = 22
        Id_IngredienteLabel.Text = "Id Ingrediente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(974, 145)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(67, 17)
        NombreLabel.TabIndex = 24
        NombreLabel.Text = "Nombre:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(974, 175)
        CategoriaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(81, 17)
        CategoriaLabel.TabIndex = 26
        CategoriaLabel.Text = "Categoria:"
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_CompraLabel.Location = New System.Drawing.Point(974, 206)
        Fecha_CompraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(112, 17)
        Fecha_CompraLabel.TabIndex = 28
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantidadLabel.Location = New System.Drawing.Point(974, 235)
        CantidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(76, 17)
        CantidadLabel.TabIndex = 30
        CantidadLabel.Text = "Cantidad:"
        '
        'Costo_UnitarioLabel
        '
        Costo_UnitarioLabel.AutoSize = True
        Costo_UnitarioLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Costo_UnitarioLabel.Location = New System.Drawing.Point(974, 265)
        Costo_UnitarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Costo_UnitarioLabel.Name = "Costo_UnitarioLabel"
        Costo_UnitarioLabel.Size = New System.Drawing.Size(110, 17)
        Costo_UnitarioLabel.TabIndex = 32
        Costo_UnitarioLabel.Text = "Costo Unitario:"
        '
        'Costo_Sin_IVALabel
        '
        Costo_Sin_IVALabel.AutoSize = True
        Costo_Sin_IVALabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Costo_Sin_IVALabel.Location = New System.Drawing.Point(974, 295)
        Costo_Sin_IVALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Costo_Sin_IVALabel.Name = "Costo_Sin_IVALabel"
        Costo_Sin_IVALabel.Size = New System.Drawing.Size(104, 17)
        Costo_Sin_IVALabel.TabIndex = 34
        Costo_Sin_IVALabel.Text = "Costo Sin IVA:"
        '
        'IVA_UnitarioLabel
        '
        IVA_UnitarioLabel.AutoSize = True
        IVA_UnitarioLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IVA_UnitarioLabel.Location = New System.Drawing.Point(974, 325)
        IVA_UnitarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IVA_UnitarioLabel.Name = "IVA_UnitarioLabel"
        IVA_UnitarioLabel.Size = New System.Drawing.Size(96, 17)
        IVA_UnitarioLabel.TabIndex = 36
        IVA_UnitarioLabel.Text = "IVA Unitario:"
        '
        'Costo_TotalLabel
        '
        Costo_TotalLabel.AutoSize = True
        Costo_TotalLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Costo_TotalLabel.Location = New System.Drawing.Point(974, 355)
        Costo_TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Costo_TotalLabel.Name = "Costo_TotalLabel"
        Costo_TotalLabel.Size = New System.Drawing.Size(88, 17)
        Costo_TotalLabel.TabIndex = 38
        Costo_TotalLabel.Text = "Costo Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngredienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.FechaCompraDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CostoUnitarioDataGridViewTextBoxColumn, Me.CostoSinIVADataGridViewTextBoxColumn, Me.IVAUnitarioDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MateriaPrimaTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 110)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(945, 342)
        Me.DataGridView1.TabIndex = 0
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
        'MateriaPrimaTableBindingSource
        '
        Me.MateriaPrimaTableBindingSource.DataMember = "Materia_Prima_Table"
        Me.MateriaPrimaTableBindingSource.DataSource = Me.DelisCakeDatabaseDataSet
        '
        'DelisCakeDatabaseDataSet
        '
        Me.DelisCakeDatabaseDataSet.DataSetName = "DelisCakeDatabaseDataSet"
        Me.DelisCakeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(1112, 396)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 48)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1001, 396)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 48)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Id_Ingrediente", True))
        Me.TextBox1.Location = New System.Drawing.Point(1088, 110)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 22)
        Me.TextBox1.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(1088, 140)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 22)
        Me.TextBox2.TabIndex = 21
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Categoria", True))
        Me.TextBox3.Location = New System.Drawing.Point(1088, 170)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(256, 22)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Cantidad", True))
        Me.TextBox5.Location = New System.Drawing.Point(1088, 230)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(256, 22)
        Me.TextBox5.TabIndex = 21
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Costo_Unitario", True))
        Me.TextBox6.Location = New System.Drawing.Point(1088, 260)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(256, 22)
        Me.TextBox6.TabIndex = 21
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Costo_Sin_IVA", True))
        Me.TextBox7.Location = New System.Drawing.Point(1088, 290)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(256, 22)
        Me.TextBox7.TabIndex = 21
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "IVA_Unitario", True))
        Me.TextBox8.Location = New System.Drawing.Point(1088, 320)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(256, 22)
        Me.TextBox8.TabIndex = 21
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Costo_Total", True))
        Me.TextBox9.Location = New System.Drawing.Point(1088, 350)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(256, 22)
        Me.TextBox9.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaPrimaTableBindingSource, "Fecha_Compra", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1088, 200)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(256, 22)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1223, 396)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 48)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1056, 450)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 48)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1167, 450)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 48)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Materia_Prima_TableTableAdapter
        '
        Me.Materia_Prima_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Materia_Prima_TableTableAdapter = Me.Materia_Prima_TableTableAdapter
        Me.TableAdapterManager.Planilla_Empleados_TableTableAdapter = Nothing
        Me.TableAdapterManager.Productos_Terminados_TableTableAdapter = Nothing
        Me.TableAdapterManager.Proveedores_TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(100, 484)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 48)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "&Regresar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 10)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(158, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Amsterdam", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 86)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Materia Prima"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(14, 468)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(78, 80)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 42
        Me.PictureBox5.TabStop = False
        '
        'Materia_Prima_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 558)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
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
        Me.Font = New System.Drawing.Font("Louis George Cafe", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Materia_Prima_Form"
        Me.Text = "Materia_Prima_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TableAdapterManager As DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
