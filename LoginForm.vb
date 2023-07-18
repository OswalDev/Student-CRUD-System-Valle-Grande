Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Dim connectionString As String = "Data Source=DESKTOP-96AL4P3\MSSQLSERVEROJSG;Initial Catalog=SRE-ValleGrande;Integrated Security=True"
        'Dim sqlCon As SqlConnection = New SqlConnection(connectionString)
        'Dim cmd As SqlCommand = New SqlCommand("select * from Table_Login where username= '" & txtUsername.Text & "' and password='" & txtPassword.Text & "' ")
        Try
            ' Interactuando con la base de datos SQL
            'Dim connectionString As String = "Data Source=DESKTOP-96AL4P3\MSSQLSERVEROJSG;Initial Catalog=SRE-ValleGrande;Integrated Security=True"
            Dim sql As String = "SELECT * FROM login_table WHERE username= '" & txtUsernameLogin.Text & "' and password='" & txtPasswordLogin.Text & "' "

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    ' Rellena la tabla en la base de datos
                    adapter.Fill(dataTable)

                    ' Si dataTable se ha cargado correctamente
                    If (dataTable.Rows.Count > 0) Then
                        ' Si las credenciales son correctas
                        'MessageBox.Show("Has iniciado sesión con " + dataTable.Rows(0)(1))
                        isLoggedIn = True
                        Me.DialogResult = DialogResult.OK ' Indicate successful login
                        Me.Close()
                    Else
                        ' Si las credenciales son incorrectas
                        MessageBox.Show("credenciales incorrectas", "Error")
                        'Application.Exit()
                    End If

                    ' se abre conección con la base de datos
                    connection.Open()


                    ' se cierra conección con la base de datos
                    connection.Close()
                End Using
            End Using

            ' If there is no exception, the code execution continues here.

        Catch ex As Exception
            ' Handle the custom exception ADP_ConnectionRequired_Fill here.
            MessageBox.Show("Custom Exception: " & ex.Message)
        End Try
    End Sub
End Class