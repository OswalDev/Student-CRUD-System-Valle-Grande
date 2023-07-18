<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        RegisterToolStripMenuItem = New ToolStripMenuItem()
        RemoveToolStripMenuItem = New ToolStripMenuItem()
        EditDatosToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ByIDToolStripMenuItem = New ToolStripMenuItem()
        ByNameToolStripMenuItem = New ToolStripMenuItem()
        AmountOfStudentsToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {RegisterToolStripMenuItem, RemoveToolStripMenuItem, EditDatosToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(85, 20)
        ToolStripMenuItem1.Text = "Operaciones"
        ' 
        ' RegisterToolStripMenuItem
        ' 
        RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        RegisterToolStripMenuItem.Size = New Size(160, 22)
        RegisterToolStripMenuItem.Text = "Inscribir alumno"
        ' 
        ' RemoveToolStripMenuItem
        ' 
        RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        RemoveToolStripMenuItem.Size = New Size(160, 22)
        RemoveToolStripMenuItem.Text = "Retirar alumno"
        ' 
        ' EditDatosToolStripMenuItem
        ' 
        EditDatosToolStripMenuItem.Name = "EditDatosToolStripMenuItem"
        EditDatosToolStripMenuItem.Size = New Size(160, 22)
        EditDatosToolStripMenuItem.Text = "Editar alumno"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {ByIDToolStripMenuItem, ByNameToolStripMenuItem, AmountOfStudentsToolStripMenuItem})
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(66, 20)
        ToolStripMenuItem2.Text = "Consulta"
        ' 
        ' ByIDToolStripMenuItem
        ' 
        ByIDToolStripMenuItem.Name = "ByIDToolStripMenuItem"
        ByIDToolStripMenuItem.Size = New Size(189, 22)
        ByIDToolStripMenuItem.Text = "Por Cédula"
        ' 
        ' ByNameToolStripMenuItem
        ' 
        ByNameToolStripMenuItem.Name = "ByNameToolStripMenuItem"
        ByNameToolStripMenuItem.Size = New Size(189, 22)
        ByNameToolStripMenuItem.Text = "Por Nombre"
        ' 
        ' AmountOfStudentsToolStripMenuItem
        ' 
        AmountOfStudentsToolStripMenuItem.Name = "AmountOfStudentsToolStripMenuItem"
        AmountOfStudentsToolStripMenuItem.Size = New Size(189, 22)
        AmountOfStudentsToolStripMenuItem.Text = "Cantidad de Alumnos"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        Text = "Sistema de Registro del Instituto Valle Grande"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmountOfStudentsToolStripMenuItem As ToolStripMenuItem
End Class
