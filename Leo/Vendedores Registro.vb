Public Class Vendedores_Registro
    Private Sub Vendedores_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENDEDORES' Puede moverla o quitarla según sea necesario.
        Me.VENDEDORESTableAdapter.Fill(Me.LeoDataSet.VENDEDORES)

    End Sub
    Private Sub IdCelda()
        Try
            'MOSTRAR CELDA SELECCIONADA
            Dim ID As Single
            Dim rowCU As DataGridViewRow = VENDEDORESDataGridView.CurrentRow
            ID = CStr(rowCU.Cells(0).Value)
            idVendedor.Text = ID
        Catch ex As Exception
            idVendedor.Text = "0"
        End Try
    End Sub
    Private Sub CONTRASEÑA_TextChanged(sender As Object, e As EventArgs) Handles CONTRASEÑA.TextChanged

    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        IdCelda()
        Try
            Me.VENDEDORESTableAdapter.BorrarVendedor(idVendedor.Text)
            Me.VENDEDORESTableAdapter.Fill(LeoDataSet.VENDEDORES)
        Catch ex As Exception
            Label2.Text = "No se borrò"
        End Try
    End Sub

    Private Sub VENDEDORESDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 
        IdCelda()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ingreso.Show()
        Me.Close()
    End Sub

    Private Sub VENDEDORESDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles VENDEDORESDataGridView.CellContentClick
        IdCelda()
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        VENDEDORESTableAdapter.ModificarVendedor(Vendedor.Text, CONTRASEÑA.Text, idVendedor.Text)
        VENDEDORESTableAdapter.Fill(LeoDataSet.VENDEDORES)
    End Sub
End Class