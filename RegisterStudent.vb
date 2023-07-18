Imports System.Data.SqlClient

Public Class RegisterStudent
    Private Sub RegisterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' Interactuando con la base de datos SQL
            'Dim connectionString As String = "Data Source=DESKTOP-96AL4P3\MSSQLSERVEROJSG;Initial Catalog=SRE-ValleGrande;Integrated Security=True"
            Dim sql As String = "INSERT INTO students_table (name, personal_id) VALUES (@name, @personal_id)"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@name", txtNameRegister.Text)
                    command.Parameters.AddWithValue("@personal_id", txtIdRegister.Text)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' The INSERT operation was successful, data was added to the database.
                        MessageBox.Show("Data was added to the database successfully.")
                    Else
                        ' The INSERT operation failed, data was not added to the database.
                        MessageBox.Show("Failed to add data to the database.")
                    End If
                End Using
            End Using

            ' If there is no exception, the code execution continues here.

        Catch ex As Exception
            ' Handle the custom exception ADP_ConnectionRequired_Fill here.
            MessageBox.Show("Custom Exception: " & ex.Message)
        End Try
    End Sub


End Class