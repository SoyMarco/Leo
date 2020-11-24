Public Class ImprimirAbono
    Private Sub ImprimirAbono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CLIENTE.Text = BusApartados.NomCliente.Text
        VENDEDOR.Text = Inicial.VENDEDOR.Text
        FECHA.Text = Inicial.DateTimePicker1.Value.Date()
        HORA.Text = Inicial.hora.Text
        RESTABA.Text = BusApartados.RESTA.Text
        ABONO.Text = FormatCurrency(AgregarAbono.ABONO.Text)
        RESTA.Text = BusApartados.RESTARIA.Text
        FOLIO.Text = BusApartados.FOLIO.Text
        CAMBIO.Text = AgregarAbono.cambio.Text
        NArticulos.Text = BusApartados.ARTICULOS.Text
        VENCE.Text = BusApartados.DateTimePicker1.Value.ToShortDateString
        Timer1.Enabled = True
        Me.DioTableAdapter.MostrarDio(LeoDataSet.Dio, FOLIO.Text)
        Me.DioDataGridView.RowHeadersVisible = False
        Me.Focus()
        Dim rwheight As Integer = DioDataGridView.Rows(0).Height
        Dim totalht As Integer = rwheight * (BusApartados.NAbono.Text + 2)
        Me.DioDataGridView.Height = totalht
        Me.AutoSize = True
        Me.Height += 60
        GeneradorCodigo()
    End Sub
    Private Sub GeneradorCodigo()
        If FOLIO.Text <> Nothing Then
            Try
                pictBarcode.Image = Code128Rendering.MakeBarcodeImage(FOLIO.Text, 1, True)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            MessageBox.Show("Please input number or text in textbox to generate to barcode.")
        End If
    End Sub
    Private Sub Lab_TextChanged(sender As Object, e As EventArgs) Handles Lab.TextChanged
        If Lab.Text = "1" Then
            PrintForm()
        End If
    End Sub
    Private Sub PrintForm()
        Try
            Cursor.Current = Cursors.WaitCursor
            With Me.PrintForm1
                Dim ALTO As Integer
                ALTO = Me.Height + 11
                .PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(11, 27, 39, 1)
                .PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.High
                .PrinterSettings.DefaultPageSettings.PaperSize = New Printing.PaperSize("personalizado", 224, ALTO)
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End With
            Cursor.Current = Cursors.Default
            'imprimir productos
            ImprimirArticulos.Close()
            ImprimirArticulos.Show()
            ImprimirArticulos.Lab.Text = "1"
            'CERRAR VENTANAS
            FolioApartado.Close()
            BuscarNombre.Close()
            AgregarAbono.Close()
            BusApartados.Close()
            AgregarProductoAApartado.Close()
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.DatImpre()
            Reimprimir.Button1.Focus()
            Me.Hide()
            Timer1.Stop()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub DioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DioDataGridView.CellContentClick

    End Sub
End Class