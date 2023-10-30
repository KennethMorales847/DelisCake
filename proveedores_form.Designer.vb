<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores_form
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
        Dim Id_ProveedorLabel As System.Windows.Forms.Label
        Dim Razon_SocialLabel As System.Windows.Forms.Label
        Dim Nombre_RepresentanteLabel As System.Windows.Forms.Label
        Dim NIT_RepresentanteLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim Codigo_PostalLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Tipo_de_PagoLabel As System.Windows.Forms.Label
        Dim Cuenta_BancariaLabel As System.Windows.Forms.Label
        Dim Plazo_de_pagoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proveedores_form))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRepresentanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NITRepresentanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipodePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaBancariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlazodepagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedoresTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DelisCakeDatabaseDataSet = New DelisCake.DelisCakeDatabaseDataSet()
        Me.Proveedores_TableTableAdapter = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Proveedores_TableTableAdapter()
        Me.TableAdapterManager = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_ProveedorLabel = New System.Windows.Forms.Label()
        Razon_SocialLabel = New System.Windows.Forms.Label()
        Nombre_RepresentanteLabel = New System.Windows.Forms.Label()
        NIT_RepresentanteLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        Codigo_PostalLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Tipo_de_PagoLabel = New System.Windows.Forms.Label()
        Cuenta_BancariaLabel = New System.Windows.Forms.Label()
        Plazo_de_pagoLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_ProveedorLabel.Location = New System.Drawing.Point(17, 401)
        Id_ProveedorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(108, 17)
        Id_ProveedorLabel.TabIndex = 1
        Id_ProveedorLabel.Text = "Id Proveedor:"
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Razon_SocialLabel.Location = New System.Drawing.Point(17, 431)
        Razon_SocialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(104, 17)
        Razon_SocialLabel.TabIndex = 3
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'Nombre_RepresentanteLabel
        '
        Nombre_RepresentanteLabel.AutoSize = True
        Nombre_RepresentanteLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_RepresentanteLabel.Location = New System.Drawing.Point(17, 462)
        Nombre_RepresentanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_RepresentanteLabel.Name = "Nombre_RepresentanteLabel"
        Nombre_RepresentanteLabel.Size = New System.Drawing.Size(182, 17)
        Nombre_RepresentanteLabel.TabIndex = 5
        Nombre_RepresentanteLabel.Text = "Nombre Representante:"
        '
        'NIT_RepresentanteLabel
        '
        NIT_RepresentanteLabel.AutoSize = True
        NIT_RepresentanteLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIT_RepresentanteLabel.Location = New System.Drawing.Point(17, 492)
        NIT_RepresentanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NIT_RepresentanteLabel.Name = "NIT_RepresentanteLabel"
        NIT_RepresentanteLabel.Size = New System.Drawing.Size(146, 17)
        NIT_RepresentanteLabel.TabIndex = 7
        NIT_RepresentanteLabel.Text = "NIT Representante:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaisLabel.Location = New System.Drawing.Point(17, 521)
        PaisLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(44, 17)
        PaisLabel.TabIndex = 9
        PaisLabel.Text = "Pais:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.Location = New System.Drawing.Point(17, 551)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(66, 17)
        CiudadLabel.TabIndex = 11
        CiudadLabel.Text = "Ciudad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(17, 581)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(81, 17)
        DireccionLabel.TabIndex = 13
        DireccionLabel.Text = "Direccion:"
        '
        'Codigo_PostalLabel
        '
        Codigo_PostalLabel.AutoSize = True
        Codigo_PostalLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Codigo_PostalLabel.Location = New System.Drawing.Point(429, 401)
        Codigo_PostalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Codigo_PostalLabel.Name = "Codigo_PostalLabel"
        Codigo_PostalLabel.Size = New System.Drawing.Size(115, 17)
        Codigo_PostalLabel.TabIndex = 15
        Codigo_PostalLabel.Text = "Codigo Postal:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(429, 431)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(73, 17)
        TelefonoLabel.TabIndex = 17
        TelefonoLabel.Text = "Telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(429, 461)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 17)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'Tipo_de_PagoLabel
        '
        Tipo_de_PagoLabel.AutoSize = True
        Tipo_de_PagoLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_de_PagoLabel.Location = New System.Drawing.Point(429, 491)
        Tipo_de_PagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tipo_de_PagoLabel.Name = "Tipo_de_PagoLabel"
        Tipo_de_PagoLabel.Size = New System.Drawing.Size(107, 17)
        Tipo_de_PagoLabel.TabIndex = 21
        Tipo_de_PagoLabel.Text = "Tipo de Pago:"
        '
        'Cuenta_BancariaLabel
        '
        Cuenta_BancariaLabel.AutoSize = True
        Cuenta_BancariaLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cuenta_BancariaLabel.Location = New System.Drawing.Point(429, 521)
        Cuenta_BancariaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cuenta_BancariaLabel.Name = "Cuenta_BancariaLabel"
        Cuenta_BancariaLabel.Size = New System.Drawing.Size(134, 17)
        Cuenta_BancariaLabel.TabIndex = 23
        Cuenta_BancariaLabel.Text = "Cuenta Bancaria:"
        '
        'Plazo_de_pagoLabel
        '
        Plazo_de_pagoLabel.AutoSize = True
        Plazo_de_pagoLabel.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Plazo_de_pagoLabel.Location = New System.Drawing.Point(429, 551)
        Plazo_de_pagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Plazo_de_pagoLabel.Name = "Plazo_de_pagoLabel"
        Plazo_de_pagoLabel.Size = New System.Drawing.Size(116, 17)
        Plazo_de_pagoLabel.TabIndex = 25
        Plazo_de_pagoLabel.Text = "Plazo de pago:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.NombreRepresentanteDataGridViewTextBoxColumn, Me.NITRepresentanteDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TipodePagoDataGridViewTextBoxColumn, Me.CuentaBancariaDataGridViewTextBoxColumn, Me.PlazodepagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProveedoresTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 128)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1350, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "Razon_Social"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razon_Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        '
        'NombreRepresentanteDataGridViewTextBoxColumn
        '
        Me.NombreRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Representante"
        Me.NombreRepresentanteDataGridViewTextBoxColumn.HeaderText = "Nombre_Representante"
        Me.NombreRepresentanteDataGridViewTextBoxColumn.Name = "NombreRepresentanteDataGridViewTextBoxColumn"
        '
        'NITRepresentanteDataGridViewTextBoxColumn
        '
        Me.NITRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "NIT_Representante"
        Me.NITRepresentanteDataGridViewTextBoxColumn.HeaderText = "NIT_Representante"
        Me.NITRepresentanteDataGridViewTextBoxColumn.Name = "NITRepresentanteDataGridViewTextBoxColumn"
        '
        'PaisDataGridViewTextBoxColumn
        '
        Me.PaisDataGridViewTextBoxColumn.DataPropertyName = "Pais"
        Me.PaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.PaisDataGridViewTextBoxColumn.Name = "PaisDataGridViewTextBoxColumn"
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'CodigoPostalDataGridViewTextBoxColumn
        '
        Me.CodigoPostalDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Postal"
        Me.CodigoPostalDataGridViewTextBoxColumn.HeaderText = "Codigo_Postal"
        Me.CodigoPostalDataGridViewTextBoxColumn.Name = "CodigoPostalDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TipodePagoDataGridViewTextBoxColumn
        '
        Me.TipodePagoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_de_Pago"
        Me.TipodePagoDataGridViewTextBoxColumn.HeaderText = "Tipo_de_Pago"
        Me.TipodePagoDataGridViewTextBoxColumn.Name = "TipodePagoDataGridViewTextBoxColumn"
        '
        'CuentaBancariaDataGridViewTextBoxColumn
        '
        Me.CuentaBancariaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta_Bancaria"
        Me.CuentaBancariaDataGridViewTextBoxColumn.HeaderText = "Cuenta_Bancaria"
        Me.CuentaBancariaDataGridViewTextBoxColumn.Name = "CuentaBancariaDataGridViewTextBoxColumn"
        '
        'PlazodepagoDataGridViewTextBoxColumn
        '
        Me.PlazodepagoDataGridViewTextBoxColumn.DataPropertyName = "Plazo_de_pago"
        Me.PlazodepagoDataGridViewTextBoxColumn.HeaderText = "Plazo_de_pago"
        Me.PlazodepagoDataGridViewTextBoxColumn.Name = "PlazodepagoDataGridViewTextBoxColumn"
        '
        'ProveedoresTableBindingSource
        '
        Me.ProveedoresTableBindingSource.DataMember = "Proveedores_Table"
        Me.ProveedoresTableBindingSource.DataSource = Me.DelisCakeDatabaseDataSet
        '
        'DelisCakeDatabaseDataSet
        '
        Me.DelisCakeDatabaseDataSet.DataSetName = "DelisCakeDatabaseDataSet"
        Me.DelisCakeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Proveedores_TableTableAdapter
        '
        Me.Proveedores_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Materia_Prima_TableTableAdapter = Nothing
        Me.TableAdapterManager.Planilla_Empleados_TableTableAdapter = Nothing
        Me.TableAdapterManager.Productos_Terminados_TableTableAdapter = Nothing
        Me.TableAdapterManager.Proveedores_TableTableAdapter = Me.Proveedores_TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(567, 431)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(207, 22)
        Me.TextBox9.TabIndex = 64
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(567, 521)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(207, 22)
        Me.TextBox12.TabIndex = 65
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(567, 491)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(207, 22)
        Me.TextBox11.TabIndex = 66
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(567, 461)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(207, 22)
        Me.TextBox10.TabIndex = 67
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(202, 551)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(207, 22)
        Me.TextBox6.TabIndex = 68
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(202, 461)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(207, 22)
        Me.TextBox3.TabIndex = 69
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(567, 401)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(207, 22)
        Me.TextBox8.TabIndex = 70
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(202, 491)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(207, 22)
        Me.TextBox4.TabIndex = 71
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(202, 521)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(207, 22)
        Me.TextBox5.TabIndex = 72
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(202, 431)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 22)
        Me.TextBox2.TabIndex = 73
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(202, 584)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(207, 22)
        Me.TextBox7.TabIndex = 74
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(202, 401)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 22)
        Me.TextBox1.TabIndex = 75
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(567, 549)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(207, 22)
        Me.TextBox13.TabIndex = 65
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1094, 520)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 48)
        Me.Button5.TabIndex = 80
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(961, 519)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 48)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1157, 460)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 48)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1023, 460)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 48)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Louis George Cafe", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(888, 460)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 48)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(18, 606)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(91, 92)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 82
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(18, 14)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(184, 111)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 84
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Amsterdam", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 86)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Proveedores"
        '
        'proveedores_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 699)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox13)
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
        Me.Controls.Add(Id_ProveedorLabel)
        Me.Controls.Add(Razon_SocialLabel)
        Me.Controls.Add(Nombre_RepresentanteLabel)
        Me.Controls.Add(NIT_RepresentanteLabel)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Codigo_PostalLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Tipo_de_PagoLabel)
        Me.Controls.Add(Cuenta_BancariaLabel)
        Me.Controls.Add(Plazo_de_pagoLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Louis George Cafe", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "proveedores_form"
        Me.Text = "proveedores_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeDatabaseDataSet As DelisCakeDatabaseDataSet
    Friend WithEvents ProveedoresTableBindingSource As BindingSource
    Friend WithEvents Proveedores_TableTableAdapter As DelisCakeDatabaseDataSetTableAdapters.Proveedores_TableTableAdapter
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreRepresentanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NITRepresentanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipodePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuentaBancariaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlazodepagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DelisCakeDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
