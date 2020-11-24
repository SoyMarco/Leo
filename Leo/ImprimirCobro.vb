Public Class ImprimirCobro
    Private Sub ImprimirCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VENDEDOR.Text = Inicial.VENDEDOR.Text
        FECHA.Text = Inicial.fecha.Text
        HORA.Text = Inicial.hora.Text
        TOTAL.Text = Cobro.TOTAL.Text
        Cambio.Text = Cobro.cambio.Text
        PagoCon.Text = FormatCurrency(Cobro.efectivo1.Text)
        Ticket.Text = Inicial.IdVenta.Text
        NArticulos.Text = Inicial.NProductos.Text
        Timer1.Enabled = True
        'De que ventana?
        If Cobro.Ventana.Text = "1" Then
            Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, Inicial.IdVenta.Text)
        Else
            Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, Venta2.IdVenta.Text)
        End If
        Me.ProductosVendidosDataGridView.RowHeadersVisible = False
        Dim rwheight As Integer = ProductosVendidosDataGridView.Rows(0).Height
        Dim totalht As Integer = rwheight * (Inicial.NProductos.Text + 1)
        Me.ProductosVendidosDataGridView.Height = totalht
        Me.AutoSize = True
        Me.Height += 30
    End Sub
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
    Private Sub CerrarPrin()
        If Cobro.Ventana.Text = 1 Then
            Inicial.Close()
            Inicial.Show()
        End If
        If Cobro.Ventana.Text = 2 Then
            Venta2.Close()
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
            CerrarPrin()
            Cobro.Close()
            Me.Hide()
            Timer1.Stop()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try
    End Sub
    Private Sub ProductosVendidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosVendidosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosVendidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) 

    End Sub
End Class