﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestablecerContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestablecerContraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox_Admin = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.L_Contraseña = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.L_Usuario = New System.Windows.Forms.Label()
        Me.BT_limpiar = New System.Windows.Forms.Button()
        Me.BT_confirmar = New System.Windows.Forms.Button()
        Me.CheckBox_Usuario = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Seleccione el Tipo de Usuario:"
        '
        'CheckBox_Admin
        '
        Me.CheckBox_Admin.AutoSize = True
        Me.CheckBox_Admin.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Admin.ForeColor = System.Drawing.Color.Sienna
        Me.CheckBox_Admin.Location = New System.Drawing.Point(193, 93)
        Me.CheckBox_Admin.Name = "CheckBox_Admin"
        Me.CheckBox_Admin.Size = New System.Drawing.Size(124, 19)
        Me.CheckBox_Admin.TabIndex = 32
        Me.CheckBox_Admin.Text = "Administrador"
        Me.CheckBox_Admin.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DelisCake.My.Resources.Resources.Pass
        Me.PictureBox3.Location = New System.Drawing.Point(27, 214)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.Cambiar_Usuario
        Me.PictureBox2.Location = New System.Drawing.Point(27, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(76, 233)
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(267, 20)
        Me.TextBox_Contraseña.TabIndex = 28
        '
        'L_Contraseña
        '
        Me.L_Contraseña.AutoSize = True
        Me.L_Contraseña.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Contraseña.Location = New System.Drawing.Point(72, 211)
        Me.L_Contraseña.Name = "L_Contraseña"
        Me.L_Contraseña.Size = New System.Drawing.Size(239, 17)
        Me.L_Contraseña.TabIndex = 27
        Me.L_Contraseña.Text = "Ingrese una nueva contraseña"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(76, 159)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(267, 20)
        Me.TextBox_Nombre.TabIndex = 26
        '
        'L_Usuario
        '
        Me.L_Usuario.AutoSize = True
        Me.L_Usuario.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Usuario.Location = New System.Drawing.Point(72, 137)
        Me.L_Usuario.Name = "L_Usuario"
        Me.L_Usuario.Size = New System.Drawing.Size(229, 17)
        Me.L_Usuario.TabIndex = 25
        Me.L_Usuario.Text = "Ingrese el nombre de usuario"
        '
        'BT_limpiar
        '
        Me.BT_limpiar.BackColor = System.Drawing.Color.Sienna
        Me.BT_limpiar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_limpiar.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_limpiar.Location = New System.Drawing.Point(70, 288)
        Me.BT_limpiar.Name = "BT_limpiar"
        Me.BT_limpiar.Size = New System.Drawing.Size(110, 39)
        Me.BT_limpiar.TabIndex = 34
        Me.BT_limpiar.Text = "Limpiar"
        Me.BT_limpiar.UseVisualStyleBackColor = False
        '
        'BT_confirmar
        '
        Me.BT_confirmar.BackColor = System.Drawing.Color.Sienna
        Me.BT_confirmar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_confirmar.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_confirmar.Location = New System.Drawing.Point(205, 288)
        Me.BT_confirmar.Name = "BT_confirmar"
        Me.BT_confirmar.Size = New System.Drawing.Size(110, 39)
        Me.BT_confirmar.TabIndex = 35
        Me.BT_confirmar.Text = "Confirmar"
        Me.BT_confirmar.UseVisualStyleBackColor = False
        '
        'CheckBox_Usuario
        '
        Me.CheckBox_Usuario.AutoSize = True
        Me.CheckBox_Usuario.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Usuario.ForeColor = System.Drawing.Color.Sienna
        Me.CheckBox_Usuario.Location = New System.Drawing.Point(70, 93)
        Me.CheckBox_Usuario.Name = "CheckBox_Usuario"
        Me.CheckBox_Usuario.Size = New System.Drawing.Size(77, 19)
        Me.CheckBox_Usuario.TabIndex = 31
        Me.CheckBox_Usuario.Text = "Usuario"
        Me.CheckBox_Usuario.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 33)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Restablecer Contraseña"
        '
        'RestablecerContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(368, 349)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BT_confirmar)
        Me.Controls.Add(Me.BT_limpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox_Admin)
        Me.Controls.Add(Me.CheckBox_Usuario)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.L_Contraseña)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.L_Usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RestablecerContraseña"
        Me.Text = "Restablecer Contraseña"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox_Admin As CheckBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox_Contraseña As TextBox
    Friend WithEvents L_Contraseña As Label
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents L_Usuario As Label
    Friend WithEvents BT_limpiar As Button
    Friend WithEvents BT_confirmar As Button
    Friend WithEvents CheckBox_Usuario As CheckBox
    Friend WithEvents Label2 As Label
End Class
