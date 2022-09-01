Public Class Clientes
    Private Sub bot_guardar_Click(sender As Object, e As EventArgs) Handles bot_guardar.Click
        Dim xid, xtelefono, xdni As Integer
        Dim xnombre, xdomicilio As String
        If txt_id_cliente.Text = "" Then
            MsgBox("Ingrese el codigo")
            txt_id_cliente.Select()
            Return
        End If
        If txt_dni.Text = "" Then
            MsgBox("Ingrese el dni")
            txt_dni.Select()
            Return
        End If
        If txt_nombre.Text = "" Then
            MsgBox("Ingrese el nombre y apellido")
            txt_nombre.Select()
            Return
        End If
        If txt_domicilio.Text = "" Then
            MsgBox("Ingrese el domicilio")
            txt_domicilio.Select()
            Return
        End If
        If txt_id_cliente.Text = "" Then
            MsgBox("Ingrese el telefono")
            txt_telefono.Select()
            Return
        End If
        xid = txt_id_cliente.Text
        xdni = txt_dni.Text
        xnombre = txt_nombre.Text
        xdomicilio = txt_domicilio.Text
        xtelefono = txt_telefono.Text
        obj_dr.Close()
        conectarse()
        obj_cmd.CommandType = CommandType.Text
        obj_cmd.Connection = obj_conex
        wsql = "insert into Clientes(id,dni,nya,domicilio,telefono)"
        wsql = wsql & "values ('" & xid & "','" & xdni & "','" & xnombre & "','" & xdomicilio & "','" & xtelefono & "')"
        MsgBox(wsql)
        obj_cmd.CommandText = wsql
        obj_cmd.ExecuteNonQuery()
        obj_dr.Close()
        desconectarse()
        MsgBox("Se guardo exitozamente")
        txt_id_cliente.Text = ""
        txt_dni.Text = ""
        txt_nombre.Text = ""
        txt_domicilio.Text = ""
        txt_telefono.Text = ""
        txt_id_cliente.Focus()



    End Sub

    Private Sub bot_salir_Click(sender As Object, e As EventArgs) Handles bot_salir.Click
        Me.Close()

    End Sub
End Class