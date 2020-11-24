Public Class SalidaDinero
    Private Sub SalidaDinero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub SALIDA()
        Me.EntradaSalidaTableAdapter.InsertarEntradaSalida(-(EFECTIVO.Text), Inicial.VENDEDOR.Text, Inicial.fecha.Text, Inicial.hora.Text, MOTIVO.Text)
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.PrecIngre.Focus()
        Me.Close()
    End Sub
    Private Sub EnCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()
            Me.Close()
        End If
    End Sub
    Private Sub EFECIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EFECTIVO.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub EntradaSalidaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EntradaSalidaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EntradaSalidaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SALIDA()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Inicial.PrecIngre.Focus()
        Me.Close()
    End Sub
    Private Sub EFECTIVO_KeyDown(sender As Object, e As KeyEventArgs) Handles EFECTIVO.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            MOTIVO.Focus()
        End If
    End Sub
    Private Sub MOTIVO_TextChanged(sender As Object, e As EventArgs) Handles MOTIVO.TextChanged
    End Sub
    Private Sub MOTIVO_KeyDown(sender As Object, e As KeyEventArgs) Handles MOTIVO.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SALIDA()
        End If
    End Sub
End Class