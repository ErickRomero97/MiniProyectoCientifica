<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarOficialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaCuentaBancariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaSocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaSolicitudPrestamoAvalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NacionalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OficialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfeciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaBancariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudPrestamoAvalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblIdUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PnlFondo = New System.Windows.Forms.Panel()
        Me.PBLogoGrande = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.BtnCambiarUsuario = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PbUser = New System.Windows.Forms.PictureBox()
        Me.PBLogoPequeño = New System.Windows.Forms.PictureBox()
        Me.LogAuditoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PnlFondo.SuspendLayout()
        CType(Me.PBLogoGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLogoPequeño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.LogAuditoriaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 25)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarOficialToolStripMenuItem, Me.BuscarUsuarioToolStripMenuItem, Me.BusquedaCuentaBancariaToolStripMenuItem, Me.BusquedaSocioToolStripMenuItem, Me.BusquedaSolicitudPrestamoAvalToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripMenuItem1.Text = "&Busqueda"
        '
        'BuscarOficialToolStripMenuItem
        '
        Me.BuscarOficialToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BuscarOficialToolStripMenuItem.Image = CType(resources.GetObject("BuscarOficialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarOficialToolStripMenuItem.Name = "BuscarOficialToolStripMenuItem"
        Me.BuscarOficialToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BuscarOficialToolStripMenuItem.Text = "BuscarOficial"
        '
        'BuscarUsuarioToolStripMenuItem
        '
        Me.BuscarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.BuscarUsuarioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BuscarUsuarioToolStripMenuItem.Image = CType(resources.GetObject("BuscarUsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarUsuarioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BuscarUsuarioToolStripMenuItem.Name = "BuscarUsuarioToolStripMenuItem"
        Me.BuscarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BuscarUsuarioToolStripMenuItem.Text = "BuscarUsuario"
        '
        'BusquedaCuentaBancariaToolStripMenuItem
        '
        Me.BusquedaCuentaBancariaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BusquedaCuentaBancariaToolStripMenuItem.Image = CType(resources.GetObject("BusquedaCuentaBancariaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BusquedaCuentaBancariaToolStripMenuItem.Name = "BusquedaCuentaBancariaToolStripMenuItem"
        Me.BusquedaCuentaBancariaToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BusquedaCuentaBancariaToolStripMenuItem.Text = "BusquedaCuentaBancaria"
        '
        'BusquedaSocioToolStripMenuItem
        '
        Me.BusquedaSocioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BusquedaSocioToolStripMenuItem.Image = CType(resources.GetObject("BusquedaSocioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BusquedaSocioToolStripMenuItem.Name = "BusquedaSocioToolStripMenuItem"
        Me.BusquedaSocioToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BusquedaSocioToolStripMenuItem.Text = "BusquedaSocio"
        '
        'BusquedaSolicitudPrestamoAvalToolStripMenuItem
        '
        Me.BusquedaSolicitudPrestamoAvalToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BusquedaSolicitudPrestamoAvalToolStripMenuItem.Image = CType(resources.GetObject("BusquedaSolicitudPrestamoAvalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BusquedaSolicitudPrestamoAvalToolStripMenuItem.Name = "BusquedaSolicitudPrestamoAvalToolStripMenuItem"
        Me.BusquedaSolicitudPrestamoAvalToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BusquedaSolicitudPrestamoAvalToolStripMenuItem.Text = "BusquedaSolicitudPrestamoAval"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NacionalidadToolStripMenuItem, Me.OficialToolStripMenuItem, Me.ProfeciónToolStripMenuItem, Me.SocioToolStripMenuItem, Me.TipoCuentaToolStripMenuItem, Me.TipoPrestamoToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(94, 21)
        Me.ToolStripMenuItem2.Text = "&Catálogo"
        '
        'NacionalidadToolStripMenuItem
        '
        Me.NacionalidadToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NacionalidadToolStripMenuItem.Image = CType(resources.GetObject("NacionalidadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NacionalidadToolStripMenuItem.Name = "NacionalidadToolStripMenuItem"
        Me.NacionalidadToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.NacionalidadToolStripMenuItem.Text = "Nacionalidad"
        '
        'OficialToolStripMenuItem
        '
        Me.OficialToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OficialToolStripMenuItem.Image = CType(resources.GetObject("OficialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OficialToolStripMenuItem.Name = "OficialToolStripMenuItem"
        Me.OficialToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.OficialToolStripMenuItem.Text = "Oficial"
        '
        'ProfeciónToolStripMenuItem
        '
        Me.ProfeciónToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProfeciónToolStripMenuItem.Image = CType(resources.GetObject("ProfeciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProfeciónToolStripMenuItem.Name = "ProfeciónToolStripMenuItem"
        Me.ProfeciónToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ProfeciónToolStripMenuItem.Text = "Profeción"
        '
        'SocioToolStripMenuItem
        '
        Me.SocioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SocioToolStripMenuItem.Image = CType(resources.GetObject("SocioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SocioToolStripMenuItem.Name = "SocioToolStripMenuItem"
        Me.SocioToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SocioToolStripMenuItem.Text = "Socio"
        '
        'TipoCuentaToolStripMenuItem
        '
        Me.TipoCuentaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TipoCuentaToolStripMenuItem.Image = CType(resources.GetObject("TipoCuentaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoCuentaToolStripMenuItem.Name = "TipoCuentaToolStripMenuItem"
        Me.TipoCuentaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TipoCuentaToolStripMenuItem.Text = "TipoCuenta"
        '
        'TipoPrestamoToolStripMenuItem
        '
        Me.TipoPrestamoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TipoPrestamoToolStripMenuItem.Image = CType(resources.GetObject("TipoPrestamoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoPrestamoToolStripMenuItem.Name = "TipoPrestamoToolStripMenuItem"
        Me.TipoPrestamoToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TipoPrestamoToolStripMenuItem.Text = "TipoPrestamo"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UsuarioToolStripMenuItem.Image = CType(resources.GetObject("UsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentaBancariaToolStripMenuItem, Me.SolicitudPrestamoToolStripMenuItem, Me.SolicitudPrestamoAvalToolStripMenuItem})
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(143, 21)
        Me.ToolStripMenuItem3.Text = "&Transaccionales"
        '
        'CuentaBancariaToolStripMenuItem
        '
        Me.CuentaBancariaToolStripMenuItem.Image = CType(resources.GetObject("CuentaBancariaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CuentaBancariaToolStripMenuItem.Name = "CuentaBancariaToolStripMenuItem"
        Me.CuentaBancariaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.CuentaBancariaToolStripMenuItem.Text = "CuentaBancaria"
        '
        'SolicitudPrestamoToolStripMenuItem
        '
        Me.SolicitudPrestamoToolStripMenuItem.Image = CType(resources.GetObject("SolicitudPrestamoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SolicitudPrestamoToolStripMenuItem.Name = "SolicitudPrestamoToolStripMenuItem"
        Me.SolicitudPrestamoToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SolicitudPrestamoToolStripMenuItem.Text = "SolicitudPrestamo"
        '
        'SolicitudPrestamoAvalToolStripMenuItem
        '
        Me.SolicitudPrestamoAvalToolStripMenuItem.Image = CType(resources.GetObject("SolicitudPrestamoAvalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SolicitudPrestamoAvalToolStripMenuItem.Name = "SolicitudPrestamoAvalToolStripMenuItem"
        Me.SolicitudPrestamoAvalToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SolicitudPrestamoAvalToolStripMenuItem.Text = "SolicitudPrestamoAval"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LblIdUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'LblIdUsuario
        '
        Me.LblIdUsuario.Name = "LblIdUsuario"
        Me.LblIdUsuario.Size = New System.Drawing.Size(0, 17)
        '
        'PnlFondo
        '
        Me.PnlFondo.BackgroundImage = CType(resources.GetObject("PnlFondo.BackgroundImage"), System.Drawing.Image)
        Me.PnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlFondo.Controls.Add(Me.PBLogoGrande)
        Me.PnlFondo.Location = New System.Drawing.Point(255, 12)
        Me.PnlFondo.Name = "PnlFondo"
        Me.PnlFondo.Size = New System.Drawing.Size(1107, 704)
        Me.PnlFondo.TabIndex = 22
        '
        'PBLogoGrande
        '
        Me.PBLogoGrande.BackColor = System.Drawing.Color.Transparent
        Me.PBLogoGrande.BackgroundImage = CType(resources.GetObject("PBLogoGrande.BackgroundImage"), System.Drawing.Image)
        Me.PBLogoGrande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBLogoGrande.Location = New System.Drawing.Point(149, 29)
        Me.PBLogoGrande.Name = "PBLogoGrande"
        Me.PBLogoGrande.Size = New System.Drawing.Size(798, 589)
        Me.PBLogoGrande.TabIndex = 20
        Me.PBLogoGrande.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.BtnCerrarSesion)
        Me.Panel2.Controls.Add(Me.BtnCambiarUsuario)
        Me.Panel2.Controls.Add(Me.LblUser)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PbUser)
        Me.Panel2.Controls.Add(Me.PBLogoPequeño)
        Me.Panel2.Location = New System.Drawing.Point(3, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 702)
        Me.Panel2.TabIndex = 23
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.BtnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(-3, 277)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(255, 33)
        Me.BtnCerrarSesion.TabIndex = 26
        Me.BtnCerrarSesion.Text = "Cerrar Sesión"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = False
        '
        'BtnCambiarUsuario
        '
        Me.BtnCambiarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.BtnCambiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCambiarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnCambiarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCambiarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnCambiarUsuario.Location = New System.Drawing.Point(-3, 237)
        Me.BtnCambiarUsuario.Name = "BtnCambiarUsuario"
        Me.BtnCambiarUsuario.Size = New System.Drawing.Size(255, 33)
        Me.BtnCambiarUsuario.TabIndex = 26
        Me.BtnCambiarUsuario.Text = "Cambiar de Usuario"
        Me.BtnCambiarUsuario.UseVisualStyleBackColor = False
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.White
        Me.LblUser.Location = New System.Drawing.Point(41, 187)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(135, 29)
        Me.LblUser.TabIndex = 2
        Me.LblUser.Text = "User Name"
        Me.LblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(3, 370)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 233)
        Me.Panel3.TabIndex = 25
        '
        'PbUser
        '
        Me.PbUser.BackColor = System.Drawing.Color.Transparent
        Me.PbUser.BackgroundImage = CType(resources.GetObject("PbUser.BackgroundImage"), System.Drawing.Image)
        Me.PbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbUser.Location = New System.Drawing.Point(43, 25)
        Me.PbUser.Name = "PbUser"
        Me.PbUser.Size = New System.Drawing.Size(161, 154)
        Me.PbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbUser.TabIndex = 3
        Me.PbUser.TabStop = False
        '
        'PBLogoPequeño
        '
        Me.PBLogoPequeño.BackColor = System.Drawing.Color.Transparent
        Me.PBLogoPequeño.BackgroundImage = CType(resources.GetObject("PBLogoPequeño.BackgroundImage"), System.Drawing.Image)
        Me.PBLogoPequeño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBLogoPequeño.Location = New System.Drawing.Point(3, 320)
        Me.PBLogoPequeño.Name = "PBLogoPequeño"
        Me.PBLogoPequeño.Size = New System.Drawing.Size(249, 250)
        Me.PBLogoPequeño.TabIndex = 24
        Me.PBLogoPequeño.TabStop = False
        '
        'LogAuditoriaToolStripMenuItem
        '
        Me.LogAuditoriaToolStripMenuItem.Name = "LogAuditoriaToolStripMenuItem"
        Me.LogAuditoriaToolStripMenuItem.Size = New System.Drawing.Size(103, 21)
        Me.LogAuditoriaToolStripMenuItem.Text = "LogAuditoria"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PnlFondo)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmPrincipal"
        Me.Tag = ""
        Me.Text = " MDIPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PnlFondo.ResumeLayout(False)
        CType(Me.PBLogoGrande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLogoPequeño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BuscarOficialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaCuentaBancariaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaSocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaSolicitudPrestamoAvalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents NacionalidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OficialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfeciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents CuentaBancariaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitudPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitudPrestamoAvalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PnlFondo As Panel
    Friend WithEvents PBLogoGrande As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PBLogoPequeño As PictureBox
    Friend WithEvents LblUser As Label
    Friend WithEvents PbUser As PictureBox
    Friend WithEvents BtnCambiarUsuario As Button
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents LblIdUsuario As ToolStripStatusLabel
    Friend WithEvents LogAuditoriaToolStripMenuItem As ToolStripMenuItem
End Class
