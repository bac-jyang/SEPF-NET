Imports System.Data.SqlClient


Public Class frmEmployer_PayHistory
    Dim da As SqlDataAdapter
    Dim dt As New DataTable

    Private Sub frmEmployer_PayHistory_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = String.Empty

        Me.Text = Me.Text & " - " & frmEmployer_Info.txtEmp_Name.Text
        Try
            sql = "SELECT Payment_Month, Payment_Amount, Payment_Type, Payment_Transferdate " & _
                 " FROM tbl_Employer_Payment where empID=" & frmEmployer_Info.EmpID & " order by Payment_Transferdate desc"
            da = New SqlDataAdapter(sql, gCnn)
            da.Fill(dt)
            grdPayHistory.DataSource = dt
            grdPayHistory.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        da.Dispose()
        dt.Dispose()
        da = Nothing
        Me.Close()
    End Sub

    Private Sub btnSaveExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveExcel.Click
        ExportToExcel(dt, "C:\temp\PayHistory.xlsx")
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class