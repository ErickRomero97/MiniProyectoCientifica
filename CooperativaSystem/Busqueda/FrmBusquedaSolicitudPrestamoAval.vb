Imports System.Data.SqlClient
Public Class FrmBusquedaSolicitudPrestamoAval
    Private Sub FrmBusquedaSolicitudPrestamoAval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Mostrar()
    End Sub
    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarSolicitudAvalBusqueda"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim Ver As SqlDataReader
                Ver = cmd.ExecuteReader()
                LsvSolicitudPA.Items.Clear()
                While Ver.Read = True
                    With Me.LsvSolicitudPA.Items.Add(Ver("CodSocio").ToString)
                        .SubItems.Add(Ver("NombreSocio").ToString)
                        .SubItems.Add(Ver("ApellidoSocio").ToString)
                        .SubItems.Add(Ver("NumSolicitudPrestamo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Sub MostrarXCodSocio()
        If ExisteSolicitudCodSocio() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarxCodSocio"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim Ver As SqlDataReader
                    Ver = cmd.ExecuteReader()
                    LsvSolicitudPA.Items.Clear()
                    While Ver.Read = True
                        With Me.LsvSolicitudPA.Items.Add(Ver("CodSocio").ToString)
                            .SubItems.Add(Ver("NombreSocio").ToString)
                            .SubItems.Add(Ver("ApellidoSocio").ToString)
                            .SubItems.Add(Ver("NumSolicitudPrestamo").ToString)
                        End With
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using

        End If
    End Sub

    Private Sub MostrarxNumSolicitudPrestamo()
        If ExisteNumSolicitudPrestamo() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarxNumSolicitudPrestamo"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@NumSolicitudPrestamo", SqlDbType.NVarChar, 11).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim Ver As SqlDataReader
                    Ver = cmd.ExecuteReader()
                    LsvSolicitudPA.Items.Clear()
                    While Ver.Read = True
                        With Me.LsvSolicitudPA.Items.Add(Ver("CodSocio").ToString)
                            .SubItems.Add(Ver("NombreSocio").ToString)
                            .SubItems.Add(Ver("ApellidoSocio").ToString)
                            .SubItems.Add(Ver("NumSolicitudPrestamo").ToString)
                        End With
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using

        End If
    End Sub

    Private Function ExisteNumSolicitudPrestamo() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteSolicitudNumSolicitudPA"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NumSolicitudPrestamo", SqlDbType.NVarChar, 11).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvSolicitudPA.Items.Clear()
                    MessageBox.Show("No existe ninguna solicitud de pestamo por aval con ese codigo", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function ExisteSolicitudCodSocio() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteSolicitudCodSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvSolicitudPA.Items.Clear()
                    MessageBox.Show("No existe ninguna solicitud de prestamo aval con ese codigo de socio", "CooperatiavSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub rdoCodMarca_CheckedChanged(sender As Object, e As EventArgs)
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True
        TxtBuscar.Text = ""
        LsvSolicitudPA.Items.Clear()
    End Sub

    Private Sub rdoNombreMarca_CheckedChanged(sender As Object, e As EventArgs)
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True
        TxtBuscar.Text = ""
        LsvSolicitudPA.Items.Clear()
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If RdoCodSocio.Checked = True Then
            e.Handled = txtNumerico(TxtBuscar, e.KeyChar, True)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RdoCodSocio.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El código del socio es requerido paa la busqueda", "CooperativaSystem", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarXCodSocio()
                TxtBuscar.Text = ""
            End If
        End If

        If RdoCodSolicitudAval.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El numero de solicitud de prestamo es necesario", "CooperativaSystem", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarxNumSolicitudPrestamo()
                TxtBuscar.Text = ""
            End If
        End If
    End Sub

End Class