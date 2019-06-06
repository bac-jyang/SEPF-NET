<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearEnd
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
        Me.btnAcVested = New System.Windows.Forms.Button()
        Me.btnAcNoVested = New System.Windows.Forms.Button()
        Me.btnAcLOEPF = New System.Windows.Forms.Button()
        Me.btnNoVestedLOPF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAcVested
        '
        Me.btnAcVested.Location = New System.Drawing.Point(29, 37)
        Me.btnAcVested.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAcVested.Name = "btnAcVested"
        Me.btnAcVested.Size = New System.Drawing.Size(168, 28)
        Me.btnAcVested.TabIndex = 0
        Me.btnAcVested.Text = "Active Vested"
        Me.btnAcVested.UseVisualStyleBackColor = True
        '
        'btnAcNoVested
        '
        Me.btnAcNoVested.Location = New System.Drawing.Point(29, 73)
        Me.btnAcNoVested.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAcNoVested.Name = "btnAcNoVested"
        Me.btnAcNoVested.Size = New System.Drawing.Size(168, 28)
        Me.btnAcNoVested.TabIndex = 1
        Me.btnAcNoVested.Text = "Active No-Vested"
        Me.btnAcNoVested.UseVisualStyleBackColor = True
        '
        'btnAcLOEPF
        '
        Me.btnAcLOEPF.Location = New System.Drawing.Point(39, 116)
        Me.btnAcLOEPF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAcLOEPF.Name = "btnAcLOEPF"
        Me.btnAcLOEPF.Size = New System.Drawing.Size(159, 28)
        Me.btnAcLOEPF.TabIndex = 2
        Me.btnAcLOEPF.Text = "Active Vested LOEPF"
        Me.btnAcLOEPF.UseVisualStyleBackColor = True
        '
        'btnNoVestedLOPF
        '
        Me.btnNoVestedLOPF.Location = New System.Drawing.Point(39, 158)
        Me.btnNoVestedLOPF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNoVestedLOPF.Name = "btnNoVestedLOPF"
        Me.btnNoVestedLOPF.Size = New System.Drawing.Size(181, 28)
        Me.btnNoVestedLOPF.TabIndex = 3
        Me.btnNoVestedLOPF.Text = "Active No-Vested LOEPF"
        Me.btnNoVestedLOPF.UseVisualStyleBackColor = True
        '
        'frmYearEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 352)
        Me.Controls.Add(Me.btnNoVestedLOPF)
        Me.Controls.Add(Me.btnAcLOEPF)
        Me.Controls.Add(Me.btnAcNoVested)
        Me.Controls.Add(Me.btnAcVested)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmYearEnd"
        Me.Text = "frmYearEnd"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAcVested As System.Windows.Forms.Button
    Friend WithEvents btnAcNoVested As System.Windows.Forms.Button
    Friend WithEvents btnAcLOEPF As System.Windows.Forms.Button
    Friend WithEvents btnNoVestedLOPF As System.Windows.Forms.Button
End Class
