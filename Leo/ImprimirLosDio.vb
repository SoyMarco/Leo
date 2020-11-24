Public Class ImprimirLosDio
    Private Sub DioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub ImprimirLosDio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FOLIO.Text = ImprimirApartadoCompleto.FOLIO.Text
        Timer1.Enabled = True
        Me.DioTableAdapter.MostrarDio(LeoDataSet.Dio, FOLIO.Text)
        Me.DioDataGridView.RowHeadersVisible = False
        Dim rwheight As Integer = DioDataGridView.Rows(0).Height
        Dim totalht As Integer = rwheight * (ImprimirApartadoCompleto.NArticulos.Text + 1)
        Me.DioDataGridView.Height = totalht
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
End Class