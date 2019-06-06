<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmployerPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployerPayment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.QbeDateBox4 = New SEPF_NET.QbeDateBox()
        Me.QbeDateBox3 = New SEPF_NET.QbeDateBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QbeDateBox2 = New SEPF_NET.QbeDateBox()
        Me.QbeDateBox1 = New SEPF_NET.QbeDateBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.gbxGrid = New System.Windows.Forms.GroupBox()
        Me.gbxButtons = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.dgResults = New BAC.Controls.bacQbeDataGridView()
        Me.EmpID = New BAC.Controls.bacQbeDataGridViewIdColumn()
        Me.EmployerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fund = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticipantDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryBy = New BAC.Controls.bacQbeDataGridViewEntryByColumn()
        Me.EntryDate = New BAC.Controls.bacQbeDataGridViewEntryDateColumn()
        Me.bacStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tslComment = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslEntryBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslEntryDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bacQbeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbxSelections.SuspendLayout()
        Me.gbxGrid.SuspendLayout()
        Me.gbxButtons.SuspendLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bacStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1154, 28)
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
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = CType(resources.GetObject("FindToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Image = CType(resources.GetObject("ResetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(129, 6)
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Image = CType(resources.GetObject("BrowseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BrowseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.BrowseToolStripMenuItem.Text = "Browse"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Image = CType(resources.GetObject("GoToToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GoToToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.GoToToolStripMenuItem.Text = "GoTo"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(129, 6)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
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
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbxSelections)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbxGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bacStatusStrip)
        Me.SplitContainer1.Size = New System.Drawing.Size(1154, 646)
        Me.SplitContainer1.SplitterDistance = 113
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'gbxSelections
        '
        Me.gbxSelections.Controls.Add(Me.QbeDateBox4)
        Me.gbxSelections.Controls.Add(Me.QbeDateBox3)
        Me.gbxSelections.Controls.Add(Me.Label6)
        Me.gbxSelections.Controls.Add(Me.Label5)
        Me.gbxSelections.Controls.Add(Me.Label4)
        Me.gbxSelections.Controls.Add(Me.Label3)
        Me.gbxSelections.Controls.Add(Me.QbeDateBox2)
        Me.gbxSelections.Controls.Add(Me.QbeDateBox1)
        Me.gbxSelections.Controls.Add(Me.cmdReset)
        Me.gbxSelections.Controls.Add(Me.Label1)
        Me.gbxSelections.Controls.Add(Me.cmdFind)
        Me.gbxSelections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxSelections.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSelections.Location = New System.Drawing.Point(0, 0)
        Me.gbxSelections.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxSelections.Name = "gbxSelections"
        Me.gbxSelections.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxSelections.Size = New System.Drawing.Size(1154, 113)
        Me.gbxSelections.TabIndex = 0
        Me.gbxSelections.TabStop = False
        '
        'QbeDateBox4
        '
        Me.QbeDateBox4.BoxStyle = SEPF_NET.QbeDateBox.DateBoxStyle.ToBox
        Me.QbeDateBox4.ClearTextEntryOnEscape = True
        Me.QbeDateBox4.DefaultValue = ""
        Me.QbeDateBox4.Location = New System.Drawing.Point(858, 57)
        Me.QbeDateBox4.Mask = "00/00/0000"
        Me.QbeDateBox4.Name = "QbeDateBox4"
        Me.QbeDateBox4.QbeBackColorOnEnter = System.Drawing.Color.Aqua
        Me.QbeDateBox4.QbeBackColorOnError = System.Drawing.Color.Yellow
        Me.QbeDateBox4.QbeBackColorOnExit = System.Drawing.Color.White
        Me.QbeDateBox4.QbeFieldName = "Epay_Transferdate2"
        Me.QbeDateBox4.ShowAlphaNumericErrorBackColor = True
        Me.QbeDateBox4.Size = New System.Drawing.Size(100, 23)
        Me.QbeDateBox4.StatusLabelError = Nothing
        Me.QbeDateBox4.TabIndex = 10
        Me.QbeDateBox4.ValidatingType = GetType(Date)
        '
        'QbeDateBox3
        '
        Me.QbeDateBox3.BoxStyle = SEPF_NET.QbeDateBox.DateBoxStyle.FromBox
        Me.QbeDateBox3.ClearTextEntryOnEscape = True
        Me.QbeDateBox3.DefaultValue = ""
        Me.QbeDateBox3.Location = New System.Drawing.Point(698, 57)
        Me.QbeDateBox3.Mask = "00/00/0000"
        Me.QbeDateBox3.Name = "QbeDateBox3"
        Me.QbeDateBox3.QbeBackColorOnEnter = System.Drawing.Color.Aqua
        Me.QbeDateBox3.QbeBackColorOnError = System.Drawing.Color.Yellow
        Me.QbeDateBox3.QbeBackColorOnExit = System.Drawing.Color.White
        Me.QbeDateBox3.QbeFieldName = "Epay_Transferdate"
        Me.QbeDateBox3.ShowAlphaNumericErrorBackColor = True
        Me.QbeDateBox3.Size = New System.Drawing.Size(100, 23)
        Me.QbeDateBox3.StatusLabelError = Nothing
        Me.QbeDateBox3.TabIndex = 9
        Me.QbeDateBox3.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(815, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(545, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Transfer Date From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Payment Date From:"
        '
        'QbeDateBox2
        '
        Me.QbeDateBox2.BoxStyle = SEPF_NET.QbeDateBox.DateBoxStyle.ToBox
        Me.QbeDateBox2.ClearTextEntryOnEscape = True
        Me.QbeDateBox2.DefaultValue = ""
        Me.QbeDateBox2.Location = New System.Drawing.Point(318, 57)
        Me.QbeDateBox2.Mask = "00/00/0000"
        Me.QbeDateBox2.Name = "QbeDateBox2"
        Me.QbeDateBox2.QbeBackColorOnEnter = System.Drawing.Color.Aqua
        Me.QbeDateBox2.QbeBackColorOnError = System.Drawing.Color.Yellow
        Me.QbeDateBox2.QbeBackColorOnExit = System.Drawing.Color.White
        Me.QbeDateBox2.QbeFieldName = "Epay_Month2"
        Me.QbeDateBox2.ShowAlphaNumericErrorBackColor = True
        Me.QbeDateBox2.Size = New System.Drawing.Size(100, 23)
        Me.QbeDateBox2.StatusLabelError = Nothing
        Me.QbeDateBox2.TabIndex = 4
        Me.QbeDateBox2.ValidatingType = GetType(Date)
        '
        'QbeDateBox1
        '
        Me.QbeDateBox1.BoxStyle = SEPF_NET.QbeDateBox.DateBoxStyle.FromBox
        Me.QbeDateBox1.ClearTextEntryOnEscape = True
        Me.QbeDateBox1.DefaultValue = ""
        Me.QbeDateBox1.Location = New System.Drawing.Point(172, 57)
        Me.QbeDateBox1.Mask = "00/00/0000"
        Me.QbeDateBox1.Name = "QbeDateBox1"
        Me.QbeDateBox1.QbeBackColorOnEnter = System.Drawing.Color.Aqua
        Me.QbeDateBox1.QbeBackColorOnError = System.Drawing.Color.Yellow
        Me.QbeDateBox1.QbeBackColorOnExit = System.Drawing.Color.White
        Me.QbeDateBox1.QbeFieldName = "Epay_Month"
        Me.QbeDateBox1.ShowAlphaNumericErrorBackColor = True
        Me.QbeDateBox1.Size = New System.Drawing.Size(100, 23)
        Me.QbeDateBox1.StatusLabelError = Nothing
        Me.QbeDateBox1.TabIndex = 3
        Me.QbeDateBox1.ValidatingType = GetType(Date)
        '
        'cmdReset
        '
        Me.cmdReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReset.Location = New System.Drawing.Point(1036, 57)
        Me.cmdReset.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Label1.Size = New System.Drawing.Size(256, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employer Payment Search Criteria"
        '
        'cmdFind
        '
        Me.cmdFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFind.Location = New System.Drawing.Point(1036, 15)
        Me.cmdFind.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(100, 33)
        Me.cmdFind.TabIndex = 0
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'gbxGrid
        '
        Me.gbxGrid.Controls.Add(Me.gbxButtons)
        Me.gbxGrid.Controls.Add(Me.dgResults)
        Me.gbxGrid.Controls.Add(Me.Label2)
        Me.gbxGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxGrid.Location = New System.Drawing.Point(0, 0)
        Me.gbxGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxGrid.Name = "gbxGrid"
        Me.gbxGrid.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxGrid.Size = New System.Drawing.Size(1154, 499)
        Me.gbxGrid.TabIndex = 6
        Me.gbxGrid.TabStop = False
        '
        'gbxButtons
        '
        Me.gbxButtons.Controls.Add(Me.cmdClose)
        Me.gbxButtons.Controls.Add(Me.cmdPrint)
        Me.gbxButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxButtons.Location = New System.Drawing.Point(4, 437)
        Me.gbxButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxButtons.Name = "gbxButtons"
        Me.gbxButtons.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxButtons.Size = New System.Drawing.Size(1146, 58)
        Me.gbxButtons.TabIndex = 7
        Me.gbxButtons.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(621, 17)
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
        Me.cmdPrint.Location = New System.Drawing.Point(496, 17)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(100, 33)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.UseVisualStyleBackColor = True
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
        Me.dgResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpID, Me.EmployerName, Me.Fund, Me.Status, Me.ParticipantDate, Me.EntryBy, Me.EntryDate})
        Me.dgResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgResults.InnerStatusStrip = Me.bacStatusStrip
        Me.dgResults.Location = New System.Drawing.Point(4, 19)
        Me.dgResults.Margin = New System.Windows.Forms.Padding(4)
        Me.dgResults.MaxRecordsReturned = 1000
        Me.dgResults.Name = "dgResults"
        Me.dgResults.ReadOnly = True
        Me.dgResults.RecordSourceCommandType = BAC.Controls.bacQbeDataGridView.GridCommandType.View
        Me.dgResults.RecordSourceName = "v_EmployerPayment"
        Me.dgResults.RowHeadersWidth = 25
        Me.dgResults.RowTemplate.Height = 24
        Me.dgResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResults.Size = New System.Drawing.Size(1146, 476)
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
        Me.EmpID.TableNameOfIdField = "EmployerPayment"
        Me.EmpID.Visible = False
        '
        'EmployerName
        '
        Me.EmployerName.DataPropertyName = "Epay_Month"
        Me.EmployerName.HeaderText = "Payment Month"
        Me.EmployerName.Name = "EmployerName"
        Me.EmployerName.ReadOnly = True
        Me.EmployerName.Width = 200
        '
        'Fund
        '
        Me.Fund.DataPropertyName = "Epay_Amount"
        Me.Fund.HeaderText = "Amount"
        Me.Fund.Name = "Fund"
        Me.Fund.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Epay_Type"
        Me.Status.HeaderText = "Type"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'ParticipantDate
        '
        Me.ParticipantDate.DataPropertyName = "Epay_Transferdate"
        Me.ParticipantDate.HeaderText = "Transfer Date"
        Me.ParticipantDate.Name = "ParticipantDate"
        Me.ParticipantDate.ReadOnly = True
        Me.ParticipantDate.Width = 200
        '
        'EntryBy
        '
        Me.EntryBy.DataPropertyName = "EntryName"
        Me.EntryBy.HeaderText = "EntryBy"
        Me.EntryBy.Name = "EntryBy"
        Me.EntryBy.ReadOnly = True
        Me.EntryBy.Visible = False
        '
        'EntryDate
        '
        Me.EntryDate.DataPropertyName = "Epay_EntryDate"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.EntryDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.EntryDate.HeaderText = "EntryDate"
        Me.EntryDate.Name = "EntryDate"
        Me.EntryDate.ReadOnly = True
        Me.EntryDate.Visible = False
        '
        'bacStatusStrip
        '
        Me.bacStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bacStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslComment, Me.tslEntryBy, Me.tslEntryDate})
        Me.bacStatusStrip.Location = New System.Drawing.Point(0, 499)
        Me.bacStatusStrip.Name = "bacStatusStrip"
        Me.bacStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.bacStatusStrip.Size = New System.Drawing.Size(1154, 29)
        Me.bacStatusStrip.TabIndex = 4
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
        Me.tslEntryBy.Size = New System.Drawing.Size(442, 24)
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
        Me.tslEntryDate.Size = New System.Drawing.Size(442, 24)
        Me.tslEntryDate.Spring = True
        Me.tslEntryDate.Text = "EntryDate"
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
        'FormEmployerPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 674)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormEmployerPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employer Search"
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
        Me.gbxButtons.ResumeLayout(False)
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bacStatusStrip.ResumeLayout(False)
        Me.bacStatusStrip.PerformLayout()
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
    Friend WithEvents bacStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tslComment As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslEntryBy As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslEntryDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents bacQbeToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents gbxGrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgResults As BAC.Controls.bacQbeDataGridView
    Friend WithEvents EmpID As BAC.Controls.bacQbeDataGridViewIdColumn
    Friend WithEvents EmployerName As DataGridViewTextBoxColumn
    Friend WithEvents Fund As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents ParticipantDate As DataGridViewTextBoxColumn
    Friend WithEvents EntryBy As BAC.Controls.bacQbeDataGridViewEntryByColumn
    Friend WithEvents EntryDate As BAC.Controls.bacQbeDataGridViewEntryDateColumn
    Friend WithEvents QbeDateBox1 As QbeDateBox
    Friend WithEvents QbeDateBox2 As QbeDateBox
    Friend WithEvents gbxButtons As GroupBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QbeDateBox4 As QbeDateBox
    Friend WithEvents QbeDateBox3 As QbeDateBox
    ' Friend WithEvents QbeDateBox1 As QbeDateBox
End Class
