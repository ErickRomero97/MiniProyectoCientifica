﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaSocio))
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LsvMostrarSocio
        '
        Me.LsvMostrarSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChRtnsocio, Me.ChCodSocio, Me.ChNombre, Me.ChApellido, Me.ChDireccion, Me.ChTelefono, Me.Chtelefonotrabajo, Me.ChLugar, Me.ChEmail, Me.ChSexo, Me.ChEstado, Me.ChNacionalidad, Me.ChProfecion})
        Me.LsvMostrarSocio.FullRowSelect = True
        Me.LsvMostrarSocio.GridLines = True
        Me.LsvMostrarSocio.Location = New System.Drawing.Point(12, 164)
        Me.LsvMostrarSocio.Name = "LsvMostrarSocio"
        Me.LsvMostrarSocio.Size = New System.Drawing.Size(698, 246)
        Me.LsvMostrarSocio.TabIndex = 97
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
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(179, 122)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 27)
        Me.txtBuscar.TabIndex = 95
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(195, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(240, 33)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Busqueda Socio"
        '
        'FrmBusquedaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 475)
        Me.Controls.Add(Me.LsvMostrarSocio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBuscar)
        Me.DoubleBuffered = True
        Me.Name = "FrmBusquedaSocio"
        Me.Text = "FrmBusquedaSocio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label12 As Label
End Class