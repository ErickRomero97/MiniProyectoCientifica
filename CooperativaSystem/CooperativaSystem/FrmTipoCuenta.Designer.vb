<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoCuenta))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.ChkVertodo = New System.Windows.Forms.CheckBox()
        Me.PlMarca = New System.Windows.Forms.Panel()
        Me.TxtNombreTipoCuenta = New System.Windows.Forms.TextBox()
        Me.TxtCodTipoCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LsvTipoCuenta = New System.Windows.Forms.ListView()
        Me.ChIdTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescTipoCuenta = New System.Windows.Forms.TextBox()
        Me.ChDescTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PlMarca.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(494, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Cancelar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(410, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Editar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(312, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Guardar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(229, 212)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 15)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "Nuevo"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(493, 164)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 108
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.BackgroundImage = CType(resources.GetObject("BtnEditar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(399, 164)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 109
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(309, 164)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 110
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(222, 164)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 111
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'ChkVertodo
        '
        Me.ChkVertodo.AutoSize = True
        Me.ChkVertodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkVertodo.Location = New System.Drawing.Point(658, 141)
        Me.ChkVertodo.Name = "ChkVertodo"
        Me.ChkVertodo.Size = New System.Drawing.Size(70, 17)
        Me.ChkVertodo.TabIndex = 107
        Me.ChkVertodo.Text = "Ver Todo"
        Me.ChkVertodo.UseVisualStyleBackColor = False
        '
        'PlMarca
        '
        Me.PlMarca.BackColor = System.Drawing.Color.Transparent
        Me.PlMarca.Controls.Add(Me.TxtDescTipoCuenta)
        Me.PlMarca.Controls.Add(Me.Label2)
        Me.PlMarca.Controls.Add(Me.TxtNombreTipoCuenta)
        Me.PlMarca.Controls.Add(Me.TxtCodTipoCuenta)
        Me.PlMarca.Controls.Add(Me.Label1)
        Me.PlMarca.Controls.Add(Me.Label11)
        Me.PlMarca.Controls.Add(Me.Label9)
        Me.PlMarca.Location = New System.Drawing.Point(132, 12)
        Me.PlMarca.Name = "PlMarca"
        Me.PlMarca.Size = New System.Drawing.Size(497, 146)
        Me.PlMarca.TabIndex = 106
        '
        'TxtNombreTipoCuenta
        '
        Me.TxtNombreTipoCuenta.Location = New System.Drawing.Point(281, 48)
        Me.TxtNombreTipoCuenta.Name = "TxtNombreTipoCuenta"
        Me.TxtNombreTipoCuenta.Size = New System.Drawing.Size(171, 20)
        Me.TxtNombreTipoCuenta.TabIndex = 70
        '
        'TxtCodTipoCuenta
        '
        Me.TxtCodTipoCuenta.Location = New System.Drawing.Point(281, 22)
        Me.TxtCodTipoCuenta.Name = "TxtCodTipoCuenta"
        Me.TxtCodTipoCuenta.Size = New System.Drawing.Size(53, 20)
        Me.TxtCodTipoCuenta.TabIndex = 70
        Me.TxtCodTipoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Nombre del Tipo de Cuenta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 16)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Codigó del Tipo Cuenta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 50
        '
        'LsvTipoCuenta
        '
        Me.LsvTipoCuenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvTipoCuenta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdTipoCuenta, Me.ChNombreTipoCuenta, Me.ChDescTipoCuenta})
        Me.LsvTipoCuenta.ContextMenuStrip = Me.CmsOpciones
        Me.LsvTipoCuenta.FullRowSelect = True
        Me.LsvTipoCuenta.GridLines = True
        Me.LsvTipoCuenta.Location = New System.Drawing.Point(12, 262)
        Me.LsvTipoCuenta.Name = "LsvTipoCuenta"
        Me.LsvTipoCuenta.Size = New System.Drawing.Size(744, 116)
        Me.LsvTipoCuenta.TabIndex = 105
        Me.LsvTipoCuenta.UseCompatibleStateImageBehavior = False
        Me.LsvTipoCuenta.View = System.Windows.Forms.View.Details
        '
        'ChIdTipoCuenta
        '
        Me.ChIdTipoCuenta.Text = "Codigo Tipo Cuenta"
        Me.ChIdTipoCuenta.Width = 131
        '
        'ChNombreTipoCuenta
        '
        Me.ChNombreTipoCuenta.Text = "TipoCuenta"
        Me.ChNombreTipoCuenta.Width = 234
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(122, 56)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Descripsion del Tipo de Cuenta"
        '
        'TxtDescTipoCuenta
        '
        Me.TxtDescTipoCuenta.Location = New System.Drawing.Point(281, 91)
        Me.TxtDescTipoCuenta.Name = "TxtDescTipoCuenta"
        Me.TxtDescTipoCuenta.Size = New System.Drawing.Size(171, 20)
        Me.TxtDescTipoCuenta.TabIndex = 72
        '
        'ChDescTipoCuenta
        '
        Me.ChDescTipoCuenta.Text = "Descripsion del Tipo de Cuenta"
        Me.ChDescTipoCuenta.Width = 380
        '
        'FrmTipoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 452)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.ChkVertodo)
        Me.Controls.Add(Me.PlMarca)
        Me.Controls.Add(Me.LsvTipoCuenta)
        Me.Name = "FrmTipoCuenta"
        Me.Text = "FrmTipoCuenta"
        Me.PlMarca.ResumeLayout(False)
        Me.PlMarca.PerformLayout()
        Me.CmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents ChkVertodo As CheckBox
    Friend WithEvents PlMarca As Panel
    Friend WithEvents TxtNombreTipoCuenta As TextBox
    Friend WithEvents TxtCodTipoCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LsvTipoCuenta As ListView
    Friend WithEvents ChIdTipoCuenta As ColumnHeader
    Friend WithEvents ChNombreTipoCuenta As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtDescTipoCuenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChDescTipoCuenta As ColumnHeader
End Class
