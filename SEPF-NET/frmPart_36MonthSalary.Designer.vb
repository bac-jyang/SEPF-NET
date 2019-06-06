<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPart_36MonthSalary
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
        Me.grd36Salary = New System.Windows.Forms.DataGridView()
        Me.lblAnn = New System.Windows.Forms.Label()
        Me.txtAnnSalary = New System.Windows.Forms.TextBox()
        Me.txtMonSalary = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd36Salary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(486, 456)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grd36Salary
        '
        Me.grd36Salary.AllowUserToDeleteRows = False
        Me.grd36Salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd36Salary.Location = New System.Drawing.Point(23, 20)
        Me.grd36Salary.Name = "grd36Salary"
        Me.grd36Salary.RowHeadersVisible = False
        Me.grd36Salary.ShowEditingIcon = False
        Me.grd36Salary.ShowRowErrors = False
        Me.grd36Salary.Size = New System.Drawing.Size(507, 360)
        Me.grd36Salary.TabIndex = 1
        '
        'lblAnn
        '
        Me.lblAnn.AutoSize = True
        Me.lblAnn.Location = New System.Drawing.Point(82, 402)
        Me.lblAnn.Name = "lblAnn"
        Me.lblAnn.Size = New System.Drawing.Size(115, 13)
        Me.lblAnn.TabIndex = 2
        Me.lblAnn.Text = "Average Annual Salary"
        '
        'txtAnnSalary
        '
        Me.txtAnnSalary.Location = New System.Drawing.Point(203, 399)
        Me.txtAnnSalary.Name = "txtAnnSalary"
        Me.txtAnnSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnSalary.TabIndex = 3
        '
        'txtMonSalary
        '
        Me.txtMonSalary.Location = New System.Drawing.Point(424, 399)
        Me.txtMonSalary.Name = "txtMonSalary"
        Me.txtMonSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtMonSalary.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMonSalary)
        Me.GroupBox1.Controls.Add(Me.txtAnnSalary)
        Me.GroupBox1.Controls.Add(Me.lblAnn)
        Me.GroupBox1.Controls.Add(Me.grd36Salary)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 432)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Participant Last 36 Months Salary"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Monthly Salary"
        '
        'frmPart_36MonthSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 491)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPart_36MonthSalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.grd36Salary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grd36Salary As System.Windows.Forms.DataGridView
    Friend WithEvents lblAnn As System.Windows.Forms.Label
    Friend WithEvents txtAnnSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtMonSalary As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
