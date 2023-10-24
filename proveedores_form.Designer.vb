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
        Me.SuspendLayout()
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(12, 274)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(71, 13)
        Id_ProveedorLabel.TabIndex = 1
        Id_ProveedorLabel.Text = "Id Proveedor:"
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.Location = New System.Drawing.Point(12, 300)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(73, 13)
        Razon_SocialLabel.TabIndex = 3
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'Nombre_RepresentanteLabel
        '
        Nombre_RepresentanteLabel.AutoSize = True
        Nombre_RepresentanteLabel.Location = New System.Drawing.Point(12, 326)
        Nombre_RepresentanteLabel.Name = "Nombre_RepresentanteLabel"
        Nombre_RepresentanteLabel.Size = New System.Drawing.Size(120, 13)
        Nombre_RepresentanteLabel.TabIndex = 5
        Nombre_RepresentanteLabel.Text = "Nombre Representante:"
        '
        'NIT_RepresentanteLabel
        '
        NIT_RepresentanteLabel.AutoSize = True
        NIT_RepresentanteLabel.Location = New System.Drawing.Point(12, 352)
        NIT_RepresentanteLabel.Name = "NIT_RepresentanteLabel"
        NIT_RepresentanteLabel.Size = New System.Drawing.Size(101, 13)
        NIT_RepresentanteLabel.TabIndex = 7
        NIT_RepresentanteLabel.Text = "NIT Representante:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(12, 378)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 9
        PaisLabel.Text = "Pais:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(12, 404)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 11
        CiudadLabel.Text = "Ciudad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(12, 430)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 13
        DireccionLabel.Text = "Direccion:"
        '
        'Codigo_PostalLabel
        '
        Codigo_PostalLabel.AutoSize = True
        Codigo_PostalLabel.Location = New System.Drawing.Point(12, 456)
        Codigo_PostalLabel.Name = "Codigo_PostalLabel"
        Codigo_PostalLabel.Size = New System.Drawing.Size(75, 13)
        Codigo_PostalLabel.TabIndex = 15
        Codigo_PostalLabel.Text = "Codigo Postal:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(12, 482)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 17
        TelefonoLabel.Text = "Telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 508)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'Tipo_de_PagoLabel
        '
        Tipo_de_PagoLabel.AutoSize = True
        Tipo_de_PagoLabel.Location = New System.Drawing.Point(12, 534)
        Tipo_de_PagoLabel.Name = "Tipo_de_PagoLabel"
        Tipo_de_PagoLabel.Size = New System.Drawing.Size(74, 13)
        Tipo_de_PagoLabel.TabIndex = 21
        Tipo_de_PagoLabel.Text = "Tipo de Pago:"
        '
        'Cuenta_BancariaLabel
        '
        Cuenta_BancariaLabel.AutoSize = True
        Cuenta_BancariaLabel.Location = New System.Drawing.Point(12, 560)
        Cuenta_BancariaLabel.Name = "Cuenta_BancariaLabel"
        Cuenta_BancariaLabel.Size = New System.Drawing.Size(89, 13)
        Cuenta_BancariaLabel.TabIndex = 23
        Cuenta_BancariaLabel.Text = "Cuenta Bancaria:"
        '
        'Plazo_de_pagoLabel
        '
        Plazo_de_pagoLabel.AutoSize = True
        Plazo_de_pagoLabel.Location = New System.Drawing.Point(12, 586)
        Plazo_de_pagoLabel.Name = "Plazo_de_pagoLabel"
        Plazo_de_pagoLabel.Size = New System.Drawing.Size(78, 13)
        Plazo_de_pagoLabel.TabIndex = 25
        Plazo_de_pagoLabel.Text = "Plazo de pago:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.NombreRepresentanteDataGridViewTextBoxColumn, Me.NITRepresentanteDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TipodePagoDataGridViewTextBoxColumn, Me.CuentaBancariaDataGridViewTextBoxColumn, Me.PlazodepagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProveedoresTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1349, 252)
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
        Me.TextBox9.Location = New System.Drawing.Point(130, 482)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(178, 20)
        Me.TextBox9.TabIndex = 64
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(130, 560)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(178, 20)
        Me.TextBox12.TabIndex = 65
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(130, 534)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(178, 20)
        Me.TextBox11.TabIndex = 66
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(130, 508)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(178, 20)
        Me.TextBox10.TabIndex = 67
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(130, 401)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(178, 20)
        Me.TextBox6.TabIndex = 68
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(130, 323)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(178, 20)
        Me.TextBox3.TabIndex = 69
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(130, 456)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(178, 20)
        Me.TextBox8.TabIndex = 70
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(130, 349)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(178, 20)
        Me.TextBox4.TabIndex = 71
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(130, 375)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(178, 20)
        Me.TextBox5.TabIndex = 72
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(130, 297)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 73
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(130, 430)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(178, 20)
        Me.TextBox7.TabIndex = 74
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 271)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 75
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(130, 585)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(178, 20)
        Me.TextBox13.TabIndex = 65
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(494, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 80
        Me.Button5.Text = "&Mostrar Todo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(413, 314)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "&Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(533, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(452, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "&Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(371, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'proveedores_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 618)
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
        Me.Name = "proveedores_form"
        Me.Text = "proveedores_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
