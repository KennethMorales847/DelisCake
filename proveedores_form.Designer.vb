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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proveedores_form))
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
        Me.Delis_CakeDataSet = New DelisCake.Delis_CakeDataSet()
        Me.PRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRTableAdapter = New DelisCake.Delis_CakeDataSetTableAdapters.PRTableAdapter()
        Me.TableAdapterManager = New DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager()
        Me.PRBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PRBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        Me.PRDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRBindingNavigator.SuspendLayout()
        CType(Me.PRDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Delis_CakeDataSet
        '
        Me.Delis_CakeDataSet.DataSetName = "Delis_CakeDataSet"
        Me.Delis_CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRBindingSource
        '
        Me.PRBindingSource.DataMember = "PR"
        Me.PRBindingSource.DataSource = Me.Delis_CakeDataSet
        '
        'PRTableAdapter
        '
        Me.PRTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MPTableAdapter = Nothing
        Me.TableAdapterManager.PlanillaTableAdapter = Nothing
        Me.TableAdapterManager.Productos_TerminadosTableAdapter = Nothing
        Me.TableAdapterManager.PRTableAdapter = Me.PRTableAdapter
        Me.TableAdapterManager.UpdateOrder = DelisCake.Delis_CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PRBindingNavigator
        '
        Me.PRBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PRBindingNavigator.BindingSource = Me.PRBindingSource
        Me.PRBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PRBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PRBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PRBindingNavigatorSaveItem})
        Me.PRBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PRBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PRBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PRBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PRBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PRBindingNavigator.Name = "PRBindingNavigator"
        Me.PRBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PRBindingNavigator.Size = New System.Drawing.Size(1042, 25)
        Me.PRBindingNavigator.TabIndex = 0
        Me.PRBindingNavigator.Text = "BindingNavigator1"
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
        'PRBindingNavigatorSaveItem
        '
        Me.PRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRBindingNavigatorSaveItem.Image = CType(resources.GetObject("PRBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRBindingNavigatorSaveItem.Name = "PRBindingNavigatorSaveItem"
        Me.PRBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PRBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(797, 33)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(71, 13)
        Id_ProveedorLabel.TabIndex = 1
        Id_ProveedorLabel.Text = "Id Proveedor:"
        '
        'Id_ProveedorTextBox
        '
        Me.Id_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Id_Proveedor", True))
        Me.Id_ProveedorTextBox.Location = New System.Drawing.Point(923, 30)
        Me.Id_ProveedorTextBox.Name = "Id_ProveedorTextBox"
        Me.Id_ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_ProveedorTextBox.TabIndex = 2
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.Location = New System.Drawing.Point(797, 59)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(73, 13)
        Razon_SocialLabel.TabIndex = 3
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'Razon_SocialTextBox
        '
        Me.Razon_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Razon_Social", True))
        Me.Razon_SocialTextBox.Location = New System.Drawing.Point(923, 56)
        Me.Razon_SocialTextBox.Name = "Razon_SocialTextBox"
        Me.Razon_SocialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Razon_SocialTextBox.TabIndex = 4
        '
        'Nombre_RepresentanteLabel
        '
        Nombre_RepresentanteLabel.AutoSize = True
        Nombre_RepresentanteLabel.Location = New System.Drawing.Point(797, 85)
        Nombre_RepresentanteLabel.Name = "Nombre_RepresentanteLabel"
        Nombre_RepresentanteLabel.Size = New System.Drawing.Size(120, 13)
        Nombre_RepresentanteLabel.TabIndex = 5
        Nombre_RepresentanteLabel.Text = "Nombre Representante:"
        '
        'Nombre_RepresentanteTextBox
        '
        Me.Nombre_RepresentanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Nombre_Representante", True))
        Me.Nombre_RepresentanteTextBox.Location = New System.Drawing.Point(923, 82)
        Me.Nombre_RepresentanteTextBox.Name = "Nombre_RepresentanteTextBox"
        Me.Nombre_RepresentanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_RepresentanteTextBox.TabIndex = 6
        '
        'NIT_RepresentanteLabel
        '
        NIT_RepresentanteLabel.AutoSize = True
        NIT_RepresentanteLabel.Location = New System.Drawing.Point(797, 111)
        NIT_RepresentanteLabel.Name = "NIT_RepresentanteLabel"
        NIT_RepresentanteLabel.Size = New System.Drawing.Size(101, 13)
        NIT_RepresentanteLabel.TabIndex = 7
        NIT_RepresentanteLabel.Text = "NIT Representante:"
        '
        'NIT_RepresentanteTextBox
        '
        Me.NIT_RepresentanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "NIT_Representante", True))
        Me.NIT_RepresentanteTextBox.Location = New System.Drawing.Point(923, 108)
        Me.NIT_RepresentanteTextBox.Name = "NIT_RepresentanteTextBox"
        Me.NIT_RepresentanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIT_RepresentanteTextBox.TabIndex = 8
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(797, 137)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 9
        PaisLabel.Text = "Pais:"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(923, 134)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 10
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(797, 163)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 11
        CiudadLabel.Text = "Ciudad:"
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(923, 160)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CiudadTextBox.TabIndex = 12
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(797, 189)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 13
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(923, 186)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 14
        '
        'Codigo_PostalLabel
        '
        Codigo_PostalLabel.AutoSize = True
        Codigo_PostalLabel.Location = New System.Drawing.Point(797, 215)
        Codigo_PostalLabel.Name = "Codigo_PostalLabel"
        Codigo_PostalLabel.Size = New System.Drawing.Size(75, 13)
        Codigo_PostalLabel.TabIndex = 15
        Codigo_PostalLabel.Text = "Codigo Postal:"
        '
        'Codigo_PostalTextBox
        '
        Me.Codigo_PostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Codigo_Postal", True))
        Me.Codigo_PostalTextBox.Location = New System.Drawing.Point(923, 212)
        Me.Codigo_PostalTextBox.Name = "Codigo_PostalTextBox"
        Me.Codigo_PostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Codigo_PostalTextBox.TabIndex = 16
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(797, 241)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 17
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(923, 238)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 18
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(797, 267)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(923, 264)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 20
        '
        'Tipo_de_PagoLabel
        '
        Tipo_de_PagoLabel.AutoSize = True
        Tipo_de_PagoLabel.Location = New System.Drawing.Point(797, 293)
        Tipo_de_PagoLabel.Name = "Tipo_de_PagoLabel"
        Tipo_de_PagoLabel.Size = New System.Drawing.Size(74, 13)
        Tipo_de_PagoLabel.TabIndex = 21
        Tipo_de_PagoLabel.Text = "Tipo de Pago:"
        '
        'Tipo_de_PagoTextBox
        '
        Me.Tipo_de_PagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Tipo_de_Pago", True))
        Me.Tipo_de_PagoTextBox.Location = New System.Drawing.Point(923, 290)
        Me.Tipo_de_PagoTextBox.Name = "Tipo_de_PagoTextBox"
        Me.Tipo_de_PagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tipo_de_PagoTextBox.TabIndex = 22
        '
        'Cuenta_BancariaLabel
        '
        Cuenta_BancariaLabel.AutoSize = True
        Cuenta_BancariaLabel.Location = New System.Drawing.Point(797, 319)
        Cuenta_BancariaLabel.Name = "Cuenta_BancariaLabel"
        Cuenta_BancariaLabel.Size = New System.Drawing.Size(89, 13)
        Cuenta_BancariaLabel.TabIndex = 23
        Cuenta_BancariaLabel.Text = "Cuenta Bancaria:"
        '
        'Cuenta_BancariaTextBox
        '
        Me.Cuenta_BancariaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Cuenta_Bancaria", True))
        Me.Cuenta_BancariaTextBox.Location = New System.Drawing.Point(923, 316)
        Me.Cuenta_BancariaTextBox.Name = "Cuenta_BancariaTextBox"
        Me.Cuenta_BancariaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cuenta_BancariaTextBox.TabIndex = 24
        '
        'Plazo_de_pagoLabel
        '
        Plazo_de_pagoLabel.AutoSize = True
        Plazo_de_pagoLabel.Location = New System.Drawing.Point(797, 345)
        Plazo_de_pagoLabel.Name = "Plazo_de_pagoLabel"
        Plazo_de_pagoLabel.Size = New System.Drawing.Size(78, 13)
        Plazo_de_pagoLabel.TabIndex = 25
        Plazo_de_pagoLabel.Text = "Plazo de pago:"
        '
        'Plazo_de_pagoTextBox
        '
        Me.Plazo_de_pagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRBindingSource, "Plazo_de_pago", True))
        Me.Plazo_de_pagoTextBox.Location = New System.Drawing.Point(923, 342)
        Me.Plazo_de_pagoTextBox.Name = "Plazo_de_pagoTextBox"
        Me.Plazo_de_pagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plazo_de_pagoTextBox.TabIndex = 26
        '
        'PRDataGridView
        '
        Me.PRDataGridView.AutoGenerateColumns = False
        Me.PRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.PRDataGridView.DataSource = Me.PRBindingSource
        Me.PRDataGridView.Location = New System.Drawing.Point(0, 33)
        Me.PRDataGridView.Name = "PRDataGridView"
        Me.PRDataGridView.Size = New System.Drawing.Size(781, 332)
        Me.PRDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Razon_Social"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razon_Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre_Representante"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre_Representante"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NIT_Representante"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NIT_Representante"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pais"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pais"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Codigo_Postal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Codigo_Postal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Tipo_de_Pago"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tipo_de_Pago"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Cuenta_Bancaria"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cuenta_Bancaria"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Plazo_de_pago"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Plazo_de_pago"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'proveedores_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 403)
        Me.Controls.Add(Me.PRDataGridView)
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
        Me.Controls.Add(Me.PRBindingNavigator)
        Me.Name = "proveedores_form"
        Me.Text = "proveedores_form"
        CType(Me.Delis_CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRBindingNavigator.ResumeLayout(False)
        Me.PRBindingNavigator.PerformLayout()
        CType(Me.PRDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Delis_CakeDataSet As Delis_CakeDataSet
    Friend WithEvents PRBindingSource As BindingSource
    Friend WithEvents PRTableAdapter As Delis_CakeDataSetTableAdapters.PRTableAdapter
    Friend WithEvents TableAdapterManager As Delis_CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRBindingNavigator As BindingNavigator
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
    Friend WithEvents PRBindingNavigatorSaveItem As ToolStripButton
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
    Friend WithEvents PRDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
