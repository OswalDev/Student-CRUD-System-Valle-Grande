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
        txtIdRemoveStudent = New TextBox()
        btnDeleteStudent = New Button()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtIdRemoveStudent)
        GroupBox1.Controls.Add(btnDeleteStudent)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(30, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(295, 145)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Eliminar estudiante"
        ' 
        ' txtIdRemoveStudent
        ' 
        txtIdRemoveStudent.Location = New Point(88, 47)
        txtIdRemoveStudent.Name = "txtIdRemoveStudent"
        txtIdRemoveStudent.Size = New Size(116, 23)
        txtIdRemoveStudent.TabIndex = 3
        ' 
        ' btnDeleteStudent
        ' 
        btnDeleteStudent.Location = New Point(100, 103)
        btnDeleteStudent.Name = "btnDeleteStudent"
        btnDeleteStudent.Size = New Size(75, 23)
        btnDeleteStudent.TabIndex = 2
        btnDeleteStudent.Text = "Eliminar"
        btnDeleteStudent.UseVisualStyleBackColor = True
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
        ' RemoveStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 189)
        Controls.Add(GroupBox1)
        Name = "RemoveStudent"
        Text = "Eliminar estudiante"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdRemoveStudent As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteStudent As Button
End Class
