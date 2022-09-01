<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolucion
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bot_cancelar = New System.Windows.Forms.Button()
        Me.bot_aceptar = New System.Windows.Forms.Button()
        Me.txt_nomlibro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nya = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_idlibro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 31)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "DEVOLUCION"
        '
        'bot_cancelar
        '
        Me.bot_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_cancelar.Location = New System.Drawing.Point(226, 182)
        Me.bot_cancelar.Name = "bot_cancelar"
        Me.bot_cancelar.Size = New System.Drawing.Size(105, 36)
        Me.bot_cancelar.TabIndex = 22
        Me.bot_cancelar.Text = "Cancelar"
        Me.bot_cancelar.UseVisualStyleBackColor = True
        '
        'bot_aceptar
        '
        Me.bot_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_aceptar.Location = New System.Drawing.Point(109, 182)
        Me.bot_aceptar.Name = "bot_aceptar"
        Me.bot_aceptar.Size = New System.Drawing.Size(100, 36)
        Me.bot_aceptar.TabIndex = 21
        Me.bot_aceptar.Text = "Aceptar"
        Me.bot_aceptar.UseVisualStyleBackColor = True
        '
        'txt_nomlibro
        '
        Me.txt_nomlibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomlibro.Location = New System.Drawing.Point(214, 128)
        Me.txt_nomlibro.Name = "txt_nomlibro"
        Me.txt_nomlibro.Size = New System.Drawing.Size(190, 22)
        Me.txt_nomlibro.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Libro"
        '
        'txt_nya
        '
        Me.txt_nya.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nya.Location = New System.Drawing.Point(215, 86)
        Me.txt_nya.Name = "txt_nya"
        Me.txt_nya.Size = New System.Drawing.Size(190, 22)
        Me.txt_nya.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Codigo"
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(89, 86)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod.TabIndex = 30
        '
        'txt_idlibro
        '
        Me.txt_idlibro.Location = New System.Drawing.Point(89, 128)
        Me.txt_idlibro.Name = "txt_idlibro"
        Me.txt_idlibro.Size = New System.Drawing.Size(100, 20)
        Me.txt_idlibro.TabIndex = 31
        '
        'Devolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(434, 261)
        Me.Controls.Add(Me.txt_idlibro)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nya)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bot_cancelar)
        Me.Controls.Add(Me.bot_aceptar)
        Me.Controls.Add(Me.txt_nomlibro)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Devolucion"
        Me.Text = "Devolucion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bot_cancelar As Button
    Friend WithEvents bot_aceptar As Button
    Friend WithEvents txt_nomlibro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nya As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents txt_idlibro As TextBox
End Class
