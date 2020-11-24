Public Class FolioApartado
    Private Sub BuscarFolio()
        If Folio.Text = "" Then
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
            Folio.Focus()
        Else
            BusApartados.Show()
        End If
    End Sub
    Private Sub Folio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Folio.KeyPress
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
            BuscarFolio()         ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BuscarNombre.Show()
        Me.Close()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Inicial.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
    Private Sub FolioApartado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Inicial.WindowState = FormWindowState.Maximized
            Me.Close()
        End If
        If (e.KeyCode = Keys.Enter) Then
            BuscarFolio()
        End If
        If (e.KeyCode = Keys.F10) Then
            BuscarNombre.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarFolio()
    End Sub
End Class