Public Class ListoLDevuelto
    Private Sub ListoLDevuelto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xid, xid_libro As Integer
        Dim xnomlibro As String
        listaD.Rows.Clear()


        obj_dr.Close()

        conectarse()
        obj_cmd.CommandType = CommandType.Text
        obj_cmd.Connection = obj_conex
        wsql = "select* from libros where prestado=" & 0

        obj_cmd.CommandText = wsql
        obj_dr = obj_cmd.ExecuteReader
        If obj_dr.HasRows Then
            Do While obj_dr.Read
                xid = obj_dr("cliente_id")
                xid_libro = obj_dr("id_libro")
                xnomlibro = obj_dr("nombre")
                listaD.Rows.Add(xid, xid_libro, xnomlibro)






            Loop
        End If
        obj_dr.Close()
        '  wsql = "select* from Clientes where id =" & xid
        'obj_cmd.CommandText = wsql
        ' obj_dr = obj_cmd.ExecuteReader
        ' If obj_dr.HasRows Then
        'Do While obj_dr.Read
        'xidc = obj_dr("id")
        'xdnic = obj_dr("dni")
        'xnombrec = obj_dr("nya")

        'Loop
        ' End If


        ' obj_dr.Close()
        desconectarse()
    End Sub

End Class