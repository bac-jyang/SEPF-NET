Imports System.Data.SqlClient
Public Class frmPart_36MonthSalary
    '---------------------------------------------------------------------------
    ' Name:     frmPart_36MonthSalary
    ' Called By:
    '           frmParticipantInfo
    ' Purpose:  retrive participant last 36month salary and calculate the average monthly salary.
    ' Input:    PartID
    ' Returns:  records
    ' Author:   Jun Yang 6/15/2018
    ' Modifications:
    '           
    '           
    '---------------------------------------------------------------------------

    Public Property PartID As Integer
    Dim da As SqlDataAdapter
    Dim dts As New DataSet


    Private Sub Load36MonthSalary()
        'load year salary
        Dim sql1 As String = String.Empty
        Dim total As Double = 0

        Try
            With grd36Salary
                'Clear grid
                .DataSource = Nothing
                .Rows.Clear()

                sql1 = "exec dt_Part36MonthSalary " & PartID.ToString

                da = New SqlDataAdapter(sql1, gCnn)
                da.Fill(dts)

                '  dts.Tables(0).Rows.Add()
                'dts.Tables(0).AcceptChanges()


                .DataSource = dts.Tables(0)

                'format salary to currency
                'For i As Integer = 1 To .Columns.Count - 1
                '    .Columns(i).DefaultCellStyle.Format = "C"
                '    .Columns(i).ReadOnly = True
                'Next
                For Each col As DataGridViewColumn In .Columns
                    col.ReadOnly = True
                    col.DefaultCellStyle.Format = "C"



                Next
                'Dim dsNewRow1 As DataRow
                dts.Tables(0).Rows.Add()

                dts.Tables(0).Rows.Add()
                'Dim dsNewRow1 As DataRow
                'dsNewRow1 = dts.Tables(0).NewRow
                'For j As Integer = 0 To .Columns.Count - 1
                '    dsNewRow1.Item(j) = DBNull.Value
                'Next

                ' dts.Tables(0).Rows.Add(dsNewRow1)
                'add  empty rows for calculaton yealy total
                'add row to datatable and datagridview will auto update

                Dim dsNewRow As DataRow = dts.Tables(0).NewRow
                dts.Tables(0).Rows.Add(dsNewRow)



                'dsNewRow = dts.Tables(0).NewRow
                'For j As Integer = 0 To .Columns.Count - 1
                '    dsNewRow.Item(j) = DBNull.Value
                'Next

                'dts.Tables(0).Rows.Add(dsNewRow)



                'dts.Tables(0).AcceptChanges()

                ' da.Update(dts.Tables(0))



                dsNewRow.Item(0) = "Total"
                'For k As Integer = 1 To .Columns.Count - 1
                '    total = 0
                '    For i As Integer = 0 To .RowCount - 1
                '        If Not IsDBNull(.Rows(i).Cells(k).Value) Then
                '            total = total + CType(.Rows(i).Cells(k).Value, Double)
                '        End If
                '    Next

                For Each col As DataGridViewColumn In .Columns
                    total = 0
                    If col.Index > 0 Then
                        ' total = 0
                        For Each rw As DataGridViewRow In .Rows

                            If rw.Index > 0 And Not IsDBNull(rw.Cells(col.Index).Value) Then
                                total = total + CType(rw.Cells(col.Index).Value, Double)
                            End If
                        Next




                        dsNewRow.Item(col.Index) = total 'String.Format("{0:C}", total)
                    End If
                Next


                '    '.Rows().Cells(k).Value = String.Format("{0:C}", total)
                '    '.Rows(.Rows.GetLastRow(DataGridViewElementStates.Displayed)).Cells(k).Value = String.Format("{0:C}", total)
                '    ' .Rows(.Rows.GetLastRow(DataGridViewElementStates.Displayed)).Cells(k).ReadOnly = True
                'Next


                ' .Rows(12).Cells(0).Value = "Total:"
                ' .Rows(.Rows.GetLastRow(DataGridViewElementStates.Displayed)).Cells(0).Value = "Total"
                ' .Rows(.Rows.GetLastRow(DataGridViewElementStates.Displayed)).ReadOnly = True

                .AllowUserToAddRows = False
                .ReadOnly = True

                Dim BoldRow As New DataGridViewCellStyle With {.Font = New System.Drawing.Font("Verdana", 8.0!, FontStyle.Bold), .ForeColor = Color.Blue}


                .Rows(.Rows.Count - 1).DefaultCellStyle = BoldRow

                '  .Rows(.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Blue


                'For Each col1 As DataGridViewColumn In dsNewRow.ItemArray
                '    col1.DefaultCellStyle.ForeColor = Color.Blue
                'Next

                ' txtTotal.Text = String.Format("{0:C}", total)
                'change label text

                ' Label1.Text = "Year " & lstBenfYear.SelectedValue.ToString & " Total:"
                'load Average
                'put yearly total in the textbox
                Dim dr As DataRow
                dr = dts.Tables(1).Rows(0)
                txtAnnSalary.Text = dr.Item(0).ToString
                txtMonSalary.Text = dr.Item(1).ToString
            End With
        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try
    End Sub

    Private Sub frmPart_36MonthSalary_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        PartID = 2667
        Call Load36MonthSalary()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        dts.Dispose()
        da.Dispose()
        da = Nothing
        Me.Close()

    End Sub
End Class