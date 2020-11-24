Imports System.IO
Public Class Inicial
    Public Sub SonidoError()
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
        s.Play()
    End Sub
    Private Sub IdCelda()
        Try
            'MOSTRAR CELDA SELECCIONADA
            Dim ID As Single
            Dim rowCU As DataGridViewRow = ProductosVendidosDataGridView.CurrentRow
            ID = CStr(rowCU.Cells(0).Value)
            IdProd.Text = ID
        Catch ex As Exception
            IdProd.Text = "0"
        End Try
        Try
            'MOSTRAR CELDA SELECCIONADA    ID abono
            Dim iDio As Single
            Dim rowCU As DataGridViewRow = ProductosVendidosDataGridView.CurrentRow
            iDio = CStr(rowCU.Cells(6).Value)
            IdDio.Text = iDio
        Catch ex As Exception
            IdDio.Text = "0"
        End Try
        Try
            'MOSTRAR CELDA SELECCIONADA    ID APARTADO
            Dim iDApar As Single
            Dim rowCU As DataGridViewRow = ProductosVendidosDataGridView.CurrentRow
            iDApar = CStr(rowCU.Cells(5).Value)
            IdApartado.Text = iDApar
        Catch ex As Exception
            IdApartado.Text = "0"
        End Try
        Try
            'MOSTRAR CELDA SELECCIONADA    ID APARTADO
            Dim Prec As Single
            Dim rowCU As DataGridViewRow = ProductosVendidosDataGridView.CurrentRow
            Prec = CStr(rowCU.Cells(3).Value)
            PrecApartado.Text = Prec
        Catch ex As Exception
            PrecApartado.Text = "0"
        End Try
    End Sub
    Public Sub F3()
        Try
            Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, IdVenta.Text)
            'SUMAR COLUMNA DE PRECIOS PRODUCTOS
            Dim Total As Single
            Dim Col As Integer = Me.ProductosVendidosDataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.ProductosVendidosDataGridView.Rows
                Total += Val(row.Cells(3).Value)
            Next
            Me.TOTAL.Text = FormatCurrency(Total.ToString)
            'NUMERO DE ARTICULOS
            NProductos.Text = ProductosVendidosDataGridView.RowCount
            'FOCUS
            PrecIngre.Focus()
            'DataGrid Centrar ULTIMA CELDA
            Dim cell As DataGridViewCell = ProductosVendidosDataGridView.CurrentCell
            cell = ProductosVendidosDataGridView.Rows(ProductosVendidosDataGridView.RowCount - 1).Cells(cell.ColumnIndex)
            ProductosVendidosDataGridView.CurrentCell = cell
            'Mostrar celda seleccionada
            IdCelda()
        Catch ex As Exception
            Me.TOTAL.Text = "$0.00"
            NProductos.Text = "0"
            IdProd.Text = "0"
        End Try
    End Sub
    Private Sub AgregarProducto()
        If Trim(PrecIngre.Text) <> "" And PrecIngre.Text <> "0" Then
            If PRECIO.Text <> "$0.00" Then
                Try
                    Me.ProductosVendidosTableAdapter.InsertarProductoVendido(PRODUCTO.Text, PrecIngre.Text, fecha.Text, hora.Text, VENDEDOR.Text, IdVenta.Text, 0, "1")
                    Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, IdVenta.Text)
                    'SUMAR COLUMNA DE PRECIOS PRODUCTOS
                    Dim Total As Single
                    Dim Col As Integer = Me.ProductosVendidosDataGridView.CurrentCell.ColumnIndex
                    For Each row As DataGridViewRow In Me.ProductosVendidosDataGridView.Rows
                        Total += Val(row.Cells(3).Value)
                    Next
                    Me.TOTAL.Text = FormatCurrency(Total.ToString)
                    'NUMERO DE ARTICULOS
                    NProductos.Text = ProductosVendidosDataGridView.RowCount
                Finally
                    'LIMPIAR TEXTBOX PRECIO              
                    PrecIngre.Text = ""
                    PRODUCTO.Text = "PROD"
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
    Private Sub AgregarUnoMas()
        If IdProd.Text > "0" Then
            Dim UMas As Single
            Dim CurRow As DataGridViewRow = ProductosVendidosDataGridView.CurrentRow
            UMas = CStr(CurRow.Cells(3).Value)
            PrecIngre.Text = UMas
            AgregarProducto()
        End If
    End Sub
    Public Sub OcultarImpre()
        ImprimirAbono.Hide()
        ImprimirApartado.Hide()
        ImprimirApartadoCompleto.Hide()
        ImprimirCobro.Hide()
        ImprimirLosDio.Hide()
    End Sub

    Private Sub BorrarProducto()
        IdCelda()
        'probar si es un abono
        If IdDio.Text = "0" Then
            If IdProd.Text <> "0" And Trim(IdProd.Text) <> "" Then
                Me.ProductosVendidosTableAdapter.EliminarProductoVenta(IdProd.Text)
                Me.ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, IdVenta.Text)
            End If
            Try
                'SUMAR COLUMNA DE PRECIOS PRODUCTOS
                Dim Total As Single
                Dim Col As Integer = Me.ProductosVendidosDataGridView.CurrentCell.ColumnIndex
                For Each row1 As DataGridViewRow In Me.ProductosVendidosDataGridView.Rows
                    Total += Val(row1.Cells(3).Value)
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
        Else
            SonidoError()
            GRIDDio.Show()
        End If
    End Sub
    Public Sub SonidoAceptar()
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Aceptar.wav")
        s.Play()
    End Sub

    Private Sub Cerrar_Click_2(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay
    End Sub
    Public Sub DatosReImpre()
        Dim DaIm As DataGridViewCell = VENTADataGridView.CurrentCell
        DaIm = VENTADataGridView.Rows(VENTADataGridView.RowCount - 3).Cells(DaIm.ColumnIndex)
        VENTADataGridView.CurrentCell = DaIm
        Dim IdRI As Single
        Dim rowCU As DataGridViewRow = VENTADataGridView.CurrentRow
        IdRI = CStr(rowCU.Cells(0).Value)
        IdUltVent.Text = IdRI
    End Sub
    Public Sub DatImpre()
        'DATOS DE REIMPRESION
        'APARTADO
        Try
            Me.NombreApartado.Text = ImprimirApartado.CLIENTE.Text
            Me.TotalApartado.Text = FormatCurrency(ImprimirApartado.TOTAL.Text)
            Me.PagoConApartado.Text = FormatCurrency(ImprimirApartado.ABONO.Text)
            Me.CambioApartado.Text = FormatCurrency(ImprimirApartado.RESTA.Text)
        Catch ex As Exception
        End Try
        'ABONO
        Try
            NombreAbono.Text = ImprimirAbono.CLIENTE.Text
            TotalAbono.Text = FormatCurrency(ImprimirAbono.RESTABA.Text)
            PagoConAbono.Text = FormatCurrency(ImprimirAbono.ABONO.Text)
            CambioAbono.Text = FormatCurrency(ImprimirAbono.RESTA.Text)
        Catch ex As Exception
        End Try
        'VENTA
        Try
            TotalUltimaV.Text = FormatCurrency(ImprimirCobro.TOTAL.Text)
            PagoConUltimV.Text = FormatCurrency(ImprimirCobro.PagoCon.Text)
            CambioUltimV.Text = FormatCurrency(ImprimirCobro.Cambio.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ReImprAbono()
        DatImpre()
        If TotalAbono.Text = "$0.00" Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        Else
            ImprimirAbono.Show()
            ImprimirAbono.Lab.Text = "0"
            ImprimirAbono.Lab.Text = "1"
            ImprimirAbono.Hide()
        End If
    End Sub
    Public Sub ReImprApart()
        DatImpre()
        If TotalApartado.Text = "$0.00" Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        Else
            ImprimirApartado.Show()
            ImprimirApartado.Lab.Text = "0"
            ImprimirApartado.Lab.Text = "1"
            ImprimirApartado.Hide()
        End If
    End Sub
    Public Sub ReImprventa()
        DatImpre()
        If TotalUltimaV.Text = "$0.00" Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        Else
            ImprimirCobro.Show()
            ImprimirCobro.Lab.Text = "0"
            ImprimirCobro.Lab.Text = "1"
            ImprimirCobro.Hide()
        End If
    End Sub
    Public Sub BorrDio()
        GRIDDio.Show()
    End Sub
    Private Sub Inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Dio' Puede moverla o quitarla según sea necesario.
        Me.DioTableAdapter.Fill(Me.LeoDataSet.Dio)
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Apartados' Puede moverla o quitarla según sea necesario.
        Me.ApartadosTableAdapter.FillByTOP5(Me.LeoDataSet.Apartados)
        PrecIngre.Focus()
        VENDEDOR.Text = Ingreso.VENDEDORLabel1.Text
        Me.VENTATableAdapter.InsertarVenta(VENDEDOR.Text, Today.Date, TimeOfDay.ToLongTimeString(), "0", "$0.00", "$0.00", "$0.00", "$0.00", "", "0", "$0.00")
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
        fecha.Text = Date.Today
        DatImpre()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ApartadoNombre.Show()

        Me.WindowState = FormWindowState.Minimized
        ApartadoNombre.ClienteComboBox.Focus()
    End Sub
    Private Sub F12()
        If NProductos.Text <> "0" Then
            Cobro.Show()
            'COPIAR DATOS
            Cobro.TOTAL.Text = FormatCurrency(TOTAL.Text)
            Cobro.EFECTIVO.Text = Int(TOTAL.Text)
            Cobro.EFECTIVO.SelectAll()
            Cobro.Ventana.Text = 1
            Cobro.SumaCambio()
        End If
    End Sub
    Private Sub Inicial_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F12) Then
            F12()
        End If
        If (e.KeyCode = Keys.F11) Then
            ApartadoNombre.Show()
            ApartadoNombre.ClienteComboBox.Focus()
            Me.WindowState = FormWindowState.Minimized
        End If
        If (e.KeyCode = Keys.F10) Then
            FolioApartado.Show()
            FolioApartado.Folio.Focus()
            Me.WindowState = FormWindowState.Minimized
        End If
        If (e.KeyCode = Keys.F6) Then
            Venta2.Show()
        End If
        If (e.KeyCode = Keys.Enter) Then
            AgregarProducto()
        End If
        If (e.KeyCode = Keys.Delete) Then
            BorrarProducto()
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolioApartado.Show()
        FolioApartado.Folio.Focus()
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Corte.Close()
        Corte.Show()
        Me.Hide()
    End Sub
    Private Sub PRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecIngre.KeyPress
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        F12()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SalidaDinero.Show()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EntradaDinero.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
        SacarApartados.Show()
    End Sub
    Private Sub ReimprimirVenta_Click(sender As Object, e As EventArgs) Handles ReimprimirVenta.Click
        ReImprventa()
    End Sub
    Private Sub ReimprimirApartado_Click(sender As Object, e As EventArgs) Handles ReimprimirApartado.Click
        ReImprApart()
    End Sub
    Private Sub ReimpirmirAbono_Click(sender As Object, e As EventArgs) Handles ReimpirmirAbono.Click
        ReImprAbono()
    End Sub
    Private Sub ProductosVendidosDataGridView_Click(sender As Object, e As EventArgs) Handles ProductosVendidosDataGridView.Click
        IdCelda()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Venta2.Show()
    End Sub
    Private Sub ProductosVendidosDataGridView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductosVendidosDataGridView.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            PrecIngre.Focus()
        End If
    End Sub
    Private Sub Inicial_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        PrecIngre.Focus()
    End Sub
    Private Sub Inicial_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        PrecIngre.Focus()
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        CancelVenta.Show()
        Button13.Visible = False
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ReImprApart()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ReImprventa()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ReImprAbono()
    End Sub
End Class