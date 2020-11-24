Imports System.IO
Public Class Ingreso
    Public Sub RespaldoDB()
        Try
            Dim BKUP As String
            BKUP = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            File.Delete(BKUP & "\Leo.accdb")
            File.Copy("Leo.accdb", BKUP & "\Leo.accdb")
        Catch ex As Exception
            Dim BKUP As String
            BKUP = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            File.Copy("Leo.accdb", BKUP & "\Leo.accdb")
        End Try
    End Sub
    Public Sub SonidoAceptar()
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Aceptar.wav")
        s.Play()
    End Sub
    Public Sub SonidoError()
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Error.wav")
        s.Play()
    End Sub
    Private Function CheckForm(Ingreso As Form) As Form
        For Each f As Ingreso In Application.OpenForms
            If f.Name = Me.Name Then
                Return f
            End If
        Next
        Return Nothing
    End Function
    Private Sub VENDEDORESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENDEDORESBindingNavigatorSaveItem.Click
        Validate()
        VENDEDORESBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(LeoDataSet)
    End Sub
    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RespaldoDB()
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENDEDORES' Puede moverla o quitarla según sea necesario.
        VENDEDORESTableAdapter.Fill(LeoDataSet.VENDEDORES)
    End Sub
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        INGRESAR()
    End Sub
    Private Sub INGRESAR()
        If CONTRASEÑA.Text = CONTRASEÑALabel1.Text And VENDEDORESComboBox.Text = VENDEDORLabel1.Text Then
            Inicial.Show()
            Inicial.WindowState = FormWindowState.Minimized
            EnCaja.Show()
            Inicial.VENDEDOR.Text = VENDEDORESComboBox.Text
            Me.Hide()
        Else
            INCORRECTA.Visible = True
            CONTRASEÑA.Text = ""
            CONTRASEÑA.Focus()
            'REPRODUCIR SONIDO
            SonidoError()
        End If
    End Sub
    Private Sub Ingreso_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            INGRESAR()
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If VENDEDORESComboBox.Text <> "" And CONTRASEÑA.Text <> "" Then
            Dim RES As MsgBoxResult = MsgBox("DESEAS AGREGAR UN NUEVO USUARIO?", MessageBoxButtons.OKCancel)
            If RES = MsgBoxResult.Ok Then
                VENDEDORESTableAdapter.InsertarVendedor(VENDEDORESComboBox.Text, CONTRASEÑA.Text)
                VENDEDORESTableAdapter.Fill(LeoDataSet.VENDEDORES)
            End If
        End If
    End Sub
    Private Sub CONTRASEÑA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CONTRASEÑA.KeyPress
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub VENDEDORESComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VENDEDORESComboBox.KeyPress
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True ' eliminamos el sonido. 
        End If
    End Sub
    Private Sub Imagentitulo_Click(sender As Object, e As EventArgs) Handles Imagentitulo.Click
        BorrarVendedor.Visible = True
    End Sub
    Private Sub BorrarVendedor_Click(sender As Object, e As EventArgs) Handles BorrarVendedor.Click
        Vendedores_Registro.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ListaDeben.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListaDeben.Show()
    End Sub
End Class