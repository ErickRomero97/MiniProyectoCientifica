Imports System.Windows.Forms

Public Class MDIP

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BuscarOficialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarOficialToolStripMenuItem.Click
        Dim MIBuscarOficial As New FrmBuscarOficial()
        MIBuscarOficial.MdiParent = Me
        MIBuscarOficial.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MIBuscarOficial.Location = New Point(500, 50)

    End Sub

    Private Sub BuscarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarUsuarioToolStripMenuItem.Click
        Dim MIBuscarUsuario As New FrmBuscarUsuario()
        MIBuscarUsuario.MdiParent = Me
        MIBuscarUsuario.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MIBuscarUsuario.Location = New Point(500, 30)

    End Sub

    Private Sub BusquedaCuentaBancariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaCuentaBancariaToolStripMenuItem.Click
        Dim MIBuscarCuentaBancaria As New FrmBusquedaCuentaBancaria()
        MIBuscarCuentaBancaria.MdiParent = Me
        MIBuscarCuentaBancaria.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MIBuscarCuentaBancaria.Location = New Point(400, 50)

    End Sub

    Private Sub BusquedaSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaSocioToolStripMenuItem.Click
        Dim MIBuscarSocio As New FrmBusquedaSocio()
        MIBuscarSocio.MdiParent = Me
        MIBuscarSocio.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MIBuscarSocio.Location = New Point(350, 50)

    End Sub

    Private Sub BusquedaSolicitudPrestamoAvalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaSolicitudPrestamoAvalToolStripMenuItem.Click
        Dim MIBuscarSPrestamoAval As New FrmBusquedaSolicitudPrestamoAval()
        MIBuscarSPrestamoAval.MdiParent = Me
        MIBuscarSPrestamoAval.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MIBuscarSPrestamoAval.Location = New Point(450, 30)
    End Sub

    Private Sub NacionalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NacionalidadToolStripMenuItem.Click
        Dim MICataNacionalidad As New FrmNacionalidad()
        MICataNacionalidad.MdiParent = Me
        MICataNacionalidad.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MICataNacionalidad.Location = New Point(450, 80)
    End Sub

    Private Sub OficialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OficialToolStripMenuItem.Click
        Dim MICataOficial As New FrmOficial()
        MICataOficial.MdiParent = Me
        MICataOficial.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MICataOficial.Location = New Point(450, 30)

    End Sub

    Private Sub ProfeciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfeciónToolStripMenuItem.Click
        Dim MICataProfecion As New FrmProfesion()
        MICataProfecion.MdiParent = Me
        MICataProfecion.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MICataProfecion.Location = New Point(450, 100)

    End Sub

    Private Sub SocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocioToolStripMenuItem.Click
        Dim MICataSocio As New FrmSocio()
        MICataSocio.MdiParent = Me
        MICataSocio.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MICataSocio.Location = New Point(450, 30)

    End Sub

    Private Sub TipoCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoCuentaToolStripMenuItem.Click
        Dim MICataTipoCuenta As New FrmTipoCuenta()
        MICataTipoCuenta.MdiParent = Me
        MICataTipoCuenta.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MICataTipoCuenta.Location = New Point(450, 100)
    End Sub

    Private Sub TipoPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoPrestamoToolStripMenuItem.Click
        Dim MICataTipoPrestamo As New FrmTipoPrestamo()
        MICataTipoPrestamo.MdiParent = Me
        MICataTipoPrestamo.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MICataTipoPrestamo.Location = New Point(450, 100)

    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim MICataUsuario As New FrmUsuario()
        MICataUsuario.MdiParent = Me
        MICataUsuario.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MICataUsuario.Location = New Point(550, 60)

    End Sub

    Private Sub CuentaBancariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaBancariaToolStripMenuItem.Click
        Dim MITransaccionalCuentaBancaria As New FrmCuentaBancaria()
        MITransaccionalCuentaBancaria.MdiParent = Me
        MITransaccionalCuentaBancaria.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MITransaccionalCuentaBancaria.Location = New Point(450, 100)

    End Sub

    Private Sub SolicitudPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudPrestamoToolStripMenuItem.Click
        Dim MITransaccionalSolicitudPrestamo As New FrmSolicitudPrestamo()
        MITransaccionalSolicitudPrestamo.MdiParent = Me
        MITransaccionalSolicitudPrestamo.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MITransaccionalSolicitudPrestamo.Location = New Point(350, 0)

    End Sub

    Private Sub SolicitudPrestamoAvalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudPrestamoAvalToolStripMenuItem.Click
        Dim MITransaccionalSolicitudPrestamoAval As New FrmSolicitudPrestamo()
        MITransaccionalSolicitudPrestamoAval.MdiParent = Me
        MITransaccionalSolicitudPrestamoAval.Show()
        PBLogoPequeño.BringToFront()
        PBLogoGrande.SendToBack()
        PnlFondo.SendToBack()
        MITransaccionalSolicitudPrestamoAval.Location = New Point(350, 0)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()

    End Sub
End Class
