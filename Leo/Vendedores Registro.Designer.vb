<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedores_Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.idVendedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Vendedor = New System.Windows.Forms.TextBox()
        Me.VENDEDORESDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeoDataSet = New Leo.LeoDataSet()
        Me.VENDEDORESTableAdapter = New Leo.LeoDataSetTableAdapters.VENDEDORESTableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        CType(Me.VENDEDORESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Borrar
        '
        Me.Borrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Borrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.ForeColor = System.Drawing.Color.White
        Me.Borrar.Location = New System.Drawing.Point(580, 158)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(210, 32)
        Me.Borrar.TabIndex = 57272
        Me.Borrar.Text = "BORRAR"
        Me.Borrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(476, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 57271
        Me.Label1.Text = "VENDEDOR"
        '
        'CONTRASEÑA
        '
        Me.CONTRASEÑA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CONTRASEÑA.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTRASEÑA.Location = New System.Drawing.Point(580, 54)
        Me.CONTRASEÑA.Margin = New System.Windows.Forms.Padding(1)
        Me.CONTRASEÑA.Name = "CONTRASEÑA"
        Me.CONTRASEÑA.Size = New System.Drawing.Size(210, 33)
        Me.CONTRASEÑA.TabIndex = 57269
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(476, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 57270
        Me.Label8.Text = "CONTRASEÑA"
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.ForeColor = System.Drawing.Color.White
        Me.Modificar.Location = New System.Drawing.Point(580, 253)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(210, 32)
        Me.Modificar.TabIndex = 57273
        Me.Modificar.Text = "MODIFICAR"
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'Agregar
        '
        Me.Agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.ForeColor = System.Drawing.Color.White
        Me.Agregar.Location = New System.Drawing.Point(580, 206)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(210, 32)
        Me.Agregar.TabIndex = 57274
        Me.Agregar.Text = "AGREGAR"
        Me.Agregar.UseVisualStyleBackColor = False
        '
        'idVendedor
        '
        Me.idVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idVendedor.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idVendedor.Location = New System.Drawing.Point(580, 102)
        Me.idVendedor.Margin = New System.Windows.Forms.Padding(1)
        Me.idVendedor.Name = "idVendedor"
        Me.idVendedor.Size = New System.Drawing.Size(210, 33)
        Me.idVendedor.TabIndex = 57275
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(476, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 57276
        Me.Label2.Text = "ID"
        '
        'Vendedor
        '
        Me.Vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vendedor.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendedor.Location = New System.Drawing.Point(580, 12)
        Me.Vendedor.Margin = New System.Windows.Forms.Padding(1)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(210, 33)
        Me.Vendedor.TabIndex = 57277
        '
        'VENDEDORESDataGridView
        '
        Me.VENDEDORESDataGridView.AutoGenerateColumns = False
        Me.VENDEDORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VENDEDORESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.VENDEDORESDataGridView.DataSource = Me.VENDEDORESBindingSource
        Me.VENDEDORESDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.VENDEDORESDataGridView.Name = "VENDEDORESDataGridView"
        Me.VENDEDORESDataGridView.Size = New System.Drawing.Size(458, 220)
        Me.VENDEDORESDataGridView.TabIndex = 57277
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(84, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 70)
        Me.Button1.TabIndex = 57278
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "VENDEDOR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "VENDEDOR"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CONTRASEÑA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CONTRASEÑA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'VENDEDORESBindingSource
        '
        Me.VENDEDORESBindingSource.DataMember = "VENDEDORES"
        Me.VENDEDORESBindingSource.DataSource = Me.LeoDataSet
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDEDORESTableAdapter
        '
        Me.VENDEDORESTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.VENDEDORESTableAdapter = Me.VENDEDORESTableAdapter
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        '
        'Vendedores_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VENDEDORESDataGridView)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.idVendedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CONTRASEÑA)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Vendedores_Registro"
        Me.Text = "Vendedores_Registro"
        CType(Me.VENDEDORESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents VENDEDORESBindingSource As BindingSource
    Friend WithEvents VENDEDORESTableAdapter As LeoDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents Borrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CONTRASEÑA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Modificar As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents idVendedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Vendedor As TextBox
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VENDEDORESDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
