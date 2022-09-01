Public Class Form1
    Private Sub bot_aceptar_Click(sender As Object, e As EventArgs) Handles bot_aceptar.Click
        Dim xnya, xcontraseña As String
        If txt_usuario.Text = "" Then
            MsgBox("ingrese el Usuario")
            txt_usuario.Select()
            Return


        End If
        If txt_contraseña.Text = "" Then
            MsgBox("Ingrese la contraseña")
            txt_contraseña.Select()

            Return
        End If
        xnya = txt_usuario.Text
        xcontraseña = Val(txt_contraseña.Text)
        conectarse()
        obj_cmd.CommandType = CommandType.Text
        obj_cmd.Connection = obj_conex
        wsql = "select * from Usuarios where contraseña =" & xcontraseña
        MsgBox(wsql)

        obj_cmd.CommandText = wsql
        obj_dr = obj_cmd.ExecuteReader()
        If obj_dr.HasRows Then
            Do While obj_dr.Read
                wid_usuario = obj_dr("id")
                wcontraseña = obj_dr("contraseña")
                wnya_usuario = obj_dr("nombre")
                If wnya_usuario = xnya Then
                    If wcontraseña = xcontraseña Then
                        Movimientos.ShowDialog()

                    End If

                Else
                    MsgBox("Usuario incorecto,Vuelva a ingresar")
                End If

            Loop
        Else
            MsgBox("Contraseña Incorrecta")

        End If

        obj_dr.Close()
        desconectarse()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
