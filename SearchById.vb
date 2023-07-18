Imports System.Data.SqlClient

Public Class SearchById
    Private Sub SearchById_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearchById_Click(sender As Object, e As EventArgs) Handles btnSearchById.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "SELECT * FROM students_table WHERE personal_id = '" & txtIdSearchById.Text & "'"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@personalIdToSearch", txtIdSearchById.Text)

                    Dim dataAdapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    dataAdapter.Fill(dataTable)

                    ' Check if dataTable has rows (i.e., a match for the personal_id)
                    If dataTable.Rows.Count > 0 Then
                        ' Data found, retrieve the values and display them in the Label control
                        Dim row As DataRow = dataTable.Rows(0)
                        Dim name As String = row("name").ToString()

                        ' Assuming you have a Label control named lblSearchResult on your form
                        lblSearchResult.Text = "Nombre: " & name & vbCrLf
                    Else
                        ' Data not found for the given personal_id
                        MessageBox.Show("No se encontró nadie registrado con cédula: " & txtIdSearchById.Text)
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