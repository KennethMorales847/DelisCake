<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciarSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniciarSesion))
        Me.btn_registrarse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_iniciarSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_registrarse
        '
        Me.btn_registrarse.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_registrarse.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarse.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_registrarse.Location = New System.Drawing.Point(300, 192)
        Me.btn_registrarse.Name = "btn_registrarse"
        Me.btn_registrarse.Size = New System.Drawing.Size(204, 94)
        Me.btn_registrarse.TabIndex = 1
        Me.btn_registrarse.Text = "Registrarse"
        Me.btn_registrarse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "B I E N V E N I D O S"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione una opción:"
        '
        'btn_iniciarSesion
        '
        Me.btn_iniciarSesion.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_iniciarSesion.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciarSesion.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_iniciarSesion.Location = New System.Drawing.Point(47, 192)
        Me.btn_iniciarSesion.Name = "btn_iniciarSesion"
        Me.btn_iniciarSesion.Size = New System.Drawing.Size(204, 94)
        Me.btn_iniciarSesion.TabIndex = 4
        Me.btn_iniciarSesion.Text = "Iniciar Sesión"
        Me.btn_iniciarSesion.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(551, 450)
        Me.Controls.Add(Me.btn_iniciarSesion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_registrarse)
        Me.Font = New System.Drawing.Font("Bauhaus 93", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_registrarse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_iniciarSesion As Button
End Class
