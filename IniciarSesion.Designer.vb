<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_NombreLogin = New System.Windows.Forms.TextBox()
        Me.TextBox_ContraseñaLogin = New System.Windows.Forms.TextBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox_Admin = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Usuario = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Inicio de Sesión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(61, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Contraseña"
        '
        'TextBox_NombreLogin
        '
        Me.TextBox_NombreLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NombreLogin.Location = New System.Drawing.Point(61, 302)
        Me.TextBox_NombreLogin.Name = "TextBox_NombreLogin"
        Me.TextBox_NombreLogin.Size = New System.Drawing.Size(296, 24)
        Me.TextBox_NombreLogin.TabIndex = 4
        '
        'TextBox_ContraseñaLogin
        '
        Me.TextBox_ContraseñaLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBox_ContraseñaLogin.Location = New System.Drawing.Point(62, 376)
        Me.TextBox_ContraseñaLogin.Name = "TextBox_ContraseñaLogin"
        Me.TextBox_ContraseñaLogin.Size = New System.Drawing.Size(296, 24)
        Me.TextBox_ContraseñaLogin.TabIndex = 5
        '
        'btn_iniciar
        '
        Me.btn_iniciar.BackColor = System.Drawing.Color.Sienna
        Me.btn_iniciar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciar.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_iniciar.Location = New System.Drawing.Point(110, 417)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(187, 46)
        Me.btn_iniciar.TabIndex = 8
        Me.btn_iniciar.Text = "Iniciar Sesión"
        Me.btn_iniciar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tipo de Usuario:"
        '
        'CheckBox_Admin
        '
        Me.CheckBox_Admin.AutoSize = True
        Me.CheckBox_Admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Admin.ForeColor = System.Drawing.Color.Sienna
        Me.CheckBox_Admin.Location = New System.Drawing.Point(190, 246)
        Me.CheckBox_Admin.Name = "CheckBox_Admin"
        Me.CheckBox_Admin.Size = New System.Drawing.Size(122, 20)
        Me.CheckBox_Admin.TabIndex = 14
        Me.CheckBox_Admin.Text = "Administrador"
        Me.CheckBox_Admin.UseVisualStyleBackColor = True
        '
        'CheckBox_Usuario
        '
        Me.CheckBox_Usuario.AutoSize = True
        Me.CheckBox_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Usuario.ForeColor = System.Drawing.Color.Sienna
        Me.CheckBox_Usuario.Location = New System.Drawing.Point(93, 246)
        Me.CheckBox_Usuario.Name = "CheckBox_Usuario"
        Me.CheckBox_Usuario.Size = New System.Drawing.Size(80, 20)
        Me.CheckBox_Usuario.TabIndex = 13
        Me.CheckBox_Usuario.Text = "Usuario"
        Me.CheckBox_Usuario.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DelisCake.My.Resources.Resources.Pass
        Me.PictureBox3.Location = New System.Drawing.Point(12, 363)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.User
        Me.PictureBox2.Location = New System.Drawing.Point(12, 290)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(109, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(412, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(404, 486)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 486)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox_Admin)
        Me.Controls.Add(Me.CheckBox_Usuario)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox_ContraseñaLogin)
        Me.Controls.Add(Me.TextBox_NombreLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InicioSesion"
        Me.Text = "Inicio Sesión"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_ContraseñaLogin As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_iniciar As Button
    Public WithEvents TextBox_NombreLogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox_Admin As CheckBox
    Friend WithEvents CheckBox_Usuario As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
