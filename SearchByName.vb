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

                    ' Ealua si dataTable tiene filas (un valor que haga match para nombre)
                    If dataTable.Rows.Count > 0 Then
                        ' Data encontrada, se retornan los valores y se muestran en el txtLabel
                        Dim row As DataRow = dataTable.Rows(0)
                        ' Almancena el valor de la cédula en la variable personal_id
                        Dim personal_id As String = row("personal_id").ToString()

                        ' Se imprime el valor obtenido en el label lblSearchResult
                        lblSearchResult.Text = "cedula: " & personal_id & vbCrLf
                    Else
                        ' Si la data no fue encontrada para el nombre dado
                        MessageBox.Show("No se encontró nadie registrado con el nombre: " & txtIdSearchByName.Text)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Maneja cualquier excepción que ocurra al interactuar con la base de datos
        End Try

    End Sub
End Class