<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOficial))
        Me.TbcOficial = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.LblEditar = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.labelapellido = New System.Windows.Forms.Label()
        Me.MtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.MtbCodOficial = New System.Windows.Forms.MaskedTextBox()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LsvMostrarOficial = New System.Windows.Forms.ListView()
        Me.ChCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpcion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbcOficial.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.CmsOpcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbcOficial
        '
        Me.TbcOficial.Controls.Add(Me.TabPage1)
        Me.TbcOficial.Controls.Add(Me.TabPage2)
        Me.TbcOficial.Location = New System.Drawing.Point(1, 1)
        Me.TbcOficial.Name = "TbcOficial"
        Me.TbcOficial.SelectedIndex = 0
        Me.TbcOficial.Size = New System.Drawing.Size(512, 468)
        Me.TbcOficial.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.LblCancelar)
        Me.TabPage1.Controls.Add(Me.BtnNuevo)
        Me.TabPage1.Controls.Add(Me.LblEditar)
        Me.TabPage1.Controls.Add(Me.BtnEditar)
        Me.TabPage1.Controls.Add(Me.LblGuardar)
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.LblNuevo)
        Me.TabPage1.Controls.Add(Me.GbDatos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(504, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestión Oficial"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(137, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 33)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Gestión Oficial"
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
        Me.BtnGuardar.Location = New System.Drawing.Point(176, 396)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 129
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(342, 376)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(0, 15)
        Me.LblCancelar.TabIndex = 131
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
        Me.BtnNuevo.Location = New System.Drawing.Point(99, 396)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 130
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'LblEditar
        '
        Me.LblEditar.AutoSize = True
        Me.LblEditar.BackColor = System.Drawing.Color.Transparent
        Me.LblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditar.Location = New System.Drawing.Point(263, 376)
        Me.LblEditar.Name = "LblEditar"
        Me.LblEditar.Size = New System.Drawing.Size(0, 15)
        Me.LblEditar.TabIndex = 132
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
        Me.BtnEditar.Location = New System.Drawing.Point(256, 396)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 128
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(183, 376)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(0, 15)
        Me.LblGuardar.TabIndex = 133
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
        Me.BtnCancelar.Location = New System.Drawing.Point(341, 396)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 127
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(106, 376)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(0, 15)
        Me.LblNuevo.TabIndex = 134
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TxtApellido)
        Me.GbDatos.Controls.Add(Me.labelapellido)
        Me.GbDatos.Controls.Add(Me.MtbTelefono)
        Me.GbDatos.Controls.Add(Me.MtbCodOficial)
        Me.GbDatos.Controls.Add(Me.CboSexo)
        Me.GbDatos.Controls.Add(Me.TxtDireccion)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Location = New System.Drawing.Point(85, 107)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(314, 253)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos Oficial"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(111, 84)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(159, 20)
        Me.TxtApellido.TabIndex = 3
        '
        'labelapellido
        '
        Me.labelapellido.AutoSize = True
        Me.labelapellido.Location = New System.Drawing.Point(31, 87)
        Me.labelapellido.Name = "labelapellido"
        Me.labelapellido.Size = New System.Drawing.Size(79, 13)
        Me.labelapellido.TabIndex = 12
        Me.labelapellido.Text = "Apellido Oficial:"
        '
        'MtbTelefono
        '
        Me.MtbTelefono.Location = New System.Drawing.Point(111, 182)
        Me.MtbTelefono.Mask = "00-00-00-00"
        Me.MtbTelefono.Name = "MtbTelefono"
        Me.MtbTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbTelefono.Size = New System.Drawing.Size(159, 20)
        Me.MtbTelefono.TabIndex = 5
        '
        'MtbCodOficial
        '
        Me.MtbCodOficial.Location = New System.Drawing.Point(111, 31)
        Me.MtbCodOficial.Mask = "0000-0000-00000"
        Me.MtbCodOficial.Name = "MtbCodOficial"
        Me.MtbCodOficial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbCodOficial.Size = New System.Drawing.Size(159, 20)
        Me.MtbCodOficial.TabIndex = 1
        '
        'CboSexo
        '
        Me.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(111, 209)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(156, 21)
        Me.CboSexo.TabIndex = 6
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(111, 114)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(159, 61)
        Me.TxtDireccion.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(111, 58)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(159, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Oficial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Oficial:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LsvMostrarOficial)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(504, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listar Oficial"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LsvMostrarOficial
        '
        Me.LsvMostrarOficial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigo, Me.ChNombre, Me.ChApellido, Me.ChDireccion, Me.ChTelefono, Me.ChSexo})
        Me.LsvMostrarOficial.ContextMenuStrip = Me.CmsOpcion
        Me.LsvMostrarOficial.FullRowSelect = True
        Me.LsvMostrarOficial.GridLines = True
        Me.LsvMostrarOficial.Location = New System.Drawing.Point(0, 0)
        Me.LsvMostrarOficial.Name = "LsvMostrarOficial"
        Me.LsvMostrarOficial.Size = New System.Drawing.Size(505, 434)
        Me.LsvMostrarOficial.TabIndex = 0
        Me.LsvMostrarOficial.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarOficial.View = System.Windows.Forms.View.Details
        '
        'ChCodigo
        '
        Me.ChCodigo.Text = "Código Oficial"
        Me.ChCodigo.Width = 99
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre Oficial"
        Me.ChNombre.Width = 85
        '
        'ChApellido
        '
        Me.ChApellido.Text = "Apellido"
        Me.ChApellido.Width = 66
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Dirección"
        Me.ChDireccion.Width = 85
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Teléfono"
        Me.ChTelefono.Width = 89
        '
        'ChSexo
        '
        Me.ChSexo.Text = "Sexo"
        Me.ChSexo.Width = 78
        '
        'CmsOpcion
        '
        Me.CmsOpcion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.CmsOpcion.Name = "CmsOpcion"
        Me.CmsOpcion.Size = New System.Drawing.Size(105, 26)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'FrmOficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 481)
        Me.Controls.Add(Me.TbcOficial)
        Me.Name = "FrmOficial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Oficial"
        Me.TbcOficial.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.CmsOpcion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbcOficial As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblCancelar As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents LblEditar As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents LblGuardar As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblNuevo As Label
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents labelapellido As Label
    Friend WithEvents MtbTelefono As MaskedTextBox
    Friend WithEvents MtbCodOficial As MaskedTextBox
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LsvMostrarOficial As ListView
    Friend WithEvents ChCodigo As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellido As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents CmsOpcion As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
End Class
