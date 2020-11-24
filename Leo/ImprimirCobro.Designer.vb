<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImprimirCobro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirCobro))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.VENDEDOR = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FECHA = New System.Windows.Forms.Label()
        Me.HORA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NArticulos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lab = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LeoDataSet = New Leo.LeoDataSet()
        Me.ProductosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosVendidosTableAdapter = New Leo.LeoDataSetTableAdapters.ProductosVendidosTableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        Me.ProductosVendidosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosVendidosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.ProductosVendidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.TOTAL = New System.Windows.Forms.TextBox()
        Me.PagoCon = New System.Windows.Forms.TextBox()
        Me.Cambio = New System.Windows.Forms.TextBox()
        Me.Ticket = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosVendidosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosVendidosBindingNavigator.SuspendLayout()
        CType(Me.ProductosVendidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = ""
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = ""
        '
        'VENDEDOR
        '
        Me.VENDEDOR.AutoSize = True
        Me.VENDEDOR.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VENDEDOR.Location = New System.Drawing.Point(80, 118)
        Me.VENDEDOR.Name = "VENDEDOR"
        Me.VENDEDOR.Size = New System.Drawing.Size(93, 18)
        Me.VENDEDOR.TabIndex = 0
        Me.VENDEDOR.Text = "VENDEDOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VENDEDOR:"
        '
        'FECHA
        '
        Me.FECHA.AutoSize = True
        Me.FECHA.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHA.Location = New System.Drawing.Point(1, 77)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(80, 18)
        Me.FECHA.TabIndex = 2
        Me.FECHA.Text = "27/10/2017"
        '
        'HORA
        '
        Me.HORA.AutoSize = True
        Me.HORA.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HORA.Location = New System.Drawing.Point(1, 96)
        Me.HORA.Name = "HORA"
        Me.HORA.Size = New System.Drawing.Size(64, 18)
        Me.HORA.TabIndex = 4
        Me.HORA.Text = "00:00:00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TICKET:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TOTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-3, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PagóCon:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CAMBIO:"
        '
        'NArticulos
        '
        Me.NArticulos.AutoSize = True
        Me.NArticulos.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NArticulos.Location = New System.Drawing.Point(101, 255)
        Me.NArticulos.Name = "NArticulos"
        Me.NArticulos.Size = New System.Drawing.Size(21, 22)
        Me.NArticulos.TabIndex = 13
        Me.NArticulos.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-3, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "No.# ART."
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab.Location = New System.Drawing.Point(38, 3)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(15, 16)
        Me.Lab.TabIndex = 15
        Me.Lab.Text = "0"
        Me.Lab.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosVendidosBindingSource
        '
        Me.ProductosVendidosBindingSource.DataMember = "ProductosVendidos"
        Me.ProductosVendidosBindingSource.DataSource = Me.LeoDataSet
        '
        'ProductosVendidosTableAdapter
        '
        Me.ProductosVendidosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProductosVendidosTableAdapter = Me.ProductosVendidosTableAdapter
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Leo.LeoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDEDORESTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        '
        'ProductosVendidosBindingNavigator
        '
        Me.ProductosVendidosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosVendidosBindingNavigator.BindingSource = Me.ProductosVendidosBindingSource
        Me.ProductosVendidosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductosVendidosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductosVendidosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductosVendidosBindingNavigatorSaveItem})
        Me.ProductosVendidosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductosVendidosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductosVendidosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductosVendidosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductosVendidosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductosVendidosBindingNavigator.Name = "ProductosVendidosBindingNavigator"
        Me.ProductosVendidosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductosVendidosBindingNavigator.Size = New System.Drawing.Size(199, 25)
        Me.ProductosVendidosBindingNavigator.TabIndex = 19
        Me.ProductosVendidosBindingNavigator.Text = "BindingNavigator1"
        Me.ProductosVendidosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductosVendidosBindingNavigatorSaveItem
        '
        Me.ProductosVendidosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductosVendidosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosVendidosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosVendidosBindingNavigatorSaveItem.Name = "ProductosVendidosBindingNavigatorSaveItem"
        Me.ProductosVendidosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.ProductosVendidosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosVendidosBindingSource, "Id", True))
        Me.IdLabel1.Location = New System.Drawing.Point(12, 33)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(41, 23)
        Me.IdLabel1.TabIndex = 24
        Me.IdLabel1.Text = "Label9"
        Me.IdLabel1.Visible = False
        '
        'ProductosVendidosDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.ProductosVendidosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductosVendidosDataGridView.AutoGenerateColumns = False
        Me.ProductosVendidosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ProductosVendidosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProductosVendidosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductosVendidosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductosVendidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosVendidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.ProductosVendidosDataGridView.DataSource = Me.ProductosVendidosBindingSource
        Me.ProductosVendidosDataGridView.GridColor = System.Drawing.Color.Black
        Me.ProductosVendidosDataGridView.Location = New System.Drawing.Point(0, 283)
        Me.ProductosVendidosDataGridView.Name = "ProductosVendidosDataGridView"
        Me.ProductosVendidosDataGridView.ReadOnly = True
        Me.ProductosVendidosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ProductosVendidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ProductosVendidosDataGridView.Size = New System.Drawing.Size(167, 49)
        Me.ProductosVendidosDataGridView.TabIndex = 24
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'TOTAL
        '
        Me.TOTAL.BackColor = System.Drawing.Color.Black
        Me.TOTAL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TOTAL.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.ForeColor = System.Drawing.Color.White
        Me.TOTAL.Location = New System.Drawing.Point(56, 160)
        Me.TOTAL.Margin = New System.Windows.Forms.Padding(0)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(112, 28)
        Me.TOTAL.TabIndex = 53
        Me.TOTAL.Text = "$0.00"
        Me.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PagoCon
        '
        Me.PagoCon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PagoCon.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagoCon.Location = New System.Drawing.Point(56, 192)
        Me.PagoCon.Margin = New System.Windows.Forms.Padding(0)
        Me.PagoCon.Name = "PagoCon"
        Me.PagoCon.Size = New System.Drawing.Size(112, 28)
        Me.PagoCon.TabIndex = 55
        Me.PagoCon.Text = "$0.00"
        Me.PagoCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cambio
        '
        Me.Cambio.BackColor = System.Drawing.Color.White
        Me.Cambio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cambio.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cambio.ForeColor = System.Drawing.Color.Black
        Me.Cambio.Location = New System.Drawing.Point(65, 223)
        Me.Cambio.Margin = New System.Windows.Forms.Padding(0)
        Me.Cambio.Name = "Cambio"
        Me.Cambio.Size = New System.Drawing.Size(104, 32)
        Me.Cambio.TabIndex = 54
        Me.Cambio.Text = "$0.00"
        Me.Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Ticket
        '
        Me.Ticket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ticket.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ticket.Location = New System.Drawing.Point(56, 136)
        Me.Ticket.Margin = New System.Windows.Forms.Padding(0)
        Me.Ticket.Name = "Ticket"
        Me.Ticket.Size = New System.Drawing.Size(112, 22)
        Me.Ticket.TabIndex = 57
        Me.Ticket.Text = "0"
        Me.Ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Leo.My.Resources.Resources.Recurso_1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.ProductoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "PRODUCTO"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "C0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 91
        '
        'ImprimirCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(184, 339)
        Me.Controls.Add(Me.Cambio)
        Me.Controls.Add(Me.VENDEDOR)
        Me.Controls.Add(Me.Ticket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.ProductosVendidosDataGridView)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.ProductosVendidosBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lab)
        Me.Controls.Add(Me.NArticulos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FECHA)
        Me.Controls.Add(Me.HORA)
        Me.Controls.Add(Me.PagoCon)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(430, 1000000)
        Me.Name = "ImprimirCobro"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImprimirCobro"
        Me.TopMost = True
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosVendidosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosVendidosBindingNavigator.ResumeLayout(False)
        Me.ProductosVendidosBindingNavigator.PerformLayout()
        CType(Me.ProductosVendidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VENDEDOR As Label
    Friend WithEvents HORA As Label
    Friend WithEvents FECHA As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NArticulos As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lab As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProductosVendidosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ProductosVendidosBindingSource As BindingSource
    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductosVendidosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductosVendidosTableAdapter As LeoDataSetTableAdapters.ProductosVendidosTableAdapter
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents ProductosVendidosDataGridView As DataGridView
    Friend WithEvents PrintForm2 As PowerPacks.Printing.PrintForm
    Friend WithEvents TOTAL As TextBox
    Friend WithEvents PagoCon As TextBox
    Friend WithEvents Cambio As TextBox
    Friend WithEvents Ticket As TextBox
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
