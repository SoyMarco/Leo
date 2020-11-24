<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EBApartado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EBApartado))
        Me.BtnEntregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEntregar
        '
        Me.BtnEntregar.BackColor = System.Drawing.Color.White
        Me.BtnEntregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEntregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntregar.Location = New System.Drawing.Point(10, 60)
        Me.BtnEntregar.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnEntregar.Name = "BtnEntregar"
        Me.BtnEntregar.Size = New System.Drawing.Size(206, 71)
        Me.BtnEntregar.TabIndex = 57302
        Me.BtnEntregar.Text = "ENTREGAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ENTER)"
        Me.BtnEntregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEntregar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.White
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(230, 60)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(206, 71)
        Me.BtnEliminar.TabIndex = 57301
        Me.BtnEliminar.Text = "ELIMINAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(SUPR)"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Articulo
        '
        Me.Articulo.AutoSize = True
        Me.Articulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Articulo.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Articulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Articulo.Location = New System.Drawing.Point(3, 9)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Size = New System.Drawing.Size(37, 41)
        Me.Articulo.TabIndex = 57317
        Me.Articulo.Text = "0"
        Me.Articulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EBApartado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 141)
        Me.Controls.Add(Me.Articulo)
        Me.Controls.Add(Me.BtnEntregar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "EBApartado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTREGAR, BORRAR ARTICULO"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEntregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Articulo As Label
End Class
