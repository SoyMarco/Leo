Public Class Prueba
    Private Sub VENTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)

    End Sub

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.LeoDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENTA' Puede moverla o quitarla según sea necesario.
        Me.VENTATableAdapter.Fill(Me.LeoDataSet.VENTA)

    End Sub


End Class