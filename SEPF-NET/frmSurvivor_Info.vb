Imports System.Data.SqlClient

Public Class frmSurvivor_Info
    Dim da As SqlDataAdapter
    Dim dt As New DataTable
    Public SurvivorID As Long

    


   

    Private Sub frmSurvivor_Info_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbl_Survivor_Info' table. You can move, or remove it, as needed.
        ' Me.Tbl_Survivor_InfoTableAdapter.Fill(Me.DataSet1.tbl_Survivor_Info)

        Dim sql As String = String.Empty
        sql = "Select * from tbl_Survivor_Info where SurvivorID=1417"
        da = New SqlDataAdapter(sql, gCnn)

        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(da)
        da.Fill(dt)
        Me.txtSurvivor_SSN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_SSN", True))
        Me.txtSurvivor_FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_FirstName", True))
        Me.txtSurvivor_MInitial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_MInitial", True))
        Me.txtSurvivor_LastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_LastName", True))
        Me.txtSurvivor_Address1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Address1", True))
        Me.txtSurvivor_Address2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Address2", True))
        Me.txtSurvivor_City.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_City", True))
        Me.cboSurvivor_State_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_State_Code", True))
        Me.txtSurvivor_Zip_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Zip_Code", True))
        Me.txtSurvivor_Gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Gender", True))
        Me.txtSurvivor_Country.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Country", True))
        Me.cboSurvivor_Country_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Country_Code", True))
        Me.txtSurvivor_Phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Phone", True))
        Me.txtSurvivor_Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Email", True))
        Me.cboSurvivor_Spouse_Flag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Spouse_Flag", True))
        Me.txtSurvivor_Relationship.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Relationship", True))
        Me.Survivor_DOB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_DOB", True))
        Me.Survivor_DOD.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_DOD", True))
        Me.Survivor_Date_last_Modified.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_Date_last_Modified", True))
        Me.Survivor_Effective_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_Effective_date", True))
        Me.Survivor_Monthly_Benefit_AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Monthly_Benefit_Amount", True))
        Me.Survivor_ITD_Benefits_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_ITD_Benefits_Paid", True))
        Me.Survivor_Award_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_Award_Date", True))
        Me.Survivor_Pension_Suspension.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_Pension_Suspension", True))
        Me.Survivor_Pension_Reinstatement.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_Pension_Reinstatement", True))
        Me.Survivor_Benefit_Last_Check_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_Benefit_Last_Check_Date", True))
        Me.Survivor_LumpSum_AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_LumpSum_Amount", True))
        Me.Survivor_QDR_Date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dt, "Survivor_QDR_Date", True))
        Me.Survivor_Monthly_Benefit_Amount_BQDRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Monthly_Benefit_Amount_BQDR", True))
        Me.Survivor_QDR_FlagComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_QDR_Flag", True))
        Me.cboSurvivor_Fund.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dt, "Survivor_Fund", True))



    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        Me.BindingContext(dt).AddNew()
    End Sub

    Private Sub btnModify_Click(sender As System.Object, e As System.EventArgs) Handles btnModify.Click
        ' Me.BindingContext (dt).EndCurrentEdit
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Try
            Me.BindingContext(dt).EndCurrentEdit()
            Dim dtChg As DataTable = dt.GetChanges()
            da.Update(dtChg)
            dt.AcceptChanges()
            MsgBox("Records saved.")
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        da.Dispose()
        dt.Dispose()
        Me.Close()
    End Sub

    
End Class