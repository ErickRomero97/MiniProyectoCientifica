Imports System.Data.SqlClient
Public Class FrmBusquedaCuentaBancaria
    Private Sub FrmBusquedaCuentaBancaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub
    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarCuentaBusqueda"
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
                        .SubItems.Add(Ver("ApellidoSocio").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub BuscarXNombre()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarSocioXNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NombreSocio", SqlDbType.NVarChar, 30).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvCuentaBancaria.Items.Clear()

                While MostrarUsuario.Read = True
                    With LsvCuentaBancaria.Items.Add(MostrarUsuario("NumCuenta").ToString)
                        .SubItems.Add(MostrarUsuario("SaldoActual").ToString)
                        .SubItems.Add(MostrarUsuario("TipoCuenta").ToString)
                        .SubItems.Add(MostrarUsuario("CodSocio").ToString)
                        .SubItems.Add(MostrarUsuario("NombreSocio").ToString)
                        .SubItems.Add(MostrarUsuario("ApellidoSocio").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarUsuarioXId()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarCuentaBancariaXId"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NumCuenta", SqlDbType.NVarChar, 15).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvCuentaBancaria.Items.Clear()

                While MostrarUsuario.Read = True
                    With LsvCuentaBancaria.Items.Add(MostrarUsuario("NumCuenta").ToString)
                        .SubItems.Add(MostrarUsuario("SaldoActual").ToString)
                        .SubItems.Add(MostrarUsuario("TipoCuenta").ToString)
                        .SubItems.Add(MostrarUsuario("CodSocio").ToString)
                        .SubItems.Add(MostrarUsuario("NombreSocio").ToString)
                        .SubItems.Add(MostrarUsuario("ApellidoSocio").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs)
        If TxtBuscar.Text = Nothing Then
            Call Mostrar()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RdoNombreSocio.Checked = True Then
            Call BuscarXNombre()
        ElseIf RdoCodCuenta.Checked = True Then
            Call BuscarUsuarioXId()
        End If
    End Sub


End Class