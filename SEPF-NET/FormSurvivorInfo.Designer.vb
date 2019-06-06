<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSurvivorInfo
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
        Dim ClsBacAuditTable1 As BAC.Controls.BacEditForm.ClsBacAuditTable = New BAC.Controls.BacEditForm.ClsBacAuditTable()
        Dim ClsBacEntryChange1 As BAC.Controls.BacEditForm.ClsBacEntryChange = New BAC.Controls.BacEditForm.ClsBacEntryChange()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSurvivorInfo))
        Dim LockExistsEventArgs1 As BAC.Controls.BacEditForm.RecordLocking.LockExistsEventArgs = New BAC.Controls.BacEditForm.RecordLocking.LockExistsEventArgs()
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
        Me.ViewAuditDropDownItem = New BAC.Controls.BacEditForm.ViewMenuItem.ViewAudit()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bacRecordLockTimer = New BAC.Controls.BacEditForm.RecordLocking.BacRecordLockTimer()
        Me.bacButtonToolStrip = New BAC.Controls.BacEditForm.ClsEflToolStripNav()
        Me.bacPanel = New System.Windows.Forms.Panel()
        Me.gbBenefit = New System.Windows.Forms.GroupBox()
        Me.BacEflRegexTextBox3 = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BacEflMaskedTextBox6 = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BacEflMaskedTextBox5 = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BacEflMaskedTextBox2 = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.BacEflRegexTextBox2 = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BacEflRegexTextBox1 = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BacEflMaskedTextBox4 = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BacEflMaskedTextBox3 = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.gbQdro = New System.Windows.Forms.GroupBox()
        Me.Part_QDR_Flag = New BAC.Controls.BacEditForm.EflFormControls.BacEflYesNoCheckBox()
        Me.txtPart_QDR_Amount = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.lblPart_QDR_Amount = New System.Windows.Forms.Label()
        Me.txtPart_QDR_Date = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.lblPart_QDR_Date = New System.Windows.Forms.Label()
        Me.gbSurvivor = New System.Windows.Forms.GroupBox()
        Me.gbDates = New System.Windows.Forms.GroupBox()
        Me.lblPart_DOB = New System.Windows.Forms.Label()
        Me.lblPart_DOB12 = New System.Windows.Forms.Label()
        Me.txtPart_DOD = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.txtPart_DOB = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.txtPart_Phone = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.lblPart_Phone = New System.Windows.Forms.Label()
        Me.txtPart_Email = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.lblPart_Email = New System.Windows.Forms.Label()
        Me.lblPart_FirstName = New System.Windows.Forms.Label()
        Me.lblPart_RetirementDate = New System.Windows.Forms.Label()
        Me.lblPart_Gender = New System.Windows.Forms.Label()
        Me.lblPart_Fund = New System.Windows.Forms.Label()
        Me.lblPart_Marital_Status = New System.Windows.Forms.Label()
        Me.txtSurv_SSN = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.gbAddress = New System.Windows.Forms.GroupBox()
        Me.lblAddressStreet = New System.Windows.Forms.Label()
        Me.txt_Address1 = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txt_Address2 = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txt_City = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.lblPAdr_City = New System.Windows.Forms.Label()
        Me.Check_Undeliverable = New BAC.Controls.BacEditForm.EflFormControls.BacEflCheckBox()
        Me.cbo_State = New BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox()
        Me.txt_CountryName = New BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox()
        Me.txt_UndeliverableDate = New BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyDateBox()
        Me.txt_Country_Code = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txt_ZipCode = New BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox()
        Me.txtSurv_FirstName = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txtSurv_LastName = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.txtSurv_MInitial = New BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox()
        Me.cboPart_Gender = New BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox()
        Me.cboSurv_Fund = New BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox()
        Me.cboPart_Marital_Status = New BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox()
        Me.gbParticipant = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BacEflMaskedTextBox1 = New BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox()
        Me.txtPart_FirstName = New BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox()
        Me.lblPart_FirstName1 = New System.Windows.Forms.Label()
        Me.BacEflReadOnlyTextBox1 = New BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox()
        Me.BacEflReadOnlyTextBox2 = New BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox()
        Me.bacStatus.SuspendLayout()
        Me.bacNavMenu.SuspendLayout()
        Me.bacButtonToolStrip.SuspendLayout()
        Me.bacPanel.SuspendLayout()
        Me.gbBenefit.SuspendLayout()
        Me.gbQdro.SuspendLayout()
        Me.gbSurvivor.SuspendLayout()
        Me.gbDates.SuspendLayout()
        Me.gbAddress.SuspendLayout()
        Me.gbParticipant.SuspendLayout()
        Me.SuspendLayout()
        '
        'bacEflNavigationControl
        '
        Me.bacEflNavigationControl.AddNewDropDownItem = Me.AddNewDropDownItem
        Me.bacEflNavigationControl.AddNewEnabled = True
        Me.bacEflNavigationControl.AddNewVisible = True
        ClsBacAuditTable1.AuditTableName = "Survivor"
        ClsBacAuditTable1.KeyField = "Surv_ID"
        ClsBacAuditTable1.StoredProcedureName = Nothing
        Me.bacEflNavigationControl.AuditTableList.Add(ClsBacAuditTable1)
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
        ClsBacEntryChange1.EntryByField = "Surv_EntryBy"
        ClsBacEntryChange1.EntryByUserName = "EntryByUserName"
        ClsBacEntryChange1.EntryDateField = "Surv_EntryDate"
        ClsBacEntryChange1.LastChangeByField = "Surv_LastChangeBy"
        ClsBacEntryChange1.LastChangeField = "Surv_LastChange"
        ClsBacEntryChange1.LastChangeUserName = "LastChangeUserName"
        ClsBacEntryChange1.TableName = "Survivor"
        Me.bacEflNavigationControl.EntryChangeDataList.Add(ClsBacEntryChange1)
        Me.bacEflNavigationControl.ErrorProviderEnabled = True
        Me.bacEflNavigationControl.ExitToolStripMenuItem = Me.ExitToolStripMenuItem
        Me.bacEflNavigationControl.FileMenuItem = Me.FileToolStripMenuItem
        Me.bacEflNavigationControl.FormAction = BAC.Controls.BacEditForm.EflAction.Unknown
        Me.bacEflNavigationControl.FormPermission = BAC.Controls.BacEditForm.EflFormFilePermissionValue.Read
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
        Me.bacStatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bacStatusLabel.Name = "bacStatusLabel"
        Me.bacStatusLabel.Size = New System.Drawing.Size(1176, 16)
        Me.bacStatusLabel.TabIndex = 3
        Me.bacStatusLabel.Text = "Read-only "
        '
        'bacStatus
        '
        Me.bacStatus.GripMargin = New System.Windows.Forms.Padding(0)
        Me.bacStatus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bacStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelStatus, Me.TooStripLabelRecordCount, Me.ToolStripLabelFormMode, Me.ToolStripLabelEntryChangeDate, Me.ToolStripLabelEntryChangeBy})
        Me.bacStatus.Location = New System.Drawing.Point(0, 689)
        Me.bacStatus.Name = "bacStatus"
        Me.bacStatus.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.bacStatus.Size = New System.Drawing.Size(1176, 29)
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
        Me.TooStripLabelRecordCount.Size = New System.Drawing.Size(275, 24)
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
        Me.ToolStripLabelFormMode.Size = New System.Drawing.Size(275, 24)
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
        Me.ToolStripLabelEntryChangeDate.Size = New System.Drawing.Size(275, 24)
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
        Me.ToolStripLabelEntryChangeBy.Size = New System.Drawing.Size(275, 24)
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
        Me.bacNavButtonsHost.Size = New System.Drawing.Size(911, 40)
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
        Me.bacNavMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.bacNavMenu.Size = New System.Drawing.Size(1176, 28)
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
        Me.bacButtonToolStrip.Location = New System.Drawing.Point(0, 648)
        Me.bacButtonToolStrip.Name = "bacButtonToolStrip"
        Me.bacButtonToolStrip.Size = New System.Drawing.Size(1176, 41)
        Me.bacButtonToolStrip.TabIndex = 0
        Me.bacButtonToolStrip.Text = "bacToolStrip"
        '
        'bacPanel
        '
        Me.bacPanel.Controls.Add(Me.gbBenefit)
        Me.bacPanel.Controls.Add(Me.gbSurvivor)
        Me.bacPanel.Controls.Add(Me.gbParticipant)
        Me.bacPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bacPanel.Location = New System.Drawing.Point(0, 44)
        Me.bacPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bacPanel.Name = "bacPanel"
        Me.bacPanel.Size = New System.Drawing.Size(1176, 604)
        Me.bacPanel.TabIndex = 0
        '
        'gbBenefit
        '
        Me.gbBenefit.Controls.Add(Me.BacEflRegexTextBox3)
        Me.gbBenefit.Controls.Add(Me.Label9)
        Me.gbBenefit.Controls.Add(Me.Label8)
        Me.gbBenefit.Controls.Add(Me.BacEflMaskedTextBox6)
        Me.gbBenefit.Controls.Add(Me.Label7)
        Me.gbBenefit.Controls.Add(Me.BacEflMaskedTextBox5)
        Me.gbBenefit.Controls.Add(Me.Label6)
        Me.gbBenefit.Controls.Add(Me.BacEflMaskedTextBox2)
        Me.gbBenefit.Controls.Add(Me.BacEflRegexTextBox2)
        Me.gbBenefit.Controls.Add(Me.Label4)
        Me.gbBenefit.Controls.Add(Me.BacEflRegexTextBox1)
        Me.gbBenefit.Controls.Add(Me.Label3)
        Me.gbBenefit.Controls.Add(Me.Label5)
        Me.gbBenefit.Controls.Add(Me.BacEflMaskedTextBox4)
        Me.gbBenefit.Controls.Add(Me.Label2)
        Me.gbBenefit.Controls.Add(Me.BacEflMaskedTextBox3)
        Me.gbBenefit.Controls.Add(Me.gbQdro)
        Me.gbBenefit.Location = New System.Drawing.Point(16, 437)
        Me.gbBenefit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbBenefit.Name = "gbBenefit"
        Me.gbBenefit.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbBenefit.Size = New System.Drawing.Size(1147, 171)
        Me.gbBenefit.TabIndex = 2
        Me.gbBenefit.TabStop = False
        Me.gbBenefit.Text = "Benefit Information"
        '
        'BacEflRegexTextBox3
        '
        Me.BacEflRegexTextBox3.AllowFieldEdit = True
        Me.BacEflRegexTextBox3.AllowFieldInsert = True
        Me.BacEflRegexTextBox3.AuditField = True
        Me.BacEflRegexTextBox3.DatabaseBindFieldName = "Surv_LumpSum_Amount"
        Me.BacEflRegexTextBox3.DatabaseTableName = "Survivor"
        Me.BacEflRegexTextBox3.DefaultValue = "0.00"
        Me.BacEflRegexTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflRegexTextBox3.Format = "C"
        Me.BacEflRegexTextBox3.Location = New System.Drawing.Point(507, 128)
        Me.BacEflRegexTextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflRegexTextBox3.Name = "BacEflRegexTextBox3"
        Me.BacEflRegexTextBox3.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.BacEflRegexTextBox3.Required = False
        Me.BacEflRegexTextBox3.Size = New System.Drawing.Size(132, 23)
        Me.BacEflRegexTextBox3.StatusStripInfo = Me.bacStatus
        Me.BacEflRegexTextBox3.StatusStripTip = "Amount of Lump Sum Payment"
        Me.BacEflRegexTextBox3.TabIndex = 85
        Me.BacEflRegexTextBox3.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(356, 133)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 17)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Lump Sum Amount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(356, 101)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 17)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Last Check Date:"
        '
        'BacEflMaskedTextBox6
        '
        Me.BacEflMaskedTextBox6.AllowFieldEdit = True
        Me.BacEflMaskedTextBox6.AllowFieldInsert = True
        Me.BacEflMaskedTextBox6.AuditField = True
        Me.BacEflMaskedTextBox6.DatabaseBindFieldName = "Surv_Benefit_Last_Check_Date"
        Me.BacEflMaskedTextBox6.DatabaseTableName = "Survivor"
        Me.BacEflMaskedTextBox6.DefaultValue = Nothing
        Me.BacEflMaskedTextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflMaskedTextBox6.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.BacEflMaskedTextBox6.Location = New System.Drawing.Point(507, 96)
        Me.BacEflMaskedTextBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflMaskedTextBox6.Mask = "00/00/0000"
        Me.BacEflMaskedTextBox6.Name = "BacEflMaskedTextBox6"
        Me.BacEflMaskedTextBox6.Required = False
        Me.BacEflMaskedTextBox6.Size = New System.Drawing.Size(132, 23)
        Me.BacEflMaskedTextBox6.StatusStripInfo = Me.bacStatus
        Me.BacEflMaskedTextBox6.StatusStripTip = "Date of Last Pension Check"
        Me.BacEflMaskedTextBox6.TabIndex = 84
        Me.BacEflMaskedTextBox6.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.BacEflMaskedTextBox6.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(356, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 17)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Reinstatement Date:"
        '
        'BacEflMaskedTextBox5
        '
        Me.BacEflMaskedTextBox5.AllowFieldEdit = True
        Me.BacEflMaskedTextBox5.AllowFieldInsert = True
        Me.BacEflMaskedTextBox5.AuditField = True
        Me.BacEflMaskedTextBox5.DatabaseBindFieldName = "Surv_Pension_Reinstatement"
        Me.BacEflMaskedTextBox5.DatabaseTableName = "Survivor"
        Me.BacEflMaskedTextBox5.DefaultValue = Nothing
        Me.BacEflMaskedTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflMaskedTextBox5.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.BacEflMaskedTextBox5.Location = New System.Drawing.Point(507, 64)
        Me.BacEflMaskedTextBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflMaskedTextBox5.Mask = "00/00/0000"
        Me.BacEflMaskedTextBox5.Name = "BacEflMaskedTextBox5"
        Me.BacEflMaskedTextBox5.Required = False
        Me.BacEflMaskedTextBox5.Size = New System.Drawing.Size(132, 23)
        Me.BacEflMaskedTextBox5.StatusStripInfo = Me.bacStatus
        Me.BacEflMaskedTextBox5.StatusStripTip = "Date Pension was Reinstated"
        Me.BacEflMaskedTextBox5.TabIndex = 82
        Me.BacEflMaskedTextBox5.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.BacEflMaskedTextBox5.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(356, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Suspension Date:"
        '
        'BacEflMaskedTextBox2
        '
        Me.BacEflMaskedTextBox2.AllowFieldEdit = True
        Me.BacEflMaskedTextBox2.AllowFieldInsert = True
        Me.BacEflMaskedTextBox2.AuditField = True
        Me.BacEflMaskedTextBox2.DatabaseBindFieldName = "Surv_Pension_Suspension"
        Me.BacEflMaskedTextBox2.DatabaseTableName = "Survivor"
        Me.BacEflMaskedTextBox2.DefaultValue = Nothing
        Me.BacEflMaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflMaskedTextBox2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.BacEflMaskedTextBox2.Location = New System.Drawing.Point(507, 32)
        Me.BacEflMaskedTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflMaskedTextBox2.Mask = "00/00/0000"
        Me.BacEflMaskedTextBox2.Name = "BacEflMaskedTextBox2"
        Me.BacEflMaskedTextBox2.Required = False
        Me.BacEflMaskedTextBox2.Size = New System.Drawing.Size(132, 23)
        Me.BacEflMaskedTextBox2.StatusStripInfo = Me.bacStatus
        Me.BacEflMaskedTextBox2.StatusStripTip = "Date Benefit was Supsended"
        Me.BacEflMaskedTextBox2.TabIndex = 80
        Me.BacEflMaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.BacEflMaskedTextBox2.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'BacEflRegexTextBox2
        '
        Me.BacEflRegexTextBox2.AllowFieldEdit = True
        Me.BacEflRegexTextBox2.AllowFieldInsert = True
        Me.BacEflRegexTextBox2.AuditField = True
        Me.BacEflRegexTextBox2.DatabaseBindFieldName = "Surv_ITD_Benefits_Paid"
        Me.BacEflRegexTextBox2.DatabaseTableName = "Survivor"
        Me.BacEflRegexTextBox2.DefaultValue = "0.00"
        Me.BacEflRegexTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflRegexTextBox2.Format = "C"
        Me.BacEflRegexTextBox2.Location = New System.Drawing.Point(123, 96)
        Me.BacEflRegexTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflRegexTextBox2.Name = "BacEflRegexTextBox2"
        Me.BacEflRegexTextBox2.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.BacEflRegexTextBox2.Required = False
        Me.BacEflRegexTextBox2.Size = New System.Drawing.Size(132, 23)
        Me.BacEflRegexTextBox2.StatusStripInfo = Me.bacStatus
        Me.BacEflRegexTextBox2.StatusStripTip = "ITD Benefits Paid Amount"
        Me.BacEflRegexTextBox2.TabIndex = 77
        Me.BacEflRegexTextBox2.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(25, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "ITD Benefits:"
        '
        'BacEflRegexTextBox1
        '
        Me.BacEflRegexTextBox1.AllowFieldEdit = True
        Me.BacEflRegexTextBox1.AllowFieldInsert = True
        Me.BacEflRegexTextBox1.AuditField = True
        Me.BacEflRegexTextBox1.DatabaseBindFieldName = "Surv_Monthly_Benefit_Amount"
        Me.BacEflRegexTextBox1.DatabaseTableName = "Survivor"
        Me.BacEflRegexTextBox1.DefaultValue = "0.00"
        Me.BacEflRegexTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflRegexTextBox1.Format = "C"
        Me.BacEflRegexTextBox1.Location = New System.Drawing.Point(123, 64)
        Me.BacEflRegexTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflRegexTextBox1.Name = "BacEflRegexTextBox1"
        Me.BacEflRegexTextBox1.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.BacEflRegexTextBox1.Required = False
        Me.BacEflRegexTextBox1.Size = New System.Drawing.Size(132, 23)
        Me.BacEflRegexTextBox1.StatusStripInfo = Me.bacStatus
        Me.BacEflRegexTextBox1.StatusStripTip = "Survior Monthly Benefit Amount"
        Me.BacEflRegexTextBox1.TabIndex = 75
        Me.BacEflRegexTextBox1.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(25, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Benefit Amt:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(25, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Award Date:"
        '
        'BacEflMaskedTextBox4
        '
        Me.BacEflMaskedTextBox4.AllowFieldEdit = True
        Me.BacEflMaskedTextBox4.AllowFieldInsert = True
        Me.BacEflMaskedTextBox4.AuditField = True
        Me.BacEflMaskedTextBox4.DatabaseBindFieldName = "Surv_Award_Date"
        Me.BacEflMaskedTextBox4.DatabaseTableName = "Survivor"
        Me.BacEflMaskedTextBox4.DefaultValue = Nothing
        Me.BacEflMaskedTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflMaskedTextBox4.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.BacEflMaskedTextBox4.Location = New System.Drawing.Point(123, 128)
        Me.BacEflMaskedTextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflMaskedTextBox4.Mask = "00/00/0000"
        Me.BacEflMaskedTextBox4.Name = "BacEflMaskedTextBox4"
        Me.BacEflMaskedTextBox4.Required = False
        Me.BacEflMaskedTextBox4.Size = New System.Drawing.Size(132, 23)
        Me.BacEflMaskedTextBox4.StatusStripInfo = Me.bacStatus
        Me.BacEflMaskedTextBox4.StatusStripTip = "Pension Awarded Date"
        Me.BacEflMaskedTextBox4.TabIndex = 74
        Me.BacEflMaskedTextBox4.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.BacEflMaskedTextBox4.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(25, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Benefit Date:"
        '
        'BacEflMaskedTextBox3
        '
        Me.BacEflMaskedTextBox3.AllowFieldEdit = True
        Me.BacEflMaskedTextBox3.AllowFieldInsert = True
        Me.BacEflMaskedTextBox3.AuditField = True
        Me.BacEflMaskedTextBox3.DatabaseBindFieldName = "Surv_Effective_date"
        Me.BacEflMaskedTextBox3.DatabaseTableName = "Survivor"
        Me.BacEflMaskedTextBox3.DefaultValue = Nothing
        Me.BacEflMaskedTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflMaskedTextBox3.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.BacEflMaskedTextBox3.Location = New System.Drawing.Point(123, 32)
        Me.BacEflMaskedTextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflMaskedTextBox3.Mask = "00/00/0000"
        Me.BacEflMaskedTextBox3.Name = "BacEflMaskedTextBox3"
        Me.BacEflMaskedTextBox3.Required = False
        Me.BacEflMaskedTextBox3.Size = New System.Drawing.Size(132, 23)
        Me.BacEflMaskedTextBox3.StatusStripInfo = Me.bacStatus
        Me.BacEflMaskedTextBox3.StatusStripTip = "Date Benefit Began"
        Me.BacEflMaskedTextBox3.TabIndex = 71
        Me.BacEflMaskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.BacEflMaskedTextBox3.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'gbQdro
        '
        Me.gbQdro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbQdro.Controls.Add(Me.Part_QDR_Flag)
        Me.gbQdro.Controls.Add(Me.txtPart_QDR_Amount)
        Me.gbQdro.Controls.Add(Me.lblPart_QDR_Amount)
        Me.gbQdro.Controls.Add(Me.txtPart_QDR_Date)
        Me.gbQdro.Controls.Add(Me.lblPart_QDR_Date)
        Me.gbQdro.Location = New System.Drawing.Point(831, 14)
        Me.gbQdro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbQdro.Name = "gbQdro"
        Me.gbQdro.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbQdro.Size = New System.Drawing.Size(308, 150)
        Me.gbQdro.TabIndex = 67
        Me.gbQdro.TabStop = False
        Me.gbQdro.Text = "QDRO Info"
        '
        'Part_QDR_Flag
        '
        Me.Part_QDR_Flag.AllowFieldEdit = True
        Me.Part_QDR_Flag.AllowFieldInsert = True
        Me.Part_QDR_Flag.AuditField = True
        Me.Part_QDR_Flag.BindYesNoValue = "N"
        Me.Part_QDR_Flag.DatabaseBindFieldName = "Surv_QDR_Flag"
        Me.Part_QDR_Flag.DatabaseTableName = "Survivor"
        Me.Part_QDR_Flag.DefaultValue = False
        Me.Part_QDR_Flag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Part_QDR_Flag.Location = New System.Drawing.Point(93, 17)
        Me.Part_QDR_Flag.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Part_QDR_Flag.Name = "Part_QDR_Flag"
        Me.Part_QDR_Flag.Required = False
        Me.Part_QDR_Flag.Size = New System.Drawing.Size(139, 30)
        Me.Part_QDR_Flag.StatusStripInfo = Me.bacStatus
        Me.Part_QDR_Flag.StatusStripTip = "Check if QDRO"
        Me.Part_QDR_Flag.TabIndex = 0
        Me.Part_QDR_Flag.Text = "QDRO Account"
        '
        'txtPart_QDR_Amount
        '
        Me.txtPart_QDR_Amount.AllowFieldEdit = True
        Me.txtPart_QDR_Amount.AllowFieldInsert = True
        Me.txtPart_QDR_Amount.AuditField = True
        Me.txtPart_QDR_Amount.DatabaseBindFieldName = "Surv_Monthly_Benefit_Amount_BQDR"
        Me.txtPart_QDR_Amount.DatabaseTableName = "Survivor"
        Me.txtPart_QDR_Amount.DefaultValue = "0.00"
        Me.txtPart_QDR_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPart_QDR_Amount.Format = "C"
        Me.txtPart_QDR_Amount.Location = New System.Drawing.Point(93, 53)
        Me.txtPart_QDR_Amount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPart_QDR_Amount.Name = "txtPart_QDR_Amount"
        Me.txtPart_QDR_Amount.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.MoneyValue
        Me.txtPart_QDR_Amount.Required = False
        Me.txtPart_QDR_Amount.Size = New System.Drawing.Size(132, 23)
        Me.txtPart_QDR_Amount.StatusStripInfo = Me.bacStatus
        Me.txtPart_QDR_Amount.StatusStripTip = "QDRO Benefit Amount"
        Me.txtPart_QDR_Amount.TabIndex = 1
        Me.txtPart_QDR_Amount.ValidationRegexStatement = "^\d{0,6}(\.\d{2})$"
        '
        'lblPart_QDR_Amount
        '
        Me.lblPart_QDR_Amount.AutoSize = True
        Me.lblPart_QDR_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_QDR_Amount.Location = New System.Drawing.Point(24, 57)
        Me.lblPart_QDR_Amount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_QDR_Amount.Name = "lblPart_QDR_Amount"
        Me.lblPart_QDR_Amount.Size = New System.Drawing.Size(56, 17)
        Me.lblPart_QDR_Amount.TabIndex = 2
        Me.lblPart_QDR_Amount.Text = "Benefit:"
        '
        'txtPart_QDR_Date
        '
        Me.txtPart_QDR_Date.AllowFieldEdit = True
        Me.txtPart_QDR_Date.AllowFieldInsert = True
        Me.txtPart_QDR_Date.AuditField = True
        Me.txtPart_QDR_Date.DatabaseBindFieldName = "Surv_QDR_Date"
        Me.txtPart_QDR_Date.DatabaseTableName = "Survivor"
        Me.txtPart_QDR_Date.DefaultValue = Nothing
        Me.txtPart_QDR_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPart_QDR_Date.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtPart_QDR_Date.Location = New System.Drawing.Point(93, 85)
        Me.txtPart_QDR_Date.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPart_QDR_Date.Mask = "00/00/0000"
        Me.txtPart_QDR_Date.Name = "txtPart_QDR_Date"
        Me.txtPart_QDR_Date.Required = False
        Me.txtPart_QDR_Date.Size = New System.Drawing.Size(132, 23)
        Me.txtPart_QDR_Date.StatusStripInfo = Me.bacStatus
        Me.txtPart_QDR_Date.StatusStripTip = "QDRO Effective Date"
        Me.txtPart_QDR_Date.TabIndex = 3
        Me.txtPart_QDR_Date.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtPart_QDR_Date.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'lblPart_QDR_Date
        '
        Me.lblPart_QDR_Date.AutoSize = True
        Me.lblPart_QDR_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_QDR_Date.Location = New System.Drawing.Point(24, 89)
        Me.lblPart_QDR_Date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_QDR_Date.Name = "lblPart_QDR_Date"
        Me.lblPart_QDR_Date.Size = New System.Drawing.Size(66, 17)
        Me.lblPart_QDR_Date.TabIndex = 4
        Me.lblPart_QDR_Date.Text = "Effective:"
        '
        'gbSurvivor
        '
        Me.gbSurvivor.Controls.Add(Me.gbDates)
        Me.gbSurvivor.Controls.Add(Me.txtPart_Phone)
        Me.gbSurvivor.Controls.Add(Me.lblPart_Phone)
        Me.gbSurvivor.Controls.Add(Me.txtPart_Email)
        Me.gbSurvivor.Controls.Add(Me.lblPart_Email)
        Me.gbSurvivor.Controls.Add(Me.lblPart_FirstName)
        Me.gbSurvivor.Controls.Add(Me.lblPart_RetirementDate)
        Me.gbSurvivor.Controls.Add(Me.lblPart_Gender)
        Me.gbSurvivor.Controls.Add(Me.lblPart_Fund)
        Me.gbSurvivor.Controls.Add(Me.lblPart_Marital_Status)
        Me.gbSurvivor.Controls.Add(Me.txtSurv_SSN)
        Me.gbSurvivor.Controls.Add(Me.gbAddress)
        Me.gbSurvivor.Controls.Add(Me.txtSurv_FirstName)
        Me.gbSurvivor.Controls.Add(Me.txtSurv_LastName)
        Me.gbSurvivor.Controls.Add(Me.txtSurv_MInitial)
        Me.gbSurvivor.Controls.Add(Me.cboPart_Gender)
        Me.gbSurvivor.Controls.Add(Me.cboSurv_Fund)
        Me.gbSurvivor.Controls.Add(Me.cboPart_Marital_Status)
        Me.gbSurvivor.Location = New System.Drawing.Point(16, 97)
        Me.gbSurvivor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSurvivor.Name = "gbSurvivor"
        Me.gbSurvivor.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSurvivor.Size = New System.Drawing.Size(1147, 332)
        Me.gbSurvivor.TabIndex = 1
        Me.gbSurvivor.TabStop = False
        Me.gbSurvivor.Text = "Survivor"
        '
        'gbDates
        '
        Me.gbDates.Controls.Add(Me.lblPart_DOB)
        Me.gbDates.Controls.Add(Me.lblPart_DOB12)
        Me.gbDates.Controls.Add(Me.txtPart_DOD)
        Me.gbDates.Controls.Add(Me.txtPart_DOB)
        Me.gbDates.Location = New System.Drawing.Point(595, 139)
        Me.gbDates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDates.Name = "gbDates"
        Me.gbDates.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDates.Size = New System.Drawing.Size(231, 164)
        Me.gbDates.TabIndex = 87
        Me.gbDates.TabStop = False
        Me.gbDates.Text = "Dates"
        '
        'lblPart_DOB
        '
        Me.lblPart_DOB.AutoSize = True
        Me.lblPart_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_DOB.Location = New System.Drawing.Point(8, 27)
        Me.lblPart_DOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_DOB.Name = "lblPart_DOB"
        Me.lblPart_DOB.Size = New System.Drawing.Size(75, 17)
        Me.lblPart_DOB.TabIndex = 40
        Me.lblPart_DOB.Text = "Birth Date:"
        '
        'lblPart_DOB12
        '
        Me.lblPart_DOB12.AutoSize = True
        Me.lblPart_DOB12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_DOB12.Location = New System.Drawing.Point(8, 60)
        Me.lblPart_DOB12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_DOB12.Name = "lblPart_DOB12"
        Me.lblPart_DOB12.Size = New System.Drawing.Size(84, 17)
        Me.lblPart_DOB12.TabIndex = 41
        Me.lblPart_DOB12.Text = "Death Date:"
        '
        'txtPart_DOD
        '
        Me.txtPart_DOD.AllowFieldEdit = True
        Me.txtPart_DOD.AllowFieldInsert = True
        Me.txtPart_DOD.AuditField = True
        Me.txtPart_DOD.DatabaseBindFieldName = "Surv_DOD"
        Me.txtPart_DOD.DatabaseTableName = "Survivor"
        Me.txtPart_DOD.DefaultValue = Nothing
        Me.txtPart_DOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPart_DOD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtPart_DOD.Location = New System.Drawing.Point(101, 55)
        Me.txtPart_DOD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPart_DOD.Mask = "00/00/0000"
        Me.txtPart_DOD.Name = "txtPart_DOD"
        Me.txtPart_DOD.Required = False
        Me.txtPart_DOD.Size = New System.Drawing.Size(100, 23)
        Me.txtPart_DOD.StatusStripInfo = Me.bacStatus
        Me.txtPart_DOD.StatusStripTip = "Date of Death"
        Me.txtPart_DOD.TabIndex = 42
        Me.txtPart_DOD.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtPart_DOD.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'txtPart_DOB
        '
        Me.txtPart_DOB.AllowFieldEdit = True
        Me.txtPart_DOB.AllowFieldInsert = True
        Me.txtPart_DOB.AuditField = True
        Me.txtPart_DOB.DatabaseBindFieldName = "Surv_DOB"
        Me.txtPart_DOB.DatabaseTableName = "Survivor"
        Me.txtPart_DOB.DefaultValue = Nothing
        Me.txtPart_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPart_DOB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtPart_DOB.Location = New System.Drawing.Point(103, 23)
        Me.txtPart_DOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPart_DOB.Mask = "00/00/0000"
        Me.txtPart_DOB.Name = "txtPart_DOB"
        Me.txtPart_DOB.Required = False
        Me.txtPart_DOB.Size = New System.Drawing.Size(99, 23)
        Me.txtPart_DOB.StatusStripInfo = Me.bacStatus
        Me.txtPart_DOB.StatusStripTip = "Participant Date of Birth"
        Me.txtPart_DOB.TabIndex = 43
        Me.txtPart_DOB.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtPart_DOB.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacShortDate)
        '
        'txtPart_Phone
        '
        Me.txtPart_Phone.AllowFieldEdit = True
        Me.txtPart_Phone.AllowFieldInsert = True
        Me.txtPart_Phone.AuditField = True
        Me.txtPart_Phone.BackColor = System.Drawing.Color.Yellow
        Me.txtPart_Phone.DatabaseBindFieldName = "Surv_Phone"
        Me.txtPart_Phone.DatabaseTableName = "Survivor"
        Me.txtPart_Phone.DefaultValue = Nothing
        Me.txtPart_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPart_Phone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtPart_Phone.Location = New System.Drawing.Point(75, 86)
        Me.txtPart_Phone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPart_Phone.Mask = "000-000-0000"
        Me.txtPart_Phone.Name = "txtPart_Phone"
        Me.txtPart_Phone.Required = False
        Me.txtPart_Phone.Size = New System.Drawing.Size(117, 23)
        Me.txtPart_Phone.StatusStripInfo = Me.bacStatus
        Me.txtPart_Phone.StatusStripTip = "Participant Phone Number"
        Me.txtPart_Phone.TabIndex = 86
        Me.txtPart_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtPart_Phone.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacPhoneMask)
        '
        'lblPart_Phone
        '
        Me.lblPart_Phone.AutoSize = True
        Me.lblPart_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_Phone.Location = New System.Drawing.Point(13, 90)
        Me.lblPart_Phone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Phone.Name = "lblPart_Phone"
        Me.lblPart_Phone.Size = New System.Drawing.Size(53, 17)
        Me.lblPart_Phone.TabIndex = 83
        Me.lblPart_Phone.Text = "Phone:"
        '
        'txtPart_Email
        '
        Me.txtPart_Email.AllowFieldEdit = True
        Me.txtPart_Email.AllowFieldInsert = True
        Me.txtPart_Email.AuditField = True
        Me.txtPart_Email.DatabaseBindFieldName = "Surv_Email"
        Me.txtPart_Email.DatabaseTableName = "Survivor"
        Me.txtPart_Email.DefaultValue = Nothing
        Me.txtPart_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPart_Email.Format = ""
        Me.txtPart_Email.Location = New System.Drawing.Point(256, 91)
        Me.txtPart_Email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.lblPart_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_Email.Location = New System.Drawing.Point(200, 95)
        Me.lblPart_Email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Email.Name = "lblPart_Email"
        Me.lblPart_Email.Size = New System.Drawing.Size(46, 17)
        Me.lblPart_Email.TabIndex = 85
        Me.lblPart_Email.Text = "Email:"
        '
        'lblPart_FirstName
        '
        Me.lblPart_FirstName.AutoSize = True
        Me.lblPart_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_FirstName.Location = New System.Drawing.Point(15, 27)
        Me.lblPart_FirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_FirstName.Name = "lblPart_FirstName"
        Me.lblPart_FirstName.Size = New System.Drawing.Size(49, 17)
        Me.lblPart_FirstName.TabIndex = 78
        Me.lblPart_FirstName.Text = "Name:"
        '
        'lblPart_RetirementDate
        '
        Me.lblPart_RetirementDate.AutoSize = True
        Me.lblPart_RetirementDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_RetirementDate.Location = New System.Drawing.Point(15, 59)
        Me.lblPart_RetirementDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_RetirementDate.Name = "lblPart_RetirementDate"
        Me.lblPart_RetirementDate.Size = New System.Drawing.Size(40, 17)
        Me.lblPart_RetirementDate.TabIndex = 74
        Me.lblPart_RetirementDate.Text = "SSN:"
        '
        'lblPart_Gender
        '
        Me.lblPart_Gender.AutoSize = True
        Me.lblPart_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_Gender.Location = New System.Drawing.Point(429, 59)
        Me.lblPart_Gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Gender.Name = "lblPart_Gender"
        Me.lblPart_Gender.Size = New System.Drawing.Size(60, 17)
        Me.lblPart_Gender.TabIndex = 73
        Me.lblPart_Gender.Text = "Gender:"
        '
        'lblPart_Fund
        '
        Me.lblPart_Fund.AutoSize = True
        Me.lblPart_Fund.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_Fund.Location = New System.Drawing.Point(200, 58)
        Me.lblPart_Fund.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Fund.Name = "lblPart_Fund"
        Me.lblPart_Fund.Size = New System.Drawing.Size(44, 17)
        Me.lblPart_Fund.TabIndex = 76
        Me.lblPart_Fund.Text = "Fund:"
        '
        'lblPart_Marital_Status
        '
        Me.lblPart_Marital_Status.AutoSize = True
        Me.lblPart_Marital_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_Marital_Status.Location = New System.Drawing.Point(309, 59)
        Me.lblPart_Marital_Status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_Marital_Status.Name = "lblPart_Marital_Status"
        Me.lblPart_Marital_Status.Size = New System.Drawing.Size(60, 17)
        Me.lblPart_Marital_Status.TabIndex = 81
        Me.lblPart_Marital_Status.Text = "Spouse:"
        '
        'txtSurv_SSN
        '
        Me.txtSurv_SSN.AllowFieldEdit = True
        Me.txtSurv_SSN.AllowFieldInsert = True
        Me.txtSurv_SSN.AuditField = True
        Me.txtSurv_SSN.BackColor = System.Drawing.Color.Yellow
        Me.txtSurv_SSN.DatabaseBindFieldName = "Surv_SSN"
        Me.txtSurv_SSN.DatabaseTableName = "Survivor"
        Me.txtSurv_SSN.DefaultValue = "999999999"
        Me.txtSurv_SSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSurv_SSN.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtSurv_SSN.Location = New System.Drawing.Point(75, 54)
        Me.txtSurv_SSN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSurv_SSN.Mask = "000-00-0000"
        Me.txtSurv_SSN.Name = "txtSurv_SSN"
        Me.txtSurv_SSN.Required = True
        Me.txtSurv_SSN.Size = New System.Drawing.Size(119, 23)
        Me.txtSurv_SSN.StatusStripInfo = Me.bacStatus
        Me.txtSurv_SSN.StatusStripTip = "Survivor SSN"
        Me.txtSurv_SSN.TabIndex = 82
        Me.txtSurv_SSN.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtSurv_SSN.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacSsnMask)
        '
        'gbAddress
        '
        Me.gbAddress.Controls.Add(Me.lblAddressStreet)
        Me.gbAddress.Controls.Add(Me.txt_Address1)
        Me.gbAddress.Controls.Add(Me.txt_Address2)
        Me.gbAddress.Controls.Add(Me.txt_City)
        Me.gbAddress.Controls.Add(Me.lblPAdr_City)
        Me.gbAddress.Controls.Add(Me.Check_Undeliverable)
        Me.gbAddress.Controls.Add(Me.cbo_State)
        Me.gbAddress.Controls.Add(Me.txt_CountryName)
        Me.gbAddress.Controls.Add(Me.txt_UndeliverableDate)
        Me.gbAddress.Controls.Add(Me.txt_Country_Code)
        Me.gbAddress.Controls.Add(Me.txt_ZipCode)
        Me.gbAddress.Location = New System.Drawing.Point(8, 139)
        Me.gbAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbAddress.Name = "gbAddress"
        Me.gbAddress.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbAddress.Size = New System.Drawing.Size(579, 164)
        Me.gbAddress.TabIndex = 64
        Me.gbAddress.TabStop = False
        Me.gbAddress.Text = "Address"
        '
        'lblAddressStreet
        '
        Me.lblAddressStreet.AutoSize = True
        Me.lblAddressStreet.Location = New System.Drawing.Point(7, 23)
        Me.lblAddressStreet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddressStreet.Name = "lblAddressStreet"
        Me.lblAddressStreet.Size = New System.Drawing.Size(50, 17)
        Me.lblAddressStreet.TabIndex = 35
        Me.lblAddressStreet.Text = "Street:"
        '
        'txt_Address1
        '
        Me.txt_Address1.AllowFieldEdit = True
        Me.txt_Address1.AllowFieldInsert = True
        Me.txt_Address1.AuditField = True
        Me.txt_Address1.DatabaseBindFieldName = "Surv_Address1"
        Me.txt_Address1.DatabaseTableName = "Survivor"
        Me.txt_Address1.DefaultValue = "123 Elm Str"
        Me.txt_Address1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_Address1.Location = New System.Drawing.Point(67, 18)
        Me.txt_Address1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Address1.MaxLength = 30
        Me.txt_Address1.Name = "txt_Address1"
        Me.txt_Address1.Required = False
        Me.txt_Address1.Size = New System.Drawing.Size(473, 23)
        Me.txt_Address1.StatusStripInfo = Me.bacStatus
        Me.txt_Address1.StatusStripTip = "Address Field (1)"
        Me.txt_Address1.TabIndex = 32
        '
        'txt_Address2
        '
        Me.txt_Address2.AllowFieldEdit = True
        Me.txt_Address2.AllowFieldInsert = True
        Me.txt_Address2.AuditField = True
        Me.txt_Address2.DatabaseBindFieldName = "Surv_Address2"
        Me.txt_Address2.DatabaseTableName = "Survivor"
        Me.txt_Address2.DefaultValue = Nothing
        Me.txt_Address2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_Address2.Location = New System.Drawing.Point(67, 55)
        Me.txt_Address2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Address2.MaxLength = 30
        Me.txt_Address2.Name = "txt_Address2"
        Me.txt_Address2.Required = False
        Me.txt_Address2.Size = New System.Drawing.Size(473, 23)
        Me.txt_Address2.StatusStripInfo = Me.bacStatus
        Me.txt_Address2.StatusStripTip = "Address Field (2)"
        Me.txt_Address2.TabIndex = 33
        '
        'txt_City
        '
        Me.txt_City.AllowFieldEdit = True
        Me.txt_City.AllowFieldInsert = True
        Me.txt_City.AuditField = True
        Me.txt_City.DatabaseBindFieldName = "Surv_City"
        Me.txt_City.DatabaseTableName = "Survivor"
        Me.txt_City.DefaultValue = Nothing
        Me.txt_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_City.Location = New System.Drawing.Point(67, 87)
        Me.txt_City.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_City.MaxLength = 20
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Required = True
        Me.txt_City.Size = New System.Drawing.Size(219, 23)
        Me.txt_City.StatusStripInfo = Me.bacStatus
        Me.txt_City.StatusStripTip = "City Name"
        Me.txt_City.TabIndex = 36
        '
        'lblPAdr_City
        '
        Me.lblPAdr_City.AutoSize = True
        Me.lblPAdr_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPAdr_City.Location = New System.Drawing.Point(9, 91)
        Me.lblPAdr_City.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPAdr_City.Name = "lblPAdr_City"
        Me.lblPAdr_City.Size = New System.Drawing.Size(39, 17)
        Me.lblPAdr_City.TabIndex = 37
        Me.lblPAdr_City.Text = "CSZ:"
        '
        'Check_Undeliverable
        '
        Me.Check_Undeliverable.AllowFieldEdit = True
        Me.Check_Undeliverable.AllowFieldInsert = True
        Me.Check_Undeliverable.AuditField = True
        Me.Check_Undeliverable.DatabaseBindFieldName = "Surv_Undeliverable"
        Me.Check_Undeliverable.DatabaseTableName = "Survivor"
        Me.Check_Undeliverable.DefaultValue = False
        Me.Check_Undeliverable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Check_Undeliverable.Location = New System.Drawing.Point(244, 121)
        Me.Check_Undeliverable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Check_Undeliverable.Name = "Check_Undeliverable"
        Me.Check_Undeliverable.Required = True
        Me.Check_Undeliverable.Size = New System.Drawing.Size(121, 30)
        Me.Check_Undeliverable.StatusStripInfo = Me.bacStatus
        Me.Check_Undeliverable.StatusStripTip = "Address good or bad"
        Me.Check_Undeliverable.TabIndex = 49
        Me.Check_Undeliverable.Text = "Undeliverable"
        '
        'cbo_State
        '
        Me.cbo_State.AllowFieldEdit = True
        Me.cbo_State.AllowFieldInsert = True
        Me.cbo_State.AuditField = True
        Me.cbo_State.CodesTypeId = "-1"
        Me.cbo_State.DatabaseBindFieldName = "Surv_State_Code"
        Me.cbo_State.DatabaseTableName = "Survivor"
        Me.cbo_State.DefaultValue = Nothing
        Me.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_State.DropDownWidth = 140
        Me.cbo_State.EscapeAction = BAC.Controls.BacEditForm.EflFormControls.BacEflComboEscapeIndex.OriginalIndex
        Me.cbo_State.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbo_State.IndexOnEscape = -1
        Me.cbo_State.Location = New System.Drawing.Point(301, 87)
        Me.cbo_State.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_State.Name = "cbo_State"
        Me.cbo_State.Required = False
        Me.cbo_State.SelectedValueType = BAC.Controls.BacEditForm.EflFormControls.BacComboSetSelectedValueType.ObjectItem
        Me.cbo_State.ShowBlankLine = False
        Me.cbo_State.Size = New System.Drawing.Size(61, 25)
        Me.cbo_State.StatusStripInfo = Me.bacStatus
        Me.cbo_State.StatusStripTip = "State or Province"
        Me.cbo_State.TabIndex = 41
        '
        'txt_CountryName
        '
        Me.txt_CountryName.AllowSecondaryUpdate = False
        Me.txt_CountryName.DatabaseBindFieldName = "Surv_Country"
        Me.txt_CountryName.DatabaseTableName = "Survivor"
        Me.txt_CountryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_CountryName.Format = ""
        Me.txt_CountryName.Location = New System.Drawing.Point(67, 118)
        Me.txt_CountryName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_CountryName.Name = "txt_CountryName"
        Me.txt_CountryName.ReadOnly = True
        Me.txt_CountryName.Size = New System.Drawing.Size(153, 23)
        Me.txt_CountryName.StatusStripInfo = Me.bacStatus
        Me.txt_CountryName.StatusStripTip = "Country Name (for mailings)"
        Me.txt_CountryName.TabIndex = 42
        '
        'txt_UndeliverableDate
        '
        Me.txt_UndeliverableDate.AllowSecondaryUpdate = True
        Me.txt_UndeliverableDate.DatabaseBindFieldName = "Surv_UndeliverableDate"
        Me.txt_UndeliverableDate.DatabaseTableName = "Survivor"
        Me.txt_UndeliverableDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_UndeliverableDate.Location = New System.Drawing.Point(376, 119)
        Me.txt_UndeliverableDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_UndeliverableDate.Name = "txt_UndeliverableDate"
        Me.txt_UndeliverableDate.ReadOnly = True
        Me.txt_UndeliverableDate.Size = New System.Drawing.Size(164, 23)
        Me.txt_UndeliverableDate.StatusStripInfo = Me.bacStatus
        Me.txt_UndeliverableDate.StatusStripTip = "Date Registered as Undeliverable"
        Me.txt_UndeliverableDate.TabIndex = 50
        Me.txt_UndeliverableDate.Value = Nothing
        '
        'txt_Country_Code
        '
        Me.txt_Country_Code.AcceptsReturn = True
        Me.txt_Country_Code.AllowFieldEdit = True
        Me.txt_Country_Code.AllowFieldInsert = True
        Me.txt_Country_Code.AuditField = True
        Me.txt_Country_Code.DatabaseBindFieldName = "Surv_Country_Code"
        Me.txt_Country_Code.DatabaseTableName = "Survivor"
        Me.txt_Country_Code.DefaultValue = Nothing
        Me.txt_Country_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_Country_Code.Location = New System.Drawing.Point(25, 118)
        Me.txt_Country_Code.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Country_Code.Name = "txt_Country_Code"
        Me.txt_Country_Code.Required = True
        Me.txt_Country_Code.Size = New System.Drawing.Size(28, 23)
        Me.txt_Country_Code.StatusStripInfo = Me.bacStatus
        Me.txt_Country_Code.StatusStripTip = ""
        Me.txt_Country_Code.TabIndex = 52
        Me.txt_Country_Code.Visible = False
        '
        'txt_ZipCode
        '
        Me.txt_ZipCode.AllowFieldEdit = True
        Me.txt_ZipCode.AllowFieldInsert = True
        Me.txt_ZipCode.AuditField = True
        Me.txt_ZipCode.DatabaseBindFieldName = "Surv_Zip_Code"
        Me.txt_ZipCode.DatabaseTableName = "Survivor"
        Me.txt_ZipCode.DefaultValue = "20111"
        Me.txt_ZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_ZipCode.Format = ""
        Me.txt_ZipCode.Location = New System.Drawing.Point(376, 87)
        Me.txt_ZipCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ZipCode.Name = "txt_ZipCode"
        Me.txt_ZipCode.RegularExpressionValueType = BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox.RegularExpressionReturnType.TextValue
        Me.txt_ZipCode.Required = False
        Me.txt_ZipCode.Size = New System.Drawing.Size(164, 23)
        Me.txt_ZipCode.StatusStripInfo = Me.bacStatus
        Me.txt_ZipCode.StatusStripTip = "Zip/Postal Code"
        Me.txt_ZipCode.TabIndex = 53
        Me.txt_ZipCode.ValidationRegexStatement = "(^\d{5}(-\d{4})?$)|(^[abceghjklmnprstvxyABCEGHJKLMNPRSTVXY]{1}\d{1}[a-zA-Z]{1} *\" &
    "d{1}[a-zA-Z]{1}\d{1})"
        '
        'txtSurv_FirstName
        '
        Me.txtSurv_FirstName.AllowFieldEdit = True
        Me.txtSurv_FirstName.AllowFieldInsert = True
        Me.txtSurv_FirstName.AuditField = True
        Me.txtSurv_FirstName.DatabaseBindFieldName = "Surv_FirstName"
        Me.txtSurv_FirstName.DatabaseTableName = "Survivor"
        Me.txtSurv_FirstName.DefaultValue = Nothing
        Me.txtSurv_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSurv_FirstName.Location = New System.Drawing.Point(75, 23)
        Me.txtSurv_FirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSurv_FirstName.MaxLength = 20
        Me.txtSurv_FirstName.Name = "txtSurv_FirstName"
        Me.txtSurv_FirstName.Required = True
        Me.txtSurv_FirstName.Size = New System.Drawing.Size(172, 23)
        Me.txtSurv_FirstName.StatusStripInfo = Me.bacStatus
        Me.txtSurv_FirstName.StatusStripTip = "Enter First Name of Survivor"
        Me.txtSurv_FirstName.TabIndex = 77
        '
        'txtSurv_LastName
        '
        Me.txtSurv_LastName.AllowFieldEdit = True
        Me.txtSurv_LastName.AllowFieldInsert = True
        Me.txtSurv_LastName.AuditField = True
        Me.txtSurv_LastName.DatabaseBindFieldName = "Surv_LastName"
        Me.txtSurv_LastName.DatabaseTableName = "Survivor"
        Me.txtSurv_LastName.DefaultValue = Nothing
        Me.txtSurv_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSurv_LastName.Location = New System.Drawing.Point(304, 23)
        Me.txtSurv_LastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSurv_LastName.MaxLength = 40
        Me.txtSurv_LastName.Name = "txtSurv_LastName"
        Me.txtSurv_LastName.Required = True
        Me.txtSurv_LastName.Size = New System.Drawing.Size(243, 23)
        Me.txtSurv_LastName.StatusStripInfo = Me.bacStatus
        Me.txtSurv_LastName.StatusStripTip = "Last Name of Survivor"
        Me.txtSurv_LastName.TabIndex = 71
        '
        'txtSurv_MInitial
        '
        Me.txtSurv_MInitial.AllowFieldEdit = True
        Me.txtSurv_MInitial.AllowFieldInsert = True
        Me.txtSurv_MInitial.AuditField = True
        Me.txtSurv_MInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSurv_MInitial.DatabaseBindFieldName = "Surv_MInitial"
        Me.txtSurv_MInitial.DatabaseTableName = "Survivor"
        Me.txtSurv_MInitial.DefaultValue = Nothing
        Me.txtSurv_MInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSurv_MInitial.Location = New System.Drawing.Point(256, 23)
        Me.txtSurv_MInitial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSurv_MInitial.MaxLength = 1
        Me.txtSurv_MInitial.Name = "txtSurv_MInitial"
        Me.txtSurv_MInitial.Required = False
        Me.txtSurv_MInitial.Size = New System.Drawing.Size(37, 23)
        Me.txtSurv_MInitial.StatusStripInfo = Me.bacStatus
        Me.txtSurv_MInitial.StatusStripTip = "Survivor's Middlle Initial (1 character)"
        Me.txtSurv_MInitial.TabIndex = 79
        '
        'cboPart_Gender
        '
        Me.cboPart_Gender.AllowFieldEdit = True
        Me.cboPart_Gender.AllowFieldInsert = True
        Me.cboPart_Gender.AuditField = True
        Me.cboPart_Gender.CodesTypeId = "9"
        Me.cboPart_Gender.DatabaseBindFieldName = "Surv_Gender"
        Me.cboPart_Gender.DatabaseTableName = "Survivor"
        Me.cboPart_Gender.DefaultValue = ""
        Me.cboPart_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPart_Gender.DropDownWidth = 120
        Me.cboPart_Gender.EscapeAction = BAC.Controls.BacEditForm.EflFormControls.BacEflComboEscapeIndex.OriginalIndex
        Me.cboPart_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboPart_Gender.IndexOnEscape = -1
        Me.cboPart_Gender.Location = New System.Drawing.Point(500, 54)
        Me.cboPart_Gender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPart_Gender.Name = "cboPart_Gender"
        Me.cboPart_Gender.Required = False
        Me.cboPart_Gender.SelectedValueType = BAC.Controls.BacEditForm.EflFormControls.BacComboSetSelectedValueType.KeyValueItem
        Me.cboPart_Gender.ShowBlankLine = False
        Me.cboPart_Gender.Size = New System.Drawing.Size(48, 25)
        Me.cboPart_Gender.StatusStripInfo = Me.bacStatus
        Me.cboPart_Gender.StatusStripTip = "Participant Gender"
        Me.cboPart_Gender.TabIndex = 72
        '
        'cboSurv_Fund
        '
        Me.cboSurv_Fund.AllowFieldEdit = True
        Me.cboSurv_Fund.AllowFieldInsert = True
        Me.cboSurv_Fund.AuditField = True
        Me.cboSurv_Fund.CodesTypeId = "3"
        Me.cboSurv_Fund.DatabaseBindFieldName = "Surv_Fund"
        Me.cboSurv_Fund.DatabaseTableName = "Survivor"
        Me.cboSurv_Fund.DefaultValue = ""
        Me.cboSurv_Fund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSurv_Fund.DropDownWidth = 120
        Me.cboSurv_Fund.EscapeAction = BAC.Controls.BacEditForm.EflFormControls.BacEflComboEscapeIndex.OriginalIndex
        Me.cboSurv_Fund.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboSurv_Fund.IndexOnEscape = -1
        Me.cboSurv_Fund.Location = New System.Drawing.Point(256, 54)
        Me.cboSurv_Fund.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSurv_Fund.Name = "cboSurv_Fund"
        Me.cboSurv_Fund.Required = False
        Me.cboSurv_Fund.SelectedValueType = BAC.Controls.BacEditForm.EflFormControls.BacComboSetSelectedValueType.KeyValueItem
        Me.cboSurv_Fund.ShowBlankLine = False
        Me.cboSurv_Fund.Size = New System.Drawing.Size(49, 25)
        Me.cboSurv_Fund.StatusStripInfo = Me.bacStatus
        Me.cboSurv_Fund.StatusStripTip = "Fund"
        Me.cboSurv_Fund.TabIndex = 75
        '
        'cboPart_Marital_Status
        '
        Me.cboPart_Marital_Status.AllowFieldEdit = True
        Me.cboPart_Marital_Status.AllowFieldInsert = True
        Me.cboPart_Marital_Status.AuditField = False
        Me.cboPart_Marital_Status.CodesTypeId = "10"
        Me.cboPart_Marital_Status.DatabaseBindFieldName = "Surv_Spouse_Flag"
        Me.cboPart_Marital_Status.DatabaseTableName = "Survivor"
        Me.cboPart_Marital_Status.DefaultValue = Nothing
        Me.cboPart_Marital_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPart_Marital_Status.DropDownWidth = 120
        Me.cboPart_Marital_Status.EscapeAction = BAC.Controls.BacEditForm.EflFormControls.BacEflComboEscapeIndex.OriginalIndex
        Me.cboPart_Marital_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboPart_Marital_Status.IndexOnEscape = -1
        Me.cboPart_Marital_Status.Location = New System.Drawing.Point(376, 54)
        Me.cboPart_Marital_Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPart_Marital_Status.Name = "cboPart_Marital_Status"
        Me.cboPart_Marital_Status.Required = False
        Me.cboPart_Marital_Status.SelectedValueType = BAC.Controls.BacEditForm.EflFormControls.BacComboSetSelectedValueType.KeyValueItem
        Me.cboPart_Marital_Status.ShowBlankLine = False
        Me.cboPart_Marital_Status.Size = New System.Drawing.Size(48, 25)
        Me.cboPart_Marital_Status.StatusStripInfo = Me.bacStatus
        Me.cboPart_Marital_Status.StatusStripTip = "Survivor Marriage Status"
        Me.cboPart_Marital_Status.TabIndex = 80
        '
        'gbParticipant
        '
        Me.gbParticipant.Controls.Add(Me.Label1)
        Me.gbParticipant.Controls.Add(Me.BacEflMaskedTextBox1)
        Me.gbParticipant.Controls.Add(Me.txtPart_FirstName)
        Me.gbParticipant.Controls.Add(Me.lblPart_FirstName1)
        Me.gbParticipant.Controls.Add(Me.BacEflReadOnlyTextBox1)
        Me.gbParticipant.Controls.Add(Me.BacEflReadOnlyTextBox2)
        Me.gbParticipant.Location = New System.Drawing.Point(16, 16)
        Me.gbParticipant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbParticipant.Name = "gbParticipant"
        Me.gbParticipant.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbParticipant.Size = New System.Drawing.Size(1147, 74)
        Me.gbParticipant.TabIndex = 0
        Me.gbParticipant.TabStop = False
        Me.gbParticipant.Text = "Participant"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "SSN:"
        '
        'BacEflMaskedTextBox1
        '
        Me.BacEflMaskedTextBox1.AllowFieldEdit = False
        Me.BacEflMaskedTextBox1.AllowFieldInsert = False
        Me.BacEflMaskedTextBox1.AuditField = False
        Me.BacEflMaskedTextBox1.BackColor = System.Drawing.Color.Yellow
        Me.BacEflMaskedTextBox1.DatabaseBindFieldName = "ParticipantSSN"
        Me.BacEflMaskedTextBox1.DatabaseTableName = "Participant"
        Me.BacEflMaskedTextBox1.DefaultValue = "999999999"
        Me.BacEflMaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.BacEflMaskedTextBox1.Location = New System.Drawing.Point(75, 23)
        Me.BacEflMaskedTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflMaskedTextBox1.Mask = "000-00-0000"
        Me.BacEflMaskedTextBox1.Name = "BacEflMaskedTextBox1"
        Me.BacEflMaskedTextBox1.Required = False
        Me.BacEflMaskedTextBox1.Size = New System.Drawing.Size(119, 23)
        Me.BacEflMaskedTextBox1.StatusStripInfo = Me.bacStatus
        Me.BacEflMaskedTextBox1.StatusStripTip = "Participant SSN"
        Me.BacEflMaskedTextBox1.TabIndex = 84
        Me.BacEflMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.BacEflMaskedTextBox1.ValidatingType = GetType(BAC.Controls.BacEditForm.BacMaskDescriptors.BacSsnMask)
        '
        'txtPart_FirstName
        '
        Me.txtPart_FirstName.AllowSecondaryUpdate = False
        Me.txtPart_FirstName.DatabaseBindFieldName = "Part_FirstName"
        Me.txtPart_FirstName.DatabaseTableName = "Participant"
        Me.txtPart_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPart_FirstName.Format = ""
        Me.txtPart_FirstName.Location = New System.Drawing.Point(369, 23)
        Me.txtPart_FirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPart_FirstName.Name = "txtPart_FirstName"
        Me.txtPart_FirstName.ReadOnly = True
        Me.txtPart_FirstName.Size = New System.Drawing.Size(189, 23)
        Me.txtPart_FirstName.StatusStripInfo = Me.bacStatus
        Me.txtPart_FirstName.StatusStripTip = "First name of Participant"
        Me.txtPart_FirstName.TabIndex = 85
        '
        'lblPart_FirstName1
        '
        Me.lblPart_FirstName1.AutoSize = True
        Me.lblPart_FirstName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPart_FirstName1.Location = New System.Drawing.Point(311, 27)
        Me.lblPart_FirstName1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPart_FirstName1.Name = "lblPart_FirstName1"
        Me.lblPart_FirstName1.Size = New System.Drawing.Size(49, 17)
        Me.lblPart_FirstName1.TabIndex = 86
        Me.lblPart_FirstName1.Text = "Name:"
        '
        'BacEflReadOnlyTextBox1
        '
        Me.BacEflReadOnlyTextBox1.AllowSecondaryUpdate = False
        Me.BacEflReadOnlyTextBox1.DatabaseBindFieldName = "Part_MInitial"
        Me.BacEflReadOnlyTextBox1.DatabaseTableName = "Participant"
        Me.BacEflReadOnlyTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflReadOnlyTextBox1.Format = ""
        Me.BacEflReadOnlyTextBox1.Location = New System.Drawing.Point(568, 23)
        Me.BacEflReadOnlyTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflReadOnlyTextBox1.Name = "BacEflReadOnlyTextBox1"
        Me.BacEflReadOnlyTextBox1.ReadOnly = True
        Me.BacEflReadOnlyTextBox1.Size = New System.Drawing.Size(41, 23)
        Me.BacEflReadOnlyTextBox1.StatusStripInfo = Me.bacStatus
        Me.BacEflReadOnlyTextBox1.StatusStripTip = "Middle Name of Participant"
        Me.BacEflReadOnlyTextBox1.TabIndex = 87
        '
        'BacEflReadOnlyTextBox2
        '
        Me.BacEflReadOnlyTextBox2.AllowSecondaryUpdate = False
        Me.BacEflReadOnlyTextBox2.DatabaseBindFieldName = "Part_LastName"
        Me.BacEflReadOnlyTextBox2.DatabaseTableName = "Participant"
        Me.BacEflReadOnlyTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BacEflReadOnlyTextBox2.Format = ""
        Me.BacEflReadOnlyTextBox2.Location = New System.Drawing.Point(619, 23)
        Me.BacEflReadOnlyTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BacEflReadOnlyTextBox2.Name = "BacEflReadOnlyTextBox2"
        Me.BacEflReadOnlyTextBox2.ReadOnly = True
        Me.BacEflReadOnlyTextBox2.Size = New System.Drawing.Size(205, 23)
        Me.BacEflReadOnlyTextBox2.StatusStripInfo = Me.bacStatus
        Me.BacEflReadOnlyTextBox2.StatusStripTip = "Last Name of Participant"
        Me.BacEflReadOnlyTextBox2.TabIndex = 88
        '
        'FormSurvivorInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 718)
        Me.Controls.Add(Me.bacPanel)
        Me.Controls.Add(Me.bacButtonToolStrip)
        Me.Controls.Add(Me.bacStatusLabel)
        Me.Controls.Add(Me.bacNavMenu)
        Me.Controls.Add(Me.bacStatus)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1194, 765)
        Me.Name = "FormSurvivorInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormSurvivor"
        Me.bacStatus.ResumeLayout(False)
        Me.bacStatus.PerformLayout()
        Me.bacNavMenu.ResumeLayout(False)
        Me.bacNavMenu.PerformLayout()
        Me.bacButtonToolStrip.ResumeLayout(False)
        Me.bacButtonToolStrip.PerformLayout()
        Me.bacPanel.ResumeLayout(False)
        Me.gbBenefit.ResumeLayout(False)
        Me.gbBenefit.PerformLayout()
        Me.gbQdro.ResumeLayout(False)
        Me.gbQdro.PerformLayout()
        Me.gbSurvivor.ResumeLayout(False)
        Me.gbSurvivor.PerformLayout()
        Me.gbDates.ResumeLayout(False)
        Me.gbDates.PerformLayout()
        Me.gbAddress.ResumeLayout(False)
        Me.gbAddress.PerformLayout()
        Me.gbParticipant.ResumeLayout(False)
        Me.gbParticipant.PerformLayout()
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
    Friend WithEvents bacNavButtonsHost As BAC.Controls.BacEditForm.ButtonItems.EflButtonNavigationInnerToolStripControlHost
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
    Friend WithEvents gbBenefit As GroupBox
    Friend WithEvents gbSurvivor As GroupBox
    Friend WithEvents gbParticipant As GroupBox
    Friend WithEvents gbAddress As GroupBox
    Friend WithEvents lblAddressStreet As Label
    Friend WithEvents txt_Address1 As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txt_Address2 As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txt_City As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents lblPAdr_City As Label
    Friend WithEvents Check_Undeliverable As BAC.Controls.BacEditForm.EflFormControls.BacEflCheckBox
    Friend WithEvents cbo_State As BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox
    Friend WithEvents txt_CountryName As BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox
    Friend WithEvents txt_UndeliverableDate As BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyDateBox
    Friend WithEvents txt_Country_Code As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txt_ZipCode As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents lblPart_FirstName As Label
    Friend WithEvents lblPart_RetirementDate As Label
    Friend WithEvents lblPart_Gender As Label
    Friend WithEvents lblPart_Fund As Label
    Friend WithEvents lblPart_Marital_Status As Label
    Friend WithEvents txtSurv_SSN As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents txtSurv_FirstName As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txtSurv_LastName As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents txtSurv_MInitial As BAC.Controls.BacEditForm.EflFormControls.BacEflTextBox
    Friend WithEvents cboPart_Gender As BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox
    Friend WithEvents cboSurv_Fund As BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox
    Friend WithEvents cboPart_Marital_Status As BAC.Controls.BacEditForm.EflFormControls.BacEflComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BacEflMaskedTextBox1 As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents txtPart_FirstName As BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox
    Friend WithEvents lblPart_FirstName1 As Label
    Friend WithEvents BacEflReadOnlyTextBox1 As BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox
    Friend WithEvents BacEflReadOnlyTextBox2 As BAC.Controls.BacEditForm.EflFormControls.BacEflReadOnlyTextBox
    Friend WithEvents lblPart_Phone As Label
    Friend WithEvents txtPart_Email As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents lblPart_Email As Label
    Friend WithEvents txtPart_Phone As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents gbDates As GroupBox
    Friend WithEvents lblPart_DOB As Label
    Friend WithEvents lblPart_DOB12 As Label
    Friend WithEvents txtPart_DOD As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents txtPart_DOB As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents gbQdro As GroupBox
    Friend WithEvents Part_QDR_Flag As BAC.Controls.BacEditForm.EflFormControls.BacEflYesNoCheckBox
    Friend WithEvents txtPart_QDR_Amount As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents lblPart_QDR_Amount As Label
    Friend WithEvents txtPart_QDR_Date As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents lblPart_QDR_Date As Label
    Friend WithEvents BacEflRegexTextBox2 As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BacEflRegexTextBox1 As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BacEflMaskedTextBox4 As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BacEflMaskedTextBox3 As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents BacEflRegexTextBox3 As BAC.Controls.BacEditForm.EflFormControls.BacEflRegexTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BacEflMaskedTextBox6 As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BacEflMaskedTextBox5 As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BacEflMaskedTextBox2 As BAC.Controls.BacEditForm.EflFormControls.BacEflMaskedTextBox
End Class
