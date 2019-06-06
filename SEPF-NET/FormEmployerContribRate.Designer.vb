<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmployerContribRate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployerContribRate))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbxGrid = New System.Windows.Forms.GroupBox()
        Me.dgResults = New BAC.Controls.bacQbeDataGridView()
        Me.EmpID = New BAC.Controls.bacQbeDataGridViewIdColumn()
        Me.Fund = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeginDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate_Amount_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate_Amount_Part = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxButtons = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.bacQbeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbxGrid.SuspendLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1119, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.toolStripSeparator, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(186, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(186, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ExitToolStripMenuItem.Text = "Exit Application"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.ResetToolStripMenuItem, Me.toolStripSeparator3, Me.BrowseToolStripMenuItem, Me.GoToToolStripMenuItem, Me.toolStripSeparator4, Me.NewToolStripMenuItem})
        Me.RecordsToolStripMenuItem.Enabled = False
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = CType(resources.GetObject("FindToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Image = CType(resources.GetObject("ResetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(213, 6)
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Image = CType(resources.GetObject("BrowseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BrowseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.BrowseToolStripMenuItem.Text = "Browse"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Image = CType(resources.GetObject("GoToToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GoToToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.GoToToolStripMenuItem.Text = "GoTo"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(213, 6)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Enabled = False
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Enabled = False
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(139, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbxGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbxButtons)
        Me.SplitContainer1.Size = New System.Drawing.Size(1119, 582)
        Me.SplitContainer1.SplitterDistance = 102
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'gbxGrid
        '
        Me.gbxGrid.Controls.Add(Me.dgResults)
        Me.gbxGrid.Controls.Add(Me.Label2)
        Me.gbxGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxGrid.Location = New System.Drawing.Point(0, 0)
        Me.gbxGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxGrid.Name = "gbxGrid"
        Me.gbxGrid.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxGrid.Size = New System.Drawing.Size(1119, 417)
        Me.gbxGrid.TabIndex = 6
        Me.gbxGrid.TabStop = False
        '
        'dgResults
        '
        Me.dgResults.AddSumRow = False
        Me.dgResults.AllowUserToAddRows = False
        Me.dgResults.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgResults.BoldTotalRow = False
        Me.dgResults.CenterGridInParent = True
        Me.dgResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpID, Me.Fund, Me.BeginDate, Me.Enddate, Me.Rate_Amount_Emp, Me.Rate_Amount_Part})
        Me.dgResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgResults.InnerStatusStrip = Nothing
        Me.dgResults.Location = New System.Drawing.Point(4, 19)
        Me.dgResults.Margin = New System.Windows.Forms.Padding(4)
        Me.dgResults.MaxRecordsReturned = 50
        Me.dgResults.Name = "dgResults"
        Me.dgResults.ReadOnly = True
        Me.dgResults.RecordSourceCommandType = BAC.Controls.bacQbeDataGridView.GridCommandType.View
        Me.dgResults.RecordSourceName = "v_EmployerContribRate"
        Me.dgResults.RowHeadersWidth = 25
        Me.dgResults.RowTemplate.Height = 24
        Me.dgResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResults.Size = New System.Drawing.Size(1111, 394)
        Me.dgResults.SumRowFontColor = System.Drawing.Color.Empty
        Me.dgResults.SumRowTitle = ""
        Me.dgResults.SumRowTitleOrdinal = 0
        Me.dgResults.TabIndex = 3
        '
        'EmpID
        '
        Me.EmpID.DataPropertyName = "Emp_ID"
        Me.EmpID.HeaderText = "EmpID"
        Me.EmpID.Name = "EmpID"
        Me.EmpID.ReadOnly = True
        Me.EmpID.TableNameOfIdField = "EmployerContribRate"
        Me.EmpID.Visible = False
        Me.EmpID.Width = 5
        '
        'Fund
        '
        Me.Fund.DataPropertyName = "Emp_Fund"
        Me.Fund.HeaderText = "Fund"
        Me.Fund.Name = "Fund"
        Me.Fund.ReadOnly = True
        '
        'BeginDate
        '
        Me.BeginDate.DataPropertyName = "Rate_Begindate"
        Me.BeginDate.HeaderText = "Rate BeginDate"
        Me.BeginDate.Name = "BeginDate"
        Me.BeginDate.ReadOnly = True
        Me.BeginDate.Width = 200
        '
        'Enddate
        '
        Me.Enddate.DataPropertyName = "Rate_Enddate"
        Me.Enddate.HeaderText = "Rate Enddate"
        Me.Enddate.Name = "Enddate"
        Me.Enddate.ReadOnly = True
        Me.Enddate.Width = 200
        '
        'Rate_Amount_Emp
        '
        Me.Rate_Amount_Emp.DataPropertyName = "Rate_Amount_Emp"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Rate_Amount_Emp.DefaultCellStyle = DataGridViewCellStyle2
        Me.Rate_Amount_Emp.HeaderText = "Employer Rate"
        Me.Rate_Amount_Emp.Name = "Rate_Amount_Emp"
        Me.Rate_Amount_Emp.ReadOnly = True
        Me.Rate_Amount_Emp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rate_Amount_Emp.Width = 150
        '
        'Rate_Amount_Part
        '
        Me.Rate_Amount_Part.DataPropertyName = "Rate_Amount_Part"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Rate_Amount_Part.DefaultCellStyle = DataGridViewCellStyle3
        Me.Rate_Amount_Part.HeaderText = "Employee Rate"
        Me.Rate_Amount_Part.Name = "Rate_Amount_Part"
        Me.Rate_Amount_Part.ReadOnly = True
        Me.Rate_Amount_Part.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rate_Amount_Part.Width = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, -1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Results"
        '
        'gbxButtons
        '
        Me.gbxButtons.Controls.Add(Me.cmdClose)
        Me.gbxButtons.Controls.Add(Me.cmdPrint)
        Me.gbxButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxButtons.Location = New System.Drawing.Point(0, 417)
        Me.gbxButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxButtons.Name = "gbxButtons"
        Me.gbxButtons.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxButtons.Size = New System.Drawing.Size(1119, 58)
        Me.gbxButtons.TabIndex = 5
        Me.gbxButtons.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(515, 15)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 33)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(389, 15)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(100, 33)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'FormEmployerContribRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 610)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormEmployerContribRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employer Search"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbxGrid.ResumeLayout(False)
        Me.gbxGrid.PerformLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbxButtons As System.Windows.Forms.GroupBox
    Friend WithEvents bacQbeToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents gbxGrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dgResults As BAC.Controls.bacQbeDataGridView
    Friend WithEvents EmpID As BAC.Controls.bacQbeDataGridViewIdColumn
    Friend WithEvents Fund As DataGridViewTextBoxColumn
    Friend WithEvents BeginDate As DataGridViewTextBoxColumn
    Friend WithEvents Enddate As DataGridViewTextBoxColumn
    Friend WithEvents Rate_Amount_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Rate_Amount_Part As DataGridViewTextBoxColumn
End Class
