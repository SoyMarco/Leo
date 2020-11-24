Imports System.Text

Public Class ApartadoDio
    Private Sub RESTARIA()
        Dim tot As Integer
        Dim ValD As Integer = 0
        Int32.TryParse(dio.Text, ValD)
        tot = FormatCurrency(ValD)
        resta.Text = FormatCurrency(TOTAL.Text - ValD)
    End Sub
    Private Sub F12Cobrar()
        If FormatNumber(resta.Text) <= 0 Or resta.Text = TOTAL.Text Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            dio.Focus()
        Else
            ApartadoCobro.Show()
            Me.Hide()
        End If
    End Sub
    Public Sub CERRARVENTANA()
        Napartado.Show()
        Napartado.WindowState = FormWindowState.Normal
        Napartado.Pro1.Focus()
        Me.TopMost = False
        Me.Close()
    End Sub
    Private Sub CREDITO_TextChanged(sender As Object, e As EventArgs)
        RESTARIA()
    End Sub
    Private Sub F1()
        Try
            If FormatCurrency(dio.Text) > 0 Then
                ApartadoCobro.Show()
                ApartadoCobro.EFECTIVO.Text = dio.Text
                ApartadoCobro.F1()
            End If
        Catch EX As Exception
            Inicial.SonidoError()
        End Try

    End Sub
    Public Sub F3()
        'AGREGAR A INICIAL Y NO SUMAR EN CORTE
        If Int(resta.Text) < Int(0) Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            dio.Focus()
        Else
            ApartadoCobro.Show()
            Inicial.ProductosVendidosTableAdapter.InsertVentApart("APARTADO", dio.Text, Inicial.fecha.Text, Inicial.hora.Text, Inicial.VENDEDOR.Text, Inicial.IdVenta.Text, 0, "1", Napartado.IdApartado.Text, ApartadoCobro.idDio.Text)

            Inicial.F3()
            ApartadoCobro.EFECTIVO.Text = ""
            ApartadoCobro.CREDITO.Text = dio.Text
            ApartadoCobro.F2()
        End If
    End Sub
    Private Sub CREDITO_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub CREDITO_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.KeyCode = Keys.Enter) Then
            F12Cobrar()
        End If
        If (e.KeyCode = Keys.F12) Then
            F12Cobrar()
        End If
        If (e.KeyCode = Keys.F1) Then
            F1()
        End If
    End Sub
    Private Sub dio_TextChanged(sender As Object, e As EventArgs) Handles dio.TextChanged
        RESTARIA()
    End Sub
    Private Sub dio_KeyDown(sender As Object, e As KeyEventArgs) Handles dio.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            F12Cobrar()
        End If
        If (e.KeyCode = Keys.F12) Then
            F12Cobrar()
        End If
        If (e.KeyCode = Keys.F1) Then
            F1()
        End If
        If (e.KeyCode = Keys.Escape) Then
            CERRARVENTANA()
        End If
    End Sub
    Private Sub dio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F12Cobrar()
    End Sub
    Private Sub ApartadoDio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cliente.Text = Napartado.CLIENTE.Text
        TOTAL.Text = Napartado.TOTAL.Text
    End Sub
    Private Sub ApartadoDio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            CERRARVENTANA()
        End If
        If (e.KeyCode = Keys.F12) Then
            F12Cobrar()
        End If
        If (e.KeyCode = Keys.F1) Then
            F1()
        End If
        If (e.KeyCode = Keys.F3) Then
            F3()
        End If
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        CERRARVENTANA()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        F3()
    End Sub
End Class