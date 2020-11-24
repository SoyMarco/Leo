Public Class GRIDDio
    Private Sub GRIDDio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Apartados' Puede moverla o quitarla según sea necesario.
        Me.ApartadosTableAdapter.MostrarApartado(LeoDataSet.Apartados, Inicial.IdApartado.Text)

        ABONO.Text = FormatCurrency(Inicial.PrecApartado.Text)
    End Sub

    Private Sub BtnEntregar_Click(sender As Object, e As EventArgs) Handles BtnEntregar.Click
        Me.Close()
    End Sub
    Private Sub BorrarDio()
        Inicial.DioTableAdapter.EliminarAbonoApartado(Inicial.IdDio.Text)
        Inicial.ProductosVendidosTableAdapter.EliminarProductoVenta(Inicial.IdProd.Text)
        Inicial.F3()
        Me.Close()
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        BorrarDio()
    End Sub

    Private Sub GRIDDio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            BorrarDio()
        End If
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
        If (e.KeyCode = Keys.Delete) Then
            BorrarDio()
        End If
    End Sub

    Private Sub ApartadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ApartadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApartadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)

    End Sub
End Class