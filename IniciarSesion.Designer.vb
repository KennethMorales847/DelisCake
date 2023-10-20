<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_NombreLogin = New System.Windows.Forms.TextBox()
        Me.TextBox_ContraseñaLogin = New System.Windows.Forms.TextBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.btn_registrarse = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox_Admin = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Usuario = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio de Sesión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese su Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ingrese su Contraseña"
        '
        'TextBox_NombreLogin
        '
        Me.TextBox_NombreLogin.Location = New System.Drawing.Point(72, 301)
        Me.TextBox_NombreLogin.Name = "TextBox_NombreLogin"
        Me.TextBox_NombreLogin.Size = New System.Drawing.Size(296, 20)
        Me.TextBox_NombreLogin.TabIndex = 4
        '
        'TextBox_ContraseñaLogin
        '
        Me.TextBox_ContraseñaLogin.Location = New System.Drawing.Point(73, 375)
        Me.TextBox_ContraseñaLogin.Name = "TextBox_ContraseñaLogin"
        Me.TextBox_ContraseñaLogin.Size = New System.Drawing.Size(296, 20)
        Me.TextBox_ContraseñaLogin.TabIndex = 5
        '
        'btn_iniciar
        '
        Me.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_iniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciar.Location = New System.Drawing.Point(73, 423)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(128, 42)
        Me.btn_iniciar.TabIndex = 8
        Me.btn_iniciar.Text = "Iniciar Sesión"
        Me.btn_iniciar.UseVisualStyleBackColor = False
        '
        'btn_registrarse
        '
        Me.btn_registrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarse.Location = New System.Drawing.Point(228, 423)
        Me.btn_registrarse.Name = "btn_registrarse"
        Me.btn_registrarse.Size = New System.Drawing.Size(122, 42)
        Me.btn_registrarse.TabIndex = 9
        Me.btn_registrarse.Text = "Registrarse"
        Me.btn_registrarse.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DelisCake.My.Resources.Resources.Pass
        Me.PictureBox3.Location = New System.Drawing.Point(32, 356)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.User
        Me.PictureBox2.Location = New System.Drawing.Point(31, 285)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DelisCake.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(132, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tipo de Usuario:"
        '
        'CheckBox_Admin
        '
        Me.CheckBox_Admin.AutoSize = True
        Me.CheckBox_Admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Admin.ForeColor = System.Drawing.Color.Indigo
        Me.CheckBox_Admin.Location = New System.Drawing.Point(219, 239)
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
        Me.CheckBox_Usuario.ForeColor = System.Drawing.Color.Indigo
        Me.CheckBox_Usuario.Location = New System.Drawing.Point(84, 239)
        Me.CheckBox_Usuario.Name = "CheckBox_Usuario"
        Me.CheckBox_Usuario.Size = New System.Drawing.Size(80, 20)
        Me.CheckBox_Usuario.TabIndex = 13
        Me.CheckBox_Usuario.Text = "Usuario"
        Me.CheckBox_Usuario.UseVisualStyleBackColor = True
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 486)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox_Admin)
        Me.Controls.Add(Me.CheckBox_Usuario)
        Me.Controls.Add(Me.btn_registrarse)
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
    Friend WithEvents btn_registrarse As Button
    Public WithEvents TextBox_NombreLogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox_Admin As CheckBox
    Friend WithEvents CheckBox_Usuario As CheckBox
End Class
