<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.bot_salir = New System.Windows.Forms.Button()
        Me.bot_guardar = New System.Windows.Forms.Button()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bot_salir
        '
        Me.bot_salir.Location = New System.Drawing.Point(236, 265)
        Me.bot_salir.Name = "bot_salir"
        Me.bot_salir.Size = New System.Drawing.Size(75, 23)
        Me.bot_salir.TabIndex = 31
        Me.bot_salir.Text = "Salir"
        Me.bot_salir.UseVisualStyleBackColor = True
        '
        'bot_guardar
        '
        Me.bot_guardar.Location = New System.Drawing.Point(146, 265)
        Me.bot_guardar.Name = "bot_guardar"
        Me.bot_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bot_guardar.TabIndex = 30
        Me.bot_guardar.Text = "Guardar"
        Me.bot_guardar.UseVisualStyleBackColor = True
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(147, 211)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(206, 20)
        Me.txt_domicilio.TabIndex = 28
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(146, 175)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 27
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(146, 141)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(207, 20)
        Me.txt_nombre.TabIndex = 25
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(146, 108)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(137, 20)
        Me.txt_dni.TabIndex = 24
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(147, 73)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_cliente.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre y Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "DNI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(117, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 31)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "CLIENTE"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(390, 321)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bot_salir)
        Me.Controls.Add(Me.bot_guardar)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.txt_id_cliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bot_salir As Button
    Friend WithEvents bot_guardar As Button
    Friend WithEvents txt_domicilio As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txt_id_cliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
