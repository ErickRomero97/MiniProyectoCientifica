Imports System.Data.SqlClient
Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarBotones(True, False, False, False, False)
        Call LlenarComboEstado()
        Call LlenarComboTipoUsuario()
        Call MostrarUsuario()
    End Sub

    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Groupbox As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        GbDatos.Enabled = Groupbox
    End Sub
    Private Sub Limpiar()
        TxtCodigo.Text = Nothing
        TxtNombre.Text = Nothing
        TxtContraseña.Text = Nothing
        CboEstado.Text = Nothing
        MtbCodigoOficial.Text = Nothing
        CboTipoUsuario.Text = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call HabilitarBotones(True, False, False, False, False)

        If Validar() Then
            Call AgregarUsuario()
            Call Limpiar()
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarBotones(False, True, False, True, True)
        Call InvestigarCorrelativo()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarBotones(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub LlenarComboTipoUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LlenarComboTipoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoUsuario")
                Me.CboTipoUsuario.DataSource = ds.Tables(0)
                Me.CboTipoUsuario.DisplayMember = ds.Tables(0).Columns("Usuario").ToString
                Me.CboTipoUsuario.ValueMember = ds.Tables(0).Columns("IdTIpoUsuario").ToString

            Catch ex As Exception

            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboEstado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LlenarComboEstado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Estado")
                Me.CboEstado.DataSource = ds.Tables(0)
                Me.CboEstado.DisplayMember = ds.Tables(0).Columns("Estado").ToString
                Me.CboEstado.ValueMember = ds.Tables(0).Columns("IdEstado").ToString

            Catch ex As Exception

            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Sub InvestigarCorrelativo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim Listar As New SqlCommand("Sp_MostrarIdUsuarioIdentity", cnn)
            Listar.CommandType = CommandType.StoredProcedure
            Dim Listar1 As SqlDataReader
            cnn.Open()
            Listar1 = Listar.ExecuteReader
            If Listar1.Read = True Then
                If Listar1("Id") Is DBNull.Value Then
                    TxtCodigo.Text = 1
                Else
                    TxtCodigo.Text = Listar1("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_InsertarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = Trim(TxtNombre.Text)
                    .Parameters.Add("@Contrasena", SqlDbType.NVarChar, 30).Value = Trim(TxtContraseña.Text)
                    .Parameters.Add("@IdEstado", SqlDbType.Int).Value = Trim(CboEstado.SelectedValue)
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 15).Value = Trim(MtbCodigoOficial.Text)
                    .Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = Trim(CboTipoUsuario.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El usuario ha sido registrado con éxito", "Cooperativa System", MessageBoxButtons.OK)
                    Call MostrarUsuario()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ActualizarUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ActualizarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdUsuario", SqlDbType.NVarChar, 50).Value = Trim(TxtCodigo.Text)
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = Trim(TxtNombre.Text)
                    .Parameters.Add("@Contrasena", SqlDbType.NVarChar, 30).Value = Trim(TxtContraseña.Text)
                    .Parameters.Add("@IdEstado", SqlDbType.Int).Value = Trim(CboEstado.SelectedValue)
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 15).Value = Trim(MtbCodigoOficial.Text)
                    .Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = Trim(CboTipoUsuario.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El usuario ha sido actualizado con éxito", "Cooperativa System", MessageBoxButtons.OK)
                    Call MostrarUsuario()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim Ver As SqlDataReader
                Ver = cmd.ExecuteReader()
                LsvMostrarUsuario.Items.Clear()
                While Ver.Read = True
                    With Me.LsvMostrarUsuario.Items.Add(Ver("IdUsuario").ToString)
                        .SubItems.Add(Ver("UserName").ToString)
                        .SubItems.Add(Ver("Contraseña").ToString)
                        .SubItems.Add(Ver("Estado").ToString)
                        .SubItems.Add(Ver("CodOficial").ToString)
                        .SubItems.Add(Ver("Usuario").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Call HabilitarBotones(True, False, False, False, False)

        If Validar() Then
            Call ActualizarUsuario()
            Call Limpiar()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        TxtCodigo.Text = LsvMostrarUsuario.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvMostrarUsuario.FocusedItem.SubItems(1).Text
        TxtContraseña.Text = LsvMostrarUsuario.FocusedItem.SubItems(2).Text
        CboEstado.Text = LsvMostrarUsuario.FocusedItem.SubItems(3).Text
        MtbCodigoOficial.Text = LsvMostrarUsuario.FocusedItem.SubItems(4).Text
        CboTipoUsuario.Text = LsvMostrarUsuario.FocusedItem.SubItems(5).Text
        TbcUsuario.SelectedIndex = 0
        HabilitarBotones(False, False, True, True, True)
    End Sub

    Private Function Validar() As Boolean
        Dim estado As Boolean

        If TxtCodigo.Text = "" And TxtNombre.Text = "" And TxtContraseña.Text = "" And CboEstado.Text = "" And MtbCodigoOficial.Text = "" And CboTipoUsuario.Text = "" Then
            Call HabilitarBotones(False, True, False, True, True)
            MessageBox.Show("Ingrese todos los datos.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNombre.Focus()
            estado = False
        ElseIf TxtNombre.Text = "" Then
            Call HabilitarBotones(False, True, False, True, True)
            MessageBox.Show("Ingrese el nombre de usuario.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNombre.Focus()
            estado = False
        ElseIf TxtContraseña.Text = "" Then
            Call HabilitarBotones(False, True, False, True, True)
            MessageBox.Show("Ingrese una contraseña.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtContraseña.Focus()
            estado = False
        ElseIf CboEstado.Text = "" Then
            Call HabilitarBotones(False, True, False, True, True)
            MessageBox.Show("Seleccione un estado.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CboEstado.Focus()
            estado = False
        ElseIf MtbCodigoOficial.Text = "" Then
            Call HabilitarBotones(False, True, False, True, True)
            MessageBox.Show("Seleccione un oficial.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MtbCodigoOficial.Focus()
            estado = False
        ElseIf CboTipoUsuario.Text = "" Then
            Call HabilitarBotones(False, True, False, True, True)
            MessageBox.Show("Seleccione un tipo de usuario.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CboTipoUsuario.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        FrmBuscarOficial.ShowDialog()
    End Sub
    Private Sub BtnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles BtnNuevo.MouseLeave
        LblNuevo.Text = ""
    End Sub

    Private Sub BtnNuevo_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnNuevo.MouseMove
        LblNuevo.Text = "Nuevo"
    End Sub

    Private Sub BtnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles BtnGuardar.MouseLeave
        LblGuardar.Text = ""
    End Sub

    Private Sub BtnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnGuardar.MouseMove
        LblGuardar.Text = "Guardar"
    End Sub

    Private Sub BtnEditar_MouseLeave(sender As Object, e As EventArgs) Handles BtnEditar.MouseLeave
        LblEditar.Text = ""
    End Sub

    Private Sub BtnEditar_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnEditar.MouseMove
        LblEditar.Text = "Editar"
    End Sub

    Private Sub BtnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancelar.MouseLeave
        LblCancelar.Text = ""
    End Sub

    Private Sub BtnCancelar_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnCancelar.MouseMove
        LblCancelar.Text = "Cancelar"
    End Sub
End Class