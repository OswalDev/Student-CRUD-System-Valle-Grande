Imports System
Imports System.Data.SqlClient
Imports System.Data
Public Class MainForm
    Private WithEvents Button1 As System.Windows.Forms.Button

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.Text = "Sistema de Registro de Estudiantes - Valle Grande"
        Dim LoginForm As New LoginForm
        Dim loginResult = LoginForm.ShowDialog()
        Me.IsMdiContainer = True ' Convertimos a este componente en un MDI
        LoginForm.MdiParent = Me

        ' Si el usuario cierra el Login Form antes de iniciar sesión, la aplicación entera se cierra como modo de seguridad
        If loginResult = DialogResult.Cancel Then
            Application.Exit()
        End If

    End Sub

    ' Botón de registro de estudiante
    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        RegisterStudent.Show()
    End Sub

    ' Botón de eliminar de estudiante
    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveStudent.Show()
    End Sub

    ' Botón de editar de estudiante
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDatosToolStripMenuItem.Click
        EditStudent.Show()
    End Sub

    ' Botón de busqueda por cédula
    Private Sub ByIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByIDToolStripMenuItem.Click
        SearchById.Show()
    End Sub

    ' Botón de busqueda por nombre
    Private Sub ByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByNameToolStripMenuItem.Click
        SearchByName.Show()
    End Sub

    ' Botón de cantidad de alumnos
    Private Sub AmountOfStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmountOfStudentsToolStripMenuItem.Click
        getTotalStudents.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class