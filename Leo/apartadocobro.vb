Public Class ApartadoCobro
    Private Sub CerrarCobro()
        ApartadoDio.Show()
        ApartadoDio.WindowState = FormWindowState.Normal
        ApartadoDio.TopMost = True
        Me.Close()
    End Sub
    Private Sub ImprimirApart()
        If FormatCurrency(cambio.Text) < FormatCurrency(0) Then
            'REPRODUCIR SONIDO
            Inicial.SonidoError()
        Else
            ImprimirApartado.Close()
            ImprimirApartado.Show()
        End If
        Reimprimir.Show()
        Reimprimir.REIMPRESION.Text = "APARTADO"
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
            Credito1.Text = Decimal.Parse(CREDITO.Text)
        Catch ex As Exception
            Credito1.Text = Decimal.Parse(0.00)
        End Try
    End Sub
    Private Sub SumaCambio()
        Formato()
        Dim TotPag As Integer = 0
        Dim Camb As Integer = 0
        Dim val8 As Integer = 0
        Int32.TryParse(efectivo1.Text, val8)
        Dim val9 As Integer = 0
        Int32.TryParse(tarjeta1.Text, val9)
        Dim val10 As Integer = 0
        Int32.TryParse(Credito1.Text, val10)
        Dim Abon As Integer = 0
        Int32.TryParse(Abono1.Text, Abon)
        TotPag = (val8 + val9 + val10)
        TotPag1.Text = TotPag
        Abono1.Text = Decimal.Parse(ApartadoDio.dio.Text)
        Camb = (TotPag - Abon)
        cambio.Text = FormatCurrency(Camb)
        'Efectivo en caja
        Dim EfeCaj As Integer
        EfeCaj = (val8 - Camb)
        EfectivoCaja.Text = FormatCurrency(EfeCaj)
    End Sub
    Private Sub GuardarApartado()
        SumaCambio()
        Formato()
        If FormatCurrency(cambio.Text) < FormatCurrency(0) Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            EFECTIVO.Focus()
        Else
            'GUARDAR DIO
            Me.DioTableAdapter.InsertarDio(ABONO.Text, Inicial.fecha.Text, Inicial.hora.Text, Inicial.VENDEDOR.Text, "0", Napartado.IdApartado.Text)
            'GUARDAR VENTA
            Me.VENTATableAdapter.Modificar(Inicial.VENDEDOR.Text, Inicial.DateTimePicker1.Value.Date(), Inicial.hora.Text, "0", EfectivoCaja.Text, tarjeta1.Text, efectivo1.Text, Credito1.Text, NOTAS.Text, REFERENCIA.Text, Abono1.Text, idVenta.Text)
            'GUARDAR APARTADO
            Me.ApartadosTableAdapter.InsertarApartado(Today.Date, Inicial.hora.Text, Inicial.VENDEDOR.Text, Napartado.CLIENTE.Text, Napartado.DATE222.Text, "0", "0", "0")
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Aceptar.wav")
            s.Play()
            ApartadoNombre.Close()
        End If
    End Sub
    Public Sub F1()
        If FormatCurrency(cambio.Text) < 0 Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            EFECTIVO.Focus()
        Else
            GuardarApartado()
            ImprimirApart()
            Inicial.DatImpre()
            ApartadoDio.Close()
        End If
    End Sub
    Public Sub F2()
        If FormatCurrency(cambio.Text) < 0 Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            EFECTIVO.Focus()
        Else
            GuardarApartado()
            ImprimirApartado.Close()
            ImprimirApartado.Show()
            ImprimirApartado.Lab.Text = 5
            ImprimirApartado.Focus()
            ImprimirApartado.Hide()
            Napartado.Close()
            ApartadoDio.Close()
            Inicial.Show()
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()
            Inicial.DatImpre()
            ApartadoNombre.Close()
            Me.Close()
        End If
    End Sub
    Private Sub Cuenta()
        If EFECTIVO.Text <> "" Then
            Dim camb As String
            camb = (EFECTIVO.Text - ABONO.Text)
            If camb >= 0 Then
                cambio.Text = FormatCurrency(camb)
            Else
                cambio.Text = FormatCurrency(0)
            End If
        End If
    End Sub
    Private Sub ApartadoCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VENTATableAdapter.InsertarVenta(Inicial.VENDEDOR.Text, Inicial.DateTimePicker1.Value(), Inicial.DateTimePicker1.Value(), "0", "$0.00", "$0.00", "$0.00", "$0.00", "", "0", "$0.00")
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENTA' Puede moverla o quitarla según sea necesario.
        Me.VENTATableAdapter.FillTOP10(Me.LeoDataSet.VENTA)
        Me.DioTableAdapter.FillTOP5(Me.LeoDataSet.Dio)
        VENTADataGridView.Sort(VENTADataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
        DioDataGridView.Sort(DioDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
        Dim cell As DataGridViewCell = VENTADataGridView.CurrentCell
        cell = VENTADataGridView.Rows(VENTADataGridView.RowCount - 2).Cells(cell.ColumnIndex)
        VENTADataGridView.CurrentCell = cell
        Dim ID As Single
        Dim rowCU As DataGridViewRow = VENTADataGridView.CurrentRow
        ID = CStr(rowCU.Cells(0).Value)
        idVenta.Text = ID
        Dim cell1 As DataGridViewCell = DioDataGridView.CurrentCell
        cell1 = DioDataGridView.Rows(DioDataGridView.RowCount - 2).Cells(cell.ColumnIndex)
        DioDataGridView.CurrentCell = cell1
        Dim ID1 As Single
        Dim rowCU1 As DataGridViewRow = DioDataGridView.CurrentRow
        ID1 = CStr(rowCU1.Cells(0).Value)
        idDio.Text = ID1 + 1
        ABONO.Text = FormatCurrency(ApartadoDio.dio.Text)
        Abono1.Text = FormatCurrency(ApartadoDio.dio.Text)
        EFECTIVO.Text = Int(ABONO.Text)
        PictureBox1.Width = Me.Width + 10
        Cuenta()
    End Sub
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        CerrarCobro()
    End Sub
    Private Sub Dio_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub SoloNumeros(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Apartadocobro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            CerrarCobro()
            ApartadoDio.TopMost = True
        End If
        If (e.KeyCode = Keys.F1) Then
            F1()
        End If
        If (e.KeyCode = Keys.F2) Then
            F2()
        End If
        If (e.KeyCode = Keys.F3) Then
            ApartadoDio.F3()
        End If
    End Sub
    Private Sub EFECTIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EFECTIVO.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub TARJETA_TextChanged(sender As Object, e As EventArgs) Handles TARJETA.TextChanged
        LabelRef.Visible = True
        REFERENCIA.Visible = True
        SumaCambio()
        Formato()
    End Sub
    Private Sub TARJETA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TARJETA.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub CREDITO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CREDITO.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
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
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub EFECTIVO_TextChanged(sender As Object, e As EventArgs) Handles EFECTIVO.TextChanged
        SumaCambio()
        Formato()
    End Sub
    Private Sub CREDITO_TextChanged(sender As Object, e As EventArgs)
        SumaCambio()
        Formato()
    End Sub
    Private Sub Cobrar_Click(sender As Object, e As EventArgs) Handles cobrar.Click
        F1()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F2()
    End Sub
    Private Sub CREDITO_TextChanged_1(sender As Object, e As EventArgs) Handles CREDITO.TextChanged
        SumaCambio()
        Formato()
    End Sub

    Private Sub EFECTIVO_Click(sender As Object, e As EventArgs) Handles EFECTIVO.Click
        EFECTIVO.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ApartadoDio.F3()
    End Sub
End Class