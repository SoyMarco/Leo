Public Class Venta2
    Private Sub AgregarProducto()
        If Trim(PrecIngre.Text) <> "" And PrecIngre.Text <> "0" Then
            If PRECIO.Text <> "$0.00" Then
                Try
                    Me.ProductosVendidosTableAdapter.InsertarProductoVendido(PRODUCTO.Text, PrecIngre.Text, Inicial.fecha.Text, Inicial.hora.Text, Inicial.VENDEDOR.Text, IdVenta.Text, 0, "1")
                    Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, IdVenta.Text)
                    'SUMAR COLUMNA DE PRECIOS PRODUCTOS
                    Dim Total As Single
                    Dim Col As Integer = Me.ProductosVendidosDataGridView.CurrentCell.ColumnIndex
                    For Each row As DataGridViewRow In Me.ProductosVendidosDataGridView.Rows
                        Total += Val(row.Cells(2).Value)
                    Next
                    Me.TOTAL.Text = FormatCurrency(Total.ToString)
                    'NUMERO DE ARTICULOS
                    NProductos.Text = ProductosVendidosDataGridView.RowCount
                Finally
                    'LIMPIAR TEXTBOX PRECIO              
                    PrecIngre.Text = ""
                    PRODUCTO.Text = "PRODUCTO"
                    PrecIngre.Focus()
                    'DataGrid Centrar ULTIMA CELDA
                    Dim cell As DataGridViewCell = ProductosVendidosDataGridView.CurrentCell
                    cell = ProductosVendidosDataGridView.Rows(ProductosVendidosDataGridView.RowCount - 1).Cells(cell.ColumnIndex)
                    ProductosVendidosDataGridView.CurrentCell = cell
                    'Mostrar celda seleccionada
                    IdCelda()
                End Try
            Else
                PRECIO.Text = ""
                PrecIngre.Text = ""
            End If
        End If
    End Sub
    Private Sub F12()
        If NProductos.Text > "0" Then
            Cobro.Show()
            'COPIAR DATOS
            Cobro.TOTAL.Text = FormatCurrency(TOTAL.Text)
            Cobro.EFECTIVO.Text = Int(TOTAL.Text)
            Cobro.EFECTIVO.SelectAll()
            Cobro.SumaCambio()
            Cobro.Ventana.Text = 2
        End If
    End Sub
    Private Sub BorrarProducto()
        IdCelda()
        If IdProd.Text <> "0" And Trim(IdProd.Text) <> "" Then
            Me.ProductosVendidosTableAdapter.EliminarProductoVenta(IdProd.Text)
            Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, IdVenta.Text)
        End If
        Try
            'SUMAR COLUMNA DE PRECIOS PRODUCTOS
            Dim Total As Single
            Dim Col As Integer = Me.ProductosVendidosDataGridView.CurrentCell.ColumnIndex
            For Each row1 As DataGridViewRow In Me.ProductosVendidosDataGridView.Rows
                Total += Val(row1.Cells(2).Value)
            Next
            Me.TOTAL.Text = FormatCurrency(Total.ToString)
            'NUMERO DE ARTICULOS
            NProductos.Text = ProductosVendidosDataGridView.RowCount
        Catch ex As Exception
            Me.TOTAL.Text = "$0.00"
            NProductos.Text = "0"
            IdProd.Text = "0"
        End Try
        PrecIngre.Focus()
        'DataGrid Centrar ULTIMA CELDA
        Try
            Dim cell As DataGridViewCell = ProductosVendidosDataGridView.CurrentCell
            cell = ProductosVendidosDataGridView.Rows(ProductosVendidosDataGridView.RowCount - 1).Cells(cell.ColumnIndex)
            ProductosVendidosDataGridView.CurrentCell = cell
            IdCelda()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CerrarV2()
        Me.VENTADataGridView.Rows.Remove(VENTADataGridView.CurrentRow)
        Inicial.PrecIngre.Focus()
        Me.Close()
    End Sub
    Private Sub Venta2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrecIngre.Focus()
        Me.VENTATableAdapter.InsertarVenta(Inicial.VENDEDOR.Text, Inicial.DateTimePicker1.Value(), Inicial.DateTimePicker1.Value(), "0", "$0.00", "$0.00", "$0.00", "$0.00", "", "0", "$0.00")
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENTA' Puede moverla o quitarla según sea necesario.
        Me.VENTATableAdapter.FillTOP10(Me.LeoDataSet.VENTA)
        VENTADataGridView.Sort(VENTADataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Ascending)
        Dim cell As DataGridViewCell = VENTADataGridView.CurrentCell
        cell = VENTADataGridView.Rows(VENTADataGridView.RowCount - 2).Cells(cell.ColumnIndex)
        VENTADataGridView.CurrentCell = cell
        Dim ID As Single
        Dim rowCU As DataGridViewRow = VENTADataGridView.CurrentRow
        ID = CStr(rowCU.Cells(0).Value)
        IdVenta.Text = ID
        Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, IdVenta.Text)
    End Sub
    Private Sub AgregarUnoMas()
        If IdProd.Text > "0" Then
            Dim UMas As Single
            Dim CurRow As DataGridViewRow = ProductosVendidosDataGridView.CurrentRow
            UMas = CStr(CurRow.Cells(2).Value)
            PrecIngre.Text = UMas
            AgregarProducto()
        End If
    End Sub
    Private Sub Venta2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F12) Then
            F12()
        End If
        If (e.KeyCode = Keys.Enter) Then
            AgregarProducto()
            PrecIngre.Focus()
        End If
        If (e.KeyCode = Keys.Delete) Then
            BorrarProducto()
        End If
        If (e.KeyCode = Keys.Escape) Then
            CerrarV2()
        End If
        If (e.KeyCode = Keys.Subtract) Then
            BorrarProducto()
        End If
        If (e.KeyCode = Keys.Add) Then
            AgregarUnoMas()
        End If
        If (e.KeyCode = Keys.Up) Then
            ProductosVendidosDataGridView.Focus()
        End If
        If (e.KeyCode = Keys.Down) Then
            ProductosVendidosDataGridView.Focus()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AgregarProducto()
        PrecIngre.Focus()
    End Sub
    Private Sub PrecIngre_TextChanged(sender As Object, e As EventArgs) Handles PrecIngre.TextChanged
        Try
            If PrecIngre.Text <> "" Then
                If PrecIngre.Text <> "0" Then
                    PRECIO.Text = FormatCurrency(PrecIngre.Text)
                End If
            End If
        Catch ex As Exception
            PRECIO.Text = "$0.00"
        End Try
    End Sub
    Private Sub ProductosVendidosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosVendidosDataGridView.CellContentClick
        IdCelda()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BorrarProducto()
    End Sub
    Private Sub IdCelda()
        'MOSTRAR CELDA SELECCIONADA
        Dim ID As Single
        Dim rowCU As DataGridViewRow = ProductosVendidosDataGridView.CurrentRow
        ID = CStr(rowCU.Cells(0).Value)
        IdProd.Text = ID
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        F12()
    End Sub
    Private Sub ProductosVendidosDataGridView_Click(sender As Object, e As EventArgs) Handles ProductosVendidosDataGridView.Click
        IdCelda()
    End Sub
    Private Sub cerrar_Click_1(sender As Object, e As EventArgs) Handles cerrar.Click
        CerrarV2()
    End Sub
    Private Sub PrecIngre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecIngre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not PrecIngre.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub ProductosVendidosDataGridView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductosVendidosDataGridView.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            PrecIngre.Focus()
        End If
    End Sub
End Class