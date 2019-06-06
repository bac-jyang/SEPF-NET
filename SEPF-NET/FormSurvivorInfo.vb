#Region "Imports"
Imports BAC.Controls
Imports BAC.Controls.BacEditForm
Imports BAC.Controls.BacEditForm.RecordLocking
Imports Microsoft.VisualBasic.PowerPacks.Printing

#End Region
Public Class FormSurvivorInfo
#Region "RemoveClose"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
#End Region
#Region "Form Variables"
    Private mPassedQbeInfo As New PassToEditFormFromQbe
    'place the string name of the stored procedure need to fill
    'all the combo boxes 
    Private nameOfProcForComboFill As String = "FillAllCombos_frmSurvivorInfo"
    Private fieldNameOfId As String = "Surv_ID"
    'Declare all classes that will be used to fill a EflComboBox
    Dim myStateCountry As New StateCountry
#End Region

#Region "Properties"
    Public Property PassedQbeInfo As PassToEditFormFromQbe
        Get
            Return mPassedQbeInfo
        End Get
        Set(value As PassToEditFormFromQbe)
            mPassedQbeInfo = value
        End Set
    End Property
#End Region
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.


    End Sub
#Region "Load"
    Private Sub EditForm_Info_Load(sender As Object, e As EventArgs) _
           Handles Me.Load
        Try
            FillEditForm()

            'make sure form is proper size
            ' Mine.AppData.SetFormSize(Me, True)

            SetFormTitle()

        Catch argNull As ArgumentNullException
            MessageBox.Show("Error in " & argNull.TargetSite.Name &
                         " " & argNull.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub FillEditForm()
        Try
            'fill all the comboboxes that will not be filled from
            'the stored procedure
            myStateCountry.FillListOfStateCountry(cbo_State)

            'run a stored procedure from a codes table to update all the
            'bacEflComboBox controls with the CodesTypeId filled in
            Me.bacEflNavigationControl.FillMultipleUsingDataTableOneTable(Me,
                                                                          mPassedQbeInfo.PassedConnection,
                                                                          CommandType.StoredProcedure,
                                                                          nameOfProcForComboFill)

            '*** Set Tab order here ***********************************************
            Dim tabOrderManager As New BacQbeTabOrderManager(Me)
            'if any group controls that should be set a different tab order
            'set them here FIRST.)
            'Set tab order as Down, Across, or None
            With tabOrderManager
                'if you have groupboxes, or other containers put in here
                ''   .SetSchemeForControl(gbRaInfo, BacQbeTabOrderManager.TabScheme.AcrossFirst)
                'bacPanel is loaded with the control
                ''     .SetSchemeForControl(bacPanel, BacQbeTabOrderManager.TabScheme.AcrossFirst)
                .SetTabOrder(BacQbeTabOrderManager.TabScheme.AcrossFirst)
            End With


            ''**** Fill the edit form *********************************************
            Me.bacEflNavigationControl.FillWithView(Me, mPassedQbeInfo.UserId,
                                                    mPassedQbeInfo.PassedConnection,
                                                    mPassedQbeInfo.RecordSourceName,
                                                    mPassedQbeInfo.IdList)

        Catch ex As Exception
            MessageBox.Show("Error loading data" & Environment.NewLine &
                            ex.ToString, "Errors", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub SetFormTitle()
        Dim firstName As String = Me.txtSurv_FirstName.Text
        Dim lastName As String = Me.txtSurv_LastName.Text

        Me.Text = "Survivor:  " & firstName & " " & lastName

    End Sub
    Private Sub FrmEdit_Info_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'This is called after all form operations have run.
        'Add the handlers for all comboboxes that have Objects as their datasource so it can be captured
        AddHandler Me.cbo_State.SelectedIndexChanged, AddressOf CboPAdr_State_ValueMemberChanged
        AddHandler Check_Undeliverable.CheckedChanged, AddressOf Padr_Undeliverable_CheckedChanged

    End Sub

#End Region

#Region "Cancel"
    Private Sub BacEfl_FileCancelConfirmEvent(sender As Object,
                                              e As System.ComponentModel.CancelEventArgs) _
                                              Handles bacEflNavigationControl.FileCancelOnConfirmEvent
        Try
            If MessageBox.Show("Information not saved - Stop Editing?", "Exit",
                               MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                'continue with cancel event
                e.Cancel = True
            Else 'set cancel to False to return to form
                e.Cancel = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub
    Private Sub BacEfl_FileCancelClickedEvent(sender As Object, e As EventArgs) _
        Handles bacEflNavigationControl.FileCancelOnClickedEvent
        ''handle any code here before the Efl code runs
        ' errors should be trapped here
        Try

            MessageBox.Show("This happens before code runs")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub BacEfl_FileCancelCompletedEvent(sender As Object,
                                                e As EventArgs) _
                                            Handles bacEflNavigationControl.FileCancelOnCompletedEvent
        Try
            MessageBox.Show("Record was canceled", "Record Canceled",
               MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

#Region "Navigation Click"
    Private Sub BacEflNavigationControl_OnCurrentPositionChanged(sender As Object,
                                                                 e As EventArgs) Handles bacEflNavigationControl.OnCurrentPositionChanged
        SetFormTitle()

    End Sub
    Private Sub BacEflNavigationControl_RecordMoveFirstClickEvent(sender As Object,
                                                                  e As System.ComponentModel.CancelEventArgs) _
                                                              Handles bacEflNavigationControl.RecordMoveFirstOnClickedEvent
        Try
            ' MessageBox.Show("Moving First")
            'e.Cancel = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: " & ex.TargetSite.Name, MessageBoxButtons.OK)
        End Try

    End Sub
    Private Sub RecordMoveFirstClickedEvent(sender As Object, e As EventArgs) _
            Handles bacEflNavigationControl.RecordMoveFirstOnClickedEventFinished
        Try
            ' MessageBox.Show("Moving First Finished")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: " & ex.TargetSite.Name, MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub RecordMovePreviousClickedEvent(sender As Object, e As EventArgs) _
            Handles bacEflNavigationControl.RecordMovePreviousOnClickedEventFinished
        Try
            ' MessageBox.Show("Moving Previous")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: " & ex.TargetSite.Name, MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub RecordMoveNextClickedEvent(sender As Object, e As EventArgs) _
            Handles bacEflNavigationControl.RecordMoveNextOnClickedEventFinished
        Try
            '  MessageBox.Show("Moving Next")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: " & ex.TargetSite.Name, MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub RecordMoveLastClickedEvent(sender As Object, e As EventArgs) _
            Handles bacEflNavigationControl.RecordMoveLastOnClickedEventFinished
        Try
            '   MessageBox.Show("Moving Last")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: " & ex.TargetSite.Name, MessageBoxButtons.OK)
        End Try
    End Sub
#End Region

#Region "RecordLocks"

    ''' <summary>
    ''' Notifies User that there are existing locks on
    ''' a record.
    ''' </summary>
    Public Sub LockExists(sender As Object, lockArgs As List(Of LockExistsEventArgs)) _
              Handles bacEflNavigationControl.OnRecordLockExists

        If Not sender Is Nothing Then


            MessageBox.Show(sender.ToString, "Record Locked",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If Not lockArgs Is Nothing Then
            For Each item As LockExistsEventArgs In lockArgs
                MessageBox.Show(item.LockExistsMessage & " Elok_ID = " & item.LockExistsId)
            Next
        End If

    End Sub
    ''' <summary>
    '''  Notifies user of why a record can not be locked for editing.
    ''' </summary>
    Public Sub LockError(sender As Object,
                         e As LockErrorEventArgs) _
                     Handles bacEflNavigationControl.OnRecordLockError
        If Not e Is Nothing Then
            MessageBox.Show(e.LockErrorMessage, "Problem Locking Record",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    ''' <summary>
    '''  This is called right after the lock expires, but it is not
    ''' yet removed from locking.  If you want to autosave, or something
    ''' do it here, then remove the lock.
    ''' </summary>
    Private Sub BacRecordLockTimer_LockTimeExpired(sender As Object,
                                                  e As LockReachedEventArgs) _
                                                   Handles bacRecordLockTimer.LockTimeExpired
        'Note: running this will also cause locks to be run after exit.
        Me.bacRecordLockTimer.DeleteAllLocksForUser(PassedQbeInfo.PassedConnection.ConnectionString, CInt(User.GlobalUserId))

    End Sub
    ''' <summary>
    '''   Removes lock, closes form, does not save the pending changes.
    ''' </summary>
    Public Sub LockExpired(sender As Object, e As LockReachedEventArgs) _
      Handles bacEflNavigationControl.OnRecordLockExpired
        If Not e Is Nothing Then


            Dim message As String = e.Message & vbCrLf & e.TimeReached & vbCrLf &
            "Data was not saved."

            MessageBox.Show(message, "Record Not Saved",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Problem with file lock", "Record Not Saved",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

    Private Sub BacEflNavigationControl_RecordAddNewClickedEvent(sender As Object, e As EventArgs) _
       Handles bacEflNavigationControl.RecordAddNewOnClickedEventFinished,
            bacEflNavigationControl.RecordAddNewClickedEvent
        'this runs after the setting up
        Try
            ' MessageBox.Show("In Add New RecordAddNewOnClickedEventFinished")
        Catch fx As FormatException
            MessageBox.Show(fx.Message)
        Catch argEx As ArgumentException
            MessageBox.Show("Finally")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub BacNavButtonsHost_CmdAddNewClick(sender As Object, e As EventArgs) _
            Handles bacNavButtonsHost.CmdAddNewClick

        Try
            '  MessageBox.Show("In Add New Click")

            Me.cbo_State.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BacNavButtonsHost_CmdOkSaveCloseClick(sender As Object, e As EventArgs) _
       Handles bacNavButtonsHost.CmdOkSaveCloseClick

        Try
            'This runs before code, so you can change items
            If Me.Check_Undeliverable.Checked = True Then
                Me.txt_UndeliverableDate.Text = Date.Now.ToShortDateString
                Me.txt_UndeliverableDate.Value = CType(Date.Now.ToShortDateString, Date?)
            Else
                Me.txt_UndeliverableDate.Text = Nothing
                Me.txt_UndeliverableDate.Value = Nothing
            End If

            MessageBox.Show("CmdOkSaveCloseClick")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BacEflNavigationControl_FileOkClickedEvent(sender As Object, e As EventArgs) _
        Handles bacEflNavigationControl.FileOkOnClickedEvent
        Try
            MessageBox.Show("FileOkClickedEvent")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Nav_OnRecordEditError(sender As Object,
                                     insertArgs As List(Of BacEventArgs.RecordInsertErrorEventArgs)) _
                                     Handles bacEflNavigationControl.OnRecordEditError

        Dim builder As New Text.StringBuilder

        builder.Append("Please fix these errors:")
        builder.AppendLine()

        For Each item As BacEventArgs.RecordInsertErrorEventArgs In insertArgs
            builder.Append(item.ErrorMessage)
            builder.AppendLine()
        Next

        MessageBox.Show(builder.ToString)

    End Sub
#Region "Modify"
    Private Sub Nav_RecordEditClickedEvent(sender As Object,
                                         e As EventArgs) _
                                        Handles bacEflNavigationControl.RecordEditOnClickedEventFinished
        Try
            '1. First run
            'This is run before the rest of the navControl data update 

            ' MessageBox.Show("1. RecordEdit_Click")
            myStateCountry = CType(cbo_State.SelectedItem, StateCountry)
            If Not myStateCountry Is Nothing Then
                Me.txt_CountryName.Text = myStateCountry.CountryName
                Me.txt_Country_Code.Text = CStr(myStateCountry.CountryCode)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & " - " & ex.TargetSite.Name, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Nav_OnRecordUpdatingNoData(sender As Object,
                                           e As BacEventArgs.RecordUpdatingNoDataEventArgs) _
                                       Handles bacEflNavigationControl.OnRecordUpdatingNoData
        Try
            '2. Run Second only if no changes
            MessageBox.Show("Error: " & e.ErrorMessage,
                            "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & " - " & ex.TargetSite.Name, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    ''' <summary>
    ''' If the ConfirmUpdate flag is set to True, then before records are 
    ''' updated, it must be confirmed by the user.  If Flag is false,
    ''' the event will not fire.
    ''' </summary>
    Private Sub Nav_OnRecordConfirmUpdate(sender As Object,
                                         e As System.ComponentModel.CancelEventArgs) _
                                     Handles bacEflNavigationControl.OnRecordConfirmUpdate
        Try
            '3. Runs third, if there are changes
            If MessageBox.Show(sender.ToString, "Save Changes?",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & " - " & ex.TargetSite.Name, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Nav_OnRecordUpdating(sender As Object,
                                                        e As SqlClient.SqlRowUpdatingEventArgs) _
                                                    Handles bacEflNavigationControl.OnRecordUpdating
        '4. Runs in process of updating
        Try

            ' MessageBox.Show("OnRecordUpdating " & e.Command.CommandText)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & " - " & ex.TargetSite.Name, "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    ''' <summary>
    '''  Runs after record updated.
    ''' Set InformRecordUpdated flag to True to display message,
    ''' False will not display.
    ''' </summary>
    Private Sub Nav_OnRecordUpdated(sender As Object,
                                    e As BacEventArgs.RecordEditEventArgs) _
                                Handles bacEflNavigationControl.OnRecordUpdated

        Try
            '5. Runs after the record is updated
            MessageBox.Show(e.Message, "Record Updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & " - " & ex.TargetSite.Name, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub Nav_OnRecordUpdateError(sender As Object,
                                                            e As SqlClient.SqlRowUpdatedEventArgs) _
                                                        Handles bacEflNavigationControl.OnRecordUpdateError
        Try

            MessageBox.Show("Error Update: " & e.Errors.Message, "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & " - " & ex.TargetSite.Name, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Nav_OnRecordUpdatingError(sender As Object,
                                          e As SqlClient.SqlRowUpdatingEventArgs) _
                                      Handles bacEflNavigationControl.OnRecordUpdatingError
        Try

            MessageBox.Show("Error Updating: " & e.Errors.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & " - " & ex.TargetSite.Name, "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    ''' <summary>
    '''  The final Error would come here.
    ''' </summary>
    Private Sub Nav_RecordUpdatingError(sender As Object,
                                     e As BacEventArgs.RecordUpdatingErrorEventArgs) _
                                        Handles bacEflNavigationControl.RecordUpdatingError

        MessageBox.Show(e.ErrorMessage,
                        "Error Updating Record",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
#End Region
#Region "ClosingUp"
    Private Sub BacEflNavigationControl_FileCloseClickedEvent(sender As Object, e As EventArgs) _
        Handles bacEflNavigationControl.FileCloseOnClickedEvent
        Try
            ' MessageBox.Show("FileCloseClickedEvent")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Form_Info_FormClosed(sender As Object,
                                               e As FormClosedEventArgs) _
                                                 Handles Me.FormClosed
        Try
            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "ComboBoxes Handlers"
    Private Sub CboPAdr_State_ValueMemberChanged(sender As Object,
                                                         e As EventArgs)

        myStateCountry = CType(cbo_State.SelectedItem, StateCountry)
        If Not myStateCountry Is Nothing Then
            Me.txt_CountryName.Text = myStateCountry.CountryName
            Me.txt_Country_Code.Text = CStr(myStateCountry.CountryCode)
        End If


    End Sub
    Private Sub Padr_Undeliverable_CheckedChanged(sender As Object, e As EventArgs) _
        'Handles Padr_Undeliverable.CheckedChanged

        'If Padr_Undeliverable.Checked Then
        '    Me.txtPAdr_UndeliverableDate.Text = CStr(Now)
        'Else
        '    Me.txtPAdr_UndeliverableDate.Text = Nothing
        'End If

    End Sub



    Private Sub BacEflNavigationControl_FilePrintOnClickedEvent(sender As Object,
                                                                e As System.ComponentModel.CancelEventArgs) _
                                                                Handles bacEflNavigationControl.FilePrintOnClickedEvent

        'Dim printf As PrintForm = Nothing

        Try

            '    printf = New PrintForm With {
            '    .Form = Me
            '}
            Using printf As New PrintForm(Me)

                printf.Print()
            End Using

        Catch ex As Exception
            MessageBox.Show("Problem Printing Form: " & ex.Message, "Error",
                      MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Finally
            'printf.Dispose()
        End Try


    End Sub
    Private Sub BacEflNavigationControl_ViewAuditOnClickedEvent(sender As Object,
                                                                   e As System.ComponentModel.CancelEventArgs) _
                                                               Handles bacEflNavigationControl.ViewAuditOnClickedEvent


        Try

            Dim cm As CurrencyManager = TryCast(Me.bacEflNavigationControl.CurrencyMgr, CurrencyManager)
            Dim p As DataRowView = CType(cm.Current, DataRowView)
            Dim id As Integer = CInt(p.Item(fieldNameOfId))
            Mine.AppData.SetFormSize(My.Forms.FormAuditTrail, True)
            With My.Forms.FormAuditTrail
                .FormId = id
                .FormCaption = Me.Text
                .ShowDialog(Me)
            End With

        Catch ex As Exception
            MessageBox.Show("Problem opening Form: " & ex.Message, "Error",
                            MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        End Try

    End Sub

#End Region

End Class