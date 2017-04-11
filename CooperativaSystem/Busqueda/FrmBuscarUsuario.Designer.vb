<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarUsuario))
        Me.LsvMostrarUsuario = New System.Windows.Forms.ListView()
        Me.ChCodigoUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChContrasena = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodigoOficial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbCodigoOficial = New System.Windows.Forms.RadioButton()
        Me.RdbNombreUsuario = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvMostrarUsuario
        '
        Me.LsvMostrarUsuario.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoUsuario, Me.ChNombre, Me.ChContrasena, Me.ChEstado, Me.ChCodigoOficial, Me.ChTipoUsuario})
        Me.LsvMostrarUsuario.FullRowSelect = True
        Me.LsvMostrarUsuario.GridLines = True
        Me.LsvMostrarUsuario.Location = New System.Drawing.Point(51, 275)
        Me.LsvMostrarUsuario.Name = "LsvMostrarUsuario"
        Me.LsvMostrarUsuario.Size = New System.Drawing.Size(539, 286)
        Me.LsvMostrarUsuario.TabIndex = 11
        Me.LsvMostrarUsuario.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarUsuario.View = System.Windows.Forms.View.Details
        '
        'ChCodigoUsuario
        '
        Me.ChCodigoUsuario.Text = "Codigo usuario"
        Me.ChCodigoUsuario.Width = 92
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre Usuario"
        Me.ChNombre.Width = 109
        '
        'ChContrasena
        '
        Me.ChContrasena.DisplayIndex = 3
        Me.ChContrasena.Text = "Contraseña"
        Me.ChContrasena.Width = 68
        '
        'ChEstado
        '
        Me.ChEstado.DisplayIndex = 2
        Me.ChEstado.Text = "Estado"
        Me.ChEstado.Width = 71
        '
        'ChCodigoOficial
        '
        Me.ChCodigoOficial.Text = "Codigo Oficial"
        Me.ChCodigoOficial.Width = 95
        '
        'ChTipoUsuario
        '
        Me.ChTipoUsuario.Text = "Tipo Usuario"
        Me.ChTipoUsuario.Width = 111
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(441, 229)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 33)
        Me.BtnBuscar.TabIndex = 10
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(97, 230)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(338, 32)
        Me.TxtBuscar.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbCodigoOficial)
        Me.GroupBox1.Controls.Add(Me.RdbNombreUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 66)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de busqueda"
        '
        'RdbCodigoOficial
        '
        Me.RdbCodigoOficial.AutoSize = True
        Me.RdbCodigoOficial.Location = New System.Drawing.Point(215, 32)
        Me.RdbCodigoOficial.Name = "RdbCodigoOficial"
        Me.RdbCodigoOficial.Size = New System.Drawing.Size(90, 17)
        Me.RdbCodigoOficial.TabIndex = 1
        Me.RdbCodigoOficial.TabStop = True
        Me.RdbCodigoOficial.Text = "Código Oficial"
        Me.RdbCodigoOficial.UseVisualStyleBackColor = True
        '
        'RdbNombreUsuario
        '
        Me.RdbNombreUsuario.AutoSize = True
        Me.RdbNombreUsuario.Location = New System.Drawing.Point(62, 32)
        Me.RdbNombreUsuario.Name = "RdbNombreUsuario"
        Me.RdbNombreUsuario.Size = New System.Drawing.Size(116, 17)
        Me.RdbNombreUsuario.TabIndex = 0
        Me.RdbNombreUsuario.TabStop = True
        Me.RdbNombreUsuario.Text = "Nombre de Usuario"
        Me.RdbNombreUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(179, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Busqueda Usuario"
        '
        'FrmBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(649, 583)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LsvMostrarUsuario)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "FrmBuscarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvMostrarUsuario As ListView
    Friend WithEvents ChCodigoUsuario As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChContrasena As ColumnHeader
    Friend WithEvents ChEstado As ColumnHeader
    Friend WithEvents ChCodigoOficial As ColumnHeader
    Friend WithEvents ChTipoUsuario As ColumnHeader
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbCodigoOficial As RadioButton
    Friend WithEvents RdbNombreUsuario As RadioButton
    Friend WithEvents Label1 As Label
End Class
