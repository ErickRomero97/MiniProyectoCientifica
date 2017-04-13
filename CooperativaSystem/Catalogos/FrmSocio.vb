Imports System.Data.SqlClient
Public Class FrmSocio
    Private Sub FrmSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxSexo()
        LlenarComboboxEstado()
        LlenarComboboxNacionalidad()
        LlenarComboboxProfesion()
        MostrarSocio()
        HabilitarBotones(True, False, False, False, False)
    End Sub

    Private Sub MostrarSocio()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerSocio As SqlDataReader
                VerSocio = cmd.ExecuteReader()
                LsvMostrarSocio.Items.Clear()
                While VerSocio.Read = True
                    With Me.LsvMostrarSocio.Items.Add(VerSocio("CodSocio").ToString)
                        .SubItems.Add(VerSocio("RtnSocio").ToString)
                        .SubItems.Add(VerSocio("NombreSocio").ToString)
                        .SubItems.Add(VerSocio("ApellidoSocio").ToString)
                        .SubItems.Add(VerSocio("Direccion").ToString)
                        .SubItems.Add(VerSocio("TelefonoCasa").ToString)
                        .SubItems.Add(VerSocio("TelefonoTrabajo").ToString)
                        .SubItems.Add(VerSocio("LugarTrabajo").ToString)
                        .SubItems.Add(VerSocio("Correo").ToString)
                        .SubItems.Add(VerSocio("Sexo").ToString)
                        .SubItems.Add(VerSocio("Estado").ToString)
                        .SubItems.Add(VerSocio("Nacionalidad").ToString)
                        .SubItems.Add(VerSocio("Profesion").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Sub TPListarSocio_Click(sender As Object, e As EventArgs) Handles TPListarSocio.Click
        MostrarSocio()
    End Sub
    Private Sub HabilitarBotones(ByVal nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal datos As Boolean)
        BtnNuevo.Enabled = nuevo
        btnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        btnCancelar.Enabled = Cancelar
        GbDatos.Enabled = datos
    End Sub
    Private Sub InsertarSocio() '

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtCodSocio.Text.Trim
                    .Parameters.Add("@RTnSocio", SqlDbType.NVarChar, 15).Value = TxtRTNSocio.Text.Trim
                    .Parameters.Add("@NombreSocio", SqlDbType.NVarChar, 30).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@ApellidoSocio", SqlDbType.NVarChar, 30).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@TelefonoCasa", SqlDbType.NVarChar, 10).Value = mtbTelefono.Text.Trim
                    .Parameters.Add("@TelefonoTrabajo", SqlDbType.NVarChar, 10).Value = MtbTelefonoTrabajo.Text.Trim
                    .Parameters.Add("@LugarTrabajo", SqlDbType.NVarChar, 300).Value = TxtLugarTrabajo.Text.Trim
                    .Parameters.Add("@correo", SqlDbType.NVarChar, 60).Value = TxtEmail.Text.Trim
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdEstado", SqlDbType.Int).Value = CInt(Cboestadocivil.SelectedValue)
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(CboNacionalidad.SelectedValue)
                    .Parameters.Add("@IdProfecional", SqlDbType.Int).Value = CInt(CboProfecion.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de Socio Agregado", "Coperativa", MessageBoxButtons.OK)
                    MostrarSocio()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub

    Private Sub ActualizarSocio() '

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtCodSocio.Text.Trim
                    .Parameters.Add("@RTnSocio", SqlDbType.NVarChar, 15).Value = TxtRTNSocio.Text.Trim
                    .Parameters.Add("@NombreSocio", SqlDbType.NVarChar, 30).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@ApellidoSocio", SqlDbType.NVarChar, 30).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@TelefonoCasa", SqlDbType.NVarChar, 10).Value = mtbTelefono.Text.Trim
                    .Parameters.Add("@TelefonoTrabajo", SqlDbType.NVarChar, 10).Value = MtbTelefonoTrabajo.Text.Trim
                    .Parameters.Add("@LugarTrabajo", SqlDbType.NVarChar, 300).Value = TxtLugarTrabajo.Text.Trim
                    .Parameters.Add("@correo", SqlDbType.NVarChar, 60).Value = TxtEmail.Text.Trim
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdEstado", SqlDbType.Int).Value = CInt(Cboestadocivil.SelectedValue)
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(CboNacionalidad.SelectedValue)
                    .Parameters.Add("@IdProfecional", SqlDbType.Int).Value = CInt(CboProfecion.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de Socio Actualizado", "coperativa", MessageBoxButtons.OK)
                    MostrarSocio()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub


    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            MessageBox.Show(Mensaje, "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function
    Private Sub Limpiar()
        TxtCodSocio.Text = Nothing
        TxtRTNSocio.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellido.Text = Nothing
        TxtLugarTrabajo.Text = Nothing
        MtbTelefonoTrabajo.Text = Nothing
        TxtEmail.Text = Nothing
        mtbTelefono.Text = Nothing
        TxtDireccion.Text = Nothing
        CboSexo.SelectedIndex = -1
        Cboestadocivil.SelectedIndex = -1
        CboNacionalidad.SelectedIndex = -1
        CboProfecion.SelectedIndex = -1
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(TxtCodSocio, "Debe ingresar el codigo del socio") Then
        ElseIf Validar(TxtRTNSocio, "Debe ingresar el RTN Socio") Then
        ElseIf Validar(TxtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(TxtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(TxtEmail, "Debe seleccionar un Email") Then
        ElseIf Validar(mtbTelefono, "Debe ingresar un número de teléfono de casa") Then
        ElseIf Validar(MtbTelefonoTrabajo, "Debe ingresar un número de teléfono de trabajo") Then
        ElseIf Validar(TxtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(TxtLugarTrabajo, "Debe ingresar el lugar de trabajo") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un sexo") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un Estado") Then
        ElseIf Validar(CboSexo, "Debe seleccionar una Nacionalidad") Then
        ElseIf Validar(CboSexo, "Debe seleccionar una Profecion") Then
        Else
            HabilitarBotones(True, False, False, False, False)
            InsertarSocio()
            MostrarSocio()
            Limpiar()
        End If
    End Sub


    Private Sub LlenarComboboxSexo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                Me.CboSexo.DataSource = ds.Tables(0)
                Me.CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
                Me.CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString

            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub LlenarComboboxEstado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboEstado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Estado")
                Me.Cboestadocivil.DataSource = ds.Tables(0)
                Me.Cboestadocivil.ValueMember = ds.Tables(0).Columns("IdEstado").ToString
                Me.Cboestadocivil.DisplayMember = ds.Tables(0).Columns("Estado").ToString

            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub LlenarComboboxNacionalidad()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Nacionalidad")
                Me.CboNacionalidad.DataSource = ds.Tables(0)
                Me.CboNacionalidad.ValueMember = ds.Tables(0).Columns("IdNacionalidad").ToString
                Me.CboNacionalidad.DisplayMember = ds.Tables(0).Columns("Nacionalidad").ToString

            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub



    Private Sub LlenarComboboxProfesion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Profesion")
                Me.CboProfecion.DataSource = ds.Tables(0)
                Me.CboProfecion.ValueMember = ds.Tables(0).Columns("IdProfesion").ToString
                Me.CboProfecion.DisplayMember = ds.Tables(0).Columns("Profesion").ToString

            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodSocio.Text = LsvMostrarSocio.FocusedItem.SubItems(0).Text
        TxtRTNSocio.Text = LsvMostrarSocio.FocusedItem.SubItems(1).Text
        TxtNombre.Text = LsvMostrarSocio.FocusedItem.SubItems(2).Text
        TxtApellido.Text = LsvMostrarSocio.FocusedItem.SubItems(3).Text
        TxtDireccion.Text = LsvMostrarSocio.FocusedItem.SubItems(4).Text
        mtbTelefono.Text = LsvMostrarSocio.FocusedItem.SubItems(5).Text
        MtbTelefonoTrabajo.Text = LsvMostrarSocio.FocusedItem.SubItems(6).Text
        TxtLugarTrabajo.Text = LsvMostrarSocio.FocusedItem.SubItems(7).Text
        TxtEmail.Text = LsvMostrarSocio.FocusedItem.SubItems(8).Text
        CboSexo.Text = LsvMostrarSocio.FocusedItem.SubItems(9).Text
        Cboestadocivil.Text = LsvMostrarSocio.FocusedItem.SubItems(10).Text
        CboNacionalidad.Text = LsvMostrarSocio.FocusedItem.SubItems(11).Text
        CboProfecion.Text = LsvMostrarSocio.FocusedItem.SubItems(12).Text
        HabilitarBotones(False, False, True, True, True)
        TbcSocio.SelectedIndex = 0

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        HabilitarBotones(True, False, False, False, False)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
        If Validar(TxtCodSocio, "Debe ingresar el codigo del socio") Then
        ElseIf Validar(TxtRTNSocio, "Debe ingresar el RTN Socio") Then
        ElseIf Validar(TxtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(TxtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(TxtEmail, "Debe seleccionar un Email") Then
        ElseIf Validar(mtbTelefono, "Debe ingresar un número de teléfono de casa") Then
        ElseIf Validar(MtbTelefonoTrabajo, "Debe ingresar un número de teléfono de trabajo") Then
        ElseIf Validar(TxtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(TxtLugarTrabajo, "Debe ingresar el lugar de trabajo") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un sexo") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un Estado") Then
        ElseIf Validar(CboSexo, "Debe seleccionar una Nacionalidad") Then
        ElseIf Validar(CboSexo, "Debe seleccionar una Profecion") Then
        Else
            HabilitarBotones(True, False, False, False, False)
            ActualizarSocio()
            MostrarSocio()
            Limpiar()
        End If
    End Sub
    Private Sub BtnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles BtnNuevo.MouseLeave
        LblNuevo.Text = ""
    End Sub

    Private Sub BtnNuevo_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnNuevo.MouseMove
        LblNuevo.Text = "Nuevo"
    End Sub

    Private Sub BtnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        LblGuardar.Text = ""
    End Sub

    Private Sub BtnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        LblGuardar.Text = "Guardar"
    End Sub

    Private Sub BtnEditar_MouseLeave(sender As Object, e As EventArgs) Handles BtnEditar.MouseLeave
        LblEditar.Text = ""
    End Sub

    Private Sub BtnEditar_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnEditar.MouseMove
        LblEditar.Text = "Editar"
    End Sub

    Private Sub BtnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelar.MouseLeave
        LblCancelar.Text = ""
    End Sub

    Private Sub BtnCancelar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCancelar.MouseMove
        LblCancelar.Text = "Cancelar"
    End Sub
End Class