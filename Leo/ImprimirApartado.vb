
Public Class ImprimirApartado
    Private Sub ImprimirApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FOLIO.Text = Napartado.IdApartado.Text
        VENDEDOR.Text = Inicial.VENDEDOR.Text
        FECHA.Text = Inicial.fecha.Text
        HORA.Text = Inicial.hora.Text
        TOTAL.Text = Napartado.TOTAL.Text
        ABONO.Text = FormatCurrency(apartadocobro.ABONO.Text)
        RESTA.Text = ApartadoDio.resta.Text
        CLIENTE.Text = Napartado.CLIENTE.Text
        NArticulos.Text = Napartado.NProductos.Text
        Timer1.Enabled = True
        VENCE.Text = Napartado.DATE222.Text
        Me.ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, Napartado.IdApartado.Text)
        Me.ProductosDataGridView.RowHeadersVisible = False
        Dim rwheight As Integer = ProductosDataGridView.Rows(0).Height
        Dim totalht As Integer = rwheight * (Napartado.NProductos.Text + 1)
        Me.ProductosDataGridView.Height = totalht
        Me.AutoSize = True
        Me.Height += 30
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
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
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
    Private Sub PrintForm()
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
        'CERRAR VENTANAS
        ApartadoNombre.Close()
        ApartadoCobro.Close()
        ApartadoDio.Close()
        Napartado.Close()
        Inicial.WindowState = FormWindowState.Maximized
        Reimprimir.Button1.Focus()
        Me.Hide()
        Timer1.Stop()
    End Sub
End Class