<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListoLDevuelto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listaD = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.listaD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LISTA DE LIBRO DEVUELTO"
        '
        'listaD
        '
        Me.listaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.nombre_libro, Me.codigo_cliente, Me.cliente_nombre})
        Me.listaD.Location = New System.Drawing.Point(37, 92)
        Me.listaD.Name = "listaD"
        Me.listaD.Size = New System.Drawing.Size(642, 140)
        Me.listaD.TabIndex = 2
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo Libro"
        Me.Codigo.Name = "Codigo"
        '
        'nombre_libro
        '
        Me.nombre_libro.HeaderText = "Nombre del Libro"
        Me.nombre_libro.Name = "nombre_libro"
        Me.nombre_libro.Width = 200
        '
        'codigo_cliente
        '
        Me.codigo_cliente.HeaderText = "Codigo Cliente"
        Me.codigo_cliente.Name = "codigo_cliente"
        '
        'cliente_nombre
        '
        Me.cliente_nombre.HeaderText = "Nombre del Cliente"
        Me.cliente_nombre.Name = "cliente_nombre"
        Me.cliente_nombre.Width = 200
        '
        'ListoLDevuelto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(726, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listaD)
        Me.Name = "ListoLDevuelto"
        Me.Text = "ListoLDevuelto"
        CType(Me.listaD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents listaD As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre_libro As DataGridViewTextBoxColumn
    Friend WithEvents codigo_cliente As DataGridViewTextBoxColumn
    Friend WithEvents cliente_nombre As DataGridViewTextBoxColumn
End Class
