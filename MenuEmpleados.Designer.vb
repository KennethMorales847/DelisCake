<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuEmpleados))
        Me.btn_materiaPrima = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_materiaPrima
        '
        Me.btn_materiaPrima.BackColor = System.Drawing.Color.Sienna
        Me.btn_materiaPrima.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_materiaPrima.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_materiaPrima.Location = New System.Drawing.Point(15, 361)
        Me.btn_materiaPrima.Name = "btn_materiaPrima"
        Me.btn_materiaPrima.Size = New System.Drawing.Size(227, 54)
        Me.btn_materiaPrima.TabIndex = 15
        Me.btn_materiaPrima.Text = "Materia Prima"
        Me.btn_materiaPrima.UseVisualStyleBackColor = False
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.Color.Sienna
        Me.btn_productos.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_productos.Location = New System.Drawing.Point(294, 361)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(227, 54)
        Me.btn_productos.TabIndex = 14
        Me.btn_productos.Text = "Productos"
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(141, 35)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DelisCake.My.Resources.Resources.MateriaPrima
        Me.PictureBox4.Location = New System.Drawing.Point(63, 253)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(121, 102)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DelisCake.My.Resources.Resources.Productos
        Me.PictureBox2.Location = New System.Drawing.Point(342, 253)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_materiaPrima)
        Me.Controls.Add(Me.btn_productos)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuEmpleados"
        Me.Text = "Menú Usuarios"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_materiaPrima As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button1 As Button
End Class
