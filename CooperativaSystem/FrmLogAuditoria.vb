Imports System.Data.SqlClient
Public Class FrmLogAuditoria
    Private Sub FrmLogAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarTodo()
    End Sub

    Private Sub MostrarTodo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_LogAuditoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerLog As SqlDataReader
                VerLog = cmd.ExecuteReader()
                LsvLogAuditoria.Items.Clear()
                While VerLog.Read = True
                    With Me.LsvLogAuditoria.Items.Add(VerLog("IdLog").ToString)
                        .SubItems.Add(VerLog("Actividad").ToString)
                        .SubItems.Add(VerLog("Fecha"))
                        .SubItems.Add(VerLog("IdUsuario").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
End Class