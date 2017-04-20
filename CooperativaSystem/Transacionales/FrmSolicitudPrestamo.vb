Imports System.Data.SqlClient
Public Class FrmSolicitudPrestamo
    Private Sub FrmSolicitudPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarBotones(True, False, False, False, False, False, False, False)
        Call LlenarComboTipoPrestamo()
        Call MostrarPrestamos()
    End Sub

    Private Sub Limpiar()
        TxtNumPrestamo.Text = Nothing
        CboTipoPrestamo.Text = Nothing
        TxtIdentidad.Text = Nothing
        TxtNombre.Text = Nothing
        TxtRTN.Text = Nothing
        TxtNacionalidad.Text = Nothing
        TxtEstadoCivil.Text = Nothing
        TxtDireccion.Text = Nothing
        TxtSumaSolicitada.Text = Nothing
        TxtSumaOtorgada.Text = Nothing
        TxtPlazo.Text = Nothing
        TxtTasa.Text = Nothing
        TxtFinalidad.Text = Nothing
        LsvCuenta.Items.Clear()
    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal GbDatosGenerales1 As Boolean, ByVal GbDatosSocio1 As Boolean, ByVal GbCuenta1 As Boolean, ByVal GbDatosPrestamo1 As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        GbDatosGenerales.Enabled = GbDatosGenerales1
        GbDatoSocio.Enabled = GbDatosSocio1
        GbCuentas.Enabled = GbCuenta1
        GbDatosPrestamo.Enabled = GbDatosPrestamo1
    End Sub

    Private Sub LlenarComboTipoPrestamo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LlenarComboTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Socio")
                Me.CboTipoPrestamo.DataSource = ds.Tables(0)
                Me.CboTipoPrestamo.DisplayMember = ds.Tables(0).Columns("TipoPrestamo").ToString
                Me.CboTipoPrestamo.ValueMember = ds.Tables(0).Columns("IdTipoPrestamo").ToString
            Catch ex As Exception

            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarCuentas()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarCuentas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtIdentidad.Text
                End With
                Dim VerCuenta As SqlDataReader
                VerCuenta = cmd.ExecuteReader()
                LsvCuenta.Items.Clear()
                While VerCuenta.Read = True
                    With Me.LsvCuenta.Items.Add(VerCuenta("NumCuenta").ToString)
                        .SubItems.Add(VerCuenta("TipoCuenta").ToString)
                        .SubItems.Add(VerCuenta("DescripcionCuenta").ToString)
                        .SubItems.Add(VerCuenta("SaldoActual").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarPrestamos()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerPrestamo As SqlDataReader
                VerPrestamo = cmd.ExecuteReader()
                LsvPrestamo.Items.Clear()
                While VerPrestamo.Read = True
                    With Me.LsvPrestamo.Items.Add(VerPrestamo("NumSolicitudPrestamo").ToString)
                        .SubItems.Add(VerPrestamo("FechaSolicitud").ToString)
                        .SubItems.Add(VerPrestamo("TipoPrestamo").ToString)
                        .SubItems.Add(VerPrestamo("CodSocio").ToString)
                        .SubItems.Add(VerPrestamo("NombreSocio").ToString)
                        .SubItems.Add(VerPrestamo("RTnSocio").ToString)
                        .SubItems.Add(VerPrestamo("Nacionalidad").ToString)
                        .SubItems.Add(VerPrestamo("EstadoCivil").ToString)
                        .SubItems.Add(VerPrestamo("Direccion").ToString)
                        .SubItems.Add(VerPrestamo("SumaSolicitada").ToString)
                        .SubItems.Add(VerPrestamo("SumaEntregada").ToString)
                        .SubItems.Add(VerPrestamo("PlazoPago").ToString)
                        .SubItems.Add(VerPrestamo("TasaInteres").ToString)
                        .SubItems.Add(VerPrestamo("FinalidadPrestamo").ToString)
                        .SubItems.Add(VerPrestamo("FechaExpiracion").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub CalcularSaldo()
        Dim Subtotal As Double
        Dim i As Integer

        For i = 0 To LsvCuenta.Items.Count - 1
            Subtotal = Subtotal + LsvCuenta.Items(i).SubItems(3).Text
        Next
        TxtSaldo.Text = FormatCurrency(Subtotal)
    End Sub

    Private Sub AgregarPrestamo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_InsertarPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumPrestamo", SqlDbType.NVarChar, 11).Value = TxtNumPrestamo.Text.Trim
                    .Parameters.Add("@FechaSolicitud", SqlDbType.Date).Value = DtpFechaSolicitud.Text.Trim
                    .Parameters.Add("@PlazoPago", SqlDbType.Decimal).Value = TxtPlazo.Text.Trim
                    .Parameters.Add("@FechaExpiracion", SqlDbType.Date).Value = DtpFechaExpiracion.Text.Trim
                    .Parameters.Add("@SumaSolicitada", SqlDbType.Decimal).Value = TxtSumaSolicitada.Text.Trim
                    .Parameters.Add("@SumaEntregada", SqlDbType.Decimal).Value = TxtSumaOtorgada.Text.Trim
                    .Parameters.Add("@TasaInteres", SqlDbType.Decimal).Value = TxtTasa.Text.Trim
                    .Parameters.Add("@FinalidadPrestamo", SqlDbType.NVarChar, 300).Value = TxtFinalidad.Text.Trim
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtIdentidad.Text.Trim
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CboTipoPrestamo.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 1
                    .ExecuteNonQuery()
                    MessageBox.Show("Se ha guardado el préstamo con éxito", "Cooperativa System", MessageBoxButtons.OK)
                    Call MostrarPrestamos()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ActualizarPrestamo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_ActualizarPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumPrestamo", SqlDbType.NVarChar, 11).Value = TxtNumPrestamo.Text.Trim
                    .Parameters.Add("@FechaSolicitud", SqlDbType.Date).Value = DtpFechaSolicitud.Text.Trim
                    .Parameters.Add("@PlazoPago", SqlDbType.Decimal).Value = TxtPlazo.Text.Trim
                    .Parameters.Add("@FechaExpiracion", SqlDbType.Date).Value = DtpFechaExpiracion.Text.Trim
                    .Parameters.Add("@SumaSolicitada", SqlDbType.Decimal).Value = TxtSumaSolicitada.Text.Trim
                    .Parameters.Add("@SumaEntregada", SqlDbType.Decimal).Value = TxtSumaOtorgada.Text.Trim
                    .Parameters.Add("@TasaInteres", SqlDbType.Decimal).Value = TxtTasa.Text.Trim
                    .Parameters.Add("@FinalidadPrestamo", SqlDbType.NVarChar, 300).Value = TxtFinalidad.Text.Trim
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtIdentidad.Text.Trim
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CboTipoPrestamo.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 1
                    .ExecuteNonQuery()
                    MessageBox.Show("Se ha guardado el préstamo con éxito", "Cooperativa System", MessageBoxButtons.OK)
                    Call MostrarPrestamos()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub AgregarEstadoPrestamo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_InsertEstadoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumSolicitudPrestamo", SqlDbType.NVarChar, 11).Value = TxtNumPrestamo.Text.Trim
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 30).Value = "Pendiente"

                    .ExecuteNonQuery()
                    MessageBox.Show("Se ha guardado el préstamo con éxito", "Cooperativa System", MessageBoxButtons.OK)
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ActualizarEstadoPrestamo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_ActualizarEstadoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumPrestamo", SqlDbType.NVarChar, 11).Value = TxtNumPrestamo.Text.Trim
                    If TxtCantAvales.Text = 2 Then
                        .Parameters.Add("@Estado", SqlDbType.NVarChar, 30).Value = "Aprobado"
                    Else
                        .Parameters.Add("@Estado", SqlDbType.NVarChar, 30).Value = "Rechazado"
                    End If
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ContarAvales()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim Listar As New SqlCommand("Sp_ContarAvales")
            Listar.CommandType = CommandType.StoredProcedure
            Listar.Connection = cnn
            Listar.Parameters.Add("@NumeroPrestamo", SqlDbType.NVarChar, 11).Value = TxtNumPrestamo.Text
            Dim Listar1 As SqlDataReader
            cnn.Open()
            Listar1 = Listar.ExecuteReader
            If Listar1.Read = True Then
                If Listar1("Cantidad de Avales") Is DBNull.Value Then
                    TxtCantAvales.Text = 1
                Else
                    TxtCantAvales.Text = Listar1("Cantidad de Avales").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtNumPrestamo.Text = LsvPrestamo.FocusedItem.SubItems(0).Text
        DtpFechaSolicitud.Text = LsvPrestamo.FocusedItem.SubItems(1).Text
        CboTipoPrestamo.Text = LsvPrestamo.FocusedItem.SubItems(2).Text
        TxtIdentidad.Text = LsvPrestamo.FocusedItem.SubItems(3).Text
        TxtNombre.Text = LsvPrestamo.FocusedItem.SubItems(4).Text
        TxtRTN.Text = LsvPrestamo.FocusedItem.SubItems(5).Text
        TxtNacionalidad.Text = LsvPrestamo.FocusedItem.SubItems(6).Text
        TxtEstadoCivil.Text = LsvPrestamo.FocusedItem.SubItems(7).Text
        TxtDireccion.Text = LsvPrestamo.FocusedItem.SubItems(8).Text
        TxtSumaSolicitada.Text = LsvPrestamo.FocusedItem.SubItems(9).Text
        TxtSumaOtorgada.Text = LsvPrestamo.FocusedItem.SubItems(10).Text
        TxtPlazo.Text = LsvPrestamo.FocusedItem.SubItems(11).Text
        TxtTasa.Text = LsvPrestamo.FocusedItem.SubItems(12).Text
        TxtFinalidad.Text = LsvPrestamo.FocusedItem.SubItems(13).Text
        DtpFechaExpiracion.Text = LsvPrestamo.FocusedItem.SubItems(14).Text

        TbPrestamo.SelectedIndex = 0
        Call MostrarCuentas()
        Call CalcularSaldo()
        Call HabilitarBotones(False, False, True, True, True, True, True, True)
    End Sub

    Private Sub BtnNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarBotones(False, True, False, True, True, True, True, True)
    End Sub

    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call HabilitarBotones(False, False, False, False, True, True, True, True)
        Call AgregarPrestamo()
        Call AgregarEstadoPrestamo()
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarBotones(True, False, False, False, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FrmBusquedaSocio.ShowDialog()
        Call MostrarCuentas()
        Call CalcularSaldo()
    End Sub

    Private Sub BtnAgregarAval_Click_1(sender As Object, e As EventArgs) Handles BtnAgregarAval.Click
        FrmSolicitudPrestamoAval.ShowDialog()
    End Sub

    Private Sub BtnAprobarPrestamo_Click(sender As Object, e As EventArgs) Handles BtnAprobarPrestamo.Click
        Call ContarAvales()

        If TxtCantAvales.Text = 2 Then
            Call ActualizarEstadoPrestamo()
            MessageBox.Show("El préstamo ha sido aprobado con éxito.", "Cooperativa System", MessageBoxButtons.OK)
        Else
            Call ActualizarEstadoPrestamo()
            MessageBox.Show("El préstamo ha sido rechazado por falta de avales.", "Cooperativa System", MessageBoxButtons.OK)
        End If

        Call Limpiar()
        Call HabilitarBotones(True, False, False, False, False, False, False, False)
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Call ActualizarPrestamo()
    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

End Class