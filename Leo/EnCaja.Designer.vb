<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnCaja))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Label()
        Me.CONTRASEÑALabel1 = New System.Windows.Forms.Label()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.CajaBox = New System.Windows.Forms.TextBox()
        Me.CAJABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CAJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CAJABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CAJADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJATableAdapter = New Leo.LeoDataSetTableAdapters.CAJATableAdapter()
        Me.TableAdapterManager = New Leo.LeoDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Imagentitulo = New System.Windows.Forms.PictureBox()
        CType(Me.CAJABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CAJABindingNavigator.SuspendLayout()
        CType(Me.CAJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAJADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(144, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 57)
        Me.Button1.TabIndex = 57275
        Me.Button1.Text = "INGRESAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ENTER)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(137, -3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 38)
        Me.Label3.TabIndex = 57274
        Me.Label3.Text = "DINERO EN CAJA"
        '
        'cerrar
        '
        Me.cerrar.AutoSize = True
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cerrar.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrar.Location = New System.Drawing.Point(472, -2)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(36, 35)
        Me.cerrar.TabIndex = 57269
        Me.cerrar.Text = "X"
        '
        'CONTRASEÑALabel1
        '
        Me.CONTRASEÑALabel1.Location = New System.Drawing.Point(275, 9)
        Me.CONTRASEÑALabel1.Name = "CONTRASEÑALabel1"
        Me.CONTRASEÑALabel1.Size = New System.Drawing.Size(100, 23)
        Me.CONTRASEÑALabel1.TabIndex = 57271
        Me.CONTRASEÑALabel1.Text = "Label2"
        '
        'IdLabel1
        '
        Me.IdLabel1.Location = New System.Drawing.Point(400, 9)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 57272
        Me.IdLabel1.Text = "Label2"
        Me.IdLabel1.Visible = False
        '
        'CajaBox
        '
        Me.CajaBox.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CajaBox.Location = New System.Drawing.Point(144, 70)
        Me.CajaBox.Margin = New System.Windows.Forms.Padding(0)
        Me.CajaBox.Name = "CajaBox"
        Me.CajaBox.Size = New System.Drawing.Size(267, 50)
        Me.CajaBox.TabIndex = 1
        Me.CajaBox.Text = "0.00"
        Me.CajaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CAJABindingNavigator
        '
        Me.CAJABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CAJABindingNavigator.BindingSource = Me.CAJABindingSource
        Me.CAJABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CAJABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CAJABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CAJABindingNavigatorSaveItem})
        Me.CAJABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CAJABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CAJABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CAJABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CAJABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CAJABindingNavigator.Name = "CAJABindingNavigator"
        Me.CAJABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CAJABindingNavigator.Size = New System.Drawing.Size(741, 25)
        Me.CAJABindingNavigator.TabIndex = 57276
        Me.CAJABindingNavigator.Text = "BindingNavigator1"
        Me.CAJABindingNavigator.Visible = False
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
        'CAJABindingSource
        '
        Me.CAJABindingSource.DataMember = "CAJA"
        Me.CAJABindingSource.DataSource = Me.LeoDataSet
        '
        'LeoDataSet
        '
        Me.LeoDataSet.DataSetName = "LeoDataSet"
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
        'CAJABindingNavigatorSaveItem
        '
        Me.CAJABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CAJABindingNavigatorSaveItem.Image = CType(resources.GetObject("CAJABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CAJABindingNavigatorSaveItem.Name = "CAJABindingNavigatorSaveItem"
        Me.CAJABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CAJABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CAJADataGridView
        '
        Me.CAJADataGridView.AutoGenerateColumns = False
        Me.CAJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CAJADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CAJADataGridView.DataSource = Me.CAJABindingSource
        Me.CAJADataGridView.Location = New System.Drawing.Point(506, 9)
        Me.CAJADataGridView.Name = "CAJADataGridView"
        Me.CAJADataGridView.Size = New System.Drawing.Size(160, 53)
        Me.CAJADataGridView.TabIndex = 57276
        Me.CAJADataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TIPO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TIPO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CANTIDAD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CANTIDAD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VENDEDOR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "VENDEDOR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "HORA"
        DataGridViewCellStyle1.Format = "T"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "HORA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CAJATableAdapter
        '
        Me.CAJATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApartadosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CAJATableAdapter = Me.CAJATableAdapter
        Me.TableAdapterManager.CORTETableAdapter = Nothing
        Me.TableAdapterManager.DioTableAdapter = Nothing
        Me.TableAdapterManager.EntradaSalidaTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosVendidosTableAdapter = Nothing
        Me.TableAdapterManager.TURNOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Leo.LeoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDEDORESTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(104, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 41)
        Me.Label2.TabIndex = 57277
        Me.Label2.Text = "$"
        '
        'Imagentitulo
        '
        Me.Imagentitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Imagentitulo.Location = New System.Drawing.Point(-1, 0)
        Me.Imagentitulo.Name = "Imagentitulo"
        Me.Imagentitulo.Size = New System.Drawing.Size(514, 43)
        Me.Imagentitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagentitulo.TabIndex = 57273
        Me.Imagentitulo.TabStop = False
        '
        'EnCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(502, 204)
        Me.Controls.Add(Me.CAJADataGridView)
        Me.Controls.Add(Me.CAJABindingNavigator)
        Me.Controls.Add(Me.CajaBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.Imagentitulo)
        Me.Controls.Add(Me.CONTRASEÑALabel1)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "EnCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EN CAJA"
        Me.TopMost = True
        CType(Me.CAJABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CAJABindingNavigator.ResumeLayout(False)
        Me.CAJABindingNavigator.PerformLayout()
        CType(Me.CAJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAJADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cerrar As Label
    Friend WithEvents Imagentitulo As PictureBox
    Friend WithEvents CONTRASEÑALabel1 As Label
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents CajaBox As TextBox
    Friend WithEvents LeoDataSet As LeoDataSet
    Friend WithEvents CAJABindingSource As BindingSource
    Friend WithEvents CAJATableAdapter As LeoDataSetTableAdapters.CAJATableAdapter
    Friend WithEvents TableAdapterManager As LeoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CAJABindingNavigator As BindingNavigator
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
    Friend WithEvents CAJABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CAJADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
