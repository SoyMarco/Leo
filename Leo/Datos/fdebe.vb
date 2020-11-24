Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class fdebe
    Inherits conexion
    Dim mosdebe As New MySqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            mosdebe = New MySqlCommand("mostrar_deben")
            mosdebe.CommandType = CommandType.StoredProcedure
            mosdebe.Connection = cnn

            If mosdebe.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(mosdebe)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
End Class
