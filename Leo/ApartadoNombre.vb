Public Class ApartadoNombre
    Private Sub ApartadoNombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.Apartados' Puede moverla o quitarla según sea necesario.
        Me.ApartadosTableAdapter.NombSinDup(Me.LeoDataSet.Apartados)
        ClienteComboBox.ValueMember = "Cliente"

        ClienteComboBox.Text = ""
        ClienteComboBox.Focus()
    End Sub
    Public Sub CERRARVENTANA()
        Inicial.WindowState = FormWindowState.Maximized
        Inicial.PrecIngre.Focus()
        Me.Close()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        CERRARVENTANA()
    End Sub
    Private Sub EnterProd()
        If Trim(ClienteComboBox.Text) <> "" Then
            Napartado.Show()

            Me.Hide()
        Else
            ClienteComboBox.Focus()
            'REPRODUCIR SONIDO
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
            s.Play()
        End If

    End Sub
    Private Sub NombreApartado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            CERRARVENTANA()
        End If

        If (e.KeyCode = Keys.Enter) Then
            EnterProd()
        End If

        If (e.KeyCode = Keys.F12) Then
            EnterProd()
        End If
    End Sub

    Private Sub ClienteComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClienteComboBox.SelectedIndexChanged

    End Sub

    Private Sub ClienteComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ClienteComboBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            EnterProd()
        End If

        If (e.KeyCode = Keys.Escape) Then
            CERRARVENTANA()
        End If
    End Sub

    Private Sub ApartadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ApartadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApartadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EnterProd()
    End Sub
End Class