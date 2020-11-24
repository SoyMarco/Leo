Public Class ImprimirArticulos
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim L As Integer
        L = Lab.Text
        Lab.Text = (L + 1)
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
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.DatImpre()
            BusApartados.Close()
            Me.Hide()
            Timer1.Stop()
            ImprimirApartadoCompleto.Close()
            Me.Close()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ImprimirArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FOLIO.Text = ImprimirAbono.FOLIO.Text

        Me.ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, FOLIO.Text)
        Me.ProductosDataGridView.RowHeadersVisible = False
        Dim rwheight As Integer = ProductosDataGridView.Rows(0).Height
        Dim totalht As Integer = rwheight * (ImprimirAbono.NArticulos.Text + 1)
        Me.ProductosDataGridView.Height = totalht
        Me.AutoSize = True
        Me.Height += 40
        Timer1.Enabled = True
    End Sub
End Class