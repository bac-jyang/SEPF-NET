<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Dim KeyValueItem5 As BAC.Controls.HelperItems.DialogForms.KeyValueItem = New BAC.Controls.HelperItems.DialogForms.KeyValueItem()
        Dim KeyValueItem6 As BAC.Controls.HelperItems.DialogForms.KeyValueItem = New BAC.Controls.HelperItems.DialogForms.KeyValueItem()
        Dim KeyValueItem7 As BAC.Controls.HelperItems.DialogForms.KeyValueItem = New BAC.Controls.HelperItems.DialogForms.KeyValueItem()
        Dim KeyValueItem8 As BAC.Controls.HelperItems.DialogForms.KeyValueItem = New BAC.Controls.HelperItems.DialogForms.KeyValueItem()
        Me.BacCboStatus = New BAC.Controls.bacExtraCombo()
        Me.bvtName = New BAC.Controls.bacValidateTextBox()
        Me.BacdtbDOB = New BAC.Controls.bacDateTimePickerMask()
        Me.SuspendLayout()
        '
        'BacCboStatus
        '
        Me.BacCboStatus.AllowEntryOnAdd = True
        Me.BacCboStatus.AllowEntryOnEdit = True
        Me.BacCboStatus.DatabaseFieldName = "participant_Status"
        Me.BacCboStatus.DatabaseTableName = "tbl_participant_info"
        Me.BacCboStatus.DefaultBackColorAllowEdit = System.Drawing.SystemColors.ControlLightLight
        Me.BacCboStatus.DefaultBackColorNoEdit = System.Drawing.SystemColors.Control
        Me.BacCboStatus.DefaultValue = ""
        Me.BacCboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BacCboStatus.EscapeAction = BAC.Controls.ExtraComboEnums.BacComboEscapeIndex.OriginalIndex
        Me.BacCboStatus.FormattingEnabled = True
        Me.BacCboStatus.HowOpened = BAC.Controls.BACenums.FormEnums.FormOpenStyle.Unknown
        Me.BacCboStatus.IndexOnEscape = -1
        KeyValueItem5.Key = "A"
        KeyValueItem5.Value = "A - Active"
        KeyValueItem6.Key = "I"
        KeyValueItem6.Value = "I - Inactive"
        KeyValueItem7.Key = "P"
        KeyValueItem7.Value = "P -Pensioner"
        Me.BacCboStatus.KeyValueItemsList.Add(KeyValueItem5)
        Me.BacCboStatus.KeyValueItemsList.Add(KeyValueItem6)
        Me.BacCboStatus.KeyValueItemsList.Add(KeyValueItem7)
        Me.BacCboStatus.KeyValueItemsList.Add(KeyValueItem8)
        Me.BacCboStatus.Location = New System.Drawing.Point(76, 122)
        Me.BacCboStatus.Name = "BacCboStatus"
        Me.BacCboStatus.SelectedValueType = BAC.Controls.ExtraComboEnums.BacComboSetSelectedValueType.KeyValueItem
        Me.BacCboStatus.ShowBlankLine = False
        Me.BacCboStatus.Size = New System.Drawing.Size(121, 24)
        Me.BacCboStatus.SqlStrings.CommandType = BAC.Controls.HelperItems.DialogForms.ClassSpPropertyStatements.SpCommandType.None
        Me.BacCboStatus.SqlStrings.ParmArray = New Object(-1) {}
        Me.BacCboStatus.SqlStrings.SqlDatabaseName = ""
        Me.BacCboStatus.SqlStrings.SqlSelectStatement = ""
        Me.BacCboStatus.SqlStrings.SqlServerName = ""
        Me.BacCboStatus.SqlStrings.StoredProcedureName = ""
        Me.BacCboStatus.TabIndex = 1
        '
        'bvtName
        '
        Me.bvtName.AcceptsTab = True
        Me.bvtName.AllowEntryOnAdd = True
        Me.bvtName.AllowEntryOnEdit = True
        Me.bvtName.DatabaseFieldName = "participant_SSN"
        Me.bvtName.DatabaseTableName = "tbl_participant_info"
        Me.bvtName.DefaultBackColorAllowEdit = System.Drawing.SystemColors.ControlLightLight
        Me.bvtName.DefaultBackColorNoEdit = System.Drawing.SystemColors.Control
        Me.bvtName.DefaultValue = ""
        Me.bvtName.Location = New System.Drawing.Point(76, 52)
        Me.bvtName.Name = "bvtName"
        Me.bvtName.Size = New System.Drawing.Size(100, 22)
        Me.bvtName.TabIndex = 2
        Me.bvtName.ValidateDataObjectSourceName = ""
        Me.bvtName.ValidatePropertyName = ""
        '
        'BacdtbDOB
        '
        Me.BacdtbDOB.AllowDrop = True
        Me.BacdtbDOB.AllowEntryOnAdd = True
        Me.BacdtbDOB.AllowEntryOnEdit = False
        Me.BacdtbDOB.Checked = False
        Me.BacdtbDOB.CustomFormat = "MM/dd/yyyy"
        Me.BacdtbDOB.DatabaseFieldName = "participant_DOB"
        Me.BacdtbDOB.DatabaseTableName = "tbl_participant_info"
        Me.BacdtbDOB.DefaultBackColorAllowEdit = System.Drawing.SystemColors.ControlLightLight
        Me.BacdtbDOB.DefaultBackColorNoEdit = System.Drawing.SystemColors.Control
        Me.BacdtbDOB.DefaultValue = Nothing
        Me.BacdtbDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BacdtbDOB.HowOpened = BAC.Controls.BACenums.FormEnums.FormOpenStyle.Unknown
        Me.BacdtbDOB.Location = New System.Drawing.Point(81, 176)
        Me.BacdtbDOB.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.BacdtbDOB.MinDate = New Date(2016, 12, 1, 0, 0, 0, 0)
        Me.BacdtbDOB.Name = "BacdtbDOB"
        Me.BacdtbDOB.Size = New System.Drawing.Size(116, 22)
        Me.BacdtbDOB.TabIndex = 3
        Me.BacdtbDOB.Value = Nothing
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 463)
        Me.Controls.Add(Me.BacdtbDOB)
        Me.Controls.Add(Me.bvtName)
        Me.Controls.Add(Me.BacCboStatus)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BacCboStatus As BAC.Controls.bacExtraCombo
    Friend WithEvents bvtName As BAC.Controls.bacValidateTextBox
    Friend WithEvents BacdtbDOB As BAC.Controls.bacDateTimePickerMask
End Class
