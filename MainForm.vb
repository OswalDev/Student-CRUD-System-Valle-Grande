Imports System
Imports System.Data.SqlClient
Imports System.Data
Public Class MainForm
    Private WithEvents Button1 As System.Windows.Forms.Button ' Fully qualify Button with the correct namespace

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Button1 = New System.Windows.Forms.Button() ' Fully qualify Button with the correct namespace
        Dim logged = False
        Me.Text = "Sistema de Registro de Estudiantes - Valle Grande"
        Dim LoginForm As New LoginForm
        Dim loginResult = LoginForm.ShowDialog()
        Me.IsMdiContainer = True ' Convertimos a este componente en un MDI
        LoginForm.MdiParent = Me



        If loginResult = DialogResult.OK Then
            ' The user logged in successfully, continue with the application
            ' ... Your application initialization code ...
            'RegisterStudent.Show()
            'RemoveStudent.Show()
            'EditStudent.Show()
        Else
            ' The user closed the login form without logging in, close the application
            Application.Exit() ' or Environment.Exit(0)
        End If

        'If isLoggedIn.Equals("true") Then

        'End If
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        RegisterStudent.Show()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveStudent.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDatosToolStripMenuItem.Click
        EditStudent.Show()
    End Sub

    Private Sub ByIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByIDToolStripMenuItem.Click
        SearchById.Show()
    End Sub

    Private Sub ByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByNameToolStripMenuItem.Click
        SearchByName.Show()
    End Sub

    Private Sub AmountOfStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmountOfStudentsToolStripMenuItem.Click
        getTotalStudents.Show()
    End Sub
End Class