<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class getTotalStudents
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
        GroupBox1 = New GroupBox()
        lblTotalResult = New Label()
        txtNumOfStudents = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblTotalResult)
        GroupBox1.Controls.Add(txtNumOfStudents)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(24, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(336, 163)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Numero de estudiantes"
        ' 
        ' lblTotalResult
        ' 
        lblTotalResult.AutoSize = True
        lblTotalResult.Location = New Point(176, 70)
        lblTotalResult.Name = "lblTotalResult"
        lblTotalResult.Size = New Size(12, 15)
        lblTotalResult.TabIndex = 2
        lblTotalResult.Text = "-"
        ' 
        ' txtNumOfStudents
        ' 
        txtNumOfStudents.AutoSize = True
        txtNumOfStudents.Location = New Point(185, 70)
        txtNumOfStudents.Name = "txtNumOfStudents"
        txtNumOfStudents.Size = New Size(0, 15)
        txtNumOfStudents.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 15)
        Label1.TabIndex = 0
        Label1.Text = "N° total de estudiantes:"
        ' 
        ' getTotalStudents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 217)
        Controls.Add(GroupBox1)
        Name = "getTotalStudents"
        Text = "Número de estudiantes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumOfStudents As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalResult As Label
End Class
