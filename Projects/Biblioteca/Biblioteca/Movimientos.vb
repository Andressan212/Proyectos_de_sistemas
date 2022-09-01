Imports System.ComponentModel

Public Class Movimientos
    Dim xid, xid_libro, xprestado As Integer
    Dim xnombre, xfecha, xhora As String

    Private Sub bot_aceptar_Click(sender As Object, e As EventArgs) Handles bot_aceptar.Click
        Dim xdevuelto, xxfecha As String
        Dim xpres As Integer

        If Txt_cod.Text = "" Then
            MsgBox("Ingrese los datos del cliente")
            Txt_cod.Select()
            Txt_cod.Focus()
            Return
        End If
        xpres = 1
        xxfecha = "09/05/2022"
        conectarse()
        obj_cmd.CommandType = CommandType.Text
        obj_cmd.Connection = obj_conex
        wwsql = "update libros set prestado = " & xpres & ",cliente_id = " & xid & "where id_libro = " & xid_libro
        obj_cmd.CommandText = wwsql
        obj_cmd.ExecuteNonQuery()

        wsql = "insert into Movimientos(fecha,hora,cliente_id,libro_id,devuelto,usuario_id)"
        wsql = wsql & "values('" & xxfecha & "','" & xhora & "','" & xid & "','" & xid_libro & "','" & xdevuelto & "','" & wid_usuario & "')"
        MsgBox(wsql)
        obj_cmd.CommandText = wsql

        obj_cmd.ExecuteNonQuery()
        obj_dr.Close()
        desconectarse()
        MsgBox("Se guardo exitozamente")
        bot_aceptar.Enabled = False
        txt_nomlibro.Text = ""
        txt_nya.Text = ""
        Txt_cod.Text = ""
        txt_id.Text = ""



    End Sub

    Private Sub bot_agregar_libro_Click(sender As Object, e As EventArgs) Handles bot_agregar_libro.Click
        Libros.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clientes.ShowDialog()

    End Sub

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_cod.Focus()
        xfecha = Date.Now.ToShortDateString()
        xhora = TimeString
        Label6.Text = xfecha
        Label5.Text = xhora

        bot_aceptar.Enabled = False




    End Sub

    Private Sub txt_id_cliente_TextChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub Txt_cod_TextChanged(sender As Object, e As EventArgs) Handles Txt_cod.TextChanged

    End Sub

    Private Sub Txt_cod_Validating(sender As Object, e As CancelEventArgs) Handles Txt_cod.Validating
        xid = Val(Txt_cod.Text)
        obj_dr.Close()

        If xid > 0 Then

            conectarse()
            obj_cmd.CommandType = CommandType.Text
            obj_cmd.Connection = obj_conex
            wsql = "select* from Clientes where id=" & xid
            obj_cmd.CommandText = wsql
            obj_dr = obj_cmd.ExecuteReader
            If obj_dr.HasRows Then
                Do While obj_dr.Read
                    wid_cliente = obj_dr("id")
                    wnombre_cli = obj_dr("nya")
                    txt_nya.Text = wnombre_cli
                    txt_id.Focus()

                Loop
            Else
                MsgBox("No se encontro al cliente")
                Txt_cod.Focus()

            End If

            obj_dr.Close()
            desconectarse()

        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Devolucion.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListaLPrestado.ShowDialog()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListoLDevuelto.ShowDialog()
    End Sub

    Private Sub txt_nya_TextChanged(sender As Object, e As EventArgs) Handles txt_nya.TextChanged



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub txt_id_Validating(sender As Object, e As CancelEventArgs) Handles txt_id.Validating

        xid_libro = Val(txt_id.Text)
        obj_dr.Close()

        If xid_libro > 0 Then



            conectarse()
            obj_cmd.CommandType = CommandType.Text
            obj_cmd.Connection = obj_conex
            wsql = "select* from libros where id_libro =" & xid_libro
            obj_cmd.CommandText = wsql
            obj_dr = obj_cmd.ExecuteReader
            If obj_dr.HasRows Then
                Do While obj_dr.Read
                    widlibro = obj_dr("id_libro")
                    wnombre_lib = obj_dr("nombre")
                    xprestado = obj_dr("prestado")

                    txt_nomlibro.Text = wnombre_lib
                    If xprestado = 0 Then
                        MsgBox("Libro Disponible")
                        bot_aceptar.Enabled = True
                        bot_aceptar.Focus()

                    Else
                        MsgBox("Libro No Disponible")
                        txt_id.Focus()

                    End If




                Loop
            Else
                MsgBox("No se encontro el libro")
                txt_id.Focus()
                bot_aceptar.Enabled = False
            End If

            obj_dr.Close()
            desconectarse()
        End If
    End Sub
End Class