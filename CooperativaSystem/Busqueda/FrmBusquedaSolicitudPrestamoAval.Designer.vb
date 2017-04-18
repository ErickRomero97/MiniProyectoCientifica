<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaSolicitudPrestamoAval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaSolicitudPrestamoAval))
        Me.LsvSolicitudPA = New System.Windows.Forms.ListView()
        Me.ChCodSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidoSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodigoSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoCodSocio = New System.Windows.Forms.RadioButton()
        Me.RdoCodSolicitudAval = New System.Windows.Forms.RadioButton()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvSolicitudPA
        '
        Me.LsvSolicitudPA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvSolicitudPA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodSocio, Me.ChNombreSocio, Me.ChApellidoSocio, Me.ChCodigoSolicitud})
        Me.LsvSolicitudPA.GridLines = True
        Me.LsvSolicitudPA.Location = New System.Drawing.Point(12, 323)
        Me.LsvSolicitudPA.Name = "LsvSolicitudPA"
        Me.LsvSolicitudPA.Size = New System.Drawing.Size(674, 146)
        Me.LsvSolicitudPA.TabIndex = 105
        Me.LsvSolicitudPA.UseCompatibleStateImageBehavior = False
        Me.LsvSolicitudPA.View = System.Windows.Forms.View.Details
        '
        'ChCodSocio
        '
        Me.ChCodSocio.Text = "Código del Socio"
        Me.ChCodSocio.Width = 137
        '
        'ChNombreSocio
        '
        Me.ChNombreSocio.Text = "Nombre del Socio"
        Me.ChNombreSocio.Width = 146
        '
        'ChApellidoSocio
        '
        Me.ChApellidoSocio.Text = "Apellido del Socio"
        Me.ChApellidoSocio.Width = 177
        '
        'ChCodigoSolicitud
        '
        Me.ChCodigoSolicitud.Text = "Codigo de la Solicitud de Prestamo"
        Me.ChCodigoSolicitud.Width = 337
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(428, 248)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(92, 39)
        Me.BtnBuscar.TabIndex = 104
        Me.BtnBuscar.Text = "Busqueda"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(43, 267)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(355, 20)
        Me.TxtBuscar.TabIndex = 106
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(4, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 91)
        Me.Panel2.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(181, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solicitud Prestamo Aval"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoCodSocio)
        Me.GroupBox1.Controls.Add(Me.RdoCodSolicitudAval)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 69)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda:"
        '
        'RdoCodSocio
        '
        Me.RdoCodSocio.AutoSize = True
        Me.RdoCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoCodSocio.Location = New System.Drawing.Point(26, 30)
        Me.RdoCodSocio.Name = "RdoCodSocio"
        Me.RdoCodSocio.Size = New System.Drawing.Size(146, 20)
        Me.RdoCodSocio.TabIndex = 0
        Me.RdoCodSocio.TabStop = True
        Me.RdoCodSocio.Text = "Código del Socio"
        Me.RdoCodSocio.UseVisualStyleBackColor = True
        '
        'RdoCodSolicitudAval
        '
        Me.RdoCodSolicitudAval.AutoSize = True
        Me.RdoCodSolicitudAval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoCodSolicitudAval.Location = New System.Drawing.Point(229, 30)
        Me.RdoCodSolicitudAval.Name = "RdoCodSolicitudAval"
        Me.RdoCodSolicitudAval.Size = New System.Drawing.Size(271, 20)
        Me.RdoCodSolicitudAval.TabIndex = 1
        Me.RdoCodSolicitudAval.TabStop = True
        Me.RdoCodSolicitudAval.Text = "Codigo de la Solicitud de Prestamo"
        Me.RdoCodSolicitudAval.UseVisualStyleBackColor = True
        '
        'FrmBusquedaSolicitudPrestamoAval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(689, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvSolicitudPA)
        Me.Controls.Add(Me.BtnBuscar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBusquedaSolicitudPrestamoAval"
        Me.Text = "FrmBusquedaSolicitudPrestamoAval"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LsvSolicitudPA As ListView
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents ChNombreSocio As ColumnHeader
    Friend WithEvents ChCodigoSolicitud As ColumnHeader
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdoCodSocio As RadioButton
    Friend WithEvents RdoCodSolicitudAval As RadioButton
    Friend WithEvents ChApellidoSocio As ColumnHeader
End Class
