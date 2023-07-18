Imports System.Data.SqlClient

Public Class RemoveStudent
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "DELETE FROM students_table WHERE personal_id = @idToDelete"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@idToDelete", txtIdRemoveStudent.Text)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' The DELETE operation was successful, the element was deleted from the database.
                        MessageBox.Show("Alumno eliminado exitosamente")
                    Else
                        ' The DELETE operation failed, the element with the given ID was not found.
                        MessageBox.Show("Alumno con Cédula " & txtIdRemoveStudent.ToString() & " no fue encontrado.")
                    End If
                End Using
            End Using

            ' Si no hay excepciones el codigo continua normalmente.

        Catch ex As Exception
            ' Maneja excepciones customizadas
            MessageBox.Show("Excepción customizada: " & ex.Message)
        End Try
    End Sub

End Class
