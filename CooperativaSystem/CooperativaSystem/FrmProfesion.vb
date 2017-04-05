Imports System.Data.SqlClient
Public Class FrmProfesion
    Private Sub FrmProfesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TxtProfesion.Focus()
        ChkVertodo.Checked = False
        Limpiar()
        ChkVertodo.Enabled = False
        InvestigarCorrelativo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar(TxtProfesion, "El Nombre de la Profesion se nesesita") Then
        Else
            Agregar()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            Mostrar()
            ChkVertodo.Enabled = True
        End If
    End Sub

    Private Sub Btneditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar(TxtProfesion, "El Nombre de la Profesion se nesesita") Then
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
        TxtCodProfesion.Text = ""
        TxtProfesion.Text = ""
    End Sub

    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim Ver As SqlDataReader
                Ver = cmd.ExecuteReader()
                LsvProfesion.Items.Clear()
                While Ver.Read = True
                    With Me.LsvProfesion.Items.Add(Ver("IdProfesion").ToString)
                        .SubItems.Add(Ver("Profesion").ToString)
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
                        .CommandText = "Sp_InsertarProfesion"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@Profesion", SqlDbType.NVarChar, 40).Value = TxtProfesion.Text.Trim
                        .ExecuteNonQuery()
                        MessageBox.Show("se ha ingresado un nueva Profesion", "Cooperativa System", MessageBoxButtons.OK)
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
                    .CommandText = "Sp_ActualizarProfesion2"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = TxtCodProfesion.Text
                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 40).Value = TxtProfesion.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("la Profesion ha sido actualizado", "Cooperativa System", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave ya existente") Then
                MessageBox.Show("Ya se encuentra registrada esta Profesion", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    .CommandText = "Sp_EliminarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = LsvProfesion.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("la Profesion  ha sido eliminado", "Cooperativa System", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodProfesion.Text = LsvProfesion.FocusedItem.SubItems(0).Text
        TxtProfesion.Text = LsvProfesion.FocusedItem.SubItems(1).Text
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
            Dim Listar As New SqlCommand("Sp_MostrarProfesionIdentity", cnn)
            Listar.CommandType = CommandType.StoredProcedure
            Dim Listar1 As SqlDataReader
            cnn.Open()
            Listar1 = Listar.ExecuteReader
            If Listar1.Read = True Then
                If Listar1("Id") Is DBNull.Value Then
                    TxtCodProfesion.Text = 1
                Else
                    TxtCodProfesion.Text = Listar1("Id").ToString
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
                    .CommandText = "Sp_ExisteProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 40).Value = TxtProfesion.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra esa Profesion", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
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