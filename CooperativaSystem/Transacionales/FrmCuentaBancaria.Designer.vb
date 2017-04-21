<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentaBancaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCuentaBancaria))
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.LblEditar = New System.Windows.Forms.Label()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.CboSocio = New System.Windows.Forms.ComboBox()
        Me.CboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.TxtSaldoAc = New System.Windows.Forms.TextBox()
        Me.TxtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LsvCuentaBancaria = New System.Windows.Forms.ListView()
        Me.ChCodigoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSaldoActual = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbcCuentaBancaria = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrbCuentaB = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CmsOpciones.SuspendLayout()
        Me.TbcCuentaBancaria.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GrbCuentaB.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(450, 305)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(0, 15)
        Me.LblCancelar.TabIndex = 123
        '
        'LblEditar
        '
        Me.LblEditar.AutoSize = True
        Me.LblEditar.BackColor = System.Drawing.Color.Transparent
        Me.LblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditar.Location = New System.Drawing.Point(347, 307)
        Me.LblEditar.Name = "LblEditar"
        Me.LblEditar.Size = New System.Drawing.Size(0, 15)
        Me.LblEditar.TabIndex = 124
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(242, 307)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(0, 15)
        Me.LblGuardar.TabIndex = 125
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(150, 307)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(0, 15)
        Me.LblNuevo.TabIndex = 126
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
        Me.BtnCancelar.Location = New System.Drawing.Point(449, 241)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 119
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
        Me.BtnEditar.Location = New System.Drawing.Point(342, 241)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 120
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
        Me.BtnGuardar.Location = New System.Drawing.Point(240, 241)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 121
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
        Me.BtnNuevo.Location = New System.Drawing.Point(144, 241)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 122
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'CboSocio
        '
        Me.CboSocio.FormattingEnabled = True
        Me.CboSocio.Location = New System.Drawing.Point(221, 98)
        Me.CboSocio.Name = "CboSocio"
        Me.CboSocio.Size = New System.Drawing.Size(121, 21)
        Me.CboSocio.TabIndex = 85
        '
        'CboTipoCuenta
        '
        Me.CboTipoCuenta.FormattingEnabled = True
        Me.CboTipoCuenta.Location = New System.Drawing.Point(221, 68)
        Me.CboTipoCuenta.Name = "CboTipoCuenta"
        Me.CboTipoCuenta.Size = New System.Drawing.Size(121, 21)
        Me.CboTipoCuenta.TabIndex = 84
        '
        'TxtSaldoAc
        '
        Me.TxtSaldoAc.Location = New System.Drawing.Point(221, 42)
        Me.TxtSaldoAc.Name = "TxtSaldoAc"
        Me.TxtSaldoAc.Size = New System.Drawing.Size(121, 20)
        Me.TxtSaldoAc.TabIndex = 83
        '
        'TxtNumCuenta
        '
        Me.TxtNumCuenta.Location = New System.Drawing.Point(221, 16)
        Me.TxtNumCuenta.Name = "TxtNumCuenta"
        Me.TxtNumCuenta.Size = New System.Drawing.Size(121, 20)
        Me.TxtNumCuenta.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Numero de Cuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(163, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Socio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Tipo de Cuenta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Saldo Actual:"
        '
        'LsvCuentaBancaria
        '
        Me.LsvCuentaBancaria.BackColor = System.Drawing.Color.White
        Me.LsvCuentaBancaria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoCuenta, Me.ChSaldoActual, Me.ChTipoCuenta, Me.ChSocio, Me.ChNombreS})
        Me.LsvCuentaBancaria.ContextMenuStrip = Me.CmsOpciones
        Me.LsvCuentaBancaria.FullRowSelect = True
        Me.LsvCuentaBancaria.GridLines = True
        Me.LsvCuentaBancaria.Location = New System.Drawing.Point(14, 5)
        Me.LsvCuentaBancaria.Name = "LsvCuentaBancaria"
        Me.LsvCuentaBancaria.Size = New System.Drawing.Size(721, 328)
        Me.LsvCuentaBancaria.TabIndex = 116
        Me.LsvCuentaBancaria.UseCompatibleStateImageBehavior = False
        Me.LsvCuentaBancaria.View = System.Windows.Forms.View.Details
        '
        'ChCodigoCuenta
        '
        Me.ChCodigoCuenta.Text = "Codigo Cuenta Bancaria"
        Me.ChCodigoCuenta.Width = 138
        '
        'ChSaldoActual
        '
        Me.ChSaldoActual.Text = "Saldo Actual"
        Me.ChSaldoActual.Width = 118
        '
        'ChTipoCuenta
        '
        Me.ChTipoCuenta.Text = "Tipo de Cuenta"
        Me.ChTipoCuenta.Width = 95
        '
        'ChSocio
        '
        Me.ChSocio.Text = "Socio"
        Me.ChSocio.Width = 367
        '
        'ChNombreS
        '
        Me.ChNombreS.Text = "Nombre del Socio"
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
        'TbcCuentaBancaria
        '
        Me.TbcCuentaBancaria.Controls.Add(Me.TabPage1)
        Me.TbcCuentaBancaria.Controls.Add(Me.TabPage2)
        Me.TbcCuentaBancaria.Location = New System.Drawing.Point(-5, -3)
        Me.TbcCuentaBancaria.Name = "TbcCuentaBancaria"
        Me.TbcCuentaBancaria.SelectedIndex = 0
        Me.TbcCuentaBancaria.Size = New System.Drawing.Size(757, 363)
        Me.TbcCuentaBancaria.TabIndex = 127
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.BtnCerrar)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.GrbCuentaB)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.LblCancelar)
        Me.TabPage1.Controls.Add(Me.BtnNuevo)
        Me.TabPage1.Controls.Add(Me.LblEditar)
        Me.TabPage1.Controls.Add(Me.BtnEditar)
        Me.TabPage1.Controls.Add(Me.LblGuardar)
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.LblNuevo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(749, 337)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestion Cuenta Bancaria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(637, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "cerrar"
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
        Me.BtnCerrar.Location = New System.Drawing.Point(643, 26)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(39, 44)
        Me.BtnCerrar.TabIndex = 132
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(169, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(363, 33)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Gestión Cuenta Bancaria"
        '
        'GrbCuentaB
        '
        Me.GrbCuentaB.Controls.Add(Me.Label3)
        Me.GrbCuentaB.Controls.Add(Me.Label5)
        Me.GrbCuentaB.Controls.Add(Me.CboSocio)
        Me.GrbCuentaB.Controls.Add(Me.TxtNumCuenta)
        Me.GrbCuentaB.Controls.Add(Me.CboTipoCuenta)
        Me.GrbCuentaB.Controls.Add(Me.Label1)
        Me.GrbCuentaB.Controls.Add(Me.Label2)
        Me.GrbCuentaB.Controls.Add(Me.TxtSaldoAc)
        Me.GrbCuentaB.Location = New System.Drawing.Point(83, 100)
        Me.GrbCuentaB.Name = "GrbCuentaB"
        Me.GrbCuentaB.Size = New System.Drawing.Size(613, 125)
        Me.GrbCuentaB.TabIndex = 129
        Me.GrbCuentaB.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.LsvCuentaBancaria)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(749, 337)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listar Cuenta Bancaria"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FrmCuentaBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(746, 354)
        Me.Controls.Add(Me.TbcCuentaBancaria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCuentaBancaria"
        Me.Text = "FrmCuentaBancaria"
        Me.CmsOpciones.ResumeLayout(False)
        Me.TbcCuentaBancaria.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GrbCuentaB.ResumeLayout(False)
        Me.GrbCuentaB.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblCancelar As Label
    Friend WithEvents LblEditar As Label
    Friend WithEvents LblGuardar As Label
    Friend WithEvents LblNuevo As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents CboSocio As ComboBox
    Friend WithEvents CboTipoCuenta As ComboBox
    Friend WithEvents TxtSaldoAc As TextBox
    Friend WithEvents TxtNumCuenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LsvCuentaBancaria As ListView
    Friend WithEvents ChCodigoCuenta As ColumnHeader
    Friend WithEvents ChSaldoActual As ColumnHeader
    Friend WithEvents ChTipoCuenta As ColumnHeader
    Friend WithEvents ChSocio As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbcCuentaBancaria As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ChNombreS As ColumnHeader
    Friend WithEvents GrbCuentaB As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCerrar As Button
End Class
