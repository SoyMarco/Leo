Imports System.IO
Public Class RegistroTotalVentas
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Cerrar()
    End Sub
    Private Sub Operaciones()
        'NUMERO DE ARTICULOS
        ARTICULOS.Text = VENTADataGridView.RowCount
        'SUMAR TOTAL
        Try
            Dim Tot As Double
            Dim Col As Integer = Me.VENTADataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.VENTADataGridView.Rows
                Tot += Val(row.Cells(6).Value)
            Next
            Me.TOTAL.Text = FormatCurrency(Tot.ToString)
        Catch EX As Exception
        End Try
        Try
            Dim Tot As Double
            Dim Col As Integer = Me.VENTADataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.VENTADataGridView.Rows
                Tot += Val(row.Cells(2).Value)
            Next
            Me.EFECTIVO.Text = FormatCurrency(Tot.ToString)
        Catch EX As Exception
        End Try
        Try
            Dim Tot As Double
            Dim Col As Integer = Me.VENTADataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.VENTADataGridView.Rows
                Tot += Val(row.Cells(3).Value)
            Next
            Me.TARJETA.Text = FormatCurrency(Tot.ToString)
        Catch EX As Exception
        End Try
        Try
            Dim Tot As Double
            Dim Col As Integer = Me.VENTADataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.VENTADataGridView.Rows
                Tot += Val(row.Cells(4).Value)
            Next
            Me.PAGO.Text = FormatCurrency(Tot.ToString)
        Catch EX As Exception
        End Try
        Try
            Dim Tot As Double
            Dim Col As Integer = Me.VENTADataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.VENTADataGridView.Rows
                Tot += Val(row.Cells(5).Value)
            Next
            Me.APARTADO.Text = FormatCurrency(Tot.ToString)
        Catch EX As Exception
        End Try


    End Sub


    Private Sub RegistroTotalVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENTA' Puede moverla o quitarla según sea necesario.
        Me.VENTATableAdapter.Fill(Me.LeoDataSet.VENTA)
        'TODO: esta línea de código carga datos en la tabla 'LeoDataSet.VENDEDORES' Puede moverla o quitarla según sea necesario.
        Me.VENDEDORESTableAdapter.Fill(Me.LeoDataSet.VENDEDORES)
        Operaciones()


    End Sub
    Private Sub Cerrar()
        Corte.Close()
        Corte.Show()
        Try
            Me.Close()
        Catch ex As Exception
            Me.Close()
        End Try


    End Sub

    Private Sub RegistroTotalVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Cerrar()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.VENTATableAdapter.MostrarVentaVendedor(LeoDataSet.VENTA, VENDEDOR.Text, FInicio.Value, FFinal.Value)
        Operaciones()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim BKUP As String
            BKUP = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            If File.Exists(BKUP & "\Leo.accdb") Then
                File.Delete(My.Application.Info.DirectoryPath + "\Leo.accdb")
                File.Copy(BKUP & "\Leo.accdb", My.Application.Info.DirectoryPath + "\Leo.accdb")
                Inicial.SonidoAceptar()
            End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VENTATableAdapter.MostrarVentaFecha(LeoDataSet.VENTA, FInicio.Value, FFinal.Value)
        Operaciones()
    End Sub
End Class