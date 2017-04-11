Imports System.Data.SqlClient
Public Class FrmBuscarUsuario
    Private Sub FrmBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarUsuario()
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

    Private Sub BuscarXNombreDeUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarUsuarioXNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvMostrarUsuario.Items.Clear()

                While MostrarUsuario.Read = True
                    With Me.LsvMostrarUsuario.Items.Add(MostrarUsuario("IdUsuario").ToString)
                        .SubItems.Add(MostrarUsuario("UserName").ToString)
                        .SubItems.Add(MostrarUsuario("Contraseña").ToString)
                        .SubItems.Add(MostrarUsuario("Estado").ToString)
                        .SubItems.Add(MostrarUsuario("CodOficial").ToString)
                        .SubItems.Add(MostrarUsuario("Usuario").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub BuscarXCodigoOficial()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarUsuarioXCodOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 15).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvMostrarUsuario.Items.Clear()

                While MostrarUsuario.Read = True
                    With Me.LsvMostrarUsuario.Items.Add(MostrarUsuario("IdUsuario").ToString)
                        .SubItems.Add(MostrarUsuario("UserName").ToString)
                        .SubItems.Add(MostrarUsuario("Contraseña").ToString)
                        .SubItems.Add(MostrarUsuario("Estado").ToString)
                        .SubItems.Add(MostrarUsuario("CodOficial").ToString)
                        .SubItems.Add(MostrarUsuario("Usuario").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RdbNombreUsuario.Checked = True Then
            Call BuscarXNombreDeUsuario()
        ElseIf RdbCodigoOficial.Checked = True Then
            Call BuscarXCodigoOficial()
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Call MostrarUsuario()
    End Sub
End Class