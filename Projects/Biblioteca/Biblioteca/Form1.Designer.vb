<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bot_aceptar = New System.Windows.Forms.Button()
        Me.bot_salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(213, 105)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 0
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(213, 144)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(100, 20)
        Me.txt_contraseña.TabIndex = 1
        Me.txt_contraseña.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 39)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BIBLIOTECA"
        '
        'bot_aceptar
        '
        Me.bot_aceptar.Location = New System.Drawing.Point(100, 188)
        Me.bot_aceptar.Name = "bot_aceptar"
        Me.bot_aceptar.Size = New System.Drawing.Size(96, 23)
        Me.bot_aceptar.TabIndex = 5
        Me.bot_aceptar.Text = "Aceptar"
        Me.bot_aceptar.UseVisualStyleBackColor = True
        '
        'bot_salir
        '
        Me.bot_salir.Location = New System.Drawing.Point(213, 188)
        Me.bot_salir.Name = "bot_salir"
        Me.bot_salir.Size = New System.Drawing.Size(100, 23)
        Me.bot_salir.TabIndex = 6
        Me.bot_salir.Text = "Salir"
        Me.bot_salir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(414, 251)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bot_salir)
        Me.Controls.Add(Me.bot_aceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_usuario)
        Me.Name = "Form1"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bot_aceptar As Button
    Friend WithEvents bot_salir As Button
    Friend WithEvents Button1 As Button
End Class
