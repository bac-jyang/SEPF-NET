<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim LockExistsEventArgs1 As BAC.Controls.BacEditForm.RecordLocking.LockExistsEventArgs = New BAC.Controls.BacEditForm.RecordLocking.LockExistsEventArgs()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bacEflNavigationControl = New BAC.Controls.BacEditForm.CompEditForm(Me.components)
        Me.bacButtonToolStrip = New BAC.Controls.BacEditForm.ClsEflToolStripNav()
        Me.bacNavButtonsHost = New BAC.Controls.BacEditForm.ButtonItems.EflButtonNavigationInnerToolStripControlHost()
        Me.bacStatus = New System.Windows.Forms.StatusStrip()
        Me.bacRecordLockTimer = New BAC.Controls.BacEditForm.RecordLocking.BacRecordLockTimer()
        Me.bacStatusLabel = New System.Windows.Forms.Label()
        Me.ToolStripLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TooStripLabelRecordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelFormMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelEntryChangeDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelEntryChangeBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bacPanel = New System.Windows.Forms.Panel()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OkToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.OkItem()
        Me.CancelToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.CancelItem()
        Me.CloseToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.Close()
        Me.PrintToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.Print()
        Me.ExitToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.ExitItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveFirstDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MoveFirst()
        Me.MovePreviousDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MovePrevious()
        Me.MoveNextDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MoveNext()
        Me.MoveLastDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MoveLast()
        Me.RecordsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.Edit()
        Me.AddNewDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.AddRecord()
        Me.DeleteDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.Delete()
        Me.RecordsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAuditDropDownItem = New BAC.Controls.BacEditForm.ViewMenuItem.ViewAudit()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bacNavMenu = New BAC.Controls.BacEditForm.ClsBacMenuStrip()
        Me.bacButtonToolStrip.SuspendLayout()
        Me.bacStatus.SuspendLayout()
        Me.bacNavMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'bacEflNavigationControl
        '
        Me.bacEflNavigationControl.AddNewDropDownItem = Me.AddNewDropDownItem
        Me.bacEflNavigationControl.AddNewEnabled = True
        Me.bacEflNavigationControl.AddNewVisible = True
        Me.bacEflNavigationControl.AuditThisForm = False
        Me.bacEflNavigationControl.AutoResizeButtonToolBar = True
        Me.bacEflNavigationControl.BacStatusLabel = Me.bacStatusLabel
        Me.bacEflNavigationControl.BacStatusLabelShowError = True
        Me.bacEflNavigationControl.BacStatusStrip = Me.bacStatus
        Me.bacEflNavigationControl.BacStatusStripShowError = True
        Me.bacEflNavigationControl.ButtonBarHost = Me.bacNavButtonsHost
        Me.bacEflNavigationControl.CancelEnabled = True
        Me.bacEflNavigationControl.CancelToolStripMenuItem = Me.CancelToolStripMenuItem
        Me.bacEflNavigationControl.CancelVisible = True
        Me.bacEflNavigationControl.CloseToolStripMenuItem = Me.CloseToolStripMenuItem
        Me.bacEflNavigationControl.ConfirmAdd = False
        Me.bacEflNavigationControl.ConfirmUpdate = False
        Me.bacEflNavigationControl.CurrencyMgr = Nothing
        Me.bacEflNavigationControl.DataChangeMessage = CType(resources.GetObject("bacEflNavigationControl.DataChangeMessage"), System.Text.StringBuilder)
        Me.bacEflNavigationControl.DeleteDropDownItem = Me.DeleteDropDownItem
        Me.bacEflNavigationControl.DeleteEnabled = True
        Me.bacEflNavigationControl.DeleteStyle = BAC.Controls.BacEditForm.EflDeleteActionStyle.UpdateFlag
        Me.bacEflNavigationControl.DeleteVisible = True
        Me.bacEflNavigationControl.EditDropDownItem = Me.EditDropDownItem
        Me.bacEflNavigationControl.ErrorProviderEnabled = True
        Me.bacEflNavigationControl.ExitToolStripMenuItem = Me.ExitToolStripMenuItem
        Me.bacEflNavigationControl.FileMenuItem = Me.FileToolStripMenuItem
        Me.bacEflNavigationControl.FormAction = BAC.Controls.BacEditForm.EflAction.Unknown
        Me.bacEflNavigationControl.FormPermission = BAC.Controls.BacEditForm.EflFormFilePermissionValue.Read
        Me.bacEflNavigationControl.HelpMenuItem = Me.HelpToolStripMenuItem
        Me.bacEflNavigationControl.InformAddPreUpdateError = False
        Me.bacEflNavigationControl.InformEditPreUpdateError = False
        Me.bacEflNavigationControl.InformRecordAdded = False
        Me.bacEflNavigationControl.InformRecordUpdated = False
        Me.bacEflNavigationControl.ModifyEnabled = True
        Me.bacEflNavigationControl.ModifyVisible = True
        Me.bacEflNavigationControl.MoveFirstDropDownItem = Me.MoveFirstDropDownItem
        Me.bacEflNavigationControl.MoveFirstEnabled = True
        Me.bacEflNavigationControl.MoveFirstVisible = True
        Me.bacEflNavigationControl.MoveLastDropDownItem = Me.MoveLastDropDownItem
        Me.bacEflNavigationControl.MoveLastEnabled = True
        Me.bacEflNavigationControl.MoveLastVisible = True
        Me.bacEflNavigationControl.MoveNextDropDownItem = Me.MoveNextDropDownItem
        Me.bacEflNavigationControl.MoveNextEnabled = True
        Me.bacEflNavigationControl.MoveNextVisible = True
        Me.bacEflNavigationControl.MovePreviousDropDownItem = Me.MovePreviousDropDownItem
        Me.bacEflNavigationControl.MovePreviousEnabled = True
        Me.bacEflNavigationControl.MovePreviousVisible = True
        Me.bacEflNavigationControl.Name = "bacEflNavigationControl"
        Me.bacEflNavigationControl.NavigationControlEnabled = True
        Me.bacEflNavigationControl.NavMenuStrip = Me.bacNavMenu
        Me.bacEflNavigationControl.OkToolStripMenuItem = Me.OkToolStripMenuItem
        Me.bacEflNavigationControl.PrintEnabled = True
        Me.bacEflNavigationControl.PrintToolStripMenuItem = Me.PrintToolStripMenuItem
        Me.bacEflNavigationControl.PrintVisible = True
        Me.bacEflNavigationControl.RecordLockTimer = Me.bacRecordLockTimer
        Me.bacEflNavigationControl.RecordsMenuItem = Me.RecordsToolStripMenuItem
        Me.bacEflNavigationControl.ReportsMenuItem = Me.ReportsToolStripMenuItem
        Me.bacEflNavigationControl.RequeryCallingForm = False
        Me.bacEflNavigationControl.SeparatorOne = Me.RecordsSep1
        Me.bacEflNavigationControl.SeparatorTwo = Me.RecordsSep2
        Me.bacEflNavigationControl.ViewAuditToolStripMenuItem = Me.ViewAuditDropDownItem
        Me.bacEflNavigationControl.ViewMenuItem = Me.ViewToolStripMenuItem
        '
        'bacButtonToolStrip
        '
        Me.bacButtonToolStrip.AutoSize = False
        Me.bacButtonToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bacButtonToolStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.bacButtonToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bacButtonToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bacButtonToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bacNavButtonsHost})
        Me.bacButtonToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.bacButtonToolStrip.Location = New System.Drawing.Point(0, 588)
        Me.bacButtonToolStrip.Name = "bacButtonToolStrip"
        Me.bacButtonToolStrip.Size = New System.Drawing.Size(1039, 33)
        Me.bacButtonToolStrip.TabIndex = 0
        Me.bacButtonToolStrip.Text = "bacToolStrip"
        '
        'bacNavButtonsHost
        '
        Me.bacNavButtonsHost.CausesValidation = False
        Me.bacNavButtonsHost.CmdAddNewEnabled = True
        Me.bacNavButtonsHost.CmdAddNewVisible = True
        Me.bacNavButtonsHost.CmdCancelEnabled = True
        Me.bacNavButtonsHost.CmdCancelVisible = True
        Me.bacNavButtonsHost.CmdDeleteEnabled = True
        Me.bacNavButtonsHost.CmdDeleteVisible = True
        Me.bacNavButtonsHost.CmdModifyEnabled = True
        Me.bacNavButtonsHost.CmdModifyVisible = True
        Me.bacNavButtonsHost.CmdMoveFirstEnabled = True
        Me.bacNavButtonsHost.CmdMoveFirstVisible = True
        Me.bacNavButtonsHost.CmdMoveLastEnabled = True
        Me.bacNavButtonsHost.CmdMoveLastVisible = True
        Me.bacNavButtonsHost.CmdNextEnabled = True
        Me.bacNavButtonsHost.CmdNextVisible = True
        Me.bacNavButtonsHost.CmdPreviousEnabled = True
        Me.bacNavButtonsHost.CmdPreviousVisible = True
        Me.bacNavButtonsHost.CmdPrintEnabled = True
        Me.bacNavButtonsHost.CmdPrintVisible = True
        Me.bacNavButtonsHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.bacNavButtonsHost.Margin = New System.Windows.Forms.Padding(0)
        Me.bacNavButtonsHost.Name = "bacNavButtonsHost"
        Me.bacNavButtonsHost.Size = New System.Drawing.Size(691, 29)
        '
        'bacStatus
        '
        Me.bacStatus.GripMargin = New System.Windows.Forms.Padding(0)
        Me.bacStatus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bacStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelStatus, Me.TooStripLabelRecordCount, Me.ToolStripLabelFormMode, Me.ToolStripLabelEntryChangeDate, Me.ToolStripLabelEntryChangeBy})
        Me.bacStatus.Location = New System.Drawing.Point(0, 621)
        Me.bacStatus.Name = "bacStatus"
        Me.bacStatus.Size = New System.Drawing.Size(1039, 29)
        Me.bacStatus.SizingGrip = False
        Me.bacStatus.TabIndex = 1
        Me.bacStatus.Text = "StatusStrip1"
        '
        'bacRecordLockTimer
        '
        LockExistsEventArgs1.LockExistsEntityId = ""
        LockExistsEventArgs1.LockExistsEntityType = ""
        LockExistsEventArgs1.LockExistsId = ""
        LockExistsEventArgs1.LockExistsLockId = ""
        LockExistsEventArgs1.LockExistsMessage = ""
        LockExistsEventArgs1.LockExistsTime = ""
        LockExistsEventArgs1.LockExistsType = ""
        LockExistsEventArgs1.LockExistsUserId = ""
        LockExistsEventArgs1.LockExistsUserName = ""
        LockExistsEventArgs1.LockExistsWorkstation = ""
        Me.bacRecordLockTimer.EntityLockExistsEventArgs = LockExistsEventArgs1
        Me.bacRecordLockTimer.LockTimeSeconds = 0
        Me.bacRecordLockTimer.TimeLeftMessage = ""
        Me.bacRecordLockTimer.UseRecordLock = True
        '
        'bacStatusLabel
        '
        Me.bacStatusLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bacStatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.bacStatusLabel.Location = New System.Drawing.Point(0, 28)
        Me.bacStatusLabel.Name = "bacStatusLabel"
        Me.bacStatusLabel.Size = New System.Drawing.Size(1039, 13)
        Me.bacStatusLabel.TabIndex = 3
        Me.bacStatusLabel.Text = "Read-only "
        '
        'ToolStripLabelStatus
        '
        Me.ToolStripLabelStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripLabelStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripLabelStatus.Name = "ToolStripLabelStatus"
        Me.ToolStripLabelStatus.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripLabelStatus.Text = "Status"
        '
        'TooStripLabelRecordCount
        '
        Me.TooStripLabelRecordCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TooStripLabelRecordCount.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.TooStripLabelRecordCount.Name = "TooStripLabelRecordCount"
        Me.TooStripLabelRecordCount.Size = New System.Drawing.Size(242, 24)
        Me.TooStripLabelRecordCount.Spring = True
        Me.TooStripLabelRecordCount.Text = "Record x of y"
        '
        'ToolStripLabelFormMode
        '
        Me.ToolStripLabelFormMode.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripLabelFormMode.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripLabelFormMode.Name = "ToolStripLabelFormMode"
        Me.ToolStripLabelFormMode.Size = New System.Drawing.Size(242, 24)
        Me.ToolStripLabelFormMode.Spring = True
        Me.ToolStripLabelFormMode.Text = "Read-Only"
        '
        'ToolStripLabelEntryChangeDate
        '
        Me.ToolStripLabelEntryChangeDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripLabelEntryChangeDate.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripLabelEntryChangeDate.Name = "ToolStripLabelEntryChangeDate"
        Me.ToolStripLabelEntryChangeDate.Size = New System.Drawing.Size(242, 24)
        Me.ToolStripLabelEntryChangeDate.Spring = True
        Me.ToolStripLabelEntryChangeDate.Text = "DateChange"
        '
        'ToolStripLabelEntryChangeBy
        '
        Me.ToolStripLabelEntryChangeBy.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripLabelEntryChangeBy.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripLabelEntryChangeBy.Name = "ToolStripLabelEntryChangeBy"
        Me.ToolStripLabelEntryChangeBy.Size = New System.Drawing.Size(242, 24)
        Me.ToolStripLabelEntryChangeBy.Spring = True
        Me.ToolStripLabelEntryChangeBy.Text = "ChangeBy"
        '
        'bacPanel
        '
        Me.bacPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bacPanel.Location = New System.Drawing.Point(0, 41)
        Me.bacPanel.Name = "bacPanel"
        Me.bacPanel.Size = New System.Drawing.Size(1039, 547)
        Me.bacPanel.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OkToolStripMenuItem, Me.CancelToolStripMenuItem, Me.CloseToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OkToolStripMenuItem
        '
        Me.OkToolStripMenuItem.MergeIndex = 0
        Me.OkToolStripMenuItem.Name = "OkToolStripMenuItem"
        Me.OkToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.OkToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.OkToolStripMenuItem.Text = "Ok"
        Me.OkToolStripMenuItem.ToolTipText = "Everything is Ok"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Image = CType(resources.GetObject("CancelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelToolStripMenuItem.MergeIndex = 4
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        Me.CancelToolStripMenuItem.ToolTipText = "Undo the Current Record"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.MergeIndex = 1
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        Me.CloseToolStripMenuItem.ToolTipText = "Close this Form"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.MergeIndex = 2
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        Me.PrintToolStripMenuItem.ToolTipText = "Print Form Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.MergeIndex = 3
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exit Application"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveFirstDropDownItem, Me.MovePreviousDropDownItem, Me.MoveNextDropDownItem, Me.MoveLastDropDownItem, Me.RecordsSep1, Me.EditDropDownItem, Me.AddNewDropDownItem, Me.DeleteDropDownItem, Me.RecordsSep2})
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.RecordsToolStripMenuItem.Text = "R&ecords"
        '
        'MoveFirstDropDownItem
        '
        Me.MoveFirstDropDownItem.Image = CType(resources.GetObject("MoveFirstDropDownItem.Image"), System.Drawing.Image)
        Me.MoveFirstDropDownItem.MergeIndex = 0
        Me.MoveFirstDropDownItem.Name = "MoveFirstDropDownItem"
        Me.MoveFirstDropDownItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Home), System.Windows.Forms.Keys)
        Me.MoveFirstDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.MoveFirstDropDownItem.Text = "Move First"
        Me.MoveFirstDropDownItem.ToolTipText = "Move to First Record in Set"
        '
        'MovePreviousDropDownItem
        '
        Me.MovePreviousDropDownItem.Image = CType(resources.GetObject("MovePreviousDropDownItem.Image"), System.Drawing.Image)
        Me.MovePreviousDropDownItem.MergeIndex = 1
        Me.MovePreviousDropDownItem.Name = "MovePreviousDropDownItem"
        Me.MovePreviousDropDownItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.MovePreviousDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.MovePreviousDropDownItem.Text = "Previous"
        Me.MovePreviousDropDownItem.ToolTipText = "Move to Previous Record in Set"
        '
        'MoveNextDropDownItem
        '
        Me.MoveNextDropDownItem.Image = CType(resources.GetObject("MoveNextDropDownItem.Image"), System.Drawing.Image)
        Me.MoveNextDropDownItem.MergeIndex = 2
        Me.MoveNextDropDownItem.Name = "MoveNextDropDownItem"
        Me.MoveNextDropDownItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.MoveNextDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.MoveNextDropDownItem.Text = "Move Next"
        Me.MoveNextDropDownItem.ToolTipText = "Move to Next Record in Set"
        '
        'MoveLastDropDownItem
        '
        Me.MoveLastDropDownItem.Image = CType(resources.GetObject("MoveLastDropDownItem.Image"), System.Drawing.Image)
        Me.MoveLastDropDownItem.MergeIndex = 3
        Me.MoveLastDropDownItem.Name = "MoveLastDropDownItem"
        Me.MoveLastDropDownItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.MoveLastDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.MoveLastDropDownItem.Text = "Last Record"
        Me.MoveLastDropDownItem.ToolTipText = "Move to Last Record in Set"
        '
        'RecordsSep1
        '
        Me.RecordsSep1.Name = "RecordsSep1"
        Me.RecordsSep1.Size = New System.Drawing.Size(232, 6)
        '
        'EditDropDownItem
        '
        Me.EditDropDownItem.Image = CType(resources.GetObject("EditDropDownItem.Image"), System.Drawing.Image)
        Me.EditDropDownItem.MergeIndex = 5
        Me.EditDropDownItem.Name = "ModifyDropDownItem"
        Me.EditDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.EditDropDownItem.Text = "Modify"
        Me.EditDropDownItem.ToolTipText = "Edit the Current Record"
        '
        'AddNewDropDownItem
        '
        Me.AddNewDropDownItem.Image = CType(resources.GetObject("AddNewDropDownItem.Image"), System.Drawing.Image)
        Me.AddNewDropDownItem.MergeIndex = 6
        Me.AddNewDropDownItem.Name = "AddRecordDropDownItem"
        Me.AddNewDropDownItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.AddNewDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.AddNewDropDownItem.Text = "Add Record"
        Me.AddNewDropDownItem.ToolTipText = "Add a New Record"
        '
        'DeleteDropDownItem
        '
        Me.DeleteDropDownItem.Image = CType(resources.GetObject("DeleteDropDownItem.Image"), System.Drawing.Image)
        Me.DeleteDropDownItem.MergeIndex = 7
        Me.DeleteDropDownItem.Name = "DeleteRecordDropDownItem"
        Me.DeleteDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.DeleteDropDownItem.Text = "Delete Record"
        Me.DeleteDropDownItem.ToolTipText = "Delete the Current Record"
        '
        'RecordsSep2
        '
        Me.RecordsSep2.Name = "RecordsSep2"
        Me.RecordsSep2.Size = New System.Drawing.Size(232, 6)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAuditDropDownItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewAuditDropDownItem
        '
        Me.ViewAuditDropDownItem.Image = CType(resources.GetObject("ViewAuditDropDownItem.Image"), System.Drawing.Image)
        Me.ViewAuditDropDownItem.MergeIndex = 0
        Me.ViewAuditDropDownItem.Name = "ViewAuditDropDownItem"
        Me.ViewAuditDropDownItem.Size = New System.Drawing.Size(188, 26)
        Me.ViewAuditDropDownItem.Text = "View Audit Trail"
        Me.ViewAuditDropDownItem.ToolTipText = "View Audit History for record."
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'bacNavMenu
        '
        Me.bacNavMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bacNavMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.bacNavMenu.Location = New System.Drawing.Point(0, 0)
        Me.bacNavMenu.Name = "bacNavMenu"
        Me.bacNavMenu.Size = New System.Drawing.Size(1039, 28)
        Me.bacNavMenu.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 650)
        Me.Controls.Add(Me.bacPanel)
        Me.Controls.Add(Me.bacButtonToolStrip)
        Me.Controls.Add(Me.bacStatusLabel)
        Me.Controls.Add(Me.bacNavMenu)
        Me.Controls.Add(Me.bacStatus)
        Me.Name = "Form1"
        Me.Text = "SEPF "
        Me.bacButtonToolStrip.ResumeLayout(False)
        Me.bacButtonToolStrip.PerformLayout()
        Me.bacStatus.ResumeLayout(False)
        Me.bacStatus.PerformLayout()
        Me.bacNavMenu.ResumeLayout(False)
        Me.bacNavMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bacEflNavigationControl As BAC.Controls.BacEditForm.CompEditForm
    Friend WithEvents bacStatusLabel As Label
    Friend WithEvents bacStatus As StatusStrip
    Friend WithEvents ToolStripLabelStatus As ToolStripStatusLabel
    Friend WithEvents TooStripLabelRecordCount As ToolStripStatusLabel
    Friend WithEvents ToolStripLabelFormMode As ToolStripStatusLabel
    Friend WithEvents ToolStripLabelEntryChangeDate As ToolStripStatusLabel
    Friend WithEvents ToolStripLabelEntryChangeBy As ToolStripStatusLabel
    Friend WithEvents bacNavButtonsHost As BAC.Controls.BacEditForm.ButtonItems.EflButtonNavigationInnerToolStripControlHost
    Friend WithEvents bacRecordLockTimer As BAC.Controls.BacEditForm.RecordLocking.BacRecordLockTimer
    Friend WithEvents bacButtonToolStrip As BAC.Controls.BacEditForm.ClsEflToolStripNav
    Friend WithEvents bacPanel As Panel
    Friend WithEvents AddNewDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.AddRecord
    Friend WithEvents CancelToolStripMenuItem As BAC.Controls.BacEditForm.FileMenuItem.CancelItem
    Friend WithEvents CloseToolStripMenuItem As BAC.Controls.BacEditForm.FileMenuItem.Close
    Friend WithEvents DeleteDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.Delete
    Friend WithEvents EditDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.Edit
    Friend WithEvents ExitToolStripMenuItem As BAC.Controls.BacEditForm.FileMenuItem.ExitItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OkToolStripMenuItem As BAC.Controls.BacEditForm.FileMenuItem.OkItem
    Friend WithEvents PrintToolStripMenuItem As BAC.Controls.BacEditForm.FileMenuItem.Print
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveFirstDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.MoveFirst
    Friend WithEvents MoveLastDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.MoveLast
    Friend WithEvents MoveNextDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.MoveNext
    Friend WithEvents MovePreviousDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.MovePrevious
    Friend WithEvents bacNavMenu As BAC.Controls.BacEditForm.ClsBacMenuStrip
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsSep1 As ToolStripSeparator
    Friend WithEvents RecordsSep2 As ToolStripSeparator
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAuditDropDownItem As BAC.Controls.BacEditForm.ViewMenuItem.ViewAudit
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
End Class
