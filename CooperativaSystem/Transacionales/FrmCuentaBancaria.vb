Imports System.Data.SqlClient
Public Class FrmCuentaBancaria
    Private Sub FrmCuentaBancaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Call LlenarComboSocio()
        Call LlenarComboTipoCuenta()
        Call Limpiar()
        Mostrar()
    End Sub
    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Grb As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        GrbCuentaB.Enabled = Grb
    End Sub

    Private Sub LlenarComboTipoCuenta()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LLenarComboTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoCuenta")
                Me.CboTipoCuenta.DataSource = ds.Tables(0)
                Me.CboTipoCuenta.DisplayMember = ds.Tables(0).Columns("TipoCuenta").ToString
                Me.CboTipoCuenta.ValueMember = ds.Tables(0).Columns("IdTipoCuenta").ToString

            Catch ex As Exception

            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboSocio()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LLenarComboSocio"
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

            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        TxtNumCuenta.Focus()
        Limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar() Then
            Agregar()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            Mostrar()
        End If
    End Sub

    Private Sub Btneditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar() Then
            Actualizar()
            Mostrar()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
        End If

    End Sub


    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Sub Limpiar()
        TxtNumCuenta.Text = ""
        TxtSaldoAc.Text = ""
        CboTipoCuenta.SelectedIndex = -1
        CboSocio.SelectedIndex = -1
    End Sub

    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarCuentaBancaria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim Ver As SqlDataReader
                Ver = cmd.ExecuteReader()
                LsvCuentaBancaria.Items.Clear()
                While Ver.Read = True
                    With Me.LsvCuentaBancaria.Items.Add(Ver("NumCuenta").ToString)
                        .SubItems.Add(Ver("SaldoActual").ToString)
                        .SubItems.Add(Ver("TipoCuenta").ToString)
                        .SubItems.Add(Ver("CodSocio").ToString)
                        .SubItems.Add(Ver("NombreSocio").ToString)
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
                        .CommandText = "Sp_InsertarCuentaBancaria"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@NumCuenta", SqlDbType.NVarChar, 11).Value = TxtNumCuenta.Text.Trim
                        .Parameters.Add("@SaldoActual", SqlDbType.Decimal, 10).Value = CDec(TxtSaldoAc.Text)
                        .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CInt(CboTipoCuenta.SelectedValue)
                        .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 1
                        .ExecuteNonQuery()
                        MessageBox.Show("se ha ingresado un nueva cuenta bancario", "Cooperativa System", MessageBoxButtons.OK)
                    End With


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub Actualizar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_ActualizarCuentaBancaria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumCuenta", SqlDbType.NVarChar, 11).Value = TxtNumCuenta.Text.Trim
                    .Parameters.Add("@SaldoActual", SqlDbType.Decimal, 10).Value = TxtSaldoAc.Text.Trim
                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CboTipoCuenta.SelectedValue
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = CboSocio.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 1
                    .ExecuteNonQuery()
                    MessageBox.Show("la cuenta bancaria ha sido actualizado", "Cooperativa System", MessageBoxButtons.OK)
                End With

            Catch ex As Exception
                If ex.ToString.Contains("clave ya existente") Then
                    MessageBox.Show("Ya se encuentra registrada esta  cuenta bancaria", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(ex.Message)
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
                    .CommandText = "Sp_EliminarCuentaBancaria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumCuenta", SqlDbType.NVarChar, 11).Value = LsvCuentaBancaria.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("la cuenta bancaria ha sido eliminado", "Cooperativa System", MessageBoxButtons.OK)
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtNumCuenta.Text = LsvCuentaBancaria.FocusedItem.SubItems(0).Text
        TxtSaldoAc.Text = LsvCuentaBancaria.FocusedItem.SubItems(1).Text
        CboTipoCuenta.Text = LsvCuentaBancaria.FocusedItem.SubItems(2).Text
        CboSocio.Text = LsvCuentaBancaria.FocusedItem.SubItems(3).Text
        TbcCuentaBancaria.SelectedIndex = 0
        HabilitarBotones(False, False, True, True, True)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
        Mostrar()
        HabilitarBotones(True, False, False, False, False)
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
                    .CommandText = "Sp_ExisteCuentaBancaria"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NumCuenta", SqlDbType.Decimal, 11).Value = TxtNumCuenta.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra esa  cuenta bancaria", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function Validar() As Boolean
        Dim estado As Boolean

        If TxtNumCuenta.Text = Nothing And TxtSaldoAc.Text = Nothing And CboTipoCuenta.SelectedValue = Nothing And CboSocio.SelectedValue = Nothing Then
            MessageBox.Show("Selecione e ingrese  todos los valores.", "CooperaativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            TxtNumCuenta.Focus()
            estado = False
        ElseIf TxtNumCuenta.Text = Nothing Then
            MessageBox.Show("Ingrese el Numero de Cuenta", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            TxtNumCuenta.Focus()
            estado = False
        ElseIf TxtSaldoAc.Text = Nothing Then
            MessageBox.Show("Ingrese el Saldo Actual de la cuenta", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            TxtSaldoAc.Focus()
            estado = False
        ElseIf CboTipoCuenta.SelectedValue = Nothing Then
            MessageBox.Show("Selecione el tipo de cuenta", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            estado = False
        ElseIf CboSocio.SelectedValue = Nothing Then
            MessageBox.Show("Seleccione el Nombre de un Socio.", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class