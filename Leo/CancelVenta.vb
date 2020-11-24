Public Class CancelVenta
    Private Sub VENTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENTABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub CancelVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGAR DATOS VENTA DEL DIA
        Me.VENTATableAdapter.MostrarVentasFiltros3(LeoDataSet.VENTA, Inicial.VENDEDOR.Text, Today.Date, "0")
        VENTADataGridView.Sort(DataGridViewTextBoxColumn1, direction:=ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        If Label3.Text <> "$0.00" Then
            VENTATableAdapter.CancelVenta("1", IdVenta.Text)
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            Me.VENTATableAdapter.MostrarVentasFiltros3(LeoDataSet.VENTA, Inicial.VENDEDOR.Text, Today.Date, "0")
        End If
    End Sub
    Private Sub Recuperar_Click(sender As Object, e As EventArgs) Handles Recuperar.Click
        If Label3.Text <> "$0.00" Then
            VENTATableAdapter.CancelVenta("0", IdVenta.Text)
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Aceptar.wav")
            s.Play()
            Me.VENTATableAdapter.MostrarVentasFiltros3(LeoDataSet.VENTA, Inicial.VENDEDOR.Text, Today.Date, "1")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.VENTATableAdapter.MostrarVentasFiltros3(LeoDataSet.VENTA, Inicial.VENDEDOR.Text, Today.Date, "1")
        Titulo.Text = "RECUPERAR VENTA"
        Recuperar.Visible = True
        Cancelar.Visible = False
    End Sub
    Private Sub CancelVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.Button13.Visible = True
            Inicial.PrecIngre.Focus()
            Me.Close()
        End If
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.Button13.Visible = True
        Inicial.PrecIngre.Focus()
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.VENTATableAdapter.MostrarVentasFiltros3(LeoDataSet.VENTA, Inicial.VENDEDOR.Text, Today.Date, "0")
        VENTADataGridView.Sort(DataGridViewTextBoxColumn1, direction:=ComponentModel.ListSortDirection.Descending)
        Titulo.Text = "CANCELAR VENTA"
        Recuperar.Visible = False
        Cancelar.Visible = True
    End Sub
    Private Sub IdVenta_TextChanged(sender As Object, e As EventArgs) Handles IdVenta.TextChanged
        Try
            ProductosVendidosTableAdapter.MostrarProductosVenta(LeoDataSet.ProductosVendidos, IdVenta.Text)
        Catch ex As Exception
        End Try
    End Sub
End Class