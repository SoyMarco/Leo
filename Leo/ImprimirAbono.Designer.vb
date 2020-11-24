<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImprimirAbono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirAbono))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FECHA = New System.Windows.Forms.Label()
        Me.NArticulos = New System.Windows.Forms.Label()
        Me.CLIENTE = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeoDataSet = New Leo.LeoDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VENDEDOR = New System.Windows.Forms.Label()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lab = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HORA = New System.Windows.Forms.Label()
        Me.RESTABA = New System.Windows.Forms.TextBox()
        Me.ABONO = New System.Windows.Forms.TextBox()
        Me.RESTA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProductosTableAdapter = New Leo.LeoDataSetTableAdapters.ProductosTableAdapter()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VENCE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DioTableAdapter = New Leo.LeoDataSetTableAdapters.DioTableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        Me.DioDataGridView = New System.Windows.Forms.DataGridView()
        Me.FOLIO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CAMBIO = New System.Windows.Forms.TextBox()
        Me.pictBarcode = New System.Windows.Forms.PictureBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHA
        '
        Me.FECHA.AutoSize = True
        Me.FECHA.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHA.Location = New System.Drawing.Point(-3, 159)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(80, 18)
        Me.FECHA.TabIndex = 55
        Me.FECHA.Text = "27/10/2017"
        '
        'NArticulos
        '
        Me.NArticulos.AutoSize = True
        Me.NArticulos.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NArticulos.Location = New System.Drawing.Point(94, 321)
        Me.NArticulos.Name = "NArticulos"
        Me.NArticulos.Size = New System.Drawing.Size(21, 22)
        Me.NArticulos.TabIndex = 62
        Me.NArticulos.Text = "0"
        '
        'CLIENTE
        '
        Me.CLIENTE.BackColor = System.Drawing.Color.Black
        Me.CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CLIENTE.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENTE.ForeColor = System.Drawing.Color.White
        Me.CLIENTE.Location = New System.Drawing.Point(0, 60)
        Me.CLIENTE.Margin = New System.Windows.Forms.Padding(0)
        Me.CLIENTE.Multiline = True
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.Size = New System.Drawing.Size(172, 49)
        Me.CLIENTE.TabIndex = 68
        Me.CLIENTE.TabStop = False
        Me.CLIENTE.Text = "CLIENTE"
        Me.CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.LeoDataSet
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, -4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 34)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "ABONO"
        '
        'VENDEDOR
        '
        Me.VENDEDOR.AutoSize = True
        Me.VENDEDOR.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VENDEDOR.Location = New System.Drawing.Point(79, 196)
        Me.VENDEDOR.Name = "VENDEDOR"
        Me.VENDEDOR.Size = New System.Drawing.Size(93, 18)
        Me.VENDEDOR.TabIndex = 53
        Me.VENDEDOR.Text = "VENDEDOR"
        '
        'IdLabel1
        '
        Me.IdLabel1.Location = New System.Drawing.Point(118, 383)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(41, 23)
        Me.IdLabel1.TabIndex = 66
        Me.IdLabel1.Text = "Label9"
        Me.IdLabel1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-2, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "FOLIO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "VENDEDOR:"
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab.Location = New System.Drawing.Point(79, 353)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(15, 16)
        Me.Lab.TabIndex = 64
        Me.Lab.Text = "0"
        Me.Lab.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "RESTA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-2, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "ABONO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-3, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "RESTABA"
        '
        'HORA
        '
        Me.HORA.AutoSize = True
        Me.HORA.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HORA.Location = New System.Drawing.Point(-2, 178)
        Me.HORA.Name = "HORA"
        Me.HORA.Size = New System.Drawing.Size(64, 18)
        Me.HORA.TabIndex = 56
        Me.HORA.Text = "00:00:00"
        '
        'RESTABA
        '
        Me.RESTABA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RESTABA.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESTABA.Location = New System.Drawing.Point(64, 213)
        Me.RESTABA.Margin = New System.Windows.Forms.Padding(0)
        Me.RESTABA.Name = "RESTABA"
        Me.RESTABA.Size = New System.Drawing.Size(104, 28)
        Me.RESTABA.TabIndex = 72
        Me.RESTABA.Text = "$0.00"
        Me.RESTABA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ABONO
        '
        Me.ABONO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ABONO.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABONO.Location = New System.Drawing.Point(52, 239)
        Me.ABONO.Margin = New System.Windows.Forms.Padding(0)
        Me.ABONO.Name = "ABONO"
        Me.ABONO.Size = New System.Drawing.Size(116, 28)
        Me.ABONO.TabIndex = 74
        Me.ABONO.Text = "$0.00"
        Me.ABONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RESTA
        '
        Me.RESTA.BackColor = System.Drawing.Color.Black
        Me.RESTA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RESTA.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESTA.ForeColor = System.Drawing.Color.White
        Me.RESTA.Location = New System.Drawing.Point(52, 267)
        Me.RESTA.Margin = New System.Windows.Forms.Padding(0)
        Me.RESTA.Name = "RESTA"
        Me.RESTA.Size = New System.Drawing.Size(116, 28)
        Me.RESTA.TabIndex = 73
        Me.RESTA.Text = "$0.00"
        Me.RESTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-2, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "No.# ART.:"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'VENCE
        '
        Me.VENCE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VENCE.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VENCE.Location = New System.Drawing.Point(56, 112)
        Me.VENCE.Margin = New System.Windows.Forms.Padding(0)
        Me.VENCE.MaxLength = 12
        Me.VENCE.Name = "VENCE"
        Me.VENCE.Size = New System.Drawing.Size(113, 18)
        Me.VENCE.TabIndex = 76
        Me.VENCE.Text = "27/10/2017"
        Me.VENCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-2, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "VENCE:"
        '
        'DioBindingSource
        '
        Me.DioBindingSource.DataMember = "Dio"
        Me.DioBindingSource.DataSource = Me.LeoDataSet
        '
        'DioTableAdapter
        '
        Me.DioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApartadosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAJATableAdapter = Nothing
        Me.TableAdapterManager.CORTETableAdapter = Nothing
        Me.TableAdapterManager.DioTableAdapter = Me.DioTableAdapter
        Me.TableAdapterManager.EntradaSalidaTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProductosVendidosTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Leo.LeoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDEDORESTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        '
        'DioDataGridView
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DioDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DioDataGridView.AutoGenerateColumns = False
        Me.DioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DioDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DioDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DioDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DioDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.DioDataGridView.DataSource = Me.DioBindingSource
        Me.DioDataGridView.Location = New System.Drawing.Point(0, 347)
        Me.DioDataGridView.Name = "DioDataGridView"
        Me.DioDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DioDataGridView.Size = New System.Drawing.Size(170, 50)
        Me.DioDataGridView.TabIndex = 77
        '
        'FOLIO
        '
        Me.FOLIO.BackColor = System.Drawing.Color.Black
        Me.FOLIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FOLIO.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FOLIO.ForeColor = System.Drawing.Color.White
        Me.FOLIO.Location = New System.Drawing.Point(80, 133)
        Me.FOLIO.Margin = New System.Windows.Forms.Padding(0)
        Me.FOLIO.Name = "FOLIO"
        Me.FOLIO.Size = New System.Drawing.Size(89, 30)
        Me.FOLIO.TabIndex = 78
        Me.FOLIO.Text = "0"
        Me.FOLIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "CAMBIO:"
        '
        'CAMBIO
        '
        Me.CAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CAMBIO.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAMBIO.Location = New System.Drawing.Point(52, 293)
        Me.CAMBIO.Margin = New System.Windows.Forms.Padding(0)
        Me.CAMBIO.Name = "CAMBIO"
        Me.CAMBIO.Size = New System.Drawing.Size(116, 28)
        Me.CAMBIO.TabIndex = 80
        Me.CAMBIO.Text = "$0.00"
        Me.CAMBIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pictBarcode
        '
        Me.pictBarcode.Location = New System.Drawing.Point(0, 30)
        Me.pictBarcode.Name = "pictBarcode"
        Me.pictBarcode.Size = New System.Drawing.Size(172, 27)
        Me.pictBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictBarcode.TabIndex = 70
        Me.pictBarcode.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Format = "C0"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "ABONOS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 98
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fecha"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 83
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Vendedor"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vendedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 101
        '
        'ImprimirAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(173, 399)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CAMBIO)
        Me.Controls.Add(Me.RESTA)
        Me.Controls.Add(Me.CLIENTE)
        Me.Controls.Add(Me.DioDataGridView)
        Me.Controls.Add(Me.VENDEDOR)
        Me.Controls.Add(Me.NArticulos)
        Me.Controls.Add(Me.FECHA)
        Me.Controls.Add(Me.pictBarcode)
        Me.Controls.Add(Me.FOLIO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.HORA)
        Me.Controls.Add(Me.RESTABA)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ABONO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lab)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.VENCE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(200, 1000000)
        Me.Name = "ImprimirAbono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImprimirAbono"
        Me.TopMost = True
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FECHA As Label
    Friend WithEvents pictBarcode As PictureBox
    Friend WithEvents NArticulos As Label
    Friend WithEvents CLIENTE As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents VENDEDOR As Label
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lab As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HORA As Label
    Friend WithEvents RESTABA As TextBox
    Friend WithEvents ABONO As TextBox
    Friend WithEvents RESTA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As LeoDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VENCE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DioBindingSource As BindingSource
    Friend WithEvents DioTableAdapter As LeoDataSetTableAdapters.DioTableAdapter
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DioDataGridView As DataGridView
    Friend WithEvents FOLIO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CAMBIO As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
