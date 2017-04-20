Imports System.Data.SqlClient
Public Class FrmBuscarOficial
    Private Sub FrmBuscarOficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarOficial()
    End Sub

    Private Sub MostrarOficial()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim Ver As SqlDataReader
                Ver = cmd.ExecuteReader()
                LsvMostrarOficial.Items.Clear()
                While Ver.Read = True
                    With Me.LsvMostrarOficial.Items.Add(Ver("CodOficial").ToString)
                        .SubItems.Add(Ver("NombreOficial").ToString)
                        .SubItems.Add(Ver("ApellidoOficial").ToString)
                        .SubItems.Add(Ver("Direccion").ToString)
                        .SubItems.Add(Ver("Telefono").ToString)
                        .SubItems.Add(Ver("Sexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub BuscarXCodigo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarOficialXCodigo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CodigoOficial", SqlDbType.NVarChar, 15).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarOficial As SqlDataReader
                MostrarOficial = cmd.ExecuteReader
                LsvMostrarOficial.Items.Clear()

                While MostrarOficial.Read = True
                    With Me.LsvMostrarOficial.Items.Add(MostrarOficial("CodOficial").ToString)
                        .SubItems.Add(MostrarOficial("NombreOficial").ToString)
                        .SubItems.Add(MostrarOficial("ApellidoOficial").ToString)
                        .SubItems.Add(MostrarOficial("Direccion").ToString)
                        .SubItems.Add(MostrarOficial("Telefono").ToString)
                        .SubItems.Add(MostrarOficial("Sexo").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
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
                    .CommandText = "Sp_BuscarOficialXNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarOficial As SqlDataReader
                MostrarOficial = cmd.ExecuteReader
                LsvMostrarOficial.Items.Clear()

                While MostrarOficial.Read = True
                    With Me.LsvMostrarOficial.Items.Add(MostrarOficial("CodOficial").ToString)
                        .SubItems.Add(MostrarOficial("NombreOficial").ToString)
                        .SubItems.Add(MostrarOficial("ApellidoOficial").ToString)
                        .SubItems.Add(MostrarOficial("Direccion").ToString)
                        .SubItems.Add(MostrarOficial("Telefono").ToString)
                        .SubItems.Add(MostrarOficial("Sexo").ToString)
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
        If RdbCodigoOficial.Checked = True Then
            Call BuscarXCodigo()
        ElseIf RdbNombre.Checked = True Then
            Call BuscarXNombre()
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Call MostrarOficial()
    End Sub

    Private Sub LsvMostrarOficial_DoubleClick(sender As Object, e As EventArgs) Handles LsvMostrarOficial.DoubleClick
        FrmUsuario.MtbCodigoOficial.Text = LsvMostrarOficial.FocusedItem.SubItems(0).Text
        Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub


End Class