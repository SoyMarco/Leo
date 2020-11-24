Public Class Cobro
    Private Sub VENTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENTABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)

    End Sub

    Private Sub Cobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENTA' Puede moverla o quitarla según sea necesario.
        Me.VENTATableAdapter.FillTOP10(Me.LeoDataSet.VENTA)
        EFECTIVO.Text = Int(TOTAL.Text)
        EFECTIVO.SelectAll()
        SumaCambio()
    End Sub
    Private Sub GuardarVenta()
        If Ventana.Text = "1" Then
            Me.VENTATableAdapter.Modificar(Inicial.VENDEDOR.Text, Inicial.DateTimePicker1.Value.Date(), Inicial.hora.Text, "0", EfectivoCaja.Text, tarjeta1.Text, efectivo1.Text, credito1.Text, NOTAS.Text, REFERENCIA.Text, TOTAL.Text, Inicial.IdVenta.Text)
        Else
            Me.VENTATableAdapter.Modificar(Inicial.VENDEDOR.Text, Inicial.DateTimePicker1.Value.Date(), Inicial.hora.Text, "0", EfectivoCaja.Text, tarjeta1.Text, efectivo1.Text, credito1.Text, NOTAS.Text, REFERENCIA.Text, TOTAL.Text, Venta2.IdVenta.Text)
        End If

        Me.VENTATableAdapter.Fill(Me.LeoDataSet.VENTA)
    End Sub
    Public Sub SumaCambio()
        Dim TotPag As Integer
        Dim Camb As Integer
        Dim val8 As Integer = 0
        Int32.TryParse(EFECTIVO.Text, val8)
        Dim val9 As Integer = 0
        Int32.TryParse(TARJETA.Text, val9)
        Dim val10 As Integer = 0
        Int32.TryParse(CREDITO.Text, val10)
        Dim Tot As Integer = 0
        Int32.TryParse(TOTAL.Text, Tot)

        TotPag = (val8 + val9 + val10)
        Total1.Text = FormatCurrency(TotPag)
        Camb = (val8 + val9 + val10 - TOTAL.Text)
        cambio.Text = FormatCurrency(Camb)

        'Efectivo en caja
        Dim EfeCaj As Integer
        EfeCaj = (val8 - Camb)
        EfectivoCaja.Text = FormatCurrency(EfeCaj)
    End Sub
    Private Sub Formato()
        Try
            efectivo1.Text = Decimal.Parse(EFECTIVO.Text)
        Catch ex As Exception
            efectivo1.Text = Decimal.Parse(0.00)
        End Try
        Try
            tarjeta1.Text = Decimal.Parse(TARJETA.Text)
        Catch ex As Exception
            tarjeta1.Text = Decimal.Parse(0.00)
        End Try
        Try
            credito1.Text = Decimal.Parse(CREDITO.Text)
        Catch ex As Exception
            credito1.Text = Decimal.Parse(0.00)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TARJETA.TextChanged
        LabelRef.Visible = True
        REFERENCIA.Visible = True
        SumaCambio()
        Formato()
    End Sub
    Private Sub Imprimir()

        ImprimirCobro.Close()
            ImprimirCobro.Show()

    End Sub
    Private Sub F1imprimir()
        If cambio.Text < 0 Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        Else
            GuardarVenta()
            Imprimir()
        End If
    End Sub
    Private Sub SoloGuardar()
        If cambio.Text < 0 Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        Else
            GuardarVenta()
            ImprimirCobro.Close()
            ImprimirCobro.Show()
            ImprimirCobro.Lab.Text = 2
            ImprimirCobro.Focus()
            ImprimirCobro.Hide()

            If Ventana.Text = 1 Then
                Inicial.Close()
                Inicial.Show()
                Inicial.DatImpre()
            End If
            If Ventana.Text = 2 Then
                Venta2.Close()
                Inicial.DatImpre()
            End If


            Me.Close()
        End If
    End Sub

    Private Sub EFECTIVO_TextChanged(sender As Object, e As EventArgs) Handles EFECTIVO.TextChanged
        SumaCambio()
        Formato()
    End Sub

    Private Sub EFECTIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EFECTIVO.KeyPress
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TARJETA.KeyPress
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

    Private Sub REFERENCIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles REFERENCIA.KeyPress
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

    Private Sub CREDITO_TextChanged(sender As Object, e As EventArgs) Handles CREDITO.TextChanged
        SumaCambio()
        Formato()
    End Sub

    Private Sub CREDITO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CREDITO.KeyPress
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

    Private Sub Cobro_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F1) Then
            F1imprimir()
        End If

        If (e.KeyCode = Keys.F2) Then
            SoloGuardar()
        End If

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub cobrar_KeyDown(sender As Object, e As KeyEventArgs) Handles cobrar.KeyDown

    End Sub



    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub cobrar_Click(sender As Object, e As EventArgs) Handles cobrar.Click
        F1imprimir()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        SoloGuardar()
    End Sub

    Private Sub EFECTIVO_Click(sender As Object, e As EventArgs) Handles EFECTIVO.Click
        EFECTIVO.Text = ""
    End Sub
End Class