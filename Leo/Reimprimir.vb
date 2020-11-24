Public Class Reimprimir
    Private Sub ImprimirX2()
        If REIMPRESION.Text = "APARTADO" Then
            ImprimirApartado.Show()
            ImprimirApartado.Lab.Text = "0"
            ImprimirApartado.Lab.Text = "1"
            Inicial.PrecIngre.Focus()
            Inicial.OcultarImpre()
            Me.Close()
        End If
        If REIMPRESION.Text = "ABONO" Then
            ImprimirAbono.Show()
            ImprimirAbono.Lab.Text = "0"
            ImprimirAbono.Lab.Text = "1"
            Inicial.PrecIngre.Focus()
            Inicial.OcultarImpre()
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.PrecIngre.Focus()
        ImprimirX2()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.PrecIngre.Focus()
        Inicial.OcultarImpre()
        Me.Close()
    End Sub
    Private Sub Reimprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Focus()
        Me.Button1.Focus()
    End Sub
    Private Sub Reimprimir_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()
            Inicial.OcultarImpre()
            Me.Close()

        End If
        If (e.KeyCode = Keys.Enter) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()
            Me.ImprimirX2()
        End If
        If (e.KeyCode = Keys.F2) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()
            Inicial.OcultarImpre()
            Me.Close()
        End If
        If (e.KeyCode = Keys.F1) Then
            Inicial.WindowState = FormWindowState.Maximized
            Inicial.PrecIngre.Focus()
            Me.ImprimirX2()
        End If
    End Sub
End Class