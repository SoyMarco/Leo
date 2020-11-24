Imports System.Runtime.InteropServices.ComTypes

Public Class BusApartados
    Public Sub MOSTRAR()
        Button1.Visible = True
        Me.ApartadosTableAdapter.MostrarApartado(Me.LeoDataSet.Apartados, FOLIO.Text)
        'MOSTRAR PRODUCTOS
        Me.ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, FOLIO.Text)
        'MOSTRAR DIO
        Me.DioTableAdapter.MostrarDio(LeoDataSet.Dio, FOLIO.Text)
        'APARTADO VENCIDO
        If Inicial.DateTimePicker1.Value > Me.DateTimePicker1.Value Then
            VENCIDLABEL.Visible = True
        End If
        'SUMAR COLUMNA DE PRECIOS PRODUCTOS
        Try
            Dim Total As Double
            Dim Col As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                Total += Val(row.Cells(2).Value)
            Next
            Me.TOTAL.Text = FormatCurrency(Total.ToString)
        Catch ex As Exception
            TOTAL.Text = "$0.00"
        End Try
        'CONTAR PRODUCTOS ACTUALES
        ARTICULOS.Text = DataGridView1.RowCount - 1
        'SUMAR COLUMNA DIO
        Try
            Dim TotalDIO As Single
            Dim ColDIO As Integer = Me.DioDataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DioDataGridView.Rows
                TotalDIO += Val(row.Cells(1).Value)
            Next
            Me.ACuenta.Text = FormatCurrency(TotalDIO.ToString)
        Catch ex As Exception
            ACuenta.Text = "SIN ARTICULOS"
        End Try
        Try
            'OPERACION "RESTA"
            RESTA.Text = FormatCurrency(Me.TOTAL.Text - ACuenta.Text)
            FOLIO.ReadOnly = True
            dio.Focus()
        Catch EX As Exception
            RESTA.Text = "SIN ARTICULOS"
            FOLIO.ReadOnly = True
        End Try
    End Sub
    Public Sub EnCuent()
        'MOSTRAR DIO MAYOR A 0
        Me.DioTableAdapter.MostrarDioM0(LeoDataSet.Dio, FOLIO.Text)
        Try
            'SUMAR COLUMNA DIO
            Dim TotalDIO As Single
            Dim ColDIO As Integer = Me.DioDataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DioDataGridView.Rows
                TotalDIO += Val(row.Cells(1).Value)
            Next
            Me.EnCuentas.Text = FormatCurrency(TotalDIO.ToString)
            Me.DioTableAdapter.MostrarDio(LeoDataSet.Dio, FOLIO.Text)
        Catch ex As Exception
            EnCuentas.Text = "$0.00"
        End Try

    End Sub
    Public Sub OPERACIONES()
        Try
            'SUMAR ENTREGADOS
            Dim Llev As Integer
            Dim Collev As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                Llev += Val(row.Cells(3).Value)
            Next
            Llevados.Text = Int(Llev)
        Catch ex As Exception
            Llevados.Text = "$0.00"
        End Try
        Try
            'SUMAR COLUMNA DE PRECIOS PRODUCTOS
            Dim Total As Integer
            Dim Col As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                Total += Val(row.Cells(2).Value)
            Next
            Me.TOTAL.Text = FormatCurrency(Total.ToString)
        Catch ex As Exception
            TOTAL.Text = "$0.00"
        End Try
        Try
            'CONTAR PRODUCTOS ACTUALES
            ARTICULOS.Text = DataGridView1.RowCount - 1
        Catch ex As Exception
            ARTICULOS.Text = "0"
        End Try
        Try
            'CONTAR ABONOS
            NAbono.Text = DioDataGridView.RowCount - 1
        Catch ex As Exception
            NAbono.Text = "0"
        End Try
        Try
            'SUMAR COLUMNA DIO
            Dim TotalDIO As Single
            Dim ColDIO As Integer = Me.DioDataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DioDataGridView.Rows
                TotalDIO += Val(row.Cells(1).Value)
            Next
            Me.ACuenta.Text = FormatCurrency(TotalDIO.ToString)
        Catch ex As Exception
            ACuenta.Text = "$0.00"
        End Try
        Try
            'OPERACION "RESTA"
            RESTA.Text = FormatCurrency(Me.TOTAL.Text - EnCuentas.Text)
            FOLIO.ReadOnly = True
        Catch ex As Exception
            RESTA.Text = "$0.00"
        End Try
        'OPERACION RESTARIA
        Try
            RESTARIA.Text = FormatCurrency(RESTA.Text - dio.Text)
        Catch EX As Exception
            RESTARIA.Text = FormatCurrency(-RESTA.Text)
        End Try
        If NomCliente.Text = "" Then
            Inicial.SonidoError()
            FolioApartado.Show()
            Me.Close()
        End If
    End Sub
    Private Sub BorrDio()
        Try
            'BORRAR DIO
            Dim res = MsgBox("BORRAR ABONO DEFINITIVAMENTE?", vbOKCancel, "BORRAR")
            If res = vbOK Then
                Dim IdPro As Single
                Dim row As DataGridViewRow = DioDataGridView.CurrentRow
                IdPro = CStr(row.Cells(0).Value)
                Me.DioTableAdapter.EliminarAbonoApartado(IdPro)
                Me.DioTableAdapter.MostrarDio(LeoDataSet.Dio, FOLIO.Text)
                'SUMAR COLUMNA DIO
                Dim TotalDIO As Single
                Dim ColDIO As Integer = Me.DioDataGridView.CurrentCell.ColumnIndex
                For Each rowU As DataGridViewRow In Me.DioDataGridView.Rows
                    TotalDIO += Val(rowU.Cells(1).Value)
                Next
                Me.ACuenta.Text = FormatCurrency(TotalDIO.ToString)
                RESTA.Text = FormatCurrency(Me.TOTAL.Text - ACuenta.Text)
                EnCuent()
                OPERACIONES()
            End If
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub
    Public Sub F3()
        'AGREGAR A INICIAL Y NO SUMAR EN CORTE
        If Int(RESTARIA.Text) < Int(0) Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            dio.Focus()
        Else
            AgregarAbono.Show()
            Inicial.ProductosVendidosTableAdapter.InsertVentApart("APARTADO", dio.Text, Inicial.fecha.Text, Inicial.hora.Text, Inicial.VENDEDOR.Text, Inicial.IdVenta.Text, 0, "1", FOLIO.Text, AgregarAbono.idDio.Text)

            Inicial.F3()
            AgregarAbono.EFECTIVO.Text = ""
            AgregarAbono.CREDITO.Text = dio.Text
            AgregarAbono.F2()
        End If
    End Sub
    Private Sub BusApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FOLIO.Text = FolioApartado.Folio.Text
            DATE222.Text = DateTimePicker1.Value.ToShortDateString
            MOSTRAR()
            FolioApartado.Close()
            EnCuent()
            OPERACIONES()
        Catch ex As Exception
            FOLIO.Text = BuscarNombre.IdApartado.Text
            DATE222.Text = DateTimePicker1.Value.ToShortDateString
            MOSTRAR()
            FolioApartado.Close()
            EnCuent()
            OPERACIONES()
        End Try
    End Sub
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.PrecIngre.Focus()
        ApartadoNombre.Close()
        AgregarProductoAApartado.Close()
        Me.Close()
    End Sub
    Private Sub EnterAbono()
        If Int(RESTARIA.Text) < Int(0) Then
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            dio.Focus()
        Else
            AgregarAbono.Show()
        End If
    End Sub
    Private Sub F12()
        dio.Text = FormatNumber(RESTA.Text, 0)
        EnterAbono()

    End Sub
    Private Sub BusApartados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()
            ApartadoNombre.Close()
            AgregarProductoAApartado.Close()
            Me.Close()
        End If

        If (e.KeyCode = Keys.Enter) Then
            EnterAbono()
        End If
        If (e.KeyCode = Keys.F12) Then
            F12()
        End If
        If (e.KeyCode = Keys.F1) Then
            ImprimirApartadoCompleto.Show()
        End If
        If (e.KeyCode = Keys.F3) Then
            F3()
        End If
    End Sub
    Private Sub ApartadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ApartadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApartadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles BotonMostrar.Click
        MOSTRAR()
    End Sub
    Private Sub FOLIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FOLIO.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub ENTREGADO_CheckedChanged(sender As Object, e As EventArgs) Handles ENTREGADO.CheckedChanged
        If ENTREGADO.Checked = True Then
            ENTREGADOTEXT.Visible = True
            FechaEntrehado.Visible = True
            HoraEntregado.Visible = True
        End If
        If ENTREGADO.Checked = False Then
            ENTREGADOTEXT.Visible = False
            FechaEntrehado.Visible = False
            HoraEntregado.Visible = False
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        'ENTREGAR PRODUCTO
        Dim resultado = MsgBox("Deseas ENTREGARLO?", vbOKCancel, "ENTREGAR PRODUCTO")
        If resultado = vbOK Then
            Dim IdProd As Single
            Dim PrecI As Single
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            IdProd = CStr(row.Cells(0).Value)
            PrecI = CStr(row.Cells(2).Value)
            Me.ProductosTableAdapter.EntregarProductoApartado(1, Inicial.fecha.Text, Inicial.hora.Text, Inicial.VENDEDOR.Text, IdProd)
            Me.ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, FOLIO.Text)
            'Restar en DIO
            Me.DioTableAdapter.InsertarDio(-PrecI, Inicial.DateTimePicker1.Value.Date(), TimeOfDay.ToLongTimeString(), Inicial.VENDEDOR.Text, "0", FOLIO.Text)
            'MOSTRAR DIO
            Me.DioTableAdapter.MostrarDio(LeoDataSet.Dio, FOLIO.Text)
            OPERACIONES()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'BORRAR PRODUCTO
        Try
            Dim resU = MsgBox("BORRAR PRODUCTO DEFINITIVAMENTE?", vbOKCancel, "BORRAR")
            If resU = vbOK Then
                Dim IdProd As Single
                Dim row As DataGridViewRow = DataGridView1.CurrentRow
                IdProd = CStr(row.Cells(0).Value)
                Me.ProductosTableAdapter.EliminarProductoApartado(IdProd)
                Me.ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, FOLIO.Text)
                OPERACIONES()
            End If
        Catch EX As Exception
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FOLIO.ReadOnly = True Then
            AgregarProductoAApartado.Show()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        BorrDio()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EnterAbono()
    End Sub
    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Dio_TextChanged(sender As Object, e As EventArgs) Handles dio.TextChanged
        OPERACIONES()
    End Sub
    Private Sub Dio_KeyDown(sender As Object, e As KeyEventArgs) Handles dio.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            EnterAbono()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        BuscarNombre.Show()
        Me.Close()
    End Sub
    Private Sub SacadoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SacadoCheckBox.CheckedChanged
        If SacadoCheckBox.Checked = True Then
            SACADO.Visible = True
        End If
        If SacadoCheckBox.Checked = False Then
            SACADO.Visible = False
        End If
    End Sub
    Private Sub Dio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dio.KeyPress
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
    Private Sub RESTARIA_TextChanged(sender As Object, e As EventArgs) Handles RESTARIA.TextChanged
        If Val(RESTARIA.Text) < 0 Then
            dio.ForeColor = Color.Red
        Else
            dio.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub DateTimePicker1_VisibleChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.VisibleChanged
        TouchCalendar.Text = 1
    End Sub
    Private Sub CancelApart_Click(sender As Object, e As EventArgs) Handles CancelApart.Click
        'BORRAR PRODUCTO
        Try
            Dim resU = MsgBox("¿ES EL FOLIO CORRECTO?", vbOKCancel, "CANCELAR")
            If resU = vbOK Then
                Me.ApartadosTableAdapter.ModificarEntrega("2", Today.Date, Inicial.hora.Text, FOLIO.Text)
                Inicial.WindowState = FormWindowState.Maximized
                Inicial.PrecIngre.Focus()
                Me.Close()
            End If
        Catch EX As Exception
            'REPRODUCIR SONIDO
            Inicial.SonidoError()
        End Try
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        ImprimirApartadoCompleto.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TouchCalendar.Text = "1" Then
            Try
                If DateTimePicker1.Value <> DATE222.Text Then
                    Me.ApartadosTableAdapter.ModificarFechaVencimiento(DateTimePicker1.Value, FOLIO.Text)
                    DATE222.Text = DateTimePicker1.Value.ToShortDateString
                    Inicial.SonidoAceptar()
                End If
            Catch EX As Exception
                'REPRODUCIR SONIDO
                Inicial.SonidoError()
            End Try
        Else
            Inicial.SonidoError()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            'OBTENER VALOR DE CELDA ACTUAL
            Dim art As Integer
            Dim tot As Integer
            art = (ARTICULOS.Text - 1 + Llevados.Text) * 30
            Dim prenda As Single
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            prenda = CStr(row.Cells(2).Value)
            tot = (prenda + art) - ACuenta.Text
            Falta.Text = FormatCurrency(tot)
        Catch EX As Exception
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        End Try
        If FOLIO.Text > "0" Then
            Button3.Visible = True
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ENTREGADO.CheckState = CheckState.Checked Then
            Me.ApartadosTableAdapter.ModificarEntrega(0, Date.Today, Date.Today, FOLIO.Text)
            ENTREGADO.CheckState = CheckState.Unchecked

        Else
            If ENTREGADO.CheckState = CheckState.Unchecked Then
                Me.ApartadosTableAdapter.ModificarEntrega(1, Date.Today, Date.Today, FOLIO.Text)
                ENTREGADO.CheckState = CheckState.Checked

            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If SacadoCheckBox.CheckState = CheckState.Checked Then
            Me.ApartadosTableAdapter.SacarApartado(0, FOLIO.Text)
            SacadoCheckBox.CheckState = CheckState.Unchecked

        Else
            If SacadoCheckBox.CheckState = CheckState.Unchecked Then
                Me.ApartadosTableAdapter.SacarApartado(1, FOLIO.Text)
                SacadoCheckBox.CheckState = CheckState.Checked

            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim id As Integer
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            id = CStr(row.Cells(0).Value)
            If id > 1 Then

                EBApartado.Show()
            End If
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub

    Private Sub DioDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DioDataGridView.CellDoubleClick
        Try
            Dim id As Integer
            Dim row As DataGridViewRow = DioDataGridView.CurrentRow
            id = CStr(row.Cells(0).Value)
            If id > 1 Then
                BorrDio()
            End If
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        F3()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        F12()
    End Sub

    Private Sub DioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DioDataGridView.CellContentClick

    End Sub
End Class