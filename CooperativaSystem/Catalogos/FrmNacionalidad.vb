Imports System.Data.SqlClient
Public Class FrmNacionalidad
    Private Sub FrmNacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Mostrar()
    End Sub
    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Grb As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        GrbNacionalidad.Enabled = Grb
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        TxtNombreNac.Focus()
        Limpiar()
        InvestigarCorrelativo()
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
        TxtCodNac.Text = ""
        TxtNombreNac.Text = ""
    End Sub

    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim Ver As SqlDataReader
                Ver = cmd.ExecuteReader()
                LsvNac.Items.Clear()
                While Ver.Read = True
                    With Me.LsvNac.Items.Add(Ver("IdNacionalidad").ToString)
                        .SubItems.Add(Ver("Nacionalidad").ToString)
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
                        .CommandText = "Sp_InsertarNacionalidad"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 40).Value = TxtNombreNac.Text.Trim
                        .ExecuteNonQuery()
                        MessageBox.Show("se ha ingresado un nueva nacioanlidad", "Cooperativa System", MessageBoxButtons.OK)
                    End With


                Catch ex As Exception

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
                    .CommandText = "Sp_ActualizarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = TxtCodNac.Text
                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 40).Value = TxtNombreNac.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("la nacionalidad ha sido actualizado", "Cooperativa System", MessageBoxButtons.OK)
                End With

            Catch ex As Exception
                If ex.ToString.Contains("clave ya existente") Then
                    MessageBox.Show("Ya se encuentra registrada esta nacionalidad", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    .CommandText = "Sp_EliminarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = LsvNac.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("la nacionalidad ha sido eliminado", "Cooperativa System", MessageBoxButtons.OK)
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodNac.Text = LsvNac.FocusedItem.SubItems(0).Text
        TxtNombreNac.Text = LsvNac.FocusedItem.SubItems(1).Text
        TbCNacionalidad.SelectedIndex = 0
        HabilitarBotones(False, False, True, True, True)

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
        Mostrar()
        HabilitarBotones(True, False, False, False, False)
    End Sub

    Sub InvestigarCorrelativo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim Listar As New SqlCommand("Sp_MostrarNacionalidadIdentity", cnn)
            Listar.CommandType = CommandType.StoredProcedure
            Dim Listar1 As SqlDataReader
            cnn.Open()
            Listar1 = Listar.ExecuteReader
            If Listar1.Read = True Then
                If Listar1("Id") Is DBNull.Value Then
                    TxtCodNac.Text = 1
                Else
                    TxtCodNac.Text = Listar1("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
                    .CommandText = "Sp_ExisteNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 40).Value = TxtNombreNac.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra esa nacionalidad", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function


    Private Function Validar() As Boolean
        Dim estado As Boolean

        If TxtNombreNac.Text = Nothing Then
            MessageBox.Show("El Nombre de la Nacionaldad es Neccesario.", "CooperativaSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            TxtNombreNac.Focus()
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