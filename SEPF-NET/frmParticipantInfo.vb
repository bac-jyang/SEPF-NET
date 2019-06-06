Imports System.Data.SqlClient


Public Class frmParticipantInfo

    Dim da As SqlDataAdapter
    Dim dt As New DataTable
    Public EmpID As Long

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            ' Me.View_Participant_InfoTableAdapter.Fill(Me.SEPFDataSet.view_Participant_Info, CType(Param1ToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmParticipantInfo_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = String.Empty
        sql = "Select * from view_Participant_Info where participantID=2668"
        da = New SqlDataAdapter(Sql, gCnn)
        da.Fill(dt)

        Me.Participant_SSN.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_SSN", True))
        Me.Participant_FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_FirstName", True))
        Me.Participant_MInitial.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_MInitial", True))
        Me.Participant_LastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_LastName", True))
        Me.Participant_Address1.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Address1", True))
        Me.Participant_Address2.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Address2", True))
        Me.Participant_City.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_City", True))
        Me.Participant_State_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_State_Code", True))
        ' Me.Participant_State_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_State_Code", True))
        Me.Participant_Country.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Country", True))
        Me.Participant_Phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Phone", True))
        Me.Participant_Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Email", True))
        Me.Participant_DOBDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_DOB", True))
        Me.Participant_Date_HiredDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Date_Hired", True))
        Me.Participant_DODDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_DOD", True))
        Me.Participant_Termination_DateDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Termination_Date", True))
        Me.Participant_Rehire_DateDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Rehire_Date", True))
        Me.Participant_Date_Last_ModifiedDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Date_Last_Modified", True))

        Me.Participant_Base_Earning.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Base_Earning", True))
        Me.Participant_Base_Effective_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Base_Effective_Date", True))
        Me.Participant_First_Contribution_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_First_Contribution_Date", True))
        Me.Participant_Last_Contribution_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Last_Contribution_Date", True))
        Me.ITDContribution.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "ITDContribution", True))
        Me.Participant_ITD_Pension_Contribution.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_ITD_Pension_Contribution", True))
        Me.Participant_ITD_Insurance_Deduction.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_ITD_Insurance_Deduction", True))
        Me.Participant_Pension_Suspension.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Pension_Suspension", True))
        Me.Participant_Pension_Reinstatement.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Pension_Reinstatement", True))
        Me.Participant_Participation_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Participation_date", True))
        Me.Participant_Retirement_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Retirement_Date", True))
        Me.Participant_Lump_Sum_Payment.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Lump_Sum_Payment", True))
        Me.Participant_Lump_Sum_Payment_Flag.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Lump_Sum_Payment_Flag", True))
        Me.FutureServiceCredit.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "FutureServiceCredit", True))
        Me.YearsOfService.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "YearsOfService", True))
        Me.MonthsOfService.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "MonthsOfService", True))
        Me.TotalServiceCredit.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "TotalServiceCredit", True))
        Me.Participant_Award_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Award_Date", True))
        Me.Participant_ITD_Benefits_Paid.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_ITD_Benefits_Paid", True))
        Me.Participant_Last_Check_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_Last_Check_Date", True))
        Me.Participant_QDR_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", dt, "Participant_QDR_Date", True))
        Me.Participant_QDR_Amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_QDR_Amount", True))
        Me.Participant_QDR_Flag.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_QDR_Flag", True))
        Me.Participant_Option.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Option", True))
        Me.Participant_Pension_Type.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Pension_Type", True))
        Me.Participant_Country_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Country_Code", True))
        Me.Participant_Fund.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Fund", True))
        Me.Participant_Zip_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Zip_Code", True))
        Me.Participant_Organization.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Organization", True))
        Me.Participant_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Status", True))
        Me.Participant_Martial_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Martial_Status", True))
        Me.Participant_OE_Flag.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_OE_Flag", True))
        Me.Vested.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Vested", True))
        Me.Participant_Pay_Frequency.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Participant_Pay_Frequency", True))
        Me.Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "Name", True))

    End Sub
End Class