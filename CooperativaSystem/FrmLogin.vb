Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            cnn.Open()
            Using cmd As New SqlCommand

                With cmd
                    .CommandText = "Sp_Login"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = TxtUser.Text
                    .Parameters.Add("@pass", SqlDbType.NVarChar).Value = TxtPassword.Text
                End With
                Dim reader As SqlDataReader = cmd.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    FrmPrincipal.Show()
                    Me.Close()
                Else
                    MsgBox("Usuario y Contrasena invalido")
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub TxtUser_Click(sender As Object, e As EventArgs) Handles TxtUser.Click
        TxtUser.Text = ""
    End Sub


    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        TxtPassword.Text = ""
        TxtPassword.PasswordChar = "*"
    End Sub
End Class