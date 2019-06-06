<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployerInfo
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
        Dim ClsBacAuditTable2 As BAC.Controls.BacEditForm.ClsBacAuditTable = New BAC.Controls.BacEditForm.ClsBacAuditTable()
        Dim ClsBacEntryChange2 As BAC.Controls.BacEditForm.ClsBacEntryChange = New BAC.Controls.BacEditForm.ClsBacEntryChange()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployerInfo))
        Dim LockExistsEventArgs2 As BAC.Controls.BacEditForm.RecordLocking.LockExistsEventArgs = New BAC.Controls.BacEditForm.RecordLocking.LockExistsEventArgs()
        Me.bacEflNavigationControl = New BAC.Controls.BacEditForm.CompEditForm(Me.components)
        Me.AddNewDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.AddRecord()
        Me.bacStatusLabel = New System.Windows.Forms.Label()
        Me.bacStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TooStripLabelRecordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelFormMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelEntryChangeDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelEntryChangeBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bacNavButtonsHost = New BAC.Controls.BacEditForm.ButtonItems.EflButtonNavigationInnerToolStripControlHost()
        Me.CancelRecordDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.Cancel()
        Me.CancelToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.CancelItem()
        Me.CloseToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.Close()
        Me.DeleteDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.Delete()
        Me.EditDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.Edit()
        Me.ExitToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.ExitItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OkToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.OkItem()
        Me.PrintToolStripMenuItem = New BAC.Controls.BacEditForm.FileMenuItem.Print()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveFirstDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MoveFirst()
        Me.MoveLastDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MoveLast()
        Me.MoveNextDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MoveNext()
        Me.MovePreviousDropDownItem = New BAC.Controls.BacEditForm.RecordsMenuItem.MovePrevious()
        Me.bacNavMenu = New BAC.Controls.BacEditForm.ClsBacMenuStrip()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecordsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployerReportHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployerPaymentHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAuditDropDownItem = New BAC.Controls.BacEditForm.ViewMenuItem.ViewAudit()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bacRecordLockTimer = New BAC.Controls.BacEditForm.RecordLocking.BacRecordLockTimer()
        Me.bacButtonToolStrip = New BAC.Controls.BacEditForm.ClsEflToolStripNav()
        Me.bacPanel = New System.Windows.Forms.Panel()
        Me.gbContact = New System.Windows.Forms.GroupBox()
        Me.lblPart_FirstName = New System.Windows.Forms.Label()
        Me.gbAddress = New System.Windows.Forms.GroupBox()
        Me.lblAddressStreet = New System.Windows.Forms.Label()
        Me.txtEmp_Phone = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.txtEmp_Address1 = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.lblPart_Phone = New System.Windows.Forms.Label()
        Me.txtEmp_Address2 = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txtPart_Email = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.lblPart_Email = New System.Windows.Forms.Label()
        Me.txtEmp_City = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.lblPAdr_City = New System.Windows.Forms.Label()
        Me.cboEmp_StateCode = New BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox()
        Me.txtEmp_ZipCode = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.txtEmp_Fax = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.lblEmp_Fax = New System.Windows.Forms.Label()
        Me.txtEmp_HomePhone = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.lblEmp_HomePhone = New System.Windows.Forms.Label()
        Me.txtEmp_ContactFirstName = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txtEmp_ContactLastName = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txtEmp_ContactMiddleInitial = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Emp_ID = New System.Windows.Forms.Label()
        Me.cboEmp_Status1 = New BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox()
        Me.BacEflMaskedTextBox1 = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmp_CurrentCharge = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.lblEmp_ParticipationDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPart_Fund = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEmp_Fund = New BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmp_LastInvoiceDate = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmp_Name = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txtEmp_CurrentBalance = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.txtEmp_LastPayment = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.lblEmp_CurrentBalance = New System.Windows.Forms.Label()
        Me.lblEmp_Name1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmp_CurrentPay = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.txtEmp_AnnualContributionLevel = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.txtEmp_PaymentDate = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmp_OpenBalance = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.txtEmp_ParticipationDate = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.lblEmp_Status = New System.Windows.Forms.Label()
        Me.lblEmp_Status12 = New System.Windows.Forms.Label()
        Me.lblEmp_Status1 = New System.Windows.Forms.Label()
        Me.lblEmp_ID = New System.Windows.Forms.Label()
        Me.txtEmp_ID = New BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox()
        Me.lblEmp_ID1 = New System.Windows.Forms.Label()
        Me.bacStatus.SuspendLayout()
        Me.bacNavMenu.SuspendLayout()
        Me.bacButtonToolStrip.SuspendLayout()
        Me.bacPanel.SuspendLayout()
        Me.gbContact.SuspendLayout()
        Me.gbAddress.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bacEflNavigationControl
        '
        Me.bacEflNavigationControl.AddNewDropDownItem = Me.AddNewDropDownItem
        Me.bacEflNavigationControl.AddNewEnabled = True
        Me.bacEflNavigationControl.AddNewVisible = True
        ClsBacAuditTable2.AuditTableName = "Employer"
        ClsBacAuditTable2.KeyField = "Emp_ID"
        ClsBacAuditTable2.StoredProcedureName = Nothing
        Me.bacEflNavigationControl.AuditTableList.Add(ClsBacAuditTable2)
        Me.bacEflNavigationControl.AuditThisForm = True
        Me.bacEflNavigationControl.AutoResizeButtonToolBar = True
        Me.bacEflNavigationControl.BacStatusLabel = Me.bacStatusLabel
        Me.bacEflNavigationControl.BacStatusLabelShowError = True
        Me.bacEflNavigationControl.BacStatusStrip = Me.bacStatus
        Me.bacEflNavigationControl.BacStatusStripShowError = True
        Me.bacEflNavigationControl.ButtonBarHost = Me.bacNavButtonsHost
        Me.bacEflNavigationControl.CancelEnabled = True
        Me.bacEflNavigationControl.CancelRecordDropDownItem = Me.CancelRecordDropDownItem
        Me.bacEflNavigationControl.CancelToolStripMenuItem = Me.CancelToolStripMenuItem
        Me.bacEflNavigationControl.CancelVisible = True
        Me.bacEflNavigationControl.CloseToolStripMenuItem = Me.CloseToolStripMenuItem
        Me.bacEflNavigationControl.ConfirmAdd = True
        Me.bacEflNavigationControl.ConfirmUpdate = True
        Me.bacEflNavigationControl.CurrencyMgr = Nothing
        Me.bacEflNavigationControl.DataChangeMessage = CType(resources.GetObject("bacEflNavigationControl.DataChangeMessage"), System.Text.StringBuilder)
        Me.bacEflNavigationControl.DeleteDropDownItem = Me.DeleteDropDownItem
        Me.bacEflNavigationControl.DeleteEnabled = True
        Me.bacEflNavigationControl.DeleteStyle = BAC.Controls.BacEditForm.EflDeleteActionStyle.UpdateFlag
        Me.bacEflNavigationControl.DeleteVisible = True
        Me.bacEflNavigationControl.EditDropDownItem = Me.EditDropDownItem
        ClsBacEntryChange2.EntryByField = "Emp_EntryBy"
        ClsBacEntryChange2.EntryByUserName = "EntryByUserName "
        ClsBacEntryChange2.EntryDateField = "Emp_EntryDate"
        ClsBacEntryChange2.LastChangeByField = "Emp_LastChangeBy"
        ClsBacEntryChange2.LastChangeField = "Emp_LastChange"
        ClsBacEntryChange2.LastChangeUserName = "LastChangeUserName"
        ClsBacEntryChange2.TableName = "Employer"
        Me.bacEflNavigationControl.EntryChangeDataList.Add(ClsBacEntryChange2)
        Me.bacEflNavigationControl.ErrorProviderEnabled = True
        Me.bacEflNavigationControl.ExitToolStripMenuItem = Me.ExitToolStripMenuItem
        Me.bacEflNavigationControl.FileMenuItem = Me.FileToolStripMenuItem
        Me.bacEflNavigationControl.FormAction = BAC.Controls.BacEditForm.EflAction.Unknown
        Me.bacEflNavigationControl.FormPermission = BAC.Controls.BacEditForm.EflFormFilePermissionValue.EditAddDelete
        Me.bacEflNavigationControl.HelpMenuItem = Me.HelpToolStripMenuItem
        Me.bacEflNavigationControl.InformAddPreUpdateError = True
        Me.bacEflNavigationControl.InformEditPreUpdateError = True
        Me.bacEflNavigationControl.InformRecordAdded = True
        Me.bacEflNavigationControl.InformRecordUpdated = True
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
        'bacStatusLabel
        '
        Me.bacStatusLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bacStatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.bacStatusLabel.Location = New System.Drawing.Point(0, 28)
        Me.bacStatusLabel.Name = "bacStatusLabel"
        Me.bacStatusLabel.Size = New System.Drawing.Size(1230, 13)
        Me.bacStatusLabel.TabIndex = 3
        Me.bacStatusLabel.Text = "Read-only "
        '
        'bacStatus
        '
        Me.bacStatus.GripMargin = New System.Windows.Forms.Padding(0)
        Me.bacStatus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bacStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelStatus, Me.TooStripLabelRecordCount, Me.ToolStripLabelFormMode, Me.ToolStripLabelEntryChangeDate, Me.ToolStripLabelEntryChangeBy})
        Me.bacStatus.Location = New System.Drawing.Point(0, 728)
        Me.bacStatus.Name = "bacStatus"
        Me.bacStatus.Size = New System.Drawing.Size(1230, 29)
        Me.bacStatus.SizingGrip = False
        Me.bacStatus.TabIndex = 1
        Me.bacStatus.Text = "StatusStrip1"
        '
        'ToolStripLabelStatus
        '
        Me.ToolStripLabelStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripLabelStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripLabelStatus.Name = "ToolStripLabelStatus"
        Me.ToolStripLabelStatus.Size = New System.Drawing.Size(4, 24)
        '
        'TooStripLabelRecordCount
        '
        Me.TooStripLabelRecordCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TooStripLabelRecordCount.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.TooStripLabelRecordCount.Name = "TooStripLabelRecordCount"
        Me.TooStripLabelRecordCount.Size = New System.Drawing.Size(302, 24)
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
        Me.ToolStripLabelFormMode.Size = New System.Drawing.Size(302, 24)
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
        Me.ToolStripLabelEntryChangeDate.Size = New System.Drawing.Size(302, 24)
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
        Me.ToolStripLabelEntryChangeBy.Size = New System.Drawing.Size(302, 24)
        Me.ToolStripLabelEntryChangeBy.Spring = True
        Me.ToolStripLabelEntryChangeBy.Text = "ChangeBy"
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
        Me.bacNavButtonsHost.Margin = New System.Windows.Forms.Padding(100, 0, 0, 0)
        Me.bacNavButtonsHost.Name = "bacNavButtonsHost"
        Me.bacNavButtonsHost.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.bacNavButtonsHost.Size = New System.Drawing.Size(691, 34)
        '
        'CancelRecordDropDownItem
        '
        Me.CancelRecordDropDownItem.Image = CType(resources.GetObject("CancelRecordDropDownItem.Image"), System.Drawing.Image)
        Me.CancelRecordDropDownItem.MergeIndex = 10
        Me.CancelRecordDropDownItem.Name = "CancelRecordDropDownItem"
        Me.CancelRecordDropDownItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.CancelRecordDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.CancelRecordDropDownItem.Text = "Undo Record"
        Me.CancelRecordDropDownItem.ToolTipText = "Undo the Current Record"
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
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.MergeIndex = 1
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        Me.CloseToolStripMenuItem.ToolTipText = "Close this Form"
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
        'EditDropDownItem
        '
        Me.EditDropDownItem.Image = CType(resources.GetObject("EditDropDownItem.Image"), System.Drawing.Image)
        Me.EditDropDownItem.MergeIndex = 5
        Me.EditDropDownItem.Name = "ModifyDropDownItem"
        Me.EditDropDownItem.Size = New System.Drawing.Size(235, 26)
        Me.EditDropDownItem.Text = "Modify"
        Me.EditDropDownItem.ToolTipText = "Edit the Current Record"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.MergeIndex = 3
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exit Application"
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
        Me.OkToolStripMenuItem.Image = CType(resources.GetObject("OkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OkToolStripMenuItem.MergeIndex = 0
        Me.OkToolStripMenuItem.Name = "OkToolStripMenuItem"
        Me.OkToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.OkToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.OkToolStripMenuItem.Text = "Ok"
        Me.OkToolStripMenuItem.ToolTipText = "Everything is Ok"
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
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
        'bacNavMenu
        '
        Me.bacNavMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bacNavMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.bacNavMenu.Location = New System.Drawing.Point(0, 0)
        Me.bacNavMenu.Name = "bacNavMenu"
        Me.bacNavMenu.Size = New System.Drawing.Size(1230, 28)
        Me.bacNavMenu.TabIndex = 4
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveFirstDropDownItem, Me.MovePreviousDropDownItem, Me.MoveNextDropDownItem, Me.MoveLastDropDownItem, Me.RecordsSep1, Me.EditDropDownItem, Me.AddNewDropDownItem, Me.DeleteDropDownItem, Me.RecordsSep2, Me.CancelRecordDropDownItem})
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.RecordsToolStripMenuItem.Text = "R&ecords"
        '
        'RecordsSep1
        '
        Me.RecordsSep1.Name = "RecordsSep1"
        Me.RecordsSep1.Size = New System.Drawing.Size(232, 6)
        '
        'RecordsSep2
        '
        Me.RecordsSep2.Name = "RecordsSep2"
        Me.RecordsSep2.Size = New System.Drawing.Size(232, 6)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployerReportHistoryToolStripMenuItem, Me.EmployerPaymentHistoryToolStripMenuItem, Me.ViewAuditDropDownItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'EmployerReportHistoryToolStripMenuItem
        '
        Me.EmployerReportHistoryToolStripMenuItem.Name = "EmployerReportHistoryToolStripMenuItem"
        Me.EmployerReportHistoryToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.EmployerReportHistoryToolStripMenuItem.Text = "Employer Contribution Rate"
        '
        'EmployerPaymentHistoryToolStripMenuItem
        '
        Me.EmployerPaymentHistoryToolStripMenuItem.Name = "EmployerPaymentHistoryToolStripMenuItem"
        Me.EmployerPaymentHistoryToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.EmployerPaymentHistoryToolStripMenuItem.Text = "Employer Payment History"
        '
        'ViewAuditDropDownItem
        '
        Me.ViewAuditDropDownItem.Image = CType(resources.GetObject("ViewAuditDropDownItem.Image"), System.Drawing.Image)
        Me.ViewAuditDropDownItem.MergeIndex = 0
        Me.ViewAuditDropDownItem.Name = "ViewAuditDropDownItem"
        Me.ViewAuditDropDownItem.Size = New System.Drawing.Size(268, 26)
        Me.ViewAuditDropDownItem.Text = "View Audit Trail"
        Me.ViewAuditDropDownItem.ToolTipText = "View Audit History for record."
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'bacRecordLockTimer
        '
        LockExistsEventArgs2.LockExistsEntityId = ""
        LockExistsEventArgs2.LockExistsEntityType = ""
        LockExistsEventArgs2.LockExistsId = ""
        LockExistsEventArgs2.LockExistsLockId = ""
        LockExistsEventArgs2.LockExistsMessage = ""
        LockExistsEventArgs2.LockExistsTime = ""
        LockExistsEventArgs2.LockExistsType = ""
        LockExistsEventArgs2.LockExistsUserId = ""
        LockExistsEventArgs2.LockExistsUserName = ""
        LockExistsEventArgs2.LockExistsWorkstation = ""
        Me.bacRecordLockTimer.EntityLockExistsEventArgs = LockExistsEventArgs2
        Me.bacRecordLockTimer.LockTimeSeconds = 0
        Me.bacRecordLockTimer.TimeLeftMessage = ""
        Me.bacRecordLockTimer.UseRecordLock = False
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
        Me.bacButtonToolStrip.Location = New System.Drawing.Point(0, 687)
        Me.bacButtonToolStrip.Name = "bacButtonToolStrip"
        Me.bacButtonToolStrip.Size = New System.Drawing.Size(1230, 41)
        Me.bacButtonToolStrip.TabIndex = 0
        Me.bacButtonToolStrip.Text = "bacToolStrip"
        '
        'bacPanel
        '
        Me.bacPanel.Controls.Add(Me.gbContact)
        Me.bacPanel.Controls.Add(Me.GroupBox1)
        Me.bacPanel.Controls.Add(Me.lblEmp_Status1)
        Me.bacPanel.Controls.Add(Me.lblEmp_ID)
        Me.bacPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bacPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bacPanel.Location = New System.Drawing.Point(0, 41)
        Me.bacPanel.Name = "bacPanel"
        Me.bacPanel.Size = New System.Drawing.Size(1230, 646)
        Me.bacPanel.TabIndex = 0
        '
        'gbContact
        '
        Me.gbContact.Controls.Add(Me.lblPart_FirstName)
        Me.gbContact.Controls.Add(Me.gbAddress)
        Me.gbContact.Controls.Add(Me.txtEmp_ContactFirstName)
        Me.gbContact.Controls.Add(Me.txtEmp_ContactLastName)
        Me.gbContact.Controls.Add(Me.txtEmp_ContactMiddleInitial)
        Me.gbContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContact.Location = New System.Drawing.Point(15, 285)
        Me.gbContact.Margin = New System.Windows.Forms.Padding(4)
        Me.gbContact.Name = "gbContact"
        Me.gbContact.Padding = New System.Windows.Forms.Padding(4)
        Me.gbContact.Size = New System.Drawing.Size(869, 340)
        Me.gbContact.TabIndex = 2
        Me.gbContact.TabStop = False
        Me.gbContact.Text = "Contact"
        '
        'lblPart_FirstName
        '
        Me.lblPart_FirstName.AutoSize = True
        Me.lblPart_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_FirstName.Location = New System.Drawing.Point(16, 36)
        Me.lblPart_FirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_FirstName.Name = "lblPart_FirstName"
        Me.lblPart_FirstName.Size = New System.Drawing.Size(49, 17)
        Me.lblPart_FirstName.TabIndex = 78
        Me.lblPart_FirstName.Text = "Name:"
        '
        'gbAddress
        '
        Me.gbAddress.Controls.Add(Me.lblAddressStreet)
        Me.gbAddress.Controls.Add(Me.txtEmp_Phone)
        Me.gbAddress.Controls.Add(Me.txtEmp_Address1)
        Me.gbAddress.Controls.Add(Me.lblPart_Phone)
        Me.gbAddress.Controls.Add(Me.txtEmp_Address2)
        Me.gbAddress.Controls.Add(Me.txtPart_Email)
        Me.gbAddress.Controls.Add(Me.lblPart_Email)
        Me.gbAddress.Controls.Add(Me.txtEmp_City)
        Me.gbAddress.Controls.Add(Me.lblPAdr_City)
        Me.gbAddress.Controls.Add(Me.cboEmp_StateCode)
        Me.gbAddress.Controls.Add(Me.txtEmp_ZipCode)
        Me.gbAddress.Controls.Add(Me.txtEmp_Fax)
        Me.gbAddress.Controls.Add(Me.lblEmp_Fax)
        Me.gbAddress.Controls.Add(Me.txtEmp_HomePhone)
        Me.gbAddress.Controls.Add(Me.lblEmp_HomePhone)
        Me.gbAddress.Location = New System.Drawing.Point(9, 63)
        Me.gbAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAddress.Name = "gbAddress"
        Me.gbAddress.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAddress.Size = New System.Drawing.Size(567, 272)
        Me.gbAddress.TabIndex = 64
        Me.gbAddress.TabStop = False
        Me.gbAddress.Text = "Address"
        '
        'lblAddressStreet
        '
        Me.lblAddressStreet.AutoSize = True
        Me.lblAddressStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressStreet.Location = New System.Drawing.Point(7, 23)
        Me.lblAddressStreet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddressStreet.Name = "lblAddressStreet"
        Me.lblAddressStreet.Size = New System.Drawing.Size(50, 17)
        Me.lblAddressStreet.TabIndex = 35
        Me.lblAddressStreet.Text = "Street:"
        '
        'txtEmp_Phone
        '
        Me.txtEmp_Phone.AllowFieldEdit = True
        Me.txtEmp_Phone.AllowFieldInsert = True
        Me.txtEmp_Phone.AuditField = True
        Me.txtEmp_Phone.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmp_Phone.DatabaseBindFieldName = "Emp_Phone"
        Me.txtEmp_Phone.DatabaseTableName = "Employer"
        Me.txtEmp_Phone.DefaultValue = Nothing
        Me.txtEmp_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_Phone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtEmp_Phone.Location = New System.Drawing.Point(68, 129)
        Me.txtEmp_Phone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_Phone.Mask = "000-000-0000"
        Me.txtEmp_Phone.Name = "txtEmp_Phone"
        Me.txtEmp_Phone.Required = False
        Me.txtEmp_Phone.Size = New System.Drawing.Size(117, 23)
        Me.txtEmp_Phone.StatusStripInfo = Me.bacStatus
        Me.txtEmp_Phone.StatusStripTip = "Participant Phone Number"
        Me.txtEmp_Phone.TabIndex = 86
        Me.txtEmp_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtEmp_Phone.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacPhoneMask)
        '
        'txtEmp_Address1
        '
        Me.txtEmp_Address1.AllowFieldEdit = True
        Me.txtEmp_Address1.AllowFieldInsert = True
        Me.txtEmp_Address1.AuditField = True
        Me.txtEmp_Address1.BackColor = System.Drawing.Color.White
        Me.txtEmp_Address1.DatabaseBindFieldName = "Emp_Address1"
        Me.txtEmp_Address1.DatabaseTableName = "Employer"
        Me.txtEmp_Address1.DefaultValue = ""
        Me.txtEmp_Address1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_Address1.Location = New System.Drawing.Point(67, 18)
        Me.txtEmp_Address1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_Address1.MaxLength = 30
        Me.txtEmp_Address1.Name = "txtEmp_Address1"
        Me.txtEmp_Address1.Required = False
        Me.txtEmp_Address1.Size = New System.Drawing.Size(473, 23)
        Me.txtEmp_Address1.StatusStripInfo = Me.bacStatus
        Me.txtEmp_Address1.StatusStripTip = "Address Field (1)"
        Me.txtEmp_Address1.TabIndex = 32
        '
        'lblPart_Phone
        '
        Me.lblPart_Phone.AutoSize = True
        Me.lblPart_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPart_Phone.Location = New System.Drawing.Point(6, 133)
        Me.lblPart_Phone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Phone.Name = "lblPart_Phone"
        Me.lblPart_Phone.Size = New System.Drawing.Size(53, 17)
        Me.lblPart_Phone.TabIndex = 83
        Me.lblPart_Phone.Text = "Phone:"
        '
        'txtEmp_Address2
        '
        Me.txtEmp_Address2.AllowFieldEdit = True
        Me.txtEmp_Address2.AllowFieldInsert = True
        Me.txtEmp_Address2.AuditField = True
        Me.txtEmp_Address2.DatabaseBindFieldName = "Emp_Address2"
        Me.txtEmp_Address2.DatabaseTableName = "Employer"
        Me.txtEmp_Address2.DefaultValue = Nothing
        Me.txtEmp_Address2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_Address2.Location = New System.Drawing.Point(67, 55)
        Me.txtEmp_Address2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_Address2.MaxLength = 30
        Me.txtEmp_Address2.Name = "txtEmp_Address2"
        Me.txtEmp_Address2.Required = False
        Me.txtEmp_Address2.Size = New System.Drawing.Size(473, 23)
        Me.txtEmp_Address2.StatusStripInfo = Me.bacStatus
        Me.txtEmp_Address2.StatusStripTip = "Address Field (2)"
        Me.txtEmp_Address2.TabIndex = 33
        '
        'txtPart_Email
        '
        Me.txtPart_Email.AllowFieldEdit = True
        Me.txtPart_Email.AllowFieldInsert = True
        Me.txtPart_Email.AuditField = True
        Me.txtPart_Email.DatabaseBindFieldName = "Emp_Email"
        Me.txtPart_Email.DatabaseTableName = "Survivor"
        Me.txtPart_Email.DefaultValue = Nothing
        Me.txtPart_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPart_Email.Format = ""
        Me.txtPart_Email.Location = New System.Drawing.Point(68, 240)
        Me.txtPart_Email.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPart_Email.Name = "txtPart_Email"
        Me.txtPart_Email.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.TextValue
        Me.txtPart_Email.Required = False
        Me.txtPart_Email.Size = New System.Drawing.Size(291, 23)
        Me.txtPart_Email.StatusStripInfo = Me.bacStatus
        Me.txtPart_Email.StatusStripTip = "Email Address"
        Me.txtPart_Email.TabIndex = 84
        Me.txtPart_Email.ValidationRegexStatement = "^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9" &
    "a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{" &
    "2,17}))$"
        '
        'lblPart_Email
        '
        Me.lblPart_Email.AutoSize = True
        Me.lblPart_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPart_Email.Location = New System.Drawing.Point(12, 243)
        Me.lblPart_Email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Email.Name = "lblPart_Email"
        Me.lblPart_Email.Size = New System.Drawing.Size(46, 17)
        Me.lblPart_Email.TabIndex = 85
        Me.lblPart_Email.Text = "Email:"
        '
        'txtEmp_City
        '
        Me.txtEmp_City.AllowFieldEdit = True
        Me.txtEmp_City.AllowFieldInsert = True
        Me.txtEmp_City.AuditField = True
        Me.txtEmp_City.DatabaseBindFieldName = "Emp_City"
        Me.txtEmp_City.DatabaseTableName = "Employer"
        Me.txtEmp_City.DefaultValue = Nothing
        Me.txtEmp_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_City.Location = New System.Drawing.Point(67, 87)
        Me.txtEmp_City.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_City.MaxLength = 20
        Me.txtEmp_City.Name = "txtEmp_City"
        Me.txtEmp_City.Required = True
        Me.txtEmp_City.Size = New System.Drawing.Size(219, 23)
        Me.txtEmp_City.StatusStripInfo = Me.bacStatus
        Me.txtEmp_City.StatusStripTip = "City Name"
        Me.txtEmp_City.TabIndex = 36
        '
        'lblPAdr_City
        '
        Me.lblPAdr_City.AutoSize = True
        Me.lblPAdr_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPAdr_City.Location = New System.Drawing.Point(9, 91)
        Me.lblPAdr_City.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPAdr_City.Name = "lblPAdr_City"
        Me.lblPAdr_City.Size = New System.Drawing.Size(39, 17)
        Me.lblPAdr_City.TabIndex = 37
        Me.lblPAdr_City.Text = "CSZ:"
        '
        'cboEmp_StateCode
        '
        Me.cboEmp_StateCode.AllowFieldEdit = True
        Me.cboEmp_StateCode.AllowFieldInsert = True
        Me.cboEmp_StateCode.AuditField = True
        Me.cboEmp_StateCode.CodesTypeId = "-1"
        Me.cboEmp_StateCode.DatabaseBindFieldName = "Emp_StateCode"
        Me.cboEmp_StateCode.DatabaseTableName = "Employer"
        Me.cboEmp_StateCode.DefaultValue = Nothing
        Me.cboEmp_StateCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmp_StateCode.DropDownWidth = 140
        Me.cboEmp_StateCode.EscapeAction = BAC.Controls.BacEditForm.EflFormControls.BacEflComboEscapeIndex.OriginalIndex
        Me.cboEmp_StateCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmp_StateCode.IndexOnEscape = -1
        Me.cboEmp_StateCode.Location = New System.Drawing.Point(301, 87)
        Me.cboEmp_StateCode.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEmp_StateCode.Name = "cboEmp_StateCode"
        Me.cboEmp_StateCode.Required = False
        Me.cboEmp_StateCode.SelectedValueType = BAC.Controls.BacEditForm.EflFormControls.BacComboSetSelectedValueType.ObjectItem
        Me.cboEmp_StateCode.ShowBlankLine = False
        Me.cboEmp_StateCode.Size = New System.Drawing.Size(61, 25)
        Me.cboEmp_StateCode.StatusStripInfo = Me.bacStatus
        Me.cboEmp_StateCode.StatusStripTip = "State or Province"
        Me.cboEmp_StateCode.TabIndex = 41
        '
        'txtEmp_ZipCode
        '
        Me.txtEmp_ZipCode.AllowFieldEdit = True
        Me.txtEmp_ZipCode.AllowFieldInsert = True
        Me.txtEmp_ZipCode.AuditField = True
        Me.txtEmp_ZipCode.DatabaseBindFieldName = "Emp_ZipCode"
        Me.txtEmp_ZipCode.DatabaseTableName = "Employer"
        Me.txtEmp_ZipCode.DefaultValue = ""
        Me.txtEmp_ZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_ZipCode.Format = ""
        Me.txtEmp_ZipCode.Location = New System.Drawing.Point(376, 87)
        Me.txtEmp_ZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_ZipCode.Name = "txtEmp_ZipCode"
        Me.txtEmp_ZipCode.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.TextValue
        Me.txtEmp_ZipCode.Required = False
        Me.txtEmp_ZipCode.Size = New System.Drawing.Size(164, 23)
        Me.txtEmp_ZipCode.StatusStripInfo = Me.bacStatus
        Me.txtEmp_ZipCode.StatusStripTip = "Zip/Postal Code"
        Me.txtEmp_ZipCode.TabIndex = 53
        Me.txtEmp_ZipCode.ValidationRegexStatement = "(^\d{5}(-\d{4})?$)|(^[abceghjklmnprstvxyABCEGHJKLMNPRSTVXY]{1}\d{1}[a-zA-Z]{1} *\" &
    "d{1}[a-zA-Z]{1}\d{1})"
        '
        'txtEmp_Fax
        '
        Me.txtEmp_Fax.AllowFieldEdit = True
        Me.txtEmp_Fax.AllowFieldInsert = True
        Me.txtEmp_Fax.AuditField = False
        Me.txtEmp_Fax.DatabaseBindFieldName = "Emp_Fax"
        Me.txtEmp_Fax.DatabaseTableName = "Employer"
        Me.txtEmp_Fax.DefaultValue = Nothing
        Me.txtEmp_Fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_Fax.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtEmp_Fax.Location = New System.Drawing.Point(68, 166)
        Me.txtEmp_Fax.Mask = "000-000-0000"
        Me.txtEmp_Fax.Name = "txtEmp_Fax"
        Me.txtEmp_Fax.Required = False
        Me.txtEmp_Fax.Size = New System.Drawing.Size(100, 23)
        Me.txtEmp_Fax.StatusStripInfo = Me.bacStatus
        Me.txtEmp_Fax.StatusStripTip = "fax number"
        Me.txtEmp_Fax.TabIndex = 87
        Me.txtEmp_Fax.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtEmp_Fax.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacPhoneMask)
        '
        'lblEmp_Fax
        '
        Me.lblEmp_Fax.AutoSize = True
        Me.lblEmp_Fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp_Fax.Location = New System.Drawing.Point(12, 166)
        Me.lblEmp_Fax.Name = "lblEmp_Fax"
        Me.lblEmp_Fax.Size = New System.Drawing.Size(34, 17)
        Me.lblEmp_Fax.TabIndex = 88
        Me.lblEmp_Fax.Text = "Fax:"
        '
        'txtEmp_HomePhone
        '
        Me.txtEmp_HomePhone.AllowFieldEdit = True
        Me.txtEmp_HomePhone.AllowFieldInsert = True
        Me.txtEmp_HomePhone.AuditField = False
        Me.txtEmp_HomePhone.DatabaseBindFieldName = "Emp_HomePhone"
        Me.txtEmp_HomePhone.DatabaseTableName = "Employer"
        Me.txtEmp_HomePhone.DefaultValue = Nothing
        Me.txtEmp_HomePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_HomePhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtEmp_HomePhone.Location = New System.Drawing.Point(68, 203)
        Me.txtEmp_HomePhone.Mask = "000-000-0000"
        Me.txtEmp_HomePhone.Name = "txtEmp_HomePhone"
        Me.txtEmp_HomePhone.Required = False
        Me.txtEmp_HomePhone.Size = New System.Drawing.Size(100, 23)
        Me.txtEmp_HomePhone.StatusStripInfo = Me.bacStatus
        Me.txtEmp_HomePhone.StatusStripTip = "Home Phone Number"
        Me.txtEmp_HomePhone.TabIndex = 89
        Me.txtEmp_HomePhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtEmp_HomePhone.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacPhoneMask)
        '
        'lblEmp_HomePhone
        '
        Me.lblEmp_HomePhone.AutoSize = True
        Me.lblEmp_HomePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp_HomePhone.Location = New System.Drawing.Point(3, 206)
        Me.lblEmp_HomePhone.Name = "lblEmp_HomePhone"
        Me.lblEmp_HomePhone.Size = New System.Drawing.Size(49, 17)
        Me.lblEmp_HomePhone.TabIndex = 90
        Me.lblEmp_HomePhone.Text = "Home:"
        '
        'txtEmp_ContactFirstName
        '
        Me.txtEmp_ContactFirstName.AllowFieldEdit = True
        Me.txtEmp_ContactFirstName.AllowFieldInsert = True
        Me.txtEmp_ContactFirstName.AuditField = True
        Me.txtEmp_ContactFirstName.DatabaseBindFieldName = "Emp_ContactFirstName"
        Me.txtEmp_ContactFirstName.DatabaseTableName = "Employer"
        Me.txtEmp_ContactFirstName.DefaultValue = Nothing
        Me.txtEmp_ContactFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmp_ContactFirstName.Location = New System.Drawing.Point(76, 32)
        Me.txtEmp_ContactFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_ContactFirstName.MaxLength = 20
        Me.txtEmp_ContactFirstName.Name = "txtEmp_ContactFirstName"
        Me.txtEmp_ContactFirstName.Required = True
        Me.txtEmp_ContactFirstName.Size = New System.Drawing.Size(172, 23)
        Me.txtEmp_ContactFirstName.StatusStripInfo = Me.bacStatus
        Me.txtEmp_ContactFirstName.StatusStripTip = "Enter First Name of Contact"
        Me.txtEmp_ContactFirstName.TabIndex = 77
        '
        'txtEmp_ContactLastName
        '
        Me.txtEmp_ContactLastName.AllowFieldEdit = True
        Me.txtEmp_ContactLastName.AllowFieldInsert = True
        Me.txtEmp_ContactLastName.AuditField = True
        Me.txtEmp_ContactLastName.DatabaseBindFieldName = "Emp_ContactLastName"
        Me.txtEmp_ContactLastName.DatabaseTableName = "Emplyer"
        Me.txtEmp_ContactLastName.DefaultValue = Nothing
        Me.txtEmp_ContactLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmp_ContactLastName.Location = New System.Drawing.Point(305, 32)
        Me.txtEmp_ContactLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_ContactLastName.MaxLength = 40
        Me.txtEmp_ContactLastName.Name = "txtEmp_ContactLastName"
        Me.txtEmp_ContactLastName.Required = True
        Me.txtEmp_ContactLastName.Size = New System.Drawing.Size(243, 23)
        Me.txtEmp_ContactLastName.StatusStripInfo = Me.bacStatus
        Me.txtEmp_ContactLastName.StatusStripTip = "Last Name of Contact"
        Me.txtEmp_ContactLastName.TabIndex = 71
        '
        'txtEmp_ContactMiddleInitial
        '
        Me.txtEmp_ContactMiddleInitial.AllowFieldEdit = True
        Me.txtEmp_ContactMiddleInitial.AllowFieldInsert = True
        Me.txtEmp_ContactMiddleInitial.AuditField = True
        Me.txtEmp_ContactMiddleInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmp_ContactMiddleInitial.DatabaseBindFieldName = "Emp_ContactMiddleInitial"
        Me.txtEmp_ContactMiddleInitial.DatabaseTableName = "Employer"
        Me.txtEmp_ContactMiddleInitial.DefaultValue = Nothing
        Me.txtEmp_ContactMiddleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmp_ContactMiddleInitial.Location = New System.Drawing.Point(257, 32)
        Me.txtEmp_ContactMiddleInitial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_ContactMiddleInitial.MaxLength = 1
        Me.txtEmp_ContactMiddleInitial.Name = "txtEmp_ContactMiddleInitial"
        Me.txtEmp_ContactMiddleInitial.Required = False
        Me.txtEmp_ContactMiddleInitial.Size = New System.Drawing.Size(37, 23)
        Me.txtEmp_ContactMiddleInitial.StatusStripInfo = Me.bacStatus
        Me.txtEmp_ContactMiddleInitial.StatusStripTip = "Contact's Middlle Initial (1 character)"
        Me.txtEmp_ContactMiddleInitial.TabIndex = 79
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Emp_ID)
        Me.GroupBox1.Controls.Add(Me.cboEmp_Status1)
        Me.GroupBox1.Controls.Add(Me.BacEflMaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEmp_CurrentCharge)
        Me.GroupBox1.Controls.Add(Me.lblEmp_ParticipationDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblPart_Fund)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboEmp_Fund)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEmp_LastInvoiceDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtEmp_Name)
        Me.GroupBox1.Controls.Add(Me.txtEmp_CurrentBalance)
        Me.GroupBox1.Controls.Add(Me.txtEmp_LastPayment)
        Me.GroupBox1.Controls.Add(Me.lblEmp_CurrentBalance)
        Me.GroupBox1.Controls.Add(Me.lblEmp_Name1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmp_CurrentPay)
        Me.GroupBox1.Controls.Add(Me.txtEmp_AnnualContributionLevel)
        Me.GroupBox1.Controls.Add(Me.txtEmp_PaymentDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEmp_OpenBalance)
        Me.GroupBox1.Controls.Add(Me.txtEmp_ParticipationDate)
        Me.GroupBox1.Controls.Add(Me.lblEmp_Status)
        Me.GroupBox1.Controls.Add(Me.lblEmp_Status12)
        Me.GroupBox1.Controls.Add(Me.txtEmp_ID)
        Me.GroupBox1.Controls.Add(Me.lblEmp_ID1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 263)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employer"
        '
        'Emp_ID
        '
        Me.Emp_ID.AutoSize = True
        Me.Emp_ID.Location = New System.Drawing.Point(339, 142)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(49, 17)
        Me.Emp_ID.TabIndex = 107
        Me.Emp_ID.Text = "EmpID"
        '
        'cboEmp_Status1
        '
        Me.cboEmp_Status1.AllowFieldEdit = True
        Me.cboEmp_Status1.AllowFieldInsert = True
        Me.cboEmp_Status1.AuditField = False
        Me.cboEmp_Status1.CodesTypeId = "8"
        Me.cboEmp_Status1.DatabaseBindFieldName = "Emp_Status"
        Me.cboEmp_Status1.DatabaseTableName = "Employer"
        Me.cboEmp_Status1.DefaultValue = Nothing
        Me.cboEmp_Status1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmp_Status1.EscapeAction = BAC.Controls.BacEditForm.EflFormControls.BacEflComboEscapeIndex.OriginalIndex
        Me.cboEmp_Status1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboEmp_Status1.IndexOnEscape = -1
        Me.cboEmp_Status1.Location = New System.Drawing.Point(351, 79)
        Me.cboEmp_Status1.Name = "cboEmp_Status1"
        Me.cboEmp_Status1.Required = True
        Me.cboEmp_Status1.SelectedValueType = BAC.Controls.BacEditForm.EflFormControls.BacComboSetSelectedValueType.KeyValueItem
        Me.cboEmp_Status1.ShowBlankLine = False
        Me.cboEmp_Status1.Size = New System.Drawing.Size(121, 25)
        Me.cboEmp_Status1.StatusStripInfo = Me.bacStatus
        Me.cboEmp_Status1.StatusStripTip = ""
        Me.cboEmp_Status1.TabIndex = 103
        '
        'BacEflMaskedTextBox1
        '
        Me.BacEflMaskedTextBox1.AllowFieldEdit = True
        Me.BacEflMaskedTextBox1.AllowFieldInsert = True
        Me.BacEflMaskedTextBox1.AuditField = False
        Me.BacEflMaskedTextBox1.DatabaseBindFieldName = "Emp_InactiveDate"
        Me.BacEflMaskedTextBox1.DatabaseTableName = "Employer"
        Me.BacEflMaskedTextBox1.DefaultValue = Nothing
        Me.BacEflMaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BacEflMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.BacEflMaskedTextBox1.Location = New System.Drawing.Point(736, 75)
        Me.BacEflMaskedTextBox1.Mask = "00/00/0000"
        Me.BacEflMaskedTextBox1.Name = "BacEflMaskedTextBox1"
        Me.BacEflMaskedTextBox1.Required = False
        Me.BacEflMaskedTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.BacEflMaskedTextBox1.StatusStripInfo = Me.bacStatus
        Me.BacEflMaskedTextBox1.StatusStripTip = "Employer Inactive Date"
        Me.BacEflMaskedTextBox1.TabIndex = 83
        Me.BacEflMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.BacEflMaskedTextBox1.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 17)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Current Month Payment:"
        '
        'txtEmp_CurrentCharge
        '
        Me.txtEmp_CurrentCharge.AllowFieldEdit = False
        Me.txtEmp_CurrentCharge.AllowFieldInsert = False
        Me.txtEmp_CurrentCharge.AuditField = False
        Me.txtEmp_CurrentCharge.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp_CurrentCharge.DatabaseBindFieldName = "Emp_CurrentCharge"
        Me.txtEmp_CurrentCharge.DatabaseTableName = "Employer"
        Me.txtEmp_CurrentCharge.DefaultValue = "0.00"
        Me.txtEmp_CurrentCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_CurrentCharge.Format = "C"
        Me.txtEmp_CurrentCharge.Location = New System.Drawing.Point(736, 151)
        Me.txtEmp_CurrentCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_CurrentCharge.Name = "txtEmp_CurrentCharge"
        Me.txtEmp_CurrentCharge.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.txtEmp_CurrentCharge.Required = False
        Me.txtEmp_CurrentCharge.Size = New System.Drawing.Size(124, 23)
        Me.txtEmp_CurrentCharge.StatusStripInfo = Me.bacStatus
        Me.txtEmp_CurrentCharge.StatusStripTip = "Current month charges"
        Me.txtEmp_CurrentCharge.TabIndex = 93
        Me.txtEmp_CurrentCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmp_CurrentCharge.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'lblEmp_ParticipationDate
        '
        Me.lblEmp_ParticipationDate.AutoSize = True
        Me.lblEmp_ParticipationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp_ParticipationDate.Location = New System.Drawing.Point(15, 81)
        Me.lblEmp_ParticipationDate.Name = "lblEmp_ParticipationDate"
        Me.lblEmp_ParticipationDate.Size = New System.Drawing.Size(124, 17)
        Me.lblEmp_ParticipationDate.TabIndex = 80
        Me.lblEmp_ParticipationDate.Text = "Participation Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(570, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 17)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Current Month Charges:"
        '
        'lblPart_Fund
        '
        Me.lblPart_Fund.AutoSize = True
        Me.lblPart_Fund.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_Fund.Location = New System.Drawing.Point(676, 43)
        Me.lblPart_Fund.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Fund.Name = "lblPart_Fund"
        Me.lblPart_Fund.Size = New System.Drawing.Size(44, 17)
        Me.lblPart_Fund.TabIndex = 76
        Me.lblPart_Fund.Text = "Fund:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Last Payment Amt:"
        '
        'cboEmp_Fund
        '
        Me.cboEmp_Fund.AllowFieldEdit = True
        Me.cboEmp_Fund.AllowFieldInsert = True
        Me.cboEmp_Fund.AuditField = True
        Me.cboEmp_Fund.CodesTypeId = "3"
        Me.cboEmp_Fund.DatabaseBindFieldName = "Emp_Fund"
        Me.cboEmp_Fund.DatabaseTableName = "Employer"
        Me.cboEmp_Fund.DefaultValue = ""
        Me.cboEmp_Fund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmp_Fund.DropDownWidth = 120
        Me.cboEmp_Fund.EscapeAction = BAC.Controls.BacEditForm.EflFormControls.BacEflComboEscapeIndex.OriginalIndex
        Me.cboEmp_Fund.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboEmp_Fund.IndexOnEscape = -1
        Me.cboEmp_Fund.Location = New System.Drawing.Point(736, 35)
        Me.cboEmp_Fund.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEmp_Fund.Name = "cboEmp_Fund"
        Me.cboEmp_Fund.Required = True
        Me.cboEmp_Fund.SelectedValueType = BAC.Controls.BacEditForm.EflFormControls.BacComboSetSelectedValueType.KeyValueItem
        Me.cboEmp_Fund.ShowBlankLine = False
        Me.cboEmp_Fund.Size = New System.Drawing.Size(124, 25)
        Me.cboEmp_Fund.StatusStripInfo = Me.bacStatus
        Me.cboEmp_Fund.StatusStripTip = "Fund"
        Me.cboEmp_Fund.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Last Invoice Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(626, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Inactive Date:"
        '
        'txtEmp_LastInvoiceDate
        '
        Me.txtEmp_LastInvoiceDate.AllowFieldEdit = True
        Me.txtEmp_LastInvoiceDate.AllowFieldInsert = True
        Me.txtEmp_LastInvoiceDate.AuditField = False
        Me.txtEmp_LastInvoiceDate.DatabaseBindFieldName = "Emp_LastInvoiceDate"
        Me.txtEmp_LastInvoiceDate.DatabaseTableName = "Employer"
        Me.txtEmp_LastInvoiceDate.DefaultValue = Nothing
        Me.txtEmp_LastInvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_LastInvoiceDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtEmp_LastInvoiceDate.Location = New System.Drawing.Point(163, 227)
        Me.txtEmp_LastInvoiceDate.Mask = "00/00/0000"
        Me.txtEmp_LastInvoiceDate.Name = "txtEmp_LastInvoiceDate"
        Me.txtEmp_LastInvoiceDate.Required = False
        Me.txtEmp_LastInvoiceDate.Size = New System.Drawing.Size(100, 23)
        Me.txtEmp_LastInvoiceDate.StatusStripInfo = Me.bacStatus
        Me.txtEmp_LastInvoiceDate.StatusStripTip = "Last Invoice Date"
        Me.txtEmp_LastInvoiceDate.TabIndex = 95
        Me.txtEmp_LastInvoiceDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtEmp_LastInvoiceDate.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(608, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Contibution Level:"
        '
        'txtEmp_Name
        '
        Me.txtEmp_Name.AllowFieldEdit = True
        Me.txtEmp_Name.AllowFieldInsert = True
        Me.txtEmp_Name.AuditField = False
        Me.txtEmp_Name.DatabaseBindFieldName = "Emp_Name"
        Me.txtEmp_Name.DatabaseTableName = "Employer"
        Me.txtEmp_Name.DefaultValue = ""
        Me.txtEmp_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_Name.Location = New System.Drawing.Point(163, 37)
        Me.txtEmp_Name.Name = "txtEmp_Name"
        Me.txtEmp_Name.Required = False
        Me.txtEmp_Name.Size = New System.Drawing.Size(343, 23)
        Me.txtEmp_Name.StatusStripInfo = Me.bacStatus
        Me.txtEmp_Name.StatusStripTip = "Employer Name"
        Me.txtEmp_Name.TabIndex = 101
        '
        'txtEmp_CurrentBalance
        '
        Me.txtEmp_CurrentBalance.AllowFieldEdit = False
        Me.txtEmp_CurrentBalance.AllowFieldInsert = False
        Me.txtEmp_CurrentBalance.AuditField = False
        Me.txtEmp_CurrentBalance.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp_CurrentBalance.DatabaseBindFieldName = "Emp_CurrentBalance"
        Me.txtEmp_CurrentBalance.DatabaseTableName = "Employer"
        Me.txtEmp_CurrentBalance.DefaultValue = Nothing
        Me.txtEmp_CurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_CurrentBalance.Format = "C"
        Me.txtEmp_CurrentBalance.Location = New System.Drawing.Point(736, 113)
        Me.txtEmp_CurrentBalance.Name = "txtEmp_CurrentBalance"
        Me.txtEmp_CurrentBalance.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.txtEmp_CurrentBalance.Required = False
        Me.txtEmp_CurrentBalance.Size = New System.Drawing.Size(124, 23)
        Me.txtEmp_CurrentBalance.StatusStripInfo = Me.bacStatus
        Me.txtEmp_CurrentBalance.StatusStripTip = "Current Balance"
        Me.txtEmp_CurrentBalance.TabIndex = 87
        Me.txtEmp_CurrentBalance.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'txtEmp_LastPayment
        '
        Me.txtEmp_LastPayment.AllowFieldEdit = False
        Me.txtEmp_LastPayment.AllowFieldInsert = False
        Me.txtEmp_LastPayment.AuditField = False
        Me.txtEmp_LastPayment.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp_LastPayment.DatabaseBindFieldName = "Emp_LastPayment"
        Me.txtEmp_LastPayment.DatabaseTableName = "Employer"
        Me.txtEmp_LastPayment.DefaultValue = "0.00"
        Me.txtEmp_LastPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_LastPayment.Format = "C"
        Me.txtEmp_LastPayment.Location = New System.Drawing.Point(163, 189)
        Me.txtEmp_LastPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_LastPayment.Name = "txtEmp_LastPayment"
        Me.txtEmp_LastPayment.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.txtEmp_LastPayment.Required = False
        Me.txtEmp_LastPayment.Size = New System.Drawing.Size(124, 23)
        Me.txtEmp_LastPayment.StatusStripInfo = Me.bacStatus
        Me.txtEmp_LastPayment.StatusStripTip = "Current month payment"
        Me.txtEmp_LastPayment.TabIndex = 91
        Me.txtEmp_LastPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmp_LastPayment.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'lblEmp_CurrentBalance
        '
        Me.lblEmp_CurrentBalance.AutoSize = True
        Me.lblEmp_CurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp_CurrentBalance.Location = New System.Drawing.Point(585, 119)
        Me.lblEmp_CurrentBalance.Name = "lblEmp_CurrentBalance"
        Me.lblEmp_CurrentBalance.Size = New System.Drawing.Size(144, 17)
        Me.lblEmp_CurrentBalance.TabIndex = 88
        Me.lblEmp_CurrentBalance.Text = "Outstanding Balance:"
        '
        'lblEmp_Name1
        '
        Me.lblEmp_Name1.AutoSize = True
        Me.lblEmp_Name1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp_Name1.Location = New System.Drawing.Point(24, 43)
        Me.lblEmp_Name1.Name = "lblEmp_Name1"
        Me.lblEmp_Name1.Size = New System.Drawing.Size(112, 17)
        Me.lblEmp_Name1.TabIndex = 102
        Me.lblEmp_Name1.Text = "Employer Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(597, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 17)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Last Payment Date:"
        '
        'txtEmp_CurrentPay
        '
        Me.txtEmp_CurrentPay.AllowFieldEdit = False
        Me.txtEmp_CurrentPay.AllowFieldInsert = False
        Me.txtEmp_CurrentPay.AuditField = False
        Me.txtEmp_CurrentPay.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp_CurrentPay.DatabaseBindFieldName = "Emp_CurrentPay"
        Me.txtEmp_CurrentPay.DatabaseTableName = "Employer"
        Me.txtEmp_CurrentPay.DefaultValue = "0.00"
        Me.txtEmp_CurrentPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_CurrentPay.Format = "C"
        Me.txtEmp_CurrentPay.Location = New System.Drawing.Point(163, 153)
        Me.txtEmp_CurrentPay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_CurrentPay.Name = "txtEmp_CurrentPay"
        Me.txtEmp_CurrentPay.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.txtEmp_CurrentPay.Required = False
        Me.txtEmp_CurrentPay.Size = New System.Drawing.Size(124, 23)
        Me.txtEmp_CurrentPay.StatusStripInfo = Me.bacStatus
        Me.txtEmp_CurrentPay.StatusStripTip = "Current month payment"
        Me.txtEmp_CurrentPay.TabIndex = 89
        Me.txtEmp_CurrentPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmp_CurrentPay.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'txtEmp_AnnualContributionLevel
        '
        Me.txtEmp_AnnualContributionLevel.AllowFieldEdit = True
        Me.txtEmp_AnnualContributionLevel.AllowFieldInsert = True
        Me.txtEmp_AnnualContributionLevel.AuditField = True
        Me.txtEmp_AnnualContributionLevel.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmp_AnnualContributionLevel.DatabaseBindFieldName = "Emp_AnnualContributionLevel"
        Me.txtEmp_AnnualContributionLevel.DatabaseTableName = "Employer"
        Me.txtEmp_AnnualContributionLevel.DefaultValue = "0.00"
        Me.txtEmp_AnnualContributionLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_AnnualContributionLevel.Format = "C"
        Me.txtEmp_AnnualContributionLevel.Location = New System.Drawing.Point(736, 227)
        Me.txtEmp_AnnualContributionLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_AnnualContributionLevel.Name = "txtEmp_AnnualContributionLevel"
        Me.txtEmp_AnnualContributionLevel.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.txtEmp_AnnualContributionLevel.Required = False
        Me.txtEmp_AnnualContributionLevel.Size = New System.Drawing.Size(113, 23)
        Me.txtEmp_AnnualContributionLevel.StatusStripInfo = Me.bacStatus
        Me.txtEmp_AnnualContributionLevel.StatusStripTip = "Open Balance"
        Me.txtEmp_AnnualContributionLevel.TabIndex = 99
        Me.txtEmp_AnnualContributionLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmp_AnnualContributionLevel.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'txtEmp_PaymentDate
        '
        Me.txtEmp_PaymentDate.AllowFieldEdit = True
        Me.txtEmp_PaymentDate.AllowFieldInsert = True
        Me.txtEmp_PaymentDate.AuditField = False
        Me.txtEmp_PaymentDate.DatabaseBindFieldName = "Emp_PaymentDate"
        Me.txtEmp_PaymentDate.DatabaseTableName = "Employer"
        Me.txtEmp_PaymentDate.DefaultValue = Nothing
        Me.txtEmp_PaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_PaymentDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtEmp_PaymentDate.Location = New System.Drawing.Point(736, 189)
        Me.txtEmp_PaymentDate.Mask = "00/00/0000"
        Me.txtEmp_PaymentDate.Name = "txtEmp_PaymentDate"
        Me.txtEmp_PaymentDate.Required = False
        Me.txtEmp_PaymentDate.Size = New System.Drawing.Size(100, 23)
        Me.txtEmp_PaymentDate.StatusStripInfo = Me.bacStatus
        Me.txtEmp_PaymentDate.StatusStripTip = "Last Payment Date"
        Me.txtEmp_PaymentDate.TabIndex = 97
        Me.txtEmp_PaymentDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtEmp_PaymentDate.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Opening Balance:"
        '
        'txtEmp_OpenBalance
        '
        Me.txtEmp_OpenBalance.AllowFieldEdit = False
        Me.txtEmp_OpenBalance.AllowFieldInsert = False
        Me.txtEmp_OpenBalance.AuditField = False
        Me.txtEmp_OpenBalance.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmp_OpenBalance.DatabaseBindFieldName = "Emp_OpenBalance"
        Me.txtEmp_OpenBalance.DatabaseTableName = "Employer"
        Me.txtEmp_OpenBalance.DefaultValue = "0.00"
        Me.txtEmp_OpenBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_OpenBalance.Format = "C"
        Me.txtEmp_OpenBalance.Location = New System.Drawing.Point(163, 116)
        Me.txtEmp_OpenBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_OpenBalance.Name = "txtEmp_OpenBalance"
        Me.txtEmp_OpenBalance.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.txtEmp_OpenBalance.Required = False
        Me.txtEmp_OpenBalance.Size = New System.Drawing.Size(124, 23)
        Me.txtEmp_OpenBalance.StatusStripInfo = Me.bacStatus
        Me.txtEmp_OpenBalance.StatusStripTip = "Open Balance"
        Me.txtEmp_OpenBalance.TabIndex = 85
        Me.txtEmp_OpenBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmp_OpenBalance.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'txtEmp_ParticipationDate
        '
        Me.txtEmp_ParticipationDate.AllowFieldEdit = True
        Me.txtEmp_ParticipationDate.AllowFieldInsert = True
        Me.txtEmp_ParticipationDate.AuditField = False
        Me.txtEmp_ParticipationDate.DatabaseBindFieldName = "Emp_ParticipationDate"
        Me.txtEmp_ParticipationDate.DatabaseTableName = "Employer"
        Me.txtEmp_ParticipationDate.DefaultValue = Nothing
        Me.txtEmp_ParticipationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp_ParticipationDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtEmp_ParticipationDate.Location = New System.Drawing.Point(163, 75)
        Me.txtEmp_ParticipationDate.Mask = "00/00/0000"
        Me.txtEmp_ParticipationDate.Name = "txtEmp_ParticipationDate"
        Me.txtEmp_ParticipationDate.Required = False
        Me.txtEmp_ParticipationDate.Size = New System.Drawing.Size(100, 23)
        Me.txtEmp_ParticipationDate.StatusStripInfo = Me.bacStatus
        Me.txtEmp_ParticipationDate.StatusStripTip = "Employer Participation Date"
        Me.txtEmp_ParticipationDate.TabIndex = 79
        Me.txtEmp_ParticipationDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtEmp_ParticipationDate.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'lblEmp_Status
        '
        Me.lblEmp_Status.AutoSize = True
        Me.lblEmp_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp_Status.Location = New System.Drawing.Point(293, 78)
        Me.lblEmp_Status.Name = "lblEmp_Status"
        Me.lblEmp_Status.Size = New System.Drawing.Size(52, 17)
        Me.lblEmp_Status.TabIndex = 82
        Me.lblEmp_Status.Text = "Status:"
        '
        'lblEmp_Status12
        '
        Me.lblEmp_Status12.AutoSize = True
        Me.lblEmp_Status12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblEmp_Status12.Location = New System.Drawing.Point(15, 40)
        Me.lblEmp_Status12.Name = "lblEmp_Status12"
        Me.lblEmp_Status12.Size = New System.Drawing.Size(0, 17)
        Me.lblEmp_Status12.TabIndex = 104
        '
        'lblEmp_Status1
        '
        Me.lblEmp_Status1.AutoSize = True
        Me.lblEmp_Status1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblEmp_Status1.Location = New System.Drawing.Point(15, 40)
        Me.lblEmp_Status1.Name = "lblEmp_Status1"
        Me.lblEmp_Status1.Size = New System.Drawing.Size(0, 17)
        Me.lblEmp_Status1.TabIndex = 105
        '
        'lblEmp_ID
        '
        Me.lblEmp_ID.AutoSize = True
        Me.lblEmp_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblEmp_ID.Location = New System.Drawing.Point(15, 40)
        Me.lblEmp_ID.Name = "lblEmp_ID"
        Me.lblEmp_ID.Size = New System.Drawing.Size(0, 17)
        Me.lblEmp_ID.TabIndex = 107
        '
        'txtEmp_ID
        '
        Me.txtEmp_ID.AllowSecondaryUpdate = False
        Me.txtEmp_ID.DatabaseBindFieldName = "Emp_ID"
        Me.txtEmp_ID.DatabaseTableName = "Employer"
        Me.txtEmp_ID.DefaultValue = "0"
        Me.txtEmp_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.txtEmp_ID.Format = ""
        Me.txtEmp_ID.Location = New System.Drawing.Point(394, 142)
        Me.txtEmp_ID.Name = "txtEmp_ID"
        Me.txtEmp_ID.ReadOnly = True
        Me.txtEmp_ID.Size = New System.Drawing.Size(100, 22)
        Me.txtEmp_ID.StatusStripInfo = Me.bacStatus
        Me.txtEmp_ID.StatusStripTip = ""
        Me.txtEmp_ID.TabIndex = 108
        '
        'lblEmp_ID1
        '
        Me.lblEmp_ID1.AutoSize = True
        Me.lblEmp_ID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblEmp_ID1.Location = New System.Drawing.Point(15, 40)
        Me.lblEmp_ID1.Name = "lblEmp_ID1"
        Me.lblEmp_ID1.Size = New System.Drawing.Size(0, 17)
        Me.lblEmp_ID1.TabIndex = 109
        '
        'FormEmployerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 757)
        Me.Controls.Add(Me.bacPanel)
        Me.Controls.Add(Me.bacButtonToolStrip)
        Me.Controls.Add(Me.bacStatusLabel)
        Me.Controls.Add(Me.bacNavMenu)
        Me.Controls.Add(Me.bacStatus)
        Me.Name = "FormEmployerInfo"
        Me.Text = "Employer Information"
        Me.bacStatus.ResumeLayout(False)
        Me.bacStatus.PerformLayout()
        Me.bacNavMenu.ResumeLayout(False)
        Me.bacNavMenu.PerformLayout()
        Me.bacButtonToolStrip.ResumeLayout(False)
        Me.bacButtonToolStrip.PerformLayout()
        Me.bacPanel.ResumeLayout(False)
        Me.bacPanel.PerformLayout()
        Me.gbContact.ResumeLayout(False)
        Me.gbContact.PerformLayout()
        Me.gbAddress.ResumeLayout(False)
        Me.gbAddress.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bacEflNavigationControl As BAC.Controls.BacEditForm.CompEditForm
    Friend WithEvents AddNewDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.AddRecord
    Friend WithEvents bacStatusLabel As Label
    Friend WithEvents bacStatus As StatusStrip
    Friend WithEvents ToolStripLabelStatus As ToolStripStatusLabel
    Friend WithEvents TooStripLabelRecordCount As ToolStripStatusLabel
    Friend WithEvents ToolStripLabelFormMode As ToolStripStatusLabel
    Friend WithEvents ToolStripLabelEntryChangeDate As ToolStripStatusLabel
    Friend WithEvents ToolStripLabelEntryChangeBy As ToolStripStatusLabel
    Friend WithEvents CancelRecordDropDownItem As BAC.Controls.BacEditForm.RecordsMenuItem.Cancel
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
    Friend WithEvents bacRecordLockTimer As BAC.Controls.BacEditForm.RecordLocking.BacRecordLockTimer
    Friend WithEvents bacButtonToolStrip As BAC.Controls.BacEditForm.ClsEflToolStripNav
    Friend WithEvents bacPanel As Panel
    Friend WithEvents gbContact As GroupBox
    Friend WithEvents txtEmp_Phone As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents lblPart_Phone As Label
    Friend WithEvents txtPart_Email As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents lblPart_Email As Label
    Friend WithEvents lblPart_FirstName As Label
    Friend WithEvents lblPart_Fund As Label
    Friend WithEvents gbAddress As GroupBox
    Friend WithEvents lblAddressStreet As Label
    Friend WithEvents txtEmp_Address1 As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txtEmp_Address2 As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txtEmp_City As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents lblPAdr_City As Label
    Friend WithEvents cboEmp_StateCode As BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox
    Friend WithEvents txtEmp_ZipCode As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents txtEmp_ContactFirstName As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txtEmp_ContactLastName As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txtEmp_ContactMiddleInitial As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents cboEmp_Fund As BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox
    Friend WithEvents txtEmp_Fax As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents lblEmp_Fax As Label
    Friend WithEvents txtEmp_HomePhone As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents lblEmp_HomePhone As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmp_CurrentCharge As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents BacEflMaskedTextBox1 As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmp_CurrentBalance As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents lblEmp_CurrentBalance As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmp_AnnualContributionLevel As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmp_PaymentDate As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents lblEmp_Status1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEmp_ParticipationDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmp_LastInvoiceDate As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents txtEmp_Name As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txtEmp_LastPayment As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents lblEmp_Name1 As Label
    Friend WithEvents txtEmp_CurrentPay As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmp_OpenBalance As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents txtEmp_ParticipationDate As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents lblEmp_Status As Label
    Friend WithEvents cboEmp_Status1 As BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox
    Friend WithEvents lblEmp_Status12 As Label
    Friend WithEvents bacNavButtonsHost As BAC.Controls.BacEditForm.ButtonItems.EflButtonNavigationInnerToolStripControlHost
    Friend WithEvents EmployerReportHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployerPaymentHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Emp_ID As Label
    Friend WithEvents lblEmp_ID As Label
    Friend WithEvents txtEmp_ID As BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox
    Friend WithEvents lblEmp_ID1 As Label
End Class
