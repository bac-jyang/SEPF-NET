Imports System.Data.SqlClient
Public Class frmEmployer_Info

    Dim da As SqlDataAdapter
    Dim dt As New DataTable
    Public EmpID As Long

    Private Sub frmEmployer_Info_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String
        Try
           
            sql = "Select * from tbl_Employer where EmpID=" & EmpID
            da = New SqlDataAdapter(sql, gCnn)
            'Automatically generates DeleteCommand, UpdateCommand and InsertCommand for DataAdapter object  
            Dim builder As SqlCommandBuilder = New SqlCommandBuilder(da)
            da.Fill(dt)
            txtEmp_Name.DataBindings.Add("Text", dt, "Emp_Name")
            txtEmp_Fund.DataBindings.Add("Text", dt, "Emp_Fund")
            txtEmp_Status.DataBindings.Add("Text", dt, "Emp_Status")
            dtbEmp_ParticipationDate.DataBindings.Add("Text", dt, "Emp_ParticipationDate", True)
            dtbEmp_ParticipationDate.DataBindings(0).FormatString = "MM/dd/yyyy"
           
            txtEmp_OpenBalance.DataBindings.Add("Text", dt, "Emp_OpenBalance", True)
            txtEmp_OpenBalance.DataBindings(0).FormatString = "C"
            txtEmp_CurrentPay.DataBindings.Add("Text", dt, "Emp_CurrentPay")
            txtEmp_CurrentPay.DataBindings(0).FormatString = "C"

            txtEmp_LastPayment.DataBindings.Add("Text", dt, "Emp_LastPayment", True)
            txtEmp_LastPayment.DataBindings(0).FormatString = "C"

            dtbEmp_InactiveDate.DataBindings.Add("Text", dt, "Emp_InactiveDate")

            dtbEmp_LastInvoiceDate.DataBindings.Add("Text", dt, "Emp_LastInvoiceDate", True, DataSourceUpdateMode.Never, "MM/yyyy")

            txtEmp_CurrentBalance.DataBindings.Add("Text", dt, "Emp_CurrentBalance", True)
            txtEmp_CurrentBalance.DataBindings(0).FormatString = "C"
            txtEmp_CurrentCharge.DataBindings.Add("Text", dt, "Emp_CurrentCharge", True)
            txtEmp_CurrentCharge.DataBindings(0).FormatString = "C"
          
            dtbEmp_PaymentDate.DataBindings.Add("Text", dt, "Emp_PaymentDate", True, DataSourceUpdateMode.Never, "MM/dd/yyyy")
            txtEmp_AnnualContributionLevel.DataBindings.Add("Text", dt, "Emp_AnnualContributionLevel", True)
            txtEmp_AnnualContributionLevel.DataBindings(0).FormatString = "C"

            'contact
            txtEmp_ContactFirstName.DataBindings.Add("Text", dt, "Emp_ContactFirstName")
            txtEmp_ContactMiddleInitial.DataBindings.Add("Text", dt, "Emp_ContactMiddleInitial")

            txtEmp_ContactLastName.DataBindings.Add("Text", dt, "Emp_ContactLastName")
            txtEmp_Address1.DataBindings.Add("Text", dt, "Emp_Address1")
            txtEmp_Address2.DataBindings.Add("Text", dt, "Emp_Address2")
            txtEmp_Address3.DataBindings.Add("Text", dt, "Emp_Address3")
            txtEmp_City.DataBindings.Add("Text", dt, "Emp_City")
            txtEmp_StateCode.DataBindings.Add("Text", dt, "Emp_StateCode")

            txtEmp_ZipCode.DataBindings.Add("Text", dt, "Emp_ZipCode")


            txtEmp_Phone.DataBindings.Add("Text", dt, "Emp_Phone", True, DataSourceUpdateMode.OnValidation, "(xxx)xxx-xxxx")
            txtEmp_Fax.DataBindings.Add("Text", dt, "Emp_Fax", True, DataSourceUpdateMode.OnValidation, "(XXX)XXX-XXXX")
            txtEmp_HomePhone.DataBindings.Add("Text", dt, "Emp_HomePhone")
            txtEmp_Email.DataBindings.Add("Text", dt, "Emp_Email")

            'make form read-only
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Source & "- " & ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        Me.BindingContext(dt).AddNew()
    End Sub

    Private Sub btnModify_Click(sender As System.Object, e As System.EventArgs) Handles btnModify.Click
        ' Me.BindingContext (dt).EndCurrentEdit
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Try
            Me.BindingContext(dt).EndCurrentEdit()
            Dim dtChg As DataTable = dt.GetChanges()
            da.Update(dtChg)
            dt.AcceptChanges()
            MsgBox("Records saved.")
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        da.Dispose()
        dt.Dispose()
        Me.Close()
    End Sub

    Private Sub mnuContribRate_Click(sender As System.Object, e As System.EventArgs) Handles mnuContribRate.Click
        ' frmEmployerContrib.Show()
    End Sub

    Private Sub mnuPayHistory_Click(sender As System.Object, e As System.EventArgs) Handles mnuPayHistory.Click
        frmEmployer_PayHistory.Show()
    End Sub

    Private Sub mnuMakePayment_Click(sender As System.Object, e As System.EventArgs) Handles mnuMakePayment.Click
        ' FormEmployer_MakePay.EmpId = Me.EmpID
        ' FormEmployer_MakePay.Show()

    End Sub

    Private Sub EmployerMonthlyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployerMonthlyToolStripMenuItem.Click
        FormEmployer_MonthlyReport.EmployerID = Me.EmpID
        FormEmployer_MonthlyReport.Show()

    End Sub
End Class