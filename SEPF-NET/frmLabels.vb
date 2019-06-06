Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class frmLabels
    ''' <summary>
    ''' retrive all labels and save them at excel/csv file formate
    ''' Jun Yang 5/9/2019
    ''' </summary>

    Dim da As SqlDataAdapter
    Dim dt As New DataTable
    Dim fPath As String = "\\tile\SEPF\MailingLabels\"
    Dim connectionString As String = Mine.ConnString.SEPFConnection
    Dim connection As New SqlClient.SqlConnection(connectionString)

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click

        dt.Dispose()
        da.Dispose()
        da = Nothing
        Me.Close()
    End Sub

    Private Sub frmLabels_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = String.Empty
        Try
            sql = "Select Label_ID, Label_Description, Label_DBSource, Label_Name, Label_DBType from Labels"
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            da = New SqlDataAdapter(sql, connection)
            da.Fill(dt)
            grdLabels.DataSource = dt
            grdLabels.Columns(3).Visible = False
            grdLabels.Columns(4).Visible = False

        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        Finally
            da.Dispose()
        End Try
    End Sub


    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        ExportFiles(True)
    End Sub
    Private Sub ExportFiles(bExcel As Boolean)
        'loop all selected labels, created datatable from datasoure,
        'call ExportExcel to create files
        Dim dtSource As New DataTable
        ' Dim sdbSource As String
        Dim fName As String = String.Empty

        Dim sql As String = String.Empty
        'For i = 0 To grdLabels.SelectedRows.Count - 1
        Try
            sql = ""
            If grdLabels.Item(4, grdLabels.CurrentRow.Index).Value.ToString = "ST" Then
                sql = "Exec " & grdLabels.Item(2, grdLabels.CurrentRow.Index).Value.ToString
            Else

                sql = "Select * from " & grdLabels.Item(2, grdLabels.CurrentRow.Index).Value.ToString
            End If
            da = New SqlDataAdapter(sql, connection)
            da.Fill(dtSource)
            'file name plus date
            fName = fPath & grdLabels.Item(3, grdLabels.CurrentRow.Index).Value.ToString & Date.Today.ToString("MMddyyyy")
            If bExcel Then
                ExportExcel(dtSource, fName & ".xlsx")
            Else
                DataTable2CSV(dtSource, fName & ".csv", ControlChars.Tab.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        Finally
            da.Dispose()
            dtSource.Dispose()
        End Try
        'Next
    End Sub
    Private Sub ExportExcel(dtTable As DataTable, strFileName As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("sheet1"), Excel.Worksheet)


        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        'write header
        For Each dc In dtTable.Columns
            colIndex = colIndex + 1
            xlApp.Cells(1, colIndex) = dc.ColumnName
        Next
        'write data
        For Each dr In dtTable.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dtTable.Columns
                colIndex = colIndex + 1
                xlApp.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next

        xlWorkSheet.Columns.AutoFit()
        'always overwrite
        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If


        xlWorkBook.SaveAs(strFileName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("New file was created, You can find it at: " & strFileName)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnCSV_Click(sender As System.Object, e As System.EventArgs) Handles btnCSV.Click
        
        ExportFiles(False)
    End Sub
    Sub DataTable2CSV(ByVal table As DataTable, ByVal filename As String, _
    ByVal sepChar As String)
        Dim writer As System.IO.StreamWriter
        Try
            If System.IO.File.Exists(filename) Then
                System.IO.File.Delete(filename)
            End If
            writer = New System.IO.StreamWriter(filename)

            ' first write a line with the columns name
            Dim sep As String = ""
            Dim builder As New System.Text.StringBuilder
            For Each col As DataColumn In table.Columns
                builder.Append(sep).Append(col.ColumnName)
                sep = sepChar
            Next
            writer.WriteLine(builder.ToString())

            ' then write all the rows
            For Each row As DataRow In table.Rows
                sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In table.Columns
                    builder.Append(sep).Append(row(col.ColumnName))
                    sep = sepChar
                Next
                writer.WriteLine(builder.ToString())
            Next
        Finally
            If Not writer Is Nothing Then writer.Close()
        End Try
        MsgBox("New file was created, You can find it at: " & vbTab & filename)

    End Sub

End Class
   