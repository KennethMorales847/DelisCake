<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjustesUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjustesUsuario))
        Me.btn_vitacora = New System.Windows.Forms.Button()
        Me.btn_restablecer = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.L_Registro = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_vitacora
        '
        Me.btn_vitacora.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vitacora.Location = New System.Drawing.Point(112, 107)
        Me.btn_vitacora.Name = "btn_vitacora"
        Me.btn_vitacora.Size = New System.Drawing.Size(232, 61)
        Me.btn_vitacora.TabIndex = 0
        Me.btn_vitacora.Text = "Vitacora de Usuarios"
        Me.btn_vitacora.UseVisualStyleBackColor = True
        '
        'btn_restablecer
        '
        Me.btn_restablecer.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restablecer.Location = New System.Drawing.Point(112, 190)
        Me.btn_restablecer.Name = "btn_restablecer"
        Me.btn_restablecer.Size = New System.Drawing.Size(232, 61)
        Me.btn_restablecer.TabIndex = 2
        Me.btn_restablecer.Text = "Restablecer Contraseña"
        Me.btn_restablecer.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(112, 273)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(232, 61)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar Usuarios"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(112, 356)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(232, 61)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "Agregar Nuevo Usuario"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'L_Registro
        '
        Me.L_Registro.AutoSize = True
        Me.L_Registro.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Registro.Location = New System.Drawing.Point(89, 31)
        Me.L_Registro.Name = "L_Registro"
        Me.L_Registro.Size = New System.Drawing.Size(222, 28)
        Me.L_Registro.TabIndex = 14
        Me.L_Registro.Text = "Ajustes de Usuario"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DelisCake.My.Resources.Resources.Registrar
        Me.PictureBox4.Location = New System.Drawing.Point(40, 356)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(66, 61)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DelisCake.My.Resources.Resources.Eliminar
        Me.PictureBox3.Location = New System.Drawing.Point(40, 273)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 61)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.Cambiar_Usuario
        Me.PictureBox2.Location = New System.Drawing.Point(40, 190)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DelisCake.My.Resources.Resources.Vitacora
        Me.PictureBox1.Location = New System.Drawing.Point(40, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'AjustesUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 450)
        Me.Controls.Add(Me.L_Registro)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_restablecer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_vitacora)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AjustesUsuario"
        Me.Text = "Ajustes de Usuario"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_vitacora As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_restablecer As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents L_Registro As Label
End Class
