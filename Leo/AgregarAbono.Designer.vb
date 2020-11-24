<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAbono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarAbono))
        Me.efectivo1 = New System.Windows.Forms.Label()
        Me.cobrar = New System.Windows.Forms.Button()
        Me.EFECTIVO = New System.Windows.Forms.TextBox()
        Me.cambio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ABONO = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.credito1 = New System.Windows.Forms.Label()
        Me.tarjeta1 = New System.Windows.Forms.Label()
        Me.NOTAS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.REFERENCIA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelRef = New System.Windows.Forms.Label()
        Me.CREDITO = New System.Windows.Forms.TextBox()
        Me.TARJETA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Entregado = New System.Windows.Forms.Label()
        Me.LeoDataSet = New Leo.LeoDataSet()
        Me.ApartadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApartadosTableAdapter = New Leo.LeoDataSetTableAdapters.ApartadosTableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        Me.DioTableAdapter = New Leo.LeoDataSetTableAdapters.DioTableAdapter()
        Me.VENTATableAdapter = New Leo.LeoDataSetTableAdapters.VENTATableAdapter()
        Me.ApartadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ApartadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ApartadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENTADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EfectivoCaja = New System.Windows.Forms.Label()
        Me.Abono1 = New System.Windows.Forms.Label()
        Me.idVenta = New System.Windows.Forms.Label()
        Me.idDio = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ApartadosBindingNavigator.SuspendLayout()
        CType(Me.ApartadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'efectivo1
        '
        Me.efectivo1.AutoSize = True
        Me.efectivo1.BackColor = System.Drawing.Color.Transparent
        Me.efectivo1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efectivo1.ForeColor = System.Drawing.Color.Black
        Me.efectivo1.Location = New System.Drawing.Point(294, 145)
        Me.efectivo1.Name = "efectivo1"
        Me.efectivo1.Size = New System.Drawing.Size(66, 25)
        Me.efectivo1.TabIndex = 56875
        Me.efectivo1.Text = "$0.00"
        Me.efectivo1.Visible = False
        '
        'cobrar
        '
        Me.cobrar.BackColor = System.Drawing.Color.White
        Me.cobrar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobrar.ForeColor = System.Drawing.Color.Green
        Me.cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cobrar.Location = New System.Drawing.Point(4, 366)
        Me.cobrar.Name = "cobrar"
        Me.cobrar.Size = New System.Drawing.Size(190, 62)
        Me.cobrar.TabIndex = 56874
        Me.cobrar.Text = "IMPRIMIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F1)"
        Me.cobrar.UseVisualStyleBackColor = False
        '
        'EFECTIVO
        '
        Me.EFECTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EFECTIVO.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EFECTIVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EFECTIVO.Location = New System.Drawing.Point(247, 124)
        Me.EFECTIVO.Margin = New System.Windows.Forms.Padding(0)
        Me.EFECTIVO.MaxLength = 7
        Me.EFECTIVO.Name = "EFECTIVO"
        Me.EFECTIVO.Size = New System.Drawing.Size(161, 53)
        Me.EFECTIVO.TabIndex = 1
        Me.EFECTIVO.Tag = "EFECTIVO"
        Me.EFECTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cambio
        '
        Me.cambio.AutoSize = True
        Me.cambio.BackColor = System.Drawing.Color.Transparent
        Me.cambio.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cambio.Location = New System.Drawing.Point(205, 276)
        Me.cambio.Name = "cambio"
        Me.cambio.Size = New System.Drawing.Size(231, 90)
        Me.cambio.TabIndex = 56872
        Me.cambio.Text = "$0.00"
        Me.cambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(102, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 56871
        Me.Label4.Text = "CAMBIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(102, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 56870
        Me.Label5.Text = "EFECTIVO"
        '
        'cerrar
        '
        Me.cerrar.AutoSize = True
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cerrar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrar.Location = New System.Drawing.Point(550, 5)
        Me.cerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(26, 25)
        Me.cerrar.TabIndex = 56867
        Me.cerrar.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(31, -5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 38)
        Me.Label1.TabIndex = 56866
        Me.Label1.Text = "¿CUÁL ES SU FORMA DE PAGO?"
        '
        'ABONO
        '
        Me.ABONO.AutoSize = True
        Me.ABONO.BackColor = System.Drawing.Color.Transparent
        Me.ABONO.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABONO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ABONO.Location = New System.Drawing.Point(205, 36)
        Me.ABONO.Name = "ABONO"
        Me.ABONO.Size = New System.Drawing.Size(231, 90)
        Me.ABONO.TabIndex = 56869
        Me.ABONO.Text = "$0.00"
        Me.ABONO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(212, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 44)
        Me.Label7.TabIndex = 56873
        Me.Label7.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(102, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 56876
        Me.Label2.Text = "ABONO" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(603, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56868
        Me.PictureBox1.TabStop = False
        '
        'GUARDAR
        '
        Me.GUARDAR.BackColor = System.Drawing.Color.White
        Me.GUARDAR.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUARDAR.ForeColor = System.Drawing.Color.Green
        Me.GUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GUARDAR.Location = New System.Drawing.Point(199, 366)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(190, 62)
        Me.GUARDAR.TabIndex = 56877
        Me.GUARDAR.Text = "SOLO GUARDAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F2)"
        Me.GUARDAR.UseVisualStyleBackColor = False
        '
        'credito1
        '
        Me.credito1.AutoSize = True
        Me.credito1.BackColor = System.Drawing.Color.Transparent
        Me.credito1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credito1.ForeColor = System.Drawing.Color.Black
        Me.credito1.Location = New System.Drawing.Point(299, 236)
        Me.credito1.Name = "credito1"
        Me.credito1.Size = New System.Drawing.Size(66, 25)
        Me.credito1.TabIndex = 56889
        Me.credito1.Text = "$0.00"
        Me.credito1.Visible = False
        '
        'tarjeta1
        '
        Me.tarjeta1.AutoSize = True
        Me.tarjeta1.BackColor = System.Drawing.Color.Transparent
        Me.tarjeta1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarjeta1.ForeColor = System.Drawing.Color.Black
        Me.tarjeta1.Location = New System.Drawing.Point(294, 188)
        Me.tarjeta1.Name = "tarjeta1"
        Me.tarjeta1.Size = New System.Drawing.Size(66, 25)
        Me.tarjeta1.TabIndex = 56888
        Me.tarjeta1.Text = "$0.00"
        Me.tarjeta1.Visible = False
        '
        'NOTAS
        '
        Me.NOTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOTAS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOTAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NOTAS.Location = New System.Drawing.Point(106, 457)
        Me.NOTAS.Margin = New System.Windows.Forms.Padding(0)
        Me.NOTAS.Multiline = True
        Me.NOTAS.Name = "NOTAS"
        Me.NOTAS.Size = New System.Drawing.Size(387, 42)
        Me.NOTAS.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(229, 438)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 19)
        Me.Label9.TabIndex = 56887
        Me.Label9.Text = "NOTAS DE VENTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(102, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 48)
        Me.Label3.TabIndex = 56885
        Me.Label3.Text = "TENÍA A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUENTA"
        '
        'REFERENCIA
        '
        Me.REFERENCIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.REFERENCIA.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFERENCIA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.REFERENCIA.Location = New System.Drawing.Point(610, 169)
        Me.REFERENCIA.Margin = New System.Windows.Forms.Padding(0)
        Me.REFERENCIA.MaxLength = 4
        Me.REFERENCIA.Name = "REFERENCIA"
        Me.REFERENCIA.Size = New System.Drawing.Size(161, 41)
        Me.REFERENCIA.TabIndex = 30
        Me.REFERENCIA.Tag = "REFERENCIA"
        Me.REFERENCIA.Text = "0000"
        Me.REFERENCIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.REFERENCIA.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(102, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 56882
        Me.Label6.Text = "TARJETA"
        '
        'LabelRef
        '
        Me.LabelRef.AutoSize = True
        Me.LabelRef.BackColor = System.Drawing.Color.Transparent
        Me.LabelRef.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelRef.Location = New System.Drawing.Point(622, 145)
        Me.LabelRef.Name = "LabelRef"
        Me.LabelRef.Size = New System.Drawing.Size(133, 25)
        Me.LabelRef.TabIndex = 56884
        Me.LabelRef.Text = "REFERENCIA"
        Me.LabelRef.Visible = False
        '
        'CREDITO
        '
        Me.CREDITO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CREDITO.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CREDITO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CREDITO.Location = New System.Drawing.Point(247, 234)
        Me.CREDITO.Margin = New System.Windows.Forms.Padding(0)
        Me.CREDITO.MaxLength = 7
        Me.CREDITO.Name = "CREDITO"
        Me.CREDITO.Size = New System.Drawing.Size(161, 53)
        Me.CREDITO.TabIndex = 3
        Me.CREDITO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TARJETA
        '
        Me.TARJETA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TARJETA.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TARJETA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TARJETA.Location = New System.Drawing.Point(247, 179)
        Me.TARJETA.Margin = New System.Windows.Forms.Padding(0)
        Me.TARJETA.MaxLength = 7
        Me.TARJETA.Name = "TARJETA"
        Me.TARJETA.Size = New System.Drawing.Size(161, 53)
        Me.TARJETA.TabIndex = 2
        Me.TARJETA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(212, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 44)
        Me.Label8.TabIndex = 56883
        Me.Label8.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(212, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 44)
        Me.Label10.TabIndex = 56886
        Me.Label10.Text = "$"
        '
        'Entregado
        '
        Me.Entregado.AutoSize = True
        Me.Entregado.BackColor = System.Drawing.Color.Transparent
        Me.Entregado.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Entregado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Entregado.Location = New System.Drawing.Point(1, 44)
        Me.Entregado.Name = "Entregado"
        Me.Entregado.Size = New System.Drawing.Size(22, 24)
        Me.Entregado.TabIndex = 56890
        Me.Entregado.Text = "0"
        Me.Entregado.Visible = False
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApartadosBindingSource
        '
        Me.ApartadosBindingSource.DataMember = "Apartados"
        Me.ApartadosBindingSource.DataSource = Me.LeoDataSet
        '
        'ApartadosTableAdapter
        '
        Me.ApartadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApartadosTableAdapter = Me.ApartadosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAJATableAdapter = Nothing
        Me.TableAdapterManager.CORTETableAdapter = Nothing
        Me.TableAdapterManager.DioTableAdapter = Me.DioTableAdapter
        Me.TableAdapterManager.EntradaSalidaTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosVendidosTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Leo.LeoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDEDORESTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Me.VENTATableAdapter
        '
        'DioTableAdapter
        '
        Me.DioTableAdapter.ClearBeforeFill = True
        '
        'VENTATableAdapter
        '
        Me.VENTATableAdapter.ClearBeforeFill = True
        '
        'ApartadosBindingNavigator
        '
        Me.ApartadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ApartadosBindingNavigator.BindingSource = Me.ApartadosBindingSource
        Me.ApartadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ApartadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ApartadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ApartadosBindingNavigatorSaveItem})
        Me.ApartadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ApartadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ApartadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ApartadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ApartadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ApartadosBindingNavigator.Name = "ApartadosBindingNavigator"
        Me.ApartadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ApartadosBindingNavigator.Size = New System.Drawing.Size(810, 25)
        Me.ApartadosBindingNavigator.TabIndex = 56891
        Me.ApartadosBindingNavigator.Text = "BindingNavigator1"
        Me.ApartadosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ApartadosBindingNavigatorSaveItem
        '
        Me.ApartadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ApartadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ApartadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ApartadosBindingNavigatorSaveItem.Name = "ApartadosBindingNavigatorSaveItem"
        Me.ApartadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ApartadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ApartadosDataGridView
        '
        Me.ApartadosDataGridView.AutoGenerateColumns = False
        Me.ApartadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ApartadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1})
        Me.ApartadosDataGridView.DataSource = Me.ApartadosBindingSource
        Me.ApartadosDataGridView.Location = New System.Drawing.Point(627, 53)
        Me.ApartadosDataGridView.Name = "ApartadosDataGridView"
        Me.ApartadosDataGridView.Size = New System.Drawing.Size(300, 73)
        Me.ApartadosDataGridView.TabIndex = 56891
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Vendedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vendedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fecha Vencimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Vencimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Entregado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Entregado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha entrega"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fecha entrega"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "hora entrega"
        Me.DataGridViewTextBoxColumn9.HeaderText = "hora entrega"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Sacado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Sacado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DioBindingSource
        '
        Me.DioBindingSource.DataMember = "Dio"
        Me.DioBindingSource.DataSource = Me.LeoDataSet
        '
        'DioDataGridView
        '
        Me.DioDataGridView.AutoGenerateColumns = False
        Me.DioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn15})
        Me.DioDataGridView.DataSource = Me.DioBindingSource
        Me.DioDataGridView.Location = New System.Drawing.Point(616, 135)
        Me.DioDataGridView.Name = "DioDataGridView"
        Me.DioDataGridView.Size = New System.Drawing.Size(300, 65)
        Me.DioDataGridView.TabIndex = 56891
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Dio"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Dio"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Vendedor"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Vendedor"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Cancelado"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Cancelado"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ApartadoN"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ApartadoN"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'VENTABindingSource
        '
        Me.VENTABindingSource.DataMember = "VENTA"
        Me.VENTABindingSource.DataSource = Me.LeoDataSet
        '
        'VENTADataGridView
        '
        Me.VENTADataGridView.AutoGenerateColumns = False
        Me.VENTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VENTADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.VENTADataGridView.DataSource = Me.VENTABindingSource
        Me.VENTADataGridView.Location = New System.Drawing.Point(665, 213)
        Me.VENTADataGridView.Name = "VENTADataGridView"
        Me.VENTADataGridView.Size = New System.Drawing.Size(300, 72)
        Me.VENTADataGridView.TabIndex = 56891
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "VENDEDOR"
        Me.DataGridViewTextBoxColumn17.HeaderText = "VENDEDOR"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn18.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "HORA"
        Me.DataGridViewTextBoxColumn19.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "CANCELADO"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "CANCELADO"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "EFECTIVO"
        Me.DataGridViewTextBoxColumn20.HeaderText = "EFECTIVO"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TARJETA"
        Me.DataGridViewTextBoxColumn21.HeaderText = "TARJETA"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PagoCon"
        Me.DataGridViewTextBoxColumn22.HeaderText = "PagoCon"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "DineroApartado"
        Me.DataGridViewTextBoxColumn23.HeaderText = "DineroApartado"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Notas"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Notas"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TOTAL"
        Me.DataGridViewTextBoxColumn26.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "HORA1"
        Me.DataGridViewTextBoxColumn27.HeaderText = "HORA1"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'EfectivoCaja
        '
        Me.EfectivoCaja.AutoSize = True
        Me.EfectivoCaja.BackColor = System.Drawing.Color.Silver
        Me.EfectivoCaja.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EfectivoCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EfectivoCaja.Location = New System.Drawing.Point(268, 197)
        Me.EfectivoCaja.Name = "EfectivoCaja"
        Me.EfectivoCaja.Size = New System.Drawing.Size(78, 24)
        Me.EfectivoCaja.TabIndex = 56892
        Me.EfectivoCaja.Text = "TOTAL"
        '
        'Abono1
        '
        Me.Abono1.AutoSize = True
        Me.Abono1.BackColor = System.Drawing.Color.Transparent
        Me.Abono1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abono1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Abono1.Location = New System.Drawing.Point(259, 142)
        Me.Abono1.Name = "Abono1"
        Me.Abono1.Size = New System.Drawing.Size(113, 24)
        Me.Abono1.TabIndex = 56893
        Me.Abono1.Text = "EFECTIVO"
        '
        'idVenta
        '
        Me.idVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENTABindingSource, "Id", True))
        Me.idVenta.ForeColor = System.Drawing.Color.Black
        Me.idVenta.Location = New System.Drawing.Point(2, 129)
        Me.idVenta.Name = "idVenta"
        Me.idVenta.Size = New System.Drawing.Size(100, 23)
        Me.idVenta.TabIndex = 56913
        Me.idVenta.Text = "Label11"
        Me.idVenta.Visible = False
        '
        'idDio
        '
        Me.idDio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DioBindingSource, "Id", True))
        Me.idDio.ForeColor = System.Drawing.Color.Black
        Me.idDio.Location = New System.Drawing.Point(2, 103)
        Me.idDio.Name = "idDio"
        Me.idDio.Size = New System.Drawing.Size(100, 23)
        Me.idDio.TabIndex = 56912
        Me.idDio.Text = "Label11"
        Me.idDio.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(394, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 62)
        Me.Button1.TabIndex = 56914
        Me.Button1.Text = "EN INICIAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F3)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AgregarAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(585, 549)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.idVenta)
        Me.Controls.Add(Me.idDio)
        Me.Controls.Add(Me.VENTADataGridView)
        Me.Controls.Add(Me.DioDataGridView)
        Me.Controls.Add(Me.ApartadosDataGridView)
        Me.Controls.Add(Me.ApartadosBindingNavigator)
        Me.Controls.Add(Me.Entregado)
        Me.Controls.Add(Me.EFECTIVO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NOTAS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.REFERENCIA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelRef)
        Me.Controls.Add(Me.CREDITO)
        Me.Controls.Add(Me.TARJETA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cobrar)
        Me.Controls.Add(Me.cambio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ABONO)
        Me.Controls.Add(Me.credito1)
        Me.Controls.Add(Me.tarjeta1)
        Me.Controls.Add(Me.efectivo1)
        Me.Controls.Add(Me.Abono1)
        Me.Controls.Add(Me.EfectivoCaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AgregarAbono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABONO APARTADO"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ApartadosBindingNavigator.ResumeLayout(False)
        Me.ApartadosBindingNavigator.PerformLayout()
        CType(Me.ApartadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents efectivo1 As Label
    Friend WithEvents cobrar As Button
    Friend WithEvents EFECTIVO As TextBox
    Friend WithEvents cambio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cerrar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ABONO As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GUARDAR As Button
    Friend WithEvents credito1 As Label
    Friend WithEvents tarjeta1 As Label
    Friend WithEvents NOTAS As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents REFERENCIA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelRef As Label
    Friend WithEvents CREDITO As TextBox
    Friend WithEvents TARJETA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Entregado As Label
    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents ApartadosBindingSource As BindingSource
    Friend WithEvents ApartadosTableAdapter As LeoDataSetTableAdapters.ApartadosTableAdapter
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ApartadosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
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
    Friend WithEvents ApartadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ApartadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DioTableAdapter As LeoDataSetTableAdapters.DioTableAdapter
    Friend WithEvents DioBindingSource As BindingSource
    Friend WithEvents VENTATableAdapter As LeoDataSetTableAdapters.VENTATableAdapter
    Friend WithEvents DioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents VENTABindingSource As BindingSource
    Friend WithEvents VENTADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents EfectivoCaja As Label
    Friend WithEvents Abono1 As Label
    Friend WithEvents idVenta As Label
    Friend WithEvents idDio As Label
    Friend WithEvents Button1 As Button
End Class
