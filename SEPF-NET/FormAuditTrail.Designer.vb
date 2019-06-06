<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuditTrail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuditTrail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bacStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tslComment = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslEntryBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslEntryDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLastChangeBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLastChangeDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgResults = New BAC.Controls.bacQbeDataGridView()
        Me.colPart_ID = New BAC.Controls.bacQbeDataGridViewIdColumn()
        Me.colTableName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFieldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNewValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChangeBy = New BAC.Controls.bacQbeDataGridViewLastChangeByColumn()
        Me.colWorkStation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEffective = New BAC.Controls.bacQbeDataGridViewLastChangeDateColumn()
        Me.gbxButtons = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.bacStatusStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ViewToolStripMenuItem1, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.toolStripSeparator, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(140, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Enabled = False
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'bacStatusStrip
        '
        Me.bacStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslComment, Me.tslEntryBy, Me.tslEntryDate, Me.tslLastChangeBy, Me.tslLastChangeDate})
        Me.bacStatusStrip.Location = New System.Drawing.Point(0, 468)
        Me.bacStatusStrip.Name = "bacStatusStrip"
        Me.bacStatusStrip.Size = New System.Drawing.Size(924, 29)
        Me.bacStatusStrip.TabIndex = 5
        Me.bacStatusStrip.Text = "StatusStrip1"
        '
        'tslComment
        '
        Me.tslComment.AutoSize = False
        Me.tslComment.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tslComment.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tslComment.Name = "tslComment"
        Me.tslComment.Size = New System.Drawing.Size(250, 24)
        Me.tslComment.Text = "Comment"
        '
        'tslEntryBy
        '
        Me.tslEntryBy.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tslEntryBy.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tslEntryBy.Name = "tslEntryBy"
        Me.tslEntryBy.Size = New System.Drawing.Size(164, 24)
        Me.tslEntryBy.Spring = True
        Me.tslEntryBy.Text = "EntryBy"
        '
        'tslEntryDate
        '
        Me.tslEntryDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tslEntryDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tslEntryDate.Name = "tslEntryDate"
        Me.tslEntryDate.Size = New System.Drawing.Size(164, 24)
        Me.tslEntryDate.Spring = True
        Me.tslEntryDate.Text = "EntryDate"
        '
        'tslLastChangeBy
        '
        Me.tslLastChangeBy.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tslLastChangeBy.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tslLastChangeBy.Name = "tslLastChangeBy"
        Me.tslLastChangeBy.Size = New System.Drawing.Size(164, 24)
        Me.tslLastChangeBy.Spring = True
        Me.tslLastChangeBy.Text = "LastChangeBy"
        '
        'tslLastChangeDate
        '
        Me.tslLastChangeDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tslLastChangeDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tslLastChangeDate.Name = "tslLastChangeDate"
        Me.tslLastChangeDate.Size = New System.Drawing.Size(164, 24)
        Me.tslLastChangeDate.Spring = True
        Me.tslLastChangeDate.Text = "LastChangeDate"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgResults)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbxButtons)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(924, 444)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 6
        '
        'dgResults
        '
        Me.dgResults.AllowDrop = True
        Me.dgResults.AllowUserToAddRows = False
        Me.dgResults.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPart_ID, Me.colTableName, Me.colFieldName, Me.colOldValue, Me.colNewValue, Me.colChangeBy, Me.colWorkStation, Me.colEffective})
        Me.dgResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgResults.InnerStatusStrip = Me.bacStatusStrip
        Me.dgResults.Location = New System.Drawing.Point(5, 0)
        Me.dgResults.MaxRecordsReturned = 800
        Me.dgResults.Name = "dgResults"
        Me.dgResults.ReadOnly = True
        Me.dgResults.RecordSourceName = "[SEPF-NET].dbo.v_ak_FillAudit_Form"
        Me.dgResults.RowHeadersWidth = 25
        Me.dgResults.RowTemplate.Height = 24
        Me.dgResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResults.Size = New System.Drawing.Size(914, 368)
        Me.dgResults.TabIndex = 7
        '
        'colPart_ID
        '
        Me.colPart_ID.DataPropertyName = "At_RefID"
        Me.colPart_ID.HeaderText = "At_RefID"
        Me.colPart_ID.Name = "colPart_ID"
        Me.colPart_ID.ReadOnly = True
        Me.colPart_ID.TableNameOfIdField = "AuditTrailSepf"
        Me.colPart_ID.Visible = False
        Me.colPart_ID.Width = 120
        '
        'colTableName
        '
        Me.colTableName.DataPropertyName = "TableName"
        Me.colTableName.HeaderText = "TableName"
        Me.colTableName.Name = "colTableName"
        Me.colTableName.ReadOnly = True
        Me.colTableName.Width = 125
        '
        'colFieldName
        '
        Me.colFieldName.DataPropertyName = "FieldName"
        Me.colFieldName.HeaderText = "FieldName"
        Me.colFieldName.Name = "colFieldName"
        Me.colFieldName.ReadOnly = True
        Me.colFieldName.Width = 170
        '
        'colOldValue
        '
        Me.colOldValue.DataPropertyName = "OldValue"
        Me.colOldValue.HeaderText = "OldValue"
        Me.colOldValue.Name = "colOldValue"
        Me.colOldValue.ReadOnly = True
        Me.colOldValue.Width = 120
        '
        'colNewValue
        '
        Me.colNewValue.DataPropertyName = "NewValue"
        Me.colNewValue.HeaderText = "NewValue"
        Me.colNewValue.Name = "colNewValue"
        Me.colNewValue.ReadOnly = True
        Me.colNewValue.Width = 130
        '
        'colChangeBy
        '
        Me.colChangeBy.DataPropertyName = "ChangeBy"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colChangeBy.DefaultCellStyle = DataGridViewCellStyle2
        Me.colChangeBy.HeaderText = "ChangeBy"
        Me.colChangeBy.Name = "colChangeBy"
        Me.colChangeBy.ReadOnly = True
        Me.colChangeBy.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colChangeBy.Width = 90
        '
        'colWorkStation
        '
        Me.colWorkStation.DataPropertyName = "WorkStation"
        Me.colWorkStation.HeaderText = "WorkStation"
        Me.colWorkStation.Name = "colWorkStation"
        Me.colWorkStation.ReadOnly = True
        Me.colWorkStation.Width = 90
        '
        'colEffective
        '
        Me.colEffective.DataPropertyName = "Effective"
        DataGridViewCellStyle3.Format = "d"
        Me.colEffective.DefaultCellStyle = DataGridViewCellStyle3
        Me.colEffective.HeaderText = "Effective"
        Me.colEffective.Name = "colEffective"
        Me.colEffective.ReadOnly = True
        Me.colEffective.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEffective.Width = 80
        '
        'gbxButtons
        '
        Me.gbxButtons.Controls.Add(Me.cmdClose)
        Me.gbxButtons.Controls.Add(Me.cmdPrint)
        Me.gbxButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxButtons.Location = New System.Drawing.Point(5, 368)
        Me.gbxButtons.Name = "gbxButtons"
        Me.gbxButtons.Size = New System.Drawing.Size(914, 47)
        Me.gbxButtons.TabIndex = 6
        Me.gbxButtons.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(466, 14)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 27)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(372, 14)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 27)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'FormAuditTrail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 497)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.bacStatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormAuditTrail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormAuditTrail"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.bacStatusStrip.ResumeLayout(False)
        Me.bacStatusStrip.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bacStatusStrip As StatusStrip
    Friend WithEvents tslComment As ToolStripStatusLabel
    Friend WithEvents tslEntryBy As ToolStripStatusLabel
    Friend WithEvents tslEntryDate As ToolStripStatusLabel
    Friend WithEvents tslLastChangeBy As ToolStripStatusLabel
    Friend WithEvents tslLastChangeDate As ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents gbxButtons As GroupBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents dgResults As BAC.Controls.bacQbeDataGridView
    Friend WithEvents colPart_ID As BAC.Controls.bacQbeDataGridViewIdColumn
    Friend WithEvents colTableName As DataGridViewTextBoxColumn
    Friend WithEvents colFieldName As DataGridViewTextBoxColumn
    Friend WithEvents colOldValue As DataGridViewTextBoxColumn
    Friend WithEvents colNewValue As DataGridViewTextBoxColumn
    Friend WithEvents colChangeBy As BAC.Controls.bacQbeDataGridViewLastChangeByColumn
    Friend WithEvents colWorkStation As DataGridViewTextBoxColumn
    Friend WithEvents colEffective As BAC.Controls.bacQbeDataGridViewLastChangeDateColumn
End Class
