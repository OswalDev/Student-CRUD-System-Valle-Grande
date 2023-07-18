<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchById
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
        Label1 = New Label()
        Label2 = New Label()
        txtId = New TextBox()
        txtName = New Label()
        btnSearchById = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSearchById)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(371, 186)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar alumno por cédula"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cédula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(110, 46)
        txtId.Name = "txtId"
        txtId.Size = New Size(120, 23)
        txtId.TabIndex = 2
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Location = New Point(110, 99)
        txtName.Name = "txtName"
        txtName.Size = New Size(12, 15)
        txtName.TabIndex = 3
        txtName.Text = "-"
        ' 
        ' btnSearchById
        ' 
        btnSearchById.Location = New Point(135, 147)
        btnSearchById.Name = "btnSearchById"
        btnSearchById.Size = New Size(75, 23)
        btnSearchById.TabIndex = 4
        btnSearchById.Text = "Buscar"
        btnSearchById.UseVisualStyleBackColor = True
        ' 
        ' SearchById
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 235)
        Controls.Add(GroupBox1)
        Name = "SearchById"
        Text = "Busqueda por Cédula"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchById As Button
End Class
