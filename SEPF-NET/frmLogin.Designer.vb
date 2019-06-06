<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSQL = New System.Windows.Forms.RadioButton()
        Me.optNT = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPwsd = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.txtCancel = New System.Windows.Forms.Button()
        Me.txtClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSQL)
        Me.GroupBox1.Controls.Add(Me.optNT)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(195, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'optSQL
        '
        Me.optSQL.AutoSize = True
        Me.optSQL.Location = New System.Drawing.Point(39, 84)
        Me.optSQL.Margin = New System.Windows.Forms.Padding(4)
        Me.optSQL.Name = "optSQL"
        Me.optSQL.Size = New System.Drawing.Size(103, 21)
        Me.optSQL.TabIndex = 1
        Me.optSQL.TabStop = True
        Me.optSQL.Text = "SQL Server"
        Me.optSQL.UseVisualStyleBackColor = True
        '
        'optNT
        '
        Me.optNT.AutoSize = True
        Me.optNT.Location = New System.Drawing.Point(41, 28)
        Me.optNT.Margin = New System.Windows.Forms.Padding(4)
        Me.optNT.Name = "optNT"
        Me.optNT.Size = New System.Drawing.Size(48, 21)
        Me.optNT.TabIndex = 0
        Me.optNT.TabStop = True
        Me.optNT.Text = "NT"
        Me.optNT.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPwsd)
        Me.GroupBox2.Controls.Add(Me.txtUserID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtDBName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtServer)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(235, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(300, 220)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 187)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password:"
        '
        'txtPwsd
        '
        Me.txtPwsd.Location = New System.Drawing.Point(145, 176)
        Me.txtPwsd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPwsd.Name = "txtPwsd"
        Me.txtPwsd.Size = New System.Drawing.Size(132, 22)
        Me.txtPwsd.TabIndex = 6
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(145, 135)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(132, 22)
        Me.txtUserID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User ID:"
        '
        'txtDBName
        '
        Me.txtDBName.Location = New System.Drawing.Point(145, 82)
        Me.txtDBName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(109, 22)
        Me.txtDBName.TabIndex = 3
        Me.txtDBName.Text = "SEPF-NET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Database Name:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(123, 39)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(132, 22)
        Me.txtServer.TabIndex = 1
        Me.txtServer.Text = "Brickyard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server:"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(127, 258)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(100, 28)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'txtCancel
        '
        Me.txtCancel.Location = New System.Drawing.Point(267, 258)
        Me.txtCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCancel.Name = "txtCancel"
        Me.txtCancel.Size = New System.Drawing.Size(100, 28)
        Me.txtCancel.TabIndex = 3
        Me.txtCancel.Text = "&Cancel"
        Me.txtCancel.UseVisualStyleBackColor = True
        '
        'txtClose
        '
        Me.txtClose.Location = New System.Drawing.Point(380, 258)
        Me.txtClose.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClose.Name = "txtClose"
        Me.txtClose.Size = New System.Drawing.Size(100, 28)
        Me.txtClose.TabIndex = 4
        Me.txtClose.Text = "Close"
        Me.txtClose.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 298)
        Me.Controls.Add(Me.txtClose)
        Me.Controls.Add(Me.txtCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optSQL As System.Windows.Forms.RadioButton
    Friend WithEvents optNT As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPwsd As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDBName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents txtCancel As System.Windows.Forms.Button
    Friend WithEvents txtClose As System.Windows.Forms.Button
End Class
