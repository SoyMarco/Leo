<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FolioApartado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolioApartado))
        Me.Folio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Label()
        Me.CONTRASEÑALabel1 = New System.Windows.Forms.Label()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.Imagentitulo = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Folio
        '
        Me.Folio.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Folio.Location = New System.Drawing.Point(9, 83)
        Me.Folio.Margin = New System.Windows.Forms.Padding(0)
        Me.Folio.MaxLength = 15
        Me.Folio.Name = "Folio"
        Me.Folio.Size = New System.Drawing.Size(484, 60)
        Me.Folio.TabIndex = 1
        Me.Folio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(9, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 66)
        Me.Button1.TabIndex = 57284
        Me.Button1.Text = "INGRESAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ENTER)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(102, -5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 38)
        Me.Label3.TabIndex = 57283
        Me.Label3.Text = "FOLIO DE APARTADO"
        '
        'cerrar
        '
        Me.cerrar.AutoSize = True
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cerrar.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrar.Location = New System.Drawing.Point(473, 0)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(31, 32)
        Me.cerrar.TabIndex = 57279
        Me.cerrar.Text = "X"
        '
        'CONTRASEÑALabel1
        '
        Me.CONTRASEÑALabel1.Location = New System.Drawing.Point(276, 9)
        Me.CONTRASEÑALabel1.Name = "CONTRASEÑALabel1"
        Me.CONTRASEÑALabel1.Size = New System.Drawing.Size(100, 23)
        Me.CONTRASEÑALabel1.TabIndex = 57280
        Me.CONTRASEÑALabel1.Text = "Label2"
        '
        'IdLabel1
        '
        Me.IdLabel1.Location = New System.Drawing.Point(401, 9)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 57281
        Me.IdLabel1.Text = "Label2"
        Me.IdLabel1.Visible = False
        '
        'Imagentitulo
        '
        Me.Imagentitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Imagentitulo.Location = New System.Drawing.Point(0, 0)
        Me.Imagentitulo.Name = "Imagentitulo"
        Me.Imagentitulo.Size = New System.Drawing.Size(514, 46)
        Me.Imagentitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagentitulo.TabIndex = 57282
        Me.Imagentitulo.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(258, 153)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(235, 63)
        Me.Button5.TabIndex = 57298
        Me.Button5.Text = "MÁS OPCIONES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F10)"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 57299
        Me.Label1.Text = "ESCANEA"
        '
        'FolioApartado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(516, 233)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Folio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.Imagentitulo)
        Me.Controls.Add(Me.CONTRASEÑALabel1)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FolioApartado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FOLIO APARTADO"
        CType(Me.Imagentitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Folio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cerrar As Label
    Friend WithEvents Imagentitulo As PictureBox
    Friend WithEvents CONTRASEÑALabel1 As Label
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
End Class
