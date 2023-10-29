<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitacoraUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BitacoraUsuarios))
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.DataGridViewAdministradores = New System.Windows.Forms.DataGridView()
        Me.L_Usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAdministradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(38, 108)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(311, 177)
        Me.DataGridViewUsuarios.TabIndex = 0
        '
        'DataGridViewAdministradores
        '
        Me.DataGridViewAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAdministradores.Location = New System.Drawing.Point(375, 108)
        Me.DataGridViewAdministradores.Name = "DataGridViewAdministradores"
        Me.DataGridViewAdministradores.Size = New System.Drawing.Size(311, 177)
        Me.DataGridViewAdministradores.TabIndex = 1
        '
        'L_Usuario
        '
        Me.L_Usuario.AutoSize = True
        Me.L_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.L_Usuario.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Usuario.Location = New System.Drawing.Point(148, 83)
        Me.L_Usuario.Name = "L_Usuario"
        Me.L_Usuario.Size = New System.Drawing.Size(99, 22)
        Me.L_Usuario.TabIndex = 16
        Me.L_Usuario.Text = "Usuarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 22)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Administradores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 33)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Gestion de Usuarios"
        '
        'BitacoraUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BackgroundImage = Global.DelisCake.My.Resources.Resources.FondoGestion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_Usuario)
        Me.Controls.Add(Me.DataGridViewAdministradores)
        Me.Controls.Add(Me.DataGridViewUsuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BitacoraUsuarios"
        Me.Text = "Gestión de Usuarios"
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewAdministradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewUsuarios As DataGridView
    Friend WithEvents DataGridViewAdministradores As DataGridView
    Friend WithEvents L_Usuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
