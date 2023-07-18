Imports System.Data.SqlClient

Public Class getTotalStudents
    Private Sub getTotalStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "SELECT COUNT(*) AS TotalStudents FROM students_table"
            Dim totalStudents As Integer = 0


            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    totalStudents = CInt(command.ExecuteScalar())
                End Using
            End Using

            lblTotalResult.Text = totalStudents.ToString()
        Catch ex As Exception
            ' Maneja cualquier excepción que pueda ocurrir mientras se interactua con la base de datos
            MessageBox.Show("Error al retornar total de estudiantes: " & ex.Message)
        End Try
    End Sub

End Class