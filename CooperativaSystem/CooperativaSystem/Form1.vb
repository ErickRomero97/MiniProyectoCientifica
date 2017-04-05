Imports System.Data.SqlClient
Public Class FrmTipoPrestamo
    Private Sub FrmTipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Mostrar()
    End Sub
    Public regreso As Integer = 0
    Private Sub Chkvertodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVertodo.CheckedChanged
        If ChkVertodo.CheckState = CheckState.Checked Then
            Height = 429
            CenterToScreen()
        Else
            Height = 277
            CenterToScreen()
        End If
    End Sub


    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        PlMarca.Enabled = Panel
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        TxtTipoPrestamo.Focus()
        ChkVertodo.Checked = False
        Limpiar()
        ChkVertodo.Enabled = False
        InvestigarCorrelativo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar(TxtTipoPrestamo, "El Nombre del tipo prestamo se nesesita") Then
        Else
            Agregar()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            Mostrar()
            ChkVertodo.Enabled = True
        End If
    End Sub

    Private Sub Btneditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar(TxtTipoPrestamo, "El Nombre del tipo Prestamo se nesesita") Then
        Else
            Actualizar()
            Mostrar()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
        End If

    End Sub


    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        ChkVertodo.Enabled = True
    End Sub

    Sub Limpiar()
        TxtCodTipoP.Text = ""
        TxtTipoPrestamo.Text = ""
    End Sub

    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTipoPrestamo1"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim Ver As SqlDataReader
                Ver = cmd.ExecuteReader()
                LsvtipoPrestamo.Items.Clear()
                While Ver.Read = True
                    With Me.LsvtipoPrestamo.Items.Add(Ver("IdTipoPrestamo").ToString)
                        .SubItems.Add(Ver("TipoPrestamo").ToString)
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
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertarTipoPrestamo1"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 40).Value = TxtTipoPrestamo.Text.Trim
                        .ExecuteNonQuery()
                        MessageBox.Show("se ha ingresado un nuevo tipo prestamo", "Cooperativa System", MessageBoxButtons.OK)
                    End With
                End Using

            Catch ex As Exception

            Finally
                cnn.Close()
            End Try
        End If


    End Sub

    Private Sub Actualizar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarTipoPrestamo1"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = TxtCodTipoP.Text
                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 40).Value = TxtTipoPrestamo.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("el tipo de prestamo ha sido actualizado", "Cooperativa System", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave ys existente") Then
                MessageBox.Show("Ya se encuentra registrado ese tipo Prestamo", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ex.Message)
            End If

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Eliminar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EliminarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = LsvtipoPrestamo.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("el tipo de prestamo ha sido eliminado", "Cooperativa System", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodTipoP.Text = LsvtipoPrestamo.FocusedItem.SubItems(0).Text
        TxtTipoPrestamo.Text = LsvtipoPrestamo.FocusedItem.SubItems(1).Text
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
            Dim Listar As New SqlCommand("Sp_MostrarTipoPrestamoIdentity", cnn)
            Listar.CommandType = CommandType.StoredProcedure
            Dim Listar1 As SqlDataReader
            cnn.Open()
            Listar1 = Listar.ExecuteReader
            If Listar1.Read = True Then
                If Listar1("Id") Is DBNull.Value Then
                    TxtCodTipoP.Text = 1
                Else
                    TxtCodTipoP.Text = Listar1("Id").ToString
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
                    .CommandText = "Sp_ExisteTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 40).Value = TxtTipoPrestamo.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra ese tipo de prestamo", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function


    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            MessageBox.Show(Mensaje, "Cooperativa System", MessageBoxButtons.OK)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function

End Class
