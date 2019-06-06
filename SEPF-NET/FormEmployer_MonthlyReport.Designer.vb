<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployer_MonthlyReport
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPartRate = New System.Windows.Forms.TextBox()
        Me.txtEmpContrib = New System.Windows.Forms.TextBox()
        Me.txtCalAmt = New System.Windows.Forms.TextBox()
        Me.grdPart = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtbContribDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtbRevcDate = New System.Windows.Forms.MaskedTextBox()
        CType(Me.grdPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local:"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(125, 21)
        Me.txtEmpName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(100, 22)
        Me.txtEmpName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contribution Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(502, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Received Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Employee Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Employer Contribution:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Calculated Amt:"
        '
        'txtPartRate
        '
        Me.txtPartRate.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtPartRate.Enabled = False
        Me.txtPartRate.Location = New System.Drawing.Point(125, 86)
        Me.txtPartRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPartRate.Name = "txtPartRate"
        Me.txtPartRate.Size = New System.Drawing.Size(100, 22)
        Me.txtPartRate.TabIndex = 7
        Me.txtPartRate.TabStop = False
        '
        'txtEmpContrib
        '
        Me.txtEmpContrib.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtEmpContrib.Enabled = False
        Me.txtEmpContrib.Location = New System.Drawing.Point(395, 87)
        Me.txtEmpContrib.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmpContrib.Name = "txtEmpContrib"
        Me.txtEmpContrib.Size = New System.Drawing.Size(100, 22)
        Me.txtEmpContrib.TabIndex = 8
        Me.txtEmpContrib.TabStop = False
        '
        'txtCalAmt
        '
        Me.txtCalAmt.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCalAmt.Enabled = False
        Me.txtCalAmt.Location = New System.Drawing.Point(613, 85)
        Me.txtCalAmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCalAmt.Name = "txtCalAmt"
        Me.txtCalAmt.Size = New System.Drawing.Size(117, 22)
        Me.txtCalAmt.TabIndex = 9
        Me.txtCalAmt.TabStop = False
        '
        'grdPart
        '
        Me.grdPart.AllowUserToAddRows = False
        Me.grdPart.AllowUserToDeleteRows = False
        Me.grdPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPart.Location = New System.Drawing.Point(17, 146)
        Me.grdPart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grdPart.Name = "grdPart"
        Me.grdPart.ReadOnly = True
        Me.grdPart.RowTemplate.Height = 24
        Me.grdPart.Size = New System.Drawing.Size(797, 218)
        Me.grdPart.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(28, 370)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 34)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 370)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 370)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtbContribDate
        '
        Me.dtbContribDate.Location = New System.Drawing.Point(395, 24)
        Me.dtbContribDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbContribDate.Mask = "00/00/0000"
        Me.dtbContribDate.Name = "dtbContribDate"
        Me.dtbContribDate.Size = New System.Drawing.Size(100, 22)
        Me.dtbContribDate.TabIndex = 0
        '
        'dtbRevcDate
        '
        Me.dtbRevcDate.Location = New System.Drawing.Point(613, 24)
        Me.dtbRevcDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtbRevcDate.Mask = "00/00/0000"
        Me.dtbRevcDate.Name = "dtbRevcDate"
        Me.dtbRevcDate.Size = New System.Drawing.Size(100, 22)
        Me.dtbRevcDate.TabIndex = 1
        '
        'FormEmployer_MonthlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 418)
        Me.Controls.Add(Me.dtbRevcDate)
        Me.Controls.Add(Me.dtbContribDate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grdPart)
        Me.Controls.Add(Me.txtCalAmt)
        Me.Controls.Add(Me.txtEmpContrib)
        Me.Controls.Add(Me.txtPartRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormEmployer_MonthlyReport"
        Me.Text = "Employer Monthly Charge"
        CType(Me.grdPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPartRate As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpContrib As System.Windows.Forms.TextBox
    Friend WithEvents txtCalAmt As System.Windows.Forms.TextBox
    Friend WithEvents grdPart As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtbContribDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtbRevcDate As System.Windows.Forms.MaskedTextBox
End Class
