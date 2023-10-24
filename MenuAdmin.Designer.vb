<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdmin))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btn_planilla = New System.Windows.Forms.Button()
        Me.btn_ajustes = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.btn_materiaPrima = New System.Windows.Forms.Button()
        Me.btn_proveedores = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(640, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'btn_planilla
        '
        Me.btn_planilla.BackColor = System.Drawing.Color.Sienna
        Me.btn_planilla.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_planilla.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_planilla.Location = New System.Drawing.Point(36, 126)
        Me.btn_planilla.Name = "btn_planilla"
        Me.btn_planilla.Size = New System.Drawing.Size(227, 54)
        Me.btn_planilla.TabIndex = 1
        Me.btn_planilla.Text = "Planilla"
        Me.btn_planilla.UseVisualStyleBackColor = False
        '
        'btn_ajustes
        '
        Me.btn_ajustes.BackColor = System.Drawing.Color.Sienna
        Me.btn_ajustes.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajustes.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_ajustes.Location = New System.Drawing.Point(698, 389)
        Me.btn_ajustes.Name = "btn_ajustes"
        Me.btn_ajustes.Size = New System.Drawing.Size(190, 49)
        Me.btn_ajustes.TabIndex = 3
        Me.btn_ajustes.Text = "Ajustes de Usuario"
        Me.btn_ajustes.UseVisualStyleBackColor = False
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.Color.Sienna
        Me.btn_productos.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_productos.Location = New System.Drawing.Point(353, 324)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(227, 54)
        Me.btn_productos.TabIndex = 7
        Me.btn_productos.Text = "Productos"
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'btn_materiaPrima
        '
        Me.btn_materiaPrima.BackColor = System.Drawing.Color.Sienna
        Me.btn_materiaPrima.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_materiaPrima.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_materiaPrima.Location = New System.Drawing.Point(353, 126)
        Me.btn_materiaPrima.Name = "btn_materiaPrima"
        Me.btn_materiaPrima.Size = New System.Drawing.Size(227, 54)
        Me.btn_materiaPrima.TabIndex = 8
        Me.btn_materiaPrima.Text = "Materia Prima"
        Me.btn_materiaPrima.UseVisualStyleBackColor = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BackColor = System.Drawing.Color.Sienna
        Me.btn_proveedores.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedores.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_proveedores.Location = New System.Drawing.Point(36, 324)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(227, 54)
        Me.btn_proveedores.TabIndex = 9
        Me.btn_proveedores.Text = "Proveedores"
        Me.btn_proveedores.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.DelisCake.My.Resources.Resources.Ajustes_Usuario
        Me.PictureBox5.Location = New System.Drawing.Point(736, 281)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 102)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DelisCake.My.Resources.Resources.MateriaPrima
        Me.PictureBox4.Location = New System.Drawing.Point(401, 18)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(121, 102)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DelisCake.My.Resources.Resources.Proveedores
        Me.PictureBox3.Location = New System.Drawing.Point(90, 216)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 102)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.Productos
        Me.PictureBox2.Location = New System.Drawing.Point(401, 216)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DelisCake.My.Resources.Resources.Planilla
        Me.PictureBox1.Location = New System.Drawing.Point(90, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(906, 450)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_proveedores)
        Me.Controls.Add(Me.btn_materiaPrima)
        Me.Controls.Add(Me.btn_productos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_ajustes)
        Me.Controls.Add(Me.btn_planilla)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuAdmin"
        Me.Text = "Menú Administrador"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btn_planilla As Button
    Friend WithEvents btn_ajustes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_productos As Button
    Friend WithEvents btn_materiaPrima As Button
    Friend WithEvents btn_proveedores As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
