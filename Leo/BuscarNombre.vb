Public Class BuscarNombre
    Private Sub BuscarNombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MOSTRAR
        Me.ApartadosTableAdapter.FiltrarApartados(LeoDataSet.Apartados, 0, 0, 0)
        ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(1), direction:=ComponentModel.ListSortDirection.Ascending)
        'NUMERO DE ARTICULOS
        NProductos.Text = ApartadosDataGridView.RowCount
    End Sub
    Private Sub CerrarBM()
        Try
            Inicial.WindowState = FormWindowState.Maximized
            Me.Close()
        Catch ex As Exception
            Inicial.WindowState = FormWindowState.Maximized
            Me.Close()
        End Try
    End Sub
    Private Sub EnterApar()
        Try
            Me.ApartadosTableAdapter.FillUnCliente(LeoDataSet.Apartados, ComboBox1.Text, LabEntreg.Text, LabCancel.Text, LabSacado.Text)
            ComboBox1.Focus()
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub
    Private Sub IdCelda()
        'MOSTRAR CELDA SELECCIONADA
        Dim ID As Single
        Dim rowC As DataGridViewRow = ApartadosDataGridView.CurrentRow
        ID = CStr(rowC.Cells(0).Value)
        IdApartado.Text = ID
        'NUMERO DE ARTICULOS
        NProductos.Text = ApartadosDataGridView.RowCount
    End Sub
    Private Sub AbrirF12()
        If IdApartado.Text > "0" Then
            BusApartados.Show()
            BusApartados.MOSTRAR()
            Me.Close()
        Else
            Inicial.SonidoError()
        End If
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        CerrarBM()
    End Sub
    Private Sub BuscarNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            CerrarBM()
        End If
        If (e.KeyCode = Keys.Enter) Then
            EnterApar()
        End If
        If (e.KeyCode = Keys.F12) Then
            AbrirF12()
        End If
        If (e.KeyCode = Keys.F10) Then
            SacarApartados.Show()
            Me.Close()
        End If
    End Sub
    Private Sub ApartadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ApartadosDataGridView.CellContentClick
        IdCelda()
    End Sub
    Private Sub ApartadosDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ApartadosDataGridView.DoubleClick
        IdCelda()
    End Sub
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FiltrClieBtn.Click
        Try
            ApartadosTableAdapter.MostarApartadoPorCliente(LeoDataSet.Apartados, ComboBox1.Text)
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CanceladoBtn.Click
        Try
            Me.ApartadosTableAdapter.FiltrarApartados(LeoDataSet.Apartados, 0, 0, 1)
            ApartadosDataGridView.Sort(DataGridViewTextBoxColumn1, direction:=ComponentModel.ListSortDirection.Descending)
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
        LabEntreg.Text = "0"
        LabCancel.Text = "1"
        LabSacado.Text = "0"
        ComboBox1.Focus()
        RecuperarBtn.Visible = True
        CancelarBtn.Visible = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        'BORRAR PRODUCTO
        Try
            Dim resultado = MsgBox("Deseas CANCELARLO?", vbOKCancel, "CANCELAR APARTADO")
            If resultado = vbOK Then
                Me.ApartadosTableAdapter.CancelApart("1", Today.Date, IdApartado.Text)
                Me.ApartadosTableAdapter.FiltrarApartados(LeoDataSet.Apartados, 0, 0, 0)
                ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Descending)
            End If
        Catch EX As Exception
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles MosTodBtn.Click
        'MOSTRAR TODOS
        Me.ApartadosTableAdapter.Fill(LeoDataSet.Apartados)
        ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Descending)
        ComboBox1.Focus()
        RecuperarBtn.Visible = False
        CancelarBtn.Visible = False
    End Sub
    Private Sub RecuperarBtn_Click(sender As Object, e As EventArgs) Handles RecuperarBtn.Click
        'BORRAR PRODUCTO
        Try
            Me.ApartadosTableAdapter.CancelApart("0", Today.Date, IdApartado.Text)
            'MOSTRAR
            Me.ApartadosTableAdapter.FiltrarApartados(LeoDataSet.Apartados, 0, 0, 0)
            ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Descending)
        Catch EX As Exception
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        End Try
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles EntregadoBtn.Click
        Try
            Me.ApartadosTableAdapter.FiltrarApartados(LeoDataSet.Apartados, 1, 0, 0)
            ApartadosDataGridView.Sort(DataGridViewTextBoxColumn1, direction:=ComponentModel.ListSortDirection.Descending)
        Catch ex As Exception
            Inicial.SonidoError()
        End Try
        LabEntreg.Text = "0"
        LabCancel.Text = "0"
        LabSacado.Text = "1"
        ComboBox1.Focus()
        RecuperarBtn.Visible = False
        CancelarBtn.Visible = False
    End Sub
    Private Sub VencidosBtn_Click(sender As Object, e As EventArgs) Handles VencidosBtn.Click
        SacarApartados.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        'MOSTRAR
        Me.ApartadosTableAdapter.FiltrarApartados(LeoDataSet.Apartados, 0, 0, 0)
        ApartadosDataGridView.Sort(ApartadosDataGridView.Columns(0), direction:=ComponentModel.ListSortDirection.Descending)
        LabEntreg.Text = "0"
        LabCancel.Text = "0"
        LabSacado.Text = "0"
        ComboBox1.Focus()
        RecuperarBtn.Visible = False
        CancelarBtn.Visible = True
    End Sub
    Private Sub ApartadosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ApartadosDataGridView.CellClick
        IdCelda()
    End Sub
    Private Sub IdApartado_TextChanged(sender As Object, e As EventArgs) Handles IdApartado.TextChanged
        Me.ProductosTableAdapter.MostrarProductos(LeoDataSet.Productos, IdApartado.Text)
    End Sub
    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirF12()
    End Sub
    Private Sub ApartadosDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ApartadosDataGridView.SelectionChanged
        Try
            IdCelda()
        Catch ex As Exception
        End Try
    End Sub
End Class