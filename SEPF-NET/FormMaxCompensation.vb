Imports System.Data.SqlClient
Public Class FormMaxCompensation


    '---------------------------------------------------------------------------
    ' Name:     FormMaxCompensation
    ' Called By:
    '           
    ' Purpose:  retrive participants max compensation rate,
    '           can be updated/deleted And added New rate
    ' Input:    
    ' Returns:  records
    ' Author:    4/18/2019
    ' Modifications:
    ' TBD: need validate duplicate date when add new rate, but this is once a year entry, not done
    '               at this time.
    '           
    '---------------------------------------------------------------------------

    Dim da As SqlDataAdapter
    Dim dt As New DataTable
    Dim newRow As DataRow
    Private cmdbuilder As SqlCommandBuilder

    Dim connectionString As String = Mine.ConnString.SEPFConnection
    Dim connection As New SqlClient.SqlConnection(connectionString)


    Private Sub frmRates_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try

            LoadGrid()

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

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            'save modification and new record

            If (CType(Me.grdRates.CurrentRow.DataBoundItem, DataRowView).Row.RowState = DataRowState.Added) Then
                'If grdRates.CurrentRow.IsNewRow Then

                newRow("effectivedate") = grdRates.CurrentRow.Cells(1).Value
                newRow("MaximumCompensation") = grdRates.CurrentRow.Cells(2).Value
                newRow("modifiedDate") = DateTime.Now

            Else
                cmdbuilder.GetUpdateCommand()
            End If
            da.Update(dt)


            LoadGrid()

            MsgBox("Change saved.")
        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try

    End Sub

    Private Sub Delete_Click(sender As System.Object, e As System.EventArgs) Handles Delete.Click
        Try
            If MsgBox("Are you sure you want to delete this record?") = MsgBoxResult.Ok Then
                cmdbuilder.GetDeleteCommand()
                dt.Rows(grdRates.CurrentRow.Index).Delete()
                da.Update(dt)

                LoadGrid()
                MsgBox("Record deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try

    End Sub
    Private Sub LoadGrid()
        Dim sql As String = String.Empty
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            grdRates.DataSource = Nothing
            'clear datatable first
            dt.Clear()
            grdRates.Rows.Clear()

            ' sql = "Select * from PensionContribInterestRate order by Rate_Effective_Date desc"
            sql = "  select ID, effectivedate,MaximumCompensation, modifiedDate from AnnMaxCompensation order by EffectiveDate desc "
            da = New SqlDataAdapter(sql, connection)

            cmdbuilder = New SqlCommandBuilder(da)

            da.Fill(dt)
            With grdRates
                .DataSource = dt
                .Columns(0).Visible = False
                .Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"
                .Columns(2).DefaultCellStyle.Format = "##.0000"
                .Columns(3).Visible = False

            End With
        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try

    End Sub


    'Private Sub grdRates_CellLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRates.CellLeave

    '    Try
    '        Select Case grdRates.CurrentCell.ColumnIndex
    '            Case 1

    '                If TypeOf (grdRates.CurrentCell.Value) Is Date Then

    '                Else
    '                    MsgBox("Please enter a validate date.")
    '                End If

    '            Case 2
    '                If IsNumeric(grdRates.CurrentCell.Value) Then

    '                Else
    '                    MsgBox("Please enter a number.")
    '                End If
    '        End Select
    '    Catch ex As Exception
    '        MsgBox(ex.Source & " -" & ex.Message)
    '    End Try
    'End Sub



    Private Sub grdRates_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grdRates.CellValidating
        Try
            Select Case grdRates.CurrentCell.ColumnIndex
                Case 1

                    If Not IsDate(CType(e.FormattedValue, DateTime)) Then
                        MsgBox("Please enter a validate date.")
                        e.Cancel = True
                    End If

                Case 2
                    If Not IsNumeric(e.FormattedValue) Then
                        MsgBox("Please enter a number.")
                        e.Cancel = True
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add new row on top
        newRow = dt.NewRow()
        dt.Rows.InsertAt(newRow, 0)

    End Sub
End Class