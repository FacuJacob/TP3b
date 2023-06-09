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
        cmdEjec = New Button()
        lblCantPar = New Label()
        lblMay = New Label()
        lblPos = New Label()
        SuspendLayout()
        ' 
        ' cmdEjec
        ' 
        cmdEjec.Location = New Point(39, 125)
        cmdEjec.Name = "cmdEjec"
        cmdEjec.Size = New Size(75, 23)
        cmdEjec.TabIndex = 0
        cmdEjec.Text = "Ejecutar"
        cmdEjec.UseVisualStyleBackColor = True
        ' 
        ' lblCantPar
        ' 
        lblCantPar.AutoSize = True
        lblCantPar.Location = New Point(39, 37)
        lblCantPar.Name = "lblCantPar"
        lblCantPar.Size = New Size(102, 15)
        lblCantPar.TabIndex = 1
        lblCantPar.Text = "Cantidad de pares"
        ' 
        ' lblMay
        ' 
        lblMay.AutoSize = True
        lblMay.Location = New Point(39, 67)
        lblMay.Name = "lblMay"
        lblMay.Size = New Size(88, 15)
        lblMay.TabIndex = 2
        lblMay.Text = "Numero Mayor"
        ' 
        ' lblPos
        ' 
        lblPos.AutoSize = True
        lblPos.Location = New Point(39, 97)
        lblPos.Name = "lblPos"
        lblPos.Size = New Size(60, 15)
        lblPos.TabIndex = 3
        lblPos.Text = "Ubicacion"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 179)
        Controls.Add(lblPos)
        Controls.Add(lblMay)
        Controls.Add(lblCantPar)
        Controls.Add(cmdEjec)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjec As Button
    Friend WithEvents lblCantPar As Label
    Friend WithEvents lblMay As Label
    Friend WithEvents lblPos As Label
End Class
