Public Class EnCaja
    Private Sub CAJABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CAJABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CAJABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub EnCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub CAJA()
        Me.CAJATableAdapter.InsertarEnCaja("CAJA", CajaBox.Text, Inicial.VENDEDOR.Text, Date.Today, TimeOfDay)
        Me.CAJATableAdapter.Fill(LeoDataSet.CAJA)
        Inicial.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        CajaBox.Text = "0.00"
        CAJA()
    End Sub
    Private Sub EnCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            CajaBox.Text = "0.00"
            CAJA()
        End If
        If (e.KeyCode = Keys.Enter) Then
            CAJA()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CAJA()
    End Sub
    Private Sub CajaBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CajaBox.KeyPress
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
End Class