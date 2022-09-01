<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaLPrestado
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
        Me.ListaP = New System.Windows.Forms.DataGridView()
        Me.Codigocli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ListaP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaP
        '
        Me.ListaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigocli, Me.nombre_libro, Me.codigo_cliente, Me.Column1})
        Me.ListaP.Location = New System.Drawing.Point(114, 83)
        Me.ListaP.Name = "ListaP"
        Me.ListaP.Size = New System.Drawing.Size(644, 150)
        Me.ListaP.TabIndex = 0
        '
        'Codigocli
        '
        Me.Codigocli.HeaderText = "Codigo Cliente"
        Me.Codigocli.Name = "Codigocli"
        '
        'nombre_libro
        '
        Me.nombre_libro.HeaderText = "Codigo Libro"
        Me.nombre_libro.Name = "nombre_libro"
        '
        'codigo_cliente
        '
        Me.codigo_cliente.HeaderText = "Nombre"
        Me.codigo_cliente.Name = "codigo_cliente"
        Me.codigo_cliente.Width = 200
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descipcion"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTA DE LIBRO PRESTADO"
        '
        'ListaLPrestado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(895, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListaP)
        Me.Name = "ListaLPrestado"
        Me.Text = "ListaLPrestado"
        CType(Me.ListaP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaP As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Codigocli As DataGridViewTextBoxColumn
    Friend WithEvents nombre_libro As DataGridViewTextBoxColumn
    Friend WithEvents codigo_cliente As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
