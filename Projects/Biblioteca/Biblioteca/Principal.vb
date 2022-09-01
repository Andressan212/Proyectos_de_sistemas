Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient

Module Principal
    Public obj_conex As New SqlConnection("Initial Catalog=Biblioteca; Data Source=localhost;Integrated Security=SSPI; MultipleActiveResultSets=True")
    Public obj_cmd As New SqlCommand
    Public obj_dr As SqlDataReader
    Public wsql, wwsql, wcontraseña, wnya_usuario, wnombre_cli, wnombre_lib As String
    Public wid_cliente, wid_usuario, widlibro As Integer

    Public Sub conectarse()
        Try
            If obj_conex.State() = 0 Then
                'msgbox("Se esta conectando...")
                obj_conex.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub desconectarse()
        obj_conex.close()
    End Sub


End Module
