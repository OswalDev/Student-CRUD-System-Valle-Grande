<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchByName
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 31)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(335, 162)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar alumno por nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(123, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(104, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(131, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(104, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(12, 15)
        Label2.TabIndex = 3
        Label2.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 4
        Label3.Text = "Cédula"
        ' 
        ' SearchByName
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 242)
        Controls.Add(GroupBox1)
        Name = "SearchByName"
        Text = "Busqueda por nombre"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
