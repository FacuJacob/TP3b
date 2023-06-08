<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Ejec = New Button()
        CantPar = New Label()
        May = New Label()
        Pos = New Label()
        SuspendLayout()
        ' 
        ' Ejec
        ' 
        Ejec.Location = New Point(98, 224)
        Ejec.Name = "Ejec"
        Ejec.Size = New Size(75, 23)
        Ejec.TabIndex = 0
        Ejec.Text = "Ejecutar"
        Ejec.UseVisualStyleBackColor = True
        ' 
        ' CantPar
        ' 
        CantPar.AutoSize = True
        CantPar.Location = New Point(66, 63)
        CantPar.Name = "CantPar"
        CantPar.Size = New Size(41, 15)
        CantPar.TabIndex = 1
        CantPar.Text = "Label1"
        ' 
        ' May
        ' 
        May.AutoSize = True
        May.Location = New Point(165, 64)
        May.Name = "May"
        May.Size = New Size(41, 15)
        May.TabIndex = 2
        May.Text = "Label1"
        ' 
        ' Pos
        ' 
        Pos.AutoSize = True
        Pos.Location = New Point(273, 67)
        Pos.Name = "Pos"
        Pos.Size = New Size(41, 15)
        Pos.TabIndex = 3
        Pos.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Pos)
        Controls.Add(May)
        Controls.Add(CantPar)
        Controls.Add(Ejec)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ejec As Button
    Friend WithEvents CantPar As Label
    Friend WithEvents May As Label
    Friend WithEvents Pos As Label
End Class
