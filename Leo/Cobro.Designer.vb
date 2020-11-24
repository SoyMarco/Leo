<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cobro))
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.cobrar = New System.Windows.Forms.Button()
        Me.EFECTIVO = New System.Windows.Forms.TextBox()
        Me.cambio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TOTAL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VENTABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.VENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeoDataSet = New Leo.LeoDataSet()
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
        Me.VENTABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TARJETA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.REFERENCIA = New System.Windows.Forms.TextBox()
        Me.LabelRef = New System.Windows.Forms.Label()
        Me.CREDITO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NOTAS = New System.Windows.Forms.TextBox()
        Me.credito1 = New System.Windows.Forms.Label()
        Me.tarjeta1 = New System.Windows.Forms.Label()
        Me.efectivo1 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ventana = New System.Windows.Forms.Label()
        Me.Total1 = New System.Windows.Forms.Label()
        Me.EfectivoCaja = New System.Windows.Forms.Label()
        Me.VENTABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENTATableAdapter = New Leo.LeoDataSetTableAdapters.VENTATableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        Me.VENTADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VENTABindingNavigator.SuspendLayout()
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GUARDAR
        '
        Me.GUARDAR.BackColor = System.Drawing.Color.White
        Me.GUARDAR.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUARDAR.ForeColor = System.Drawing.Color.Green
        Me.GUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GUARDAR.Location = New System.Drawing.Point(296, 351)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(220, 66)
        Me.GUARDAR.TabIndex = 56850
        Me.GUARDAR.Text = "SOLO GUARDAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F2)"
        Me.GUARDAR.UseVisualStyleBackColor = False
        '
        'cobrar
        '
        Me.cobrar.BackColor = System.Drawing.Color.White
        Me.cobrar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobrar.ForeColor = System.Drawing.Color.Green
        Me.cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cobrar.Location = New System.Drawing.Point(38, 351)
        Me.cobrar.Name = "cobrar"
        Me.cobrar.Size = New System.Drawing.Size(220, 66)
        Me.cobrar.TabIndex = 56849
        Me.cobrar.Text = "IMPRIMIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F1)"
        Me.cobrar.UseVisualStyleBackColor = False
        '
        'EFECTIVO
        '
        Me.EFECTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EFECTIVO.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EFECTIVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EFECTIVO.Location = New System.Drawing.Point(237, 112)
        Me.EFECTIVO.Margin = New System.Windows.Forms.Padding(0)
        Me.EFECTIVO.MaxLength = 7
        Me.EFECTIVO.Name = "EFECTIVO"
        Me.EFECTIVO.Size = New System.Drawing.Size(222, 53)
        Me.EFECTIVO.TabIndex = 1
        Me.EFECTIVO.Tag = "EFECTIVO"
        Me.EFECTIVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cambio
        '
        Me.cambio.AutoSize = True
        Me.cambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cambio.Font = New System.Drawing.Font("Arial Black", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cambio.Location = New System.Drawing.Point(196, 269)
        Me.cambio.Name = "cambio"
        Me.cambio.Size = New System.Drawing.Size(201, 79)
        Me.cambio.TabIndex = 56846
        Me.cambio.Text = "$0.00"
        Me.cambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(91, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 56845
        Me.Label4.Text = "CAMBIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(91, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 56844
        Me.Label5.Text = "EFECTIVO"
        '
        'cerrar
        '
        Me.cerrar.AutoSize = True
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cerrar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrar.Location = New System.Drawing.Point(553, 0)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(26, 25)
        Me.cerrar.TabIndex = 56840
        Me.cerrar.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(46, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 38)
        Me.Label1.TabIndex = 56839
        Me.Label1.Text = "¿CUÁL ES SU FORMA DE PAGO?"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(634, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56841
        Me.PictureBox1.TabStop = False
        '
        'TOTAL
        '
        Me.TOTAL.AutoSize = True
        Me.TOTAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TOTAL.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TOTAL.Location = New System.Drawing.Point(195, 28)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(231, 90)
        Me.TOTAL.TabIndex = 56843
        Me.TOTAL.Text = "$0.00"
        Me.TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(202, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 44)
        Me.Label7.TabIndex = 56848
        Me.Label7.Text = "$"
        '
        'VENTABindingNavigator
        '
        Me.VENTABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VENTABindingNavigator.BindingSource = Me.VENTABindingSource
        Me.VENTABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VENTABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VENTABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VENTABindingNavigatorSaveItem})
        Me.VENTABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VENTABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VENTABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VENTABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VENTABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VENTABindingNavigator.Name = "VENTABindingNavigator"
        Me.VENTABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VENTABindingNavigator.Size = New System.Drawing.Size(742, 25)
        Me.VENTABindingNavigator.TabIndex = 56852
        Me.VENTABindingNavigator.Text = "BindingNavigator1"
        Me.VENTABindingNavigator.Visible = False
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
        'VENTABindingSource
        '
        Me.VENTABindingSource.DataMember = "VENTA"
        Me.VENTABindingSource.DataSource = Me.LeoDataSet
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = Global.Leo.My.MySettings.Default.cobro
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'VENTABindingNavigatorSaveItem
        '
        Me.VENTABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VENTABindingNavigatorSaveItem.Image = CType(resources.GetObject("VENTABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VENTABindingNavigatorSaveItem.Name = "VENTABindingNavigatorSaveItem"
        Me.VENTABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VENTABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TARJETA
        '
        Me.TARJETA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TARJETA.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TARJETA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TARJETA.Location = New System.Drawing.Point(237, 168)
        Me.TARJETA.Margin = New System.Windows.Forms.Padding(0)
        Me.TARJETA.MaxLength = 7
        Me.TARJETA.Name = "TARJETA"
        Me.TARJETA.Size = New System.Drawing.Size(222, 53)
        Me.TARJETA.TabIndex = 2
        Me.TARJETA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(91, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 56853
        Me.Label3.Text = "TARJETA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(202, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 44)
        Me.Label6.TabIndex = 56855
        Me.Label6.Text = "$"
        '
        'REFERENCIA
        '
        Me.REFERENCIA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.REFERENCIA.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFERENCIA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.REFERENCIA.Location = New System.Drawing.Point(237, 186)
        Me.REFERENCIA.Margin = New System.Windows.Forms.Padding(0)
        Me.REFERENCIA.MaxLength = 4
        Me.REFERENCIA.Name = "REFERENCIA"
        Me.REFERENCIA.Size = New System.Drawing.Size(161, 34)
        Me.REFERENCIA.TabIndex = 5
        Me.REFERENCIA.Tag = "REFERENCIA"
        Me.REFERENCIA.Text = "0000"
        Me.REFERENCIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.REFERENCIA.Visible = False
        '
        'LabelRef
        '
        Me.LabelRef.AutoSize = True
        Me.LabelRef.BackColor = System.Drawing.Color.White
        Me.LabelRef.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelRef.Location = New System.Drawing.Point(249, 176)
        Me.LabelRef.Name = "LabelRef"
        Me.LabelRef.Size = New System.Drawing.Size(133, 25)
        Me.LabelRef.TabIndex = 56856
        Me.LabelRef.Text = "REFERENCIA"
        Me.LabelRef.Visible = False
        '
        'CREDITO
        '
        Me.CREDITO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CREDITO.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CREDITO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CREDITO.Location = New System.Drawing.Point(237, 224)
        Me.CREDITO.Margin = New System.Windows.Forms.Padding(0)
        Me.CREDITO.MaxLength = 7
        Me.CREDITO.Name = "CREDITO"
        Me.CREDITO.Size = New System.Drawing.Size(222, 53)
        Me.CREDITO.TabIndex = 3
        Me.CREDITO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 48)
        Me.Label2.TabIndex = 56859
        Me.Label2.Text = "TENÍA A " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUENTA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(202, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 44)
        Me.Label8.TabIndex = 56860
        Me.Label8.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(206, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 19)
        Me.Label9.TabIndex = 56863
        Me.Label9.Text = "NOTAS DE VENTA:"
        '
        'NOTAS
        '
        Me.NOTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOTAS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOTAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NOTAS.Location = New System.Drawing.Point(109, 453)
        Me.NOTAS.Margin = New System.Windows.Forms.Padding(0)
        Me.NOTAS.Multiline = True
        Me.NOTAS.Name = "NOTAS"
        Me.NOTAS.Size = New System.Drawing.Size(350, 42)
        Me.NOTAS.TabIndex = 4
        '
        'credito1
        '
        Me.credito1.AutoSize = True
        Me.credito1.BackColor = System.Drawing.Color.White
        Me.credito1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credito1.ForeColor = System.Drawing.Color.Black
        Me.credito1.Location = New System.Drawing.Point(247, 226)
        Me.credito1.Name = "credito1"
        Me.credito1.Size = New System.Drawing.Size(66, 25)
        Me.credito1.TabIndex = 56866
        Me.credito1.Text = "$0.00"
        Me.credito1.Visible = False
        '
        'tarjeta1
        '
        Me.tarjeta1.AutoSize = True
        Me.tarjeta1.BackColor = System.Drawing.Color.White
        Me.tarjeta1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarjeta1.ForeColor = System.Drawing.Color.Black
        Me.tarjeta1.Location = New System.Drawing.Point(242, 178)
        Me.tarjeta1.Name = "tarjeta1"
        Me.tarjeta1.Size = New System.Drawing.Size(66, 25)
        Me.tarjeta1.TabIndex = 56865
        Me.tarjeta1.Text = "$0.00"
        Me.tarjeta1.Visible = False
        '
        'efectivo1
        '
        Me.efectivo1.AutoSize = True
        Me.efectivo1.BackColor = System.Drawing.Color.White
        Me.efectivo1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efectivo1.ForeColor = System.Drawing.Color.Black
        Me.efectivo1.Location = New System.Drawing.Point(242, 135)
        Me.efectivo1.Name = "efectivo1"
        Me.efectivo1.Size = New System.Drawing.Size(66, 25)
        Me.efectivo1.TabIndex = 56864
        Me.efectivo1.Text = "$0.00"
        Me.efectivo1.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(92, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 24)
        Me.Label10.TabIndex = 56867
        Me.Label10.Text = "TOTAL"
        '
        'Ventana
        '
        Me.Ventana.AutoSize = True
        Me.Ventana.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Ventana.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventana.ForeColor = System.Drawing.Color.White
        Me.Ventana.Location = New System.Drawing.Point(3, 43)
        Me.Ventana.Name = "Ventana"
        Me.Ventana.Size = New System.Drawing.Size(91, 24)
        Me.Ventana.TabIndex = 56868
        Me.Ventana.Text = "Ventana"
        '
        'Total1
        '
        Me.Total1.AutoSize = True
        Me.Total1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Total1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Total1.Location = New System.Drawing.Point(325, 186)
        Me.Total1.Name = "Total1"
        Me.Total1.Size = New System.Drawing.Size(73, 25)
        Me.Total1.TabIndex = 56869
        Me.Total1.Text = "TOTAL"
        '
        'EfectivoCaja
        '
        Me.EfectivoCaja.AutoSize = True
        Me.EfectivoCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EfectivoCaja.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EfectivoCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EfectivoCaja.Location = New System.Drawing.Point(303, 130)
        Me.EfectivoCaja.Name = "EfectivoCaja"
        Me.EfectivoCaja.Size = New System.Drawing.Size(108, 25)
        Me.EfectivoCaja.TabIndex = 56870
        Me.EfectivoCaja.Text = "EFECTIVO"
        '
        'VENTABindingSource1
        '
        Me.VENTABindingSource1.DataMember = "VENTA"
        Me.VENTABindingSource1.DataSource = Me.LeoDataSet
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
        'VENTADataGridView
        '
        Me.VENTADataGridView.AutoGenerateColumns = False
        Me.VENTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VENTADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.VENTADataGridView.DataSource = Me.VENTABindingSource
        Me.VENTADataGridView.Location = New System.Drawing.Point(522, 275)
        Me.VENTADataGridView.Name = "VENTADataGridView"
        Me.VENTADataGridView.Size = New System.Drawing.Size(300, 220)
        Me.VENTADataGridView.TabIndex = 56870
        Me.VENTADataGridView.Visible = False
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HORA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CANCELADO"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CANCELADO"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EFECTIVO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EFECTIVO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TARJETA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TARJETA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PagoCon"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PagoCon"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DineroApartado"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DineroApartado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Notas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Notas"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TOTAL"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "HORA1"
        Me.DataGridViewTextBoxColumn12.HeaderText = "HORA1"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Cobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(589, 517)
        Me.Controls.Add(Me.Ventana)
        Me.Controls.Add(Me.EFECTIVO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.VENTADataGridView)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NOTAS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VENTABindingNavigator)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.cobrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.CREDITO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TARJETA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.credito1)
        Me.Controls.Add(Me.tarjeta1)
        Me.Controls.Add(Me.efectivo1)
        Me.Controls.Add(Me.REFERENCIA)
        Me.Controls.Add(Me.LabelRef)
        Me.Controls.Add(Me.EfectivoCaja)
        Me.Controls.Add(Me.Total1)
        Me.Controls.Add(Me.cambio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Cobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COBRO VENTA"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VENTABindingNavigator.ResumeLayout(False)
        Me.VENTABindingNavigator.PerformLayout()
        CType(Me.VENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GUARDAR As Button
    Friend WithEvents cobrar As Button
    Friend WithEvents EFECTIVO As TextBox
    Friend WithEvents cambio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cerrar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TOTAL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents VENTABindingSource As BindingSource
    Friend WithEvents VENTATableAdapter As LeoDataSetTableAdapters.VENTATableAdapter
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VENTABindingNavigator As BindingNavigator
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
    Friend WithEvents VENTABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TARJETA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents REFERENCIA As TextBox
    Friend WithEvents LabelRef As Label
    Friend WithEvents CREDITO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NOTAS As TextBox
    Friend WithEvents credito1 As Label
    Friend WithEvents tarjeta1 As Label
    Friend WithEvents efectivo1 As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents Ventana As Label
    Friend WithEvents Total1 As Label
    Friend WithEvents EfectivoCaja As Label
    Friend WithEvents VENTABindingSource1 As BindingSource
    Public WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents VENTADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
