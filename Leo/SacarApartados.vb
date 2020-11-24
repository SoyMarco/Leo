Public Class SacarApartados
    Private Sub ApartadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ApartadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApartadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub Operaciones()
        Try
            'SUMAR COLUMNA DIO
            Dim TotalDIO As Single
            Dim ColDIO As Integer = Me.DioDataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DioDataGridView.Rows
                TotalDIO += Val(row.Cells(0).Value)
            Next
            Me.ACuenta.Text = FormatCurrency(TotalDIO.ToString)
        Catch ex As Exception
            ACuenta.Text = "$0.00"
        End Try
    End Sub
    Private Sub Sacar()
        Try
            If IdProd.Text > 0 Then
                ApartadosTableAdapter.SacarApartado(1, IdProd.Text)
                Me.ApartadosTableAdapter.MostrarApartadosPorSacar(Me.LeoDataSet.Apartados, "0", "0", Date.Today, "0")
                ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
                Inicial.SonidoAceptar()
                IdCelda()
            End If
        Catch es As Exception
            Inicial.SonidoError()
        End Try
    End Sub
    Private Sub Desglosar()
        IdCelda()
        Try
            ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, IdProd.Text)
            DioTableAdapter.MostrarDio(LeoDataSet.Dio, IdProd.Text)
            Operaciones()
        Catch EX As Exception
            Inicial.SonidoError()
        End Try
        'NUMERO DE ARTICULOS
        NProductos.Text = ApartadosDataGridView.RowCount
    End Sub
    Private Sub BtnEnter()
        If Folio.Text <> "" Then
            Me.ApartadosTableAdapter.MostrarApartado(Me.LeoDataSet.Apartados, Folio.Text)
            IdProd.Text = Folio.Text
            Desglosar()
            Folio.Text = ""
            Folio.Focus()
        End If
    End Sub
    Private Sub SacarApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ApartadosTableAdapter.MostrarApartadosPorSacar(Me.LeoDataSet.Apartados, "0", "0", Date.Today, "0")
        ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
        'NUMERO DE ARTICULOS
        NProductos.Text = ApartadosDataGridView.RowCount
    End Sub
    Private Sub IdCelda()
        Try
            'MOSTRAR CELDA SELECCIONADA
            Dim ID As Single
            Dim rowC As DataGridViewRow = ApartadosDataGridView.CurrentRow
            ID = CStr(rowC.Cells(0).Value)
            IdProd.Text = ID
        Catch EX As Exception
            IdProd.Text = "0"
        End Try
        'MOSTRAR CELDA SELECCIONADA
        Try
            Dim ID2 As Date
            Dim row As DataGridViewRow = ApartadosDataGridView.CurrentRow
            ID2 = CStr(row.Cells(2).Value)
            FECHA.Text = ID2
        Catch EX As Exception
            FECHA.Text = "0"
        End Try
    End Sub
    Private Sub ApartadosDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ApartadosDataGridView.DoubleClick
        Desglosar()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.PrecIngre.Focus()
        Me.Close()
    End Sub
    Private Sub SacarApartados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()

            Me.Close()
        End If
        If (e.KeyCode = Keys.Delete) Then
            Sacar()
        End If
        If (e.KeyCode = Keys.Enter) Then
            BtnEnter()
        End If
    End Sub
    Private Sub ApartadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ApartadosDataGridView.CellContentClick
        Desglosar()
    End Sub
    Private Sub ApartadosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ApartadosDataGridView.CellClick
        Desglosar()
    End Sub
    Private Sub SacadoBtn_Click(sender As Object, e As EventArgs) Handles SacadoBtn.Click
        Try
            Me.ApartadosTableAdapter.FiltrarApartados(LeoDataSet.Apartados, "0", "1", "0")
            ApartadosDataGridView.Sort(DataGridViewTextBoxColumn1, direction:=ComponentModel.ListSortDirection.Descending)

            IdCelda()
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub
    Private Sub IdProd_TextChanged(sender As Object, e As EventArgs) Handles IdProd.TextChanged
        Desglosar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRecuperar.Click
        Try
            If IdProd.Text > 0 Then
                ApartadosTableAdapter.SacarApartado(0, IdProd.Text)
                Me.ApartadosTableAdapter.MostrarApartadosPorSacar(Me.LeoDataSet.Apartados, "0", "0", Date.Today, "0")
                ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
                Inicial.SonidoAceptar()
                IdCelda()

            End If
        Catch es As Exception
            Inicial.SonidoError()
        End Try
    End Sub
    Private Sub VencidosBtn_Click(sender As Object, e As EventArgs) Handles VencidosBtn.Click
        Me.ApartadosTableAdapter.MostrarApartadosPorSacar(Me.LeoDataSet.Apartados, "0", "0", Date.Today, "0")
        ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
        IdCelda()
    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnSacar.Click
        Sacar()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Folio_TextChanged(sender As Object, e As EventArgs) Handles Folio.TextChanged

    End Sub

    Private Sub Folio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Folio.KeyPress
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
End Class