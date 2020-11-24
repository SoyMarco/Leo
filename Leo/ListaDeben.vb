
Public Class ListaDeben

    Private Sub ListaDeben_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet1.deben' Puede moverla o quitarla según sea necesario.
        Me.DebenTableAdapter.Fill(Me.LeoDataSet1.deben)

    End Sub

    Private Sub DebenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DebenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DebenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet1)

    End Sub
End Class