Imports System.IO
Public Class Corte
    Public Sub GuardarCorte()
        Me.CORTETableAdapter.InsertarCorte(VENDEDOR.Text, CajaInicial.Text, VENTA.Text, TARJETA.Text, VentaTotal.Text, EfectivoCaja.Text, SOBRA.Text, fecha.Text, hora.Text, EntradasSalidas.Text)
    End Sub
    Private Sub Operaciones()
        'VENTA TOTAL
        Dim Vent As Decimal
        Dim val1 As Decimal
        val1 = VENTA.Text
        Dim val2 As Decimal
        val2 = TARJETA.Text
        Vent = (val1 + val2)
        VentaTotal.Text = FormatCurrency(Vent)
        'TOTAL EN CAJA
        Dim Tot As Decimal
        Dim val3 As Decimal
        val3 = CajaInicial.Text
        Dim val4 As Decimal
        val4 = VENTA.Text
        Dim valES As Decimal
        valES = EntradasSalidas.Text
        Tot = (val3 + val4 + valES)
        TotalCaja.Text = FormatCurrency(Tot)
        'SOBRA
        Try
            Dim Sobr As Decimal
            Dim valor5 As Decimal
            valor5 = EfectivoCaja.Text
            Dim valor6 As Decimal
            valor6 = TotalCaja.Text
            Sobr = (valor5 - valor6)
            SOBRA.Text = FormatCurrency(Sobr)
        Catch ex As Exception
            SOBRA.Text = "$0.00"
        End Try
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Inicial.Show()
        Inicial.PrecIngre.Focus()
        Me.Close()
    End Sub
    Private Sub Corte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EfectivoCaja.Focus()
        VENDEDOR.Text = Inicial.VENDEDOR.Text
        fecha.Text = Inicial.fecha.Text
        'CARGAR DATOS VENTA DEL DIA
        VENTATableAdapter.MostrarVentasFiltros3(LeoDataSet.VENTA, VENDEDOR.Text, Today.Date, "0")
        'SUMAR EFECTIVO DEL DIA
        Try
            Dim Efect As Single
            Dim Col As Integer = Me.VENTADataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.VENTADataGridView.Rows
                Efect += Val(row.Cells(1).Value)
            Next
            Me.VENTA.Text = FormatCurrency(Efect.ToString)
        Catch ex As Exception
            Me.VENTA.Text = "$0.00"
        End Try
        'SUMAR VENTA TARJETA DEL DIA
        Try
            Dim Tarj As Single
            Dim Col2 As Integer = Me.VENTADataGridView.CurrentCell.ColumnIndex
            For Each row2 As DataGridViewRow In Me.VENTADataGridView.Rows
                Tarj += Val(row2.Cells(2).Value)
            Next
            Me.TARJETA.Text = FormatCurrency(Tarj.ToString)
        Catch ex As Exception
            Me.TARJETA.Text = "$0.00"
        End Try
        'CARGAR DATOS CAJA INICIAL
        Me.CAJATableAdapter.MostrarCorteHoy(LeoDataSet.CAJA, VENDEDOR.Text, fecha.Text)
        'SUMAR EFECTIVO DEL DIA
        Try
            Dim CajaIn As Single
            Dim Col3 As Integer = Me.CAJADataGridView.CurrentCell.ColumnIndex
            For Each row3 As DataGridViewRow In Me.CAJADataGridView.Rows
                CajaIn += Val(row3.Cells(1).Value)
            Next
            Me.CajaInicial.Text = FormatCurrency(CajaIn.ToString)
        Catch ex As Exception
            Me.CajaInicial.Text = "$0.00"
        End Try
        'CARGAR DATOS CAJA INICIAL
        Me.EntradaSalidaTableAdapter.MostrarEntradasSalidas(LeoDataSet.EntradaSalida, VENDEDOR.Text, Inicial.fecha.Text)
        'SUMAR ENTRADAS Y SALIDAS DEL DIA
        Try
            Dim EntSal As Single
            Dim Col4 As Integer = Me.EntradaSalidaDataGridView.CurrentCell.ColumnIndex
            For Each row4 As DataGridViewRow In Me.EntradaSalidaDataGridView.Rows
                EntSal += Val(row4.Cells(1).Value)
                If EntSal > 0 Then
                    EntradasSalidas.ForeColor = Color.Green
                Else
                    EntradasSalidas.ForeColor = Color.Red
                End If
            Next
            Me.EntradasSalidas.Text = FormatCurrency(EntSal.ToString)
        Catch ex As Exception
            Me.EntradasSalidas.Text = "$0.00"
        End Try
        Operaciones()
        Me.EfectivoCaja.Focus()
    End Sub
    Private Sub Corte_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Inicial.Show()
            Inicial.PrecIngre.Focus()
            Me.Close()
        End If
    End Sub
    Private Sub VENTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENTABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeoDataSet)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay
    End Sub
    Private Sub EfectivoCaja_TextChanged(sender As Object, e As EventArgs) Handles EfectivoCaja.TextChanged
        Operaciones()
    End Sub
    Private Sub EfectivoCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EfectivoCaja.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        RegistroTotalVentas.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MENSAJE BOX 
        Try
            Dim resultado = MsgBox("DESEAS CERRAR TÚ TURNO?", vbOKCancel, "CERRAR TURNO")
            If resultado = vbOK Then
                GuardarCorte()
                Ingreso.Show()
                Inicial.VENTADataGridView.Rows.Remove(Inicial.VENTADataGridView.CurrentRow)
                If Venta2.IdVenta.Text <> "" Then
                    Venta2.VENTADataGridView.Rows.Remove(Venta2.VENTADataGridView.CurrentRow)
                End If
                Inicial.Close()
                Venta2.Close()
                Ingreso.CONTRASEÑA.Text = ""
                Ingreso.VENDEDORESComboBox.Text = ""
                Ingreso.VENDEDORESComboBox.Focus()
                Ingreso.RespaldoDB()
                Me.Close()
            End If
        Catch EX As Exception
            EfectivoCaja.Text = "$0.00"
            GuardarCorte()
            Ingreso.Show()
            Inicial.Close()
            Ingreso.CONTRASEÑA.Text = ""
            Ingreso.VENDEDORESComboBox.Text = ""
            Ingreso.VENDEDORESComboBox.Focus()
            Me.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Apagar.Show()
        Ingreso.RespaldoDB()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ingreso.RespaldoDB()
    End Sub
    Private Sub SOBRA_TextChanged(sender As Object, e As EventArgs) Handles SOBRA.TextChanged
        If Int(SOBRA.Text) < Int(0) Then
            SOBRA.ForeColor = Color.Red
        Else
            SOBRA.ForeColor = Color.Green
        End If
    End Sub
End Class