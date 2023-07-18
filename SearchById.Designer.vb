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
        lblSearchResult = New Label()
        btnSearchById = New Button()
        txtIdSearchById = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblSearchResult)
        GroupBox1.Controls.Add(btnSearchById)
        GroupBox1.Controls.Add(txtIdSearchById)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(371, 186)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar alumno por cédula"
        ' 
        ' lblSearchResult
        ' 
        lblSearchResult.AutoSize = True
        lblSearchResult.Location = New Point(121, 97)
        lblSearchResult.Name = "lblSearchResult"
        lblSearchResult.Size = New Size(12, 15)
        lblSearchResult.TabIndex = 6
        lblSearchResult.Text = "-"
        ' 
        ' btnSearchById
        ' 
        btnSearchById.Location = New Point(130, 157)
        btnSearchById.Name = "btnSearchById"
        btnSearchById.Size = New Size(75, 23)
        btnSearchById.TabIndex = 4
        btnSearchById.Text = "Buscar"
        btnSearchById.UseVisualStyleBackColor = True
        ' 
        ' txtIdSearchById
        ' 
        txtIdSearchById.Location = New Point(121, 49)
        txtIdSearchById.Name = "txtIdSearchById"
        txtIdSearchById.Size = New Size(120, 23)
        txtIdSearchById.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cédula"
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
    Friend WithEvents txtIdSearchById As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchById As Button
    Friend WithEvents lblSearchResult As Label
End Class
