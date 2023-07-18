Imports System.Data.SqlClient

Public Class RegisterStudent
    Private Sub RegisterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "INSERT INTO students_table (name, personal_id) VALUES (@name, @personal_id)"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@name", txtNameRegister.Text)
                    command.Parameters.AddWithValue("@personal_id", txtIdRegister.Text)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Si la operación de INSERT fue exitosa,se agrega la data a la base da datos.
                        MessageBox.Show("Alumno añadido exitosamente.")
                    Else
                        ' Si la operación de INSERT falla, la data no se agrega a la base de datos.
                        MessageBox.Show("Error al añadir usuario.")
                    End If
                End Using
            End Using

            ' Si no hay excepciones el codigo continua normalmente.

        Catch ex As Exception
            ' Maneja excepciones customizadas
            MessageBox.Show("Custom Exception: " & ex.Message)
        End Try
    End Sub


End Class