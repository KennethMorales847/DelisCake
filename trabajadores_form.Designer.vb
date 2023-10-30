<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class trabajadores_form
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
        Dim Codigo_EmpleadoLabel As System.Windows.Forms.Label
        Dim Nombre_CompletoLabel As System.Windows.Forms.Label
        Dim PuestoLabel As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim Num_Horas_ExtrasLabel As System.Windows.Forms.Label
        Dim Bonificacion_IncentivoLabel As System.Windows.Forms.Label
        Dim AnticipoLabel As System.Windows.Forms.Label
        Dim Horas_ExtrasLabel As System.Windows.Forms.Label
        Dim Total_DevengadoLabel As System.Windows.Forms.Label
        Dim IGSSLabel As System.Windows.Forms.Label
        Dim Total_DescuentosLabel As System.Windows.Forms.Label
        Dim Importe_a_RecibirLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trabajadores_form))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHorasExtrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonificacionIncentivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnticipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasExtrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDevengadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDescuentosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteaRecibirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanillaEmpleadosTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DelisCakeDatabaseDataSet = New DelisCake.DelisCakeDatabaseDataSet()
        Me.Planilla_Empleados_TableTableAdapter = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Planilla_Empleados_TableTableAdapter()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Codigo_EmpleadoLabel = New System.Windows.Forms.Label()
        Nombre_CompletoLabel = New System.Windows.Forms.Label()
        PuestoLabel = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        Num_Horas_ExtrasLabel = New System.Windows.Forms.Label()
        Bonificacion_IncentivoLabel = New System.Windows.Forms.Label()
        AnticipoLabel = New System.Windows.Forms.Label()
        Horas_ExtrasLabel = New System.Windows.Forms.Label()
        Total_DevengadoLabel = New System.Windows.Forms.Label()
        IGSSLabel = New System.Windows.Forms.Label()
        Total_DescuentosLabel = New System.Windows.Forms.Label()
        Importe_a_RecibirLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaEmpleadosTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Codigo_EmpleadoLabel
        '
        Codigo_EmpleadoLabel.AutoSize = True
        Codigo_EmpleadoLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Codigo_EmpleadoLabel.Location = New System.Drawing.Point(1274, 108)
        Codigo_EmpleadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Codigo_EmpleadoLabel.Name = "Codigo_EmpleadoLabel"
        Codigo_EmpleadoLabel.Size = New System.Drawing.Size(133, 17)
        Codigo_EmpleadoLabel.TabIndex = 53
        Codigo_EmpleadoLabel.Text = "Codigo Empleado:"
        '
        'Nombre_CompletoLabel
        '
        Nombre_CompletoLabel.AutoSize = True
        Nombre_CompletoLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_CompletoLabel.Location = New System.Drawing.Point(1274, 136)
        Nombre_CompletoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_CompletoLabel.Name = "Nombre_CompletoLabel"
        Nombre_CompletoLabel.Size = New System.Drawing.Size(137, 17)
        Nombre_CompletoLabel.TabIndex = 55
        Nombre_CompletoLabel.Text = "Nombre Completo:"
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PuestoLabel.Location = New System.Drawing.Point(1274, 164)
        PuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(57, 17)
        PuestoLabel.TabIndex = 57
        PuestoLabel.Text = "Puesto:"
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalarioLabel.Location = New System.Drawing.Point(1274, 192)
        SalarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(60, 17)
        SalarioLabel.TabIndex = 59
        SalarioLabel.Text = "Salario:"
        '
        'Num_Horas_ExtrasLabel
        '
        Num_Horas_ExtrasLabel.AutoSize = True
        Num_Horas_ExtrasLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_Horas_ExtrasLabel.Location = New System.Drawing.Point(1274, 220)
        Num_Horas_ExtrasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Num_Horas_ExtrasLabel.Name = "Num_Horas_ExtrasLabel"
        Num_Horas_ExtrasLabel.Size = New System.Drawing.Size(136, 17)
        Num_Horas_ExtrasLabel.TabIndex = 61
        Num_Horas_ExtrasLabel.Text = "Num Horas Extras:"
        '
        'Bonificacion_IncentivoLabel
        '
        Bonificacion_IncentivoLabel.AutoSize = True
        Bonificacion_IncentivoLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Bonificacion_IncentivoLabel.Location = New System.Drawing.Point(1274, 248)
        Bonificacion_IncentivoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Bonificacion_IncentivoLabel.Name = "Bonificacion_IncentivoLabel"
        Bonificacion_IncentivoLabel.Size = New System.Drawing.Size(160, 17)
        Bonificacion_IncentivoLabel.TabIndex = 63
        Bonificacion_IncentivoLabel.Text = "Bonificacion Incentivo:"
        '
        'AnticipoLabel
        '
        AnticipoLabel.AutoSize = True
        AnticipoLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnticipoLabel.Location = New System.Drawing.Point(1274, 276)
        AnticipoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AnticipoLabel.Name = "AnticipoLabel"
        AnticipoLabel.Size = New System.Drawing.Size(68, 17)
        AnticipoLabel.TabIndex = 65
        AnticipoLabel.Text = "Anticipo:"
        '
        'Horas_ExtrasLabel
        '
        Horas_ExtrasLabel.AutoSize = True
        Horas_ExtrasLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Horas_ExtrasLabel.Location = New System.Drawing.Point(1274, 304)
        Horas_ExtrasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Horas_ExtrasLabel.Name = "Horas_ExtrasLabel"
        Horas_ExtrasLabel.Size = New System.Drawing.Size(100, 17)
        Horas_ExtrasLabel.TabIndex = 67
        Horas_ExtrasLabel.Text = "Horas Extras:"
        '
        'Total_DevengadoLabel
        '
        Total_DevengadoLabel.AutoSize = True
        Total_DevengadoLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_DevengadoLabel.Location = New System.Drawing.Point(1274, 332)
        Total_DevengadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_DevengadoLabel.Name = "Total_DevengadoLabel"
        Total_DevengadoLabel.Size = New System.Drawing.Size(126, 17)
        Total_DevengadoLabel.TabIndex = 69
        Total_DevengadoLabel.Text = "Total Devengado:"
        '
        'IGSSLabel
        '
        IGSSLabel.AutoSize = True
        IGSSLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IGSSLabel.Location = New System.Drawing.Point(1274, 360)
        IGSSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IGSSLabel.Name = "IGSSLabel"
        IGSSLabel.Size = New System.Drawing.Size(44, 17)
        IGSSLabel.TabIndex = 71
        IGSSLabel.Text = "IGSS:"
        '
        'Total_DescuentosLabel
        '
        Total_DescuentosLabel.AutoSize = True
        Total_DescuentosLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_DescuentosLabel.Location = New System.Drawing.Point(1274, 388)
        Total_DescuentosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_DescuentosLabel.Name = "Total_DescuentosLabel"
        Total_DescuentosLabel.Size = New System.Drawing.Size(126, 17)
        Total_DescuentosLabel.TabIndex = 73
        Total_DescuentosLabel.Text = "Total Descuentos:"
        '
        'Importe_a_RecibirLabel
        '
        Importe_a_RecibirLabel.AutoSize = True
        Importe_a_RecibirLabel.Font = New System.Drawing.Font("Louis George Cafe", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Importe_a_RecibirLabel.Location = New System.Drawing.Point(1274, 416)
        Importe_a_RecibirLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Importe_a_RecibirLabel.Name = "Importe_a_RecibirLabel"
        Importe_a_RecibirLabel.Size = New System.Drawing.Size(130, 17)
        Importe_a_RecibirLabel.TabIndex = 75
        Importe_a_RecibirLabel.Text = "Importe a Recibir:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1445, 494)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 45)
        Me.Button5.TabIndex = 44
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1334, 494)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 45)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1508, 443)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 45)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1397, 443)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 45)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1286, 443)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 45)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoEmpleadoDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.PuestoDataGridViewTextBoxColumn, Me.SalarioDataGridViewTextBoxColumn, Me.NumHorasExtrasDataGridViewTextBoxColumn, Me.BonificacionIncentivoDataGridViewTextBoxColumn, Me.AnticipoDataGridViewTextBoxColumn, Me.HorasExtrasDataGridViewTextBoxColumn, Me.TotalDevengadoDataGridViewTextBoxColumn, Me.IGSSDataGridViewTextBoxColumn, Me.TotalDescuentosDataGridViewTextBoxColumn, Me.ImporteaRecibirDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PlanillaEmpleadosTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 92)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1242, 412)
        Me.DataGridView1.TabIndex = 45
        '
        'CodigoEmpleadoDataGridViewTextBoxColumn
        '
        Me.CodigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Empleado"
        Me.CodigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "Codigo_Empleado"
        Me.CodigoEmpleadoDataGridViewTextBoxColumn.Name = "CodigoEmpleadoDataGridViewTextBoxColumn"
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre_Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        '
        'PuestoDataGridViewTextBoxColumn
        '
        Me.PuestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.HeaderText = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.Name = "PuestoDataGridViewTextBoxColumn"
        '
        'SalarioDataGridViewTextBoxColumn
        '
        Me.SalarioDataGridViewTextBoxColumn.DataPropertyName = "Salario"
        Me.SalarioDataGridViewTextBoxColumn.HeaderText = "Salario"
        Me.SalarioDataGridViewTextBoxColumn.Name = "SalarioDataGridViewTextBoxColumn"
        '
        'NumHorasExtrasDataGridViewTextBoxColumn
        '
        Me.NumHorasExtrasDataGridViewTextBoxColumn.DataPropertyName = "Num_Horas_Extras"
        Me.NumHorasExtrasDataGridViewTextBoxColumn.HeaderText = "Num_Horas_Extras"
        Me.NumHorasExtrasDataGridViewTextBoxColumn.Name = "NumHorasExtrasDataGridViewTextBoxColumn"
        '
        'BonificacionIncentivoDataGridViewTextBoxColumn
        '
        Me.BonificacionIncentivoDataGridViewTextBoxColumn.DataPropertyName = "Bonificacion_Incentivo"
        Me.BonificacionIncentivoDataGridViewTextBoxColumn.HeaderText = "Bonificacion_Incentivo"
        Me.BonificacionIncentivoDataGridViewTextBoxColumn.Name = "BonificacionIncentivoDataGridViewTextBoxColumn"
        '
        'AnticipoDataGridViewTextBoxColumn
        '
        Me.AnticipoDataGridViewTextBoxColumn.DataPropertyName = "Anticipo"
        Me.AnticipoDataGridViewTextBoxColumn.HeaderText = "Anticipo"
        Me.AnticipoDataGridViewTextBoxColumn.Name = "AnticipoDataGridViewTextBoxColumn"
        '
        'HorasExtrasDataGridViewTextBoxColumn
        '
        Me.HorasExtrasDataGridViewTextBoxColumn.DataPropertyName = "Horas_Extras"
        Me.HorasExtrasDataGridViewTextBoxColumn.HeaderText = "Horas_Extras"
        Me.HorasExtrasDataGridViewTextBoxColumn.Name = "HorasExtrasDataGridViewTextBoxColumn"
        Me.HorasExtrasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDevengadoDataGridViewTextBoxColumn
        '
        Me.TotalDevengadoDataGridViewTextBoxColumn.DataPropertyName = "Total_Devengado"
        Me.TotalDevengadoDataGridViewTextBoxColumn.HeaderText = "Total_Devengado"
        Me.TotalDevengadoDataGridViewTextBoxColumn.Name = "TotalDevengadoDataGridViewTextBoxColumn"
        Me.TotalDevengadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IGSSDataGridViewTextBoxColumn
        '
        Me.IGSSDataGridViewTextBoxColumn.DataPropertyName = "IGSS"
        Me.IGSSDataGridViewTextBoxColumn.HeaderText = "IGSS"
        Me.IGSSDataGridViewTextBoxColumn.Name = "IGSSDataGridViewTextBoxColumn"
        Me.IGSSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDescuentosDataGridViewTextBoxColumn
        '
        Me.TotalDescuentosDataGridViewTextBoxColumn.DataPropertyName = "Total_Descuentos"
        Me.TotalDescuentosDataGridViewTextBoxColumn.HeaderText = "Total_Descuentos"
        Me.TotalDescuentosDataGridViewTextBoxColumn.Name = "TotalDescuentosDataGridViewTextBoxColumn"
        Me.TotalDescuentosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteaRecibirDataGridViewTextBoxColumn
        '
        Me.ImporteaRecibirDataGridViewTextBoxColumn.DataPropertyName = "Importe_a_Recibir"
        Me.ImporteaRecibirDataGridViewTextBoxColumn.HeaderText = "Importe_a_Recibir"
        Me.ImporteaRecibirDataGridViewTextBoxColumn.Name = "ImporteaRecibirDataGridViewTextBoxColumn"
        Me.ImporteaRecibirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlanillaEmpleadosTableBindingSource
        '
        Me.PlanillaEmpleadosTableBindingSource.DataMember = "Planilla_Empleados_Table"
        Me.PlanillaEmpleadosTableBindingSource.DataSource = Me.DelisCakeDatabaseDataSet
        '
        'DelisCakeDatabaseDataSet
        '
        Me.DelisCakeDatabaseDataSet.DataSetName = "DelisCakeDatabaseDataSet"
        Me.DelisCakeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Planilla_Empleados_TableTableAdapter
        '
        Me.Planilla_Empleados_TableTableAdapter.ClearBeforeFill = True
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Total_Devengado", True))
        Me.TextBox9.Location = New System.Drawing.Point(1445, 332)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(167, 21)
        Me.TextBox9.TabIndex = 46
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Bonificacion_Incentivo", True))
        Me.TextBox6.Location = New System.Drawing.Point(1445, 244)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(167, 21)
        Me.TextBox6.TabIndex = 47
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Puesto", True))
        Me.TextBox3.Location = New System.Drawing.Point(1445, 160)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(167, 21)
        Me.TextBox3.TabIndex = 48
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Horas_Extras", True))
        Me.TextBox8.Location = New System.Drawing.Point(1445, 304)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(167, 21)
        Me.TextBox8.TabIndex = 49
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Num_Horas_Extras", True))
        Me.TextBox5.Location = New System.Drawing.Point(1445, 216)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(167, 21)
        Me.TextBox5.TabIndex = 50
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Nombre_Completo", True))
        Me.TextBox2.Location = New System.Drawing.Point(1445, 132)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(167, 21)
        Me.TextBox2.TabIndex = 51
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Anticipo", True))
        Me.TextBox7.Location = New System.Drawing.Point(1445, 276)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(167, 21)
        Me.TextBox7.TabIndex = 52
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Codigo_Empleado", True))
        Me.TextBox1.Location = New System.Drawing.Point(1445, 104)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 21)
        Me.TextBox1.TabIndex = 53
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Salario", True))
        Me.TextBox4.Location = New System.Drawing.Point(1445, 188)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(167, 21)
        Me.TextBox4.TabIndex = 50
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Materia_Prima_TableTableAdapter = Nothing
        Me.TableAdapterManager.Planilla_Empleados_TableTableAdapter = Me.Planilla_Empleados_TableTableAdapter
        Me.TableAdapterManager.Productos_Terminados_TableTableAdapter = Nothing
        Me.TableAdapterManager.Proveedores_TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "IGSS", True))
        Me.TextBox10.Location = New System.Drawing.Point(1445, 360)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(167, 21)
        Me.TextBox10.TabIndex = 47
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Total_Descuentos", True))
        Me.TextBox11.Location = New System.Drawing.Point(1445, 388)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(167, 21)
        Me.TextBox11.TabIndex = 47
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaEmpleadosTableBindingSource, "Importe_a_Recibir", True))
        Me.TextBox12.Location = New System.Drawing.Point(1445, 416)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(167, 21)
        Me.TextBox12.TabIndex = 47
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(14, 510)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(91, 86)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 77
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 1)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 86
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Amsterdam", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, -3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 86)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Trabajadores"
        '
        'trabajadores_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 602)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Codigo_EmpleadoLabel)
        Me.Controls.Add(Nombre_CompletoLabel)
        Me.Controls.Add(PuestoLabel)
        Me.Controls.Add(SalarioLabel)
        Me.Controls.Add(Num_Horas_ExtrasLabel)
        Me.Controls.Add(Bonificacion_IncentivoLabel)
        Me.Controls.Add(AnticipoLabel)
        Me.Controls.Add(Horas_ExtrasLabel)
        Me.Controls.Add(Total_DevengadoLabel)
        Me.Controls.Add(IGSSLabel)
        Me.Controls.Add(Total_DescuentosLabel)
        Me.Controls.Add(Importe_a_RecibirLabel)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Louis George Cafe", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "trabajadores_form"
        Me.Text = "trabajadores_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaEmpleadosTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeDatabaseDataSet As DelisCakeDatabaseDataSet
    Friend WithEvents PlanillaEmpleadosTableBindingSource As BindingSource
    Friend WithEvents Planilla_Empleados_TableTableAdapter As DelisCakeDatabaseDataSetTableAdapters.Planilla_Empleados_TableTableAdapter
    Friend WithEvents CodigoEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumHorasExtrasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BonificacionIncentivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnticipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasExtrasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDevengadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IGSSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDescuentosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteaRecibirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TableAdapterManager As DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
