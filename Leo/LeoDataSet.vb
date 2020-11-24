

Partial Class LeoDataSet
    Partial Public Class VENDEDORESDataTable
        Private Sub VENDEDORESDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.VENDEDORColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace LeoDataSetTableAdapters
    Partial Public Class VENTATableAdapter
    End Class

    Partial Public Class ApartadosTableAdapter
    End Class
End Namespace

Namespace LeoDataSetTableAdapters
    Partial Public Class ProductosVendidosTableAdapter
    End Class
End Namespace
