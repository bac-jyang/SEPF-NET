

Imports BAC.Controls
Imports BAC.Controls.BacEditForm
Imports BAC.Controls.BacEditForm.RecordLocking
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class FormEmployerInfo
#Region "Form Variables"
    Private mPassedQbeInfo As New PassToEditFormFromQbe
    'place the string name of the stored procedure need to fill
    'all the combo boxes 
    Private nameOfProcForComboFill As String = "FillAllCombos_frmEmployerInfo"
    Private fieldNameOfId As String = "Emp_ID"
    'Declare all classes that will be used to fill a EflComboBox
    Dim myStateCountry As New StateCountry

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



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
            myStateCountry.FillListOfStateCountry(cboEmp_StateCode)

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
        ' Dim firstName As String = Me.txtSurv_FirstName.Text
        ' Dim lastName As String = Me.txtSurv_LastName.Text

        ' Me.Text = "Survivor:  " & firstName & " " & lastName

    End Sub
    Private Sub FrmEdit_Info_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'This is called after all form operations have run.
        'Add the handlers for all comboboxes that have Objects as their datasource so it can be captured
        ' AddHandler Me.cboemp_State.SelectedIndexChanged, AddressOf CboPAdr_State_ValueMemberChanged
        ' AddHandler Check_Undeliverable.CheckedChanged, AddressOf Padr_Undeliverable_CheckedChanged

    End Sub

    Private Sub bacPanel_Paint(sender As Object, e As PaintEventArgs) Handles bacPanel.Paint

    End Sub

    Private Sub bacEflNavigationControl_RecordAddNewClickedEvent(sender As Object, e As System.ComponentModel.CancelEventArgs) _
         Handles bacEflNavigationControl.RecordAddNewClickedEvent
        ' MessageBox.Show("Hi Jun")
    End Sub

    Private Sub EmployerReportHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployerReportHistoryToolStripMenuItem.Click
        With FormEmployerContribRate
            .FormCaption = txtEmp_Name.Text.ToString
            .FormId = CType(txtEmp_ID.Text, Integer)
            .Show()
        End With
    End Sub

    Private Sub EmployerPaymentHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployerPaymentHistoryToolStripMenuItem.Click
        With FormEmployerPayment
            .FormCaption = txtEmp_Name.Text.ToString
            .FormId = CType(txtEmp_ID.Text, Integer)
            .Show()
        End With

    End Sub



#End Region

End Class