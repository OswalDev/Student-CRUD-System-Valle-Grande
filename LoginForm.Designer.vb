<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtUsernameLogin = New TextBox()
        Label1 = New Label()
        txtPasswordLogin = New TextBox()
        GroupBox1 = New GroupBox()
        btnLogin = New Button()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsernameLogin
        ' 
        txtUsernameLogin.Location = New Point(136, 34)
        txtUsernameLogin.Name = "txtUsernameLogin"
        txtUsernameLogin.Size = New Size(118, 23)
        txtUsernameLogin.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 15)
        Label1.TabIndex = 1
        Label1.Text = "Sistema de Registro de Estudiantes - Valle Grande"
        ' 
        ' txtPasswordLogin
        ' 
        txtPasswordLogin.Location = New Point(136, 72)
        txtPasswordLogin.Name = "txtPasswordLogin"
        txtPasswordLogin.Size = New Size(118, 23)
        txtPasswordLogin.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtUsernameLogin)
        GroupBox1.Controls.Add(txtPasswordLogin)
        GroupBox1.Location = New Point(30, 56)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(331, 140)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Iniciar Sesión"
        ' 
        ' btnLogin
        ' 
        btnLogin.AccessibleName = "btnLogin"
        btnLogin.Location = New Point(111, 111)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Ingresar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 4
        Label3.Text = "Contraseña:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 3
        Label2.Text = "Usuario:"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(403, 208)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "LoginForm"
        Text = "Inicio de sesión"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsernameLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPasswordLogin As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
