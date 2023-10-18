<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.L_Registro = New System.Windows.Forms.Label()
        Me.L_Usuario = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.L_Contraseña = New System.Windows.Forms.Label()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L_Registro
        '
        Me.L_Registro.AutoSize = True
        Me.L_Registro.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Registro.Location = New System.Drawing.Point(134, 9)
        Me.L_Registro.Name = "L_Registro"
        Me.L_Registro.Size = New System.Drawing.Size(106, 28)
        Me.L_Registro.TabIndex = 0
        Me.L_Registro.Text = "Registro"
        '
        'L_Usuario
        '
        Me.L_Usuario.AutoSize = True
        Me.L_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Usuario.Location = New System.Drawing.Point(48, 88)
        Me.L_Usuario.Name = "L_Usuario"
        Me.L_Usuario.Size = New System.Drawing.Size(209, 18)
        Me.L_Usuario.TabIndex = 1
        Me.L_Usuario.Text = "Ingrese nombre de usuario"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(52, 110)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(301, 20)
        Me.TextBox_Nombre.TabIndex = 2
        '
        'L_Contraseña
        '
        Me.L_Contraseña.AutoSize = True
        Me.L_Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Contraseña.Location = New System.Drawing.Point(48, 162)
        Me.L_Contraseña.Name = "L_Contraseña"
        Me.L_Contraseña.Size = New System.Drawing.Size(184, 18)
        Me.L_Contraseña.TabIndex = 3
        Me.L_Contraseña.Text = "Ingrese una contraseña"
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(52, 184)
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(301, 20)
        Me.TextBox_Contraseña.TabIndex = 4
        '
        'btn_registrar
        '
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.Location = New System.Drawing.Point(207, 248)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(103, 27)
        Me.btn_registrar.TabIndex = 6
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(65, 248)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(103, 27)
        Me.btn_limpiar.TabIndex = 7
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DelisCake.My.Resources.Resources.Pass
        Me.PictureBox3.Location = New System.Drawing.Point(3, 165)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.Registrar
        Me.PictureBox2.Location = New System.Drawing.Point(3, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(365, 321)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.L_Contraseña)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.L_Usuario)
        Me.Controls.Add(Me.L_Registro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Registro As Label
    Friend WithEvents L_Usuario As Label
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents L_Contraseña As Label
    Friend WithEvents TextBox_Contraseña As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents btn_registrar As Button
    Public WithEvents btn_limpiar As Button
End Class
