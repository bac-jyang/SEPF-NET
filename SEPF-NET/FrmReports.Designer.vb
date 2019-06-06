<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReports
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
        Me.trvReports = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'trvReports
        '
        Me.trvReports.Location = New System.Drawing.Point(12, 12)
        Me.trvReports.Name = "trvReports"
        Me.trvReports.Size = New System.Drawing.Size(460, 449)
        Me.trvReports.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Run"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 473)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.trvReports)
        Me.Name = "FrmReports"
        Me.Text = "FrmReports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvReports As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
