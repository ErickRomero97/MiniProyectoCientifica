Imports System.Data.SqlClient
Public Class FrmSolicitudPrestamoAval
    Private Sub LlenarCboNombreSocio()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LLenarComboSocioA"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Socio")
                Me.CboSocio.DataSource = ds.Tables(0)
                Me.CboSocio.DisplayMember = ds.Tables(0).Columns("CodSocio").ToString
                Me.CboSocio.ValueMember = ds.Tables(0).Columns("CodSocio").ToString

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Sub LlenarCboNumSolicitud()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LLenarComboSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "SolicitudPrestamo")
                Me.CboSolicitudP.DataSource = ds.Tables(0)
                Me.CboSolicitudP.DisplayMember = ds.Tables(0).Columns("NumSolicitudPrestamo").ToString
                Me.CboSolicitudP.ValueMember = ds.Tables(0).Columns("NumSolicitudPrestamo").ToString

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Gr As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        GrbSolicitud.Enabled = Gr
    End Sub

    Sub Limpiar()
        CboSocio.SelectedIndex = -1
        CboSolicitudP.SelectedIndex = -1
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        CboSocio.Focus()
        Limpiar()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validar() Then
            If ExisteSocioAval() = False Then
                Agregar()
                Limpiar()
                HabilitarBotones(True, False, False, False, False)
                Mostrar()
            End If
        End If
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar() Then
            Actualizar()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
            Mostrar()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
        Mostrar()
        HabilitarBotones(True, False, False, False, False)
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        CboSocio.Text = LsvSolicitudAval.FocusedItem.SubItems(0).Text
        CboSolicitudP.Text = LsvSolicitudAval.FocusedItem.SubItems(2).Text
        TbcSolicitudPA.SelectedIndex = 0
        HabilitarBotones(False, False, True, True, True)
    End Sub
    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoSolicitudAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerEquipo As SqlDataReader
                VerEquipo = cmd.ExecuteReader()
                LsvSolicitudAval.Items.Clear()

                While VerEquipo.Read = True
                    With Me.LsvSolicitudAval.Items.Add(VerEquipo("CodSocio").ToString)
                        .SubItems.Add(VerEquipo("NombreSocio").ToString)
                        .SubItems.Add(VerEquipo("NumSolicitudPrestamo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Sub Agregar()

        If ExisteRegistro() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Using cmd As New SqlCommand
                Try

                    With cmd
                        .CommandText = "Sp_InsertarSolicitudAval"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue
                        .Parameters.Add("@NumSolicitudPrestamo", SqlDbType.NVarChar, 11).Value = CboSolicitudP.SelectedValue
                        .Connection = cnn
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de la solicitud de pestamo del aval sido guardado con exito", "CooperativaSystem", MessageBoxButtons.OK)
                    End With

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using
        End If
    End Sub

    Private Function ExisteSocioAval() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_VerificarSocioAval"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NumSolicitudPrestamo", SqlDbType.NVarChar, 11).Value = CboSolicitudP.SelectedValue
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("El mismo solicitante no puede ser aval.", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Sub Actualizar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_ActualizarSolicitudAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue
                    .Parameters.Add("@NumSolicitudPrestamo", SqlDbType.NVarChar, 11).Value = CboSolicitudP.SelectedValue
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de la solicitud de prestamo del aval fue actualizado", "CooperativaSystem", MessageBoxButtons.OK)
                End With

            Catch ex As Exception
                If ex.ToString.Contains("clave ya existente") Then
                    MessageBox.Show("Ya se encuentra registrada solicitud de pestamo de aval", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox(ex.Message)
                End If
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub


    Private Sub Eliminar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_EliminarSolicitudAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumSolicitudPrestamo", SqlDbType.NVarChar, 11).Value = LsvSolicitudAval.FocusedItem.SubItems(2).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de la solicitud de prestamo de aval ha sido eliminado", "CooperativaSystem", MessageBoxButtons.OK)
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteRegistro() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "SP_ExisteSolicitudAval"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue
                    .Parameters.Add("@NumPrestamo", SqlDbType.NVarChar, 11).Value = CboSolicitudP.SelectedValue
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrada esta solicitud de prestamo por aval", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Sub FrmSolicitudPrestamoAval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Call LlenarCboNumSolicitud()
        Call LlenarCboNombreSocio()
        Call Limpiar()
        Call Mostrar()
    End Sub
    Private Function Validar() As Boolean
        Dim estado As Boolean

        If CboSocio.SelectedValue = Nothing And CboSolicitudP.SelectedValue = Nothing Then
            MessageBox.Show("Selecione todoslos valores.", "CooperaativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            estado = False
        ElseIf CboSocio.SelectedValue = Nothing Then
            MessageBox.Show("Seleccione el Nombre de un Socio.", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            estado = False
        ElseIf CboSolicitudP.SelectedValue = Nothing Then
            MessageBox.Show("Selecione el codigo del Solicitud de Prestamo", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function
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

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub

End Class