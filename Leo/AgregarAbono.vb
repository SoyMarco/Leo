Public Class AgregarAbono
    Private Sub AgregarAbono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VENTATableAdapter.InsertarVenta(Inicial.VENDEDOR.Text, Inicial.DateTimePicker1.Value(), Inicial.DateTimePicker1.Value(), "0", "$0.00", "$0.00", "$0.00", "$0.00", "", "0", "$0.00")
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENTA' Puede moverla o quitarla según sea necesario.
        Me.VENTATableAdapter.FillTOP10(Me.LeoDataSet.VENTA)
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Dio' Puede moverla o quitarla según sea necesario.
        Me.DioTableAdapter.FillTOP5(Me.LeoDataSet.Dio)
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Apartados' Puede moverla o quitarla según sea necesario.
        Me.ApartadosTableAdapter.FillByTOP5(Me.LeoDataSet.Apartados)
        VENTADataGridView.Sort(VENTADataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
        DioDataGridView.Sort(DioDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)

        ABONO.Text = FormatCurrency(BusApartados.dio.Text)
        EFECTIVO.Text = Int(ABONO.Text)
        If Int(BusApartados.RESTARIA.Text) = Int(0) Then
            Entregado.Text = "1"
        End If
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
    End Sub
    Private Sub ImprimirABN()
        ImprimirAbono.Close()
        ImprimirAbono.Show()
        ImprimirAbono.Lab.Text = "1"
        Reimprimir.Show()
        Reimprimir.REIMPRESION.Text = "ABONO"
    End Sub
    Private Sub ABONAR()
        SumaCambio()
        Formato()
        If Entregado.Text = "1" Then
            Me.ApartadosTableAdapter.ModificarEntrega("1", Today.Date, Inicial.hora.Text, BusApartados.FOLIO.Text)
        End If
        Me.DioTableAdapter.InsertarDio(ABONO.Text, Inicial.DateTimePicker1.Value.Date(), TimeOfDay.ToLongTimeString(), Inicial.VENDEDOR.Text, "0", BusApartados.FOLIO.Text)
        'GUARDAR VENTA
        Me.VENTATableAdapter.Modificar(Inicial.VENDEDOR.Text, Inicial.DateTimePicker1.Value.Date(), Inicial.hora.Text, "0", EfectivoCaja.Text, tarjeta1.Text, efectivo1.Text, credito1.Text, NOTAS.Text, REFERENCIA.Text, Abono1.Text, idVenta.Text)
        'REPRODUCIR SONIDO
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Aceptar.wav")
        s.Play()
        'Mostrar Inicial
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.PrecIngre.Focus()
    End Sub
    Private Sub SoloGuardar()
        ImprimirAbono.Close()
        ABONAR()
        ImprimirAbono.Show()
        ImprimirAbono.Lab.Text = 2
        ImprimirAbono.Hide()
        Inicial.DatImpre()
        BusApartados.Close()
        Me.Close()
    End Sub
    Private Sub SumaCambio()
        Dim TotPag As Integer
        Dim Camb As Integer
        Dim val8 As Integer = 0
        Int32.TryParse(EFECTIVO.Text, val8)
        Dim val9 As Integer = 0
        Int32.TryParse(TARJETA.Text, val9)
        Dim val10 As Integer = 0
        Int32.TryParse(CREDITO.Text, val10)
        Dim Tot As Integer = 0
        Int32.TryParse(ABONO.Text, Tot)
        TotPag = (val8 + val9 + val10)
        Abono1.Text = FormatCurrency(TotPag)
        Camb = (val8 + val9 + val10 - ABONO.Text)
        cambio.Text = FormatCurrency(Camb)
        'Efectivo en caja
        Dim EfeCaj As Integer
        EfeCaj = (val8 - Camb)
        EfectivoCaja.Text = FormatCurrency(EfeCaj)
    End Sub
    Private Sub Formato()
        Try
            efectivo1.Text = FormatCurrency(EFECTIVO.Text)
        Catch ex As Exception
            efectivo1.Text = "$0.00"
        End Try
        Try
            tarjeta1.Text = FormatCurrency(TARJETA.Text)
        Catch ex As Exception
            tarjeta1.Text = "$0.00"
        End Try
        Try
            credito1.Text = FormatCurrency(CREDITO.Text)
        Catch ex As Exception
            credito1.Text = "$0.00"
        End Try
    End Sub
    Public Sub F2()
        If FormatCurrency(cambio.Text) < Int(0) Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            EFECTIVO.Focus()
        Else
            SoloGuardar()
        End If
    End Sub
    Private Sub AgregarAbono_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
        If (e.KeyCode = Keys.F1) Then
            If FormatCurrency(cambio.Text) < Int(0) Then
                'REPRODUCIR SONIDO
                Dim s As System.Media.SoundPlayer
                s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
                s.Play()
                EFECTIVO.Focus()
            Else
                ABONAR()
                ImprimirABN()
            End If
        End If
        If (e.KeyCode = Keys.F2) Then
            F2()
        End If
        If (e.KeyCode = Keys.F3) Then
            BusApartados.F3()
        End If
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub
    Private Sub EFECTIVO_TextChanged(sender As Object, e As EventArgs) Handles EFECTIVO.TextChanged
        SumaCambio()
        Formato()
    End Sub
    Private Sub cobrar_Click(sender As Object, e As EventArgs) Handles cobrar.Click
        If FormatCurrency(cambio.Text) < Int(0) Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            EFECTIVO.Focus()
        Else
            ABONAR()
            ImprimirABN()
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
    Private Sub TARJETA_TextChanged(sender As Object, e As EventArgs) Handles TARJETA.TextChanged
        LabelRef.Visible = True
        REFERENCIA.Visible = True
        SumaCambio()
        Formato()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        F2()
    End Sub
    Private Sub EFECTIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EFECTIVO.KeyPress
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub TARJETA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TARJETA.KeyPress
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub REFERENCIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles REFERENCIA.KeyPress
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub ApartadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ApartadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApartadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub

    Private Sub EFECTIVO_Click(sender As Object, e As EventArgs) Handles EFECTIVO.Click
        EFECTIVO.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        BusApartados.F3()
    End Sub
End Class