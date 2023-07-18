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
        lblSearchResult = New Label()
        txtIdSearchByName = New TextBox()
        btnSearchByName = New Button()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblSearchResult)
        GroupBox1.Controls.Add(txtIdSearchByName)
        GroupBox1.Controls.Add(btnSearchByName)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 31)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(335, 162)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar alumno por nombre"
        ' 
        ' lblSearchResult
        ' 
        lblSearchResult.AutoSize = True
        lblSearchResult.Location = New Point(104, 86)
        lblSearchResult.Name = "lblSearchResult"
        lblSearchResult.Size = New Size(12, 15)
        lblSearchResult.TabIndex = 3
        lblSearchResult.Text = "-"
        ' 
        ' txtIdSearchByName
        ' 
        txtIdSearchByName.Location = New Point(104, 41)
        txtIdSearchByName.Name = "txtIdSearchByName"
        txtIdSearchByName.Size = New Size(131, 23)
        txtIdSearchByName.TabIndex = 2
        ' 
        ' btnSearchByName
        ' 
        btnSearchByName.Location = New Point(123, 124)
        btnSearchByName.Name = "btnSearchByName"
        btnSearchByName.Size = New Size(75, 23)
        btnSearchByName.TabIndex = 1
        btnSearchByName.Text = "Buscar"
        btnSearchByName.UseVisualStyleBackColor = True
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
    Friend WithEvents btnSearchByName As Button
    Friend WithEvents txtIdSearchByName As TextBox
    Friend WithEvents lblSearchResult As Label
End Class
