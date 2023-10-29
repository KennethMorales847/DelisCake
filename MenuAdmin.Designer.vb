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
        Me.btn_planilla = New System.Windows.Forms.Button()
        Me.btn_ajustes = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.btn_materiaPrima = New System.Windows.Forms.Button()
        Me.btn_proveedores = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Materia_Prima_TableTableAdapter1 = New DelisCake.DelisCakeDatabaseDataSetTableAdapters.Materia_Prima_TableTableAdapter()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_planilla
        '
        Me.btn_planilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_planilla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_planilla.FlatAppearance.BorderSize = 5
        Me.btn_planilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_planilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_planilla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_planilla.Image = CType(resources.GetObject("btn_planilla.Image"), System.Drawing.Image)
        Me.btn_planilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_planilla.Location = New System.Drawing.Point(-1, 86)
        Me.btn_planilla.Name = "btn_planilla"
        Me.btn_planilla.Size = New System.Drawing.Size(327, 77)
        Me.btn_planilla.TabIndex = 1
        Me.btn_planilla.Text = "   Planilla"
        Me.btn_planilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_planilla.UseVisualStyleBackColor = False
        '
        'btn_ajustes
        '
        Me.btn_ajustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_ajustes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_ajustes.FlatAppearance.BorderSize = 5
        Me.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajustes.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_ajustes.Location = New System.Drawing.Point(173, 404)
        Me.btn_ajustes.Name = "btn_ajustes"
        Me.btn_ajustes.Size = New System.Drawing.Size(141, 67)
        Me.btn_ajustes.TabIndex = 3
        Me.btn_ajustes.Text = "Ajustes de Usuario"
        Me.btn_ajustes.UseVisualStyleBackColor = False
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_productos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_productos.FlatAppearance.BorderSize = 5
        Me.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_productos.Image = CType(resources.GetObject("btn_productos.Image"), System.Drawing.Image)
        Me.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_productos.Location = New System.Drawing.Point(0, 313)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(326, 77)
        Me.btn_productos.TabIndex = 7
        Me.btn_productos.Text = "  Productos"
        Me.btn_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'btn_materiaPrima
        '
        Me.btn_materiaPrima.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_materiaPrima.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_materiaPrima.FlatAppearance.BorderSize = 5
        Me.btn_materiaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_materiaPrima.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_materiaPrima.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_materiaPrima.Image = CType(resources.GetObject("btn_materiaPrima.Image"), System.Drawing.Image)
        Me.btn_materiaPrima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_materiaPrima.Location = New System.Drawing.Point(-1, 239)
        Me.btn_materiaPrima.Name = "btn_materiaPrima"
        Me.btn_materiaPrima.Size = New System.Drawing.Size(326, 77)
        Me.btn_materiaPrima.TabIndex = 8
        Me.btn_materiaPrima.Text = " Materia Prima"
        Me.btn_materiaPrima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_materiaPrima.UseVisualStyleBackColor = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_proveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_proveedores.FlatAppearance.BorderSize = 5
        Me.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_proveedores.Image = CType(resources.GetObject("btn_proveedores.Image"), System.Drawing.Image)
        Me.btn_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proveedores.Location = New System.Drawing.Point(0, 162)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(326, 77)
        Me.btn_proveedores.TabIndex = 9
        Me.btn_proveedores.Text = " Proveedores"
        Me.btn_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_proveedores.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 402)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(94, 69)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Menú de Administrador"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(91, 404)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(76, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(337, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(361, 483)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'Materia_Prima_TableTableAdapter1
        '
        Me.Materia_Prima_TableTableAdapter1.ClearBeforeFill = True
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 483)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btn_proveedores)
        Me.Controls.Add(Me.btn_materiaPrima)
        Me.Controls.Add(Me.btn_productos)
        Me.Controls.Add(Me.btn_ajustes)
        Me.Controls.Add(Me.btn_planilla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuAdmin"
        Me.Text = "Menú Administrador"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_planilla As Button
    Friend WithEvents btn_ajustes As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents btn_materiaPrima As Button
    Friend WithEvents btn_proveedores As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Materia_Prima_TableTableAdapter1 As DelisCakeDatabaseDataSetTableAdapters.Materia_Prima_TableTableAdapter
End Class
