Public Class Napartado
    Private Sub IdCelda()
        'MOSTRAR CELDA SELECCIONADA
        Dim ID As Single
        Dim rowC As DataGridViewRow = ProductosDataGridView.CurrentRow
        ID = CStr(rowC.Cells(0).Value)
        IdProd.Text = ID
    End Sub
    Private Sub AgregarProducto()
        Me.ProductosTableAdapter.InsertarProducto(Pro1.Text, Pre1.Text, "0", Date.Today, Inicial.hora.Text, Inicial.VENDEDOR.Text, IdApartado.Text, "0")
        Me.ProductosTableAdapter.MostrarProductos(Me.LeoDataSet.Productos, IdApartado.Text)
        Pro1.Text = ""
        Pre1.Text = ""
        Pro1.Focus()
        'SUMAR COLUMNA DE PRECIOS PRODUCTOS
        Dim Total As Single
        Dim Col As Integer = Me.ProductosDataGridView.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.ProductosDataGridView.Rows
            Total += Val(row.Cells(2).Value)
        Next
        Me.TOTAL.Text = FormatCurrency(Total.ToString)
        'DataGrid Centrar ULTIMA CELDA
        Dim cell As DataGridViewCell = ProductosDataGridView.CurrentCell
        cell = ProductosDataGridView.Rows(ProductosDataGridView.RowCount - 1).Cells(cell.ColumnIndex)
        ProductosDataGridView.CurrentCell = cell
        'Mostrar celda seleccionada
        IdCelda()
        'NUMERO DE ARTICULOS
        NProductos.Text = ProductosDataGridView.RowCount
    End Sub
    Public Sub CERRARVENTANA()
        Me.ProductosTableAdapter.EliminarProductosNoGuardados(IdApartado.Text)
        ApartadoNombre.Show()
        ApartadoNombre.ClienteComboBox.Focus()
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.ProductosVendidos' Puede moverla o quitarla según sea necesario.
        Me.ProductosVendidosTableAdapter.FillByProdVenSD(Me.LeoDataSet.ProductosVendidos)
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Apartados' Puede moverla o quitarla según sea necesario.
        Me.ApartadosTableAdapter.FillByTOP5(Me.LeoDataSet.Apartados)
        ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
        DateTimePicker2.Value = DateTime.Now.AddMonths(1)
        date111.Text = Date.Today
        DATE222.Text = DateTimePicker2.Value.Date
        PictureBox1.Width = Me.Width
        VENDEDOR.Text = Inicial.VENDEDOR.Text
        CLIENTE.ValueMember = "Cliente"
        CLIENTE.Text = ""
        CLIENTE.Text = ApartadoNombre.ClienteComboBox.Text
        CLIENTE.Enabled = False
        'ULTIMO ID
        Dim cell As DataGridViewCell = ApartadosDataGridView.CurrentCell
        cell = ApartadosDataGridView.Rows(ApartadosDataGridView.RowCount - 1).Cells(cell.ColumnIndex)
        ApartadosDataGridView.CurrentCell = cell
        Dim ID As Single
        Dim rowCU As DataGridViewRow = ApartadosDataGridView.CurrentRow
        ID = CStr(rowCU.Cells(0).Value)
        IdApartado.Text = ID + 1
        ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, IdApartado.Text)
        Pro1.ValueMember = "Producto"
        Pro1.Text = ""
        Me.TopMost = False
    End Sub
    Private Sub BorrarProducto()
        If IdProd.Text <> "0" And Trim(IdProd.Text) <> "" Then
            IdCelda()
            Me.ProductosTableAdapter.EliminarProductoApartado(IdProd.Text)
            Me.ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, IdApartado.Text)
            'DataGrid Centrar ULTIMA CELDA
            Try
                Dim cell As DataGridViewCell = ProductosDataGridView.CurrentCell
                cell = ProductosDataGridView.Rows(ProductosDataGridView.RowCount - 1).Cells(cell.ColumnIndex)
                ProductosDataGridView.CurrentCell = cell
                IdCelda()
            Catch ex As Exception
            End Try
        End If
        Try
            'SUMAR COLUMNA DE PRECIOS PRODUCTOS
            Dim Total As Single
            Dim Col As Integer = Me.ProductosDataGridView.CurrentCell.ColumnIndex
            For Each row9 As DataGridViewRow In Me.ProductosDataGridView.Rows
                Total += Val(row9.Cells(2).Value)
            Next
            Me.TOTAL.Text = FormatCurrency(Total.ToString)
            'NUMERO DE ARTICULOS
            NProductos.Text = ProductosDataGridView.RowCount
        Catch ex As Exception
            Me.TOTAL.Text = "$0.00"
            NProductos.Text = "0"
            IdProd.Text = "0"
        End Try
        Pro1.Focus()
    End Sub
    Private Sub F12Cobrar()
        If CLIENTE.Text = "" Then
            CLIENTE.Focus()
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        End If
        If Trim(TOTAL.Text) = "$0.00" Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        Else
            If NProductos.Text <> "0" Then
                If Trim(CLIENTE.Text) <> "" Then
                    ApartadoDio.Show()

                    Me.Hide()
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        CERRARVENTANA()
    End Sub
    Private Sub Pre1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pre1.KeyPress
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
    Private Sub dio_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    Private Sub Napartado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            CERRARVENTANA()
        End If
        If (e.KeyCode = Keys.Delete) Then
            BorrarProducto()
        End If
        If (e.KeyCode = Keys.F12) Then
            F12Cobrar()
        End If
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs)
        F12Cobrar()
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DATE222.Text = DateTimePicker2.Value.Date
    End Sub
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub Pre1_TextChanged(sender As Object, e As EventArgs) Handles Pre1.TextChanged
        If Pro1.Text = "" Then
            Pre1.Text = ""
        End If
    End Sub
    Private Sub Pre1_KeyDown(sender As Object, e As KeyEventArgs) Handles Pre1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If Pre1.Text <> "" Then
                AgregarProducto()
            End If
        End If
    End Sub
    Private Sub ProductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick
        IdCelda()
    End Sub
    Private Sub CREDITO_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F12Cobrar()
    End Sub
    Private Sub CLIENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles CLIENTE.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Pro1.Focus()
        End If
    End Sub
    Private Sub Pro1_KeyDown(sender As Object, e As KeyEventArgs) Handles Pro1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If Trim(Pro1.Text) <> "" Then
                Pre1.Focus()
            Else
                If TOTAL.Text <> "$0.00" Then
                    F12Cobrar()
                End If
            End If
        End If
    End Sub
End Class