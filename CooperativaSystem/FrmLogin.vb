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
                    Dim name As String = reader("NombreOficial")
                    Dim username As String() = name.Split(" ")
                    Dim name2 As String = reader("ApellidoOficial")
                    Dim username2 As String() = name2.Split(" ")
                    FrmPrincipal.Show()
                    FrmPrincipal.LblUser.Text = String.Format("{0} {1}", username(0), username2(0))
                    FrmPrincipal.LblIdUsuario.Text = String.Format("{0}", reader(0).ToString)

                    Dim imagen As New System.IO.MemoryStream(DirectCast(reader("Foto"), [Byte]()))
                    Dim ObjImagen As Image = Image.FromStream(imagen)
                    FrmPrincipal.PbUser.BackgroundImage = ObjImagen
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


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class