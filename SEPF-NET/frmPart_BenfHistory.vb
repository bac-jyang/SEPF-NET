Imports System.Data.SqlClient
Imports System.Text
Public Class frmPart_BenfHistory
    '---------------------------------------------------------------------------
    ' Name:     frmPart_BenfHistory
    ' Called By:
    '           frmParticipantInfo
    ' Purpose:  retrive participant survivor payment history
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


    Private Sub frmPart_BenfHistory_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = String.Empty
        Dim strBld As New StringBuilder

        Try
            'get PartID from Infor. form
            PartID = 2857

            'load listbox with salary year
            strBld.Append(" select distinct Year(Pben_Paymentdate) as BenfYear from ")

            strBld.Append("ParticipantBenefit where part_ID= ")
            strBld.Append(PartID.ToString)

            ' Append a string and then another line break.
            strBld.Append(" order by year(Pben_Paymentdate)")


            sql = strBld.ToString
            da = New SqlDataAdapter(sql, gCnn)
            da.Fill(dt)
            With lstBenfYear
                .DisplayMember = "BenfYear"
                .ValueMember = "BenfYear"
                .DataSource = dt

            End With

            'show first year salary
            lstBenfYear.SelectedIndex = 0
            Call LoadYearBenefit()
            grdBenfHistory.ReadOnly = True

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

    Private Sub lstbenYear_Click(sender As Object, e As System.EventArgs) Handles lstBenfYear.Click
        Call LoadYearBenefit()
    End Sub
    Private Sub LoadYearBenefit()
        'load year salary
        Dim sql1 As String = String.Empty
        Dim strBld As New StringBuilder
        Dim dt1 As New DataTable

        Try
            grdBenfHistory.DataSource = Nothing
            grdBenfHistory.Rows.Clear()



            sql1 = "exec dt_PartBenfHistory " & PartID.ToString & ",  " & Convert.ToInt32(lstBenfYear.SelectedValue)  '--2000"
            da.Dispose()
            da = Nothing
            da = New SqlDataAdapter(sql1, gCnn)
            da.Fill(dt1)
            grdBenfHistory.DataSource = dt1

            'format benefit to currency
            grdBenfHistory.Columns(1).DefaultCellStyle.Format = "C"

            'put yearly total in the textbox
            Dim total As Double = 0


            For i As Integer = 0 To grdBenfHistory.RowCount - 1

                total = total + CType(grdBenfHistory.Rows(i).Cells(1).Value, Double)

            Next

            txtTotal.Text = String.Format("{0:C}", total)
            'change label text

            Label1.Text = "Year " & lstBenfYear.SelectedValue.ToString & " Total:"


        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try
    End Sub


End Class