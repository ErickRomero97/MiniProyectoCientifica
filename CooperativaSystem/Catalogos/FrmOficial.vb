Imports System.Data.SqlClient
Public Class FrmOficial
    Private Sub FrmOficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarBotones(True, False, False, False, False)
        Call LlenarComboSexo()
        Call MostrarOficial()
    End Sub

    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Groupbox As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        GbDatos.Enabled = Groupbox
    End Sub

    Sub Limpiar()
        MtbCodOficial.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtDireccion.Text = ""
        MtbTelefono.Text = ""
        CboSexo.SelectedItem = -1
    End Sub

    Private Sub LlenarComboSexo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_LlenarComboSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                Me.CboSexo.DataSource = ds.Tables(0)
                Me.CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                Me.CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString

            Catch ex As Exception

            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call HabilitarBotones(True, False, False, False, False)

        If Validar() = True Then
            Call AgregarOficial()
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarBotones(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub AgregarOficial()
        If ExisteRegistro() = False Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Using cmd As New SqlCommand
                Try

                    With cmd
                        .CommandText = "Sp_InsertarOficial"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 15).Value = Trim(MtbCodOficial.Text)
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = Trim(TxtNombre.Text)
                        .Parameters.Add("@Apellido", SqlDbType.NVarChar, 50).Value = Trim(TxtApellido.Text)
                        .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = Trim(TxtDireccion.Text)
                        .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = Trim(MtbTelefono.Text)
                        .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                        .ExecuteNonQuery()
                        MessageBox.Show("El oficial ha sido registrado con éxito", "Cooperativa System", MessageBoxButtons.OK)
                        Call MostrarOficial()
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using
        Else
            Call Limpiar()
        End If
    End Sub

    Private Sub ActualizarOficial()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Using cmd As New SqlCommand
            Try

                With cmd
                    .CommandText = "Sp_ActualizarOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 15).Value = Trim(MtbCodOficial.Text)
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = Trim(TxtNombre.Text)
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar, 50).Value = Trim(TxtApellido.Text)
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = Trim(TxtDireccion.Text)
                    .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = Trim(MtbTelefono.Text)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .ExecuteNonQuery()
                    MessageBox.Show("El oficial ha sido actualizado con éxito", "Cooperativa System", MessageBoxButtons.OK)
                    Call MostrarOficial()
                End With


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using

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
                    .CommandText = "Sp_ExisteOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 15).Value = MtbCodOficial.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este socio", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

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

    Private Function Validar() As Boolean
        Dim estado As Boolean
        If MtbCodOficial.Text = "" And TxtNombre.Text = "" And TxtApellido.Text = "" And TxtDireccion.Text = "" And MtbTelefono.Text = "" And CboSexo.Text = "" Then
            MessageBox.Show("Ingrese todos los datos.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            MtbCodOficial.Focus()
            estado = False
        ElseIf MtbCodOficial.Text = "" Then
            MessageBox.Show("Ingrese el Codigo de Oficial.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            MtbCodOficial.Focus()
            estado = False
        ElseIf TxtNombre.Text = "" Then
            MessageBox.Show("Ingrese el nombre de Oficial.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            TxtNombre.Focus()
            estado = False
        ElseIf TxtApellido.Text = "" Then
            MessageBox.Show("Ingrese el apellido de Oficial.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            TxtApellido.Focus()
            estado = False
        ElseIf TxtDireccion.Text = "" Then
            MessageBox.Show("Ingrese la dirección de Oficial.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            TxtDireccion.Focus()
            estado = False
        ElseIf MtbTelefono.Text = "" Then
            MessageBox.Show("Ingrese el teléfono de Oficial.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            MtbTelefono.Focus()
            estado = False
        ElseIf CboSexo.Text = "" Then
            MessageBox.Show("Seleccione el sexo de Oficial.", "Cooperativa System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarBotones(False, True, False, True, True)
            CboSexo.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarBotones(False, True, False, True, True)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarBotones(False, False, True, True, True)


        MtbCodOficial.Text = LsvMostrarOficial.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvMostrarOficial.FocusedItem.SubItems(1).Text
        TxtApellido.Text = LsvMostrarOficial.FocusedItem.SubItems(2).Text
        TxtDireccion.Text = LsvMostrarOficial.FocusedItem.SubItems(3).Text
        MtbTelefono.Text = LsvMostrarOficial.FocusedItem.SubItems(4).Text
        CboSexo.Text = LsvMostrarOficial.FocusedItem.SubItems(5).Text
        TbcOficial.SelectedIndex = 0
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Call HabilitarBotones(True, False, False, False, False)

        Call ActualizarOficial()
    End Sub
End Class