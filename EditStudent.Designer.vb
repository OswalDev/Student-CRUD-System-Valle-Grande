<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudent
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
        txtNameEdit = New TextBox()
        txtIdEdit = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnEdit = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtNameEdit)
        GroupBox1.Controls.Add(txtIdEdit)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnEdit)
        GroupBox1.Location = New Point(25, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(310, 154)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Editar estudiante"
        ' 
        ' txtNameEdit
        ' 
        txtNameEdit.Location = New Point(95, 86)
        txtNameEdit.Name = "txtNameEdit"
        txtNameEdit.Size = New Size(100, 23)
        txtNameEdit.TabIndex = 4
        ' 
        ' txtIdEdit
        ' 
        txtIdEdit.Location = New Point(95, 38)
        txtIdEdit.Name = "txtIdEdit"
        txtIdEdit.Size = New Size(100, 23)
        txtIdEdit.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 2
        Label2.Text = "Cédula"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(110, 125)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 0
        btnEdit.Text = "Editar"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' EditStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(360, 207)
        Controls.Add(GroupBox1)
        Name = "EditStudent"
        Text = "Editar estudiante"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNameEdit As TextBox
    Friend WithEvents txtIdEdit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
End Class
