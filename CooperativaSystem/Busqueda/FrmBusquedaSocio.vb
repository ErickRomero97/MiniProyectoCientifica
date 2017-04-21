Imports System.Data.SqlClient
Public Class FrmBusquedaSocio
    Private Sub FrmBusquedaSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarSocio()
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
                        .SubItems.Add(VerSocio("EstadoCivil").ToString)
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


    Private Sub BuscarSocio()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_BuscarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Socio", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarSocio()
    End Sub

    Private Sub LsvMostrarSocio_DoubleClick(sender As Object, e As EventArgs) Handles LsvMostrarSocio.DoubleClick
        FrmSolicitudPrestamo.TxtIdentidad.Text = LsvMostrarSocio.FocusedItem.SubItems(0).Text
        FrmSolicitudPrestamo.TxtNombre.Text = LsvMostrarSocio.FocusedItem.SubItems(2).Text
        FrmSolicitudPrestamo.TxtRTN.Text = LsvMostrarSocio.FocusedItem.SubItems(1).Text
        FrmSolicitudPrestamo.TxtNacionalidad.Text = LsvMostrarSocio.FocusedItem.SubItems(11).Text
        FrmSolicitudPrestamo.TxtEstadoCivil.Text = LsvMostrarSocio.FocusedItem.SubItems(10).Text
        FrmSolicitudPrestamo.TxtDireccion.Text = LsvMostrarSocio.FocusedItem.SubItems(4).Text

        Me.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class