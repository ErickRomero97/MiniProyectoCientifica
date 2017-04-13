<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProfesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProfesion))
        Me.LsvProfesion = New System.Windows.Forms.ListView()
        Me.ChIdProfesion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChProfesion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.LblEditar = New System.Windows.Forms.Label()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtProfesion = New System.Windows.Forms.TextBox()
        Me.TxtCodProfesion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbcProfesion = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GrbProfesion = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CmsOpciones.SuspendLayout()
        Me.TbcProfesion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GrbProfesion.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvProfesion
        '
        Me.LsvProfesion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvProfesion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdProfesion, Me.ChProfesion})
        Me.LsvProfesion.ContextMenuStrip = Me.CmsOpciones
        Me.LsvProfesion.FullRowSelect = True
        Me.LsvProfesion.GridLines = True
        Me.LsvProfesion.Location = New System.Drawing.Point(3, 2)
        Me.LsvProfesion.Name = "LsvProfesion"
        Me.LsvProfesion.Size = New System.Drawing.Size(638, 274)
        Me.LsvProfesion.TabIndex = 116
        Me.LsvProfesion.UseCompatibleStateImageBehavior = False
        Me.LsvProfesion.View = System.Windows.Forms.View.Details
        '
        'ChIdProfesion
        '
        Me.ChIdProfesion.Text = "Codigo Profesion"
        Me.ChIdProfesion.Width = 131
        '
        'ChProfesion
        '
        Me.ChProfesion.Text = "Profesion"
        Me.ChProfesion.Width = 505
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
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(407, 236)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(0, 15)
        Me.LblCancelar.TabIndex = 112
        '
        'LblEditar
        '
        Me.LblEditar.AutoSize = True
        Me.LblEditar.BackColor = System.Drawing.Color.Transparent
        Me.LblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditar.Location = New System.Drawing.Point(323, 236)
        Me.LblEditar.Name = "LblEditar"
        Me.LblEditar.Size = New System.Drawing.Size(0, 15)
        Me.LblEditar.TabIndex = 113
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(225, 236)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(0, 15)
        Me.LblGuardar.TabIndex = 114
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(142, 236)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(0, 15)
        Me.LblNuevo.TabIndex = 115
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
        Me.BtnCancelar.Location = New System.Drawing.Point(406, 188)
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
        Me.BtnEditar.Location = New System.Drawing.Point(312, 188)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(222, 188)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(135, 188)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 111
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtProfesion
        '
        Me.TxtProfesion.Location = New System.Drawing.Point(189, 44)
        Me.TxtProfesion.Name = "TxtProfesion"
        Me.TxtProfesion.Size = New System.Drawing.Size(171, 20)
        Me.TxtProfesion.TabIndex = 70
        '
        'TxtCodProfesion
        '
        Me.TxtCodProfesion.Location = New System.Drawing.Point(191, 16)
        Me.TxtCodProfesion.Name = "TxtCodProfesion"
        Me.TxtCodProfesion.Size = New System.Drawing.Size(53, 20)
        Me.TxtCodProfesion.TabIndex = 70
        Me.TxtCodProfesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Nombre Profesion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 16)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Codigo del Profesion"
        '
        'TbcProfesion
        '
        Me.TbcProfesion.Controls.Add(Me.TabPage1)
        Me.TbcProfesion.Controls.Add(Me.TabPage2)
        Me.TbcProfesion.Location = New System.Drawing.Point(0, 12)
        Me.TbcProfesion.Name = "TbcProfesion"
        Me.TbcProfesion.SelectedIndex = 0
        Me.TbcProfesion.Size = New System.Drawing.Size(655, 300)
        Me.TbcProfesion.TabIndex = 117
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.GrbProfesion)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.LblCancelar)
        Me.TabPage1.Controls.Add(Me.BtnNuevo)
        Me.TabPage1.Controls.Add(Me.LblEditar)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.LblGuardar)
        Me.TabPage1.Controls.Add(Me.BtnEditar)
        Me.TabPage1.Controls.Add(Me.LblNuevo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(647, 274)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestión Profesión "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GrbProfesion
        '
        Me.GrbProfesion.Controls.Add(Me.TxtProfesion)
        Me.GrbProfesion.Controls.Add(Me.Label11)
        Me.GrbProfesion.Controls.Add(Me.Label1)
        Me.GrbProfesion.Controls.Add(Me.TxtCodProfesion)
        Me.GrbProfesion.Location = New System.Drawing.Point(107, 82)
        Me.GrbProfesion.Name = "GrbProfesion"
        Me.GrbProfesion.Size = New System.Drawing.Size(406, 100)
        Me.GrbProfesion.TabIndex = 129
        Me.GrbProfesion.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(8, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 75)
        Me.Panel2.TabIndex = 128
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(188, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Gestión Profeción"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LsvProfesion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(647, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listar Profesión"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FrmProfesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 311)
        Me.Controls.Add(Me.TbcProfesion)
        Me.Name = "FrmProfesion"
        Me.Text = "FrmProfesion"
        Me.CmsOpciones.ResumeLayout(False)
        Me.TbcProfesion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GrbProfesion.ResumeLayout(False)
        Me.GrbProfesion.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LsvProfesion As ListView
    Friend WithEvents ChIdProfesion As ColumnHeader
    Friend WithEvents ChProfesion As ColumnHeader
    Friend WithEvents LblCancelar As Label
    Friend WithEvents LblEditar As Label
    Friend WithEvents LblGuardar As Label
    Friend WithEvents LblNuevo As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtProfesion As TextBox
    Friend WithEvents TxtCodProfesion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbcProfesion As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GrbProfesion As GroupBox
End Class
