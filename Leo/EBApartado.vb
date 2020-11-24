Public Class EBApartado
    Private Sub EntProd()
        'ENTREGAR PRODUCTO
        Dim IdProd As Single
        Dim PrecI As Single
        Dim Entregado As Boolean
        Dim row As DataGridViewRow = BusApartados.DataGridView1.CurrentRow
            IdProd = CStr(row.Cells(0).Value)
        PrecI = CStr(row.Cells(2).Value)
        Entregado = CStr(row.Cells(3).Value)
        If Entregado = False Then
            BusApartados.ProductosTableAdapter.EntregarProductoApartado(1, Inicial.fecha.Text, Inicial.hora.Text, Inicial.VENDEDOR.Text, IdProd)
            BusApartados.ProductosTableAdapter.MostrarProductos(BusApartados.LeoDataSet.Productos, BusApartados.FOLIO.Text)
            'Restar en DIO
            BusApartados.DioTableAdapter.InsertarDio(-PrecI, Inicial.DateTimePicker1.Value.Date(), TimeOfDay.ToLongTimeString(), Inicial.VENDEDOR.Text, "0", BusApartados.FOLIO.Text)
            'MOSTRAR DIO
            BusApartados.DioTableAdapter.MostrarDio(BusApartados.LeoDataSet.Dio, BusApartados.FOLIO.Text)
            BusApartados.EnCuent()
            BusApartados.OPERACIONES()
            Inicial.SonidoAceptar()
        Else
            Inicial.SonidoError()
        End If

    End Sub
    Private Sub BorrProd()
        'BORRAR PRODUCTO
        Dim IdProd As Single
                Dim row As DataGridViewRow = BusApartados.DataGridView1.CurrentRow
                IdProd = CStr(row.Cells(0).Value)
                BusApartados.ProductosTableAdapter.EliminarProductoApartado(IdProd)
                BusApartados.ProductosTableAdapter.MostrarProductos(BusApartados.LeoDataSet.Productos, BusApartados.FOLIO.Text)
        BusApartados.EnCuent()
        BusApartados.OPERACIONES()
    End Sub

    Private Sub BtnEntregar_Click(sender As Object, e As EventArgs) Handles BtnEntregar.Click
        Try
            EntProd()

            Me.Close()
        Catch Ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            BorrProd()
            Inicial.SonidoAceptar()
            Me.Close()
        Catch Ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub

    Private Sub EBApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim row As DataGridViewRow = BusApartados.DataGridView1.CurrentRow
        Articulo.Text = (row.Cells(1).Value)

    End Sub

    Private Sub EBApartado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class