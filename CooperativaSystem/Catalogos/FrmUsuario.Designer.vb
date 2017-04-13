<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbcUsuario = New System.Windows.Forms.TabControl()
        Me.TbpGestion = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.LblEditar = New System.Windows.Forms.Label()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.MtbCodigoOficial = New System.Windows.Forms.MaskedTextBox()
        Me.CboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LsvMostrarUsuario = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones.SuspendLayout()
        Me.TbcUsuario.SuspendLayout()
        Me.TbpGestion.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmsOpciones
        '
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(105, 26)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'TbcUsuario
        '
        Me.TbcUsuario.Controls.Add(Me.TbpGestion)
        Me.TbcUsuario.Controls.Add(Me.TabPage4)
        Me.TbcUsuario.Location = New System.Drawing.Point(-5, -2)
        Me.TbcUsuario.Name = "TbcUsuario"
        Me.TbcUsuario.SelectedIndex = 0
        Me.TbcUsuario.Size = New System.Drawing.Size(530, 479)
        Me.TbcUsuario.TabIndex = 3
        '
        'TbpGestion
        '
        Me.TbpGestion.BackgroundImage = CType(resources.GetObject("TbpGestion.BackgroundImage"), System.Drawing.Image)
        Me.TbpGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TbpGestion.Controls.Add(Me.Label4)
        Me.TbpGestion.Controls.Add(Me.BtnGuardar)
        Me.TbpGestion.Controls.Add(Me.BtnNuevo)
        Me.TbpGestion.Controls.Add(Me.BtnEditar)
        Me.TbpGestion.Controls.Add(Me.BtnCancelar)
        Me.TbpGestion.Controls.Add(Me.LblCancelar)
        Me.TbpGestion.Controls.Add(Me.LblEditar)
        Me.TbpGestion.Controls.Add(Me.LblGuardar)
        Me.TbpGestion.Controls.Add(Me.LblNuevo)
        Me.TbpGestion.Controls.Add(Me.GbDatos)
        Me.TbpGestion.Location = New System.Drawing.Point(4, 22)
        Me.TbpGestion.Name = "TbpGestion"
        Me.TbpGestion.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpGestion.Size = New System.Drawing.Size(522, 453)
        Me.TbpGestion.TabIndex = 0
        Me.TbpGestion.Text = "Gestión Usuario"
        Me.TbpGestion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(139, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 33)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Gestión Usuario"
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
        Me.BtnGuardar.Location = New System.Drawing.Point(169, 371)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 141
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
        Me.BtnNuevo.Location = New System.Drawing.Point(92, 371)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 142
        Me.BtnNuevo.UseVisualStyleBackColor = False
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
        Me.BtnEditar.Location = New System.Drawing.Point(249, 371)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 140
        Me.BtnEditar.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(332, 371)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 139
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(329, 423)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(0, 15)
        Me.LblCancelar.TabIndex = 135
        '
        'LblEditar
        '
        Me.LblEditar.AutoSize = True
        Me.LblEditar.BackColor = System.Drawing.Color.Transparent
        Me.LblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditar.Location = New System.Drawing.Point(253, 423)
        Me.LblEditar.Name = "LblEditar"
        Me.LblEditar.Size = New System.Drawing.Size(0, 15)
        Me.LblEditar.TabIndex = 136
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(168, 423)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(0, 15)
        Me.LblGuardar.TabIndex = 137
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(97, 423)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(0, 15)
        Me.LblNuevo.TabIndex = 138
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtnBuscar)
        Me.GbDatos.Controls.Add(Me.MtbCodigoOficial)
        Me.GbDatos.Controls.Add(Me.CboTipoUsuario)
        Me.GbDatos.Controls.Add(Me.Label11)
        Me.GbDatos.Controls.Add(Me.Label12)
        Me.GbDatos.Controls.Add(Me.CboEstado)
        Me.GbDatos.Controls.Add(Me.Label16)
        Me.GbDatos.Controls.Add(Me.Label17)
        Me.GbDatos.Controls.Add(Me.Label18)
        Me.GbDatos.Controls.Add(Me.Label20)
        Me.GbDatos.Controls.Add(Me.TxtContraseña)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.TxtCodigo)
        Me.GbDatos.Location = New System.Drawing.Point(50, 131)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(393, 234)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del Usuario"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(325, 158)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(28, 20)
        Me.BtnBuscar.TabIndex = 89
        Me.BtnBuscar.Text = "..."
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'MtbCodigoOficial
        '
        Me.MtbCodigoOficial.Location = New System.Drawing.Point(196, 158)
        Me.MtbCodigoOficial.Mask = "0000-0000-00000"
        Me.MtbCodigoOficial.Name = "MtbCodigoOficial"
        Me.MtbCodigoOficial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbCodigoOficial.ReadOnly = True
        Me.MtbCodigoOficial.Size = New System.Drawing.Size(125, 20)
        Me.MtbCodigoOficial.TabIndex = 5
        '
        'CboTipoUsuario
        '
        Me.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoUsuario.FormattingEnabled = True
        Me.CboTipoUsuario.Location = New System.Drawing.Point(196, 184)
        Me.CboTipoUsuario.Name = "CboTipoUsuario"
        Me.CboTipoUsuario.Size = New System.Drawing.Size(138, 21)
        Me.CboTipoUsuario.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(92, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Tipo Usuario:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(84, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 16)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Código Oficial:"
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(196, 125)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(138, 21)
        Me.CboEstado.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(134, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 16)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Estado:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(104, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 16)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Contraseña:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(48, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 16)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Nombre de Usuario:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(53, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 16)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Código de Usuario:"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(196, 98)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(138, 20)
        Me.TxtContraseña.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(196, 68)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(138, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(196, 37)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LsvMostrarUsuario)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(522, 453)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Listar Usuario"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LsvMostrarUsuario
        '
        Me.LsvMostrarUsuario.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LsvMostrarUsuario.ContextMenuStrip = Me.CmsOpciones
        Me.LsvMostrarUsuario.FullRowSelect = True
        Me.LsvMostrarUsuario.GridLines = True
        Me.LsvMostrarUsuario.Location = New System.Drawing.Point(-4, 0)
        Me.LsvMostrarUsuario.Name = "LsvMostrarUsuario"
        Me.LsvMostrarUsuario.Size = New System.Drawing.Size(533, 457)
        Me.LsvMostrarUsuario.TabIndex = 0
        Me.LsvMostrarUsuario.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarUsuario.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo usuario"
        Me.ColumnHeader1.Width = 92
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre Usuario"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 3
        Me.ColumnHeader3.Text = "Contraseña"
        Me.ColumnHeader3.Width = 68
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 2
        Me.ColumnHeader4.Text = "Estado"
        Me.ColumnHeader4.Width = 71
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Codigo Oficial"
        Me.ColumnHeader5.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tipo Usuario"
        Me.ColumnHeader6.Width = 111
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 472)
        Me.Controls.Add(Me.TbcUsuario)
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Usuario"
        Me.CmsOpciones.ResumeLayout(False)
        Me.TbcUsuario.ResumeLayout(False)
        Me.TbpGestion.ResumeLayout(False)
        Me.TbpGestion.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbcUsuario As TabControl
    Friend WithEvents TbpGestion As TabPage
    Friend WithEvents LblCancelar As Label
    Friend WithEvents LblEditar As Label
    Friend WithEvents LblGuardar As Label
    Friend WithEvents LblNuevo As Label
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents MtbCodigoOficial As MaskedTextBox
    Friend WithEvents CboTipoUsuario As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CboEstado As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents LsvMostrarUsuario As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label4 As Label
End Class
