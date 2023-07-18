<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RemoveStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        studentNameLabel = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(studentNameLabel)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(30, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(295, 153)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Eliminar estudiante"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cédula: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(100, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(88, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(116, 23)
        TextBox1.TabIndex = 3
        ' 
        ' studentNameLabel
        ' 
        studentNameLabel.AutoSize = True
        studentNameLabel.Location = New Point(89, 89)
        studentNameLabel.Name = "studentNameLabel"
        studentNameLabel.Size = New Size(0, 15)
        studentNameLabel.TabIndex = 4
        ' 
        ' RemoveStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 202)
        Controls.Add(GroupBox1)
        Name = "RemoveStudent"
        Text = "Eliminar estudiante"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents studentNameLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
