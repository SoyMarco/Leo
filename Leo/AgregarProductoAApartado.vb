Public Class AgregarProductoAApartado
    Private Sub AgregarProductoAApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.ProductosVendidos' Puede moverla o quitarla según sea necesario.
        Me.ProductosVendidosTableAdapter.FillByProdVenSD(Me.LeoDataSet.ProductosVendidos)
        Pro1.Text = ""
    End Sub
    Private Sub AgregarProducto()
        If Trim(Pre1.Text) <> "" And Trim(pro1.Text) <> "" Then
            BusApartados.ProductosTableAdapter.InsertarProducto(pro1.Text, Pre1.Text, "0", Inicial.DateTimePicker1.Value, Inicial.hora.Text, Inicial.VENDEDOR.Text, BusApartados.FOLIO.Text, "0")
            BusApartados.ProductosTableAdapter.MostrarProductos(BusApartados.LeoDataSet.Productos, BusApartados.FOLIO.Text)
            BusApartados.EnCuent()
            BusApartados.OPERACIONES()
            Me.Close()
        Else
            Inicial.SonidoError()
        End If
    End Sub
    Private Sub AgregarProductoAApartado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
        If (e.KeyCode = Keys.F1) Then
            AgregarProducto()
        End If
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub
    Private Sub Pre1_TextChanged(sender As Object, e As EventArgs) Handles Pre1.TextChanged
        If pro1.Text = "" Then
            Pre1.Text = ""
        End If
    End Sub
    Private Sub Pre1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pre1.KeyPress
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
            AgregarProducto()         ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AgregarProducto()
    End Sub
    Private Sub pro1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub ProductosVendidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosVendidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub Pro1_KeyDown(sender As Object, e As KeyEventArgs) Handles Pro1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If Trim(Pro1.Text) <> "" Then
                Pre1.Focus()
            Else
                'REPRODUCIR SONIDO
                Dim s As System.Media.SoundPlayer
                s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
                s.Play()
            End If
        End If
    End Sub
End Class