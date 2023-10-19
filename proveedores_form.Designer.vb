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
        Me.DelisCakeSet2 = New DelisCake.DelisCakeSet2()
        Me.PRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRTableAdapter = New DelisCake.DelisCakeSet2TableAdapters.PRTableAdapter()
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
        Me.TableAdapterManager = New DelisCake.DelisCakeSet2TableAdapters.TableAdapterManager()
        Me.Id_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Razon_SocialTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_RepresentanteTextBox = New System.Windows.Forms.TextBox()
        Me.NIT_RepresentanteTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Codigo_PostalTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_PagoTextBox = New System.Windows.Forms.TextBox()
        Me.Cuenta_BancariaTextBox = New System.Windows.Forms.TextBox()
        Me.Plazo_de_pagoTextBox = New System.Windows.Forms.TextBox()
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
        CType(Me.DelisCakeSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.NombreRepresentanteDataGridViewTextBoxColumn, Me.NITRepresentanteDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TipodePagoDataGridViewTextBoxColumn, Me.CuentaBancariaDataGridViewTextBoxColumn, Me.PlazodepagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PRBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(765, 188)
        Me.DataGridView1.TabIndex = 0
        '
        'DelisCakeSet2
        '
        Me.DelisCakeSet2.DataSetName = "DelisCakeSet2"
        Me.DelisCakeSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRBindingSource
        '
        Me.PRBindingSource.DataMember = "PR"
        Me.PRBindingSource.DataSource = Me.DelisCakeSet2
        '
        'PRTableAdapter
        '
        Me.PRTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PRTableAdapter = Me.PRTableAdapter
        Me.TableAdapterManager.UpdateOrder = DelisCake.DelisCakeSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(802, 13)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(71, 13)
        Id_ProveedorLabel.TabIndex = 1
        Id_ProveedorLabel.Text = "Id Proveedor:"
        '
        'Id_ProveedorTextBox
        '
        Me.Id_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Id_Proveedor", True))
        Me.Id_ProveedorTextBox.Location = New System.Drawing.Point(928, 10)
        Me.Id_ProveedorTextBox.Name = "Id_ProveedorTextBox"
        Me.Id_ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_ProveedorTextBox.TabIndex = 2
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.Location = New System.Drawing.Point(802, 39)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(73, 13)
        Razon_SocialLabel.TabIndex = 3
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'Razon_SocialTextBox
        '
        Me.Razon_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Razon_Social", True))
        Me.Razon_SocialTextBox.Location = New System.Drawing.Point(928, 36)
        Me.Razon_SocialTextBox.Name = "Razon_SocialTextBox"
        Me.Razon_SocialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Razon_SocialTextBox.TabIndex = 4
        '
        'Nombre_RepresentanteLabel
        '
        Nombre_RepresentanteLabel.AutoSize = True
        Nombre_RepresentanteLabel.Location = New System.Drawing.Point(802, 65)
        Nombre_RepresentanteLabel.Name = "Nombre_RepresentanteLabel"
        Nombre_RepresentanteLabel.Size = New System.Drawing.Size(120, 13)
        Nombre_RepresentanteLabel.TabIndex = 5
        Nombre_RepresentanteLabel.Text = "Nombre Representante:"
        '
        'Nombre_RepresentanteTextBox
        '
        Me.Nombre_RepresentanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Nombre_Representante", True))
        Me.Nombre_RepresentanteTextBox.Location = New System.Drawing.Point(928, 62)
        Me.Nombre_RepresentanteTextBox.Name = "Nombre_RepresentanteTextBox"
        Me.Nombre_RepresentanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_RepresentanteTextBox.TabIndex = 6
        '
        'NIT_RepresentanteLabel
        '
        NIT_RepresentanteLabel.AutoSize = True
        NIT_RepresentanteLabel.Location = New System.Drawing.Point(802, 91)
        NIT_RepresentanteLabel.Name = "NIT_RepresentanteLabel"
        NIT_RepresentanteLabel.Size = New System.Drawing.Size(101, 13)
        NIT_RepresentanteLabel.TabIndex = 7
        NIT_RepresentanteLabel.Text = "NIT Representante:"
        '
        'NIT_RepresentanteTextBox
        '
        Me.NIT_RepresentanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "NIT_Representante", True))
        Me.NIT_RepresentanteTextBox.Location = New System.Drawing.Point(928, 88)
        Me.NIT_RepresentanteTextBox.Name = "NIT_RepresentanteTextBox"
        Me.NIT_RepresentanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIT_RepresentanteTextBox.TabIndex = 8
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(802, 117)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 9
        PaisLabel.Text = "Pais:"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(928, 114)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 10
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(802, 143)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 11
        CiudadLabel.Text = "Ciudad:"
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(928, 140)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CiudadTextBox.TabIndex = 12
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(802, 169)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 13
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(928, 166)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 14
        '
        'Codigo_PostalLabel
        '
        Codigo_PostalLabel.AutoSize = True
        Codigo_PostalLabel.Location = New System.Drawing.Point(802, 195)
        Codigo_PostalLabel.Name = "Codigo_PostalLabel"
        Codigo_PostalLabel.Size = New System.Drawing.Size(75, 13)
        Codigo_PostalLabel.TabIndex = 15
        Codigo_PostalLabel.Text = "Codigo Postal:"
        '
        'Codigo_PostalTextBox
        '
        Me.Codigo_PostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Codigo_Postal", True))
        Me.Codigo_PostalTextBox.Location = New System.Drawing.Point(928, 192)
        Me.Codigo_PostalTextBox.Name = "Codigo_PostalTextBox"
        Me.Codigo_PostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Codigo_PostalTextBox.TabIndex = 16
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(802, 221)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 17
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(928, 218)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 18
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(802, 247)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(928, 244)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 20
        '
        'Tipo_de_PagoLabel
        '
        Tipo_de_PagoLabel.AutoSize = True
        Tipo_de_PagoLabel.Location = New System.Drawing.Point(802, 273)
        Tipo_de_PagoLabel.Name = "Tipo_de_PagoLabel"
        Tipo_de_PagoLabel.Size = New System.Drawing.Size(74, 13)
        Tipo_de_PagoLabel.TabIndex = 21
        Tipo_de_PagoLabel.Text = "Tipo de Pago:"
        '
        'Tipo_de_PagoTextBox
        '
        Me.Tipo_de_PagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Tipo_de_Pago", True))
        Me.Tipo_de_PagoTextBox.Location = New System.Drawing.Point(928, 270)
        Me.Tipo_de_PagoTextBox.Name = "Tipo_de_PagoTextBox"
        Me.Tipo_de_PagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tipo_de_PagoTextBox.TabIndex = 22
        '
        'Cuenta_BancariaLabel
        '
        Cuenta_BancariaLabel.AutoSize = True
        Cuenta_BancariaLabel.Location = New System.Drawing.Point(802, 299)
        Cuenta_BancariaLabel.Name = "Cuenta_BancariaLabel"
        Cuenta_BancariaLabel.Size = New System.Drawing.Size(89, 13)
        Cuenta_BancariaLabel.TabIndex = 23
        Cuenta_BancariaLabel.Text = "Cuenta Bancaria:"
        '
        'Cuenta_BancariaTextBox
        '
        Me.Cuenta_BancariaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Cuenta_Bancaria", True))
        Me.Cuenta_BancariaTextBox.Location = New System.Drawing.Point(928, 296)
        Me.Cuenta_BancariaTextBox.Name = "Cuenta_BancariaTextBox"
        Me.Cuenta_BancariaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cuenta_BancariaTextBox.TabIndex = 24
        '
        'Plazo_de_pagoLabel
        '
        Plazo_de_pagoLabel.AutoSize = True
        Plazo_de_pagoLabel.Location = New System.Drawing.Point(802, 325)
        Plazo_de_pagoLabel.Name = "Plazo_de_pagoLabel"
        Plazo_de_pagoLabel.Size = New System.Drawing.Size(78, 13)
        Plazo_de_pagoLabel.TabIndex = 25
        Plazo_de_pagoLabel.Text = "Plazo de pago:"
        '
        'Plazo_de_pagoTextBox
        '
        Me.Plazo_de_pagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Plazo_de_pago", True))
        Me.Plazo_de_pagoTextBox.Location = New System.Drawing.Point(928, 322)
        Me.Plazo_de_pagoTextBox.Name = "Plazo_de_pagoTextBox"
        Me.Plazo_de_pagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plazo_de_pagoTextBox.TabIndex = 26
        '
        'proveedores_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 381)
        Me.Controls.Add(Id_ProveedorLabel)
        Me.Controls.Add(Me.Id_ProveedorTextBox)
        Me.Controls.Add(Razon_SocialLabel)
        Me.Controls.Add(Me.Razon_SocialTextBox)
        Me.Controls.Add(Nombre_RepresentanteLabel)
        Me.Controls.Add(Me.Nombre_RepresentanteTextBox)
        Me.Controls.Add(NIT_RepresentanteLabel)
        Me.Controls.Add(Me.NIT_RepresentanteTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Codigo_PostalLabel)
        Me.Controls.Add(Me.Codigo_PostalTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Tipo_de_PagoLabel)
        Me.Controls.Add(Me.Tipo_de_PagoTextBox)
        Me.Controls.Add(Cuenta_BancariaLabel)
        Me.Controls.Add(Me.Cuenta_BancariaTextBox)
        Me.Controls.Add(Plazo_de_pagoLabel)
        Me.Controls.Add(Me.Plazo_de_pagoTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "proveedores_form"
        Me.Text = "proveedores_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelisCakeSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DelisCakeSet2 As DelisCakeSet2
    Friend WithEvents PRBindingSource As BindingSource
    Friend WithEvents PRTableAdapter As DelisCakeSet2TableAdapters.PRTableAdapter
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
    Friend WithEvents TableAdapterManager As DelisCakeSet2TableAdapters.TableAdapterManager
    Friend WithEvents Id_ProveedorTextBox As TextBox
    Friend WithEvents Razon_SocialTextBox As TextBox
    Friend WithEvents Nombre_RepresentanteTextBox As TextBox
    Friend WithEvents NIT_RepresentanteTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents Codigo_PostalTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Tipo_de_PagoTextBox As TextBox
    Friend WithEvents Cuenta_BancariaTextBox As TextBox
    Friend WithEvents Plazo_de_pagoTextBox As TextBox
End Class
