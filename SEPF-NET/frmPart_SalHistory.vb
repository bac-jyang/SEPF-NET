Imports System.Data.SqlClient
Imports System.Text

Public Class frmPart_SalHistory
    '---------------------------------------------------------------------------
    ' Name:     frmPart_SalHistory
    ' Called By:
    '           frmParticipantInfo
    ' Purpose:  retrive participant salary history
    ' Input:    PartID
    ' Returns:  records
    ' Author:   Jun Yang 6/15/2018
    ' Modifications:
    '           
    '           
    '---------------------------------------------------------------------------
    Dim da As SqlDataAdapter
    Dim dt As New DataTable

    Public Property PartID As Integer


    Private Sub frmPartSalHistory_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = String.Empty
        Dim strBld As New StringBuilder

        Try
            'get PartID from Infor. form
            PartID = 3393 '2667 

            'load listbox with salary year
            strBld.Append(" select distinct Year(pSal_Contributiondate) as SalYear from ")

            strBld.Append("participantsalary where part_ID= ")
            strBld.Append(PartID.ToString)

            ' Append a string and then another line break.
            strBld.Append(" order by year(pSal_Contributiondate)")


            sql = strBld.ToString
            da = New SqlDataAdapter(sql, gCnn)
            da.Fill(dt)
            With lstSalYear
                .DisplayMember = "SalYear"
                .ValueMember = "SalYear"
                .DataSource = dt

            End With

            'show first year salary
            lstSalYear.SelectedIndex = 0
            Call LoadYearSalary()

        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)

        End Try
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        dt.Dispose()
        da.Dispose()
        da = Nothing
        Me.Close()
    End Sub

    Private Sub lstSalYear_Click(sender As Object, e As System.EventArgs) Handles lstSalYear.Click
        Call LoadYearSalary()
    End Sub
    Private Sub LoadYearSalary()
        'load year salary
        Dim sql1 As String = String.Empty
        Dim strBld As New StringBuilder
        Dim dt1 As New DataTable

        Try
            grdSalHistory.DataSource = Nothing
            grdSalHistory.Rows.Clear()

            sql1 = "exec dt_PartSalHistory " & PartID.ToString & ",  " & Convert.ToInt32(lstSalYear.SelectedValue)  '--2000"
            da.Dispose()
            da = Nothing
            da = New SqlDataAdapter(sql1, gCnn)
            da.Fill(dt1)
            grdSalHistory.DataSource = dt1


            'format benefit to currency
            grdSalHistory.Columns(1).DefaultCellStyle.Format = "C"
            grdSalHistory.Columns(2).DefaultCellStyle.Format = "C"
            grdSalHistory.Columns(3).DefaultCellStyle.Format = "C"

            'put yearly total in the textbox
            Dim total As Double = 0


            For i As Integer = 0 To grdSalHistory.RowCount - 1

                total = total + CType(grdSalHistory.Rows(i).Cells(1).Value, Double)

            Next

            TextBox1.Text = String.Format("{0:C}", total)
            'change label text
            Label1.Text = "Year " & lstSalYear.SelectedValue.ToString & " Total:"


        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try
    End Sub

    Private Sub lstSalYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstSalYear.SelectedIndexChanged

    End Sub
End Class