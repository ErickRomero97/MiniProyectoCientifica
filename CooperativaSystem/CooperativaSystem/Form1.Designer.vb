﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoPrestamo))
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
        Me.TxtTipoPrestamo = New System.Windows.Forms.TextBox()
        Me.TxtCodTipoP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LsvtipoPrestamo = New System.Windows.Forms.ListView()
        Me.ChIdTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PlMarca.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(447, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Cancelar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(363, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Editar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(265, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Guardar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(182, 197)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 15)
        Me.Label19.TabIndex = 104
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
        Me.BtnCancelar.Location = New System.Drawing.Point(446, 149)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 97
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
        Me.BtnEditar.Location = New System.Drawing.Point(352, 149)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 98
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
        Me.BtnGuardar.Location = New System.Drawing.Point(262, 149)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 99
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
        Me.BtnNuevo.Location = New System.Drawing.Point(175, 149)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 100
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'ChkVertodo
        '
        Me.ChkVertodo.AutoSize = True
        Me.ChkVertodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkVertodo.Location = New System.Drawing.Point(518, 126)
        Me.ChkVertodo.Name = "ChkVertodo"
        Me.ChkVertodo.Size = New System.Drawing.Size(70, 17)
        Me.ChkVertodo.TabIndex = 96
        Me.ChkVertodo.Text = "Ver Todo"
        Me.ChkVertodo.UseVisualStyleBackColor = False
        '
        'PlMarca
        '
        Me.PlMarca.BackColor = System.Drawing.Color.Transparent
        Me.PlMarca.Controls.Add(Me.TxtTipoPrestamo)
        Me.PlMarca.Controls.Add(Me.TxtCodTipoP)
        Me.PlMarca.Controls.Add(Me.Label1)
        Me.PlMarca.Controls.Add(Me.Label11)
        Me.PlMarca.Controls.Add(Me.Label9)
        Me.PlMarca.Location = New System.Drawing.Point(97, 62)
        Me.PlMarca.Name = "PlMarca"
        Me.PlMarca.Size = New System.Drawing.Size(406, 81)
        Me.PlMarca.TabIndex = 95
        '
        'TxtTipoPrestamo
        '
        Me.TxtTipoPrestamo.Location = New System.Drawing.Point(220, 45)
        Me.TxtTipoPrestamo.Name = "TxtTipoPrestamo"
        Me.TxtTipoPrestamo.Size = New System.Drawing.Size(171, 20)
        Me.TxtTipoPrestamo.TabIndex = 70
        '
        'TxtCodTipoP
        '
        Me.TxtCodTipoP.Location = New System.Drawing.Point(221, 18)
        Me.TxtCodTipoP.Name = "TxtCodTipoP"
        Me.TxtCodTipoP.Size = New System.Drawing.Size(53, 20)
        Me.TxtCodTipoP.TabIndex = 70
        Me.TxtCodTipoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Nombre Tipo Prestamo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 16)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Codigo del Tipo Prestamo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 50
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
        'LsvtipoPrestamo
        '
        Me.LsvtipoPrestamo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvtipoPrestamo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdTipoPrestamo, Me.ChTipoPrestamo})
        Me.LsvtipoPrestamo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvtipoPrestamo.FullRowSelect = True
        Me.LsvtipoPrestamo.GridLines = True
        Me.LsvtipoPrestamo.Location = New System.Drawing.Point(97, 262)
        Me.LsvtipoPrestamo.Name = "LsvtipoPrestamo"
        Me.LsvtipoPrestamo.Size = New System.Drawing.Size(522, 116)
        Me.LsvtipoPrestamo.TabIndex = 105
        Me.LsvtipoPrestamo.UseCompatibleStateImageBehavior = False
        Me.LsvtipoPrestamo.View = System.Windows.Forms.View.Details
        '
        'ChIdTipoPrestamo
        '
        Me.ChIdTipoPrestamo.Text = "Codigo Tipo Prestamo"
        Me.ChIdTipoPrestamo.Width = 131
        '
        'ChTipoPrestamo
        '
        Me.ChTipoPrestamo.Text = "Tipo Prestamo"
        Me.ChTipoPrestamo.Width = 443
        '
        'FrmTipoPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 422)
        Me.Controls.Add(Me.LsvtipoPrestamo)
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
        Me.Name = "FrmTipoPrestamo"
        Me.Text = "Tipo Prestamo"
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
    Friend WithEvents TxtTipoPrestamo As TextBox
    Friend WithEvents TxtCodTipoP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LsvtipoPrestamo As ListView
    Friend WithEvents ChIdTipoPrestamo As ColumnHeader
    Friend WithEvents ChTipoPrestamo As ColumnHeader
End Class
