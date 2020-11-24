<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta2))
        Me.PRODUCTO = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ProductosVendidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeoDataSet = New Leo.LeoDataSet()
        Me.PrecIngre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NProductos = New System.Windows.Forms.Label()
        Me.TOTAL = New System.Windows.Forms.Label()
        Me.Imagentitulo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.PRECIO = New System.Windows.Forms.Label()
        Me.IdProd = New System.Windows.Forms.Label()
        Me.IdVenta = New System.Windows.Forms.Label()
        Me.CantidadLab = New System.Windows.Forms.Label()
        Me.VENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENTATableAdapter = New Leo.LeoDataSetTableAdapters.VENTATableAdapter()
        Me.ProductosVendidosTableAdapter = New Leo.LeoDataSetTableAdapters.ProductosVendidosTableAdapter()
        Me.VENTADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProductosVendidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUCTO
        '
        Me.PRODUCTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PRODUCTO.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PRODUCTO.Location = New System.Drawing.Point(53, 51)
        Me.PRODUCTO.Margin = New System.Windows.Forms.Padding(0)
        Me.PRODUCTO.Name = "PRODUCTO"
        Me.PRODUCTO.Size = New System.Drawing.Size(217, 43)
        Me.PRODUCTO.TabIndex = 57268
        Me.PRODUCTO.Text = "PRODUCTO"
        Me.PRODUCTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Green
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(584, 99)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 66)
        Me.Button5.TabIndex = 57271
        Me.Button5.Text = "(ENTER)"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ProductosVendidosDataGridView
        '
        Me.ProductosVendidosDataGridView.AllowUserToAddRows = False
        Me.ProductosVendidosDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProductosVendidosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductosVendidosDataGridView.AutoGenerateColumns = False
        Me.ProductosVendidosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ProductosVendidosDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductosVendidosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductosVendidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosVendidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.ProductoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
        Me.ProductosVendidosDataGridView.DataSource = Me.ProductosVendidosBindingSource
        Me.ProductosVendidosDataGridView.Location = New System.Drawing.Point(10, 171)
        Me.ProductosVendidosDataGridView.Name = "ProductosVendidosDataGridView"
        Me.ProductosVendidosDataGridView.ReadOnly = True
        Me.ProductosVendidosDataGridView.Size = New System.Drawing.Size(728, 300)
        Me.ProductosVendidosDataGridView.TabIndex = 57269
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Width = 49
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 103
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 82
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosVendidosBindingSource
        '
        Me.ProductosVendidosBindingSource.DataMember = "ProductosVendidos"
        Me.ProductosVendidosBindingSource.DataSource = Me.LeoDataSet
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrecIngre
        '
        Me.PrecIngre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrecIngre.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecIngre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrecIngre.Location = New System.Drawing.Point(53, 99)
        Me.PrecIngre.Margin = New System.Windows.Forms.Padding(0)
        Me.PrecIngre.MaxLength = 5
        Me.PrecIngre.Name = "PrecIngre"
        Me.PrecIngre.Size = New System.Drawing.Size(518, 66)
        Me.PrecIngre.TabIndex = 1
        Me.PrecIngre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(-3, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 75)
        Me.Label8.TabIndex = 57270
        Me.Label8.Text = "$"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Leo.My.Resources.Resources._2017_10_12
        Me.PictureBox2.Location = New System.Drawing.Point(252, 429)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57285
        Me.PictureBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Green
        Me.Button4.Location = New System.Drawing.Point(150, 557)
        Me.Button4.Margin = New System.Windows.Forms.Padding(1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(421, 74)
        Me.Button4.TabIndex = 57284
        Me.Button4.Text = "COBRAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F12)"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(183, 655)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 22)
        Me.Label16.TabIndex = 57283
        Me.Label16.Text = "PRODUCTOS"
        '
        'NProductos
        '
        Me.NProductos.AutoSize = True
        Me.NProductos.BackColor = System.Drawing.Color.Transparent
        Me.NProductos.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NProductos.Location = New System.Drawing.Point(322, 627)
        Me.NProductos.Name = "NProductos"
        Me.NProductos.Size = New System.Drawing.Size(68, 75)
        Me.NProductos.TabIndex = 57282
        Me.NProductos.Text = "0"
        Me.NProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TOTAL
        '
        Me.TOTAL.AutoSize = True
        Me.TOTAL.BackColor = System.Drawing.Color.Transparent
        Me.TOTAL.Font = New System.Drawing.Font("Arial Black", 62.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TOTAL.Location = New System.Drawing.Point(205, 450)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(298, 117)
        Me.TOTAL.TabIndex = 57281
        Me.TOTAL.Text = "$0.00"
        Me.TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Imagentitulo
        '
        Me.Imagentitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Imagentitulo.Location = New System.Drawing.Point(-2, -12)
        Me.Imagentitulo.Name = "Imagentitulo"
        Me.Imagentitulo.Size = New System.Drawing.Size(860, 60)
        Me.Imagentitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagentitulo.TabIndex = 57316
        Me.Imagentitulo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(259, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 41)
        Me.Label1.TabIndex = 57317
        Me.Label1.Text = "VENTA 2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cerrar
        '
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cerrar.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrar.Location = New System.Drawing.Point(700, -2)
        Me.cerrar.Margin = New System.Windows.Forms.Padding(1)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(38, 45)
        Me.cerrar.TabIndex = 57318
        Me.cerrar.Text = "X"
        Me.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'PRECIO
        '
        Me.PRECIO.AutoSize = True
        Me.PRECIO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRECIO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PRECIO.Location = New System.Drawing.Point(626, 425)
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Size = New System.Drawing.Size(77, 19)
        Me.PRECIO.TabIndex = 57322
        Me.PRECIO.Text = "PRECIO $"
        '
        'IdProd
        '
        Me.IdProd.AutoSize = True
        Me.IdProd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdProd.Location = New System.Drawing.Point(602, 429)
        Me.IdProd.Name = "IdProd"
        Me.IdProd.Size = New System.Drawing.Size(18, 19)
        Me.IdProd.TabIndex = 57321
        Me.IdProd.Text = "0"
        '
        'IdVenta
        '
        Me.IdVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdVenta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdVenta.ForeColor = System.Drawing.Color.White
        Me.IdVenta.Location = New System.Drawing.Point(5, 18)
        Me.IdVenta.Name = "IdVenta"
        Me.IdVenta.Size = New System.Drawing.Size(100, 23)
        Me.IdVenta.TabIndex = 57319
        '
        'CantidadLab
        '
        Me.CantidadLab.AutoSize = True
        Me.CantidadLab.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadLab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CantidadLab.Location = New System.Drawing.Point(658, 450)
        Me.CantidadLab.Name = "CantidadLab"
        Me.CantidadLab.Size = New System.Drawing.Size(18, 19)
        Me.CantidadLab.TabIndex = 57320
        Me.CantidadLab.Text = "1"
        '
        'VENTABindingSource
        '
        Me.VENTABindingSource.DataMember = "VENTA"
        Me.VENTABindingSource.DataSource = Me.LeoDataSet
        '
        'VENTATableAdapter
        '
        Me.VENTATableAdapter.ClearBeforeFill = True
        '
        'ProductosVendidosTableAdapter
        '
        Me.ProductosVendidosTableAdapter.ClearBeforeFill = True
        '
        'VENTADataGridView
        '
        Me.VENTADataGridView.AutoGenerateColumns = False
        Me.VENTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VENTADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.VENTADataGridView.DataSource = Me.VENTABindingSource
        Me.VENTADataGridView.Location = New System.Drawing.Point(-12, 664)
        Me.VENTADataGridView.Name = "VENTADataGridView"
        Me.VENTADataGridView.Size = New System.Drawing.Size(825, 79)
        Me.VENTADataGridView.TabIndex = 57323
        Me.VENTADataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TOTAL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PagoCon"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PagoCon"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VENDEDOR"
        Me.DataGridViewTextBoxColumn6.HeaderText = "VENDEDOR"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "HORA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CANCELADO"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CANCELADO"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EFECTIVO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EFECTIVO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TARJETA"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TARJETA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DineroApartado"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DineroApartado"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Notas"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Notas"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'Venta2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(749, 743)
        Me.Controls.Add(Me.VENTADataGridView)
        Me.Controls.Add(Me.IdVenta)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Imagentitulo)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PRODUCTO)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ProductosVendidosDataGridView)
        Me.Controls.Add(Me.PrecIngre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PRECIO)
        Me.Controls.Add(Me.IdProd)
        Me.Controls.Add(Me.CantidadLab)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.NProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Venta2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta 2"
        CType(Me.ProductosVendidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PRODUCTO As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents ProductosVendidosDataGridView As DataGridView
    Friend WithEvents PrecIngre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents NProductos As Label
    Friend WithEvents TOTAL As Label
    Friend WithEvents Imagentitulo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cerrar As Button
    Friend WithEvents PRECIO As Label
    Friend WithEvents IdProd As Label
    Friend WithEvents IdVenta As Label
    Friend WithEvents CantidadLab As Label
    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents VENTABindingSource As BindingSource
    Friend WithEvents VENTATableAdapter As LeoDataSetTableAdapters.VENTATableAdapter
    Friend WithEvents ProductosVendidosBindingSource As BindingSource
    Friend WithEvents ProductosVendidosTableAdapter As LeoDataSetTableAdapters.ProductosVendidosTableAdapter
    Friend WithEvents VENTADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
