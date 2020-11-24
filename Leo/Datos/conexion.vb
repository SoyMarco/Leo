Imports MySql.Data.MySqlClient
Public Class conexion
    Protected cnn As New MySqlConnection

    Protected Function conectado()
        Try
            cnn = New MySqlConnection("datasource =(localhost); initial catalog=leo;integrated security= true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
