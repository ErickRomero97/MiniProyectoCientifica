<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaCuentaBancaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaCuentaBancaria))
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LsvCuentaBancaria = New System.Windows.Forms.ListView()
        Me.ChCodigoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSaldoActual = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidoS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoCodCuenta = New System.Windows.Forms.RadioButton()
        Me.RdoNombreSocio = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(492, 217)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(92, 39)
        Me.BtnBuscar.TabIndex = 104
        Me.BtnBuscar.Text = "Busqueda"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'LsvCuentaBancaria
        '
        Me.LsvCuentaBancaria.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvCuentaBancaria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoCuenta, Me.ChSaldoActual, Me.ChTipoCuenta, Me.ChSocio, Me.ChNombreS, Me.ChApellidoS})
        Me.LsvCuentaBancaria.FullRowSelect = True
        Me.LsvCuentaBancaria.GridLines = True
        Me.LsvCuentaBancaria.Location = New System.Drawing.Point(25, 273)
        Me.LsvCuentaBancaria.Name = "LsvCuentaBancaria"
        Me.LsvCuentaBancaria.Size = New System.Drawing.Size(683, 116)
        Me.LsvCuentaBancaria.TabIndex = 117
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
        Me.ChSaldoActual.Width = 95
        '
        'ChTipoCuenta
        '
        Me.ChTipoCuenta.Text = "Tipo de Cuenta"
        Me.ChTipoCuenta.Width = 97
        '
        'ChSocio
        '
        Me.ChSocio.Text = "Codigo del Socio"
        Me.ChSocio.Width = 185
        '
        'ChNombreS
        '
        Me.ChNombreS.Text = "Nombre Socio"
        Me.ChNombreS.Width = 118
        '
        'ChApellidoS
        '
        Me.ChApellidoS.Text = "Apellido Socio"
        Me.ChApellidoS.Width = 143
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(132, 227)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(281, 20)
        Me.TxtBuscar.TabIndex = 118
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 106)
        Me.Panel2.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(165, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda Cuenta Bancaria"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RdoCodCuenta)
        Me.GroupBox1.Controls.Add(Me.RdoNombreSocio)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 65)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Búsqueda:"
        '
        'RdoCodCuenta
        '
        Me.RdoCodCuenta.AutoSize = True
        Me.RdoCodCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoCodCuenta.Location = New System.Drawing.Point(0, 28)
        Me.RdoCodCuenta.Name = "RdoCodCuenta"
        Me.RdoCodCuenta.Size = New System.Drawing.Size(171, 20)
        Me.RdoCodCuenta.TabIndex = 0
        Me.RdoCodCuenta.TabStop = True
        Me.RdoCodCuenta.Text = "Codigo de la Cuenta:"
        Me.RdoCodCuenta.UseVisualStyleBackColor = True
        '
        'RdoNombreSocio
        '
        Me.RdoNombreSocio.AutoSize = True
        Me.RdoNombreSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoNombreSocio.Location = New System.Drawing.Point(245, 28)
        Me.RdoNombreSocio.Name = "RdoNombreSocio"
        Me.RdoNombreSocio.Size = New System.Drawing.Size(151, 20)
        Me.RdoNombreSocio.TabIndex = 1
        Me.RdoNombreSocio.TabStop = True
        Me.RdoNombreSocio.Text = "Nombre del Socio"
        Me.RdoNombreSocio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(668, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "cerrar"
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
        Me.BtnCerrar.Location = New System.Drawing.Point(674, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(39, 44)
        Me.BtnCerrar.TabIndex = 121
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'FrmBusquedaCuentaBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 469)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvCuentaBancaria)
        Me.Controls.Add(Me.BtnBuscar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBusquedaCuentaBancaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBusquedaCuentaBancaria"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LsvCuentaBancaria As ListView
    Friend WithEvents ChCodigoCuenta As ColumnHeader
    Friend WithEvents ChSaldoActual As ColumnHeader
    Friend WithEvents ChTipoCuenta As ColumnHeader
    Friend WithEvents ChSocio As ColumnHeader
    Friend WithEvents ChNombreS As ColumnHeader
    Friend WithEvents ChApellidoS As ColumnHeader
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdoCodCuenta As RadioButton
    Friend WithEvents RdoNombreSocio As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCerrar As Button
End Class
