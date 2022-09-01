Imports System.ComponentModel

Public Class Devolucion
    Dim se As String
    Dim xid, xprestado As Integer
    Dim xidcli As Integer
    Private Sub txt_idlibro_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Txt_cod_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub bot_aceptar_Click(sender As Object, e As EventArgs) Handles bot_aceptar.Click
        Dim xxfecha, xhora As String
        Dim xpres, xdevuelto As Integer

        If txt_cod.Text = "" Then
            MsgBox("Ingrese los datos del cliente")
            txt_cod.Select()
            txt_cod.Focus()
            Return
        End If
        xdevuelto = 1 'devuelto'
        xpres = 0 'desponible'
        xxfecha = "09/05/2022"
        conectarse()
        obj_cmd.CommandType = CommandType.Text
        obj_cmd.Connection = obj_conex
        wwsql = "update libros set prestado ='" & xpres & "'where id_libro =" & xid
        obj_cmd.CommandText = wwsql
        obj_cmd.ExecuteNonQuery()
        xhora = TimeString
        wsql = "insert into Movimientos(fecha,hora,cliente_id,libro_id,devuelto,usuario_id)"
        wsql = wsql & "values('" & xxfecha & "','" & xhora & "','" & xidcli & "','" & xid & "','" & xdevuelto & "','" & wid_usuario & "')"
        MsgBox(wsql)
        obj_cmd.CommandText = wsql

        obj_cmd.ExecuteNonQuery()
        obj_dr.Close()
        desconectarse()
        MsgBox("Se guardo exitozamente")
        bot_aceptar.Enabled = False
        txt_cod.Text = ""
        txt_idlibro.Text = ""
        txt_nya.Text = ""
        txt_nomlibro.Text = ""


    End Sub

    Private Sub Txt_cod_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_cod_TextChanged_2(sender As Object, e As EventArgs) Handles txt_cod.TextChanged

    End Sub

    Private Sub Devolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cod.Focus()

        txt_cod.Text = ""
        txt_idlibro.Text = ""
        txt_nya.Text = ""
        txt_nomlibro.Text = ""
        txt_cod.Focus()


    End Sub

    Private Sub txt_idlibro_TextChanged_1(sender As Object, e As EventArgs) Handles txt_idlibro.TextChanged

    End Sub

    Private Sub txt_cod_Validating(sender As Object, e As CancelEventArgs) Handles txt_cod.Validating
        xid = Val(txt_cod.Text)
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
                    txt_idlibro.Focus()



                Loop
            Else
                MsgBox("No se encontro al cliente")
                txt_cod.Focus()

            End If

            obj_dr.Close()
            desconectarse()

        End If
    End Sub

    Private Sub txt_idlibro_Validating(sender As Object, e As CancelEventArgs) Handles txt_idlibro.Validating
        xid = Val(txt_idlibro.Text)
        obj_dr.Close()

        If xid > 0 Then



            conectarse()
            obj_cmd.CommandType = CommandType.Text
            obj_cmd.Connection = obj_conex
            wsql = "select* from libros where id_libro =" & xid
            obj_cmd.CommandText = wsql
            obj_dr = obj_cmd.ExecuteReader
            If obj_dr.HasRows Then
                Do While obj_dr.Read

                    wnombre_lib = obj_dr("nombre")
                    xprestado = obj_dr("prestado")
                    txt_nomlibro.Text = wnombre_lib
                    MsgBox(xprestado)
                    If xprestado = 1 Then
                        MsgBox("Libro Prestado")
                        bot_aceptar.Enabled = True
                    Else
                        MsgBox("Libro No Prestado")
                        txt_idlibro.Focus()

                    End If




                Loop
            Else
                MsgBox("No se encontro el libro")
                bot_aceptar.Enabled = False
                txt_idlibro.Focus()

            End If

            obj_dr.Close()
            desconectarse()
        End If
    End Sub
End Class