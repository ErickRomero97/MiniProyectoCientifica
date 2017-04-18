<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarOficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarOficial))
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LsvMostrarOficial = New System.Windows.Forms.ListView()
        Me.ChCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbNombre = New System.Windows.Forms.RadioButton()
        Me.RdbCodigoOficial = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(413, 238)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 33)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(69, 239)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(338, 32)
        Me.TxtBuscar.TabIndex = 6
        '
        'LsvMostrarOficial
        '
        Me.LsvMostrarOficial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigo, Me.ChNombre, Me.ChApellido, Me.ChDireccion, Me.ChTelefono, Me.ChSexo})
        Me.LsvMostrarOficial.FullRowSelect = True
        Me.LsvMostrarOficial.GridLines = True
        Me.LsvMostrarOficial.Location = New System.Drawing.Point(23, 277)
        Me.LsvMostrarOficial.Name = "LsvMostrarOficial"
        Me.LsvMostrarOficial.Size = New System.Drawing.Size(504, 326)
        Me.LsvMostrarOficial.TabIndex = 5
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbNombre)
        Me.GroupBox1.Controls.Add(Me.RdbCodigoOficial)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 66)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de busqueda"
        '
        'RdbNombre
        '
        Me.RdbNombre.AutoSize = True
        Me.RdbNombre.Location = New System.Drawing.Point(215, 32)
        Me.RdbNombre.Name = "RdbNombre"
        Me.RdbNombre.Size = New System.Drawing.Size(62, 17)
        Me.RdbNombre.TabIndex = 1
        Me.RdbNombre.TabStop = True
        Me.RdbNombre.Text = "Nombre"
        Me.RdbNombre.UseVisualStyleBackColor = True
        '
        'RdbCodigoOficial
        '
        Me.RdbCodigoOficial.AutoSize = True
        Me.RdbCodigoOficial.Location = New System.Drawing.Point(62, 32)
        Me.RdbCodigoOficial.Name = "RdbCodigoOficial"
        Me.RdbCodigoOficial.Size = New System.Drawing.Size(90, 17)
        Me.RdbCodigoOficial.TabIndex = 0
        Me.RdbCodigoOficial.TabStop = True
        Me.RdbCodigoOficial.Text = "Código Oficial"
        Me.RdbCodigoOficial.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(137, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Busqueda Oficial"
        '
        'FrmBuscarOficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(556, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvMostrarOficial)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBuscarOficial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Oficial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LsvMostrarOficial As ListView
    Friend WithEvents ChCodigo As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellido As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbNombre As RadioButton
    Friend WithEvents RdbCodigoOficial As RadioButton
    Friend WithEvents Label1 As Label
End Class
