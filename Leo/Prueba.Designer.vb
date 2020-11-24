<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prueba
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim PrendaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim EntregadoLabel As System.Windows.Forms.Label
        Dim Fecha_entregaLabel As System.Windows.Forms.Label
        Dim Hora_entregaLabel As System.Windows.Forms.Label
        Dim VendedorLabel As System.Windows.Forms.Label
        Dim ApartadoNLabel As System.Windows.Forms.Label
        Dim CanceladoLabel As System.Windows.Forms.Label
        Me.VENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeoDataSet = New Leo.LeoDataSet()
        Me.VENTATableAdapter = New Leo.LeoDataSetTableAdapters.VENTATableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Leo.LeoDataSetTableAdapters.ProductosTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PrendaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.EntregadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Fecha_entregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hora_entregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VendedorTextBox = New System.Windows.Forms.TextBox()
        Me.ApartadoNTextBox = New System.Windows.Forms.TextBox()
        Me.CanceladoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        PrendaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        EntregadoLabel = New System.Windows.Forms.Label()
        Fecha_entregaLabel = New System.Windows.Forms.Label()
        Hora_entregaLabel = New System.Windows.Forms.Label()
        VendedorLabel = New System.Windows.Forms.Label()
        ApartadoNLabel = New System.Windows.Forms.Label()
        CanceladoLabel = New System.Windows.Forms.Label()
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VENTABindingSource
        '
        Me.VENTABindingSource.DataMember = "VENTA"
        Me.VENTABindingSource.DataSource = Me.LeoDataSet
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENTATableAdapter
        '
        Me.VENTATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApartadosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAJATableAdapter = Nothing
        Me.TableAdapterManager.CORTETableAdapter = Nothing
        Me.TableAdapterManager.DioTableAdapter = Nothing
        Me.TableAdapterManager.EntradaSalidaTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosVendidosTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Leo.LeoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDEDORESTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Me.VENTATableAdapter
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.LeoDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(23, 32)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(105, 29)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'PrendaLabel
        '
        PrendaLabel.AutoSize = True
        PrendaLabel.Location = New System.Drawing.Point(23, 58)
        PrendaLabel.Name = "PrendaLabel"
        PrendaLabel.Size = New System.Drawing.Size(44, 13)
        PrendaLabel.TabIndex = 2
        PrendaLabel.Text = "Prenda:"
        '
        'PrendaTextBox
        '
        Me.PrendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Prenda", True))
        Me.PrendaTextBox.Location = New System.Drawing.Point(105, 55)
        Me.PrendaTextBox.Name = "PrendaTextBox"
        Me.PrendaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrendaTextBox.TabIndex = 3
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(23, 84)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 4
        PrecioLabel.Text = "Precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(105, 81)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrecioTextBox.TabIndex = 5
        '
        'EntregadoLabel
        '
        EntregadoLabel.AutoSize = True
        EntregadoLabel.Location = New System.Drawing.Point(23, 112)
        EntregadoLabel.Name = "EntregadoLabel"
        EntregadoLabel.Size = New System.Drawing.Size(59, 13)
        EntregadoLabel.TabIndex = 6
        EntregadoLabel.Text = "Entregado:"
        '
        'EntregadoCheckBox
        '
        Me.EntregadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "Entregado", True))
        Me.EntregadoCheckBox.Location = New System.Drawing.Point(105, 107)
        Me.EntregadoCheckBox.Name = "EntregadoCheckBox"
        Me.EntregadoCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.EntregadoCheckBox.TabIndex = 7
        Me.EntregadoCheckBox.Text = "CheckBox1"
        Me.EntregadoCheckBox.UseVisualStyleBackColor = True
        '
        'Fecha_entregaLabel
        '
        Fecha_entregaLabel.AutoSize = True
        Fecha_entregaLabel.Location = New System.Drawing.Point(23, 141)
        Fecha_entregaLabel.Name = "Fecha_entregaLabel"
        Fecha_entregaLabel.Size = New System.Drawing.Size(76, 13)
        Fecha_entregaLabel.TabIndex = 8
        Fecha_entregaLabel.Text = "fecha entrega:"
        '
        'Fecha_entregaDateTimePicker
        '
        Me.Fecha_entregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "fecha entrega", True))
        Me.Fecha_entregaDateTimePicker.Location = New System.Drawing.Point(105, 137)
        Me.Fecha_entregaDateTimePicker.Name = "Fecha_entregaDateTimePicker"
        Me.Fecha_entregaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_entregaDateTimePicker.TabIndex = 9
        '
        'Hora_entregaLabel
        '
        Hora_entregaLabel.AutoSize = True
        Hora_entregaLabel.Location = New System.Drawing.Point(23, 167)
        Hora_entregaLabel.Name = "Hora_entregaLabel"
        Hora_entregaLabel.Size = New System.Drawing.Size(70, 13)
        Hora_entregaLabel.TabIndex = 10
        Hora_entregaLabel.Text = "hora entrega:"
        '
        'Hora_entregaDateTimePicker
        '
        Me.Hora_entregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "hora entrega", True))
        Me.Hora_entregaDateTimePicker.Location = New System.Drawing.Point(105, 163)
        Me.Hora_entregaDateTimePicker.Name = "Hora_entregaDateTimePicker"
        Me.Hora_entregaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Hora_entregaDateTimePicker.TabIndex = 11
        '
        'VendedorLabel
        '
        VendedorLabel.AutoSize = True
        VendedorLabel.Location = New System.Drawing.Point(23, 192)
        VendedorLabel.Name = "VendedorLabel"
        VendedorLabel.Size = New System.Drawing.Size(56, 13)
        VendedorLabel.TabIndex = 12
        VendedorLabel.Text = "Vendedor:"
        '
        'VendedorTextBox
        '
        Me.VendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Vendedor", True))
        Me.VendedorTextBox.Location = New System.Drawing.Point(105, 189)
        Me.VendedorTextBox.Name = "VendedorTextBox"
        Me.VendedorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VendedorTextBox.TabIndex = 13
        '
        'ApartadoNLabel
        '
        ApartadoNLabel.AutoSize = True
        ApartadoNLabel.Location = New System.Drawing.Point(23, 218)
        ApartadoNLabel.Name = "ApartadoNLabel"
        ApartadoNLabel.Size = New System.Drawing.Size(64, 13)
        ApartadoNLabel.TabIndex = 14
        ApartadoNLabel.Text = "Apartado N:"
        '
        'ApartadoNTextBox
        '
        Me.ApartadoNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ApartadoN", True))
        Me.ApartadoNTextBox.Location = New System.Drawing.Point(105, 215)
        Me.ApartadoNTextBox.Name = "ApartadoNTextBox"
        Me.ApartadoNTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApartadoNTextBox.TabIndex = 15
        '
        'CanceladoLabel
        '
        CanceladoLabel.AutoSize = True
        CanceladoLabel.Location = New System.Drawing.Point(23, 246)
        CanceladoLabel.Name = "CanceladoLabel"
        CanceladoLabel.Size = New System.Drawing.Size(61, 13)
        CanceladoLabel.TabIndex = 16
        CanceladoLabel.Text = "Cancelado:"
        '
        'CanceladoCheckBox
        '
        Me.CanceladoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "Cancelado", True))
        Me.CanceladoCheckBox.Location = New System.Drawing.Point(105, 241)
        Me.CanceladoCheckBox.Name = "CanceladoCheckBox"
        Me.CanceladoCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.CanceladoCheckBox.TabIndex = 17
        Me.CanceladoCheckBox.Text = "CheckBox1"
        Me.CanceladoCheckBox.UseVisualStyleBackColor = True
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn2})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(338, 11)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(629, 234)
        Me.ProductosDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Prenda"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Prenda"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Entregado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Entregado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha entrega"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha entrega"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "hora entrega"
        Me.DataGridViewTextBoxColumn5.HeaderText = "hora entrega"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Vendedor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Vendedor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ApartadoN"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ApartadoN"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Cancelado"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Cancelado"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'Prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 450)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(PrendaLabel)
        Me.Controls.Add(Me.PrendaTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(EntregadoLabel)
        Me.Controls.Add(Me.EntregadoCheckBox)
        Me.Controls.Add(Fecha_entregaLabel)
        Me.Controls.Add(Me.Fecha_entregaDateTimePicker)
        Me.Controls.Add(Hora_entregaLabel)
        Me.Controls.Add(Me.Hora_entregaDateTimePicker)
        Me.Controls.Add(VendedorLabel)
        Me.Controls.Add(Me.VendedorTextBox)
        Me.Controls.Add(ApartadoNLabel)
        Me.Controls.Add(Me.ApartadoNTextBox)
        Me.Controls.Add(CanceladoLabel)
        Me.Controls.Add(Me.CanceladoCheckBox)
        Me.Name = "Prueba"
        Me.Text = "Prueba"
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents VENTABindingSource As BindingSource
    Friend WithEvents VENTATableAdapter As LeoDataSetTableAdapters.VENTATableAdapter
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As LeoDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents PrendaTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents EntregadoCheckBox As CheckBox
    Friend WithEvents Fecha_entregaDateTimePicker As DateTimePicker
    Friend WithEvents Hora_entregaDateTimePicker As DateTimePicker
    Friend WithEvents VendedorTextBox As TextBox
    Friend WithEvents ApartadoNTextBox As TextBox
    Friend WithEvents CanceladoCheckBox As CheckBox
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
End Class
