<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bot_salir = New System.Windows.Forms.Button()
        Me.bot_guardar = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id_libro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(124, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 31)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "LIBROS"
        '
        'bot_salir
        '
        Me.bot_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_salir.Location = New System.Drawing.Point(210, 234)
        Me.bot_salir.Name = "bot_salir"
        Me.bot_salir.Size = New System.Drawing.Size(75, 32)
        Me.bot_salir.TabIndex = 32
        Me.bot_salir.Text = "Salir"
        Me.bot_salir.UseVisualStyleBackColor = True
        '
        'bot_guardar
        '
        Me.bot_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_guardar.Location = New System.Drawing.Point(83, 234)
        Me.bot_guardar.Name = "bot_guardar"
        Me.bot_guardar.Size = New System.Drawing.Size(95, 32)
        Me.bot_guardar.TabIndex = 31
        Me.bot_guardar.Text = "Guardar"
        Me.bot_guardar.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Location = New System.Drawing.Point(168, 158)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(175, 26)
        Me.txt_descripcion.TabIndex = 26
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(168, 118)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(137, 26)
        Me.txt_nombre.TabIndex = 25
        '
        'txt_id_libro
        '
        Me.txt_id_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_libro.Location = New System.Drawing.Point(168, 77)
        Me.txt_id_libro.Name = "txt_id_libro"
        Me.txt_id_libro.Size = New System.Drawing.Size(100, 26)
        Me.txt_id_libro.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre"
        '
        'Codigo
        '
        Me.Codigo.AutoSize = True
        Me.Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.Location = New System.Drawing.Point(57, 79)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(65, 20)
        Me.Codigo.TabIndex = 17
        Me.Codigo.Text = "Codigo"
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(407, 318)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bot_salir)
        Me.Controls.Add(Me.bot_guardar)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id_libro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Codigo)
        Me.Name = "Libros"
        Me.Text = "Libros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents bot_salir As Button
    Friend WithEvents bot_guardar As Button
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_id_libro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Codigo As Label
End Class
