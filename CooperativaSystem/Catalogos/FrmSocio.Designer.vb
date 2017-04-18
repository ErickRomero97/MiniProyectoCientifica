<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSocio))
        Me.TbcSocio = New System.Windows.Forms.TabControl()
        Me.TPGestionSocio = New System.Windows.Forms.TabPage()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TxtRTNSocio = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCodSocio = New System.Windows.Forms.MaskedTextBox()
        Me.CboProfecion = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CboNacionalidad = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtLugarTrabajo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MtbTelefonoTrabajo = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.lblapellidos = New System.Windows.Forms.Label()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Cboestadocivil = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.LblEditar = New System.Windows.Forms.Label()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TPListarSocio = New System.Windows.Forms.TabPage()
        Me.LsvMostrarSocio = New System.Windows.Forms.ListView()
        Me.ChRtnsocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Chtelefonotrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChLugar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChProfecion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbcSocio.SuspendLayout()
        Me.TPGestionSocio.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.TPListarSocio.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbcSocio
        '
        Me.TbcSocio.Controls.Add(Me.TPGestionSocio)
        Me.TbcSocio.Controls.Add(Me.TPListarSocio)
        Me.TbcSocio.Location = New System.Drawing.Point(5, 11)
        Me.TbcSocio.Name = "TbcSocio"
        Me.TbcSocio.SelectedIndex = 0
        Me.TbcSocio.Size = New System.Drawing.Size(722, 566)
        Me.TbcSocio.TabIndex = 88
        '
        'TPGestionSocio
        '
        Me.TPGestionSocio.BackgroundImage = CType(resources.GetObject("TPGestionSocio.BackgroundImage"), System.Drawing.Image)
        Me.TPGestionSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPGestionSocio.Controls.Add(Me.BtnEditar)
        Me.TPGestionSocio.Controls.Add(Me.Label12)
        Me.TPGestionSocio.Controls.Add(Me.BtnNuevo)
        Me.TPGestionSocio.Controls.Add(Me.GbDatos)
        Me.TPGestionSocio.Controls.Add(Me.btnGuardar)
        Me.TPGestionSocio.Controls.Add(Me.LblEditar)
        Me.TPGestionSocio.Controls.Add(Me.LblGuardar)
        Me.TPGestionSocio.Controls.Add(Me.LblCancelar)
        Me.TPGestionSocio.Controls.Add(Me.LblNuevo)
        Me.TPGestionSocio.Controls.Add(Me.btnCancelar)
        Me.TPGestionSocio.Location = New System.Drawing.Point(4, 22)
        Me.TPGestionSocio.Name = "TPGestionSocio"
        Me.TPGestionSocio.Padding = New System.Windows.Forms.Padding(3)
        Me.TPGestionSocio.Size = New System.Drawing.Size(714, 540)
        Me.TPGestionSocio.TabIndex = 0
        Me.TPGestionSocio.Text = "Gestión Socio"
        Me.TPGestionSocio.UseVisualStyleBackColor = True
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
        Me.BtnEditar.Location = New System.Drawing.Point(549, 221)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 110
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label12.Location = New System.Drawing.Point(233, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 33)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Gestión Socio"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(551, 157)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(47, 43)
        Me.BtnNuevo.TabIndex = 72
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'GbDatos
        '
        Me.GbDatos.BackColor = System.Drawing.Color.Transparent
        Me.GbDatos.Controls.Add(Me.TxtRTNSocio)
        Me.GbDatos.Controls.Add(Me.TxtCodSocio)
        Me.GbDatos.Controls.Add(Me.CboProfecion)
        Me.GbDatos.Controls.Add(Me.Label18)
        Me.GbDatos.Controls.Add(Me.CboNacionalidad)
        Me.GbDatos.Controls.Add(Me.Label17)
        Me.GbDatos.Controls.Add(Me.TxtLugarTrabajo)
        Me.GbDatos.Controls.Add(Me.Label16)
        Me.GbDatos.Controls.Add(Me.MtbTelefonoTrabajo)
        Me.GbDatos.Controls.Add(Me.Label15)
        Me.GbDatos.Controls.Add(Me.Label14)
        Me.GbDatos.Controls.Add(Me.mtbTelefono)
        Me.GbDatos.Controls.Add(Me.lblapellidos)
        Me.GbDatos.Controls.Add(Me.CboSexo)
        Me.GbDatos.Controls.Add(Me.TxtApellido)
        Me.GbDatos.Controls.Add(Me.Cboestadocivil)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.TxtDireccion)
        Me.GbDatos.Controls.Add(Me.TxtEmail)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Location = New System.Drawing.Point(122, 128)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(348, 394)
        Me.GbDatos.TabIndex = 78
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del Socio"
        '
        'TxtRTNSocio
        '
        Me.TxtRTNSocio.Location = New System.Drawing.Point(128, 40)
        Me.TxtRTNSocio.Mask = "9999-9999-999999"
        Me.TxtRTNSocio.Name = "TxtRTNSocio"
        Me.TxtRTNSocio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtRTNSocio.Size = New System.Drawing.Size(157, 20)
        Me.TxtRTNSocio.TabIndex = 30
        '
        'TxtCodSocio
        '
        Me.TxtCodSocio.Location = New System.Drawing.Point(128, 15)
        Me.TxtCodSocio.Mask = "9999-9999-99999"
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtCodSocio.Size = New System.Drawing.Size(157, 20)
        Me.TxtCodSocio.TabIndex = 29
        '
        'CboProfecion
        '
        Me.CboProfecion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProfecion.FormattingEnabled = True
        Me.CboProfecion.Location = New System.Drawing.Point(132, 368)
        Me.CboProfecion.Name = "CboProfecion"
        Me.CboProfecion.Size = New System.Drawing.Size(125, 21)
        Me.CboProfecion.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(68, 370)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Profesion"
        '
        'CboNacionalidad
        '
        Me.CboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNacionalidad.FormattingEnabled = True
        Me.CboNacionalidad.Location = New System.Drawing.Point(132, 342)
        Me.CboNacionalidad.Name = "CboNacionalidad"
        Me.CboNacionalidad.Size = New System.Drawing.Size(125, 21)
        Me.CboNacionalidad.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(52, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Nacionalidad"
        '
        'TxtLugarTrabajo
        '
        Me.TxtLugarTrabajo.Location = New System.Drawing.Point(129, 253)
        Me.TxtLugarTrabajo.Multiline = True
        Me.TxtLugarTrabajo.Name = "TxtLugarTrabajo"
        Me.TxtLugarTrabajo.Size = New System.Drawing.Size(158, 29)
        Me.TxtLugarTrabajo.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(34, 253)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Lugar de Trabajo"
        '
        'MtbTelefonoTrabajo
        '
        Me.MtbTelefonoTrabajo.Location = New System.Drawing.Point(130, 176)
        Me.MtbTelefonoTrabajo.Mask = "9999-9999"
        Me.MtbTelefonoTrabajo.Name = "MtbTelefonoTrabajo"
        Me.MtbTelefonoTrabajo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbTelefonoTrabajo.Size = New System.Drawing.Size(157, 20)
        Me.MtbTelefonoTrabajo.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Teléfono Trabajo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(68, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "RTNSocio"
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Location = New System.Drawing.Point(130, 145)
        Me.mtbTelefono.Mask = "9999-9999"
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbTelefono.Size = New System.Drawing.Size(157, 20)
        Me.mtbTelefono.TabIndex = 5
        '
        'lblapellidos
        '
        Me.lblapellidos.AutoSize = True
        Me.lblapellidos.Location = New System.Drawing.Point(78, 98)
        Me.lblapellidos.Name = "lblapellidos"
        Me.lblapellidos.Size = New System.Drawing.Size(49, 13)
        Me.lblapellidos.TabIndex = 17
        Me.lblapellidos.Text = "Apellidos"
        '
        'CboSexo
        '
        Me.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(130, 290)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(126, 21)
        Me.CboSexo.TabIndex = 9
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(129, 95)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(158, 20)
        Me.TxtApellido.TabIndex = 3
        '
        'Cboestadocivil
        '
        Me.Cboestadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cboestadocivil.FormattingEnabled = True
        Me.Cboestadocivil.Location = New System.Drawing.Point(132, 316)
        Me.Cboestadocivil.Name = "Cboestadocivil"
        Me.Cboestadocivil.Size = New System.Drawing.Size(125, 21)
        Me.Cboestadocivil.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod Socio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(129, 67)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(158, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Estado Civil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(129, 210)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(158, 29)
        Me.TxtDireccion.TabIndex = 7
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(129, 119)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(158, 20)
        Me.TxtEmail.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono Casa"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(553, 291)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 74
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'LblEditar
        '
        Me.LblEditar.AutoSize = True
        Me.LblEditar.BackColor = System.Drawing.Color.Transparent
        Me.LblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditar.Location = New System.Drawing.Point(555, 271)
        Me.LblEditar.Name = "LblEditar"
        Me.LblEditar.Size = New System.Drawing.Size(0, 16)
        Me.LblEditar.TabIndex = 82
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(551, 338)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(0, 16)
        Me.LblGuardar.TabIndex = 80
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(551, 403)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(0, 16)
        Me.LblCancelar.TabIndex = 83
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(549, 202)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(0, 16)
        Me.LblNuevo.TabIndex = 79
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(558, 366)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 33)
        Me.btnCancelar.TabIndex = 75
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'TPListarSocio
        '
        Me.TPListarSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPListarSocio.Controls.Add(Me.LsvMostrarSocio)
        Me.TPListarSocio.Location = New System.Drawing.Point(4, 22)
        Me.TPListarSocio.Name = "TPListarSocio"
        Me.TPListarSocio.Padding = New System.Windows.Forms.Padding(3)
        Me.TPListarSocio.Size = New System.Drawing.Size(714, 540)
        Me.TPListarSocio.TabIndex = 1
        Me.TPListarSocio.Text = "Listar Socio"
        Me.TPListarSocio.UseVisualStyleBackColor = True
        '
        'LsvMostrarSocio
        '
        Me.LsvMostrarSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChRtnsocio, Me.ChCodSocio, Me.ChNombre, Me.ChApellido, Me.ChDireccion, Me.ChTelefono, Me.Chtelefonotrabajo, Me.ChLugar, Me.ChEmail, Me.ChSexo, Me.ChEstado, Me.ChNacionalidad, Me.ChProfecion})
        Me.LsvMostrarSocio.ContextMenuStrip = Me.CmsOpciones
        Me.LsvMostrarSocio.FullRowSelect = True
        Me.LsvMostrarSocio.GridLines = True
        Me.LsvMostrarSocio.Location = New System.Drawing.Point(-3, 0)
        Me.LsvMostrarSocio.Name = "LsvMostrarSocio"
        Me.LsvMostrarSocio.Size = New System.Drawing.Size(714, 534)
        Me.LsvMostrarSocio.TabIndex = 90
        Me.LsvMostrarSocio.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarSocio.View = System.Windows.Forms.View.Details
        '
        'ChRtnsocio
        '
        Me.ChRtnsocio.Text = "RTNSocio"
        '
        'ChCodSocio
        '
        Me.ChCodSocio.Text = "CódigoSocio"
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre "
        Me.ChNombre.Width = 80
        '
        'ChApellido
        '
        Me.ChApellido.Text = "Apellido"
        Me.ChApellido.Width = 80
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Teléfono"
        Me.ChTelefono.Width = 75
        '
        'Chtelefonotrabajo
        '
        Me.Chtelefonotrabajo.Text = "Telefono Trabajo"
        '
        'ChLugar
        '
        Me.ChLugar.Text = "Lugar de Trabajo"
        '
        'ChEmail
        '
        Me.ChEmail.Text = "Email"
        Me.ChEmail.Width = 120
        '
        'ChSexo
        '
        Me.ChSexo.Text = "Sexo"
        Me.ChSexo.Width = 80
        '
        'ChEstado
        '
        Me.ChEstado.Text = "Estado Civil"
        '
        'ChNacionalidad
        '
        Me.ChNacionalidad.Text = "Nacionalidad"
        '
        'ChProfecion
        '
        Me.ChProfecion.Text = "Profecion"
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(109, 30)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'FrmSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 580)
        Me.Controls.Add(Me.TbcSocio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSocio"
        Me.Text = "FrmSocio"
        Me.TbcSocio.ResumeLayout(False)
        Me.TPGestionSocio.ResumeLayout(False)
        Me.TPGestionSocio.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.TPListarSocio.ResumeLayout(False)
        Me.CmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbcSocio As TabControl
    Friend WithEvents TPGestionSocio As TabPage
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents TxtRTNSocio As MaskedTextBox
    Friend WithEvents TxtCodSocio As MaskedTextBox
    Friend WithEvents CboProfecion As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CboNacionalidad As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtLugarTrabajo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents MtbTelefonoTrabajo As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents lblapellidos As Label
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Cboestadocivil As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents LblEditar As Label
    Friend WithEvents LblGuardar As Label
    Friend WithEvents LblCancelar As Label
    Friend WithEvents LblNuevo As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents TPListarSocio As TabPage
    Friend WithEvents LsvMostrarSocio As ListView
    Friend WithEvents ChRtnsocio As ColumnHeader
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellido As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents Chtelefonotrabajo As ColumnHeader
    Friend WithEvents ChLugar As ColumnHeader
    Friend WithEvents ChEmail As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents ChEstado As ColumnHeader
    Friend WithEvents ChNacionalidad As ColumnHeader
    Friend WithEvents ChProfecion As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnEditar As Button
End Class
