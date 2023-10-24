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
        Me.L_Registro = New System.Windows.Forms.Label()
        Me.L_Usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAdministradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(38, 108)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(315, 212)
        Me.DataGridViewUsuarios.TabIndex = 0
        '
        'DataGridViewAdministradores
        '
        Me.DataGridViewAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAdministradores.Location = New System.Drawing.Point(446, 108)
        Me.DataGridViewAdministradores.Name = "DataGridViewAdministradores"
        Me.DataGridViewAdministradores.Size = New System.Drawing.Size(315, 212)
        Me.DataGridViewAdministradores.TabIndex = 1
        '
        'L_Registro
        '
        Me.L_Registro.AutoSize = True
        Me.L_Registro.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Registro.Location = New System.Drawing.Point(285, 18)
        Me.L_Registro.Name = "L_Registro"
        Me.L_Registro.Size = New System.Drawing.Size(235, 28)
        Me.L_Registro.TabIndex = 15
        Me.L_Registro.Text = "Gestión de Usuarios"
        '
        'L_Usuario
        '
        Me.L_Usuario.AutoSize = True
        Me.L_Usuario.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Usuario.Location = New System.Drawing.Point(147, 87)
        Me.L_Usuario.Name = "L_Usuario"
        Me.L_Usuario.Size = New System.Drawing.Size(74, 17)
        Me.L_Usuario.TabIndex = 16
        Me.L_Usuario.Text = "Usuarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(545, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Administradores"
        '
        'BitacoraUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_Usuario)
        Me.Controls.Add(Me.L_Registro)
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
    Friend WithEvents L_Registro As Label
    Friend WithEvents L_Usuario As Label
    Friend WithEvents Label1 As Label
End Class
