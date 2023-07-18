<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStudent
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
        btnRegister = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtNameRegister = New TextBox()
        txtIdRegister = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(120, 140)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(75, 23)
        btnRegister.TabIndex = 0
        btnRegister.Text = "Registrar"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nombre :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 3
        Label3.Text = "Cédula :"
        ' 
        ' txtNameRegister
        ' 
        txtNameRegister.Location = New Point(105, 43)
        txtNameRegister.Name = "txtNameRegister"
        txtNameRegister.Size = New Size(145, 23)
        txtNameRegister.TabIndex = 4
        ' 
        ' txtIdRegister
        ' 
        txtIdRegister.Location = New Point(105, 98)
        txtIdRegister.Name = "txtIdRegister"
        txtIdRegister.Size = New Size(145, 23)
        txtIdRegister.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnRegister)
        GroupBox1.Controls.Add(txtIdRegister)
        GroupBox1.Controls.Add(txtNameRegister)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(32, 32)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(316, 178)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Registro estudiantil"
        ' 
        ' RegisterStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 231)
        Controls.Add(GroupBox1)
        Name = "RegisterStudent"
        Text = "Registro de estudiante"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnRegister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNameRegister As TextBox
    Friend WithEvents txtIdRegister As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
