Public Class Apagar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim L As Integer
        L = CUENTA.Text
        CUENTA.Text = (L - 1)
    End Sub

    Private Sub CUENTA_TextChanged(sender As Object, e As EventArgs) Handles CUENTA.TextChanged
        If CUENTA.Text = "5" Then
            Corte.WindowState = FormWindowState.Minimized
        End If
        If CUENTA.Text = "0" Then
            Corte.EfectivoCaja.Text = "0.00"
            Corte.GuardarCorte()
            Inicial.VENTADataGridView.Rows.Remove(Inicial.VENTADataGridView.CurrentRow)
            If Venta2.IdVenta.Text <> "" Then
                Venta2.VENTADataGridView.Rows.Remove(Venta2.VENTADataGridView.CurrentRow)
            End If
            Inicial.Close()
            Venta2.Close()
            System.Diagnostics.Process.Start("SHUTDOWN", "-S")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CANCEL()
    End Sub

    Private Sub CANCEL()
        Timer1.Stop()
        Corte.Show()
        Me.Close()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        CANCEL()
    End Sub
    Private Sub Apagar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            CANCEL()
        End If
    End Sub

    Private Sub Apagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class