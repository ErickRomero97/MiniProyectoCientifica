<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSolicitudPrestamo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSolicitudPrestamo))
        Me.TbPrestamo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtCantAvales = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GbDatosPrestamo = New System.Windows.Forms.GroupBox()
        Me.BtnAprobarPrestamo = New System.Windows.Forms.Button()
        Me.BtnAgregarAval = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DtpFechaExpiracion = New System.Windows.Forms.DateTimePicker()
        Me.TxtFinalidad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSumaOtorgada = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSumaSolicitada = New System.Windows.Forms.TextBox()
        Me.GbCuentas = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.LsvCuenta = New System.Windows.Forms.ListView()
        Me.ChNumeroCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GbDatoSocio = New System.Windows.Forms.GroupBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEstadoCivil = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRTN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.CboTipoPrestamo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumPrestamo = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LsvPrestamo = New System.Windows.Forms.ListView()
        Me.ChNumPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodigoSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChRTN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoCivil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSumaSolicitada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSumaOtorgada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChPlazo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChInteres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHFinalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaExpiracion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbPrestamo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GbDatosPrestamo.SuspendLayout()
        Me.GbCuentas.SuspendLayout()
        Me.GbDatoSocio.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbPrestamo
        '
        Me.TbPrestamo.Controls.Add(Me.TabPage1)
        Me.TbPrestamo.Controls.Add(Me.TabPage2)
        Me.TbPrestamo.Location = New System.Drawing.Point(3, 1)
        Me.TbPrestamo.Name = "TbPrestamo"
        Me.TbPrestamo.SelectedIndex = 0
        Me.TbPrestamo.Size = New System.Drawing.Size(1225, 658)
        Me.TbPrestamo.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.TxtCantAvales)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.BtnNuevo)
        Me.TabPage1.Controls.Add(Me.BtnEditar)
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.GbDatosPrestamo)
        Me.TabPage1.Controls.Add(Me.GbCuentas)
        Me.TabPage1.Controls.Add(Me.GbDatoSocio)
        Me.TabPage1.Controls.Add(Me.GbDatosGenerales)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1217, 632)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestión Préstamo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtCantAvales
        '
        Me.TxtCantAvales.Location = New System.Drawing.Point(741, 572)
        Me.TxtCantAvales.Name = "TxtCantAvales"
        Me.TxtCantAvales.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantAvales.TabIndex = 131
        Me.TxtCantAvales.Visible = False
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
        Me.BtnGuardar.Location = New System.Drawing.Point(354, 572)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 134
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
        Me.BtnNuevo.Location = New System.Drawing.Point(277, 572)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 135
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
        Me.BtnEditar.Location = New System.Drawing.Point(434, 572)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 133
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
        Me.BtnCancelar.Location = New System.Drawing.Point(515, 572)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 132
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'GbDatosPrestamo
        '
        Me.GbDatosPrestamo.Controls.Add(Me.BtnAprobarPrestamo)
        Me.GbDatosPrestamo.Controls.Add(Me.BtnAgregarAval)
        Me.GbDatosPrestamo.Controls.Add(Me.Label16)
        Me.GbDatosPrestamo.Controls.Add(Me.Label15)
        Me.GbDatosPrestamo.Controls.Add(Me.DtpFechaExpiracion)
        Me.GbDatosPrestamo.Controls.Add(Me.TxtFinalidad)
        Me.GbDatosPrestamo.Controls.Add(Me.Label14)
        Me.GbDatosPrestamo.Controls.Add(Me.TxtTasa)
        Me.GbDatosPrestamo.Controls.Add(Me.Label13)
        Me.GbDatosPrestamo.Controls.Add(Me.TxtPlazo)
        Me.GbDatosPrestamo.Controls.Add(Me.Label12)
        Me.GbDatosPrestamo.Controls.Add(Me.TxtSumaOtorgada)
        Me.GbDatosPrestamo.Controls.Add(Me.Label11)
        Me.GbDatosPrestamo.Controls.Add(Me.TxtSumaSolicitada)
        Me.GbDatosPrestamo.Location = New System.Drawing.Point(20, 404)
        Me.GbDatosPrestamo.Name = "GbDatosPrestamo"
        Me.GbDatosPrestamo.Size = New System.Drawing.Size(830, 144)
        Me.GbDatosPrestamo.TabIndex = 130
        Me.GbDatosPrestamo.TabStop = False
        Me.GbDatosPrestamo.Text = "Datos del Préstamo"
        '
        'BtnAprobarPrestamo
        '
        Me.BtnAprobarPrestamo.Location = New System.Drawing.Point(675, 101)
        Me.BtnAprobarPrestamo.Name = "BtnAprobarPrestamo"
        Me.BtnAprobarPrestamo.Size = New System.Drawing.Size(92, 37)
        Me.BtnAprobarPrestamo.TabIndex = 21
        Me.BtnAprobarPrestamo.Text = "Aprobar Préstamo"
        Me.BtnAprobarPrestamo.UseVisualStyleBackColor = True
        '
        'BtnAgregarAval
        '
        Me.BtnAgregarAval.Location = New System.Drawing.Point(577, 101)
        Me.BtnAgregarAval.Name = "BtnAgregarAval"
        Me.BtnAgregarAval.Size = New System.Drawing.Size(92, 37)
        Me.BtnAgregarAval.TabIndex = 20
        Me.BtnAgregarAval.Text = "Agregar Aval"
        Me.BtnAgregarAval.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(422, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Fecha de expiración"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Finalidad"
        '
        'DtpFechaExpiracion
        '
        Me.DtpFechaExpiracion.Location = New System.Drawing.Point(531, 56)
        Me.DtpFechaExpiracion.Name = "DtpFechaExpiracion"
        Me.DtpFechaExpiracion.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaExpiracion.TabIndex = 7
        '
        'TxtFinalidad
        '
        Me.TxtFinalidad.Location = New System.Drawing.Point(79, 56)
        Me.TxtFinalidad.Multiline = True
        Me.TxtFinalidad.Name = "TxtFinalidad"
        Me.TxtFinalidad.Size = New System.Drawing.Size(335, 59)
        Me.TxtFinalidad.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(614, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Tasa de interés"
        '
        'TxtTasa
        '
        Me.TxtTasa.Location = New System.Drawing.Point(701, 30)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(100, 20)
        Me.TxtTasa.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(420, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Plazo de pago"
        '
        'TxtPlazo
        '
        Me.TxtPlazo.Location = New System.Drawing.Point(501, 30)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(100, 20)
        Me.TxtPlazo.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(227, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Suma otorgada"
        '
        'TxtSumaOtorgada
        '
        Me.TxtSumaOtorgada.Location = New System.Drawing.Point(314, 30)
        Me.TxtSumaOtorgada.Name = "TxtSumaOtorgada"
        Me.TxtSumaOtorgada.Size = New System.Drawing.Size(100, 20)
        Me.TxtSumaOtorgada.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Suma solicitada"
        '
        'TxtSumaSolicitada
        '
        Me.TxtSumaSolicitada.Location = New System.Drawing.Point(111, 30)
        Me.TxtSumaSolicitada.Name = "TxtSumaSolicitada"
        Me.TxtSumaSolicitada.Size = New System.Drawing.Size(100, 20)
        Me.TxtSumaSolicitada.TabIndex = 11
        '
        'GbCuentas
        '
        Me.GbCuentas.Controls.Add(Me.Label10)
        Me.GbCuentas.Controls.Add(Me.TxtSaldo)
        Me.GbCuentas.Controls.Add(Me.LsvCuenta)
        Me.GbCuentas.Location = New System.Drawing.Point(20, 218)
        Me.GbCuentas.Name = "GbCuentas"
        Me.GbCuentas.Size = New System.Drawing.Size(830, 170)
        Me.GbCuentas.TabIndex = 129
        Me.GbCuentas.TabStop = False
        Me.GbCuentas.Text = "Cuentas del Socio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(530, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Total Saldo"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Location = New System.Drawing.Point(597, 139)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.ReadOnly = True
        Me.TxtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldo.TabIndex = 11
        Me.TxtSaldo.Text = "0"
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LsvCuenta
        '
        Me.LsvCuenta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumeroCuenta, Me.ChTipoCuenta, Me.ChDescripcion, Me.ChSaldo})
        Me.LsvCuenta.Location = New System.Drawing.Point(100, 19)
        Me.LsvCuenta.Name = "LsvCuenta"
        Me.LsvCuenta.Size = New System.Drawing.Size(597, 114)
        Me.LsvCuenta.TabIndex = 0
        Me.LsvCuenta.UseCompatibleStateImageBehavior = False
        Me.LsvCuenta.View = System.Windows.Forms.View.Details
        '
        'ChNumeroCuenta
        '
        Me.ChNumeroCuenta.Text = "Numero de Cuenta"
        Me.ChNumeroCuenta.Width = 139
        '
        'ChTipoCuenta
        '
        Me.ChTipoCuenta.Text = "Tipo Cuenta"
        Me.ChTipoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ChTipoCuenta.Width = 137
        '
        'ChDescripcion
        '
        Me.ChDescripcion.Text = "Descripción"
        Me.ChDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ChDescripcion.Width = 223
        '
        'ChSaldo
        '
        Me.ChSaldo.Text = "Saldo Actual"
        Me.ChSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ChSaldo.Width = 90
        '
        'GbDatoSocio
        '
        Me.GbDatoSocio.Controls.Add(Me.BtnAgregar)
        Me.GbDatoSocio.Controls.Add(Me.Label9)
        Me.GbDatoSocio.Controls.Add(Me.TxtDireccion)
        Me.GbDatoSocio.Controls.Add(Me.Label8)
        Me.GbDatoSocio.Controls.Add(Me.TxtEstadoCivil)
        Me.GbDatoSocio.Controls.Add(Me.Label7)
        Me.GbDatoSocio.Controls.Add(Me.TxtNacionalidad)
        Me.GbDatoSocio.Controls.Add(Me.Label6)
        Me.GbDatoSocio.Controls.Add(Me.TxtRTN)
        Me.GbDatoSocio.Controls.Add(Me.Label5)
        Me.GbDatoSocio.Controls.Add(Me.TxtNombre)
        Me.GbDatoSocio.Controls.Add(Me.Label4)
        Me.GbDatoSocio.Controls.Add(Me.TxtIdentidad)
        Me.GbDatoSocio.Location = New System.Drawing.Point(20, 90)
        Me.GbDatoSocio.Name = "GbDatoSocio"
        Me.GbDatoSocio.Size = New System.Drawing.Size(830, 110)
        Me.GbDatoSocio.TabIndex = 128
        Me.GbDatoSocio.TabStop = False
        Me.GbDatoSocio.Text = "Datos del Socio (Solicitante)"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(670, 60)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(92, 37)
        Me.BtnAgregar.TabIndex = 19
        Me.BtnAgregar.Text = "Agregar Socio"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(218, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Dirección"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(276, 69)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(331, 20)
        Me.TxtDireccion.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Estado Civil"
        '
        'TxtEstadoCivil
        '
        Me.TxtEstadoCivil.Location = New System.Drawing.Point(100, 69)
        Me.TxtEstadoCivil.Name = "TxtEstadoCivil"
        Me.TxtEstadoCivil.ReadOnly = True
        Me.TxtEstadoCivil.Size = New System.Drawing.Size(100, 20)
        Me.TxtEstadoCivil.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(614, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nacionalidad"
        '
        'TxtNacionalidad
        '
        Me.TxtNacionalidad.Location = New System.Drawing.Point(689, 33)
        Me.TxtNacionalidad.Name = "TxtNacionalidad"
        Me.TxtNacionalidad.ReadOnly = True
        Me.TxtNacionalidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtNacionalidad.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(439, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "RTN"
        '
        'TxtRTN
        '
        Me.TxtRTN.Location = New System.Drawing.Point(474, 33)
        Me.TxtRTN.Name = "TxtRTN"
        Me.TxtRTN.ReadOnly = True
        Me.TxtRTN.Size = New System.Drawing.Size(133, 20)
        Me.TxtRTN.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(300, 33)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(123, 20)
        Me.TxtNombre.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Número de Identidad"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Location = New System.Drawing.Point(134, 33)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.ReadOnly = True
        Me.TxtIdentidad.Size = New System.Drawing.Size(110, 20)
        Me.TxtIdentidad.TabIndex = 7
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.CboTipoPrestamo)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.DtpFechaSolicitud)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TxtNumPrestamo)
        Me.GbDatosGenerales.Location = New System.Drawing.Point(20, 19)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(830, 54)
        Me.GbDatosGenerales.TabIndex = 127
        Me.GbDatosGenerales.TabStop = False
        '
        'CboTipoPrestamo
        '
        Me.CboTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPrestamo.FormattingEnabled = True
        Me.CboTipoPrestamo.Location = New System.Drawing.Point(689, 19)
        Me.CboTipoPrestamo.Name = "CboTipoPrestamo"
        Me.CboTipoPrestamo.Size = New System.Drawing.Size(121, 21)
        Me.CboTipoPrestamo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo de Préstamo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de Solicitud"
        '
        'DtpFechaSolicitud
        '
        Me.DtpFechaSolicitud.Location = New System.Drawing.Point(374, 19)
        Me.DtpFechaSolicitud.Name = "DtpFechaSolicitud"
        Me.DtpFechaSolicitud.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaSolicitud.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Préstamo"
        '
        'TxtNumPrestamo
        '
        Me.TxtNumPrestamo.Location = New System.Drawing.Point(134, 19)
        Me.TxtNumPrestamo.Name = "TxtNumPrestamo"
        Me.TxtNumPrestamo.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumPrestamo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LsvPrestamo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1217, 632)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listar Préstamos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LsvPrestamo
        '
        Me.LsvPrestamo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumPrestamo, Me.ChFechaSolicitud, Me.ChTipoPrestamo, Me.ChCodigoSocio, Me.ChNombre, Me.ChRTN, Me.ChNacionalidad, Me.ChEstadoCivil, Me.ChDireccion, Me.ChSumaSolicitada, Me.ChSumaOtorgada, Me.ChPlazo, Me.ChInteres, Me.CHFinalidad, Me.ChFechaExpiracion})
        Me.LsvPrestamo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvPrestamo.FullRowSelect = True
        Me.LsvPrestamo.Location = New System.Drawing.Point(0, 4)
        Me.LsvPrestamo.Name = "LsvPrestamo"
        Me.LsvPrestamo.Size = New System.Drawing.Size(1217, 628)
        Me.LsvPrestamo.TabIndex = 0
        Me.LsvPrestamo.UseCompatibleStateImageBehavior = False
        Me.LsvPrestamo.View = System.Windows.Forms.View.Details
        '
        'ChNumPrestamo
        '
        Me.ChNumPrestamo.Text = "Número de Préstamo"
        Me.ChNumPrestamo.Width = 113
        '
        'ChFechaSolicitud
        '
        Me.ChFechaSolicitud.Text = "Fecha de Solicitud"
        Me.ChFechaSolicitud.Width = 99
        '
        'ChTipoPrestamo
        '
        Me.ChTipoPrestamo.Text = "Tipo Prestamo"
        Me.ChTipoPrestamo.Width = 89
        '
        'ChCodigoSocio
        '
        Me.ChCodigoSocio.Text = "Codigo Socio"
        Me.ChCodigoSocio.Width = 87
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre"
        Me.ChNombre.Width = 78
        '
        'ChRTN
        '
        Me.ChRTN.Text = "RTN"
        Me.ChRTN.Width = 96
        '
        'ChNacionalidad
        '
        Me.ChNacionalidad.Text = "Nacionalidad"
        Me.ChNacionalidad.Width = 85
        '
        'ChEstadoCivil
        '
        Me.ChEstadoCivil.Text = "Estado Civil"
        Me.ChEstadoCivil.Width = 68
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        Me.ChDireccion.Width = 66
        '
        'ChSumaSolicitada
        '
        Me.ChSumaSolicitada.Text = "Suma Solicitada"
        Me.ChSumaSolicitada.Width = 86
        '
        'ChSumaOtorgada
        '
        Me.ChSumaOtorgada.Text = "Suma Otorgada"
        Me.ChSumaOtorgada.Width = 72
        '
        'ChPlazo
        '
        Me.ChPlazo.Text = "Plazo"
        Me.ChPlazo.Width = 42
        '
        'ChInteres
        '
        Me.ChInteres.Text = "Tasa Interes"
        Me.ChInteres.Width = 71
        '
        'CHFinalidad
        '
        Me.CHFinalidad.Text = "Finalidad"
        Me.CHFinalidad.Width = 75
        '
        'ChFechaExpiracion
        '
        Me.ChFechaExpiracion.Text = "Fecha Expiracion"
        Me.ChFechaExpiracion.Width = 94
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
        'FrmSolicitudPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(880, 656)
        Me.Controls.Add(Me.TbPrestamo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSolicitudPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud Prestamo"
        Me.TbPrestamo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GbDatosPrestamo.ResumeLayout(False)
        Me.GbDatosPrestamo.PerformLayout()
        Me.GbCuentas.ResumeLayout(False)
        Me.GbCuentas.PerformLayout()
        Me.GbDatoSocio.ResumeLayout(False)
        Me.GbDatoSocio.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.CmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbPrestamo As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtCantAvales As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GbDatosPrestamo As GroupBox
    Friend WithEvents BtnAprobarPrestamo As Button
    Friend WithEvents BtnAgregarAval As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DtpFechaExpiracion As DateTimePicker
    Friend WithEvents TxtFinalidad As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtTasa As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPlazo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSumaOtorgada As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtSumaSolicitada As TextBox
    Friend WithEvents GbCuentas As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents LsvCuenta As ListView
    Friend WithEvents ChNumeroCuenta As ColumnHeader
    Friend WithEvents ChTipoCuenta As ColumnHeader
    Friend WithEvents ChDescripcion As ColumnHeader
    Friend WithEvents ChSaldo As ColumnHeader
    Friend WithEvents GbDatoSocio As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEstadoCivil As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNacionalidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRTN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents CboTipoPrestamo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpFechaSolicitud As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumPrestamo As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LsvPrestamo As ListView
    Friend WithEvents ChNumPrestamo As ColumnHeader
    Friend WithEvents ChFechaSolicitud As ColumnHeader
    Friend WithEvents ChTipoPrestamo As ColumnHeader
    Friend WithEvents ChCodigoSocio As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChRTN As ColumnHeader
    Friend WithEvents ChNacionalidad As ColumnHeader
    Friend WithEvents ChEstadoCivil As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChSumaSolicitada As ColumnHeader
    Friend WithEvents ChSumaOtorgada As ColumnHeader
    Friend WithEvents ChPlazo As ColumnHeader
    Friend WithEvents ChInteres As ColumnHeader
    Friend WithEvents CHFinalidad As ColumnHeader
    Friend WithEvents ChFechaExpiracion As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
End Class
