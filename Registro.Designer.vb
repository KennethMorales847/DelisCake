﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.L_Usuario = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.L_Contraseña = New System.Windows.Forms.Label()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.CheckBox_Usuario = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Admin = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L_Usuario
        '
        Me.L_Usuario.AutoSize = True
        Me.L_Usuario.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Usuario.Location = New System.Drawing.Point(68, 151)
        Me.L_Usuario.Name = "L_Usuario"
        Me.L_Usuario.Size = New System.Drawing.Size(211, 17)
        Me.L_Usuario.TabIndex = 1
        Me.L_Usuario.Text = "Ingrese nombre de usuario"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(72, 173)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(267, 20)
        Me.TextBox_Nombre.TabIndex = 2
        '
        'L_Contraseña
        '
        Me.L_Contraseña.AutoSize = True
        Me.L_Contraseña.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Contraseña.Location = New System.Drawing.Point(68, 225)
        Me.L_Contraseña.Name = "L_Contraseña"
        Me.L_Contraseña.Size = New System.Drawing.Size(188, 17)
        Me.L_Contraseña.TabIndex = 3
        Me.L_Contraseña.Text = "Ingrese una contraseña"
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(72, 247)
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(267, 20)
        Me.TextBox_Contraseña.TabIndex = 4
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.Sienna
        Me.btn_registrar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_registrar.Location = New System.Drawing.Point(189, 302)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(111, 40)
        Me.btn_registrar.TabIndex = 6
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.Sienna
        Me.btn_limpiar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_limpiar.Location = New System.Drawing.Point(50, 302)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(112, 40)
        Me.btn_limpiar.TabIndex = 7
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'CheckBox_Usuario
        '
        Me.CheckBox_Usuario.AutoSize = True
        Me.CheckBox_Usuario.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Usuario.ForeColor = System.Drawing.Color.Sienna
        Me.CheckBox_Usuario.Location = New System.Drawing.Point(66, 107)
        Me.CheckBox_Usuario.Name = "CheckBox_Usuario"
        Me.CheckBox_Usuario.Size = New System.Drawing.Size(77, 19)
        Me.CheckBox_Usuario.TabIndex = 10
        Me.CheckBox_Usuario.Text = "Usuario"
        Me.CheckBox_Usuario.UseVisualStyleBackColor = True
        '
        'CheckBox_Admin
        '
        Me.CheckBox_Admin.AutoSize = True
        Me.CheckBox_Admin.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Admin.ForeColor = System.Drawing.Color.Sienna
        Me.CheckBox_Admin.Location = New System.Drawing.Point(189, 107)
        Me.CheckBox_Admin.Name = "CheckBox_Admin"
        Me.CheckBox_Admin.Size = New System.Drawing.Size(124, 19)
        Me.CheckBox_Admin.TabIndex = 11
        Me.CheckBox_Admin.Text = "Administrador"
        Me.CheckBox_Admin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Seleccione el Tipo de Usuario:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DelisCake.My.Resources.Resources.Pass
        Me.PictureBox3.Location = New System.Drawing.Point(23, 228)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.Registrar
        Me.PictureBox2.Location = New System.Drawing.Point(23, 142)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 33)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Registro de Usuarios"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(365, 388)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox_Admin)
        Me.Controls.Add(Me.CheckBox_Usuario)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.L_Contraseña)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.L_Usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L_Usuario As Label
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents L_Contraseña As Label
    Friend WithEvents TextBox_Contraseña As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents btn_registrar As Button
    Public WithEvents btn_limpiar As Button
    Friend WithEvents CheckBox_Usuario As CheckBox
    Friend WithEvents CheckBox_Admin As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
