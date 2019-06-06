<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSurvivorQBE
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSurvivorQBE))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.gbxSelections = New System.Windows.Forms.GroupBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.gbxGrid = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgResults = New System.Windows.Forms.DataGridView()
        Me.gbxButtons = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdGoTo = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslComment = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslEntryBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslEntryDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLastChangeBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLastChangeDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bacQbeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BacQbeTextBox1 = New BAC.Controls.bacQbeTextBox()
        Me.BacQbeCombo1 = New BAC.Controls.bacQbeCombo()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbxSelections.SuspendLayout()
        Me.gbxGrid.SuspendLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxButtons.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1149, 28)
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
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(180, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.ExitToolStripMenuItem.Text = "Exit Application"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.ResetToolStripMenuItem, Me.toolStripSeparator3, Me.BrowseToolStripMenuItem, Me.GoToToolStripMenuItem, Me.toolStripSeparator4, Me.NewToolStripMenuItem})
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = CType(resources.GetObject("FindToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Image = CType(resources.GetObject("ResetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(123, 6)
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Image = CType(resources.GetObject("BrowseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BrowseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.BrowseToolStripMenuItem.Text = "Browse"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Image = CType(resources.GetObject("GoToToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GoToToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.GoToToolStripMenuItem.Text = "GoTo"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(123, 6)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Enabled = False
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
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
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(133, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbxSelections)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbxGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbxButtons)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1149, 622)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'gbxSelections
        '
        Me.gbxSelections.Controls.Add(Me.BacQbeCombo1)
        Me.gbxSelections.Controls.Add(Me.BacQbeTextBox1)
        Me.gbxSelections.Controls.Add(Me.cmdReset)
        Me.gbxSelections.Controls.Add(Me.Label1)
        Me.gbxSelections.Controls.Add(Me.cmdFind)
        Me.gbxSelections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxSelections.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSelections.Location = New System.Drawing.Point(0, 0)
        Me.gbxSelections.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxSelections.Name = "gbxSelections"
        Me.gbxSelections.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxSelections.Size = New System.Drawing.Size(1149, 204)
        Me.gbxSelections.TabIndex = 0
        Me.gbxSelections.TabStop = False
        '
        'cmdReset
        '
        Me.cmdReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReset.Location = New System.Drawing.Point(1033, 64)
        Me.cmdReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(100, 33)
        Me.cmdReset.TabIndex = 2
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Criteria"
        '
        'cmdFind
        '
        Me.cmdFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFind.Location = New System.Drawing.Point(1033, 23)
        Me.cmdFind.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(100, 33)
        Me.cmdFind.TabIndex = 0
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'gbxGrid
        '
        Me.gbxGrid.Controls.Add(Me.Label2)
        Me.gbxGrid.Controls.Add(Me.dgResults)
        Me.gbxGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxGrid.Location = New System.Drawing.Point(0, 0)
        Me.gbxGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxGrid.Name = "gbxGrid"
        Me.gbxGrid.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxGrid.Size = New System.Drawing.Size(1149, 326)
        Me.gbxGrid.TabIndex = 6
        Me.gbxGrid.TabStop = False
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
        'dgResults
        '
        Me.dgResults.AllowUserToAddRows = False
        Me.dgResults.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgResults.Location = New System.Drawing.Point(4, 19)
        Me.dgResults.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgResults.Name = "dgResults"
        Me.dgResults.RowHeadersWidth = 25
        Me.dgResults.RowTemplate.Height = 24
        Me.dgResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResults.Size = New System.Drawing.Size(1141, 303)
        Me.dgResults.TabIndex = 0
        '
        'gbxButtons
        '
        Me.gbxButtons.Controls.Add(Me.cmdClose)
        Me.gbxButtons.Controls.Add(Me.cmdPrint)
        Me.gbxButtons.Controls.Add(Me.cmdBrowse)
        Me.gbxButtons.Controls.Add(Me.cmdGoTo)
        Me.gbxButtons.Controls.Add(Me.cmdNew)
        Me.gbxButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxButtons.Location = New System.Drawing.Point(0, 326)
        Me.gbxButtons.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxButtons.Name = "gbxButtons"
        Me.gbxButtons.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxButtons.Size = New System.Drawing.Size(1149, 58)
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
        'cmdBrowse
        '
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowse.Location = New System.Drawing.Point(268, 15)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(100, 33)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdGoTo
        '
        Me.cmdGoTo.Image = CType(resources.GetObject("cmdGoTo.Image"), System.Drawing.Image)
        Me.cmdGoTo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGoTo.Location = New System.Drawing.Point(144, 15)
        Me.cmdGoTo.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.cmdGoTo.Name = "cmdGoTo"
        Me.cmdGoTo.Size = New System.Drawing.Size(100, 33)
        Me.cmdGoTo.TabIndex = 1
        Me.cmdGoTo.Text = "Go To"
        Me.cmdGoTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGoTo.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(23, 15)
        Me.cmdNew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(100, 33)
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslComment, Me.tslEntryBy, Me.tslEntryDate, Me.tslLastChangeBy, Me.tslLastChangeDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1149, 29)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
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
        Me.tslEntryBy.Size = New System.Drawing.Size(219, 24)
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
        Me.tslEntryDate.Size = New System.Drawing.Size(219, 24)
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
        Me.tslLastChangeBy.Size = New System.Drawing.Size(219, 24)
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
        Me.tslLastChangeDate.Size = New System.Drawing.Size(219, 24)
        Me.tslLastChangeDate.Spring = True
        Me.tslLastChangeDate.Text = "LastChangeDate"
        '
        'BacQbeTextBox1
        '
        Me.BacQbeTextBox1.ClearTextEntryOnEscape = True
        Me.BacQbeTextBox1.DefaultValue = ""
        Me.BacQbeTextBox1.Location = New System.Drawing.Point(178, 49)
        Me.BacQbeTextBox1.Name = "BacQbeTextBox1"
        Me.BacQbeTextBox1.QbeBackColorOnEnter = System.Drawing.Color.Aqua
        Me.BacQbeTextBox1.QbeBackColorOnError = System.Drawing.Color.Yellow
        Me.BacQbeTextBox1.QbeBackColorOnExit = System.Drawing.Color.White
        Me.BacQbeTextBox1.QbeFieldName = "Part_LastName"
        Me.BacQbeTextBox1.ShowAlphaNumericErrorBackColor = True
        Me.BacQbeTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.BacQbeTextBox1.StatusLabelError = Me.tslComment
        Me.BacQbeTextBox1.TabIndex = 3
        Me.BacQbeTextBox1.TextEntrySqlOutput = BAC.Controls.bacQbeTextBox.QbeEntrySqlOutput.EntryAlphaSqlStringLike
        '
        'BacQbeCombo1
        '
        Me.BacQbeCombo1.DefaultValue = ""
        Me.BacQbeCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BacQbeCombo1.EscapeAction = BAC.Controls.BACenums.FormEnums.ExtraComboEnums.BacComboEscapeIndex.OriginalIndex
        Me.BacQbeCombo1.FormattingEnabled = True
        Me.BacQbeCombo1.IndexOnEscape = -1
        Me.BacQbeCombo1.Location = New System.Drawing.Point(23, 47)
        Me.BacQbeCombo1.Name = "BacQbeCombo1"
        Me.BacQbeCombo1.QbeFieldName = ""
        Me.BacQbeCombo1.SelectedValueType = BAC.Controls.BACenums.FormEnums.ExtraComboEnums.BacComboSetSelectedValueType.None
        Me.BacQbeCombo1.ShowBlankLine = False
        Me.BacQbeCombo1.Size = New System.Drawing.Size(121, 25)
        Me.BacQbeCombo1.SqlReturnType = BAC.Controls.bacQbeCombo.QbeComboReturnSqlType.ReturnString
        Me.BacQbeCombo1.SqlStrings.CommandType = BAC.Controls.HelperItems.DialogForms.ClassSpPropertyStatements.SpCommandType.None
        Me.BacQbeCombo1.SqlStrings.ParmArray = New Object(-1) {}
        Me.BacQbeCombo1.SqlStrings.SqlDatabaseName = ""
        Me.BacQbeCombo1.SqlStrings.SqlSelectStatement = ""
        Me.BacQbeCombo1.SqlStrings.SqlServerName = ""
        Me.BacQbeCombo1.SqlStrings.StoredProcedureName = ""
        Me.BacQbeCombo1.StatusLabelError = Nothing
        Me.BacQbeCombo1.TabIndex = 4
        '
        'frmMemberQBE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 650)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMemberQBE"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbxSelections.ResumeLayout(False)
        Me.gbxSelections.PerformLayout()
        Me.gbxGrid.ResumeLayout(False)
        Me.gbxGrid.PerformLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxButtons.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents gbxSelections As System.Windows.Forms.GroupBox
    Friend WithEvents gbxButtons As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslComment As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslEntryBy As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslEntryDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslLastChangeBy As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslLastChangeDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents bacQbeToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents gbxGrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgResults As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents cmdGoTo As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents BacQbeTextBox1 As BAC.Controls.bacQbeTextBox
    Friend WithEvents BacQbeCombo1 As BAC.Controls.bacQbeCombo

End Class
