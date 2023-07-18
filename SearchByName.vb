Imports System.Data.SqlClient

Public Class SearchByName
    Private Sub SearchByName_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearchByName_Click(sender As Object, e As EventArgs) Handles btnSearchByName.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "SELECT * FROM students_table WHERE name = '" & txtIdSearchByName.Text & "'"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@nameToSearch", txtIdSearchByName.Text)

                    Dim dataAdapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    dataAdapter.Fill(dataTable)

                    ' Check if dataTable has rows (i.e., a match for the name)
                    If dataTable.Rows.Count > 0 Then
                        ' Data found, retrieve the values and display them in the Label control
                        Dim row As DataRow = dataTable.Rows(0)
                        'Dim name As String = row("name").ToString()
                        Dim personal_id As String = row("personal_id").ToString()

                        ' Assuming you have a Label control named lblSearchResult on your form
                        lblSearchResult.Text = "cedula: " & personal_id & vbCrLf
                    Else
                        ' Data not found for the given name
                        MessageBox.Show("No se encontró nadie registrado con el nombre: " & txtIdSearchByName.Text)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during the database interaction
            MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
        End Try

    End Sub
End Class