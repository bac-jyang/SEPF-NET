<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabels
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grdLabels = New System.Windows.Forms.DataGridView()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        CType(Me.grdLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(252, 234)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grdLabels
        '
        Me.grdLabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLabels.Location = New System.Drawing.Point(12, 38)
        Me.grdLabels.Name = "grdLabels"
        Me.grdLabels.Size = New System.Drawing.Size(352, 183)
        Me.grdLabels.TabIndex = 2
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(12, 234)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExcel.TabIndex = 3
        Me.btnExcel.Text = "Export Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnCSV
        '
        Me.btnCSV.Location = New System.Drawing.Point(121, 234)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(75, 23)
        Me.btnCSV.TabIndex = 4
        Me.btnCSV.Text = "Export CSV"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'frmLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 280)
        Me.Controls.Add(Me.btnCSV)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.grdLabels)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmLabels"
        Me.Text = "frmLabels"
        CType(Me.grdLabels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grdLabels As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnCSV As System.Windows.Forms.Button
End Class
