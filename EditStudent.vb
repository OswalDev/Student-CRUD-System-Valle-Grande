Imports System.Data.SqlClient

Public Class EditStudent
    Private Sub EditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "UPDATE students_table SET name = @name WHERE personal_id = @personal_id"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@name", txtNameEdit.Text)
                    command.Parameters.AddWithValue("@personal_id", txtIdEdit.Text)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Si la operación de UPDATE fue exitosa,se agrega la data a la base da datos.
                        MessageBox.Show("Nombre actualizado exitosamente.")
                    Else
                        ' Si la operación de UPDATE falla, la data no se modifica en la base de datos.
                        MessageBox.Show("No se encontró nadie registrado con la cédula: " & txtIdEdit.Text)
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