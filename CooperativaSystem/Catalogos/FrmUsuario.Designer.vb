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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LsvMostrarUsuario = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.btnEliminarFoto = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.FotoAgregar = New System.Windows.Forms.PictureBox()
        Me.AbrirFoto = New System.Windows.Forms.OpenFileDialog()
        Me.CmsOpciones.SuspendLayout()
        Me.TbcUsuario.SuspendLayout()
        Me.TbpGestion.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.FotoAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(124, 30)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'TbcUsuario
        '
        Me.TbcUsuario.Controls.Add(Me.TbpGestion)
        Me.TbcUsuario.Controls.Add(Me.TabPage4)
        Me.TbcUsuario.Location = New System.Drawing.Point(-7, -2)
        Me.TbcUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbcUsuario.Name = "TbcUsuario"
        Me.TbcUsuario.SelectedIndex = 0
        Me.TbcUsuario.Size = New System.Drawing.Size(707, 590)
        Me.TbcUsuario.TabIndex = 3
        '
        'TbpGestion
        '
        Me.TbpGestion.BackgroundImage = CType(resources.GetObject("TbpGestion.BackgroundImage"), System.Drawing.Image)
        Me.TbpGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TbpGestion.Controls.Add(Me.Label3)
        Me.TbpGestion.Controls.Add(Me.BtnCerrar)
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
        Me.TbpGestion.Location = New System.Drawing.Point(4, 25)
        Me.TbpGestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbpGestion.Name = "TbpGestion"
        Me.TbpGestion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbpGestion.Size = New System.Drawing.Size(699, 561)
        Me.TbpGestion.TabIndex = 0
        Me.TbpGestion.Text = "Gestión Usuario"
        Me.TbpGestion.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(588, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "cerrar"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(596, 27)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(52, 54)
        Me.BtnCerrar.TabIndex = 144
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(185, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 42)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(225, 457)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(73, 60)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(123, 457)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 60)
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
        Me.BtnEditar.Location = New System.Drawing.Point(332, 457)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(73, 60)
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
        Me.BtnCancelar.Location = New System.Drawing.Point(443, 457)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 60)
        Me.BtnCancelar.TabIndex = 139
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(439, 521)
        Me.LblCancelar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(0, 18)
        Me.LblCancelar.TabIndex = 135
        '
        'LblEditar
        '
        Me.LblEditar.AutoSize = True
        Me.LblEditar.BackColor = System.Drawing.Color.Transparent
        Me.LblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditar.Location = New System.Drawing.Point(337, 521)
        Me.LblEditar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEditar.Name = "LblEditar"
        Me.LblEditar.Size = New System.Drawing.Size(0, 18)
        Me.LblEditar.TabIndex = 136
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(224, 521)
        Me.LblGuardar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(0, 18)
        Me.LblGuardar.TabIndex = 137
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(129, 521)
        Me.LblNuevo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(0, 18)
        Me.LblNuevo.TabIndex = 138
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.btnEliminarFoto)
        Me.GbDatos.Controls.Add(Me.btnAbrir)
        Me.GbDatos.Controls.Add(Me.FotoAgregar)
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
        Me.GbDatos.Location = New System.Drawing.Point(28, 161)
        Me.GbDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GbDatos.Size = New System.Drawing.Size(640, 288)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del Usuario"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LsvMostrarUsuario)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage4.Size = New System.Drawing.Size(699, 561)
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
        Me.LsvMostrarUsuario.Location = New System.Drawing.Point(-5, 0)
        Me.LsvMostrarUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LsvMostrarUsuario.Name = "LsvMostrarUsuario"
        Me.LsvMostrarUsuario.Size = New System.Drawing.Size(709, 562)
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
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(586, 196)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(37, 25)
        Me.BtnBuscar.TabIndex = 102
        Me.BtnBuscar.Text = "..."
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'MtbCodigoOficial
        '
        Me.MtbCodigoOficial.Location = New System.Drawing.Point(414, 196)
        Me.MtbCodigoOficial.Margin = New System.Windows.Forms.Padding(4)
        Me.MtbCodigoOficial.Mask = "0000-0000-00000"
        Me.MtbCodigoOficial.Name = "MtbCodigoOficial"
        Me.MtbCodigoOficial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbCodigoOficial.ReadOnly = True
        Me.MtbCodigoOficial.Size = New System.Drawing.Size(165, 22)
        Me.MtbCodigoOficial.TabIndex = 94
        '
        'CboTipoUsuario
        '
        Me.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoUsuario.FormattingEnabled = True
        Me.CboTipoUsuario.Location = New System.Drawing.Point(414, 228)
        Me.CboTipoUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.CboTipoUsuario.Name = "CboTipoUsuario"
        Me.CboTipoUsuario.Size = New System.Drawing.Size(183, 24)
        Me.CboTipoUsuario.TabIndex = 95
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(276, 230)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 20)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Tipo Usuario:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(265, 196)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 20)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Código Oficial:"
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(414, 156)
        Me.CboEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(183, 24)
        Me.CboEstado.TabIndex = 93
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(332, 157)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 20)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Estado:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(292, 124)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 20)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Contraseña:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(217, 87)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(177, 20)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "Nombre de Usuario:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(224, 49)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(170, 20)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "Código de Usuario:"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(414, 123)
        Me.TxtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(183, 22)
        Me.TxtContraseña.TabIndex = 92
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(414, 86)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(183, 22)
        Me.TxtNombre.TabIndex = 91
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(414, 48)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(148, 22)
        Me.TxtCodigo.TabIndex = 90
        '
        'btnEliminarFoto
        '
        Me.btnEliminarFoto.BackgroundImage = CType(resources.GetObject("btnEliminarFoto.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarFoto.FlatAppearance.BorderSize = 0
        Me.btnEliminarFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEliminarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEliminarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarFoto.Location = New System.Drawing.Point(124, 190)
        Me.btnEliminarFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarFoto.Name = "btnEliminarFoto"
        Me.btnEliminarFoto.Size = New System.Drawing.Size(44, 37)
        Me.btnEliminarFoto.TabIndex = 105
        Me.btnEliminarFoto.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.BackgroundImage = CType(resources.GetObject("btnAbrir.BackgroundImage"), System.Drawing.Image)
        Me.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbrir.FlatAppearance.BorderSize = 0
        Me.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrir.Location = New System.Drawing.Point(58, 190)
        Me.btnAbrir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(44, 37)
        Me.btnAbrir.TabIndex = 104
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'FotoAgregar
        '
        Me.FotoAgregar.BackColor = System.Drawing.Color.Transparent
        Me.FotoAgregar.Image = Global.CooperativaSystem.My.Resources.Resources.silueta
        Me.FotoAgregar.InitialImage = Nothing
        Me.FotoAgregar.Location = New System.Drawing.Point(36, 38)
        Me.FotoAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.FotoAgregar.Name = "FotoAgregar"
        Me.FotoAgregar.Size = New System.Drawing.Size(160, 142)
        Me.FotoAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoAgregar.TabIndex = 103
        Me.FotoAgregar.TabStop = False
        '
        'AbrirFoto
        '
        Me.AbrirFoto.FileName = "OpenFileDialog1"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 581)
        Me.Controls.Add(Me.TbcUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        CType(Me.FotoAgregar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents btnEliminarFoto As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents FotoAgregar As PictureBox
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
    Friend WithEvents AbrirFoto As OpenFileDialog
End Class
