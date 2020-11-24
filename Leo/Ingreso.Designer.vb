<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ingreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso))
        Me.CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LeoDataSet = New Leo.LeoDataSet()
        Me.VENDEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDEDORESTableAdapter = New Leo.LeoDataSetTableAdapters.VENDEDORESTableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        Me.VENDEDORESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VENDEDORESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VENDEDORESComboBox = New System.Windows.Forms.ComboBox()
        Me.CONTRASEÑALabel1 = New System.Windows.Forms.Label()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Imagentitulo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.INCORRECTA = New System.Windows.Forms.Label()
        Me.VENDEDORLabel1 = New System.Windows.Forms.Label()
        Me.BorrarVendedor = New System.Windows.Forms.Button()
        Me.VENDEDORESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDEDORESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDEDORESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VENDEDORESBindingNavigator.SuspendLayout()
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDEDORESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDEDORESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CONTRASEÑA
        '
        Me.CONTRASEÑA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CONTRASEÑA.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTRASEÑA.Location = New System.Drawing.Point(161, 103)
        Me.CONTRASEÑA.Margin = New System.Windows.Forms.Padding(1)
        Me.CONTRASEÑA.Name = "CONTRASEÑA"
        Me.CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CONTRASEÑA.Size = New System.Drawing.Size(305, 44)
        Me.CONTRASEÑA.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(32, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 19)
        Me.Label8.TabIndex = 57256
        Me.Label8.Text = "CONTRASEÑA"
        '
        'cerrar
        '
        Me.cerrar.AutoSize = True
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cerrar.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrar.Location = New System.Drawing.Point(474, 1)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(31, 32)
        Me.cerrar.TabIndex = 57257
        Me.cerrar.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 57259
        Me.Label1.Text = "VENDEDOR"
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
        Me.LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDEDORESBindingSource
        '
        Me.VENDEDORESBindingSource.DataMember = "VENDEDORES"
        Me.VENDEDORESBindingSource.DataSource = Me.LeoDataSet
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
        'VENDEDORESBindingNavigator
        '
        Me.VENDEDORESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VENDEDORESBindingNavigator.BindingSource = Me.VENDEDORESBindingSource
        Me.VENDEDORESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VENDEDORESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VENDEDORESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VENDEDORESBindingNavigatorSaveItem})
        Me.VENDEDORESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VENDEDORESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VENDEDORESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VENDEDORESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VENDEDORESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VENDEDORESBindingNavigator.Name = "VENDEDORESBindingNavigator"
        Me.VENDEDORESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VENDEDORESBindingNavigator.Size = New System.Drawing.Size(886, 25)
        Me.VENDEDORESBindingNavigator.TabIndex = 57260
        Me.VENDEDORESBindingNavigator.Text = "BindingNavigator1"
        Me.VENDEDORESBindingNavigator.Visible = False
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
        'VENDEDORESBindingNavigatorSaveItem
        '
        Me.VENDEDORESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VENDEDORESBindingNavigatorSaveItem.Image = CType(resources.GetObject("VENDEDORESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VENDEDORESBindingNavigatorSaveItem.Name = "VENDEDORESBindingNavigatorSaveItem"
        Me.VENDEDORESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VENDEDORESBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VENDEDORESComboBox
        '
        Me.VENDEDORESComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.VENDEDORESComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.VENDEDORESComboBox.DataSource = Me.VENDEDORESBindingSource
        Me.VENDEDORESComboBox.DisplayMember = "VENDEDOR"
        Me.VENDEDORESComboBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VENDEDORESComboBox.FormattingEnabled = True
        Me.VENDEDORESComboBox.Location = New System.Drawing.Point(161, 53)
        Me.VENDEDORESComboBox.Name = "VENDEDORESComboBox"
        Me.VENDEDORESComboBox.Size = New System.Drawing.Size(305, 45)
        Me.VENDEDORESComboBox.TabIndex = 1
        Me.VENDEDORESComboBox.ValueMember = "VENDEDOR"
        '
        'CONTRASEÑALabel1
        '
        Me.CONTRASEÑALabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDEDORESBindingSource, "CONTRASEÑA", True))
        Me.CONTRASEÑALabel1.Location = New System.Drawing.Point(271, 9)
        Me.CONTRASEÑALabel1.Name = "CONTRASEÑALabel1"
        Me.CONTRASEÑALabel1.Size = New System.Drawing.Size(100, 23)
        Me.CONTRASEÑALabel1.TabIndex = 57261
        Me.CONTRASEÑALabel1.Text = "Label2"
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDEDORESBindingSource, "Id", True))
        Me.IdLabel1.Location = New System.Drawing.Point(396, 9)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 57262
        Me.IdLabel1.Text = "Label2"
        Me.IdLabel1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(154, -2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 38)
        Me.Label3.TabIndex = 57264
        Me.Label3.Text = "NUEVO TURNO"
        '
        'Imagentitulo
        '
        Me.Imagentitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Imagentitulo.Location = New System.Drawing.Point(-3, 0)
        Me.Imagentitulo.Name = "Imagentitulo"
        Me.Imagentitulo.Size = New System.Drawing.Size(533, 47)
        Me.Imagentitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagentitulo.TabIndex = 57263
        Me.Imagentitulo.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(161, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(305, 50)
        Me.Button1.TabIndex = 57265
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'INCORRECTA
        '
        Me.INCORRECTA.AutoSize = True
        Me.INCORRECTA.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INCORRECTA.ForeColor = System.Drawing.Color.Red
        Me.INCORRECTA.Location = New System.Drawing.Point(157, 204)
        Me.INCORRECTA.Name = "INCORRECTA"
        Me.INCORRECTA.Size = New System.Drawing.Size(272, 22)
        Me.INCORRECTA.TabIndex = 57266
        Me.INCORRECTA.Text = "CONTRASEÑA INCORRECTA"
        Me.INCORRECTA.Visible = False
        '
        'VENDEDORLabel1
        '
        Me.VENDEDORLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDEDORESBindingSource, "VENDEDOR", True))
        Me.VENDEDORLabel1.Location = New System.Drawing.Point(334, 9)
        Me.VENDEDORLabel1.Name = "VENDEDORLabel1"
        Me.VENDEDORLabel1.Size = New System.Drawing.Size(100, 23)
        Me.VENDEDORLabel1.TabIndex = 57269
        Me.VENDEDORLabel1.Text = "Label2"
        '
        'BorrarVendedor
        '
        Me.BorrarVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrarVendedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarVendedor.ForeColor = System.Drawing.Color.White
        Me.BorrarVendedor.Location = New System.Drawing.Point(3, 190)
        Me.BorrarVendedor.Name = "BorrarVendedor"
        Me.BorrarVendedor.Size = New System.Drawing.Size(123, 32)
        Me.BorrarVendedor.TabIndex = 57270
        Me.BorrarVendedor.Text = "BORRAR"
        Me.BorrarVendedor.UseVisualStyleBackColor = False
        Me.BorrarVendedor.Visible = False
        '
        'VENDEDORESDataGridView
        '
        Me.VENDEDORESDataGridView.AutoGenerateColumns = False
        Me.VENDEDORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VENDEDORESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.VENDEDORESDataGridView.DataSource = Me.VENDEDORESBindingSource1
        Me.VENDEDORESDataGridView.Location = New System.Drawing.Point(521, 53)
        Me.VENDEDORESDataGridView.Name = "VENDEDORESDataGridView"
        Me.VENDEDORESDataGridView.Size = New System.Drawing.Size(300, 107)
        Me.VENDEDORESDataGridView.TabIndex = 57270
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
        'VENDEDORESBindingSource1
        '
        Me.VENDEDORESBindingSource1.DataMember = "VENDEDORES"
        Me.VENDEDORESBindingSource1.DataSource = Me.LeoDataSet
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(-1, -2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(17, 49)
        Me.Button2.TabIndex = 57271
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(510, 226)
        Me.Controls.Add(Me.VENDEDORESDataGridView)
        Me.Controls.Add(Me.BorrarVendedor)
        Me.Controls.Add(Me.INCORRECTA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VENDEDORESComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.CONTRASEÑA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CONTRASEÑALabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Imagentitulo)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.VENDEDORLabel1)
        Me.Controls.Add(Me.VENDEDORESBindingNavigator)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Ingreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INGRESO"
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDEDORESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VENDEDORESBindingNavigator.ResumeLayout(False)
        Me.VENDEDORESBindingNavigator.PerformLayout()
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDEDORESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDEDORESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CONTRASEÑA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cerrar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents VENDEDORESBindingSource As BindingSource
    Friend WithEvents VENDEDORESTableAdapter As LeoDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VENDEDORESBindingNavigator As BindingNavigator
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
    Friend WithEvents VENDEDORESBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VENDEDORESComboBox As ComboBox
    Friend WithEvents CONTRASEÑALabel1 As Label
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Imagentitulo As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents INCORRECTA As Label
    Friend WithEvents VENDEDORLabel1 As Label
    Friend WithEvents BorrarVendedor As Button
    Friend WithEvents VENDEDORESDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents VENDEDORESBindingSource1 As BindingSource
    Friend WithEvents Button2 As Button
End Class
