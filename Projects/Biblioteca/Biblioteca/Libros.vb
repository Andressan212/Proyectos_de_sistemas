Public Class Libros
    Private Sub txt_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub bot_guardar_Click(sender As Object, e As EventArgs) Handles bot_guardar.Click
        Dim xid As Integer
        Dim xdescripcion, xnombre, xprestado As String

        If txt_id_libro.Text = "" Then
            MsgBox("Ingrese el codigo")
            txt_id_libro.Select()
            Return
        End If
        If txt_nombre.Text = "" Then
            MsgBox("Ingrese el nombre")
            txt_nombre.Select()
            Return
        End If
        If txt_descripcion.Text = "" Then
            MsgBox("Ingrese la dscripacion")
            txt_descripcion.Select()
            Return
        End If
        xid = txt_id_libro.Text
        xnombre = txt_nombre.Text
        xdescripcion = txt_descripcion.Text
        xprestado = 0
        obj_dr.Close()

        conectarse()
        obj_cmd.CommandType = CommandType.Text
        obj_cmd.Connection = obj_conex
        wsql = "insert into libros(id_libro,nombre,descripcion,prestado)"
        wsql = wsql & "values('" & xid & "','" & xnombre & "','" & xdescripcion & "','" & xprestado & "')"
        MsgBox(wsql)
        obj_cmd.CommandText = wsql
        obj_cmd.ExecuteNonQuery()
        obj_dr.Close()
        desconectarse()
        MsgBox("Se guardo exitozamente")
        txt_id_libro.Text = ""
        txt_nombre.Text = ""
        txt_descripcion.Text = ""


    End Sub
End Class
