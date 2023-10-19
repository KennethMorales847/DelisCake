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
        Dim ISRLabel As System.Windows.Forms.Label
        Dim Total_DescuentosLabel As System.Windows.Forms.Label
        Dim Importe_a_RecibirLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DelisCakeSet3 = New DelisCake.DelisCakeSet3()
        Me.PlanillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaTableAdapter = New DelisCake.DelisCakeSet3TableAdapters.PlanillaTableAdapter()
        Me.CodigoEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHorasExtrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasExtrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonificacionIncentivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDevengadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnticipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDescuentosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteaRecibirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New DelisCake.DelisCakeSet3TableAdapters.TableAdapterManager()
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
        Me.ISRTextBox = New System.Windows.Forms.TextBox()
        Me.Total_DescuentosTextBox = New System.Windows.Forms.TextBox()
        Me.Importe_a_RecibirTextBox = New System.Windows.Forms.TextBox()
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
        ISRLabel = New System.Windows.Forms.Label()
        Total_DescuentosLabel = New System.Windows.Forms.Label()
        Importe_a_RecibirLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoEmpleadoDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.PuestoDataGridViewTextBoxColumn, Me.SalarioDataGridViewTextBoxColumn, Me.NumHorasExtrasDataGridViewTextBoxColumn, Me.HorasExtrasDataGridViewTextBoxColumn, Me.BonificacionIncentivoDataGridViewTextBoxColumn, Me.TotalDevengadoDataGridViewTextBoxColumn, Me.AnticipoDataGridViewTextBoxColumn, Me.IGSSDataGridViewTextBoxColumn, Me.ISRDataGridViewTextBoxColumn, Me.TotalDescuentosDataGridViewTextBoxColumn, Me.ImporteaRecibirDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PlanillaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(775, 329)
        Me.DataGridView1.TabIndex = 0
        '
        'DelisCakeSet3
        '
        Me.DelisCakeSet3.DataSetName = "DelisCakeSet3"
        Me.DelisCakeSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanillaBindingSource
        '
        Me.PlanillaBindingSource.DataMember = "Planilla"
        Me.PlanillaBindingSource.DataSource = Me.DelisCakeSet3
        '
        'PlanillaTableAdapter
        '
        Me.PlanillaTableAdapter.ClearBeforeFill = True
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
        'HorasExtrasDataGridViewTextBoxColumn
        '
        Me.HorasExtrasDataGridViewTextBoxColumn.DataPropertyName = "Horas_Extras"
        Me.HorasExtrasDataGridViewTextBoxColumn.HeaderText = "Horas_Extras"
        Me.HorasExtrasDataGridViewTextBoxColumn.Name = "HorasExtrasDataGridViewTextBoxColumn"
        Me.HorasExtrasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BonificacionIncentivoDataGridViewTextBoxColumn
        '
        Me.BonificacionIncentivoDataGridViewTextBoxColumn.DataPropertyName = "Bonificacion_Incentivo"
        Me.BonificacionIncentivoDataGridViewTextBoxColumn.HeaderText = "Bonificacion_Incentivo"
        Me.BonificacionIncentivoDataGridViewTextBoxColumn.Name = "BonificacionIncentivoDataGridViewTextBoxColumn"
        '
        'TotalDevengadoDataGridViewTextBoxColumn
        '
        Me.TotalDevengadoDataGridViewTextBoxColumn.DataPropertyName = "Total_Devengado"
        Me.TotalDevengadoDataGridViewTextBoxColumn.HeaderText = "Total_Devengado"
        Me.TotalDevengadoDataGridViewTextBoxColumn.Name = "TotalDevengadoDataGridViewTextBoxColumn"
        Me.TotalDevengadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnticipoDataGridViewTextBoxColumn
        '
        Me.AnticipoDataGridViewTextBoxColumn.DataPropertyName = "Anticipo"
        Me.AnticipoDataGridViewTextBoxColumn.HeaderText = "Anticipo"
        Me.AnticipoDataGridViewTextBoxColumn.Name = "AnticipoDataGridViewTextBoxColumn"
        '
        'IGSSDataGridViewTextBoxColumn
        '
        Me.IGSSDataGridViewTextBoxColumn.DataPropertyName = "IGSS"
        Me.IGSSDataGridViewTextBoxColumn.HeaderText = "IGSS"
        Me.IGSSDataGridViewTextBoxColumn.Name = "IGSSDataGridViewTextBoxColumn"
        '
        'ISRDataGridViewTextBoxColumn
        '
        Me.ISRDataGridViewTextBoxColumn.DataPropertyName = "ISR"
        Me.ISRDataGridViewTextBoxColumn.HeaderText = "ISR"
        Me.ISRDataGridViewTextBoxColumn.Name = "ISRDataGridViewTextBoxColumn"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PlanillaTableAdapter = Me.PlanillaTableAdapter
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Codigo_EmpleadoLabel
        '
        Codigo_EmpleadoLabel.AutoSize = True
        Codigo_EmpleadoLabel.Location = New System.Drawing.Point(806, 13)
        Codigo_EmpleadoLabel.Name = "Codigo_EmpleadoLabel"
        Codigo_EmpleadoLabel.Size = New System.Drawing.Size(93, 13)
        Codigo_EmpleadoLabel.TabIndex = 1
        Codigo_EmpleadoLabel.Text = "Codigo Empleado:"
        '
        'Codigo_EmpleadoTextBox
        '
        Me.Codigo_EmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Codigo_Empleado", True))
        Me.Codigo_EmpleadoTextBox.Location = New System.Drawing.Point(927, 10)
        Me.Codigo_EmpleadoTextBox.Name = "Codigo_EmpleadoTextBox"
        Me.Codigo_EmpleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Codigo_EmpleadoTextBox.TabIndex = 2
        '
        'Nombre_CompletoLabel
        '
        Nombre_CompletoLabel.AutoSize = True
        Nombre_CompletoLabel.Location = New System.Drawing.Point(806, 39)
        Nombre_CompletoLabel.Name = "Nombre_CompletoLabel"
        Nombre_CompletoLabel.Size = New System.Drawing.Size(94, 13)
        Nombre_CompletoLabel.TabIndex = 3
        Nombre_CompletoLabel.Text = "Nombre Completo:"
        '
        'Nombre_CompletoTextBox
        '
        Me.Nombre_CompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Nombre_Completo", True))
        Me.Nombre_CompletoTextBox.Location = New System.Drawing.Point(927, 36)
        Me.Nombre_CompletoTextBox.Name = "Nombre_CompletoTextBox"
        Me.Nombre_CompletoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_CompletoTextBox.TabIndex = 4
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Location = New System.Drawing.Point(806, 65)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(43, 13)
        PuestoLabel.TabIndex = 5
        PuestoLabel.Text = "Puesto:"
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(927, 62)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PuestoTextBox.TabIndex = 6
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Location = New System.Drawing.Point(806, 91)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(42, 13)
        SalarioLabel.TabIndex = 7
        SalarioLabel.Text = "Salario:"
        '
        'SalarioTextBox
        '
        Me.SalarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Salario", True))
        Me.SalarioTextBox.Location = New System.Drawing.Point(927, 88)
        Me.SalarioTextBox.Name = "SalarioTextBox"
        Me.SalarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalarioTextBox.TabIndex = 8
        '
        'Num_Horas_ExtrasLabel
        '
        Num_Horas_ExtrasLabel.AutoSize = True
        Num_Horas_ExtrasLabel.Location = New System.Drawing.Point(806, 117)
        Num_Horas_ExtrasLabel.Name = "Num_Horas_ExtrasLabel"
        Num_Horas_ExtrasLabel.Size = New System.Drawing.Size(95, 13)
        Num_Horas_ExtrasLabel.TabIndex = 9
        Num_Horas_ExtrasLabel.Text = "Num Horas Extras:"
        '
        'Num_Horas_ExtrasTextBox
        '
        Me.Num_Horas_ExtrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Num_Horas_Extras", True))
        Me.Num_Horas_ExtrasTextBox.Location = New System.Drawing.Point(927, 114)
        Me.Num_Horas_ExtrasTextBox.Name = "Num_Horas_ExtrasTextBox"
        Me.Num_Horas_ExtrasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Num_Horas_ExtrasTextBox.TabIndex = 10
        '
        'Horas_ExtrasLabel
        '
        Horas_ExtrasLabel.AutoSize = True
        Horas_ExtrasLabel.Location = New System.Drawing.Point(806, 143)
        Horas_ExtrasLabel.Name = "Horas_ExtrasLabel"
        Horas_ExtrasLabel.Size = New System.Drawing.Size(70, 13)
        Horas_ExtrasLabel.TabIndex = 11
        Horas_ExtrasLabel.Text = "Horas Extras:"
        '
        'Horas_ExtrasTextBox
        '
        Me.Horas_ExtrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Horas_Extras", True))
        Me.Horas_ExtrasTextBox.Location = New System.Drawing.Point(927, 140)
        Me.Horas_ExtrasTextBox.Name = "Horas_ExtrasTextBox"
        Me.Horas_ExtrasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Horas_ExtrasTextBox.TabIndex = 12
        '
        'Bonificacion_IncentivoLabel
        '
        Bonificacion_IncentivoLabel.AutoSize = True
        Bonificacion_IncentivoLabel.Location = New System.Drawing.Point(806, 169)
        Bonificacion_IncentivoLabel.Name = "Bonificacion_IncentivoLabel"
        Bonificacion_IncentivoLabel.Size = New System.Drawing.Size(115, 13)
        Bonificacion_IncentivoLabel.TabIndex = 13
        Bonificacion_IncentivoLabel.Text = "Bonificacion Incentivo:"
        '
        'Bonificacion_IncentivoTextBox
        '
        Me.Bonificacion_IncentivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Bonificacion_Incentivo", True))
        Me.Bonificacion_IncentivoTextBox.Location = New System.Drawing.Point(927, 166)
        Me.Bonificacion_IncentivoTextBox.Name = "Bonificacion_IncentivoTextBox"
        Me.Bonificacion_IncentivoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bonificacion_IncentivoTextBox.TabIndex = 14
        '
        'Total_DevengadoLabel
        '
        Total_DevengadoLabel.AutoSize = True
        Total_DevengadoLabel.Location = New System.Drawing.Point(806, 195)
        Total_DevengadoLabel.Name = "Total_DevengadoLabel"
        Total_DevengadoLabel.Size = New System.Drawing.Size(93, 13)
        Total_DevengadoLabel.TabIndex = 15
        Total_DevengadoLabel.Text = "Total Devengado:"
        '
        'Total_DevengadoTextBox
        '
        Me.Total_DevengadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Total_Devengado", True))
        Me.Total_DevengadoTextBox.Location = New System.Drawing.Point(927, 192)
        Me.Total_DevengadoTextBox.Name = "Total_DevengadoTextBox"
        Me.Total_DevengadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_DevengadoTextBox.TabIndex = 16
        '
        'AnticipoLabel
        '
        AnticipoLabel.AutoSize = True
        AnticipoLabel.Location = New System.Drawing.Point(806, 221)
        AnticipoLabel.Name = "AnticipoLabel"
        AnticipoLabel.Size = New System.Drawing.Size(48, 13)
        AnticipoLabel.TabIndex = 17
        AnticipoLabel.Text = "Anticipo:"
        '
        'AnticipoTextBox
        '
        Me.AnticipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Anticipo", True))
        Me.AnticipoTextBox.Location = New System.Drawing.Point(927, 218)
        Me.AnticipoTextBox.Name = "AnticipoTextBox"
        Me.AnticipoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnticipoTextBox.TabIndex = 18
        '
        'IGSSLabel
        '
        IGSSLabel.AutoSize = True
        IGSSLabel.Location = New System.Drawing.Point(806, 247)
        IGSSLabel.Name = "IGSSLabel"
        IGSSLabel.Size = New System.Drawing.Size(35, 13)
        IGSSLabel.TabIndex = 19
        IGSSLabel.Text = "IGSS:"
        '
        'IGSSTextBox
        '
        Me.IGSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "IGSS", True))
        Me.IGSSTextBox.Location = New System.Drawing.Point(927, 244)
        Me.IGSSTextBox.Name = "IGSSTextBox"
        Me.IGSSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IGSSTextBox.TabIndex = 20
        '
        'ISRLabel
        '
        ISRLabel.AutoSize = True
        ISRLabel.Location = New System.Drawing.Point(806, 273)
        ISRLabel.Name = "ISRLabel"
        ISRLabel.Size = New System.Drawing.Size(28, 13)
        ISRLabel.TabIndex = 21
        ISRLabel.Text = "ISR:"
        '
        'ISRTextBox
        '
        Me.ISRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "ISR", True))
        Me.ISRTextBox.Location = New System.Drawing.Point(927, 270)
        Me.ISRTextBox.Name = "ISRTextBox"
        Me.ISRTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ISRTextBox.TabIndex = 22
        '
        'Total_DescuentosLabel
        '
        Total_DescuentosLabel.AutoSize = True
        Total_DescuentosLabel.Location = New System.Drawing.Point(806, 299)
        Total_DescuentosLabel.Name = "Total_DescuentosLabel"
        Total_DescuentosLabel.Size = New System.Drawing.Size(94, 13)
        Total_DescuentosLabel.TabIndex = 23
        Total_DescuentosLabel.Text = "Total Descuentos:"
        '
        'Total_DescuentosTextBox
        '
        Me.Total_DescuentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Total_Descuentos", True))
        Me.Total_DescuentosTextBox.Location = New System.Drawing.Point(927, 296)
        Me.Total_DescuentosTextBox.Name = "Total_DescuentosTextBox"
        Me.Total_DescuentosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_DescuentosTextBox.TabIndex = 24
        '
        'Importe_a_RecibirLabel
        '
        Importe_a_RecibirLabel.AutoSize = True
        Importe_a_RecibirLabel.Location = New System.Drawing.Point(806, 325)
        Importe_a_RecibirLabel.Name = "Importe_a_RecibirLabel"
        Importe_a_RecibirLabel.Size = New System.Drawing.Size(90, 13)
        Importe_a_RecibirLabel.TabIndex = 25
        Importe_a_RecibirLabel.Text = "Importe a Recibir:"
        '
        'Importe_a_RecibirTextBox
        '
        Me.Importe_a_RecibirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillaBindingSource, "Importe_a_Recibir", True))
        Me.Importe_a_RecibirTextBox.Location = New System.Drawing.Point(927, 322)
        Me.Importe_a_RecibirTextBox.Name = "Importe_a_RecibirTextBox"
        Me.Importe_a_RecibirTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Importe_a_RecibirTextBox.TabIndex = 26
        '
        'trabajadores_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 381)
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
        Me.Controls.Add(ISRLabel)
        Me.Controls.Add(Me.ISRTextBox)
        Me.Controls.Add(Total_DescuentosLabel)
        Me.Controls.Add(Me.Total_DescuentosTextBox)
        Me.Controls.Add(Importe_a_RecibirLabel)
        Me.Controls.Add(Me.Importe_a_RecibirTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "trabajadores_form"
        Me.Text = "trabajadores_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeSet3 As DelisCakeSet3
    Friend WithEvents PlanillaBindingSource As BindingSource
    Friend WithEvents PlanillaTableAdapter As DelisCakeSet3TableAdapters.PlanillaTableAdapter
    Friend WithEvents CodigoEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumHorasExtrasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasExtrasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BonificacionIncentivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDevengadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnticipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IGSSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDescuentosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteaRecibirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DelisCakeSet3TableAdapters.TableAdapterManager
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
    Friend WithEvents ISRTextBox As TextBox
    Friend WithEvents Total_DescuentosTextBox As TextBox
    Friend WithEvents Importe_a_RecibirTextBox As TextBox
End Class
